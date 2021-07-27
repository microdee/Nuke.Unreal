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
    }
}