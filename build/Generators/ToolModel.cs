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
    public List<ToolModel> Subtools { get; } = new();
}