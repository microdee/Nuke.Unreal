using System;
using System.Linq;
using Nuke.Common;
using Nuke.Common.CI;
using Nuke.Common.CI.GitHubActions;
using Nuke.Common.Execution;
using Nuke.Common.IO;
using Nuke.Common.ProjectModel;
using Nuke.Common.Tools.DotNet;
using Nuke.Common.Tools.MSBuild;
using Nuke.Common.Tools.NuGet;
using Nuke.Common.Tooling;
using Nuke.Common.Utilities.Collections;
using Serilog;

using static Nuke.Common.EnvironmentInfo;
using static Nuke.Common.IO.FileSystemTasks;
using static Nuke.Common.IO.PathConstruction;
using static Nuke.Common.Tools.DotNet.DotNetTasks;
using static Nuke.Common.Tools.NuGet.NuGetTasks;
using System.Xml.Linq;
using build.Generators;
using build.Generators.UAT;
using build.Generators.UBT;
using Nuke.Common.Tools.GitVersion;

namespace build;

[GitHubActions(
    "Release",
    GitHubActionsImage.WindowsLatest,
    AutoGenerate = false,
    OnPushBranches = new[] { MasterBranch },
    OnPullRequestBranches = new[] { MasterBranch }
)]
class Build : NukeBuild
{
    /// Support plugins are available for:
    ///   - JetBrains ReSharper        https://nuke.build/resharper
    ///   - JetBrains Rider            https://nuke.build/rider
    ///   - Microsoft VisualStudio     https://nuke.build/visualstudio
    ///   - Microsoft VSCode           https://nuke.build/vscode

    private readonly string _msbuildXmlns = "http://schemas.microsoft.com/developer/msbuild/2003";

    public static int Main () => Execute<Build>(x => x.Info);
    protected override void OnBuildCreated() => NoLogo = true;

    [Parameter("Configuration to build - Default is 'Debug' (local) or 'Release' (server)")]
    readonly Configuration Configuration = IsLocalBuild ? Configuration.Debug : Configuration.Release;

    const string MasterBranch = "master";

    record ProjectRecord(Project Project, bool PublishToNuget);

    ProjectRecord MainProject => new (Solution.GetProject("Nuke.Unreal") , true);
    ProjectRecord IniProject => new (Solution.GetProject("Nuke.Unreal.Ini") , true);
    ProjectRecord[] NukeUnreal => new [] { MainProject, IniProject };

    [Solution] readonly Solution Solution;
    
    [GitVersion]
    readonly GitVersion GitVersion;

    [Parameter]
    string[] NugetApiKeys;

    [Parameter]
    NuGetPublishTarget[] PublishTo = new [] { IsLocalBuild ? NuGetPublishTarget.Github : NuGetPublishTarget.NugetOrg };

    Target Info => _ => _
        .Description("Print information about the current state of the environment")
        .Executes(() =>
        {
            Log.Information("GitVersion: {0}", GitVersion.FullSemVer);
            Log.Information("NugetVersion: {0}", GitVersion.NuGetVersion);
            Log.Information("NugetVersionV2: {0}", GitVersion.NuGetVersionV2);
        });

    Target GenerateTools => _ => _
        .Executes(() =>
        {
            var engines = new ToolGeneratorUnrealArg[]
            {
                new("4.27", UnrealCompatibility.UE4),
                new("5.1", UnrealCompatibility.UE5)
            };
            new UbtGeneratorFromSource().Generate(this, engines);
            new UatGenerator().Generate(this, engines);
        });

    Target Restore => _ => _
        .Executes(() =>
        {
            foreach(var project in NukeUnreal)
            {
                DotNetRestore(s => s
                    .SetProjectFile(project.Project)
                );
            }
        });

    Target Compile => _ => _
        .DependsOn(Restore)
        .Executes(() =>
        {
            foreach(var (project, publishToNuget) in NukeUnreal)
            {
                var nukeUnrealMsBuild = project.GetMSBuildProject();
                nukeUnrealMsBuild.SetProperty("Version", GitVersion.NuGetVersion);
                nukeUnrealMsBuild.Save();

                DotNetBuild(s => s
                    .SetNoRestore(true)
                    .SetProjectFile(project)
                    .SetVersion(GitVersion.NuGetVersion)
                    .SetAssemblyVersion(GitVersion.MajorMinorPatch)
                );
            }
        });

    Target Test => _ => _
        .Executes(() =>
        {
            DotNetTest(s => s
                .SetProjectFile(Solution.GetProject("Nuke.Unreal.Tests"))
            );
        });

    Target PublishNuget => _ => _
        .DependsOn(Compile, Test)
        .Requires(() => NugetApiKeys)
        .Requires(() => PublishTo)
        .Executes(() =>
        {
            for (int i=0; i<PublishTo.Length; i++)
            {
                foreach(var project in NukeUnreal)
                {
                    if (!project.PublishToNuget) continue;

                    var source = PublishTo[i].Source;
                    var apiKey = NugetApiKeys[i % NugetApiKeys.Length];

                    Log.Information("Publishing nuget package to {0}", source);

                    var packageId = project.Project.GetProperty("PackageId");
                    DotNetNuGetPush(s => s
                        .SetTargetPath(project.Project.Directory / "bin" / Configuration / $"{packageId}.{GitVersion.NuGetVersion}.symbols.nupkg")
                        .SetApiKey(apiKey)
                        .SetSource(source)
                    );
                }
            }
        });

}
