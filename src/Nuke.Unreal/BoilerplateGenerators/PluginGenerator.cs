using System.Linq;
using System;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Nuke.Common.IO;
using Nuke.Common;

namespace Nuke.Unreal.BoilerplateGenerators
{
    public class PluginModel : CommonModelBase
    {
        public string UeVersion { get; init; }
        public UnrealProject Project { get; init; }
    }

    public class PluginGenerator : BoilerplateGenerator
    {
        protected PluginModel Model;
        public string TemplateSubfolder => "Plugin";

        public void Generate(AbsolutePath templatesPath, AbsolutePath currentFolder, string name, EngineVersion ueVersion)
        {
            var project = new UnrealProject(currentFolder);
            Model = new() {
                Name = name,
                Copyright = Unreal.ReadCopyrightFromProject((AbsolutePath)project.Folder),
                Project = project,
                UeVersion = ueVersion.FullVersionName
            };

            var pluginsFolder = (AbsolutePath) project.Folder / "Plugins";
            if(!Directory.Exists(pluginsFolder))
                Directory.CreateDirectory(pluginsFolder);

            if(Directory.Exists(pluginsFolder / name))
            {
                throw new InvalidOperationException($"The plugin folder of {name} already exists in project plugins.");
            }

            if(!Directory.Exists(templatesPath / TemplateSubfolder))
                templatesPath = DefaultTemplateFolder;

            var templateDir = templatesPath / TemplateSubfolder;

            RenderFolder(templateDir, pluginsFolder / name, Model);

            var srcFolder = pluginsFolder / name / "Source";
            Directory.CreateDirectory(srcFolder);

            new ModuleGenerator().Generate(templatesPath, srcFolder, name);
        }
    }
}