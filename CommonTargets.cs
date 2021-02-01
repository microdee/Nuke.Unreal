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
using static Nuke.Common.EnvironmentInfo;
using static Nuke.Common.IO.FileSystemTasks;
using static Nuke.Common.IO.PathConstruction;
using static Nuke.Common.Tools.DotNet.DotNetTasks;
using static Nuke.Common.Logger;
using static Nuke.Common.ControlFlow;
using static Nuke.Unreal.BuildCommon;

namespace Nuke.Unreal
{
    public abstract class CommonTargets : NukeBuild
    {
        [Parameter("Specify the target Unreal Engine version")]
        public abstract string UnrealVersion { get; set; }

        [Parameter("Use the following subfolder for the specified engine version. 'UE_{0}.{1}' is the default. use '{0}' (= '4') for major and {1} for minor versions.")]
        public virtual string UnrealSubfolder { get; } = "UE_{0}.{1}";
        
        [Parameter("Specify the target Unreal Engine version")]
        public virtual string OutPath { get; set; } = ".deploy";

        public EngineVersion TargetEngineVersion => new EngineVersion(UnrealVersion, UnrealSubfolder);

        public abstract AbsolutePath ToProject { get; }

        public AbsolutePath UnrealProjectFolder => ToProject.Parent;
        public AbsolutePath UnrealPluginsFolder => UnrealProjectFolder / "Plugins";

        private JObject _projectObject;
        protected JObject ProjectObject =>
            _projectObject ?? (_projectObject = JObject.Parse(File.ReadAllText(ToProject)));

        public virtual Target CleanProject => _ => _
            .Executes(() => Unreal.ClearFolder(UnrealProjectFolder));

        public virtual Target CleanPlugins => _ => _
            .Executes(() =>
            {
                foreach(var pluginDir in Directory.EnumerateDirectories(UnrealPluginsFolder))
                {
                    Unreal.ClearFolder((AbsolutePath)pluginDir);
                }
            });

        public virtual Target CleanUnreal => _ => _
            .DependsOn(CleanProject)
            .DependsOn(CleanPlugins);

        public virtual Target GenerateProject => _ => _
            .Executes(() =>
            {
                Unreal.BuildTool(
                    TargetEngineVersion,
                    "-projectfiles " +
                    $"-project=\"{ToProject}\" " +
                    "-game -rocket -progress"
                );
            });
    }
}