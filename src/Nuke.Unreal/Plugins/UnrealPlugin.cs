
using System;
using System.Collections.Generic;
using System.Linq;
using EverythingSearchClient;
using Newtonsoft.Json.Linq;
using Nuke.Cola.FolderComposition;
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
public record PluginDistributionOptions(
    RelativePath? OutputSubfolder = null,
    AbsolutePath? OutputOverride = null,
    bool GenerateFilterPluginIni = true
);

/// <summary>
///     Options for packaging plugins for binary distribution with UAT.
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
public record PluginBuildOptions(
    RelativePath? OutputSubfolder = null,
    AbsolutePath? OutputOverride = null,
    bool UseDistributedPlugin = true
);

/// <summary>
/// A class encapsulating information and tasks around one Unreal plugin.
/// </summary>
public class UnrealPlugin
{
    public static readonly Dictionary<AbsolutePath, UnrealPlugin> Instances = [];

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
                _explicitPluginFiles.Union(pluginRelativePaths.Select(f => f.ToUnixRelativePath()))
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

        var configPath = Folder / "Config" / "FilterPlugin.ini";
        Log.Debug("Generating FilterPlugin.ini: {0}", configPath);

        var lines = _explicitPluginFiles
            .Select(f => ("/" + f.ToString()).Replace("//", "/"))
            .Prepend("[FilterPlugin]");
        configPath.WriteAllLines(lines);
    }

    private readonly ExportManifest _filterExportManifest = new()
    {
        Copy = {
            new()
            {
                File = "Content/**/*" ,
                Not = {
                    "PluginFiles.yml", "*.uasset", "*.umap",
                }
            },
            new() { File = "Resources/**/*" ,  Not = { "PluginFiles.yml" }},
        },
        Not = {
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

    /// <summary>
    ///     Create a copy of this plugin which can be distributed to other developers or other tools
    ///     who shouldn't require extra non-unreal related steps to work with it.
    /// </summary>
    /// <param name="build"></param>
    /// <param name="options"></param>
    /// <param name="pretend"></param>
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

        if (!pretend && _explicitPluginFiles.Any(f => f.ToString().Contains("Binaries")))
        {
            // TODO: Handle delayed binary copy
        }

        var result = build.ImportFolder((Folder, outFolder, "PluginFiles.yml"), new(
            UseSubfolder: false,
            ForceCopyLinks: true,
            Pretend: pretend,
            AddToMain: [_filterExportManifest, new()
            {
                Copy = {
                    new() { File = "Config/**/*.ini" , Not = { "PluginFiles.yml" }},
                    new() { File = "Source/**/*" ,     Not = { "PluginFiles.yml" }},
                    new() { File = "*.uplugin" ,       Not = { "PluginFiles.yml" }},
                },
            }]
        ));

        return (result.WithFilesExpanded(), outFolder);
    }

    /// <summary>
    /// Make a prebuilt release of this plugin.
    /// </summary>
    /// <param name="build"></param>
    /// <param name="uatConfig"></param>
    /// <param name="buildOptions"></param>
    /// <param name="distOptions"></param>
    /// <returns></returns>
    public AbsolutePath BuildPlugin(
        UnrealBuild build,
        Func<UatConfig, UatConfig>? uatConfig = null,
        PluginBuildOptions? buildOptions = null,
        PluginDistributionOptions? distOptions = null
    ) {
        var outFolder = GetBuildOutput(build, buildOptions);
        buildOptions ??= _buildOptionsCache;

        var sourceFolder = Folder;
        if (buildOptions.UseDistributedPlugin)
        {
            var (_, distFolder) = DistributeSource(build, distOptions);
            sourceFolder = distFolder;
        }

        var hostProjectDir = build.GetOutput() / "Plugins" / Name / "HostProject";
        outFolder.CreateOrCleanDirectory();
        hostProjectDir.ExistingDirectory()?.DeleteDirectory();

        Unreal.AutomationTool(build, _ => _
            .BuildPlugin(_ => _
                .Plugin(sourceFolder / PluginPath.Name)
                .Package(outFolder)
                .TargetPlatforms(build.Platform)
                .If(Unreal.Is4(build), _ => _
                    .VS2019()
                )
                .NoDeleteHostProject()
                .Unversioned()
            )
            .Apply(uatConfig)
            .Apply(build.UatGlobal)
        )("");

        return outFolder;
    }
}