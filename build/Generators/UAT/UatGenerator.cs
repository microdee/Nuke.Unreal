using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Nuke.Common.IO;

namespace build.Generators.UAT;

public class UatGeneratorContext
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

public class UatGenerator : GeneratorFromSource
{
    public override string TemplateName => "UatConfigGenerated";
    
    private record UatModel(ToolModel Uat);


    protected override object GetFullModel(ToolModel tool) => new UatModel(tool);
    protected override AbsolutePath[] GetRoots(string engineVersion, UnrealCompatibility compatibility) =>
        new []
        {
            Unreal.GetInstance(engineVersion, compatibility).Location / Programs / "AutomationTool"
        };

    protected override ToolModel GetToolModelForEngine(string engineVersion, UnrealCompatibility compatibility)
    {
        var tool = base.GetToolModelForEngine(engineVersion, compatibility);
        if (tool != null) return tool;

        var gatherer = new UatGathering(GetRoots(engineVersion, compatibility));
        var context = new UatGeneratorContext
        {
            Compatibility = compatibility,
            MainTool = new ToolModel
            {
                ConfigName = "Uat",
                CliName = "",
                ConfigType = new(TemplateName.Replace("Generated", ""), TemplateName),
                ClassKeywords = "abstract",
                Compatibility = new() { compatibility }
            }.AddSummary("Unreal Automation Tool is a vast collection of scripts solving all aspects of deploying a program made in Unreal Engine")
        };

        gatherer.Gather(context);
        context.MainTool.Subtools.AddRange(context.SubTools);
        return context.MainTool;
    }
}