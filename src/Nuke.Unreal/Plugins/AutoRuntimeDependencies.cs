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
using System.Collections;
using Serilog;

namespace Nuke.Unreal.Plugins;

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
    public string Origin = "";
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
    ///     <para>
    ///         Prepare and transform a group of files for neatly be packaged as runtime
    ///         dependencies in conventional locations. This aims to alleviate some chore regarding
    ///         working with elaborate third-party/prebuilt libraries. Files are copied by
    ///         Nuke.Unreal but let UBT do it.
    ///     </para>
    ///     <para>
    ///         The result of this function is a partial module rule C# file which will list runtime
    ///         dependencies in a partial method called `SetupRuntimeDependencies`. Please take care
    ///         that the main module rules class for the target module is also partial.
    ///     </para>
    ///     <para>
    ///         Here's the overview of the usage of this function.
    ///     </para>
    ///     <list type="number">
    ///         <item>
    ///             Provide a source folder for the runtime dependencies
    ///         </item>
    ///         <item>
    ///             Provide a set of locations in runtime, relative to the destination folder serving
    ///             as runtime library paths (ideally one for each supported platforms). This may be
    ///             used as base folders to load DLL's from.
    ///         </item>
    ///         <item>
    ///             If applicable provide pattern matching functions to determine the platform and
    ///             configuration for individual files
    ///         </item>
    ///         <item>
    ///             To control the destination folder structure PrepareRuntimeDependencies may pick
    ///             up a folder composition manifest file called "RuntimeDeps.yml" (by default this
    ///             can be also overridden)
    ///         </item>
    ///         <item>
    ///             If no such manifest is available one can be passed directly in C#
    ///         </item>
    ///     </list>
    ///     <para>
    ///         The module rule will copy output files on building the project to
    ///         `&lt;plugin-directory&gt;/Binaries/&lt;binariesSubfolder&gt;/&lt;moduleName&gt;`.
    ///         Where `binariesSubfolder` is "ThirdParty" by default.
    ///     </para>
    ///     <para>
    ///         For example:
    ///     </para>
    ///     <code>
    ///         [ImplicitBuildInterface]
    ///         public interface IMyPluginTargets : INukeBuild
    ///         {
    ///             Target PrepareMyPlugin =&gt; _ =&gt; _
    ///                 .Executes(() =&gt;
    ///                 {
    ///                     this.PrepareRuntimeDependencies(
    ///                         this.ScriptFolder(),
    ///                         [ new() {Path = (RelativePath)&quot;Win64&quot; } ],
    ///                         determinePlatform: f =&gt; UnrealPlatform.Win64,
    ///                         customManifest: new()
    ///                         {
    ///                             Copy = [
    ///                                 new() {Directory = &quot;tools&quot;},
    ///                                 new() {
    ///                                     Directory = &quot;sdk/windows-desktop/amd64/release/bin&quot;,
    ///                                     As = &quot;Win64&quot;
    ///                                 },
    ///                             ]
    ///                         }
    ///                     );
    ///                 });
    ///         }
    ///     </code>
    /// </summary>
    /// <remarks>
    ///     This will create a "copy" of the binaries subfolder in Plugin sources, so Fab
    ///     compatibility can be ensured. This "copy" is just done with symlinks, not actual copies
    ///     of binaries. This wisdom has been bestowed upon us by the author of CefView
    ///     https://forums.unrealengine.com/t/copy-3rd-party-dlls-to-binaries-folder-does-not-work-for-engine-plugin-how-to-solve/738255/6
    /// </remarks>
    /// <param name="self"></param>
    /// <param name="sourceFolder">
    ///     Required. The root folder of the third-party library. Ideally the same folder as the
    ///     external module representing the library for Unreal.
    /// </param>
    /// <param name="runtimeLibraryPaths">
    ///     Required. A a set of locations in runtime, relative to the destination folder serving as
    ///     runtime library paths (ideally one for each supported platforms). This may be used as
    ///     base folders to load DLL's from.
    /// </param>
    /// <param name="determineConfig">
    ///     Optional. Determin a configuration (either debug or release) from a given runtime
    ///     dependency file. If the file is needed in all configurations return
    ///     `RuntimeDependencyConfig.All`. This predicate is also applied to DLL's, there are no
    ///     assumptions about them, solely based on their file paths. By default every file is
    ///     assumed for all configurations.
    /// </param>
    /// <param name="determinePlatform">
    ///     Optional. Determin a target platform from a given runtime dependency file. If the file
    ///     is needed on all platforms return `UnrealPlatform.Independent`. This predicate is also
    ///     applied to DLL's, there are no assumptions about them, solely based on their file paths.
    ///     By default every file is assumed for all platforms.
    /// </param>
    /// <param name="moduleName">
    ///     Optional. By default derived from the folder name provided with `sourceFolder`
    /// </param>
    /// <param name="pluginFolder">
    ///     Optional. By default it's the owning plugin of the `sourceFolder`
    /// </param>
    /// <param name="customManifest">
    ///     Optional. Provide a folder composition manifest if the target file-folder structure is
    ///     different than the input one. Default is empty (just copy folder structure as-is)
    /// </param>
    /// <param name="manifestFilePattern">
    ///     Optional. The file name of an optional folder composition manifest which may reside in
    ///     `sourceFolder`. Default is "RuntimeDeps.y*ml"
    /// </param>
    /// <param name="binariesSubfolder">
    ///     Optional. The subfolder name in the plugin Binaries where everything else is copied into.
    ///     Default is "ThirdParty".
    /// </param>
    /// <param name="moduleRuleOutput">
    ///     Optional. A custom folder output for the generated module rule file.
    ///     Default is `sourceFolder`.
    /// </param>
    /// <param name="setFilterPlugin">
    ///     Enqueue referred files and their destination locations in the owning plugin instance.
    ///     Default is true.
    /// </param>
    /// <param name="pretend">
    ///     Optional. If true only list affected files, but do not modify files or generate a module
    ///     rule. Default is false.
    /// </param>
    public static IEnumerable<ImportedItem> PrepareRuntimeDependencies(
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
        AbsolutePath? moduleRuleOutput = null,
        bool setFilterPlugin = true,
        bool pretend = false
    ) {
        pluginFolder ??= sourceFolder.GetOwningPlugin()!.Parent;
        determineConfig ??= p => RuntimeDependencyConfig.All;
        determinePlatform ??= p => UnrealPlatform.Independent;
        moduleName ??= sourceFolder.Name;
        moduleRuleOutput ??= sourceFolder;

        Log.Information(
            """
            Preparing runtime dependencies:
            For plugin:           {0}
                folder:           {1}
            For module:           {2}
                folder:           {3}
                Result .build.cs: {4}
            """,
            pluginFolder.Name, pluginFolder,
            moduleName, sourceFolder,
            moduleRuleOutput
        );

        var dstFolder = pluginFolder / "Binaries" / binariesSubfolder;
        var options = new ImportOptions(
            Pretend: pretend
        );
        var deps = (
                customManifest == null
                ? self.ImportFolder((sourceFolder, dstFolder, manifestFilePattern), options)
                : self.ImportFolder((sourceFolder, dstFolder, customManifest, manifestFilePattern), options)
            ).WithFilesExpanded().ToList();

        if (setFilterPlugin)
        {
            var thisPlugin = UnrealPlugin.Get(pluginFolder);
            thisPlugin.AddExplicitPluginFiles(deps.Select(d => d.To));

            if (!pretend)
            {
                Log.Debug("Generating FilterPlugin.ini for {0}", thisPlugin.Name);
                thisPlugin.GenerateFilterPluginIni(self);
            }
        }

        if (!pretend)
        {
            var binaryPlumbingTemporary = pluginFolder
                / "Source"
                / "ThirdParty"
                / "BinaryPlumbing"
                / moduleName
                / binariesSubfolder
                / sourceFolder.Name
            ;
            Log.Debug("For marketplace compatibility these binaries will be linked within the Source folder as well.");
            Log.Debug("Plugin distribution will ship these binaries in the Source folder, not in Binaries folder for Fab compatibility.");
            Log.Information("Binary-plumbing folder: {0}", binaryPlumbingTemporary);
            self.ImportFolder((dstFolder / sourceFolder.Name, binaryPlumbingTemporary), new(UseSubfolder: false));
        }

        var dllDeps = deps
            .Where(d => UnrealPlatform.Platforms.Any(
                p => d.From.Extension.EqualsOrdinalIgnoreCase("." + p.DllExtension)
            ));

        Log.Debug("DLL's handled: {0}", dllDeps.Select(d => d.To.Name));

        var model = new RuntimeDependencies
        {
            ModuleName = moduleName,
            Files = [.. deps.Select(d => new RuntimeDependency
            {
                Value = pluginFolder.GetRelativePathTo(d.To).ToUnixRelativePath(),
                Origin = pluginFolder.GetRelativePathTo(d.From).ToUnixRelativePath(),
                Config = determineConfig(d.From),
                Platform = determinePlatform(d.From)
            })],

            Dlls = [.. dllDeps.Select(d => new RuntimeDependency
            {
                Value = d.To.Name,
                Config = determineConfig(d.From),
                Platform = determinePlatform(d.From)
            })],

            RuntimeLibraryPath = [.. runtimeLibraryPaths.Select(p => new RuntimeDependency
            {
                Value = $"Binaries/{binariesSubfolder}/{p.Path.ToUnixRelativePath()}",
                Config = p.Config,
                Platform = p.Platform
            })]
        };

        if (!pretend)
            new AutoRuntimeDependencyGenerator().Generate(self.TemplatesPath, moduleRuleOutput, model);
        
        return deps;
    }
}