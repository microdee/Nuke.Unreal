using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis.CSharp;

/*
TODO:
    * Gather all classes 
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

    * IMPORTANT: Add metadata for tools where 'UE4' became 'Unreal' and make a mechanism to know which one to use
        * in Nuke C# programs expose Unreal only, decide based on version.
        * will do command line transformation at invocation
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
            ClassKeywords = "abstract"
        }.AddSummary("Unreal Automation Tool is a vast collection of scripts solving all aspects of deploying a program made in Unreal Engine");
        // testPass.Gather(toolModel, syntaxTree, null);
    }
}