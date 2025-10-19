using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Nuke.Unreal.Plugins;

/// <summary>
/// Representation of a reference to a plugin from a project file
/// </summary>
/// <param name="Name">
/// Name of the plugin
/// </param>
/// <param name="Enabled">
/// Whether it should be enabled by default
/// </param>
/// <param name="Optional">
/// Whether this plugin is optional, and the game should silently ignore it not being present
/// </param>
/// <param name="Description">
/// Description of the plugin for users that do not have it installed.
/// </param>
/// <param name="MarketplaceURL">
/// URL for this plugin on the marketplace, if the user doesn't have it installed.
/// </param>
/// <param name="PlatformAllowList">
/// If enabled, list of platforms for which the plugin should be enabled (or all platforms if blank).
/// </param>
/// <param name="PlatformDenyList">
/// If enabled, list of platforms for which the plugin should be disabled.
/// </param>
/// <param name="TargetConfigurationAllowList">
/// If enabled, list of target configurations for which the plugin should be enabled (or all target configurations if blank).
/// </param>
/// <param name="TargetConfigurationDenyList">
/// If enabled, list of target configurations for which the plugin should be disabled.
/// </param>
/// <param name="TargetAllowList">
/// If enabled, list of targets for which the plugin should be enabled (or all targets if blank).
/// </param>
/// <param name="TargetDenyList">
/// If enabled, list of targets for which the plugin should be disabled.
/// </param>
/// <param name="SupportedTargetPlatforms">
/// The list of supported platforms for this plugin. This field is copied from the plugin descriptor, and supplements the user's allowed/denied platforms.
/// </param>
/// <param name="HasExplicitPlatforms">
/// When true, empty SupportedTargetPlatforms and PlatformAllowList are interpreted as 'no platforms' with the expectation that explicit platforms will be added in plugin platform extensions
/// </param>
/// <param name="RequestedVersion">
/// When set, specifies a specific version of the plugin that this references.
/// </param>
public record class PluginReferenceDescriptor(
    string? Name = null,
    bool? Enabled = null,
    bool? Optional = null,
    string? Description = null,
    string? MarketplaceURL = null,
    List<string>? PlatformAllowList = null,
    List<string>? PlatformDenyList = null,
    List<UnrealConfig>? TargetConfigurationAllowList = null,
    List<UnrealConfig>? TargetConfigurationDenyList = null,
    List<UnrealTargetType>? TargetAllowList = null,
    List<UnrealTargetType>? TargetDenyList = null,
    List<string>? SupportedTargetPlatforms = null,
    bool? HasExplicitPlatforms = null,
    int? RequestedVersion = null
);
