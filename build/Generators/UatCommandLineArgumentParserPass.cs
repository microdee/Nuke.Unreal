using System;
using Serilog;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Nuke.Common.Utilities;
using Nuke.Common.Utilities.Collections;
using Towel;

namespace build.Generators;

public partial class UatCommandLineArgumentParserPass : IGatherArgumentsFromSource
{
    [GeneratedRegex(@"(Parse|Get)(Optional)?Param")]
    private static partial Regex ParamGetterInvocationRegex();

    public void Gather(ToolModel mainTool, SyntaxTree source, IGatheringContext context)
    {
        var paramGetterInvocations = source.GetCompilationUnitRoot()
            .DescendantNodes().OfType<InvocationExpressionSyntax>()
            .Where(n => ParamGetterInvocationRegex().IsMatch(n
                .DescendantNodes()
                .OfType<IdentifierNameSyntax>()
                .First()
                .Identifier.Text
            ));
        foreach(var invocation in paramGetterInvocations)
        {
            var cliName = invocation.DescendantNodes()
                .OfType<LiteralExpressionSyntax>()
                .Where(n => n.IsKind(SyntaxKind.StringLiteralExpression))
                .FirstOrDefault()
                ?.Token.Text?.TrimMatchingDoubleQuotes();
            
            if (string.IsNullOrWhiteSpace(cliName))
                continue;
            
            var csharpName = invocation.DescendantNodes()
                .OfType<ArgumentSyntax>()
                .Select(n => n
                    .DescendantNodes()
                    .OfType<IdentifierNameSyntax>()
                    .FirstOrDefault()
                )
                .Where(n => n != null)
                .Select(n => n.GetText().ToString())
                .Where(n => n.EqualsOrdinalIgnoreCase(cliName))
                .FirstOrDefault(cliName)
                .EnsureIdentifierCompatibleName();
                
            var indentation = "  ".Repeat((context as IHaveLogDisplayInfo)?.Indentation ?? 1);
            Log.Information(indentation + "{0} {1}", cliName, csharpName);

            var parentClass = invocation.Ancestors()
                .OfType<ClassDeclarationSyntax>()
                .FirstOrDefault();

            var documentation = "";
            
            if (parentClass != null)
            {
                var propertyCandidate = parentClass.Members
                    .OfType<PropertyDeclarationSyntax>()
                    .Where(n => n.Identifier.Text.EqualsOrdinalIgnoreCase(csharpName))
                    .FirstOrDefault();
                
                if (propertyCandidate?.HasStructuredTrivia ?? false)
                {
                    documentation = propertyCandidate.GetLeadingTrivia()
                        .Where(t => t.IsKind(SyntaxKind.SingleLineDocumentationCommentTrivia))
                        .FirstOrDefault().FullSpan.ToString();
                    
                }
            }
            
            mainTool.AddArgument(
                new() {
                    ConfigName = csharpName,
                    CliName = "-" + cliName,
                    ArgumentType = ArgumentModelType.TextCollection,
                    DocsXml = documentation
                },
                (context as IHaveSubTools)?.SubTools ?? Array.Empty<ToolModel>()
            );
        }
    }
}