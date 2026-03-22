# Targets {#Targets}

[TOC]

In Nuke (and consequently in Nuke.Unreal) a target is a delegate which can build a dependency execution graph with other targets. Nuke's main selling point is how these targets allow complex build compositions and how that can be controlled via command line, environment variables (`NUKE_` prefix) or parameter profile files (`parameters.json` / `parameters-myProfile.json`).

![](docs/Images/plan.png)

Nuke.Unreal provides couple of universally useful targets associated with regular chores regarding Unreal Engine development. The above figure shows all convenience targets available and their relationship to each other. This also includes optional targets (coming from `IPackageTargets` and `IAndroidTargets`)

> [!NOTE]
> All parameters are optional and have a "sensible" default, unless they're marked required `(req.)`.

## Global targets (UnrealBuild)

They're available for all project types just from using `UnrealBuild` as base class (`UnrealBuild.Targets.cs` or `UnrealBuild.Templating.cs`).

* [Info](@ref Nuke.Unreal.UnrealBuild.Info)
* [Switch](@ref Nuke.Unreal.UnrealBuild.Switch)
  * [\--unreal](@ref Nuke.Unreal.UnrealBuild.UnrealVersion)
  * Depends on [Clean](@ref Nuke.Unreal.UnrealBuild.Clean)
  * Before [Prepare](@ref Nuke.Unreal.UnrealBuild.Prepare)
  * Before [Generate](@ref Nuke.Unreal.UnrealBuild.Generate)
  * Before [BuildEditor](@ref Nuke.Unreal.UnrealBuild.BuildEditor)
  * Before [Build](@ref Nuke.Unreal.UnrealBuild.Build)
  * Before [Cook](@ref Nuke.Unreal.UnrealBuild.Cook)
* [Prepare](@ref Nuke.Unreal.UnrealBuild.Prepare)
* [Generate](@ref Nuke.Unreal.UnrealBuild.Generate)
  * Depends on [Prepare](@ref Nuke.Unreal.UnrealBuild.Prepare)
* [BuildEditor](@ref Nuke.Unreal.UnrealBuild.BuildEditor)
  * [\--EditorConfig](@ref Nuke.Unreal.UnrealBuild.EditorConfig)
  * \-->ubt
  * After [Prepare](@ref Nuke.Unreal.UnrealBuild.Prepare)
* [Build](@ref Nuke.Unreal.UnrealBuild.Build)
  * [\--TargetType](@ref Nuke.Unreal.UnrealBuild.TargetType)
  * [\--Config](@ref Nuke.Unreal.UnrealBuild.Config)
  * [\--Platform](@ref Nuke.Unreal.UnrealBuild.Platform)
  * \-->ubt
  * After [Cook](@ref Nuke.Unreal.UnrealBuild.Cook)
  * After [Prepare](@ref Nuke.Unreal.UnrealBuild.Prepare)
* [Cook](@ref Nuke.Unreal.UnrealBuild.Cook)
  * [\--Config](@ref Nuke.Unreal.UnrealBuild.Config)
  * [\--Platform](@ref Nuke.Unreal.UnrealBuild.Platform)
  * [\--AndroidTextureMode](@ref Nuke.Unreal.UnrealBuild.AndroidTextureMode)
  * \-->ubt
  * \-->uat
  * Depends on [BuildEditor](@ref Nuke.Unreal.UnrealBuild.BuildEditor)
* [Clean](@ref Nuke.Unreal.UnrealBuild.Clean)
  * Depends on [CleanProject](@ref Nuke.Unreal.UnrealBuild.CleanProject)
  * Depends on [CleanPlugins](@ref Nuke.Unreal.UnrealBuild.CleanPlugins)
  * [ ] TODO: it may be too aggressive, use rather UAT?
* [Run](@ref Nuke.Unreal.UnrealBuild.Run)
  * [\--Tool](@ref Nuke.Unreal.UnrealBuild.Tool)
  * \-->
* [RunUat](@ref Nuke.Unreal.UnrealBuild.RunUat)
  * [\--IgnoreGlobalArgs](@ref Nuke.Unreal.UnrealBuild.IgnoreGlobalArgs)
  * \-->
* [RunUbt](@ref Nuke.Unreal.UnrealBuild.RunUbt)
  * [\--IgnoreGlobalArgs](@ref Nuke.Unreal.UnrealBuild.IgnoreGlobalArgs)
  * \-->
* [RunShell](@ref Nuke.Unreal.UnrealBuild.RunShell)
* [RunEditorCmd](@ref Nuke.Unreal.UnrealBuild.RunEditorCmd)
  * [\--Cmd](@ref Nuke.Unreal.UnrealBuild.Cmd)
  * \-->

