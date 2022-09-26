
using System;
using System.IO;
using System.IO.Compression;
using Nuke.Common.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Nuke.Common;
using static Nuke.Common.IO.FileSystemTasks;
using static Nuke.Common.IO.PathConstruction;
using static Nuke.Common.Logger;
using static Nuke.Common.ControlFlow;

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