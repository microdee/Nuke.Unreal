using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Nuke.Unreal.Config
{
    public static class ConfigCommon
    {
        public static GroupCollection MatchGroup(
            this string text,
            string pattern,
            RegexOptions options = RegexOptions.CultureInvariant | RegexOptions.Multiline)
        {
            var match = Regex.Match(text, pattern, options);
            return match?.Groups;
        }

        public static GroupCollection Fetch(this GroupCollection groups, string capturename, out string result)
        {
            result = groups[capturename]?.Value;
            return groups;
        }
    }

    public class ConfigIni
    {
        public readonly Dictionary<string, ConfigSession> Sessions = new();

        public ConfigSession this[string key] => Sessions.ContainsKey(key) ? Sessions[key] : null;

        public static ConfigIni Parse(string input)
        {
            ConfigSession currentSession = null;
            var ini = new ConfigIni();
            int order = 0;
            foreach(var line in input.Split(Environment.NewLine))
            {
                if (string.IsNullOrWhiteSpace(line)) continue;
                if (line.StartsWith('[') && line.EndsWith(']'))
                {
                    var sessionName = new string(line.Skip(1).SkipLast(1).ToArray());
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
                if (Sessions.ContainsKey(fromSession.Name))
                {
                    Sessions[fromSession.Name].Merge(fromSession);
                }
                else
                {
                    Sessions.Add(fromSession.Name, fromSession.Copy());
                }
            }
        }

        public string Serialize() => string.Join(Environment.NewLine,
            Sessions.Values.OrderBy(s => s.Order).Select(s => s.Serialize())
        );
    }
}