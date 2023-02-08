
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
        public static readonly IPackageTargets Default = new PackageTargets();
    }

    public interface IPackageTargets : INukeBuild
    {
        T Self<T>() where T : INukeBuild => (T)(object)this;
        T SelfAs<T>() where T : class, INukeBuild => (object)this as T;

        bool PackagePak => false;
        
        IEnumerable<string> PackageArguments
        {
            get
            {
                var result = new List<string> {
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
            .DependsOn<UnrealBuild>(u => u.BuildEditor)
            .After<UnrealBuild>(u => u.CleanDeployment)
            .After<UnrealBuild>(u => u.Cook)
            .Executes(() =>
            {
                var self = Self<UnrealBuild>();
                var androidTextureMode = SelfAs<IAndroidTargets>()?.TextureMode
                    ?? new [] { AndroidCookFlavor.Multi };

                var isAndroidPlatform = self.Platform == UnrealPlatform.Android;
                var appLocalDir = self.UnrealEnginePath / "Engine" / "Binaries" / "ThirdParty" / "AppLocalDependencies";
                var configCombination = isAndroidPlatform
                    ? (from config in self.Config from textureMode in androidTextureMode select (config, textureMode))
                    : self.Config.Select(c => (c, AndroidCookFlavor.Multi));
                configCombination.ForEach(combination =>
                {
                    var (config, textureMode) = combination;
                    Unreal.AutomationTool(self.GetEngineVersionFromProject())(
                        arguments:
                            "BuildCookRun"
                            + $" -ScriptsForProject=\"{self.ProjectPath}\""
                            + $" -project=\"{self.ProjectPath}\""
                            + $" -target={self.ProjectName}"
                            + $" -targetplatform={self.Platform}"
                            + $" -platform={self.Platform}"
                            + $" -clientconfig={config}"
                            + $" -archivedirectory=\"{self.OutPath}\""
                            + $" -applocaldirectory={appLocalDir}"
                            + (InvokedTargets.Contains(self.Cook) ? " -skipcook" : " -cook")
                            + " -build"
                            + " -stage"
                            + " -package"
                            + " -archive"
                            + (InvokedTargets.Contains(self.BuildEditor) ? " -nocompileeditor" : "")
                            + (!InvokedTargets.Contains(self.Cook) && self.CookAll ? " -CookAll" : "")
                            + PackageArguments.AppendAsArguments()
                            + self.UatArgs.AppendAsArguments(),
                        workingDirectory: self.UnrealEnginePath
                    );
                });
            });
    }
}