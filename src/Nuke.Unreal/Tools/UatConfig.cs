using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nuke.Unreal.Tools;

public class UatConfig : UatConfigGenerated
{
    /// <summary>
    /// Path to the current project. May not be specified, in which case we compile scripts for all projects.
    /// </summary>
    public virtual UatConfig ScriptsForProject(params object[] values)
    {
        AppendArgument(
            new UnrealToolArgument("-ScriptsForProject", string.Join("+", values))
        );
        return this;
    }
}