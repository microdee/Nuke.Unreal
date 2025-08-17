using System;
using System.Collections.Generic;
using Nuke.Common;
using System.Xml.Serialization;
using System.IO;
using System.Linq;
using Nuke.Common.IO;
using Nuke.Common.Tooling;
using System.Runtime.CompilerServices;
using Nuke.Cola.FolderComposition;
using Nuke.Common.Utilities;
using Nuke.Unreal.BoilerplateGenerators;

namespace Nuke.Unreal.Modules;

public enum RuntimeDependencyConfig
{
    Debug,
    Release,
    All
}

public class RuntimeLibraryPath
{
    public required RelativePath Path;
    public UnrealPlatform Platform = UnrealPlatform.Independent;
    public RuntimeDependencyConfig Config = RuntimeDependencyConfig.All;
}

public class RuntimeDependency
{
    public string Value = "";
    public UnrealPlatform Platform = UnrealPlatform.Independent;
    public RuntimeDependencyConfig Config = RuntimeDependencyConfig.All;
};

public class RuntimeDependencies
{
    public string ModuleName = "";
    public List<RuntimeDependency> RuntimeLibraryPath = [];
    public List<RuntimeDependency> Files = [];
    public List<RuntimeDependency> Dlls = [];
}

public class AutoRuntimeDependencyGenerator : BoilerplateGenerator
{
    public void Generate(AbsolutePath templatesPath, AbsolutePath currentFolder, RuntimeDependencies model)
    {
        var templateSubFolder = "AutoRuntimeDependency";
        if (!(templatesPath / templateSubFolder).DirectoryExists())
            templatesPath = DefaultTemplateFolder;

        var templateDir = templatesPath / templateSubFolder;
        RenderFolder(templateDir, currentFolder, model);
    }
}

