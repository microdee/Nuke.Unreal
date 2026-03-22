using System;
using System.Diagnostics;
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
using System.Runtime.InteropServices;
using Nuke.Cola.Tooling;
using Nuke.Common.Tooling;
using Nuke.Unreal.Platforms;
using Nuke.Unreal.Platforms.Android;

// Maximum line length of long parameter description:
// ------------------------------------------------------------

namespace Nuke.Unreal;

public abstract partial class UnrealBuild : NukeBuild, IUnrealBuild
{
    /// <summary>
    /// <para>
    /// **NUKE TARGET**
    /// </para>
    /// Opens the Nuke.Unreal online documentation
    /// </summary>
    public virtual Target HelpNukeUnreal => _ => _
        .Description(
            """
            |
                | Opens Nuke.Unreal online documentation.
                
            """
        )
        .Executes(() =>
        {
            Process.Start(new ProcessStartInfo
            {
                UseShellExecute = true,
                FileName = "https://mcro.de/Nuke.Unreal"
            });
        });

    /// <summary>
    /// <para>
    /// **NUKE TARGET**
    /// </para>
    /// Prints curated information about project
    /// </summary>
    public virtual Target Info => _ => _
        .Description(
            """
            |
                | Prints curated information about project
            
            """
        )
        .Executes(PrintInfo);

    /// <summary>
    /// <para>
    /// **NUKE TARGET**
    /// </para>
    /// Removes previous deployment folder
    /// </summary>
    public virtual Target CleanDeployment => _ => _
        .Description(
            """
            |
                | Removes previous deployment folder

            """
        )
        .Executes(() => GetOutput().DeleteDirectory());

    /// <summary>
    /// <para>
    /// **NUKE TARGET**
    /// </para>
    /// Removes auto generated folders of Unreal Engine from the project
    /// </summary>
    public virtual Target CleanProject => _ => _
        .Description(
            """
            |
                | Removes auto generated folders of Unreal Engine from the project

            """
        )
        .Executes(() => Unreal.ClearFolder(ProjectFolder));

    /// <summary>
    /// <para>
    /// **NUKE TARGET**
    /// </para>
    /// Removes auto generated folders of Unreal Engine from the plugins
    /// </summary>
    public virtual Target CleanPlugins => _ => _
        .Description(
            """
            |
                | Removes auto generated folders of Unreal Engine from the plugins

            """
        )
        .OnlyWhenDynamic(() => PluginsFolder.DirectoryExists())
        .Executes(() =>
        {
            void recurseBody(AbsolutePath path)
            {
                if (Glob.Files(path, "*.uplugin", GlobOptions.CaseInsensitive).Any())
                {
                    Log.Debug("Cleaning plugin {0}", path);
                    Unreal.ClearFolder(path);
                }
                else
                {
                    foreach (var dir in Directory.EnumerateDirectories(path))
                    {
                        recurseBody((AbsolutePath)dir);
                    }
                }
            }

            foreach (var pluginDir in Directory.EnumerateDirectories(PluginsFolder))
            {
                recurseBody((AbsolutePath)pluginDir);
            }
        });

    /// <summary>
    /// <para>
    /// **NUKE TARGET**
    /// </para>
    /// Removes auto generated folders of Unreal Engine
    /// </summary>
    public virtual Target Clean => _ => _
        .Description(
            """
            |
                | Removes auto generated folders of Unreal Engine
                
            """
        )
        .DependsOn(CleanProject)
        .DependsOn(CleanPlugins);

    /// <summary>
    /// <para>
    /// **NUKE TARGET**
    /// </para>
    /// Switch to an explicit Engine versionű
    /// <code>
    ///     \--unreal (req.)
    /// </code>
    /// </summary>
    public virtual Target Switch => _ => _
        .Description(
            """
            |
                | Switch to an explicit Engine version
                |
                | --unreal (req.)
            
            """
        )
        .DependsOn(Clean)
        .Before(Prepare, Generate, BuildEditor, Build, Cook)
        .Requires(() => UnrealVersion)
        .Executes(() =>
        {
            Log.Information($"Targeting Unreal Engine {UnrealVersion} on platform {Platform}");
            Unreal.InvalidateEnginePathCache();
            ProjectDescriptor = ProjectDescriptor with { EngineAssociation = UnrealVersion };
            Unreal.WriteJson(ProjectDescriptor, ProjectPath);
            _projectDescriptor = null;
            _engineVersionCache = null;
        });

