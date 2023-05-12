using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nuke.Unreal.Tools;


/// <summary>
/// Unreal Build Tool defines the Unreal project structure and provides unified source
/// building utilities over multiple platforms
/// </summary>
public class UbtConfig : UbtConfigGenerated
{
    public UbtConfig Project(string project)
    {
        if (!project.EndsWith(".uproject", true, null))
        {
            throw new ArgumentException("Project file path specified is not a *.uproject");
        }
        AppendArgument(project);
        return this;
    }

    public UbtConfig Game(bool present = true)
    {
        if (present)
        {
            AppendArgument(new UnrealToolArgument("-game"));
        }
        return this;
    }

    public UbtConfig Engine(bool present = true)
    {
        if (present)
        {
            AppendArgument(new UnrealToolArgument("-engine"));
        }
        return this;
    }

    public UbtConfig Target(params object[] target) => Target(target.AsEnumerable());
    public UbtConfig Target(IEnumerable<object> target)
    {
        AppendArgument(string.Join('+', target), new(IsRawText: true));
        return this;
    }

    public UbtConfig Platform(params object[] platform) => Platform(platform.AsEnumerable());
    public UbtConfig Platform(IEnumerable<object> platform)
    {
        AppendArgument(string.Join('+', platform), new(IsRawText: true));
        return this;
    }

    public UbtConfig Configuration(params object[] config) => Configuration(config.AsEnumerable());
    public UbtConfig Configuration(IEnumerable<object> config)
    {
        AppendArgument(string.Join('+', config), new(IsRawText: true));
        return this;
    }
}