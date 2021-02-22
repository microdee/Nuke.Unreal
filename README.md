# Nuke.Unreal

Simplistic workflow for automating Unreal Engine project steps with Nuke.

For now, no Nuget release available and its functionality is limited yet for mostly personal usage. If you still want to use this workflow you can start from the [Nuke.Unreal Workflow Template](https://github.com/microdee/Nuke.Unreal.WorkflowTemplate), or go manually:

1. go and set up Nuke with their global tool in your project's root
2. Submodule this repo in `<git root>/Nuke.Unreal`
3. `dotnet sln .\Build.sln add .\Nuke.Unreal\src\Nuke.Unreal\Nuke.Unreal.csproj`
4. `dotnet add .\build\_build.csproj reference .\Nuke.Unreal\src\Nuke.Unreal\Nuke.Unreal.csproj`
5. Inherit your Build class from either `PluginTargets` or `ProjectTargets`
6. Override abstract members, and add own targets

## Generators for Unreal Tools

Nuke.Unreal can generate type-safe fluent API for UE tooling with similar mindset as Nuke tools using direct reflection data from Unreal tools written for .NET. The Tool Generators project directly reference those programs as .NET assemblies. It's only done like this in the generator, and not actually inside the build project because the assemblies are referred with an absolute path, but the location of Unreal is a dynamic data during runtime ("build-time" if you prefer). So there's no extra ceremony for the user during setting up their build environment with Nuke.Unreal. As an added extra this way we can still somewhat treat these tools as executable black-boxes during runtime/build-time, so we don't run into any problems regarding different .NET environment requirements.

On the other hand Contributors to Nuke.Unreal need to modify `LocalUnrealAssemblies.targets` in order to explicitly point to their own location of their unreal installation depending on their development platform. Again this is only necessary for generating the fluent tool API, but not for running the actual Nuke.Unreal targets.