using System;
using Nuke.Common.IO;

namespace Nuke.Unreal.BoilerplateGenerators
{
    public class UnrealPlugin : UnrealSourceUnit
    {
        public UnrealPlugin(AbsolutePath currentFolder, string throwIfNotFound = null) : base(currentFolder, throwIfNotFound)
        {
        }

        protected override bool FilePredicate(string f) =>
            f.EndsWith(".uplugin", StringComparison.InvariantCultureIgnoreCase);
    }
}