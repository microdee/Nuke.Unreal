# Targets {#Targets}

[TOC]

In Nuke (and consequently in Nuke.Unreal) a target is a delegate which can build a dependency execution graph with other targets. Nuke's main selling point is how these targets allow complex build compositions and how that can be controlled via command line or profile files.

![](docs/Images/plan.png)

Nuke.Unreal provides couple of universally useful targets associated with regular chores regarding Unreal Engine development. The above figure shows all convenience targets available and their relationship to each other. This also includes optional targets (coming from `IPackageTargets`, `IPluginTargets` and `IAndroidTargets`)

> [!NOTE]
> All parameters specified here are optional and have a "sensible" default, unless they're marked required.

## Global targets (UnrealBuild)

They're available for all project types just from using `UnrealBuild` as base class (`UnrealBuild.Targets.cs` or `UnrealBuild.Templating.cs`).

### info {#target-info}

Prints curated information about project.

### switch {#target-switch}

Switch to the specified Unreal Engine version and platform. A CI/CD can call nuke with this target multiple times to deploy plugins for multiple engine versions for example.

* Parameters:
  * `--unreal` **REQUIRED**
    * Can be simple version name like `5.5`, a GUID associated with engine location or an absolute path to engine root.
* Graph:
  * Depends on [clean](@ref target-clean)
  * Before [prepare](@ref target-prepare)
  * Before [generate](@ref target-generate)
  * Before [buildEditor](@ref target-build-editor)
  * Before [build](@ref target-build)
  * Before [cook](@ref target-cook)

### prepare {#target-prepare}

Run necessary preparations which needs to be done before Unreal tools can handle the project. By default it is empty and the main build project may override it or other Targets can depend on it / hook into it. For example the generated Nuke targets made by `use-cmake` or `use-xrepo` are dependent for `prepare`

### generate {#target-generate}

Generate project files for the default IDE of the current platform (i.e.: Visual Studio or XCode). It is equivalent to right clicking the uproject and selecting "Generate _IDE_ project files".

* Graph:
  * Depends on [prepare](@ref target-prepare)
* Plans:
  * [ ] TODO: Provide more arguments for how the project is generated

### build-editor {#target-build-editor}

Shorthand for building the editor for current platform.

* Parameters:
  * `--editor-config` default is `developnment`
* Graph:
  * After [prepare](@ref target-prepare)

### build {#target-build}

Uses UBT to build one of the main project targets (Game, Editor, Client, Server).

* Parameters:
  * `--config` default is `development`
  * `--target-type` default is `game`
  * `--platform` default is current development platform
