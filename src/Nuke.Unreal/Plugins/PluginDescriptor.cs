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
/// <param name="FileVersion">
/// Descriptor version number
/// </param>
/// <param name="Version">
/// Version number for the plugin.  The version number must increase with every version of the plugin, so that the system 
/// can determine whether one version of a plugin is newer than another, or to enforce other requirements.  This version
/// number is not displayed in front-facing UI.  Use the VersionName for that.
/// </param>
/// <param name="VersionName">
/// Name of the version for this plugin.  This is the front-facing part of the version number.  It doesn't need to match
/// the version number numerically, but should be updated when the version number is increased accordingly.
/// </param>
/// <param name="FriendlyName">
/// Friendly name of the plugin
/// </param>
/// <param name="Description">
/// Description of the plugin
/// </param>
/// <param name="Category">
/// The name of the category this plugin
/// </param>
/// <param name="CreatedBy">
/// The company or individual who created this plugin.  This is an optional field that may be displayed in the user interface.
/// </param>
/// <param name="CreatedByURL">
/// Hyperlink URL string for the company or individual who created this plugin.  This is optional.
/// </param>
/// <param name="DocsURL">
/// Documentation URL string.
/// </param>
/// <param name="MarketplaceURL">
/// Marketplace URL for this plugin. This URL will be embedded into projects that enable this plugin, so we can redirect to the marketplace if a user doesn't have it installed.
/// </param>
/// <param name="SupportURL">
/// Support URL/email for this plugin.
/// </param>
/// <param name="EngineVersion">
/// Sets the version of the engine that this plugin is compatible with.
/// </param>
/// <param name="IsPluginExtension">4
/// If true, this plugin from a platform extension extending another plugin */
/// </param>
/// <param name="SupportedTargetPlatforms">
/// List of platforms supported by this plugin. This list will be copied to any plugin reference from a project file, to allow filtering entire plugins from staged builds.
/// </param>
/// <param name="SupportedPrograms">
/// List of programs supported by this plugin.
/// </param>
/// <param name="Modules">
/// List of all modules associated with this plugin
/// </param>
/// <param name="LocalizationTargets">
/// List of all localization targets associated with this plugin
/// </param>
/// <param name="EnabledByDefault">
/// Whether this plugin should be enabled by default for all projects
/// </param>
/// <param name="CanContainContent">
/// Can this plugin contain content?
/// </param>
/// <param name="CanContainVerse">
/// Can this plugin contain Verse code (either in content directory or in any of its modules)?
/// </param>
/// <param name="IsBetaVersion">
/// Marks the plugin as beta in the UI
/// </param>
/// <param name="IsExperimentalVersion">
/// Marks the plugin as experimental in the UI
/// </param>
/// <param name="Installed">
/// Set for plugins which are installed
/// </param>
/// <param name="RequiresBuildPlatform">
/// For plugins that are under a platform folder (eg. /IOS/), determines whether compiling the plugin requires the build platform and/or SDK to be available
/// </param>
/// <param name="IsSealed">
/// When true, prevents other plugins from depending on this plugin
/// </param>
/// <param name="NoCode">
/// When true, this plugin should not contain any code or modules.
/// </param>
/// <param name="ExplicitlyLoaded">
/// When true, this plugin's modules will not be loaded automatically nor will it's content be mounted automatically. It will load/mount when explicitly requested and LoadingPhases will be ignored
/// </param>
/// <param name="HasExplicitPlatforms">
/// When true, an empty SupportedTargetPlatforms is interpeted as 'no platforms' with the expectation that explict platforms will be added in plugin platform extensions
/// </param>
/// <param name="PreBuildSteps">
/// Set of pre-build steps to execute, keyed by host platform name.
/// </param>
/// <param name="PostBuildSteps">
/// Set of post-build steps to execute, keyed by host platform name.
/// </param>
/// <param name="Plugins">
/// Additional plugins that this plugin depends on
/// </param>
/// <param name="DisallowedPlugins">
/// Plugins that this plugin should never depend on
/// </param>
public record class PluginDescriptor(
    int FileVersion = 3,
    int Version = 1,
    string? VersionName = null,
    string? FriendlyName = null,
    string? Description = null,
    string? Category = null,
    string? CreatedBy = null,
    string? CreatedByURL = null,
    string? DocsURL = null,
    string? MarketplaceURL = null,
    string? SupportURL = null,
    string? EngineVersion = null,
    bool? IsPluginExtension = null,
    List<UnrealPlatform>? SupportedTargetPlatforms = null,
    List<string>? SupportedPrograms = null,
    List<ModuleDescriptor>? Modules = null,
    List<LocalizationTargetDescriptor>? LocalizationTargets = null,
    bool? EnabledByDefault = null,
    bool? CanContainContent = null,
    bool? CanContainVerse = null,
    bool? IsBetaVersion = null,
    bool? IsExperimentalVersion = null,
    bool? Installed = null,
    bool? RequiresBuildPlatform = null,
    bool? IsSealed = null,
    bool? NoCode = null,
    bool? ExplicitlyLoaded = null,
    bool? HasExplicitPlatforms = null,
    Dictionary<UnrealPlatform, List<string>>? PreBuildSteps = null,
    Dictionary<UnrealPlatform, List<string>>? PostBuildSteps = null,
    List<PluginReferenceDescriptor>? Plugins = null,
    List<string>? DisallowedPlugins = null
);
