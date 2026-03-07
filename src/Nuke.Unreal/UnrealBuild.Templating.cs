using System;
using Nuke.Common;
using Nuke.Common.IO;
using Nuke.Common.Utilities.Collections;
using Nuke.Unreal.BoilerplateGenerators;
using Serilog;

// Maximum line length of long parameter description:
// ------------------------------------------------------------

namespace Nuke.Unreal
{
    public abstract partial class UnrealBuild : NukeBuild
    {

        /// <summary>
        /// Specify a folder containing generator specific folders for Scriban scaffolding and templates. If left empty
        /// the templates coming with Nuke.Unreal will be used.
        /// </summary>
        [Parameter]
        public virtual AbsolutePath TemplatesPath { get; set; } = BoilerplateGenerator.DefaultTemplateFolder;

        /// <summary>
        ///     Name parameter for boilerplate generators.
        /// </summary>
        [Parameter]
        public string[] Name { get; set; } = [];

        /// <summary>
        /// <para>
        ///     Specification(s) of the imported library(ies). This is used slightly differently based on which library
        ///     type is being used:
        /// </para>
        /// <para>
        ///     Header / CMake: It's only the name of the library (like `--spec spdlog`)
        /// </para>
        /// <para>
        ///     XRepo: specify the xrepo package reference and its config separated by space. For example:
        /// </para>
        /// <code>
        ///     --spec "zlib"
        ///     --spec "zlib 1.2.x"
        ///     --spec "boost regex=true,thread=true"
        ///     --spec "imgui 1.91.1 freetype=true"
        /// </code>
        /// <para>
        ///     Or multiple libraries at once
        /// </para>
        /// <code>
        ///     --spec "zlib 1.2.x" "boost regex=true,thread=true" "imgui 1.91.1 freetype=true"
        /// </code>
        /// <para>
        ///     More about xrepo: https://xrepo.xmake.io
        /// </para>
        /// </summary>
        /// <remarks>
        ///     Since Unreal uses MD runtime linkage `runtimes='MD'` config is always appended by Nuke.Unreal, and the
        ///     user must not specify it.
        /// </remarks>
        [Parameter]
        public virtual string[] Spec { get; set; } = [];

        /// <summary>
        /// Some boilerplate generators allows to define an extra suffix for names depending on their use case. For
        /// example `NewLibrary` can use the plain `Name` for library folder structure and `Name_MySuffix` for module
        /// names (when `Suffix` is set to `MySuffix`)
        /// </summary>
        [Parameter]
        public string? Suffix { get; set; }

        /// <summary>
        /// <para>
        ///     Specify the type of the third-party library being imported:
        /// </para>
        /// <para>
        ///     `Header`<br />
        ///     header only C++ library which doesn't need extra preparation
        /// </para>
        /// <para>
        ///     `CMake`<br />
        ///     generates an extra nuke target which prepares the CMake library to be used and distributed in Unreal.
        /// </para>
        /// <para>
        ///     `XRepo`<br />
        ///     generates an extra nuke target which then installs the library on preparation via the xrepo package
        ///     manager. The library for a specific platform will be available when running Prepare&lt;library&gt;,
        ///     Prepare or Generate targets.
        /// </para>
        /// </summary>
        [Parameter]
        public LibraryType? LibraryType { get; set; }

        /// <summary>
        /// Explicitly add new module to project target
        /// </summary>
        [Parameter]
        public bool AddToTarget { get; set; }

        /// <summary>
        /// Create new module in the owning project or plugin (depending on working directory)
        /// <code>
        ///     --Name (req,)
        ///     --AddToTarget
        ///     --TemplatesPath (adv.)
        /// </code>
        /// </summary>
        public Target NewModule => _ => _
            .Description(
                """
                |
                    | Create new module in the owning project or plugin
                    | (depending on working directory)
                    |
                    | --Name (req,)
                    | --AddToTarget
                    | --TemplatesPath (adv.)
                
                """
            )
            .Before(Generate)
            .Requires(() => Name)
            .Executes(() =>
                Name.ForEach(n => 
                    new ModuleGenerator()
                    .SetAddToTarget(AddToTarget)
                    .Generate(
                        TemplatesPath,
                        (AbsolutePath) Environment.CurrentDirectory,
                        n
                    )
                )
            );

