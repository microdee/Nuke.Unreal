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

/// <summary>
/// Bouquet of SDK component versions used by specific Unreal version
/// </summary>
/// <param name="Jdk">Major JDK version</param>
/// <param name="Sdk">Major Android SDK requirement</param>
/// <param name="Target">Major target Android SDK</param>
/// <param name="Ndk">Very specific NDK version</param>
/// <param name="BuildTools">Very specific Build Tools version</param>
/// <param name="CMake">Very specific CMake version</param>
public record class AndroidSdkVersion(
    int Jdk,
    int Sdk,
    int Target,
    Version Ndk,
    Version BuildTools,
    Version CMake
);

/// <summary>
/// Base class for managing Android SDK on any host platform
/// </summary>
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

    public static AndroidSdkVersion? GetSdkVersions(IUnrealBuild build)
        => GetSdkVersions(Unreal.Version(build).VersionMinor);

    public static AndroidSdkVersion GetSdkVersionsChecked(IUnrealBuild build)
        => GetSdkVersions(build)
            .NotNull($"Couldn't determine Android SDK/JDK/NDK versions for Unreal {Unreal.Version(build)} ")
        !;

    public abstract UnrealPlatform Host { get; }
    public abstract UnrealPlatform Target { get; }
    public abstract Task Setup(IUnrealBuild build);
    public abstract bool IsValid(IUnrealBuild build);
    public abstract AbsolutePath GetSdkPath(IUnrealBuild build);
    public abstract PlatformSdkXMakeData GetXMakeData(IUnrealBuild build);

    public abstract AbsolutePath GetAndroidHome(IUnrealBuild build);
    public abstract AbsolutePath GetNdkPath(IUnrealBuild build);
    public abstract AbsolutePath GetBuildToolsPath(IUnrealBuild build);
    public abstract AbsolutePath GetPlatformToolsPath(IUnrealBuild build);

    public abstract Tool GetApkSigner(IUnrealBuild build);
    public abstract Tool GetAdb(IUnrealBuild build);
}
