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
    public class ModuleModel : CommonModelBase
    {
        public UnrealProject Project { get; init; }
        public UnrealPlugin Plugin { get; init; }
    }

    public class ModuleGenerator : BoilerplateGenerator
    {
        protected ModuleModel Model;
        public string TemplateSubfolder => "Module";

        public bool AddToTarget { get; private set; }

        public ModuleGenerator SetAddToTarget(bool addToTarget)
        {
            AddToTarget = addToTarget;
            return this;
        }

        public void Generate(AbsolutePath templatesPath, AbsolutePath currentFolder, string name)
        {
            var project = new UnrealProject(currentFolder);
            Model = new() {
                Name = name,
                Copyright = Unreal.ReadCopyrightFromProject((AbsolutePath)project.Folder),
                Project = project,
                Plugin = new UnrealPlugin(currentFolder)
            };

            if(Directory.Exists(currentFolder / name))
            {
                throw new InvalidOperationException($"The module folder of {name} already exists in the current folder.");
            }

            if(!Directory.Exists(templatesPath / TemplateSubfolder))
                templatesPath = DefaultTemplateFolder;

            var templateDir = templatesPath / TemplateSubfolder;

            RenderFolder(templateDir, currentFolder, Model);

            if(Model.Plugin.IsValid)
                AddModuleToPlugin();
            else
                AddModuleToProject();
        }

        protected void AddModuleToProjectUnit(AbsolutePath projectFile, string name)
        {
            var unitJson = JObject.Parse(File.ReadAllText(projectFile));

            if(!unitJson.ContainsKey("Modules"))
            {
                unitJson.Add("Modules", new JArray());
            }
            else if (unitJson["Modules"] is JArray modulesArray)
            {
                if(!modulesArray.Any(t => t["Name"]?.ToString().Equals(name, StringComparison.InvariantCultureIgnoreCase) ?? false))
                {
                    modulesArray.Add(JObject.FromObject(new {
                        Name = name,
                        // We now just assume these here. The user can specify further if needed.
                        Type = "Runtime",
                        LoadingPhase = "Default"
                    }));
                }
                else throw new InvalidOperationException($"A module named {name} already exist.");
            }

            var result = unitJson.ToString(Formatting.Indented);
            File.WriteAllText(projectFile, result);
        }

        protected void AddModuleToPlugin()
        {
            var pluginFile = (AbsolutePath) Model.Plugin.Folder / $"{Model.Plugin.Name}.uplugin";
            try
            {
                AddModuleToProjectUnit(pluginFile, Model.Name);
            }
            catch (Exception e)
            {
                Logger.Warn($"Couldn't add module {Model.Name} to {Model.Plugin.Name}.uproject, it has to be added manually.");
                Logger.Warn("Exception:");
                Logger.Warn(e);
            }
        }

        protected void AddModuleToProject()
        {
            var projectFile = (AbsolutePath) Model.Project.Folder / $"{Model.Project.Name}.uproject";
            try
            {
                AddModuleToProjectUnit(projectFile, Model.Name);
            }
            catch (Exception e)
            {
                Logger.Warn($"Couldn't add module {Model.Name} to {Model.Project.Name}.uproject, it has to be added manually.");
                Logger.Warn("Exception:");
                Logger.Warn(e);
            }
            if(AddToTarget)
            {
                var targetFile = (AbsolutePath) Model.Project.Folder / "Source" / $"{Model.Project.Name}.Target.cs";
                var editorTargetFile = (AbsolutePath) Model.Project.Folder / "Source" / $"{Model.Project.Name}Editor.Target.cs";
                try
                {
                    AddModuleToTarget(targetFile);
                    AddModuleToTarget(editorTargetFile);
                }
                catch (Exception e)
                {
                    Logger.Warn($"Couldn't add module {Model.Name} to {Model.Project.Name}'s target rules, it has to be added manually.");
                    Logger.Warn("Exception:");
                    Logger.Warn(e);
                }
            }
        }

        protected void AddModuleToTarget(AbsolutePath targetFile)
        {
            var targetText = File.ReadAllText(targetFile);
            var targetSt = CSharpSyntaxTree.ParseText(targetText);

            var targetClass = targetSt.GetCompilationUnitRoot()
                .DescendantNodes().OfType<ClassDeclarationSyntax>()
                .FirstOrDefault(c =>
                    c.Identifier.ValueText.EndsWith("Target", true, null)
                    && c.Identifier.ValueText.Contains(Model.Project.Name, StringComparison.InvariantCultureIgnoreCase)
                );
            
            if(targetClass == null)
            {
                throw new InvalidDataException($"Could not find the target rule class in {targetFile}");
            }

            var constructor = targetClass
                .DescendantNodes().OfType<ConstructorDeclarationSyntax>()
                .FirstOrDefault();
            
            if(constructor == null)
            {
                throw new InvalidDataException($"Could not find the constructor of the target rule class in {targetFile}");
            }
            
            var extraModuleAdd = CSharpSyntaxTree.ParseText($"ExtraModuleNames.Add(\"{Model.Name}\");")
                .GetCompilationUnitRoot()
                .DescendantNodes().OfType<ExpressionStatementSyntax>()
                .FirstOrDefault();

            var newBody = constructor.Body?.AddStatements(extraModuleAdd);
            var newCtr = constructor.WithBody(newBody);

            var root = targetSt.GetRoot().ReplaceNode(constructor, newCtr);

            File.WriteAllText(targetFile, root.GetText().ToString());
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