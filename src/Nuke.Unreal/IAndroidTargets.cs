
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
using Nuke.Unreal.Ini;
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

    public record AndroidBuildEnvironment(
        AbsolutePath ArtifactFolder,
        AbsolutePath AndroidHome,
        AbsolutePath NdkFolder,
        AbsolutePath BuildTools
    );

    [ParameterPrefix("Android")]
    public interface IAndroidTargets : INukeBuild
    {
        T Self<T>() where T : INukeBuild => (T)(object)this;
        T GetParameter<T>(Expression<Func<T>> expression) => EnvironmentInfo.GetParameter(expression);
        bool IsAndroidPlatform() => Self<UnrealBuild>().Platform == UnrealPlatform.Android;

        [Parameter("Select texture compression mode for Android")]
        AndroidCookFlavor[] TextureMode
            => GetParameter(() => TextureMode)
            ?? new [] {AndroidCookFlavor.Multi};

        string GetAppNameFromConfig()
        {
            var packageNameCommands = Self<UnrealBuild>().ReadIniHierarchy("Engine")
                ?["/Script/AndroidRuntimeSettings.AndroidRuntimeSettings"]
                ?["PackageName"];

            return packageNameCommands?.IsEmpty() ?? true
                ? $"com.epicgames.{Self<UnrealBuild>().ProjectName}"
                : packageNameCommands.First().Value;
        }

        [Parameter("Specify the full qualified android app name")]
        string AppName
            => GetParameter(() => AppName)
            ?? GetAppNameFromConfig();

        [Parameter("Processor architecture of your target hardware")]
        AndroidProcessorArchitecture Cpu
            => GetParameter(() => Cpu)
            ?? AndroidProcessorArchitecture.Arm64;

        [Parameter("Processor architecture of your target hardware")]
        bool NoUninstall => GetParameter(() => NoUninstall);

        [Parameter("Specify version of the Android build tools to use. Latest will be used by default, or when the specified version is not found")]
        int BuildToolVersion => GetParameter(() => BuildToolVersion);

        Target CleanIntermediateAndroid => _ => _
            .Description("Clean up the Android folder inside Intermediate")
            .OnlyWhenStatic(() => IsAndroidPlatform())
            .DependentFor<UnrealBuild>(ub => ub.Build)
            .DependentFor<IPackageTargets>(p => p.Package)
            .Executes(() =>
            {
                var self = Self<UnrealBuild>();
                DeleteDirectory(self.ProjectFolder / "Intermediate" / "Android");
            });

        AndroidBuildEnvironment AndroidBoilerplate()
        {
            var self = Self<UnrealBuild>();
            var artifactFolder = self.OutPath / $"Android_{TextureMode[0]}";
            if (!artifactFolder.DirectoryExists())
            {
                artifactFolder = self.OutPath / "Android";
            }
            Assert.DirectoryExists(
                artifactFolder,
                $"{artifactFolder} doesn't exist. Did packaging go wrong?"
            );

            var androidHome = (AbsolutePath) EnvironmentInfo.SpecialFolder(SpecialFolders.LocalApplicationData) / "Android" / "Sdk";
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

            var buildToolsParent = androidHome / "build-tools";
            var buildToolsCandidates = buildToolsParent.GlobDirectories($"{BuildToolVersion}.*");
            if (buildToolsCandidates.IsEmpty())
            {
                buildToolsCandidates = buildToolsParent.GlobDirectories("*");
            }
            var buildTools = buildToolsCandidates.Last();

            return new(artifactFolder, androidHome, ndkFolder, buildTools);
        }

        string GetApkName()
        {
            var self = Self<UnrealBuild>();
            return self.Config[0] == UnrealConfig.Development
                ? $"{self.ProjectName}-{Cpu.ToString().ToLower()}"
                : $"{self.ProjectName}-Android-{self.Config[0]}-{Cpu.ToString().ToLower()}";
        }

        AbsolutePath GetApkFile()
        {
            var self = Self<UnrealBuild>();
            return self.ProjectFolder / "Binaries" / "Android" / (GetApkName() + ".apk");
        }

        Target SignApk => _ => _
            .Description("Sign the output APK")
            .OnlyWhenStatic(() => IsAndroidPlatform())
            .TriggeredBy<IPackageTargets>(p => p.Package)
            .Before(InstallOnAndroid, DebugOnAndroid)
            .After<UnrealBuild>(ub => ub.Build)
            .Executes(() =>
            {
                var self = Self<UnrealBuild>();
                var androidRuntimeSettings = self.ReadIniHierarchy("Engine")?["/Script/AndroidRuntimeSettings.AndroidRuntimeSettings"];
                var keyStore = androidRuntimeSettings?.GetFirst("KeyStore").Value;
                var password = androidRuntimeSettings?.GetFirst("KeyStorePassword").Value;
                var keystorePath = self.ProjectFolder / "Build" / "Android" / keyStore;
                
                Assert.False(string.IsNullOrWhiteSpace(keyStore), "There was no keystore specified");
                Assert.True(keystorePath.FileExists(), "Specified keystore was not found");

                if (string.IsNullOrWhiteSpace(password))
                    password = androidRuntimeSettings?.GetFirst("KeyPassword").Value;
                    
                Assert.False(string.IsNullOrWhiteSpace(password), "There was no keystore password specified");

                // save the password in a temporary file so special characters not appreciated by batch will not cause trouble
                var kspassFile = TemporaryDirectory / "Android" / "kspass";
                if (!kspassFile.Parent.DirectoryExists())
                {
                    Directory.CreateDirectory(kspassFile.Parent);
                }
                File.WriteAllText(kspassFile, password);

                var androidEnv = AndroidBoilerplate();
                var apkSignerBat = ToolResolver.GetLocalTool(androidEnv.BuildTools / "apksigner.bat");
                apkSignerBat(
                    $"sign --ks \"{keystorePath}\" --ks-pass \"file:{kspassFile}\" \"{GetApkFile()}\""
                );
            });

        Target InstallOnAndroid => _ => _
            .Description(
                "Package and install the product on a connected android device."
                + " Only executed when target-platform is set to Android"
            )
            .OnlyWhenStatic(() => IsAndroidPlatform())
            .After<IPackageTargets>(p => p.Package)
            .After<UnrealBuild>(u => u.Build)
            .Executes(() =>
            {
                var self = Self<UnrealBuild>();
                var adb = ToolResolver.GetPathTool("adb");

                var androidEnv = AndroidBoilerplate();

                var apkFile = GetApkFile();
                Assert.True(apkFile.FileExists());

                if (!NoUninstall)
                {
                    try
                    {
                        Log.Information("Uninstall {0} (failures here are not fatal)", AppName);
                        adb($"uninstall {AppName}");
                    }
                    catch (Exception e)
                    {
                        Log.Warning(e, "Uninstallation threw errors, but that might not be a problem");
                    }
                }

                Log.Information("Installing {0}", apkFile);
                adb($"install {apkFile}");

                var storagePath = adb("shell echo $EXTERNAL_STORAGE")
                    .FirstOrDefault(o => !string.IsNullOrWhiteSpace(o.Text))
                    .Text;

                Assert.False(string.IsNullOrWhiteSpace(storagePath), "Couldn't get a storage path from the device");
                
                if (!NoUninstall)
                {
                    try
                    {
                        Log.Information("Removing existing assets from device (failures here are not fatal)");
                        adb($"shell rm -r {storagePath}/UE4Game/{self.ProjectName}");
                        adb($"shell rm -r {storagePath}/UE4Game/UE4CommandLine.txt");
                        adb($"shell rm -r {storagePath}/obb/{AppName}");
                        adb($"shell rm -r {storagePath}/Android/obb/{AppName}");
                        adb($"shell rm -r {storagePath}/Download/obb/{AppName}");
                    }
                    catch (Exception e)
                    {
                        Log.Warning(e, "Removing existing asset files threw errors, but that might not be a problem");
                    }
                }

                var obbName = $"main.1.{AppName}";
                var obbFile = androidEnv.ArtifactFolder / (obbName + ".obb");

                if (obbFile.FileExists())
                {
                    Log.Information("Installing {0}", obbFile);

                    adb($"push {obbFile} {storagePath}/obb/{AppName}/{obbName}.obb");
                }

                Log.Information("Grant READ_EXTERNAL_STORAGE and WRITE_EXTERNAL_STORAGE to the apk for reading OBB file or game file in external storage.");

                adb($"shell pm grant {AppName} android.permission.READ_EXTERNAL_STORAGE");
                adb($"shell pm grant {AppName} android.permission.WRITE_EXTERNAL_STORAGE");
                
                Log.Information("Done installing {0}", AppName);
            });

        Target DebugOnAndroid => _ => _
            .Description(
                "Launch the product on android but wait for debugger."
                + " This requires ADB to be in your PATH and NDK to be correctly configured."
                + " Only executed when target-platform is set to Android"
            )
            .OnlyWhenStatic(() => IsAndroidPlatform())
            .After(InstallOnAndroid)
            .Executes(() => 
            {
                var adb = ToolResolver.GetPathTool("adb");

                Log.Information("Running {0} but wait for a debugger to be attached", AppName);
                adb($"shell am start -D -n {AppName}/com.epicgames.ue4.GameActivity");
            });
    }
}