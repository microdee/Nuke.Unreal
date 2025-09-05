
using System.Collections.Generic;
using System.IO;
using Nuke.Common.IO;

namespace Nuke.Unreal;

/// <summary>
/// Group an Unreal association with its actual path
/// </summary>
public record UnrealInstance(string Name, AbsolutePath Path);

/// <summary>
/// Common interface for locating Unreal Engine instances in different environments
/// </summary>
public interface IUnrealLocator
{
    /// <summary>
    /// List all installed Unreal Engine installation on current system
    /// </summary>
    IEnumerable<UnrealInstance> Instances { get; }

    /// <summary>
    /// Get the path to an installed engine by its name or its absolute path
    /// </summary>
    /// <param name="name">
    /// Engine association name, source GUID, plain version or absolute path to/of an installed engine
    /// </param>
    /// <returns>Path to engine or null if that couldn't have been inferred</returns>
    AbsolutePath? GetEngine(string name);
}

/// <summary>
/// Static functions and common utilities for locating Unreal Engine
/// </summary>
public static class UnrealLocator
{
    /// <summary>
    /// Extend input path (presumably to an Unreal Engine installation) to its location of Build.version
    /// </summary>
    public static AbsolutePath GetUnrealBuildVersionPath(this AbsolutePath enginePath)
        => enginePath / "Engine" / "Build" / "Build.version";
    
    /// <summary>
    /// Validate input path if it's a proper Unreal Engine installation, return null if it isn't
    /// </summary>
    public static AbsolutePath? ExistingUnrealEngine(this AbsolutePath? enginePath)
        => enginePath?.GetUnrealBuildVersionPath()?.FileExists() ?? false
            ? enginePath
            : null;

    /// <summary>
    /// Validate input path (as string) if it's a proper Unreal Engine installation, return null if it isn't
    /// </summary>
    public static AbsolutePath? GetExistingUnrealEngine(string name)
        => Path.IsPathRooted(name)
            ? AbsolutePath.Create(name).ExistingUnrealEngine()
            : null;
    
    /// <summary>
    /// Is input path points to a valid Unreal Engine installation
    /// </summary>
    /// <param name="enginePath"></param>
    /// <returns></returns>
    public static bool IsUnrealEnginePath(this AbsolutePath? enginePath)
        => enginePath.ExistingUnrealEngine() != null;
}

/// <summary>
/// An empty Unreal Locator implementation which doesn't know about installed instances, but it will
/// validate an absolute input path of a potential Unreal Engine installation
/// </summary>
internal class GenericUnrealLocator : IUnrealLocator
{
    public IEnumerable<UnrealInstance> Instances => [];

    public AbsolutePath? GetEngine(string name) => UnrealLocator.GetExistingUnrealEngine(name);
}