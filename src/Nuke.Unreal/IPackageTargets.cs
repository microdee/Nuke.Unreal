
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
using Nuke.Unreal.Platforms.Android;

namespace Nuke.Unreal;

/// <summary>
/// Target for packaging the current project we're working on
/// </summary>
public interface IPackageTargets : IUnrealBuild
{
    /// <summary>
    /// UAT arguments to be applied every time UAT is called for Packaging.
    /// Explicitly implement this function in your main build class if your project needs extra
    /// intricacies for Packaging.
    /// For example specifying maps explicitly.
    /// </summary>
    UatConfig UatPackage(UatConfig _) => _.Prereqs();

    /// <summary>
    /// Same as running Package Project from Editor
    /// <code>
    ///     \--Config
    ///     \--Platform
    ///     \--AndroidTextureMode
    ///     \-->ubt (args.)
    ///     \-->uat (args.)
    /// </code>
    /// </summary>
    Target Package => _ => _
        .Description(
            """
            |
                | Same as running Package Project from Editor
                |
                | --Config
                | --Platform
                | --AndroidTextureMode
                | -->ubt (args.)
                | -->uat (args.)
                
            """
        )
        .DependsOn(BuildEditor, SetupPlatformSdk)
        .After(CleanDeployment, Cook, Prepare, Switch)
        .Executes(() =>
        {
            var appLocalDir = UnrealEnginePath / "Engine" / "Binaries" / "ThirdParty" / "AppLocalDependencies";
            Config.ForEach(config =>
            {
                Unreal.AutomationTool(this, _ => _
                    .BuildCookRun(_ => _
                        .Project(ProjectPath)
                        .Target(ProjectName)
                        .Clientconfig(Config)
                        .Manifests()
                        .AppLocalDirectory(appLocalDir)
                        .If(ForDistribution(), _ => _
                            .Distribution()
                        )
                    )
                    .ScriptsForProject(ProjectPath)
                    .Targetplatform(Platform)
                    .Build()
                    .Stage()
                    .Package()
                    .Archive()
                    .Archivedirectory(GetOutput())
                    .If(InvokedTargets.Contains(Cook),
                        _ => _.Skipcook(),
                        _ => _.Cook()
                    )
                    .If(!InvokedTargets.Contains(BuildEditor), _ => _
                        .NoCompileEditor()
                    )
                    .If(this.IsAndroidPlatform(), _ => _
                        .Cookflavor(AndroidTextureMode)
                    )
                    .Apply(UatGlobal)
                    .Apply(UatCook)
                    .Apply(UatPackage)
                    .AppendRaw(GetArgumentBlock("uat"))
                )(
                    workingDirectory: UnrealEnginePath
                );
            });
        });
}
