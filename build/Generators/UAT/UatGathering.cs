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

namespace build.Generators.UAT;

/*
    Classes are considered where
        - non-abstract T is BuildCommand
        - special cases
    
    Inheriting params via
        - Base class
        - Member field/property of considered class

    Special unique-snowflake-unicorn classes which provide important command line arguments but they're
    sooo important and sooo reusable in the pile of garbage that is the UAT source code they don't follow
    any apparent source conventions to ease their discoveribility: (as of UE 4.27)
        - Program
        - ProjectParams
        - Automation
        - CodeSign
        - McpConfigMapper
        - P4Environment
        - UE4Build (probably renamed in UE5 to UnrealBuild)
        - LocalizationProvider (+ implementations)

        - Just completely ignore these because they're doing 100% runtime command line parsing, which
          cannot be inferred from static code analysis. Developer should just invoke them through regular
          tool invokation arguments
            - MegaXGE
*/

public static class UniqueClass
{
    public const string BuildCommand = nameof(BuildCommand);
    public const string Program = nameof(Program);
    public const string ProjectParams = nameof(ProjectParams);
    public const string Automation = nameof(Automation);
    public const string CodeSign = nameof(CodeSign);
    public const string McpConfigMapper = nameof(McpConfigMapper);
    public const string P4Environment = nameof(P4Environment);
    public const string UE4Build = nameof(UE4Build);
    public const string LocalizationProvider = nameof(LocalizationProvider);

    public static readonly List<string> SpeciallyConsideredClasses = new()
    {
        Program,
        ProjectParams,
        Automation,
        CodeSign,
        McpConfigMapper,
        P4Environment,
        UE4Build,
        LocalizationProvider
    };
}

public static class ExcludedClass
{
    public const string MegaXGE = nameof(MegaXGE);
}

public partial class UatGathering
{
    public readonly UatSolution Solution;
    public readonly Dictionary<string, ClassInfo> Classes = new();

    public UatGathering(AbsolutePath automationToolRoot)
    {
        Solution = new(automationToolRoot);
    }

    protected void GatherClasses(IGatheringContext context)
    {
        context.IncreaseIndent();
        Dictionary<string, ClassInfo> baseClassRequests = new();
        foreach(var csClass in Solution.Files.SelectMany(f => f.Classes))
        {
            Log.Debug(context.Indent() + "Gathered class: {0}", csClass.Name);
            if (!Classes.TryGetValue(csClass.Name, out var classInfo))
            {
                classInfo = new() {
                    Name = csClass.Name,
                    IsPartial = csClass.IsPartial
                };
            }
            classInfo.Declarations.Add(csClass);
            if (csClass.HasBase)
            {
                baseClassRequests.TryAdd(csClass.BaseClass, classInfo);
            }
        }
        foreach(var (baseClassOf, targetClass) in baseClassRequests)
        {
            if (Classes.TryGetValue(baseClassOf, out var baseClass))
            {
                targetClass.BaseClass = baseClass;
            }
        }
        context.DecreaseIndent();
    }

    protected IEnumerable<ClassInfo> LocalizationProviderImplementations => Classes.Values
        .Where(c => c.Implements(UniqueClass.LocalizationProvider) != null);

    protected bool IsConsidered(ClassInfo classInfo) =>
        classInfo.Name != ExcludedClass.MegaXGE
        && !classInfo.IsAbstract
        && (
            classInfo.Implements(UniqueClass.BuildCommand) != null
            || UniqueClass.SpeciallyConsideredClasses.Any(specClass => classInfo.Name == specClass)
            || classInfo.Implements(UniqueClass.LocalizationProvider) != null
        );

    [GeneratedRegex(@"(Parse|Get)(Optional)?Param")]
    private static partial Regex ParamGetterInvocationRegex();

