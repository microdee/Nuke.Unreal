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

    public static int Main () => Execute<Build>(x => x.Compile);
    protected override void OnBuildCreated() => NoLogo = true;

    [Parameter("Configuration to build - Default is 'Debug' (local) or 'Release' (server)")]
    readonly Configuration Configuration = IsLocalBuild ? Configuration.Debug : Configuration.Release;

    [Parameter("Reference Unreal version")]
    readonly string UnrealVersion = "4.27";

    const string MasterBranch = "master";

    record ProjectRecord(Project Project, bool PublishToNuget);

    ProjectRecord MainProject => new (Solution.GetProject("Nuke.Unreal") , true);
    ProjectRecord IniProject => new (Solution.GetProject("Nuke.Unreal.Ini") , true);
    ProjectRecord[] NukeUnreal => new [] { MainProject, IniProject };

    [Solution] readonly Solution Solution;

    [Parameter]
    string[] NugetApiKeys;

    [Parameter]
    NuGetPublishTarget[] PublishTo = new [] { IsLocalBuild ? NuGetPublishTarget.Github : NuGetPublishTarget.NugetOrg };

    Version CurrentVersion => Version.Parse(NukeUnreal.First().Project.GetProperty("Version"));

    Target GenerateTools => _ => _
        .Executes(() =>
        {
            // var generator = new UnrealBuildToolGenerator
            // {
            //     UnrealVersion = UnrealVersion
            // };
            // generator.Generate(this);

            new UnrealAutomationToolGenerator().Test();
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
            var currentVersion = CurrentVersion;
            foreach(var project in NukeUnreal)
            {
                var newVersion = new Version(currentVersion.Major, currentVersion.Minor, currentVersion.Build + 1);
                var nukeUnrealMsBuild = project.Project.GetMSBuildProject();
                nukeUnrealMsBuild.SetProperty("Version", newVersion.ToString(3));
                nukeUnrealMsBuild.Save();

                DotNetBuild(s => s
                    .SetNoRestore(true)
                    .SetProjectFile(project.Project)
                    .SetVersion(newVersion.ToString())
                    .SetAssemblyVersion(newVersion.ToString())
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
            var currentVersion = CurrentVersion;
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
                        .SetTargetPath(project.Project.Directory / "bin" / Configuration / $"{packageId}.{currentVersion.ToString(3)}.symbols.nupkg")
                        .SetApiKey(apiKey)
                        .SetSource(source)
                    );
                }
            }
        });

}
