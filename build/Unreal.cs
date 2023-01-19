using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Nuke.Common.Tooling;
using Nuke.Common.IO;
using System.Collections.Concurrent;
using System.Reflection;

namespace build;

public class UnrealDotnetAssemblies
{
    public class Dlls
    {
        public Dlls(AbsolutePath location) => _engineDotnetPath = location / "Engine" / "Binaries" / "DotNET";

        private readonly AbsolutePath _engineDotnetPath;
    
        public AbsolutePath DotNETUtilities                    => _engineDotnetPath / "DotNETUtilities.dll";
        public AbsolutePath AutomationUtilsAutomation          => _engineDotnetPath / "AutomationUtils.Automation.dll";
        public AbsolutePath UnrealBuildTool                    => _engineDotnetPath / "UnrealBuildTool.exe";
        public AbsolutePath AutomationScriptsAutomationScripts => _engineDotnetPath / "AutomationScripts" / "AutomationScripts.Automation.dll";
        public AbsolutePath AutomationScriptsBuildGraph        => _engineDotnetPath / "AutomationScripts" / "BuildGraph.Automation.dll";
        public AbsolutePath AutomationScriptsGauntlet          => _engineDotnetPath / "AutomationScripts" / "Gauntlet.Automation.dll";
        public AbsolutePath AutomationScriptsLocalization      => _engineDotnetPath / "AutomationScripts" / "Localization.Automation.dll";
        public AbsolutePath AutomationScriptsWin               => _engineDotnetPath / "AutomationScripts" / "Win.Automation.dll";
        public AbsolutePath AutomationScriptsXLocLocalization  => _engineDotnetPath / "AutomationScripts" / "XLocLocalization.Automation.dll";
        public AbsolutePath AutomationScriptsAllDesktop        => _engineDotnetPath / "AutomationScripts" / "AllDesktop" / "AllDesktop.Automation.dll";
        public AbsolutePath AutomationScriptsAndroid           => _engineDotnetPath / "AutomationScripts" / "Android"    / "Android.Automation.dll";
        public AbsolutePath AutomationScriptsHoloLens          => _engineDotnetPath / "AutomationScripts" / "HoloLens"   / "HoloLens.Automation.dll";
        public AbsolutePath AutomationScriptsIOS               => _engineDotnetPath / "AutomationScripts" / "IOS"        / "IOS.Automation.dll";
        public AbsolutePath AutomationScriptsLinux             => _engineDotnetPath / "AutomationScripts" / "Linux"      / "Linux.Automation.dll";
        public AbsolutePath AutomationScriptsMac               => _engineDotnetPath / "AutomationScripts" / "Mac"        / "Mac.Automation.dll";
    }

    public UnrealDotnetAssemblies(AbsolutePath location) => DllPaths = new(location);

    public readonly Dlls DllPaths;
    
    public Assembly DotNETUtilities                    => Assembly.LoadFrom(DllPaths.DotNETUtilities);
    public Assembly AutomationUtilsAutomation          => Assembly.LoadFrom(DllPaths.AutomationUtilsAutomation);
    public Assembly UnrealBuildTool                    => Assembly.LoadFrom(DllPaths.UnrealBuildTool);
    public Assembly AutomationScriptsAutomationScripts => Assembly.LoadFrom(DllPaths.AutomationScriptsAutomationScripts);
    public Assembly AutomationScriptsBuildGraph        => Assembly.LoadFrom(DllPaths.AutomationScriptsBuildGraph);
    public Assembly AutomationScriptsGauntlet          => Assembly.LoadFrom(DllPaths.AutomationScriptsGauntlet);
    public Assembly AutomationScriptsLocalization      => Assembly.LoadFrom(DllPaths.AutomationScriptsLocalization);
    public Assembly AutomationScriptsWin               => Assembly.LoadFrom(DllPaths.AutomationScriptsWin);
    public Assembly AutomationScriptsXLocLocalization  => Assembly.LoadFrom(DllPaths.AutomationScriptsXLocLocalization);
    public Assembly AutomationScriptsAllDesktop        => Assembly.LoadFrom(DllPaths.AutomationScriptsAllDesktop);
    public Assembly AutomationScriptsAndroid           => Assembly.LoadFrom(DllPaths.AutomationScriptsAndroid);
    public Assembly AutomationScriptsHoloLens          => Assembly.LoadFrom(DllPaths.AutomationScriptsHoloLens);
    public Assembly AutomationScriptsIOS               => Assembly.LoadFrom(DllPaths.AutomationScriptsIOS);
    public Assembly AutomationScriptsLinux             => Assembly.LoadFrom(DllPaths.AutomationScriptsLinux);
    public Assembly AutomationScriptsMac               => Assembly.LoadFrom(DllPaths.AutomationScriptsMac);
}

public record UnrealEngineInstance(string Version, AbsolutePath Location, UnrealDotnetAssemblies Assemblies);

public static class Unreal
{
    private static AbsolutePath _locatorPath = null;
    public static AbsolutePath LocatorPath => _locatorPath ??= BuildCommon.GetContentsFolder() / "UnrealLocator" / "UnrealLocator.exe";

    private static Tool _locator = null;
    public static Tool Locator => _locator ??= ToolResolver.GetLocalTool(LocatorPath);

    private static readonly ConcurrentDictionary<string, UnrealEngineInstance> Instances = new();

    public static UnrealEngineInstance GetInstance(string version) => Instances.GetOrAdd(version, v =>
    {
        var location = (AbsolutePath) Locator(v, logOutput: false).Single().Text;
        return new(v, location, new(location));
    });
}