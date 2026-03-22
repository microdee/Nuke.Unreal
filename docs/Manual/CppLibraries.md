# Using third-party C++ libraries {#CppLibraries}

[TOC]

Nuke.Unreal allows you to set up boilerplate for C++ libraries, or fetch them via a package manager. In all cases the artifacts it generates are placed in the working directory (the current location of your terminal), and they're managed in their own preparation targets which are generated for you.

There are three methods available:

## Use library from XRepo

[XRepo](https://xrepo.xmake.io) is an emerging C++ package manager relying on the build tool XMake (made by the same people). Nuke.Unreal taps into that ecosystem and has tools to convert their packages into Unreal modules. Tt can be as simply used as the following:

```
> nuke use-xrepo --spec "zlib"
```

or fully specified with version and library options:

```
> nuke use-xrepo --spec "imgui 1.91.1 freetype=true,dx11=true,dx12=true,vulkan=true"
```

and multiple libraries can be set up in one go

```
nuke use-xrepo --spec "imgui 1.91.1 freetype=true" "zlib 1.2.11" "spdlog wchar=true" <etc...>
```

XMake/XRepo can act like a meta-package-manager (using for example `vcpkg::spdlog`) however that feature is not supported by Nuke.Unreal as package information is not consistently reported by XRepo for external package managers. Nuke.Unreal may have support for other package managers in the future on its own properly implemented.

Video demonstrating the installation of a C++ library.

<a href="https://youtu.be/whSjicxWp8U" target="_blank">

![](CppLibInstallVideo.png)

</a>

`use-xrepo` will not fetch the specified libraries immediately but rather generate build plugins for them, which define `Prepare-<library>` targets. These are all dependent for `Prepare` target of `UnrealBuild` which is then dependent for `Generate`. So after `nuke use-xrepo` running `nuke prepare` or `nuke generate` will fetch and install properly all libraries used in this way. Having an extra build plugin allows the developer to further customize how the library is used, add extra necessary operations or change parameters after-the-fact.

### Library specifications

`--spec` follows this syntax:

```
package-name v1.2.3 comma='separated',options=true
```

> [!NOTE]
> Since Unreal requires `MD` C runtime linkage `runtimes='MD'` is implicitly added by Nuke.Unreal.

The `Prepare` and the individual `Prepare-<library>` targets will generate partial module rule classes for the platforms they were invoked for. This is done because libraries may have different requirements based on which platform they're used on / compiled on. The main `MyLibrary.Build.cs` module rule is the place for the developer to add custom logic if that's necessary for the library. Individual `MyLibrary.Platform.Build.cs` partial rules set up includes and libs.

> [!IMPORTANT]
> During installation all supported platforms will be attempted to cross-compile which are set in the owning UPlugin. If no platform is set there, only the one currently being built will be used. Please make sure that the library you're about to depend on is supporting your target platforms, and that you list them in your owning UPlugin. You can also limit the platform for specific library only in their `*.nuke.cs` preparation script.

The main benefit of this design is that libraries prepared this way can be further distributed with source but without the need for Nuke.Unreal, or without the need to execute complex behavior from the module rule files. This ensures for example Fab compliance of plugins.

### Known issues:

Current table of platform support for managing C++ libraries this way. Columns are host development platforms and rows are targeted platforms (cross-compile)

|         | Windows | Linux | Mac¹ |
|--------:|:-------:|:-----:|:----:|
| Windows |    ✔    |   ❌  |  ❌   |
|   Linux |   ⚠️³   |   ✔   |  ❌   |
|   MacOS |    ❌    |   ❌  |  ??  |
| Android |    ✔    |   ✔  |  ??  |
|  Apple² |    ❌    |   ❌  |  ??  |

1. Apple platforms are untested by Nuke.Unreal and I'm not eager to make it work either because of the walled-garden Apple is infamous for
2. IOS / TVOS / VisionOS
3. Nuke.Unreal can manage the cross-compilation toolchain provided by Epic, but XMake has problems using it unfortunately

## Use library via CMake

```
nuke use-cmake --spec MyLibrary
```

This generates build plugins allowing the developer to prepare libraries via CMake. Fetching and storing the library is the responsibility of the developer. The build plugin is prepared for the most trivial use case when compiling a library via CMake but one may need to modify that depending on the design decisions of the library being used.

CMake support currently is pretty barebones but will improve in the future (like adding automatic cross-compile toolchain setup).

## Use header only library

```
nuke use-header-only --spec MyLibrary
```

This will directly generate only the module rule file without the need for extra preparations like with the xrepo or the CMake methods.
