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

public class ArgumentModel : CommandLineEntity
{
    public ArgumentModelType ArgumentType { init; get; }
    public string CollectionSeparator { get; set; } = "+";
    public string ValueSetter { get; set; } = "=";
    public EnumData Enum { get; set; }
    public bool IsCollectionMultipleArgs { get; set; }
    public bool IsCollection => ArgumentType >= ArgumentModelType.ScalarCollection;
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
        ArgumentModelType.Switch => "null",
        
        ArgumentModelType.Bool or
        ArgumentModelType.Scalar or
        ArgumentModelType.Enum or
        ArgumentModelType.Text => $"val?.ToString()",

        ArgumentModelType.ScalarCollection or
        ArgumentModelType.EnumCollection or
        ArgumentModelType.TextCollection =>
            "values != null && values.Length > 0"
            + $" ? string.Join(\"{CollectionSeparator}\", values)"
            + $" : null",

        _ => throw new NotImplementedException()
    };

    public string Condition => ArgumentType switch
    {
        ArgumentModelType.Switch => "present",
        _ => "true"
    };
}