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
    Enum,
    ScalarCollection,
    TextCollection,
    EnumCollection,
}

public record EnumEntry(string Name, string DocsXml);
public record EnumData(string Name, string DocsXml, IEnumerable<EnumEntry> Entries);

public class ArgumentModel
{
    public string ConfigName { init; get; }
    public string CliName { init; get; }
    public ArgumentModelType ArgumentType { init; get; }
    public string CollectionSeparator { get; set; } = "+";
    public string ValueSetter { get; set; } = "=";
    public string DocsXml { get; set; } = "";
    public EnumData Enum { get; set; }
    public string ParametersRenderer => ArgumentType switch
    {
        ArgumentModelType.Switch => "bool present = true",
        ArgumentModelType.Bool => "bool? val = null",
        ArgumentModelType.Scalar => "double? val = null",
        ArgumentModelType.Text => "object val = null",
        ArgumentModelType.Enum => $"{Enum.Name}? val = null",
        ArgumentModelType.ScalarCollection => "params double[] values",
        ArgumentModelType.TextCollection => "params object[] values",
        ArgumentModelType.EnumCollection => $"params {Enum.Name}[] values",
        _ => throw new NotImplementedException()
    };

    public string CommandLineRenderer => ArgumentType switch
    {
        ArgumentModelType.Switch => $"present ? \"{CliName}\" : \"\"",
        ArgumentModelType.Bool => $"val == null ? \"{CliName}\" : \"{CliName}{ValueSetter}\" + val.ToString()",
        ArgumentModelType.Scalar => $"val == null ? \"{CliName}\" : \"{CliName}{ValueSetter}\" + val.ToString()",
        ArgumentModelType.Enum => $"val == null ? \"{CliName}\" : \"{CliName}{ValueSetter}\" + val.ToString()",
        ArgumentModelType.Text => $"string.IsNullOrWhiteSpace(val?.ToString()) ? \"{CliName}\" : \"{CliName}{ValueSetter}\" + val.ToString().DoubleQuoteIfNeeded()",
        ArgumentModelType.ScalarCollection =>
            "values != null && values.Length > 0"
            + $" ? \"{CliName}{ValueSetter}\" + string.Join(\"{CollectionSeparator}\", values)"
            + $" : \"{CliName}\"",
        ArgumentModelType.EnumCollection =>
            "values != null && values.Length > 0"
            + $" ? \"{CliName}{ValueSetter}\" + string.Join(\"{CollectionSeparator}\", values)"
            + $" : \"{CliName}\"",
        ArgumentModelType.TextCollection =>
            "values != null && values.Length > 0"
            + $" ? \"{CliName}{ValueSetter}\" + string.Join(\"{CollectionSeparator}\", values.DoubleQuoteIfNeeded())"
            + $" : \"{CliName}\"",
        _ => throw new NotImplementedException()
    };
}