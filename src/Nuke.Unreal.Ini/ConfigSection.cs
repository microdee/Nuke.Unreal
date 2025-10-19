using System;
using System.Collections.Generic;
using System.Linq;

namespace Nuke.Unreal.Ini;

/// <summary>
/// Represents a section block in an Unreal INI configuration under a `[SectionName]` header
/// </summary>
public class ConfigSection
{
    /// <summary>
    /// Maintain the original position for this section as they were in the source file
    /// so serialization doesn't introduce that much unnecessary changes.
    /// </summary>
    public int Order { get; set; }

    /// <summary>
    /// Section name without square brackets
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// Individual config items underneath this section. Here it's referred to as commands because
    /// Unreal INI config items can procedurally add or remove items from containers.
    /// </summary>
    public List<ConfigCommand> Commands { get; private set; } = new();

    /// <summary>
    /// Get all commands matching given name.
    /// </summary>
    /// <returns>
    /// Matched commands or an empty enumerable if there wasn't any matching the given name.
    /// </returns>
    public IEnumerable<ConfigCommand> this[string key] => Commands.Where(c => c.Name == key);

    /// <summary>
    /// Parse an entire config item (or a line) as a command and add it to this section.
    /// </summary>
    /// <param name="line"></param>
    /// <param name="order">
    /// Maintain the original position for this section as they were in the source file
    /// so serialization doesn't introduce that much unnecessary changes.
    /// </param>
    public void SetLine(string line, int order)
    {
        if (string.IsNullOrWhiteSpace(line) || line[0] == '[')
        {
            return;
        }

        var command = new ConfigCommand(line, order);
        if (command.Type == CommandType.Set)
        {
            Commands = Commands.Where(c => c.Name != command.Name).ToList();
        }

        Commands.Add(command);
    }

    /// <summary>
    /// Remove all given keys from this section.
    /// </summary>
    public void Remove(IEnumerable<string> keys)
    {
        Commands = Commands.Where(c => !keys.Any(k => c.Name == k)).ToList();
    }

    /// <summary>
    /// Remove all given keys from this section.
    /// </summary>
    public void Remove(params string[] keys) => Remove(keys.AsEnumerable());

    /// <summary>
    /// Gets a config item in this section with specified key.
    /// </summary>
    /// <param name="key"></param>
    /// <param name="fallback"></param>
    /// <returns>
    /// Config item or a given fallback if it doesn't exist.
    /// </returns>
    public ConfigCommand GetFirst(string key, ConfigCommand fallback = default) =>
        this[key].Append(fallback).FirstOrDefault();

    /// <summary>
    /// Set or add an individual config item
    /// </summary>
    /// <param name="key">Name of the config item</param>
    /// <param name="value">Associated value after `=` sign.</param>
    /// <param name="type">Command type of config item.</param>
    public void Set(string key, string value, CommandType type = CommandType.Set)
    {
        char typeChar = (char)type;
        string typeString = typeChar == 0 ? "" : typeChar.ToString();
        var order = Commands.Count > 0 ? Commands.Max(s => s.Order) + 1 : 0;
        SetLine(typeString + key + "=" + value, order);
    }

    /// <summary>
    /// Merge another section into this one, overriding existing values and adding new ones.
    /// </summary>
    public void Merge(ConfigSection from)
    {
        foreach(var command in from.Commands)
        {
            switch (command.Type)
            {
                case CommandType.Set:
                    var index = Commands.FindIndex(c => c.Name == command.Name);
                    if (index >= 0)
                    {
                        var existingCommand = Commands[index];
                        existingCommand.Value = command.Value;
                        Commands[index] = existingCommand;
                    }
                    else Commands.Add(command);
                    break;

                case CommandType.Add:
                case CommandType.Remove:
                    
                    if (Commands.Any(c => c == command)) continue;
                    else
                    {
                        var inverseCommandType = CommandType.Remove;
                        if (command.Type == CommandType.Remove)
                            inverseCommandType = CommandType.Add;

                        var inverseCommand = command;
                        inverseCommand.Type = inverseCommandType;
                        if (Commands.Any(c => c == inverseCommand))
                        {
                            Commands = Commands.Where(c => c != inverseCommand).ToList();
                        }
                        else Commands.Add(command);
                    }
                    break;
                case CommandType.Clear:
                    Commands = Commands.Where(c => c.Name != command.Name).ToList();
                    Commands.Add(command);
                    break;
            }
        }
    }

    /// <summary>
    /// Convert this section to INI format.
    /// </summary>
    /// <returns></returns>
    public string Serialize()
    {
        var body = string.Join(Environment.NewLine, Commands.Select(c => c.Serialize()));
        return Environment.NewLine + "[" + Name + "]" + Environment.NewLine + body;
    }

    /// <summary>
    /// Deep copy this section.
    /// </summary>
    public ConfigSection Copy() => new() {
        Name = Name,
        Order = Order,
        Commands = Commands.ToList()
    };
}