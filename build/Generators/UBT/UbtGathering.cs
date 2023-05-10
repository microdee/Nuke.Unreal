using System;
using Serilog;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using Nuke.Common.IO;
using Nuke.Common.Utilities;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Nuke.Common.Utilities.Collections;
using Towel;
using System.Security;

namespace build.Generators.UBT;

/*
    Classes are considered where
        - class is decorated with ToolModeAttribute
        - special cases

    Special cases:
        GlobalOptions
*/

public static class UniqueClass
{
    public const string ToolMode = nameof(ToolMode);
    public const string GlobalOptions = nameof(GlobalOptions);

    public static readonly List<string> SpeciallyConsideredClasses = new()
    {
        GlobalOptions,
    };
}

public class UbtGathering : CSharpSourceGatherer
{
    public UbtGathering(AbsolutePath root) : base(root) {}

    protected bool IsConsidered(ClassInfo classInfo) => !classInfo.IsAbstract
        && (
            classInfo.Implements(UniqueClass.ToolMode) != null
            || UniqueClass.SpeciallyConsideredClasses.Any(specClass => classInfo.Name == specClass)
        );

    protected void GatherFromCommandLineAttributes(ClassInfo from, IGatheringContext context)
    {
        var compatibility = (context as IHaveEngineCompatibility)?.Compatibility ?? UnrealCompatibility.All;
        var consideredMembers = from.PropertiesAndFields
            .Where(m => m.AttributeLists
                .SelectMany(a => a.Attributes)
                .Any(a => a.Name.ToString() == "CommandLine")
            );
        // TBC...
    }

    protected ToolModel CreateSubtool(ClassInfo from, IGatheringContext context)
    {
        var compatibility = (context as IHaveEngineCompatibility)?.Compatibility ?? UnrealCompatibility.All;
        var toolModeCliName = from.Declarations
            .SelectMany(d => d.Declaration
                .DescendantNodes()
                .OfType<AttributeSyntax>()
            )
            .Where(a => a.Name.ToString() == "ToolMode")
            .SelectMany(a => a
                .DescendantNodes()
                .Where(l => l.IsKind(SyntaxKind.StringLiteralExpression))
                .Cast<LiteralExpressionSyntax>()
            )
            .Select(s => s.Token.Text)
            .Where(s => !string.IsNullOrWhiteSpace(s))
            .Select(s => s.TrimMatchingDoubleQuotes())
            .FirstOrDefault();

        var csharpName = toolModeCliName?.EnsureIdentifierCompatibleName() ?? from.Name;
        var outCsharpName = csharpName.Replace("UE4", "Unreal");
        var docs = from.Declarations
            .Select(c => c.Declaration.GetLeadingXmlDocs())
            .Where(d => !string.IsNullOrWhiteSpace(d));

        var tool = new ToolModel {
            ConfigName = outCsharpName,
            ConfigType = new(outCsharpName + "Config", outCsharpName + "Config"),
            CliName = toolModeCliName == null ? "" : "-" + toolModeCliName,
            Compatibility = new() { compatibility }
        };

        if (!docs.IsEmpty())
        {
            tool.AddSummary(string.Join('\n', docs));
        }

        return tool;
    }
}