    /// <summary>
    /// <para>
    /// **NUKE TARGET**
    /// </para>
    /// <para>
    ///     Run necessary preparations which needs to be done before Unreal tools can handle
    ///     the project. By default it is empty and the main build project may override it or
    ///     other Targets can depend on it / hook into it.
    /// </para>
    /// </summary>
    public virtual Target Prepare => _ => _
        .Description(
            """
            |
                | Run necessary preparations which needs to be done before Unreal tools can handle
                | the project. By default it is empty and the main build project may override it or
                | other Targets can depend on it / hook into it.

            """
        );

    /// <summary>
    /// <para>
    /// **NUKE TARGET**
    /// </para>
    /// Generate project files for the default IDE of the current platform. You can specify further details with
    /// `-->ubt` argument block. It is equivalent to right clicking the uproject and selecting "Generate _IDE_
    /// project files".
    /// <code>
    ///     \-->ubt (args.)
    /// </code>
    /// </summary>
    public virtual Target Generate => _ => _
        .Description(
            """
            |
                | Generate project files for the default IDE of the current platform.
                | You can specify further details with -->ubt argument block It is equivalent to
                | right clicking the uproject and selecting "Generate _IDE_ project files".
                |
                | -->ubt (args.)
            
            """
        )
        .DependsOn(Prepare)
        .Executes(() =>
        {
            Unreal.BuildTool(this, _ => _
                .ProjectFiles()
                .Project(ProjectPath)
                .Game()
                .If(Unreal.IsSource(this), _ => _
                    .Engine()
                )
                .Progress()
                .AppendRaw(GetArgumentBlock("ubt"))
            )("");
        });

    public virtual Target SetupPlatformSdk => _ => _
        .Unlisted()
        .Executes(() =>
        {
            var sdk = Platform.GetSdk();
            if (sdk != null)
            {
                if (sdk.IsValid(this))
                {
                    Log.Information("Preparing SDK for {0}", Platform);
                    sdk.Setup(this);
                }
                else
                {
                    Log.Error("An SDK for {0} cannot be prepared for current build", Platform);
                }
            }
        });

    /// <summary>
    /// <para>
    /// **NUKE TARGET**
    /// </para>
    /// Build the editor binaries so this project can be opened properly in the Unreal editor
    /// <code>
    ///     \--EditorConfig
    ///     \-->ubt (args.)
    /// </code>
    /// </summary>
    public virtual Target BuildEditor => _ => _
        .Description(
            """
            |
                | Build the editor binaries so this project can be opened properly in the
                | Unreal editor
                |
                | --EditorConfig
                | -->ubt (args.)

            """
        )
        .After(Prepare)
        .Executes(() =>
        {
            Unreal.BuildTool(this, _ => _
                .Target(
                    ProjectName + UnrealTargetType.Editor,
                    UnrealPlatform.FromFlag(Unreal.GetHostPlatformFlag()),
                    EditorConfig
                )
                .Project(ProjectPath, true)
                .If(Unreal.IsSource(this), _ => _
                    .Target(
                        "ShaderCompileWorker",
                        UnrealPlatform.FromFlag(Unreal.GetHostPlatformFlag()),
                        [UnrealConfig.Development]
                    )
                    .Quiet()
                )
                .FromMsBuild()
                .Apply<UbtConfig, UbtConfig>(UbtGlobal)
                .AppendRaw(GetArgumentBlock("ubt"))
            )("");
        });

