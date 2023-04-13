using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
}