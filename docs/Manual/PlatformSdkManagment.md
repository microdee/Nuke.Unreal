# Platform SDK management {#PlatformSdkManagment}

Vanilla Unreal Engine comes with two ways to semi-automatically manage platform SDK packages for cross-compilation targets. **AutoSDK** and **Turnkey**. Neither of them help with anything. In fact both of them put more mental burden on DevOps engineers, than just manually installing the SDK's somewhere. Actually **AutoSDK** is just that with a naming convention for files and folders. Turnkey actually lets you "script" gathering the platform SDK files but still, you need to know which ones to get and where to get them from.

Nuke.Unreal introduces the concept of **"Platform SDK Management"** which attempts to fully automatically set up the compilation and packaging environment for a given target platform. This feature can also provide C++ toolchain information for external libraries which are compiled separately but will need to link with target Unreal project, as an attempt to have the least amount of ABI difference.

For example: in case of Android it does the following things (when working on Windows):

* Downloads the JDK version recommended by Epic for project's Unreal version
* Fetches if necessary then invokes Android's `sdkmanager` to set up the recommended components by Epic
  * SDK, NDK, BuildTools, CMake
* Sets proper environment variables scoped to the process (and subprocesses, like Unreal tools) pointing to component locations

All of these steps are customizable and are done on-demand with sensible caching. This requires no extra configuration and no extra infrastructure (other than having Nuke.Unreal working on your project of course).

Under the hood, cross-compile platform SDK's are expressed as [`IPlatformSdk`](@ref Nuke.Unreal.Platforms.IPlatformSdk) implementations. Each implementation specifies how to cross compile on a host platform for a target platform. For example the above Android SDK management is implemented in [`WindowsHostsAndroid`](@ref Nuke.Unreal.Platforms.Android.WindowsHostsAndroid).

## NDA platforms

For host-target combinations of platforms which are not imolemented in Nuke.Unreal yet, or game console NDA platforms, you can register your own implementation in your Nuke.Unreal build project:

```csharp
// NintendoVirtualBoy.cs

using Nuke.Unreal;
using Nuke.Unreal.Platforms;

public class WindowsHostsNintendoVirtualBoy : IPlatformSdk
{
    private IPlatformSdk SelfPlatformSdk => this;
    
    public static NintendoVirtualBoy { get; } = new()
    {
        Value = nameof(NintendoVirtualBoy),
        Flag = UnrealPlatformFlag.Independent
    };
    
    public UnrealPlatform Host => UnrealPlatform.Win64;
    public UnrealPlatform Target => NintendoVirtualBoy;
    
    static WindowsHostsNintendoVirtualBoy() => PlatformSdkManager.Register(new WindowsHostsNintendoVirtualBoy());
    
    public bool IsValid(IUnrealBuild build) => /* ... */;
    public async Task Setup(IUnrealBuild build) => /* ... */;
    
    // etc...
    
    // Check the documentation of IPlatformSdk
}
```

And in theory you might be good to go.
