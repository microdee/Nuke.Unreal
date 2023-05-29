using System;
using Nuke.Common.IO;

namespace Nuke.Unreal.BoilerplateGenerators
{
    public class UnrealProject : UnrealSourceUnit
    {
        public UnrealProject(AbsolutePath currentFolder, string throwIfNotFound = null) : base(currentFolder, throwIfNotFound)
        {
        }

        protected override bool FilePredicate(AbsolutePath f) => f.Name.EndsWith(".uproject", true, null);
    }
}