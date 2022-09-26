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

    [TypeConverter(typeof(TypeConverter<UnrealPlatform>))]
    public class UnrealPlatform : Enumeration
    {
        public static UnrealPlatform Win64 = new()
        {
            Value = nameof(Win64),
            Flag = UnrealPlatformFlag.Win64
        };
        public static UnrealPlatform Win32 = new()
        {
            Value = nameof(Win32),
            Flag = UnrealPlatformFlag.Win32
        };
        public static UnrealPlatform HoloLens = new()
        {
            Value = nameof(HoloLens),
            Flag = UnrealPlatformFlag.HoloLens
        };
        public static UnrealPlatform Mac = new()
        {
            Value = nameof(Mac),
            Flag = UnrealPlatformFlag.Mac
        };
        public static UnrealPlatform Linux = new()
        {
            Value = nameof(Linux),
            Flag = UnrealPlatformFlag.Linux
        };
        public static UnrealPlatform LinuxAArch64 = new()
        {
            Value = nameof(LinuxAArch64),
            Flag = UnrealPlatformFlag.LinuxAArch64
        };
        public static UnrealPlatform Android = new()
        {
            Value = nameof(Android),
            Flag = UnrealPlatformFlag.Android
        };
        public static UnrealPlatform IOS = new()
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
                _ => null,
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