using System.Linq;
using System;
using System.IO;
using Serilog;
using Nuke.Common.IO;
using Nuke.Common.Utilities.Collections;
using Nuke.Common;

namespace Nuke.Unreal.BoilerplateGenerators
{
    public record SourceFileModel(
        string Name, string? Copyright,
        UnrealProject Project,
        UnrealPlugin Plugin,
        UnrealModule Module,
        string CppIncludePath
    ) : CommonModelBase(Name, Copyright);
    
    public abstract class SourceFileGenerator : BoilerplateGenerator
    {
        protected SourceFileModel? Model;
        public abstract string TemplateSubfolder { get; }

        public virtual void Generate(AbsolutePath templatesPath, AbsolutePath currentFolder, string name)
        {
            CheckInsideSourceFolder(currentFolder);

            Model = GetModelFromArguments(currentFolder, name) with {
                CppIncludePath = Path.GetRelativePath(Model!.Module.Folder, currentFolder)
                    .Replace("\\", "/")
                    .Replace("public", "", true, null)
                    .Replace("private", "", true, null)
                    .Trim('.').Trim('/')
            };

            if(!(templatesPath / TemplateSubfolder).DirectoryExists())
                templatesPath = DefaultTemplateFolder;
            
            var sourceTemplateDir = templatesPath / TemplateSubfolder;
            var cppDstDir = currentFolder.ToString().Replace("public", "private", true, null);

            if(Model.Plugin != null)
                Log.Debug($"Plugin: {Model.Plugin.Folder}");
            
            Log.Debug($"Module: {Model.Module.Folder}");

            Directory.EnumerateFiles(sourceTemplateDir, "*.sbncpp").ForEach(f =>
                RenderFile(
                    sourceTemplateDir,
                    (RelativePath) Path.GetFileName(f),
                    (AbsolutePath) cppDstDir,
                    Model
                )
            );

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

        public virtual SourceFileModel GetModelFromArguments(AbsolutePath currentFolder, string name)
        {
            var project = new UnrealProject(currentFolder);
            return new(
                Name: name,
                Copyright: Unreal.ReadCopyrightFromProject(project.Folder!),
                Project: project,
                Plugin: new UnrealPlugin(currentFolder),
                Module: new UnrealModule(
                    currentFolder,
                    $"{currentFolder} is not inside a Module. Unreal Engine requires all source files to be contained inside a Module in a Source folder."
                ),
                CppIncludePath: ""
            );
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