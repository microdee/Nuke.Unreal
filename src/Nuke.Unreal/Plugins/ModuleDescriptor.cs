using System.Collections.Generic;

namespace Nuke.Unreal.Plugins;

/// <summary>
/// The type of host that can load a module
/// </summary>
public enum ModuleHostType
{
    /// <summary>
    /// /// 
    /// </summary>
    Default,

    /// <summary>
    /// Any target using the UE runtime
    /// </summary>
    Runtime,

    /// <summary>
    /// Any target except for commandlet
    /// </summary>
    RuntimeNoCommandlet,

    /// <summary>
    /// Any target or program
    /// </summary>
    RuntimeAndProgram,

    /// <summary>
    /// Loaded only in cooked builds
    /// </summary>
    CookedOnly,

    /// <summary>
    /// Loaded only in uncooked builds
    /// </summary>
    UncookedOnly,

    /// <summary>
    /// Loaded only when the engine has support for developer tools enabled
    /// </summary>
    Developer,

    /// <summary>
    /// Loads on any targets where bBuildDeveloperTools is enabled
    /// </summary>
    DeveloperTool,

    /// <summary>
    /// Loaded only by the editor
    /// </summary>
    Editor,

    /// <summary>
    /// Loaded only by the editor, except when running commandlets
    /// </summary>
    EditorNoCommandlet,

    /// <summary>
    /// Loaded by the editor or program targets
    /// </summary>
    EditorAndProgram,

    /// <summary>
    /// Loaded only by programs
    /// </summary>
    Program,

    /// <summary>
    /// Loaded only by servers
    /// </summary>
    ServerOnly,

    /// <summary>
    /// Loaded only by clients, and commandlets, and editor....
    /// </summary>
    ClientOnly,

    /// <summary>
    /// Loaded only by clients and editor (editor can run PIE which is kinda a commandlet)
    /// </summary>
    ClientOnlyNoCommandlet,
}

/// <summary>
/// Indicates when the engine should attempt to load this module
/// </summary>
public enum ModuleLoadingPhase
{
    /// <summary>
    /// Loaded at the default loading point during startup (during engine init, after game modules are loaded.)
    /// </summary>
    Default,

    /// <summary>
    /// Right after the default phase
    /// </summary>
    PostDefault,

    /// <summary>
    /// Right before the default phase
    /// </summary>
    PreDefault,

    /// <summary>
    /// Loaded as soon as plugins can possibly be loaded (need GConfig)
    /// </summary>
    EarliestPossible,

    /// <summary>
    /// Loaded before the engine is fully initialized, immediately after the config system has been initialized.  Necessary only for very low-level hooks
    /// </summary>
    PostConfigInit,

    /// <summary>
    /// The first screen to be rendered after system splash screen
    /// </summary>
    PostSplashScreen,

    /// <summary>
    /// After PostConfigInit and before coreUobject initialized. used for early boot loading screens before the uobjects are initialized
    /// </summary>
    PreEarlyLoadingScreen,

    /// <summary>
    /// Loaded before the engine is fully initialized for modules that need to hook into the loading screen before it triggers
    /// </summary>
    PreLoadingScreen,

    /// <summary>
    /// After the engine has been initialized
    /// </summary>
    PostEngineInit,

    /// <summary>
    /// Do not automatically load this module
    /// </summary>
    None,
}

/// <summary>
/// Class containing information about a code module
/// </summary>
/// <param name="Name">
/// Name of this module
/// </param>
/// <param name="Type">
/// Usage type of module
/// </param>
/// <param name="LoadingPhase">
/// When should the module be loaded during the startup sequence?  This is sort of an advanced setting.
/// </param>
/// <param name="PlatformAllowList">
/// List of allowed platforms
/// </param>
/// <param name="PlatformDenyList">
/// List of disallowed platforms
/// </param>
/// <param name="TargetAllowList">
/// List of allowed targets
/// </param>
/// <param name="TargetDenyList">
/// List of disallowed targets
/// </param>
/// <param name="TargetConfigurationAllowList">
/// List of allowed target configurations
/// </param>
/// <param name="TargetConfigurationDenyList">
/// List of disallowed target configurations
/// </param>
/// <param name="ProgramAllowList">
/// List of allowed programs
/// </param>
/// <param name="ProgramDenyList">
/// List of disallowed programs
/// </param>
/// <param name="AdditionalDependencies">
/// List of additional dependencies for building this module.
/// </param>
/// <param name="HasExplicitPlatforms">
/// When true, an empty PlatformAllowList is interpreted as 'no platforms' with the expectation that explicit platforms will be added in plugin extensions */
/// </param>
public record ModuleDescriptor(
    string? Name = null,
    ModuleHostType? Type = null,
    ModuleLoadingPhase? LoadingPhase = null,
    List<UnrealPlatform>? PlatformAllowList = null,
    List<UnrealPlatform>? PlatformDenyList = null,
    List<UnrealTargetType>? TargetAllowList = null,
    List<UnrealTargetType>? TargetDenyList = null,
    List<UnrealConfig>? TargetConfigurationAllowList = null,
    List<UnrealConfig>? TargetConfigurationDenyList = null,
    List<string>? ProgramAllowList = null,
    List<string>? ProgramDenyList = null,
    List<string>? AdditionalDependencies = null,
    bool? HasExplicitPlatforms = null
);
