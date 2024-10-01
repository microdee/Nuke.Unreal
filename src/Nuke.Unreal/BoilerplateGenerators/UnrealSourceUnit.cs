using System.Linq;
using System;
using System.IO;
using Nuke.Common.IO;

namespace Nuke.Unreal.BoilerplateGenerators
{
    public abstract class UnrealSourceUnit
    {
        public readonly AbsolutePath? Folder;
        public readonly string? Name;

        public readonly bool IsValid = false;

        public UnrealSourceUnit(AbsolutePath currentFolder, string? throwIfNotFound = null)
        {
            Folder = currentFolder.FindParentOrSelf(d => d.GetFiles().Any(f => FilePredicate(f)));
            if(throwIfNotFound != null && Folder == null)
            {
                IsValid = false;
                throw new InvalidOperationException(throwIfNotFound);
            }
            if(Folder == null)
            {
                IsValid = false;
                return;
            }
            var unitFile = Folder.GlobFiles("*")
                .Where(FilePredicate)
                .Select(f => f.Name)
                .First(); // it should fail when despite our efforts before it didn't find the module file anyway

            Name = GetNameFromFileName(unitFile);
            IsValid = true;
        }

        protected abstract bool FilePredicate(AbsolutePath f);
        protected virtual string GetNameFromFileName(string f) => f.Split('.').First();
    }
}