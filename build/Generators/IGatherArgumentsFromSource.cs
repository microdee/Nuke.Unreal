using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis;

namespace build.Generators;
public interface IGatherArgumentsFromSource
{
    void Gather(ToolModel mainTool, SyntaxTree source, IGatheringContext context);
}