    protected void GatherFromCommandLineArgumentParsers(ClassInfo from, IGatheringContext context)
    {
        var paramGetterInvocations = from.Declarations.SelectMany(c => c.Declaration
            .DescendantNodes().OfType<InvocationExpressionSyntax>()
            .Where(n => ParamGetterInvocationRegex().IsMatch(n
                .DescendantNodes()
                .OfType<IdentifierNameSyntax>()
                .First()
                .Identifier.Text
            ))
        );

        foreach(var invocation in paramGetterInvocations)
        {
            var cliName = invocation.DescendantNodes()
                .OfType<LiteralExpressionSyntax>()
                .Where(n => n.IsKind(SyntaxKind.StringLiteralExpression))
                .Select(n => n.Token.Text)
                .Where(n => !string.IsNullOrWhiteSpace(n))
                .FirstOrDefault()
                ?.TrimMatchingDoubleQuotes();
            
            if (string.IsNullOrWhiteSpace(cliName))
                continue;
            
            var csharpName = invocation.DescendantNodes()
                .OfType<ArgumentSyntax>()
                .Select(n => n
                    .DescendantNodes()
                    .OfType<IdentifierNameSyntax>()
                    .FirstOrDefault()
                )
                .Where(n => n != null)
                .Select(n => n.GetText().ToString())
                .Where(n => n.MemberAssociable(cliName))
                .FirstOrDefault(cliName)
                .EnsureIdentifierCompatibleName();

            var documentation = "";

            var memberCandidate = from.PropertiesAndFields
                .FirstOrDefault(m => m
                    .GetFieldOrPropertyName()
                    .MemberAssociable(csharpName)
                );
            
            if (memberCandidate?.HasStructuredTrivia ?? false)
            {
                var doscSpan = memberCandidate.GetLeadingTrivia()
                    .Where(t =>
                        t.IsKind(SyntaxKind.SingleLineDocumentationCommentTrivia)
                        || t.IsKind(SyntaxKind.MultiLineDocumentationCommentTrivia)
                    )
                    .FirstOrDefault()
                    .FullSpan;

                // TODO: get extra help from HelpAttribute

                documentation = memberCandidate.SyntaxTree
                    .GetText().GetSubText(doscSpan).ToString()
                    .Replace("///", "")
                    .Trim();
            }

            
            var existing = from.AddArgument(
                new ArgumentModel() {
                    ConfigName = csharpName,
                    CliName = (cliName[0] == '-' ? "" : "-") + cliName,
                    ArgumentType = ArgumentModelType.TextCollection
                }.AddRootlessXmlDocs(documentation)
            );
            if (existing != null)
            {
                Log.Debug(context.Indent() + "{0} {1}", cliName, csharpName);
            }
        }
    }

    [GeneratedRegex(@"(?<NAME>[\w-]+)((?<SETTER>[:=]).*)?")]
    private static partial Regex ArgumentFromHelp();

    protected void GatherFromHelpHeuristics(ClassInfo from, IGatheringContext context)
    {
        var commandHelpAttributes = from.HelpAttributes
            .Where(a => a
                .DescendantNodes()
                .OfType<AttributeArgumentSyntax>()
                .Count() == 2
            );
        
        foreach(var attr in commandHelpAttributes)
        {
            var arguments = attr
                .DescendantNodes()
                .OfType<AttributeArgumentSyntax>()
                .SelectMany(a => a
                    .DescendantNodes()
                    .Where(l => l.IsKind(SyntaxKind.StringLiteralExpression))
                    .Cast<LiteralExpressionSyntax>()
                )
                .ToArray();
            if (arguments.Length != 2) continue;

            var regexMatch = ArgumentFromHelp().Match(arguments[0].Token.Text);
            if (regexMatch?.Groups?["NAME"] == null) continue;

            var argument = new ArgumentModel()
            {
                CliName = regexMatch.Groups["NAME"].Value,
                ConfigName = regexMatch.Groups["NAME"].Value.Replace("-", "").EnsureIdentifierCompatibleName(),
                ArgumentType = ArgumentModelType.TextCollection,
                ValueSetter = regexMatch.Groups["SETTER"]?.Value ?? "="
            }.AddSummary(arguments[1].Token.Text);
            var existing = from.AddArgument(argument);
            if (existing != null)
            {
                Log.Debug(context.Indent() + "{0} {1}", argument.CliName, argument.ConfigName);
            }
        }
    }

