using System.Linq;
using System;
using System.IO;
using Nuke.Common.IO;

namespace Nuke.Unreal.BoilerplateGenerators
{
    public abstract class UnrealSourceUnit
    {
        public readonly string Folder;
        public readonly string Name;

        public UnrealSourceUnit(AbsolutePath currentFolder, string throwIfNotFound = null)
        {
            Folder = FileSystemTasks.FindParentDirectory(
                currentFolder,
                d => d.GetFiles().Any(f => FilePredicate(f.FullName))
            );
            if(throwIfNotFound != null && Folder == null)
            {
                throw new InvalidOperationException(throwIfNotFound);
            }
            var unitFile = Directory.EnumerateFiles(Folder)
                .Where(FilePredicate)
                .Select(f => Path.GetFileName(f))
                .First(); // it should fail when despite our efforts before it didn't find the module file anyway

            Name = GetNameFromFileName(unitFile);
        }

        protected abstract bool FilePredicate(string f);
        protected virtual string GetNameFromFileName(string f) => f.Split('.').First();
    }
}