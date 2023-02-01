using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis.CSharp;

/*
TODO:
    * Gather BuildCommand classes
        * Check all class inheritance hierarchy until we're getting to BuildCommand
            * Classes without inheritance can be ignored automatically
        * associate source files
        * merge together partial classes (via adding to source file association)
    * Gather args via 'CommandHelp' attribute (Help<string, string>) and organize into classes
    * Gather args via UatCommandLineArgumentParserPass and organize into classes
    * infer if BuildCommand is Shared or Real
        * by the presence of a 'SummaryHelp' attribute (Help<string>) (no)
        * by the fact that it's not referred by any other build? (nah)
        * just don't care and have every BuildCommand? (probably)
            * ignore BuildCommands from AutomationUtils
            * ignore partial Project declarations
    * Make subtools for Real BuildCommands
    * Add warning to docs when [RequireP4] is present
    * Import arguments of referred Shared BuildCommands into subtools based on ImportCommandHelp attribute (Help<Type>)
*/
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