public static class RuntimeDependenciesExtensions
{
    /// <summary>
    /// <para>
    /// Prepare and transform a group of files for neatly be packaged as runtime dependencies in
    /// conventional locations. This aims to alleviate some chore regarding working with elaborate
    /// third-party/prebuilt libraries.
    /// </para>
    /// <para>
    /// The result of this function is a partial module rule C# file which will list runtime
    /// dependencies in a partial method called `SetupRuntimeDependencies`. Please take care that
    /// the main module rules class for the target module is also partial.
    /// </para>
    /// <para>
    /// Here's the overview of the usage of this function.
    /// </para>
    /// <list type="number">
    /// <item>
    /// Provide a source folder for the runtime dependencies
    /// </item>
    /// <item>
    /// Provide a set of locations in runtime, relative to the destination folder serving as
    /// runtime library paths (ideally one for each supported platforms). This may be used as base
    /// folders to load DLL's from.
    /// </item>
    /// <item>
    /// If applicable provide pattern matching functions to determine the platform and configuration
    /// for individual files
    /// </item>
    /// <item>
    /// To control the destination folder structure PrepareRuntimeDependencies may pick up a folder
    /// composition manifest file called "RuntimeDeps.yml" (by default this can be also overridden)
    /// </item>
    /// <item>
    /// If no such manifest is available one can be passed directly in C#
    /// </item>
    /// </list>
    /// <para>
    /// Output files will be put into
    /// `&lt;plugin-directory&gt;/Binaries/&lt;binariesSubfolder&gt;/&lt;moduleName&gt;`. Where
    /// `binariesSubfolder` is "ThirdParty" by default.
    /// </para>
    /// <para>
    /// For example:
    /// </para>
    /// <code>
    /// [ImplicitBuildInterface]
    /// public interface IMyPluginTargets : INukeBuild
    /// {
    ///     Target PrepareMyPlugin =&gt; _ =&gt; _
    ///         .Executes(() =&gt;
    ///         {
    ///             this.PrepareRuntimeDependencies(
    ///                 this.ScriptFolder(),
    ///                 [ new() {Path = (RelativePath)&quot;Win64&quot; } ],
    ///                 determinePlatform: f =&gt; UnrealPlatform.Win64,
    ///                 customManifest: new()
    ///                 {
    ///                     Copy = [
    ///                         new() {Directory = &quot;tools&quot;},
    ///                         new() {
    ///                             Directory = &quot;sdk/windows-desktop/amd64/release/bin&quot;,
    ///                             As = &quot;Win64&quot;
    ///                         },
    ///                     ]
    ///                 }
    ///             );
    ///         });
    /// }
    /// </code>
    /// </summary>
    /// <param name="self"></param>
    /// <param name="sourceFolder">
    /// Required. The root folder of the third-party library. Ideally the same folder as the
    /// external module representing the library for Unreal.
    /// </param>
    /// <param name="runtimeLibraryPaths">
    /// Required. A a set of locations in runtime, relative to the destination folder serving as
    /// runtime library paths (ideally one for each supported platforms). This may be used as base
    /// folders to load DLL's from.
    /// </param>
    /// <param name="determineConfig">
    /// Optional. Determin a configuration (either debug or release) from a given runtime dependency
    /// file. If the file is needed in all configurations return `RuntimeDependencyConfig.All`.
    /// This predicate is also applied to DLL's, there are no assumptions about them, solely based
    /// on their file paths. By default every file is assumed for all configurations.
    /// </param>
    /// <param name="determinePlatform">
    /// Optional. Determin a target platform from a given runtime dependency file. If the file is
    /// needed on all platforms return `UnrealPlatform.Independent`. This predicate is also applied
    /// to DLL's, there are no assumptions about them, solely based on their file paths. By default
    /// every file is assumed for all platforms.
    /// </param>
    /// <param name="moduleName">
    /// Optional. By default derived from the folder name provided with `sourceFolder`
    /// </param>
    /// <param name="pluginFolder">
    /// Optional. By default it's the owning plugin of the `sourceFolder`
    /// </param>
    /// <param name="customManifest">
    /// Optional. Provide a folder composition manifest if the target file-folder structure is
    /// different than the input one. Default is empty (just copy folder structure as-is)
    /// </param>
    /// <param name="manifestFilePattern">
    /// Optional. The file name of an optional folder composition manifest which may reside in
    /// `sourceFolder`. Default is "RuntimeDeps.y*ml"
    /// </param>
    /// <param name="binariesSubfolder">
    /// Optional. The subfolder name in the plugin Binaries where everything else is copied into.
    /// Default is "ThirdParty".
    /// </param>
    /// <param name="moduleRuleOutput"></param>
    public static void PrepareRuntimeDependencies(
        this UnrealBuild self,
        AbsolutePath sourceFolder,
        IEnumerable<RuntimeLibraryPath> runtimeLibraryPaths,
        Func<AbsolutePath, RuntimeDependencyConfig>? determineConfig = null,
        Func<AbsolutePath, UnrealPlatform>? determinePlatform = null,
        string? moduleName = null,
        AbsolutePath? pluginFolder = null,
        ExportManifest? customManifest = null,
        string manifestFilePattern = "RuntimeDeps.y*ml",
        string binariesSubfolder = "ThirdParty",
        AbsolutePath? moduleRuleOutput = null
    )
    {
        pluginFolder ??= sourceFolder.GetOwningPlugin()!.Parent;
        determineConfig ??= p => RuntimeDependencyConfig.All;
        determinePlatform ??= p => UnrealPlatform.Independent;
        moduleName ??= sourceFolder.Name;
        moduleRuleOutput ??= sourceFolder;

        var dstFolder = pluginFolder / "Binaries" / binariesSubfolder;

        if (customManifest == null)
            self.ImportFolders((sourceFolder, dstFolder, manifestFilePattern));
        else
            self.ImportFolders((sourceFolder, dstFolder, customManifest, manifestFilePattern));

        var runtimeDeps = (dstFolder / moduleName).GetFiles(depth: 40);
        var dllDeps = (dstFolder / moduleName / self.Platform).GetFiles(depth: 40)
            .Where(f => UnrealPlatform.Platforms.Any(
                p => f.Extension.EqualsOrdinalIgnoreCase("." + p.DllExtension)
            ));

        var model = new RuntimeDependencies
        {
            ModuleName = moduleName,
            Files = [.. runtimeDeps.Select(f => new RuntimeDependency
            {
                Value = pluginFolder.GetRelativePathTo(f).ToUnixRelativePath(),
                Config = determineConfig(f),
                Platform = determinePlatform(f)
            })],

            Dlls = [.. dllDeps.Select(f => new RuntimeDependency
            {
                Value = f.Name,
                Config = determineConfig(f),
                Platform = determinePlatform(f)
            })],

            RuntimeLibraryPath = [.. runtimeLibraryPaths.Select(p => new RuntimeDependency
            {
                Value = $"Binaries/{binariesSubfolder}/{p.Path.ToUnixRelativePath()}",
                Config = p.Config,
                Platform = p.Platform
            })]
        };

        new AutoRuntimeDependencyGenerator().Generate(self.TemplatesPath, moduleRuleOutput, model);
    }
}