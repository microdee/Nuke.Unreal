
using System;
using System.IO;
using Nuke.Common.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Nuke.Common;
using static Nuke.Common.IO.FileSystemTasks;
using static Nuke.Common.IO.PathConstruction;
using static Nuke.Common.Logger;
using static Nuke.Common.ControlFlow;

namespace Nuke.Unreal
{
    public abstract class PluginTargets : CommonTargets
    {
        public abstract string PluginVersion { get; }
        public abstract AbsolutePath ToPlugin { get; }

        [Parameter("Which platform should the Checkout target")]
        public string TargetPlatform { get; set; } = "Win64";

        private JObject _pluginObject;
        protected JObject PluginObject =>
            _pluginObject ?? (_pluginObject = JObject.Parse(File.ReadAllText(ToPlugin)));

        public virtual Target Checkout => _ => _
            .DependsOn(CleanUnreal)
            .Executes(() =>
            {
                Info($"Checking out targeting UE {UnrealVersion} on platform {TargetPlatform}");

                PluginObject["EngineVersion"] = TargetEngineVersion.FullVersionName;
                foreach (var module in PluginObject["Modules"])
                {
                    module["WhitelistPlatforms"] = new JArray(TargetPlatform);
                }
                var result = PluginObject.ToString(Formatting.Indented);
                File.WriteAllText(ToPlugin, result);

                ProjectObject["EngineAssociation"] = TargetEngineVersion.VersionName;
                result = ProjectObject.ToString(Formatting.Indented);
                File.WriteAllText(ToProject, result);
            });

        public virtual Target GatherMarketplace => _ => _
            .DependsOn(Checkout)
            .Executes(() =>
            {
                var pluginName = Path.GetFileNameWithoutExtension(ToPlugin);
                var packageName = $"{pluginName}_{TargetPlatform}_{PluginVersion}.{TargetEngineVersion.FullVersionName}";
                var targetDir = RootDirectory / OutPath / packageName;

                Info($"Gathering Marketplace release: {packageName}");

                if(Directory.Exists(targetDir))
                {
                    Directory.Delete(targetDir, true);
                }
                Directory.CreateDirectory(targetDir);

                File.Copy(ToPlugin, targetDir / Path.GetFileName(ToPlugin), true);
                CopyDirectoryRecursively(
                    ToPlugin.Parent / "Source",
                    targetDir / "Source",
                    DirectoryExistsPolicy.Merge,
                    excludeDirectory: d => d.Name.StartsWith(".git", StringComparison.InvariantCultureIgnoreCase),
                    excludeFile: f =>
                        f.Name.StartsWith(".git", StringComparison.InvariantCultureIgnoreCase)
                        || f.Name.EndsWith(".md", StringComparison.InvariantCultureIgnoreCase)
                );
                CopyDirectoryRecursively(
                    ToPlugin.Parent / "Resources",
                    targetDir / "Resources",
                    DirectoryExistsPolicy.Merge
                );
                CopyDirectoryRecursively(
                    ToPlugin.Parent / "Config",
                    targetDir / "Config",
                    DirectoryExistsPolicy.Merge
                );
            });
    }
}