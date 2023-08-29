using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Nuke.Unreal.Ini;

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

public class ConfigIni
{
    public readonly Dictionary<string, ConfigSession> Sessions = new();

    public ConfigSession? this[string key] => Sessions.ContainsKey(key) ? Sessions[key] : null;

    public ConfigSession FindOrAdd(string key)
    {
        var result = this[key];
        if (result == null)
        {
            var lastOrder = Sessions.Count > 0 ? Sessions.Values.Max(s => s.Order) + 1 : 0;
            result = new ConfigSession {Order = lastOrder, Name = key};
            Sessions.Add(key, result);
        }
        return result;
    }

    public static ConfigIni? Parse(string input)
    {
        if (string.IsNullOrWhiteSpace(input)) return null;
        ConfigSession? currentSession = null;
        var ini = new ConfigIni();
        int order = 0;
        foreach(var lineIn in input.Split(new [] { "\r", "\n" }, StringSplitOptions.None))
        {
            if (string.IsNullOrWhiteSpace(lineIn)) continue;
            var line = lineIn.Trim();
            
            if (line.StartsWith("[") && line.EndsWith("]"))
            {
                var sessionName = line.TrimStart('[').TrimEnd(']');
                if (ini.Sessions.ContainsKey(sessionName))
                {
                    currentSession = ini.Sessions[sessionName];
                }
                else
                {
                    currentSession = new() { Order = order, Name = sessionName };
                    ini.Sessions.Add(sessionName, currentSession);
                }
            }
            else if (currentSession != null)
            {
                currentSession.SetLine(line, order);
            }
            order++;
        }

        return order > 0 ? ini : null;
    }

    public void Merge(ConfigIni from)
    {
        foreach(var fromSession in from.Sessions.Values)
        {
            var name = fromSession.Name ?? "";
            if (Sessions.ContainsKey(name))
            {
                Sessions[name].Merge(fromSession);
            }
            else
            {
                Sessions.Add(name, fromSession.Copy());
            }
        }
    }

    public string Serialize() => string.Join(Environment.NewLine,
        Sessions.Values.OrderBy(s => s.Order).Select(s => s.Serialize())
    );
}