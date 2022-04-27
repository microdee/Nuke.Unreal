
using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.IO.Compression;
using Nuke.Common.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Nuke.Common;
using Nuke.Common.Utilities.Collections;
using static Nuke.Common.IO.FileSystemTasks;
using static Nuke.Common.IO.PathConstruction;
using static Nuke.Common.Logger;
using static Nuke.Common.ControlFlow;

namespace Nuke.Unreal
{
    public class PackageTargets : NukeBuild, IPackageTargets
    {
        public static IPackageTargets Default => new PackageTargets();
    }

    public interface IPackageTargets : INukeBuild
    {
        T Self<T>() where T : INukeBuild => (T)(object)this;

        bool PackagePak => false;
        
        IEnumerable<string> PackageArguments
        {
            get
            {
                var result = new List<string> {
                    "-skipcook",
                    "-nocompileeditor",
                    "-installed",
                    "-prereqs",
                    "-nop4",
                    "-utf8output",
                    "-manifests",
                };
                if(PackagePak)
                {
                    result.Add("-pak");
                }
                return result;
            }
        }

        Target Package => _ => _
            .Description("Same as running Package Project from Editor")
            .DependsOn<UnrealBuild>(u => u.Cook)
            .After<UnrealBuild>(u => u.CleanDeployment)
            .Executes(() =>
            {
                var self = Self<UnrealBuild>();

                var isAndroidPlatform = self.TargetPlatform == UnrealPlatform.Android;
                var appLocalDir = self.UnrealEnginePath / "Engine" / "Binaries" / "ThirdParty" / "AppLocalDependencies";
                var configCombination = isAndroidPlatform
                    ? (from config in self.Config from textureMode in self.AndroidTextureMode select (config, textureMode))
                    : self.Config.Select(c => (c, AndroidCookFlavor.Multi));
                configCombination.ForEach(combination =>
                {
                    var (config, textureMode) = combination;
                    Unreal.AutomationToolBatch(
                        self.GetEngineVersionFromProject(),
                        "BuildCookRun"
                        + $" -ScriptsForProject=\"{self.ToProject}\""
                        + $" -project=\"{self.ToProject}\""
                        + $" -target={self.UnrealProjectName}"
                        + $" -targetplatform={self.TargetPlatform}"
                        + $" -platform={self.TargetPlatform}"
                        + $" -clientconfig={config}"
                        + $" -archivedirectory=\"{self.OutPath}\""
                        + $" -applocaldirectory={appLocalDir}"
                        + " -build"
                        + " -package"
                        + " -stage"
                        + " -archive"
                        + (isAndroidPlatform ? $" -cookflavor={textureMode}" : "")
                        + PackageArguments.AppendAsArguments()
                        + self.UatArgs.AppendAsArguments()
                    )
                    .WithWorkingDir(self.UnrealEnginePath)
                    .Run();
                });
            });
    }
}