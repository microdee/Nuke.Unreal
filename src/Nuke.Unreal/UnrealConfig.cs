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

        public static implicit operator string(UnrealConfig configuration)
        {
            return configuration.Value;
        }
    }

    [TypeConverter(typeof(TypeConverter<ExecMode>))]
    public class ExecMode : Enumeration
    {
        public static ExecMode Standalone = new() { Value = nameof(Standalone) };
        public static ExecMode StandaloneWithEditor = new() { Value = nameof(StandaloneWithEditor) };
        public static ExecMode Editor = new() { Value = nameof(Editor) };

        public static implicit operator string(ExecMode configuration)
        {
            return configuration.Value;
        }
    }
}