using Towel;
using Towel.DataStructures;
using System.Collections.Generic;

namespace build.Generators;
public interface IGatheringContext { }

public interface IHaveSubTools
{
    List<ToolModel> SubTools { get; }
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