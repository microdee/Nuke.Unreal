using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace build.Generators;
public interface IGatherArgumentsFromClass
{
    void Gather(ClassDeclarationSyntax sourceClass, IGatheringContext context);
}