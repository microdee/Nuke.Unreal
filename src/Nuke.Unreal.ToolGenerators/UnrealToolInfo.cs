
using System;
using System.Threading;
using System.Text.RegularExpressions;
using System.Collections.Concurrent;
using System.Diagnostics;

using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace Nuke.Unreal.ToolGenerators
{
    public class UnrealToolInfo
    {
        public class Parameter
        {
            public string Name { init; get; }
            public string ValueName { init; get; }
            public bool HasValue => ValueName != null;
            public string HelpText { init; get; }

            public static Parameter FromHelpNameSyntax([NotNull] string HelpName, string helpText)
            {
                var paramPair = HelpName.Split('=');
                string valueName = null;
                if(paramPair.Length > 1)
                {
                    valueName = paramPair[1].TrimStart('<').TrimEnd('>');
                }
                return new()
                {
                    Name = paramPair[0].TrimStart('-'),
                    ValueName = valueName,
                    HelpText = helpText
                };
            }
        }

        public class Command
        {
            public string Name { init; get; }
            public string HelpText { init; get; }
            public List<Parameter> Parameters { init; get; }
        }

        public class Group : UnrealToolInfo
        {
        }
        
        public string Name { init; get; }
        public List<Parameter> Parameters { init; get; }
    }
}