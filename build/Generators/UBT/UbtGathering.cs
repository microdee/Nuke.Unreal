using System;
using Serilog;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using Nuke.Common.IO;
using Nuke.Common.Utilities;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Nuke.Common.Utilities.Collections;
using Towel;
using System.Security;

namespace build.Generators.UBT;

/*
    Classes are considered where
        - class is decorated with ToolModeAttribute
        - or any of its field is [CommandLine()]
          - if that's not a tool mode it will be merged with main tool.
*/

public static class UniqueClass
{
    public const string ToolMode = nameof(ToolMode);
}

public partial class UbtGathering : CSharpSourceGatherer
{
    public UbtGathering(params AbsolutePath[] root) : base(root) {}

    protected static bool ContainsCommandLineArg(ClassInfo classInfo) => classInfo.Declarations
        .Select(d => d.Declaration)
        .SelectMany(c => c
            .DescendantNodes()
            .OfType<AttributeSyntax>()
        )
        .Any(a => a.Name.ToString() == "CommandLine");

    protected static bool IsConsidered(ClassInfo classInfo) => !classInfo.IsAbstract
        && (
            classInfo.Implements(UniqueClass.ToolMode) != null
            || ContainsCommandLineArg(classInfo)
        );

    ArgumentModelType GetArgType(TypeSyntax type, bool isCollection)
    {
        if (type is ArrayTypeSyntax array)
        {
            return GetArgType(array.ElementType, true);
        }
        if (type is GenericNameSyntax generic)
        {
            // We only care about the first argument of generic collections as caring about the
            // rest opens up all sorts of can of worms which I don't have the patience for
            var subtype = generic.TypeArgumentList.Arguments.First();
            return GetArgType(subtype, true);
        }
        if (type.GetRootName() == "bool")
        {
            // Collection of booleans makes no sense through the command line
            return ArgumentModelType.Bool;
        }
        if (type.IsScalarType())
        {
            return isCollection ? ArgumentModelType.ScalarCollection : ArgumentModelType.Scalar;
        }
        if (Enums.ContainsKey(type.GetRootName()))
        {
            return isCollection ? ArgumentModelType.EnumCollection : ArgumentModelType.Enum;
        }

        return isCollection ? ArgumentModelType.TextCollection : ArgumentModelType.Text;
    }

    string GetEnumType(TypeSyntax type) => type switch
    {
        GenericNameSyntax generic => GetEnumType(generic.TypeArgumentList.Arguments.First()),
        _ => type.GetRootName()
    };

    protected void GatherFromCommandLineAttributes(ClassInfo from, IGatheringContext context)
    {
        var compatibility = (context as IHaveEngineCompatibility)?.Compatibility ?? UnrealCompatibility.All;
        var consideredMembers = from.PropertiesAndFields
            .Where(m => m.AttributeLists
                .SelectMany(a => a.Attributes)
                .Any(a => a.Name.ToString() == "CommandLine")
            )
            .Where(m => !m.GetMemberName().EqualsAnyOrdinalIgnoreCase("bGetHelp", "bHelp"));
        Log.Debug(context.Indent() + "from {0}", from.Name);
        
        using var indent = new Indentation(context);
        foreach (var member in consideredMembers)
        {
            var memberName = member.GetMemberName();
            var memberType = member.GetMemberType();
            var commandLineAttrs = member.AttributeLists
                .SelectMany(a => a.Attributes)
                .Where(a => a.Name.ToString() == "CommandLine");

            foreach(var commandLineAttr in commandLineAttrs)
            {
                var implicitCliNameCandidateNode = commandLineAttr
                    .GetImplicitAttributeArguments()
                    ?.FirstOrDefault();

                var explicitCliNameCandidateNode = commandLineAttr.GetNamedAttributeArgument("Prefix");

                var cliNameCandidate = implicitCliNameCandidateNode
                    ?? explicitCliNameCandidateNode
                    ?? null;
                    
                if (string.IsNullOrWhiteSpace(cliNameCandidate))
                {
                    Log.Warning(
                        indent >> "{0} didn't specify a separate CLI name. The C# name will be assumed",
                        memberName
                    );
                    cliNameCandidate = "-" + memberName;
                }

                var cliName = (cliNameCandidate[0] != '-' ? "-" : "") + cliNameCandidate
                    .TrimEnd('=')
                    .TrimEnd(':');
                var csharpName = cliName[1..].EnsureIdentifierCompatibleName().Replace("UE4", "Unreal");

                var setter = "=:".Any(c => c == cliNameCandidate[^1])
                        ? cliNameCandidate[^1].ToString()
                        : "=";

                var value = commandLineAttr.GetNamedAttributeArgument("Value");

                var argType = ArgumentModelType.Switch;
                EnumData enumData = null;

                if (value == null)
                {
                    argType = GetArgType(memberType, false);
                }
                
                if (argType == ArgumentModelType.Enum || argType == ArgumentModelType.EnumCollection)
                {
                    var enumTypeName = GetEnumType(memberType);
                    if (Enums.TryGetValue(enumTypeName, out var enumType))
                    {
                        enumData = new(
                            enumTypeName,
                            enumType.GetLeadingXmlDocs()
                                ?.PadLinesLeft("/// "),
                            enumType.Members
                                .Select(f => new EnumEntry(
                                    f.Identifier.Text,
                                    f.GetLeadingXmlDocs()
                                        ?.PadLinesLeft("/// ")
                                ))
                                .SelectMany(f => f.Name.Contains("UE4")
                                    ? new EnumEntry[] { f, f with { Name = f.Name.Replace("UE4", "Unreal") }}
                                    : new EnumEntry[] { f }
                                )
                        );
                    }
                    else
                    {
                        argType = argType == ArgumentModelType.EnumCollection
                            ? ArgumentModelType.TextCollection
                            : ArgumentModelType.Text;
                    }
                }

                var separator = commandLineAttr.GetNamedAttributeArgument("ListSeparator");
                bool isCollectionMultipleArgs = argType >= ArgumentModelType.ScalarCollection && string.IsNullOrWhiteSpace(separator);

                var documentation = member.GetLeadingXmlDocs();
                var description = commandLineAttr.GetNamedAttributeArgument("Description");
                var requiredWarning = commandLineAttr.GetNamedAttributeArgument("Required") != null
                    ? "REQUIRED!"
                    : null;

                var existing = from.AddArgument(
                    new ArgumentModel()
                    {
                        ConfigName = csharpName,
                        CliName = cliName,
                        ArgumentType = argType,
                        CollectionSeparator = separator ?? "=",
                        IsCollectionMultipleArgs = isCollectionMultipleArgs,
                        ValueSetter = setter,
                        Enum = enumData,
                        Compatibility = new() { compatibility }
                    }
                    .AddRootlessXmlDocs(documentation)
                    .AddSummary(description)
                    .AddSummary(requiredWarning)
                );
                if (existing == null)
                {
                    Log.Debug(indent >> "{0} {1}", cliName, csharpName);
                }
            }
        }
    }

