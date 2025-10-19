using System;
using Nuke.Common.IO;
using System.Runtime.CompilerServices;
using Nuke.Common;
using System.Collections;
using System.Collections.Generic;
using Nuke.Common.Utilities.Collections;
using System.Linq;
using Nuke.Common.Utilities;
using System.IO;
using System.Reflection;
using Serilog;
using System.Text.RegularExpressions;
using Nuke.Cola;
using System.Runtime.InteropServices;

namespace Nuke.Unreal;

/// <summary>
/// Extra build related utilities not necessarily associated with Unreal tasks
/// </summary>
public static class BuildCommon
{
    /// <summary>
    /// Get the contents folder Nuke.Unreal is shipped with. This is usually contained in the local
    /// nuget installation of Nuke.Unreal, but may vary depending on the circumstances.
    /// </summary>
    public static AbsolutePath GetContentsFolder()
    {
        var executingAssemblyFolder = (AbsolutePath) Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

        if (Directory.Exists(executingAssemblyFolder / "Templates"))
        {
            return executingAssemblyFolder;
        }

        var nukeUnrealAssemblyFolder = (AbsolutePath) Path.GetDirectoryName(typeof(BuildCommon).Assembly.Location);
        if (Directory.Exists(nukeUnrealAssemblyFolder / "Templates"))
        {
            return nukeUnrealAssemblyFolder;
        }

        var contentFolder = nukeUnrealAssemblyFolder
            .DescendantsAndSelf(p => p.Parent, d => Path.GetPathRoot(d) != d)
            .FirstOrDefault(p => Directory.Exists(p / "content"));
        
        Assert.NotNullOrEmpty(contentFolder, "Couldn't find contents folder of Nuke.Unreal.");
        return contentFolder!;
    }

    /// <summary>
    /// Returns false on known folders which are intermediate results of Engine operations,
    /// therefore its contents must not be modified by the user.
    /// </summary>
    /// <param name="path"></param>
    /// <returns></returns>
    public static bool IsProjectFolder(this AbsolutePath path)
        => !path.Name.StartsWith('.')
        && !path.Name.StartsWith("Nuke.")
        && path.Name != "Intermediate"
        && path.Name != "Binaries"
        && path.Name != "ThirdParty"
        && path.Name != "Saved";
    
    /// <summary>
    /// Gives a recursive folder tree filtering out known intermediate folders
    /// </summary>
    /// <param name="origin"></param>
    /// <param name="filter">Extra filtering function</param>
    public static IEnumerable<AbsolutePath> SubTreeProject(this AbsolutePath origin, Func<AbsolutePath, bool>? filter = null) =>
        origin.SubTree(sd => filter?.Invoke(sd) ?? true && sd.IsProjectFolder());

    /// <summary>
    /// Look for something in subtree of a folder or in parent folders based on a predicate.
    /// </summary>
    public static bool LookAroundFor(Func<string, bool> predicate, out AbsolutePath? result) =>
        PathExtensions.LookAroundFor(predicate, out result, IsProjectFolder);

    /// <summary>
    /// Get the owning parent folder of an arbitrarily deep subfolder based on wildcard filtering of
    /// files in parent folder. The closest match will be returned.
    /// </summary>
    /// <param name="path"></param>
    /// <param name="ownerPattern"></param>
    /// <returns>Owning parent folder or null if there's no match.</returns>
    public static AbsolutePath? GetOwner(this AbsolutePath path, string ownerPattern)
        => path
            .DescendantsAndSelf(d => d.Parent, d => Path.GetPathRoot(d) != d)
            .SelectMany(p => p.GlobFiles(ownerPattern))
            .FirstOrDefault();

    /// <summary>
    /// Get the Unreal plugin owning the given subfolder.
    /// </summary>
    public static AbsolutePath? GetOwningPlugin(this AbsolutePath path)
        => path
            .DescendantsAndSelf(d => d.Parent, d => Path.GetPathRoot(d) != d)
            .SelectMany(p => p.GlobFiles("*.uplugin"))
            .FirstOrDefault();

    /// <summary>
    /// Get the Unreal project owning the given subfolder.
    /// </summary>
    public static AbsolutePath? GetOwningProject(this AbsolutePath path)
        => path
            .DescendantsAndSelf(d => d.Parent, d => Path.GetPathRoot(d) != d)
            .SelectMany(p => p.GlobFiles("*.uproject"))
            .FirstOrDefault();

    /// <summary>
    /// Get the Unreal module owning the given subfolder.
    /// </summary>
    public static AbsolutePath? GetOwningModule(this AbsolutePath path)
        => path
            .DescendantsAndSelf(d => d.Parent, d => Path.GetPathRoot(d) != d)
            .SelectMany(p => p.GlobFiles("*.Build.cs"))
            .FirstOrDefault();

    /// <summary>
    /// Create a short path symlink for input path to work around the 260 character path length
    /// limitation cursing Windows from the 80's to present day.
    /// </summary>
    public static AbsolutePath Shorten(this AbsolutePath longPath, bool allPlatforms = false)
    {
        var result = longPath;
        if (allPlatforms || RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
        {
            Log.Information("Creating short symlink on {0} for {1}", longPath.GetRoot(), longPath);
            result = longPath.GetRoot() / Guid.NewGuid().ToString("N")[..16];
            result.Links(longPath);
        }
        return result;
    }
}
