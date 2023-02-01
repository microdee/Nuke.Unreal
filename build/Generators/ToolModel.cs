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
    public string DocsXml { get; set; } = "";
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
            .SelectMany(t => t.Arguments)
            .Where(a => a.ConfigName.EqualsOrdinalIgnoreCase(arg.ConfigName));
            
        bool addNew = true;
        foreach(var otherArg in compareArgs)
        {
            if (string.IsNullOrWhiteSpace(otherArg.DocsXml))
            {
                otherArg.DocsXml = arg.DocsXml;
            }
            otherArg.Enum ??= arg.Enum;
            addNew = false;
        }
        if (addNew)
        {
            self.Arguments.Add(arg);
        }
        return addNew;
    }
}