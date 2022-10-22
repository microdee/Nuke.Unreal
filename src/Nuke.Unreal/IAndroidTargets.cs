
using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.IO.Compression;
using Nuke.Common.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Nuke.Common;
using Nuke.Common.Utilities.Collections;
using static Nuke.Common.IO.FileSystemTasks;
using static Nuke.Common.IO.PathConstruction;
using Nuke.Common.Tooling;
using Serilog;
using GlobExpressions;
using System.Linq.Expressions;
using System.Text.RegularExpressions;
using Microsoft.Azure.KeyVault.Models;
using System.Threading;

namespace Nuke.Unreal
{
    public class AndroidTargets : NukeBuild, IAndroidTargets
    {
        public static readonly IAndroidTargets Default = new AndroidTargets();
    }

    internal record AndroidProcess(
        string User,
        int Pid,
        int ParentPid,
        int Vsz,
        int Rss,
        string Wchan,
        int Addr,
        string S,
        string Name
    ) {
        public static AndroidProcess Make(string line)
        {
            var r = Regex.Matches(line, @"(?<USER>\S+)\s+(?<PID>\S+)\s+(?<PPID>\S+)\s+(?<VSZ>\S+)\s+(?<RSS>\S+)\s+(?<WCHAN>\S+)\s+(?<ADDR>\S+)\s+(?<S>\S+)\s+(?<NAME>\S+)")
                .FirstOrDefault()?.Groups;

            return r == null ? null : new(
                r["USER"]?.Value ?? "",
                int.TryParse(r["PID"]?.Value, out int pid) ? pid : 0,
                int.TryParse(r["PPID"]?.Value, out int ppid) ? ppid : 0,
                int.TryParse(r["VSZ"]?.Value, out int vsz) ? vsz : 0,
                int.TryParse(r["RSS"]?.Value, out int rss) ? rss : 0,
                r["WCHAN"]?.Value ?? "",
                int.TryParse(r["ADDR"]?.Value, out int addr) ? addr : 0,
                r["S"]?.Value ?? "",
                r["NAME"]?.Value ?? ""
            );
        }

        public bool IsAnyIdNull()
        {
            return Pid == 0
                || (new [] {User, S, Wchan, Name}).Any(s => string.IsNullOrWhiteSpace(s));
        }

        public override string ToString()
        {
            return $"User: {User}, Pid: {Pid}, ParentPid: {ParentPid}, Vsz: {Vsz}, Rss: {Rss}, Wchan: {Wchan}, Addr: {Addr}, S: {S}, Name: {Name}";
        }
    }

    public interface IAndroidTargets : INukeBuild
    {
        T Self<T>() where T : INukeBuild => (T)(object)this;
        T GetParameter<T>(Expression<Func<T>> expression) => EnvironmentInfo.GetParameter(expression);

        [Parameter("Select texture compression mode for Android")]
        AndroidCookFlavor[] AndroidTextureMode
            => GetParameter(() => AndroidTextureMode)
            ?? new [] {AndroidCookFlavor.Multi};

        [Parameter("Specify the full qualified android app name")]
        string AndroidAppName
            => GetParameter(() => AndroidAppName)
            ?? $"com.epicgames.{Self<UnrealBuild>().ProjectName}";
            
        [Parameter("Attach a debugger to the launched Android app")]
        bool? WithNativeDebugger => GetParameter(() => WithNativeDebugger) ?? false;

        [Parameter("Specify the port used by the debugger server")]
        int? AndroidDebugPort
            => GetParameter(() => AndroidDebugPort)
            ?? 5045;

        [Parameter("Debug the plain process instead of the one forked by Zygote")]
        bool? AndroidDebugPlainProcess
            => GetParameter(() => AndroidDebugPlainProcess)
            ?? false;

        [Parameter("Processor architecture of your target hardware")]
        AndroidProcessorArchitecture AndroidCpu
            => GetParameter(() => AndroidCpu)
            ?? AndroidProcessorArchitecture.Arm64;

        [Parameter("The debugger server to be used on Android")]
        AndroidDebuggerBackend AndroidDebugger
            => GetParameter(() => AndroidDebugger)
            ?? AndroidDebuggerBackend.GDB;

