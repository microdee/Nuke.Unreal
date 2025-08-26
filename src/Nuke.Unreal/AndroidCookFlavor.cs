using System;
using System.ComponentModel;
using System.Linq;
using Newtonsoft.Json;
using Nuke.Common.Tooling;

namespace Nuke.Unreal
{
    [TypeConverter(typeof(TypeConverter<AndroidCookFlavor>))]
    [JsonConverter(typeof(EnumerationJsonConverter<AndroidCookFlavor>))]
    public class AndroidCookFlavor : Enumeration
    {
        public static AndroidCookFlavor Multi = new() { Value = nameof(Multi) };
        public static AndroidCookFlavor ASTC = new() { Value = nameof(ASTC) };
        public static AndroidCookFlavor DXT = new() { Value = nameof(DXT) };
        public static AndroidCookFlavor ETC2 = new() { Value = nameof(ETC2) };

        public static implicit operator string(AndroidCookFlavor configuration)
        {
            return configuration.Value;
        }
    }
}