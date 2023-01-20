using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace build.Generators.Replicated.UnrealBuildTool;

/// <summary>
/// Systems that need to be configured to execute a tool mode
/// </summary>
[Flags]
enum ToolModeOptions
{
    /// <summary>
    /// Do not initialize anything
    /// </summary>
    None = 0,

    /// <summary>
    /// Start prefetching metadata for the engine folder as early as possible
    /// </summary>
    StartPrefetchingEngine = 1,

    /// <summary>
    /// Initializes the XmlConfig system
    /// </summary>
    XmlConfig = 2,

    /// <summary>
    /// Registers build platforms
    /// </summary>
    BuildPlatforms = 4,

    /// <summary>
    /// Registers build platforms
    /// </summary>
    BuildPlatformsHostOnly = 8,

    /// <summary>
    /// Registers build platforms for validation
    /// </summary>
    BuildPlatformsForValidation = 16,

    /// <summary>
    /// Only allow a single instance running in the branch at once
    /// </summary>
    SingleInstance = 32,

    /// <summary>
    /// Print out the total time taken to execute
    /// </summary>
    ShowExecutionTime = 64,
}

/// <summary>
/// Attribute used to specify options for a UBT mode.
/// </summary>
[AttributeUsage(AttributeTargets.Class)]
class ToolModeAttribute : Attribute
{
    /// <summary>
    /// Name of this mode
    /// </summary>
    public string Name;

    /// <summary>
    /// Options for executing this mode
    /// </summary>
    public ToolModeOptions Options;
}