        Target CleanIntermediateAndroid => _ => _
            .Description("Clean up the Android folder inside Intermediate")
            .Executes(() =>
            {
                var self = Self<UnrealBuild>();
                DeleteDirectory(self.ProjectFolder / "Intermediate" / "Android");
            });

        bool GetAndroidProcess(IEnumerable<Output> output, out int pid)
        {
            pid = 0;
            var processes = new Dictionary<int, AndroidProcess>();
            foreach(var line in output.Skip(1))
            {
                var process = AndroidProcess.Make(line.Text);
                if (process == null) continue;
                if (process.IsAnyIdNull())
                {
                    Log.Warning("Not all data could be parsed for the following process:\n    {0}", process);
                }
                processes.Add(process.Pid, process);
            }

            var ownProcesses = from kvp in processes
                where kvp.Value.Name.Contains(AndroidAppName)
                select kvp.Value;
            
            if (ownProcesses.IsEmpty()) return false;
            if (ownProcesses.Count() == 1)
            {
                pid = ownProcesses.First().Pid;
                return true;
            }

            pid = ownProcesses.FirstOrDefault(
                proc =>
                    processes[proc.ParentPid].Name.Contains("zygote", StringComparison.InvariantCultureIgnoreCase)
                    != (AndroidDebugPlainProcess ?? false)
            )?.Pid ?? 0;
            return pid > 0;
        }

        (AbsolutePath artifactFolder, AbsolutePath androidHome, AbsolutePath ndkFolder) AndroidBoilerplate()
        {
                var self = Self<UnrealBuild>();
            var artifactFolder = self.OutPath / $"Android_{AndroidTextureMode[0]}";
            var androidHome = (AbsolutePath) EnvironmentInfo.SpecialFolder(SpecialFolders.LocalApplicationData)
                / "Android" / "Sdk";
            var ndkFolderParent = androidHome / "ndk";

            Assert.DirectoryExists(
                ndkFolderParent,
                $"{ndkFolderParent} doesn't exist. Please configure your Android development environment"
            );

            var ndkFolder = (AbsolutePath) Directory.EnumerateDirectories(ndkFolderParent).FirstOrDefault();
            
            Assert.NotNull(
                ndkFolder,
                "There are no NDK subfolders. Please configure your Android development environment"
            );

            return (artifactFolder, androidHome, ndkFolder);
        }

