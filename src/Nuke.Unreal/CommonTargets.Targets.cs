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
using static Nuke.Unreal.BuildCommon;
using GlobExpressions;
using Nuke.Common.Tools.Git;
using Serilog;

namespace Nuke.Unreal
{
    public abstract partial class CommonTargets : NukeBuild
    {
        public Target CleanDeployment => _ => _
            .Description("Removes previous deployment folder")
            .Executes(() => DeleteDirectory(OutPath));

        public Target CleanProject => _ => _
            .Description("Removes auto generated folders of Unreal Engine from the project")
            .Executes(() => Unreal.ClearFolder(UnrealProjectFolder));

        public Target CleanPlugins => _ => _
            .Description("Removes auto generated folders of Unreal Engine from the plugins")
            .Executes(() =>
            {
                void recurseBody(AbsolutePath path)
                {
                    if(Glob.Files(path, "*.uplugin", GlobOptions.CaseInsensitive).Any())
                    {
                        Unreal.ClearFolder(path);
                        if((path / ".git").DirectoryExists() || (path / ".git").FileExists())
                            GitTasks.Git("clean -xdf", path);
                    }
                    else
                    {
                        if((path / ".git").DirectoryExists() || (path / ".git").FileExists())
                            GitTasks.Git("clean -xdf", path);
                        foreach(var dir in Directory.EnumerateDirectories(path))
                        {
                            recurseBody((AbsolutePath)dir);
                        }
                    }
                }

                foreach(var pluginDir in Directory.EnumerateDirectories(UnrealPluginsFolder))
                {
                    recurseBody((AbsolutePath)pluginDir);
                }
            });

        public Target Clean => _ => _
            .Description("Removes auto generated folders of Unreal Engine")
            .DependsOn(CleanProject)
            .DependsOn(CleanPlugins);

        public virtual Target Generate => _ => _
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

        public virtual Target BuildEditor => _ => _
            .Description("Build the editor binaries so this project can be opened properly in the Unreal editor")
            .Executes(() =>
            {
                Unreal.BuildTool(
                    GetEngineVersionFromProject(),
                    $"{UnrealProjectName}Editor Win64 Development"
                    + $" -Project=\"{ToProject}\""
                ).Run();
            });

        public virtual Target Build => _ => _
            .Description("Build this project for execution")
            .Executes(() =>
            {
                (
                    from c in Config
                    from r in RunIn
                    select (c, r)
                ).ForEach(combination =>
                {
                    var (config, runIn) = combination;

                    Log.Information($"{config} ran in {runIn}:");
                    var targetEnv = runIn == ExecMode.Standalone ? "" : "Editor";
                    Unreal.BuildTool(
                        GetEngineVersionFromProject(),
                        $"{UnrealProjectName}{targetEnv} {TargetPlatform} {config}"
                        + $" -Project=\"{ToProject}\""
                    ).Run();
                });
            });
        
        public virtual Target Cook => _ => _
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