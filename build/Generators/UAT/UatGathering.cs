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
        - UE4Build (in UE4)
        - UnrealBuild (in UE5)
        - LocalizationProvider (+ implementations)

    Just completely ignore these because they're doing 100% runtime command line parsing, which
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
    public const string UnrealBuild = nameof(UnrealBuild);
    public const string LocalizationProvider = nameof(LocalizationProvider);
    public const string GlobalCommandLine = nameof(GlobalCommandLine);
    public const string CommandLineArg = nameof(CommandLineArg);

    public static readonly List<string> SpeciallyConsideredClasses = new()
    {
        Program,
        ProjectParams,
        Automation,
        CodeSign,
        McpConfigMapper,
        P4Environment,
        UE4Build,
        UnrealBuild,
        LocalizationProvider
    };
}

public static class ExcludedClass
{
    public const string MegaXGE = nameof(MegaXGE);
}

public partial class UatGathering : CSharpSourceGatherer
{
    public UatGathering(params AbsolutePath[] root) : base(root) {}

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
        var compatibility = (context as IHaveEngineCompatibility)?.Compatibility ?? UnrealCompatibility.All;
        var paramGetterInvocations = from.Declarations.SelectMany(c => c.Declaration
            .DescendantNodes().OfType<InvocationExpressionSyntax>()
            .Where(n => ParamGetterInvocationRegex().IsMatch(n.ToString()))
        );
        
        if (!paramGetterInvocations.IsNullOrEmpty())
        {
            Log.Debug(context.Indent() + "Using commandline argument parsers.");
        }

        using var indent = new Indentation(context);

