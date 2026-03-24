using System.Linq;
using Nuke.Common;
using Nuke.Common.IO;
using Nuke.Common.Utilities.Collections;

namespace Nuke.Unreal.Platforms.Android;

public static class AndroidBuildCommon
{
    public static string GetAppNameFromConfig(this IUnrealBuild build)
    {
        var packageNameCommands = build.ReadIniHierarchy("Engine")
            ?["/Script/AndroidRuntimeSettings.AndroidRuntimeSettings"]
            ?["PackageName"];

        return packageNameCommands?.IsEmpty() ?? true
            ? $"com.acme.{build.ProjectName}"
            : packageNameCommands.First().Value;
    }

    public static bool IsAndroidPlatform(this IUnrealBuild build)
        => build.Platform == UnrealPlatform.Android;

    public static string GetApkName(this IUnrealBuild build)
    {
        var androidBuild = (IAndroidBuildTargets) build;
        return build.Config[0] == UnrealConfig.Development
            ? $"{build.ProjectName}-{androidBuild.Cpu.ToString().ToLower()}"
            : $"{build.ProjectName}-Android-{build.Config[0]}-{androidBuild.Cpu.ToString().ToLower()}";
    }

    public static string GetAppName(this IUnrealBuild build)
    {
        var androidBuild = (IAndroidBuildTargets) build;
        return androidBuild.AppName;
    }

    public static AbsolutePath GetApkFile(this IUnrealBuild build)
    {
        return build.ProjectFolder / "Binaries" / "Android" / (build.GetApkName() + ".apk");
    }

    public static AndroidSdk GetAndroidSdk(this IUnrealBuild build)
    {
        var sdk = build.Platform.GetSdk() as AndroidSdk;
        Assert.True(sdk?.IsValid(build) ?? false, "Android SDK management was unavailable.");
        return sdk!;
    }
}
