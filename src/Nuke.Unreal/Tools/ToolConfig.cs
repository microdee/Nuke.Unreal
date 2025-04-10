using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Nuke.Common.Tooling;
using Nuke.Common.Utilities;
using Serilog;

namespace Nuke.Unreal.Tools;

/// <summary>
/// The base class for generated strongly typed tool configurators providing base
/// functionalities like argument and subtool management
/// </summary>
public abstract class ToolConfig : Options
{
    /// <summary>
    /// The C# friendly name of the tool which will be used inside configurators
    /// </summary>
    public abstract string Name { get; }

    /// <summary>
    /// The name which will be rendered onto command line.
    /// </summary>
    public abstract string CliName { get; }

    /// <summary>
    /// Compatibility with either Unreal Engine 4 or 5 or both.
    /// If tool is configured to run with an incompatible engine its entire configuration
    /// will be ignored.
    /// </summary>
    public abstract UnrealCompatibility Compatibility { get; }
    
    protected List<UnrealToolArgument> UsingArguments = [];
    protected readonly Dictionary<string, ToolConfig> UsingSubtools = [];

    protected virtual ToolConfig[] Configs => [];

    public virtual void AppendArgument(UnrealToolArgument arg)
    {
        var meta = arg.GetMeta();
        bool allowMultiple = meta.AllowMultiple || meta.IsRawText;
        if (!allowMultiple)
        {
            UsingArguments = UsingArguments
                .Where(a => !a.Name.EqualsOrdinalIgnoreCase(arg.Name))
                .ToList();
        }
        UsingArguments.Add(arg);
    }

    public virtual void AppendArgument(string arg, UnrealToolArgumentMeta? meta = null)
    {
        AppendArgument(UnrealToolArgument.Parse(arg, meta)!);
    }

    public virtual void AppendSubtool(ToolConfig subtool)
    {
        UsingSubtools.TryAdd(subtool.Name, subtool);
    }

    /// <summary>
    /// Gether the arguments and subtools and render a command line output
    /// </summary>
    /// <param name="ueVersion"></param>
    /// <returns>The command line output to be passed to the wrapped tool</returns>
    public virtual string Gather(EngineVersion ueVersion)
    {
        var compatibleName = ueVersion.SemanticalVersion.Major > 4
            ? CliName.Replace("UE4", "Unreal")
            : CliName;

        var subtools = UsingSubtools.Values
            .Where(v => ueVersion.IsCompatibleWith(v.Compatibility))
            .Select(v => v.Gather(ueVersion));

        foreach (var subtool in UsingSubtools.Values.Where(v => !ueVersion.IsCompatibleWith(v.Compatibility)))
        {
            Log.Warning(
                "The tool {0} ({1}) is only compatible with {2} therefore it is ignored (current compatibility: {3})",
                subtool.Name,
                subtool.CliName,
                subtool.Compatibility,
                ueVersion.Compatibility
            );
        }

        var args = UsingArguments
            .Where(v => ueVersion.IsCompatibleWith(v.GetMeta().Compatibility))
            .Select(v => v.Gather(ueVersion));

        foreach (var arg in UsingArguments.Where(v => !ueVersion.IsCompatibleWith(v.GetMeta().Compatibility)))
        {
            Log.Warning(
                "The argument {0} is only compatible with {1} therefore it is ignored (current compatibility: {2})",
                arg.Name,
                arg.GetMeta().Compatibility,
                ueVersion.Compatibility
            );
        }

        return (compatibleName + " " + string.Join(' ', subtools.Concat(args))).Trim();
    }
}

public static class ToolConfigExtensions
{
    /// <summary>
    /// Convenience function for conditionally configuring a tool
    /// </summary>
    /// <param name="config"></param>
    /// <param name="condition"></param>
    /// <param name="true">Execute delegate when condition is true</param>
    /// <param name="false">Execute delegate when condition is false</param>
    /// <typeparam name="T"></typeparam>
    /// <returns>The same configurator as the input one</returns>
    public static T If<T>(this T config, bool condition, Action<T>? @true = null, Action<T>? @false = null) where T : ToolConfig
    {
        if (condition) @true?.Invoke(config);
        else @false?.Invoke(config);
        return config;
    }

    /// <summary>
    /// Convenience function to apply potentially stacking command line arguments for each element in an enumerable
    /// </summary>
    /// <param name="config"></param>
    /// <param name="collection"></param>
    /// <param name="body">Execute delegate for each item of `collection`</param>
    /// <typeparam name="T"></typeparam>
    /// <typeparam name="I"></typeparam>
    /// <returns>The same configurator as the input one</returns>
    public static T For<T, I>(this T config, IEnumerable<I> collection, Action<I, T> body) where T : ToolConfig
    {
        foreach (var item in collection)
        {
            body?.Invoke(item, config);
        }
        return config;
    }

    /// <summary>
    /// Append arbitrary arguments to target configurator.
    /// Arguments will be parsed for (NAME)[=:]?(VALUE)? structure, and quoted if necessary
    /// </summary>
    /// <param name="config"></param>
    /// <param name="arguments"></param>
    /// <typeparam name="T"></typeparam>
    /// <returns>The same configurator as the input one</returns>
    public static T Append<T>(this T config, params string[] arguments) where T : ToolConfig =>
        Append(config, arguments.AsEnumerable());

    /// <summary>
    /// Append arbitrary arguments to target configurator.
    /// Arguments will be parsed for (NAME)[=:]?(VALUE)? structure, and quoted if necessary
    /// </summary>
    /// <param name="config"></param>
    /// <param name="arguments"></param>
    /// <typeparam name="T"></typeparam>
    /// <returns>The same configurator as the input one</returns>
    public static T Append<T>(this T config, IEnumerable<string?> arguments) where T : ToolConfig
    {
        foreach(var arg in arguments)
        {
            if (arg == null) continue;
            config.AppendArgument(arg);
        }
        return config;
    }

    /// <summary>
    /// Append arbitrary arguments to target configurator.
    /// Arguments will be passed as is
    /// </summary>
    /// <param name="config"></param>
    /// <param name="arguments"></param>
    /// <typeparam name="T"></typeparam>
    /// <returns>The same configurator as the input one</returns>
    public static T AppendRaw<T>(this T config, params string[] arguments) where T : ToolConfig =>
        AppendRaw(config, arguments.AsEnumerable());

    /// <summary>
    /// Append arbitrary arguments to target configurator.
    /// Arguments will be passed as is
    /// </summary>
    /// <param name="config"></param>
    /// <param name="arguments"></param>
    /// <typeparam name="T"></typeparam>
    /// <returns>The same configurator as the input one</returns>
    public static T AppendRaw<T>(this T config, IEnumerable<string> arguments) where T : ToolConfig
    {
        foreach(var arg in arguments)
        {
            config.AppendArgument(new UnrealToolArgument(
                Name: arg,
                Meta: new(IsRawText: true)
            ));
        }
        return config;
    }
}