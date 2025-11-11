
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using EverythingSearchClient;
using Newtonsoft.Json.Linq;
using Nuke.Cola;
using Nuke.Cola.FolderComposition;
using Nuke.Cola.Search;
using Nuke.Common;
using Nuke.Common.IO;
using Nuke.Common.Utilities;
using Nuke.Common.Utilities.Collections;
using Nuke.Unreal.Tools;
using Serilog;

namespace Nuke.Unreal.Plugins;

/// <summary>
///     Options for creating a distributable version of this plugin, usually for making it
///     independent of Nuke.
/// </summary>
/// <param name="OutputSubfolder">
///     Relative path to the output folder indicated by `UnrealBuild.GetOutput()`.
///     Default is `Plugins/{Name}/Distribution`
/// </param>
/// <param name="OutputOverride">
///     If set, this will disregard both `UnrealBuild.GetOutput()` and `OutputSubfolder`, and use this
///     as the output of plugin distribution tasks
/// </param>
/// <param name="GenerateFilterPluginIni">
///     Generate a FilterPlugin.ini in the plugin's Config folder, so Unreal tools will not ignore
///     extra files handled with Nuke.
/// </param>
/// <param name="UPluginAssociateEngineVersion">
///     When set to true, distributing sources of plugins will write engine version to UPlugin file.
/// </param>
/// <param name="UPluginIsInstalled">
///     Mark plugin as Installed when distributing. Default is true
/// </param>
/// <param name="UPluginConfig">
///     Modify plugin descriptor for the distributed plugin after all other configuration is done.
/// </param>
public record class PluginDistributionOptions(
    RelativePath? OutputSubfolder = null,
    AbsolutePath? OutputOverride = null,
    bool GenerateFilterPluginIni = true,
    bool UPluginAssociateEngineVersion = true,
    bool UPluginIsInstalled = true,
    Func<PluginDescriptor, PluginDescriptor>? UPluginConfig = null
);

/// <summary>
/// Method of packaging a plugin.
/// </summary>
public enum PluginBuildMethod
{
    /// <summary>
    /// Use vanilla UAT BuildPlugin feature
    /// </summary>
    UAT,
    
    /// <summary>
    /// <para>
    ///     Nuke.Unreal will use UBT directly in a similar way than UAT does, but with extra
    ///     features/bugfixes that UAT doesn't have, for example automatically handle plugin
    ///     dependencies, but in a customizable way. This is the default method.
    /// </para>
    /// </summary>
    UBT
}

/// <summary>
///     Options for packaging plugins for binary distribution..
/// </summary>
/// <param name="OutputSubfolder">
///     Relative path to the output folder indicated by `UnrealBuild.GetOutput()`.
///     Default is `Plugins/{Name}/Build`
/// </param>
/// <param name="OutputOverride">
///     If set, this will disregard both `UnrealBuild.GetOutput()` and `OutputSubfolder`, and use this
///     as the output of plugin distribution tasks
/// </param>
/// <param name="UseDistributedPlugin">
///     If set to true, first make a distributed copy of this plugin and then package it with UAT
///     from that.
/// </param>
/// <param name="Method">
///     Select the method of packaging the plugin. If you have problems with duplicate types in your
///     module rules, then set this to PluginBuildMethod.UBT.
/// </param>
/// <param name="Platforms">
///     Extra platforms to build this plugin for. UnrealBuild.Platform is always added to this list.
/// </param>
public record class PluginBuildOptions(
    RelativePath? OutputSubfolder = null,
    AbsolutePath? OutputOverride = null,
    bool UseDistributedPlugin = true,
    PluginBuildMethod Method = PluginBuildMethod.UBT,
    UnrealPlatform[]? Platforms = null
);

/// <summary>
/// Arguments for BuildPlugin
/// </summary>
public record class PluginBuildArguments(
        Func<UatConfig, UatConfig>? UatConfig = null,
        Func<UbtConfig, UbtConfig>? UbtConfig = null,
        PluginBuildOptions? BuildOptions = null,
        PluginDistributionOptions? DistOptions = null,
        Func<UnrealPlugin, PluginBuildArguments, PluginBuildArguments?>? DependencyHandler = null
);

/// <summary>
/// A class encapsulating information and tasks around one Unreal plugin.
/// </summary>
public class UnrealPlugin
{
    public static readonly Dictionary<AbsolutePath, UnrealPlugin> Instances = [];
    internal static string RelativePathDistinction<T>(T path)
        => path!.ToString()!.Trim().Trim('/');

