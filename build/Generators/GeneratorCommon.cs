using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using System.Text.RegularExpressions;
using Humanizer;
using Nuke.Common.Utilities;

namespace build.Generators;

public static partial class GeneratorCommon
{
    private static readonly List<string> Reserved = new()
    {
        "Name",
        "CliName",
        "Compatibility",
        "UsingArguments",
        "UsingSubtools",
        "Configs",
        "Append",
        "AppendArgument",
        "AppendSubtool",
        "Gather",
        "If",

        "Type",
        "abstract",
        "as",
        "base",
        "bool",
        "break",
        "byte",
        "case",
        "catch",
        "char",
        "checked",
        "class",
        "const",
        "continue",
        "decimal",
        "default",
        "delegate",
        "do",
        "double",
        "else",
        "enum",
        "event",
        "explicit",
        "extern",
        "false",
        "finally",
        "fixed",
        "float",
        "for",
        "foreach",
        "goto",
        "if",
        "implicit",
        "in",
        "int",
        "interface",
        "internal",
        "is",
        "lock",
        "long",
        "namespace",
        "new",
        "null",
        "object",
        "operator",
        "out",
        "override",
        "params",
        "private",
        "protected",
        "public",
        "readonly",
        "ref",
        "return",
        "sbyte",
        "sealed",
        "short",
        "sizeof",
        "stackalloc",
        "static",
        "string",
        "struct",
        "switch",
        "this",
        "throw",
        "true",
        "try",
        "typeof",
        "uint",
        "ulong",
        "unchecked",
        "unsafe",
        "ushort",
        "using",
        "virtual",
        "void",
        "volatile",
        "while",
    };

    [GeneratedRegex("[^a-zA-Z0-9_]")]
    private static partial Regex InvalidCharacters();
    public static string EnsureIdentifierCompatibleName(this string name)
    {
        var curedName = name.Trim();
        var result = curedName[0] switch
            {
                '_' => curedName,
                '-' => curedName.Substring(1),
                >= 'a' and <= 'z' => curedName,
                >= 'A' and <= 'Z' => curedName,
                _ => "_" + curedName
            };
        result = InvalidCharacters().Replace(result, "_").Pascalize();
        return Reserved.Any(r => r == result) ? "_" + result : result;
    }
}