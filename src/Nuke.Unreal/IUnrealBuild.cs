using System.Collections.Generic;
using Nuke.Common;
using Nuke.Common.IO;
using Nuke.Unreal.Ini;
using Nuke.Unreal.Platforms.Android;
using Nuke.Unreal.Tools;

namespace Nuke.Unreal;

/// <summary>
/// Base interface for build components which require an UnrealBuild main class.
/// </summary>
public interface IUnrealBuild : INukeBuild
{
    //////// GENERAL PARAMETERS ////////

    /// <summary>
    /// Get an output folder where the targets should store their artifacts. Override this
    /// function in your main build class to enforce your own.
    /// </summary>
    AbsolutePath GetOutput();

    /// <summary>
    /// <para>
    /// **NUKE PARAMETER**
    /// </para>
    /// Set platform for running targets
    /// </summary>
    UnrealPlatform Platform { get; }

    /// <summary>
    /// <para>
    /// **NUKE PARAMETER**
    /// </para>
    /// The target configuration for building or packaging the project
    /// </summary>
    UnrealConfig[] Config { get; }

    /// <summary>
    /// <para>
    /// **NUKE PARAMETER**
    /// </para>
    /// The editor configuration to be used while building or packaging the project
    /// </summary>
    UnrealConfig[] EditorConfig { get; }

    /// <summary>
    /// <para>
    /// **NUKE PARAMETER**
    /// </para>
    /// The Unreal target type for building the project
    /// </summary>
    UnrealTargetType[] TargetType { get; }

    /// <summary>
    /// <para>
    /// **NUKE PARAMETER**
    /// </para>
    /// Select texture compression mode for Android
    /// </summary>
    AndroidCookFlavor[] AndroidTextureMode { get; }

    /// <summary>
    /// UBT arguments to be applied globally for all UBT invocations. Override this function
    /// in your main build class if your project needs extra intricacies for everything what
    /// UBT may do through Nuke.Unreal.
    ///
    /// These arguments are also propagated to all UAT invocations through its `-UbtArgs`
    /// </summary>
    UbtConfig UbtGlobal(UbtConfig _);

    /// <summary>
    /// UAT arguments to be applied globally for all UAT invocations. Override this function
    /// in your main build class if your project needs extra intricacies for everything what
    /// UAT may do through Nuke.Unreal.
    /// </summary>
    UatConfig UatGlobal(UatConfig _);

    /// <summary>
    /// Utility function to get the proper Engine version associated with current project.
    /// Rather use `Unreal.Version` static function, that looks nicer.
    /// </summary>
    EngineVersion GetEngineVersionFromProject();

    /// <summary>
    /// Path to the root of the associated Unreal Engine installation/source
    /// </summary>
    AbsolutePath UnrealEnginePath { get; }

    /// <summary>
    /// Get optionally named argument block (section after `-->`) with contextual data
    /// substituted.
    /// <list type="bullet">
    ///     <item>`~p` Project file path</item>
    ///     <item>`~pdir` Project folder</item>
    ///     <item>`~ue` Unreal Engine folder</item>
    /// </list>
    /// </summary>
    IEnumerable<string> GetArgumentBlock(string name = "");

    /// <summary>
    /// Read INI configuration emulating the same hierarchy of importance as Unreal Engine
    /// also does.
    /// </summary>
    /// <param name="shortName">The name of the configuration like `Game` or `Engine`</param>
    /// <param name="lowestLevel">
    ///     The least important level of hierarchy for reading this config.
    ///     Default is `Base`
    /// </param>
    /// <param name="highestLevel">
    ///     The maximum important level of hierarchy for reading this config
    ///     Default is `Saved`
    /// </param>
    /// <param name="considerPlugins">
    ///     If true also consider config files found in plugins.
    ///     Default if true.
    /// </param>
    /// <param name="extraConfigSubfolder">
    ///     Manually add extra configuration subfolders which may be outside of the normal
    ///     sources of config files.
    /// </param>
    /// <returns>The parsed contents of the indicated config name</returns>
    ConfigIni ReadIniHierarchy(
        string shortName,
        IniHierarchyLevel lowestLevel = IniHierarchyLevel.Base,
        IniHierarchyLevel highestLevel = IniHierarchyLevel.Saved,
        bool considerPlugins = true,
        IEnumerable<string>? extraConfigSubfolder = null
    );

