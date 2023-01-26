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
using System.Security.Cryptography;
using Nuke.Unreal.Tools;
using Nuke.Common.Tooling;
using System.Reflection;

namespace Nuke.Unreal
{
    public abstract partial class UnrealBuild : NukeBuild
    {
        public Target CleanDeployment => _ => _
            .Description("Removes previous deployment folder")
            .Executes(() => DeleteDirectory(OutPath));

        public Target CleanProject => _ => _
            .Description("Removes auto generated folders of Unreal Engine from the project")
            .Executes(() => Unreal.ClearFolder(ProjectFolder));

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

                foreach(var pluginDir in Directory.EnumerateDirectories(PluginsFolder))
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
                Unreal.BuildTool(GetEngineVersionFromProject(), _ => _
                    .ProjectFiles()
                    .Project(ProjectPath)
                    .Game()
                    .Progress()
                    .Append(UbtArgs.AsArguments())
                )();
            });

        public virtual Target BuildEditor => _ => _
            .Description("Build the editor binaries so this project can be opened properly in the Unreal editor")
            .Executes(() =>
            {
                var platform = Unreal.GetDefaultPlatform();
                Unreal.BuildTool(GetEngineVersionFromProject())(
                    $"{ProjectName}Editor {platform} Development"
                    + $" -Project=\"{ProjectPath}\""
                    + UbtArgs.AppendAsArguments()
                );
            });

        public virtual Target Build => _ => _
            .Description("Build this project for execution")
            .After(Cook) // Android needs Cook to happen before building the APK, so OBB files can be included in the APK
            .Executes(() =>
            {
                Unreal.BuildTool(GetEngineVersionFromProject(), _ => _
                    .Target(
                        TargetType.Select(tt => tt == UnrealTargetType.Game
                            ? ProjectName
                            : ProjectName + tt
                        )
                    )
                    .Platform(Platform)
                    .Configuration(Config)
                    .Project(ProjectPath)
                    .Append(UbtArgs.AsArguments())
                )();
            });

        public virtual bool CookAll => false;
        public virtual IEnumerable<string> CookArguments
        {
            get
            {
                var result = new List<string> {
                    "-nocompile",
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
            .DependsOn(BuildEditor)
            .Executes(() =>
            {
                var isAndroidPlatform = Platform == UnrealPlatform.Android;
                
                var androidTextureMode = SelfAs<IAndroidTargets>()?.TextureMode
                    ?? new [] { AndroidCookFlavor.Multi };

                var configCombination = isAndroidPlatform
                    ? (from config in Config from textureMode in androidTextureMode select (config, textureMode))
                    : Config.Select(c => (c, AndroidCookFlavor.Multi));
                configCombination.ForEach(combination =>
                {
                    var (config, textureMode) = combination;
                    Unreal.AutomationTool(GetEngineVersionFromProject())(
                        arguments:
                            "BuildCookRun"
                            + $" -ScriptsForProject=\"{ProjectPath}\""
                            + $" -project=\"{ProjectPath}\""
                            + $" -targetplatform={Platform}"
                            + $" -platform={Platform}"
                            + $" -clientconfig={config}"
                            + " -ue4exe=UE4Editor-Cmd.exe"
                            + " -cook"
                            + (isAndroidPlatform ? $" -cookflavor={textureMode}" : "")
                            + (InvokedTargets.Contains(BuildEditor) ? " -nocompileeditor" : "")
                            + CookArguments.AppendAsArguments()
                            + UatArgs.AppendAsArguments(),
                        workingDirectory: UnrealEnginePath
                    );
                });
            });
        
        public virtual Target DiscoverPluginTargets => _ => _
            .Description(
                "Discover other C# projects which may contain additional Nuke targets, and add them to the main build project."
                + " However after discovery they still need to be added to the main Build class."
                // TODO: add them automatically via Roslyn
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
