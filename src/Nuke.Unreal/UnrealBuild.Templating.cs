using System;
using Nuke.Common;
using Nuke.Common.IO;
using Nuke.Common.Utilities.Collections;
using Nuke.Unreal.BoilerplateGenerators;

namespace Nuke.Unreal
{
    public abstract partial class UnrealBuild : NukeBuild
    {

        [Parameter("Specify a folder containing generator specific folders for Scriban scaffolding and templates")]
        public virtual AbsolutePath TemplatesPath { get; set; } = BoilerplateGenerator.DefaultTemplateFolder;

        [Parameter("Name parameter for boilerplate generators.")]
        public string[] Name { get; set; }

        [Parameter("Explicitly add new module to project target")]
        public bool AddToTarget { get; set; }

        public Target NewModule => _ => _
            .Description("Create new module in the owning project or plugin (depending on working directory)")
            .Requires(() => Name)
            .Executes(() =>
                Name.ForEach(n => 
                    new ModuleGenerator()
                    .SetAddToTarget(AddToTarget)
                    .Generate(
                        TemplatesPath,
                        (AbsolutePath) Environment.CurrentDirectory,
                        n
                    )
                )
            );
        public Target AddCode => _ => _
            .Description("Add C++ code to a project which doesn't have one yet.")
            .Executes(() => 
                new TargetGenerator().Generate(
                    TemplatesPath,
                    UnrealProjectFolder,
                    UnrealProjectName
                )
            );

        public Target NewPlugin => _ => _
            .Description("Create a new project plugin.")
            .Requires(() => Name)
            .Executes(() => 
                Name.ForEach(n => 
                    new PluginGenerator().Generate(
                        TemplatesPath,
                        (AbsolutePath) Environment.CurrentDirectory,
                        n, GetEngineVersionFromProject()
                    )
                )
            );

        public Target NewActor => _ => _
            .Description("Create new Unreal Actor in current directory")
            .Requires(() => Name)
            .Executes(() =>
                Name.ForEach(n => 
                    new ActorGenerator().Generate(
                        TemplatesPath,
                        (AbsolutePath) Environment.CurrentDirectory,
                        new(n)
                    )
                )
            );

        public Target NewInterface => _ => _
            .Description("Create new Unreal Interface in current directory")
            .Requires(() => Name)
            .Executes(() =>
                Name.ForEach(n => 
                    new InterfaceGenerator().Generate(
                        TemplatesPath,
                        (AbsolutePath) Environment.CurrentDirectory,
                        new(n)
                    )
                )
            );

        public Target NewObject => _ => _
            .Description("Create new Unreal Object in current directory")
            .Requires(() => Name)
            .Executes(() => 
                Name.ForEach(n => 
                    new ObjectGenerator().Generate(
                        TemplatesPath,
                        (AbsolutePath) Environment.CurrentDirectory,
                        new(n)
                    )
                )
            );

        public Target NewStruct => _ => _
            .Description("Create new Unreal Struct in current directory")
            .Requires(() => Name)
            .Executes(() => 
                Name.ForEach(n => 
                    new StructGenerator().Generate(
                        TemplatesPath,
                        (AbsolutePath) Environment.CurrentDirectory,
                        new(n)
                    )
                )
            );

        public Target NewSpec => _ => _
            .Description("Create new Unreal Automation Spec in current directory")
            .Requires(() => Name)
            .Executes(() => 
                Name.ForEach(n => 
                    new SpecGenerator().Generate(
                        TemplatesPath,
                        (AbsolutePath) Environment.CurrentDirectory,
                        new(n)
                    )
                )
            );
    }
}