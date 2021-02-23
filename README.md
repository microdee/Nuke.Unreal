# Nuke.Unreal

Simplistic workflow for automating Unreal Engine project steps embracing [Nuke](https://nuke.build).

Nuke + Unreal Engine workflow provides a consistent way to work with UE4/5 tools reducing the chore it comes with 

## Usage

For now, no Nuget release available and its functionality is limited yet for mostly personal usage. If you still want to use this workflow you can start from the [Nuke.Unreal Workflow Template](https://github.com/microdee/Nuke.Unreal.WorkflowTemplate), or go manually:

1. go and set up Nuke with their global tool in your project's root
2. Submodule this repo in `<git root>/Nuke.Unreal`
3. `dotnet sln .\Build.sln add .\Nuke.Unreal\src\Nuke.Unreal\Nuke.Unreal.csproj`
4. `dotnet add .\build\_build.csproj reference .\Nuke.Unreal\src\Nuke.Unreal\Nuke.Unreal.csproj`
5. Inherit your Build class from either `PluginTargets` or `ProjectTargets`
6. Override abstract members, and add own targets

## Features:
* Common UE4 build tasks (generate project files, build editor, cook, package, etc)
* Prepare plugins for release in Marketplace
* Bind Unreal tools to Nuke with fluent C# API \[WIP\]
* Generate boilerplate code and scaffolding from [Scriban](https://github.com/scriban/scriban) templates so no editor needs to be opened \[WIP\]
  * New Unreal class
  * New Plugin
  * New Module

## Generators

### Unreal boilerplate templates \[WIP\]

Nuke.Unreal provides some targets which creates boilerplate code for common Unreal entities, such as

* Plugins
* Modules
* Unreal Classes/Structs/Interfaces
* Slate widgets

without the need for opening the editor or extend IDE's. These boilerplate targets work with Scriban templates. The path to these templates can be overridden in the actual Nuke build class in case a project requires further boilerplate.

### Generators for Unreal Tools \[WIP\]

Nuke.Unreal can generate type-safe fluent API for UE tooling with similar mindset as Nuke tools using direct reflection data from Unreal tools written for .NET. The Tool Generators project directly reference those programs as .NET assemblies. It's only done like this in the generator, and not actually inside the build project because the assemblies are referred with an absolute path, but the location of Unreal is a dynamic data during runtime ("build-time" if you prefer). So there's no extra ceremony for the user during setting up their build environment with Nuke.Unreal. As an added extra this way we can still somewhat treat these tools as executable black-boxes during runtime/build-time, so we don't run into any problems regarding different .NET environment requirements.

On the other hand Contributors to Nuke.Unreal need to modify `LocalUnrealAssemblies.targets` in order to explicitly point to their own location of their unreal installation depending on their development platform. Again this is only necessary for generating the fluent tool API, but not for running the actual Nuke.Unreal targets.