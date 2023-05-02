using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nuke.Unreal.Tools;

public abstract class ToolConfig
{
    public abstract string Name { get; }
    public abstract string CliName { get; }
    public abstract UnrealCompatibility Compatibility { get; }
    
    protected readonly Dictionary<string, UnrealToolArgument> UsingArguments = new();
    protected readonly Dictionary<string, ToolConfig> UsingSubtools = new();

    protected virtual ToolConfig[] Configs => Array.Empty<ToolConfig>();

    public virtual void AppendArgument(UnrealToolArgument arg)
    {
        if (UsingArguments.ContainsKey(arg.Name))
        {
            UsingArguments[arg.Name] = arg;
        }
        else
        {
            UsingArguments.Add(arg.Name, arg);
        }
    }

    public virtual void AppendArgument(string arg)
    {
        AppendArgument(UnrealToolArgument.Parse(arg));
    }

    public virtual void AppendSubtool(ToolConfig subtool)
    {
        UsingSubtools.TryAdd(subtool.Name, subtool);
    }

    public virtual string Gather(EngineVersion ueVersion)
    {
        var compatibleName = ueVersion.SemanticalVersion.Major > 4
            ? CliName.Replace("UE4", "Unreal")
            : CliName;

        var subtools = UsingSubtools.Values
            .Where(v => ueVersion.IsCompatibleWith(v.Compatibility))
            .Select(v => v.Gather(ueVersion));

        var args = UsingArguments.Values
            .Where(v => ueVersion.IsCompatibleWith(v.Compatibility))
            .Select(v => v.Gather(ueVersion));

        return (compatibleName + " " + string.Join(' ', subtools.Concat(args))).Trim();
    }
}

public static class ToolConfigExtensions
{
    public static T If<T>(this T config, bool condition, Action<T> @true = null, Action<T> @false = null) where T : ToolConfig
    {
        if (condition) @true?.Invoke(config);
        else @false?.Invoke(config);
        return config;
    }

    public static T Append<T>(this T config, params string[] arguments) where T : ToolConfig =>
        Append(config, arguments.AsEnumerable());

    public static T Append<T>(this T config, IEnumerable<string> arguments) where T : ToolConfig
    {
        foreach(var arg in arguments)
        {
            config.AppendArgument(arg);
        }
        return config;
    }
}