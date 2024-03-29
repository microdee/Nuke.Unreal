using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Serilog;

namespace build.Generators;

public class ClassInfo : IProvideArguments
{
    public string Name { init; get; }
    public bool IsPartial { init; get; }
    public readonly HashSet<CsClass> Declarations = new();
    public ClassInfo BaseClass;

    public ClassInfo Implements(string baseType, List<ClassInfo> chain = null)
    {
        if (BaseClass == null) return null;
        if (BaseClass.Name == baseType) return BaseClass;

        chain ??= new();
        var candidate = chain.FirstOrDefault(c => c.Name == baseType);
        if (candidate != null) return candidate;
        if (chain.Any(c => c.Name == Name))
        {
            Log.Verbose("Self referencing inheritance chain: {0}", string.Join(" -> ", chain.Select(c => c.Name)));
            return null;
        }
        chain.Add(this);

        return BaseClass?.Implements(baseType, chain);
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