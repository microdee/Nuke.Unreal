using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Nuke.Common.Utilities;

namespace build.Generators;

public class ToolModel
{
    public record TypeModel(string Final, string Base);

    public string ConfigName { init; get; }
    public string CliName { init; get; }
    public TypeModel ConfigType { init; get; }
    public string ClassKeywords { get; set; } = "";
    public string Description { get; set; } = "No description";
    public List<ArgumentModel> Arguments { get; } = new();
    public List<ToolModel> Subtools { get; } = new();
}

public static class ToolModelExtensions
{
    public static bool AddArgument(this ToolModel self, ArgumentModel arg, params ToolModel[] alsoSearchIn)
    {
        var compareArgs = alsoSearchIn
            .Append(self)
            .Distinct()
            .SelectMany(t => t.Arguments);
        
        if (compareArgs.Any(a => a.ConfigName.EqualsOrdinalIgnoreCase(arg.ConfigName)))
        {
            return false;
        }

        self.Arguments.Add(arg);
        return true;
    }
}