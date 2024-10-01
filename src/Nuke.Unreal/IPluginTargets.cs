
using System;
using System.IO;
using System.IO.Compression;
using Nuke.Common.IO;
using Serilog;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Nuke.Common;
using System.Collections.Generic;
using Nuke.Unreal.Tools;
using Nuke.Common.Tooling;

using static Nuke.Common.IO.FileSystemTasks;
using Nuke.Cola;
using System.Linq;

namespace Nuke.Unreal
{
    public class PluginCache
    {
        public static readonly Dictionary<IPluginTargets, PluginCache> Instances = new();
        
        public AbsolutePath? PluginPath;
        public JObject? PluginObject;
    }

    public static class PluginTargetsExtensions
    {
        public static PluginCache Cache(this IPluginTargets self)
        {
            if (PluginCache.Instances.TryGetValue(self, out var value))
            {
                return value;
            }
            var cache = new PluginCache();
            PluginCache.Instances.Add(self, cache);
            return cache;
        }
    }

    public class PluginTargets : NukeBuild, IPluginTargets
    {
        public static readonly IPluginTargets Default = new PluginTargets();
    }

    public interface IPluginTargets : INukeBuild
    {
        T Self<T>() where T : INukeBuild => (T)(object)this;

        [Parameter("Make marketplace compliant archives")]
        bool ForMarketplace => TryGetValue<bool?>(() => ForMarketplace) ?? false;

        string PluginVersion => "1.0.0";
        
        /// <summary>
        /// Optionally specify a .uplugin path.
        /// If not overridden Nuke.Unreal will traverse upwards on the directory tree,
        /// then sift through all subdirectories recursively (ignoring some known folders)
        /// </summary>
        AbsolutePath PluginPath
        {
            get
            {
                if(this.Cache().PluginPath != null) return this.Cache().PluginPath!;

                if (this is not UnrealBuild self)
                {
                    throw new Exception("An UnrealBuild class needs to inherit IPluginTargets");
                }

                Log.Information(".uplugin path was unspecified, looking for one...");
                if(BuildCommon.LookAroundFor(f => f.EndsWith(".uplugin"), out var candidate))
                {
                    Log.Information($"Found plugin at {candidate}");
                    this.Cache().PluginPath = candidate;
                    return candidate!;
                }
                throw new FileNotFoundException("No .uplugin was found");
            }
        }

        string PluginName => Path.GetFileNameWithoutExtension(PluginPath);

        JObject PluginObject =>
            this.Cache().PluginObject ?? (this.Cache().PluginObject = JObject.Parse(File.ReadAllText(PluginPath)));

        Target Checkout => _ => _
            .Description("Switch to the specified Unreal Engine version and platform for plugin development or packaging")
            .DependsOn<UnrealBuild>(u => u.Clean)
            .Requires(() => Self<UnrealBuild>().UnrealVersion)
            .Executes(() =>
            {
                var self = Self<UnrealBuild>();

                Log.Information($"Checking out targeting UE {self.UnrealVersion} on platform {self.Platform}");

                PluginObject["EngineVersion"] = self.ManualEngineVersion.VersionName;
                PluginObject["VersionName"] = PluginVersion;

                foreach (var module in PluginObject["Modules"] ?? Enumerable.Empty<JToken>())
                {
                    module["WhitelistPlatforms"] = new JArray(self.Platform.ToString());
                }

                Unreal.WriteJson(PluginObject, PluginPath);

                self.ProjectObject["EngineAssociation"] = self.ManualEngineVersion.EngineAssociation;
                self.ProjectObject["EngineVersionPatch"] = self.ManualEngineVersion.FullVersionName;
                Unreal.WriteJson(self.ProjectObject, self.ProjectPath);
            });

        Target MakeRelease => _ => _
            .Description("Make a proper release of the target plugin for current version. This yields zip archives in the deployment path specified in OutPath (.deploy by default)")
            .Triggers(MakeMarketplaceRelease)
            .Triggers(PackPlugin);

        UatConfig UatPackPlugin(UatConfig _) => _;
        UatConfig UatBuildEditorPlugin(UatConfig _) => _;

        Target PackPlugin => _ => _
            .Description("Make a prebuilt release of the target plugin for current version. This yields zip archives in the deployment path specified in OutPath (.deploy by default)")
            .DependsOn(Checkout)
            .After<UnrealBuild>(u => u.CleanDeployment)
            .Executes(() =>
            {
                var self = Self<UnrealBuild>();

                var packageName = $"{PluginName}-{self.Platform}-{PluginVersion}.{Unreal.Version(self).VersionName}-PreBuilt";
                var targetDir = self.GetOutput() / packageName;
                var hostProjectDir = targetDir / "HostProject";
                var archiveFileName = $"{packageName}.zip";

                Log.Information($"Packaging plugin: {packageName}");

                targetDir.DeleteDirectory();
                Directory.CreateDirectory(targetDir);
                (targetDir.Parent / archiveFileName).DeleteFile();

                Unreal.AutomationTool(self, _ => _
                    .BuildPlugin(_ => _
                        .Plugin(PluginPath)
                        .Package(targetDir)
                        .TargetPlatforms(self.Platform)
                        .If(Unreal.Is4(self), _ => _
                            .VS2019()
                        )
                        .NoDeleteHostProject()
                        .Unversioned()
                    )
                    .Apply(UatPackPlugin)
                    .Apply(self.UatGlobal)
                    .Append(self.UatArgs.AsArguments())
                )("");
                hostProjectDir.DeleteDirectory();

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

                var packageName = $"{PluginName}-{self.Platform}-{PluginVersion}.{Unreal.Version(self).VersionName}-Source";
                var targetDir = self.GetOutput() / packageName;
                var archiveFileName = $"{packageName}.zip";

                Log.Information($"Gathering Marketplace release: {packageName}");

                targetDir.DeleteDirectory();
                Directory.CreateDirectory(targetDir);
                (targetDir.Parent / archiveFileName).DeleteFile();

                CopyFileToDirectory(
                    PluginPath, targetDir,
                    FileExistsPolicy.Overwrite
                );
                CopyDirectoryRecursively(
                    PluginPath.Parent / "Source",
                    targetDir / "Source",
                    DirectoryExistsPolicy.Merge,
                    excludeDirectory: d => d.Name.StartsWith(".git", StringComparison.InvariantCultureIgnoreCase),
                    excludeFile: f =>
                        f.Name.StartsWith(".git", StringComparison.InvariantCultureIgnoreCase)
                        || f.Name.EndsWith(".md", StringComparison.InvariantCultureIgnoreCase)
                );

                if(Directory.Exists(PluginPath.Parent / "Resources"))
                    CopyDirectoryRecursively(
                        PluginPath.Parent / "Resources",
                        targetDir / "Resources",
                        DirectoryExistsPolicy.Merge
                    );
                
                if(Directory.Exists(PluginPath.Parent / "Config"))
                    CopyDirectoryRecursively(
                        PluginPath.Parent / "Config",
                        targetDir / "Config",
                        DirectoryExistsPolicy.Merge
                    );

                Log.Information($"Archiving release: {packageName}");
                ZipFile.CreateFromDirectory(targetDir, targetDir.Parent / archiveFileName);
            });
    }
}