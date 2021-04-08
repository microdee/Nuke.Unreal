using System.Linq;
using System;
using System.IO;
using Nuke.Common.IO;

namespace Nuke.Unreal.BoilerplateGenerators
{
    public class SourceFileModel : CommonModelBase
    {
        public UnrealProject Project { get; init; }
        public UnrealPlugin Plugin { get; init; }
        public UnrealModule Module { get; init; }
    }

    public record SourceFileGeneratorArgs(string Name)
    {
    }

    public abstract class SourceFileGenerator : SourceFileGenerator<SourceFileGeneratorArgs, SourceFileModel>
    {
    }
    
    public abstract class SourceFileGenerator<TGeneratorArg, TModel>
        : BoilerplateGenerator
        where TGeneratorArg : SourceFileGeneratorArgs
        where TModel : SourceFileModel, new()
    {
        protected TModel Model;
        public abstract string TemplateSubfolder { get; }

        public virtual void Generate(AbsolutePath templatesPath, AbsolutePath currentFolder, TGeneratorArg Arguments)
        {
            CheckInsideSourceFolder(currentFolder);

            Model = GetModelFromArguments(currentFolder, Arguments);

            if(!FileSystemTasks.DirectoryExists(templatesPath / TemplateSubfolder))
                templatesPath = DefaultTemplateFolder;
            
            var sourceTemplateDir = templatesPath / TemplateSubfolder;
            var cppDstDir = currentFolder.ToString().Replace("public", "private", true, null);
            var cppFile = Directory.EnumerateFiles(sourceTemplateDir, "*.sbncpp").First();
            RenderFile(
                sourceTemplateDir,
                (RelativePath) Path.GetFileName(cppFile),
                (AbsolutePath) cppDstDir,
                Model
            );

            var hDstDir = currentFolder.ToString().Replace("private", "public", true, null);
            var hFile = Directory.EnumerateFiles(sourceTemplateDir, "*.sbnh").First();
            RenderFile(
                sourceTemplateDir,
                (RelativePath) Path.GetFileName(hFile),
                (AbsolutePath) hDstDir,
                Model
            );
        }

        public virtual TModel GetModelFromArguments(AbsolutePath currentFolder, TGeneratorArg Arguments)
        {
            var project = new UnrealProject(currentFolder);
            return new()
            {
                Name = Arguments.Name,
                Copyright = Unreal.ReadCopyrightFromProject((AbsolutePath)project.Folder),
                Project = project,
                Plugin = new UnrealPlugin(currentFolder),
                Module = new UnrealModule(
                    currentFolder,
                    $"{currentFolder} is not inside a Module. Unreal Engine requires all source files to be contained inside a Module in a Source folder."
                )
            };
        }

        protected void CheckInsideSourceFolder(AbsolutePath currentFolder)
        {
            if(!currentFolder.ToString().Contains("Source", StringComparison.InvariantCultureIgnoreCase))
            {
                throw new InvalidOperationException(
                    $"{currentFolder} doesn't contain a Source folder. Unreal Engine requires all source files to be contained inside a Module in a Source folder."
                );
            }
        }
    }
}