    /// <summary>
    ///     <para>
    ///         Get a `PluginInfo` instance from the path to its `.uplugin` file, or a file/folder
    ///         belonging to that plugin (in its subtree of files and folders). If a PluginInfo
    ///         doesn't exist yet, one will be created given that the associated plugin exists.
    ///     </para>
    ///     <para>
    ///         For example:
    ///     </para>
    ///     <code>
    ///         // In a local `MyPlugin.nuke.cs`
    ///         PluginInfo.Get(this.ScriptFolder()); // Gets or creates a `PluginInfo` about `MyPlugin.uplugin`
    ///     </code>
    /// </summary>
    /// <remarks>
    ///     Referring to non-existing plugins is a runtime error.
    /// </remarks>
    /// <param name="from"></param>
    /// <returns></returns>
    public static UnrealPlugin Get(AbsolutePath from)
    {
        var uplugin = from.FileExists() && from.HasExtension(".uplugin") ? from : from.GetOwningPlugin();
        Assert.NotNull(uplugin, $"Given plugin context {from} didn't contain an Unreal plugin");
        if (!Instances.ContainsKey(uplugin!))
        {
            Log.Debug("Handling plugin: {0}", uplugin!.NameWithoutExtension);
            Instances.Add(uplugin!, new (uplugin!));
        }
        return Instances[uplugin!];
    }

    internal UnrealPlugin(AbsolutePath uplugin)
    {
        PluginPath = uplugin;
        Descriptor = uplugin.ReadJson<PluginDescriptor>(Unreal.JsonReadSettings);
        if (FilterPluginIni.FileExists())
        {
            Log.Debug("Considering FilterPlugin.ini of {0}", Name);
            var inFiles = FilterPluginIni.ReadAllLines()
                .Where(l => !l.Contains("[FilterPlugin]"))
                .Where(l => !string.IsNullOrWhiteSpace(l))
                .Where(l => !l.StartsWith(';'))
                .Select(l => (RelativePath)l.Trim())
                .DistinctBy(RelativePathDistinction)
            ;
            AddExplicitPluginFiles(inFiles);
        }
    }

    /// <summary>
    /// Path to the `.uplugin` file
    /// </summary>
    public AbsolutePath PluginPath { get; private set; }

    /// <summary>
    /// "Immutable" C# representation of the uplugin file
    /// </summary>
    public PluginDescriptor Descriptor { get; private set; }

    /// <summary>
    /// Path to folder containing the `.uplugin` file
    /// </summary>
    public AbsolutePath Folder => PluginPath.Parent;

    public AbsolutePath ConfigFolder => Folder / "Config";
    public AbsolutePath FilterPluginIni => ConfigFolder / "FilterPlugin.ini";

    /// <summary>
    /// Short name of the plugin
    /// </summary>
    public string Name => PluginPath.NameWithoutExtension;

    private Version? _versionCache = null;

    /// <summary>
    ///     Semantic version of the plugin. Parsed from the `uplugin` file. If set, it will modify the
    ///     `.uplugin` file as well
    /// </summary>
    public Version Version
    {
        get => _versionCache ?? (
            Version.TryParse(Descriptor.VersionName ?? "", out var version)
            ? version
            : new()
        );
        set
        {
            Descriptor = Descriptor with { VersionName = value.ToString(3) };
            _versionCache = value;
            Unreal.WriteJson(Descriptor, PluginPath);
        }
    }

    private List<UnixRelativePath> _explicitPluginFiles = [];

    /// <summary>
    ///     Return list of files which may need extra mention for Unreal/Epic tools. This is also
    ///     usually the contents of FilterPlugin.ini
    /// </summary>
    public IEnumerable<AbsolutePath> ExplicitPluginFiles => _explicitPluginFiles
        .Select(f => Folder / f);

    /// <summary>
    ///     Add explicit plugin files to be listed later in FilterPlugin.ini
    /// </summary>
    /// <param name="files">
    ///     Absolute paths to the files. Relative paths will be calculated based on plugin root.
    /// </param>
    public void AddExplicitPluginFiles(IEnumerable<AbsolutePath> files)
        => AddExplicitPluginFiles(files.Select(f => Folder.GetRelativePathTo(f)));

    /// <summary>
    /// Add explicit plugin files to be listed later in FilterPlugin.ini
    /// </summary>
    public void AddExplicitPluginFiles(IEnumerable<RelativePath> pluginRelativePaths)
        => _explicitPluginFiles = [..
                _explicitPluginFiles
                    .UnionBy(
                        pluginRelativePaths.Select(f => f.ToUnixRelativePath()),
                        RelativePathDistinction
                    )
            ];

