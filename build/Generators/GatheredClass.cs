using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace build.Generators;

public class GatheredClass : IProvideArguments
{
    public GatheredClass(ClassDeclarationSyntax sourceClass)
    {
        Class = new(
            new HashSet<ClassDeclarationSyntax>() { sourceClass }, null
        );
    }

    public readonly CSharpClass Class;
    public HashSet<CSharpClass> CommandComponents { get; } = new();
    public List<ArgumentModel> Arguments { get; set; } = new();
    public readonly ToolModel ToolCandidate;
}