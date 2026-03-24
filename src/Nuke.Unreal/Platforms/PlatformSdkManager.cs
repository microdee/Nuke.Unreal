using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Nuke.Cola.BuildPlugins;
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

    internal static void RegisterSdks()
    {
        var platformSdks = new []
            {
                Assembly.GetEntryAssembly()!,
                Assembly.GetExecutingAssembly()
            }
            .SelectMany(a => a.GetTypes())
            .Distinct()
            .Where(t =>
                !t.IsAbstract
                && t.GetInterfaces().Any(i => i.FullName == "Nuke.Unreal.Platforms.IPlatformSdk")
            );
        foreach (var platformSdkType in platformSdks)
        {
            var platformSdk = (IPlatformSdk) Activator.CreateInstance(platformSdkType)!;
            Sdks[(platformSdk.Host, platformSdk.Target)] = platformSdk;
            Console.WriteLine($"Registered SDK manager for {platformSdk.Target} on {platformSdk.Host} ({platformSdkType.Name})");
        }
    }
}
