using System;
using System.ComponentModel;
using System.Linq;
using Nuke.Common.Tooling;

namespace Nuke.Unreal
{
    [TypeConverter(typeof(TypeConverter<UnrealConfig>))]
    public class UnrealConfig : Enumeration
    {
        public static UnrealConfig Debug = new() { Value = nameof(Debug) };
        public static UnrealConfig DebugGame = new() { Value = nameof(DebugGame) };
        public static UnrealConfig Development = new() { Value = nameof(Development) };
        public static UnrealConfig Shipping = new() { Value = nameof(Shipping) };
        public static UnrealConfig Test = new() { Value = nameof(Test) };

        public static implicit operator string(UnrealConfig configuration)
        {
            return configuration.Value;
        }
    }
}