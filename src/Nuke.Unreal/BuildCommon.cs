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
    
    public static IEnumerable<AbsolutePath> SubTreeProject(this AbsolutePath origin, Func<AbsolutePath, bool> filter = null) =>
        origin.SubTree(sd => filter?.Invoke(sd) ?? true
            && !sd.Name.StartsWith(".")
            && !sd.Name.StartsWith("Nuke.")
            && sd.Name != "Intermediate"
            && sd.Name != "Binaries"
            && sd.Name != "ThirdParty"
            && sd.Name != "Saved"
        );

    public static bool LookAroundFor(Func<string, bool> predicate, out AbsolutePath result) =>
        PathExtensions.LookAroundFor(predicate, out result, sd =>
            !sd.Name.StartsWith(".")
            && !sd.Name.StartsWith("Nuke.")
            && sd.Name != "Intermediate"
            && sd.Name != "Binaries"
            && sd.Name != "ThirdParty"
            && sd.Name != "Saved"
        );
}
