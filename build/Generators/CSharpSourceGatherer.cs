using System;
using Serilog;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Nuke.Common.IO;
using Nuke.Common.Utilities;
using Nuke.Common.Utilities.Collections;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace build.Generators;

public abstract class CSharpSourceGatherer
{
    protected readonly List<CsFile> Files;
    protected readonly AbsolutePath[] Roots;
    protected readonly Dictionary<string, ClassInfo> Classes = new();
    protected readonly Dictionary<string, EnumDeclarationSyntax> Enums = new();
    
    public CSharpSourceGatherer(params AbsolutePath[] roots)
    {
        Roots = roots;

        Files = roots.SelectMany(r => r
            .GlobFilesRecursive("*.cs")
            .Where(f => !f.ToString().Contains("\\obj\\"))
            .Select(f => new CsFile(f))
        )
        .ToList();
    }

    protected void GatherClasses(IGatheringContext context)
    {
        using var indent = new Indentation(context);
        Dictionary<string, string> baseClassRequests = new();
        foreach (var csClass in Files.SelectMany(f => f.Classes))
        {
            Log.Verbose(indent >> "Gathered class: {0}", csClass.Name);
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
        foreach (var (targetClassName, baseClassName) in baseClassRequests)
        {
            if (Classes.TryGetValue(targetClassName, out var targetClass) && Classes.TryGetValue(baseClassName, out var baseClass))
            {
                Log.Verbose(indent >> "Inheritance: {0}: {1}", targetClassName, baseClassName);
                targetClass.BaseClass = baseClass;
            }
        }
    }

    protected void GatherEnums(IGatheringContext context)
    {
        using var indent = new Indentation(context);
        foreach (var csEnum in Files.SelectMany(f => f.Enums))
        {
            if (Enums.TryAdd(csEnum.Identifier.Text, csEnum))
            {
                Log.Verbose(indent >> "Gathered class: {0}", csEnum.Identifier.Text);
            }
        }
    }
}