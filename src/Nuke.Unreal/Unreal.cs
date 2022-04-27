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

namespace Nuke.Unreal
{
    public struct EngineVersion
    {
        public static bool ValidVersionString(string versionName)
        {
            if(Guid.TryParse(versionName, out _))
            {
                return true;
            }

            var regexedComponents = Regex.Match(versionName, @"(?<version>[\W\d]+)(?<extension>\w*)");
            if(regexedComponents == null)
                return false;

            var pureVersionNamePatch = regexedComponents.Groups["version"].Value;
            return Version.TryParse(pureVersionNamePatch, out _);
        }

        public EngineVersion(string versionName, string customEnginePath = null)
        {
            FullVersionName = versionName;
            VersionName = versionName;

            PureVersionName = "";
            PureVersionNamePatch = "";
            Extension = "";
            IsEngineSource = false;
            IsEarlyAccess = false;
            SemanticalVersion = null;

            if(Guid.TryParse(versionName, out EngineSourceId))
            {
                IsEngineSource = true;
                EngineAssociation = versionName;
                var enginePath = (AbsolutePath) customEnginePath ?? Unreal.GetEnginePath(versionName);
                if(enginePath != null)
                {
                    var buildVersionPath = enginePath / "Engine" / "Build" / "Build.version";
                    if(buildVersionPath.Exists())
                    {
                        var buildVersion = JObject.Parse(File.ReadAllText(buildVersionPath));
                        SemanticalVersion = new(
                            buildVersion.GetPropertyValue<int>("MajorVersion"),
                            buildVersion.GetPropertyValue<int>("MinorVersion"),
                            buildVersion.GetPropertyValue<int>("PatchVersion")
                        );

                        PureVersionName = $"{SemanticalVersion.Major}.{SemanticalVersion.Minor}";
                        PureVersionNamePatch = $"{SemanticalVersion.Major}.{SemanticalVersion.Minor}.{SemanticalVersion.Build}";
                    }
                }
                return;
            }

            var regexedComponents = Regex.Match(versionName, @"(?<version>[\W\d]+)(?<extension>\w*)");
            Assert.True(regexedComponents != null, "Invalid version format");

            PureVersionNamePatch = regexedComponents.Groups["version"].Value;
            Extension = regexedComponents.Groups["extension"].Value ?? "";
            IsEarlyAccess = Extension == "EA";

            Assert.True(Version.TryParse(PureVersionNamePatch, out var semVersion), "Couldn't parse semantic version of input UE version");

            SemanticalVersion = new Version(
                semVersion.Major,
                semVersion.Minor,
                Math.Max(semVersion.Build, 0),
                0
            );

            PureVersionName = SemanticalVersion.Major + "." + SemanticalVersion.Minor;
            VersionName = PureVersionName + Extension;
            EngineAssociation = customEnginePath?.Replace('\\', '/') ?? VersionName;
        }

        public string VersionName;
        public string PureVersionName;
        public string PureVersionNamePatch;
        public string FullVersionName;
        public Version SemanticalVersion;
        public string Extension;
        public bool IsEarlyAccess;
        public bool IsEngineSource;
        public Guid EngineSourceId;
        public string EngineAssociation;
    }

    [Flags]
    public enum UnrealPlatformFlag
    {
        Win64 =         0b_00000001,
        Win32 =         0b_00000010,
        HoloLens =      0b_00000100,
        Mac =           0b_00001000,
        Linux =         0b_00010000,
        LinuxAArch64 =  0b_00100000,
        Android =       0b_01000000,
        IOS =           0b_10000000,
        AllWin =        Win32  | Win64,
        AllLinux =      Linux  | LinuxAArch64,
        AllDesktop =    AllWin | AllLinux | Mac

        // TODO: rest of the platforms
        // Engine/Source/Programs/UnrealBuildTool/Configuration/UEBuildTarget.cs
    }

    public static class Unreal
    {
        public static readonly HashSet<AbsolutePath> EngineSearchPaths;

        public static AbsolutePath EnginePathOverride = null;

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
            using(var fs = File.OpenWrite(path))
            using(var sw = new StreamWriter(fs))
            using(var jtw = new JsonTextWriter(sw) {
                Formatting = Formatting.Indented,
                Indentation = 1,
                IndentChar = '\t'
            }) {
                new JsonSerializer().Serialize(jtw, input);
            }
        }

        public static readonly AbsolutePath UnrealLocatorFolder = BuildCommon.GetContentsFolder() / "UnrealLocator";
        public static AbsolutePath GetUnrealLocator()
        {
            if(RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                return UnrealLocatorFolder / "UnrealLocator.exe";
            }
            throw new ApplicationException("Trying to get unreal locator on an unsupported platform.");
        }

