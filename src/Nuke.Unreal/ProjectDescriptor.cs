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
public class ProjectDescriptor
{
    /// <summary>
    /// Descriptor version number.
    /// </summary>
    public int FileVersion;

    /// <summary>
    /// The engine to open this project with.
    /// </summary>
    public string? EngineAssociation;

    /// <summary>
    /// Category to show under the project browser
    /// </summary>
    public string? Category;

    /// <summary>
    /// Description to show in the project browser
    /// </summary>
    public string? Description;

    /// <summary>
    /// List of all modules associated with this project
    /// </summary>
    public List<ModuleDescriptor>? Modules;

    /// <summary>
    /// List of plugins for this project (may be enabled/disabled)
    /// </summary>
    public List<PluginReferenceDescriptor>? Plugins;

    /// <summary>
    /// Array of additional root directories
    /// </summary>
    public List<string>? AdditionalRootDirectories;

    /// <summary>
    /// List of additional plugin directories to scan for available plugins
    /// </summary>
    public List<string>? AdditionalPluginDirectories;

    /// <summary>
    /// Array of platforms that this project is targeting
    /// </summary>
    public List<UnrealPlatform>? TargetPlatforms;

    /// <summary>
    /// A hash that is used to determine if the project was forked from a sample
    /// </summary>
    public uint? EpicSampleNameHash;

    /// <summary>
    /// Steps to execute before creating rules assemblies in this project
    /// </summary>
    public Dictionary<UnrealPlatform, string[]>? InitSteps;

    /// <summary>
    /// Steps to execute before building targets in this project
    /// </summary>
    public Dictionary<UnrealPlatform, string[]>? PreBuildSteps;

    /// <summary>
    /// Steps to execute before building targets in this project
    /// </summary>
    public Dictionary<UnrealPlatform, string[]>? PostBuildSteps;

    /// <summary>
    /// Indicates if this project is an Enterprise project
    /// </summary>
    public bool? IsEnterpriseProject;

    /// <summary>
    /// Indicates that enabled by default engine plugins should not be enabled unless explicitly enabled by the project or target files.
    /// </summary>
    public bool? DisableEnginePluginsByDefault;
}