    /// <summary>
    /// <para>
    /// **NUKE TARGET**
    /// </para>
    /// Build this project for execution
    /// <code>
    ///     \--TargetType
    ///     \--Config
    ///     \--Platform
    ///     \-->ubt (args.)
    /// </code>
    /// </summary>
    public virtual Target Build => _ => _
        .Description(
            """
            |
                | Build this project for execution
                |
                | --TargetType
                | --Config
                | --Platform
                | -->ubt (args.)
                
            """
        )
        .DependsOn(SetupPlatformSdk)
        .After(Cook) // Android needs Cook to happen before building the APK, so OBB files can be included in the APK
        .After(Prepare)
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
                .Apply<UbtConfig, UbtConfig>(UbtGlobal)
                .AppendRaw(GetArgumentBlock("ubt"))
            )("");
        });


    /// <summary>
    /// UAT arguments to be applied every time UAT is called for Cooking. Override this function
    /// in your main build class if your project needs extra intricacies for Cooking.
    /// For example specifying maps explicitly.
    /// </summary>
    public virtual UatConfig UatCook(UatConfig _) => _;

    /// <summary>
    /// Enforce packaging for distribution when that is set from `Game` ini files.
    /// Override this function in your main build class if you want a different logic set for
    /// flagging packages for distribution.
    /// </summary>
    public virtual bool ForDistribution()
    {
        var section = ReadIniHierarchy("Game")["/Script/UnrealEd.ProjectPackagingSettings"];
        return section != null && section
            .GetFirst("ForDistribution", new() { Value = "" }).Value
            .EqualsAnyOrdinalIgnoreCase("true", "1");
    }

    /// <summary>
    /// <para>
    /// **NUKE TARGET**
    /// </para>
    /// Cook Unreal assets for standalone game execution
    /// <code>
    ///     \--Config
    ///     \--Platform
    ///     \--AndroidTextureMode
    ///     \-->ubt (args.)
    ///     \-->uat (args.)
    /// </code>
    /// </summary>
    public virtual Target Cook => _ => _
        .Description(
            """
            |
                | Cook Unreal assets for standalone game execution
                |
                | --Config
                | --Platform
                | --AndroidTextureMode
                | -->ubt (args.)
                | -->uat (args.)
                
            """
        )
        .DependsOn(BuildEditor, SetupPlatformSdk)
        .Executes(() =>
        {
            var isAndroidPlatform = Platform == UnrealPlatform.Android;

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
                        .Cookflavor(AndroidTextureMode)
                    )
                    .Apply<UatConfig, UatConfig>(UatGlobal)
                    .Apply<UatConfig, UatConfig>(UatCook)
                    .AppendRaw(GetArgumentBlock("uat"))
                )("", workingDirectory: UnrealEnginePath);
            });
        });

    /// <summary>
    /// <para>
    /// **NUKE TARGET**
    /// </para>
    /// Ensure support for plain C# build plugins without the need for CSX or dotnet projects. This only needs to
    /// be done once, you can check the results into source control.
    /// </summary>
    public virtual Target EnsureBuildPluginSupport => _ => _
        .Description(
            """
            |
                | Ensure support for plain C# build plugins without the need for CSX or dotnet
                | projects. This only needs to be done once, you can check the results into
                | source control.

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

    /// <summary>
    /// <para>
    /// **NUKE PARAMETER**
    /// </para>
    /// Do not use globally applicable UBT/UAT arguments with run-uat/run-ubt
    /// </summary>
    [Parameter]
    public bool IgnoreGlobalArgs = false;

    /// <summary>
    /// <para>
    /// **NUKE TARGET**
    /// </para>
    /// Simply run UAT with arguments passed after `-->`
    /// <code>
    ///     \--> (args.)
    ///     \--IgnoreGlobalArgs (adv.)
    /// </code>
    /// <para>
    ///     The following symbols are replaced by Nuke.Unreal:
    /// </para>
    /// <code>
    ///     ~p    : Project file path
    ///     ~pdir : Project folder
    ///     ~ue   : Unreal Engine folder
    /// </code>
    /// </summary>
    public virtual Target RunUat => _ => _
        .Description(
            """
            |
                | Simply run UAT with arguments passed after `-->`
                |
                | The following symbols are replaced by Nuke.Unreal:
                | ~p    : Project file path
                | ~pdir : Project folder
                | ~ue   : Unreal Engine folder
                |
                | --> (args.)
                | --IgnoreGlobalArgs (adv.)
                
            """
        )
        .DependsOn(SetupPlatformSdk)
        .Executes(() =>
        {
            Unreal.AutomationTool(this, _ => _
                .AppendRaw(GetArgumentBlock())
                .If(!IgnoreGlobalArgs, _ => _.Apply<UatConfig, UatConfig>(UatGlobal))
            )("", workingDirectory: ProjectFolder);
        });

    /// <summary>
    /// <para>
    /// **NUKE TARGET**
    /// </para>
    /// Simply run UBT with arguments passed after `-->`
    /// <code>
    ///     \--> (args.)
    ///     \--IgnoreGlobalArgs (adv.)
    /// </code>
    /// <para>
    ///     The following symbols are replaced by Nuke.Unreal:
    /// </para>
    /// <code>
    ///     ~p    : Project file path
    ///     ~pdir : Project folder
    ///     ~ue   : Unreal Engine folder
    /// </code>
    /// </summary>
    public virtual Target RunUbt => _ => _
        .Description(
            """
            |
                | Simply run UBT with arguments passed after `-->`
                |
                | The following symbols are replaced by Nuke.Unreal:
                | ~p    : Project file path
                | ~pdir : Project folder
                | ~ue   : Unreal Engine folder
                |
                | --> (args.)
                | --IgnoreGlobalArgs (adv.)
                
            """
        )
        .DependsOn(SetupPlatformSdk)
        .Executes(() =>
        {
            Unreal.BuildTool(this, _ => _
                .AppendRaw(GetArgumentBlock())
                .If(!IgnoreGlobalArgs, _ => _.Apply<UbtConfig, UbtConfig>(UbtGlobal))
            )("", workingDirectory: ProjectFolder);
        });

    /// <summary>
    /// <para>
    /// **NUKE TARGET**
    /// </para>
    /// Start a UShell session. This opens a new console window, and nuke will exit immadiately. Working directory
    /// is the project folder, regardless of actual working directory.
    /// </summary>
    public virtual Target RunShell => _ => _
        .Description(
            """
            |
                | Start a UShell session. This opens a new console window, and nuke will exit
                | immadiately. Working directory is the project folder, regardless of actual
                | working directory.

            """
        )
        .DependsOn(SetupPlatformSdk)
        .Executes(() =>
        {
            var ushellDir = UnrealEnginePath / "Engine" / "Extras" / "ushell";
            var scriptExt = RuntimeInformation.IsOSPlatform(OSPlatform.Windows) ? "bat" : "sh";
            var ushellScript = ushellDir / ("ushell." + scriptExt);
            Common.Tooling.ProcessTasks.StartShell(
                ushellScript,
                ProjectFolder
            );
        });

    /// <summary>
    /// <para>
    /// **NUKE PARAMETER**
    /// </para>
    /// Name the Unreal tool to be run, You can omit the `Unreal` prefix and the extension. For example:
    /// <code>
    ///     nuke run \--tool pak \--> ./Path/To/MyProject.pak -Extract "D:/temp"
    ///     nuke run \--tool editor-cmd \--> ~p -run=MyCommandlet
    /// </code>
    /// </summary>
    [Parameter]
    public string? Tool;

    /// <summary>
    /// <para>
    /// **NUKE TARGET**
    /// </para>
    /// <para>
    ///     Run an Unreal tool from the engine binaries folder. You can omit the `Unreal` prefix and the extension.
    ///     For example:
    /// </para>
    /// <code>
    ///     nuke run \--tool pak \--> ./Path/To/MyProject.pak -Extract "D:/temp"
    ///     nuke run \--tool editor-cmd \--> ~p -run=MyCommandlet
    /// </code>
    /// <para>
    /// Working directory is the project folder, regardless of actual working directory.
    /// </para>
    /// <para>
    ///     The following symbols are replaced by Nuke.Unreal:
    /// </para>
    /// <code>
    ///     ~p    : Project file path
    ///     ~pdir : Project folder
    ///     ~ue   : Unreal Engine folder
    /// </code>
    /// <code>
    ///     \--Tool (req.)
    ///     \--> (args.)
    /// </code>
    /// </summary>
    public virtual Target Run => _ => _
        .Description(
            """
            |
                | Run an Unreal tool from the engine binaries folder. You can omit the `Unreal`
                | prefix and the extension. For example:
                | 
                | nuke run --tool pak --> ./Path/To/MyProject.pak -Extract "D:/temp"
                | nuke run --tool editor-cmd --> ~p -run=MyCommandlet
                | 
                | Working directory is the project folder, regardless of actual working
                | directory.
                |
                | The following symbols are replaced by Nuke.Unreal:
                | ~p    : Project file path
                | ~pdir : Project folder
                | ~ue   : Unreal Engine folder
                |
                | --Tool (req.)
                | --> (args.)
            
            """
        )
        .Requires(() => Tool)
        .Executes(() =>
        {
            Unreal.GetTool(this, Tool!).WithSemanticLogging()(
                GetArgumentBlock().JoinSpace(), ProjectFolder
            );
        });

    /// <summary>
    /// <para>
    /// **NUKE PARAMETER**
    /// </para>
    /// Name of the editor commandlet to run
    /// </summary>
    [Parameter]
    public string? Cmd;

    /// <summary>
    /// <para>
    /// **NUKE TARGET**
    /// </para>
    /// Run an editor commandlet with arguments passed in after `-->`
    /// <para>
    ///     The following symbols are replaced by Nuke.Unreal:
    /// </para>
    /// <code>
    ///     ~p    : Project file path
    ///     ~pdir : Project folder
    ///     ~ue   : Unreal Engine folder
    /// </code>
    /// <code>
    ///     \--Cmd (req.)
    ///     \--> (args.)
    /// </code>
    /// </summary>
    public virtual Target RunEditorCmd => _ => _
        .Description(
            """
            |
                | Run an editor commandlet with arguments passed in after -->
                |
                | The following symbols are replaced by Nuke.Unreal:
                | ~p    : Project file path
                | ~pdir : Project folder
                | ~ue   : Unreal Engine folder
                |
                | --Cmd (req.)
                | --> (args.)
                
            """
        )
        .Requires(() => Cmd)
        .Executes(() =>
        {
            Unreal.GetTool(this, "Editor-Cmd").WithSemanticLogging()(
                GetArgumentBlock()
                    .Prepend($"{ProjectPath} -run={Cmd}")
                    .JoinSpace()
                ,
                ProjectFolder
            );
        });
}
