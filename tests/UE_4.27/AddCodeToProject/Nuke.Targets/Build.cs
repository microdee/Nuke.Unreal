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

class Build : UnrealBuildTest
{
    /// Support plugins are available for:
    ///   - JetBrains ReSharper        https://nuke.build/resharper
    ///   - JetBrains Rider            https://nuke.build/rider
    ///   - Microsoft VisualStudio     https://nuke.build/visualstudio
    ///   - Microsoft VSCode           https://nuke.build/vscode

    public static int Main () => Execute<Build>(x => x.Test);

    Target Test => _ => _
        .Triggers(AddCode, Generate);

    protected override void PostBuildCheck()
    {
        var projectContent = File.ReadAllText(ProjectPath);
        Assert.DirectoryExists(ProjectFolder / "Source" / ProjectName);
        var targetPath = ProjectFolder / "Source" / (ProjectName + ".Target.cs");
        Assert.FileExists(targetPath);
        var targetContent = File.ReadAllText(targetPath);
        Assert.True(targetContent.Contains($"\"{ProjectName}\""));
        Assert.True(projectContent.Contains(ProjectName));
    }
}
