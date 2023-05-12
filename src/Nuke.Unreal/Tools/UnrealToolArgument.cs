using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Nuke.Common.Utilities;

namespace Nuke.Unreal.Tools;

public record UnrealToolArgumentMeta(
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
public record UnrealToolArgument(
    string Name,
    string Value = "",
    char Setter = '=',
    UnrealToolArgumentMeta Meta = null
) {
    public override string ToString()
    {
        if (GetMeta().IsRawText) return Name;

        return string.IsNullOrWhiteSpace(Value)
            ? Name : (Name + Setter + Value).DoubleQuoteIfNeeded();
    }
    
    public static UnrealToolArgument Parse(string input, UnrealToolArgumentMeta meta = null)
    {
        var groups = Regex.Match(input, @"^(?<NAME>.*?)((?<SETTER>[:=])(?<VALUE>.*))?$")?.Groups;
        return groups?["NAME"] == null
            ? null
            : new(
                groups?["NAME"]?.Value,
                groups?["VALUE"]?.Value,
                (groups?["SETTER"]?.Value ?? "=")[0],
                Meta: meta
            );
    }

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