
using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.IO.Compression;
using Nuke.Common.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Nuke.Common;
using Nuke.Common.Utilities;
using Nuke.Common.Utilities.Collections;
using static Nuke.Common.IO.FileSystemTasks;
using static Nuke.Common.IO.PathConstruction;
using Nuke.Common.Tooling;
using Nuke.Unreal.Ini;
using Serilog;
using GlobExpressions;
using System.Linq.Expressions;
using System.Text.RegularExpressions;
using System.Threading;
using System.Runtime.InteropServices;
using Nuke.Cola;

namespace Nuke.Unreal
{
    [StructLayout(LayoutKind.Sequential)]
    public struct FLASHWINFO
    {
        public UInt32 cbSize;
        public IntPtr hwnd;
        public Int32 dwFlags;
        public UInt32 uCount;
        public Int32 dwTimeout;
    }
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

    public record AndroidSdkNdkUserSettings(
        string SdkPath,
        string NdkPath,
        string JavaPath,
        string SdkApiLevel,
        string NdkApiLevel
    ) {
        
        public static readonly string SdkUserSettingsSection = "/Script/AndroidPlatformEditor.AndroidSDKSettings";

        public static string GetConfig(ConfigIni from, string key) =>
            from?[SdkUserSettingsSection]?[key].FirstOrDefault().Value;

        public static string GetConfigPath(ConfigIni from, string key) =>
            GetConfig(from, key)?.Parse(@"Path=""(?<PATH>.*)""")("PATH");

        public static void SetConfig(ConfigIni to, string key, string value)
        {
            to.FindOrAdd(SdkUserSettingsSection).Set(key, value);
        }

        public static void SetConfigPath(ConfigIni to, string key, string value)
        {
            to.FindOrAdd(SdkUserSettingsSection).Set(key, $"(Path=\"{value}\")");
        }

        public static AndroidSdkNdkUserSettings From(ConfigIni ini) => new(
            GetConfigPath(ini, "SDKPath"),
            GetConfigPath(ini, "NDKPath"),
            GetConfigPath(ini, "JavaPath"),
            GetConfig(ini, "SDKAPILevel"),
            GetConfig(ini, "NDKAPILevel")
        );

        public bool IsEmpty =>
            SdkPath == null
            && NdkPath == null
            && JavaPath == null
            && SdkApiLevel == null
            && NdkApiLevel == null;

        public ConfigIni ToConfig()
        {
            var result = new ConfigIni();
            SetConfigPath(result, "SDKPath", SdkPath);
            SetConfigPath(result, "NDKPath", NdkPath);
            SetConfigPath(result, "JavaPath", JavaPath);
            SetConfig(result, "SDKAPILevel", SdkApiLevel);
            SetConfig(result, "NDKAPILevel", NdkApiLevel);
            return result;
        }

        public override string ToString() => IsEmpty ? null : ToConfig().Serialize().Trim();

        public AndroidSdkNdkUserSettings Merge(AndroidSdkNdkUserSettings from) => this with {
            SdkPath = from?.SdkPath ?? SdkPath,
            NdkPath = from?.NdkPath ?? NdkPath,
            JavaPath = from?.JavaPath ?? JavaPath,
            SdkApiLevel = from?.SdkApiLevel ?? SdkApiLevel,
            NdkApiLevel = from?.NdkApiLevel ?? NdkApiLevel
        };
    }

    [ParameterPrefix("Android")]
    public interface IAndroidTargets : INukeBuild
    {
        T Self<T>() where T : INukeBuild => (T)(object)this;
        bool IsAndroidPlatform() => Self<UnrealBuild>().Platform == UnrealPlatform.Android;

        [Parameter("Select texture compression mode for Android")]
        AndroidCookFlavor[] TextureMode
            => TryGetValue(() => TextureMode)
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
            => TryGetValue(() => AppName)
            ?? GetAppNameFromConfig();

