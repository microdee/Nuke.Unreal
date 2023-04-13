using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace build.Generators.UAT;

public class ToolCandidate
{
    public ClassInfo MainClass;
    
    /// <summary>
    /// From inheritance, Help imports, Class member command components
    /// </summary>
    public readonly HashSet<ClassInfo> AuxArgumentSources = new();
}