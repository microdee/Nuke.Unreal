using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Nuke.Unreal.Ini;

/// <summary>
/// Unreal INI config items are read top to bottom, reading like individual commands, especially when
/// manipulating Unreal containers. This is why Nuke.Unreal.Ini refers to config lines as 'Commands'.
/// </summary>
public enum CommandType
{
    Set = 0,
    Add = '+',
    Remove = '-',
    Clear = '!',
    Comment = ';'
}

/// <summary>
/// Structural representation of a config line in Unreal.
/// </summary>
public struct ConfigCommand
{
    private const string AllCommands = "+-!;";
    
    /// <summary>
    /// Maintain the original position for this section as they were in the source file
    /// so serialization doesn't introduce that much unnecessary changes.
    /// </summary>
    public int Order;
    
    /// <summary>
    /// Config item name
    /// </summary>
    public string Name;

    /// <summary>
    /// Everything on the right side of the `=` symbol on a config,
    /// </summary>
    /// <remarks>
    /// For comments the actual text of the comment is contained in Name, however if that comment
    /// has `=` character everything following that will be stored in Value. Use CommentText
    /// when dealing with comments.
    /// </remarks>
    public string Value;

    /// <summary>
    /// Was the value quoted originally in the source config file.
    /// </summary>
    public bool IsQuotedString;

    /// <summary>
    /// How this config item should apply its value
    /// </summary>
    public CommandType Type;

    /// <summary>
    /// Get the full text of a comment including `=` character and its right side
    /// </summary>
    public string CommentText => Name + (string.IsNullOrWhiteSpace(GetSerializedValue()) ? "" : "=" + Value);

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