        /// <summary>
        /// Add C++ code to a project which doesn't have one yet.
        /// <code>
        ///     --Name (req,)
        ///     --TemplatesPath (adv.)
        /// </code>
        /// </summary>
        public Target AddCode => _ => _
            .Description(
                """
                |
                    | Add C++ code to a project which doesn't have one yet.
                    |
                    | --Name (req,)
                    | --TemplatesPath (adv.)
                
                """
            )
            .Before(Generate)
            .Executes(() => 
                new TargetGenerator().Generate(
                    TemplatesPath,
                    ProjectFolder,
                    ProjectName
                )
            );

        /// <summary>
        /// Create a new project plugin.
        /// <code>
        ///     --Name (req,)
        ///     --TemplatesPath (adv.)
        /// </code>
        /// </summary>
        public Target NewPlugin => _ => _
            .Description(
                """
                |
                    | Create a new project plugin.
                    |
                    | --Name (req,)
                    | --TemplatesPath (adv.)
                    
                """
            )
            .Before(Generate)
            .Requires(() => Name)
            .Executes(() => 
                Name.ForEach(n => 
                    new PluginGenerator().Generate(
                        TemplatesPath,
                        (AbsolutePath) Environment.CurrentDirectory,
                        n, Unreal.Version(this)
                    )
                )
            );

        /// <summary>
        /// Create new Unreal Actor in current directory
        /// <code>
        ///     --Name (req,)
        ///     --TemplatesPath (adv.)
        /// </code>
        /// </summary>
        public Target NewActor => _ => _
            .Description(
                """
                |
                    | Create new Unreal Actor in current directory
                    |
                    | --Name (req,)
                    | --TemplatesPath (adv.)
                    
                """
            )
            .Before(Generate)
            .Requires(() => Name)
            .Executes(() =>
                Name.ForEach(n => 
                    new ActorGenerator().Generate(
                        TemplatesPath,
                        (AbsolutePath) Environment.CurrentDirectory,
                        new(n)
                    )
                )
            );

        /// <summary>
        /// Create new Unreal Interface in current directory
        /// <code>
        ///     --Name (req,)
        ///     --TemplatesPath (adv.)
        /// </code>
        /// </summary>
        public Target NewInterface => _ => _
            .Description(
                """
                |
                    | Create new Unreal Interface in current directory
                    |
                    | --Name (req,)
                    | --TemplatesPath (adv.)
                    
                """
            )
            .Before(Generate)
            .Requires(() => Name)
            .Executes(() =>
                Name.ForEach(n => 
                    new InterfaceGenerator().Generate(
                        TemplatesPath,
                        (AbsolutePath) Environment.CurrentDirectory,
                        new(n)
                    )
                )
            );

        /// <summary>
        /// Create new Unreal Object in current directory
        /// <code>
        ///     --Name (req,)
        ///     --TemplatesPath (adv.)
        /// </code>
        /// </summary>
        public Target NewObject => _ => _
            .Description(
                """
                |
                    | Create new Unreal Object in current directory
                    |
                    | --Name (req,)
                    | --TemplatesPath (adv.)
                    
                """
            )
            .Before(Generate)
            .Requires(() => Name)
            .Executes(() => 
                Name.ForEach(n => 
                    new ObjectGenerator().Generate(
                        TemplatesPath,
                        (AbsolutePath) Environment.CurrentDirectory,
                        new(n)
                    )
                )
            );

        /// <summary>
        /// Create new Unreal Struct in current directory
        /// <code>
        ///     --Name (req,)
        ///     --TemplatesPath (adv.)
        /// </code>
        /// </summary>
        public Target NewStruct => _ => _
            .Description(
                """
                |
                    | Create new Unreal Struct in current directory
                    |
                    | --Name (req,)
                    | --TemplatesPath (adv.)
                    
                """
            )
            .Before(Generate)
            .Requires(() => Name)
            .Executes(() => 
                Name.ForEach(n => 
                    new StructGenerator().Generate(
                        TemplatesPath,
                        (AbsolutePath) Environment.CurrentDirectory,
                        new(n)
                    )
                )
            );

        /// <summary>
        /// Create new Unreal Automation Spec in current directory
        /// <code>
        ///     --Name (req,)
        ///     --TemplatesPath (adv.)
        /// </code>
        /// </summary>
        public Target NewSpec => _ => _
            .Description(
                """
                |
                    | Create new Unreal Automation Spec in current directory
                    |
                    | --Name (req,)
                    | --TemplatesPath (adv.)
                    
                """
            )
            .Before(Generate)
            .Requires(() => Name)
            .Executes(() => 
                Name.ForEach(n => 
                    new SpecGenerator().Generate(
                        TemplatesPath,
                        (AbsolutePath) Environment.CurrentDirectory,
                        new(n)
                    )
                )
            );

