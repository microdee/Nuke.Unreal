using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Nuke.Common;
using Nuke.Common.IO;
using Nuke.Common.Utilities.Collections;

using static Nuke.Common.IO.FileSystemTasks;
using GlobExpressions;
using Nuke.Common.Tools.Git;
using Serilog;

namespace Nuke.Unreal
{
    public abstract partial class UnrealBuild : NukeBuild
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
                    + UbtArgs.AppendAsArguments()
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
                    + UbtArgs.AppendAsArguments()
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
                        + UbtArgs.AppendAsArguments()
                    ).Run();
                });
            });

        public virtual bool CookAll => false;
        public virtual IEnumerable<string> CookArguments
        {
            get
            {
                var result = new List<string> {
                    "-nocompile",
                    "-nocompileeditor",
                    "-installed",
                    "-skipstage",
                    "-skipbuild",
                    "-nop4",
                    "-utf8output",
                    "-manifests",
                };
                if(CookAll)
                {
                    result.Add("-CookAll");
                }
                return result;
            }
        }
        
        public virtual Target Cook => _ => _
            .Description("Cook Unreal assets for standalone game execution")
            .DependsOn(BuildEditor, Build)
            .Executes(() =>
            {
                Config.ForEach(c =>
                {
                    Unreal.AutomationToolBatch(
                        GetEngineVersionFromProject(),
                        "BuildCookRun"
                        + $" -ScriptsForProject=\"{ToProject}\""
                        + $" -project=\"{ToProject}\""
                        + $" -targetplatform={TargetPlatform}"
                        + $" -platform={TargetPlatform}"
                        + $" -clientconfig={c}"
                        + " -ue4exe=UE4Editor-Cmd.exe"
                        + " -cook"
                        + CookArguments.AppendAsArguments()
                        + UatArgs.AppendAsArguments()
                    )
                    .WithWorkingDir(UnrealEnginePath)
                    .Run();
                });
            });
    }
}