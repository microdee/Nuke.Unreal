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
        AbsolutePath? moduleRuleOutput = null,
        [CallerFilePath] string? scriptFile = null
    )
    {
        var scriptFolder = AbsolutePath.Create(scriptFile!).Parent;
        pluginFolder ??= scriptFolder.GetOwningPlugin()!.Parent;
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