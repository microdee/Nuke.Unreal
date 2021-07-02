
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
    public abstract class ProgramTargets<TProgramList> : CommonTargets
        where TProgramList : UnrealProgram
    {
        [Parameter("The target program to execute operations on")]
        public abstract TProgramList Program { get; set; }

        public override AbsolutePath ToProject => RootDirectory / Program.GetProgram().PathToProject;

        public override Target BuildEditor => _ => _
            .Unlisted()
            .Executes(() => {
                throw new InvalidOperationException("This type of target is not supported on Unreal Programs");
            });

        public override Target Cook => _ => _
            .Unlisted()
            .Executes(() => {
                throw new InvalidOperationException("This type of target is not supported on Unreal Programs");
            });
    }
}