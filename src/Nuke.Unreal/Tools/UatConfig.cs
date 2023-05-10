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

    public override UatConfig NoCompile(params object[] values)
    {
        // Overriding NoCompile, despite being flagged as deprecated in UE4, it's no longer
        // deprecated in UE5. However to not confuse usage for UE4, here we override
        // the argument compatibility.
        if (true)
        {
            AppendArgument(new UnrealToolArgument(
                "-NoCompile",
                Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                Setter: '=',
                Compatibility: UnrealCompatibility.All
            ));
        }
        return this;
    }
}