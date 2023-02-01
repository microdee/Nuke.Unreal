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

file static class UatCommandLineArgumentParserPassUtils
{
    public static bool MemberAssociable(this string a, string b)
    {
        return a.EqualsOrdinalIgnoreCase(b)
        || a.TrimStart("b").EqualsOrdinalIgnoreCase(b);
    }
}

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
                .Select(n => n.Token.Text)
                .Where(n => !string.IsNullOrWhiteSpace(n))
                .FirstOrDefault()
                ?.TrimMatchingDoubleQuotes();
            
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
                .Where(n => n.MemberAssociable(cliName))
                .FirstOrDefault(cliName)
                .EnsureIdentifierCompatibleName();
                
            var indentation = "  ".Repeat((context as IHaveLogDisplayInfo)?.Indentation ?? 1);

            var parentClass = invocation.Ancestors()
                .OfType<ClassDeclarationSyntax>()
                .FirstOrDefault();

            var documentation = "";
            
            if (parentClass != null)
            {
                var propertyCandidates = parentClass.Members
                    .OfType<PropertyDeclarationSyntax>()
                    .Where(n => n.Identifier.Text.MemberAssociable(csharpName))
                    .Cast<MemberDeclarationSyntax>();
                
                var fieldCandidates = parentClass.Members
                    .OfType<FieldDeclarationSyntax>()
                    .Where(n => n
                        .DescendantNodes()
                        .OfType<VariableDeclaratorSyntax>()
                        .FirstOrDefault()
                        ?.Identifier.Text.MemberAssociable(csharpName) ?? false
                    )
                    .Cast<MemberDeclarationSyntax>();

                var memberCandidate = propertyCandidates.Concat(fieldCandidates).FirstOrDefault();
                
                if (memberCandidate?.HasStructuredTrivia ?? false)
                {
                    var doscSpan = memberCandidate.GetLeadingTrivia()
                        .Where(t =>
                            t.IsKind(SyntaxKind.SingleLineDocumentationCommentTrivia)
                            || t.IsKind(SyntaxKind.MultiLineDocumentationCommentTrivia)
                        )
                        .FirstOrDefault()
                        .FullSpan;

                    documentation = source.GetText().GetSubText(doscSpan)
                        .ToString()
                        .Trim()
                        .Replace("///", "")
                        .DocsXmlComment();
                    
                    // TODO: Make documentation more modular + add source line info
                    // Log.Information(documentation);
                }
            }
            
            if (mainTool.AddArgument(
                new() {
                    ConfigName = csharpName,
                    CliName = "-" + cliName,
                    ArgumentType = ArgumentModelType.TextCollection,
                    DocsXml = documentation
                },
                (context as IHaveSubTools)?.SubTools ?? Array.Empty<ToolModel>()
            ))
            {
                Log.Information(indentation + "{0} {1}", cliName, csharpName);
            }
        }
    }
}