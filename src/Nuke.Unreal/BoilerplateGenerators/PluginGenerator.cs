using System.Linq;
using System;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Nuke.Common.IO;
using Nuke.Common;

namespace Nuke.Unreal.BoilerplateGenerators
{
    public record PluginModel(
        string Name, string? Copyright,
        string UeVersion, UnrealProject Project
    ) : CommonModelBase(Name, Copyright);

    public class PluginGenerator : BoilerplateGenerator
    {
        protected PluginModel? Model;
        public string TemplateSubfolder => "Plugin";

        public void Generate(AbsolutePath templatesPath, AbsolutePath currentFolder, string name, EngineVersion ueVersion)
        {
            var project = new UnrealProject(currentFolder);
            Model = new(
                Name: name,
                Copyright: Unreal.ReadCopyrightFromProject(project.Folder!),
                Project: project,
                UeVersion: ueVersion.VersionMinor
            );

            var projectMainPluginsFolder = project.Folder / "Plugins";
            var pluginsFolder = currentFolder.ToString().Contains(projectMainPluginsFolder)
                ? currentFolder
                : projectMainPluginsFolder;

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