using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using Nuke.Common.Tooling;

namespace Nuke.Unreal
{
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

    [TypeConverter(typeof(TypeConverter<UnrealPlatform>))]
    public class UnrealPlatform : Enumeration
    {
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
        public static readonly UnrealPlatform Independent = new()
        {
            Value = nameof(Independent),
            Flag = UnrealPlatformFlag.Independent,
            DllExtension = "",
            _platformText = ""
        };

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

        public static readonly IEnumerable<UnrealPlatform> Platforms =
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

        public static readonly IEnumerable<UnrealPlatform> DevelopmentPlatforms =
        [
            Win64,
            Mac,
            Linux,
        ];

        public UnrealPlatformFlag Flag { get; private set; } = UnrealPlatformFlag.Win64;
        public UnrealCompatibility Compatibility { get; private set; } = UnrealCompatibility.All;
        public string DllExtension { get; private set; } = "so";
        private string? _platformText = null;

        public string PlatformText => _platformText ?? Value;
        public bool IsDesktop => (Flag & UnrealPlatformFlag.AllDesktop) > 0;
        public bool IsLinux => (Flag & UnrealPlatformFlag.AllLinux) > 0;
        public bool IsWindows => (Flag & UnrealPlatformFlag.AllWin) > 0;
        public bool IsMobile => (Flag & (UnrealPlatformFlag.Android | UnrealPlatformFlag.IOS | UnrealPlatformFlag.HoloLens | UnrealPlatformFlag.VisionOS)) > 0;

        public static implicit operator string(UnrealPlatform configuration)
        {
            return configuration.Value;
        }
    }
}