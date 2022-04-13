
using System;
using System.IO;
using System.IO.Compression;
using Nuke.Common.IO;
using Serilog;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Nuke.Common;
using static Nuke.Common.IO.FileSystemTasks;
using System.Collections.Generic;

namespace Nuke.Unreal
{
    public class PluginCache
    {
        public static readonly Dictionary<IPluginTargets, PluginCache> Instances = new();
        
        public AbsolutePath ToPlugin;
        public JObject PluginObject;
    }

    public static class PluginTargets
    {
        public static PluginCache Cache(this IPluginTargets self)
        {
            if (PluginCache.Instances.ContainsKey(self))
            {
                return PluginCache.Instances[self];
            }
            var cache = new PluginCache();
            PluginCache.Instances.Add(self, cache);
            return cache;
        }
    }

    public interface IPluginTargets : INukeBuild, ISelf
    {

        [Parameter("Make marketplace compliant archives")]
        bool ForMarketplace {get; set;}

        string PluginVersion { get; }
        
        /// <summary>
        /// Optionally specify a .uplugin path.
        /// If not overridden Nuke.Unreal will traverse upwards on the directory tree,
        /// then sift through all subdirectories recursively (ignoring some known folders)
        /// </summary>
        AbsolutePath ToPlugin
        {
            get
            {
                if(this.Cache().ToPlugin != null) return this.Cache().ToPlugin;

                if (this is not UnrealBuild self)
                {
                    throw new Exception("An UnrealBuild class needs to inherit IPluginTargets");
                }

                Log.Information(".uplugin path was unspecified, looking for one...");
                if(BuildCommon.LookAroundFor(f => f.EndsWith(".uplugin"), out var candidate))
                {
                    Log.Information($"Found project at {candidate}");
                    this.Cache().ToPlugin = candidate;
                    return candidate;
                }
                throw new FileNotFoundException("No .uplugin was found");
            }
        }

        string PluginName => Path.GetFileNameWithoutExtension(ToPlugin);

        JObject PluginObject =>
            this.Cache().PluginObject ?? (this.Cache().PluginObject = JObject.Parse(File.ReadAllText(ToPlugin)));

        Target Checkout => _ => _
            .Description("Switch to the specified Unreal Engine version and platform for plugin development or packaging")
            .DependsOn<UnrealBuild>(u => u.Clean)
            .Requires(() => Self<UnrealBuild>().UnrealVersion)
            .Executes(() =>
            {
                var self = Self<UnrealBuild>();

                Log.Information($"Checking out targeting UE {self.UnrealVersion} on platform {self.TargetPlatform}");

                PluginObject["EngineVersion"] = self.TargetEngineVersion.FullVersionName;
                PluginObject["VersionName"] = PluginVersion;

                foreach (var module in PluginObject["Modules"])
                {
                    module["WhitelistPlatforms"] = new JArray(self.TargetPlatform);
                }

                Unreal.WriteJson(PluginObject, ToPlugin);

                self.ProjectObject["EngineAssociation"] = self.TargetEngineVersion.EngineAssociation;
                self.ProjectObject["EngineVersionPatch"] = self.TargetEngineVersion.FullVersionName;
                Unreal.WriteJson(self.ProjectObject, self.ToProject);
            });

        Target MakeRelease => _ => _
            .Description("Make a proper release of the target plugin for current version. This yields zip archives in the deployment path specified in OutPath (.deploy by default)")
            .Triggers(MakeMarketplaceRelease)
            .Triggers(PackPlugin);

        Target PackPlugin => _ => _
            .Description("Make a prebuilt release of the target plugin for current version. This yields zip archives in the deployment path specified in OutPath (.deploy by default)")
            .DependsOn(Checkout)
            .After<UnrealBuild>(u => u.CleanDeployment)
            .Executes(() =>
            {
                var self = Self<UnrealBuild>();

                var packageName = $"{PluginName}-{self.TargetPlatform}-{PluginVersion}.{self.GetEngineVersionFromProject().FullVersionName}-PreBuilt";
                var targetDir = self.OutPath / packageName;
                var archiveFileName = $"{packageName}.zip";

                Log.Information($"Packaging plugin: {packageName}");

                if(Directory.Exists(targetDir))
                    DeleteDirectory(targetDir);
                Directory.CreateDirectory(targetDir);

                if(File.Exists(targetDir.Parent / archiveFileName))
                    DeleteFile(targetDir.Parent / archiveFileName);

                Unreal.AutomationTool(
                    self.GetEngineVersionFromProject(),
                    "BuildPlugin"
                    + $" -Plugin=\"{ToPlugin}\""
                    + $" -Package=\"{targetDir}\""
                    + " -CreateSubFolder"
                    + self.UatArgs.AppendAsArguments()
                )
                    .WithOnlyResults()
                    .Run();

                Log.Information($"Archiving release: {packageName}");
                ZipFile.CreateFromDirectory(targetDir, targetDir.Parent / archiveFileName);
            });

        public virtual Target MakeMarketplaceRelease => _ => _
            .Description("Prepare a Marketplace complaint archive from the plugin. This target only executes when --for-marketplace is also present. This yields zip archives in the deployment path specified in OutPath (.deploy by default)")
            .DependsOn(Checkout)
            .OnlyWhenStatic(() => ForMarketplace)
            .Executes(() =>
            {
                var self = Self<UnrealBuild>();

                var packageName = $"{PluginName}-{self.TargetPlatform}-{PluginVersion}.{self.GetEngineVersionFromProject().FullVersionName}-Source";
                var targetDir = self.OutPath / packageName;
                var archiveFileName = $"{packageName}.zip";

                Log.Information($"Gathering Marketplace release: {packageName}");

                if(Directory.Exists(targetDir))
                    DeleteDirectory(targetDir);
                Directory.CreateDirectory(targetDir);

                if(File.Exists(targetDir.Parent / archiveFileName))
                    DeleteFile(targetDir.Parent / archiveFileName);

                CopyFileToDirectory(
                    ToPlugin, targetDir,
                    FileExistsPolicy.Overwrite
                );
                CopyDirectoryRecursively(
                    ToPlugin.Parent / "Source",
                    targetDir / "Source",
                    DirectoryExistsPolicy.Merge,
                    excludeDirectory: d => d.Name.StartsWith(".git", StringComparison.InvariantCultureIgnoreCase),
                    excludeFile: f =>
                        f.Name.StartsWith(".git", StringComparison.InvariantCultureIgnoreCase)
                        || f.Name.EndsWith(".md", StringComparison.InvariantCultureIgnoreCase)
                );

                if(Directory.Exists(ToPlugin.Parent / "Resources"))
                    CopyDirectoryRecursively(
                        ToPlugin.Parent / "Resources",
                        targetDir / "Resources",
                        DirectoryExistsPolicy.Merge
                    );
                
                if(Directory.Exists(ToPlugin.Parent / "Config"))
                    CopyDirectoryRecursively(
                        ToPlugin.Parent / "Config",
                        targetDir / "Config",
                        DirectoryExistsPolicy.Merge
                    );

                Log.Information($"Archiving release: {packageName}");
                ZipFile.CreateFromDirectory(targetDir, targetDir.Parent / archiveFileName);
            });
    }
}