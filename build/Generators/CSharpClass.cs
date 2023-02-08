using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Nuke.Common.IO;

namespace build.Generators;

public record CSharpClass(
    HashSet<ClassDeclarationSyntax> Declarations,
    CSharpClass BaseClass = null
) {
    public IEnumerable<AbsolutePath> AssociatedFiles => Declarations
        .Select(c => c.SyntaxTree.FilePath)
        .Cast<AbsolutePath>();

    public bool HasBase(string baseClassIdentifier)
    {
        if (Declarations.FirstOrDefault().Identifier.Text == baseClassIdentifier)
            return true;

        if (BaseClass == null)
            return false;

        return BaseClass.HasBase(baseClassIdentifier);
    }

    public bool IsBuildCommand() => HasBase("BuildCommand");
}