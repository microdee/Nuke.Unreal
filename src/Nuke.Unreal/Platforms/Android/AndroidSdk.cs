using System;
using System.Linq;
using System.Threading.Tasks;
using Nuke.Cola;
using Nuke.Cola.Tooling;
using Nuke.Common;
using Nuke.Common.IO;
using Nuke.Common.Tooling;
using Serilog;

namespace Nuke.Unreal.Platforms.Android;

public record class AndroidSdkVersion(int Jdk, int Sdk, int Target, Version Ndk, Version BuildTools);

public abstract class AndroidSdk : IPlatformSdk
{
    public static AndroidSdkVersion? GetSdkVersions(string unrealVersion) => unrealVersion switch
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

    public static AndroidSdkVersion GetSdkVersionsChecked(INukeBuild self)
        => GetSdkVersions(self)
            .NotNull($"Couldn't determine Android SDK/JDK/NDK versions for Unreal {Unreal.Version((UnrealBuild)self)} ")
        !;

    public abstract UnrealPlatform Host { get; }
    public abstract UnrealPlatform Target { get; }
    public abstract Task Setup(INukeBuild self);
    public abstract bool IsValid(INukeBuild self);
    public abstract AbsolutePath GetSdkPath(INukeBuild self);
    public abstract string GetXmakeArguments(INukeBuild self);

    public abstract AbsolutePath GetAndroidHome(INukeBuild self);
    public abstract AbsolutePath GetNdkPath(INukeBuild self);
    public abstract AbsolutePath GetBuildToolsPath(INukeBuild self);

    public abstract Tool GetApkSigner(INukeBuild self);
}
