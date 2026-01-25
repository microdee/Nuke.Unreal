using System;
using System.Threading.Tasks;
using Nuke.Cola.Tooling;
using Nuke.Common;
using Nuke.Common.IO;
using Nuke.Common.Tooling;
using Serilog;

namespace Nuke.Unreal.Platforms.Linux;

public class WindowsHostsLinux : IPlatformSdk
{
    private IPlatformSdk SelfPlatformSdk => this;
    public UnrealPlatform Host => UnrealPlatform.Win64;
    public UnrealPlatform Target => UnrealPlatform.Linux;

    private static string? GetEpicToolchainName(string unrealVersion) => unrealVersion switch
    {
        "5.0" => "v20_clang-13.0.1-centos7",
        "5.1" => "v20_clang-13.0.1-centos7",
        "5.2" => "v21_clang-15.0.1-centos7",
        "5.3" => "v22_clang-16.0.6-centos7",
        "5.4" => "v22_clang-16.0.6-centos7",
        "5.5" => "v23_clang-18.1.0-rockylinux8",
        "5.6" => "v25_clang-18.1.0-rockylinux8",
        "5.7" => "v26_clang-20.1.8-rockylinux8",
        _ => null
    };

    public static string? GetEpicToolchainName(INukeBuild self)
        => GetEpicToolchainName(Unreal.Version((UnrealBuild)self).VersionMinor);

    public async Task Setup(INukeBuild self)
    {
        var epicToolchainName = GetEpicToolchainName(self);
        var sdkPath = GetSdkPath(self);

        Log.Information("Setting up Linux toolchain {0} at {1}", epicToolchainName, sdkPath);
        if (!SelfPlatformSdk.Exists(self))
        {
            var url = $"https://cdn.unrealengine.com/CrossToolchain_Linux/{epicToolchainName}.exe";
            var installerPath = NukeBuild.TemporaryDirectory / "LinuxSdkTemp" / (epicToolchainName + ".exe");

            Log.Debug("    Downloading from {0} to {1}", url, installerPath);
            await HttpTasks.HttpDownloadFileAsync(url, installerPath);

            Log.Debug("    Because this installer require admin rights we will rather extract its contents with 7zip");
            SevenZip.Exe($"x -bso1 -bse1 -bsp1 -o{sdkPath} {installerPath}");
        }
        Environment.SetEnvironmentVariable("LINUX_MULTIARCH_ROOT", sdkPath, EnvironmentVariableTarget.Process);
    }

    public bool IsValid(INukeBuild self) => GetEpicToolchainName(self) != null;

    public AbsolutePath GetSdkPath(INukeBuild self)
        => SelfPlatformSdk.GetSdkVersionsPath(self) / GetEpicToolchainName(self);

    public AbsolutePath GetToolchainPath(INukeBuild self)
        => GetSdkPath(self) / "x86_64-unknown-linux-gnu";

    public PlatformSdkXMakeData GetXMakeData(INukeBuild self)
        => new($"--sdk=\"{GetToolchainPath(self)}\"");
}
