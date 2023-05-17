<div align="center">

![](docs/nu_logo-250.png)

![](https://badgen.net/nuget/v/md.Nuke.Unreal)

# Nuke.Unreal

</div>

Simplistic workflow for automating Unreal Engine project tasks embracing [Nuke](https://nuke.build), providing a consistent way to use UE4/5 tools and reducing chores they come with.

## Usage

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
2. Inherit your Build class from `UnrealBuild` instead of `NukeBuild`
3. No further boilerplate required, run `nuke --plan` to test Nuke.Unreal
4. ***(optional)*** Inherit `IPackageTargets` interface if you want to package the associated Unreal project
5. ***(optional)*** Inherit `IPluginTargets` interface for automating plugin development related steps.

Your bare-bones minimal Build.cs which will provide the default features of Nuke.Unreal should look like this:

```CSharp
// Build.cs
using namespace Nuke.Common;
using namespace Nuke.Unreal;

class Build : UnrealBuild
{
    public static int Main () => Execute<Build>(x => x.BuildEditor);
}
```

## Features:
* All what the great Nuke can offer
* Common UE4 build tasks (generate project files, build editor, cook, package, etc)
  ```
  > nuke generate
  > nuke build-editor
  > nuke cook
  > nuke package
  > nuke build --config Shipping
  > nuke build --config DebugGame Development --target-type Game --platform Android
  ```
* Prepare plugins for release in Marketplace
  ```
  > nuke make-release --for-marketplace
  ```
* Generate boilerplate code and scaffolding from [Scriban](https://github.com/scriban/scriban) templates so no editor needs to be opened
    ```
    > nuke new-actor --name MyActor
    > nuke new-plugin --name MyPlugin
    > nuke new-module --name MyModule
    etc...
    ```
* Generated C# configurators for Unreal tools with gathered documentation. (UBT and UAT)
* Pluggable way to define targets for reusable plugins and modules

## Breaking changes

### 1.1 → 1.2
* `UnrealBuild.CookArguments` has been replaced with `UnrealBuild.UatGlobal` and `UnrealBuild.UatCook` using the tool configurator instead of just an `IEnumerable` of strings
* `UnrealBuild.CookAll` has been removed, `UnrealBuild.UatCook` override should be used instead.
* `IPackageTargets.PackageArguments` has been replaced with `IPackageTargets.UatPackage` using the tool configurator instead of just an `IEnumerable` of strings
* `IPackageTargets.PackagePak` has been removed, `IPackageTargets.PackageArguments` override should be used instead.
* `UnrealBuild.UbtConfig` → `UnrealBuild.UbtGlobal`
* `UnrealBuildToolConfig` → `UbtConfig`

### 1.0 → 1.1
* `ToProject` and `ToPlugin` → `ProjectPath` and `PluginPath`
* `TargetPlatform` → `Platform`
* `TargetEngineVersion` → `EngineVersion`
* `RunIn` and `ExecMode` has been replaced with proper Unreal compliant target names `TargetType` and `UnrealTargetType`
* `UnrealTool` and `UnrealToolOutput` has been replaced by proper Nuke `Tool` delegates
* More smaller things might be there, beware when updating

## Setting up for a project

Nuke.Unreal targets looks for the `*.uproject` file automatically and it will use the first one it finds. A `*.uproject` is required to be present even for plugin development (more on plugins below). Automatically found project files can be in the sub-folder tree of Nuke's root (which is the folder containing the `.nuke` temporary folder) or in parent folders of Nuke's root. If for any reason there are more than one or no `*.uproject` files in that area, the developer can specify an explicit location of the associated `*.uproject` file.

```CSharp
public override AbsolutePath ProjectPath => RootDirectory / ".." / "MyProject" / "MyProject.uproject";
```

Only one Unreal project is supported per Nuke.Unreal instance.

## Setting up for plugin development

Same is applicable when Nuke.Unreal is used for developing an Unreal Plugin for release. Of course Nuke.Unreal can work with multiple plugins in a project, but the `IPluginTargets` interface focuses only on one plugin. Again if the plugin is not trivially locatable then the developer can specify its location explicitly.

```CSharp
public AbsolutePath PluginPath => UnrealPluginsFolder / "MyPlugin" / "MyPlugin.uplugin";
```

### Additional Plugin Targets

However plugins which require some pre-processing might benefit from the very simple "Plugin Targets" pattern, which is just simple class-library C# projects, referencing Nuke.Unreal as a nuget, and define extra targets or functionality which can be used by the main Nuke installation for the project. Let's have this scaffolding as an example:

```
<project root>
│   MyUnrealProject.uproject
├── .nuke
├── Content, Build, etc...
├── Nuke.Targets
│       Build.cs
│       _build.csproj (main build script)
├── Plugins
│   └── MyPlugin
│       ├── Nuke.Targets
│       │       MyPlugin.cs
│       │       MyPlugin.csproj
│       └── <regular plugin files>
└── Source
    └── MyModule
        ├── Nuke.Targets
        │       MyModule.cs
        │       MyModule.csproj
        └── <source files>
```

`MyModule.csproj` and `MyPlugin.csproj` were both simply generated by `dotnet new classlib --name ... --output ./Nuke.Targets` and then the `md.Nuke.Unreal` which brings in the core Nuke packages, was added to define targets. Of course the developer can manually add these project references to the main build project, but Nuke.Unreal provides `discover-plugin-targets` target, which seeks out C# projects inside `Nuke.Targets` folders, and add them to the main build project automatically. After calling `discover-plugin-targets`, the developer can use these plugin projects as any other regular .NET reference. In most cases the plugin projects define interfaces which has some targets declared with "default implementation", then these interfaces can be inherited by the main Build class. Nuke will see the new targets without further boilerplate.

```CSharp

// MyModule.cs
using namespace Nuke.Common;
using namespace Nuke.Unreal;
namespace Nuke.MyModule;

public interface IMyModuleTargets : INukeBuild
{
    Target Foo => _ => _
        .DependsOn<IPackageTargets>()
        .Executes(() {...});
}

// MyPlugin.cs
using namespace Nuke.Common;
using namespace Nuke.Unreal;
namespace Nuke.MyPlugin;

public interface IMyPluginTargets : INukeBuild
{
    Target Foo => _ => _
        .Before<UnrealBuild>(u => u.Generate, u => u.Build, u => u.BuildEditor)
        .Executes(() {...});
}

// Build.cs
using namespace Nuke.Common;
using namespace Nuke.Unreal;
using namespace Nuke.MyModule;
using namespace Nuke.MyPlugin;

class Build : UnrealBuild, IPackageTargets, IMyModuleTargets, IMyPluginTargets
{
    public static int Main () => Execute<Build>(x => x.BuildEditor);
}
```

While discovering plugin targets, C# projects inside a `Nuke.Targets` folder neighbouring a `.nuke` folder will be ignored.

### Custom UBT or UAT arguments from command line

Nuke.Unreal supports passing custom arguments to UBT or UAT via `--ubt-args` or `--uat-args`. These are regular array properties exposed as Nuke target parameters. This means however that doing `--ubt-args -DisableUnity` wouldn't actually add `-DisableUnity` to the argument list. This happens because Nuke stops parsing the array argument when it hits a `-` character. For this reason Nuke.Unreal has a special escape mechanism where `~-` is replaced with `-`, or if the argument starts with `~` then that's also replaced with a `-`.

So doing `--ubt-args ~DisableUnity ~2022` will correctly pass arguments `-DisableUnity -2022` to UBT.

For convenience the sequence `''` is also replaced with a double quote `"` hopefully escaping command line parsers.

This is especially useful for doing temporary debugging with UBT and the compiler: (not an actual usecase)
```
> nuke build ... --ubt-args "~CompilerArguments=''/diagnostics:caret /P /C''" ~DisableUnity
> nuke build ... --ubt-args "~LinkerArguments=''/VERBOSE''"
> nuke build ... --ubt-args ~Preprocess
```

## Generators

### C# code generators for Unreal tools

**TODO:** record a new fancy gif with newest updates

Nuke.Unreal provides builder pattern Unreal tool configurators in C# which yield a command line for the specified tool. TLDR: the syntax looks like this:

```CSharp
// For UBT:
Unreal.BuildTool(GetEngineVersionFromProject(), _ => _
    .Target(UnrealTargetType.Server)
    .Platform(UnrealPlatform.LinuxAArch64)
    .Configuration(UnrealConfig.Development)
    .Project(ProjectPath)
    .Append(MyExplicitArguments)
)(workingDirectory: MyEnginePath);

// For UAT:
Unreal.AutomationTool(GetEngineVersionFromProject(), _ => _
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

**TODO:** add more details about the actual usage in Nuke.Unreal targets and some more info about implementation.

### Unreal boilerplate templates

Nuke.Unreal provides some targets which creates boilerplate code for common Unreal entities, such as

* [x] Plugins
* [x] Modules
* [x] Unreal Object/Actor/Structs/Interfaces
* [ ] Slate widgets

without the need for opening the UE4 editor or extend heavy weight IDE's. These boilerplate targets work with Scriban templates. The path to these templates can be overridden in the actual Nuke build class in case a project requires further boilerplate. Example:

In any folder in your project
```
> nuke NewActor --name MyPreciousActor
```

This will generate MyPreciousActor.h and ~.cpp at their respective places (taking public and private folders into account) and the minimal actor class boilerplate for unreal.

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
