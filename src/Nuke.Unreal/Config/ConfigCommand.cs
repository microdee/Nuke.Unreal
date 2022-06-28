using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using Nuke.Common.Utilities;
using Nuke.Common.Utilities.Collections;

namespace Nuke.Unreal.Config
{
    public enum CommandType
    {
        Set = 0,
        Add = '+',
        Remove = '-',
        Clear = '!',
        Comment = ';'
    }

    public struct ConfigCommand
    {
        private const string AllCommands = "+-!;";
        public int Order;
        public string Name;
        public string Value;
        public bool IsQuotedString;
        public CommandType Type;

        public static bool operator ==(ConfigCommand a, ConfigCommand b)
        {
            return a.Type == b.Type && a.Name == b.Name && a.Value == b.Value;
        }

        public static bool operator !=(ConfigCommand a, ConfigCommand b)
        {
            return a.Type != b.Type || a.Name != b.Name || a.Value != b.Value;
        }

        public ConfigCommand(string line, int order)
        {
            Order = order;

            line.MatchGroup(
                @"^(?<COMMAND>[\+\-!;]?)" +
                @"(?<NAME>.*?)" +
                @"(=(?<VALUE>.*))?$",
                RegexOptions.CultureInvariant
            )
                .Fetch("COMMAND", out var command)
                .Fetch("NAME", out var name)
                .Fetch("VALUE", out var value);
            

            Type = string.IsNullOrWhiteSpace(command) || AllCommands.All(c => c != command[0])
                ? CommandType.Set
                : (CommandType) command[0];

            value = value?.Trim();
            Name = Type != CommandType.Comment ? name?.Trim() : name;
            IsQuotedString = value.IsDoubleQuoted();
            Value = value.TrimMatchingDoubleQuotes();
        }

        private string GetSerializedValue() => IsQuotedString ? Value.DoubleQuote() : Value;

        public string Serialize() => Type switch
        {
            CommandType.Set => $"{Name}={GetSerializedValue()}",
            CommandType.Add => $"+{Name}={GetSerializedValue()}",
            CommandType.Remove => $"-{Name}={GetSerializedValue()}",
            CommandType.Clear => "!" + Name,
            CommandType.Comment => ";" + Name + (string.IsNullOrWhiteSpace(GetSerializedValue()) ? "" : "=" + Value),
            _ => ""
        };
    }
}