    //////// PROJECT PARAMETERS ////////

    /// <summary>
    ///     <para>
    ///         Optionally specify a path to a `.uproject` file.
    ///     </para>
    ///     <para>
    ///         If not overridden Nuke.Unreal will traverse upwards on the directory tree,
    ///         then sift through all subdirectories recursively (ignoring some known folders)
    ///     </para>
    /// </summary>
    AbsolutePath ProjectPath { get; }

    /// <summary>
    /// Path to folder containing the `.project` file
    /// </summary>
    AbsolutePath ProjectFolder { get; }

    /// <summary>
    /// Path to the Unreal plugins folder of this project
    /// </summary>
    AbsolutePath PluginsFolder { get; }

    /// <summary>
    /// Short name of the project
    /// </summary>
    string ProjectName { get; }

    /// <summary>
    /// "Immutable" C# representation of the `.uproject` contents
    /// </summary>
    ProjectDescriptor ProjectDescriptor { get; }

    /// <summary>
    /// UAT arguments to be applied every time UAT is called for Cooking. Override this function
    /// in your main build class if your project needs extra intricacies for Cooking.
    /// For example specifying maps explicitly.
    /// </summary>
    UatConfig UatCook(UatConfig _);

    /// <summary>
    /// Enforce packaging for distribution when that is set from `Game` ini files.
    /// Override this function in your main build class if you want a different logic set for
    /// flagging packages for distribution.
    /// </summary>
    bool ForDistribution();

    //////// BOILERPLATE PARAMETERS ////////

    /// <summary>
    /// <para>
    /// **NUKE PARAMETER**
    /// </para>
    /// Specify a folder containing generator specific folders for Scriban scaffolding and templates. If left empty
    /// the templates coming with Nuke.Unreal will be used.
    /// </summary>
    AbsolutePath TemplatesPath { get; }

    /// <summary>
    /// <para>
    /// **NUKE PARAMETER**
    /// </para>
    /// Name parameter for boilerplate generators.
    /// </summary>
    string[] Name { get; }

    /// <summary>
    /// <para>
    /// **NUKE PARAMETER**
    /// </para>
    /// <para>
    ///     Specification(s) of the imported library(ies). This is used slightly differently based on which library
    ///     type is being used:
    /// </para>
    /// <para>
    ///     Header / CMake: It's only the name of the library (like `\--Spec spdlog`)
    /// </para>
    /// <para>
    ///     XRepo: specify the xrepo package reference and its config separated by space. For example:
    /// </para>
    /// <code>
    ///     \--Spec "zlib"
    ///     \--Spec "zlib 1.2.x"
    ///     \--Spec "boost regex=true,thread=true"
    ///     \--Spec "imgui 1.91.1 freetype=true"
    /// </code>
    /// <para>
    ///     Or multiple libraries at once
    /// </para>
    /// <code>
    ///     \--Spec "zlib 1.2.x" "boost regex=true,thread=true" "imgui 1.91.1 freetype=true"
    /// </code>
    /// <para>
    ///     More about xrepo: https://xrepo.xmake.io
    /// </para>
    /// </summary>
    /// <remarks>
    ///     Since Unreal uses MD runtime linkage `runtimes='MD'` config is always appended by Nuke.Unreal, and the
    ///     user must not specify it.
    /// </remarks>
    string[] Spec { get; }

    //////// GENERAL TARGETS ////////

