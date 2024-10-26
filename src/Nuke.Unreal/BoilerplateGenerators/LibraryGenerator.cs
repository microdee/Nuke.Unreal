using System.Linq;
using System;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Nuke.Common.IO;
using Nuke.Common.Tooling;
using System.ComponentModel;
using Nuke.Cola;

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
        ParseSpec = LibrarySpec.ParseXRepo
    };

    public required string TemplateSubfolder { init; get; }
    public Func<string, LibrarySpec> ParseSpec { get; private set; } = s => new LibrarySpec(s);
}

public record LibrarySpec(
    string Name,
    string? Version = null,
    string? Provider = null,
    string? Options = null
) {
    internal static LibrarySpec ParseXRepo(string spec)
    {
        var matches = spec.Parse(
            """
            ^
            (?:(?<PROVIDER>\w+)\:\:)?
            (?<NAME>[\w\.]+)
            (?:[\s\/-](?<VERSION>[0-9\.x#]+))?
            (?:\s(?<OPTIONS>[\w=,]+))?
            $
            """.AsSingleLine("")
        );
        return new(matches("NAME")!, matches("VERSION"), matches("PROVIDER"), matches("OPTIONS"));
    }
}

public record LibraryModel(
    LibrarySpec Spec, string? Copyright, string? Suffix
) : CommonModelBase(Spec.Name, Copyright);

public class LibraryGenerator : BoilerplateGenerator
{
    protected LibraryModel? Model;
    public required string Spec { init; get; }
    public required LibraryType LibraryType { init; get; }
    public string TemplateSubfolder => LibraryType.TemplateSubfolder;
    public string? Suffix { init; get; }

    public void Generate(AbsolutePath templatesPath, AbsolutePath currentFolder, EngineVersion ueVersion)
    {
        var project = new UnrealProject(currentFolder);
        var spec = LibraryType.ParseSpec(Spec);
        Model = new(
            Spec: spec,
            Copyright: Unreal.ReadCopyrightFromProject(project.Folder!),
            Suffix: Suffix
        );

        if ((currentFolder / spec.Name).DirectoryExists())
        {
            throw new InvalidOperationException($"The library module folder of {spec.Name} already exists in the current folder.");
        }

        if(!(templatesPath / TemplateSubfolder).DirectoryExists())
            templatesPath = DefaultTemplateFolder;

        var templateDir = templatesPath / TemplateSubfolder;

        RenderFolder(templateDir, currentFolder / spec.Name, Model);
    }
}