using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis.CSharp;

namespace build.Generators;

public class UnrealAutomationToolGenerator : ToolGenerator
{
    public override string TemplateName => "UnrealAutomationToolConfigGenerated";

    protected override object Model => throw new NotImplementedException();

    public void Test()
    {
        var testFile = @"D:\UE\src\Engine\Source\Programs\AutomationTool\AutomationUtils\ProjectParams.cs";
        var syntaxTree = CSharpSyntaxTree.ParseText(File.ReadAllText(testFile));
        var toolModel = new ToolModel
        {
            ConfigName = "UnrealAutomationTool",
            CliName = "UnrealAutomationTool",
            ConfigType = new(TemplateName.Replace("Generated", ""), TemplateName),
            ClassKeywords = "abstract",
            DocsXml = """
            /// <summary>
            /// Unreal Automation Tool is a vast collection of scripts solving all aspects
            /// of deploying a program made in Unreal Engine
            /// </summary>
            """
        };
        var testPass = new UatCommandLineArgumentParserPass();
        testPass.Gather(toolModel, syntaxTree, null);
    }
}