    /// <summary>
    /// <para>
    /// **NUKE TARGET**
    /// </para>
    /// Opens the Nuke.Unreal online documentation
    /// </summary>
    Target HelpNukeUnreal { get; }

    /// <summary>
    /// <para>
    /// **NUKE TARGET**
    /// </para>
    /// Prints curated information about project
    /// </summary>
    Target Info { get; }

    /// <summary>
    /// <para>
    /// **NUKE TARGET**
    /// </para>
    /// Removes previous deployment folder
    /// </summary>
    Target CleanDeployment { get; }

    /// <summary>
    /// <para>
    /// **NUKE TARGET**
    /// </para>
    /// Removes auto generated folders of Unreal Engine from the project
    /// </summary>
    Target CleanProject { get; }

    /// <summary>
    /// <para>
    /// **NUKE TARGET**
    /// </para>
    /// Removes auto generated folders of Unreal Engine from the plugins
    /// </summary>
    Target CleanPlugins { get; }

    /// <summary>
    /// <para>
    /// **NUKE TARGET**
    /// </para>
    /// Removes auto generated folders of Unreal Engine
    /// </summary>
    Target Clean { get; }

    /// <summary>
    /// <para>
    /// **NUKE TARGET**
    /// </para>
    /// Switch to an explicit Engine version
    /// <code>
    ///     \--unreal (req.)
    /// </code>
    /// </summary>
    Target Switch { get; }

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
    Target Prepare { get; }

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
    Target Generate { get; }

    Target SetupPlatformSdk { get; }

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
    Target BuildEditor { get; }

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
    Target Build { get; }

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
    Target Cook { get; }

    /// <summary>
    /// <para>
    /// **NUKE TARGET**
    /// </para>
    /// Ensure support for plain C# build plugins without the need for CSX or dotnet projects. This only needs to
    /// be done once, you can check the results into source control.
    /// </summary>
    Target EnsureBuildPluginSupport { get; }

    //////// RUN UNREAL TOOLS TARGETS ////////

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
    Target RunUat { get; }

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
    Target RunUbt { get; }

    /// <summary>
    /// <para>
    /// **NUKE TARGET**
    /// </para>
    /// Start a UShell session. This opens a new console window, and nuke will exit immadiately. Working directory
    /// is the project folder, regardless of actual working directory.
    /// </summary>
    Target RunShell { get; }

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
    Target Run { get; }

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
    Target RunEditorCmd { get; }

    //////// BOILERPLATE TARGETS /////////

    /// <summary>
    /// <para>
    /// **NUKE TARGET**
    /// </para>
    /// Create new module in the owning project or plugin (depending on working directory)
    /// <code>
    ///     \--Name (req,)
    ///     \--AddToTarget
    ///     \--TemplatesPath (adv.)
    /// </code>
    /// </summary>
    Target NewModule { get; }

    /// <summary>
    /// <para>
    /// **NUKE TARGET**
    /// </para>
    /// Add C++ code to a project which doesn't have one yet.
    /// <code>
    ///     \--Name (req,)
    ///     \--TemplatesPath (adv.)
    /// </code>
    /// </summary>
    Target AddCode { get; }

    /// <summary>
    /// <para>
    /// **NUKE TARGET**
    /// </para>
    /// Create a new project plugin.
    /// <code>
    ///     \--Name (req,)
    ///     \--TemplatesPath (adv.)
    /// </code>
    /// </summary>
    Target NewPlugin { get; }

    /// <summary>
    /// <para>
    /// **NUKE TARGET**
    /// </para>
    /// Create new Unreal Actor in current directory
    /// <code>
    ///     \--Name (req,)
    ///     \--TemplatesPath (adv.)
    /// </code>
    /// </summary>
    Target NewActor { get; }

    /// <summary>
    /// <para>
    /// **NUKE TARGET**
    /// </para>
    /// Create new Unreal Interface in current directory
    /// <code>
    ///     \--Name (req,)
    ///     \--TemplatesPath (adv.)
    /// </code>
    /// </summary>
    Target NewInterface { get; }

