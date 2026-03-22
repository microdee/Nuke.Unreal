using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Nuke.Cola.Tooling;
using Nuke.Common;
using Nuke.Common.IO;

namespace Nuke.Unreal.Platforms;

public record class PlatformSdkXMakeData(
    string Arguments,
    string? Platform = null,
    Func<ToolEx, ToolEx>? ToolSetup = null
);

public interface IPlatformSdk
{
    UnrealPlatform Host { get; }

    UnrealPlatform Target { get; }

    Task Setup(IUnrealBuild build);

    bool IsValid(IUnrealBuild build);

    AbsolutePath GetSdkVersionsPath(IUnrealBuild build) => PlatformSdkManager.PlatformSdkRoot / Host / Target;

    AbsolutePath GetSdkPath(IUnrealBuild build);

    AbsolutePath GetToolchainPath(IUnrealBuild build) => GetSdkPath(build);

    bool Exists(IUnrealBuild build) => IsValid(build) && GetSdkPath(build).DirectoryExists();

    PlatformSdkXMakeData GetXMakeData(IUnrealBuild build);
}
