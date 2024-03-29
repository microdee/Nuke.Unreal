using Towel;
using Towel.DataStructures;
using System.Collections.Generic;
using System;

namespace build.Generators;
public interface IGatheringContext { }

public interface IHaveSubTools
{
    ToolModel MainTool { get; }
    List<ToolModel> SubTools { get; }
}

public interface IHaveEngineCompatibility
{
    UnrealCompatibility Compatibility { get; }
}

public interface IHaveLogDisplayInfo
{
    int Indentation { get; set; }
}

public static class LogDisplayInfoExtensions
{
    public static string Indent(this IGatheringContext context) =>
        "  ".Repeat((context as IHaveLogDisplayInfo)?.Indentation ?? 1);

    public static int IncreaseIndent(this IGatheringContext context)
    {
        if (context is IHaveLogDisplayInfo logDisplayInfo)
        {
            return logDisplayInfo.Indentation++;
        }
        return 0;
    }

    public static int DecreaseIndent(this IGatheringContext context)
    {
        if (context is IHaveLogDisplayInfo logDisplayInfo)
        {
            return logDisplayInfo.Indentation--;
        }
        return 0;
    }
}

public sealed class Indentation : IDisposable
{
    private IGatheringContext _context;
    public Indentation(IGatheringContext context)
    {
        _context = context;
        _context.IncreaseIndent();
    }

    public static string operator >>(Indentation a, string b) => a._context.Indent() + b;

    public void Dispose() => _context.DecreaseIndent();
}