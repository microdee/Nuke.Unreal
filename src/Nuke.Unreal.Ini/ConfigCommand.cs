using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Nuke.Unreal.Ini;

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
        return a.Equals(b);
    }

    public static bool operator !=(ConfigCommand a, ConfigCommand b)
    {
        return !a.Equals(b);
    }

    public ConfigCommand(string line, int order)
    {
        Order = order;

        string command = "", name = "", value = "";

        line.MatchGroup(@"^(?<COMMAND>[\+\-!;]?)(?<NAME>.*?)(=(?<VALUE>.*))?$", RegexOptions.CultureInvariant)
            ?.Fetch("COMMAND", out command)
            ?.Fetch("NAME", out name)
            ?.Fetch("VALUE", out value);
        

        Type = string.IsNullOrWhiteSpace(command) || AllCommands.All(c => c != command[0])
            ? CommandType.Set
            : (CommandType) command[0];

        value = value.Trim();
        Name = Type != CommandType.Comment ? name.Trim() : name;
        IsQuotedString = value.StartsWith("\"") && value.EndsWith("\"");
        Value = IsQuotedString ? value.Trim('"') : value;
    }

    private string GetSerializedValue() => IsQuotedString ? $"\"{Value}\"" : Value;

    public string Serialize() => Type switch
    {
        CommandType.Set => $"{Name}={GetSerializedValue()}",
        CommandType.Add => $"+{Name}={GetSerializedValue()}",
        CommandType.Remove => $"-{Name}={GetSerializedValue()}",
        CommandType.Clear => "!" + Name,
        CommandType.Comment => ";" + Name + (string.IsNullOrWhiteSpace(GetSerializedValue()) ? "" : "=" + Value),
        _ => ""
    };

    public override bool Equals(object? obj)
    {
        if (obj is ConfigCommand b)
        {
            return Type == b.Type && Name == b.Name && Value == b.Value;
        }
        return false;
    }

    public override int GetHashCode() => (int)Type ^ (Name?.GetHashCode() ^ Value?.GetHashCode() ?? 0);
}