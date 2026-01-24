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
[ParameterPrefix("yaml-cpp")]
public interface IUseYamlCpp : INukeBuild
{
    AbsolutePath YamlCppInputDir => this.ScriptFolder() / "yaml-cpp";

    string[] YamlCppConfigs => [ "Release", "Debug" ];

    Target PrepareYamlCpp => _ => _
        .DependentFor<UnrealBuild>(b => b.Prepare)
        .Executes(() =>
        {
            ((UnrealBuild) this).InstallXRepoLibrary(
                "vcpkg::yaml-cpp", "", this.ScriptFolder()
            );
        });
}