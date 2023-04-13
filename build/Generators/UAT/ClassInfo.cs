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
    public readonly HashSet<CsClass> Declarations;
    public ClassInfo BaseClass;

    public ClassInfo Implements(string baseType)
    {
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
}