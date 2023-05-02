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

    public UnrealBuildToolConfig Game(bool present = true)
    {
        AppendArgument(present ? "-game" : "");
        return this;
    }

    public UnrealBuildToolConfig Engine(bool present = true)
    {
        AppendArgument(present ? "-engine" : "");
        return this;
    }

    public UnrealBuildToolConfig Target(params object[] target) => Target(target.AsEnumerable());
    public UnrealBuildToolConfig Target(IEnumerable<object> target)
    {
        AppendArgument(string.Join('+', target));
        return this;
    }

    public UnrealBuildToolConfig Platform(params object[] platform) => Platform(platform.AsEnumerable());
    public UnrealBuildToolConfig Platform(IEnumerable<object> platform)
    {
        AppendArgument(string.Join('+', platform));
        return this;
    }

    public UnrealBuildToolConfig Configuration(params object[] config) => Configuration(config.AsEnumerable());
    public UnrealBuildToolConfig Configuration(IEnumerable<object> config)
    {
        AppendArgument(string.Join('+', config));
        return this;
    }
}