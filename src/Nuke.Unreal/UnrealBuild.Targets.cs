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
using Nuke.Common.Tools.MSBuild;
using Nuke.Common.ProjectModel;

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
        
        public virtual Target DiscoverPluginTargets => _ => _
            .Description(
                "Discover other C# projects which may contain additional Nuke targets, and add them to the main build project."
                + " However after discovery they still need to be added to the main Build class."
            )
            .Executes(() =>
            {
                var buildProject = ProjectModelTasks.ParseProject(BuildProjectFile);
                var pluginProjectFiles = RootDirectory.SubTreeProject()
                    .Where(sd =>  Directory.Exists(sd / "Nuke.Targets"))
                    .Where(sd => !Directory.Exists(sd / ".nuke"))
                    .Select(sd => Glob.Files(sd / "Nuke.Targets", "*.csproj", GlobOptions.CaseInsensitive)
                        .Where(f => sd / "Nuke.Targets" / f != BuildProjectFile)
                        .Select(f => sd / "Nuke.Targets" / f)
                        .FirstOrDefault()
                    )
                    .WhereNotNull();
                
                if (pluginProjectFiles.IsEmpty())
                {
                    Log.Information("No plugin targets have been found.");
                    return;
                }
                
                foreach(var pluginTargetsProject in pluginProjectFiles)
                {
                    var relativeToBuildProject = BuildProjectDirectory.GetRelativePathTo(pluginTargetsProject);

                    if (buildProject.GetItems("ProjectReference").Any(
                        i => i.EvaluatedInclude.Contains(Path.GetFileName(pluginTargetsProject))
                    )) {
                        Log.Information($"Plugin project was already included {relativeToBuildProject}");
                        continue;
                    }
                    Log.Information($"Found plugin project at {relativeToBuildProject}");

                    buildProject.AddItem("ProjectReference", relativeToBuildProject);
                }

                buildProject.Save();
            });
    }
}
