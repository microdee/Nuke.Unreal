using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using Nuke.Common.Tooling;
using Newtonsoft.Json;
using Nuke.Cola;
using Nuke.Common;
using Nuke.Common.Utilities;

namespace Nuke.Unreal
{
    /// <summary>
    /// Bit-field representation of Unreal platforms and platform-families
    /// </summary>
    [Flags]
    public enum UnrealPlatformFlag : UInt16
    {
        Win64 =       1 << 0,
        Win32 =       1 << 1,
        // TODO: Windows ARM64?
        HoloLens =    1 << 2,
        Mac =         1 << 3,
        Linux =       1 << 4,
        LinuxArm64 =  1 << 5,
        Android =     1 << 6,
        IOS =         1 << 7,
        TVOS =        1 << 8,
        VisionOS =    1 << 9,
        AllWin =      Win32 | Win64,
        AllLinux =    Linux | LinuxArm64,
        AllDesktop =  AllWin | AllLinux | Mac,
        Independent = 0xFFFF

        // TODO: rest of the platforms
        // Engine/Source/Programs/UnrealBuildTool/Configuration/UEBuildTarget.cs
    }

    public class UnrealPlatformJsonConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return objectType.IsClass && objectType.IsAssignableTo(typeof(UnrealPlatform));
        }

        public override object? ReadJson(JsonReader reader, Type objectType, object? existingValue, JsonSerializer serializer)
        {
            if (reader.Value is string value)
            {
                return UnrealPlatform.Parse(value);
            }
            Assert.True(reader.TokenType == JsonToken.None
                || reader.TokenType == JsonToken.Null
                || reader.TokenType == JsonToken.Undefined,
                $"JSON value was neither a string, nor one of the 'not-existing' types. Token type: {reader.TokenType}; Object type: {objectType.Name};"
            );
            return null;
        }

        public override void WriteJson(JsonWriter writer, object? value, JsonSerializer serializer)
        {
            if (value is UnrealPlatform platform)
            {
                writer.WriteValue(platform.UserDefinedName ?? platform.ToString());
            }
        }
    }

    /// <summary>
    /// High level representation of common platforms supported by Unreal Engine (NDA ones excluded)
    /// and extra metadata about platform specific intricacies.
    /// </summary>
    [TypeConverter(typeof(TypeConverter<UnrealPlatform>))]
    [JsonConverter(typeof(UnrealPlatformJsonConverter))]
    public class UnrealPlatform : Enumeration, ICloneable<UnrealPlatform>
    {
        /// <summary>
        /// Any platform name containing 'Windows' is also mapped to this platform
        /// </summary>
        public static readonly UnrealPlatform Win64 = new()
        {
            Value = nameof(Win64),
            Flag = UnrealPlatformFlag.Win64,
            DllExtension = "dll"
        };
        public static readonly UnrealPlatform Win32 = new()
        {
            Value = nameof(Win32),
            Flag = UnrealPlatformFlag.Win32,
            Compatibility = UnrealCompatibility.UE_4,
            DllExtension = "dll",
        };
        public static readonly UnrealPlatform HoloLens = new()
        {
            Value = nameof(HoloLens),
            Flag = UnrealPlatformFlag.HoloLens,
            Compatibility = UnrealCompatibility.UE_4,
            DllExtension = "dll",
        };
        
        /// <summary>
        /// Any platform name containing 'Mac' is also mapped to this platform
        /// </summary>
        public static readonly UnrealPlatform Mac = new()
        {
            Value = nameof(Mac),
            Flag = UnrealPlatformFlag.Mac,
            DllExtension = "dylib",
        };
        public static readonly UnrealPlatform Linux = new()
        {
            Value = nameof(Linux),
            Flag = UnrealPlatformFlag.Linux
        };
        public static readonly UnrealPlatform LinuxArm64 = new()
        {
            Value = nameof(LinuxArm64),
            Flag = UnrealPlatformFlag.LinuxArm64
        };
        public static readonly UnrealPlatform Android = new()
        {
            Value = nameof(Android),
            Flag = UnrealPlatformFlag.Android
        };
        public static readonly UnrealPlatform IOS = new()
        {
            Value = nameof(IOS),
            Flag = UnrealPlatformFlag.IOS,
            DllExtension = "dylib",
        };
        public static readonly UnrealPlatform TVOS = new()
        {
            Value = nameof(TVOS),
            Flag = UnrealPlatformFlag.TVOS,
            DllExtension = "dylib",
        };
        public static readonly UnrealPlatform VisionOS = new()
        {
            Value = nameof(VisionOS),
            Flag = UnrealPlatformFlag.VisionOS,
            Compatibility = UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
            DllExtension = "dylib",
        };

        /// <summary>
        /// Meta-platform indicating that its context of operation is platform-independent or has
        /// (should have) the same results on all platforms.
        /// </summary>
        public static readonly UnrealPlatform Independent = new()
        {
            Value = nameof(Independent),
            Flag = UnrealPlatformFlag.Independent,
            DllExtension = "",
            _platformText = ""
        };

        /// <summary>
        /// Get the high-level platform from a bit-field platform flag
        /// </summary
        public static UnrealPlatform FromFlag(UnrealPlatformFlag flag)
        {
            return flag switch
            {
                UnrealPlatformFlag.Win64       => Win64,
                UnrealPlatformFlag.Win32       => Win32,
                // TODO: Windows ARM64?
                UnrealPlatformFlag.HoloLens    => HoloLens,
                UnrealPlatformFlag.Mac         => Mac,
                UnrealPlatformFlag.Linux       => Linux,
                UnrealPlatformFlag.LinuxArm64  => LinuxArm64,
                UnrealPlatformFlag.Android     => Android,
                UnrealPlatformFlag.IOS         => IOS,
                UnrealPlatformFlag.TVOS        => TVOS,
                UnrealPlatformFlag.VisionOS    => VisionOS,
                UnrealPlatformFlag.Independent => Independent,
                _ => throw new Exception($"UnrealPlatformFlag {flag} didn't have matching UnrealPlatform"),
            };
        }

        /// <summary>
        /// List of all "real" platforms
        /// </summary>
        public static readonly List<UnrealPlatform> Platforms =
        [
            Win64,
            Mac,
            Linux,
            LinuxArm64,
            Android,
            IOS,
            TVOS,
            VisionOS,
        ];

        /// <summary>
        /// List of platforms which can support the Unreal Editor
        /// </summary>
        public static readonly List<UnrealPlatform> DevelopmentPlatforms =
        [
            Win64,
            Mac,
            Linux,
        ];

        public UnrealPlatformFlag Flag {get; private set; } = UnrealPlatformFlag.Win64;

        /// <summary>
        /// Which Unreal version this platform is compatible with.
        /// </summary>
        public UnrealCompatibility Compatibility {get; private set; } = UnrealCompatibility.All;

        /// <summary>
        /// The platform specific file extension used for dynamic libraries
        /// </summary>
        public string DllExtension {get; private set; } = "so";

        /// <summary>
        /// In some cases platforms can have multiple names which can be used by project~ and plugin
        /// descriptors. In order to maintain their value during file operations, we maintain these
        /// aliases here, if they're recognized by the parser.
        /// </summary>
        public string? UserDefinedName { get; private set; }

        private string? _platformText = null;

        /// <summary>
        /// This property is used for serialization contexts where maintaining a platform name alias
        /// is important. Use `ToString` or `Value` otherwise.
        /// </summary>
        public string PlatformText => _platformText ?? Value;

        /// <summary>
        /// Is given platform a traditional desktop computer?
        /// </summary>
        public bool IsDesktop => (Flag & UnrealPlatformFlag.AllDesktop) > 0;

        /// <summary>
        /// Can this platform support Unreal Editor?
        /// </summary>
        public bool IsDevelopment => DevelopmentPlatforms.Contains(this);
        
        /// <summary>
        /// Can this platform support Unreal Editor?
        /// </summary>
        public bool IsHost => IsDevelopment;

        public bool IsLinux => (Flag & UnrealPlatformFlag.AllLinux) > 0;
        public bool IsWindows => (Flag & UnrealPlatformFlag.AllWin) > 0;
        
        /// <summary>
        /// Given platform is for handheld devices and/or standalone XR headsets.
        /// </summary>
        public bool IsMobile => (Flag & (UnrealPlatformFlag.Android | UnrealPlatformFlag.IOS | UnrealPlatformFlag.HoloLens | UnrealPlatformFlag.VisionOS)) > 0;

        public override string ToString()
        {
            return Value;
        }

        public UnrealPlatform Clone()
        {
            return new()
            {
                Flag = Flag,
                Compatibility = Compatibility,
                DllExtension = DllExtension,
                UserDefinedName =  UserDefinedName,
                _platformText = _platformText
            };
        }

        object ICloneable.Clone()
        {
            return Clone();
        }

        public static implicit operator string(UnrealPlatform configuration)
        {
            return configuration.ToString();
        }

        /// <summary>
        ///     Attempt to convert a piece of text into a high-level platform representation.
        ///     Platform name aliases/variations are supported:
        ///     <list type="bullet">
        ///         <item>Anything containing 'Windows' will be mapped to `Win64`</item>
        ///         <item>Anything containing 'Mac' will be mapped to `Mac` (like MacOS, MacOSX)</item>
        ///     </list>
        /// </summary>
        /// <exception cref="AggregateException">
        ///     Thrown when the input text cannot be mapped to any of the known platforms.
        /// </exception>
        /// <returns>
        ///     The determined static high-level platform, or a clone of a high-level platform if
        ///     the input name was a platform alias.
        /// </returns>
        public static UnrealPlatform Parse(string platformText)
        {
            if (platformText.ContainsOrdinalIgnoreCase("Windows"))
                return Win64.Clone().With(p => p.UserDefinedName = platformText);
            if (platformText.ContainsOrdinalIgnoreCase("Mac") && platformText != "Mac")
                return Mac.Clone().With(p => p.UserDefinedName = platformText);
            try
            {
                var result = TypeDescriptor.GetConverter(typeof(UnrealPlatform)).ConvertFrom(platformText!);
                Assert.NotNull(result, $"'{platformText}' is not a valid UnrealPlatform");
                return (UnrealPlatform)result!;
            }
            catch (Exception e)
            {
                throw new AggregateException($"'{platformText}' is not a valid UnrealPlatform", e);
            }
        }
    }
}