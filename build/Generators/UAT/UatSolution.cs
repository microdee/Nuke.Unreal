using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Build.Construction;
using Nuke.Common.IO;
using Nuke.Common.Tools.MSBuild;

namespace build.Generators.UAT;

public class UatSolution
{
    public readonly List<CsFile> Files;
    public readonly AbsolutePath UatRoot;

    public UatSolution(AbsolutePath automationToolRoot)
    {
        UatRoot = automationToolRoot;

        Files = automationToolRoot
            .GlobFilesRecursive("*.cs")
            .Where(f => !f.ToString().Contains("\\obj\\"))
            .Select(f => new CsFile(f))
            .ToList();
    }
}