using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using Nuke.Common.IO;
using System.Runtime.InteropServices;
using Nuke.Common.Tooling;
using Newtonsoft.Json;
using Serilog;
using System.Text;
using Nuke.Unreal.Tools;
using Nuke.Cola.Tooling;
using Nuke.Common;
using Nuke.Common.Utilities;
using Newtonsoft.Json.Converters;

namespace Nuke.Unreal
{
    public static class Unreal
    {
        public static readonly HashSet<AbsolutePath>? EngineSearchPaths;

        public static AbsolutePath? EnginePathCache = null;

        static Unreal()
        {
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                // Use UnrealLocator
                return;
            }

            // TODO: Use UnrealLocator on other platforms as well
            if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
            {
                EngineSearchPaths = new()
                {
                    (AbsolutePath) @"/Users/Shared/Epic Games",
                };
                return;
            }
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
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

        public static readonly JsonSerializerSettings JsonReadSettings = new()
        {
            MissingMemberHandling = MissingMemberHandling.Ignore,
            DefaultValueHandling = DefaultValueHandling.Populate,
            NullValueHandling = NullValueHandling.Include,
            Converters = {
                new StringEnumConverter(false)
            }
        };

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

            var serializer = new JsonSerializer()
            {
                NullValueHandling = NullValueHandling.Ignore,
                Formatting = Formatting.Indented,
                Converters = {
                    new StringEnumConverter(false)
                }
            };
            serializer.Serialize(jtw, input);
            File.WriteAllText(path, sb.ToString());
        }

        public static void InvalidateEnginePathCache() => EnginePathCache = null;
        public static AbsolutePath GetEnginePath(string engineAssociation, bool ignoreCache = false)
        {
            if (!ignoreCache && EnginePathCache != null) return EnginePathCache;

            IUnrealLocator locator = RuntimeInformation.IsOSPlatform(OSPlatform.Windows)
                ? new WindowsUnrealLocator()
                : new GenericUnrealLocator();

            Log.Debug("Looking for Unreal Engine installation {0}", engineAssociation);

            EnginePathCache = locator.GetEngine(engineAssociation);
            Assert.NotNull(EnginePathCache, "Couldn't find Unreal Engine with that association");

            Log.Debug("Found at: {0}", EnginePathCache!);
            return EnginePathCache!;
        }

        public static EngineVersion Version(UnrealBuild build) => build.GetEngineVersionFromProject();

        public static bool Is4(UnrealBuild build) => Version(build).SemanticalVersion.Major == 4;
        public static bool Is5(UnrealBuild build) => Version(build).SemanticalVersion.Major == 5;

        public static bool IsInstalled(AbsolutePath enginePath)
            => (enginePath / "Engine" / "Build" / "InstalledBuild.txt").FileExists();

        public static bool IsInstalled(EngineVersion ofVersion)
            => IsInstalled(ofVersion.EnginePath);

        public static bool IsInstalled(UnrealBuild build)
            => IsInstalled(GetEnginePath(build));

        public static bool IsSource(AbsolutePath enginePath)
            => !IsInstalled(enginePath);

        public static bool IsSource(EngineVersion ofVersion)
            => IsSource(ofVersion.EnginePath);

        public static bool IsSource(UnrealBuild build)
            => IsSource(GetEnginePath(build));

        public static AbsolutePath GetEnginePath(UnrealBuild build)
            => Version(build).EnginePath;

        public static UnrealPlatformFlag GetDefaultPlatform()
        {
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                return UnrealPlatformFlag.Win64;

            if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
                return UnrealPlatformFlag.Mac;

            if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
                return UnrealPlatformFlag.Linux;

            throw new Exception("Attempting to build on an unsupported platform");
        }

        public static AbsolutePath MacRunMono(EngineVersion ofVersion) =>
            ofVersion.EnginePath / "Engine" / "Build" / "BatchFiles" / "Mac" / "RunMono.sh";

        public static Tool BuildTool(EngineVersion ofVersion)
        {
            var ubtPath = ofVersion.SemanticalVersion.Major >= 5
                ? ofVersion.EnginePath / "Engine" / "Binaries" / "DotNET" / "UnrealBuildTool" / "UnrealBuildTool.exe"
                : ofVersion.EnginePath / "Engine" / "Binaries" / "DotNET" / "UnrealBuildTool.exe";

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
                workingDirectory: ofVersion.EnginePath / "Engine" / "Source",
                logInvocation: true
            );
        }

        public static Tool BuildTool(UnrealBuild build) => BuildTool(Version(build));

        public static Tool BuildTool(UnrealBuild build, Action<UbtConfig> config) => BuildTool(Version(build), config);

        public static Tool AutomationTool(EngineVersion ofVersion)
        {
            var scriptExt = RuntimeInformation.IsOSPlatform(OSPlatform.Windows) ? "bat" : "sh";
            return ToolResolver.GetTool(ofVersion.EnginePath / "Engine" / "Build" / "BatchFiles" / $"RunUAT.{scriptExt}")
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
                workingDirectory: ofVersion.EnginePath / "Engine" / "Source",
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
            if (!File.Exists(configPath)) return "Fill in Copyright info...";

            var crLine = File.ReadAllLines(configPath)
                .FirstOrDefault(l => l.StartsWith("CopyrightNotice="));

            if (string.IsNullOrWhiteSpace(crLine)) return "Fill in Copyright info...";

            var crEntry = crLine.Split('=', 2, StringSplitOptions.TrimEntries);
            if (crEntry.Length < 2) return "Fill in Copyright info...";

            return crEntry[1];
        }

        public static Tool GetTool(UnrealBuild build, string name)
        {
            var binaries = GetEnginePath(build) / "Engine" / "Binaries" / GetDefaultPlatform().ToString();
            var ext = RuntimeInformation.IsOSPlatform(OSPlatform.Windows) ? ".exe" : "";
            var path = binaries / (name + ext);

            if (!path.FileExists())
                path = binaries / ("Unreal" + name + ext);

            Assert.FileExists(path, $"Requested tool {name} doesn't exist.");
            return ToolResolver.GetTool(path);
        }
    }
}
