using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Nuke.Common.Utilities;

namespace build.Generators;
public static class AnalysisCommon
{
    public static bool MemberAssociable(this string a, string b)
    {
        return a.EqualsOrdinalIgnoreCase(b)
            || a.TrimStart("b").EqualsOrdinalIgnoreCase(b);
    }

    public static string GetMemberName(this MemberDeclarationSyntax member) => member switch
    {
        PropertyDeclarationSyntax prop => prop.Identifier.Text,
        FieldDeclarationSyntax field => field
            .DescendantNodes()
            .OfType<VariableDeclaratorSyntax>()
            .FirstOrDefault()
            ?.Identifier.Text,
        _ => null
    };

    public static TypeSyntax GetMemberType(this MemberDeclarationSyntax member) => member switch
    {
        PropertyDeclarationSyntax prop => prop.Type,
        FieldDeclarationSyntax field => field
            .ChildNodes()
            .OfType<VariableDeclarationSyntax>()
            .SelectMany(v => v
                .ChildNodes()
                .OfType<TypeSyntax>()
            )
            .FirstOrDefault(),
        _ => null
    };

    public static string GetRootName(this TypeSyntax type) => type switch
    {
        ArrayTypeSyntax array => array.ElementType.GetRootName(),
        NullableTypeSyntax nullable => nullable.ElementType.GetRootName(),
        GenericNameSyntax generic => generic.Identifier.Text,
        PredefinedTypeSyntax predefined => predefined.Keyword.Text,
        SimpleNameSyntax regular => regular.Identifier.Text,
        _ => type.ToString()
    };

    public static bool IsScalarType(this TypeSyntax type) => type switch
    {
        NullableTypeSyntax nullable => nullable.ElementType.IsScalarType(),
        PredefinedTypeSyntax predefined => 
            new [] {
                "short",
                "int",
                "long",
                "ushort",
                "uint",
                "ulong",
                "float",
                "double",
                "decimal"
            }.Any(t => t == predefined.Keyword.Text),
        _ => false
    };

    public static IEnumerable<string> GetLiteralStringValues(this IEnumerable<AttributeArgumentSyntax> args) => args
            .SelectMany(a => a
                .DescendantNodes()
                .OfType<LiteralExpressionSyntax>()
                .Where(l => l.IsKind(SyntaxKind.StringLiteralExpression))
            )
            .Select(l => l.Token.ValueText);

    public static string GetNamedAttributeArgument(this AttributeSyntax attr, string key) =>
        attr?.ArgumentList?.Arguments
            .Where(a => a
                .DescendantNodes()
                .OfType<NameEqualsSyntax>()
                .Any(n => n.Name.ToString() == key)
            )
            .GetLiteralStringValues()
            ?.FirstOrDefault();

    public static IEnumerable<string> GetImplicitAttributeArguments(this AttributeSyntax attr) =>
        attr?.ArgumentList?.Arguments
            .Where(a => a
                .ChildNodes().Count() == 1
            )
            .GetLiteralStringValues();

    public static string GetLeadingXmlDocs(this CSharpSyntaxNode node)
    {
        string documentation = null;
        if (node == null) return documentation;
        
        SyntaxNode actualNode = node;
        if (!node.HasStructuredTrivia)
        {
            var attributes = node
                .ChildNodes()
                .OfType<AttributeListSyntax>()
                .SelectMany(a => a.DescendantNodesAndSelf());

            actualNode = attributes.FirstOrDefault(a => a.HasStructuredTrivia) ?? node;
        }

        if (actualNode.HasStructuredTrivia)
        {
            var doscSpan = actualNode.GetLeadingTrivia()
                .Where(t =>
                    t.IsKind(SyntaxKind.SingleLineDocumentationCommentTrivia)
                    || t.IsKind(SyntaxKind.MultiLineDocumentationCommentTrivia)
                )
                .FirstOrDefault()
                .FullSpan;

            documentation = actualNode.SyntaxTree
                .GetText().GetSubText(doscSpan).ToString()
                .Replace("///", "")
                .Trim();

            // Of course we have instances of malformed XML docs in UAT
            if (documentation.ContainsOrdinalIgnoreCase("<summary>") && !documentation.ContainsOrdinalIgnoreCase("</summary>"))
            {
                documentation += "</summary>";
            }
            if (!documentation.ContainsOrdinalIgnoreCase("<summary>") && documentation.ContainsOrdinalIgnoreCase("</summary>"))
            {
                documentation = "<summary>" + documentation;
            }
            if (!documentation.StartsWith("<") && !documentation.EndsWith(">"))
            {
                documentation = "<summary>" + SecurityElement.Escape(documentation) + "</summary>";
            }
        }
        return documentation == null ? null : string.Join(
            Environment.NewLine,
            documentation
                .Split(Environment.NewLine)
                .Select(s => s.Trim())
        );
    }
}