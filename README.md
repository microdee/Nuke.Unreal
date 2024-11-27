<div align="center">

![](docs/nu_logo-250.png)

![](https://badgen.net/nuget/v/md.Nuke.Unreal)

# Nuke.Unreal

</div>

Simplistic workflow for automating Unreal Engine project tasks embracing [Nuke](https://nuke.build), providing a consistent way to use UE4/5 tools and reducing chores they come with.

- [Nuke.Unreal](#nukeunreal)
- [Usage](#usage)
  - [Install via remote script](#install-via-remote-script)
  - [Install manually](#install-manually)
- [Features:](#features)
- [Setting up for a project](#setting-up-for-a-project)
- [Setting up for plugin development](#setting-up-for-plugin-development)
  - [Additional Plugin Targets](#additional-plugin-targets)
- [Generators](#generators)
  - [C# code generators for Unreal tools](#c-code-generators-for-unreal-tools)
  - [Using third-party C++ libraries](#using-third-party-c-libraries)
    - [Use library from xrepo](#use-library-from-xrepo)
    - [Use library via CMake](#use-library-via-cmake)
    - [Use header only library](#use-header-only-library)
  - [Unreal boilerplate templates](#unreal-boilerplate-templates)
    - [Use your own templates](#use-your-own-templates)
- [Custom UBT or UAT arguments from command line](#custom-ubt-or-uat-arguments-from-command-line)
- [Targets](#targets)
  - [Global targets (UnrealBuild)](#global-targets-unrealbuild)
    - [prepare](#prepare)
    - [generate](#generate)
    - [build-editor](#build-editor)
    - [build](#build)
    - [cook](#cook)
    - [clean](#clean)
    - [ensure-build-plugin-support](#ensure-build-plugin-support)
  - [UnrealBuild.Templating](#unrealbuildtemplating)
  - [Packaging (IPackageTargets)](#packaging-ipackagetargets)
    - [package](#package)
  - [Targeting Android (IAndroidTargets)](#targeting-android-iandroidtargets)
    - [apply-sdk-user-settings](#apply-sdk-user-settings)
    - [clean-intermediate-android](#clean-intermediate-android)
    - [sign-apk](#sign-apk)
    - [install-on-android](#install-on-android)
    - [debug-on-android](#debug-on-android)
    - [java-development-service](#java-development-service)
  - [Plugin development (IPluginTargets)](#plugin-development-iplugintargets)
    - [checkout](#checkout)
    - [make-release](#make-release)
    - [pack-plugin](#pack-plugin)
    - [make-marketplace-release](#make-marketplace-release)


# Usage

> [!WARNING]
> `dotnet` is required to be installed first.

## Install via remote script

Navigate to your project with powershell and do

```
Set-ExecutionPolicy Unrestricted -Scope Process -Force; iex (iwr 'https://raw.githubusercontent.com/microdee/Nuke.Unreal/refs/heads/main/install/install.ps1').ToString()
```

1. ***(optional)*** Inherit `IPackageTargets` interface if you want to package the associated Unreal project
2. ***(optional)*** Inherit `IPluginTargets` interface for automating plugin development related steps.

## Install manually

Nuke.Unreal is available as a Nuget package and you can just add it to your build project as usual (package ID is `md.Nuke.Unreal`)

1. <details><summary>Install Nuke for an Unreal project</summary>  
   
   ```
   > dotnet tool install Nuke.GlobalTool --global
   
   > nuke :setup
     select None for solution
     build project inside Nuke.Targets folder
   
   > nuke :add-package md.Nuke.Unreal
   ```
   
   </details>
2. Inherit your Build class from `UnrealBuild` instead of `NukeBuild` and make it `public`
3. Use `Main () => Plugins.Execute<Build>(Execute);` instead of `Main () => Execute();`
4. No further boilerplate required, run `nuke --plan` to test Nuke.Unreal
5. ***(optional)*** Inherit `IPackageTargets` interface if you want to package the associated Unreal project
6. ***(optional)*** Inherit `IPluginTargets` interface for automating plugin development related steps.

Your bare-bones minimal Build.cs which will provide the default features of Nuke.Unreal should look like this:

```CSharp
// Build.cs
using Nuke.Common;
using Nuke.Unreal;
using Nuke.Cola.BuildPlugins;

public class Build : UnrealBuild
{
    public static int Main () => Plugins.Execute<Build>(Execute);
}
```

# Features:

* All what the great Nuke can offer
* Common Unreal build tasks (generate project files, build editor, cook, package, etc)
  ```
  > nuke generate
  > nuke build-editor
  > nuke cook
  > nuke package
  > nuke build --config Shipping
  > nuke build --config DebugGame Development --target-type Game --platform Android
  ```
* Unreal engine location is automatically determined (on Windows at least)
* Prepare plugins for release in Marketplace
  ```
  > nuke make-release --for-marketplace
  ```
* Install C++ libraries (using [xrepo](https://xrepo.xmake.io))
  ```
  > nuke use-xrepo --spec "imgui 1.91.1 freetype=true" "vcpkg::ryml[dbg]" "conan::zlib/1.2.11"
  > nuke generate
  ```
* Generate boilerplate code and scaffolding from [Scriban](https://github.com/scriban/scriban) templates so no editor needs to be opened
    ```
    > nuke new-actor --name MyActor
    > nuke new-plugin --name MyPlugin
    > nuke new-module --name MyModule
    > nuke use-cmake --spec MyLibrary
    etc...
    ```
* Generated C# configurators for Unreal tools with gathered documentation. (UBT and UAT)
* Pluggable way to define targets for reusable plugins and modules

# Setting up for a project

Nuke.Unreal targets looks for the `*.uproject` file automatically and it will use the first one it finds. A `*.uproject` is required to be present even for plugin development (more on plugins below). Automatically found project files can be in the sub-folder tree of Nuke's root (which is the folder containing the `.nuke` temporary folder) or in parent folders of Nuke's root. If for any reason there are more than one or no `*.uproject` files in that area, the developer can specify an explicit location of the associated `*.uproject` file.

```CSharp
public override AbsolutePath ProjectPath => RootDirectory / ".." / "MyProject" / "MyProject.uproject";
```

Only one Unreal project is supported per Nuke.Unreal instance.

# Setting up for plugin development

Same is applicable when Nuke.Unreal is used for developing an Unreal Plugin for release. Of course Nuke.Unreal can work with multiple plugins in a project, but the `IPluginTargets` interface focuses only on one plugin. Again if the plugin is not trivially locatable then the developer can specify its location explicitly.

```CSharp
public AbsolutePath PluginPath => UnrealPluginsFolder / "MyPlugin" / "MyPlugin.uplugin";
```

## Additional Plugin Targets

However plugins which require some pre-processing might benefit from the "[Build plugins](https://github.com/microdee/md.Nuke.Cola?tab=readme-ov-file#build-plugins)" pattern from Nuke.Cola. Simplest method of which is [standalone `*.nuke.cs` files](https://github.com/microdee/md.Nuke.Cola?tab=readme-ov-file#implicitbuildinterface-plugins) which are compiled with the build project. Let's have this scaffolding as an example:

```
<project root>
│   MyUnrealProject.uproject
├── .nuke
├── Content, Build, etc...
├── Nuke.Targets
│       Build.cs
│       Nuke.Targets.csproj (main build script)
├── Plugins
│   └── MyPlugin
│       │   MyPlugin.nuke.cs
│       └── <regular plugin files>
└── Source
    └── MyModule
        │   MyModule.nuke.cs
        └── <source files>
```

Build interfaces (or in Nuke vocabulary "Build Components") decorated with `[ImplicitBuildInterface]` inside these `*.nuke.cs` files will automatically contribute to the build graph without further boilerplate.

```CSharp

// MyModule.nuke.cs
using Nuke.Common;
using Nuke.Cola;
using Nuke.Cola.BuildPlugins;
using Nuke.Unreal;

namespace Nuke.MyModule;

[ImplicitBuildInterface]
public interface IMyModuleTargets : INukeBuild
{
    Target Foo => _ => _
        .DependsOn<IPackageTargets>()
        .Executes(() {...});
}

// MyPlugin.nuke.cs
using Nuke.Common;
using Nuke.Cola;
using Nuke.Cola.BuildPlugins;
using Nuke.Unreal;
namespace Nuke.MyPlugin;

[ImplicitBuildInterface]
public interface IMyPluginTargets : INukeBuild
{
    Target Foo => _ => _
        .Before<UnrealBuild>(u => u.Generate, u => u.Build, u => u.BuildEditor)
        .Executes(() {...});
}
```

# Generators

## C# code generators for Unreal tools

Nuke.Unreal provides builder pattern Unreal tool configurators in C# which yield a command line for the specified tool. TLDR: the syntax looks like this:

```CSharp
// For UBT:
Unreal.BuildTool(this, _ => _
    .Target(UnrealTargetType.Server)
    .Platform(UnrealPlatform.LinuxArm64)
    .Configuration(UnrealConfig.Development)
    .Project(ProjectPath)
    .Append(MyExplicitArguments)
)(workingDirectory: MyEnginePath);

// For UAT:
Unreal.AutomationTool(this, _ => _
    .BuildPlugin(_ => _
        .Plugin(PluginPath)
        .Package(targetDir)
        .StrictIncludes()
        .Unversioned()
    )
    .Append(self.UatArgs.AsArguments())
)(workingDirectory: MyEnginePath);
```

As the reader can see from the GIF this introduces a greater discoveribility to the vast functionality of both UAT and UBT which simply was not there before unless the developer followed some trails inside the source code of these tools. In fact the UAT configurator is generated from the actual source code using static code analysis and relying on semantical heuristics as the command line interpretation of UAT is very organic and inconsistent to say the least.

UBT on the other hand had a more disciplined and consistent approach for interpreting the command line, that allowed to rely on purely reflection while gathering arguments with the added feature of typed parameter value input (like numbers, strings and enums). As of time of writing detecting parameter types in a reliable and meaningful way is not possible for UAT.

## Using third-party C++ libraries

Nuke.Unreal allows you to set up boilerplate for C++ libraries, or fetch them via a package manager. In all cases the artifacts it generates are placed in the working directory (the current location of your terminal). There are three methods available:

### Use library from [xrepo](https://xrepo.xmake.io)

Tt can be as simple as

```
> nuke use-xrepo --spec "zlib"
```

or fully specified with version and library options

```
> nuke use-xrepo --spec "imgui 1.91.1 freetype=true,dx11=true,dx12=true,vulkan=true"
```

and multiple libraries can be set up in one go

```
nuke use-xrepo --spec "imgui 1.91.1 freetype=true" "conan::zlib/1.2.11" "vcpkg::spdlog[wchar]" <etc...>
```

As you can see xrepo also can act like a meta-package-manager for libraries which may not yet been added to the xrepo repository. However their support is more limited than xrepo "native" packages.

`use-xrepo` will not fetch the specified libraries immediately but rather generate build plugins for them, which define `Prepare-<library>` targets. These are all dependent for `Prepare` target of `UnrealBuild` which is then dependent for `Generate`. So after `nuke use-xrepo` running `nuke prepare` or `nuke generate` will fetch and install properly all libraries used in this way. Having an extra build plugin allows the developer to further customize how the library is used, or add extra necessary operations.

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

### Use library via CMake

```
nuke use-cmake --spec MyLibrary
```

This generates build plugins allowing the developer to prepare libraries via CMake. Fetching and storing the library is the responsibility of the developer. The build plugin is prepared for the most trivial use case when compiling a library via CMake but one may need to modify that depending on the design decisions of the library being used.

### Use header only library

```
nuke use-header-only --spec MyLibrary
```

This will directly generate only the module rule file without the need for extra preparations like with the xrepo or the CMake methods.

## Unreal boilerplate templates

Nuke.Unreal provides some targets which creates boilerplate code for common Unreal entities, such as

* Plugins
* Modules
* Unreal Object/Actor/Structs/Interfaces

without the need for opening the Unreal editor or extend heavy weight IDE's. These boilerplate targets work with Scriban templates. The path to these templates can be overridden in the actual Nuke build class in case a project requires further boilerplate. Example:

In any folder in your project do

```
> nuke new-actor --name MyPreciousActor
```

This will generate MyPreciousActor.h and ~.cpp at their respective places (taking public and private folders into account) and the minimal actor class boilerplate for unreal.

### Use your own templates

Optional **Custom templates** folders are required to contain generator specific subfolders. If a subfolder doesn't exist for a generator the default will be used. Example:

Given directory scaffolding:

```
<project root>
├── ...
├── MyTemplates
│   ├── Actor
│   └── Object
└── Nuke.Targets
        Build.cs
        ...
```

In `Nuke.Targets/Build.cs` override `TemplatesPath` property
```CSharp
public override AbsolutePath TemplatesPath { get; set; } = RootDirectory / "MyTemplates";
```

This way Actor and Object generators will have their project specific Scriban templates but the remaining generator types will use the default templates of Nuke.Unreal.

# Custom UBT or UAT arguments from command line

Nuke.Unreal supports passing custom arguments to UBT or UAT via `--ubt-args` or `--uat-args`. These are regular array properties exposed as Nuke target parameters. This means however that doing `--ubt-args -DisableUnity` wouldn't actually add `-DisableUnity` to the argument list. This happens because Nuke stops parsing the array argument when it hits a `-` character. For this reason Nuke.Unreal has a special escape mechanism where `~-` is replaced with `-`, or if the argument starts with `~` then that's also replaced with a `-`.

So doing `--ubt-args ~DisableUnity ~2022` will correctly pass arguments `-DisableUnity -2022` to UBT.

This is especially useful for doing temporary debugging with UBT and the compiler: (not an actual usecase)
```
> nuke build ... --ubt-args "~CompilerArguments='/diagnostics:caret /P /C'" ~DisableUnity
> nuke build ... --ubt-args ~LinkerArguments=/VERBOSE
> nuke build ... --ubt-args ~Preprocess
```

# Targets

In Nuke (and consequently in Nuke.Unreal) a target is a delegate which can build a dependency execution graph with other targets. Nuke's main selling point is how these targets allow complex build compositions and how that can be controlled via command line or profile files.

![](docs/plan.png)

Nuke.Unreal provides couple of universally useful targets associated with regular chores regarding Unreal Engine development. The above figure shows all convenience targets available and their relationship to each other. This also includes optional targets (coming from `IPackageTargets`, `IPluginTargets` and `IAndroidTargets`)

> [!NOTE]
> All parameters specified here are optional and have a "sensible" default, unless they're marked required.

## Global targets (UnrealBuild)

They're available for all project types just from using `UnrealBuild` as base class (`UnrealBuild.Targets.cs` or `UnrealBuild.Templating.cs`).

* Plans:
  * [ ] TODO: `run` target which allows to run any Unreal program from the version associated with the project with arbitrary command line arguments.

### prepare
Run necessary preparations which needs to be done before Unreal tools can handle the project. By default it is empty and the main build project may override it or other Targets can depend on it / hook into it. For example the generated Nuke targets made by `use-cmake` or `use-xrepo` are dependent for `prepare`

### generate

Generate project files for the default IDE of the current platform (i.e.: Visual Studio or XCode). It is equivalent to right clicking the uproject and selecting "Generate _IDE_ project files".

* Graph:
  * Depends on [`prepare`](#prepare)
* Plans:
  * [ ] TODO: Provide more arguments for how the project is generated

### build-editor

Shorthand for building the editor for current platform.

* Parameters:
  * `--editor-config` default is `developnment`
* Graph:
  * After [`prepare`](#prepare)

### build

Uses UBT to build one of the main project targets (Game, Editor, Client, Server).

* Parameters:
  * `--config` default is `development`
  * `--target-type` default is `game`
  * `--platform` default is current development platform
  * `--ubt-args` see [Custom UBT or UAT arguments from command line](#custom-ubt-or-uat-arguments-from-command-line)
* Graph:
  * After [`cook`](#cook)
  * After [`prepare`](#prepare)

### cook

Cook Unreal assets for standalone game execution with UAT.

* Parameters:
  * `--config` default is `development`
  * `--platform` default is current development platform
  * `--uat-args` see [Custom UBT or UAT arguments from command line](#custom-ubt-or-uat-arguments-from-command-line)
  * from [`IAndroidTargets`](#targeting-android-iandroidtargets)
    * `--android-texture-mode` default is `multi`
* Graph:
  * Depends on [`build-editor`](#build-editor)

### clean

Removes auto generated folders of Unreal Engine

* Graph:
  * Depends on:
    * `clean-project`
    * `clean-plugins`
  * Related to `clean-deployment`
* Plans:
  * [ ] TODO: it may be too aggressive, use rather UAT?

### ensure-build-plugin-support

Ensure support for plain C# build plugins without the need for CSX or dotnet projects. This only needs to be done once and you can check the results into source control. It will modify the main Nuke project itself, see [Additional Plugin Targets](#additional-plugin-targets) or [`[ImplicitBuildInterface]` plugins of Nuke.Cola](https://github.com/microdee/md.Nuke.Cola?tab=readme-ov-file#implicitbuildinterface-plugins)

If you used the [remote script install method](#install-via-remote-script) then you don't need to run this target as it's already configured for you.

## UnrealBuild.Templating

These targets are used as a development aid for generating boilerplates. See [Using third-party C++ libraries](#using-third-party-c-libraries) and [Unreal boilerplate templates](#unreal-boilerplate-templates) for full explanation. Because those sections explain in detail how to use boilerplate generator targets, they will be only listed here:

```
new-module      --name ...
add-code        --name ...
new-plugin      --name ...
new-actor       --name ...
new-interface   --name ...
new-object      --name ...
new-struct      --name ...
new-spec        --name ...
use-library     --spec ... --library-type ...
use-xrepo       --spec ...
use-cmake       --spec ...
use-header-only --spec ...
```

Only special mention is `use-library` which is not recommended to be used manually, use either one of `use-xrepo`, `use-cmake` or `use-header-only`. `use-library` expects an extra `--library-type` which the former targets already fill in.

## Packaging (IPackageTargets)

### package

Package the project for distribution. Same as packaging the project from the editor.

* Parameters:
  * `--config` default is `development`
  * `--editor-config` default is `development`
  * `--platform` default is current development platform
  * `--output` default is `<project root>/Intermediate/Output`
  * `--uat-args` see [Custom UBT or UAT arguments from command line](#custom-ubt-or-uat-arguments-from-command-line)
  * from [`IAndroidTargets`](#targeting-android-iandroidtargets)
    * `--android-texture-mode` default is `multi`
* Graph:
  * Depends on [`build-editor`](#build-editor)
  * After
    * `clean-deployment`
    * [`cook`](#cook)
    * [`prepare`](#prepare)

## Targeting Android (IAndroidTargets)

* Plans
  * [ ] TODO: Android targets require some tidy-up and "nicer" interaction with SDK managers (both from the Android SDK Manager and Epic's AutoSDK). Some of the targets are still experimental and probably won't lose that status in the forseeable future

### apply-sdk-user-settings

Epic in their infinite wisdom decided to store crucial project breaking build settings in a user scoped shared location (AppData/Local on Windows). This target attempts to make it less shared info, so one project compilation doesn't break the other one if they use different Engine versions and if these settings are not solidified in `*Engine.ini`.

* Parameters:
  * the default for all of these are determined from engine version and the current user configuration. SDK and NDK versions and API levels can be simple numbers.
  * `--android-build-tool-version`
  * `--android-sdk-path`
  * `--android-ndk-version`
  * `--android-java-path`
  * `--adnroid-sdk-api-level`
  * `--adnroid-ndk-api-level`
* Graph:
  * Dependent for
    * [`build`](#build)
    * [`cook`](#cook)
    * from [`IPackageTargets`](#packaging-ipackagetargets)
      * [`package`](#package)

### clean-intermediate-android

During Android development workflows involving debugging Unreal programs with the generated Gradle project in Android Studio, or developing Java files, Android Studio may modify the generated Gradle project caches in a way that is unexpected for Unreal tools and which may fail in consequent builds. This target clears only the intermediate files generated for Android tooling to avoid such scenario.

This target hooks itself into package and build targets so it's very rare that it has to be executed manually.

* Graph:
  * Dependent for
    * [`build`](#build)
    * from [`IPackageTargets`](#packaging-ipackagetargets)
      * [`package`](#package)

### sign-apk

In some cases UAT or UBT fails to sign the generated APK with the data provided from `[/Script/AndroidRuntimeSettings.AndroidRuntimeSettings]` @ `*Engine.ini`, so this target does that manually directly using the Android tooling.

* Parameters:
  * the default for all of these are determined from engine version and the current user configuration. SDK and NDK versions and API levels can be simple numbers.
  * `--android-build-tool-version`
* Graph:
  * Triggered by [`package`](#package)
  * After [`build`](#build)
  * Before
    * [`install-on-android`](#install-on-android)
    * [`debug-on-android`](#debug-on-android)

### install-on-android

Install the result of packaging or build on a connected android device, same as the "install APK" generated batch files, but more robust. This may provide an alternative to "Launch on device" feature available in Editor but for cases when for some cursed reason that is not supported by the project, or for cases when a bug only happens in distributed or almost distributed builds.

> [!WARNING]
> Assumes ADB is in PATH

* Parameters:
  * the default for all of these are determined from engine version and the current user configuration. SDK and NDK versions and API levels can be simple numbers.
  * `--android-build-tool-version`
* Graph:
  * After
    * [`package`](#package)
    * [`build`](#build)

### debug-on-android

Run this project on a connected Android device from the result of packaging or build with the ActivityManager. This may provide an alternative to "Launch on device" feature available in Editor but for cases when for some cursed reason that is not supported by the project, or for cases when a bug only happens in distributed or almost distributed builds.

> [!WARNING]
> Assumes ADB is in PATH

* Graph:
  * After [`install-on-android`](#install-on-android)

### java-development-service

> [!CAUTION]
> This is highly experimental and only developed for specific cases, but with ambitious intents.

This was an attempt to sync Java files copied into the generated Gradle project back to their original source whenever they're changed. At the moment this is very experimental, may not cover all edge cases, and if I ever return to this problem, I'll rewrite this to use symlinks instead which is set up by another target which needs to be run only once (instead of this acting as a file-system watcher service).

## Plugin development (IPluginTargets)

> [!CAUTION]
> This is highly experimental and only developed for specific cases, but with ambitious intents. This entire section can be different in future versions.

* Plans:
  * This build component will have a lot of changes in the foreseeable future which will allow to better prepare plugins for distribution.

### checkout

Switch to the specified Unreal Engine version and platform for plugin development. A CI/CD can call nuke with this target multiple times to deploy the plugin for multiple engine versions.

* Overrides:
  * `IPluginTargets.PluginPath { get; }` if multiple plugins are present in development project
* Parameters:
  * `--unreal-version` **REQUIRED**
* Graph:
  * Depends on [`clean`](#clean)

### make-release

Convenience target triggering [`pack-plugin`](#pack-plugin) and [`make-marketplace-release`](#make-marketplace-release).

### pack-plugin

Make a pre-built release of the plugin and archive it into a zip file ready to be distributed.

* Overrides:
  * `IPluginTargets.PluginVersion { get; }`
  * `IPluginTargets.PluginPath { get; }` if multiple plugins are present in development project
* Parameters:
  * `--platform` default is current development platform
  * `--output` default is `<project root>/Intermediate/Output`
  * `--uat-args` see [Custom UBT or UAT arguments from command line]
* Graph:
  * After `clean-deployment`

### make-marketplace-release

Prepare a Marketplace complaint archive from the plugin. This yields zip archives in the deployment path, which can then be linked for ~~marketplace~~/Fab.

> [!IMPORTANT]
> Because Unreal Marketplace is no longer a thing, this will be probably renamed to `make-fab-release` in the future.

* Parameters:
  * `--for-marketplace` **REQUIRED** switch
    * This will be deprecated in the future and express the same intention with just the target execution graph
  * `--platform` default is current development platform
  * `--output` default is `<project root>/Intermediate/Output`