        /// <summary>
        /// <para>
        ///     Create boilerplate module for third-party C++ libraries. Specify the kind of
        ///     library with `--library-type Header|CMake|XRepo` The latter two will generate
        ///     extra nuke targets preparing the library to be consumed by Unreal.
        ///     Fetching/storing the library is up to the developer
        ///     (except of course with XRepo).
        /// </para>
        /// <para>
        ///     Use type specific targets for more comfortable CLI experience, for example <br />
        ///     `nuke use-xrepo --spec tracy` <br />
        ///     instead of <br />
        ///     `nuke use-library --library-type xrepo --spec tracy`
        /// </para>
        /// <para>
        ///     This only needs to be done once, you can check the results into source control.
        /// </para>
        /// </summary>
        public Target UseLibrary => _ => _
            .Description(
                """

                    Create boilerplate module for third-party C++ libraries. Specify the kind of
                    library with `--library-type Header|CMake|XRepo` The latter two will generate
                    extra nuke targets preparing the library to be consumed by Unreal.
                    Fetching/storing the library is up to the developer
                    (except of course with XRepo).

                    Use type specific targets for more comfortable CLI experience, for example
                    nuke use-xrepo --spec tracy
                    instead of
                    nuke use-library --library-type xrepo --spec tracy

                    This only needs to be done once, you can check the results into source control.

                """
            )
            .DependsOn(EnsureBuildPluginSupport)
            .Before(Prepare, Generate)
            .Executes(() => 
            {
                Assert.NotEmpty(Spec);
                Assert.NotNull(LibraryType);
                
                Spec.ForEach(n =>
                    { 
                        Log.Information("Preparing library {0}", n);
                        new LibraryGenerator().Generate(
                            this,
                            TemplatesPath,
                            EnvironmentInfo.WorkingDirectory,
                            n, LibraryType!, Suffix
                        );
                    }
                );
                if (LibraryType == LibraryType.XRepo)
                    Log.Information("Run `Prepare` or `Generate` to install new libraries.");
                Log.Information("This only needs to be done once, you can check the results into source control.");
            });

        public Target UseXRepo => _ => _
            .Description(
                """
                
                    Use libraries from the xrepo package manager. This target only configures
                    another target which will eventually fetch the input libraries. To make them
                    available to Unreal run `Prepare` or `Generate` targets.

                    Specify the xrepo package reference and its config separated by space.
                    For example:

                    nuke use-xrepo --spec "zlib"
                    nuke use-xrepo --spec "zlib 1.2.x"
                    nuke use-xrepo --spec "boost regex=true,thread=true"
                    nuke use-xrepo --spec "imgui 1.91.1 freetype=true"

                    Use VCPKG via XRepo, note that specifying an explicit version is
                    not supported in VCPKG (bug in xrepo?)
                    nuke use-xrepo --spec "vcpkg::spdlog"

                    VCPKG features are supported
                    nuke use-xrepo --spec "vcpkg::spdlog[wchar]"

                    Use Conan via XRepo (note version is required and delimited with /)
                    nuke use-xrepo --spec "conan::zlib/1.2.11"

                    And of course multiple libraries can be used in one go
                    nuke use-xrepo --spec
                        "imgui 1.91.1 freetype=true"
                        "conan::zlib/1.2.11"
                        "vcpkg::spdlog[wchar]"
                        <etc...>

                    More about xrepo: https://xrepo.xmake.io
                    NOTE: since Unreal uses MD runtime linkage `runtimes='MD'` config is always
                    appended by Nuke.Unreal, and the user must not specify it.

                    This only needs to be done once, you can check the results into source control.
                
                """
            )
            .Triggers(UseLibrary)
            .Requires(() => Spec)
            .Executes(() => LibraryType = LibraryType.XRepo);

        public Target UseCMake => _ => _
            .Triggers(UseLibrary)
            .Requires(() => Spec)
            .Executes(() => LibraryType = LibraryType.CMake);

        public Target UseHeaderOnly => _ => _
            .Triggers(UseLibrary)
            .Requires(() => Spec)
            .Executes(() => LibraryType = LibraryType.Header);
    }
}