        [Parameter("Processor architecture of your target hardware")]
        AndroidProcessorArchitecture Cpu
            => TryGetValue(() => Cpu)
            ?? AndroidProcessorArchitecture.Arm64;

        [Parameter("Processor architecture of your target hardware")]
        bool NoUninstall => TryGetValue<bool?>(() => NoUninstall) ?? false;

        [Parameter("Specify version of the Android build tools to use. Latest will be used by default, or when the specified version is not found")]
        int? BuildToolVersion => TryGetValue<int?>(() => BuildToolVersion);

        [Parameter("Android SDK version or path. If not specified a local cache will be used. If that doesn't exist the global user settings will be used")]
        AbsolutePath SdkPath => TryGetValue(() => SdkPath);

        [Parameter("Android NDK version or path. If not specified a local cache will be used. If that doesn't exist the global user settings will be used")]
        string NdkVersion => TryGetValue(() => NdkVersion);

        [Parameter("Absolute path to Android Java. If not specified a local cache will be used. If that doesn't exist the global user settings will be used")]
        string JavaPath => TryGetValue(() => JavaPath);

        [Parameter("If not specified a local cache will be used. If that doesn't exist the global user settings will be used")]
        string SdkApiLevel => TryGetValue(() => SdkApiLevel);

        [Parameter("If not specified a local cache will be used. If that doesn't exist the global user settings will be used")]
        string NdkApiLevel => TryGetValue(() => NdkApiLevel);

        AbsolutePath UserEngineIniPath => (AbsolutePath)
            EnvironmentInfo.SpecialFolder(SpecialFolders.LocalApplicationData)
            / "Unreal Engine" / "Engine" / "Config" / "UserEngine.ini";

        AbsolutePath UserEngineIniCache => TemporaryDirectory
            / "Config" / "UserEngine.ini";

        AbsolutePath AndroidHome => (AbsolutePath)
            EnvironmentInfo.SpecialFolder(SpecialFolders.LocalApplicationData) / "Android" / "Sdk";

        AbsolutePath AndroidNdkRoot => AndroidHome / "ndk";
        AbsolutePath AndroidBuildToolsRoot => AndroidHome / "build-tools";