    private PluginDistributionOptions _distributionOptionsCache = new();
    private RelativePath _defaultDistSubdir => (RelativePath) $"Plugins/{Name}/Distribution";

    /// <summary>
    ///     Gets the output folder for distribution
    /// </summary>
    /// <param name="build"></param>
    /// <param name="options">
    ///     Optional argument to get the output from. If another functionality has cached this
    ///     before, this is not needed.
    /// </param>
    public AbsolutePath GetDistributionOutput(UnrealBuild build, PluginDistributionOptions? options = null)
    {
        options ??= _distributionOptionsCache;
        _distributionOptionsCache = options;
        
        var outputSubfolder = options.OutputSubfolder ?? _defaultDistSubdir;
        return options.OutputOverride ?? (build.GetOutput() / outputSubfolder);
    }

    private PluginBuildOptions _buildOptionsCache = new();
    private RelativePath _defaultBuildSubdir => (RelativePath) $"Plugins/{Name}/Build";

    /// <summary>
    ///     Gets the output folder for packaging this plugin
    /// </summary>
    /// <param name="build"></param>
    /// <param name="options">
    ///     Optional argument to get the output from. If another functionality has cached this
    ///     before, this is not needed.
    /// </param>
    public AbsolutePath GetBuildOutput(UnrealBuild build, PluginBuildOptions? options = null)
    {
        options ??= _buildOptionsCache;
        _buildOptionsCache = options;
        
        var outputSubfolder = options.OutputSubfolder ?? _defaultBuildSubdir;
        return options.OutputOverride ?? (build.GetOutput() / outputSubfolder);
    }

    /// <summary>
    ///     Generate the `FilterPlugin.ini` file after all components have submitted their
    ///     explicit files.
    /// </summary>
    public void GenerateFilterPluginIni(UnrealBuild build)
    {
        AddDefaultExplicitPluginFiles(build);

        var configPath = FilterPluginIni;
        Log.Debug("Generating FilterPlugin.ini: {0}", configPath);

        var lines = _explicitPluginFiles
            .Select(f => ("/" + f.ToString()).Replace("//", "/"))
            .Distinct()
        ;
        if (!lines.IsEmpty())
            configPath.WriteAllLines(lines.Prepend("[FilterPlugin]"));
        else
            Log.Debug("There were no files to list in FilterPlugin.ini");
    }

    private static readonly ExportManifest _filterExportManifest = new()
    {
        Copy = { new() { File = "Config/**/*.ini" , Not = {"FilterPlugin.ini"}} },
        Not = {
            "PluginFiles.yml",
            "*.nuke.cs",
            "*.nuke.csx",
            "Nuke.Targets",
            ".Nuke",
            ".git",
            ".gitignore",
            ".p4ignore",
        },
        Use = {
            new() { File = "**/PluginFiles.yml" }
        }
    };

    private IEnumerable<AbsolutePath> GetDefaultExplicitPluginFiles(UnrealBuild build)
        => build.ImportFolder((Folder, Folder.Parent / "ShouldntExist", "PluginFiles.yml"), new(
                Pretend: true,
                UseSubfolder: false,
                ForceCopyLinks: true,
                AddToMain: [_filterExportManifest]
            )).WithFilesExpanded().Select(f => f.From);

    private void AddDefaultExplicitPluginFiles(UnrealBuild build)
        => AddExplicitPluginFiles(GetDefaultExplicitPluginFiles(build));

