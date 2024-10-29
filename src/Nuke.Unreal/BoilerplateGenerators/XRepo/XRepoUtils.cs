using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Nuke.Common.Utilities.Collections;

namespace Nuke.Unreal.BoilerplateGenerators.XRepo;

public static class XRepoUtils
{
    public static string ToCorrectString(this XRepoArch arch) => arch.ToString().Replace("__", "-");

    public static XRepoArch GetArch(string from) => Enum.Parse<XRepoArch>(from.Replace("-", "__"));

    public static XRepoArch GetDefaultArch(this XRepoPlatform xrepoPlatform)
        => xrepoPlatform switch
        {
            XRepoPlatform.android   => XRepoArch.arm64__v8a,
            XRepoPlatform.appletvos => XRepoArch.arm64,
            XRepoPlatform.applexros => XRepoArch.arm64,
            XRepoPlatform.bsd       => XRepoArch.x86_64,
            XRepoPlatform.cygwin    => XRepoArch.x86_64,
            XRepoPlatform.haiku     => XRepoArch.x86_64,
            XRepoPlatform.harmony   => XRepoArch.arm64__v8a,
            XRepoPlatform.iphoneos  => XRepoArch.arm64,
            XRepoPlatform.linux     => XRepoArch.x86_64,
            XRepoPlatform.macos     => XRepoArch.arm64,
            XRepoPlatform.mingw     => XRepoArch.x86_64,
            XRepoPlatform.msys      => XRepoArch.x86_64,
            XRepoPlatform.wasm      => XRepoArch.wasm32,
            XRepoPlatform.watchos   => XRepoArch.armv7k,
            XRepoPlatform.windows   => XRepoArch.x64,
            _ => XRepoArch.x86_64,
        };
    
    public static UnrealPlatform? InferUnrealPlatform(this XRepoPlatform xrepoPlatform)
        => xrepoPlatform switch
        {
            XRepoPlatform.windows   => UnrealPlatform.Win64,
            XRepoPlatform.macos     => UnrealPlatform.Mac,
            XRepoPlatform.linux     => UnrealPlatform.Linux,
            XRepoPlatform.android   => UnrealPlatform.Android,
            XRepoPlatform.iphoneos  => UnrealPlatform.IOS,
            XRepoPlatform.appletvos => UnrealPlatform.TVOS,
            XRepoPlatform.applexros => UnrealPlatform.VisionOS,
            _ => null
        };

    public static UnrealPlatform? GetUnrealPlatform(this XRepoPlatformArch xrepoPlatform)
        => xrepoPlatform switch
        {
            { Platform: XRepoPlatform.windows, Arch: XRepoArch.x64 }    => UnrealPlatform.Win64,
            { Platform: XRepoPlatform.windows, Arch: XRepoArch.x86_64 } => UnrealPlatform.Win64,
            { Platform: XRepoPlatform.windows, Arch: XRepoArch.x86 }    => UnrealPlatform.Win32,
            // TODO: Windows ARM64?

            { Platform: XRepoPlatform.linux, Arch: XRepoArch.x64 }        => UnrealPlatform.Linux,
            { Platform: XRepoPlatform.linux, Arch: XRepoArch.x86_64 }     => UnrealPlatform.Linux,
            { Platform: XRepoPlatform.linux, Arch: XRepoArch.arm64 }      => UnrealPlatform.LinuxArm64,
            { Platform: XRepoPlatform.linux, Arch: XRepoArch.arm64__v8a } => UnrealPlatform.LinuxArm64,
            { Platform: XRepoPlatform.linux, Arch: XRepoArch.arm64ec }    => UnrealPlatform.LinuxArm64,

            { Platform: XRepoPlatform.android }   => UnrealPlatform.Android,

            { Platform: XRepoPlatform.macos }     => UnrealPlatform.Mac,
            { Platform: XRepoPlatform.iphoneos }  => UnrealPlatform.IOS,
            { Platform: XRepoPlatform.appletvos } => UnrealPlatform.TVOS,
            { Platform: XRepoPlatform.applexros } => UnrealPlatform.VisionOS,

            _ => null
        };
    
    public static XRepoPlatformArch GetXRepoPlatformArch(this UnrealPlatform platform)
    {
        if (platform == UnrealPlatform.Win64)      return new(XRepoPlatform.windows,   XRepoArch.x64);
        if (platform == UnrealPlatform.Win32)      return new(XRepoPlatform.windows,   XRepoArch.x86);
        if (platform == UnrealPlatform.Linux)      return new(XRepoPlatform.linux,     XRepoArch.x86_64);
        if (platform == UnrealPlatform.LinuxArm64) return new(XRepoPlatform.linux,     XRepoArch.arm64);
        if (platform == UnrealPlatform.Android)    return new(XRepoPlatform.android,   XRepoPlatform.android.GetDefaultArch());
        if (platform == UnrealPlatform.Mac)        return new(XRepoPlatform.macos,     XRepoPlatform.macos.GetDefaultArch());
        if (platform == UnrealPlatform.IOS)        return new(XRepoPlatform.iphoneos,  XRepoPlatform.iphoneos.GetDefaultArch());
        if (platform == UnrealPlatform.TVOS)       return new(XRepoPlatform.appletvos, XRepoPlatform.appletvos.GetDefaultArch());
        if (platform == UnrealPlatform.VisionOS)   return new(XRepoPlatform.applexros, XRepoPlatform.applexros.GetDefaultArch());
        throw new Exception($"{platform} platform was invalid.");
    }

    public static IEnumerable<UnrealPlatform> ParseSupportedPlatforms(string xrepoPlatforms, string arch)
        => xrepoPlatforms switch
        {
            "all" => [
                UnrealPlatform.Win64,
                UnrealPlatform.Mac,
                UnrealPlatform.Linux,
                UnrealPlatform.LinuxArm64,
                UnrealPlatform.Android,
                UnrealPlatform.IOS,
                UnrealPlatform.TVOS,
                UnrealPlatform.VisionOS,
            ],
            _ => xrepoPlatforms.Split(',')
                .Select(p => new XRepoPlatformArch(p.Trim(), arch).GetUnrealPlatform())
                .WhereNotNull()
                .Select(p => p!)
        };
}