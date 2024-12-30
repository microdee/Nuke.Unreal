using System;
using System.Text.RegularExpressions;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using Nuke.Common;
using Nuke.Common.IO;
using System.Runtime.InteropServices;
using Nuke.Common.Tooling;
using System.Reflection;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Serilog;

using static Nuke.Common.IO.FileSystemTasks;
using Nuke.Common.Utilities;
using System.Text;
using Nuke.Unreal.Tools;
using Nuke.Cola;
using Nuke.Cola.Tooling;

namespace Nuke.Unreal
{
    public static class Unreal
    {
        public static readonly HashSet<AbsolutePath>? EngineSearchPaths;

        public static AbsolutePath? EnginePathOverride = null;

        static Unreal()
        {
            if(RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                // Use UnrealLocator
                return;
            }

            // TODO: Use UnrealLocator on other platforms as well
            if(RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
            {
                EngineSearchPaths = new()
                {
                    (AbsolutePath) @"/Users/Shared/Epic Games",
                };
                return;
            }
            if(RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
            {
                // TODO: build and use UnrealLocator on linux
                EngineSearchPaths = new()
                {
                    (AbsolutePath) @"/Users/Shared/Epic Games",
                };
                return;
            }

            throw new Exception("Attempting to build on an unsupported platform");
        }

        public static void WriteJson(object input, AbsolutePath path)
        {
            var sb = new StringBuilder();
            var sw = new StringWriter(sb);

            using var jtw = new JsonTextWriter(sw)
            {
                Formatting = Formatting.Indented,
                Indentation = 1,
                IndentChar = '\t'
            };
            
            new JsonSerializer().Serialize(jtw, input);
            File.WriteAllText(path, sb.ToString());
        }

        public static AbsolutePath GetUnrealLocatorPath()
        {
            if(RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                return BuildCommon.GetContentsFolder() / "UnrealLocator" / "UnrealLocator.exe";
            }
            throw new ApplicationException("Trying to get unreal locator on an unsupported platform.");
        }

        public static Tool UnrealLocator => ToolResolver.GetTool(GetUnrealLocatorPath());

        public static AbsolutePath GetEnginePath(string engineAssociation)
        {
            if(EnginePathOverride != null) return EnginePathOverride;

            if(RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                Log.Debug("Looking for Unreal Engine installation:");
                string location = UnrealLocator(engineAssociation, logOutput: false).Single().Text;
                Log.Debug("Found at: {0}", location);
                EnginePathOverride = (AbsolutePath) location;
                return (AbsolutePath) location;
            }

            throw new FileNotFoundException("No Unreal Engine installation could be found.");
        }
        
        public static EngineVersion Version(UnrealBuild build) => build.GetEngineVersionFromProject();

        public static bool Is4(UnrealBuild build) => Version(build).SemanticalVersion.Major == 4;
        public static bool Is5(UnrealBuild build) => Version(build).SemanticalVersion.Major == 5;

        public static AbsolutePath GetEnginePath(EngineVersion ofVersion)
        {
            if(EnginePathOverride != null) return EnginePathOverride;

            if(RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                return GetEnginePath(ofVersion.VersionName);
            }

            throw new FileNotFoundException("No Unreal Engine installation could be found.");
        }
        public static AbsolutePath GetEnginePath(UnrealBuild build) => GetEnginePath(Version(build));

        public static UnrealPlatformFlag GetDefaultPlatform()
        {
            if(RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                return UnrealPlatformFlag.Win64;

            if(RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
                return UnrealPlatformFlag.Mac;
                
            if(RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
                return UnrealPlatformFlag.Linux;
                
            throw new Exception("Attempting to build on an unsupported platform");
        }

        public static AbsolutePath MacRunMono(EngineVersion ofVersion) =>
            GetEnginePath(ofVersion) / "Engine" / "Build" / "BatchFiles" / "Mac" / "RunMono.sh";

        public static Tool BuildTool(EngineVersion ofVersion)
        {
            var ubtPath = ofVersion.SemanticalVersion.Major >= 5
                ? GetEnginePath(ofVersion) / "Engine" / "Binaries" / "DotNET" / "UnrealBuildTool" / "UnrealBuildTool.exe"
                : GetEnginePath(ofVersion) / "Engine" / "Binaries" / "DotNET" / "UnrealBuildTool.exe";
            
            return ToolResolver.GetTool(ubtPath).WithSemanticLogging();

            // TODO: MacOS: "sh", $"\"{MacRunMono(ofVersion)}\" \"{ubtPath}\" " + arguments
            // TODO: Linux: "mono", $"\"{ubtPath}\" " + arguments
        }

        public static Tool BuildTool(EngineVersion ofVersion, Action<UbtConfig> config)
        {
            var toolConfig = new UbtConfig();
            config?.Invoke(toolConfig);
            return BuildTool(ofVersion).With(
                arguments: $"{toolConfig.Gather(ofVersion):nq}",
                workingDirectory: GetEnginePath(ofVersion) / "Engine" / "Source",
                logInvocation: true
            );
        }

        public static Tool BuildTool(UnrealBuild build) => BuildTool(Version(build));

        public static Tool BuildTool(UnrealBuild build, Action<UbtConfig> config) => BuildTool(Version(build), config);

        public static Tool AutomationTool(EngineVersion ofVersion)
        {
            var scriptExt = RuntimeInformation.IsOSPlatform(OSPlatform.Windows) ? "bat" : "sh";
            return ToolResolver.GetTool(GetEnginePath(ofVersion) / "Engine" / "Build" / "BatchFiles" / $"RunUAT.{scriptExt}")
                .WithSemanticLogging(filter: l =>
                    !(l.Contains("Reading chunk manifest") && l.Contains("which contains 0 entries"))
                );
        }

        public static Tool AutomationTool(EngineVersion ofVersion, Action<UatConfig> config)
        {
            var toolConfig = new UatConfig();
            config?.Invoke(toolConfig);
            return AutomationTool(ofVersion).With(
                arguments: $"{toolConfig.Gather(ofVersion):nq}",
                workingDirectory: GetEnginePath(ofVersion) / "Engine" / "Source",
                logInvocation: true
            );
        }

        public static Tool AutomationTool(UnrealBuild build) => AutomationTool(Version(build));

        public static Tool AutomationTool(UnrealBuild build, Action<UatConfig> config) => AutomationTool(Version(build), config);

        public static void ClearFolder(AbsolutePath folder)
        {
            (folder / "Intermediate").DeleteDirectory();
            (folder / "Binaries").DeleteDirectory();
            (folder / "DerivedDataCache").DeleteDirectory();
        }

        public static string ReadCopyrightFromProject(AbsolutePath projectFolder)
        {
            var configPath = projectFolder / "Config" / "DefaultGame.ini";
            if(!File.Exists(configPath)) return "Fill in Copyright info...";

            var crLine = File.ReadAllLines(configPath)
                .FirstOrDefault(l => l.StartsWith("CopyrightNotice="));
            
            if(string.IsNullOrWhiteSpace(crLine)) return "Fill in Copyright info...";

            var crEntry = crLine.Split('=', 2, StringSplitOptions.TrimEntries);
            if(crEntry.Length < 2) return "Fill in Copyright info...";

            return crEntry[1];
        }
    }
}
