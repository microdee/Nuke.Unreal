using System.IO;
using Nuke.Common;
using Nuke.Unreal;
using Nuke.Cola.BuildPlugins;

public class TestBuild : UnrealBuildTest
{
    public static int Main() => Plugins.Execute<TestBuild>(Execute);

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