        public static AbsolutePath GetEnginePath(string engineAssociation)
        {
            if(EnginePathOverride != null) return EnginePathOverride;

            if(RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                string location = null;
                Log.Debug("Looking for Unreal Engine installation:");

                string Filter(string line)
                {
                    if(string.IsNullOrWhiteSpace(line)) return line;
                    if(Path.IsPathRooted(line.Trim()))
                    {
                        location = line.Trim();
                        return "Found at: " + line;
                    }
                    return line;
                }

                var locatorPath = GetUnrealLocator();

                var locator = ProcessTasks.StartProcess(
                    locatorPath,
                    arguments: engineAssociation,
                    outputFilter: Filter
                );
                locator.WaitForExit();
                if(locator.ExitCode != 0 || string.IsNullOrWhiteSpace(location))
                {
                    throw new FileNotFoundException("No Unreal Engine installation could be found.");
                }
                EnginePathOverride = (AbsolutePath) location;
                return (AbsolutePath) location;
            }

            throw new FileNotFoundException("No Unreal Engine installation could be found.");
        }

        public static AbsolutePath GetEnginePath(EngineVersion ofVersion)
        {
            if(EnginePathOverride != null) return EnginePathOverride;

            if(RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                return GetEnginePath(ofVersion.VersionName);
            }

            throw new FileNotFoundException("No Unreal Engine installation could be found.");
        }

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

        public static UnrealToolOutput BuildTool(EngineVersion ofVersion, string arguments)
        {
            var ubtPath = GetEnginePath(ofVersion) / "Engine" / "Binaries" / "DotNET" / "UnrealBuildTool.exe";
            if(ofVersion.SemanticalVersion.Major >= 5)
            {
                ubtPath = GetEnginePath(ofVersion) / "Engine" / "Binaries" / "DotNET" / "UnrealBuildTool" / "UnrealBuildTool.exe";
            }
            if(RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                return new UnrealToolOutput(ubtPath, arguments);

            if(RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
                return new UnrealToolOutput("sh", $"\"{MacRunMono(ofVersion)}\" \"{ubtPath}\" " + arguments);

            return new UnrealToolOutput("mono", $"\"{ubtPath}\" " + arguments);
        }

        public static UnrealToolOutput AutomationToolBatch(EngineVersion ofVersion, string arguments)
        {
            var scriptExt = RuntimeInformation.IsOSPlatform(OSPlatform.Windows) ? "bat" : "sh";
            return new UnrealToolOutput(
                GetEnginePath(ofVersion) / "Engine" / "Build" / "BatchFiles" / $"RunUAT.{scriptExt}",
                arguments
            );
        }

        public static UnrealToolOutput AutomationTool(EngineVersion ofVersion, string arguments)
        {
            var uatPath = GetEnginePath(ofVersion) / "Engine" / "Binaries" / "DotNET" / "AutomationTool.exe";
            if(ofVersion.SemanticalVersion.Major >= 5)
            {
                uatPath = GetEnginePath(ofVersion) / "Engine" / "Binaries" / "DotNET" / "AutomationTool" / "AutomationTool.exe";
            }

            if(RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                return new UnrealToolOutput(uatPath, arguments);

            if(RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
                return new UnrealToolOutput("sh", $"\"{MacRunMono(ofVersion)}\" \"{uatPath}\" " + arguments);

            return new UnrealToolOutput("mono", $"\"{uatPath}\" " + arguments);
        }

        public static void ClearFolder(AbsolutePath folder)
        {
            if(Directory.Exists(folder / "Intermediate"))
                DeleteDirectory(folder / "Intermediate");

            if(Directory.Exists(folder / "Binaries"))
                DeleteDirectory(folder / "Binaries");

            if(Directory.Exists(folder / "DerivedDataCache"))
                DeleteDirectory(folder / "DerivedDataCache");
        }

        public static string ReadCopyrightFromProject(AbsolutePath projectFolder)
        {
            var configPath = projectFolder / "Config" / "DefaultGame.ini";
            if(!File.Exists(configPath)) return null;

            var crLine = File.ReadAllLines(configPath)
                .FirstOrDefault(l => l.StartsWith("CopyrightNotice="));
            
            if(string.IsNullOrWhiteSpace(crLine)) return null;

            var crEntry = crLine.Split('=', 2, StringSplitOptions.TrimEntries);
            if(crEntry.Length < 2) return null;

            return crEntry[1];
        }
    }
}
