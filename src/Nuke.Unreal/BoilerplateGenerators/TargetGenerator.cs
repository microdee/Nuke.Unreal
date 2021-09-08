using System.Linq;
using System;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Nuke.Common.IO;
using Nuke.Common;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Nuke.Unreal.BoilerplateGenerators
{
    public class TargetModel : CommonModelBase
    {
        public UnrealProject Project { get; init; }
    }

    public class TargetGenerator : BoilerplateGenerator
    {
        protected TargetModel Model;
        public string TemplateSubfolder => "Target";

        public void Generate(AbsolutePath templatesPath, AbsolutePath currentFolder, string name)
        {
            var project = new UnrealProject(currentFolder);
            Model = new() {
                Name = name,
                Copyright = Unreal.ReadCopyrightFromProject((AbsolutePath)project.Folder),
                Project = project
            };

            if(!Directory.Exists(templatesPath / TemplateSubfolder))
                templatesPath = DefaultTemplateFolder;

            var templateDir = templatesPath / TemplateSubfolder;

            RenderFolder(templateDir, currentFolder, Model);

            var srcFolder = currentFolder / "Source";
            Directory.CreateDirectory(srcFolder);

            new ModuleGenerator().Generate(templatesPath, srcFolder, name);
        }

        protected void CheckInsideSourceFolder(AbsolutePath currentFolder)
        {
            if(!currentFolder.ToString().Contains("Source", StringComparison.InvariantCultureIgnoreCase))
            {
                throw new InvalidOperationException(
                    $"{currentFolder} doesn't contain a Source folder. Unreal Engine requires Module to be inside the project or plugin Source folder."
                );
            }
        }
    }
}