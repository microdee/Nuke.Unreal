using Nuke.Common.IO;
using Nuke.Common;

namespace Nuke.Unreal
{
    public interface IProgramTargets<TProgramList>
        where TProgramList : UnrealProgram
    {
        [Parameter("The target program to execute operations on")]
        TProgramList Program { get; set; }

        AbsolutePath ProgramProject => NukeBuild.RootDirectory / Program.GetProgram().PathToProject;
    }
}