using System.Linq;
using Nuke.Common;
using Nuke.Common.IO;
using Nuke.Common.Utilities.Collections;

namespace Nuke.Unreal.Platforms.Android;

public static class AndroidBuildCommon
{
    public static string GetAppNameFromConfig(this INukeBuild self)
    {
        var build = (UnrealBuild)self;
        var packageNameCommands = build.ReadIniHierarchy("Engine")
            ?["/Script/AndroidRuntimeSettings.AndroidRuntimeSettings"]
            ?["PackageName"];

        return packageNameCommands?.IsEmpty() ?? true
            ? $"com.acme.{build.ProjectName}"
            : packageNameCommands.First().Value;
    }

    public static bool IsAndroidPlatform(this INukeBuild self)
        => ((UnrealBuild)self).Platform == UnrealPlatform.Android;

    public static string GetApkName(this INukeBuild self)
    {
        var build = (UnrealBuild) self;
        var androidBuild = (IAndroidBuildTargets) self;
        return build.Config[0] == UnrealConfig.Development
            ? $"{build.ProjectName}-{androidBuild.Cpu.ToString().ToLower()}"
            : $"{build.ProjectName}-Android-{build.Config[0]}-{androidBuild.Cpu.ToString().ToLower()}";
    }

    public static string GetAppName(this INukeBuild self)
    {
        var androidBuild = (IAndroidBuildTargets) self;
        return androidBuild.AppName;
    }

    public static AbsolutePath GetApkFile(this INukeBuild self)
    {
        var build = (UnrealBuild) self;
        return build.ProjectFolder / "Binaries" / "Android" / (self.GetApkName() + ".apk");
    }

    public static AndroidSdk GetAndroidSdk(this INukeBuild self)
    {
        var build = (UnrealBuild) self;
        var sdk = build.Platform.GetSdk() as AndroidSdk;
        Assert.True(sdk?.IsValid(self) ?? false, "Android SDK management was unavailable.");
        return sdk!;
    }
}
