using System;
using System.IO;
using System.Linq;
using Nuke.Common;
using Nuke.Common.IO;
using Nuke.Common.Utilities.Collections;
using GlobExpressions;
using Nuke.Common.Tools.Git;
using Nuke.Unreal.Tools;
using Nuke.Cola;
using Nuke.Common.Utilities;
using Nuke.Common.ProjectModel;
using Serilog;

namespace Nuke.Unreal
{
    public abstract partial class UnrealBuild : NukeBuild
    {
        public virtual Target CleanDeployment => _ => _
            .Description("Removes previous deployment folder")
            .Executes(() => GetOutput().DeleteDirectory());

        public virtual Target CleanProject => _ => _
            .Description("Removes auto generated folders of Unreal Engine from the project")
            .Executes(() => Unreal.ClearFolder(ProjectFolder));

        public virtual Target CleanPlugins => _ => _
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

        public virtual Target Clean => _ => _
            .Description("Removes auto generated folders of Unreal Engine")
            .DependsOn(CleanProject)
            .DependsOn(CleanPlugins);

        public virtual Target Prepare => _ => _
            .Description(
                """
                Run necessary preparations which needs to be done before Unreal tools can handle
                the project. By default it is empty and the main build project may override it or
                other Targets can depend on it / hook into it.
                """
            );

        public virtual Target Generate => _ => _
            .Description(
                """
                Generate project files for the default IDE of the current platform
                (Visual Studio or XCode)
                """
            )
            .DependsOn(Prepare)
            .Executes(() =>
            {
                Unreal.BuildTool(this, _ => _
                    .ProjectFiles()
                    .Project(ProjectPath)
                    .Game()
                    .If(Unreal.Version(this).IsEngineSource, _ => _
                        .Engine()
                    )
                    .Progress()
                    .Append(UbtArgs.AsArguments())
                )("");
            });

        public virtual Target BuildEditor => _ => _
            .Description(
                """
                Build the editor binaries so this project can be opened properly in the Unreal editor
                """
            )
            .Executes(() =>
            {
                Unreal.BuildTool(this, _ => _
                    .Target(
                        ProjectName + UnrealTargetType.Editor,
                        UnrealPlatform.FromFlag(Unreal.GetDefaultPlatform()),
                        EditorConfig
                    )
                    .Project(ProjectPath, true)
                    .If(Unreal.Version(this).IsEngineSource, _ => _
                        .Target(
                            "ShaderCompileWorker",
                            UnrealPlatform.FromFlag(Unreal.GetDefaultPlatform()),
                            new [] { UnrealConfig.Development }
                        )
                        .Quiet()
                    )
                    .FromMsBuild()
                    .Apply(UbtGlobal)
                    .Append(UbtArgs.AsArguments())
                )("");
            });

        public virtual Target Build => _ => _
            .Description("Build this project for execution")
            .After(Cook) // Android needs Cook to happen before building the APK, so OBB files can be included in the APK
            .Executes(() =>
            {
                var targets = TargetType.Select(tt => tt == UnrealTargetType.Game
                    ? ProjectName
                    : ProjectName + tt
                );
                Unreal.BuildTool(this, _ => _
                    .For(targets, (t, _) => _
                        .Target(t, Platform, Config)
                    )
                    .Project(ProjectPath)
                    .Apply(UbtGlobal)
                    .Append(UbtArgs.AsArguments())
                )("");
            });

        public virtual bool CookAll => false;

        public virtual UatConfig UatCook(UatConfig _) => _;

        public virtual bool ForDistribution()
        {
            var section = ReadIniHierarchy("Game")["/Script/UnrealEd.ProjectPackagingSettings"];
            return section != null && section
                .GetFirst("ForDistribution", new() { Value = "" }).Value
                .EqualsAnyOrdinalIgnoreCase("true", "1");
        }

        public virtual Target Cook => _ => _
            .Description("Cook Unreal assets for standalone game execution")
            .DependsOn(BuildEditor)
            .Executes(() =>
            {
                var isAndroidPlatform = Platform == UnrealPlatform.Android;
                
                var androidTextureMode = SelfAs<IAndroidTargets>()?.TextureMode
                    ?? new [] { AndroidCookFlavor.Multi };

                Config.ForEach(config =>
                {
                    Unreal.AutomationTool(this, _ => _
                        .BuildCookRun(_ => _
                            .Project(ProjectPath)
                            .Clientconfig(config)
                            .Skipstage()
                            .Manifests()
                            .If(ForDistribution(), _ => _
                                .Distribution()
                            )
                        )
                        .ScriptsForProject(ProjectPath)
                        .Targetplatform(Platform)
                        .Cook()
                        .If(InvokedTargets.Contains(BuildEditor), _ => _
                            .NoCompileEditor()
                        )
                        .If(isAndroidPlatform, _ => _
                            .Cookflavor(androidTextureMode)
                        )
                        .Apply(UatCook)
                        .Apply(UatGlobal)
                        .Append(UatArgs.AsArguments())
                    )("", workingDirectory: UnrealEnginePath);
                });
            });

        public virtual Target EnsureBuildPluginSupport => _ => _
            .Description(
                """
                Ensure support for plain C# build plugins without the need for CSX or dotnet projects.

                This only needs to be done once, you can check the results into source control.
                """
            )
            .Executes(() =>
            {
                var project = ProjectModelTasks.ParseProject(BuildProjectFile);
                project.SkipEvaluation = true;
                var compileItems = project.GetItems("Compile");
                var pattern = "../**/*.nuke.cs";

                if (BuildProjectFile.ReadAllText().Contains(pattern))
                    Log.Debug("Build project already supports standalone C# build plugins.");
                else
                {
                    Log.Information("Preparing build project to accept standalone C# files. {0}, in {1}", pattern, BuildProjectFile);
                    project.AddItem("Compile", pattern);
                    project.Save();
                    Log.Information("This only needs to be done once, you can check the results into source control.");
                }
            });
    }
}
