using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Nuke.Cola;
using Nuke.Cola.Tooling;
using Nuke.Common.IO;
using Nuke.Common.Utilities;
using Serilog;

namespace Nuke.Unreal.BoilerplateGenerators.XRepo;

public static partial class XRepoLibrary
{
    [GeneratedRegex(
        """
        ^
        (?<SPEC>
            (?:(?<PROVIDER>\w+)\:\:)?
            (?<NAME>[\w\.]+)
            (?:\[
                (?<FEATURES>[\w-,]+)
            \])?
            (?:[\s\/-]
                (?<VERSION>[0-9\.x#]+)
            )?
        )
        (?:\s(?<OPTIONS>[\w=,']+))?
        $
        """,
        RegexOptions.IgnoreCase | RegexOptions.IgnorePatternWhitespace
    )]
    private static partial Regex SpecRegex();

    public static LibrarySpec ParseSpec(string spec)
    {
        var matches = spec.Parse(SpecRegex(), forceNullOnWhitespce: true);
        return new(
            matches("SPEC")!,
            matches("NAME")!,
            matches("VERSION"),
            matches("PROVIDER"),
            matches("OPTIONS"),
            matches("FEATURES")
        );
    }

    internal static IEnumerable<XRepoLibraryRecord> InstallXRepoLibrary(UnrealBuild self, LibrarySpec spec, string options, AbsolutePath targetPath, bool debug)
    {
        options = options.AppendNonEmpty(",") + (debug
            ? "runtimes='MDd'"
            : "runtimes='MD'"
        );
        var xrepoPlatArch = self.Platform.GetXRepoPlatformArch();

        var extraArgs =
            $"""
            -p {xrepoPlatArch.Platform}
            -a {xrepoPlatArch.Arch}
            -m {(debug ? "debug" : "release")}
            """.AsSingleLine();

        // TODO: pass NDK location in

        XRepoTasks.Install(spec.Spec, options, extraArgs);
        
        string[] ProcessPaths(string? paths, AbsolutePath dstDir)
        {
            if (paths == null) return [];

            return paths!.Split(" ")
                .Select(i =>
                {
                    var currPath = (AbsolutePath) i;
                    var dstPath = dstDir / currPath.Name;
                    int ctr = 0;
                    while (dstPath.FileExists() || dstPath.DirectoryExists())
                    {
                        dstPath = dstDir / currPath.Name + $"_{ctr}";
                        ctr++;
                    }
                    currPath.LinkedByOrCopyTo(dstPath).Assume();
                    return dstPath.Name;
                })
                .ToArray();
        };

        return XRepoTasks.Info(spec.Spec, options, extraArgs)("").ParseXRepoInfo()
            .Where(i => i["fetchinfo"] != null)                                                          // needs fetchinfo
            .Where(i => !i["fetchinfo"]!.Any(i => i.Key?.ContainsOrdinalIgnoreCase("program") ?? false)) // ignore required programs
            .Where(i => !i["fetchinfo"]!["kind"]?.Value?.EqualsOrdinalIgnoreCase("binary") ?? true)      // ignore required executables
            .Select(i =>
            {
                Log.Information("Parsing library (dependency) {0}", i.Key);
                var currSpec = ParseSpec(i.Key!) with {
                    Version = i["version"]!.Value!
                };
                Log.Information("    Name: {0}", currSpec.Name);
                Log.Information("    Version: {0}", currSpec.Version);
                Log.Information("    Provider: {0}", currSpec.Provider ?? "xrepo");
                Log.Information("    Features: {0}", currSpec.Features);

                return new XRepoLibraryRecord(
                    Spec: currSpec,
                    Description: i["description"]?.Value,
                    Options: i["requires"]!["configs"]
                        !.Select(c => c.Key.AppendNonEmpty(": ") + c.Value)
                        .JoinNewLine(),
                    OptionsHelp: i["configs"]
                        ?.Select(c => c.Key.AppendNonEmpty(": ") + c.Value)
                        ?.JoinNewLine()
                        ?? "",
                    IncludePaths: ProcessPaths(
                        i["fetchinfo"]!["includedirs"]?.Value,
                        targetPath / currSpec.Name / "Includes"
                    ),
                    SysIncludePaths: ProcessPaths(
                        i["fetchinfo"]!["sysincludedirs"]?.Value,
                        targetPath / currSpec.Name / "SysIncludes"
                    ),
                    LibFiles: ProcessPaths(
                        i["fetchinfo"]!["libfiles"]?.Value,
                        targetPath / currSpec.Name / "Libs" / self.Platform / (debug ? "Debug" : "Release")
                    ),
                    SysLinks: i["fetchinfo"]!["syslinks"]?.Value?.Split(" ") ?? [],
                    Defines: i["fetchinfo"]!["defines"]?.Value?.Split(" ") ?? []
                );
            });
    }

    public static void InstallXRepoLibrary(this UnrealBuild self, string specIn, string options, AbsolutePath targetPath, string? suffix)
    {
        Log.Information("Installing library {0} via xrepo", specIn);
        var spec = ParseSpec(specIn) with { Options = options };
        Log.Information("    Name: {0}", spec.Name);
        Log.Information("    Version: {0}", spec.Version);
        Log.Information("    Provider: {0}", spec.Provider ?? "xrepo");
        Log.Information("    Options: {0}", spec.Options);
        Log.Information("    Features: {0}", spec.Features);

        Log.Information("Installing debug build");
        var debugLibs = InstallXRepoLibrary(self, spec, options, targetPath, true);
        
        Log.Information("Installing release build (metadata will be used from release build)");
        var releaseLibs = InstallXRepoLibrary(self, spec, options, targetPath, false);
        
        Log.Information("Generating partial module rule class for {0}", self.Platform);
        new XRepoLibraryModuleGenerator().Generate(
            self.TemplatesPath,
            targetPath,
            spec,
            self.Platform,
            releaseLibs,
            suffix
        );
    }
}