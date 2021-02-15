using System;
using Nuke.Common.IO;
using System.Runtime.CompilerServices;
using static Nuke.Common.ControlFlow;

namespace Nuke.Unreal
{
    public static class BuildCommon
    {
        public static AbsolutePath GetOuterFolder(Func<AbsolutePath, bool> predicate, [CallerFilePath] string scriptPath = null)
        {
            AbsolutePath RecurseBody(AbsolutePath current)
            {
                Assert(current.Parent != null, "Could not find a project root");
                if(predicate(current)) return current;
                return RecurseBody(current.Parent);
            }
            return RecurseBody(((AbsolutePath)scriptPath).Parent);
        }
    }
}
