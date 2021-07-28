using System.Linq;
using System;
using System.IO;
using Nuke.Common.IO;
using Nuke.Common.Utilities.Collections;

namespace Nuke.Unreal.BoilerplateGenerators
{
    public class SourceFileModel : CommonModelBase
    {
        public UnrealProject Project { get; init; }
        public UnrealPlugin Plugin { get; init; }
        public UnrealModule Module { get; init; }
        public string CppIncludePath { get; set; }
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
            Directory.EnumerateFiles(sourceTemplateDir, "*.sbncpp").ForEach(f =>
            {
                var srcFolder = ((AbsolutePath)f).Parent;
                Model.CppIncludePath = Path.GetRelativePath(Model.Module.Folder, srcFolder)
                    .Replace("\\", "/")
                    .Replace("public", "", true, null)
                    .Replace("private", "", true, null)
                    .Trim('.').Trim('/');
                RenderFile(
                    sourceTemplateDir,
                    (RelativePath) Path.GetFileName(f),
                    (AbsolutePath) cppDstDir,
                    Model
                );
    }       );

            var hDstDir = currentFolder.ToString().Replace("private", "public", true, null);
            Directory.EnumerateFiles(sourceTemplateDir, "*.sbnh").ForEach(f =>
                RenderFile(
                    sourceTemplateDir,
                    (RelativePath) Path.GetFileName(f),
                    (AbsolutePath) hDstDir,
                    Model
                )
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