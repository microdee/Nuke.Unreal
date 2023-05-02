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
}