## UnrealBuild.Templating

These targets are used as a development aid for generating boilerplates. See [Using third-party C++ libraries](#using-third-party-c-libraries) and [Unreal boilerplate templates](#unreal-boilerplate-templates) for full explanation.

* [NewModule](@ref Nuke.Unreal.UnrealBuild.NewModule)
  * [\--Name](@ref Nuke.Unreal.UnrealBuild.Name)
* [AddCode](@ref Nuke.Unreal.UnrealBuild.AddCode)
  * [\--Name](@ref Nuke.Unreal.UnrealBuild.Name)
* [NewPlugin](@ref Nuke.Unreal.UnrealBuild.NewPlugin)
  * [\--Name](@ref Nuke.Unreal.UnrealBuild.Name)
* [NewActor](@ref Nuke.Unreal.UnrealBuild.NewActor)
  * [\--Name](@ref Nuke.Unreal.UnrealBuild.Name)
* [NewInterface](@ref Nuke.Unreal.UnrealBuild.NewInterface)
  * [\--Name](@ref Nuke.Unreal.UnrealBuild.Name)
* [NewObject](@ref Nuke.Unreal.UnrealBuild.NewObject)
  * [\--Name](@ref Nuke.Unreal.UnrealBuild.Name)
* [NewStruct](@ref Nuke.Unreal.UnrealBuild.NewStruct)
  * [\--Name](@ref Nuke.Unreal.UnrealBuild.Name)
* [NewSpec](@ref Nuke.Unreal.UnrealBuild.NewSpec)
  * [\--Name](@ref Nuke.Unreal.UnrealBuild.Name)
* [UseXRepo](@ref Nuke.Unreal.UnrealBuild.UseXRepo)
  * [\--Spec](@ref Nuke.Unreal.UnrealBuild.Spec)
* [UseCMake](@ref Nuke.Unreal.UnrealBuild.UseCMake)
  * [\--Spec](@ref Nuke.Unreal.UnrealBuild.Spec)
* [UseHeaderOnly](@ref Nuke.Unreal.UnrealBuild.UseHeaderOnly)
  * [\--Spec](@ref Nuke.Unreal.UnrealBuild.Spec)

## Packaging (IPackageTargets) {#targets-IPackageTargets}

* [Package](@ref Nuke.Unreal.IPackageTargets.Package)
    * [\--Config](@ref Nuke.Unreal.UnrealBuild.Config)
    * [\--Platform](@ref Nuke.Unreal.UnrealBuild.Platform)
    * [\--AndroidTextureMode](@ref Nuke.Unreal.UnrealBuild.AndroidTextureMode)
    * \-->ubt
    * \-->uat
    * Depends on [BuildEditor](@ref Nuke.Unreal.UnrealBuild.BuildEditor)
    * After [CleanDeployment](@ref Nuke.Unreal.UnrealBuild.CleanDeployment)
    * After [Prepare](@ref Nuke.Unreal.UnrealBuild.Prepare)
    * After [Cook](@ref Nuke.Unreal.UnrealBuild.Cook)

## Android (IAndroidTargets) {#targets-IAndroidTargets}

* [CleanIntermediateAndroid](@ref Nuke.Unreal.Platforms.Android.IAndroidBuildTargets.CleanIntermediateAndroid)
  * Only when Android platform is set
  * Dependent for [Build](@ref Nuke.Unreal.UnrealBuild.Build)
  * Dependent for [Package](@ref Nuke.Unreal.IPackageTargets.Package)
* [SignApk](@ref Nuke.Unreal.Platforms.Android.IAndroidBuildTargets.SignApk)
  * Only when Android platform is set
  * Triggered by [Package](@ref Nuke.Unreal.IPackageTargets.Package)
  * After [Build](@ref Nuke.Unreal.UnrealBuild.Build)
* [InstallOnAndroid](@ref Nuke.Unreal.Platforms.Android.IAndroidDeployTargets.InstallOnAndroid)
  * Only when Android platform is set
  * [\--NoUninstall](@ref Nuke.Unreal.Platforms.Android.IAndroidDeployTargets.NoUninstall)
  * After [Package](@ref Nuke.Unreal.IPackageTargets.Package)
  * After [Build](@ref Nuke.Unreal.UnrealBuild.Build)
* [DebugOnAndroid](@ref Nuke.Unreal.Platforms.Android.IAndroidDeployTargets.DebugOnAndroid)
  * Only when Android platform is set
  * After [InstallOnAndroid](@ref Nuke.Unreal.Platforms.Android.IAndroidDeployTargets.InstallOnAndroid)
