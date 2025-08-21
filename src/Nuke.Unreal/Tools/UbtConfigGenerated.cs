
// This file is generated via `nuke generate-tools` target.
#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace Nuke.Unreal.Tools;
/// <summary>
/// The current hot reload mode
/// </summary>
public enum HotReloadMode
{
    
    Default,
    
    Disabled,
    
    FromIDE,
    
    FromEditor,
    
    LiveCoding,
}

/// <summary>
/// Controls how a particular warning is treated
/// </summary>
public enum WarningLevel
{
    /// <summary>
    /// Do not display diagnostics
    /// </summary>
    Off,
    /// <summary>
    /// Output warnings normally
    /// </summary>
    Warning,
    /// <summary>
    /// Output warnings as errors
    /// </summary>
    Error,
}

/// <summary>
/// Specifies which language standard to use. This enum should be kept in order, so that toolchains can check whether the requested setting is >= values that they support.
/// </summary>
public enum CppStandardVersion
{
    /// <summary>
    /// Use the default standard version
    /// </summary>
    Default,
    /// <summary>
    /// Supports C++14
    /// </summary>
    Cpp14,
    /// <summary>
    /// Supports C++17
    /// </summary>
    Cpp17,
    /// <summary>
    /// Latest standard supported by the compiler
    /// </summary>
    Latest,
}

/// <summary>
/// Available compiler toolchains on Windows platform
/// </summary>
public enum WindowsCompiler
{
    /// <summary>
    /// Use the default compiler. A specific value will always be used outside of configuration classes.
    /// </summary>
    Default,
    /// <summary>
    /// Use Clang for Windows, using the clang-cl driver.
    /// </summary>
    Clang,
    /// <summary>
    /// Use the Intel C++ compiler
    /// </summary>
    Intel,
    /// <summary>
    /// Visual Studio 2015 (Visual C++ 14.0)
    /// </summary>
    VisualStudio2015_DEPRECATED,
    /// <summary>
    /// Visual Studio 2015 (Visual C++ 14.0)
    /// </summary>
    VisualStudio2015,
    /// <summary>
    /// Visual Studio 2017 (Visual C++ 15.0)
    /// </summary>
    VisualStudio2017,
    /// <summary>
    /// Visual Studio 2019 (Visual C++ 16.0)
    /// </summary>
    VisualStudio2019,
    /// <summary>
    /// Visual Studio 2022 (Visual C++ 17.0)
    /// </summary>
    VisualStudio2022,
}

/// <summary>
/// Which static analyzer to use
/// </summary>
public enum WindowsStaticAnalyzer
{
    /// <summary>
    /// Do not perform static analysis
    /// </summary>
    None,
    /// <summary>
    /// Use the built-in Visual C++ static analyzer
    /// </summary>
    VisualCpp,
    /// <summary>
    /// Use PVS-Studio for static analysis
    /// </summary>
    PVSStudio,
}

/// <summary>
/// The type of target
/// </summary>
public enum TargetType
{
    /// <summary>
    /// Cooked monolithic game executable (GameName.exe).  Also used for a game-agnostic engine executable (UE4Game.exe or RocketGame.exe)
    /// </summary>
    Game,
    /// <summary>
    /// Uncooked modular editor executable and DLLs (UE4Editor.exe, UE4Editor*.dll, GameName*.dll)
    /// </summary>
    Editor,
    /// <summary>
    /// Cooked monolithic game client executable (GameNameClient.exe, but no server code)
    /// </summary>
    Client,
    /// <summary>
    /// Cooked monolithic game server executable (GameNameServer.exe, but no client code)
    /// </summary>
    Server,
    /// <summary>
    /// Program (standalone program, e.g. ShaderCompileWorker.exe, can be modular or monolithic depending on the program)
    /// </summary>
    Program,
}

/// <summary>
/// The type of configuration a target can be built for
/// </summary>
public enum UnrealTargetConfiguration
{
    /// <summary>
    /// Unknown
    /// </summary>
    Unknown,
    /// <summary>
    /// Debug configuration
    /// </summary>
    Debug,
    /// <summary>
    /// DebugGame configuration; equivalent to development, but with optimization disabled for game modules
    /// </summary>
    DebugGame,
    /// <summary>
    /// Development configuration
    /// </summary>
    Development,
    /// <summary>
    /// Shipping configuration
    /// </summary>
    Shipping,
    /// <summary>
    /// Test configuration
    /// </summary>
    Test,
}

/// <summary>
/// Output type for the static analyzer. This currently only works for the Clang static analyzer.
/// The Clang static analyzer can do either Text, which prints the analysis to stdout, or
/// html, where it writes out a navigable HTML page for each issue that it finds, per file.
/// The HTML is output in the same directory as the object fil that would otherwise have
/// been generated.
/// All other analyzers default automatically to Text.
/// </summary>
public enum WindowsStaticAnalyzerOutputType
{
    /// <summary>
    /// Output the analysis to stdout.
    /// </summary>
    Text,
    /// <summary>
    /// Output the analysis to an HTML file in the object folder.
    /// </summary>
    Html,
}

/// <summary>
/// What version of include order to use when compiling.
/// </summary>
public enum EngineIncludeOrderVersion
{
    /// <summary>
    /// Include order used in Unreal 5.0
    /// </summary>
    Unreal5_0,
    /// <summary>
    /// Include order used in Unreal 5.1
    /// </summary>
    Unreal5_1,
    /// <summary>
    /// Always use the latest version of include order.
    /// </summary>
    Latest,
    /// <summary>
    /// Contains the oldest version of include order that the engine supports.
    /// </summary>
    Oldest,
}

/// <summary>
/// Output type for the static analyzer. This currently only works for the Clang static analyzer.
/// The Clang static analyzer can do a shallow quick analysis. However the default deep is recommended.
/// </summary>
public enum StaticAnalyzerMode
{
    /// <summary>
    /// Default deep analysis.
    /// </summary>
    Deep,
    /// <summary>
    /// Quick analysis. Not recommended.
    /// </summary>
    Shallow,
}

/// <summary>
/// Specifies which C language standard to use. This enum should be kept in order, so that toolchains can check whether the requested setting is >= values that they support.
/// </summary>
public enum CStandardVersion
{
    /// <summary>
    /// Use the default standard version
    /// </summary>
    Default,
    /// <summary>
    /// Supports C89
    /// </summary>
    C89,
    /// <summary>
    /// Supports C99
    /// </summary>
    C99,
    /// <summary>
    /// Supports C11
    /// </summary>
    C11,
    /// <summary>
    /// Supports C17
    /// </summary>
    C17,
    /// <summary>
    /// Latest standard supported by the compiler
    /// </summary>
    Latest,
}

/// <summary>
/// Optimization mode for compiler settings
/// </summary>
public enum OptimizationMode
{
    /// <summary>
    /// Favor speed
    /// </summary>
    Speed,
    /// <summary>
    /// Favor minimal code size
    /// </summary>
    Size,
    /// <summary>
    /// Somewhere between Speed and Size
    /// </summary>
    SizeAndSpeed,
}

/// <summary>
/// Specifies the architecture for code generation on x64 for windows platforms.
/// Note that by enabling this you are changing the minspec for the PC platform, and the resultant executable will crash on machines without AVX support.
/// For more details please see https://learn.microsoft.com/en-us/cpp/build/reference/arch-x64
/// </summary>
public enum MinimumCpuArchitectureX64
{
    /// <summary>
    /// No minimum architecure
    /// </summary>
    None,
    /// <summary>
    /// Enables the use of Intel Advanced Vector Extensions instructions
    /// </summary>
    AVX,
    /// <summary>
    /// Enables the use of Intel Advanced Vector Extensions 2 instructions
    /// </summary>
    AVX2,
    /// <summary>
    /// Enables the use of Intel Advanced Vector Extensions 512 instructions
    /// </summary>
    AVX512,
    /// <summary>
    /// Use the default minimum architecure
    /// </summary>
    Default,
}

/// <summary>
/// Floating point math semantics
/// </summary>
public enum FPSemanticsMode
{
    /// <summary>
    /// Use the default semantics for the platform.
    /// </summary>
    Default,
    /// <summary>
    /// FP math is IEEE-754 compliant, assuming that FP exceptions are disabled and the rounding
    /// mode is round-to-nearest-even.
    /// </summary>
    Precise,
    /// <summary>
    /// FP math isn't IEEE-754 compliant: the compiler is allowed to transform math expressions
    /// in a ways that might result in differently rounded results from what IEEE-754 requires.
    /// </summary>
    Imprecise,
}

/// <summary>
/// Debug info mode for compiler settings to determine how much debug info is available
/// </summary>
public enum DebugInfoMode
{
    /// <summary>
    /// Disable all debugging info.
    /// MSVC: object files will be compiled without /Z7 or /Zi but pdbs will still be created
    /// callstacks should be available in this mode but there have been reports with them being incorrect
    /// </summary>
    None,
    /// <summary>
    /// Enable debug info for engine modules
    /// </summary>
    Engine,
    /// <summary>
    /// Enable debug info for engine plugins
    /// </summary>
    EnginePlugins,
    /// <summary>
    /// Enable debug info for project modules
    /// </summary>
    Project,
    /// <summary>
    /// Enable debug info for project plugins
    /// </summary>
    ProjectPlugins,
    /// <summary>
    /// Only include debug info for engine modules and plugins
    /// </summary>
    EngineOnly,
    /// <summary>
    /// Only include debug info for project modules and project plugins
    /// </summary>
    ProjectOnly,
    /// <summary>
    /// Include full debugging information for all modules
    /// </summary>
    Full,
}

/// <summary>
/// Target ARM64 CPU for codegen. This defines different ARM ISA and extension targets
/// </summary>
public enum Arm64TargetCpuType
{
    /// <summary>
    /// Default ARMv8.0-A ISA target CPU, supported by every 64 bit ARM CPU
    /// </summary>
    Default,
    /// <summary>
    /// AWS Graviton2 CPU - ARM Neoverse N1 uArch with ARMv8.2-A ISA + FP16 + rcpc + dotprod + crypto extensions
    /// </summary>
    Graviton2,
    /// <summary>
    /// AWS Graviton3 CPU - ARM Neoverse V1 uArch with AMRv8.4-A ISA + SVE + bf16 + rng + crypto extensions
    /// </summary>
    Graviton3,
}

/// <summary>
/// Which static analyzer to use
/// </summary>
public enum StaticAnalyzer
{
    /// <summary>
    /// Do not perform static analysis
    /// </summary>
    None,
    /// <summary>
    /// Use the default static analyzer for the selected compiler, if it has one. For
    /// Visual Studio and Clang, this means using their built-in static analysis tools.
    /// Any compiler that doesn't support static analysis will ignore this option.
    /// </summary>
    Default,
    /// <summary>
    /// Use the built-in Visual C++ static analyzer
    /// </summary>
    VisualCpp,
    /// <summary>
    /// Use PVS-Studio for static analysis
    /// </summary>
    PVSStudio,
    /// <summary>
    /// Use clang for static analysis. This forces the compiler to clang.
    /// </summary>
    Clang,
}

/// <summary>
/// Output type for the static analyzer. This currently only works for the Clang static analyzer.
/// The Clang static analyzer can do either Text, which prints the analysis to stdout, or
/// html, where it writes out a navigable HTML page for each issue that it finds, per file.
/// The HTML is output in the same directory as the object file that would otherwise have
/// been generated.
/// All other analyzers default automatically to Text.
/// </summary>
public enum StaticAnalyzerOutputType
{
    /// <summary>
    /// Output the analysis to stdout.
    /// </summary>
    Text,
    /// <summary>
    /// Output the analysis to an HTML file in the object folder.
    /// </summary>
    Html,
}

/// <summary>
/// The type of project files to generate
/// </summary>
public enum ProjectFileFormat
{
    
    Make,
    
    CMake,
    
    QMake,
    
    KDevelop,
    
    CodeLite,
    
    VisualStudio,
    
    VisualStudio2012,
    
    VisualStudio2013,
    
    VisualStudio2015,
    
    VisualStudio2017,
    
    VisualStudio2019,
    
    VisualStudio2022,
    
    XCode,
    
    Eddie,
    
    VisualStudioCode,
    
    VisualStudioMac,
    
    CLion,
    
    Rider,
}

/// <summary>
/// Enum for the type of documentation to generate
/// </summary>
public enum DocumentationType
{
    
    BuildConfiguration,
    
    ModuleRules,
    
    TargetRules,
}


public enum QueryType
{
    
    Capabilities,
    
    AvailableTargets,
    
    TargetDetails,
}


public enum PipAction
{
    
    OnlySetupParse,
    
    OnlyInstall,
    
    GenRequirements,
    
    Setup,
    
    Parse,
    
    Install,
    
    ViewLicenses,
}


