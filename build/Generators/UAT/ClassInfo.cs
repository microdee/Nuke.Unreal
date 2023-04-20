using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace build.Generators.UAT;

public class ClassInfo : IProvideArguments
{
    public string Name { init; get; }
    public bool IsPartial { init; get; }
    public readonly HashSet<CsClass> Declarations = new();
    public ClassInfo BaseClass;

    public ClassInfo Implements(string baseType)
    {
        if (BaseClass == null) return null;
        
        if (BaseClass.Name.Equals(baseType))
        {
            return BaseClass;
        }
        return BaseClass?.Implements(baseType);
    }
    
    public List<ArgumentModel> Arguments { get; set; } = new();

    public IEnumerable<AttributeSyntax> HelpAttributes => Declarations
        .SelectMany(d => d.Declaration
            .DescendantNodes()
            .OfType<AttributeSyntax>()
        )
        .Where(a => a.Name.ToString() == "Help");

    private bool? _requireP4 = null;
    public bool RequireP4 => _requireP4 ??= Declarations 
        .SelectMany(d => d.Declaration
            .DescendantNodes()
            .OfType<AttributeSyntax>()
        )
        .Any(a => a.Name.ToString() == "RequireP4");

    public IEnumerable<MemberDeclarationSyntax> PropertiesAndFields => Declarations.SelectMany(d => d.PropertiesAndFields);
    public bool IsAbstract => Declarations.Any(d => d.IsAbstract);
}