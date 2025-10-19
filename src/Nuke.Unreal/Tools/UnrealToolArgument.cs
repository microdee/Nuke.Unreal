using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Nuke.Common.Utilities;

namespace Nuke.Unreal.Tools;

/// <summary>
/// Properties guiding how to process the argument
/// </summary>
/// <param name="Compatibility">
/// Which major engine version this argument is compatible with
/// </param>
/// <param name="AllowMultiple">
/// Allow multiple instances of this argument distinct by name only in the same command line
/// output.
/// </param>
/// <param name="IsRawText">
/// Argument is provided as-is in the Name field, do not parse it or escape it.
/// </param>
/// <returns></returns>
public record class UnrealToolArgumentMeta(
    UnrealCompatibility Compatibility = UnrealCompatibility.All,
    bool AllowMultiple = false,
    bool IsRawText = false
);

/// <summary>
/// Argument for an Unreal tool
/// </summary>
/// <param name="Name">Argument name including optional starting dash (-MyArg)</param>
/// <param name="Value">Flattened value of argument</param>
/// <param name="Setter"></param>
/// <param name="Meta">Properties guiding how to process the argument</param>
public partial record class UnrealToolArgument(
    string Name,
    string? Value = null,
    char Setter = '=',
    UnrealToolArgumentMeta? Meta = null
) {
    /// <summary>
    /// Render the command line without 'UE4' -&gt; 'Unreal' compatibility transformation
    /// </summary>
    public override string ToString()
    {
        if (GetMeta().IsRawText) return Name;

        return string.IsNullOrWhiteSpace(Value)
            ? Name : (Name + Setter + Value).DoubleQuoteIfNeeded();
    }

    [GeneratedRegex(@"^(?<NAME>.*?)((?<SETTER>[:=])(?<VALUE>.*))?$")]
    private static partial Regex ParseRegex();
    
    /// <summary>
    /// Parse a (NAME)[=:]?(VALUE)? formatted argument
    /// </summary>
    /// <param name="input"></param>
    /// <param name="meta">
    /// Pass in new(IsRawText: true) to not parse it and take input at face value
    /// </param>
    /// <returns></returns>
    public static UnrealToolArgument? Parse(string input, UnrealToolArgumentMeta? meta = null)
    {
        meta ??= new();
        if (meta.IsRawText)
        {
            return new(
                Name: input,
                Meta: meta
            );
        }

        var groups = ParseRegex().Match(input)?.Groups;
        return groups?["NAME"] == null
            ? null
            : new(
                groups?["NAME"]?.Value!,
                groups?["VALUE"]?.Value,
                (groups?["SETTER"]?.Value ?? "=").FirstOrDefault('='),
                Meta: meta
            );
    }

    /// <summary>
    /// Render the command line with 'UE4' -&gt; 'Unreal' compatibility transformation
    /// if we're gathering for UE5
    /// </summary>
    public string Gather(EngineVersion ueVersion)
    {
        if (GetMeta().IsRawText) return Name;
        
        var compatibleName = ueVersion.SemanticalVersion.Major > 4
            ? Name.Replace("UE4", "Unreal")
            : Name;
        return string.IsNullOrWhiteSpace(Value)
            ? compatibleName : (compatibleName + Setter + Value).DoubleQuoteIfNeeded();
    }

    public UnrealToolArgumentMeta GetMeta() => Meta ?? new();
}