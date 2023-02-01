using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace build.Generators;
public interface IGatherArgumentsFromAssembly
{
    void Gather(ToolModel mainTool, Assembly assembly, IGatheringContext context);
}