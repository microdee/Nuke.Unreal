using System;
using System.Linq;
using System.Threading.Tasks;
using Nuke.Cola;
using Nuke.Cola.Tooling;
using Nuke.Common;
using Nuke.Common.IO;
using Nuke.Common.Tooling;
using Serilog;

namespace Nuke.Unreal.Platforms;

public record class AndroidSdkVersion(int Jdk, int Sdk, int Target, Version Ndk, Version BuildTools);

public class WindowsHostsAndroid : IPlatformSdk
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

    private static AndroidSdkVersion? GetSdkVersions(string unrealVersion) => unrealVersion switch
    {
        "5.0" => new(17, 30, 30, new(21, 4, 7075529), new(30, 0, 3)),
        "5.1" => new(17, 32, 32, new(25, 1, 8937393), new(32, 0, 0)),
        "5.2" => new(17, 32, 32, new(25, 1, 8937393), new(32, 0, 0)),
        "5.3" => new(17, 33, 33, new(25, 1, 8937393), new(33, 0, 3)),
        "5.4" => new(17, 34, 34, new(25, 1, 8937393), new(34, 0, 0)),
        "5.5" => new(17, 34, 34, new(25, 1, 8937393), new(34, 0, 0)),
        "5.6" => new(21, 35, 34, new(27, 2, 12479018), new(35, 0, 1)),
        "5.7" => new(21, 35, 34, new(27, 2, 12479018), new(35, 0, 1)),
        _ => null
    };

    public static AndroidSdkVersion? GetSdkVersions(INukeBuild self)
        => GetSdkVersions(Unreal.Version((UnrealBuild)self).VersionMinor);

    public static AbsolutePath SharedUserEngineIniPath =>
        EnvironmentInfo.SpecialFolder(SpecialFolders.LocalApplicationData).NotNull()
        / "Unreal Engine/Engine/Config/UserEngine.ini"
    ;

    public static AbsolutePath AndroidHome
    {
        get
        {
            var androidHome = EnvironmentInfo.GetVariable("ANDROID_HOME")
                ?? EnvironmentInfo.SpecialFolder(SpecialFolders.LocalApplicationData)! / "Android/Sdk"
            ;
            Environment.SetEnvironmentVariable("ANDROID_HOME", androidHome, EnvironmentVariableTarget.Process);
            return AbsolutePath.Create(androidHome);
        }
    }

    private IPlatformSdk SelfPlatformSdk => this;

    public AbsolutePath GetJdkVersionsPath(INukeBuild self) => SelfPlatformSdk.GetSdkVersionsPath(self) / "JDK";
    public AbsolutePath GetCommandlineToolsPath(INukeBuild self) => AndroidHome / "cmdline-tools/latest";

    public AbsolutePath GetSdkManagerPath(INukeBuild self) => GetCommandlineToolsPath(self) / "bin/sdkmanager.bat";

    public UnrealPlatform Host => UnrealPlatform.Win64;
    public UnrealPlatform Target => UnrealPlatform.Android;

    public async Task Setup(INukeBuild self)
    {
        var sdkVersions = GetSdkVersions(self)
            .NotNull($"Couldn't determine Android SDK/JDK/NDK versions for Unreal {Unreal.Version((UnrealBuild)self)} ")
        !;
        var jdkPath = GetJdkVersionsPath(self) / sdkVersions.Jdk.ToString();

        Log.Information("Using JDK {} at {}", sdkVersions.Jdk, jdkPath);
        if (!jdkPath.DirectoryExists())
        {
            var jdkDownloadPath = NukeBuild.TemporaryDirectory / $"OpenJDK-{sdkVersions.Jdk}.zip";
            var url = GetJdkDownloadUrl(sdkVersions.Jdk);
            Log.Debug("    Downloading JDK from {} to {}", url, jdkDownloadPath);
            await HttpTasks.HttpDownloadFileAsync(url, jdkDownloadPath);

            var extractTemp = NukeBuild.TemporaryDirectory / $"OpenJDK-{sdkVersions.Jdk}";
            Log.Debug("    Extracting to {}", extractTemp);

            jdkDownloadPath.UnZipTo(extractTemp);
            var tempJdkRoot = extractTemp.GetDirectories().First();
            Log.Debug("    Moving");
            tempJdkRoot.Move(jdkPath);
        }
        Environment.SetEnvironmentVariable("JAVA_HOME", jdkPath, EnvironmentVariableTarget.Process);

        var sdkManagerPath = GetSdkManagerPath(self);
        Log.Information("Using SDK Manager at {}", sdkVersions.Jdk, sdkManagerPath);
        if (!sdkManagerPath.FileExists())
        {
            var cmdlineToolsDownloadPath = NukeBuild.TemporaryDirectory / "AndroidCommandLineTools.zip";
            var url = "https://dl.google.com/android/repository/commandlinetools-win-13114758_latest.zip";
            Log.Debug("    Downloading JDK from {} to {}", url, cmdlineToolsDownloadPath);
            await HttpTasks.HttpDownloadFileAsync(url, cmdlineToolsDownloadPath);

            var extractTemp = NukeBuild.TemporaryDirectory / "AndroidCommandLineTools";
            Log.Debug("    Extracting to {}", extractTemp);
            cmdlineToolsDownloadPath.UnZipTo(extractTemp);

            Log.Debug("    Moving");
            (extractTemp / "cmdline-tools").Move(GetCommandlineToolsPath(self));
            Assert.FileExists(sdkManagerPath);
        }

        var sdkManager = ToolExResolver.GetTool(sdkManagerPath);

        Log.Information(
            "Installing Android SDK {} and {}, Build Tools {}, NDK {}",
            sdkVersions.Sdk,
            sdkVersions.Target,
            sdkVersions.BuildTools.ToString(3),
            sdkVersions.Ndk.ToString(3)
        );
        Log.Debug("    Accepting licenses");
        sdkManager.WithInput("yes")("--licenses");

        sdkManager(
            $"""
            "platforms;android-{sdkVersions.Sdk}"
            "build-tools;{sdkVersions.BuildTools.ToString(3)}"
            "ndk;{sdkVersions.Ndk.ToString(3)}"
            """.AsSingleLine()
        );
    }

    public bool IsValid(INukeBuild self) => GetSdkVersions(self) != null;

    public AbsolutePath GetSdkPath(INukeBuild self)
    {
        var sdkVersions = GetSdkVersions(self)
            .NotNull($"Couldn't determine Android SDK/JDK/NDK versions for Unreal {Unreal.Version((UnrealBuild)self)} ")
        !;
        return AndroidHome / $"platforms/android-{sdkVersions.Sdk}";
    }

    public AbsolutePath GetToolchainPath(INukeBuild self)
    {
        var sdkVersions = GetSdkVersions(self)
            .NotNull($"Couldn't determine Android SDK/JDK/NDK versions for Unreal {Unreal.Version((UnrealBuild)self)} ")
        !;
        return AndroidHome / "ndk" / sdkVersions.Ndk.ToString(3) / "toolchains/llvm/prebuilt/windows-x86_64";
    }
}
