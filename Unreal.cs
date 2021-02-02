using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using Nuke.Common.IO;
using static Nuke.Common.Logger;
using static Nuke.Common.ControlFlow;
using static Nuke.Common.IO.FileSystemTasks;

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

    public static class Unreal
    {
        // some random locations I've encountered so far with other people
        // TODO: there's got to be a more intelligent way of doing this, but documentation is not very searchable for this
        public static readonly HashSet<AbsolutePath> EngineSearchPaths = new() {
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

        public static AbsolutePath GetEnginePath(EngineVersion ofVersion) =>
            EngineSearchPaths
                .First(sp => Directory.Exists(sp / ofVersion.SubFolderName))
                / ofVersion.SubFolderName;

        public static UnrealToolOutput BuildTool(
            EngineVersion ofVersion,
            string arguments,
            bool compactOutput = false,
            bool explicitUnimportance = false,
            AbsolutePath workingDir = null
        ) {
            return new UnrealToolOutput(
                GetEnginePath(ofVersion) / "Engine" / "Binaries" / "DotNET" / "UnrealBuildTool.exe",
                arguments, compactOutput, explicitUnimportance, workingDir
            );
        }

        public static UnrealToolOutput AutomationToolBatch(
            EngineVersion ofVersion,
            string arguments,
            bool compactOutput = false,
            bool explicitUnimportance = false,
            AbsolutePath workingDir = null
        ) {
            return new UnrealToolOutput(
                GetEnginePath(ofVersion) / "Engine" / "Build" / "BatchFiles" / "RunUAT.bat",
                arguments, compactOutput, explicitUnimportance, workingDir
            );
        }

        public static UnrealToolOutput AutomationTool(
            EngineVersion ofVersion,
            string arguments,
            bool compactOutput = false,
            bool explicitUnimportance = false,
            AbsolutePath workingDir = null
        ) {
            return new UnrealToolOutput(
                GetEnginePath(ofVersion) / "Engine" / "Binaries" / "DotNET" / "AutomationTool.exe",
                arguments, compactOutput, explicitUnimportance, workingDir
            );
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