        foreach(var invocation in paramGetterInvocations)
        {
            var cliName = invocation.ArgumentList.Arguments.SelectMany(i => i.DescendantNodes())
                .OfType<LiteralExpressionSyntax>()
                .Where(n => n.IsKind(SyntaxKind.StringLiteralExpression))
                .Select(n => n.Token.ValueText)
                .Where(n => !string.IsNullOrWhiteSpace(n))
                .FirstOrDefault();
            
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

            var memberCandidate = from.PropertiesAndFields
                .FirstOrDefault(m => m
                    .GetMemberName()
                    .MemberAssociable(csharpName)
                );

            var documentation = memberCandidate.GetLeadingXmlDocs();
            var outCsharpName = csharpName.Replace("UE4", "Unreal");
            
            var existing = from.AddArgument(
                new ArgumentModel() {
                    ConfigName = outCsharpName,
                    CliName = (cliName[0] == '-' ? "" : "-") + cliName,
                    ArgumentType = ArgumentModelType.TextCollection,
                    Compatibility = new() { compatibility }
                }.AddRootlessXmlDocs(documentation)
            );
            if (existing == null)
            {
                Log.Debug(indent >> "{0} {1}", cliName, outCsharpName);
            }
        }
    }

    protected void GatherFromParsedCommandLineDictionaryInProgramClass(IGatheringContext context)
    {
        Log.Information(context.Indent() + "Gathering global arguments from Program class.");
        var compatibility = (context as IHaveEngineCompatibility)?.Compatibility ?? UnrealCompatibility.All;
        var program = Classes[UniqueClass.Program];

        var parseCommandLineMethod = program.Declarations.SelectMany(c => c.Declaration
            .DescendantNodes()
            .OfType<MethodDeclarationSyntax>()
            .Where(m => m.Identifier.Text == "ParseCommandLine")
        )
        .FirstOrDefault();
        if (parseCommandLineMethod == null) return;

        var paramDictionaryInitializers = parseCommandLineMethod
            .DescendantNodes()
            .OfType<ObjectCreationExpressionSyntax>()
            .Where(o => o.Type.ToFullString().Trim() == "ParsedCommandLine")
            .SelectMany(o => o
                .DescendantNodes()
                .OfType<ObjectCreationExpressionSyntax>()
                .Where(d => d.Type.ToFullString().Trim() == "Dictionary<string, string>")
            )
            .SelectMany(d => d
                .DescendantNodes()
                .OfType<InitializerExpressionSyntax>()
                .Where(i => i.IsKind(SyntaxKind.ComplexElementInitializerExpression))
                .Where(i => i.Expressions.Count == 2)
            );

        using var indent = new Indentation(context);
        foreach(var paramDeclarer in paramDictionaryInitializers)
        {
            var literals = paramDeclarer
                .DescendantNodes()
                .OfType<LiteralExpressionSyntax>()
                .Where(l => l.IsKind(SyntaxKind.StringLiteralExpression))
                .Select(l => l.Token.ValueText)
                .ToArray();

            if (literals.Length != 2)
            {
                Log.Error(indent >> "Command line parameter declaring initializer didn't contain 2 arguments.");
                continue;
            }
            
            var cliName = literals[0];
            var csharpName = cliName.Replace("-", "").EnsureIdentifierCompatibleName();
            var docs = literals[1];
            
            var argument = new ArgumentModel()
            {
                CliName = cliName,
                ConfigName = csharpName,
                ArgumentType = ArgumentModelType.TextCollection,
                ValueSetter = "=",
                Compatibility = new() { compatibility }
            }.AddSummary(docs);
            var existing = program.AddArgument(argument);
            if (existing == null)
            {
                Log.Debug(indent >> "{0} {1}", argument.CliName, argument.ConfigName);
            }
        }
    }

    [GeneratedRegex(@"(?<NAME>[\w-]+)((?<SETTER>[:=]).*)?")]
    private static partial Regex ArgumentFromHelp();

    protected void GatherFromHelpHeuristics(ClassInfo from, IGatheringContext context)
    {
        var compatibility = (context as IHaveEngineCompatibility)?.Compatibility ?? UnrealCompatibility.All;
        var commandHelpAttributes = from.HelpAttributes
            .Where(a => a
                .DescendantNodes()
                .OfType<AttributeArgumentSyntax>()
                .Count() == 2
            );
        
        if (!commandHelpAttributes.IsNullOrEmpty())
        {
            Log.Debug(context.Indent() + "Using Help attribute heuristics");
        }

        using var indent = new Indentation(context);
        foreach(var attr in commandHelpAttributes)
        {
            var arguments = attr
                .DescendantNodes()
                .OfType<AttributeArgumentSyntax>()
                .SelectMany(a => a
                    .DescendantNodes()
                    .OfType<LiteralExpressionSyntax>()
                    .Where(l => l.IsKind(SyntaxKind.StringLiteralExpression))
                )
                .ToArray();
            if (arguments.Length != 2) continue;

            var regexMatch = ArgumentFromHelp().Match(arguments[0].Token.ValueText);
            if (regexMatch?.Groups?["NAME"] == null) continue;

            var cliName = regexMatch.Groups["NAME"].Value;
            var csharpName = regexMatch.Groups["NAME"].Value.Replace("-", "").EnsureIdentifierCompatibleName();
            var outCsharpName = csharpName.Replace("UE4", "Unreal");

            var argument = new ArgumentModel()
            {
                CliName = (cliName[0] == '-' ? "" : "-") + cliName,
                ConfigName = outCsharpName,
                ArgumentType = ArgumentModelType.TextCollection,
                ValueSetter = regexMatch.Groups["SETTER"]?.Value ?? "=",
                Compatibility = new() { compatibility }
            }.AddSummary(arguments[1].Token.ValueText);
            var existing = from.AddArgument(argument);
            if (existing == null)
            {
                Log.Debug(indent >> "{0} {1}", argument.CliName, argument.ConfigName);
            }
        }
    }

    protected void GatherGlobalCommandLine(IGatheringContext context)
    {
        var compatibility = (context as IHaveEngineCompatibility)?.Compatibility ?? UnrealCompatibility.All;
        var globalArgDecls = Classes[UniqueClass.GlobalCommandLine]
            .Declarations.SelectMany(d => d.Declaration.DescendantNodes())
            .OfType<FieldDeclarationSyntax>()
            .Where(f => f.Declaration.Type.ToString() == UniqueClass.CommandLineArg);

        if (!globalArgDecls.IsNullOrEmpty())
        {
            Log.Debug(context.Indent() + "Gathering from GlobalCommandLine");
        }

        using var indent = new Indentation(context);
        foreach(var field in globalArgDecls)
        {
            var csName = field.Declaration.Variables.Select(v => v.Identifier.Text).FirstOrDefault();
            var cliName = field.Declaration.Variables
                .SelectMany(v => v
                    .DescendantNodes()
                    .OfType<ObjectCreationExpressionSyntax>()
                )
                .SelectMany(v => v.ArgumentList.Arguments)
                .SelectMany(a => a
                    .DescendantNodes()
                    .OfType<LiteralExpressionSyntax>()
                    .Where(l => l.IsKind(SyntaxKind.StringLiteralExpression))
                )
                .Select(s => s.Token.ValueText)
                .Where(s => !string.IsNullOrWhiteSpace(s))
                .FirstOrDefault();

            if (!string.IsNullOrWhiteSpace(csName) && !string.IsNullOrWhiteSpace(cliName))
            {
                var outCsharpName = csName.Replace("UE4", "Unreal");
                if (context is IHaveSubTools contextWithSubtools)
                {
                    var documentation = field.GetLeadingXmlDocs();
                    var existing = contextWithSubtools.MainTool.AddArgument(
                        new ArgumentModel() {
                            ConfigName = outCsharpName,
                            CliName = (cliName[0] == '-' ? "" : "-") + cliName,
                            ArgumentType = ArgumentModelType.TextCollection,
                            Compatibility = new() { compatibility }
                        }.AddRootlessXmlDocs(documentation)
                    );
                    if (existing == null)
                    {
                        Log.Debug(indent >> "Global argument: {0} {1}", cliName, outCsharpName);
                    }
                }
            }
        }
    }

    protected void CopyArgumentsToGlobal(string className, IGatheringContext context)
    {
        if (context is IHaveSubTools contextWithSubtools)
        {
            Log.Debug(context.Indent() + "from {0}", className);
            var automationSubtool = contextWithSubtools.SubTools.FirstOrDefault(t => t.ConfigName == className);
            automationSubtool?.Arguments?.ForEach(a => contextWithSubtools.MainTool.AddArgument(a));
        }
    }

    protected ToolModel CreateSubtool(ClassInfo from, IGatheringContext context)
    {
        var compatibility = (context as IHaveEngineCompatibility)?.Compatibility ?? UnrealCompatibility.All;
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
            .Select(s => s.Token.ValueText)
            .Where(s => !string.IsNullOrWhiteSpace(s));

        var outCsharpName = from.Name.Replace("UE4", "Unreal");

        var tool = new ToolModel {
            ConfigName = outCsharpName,
            ConfigType = new(outCsharpName + "Config", outCsharpName + "Config"),
            CliName = from.Implements(UniqueClass.BuildCommand) == null ? "" : from.Name,
            Compatibility = new() { compatibility }
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
            using var indent = new Indentation(context);
            foreach(var import in typeImportsFromHelp)
            {
                if (Classes.TryGetValue(import, out var classInfo))
                {
                    Log.Debug(indent >> "{0}", classInfo.Name);
                    ImportArgs(classInfo, tool, context);
                }
            }
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
            using var indent = new Indentation(context);
            foreach(var member in members)
            {
                Log.Debug(indent >> "{0}", member.Name);
                ImportArgs(member, tool, context);
            }
        }
    }

    public void Gather(IGatheringContext context)
    {
        Log.Information(context.Indent() + "Gathering all classes in UAT");
        GatherClasses(context);

        var buildCommandCandidates = Classes.Values.Where(IsConsidered);
        GatherFromParsedCommandLineDictionaryInProgramClass(context);
        GatherGlobalCommandLine(context);
        
        Log.Information(context.Indent() + "Gathering parameters from all classes");
        using(var indentA = new Indentation(context))
            buildCommandCandidates.ForEach(c =>
            {
                Log.Debug(indentA >> "from {0}", c.Name);
                using var indentB = new Indentation(context);
                GatherFromHelpHeuristics(c, context);
                GatherFromCommandLineArgumentParsers(c, context);
            });
        
        Log.Information(context.Indent() + "Extrapolating tools from the relations of gathered classes");
        using(var indentA = new Indentation(context))
            buildCommandCandidates.ForEach(c =>
            {
                Log.Debug(indentA >> "from {0}", c.Name);
                var tool = CreateSubtool(c, context);
                ImportArgs(c, tool, context);
                if (context is IHaveSubTools contextSubtools)
                {
                    contextSubtools.SubTools.Add(tool);
                }
            });

        Log.Information(context.Indent() + "Placing commonly used arguments on top tool level");
        using(var indentA = new Indentation(context))
        {
            CopyArgumentsToGlobal(UniqueClass.Automation, context);
            CopyArgumentsToGlobal(UniqueClass.Program, context);
            CopyArgumentsToGlobal(UniqueClass.ProjectParams, context);
            CopyArgumentsToGlobal(UniqueClass.GlobalCommandLine, context);
        }
    }
}