    private bool InjectBinaryPlumbing(PluginDescriptor descriptor, out PluginDescriptor result)
    {
        var plumbingRootRelative = (RelativePath) "Source" / "ThirdParty" / "BinaryPlumbing";
        var plumbingRoot = Folder / plumbingRootRelative;
        if (!plumbingRoot.DirectoryExists())
        {
            result = descriptor;
            return false;
        }

        Log.Information("{0} seemingly requires binary plumbing", Name);
        Log.Debug("Because {0} exists", plumbingRoot);

        result = descriptor with {
            PreBuildSteps = descriptor.PreBuildSteps?.ToDictionary() ?? []
        };
        result.PreBuildSteps.EnsureDevelopmentPlatforms();
        
        foreach (var platform in UnrealPlatform.DevelopmentPlatforms)
        {
            result.PreBuildSteps[platform] = [..
                result.PreBuildSteps[platform]
                    .FilterBuildStepBlock("BinaryPlumbing")
                    .StartBuildStepBlock("BinaryPlumbing"),
                $"echo Plumbing runtime dependencies for {Name} plugin",
            ];
        }
        
        foreach (var subdir in plumbingRoot.GetDirectories())
        {
            Log.Debug("Plumbing from {0}", subdir);

            result.PreBuildSteps[UnrealPlatform.Win64].AddRange([
                $"echo Copying {subdir.Name} runtime dependencies",
                $"robocopy /s /v /njh /njs /np /ndl \"$(PluginDir)\\{plumbingRootRelative.ToWinRelativePath()}\\{subdir.Name}\" \"$(PluginDir)\\Binaries\"",
                "if %ERRORLEVEL% LSS 8 (exit /B 0) else (exit /B %ERRORLEVEL%)"
            ]);

            result.PreBuildSteps[UnrealPlatform.Linux].AddRange([
                $"echo Copying {subdir.Name} runtime dependencies",
                $"cp -vnpR \"$(PluginDir)/{plumbingRootRelative.ToUnixRelativePath()}/{subdir.Name}\" \"$(PluginDir)/Binaries\"",
                "chmod -R +x \"$(PluginDir)/Binaries\""
            ]);

            result.PreBuildSteps[UnrealPlatform.Mac].AddRange([
                $"echo Copying {subdir.Name} runtime dependencies",
                $"cp -vnpR \"$(PluginDir)/{plumbingRootRelative.ToUnixRelativePath()}/{subdir.Name}\" \"$(PluginDir)/Binaries\"",
                "chmod -R +x \"$(PluginDir)/Binaries\""
            ]);
        }

        return true;
    }

    /// <summary>
    ///     Create a copy of this plugin which can be distributed to other developers or other tools
    ///     who shouldn't require extra non-unreal related steps to work with it.
    /// </summary>
    /// <param name="build"></param>
    /// <param name="options">Optional arguments for distribution</param>
    /// <param name="pretend">
    ///     Do not have side effects on files, just return a list of files which may be affected
    ///     by this operation.
    /// </param>
    /// <returns>
    ///     <list type="bullet">
    ///         <item>result: List of files which has been copied</item>
    ///         <item>output: Output folder of distribution</item>
    ///     </list>
    /// </returns>
    public (IEnumerable<ImportedItem> result, AbsolutePath output) DistributeSource(
        UnrealBuild build,
        PluginDistributionOptions? options = null,
        bool pretend = false
    ) {
        var outFolder = GetDistributionOutput(build, options);
        options ??= _distributionOptionsCache;

        if (options.GenerateFilterPluginIni && !pretend)
            GenerateFilterPluginIni(build);

        var result = build.ImportFolder((Folder, outFolder, "PluginFiles.yml"), new(
            UseSubfolder: false,
            ForceCopyLinks: true,
            Pretend: pretend,
            AddToMain: [_filterExportManifest, new()
            {
                Copy = {
                    new() { File = "Content/**/*" ,    Not = { "PluginFiles.yml" }},
                    new() { File = "Shaders/**/*" ,    Not = { "PluginFiles.yml" }},
                    new() { File = "Source/**/*" ,     Not = { "PluginFiles.yml" }},
                    new() { File = "Resources/**/*" ,  Not = { "PluginFiles.yml" }},
                    new() { File = "Tests/**/*" ,      Not = { "PluginFiles.yml" }},
                    new() { File = "*.uplugin" ,       Not = { "PluginFiles.yml" }},
                },
            }]
        ));
        
        var outUPlugin = outFolder / PluginPath.Name;

        var descriptor = Descriptor with {};

        if (!pretend && options.UPluginAssociateEngineVersion)
        {
            descriptor = descriptor with { EngineVersion = Unreal.Version(build).VersionMinor + ".0" };
            Unreal.WriteJson(descriptor, outUPlugin);
        }
        
        if (!pretend && InjectBinaryPlumbing(descriptor, out descriptor))
        {
            Unreal.WriteJson(descriptor, outUPlugin);
        }

        if (!pretend && options.UPluginIsInstalled)
        {
            descriptor = descriptor with { Installed = true };
            Unreal.WriteJson(descriptor, outUPlugin);
        }

        if (!pretend && options.UPluginConfig != null)
        {
            descriptor = options.UPluginConfig(descriptor);
            Unreal.WriteJson(descriptor, outUPlugin);
        }

        return (result.WithFilesExpanded(), outFolder);
    }

