using System;
using System.ComponentModel;
using System.IO;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Nuke.Common;
using Nuke.Common.CI;
using Nuke.Common.Execution;
using Nuke.Common.Git;
using Nuke.Common.IO;
using Nuke.Common.ProjectModel;
using Nuke.Common.Tooling;
using Nuke.Common.Tools.DotNet;
using Nuke.Common.Utilities.Collections;
using Nuke.Unreal.BoilerplateGenerators;

using static Nuke.Common.EnvironmentInfo;
using static Nuke.Common.IO.FileSystemTasks;
using static Nuke.Common.IO.PathConstruction;
using static Nuke.Common.Tools.DotNet.DotNetTasks;
using static Nuke.Common.Logger;
using static Nuke.Common.ControlFlow;
using static Nuke.Unreal.BuildCommon;

namespace Nuke.Unreal
{
    public abstract partial class CommonTargets : NukeBuild
    {
        /// <summary>
        /// Most targets read the desired UE4 version from the project file.
        /// </summary>
        [Parameter("Specify the target Unreal Engine version. By default only used by the Checkout target. Everything else should infer engine version from the project file.")]
        public virtual string UnrealVersion { get; set; }

        // not a command line parameter anymore especially when we have the UnrealLocator program
        public virtual string UnrealSubfolder { get; } = "UE_{0}";

        [Parameter("Specify a path to a custom engine version (eg.: built from source)")]
        public virtual AbsolutePath CustomEnginePath { get; set; } = null;
        
        protected override void OnBuildInitialized()
        {
            base.OnBuildInitialized();
            if(CustomEnginePath != null)
            {
                Unreal.EnginePathOverride = CustomEnginePath;
            }
        }
        
        [Parameter("Specify the output working directory for artifacts")]
        public virtual AbsolutePath OutPath { get; set; } = RootDirectory / ".deploy";

        [Parameter("Set platform for running targets")]
        public string TargetPlatform { get; set; } = Unreal.GetDefaultPlatform().ToString();

        [Parameter("The target configuration for building or packaging the project")]
        public virtual UnrealConfig[] Config { get; set; } = new [] {UnrealConfig.Development};

        [Parameter("The target execution mode for building the project (Standalone or Editor")]
        public virtual ExecMode[] RunIn { get; set; } = new [] {ExecMode.Standalone};

        public EngineVersion TargetEngineVersion => new(UnrealVersion, UnrealSubfolder, CustomEnginePath);

        protected EngineVersion GetEngineVersionFromProject() {
            var result = (ProjectObject["EngineVersionPatch"] ?? ProjectObject["EngineAssociation"]).ToString();
            if(!EngineVersion.ValidVersionString(result))
                return TargetEngineVersion;
            
            return new(result, UnrealSubfolder, CustomEnginePath);
        }

        public AbsolutePath UnrealEnginePath => Unreal.GetEnginePath(GetEngineVersionFromProject());
    }
}