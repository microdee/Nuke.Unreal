using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Nuke.Common.IO;

namespace build.Generators.UBT;

public class UbtGeneratorContext
    : IGatheringContext
    , IHaveSubTools
    , IHaveLogDisplayInfo
    , IHaveEngineCompatibility
{
    public int Indentation { get; set; } = 0;
    public ToolModel MainTool { get; set; }
    public List<ToolModel> SubTools { get; } = new();
    public UnrealCompatibility Compatibility { get; set; } = UnrealCompatibility.All;
}

public class UbtGeneratorFromSource : GeneratorFromSource
{
    public override string TemplateName => "UbtConfigGenerated";

    private record UbtModel(ToolModel Ubt);

    protected override object GetFullModel(ToolModel tool) => new UbtModel(tool);
    protected override AbsolutePath[] GetRoots(string engineVersion, UnrealCompatibility compatibility) =>
        base.GetRoots(engineVersion, compatibility)
        .Concat(new AbsolutePath[]
        {
            Unreal.GetInstance(engineVersion, compatibility).Location / Programs / "UnrealBuildTool"
        })
        .ToArray();

    protected override ToolModel GetToolModelForEngine(string engineVersion, UnrealCompatibility compatibility)
    {
        var tool = base.GetToolModelForEngine(engineVersion, compatibility);
        if (tool != null) return tool;

        var gatherer = new UbtGathering(GetRoots(engineVersion, compatibility));
        var context = new UbtGeneratorContext
        {
            Compatibility = compatibility,
            MainTool = new ToolModel
            {
                ConfigName = "Ubt",
                CliName = "",
                ConfigType = new(TemplateName.Replace("Generated", ""), TemplateName),
                ClassKeywords = "abstract",
                Compatibility = new() { compatibility }
            }.AddSummary("Unreal Build Tool defines the Unreal project structure and provides unified source building utilities over multiple platforms")
        };

        gatherer.Gather(context);
        context.MainTool.Subtools.AddRange(context.SubTools);
        return context.MainTool;
    }
}