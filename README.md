<div align="center">

![](docs/nu_logo-250.png)

![](https://badgen.net/nuget/v/md.Nuke.Unreal)

# Nuke.Unreal

</div>

Simplistic workflow for automating Unreal Engine project tasks embracing [Nuke](https://nuke.build), providing a consistent way to use UE4/5 tools and reducing chores they come with.

## Usage

> [!WARNING]
> `dotnet` is required to be installed first. Also recommend to set 

### Install via remote script

Navigate to your project with powershell and do

```
Set-ExecutionPolicy Unrestricted -Scope Process -Force; iex (iwr 'https://raw.githubusercontent.com/microdee/Nuke.Unreal/refs/heads/main/install/install.ps1').ToString()
```

1. ***(optional)*** Inherit `IPackageTargets` interface if you want to package the associated Unreal project
2. ***(optional)*** Inherit `IPluginTargets` interface for automating plugin development related steps.

### Install manually

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

## Generators

### C# code generators for Unreal tools

**TODO:** record a new fancy gif with newest updates

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

### Using third-party C++ libraries

Nuke.Unreal allows you to set up boilerplate for C++ libraries, or fetch them via a package manager. There are three methods available:

#### Use library from [xrepo](https://xrepo.xmake.io)

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
> Conan packages uses `/` to delimit version (`conan::zlib/1.2.3`). VCPKG through xrepo cannot set specific version so attempting to do `vcpkg::zlib 1.2.3` will result in failing installation, but `vcpkg::zlib` is fine.

> [!NOTE]
> Since Unreal requires `MD` C runtime linkage `runtimes='MD'` is implicitly added by Nuke.Unreal.

The `Prepare` and the individual `Prepare-<library>` targets will generate partial module rule classes for the platforms they were invoked for. This is done because libraries may have different requirements based on which platform they're used on / compiled on. The main `MyLibrary.Build.cs` module rule is the place for the developer to add custom logic if that's necessary for the library. Individual `MyLibrary.Platform.Build.cs` partial rules set up includes and libs.

> [!IMPORTANT]
> During installation only one platform is considered, and only one platform worth of module rule class will be generated. This means the library should be prpared with all supported platforms or cross-compiled to be able to deploy in a truly cross-platform fashion.

### Unreal boilerplate templates

Nuke.Unreal provides some targets which creates boilerplate code for common Unreal entities, such as

* [x] Plugins
* [x] Modules
* [x] Unreal Object/Actor/Structs/Interfaces

without the need for opening the Unreal editor or extend heavy weight IDE's. These boilerplate targets work with Scriban templates. The path to these templates can be overridden in the actual Nuke build class in case a project requires further boilerplate. Example:

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

## Custom UBT or UAT arguments from command line

Nuke.Unreal supports passing custom arguments to UBT or UAT via `--ubt-args` or `--uat-args`. These are regular array properties exposed as Nuke target parameters. This means however that doing `--ubt-args -DisableUnity` wouldn't actually add `-DisableUnity` to the argument list. This happens because Nuke stops parsing the array argument when it hits a `-` character. For this reason Nuke.Unreal has a special escape mechanism where `~-` is replaced with `-`, or if the argument starts with `~` then that's also replaced with a `-`.

So doing `--ubt-args ~DisableUnity ~2022` will correctly pass arguments `-DisableUnity -2022` to UBT.

For convenience the sequence `''` is also replaced with a double quote `"` hopefully escaping command line parsers.

This is especially useful for doing temporary debugging with UBT and the compiler: (not an actual usecase)
```
> nuke build ... --ubt-args "~CompilerArguments=''/diagnostics:caret /P /C''" ~DisableUnity
> nuke build ... --ubt-args "~LinkerArguments=''/VERBOSE''"
> nuke build ... --ubt-args ~Preprocess
```