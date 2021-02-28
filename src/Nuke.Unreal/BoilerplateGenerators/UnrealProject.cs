using System;
using Nuke.Common.IO;

namespace Nuke.Unreal.BoilerplateGenerators
{
    public class UnrealProject : UnrealSourceUnit
    {
        public UnrealProject(AbsolutePath currentFolder, string throwIfNotFound = null) : base(currentFolder, throwIfNotFound)
        {
        }

        protected override bool FilePredicate(string f) =>
            f.EndsWith(".uproject", StringComparison.InvariantCultureIgnoreCase);
    }
}