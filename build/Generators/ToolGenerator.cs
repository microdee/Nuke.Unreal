using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Text;
using Nuke.Common.IO;
using Scriban;


namespace build.Generators;

public abstract class ToolGenerator
{
    private static AbsolutePath GetTemplatesFolder([CallerFilePath] string sourcePath = null) =>
        ((AbsolutePath) sourcePath).Parent / "Templates";

    public abstract string TemplateName { get; }

    public string UnrealVersion { init; get; }

    protected abstract object Model { get; }

    private string ReadTemplate(AbsolutePath path, HashSet<AbsolutePath> previousIncludes = null)
    {
        var templateText = File.ReadAllText(path);
        var includeMatches = Regex.Matches(templateText, @"\/\*\s+(?<INCLUDE>.*?\.sbncs)\s+\*\/");
        for (int i=0; i<includeMatches.Count; i++)
        {
            previousIncludes ??= new();
            var match = includeMatches[i];
            var include = match.Groups["INCLUDE"];
            var includePath = GetTemplatesFolder() / include.Value;
            if (previousIncludes.Contains(includePath))
            {
                templateText = templateText.Replace(match.Value, "");
                continue;
            }
            if (includePath.FileExists())
            {
                previousIncludes.Add(includePath);
                var includeText = ReadTemplate(includePath, previousIncludes);
                templateText = templateText.Replace(match.Value, includeText);
            }
            else
            {
                throw new FileNotFoundException($"Include file {includePath} during template preprocessing didn't exist.");
            }
        }
        return templateText;
    }

    public virtual void Generate(GeneratorExecutionContext context)
    {
        var path = GetTemplatesFolder() / $"{TemplateName}.sbncs";
        var templateText = ReadTemplate(path);
        var scribanTemplate = Template.Parse(templateText, path);
        // TODO: Output to actual file
        context.AddSource(TemplateName, SourceText.From(scribanTemplate.Render(Model), Encoding.UTF8));
    }
}