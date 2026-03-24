using System;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using JetBrains.Annotations;
using Nuke.Common.Tooling;
using Nuke.Common.Utilities;
using Nuke.Common.Utilities.Collections;
using Serilog;
using Serilog.Events;

namespace Nuke.Unreal.Tools;

/// <summary>
/// Version of Nuke's ProcessException which doesn't output the log by default
/// </summary>
public class UnrealProcessException(IProcess process, bool includeOutputInMessage = false)
    : Exception(FormatMessage(process, includeOutputInMessage))
{
    private static string FormatMessage(IProcess process, bool includeOutputInMessage)
    {
        const string indentation = "   ";

        var messageBuilder = new StringBuilder()
            .AppendLine($"Process '{Path.GetFileName(process.FileName)}' exited with code {process.ExitCode}.")
            .AppendLine($"{indentation}> {process.FileName.DoubleQuoteIfNeeded()} {process.Arguments}")
            .AppendLine($"{indentation}@ {process.WorkingDirectory}");

        if (includeOutputInMessage)
        {
            var errorOutput = process.Output.Where(x => x.Type == OutputType.Err).ToList();
            if (errorOutput.Count > 0)
            {
                messageBuilder.AppendLine("Error output:");
                errorOutput.ForEach(x => messageBuilder.Append(indentation).AppendLine(x.Text));
            }
            else if (Log.IsEnabled(LogEventLevel.Verbose))
            {
                messageBuilder.AppendLine("Standard output:");
                process.Output.ForEach(x => messageBuilder.Append(indentation).AppendLine(x.Text));
            }
        }

        return messageBuilder.ToString();
    }

    internal IProcess Process { get; } = process;

    public int ExitCode { get; } = process.ExitCode;
}

public static class UnrealProcessAssert
{
    [AssertionMethod]
    public static IProcess AssertZeroExitCodeNoLog(this IProcess process, bool includeOutputInMessage = false)
    {
        process.AssertWaitForExit();

        if (process.ExitCode != 0)
            throw new UnrealProcessException(process, includeOutputInMessage);

        return process;
    }
}
