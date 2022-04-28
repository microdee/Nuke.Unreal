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

[GitHubActions(
    "Release",
    GitHubActionsImage.WindowsLatest,
    OnPushBranches = new[] { MasterBranch },
    OnPullRequestBranches = new[] { MasterBranch }
)]
[CheckBuildProjectConfigurations]
class Build : NukeBuild
{
    /// Support plugins are available for:
    ///   - JetBrains ReSharper        https://nuke.build/resharper
    ///   - JetBrains Rider            https://nuke.build/rider
    ///   - Microsoft VisualStudio     https://nuke.build/visualstudio
    ///   - Microsoft VSCode           https://nuke.build/vscode

    public static int Main () => Execute<Build>(x => x.Compile);
    protected override void OnBuildCreated() => NoLogo = true;

    [Parameter("Configuration to build - Default is 'Debug' (local) or 'Release' (server)")]
    readonly Configuration Configuration = IsLocalBuild ? Configuration.Debug : Configuration.Release;

    const string MasterBranch = "master";

    [Solution] readonly Solution Solution;
    Project NukeUnreal => Solution.GetProject("Nuke.Unreal");

    [Parameter]
    string[] NugetApiKeys;

    [Parameter]
    NuGetPublishTarget[] PublishTo = new [] { IsLocalBuild ? NuGetPublishTarget.Github : NuGetPublishTarget.NugetOrg };

    Version CurrentVersion => Version.Parse(NukeUnreal.GetProperty("Version"));

    Target Restore => _ => _
        .Executes(() =>
        {
            DotNetRestore(s => s
                .SetProjectFile(NukeUnreal)
            );
        });

    Target Compile => _ => _
        .DependsOn(Restore)
        .Executes(() =>
        {
            var currentVersion = CurrentVersion;
            var newVersion = new Version(currentVersion.Major, currentVersion.Minor, currentVersion.Build + 1);
            var nukeUnrealMsBuild = NukeUnreal.GetMSBuildProject();
            nukeUnrealMsBuild.SetProperty("Version", newVersion.ToString(3));
            nukeUnrealMsBuild.Save();
            
            DotNetBuild(s => s
                .SetNoRestore(true)
                .SetProjectFile(NukeUnreal)
                .SetVersion(newVersion.ToString())
                .SetAssemblyVersion(newVersion.ToString())
            );
        });

    Target PublishNuget => _ => _
        .DependsOn(Compile)
        .Requires(() => NugetApiKeys)
        .Requires(() => PublishTo)
        .Executes(() =>
        {
            for (int i=0; i<PublishTo.Length; i++)
            {
                var source = PublishTo[i].Source;
                var apiKey = NugetApiKeys[i % NugetApiKeys.Length];

                Log.Information("Publishing nuget package to {0}", source);

                var packageId = NukeUnreal.GetProperty("PackageId");
                DotNetNuGetPush(s => s
                    .SetTargetPath(NukeUnreal.Directory / "bin" / Configuration / $"{packageId}.{CurrentVersion.ToString(3)}.symbols.nupkg")
                    .SetApiKey(apiKey)
                    .SetSource(source)
                );
            }
        });

}
