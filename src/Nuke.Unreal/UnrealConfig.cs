using System;
using System.ComponentModel;
using System.Linq;
using Nuke.Common.Tooling;

namespace Nuke.Unreal
{
    [TypeConverter(typeof(TypeConverter<UnrealConfig>))]
    public class UnrealConfig : Enumeration
    {
        public static readonly UnrealConfig Debug = new() { Value = nameof(Debug) };
        public static readonly UnrealConfig DebugGame = new() { Value = nameof(DebugGame) };
        public static readonly UnrealConfig Development = new() { Value = nameof(Development) };
        public static readonly UnrealConfig Shipping = new() { Value = nameof(Shipping) };
        public static readonly UnrealConfig Test = new() { Value = nameof(Test) };

        public static implicit operator string(UnrealConfig configuration)
        {
            return configuration.Value;
        }
    }
}