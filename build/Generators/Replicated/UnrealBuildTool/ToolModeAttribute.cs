using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;

namespace build.Generators.Replicated.UnrealBuildTool;

/// <summary>
/// Systems that need to be configured to execute a tool mode
/// </summary>
[Flags]
public enum ToolModeOptions
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

public static class ToolModeOptions_Info
{
    public static UnrealTypeMap<ToolModeOptions> Mapping(UnrealDotnetAssemblies assemblies) => new()
    {
        Namespace = "UnrealBuildTool",
        UeAssembly = assemblies.UnrealBuildTool
    };
}

/// <summary>
/// Attribute used to specify options for a UBT mode.
/// </summary>
[AttributeUsage(AttributeTargets.Class)]
class ToolModeAttribute : Attribute
{
    public static UnrealTypeMap<ToolModeAttribute> Mapping(UnrealDotnetAssemblies assemblies) => new()
    {
        Namespace = "UnrealBuildTool",
        UeAssembly = assemblies.UnrealBuildTool
    };

    /// <summary>
    /// Name of this mode
    /// </summary>
    public string Name;

    /// <summary>
    /// Options for executing this mode
    /// </summary>
    public ToolModeOptions Options;
}

/// <summary>
/// Base class for standalone UBT modes. Different modes can be invoked using the -Mode=[Name] argument on the command line, where [Name] is determined by 
/// the ToolModeAttribute on a ToolMode derived class. The log system will be initialized before calling the mode, but little else.
/// </summary>
public class ToolMode
{
    public static UnrealTypeMap<ToolMode> Mapping(UnrealDotnetAssemblies assemblies) => new()
    {
        Namespace = "UnrealBuildTool",
        UeAssembly = assemblies.UnrealBuildTool
    };
}