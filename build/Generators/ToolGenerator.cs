using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Nuke.Common;
using Nuke.Common.IO;
using Nuke.Unreal;
using Scriban;
using Serilog;

namespace build.Generators;

public record ToolGeneratorUnrealArg(string EngineVersion, UnrealCompatibility Compatibility);

public abstract class ToolGenerator
{
    private static AbsolutePath GetTemplatesFolder([CallerFilePath] string sourcePath = null) =>
        ((AbsolutePath) sourcePath).Parent / "Templates";

    public abstract string TemplateName { get; }

    protected abstract ToolModel GetToolModelForEngine(string engineVersion, UnrealCompatibility compatibility);

    protected abstract object GetFullModel(ToolModel tool);

    protected virtual RelativePath OutputPath => (RelativePath) "src" / "Nuke.Unreal" / "Tools" / (TemplateName + ".cs");

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

    private ToolModel _outputTool = null;

    public virtual void Generate(INukeBuild build, params ToolGeneratorUnrealArg[] unrealArgs)
    {
        foreach(var unreal in unrealArgs)
        {
            Log.Information("Generating {0} from Unreal Engine {1} {2}", TemplateName, unreal.EngineVersion, unreal.Compatibility);
            var currentTool = GetToolModelForEngine(unreal.EngineVersion, unreal.Compatibility);
            if (_outputTool == null)
            {
                _outputTool = currentTool;
            }
            else
            {
                Log.Debug("Merging result with previous gathering");
                _outputTool.Merge(currentTool);
            }
        }
        var path = GetTemplatesFolder() / $"{TemplateName}.sbncs";
        var templateText = ReadTemplate(path);
        var scribanTemplate = Template.Parse(templateText, path);
        var model = GetFullModel(_outputTool);
        var output = scribanTemplate.Render(model);
        File.WriteAllText(build.RootDirectory / OutputPath, output);
    }
}