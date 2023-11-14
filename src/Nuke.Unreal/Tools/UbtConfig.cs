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
    /// <summary>
    /// Specify Project file without `-Project`
    /// </summary>
    /// <param name="project"></param>
    /// <param name="withKey">use `-project` key to specify target project</param>
    /// <returns></returns>
    public UbtConfig Project(string project, bool withKey = false)
    {
        if (!project.EndsWith(".uproject", true, null))
        {
            throw new ArgumentException("Project file path specified is not a *.uproject");
        }
        if (withKey)
        {
            AppendArgument(new("-project", project, Meta: new(AllowMultiple: true)));
        }
        else
        {
            AppendArgument(project);
        }
        return this;
    }

    /// <summary>
    /// Build with Game target
    /// </summary>
    /// <param name="present"></param>
    /// <returns></returns>
    public UbtConfig Game(bool present = true)
    {
        if (present)
        {
            AppendArgument(new UnrealToolArgument("-game"));
        }
        return this;
    }


    /// <summary>
    /// Build with Engine target
    /// </summary>
    /// <param name="present"></param>
    /// <returns></returns>
    public UbtConfig Engine(bool present = true)
    {
        if (present)
        {
            AppendArgument(new UnrealToolArgument("-engine"));
        }
        return this;
    }

    public UbtConfig Target(string name, UnrealPlatform platform, IEnumerable<UnrealConfig> config)
    {
        AppendArgument($"-Target={name} {platform} {string.Join('+', config)}", new(IsRawText: true));
        return this;
    }

    public UbtConfig Targets(params object[] target) => Targets(target.AsEnumerable());
    public UbtConfig Targets(IEnumerable<object> target)
    {
        AppendArgument(string.Join('+', target), new(IsRawText: true));
        return this;
    }

    public UbtConfig TargetPlatforms(params object[] platform) => TargetPlatforms(platform.AsEnumerable());
    public UbtConfig TargetPlatforms(IEnumerable<object> platform)
    {
        AppendArgument(string.Join('+', platform), new(IsRawText: true));
        return this;
    }

    public UbtConfig Configurations(params object[] config) => Configurations(config.AsEnumerable());
    public UbtConfig Configurations(IEnumerable<object> config)
    {
        AppendArgument(string.Join('+', config), new(IsRawText: true));
        return this;
    }
}