    protected ToolModel CreateSubtool(ClassInfo from, IGatheringContext context)
    {
        var commandDescriptionHelpAttr = from.HelpAttributes
            .Where(a => a
                .DescendantNodes()
                .OfType<AttributeArgumentSyntax>()
                .Count() == 1
            )
            .SelectMany(a => a
                .DescendantNodes()
                .Where(l => l.IsKind(SyntaxKind.StringLiteralExpression))
                .Cast<LiteralExpressionSyntax>()
            )
            .Select(s => s.Token.Text)
            .Where(s => !string.IsNullOrWhiteSpace(s))
            .Select(s => s.TrimMatchingDoubleQuotes());

        var tool = new ToolModel {
            ConfigName = from.Name,
            ConfigType = new(from.Name + "Config", from.Name + "Config"),
            CliName = from.Implements(UniqueClass.BuildCommand) == null ? "" : from.Name,
        };

        if (!commandDescriptionHelpAttr.IsNullOrEmpty())
        {
            tool.AddSummary(string.Join('\n', commandDescriptionHelpAttr));
        }

        if (from.RequireP4)
        {
            tool.AddRemarks("WARNING: This command might require Perforce");
        }

        return tool;
    }

    protected void ImportArgs(ClassInfo currentClass, ToolModel tool, IGatheringContext context)
    {
        if (currentClass.Name == UniqueClass.BuildCommand)
        {
            return;
        }

        currentClass.Arguments.ForEach(a => tool.AddArgument(a));
        
        if (UniqueClass.SpeciallyConsideredClasses.Any(sc => currentClass.Name == sc))
        {
            return;
        }
        
        // From Help attribute Heuristics
        var typeImportsFromHelp = currentClass.HelpAttributes
            .Where(a => a
                .DescendantNodes()
                .OfType<AttributeArgumentSyntax>()
                .Count() == 1
            )
            .SelectMany(a => a.DescendantNodes().OfType<TypeOfExpressionSyntax>())
            .SelectMany(t => t.DescendantNodes().OfType<IdentifierNameSyntax>())
            .Select(i => i.Identifier.Text);
        
        if (!typeImportsFromHelp.IsNullOrEmpty())
        {
            Log.Debug(context.Indent() + "Help(type(T)) above {0}", currentClass.Name);
            context.IncreaseIndent();
            foreach(var import in typeImportsFromHelp)
            {
                if (Classes.TryGetValue(import, out var classInfo))
                {
                    Log.Debug(context.Indent() + "{0}", classInfo.Name);
                    ImportArgs(classInfo, tool, context);
                }
            }
            context.DecreaseIndent();
        }

        // From class inheritance
        var current = currentClass.BaseClass;
        while(current != null && current.Name != UniqueClass.BuildCommand)
        {
            Log.Debug(context.Indent() + "inheriting from {0}", current.Name);
            ImportArgs(current, tool, context);
            current = current.BaseClass;
        }

        // From referencing a build command in class fields or properties
        var members = currentClass.PropertiesAndFields
            .SelectMany(m => m.DescendantNodes().OfType<IdentifierNameSyntax>())
            .Where(t => Classes.ContainsKey(t.Identifier.Text))
            .Select(t => Classes[t.Identifier.Text])
            .Where(IsConsidered);
        
        if (!members.IsNullOrEmpty())
        {
            Log.Information(context.Indent() + "Importing members of {0}", currentClass.Name);
            context.IncreaseIndent();
            foreach(var member in members)
            {
                Log.Debug(context.Indent() + "{0}", member.Name);
                ImportArgs(member, tool, context);
            }
            context.DecreaseIndent();
        }
    }

    public void Gather(IGatheringContext context)
    {
        Log.Information(context.Indent() + "Gathering all classes in UAT");
        GatherClasses(context);

        var buildCommandCandidates = Classes.Values.Where(IsConsidered);
        
        Log.Information(context.Indent() + "Gathering parameters from all classes");
        context.IncreaseIndent();
        buildCommandCandidates.ForEach(c =>
        {
            Log.Debug(context.Indent() + "from {0}", c.Name);
            context.IncreaseIndent();
            GatherFromHelpHeuristics(c, context);
            GatherFromCommandLineArgumentParsers(c, context);
            context.DecreaseIndent();
        });
        context.DecreaseIndent();
        
        Log.Information(context.Indent() + "Extrapolating tools from the relations of gathered classes");
        context.IncreaseIndent();
        buildCommandCandidates.ForEach(c =>
        {
            Log.Debug(context.Indent() + "from {0}", c.Name);
            var tool = CreateSubtool(c, context);
            ImportArgs(c, tool, context);
            if (context is IHaveSubTools contextSubtools)
            {
                contextSubtools.SubTools.Add(tool);
            }
        });
        context.DecreaseIndent();
    }
}