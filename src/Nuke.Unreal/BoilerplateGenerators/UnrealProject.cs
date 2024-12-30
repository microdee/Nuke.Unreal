using System;
using Nuke.Common.IO;

namespace Nuke.Unreal.BoilerplateGenerators
{
    public class UnrealProject : UnrealSourceUnit
    {
        public UnrealProject(
            AbsolutePath currentFolder,
            string? throwIfNotFound = null
        ) : base(currentFolder, throwIfNotFound) {}

        public UnrealProject(UnrealBuild build) : base(
            build.ProjectFolder,
            "Project folder couldn't be determined from build class"
        ) {}

        protected override bool FilePredicate(AbsolutePath f) => f.Name.EndsWith(".uproject", true, null);
    }
}