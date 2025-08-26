using System;
using System.ComponentModel;
using System.Linq;
using Newtonsoft.Json;
using Nuke.Common.Tooling;

namespace Nuke.Unreal
{
    [TypeConverter(typeof(TypeConverter<AndroidProcessorArchitecture>))]
    [JsonConverter(typeof(EnumerationJsonConverter<AndroidProcessorArchitecture>))]
    public class AndroidProcessorArchitecture : Enumeration
    {
        public static readonly AndroidProcessorArchitecture Arm = new()
        {
            Value = nameof(Arm),
            AltName = "arm",
            AbiName = "armeabi-v7a"
        };
        public static readonly AndroidProcessorArchitecture Arm64 = new()
        {
            Value = nameof(Arm64),
            AltName = "aarch64",
            AbiName = "arm64-v8a"
        };
        public static readonly AndroidProcessorArchitecture X86 = new()
        {
            Value = nameof(X86),
            AltName = "i386",
            AbiName = "x86"
        };
        public static readonly AndroidProcessorArchitecture X86_64 = new()
        {
            Value = nameof(X86_64),
            AltName = "x86_64",
            AbiName = "x86_64"
        };

        public required string AltName { get; init; }
        public required string AbiName { get; init; }

        public static implicit operator string(AndroidProcessorArchitecture configuration)
        {
            return configuration.Value;
        }
    }
}