    /// <summary>
    /// <para>
    /// **NUKE TARGET**
    /// </para>
    /// Create new Unreal Object in current directory
    /// <code>
    ///     \--Name (req,)
    ///     \--TemplatesPath (adv.)
    /// </code>
    /// </summary>
    Target NewObject { get; }

    /// <summary>
    /// <para>
    /// **NUKE TARGET**
    /// </para>
    /// Create new Unreal Struct in current directory
    /// <code>
    ///     \--Name (req,)
    ///     \--TemplatesPath (adv.)
    /// </code>
    /// </summary>
    Target NewStruct { get; }

    /// <summary>
    /// <para>
    /// **NUKE TARGET**
    /// </para>
    /// Create new Unreal Automation Spec in current directory
    /// <code>
    ///     \--Name (req,)
    ///     \--TemplatesPath (adv.)
    /// </code>
    /// </summary>
    Target NewSpec { get; }

    /// <summary>
    /// <para>
    /// **NUKE TARGET**
    /// </para>
    /// <para>
    ///     Create boilerplate module for third-party C++ libraries. Specify the kind of
    ///     library with `\--LibraryType Header|CMake|XRepo` The latter two will generate
    ///     extra nuke targets preparing the library to be consumed by Unreal.
    ///     Fetching/storing the library is up to the developer
    ///     (except of course with XRepo).
    /// </para>
    /// <para>
    ///     Use type specific targets for more comfortable CLI experience, for example <br />
    ///     `nuke use-xrepo \--Spec tracy` <br />
    ///     instead of <br />
    ///     `nuke UseLibrary --LibraryType xrepo --Spec tracy`
    /// </para>
    /// <para>
    ///     This only needs to be done once, you can check the results into source control.
    /// </para>
    /// <code>
    ///     \--Spec (req,)
    ///     \--LibraryType
    ///     \--Suffix (adv.)
    /// </code>
    /// </summary>
    Target UseLibrary { get; }

    /// <summary>
    /// <para>
    /// **NUKE TARGET**
    /// </para>
    /// <para>
    ///     Use libraries from the xrepo package manager. This target only configures another target which will
    ///     eventually fetch the input libraries. To make them available to Unreal run `Prepare` or `Generate`
    ///     targets.
    /// </para>
    /// <para>
    ///     Specify the xrepo package reference and its config separated by space. For example:
    /// </para>
    /// <code>
    ///     nuke UseXRepo \--Spec "zlib"
    ///     nuke UseXRepo \--Spec "zlib 1.2.x"
    ///     nuke UseXRepo \--Spec "boost regex=true,thread=true"
    ///     nuke UseXRepo \--Spec "imgui 1.91.1 freetype=true"
    /// </code>
    /// <para>
    ///     Or multiple libraries at once
    /// </para>
    /// <code>
    ///     nuke UseXRepo \--Spec "zlib 1.2.x" "boost regex=true,thread=true" "imgui 1.91.1 freetype=true"
    /// </code>
    /// <para>
    ///     More about xrepo: https://xrepo.xmake.io
    /// </para>
    /// <code>
    ///     \--Spec (req,)
    ///     \--Suffix (adv.)
    /// </code>
    /// </summary>
    /// <remarks>
    ///     Since Unreal uses MD runtime linkage `runtimes='MD'` config is always appended by Nuke.Unreal, and the
    ///     user must not specify it.
    /// </remarks>
    Target UseXRepo { get; }

    /// <summary>
    /// <para>
    /// **NUKE TARGET**
    /// </para>
    /// </summary>
    Target UseCMake { get; }

    /// <summary>
    /// <para>
    /// **NUKE TARGET**
    /// </para>
    /// </summary>
    Target UseHeaderOnly { get; }
}
