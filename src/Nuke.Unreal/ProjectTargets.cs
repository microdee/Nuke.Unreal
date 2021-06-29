
using System;
using System.IO;
using System.IO.Compression;
using Nuke.Common.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Nuke.Common;
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
            .Executes(() => {
                var appLocalDir = Unreal.GetEnginePath(GetEngineVersionFromProject()) / "Binaries" / "ThirdParty" / "AppLocalDependencies";
                Unreal.AutomationToolBatch(
                    GetEngineVersionFromProject(),
                    "BuildCookRun"
                    + $" -ScriptsForProject=\"{ToProject}\""
                    + $" -project=\"{ToProject}\""
                    + $" -targetplatform={TargetPlatform}"
                    + $" -clientconfig={Config}"
                    + $" -archivedirectory=\"{OutPath}\""
                    + $" -applocaldirectory={appLocalDir}"
                    + " -package"
                    + " -nocompile"
                    + " -nocompileeditor"
                    + " -skipcook"
                    + " -installed"
                    + " -nop4"
                    + " -stage"
                    + " -archive"
                    + " -prereqs"
                    + " -build"
                    + " -CrashReporter"
                    + " -utf8output"
                );
            });
    }
}