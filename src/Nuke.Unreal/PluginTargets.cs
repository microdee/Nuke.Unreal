
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
        [Parameter("Make marketplace compliant archives")]
        public bool ForMarketplace = false;

        public abstract string PluginVersion { get; }
        public abstract AbsolutePath ToPlugin { get; }

        public string PluginName => Path.GetFileNameWithoutExtension(ToPlugin);

        private JObject _pluginObject;
        protected JObject PluginObject =>
            _pluginObject ?? (_pluginObject = JObject.Parse(File.ReadAllText(ToPlugin)));

        public Target Checkout => _ => _
            .Description("Switch to the specified Unreal Engine version and platform for plugin development or packaging")
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

                ProjectObject["EngineAssociation"] = TargetEngineVersion.FullVersionName;
                result = ProjectObject.ToString(Formatting.Indented);
                File.WriteAllText(ToProject, result);
            });

        public Target MakeRelease => _ => _
            .Description("Make a proper release of the target plugin for current version. This yields zip archives in the deployment path specified in OutPath (.deploy by default)")
            .Triggers(MakeMarketplaceRelease)
            .Triggers(PackPlugin);

        public Target PackPlugin => _ => _
            .Description("Make a prebuilt release of the target plugin for current version. This yields zip archives in the deployment path specified in OutPath (.deploy by default)")
            .DependsOn(Checkout)
            .Executes(() =>
            {
                var packageName = $"{PluginName}-{TargetPlatform}-{PluginVersion}.{GetEngineVersionFromProject().FullVersionName}-PreBuilt";
                var targetDir = RootDirectory / OutPath / packageName;
                var archiveFileName = $"{packageName}.zip";

                Info($"Packaging plugin: {packageName}");

                if(Directory.Exists(targetDir))
                    DeleteDirectory(targetDir);
                Directory.CreateDirectory(targetDir);

                if(File.Exists(targetDir.Parent / archiveFileName))
                    DeleteFile(targetDir.Parent / archiveFileName);

                Unreal.AutomationTool(
                    GetEngineVersionFromProject(),
                    "BuildPlugin"
                    + $" -Plugin=\"{ToPlugin}\""
                    + $" -Package=\"{targetDir}\""
                    + " -CreateSubFolder"
                )
                    .WithOnlyResults()
                    .Run();

                Info($"Archiving release: {packageName}");
                ZipFile.CreateFromDirectory(targetDir, targetDir.Parent / archiveFileName);
            });

        public Target MakeMarketplaceRelease => _ => _
            .Description("Prepare a Marketplace complaint archive from the plugin. This target only executes when --for-marketplace is also present. This yields zip archives in the deployment path specified in OutPath (.deploy by default)")
            .DependsOn(Checkout)
            .OnlyWhenStatic(() => ForMarketplace)
            .Executes(() =>
            {
                var packageName = $"{PluginName}-{TargetPlatform}-{PluginVersion}.{GetEngineVersionFromProject().FullVersionName}-Source";
                var targetDir = RootDirectory / OutPath / packageName;
                var archiveFileName = $"{packageName}.zip";

                Info($"Gathering Marketplace release: {packageName}");

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

                Info($"Archiving release: {packageName}");
                ZipFile.CreateFromDirectory(targetDir, targetDir.Parent / archiveFileName);
            });
    }
}