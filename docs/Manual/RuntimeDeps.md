# Semi-auto Runtime Dependencies {#RuntimeDeps}

Some third-party libraries or solutions may come with a lot of binary dependencies, which needs to be organized neatly into specific folders when distributing the project. Module rules provide a mechanism for managing arbitrary runtime dependencies, and UAT will distribute them when packaging. However when there's a lot of files in elaborate folder structure it is quite a chore to list them all in module rules.

Nuke.Unreal comes with a feature dubbed "Auto Runtime Dependencies" which can generate partial module rules sorting them out for each platform and configuration. This is only meant to be used for large, prebuilt libraries ususally downloaded or pre-installed for a project. Libraries fetched in other ways like the XRepo workflow, doesn't need this feature, as the same problem is solved there in a different way.

Here's the overview of the usage of `PrepareRuntimeDependencies` function:

1. Provide a source folder for the runtime dependencies
2. Provide a set of locations in runtime, relative to the destination folder serving as runtime library paths (ideally one for each supported platforms). This may be used as base folders to load DLL's from.
3. If applicable provide pattern matching functions to determine the platform and configuration for individual files
4. To control the destination folder structure `PrepareRuntimeDependencies` may pick up a folder composition manifest file called "RuntimeDeps.yml" (by default this can be also overridden)
5. If no such manifest is available one can be passed directly in C#

The module rule will copy output files on building the project to `<plugin-directory>/Binaries/<binariesSubfolder>/<moduleName>`. Where `binariesSubfolder` is "ThirdParty" by default.

For example have the following file structure of a module representing a third-party library:

```
TpModule
├── ...
├── LibraryFiles
│   ├── includes ...
│   └── lib
│       ├── win_amd64
│       │   ├── rel
│       │   │   ├── libtp.lib
│       │   │   └── *.dll
│       │   └── debug
│       │       ├── libtp.lib
│       │       └── *.dll
│       └── linux_x86_64
│           ├── rel
│           │   ├── libtp.lib
│           │   └── *.so
│           └── debug
│               ├── libtp.lib
│               └── *.so
├── RuntimeDeps.yml
├── TpModule.Build.cs
└── TpModule.nuke.cs
```

```yaml
# RuntimeDeps.yml
copy:
  - file: LibraryFiles/win_amd64/rel/*.dll
    as: Win64/Release/$1.dll
  - file: LibraryFiles/win_amd64/debug/*.dll
    as: Win64/Debug/$1.dll
  - file: LibraryFiles/linux_x86_64/rel/*.so
    as: Linux/Release/$1.so
  - file: LibraryFiles/linux_x86_64/debug/*.so
    as: Linux/Debug/$1.so
```

```CSharp
// TpModule.Build.cs

using System;
using UnrealBuildTool;

public partial class TpModule : ModuleRules
{
    public TpModule(ReadOnlyTargetRules target) : base(target)
    {
		Type = ModuleType.External;
        SetupRuntimeDependencies(target);
    }
    partial void SetupRuntimeDependencies(ReadOnlyTargetRules target);
}
```

```CSharp
// TpModule.nuke.cs

using Nuke.Common;
using Nuke.Cola;
using Nuke.Cola.BuildPlugins;
using Nuke.Unreal;

[ImplicitBuildInterface]
public interface IMyPluginTargets : INukeBuild
{
    Target PrepareMyPlugin => _ => _
        .Executes(() =>
        {
            this.PrepareRuntimeDependencies(
                this.ScriptFolder(),
                [
                    new() {
                        Path = (RelativePath)"Win64/Release",
                        Config = RuntimeDependencyConfig.Release,
                        Platform = UnrealPlatform.Win64
                    },
                    new() {
                        Path = (RelativePath)"Win64/Debug",
                        Config = RuntimeDependencyConfig.Debug,
                        Platform = UnrealPlatform.Win64
                    },
                    new() {
                        Path = (RelativePath)"Linux/Release",
                        Config = RuntimeDependencyConfig.Release,
                        Platform = UnrealPlatform.Linux
                    },
                    new() {
                        Path = (RelativePath)"Linux/Debug",
                        Config = RuntimeDependencyConfig.Debug,
                        Platform = UnrealPlatform.Linux
                    },
                ],
                determineConfig: f =>
                    f.ToString().Contains("rel")
                    ? RuntimeDependencyConfig.Release
                    : f.ToString().Contains("debug")
                    ? RuntimeDependencyConfig.Debug
                    : RuntimeDependencyConfig.All
                ,
                determinePlatform: f =>
                    f.ToString().Contains("win_amd64")
                    ? UnrealPlatform.Win64
                    : f.ToString().Contains("linux_x86_64")
                    ? UnrealPlatform.Linux
                    : UnrealPlatform.Independent
            );
        });
}
```

<details>
<summary>Will generate a partial module rule file:</summary>

