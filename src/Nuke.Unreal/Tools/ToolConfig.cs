using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nuke.Unreal.Tools;

public abstract class ToolConfig
{
    public abstract string Name { get; }
    
    internal readonly List<string> Arguments = new();

    protected virtual ToolConfig[] Configs => Array.Empty<ToolConfig>();

    internal virtual void AppendArgument(string arg)
    {
        if (!string.IsNullOrWhiteSpace(arg))
            Arguments.Add(arg);
    }

    internal virtual void AppendSubtool(ToolConfig subtool)
    {
        AppendArgument(subtool.Gather());
    }

    public virtual string Gather() => string.Join(' ', Arguments);
}

public static class ToolConfigExtensions
{
    public static T If<T>(this T config, bool condition, Action<T> @true = null, Action<T> @false = null) where T : ToolConfig
    {
        if (condition) @true?.Invoke(config);
        else @false?.Invoke(config);
        return config;
    }

    public static T Append<T>(this T config, params string[] arguments) where T : ToolConfig
    {
        foreach(var arg in arguments)
        {
            config.AppendArgument(arg);
        }
        return config;
    }
}