using System;
using System.Linq;
using System.Threading.Tasks;
using Nuke.Cola;
using Nuke.Cola.Tooling;
using Nuke.Common;
using Nuke.Common.IO;
using Nuke.Common.Tooling;
using Nuke.Common.Utilities;
using Serilog;

namespace Nuke.Unreal.Platforms.Android;

public class WindowsHostsAndroid : AndroidSdk
{
    public static string? GetJdkDownloadUrl(int jdk) => jdk switch
    {
        25 => "https://download.java.net/java/GA/jdk25.0.1/2fbf10d8c78e40bd87641c434705079d/8/GPL/openjdk-25.0.1_windows-x64_bin.zip",
        24 => "https://download.java.net/java/GA/jdk24.0.2/fdc5d0102fe0414db21410ad5834341f/12/GPL/openjdk-24.0.2_windows-x64_bin.zip",
        23 => "https://download.java.net/java/GA/jdk23.0.2/6da2a6609d6e406f85c491fcb119101b/7/GPL/openjdk-23.0.2_windows-x64_bin.zip",
        22 => "https://download.java.net/java/GA/jdk22.0.2/c9ecb94cd31b495da20a27d4581645e8/9/GPL/openjdk-22.0.2_windows-x64_bin.zip",
        21 => "https://download.java.net/java/GA/jdk21.0.2/f2283984656d49d69e91c558476027ac/13/GPL/openjdk-21.0.2_windows-x64_bin.zip",
        20 => "https://download.java.net/java/GA/jdk20.0.2/6e380f22cbe7469fa75fb448bd903d8e/9/GPL/openjdk-20.0.2_windows-x64_bin.zip",
        19 => "https://download.java.net/java/GA/jdk19.0.1/afdd2e245b014143b62ccb916125e3ce/10/GPL/openjdk-19.0.1_windows-x64_bin.zip",
        18 => "https://download.java.net/java/GA/jdk18.0.2/f6ad4b4450fd4d298113270ec84f30ee/9/GPL/openjdk-18.0.2_windows-x64_bin.zip",
        17 => "https://download.java.net/java/GA/jdk17.0.2/dfd4a8d0985749f896bed50d7138ee7f/8/GPL/openjdk-17.0.2_windows-x64_bin.zip",
        _ => null
    };

    public static AbsolutePath AndroidHome
    {
        get
        {
            var androidHome = EnvironmentInfo.GetVariable("ANDROID_HOME")
                ?? EnvironmentInfo.GetVariable("ANDROID_SDK_HOME")
                ?? EnvironmentInfo.GetVariable("ANDROID_SDK_ROOT")
                ?? EnvironmentInfo.SpecialFolder(SpecialFolders.LocalApplicationData)! / "Android/Sdk"
            ;
            Environment.SetEnvironmentVariable("ANDROID_HOME", androidHome, EnvironmentVariableTarget.Process);
            Environment.SetEnvironmentVariable("ANDROID_SDK_HOME", androidHome, EnvironmentVariableTarget.Process);
            return AbsolutePath.Create(androidHome);
        }
    }

    private IPlatformSdk SelfPlatformSdk => this;

    public AbsolutePath GetJdkVersionsPath(IUnrealBuild build) => SelfPlatformSdk.GetSdkVersionsPath(build) / "JDK";
    public AbsolutePath GetCommandlineToolsPath(IUnrealBuild build) => AndroidHome / "cmdline-tools/latest";

    public AbsolutePath GetSdkManagerPath(IUnrealBuild build) => GetCommandlineToolsPath(build) / "bin/sdkmanager.bat";

    public override UnrealPlatform Host => UnrealPlatform.Win64;
    public override UnrealPlatform Target => UnrealPlatform.Android;

