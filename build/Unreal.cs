using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Nuke.Common.Tooling;
using Nuke.Common.IO;
using System.Collections.Concurrent;
using System.Reflection;
using System.IO;

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

    private Assembly LoadAssembly(AbsolutePath file)
    {
        var result = Assembly.LoadFrom(file);
        var xmlPath = file.Parent / (file.NameWithoutExtension + ".xml");
        if (xmlPath.Exists())
        {
            Towel.Meta.LoadXmlDocumentation(File.ReadAllText(xmlPath));
        }
        return result;
    }
    
    private Assembly _dotNetUtilities;
    public  Assembly  DotNETUtilities                    => _dotNetUtilities ??= LoadAssembly(DllPaths.DotNETUtilities);
    private Assembly _automationUtilsAutomation;
    public  Assembly  AutomationUtilsAutomation          => _automationUtilsAutomation ??= LoadAssembly(DllPaths.AutomationUtilsAutomation);
    private Assembly _unrealBuildTool;
    public  Assembly  UnrealBuildTool                    => _unrealBuildTool ??= LoadAssembly(DllPaths.UnrealBuildTool);
    private Assembly _automationScriptsAutomationScripts;
    public  Assembly  AutomationScriptsAutomationScripts => _automationScriptsAutomationScripts ??= LoadAssembly(DllPaths.AutomationScriptsAutomationScripts);
    private Assembly _automationScriptsBuildGraph;
    public  Assembly  AutomationScriptsBuildGraph        => _automationScriptsBuildGraph ??= LoadAssembly(DllPaths.AutomationScriptsBuildGraph);
    private Assembly _automationScriptsGauntlet;
    public  Assembly  AutomationScriptsGauntlet          => _automationScriptsGauntlet ??= LoadAssembly(DllPaths.AutomationScriptsGauntlet);
    private Assembly _automationScriptsLocalization;
    public  Assembly  AutomationScriptsLocalization      => _automationScriptsLocalization ??= LoadAssembly(DllPaths.AutomationScriptsLocalization);
    private Assembly _automationScriptsWin;
    public  Assembly  AutomationScriptsWin               => _automationScriptsWin ??= LoadAssembly(DllPaths.AutomationScriptsWin);
    private Assembly _automationScriptsXLocLocalization;
    public  Assembly  AutomationScriptsXLocLocalization  => _automationScriptsXLocLocalization ??= LoadAssembly(DllPaths.AutomationScriptsXLocLocalization);
    private Assembly _automationScriptsAllDesktop;
    public  Assembly  AutomationScriptsAllDesktop        => _automationScriptsAllDesktop ??= LoadAssembly(DllPaths.AutomationScriptsAllDesktop);
    private Assembly _automationScriptsAndroid;
    public  Assembly  AutomationScriptsAndroid           => _automationScriptsAndroid ??= LoadAssembly(DllPaths.AutomationScriptsAndroid);
    private Assembly _automationScriptsHoloLens;
    public  Assembly  AutomationScriptsHoloLens          => _automationScriptsHoloLens ??= LoadAssembly(DllPaths.AutomationScriptsHoloLens);
    private Assembly _automationScriptsIos;
    public  Assembly  AutomationScriptsIOS               => _automationScriptsIos ??= LoadAssembly(DllPaths.AutomationScriptsIOS);
    private Assembly _automationScriptsLinux;
    public  Assembly  AutomationScriptsLinux             => _automationScriptsLinux ??= LoadAssembly(DllPaths.AutomationScriptsLinux);
    private Assembly _automationScriptsMac;
    public  Assembly  AutomationScriptsMac               => _automationScriptsMac ??= LoadAssembly(DllPaths.AutomationScriptsMac);
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