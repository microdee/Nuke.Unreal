using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace build.Generators;

public enum ArgumentModelType
{
    Switch,
    Bool,
    Scalar,
    Text,
    ScalarCollection,
    TextCollection,
}

public class ArgumentModel
{
    public string ConfigName { init; get; }
    public string CliName { init; get; }
    public ArgumentModelType ArgumentType { init; get; }
    public string CollectionSeparator { get; set; } = "+";
    public string ValueSetter { get; set; } = "=";
    public string Description { get; set; } = "No description";
    public string ParametersRenderer => ArgumentType switch
    {
        ArgumentModelType.Switch => "bool present = true",
        ArgumentModelType.Bool => "bool? val = null",
        ArgumentModelType.Scalar => "double? val = null",
        ArgumentModelType.Text => "string val = null",
        ArgumentModelType.ScalarCollection => "params double[] values",
        ArgumentModelType.TextCollection => "params string[] values",
        _ => throw new NotImplementedException()
    };

    public string CommandLineRenderer => ArgumentType switch
    {
        ArgumentModelType.Switch => $"present ? \"-{CliName}\" : \"\"",
        ArgumentModelType.Bool => $"val == null ? \"-{CliName}\" : \"-{CliName}{ValueSetter}\" + val.ToString()",
        ArgumentModelType.Scalar => $"val == null ? \"-{CliName}\" : \"-{CliName}{ValueSetter}\" + val.ToString()",
        ArgumentModelType.Text => $"string.IsNullOrWhiteSpace(val) ? \"-{CliName}\" : \"-{CliName}{ValueSetter}\" + val.DoubleQuoteIfNeeded()",
        ArgumentModelType.ScalarCollection =>
            "values != null && values.Length > 0"
            + $" ? \"-{CliName}{ValueSetter}\" + string.Join(\"{CollectionSeparator}\", values)"
            + $" : \"-{CliName}\"",
        ArgumentModelType.TextCollection =>
            "values != null && values.Length > 0"
            + $" ? \"-{CliName}{ValueSetter}\" + string.Join(\"{CollectionSeparator}\", values.DoubleQuoteIfNeeded())"
            + $" : \"-{CliName}\"",
        _ => throw new NotImplementedException()
    };
}