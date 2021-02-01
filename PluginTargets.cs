
using System;
using System.IO;
using System.IO.Compression;
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
                PluginObject["VersionName"] = PluginVersion;
                
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

        public virtual Target MakeMarketplaceRelease => _ => _
            .DependsOn(Checkout)
            .Executes(() =>
            {
                var pluginName = Path.GetFileNameWithoutExtension(ToPlugin);
                var packageName = $"{pluginName}-{TargetPlatform}-{PluginVersion}.{TargetEngineVersion.FullVersionName}-Source";
                var targetDir = RootDirectory / OutPath / packageName;
                var archiveFileName = $"{packageName}.zip";

                Info($"Gathering Marketplace release: {packageName}");

                if(Directory.Exists(targetDir))
                {
                    Directory.Delete(targetDir, true);
                }
                Directory.CreateDirectory(targetDir);

                if(File.Exists(targetDir.Parent / archiveFileName))
                {
                    File.Delete(targetDir.Parent / archiveFileName);
                }

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

                Info($"Archiving release: {packageName}");
                ZipFile.CreateFromDirectory(targetDir, targetDir.Parent / archiveFileName);
            });
    }
}