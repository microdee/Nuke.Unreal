// Fill in Copyright info...

using Nuke.Common;
using Nuke.Common.IO;
using Nuke.Common.Tooling;
using Nuke.Cola;
using Nuke.Cola.Tooling;
using Nuke.Cola.BuildPlugins;
using Nuke.Unreal;
using Nuke.Unreal.BoilerplateGenerators.XRepo;
using Serilog;
using System;

[ImplicitBuildInterface]
[ParameterPrefix("reflect-cpp")]
public interface IUseReflectCpp : IUnrealBuild
{
    AbsolutePath ReflectCppInputDir => this.ScriptFolder() / "reflect-cpp";

    string[] ReflectCppConfigs => [ "Release", "Debug" ];

    Target PrepareReflectCpp => _ => _
        .DependentFor(Prepare)
        .Executes(() =>
        {
            this.InstallXRepoLibrary(
                "reflect-cpp v0.24.0", "yaml=true", this.ScriptFolder(),
                supportedPlatforms: Unreal.Version(this) < (5,6)
                    ? [UnrealPlatform.Win64] // Allow only Windows
                    : null                   // Allow all platforms
            );
        });
}
