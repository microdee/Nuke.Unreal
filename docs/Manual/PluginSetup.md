# Setting up for plugin development {#PluginSetup}

A little bit of theory: Unreal plugins are simple on the surface but easily can get very complicated to handle especially when they need to interact with the non-unreal world. For this reason it is recommended to break up development and distribution of Unreal plugins into multiple stages:

<div align="center">

![](PluginStages.drawio.svg)

</div>

Nuke.Unreal lives in the "**True Plugin Source**" stage *(whatever that may look like in your software architecture)* and helps to deliver it to further distribution stages.

Plugins can be managed by creating your own targets to handle them. You can do that inside either your main build class, or glue that logic to your Unreal plugin in its folder structure via [Nuke.Cola build plugins](https://mcro.de/md.Nuke.Cola/de/d4b/BuildPlugins.html). The simplest method of which is [standalone `*.nuke.cs` files](https://mcro.de/md.Nuke.Cola/de/d4b/BuildPlugins.html#autotoc_md0) which are compiled with the build project.

Let's have this scaffolding as an example:

```
<project root>
│   MyUnrealProject.uproject
├── .nuke
├── Content, Build, etc...
├── Nuke.Targets
│       Build.cs
│       Nuke.Targets.csproj (main build script)
└── Plugins
    └── MyPlugin
        │   MyPlugin.nuke.cs
        ├── Source
        │   └── MyModule
        │       │   MyModule.nuke.cs
        │       └── <source files>
        └── <regular plugin files>
```

Build interfaces (or in Nuke vocabulary "[Build Components](https://nuke.build/docs/sharing/build-components/)") decorated with `[ImplicitBuildInterface]` inside these `*.nuke.cs` files will automatically contribute to the build graph without further boilerplate.

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
    Target PrepareMyModule => _ => _
        .Executes(() =>
        {
            var self = (UnrealBuild)this;

            // This will automatically fetch the plugin which owns this particular script.
            // These plugin objects are shared among all targets and they can all manipulate their aspects
            var thisPlugin = UnrealPlugin.Get(this.ScriptFolder());

            // This module has some runtime dependencies which it needs to sort out
            // This function gets the plugin in itself, no need to use thisPlugin here
            // See exact usage of this in section "Semi-auto Runtime Dependencies"
            self.PrepareRuntimeDependencies(this.ScriptFolder(), /* ... */);
        });
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
    Target PrepareMyPlugin => _ => _
        .DependentFor<UnrealBuild>(u => u.Prepare)
        .DependsOn<IMyModuleTargets>()
        .Executes(() =>
        {
            // This will automatically fetch the plugin which owns this particular script.
            // These plugin objects are shared among all targets and they can all manipulate their aspects
            var thisPlugin = UnrealPlugin.Get(this.ScriptFolder());

            // Do extra logic scoped for the plugin...
        });
    
    Target DistributeMyPlugin => _ => _
        .DependsOn(PrepareMyPlugin)
        .Executes(() =>
        {
            // Create a copy of this plugin which can be distributed to other developers or other tools
            // who shouldn't require extra non-unreal related steps to work with it.
            // You can upload the result of this to Fab.
            var (files, outputDir) = UnrealPlugin.Get(this.ScriptFolder()).DistributeSource();

            // Do something with the affected files or in the output directory...
        });
    
    Target BuildMyPlugin => _ => _
        .DependsOn(PrepareMyPlugin)
        .Executes(() =>
        {
            // Build this plugin with UAT for binary distribution
            var outputDir = UnrealPlugin.Get(this.ScriptFolder()).BuildPlugin();

            // Do something in the output directory...
        });
}
```

And call them later with

```
> nuke prepare-my-plugin
> nuke distribute-my-plugin
> nuke build-my-plugin
```

You have absolute freedom to organize the task-dependency graph around handling your plugins. For example one target may manipulate multiple plugins even, from a dynamic set of folders. The above example is just a simple use-case.