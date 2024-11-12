using System.Linq;
using System;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Nuke.Common.IO;
using Nuke.Common.Tooling;
using System.ComponentModel;
using Nuke.Cola;
using System.Text.RegularExpressions;
using Nuke.Unreal.BoilerplateGenerators.XRepo;
using System.Collections.Generic;
using Humanizer;

namespace Nuke.Unreal.BoilerplateGenerators;

[TypeConverter(typeof(TypeConverter<LibraryType>))]
public class LibraryType : Enumeration
{
    public static readonly LibraryType Header = new()
    {
        Value = nameof(Header),
        TemplateSubfolder = "HeaderLibrary"
    };
    
    public static readonly LibraryType CMake = new()
    {
        Value = nameof(CMake),
        TemplateSubfolder = "CMakeLibrary"
    };
    
    public static readonly LibraryType XRepo = new()
    {
        Value = nameof(XRepo),
        TemplateSubfolder = "XRepoLibrary",
        ParseSpec = XRepoLibrary.ParseSpec
    };

    public required string TemplateSubfolder { init; get; }
    public Func<string, LibrarySpec> ParseSpec { get; private set; } = s => new LibrarySpec(s, s);
}

public record LibrarySpec(
    string Spec,
    string Name,
    string? Version = null,
    string? Provider = null,
    string? Options = null,
    string? Features = null
) {
    public string UnrealName => Name.Pascalize();
}

public record SuffixRecord(string? Text, string? Us, string? Dot)
{
    public SuffixRecord(string? suffix) : this(suffix, suffix.PrependNonEmpty("_"), suffix.PrependNonEmpty(".")) {}
}

public record LibraryModel(
    LibrarySpec Spec,
    string? Copyright,
    SuffixRecord Suffix,
    IEnumerable<UnrealPlatform> Platforms
) : CommonModelBase(Spec.Name, Copyright);

public class LibraryGenerator : BoilerplateGenerator
{
    protected LibraryModel? Model;

    public void Generate(AbsolutePath templatesPath, AbsolutePath currentFolder, string fullSpec, LibraryType libraryType, string? suffix)
    {
        var project = new UnrealProject(currentFolder);
        var spec = libraryType.ParseSpec(fullSpec);
        Model = new(
            Spec: spec,
            Copyright: Unreal.ReadCopyrightFromProject(project.Folder!),
            Suffix: new(suffix),
            Platforms: UnrealPlatform.Platforms
        );

        if ((currentFolder / (spec.Name + Model.Suffix.Us)).DirectoryExists())
        {
            throw new InvalidOperationException($"The library module folder of {spec.Name} already exists in the current folder.");
        }

        if(!(templatesPath / libraryType.TemplateSubfolder).DirectoryExists())
            templatesPath = DefaultTemplateFolder;

        var templateDir = templatesPath / libraryType.TemplateSubfolder;

        RenderFolder(templateDir, currentFolder, Model);
    }
}