```CSharp

// TpModule.Rtd.Build.cs
// This is an automatically generated file, do not modify

using System;
using UnrealBuildTool;

public partial class TpModule : ModuleRules
{
	void HandleRuntimeLibraryPath(string path)
	{
		PublicRuntimeLibraryPaths.Add($"{PluginDirectory}/{path}");
		PublicDefinitions.Add($"TPMODULE_DLL_PATH=TEXT(\"{path}\")");
	}

	void HandleRuntimeDependency(string from, string to) =>
		RuntimeDependencies.Add(
			$"{PluginDirectory}/{from}", $"{PluginDirectory}/{to}",
			StagedFileType.SystemNonUFS
		);

	partial void SetupRuntimeDependencies(ReadOnlyTargetRules target)
	{
		var Win64 =       target.Platform == UnrealTargetPlatform.Win64;
		var Mac =         target.Platform == UnrealTargetPlatform.Mac;
		var Linux =       target.Platform == UnrealTargetPlatform.Linux;
		var LinuxArm64 =  target.Platform == UnrealTargetPlatform.LinuxArm64;
		var Android =     target.Platform == UnrealTargetPlatform.Android;
		var IOS =         target.Platform == UnrealTargetPlatform.IOS;
		var TVOS =        target.Platform == UnrealTargetPlatform.TVOS;
		var VisionOS =    target.Platform == UnrealTargetPlatform.VisionOS;
		var Independent = true;

		var Debug = Target.Configuration <= UnrealTargetConfiguration.DebugGame;
		var Release = !Debug;
		var All = true;

		if (Release && Win64) HandleRuntimeLibraryPath("Binaries/ThirdParty/TpModule/Win64/Release");
		if (Debug && Win64) HandleRuntimeLibraryPath("Binaries/ThirdParty/TpModule/Win64/Debug");
		if (Release && Linux) HandleRuntimeLibraryPath("Binaries/ThirdParty/TpModule/Linux/Release");
		if (Debug && Linux) HandleRuntimeLibraryPath("Binaries/ThirdParty/TpModule/Linux/Debug");

		if (Release && Win64) HandleRuntimeDependency("Source/ThirdParty/TpModule/LibraryFiles/lib/win_amd64/rel/foo.dll", "Binaries/ThirdParty/TpModule/Win64/Release/foo.dll");
		if (Release && Win64) HandleRuntimeDependency("Source/ThirdParty/TpModule/LibraryFiles/lib/win_amd64/rel/bar.dll", "Binaries/ThirdParty/TpModule/Win64/Release/bar.dll");
		if (Release && Win64) HandleRuntimeDependency("Source/ThirdParty/TpModule/LibraryFiles/lib/win_amd64/rel/etc.dll", "Binaries/ThirdParty/TpModule/Win64/Release/etc.dll");
		if (Debug && Win64) HandleRuntimeDependency("Source/ThirdParty/TpModule/LibraryFiles/lib/win_amd64/debug/foo.dll", "Binaries/ThirdParty/TpModule/Win64/Debug/foo.dll");
		if (Debug && Win64) HandleRuntimeDependency("Source/ThirdParty/TpModule/LibraryFiles/lib/win_amd64/debug/bar.dll", "Binaries/ThirdParty/TpModule/Win64/Debug/bar.dll");
		if (Debug && Win64) HandleRuntimeDependency("Source/ThirdParty/TpModule/LibraryFiles/lib/win_amd64/debug/etc.dll", "Binaries/ThirdParty/TpModule/Win64/Debug/etc.dll");
		if (Release && Linux) HandleRuntimeDependency("Source/ThirdParty/TpModule/LibraryFiles/lib/linux_x86_64/rel/foo.so", "Binaries/ThirdParty/TpModule/Linux/Release/foo.so");
		if (Release && Linux) HandleRuntimeDependency("Source/ThirdParty/TpModule/LibraryFiles/lib/linux_x86_64/rel/bar.so", "Binaries/ThirdParty/TpModule/Linux/Release/bar.so");
		if (Release && Linux) HandleRuntimeDependency("Source/ThirdParty/TpModule/LibraryFiles/lib/linux_x86_64/rel/etc.so", "Binaries/ThirdParty/TpModule/Linux/Release/etc.so");
		if (Debug && Linux) HandleRuntimeDependency("Source/ThirdParty/TpModule/LibraryFiles/lib/linux_x86_64/debug/foo.so", "Binaries/ThirdParty/TpModule/Linux/Debug/foo.so");
		if (Debug && Linux) HandleRuntimeDependency("Source/ThirdParty/TpModule/LibraryFiles/lib/linux_x86_64/debug/bar.so", "Binaries/ThirdParty/TpModule/Linux/Debug/bar.so");
		if (Debug && Linux) HandleRuntimeDependency("Source/ThirdParty/TpModule/LibraryFiles/lib/linux_x86_64/debug/etc.so", "Binaries/ThirdParty/TpModule/Linux/Debug/etc.so");

		if (Release && Win64) PublicDelayLoadDLLs.Add("foo.dll");
		if (Release && Win64) PublicDelayLoadDLLs.Add("bar.dll");
		if (Release && Win64) PublicDelayLoadDLLs.Add("etc.dll");
		if (Debug && Win64) PublicDelayLoadDLLs.Add("foo.dll");
		if (Debug && Win64) PublicDelayLoadDLLs.Add("bar.dll");
		if (Debug && Win64) PublicDelayLoadDLLs.Add("etc.dll");
		if (Release && Linux) PublicDelayLoadDLLs.Add("foo.so");
		if (Release && Linux) PublicDelayLoadDLLs.Add("bar.so");
		if (Release && Linux) PublicDelayLoadDLLs.Add("etc.so");
		if (Debug && Linux) PublicDelayLoadDLLs.Add("foo.so");
		if (Debug && Linux) PublicDelayLoadDLLs.Add("bar.so");
		if (Debug && Linux) PublicDelayLoadDLLs.Add("etc.so");
		
		var dllList = string.Join(',', PublicDelayLoadDLLs.Select(d => $"TEXT(\"{d}\")"));
		PublicDefinitions.Add($"TPMODULE_DLL_FILES={dllList}");
	}
}
```

</details>

This is of course a toy example. As you can see though this may end up with quite a lot of boilerplate code, so again this is only recommended for libraries which needs a non-trivial folder structure of files and DLL's for its runtime.