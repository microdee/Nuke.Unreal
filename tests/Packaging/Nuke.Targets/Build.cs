using Nuke.Common;
using Nuke.Common.IO;
using Nuke.Unreal;
using Nuke.Cola.BuildPlugins;

class TestBuild : UnrealBuildTest, IPackageTargets
{
    public static int Main() => Plugins.Execute<TestBuild>(Execute);

    AbsolutePath PlatformBinariesFolder => ProjectFolder / "Binaries" / Unreal.GetHostPlatformFlag().ToString();

    Target Test => _ => _
        .Triggers(Generate);

    Target CheckGenerate => _ => _
        .TriggeredBy(Generate)
        .Triggers(Cook)
        .Executes(() =>
        {
            Assert.FileExists(ProjectFolder / (ProjectName + ".sln"));
        });

    Target CheckBuildEditor => _ => _
        .TriggeredBy(BuildEditor)
        .Executes(() =>
        {
            Assert.NotEmpty(PlatformBinariesFolder.GlobFiles($"*Editor-{ProjectName}*"));
        });

    Target CheckCook => _ => _
        .TriggeredBy(Cook)
        .Triggers(Build);

    Target CheckBuild => _ => _
        .TriggeredBy(Build)
        .Triggers<IPackageTargets>(p => p.Package)
        .Executes(() =>
        {
            Assert.NotEmpty(PlatformBinariesFolder.GlobFiles($"{ProjectName}*"));
        });

    Target CheckPackage => _ => _
        .TriggeredBy<IPackageTargets>(p => p.Package)
        .Executes(() =>
        {
            if (Platform == UnrealPlatform.Win64)
            {
                Assert.FileExists(GetOutput() / "Windows" / $"{ProjectName}.exe");
            }
        });
}
