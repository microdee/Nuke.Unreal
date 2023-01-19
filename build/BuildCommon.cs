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

namespace build;
public static class BuildCommon
{
    public static AbsolutePath GetOuterFolder(Func<AbsolutePath, bool> predicate, [CallerFilePath] string scriptPath = null)
    {
        AbsolutePath RecurseBody(AbsolutePath current)
        {
            Assert.True(current.Parent != null, "Could not find a project root");
            if(predicate(current)) return current;
            return RecurseBody(current.Parent);
        }
        return RecurseBody(((AbsolutePath)scriptPath).Parent);
    }

    public static string DoubleQuoteIfNeeded(this string self) =>
        " \t\n\f".Any(ws => self.Contains(ws)) ? self.DoubleQuote() : self;

    public static IEnumerable<string> DoubleQuoteIfNeeded(this IEnumerable<string> self) =>
        self.Select(DoubleQuoteIfNeeded);

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
        return contentFolder;
    }

    public static IEnumerable<AbsolutePath> SubTree(this AbsolutePath origin, Func<AbsolutePath, bool> filter = null) =>
        origin.DescendantsAndSelf(d =>
            from sd in d.GlobDirectories("*")
            where filter?.Invoke(sd) ?? true
            select sd
        );
}
