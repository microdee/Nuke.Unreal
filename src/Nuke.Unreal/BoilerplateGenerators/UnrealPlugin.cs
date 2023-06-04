using System;
using Nuke.Common.IO;

namespace Nuke.Unreal.BoilerplateGenerators
{
    public class UnrealPlugin : UnrealSourceUnit
    {
        public UnrealPlugin(AbsolutePath currentFolder, string throwIfNotFound = null) : base(currentFolder, throwIfNotFound)
        {
        }

        protected override bool FilePredicate(AbsolutePath f) => f.Name.EndsWith(".uplugin", true, null);
    }
}