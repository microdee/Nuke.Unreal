
using System;
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
        public Target Package => _ => _
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
                        + $" -clientconfig={c}"
                        + $" -archivedirectory=\"{OutPath}\""
                        + $" -applocaldirectory={appLocalDir}"
                        + " -package"
                        + " -nocompileeditor"
                        + " -skipcook"
                        + " -installed"
                        + " -stage"
                        + " -archive"
                        + " -prereqs"
                        + " -build"
                    ).WithWorkingDir(UnrealEnginePath)
                        .Run();
                });
            });
    }
}