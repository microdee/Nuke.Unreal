using System;
using Serilog;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Nuke.Common.IO;
using Nuke.Common.Utilities;
using Nuke.Common.Utilities.Collections;

namespace build.Generators;

public abstract class CSharpSourceGatherer
{
    protected readonly List<CsFile> Files;
    protected readonly AbsolutePath Root;
    protected readonly Dictionary<string, ClassInfo> Classes = new();
    
    public CSharpSourceGatherer(AbsolutePath root)
    {
        Root = root;

        Files = root
            .GlobFilesRecursive("*.cs")
            .Where(f => !f.ToString().Contains("\\obj\\"))
            .Select(f => new CsFile(f))
            .ToList();
    }

    protected void GatherClasses(IGatheringContext context)
    {
        context.IncreaseIndent();
        Dictionary<string, string> baseClassRequests = new();
        foreach(var csClass in Files.SelectMany(f => f.Classes))
        {
            Log.Debug(context.Indent() + "Gathered class: {0}", csClass.Name);
            if (!Classes.TryGetValue(csClass.Name, out var classInfo))
            {
                classInfo = new() {
                    Name = csClass.Name,
                    IsPartial = csClass.IsPartial
                };
                Classes.Add(csClass.Name, classInfo);
            }
            classInfo.Declarations.Add(csClass);
            if (!string.IsNullOrWhiteSpace(csClass.BaseClass))
            {
                baseClassRequests.TryAdd(classInfo.Name, csClass.BaseClass);
            }
        }
        foreach(var (targetClassName, baseClassName) in baseClassRequests)
        {
            if (Classes.TryGetValue(targetClassName, out var targetClass) && Classes.TryGetValue(baseClassName, out var baseClass))
            {
                Log.Debug(context.Indent() + "Inheritance: {0}: {1}", targetClassName, baseClassName);
                targetClass.BaseClass = baseClass;
            }
        }
        context.DecreaseIndent();
    }
}