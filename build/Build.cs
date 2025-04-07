using System.Linq;
using Nuke.Common;
using Nuke.Common.CI.GitHubActions;
using Nuke.Common.IO;
using Nuke.Common.ProjectModel;
using Nuke.Common.Tools.DotNet;
using Nuke.Common.Tools.MSBuild;
using Nuke.Common.Tools.NuGet;
using Nuke.Common.Tooling;
using Serilog;
using static Nuke.Common.Tools.DotNet.DotNetTasks;
using build.Generators;
using build.Generators.UAT;
using build.Generators.UBT;
using Nuke.Common.Tools.GitVersion;
using Nuke.Cola;

namespace build;

[GitHubActions(
    "Release",
    GitHubActionsImage.WindowsLatest,
    AutoGenerate = false,
    OnPushBranches = new[] { MasterBranch },
    OnPullRequestBranches = new[] { MasterBranch }
)]
class Build : NukeBuild, IPublishNugets
{
    /// Support plugins are available for:
    ///   - JetBrains ReSharper        https://nuke.build/resharper
    ///   - JetBrains Rider            https://nuke.build/rider
    ///   - Microsoft VisualStudio     https://nuke.build/visualstudio
    ///   - Microsoft VSCode           https://nuke.build/vscode

    public static int Main () => Execute<Build>(x => x.Info);
    protected override void OnBuildCreated() => NoLogo = true;

    [Parameter("Configuration to build - Default is 'Debug' (local) or 'Release' (server)")]
    readonly Configuration Configuration = IsLocalBuild ? Configuration.Debug : Configuration.Release;

    const string MasterBranch = "master";

    Project GetSlnProject(string name) => Solution.GetAllProjects(name).SingleOrDefault();

    ProjectRecord MainProject => new (GetSlnProject("Nuke.Unreal") , true);
    ProjectRecord IniProject => new (GetSlnProject("Nuke.Unreal.Ini") , true);

    [Solution] readonly Solution Solution;
    
    [GitVersion]
    readonly GitVersion GitVersion;

    [Parameter]
    string[] NugetApiKeys;

    [Parameter]
    NuGetPublishTarget[] PublishTo = new [] { IsLocalBuild ? NuGetPublishTarget.Github : NuGetPublishTarget.NugetOrg };

    public string VersionForNuget => GitVersion.NuGetVersion;

    public ProjectRecord[] PublishProjects => new [] { MainProject, IniProject };

    public NugetSource[] NugetSources => NugetSource.CombineFrom(
        PublishTo.Select(p => p.Source).ToArray(), NugetApiKeys
    ).ToArray();

    Target Info => _ => _
        .Description("Print information about the current state of the environment")
        .Executes(() =>
        {
            Log.Information("GitVersion: {0}", GitVersion.FullSemVer);
            Log.Information("NugetVersion: {0}", GitVersion.NuGetVersion);
            Log.Information("NugetVersionV2: {0}", GitVersion.NuGetVersionV2);
            foreach(var project in PublishProjects)
            {
                Log.Information(project.Project.Name);
            }
        });

    Target GenerateTools => _ => _
        .Executes(() =>
        {
            var engines = new ToolGeneratorUnrealArg[]
            {
                new("4.27", UnrealCompatibility.UE_4),
                new("5.0", UnrealCompatibility.UE_5_0),
                new("5.1", UnrealCompatibility.UE_5_1),
                new("5.2", UnrealCompatibility.UE_5_2),
                new("5.3", UnrealCompatibility.UE_5_3),
                new("5.4", UnrealCompatibility.UE_5_4),
                new("5.5", UnrealCompatibility.UE_5_Latest),
            };
            new UbtGeneratorFromSource().Generate(this, engines);
            new UatGenerator().Generate(this, engines);
        });

    Target Restore => _ => _
        .Executes(() =>
        {
            foreach(var project in PublishProjects)
            {
                DotNetRestore(s => s
                    .SetProjectFile(project.Project)
                );
            }
        });

    Target Compile => _ => _
        .DependentFor<IPublishNugets>(_ => _.PublishNuget)
        .DependsOn(Restore)
        .Executes(() =>
        {
            foreach(var (project, publishToNuget) in PublishProjects)
            {
                var projectMsBuild = project.GetMSBuildProject();
                projectMsBuild.SetProperty("Version", GitVersion.NuGetVersion);
                projectMsBuild.Save();

                DotNetBuild(s => s
                    .SetNoRestore(true)
                    .SetProjectFile(project)
                    .SetVersion(GitVersion.NuGetVersion)
                    .SetAssemblyVersion(GitVersion.MajorMinorPatch)
                    .SetConfiguration(Configuration)
                );
            }
        });

    private static void RunTest(AbsolutePath root, string args = "")
        => ToolResolver.GetTool(root / "build.cmd")(
            args,
            workingDirectory: root
        );

    Target TestUE_4_27 => _ => _
        .Executes(() =>
        {
            var tests_4_27 = RootDirectory / "tests" / "UE_4.27";
            RunTest(tests_4_27 / "AddCodeToProject");
            RunTest(tests_4_27 / "Packaging");
            // RunTest(tests_4_27 / "Packaging",
            //     "--platform Android --android-texture-mode ASTC --skip sign"
            // );
        });

    Target TestUE_5_1 => _ => _
        .Executes(() =>
        {
            var tests_5_1 = RootDirectory / "tests" / "UE_5.1";
            RunTest(tests_5_1 / "AddCodeToProject");
            RunTest(tests_5_1 / "Packaging");
        });

    Target TestUE_5_2 => _ => _
        .Executes(() =>
        {
            var tests_5_2 = RootDirectory / "tests" / "UE_5.2";
            RunTest(tests_5_2 / "AddCodeToProject");
            RunTest(tests_5_2 / "Packaging");
        });

    Target TestUE_5_3 => _ => _
        .Executes(() =>
        {
            var tests_5_3 = RootDirectory / "tests" / "UE_5.3";
            RunTest(tests_5_3 / "AddCodeToProject");
            RunTest(tests_5_3 / "Packaging");
        });
    Target TestUE_5_4 => _ => _
        .Executes(() =>
        {
            var tests_5_4 = RootDirectory / "tests" / "UE_5.4";
            RunTest(tests_5_4 / "AddCodeToProject");
            RunTest(tests_5_4 / "Packaging");
        });
        
    Target TestUE_5_5 => _ => _
        .Executes(() =>
        {
            var tests_5_5 = RootDirectory / "tests" / "UE_5.5";
            RunTest(tests_5_5 / "AddCodeToProject");
            RunTest(tests_5_5 / "Packaging");
        });

    Target DotnetTest => _ => _
        .Executes(() =>
        {
            DotNetTest(s => s
                .SetProjectFile(GetSlnProject("Nuke.Unreal.Tests"))
            );
        });
        
    Target Test => _ => _
        .Triggers(
            DotnetTest,
            TestUE_4_27,
            TestUE_5_1,
            TestUE_5_2,
            TestUE_5_3,
            TestUE_5_4,
            TestUE_5_5
        );
}