    protected ToolModel CreateSubtool(ClassInfo from, IGatheringContext context)
    {
        var compatibility = (context as IHaveEngineCompatibility)?.Compatibility ?? UnrealCompatibility.All;
        var toolModeCliName = from.Declarations
            .SelectMany(d => d.Declaration
                .DescendantNodes()
                .OfType<AttributeSyntax>()
            )
            .Where(a => a.Name.ToString() == "ToolMode")
            .SelectMany(a => a
                .DescendantNodes()
                .Where(l => l.IsKind(SyntaxKind.StringLiteralExpression))
                .Cast<LiteralExpressionSyntax>()
            )
            .Select(s => s.Token.ValueText)
            .Where(s => !string.IsNullOrWhiteSpace(s))
            .FirstOrDefault();

        var csharpName = toolModeCliName?.EnsureIdentifierCompatibleName() ?? from.Name;
        var outCsharpName = csharpName.Replace("UE4", "Unreal");
        var docs = from.Declarations
            .Select(c => c.Declaration.GetLeadingXmlDocs())
            .Where(d => !string.IsNullOrWhiteSpace(d));

        var tool = new ToolModel {
            ConfigName = outCsharpName,
            ConfigType = new(outCsharpName + "Config", outCsharpName + "Config"),
            CliName = toolModeCliName == null ? "" : "-" + toolModeCliName,
            Compatibility = new() { compatibility }
        };

        if (!docs.IsEmpty())
        {
            tool.AddRootlessXmlDocs(string.Join('\n', docs));
        }

        return tool;
    }

    public void Gather(IGatheringContext context)
    {
        Log.Information(context.Indent() + "Gathering all classes in UBT");
        GatherClasses(context);
        Log.Information(context.Indent() + "Gathering all enums in UBT");
        GatherEnums(context);

        var toolCandidates = Classes.Values.Where(IsConsidered);
        
        Log.Information(context.Indent() + "Gathering parameters from all classes");
        using(var indent = new Indentation(context))
            toolCandidates.ForEach(c => GatherFromCommandLineAttributes(c, context));

        Log.Information(context.Indent() + "Creating subtools");
        using(var indent = new Indentation(context))
            toolCandidates.ForEach(c =>
            {
                var tool = CreateSubtool(c, context);
                Log.Debug(indent >> "from {0} as {1}", c.Name, tool.CliName);
                c.Arguments.ForEach(a => tool.AddArgument(a));
                if (context is IHaveSubTools contextSubtools)
                {
                    contextSubtools.SubTools.Add(tool);
                    if (string.IsNullOrWhiteSpace(tool.CliName))
                    {
                        Log.Debug(context.Indent() + "... part of the main tool.");
                        tool.Arguments.ForEach(a => contextSubtools.MainTool.AddArgument(a));
                    }
                }
            });
    }
}