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

namespace Nuke.Unreal;
public static class BuildCommon
{
    public static AbsolutePath GetContentsFolder()
    {
        var executingAssemblyFolder = (AbsolutePath) Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

        if (Directory.Exists(executingAssemblyFolder / "UnrealLocator"))
        {
            return executingAssemblyFolder;
        }

        var nukeUnrealAssemblyFolder = (AbsolutePath) Path.GetDirectoryName(typeof(BuildCommon).Assembly.Location);
        if (Directory.Exists(nukeUnrealAssemblyFolder / "UnrealLocator"))
        {
            return nukeUnrealAssemblyFolder;
        }

        var contentFolder = nukeUnrealAssemblyFolder
            .DescendantsAndSelf(p => p.Parent, d => Path.GetPathRoot(d) != d)
            .FirstOrDefault(p => Directory.Exists(p / "content"));
        
        Assert.NotNullOrEmpty(contentFolder, "Couldn't find contents folder of Nuke.Unreal.");
        return contentFolder!;
    }

    public static bool IsProjectFolder(this AbsolutePath path)
        => !path.Name.StartsWith('.')
        && !path.Name.StartsWith("Nuke.")
        && path.Name != "Intermediate"
        && path.Name != "Binaries"
        && path.Name != "ThirdParty"
        && path.Name != "Saved";
    
    public static IEnumerable<AbsolutePath> SubTreeProject(this AbsolutePath origin, Func<AbsolutePath, bool>? filter = null) =>
        origin.SubTree(sd => filter?.Invoke(sd) ?? true && sd.IsProjectFolder());

    public static bool LookAroundFor(Func<string, bool> predicate, out AbsolutePath? result) =>
        PathExtensions.LookAroundFor(predicate, out result, IsProjectFolder);

    public static AbsolutePath? GetOwner(this AbsolutePath path, string ownerPattern)
        => path
            .DescendantsAndSelf(d => d.Parent, d => Path.GetPathRoot(d) != d)
            .SelectMany(p => p.GlobFiles(ownerPattern))
            .FirstOrDefault();

    public static AbsolutePath? GetOwningPlugin(this AbsolutePath path)
        => path
            .DescendantsAndSelf(d => d.Parent, d => Path.GetPathRoot(d) != d)
            .SelectMany(p => p.GlobFiles("*.uplugin"))
            .FirstOrDefault();

    public static AbsolutePath? GetOwningProject(this AbsolutePath path)
        => path
            .DescendantsAndSelf(d => d.Parent, d => Path.GetPathRoot(d) != d)
            .SelectMany(p => p.GlobFiles("*.uproject"))
            .FirstOrDefault();

    public static AbsolutePath? GetOwningModule(this AbsolutePath path)
        => path
            .DescendantsAndSelf(d => d.Parent, d => Path.GetPathRoot(d) != d)
            .SelectMany(p => p.GlobFiles("*.Build.cs"))
            .FirstOrDefault();
}
