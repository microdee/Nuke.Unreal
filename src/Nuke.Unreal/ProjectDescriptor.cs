// Copyright Epic Games, Inc. All Rights Reserved.

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Nuke.Unreal.Plugins;

namespace Nuke.Unreal;

/// <summary>
/// The version format for .uproject files. This rarely changes now; project descriptors should maintain backwards compatibility automatically.
/// </summary>
enum ProjectDescriptorVersion
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
/// In-memory representation of a .uproject file
/// </summary>
/// <param name="FileVersion">
/// Descriptor version number.
/// </param>
/// <param name="EngineAssociation">
/// The engine to open this project with.
/// </param>
/// <param name="Category">
/// Category to show under the project browser
/// </param>
/// <param name="Description">
/// Description to show in the project browser
/// </param>
/// <param name="Modules">
/// List of all modules associated with this project
/// </param>
/// <param name="Plugins">
/// List of plugins for this project (may be enabled/disabled)
/// </param>
/// <param name="AdditionalRootDirectories">
/// Array of additional root directories
/// </param>
/// <param name="AdditionalPluginDirectories">
/// List of additional plugin directories to scan for available plugins
/// </param>
/// <param name="TargetPlatforms">
/// Array of platforms that this project is targeting
/// </param>
/// <param name="EpicSampleNameHash">
/// A hash that is used to determine if the project was forked from a sample
/// </param>
/// <param name="InitSteps">
/// Steps to execute before creating rules assemblies in this project
/// </param>
/// <param name="PreBuildSteps">
/// Steps to execute before building targets in this project
/// </param>
/// <param name="PostBuildSteps">
/// Steps to execute before building targets in this project
/// </param>
/// <param name="IsEnterpriseProject">
/// Indicates if this project is an Enterprise project
/// </param>
/// <param name="DisableEnginePluginsByDefault">
/// Indicates that enabled by default engine plugins should not be enabled unless explicitly enabled by the project or target files.
/// </param>
public record class ProjectDescriptor(
    int FileVersion = 3,
    string? EngineAssociation = null,
    string? Category = null,
    string? Description = null,
    List<ModuleDescriptor>? Modules = null,
    List<PluginReferenceDescriptor>? Plugins = null,
    List<string>? AdditionalRootDirectories = null,
    List<string>? AdditionalPluginDirectories = null,
    List<UnrealPlatform>? TargetPlatforms = null,
    uint? EpicSampleNameHash = null,
    Dictionary<UnrealPlatform, List<string>>? InitSteps = null,
    Dictionary<UnrealPlatform, List<string>>? PreBuildSteps = null,
    Dictionary<UnrealPlatform, List<string>>? PostBuildSteps = null,
    bool? IsEnterpriseProject = null,
    bool? DisableEnginePluginsByDefault = null
);
