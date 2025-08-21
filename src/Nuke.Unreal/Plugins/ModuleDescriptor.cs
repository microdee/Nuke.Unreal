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
public class ModuleDescriptor
{
    /// <summary>
    /// Name of this module
    /// </summary>
    public string? Name;

    /// <summary>
    /// Usage type of module
    /// </summary>
    public ModuleHostType? Type;

    /// <summary>
    /// When should the module be loaded during the startup sequence?  This is sort of an advanced setting.
    /// </summary>
    public ModuleLoadingPhase? LoadingPhase;

    /// <summary>
    /// List of allowed platforms
    /// </summary>
    public List<UnrealPlatform>? PlatformAllowList;

    /// <summary>
    /// List of disallowed platforms
    /// </summary>
    public List<UnrealPlatform>? PlatformDenyList;

    /// <summary>
    /// List of allowed targets
    /// </summary>
    public List<UnrealTargetType>? TargetAllowList;

    /// <summary>
    /// List of disallowed targets
    /// </summary>
    public List<UnrealTargetType>? TargetDenyList;

    /// <summary>
    /// List of allowed target configurations
    /// </summary>
    public List<UnrealConfig>? TargetConfigurationAllowList;

    /// <summary>
    /// List of disallowed target configurations
    /// </summary>
    public List<UnrealConfig>? TargetConfigurationDenyList;

    /// <summary>
    /// List of allowed programs
    /// </summary>
    public List<string>? ProgramAllowList;

    /// <summary>
    /// List of disallowed programs
    /// </summary>
    public List<string>? ProgramDenyList;

    /// <summary>
    /// List of additional dependencies for building this module.
    /// </summary>
    public List<string>? AdditionalDependencies;

    /// <summary>
    /// When true, an empty PlatformAllowList is interpreted as 'no platforms' with the expectation that explicit platforms will be added in plugin extensions */
    /// </summary>
    public bool? bHasExplicitPlatforms;
}
