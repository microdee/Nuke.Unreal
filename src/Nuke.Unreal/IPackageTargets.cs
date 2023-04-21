
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
using Nuke.Unreal.Tools;

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

        UnrealAutomationToolConfig PackageArguments(UnrealAutomationToolConfig _) => _.Prereqs();

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
                self.Config.ForEach(config =>
                {
                    Unreal.AutomationTool(self.GetEngineVersionFromProject(), _ =>
                        PackageArguments(
                        self.CookArguments(
                        self.UatConfig(_
                            .BuildCookRun(_ => _
                                .Project(self.ProjectPath)
                                .Target(self.ProjectName)
                                .Clientconfig(self.Config)
                                .Manifests()
                                .AppLocalDirectory(appLocalDir)
                            )
                            .ScriptsForProject(self.ProjectPath)
                            .Targetplatform(self.Platform)
                            .Build()
                            .Stage()
                            .Package()
                            .Archive()
                            .Archivedirectory(self.OutPath)
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
                        )))
                        .Append(self.UatArgs.AsArguments())
                    )(workingDirectory: self.UnrealEnginePath);
                });
            });
    }
}