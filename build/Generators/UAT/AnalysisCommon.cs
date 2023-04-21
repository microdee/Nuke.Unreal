using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Nuke.Common.Utilities;

namespace build.Generators.UAT;
public static class AnalysisCommon
{
    public static bool MemberAssociable(this string a, string b)
    {
        return a.EqualsOrdinalIgnoreCase(b)
            || a.TrimStart("b").EqualsOrdinalIgnoreCase(b);
    }

    public static string GetFieldOrPropertyName(this MemberDeclarationSyntax member) => member switch
    {
        PropertyDeclarationSyntax prop => prop.Identifier.Text,
        FieldDeclarationSyntax field => field
            .DescendantNodes()
            .OfType<VariableDeclaratorSyntax>()
            .FirstOrDefault()
            ?.Identifier.Text,
        _ => null
    };

    public static string GetLeadingXmlDocs(this MemberDeclarationSyntax node)
    {
        string documentation = "";
        if (node?.HasStructuredTrivia ?? false)
        {
            var doscSpan = node.GetLeadingTrivia()
                .Where(t =>
                    t.IsKind(SyntaxKind.SingleLineDocumentationCommentTrivia)
                    || t.IsKind(SyntaxKind.MultiLineDocumentationCommentTrivia)
                )
                .FirstOrDefault()
                .FullSpan;

            documentation = node.SyntaxTree
                .GetText().GetSubText(doscSpan).ToString()
                .Replace("///", "")
                .Trim();

            // Of course we have instances of malformed XML docs in UAT
            if (documentation.StartsWithOrdinalIgnoreCase("<summary>") && !documentation.EndsWithOrdinalIgnoreCase("</summary>"))
            {
                documentation += "</summary>";
            }
            if (!documentation.StartsWithOrdinalIgnoreCase("<summary>") && documentation.EndsWithOrdinalIgnoreCase("</summary>"))
            {
                documentation = "<summary>" + documentation;
            }
            if (!documentation.StartsWith("<") && !documentation.EndsWith(">"))
            {
                documentation = "<summary>" + SecurityElement.Escape(documentation) + "</summary>";
            }
        }
        return documentation;
    }
}