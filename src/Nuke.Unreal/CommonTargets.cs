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
    public abstract class CommonTargets : NukeBuild
    {
        /// <summary>
        /// Most targets read the desired UE4 version from the project file.
        /// This property is abstract only for the default version of the Checkout target,
        /// or anything which modifies the project file.
        /// </summary>
        [Parameter("Specify the target Unreal Engine version. By default only used by the Checkout target. Everything else should infer engine version from the project file.")]
        public abstract string UnrealVersion { get; set; }

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
        public virtual string OutPath { get; set; } = ".deploy";

        [Parameter("Set platform for running targets")]
        public string TargetPlatform { get; set; } = Unreal.GetDefaultPlatform().ToString();

        public EngineVersion TargetEngineVersion => new(UnrealVersion, UnrealSubfolder, CustomEnginePath);

        public abstract AbsolutePath ToProject { get; }

        public AbsolutePath UnrealProjectFolder => ToProject.Parent;
        public AbsolutePath UnrealPluginsFolder => UnrealProjectFolder / "Plugins";

        public AbsolutePath UnrealEnginePath => Unreal.GetEnginePath(GetEngineVersionFromProject());

        public string UnrealProjectName => Path.GetFileNameWithoutExtension(ToProject);

        private JObject _projectObject;
        protected JObject ProjectObject =>
            _projectObject ?? (_projectObject = JObject.Parse(File.ReadAllText(ToProject)));

        protected EngineVersion GetEngineVersionFromProject() {
            var result = (ProjectObject["EngineVersionPatch"] ?? ProjectObject["EngineAssociation"]).ToString();
            if(!EngineVersion.ValidVersionString(result))
                return TargetEngineVersion;
            
            return new(result, UnrealSubfolder, CustomEnginePath);
        }

        [Parameter("Specify a folder containing generator specific folders for Scriban scaffolding and templates")]
        public virtual AbsolutePath TemplatesPath { get; set; } = BoilerplateGenerator.DefaultTemplateFolder;

        [Parameter("Name parameter for boilerplate generators.")]
        public string Name { get; set; }

        public Target NewModule => _ => _
            .Description("Create new module in the owning project or plugin (depending on working directory)")
            .Requires(() => Name)
            .Executes(() => 
                new ModuleGenerator().Generate(
                    TemplatesPath,
                    (AbsolutePath) Environment.CurrentDirectory,
                    Name
                )
            );

        public Target NewPlugin => _ => _
            .Description("Create a new project plugin.")
            .Requires(() => Name)
            .Executes(() => 
                new PluginGenerator().Generate(
                    TemplatesPath,
                    (AbsolutePath) Environment.CurrentDirectory,
                    Name, GetEngineVersionFromProject()
                )
            );

        public Target NewActor => _ => _
            .Description("Create new Unreal Actor in current directory")
            .Requires(() => Name)
            .Executes(() =>
                new ActorGenerator().Generate(
                    TemplatesPath,
                    (AbsolutePath) Environment.CurrentDirectory,
                    new(Name)
                )
            );

        public Target NewInterface => _ => _
            .Description("Create new Unreal Interface in current directory")
            .Requires(() => Name)
            .Executes(() =>
                new InterfaceGenerator().Generate(
                    TemplatesPath,
                    (AbsolutePath) Environment.CurrentDirectory,
                    new(Name)
                )
            );

        public Target NewObject => _ => _
            .Description("Create new Unreal Object in current directory")
            .Requires(() => Name)
            .Executes(() => 
                new ObjectGenerator().Generate(
                    TemplatesPath,
                    (AbsolutePath) Environment.CurrentDirectory,
                    new(Name)
                )
            );

        public Target NewStruct => _ => _
            .Description("Create new Unreal Struct in current directory")
            .Requires(() => Name)
            .Executes(() => 
                new StructGenerator().Generate(
                    TemplatesPath,
                    (AbsolutePath) Environment.CurrentDirectory,
                    new(Name)
                )
            );

        public Target CleanDeployment => _ => _
            .Description("Removes previous deployment folder")
            .Executes(() => DeleteDirectory(RootDirectory / OutPath));

        public Target CleanProject => _ => _
            .Description("Removes auto generated folders of Unreal Engine from the project")
            .Executes(() => Unreal.ClearFolder(UnrealProjectFolder));

        public Target CleanPlugins => _ => _
            .Description("Removes auto generated folders of Unreal Engine from the plugins")
            .Executes(() =>
            {
                foreach(var pluginDir in Directory.EnumerateDirectories(UnrealPluginsFolder))
                {
                    Unreal.ClearFolder((AbsolutePath)pluginDir);
                }
            });

        public Target CleanUnreal => _ => _
            .Description("Removes auto generated folders of Unreal Engine")
            .DependsOn(CleanProject)
            .DependsOn(CleanPlugins);

        public Target GenerateProject => _ => _
            .Description("Generate project files for the default IDE of the current platform (Visual Studio or XCode)")
            .Executes(() =>
            {
                Unreal.BuildTool(
                    GetEngineVersionFromProject(),
                    "-projectfiles"
                    + $" -project=\"{ToProject}\""
                    + " -game -progress"
                ).Run();
            });

        public Target BuildEditor => _ => _
            .Description("Build the editor binaries so this project can be opened properly in the Unreal editor")
            .Executes(() =>
            {
                Unreal.BuildTool(
                    GetEngineVersionFromProject(),
                    $"{UnrealProjectName}Editor {TargetPlatform} Development"
                    + $" -Project=\"{ToProject}\""
                )
                    .WithoutUnimportant()
                    .Run();
            });
        
        public Target CookProject => _ => _
            .Description("Cook Unreal assets for standalone game execution")
            .DependsOn(BuildEditor)
            .Executes(() =>
            {
                Unreal.AutomationToolBatch(
                    GetEngineVersionFromProject(),
                    "BuildCookRun"
                    + $" -ScriptsForProject=\"{ToProject}\""
                    + $" -project=\"{ToProject}\""
                    + $" -targetplatform={TargetPlatform}"
                    + " -nocompile"
                    + " -nocompileeditor"
                    + " -installed"
                    + " -nop4"
                    + " -cook"
                    + " -skipstage"
                    + " -utf8output"
                )
                    .WithOnlyResults()
                    .Run();
            });
    }
}