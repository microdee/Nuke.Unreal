using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Nuke.Common.Utilities;

namespace build.Generators;

public class ToolModel : CommandLineEntity, IProvideArguments
{
    public record TypeModel(string Final, string Base);

    public TypeModel ConfigType { init; get; }
    public string ClassKeywords { get; set; } = "";
    public List<ArgumentModel> Arguments { get; set; } = new();
    public List<ToolModel> Subtools { get; private set; } = new();

    public ToolModel Merge(ToolModel other)
    {
        Compatibility = Compatibility.Union(other.Compatibility).ToList();
        this.MergeDocs(other);

        foreach(var arg in other.Arguments)
        {
            this.AddArgument(arg);
        }

        foreach(var tool in other.Subtools)
        {
            var outputSubtool = Subtools.FirstOrDefault(t => t.ConfigName == tool.ConfigName);
            if (outputSubtool == null)
            {
                Subtools.Add(tool);
            }
            else
            {
                outputSubtool.Merge(tool);
            }
        }
        return this;
    }
}