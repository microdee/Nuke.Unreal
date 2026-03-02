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

public record class AndroidSdkVersion(
    int Jdk,
    int Sdk,
    int Target,
    Version Ndk,
    Version BuildTools,
    Version CMake
);

public abstract class AndroidSdk : IPlatformSdk
{
    public static AndroidSdkVersion? GetSdkVersions(string unrealVersion) => unrealVersion switch
    {
        "5.0" => new(
            Jdk: 17, Sdk: 30, Target: 30,
            Ndk:        new(21, 4, 7075529),
            BuildTools: new(30, 0, 3),
            CMake:      new(3, 10, 2, 4988404)
        ),
        "5.1" => new(
            Jdk: 17, Sdk: 32, Target: 32,
            Ndk:        new(25, 1, 8937393),
            BuildTools: new(32, 0, 0),
            CMake:      new(3, 10, 2, 4988404)
        ),
        "5.2" => new(
            Jdk: 17, Sdk: 32, Target: 32,
            Ndk:        new(25, 1, 8937393),
            BuildTools: new(32, 0, 0),
            CMake:      new(3, 10, 2, 4988404)
        ),
        "5.3" => new(
            Jdk: 17, Sdk: 33, Target: 33,
            Ndk:        new(25, 1, 8937393),
            BuildTools: new(33, 0, 3),
            CMake:      new(3, 10, 2, 4988404)
        ),
        "5.4" => new(
            Jdk: 17, Sdk: 34, Target: 34,
            Ndk:        new(25, 1, 8937393),
            BuildTools: new(34, 0, 0),
            CMake:      new(3, 22, 1, -1)
        ),
        "5.5" => new(
            Jdk: 17, Sdk: 34, Target: 34,
            Ndk:        new(25, 1, 8937393),
            BuildTools: new(34, 0, 0),
            CMake:      new(3, 22, 1, -1)
        ),
        "5.6" => new(
            Jdk: 21, Sdk: 35, Target: 34,
            Ndk:        new(27, 2, 12479018),
            BuildTools: new(35, 0, 1),
            CMake:      new(3, 22, 1, -1)
        ),
        "5.7" => new(
            Jdk: 21, Sdk: 35, Target: 34,
            Ndk:        new(27, 2, 12479018),
            BuildTools: new(35, 0, 1),
            CMake:      new(3, 22, 1, -1)
        ),
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
    public abstract PlatformSdkXMakeData GetXMakeData(INukeBuild self);

    public abstract AbsolutePath GetAndroidHome(INukeBuild self);
    public abstract AbsolutePath GetNdkPath(INukeBuild self);
    public abstract AbsolutePath GetBuildToolsPath(INukeBuild self);
    public abstract AbsolutePath GetPlatformToolsPath(INukeBuild self);

    public abstract Tool GetApkSigner(INukeBuild self);
    public abstract Tool GetAdb(INukeBuild self);
}
