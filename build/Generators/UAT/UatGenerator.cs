using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using build.Generators.UAT;
using Microsoft.CodeAnalysis.CSharp;
namespace build.Generators;

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

public class UatGenerator : ToolGenerator
{
    public override string TemplateName => "UatConfigGenerated";
    
    private record UatModel(ToolModel Uat);


    protected override object GetFullModel(ToolModel tool) => new UatModel(tool);

    private readonly Dictionary<string, ToolModel> _modelCahce = new();
    protected override ToolModel GetToolModelForEngine(string engineVersion, UnrealCompatibility compatibility)
    {
        if (_modelCahce.TryGetValue(engineVersion, out var tool))
        {
            return tool;
        }

        var uatRoot = Unreal.GetInstance(engineVersion, compatibility).Location / "Engine" / "Source" / "Programs" / "AutomationTool";
        var gatherer = new UatGathering(uatRoot);
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