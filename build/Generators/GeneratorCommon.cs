using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using System.Text.RegularExpressions;
using Humanizer;

namespace build.Generators;

public static partial class GeneratorCommon
{
    [GeneratedRegex("[^a-zA-Z0-9_]")]
    private static partial Regex InvalidCharacters();
    public static string EnsureIdentifierCompatibleName(this string name)
    {
        var result = name[0] switch
            {
                '_' => name,
                >= 'a' and <= 'z' => name,
                >= 'A' and <= 'Z' => name,
                _ => "_" + name
            };
        return InvalidCharacters().Replace(result, "_").Pascalize();
    }
}