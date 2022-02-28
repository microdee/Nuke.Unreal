using System;
using Nuke.Common.IO;
using System.Runtime.CompilerServices;
using Nuke.Common;
using System.Collections;
using System.Collections.Generic;
using Nuke.Common.Utilities.Collections;
using System.Linq;
using Nuke.Common.Utilities;

namespace Nuke.Unreal
{
    public static class BuildCommon
    {
        public static AbsolutePath GetOuterFolder(Func<AbsolutePath, bool> predicate, [CallerFilePath] string scriptPath = null)
        {
            AbsolutePath RecurseBody(AbsolutePath current)
            {
                Assert.True(current.Parent != null, "Could not find a project root");
                if(predicate(current)) return current;
                return RecurseBody(current.Parent);
            }
            return RecurseBody(((AbsolutePath)scriptPath).Parent);
        }

        private static string ProcessArgument(string arg)
        {
            if(string.IsNullOrWhiteSpace(arg)) return arg;

            // internal escape character is ~
            arg = arg.TrimMatchingDoubleQuotes()
                .Replace("~''", "\"") // sequence for double quotes
                .Replace("~-", "-"); // sequence for -
            if(arg[0] == '~')
                arg = string.Concat("-", arg.AsSpan(1));
            return arg;
        }

        public static string AppendAsArguments(this IEnumerable<string> input) =>
            (input?.IsEmpty() ?? true) ? "" : " " + string.Join(' ', input.Select(ProcessArgument));
    }
}
