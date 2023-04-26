using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Nuke.Common.Tooling;
using Nuke.Common.Utilities;
using Nuke.Common.Utilities.Collections;
using Serilog;

namespace Nuke.Unreal.Tools;

public record ToolArguments(
    string Arguments = null,
    string WorkingDirectory = null,
    IReadOnlyDictionary<string, string> EnvironmentVariables = null,
    int? Timeout = null,
    bool? LogOutput = null,
    bool? LogInvocation = null,
    Action<OutputType, string> CustomLogger = null,
    Func<string, string> OutputFilter = null
) {
    public static ToolArguments operator | (ToolArguments a, ToolArguments b)
    {
        var timeOut = Math.Max(a?.Timeout ?? -1, b?.Timeout ?? -1);
        return new() {
            Arguments = string.Join(' ', new [] {a?.Arguments, b?.Arguments}
                .Where(_ => !string.IsNullOrWhiteSpace(_))),

            WorkingDirectory = string.IsNullOrWhiteSpace(a?.WorkingDirectory)
                ? b?.WorkingDirectory
                : a?.WorkingDirectory,
            
            EnvironmentVariables = (a?.EnvironmentVariables == null && b?.EnvironmentVariables == null)
                ? null
                : (a?.EnvironmentVariables ?? new Dictionary<string, string>())
                    .ToDictionary(_ => _.Key, _ => _.Value)
                    .AddDictionary(b?.EnvironmentVariables),

            Timeout = timeOut < 0 ? null : timeOut,

            LogOutput = (a?.LogOutput == null && b?.LogOutput == null)
                ? null
                : (a?.LogOutput ?? false) || (b?.LogOutput ?? false),

            LogInvocation = (a?.LogInvocation == null && b?.LogInvocation == null)
                ? null
                : (a?.LogInvocation ?? false) || (b?.LogInvocation ?? false),

            CustomLogger = (a?.CustomLogger == null && b?.CustomLogger == null)
                ? null
                : b?.CustomLogger ?? a?.CustomLogger,

            OutputFilter = (a?.OutputFilter == null && b?.OutputFilter == null)
                ? null
                : _ => a?.OutputFilter?.Invoke(b?.OutputFilter?.Invoke(_))
        };
    }
}

public static class ToolExtensions
{
    public static IReadOnlyCollection<Output> ExecuteWith(this Tool tool, ToolArguments args) =>
        tool(
            args.Arguments,
            args.WorkingDirectory,
            args.EnvironmentVariables,
            args.Timeout,
            args.LogOutput,
            args.LogInvocation,
            args.CustomLogger,
            args.OutputFilter
        );

    public static Tool With(this Tool tool, ToolArguments args) =>
        new PropagateToolExecution(tool, args).Execute;

    public static Tool With(
        this Tool tool,
        string arguments = null,
        string workingDirectory = null,
        IReadOnlyDictionary<string, string> environmentVariables = null,
        int? timeout = null,
        bool? logOutput = null,
        bool? logInvocation = null,
        Action<OutputType, string> customLogger = null,
        Func<string, string> outputFilter = null
    ) => tool.With(new ToolArguments(
        arguments,
        workingDirectory,
        environmentVariables,
        timeout,
        logOutput,
        logInvocation,
        customLogger,
        outputFilter
    ));

    public static Tool WithSemanticLogging(this Tool tool, Func<string, bool> filter = null, Action<OutputType, string> normalOutputLogger = null) =>
        tool.With(customLogger: (t, l) =>
        {
            if (!(filter?.Invoke(l) ?? true)) return;

            if (l.ContainsAnyOrdinalIgnoreCase("success", "complete", "ready", "start", "***"))
            {
                Log.Information(l);
            }
            else if (l.ContainsOrdinalIgnoreCase("warning"))
            {
                Log.Warning(l);
            }
            else if (l.ContainsAnyOrdinalIgnoreCase("error", "fail"))
            {
                Log.Error(l);
            }
            else
            {
                if (normalOutputLogger != null)
                    normalOutputLogger(t, l);
                else
                {
                    Log.Debug(l);
                }
            }
        });
}

public record PropagateToolExecution(Tool Target, ToolArguments PropagateArguments = null)
{
    public IReadOnlyCollection<Output> Execute(
        string arguments = null,
        string workingDirectory = null,
        IReadOnlyDictionary<string, string> environmentVariables = null,
        int? timeout = null,
        bool? logOutput = null,
        bool? logInvocation = null,
        Action<OutputType, string> customLogger = null,
        Func<string, string> outputFilter = null
    ) => Target.ExecuteWith(
        PropagateArguments | new ToolArguments(
            arguments,
            workingDirectory,
            environmentVariables,
            timeout,
            logOutput,
            logInvocation,
            customLogger,
            outputFilter
        )
    );
}