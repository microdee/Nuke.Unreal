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
        [Parameter("Specify the target Unreal Engine version")]
        public abstract string UnrealVersion { get; set; }

        [Parameter("Use the following subfolder for the specified engine version. 'UE_{0}.{1}' is the default. use '{0}' (= '4') for major and {1} for minor versions.")]
        public virtual string UnrealSubfolder { get; } = "UE_{0}.{1}";
        
        [Parameter("Specify the output working directory")]
        public virtual string OutPath { get; set; } = ".deploy";

        [Parameter("Set platform for running targets")]
        public string TargetPlatform { get; set; } = Unreal.GetDefaultPlatform().ToString();

        public EngineVersion TargetEngineVersion => new(UnrealVersion, UnrealSubfolder);

        public abstract AbsolutePath ToProject { get; }

        public AbsolutePath UnrealProjectFolder => ToProject.Parent;
        public AbsolutePath UnrealPluginsFolder => UnrealProjectFolder / "Plugins";

        public string UnrealProjectName => Path.GetFileNameWithoutExtension(ToProject);

        private JObject _projectObject;
        protected JObject ProjectObject =>
            _projectObject ?? (_projectObject = JObject.Parse(File.ReadAllText(ToProject)));

        [Parameter("Specify a folder containing generator specific folders for Scriban scaffolding and templates")]
        public virtual AbsolutePath TemplatesFolder { get; set; } = BoilerplateGenerator.DefaultTemplateFolder;

        [Parameter("Name parameter for boilerplate generators.")]
        public string Name { get; set; }

        public Target NewActor => _ => _
            .Description("Create new Unreal Actor in current directory")
            .Requires(() => Name)
            .Executes(() => {
                new ActorGenerator().Generate(
                    TemplatesFolder,
                    (AbsolutePath) Environment.CurrentDirectory,
                    new(Name, "Test, TODO")
                );
            });

        public Target NewInterface => _ => _
            .Description("Create new Unreal Interface in current directory")
            .Requires(() => Name)
            .Executes(() => {
                new InterfaceGenerator().Generate(
                    TemplatesFolder,
                    (AbsolutePath) Environment.CurrentDirectory,
                    new(Name, "Test, TODO")
                );
            });

        public Target NewObject => _ => _
            .Description("Create new Unreal Object in current directory")
            .Requires(() => Name)
            .Executes(() => {
                new ObjectGenerator().Generate(
                    TemplatesFolder,
                    (AbsolutePath) Environment.CurrentDirectory,
                    new(Name, "Test, TODO")
                );
            });

        public Target NewStruct => _ => _
            .Description("Create new Unreal Struct in current directory")
            .Requires(() => Name)
            .Executes(() => {
                new StructGenerator().Generate(
                    TemplatesFolder,
                    (AbsolutePath) Environment.CurrentDirectory,
                    new(Name, "Test, TODO")
                );
            });

        public Target CleanDeployment => _ => _
            .Executes(() => DeleteDirectory(RootDirectory / OutPath));

        public Target CleanProject => _ => _
            .Executes(() => Unreal.ClearFolder(UnrealProjectFolder));

        public Target CleanPlugins => _ => _
            .Executes(() =>
            {
                foreach(var pluginDir in Directory.EnumerateDirectories(UnrealPluginsFolder))
                {
                    Unreal.ClearFolder((AbsolutePath)pluginDir);
                }
            });

        public Target CleanUnreal => _ => _
            .DependsOn(CleanProject)
            .DependsOn(CleanPlugins);

        public Target GenerateProject => _ => _
            .Executes(() =>
            {
                Unreal.BuildTool(
                    TargetEngineVersion,
                    "-projectfiles"
                    + $" -project=\"{ToProject}\""
                    + " -game -rocket -progress"
                ).Run();
            });

        public Target BuildEditor => _ => _
            .DependsOn(GenerateProject)
            .Executes(() =>
            {
                Unreal.BuildTool(
                    TargetEngineVersion,
                    $"{UnrealProjectName}Editor {TargetPlatform} Development"
                    + $" -Project=\"{ToProject}\""
                )
                    .WithoutUnimportant()
                    .Run();
            });
        
        public Target CookProject => _ => _
            .DependsOn(BuildEditor)
            .Executes(() =>
            {
                Unreal.AutomationToolBatch(
                    TargetEngineVersion,
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