    public override async Task Setup(IUnrealBuild build)
    {
        var sdkVersions = GetSdkVersionsChecked(build);
        var jdkPath = GetJdkVersionsPath(build) / sdkVersions.Jdk.ToString();

        Log.Information("Using JDK {0} at {1}", sdkVersions.Jdk, jdkPath);
        if (!jdkPath.DirectoryExists())
        {
            var jdkDownloadPath = NukeBuild.TemporaryDirectory / $"OpenJDK-{sdkVersions.Jdk}.zip";
            var url = GetJdkDownloadUrl(sdkVersions.Jdk);
            Log.Debug("    Downloading JDK from {0} to {1}", url, jdkDownloadPath);
            await HttpTasks.HttpDownloadFileAsync(url, jdkDownloadPath);

            var extractTemp = NukeBuild.TemporaryDirectory / $"OpenJDK-{sdkVersions.Jdk}";
            Log.Debug("    Extracting to {0}", extractTemp);

            jdkDownloadPath.UnZipTo(extractTemp);
            var tempJdkRoot = extractTemp.GetDirectories().First();
            Log.Debug("    Moving");
            tempJdkRoot.Move(jdkPath);
        }
        Environment.SetEnvironmentVariable("JAVA_HOME", jdkPath, EnvironmentVariableTarget.Process);

        if (!SelfPlatformSdk.Exists(build))
        {
            var sdkManagerPath = GetSdkManagerPath(build);
            Log.Information("Using SDK Manager at {0}", sdkVersions.Jdk, sdkManagerPath);
            if (!sdkManagerPath.FileExists())
            {
                var cmdlineToolsDownloadPath = NukeBuild.TemporaryDirectory / "AndroidCommandLineTools.zip";
                var url = "https://dl.google.com/android/repository/commandlinetools-win-13114758_latest.zip";
                Log.Debug("    Downloading Command line tools from {0} to {1}", url, cmdlineToolsDownloadPath);
                await HttpTasks.HttpDownloadFileAsync(url, cmdlineToolsDownloadPath);

                var extractTemp = NukeBuild.TemporaryDirectory / "AndroidCommandLineTools";
                Log.Debug("    Extracting to {0}", extractTemp);
                cmdlineToolsDownloadPath.UnZipTo(extractTemp);

                Log.Debug("    Moving");
                (extractTemp / "cmdline-tools").Move(GetCommandlineToolsPath(build));
                Assert.FileExists(sdkManagerPath);
            }

            var sdkManager = ToolExResolver.GetTool(sdkManagerPath);

            Log.Information(
                "Installing Android SDK {0}, Build Tools {1}, NDK {2}",
                sdkVersions.Sdk,
                sdkVersions.BuildTools.ToString(3),
                sdkVersions.Ndk.ToString(3)
            );
            Log.Debug("    Accepting licenses");
            sdkManager.WithInput(Enumerable.Repeat("y", 100)).CloseInput()("--licenses");

            // TODO: read TargetSDKVersion from *Engine.ini

            sdkManager(
                $"""
                "platforms;android-{sdkVersions.Sdk}"
                "build-tools;{sdkVersions.BuildTools.ToString(3)}"
                "ndk;{sdkVersions.Ndk.ToString(3)}"
                "cmake;{sdkVersions.CMake.ToStringAutoFieldCount()}"
                "platform-tools"
                """.AsSingleLine()
            );
        }

        Environment.SetEnvironmentVariable("NDK_ROOT", GetNdkPath(build), EnvironmentVariableTarget.Process);
        Environment.SetEnvironmentVariable("NDKROOT", GetNdkPath(build), EnvironmentVariableTarget.Process);
        var paths = EnvironmentInfo.Paths
            .Append(GetPlatformToolsPath(build).ToString())
            .Join(";")
        ;
        Environment.SetEnvironmentVariable("PATH", paths, EnvironmentVariableTarget.Process);

        Log.Information("Using Android SDK {0} at {1}", sdkVersions.Sdk, GetSdkPath(build));
        Log.Information("Using Android NDK toolchain {0} at {1}", sdkVersions.Ndk.ToString(3), GetToolchainPath(build));
    }

    public override bool IsValid(IUnrealBuild build) => GetSdkVersions(build) != null;

    public override AbsolutePath GetSdkPath(IUnrealBuild build)
        => AndroidHome / $"platforms/android-{GetSdkVersionsChecked(build).Sdk}";

    public override AbsolutePath GetAndroidHome(IUnrealBuild build) => AndroidHome;

    public override AbsolutePath GetNdkPath(IUnrealBuild build)
        => AndroidHome / "ndk" / GetSdkVersionsChecked(build).Ndk.ToString(3);

    public override AbsolutePath GetBuildToolsPath(IUnrealBuild build)
        => AndroidHome / "build-tools" / GetSdkVersionsChecked(build).BuildTools.ToString(3);

    public override ToolEx GetApkSigner(IUnrealBuild build)
        => ToolExResolver.GetTool(GetBuildToolsPath(build) / "apksigner.bat");

    public AbsolutePath GetToolchainPath(IUnrealBuild build)
        => GetNdkPath(build) / "toolchains/llvm/prebuilt/windows-x86_64";

    public override PlatformSdkXMakeData GetXMakeData(IUnrealBuild build)
        => new($"--ndk=\"{GetNdkPath(build)}\"");

    public override AbsolutePath GetPlatformToolsPath(IUnrealBuild build) => AndroidHome / "platform-tools";

    public override ToolEx GetAdb(IUnrealBuild build) => ToolExResolver.GetTool(GetPlatformToolsPath(build) / "adb.exe");
}