/// <summary>Unreal Build Tool defines the Unreal project structure and provides unified source building utilities over multiple platforms</summary>
public abstract class UbtConfigGenerated : ToolConfig
{
    public override string Name => "Ubt";
    public override string CliName => "";
    public override UnrealCompatibility Compatibility => UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest;
    
/// <summary>The amount of detail to write to the log
/// Increase output verbosity</summary>
        public virtual UbtConfig Verbose(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Verbose",
                    Value: null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>The amount of detail to write to the log
/// Increase output verbosity more</summary>
        public virtual UbtConfig VeryVerbose(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-VeryVerbose",
                    Value: null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>Specifies the path to a log file to write. Note that the default mode (eg. building, generating project files) will create a log file by default if this not specified.
/// Specify a log file location instead of the default Engine/Programs/UnrealBuildTool/Log.txt
/// Specify a log file location instead of the default Engine/Programs/UnrealHeaderTool/Saved/Logs/UnrealHeaderTool.log</summary>
        public virtual UbtConfig Log(object val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Log",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>Whether to include timestamps in the log
/// Include timestamps in the log</summary>
        public virtual UbtConfig Timestamps(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Timestamps",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>Whether to format messages in MsBuild format
/// Format messages for msbuild
/// Whether UBT is invoked from MSBuild.
/// If false will, disable bDontBundleLibrariesInAPK, unless forced .</summary>
        public virtual UbtConfig FromMsBuild(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-FromMsBuild",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>Whether to write progress markup in a format that can be parsed by other programs
/// Write progress messages in a format that can be parsed by other programs</summary>
        public virtual UbtConfig Progress(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Progress",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>Whether to ignore the mutex
/// Allow more than one instance of the program to run at once</summary>
        public virtual UbtConfig NoMutex(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-NoMutex",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>Whether to wait for the mutex rather than aborting immediately
/// Wait for another instance to finish and then start, rather than aborting immediately</summary>
        public virtual UbtConfig WaitMutex(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-WaitMutex",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>Whether to wait for the mutex rather than aborting immediately
/// Remote tool ini directory</summary>
        public virtual UbtConfig RemoteIni(object val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-RemoteIni",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// The mode to execute
/// </summary>
        public virtual UbtConfig Mode(object val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Mode",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>The mode to execute
/// Clean build products. Equivalent to -Mode=Clean</summary>
        public virtual UbtConfig Clean(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Clean",
                    Value: null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>The mode to execute
/// Generate project files based on IDE preference. Equivalent to -Mode=GenerateProjectFiles</summary>
        public virtual UbtConfig ProjectFiles(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-ProjectFiles",
                    Value: null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>The mode to execute
/// Generate project files in specified format. May be used multiple times.</summary>
        public virtual UbtConfig ProjectFileFormat(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-ProjectFileFormat",
                    Value: null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>The mode to execute
/// Generate Linux Makefile
/// Generate Makefile</summary>
        public virtual UbtConfig Makefile(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Makefile",
                    Value: null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>The mode to execute
/// Generate project files for CMake</summary>
        public virtual UbtConfig CMakefile(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-CMakefile",
                    Value: null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>The mode to execute
/// Generate project files for QMake</summary>
        public virtual UbtConfig QMakefile(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-QMakefile",
                    Value: null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>The mode to execute
/// Generate project files for KDevelop</summary>
        public virtual UbtConfig KDevelopfile(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-KDevelopfile",
                    Value: null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>The mode to execute
/// Generate project files for Codelite</summary>
        public virtual UbtConfig CodeliteFiles(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-CodeliteFiles",
                    Value: null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>The mode to execute
/// Generate project files for XCode</summary>
        public virtual UbtConfig XCodeProjectFiles(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-XCodeProjectFiles",
                    Value: null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// The mode to execute
/// </summary>
        public virtual UbtConfig EdditProjectFiles(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-EdditProjectFiles",
                    Value: null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>The mode to execute
/// Generate project files for Visual Studio Code</summary>
        public virtual UbtConfig VSCode(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-VSCode",
                    Value: null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>The mode to execute
/// Generate project files for Visual Studio Mac</summary>
        public virtual UbtConfig VSMac(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-VSMac",
                    Value: null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>The mode to execute
/// Generate project files for CLion</summary>
        public virtual UbtConfig CLion(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-CLion",
                    Value: null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>The mode to execute
/// Generate project files for Rider</summary>
        public virtual UbtConfig Rider(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Rider",
                    Value: null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// Use existing static libraries for all engine modules in this target.
/// </summary>
        public virtual UbtConfig UsePrecompiled(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-UsePrecompiled",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>Whether XGE may be used.
/// Whether XGE may be used if available, default is true.</summary>
        public virtual UbtConfig NoXGE(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-NoXGE",
                    Value: null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>Whether FASTBuild may be used.
/// Whether FASTBuild may be used if available, default is true.</summary>
        public virtual UbtConfig NoFASTBuild(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-NoFASTBuild",
                    Value: null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// Enables support for very fast iterative builds by caching target data. Turning this on causes Unreal Build Tool to emit
/// 'UBT Makefiles' for targets when they are built the first time. Subsequent builds will load these Makefiles and begin
/// outdatedness checking and build invocation very quickly. The caveat is that if source files are added or removed to
/// the project, UBT will need to gather information about those in order for your build to complete successfully. Currently,
/// you must run the project file generator after adding/removing source files to tell UBT to re-gather this information.
/// 
/// Events that can invalidate the 'UBT Makefile':
/// - Adding/removing .cpp files
/// - Adding/removing .h files with UObjects
/// - Adding new UObject types to a file that did not previously have any
/// - Changing global build settings (most settings in this file qualify)
/// - Changed code that affects how Unreal Header Tool works
/// 
/// You can force regeneration of the 'UBT Makefile' by passing the '-gather' argument, or simply regenerating project files.
/// 
/// This also enables the fast include file dependency scanning and caching system that allows Unreal Build Tool to detect out
/// of date dependencies very quickly. When enabled, a deep C++ include graph does not have to be generated, and instead,
/// we only scan and cache indirect includes for after a dependent build product was already found to be out of date. During the
/// next build, we will load those cached indirect includes and check for outdatedness.
/// </summary>
        public virtual UbtConfig NoUBTMakefiles(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-NoUBTMakefiles",
                    Value: null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>Number of actions that can be executed in parallel. If 0 then code will pick a default based
/// on the number of cores available. Only applies to the ParallelExecutor
/// Number of actions that can be executed in parallel. If 0 then code will pick a default based
/// on the number of cores and memory available. Applies to the ParallelExecutor, HybridExecutor, and LocalExecutor</summary>
        public virtual UbtConfig MaxParallelActions(double? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-MaxParallelActions",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// If true, force header regeneration. Intended for the build machine.
/// </summary>
        public virtual UbtConfig ForceHeaderGeneration(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-ForceHeaderGeneration",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// If true, do not build UHT, assume it is already built.
/// </summary>
        public virtual UbtConfig NoBuildUHT(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-NoBuildUHT",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>If true, fail if any of the generated header files is out of date.
/// Consider any changes to output files as being an error</summary>
        public virtual UbtConfig FailIfGeneratedCodeChanges(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-FailIfGeneratedCodeChanges",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// True if hot-reload from IDE is allowed.
/// </summary>
        public virtual UbtConfig NoHotReloadFromIDE(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-NoHotReloadFromIDE",
                    Value: null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// Whether to skip compiling rules assemblies and just assume they are valid
/// </summary>
        public virtual UbtConfig SkipRulesCompile(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-SkipRulesCompile",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// Foreign plugin to compile against this target
/// </summary>
        public virtual UbtConfig Plugin(object val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Plugin",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// Set of module names to compile.
/// </summary>
        public virtual UbtConfig Module(params object[] values)
        {
            if (true)
            {
                if (values != null)
                    foreach (var val in values)
                    {
                        AppendArgument(new UnrealToolArgument(
                            "-Module",
                            Value: val.ToString(),
                            Setter: '=',
                            Meta: new(
                                Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                                AllowMultiple: true
                            )
                        ));
                    }
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// Individual file(s) to compile
/// </summary>
        public virtual UbtConfig SingleFile(params object[] values)
        {
            if (true)
            {
                if (values != null)
                    foreach (var val in values)
                    {
                        AppendArgument(new UnrealToolArgument(
                            "-SingleFile",
                            Value: val.ToString(),
                            Setter: '=',
                            Meta: new(
                                Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                                AllowMultiple: true
                            )
                        ));
                    }
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// Whether to perform hot reload for this target
/// </summary>
        public virtual UbtConfig NoHotReload(HotReloadMode? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-NoHotReload",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// Whether to perform hot reload for this target
/// </summary>
        public virtual UbtConfig ForceHotReload(HotReloadMode? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-ForceHotReload",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// Whether to perform hot reload for this target
/// </summary>
        public virtual UbtConfig LiveCoding(HotReloadMode? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-LiveCoding",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// Export the actions for the target to a file
/// </summary>
        public virtual UbtConfig WriteActions(params object[] values)
        {
            if (true)
            {
                if (values != null)
                    foreach (var val in values)
                    {
                        AppendArgument(new UnrealToolArgument(
                            "-WriteActions",
                            Value: val.ToString(),
                            Setter: '=',
                            Meta: new(
                                Compatibility: UnrealCompatibility.UE_4,
                                AllowMultiple: true
                            )
                        ));
                    }
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// Path to a file containing a list of modules that may be modified for live coding.
/// </summary>
        public virtual UbtConfig LiveCodingModules(object val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-LiveCodingModules",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// Path to the manifest for passing info about the output to live coding
/// </summary>
        public virtual UbtConfig LiveCodingManifest(object val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-LiveCodingManifest",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// Suppress messages about building this target
/// </summary>
        public virtual UbtConfig Quiet(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Quiet",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// Build all the modules that are valid for this target type. Used for CIS and making installed engine builds.
/// </summary>
        public virtual UbtConfig AllModules(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-AllModules",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// Additional plugins that are built for this target type but not enabled.
/// </summary>
        public virtual UbtConfig BuildPlugin(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-BuildPlugin",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: true
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// Additional plugins that should be included for this target.
/// </summary>
        public virtual UbtConfig EnablePlugin(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-EnablePlugin",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: true
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// List of plugins to be disabled for this target. Note that the project file may still reference them, so they should be marked
/// as optional to avoid failing to find them at runtime.
/// </summary>
        public virtual UbtConfig DisablePlugin(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-DisablePlugin",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: true
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// Whether this target should be compiled as a DLL.  Requires LinkType to be set to TargetLinkType.Monolithic.
/// </summary>
        public virtual UbtConfig CompileAsDll(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-CompileAsDll",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// Whether to compile the Chaos physics plugin.
/// </summary>
        public virtual UbtConfig NoCompileChaos(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-NoCompileChaos",
                    Value: null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// Whether to compile the Chaos physics plugin.
/// </summary>
        public virtual UbtConfig CompileChaos(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-CompileChaos",
                    Value: null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// Whether to use the Chaos physics interface. This overrides the physx flags to disable APEX and NvCloth
/// </summary>
        public virtual UbtConfig NoUseChaos(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-NoUseChaos",
                    Value: null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// Whether to use the Chaos physics interface. This overrides the physx flags to disable APEX and NvCloth
/// </summary>
        public virtual UbtConfig UseChaos(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-UseChaos",
                    Value: null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// Enable RTTI for all modules.
/// </summary>
        public virtual UbtConfig Rtti(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-rtti",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>Enables "include what you use" by default for modules in this target. Changes the default PCH mode for any module in this project to PCHUsageMode.UseExplicitOrSharedPCHs.
/// Enables "include what you use" mode.</summary>
        public virtual UbtConfig IWYU(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-IWYU",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// Make static libraries for all engine modules as intermediates for this target.
/// </summary>
        public virtual UbtConfig Precompile(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Precompile",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// Whether to unify C++ code into larger files for faster compilation.
/// </summary>
        public virtual UbtConfig DisableUnity(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-DisableUnity",
                    Value: null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// Whether to force C++ source files to be combined into larger files for faster compilation.
/// </summary>
        public virtual UbtConfig ForceUnity(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-ForceUnity",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>Forces shadow variable warnings to be treated as errors on platforms that support it.
/// Forces shadow variable warnings to be treated as errors on platforms that support it.
/// MSVC -
/// https://learn.microsoft.com/en-us/cpp/error-messages/compiler-warnings/compiler-warning-level-4-c4456
/// 4456 - declaration of 'LocalVariable' hides previous local declaration
/// https://learn.microsoft.com/en-us/cpp/error-messages/compiler-warnings/compiler-warning-level-4-c4458
/// 4458 - declaration of 'parameter' hides class member
/// https://learn.microsoft.com/en-us/cpp/error-messages/compiler-warnings/compiler-warning-level-4-c4459
/// 4459 - declaration of 'LocalVariable' hides global declaration
/// Clang -
/// https://clang.llvm.org/docs/DiagnosticsReference.html#wshadow</summary>
        public virtual UbtConfig ShadowVariableErrors(WarningLevel? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-ShadowVariableErrors",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// New Monolithic Graphics drivers have optional "fast calls" replacing various D3d functions
/// </summary>
        public virtual UbtConfig FastMonoCalls(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-FastMonoCalls",
                    Value: null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// New Monolithic Graphics drivers have optional "fast calls" replacing various D3d functions
/// </summary>
        public virtual UbtConfig NoFastMonoCalls(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-NoFastMonoCalls",
                    Value: null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// Whether to stress test the C++ unity build robustness by including all C++ files files in a project from a single unified file.
/// </summary>
        public virtual UbtConfig StressTestUnity(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-StressTestUnity",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// Whether to force debug info to be generated.
/// </summary>
        public virtual UbtConfig ForceDebugInfo(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-ForceDebugInfo",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>Whether to globally disable debug info generation; see DebugInfoHeuristics.cs for per-config and per-platform options.
/// How much debug info should be generated. See DebugInfoMode enum for more details</summary>
        public virtual UbtConfig NoDebugInfo(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-NoDebugInfo",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// Whether PDB files should be used for Visual C++ builds.
/// </summary>
        public virtual UbtConfig NoPDB(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-NoPDB",
                    Value: null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// Whether PCH files should be used.
/// </summary>
        public virtual UbtConfig NoPCH(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-NoPCH",
                    Value: null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// Whether to just preprocess source files for this target, and skip compilation
/// </summary>
        public virtual UbtConfig Preprocess(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Preprocess",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// Whether to use incremental linking or not. Incremental linking can yield faster iteration times when making small changes.
/// Currently disabled by default because it tends to behave a bit buggy on some computers (PDB-related compile errors).
/// </summary>
        public virtual UbtConfig IncrementalLinking(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-IncrementalLinking",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// Whether to use incremental linking or not. Incremental linking can yield faster iteration times when making small changes.
/// Currently disabled by default because it tends to behave a bit buggy on some computers (PDB-related compile errors).
/// </summary>
        public virtual UbtConfig NoIncrementalLinking(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-NoIncrementalLinking",
                    Value: null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// Whether to allow the use of link time code generation (LTCG).
/// </summary>
        public virtual UbtConfig LTCG(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-LTCG",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// Whether to enable Profile Guided Optimization (PGO) instrumentation in this build.
/// </summary>
        public virtual UbtConfig PGOProfile(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-PGOProfile",
                    Value: null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// Whether to optimize this build with Profile Guided Optimization (PGO).
/// </summary>
        public virtual UbtConfig PGOOptimize(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-PGOOptimize",
                    Value: null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// Enables "Shared PCHs", a feature which significantly speeds up compile times by attempting to
/// share certain PCH files between modules that UBT detects is including those PCH's header files.
/// </summary>
        public virtual UbtConfig NoSharedPCH(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-NoSharedPCH",
                    Value: null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// Whether to use the :FASTLINK option when building with /DEBUG to create local PDBs on Windows. Fast, but currently seems to have problems finding symbols in the debugger.
/// </summary>
        public virtual UbtConfig FastPDB(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-FastPDB",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// Outputs a map file as part of the build.
/// </summary>
        public virtual UbtConfig MapFile(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-MapFile",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// Bundle version for Mac apps.
/// </summary>
        public virtual UbtConfig BundleVersion(object val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-BundleVersion",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// Whether to deploy the executable after compilation on platforms that require deployment.
/// </summary>
        public virtual UbtConfig Deploy(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Deploy",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// Whether to force skipping deployment for platforms that require deployment by default.
/// </summary>
        public virtual UbtConfig SkipDeploy(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-SkipDeploy",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// Whether to disable linking for this target.
/// </summary>
        public virtual UbtConfig NoLink(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-NoLink",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>Indicates that this is a formal build, intended for distribution. This flag is automatically set to true when Build.version has a changelist set.
/// The only behavior currently bound to this flag is to compile the default resource file separately for each binary so that the OriginalFilename field is set correctly.
/// By default, we only compile the resource once to reduce build times.
/// Indicates that this is a formal build, intended for distribution. This flag is automatically set to true when Build.version has a changelist set and is a promoted build.
/// The only behavior currently bound to this flag is to compile the default resource file separately for each binary so that the OriginalFilename field is set correctly.
/// By default, we only compile the resource once to reduce build times.</summary>
        public virtual UbtConfig Formal(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Formal",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// Whether to clean Builds directory on a remote Mac before building.
/// </summary>
        public virtual UbtConfig FlushMac(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-FlushMac",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// Whether to write detailed timing info from the compiler and linker.
/// </summary>
        public virtual UbtConfig Timing(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Timing",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// Whether to parse timing data into a tracing file compatible with chrome://tracing.
/// </summary>
        public virtual UbtConfig Tracing(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Tracing",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// Whether to expose all symbols as public by default on POSIX platforms
/// </summary>
        public virtual UbtConfig PublicSymbolsByDefault(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-PublicSymbolsByDefault",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// Allows overriding the toolchain to be created for this target. This must match the name of a class declared in the UnrealBuildTool assembly.
/// </summary>
        public virtual UbtConfig ToolChain(object val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-ToolChain",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>Which C++ stanard to use for compiling this target
/// Which C++ standard to use for compiling this target (for non-engine modules)</summary>
        public virtual UbtConfig CppStd(CppStandardVersion? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-CppStd",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// Do not allow manifest changes when building this target. Used to cause earlier errors when building multiple targets with a shared build environment.
/// </summary>
        public virtual UbtConfig NoManifestChanges(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-NoManifestChanges",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// The build version string
/// </summary>
        public virtual UbtConfig BuildVersion(object val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-BuildVersion",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// Backing storage for the LinkType property.
/// </summary>
        public virtual UbtConfig Monolithic(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Monolithic",
                    Value: null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// Backing storage for the LinkType property.
/// </summary>
        public virtual UbtConfig Modular(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Modular",
                    Value: null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// Macros to define globally across the whole target.
/// </summary>
        public virtual UbtConfig Define(params object[] values)
        {
            if (true)
            {
                if (values != null)
                    foreach (var val in values)
                    {
                        AppendArgument(new UnrealToolArgument(
                            "-Define",
                            Value: val.ToString(),
                            Setter: ':',
                            Meta: new(
                                Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                                AllowMultiple: true
                            )
                        ));
                    }
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// Macros to define across all macros in the project.
/// </summary>
        public virtual UbtConfig ProjectDefine(params object[] values)
        {
            if (true)
            {
                if (values != null)
                    foreach (var val in values)
                    {
                        AppendArgument(new UnrealToolArgument(
                            "-ProjectDefine",
                            Value: val.ToString(),
                            Setter: ':',
                            Meta: new(
                                Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                                AllowMultiple: true
                            )
                        ));
                    }
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// Path to a manifest to output for this target
/// </summary>
        public virtual UbtConfig Manifest(params object[] values)
        {
            if (true)
            {
                if (values != null)
                    foreach (var val in values)
                    {
                        AppendArgument(new UnrealToolArgument(
                            "-Manifest",
                            Value: val.ToString(),
                            Setter: '=',
                            Meta: new(
                                Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                                AllowMultiple: true
                            )
                        ));
                    }
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// Path to a list of dependencies for this target, when precompiling
/// </summary>
        public virtual UbtConfig DependencyList(params object[] values)
        {
            if (true)
            {
                if (values != null)
                    foreach (var val in values)
                    {
                        AppendArgument(new UnrealToolArgument(
                            "-DependencyList",
                            Value: val.ToString(),
                            Setter: '=',
                            Meta: new(
                                Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                                AllowMultiple: true
                            )
                        ));
                    }
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// Backing storage for the BuildEnvironment property
/// </summary>
        public virtual UbtConfig SharedBuildEnvironment(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-SharedBuildEnvironment",
                    Value: null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// Backing storage for the BuildEnvironment property
/// </summary>
        public virtual UbtConfig UniqueBuildEnvironment(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-UniqueBuildEnvironment",
                    Value: null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// Whether to ignore violations to the shared build environment (eg. editor targets modifying definitions)
/// </summary>
        public virtual UbtConfig OverrideBuildEnvironment(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-OverrideBuildEnvironment",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// Additional arguments to pass to the compiler
/// </summary>
        public virtual UbtConfig CompilerArguments(object val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-CompilerArguments",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// Additional arguments to pass to the linker
/// </summary>
        public virtual UbtConfig LinkerArguments(object val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-LinkerArguments",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// Lists Architectures that you want to build
/// </summary>
        public virtual UbtConfig Architectures(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Architectures",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1,
                        AllowMultiple: true
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// Lists GPU Architectures that you want to build (mostly used for mobile etc.)
/// </summary>
        public virtual UbtConfig GPUArchitectures(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-GPUArchitectures",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1,
                        AllowMultiple: true
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// Ignore AppBundle (AAB) generation setting if "-ForceAPKGeneration" specified
/// </summary>
        public virtual UbtConfig ForceAPKGeneration(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-ForceAPKGeneration",
                    Value: null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>Version of the compiler toolchain to use on HoloLens. A value of "default" will be changed to a specific version at UBT startup.
/// Version of the compiler toolchain to use on Windows platform. A value of "default" will be changed to a specific version at UBT start up.</summary>
        public virtual UbtConfig _2015(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-2015",
                    Value: null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>Version of the compiler toolchain to use on HoloLens. A value of "default" will be changed to a specific version at UBT startup.
/// Version of the compiler toolchain to use on Windows platform. A value of "default" will be changed to a specific version at UBT start up.</summary>
        public virtual UbtConfig _2017(WindowsCompiler? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-2017",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>Version of the compiler toolchain to use on HoloLens. A value of "default" will be changed to a specific version at UBT startup.
/// Version of the compiler toolchain to use on Windows platform. A value of "default" will be changed to a specific version at UBT start up.</summary>
        public virtual UbtConfig _2019(WindowsCompiler? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-2019",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>Version of the compiler toolchain to use on HoloLens. A value of "default" will be changed to a specific version at UBT startup.
/// Version of the compiler toolchain to use on Windows platform. A value of "default" will be changed to a specific version at UBT start up.</summary>
        public virtual UbtConfig _2022(WindowsCompiler? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-2022",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// Whether to strip iOS symbols or not (implied by Shipping config).
/// </summary>
        public virtual UbtConfig Stripsymbols(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-stripsymbols",
                    Value: null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// If true, then a stub IPA will be generated when compiling is done (minimal files needed for a valid IPA).
/// </summary>
        public virtual UbtConfig CreateStub(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-CreateStub",
                    Value: null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// Don't generate crashlytics data
/// </summary>
        public virtual UbtConfig Alwaysgeneratedsym(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-alwaysgeneratedsym",
                    Value: null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// Don't generate crashlytics data
/// </summary>
        public virtual UbtConfig Skipcrashlytics(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-skipcrashlytics",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>Mark the build for distribution
/// If -distribution was passed on the commandline, this build is for distribution.</summary>
        public virtual UbtConfig Distribution(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-distribution",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// Manual override for the provision to use. Should be a full path.
/// </summary>
        public virtual UbtConfig ImportProvision(object val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-ImportProvision",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// Imports the given certificate (inc private key) into a temporary keychain before signing.
/// </summary>
        public virtual UbtConfig ImportCertificate(object val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-ImportCertificate",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// Password for the imported certificate
/// </summary>
        public virtual UbtConfig ImportCertificatePassword(object val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-ImportCertificatePassword",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// Whether to build the iOS project as a framework.
/// </summary>
        public virtual UbtConfig BuildAsFramework(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-build-as-framework",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// Whether to generate a dSYM file or not.
/// </summary>
        public virtual UbtConfig Generatedsymfile(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-generatedsymfile",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// Whether to generate a dSYM bundle (as opposed to single file dSYM)
/// </summary>
        public virtual UbtConfig Generatedsymbundle(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-generatedsymbundle",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>Enables address sanitizer (ASan)
/// Enables address sanitizer (ASan).
/// Enables address sanitizer (ASan). Only supported for Visual Studio 2019 16.7.0 and up.</summary>
        public virtual UbtConfig EnableASan(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-EnableASan",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>Enables thread sanitizer (TSan)
/// Enables thread sanitizer (TSan).</summary>
        public virtual UbtConfig EnableTSan(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-EnableTSan",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>Enables undefined behavior sanitizer (UBSan)
/// Enables undefined behavior sanitizer (UBSan).</summary>
        public virtual UbtConfig EnableUBSan(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-EnableUBSan",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// Enables memory sanitizer (MSan)
/// </summary>
        public virtual UbtConfig EnableMSan(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-EnableMSan",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>Enables "thin" LTO
/// When Link Time Code Generation (LTCG) is enabled, whether to
/// prefer using the lighter weight version on supported platforms.</summary>
        public virtual UbtConfig ThinLTO(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-ThinLTO",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// Version of the compiler toolchain to use on Windows platform. A value of "default" will be changed to a specific version at UBT start up.
/// </summary>
        public virtual UbtConfig Compiler(WindowsCompiler? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Compiler",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>The specific toolchain version to use. This may be a specific version number (for example, "14.13.26128"), the string "Latest" to select the newest available version, or
/// the string "Preview" to select the newest available preview version. By default, and if it is available, we use the toolchain version indicated by
/// WindowsPlatform.DefaultToolChainVersion (otherwise, we use the latest version).
/// The specific compiler version to use. This may be a specific version number (for example, "14.13.26128"), the string "Latest" to select the newest available version, or
/// the string "Preview" to select the newest available preview version. By default, and if it is available, we use the toolchain version indicated by
/// WindowsPlatform.DefaultToolChainVersion (otherwise, we use the latest version).</summary>
        public virtual UbtConfig CompilerVersion(object val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-CompilerVersion",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>The static analyzer to use.
/// Whether static code analysis should be enabled.</summary>
        public virtual UbtConfig StaticAnalyzer(WindowsStaticAnalyzer? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-StaticAnalyzer",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// Whether we should export a file containing .obj to source file mappings.
/// </summary>
        public virtual UbtConfig ObjSrcMap(object val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-ObjSrcMap",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>Enables strict standard conformance mode (/permissive-) in VS2017+.
/// Enables strict standard conformance mode (/permissive-).</summary>
        public virtual UbtConfig Strict(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Strict",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// Print out files that are included by each source file
/// </summary>
        public virtual UbtConfig ShowIncludes(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-ShowIncludes",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// Platforms to generate project files for
/// </summary>
        public virtual UbtConfig Platforms(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Platforms",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: true
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// Target types to generate project files for
/// </summary>
        public virtual UbtConfig TargetTypes(params TargetType[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-TargetTypes",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: true
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// Target configurations to generate project files for
/// </summary>
        public virtual UbtConfig TargetConfigurations(params UnrealTargetConfiguration[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-TargetConfigurations",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: true
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// Projects to generate project files for
/// </summary>
        public virtual UbtConfig ProjectNames(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-ProjectNames",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: true
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// Should format JSON files in human readable form, or use packed one without indents
/// </summary>
        public virtual UbtConfig Minimize(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Minimize",
                    Value: null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>Log all attempts to write to the specified file
/// Trace writes requested to the specified file</summary>
        public virtual UbtConfig TraceWrites(object val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-TraceWrites",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>The mode to execute
/// Generate project files for Eddie</summary>
        public virtual UbtConfig EddieProjectFiles(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-EddieProjectFiles",
                    Value: null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// Whether debug info should be written to the console.
/// </summary>
        public virtual UbtConfig PrintDebugInfo(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-PrintDebugInfo",
                    Value: null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>Whether SN-DBS may be used.
/// Whether SN-DBS may be used if available, default is true.</summary>
        public virtual UbtConfig NoSNDBS(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-NoSNDBS",
                    Value: null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// Whether to force compiling rules assemblies, regardless of whether they are valid
/// </summary>
        public virtual UbtConfig ForceRulesCompile(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-ForceRulesCompile",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// Lists of files to compile
/// </summary>
        public virtual UbtConfig FileList(params object[] values)
        {
            if (true)
            {
                if (values != null)
                    foreach (var val in values)
                    {
                        AppendArgument(new UnrealToolArgument(
                            "-FileList",
                            Value: val.ToString(),
                            Setter: '=',
                            Meta: new(
                                Compatibility: UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                                AllowMultiple: true
                            )
                        ));
                    }
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// Individual file(s) to compile
/// </summary>
        public virtual UbtConfig File(params object[] values)
        {
            if (true)
            {
                if (values != null)
                    foreach (var val in values)
                    {
                        AppendArgument(new UnrealToolArgument(
                            "-File",
                            Value: val.ToString(),
                            Setter: '=',
                            Meta: new(
                                Compatibility: UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                                AllowMultiple: true
                            )
                        ));
                    }
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// If a non-zero value, a live coding request will be terminated if more than the given number of actions are required.
/// </summary>
        public virtual UbtConfig LiveCodingLimit(double? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-LiveCodingLimit",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// Clean the target before trying to build it
/// </summary>
        public virtual UbtConfig Rebuild(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Rebuild",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// Whether to use the verse script interface.
/// </summary>
        public virtual UbtConfig NoUseVerse(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-NoUseVerse",
                    Value: null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// Whether to use the verse script interface.
/// </summary>
        public virtual UbtConfig UseVerse(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-UseVerse",
                    Value: null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>Use a heuristic to determine which files are currently being iterated on and exclude them from unity blobs, result in faster
/// incremental compile times. The current implementation uses the read-only flag to distinguish the working set, assuming that files will
/// be made writable by the source control system if they are being modified. This is true for Perforce, but not for Git.
/// Use a heuristic to determine which files are currently being iterated on and exclude them from unity blobs. This results in faster
/// incremental compile times. For Perforce repositories, the current implementation uses the read-only flag to distinguish the working
/// set, assuming that files will be made writable by the source control system if they are being modified. For Git repositories, the
/// implementation uses the git status command. Source code archives downloaded from Git as .zip files are not supported.</summary>
        public virtual UbtConfig DisableAdaptiveUnity(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-DisableAdaptiveUnity",
                    Value: null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>Whether to enable all warnings as errors. UE enables most warnings as errors already, but disables a few (such as deprecation warnings).
/// Treat warnings as errors</summary>
        public virtual UbtConfig WarningsAsErrors(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-WarningsAsErrors",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// Enables HW address sanitizer (HWASan)
/// </summary>
        public virtual UbtConfig EnableHWASan(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-EnableHWASan",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// Enables minimal undefined behavior sanitizer (UBSan)
/// </summary>
        public virtual UbtConfig EnableMinUBSan(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-EnableMinUBSan",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// Turns on tuning of debug info for LLDB
/// </summary>
        public virtual UbtConfig EnableLLDB(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-EnableLLDB",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// Enables the generation of .dsym files. This can be disabled to enable faster iteration times during development.
/// </summary>
        public virtual UbtConfig NoDSYM(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-NoDSYM",
                    Value: null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_0,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>The output type to use for the static analyzer.
/// The output type to use for the static analyzer. This is only supported for Clang.</summary>
        public virtual UbtConfig StaticAnalyzerOutputType(WindowsStaticAnalyzerOutputType? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-StaticAnalyzerOutputType",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>Set flags require for determinstic compiles (experimental)
/// Force set flags require for determinstic compiling and linking (experimental, may not be fully supported).
/// This setting is only recommended for testing, instead:
/// * Set bDeterministic on a per module basis in ModuleRules to control deterministic compiling.
/// * Set bDeterministic on a per target basis in TargetRules to control deterministic linking.
/// Set flags require for deterministic compiling and linking.
/// Enabling deterministic mode for msvc disables codegen multithreading so compiling will be slower</summary>
        public virtual UbtConfig Deterministic(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Deterministic",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>Whether or not to suppress warnings of missing SDKs from warnings to LogEventType.Log in UEBuildPlatformSDK.cs
/// Missing SDKs error verbosity level will be reduced from warning to log</summary>
        public virtual UbtConfig SuppressSDKWarnings(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-SuppressSDKWarnings",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// Whether Horde remote compute may be used. Highly experimental, disabled by default.
/// </summary>
        public virtual UbtConfig HordeCompute(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-HordeCompute",
                    Value: null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// Consider logical cores when determining how many total cpu cores are available.
/// </summary>
        public virtual UbtConfig AllCores(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-AllCores",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// When single file targets are specified, via -File=, -SingleFile=, or -FileList=
/// If this option is set, no error will be produced if the source file is not included in the target.
/// Additionally, if any file or file list is specified, the target will not be built if none of the specified files are part of that target,
/// including the case where a file specified via -FileList= is empty.
/// </summary>
        public virtual UbtConfig IgnoreInvalidFiles(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-IgnoreInvalidFiles",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// Instruct the executor to write compact output e.g. only errors, if supported by the executor.
/// This field is used to hold the value when specified from the command line or XML
/// </summary>
        public virtual UbtConfig CompactOutput(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-CompactOutput",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// Override the name used for this target
/// </summary>
        public virtual UbtConfig TargetNameOverride(object val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-TargetNameOverride",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// Force the include order to a specific version. Overrides any Target and Module rules.
/// </summary>
        public virtual UbtConfig ForceIncludeOrder(EngineIncludeOrderVersion? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-ForceIncludeOrder",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// Whether to use Iris.
/// </summary>
        public virtual UbtConfig NoUseIris(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-NoUseIris",
                    Value: null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// Whether to use Iris.
/// </summary>
        public virtual UbtConfig UseIris(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-UseIris",
                    Value: null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
    
        public virtual UbtConfig TrustedServer(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-TrustedServer",
                    Value: null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_1,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
    
        public virtual UbtConfig NoTrustedServer(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-NoTrustedServer",
                    Value: null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_1,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// Whether to merge module and generated unity files for faster compilation.
/// </summary>
        public virtual UbtConfig DisableMergingUnityFiles(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-DisableMergingUnityFiles",
                    Value: null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// Forces frame pointers to be retained this is usually required when you want reliable callstacks e.g. mallocframeprofiler
/// </summary>
        public virtual UbtConfig RetainFramePointers(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-RetainFramePointers",
                    Value: null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// Forces frame pointers to be retained this is usually required when you want reliable callstacks e.g. mallocframeprofiler
/// </summary>
        public virtual UbtConfig NoRetainFramePointers(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-NoRetainFramePointers",
                    Value: null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// An approximate number of bytes of C++ code to target for inclusion in a single unified C++ file.
/// </summary>
        public virtual UbtConfig BytesPerUnityCPP(double? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-BytesPerUnityCPP",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>Whether to add additional information to the unity files, such as '_of_X' in the file name.
/// Whether to add additional information to the unity files, such as '_of_X' in the file name. Not recommended.</summary>
        public virtual UbtConfig DetailedUnityFiles(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-DetailedUnityFiles",
                    Value: null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>Whether to add additional information to the unity files, such as '_of_X' in the file name.
/// Whether to add additional information to the unity files, such as '_of_X' in the file name. Not recommended.</summary>
        public virtual UbtConfig NoDetailedUnityFiles(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-NoDetailedUnityFiles",
                    Value: null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// Generate dependency files by preprocessing. This is only recommended when distributing builds as it adds additional overhead.
/// </summary>
        public virtual UbtConfig PreprocessDepends(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-PreprocessDepends",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// The mode to use for the static analyzer. This is only supported for Clang.
/// Shallow mode completes quicker but is generally not recommended.
/// </summary>
        public virtual UbtConfig StaticAnalyzerMode(StaticAnalyzerMode? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-StaticAnalyzerMode",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// Package full path (directory + filename) where to store input files used at link time
/// Normally used to debug a linker crash for platforms that support it
/// </summary>
        public virtual UbtConfig PackagePath(object val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-PackagePath",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// Directory where to put crash report files for platforms that support it
/// </summary>
        public virtual UbtConfig CrashDiagnosticDirectory(object val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-CrashDiagnosticDirectory",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// Disable supports for inlining gen.cpps
/// </summary>
        public virtual UbtConfig DisableInliningGenCpps(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-DisableInliningGenCpps",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// Which C standard to use for compiling this target
/// </summary>
        public virtual UbtConfig CStd(CStandardVersion? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-CStd",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>Disables all logging including the default log location
/// Disable log file creation including the default log file</summary>
        public virtual UbtConfig NoLog(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-NoLog",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>Run testing scripts</summary>
        public virtual UbtConfig Test(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Test",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>Disable concurrent parsing and code generation</summary>
        public virtual UbtConfig NoGoWide(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-NoGoWide",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>Write all the output to a reference directory</summary>
        public virtual UbtConfig WriteRef(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-WriteRef",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>Write all the output to a verification directory and compare to the reference output</summary>
        public virtual UbtConfig VerifyRef(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-VerifyRef",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>Do not save any output files other than reference output</summary>
        public virtual UbtConfig NoOutput(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-NoOutput",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>Include extra content in generated output to assist with debugging</summary>
        public virtual UbtConfig IncludeDebugOutput(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-IncludeDebugOutput",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>Disable all default exporters.  Useful for when a specific exporter is to be run</summary>
        public virtual UbtConfig NoDefaultExporters(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-NoDefaultExporters",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// Do not use Gradle if previous APK exists and only libUnreal.so changed
/// </summary>
        public virtual UbtConfig BypassGradlePackaging(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-BypassGradlePackaging",
                    Value: null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// Disables clang build verification checks on static libraries
/// </summary>
        public virtual UbtConfig Skipclangvalidation(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-skipclangvalidation",
                    Value: null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>Enables the generation of .dsym files. This can be disabled to enable faster iteration times during development.
/// Don't generate crashlytics data</summary>
        public virtual UbtConfig EnableDSYM(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-EnableDSYM",
                    Value: null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// Enables updated __cplusplus macro (/Zc:__cplusplus).
/// </summary>
        public virtual UbtConfig UpdatedCPPMacro(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-UpdatedCPPMacro",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// Enables inline conformance (Remove unreferenced COMDAT) (/Zc:inline).
/// </summary>
        public virtual UbtConfig StrictInline(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-StrictInline",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>Enables new preprocessor conformance (/Zc:preprocessor).
/// Enables new preprocessor conformance (/Zc:preprocessor). This is always enabled for C++20 modules.</summary>
        public virtual UbtConfig StrictPreprocessor(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-StrictPreprocessor",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// Enables enum types conformance (/Zc:enumTypes) in VS2022 17.4 Preview 4.0+.
/// </summary>
        public virtual UbtConfig StrictEnumTypes(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-StrictEnumTypes",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// When specified only primary project file (root.json) will be generated.
/// Normally project files for specific configurations are generated together with primary project file.
/// </summary>
        public virtual UbtConfig OnlyPrimaryProjectFile(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-OnlyPrimaryProjectFile",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// Enable Position Independent Executable (PIE). Has an overhead cost
/// </summary>
        public virtual UbtConfig Pie(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-pie",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// Enable Stack Protection. Has an overhead cost
/// </summary>
        public virtual UbtConfig StackProtect(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-stack-protect",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// Allows to fine tune optimizations level for speed and\or code size
/// </summary>
        public virtual UbtConfig OptimizationLevel(OptimizationMode? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-OptimizationLevel",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// Tells "include what you use" to only compile header files.
/// </summary>
        public virtual UbtConfig IWYUHeadersOnly(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-IWYUHeadersOnly",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_2,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// Disables overrides that are set by the module
/// </summary>
        public virtual UbtConfig DisableModuleNumIncludedBytesPerUnityCPPOverride(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-DisableModuleNumIncludedBytesPerUnityCPPOverride",
                    Value: null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// Directory where to put the ThinLTO cache on supported platforms.
/// </summary>
        public virtual UbtConfig ThinLTOCacheDirectory(object val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-ThinLTOCacheDirectory",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// Arguments that will be applied to prune the ThinLTO cache on supported platforms.
/// Arguments will only be applied if ThinLTOCacheDirectory is set.
/// </summary>
        public virtual UbtConfig ThinLTOCachePruningArguments(object val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-ThinLTOCachePruningArguments",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>True if we should use the Clang linker (LLD) when we are compiling with Clang, or Intel linker (xilink\xilib) when we are compiling with Intel oneAPI, otherwise we use the MSVC linker.
/// True if we should use the Clang linker (LLD) when we are compiling with Clang or Intel oneAPI, otherwise we use the MSVC linker.</summary>
        public virtual UbtConfig ClangLinker(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-ClangLinker",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>If specified along with -PGOProfile, then /FASTGENPROFILE will be used instead of /GENPROFILE.
/// This usually means that the PGO data is generated faster, but the resulting data may not yield as efficient optimizations during -PGOOptimize
/// If specified along with -PGOProfile, then /FASTGENPROFILE will be used instead of /GENPROFILE. This usually means that the PGO data is generated faster, but the resulting data may not yield as efficient optimizations during -PGOOptimize</summary>
        public virtual UbtConfig PGOFastGen(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-PGOFastGen",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// Do not create compile commands json files with compiler arguments for each file; works better with VS Code extension using
/// UBT server mode.
/// </summary>
        public virtual UbtConfig NoCompileCommands(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-NoCompileCommands",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// If set, artifacts will be read
/// </summary>
        public virtual UbtConfig ArtifactReads(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-ArtifactReads",
                    Value: null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// If set, artifacts will be read
/// </summary>
        public virtual UbtConfig NoArtifactReads(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-NoArtifactReads",
                    Value: null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// If set, artifacts will be written
/// </summary>
        public virtual UbtConfig ArtifactWrites(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-ArtifactWrites",
                    Value: null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// If set, artifacts will be written
/// </summary>
        public virtual UbtConfig NoArtifactWrites(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-NoArtifactWrites",
                    Value: null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// If true, log all artifact cache misses as informational messages
/// </summary>
        public virtual UbtConfig LogArtifactCacheMisses(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-LogArtifactCacheMisses",
                    Value: null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// Location to store the artifacts.
/// </summary>
        public virtual UbtConfig ArtifactDirectory(object val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-ArtifactDirectory",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// Whether we should treat the ForeignPlugin argument as a local plugin for building purposes
/// </summary>
        public virtual UbtConfig BuildPluginAsLocal(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-BuildPluginAsLocal",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// Relative path to file(s) to compile
/// </summary>
        public virtual UbtConfig Files(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Files",
                    Value: values != null && values.Length > 0 ? string.Join(";", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: true
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// Working directory when compiling with RelativePathsToSpecificFilesToCompile
/// </summary>
        public virtual UbtConfig WorkingDir(object val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-WorkingDir",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// Will build all files that directly include any of the files provided in -SingleFile
/// </summary>
        public virtual UbtConfig SingleFileBuildDependents(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-SingleFileBuildDependents",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// Adds header files in included modules to the build.
/// </summary>
        public virtual UbtConfig IncludeHeaders(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-IncludeHeaders",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// Set flags require for deterministic compiling and linking.
/// Enabling deterministic mode for msvc disables codegen multithreading so compiling will be slower
/// </summary>
        public virtual UbtConfig NonDeterministic(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-NonDeterministic",
                    Value: null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// Which C++ standard to use for compiling this target (for engine modules)
/// </summary>
        public virtual UbtConfig CppStdEngine(CppStandardVersion? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-CppStdEngine",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>Whether to use the AutoRTFM Clang compiler.
/// Whether to use force AutoRTFM Clang compiler off.</summary>
        public virtual UbtConfig NoUseAutoRTFM(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-NoUseAutoRTFM",
                    Value: null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// Whether to use the AutoRTFM Clang compiler.
/// </summary>
        public virtual UbtConfig UseAutoRTFM(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-UseAutoRTFM",
                    Value: null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// Whether to compile in Chaos Visual Debugger (CVD) support features to record the state of the physics simulation
/// </summary>
        public virtual UbtConfig CompileChaosVisualDebuggerSupport(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-CompileChaosVisualDebuggerSupport",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// When used with -IncludeHeaders, only header files will be compiled.
/// </summary>
        public virtual UbtConfig HeadersOnly(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-HeadersOnly",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// Indicates what warning/error level to treat potential PCH performance issues.
/// </summary>
        public virtual UbtConfig PCHPerformanceIssueWarningLevel(WarningLevel? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-PCHPerformanceIssueWarningLevel",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// How to treat general module include path validation messages
/// </summary>
        public virtual UbtConfig ModuleIncludePathWarningLevel(WarningLevel? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-ModuleIncludePathWarningLevel",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// How to treat private module include path validation messages, where a module is adding an include path that exposes private headers
/// </summary>
        public virtual UbtConfig ModuleIncludePrivateWarningLevel(WarningLevel? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-ModuleIncludePrivateWarningLevel",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// How to treat unnecessary module sub-directory include path validation messages
/// </summary>
        public virtual UbtConfig ModuleIncludeSubdirectoryWarningLevel(WarningLevel? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-ModuleIncludeSubdirectoryWarningLevel",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// Whether PDB files should be used for Visual C++ builds.
/// </summary>
        public virtual UbtConfig UsePDB(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-UsePDB",
                    Value: null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// Whether PCHs should be chained when compiling with clang.
/// </summary>
        public virtual UbtConfig NoPCHChain(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-NoPCHChain",
                    Value: null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// Whether to generate assembly data while compiling this target. Works exclusively on MSVC for now.
/// </summary>
        public virtual UbtConfig WithAssembly(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-WithAssembly",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// Whether the target requires code coverage compilation and linking.
/// </summary>
        public virtual UbtConfig CodeCoverage(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-CodeCoverage",
                    Value: null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// Whether to support edit and continue.
/// </summary>
        public virtual UbtConfig SupportEditAndContinue(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-SupportEditAndContinue",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>Direct the compiler to generate AVX instructions wherever SSE or AVX intrinsics are used, on the x64 platforms that support it.
/// Note that by enabling this you are changing the minspec for the PC platform, and the resultant executable will crash on machines without AVX support.
/// Direct the compiler to generate AVX instructions wherever SSE or AVX intrinsics are used, on the x64 platforms that support it. Ignored for arm64.
/// Note that by enabling this you are changing the minspec for the target platform, and the resultant executable will crash on machines without AVX support.</summary>
        public virtual UbtConfig MinCpuArchX64(MinimumCpuArchitectureX64? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-MinCpuArchX64",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>Enables LibFuzzer
/// Enables LibFuzzer.
/// Enables LibFuzzer. Only supported for Visual Studio 2022 17.0.0 and up.</summary>
        public virtual UbtConfig EnableLibFuzzer(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-EnableLibFuzzer",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// Whether to globally disable calling dump_syms
/// </summary>
        public virtual UbtConfig NoDumpSyms(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-NoDumpSyms",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// Version of the toolchain to use on Windows platform when a non-msvc Compiler is in use, to locate include paths etc.
/// </summary>
        public virtual UbtConfig VCToolchain(WindowsCompiler? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-VCToolchain",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// If -PGOOptimize is specified but the linker flags have changed since the last -PGOProfile, this will emit a warning and build without PGO instead of failing during link with LNK1268.
/// </summary>
        public virtual UbtConfig IgnoreStalePGOData(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-IgnoreStalePGOData",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// If specified along with -PGOProfile, prevent the usage of extra counters. Please note that by default /FASTGENPROFILE doesnt use extra counters
/// </summary>
/// <seealso href="link">https://learn.microsoft.com/en-us/cpp/build/reference/genprofile-fastgenprofile-generate-profiling-instrumented-build</seealso>
        public virtual UbtConfig PGONoExtraCounters(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-PGONoExtraCounters",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// The specific msvc toolchain version to use if the compiler is not msvc. This may be a specific version number (for example, "14.13.26128"), the string "Latest" to select the newest available version, or
/// the string "Preview" to select the newest available preview version. By default, and if it is available, we use the toolchain version indicated by
/// WindowsPlatform.DefaultToolChainVersion (otherwise, we use the latest version).
/// </summary>
        public virtual UbtConfig VCToolchainVersion(object val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-VCToolchainVersion",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// True if /fastfail should be passed to the msvc compiler and linker
/// </summary>
        public virtual UbtConfig VCFastFail(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-VCFastFail",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// The specific Windows SDK version to use. This may be a specific version number (for example, "8.1", "10.0" or "10.0.10150.0"), or the string "Latest", to select the newest available version.
/// By default, and if it is available, we use the Windows SDK version indicated by WindowsPlatform.DefaultWindowsSdkVersion (otherwise, we use the latest version).
/// </summary>
        public virtual UbtConfig WindowsSDKVersion(object val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-WindowsSDKVersion",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// Whether .sarif files containing errors and warnings are written alongside each .obj, if supported
/// </summary>
        public virtual UbtConfig Sarif(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Sarif",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// Specify an alternate location for the PDB file. This option does not change the location of the generated PDB file,
/// it changes the name that is embedded into the executable. Path can contain %_PDB% which will be expanded to the original
/// PDB file name of the target, without the directory.
/// See https://learn.microsoft.com/en-us/cpp/build/reference/pdbaltpath-use-alternate-pdb-path
/// </summary>
        public virtual UbtConfig PdbAltPath(object val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-PdbAltPath",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// Create a workspace file for use with VS Code extension that communicates directly with UBT.
/// </summary>
        public virtual UbtConfig UseVSCodeExtension(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-UseVSCodeExtension",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// Whether the UnrealBuildAccelerator executor will be used.
/// </summary>
        public virtual UbtConfig UBA(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-UBA",
                    Value: null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// Whether the UnrealBuildAccelerator executor will be used.
/// </summary>
        public virtual UbtConfig NoUBA(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-NoUBA",
                    Value: null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// Whether the UnrealBuildAccelerator (local only) executor will be used.
/// </summary>
        public virtual UbtConfig UBALocal(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-UBALocal",
                    Value: null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// Whether the UnrealBuildAccelerator (local only) executor will be used.
/// </summary>
        public virtual UbtConfig NoUBALocal(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-NoUBALocal",
                    Value: null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// When building a foreign plugin, whether to build plugins it depends on as well.
/// </summary>
        public virtual UbtConfig BuildDependantPlugins(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-BuildDependantPlugins",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// Extra subdirectory to load config files out of, for making multiple types of builds with the same platform
/// This will get baked into the game executable as CUSTOM_CONFIG and used when staging to filter files and settings
/// </summary>
        public virtual UbtConfig CustomConfig(object val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-CustomConfig",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// Whether to use the BPVM to run Verse.
/// </summary>
        public virtual UbtConfig NoUseVerseBPVM(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-NoUseVerseBPVM",
                    Value: null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// Whether to use the BPVM to run Verse.
/// </summary>
        public virtual UbtConfig UseVerseBPVM(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-UseVerseBPVM",
                    Value: null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// Allows setting the FP semantics.
/// </summary>
        public virtual UbtConfig FPSemantics(FPSemanticsMode? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-FPSemantics",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// How much debug info should be generated. See DebugInfoMode enum for more details
/// </summary>
        public virtual UbtConfig DebugInfo(DebugInfoMode? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-DebugInfo",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// Modules that should have debug info disabled
/// </summary>
        public virtual UbtConfig DisableDebugInfoModules(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-DisableDebugInfoModules",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: true
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// Plugins that should have debug info disabled
/// </summary>
        public virtual UbtConfig DisableDebugInfoPlugins(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-DisableDebugInfoPlugins",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: true
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// True if only debug line number tables should be emitted in debug information for compilers that support doing so. Overrides TargetRules.DebugInfo
/// See https://clang.llvm.org/docs/UsersManual.html#cmdoption-gline-tables-only for more information
/// </summary>
        public virtual UbtConfig DebugInfoLineTablesOnly(DebugInfoMode? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-DebugInfoLineTablesOnly",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// Modules that should emit line number tables instead of full debug information for compilers that support doing so. Overrides DisableDebugInfoModules
/// </summary>
        public virtual UbtConfig DebugInfoLineTablesOnlyModules(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-DebugInfoLineTablesOnlyModules",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: true
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// Plugins that should emit line number tables instead of full debug information for compilers that support doing so. Overrides DisableDebugInfoPlugins
/// </summary>
        public virtual UbtConfig DebugInfoLineTablesOnlyPlugins(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-DebugInfoLineTablesOnlyPlugins",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: true
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// The level of warnings to print when analyzing using PVS-Studio
/// </summary>
        public virtual UbtConfig StaticAnalyzerPVSPrintLevel(double? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-StaticAnalyzerPVSPrintLevel",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// Only run static analysis against project modules, skipping engine modules
/// </summary>
/// <remarks>PVS-Studio: warnings that are disabled via Engine/Source/Runtime/Core/Public/Microsoft/MicrosoftPlatformCodeAnalysis.h will be reenabled</remarks>
        public virtual UbtConfig StaticAnalyzerProjectOnly(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-StaticAnalyzerProjectOnly",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// When enabled, generated source files will be analyzed
/// </summary>
        public virtual UbtConfig StaticAnalyzerIncludeGenerated(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-StaticAnalyzerIncludeGenerated",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// Will replace pch with ifc and use header units instead. This is an experimental and msvc-only feature
/// </summary>
        public virtual UbtConfig HeaderUnits(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-HeaderUnits",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// A list of additional plugins which need to be included in this target. This allows referencing non-optional plugin modules
/// which cannot be disabled, and allows building against specific modules in program targets which do not fit the categories
/// in ModuleHostType.
/// </summary>
        public virtual UbtConfig AdditionalPlugins(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-AdditionalPlugins",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: true
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// Additional plugins that should be included for this target if they are found.
/// </summary>
        public virtual UbtConfig OptionalPlugins(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-OptionalPlugins",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: true
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// Number of second of no completed actions to trigger an action stall report.
/// If zero, stall reports will not be enabled.
/// </summary>
        public virtual UbtConfig ActionStallReportTime(double? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-ActionStallReportTime",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// When set to true, UBA will not use any remote help
/// </summary>
        public virtual UbtConfig UBADisableRemote(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-UBADisableRemote",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// When set to true, UBA will force all actions that can be built remotely to be built remotely. This will hang if there are no remote agents available
/// </summary>
        public virtual UbtConfig UBAForceRemote(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-UBAForceRemote",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>When set to true, actions that fail locally with UBA will be retried without UBA.
/// When set to true, all actions that fail locally with UBA will be retried without UBA.</summary>
        public virtual UbtConfig UBAForcedRetry(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-UBAForcedRetry",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// When set to true, all errors and warnings from UBA will be output at the appropriate severity level to the log (rather than being output as 'information' and attempting to continue regardless).
/// </summary>
        public virtual UbtConfig UBAStrict(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-UBAStrict",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// If UBA should store cas compressed or raw
/// </summary>
        public virtual UbtConfig UBAStoreRaw(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-UBAStoreRaw",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// If UBA should distribute linking to remote workers. This needs bandwidth but can be an optimization
/// </summary>
        public virtual UbtConfig UBALinkRemote(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-UBALinkRemote",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// The amount of gigabytes UBA is allowed to use to store workset and cached data. It is a good idea to have this &gt;10gb
/// </summary>
        public virtual UbtConfig UBAStoreCapacityGb(double? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-UBAStoreCapacityGb",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// Max number of worker threads that can handle messages from remotes.
/// </summary>
        public virtual UbtConfig UBAMaxWorkers(double? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-UBAMaxWorkers",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// Max size of each message sent from server to client
/// </summary>
        public virtual UbtConfig UBASendSize(double? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-UBASendSize",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// Which ip UBA server should listen to for connections
/// </summary>
        public virtual UbtConfig UBAHost(object val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-UBAHost",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// Which port UBA server should listen to for connections.
/// </summary>
        public virtual UbtConfig UBAPort(double? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-UBAPort",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// Which directory to store files for UBA.
/// </summary>
        public virtual UbtConfig UBARootDir(object val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-UBARootDir",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// Use Quic protocol instead of Tcp (experimental)
/// </summary>
        public virtual UbtConfig UBAQuic(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-UBAQuic",
                    Value: null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// Enable logging of UBA processes
/// </summary>
        public virtual UbtConfig UBALog(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-UBALog",
                    Value: null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// Prints summary of UBA stats at end of build
/// </summary>
        public virtual UbtConfig UBAPrintSummary(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-UBAPrintSummary",
                    Value: null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// Launch visualizer application which shows build progress
/// </summary>
        public virtual UbtConfig UBAVisualizer(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-UBAVisualizer",
                    Value: null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// Resets the cas cache
/// </summary>
        public virtual UbtConfig UBAResetCas(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-UBAResetCas",
                    Value: null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// Provide custom path for trace output file
/// </summary>
        public virtual UbtConfig UBATraceOutputFile(object val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-UBATraceOutputFile",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// Add verbose details to the UBA trace
/// </summary>
        public virtual UbtConfig UBADetailedTrace(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-UBADetailedTrace",
                    Value: null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// Disable UBA waiting on available memory before spawning new processes
/// </summary>
        public virtual UbtConfig UBADisableWaitOnMem(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-UBADisableWaitOnMem",
                    Value: null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// Let UBA kill running processes when close to out of memory
/// </summary>
        public virtual UbtConfig UBAAllowKillOnMem(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-UBAAllowKillOnMem",
                    Value: null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// Threshold for when executor should output logging for the process. Defaults to never
/// </summary>
        public virtual UbtConfig UBAOutputStatsThresholdMs(double? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-UBAOutputStatsThresholdMs",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// Skip writing intermediate and output files to disk. Useful for validation builds where we don't need the output
/// </summary>
        public virtual UbtConfig UBANoWrite(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-UBANoWrite",
                    Value: null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// Set to true to disable mimalloc and detouring of memory allocations.
/// </summary>
        public virtual UbtConfig UBANoCustomMalloc(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-UBANoCustomMalloc",
                    Value: null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// The zone to use for UBA.
/// </summary>
        public virtual UbtConfig UBAZone(object val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-UBAZone",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// Set to true to enable encryption when transferring files over the network.
/// </summary>
        public virtual UbtConfig UBACrypto(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-UBACrypto",
                    Value: null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// Set to true to provide known inputs to processes that are run remote. This is an experimental feature to speed up build times when ping is higher
/// </summary>
        public virtual UbtConfig UBAUseKnownInputs(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-UBAUseKnownInputs",
                    Value: null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// Write yaml file with all actions that are queued for build. This can be used to replay using "UbaCli.exe local file.yaml"
/// </summary>
        public virtual UbtConfig UBAActionsOutputFile(object val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-UBAActionsOutputFile",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// Set to true to see more info about what is happening inside uba and also log output from agents
/// </summary>
        public virtual UbtConfig UBADetailedLog(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-UBADetailedLog",
                    Value: null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// Uri of the Horde server
/// </summary>
        public virtual UbtConfig UBAHorde(object val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-UBAHorde",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>Uri of the Horde server
/// Auth token for the Horde server</summary>
        public virtual UbtConfig UBAHordeToken(object val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-UBAHordeToken",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// OIDC id for the login to use
/// </summary>
        public virtual UbtConfig UBAHordeOidc(object val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-UBAHordeOidc",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// Pool for the Horde agent to assign, only used for commandline override
/// </summary>
        public virtual UbtConfig UBAHordePool(object val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-UBAHordePool",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// Requirements for the Horde agent to assign
/// </summary>
        public virtual UbtConfig UBAHordeRequirements(object val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-UBAHordeRequirements",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// Which ip UBA server should give to agents. This will invert so host listens and agents connect
/// </summary>
        public virtual UbtConfig UBAHordeHost(object val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-UBAHordeHost",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// Max cores allowed to be used by build session
/// </summary>
        public virtual UbtConfig UBAHordeMaxCores(double? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-UBAHordeMaxCores",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// How long UBT should wait to ask for help. Useful in build configs where machine can delay remote work and still get same wall time results (pch dependencies etc)
/// </summary>
        public virtual UbtConfig UBAHordeDelay(double? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-UBAHordeDelay",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// Allow use of Wine. Only applicable to Horde agents running Linux. Can still be ignored if Wine executable is not set on agent.
/// </summary>
        public virtual UbtConfig UBAHordeAllowWine(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-UBAHordeAllowWine",
                    Value: null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// Connection mode for agent/compute communication
/// <see cref="ConnectionMode" /> for valid modes.
/// </summary>
        public virtual UbtConfig UBAHordeConnectionMode(object val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-UBAHordeConnectionMode",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// Encryption to use for agent/compute communication. Note that UBA agent uses its own encryption.
/// <see cref="Encryption" /> for valid modes.
/// </summary>
        public virtual UbtConfig UBAHordeEncryption(object val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-UBAHordeEncryption",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// Sentry URL to send box data to. Optional.
/// </summary>
        public virtual UbtConfig UBASentryUrl(object val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-UBASentryUrl",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// Disable horde all together
/// </summary>
        public virtual UbtConfig UBADisableHorde(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-UBADisableHorde",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// Forcing bDontBundleLibrariesInAPK to "true" or "false" ignoring any other option.
/// </summary>
        public virtual UbtConfig ForceDontBundleLibrariesInAPK(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-ForceDontBundleLibrariesInAPK",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// Adds LD_PRELOAD'ed .so to capture all malloc/free/etc calls to libc.so and route them to our memory tracing.
/// </summary>
        public virtual UbtConfig ScudoMemoryTracing(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-ScudoMemoryTracing",
                    Value: null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// If enabled will set the ProductVersion embeded in windows executables and dlls to contain BUILT_FROM_CHANGELIST and BuildVersion
/// Enabled by default for all precompiled and Shipping configurations. Regardless of this setting, the versions from Build.version will be available via the BuildSettings module
/// Note: Embedding these versions will cause resource files to be recompiled whenever changelist is updated which will cause binaries to relink
/// </summary>
        public virtual UbtConfig SetResourceVersions(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-SetResourceVersions",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// If enabled will set the ProductVersion embeded in windows executables and dlls to contain BUILT_FROM_CHANGELIST and BuildVersion
/// Enabled by default for all precompiled and Shipping configurations. Regardless of this setting, the versions from Build.version will be available via the BuildSettings module
/// Note: Embedding these versions will cause resource files to be recompiled whenever changelist is updated which will cause binaries to relink
/// </summary>
        public virtual UbtConfig NoSetResourceVersions(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-NoSetResourceVersions",
                    Value: null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// Warning level when reporting toolchains that are not in the preferred version list
/// </summary>
/// <seealso cref="MicrosoftPlatformSDK.PreferredVisualCppVersions" />
        public virtual UbtConfig ToolchainVersionWarningLevel(WarningLevel? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-ToolchainVersionWarningLevel",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// If specified along with -PGOProfile, use sample-based PGO instead of instrumented. Currently Intel oneAPI 2024.0+ only.
/// </summary>
        public virtual UbtConfig SampleBasedPGO(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-SampleBasedPGO",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// True if /d2ExtendedWarningInfo should be passed to the compiler and /d2:-ExtendedWarningInfo to the linker
/// </summary>
        public virtual UbtConfig VCExtendedWarningInfo(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-VCExtendedWarningInfo",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// True if /d2ExtendedWarningInfo should be passed to the compiler and /d2:-ExtendedWarningInfo to the linker
/// </summary>
        public virtual UbtConfig VCDisableExtendedWarningInfo(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-VCDisableExtendedWarningInfo",
                    Value: null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// True if optimizations to reduce the size of debug information should be disabled
/// See https://clang.llvm.org/docs/UsersManual.html#cmdoption-fstandalone-debug for more information
/// </summary>
        public virtual UbtConfig ClangStandaloneDebug(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-ClangStandaloneDebug",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// Whether to have the linker or library tool to generate a link repro in the specified directory
/// See https://learn.microsoft.com/en-us/cpp/build/reference/linkrepro for more information
/// </summary>
        public virtual UbtConfig LinkRepro(object val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-LinkRepro",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// Whether to request the linker create a stripped pdb file as part of the build.
/// If enabled the full debug pdb will have the extension .full.pdb
/// </summary>
        public virtual UbtConfig StripPrivateSymbols(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-StripPrivateSymbols",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// Whether this build will use Microsoft's custom XCurl instead of libcurl
/// Note that XCurl is not part of the normal Windows SDK and will require additional downloads
/// </summary>
        public virtual UbtConfig UseXCurl(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-UseXCurl",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>Additional command line providers to load opt-in telemetry connection information from ini.
/// List of ini providers for telemetry</summary>
        public virtual UbtConfig TelemetryProvider(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-TelemetryProvider",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: true
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// Session identifier for this run of UBT, if unset defaults to a random Guid
/// </summary>
        public virtual UbtConfig Session(object val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Session",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// Whether to enable emitting AutoRTFM verification metadata
/// </summary>
        public virtual UbtConfig UseAutoRTFMVerifier(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-UseAutoRTFMVerifier",
                    Value: null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// Whether to use I/O store on-demand
/// </summary>
        public virtual UbtConfig CompileIoStoreOnDemand(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-CompileIoStoreOnDemand",
                    Value: null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>Indicates what warning/error level to treat undefined identifiers in conditional expressions.
/// Indicates what warning/error level to treat undefined identifiers in conditional expressions.
/// MSVC -
/// https://learn.microsoft.com/en-us/cpp/error-messages/compiler-warnings/compiler-warning-level-4-c4668
/// 4668 - 'symbol' is not defined as a preprocessor macro, replacing with '0' for 'directives'
/// 44668 - Note: The extra 4 is not a typo, /wLXXXX sets warning XXXX to level L
/// Clang -
/// https://clang.llvm.org/docs/DiagnosticsReference.html#wundef</summary>
        public virtual UbtConfig UndefinedIdentifierWarningLevel(WarningLevel? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-UndefinedIdentifierWarningLevel",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>Experimental: Store object (.obj) compressed on disk. Requires UBA to link, currently MSVC only. Toggling this flag will invalidate MSVC actions.
/// Warning, this option is not currently compatitable with PGO or the the cl-clang linker as those are not detoured and linking will fail.
/// Store object (.obj) compressed on disk. Requires uba to do link step where it will decompress obj files again</summary>
        public virtual UbtConfig UBAStoreObjFilesCompressed(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-UBAStoreObjFilesCompressed",
                    Value: null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// Experimental: Strip unused exports from libraries. Only applies when LinkType is Modular
/// </summary>
        public virtual UbtConfig StripExports(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-StripExports",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// Experimental: Merge modular modules into combined libraries. Sets LinkType to Modular and enables bStripExports
/// </summary>
        public virtual UbtConfig MergeModules(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-MergeModules",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// Experimental: List of plugins (and their dependencies) to each merge into separate libraries. Requires bMergeModules to be enabled
/// </summary>
        public virtual UbtConfig MergePlugins(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-MergePlugins",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: true
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// Number of second of no completed actions to trigger to terminate the queue.
/// If zero, force termination not be enabled.
/// </summary>
        public virtual UbtConfig ActionStallTerminateTime(double? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-ActionStallTerminateTime",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// When set to true, actions that fail remotely with UBA will be retried locally with UBA.
/// </summary>
        public virtual UbtConfig UBAForcedRetryRemote(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-UBAForcedRetryRemote",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// Address of the uba cache service. Will automatically use cache if connected
/// </summary>
        public virtual UbtConfig UBACache(object val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-UBACache",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>Set cache to write instead of fetch
/// Set cache to write, expects one of [True, False, BuildMachineOnly]</summary>
        public virtual UbtConfig UBAWriteCache(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-UBAWriteCache",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// Max number of cache download tasks that can execute in parallel
/// </summary>
        public virtual UbtConfig UBACacheMaxWorkers(double? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-UBACacheMaxWorkers",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// Report reason a cache miss happened. Useful when searching for determinism/portability issues
/// </summary>
        public virtual UbtConfig UBAReportCacheMissReason(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-UBAReportCacheMissReason",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// Compute cluster ID to use in Horde. Set to "_auto" to let Horde server resolve a suitable cluster.
/// In multi-region setups this is can simplify configuration of UBT/UBA a lot.
/// </summary>
        public virtual UbtConfig UBAHordeCluster(object val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-UBAHordeCluster",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// Volatile Metadata is enabled by default and improves x64 emulation on arm64, but may come at a small perfomance cost (/volatileMetadata-).
/// </summary>
        public virtual UbtConfig DisableVolatileMetadata(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-DisableVolatileMetadata",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// If specified along with -PGOOptimize, will use the specified per-merged pgd file instead of the usual pgd file with loose pgc files.
/// </summary>
        public virtual UbtConfig PGOMergedPGD(object val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-PGOMergedPGD",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// True if we should use the Clang linker (LLD) when we are compiling with Clang or Intel oneAPI, otherwise we use the MSVC linker.
/// </summary>
        public virtual UbtConfig NoClangLinker(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-NoClangLinker",
                    Value: null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// Enables enforcing standard C++ ODR violations (/Zc:checkGwOdr) in VS2022 17.5 Preview 2.0+
/// </summary>
        public virtual UbtConfig StrictODR(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-StrictODR",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// If you supply -NoDebugInfo, windows platforms still create debug info while linking. Set this to true to not create debug info while linking in this circumstance
/// </summary>
        public virtual UbtConfig NoLinkerDebugInfo(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-NoLinkerDebugInfo",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>Outputs all the available configurations, platforms and targets to a file provided by the user.</summary>
        public virtual UbtConfig Query(object val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Query",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
    
        public virtual UbtConfig TargetDescriptionFile(object val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-TargetDescriptionFile",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>Show version information and exit.</summary>
        public virtual UbtConfig WorkspaceGeneratorVersion(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-WorkspaceGeneratorVersion",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>Generate .vsconfig file with dependencies and exit</summary>
        public virtual UbtConfig GenerateVsConfigOnly(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-GenerateVsConfigOnly",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// Indicates what warning/error level to treat unhandled enumerators in switches on enumeration-typed values.
/// MSVC -
/// 4061 - https://learn.microsoft.com/en-us/cpp/error-messages/compiler-warnings/compiler-warning-level-4-c4061
/// 44061 - Note: The extra 4 is not a typo, /wLXXXX sets warning XXXX to level L
/// Clang -
/// https://clang.llvm.org/docs/DiagnosticsReference.html#wswitch-enum
/// </summary>
        public virtual UbtConfig SwitchUnhandledEnumeratorWarningLevel(WarningLevel? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-SwitchUnhandledEnumeratorWarningLevel",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// How to treat module unsupported validation messages
/// </summary>
        public virtual UbtConfig ModuleUnsupportedWarningLevel(WarningLevel? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-ModuleUnsupportedWarningLevel",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// How to treat plugin specific module unsupported validation messages
/// </summary>
        public virtual UbtConfig PluginModuleUnsupportedWarningLevel(WarningLevel? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-PluginModuleUnsupportedWarningLevel",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// Whether to run LLVM verification after the AutoRTFM compiler pass.
/// This is used by our compiler folks to ensure the pass works with
/// the various code-paths UBT can take us down.
/// </summary>
        public virtual UbtConfig AutoRTFMVerify(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-AutoRTFMVerify",
                    Value: null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// Whether to link closed function declarations statically.
/// </summary>
        public virtual UbtConfig AutoRTFMClosedStaticLinkage(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-AutoRTFMClosedStaticLinkage",
                    Value: null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// Experimental work in progress: Set flags to use toolchain virtual file system support, to generate consistent pathing in outputs
/// </summary>
        public virtual UbtConfig VFS(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-VFS",
                    Value: null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// Experimental work in progress: Set flags to use toolchain virtual file system support, to generate consistent pathing in outputs
/// </summary>
        public virtual UbtConfig NoVFS(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-NoVFS",
                    Value: null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// Select a minimum ARM64 target CPU. This will change what ARMv8(9)-A ISA + extension code will be compiled for.
/// Changing it from default will guarantee not to work on all ARM64 CPUs.
/// Currently supported by clang compiler only
/// </summary>
        public virtual UbtConfig MinArm64CpuTarget(Arm64TargetCpuType? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-MinArm64CpuTarget",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// Experimental: List of plugins (and their dependencies) to ignore when processing merged libraries. Requires bMergeModules to be enabled
/// Ignored plugins will still be compiled, but if they're kept in the base executable, their dependencies will not be forced out of merged library with them.
/// This should be used carefully, for organisational plugins known to have dependencies they don't actually need at runtime.
/// </summary>
        public virtual UbtConfig MergePluginsIgnored(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-MergePluginsIgnored",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: true
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// List of provider names for remote connections from ini
/// It is recommended to set Providers in ini so the setting can be shared with the uba controller in editor, such as
/// Windows:	%ProgramData%/Epic/Unreal Engine/Engine/Config/SystemEngine.ini
/// Mac:		~/Library/Application Support/Epic/Unreal Engine/Engine/Config/SystemEngine.ini
/// Linux:		~/.config/Epic/Unreal Engine/Engine/Config/SystemEngine.ini
/// </summary>
        public virtual UbtConfig UBAProviders(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-UBAProviders",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: true
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// List of provider names for remote cache from ini
/// </summary>
        public virtual UbtConfig UBACacheProviders(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-UBACacheProviders",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: true
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// When set to true, actions that fail locally with certain error codes will retry without uba.
/// </summary>
        public virtual UbtConfig UBANoRetry(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-UBANoRetry",
                    Value: null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// Store object (.obj) compressed on disk. Requires uba to do link step where it will decompress obj files again
/// </summary>
        public virtual UbtConfig UBADisableStoreObjFilesCompressed(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-UBADisableStoreObjFilesCompressed",
                    Value: null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// Disable all detouring making all actions run outside uba
/// </summary>
        public virtual UbtConfig UBANoDetour(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-UBANoDetour",
                    Value: null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// Shuffle the list of cache servers before each read attempt
/// </summary>
        public virtual UbtConfig UBAShuffleCache(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-UBAShuffleCache",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// Compression level. Options are None, SuperFast, VeryFast, Fast, Normal, Optimal1 to Optimal5
/// </summary>
        public virtual UbtConfig UBACompressionLevel(object val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-UBACompressionLevel",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// If specificed Visual Studio Dynamic Debugging support will be enabled, unless the compiler or linker is not MSVC or LTCG is enabled
/// </summary>
        public virtual UbtConfig DynamicDebugging(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-DynamicDebugging",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// True if we should use the Rad linker
/// </summary>
        public virtual UbtConfig RadLinker(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-RadLinker",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary>
/// Enables instrumentation.
/// </summary>
        public virtual UbtConfig EnableInstrumentation(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-EnableInstrumentation",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

    
/// <summary></summary>
    public  class UnrealBuildToolConfig : ToolConfig
    {
        public override string Name => "UnrealBuildTool";
        public override string CliName => "";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest;
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    }

    protected readonly UnrealBuildToolConfig UnrealBuildToolStorage = new();
    
/// <summary>
/// Global options for UBT (any modes)
/// </summary>
    public  class GlobalOptionsConfig : ToolConfig
    {
        public override string Name => "GlobalOptions";
        public override string CliName => "";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest;
    
/// <summary>The amount of detail to write to the log
/// Increase output verbosity</summary>
        public virtual GlobalOptionsConfig Verbose(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Verbose",
                    Value: null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (GlobalOptionsConfig) this;
        }

    
/// <summary>The amount of detail to write to the log
/// Increase output verbosity more</summary>
        public virtual GlobalOptionsConfig VeryVerbose(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-VeryVerbose",
                    Value: null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (GlobalOptionsConfig) this;
        }

    
/// <summary>Specifies the path to a log file to write. Note that the default mode (eg. building, generating project files) will create a log file by default if this not specified.
/// Specify a log file location instead of the default Engine/Programs/UnrealBuildTool/Log.txt
/// Specify a log file location instead of the default Engine/Programs/UnrealHeaderTool/Saved/Logs/UnrealHeaderTool.log</summary>
        public virtual GlobalOptionsConfig Log(object val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Log",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (GlobalOptionsConfig) this;
        }

    
/// <summary>Whether to include timestamps in the log
/// Include timestamps in the log</summary>
        public virtual GlobalOptionsConfig Timestamps(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Timestamps",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (GlobalOptionsConfig) this;
        }

    
/// <summary>Whether to format messages in MsBuild format
/// Format messages for msbuild
/// Whether UBT is invoked from MSBuild.
/// If false will, disable bDontBundleLibrariesInAPK, unless forced .</summary>
        public virtual GlobalOptionsConfig FromMsBuild(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-FromMsBuild",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (GlobalOptionsConfig) this;
        }

    
/// <summary>Whether to write progress markup in a format that can be parsed by other programs
/// Write progress messages in a format that can be parsed by other programs</summary>
        public virtual GlobalOptionsConfig Progress(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Progress",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (GlobalOptionsConfig) this;
        }

    
/// <summary>Whether to ignore the mutex
/// Allow more than one instance of the program to run at once</summary>
        public virtual GlobalOptionsConfig NoMutex(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-NoMutex",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (GlobalOptionsConfig) this;
        }

    
/// <summary>Whether to wait for the mutex rather than aborting immediately
/// Wait for another instance to finish and then start, rather than aborting immediately</summary>
        public virtual GlobalOptionsConfig WaitMutex(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-WaitMutex",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (GlobalOptionsConfig) this;
        }

    
/// <summary>Whether to wait for the mutex rather than aborting immediately
/// Remote tool ini directory</summary>
        public virtual GlobalOptionsConfig RemoteIni(object val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-RemoteIni",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (GlobalOptionsConfig) this;
        }

    
/// <summary>
/// The mode to execute
/// </summary>
        public virtual GlobalOptionsConfig Mode(object val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Mode",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (GlobalOptionsConfig) this;
        }

    
/// <summary>The mode to execute
/// Clean build products. Equivalent to -Mode=Clean</summary>
        public virtual GlobalOptionsConfig Clean(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Clean",
                    Value: null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (GlobalOptionsConfig) this;
        }

    
/// <summary>The mode to execute
/// Generate project files based on IDE preference. Equivalent to -Mode=GenerateProjectFiles</summary>
        public virtual GlobalOptionsConfig ProjectFiles(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-ProjectFiles",
                    Value: null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (GlobalOptionsConfig) this;
        }

    
/// <summary>The mode to execute
/// Generate project files in specified format. May be used multiple times.</summary>
        public virtual GlobalOptionsConfig ProjectFileFormat(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-ProjectFileFormat",
                    Value: null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (GlobalOptionsConfig) this;
        }

    
/// <summary>The mode to execute
/// Generate Linux Makefile
/// Generate Makefile</summary>
        public virtual GlobalOptionsConfig Makefile(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Makefile",
                    Value: null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (GlobalOptionsConfig) this;
        }

    
/// <summary>The mode to execute
/// Generate project files for CMake</summary>
        public virtual GlobalOptionsConfig CMakefile(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-CMakefile",
                    Value: null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (GlobalOptionsConfig) this;
        }

    
/// <summary>The mode to execute
/// Generate project files for QMake</summary>
        public virtual GlobalOptionsConfig QMakefile(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-QMakefile",
                    Value: null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (GlobalOptionsConfig) this;
        }

    
/// <summary>The mode to execute
/// Generate project files for KDevelop</summary>
        public virtual GlobalOptionsConfig KDevelopfile(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-KDevelopfile",
                    Value: null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (GlobalOptionsConfig) this;
        }

    
/// <summary>The mode to execute
/// Generate project files for Codelite</summary>
        public virtual GlobalOptionsConfig CodeliteFiles(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-CodeliteFiles",
                    Value: null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (GlobalOptionsConfig) this;
        }

    
/// <summary>The mode to execute
/// Generate project files for XCode</summary>
        public virtual GlobalOptionsConfig XCodeProjectFiles(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-XCodeProjectFiles",
                    Value: null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (GlobalOptionsConfig) this;
        }

    
/// <summary>
/// The mode to execute
/// </summary>
        public virtual GlobalOptionsConfig EdditProjectFiles(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-EdditProjectFiles",
                    Value: null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4,
                        AllowMultiple: false
                    )
                ));
            }
            return (GlobalOptionsConfig) this;
        }

    
/// <summary>The mode to execute
/// Generate project files for Visual Studio Code</summary>
        public virtual GlobalOptionsConfig VSCode(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-VSCode",
                    Value: null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (GlobalOptionsConfig) this;
        }

    
/// <summary>The mode to execute
/// Generate project files for Visual Studio Mac</summary>
        public virtual GlobalOptionsConfig VSMac(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-VSMac",
                    Value: null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (GlobalOptionsConfig) this;
        }

    
/// <summary>The mode to execute
/// Generate project files for CLion</summary>
        public virtual GlobalOptionsConfig CLion(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-CLion",
                    Value: null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (GlobalOptionsConfig) this;
        }

    
/// <summary>The mode to execute
/// Generate project files for Rider</summary>
        public virtual GlobalOptionsConfig Rider(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Rider",
                    Value: null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (GlobalOptionsConfig) this;
        }

    
/// <summary>Log all attempts to write to the specified file
/// Trace writes requested to the specified file</summary>
        public virtual GlobalOptionsConfig TraceWrites(object val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-TraceWrites",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (GlobalOptionsConfig) this;
        }

    
/// <summary>The mode to execute
/// Generate project files for Eddie</summary>
        public virtual GlobalOptionsConfig EddieProjectFiles(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-EddieProjectFiles",
                    Value: null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (GlobalOptionsConfig) this;
        }

    
/// <summary>Whether or not to suppress warnings of missing SDKs from warnings to LogEventType.Log in UEBuildPlatformSDK.cs
/// Missing SDKs error verbosity level will be reduced from warning to log</summary>
        public virtual GlobalOptionsConfig SuppressSDKWarnings(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-SuppressSDKWarnings",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (GlobalOptionsConfig) this;
        }

    
/// <summary>Additional command line providers to load opt-in telemetry connection information from ini.
/// List of ini providers for telemetry</summary>
        public virtual GlobalOptionsConfig TelemetryProvider(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-TelemetryProvider",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: true
                    )
                ));
            }
            return (GlobalOptionsConfig) this;
        }

    
/// <summary>
/// Session identifier for this run of UBT, if unset defaults to a random Guid
/// </summary>
        public virtual GlobalOptionsConfig Session(object val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Session",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (GlobalOptionsConfig) this;
        }
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    }

    protected readonly GlobalOptionsConfig GlobalOptionsStorage = new();
    
/// <summary>
/// Global settings for building. Should not contain any target-specific settings.
/// </summary>
    public  class BuildConfigurationConfig : ToolConfig
    {
        public override string Name => "BuildConfiguration";
        public override string CliName => "";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest;
    
/// <summary>
/// Use existing static libraries for all engine modules in this target.
/// </summary>
        public virtual BuildConfigurationConfig UsePrecompiled(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-UsePrecompiled",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (BuildConfigurationConfig) this;
        }

    
/// <summary>Whether XGE may be used.
/// Whether XGE may be used if available, default is true.</summary>
        public virtual BuildConfigurationConfig NoXGE(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-NoXGE",
                    Value: null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (BuildConfigurationConfig) this;
        }

    
/// <summary>Whether FASTBuild may be used.
/// Whether FASTBuild may be used if available, default is true.</summary>
        public virtual BuildConfigurationConfig NoFASTBuild(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-NoFASTBuild",
                    Value: null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (BuildConfigurationConfig) this;
        }

    
/// <summary>
/// Enables support for very fast iterative builds by caching target data. Turning this on causes Unreal Build Tool to emit
/// 'UBT Makefiles' for targets when they are built the first time. Subsequent builds will load these Makefiles and begin
/// outdatedness checking and build invocation very quickly. The caveat is that if source files are added or removed to
/// the project, UBT will need to gather information about those in order for your build to complete successfully. Currently,
/// you must run the project file generator after adding/removing source files to tell UBT to re-gather this information.
/// 
/// Events that can invalidate the 'UBT Makefile':
/// - Adding/removing .cpp files
/// - Adding/removing .h files with UObjects
/// - Adding new UObject types to a file that did not previously have any
/// - Changing global build settings (most settings in this file qualify)
/// - Changed code that affects how Unreal Header Tool works
/// 
/// You can force regeneration of the 'UBT Makefile' by passing the '-gather' argument, or simply regenerating project files.
/// 
/// This also enables the fast include file dependency scanning and caching system that allows Unreal Build Tool to detect out
/// of date dependencies very quickly. When enabled, a deep C++ include graph does not have to be generated, and instead,
/// we only scan and cache indirect includes for after a dependent build product was already found to be out of date. During the
/// next build, we will load those cached indirect includes and check for outdatedness.
/// </summary>
        public virtual BuildConfigurationConfig NoUBTMakefiles(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-NoUBTMakefiles",
                    Value: null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (BuildConfigurationConfig) this;
        }

    
/// <summary>Number of actions that can be executed in parallel. If 0 then code will pick a default based
/// on the number of cores available. Only applies to the ParallelExecutor
/// Number of actions that can be executed in parallel. If 0 then code will pick a default based
/// on the number of cores and memory available. Applies to the ParallelExecutor, HybridExecutor, and LocalExecutor</summary>
        public virtual BuildConfigurationConfig MaxParallelActions(double? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-MaxParallelActions",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (BuildConfigurationConfig) this;
        }

    
/// <summary>
/// If true, force header regeneration. Intended for the build machine.
/// </summary>
        public virtual BuildConfigurationConfig ForceHeaderGeneration(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-ForceHeaderGeneration",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (BuildConfigurationConfig) this;
        }

    
/// <summary>
/// If true, do not build UHT, assume it is already built.
/// </summary>
        public virtual BuildConfigurationConfig NoBuildUHT(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-NoBuildUHT",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1,
                        AllowMultiple: false
                    )
                ));
            }
            return (BuildConfigurationConfig) this;
        }

    
/// <summary>If true, fail if any of the generated header files is out of date.
/// Consider any changes to output files as being an error</summary>
        public virtual BuildConfigurationConfig FailIfGeneratedCodeChanges(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-FailIfGeneratedCodeChanges",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (BuildConfigurationConfig) this;
        }

    
/// <summary>
/// True if hot-reload from IDE is allowed.
/// </summary>
        public virtual BuildConfigurationConfig NoHotReloadFromIDE(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-NoHotReloadFromIDE",
                    Value: null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (BuildConfigurationConfig) this;
        }

    
/// <summary>
/// Whether to skip compiling rules assemblies and just assume they are valid
/// </summary>
        public virtual BuildConfigurationConfig SkipRulesCompile(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-SkipRulesCompile",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (BuildConfigurationConfig) this;
        }

    
/// <summary>
/// Whether debug info should be written to the console.
/// </summary>
        public virtual BuildConfigurationConfig PrintDebugInfo(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-PrintDebugInfo",
                    Value: null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (BuildConfigurationConfig) this;
        }

    
/// <summary>Whether SN-DBS may be used.
/// Whether SN-DBS may be used if available, default is true.</summary>
        public virtual BuildConfigurationConfig NoSNDBS(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-NoSNDBS",
                    Value: null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (BuildConfigurationConfig) this;
        }

    
/// <summary>
/// Whether to force compiling rules assemblies, regardless of whether they are valid
/// </summary>
        public virtual BuildConfigurationConfig ForceRulesCompile(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-ForceRulesCompile",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (BuildConfigurationConfig) this;
        }

    
/// <summary>
/// Whether Horde remote compute may be used. Highly experimental, disabled by default.
/// </summary>
        public virtual BuildConfigurationConfig HordeCompute(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-HordeCompute",
                    Value: null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2,
                        AllowMultiple: false
                    )
                ));
            }
            return (BuildConfigurationConfig) this;
        }

    
/// <summary>
/// Consider logical cores when determining how many total cpu cores are available.
/// </summary>
        public virtual BuildConfigurationConfig AllCores(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-AllCores",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (BuildConfigurationConfig) this;
        }

    
/// <summary>
/// When single file targets are specified, via -File=, -SingleFile=, or -FileList=
/// If this option is set, no error will be produced if the source file is not included in the target.
/// Additionally, if any file or file list is specified, the target will not be built if none of the specified files are part of that target,
/// including the case where a file specified via -FileList= is empty.
/// </summary>
        public virtual BuildConfigurationConfig IgnoreInvalidFiles(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-IgnoreInvalidFiles",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (BuildConfigurationConfig) this;
        }

    
/// <summary>
/// Instruct the executor to write compact output e.g. only errors, if supported by the executor.
/// This field is used to hold the value when specified from the command line or XML
/// </summary>
        public virtual BuildConfigurationConfig CompactOutput(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-CompactOutput",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (BuildConfigurationConfig) this;
        }

    
/// <summary>
/// If set, artifacts will be read
/// </summary>
        public virtual BuildConfigurationConfig ArtifactReads(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-ArtifactReads",
                    Value: null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (BuildConfigurationConfig) this;
        }

    
/// <summary>
/// If set, artifacts will be read
/// </summary>
        public virtual BuildConfigurationConfig NoArtifactReads(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-NoArtifactReads",
                    Value: null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (BuildConfigurationConfig) this;
        }

    
/// <summary>
/// If set, artifacts will be written
/// </summary>
        public virtual BuildConfigurationConfig ArtifactWrites(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-ArtifactWrites",
                    Value: null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (BuildConfigurationConfig) this;
        }

    
/// <summary>
/// If set, artifacts will be written
/// </summary>
        public virtual BuildConfigurationConfig NoArtifactWrites(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-NoArtifactWrites",
                    Value: null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (BuildConfigurationConfig) this;
        }

    
/// <summary>
/// If true, log all artifact cache misses as informational messages
/// </summary>
        public virtual BuildConfigurationConfig LogArtifactCacheMisses(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-LogArtifactCacheMisses",
                    Value: null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (BuildConfigurationConfig) this;
        }

    
/// <summary>
/// Location to store the artifacts.
/// </summary>
        public virtual BuildConfigurationConfig ArtifactDirectory(object val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-ArtifactDirectory",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (BuildConfigurationConfig) this;
        }

    
/// <summary>
/// Whether the UnrealBuildAccelerator executor will be used.
/// </summary>
        public virtual BuildConfigurationConfig UBA(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-UBA",
                    Value: null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (BuildConfigurationConfig) this;
        }

    
/// <summary>
/// Whether the UnrealBuildAccelerator executor will be used.
/// </summary>
        public virtual BuildConfigurationConfig NoUBA(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-NoUBA",
                    Value: null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (BuildConfigurationConfig) this;
        }

    
/// <summary>
/// Whether the UnrealBuildAccelerator (local only) executor will be used.
/// </summary>
        public virtual BuildConfigurationConfig UBALocal(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-UBALocal",
                    Value: null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5,
                        AllowMultiple: false
                    )
                ));
            }
            return (BuildConfigurationConfig) this;
        }

    
/// <summary>
/// Whether the UnrealBuildAccelerator (local only) executor will be used.
/// </summary>
        public virtual BuildConfigurationConfig NoUBALocal(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-NoUBALocal",
                    Value: null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5,
                        AllowMultiple: false
                    )
                ));
            }
            return (BuildConfigurationConfig) this;
        }
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    }

    protected readonly BuildConfigurationConfig BuildConfigurationStorage = new();
    
/// <summary>
/// Describes all of the information needed to initialize a UEBuildTarget object
/// </summary>
    public  class TargetDescriptorConfig : ToolConfig
    {
        public override string Name => "TargetDescriptor";
        public override string CliName => "";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest;
    
/// <summary>
/// Foreign plugin to compile against this target
/// </summary>
        public virtual TargetDescriptorConfig Plugin(object val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Plugin",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (TargetDescriptorConfig) this;
        }

    
/// <summary>
/// Set of module names to compile.
/// </summary>
        public virtual TargetDescriptorConfig Module(params object[] values)
        {
            if (true)
            {
                if (values != null)
                    foreach (var val in values)
                    {
                        AppendArgument(new UnrealToolArgument(
                            "-Module",
                            Value: val.ToString(),
                            Setter: '=',
                            Meta: new(
                                Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                                AllowMultiple: true
                            )
                        ));
                    }
            }
            return (TargetDescriptorConfig) this;
        }

    
/// <summary>
/// Individual file(s) to compile
/// </summary>
        public virtual TargetDescriptorConfig SingleFile(params object[] values)
        {
            if (true)
            {
                if (values != null)
                    foreach (var val in values)
                    {
                        AppendArgument(new UnrealToolArgument(
                            "-SingleFile",
                            Value: val.ToString(),
                            Setter: '=',
                            Meta: new(
                                Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                                AllowMultiple: true
                            )
                        ));
                    }
            }
            return (TargetDescriptorConfig) this;
        }

    
/// <summary>
/// Whether to perform hot reload for this target
/// </summary>
        public virtual TargetDescriptorConfig NoHotReload(HotReloadMode? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-NoHotReload",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (TargetDescriptorConfig) this;
        }

    
/// <summary>
/// Whether to perform hot reload for this target
/// </summary>
        public virtual TargetDescriptorConfig ForceHotReload(HotReloadMode? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-ForceHotReload",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (TargetDescriptorConfig) this;
        }

    
/// <summary>
/// Whether to perform hot reload for this target
/// </summary>
        public virtual TargetDescriptorConfig LiveCoding(HotReloadMode? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-LiveCoding",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (TargetDescriptorConfig) this;
        }

    
/// <summary>
/// Export the actions for the target to a file
/// </summary>
        public virtual TargetDescriptorConfig WriteActions(params object[] values)
        {
            if (true)
            {
                if (values != null)
                    foreach (var val in values)
                    {
                        AppendArgument(new UnrealToolArgument(
                            "-WriteActions",
                            Value: val.ToString(),
                            Setter: '=',
                            Meta: new(
                                Compatibility: UnrealCompatibility.UE_4,
                                AllowMultiple: true
                            )
                        ));
                    }
            }
            return (TargetDescriptorConfig) this;
        }

    
/// <summary>
/// Path to a file containing a list of modules that may be modified for live coding.
/// </summary>
        public virtual TargetDescriptorConfig LiveCodingModules(object val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-LiveCodingModules",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (TargetDescriptorConfig) this;
        }

    
/// <summary>
/// Path to the manifest for passing info about the output to live coding
/// </summary>
        public virtual TargetDescriptorConfig LiveCodingManifest(object val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-LiveCodingManifest",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (TargetDescriptorConfig) this;
        }

    
/// <summary>
/// Suppress messages about building this target
/// </summary>
        public virtual TargetDescriptorConfig Quiet(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Quiet",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (TargetDescriptorConfig) this;
        }

    
/// <summary>
/// Lists of files to compile
/// </summary>
        public virtual TargetDescriptorConfig FileList(params object[] values)
        {
            if (true)
            {
                if (values != null)
                    foreach (var val in values)
                    {
                        AppendArgument(new UnrealToolArgument(
                            "-FileList",
                            Value: val.ToString(),
                            Setter: '=',
                            Meta: new(
                                Compatibility: UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                                AllowMultiple: true
                            )
                        ));
                    }
            }
            return (TargetDescriptorConfig) this;
        }

    
/// <summary>
/// Individual file(s) to compile
/// </summary>
        public virtual TargetDescriptorConfig File(params object[] values)
        {
            if (true)
            {
                if (values != null)
                    foreach (var val in values)
                    {
                        AppendArgument(new UnrealToolArgument(
                            "-File",
                            Value: val.ToString(),
                            Setter: '=',
                            Meta: new(
                                Compatibility: UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                                AllowMultiple: true
                            )
                        ));
                    }
            }
            return (TargetDescriptorConfig) this;
        }

    
/// <summary>
/// If a non-zero value, a live coding request will be terminated if more than the given number of actions are required.
/// </summary>
        public virtual TargetDescriptorConfig LiveCodingLimit(double? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-LiveCodingLimit",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (TargetDescriptorConfig) this;
        }

    
/// <summary>
/// Clean the target before trying to build it
/// </summary>
        public virtual TargetDescriptorConfig Rebuild(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Rebuild",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (TargetDescriptorConfig) this;
        }

    
/// <summary>
/// Whether we should treat the ForeignPlugin argument as a local plugin for building purposes
/// </summary>
        public virtual TargetDescriptorConfig BuildPluginAsLocal(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-BuildPluginAsLocal",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (TargetDescriptorConfig) this;
        }

    
/// <summary>
/// Relative path to file(s) to compile
/// </summary>
        public virtual TargetDescriptorConfig Files(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Files",
                    Value: values != null && values.Length > 0 ? string.Join(";", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: true
                    )
                ));
            }
            return (TargetDescriptorConfig) this;
        }

    
/// <summary>
/// Working directory when compiling with RelativePathsToSpecificFilesToCompile
/// </summary>
        public virtual TargetDescriptorConfig WorkingDir(object val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-WorkingDir",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (TargetDescriptorConfig) this;
        }

    
/// <summary>
/// Will build all files that directly include any of the files provided in -SingleFile
/// </summary>
        public virtual TargetDescriptorConfig SingleFileBuildDependents(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-SingleFileBuildDependents",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (TargetDescriptorConfig) this;
        }

    
/// <summary>
/// Whether to unify C++ code into larger files for faster compilation.
/// </summary>
        public virtual TargetDescriptorConfig DisableUnity(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-DisableUnity",
                    Value: null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (TargetDescriptorConfig) this;
        }

    
/// <summary>
/// Whether to force C++ source files to be combined into larger files for faster compilation.
/// </summary>
        public virtual TargetDescriptorConfig ForceUnity(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-ForceUnity",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (TargetDescriptorConfig) this;
        }

    
/// <summary>
/// Enables "include what you use" mode.
/// </summary>
        public virtual TargetDescriptorConfig IWYU(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-IWYU",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (TargetDescriptorConfig) this;
        }

    
/// <summary>
/// When building a foreign plugin, whether to build plugins it depends on as well.
/// </summary>
        public virtual TargetDescriptorConfig BuildDependantPlugins(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-BuildDependantPlugins",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (TargetDescriptorConfig) this;
        }
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    }

    protected readonly TargetDescriptorConfig TargetDescriptorStorage = new();
    
/// <summary>
/// TargetRules is a data structure that contains the rules for defining a target (application/executable)
/// </summary>
    public  class TargetRulesConfig : ToolConfig
    {
        public override string Name => "TargetRules";
        public override string CliName => "";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest;
    
/// <summary>
/// Build all the modules that are valid for this target type. Used for CIS and making installed engine builds.
/// </summary>
        public virtual TargetRulesConfig AllModules(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-AllModules",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (TargetRulesConfig) this;
        }

    
/// <summary>
/// Additional plugins that are built for this target type but not enabled.
/// </summary>
        public virtual TargetRulesConfig BuildPlugin(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-BuildPlugin",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: true
                    )
                ));
            }
            return (TargetRulesConfig) this;
        }

    
/// <summary>
/// Additional plugins that should be included for this target.
/// </summary>
        public virtual TargetRulesConfig EnablePlugin(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-EnablePlugin",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: true
                    )
                ));
            }
            return (TargetRulesConfig) this;
        }

    
/// <summary>
/// List of plugins to be disabled for this target. Note that the project file may still reference them, so they should be marked
/// as optional to avoid failing to find them at runtime.
/// </summary>
        public virtual TargetRulesConfig DisablePlugin(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-DisablePlugin",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: true
                    )
                ));
            }
            return (TargetRulesConfig) this;
        }

    
/// <summary>
/// Whether this target should be compiled as a DLL.  Requires LinkType to be set to TargetLinkType.Monolithic.
/// </summary>
        public virtual TargetRulesConfig CompileAsDll(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-CompileAsDll",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (TargetRulesConfig) this;
        }

    
/// <summary>
/// Whether to compile the Chaos physics plugin.
/// </summary>
        public virtual TargetRulesConfig NoCompileChaos(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-NoCompileChaos",
                    Value: null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3,
                        AllowMultiple: false
                    )
                ));
            }
            return (TargetRulesConfig) this;
        }

    
/// <summary>
/// Whether to compile the Chaos physics plugin.
/// </summary>
        public virtual TargetRulesConfig CompileChaos(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-CompileChaos",
                    Value: null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3,
                        AllowMultiple: false
                    )
                ));
            }
            return (TargetRulesConfig) this;
        }

    
/// <summary>
/// Whether to use the Chaos physics interface. This overrides the physx flags to disable APEX and NvCloth
/// </summary>
        public virtual TargetRulesConfig NoUseChaos(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-NoUseChaos",
                    Value: null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3,
                        AllowMultiple: false
                    )
                ));
            }
            return (TargetRulesConfig) this;
        }

    
/// <summary>
/// Whether to use the Chaos physics interface. This overrides the physx flags to disable APEX and NvCloth
/// </summary>
        public virtual TargetRulesConfig UseChaos(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-UseChaos",
                    Value: null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3,
                        AllowMultiple: false
                    )
                ));
            }
            return (TargetRulesConfig) this;
        }

    
/// <summary>
/// Enable RTTI for all modules.
/// </summary>
        public virtual TargetRulesConfig Rtti(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-rtti",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (TargetRulesConfig) this;
        }

    
/// <summary>Enables "include what you use" by default for modules in this target. Changes the default PCH mode for any module in this project to PCHUsageMode.UseExplicitOrSharedPCHs.
/// Enables "include what you use" mode.</summary>
        public virtual TargetRulesConfig IWYU(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-IWYU",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (TargetRulesConfig) this;
        }

    
/// <summary>
/// Make static libraries for all engine modules as intermediates for this target.
/// </summary>
        public virtual TargetRulesConfig Precompile(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Precompile",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (TargetRulesConfig) this;
        }

    
/// <summary>
/// Whether to unify C++ code into larger files for faster compilation.
/// </summary>
        public virtual TargetRulesConfig DisableUnity(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-DisableUnity",
                    Value: null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (TargetRulesConfig) this;
        }

    
/// <summary>
/// Whether to force C++ source files to be combined into larger files for faster compilation.
/// </summary>
        public virtual TargetRulesConfig ForceUnity(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-ForceUnity",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (TargetRulesConfig) this;
        }

    
/// <summary>Forces shadow variable warnings to be treated as errors on platforms that support it.
/// Forces shadow variable warnings to be treated as errors on platforms that support it.
/// MSVC -
/// https://learn.microsoft.com/en-us/cpp/error-messages/compiler-warnings/compiler-warning-level-4-c4456
/// 4456 - declaration of 'LocalVariable' hides previous local declaration
/// https://learn.microsoft.com/en-us/cpp/error-messages/compiler-warnings/compiler-warning-level-4-c4458
/// 4458 - declaration of 'parameter' hides class member
/// https://learn.microsoft.com/en-us/cpp/error-messages/compiler-warnings/compiler-warning-level-4-c4459
/// 4459 - declaration of 'LocalVariable' hides global declaration
/// Clang -
/// https://clang.llvm.org/docs/DiagnosticsReference.html#wshadow</summary>
        public virtual TargetRulesConfig ShadowVariableErrors(WarningLevel? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-ShadowVariableErrors",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (TargetRulesConfig) this;
        }

    
/// <summary>
/// New Monolithic Graphics drivers have optional "fast calls" replacing various D3d functions
/// </summary>
        public virtual TargetRulesConfig FastMonoCalls(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-FastMonoCalls",
                    Value: null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (TargetRulesConfig) this;
        }

    
/// <summary>
/// New Monolithic Graphics drivers have optional "fast calls" replacing various D3d functions
/// </summary>
        public virtual TargetRulesConfig NoFastMonoCalls(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-NoFastMonoCalls",
                    Value: null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (TargetRulesConfig) this;
        }

    
/// <summary>
/// Whether to stress test the C++ unity build robustness by including all C++ files files in a project from a single unified file.
/// </summary>
        public virtual TargetRulesConfig StressTestUnity(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-StressTestUnity",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (TargetRulesConfig) this;
        }

    
/// <summary>
/// Whether to force debug info to be generated.
/// </summary>
        public virtual TargetRulesConfig ForceDebugInfo(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-ForceDebugInfo",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (TargetRulesConfig) this;
        }

    
/// <summary>Whether to globally disable debug info generation; see DebugInfoHeuristics.cs for per-config and per-platform options.
/// How much debug info should be generated. See DebugInfoMode enum for more details</summary>
        public virtual TargetRulesConfig NoDebugInfo(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-NoDebugInfo",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (TargetRulesConfig) this;
        }

    
/// <summary>
/// Whether PDB files should be used for Visual C++ builds.
/// </summary>
        public virtual TargetRulesConfig NoPDB(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-NoPDB",
                    Value: null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (TargetRulesConfig) this;
        }

    
/// <summary>
/// Whether PCH files should be used.
/// </summary>
        public virtual TargetRulesConfig NoPCH(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-NoPCH",
                    Value: null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (TargetRulesConfig) this;
        }

    
/// <summary>
/// Whether to just preprocess source files for this target, and skip compilation
/// </summary>
        public virtual TargetRulesConfig Preprocess(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Preprocess",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (TargetRulesConfig) this;
        }

    
/// <summary>
/// Whether to use incremental linking or not. Incremental linking can yield faster iteration times when making small changes.
/// Currently disabled by default because it tends to behave a bit buggy on some computers (PDB-related compile errors).
/// </summary>
        public virtual TargetRulesConfig IncrementalLinking(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-IncrementalLinking",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (TargetRulesConfig) this;
        }

    
/// <summary>
/// Whether to use incremental linking or not. Incremental linking can yield faster iteration times when making small changes.
/// Currently disabled by default because it tends to behave a bit buggy on some computers (PDB-related compile errors).
/// </summary>
        public virtual TargetRulesConfig NoIncrementalLinking(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-NoIncrementalLinking",
                    Value: null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (TargetRulesConfig) this;
        }

    
/// <summary>
/// Whether to allow the use of link time code generation (LTCG).
/// </summary>
        public virtual TargetRulesConfig LTCG(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-LTCG",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (TargetRulesConfig) this;
        }

    
/// <summary>
/// Whether to enable Profile Guided Optimization (PGO) instrumentation in this build.
/// </summary>
        public virtual TargetRulesConfig PGOProfile(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-PGOProfile",
                    Value: null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (TargetRulesConfig) this;
        }

    
/// <summary>
/// Whether to optimize this build with Profile Guided Optimization (PGO).
/// </summary>
        public virtual TargetRulesConfig PGOOptimize(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-PGOOptimize",
                    Value: null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (TargetRulesConfig) this;
        }

    
/// <summary>
/// Enables "Shared PCHs", a feature which significantly speeds up compile times by attempting to
/// share certain PCH files between modules that UBT detects is including those PCH's header files.
/// </summary>
        public virtual TargetRulesConfig NoSharedPCH(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-NoSharedPCH",
                    Value: null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (TargetRulesConfig) this;
        }

    
/// <summary>
/// Whether to use the :FASTLINK option when building with /DEBUG to create local PDBs on Windows. Fast, but currently seems to have problems finding symbols in the debugger.
/// </summary>
        public virtual TargetRulesConfig FastPDB(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-FastPDB",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (TargetRulesConfig) this;
        }

    
/// <summary>
/// Outputs a map file as part of the build.
/// </summary>
        public virtual TargetRulesConfig MapFile(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-MapFile",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (TargetRulesConfig) this;
        }

    
/// <summary>
/// Bundle version for Mac apps.
/// </summary>
        public virtual TargetRulesConfig BundleVersion(object val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-BundleVersion",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (TargetRulesConfig) this;
        }

    
/// <summary>
/// Whether to deploy the executable after compilation on platforms that require deployment.
/// </summary>
        public virtual TargetRulesConfig Deploy(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Deploy",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (TargetRulesConfig) this;
        }

    
/// <summary>
/// Whether to force skipping deployment for platforms that require deployment by default.
/// </summary>
        public virtual TargetRulesConfig SkipDeploy(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-SkipDeploy",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (TargetRulesConfig) this;
        }

    
/// <summary>
/// Whether to disable linking for this target.
/// </summary>
        public virtual TargetRulesConfig NoLink(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-NoLink",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (TargetRulesConfig) this;
        }

    
/// <summary>Indicates that this is a formal build, intended for distribution. This flag is automatically set to true when Build.version has a changelist set.
/// The only behavior currently bound to this flag is to compile the default resource file separately for each binary so that the OriginalFilename field is set correctly.
/// By default, we only compile the resource once to reduce build times.
/// Indicates that this is a formal build, intended for distribution. This flag is automatically set to true when Build.version has a changelist set and is a promoted build.
/// The only behavior currently bound to this flag is to compile the default resource file separately for each binary so that the OriginalFilename field is set correctly.
/// By default, we only compile the resource once to reduce build times.</summary>
        public virtual TargetRulesConfig Formal(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Formal",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (TargetRulesConfig) this;
        }

    
/// <summary>
/// Whether to clean Builds directory on a remote Mac before building.
/// </summary>
        public virtual TargetRulesConfig FlushMac(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-FlushMac",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (TargetRulesConfig) this;
        }

    
/// <summary>
/// Whether to write detailed timing info from the compiler and linker.
/// </summary>
        public virtual TargetRulesConfig Timing(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Timing",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (TargetRulesConfig) this;
        }

    
/// <summary>
/// Whether to parse timing data into a tracing file compatible with chrome://tracing.
/// </summary>
        public virtual TargetRulesConfig Tracing(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Tracing",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (TargetRulesConfig) this;
        }

    
/// <summary>
/// Whether to expose all symbols as public by default on POSIX platforms
/// </summary>
        public virtual TargetRulesConfig PublicSymbolsByDefault(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-PublicSymbolsByDefault",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (TargetRulesConfig) this;
        }

    
/// <summary>
/// Allows overriding the toolchain to be created for this target. This must match the name of a class declared in the UnrealBuildTool assembly.
/// </summary>
        public virtual TargetRulesConfig ToolChain(object val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-ToolChain",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (TargetRulesConfig) this;
        }

    
/// <summary>Which C++ stanard to use for compiling this target
/// Which C++ standard to use for compiling this target (for non-engine modules)</summary>
        public virtual TargetRulesConfig CppStd(CppStandardVersion? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-CppStd",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (TargetRulesConfig) this;
        }

    
/// <summary>
/// Do not allow manifest changes when building this target. Used to cause earlier errors when building multiple targets with a shared build environment.
/// </summary>
        public virtual TargetRulesConfig NoManifestChanges(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-NoManifestChanges",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (TargetRulesConfig) this;
        }

    
/// <summary>
/// The build version string
/// </summary>
        public virtual TargetRulesConfig BuildVersion(object val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-BuildVersion",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (TargetRulesConfig) this;
        }

    
/// <summary>
/// Backing storage for the LinkType property.
/// </summary>
        public virtual TargetRulesConfig Monolithic(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Monolithic",
                    Value: null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (TargetRulesConfig) this;
        }

    
/// <summary>
/// Backing storage for the LinkType property.
/// </summary>
        public virtual TargetRulesConfig Modular(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Modular",
                    Value: null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (TargetRulesConfig) this;
        }

    
/// <summary>
/// Macros to define globally across the whole target.
/// </summary>
        public virtual TargetRulesConfig Define(params object[] values)
        {
            if (true)
            {
                if (values != null)
                    foreach (var val in values)
                    {
                        AppendArgument(new UnrealToolArgument(
                            "-Define",
                            Value: val.ToString(),
                            Setter: ':',
                            Meta: new(
                                Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                                AllowMultiple: true
                            )
                        ));
                    }
            }
            return (TargetRulesConfig) this;
        }

    
/// <summary>
/// Macros to define across all macros in the project.
/// </summary>
        public virtual TargetRulesConfig ProjectDefine(params object[] values)
        {
            if (true)
            {
                if (values != null)
                    foreach (var val in values)
                    {
                        AppendArgument(new UnrealToolArgument(
                            "-ProjectDefine",
                            Value: val.ToString(),
                            Setter: ':',
                            Meta: new(
                                Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                                AllowMultiple: true
                            )
                        ));
                    }
            }
            return (TargetRulesConfig) this;
        }

    
/// <summary>
/// Path to a manifest to output for this target
/// </summary>
        public virtual TargetRulesConfig Manifest(params object[] values)
        {
            if (true)
            {
                if (values != null)
                    foreach (var val in values)
                    {
                        AppendArgument(new UnrealToolArgument(
                            "-Manifest",
                            Value: val.ToString(),
                            Setter: '=',
                            Meta: new(
                                Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                                AllowMultiple: true
                            )
                        ));
                    }
            }
            return (TargetRulesConfig) this;
        }

    
/// <summary>
/// Path to a list of dependencies for this target, when precompiling
/// </summary>
        public virtual TargetRulesConfig DependencyList(params object[] values)
        {
            if (true)
            {
                if (values != null)
                    foreach (var val in values)
                    {
                        AppendArgument(new UnrealToolArgument(
                            "-DependencyList",
                            Value: val.ToString(),
                            Setter: '=',
                            Meta: new(
                                Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                                AllowMultiple: true
                            )
                        ));
                    }
            }
            return (TargetRulesConfig) this;
        }

    
/// <summary>
/// Backing storage for the BuildEnvironment property
/// </summary>
        public virtual TargetRulesConfig SharedBuildEnvironment(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-SharedBuildEnvironment",
                    Value: null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (TargetRulesConfig) this;
        }

    
/// <summary>
/// Backing storage for the BuildEnvironment property
/// </summary>
        public virtual TargetRulesConfig UniqueBuildEnvironment(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-UniqueBuildEnvironment",
                    Value: null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (TargetRulesConfig) this;
        }

    
/// <summary>
/// Whether to ignore violations to the shared build environment (eg. editor targets modifying definitions)
/// </summary>
        public virtual TargetRulesConfig OverrideBuildEnvironment(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-OverrideBuildEnvironment",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (TargetRulesConfig) this;
        }

    
/// <summary>
/// Additional arguments to pass to the compiler
/// </summary>
        public virtual TargetRulesConfig CompilerArguments(object val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-CompilerArguments",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (TargetRulesConfig) this;
        }

    
/// <summary>
/// Additional arguments to pass to the linker
/// </summary>
        public virtual TargetRulesConfig LinkerArguments(object val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-LinkerArguments",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (TargetRulesConfig) this;
        }

    
/// <summary>
/// Whether to use the verse script interface.
/// </summary>
        public virtual TargetRulesConfig NoUseVerse(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-NoUseVerse",
                    Value: null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3,
                        AllowMultiple: false
                    )
                ));
            }
            return (TargetRulesConfig) this;
        }

    
/// <summary>
/// Whether to use the verse script interface.
/// </summary>
        public virtual TargetRulesConfig UseVerse(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-UseVerse",
                    Value: null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3,
                        AllowMultiple: false
                    )
                ));
            }
            return (TargetRulesConfig) this;
        }

    
/// <summary>Use a heuristic to determine which files are currently being iterated on and exclude them from unity blobs, result in faster
/// incremental compile times. The current implementation uses the read-only flag to distinguish the working set, assuming that files will
/// be made writable by the source control system if they are being modified. This is true for Perforce, but not for Git.
/// Use a heuristic to determine which files are currently being iterated on and exclude them from unity blobs. This results in faster
/// incremental compile times. For Perforce repositories, the current implementation uses the read-only flag to distinguish the working
/// set, assuming that files will be made writable by the source control system if they are being modified. For Git repositories, the
/// implementation uses the git status command. Source code archives downloaded from Git as .zip files are not supported.</summary>
        public virtual TargetRulesConfig DisableAdaptiveUnity(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-DisableAdaptiveUnity",
                    Value: null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (TargetRulesConfig) this;
        }

    
/// <summary>Whether to enable all warnings as errors. UE enables most warnings as errors already, but disables a few (such as deprecation warnings).
/// Treat warnings as errors</summary>
        public virtual TargetRulesConfig WarningsAsErrors(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-WarningsAsErrors",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (TargetRulesConfig) this;
        }

    
/// <summary>
/// When Link Time Code Generation (LTCG) is enabled, whether to
/// prefer using the lighter weight version on supported platforms.
/// </summary>
        public virtual TargetRulesConfig ThinLTO(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-ThinLTO",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (TargetRulesConfig) this;
        }

    
/// <summary>
/// Override the name used for this target
/// </summary>
        public virtual TargetRulesConfig TargetNameOverride(object val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-TargetNameOverride",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (TargetRulesConfig) this;
        }

    
/// <summary>
/// Force the include order to a specific version. Overrides any Target and Module rules.
/// </summary>
        public virtual TargetRulesConfig ForceIncludeOrder(EngineIncludeOrderVersion? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-ForceIncludeOrder",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (TargetRulesConfig) this;
        }

    
/// <summary>
/// Whether to use Iris.
/// </summary>
        public virtual TargetRulesConfig NoUseIris(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-NoUseIris",
                    Value: null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (TargetRulesConfig) this;
        }

    
/// <summary>
/// Whether to use Iris.
/// </summary>
        public virtual TargetRulesConfig UseIris(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-UseIris",
                    Value: null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (TargetRulesConfig) this;
        }

    
    
        public virtual TargetRulesConfig TrustedServer(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-TrustedServer",
                    Value: null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_1,
                        AllowMultiple: false
                    )
                ));
            }
            return (TargetRulesConfig) this;
        }

    
    
        public virtual TargetRulesConfig NoTrustedServer(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-NoTrustedServer",
                    Value: null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_1,
                        AllowMultiple: false
                    )
                ));
            }
            return (TargetRulesConfig) this;
        }

    
/// <summary>
/// Whether to merge module and generated unity files for faster compilation.
/// </summary>
        public virtual TargetRulesConfig DisableMergingUnityFiles(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-DisableMergingUnityFiles",
                    Value: null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3,
                        AllowMultiple: false
                    )
                ));
            }
            return (TargetRulesConfig) this;
        }

    
/// <summary>
/// Forces frame pointers to be retained this is usually required when you want reliable callstacks e.g. mallocframeprofiler
/// </summary>
        public virtual TargetRulesConfig RetainFramePointers(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-RetainFramePointers",
                    Value: null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (TargetRulesConfig) this;
        }

    
/// <summary>
/// Forces frame pointers to be retained this is usually required when you want reliable callstacks e.g. mallocframeprofiler
/// </summary>
        public virtual TargetRulesConfig NoRetainFramePointers(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-NoRetainFramePointers",
                    Value: null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (TargetRulesConfig) this;
        }

    
/// <summary>
/// An approximate number of bytes of C++ code to target for inclusion in a single unified C++ file.
/// </summary>
        public virtual TargetRulesConfig BytesPerUnityCPP(double? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-BytesPerUnityCPP",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (TargetRulesConfig) this;
        }

    
/// <summary>Whether to add additional information to the unity files, such as '_of_X' in the file name.
/// Whether to add additional information to the unity files, such as '_of_X' in the file name. Not recommended.</summary>
        public virtual TargetRulesConfig DetailedUnityFiles(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-DetailedUnityFiles",
                    Value: null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5,
                        AllowMultiple: false
                    )
                ));
            }
            return (TargetRulesConfig) this;
        }

    
/// <summary>Whether to add additional information to the unity files, such as '_of_X' in the file name.
/// Whether to add additional information to the unity files, such as '_of_X' in the file name. Not recommended.</summary>
        public virtual TargetRulesConfig NoDetailedUnityFiles(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-NoDetailedUnityFiles",
                    Value: null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5,
                        AllowMultiple: false
                    )
                ));
            }
            return (TargetRulesConfig) this;
        }

    
/// <summary>Force set flags require for determinstic compiling and linking (experimental, may not be fully supported).
/// This setting is only recommended for testing, instead:
/// * Set bDeterministic on a per module basis in ModuleRules to control deterministic compiling.
/// * Set bDeterministic on a per target basis in TargetRules to control deterministic linking.
/// Set flags require for deterministic compiling and linking.
/// Enabling deterministic mode for msvc disables codegen multithreading so compiling will be slower</summary>
        public virtual TargetRulesConfig Deterministic(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Deterministic",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (TargetRulesConfig) this;
        }

    
/// <summary>
/// Generate dependency files by preprocessing. This is only recommended when distributing builds as it adds additional overhead.
/// </summary>
        public virtual TargetRulesConfig PreprocessDepends(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-PreprocessDepends",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (TargetRulesConfig) this;
        }

    
/// <summary>Whether static code analysis should be enabled.
/// The static analyzer to use.</summary>
        public virtual TargetRulesConfig StaticAnalyzer(StaticAnalyzer? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-StaticAnalyzer",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (TargetRulesConfig) this;
        }

    
/// <summary>
/// The output type to use for the static analyzer. This is only supported for Clang.
/// </summary>
        public virtual TargetRulesConfig StaticAnalyzerOutputType(StaticAnalyzerOutputType? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-StaticAnalyzerOutputType",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (TargetRulesConfig) this;
        }

    
/// <summary>
/// The mode to use for the static analyzer. This is only supported for Clang.
/// Shallow mode completes quicker but is generally not recommended.
/// </summary>
        public virtual TargetRulesConfig StaticAnalyzerMode(StaticAnalyzerMode? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-StaticAnalyzerMode",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (TargetRulesConfig) this;
        }

    
/// <summary>
/// Package full path (directory + filename) where to store input files used at link time
/// Normally used to debug a linker crash for platforms that support it
/// </summary>
        public virtual TargetRulesConfig PackagePath(object val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-PackagePath",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (TargetRulesConfig) this;
        }

    
/// <summary>
/// Directory where to put crash report files for platforms that support it
/// </summary>
        public virtual TargetRulesConfig CrashDiagnosticDirectory(object val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-CrashDiagnosticDirectory",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (TargetRulesConfig) this;
        }

    
/// <summary>
/// Disable supports for inlining gen.cpps
/// </summary>
        public virtual TargetRulesConfig DisableInliningGenCpps(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-DisableInliningGenCpps",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3,
                        AllowMultiple: false
                    )
                ));
            }
            return (TargetRulesConfig) this;
        }

    
/// <summary>
/// Which C standard to use for compiling this target
/// </summary>
        public virtual TargetRulesConfig CStd(CStandardVersion? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-CStd",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (TargetRulesConfig) this;
        }

    
/// <summary>
/// Enable Position Independent Executable (PIE). Has an overhead cost
/// </summary>
        public virtual TargetRulesConfig Pie(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-pie",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (TargetRulesConfig) this;
        }

    
/// <summary>
/// Enable Stack Protection. Has an overhead cost
/// </summary>
        public virtual TargetRulesConfig StackProtect(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-stack-protect",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (TargetRulesConfig) this;
        }

    
/// <summary>
/// Allows to fine tune optimizations level for speed and\or code size
/// </summary>
        public virtual TargetRulesConfig OptimizationLevel(OptimizationMode? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-OptimizationLevel",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (TargetRulesConfig) this;
        }

    
/// <summary>
/// Tells "include what you use" to only compile header files.
/// </summary>
        public virtual TargetRulesConfig IWYUHeadersOnly(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-IWYUHeadersOnly",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_2,
                        AllowMultiple: false
                    )
                ));
            }
            return (TargetRulesConfig) this;
        }

    
/// <summary>
/// Disables overrides that are set by the module
/// </summary>
        public virtual TargetRulesConfig DisableModuleNumIncludedBytesPerUnityCPPOverride(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-DisableModuleNumIncludedBytesPerUnityCPPOverride",
                    Value: null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (TargetRulesConfig) this;
        }

    
/// <summary>
/// Directory where to put the ThinLTO cache on supported platforms.
/// </summary>
        public virtual TargetRulesConfig ThinLTOCacheDirectory(object val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-ThinLTOCacheDirectory",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (TargetRulesConfig) this;
        }

    
/// <summary>
/// Arguments that will be applied to prune the ThinLTO cache on supported platforms.
/// Arguments will only be applied if ThinLTOCacheDirectory is set.
/// </summary>
        public virtual TargetRulesConfig ThinLTOCachePruningArguments(object val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-ThinLTOCachePruningArguments",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (TargetRulesConfig) this;
        }

    
/// <summary>
/// Adds header files in included modules to the build.
/// </summary>
        public virtual TargetRulesConfig IncludeHeaders(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-IncludeHeaders",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (TargetRulesConfig) this;
        }

    
/// <summary>
/// Set flags require for deterministic compiling and linking.
/// Enabling deterministic mode for msvc disables codegen multithreading so compiling will be slower
/// </summary>
        public virtual TargetRulesConfig NonDeterministic(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-NonDeterministic",
                    Value: null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (TargetRulesConfig) this;
        }

    
/// <summary>
/// Which C++ standard to use for compiling this target (for engine modules)
/// </summary>
        public virtual TargetRulesConfig CppStdEngine(CppStandardVersion? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-CppStdEngine",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (TargetRulesConfig) this;
        }

    
/// <summary>Whether to use the AutoRTFM Clang compiler.
/// Whether to use force AutoRTFM Clang compiler off.</summary>
        public virtual TargetRulesConfig NoUseAutoRTFM(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-NoUseAutoRTFM",
                    Value: null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (TargetRulesConfig) this;
        }

    
/// <summary>
/// Whether to use the AutoRTFM Clang compiler.
/// </summary>
        public virtual TargetRulesConfig UseAutoRTFM(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-UseAutoRTFM",
                    Value: null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4,
                        AllowMultiple: false
                    )
                ));
            }
            return (TargetRulesConfig) this;
        }

    
/// <summary>
/// Whether to compile in Chaos Visual Debugger (CVD) support features to record the state of the physics simulation
/// </summary>
        public virtual TargetRulesConfig CompileChaosVisualDebuggerSupport(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-CompileChaosVisualDebuggerSupport",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (TargetRulesConfig) this;
        }

    
/// <summary>
/// When used with -IncludeHeaders, only header files will be compiled.
/// </summary>
        public virtual TargetRulesConfig HeadersOnly(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-HeadersOnly",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (TargetRulesConfig) this;
        }

    
/// <summary>
/// Indicates what warning/error level to treat potential PCH performance issues.
/// </summary>
        public virtual TargetRulesConfig PCHPerformanceIssueWarningLevel(WarningLevel? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-PCHPerformanceIssueWarningLevel",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (TargetRulesConfig) this;
        }

    
/// <summary>
/// How to treat general module include path validation messages
/// </summary>
        public virtual TargetRulesConfig ModuleIncludePathWarningLevel(WarningLevel? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-ModuleIncludePathWarningLevel",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (TargetRulesConfig) this;
        }

    
/// <summary>
/// How to treat private module include path validation messages, where a module is adding an include path that exposes private headers
/// </summary>
        public virtual TargetRulesConfig ModuleIncludePrivateWarningLevel(WarningLevel? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-ModuleIncludePrivateWarningLevel",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (TargetRulesConfig) this;
        }

    
/// <summary>
/// How to treat unnecessary module sub-directory include path validation messages
/// </summary>
        public virtual TargetRulesConfig ModuleIncludeSubdirectoryWarningLevel(WarningLevel? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-ModuleIncludeSubdirectoryWarningLevel",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (TargetRulesConfig) this;
        }

    
/// <summary>
/// Whether PDB files should be used for Visual C++ builds.
/// </summary>
        public virtual TargetRulesConfig UsePDB(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-UsePDB",
                    Value: null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (TargetRulesConfig) this;
        }

    
/// <summary>
/// Whether PCHs should be chained when compiling with clang.
/// </summary>
        public virtual TargetRulesConfig NoPCHChain(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-NoPCHChain",
                    Value: null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (TargetRulesConfig) this;
        }

    
/// <summary>
/// Whether to generate assembly data while compiling this target. Works exclusively on MSVC for now.
/// </summary>
        public virtual TargetRulesConfig WithAssembly(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-WithAssembly",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (TargetRulesConfig) this;
        }

    
/// <summary>
/// Whether the target requires code coverage compilation and linking.
/// </summary>
        public virtual TargetRulesConfig CodeCoverage(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-CodeCoverage",
                    Value: null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (TargetRulesConfig) this;
        }

    
/// <summary>
/// Whether to support edit and continue.
/// </summary>
        public virtual TargetRulesConfig SupportEditAndContinue(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-SupportEditAndContinue",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (TargetRulesConfig) this;
        }

    
/// <summary>Direct the compiler to generate AVX instructions wherever SSE or AVX intrinsics are used, on the x64 platforms that support it.
/// Note that by enabling this you are changing the minspec for the PC platform, and the resultant executable will crash on machines without AVX support.
/// Direct the compiler to generate AVX instructions wherever SSE or AVX intrinsics are used, on the x64 platforms that support it. Ignored for arm64.
/// Note that by enabling this you are changing the minspec for the target platform, and the resultant executable will crash on machines without AVX support.</summary>
        public virtual TargetRulesConfig MinCpuArchX64(MinimumCpuArchitectureX64? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-MinCpuArchX64",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (TargetRulesConfig) this;
        }

    
/// <summary>
/// Extra subdirectory to load config files out of, for making multiple types of builds with the same platform
/// This will get baked into the game executable as CUSTOM_CONFIG and used when staging to filter files and settings
/// </summary>
        public virtual TargetRulesConfig CustomConfig(object val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-CustomConfig",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (TargetRulesConfig) this;
        }

    
/// <summary>
/// Whether to use the BPVM to run Verse.
/// </summary>
        public virtual TargetRulesConfig NoUseVerseBPVM(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-NoUseVerseBPVM",
                    Value: null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (TargetRulesConfig) this;
        }

    
/// <summary>
/// Whether to use the BPVM to run Verse.
/// </summary>
        public virtual TargetRulesConfig UseVerseBPVM(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-UseVerseBPVM",
                    Value: null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (TargetRulesConfig) this;
        }

    
/// <summary>
/// Allows setting the FP semantics.
/// </summary>
        public virtual TargetRulesConfig FPSemantics(FPSemanticsMode? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-FPSemantics",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (TargetRulesConfig) this;
        }

    
/// <summary>
/// How much debug info should be generated. See DebugInfoMode enum for more details
/// </summary>
        public virtual TargetRulesConfig DebugInfo(DebugInfoMode? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-DebugInfo",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (TargetRulesConfig) this;
        }

    
/// <summary>
/// Modules that should have debug info disabled
/// </summary>
        public virtual TargetRulesConfig DisableDebugInfoModules(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-DisableDebugInfoModules",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: true
                    )
                ));
            }
            return (TargetRulesConfig) this;
        }

    
/// <summary>
/// Plugins that should have debug info disabled
/// </summary>
        public virtual TargetRulesConfig DisableDebugInfoPlugins(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-DisableDebugInfoPlugins",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: true
                    )
                ));
            }
            return (TargetRulesConfig) this;
        }

    
/// <summary>
/// True if only debug line number tables should be emitted in debug information for compilers that support doing so. Overrides TargetRules.DebugInfo
/// See https://clang.llvm.org/docs/UsersManual.html#cmdoption-gline-tables-only for more information
/// </summary>
        public virtual TargetRulesConfig DebugInfoLineTablesOnly(DebugInfoMode? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-DebugInfoLineTablesOnly",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (TargetRulesConfig) this;
        }

    
/// <summary>
/// Modules that should emit line number tables instead of full debug information for compilers that support doing so. Overrides DisableDebugInfoModules
/// </summary>
        public virtual TargetRulesConfig DebugInfoLineTablesOnlyModules(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-DebugInfoLineTablesOnlyModules",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: true
                    )
                ));
            }
            return (TargetRulesConfig) this;
        }

    
/// <summary>
/// Plugins that should emit line number tables instead of full debug information for compilers that support doing so. Overrides DisableDebugInfoPlugins
/// </summary>
        public virtual TargetRulesConfig DebugInfoLineTablesOnlyPlugins(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-DebugInfoLineTablesOnlyPlugins",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: true
                    )
                ));
            }
            return (TargetRulesConfig) this;
        }

    
/// <summary>
/// The level of warnings to print when analyzing using PVS-Studio
/// </summary>
        public virtual TargetRulesConfig StaticAnalyzerPVSPrintLevel(double? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-StaticAnalyzerPVSPrintLevel",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (TargetRulesConfig) this;
        }

    
/// <summary>
/// Only run static analysis against project modules, skipping engine modules
/// </summary>
/// <remarks>PVS-Studio: warnings that are disabled via Engine/Source/Runtime/Core/Public/Microsoft/MicrosoftPlatformCodeAnalysis.h will be reenabled</remarks>
        public virtual TargetRulesConfig StaticAnalyzerProjectOnly(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-StaticAnalyzerProjectOnly",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (TargetRulesConfig) this;
        }

    
/// <summary>
/// When enabled, generated source files will be analyzed
/// </summary>
        public virtual TargetRulesConfig StaticAnalyzerIncludeGenerated(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-StaticAnalyzerIncludeGenerated",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (TargetRulesConfig) this;
        }

    
/// <summary>
/// Will replace pch with ifc and use header units instead. This is an experimental and msvc-only feature
/// </summary>
        public virtual TargetRulesConfig HeaderUnits(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-HeaderUnits",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (TargetRulesConfig) this;
        }

    
/// <summary>
/// A list of additional plugins which need to be included in this target. This allows referencing non-optional plugin modules
/// which cannot be disabled, and allows building against specific modules in program targets which do not fit the categories
/// in ModuleHostType.
/// </summary>
        public virtual TargetRulesConfig AdditionalPlugins(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-AdditionalPlugins",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: true
                    )
                ));
            }
            return (TargetRulesConfig) this;
        }

    
/// <summary>
/// Additional plugins that should be included for this target if they are found.
/// </summary>
        public virtual TargetRulesConfig OptionalPlugins(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-OptionalPlugins",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: true
                    )
                ));
            }
            return (TargetRulesConfig) this;
        }

    
/// <summary>
/// Whether to enable emitting AutoRTFM verification metadata
/// </summary>
        public virtual TargetRulesConfig UseAutoRTFMVerifier(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-UseAutoRTFMVerifier",
                    Value: null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (TargetRulesConfig) this;
        }

    
/// <summary>
/// Whether to use I/O store on-demand
/// </summary>
        public virtual TargetRulesConfig CompileIoStoreOnDemand(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-CompileIoStoreOnDemand",
                    Value: null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (TargetRulesConfig) this;
        }

    
/// <summary>Indicates what warning/error level to treat undefined identifiers in conditional expressions.
/// Indicates what warning/error level to treat undefined identifiers in conditional expressions.
/// MSVC -
/// https://learn.microsoft.com/en-us/cpp/error-messages/compiler-warnings/compiler-warning-level-4-c4668
/// 4668 - 'symbol' is not defined as a preprocessor macro, replacing with '0' for 'directives'
/// 44668 - Note: The extra 4 is not a typo, /wLXXXX sets warning XXXX to level L
/// Clang -
/// https://clang.llvm.org/docs/DiagnosticsReference.html#wundef</summary>
        public virtual TargetRulesConfig UndefinedIdentifierWarningLevel(WarningLevel? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-UndefinedIdentifierWarningLevel",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (TargetRulesConfig) this;
        }

    
/// <summary>Experimental: Store object (.obj) compressed on disk. Requires UBA to link, currently MSVC only. Toggling this flag will invalidate MSVC actions.
/// Warning, this option is not currently compatitable with PGO or the the cl-clang linker as those are not detoured and linking will fail.
/// Store object (.obj) compressed on disk. Requires uba to do link step where it will decompress obj files again</summary>
        public virtual TargetRulesConfig UBAStoreObjFilesCompressed(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-UBAStoreObjFilesCompressed",
                    Value: null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (TargetRulesConfig) this;
        }

    
/// <summary>
/// Experimental: Strip unused exports from libraries. Only applies when LinkType is Modular
/// </summary>
        public virtual TargetRulesConfig StripExports(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-StripExports",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (TargetRulesConfig) this;
        }

    
/// <summary>
/// Experimental: Merge modular modules into combined libraries. Sets LinkType to Modular and enables bStripExports
/// </summary>
        public virtual TargetRulesConfig MergeModules(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-MergeModules",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (TargetRulesConfig) this;
        }

    
/// <summary>
/// Experimental: List of plugins (and their dependencies) to each merge into separate libraries. Requires bMergeModules to be enabled
/// </summary>
        public virtual TargetRulesConfig MergePlugins(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-MergePlugins",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: true
                    )
                ));
            }
            return (TargetRulesConfig) this;
        }

    
/// <summary>
/// Print out files that are included by each source file
/// </summary>
        public virtual TargetRulesConfig ShowIncludes(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-ShowIncludes",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (TargetRulesConfig) this;
        }

    
/// <summary>
/// Whether to run LLVM verification after the AutoRTFM compiler pass.
/// This is used by our compiler folks to ensure the pass works with
/// the various code-paths UBT can take us down.
/// </summary>
        public virtual TargetRulesConfig AutoRTFMVerify(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-AutoRTFMVerify",
                    Value: null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (TargetRulesConfig) this;
        }

    
/// <summary>
/// Whether to link closed function declarations statically.
/// </summary>
        public virtual TargetRulesConfig AutoRTFMClosedStaticLinkage(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-AutoRTFMClosedStaticLinkage",
                    Value: null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (TargetRulesConfig) this;
        }

    
/// <summary>
/// Experimental work in progress: Set flags to use toolchain virtual file system support, to generate consistent pathing in outputs
/// </summary>
        public virtual TargetRulesConfig VFS(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-VFS",
                    Value: null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (TargetRulesConfig) this;
        }

    
/// <summary>
/// Experimental work in progress: Set flags to use toolchain virtual file system support, to generate consistent pathing in outputs
/// </summary>
        public virtual TargetRulesConfig NoVFS(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-NoVFS",
                    Value: null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (TargetRulesConfig) this;
        }

    
/// <summary>
/// Select a minimum ARM64 target CPU. This will change what ARMv8(9)-A ISA + extension code will be compiled for.
/// Changing it from default will guarantee not to work on all ARM64 CPUs.
/// Currently supported by clang compiler only
/// </summary>
        public virtual TargetRulesConfig MinArm64CpuTarget(Arm64TargetCpuType? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-MinArm64CpuTarget",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (TargetRulesConfig) this;
        }

    
/// <summary>
/// Experimental: List of plugins (and their dependencies) to ignore when processing merged libraries. Requires bMergeModules to be enabled
/// Ignored plugins will still be compiled, but if they're kept in the base executable, their dependencies will not be forced out of merged library with them.
/// This should be used carefully, for organisational plugins known to have dependencies they don't actually need at runtime.
/// </summary>
        public virtual TargetRulesConfig MergePluginsIgnored(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-MergePluginsIgnored",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: true
                    )
                ));
            }
            return (TargetRulesConfig) this;
        }
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    }

    protected readonly TargetRulesConfig TargetRulesStorage = new();
    
/// <summary>
/// Aggregates parsed Visual C++ timing information files together into one monolithic breakdown file.
/// </summary>
/// <summary>
/// Aggregates parsed Visual C++ timing information files together into one monolithic breakdown file.
/// </summary>
    public  class AggregateParsedTimingInfoConfig : ToolConfig
    {
        public override string Name => "AggregateParsedTimingInfo";
        public override string CliName => "-AggregateParsedTimingInfo";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest;
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    }

    protected readonly AggregateParsedTimingInfoConfig AggregateParsedTimingInfoStorage = new();
    
/// <summary>
/// Builds a target
/// </summary>
    public  class BuildConfig : ToolConfig
    {
        public override string Name => "Build";
        public override string CliName => "-Build";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest;
    
/// <summary>
/// Whether to skip checking for files identified by the junk manifest.
/// </summary>
        public virtual BuildConfig IgnoreJunk(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-IgnoreJunk",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (BuildConfig) this;
        }

    
/// <summary>
/// Skip building; just do setup and terminate.
/// </summary>
        public virtual BuildConfig SkipBuild(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-SkipBuild",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (BuildConfig) this;
        }

    
/// <summary>
/// Skip pre build targets; just do the main target.
/// </summary>
        public virtual BuildConfig SkipPreBuildTargets(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-SkipPreBuildTargets",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (BuildConfig) this;
        }

    
/// <summary>
/// Whether we should just export the XGE XML and pretend it succeeded
/// </summary>
        public virtual BuildConfig XGEExport(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-XGEExport",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (BuildConfig) this;
        }

    
/// <summary>
/// Do not allow any engine files to be output (used by compile on startup functionality)
/// </summary>
        public virtual BuildConfig NoEngineChanges(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-NoEngineChanges",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (BuildConfig) this;
        }

    
/// <summary>
/// Whether we should just export the outdated actions list
/// </summary>
        public virtual BuildConfig WriteOutdatedActions(object val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-WriteOutdatedActions",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (BuildConfig) this;
        }

    
/// <summary>
/// An optional directory to copy crash dump files into
/// </summary>
        public virtual BuildConfig SaveCrashDumps(object val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-SaveCrashDumps",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (BuildConfig) this;
        }

    
/// <summary>
/// If specified, then only this type of action will execute
/// </summary>
        public virtual BuildConfig ActionTypeFilter(object val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-ActionTypeFilter",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (BuildConfig) this;
        }
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    }

    protected readonly BuildConfig BuildStorage = new();
    
/// <summary>Cleans build products and intermediates for the target. This deletes files which are named consistently with the target being built
/// (e.g. UE4Editor-Foo-Win64-Debug.dll) rather than an actual record of previous build products.
/// Cleans build products and intermediates for the target. This deletes files which are named consistently with the target being built
/// (e.g. UnrealEditor-Foo-Win64-Debug.dll) rather than an actual record of previous build products.</summary>
    public  class CleanConfig : ToolConfig
    {
        public override string Name => "Clean";
        public override string CliName => "-Clean";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest;
    
/// <summary>
/// Whether to avoid cleaning targets
/// </summary>
        public virtual CleanConfig SkipRulesCompile(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-SkipRulesCompile",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (CleanConfig) this;
        }

    
/// <summary>
/// Skip pre build targets; just do the main target.
/// </summary>
        public virtual CleanConfig SkipPreBuildTargets(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-SkipPreBuildTargets",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (CleanConfig) this;
        }
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    }

    protected readonly CleanConfig CleanStorage = new();
    
/// <summary>
/// Invokes the deployment handler for a target.
/// </summary>
    public  class DeployConfig : ToolConfig
    {
        public override string Name => "Deploy";
        public override string CliName => "-Deploy";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest;
    
/// <summary>If we are just running the deployment step, specifies the path to the given deployment settings
/// REQUIRED!</summary>
        public virtual DeployConfig Receipt(object val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Receipt",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (DeployConfig) this;
        }
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    }

    protected readonly DeployConfig DeployStorage = new();
    
/// <summary>
/// Builds a target
/// </summary>
    public  class ExecuteConfig : ToolConfig
    {
        public override string Name => "Execute";
        public override string CliName => "-Execute";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest;
    
/// <summary>Whether we should just export the outdated actions list
/// REQUIRED!</summary>
        public virtual ExecuteConfig Actions(object val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Actions",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (ExecuteConfig) this;
        }
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    }

    protected readonly ExecuteConfig ExecuteStorage = new();
    
/// <summary>
/// Generate a clang compile_commands file for a target
/// </summary>
    public  class GenerateClangDatabaseConfig : ToolConfig
    {
        public override string Name => "GenerateClangDatabase";
        public override string CliName => "-GenerateClangDatabase";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest;
    
/// <summary>
/// Set of filters for files to include in the database. Relative to the root directory, or to the project file.
/// </summary>
        public virtual GenerateClangDatabaseConfig Filter(params object[] values)
        {
            if (true)
            {
                if (values != null)
                    foreach (var val in values)
                    {
                        AppendArgument(new UnrealToolArgument(
                            "-Filter",
                            Value: val.ToString(),
                            Setter: '=',
                            Meta: new(
                                Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4,
                                AllowMultiple: true
                            )
                        ));
                    }
            }
            return (GenerateClangDatabaseConfig) this;
        }

    
/// <summary>
/// Execute any actions which result in code generation (eg. ISPC compilation)
/// </summary>
        public virtual GenerateClangDatabaseConfig ExecCodeGenActions(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-ExecCodeGenActions",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (GenerateClangDatabaseConfig) this;
        }

    
/// <summary>
/// Execute any actions which result in code generation (eg. ISPC compilation)
/// </summary>
        public virtual GenerateClangDatabaseConfig NoExecCodeGenActions(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-NoExecCodeGenActions",
                    Value: null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (GenerateClangDatabaseConfig) this;
        }

    
/// <summary>
/// Optional set of source files to include in the compile database. If this is empty, all files will be included by default and -Exclude can be used to exclude some.
/// Relative to the root directory, or to the project file.
/// </summary>
        public virtual GenerateClangDatabaseConfig Include(params object[] values)
        {
            if (true)
            {
                if (values != null)
                    foreach (var val in values)
                    {
                        AppendArgument(new UnrealToolArgument(
                            "-Include",
                            Value: val.ToString(),
                            Setter: '=',
                            Meta: new(
                                Compatibility: UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                                AllowMultiple: true
                            )
                        ));
                    }
            }
            return (GenerateClangDatabaseConfig) this;
        }

    
/// <summary>
/// Optional set of source files to exclude from the compile database.
/// Relative to the root directory, or to the project file.
/// </summary>
        public virtual GenerateClangDatabaseConfig Exclude(params object[] values)
        {
            if (true)
            {
                if (values != null)
                    foreach (var val in values)
                    {
                        AppendArgument(new UnrealToolArgument(
                            "-Exclude",
                            Value: val.ToString(),
                            Setter: '=',
                            Meta: new(
                                Compatibility: UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                                AllowMultiple: true
                            )
                        ));
                    }
            }
            return (GenerateClangDatabaseConfig) this;
        }

    
/// <summary>
/// Optionally override the output filename for handling multiple targets
/// </summary>
        public virtual GenerateClangDatabaseConfig OutputFilename(object val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-OutputFilename",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (GenerateClangDatabaseConfig) this;
        }

    
/// <summary>
/// Optionally overrite the output directory for the compile_commands file.
/// </summary>
        public virtual GenerateClangDatabaseConfig OutputDir(object val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-OutputDir",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (GenerateClangDatabaseConfig) this;
        }
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    }

    protected readonly GenerateClangDatabaseConfig GenerateClangDatabaseStorage = new();
    
/// <summary>
/// Generates project files for one or more projects
/// </summary>
    public  class GenerateProjectFilesConfig : ToolConfig
    {
        public override string Name => "GenerateProjectFiles";
        public override string CliName => "-GenerateProjectFiles";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest;
    
/// <summary>
/// Types of project files to generate
/// </summary>
        public virtual GenerateProjectFilesConfig ProjectFileFormat(params ProjectFileFormat[] values)
        {
            if (true)
            {
                if (values != null)
                    foreach (var val in values)
                    {
                        AppendArgument(new UnrealToolArgument(
                            "-ProjectFileFormat",
                            Value: val.ToString(),
                            Setter: '=',
                            Meta: new(
                                Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                                AllowMultiple: true
                            )
                        ));
                    }
            }
            return (GenerateProjectFilesConfig) this;
        }

    
/// <summary>
/// Types of project files to generate
/// </summary>
        public virtual GenerateProjectFilesConfig _2012unsupported(params ProjectFileFormat[] values)
        {
            if (true)
            {
                if (values != null)
                    foreach (var val in values)
                    {
                        AppendArgument(new UnrealToolArgument(
                            "-2012unsupported",
                            Value: val.ToString(),
                            Setter: '=',
                            Meta: new(
                                Compatibility: UnrealCompatibility.UE_4,
                                AllowMultiple: true
                            )
                        ));
                    }
            }
            return (GenerateProjectFilesConfig) this;
        }

    
/// <summary>
/// Types of project files to generate
/// </summary>
        public virtual GenerateProjectFilesConfig _2013unsupported(params ProjectFileFormat[] values)
        {
            if (true)
            {
                if (values != null)
                    foreach (var val in values)
                    {
                        AppendArgument(new UnrealToolArgument(
                            "-2013unsupported",
                            Value: val.ToString(),
                            Setter: '=',
                            Meta: new(
                                Compatibility: UnrealCompatibility.UE_4,
                                AllowMultiple: true
                            )
                        ));
                    }
            }
            return (GenerateProjectFilesConfig) this;
        }

    
/// <summary>
/// Types of project files to generate
/// </summary>
        public virtual GenerateProjectFilesConfig _2015(params ProjectFileFormat[] values)
        {
            if (true)
            {
                if (values != null)
                    foreach (var val in values)
                    {
                        AppendArgument(new UnrealToolArgument(
                            "-2015",
                            Value: val.ToString(),
                            Setter: '=',
                            Meta: new(
                                Compatibility: UnrealCompatibility.UE_4,
                                AllowMultiple: true
                            )
                        ));
                    }
            }
            return (GenerateProjectFilesConfig) this;
        }

    
/// <summary>
/// Types of project files to generate
/// </summary>
        public virtual GenerateProjectFilesConfig _2017(params ProjectFileFormat[] values)
        {
            if (true)
            {
                if (values != null)
                    foreach (var val in values)
                    {
                        AppendArgument(new UnrealToolArgument(
                            "-2017",
                            Value: val.ToString(),
                            Setter: '=',
                            Meta: new(
                                Compatibility: UnrealCompatibility.UE_4,
                                AllowMultiple: true
                            )
                        ));
                    }
            }
            return (GenerateProjectFilesConfig) this;
        }

    
/// <summary>
/// Types of project files to generate
/// </summary>
        public virtual GenerateProjectFilesConfig _2019(params ProjectFileFormat[] values)
        {
            if (true)
            {
                if (values != null)
                    foreach (var val in values)
                    {
                        AppendArgument(new UnrealToolArgument(
                            "-2019",
                            Value: val.ToString(),
                            Setter: '=',
                            Meta: new(
                                Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3,
                                AllowMultiple: true
                            )
                        ));
                    }
            }
            return (GenerateProjectFilesConfig) this;
        }

    
/// <summary>
/// Types of project files to generate
/// </summary>
        public virtual GenerateProjectFilesConfig _2022(params ProjectFileFormat[] values)
        {
            if (true)
            {
                if (values != null)
                    foreach (var val in values)
                    {
                        AppendArgument(new UnrealToolArgument(
                            "-2022",
                            Value: val.ToString(),
                            Setter: '=',
                            Meta: new(
                                Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                                AllowMultiple: true
                            )
                        ));
                    }
            }
            return (GenerateProjectFilesConfig) this;
        }

    
/// <summary>
/// Types of project files to generate
/// </summary>
        public virtual GenerateProjectFilesConfig Makefile(params ProjectFileFormat[] values)
        {
            if (true)
            {
                if (values != null)
                    foreach (var val in values)
                    {
                        AppendArgument(new UnrealToolArgument(
                            "-Makefile",
                            Value: val.ToString(),
                            Setter: '=',
                            Meta: new(
                                Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                                AllowMultiple: true
                            )
                        ));
                    }
            }
            return (GenerateProjectFilesConfig) this;
        }

    
/// <summary>
/// Types of project files to generate
/// </summary>
        public virtual GenerateProjectFilesConfig CMakefile(params ProjectFileFormat[] values)
        {
            if (true)
            {
                if (values != null)
                    foreach (var val in values)
                    {
                        AppendArgument(new UnrealToolArgument(
                            "-CMakefile",
                            Value: val.ToString(),
                            Setter: '=',
                            Meta: new(
                                Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                                AllowMultiple: true
                            )
                        ));
                    }
            }
            return (GenerateProjectFilesConfig) this;
        }

    
/// <summary>
/// Types of project files to generate
/// </summary>
        public virtual GenerateProjectFilesConfig QMakefile(params ProjectFileFormat[] values)
        {
            if (true)
            {
                if (values != null)
                    foreach (var val in values)
                    {
                        AppendArgument(new UnrealToolArgument(
                            "-QMakefile",
                            Value: val.ToString(),
                            Setter: '=',
                            Meta: new(
                                Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                                AllowMultiple: true
                            )
                        ));
                    }
            }
            return (GenerateProjectFilesConfig) this;
        }

    
/// <summary>
/// Types of project files to generate
/// </summary>
        public virtual GenerateProjectFilesConfig KDevelopfile(params ProjectFileFormat[] values)
        {
            if (true)
            {
                if (values != null)
                    foreach (var val in values)
                    {
                        AppendArgument(new UnrealToolArgument(
                            "-KDevelopfile",
                            Value: val.ToString(),
                            Setter: '=',
                            Meta: new(
                                Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                                AllowMultiple: true
                            )
                        ));
                    }
            }
            return (GenerateProjectFilesConfig) this;
        }

    
/// <summary>
/// Types of project files to generate
/// </summary>
        public virtual GenerateProjectFilesConfig CodeLiteFiles(params ProjectFileFormat[] values)
        {
            if (true)
            {
                if (values != null)
                    foreach (var val in values)
                    {
                        AppendArgument(new UnrealToolArgument(
                            "-CodeLiteFiles",
                            Value: val.ToString(),
                            Setter: '=',
                            Meta: new(
                                Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                                AllowMultiple: true
                            )
                        ));
                    }
            }
            return (GenerateProjectFilesConfig) this;
        }

    
/// <summary>
/// Types of project files to generate
/// </summary>
        public virtual GenerateProjectFilesConfig XCodeProjectFiles(params ProjectFileFormat[] values)
        {
            if (true)
            {
                if (values != null)
                    foreach (var val in values)
                    {
                        AppendArgument(new UnrealToolArgument(
                            "-XCodeProjectFiles",
                            Value: val.ToString(),
                            Setter: '=',
                            Meta: new(
                                Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                                AllowMultiple: true
                            )
                        ));
                    }
            }
            return (GenerateProjectFilesConfig) this;
        }

    
/// <summary>
/// Types of project files to generate
/// </summary>
        public virtual GenerateProjectFilesConfig EddieProjectFiles(params ProjectFileFormat[] values)
        {
            if (true)
            {
                if (values != null)
                    foreach (var val in values)
                    {
                        AppendArgument(new UnrealToolArgument(
                            "-EddieProjectFiles",
                            Value: val.ToString(),
                            Setter: '=',
                            Meta: new(
                                Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                                AllowMultiple: true
                            )
                        ));
                    }
            }
            return (GenerateProjectFilesConfig) this;
        }

    
/// <summary>
/// Types of project files to generate
/// </summary>
        public virtual GenerateProjectFilesConfig VSCode(params ProjectFileFormat[] values)
        {
            if (true)
            {
                if (values != null)
                    foreach (var val in values)
                    {
                        AppendArgument(new UnrealToolArgument(
                            "-VSCode",
                            Value: val.ToString(),
                            Setter: '=',
                            Meta: new(
                                Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                                AllowMultiple: true
                            )
                        ));
                    }
            }
            return (GenerateProjectFilesConfig) this;
        }

    
/// <summary>
/// Types of project files to generate
/// </summary>
        public virtual GenerateProjectFilesConfig VSMac(params ProjectFileFormat[] values)
        {
            if (true)
            {
                if (values != null)
                    foreach (var val in values)
                    {
                        AppendArgument(new UnrealToolArgument(
                            "-VSMac",
                            Value: val.ToString(),
                            Setter: '=',
                            Meta: new(
                                Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                                AllowMultiple: true
                            )
                        ));
                    }
            }
            return (GenerateProjectFilesConfig) this;
        }

    
/// <summary>
/// Types of project files to generate
/// </summary>
        public virtual GenerateProjectFilesConfig CLion(params ProjectFileFormat[] values)
        {
            if (true)
            {
                if (values != null)
                    foreach (var val in values)
                    {
                        AppendArgument(new UnrealToolArgument(
                            "-CLion",
                            Value: val.ToString(),
                            Setter: '=',
                            Meta: new(
                                Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                                AllowMultiple: true
                            )
                        ));
                    }
            }
            return (GenerateProjectFilesConfig) this;
        }

    
/// <summary>
/// Types of project files to generate
/// </summary>
        public virtual GenerateProjectFilesConfig Rider(params ProjectFileFormat[] values)
        {
            if (true)
            {
                if (values != null)
                    foreach (var val in values)
                    {
                        AppendArgument(new UnrealToolArgument(
                            "-Rider",
                            Value: val.ToString(),
                            Setter: '=',
                            Meta: new(
                                Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                                AllowMultiple: true
                            )
                        ));
                    }
            }
            return (GenerateProjectFilesConfig) this;
        }

    
/// <summary>
/// Whether this command is being run in an automated mode
/// </summary>
        public virtual GenerateProjectFilesConfig Automated(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Automated",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (GenerateProjectFilesConfig) this;
        }

    
/// <summary>
/// Types of project files to generate
/// </summary>
        public virtual GenerateProjectFilesConfig VSWorkspace(params ProjectFileFormat[] values)
        {
            if (true)
            {
                if (values != null)
                    foreach (var val in values)
                    {
                        AppendArgument(new UnrealToolArgument(
                            "-VSWorkspace",
                            Value: val.ToString(),
                            Setter: '=',
                            Meta: new(
                                Compatibility: UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                                AllowMultiple: true
                            )
                        ));
                    }
            }
            return (GenerateProjectFilesConfig) this;
        }
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    }

    protected readonly GenerateProjectFilesConfig GenerateProjectFilesStorage = new();
    
/// <summary>
/// Exports a target as a JSON file
/// </summary>
    public  class JsonExportConfig : ToolConfig
    {
        public override string Name => "JsonExport";
        public override string CliName => "-JsonExport";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest;
    
/// <summary>
/// Execute any actions which result in code generation (eg. ISPC compilation)
/// </summary>
        public virtual JsonExportConfig ExecCodeGenActions(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-ExecCodeGenActions",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (JsonExportConfig) this;
        }
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    }

    protected readonly JsonExportConfig JsonExportStorage = new();
    
/// <summary>
/// Parses an MSVC timing info file generated from cl-filter to turn it into a form that can be used by other tooling.
/// This is implemented as a separate mode to allow it to be done as part of the action graph.
/// </summary>
/// <summary>
/// Parses an MSVC timing info file generated from cl-filter to turn it into a form that can be used by other tooling.
/// This is implemented as a separate mode to allow it to be done as part of the action graph.
/// </summary>
    public  class ParseMsvcTimingInfoConfig : ToolConfig
    {
        public override string Name => "ParseMsvcTimingInfo";
        public override string CliName => "-ParseMsvcTimingInfo";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest;
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    }

    protected readonly ParseMsvcTimingInfoConfig ParseMsvcTimingInfoStorage = new();
    
/// <summary>
/// Queries information about the targets supported by a project
/// </summary>
    public  class QueryTargetsConfig : ToolConfig
    {
        public override string Name => "QueryTargets";
        public override string CliName => "-QueryTargets";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest;
    
/// <summary>
/// Path to the project file to query
/// </summary>
        public virtual QueryTargetsConfig Project(object val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Project",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (QueryTargetsConfig) this;
        }

    
/// <summary>
/// Path to the output file to receive information about the targets
/// </summary>
        public virtual QueryTargetsConfig Output(object val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Output",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (QueryTargetsConfig) this;
        }

    
/// <summary>
/// Write out all targets, even if a default is specified in the BuildSettings section of the Default*.ini files.
/// </summary>
        public virtual QueryTargetsConfig IncludeAllTargets(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-IncludeAllTargets",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (QueryTargetsConfig) this;
        }

    
/// <summary>
/// Write all targets from parent assemblies (useful for EngineRules which can be chained)
/// </summary>
        public virtual QueryTargetsConfig IncludeParentAssembly(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-IncludeParentAssembly",
                    Value: null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (QueryTargetsConfig) this;
        }

    
/// <summary>
/// Write all targets from parent assemblies (useful for EngineRules which can be chained)
/// </summary>
        public virtual QueryTargetsConfig DontIncludeParentAssembly(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-DontIncludeParentAssembly",
                    Value: null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (QueryTargetsConfig) this;
        }
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    }

    protected readonly QueryTargetsConfig QueryTargetsStorage = new();
    
/// <summary>
/// Register all platforms (and in the process, configure all autosdks)
/// </summary>
    public  class SetupPlatformsConfig : ToolConfig
    {
        public override string Name => "SetupPlatforms";
        public override string CliName => "-SetupPlatforms";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest;
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    }

    protected readonly SetupPlatformsConfig SetupPlatformsStorage = new();
    
/// <summary>
/// Validates the various platforms to determine if they are ready for building
/// </summary>
    public  class ValidatePlatformsConfig : ToolConfig
    {
        public override string Name => "ValidatePlatforms";
        public override string CliName => "-ValidatePlatforms";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest;
    
/// <summary>
/// Platforms to validate
/// </summary>
        public virtual ValidatePlatformsConfig Platforms(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Platforms",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: true
                    )
                ));
            }
            return (ValidatePlatformsConfig) this;
        }

    
/// <summary>
/// Whether to validate all platforms
/// </summary>
        public virtual ValidatePlatformsConfig AllPlatforms(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-AllPlatforms",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (ValidatePlatformsConfig) this;
        }

    
/// <summary>
/// Whether to output SDK versions.
/// </summary>
        public virtual ValidatePlatformsConfig OutputSDKs(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-OutputSDKs",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (ValidatePlatformsConfig) this;
        }
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    }

    protected readonly ValidatePlatformsConfig ValidatePlatformsStorage = new();
    
/// <summary>
/// Generates documentation from reflection data
/// </summary>
    public  class WriteDocumentationConfig : ToolConfig
    {
        public override string Name => "WriteDocumentation";
        public override string CliName => "-WriteDocumentation";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest;
    
/// <summary>Type of documentation to generate
/// REQUIRED!</summary>
        public virtual WriteDocumentationConfig _Type(DocumentationType? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Type",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (WriteDocumentationConfig) this;
        }

    
/// <summary>The HTML file to write to
/// REQUIRED!</summary>
        public virtual WriteDocumentationConfig OutputFile(object val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-OutputFile",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (WriteDocumentationConfig) this;
        }
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    }

    protected readonly WriteDocumentationConfig WriteDocumentationStorage = new();
    
/// <summary>
/// Writes all metadata files at the end of a build (receipts, version files, etc...). This is implemented as a separate mode to allow it to be done as part of the action graph.
/// </summary>
    public  class WriteMetadataConfig : ToolConfig
    {
        public override string Name => "WriteMetadata";
        public override string CliName => "-WriteMetadata";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest;
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    }

    protected readonly WriteMetadataConfig WriteMetadataStorage = new();
    
/// <summary></summary>
    public  class AndroidToolChainConfig : ToolConfig
    {
        public override string Name => "AndroidToolChain";
        public override string CliName => "";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1;
    
/// <summary>
/// Lists Architectures that you want to build
/// </summary>
        public virtual AndroidToolChainConfig Architectures(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Architectures",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1,
                        AllowMultiple: true
                    )
                ));
            }
            return (AndroidToolChainConfig) this;
        }
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    }

    protected readonly AndroidToolChainConfig AndroidToolChainStorage = new();
    
/// <summary>
/// Android-specific target settings
/// </summary>
    public  class AndroidTargetRulesConfig : ToolConfig
    {
        public override string Name => "AndroidTargetRules";
        public override string CliName => "";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest;
    
/// <summary>
/// Lists Architectures that you want to build
/// </summary>
        public virtual AndroidTargetRulesConfig Architectures(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Architectures",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1,
                        AllowMultiple: true
                    )
                ));
            }
            return (AndroidTargetRulesConfig) this;
        }

    
/// <summary>
/// Lists GPU Architectures that you want to build (mostly used for mobile etc.)
/// </summary>
        public virtual AndroidTargetRulesConfig GPUArchitectures(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-GPUArchitectures",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1,
                        AllowMultiple: true
                    )
                ));
            }
            return (AndroidTargetRulesConfig) this;
        }

    
/// <summary>Enables address sanitizer (ASan)
/// Enables address sanitizer (ASan).
/// Enables address sanitizer (ASan). Only supported for Visual Studio 2019 16.7.0 and up.</summary>
        public virtual AndroidTargetRulesConfig EnableASan(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-EnableASan",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (AndroidTargetRulesConfig) this;
        }

    
/// <summary>
/// Enables HW address sanitizer (HWASan)
/// </summary>
        public virtual AndroidTargetRulesConfig EnableHWASan(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-EnableHWASan",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (AndroidTargetRulesConfig) this;
        }

    
/// <summary>Enables undefined behavior sanitizer (UBSan)
/// Enables undefined behavior sanitizer (UBSan).</summary>
        public virtual AndroidTargetRulesConfig EnableUBSan(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-EnableUBSan",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (AndroidTargetRulesConfig) this;
        }

    
/// <summary>
/// Enables minimal undefined behavior sanitizer (UBSan)
/// </summary>
        public virtual AndroidTargetRulesConfig EnableMinUBSan(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-EnableMinUBSan",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (AndroidTargetRulesConfig) this;
        }
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    }

    protected readonly AndroidTargetRulesConfig AndroidTargetRulesStorage = new();
    
/// <summary></summary>
    public  class UEDeployAndroidConfig : ToolConfig
    {
        public override string Name => "UEDeployAndroid";
        public override string CliName => "";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest;
    
/// <summary>
/// Ignore AppBundle (AAB) generation setting if "-ForceAPKGeneration" specified
/// </summary>
        public virtual UEDeployAndroidConfig ForceAPKGeneration(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-ForceAPKGeneration",
                    Value: null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UEDeployAndroidConfig) this;
        }

    
/// <summary>
/// Do not use Gradle if previous APK exists and only libUnreal.so changed
/// </summary>
        public virtual UEDeployAndroidConfig BypassGradlePackaging(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-BypassGradlePackaging",
                    Value: null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UEDeployAndroidConfig) this;
        }

    
/// <summary>
/// Whether UBT is invoked from MSBuild.
/// If false will, disable bDontBundleLibrariesInAPK, unless forced .
/// </summary>
        public virtual UEDeployAndroidConfig FromMsBuild(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-FromMsBuild",
                    Value: null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UEDeployAndroidConfig) this;
        }

    
/// <summary>
/// Forcing bDontBundleLibrariesInAPK to "true" or "false" ignoring any other option.
/// </summary>
        public virtual UEDeployAndroidConfig ForceDontBundleLibrariesInAPK(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-ForceDontBundleLibrariesInAPK",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UEDeployAndroidConfig) this;
        }

    
/// <summary>
/// Adds LD_PRELOAD'ed .so to capture all malloc/free/etc calls to libc.so and route them to our memory tracing.
/// </summary>
        public virtual UEDeployAndroidConfig ScudoMemoryTracing(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-ScudoMemoryTracing",
                    Value: null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UEDeployAndroidConfig) this;
        }
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    }

    protected readonly UEDeployAndroidConfig UEDeployAndroidStorage = new();
    
/// <summary>
/// HoloLens-specific target settings
/// </summary>
    public  class HoloLensTargetRulesConfig : ToolConfig
    {
        public override string Name => "HoloLensTargetRules";
        public override string CliName => "";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0;
    
/// <summary>Version of the compiler toolchain to use on HoloLens. A value of "default" will be changed to a specific version at UBT startup.
/// Version of the compiler toolchain to use on Windows platform. A value of "default" will be changed to a specific version at UBT start up.</summary>
        public virtual HoloLensTargetRulesConfig _2015(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-2015",
                    Value: null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4,
                        AllowMultiple: false
                    )
                ));
            }
            return (HoloLensTargetRulesConfig) this;
        }

    
/// <summary>Version of the compiler toolchain to use on HoloLens. A value of "default" will be changed to a specific version at UBT startup.
/// Version of the compiler toolchain to use on Windows platform. A value of "default" will be changed to a specific version at UBT start up.</summary>
        public virtual HoloLensTargetRulesConfig _2017(WindowsCompiler? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-2017",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4,
                        AllowMultiple: false
                    )
                ));
            }
            return (HoloLensTargetRulesConfig) this;
        }

    
/// <summary>Version of the compiler toolchain to use on HoloLens. A value of "default" will be changed to a specific version at UBT startup.
/// Version of the compiler toolchain to use on Windows platform. A value of "default" will be changed to a specific version at UBT start up.</summary>
        public virtual HoloLensTargetRulesConfig _2019(WindowsCompiler? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-2019",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3,
                        AllowMultiple: false
                    )
                ));
            }
            return (HoloLensTargetRulesConfig) this;
        }

    
/// <summary>Version of the compiler toolchain to use on HoloLens. A value of "default" will be changed to a specific version at UBT startup.
/// Version of the compiler toolchain to use on Windows platform. A value of "default" will be changed to a specific version at UBT start up.</summary>
        public virtual HoloLensTargetRulesConfig _2022(WindowsCompiler? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-2022",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (HoloLensTargetRulesConfig) this;
        }
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    }

    protected readonly HoloLensTargetRulesConfig HoloLensTargetRulesStorage = new();
    
    
    public  class IOSPostBuildSyncConfig : ToolConfig
    {
        public override string Name => "IOSPostBuildSync";
        public override string CliName => "-IOSPostBuildSync";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest;
    
/// <summary>REQUIRED!</summary>
        public virtual IOSPostBuildSyncConfig Input(object val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Input",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (IOSPostBuildSyncConfig) this;
        }

    
    
        public virtual IOSPostBuildSyncConfig XmlConfigCache(object val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-XmlConfigCache",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (IOSPostBuildSyncConfig) this;
        }

    
    
        public virtual IOSPostBuildSyncConfig LegacyXcode(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-LegacyXcode",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (IOSPostBuildSyncConfig) this;
        }
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    }

    protected readonly IOSPostBuildSyncConfig IOSPostBuildSyncStorage = new();
    
/// <summary>
/// IOS-specific target settings
/// </summary>
    public  class IOSTargetRulesConfig : ToolConfig
    {
        public override string Name => "IOSTargetRules";
        public override string CliName => "";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest;
    
/// <summary>
/// Whether to strip iOS symbols or not (implied by Shipping config).
/// </summary>
        public virtual IOSTargetRulesConfig Stripsymbols(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-stripsymbols",
                    Value: null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (IOSTargetRulesConfig) this;
        }

    
/// <summary>
/// If true, then a stub IPA will be generated when compiling is done (minimal files needed for a valid IPA).
/// </summary>
        public virtual IOSTargetRulesConfig CreateStub(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-CreateStub",
                    Value: null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (IOSTargetRulesConfig) this;
        }

    
/// <summary>
/// Don't generate crashlytics data
/// </summary>
        public virtual IOSTargetRulesConfig Alwaysgeneratedsym(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-alwaysgeneratedsym",
                    Value: null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (IOSTargetRulesConfig) this;
        }

    
/// <summary>
/// Don't generate crashlytics data
/// </summary>
        public virtual IOSTargetRulesConfig Skipcrashlytics(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-skipcrashlytics",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (IOSTargetRulesConfig) this;
        }

    
/// <summary>Mark the build for distribution
/// If -distribution was passed on the commandline, this build is for distribution.</summary>
        public virtual IOSTargetRulesConfig Distribution(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-distribution",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (IOSTargetRulesConfig) this;
        }

    
/// <summary>
/// Manual override for the provision to use. Should be a full path.
/// </summary>
        public virtual IOSTargetRulesConfig ImportProvision(object val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-ImportProvision",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (IOSTargetRulesConfig) this;
        }

    
/// <summary>
/// Imports the given certificate (inc private key) into a temporary keychain before signing.
/// </summary>
        public virtual IOSTargetRulesConfig ImportCertificate(object val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-ImportCertificate",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (IOSTargetRulesConfig) this;
        }

    
/// <summary>
/// Password for the imported certificate
/// </summary>
        public virtual IOSTargetRulesConfig ImportCertificatePassword(object val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-ImportCertificatePassword",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (IOSTargetRulesConfig) this;
        }

    
/// <summary>
/// Enables address sanitizer (ASan)
/// </summary>
        public virtual IOSTargetRulesConfig EnableASan(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-EnableASan",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (IOSTargetRulesConfig) this;
        }

    
/// <summary>Enables thread sanitizer (TSan)
/// Enables thread sanitizer (TSan).</summary>
        public virtual IOSTargetRulesConfig EnableTSan(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-EnableTSan",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (IOSTargetRulesConfig) this;
        }

    
/// <summary>
/// Enables undefined behavior sanitizer (UBSan)
/// </summary>
        public virtual IOSTargetRulesConfig EnableUBSan(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-EnableUBSan",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (IOSTargetRulesConfig) this;
        }

    
/// <summary>
/// Disables clang build verification checks on static libraries
/// </summary>
        public virtual IOSTargetRulesConfig Skipclangvalidation(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-skipclangvalidation",
                    Value: null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (IOSTargetRulesConfig) this;
        }

    
/// <summary>Don't generate crashlytics data
/// Enables the generation of .dsym files. This can be disabled to enable faster iteration times during development.</summary>
        public virtual IOSTargetRulesConfig EnableDSYM(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-EnableDSYM",
                    Value: null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (IOSTargetRulesConfig) this;
        }
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    }

    protected readonly IOSTargetRulesConfig IOSTargetRulesStorage = new();
    
/// <summary>
/// Stores project-specific IOS settings. Instances of this object are cached by IOSPlatform.
/// </summary>
    public  class IOSProjectSettingsConfig : ToolConfig
    {
        public override string Name => "IOSProjectSettings";
        public override string CliName => "";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest;
    
/// <summary>
/// Whether to build the iOS project as a framework.
/// </summary>
        public virtual IOSProjectSettingsConfig BuildAsFramework(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-build-as-framework",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (IOSProjectSettingsConfig) this;
        }

    
/// <summary>
/// Whether to generate a dSYM file or not.
/// </summary>
        public virtual IOSProjectSettingsConfig Generatedsymfile(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-generatedsymfile",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (IOSProjectSettingsConfig) this;
        }

    
/// <summary>
/// Whether to generate a dSYM bundle (as opposed to single file dSYM)
/// </summary>
        public virtual IOSProjectSettingsConfig Generatedsymbundle(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-generatedsymbundle",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (IOSProjectSettingsConfig) this;
        }
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    }

    protected readonly IOSProjectSettingsConfig IOSProjectSettingsStorage = new();
    
/// <summary>
/// Linux-specific target settings
/// </summary>
    public  class LinuxTargetRulesConfig : ToolConfig
    {
        public override string Name => "LinuxTargetRules";
        public override string CliName => "";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest;
    
/// <summary>Enables address sanitizer (ASan)
/// Enables address sanitizer (ASan).
/// Enables address sanitizer (ASan). Only supported for Visual Studio 2019 16.7.0 and up.</summary>
        public virtual LinuxTargetRulesConfig EnableASan(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-EnableASan",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (LinuxTargetRulesConfig) this;
        }

    
/// <summary>Enables thread sanitizer (TSan)
/// Enables thread sanitizer (TSan).</summary>
        public virtual LinuxTargetRulesConfig EnableTSan(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-EnableTSan",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (LinuxTargetRulesConfig) this;
        }

    
/// <summary>Enables undefined behavior sanitizer (UBSan)
/// Enables undefined behavior sanitizer (UBSan).</summary>
        public virtual LinuxTargetRulesConfig EnableUBSan(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-EnableUBSan",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (LinuxTargetRulesConfig) this;
        }

    
/// <summary>
/// Enables memory sanitizer (MSan)
/// </summary>
        public virtual LinuxTargetRulesConfig EnableMSan(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-EnableMSan",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (LinuxTargetRulesConfig) this;
        }

    
/// <summary>Enables "thin" LTO
/// When Link Time Code Generation (LTCG) is enabled, whether to
/// prefer using the lighter weight version on supported platforms.</summary>
        public virtual LinuxTargetRulesConfig ThinLTO(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-ThinLTO",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (LinuxTargetRulesConfig) this;
        }

    
/// <summary>
/// Turns on tuning of debug info for LLDB
/// </summary>
        public virtual LinuxTargetRulesConfig EnableLLDB(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-EnableLLDB",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (LinuxTargetRulesConfig) this;
        }

    
/// <summary>Enables LibFuzzer
/// Enables LibFuzzer.
/// Enables LibFuzzer. Only supported for Visual Studio 2022 17.0.0 and up.</summary>
        public virtual LinuxTargetRulesConfig EnableLibFuzzer(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-EnableLibFuzzer",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (LinuxTargetRulesConfig) this;
        }

    
/// <summary>
/// Whether to globally disable calling dump_syms
/// </summary>
        public virtual LinuxTargetRulesConfig NoDumpSyms(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-NoDumpSyms",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (LinuxTargetRulesConfig) this;
        }
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    }

    protected readonly LinuxTargetRulesConfig LinuxTargetRulesStorage = new();
    
/// <summary></summary>
    public  class LuminToolChainConfig : ToolConfig
    {
        public override string Name => "LuminToolChain";
        public override string CliName => "";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE_4;
    
    
        public virtual LuminToolChainConfig GpuArchitectures(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-GpuArchitectures",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4,
                        AllowMultiple: true
                    )
                ));
            }
            return (LuminToolChainConfig) this;
        }
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    }

    protected readonly LuminToolChainConfig LuminToolChainStorage = new();
    
/// <summary>
/// Lumin-specific target settings
/// </summary>
    public  class LuminTargetRulesConfig : ToolConfig
    {
        public override string Name => "LuminTargetRules";
        public override string CliName => "";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE_4;
    
/// <summary>
/// Lists GPU Architectures that you want to build (mostly used for mobile etc.)
/// </summary>
        public virtual LuminTargetRulesConfig GPUArchitectures(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-GPUArchitectures",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4,
                        AllowMultiple: true
                    )
                ));
            }
            return (LuminTargetRulesConfig) this;
        }

    
/// <summary>
/// If -distribution was passed on the commandline, this build is for distribution.
/// </summary>
        public virtual LuminTargetRulesConfig Distribution(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-distribution",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4,
                        AllowMultiple: false
                    )
                ));
            }
            return (LuminTargetRulesConfig) this;
        }
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    }

    protected readonly LuminTargetRulesConfig LuminTargetRulesStorage = new();
    
/// <summary>
/// Mac-specific target settings
/// </summary>
    public  class MacTargetRulesConfig : ToolConfig
    {
        public override string Name => "MacTargetRules";
        public override string CliName => "";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest;
    
/// <summary>
/// Enables address sanitizer (ASan).
/// </summary>
        public virtual MacTargetRulesConfig EnableASan(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-EnableASan",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (MacTargetRulesConfig) this;
        }

    
/// <summary>
/// Enables thread sanitizer (TSan).
/// </summary>
        public virtual MacTargetRulesConfig EnableTSan(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-EnableTSan",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (MacTargetRulesConfig) this;
        }

    
/// <summary>
/// Enables undefined behavior sanitizer (UBSan).
/// </summary>
        public virtual MacTargetRulesConfig EnableUBSan(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-EnableUBSan",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (MacTargetRulesConfig) this;
        }

    
/// <summary>
/// Enables the generation of .dsym files. This can be disabled to enable faster iteration times during development.
/// </summary>
        public virtual MacTargetRulesConfig NoDSYM(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-NoDSYM",
                    Value: null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_0,
                        AllowMultiple: false
                    )
                ));
            }
            return (MacTargetRulesConfig) this;
        }

    
/// <summary>Enables the generation of .dsym files. This can be disabled to enable faster iteration times during development.
/// Don't generate crashlytics data</summary>
        public virtual MacTargetRulesConfig EnableDSYM(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-EnableDSYM",
                    Value: null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (MacTargetRulesConfig) this;
        }

    
/// <summary>
/// Disables clang build verification checks on static libraries
/// </summary>
        public virtual MacTargetRulesConfig Skipclangvalidation(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-skipclangvalidation",
                    Value: null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (MacTargetRulesConfig) this;
        }

    
/// <summary>
/// Enables LibFuzzer.
/// </summary>
        public virtual MacTargetRulesConfig EnableLibFuzzer(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-EnableLibFuzzer",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (MacTargetRulesConfig) this;
        }
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    }

    protected readonly MacTargetRulesConfig MacTargetRulesStorage = new();
    
/// <summary>
/// Special mode for gathering all the messages into a single output file
/// </summary>
    public  class PVSGatherConfig : ToolConfig
    {
        public override string Name => "PVSGather";
        public override string CliName => "-PVSGather";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest;
    
/// <summary>Path to the input file list
/// REQUIRED!</summary>
        public virtual PVSGatherConfig Input(object val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Input",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (PVSGatherConfig) this;
        }

    
/// <summary>Output file to generate
/// REQUIRED!</summary>
        public virtual PVSGatherConfig Output(object val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Output",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (PVSGatherConfig) this;
        }

    
/// <summary>
/// The maximum level of warnings to print
/// </summary>
        public virtual PVSGatherConfig PrintLevel(double? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-PrintLevel",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (PVSGatherConfig) this;
        }

    
/// <summary>
/// Version of the analyzers
/// </summary>
        public virtual PVSGatherConfig AnalyzerVersion(object val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-AnalyzerVersion",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5,
                        AllowMultiple: false
                    )
                ));
            }
            return (PVSGatherConfig) this;
        }

    
/// <summary>Path to file list of paths to ignore
/// REQUIRED!</summary>
        public virtual PVSGatherConfig Ignored(object val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Ignored",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (PVSGatherConfig) this;
        }

    
/// <summary>Path to file list of rootpaths,realpath mapping
/// REQUIRED!</summary>
        public virtual PVSGatherConfig RootPaths(object val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-RootPaths",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (PVSGatherConfig) this;
        }
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    }

    protected readonly PVSGatherConfig PVSGatherStorage = new();
    
/// <summary>
/// Windows-specific target settings
/// </summary>
    public  class WindowsTargetRulesConfig : ToolConfig
    {
        public override string Name => "WindowsTargetRules";
        public override string CliName => "";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest;
    
/// <summary>
/// Version of the compiler toolchain to use on Windows platform. A value of "default" will be changed to a specific version at UBT start up.
/// </summary>
        public virtual WindowsTargetRulesConfig _2015(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-2015",
                    Value: null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4,
                        AllowMultiple: false
                    )
                ));
            }
            return (WindowsTargetRulesConfig) this;
        }

    
/// <summary>
/// Version of the compiler toolchain to use on Windows platform. A value of "default" will be changed to a specific version at UBT start up.
/// </summary>
        public virtual WindowsTargetRulesConfig _2017(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-2017",
                    Value: null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4,
                        AllowMultiple: false
                    )
                ));
            }
            return (WindowsTargetRulesConfig) this;
        }

    
/// <summary>
/// Version of the compiler toolchain to use on Windows platform. A value of "default" will be changed to a specific version at UBT start up.
/// </summary>
        public virtual WindowsTargetRulesConfig _2019(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-2019",
                    Value: null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3,
                        AllowMultiple: false
                    )
                ));
            }
            return (WindowsTargetRulesConfig) this;
        }

    
/// <summary>
/// Version of the compiler toolchain to use on Windows platform. A value of "default" will be changed to a specific version at UBT start up.
/// </summary>
        public virtual WindowsTargetRulesConfig _2022(WindowsCompiler? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-2022",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (WindowsTargetRulesConfig) this;
        }

    
/// <summary>
/// Version of the compiler toolchain to use on Windows platform. A value of "default" will be changed to a specific version at UBT start up.
/// </summary>
        public virtual WindowsTargetRulesConfig Compiler(WindowsCompiler? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Compiler",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (WindowsTargetRulesConfig) this;
        }

    
/// <summary>The specific toolchain version to use. This may be a specific version number (for example, "14.13.26128"), the string "Latest" to select the newest available version, or
/// the string "Preview" to select the newest available preview version. By default, and if it is available, we use the toolchain version indicated by
/// WindowsPlatform.DefaultToolChainVersion (otherwise, we use the latest version).
/// The specific compiler version to use. This may be a specific version number (for example, "14.13.26128"), the string "Latest" to select the newest available version, or
/// the string "Preview" to select the newest available preview version. By default, and if it is available, we use the toolchain version indicated by
/// WindowsPlatform.DefaultToolChainVersion (otherwise, we use the latest version).</summary>
        public virtual WindowsTargetRulesConfig CompilerVersion(object val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-CompilerVersion",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (WindowsTargetRulesConfig) this;
        }

    
/// <summary>The static analyzer to use.
/// Whether static code analysis should be enabled.</summary>
        public virtual WindowsTargetRulesConfig StaticAnalyzer(WindowsStaticAnalyzer? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-StaticAnalyzer",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (WindowsTargetRulesConfig) this;
        }

    
/// <summary>
/// Whether we should export a file containing .obj to source file mappings.
/// </summary>
        public virtual WindowsTargetRulesConfig ObjSrcMap(object val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-ObjSrcMap",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (WindowsTargetRulesConfig) this;
        }

    
/// <summary>Enables strict standard conformance mode (/permissive-) in VS2017+.
/// Enables strict standard conformance mode (/permissive-).</summary>
        public virtual WindowsTargetRulesConfig Strict(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Strict",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (WindowsTargetRulesConfig) this;
        }

    
/// <summary>
/// Print out files that are included by each source file
/// </summary>
        public virtual WindowsTargetRulesConfig ShowIncludes(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-ShowIncludes",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (WindowsTargetRulesConfig) this;
        }

    
/// <summary>The output type to use for the static analyzer.
/// The output type to use for the static analyzer. This is only supported for Clang.</summary>
        public virtual WindowsTargetRulesConfig StaticAnalyzerOutputType(WindowsStaticAnalyzerOutputType? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-StaticAnalyzerOutputType",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (WindowsTargetRulesConfig) this;
        }

    
/// <summary>
/// Enables address sanitizer (ASan). Only supported for Visual Studio 2019 16.7.0 and up.
/// </summary>
        public virtual WindowsTargetRulesConfig EnableASan(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-EnableASan",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (WindowsTargetRulesConfig) this;
        }

    
/// <summary>Set flags require for determinstic compiles (experimental)
/// Force set flags require for determinstic compiling and linking (experimental, may not be fully supported).
/// This setting is only recommended for testing, instead:
/// * Set bDeterministic on a per module basis in ModuleRules to control deterministic compiling.
/// * Set bDeterministic on a per target basis in TargetRules to control deterministic linking.
/// Set flags require for deterministic compiling and linking.
/// Enabling deterministic mode for msvc disables codegen multithreading so compiling will be slower</summary>
        public virtual WindowsTargetRulesConfig Deterministic(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Deterministic",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (WindowsTargetRulesConfig) this;
        }

    
/// <summary>
/// Enables updated __cplusplus macro (/Zc:__cplusplus).
/// </summary>
        public virtual WindowsTargetRulesConfig UpdatedCPPMacro(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-UpdatedCPPMacro",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (WindowsTargetRulesConfig) this;
        }

    
/// <summary>
/// Enables inline conformance (Remove unreferenced COMDAT) (/Zc:inline).
/// </summary>
        public virtual WindowsTargetRulesConfig StrictInline(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-StrictInline",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (WindowsTargetRulesConfig) this;
        }

    
/// <summary>Enables new preprocessor conformance (/Zc:preprocessor).
/// Enables new preprocessor conformance (/Zc:preprocessor). This is always enabled for C++20 modules.</summary>
        public virtual WindowsTargetRulesConfig StrictPreprocessor(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-StrictPreprocessor",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (WindowsTargetRulesConfig) this;
        }

    
/// <summary>
/// Enables enum types conformance (/Zc:enumTypes) in VS2022 17.4 Preview 4.0+.
/// </summary>
        public virtual WindowsTargetRulesConfig StrictEnumTypes(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-StrictEnumTypes",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (WindowsTargetRulesConfig) this;
        }

    
/// <summary>True if we should use the Clang linker (LLD) when we are compiling with Clang, or Intel linker (xilink\xilib) when we are compiling with Intel oneAPI, otherwise we use the MSVC linker.
/// True if we should use the Clang linker (LLD) when we are compiling with Clang or Intel oneAPI, otherwise we use the MSVC linker.</summary>
        public virtual WindowsTargetRulesConfig ClangLinker(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-ClangLinker",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (WindowsTargetRulesConfig) this;
        }

    
/// <summary>If specified along with -PGOProfile, then /FASTGENPROFILE will be used instead of /GENPROFILE.
/// This usually means that the PGO data is generated faster, but the resulting data may not yield as efficient optimizations during -PGOOptimize
/// If specified along with -PGOProfile, then /FASTGENPROFILE will be used instead of /GENPROFILE. This usually means that the PGO data is generated faster, but the resulting data may not yield as efficient optimizations during -PGOOptimize</summary>
        public virtual WindowsTargetRulesConfig PGOFastGen(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-PGOFastGen",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (WindowsTargetRulesConfig) this;
        }

    
/// <summary>
/// Version of the toolchain to use on Windows platform when a non-msvc Compiler is in use, to locate include paths etc.
/// </summary>
        public virtual WindowsTargetRulesConfig VCToolchain(WindowsCompiler? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-VCToolchain",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (WindowsTargetRulesConfig) this;
        }

    
/// <summary>
/// If -PGOOptimize is specified but the linker flags have changed since the last -PGOProfile, this will emit a warning and build without PGO instead of failing during link with LNK1268.
/// </summary>
        public virtual WindowsTargetRulesConfig IgnoreStalePGOData(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-IgnoreStalePGOData",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (WindowsTargetRulesConfig) this;
        }

    
/// <summary>
/// If specified along with -PGOProfile, prevent the usage of extra counters. Please note that by default /FASTGENPROFILE doesnt use extra counters
/// </summary>
/// <seealso href="link">https://learn.microsoft.com/en-us/cpp/build/reference/genprofile-fastgenprofile-generate-profiling-instrumented-build</seealso>
        public virtual WindowsTargetRulesConfig PGONoExtraCounters(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-PGONoExtraCounters",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (WindowsTargetRulesConfig) this;
        }

    
/// <summary>
/// The specific msvc toolchain version to use if the compiler is not msvc. This may be a specific version number (for example, "14.13.26128"), the string "Latest" to select the newest available version, or
/// the string "Preview" to select the newest available preview version. By default, and if it is available, we use the toolchain version indicated by
/// WindowsPlatform.DefaultToolChainVersion (otherwise, we use the latest version).
/// </summary>
        public virtual WindowsTargetRulesConfig VCToolchainVersion(object val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-VCToolchainVersion",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (WindowsTargetRulesConfig) this;
        }

    
/// <summary>
/// True if /fastfail should be passed to the msvc compiler and linker
/// </summary>
        public virtual WindowsTargetRulesConfig VCFastFail(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-VCFastFail",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (WindowsTargetRulesConfig) this;
        }

    
/// <summary>
/// The specific Windows SDK version to use. This may be a specific version number (for example, "8.1", "10.0" or "10.0.10150.0"), or the string "Latest", to select the newest available version.
/// By default, and if it is available, we use the Windows SDK version indicated by WindowsPlatform.DefaultWindowsSdkVersion (otherwise, we use the latest version).
/// </summary>
        public virtual WindowsTargetRulesConfig WindowsSDKVersion(object val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-WindowsSDKVersion",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (WindowsTargetRulesConfig) this;
        }

    
/// <summary>
/// Enables LibFuzzer. Only supported for Visual Studio 2022 17.0.0 and up.
/// </summary>
        public virtual WindowsTargetRulesConfig EnableLibFuzzer(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-EnableLibFuzzer",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (WindowsTargetRulesConfig) this;
        }

    
/// <summary>
/// Whether .sarif files containing errors and warnings are written alongside each .obj, if supported
/// </summary>
        public virtual WindowsTargetRulesConfig Sarif(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Sarif",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4,
                        AllowMultiple: false
                    )
                ));
            }
            return (WindowsTargetRulesConfig) this;
        }

    
/// <summary>
/// Specify an alternate location for the PDB file. This option does not change the location of the generated PDB file,
/// it changes the name that is embedded into the executable. Path can contain %_PDB% which will be expanded to the original
/// PDB file name of the target, without the directory.
/// See https://learn.microsoft.com/en-us/cpp/build/reference/pdbaltpath-use-alternate-pdb-path
/// </summary>
        public virtual WindowsTargetRulesConfig PdbAltPath(object val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-PdbAltPath",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (WindowsTargetRulesConfig) this;
        }

    
/// <summary>
/// If enabled will set the ProductVersion embeded in windows executables and dlls to contain BUILT_FROM_CHANGELIST and BuildVersion
/// Enabled by default for all precompiled and Shipping configurations. Regardless of this setting, the versions from Build.version will be available via the BuildSettings module
/// Note: Embedding these versions will cause resource files to be recompiled whenever changelist is updated which will cause binaries to relink
/// </summary>
        public virtual WindowsTargetRulesConfig SetResourceVersions(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-SetResourceVersions",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (WindowsTargetRulesConfig) this;
        }

    
/// <summary>
/// If enabled will set the ProductVersion embeded in windows executables and dlls to contain BUILT_FROM_CHANGELIST and BuildVersion
/// Enabled by default for all precompiled and Shipping configurations. Regardless of this setting, the versions from Build.version will be available via the BuildSettings module
/// Note: Embedding these versions will cause resource files to be recompiled whenever changelist is updated which will cause binaries to relink
/// </summary>
        public virtual WindowsTargetRulesConfig NoSetResourceVersions(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-NoSetResourceVersions",
                    Value: null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (WindowsTargetRulesConfig) this;
        }

    
/// <summary>
/// Warning level when reporting toolchains that are not in the preferred version list
/// </summary>
/// <seealso cref="MicrosoftPlatformSDK.PreferredVisualCppVersions" />
        public virtual WindowsTargetRulesConfig ToolchainVersionWarningLevel(WarningLevel? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-ToolchainVersionWarningLevel",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (WindowsTargetRulesConfig) this;
        }

    
/// <summary>
/// If specified along with -PGOProfile, use sample-based PGO instead of instrumented. Currently Intel oneAPI 2024.0+ only.
/// </summary>
        public virtual WindowsTargetRulesConfig SampleBasedPGO(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-SampleBasedPGO",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (WindowsTargetRulesConfig) this;
        }

    
/// <summary>
/// True if /d2ExtendedWarningInfo should be passed to the compiler and /d2:-ExtendedWarningInfo to the linker
/// </summary>
        public virtual WindowsTargetRulesConfig VCExtendedWarningInfo(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-VCExtendedWarningInfo",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (WindowsTargetRulesConfig) this;
        }

    
/// <summary>
/// True if /d2ExtendedWarningInfo should be passed to the compiler and /d2:-ExtendedWarningInfo to the linker
/// </summary>
        public virtual WindowsTargetRulesConfig VCDisableExtendedWarningInfo(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-VCDisableExtendedWarningInfo",
                    Value: null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (WindowsTargetRulesConfig) this;
        }

    
/// <summary>
/// True if optimizations to reduce the size of debug information should be disabled
/// See https://clang.llvm.org/docs/UsersManual.html#cmdoption-fstandalone-debug for more information
/// </summary>
        public virtual WindowsTargetRulesConfig ClangStandaloneDebug(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-ClangStandaloneDebug",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (WindowsTargetRulesConfig) this;
        }

    
/// <summary>
/// Whether to have the linker or library tool to generate a link repro in the specified directory
/// See https://learn.microsoft.com/en-us/cpp/build/reference/linkrepro for more information
/// </summary>
        public virtual WindowsTargetRulesConfig LinkRepro(object val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-LinkRepro",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (WindowsTargetRulesConfig) this;
        }

    
/// <summary>
/// Whether to request the linker create a stripped pdb file as part of the build.
/// If enabled the full debug pdb will have the extension .full.pdb
/// </summary>
        public virtual WindowsTargetRulesConfig StripPrivateSymbols(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-StripPrivateSymbols",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (WindowsTargetRulesConfig) this;
        }

    
/// <summary>
/// Whether this build will use Microsoft's custom XCurl instead of libcurl
/// Note that XCurl is not part of the normal Windows SDK and will require additional downloads
/// </summary>
        public virtual WindowsTargetRulesConfig UseXCurl(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-UseXCurl",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (WindowsTargetRulesConfig) this;
        }

    
/// <summary>
/// Volatile Metadata is enabled by default and improves x64 emulation on arm64, but may come at a small perfomance cost (/volatileMetadata-).
/// </summary>
        public virtual WindowsTargetRulesConfig DisableVolatileMetadata(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-DisableVolatileMetadata",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (WindowsTargetRulesConfig) this;
        }

    
/// <summary>
/// If specified along with -PGOOptimize, will use the specified per-merged pgd file instead of the usual pgd file with loose pgc files.
/// </summary>
        public virtual WindowsTargetRulesConfig PGOMergedPGD(object val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-PGOMergedPGD",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (WindowsTargetRulesConfig) this;
        }

    
/// <summary>
/// True if we should use the Clang linker (LLD) when we are compiling with Clang or Intel oneAPI, otherwise we use the MSVC linker.
/// </summary>
        public virtual WindowsTargetRulesConfig NoClangLinker(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-NoClangLinker",
                    Value: null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (WindowsTargetRulesConfig) this;
        }

    
/// <summary>
/// Enables enforcing standard C++ ODR violations (/Zc:checkGwOdr) in VS2022 17.5 Preview 2.0+
/// </summary>
        public virtual WindowsTargetRulesConfig StrictODR(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-StrictODR",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (WindowsTargetRulesConfig) this;
        }

    
/// <summary>
/// If you supply -NoDebugInfo, windows platforms still create debug info while linking. Set this to true to not create debug info while linking in this circumstance
/// </summary>
        public virtual WindowsTargetRulesConfig NoLinkerDebugInfo(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-NoLinkerDebugInfo",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (WindowsTargetRulesConfig) this;
        }

    
/// <summary>
/// If specificed Visual Studio Dynamic Debugging support will be enabled, unless the compiler or linker is not MSVC or LTCG is enabled
/// </summary>
        public virtual WindowsTargetRulesConfig DynamicDebugging(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-DynamicDebugging",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (WindowsTargetRulesConfig) this;
        }

    
/// <summary>
/// True if we should use the Rad linker
/// </summary>
        public virtual WindowsTargetRulesConfig RadLinker(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-RadLinker",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (WindowsTargetRulesConfig) this;
        }

    
/// <summary>
/// Enables undefined behavior sanitizer (UBSan)
/// </summary>
        public virtual WindowsTargetRulesConfig EnableUBSan(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-EnableUBSan",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (WindowsTargetRulesConfig) this;
        }

    
/// <summary>
/// Enables instrumentation.
/// </summary>
        public virtual WindowsTargetRulesConfig EnableInstrumentation(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-EnableInstrumentation",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (WindowsTargetRulesConfig) this;
        }
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    }

    protected readonly WindowsTargetRulesConfig WindowsTargetRulesStorage = new();
    
/// <summary></summary>
    public  class RiderProjectFileGeneratorConfig : ToolConfig
    {
        public override string Name => "RiderProjectFileGenerator";
        public override string CliName => "";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest;
    
/// <summary>
/// Platforms to generate project files for
/// </summary>
        public virtual RiderProjectFileGeneratorConfig Platforms(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Platforms",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: true
                    )
                ));
            }
            return (RiderProjectFileGeneratorConfig) this;
        }

    
/// <summary>
/// Target types to generate project files for
/// </summary>
        public virtual RiderProjectFileGeneratorConfig TargetTypes(params TargetType[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-TargetTypes",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: true
                    )
                ));
            }
            return (RiderProjectFileGeneratorConfig) this;
        }

    
/// <summary>
/// Target configurations to generate project files for
/// </summary>
        public virtual RiderProjectFileGeneratorConfig TargetConfigurations(params UnrealTargetConfiguration[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-TargetConfigurations",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: true
                    )
                ));
            }
            return (RiderProjectFileGeneratorConfig) this;
        }

    
/// <summary>
/// Projects to generate project files for
/// </summary>
        public virtual RiderProjectFileGeneratorConfig ProjectNames(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-ProjectNames",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: true
                    )
                ));
            }
            return (RiderProjectFileGeneratorConfig) this;
        }

    
/// <summary>
/// Should format JSON files in human readable form, or use packed one without indents
/// </summary>
        public virtual RiderProjectFileGeneratorConfig Minimize(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Minimize",
                    Value: null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (RiderProjectFileGeneratorConfig) this;
        }

    
/// <summary>
/// When specified only primary project file (root.json) will be generated.
/// Normally project files for specific configurations are generated together with primary project file.
/// </summary>
        public virtual RiderProjectFileGeneratorConfig OnlyPrimaryProjectFile(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-OnlyPrimaryProjectFile",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (RiderProjectFileGeneratorConfig) this;
        }
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    }

    protected readonly RiderProjectFileGeneratorConfig RiderProjectFileGeneratorStorage = new();
    
/// <summary>
/// Outputs information about the given target, including a module dependecy graph (in .gefx format and list of module references)
/// </summary>
    public  class AnalyzeConfig : ToolConfig
    {
        public override string Name => "Analyze";
        public override string CliName => "-Analyze";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest;
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    }

    protected readonly AnalyzeConfig AnalyzeStorage = new();
    
/// <summary>
/// Aggregates clang timing information files together into one monolithic breakdown file.
/// </summary>
    public  class AggregateClangTimingInfoConfig : ToolConfig
    {
        public override string Name => "AggregateClangTimingInfo";
        public override string CliName => "-AggregateClangTimingInfo";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest;
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    }

    protected readonly AggregateClangTimingInfoConfig AggregateClangTimingInfoStorage = new();
    
/// <summary>
/// Fixes the include paths found in a header and source file
/// </summary>
    public  class FixIncludePathsConfig : ToolConfig
    {
        public override string Name => "FixIncludePaths";
        public override string CliName => "-FixIncludePaths";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest;
    
/// <summary>Set of filters for files to include in the database. Relative to the root directory, or to the project file.</summary>
        public virtual FixIncludePathsConfig Filter(params object[] values)
        {
            if (true)
            {
                if (values != null)
                    foreach (var val in values)
                    {
                        AppendArgument(new UnrealToolArgument(
                            "-Filter",
                            Value: val.ToString(),
                            Setter: '=',
                            Meta: new(
                                Compatibility: UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                                AllowMultiple: true
                            )
                        ));
                    }
            }
            return (FixIncludePathsConfig) this;
        }

    
/// <summary>Flags that this task should use p4 to check out the file before updating it.</summary>
        public virtual FixIncludePathsConfig CheckoutWithP4(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-CheckoutWithP4",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (FixIncludePathsConfig) this;
        }

    
/// <summary>Flags that the updated files shouldn't be saved.</summary>
        public virtual FixIncludePathsConfig NoOutput(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-NoOutput",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (FixIncludePathsConfig) this;
        }

    
/// <summary>Flags that includes should not be sorted.</summary>
        public virtual FixIncludePathsConfig NoIncludeSorting(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-NoIncludeSorting",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (FixIncludePathsConfig) this;
        }

    
/// <summary>Set of filters for #include'd lines to allow updating. Relative to the root directory, or to the project file.</summary>
        public virtual FixIncludePathsConfig IncludeFilter(params object[] values)
        {
            if (true)
            {
                if (values != null)
                    foreach (var val in values)
                    {
                        AppendArgument(new UnrealToolArgument(
                            "-IncludeFilter",
                            Value: val.ToString(),
                            Setter: '=',
                            Meta: new(
                                Compatibility: UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                                AllowMultiple: true
                            )
                        ));
                    }
            }
            return (FixIncludePathsConfig) this;
        }

    
/// <summary>Forces updating and sorting the includes.</summary>
        public virtual FixIncludePathsConfig ForceUpdate(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-ForceUpdate",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (FixIncludePathsConfig) this;
        }
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    }

    protected readonly FixIncludePathsConfig FixIncludePathsStorage = new();
    
/// <summary>
/// Generate a clang compile_commands file for a target
/// </summary>
    public  class InlineGeneratedCppsConfig : ToolConfig
    {
        public override string Name => "InlineGeneratedCpps";
        public override string CliName => "-InlineGeneratedCpps";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest;
    
/// <summary>Set of filters for files to include in the database. Relative to the root directory, or to the project file.</summary>
        public virtual InlineGeneratedCppsConfig Filter(params object[] values)
        {
            if (true)
            {
                if (values != null)
                    foreach (var val in values)
                    {
                        AppendArgument(new UnrealToolArgument(
                            "-Filter",
                            Value: val.ToString(),
                            Setter: '=',
                            Meta: new(
                                Compatibility: UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                                AllowMultiple: true
                            )
                        ));
                    }
            }
            return (InlineGeneratedCppsConfig) this;
        }

    
/// <summary>Flags that this task should use p4 to check out the file before updating it.</summary>
        public virtual InlineGeneratedCppsConfig CheckoutWithP4(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-CheckoutWithP4",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (InlineGeneratedCppsConfig) this;
        }

    
/// <summary>Flags that the updated files shouldn't be saved.</summary>
        public virtual InlineGeneratedCppsConfig NoOutput(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-NoOutput",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (InlineGeneratedCppsConfig) this;
        }
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    }

    protected readonly InlineGeneratedCppsConfig InlineGeneratedCppsStorage = new();
    
/// <summary>
/// Generate a clang compile_commands file for a target
/// </summary>
    public  class PrintBuildGraphInfoConfig : ToolConfig
    {
        public override string Name => "PrintBuildGraphInfo";
        public override string CliName => "-PrintBuildGraphInfo";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest;
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    }

    protected readonly PrintBuildGraphInfoConfig PrintBuildGraphInfoStorage = new();
    
/// <summary>
/// Builds low level tests on one or more targets.
/// </summary>
    public  class TestConfig : ToolConfig
    {
        public override string Name => "Test";
        public override string CliName => "-Test";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest;
    
/// <summary>
/// Whether we're building implicit tests (default is explicit)
/// </summary>
        public virtual TestConfig Implicit(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Implicit",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (TestConfig) this;
        }

    
/// <summary>
/// Whether we're cleaning tests instead of just building
/// </summary>
        public virtual TestConfig CleanTests(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-CleanTests",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (TestConfig) this;
        }

    
/// <summary>
/// Whether we're rebuilding tests instead of just building
/// </summary>
        public virtual TestConfig RebuildTests(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-RebuildTests",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (TestConfig) this;
        }

    
/// <summary>
/// Updates tests' build graph metadata files for explicit tests
/// </summary>
        public virtual TestConfig GenerateMetadata(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-GenerateMetadata",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (TestConfig) this;
        }

    
/// <summary>
/// Specific project file to run tests on or update test metadata
/// </summary>
        public virtual TestConfig Project(object val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Project",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (TestConfig) this;
        }
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    }

    protected readonly TestConfig TestStorage = new();
    
/// <summary>
/// Global options for UBT (any modes)
/// </summary>
    public  class UhtGlobalOptionsConfig : ToolConfig
    {
        public override string Name => "UhtGlobalOptions";
        public override string CliName => "";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest;
    
/// <summary>The amount of detail to write to the log
/// Increase output verbosity</summary>
        public virtual UhtGlobalOptionsConfig Verbose(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Verbose",
                    Value: null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UhtGlobalOptionsConfig) this;
        }

    
/// <summary>The amount of detail to write to the log
/// Increase output verbosity more</summary>
        public virtual UhtGlobalOptionsConfig VeryVerbose(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-VeryVerbose",
                    Value: null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UhtGlobalOptionsConfig) this;
        }

    
/// <summary>Specifies the path to a log file to write. Note that the default mode (eg. building, generating project files) will create a log file by default if this not specified.
/// Specify a log file location instead of the default Engine/Programs/UnrealHeaderTool/Saved/Logs/UnrealHeaderTool.log</summary>
        public virtual UhtGlobalOptionsConfig Log(object val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Log",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UhtGlobalOptionsConfig) this;
        }

    
/// <summary>Whether to include timestamps in the log
/// Include timestamps in the log</summary>
        public virtual UhtGlobalOptionsConfig Timestamps(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Timestamps",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UhtGlobalOptionsConfig) this;
        }

    
/// <summary>Whether to format messages in MsBuild format
/// Format messages for msbuild</summary>
        public virtual UhtGlobalOptionsConfig FromMsBuild(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-FromMsBuild",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UhtGlobalOptionsConfig) this;
        }

    
/// <summary>Disables all logging including the default log location
/// Disable log file creation including the default log file</summary>
        public virtual UhtGlobalOptionsConfig NoLog(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-NoLog",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UhtGlobalOptionsConfig) this;
        }

    
/// <summary>Run testing scripts</summary>
        public virtual UhtGlobalOptionsConfig Test(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Test",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UhtGlobalOptionsConfig) this;
        }

    
/// <summary>Treat warnings as errors</summary>
        public virtual UhtGlobalOptionsConfig WarningsAsErrors(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-WarningsAsErrors",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UhtGlobalOptionsConfig) this;
        }

    
/// <summary>Disable concurrent parsing and code generation</summary>
        public virtual UhtGlobalOptionsConfig NoGoWide(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-NoGoWide",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UhtGlobalOptionsConfig) this;
        }

    
/// <summary>Write all the output to a reference directory</summary>
        public virtual UhtGlobalOptionsConfig WriteRef(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-WriteRef",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UhtGlobalOptionsConfig) this;
        }

    
/// <summary>Write all the output to a verification directory and compare to the reference output</summary>
        public virtual UhtGlobalOptionsConfig VerifyRef(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-VerifyRef",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UhtGlobalOptionsConfig) this;
        }

    
/// <summary>Consider any changes to output files as being an error</summary>
        public virtual UhtGlobalOptionsConfig FailIfGeneratedCodeChanges(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-FailIfGeneratedCodeChanges",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UhtGlobalOptionsConfig) this;
        }

    
/// <summary>Do not save any output files other than reference output</summary>
        public virtual UhtGlobalOptionsConfig NoOutput(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-NoOutput",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UhtGlobalOptionsConfig) this;
        }

    
/// <summary>Include extra content in generated output to assist with debugging</summary>
        public virtual UhtGlobalOptionsConfig IncludeDebugOutput(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-IncludeDebugOutput",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UhtGlobalOptionsConfig) this;
        }

    
/// <summary>Disable all default exporters.  Useful for when a specific exporter is to be run</summary>
        public virtual UhtGlobalOptionsConfig NoDefaultExporters(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-NoDefaultExporters",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UhtGlobalOptionsConfig) this;
        }
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    }

    protected readonly UhtGlobalOptionsConfig UhtGlobalOptionsStorage = new();
    
/// <summary>
/// Invoke UHT
/// </summary>
    public  class UnrealHeaderToolConfig : ToolConfig
    {
        public override string Name => "UnrealHeaderTool";
        public override string CliName => "-UnrealHeaderTool";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest;
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    }

    protected readonly UnrealHeaderToolConfig UnrealHeaderToolStorage = new();
    
/// <summary>
/// Profiles different unity sizes and prints out the different size and its timings
/// </summary>
    public  class IWYUConfig : ToolConfig
    {
        public override string Name => "IWYU";
        public override string CliName => "-IWYU";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest;
    
/// <summary>
/// Will check out files from p4 and write to disk
/// </summary>
        public virtual IWYUConfig Write(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Write",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (IWYUConfig) this;
        }

    
/// <summary>
/// Update only includes in cpp files and don't touch headers
/// </summary>
        public virtual IWYUConfig UpdateOnlyPrivate(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-UpdateOnlyPrivate",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (IWYUConfig) this;
        }

    
/// <summary>
/// Which module to run IWYU on. Will also include all modules depending on this module
/// </summary>
        public virtual IWYUConfig ModuleToUpdate(object val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-ModuleToUpdate",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (IWYUConfig) this;
        }

    
/// <summary>
/// Which directory to run IWYU on. Will search for modules that has module directory matching this string
/// If no module is found in -PathToUpdate it handles this for individual files instead.
/// Note this can be combined with -ModuleToUpdate to double filter
/// PathToUpdate supports multiple paths using semi colon separation
/// </summary>
        public virtual IWYUConfig PathToUpdate(object val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-PathToUpdate",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (IWYUConfig) this;
        }

    
/// <summary>
/// Same as PathToUpdate but provide the list of paths in a text file instead.
/// Add all the desired paths on a separate line
/// </summary>
        public virtual IWYUConfig PathToUpdateFile(object val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-PathToUpdateFile",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (IWYUConfig) this;
        }

    
/// <summary>
/// Also update modules that are depending on the module we are updating
/// </summary>
        public virtual IWYUConfig UpdateDependents(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-UpdateDependents",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (IWYUConfig) this;
        }

    
/// <summary>
/// Will check out files from p4 and write to disk
/// </summary>
        public virtual IWYUConfig NoP4(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-NoP4",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (IWYUConfig) this;
        }

    
/// <summary>
/// Allow files to not add includes if they are transitively included by other includes
/// </summary>
        public virtual IWYUConfig NoTransitiveIncludes(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-NoTransitiveIncludes",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_2,
                        AllowMultiple: false
                    )
                ));
            }
            return (IWYUConfig) this;
        }

    
/// <summary>
/// Will skip compiling before updating. Handle with care, this is dangerous since files might not match .iwyu files
/// </summary>
        public virtual IWYUConfig NoCompile(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-NoCompile",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (IWYUConfig) this;
        }

    
/// <summary>
/// Will ignore update check that .iwyu is newer than source files.
/// </summary>
        public virtual IWYUConfig IgnoreUpToDateCheck(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-IgnoreUpToDateCheck",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (IWYUConfig) this;
        }

    
/// <summary>
/// If set, this will keep removed includes in #if/#endif scope at the end of updated file.
/// Applied to non-private headers that are part of the Engine folder.
/// </summary>
        public virtual IWYUConfig DeprecateTag(object val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-DeprecateTag",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (IWYUConfig) this;
        }

    
/// <summary>
/// Allow files to not add includes if they are transitively included by other includes
/// </summary>
        public virtual IWYUConfig NoTransitive(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-NoTransitive",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (IWYUConfig) this;
        }

    
/// <summary>
/// Will remove headers that are needed but redundant because they are included through other needed includes
/// </summary>
        public virtual IWYUConfig RemoveRedundant(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-RemoveRedundant",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (IWYUConfig) this;
        }

    
/// <summary>
/// Compare current include structure with how it would look like if iwyu was applied on all files
/// </summary>
        public virtual IWYUConfig Compare(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Compare",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (IWYUConfig) this;
        }

    
/// <summary>
/// For Development only - Will write a toc referencing all .iwyu files. Toc can be used by -ReadToc
/// </summary>
        public virtual IWYUConfig WriteToc(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-WriteToc",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (IWYUConfig) this;
        }

    
/// <summary>
/// For Development only - Will read a toc to find all .iwyu files instead of building the code.
/// </summary>
        public virtual IWYUConfig ReadToc(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-ReadToc",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (IWYUConfig) this;
        }
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    }

    protected readonly IWYUConfig IWYUStorage = new();
    
/// <summary>
/// Profiles different unity sizes and prints out the different size and its timings
/// </summary>
    public  class ProfileUnitySizesConfig : ToolConfig
    {
        public override string Name => "ProfileUnitySizes";
        public override string CliName => "-ProfileUnitySizes";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest;
    
/// <summary>
/// Set of filters for files to include in the database. Relative to the root directory, or to the project file.
/// </summary>
        public virtual ProfileUnitySizesConfig Filter(params object[] values)
        {
            if (true)
            {
                if (values != null)
                    foreach (var val in values)
                    {
                        AppendArgument(new UnrealToolArgument(
                            "-Filter",
                            Value: val.ToString(),
                            Setter: '=',
                            Meta: new(
                                Compatibility: UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                                AllowMultiple: true
                            )
                        ));
                    }
            }
            return (ProfileUnitySizesConfig) this;
        }
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    }

    protected readonly ProfileUnitySizesConfig ProfileUnitySizesStorage = new();
    
    
    public  class ServerConfig : ToolConfig
    {
        public override string Name => "Server";
        public override string CliName => "-Server";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest;
    
    
        public virtual ServerConfig LogDirectory(object val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-LogDirectory",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (ServerConfig) this;
        }
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    }

    protected readonly ServerConfig ServerStorage = new();
    
/// <summary></summary>
    public  class VSCodeProjectFileGeneratorConfig : ToolConfig
    {
        public override string Name => "VSCodeProjectFileGenerator";
        public override string CliName => "";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest;
    
/// <summary>
/// Do not create compile commands json files with compiler arguments for each file; works better with VS Code extension using
/// UBT server mode.
/// </summary>
        public virtual VSCodeProjectFileGeneratorConfig NoCompileCommands(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-NoCompileCommands",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (VSCodeProjectFileGeneratorConfig) this;
        }

    
/// <summary>
/// Create a workspace file for use with VS Code extension that communicates directly with UBT.
/// </summary>
        public virtual VSCodeProjectFileGeneratorConfig UseVSCodeExtension(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-UseVSCodeExtension",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (VSCodeProjectFileGeneratorConfig) this;
        }
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    }

    protected readonly VSCodeProjectFileGeneratorConfig VSCodeProjectFileGeneratorStorage = new();
    
    
    public  class ClReproConfig : ToolConfig
    {
        public override string Name => "ClRepro";
        public override string CliName => "-ClRepro";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest;
    
/// <summary>REQUIRED!</summary>
        public virtual ClReproConfig InputCpp(object val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-InputCpp",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (ClReproConfig) this;
        }

    
/// <summary>REQUIRED!</summary>
        public virtual ClReproConfig OutputDir(object val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-OutputDir",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (ClReproConfig) this;
        }
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    }

    protected readonly ClReproConfig ClReproStorage = new();
    
    
    public  class QueryConfig : ToolConfig
    {
        public override string Name => "Query";
        public override string CliName => "-Query";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest;
    
    
        public virtual QueryConfig LogDirectory(object val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-LogDirectory",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (QueryConfig) this;
        }

    
    
        public virtual QueryConfig Query(QueryType? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Query",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (QueryConfig) this;
        }

    
    
        public virtual QueryConfig IncludeEngineSource(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-IncludeEngineSource",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (QueryConfig) this;
        }

    
    
        public virtual QueryConfig Target(object val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Target",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (QueryConfig) this;
        }

    
    
        public virtual QueryConfig Configuration(object val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Configuration",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (QueryConfig) this;
        }

    
    
        public virtual QueryConfig Platform(object val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Platform",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (QueryConfig) this;
        }

    
    
        public virtual QueryConfig Indented(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Indented",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (QueryConfig) this;
        }

    
    
        public virtual QueryConfig OutputPath(object val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-OutputPath",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (QueryConfig) this;
        }

    
    
        public virtual QueryConfig LoadTargets(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-LoadTargets",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (QueryConfig) this;
        }

    
    
        public virtual QueryConfig NoIntellisense(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-NoIntellisense",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (QueryConfig) this;
        }
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    }

    protected readonly QueryConfig QueryStorage = new();
    
    
    public  class ApplePostBuildSyncConfig : ToolConfig
    {
        public override string Name => "ApplePostBuildSync";
        public override string CliName => "-ApplePostBuildSync";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest;
    
/// <summary>REQUIRED!</summary>
        public virtual ApplePostBuildSyncConfig Input(object val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Input",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (ApplePostBuildSyncConfig) this;
        }

    
    
        public virtual ApplePostBuildSyncConfig XmlConfigCache(object val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-XmlConfigCache",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (ApplePostBuildSyncConfig) this;
        }

    
    
        public virtual ApplePostBuildSyncConfig ModernXcode(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-ModernXcode",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_3 | UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (ApplePostBuildSyncConfig) this;
        }

    
    
        public virtual ApplePostBuildSyncConfig NoEntitlements(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-noEntitlements",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (ApplePostBuildSyncConfig) this;
        }
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    }

    protected readonly ApplePostBuildSyncConfig ApplePostBuildSyncStorage = new();
    
/// <summary>
/// Helper class to manage the action queue
/// 
/// Running the queue can be done with a mixture of automatic and manual runners. Runners are responsible for performing
/// the work associated with an action. Automatic runners will have actions automatically queued to them up to the point
/// that any runtime limits aren't exceeded (such as maximum number of concurrent processes).  Manual runners must have
/// jobs queued to them by calling TryStartOneAction or StartManyActions with the runner specified.
/// 
/// For example:
/// 
/// ParallelExecutor uses an automatic runner exclusively.
/// UBAExecutor uses an automatic runner to run jobs locally and a manual runner to run jobs remotely as processes
/// become available.
/// </summary>
    public  class ImmediateActionQueueConfig : ToolConfig
    {
        public override string Name => "ImmediateActionQueue";
        public override string CliName => "";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest;
    
/// <summary>
/// Number of second of no completed actions to trigger an action stall report.
/// If zero, stall reports will not be enabled.
/// </summary>
        public virtual ImmediateActionQueueConfig ActionStallReportTime(double? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-ActionStallReportTime",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (ImmediateActionQueueConfig) this;
        }

    
/// <summary>
/// Number of second of no completed actions to trigger to terminate the queue.
/// If zero, force termination not be enabled.
/// </summary>
        public virtual ImmediateActionQueueConfig ActionStallTerminateTime(double? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-ActionStallTerminateTime",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (ImmediateActionQueueConfig) this;
        }
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    }

    protected readonly ImmediateActionQueueConfig ImmediateActionQueueStorage = new();
    
/// <summary>
/// Configuration for Unreal Build Accelerator
/// </summary>
    public  class UnrealBuildAcceleratorConfigConfig : ToolConfig
    {
        public override string Name => "UnrealBuildAcceleratorConfig";
        public override string CliName => "";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest;
    
/// <summary>
/// When set to true, UBA will not use any remote help
/// </summary>
        public virtual UnrealBuildAcceleratorConfigConfig UBADisableRemote(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-UBADisableRemote",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UnrealBuildAcceleratorConfigConfig) this;
        }

    
/// <summary>
/// When set to true, UBA will force all actions that can be built remotely to be built remotely. This will hang if there are no remote agents available
/// </summary>
        public virtual UnrealBuildAcceleratorConfigConfig UBAForceRemote(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-UBAForceRemote",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UnrealBuildAcceleratorConfigConfig) this;
        }

    
/// <summary>When set to true, actions that fail locally with UBA will be retried without UBA.
/// When set to true, all actions that fail locally with UBA will be retried without UBA.</summary>
        public virtual UnrealBuildAcceleratorConfigConfig UBAForcedRetry(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-UBAForcedRetry",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UnrealBuildAcceleratorConfigConfig) this;
        }

    
/// <summary>
/// When set to true, all errors and warnings from UBA will be output at the appropriate severity level to the log (rather than being output as 'information' and attempting to continue regardless).
/// </summary>
        public virtual UnrealBuildAcceleratorConfigConfig UBAStrict(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-UBAStrict",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UnrealBuildAcceleratorConfigConfig) this;
        }

    
/// <summary>
/// If UBA should store cas compressed or raw
/// </summary>
        public virtual UnrealBuildAcceleratorConfigConfig UBAStoreRaw(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-UBAStoreRaw",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UnrealBuildAcceleratorConfigConfig) this;
        }

    
/// <summary>
/// If UBA should distribute linking to remote workers. This needs bandwidth but can be an optimization
/// </summary>
        public virtual UnrealBuildAcceleratorConfigConfig UBALinkRemote(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-UBALinkRemote",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UnrealBuildAcceleratorConfigConfig) this;
        }

    
/// <summary>
/// The amount of gigabytes UBA is allowed to use to store workset and cached data. It is a good idea to have this &gt;10gb
/// </summary>
        public virtual UnrealBuildAcceleratorConfigConfig UBAStoreCapacityGb(double? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-UBAStoreCapacityGb",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UnrealBuildAcceleratorConfigConfig) this;
        }

    
/// <summary>
/// Max number of worker threads that can handle messages from remotes.
/// </summary>
        public virtual UnrealBuildAcceleratorConfigConfig UBAMaxWorkers(double? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-UBAMaxWorkers",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UnrealBuildAcceleratorConfigConfig) this;
        }

    
/// <summary>
/// Max size of each message sent from server to client
/// </summary>
        public virtual UnrealBuildAcceleratorConfigConfig UBASendSize(double? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-UBASendSize",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UnrealBuildAcceleratorConfigConfig) this;
        }

    
/// <summary>
/// Which ip UBA server should listen to for connections
/// </summary>
        public virtual UnrealBuildAcceleratorConfigConfig UBAHost(object val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-UBAHost",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UnrealBuildAcceleratorConfigConfig) this;
        }

    
/// <summary>
/// Which port UBA server should listen to for connections.
/// </summary>
        public virtual UnrealBuildAcceleratorConfigConfig UBAPort(double? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-UBAPort",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UnrealBuildAcceleratorConfigConfig) this;
        }

    
/// <summary>
/// Which directory to store files for UBA.
/// </summary>
        public virtual UnrealBuildAcceleratorConfigConfig UBARootDir(object val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-UBARootDir",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UnrealBuildAcceleratorConfigConfig) this;
        }

    
/// <summary>
/// Use Quic protocol instead of Tcp (experimental)
/// </summary>
        public virtual UnrealBuildAcceleratorConfigConfig UBAQuic(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-UBAQuic",
                    Value: null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UnrealBuildAcceleratorConfigConfig) this;
        }

    
/// <summary>
/// Enable logging of UBA processes
/// </summary>
        public virtual UnrealBuildAcceleratorConfigConfig UBALog(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-UBALog",
                    Value: null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UnrealBuildAcceleratorConfigConfig) this;
        }

    
/// <summary>
/// Prints summary of UBA stats at end of build
/// </summary>
        public virtual UnrealBuildAcceleratorConfigConfig UBAPrintSummary(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-UBAPrintSummary",
                    Value: null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UnrealBuildAcceleratorConfigConfig) this;
        }

    
/// <summary>
/// Launch visualizer application which shows build progress
/// </summary>
        public virtual UnrealBuildAcceleratorConfigConfig UBAVisualizer(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-UBAVisualizer",
                    Value: null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UnrealBuildAcceleratorConfigConfig) this;
        }

    
/// <summary>
/// Resets the cas cache
/// </summary>
        public virtual UnrealBuildAcceleratorConfigConfig UBAResetCas(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-UBAResetCas",
                    Value: null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UnrealBuildAcceleratorConfigConfig) this;
        }

    
/// <summary>
/// Provide custom path for trace output file
/// </summary>
        public virtual UnrealBuildAcceleratorConfigConfig UBATraceOutputFile(object val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-UBATraceOutputFile",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UnrealBuildAcceleratorConfigConfig) this;
        }

    
/// <summary>
/// Add verbose details to the UBA trace
/// </summary>
        public virtual UnrealBuildAcceleratorConfigConfig UBADetailedTrace(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-UBADetailedTrace",
                    Value: null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UnrealBuildAcceleratorConfigConfig) this;
        }

    
/// <summary>
/// Disable UBA waiting on available memory before spawning new processes
/// </summary>
        public virtual UnrealBuildAcceleratorConfigConfig UBADisableWaitOnMem(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-UBADisableWaitOnMem",
                    Value: null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UnrealBuildAcceleratorConfigConfig) this;
        }

    
/// <summary>
/// Let UBA kill running processes when close to out of memory
/// </summary>
        public virtual UnrealBuildAcceleratorConfigConfig UBAAllowKillOnMem(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-UBAAllowKillOnMem",
                    Value: null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UnrealBuildAcceleratorConfigConfig) this;
        }

    
/// <summary>
/// Threshold for when executor should output logging for the process. Defaults to never
/// </summary>
        public virtual UnrealBuildAcceleratorConfigConfig UBAOutputStatsThresholdMs(double? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-UBAOutputStatsThresholdMs",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5,
                        AllowMultiple: false
                    )
                ));
            }
            return (UnrealBuildAcceleratorConfigConfig) this;
        }

    
/// <summary>
/// Skip writing intermediate and output files to disk. Useful for validation builds where we don't need the output
/// </summary>
        public virtual UnrealBuildAcceleratorConfigConfig UBANoWrite(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-UBANoWrite",
                    Value: null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UnrealBuildAcceleratorConfigConfig) this;
        }

    
/// <summary>
/// Set to true to disable mimalloc and detouring of memory allocations.
/// </summary>
        public virtual UnrealBuildAcceleratorConfigConfig UBANoCustomMalloc(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-UBANoCustomMalloc",
                    Value: null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UnrealBuildAcceleratorConfigConfig) this;
        }

    
/// <summary>
/// The zone to use for UBA.
/// </summary>
        public virtual UnrealBuildAcceleratorConfigConfig UBAZone(object val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-UBAZone",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UnrealBuildAcceleratorConfigConfig) this;
        }

    
/// <summary>
/// Set to true to enable encryption when transferring files over the network.
/// </summary>
        public virtual UnrealBuildAcceleratorConfigConfig UBACrypto(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-UBACrypto",
                    Value: null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UnrealBuildAcceleratorConfigConfig) this;
        }

    
/// <summary>
/// Set to true to provide known inputs to processes that are run remote. This is an experimental feature to speed up build times when ping is higher
/// </summary>
        public virtual UnrealBuildAcceleratorConfigConfig UBAUseKnownInputs(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-UBAUseKnownInputs",
                    Value: null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UnrealBuildAcceleratorConfigConfig) this;
        }

    
/// <summary>
/// Write yaml file with all actions that are queued for build. This can be used to replay using "UbaCli.exe local file.yaml"
/// </summary>
        public virtual UnrealBuildAcceleratorConfigConfig UBAActionsOutputFile(object val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-UBAActionsOutputFile",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UnrealBuildAcceleratorConfigConfig) this;
        }

    
/// <summary>
/// Set to true to see more info about what is happening inside uba and also log output from agents
/// </summary>
        public virtual UnrealBuildAcceleratorConfigConfig UBADetailedLog(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-UBADetailedLog",
                    Value: null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UnrealBuildAcceleratorConfigConfig) this;
        }

    
/// <summary>
/// When set to true, actions that fail remotely with UBA will be retried locally with UBA.
/// </summary>
        public virtual UnrealBuildAcceleratorConfigConfig UBAForcedRetryRemote(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-UBAForcedRetryRemote",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UnrealBuildAcceleratorConfigConfig) this;
        }

    
/// <summary>
/// Store object (.obj) compressed on disk. Requires uba to do link step where it will decompress obj files again
/// </summary>
        public virtual UnrealBuildAcceleratorConfigConfig UBAStoreObjFilesCompressed(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-UBAStoreObjFilesCompressed",
                    Value: null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UnrealBuildAcceleratorConfigConfig) this;
        }

    
/// <summary>
/// Address of the uba cache service. Will automatically use cache if connected
/// </summary>
        public virtual UnrealBuildAcceleratorConfigConfig UBACache(object val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-UBACache",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UnrealBuildAcceleratorConfigConfig) this;
        }

    
/// <summary>Set cache to write instead of fetch
/// Set cache to write, expects one of [True, False, BuildMachineOnly]</summary>
        public virtual UnrealBuildAcceleratorConfigConfig UBAWriteCache(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-UBAWriteCache",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UnrealBuildAcceleratorConfigConfig) this;
        }

    
/// <summary>
/// Max number of cache download tasks that can execute in parallel
/// </summary>
        public virtual UnrealBuildAcceleratorConfigConfig UBACacheMaxWorkers(double? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-UBACacheMaxWorkers",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UnrealBuildAcceleratorConfigConfig) this;
        }

    
/// <summary>
/// Report reason a cache miss happened. Useful when searching for determinism/portability issues
/// </summary>
        public virtual UnrealBuildAcceleratorConfigConfig UBAReportCacheMissReason(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-UBAReportCacheMissReason",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UnrealBuildAcceleratorConfigConfig) this;
        }

    
/// <summary>
/// List of provider names for remote connections from ini
/// It is recommended to set Providers in ini so the setting can be shared with the uba controller in editor, such as
/// Windows:	%ProgramData%/Epic/Unreal Engine/Engine/Config/SystemEngine.ini
/// Mac:		~/Library/Application Support/Epic/Unreal Engine/Engine/Config/SystemEngine.ini
/// Linux:		~/.config/Epic/Unreal Engine/Engine/Config/SystemEngine.ini
/// </summary>
        public virtual UnrealBuildAcceleratorConfigConfig UBAProviders(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-UBAProviders",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: true
                    )
                ));
            }
            return (UnrealBuildAcceleratorConfigConfig) this;
        }

    
/// <summary>
/// List of provider names for remote cache from ini
/// </summary>
        public virtual UnrealBuildAcceleratorConfigConfig UBACacheProviders(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-UBACacheProviders",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: true
                    )
                ));
            }
            return (UnrealBuildAcceleratorConfigConfig) this;
        }

    
/// <summary>
/// When set to true, actions that fail locally with certain error codes will retry without uba.
/// </summary>
        public virtual UnrealBuildAcceleratorConfigConfig UBANoRetry(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-UBANoRetry",
                    Value: null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UnrealBuildAcceleratorConfigConfig) this;
        }

    
/// <summary>
/// Store object (.obj) compressed on disk. Requires uba to do link step where it will decompress obj files again
/// </summary>
        public virtual UnrealBuildAcceleratorConfigConfig UBADisableStoreObjFilesCompressed(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-UBADisableStoreObjFilesCompressed",
                    Value: null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UnrealBuildAcceleratorConfigConfig) this;
        }

    
/// <summary>
/// Disable all detouring making all actions run outside uba
/// </summary>
        public virtual UnrealBuildAcceleratorConfigConfig UBANoDetour(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-UBANoDetour",
                    Value: null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UnrealBuildAcceleratorConfigConfig) this;
        }

    
/// <summary>
/// Shuffle the list of cache servers before each read attempt
/// </summary>
        public virtual UnrealBuildAcceleratorConfigConfig UBAShuffleCache(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-UBAShuffleCache",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UnrealBuildAcceleratorConfigConfig) this;
        }

    
/// <summary>
/// Compression level. Options are None, SuperFast, VeryFast, Fast, Normal, Optimal1 to Optimal5
/// </summary>
        public virtual UnrealBuildAcceleratorConfigConfig UBACompressionLevel(object val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-UBACompressionLevel",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UnrealBuildAcceleratorConfigConfig) this;
        }
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    }

    protected readonly UnrealBuildAcceleratorConfigConfig UnrealBuildAcceleratorConfigStorage = new();
    
/// <summary>
/// Configuration for Unreal Build Accelerator Horde session
/// </summary>
    public  class UnrealBuildAcceleratorHordeConfigConfig : ToolConfig
    {
        public override string Name => "UnrealBuildAcceleratorHordeConfig";
        public override string CliName => "";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest;
    
/// <summary>
/// Uri of the Horde server
/// </summary>
        public virtual UnrealBuildAcceleratorHordeConfigConfig UBAHorde(object val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-UBAHorde",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UnrealBuildAcceleratorHordeConfigConfig) this;
        }

    
/// <summary>Uri of the Horde server
/// Auth token for the Horde server</summary>
        public virtual UnrealBuildAcceleratorHordeConfigConfig UBAHordeToken(object val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-UBAHordeToken",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UnrealBuildAcceleratorHordeConfigConfig) this;
        }

    
/// <summary>
/// OIDC id for the login to use
/// </summary>
        public virtual UnrealBuildAcceleratorHordeConfigConfig UBAHordeOidc(object val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-UBAHordeOidc",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UnrealBuildAcceleratorHordeConfigConfig) this;
        }

    
/// <summary>
/// Pool for the Horde agent to assign, only used for commandline override
/// </summary>
        public virtual UnrealBuildAcceleratorHordeConfigConfig UBAHordePool(object val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-UBAHordePool",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UnrealBuildAcceleratorHordeConfigConfig) this;
        }

    
/// <summary>
/// Requirements for the Horde agent to assign
/// </summary>
        public virtual UnrealBuildAcceleratorHordeConfigConfig UBAHordeRequirements(object val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-UBAHordeRequirements",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UnrealBuildAcceleratorHordeConfigConfig) this;
        }

    
/// <summary>
/// Which ip UBA server should give to agents. This will invert so host listens and agents connect
/// </summary>
        public virtual UnrealBuildAcceleratorHordeConfigConfig UBAHordeHost(object val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-UBAHordeHost",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UnrealBuildAcceleratorHordeConfigConfig) this;
        }

    
/// <summary>
/// Max cores allowed to be used by build session
/// </summary>
        public virtual UnrealBuildAcceleratorHordeConfigConfig UBAHordeMaxCores(double? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-UBAHordeMaxCores",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UnrealBuildAcceleratorHordeConfigConfig) this;
        }

    
/// <summary>
/// How long UBT should wait to ask for help. Useful in build configs where machine can delay remote work and still get same wall time results (pch dependencies etc)
/// </summary>
        public virtual UnrealBuildAcceleratorHordeConfigConfig UBAHordeDelay(double? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-UBAHordeDelay",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UnrealBuildAcceleratorHordeConfigConfig) this;
        }

    
/// <summary>
/// Allow use of Wine. Only applicable to Horde agents running Linux. Can still be ignored if Wine executable is not set on agent.
/// </summary>
        public virtual UnrealBuildAcceleratorHordeConfigConfig UBAHordeAllowWine(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-UBAHordeAllowWine",
                    Value: null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UnrealBuildAcceleratorHordeConfigConfig) this;
        }

    
/// <summary>
/// Connection mode for agent/compute communication
/// <see cref="ConnectionMode" /> for valid modes.
/// </summary>
        public virtual UnrealBuildAcceleratorHordeConfigConfig UBAHordeConnectionMode(object val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-UBAHordeConnectionMode",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UnrealBuildAcceleratorHordeConfigConfig) this;
        }

    
/// <summary>
/// Encryption to use for agent/compute communication. Note that UBA agent uses its own encryption.
/// <see cref="Encryption" /> for valid modes.
/// </summary>
        public virtual UnrealBuildAcceleratorHordeConfigConfig UBAHordeEncryption(object val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-UBAHordeEncryption",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UnrealBuildAcceleratorHordeConfigConfig) this;
        }

    
/// <summary>
/// Sentry URL to send box data to. Optional.
/// </summary>
        public virtual UnrealBuildAcceleratorHordeConfigConfig UBASentryUrl(object val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-UBASentryUrl",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UnrealBuildAcceleratorHordeConfigConfig) this;
        }

    
/// <summary>
/// Disable horde all together
/// </summary>
        public virtual UnrealBuildAcceleratorHordeConfigConfig UBADisableHorde(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-UBADisableHorde",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UnrealBuildAcceleratorHordeConfigConfig) this;
        }

    
/// <summary>
/// Compute cluster ID to use in Horde. Set to "_auto" to let Horde server resolve a suitable cluster.
/// In multi-region setups this is can simplify configuration of UBT/UBA a lot.
/// </summary>
        public virtual UnrealBuildAcceleratorHordeConfigConfig UBAHordeCluster(object val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-UBAHordeCluster",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UnrealBuildAcceleratorHordeConfigConfig) this;
        }
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    }

    protected readonly UnrealBuildAcceleratorHordeConfigConfig UnrealBuildAcceleratorHordeConfigStorage = new();
    
/// <summary>
/// Identifies plugins with python requirements and attempts to install all dependencies using pip.
/// </summary>
    public  class PipInstallConfig : ToolConfig
    {
        public override string Name => "PipInstall";
        public override string CliName => "-PipInstall";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest;
    
/// <summary>Full path to python interpreter engine was built with (if unspecified use value in PythonSDKRoot.txt)
/// Full path to python interpreter to use in case the engine is built against an external python SDK</summary>
        public virtual PipInstallConfig PythonInterpreter(object val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-PythonInterpreter",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (PipInstallConfig) this;
        }

    
/// <summary>The action the pip install tool should implement (GenRequirements, Setup, Parse, Install, ViewLicenses, default: Install)
/// Pip action: [GenRequirements, Setup, Parse, Install, ViewLicenses, default: Install]</summary>
        public virtual PipInstallConfig PipAction(PipAction? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-PipAction",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (PipInstallConfig) this;
        }

    
/// <summary>Disable requiring hashes in pip install requirements (NOTE: this is insecure and may simplify supply-chain attacks)
/// Do not require package hashes (WARNING: Enabling this flag is security risk)</summary>
        public virtual PipInstallConfig IgnoreHashes(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-IgnoreHashes",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (PipInstallConfig) this;
        }

    
/// <summary>Allow overriding the index url (this will also disable extra-urls)
/// Use the specified index-url (WARNING: Should not be combined with IgnoreHashes)</summary>
        public virtual PipInstallConfig OverrideIndexUrl(object val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-OverrideIndexUrl",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (PipInstallConfig) this;
        }

    
/// <summary>
/// Run pip installer on all plugins in project and engine
/// </summary>
        public virtual PipInstallConfig AllPlugins(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-AllPlugins",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (PipInstallConfig) this;
        }
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    }

    protected readonly PipInstallConfig PipInstallStorage = new();
    
/// <summary></summary>
    public  class VSWorkspaceProjectFileGeneratorConfig : ToolConfig
    {
        public override string Name => "VSWorkspaceProjectFileGenerator";
        public override string CliName => "";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest;
    
/// <summary>
/// Platforms to generate project files for
/// </summary>
        public virtual VSWorkspaceProjectFileGeneratorConfig Platforms(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Platforms",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: true
                    )
                ));
            }
            return (VSWorkspaceProjectFileGeneratorConfig) this;
        }

    
/// <summary>
/// Target types to generate project files for
/// </summary>
        public virtual VSWorkspaceProjectFileGeneratorConfig TargetTypes(params TargetType[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-TargetTypes",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: true
                    )
                ));
            }
            return (VSWorkspaceProjectFileGeneratorConfig) this;
        }

    
/// <summary>
/// Target configurations to generate project files for
/// </summary>
        public virtual VSWorkspaceProjectFileGeneratorConfig TargetConfigurations(params UnrealTargetConfiguration[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-TargetConfigurations",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: true
                    )
                ));
            }
            return (VSWorkspaceProjectFileGeneratorConfig) this;
        }

    
/// <summary>
/// Projects to generate project files for
/// </summary>
        public virtual VSWorkspaceProjectFileGeneratorConfig ProjectNames(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-ProjectNames",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: true
                    )
                ));
            }
            return (VSWorkspaceProjectFileGeneratorConfig) this;
        }

    
/// <summary>
/// Should format JSON files in human readable form, or use packed one without indents
/// </summary>
        public virtual VSWorkspaceProjectFileGeneratorConfig Minimize(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Minimize",
                    Value: null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_4 | UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (VSWorkspaceProjectFileGeneratorConfig) this;
        }

    
/// <summary>Outputs all the available configurations, platforms and targets to a file provided by the user.</summary>
        public virtual VSWorkspaceProjectFileGeneratorConfig Query(object val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Query",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (VSWorkspaceProjectFileGeneratorConfig) this;
        }

    
    
        public virtual VSWorkspaceProjectFileGeneratorConfig TargetDescriptionFile(object val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-TargetDescriptionFile",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (VSWorkspaceProjectFileGeneratorConfig) this;
        }

    
/// <summary>Show version information and exit.</summary>
        public virtual VSWorkspaceProjectFileGeneratorConfig WorkspaceGeneratorVersion(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-WorkspaceGeneratorVersion",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (VSWorkspaceProjectFileGeneratorConfig) this;
        }

    
/// <summary>Generate .vsconfig file with dependencies and exit</summary>
        public virtual VSWorkspaceProjectFileGeneratorConfig GenerateVsConfigOnly(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-GenerateVsConfigOnly",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_5 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (VSWorkspaceProjectFileGeneratorConfig) this;
        }
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    }

    protected readonly VSWorkspaceProjectFileGeneratorConfig VSWorkspaceProjectFileGeneratorStorage = new();
    
/// <summary>
/// Container class used for C++ compiler warning settings.
/// </summary>
    public  class CppCompileWarningsConfig : ToolConfig
    {
        public override string Name => "CppCompileWarnings";
        public override string CliName => "";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE_5_Latest;
    
/// <summary>
/// Forces shadow variable warnings to be treated as errors on platforms that support it.
/// MSVC -
/// https://learn.microsoft.com/en-us/cpp/error-messages/compiler-warnings/compiler-warning-level-4-c4456
/// 4456 - declaration of 'LocalVariable' hides previous local declaration
/// https://learn.microsoft.com/en-us/cpp/error-messages/compiler-warnings/compiler-warning-level-4-c4458
/// 4458 - declaration of 'parameter' hides class member
/// https://learn.microsoft.com/en-us/cpp/error-messages/compiler-warnings/compiler-warning-level-4-c4459
/// 4459 - declaration of 'LocalVariable' hides global declaration
/// Clang -
/// https://clang.llvm.org/docs/DiagnosticsReference.html#wshadow
/// </summary>
        public virtual CppCompileWarningsConfig ShadowVariableErrors(WarningLevel? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-ShadowVariableErrors",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (CppCompileWarningsConfig) this;
        }

    
/// <summary>
/// Indicates what warning/error level to treat undefined identifiers in conditional expressions.
/// MSVC -
/// https://learn.microsoft.com/en-us/cpp/error-messages/compiler-warnings/compiler-warning-level-4-c4668
/// 4668 - 'symbol' is not defined as a preprocessor macro, replacing with '0' for 'directives'
/// 44668 - Note: The extra 4 is not a typo, /wLXXXX sets warning XXXX to level L
/// Clang -
/// https://clang.llvm.org/docs/DiagnosticsReference.html#wundef
/// </summary>
        public virtual CppCompileWarningsConfig UndefinedIdentifierWarningLevel(WarningLevel? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-UndefinedIdentifierWarningLevel",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (CppCompileWarningsConfig) this;
        }

    
/// <summary>
/// Indicates what warning/error level to treat unhandled enumerators in switches on enumeration-typed values.
/// MSVC -
/// 4061 - https://learn.microsoft.com/en-us/cpp/error-messages/compiler-warnings/compiler-warning-level-4-c4061
/// 44061 - Note: The extra 4 is not a typo, /wLXXXX sets warning XXXX to level L
/// Clang -
/// https://clang.llvm.org/docs/DiagnosticsReference.html#wswitch-enum
/// </summary>
        public virtual CppCompileWarningsConfig SwitchUnhandledEnumeratorWarningLevel(WarningLevel? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-SwitchUnhandledEnumeratorWarningLevel",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (CppCompileWarningsConfig) this;
        }

    
/// <summary>
/// Indicates what warning/error level to treat potential PCH performance issues.
/// </summary>
        public virtual CppCompileWarningsConfig PCHPerformanceIssueWarningLevel(WarningLevel? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-PCHPerformanceIssueWarningLevel",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (CppCompileWarningsConfig) this;
        }

    
/// <summary>
/// How to treat module unsupported validation messages
/// </summary>
        public virtual CppCompileWarningsConfig ModuleUnsupportedWarningLevel(WarningLevel? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-ModuleUnsupportedWarningLevel",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (CppCompileWarningsConfig) this;
        }

    
/// <summary>
/// How to treat plugin specific module unsupported validation messages
/// </summary>
        public virtual CppCompileWarningsConfig PluginModuleUnsupportedWarningLevel(WarningLevel? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-PluginModuleUnsupportedWarningLevel",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (CppCompileWarningsConfig) this;
        }

    
/// <summary>
/// How to treat general module include path validation messages
/// </summary>
        public virtual CppCompileWarningsConfig ModuleIncludePathWarningLevel(WarningLevel? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-ModuleIncludePathWarningLevel",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (CppCompileWarningsConfig) this;
        }

    
/// <summary>
/// How to treat private module include path validation messages, where a module is adding an include path that exposes private headers
/// </summary>
        public virtual CppCompileWarningsConfig ModuleIncludePrivateWarningLevel(WarningLevel? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-ModuleIncludePrivateWarningLevel",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (CppCompileWarningsConfig) this;
        }

    
/// <summary>
/// How to treat unnecessary module sub-directory include path validation messages
/// </summary>
        public virtual CppCompileWarningsConfig ModuleIncludeSubdirectoryWarningLevel(WarningLevel? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-ModuleIncludeSubdirectoryWarningLevel",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (CppCompileWarningsConfig) this;
        }
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    }

    protected readonly CppCompileWarningsConfig CppCompileWarningsStorage = new();
    
/// <summary>
/// Configuration for Unreal Build Accelerator
/// </summary>
    public  class UnrealBuildAcceleratorCacheConfigConfig : ToolConfig
    {
        public override string Name => "UnrealBuildAcceleratorCacheConfig";
        public override string CliName => "";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE_5_Latest;
    
/// <summary>
/// Address of the uba cache service. Will automatically use cache if connected
/// </summary>
        public virtual UnrealBuildAcceleratorCacheConfigConfig UBACache(object val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-UBACache",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UnrealBuildAcceleratorCacheConfigConfig) this;
        }

    
/// <summary>
/// Set cache to write, expects one of [True, False, BuildMachineOnly]
/// </summary>
        public virtual UnrealBuildAcceleratorCacheConfigConfig UBAWriteCache(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-UBAWriteCache",
                    Value: null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UnrealBuildAcceleratorCacheConfigConfig) this;
        }
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    }

    protected readonly UnrealBuildAcceleratorCacheConfigConfig UnrealBuildAcceleratorCacheConfigStorage = new();

    private ToolConfig[] _configs = null;
    protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
    {
        UnrealBuildToolStorage,
                GlobalOptionsStorage,
                BuildConfigurationStorage,
                TargetDescriptorStorage,
                TargetRulesStorage,
                AggregateParsedTimingInfoStorage,
                BuildStorage,
                CleanStorage,
                DeployStorage,
                ExecuteStorage,
                GenerateClangDatabaseStorage,
                GenerateProjectFilesStorage,
                JsonExportStorage,
                ParseMsvcTimingInfoStorage,
                QueryTargetsStorage,
                SetupPlatformsStorage,
                ValidatePlatformsStorage,
                WriteDocumentationStorage,
                WriteMetadataStorage,
                AndroidToolChainStorage,
                AndroidTargetRulesStorage,
                UEDeployAndroidStorage,
                HoloLensTargetRulesStorage,
                IOSPostBuildSyncStorage,
                IOSTargetRulesStorage,
                IOSProjectSettingsStorage,
                LinuxTargetRulesStorage,
                LuminToolChainStorage,
                LuminTargetRulesStorage,
                MacTargetRulesStorage,
                PVSGatherStorage,
                WindowsTargetRulesStorage,
                RiderProjectFileGeneratorStorage,
                AnalyzeStorage,
                AggregateClangTimingInfoStorage,
                FixIncludePathsStorage,
                InlineGeneratedCppsStorage,
                PrintBuildGraphInfoStorage,
                TestStorage,
                UhtGlobalOptionsStorage,
                UnrealHeaderToolStorage,
                IWYUStorage,
                ProfileUnitySizesStorage,
                ServerStorage,
                VSCodeProjectFileGeneratorStorage,
                ClReproStorage,
                QueryStorage,
                ApplePostBuildSyncStorage,
                ImmediateActionQueueStorage,
                UnrealBuildAcceleratorConfigStorage,
                UnrealBuildAcceleratorHordeConfigStorage,
                PipInstallStorage,
                VSWorkspaceProjectFileGeneratorStorage,
                CppCompileWarningsStorage,
                UnrealBuildAcceleratorCacheConfigStorage,
            };
/// <summary></summary>
    public UbtConfig UnrealBuildTool(Action<UnrealBuildToolConfig> configurator)
    {
        configurator?.Invoke(UnrealBuildToolStorage);
        AppendSubtool(UnrealBuildToolStorage);
        return (UbtConfig) this;
    }
/// <summary>
/// Global options for UBT (any modes)
/// </summary>
    public UbtConfig GlobalOptions(Action<GlobalOptionsConfig> configurator)
    {
        configurator?.Invoke(GlobalOptionsStorage);
        AppendSubtool(GlobalOptionsStorage);
        return (UbtConfig) this;
    }
/// <summary>
/// Global settings for building. Should not contain any target-specific settings.
/// </summary>
    public UbtConfig BuildConfiguration(Action<BuildConfigurationConfig> configurator)
    {
        configurator?.Invoke(BuildConfigurationStorage);
        AppendSubtool(BuildConfigurationStorage);
        return (UbtConfig) this;
    }
/// <summary>
/// Describes all of the information needed to initialize a UEBuildTarget object
/// </summary>
    public UbtConfig TargetDescriptor(Action<TargetDescriptorConfig> configurator)
    {
        configurator?.Invoke(TargetDescriptorStorage);
        AppendSubtool(TargetDescriptorStorage);
        return (UbtConfig) this;
    }
/// <summary>
/// TargetRules is a data structure that contains the rules for defining a target (application/executable)
/// </summary>
    public UbtConfig TargetRules(Action<TargetRulesConfig> configurator)
    {
        configurator?.Invoke(TargetRulesStorage);
        AppendSubtool(TargetRulesStorage);
        return (UbtConfig) this;
    }
/// <summary>
/// Aggregates parsed Visual C++ timing information files together into one monolithic breakdown file.
/// </summary>
/// <summary>
/// Aggregates parsed Visual C++ timing information files together into one monolithic breakdown file.
/// </summary>
    public UbtConfig AggregateParsedTimingInfo(Action<AggregateParsedTimingInfoConfig> configurator)
    {
        configurator?.Invoke(AggregateParsedTimingInfoStorage);
        AppendSubtool(AggregateParsedTimingInfoStorage);
        return (UbtConfig) this;
    }
/// <summary>
/// Builds a target
/// </summary>
    public UbtConfig Build(Action<BuildConfig> configurator)
    {
        configurator?.Invoke(BuildStorage);
        AppendSubtool(BuildStorage);
        return (UbtConfig) this;
    }
/// <summary>Cleans build products and intermediates for the target. This deletes files which are named consistently with the target being built
/// (e.g. UE4Editor-Foo-Win64-Debug.dll) rather than an actual record of previous build products.
/// Cleans build products and intermediates for the target. This deletes files which are named consistently with the target being built
/// (e.g. UnrealEditor-Foo-Win64-Debug.dll) rather than an actual record of previous build products.</summary>
    public UbtConfig Clean(Action<CleanConfig> configurator)
    {
        configurator?.Invoke(CleanStorage);
        AppendSubtool(CleanStorage);
        return (UbtConfig) this;
    }
/// <summary>
/// Invokes the deployment handler for a target.
/// </summary>
    public UbtConfig Deploy(Action<DeployConfig> configurator)
    {
        configurator?.Invoke(DeployStorage);
        AppendSubtool(DeployStorage);
        return (UbtConfig) this;
    }
/// <summary>
/// Builds a target
/// </summary>
    public UbtConfig Execute(Action<ExecuteConfig> configurator)
    {
        configurator?.Invoke(ExecuteStorage);
        AppendSubtool(ExecuteStorage);
        return (UbtConfig) this;
    }
/// <summary>
/// Generate a clang compile_commands file for a target
/// </summary>
    public UbtConfig GenerateClangDatabase(Action<GenerateClangDatabaseConfig> configurator)
    {
        configurator?.Invoke(GenerateClangDatabaseStorage);
        AppendSubtool(GenerateClangDatabaseStorage);
        return (UbtConfig) this;
    }
/// <summary>
/// Generates project files for one or more projects
/// </summary>
    public UbtConfig GenerateProjectFiles(Action<GenerateProjectFilesConfig> configurator)
    {
        configurator?.Invoke(GenerateProjectFilesStorage);
        AppendSubtool(GenerateProjectFilesStorage);
        return (UbtConfig) this;
    }
/// <summary>
/// Exports a target as a JSON file
/// </summary>
    public UbtConfig JsonExport(Action<JsonExportConfig> configurator)
    {
        configurator?.Invoke(JsonExportStorage);
        AppendSubtool(JsonExportStorage);
        return (UbtConfig) this;
    }
/// <summary>
/// Parses an MSVC timing info file generated from cl-filter to turn it into a form that can be used by other tooling.
/// This is implemented as a separate mode to allow it to be done as part of the action graph.
/// </summary>
/// <summary>
/// Parses an MSVC timing info file generated from cl-filter to turn it into a form that can be used by other tooling.
/// This is implemented as a separate mode to allow it to be done as part of the action graph.
/// </summary>
    public UbtConfig ParseMsvcTimingInfo(Action<ParseMsvcTimingInfoConfig> configurator)
    {
        configurator?.Invoke(ParseMsvcTimingInfoStorage);
        AppendSubtool(ParseMsvcTimingInfoStorage);
        return (UbtConfig) this;
    }
/// <summary>
/// Queries information about the targets supported by a project
/// </summary>
    public UbtConfig QueryTargets(Action<QueryTargetsConfig> configurator)
    {
        configurator?.Invoke(QueryTargetsStorage);
        AppendSubtool(QueryTargetsStorage);
        return (UbtConfig) this;
    }
/// <summary>
/// Register all platforms (and in the process, configure all autosdks)
/// </summary>
    public UbtConfig SetupPlatforms(Action<SetupPlatformsConfig> configurator)
    {
        configurator?.Invoke(SetupPlatformsStorage);
        AppendSubtool(SetupPlatformsStorage);
        return (UbtConfig) this;
    }
/// <summary>
/// Validates the various platforms to determine if they are ready for building
/// </summary>
    public UbtConfig ValidatePlatforms(Action<ValidatePlatformsConfig> configurator)
    {
        configurator?.Invoke(ValidatePlatformsStorage);
        AppendSubtool(ValidatePlatformsStorage);
        return (UbtConfig) this;
    }
/// <summary>
/// Generates documentation from reflection data
/// </summary>
    public UbtConfig WriteDocumentation(Action<WriteDocumentationConfig> configurator)
    {
        configurator?.Invoke(WriteDocumentationStorage);
        AppendSubtool(WriteDocumentationStorage);
        return (UbtConfig) this;
    }
/// <summary>
/// Writes all metadata files at the end of a build (receipts, version files, etc...). This is implemented as a separate mode to allow it to be done as part of the action graph.
/// </summary>
    public UbtConfig WriteMetadata(Action<WriteMetadataConfig> configurator)
    {
        configurator?.Invoke(WriteMetadataStorage);
        AppendSubtool(WriteMetadataStorage);
        return (UbtConfig) this;
    }
/// <summary></summary>
    public UbtConfig AndroidToolChain(Action<AndroidToolChainConfig> configurator)
    {
        configurator?.Invoke(AndroidToolChainStorage);
        AppendSubtool(AndroidToolChainStorage);
        return (UbtConfig) this;
    }
/// <summary>
/// Android-specific target settings
/// </summary>
    public UbtConfig AndroidTargetRules(Action<AndroidTargetRulesConfig> configurator)
    {
        configurator?.Invoke(AndroidTargetRulesStorage);
        AppendSubtool(AndroidTargetRulesStorage);
        return (UbtConfig) this;
    }
/// <summary></summary>
    public UbtConfig UEDeployAndroid(Action<UEDeployAndroidConfig> configurator)
    {
        configurator?.Invoke(UEDeployAndroidStorage);
        AppendSubtool(UEDeployAndroidStorage);
        return (UbtConfig) this;
    }
/// <summary>
/// HoloLens-specific target settings
/// </summary>
    public UbtConfig HoloLensTargetRules(Action<HoloLensTargetRulesConfig> configurator)
    {
        configurator?.Invoke(HoloLensTargetRulesStorage);
        AppendSubtool(HoloLensTargetRulesStorage);
        return (UbtConfig) this;
    }

    public UbtConfig IOSPostBuildSync(Action<IOSPostBuildSyncConfig> configurator)
    {
        configurator?.Invoke(IOSPostBuildSyncStorage);
        AppendSubtool(IOSPostBuildSyncStorage);
        return (UbtConfig) this;
    }
/// <summary>
/// IOS-specific target settings
/// </summary>
    public UbtConfig IOSTargetRules(Action<IOSTargetRulesConfig> configurator)
    {
        configurator?.Invoke(IOSTargetRulesStorage);
        AppendSubtool(IOSTargetRulesStorage);
        return (UbtConfig) this;
    }
/// <summary>
/// Stores project-specific IOS settings. Instances of this object are cached by IOSPlatform.
/// </summary>
    public UbtConfig IOSProjectSettings(Action<IOSProjectSettingsConfig> configurator)
    {
        configurator?.Invoke(IOSProjectSettingsStorage);
        AppendSubtool(IOSProjectSettingsStorage);
        return (UbtConfig) this;
    }
/// <summary>
/// Linux-specific target settings
/// </summary>
    public UbtConfig LinuxTargetRules(Action<LinuxTargetRulesConfig> configurator)
    {
        configurator?.Invoke(LinuxTargetRulesStorage);
        AppendSubtool(LinuxTargetRulesStorage);
        return (UbtConfig) this;
    }
/// <summary></summary>
    public UbtConfig LuminToolChain(Action<LuminToolChainConfig> configurator)
    {
        configurator?.Invoke(LuminToolChainStorage);
        AppendSubtool(LuminToolChainStorage);
        return (UbtConfig) this;
    }
/// <summary>
/// Lumin-specific target settings
/// </summary>
    public UbtConfig LuminTargetRules(Action<LuminTargetRulesConfig> configurator)
    {
        configurator?.Invoke(LuminTargetRulesStorage);
        AppendSubtool(LuminTargetRulesStorage);
        return (UbtConfig) this;
    }
/// <summary>
/// Mac-specific target settings
/// </summary>
    public UbtConfig MacTargetRules(Action<MacTargetRulesConfig> configurator)
    {
        configurator?.Invoke(MacTargetRulesStorage);
        AppendSubtool(MacTargetRulesStorage);
        return (UbtConfig) this;
    }
/// <summary>
/// Special mode for gathering all the messages into a single output file
/// </summary>
    public UbtConfig PVSGather(Action<PVSGatherConfig> configurator)
    {
        configurator?.Invoke(PVSGatherStorage);
        AppendSubtool(PVSGatherStorage);
        return (UbtConfig) this;
    }
/// <summary>
/// Windows-specific target settings
/// </summary>
    public UbtConfig WindowsTargetRules(Action<WindowsTargetRulesConfig> configurator)
    {
        configurator?.Invoke(WindowsTargetRulesStorage);
        AppendSubtool(WindowsTargetRulesStorage);
        return (UbtConfig) this;
    }
/// <summary></summary>
    public UbtConfig RiderProjectFileGenerator(Action<RiderProjectFileGeneratorConfig> configurator)
    {
        configurator?.Invoke(RiderProjectFileGeneratorStorage);
        AppendSubtool(RiderProjectFileGeneratorStorage);
        return (UbtConfig) this;
    }
/// <summary>
/// Outputs information about the given target, including a module dependecy graph (in .gefx format and list of module references)
/// </summary>
    public UbtConfig Analyze(Action<AnalyzeConfig> configurator)
    {
        configurator?.Invoke(AnalyzeStorage);
        AppendSubtool(AnalyzeStorage);
        return (UbtConfig) this;
    }
/// <summary>
/// Aggregates clang timing information files together into one monolithic breakdown file.
/// </summary>
    public UbtConfig AggregateClangTimingInfo(Action<AggregateClangTimingInfoConfig> configurator)
    {
        configurator?.Invoke(AggregateClangTimingInfoStorage);
        AppendSubtool(AggregateClangTimingInfoStorage);
        return (UbtConfig) this;
    }
/// <summary>
/// Fixes the include paths found in a header and source file
/// </summary>
    public UbtConfig FixIncludePaths(Action<FixIncludePathsConfig> configurator)
    {
        configurator?.Invoke(FixIncludePathsStorage);
        AppendSubtool(FixIncludePathsStorage);
        return (UbtConfig) this;
    }
/// <summary>
/// Generate a clang compile_commands file for a target
/// </summary>
    public UbtConfig InlineGeneratedCpps(Action<InlineGeneratedCppsConfig> configurator)
    {
        configurator?.Invoke(InlineGeneratedCppsStorage);
        AppendSubtool(InlineGeneratedCppsStorage);
        return (UbtConfig) this;
    }
/// <summary>
/// Generate a clang compile_commands file for a target
/// </summary>
    public UbtConfig PrintBuildGraphInfo(Action<PrintBuildGraphInfoConfig> configurator)
    {
        configurator?.Invoke(PrintBuildGraphInfoStorage);
        AppendSubtool(PrintBuildGraphInfoStorage);
        return (UbtConfig) this;
    }
/// <summary>
/// Builds low level tests on one or more targets.
/// </summary>
    public UbtConfig Test(Action<TestConfig> configurator)
    {
        configurator?.Invoke(TestStorage);
        AppendSubtool(TestStorage);
        return (UbtConfig) this;
    }
/// <summary>
/// Global options for UBT (any modes)
/// </summary>
    public UbtConfig UhtGlobalOptions(Action<UhtGlobalOptionsConfig> configurator)
    {
        configurator?.Invoke(UhtGlobalOptionsStorage);
        AppendSubtool(UhtGlobalOptionsStorage);
        return (UbtConfig) this;
    }
/// <summary>
/// Invoke UHT
/// </summary>
    public UbtConfig UnrealHeaderTool(Action<UnrealHeaderToolConfig> configurator)
    {
        configurator?.Invoke(UnrealHeaderToolStorage);
        AppendSubtool(UnrealHeaderToolStorage);
        return (UbtConfig) this;
    }
/// <summary>
/// Profiles different unity sizes and prints out the different size and its timings
/// </summary>
    public UbtConfig IWYU(Action<IWYUConfig> configurator)
    {
        configurator?.Invoke(IWYUStorage);
        AppendSubtool(IWYUStorage);
        return (UbtConfig) this;
    }
/// <summary>
/// Profiles different unity sizes and prints out the different size and its timings
/// </summary>
    public UbtConfig ProfileUnitySizes(Action<ProfileUnitySizesConfig> configurator)
    {
        configurator?.Invoke(ProfileUnitySizesStorage);
        AppendSubtool(ProfileUnitySizesStorage);
        return (UbtConfig) this;
    }

    public UbtConfig Server(Action<ServerConfig> configurator)
    {
        configurator?.Invoke(ServerStorage);
        AppendSubtool(ServerStorage);
        return (UbtConfig) this;
    }
/// <summary></summary>
    public UbtConfig VSCodeProjectFileGenerator(Action<VSCodeProjectFileGeneratorConfig> configurator)
    {
        configurator?.Invoke(VSCodeProjectFileGeneratorStorage);
        AppendSubtool(VSCodeProjectFileGeneratorStorage);
        return (UbtConfig) this;
    }

    public UbtConfig ClRepro(Action<ClReproConfig> configurator)
    {
        configurator?.Invoke(ClReproStorage);
        AppendSubtool(ClReproStorage);
        return (UbtConfig) this;
    }

    public UbtConfig Query(Action<QueryConfig> configurator)
    {
        configurator?.Invoke(QueryStorage);
        AppendSubtool(QueryStorage);
        return (UbtConfig) this;
    }

    public UbtConfig ApplePostBuildSync(Action<ApplePostBuildSyncConfig> configurator)
    {
        configurator?.Invoke(ApplePostBuildSyncStorage);
        AppendSubtool(ApplePostBuildSyncStorage);
        return (UbtConfig) this;
    }
/// <summary>
/// Helper class to manage the action queue
/// 
/// Running the queue can be done with a mixture of automatic and manual runners. Runners are responsible for performing
/// the work associated with an action. Automatic runners will have actions automatically queued to them up to the point
/// that any runtime limits aren't exceeded (such as maximum number of concurrent processes).  Manual runners must have
/// jobs queued to them by calling TryStartOneAction or StartManyActions with the runner specified.
/// 
/// For example:
/// 
/// ParallelExecutor uses an automatic runner exclusively.
/// UBAExecutor uses an automatic runner to run jobs locally and a manual runner to run jobs remotely as processes
/// become available.
/// </summary>
    public UbtConfig ImmediateActionQueue(Action<ImmediateActionQueueConfig> configurator)
    {
        configurator?.Invoke(ImmediateActionQueueStorage);
        AppendSubtool(ImmediateActionQueueStorage);
        return (UbtConfig) this;
    }
/// <summary>
/// Configuration for Unreal Build Accelerator
/// </summary>
    public UbtConfig UnrealBuildAcceleratorConfig(Action<UnrealBuildAcceleratorConfigConfig> configurator)
    {
        configurator?.Invoke(UnrealBuildAcceleratorConfigStorage);
        AppendSubtool(UnrealBuildAcceleratorConfigStorage);
        return (UbtConfig) this;
    }
/// <summary>
/// Configuration for Unreal Build Accelerator Horde session
/// </summary>
    public UbtConfig UnrealBuildAcceleratorHordeConfig(Action<UnrealBuildAcceleratorHordeConfigConfig> configurator)
    {
        configurator?.Invoke(UnrealBuildAcceleratorHordeConfigStorage);
        AppendSubtool(UnrealBuildAcceleratorHordeConfigStorage);
        return (UbtConfig) this;
    }
/// <summary>
/// Identifies plugins with python requirements and attempts to install all dependencies using pip.
/// </summary>
    public UbtConfig PipInstall(Action<PipInstallConfig> configurator)
    {
        configurator?.Invoke(PipInstallStorage);
        AppendSubtool(PipInstallStorage);
        return (UbtConfig) this;
    }
/// <summary></summary>
    public UbtConfig VSWorkspaceProjectFileGenerator(Action<VSWorkspaceProjectFileGeneratorConfig> configurator)
    {
        configurator?.Invoke(VSWorkspaceProjectFileGeneratorStorage);
        AppendSubtool(VSWorkspaceProjectFileGeneratorStorage);
        return (UbtConfig) this;
    }
/// <summary>
/// Container class used for C++ compiler warning settings.
/// </summary>
    public UbtConfig CppCompileWarnings(Action<CppCompileWarningsConfig> configurator)
    {
        configurator?.Invoke(CppCompileWarningsStorage);
        AppendSubtool(CppCompileWarningsStorage);
        return (UbtConfig) this;
    }
/// <summary>
/// Configuration for Unreal Build Accelerator
/// </summary>
    public UbtConfig UnrealBuildAcceleratorCacheConfig(Action<UnrealBuildAcceleratorCacheConfigConfig> configurator)
    {
        configurator?.Invoke(UnrealBuildAcceleratorCacheConfigStorage);
        AppendSubtool(UnrealBuildAcceleratorCacheConfigStorage);
        return (UbtConfig) this;
    }
}
