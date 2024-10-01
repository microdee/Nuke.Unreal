using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using Nuke.Common.Tooling;

namespace Nuke.Unreal
{
    [Flags]
    public enum UnrealPlatformFlag
    {
        Win64 =         0b_00000001,
        Win32 =         0b_00000010,
        HoloLens =      0b_00000100,
        Mac =           0b_00001000,
        Linux =         0b_00010000,
        LinuxAArch64 =  0b_00100000,
        Android =       0b_01000000,
        IOS =           0b_10000000,
        AllWin =        Win32  | Win64,
        AllLinux =      Linux  | LinuxAArch64,
        AllDesktop =    AllWin | AllLinux | Mac

        // TODO: rest of the platforms
        // Engine/Source/Programs/UnrealBuildTool/Configuration/UEBuildTarget.cs
    }

    [TypeConverter(typeof(TypeConverter<UnrealPlatform>))]
    public class UnrealPlatform : Enumeration
    {
        public static readonly UnrealPlatform Win64 = new()
        {
            Value = nameof(Win64),
            Flag = UnrealPlatformFlag.Win64
        };
        public static readonly UnrealPlatform Win32 = new()
        {
            Value = nameof(Win32),
            Flag = UnrealPlatformFlag.Win32
        };
        public static readonly UnrealPlatform HoloLens = new()
        {
            Value = nameof(HoloLens),
            Flag = UnrealPlatformFlag.HoloLens
        };
        public static readonly UnrealPlatform Mac = new()
        {
            Value = nameof(Mac),
            Flag = UnrealPlatformFlag.Mac
        };
        public static readonly UnrealPlatform Linux = new()
        {
            Value = nameof(Linux),
            Flag = UnrealPlatformFlag.Linux
        };
        public static readonly UnrealPlatform LinuxAArch64 = new()
        {
            Value = nameof(LinuxAArch64),
            Flag = UnrealPlatformFlag.LinuxAArch64
        };
        public static readonly UnrealPlatform Android = new()
        {
            Value = nameof(Android),
            Flag = UnrealPlatformFlag.Android
        };
        public static readonly UnrealPlatform IOS = new()
        {
            Value = nameof(IOS),
            Flag = UnrealPlatformFlag.IOS
        };

        public static UnrealPlatform FromFlag(UnrealPlatformFlag flag)
        {
            return flag switch
            {
                UnrealPlatformFlag.Win64        => Win64,
                UnrealPlatformFlag.Win32        => Win32,
                UnrealPlatformFlag.HoloLens     => HoloLens,
                UnrealPlatformFlag.Mac          => Mac,
                UnrealPlatformFlag.Linux        => Linux,
                UnrealPlatformFlag.LinuxAArch64 => LinuxAArch64,
                UnrealPlatformFlag.Android      => Android,
                UnrealPlatformFlag.IOS          => IOS,
                _ => throw new Exception($"UnrealPlatformFlag {flag} didn't have matching UnrealPlatform"),
            };
        }

        public UnrealPlatformFlag Flag { get; private set; } = UnrealPlatformFlag.Win64;

        public bool IsDesktop => (Flag & UnrealPlatformFlag.AllDesktop) > 0;
        public bool IsLinux => (Flag & UnrealPlatformFlag.AllLinux) > 0;
        public bool IsWindows => (Flag & UnrealPlatformFlag.AllWin) > 0;
        public bool IsMobile => (Flag & (UnrealPlatformFlag.Android | UnrealPlatformFlag.IOS | UnrealPlatformFlag.HoloLens)) > 0;

        public static implicit operator string(UnrealPlatform configuration)
        {
            return configuration.Value;
        }
    }
}