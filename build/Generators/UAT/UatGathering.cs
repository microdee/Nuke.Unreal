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

public partial class UatGathering
{
    public readonly UatSolution Solution;
    public readonly Dictionary<string, ClassInfo> Classes = new();

    public UatGathering(AbsolutePath automationToolRoot)
    {
        Solution = new(automationToolRoot);
    }

    protected void GatherClasses()
    {
        Dictionary<string, ClassInfo> baseClassRequests = new();
        foreach(var csClass in Solution.Files.SelectMany(f => f.Classes))
        {
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
    }

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
                
            var indentation = "  ".Repeat((context as IHaveLogDisplayInfo)?.Indentation ?? 1);

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
                    CliName = "-" + cliName,
                    ArgumentType = ArgumentModelType.TextCollection
                }.AddRootlessXmlDocs(documentation)
            );
            if (existing != null)
            {
                Log.Information(indentation + "{0} {1}", cliName, csharpName);
            }
        }
    }

    [GeneratedRegex(@"(?<NAME>[\w-]+)((?<SETTER>[:=]).*)?")]
    private static partial Regex ArgumentFromHelp();

    protected void GatherFromHelpHeuristics(ClassInfo from, IGatheringContext context)
    {
        var commandHelpAttributes = from.HelpAttributes
            .Concat(
                from.Declarations.SelectMany(c => c.Declaration
                    .Members
                    .Where(m => m.)
                )
            )
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
                    .DescendantNodes(l => l.IsKind(SyntaxKind.StringLiteralExpression))
                    .Cast<LiteralExpressionSyntax>()
                )
                .ToArray();
            if (arguments.Length != 2) continue;

            var regexMatch = ArgumentFromHelp().Match(arguments[0].Token.Text);
            if (regexMatch?.Groups?["NAME"] == null) continue;

            var argument = new ArgumentModel()
            {
                CliName = regexMatch.Groups["NAME"].Value,
                ConfigName = regexMatch.Groups["NAME"].Value.EnsureIdentifierCompatibleName(),
                ArgumentType = ArgumentModelType.TextCollection,
                ValueSetter = regexMatch.Groups["SETTER"]?.Value ?? "="
            }.AddSummary(arguments[1].Token.Text);
            from.AddArgument(argument);
        }
    }

    public void Gather(IGatheringContext context)
    {
        GatherClasses();

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
        */
    }
}