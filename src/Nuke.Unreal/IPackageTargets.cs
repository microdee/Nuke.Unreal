
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
using Nuke.Unreal.Tools;
using Nuke.Cola;
using Nuke.Common.Utilities;

using static Nuke.Common.IO.PathConstruction;

namespace Nuke.Unreal
{
    public class PackageTargets : NukeBuild, IPackageTargets
    {
        public static readonly IPackageTargets Default = new PackageTargets();
    }

    public interface IPackageTargets : INukeBuild
    {
        T Self<T>() where T : INukeBuild => (T)(object)this;
        T? SelfAs<T>() where T : class, INukeBuild => (object)this as T;

        UatConfig UatPackage(UatConfig _) => _.Prereqs();

        Target Package => _ => _
            .Description("Same as running Package Project from Editor")
            .DependsOn<UnrealBuild>(u => u.BuildEditor)
            .After<UnrealBuild>(
                u => u.CleanDeployment,
                u => u.Cook,
                u => u.Prepare,
                u => u.Switch
            )
            .Executes(() =>
            {
                var self = Self<UnrealBuild>();
                var androidTextureMode = SelfAs<IAndroidTargets>()?.TextureMode
                    ?? [ AndroidCookFlavor.Multi ];

                var isAndroidPlatform = self.Platform == UnrealPlatform.Android;
                var appLocalDir = self.UnrealEnginePath / "Engine" / "Binaries" / "ThirdParty" / "AppLocalDependencies";
                self.Config.ForEach(config =>
                {
                    Unreal.AutomationTool(self, _ => _
                        .BuildCookRun(_ => _
                            .Project(self.ProjectPath)
                            .Target(self.ProjectName)
                            .Clientconfig(self.Config)
                            .Manifests()
                            .AppLocalDirectory(appLocalDir)
                            .If(self.ForDistribution(), _ => _
                                .Distribution()
                            )
                        )
                        .ScriptsForProject(self.ProjectPath)
                        .Targetplatform(self.Platform)
                        .Build()
                        .Stage()
                        .Package()
                        .Archive()
                        .Archivedirectory(self.GetOutput())
                        .If(InvokedTargets.Contains(self.Cook),
                            _ => _.Skipcook(),
                            _ => _.Cook()
                        )
                        .If(!InvokedTargets.Contains(self.BuildEditor), _ => _
                            .NoCompileEditor()
                        )
                        .If(isAndroidPlatform, _ => _
                            .Cookflavor(androidTextureMode)
                        )
                        .UbtArgs(Arguments.GetBlock("ubt").JoinSpace())
                        .Apply(UatPackage)
                        .Apply(self.UatCook)
                        .Apply(self.UatGlobal)
                        .Append(Arguments.GetBlock("uat"))
                    )("", workingDirectory: self.UnrealEnginePath);
                });
            });
    }
}