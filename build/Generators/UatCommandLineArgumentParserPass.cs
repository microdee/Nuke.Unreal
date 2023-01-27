using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace build.Generators;

public class UatCommandLineArgumentParserPass : IGatherArgumentsFromSource
{
    public void Gather(ToolModel mainTool, SyntaxTree source)
    {
    }
}