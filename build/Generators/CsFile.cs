using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Nuke.Common.IO;
using Nuke.Common.Utilities.Collections;

namespace build.Generators;

public record CsFile(AbsolutePath Path)
{
    private List<CsClass> _classes;
    public List<CsClass> Classes => _classes ??= Ast.GetCompilationUnitRoot()
        .DescendantNodes()
        .OfType<ClassDeclarationSyntax>()
        .Select(c => new CsClass(c))
        .ToList();

    private List<EnumDeclarationSyntax> _enums;
    public List<EnumDeclarationSyntax> Enums => _enums ??= Ast.GetCompilationUnitRoot()
        .DescendantNodes()
        .OfType<EnumDeclarationSyntax>()
        .ToList();

    private SyntaxTree _ast;
    public SyntaxTree Ast => _ast ??= CSharpSyntaxTree.ParseText(File.ReadAllText(Path));
}