using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nuke.Unreal.Tools;

public class UnrealBuildToolConfig : UnrealBuildToolConfigGenerated
{
    public UnrealBuildToolConfig Project(string project)
    {
        if (!project.EndsWith(".uproject", true, null))
        {
            throw new ArgumentException("Project file path specified is not a *.uproject");
        }
        AppendArgument(project);
        return this;
    }

    public UnrealBuildToolConfig Target(params string[] target)
    {
        AppendArgument(string.Join('+', target));
        return this;
    }

    public UnrealBuildToolConfig Platform(params string[] platform)
    {
        AppendArgument(string.Join('+', platform));
        return this;
    }

    public UnrealBuildToolConfig Configuration(params string[] config)
    {
        AppendArgument(string.Join('+', config));
        return this;
    }
}