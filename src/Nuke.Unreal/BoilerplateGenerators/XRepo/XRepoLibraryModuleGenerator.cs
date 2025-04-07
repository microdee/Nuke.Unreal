using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Nuke.Cola;
using Nuke.Cola.Tooling;
using Nuke.Common.IO;
using Nuke.Common.Utilities;
using Nuke.Common.Utilities.Collections;

namespace Nuke.Unreal.BoilerplateGenerators.XRepo;

public record XRepoLibraryModuleModel(
    LibrarySpec Spec,
    UnrealPlatform Platform,
    string? Copyright,
    SuffixRecord Suffix,
    IEnumerable<XRepoLibraryRecord> Libraries,
    bool HeaderOnly
) : CommonModelBase(Spec.Name, Copyright);

public class XRepoLibraryModuleGenerator : BoilerplateGenerator
{
    protected XRepoLibraryModuleModel? Model;

    public void Generate(AbsolutePath templatesPath, AbsolutePath currentFolder, LibrarySpec spec, UnrealPlatform platform, IEnumerable<XRepoLibraryRecord> libraries, string? suffix)
    {
        var project = new UnrealProject(currentFolder);
        Model = new(
            Spec: spec,
            Platform: platform,
            Copyright: Unreal.ReadCopyrightFromProject(project.Folder!),
            Suffix: new(suffix),
            Libraries: libraries,
            HeaderOnly: libraries.SelectMany(l => l.LibFiles.Concat(l.SysLibs)).IsEmpty()
        );

        var templateSubFolder = "XRepoLibraryModule";
        if (!(templatesPath / templateSubFolder).DirectoryExists())
            templatesPath = DefaultTemplateFolder;
        
        var templateDir = templatesPath / templateSubFolder;
        RenderFolder(templateDir, currentFolder, Model);
        if (Model.HeaderOnly)
        {
            var redundantPlatformModuleFile = $"{spec.UnrealName}{Model.Suffix.Us}.{platform}.Build.cs";
            (currentFolder / redundantPlatformModuleFile).DeleteFile();
        }
    }
}