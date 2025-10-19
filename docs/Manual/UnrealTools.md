# Unreal tools bindings {#UnrealTools}

[TOC]

## Passing command line arguments to Unreal tools

In some targets Nuke.Unreal allows to pass custom command line arguments for Unreal tools. This is only necessary for advanced use cases, and for prototyping. In almost all cases once a workflow is developed with these custom arguments it is recommended to solidify them into a custom target, or use the plathera of customization and modularization points Nuke.Unreal offers.

Command line arguments are passed with the `-->` sequence, anything after such sequence will be passed directly to tools. This is dubbed as "argument blocks". The precise usage of them depends on the specific target being used. Multiple argument blocks can be named and used by targets. A block ends when another one starts or when it's the end of the command line input.

In all cases Nuke.Unreal provides some variables so the user don't need to repeat long paths. These variables are replaced at any position of the text of any argument. These variables are:

```
   ~p - Absolute path of the .uproject file
~pdir - Absolute folder containing the .uproject file
  ~ue - Absolute path to the engine root
```

For example

```
> nuke run --tool editor-cmd --> ~p -run=MyCommandlet
UnrealEditor-Cmd.exe C:\Projects\Personal\MyProject\MyProject.uproject -run=MyCommandlet
```

### Custom UBT or UAT arguments

When invoking common tasks Nuke.Unreal supports passing extra custom arguments to UBT or UAT via `-->ubt` or `-->uat`. Anything passed behind these or in-between these will be passed to their respective tool.

This is especially useful for doing temporary debugging with UBT and the compiler: (not an actual usecase)
```
> nuke build ... -->ubt -CompilerArguments="/diagnostics:caret /P /C" -DisableUnity
> nuke build ... -->ubt -LinkerArguments=/VERBOSE
> nuke build ... -->ubt -Preprocess
```

## C# Tool API

Nuke.Unreal provides builder/fluent pattern Unreal tool configurators in C# which yield command line arguments for the specified tool. TLDR: the syntax looks like this:

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

And since this is C# it comes with all the developer experience benefits:

![](nuke-unreal-uat-bindings-docs.png)

This introduces a greater discoverability to the vast functionality of both UAT and UBT which simply was not there before unless the developer followed some trails inside the source code of these tools. Both configurators are generated from the actual source code using static code analysis and relying on semantical heuristics as the command line interpretation of UAT is very procedural.

UBT on the other hand had a more disciplined and consistent approach for interpreting the command line, that allowed to rely on purely reflection while gathering arguments with the added feature of typed parameter value input (like numbers, strings and enums). As of time of writing detecting parameter types in a reliable and meaningful way is not possible for UAT.

### Handling multiple egnine versions

You might notice that the documentation for auto-generated bindings above strangely repeats itself. This happens because Nuke.Unreal scapes the source of Unreal tools for multiple engine versions, and in this particular case it joins together documentation if that's different between engine versions. This is also a perfect segue to how this syntax deals with differences of the command line interface of different engine versions.

Unfortunately if one parameter or one sub-tool is renamed from one version to the next one, there's no algorithmically sound, 100% accurate way to map these renames automatically. With one exception of course when Unreal Engine 5 came out all mentions of `UE4` in the codebase has been renamed to `Unreal`. Nuke.Unreal can deal with that particular case, so all `Unreal*` parameters are renamed to `UE4` at invocation for Unreal Engine 4 (and where `UE4` was actually used in Unreal Engine 4).

With each parameter or subtool an extra metadata is kept denoting which engine versions they're compatible with. If the developer would invoke a parameter which is not present in their target engine version, that will be ignored from the resulting command line arguments string and a warning will be logged.