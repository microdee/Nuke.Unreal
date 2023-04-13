using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Nuke.Common.Utilities.Collections;

namespace build.Generators;
public partial class UatCommandHelpHeuristicssPass
{
    [GeneratedRegex(@"(?<NAME>[\w-]+)((?<SETTER>[:=]).*)?")]
    private static partial Regex ArgumentFromHelp();
    
    public void Gather(ClassDeclarationSyntax sourceClass, IGatheringContext context)
    {
        var commandHelpAttributes = sourceClass
            .DescendantNodes()
            .OfType<AttributeSyntax>()
            .Where(a => a.Name.ToString() == "Help")
            .Where(a => a
                .DescendantNodes()
                .OfType<AttributeArgumentSyntax>()
                .Count() == 2
            );
        
        foreach(var attr in commandHelpAttributes)
        {
            var arguments = attr
                .DescendantNodes()
                .OfType<AttributeArgumentSyntax>()
                .SelectMany(a => a
                    .DescendantNodes(l => l.IsKind(SyntaxKind.StringLiteralExpression))
                    .Cast<LiteralExpressionSyntax>()
                )
                .ToArray();
            if (arguments.Length != 2) continue;

            var regexMatch = ArgumentFromHelp().Match(arguments[0].Token.Text);
            if (regexMatch?.Groups?["NAME"] == null) continue;

            if (context is IHaveTargetClass contextWithTargetClass)
            {
                var argument = new ArgumentModel()
                {
                    CliName = regexMatch.Groups["NAME"].Value,
                    ConfigName = regexMatch.Groups["NAME"].Value.EnsureIdentifierCompatibleName(),
                    ArgumentType = ArgumentModelType.TextCollection,
                    ValueSetter = regexMatch.Groups["SETTER"]?.Value ?? "="
                }.AddSummary(arguments[1].Token.Text);
                contextWithTargetClass.TargetClass.AddArgument(argument);
            }
        }
    }
}