using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Nuke.Cola;
using Nuke.Cola.Tooling;
using Nuke.Common;
using Nuke.Common.IO;
using Nuke.Common.Utilities;
using Nuke.Common.Utilities.Collections;
using Nuke.Unreal.Platforms;
using Serilog;
using UPlugin = Nuke.Unreal.Plugins.UnrealPlugin;

namespace Nuke.Unreal.BoilerplateGenerators.XRepo;

/// <summary>
/// Utility classes for working with XRepo (or XMake) packages
/// </summary>
public static partial class XRepoLibrary
{
    [GeneratedRegex(
        """
        ^
        (?<SPEC>
            (?:(?<PROVIDER>\w+)\:\:)?
            (?<NAME>[\w\-\.]+)
            (?:\[
                (?<FEATURES>[\w\-,]+)
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

    /// <summary>
    /// Parses an input library spec string as a record
    /// </summary>
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

    internal static IEnumerable<XRepoLibraryRecord> InstallXRepoLibrary(INukeBuild build, UnrealPlatform platform, LibrarySpec spec, string options, AbsolutePath targetPath, bool debug, string runtime = "MD")
    {
        var libraryFiles = targetPath / "LibraryFiles";
        if (platform == UnrealPlatform.Win64)
        {
            options = options.AppendNonEmpty(",") + $"runtimes='{runtime}'";
        }
        var xrepoPlatArch = platform.GetXRepoPlatformArch();

        var sdk = platform.GetSdk();
        if (sdk != null)
        {
            Assert.True(sdk.IsValid(build), $"Attempting to use a platform which is not set up for cross compiling ({Unreal.GetHostPlatform()} -> {platform})");
            sdk.Setup(build).Wait();
        }

        var sdkXMakeData = sdk?.GetXMakeData(build);

        var extraArgs =
            $"""
            -p {sdkXMakeData?.Platform ?? xrepoPlatArch.Platform.ToString()}
            -a {xrepoPlatArch.Arch.ToCorrectString()}
            -m {(debug ? "debug" : "release")}
            """.AsSingleLine()
        ;
        if (sdkXMakeData != null)
        {
            extraArgs += " " + sdkXMakeData.Arguments;
        }

        XRepoTasks.Install(spec.Spec, options, extraArgs)("");
        
        string[] ProcessPaths(string? paths, AbsolutePath dstDir)
        {
            if (paths == null) return [];

            return paths!.Split(" ")
                .Select(i =>
                {
                    var currPath = (AbsolutePath) i;
                    var dstPath = dstDir / currPath.Name;
                    if (currPath.FileExists() || currPath.DirectoryExists())
                        currPath.Copy(dstPath, ExistsPolicy.MergeAndOverwrite);
                    else
                    {
                        Log.Warning("A library is referring to a non-existing file or folder: {0}", currPath);
                        return "";
                    }
                    return dstPath.Name;
                })
                .Where(p => !string.IsNullOrWhiteSpace(p))
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
                        libraryFiles / currSpec.Name / "Includes"
                    ),
                    SysIncludePaths: ProcessPaths(
                        i["fetchinfo"]!["sysincludedirs"]?.Value,
                        libraryFiles / currSpec.Name / "SysIncludes"
                    ),
                    LibFiles: ProcessPaths(
                        i["fetchinfo"]!["libfiles"]?.Value,
                        libraryFiles / currSpec.Name / "Libs" / platform / (debug ? "Debug" : "Release")
                    ),
                    SysLibs: i["fetchinfo"]!["syslinks"]?.Value
                        ?.Split(" ")
                        ?.Select(l => platform.IsWindows && !l.EndsWith(".lib") ? l + ".lib" : l)
                        ?? [],
                    Defines: i["fetchinfo"]!["defines"]?.Value?.Split(" ") ?? []
                );
            })
            .ToArray();
    }

    /// <summary>
    ///     Prepare a third-party library from an XRepo library spec for Unreal engine's consumption. Each platforms
    ///     will be considered which is listed under SupportedTargetPlatforms of the owning UPlugin. If it's empty
    ///     only consider the host platform.
    /// </summary>
    /// <param name="build">The build context</param>
    /// <param name="specIn">
    ///     The library spec specified here (without the options) https://mcro.de/Nuke.Unreal/d2/d84/CppLibraries.html
    /// </param>
    /// <param name="options">Comma separated '=' delimited key-value pairs. Space is not allowed around commas</param>
    /// <param name="targetPath">Where library files should be organized</param>
    /// <param name="supportedPlatforms">
    ///     Optionally limit the platforms considered for this library, if it shouldn't be compiled with all what's
    ///     listed in its UPlugin.
    /// </param>
    /// <param name="suffix">Optional addition to the name of library name exposed to Unreal</param>
    /// <param name="releaseRuntime">Windows CRT linkage for release versions (default is MD)</param>
    /// <param name="debugRuntime">Windows CRT linkage for debug versions (default is MD)</param>
    public static void InstallXRepoLibrary(this INukeBuild build, string specIn, string options, AbsolutePath targetPath, List<UnrealPlatform>? supportedPlatforms = null, string? suffix = null, string releaseRuntime = "MD", string debugRuntime = "MD")
    {
        Log.Information("Installing library {0} via xrepo", specIn);
        var spec = ParseSpec(specIn) with { Options = options };
        Log.Information("    Name: {0}", spec.Name);
        Log.Information("    Version: {0}", spec.Version);
        Log.Information("    Provider: {0}", spec.Provider ?? "xrepo");
        Log.Information("    Options: {0}", spec.Options);
        Log.Information("    Features: {0}", spec.Features);

        var platforms = UPlugin.Get(targetPath).Descriptor.SupportedTargetPlatforms;
        if (platforms == null || platforms.IsEmpty())
        {
            platforms = [Unreal.GetHostPlatform()];
        }

        foreach (var platform in platforms)
        {
            if (!supportedPlatforms.IsNullOrEmpty() && supportedPlatforms!.All(p => p != platform))
            {
                Log.Information("{0} platform has been skipped", platform);
                continue;
            }

            Log.Information("Installing debug build for {0}", platform);
            var debugLibs = InstallXRepoLibrary(build, platform, spec, options, targetPath, true, debugRuntime);

            Log.Information("Installing release build for {0}", platform);
            Log.Information("    (metadata will be used from release build)");
            var releaseLibs = InstallXRepoLibrary(build, platform, spec, options, targetPath, false, releaseRuntime);

            Log.Information("Generating partial module rule class for {0}", platform);
            new XRepoLibraryModuleGenerator().Generate(
                ((UnrealBuild) build).TemplatesPath,
                targetPath,
                spec,
                platform,
                releaseLibs,
                suffix
            );
        }
    }
}
