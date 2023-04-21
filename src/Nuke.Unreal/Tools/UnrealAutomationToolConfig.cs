using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nuke.Unreal.Tools;

public class UnrealAutomationToolConfig : UnrealAutomationToolConfigGenerated
{
    /// <summary>
    /// Path to the current project. May not be specified, in which case we compile scripts for all projects.
    /// </summary>
    public virtual UnrealAutomationToolConfig ScriptsForProject(params object[] values)
    {
        AppendArgument(values != null && values.Length > 0 ? "-ScriptsForProject=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-ScriptsForProject");
        return this;
    }
    
    public override string Gather()
    {
        var output = new List<string>();
        var notool = new List<string>();
        var perTool = new Dictionary<string, List<string>>();
        foreach(var carg in Arguments)
        {
            var args = carg.Trim().Split(' ');
            if (Configs.Any(c => args[0] == c.Name))
            {
                if (!perTool.TryGetValue(args[0], out var toolArgs))
                {
                    toolArgs = new();
                    perTool.Add(args[0], toolArgs);
                }
                toolArgs.AddRange(args.Skip(1));
            }
            else
            {
                notool.AddRange(args);
            }
        }

        foreach((var tool, var args) in perTool)
        {
            output.Add(tool);
            output.AddRange(args);
        }
        output.AddRange(notool);
        return string.Join(' ', output);
    }
}