        Target DebugOnAndroid => _ => _
            .Description(
                "Package and launch the product on android but wait for debugger."
                + " This requires ADB to be in your PATH and NDK to be correctly configured."
                + " If --with-native-debugger is set select a debugger server which will be"
                + " copied to the device, and will be attached to the just-started application."
                + " Only executed when target-platform is set to Android"
            )
            .OnlyWhenStatic(() => Self<UnrealBuild>().Platform == UnrealPlatform.Android)
            .DependsOn<IPackageTargets>(p => p.Package)
            .Executes(() => 
            {
                var self = Self<UnrealBuild>();
                var adb = ToolResolver.GetPathTool("adb");

                var (artifactFolder, androidHome, ndkFolder) = AndroidBoilerplate();

                var apkName = self.Config[0] == UnrealConfig.Development
                    ? $"{self.ProjectName}-{AndroidCpu.ToString().ToLower()}"
                    : $"{self.ProjectName}-Android-{self.Config[0]}-{AndroidCpu.ToString().ToLower()}";

                var apkFile = artifactFolder / (apkName + ".apk");

                try
                {
                    Log.Information("Uninstall {0} (failures here are not fatal)", AndroidAppName);
                    adb($"uninstall {AndroidAppName}");
                }
                catch (Exception e)
                {
                    Log.Warning(e, "Uninstallation threw errors, but that might not be a problem");
                }

                Log.Information("Installing {0}", apkFile);
                adb($"install {apkFile}");

                var storagePath = adb("shell echo $EXTERNAL_STORAGE")
                    .FirstOrDefault(o => !string.IsNullOrWhiteSpace(o.Text))
                    .Text;

                Assert.False(string.IsNullOrWhiteSpace(storagePath), "Couldn't get a storage path from the device");
                
                try
                {
                    Log.Information("Removing existing assets from device (failures here are not fatal)");
                    adb($"shell rm -r {storagePath}/UE4Game/{self.ProjectName}");
                    adb($"shell rm -r {storagePath}/UE4Game/UE4CommandLine.txt");
                    adb($"shell rm -r {storagePath}/obb/{AndroidAppName}");
                    adb($"shell rm -r {storagePath}/Android/obb/{AndroidAppName}");
                    adb($"shell rm -r {storagePath}/Download/obb/{AndroidAppName}");
                }
                catch (Exception e)
                {
                    Log.Warning(e, "Removing existing asset files threw errors, but that might not be a problem");
                }

                var obbName = $"main.1.{AndroidAppName}";
                var obbFile = artifactFolder / (obbName + ".obb");

                if (obbFile.FileExists())
                {
                    Log.Information("Installing {0}", obbFile);

                    adb($"push {obbFile} {storagePath}/obb/{AndroidAppName}/{obbName}.obb");
                }

                Log.Information("Grant READ_EXTERNAL_STORAGE and WRITE_EXTERNAL_STORAGE to the apk for reading OBB file or game file in external storage.");

                adb($"shell pm grant {AndroidAppName} android.permission.READ_EXTERNAL_STORAGE");
                adb($"shell pm grant {AndroidAppName} android.permission.WRITE_EXTERNAL_STORAGE");
                
                Log.Information("Done installing {0}", AndroidAppName);

                // TODO: remove this feature, didn't work out
                if (WithNativeDebugger ?? false)
                {
                    Log.Information("Copying {0} from NDK to device", AndroidDebugger.ServerProgramName);

                    var server = ndkFolder / AndroidDebugger.ServerProgramPath(AndroidCpu);
                    Assert.True(server.FileExists(), $"NDK didn't contain a suitable {AndroidDebugger.ServerProgramName}");

                    var serverFolderTmp = "/data/local/tmp";
                    var serverFolderUser = $"/data/user/0/{AndroidAppName}";

                    adb($"push {server} {serverFolderTmp}/");
                    adb($"shell chmod 775 {serverFolderTmp}/{AndroidDebugger.ServerProgramName}");

                    Log.Information("Duplicating {0} to be used by {1}", AndroidDebugger.ServerProgramName, AndroidAppName);
                    adb($"shell run-as {AndroidAppName} cp {serverFolderTmp}/{AndroidDebugger.ServerProgramName} {serverFolderUser}/{AndroidDebugger.ServerProgramName}");

                    var waitForDebugger = AndroidDebugger == AndroidDebuggerBackend.LLDB ? " -D" : "";

                    adb($"shell am start{waitForDebugger} -n {AndroidAppName}/com.epicgames.ue4.GameActivity");
                    adb($"forward tcp:{AndroidDebugPort} tcp:{AndroidDebugPort}");

                    int pid = 0;
                    while(true)
                    {
                        var output = adb($"shell ps", logOutput: false);
                        if (GetAndroidProcess(output, out pid))
                        {
                            break;
                        }
                        Log.Information("Waiting for process to start on device...");
                        Thread.Sleep(1000);
                    }

                    if (AndroidDebugger == AndroidDebuggerBackend.GDB)
                    {
                        Log.Information("Attaching gdbserver to process ID {0} listening on port {1}", pid, AndroidDebugPort);
                    }
                    if (AndroidDebugger == AndroidDebuggerBackend.LLDB)
                    {
                        Log.Information("lldb-server is listening on port {0}.", AndroidDebugPort);
                        Log.Information("Attach to process {0} ({1}) from LLDB client", AndroidAppName, pid);
                    }

                    adb($"shell run-as {AndroidAppName} {serverFolderUser}/{AndroidDebugger.ServerProgramName} {AndroidDebugger.LaunchArguments(AndroidDebugPort ?? 5045, pid)}");
                }
                else
                {
                    Log.Information("Running {0} but wait for a debugger to be attached", AndroidAppName);
                    adb($"shell am start -D -n {AndroidAppName}/com.epicgames.ue4.GameActivity");
                }
            });
    }
}