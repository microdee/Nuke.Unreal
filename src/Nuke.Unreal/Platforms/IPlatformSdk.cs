using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Nuke.Cola.Tooling;
using Nuke.Common;
using Nuke.Common.IO;

namespace Nuke.Unreal.Platforms;

/// <summary>
/// A record for providing build information for XMake/XRepo when that may be requested
/// </summary>
/// <param name="Arguments"></param>
/// <param name="Platform">
///     XMake compatible platform name. If not specified known common platforms will be inferred.
/// </param>
/// <param name="ToolSetup">
///     Arbitrary modification to the XRepo tool execution
/// </param>
public record class PlatformSdkXMakeData(
    string Arguments,
    string? Platform = null,
    Func<ToolEx, ToolEx>? ToolSetup = null
);

/// <summary>
/// Base interface for implementing the automatic SDK management for a host-target platform pair.
/// </summary>
public interface IPlatformSdk
{
    /// <summary>
    /// The platform used for development, hosting this SDK to cross-compile target platform
    /// </summary>
    UnrealPlatform Host { get; }

    /// <summary>
    /// The platform targeted by given SDK
    /// </summary>
    UnrealPlatform Target { get; }

    /// <summary>
    /// <para>
    ///     Initial setup done when the SDK is first needed by a task in Nuke.Unreal. Download and install SDK files
    ///     here and point Unreal to it via setting process environment variables for example. Even if an SDK is
    ///     already downloaded and installed this Setup function would still need to connect Unreal to that.
    /// </para>
    /// </summary>
    /// <param name="build">
    ///     Current Unreal project, set or get data from it, as that's necessary for this platform SDK
    /// </param>
    /// <returns>
    ///     As this can be a long-running process, implementation is recommended to be async
    /// </returns>
    Task Setup(IUnrealBuild build);

    /// <summary>
    /// Would this SDK be ever valid for the given Unreal project. This check is done before Setup is called.
    /// It shouldn't yet check if SDK is available locally, only that it can be made available at some point in the
    /// future.
    /// For checking if an installed SDK is available locally use <see cref="Exists"/>
    /// </summary>
    bool IsValid(IUnrealBuild build);

    /// <summary>
    ///     A shared user folder for this SDK version, owned by Nuke.Unreal. This may be a parent folder to store all
    ///     the separate SDK versions. To get the path directly to the currently used SDK use <see cref="GetSdkPath"/>
    /// </summary>
    AbsolutePath GetSdkVersionsPath(IUnrealBuild build) => PlatformSdkManager.PlatformSdkRoot / Host / Target;

    /// <summary>
    ///     The root of the currently used platform SDK in the file system, if there's one.
    /// </summary>
    AbsolutePath GetSdkPath(IUnrealBuild build);

    /// <summary>
    ///     Get the path to a C++ toolchain folder which may be used to compile external C++ code with to maintain
    ///     ABI compatibility if that code needs to link with Unreal.
    /// </summary>
    AbsolutePath GetToolchainPath(IUnrealBuild build) => GetSdkPath(build);

    /// <summary>
    ///     Whether a valid platform SDK exists locally for given project, and is ready to use without further
    ///     downloading and installation.
    /// </summary>
    bool Exists(IUnrealBuild build) => IsValid(build) && GetSdkPath(build).DirectoryExists();

    /// <summary>
    ///     If applicable and XMake can work with the toolchains provided by this SDK, return information for it
    ///     how to do so.
    /// </summary>
    /// <param name="build"></param>
    /// <returns></returns>
    PlatformSdkXMakeData? GetXMakeData(IUnrealBuild build) => null;
}
