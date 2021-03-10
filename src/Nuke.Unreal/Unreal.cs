using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using Nuke.Common.IO;
using static Nuke.Common.Logger;
using static Nuke.Common.ControlFlow;
using static Nuke.Common.IO.FileSystemTasks;
using System.Runtime.InteropServices;

namespace Nuke.Unreal
{
    public struct EngineVersion
    {
        public EngineVersion(string versionName, string subFolderFormat = null)
        {
            subFolderFormat ??= "UE_{0}.{1}";
            FullVersionName = versionName;

            Assert(Version.TryParse(versionName, out var semVersion), "Couldn't parse semantic version of input UE version");

            SemanticalVersion = new Version(
                semVersion.Major,
                semVersion.Minor,
                Math.Max(semVersion.Build, 0),
                0
            );

            VersionName = SemanticalVersion.Major + "." + SemanticalVersion.Minor;
            SubFolderName = string.Format(subFolderFormat, SemanticalVersion.Major, SemanticalVersion.Minor, SemanticalVersion.Build);
        }

        public string VersionName;
        public string FullVersionName;
        public string SubFolderName;
        public Version SemanticalVersion;
    }

    [Flags]
    public enum UnrealPlatform
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
        // some random locations I've encountered so far with other people
        // TODO: there's got to be a more intelligent way of doing this, but documentation is not very searchable for this
        public static readonly HashSet<AbsolutePath> EngineSearchPaths;

        static Unreal()
        {
            if(RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                EngineSearchPaths = new()
                {
                    (AbsolutePath) @"C:\Program Files\Epic Games",
                    (AbsolutePath) @"C:\Program Files\unreal_epic",
                    (AbsolutePath) @"C:\ue4",
                    (AbsolutePath) @"D:",
                    (AbsolutePath) @"D:\Epic Games",
                    (AbsolutePath) @"D:\EpicGames",
                    (AbsolutePath) @"D:\Program Files\Epic Games",
                    (AbsolutePath) @"D:\Tools\Epic Games",
                    (AbsolutePath) @"D:\ue4",
                    (AbsolutePath) @"E:\Programmes",
                };
                return;
            }
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
                EngineSearchPaths = new()
                {
                    (AbsolutePath) @"/Users/Shared/Epic Games",
                };
                return;
            }

            throw new Exception("Attempting to build on an unsupported platform");
        }

        public static AbsolutePath GetEnginePath(EngineVersion ofVersion) =>
            EngineSearchPaths
                .First(sp => Directory.Exists(sp / ofVersion.SubFolderName))
                / ofVersion.SubFolderName;

        public static UnrealPlatform GetDefaultPlatform()
        {
            if(RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                return UnrealPlatform.Win64;

            if(RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
                return UnrealPlatform.Mac;
                
            if(RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
                return UnrealPlatform.Linux;
                
            throw new Exception("Attempting to build on an unsupported platform");
        }

        public static AbsolutePath MacRunMono(EngineVersion ofVersion) =>
            GetEnginePath(ofVersion) / "Engine" / "Build" / "BatchFiles" / "Mac" / "RunMono.sh";

        public static UnrealToolOutput BuildTool(EngineVersion ofVersion, string arguments)
        {
            var ubtPath = GetEnginePath(ofVersion) / "Engine" / "Binaries" / "DotNET" / "UnrealBuildTool.exe";
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

            if(RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                return new UnrealToolOutput(uatPath, arguments);

            if(RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
                return new UnrealToolOutput("sh", $"\"{MacRunMono(ofVersion)}\" \"{uatPath}\" " + arguments);

            return new UnrealToolOutput("mono", $"\"{uatPath}\" " + arguments);
        }

        public static void ClearFolder(AbsolutePath folder)
        {
            var targetName = Path.GetFileName(folder);
            if(Directory.Exists(folder / "Intermediate"))
                DeleteDirectory(folder / "Intermediate");

            if(Directory.Exists(folder / "Binaries"))
                DeleteDirectory(folder / "Binaries");

            if(Directory.Exists(folder / "DerivedDataCache"))
                DeleteDirectory(folder / "DerivedDataCache");
        }
    }
}
