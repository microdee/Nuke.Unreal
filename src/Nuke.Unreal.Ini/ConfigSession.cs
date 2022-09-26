using System;
using System.Collections.Generic;
using System.Linq;

namespace Nuke.Unreal.Ini;

public class ConfigSession
{
    public int Order { get; set; }
    public string? Name { get; set; }
    public List<ConfigCommand> Commands { get; private set; } = new();

    public IEnumerable<ConfigCommand> this[string key] => Commands.Where(c => c.Name == key);

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

    public void Remove(IEnumerable<string> keys)
    {
        Commands = Commands.Where(c => !keys.Any(k => c.Name == k)).ToList();
    }

    public void Remove(params string[] keys) => Remove(keys.AsEnumerable());

    public ConfigCommand GetFirst(string key, ConfigCommand fallback = default) =>
        this[key].Append(fallback).FirstOrDefault();

    public void Set(string key, string value, CommandType type = CommandType.Set)
    {
        char typeChar = (char)type;
        string typeString = typeChar == 0 ? "" : typeChar.ToString();
        var order = Commands.Count > 0 ? Commands.Max(s => s.Order) + 1 : 0;
        SetLine(typeString + key + "=" + value, order);
    }

    public void Merge(ConfigSession from)
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

    public string Serialize()
    {
        var body = string.Join(Environment.NewLine, Commands.Select(c => c.Serialize()));
        return Environment.NewLine + "[" + Name + "]" + Environment.NewLine + body;
    }

    public ConfigSession Copy() => new() {
        Name = Name,
        Order = Order,
        Commands = Commands.ToList()
    };
}