# Nuke.Unreal

Simplistic workflow for automating Unreal Engine project steps with Nuke.

For now, no Nuget release available and its functionality is limited yet for mostly personal usage. If you still want to use this workflow you can start from the [Nuke.Unreal Workflow Template](https://github.com/microdee/Nuke.Unreal.WorkflowTemplate), or go manually:

1. go and set up Nuke with their global tool in your project's root
2. Submodule this repo (no matter where as long as project references are checking out)
3. `dotnet sln .\Build.sln add .\Nuke.Unreal\Nuke.Unreal.csproj`
4. `dotnet add .\build\_build.csproj reference .\Nuke.Unreal\Nuke.Unreal.csproj`
5. Inherit your Build class from either `PluginTargets` or `ProjectTargets`
6. Override abstract members, and add or override your own targets