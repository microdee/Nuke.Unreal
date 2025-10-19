using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Nuke.Unreal.Ini;

/// <summary>
/// Utilities for parsing Unreal configuration files
/// </summary>
public static class ConfigCommon
{
    public static GroupCollection? MatchGroup(
        this string text,
        string pattern,
        RegexOptions options = RegexOptions.CultureInvariant | RegexOptions.Multiline)
    {
        var match = Regex.Match(text, pattern, options);
        return match?.Groups;
    }

    public static GroupCollection? Fetch(this GroupCollection groups, string capturename, out string result)
    {
        result = groups[capturename].Value;
        return groups;
    }

    /// <summary>
    /// Convert a command type into its representing character
    /// </summary>
    /// <param name="commandType"></param>
    /// <returns>
    ///     Command type character or empty string if command doesn't have associated symbol.
    /// </returns>
    public static string AsCharacter(this CommandType commandType) => commandType switch
    {
        CommandType.Set => "",
        CommandType.Add => "+",
        CommandType.Remove => "-",
        CommandType.Clear => "!",
        CommandType.Comment => ";",
        _ => ""
    };
}

/// <summary>
/// The root class representing Unreal INI configuration
/// </summary>
public class ConfigIni
{
    /// <summary>
    /// Sections separated by `[SectionName]` syntax
    /// </summary>
    public readonly Dictionary<string, ConfigSection> Sections = new();

    /// <summary>
    /// Get a section via its name
    /// </summary>
    public ConfigSection? this[string key] => Sections.ContainsKey(key) ? Sections[key] : null;

    /// <summary>
    /// Get an existing section or add it if it doesn't exist yet.
    /// </summary>
    /// <param name="key"></param>
    /// <returns></returns>
    public ConfigSection FindOrAdd(string key)
    {
        var result = this[key];
        if (result == null)
        {
            var lastOrder = Sections.Count > 0 ? Sections.Values.Max(s => s.Order) + 1 : 0;
            result = new ConfigSection {Order = lastOrder, Name = key};
            Sections.Add(key, result);
        }
        return result;
    }

    /// <summary>
    /// Parse an Unreal configuration text into a ConfigIni.
    /// </summary>
    /// <returns>Resulting ConfigIni or null if parsing was not possible.</returns>
    public static ConfigIni? Parse(string? input)
    {
        if (string.IsNullOrWhiteSpace(input)) return null;
        ConfigSection? currentSection = null;
        var ini = new ConfigIni();
        int order = 0;
        foreach(var lineIn in input!.Split(new [] { "\r", "\n" }, StringSplitOptions.None))
        {
            if (string.IsNullOrWhiteSpace(lineIn)) continue;
            var line = lineIn.Trim();
            
            if (line.StartsWith("[") && line.EndsWith("]"))
            {
                var sectionName = line.TrimStart('[').TrimEnd(']');
                if (ini.Sections.ContainsKey(sectionName))
                {
                    currentSection = ini.Sections[sectionName];
                }
                else
                {
                    currentSection = new() { Order = order, Name = sectionName };
                    ini.Sections.Add(sectionName, currentSection);
                }
            }
            else
            {
                currentSection?.SetLine(line, order);
            }
            order++;
        }

        return order > 0 ? ini : null;
    }

    /// <summary>
    /// Compose another ConfigIni instance into this one, overriding existing values and adding new
    /// ones.
    /// </summary>
    public void Merge(ConfigIni from)
    {
        foreach(var fromSection in from.Sections.Values)
        {
            var name = fromSection.Name ?? "";
            if (Sections.ContainsKey(name))
            {
                Sections[name].Merge(fromSection);
            }
            else
            {
                Sections.Add(name, fromSection.Copy());
            }
        }
    }

    /// <summary>
    /// Convert this ConfigIni back to something Unreal can read.
    /// </summary>
    public string Serialize() => string.Join(Environment.NewLine,
        Sections.Values.OrderBy(s => s.Order).Select(s => s.Serialize())
    );
}