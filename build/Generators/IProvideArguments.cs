using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Nuke.Common.Utilities;

namespace build.Generators;
public interface IProvideArguments
{
    List<ArgumentModel> Arguments { get; set; }
}

public class ArgumentCollection : IProvideArguments
{
    public List<ArgumentModel> Arguments { get; set; }
}

public static class ArgumentProviderExtensions
{
    public static ArgumentModel AddArgument(this IProvideArguments self, ArgumentModel arg, params IProvideArguments[] alsoSearchIn)
    {
        var compareArgs = alsoSearchIn
            .Append(self)
            .Distinct()
            .SelectMany(t => t.Arguments)
            .Where(a => a.ConfigName.EqualsOrdinalIgnoreCase(arg.ConfigName));
            
        ArgumentModel existing = null;
        foreach(var otherArg in compareArgs)
        {
            otherArg.Enum ??= arg.Enum;
            otherArg.ValueSetter = arg.ValueSetter;
            foreach(var el in arg.DocsRoot.Elements())
            {
                var otherEl = otherArg.DocsRoot.Element(el.Name);
                if (otherEl == null)
                {
                    otherArg.DocsRoot.Add(el.Clone());
                }
                else
                {
                    if (!otherEl.Value.Contains(el.Value))
                        otherEl.Value += Environment.NewLine + el.Value;
                }
            }
            existing = otherArg;
        }
        if (existing == null)
        {
            self.Arguments.Add(arg);
        }
        return existing;
    }
}