using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Nuke.Unreal.Plugins;

/// <summary>
/// Representation of a reference to a plugin from a project file
/// </summary>
public class PluginReferenceDescriptor
{
    /// <summary>
    /// Name of the plugin
    /// </summary>
    public string? Name;

    /// <summary>
    /// Whether it should be enabled by default
    /// </summary>
    public bool? bEnabled;

    /// <summary>
    /// Whether this plugin is optional, and the game should silently ignore it not being present
    /// </summary>
    public bool? bOptional;

    /// <summary>
    /// Description of the plugin for users that do not have it installed.
    /// </summary>
    public string? Description;

    /// <summary>
    /// URL for this plugin on the marketplace, if the user doesn't have it installed.
    /// </summary>
    public string? MarketplaceURL;

    /// <summary>
    /// If enabled, list of platforms for which the plugin should be enabled (or all platforms if blank).
    /// </summary>
    public List<string>? PlatformAllowList;

    /// <summary>
    /// If enabled, list of platforms for which the plugin should be disabled.
    /// </summary>
    public List<string>? PlatformDenyList;

    /// <summary>
    /// If enabled, list of target configurations for which the plugin should be enabled (or all target configurations if blank).
    /// </summary>
    public List<UnrealConfig>? TargetConfigurationAllowList;

    /// <summary>
    /// If enabled, list of target configurations for which the plugin should be disabled.
    /// </summary>
    public List<UnrealConfig>? TargetConfigurationDenyList;

    /// <summary>
    /// If enabled, list of targets for which the plugin should be enabled (or all targets if blank).
    /// </summary>
    public List<UnrealTargetType>? TargetAllowList;

    /// <summary>
    /// If enabled, list of targets for which the plugin should be disabled.
    /// </summary>
    public List<UnrealTargetType>? TargetDenyList;

    /// <summary>
    /// The list of supported platforms for this plugin. This field is copied from the plugin descriptor, and supplements the user's allowed/denied platforms.
    /// </summary>
    public List<string>? SupportedTargetPlatforms;

    /// <summary>
    /// When true, empty SupportedTargetPlatforms and PlatformAllowList are interpreted as 'no platforms' with the expectation that explicit platforms will be added in plugin platform extensions
    /// </summary>
    public bool? bHasExplicitPlatforms;

    /// <summary>
    /// When set, specifies a specific version of the plugin that this references.
    /// </summary>
    public int? RequestedVersion;
}
