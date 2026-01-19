using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Nuke.Common;
using Nuke.Common.IO;

namespace Nuke.Unreal.Platforms;

public interface IPlatformSdk
{
    UnrealPlatform Host { get; }

    UnrealPlatform Target { get; }

    Task Setup(INukeBuild self);

    bool IsValid(INukeBuild self);

    AbsolutePath GetSdkVersionsPath(INukeBuild self) => PlatformSdkManager.PlatformSdkRoot / Host / Target;

    AbsolutePath GetSdkPath(INukeBuild self);

    AbsolutePath GetToolchainPath(INukeBuild self) => GetSdkPath(self);

    bool Exists(INukeBuild self) => IsValid(self) && GetSdkPath(self).DirectoryExists();
}
