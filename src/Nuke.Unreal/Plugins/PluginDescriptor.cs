using System;
using System.Collections.Generic;
using System.Linq;

namespace Nuke.Unreal.Plugins;

/// <summary>
/// The version format for .uplugin files. This rarely changes now; plugin descriptors should maintain backwards compatibility automatically.
/// </summary>
public enum PluginDescriptorVersion
{
    /// <summary>
    /// Invalid
    /// </summary>
    Invalid = 0,

    /// <summary>
    /// Initial version
    /// </summary>
    Initial = 1,

    /// <summary>
    /// Adding SampleNameHash
    /// </summary>
    NameHash = 2,

    /// <summary>
    /// Unifying plugin/project files (since abandoned, but backwards compatibility maintained)
    /// </summary>
    ProjectPluginUnification = 3,

    /// <summary>
    /// This needs to be the last line, so we can calculate the value of Latest below
    /// </summary>
    LatestPlusOne,

    /// <summary>
    /// The latest plugin descriptor version
    /// </summary>
    Latest = LatestPlusOne - 1
}

/// <summary>
/// In-memory representation of a .uplugin file
/// </summary>
public class PluginDescriptor
{
    /// <summary>
    /// Descriptor version number
    /// </summary>
    public int FileVersion;

    /// <summary>
    /// Version number for the plugin.  The version number must increase with every version of the plugin, so that the system 
    /// can determine whether one version of a plugin is newer than another, or to enforce other requirements.  This version
    /// number is not displayed in front-facing UI.  Use the VersionName for that.
    /// </summary>
    public int Version;

    /// <summary>
    /// Name of the version for this plugin.  This is the front-facing part of the version number.  It doesn't need to match
    /// the version number numerically, but should be updated when the version number is increased accordingly.
    /// </summary>
    public string? VersionName;

    /// <summary>
    /// Friendly name of the plugin
    /// </summary>
    public string? FriendlyName;

    /// <summary>
    /// Description of the plugin
    /// </summary>
    public string? Description;

    /// <summary>
    /// The name of the category this plugin
    /// </summary>
    public string? Category;

    /// <summary>
    /// The company or individual who created this plugin.  This is an optional field that may be displayed in the user interface.
    /// </summary>
    public string? CreatedBy;

    /// <summary>
    /// Hyperlink URL string for the company or individual who created this plugin.  This is optional.
    /// </summary>
    public string? CreatedByURL;

    /// <summary>
    /// Documentation URL string.
    /// </summary>
    public string? DocsURL;

    /// <summary>
    /// Marketplace URL for this plugin. This URL will be embedded into projects that enable this plugin, so we can redirect to the marketplace if a user doesn't have it installed.
    /// </summary>
    public string? MarketplaceURL;

    /// <summary>
    /// Support URL/email for this plugin.
    /// </summary>
    public string? SupportURL;

    /// <summary>
    /// Sets the version of the engine that this plugin is compatible with.
    /// </summary>
    public string? EngineVersion;

    /// <summary>4
    /// If true, this plugin from a platform extension extending another plugin */
    /// </summary>
    public bool? bIsPluginExtension;

    /// <summary>
    /// List of platforms supported by this plugin. This list will be copied to any plugin reference from a project file, to allow filtering entire plugins from staged builds.
    /// </summary>
    public List<UnrealPlatform>? SupportedTargetPlatforms;

    /// <summary>
    /// List of programs supported by this plugin.
    /// </summary>
    public List<string>? SupportedPrograms;

    /// <summary>
    /// List of all modules associated with this plugin
    /// </summary>
    public List<ModuleDescriptor>? Modules;

    /// <summary>
    /// List of all localization targets associated with this plugin
    /// </summary>
    public List<LocalizationTargetDescriptor>? LocalizationTargets;

    /// <summary>
    /// Whether this plugin should be enabled by default for all projects
    /// </summary>
    public bool? bEnabledByDefault;

    /// <summary>
    /// Can this plugin contain content?
    /// </summary>
    public bool? bCanContainContent;

    /// <summary>
    /// Can this plugin contain Verse code (either in content directory or in any of its modules)?
    /// </summary>
    public bool? bCanContainVerse;

    /// <summary>
    /// Marks the plugin as beta in the UI
    /// </summary>
    public bool? bIsBetaVersion;

    /// <summary>
    /// Marks the plugin as experimental in the UI
    /// </summary>
    public bool? bIsExperimentalVersion;

    /// <summary>
    /// Set for plugins which are installed
    /// </summary>
    public bool? bInstalled;

    /// <summary>
    /// For plugins that are under a platform folder (eg. /IOS/), determines whether compiling the plugin requires the build platform and/or SDK to be available
    /// </summary>
    public bool? bRequiresBuildPlatform;

    /// <summary>
    /// When true, prevents other plugins from depending on this plugin
    /// </summary>
    public bool? bIsSealed;

    /// <summary>
    /// When true, this plugin should not contain any code or modules.
    /// </summary>
    public bool? bNoCode;

    /// <summary>
    /// When true, this plugin's modules will not be loaded automatically nor will it's content be mounted automatically. It will load/mount when explicitly requested and LoadingPhases will be ignored
    /// </summary>
    public bool? bExplicitlyLoaded;

    /// <summary>
    /// When true, an empty SupportedTargetPlatforms is interpeted as 'no platforms' with the expectation that explict platforms will be added in plugin platform extensions
    /// </summary>
    public bool? bHasExplicitPlatforms;

    /// <summary>
    /// Set of pre-build steps to execute, keyed by host platform name.
    /// </summary>
    public Dictionary<UnrealPlatform, string[]>? PreBuildSteps;

    /// <summary>
    /// Set of post-build steps to execute, keyed by host platform name.
    /// </summary>
    public Dictionary<UnrealPlatform, string[]>? PostBuildSteps;

    /// <summary>
    /// Additional plugins that this plugin depends on
    /// </summary>
    public List<PluginReferenceDescriptor>? Plugins;

    /// <summary>
    /// Plugins that this plugin should never depend on
    /// </summary>
    public List<string>? DisallowedPlugins;
}