    /// <summary>
    /// Get the project plugin dependencies of this plugin as UnrealPlugin objects.
    /// </summary>
    /// <param name="build"></param>
    /// <returns></returns>
    IEnumerable<UnrealPlugin> GetProjectPluginDependencies(UnrealBuild build)
        => Descriptor.Plugins?
            .Where(p => p.Enabled ?? false)
            .Select(p =>
            {
                var depFIle = build.PluginsFolder.SearchFiles($"**/{p.Name}.uplugin").FirstOrDefault();
                return depFIle != null ? Get(depFIle) : null;
            })
            .Where(p => p != null)
            .Select(p => p!)
            ?? []
        ;

    private AbsolutePath? _buildOutput = null;

    /// <summary>
    /// Make a prebuilt release of this plugin for end-users. Globally set UAT and UBT arguments
    /// are used from the input UnrealBuild
    /// </summary>
    /// <param name="build"></param>
    /// <param name="uatConfig">Configurator for UAT</param>
    /// <param name="ubtConfig">Configurator for UBT (only when UBT method is used)</param>
    /// <param name="buildOptions">Optional arguments for packaging</param>
    /// <param name="distOptions">Optional arguments for distribution</param>
    /// <param name="dependencyHandler">Customize the build option for plugin dependencies</param>
    /// <returns>Output folder of the packaged plugin</returns>
    public AbsolutePath BuildPlugin(
        UnrealBuild build,
        Func<UatConfig, UatConfig>? uatConfig = null,
        Func<UbtConfig, UbtConfig>? ubtConfig = null,
        PluginBuildOptions? buildOptions = null,
        PluginDistributionOptions? distOptions = null,
        Func<UnrealPlugin, PluginBuildArguments, PluginBuildArguments?>? dependencyHandler = null
    ) {
        var outFolder = GetBuildOutput(build, buildOptions);
        buildOptions ??= _buildOptionsCache;
        uatConfig ??= _ => _;
        ubtConfig ??= _ => _;

        var sourceFolder = Folder;
        if (buildOptions.UseDistributedPlugin || buildOptions.Method == PluginBuildMethod.UBT)
        {
            var (_, distFolder) = DistributeSource(build, distOptions);
            sourceFolder = distFolder;
        }

        var hostProjectDir = build.GetOutput() / "Plugins" / Name / "HostProject";
        outFolder.CreateOrCleanDirectory();
        hostProjectDir.ExistingDirectory()?.DeleteDirectory();
        
        var platforms = (buildOptions.Platforms ?? []).Union([build.Platform]);
        
        var dependencies = GetProjectPluginDependencies(build).ToList();
        var thisArgs = new PluginBuildArguments(
            uatConfig,
            ubtConfig,
            buildOptions,
            distOptions,
            dependencyHandler
        );

        foreach (var unbuiltDep in dependencies.Where(d => d._buildOutput == null))
        {
            Log.Information("Building dependency plugin {0}", unbuiltDep.Name);
            var args = dependencyHandler?.Invoke(unbuiltDep, thisArgs) ?? thisArgs;
            unbuiltDep.BuildPlugin(
                build,
                args.UatConfig,
                args.UbtConfig,
                args.BuildOptions,
                args.DistOptions,
                args.DependencyHandler
            );
        }
        var enginePluginsDir = build.UnrealEnginePath / "Engine" / "Plugins" / "Marketplace";
        foreach (var dep in dependencies)
        {
            Log.Information("Copying dependency plugin {0} to {1}", dep.Name, enginePluginsDir);
            dep._buildOutput.Copy(enginePluginsDir / dep.Name);
        }

        switch (buildOptions.Method)
        {

        case PluginBuildMethod.UAT:
            var shortSource = sourceFolder.Shorten();
            var shortOut = outFolder.Shorten();
            try
            {
                Unreal.AutomationTool(build, _ => _
                    .BuildPlugin(_ => _
                        .Plugin(shortSource / PluginPath.Name)
                        .Package(shortOut)
                        .TargetPlatforms(string.Join('+', platforms))
                        .If(Unreal.Is4(build), _ => _
                            .VS2019()
                        )
                        .Unversioned()
                    )
                    .Apply(build.UatGlobal)
                    .Apply(uatConfig)
                )("");
                _buildOutput = outFolder;
            }
            catch (Exception) { throw; }
            finally
            {
                if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                {
                    shortSource.DeleteDirectory();
                    shortOut.AsLinkInfo()?.Delete();
                }
            }

        break;

        case PluginBuildMethod.UBT:

            hostProjectDir.CreateDirectory();
            var hostPluginDir = hostProjectDir / "Plugins" / Name;
            var hostProject = new ProjectDescriptor(
                EngineAssociation: build.ProjectDescriptor.EngineAssociation,
                Plugins: [
                    new (Name: Name, Enabled: true),
                    ..
                    dependencies.Select(d => new PluginReferenceDescriptor(
                        Name: d.Name,
                        Enabled: true
                    ))
                ]
            );
            Unreal.WriteJson(hostProject, hostProjectDir / "HostProject.uproject");
            sourceFolder.Copy(hostPluginDir);

            var shortHostProjectDir = hostProjectDir.Shorten();
            var shortPluginDir = shortHostProjectDir / "Plugins" / Name;
            try
            {
                UbtConfig Common(UbtConfig _) => _
                    .NoHotReload()
                    .Apply(build.UbtGlobal)
                    .Apply(ubtConfig)
                ;
                UbtConfig CommonProject(UbtConfig _) => _
                    .Project(shortHostProjectDir / "HostProject.uproject")
                    .Apply(Common)
                ;
                UbtConfig CommonPlugin(UbtConfig _) => _
                    .Plugin(shortPluginDir / PluginPath.Name)
                    .Apply(Common)
                ;

                foreach(var platform in platforms)
                {
                    Log.Information("Building UnrealGame binaries from UProject for {0} @ {1}", Name, platform);
                    Unreal.BuildTool(build, _ => _
                        .Target("UnrealGame", platform,
                        [
                            UnrealConfig.Development,
                            UnrealConfig.Shipping
                        ])
                        .Apply(CommonProject)
                    )("");
                    if (platform.IsDevelopment)
                    {
                        Log.Information("Building UnrealEditor binaries for UProject {0} @ {1}", Name, platform);
                        Unreal.BuildTool(build, _ => _
                            .Target("UnrealEditor", platform, [UnrealConfig.Development])
                            .Apply(CommonProject)
                        )("");
                    }
                    Log.Information("Building UnrealGame binaries from UPlugin for {0} @ {1}", Name, platform);
                    Unreal.BuildTool(build, _ => _
                        .Target("UnrealGame", platform,
                        [
                            UnrealConfig.Development,
                            UnrealConfig.Shipping
                        ])
                        .Apply(CommonPlugin)
                    )("");
                    if (platform.IsDevelopment)
                    {
                        Log.Information("Building UnrealEditor binaries for UPlugin {0} @ {1}", Name, platform);
                        Unreal.BuildTool(build, _ => _
                            .Target("UnrealEditor", platform, [UnrealConfig.Development])
                            .Apply(CommonPlugin)
                        )("");
                    }
                }
                hostPluginDir.Copy(outFolder, ExistsPolicy.MergeAndOverwrite);
                hostProjectDir.DeleteDirectory();
                _buildOutput = outFolder;
            }
            catch(Exception) { throw; }
            finally
            {
                if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                    shortPluginDir.AsLinkInfo()?.Delete();
                
                foreach (var dep in dependencies)
                {
                    Log.Debug("Deleting temporary installed plugin {0}", enginePluginsDir / dep.Name);
                    (enginePluginsDir / dep.Name).ExistingDirectory()?.DeleteDirectory();
                }
            }
        break;

        }

        return outFolder;
    }
}

public static class UnrealPluginExtensions
{
    internal static IEnumerable<string> FilterBuildStepBlock(this IEnumerable<string> self, string name)
        => self
            .TakeUntil(a => a == "echo GENERATED BUILD STEPS".AppendNonEmpty(name))
            .Concat(
                self.SkipUntil(a => a == "echo GENERATED BUILD STEPS".AppendNonEmpty(name))
                .Skip(1)
                .SkipUntil(a => a.StartsWith("echo GENERATED BUILD STEPS"))
            );
    
    internal static IEnumerable<string> StartBuildStepBlock(this IEnumerable<string> self, string name)
        => self.Append("echo GENERATED BUILD STEPS".AppendNonEmpty(name));

    internal static void EnsureDevelopmentPlatforms(this Dictionary<UnrealPlatform, List<string>> self)
    {
        foreach (var platform in UnrealPlatform.DevelopmentPlatforms)
        {
            if (!self.ContainsKey(platform)) self.Add(platform, []);
        }
    }

    public static UbtConfig StrictIncludes(this UbtConfig _) => _
        .NoPCH()
        .NoSharedPCH()
        .DisableUnity();
}