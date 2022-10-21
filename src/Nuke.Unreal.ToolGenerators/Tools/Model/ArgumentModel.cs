using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nuke.Unreal.ToolGenerators.Tools.Model;

public enum ArgumenModelType
{
    Switch,
    Scalar,
    Text,
    ScalarCollection,
    TextCollection,
}

public class ArgumentModel
{
    public string ConfigName { init; get; }
    public string CliName { init; get; }
    public ArgumenModelType ArgumentType { init; get; }
    public string CollectionSeparator { get; set; } = "+";
    public string ValueSetter { get; set; } = "=";
    public string Description { get; set; } = "No description";
    public string ParametersRenderer => ArgumentType switch
    {
        ArgumenModelType.Switch => "bool present = true",
        ArgumenModelType.Scalar => "double? val = null",
        ArgumenModelType.Text => "string val = null",
        ArgumenModelType.ScalarCollection => "params double[] values",
        ArgumenModelType.TextCollection => "params string[] values",
        _ => throw new NotImplementedException()
    };

    public string CommandLineRenderer => ArgumentType switch
    {
        ArgumenModelType.Switch => $"present ? \"-{CliName}\" : \"\"",
        ArgumenModelType.Scalar => $"val == null ? \"-{CliName}\" : \"-{CliName}{ValueSetter}\" + val.ToString()",
        ArgumenModelType.Text => $"string.IsNullOrWhiteSpace(val) ? \"-{CliName}\" : \"-{CliName}{ValueSetter}\" + val.DoubleQuoteIfNeeded()",
        ArgumenModelType.ScalarCollection =>
            "values != null && values.Length > 0"
            + $" ? \"-{CliName}{ValueSetter}\" + string.Join(\"{CollectionSeparator}\", values)"
            + $" : \"-{CliName}\"",
        ArgumenModelType.TextCollection =>
            "values != null && values.Length > 0"
            + $" ? \"-{CliName}{ValueSetter}\" + string.Join(\"{CollectionSeparator}\", values.DoubleQuoteIfNeeded())"
            + $" : \"-{CliName}\"",
        _ => throw new NotImplementedException()
    };
}