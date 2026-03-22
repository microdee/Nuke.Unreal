using System;
using System.Collections.Generic;
using Nuke.Common;
using Nuke.Common.IO;
using Nuke.Unreal.Platforms.Android;
using Nuke.Unreal.Platforms.Linux;

namespace Nuke.Unreal.Platforms;

using PlatformSdkCollection = Dictionary<(UnrealPlatform Host, UnrealPlatform Target), IPlatformSdk>;

/// <summary>
/// Static class managing <see cref="IPlatformSdk"/> implementations
/// </summary>
public static class PlatformSdkManager
{
    /// <summary>
    /// A user folder to store SDK installation files owned by Nuke.Unreal.
    /// </summary>
    public static readonly AbsolutePath PlatformSdkRoot = AbsolutePath.Create(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData))
        / "Nuke.Unreal" / "PlatformSdks"
    ;

    private static readonly PlatformSdkCollection Sdks = new();

    /// <summary>
    /// Get a platform SDK instance for the current host-platform and input target platform pair.
    /// </summary>
    /// <returns>
    /// The platform SDK instance, or null. When null is returned then either extra platform SDK considerations are
    /// not necessary for given platform combination (like Windows targeting Windows), or such an instance is not
    /// yet implemented.
    /// </returns>
    public static IPlatformSdk? GetSdk(this UnrealPlatform platform)
        => Sdks.TryGetValue((Unreal.GetHostPlatform(), platform), out var sdk) ? sdk : null
    ;

    /// <summary>
    /// Register a <see cref="IPlatformSdk"/> implementation for a host-target platform pair.
    /// </summary>
    public static void Register(IPlatformSdk sdk) => Sdks[(sdk.Host, sdk.Target)] = sdk;
}
