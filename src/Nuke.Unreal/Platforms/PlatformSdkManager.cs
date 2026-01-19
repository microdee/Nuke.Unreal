using System;
using System.Collections.Generic;
using Nuke.Common;
using Nuke.Common.IO;

namespace Nuke.Unreal.Platforms;
using PlatformSdkCollection = Dictionary<(UnrealPlatform Host, UnrealPlatform Target), IPlatformSdk>;

public static class PlatformSdkManager
{
    public static readonly AbsolutePath PlatformSdkRoot = AbsolutePath.Create(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData))
        / "Nuke.Unreal" / "PlatformSdks"
    ;

    private static readonly PlatformSdkCollection Sdks = new()
    {
        [(UnrealPlatform.Win64, UnrealPlatform.Linux)] = new WindowsHostsLinux(),
        [(UnrealPlatform.Win64, UnrealPlatform.Android)] = new WindowsHostsAndroid()
    };

    public static IPlatformSdk? GetSdk(this UnrealPlatform platform) =>
        Sdks.TryGetValue((Unreal.GetHostPlatform(), platform), out var sdk) ? sdk : null
    ;

    public static void RegisterSdk(this UnrealPlatform platform, IPlatformSdk sdk)
        => Sdks[(Unreal.GetHostPlatform(), platform)] = sdk;
}
