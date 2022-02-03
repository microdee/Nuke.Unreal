
using System;

using System.Collections.Generic;
using System.Runtime.InteropServices;
using Nuke.Common.IO;

namespace Nuke.Unreal
{
    public abstract class ToolEntity
    {
        public ToolEntity Parent { init; get; }
        public virtual UnrealToolOutput Invoke(EngineVersion withVersion) => Parent.Invoke(withVersion);
    }

    public abstract class UnrealTool : ToolEntity
    {
        public class Parameter
        {
            public string Name { init; get; }
            public string Value { init; get; }

            public override string ToString() => $"-{Name}={Value}";
        }

        public class ParameterCollection
        {
            protected readonly List<Parameter> Parameters = new();

            public string Name { init; get; }

            public void Add(string name, string value = null) =>
                Parameters.Add(new() {
                    Name = name,
                    Value = value
                });

            public override string ToString() => string.Join(' ', Parameters);
        }

        public class Command : ToolEntity
        {
            public string Name { init; get; }
            internal readonly ParameterCollection Parameters = new();
        }

        protected Command SelectedCommand;

        public class Group : ToolEntity
        {
            internal Command SelectedCommand = new();
        }

        protected Group SelectedGroup;
        
        internal readonly ParameterCollection Parameters = new();

        protected abstract AbsolutePath GetToolExe(EngineVersion withVersion);
        protected abstract bool IsToolDotNet();

        protected virtual string GetArguments()
        {
            var selCommand = SelectedGroup?.SelectedCommand ?? SelectedCommand;
            var result = "";
            if(selCommand != null)
                result = selCommand.Name + " " + selCommand.Parameters;

            return result + " " + Parameters;
        }

        public override UnrealToolOutput Invoke(EngineVersion withVersion)
        {
            var uetPath = GetToolExe(withVersion);
            var uetArgs = GetArguments();
            if(IsToolDotNet())
            {
                if(RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                    return new UnrealToolOutput(uetPath, uetArgs);
                
                return new UnrealToolOutput("mono", $"\"{uetPath}\" " + uetArgs);
            }
            return new UnrealToolOutput(uetPath, uetArgs);
        }
    }
}