
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
    public enum UnrealConfig
    {
        Debug,
        DebugGame,
        Development,
        Shipping
    }

    public abstract class ProjectTargets : CommonTargets
    {
        [Parameter("The target packaged application configuration")]
        public virtual UnrealConfig BuildConfig { get; set; } = UnrealConfig.Development;

        [Parameter("The target packaged application configuration")]
        public virtual AbsolutePath CustomEnginePath { get; set; } = null;

        protected override void OnBuildInitialized()
        {
            base.OnBuildInitialized();
            if(CustomEnginePath != null)
            {
                Unreal.EnginePathOverride = CustomEnginePath;
            }
        }

        public Target Package => _ => _
            .Description("Same as running Package Project from Editor")
            .DependsOn(CookProject)
            .Executes(() => {
                var appLocalDir = Unreal.GetEnginePath(TargetEngineVersion) / "Binaries" / "ThirdParty" / "AppLocalDependencies";
                Unreal.AutomationToolBatch(
                    TargetEngineVersion,
                    "BuildCookRun"
                    + $" -ScriptsForProject=\"{ToProject}\""
                    + $" -project=\"{ToProject}\""
                    + $" -targetplatform={TargetPlatform}"
                    + $" -clientconfig={BuildConfig}"
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