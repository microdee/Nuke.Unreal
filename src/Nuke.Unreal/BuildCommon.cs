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

namespace Nuke.Unreal
{
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

        private static string ProcessArgument(string arg)
        {
            if(string.IsNullOrWhiteSpace(arg)) return arg;

            arg = arg.TrimMatchingDoubleQuotes()
                .Replace("''", "\"") // sequence for double quotes
                .Replace("~-", "-"); // sequence for -
            if(arg[0] == '~')
                arg = string.Concat("-", arg.AsSpan(1));
            return arg;
        }

        public static IEnumerable<string> AsArguments(this IEnumerable<string> args) =>
            args?.Select(ProcessArgument) ?? Enumerable.Empty<string>();

        public static string AppendAsArguments(this IEnumerable<string> input, bool leadingSpace = true) =>
            (input?.IsEmpty() ?? true)
                ? ""
                : (leadingSpace ? " " : "") + string.Join(' ', input?.Select(ProcessArgument) ?? Enumerable.Empty<string>());

        public static IEnumerable<string> DoubleQuoteIfNeeded(this IEnumerable<object> self) =>
            self?.Select(s => s.ToString().DoubleQuoteIfNeeded()) ?? Enumerable.Empty<string>();

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
        
        public static IEnumerable<AbsolutePath> SubTreeProject(this AbsolutePath origin, Func<AbsolutePath, bool> filter = null) =>
            origin.SubTree(sd => filter?.Invoke(sd) ?? true
                && !sd.Name.StartsWith(".")
                && !sd.Name.StartsWith("Nuke.")
                && sd.Name != "Intermediate"
                && sd.Name != "Binaries"
                && sd.Name != "ThirdParty"
                && sd.Name != "Saved"
            );
        
        public static bool LookAroundFor(Func<string, bool> predicate, out AbsolutePath result)
        {
            result = null;
            var parents = NukeBuild.RootDirectory
                .DescendantsAndSelf(d => d.Parent, d => Path.GetPathRoot(d) != d );

            foreach(var p in parents)
                foreach(var f in Directory.EnumerateFiles(p))
                {
                    if(predicate(f))
                    {
                        result = (AbsolutePath) f;
                        return true;
                    }
                }

            foreach(var p in NukeBuild.RootDirectory.SubTreeProject())
                foreach(var f in Directory.EnumerateFiles(p))
                {
                    if(predicate(f))
                    {
                        result = (AbsolutePath) f;
                        return true;
                    }
                }
            return false;
        }

        public static Func<string, string> Parse(this string input, string pattern)
        {
            if (input == null) return i => null;
            
            var groups = Regex.Matches(input, pattern)?.FirstOrDefault()?.Groups;
            return i => groups?[i]?.Value;
        }

        public static AbsolutePath GetVersionSubfolder(this AbsolutePath root, string version)
        {
            if (Path.IsPathRooted(version))
            {
                return (AbsolutePath) version;
            }
            if ((root / version).DirectoryExists())
            {
                return root / version;
            }
            version = version.Contains('.') ? version : version + ".0";
            if (Version.TryParse(version, out var semVersion))
            {
                var majorMinorPatch = $"{semVersion.Major}.{semVersion.Minor}.{semVersion.Build}".Replace("-1", "0");
                var majorMinor = $"{semVersion.Major}.{semVersion.Minor}".Replace("-1", "0");
                var candidate =
                    root.GlobDirectories("*").FirstOrDefault(d => d.Name.Contains(majorMinorPatch))
                    ?? root.GlobDirectories("*").FirstOrDefault(d => d.Name.Contains(majorMinor))
                    ?? root.GlobDirectories("*").FirstOrDefault(d => d.Name.Contains(semVersion.Major.ToString()));
                return candidate;
            }
            return null;
        }
    }
}
