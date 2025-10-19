# Using third-party C++ libraries {#CppLibraries}

[TOC]

Nuke.Unreal allows you to set up boilerplate for C++ libraries, or fetch them via a package manager. In all cases the artifacts it generates are placed in the working directory (the current location of your terminal). In all cases they're managed in their own preparation targets which are generated for you.

There are three methods available:

## Use library from XRepo

[XRepo](https://xrepo.xmake.io) is so far the most reliable C++ package manager I've encountered relying on the build tool by the same people XMake. Nuke.Unreal taps into that ecosystem and has tools to convert their packages into Unreal modules. Tt can be as simply used as the following:

```
> nuke use-xrepo --spec "zlib"
```

or fully specified with version and library options:

```
> nuke use-xrepo --spec "imgui 1.91.1 freetype=true,dx11=true,dx12=true,vulkan=true"
```

and multiple libraries can be set up in one go

```
nuke use-xrepo --spec "imgui 1.91.1 freetype=true" "conan::zlib/1.2.11" "vcpkg::spdlog[wchar]" <etc...>
```

As you can see xrepo also can act like a meta-package-manager for libraries which may not have been added to the xrepo repository. However their support is more limited than xrepo "native" packages.

Video demonstrating the installation of a C++ library.

<a href="https://youtu.be/whSjicxWp8U" target="_blank">

![](CppLibInstallVideo.png)

</a>

`use-xrepo` will not fetch the specified libraries immediately but rather generate build plugins for them, which define `Prepare-<library>` targets. These are all dependent for `Prepare` target of `UnrealBuild` which is then dependent for `Generate`. So after `nuke use-xrepo` running `nuke prepare` or `nuke generate` will fetch and install properly all libraries used in this way. Having an extra build plugin allows the developer to further customize how the library is used, or add extra necessary operations.

### Library specifications

`--spec` follows this syntax:

```
provider::name[comma,separated,features] 1.2.3 comma='separated',options=true
```

> [!NOTE]
> Conan packages use `/` to delimit version (`conan::zlib/1.2.3`) instead of space. VCPKG through xrepo cannot set specific version so attempting to do `vcpkg::zlib 1.2.3` will result in failing installation, but `vcpkg::zlib` is fine.

> [!NOTE]
> Since Unreal requires `MD` C runtime linkage `runtimes='MD'` is implicitly added by Nuke.Unreal.

The `Prepare` and the individual `Prepare-<library>` targets will generate partial module rule classes for the platforms they were invoked for. This is done because libraries may have different requirements based on which platform they're used on / compiled on. The main `MyLibrary.Build.cs` module rule is the place for the developer to add custom logic if that's necessary for the library. Individual `MyLibrary.Platform.Build.cs` partial rules set up includes and libs.

> [!IMPORTANT]
> During installation only one platform is considered, and only one platform worth of module rule class will be generated. This means the library should be prepared with all supported platforms or cross-compiled to be able to deploy in a truly cross-platform fashion.

The main benefit of this design is that libraries prepared this way can be further distributed with source but without the need for Nuke.Unreal, or without the need to execute complex behavior from the module rule files. This ensures for example ~~Marketplace~~/Fab compliance of plugins.

## Use library via CMake

```
nuke use-cmake --spec MyLibrary
```

This generates build plugins allowing the developer to prepare libraries via CMake. Fetching and storing the library is the responsibility of the developer. The build plugin is prepared for the most trivial use case when compiling a library via CMake but one may need to modify that depending on the design decisions of the library being used.

## Use header only library

```
nuke use-header-only --spec MyLibrary
```

This will directly generate only the module rule file without the need for extra preparations like with the xrepo or the CMake methods.