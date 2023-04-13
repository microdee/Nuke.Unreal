using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace build.Generators.UAT;
public record CsClass(ClassDeclarationSyntax Declaration)
{
    private string _name;
    public string Name => _name ??= Declaration.Identifier.Text;

    private bool? _isPartial;
    public bool IsPartial => _isPartial ??= Declaration
        .DescendantNodesAndTokens()
        .OfType<SyntaxToken>()
        .Any(t => t.IsKind(SyntaxKind.PartialKeyword));

    public bool? _hasBase = null;
    public bool HasBase => _hasBase ??= Declaration
        .DescendantNodes()
        .Any(s => s is SimpleBaseTypeSyntax);

    private string _baseClass;
    public string BaseClass => !HasBase ? null : _baseClass ??= Declaration
        .DescendantNodes()
        .OfType<SimpleBaseTypeSyntax>()
        .SelectMany(s => s
            .DescendantNodes()
            .OfType<IdentifierNameSyntax>()
        )
        .Select(s => s.GetText().ToString())
        .FirstOrDefault();

    public IEnumerable<MemberDeclarationSyntax> PropertiesAndFields => Declaration.Members
        .OfType<PropertyDeclarationSyntax>()
        .Cast<MemberDeclarationSyntax>()
        .Concat(
            Declaration.Members
                .OfType<FieldDeclarationSyntax>()
                .Cast<MemberDeclarationSyntax>()
        );
}