* Argument blocks:
  * `-->ubt` see [Custom UBT or UAT arguments](#custom-ubt-or-uat-arguments)
* Graph:
  * After [cook](@ref target-cook)
  * After [prepare](@ref target-prepare)

### cook {#target-cook}

Cook Unreal assets for standalone game execution with UAT.

* Parameters:
  * `--config` default is `development`
  * `--platform` default is current development platform
  * from [`IAndroidTargets`](#targeting-android-iandroidtargets)
    * `--android-texture-mode` default is `multi`
* Argument blocks:
  * `-->uat` see [Custom UBT or UAT arguments](#custom-ubt-or-uat-arguments)
* Graph:
  * Depends on [build-editor](@ref target-build-editor)

### clean {#target-clean}

Removes auto generated folders of Unreal Engine

* Graph:
  * Depends on:
    * `clean-project`
    * `clean-plugins`
  * Related to `clean-deployment`
* Plans:
  * [ ] TODO: it may be too aggressive, use rather UAT?

### run {#target-run}

Run an Unreal tool from the engine binaries folder. You can omit the `Unreal` prefix and the extension. For example:

```
> nuke run --tool pak --> ./Path/To/MyProject.pak -Extract "D:/temp"
> nuke run --tool editor-cmd --> ~p -run=MyCommandlet
```

Working directory is the project folder, regardless of actual working directory.

* Parameters:
  * `--tool`
* Argument blocks:
  * `-->` see [Passing command line arguments to Unreal tools](#passing-command-line-arguments-to-unreal-tools)

### run-uat {#target-run-uat}

Simply run UAT with arguments passed after `-->`

* Parameters:
  * `--ignore-global-args`
* Argument blocks:
  * `-->` see [Passing command line arguments to Unreal tools](#passing-command-line-arguments-to-unreal-tools)

### run-ubt {#target-run-ubt}

Simply run UBT with arguments passed after `-->`

* Parameters:
  * `--ignore-global-args`
* Argument blocks:
  * `-->` see [Passing command line arguments to Unreal tools](#passing-command-line-arguments-to-unreal-tools)

### run-shell {#target-run-shell}

Create console window with a [UShell](https://dev.epicgames.com/documentation/en-us/unreal-engine/how-to-use-ushell-for-unreal-engine) session. Only fully supported after UE 5.5

### run-editor-cmd {#target-run-editor-cmd}

Run an editor commandlet with arguments passed in after `-->`

* Parameters:
  * `--cmd`
* Argument blocks:
  * `-->` see [Passing command line arguments to Unreal tools](#passing-command-line-arguments-to-unreal-tools)

### ensure-build-plugin-support {#target-ensure-build-plugin-support}

Ensure support for plain C# build plugins without the need for CSX or dotnet projects. This only needs to be done once and you can check the results into source control. It will modify the main Nuke project itself, see [Setting up for plugin development](#setting-up-for-plugin-development) or [`[ImplicitBuildInterface]` plugins of Nuke.Cola](https://mcro.de/md.Nuke.Cola/de/d4b/BuildPlugins.html#autotoc_md0)

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

## Packaging (IPackageTargets) {#targets-IPackageTargets}

### package {#target-package}

Package the project for distribution. Same as packaging the project from the editor.

* Parameters:
  * `--config` default is `development`
  * `--editor-config` default is `development`
  * `--platform` default is current development platform
  * `--output` default is `<project root>/Intermediate/Output`(#custom-ubt-or-uat-arguments)
  * from [`IAndroidTargets`](#targeting-android-iandroidtargets)
    * `--android-texture-mode` default is `multi`
* Argument blocks:
  * `-->uat` see [Custom UBT or UAT arguments](#custom-ubt-or-uat-arguments)
* Graph:
  * Depends on [build-editor](@ref target-build-editor)
  * After
    * clean-deployment
    * [cook](@ref target-cook)
    * [prepare](@ref target-prepare)

## Targeting Android (IAndroidTargets)

* Plans
  * [ ] TODO: Android targets require some tidy-up and "nicer" interaction with SDK managers (both from the Android SDK Manager and Epic's AutoSDK). Some of the targets are still experimental and probably won't lose that status in the forseeable future

### apply-sdk-user-settings {#target-apply-sdk-user-settings}

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
    * [build](@ref target-build)
    * [cook](@ref target-cook)
    * from [IPackageTargets](@ref targets-IPackageTargets)
      * [package](@ref target-package)

### clean-intermediate-android {#target-clean-intermediate-android}

During Android development workflows involving debugging Unreal programs with the generated Gradle project in Android Studio, or developing Java files, Android Studio may modify the generated Gradle project caches in a way that is unexpected for Unreal tools and which may fail in consequent builds. This target clears only the intermediate files generated for Android tooling to avoid such scenario.

This target hooks itself into package and build targets so it's very rare that it has to be executed manually.

* Graph:
  * Dependent for
    * [build](@ref target-build)
    * from [IPackageTargets](@ref targets-IPackageTargets)
      * [package](@ref target-package)

### sign-apk {#target-sign-apk}

In some cases UAT or UBT fails to sign the generated APK with the data provided from `[/Script/AndroidRuntimeSettings.AndroidRuntimeSettings]` @ `*Engine.ini`, so this target does that manually directly using the Android tooling.

* Parameters:
  * the default for all of these are determined from engine version and the current user configuration. SDK and NDK versions and API levels can be simple numbers.
  * `--android-build-tool-version`
* Graph:
  * Triggered by [package](@ref target-package)
  * After [build](@ref target-build)
  * Before
    * [install-on-android](@ref target-install-on-android)
    * [debug-on-android](@ref target-debug-on-android)

### install-on-android {#target-install-on-android}

Install the result of packaging or build on a connected android device, same as the "install APK" generated batch files, but more robust. This may provide an alternative to "Launch on device" feature available in Editor but for cases when for some cursed reason that is not supported by the project, or for cases when a bug only happens in distributed or almost distributed builds.

> [!WARNING]
> Assumes ADB is in PATH

* Parameters:
  * the default for all of these are determined from engine version and the current user configuration. SDK and NDK versions and API levels can be simple numbers.
  * `--android-build-tool-version`
* Graph:
  * After
    * [package](@ref target-package)
    * [build](@ref target-build)

### debug-on-android {#target-debug-on-android}

Run this project on a connected Android device from the result of packaging or build with the ActivityManager. This may provide an alternative to "Launch on device" feature available in Editor but for cases when for some cursed reason that is not supported by the project, or for cases when a bug only happens in distributed or almost distributed builds.

> [!WARNING]
> Assumes ADB is in PATH

* Graph:
  * After [install-on-android](@ref target-install-on-android)

### java-development-service {#target-java-development-service}

> [!CAUTION]
> This is highly experimental and only developed for specific cases, but with ambitious intents.

This was an attempt to sync Java files copied into the generated Gradle project back to their original source whenever they're changed. At the moment this is very experimental, may not cover all edge cases, and if I ever return to this problem, I'll rewrite this to use symlinks instead which is set up by another target which needs to be run only once (instead of this acting as a file-system watcher service).