
using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.IO.Compression;
using Nuke.Common.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Nuke.Common;
using Nuke.Common.Utilities.Collections;
using static Nuke.Common.IO.FileSystemTasks;
using static Nuke.Common.IO.PathConstruction;
using static Nuke.Common.Logger;
using static Nuke.Common.ControlFlow;

namespace Nuke.Unreal
{
    public abstract class ProjectTargets : CommonTargets
    {
        public virtual bool PackagePak => false;
        
        public virtual IEnumerable<string> PackageArguments
        {
            get
            {
                var result = new List<string> {
                    "-skipcook",
                    "-nocompileeditor",
                    "-installed",
                    "-prereqs",
                    "-nop4",
                    "-utf8output",
                    "-manifests",
                };
                if(PackagePak)
                {
                    result.Add("-pak");
                }
                return result;
            }
        }

        public virtual Target Package => _ => _
            .Description("Same as running Package Project from Editor")
            .DependsOn(Cook)
            .Executes(() =>
            {
                var appLocalDir = UnrealEnginePath / "Engine" / "Binaries" / "ThirdParty" / "AppLocalDependencies";
                Config.ForEach(c =>
                {
                    Unreal.AutomationToolBatch(
                        GetEngineVersionFromProject(),
                        "BuildCookRun"
                        + $" -ScriptsForProject=\"{ToProject}\""
                        + $" -project=\"{ToProject}\""
                        + $" -target={UnrealProjectName}"
                        + $" -targetplatform={TargetPlatform}"
                        + $" -platform={TargetPlatform}"
                        + $" -clientconfig={c}"
                        + $" -archivedirectory=\"{OutPath}\""
                        + $" -applocaldirectory={appLocalDir}"
                        + " -build"
                        + " -package"
                        + " -stage"
                        + " -archive"
                        + " " + string.Join(' ', PackageArguments)
                    )
                    .WithWorkingDir(UnrealEnginePath)
                    .Run();
                });
            });
    }
}
/*
-project=E:\work\14\s\RW1.uproject
-noP4
-utf8output
-ue4exe=UE4Editor-Cmd.exe
-manifests
-stagingdirectory=E:\work\14\a\s
-archivedirectory=E:\work\14\a\__default
-clientconfig=Development
-platform=Win64
-server
-serverconfig=Development
-serverplatform=Linux
-createreleaseversion=core
-map=ToolsTest+WarpTest+InteractionTest+ReviewRoom+AttachmentSystemTest+ChartsTest+UserRoom+Symposium+MeetingRoom+CompanyRoom_01+MenuCansTutorial+MenuFilesTutorial+GeneralMenuTutorialMain+GeneralMenuTutorialUserRoom+LevelStreamingTest
-skipbuild
-skipcook
-pak
-package
-stage
-archive
-CookOutputDir=E:\work\14\a\c
-compile
*/