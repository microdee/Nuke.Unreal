using System;
using Nuke.Common.IO;

namespace Nuke.Unreal.BoilerplateGenerators
{
    public class UnrealModule : UnrealSourceUnit
    {
        public UnrealModule(AbsolutePath currentFolder, string throwIfNotFound = null) : base(currentFolder, throwIfNotFound)
        {
        }

        protected override bool FilePredicate(string f) =>
            f.EndsWith(".build.cs", StringComparison.InvariantCultureIgnoreCase);
    }
}