        AndroidBuildEnvironment AndroidBoilerplate()
        {
            var self = Self<UnrealBuild>();
            var artifactFolder = self.GetOutput() / $"Android_{TextureMode[0]}";
            if (!artifactFolder.DirectoryExists())
            {
                artifactFolder = self.GetOutput() / "Android";
            }
            Assert.DirectoryExists(
                artifactFolder,
                $"{artifactFolder} doesn't exist. Did packaging go wrong?"
            );

            Assert.DirectoryExists(
                AndroidNdkRoot,
                $"{AndroidNdkRoot} doesn't exist. Please configure your Android development environment"
            );

            var ndkFolder = (AbsolutePath) Directory.EnumerateDirectories(AndroidNdkRoot).FirstOrDefault();
            
            Assert.NotNull(
                ndkFolder,
                "There are no NDK subfolders. Please configure your Android development environment"
            );

            var buildToolsCandidates = BuildToolVersion == null
                ? AndroidBuildToolsRoot.GlobDirectories("*")
                : AndroidBuildToolsRoot.GlobDirectories($"{BuildToolVersion}.*");

            if (buildToolsCandidates.IsEmpty())
            {
                buildToolsCandidates = AndroidBuildToolsRoot.GlobDirectories("*");
            }
            var buildTools = buildToolsCandidates.Last();

            return new(artifactFolder, AndroidHome, ndkFolder, buildTools);
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

        Target ApplySdkUserSettings => _ => _
            .Description(
                "For some cursed reason Epic decided to store crucial project breaking build settings"
                + " in a user scoped shared location (AppData/Local). This target attempts to make"
                + " it less shared info, so one project compilation doesn't break the other one."
            )
            .OnlyWhenStatic(() => IsAndroidPlatform())
            .DependentFor<UnrealBuild>(ub => ub.Build, ub => ub.Cook)
            .DependentFor<IPackageTargets>(p => p.Package)
            .Executes(() =>
            {
                string cachedIniContent = UserEngineIniCache.FileExists() ? File.ReadAllText(UserEngineIniCache) : null;
                string sharedIniContent = UserEngineIniPath.FileExists() ? File.ReadAllText(UserEngineIniPath) : null;
                var cachedIni = ConfigIni.Parse(cachedIniContent);
                var sharedIni = ConfigIni.Parse(sharedIniContent);

                var cached = AndroidSdkNdkUserSettings.From(cachedIni);
                var shared = AndroidSdkNdkUserSettings.From(sharedIni);

                string AppendPrefix(string input) =>
                    input?.StartsWithOrdinalIgnoreCase("android-") ?? true ? input : "android-" + input;

                var input = new AndroidSdkNdkUserSettings(
                    SdkPath,
                    NdkVersion == null ? null : AndroidNdkRoot.GetVersionSubfolder(NdkVersion),
                    JavaPath,
                    AppendPrefix(SdkApiLevel),
                    AppendPrefix(NdkApiLevel)
                );

                if (input.IsEmpty && cached.IsEmpty)
                {
                    Log.Information("No local change is requested");
                    if (!shared.IsEmpty)
                    {
                        Log.Information("User scoped configuration is:\n" + shared.ToString());
                    }
                    return;
                }

                Log.Debug("SDK User settings are");
                Log.Debug("User Scoped:\n" + (shared.ToString() ?? "none"));
                Log.Debug("Cached:\n" + (cached.ToString() ?? "none"));
                Log.Debug("Command Line:\n" + (input.ToString() ?? "none"));

                var result = shared.Merge(cached).Merge(input);

                Log.Information("Result:\n" + (result.ToString() ?? "none"));

                if (!result.IsEmpty)
                {
                    Log.Information("Writing configuration to cache");
                    Directory.CreateDirectory(UserEngineIniCache.Parent);
                    File.WriteAllText(UserEngineIniCache, result.ToString());
                    Log.Information("Writing configuration to User shared settings");
                    Directory.CreateDirectory(UserEngineIniPath.Parent);
                    File.WriteAllText(UserEngineIniPath, result.ToString());
                }
            });

        Target CleanIntermediateAndroid => _ => _
            .Description("Clean up the Android folder inside Intermediate")
            .OnlyWhenStatic(() => IsAndroidPlatform())
            .DependentFor<UnrealBuild>(ub => ub.Build)
            .DependentFor<IPackageTargets>(p => p.Package)
            .Executes(() =>
            {
                var self = Self<UnrealBuild>();
                (self.ProjectFolder / "Intermediate" / "Android").DeleteDirectory();
            });

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
                var apkSignerBat = ToolResolver.GetTool(androidEnv.BuildTools / "apksigner.bat");
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

        private void FinishKeyReminder()
        {
            var (Left, Top) = Console.GetCursorPosition();
            Console.WriteLine("Press Escape when finished...");
            Console.SetCursorPosition(Left, Top);
        }

        private static readonly Regex ComponentFromPathRegex = new Regex(@"/(?:org|com|extensions?)/.*$", RegexOptions.Multiline | RegexOptions.IgnoreCase);

        private static string GetComponentFromPath(AbsolutePath path) =>
            ComponentFromPathRegex.Match(path.ToString().Replace('\\', '/'))?.Value;

        private static bool ArePathsSharingComponents(AbsolutePath a, AbsolutePath b)
        {
            var ac = GetComponentFromPath(a);
            var bc = GetComponentFromPath(b);
            return ac?.EqualsOrdinalIgnoreCase(bc ?? "") ?? false;
        }

        private static AbsolutePath FindMatchingComponentPath(AbsolutePath reference, AbsolutePath root, bool lookForFiles)
        {
            var target = root.SubTreeProject()
                .Where(s => s.ToString().Replace('\\', '/').ContainsOrdinalIgnoreCase("java/src"));
                
            if (lookForFiles)
            {
                target = target.Concat(target.SelectMany(d => d.GlobFiles("*.*")));
            }
            return target.FirstOrDefault(s => ArePathsSharingComponents(reference, s));
        }

        Target JavaDevelopmentService => _ => _
            .Description(
                "This is a service which synchronizes Java sources from the Intermediate Gradle project back to plugin sources."
                + "\nHit Escape when it is finished."
                + "\nThis Target assumes the plugin Java sources are also organized into the package compliant name pattern (com/company/product/etc)"
            )
            .After<UnrealBuild>(u => u.Build)
            .After<IPackageTargets>(p => p.Package)
            .Executes(() =>
            {
                var self = Self<UnrealBuild>();
                var gradleProjectFolder = self.ProjectFolder / "Intermediate" / "Android" / "arm64" / "gradle";
                var intermediateJavaSourcesFolder = gradleProjectFolder / "app" / "src" / "main" / "java";
                var searchRoot = self.PluginsFolder;

                Assert.DirectoryExists(
                    intermediateJavaSourcesFolder,
                    "Generated Gradle project doesn't exist, did you successfully build the project for Anroid?"
                    + "\nnuke build --platform Android"
                );

                using var watcher = new FileSystemWatcher(intermediateJavaSourcesFolder)
                {
                    NotifyFilter = NotifyFilters.LastWrite
                        | NotifyFilters.DirectoryName
                        | NotifyFilters.FileName,
                    EnableRaisingEvents = true,
                    IncludeSubdirectories = true
                };

                void FileSystemEventBody(object s, FileSystemEventArgs e, bool useFileInComparison, Action<AbsolutePath, AbsolutePath> onItemDirectory, Action<AbsolutePath, AbsolutePath> onItemFile)
                {
                    var path = (AbsolutePath) ((e as RenamedEventArgs)?.OldFullPath ?? e.FullPath);
                    Log.Information("Item change: {0} | {1}", path, e.ChangeType);
                    var target = FindMatchingComponentPath(useFileInComparison ? path : path.Parent, searchRoot, useFileInComparison);
                    if (target != null)
                    {
                        Log.Information("Found matching source: {0}", target);
                        try
                        {
                            if (path.DirectoryExists()) // Changed item is directory
                            {
                                onItemDirectory?.Invoke(path, target);
                            }
                            else if (path.FileExists()) // Changed item is directory
                            {
                                onItemFile?.Invoke(path, target);
                            }
                        }
                        catch (Exception ex)
                        {
                            Log.Error(ex, "Error during reacting to file-system changes");
                        }
                    }
                    else
                    {
                        Log.Information("No matching source was found. Nothing will happen.");
                    }
                }

                watcher.Created += (s, e) => FileSystemEventBody(s, e, false,
                    (p, t) => Directory.CreateDirectory(t / p.Name),
                    (p, t) =>
                    {
                        var content = File.ReadAllText(p);
                        File.WriteAllText(t / p.Name, content);
                    }
                );

                watcher.Renamed += (s, e) => FileSystemEventBody(s, e, true,
                    (p, t) => RenameDirectory(t, e.Name, DirectoryExistsPolicy.Merge, FileExistsPolicy.OverwriteIfNewer),
                    (p, t) => RenameFile(t, e.Name, FileExistsPolicy.OverwriteIfNewer)
                );

                watcher.Deleted += (s, e) => FileSystemEventBody(s, e, true,
                    (p, t) => t.DeleteDirectory(),
                    (p, t) => t.DeleteFile()
                );

                watcher.Changed += (s, e) => FileSystemEventBody(s, e, true,
                    null,
                    (p, t) => CopyFileToDirectory(p, t.Parent, FileExistsPolicy.Overwrite)
                );

                Log.Information("Now you can start Android Studio and load the gradle project at\n{0}", gradleProjectFolder);
                Log.Information("Just close with Ctrl+C when finished");

                while(true) {
                    watcher.WaitForChanged(WatcherChangeTypes.All);
                }
            });
    }
}