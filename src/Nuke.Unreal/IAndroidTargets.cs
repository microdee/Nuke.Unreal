
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
        int Wchan,
        int Addr,
        string S,
        string Name
    ) {
        public static AndroidProcess Make(string line)
        {
            var r = Regex.Matches(line, @"(?<USER>\S+)\s+(?<PID>\S+)\s+(?<PPID>\S+)\s+(?<VSZ>\S+)\s+(?<RSS>\S+)\s+(?<WCHAN>\S+)\s+(?<ADDR>\S+)\s+(?<S>\S+)\s+(?<NAME>\S+)")
                .First().Groups;
            return r == null ? null : new(
                r["USER"].Value,
                int.Parse(r["PID"].Value),
                int.Parse(r["PPID"].Value),
                int.Parse(r["VSZ"].Value),
                int.Parse(r["RSS"].Value),
                int.Parse(r["WCHAN"].Value),
                int.Parse(r["ADDR"].Value),
                r["S"].Value,
                r["NAME"].Value
            );
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
            ?? $"com.epicgames.{Self<UnrealBuild>().UnrealProjectName}";

        [Parameter("Specify the full qualified android app name")]
        int? AndroidGdbPort
            => GetParameter(() => AndroidGdbPort)
            ?? 5045;

        [Parameter("Processor architecture of your target hardware")]
        AndroidProcessorArchitecture AndroidCpu
            => GetParameter(() => AndroidCpu)
            ?? AndroidProcessorArchitecture.Arm64;

        Target CleanIntermediateAndroid => _ => _
            .Description("Clean up the Android folder inside Intermediate")
            .Executes(() =>
            {
                var self = Self<UnrealBuild>();
                DeleteDirectory(self.UnrealProjectFolder / "Intermediate" / "Android");
            });

        bool GetAndroidProcess(IEnumerable<Output> output, out int pid)
        {
            pid = 0;
            var processes = new Dictionary<int, AndroidProcess>();
            foreach(var line in output)
            {
                var process = AndroidProcess.Make(line.Text);
                if (process == null) continue;
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
                proc => processes[proc.ParentPid].Name.Contains("zygote", StringComparison.InvariantCultureIgnoreCase)
            )?.Pid ?? 0;
            return pid > 0;
        }

        Target DebugOnAndroid => _ => _
            .Description(
                "Package and launch the product on android but wait for debugger."
                + " This requires ADB to be in your PATH and NDK to be correctly configured."
                + " GDB server is copied to the device, and GDB will be used to debug the application"
                + " Only executed when target-platform is set to Android"
            )
            .OnlyWhenStatic(() => Self<UnrealBuild>().TargetPlatform == UnrealPlatform.Android)
            .DependsOn<IPackageTargets>(p => p.Package)
            .Executes(() => 
            {
                var self = Self<UnrealBuild>();
                var adb = ToolResolver.GetPathTool("adb");
                var artifactFolder = self.OutPath / $"Android_{AndroidTextureMode}";
                var ndkFolderParent = (AbsolutePath) EnvironmentInfo.SpecialFolder(SpecialFolders.LocalApplicationData)
                    / "Android" / "Sdk" / "ndk";

                Assert.True(
                    ndkFolderParent.DirectoryExists(),
                    "NDK parent folder doesn't exist. Please configure your Android development environment"
                );

                var ndkFolder = (AbsolutePath) Directory.EnumerateDirectories(ndkFolderParent).First();

                Log.Information("Installing packaged app");
                var installBat = artifactFolder / Glob.Files(artifactFolder, "Install_*.bat").First();
                ProcessTasks.StartShell(installBat);

                var gdbServer = ndkFolder / "prebuilt" / $"android-{AndroidCpu.ToString().ToLower()}" / "gdbserver" / "gdbserver";
                Assert.True(gdbServer.FileExists(), "NDK didn't contain a suitable GDB server");

                adb($"push {gdbServer} /data/local/tmp/");
                adb($"shell am start -D -n {AndroidAppName}/com.epicgames.ue4.GameActivity");

                int pid = 0;
                while(true)
                {
                    var output = adb($"shell ps");
                    if (GetAndroidProcess(output, out pid))
                    {
                        break;
                    }
                    Log.Information("Waiting for process to start on device...");
                    Thread.Sleep(1000);
                }

                Log.Information("Attaching GDB server to process ID {0} listening on port {1}", pid, AndroidGdbPort);
                
                adb($"forward tcp:{AndroidGdbPort} tcp:{AndroidGdbPort}");
                adb($"shell /data/local/tmp/gdbserver :{AndroidGdbPort} --attach {pid}");
            });
    }
}