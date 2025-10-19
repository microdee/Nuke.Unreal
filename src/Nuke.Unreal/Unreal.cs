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
    /// <summary>
    /// A collection of utilities around basic functions regarding the environment of the Engine
    /// we're working with.
    /// </summary>
    public static class Unreal
    {
        /// <summary>
        /// Frankly this is not really relevant anymore
        /// </summary>
        public static readonly HashSet<AbsolutePath>? EngineSearchPaths;

        /// <summary>
        /// Once the Engine location is found for the current session, it ain't gonna move around,
        /// so we cache it.
        /// </summary>
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

        /// <summary>
        /// Common `JsonSerializerSettings` for Unreal conventions of JSON format
        /// </summary>
        public static readonly JsonSerializerSettings JsonReadSettings = new()
        {
            MissingMemberHandling = MissingMemberHandling.Ignore,
            DefaultValueHandling = DefaultValueHandling.Populate,
            NullValueHandling = NullValueHandling.Include,
            Converters = {
                new StringEnumConverter(false)
            }
        };

        /// <summary>
        /// Write data in JSON with Unreal conventions of JSON format
        /// </summary>
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

        /// <summary>
        /// In the rare and unlikely case that the Engine location may have changed during one
        /// session
        /// </summary>
        public static void InvalidateEnginePathCache() => EnginePathCache = null;

        /// <summary>
        /// Get the Unreal Engine path based on an input association text.
        /// (version, GUID or absolute path)
        /// </summary>
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

        /// <summary>
        /// Get high-level version of currently used Engine
        /// </summary>
        public static EngineVersion Version(UnrealBuild build) => build.GetEngineVersionFromProject();

        /// <summary>
        /// Create a compatibility flag mask which indicates that a feature is available un-broken
        /// in given and the following versions of Unreal Engine
        /// </summary>
        public static UnrealCompatibility AndLater(this UnrealCompatibility compatibility)
            => ~(compatibility - 1);

        /// <summary>
        /// Are we working with UE4
        /// </summary>
        public static bool Is4(UnrealBuild build) => Version(build).SemanticalVersion.Major == 4;
        
        /// <summary>
        /// Are we working with UE5
        /// </summary>
        public static bool Is5(UnrealBuild build) => Version(build).SemanticalVersion.Major == 5;

        /// <summary>
        /// Is given path a vanilla engine most probably installed via the Marketplace?
        /// </summary>
        public static bool IsInstalled(AbsolutePath enginePath)
            => (enginePath / "Engine" / "Build" / "InstalledBuild.txt").FileExists();

        /// <summary>
        /// Are we working with a vanilla engine most probably installed via the Marketplace?
        /// </summary>
        public static bool IsInstalled(EngineVersion ofVersion)
            => IsInstalled(ofVersion.EnginePath);

        /// <summary>
        /// Are we working with a vanilla engine most probably installed via the Marketplace?
        /// </summary>
        public static bool IsInstalled(UnrealBuild build)
            => IsInstalled(GetEnginePath(build));

        /// <summary>
        /// Is given path an engine built from source?
        /// </summary>
        public static bool IsSource(AbsolutePath enginePath)
            => !IsInstalled(enginePath);

        /// <summary>
        /// Are we working with an engine built from source?
        /// </summary>
        public static bool IsSource(EngineVersion ofVersion)
            => IsSource(ofVersion.EnginePath);

        /// <summary>
        /// Are we working with an engine built from source?
        /// </summary>
        public static bool IsSource(UnrealBuild build)
            => IsSource(GetEnginePath(build));

        public static AbsolutePath GetEnginePath(UnrealBuild build)
            => Version(build).EnginePath;

        /// <summary>
        /// Get the current development platform Nuke.Unreal is ran on.
        /// </summary>
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

        /// <summary>
        /// On Mac many Unreal tools need the Mono bootstrap.
        /// </summary>
        public static AbsolutePath MacRunMono(EngineVersion ofVersion) =>
            ofVersion.EnginePath / "Engine" / "Build" / "BatchFiles" / "Mac" / "RunMono.sh";

        /// <summary>Prepare invocation for UBT</summary>
        /// <returns>A Tool delegate for UBT</returns>
        public static Tool BuildTool(EngineVersion ofVersion)
        {
            var ubtPath = ofVersion.SemanticalVersion.Major >= 5
                ? ofVersion.EnginePath / "Engine" / "Binaries" / "DotNET" / "UnrealBuildTool" / "UnrealBuildTool.exe"
                : ofVersion.EnginePath / "Engine" / "Binaries" / "DotNET" / "UnrealBuildTool.exe";

            return ToolResolver.GetTool(ubtPath).WithSemanticLogging();

            // TODO: MacOS: "sh", $"\"{MacRunMono(ofVersion)}\" \"{ubtPath}\" " + arguments
            // TODO: Linux: "mono", $"\"{ubtPath}\" " + arguments
        }

        /// <summary>
        /// Prepare invocation for UBT with extra fluent-API configuration
        /// </summary>
        /// <param name="ofVersion"></param>
        /// <param name="config">
        /// Auto-generated Configuration facilities mirroring UBT arguments
        /// </param>
        /// <returns>A Tool delegate for UBT</returns>
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

        /// <summary>Prepare invocation for UBT</summary>
        /// <returns>A Tool delegate for UBT</returns>
        public static Tool BuildTool(UnrealBuild build) => BuildTool(Version(build));

        /// <summary>
        /// Prepare invocation for UBT with extra fluent-API configuration
        /// </summary>
        /// <param name="build"></param>
        /// <param name="config">
        /// Auto-generated Configuration facilities mirroring UBT arguments
        /// </param>
        /// <returns>A Tool delegate for UBT</returns>
        public static Tool BuildTool(UnrealBuild build, Action<UbtConfig> config) => BuildTool(Version(build), config);

        /// <summary>Prepare invocation for UAT</summary>
        /// <returns>A Tool delegate for UAT</returns>
        public static Tool AutomationTool(EngineVersion ofVersion)
        {
            var scriptExt = RuntimeInformation.IsOSPlatform(OSPlatform.Windows) ? "bat" : "sh";
            return ToolResolver.GetTool(ofVersion.EnginePath / "Engine" / "Build" / "BatchFiles" / $"RunUAT.{scriptExt}")
                .WithSemanticLogging(filter: l =>
                    !(l.Contains("Reading chunk manifest") && l.Contains("which contains 0 entries"))
                );
        }

        /// <summary>
        /// Prepare invocation for UAT with extra fluent-API configuration
        /// </summary>
        /// <param name="ofVersion"></param>
        /// <param name="config">
        /// Auto-generated Configuration facilities mirroring UAT arguments
        /// </param>
        /// <returns>A Tool delegate for UAT</returns>
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

        /// <summary>Prepare invocation for UAT</summary>
        /// <returns>A Tool delegate for UAT</returns>
        public static Tool AutomationTool(UnrealBuild build) => AutomationTool(Version(build));

        /// <summary>
        /// Prepare invocation for UAT with extra fluent-API configuration
        /// </summary>
        /// <param name="build"></param>
        /// <param name="config">
        /// Auto-generated Configuration facilities mirroring UAT arguments
        /// </param>
        /// <returns>A Tool delegate for UAT</returns>
        public static Tool AutomationTool(UnrealBuild build, Action<UatConfig> config) => AutomationTool(Version(build), config);

        /// <summary>
        /// Clear intermediate folders of Unreal from a given folder
        /// </summary>
        public static void ClearFolder(AbsolutePath folder)
        {
            (folder / "Intermediate").ExistingDirectory()?.DeleteDirectory();
            (folder / "Binaries").ExistingDirectory()?.DeleteDirectory();
            (folder / "DerivedDataCache").ExistingDirectory()?.DeleteDirectory();
        }

        /// <summary>
        /// Read copyright info from the project's `DefaultGame.ini`
        /// </summary>
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

        /// <summary>
        /// Get a native binary tool from `Engine/Binaries` folder. Unreal tools written in C# or
        /// stored in other folders/sub-folders are not supported. You can omit the `Unreal` part
        /// of the tool name.
        /// </summary>
        /// <param name="build"></param>
        /// <param name="name">You can omit the `Unreal` part of the tool name.</param>
        /// <returns>A Tool delegate for selected Unreal tool</returns>
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
