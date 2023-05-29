using System;
using System.IO;
using System.Linq;
using Nuke.Common;
using Nuke.Common.CI;
using Nuke.Common.Execution;
using Nuke.Common.IO;
using Nuke.Common.ProjectModel;
using Nuke.Common.Tooling;
using Nuke.Common.Tools.Git;
using Nuke.Common.Utilities.Collections;
using Nuke.Unreal;
using static Nuke.Common.EnvironmentInfo;
using static Nuke.Common.IO.FileSystemTasks;
using static Nuke.Common.IO.PathConstruction;

class Build : UnrealBuildTest, IPackageTargets
{
    /// Support plugins are available for:
    ///   - JetBrains ReSharper        https://nuke.build/resharper
    ///   - JetBrains Rider            https://nuke.build/rider
    ///   - Microsoft VisualStudio     https://nuke.build/visualstudio
    ///   - Microsoft VSCode           https://nuke.build/vscode

    public static int Main () => Execute<Build>(x => x.Test);

    Target Test => _ => _
        .Triggers(Generate);

    Target CheckGenerate => _ => _
        .TriggeredBy(Generate)
        .Triggers(Build)
        .Executes(() =>
        {
            Assert.FileExists(ProjectFolder / (ProjectName + ".sln"));
        });

    Target CheckBuild => _ => _
        .TriggeredBy(Build)
        .Triggers(Cook)
        .Executes(() =>
        {
            // TODO: check
        });

    Target CheckCook => _ => _
        .TriggeredBy(Cook)
        .Triggers<IPackageTargets>(p => p.Package)
        .Executes(() =>
        {
            // TODO: check
        });

    Target CheckPackage => _ => _
        .TriggeredBy<IPackageTargets>(p => p.Package)
        .Executes(() =>
        {
            // TODO: check
        });
}
