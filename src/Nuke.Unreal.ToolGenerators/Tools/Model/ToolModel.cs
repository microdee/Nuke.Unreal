using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nuke.Unreal.ToolGenerators.Tools.Model;

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