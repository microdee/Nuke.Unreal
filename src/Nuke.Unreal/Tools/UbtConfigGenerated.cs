
// This file is generated via `nuke generate-tools` target.

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


/// <summary>Unreal Build Tool defines the Unreal project structure and provides unified source building utilities over multiple platforms</summary>
public abstract class UbtConfigGenerated : ToolConfig
{
    public override string Name => "Ubt";
    public override string CliName => "";
    public override UnrealCompatibility Compatibility => UnrealCompatibility.UE4 | UnrealCompatibility.UE5;
    
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
                    Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                    AllowMultiple: false
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
                    Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                    AllowMultiple: false
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
                    Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                    AllowMultiple: false
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
                    Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                    AllowMultiple: false
                ));
            }
            return (UbtConfig) this;
        }

        
/// <summary>Whether to format messages in MsBuild format
/// Format messages for msbuild</summary>
        public virtual UbtConfig FromMsBuild(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-FromMsBuild",
                    Value: val?.ToString(),
                    Setter: '=',
                    Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                    AllowMultiple: false
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
                    Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                    AllowMultiple: false
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
                    Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                    AllowMultiple: false
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
                    Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                    AllowMultiple: false
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
                    Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                    AllowMultiple: false
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
                    Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                    AllowMultiple: false
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
                    Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                    AllowMultiple: false
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
                    Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                    AllowMultiple: false
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
                    Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                    AllowMultiple: false
                ));
            }
            return (UbtConfig) this;
        }

        
/// <summary>The mode to execute
/// Generate Linux Makefile</summary>
        public virtual UbtConfig Makefile(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Makefile",
                    Value: null,
                    Setter: '=',
                    Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                    AllowMultiple: false
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
                    Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                    AllowMultiple: false
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
                    Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                    AllowMultiple: false
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
                    Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                    AllowMultiple: false
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
                    Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                    AllowMultiple: false
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
                    Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                    AllowMultiple: false
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
                    Compatibility: UnrealCompatibility.UE4,
                    AllowMultiple: false
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
                    Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                    AllowMultiple: false
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
                    Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                    AllowMultiple: false
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
                    Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                    AllowMultiple: false
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
                    Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                    AllowMultiple: false
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
                    Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                    AllowMultiple: false
                ));
            }
            return (UbtConfig) this;
        }

        
/// <summary>
/// Whether XGE may be used.
/// </summary>
        public virtual UbtConfig NoXGE(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-NoXGE",
                    Value: null,
                    Setter: '=',
                    Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                    AllowMultiple: false
                ));
            }
            return (UbtConfig) this;
        }

        
/// <summary>
/// Whether FASTBuild may be used.
/// </summary>
        public virtual UbtConfig NoFASTBuild(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-NoFASTBuild",
                    Value: null,
                    Setter: '=',
                    Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                    AllowMultiple: false
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
                    Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                    AllowMultiple: false
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
                    Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                    AllowMultiple: false
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
                    Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                    AllowMultiple: false
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
                    Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                    AllowMultiple: false
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
                    Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                    AllowMultiple: false
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
                    Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                    AllowMultiple: false
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
                    Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                    AllowMultiple: false
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
                    Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                    AllowMultiple: false
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
                            Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                            AllowMultiple: true
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
                            Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                            AllowMultiple: true
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
                    Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                    AllowMultiple: false
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
                    Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                    AllowMultiple: false
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
                    Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                    AllowMultiple: false
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
                            Compatibility: UnrealCompatibility.UE4,
                            AllowMultiple: true
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
                    Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                    AllowMultiple: false
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
                    Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                    AllowMultiple: false
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
                    Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                    AllowMultiple: false
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
                if (values != null)
                    foreach (var val in values)
                    {
                        AppendArgument(new UnrealToolArgument(
                            "-Architectures",
                            Value: val.ToString(),
                            Setter: '=',
                            Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                            AllowMultiple: true
                        ));
                    }
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
                if (values != null)
                    foreach (var val in values)
                    {
                        AppendArgument(new UnrealToolArgument(
                            "-GPUArchitectures",
                            Value: val.ToString(),
                            Setter: '=',
                            Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                            AllowMultiple: true
                        ));
                    }
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
                    Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                    AllowMultiple: false
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
                    Compatibility: UnrealCompatibility.UE4,
                    AllowMultiple: false
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
                    Compatibility: UnrealCompatibility.UE4,
                    AllowMultiple: false
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
                    Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                    AllowMultiple: false
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
                    Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                    AllowMultiple: false
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
                    Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                    AllowMultiple: false
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
                    Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                    AllowMultiple: false
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
                    Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                    AllowMultiple: false
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
                    Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                    AllowMultiple: false
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
                    Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                    AllowMultiple: false
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
                    Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                    AllowMultiple: false
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
                    Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                    AllowMultiple: false
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
                    Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                    AllowMultiple: false
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
                    Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                    AllowMultiple: false
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
                    Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                    AllowMultiple: false
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
                    Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                    AllowMultiple: false
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
                    Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                    AllowMultiple: false
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
                    Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                    AllowMultiple: false
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
                    Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                    AllowMultiple: false
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
                    Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                    AllowMultiple: false
                ));
            }
            return (UbtConfig) this;
        }

        
/// <summary>
/// Enables "thin" LTO
/// </summary>
        public virtual UbtConfig ThinLTO(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-ThinLTO",
                    Value: val?.ToString(),
                    Setter: '=',
                    Compatibility: UnrealCompatibility.UE4,
                    AllowMultiple: false
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
                    Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                    AllowMultiple: false
                ));
            }
            return (UbtConfig) this;
        }

        
/// <summary>
/// The specific toolchain version to use. This may be a specific version number (for example, "14.13.26128"), the string "Latest" to select the newest available version, or
/// the string "Preview" to select the newest available preview version. By default, and if it is available, we use the toolchain version indicated by
/// WindowsPlatform.DefaultToolChainVersion (otherwise, we use the latest version).
/// </summary>
        public virtual UbtConfig CompilerVersion(object val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-CompilerVersion",
                    Value: val?.ToString(),
                    Setter: '=',
                    Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                    AllowMultiple: false
                ));
            }
            return (UbtConfig) this;
        }

        
/// <summary>
/// The static analyzer to use.
/// </summary>
        public virtual UbtConfig StaticAnalyzer(WindowsStaticAnalyzer? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-StaticAnalyzer",
                    Value: val?.ToString(),
                    Setter: '=',
                    Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                    AllowMultiple: false
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
                    Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                    AllowMultiple: false
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
                    Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                    AllowMultiple: false
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
                    Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                    AllowMultiple: false
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
                if (values != null)
                    foreach (var val in values)
                    {
                        AppendArgument(new UnrealToolArgument(
                            "-Platforms",
                            Value: val.ToString(),
                            Setter: '=',
                            Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                            AllowMultiple: true
                        ));
                    }
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
                if (values != null)
                    foreach (var val in values)
                    {
                        AppendArgument(new UnrealToolArgument(
                            "-TargetTypes",
                            Value: val.ToString(),
                            Setter: '=',
                            Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                            AllowMultiple: true
                        ));
                    }
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
                if (values != null)
                    foreach (var val in values)
                    {
                        AppendArgument(new UnrealToolArgument(
                            "-TargetConfigurations",
                            Value: val.ToString(),
                            Setter: '=',
                            Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                            AllowMultiple: true
                        ));
                    }
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
                if (values != null)
                    foreach (var val in values)
                    {
                        AppendArgument(new UnrealToolArgument(
                            "-ProjectNames",
                            Value: val.ToString(),
                            Setter: '=',
                            Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                            AllowMultiple: true
                        ));
                    }
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
                    Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                    AllowMultiple: false
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
                    Compatibility: UnrealCompatibility.UE5,
                    AllowMultiple: false
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
                    Compatibility: UnrealCompatibility.UE5,
                    AllowMultiple: false
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
                    Compatibility: UnrealCompatibility.UE5,
                    AllowMultiple: false
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
                    Compatibility: UnrealCompatibility.UE5,
                    AllowMultiple: false
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
                    Compatibility: UnrealCompatibility.UE5,
                    AllowMultiple: false
                ));
            }
            return (UbtConfig) this;
        }

        
/// <summary>
/// Whether SN-DBS may be used.
/// </summary>
        public virtual UbtConfig NoSNDBS(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-NoSNDBS",
                    Value: null,
                    Setter: '=',
                    Compatibility: UnrealCompatibility.UE5,
                    AllowMultiple: false
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
                    Compatibility: UnrealCompatibility.UE5,
                    AllowMultiple: false
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
                    Compatibility: UnrealCompatibility.UE5,
                    AllowMultiple: false
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
                    Compatibility: UnrealCompatibility.UE5,
                    AllowMultiple: false
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
                    Compatibility: UnrealCompatibility.UE5,
                    AllowMultiple: false
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
                            Compatibility: UnrealCompatibility.UE5,
                            AllowMultiple: true
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
                            Compatibility: UnrealCompatibility.UE5,
                            AllowMultiple: true
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
                    Compatibility: UnrealCompatibility.UE5,
                    AllowMultiple: false
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
                    Compatibility: UnrealCompatibility.UE5,
                    AllowMultiple: false
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
                    Compatibility: UnrealCompatibility.UE5,
                    AllowMultiple: false
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
                    Compatibility: UnrealCompatibility.UE5,
                    AllowMultiple: false
                ));
            }
            return (UbtConfig) this;
        }

        
/// <summary>Treat warnings as errors</summary>
        public virtual UbtConfig WarningsAsErrors(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-WarningsAsErrors",
                    Value: val?.ToString(),
                    Setter: '=',
                    Compatibility: UnrealCompatibility.UE5,
                    AllowMultiple: false
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
                    Compatibility: UnrealCompatibility.UE5,
                    AllowMultiple: false
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
                    Compatibility: UnrealCompatibility.UE5,
                    AllowMultiple: false
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
                    Compatibility: UnrealCompatibility.UE5,
                    AllowMultiple: false
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
                    Compatibility: UnrealCompatibility.UE5,
                    AllowMultiple: false
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
                    Compatibility: UnrealCompatibility.UE5,
                    AllowMultiple: false
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
                    Compatibility: UnrealCompatibility.UE5,
                    AllowMultiple: false
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
                    Compatibility: UnrealCompatibility.UE5,
                    AllowMultiple: false
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
                    Compatibility: UnrealCompatibility.UE5,
                    AllowMultiple: false
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
                    Compatibility: UnrealCompatibility.UE5,
                    AllowMultiple: false
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
                    Compatibility: UnrealCompatibility.UE5,
                    AllowMultiple: false
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
                    Compatibility: UnrealCompatibility.UE5,
                    AllowMultiple: false
                ));
            }
            return (UbtConfig) this;
        }

        
/// <summary>
/// Enables the generation of .dsym files. This can be disabled to enable faster iteration times during development.
/// </summary>
        public virtual UbtConfig EnableDSYM(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-EnableDSYM",
                    Value: null,
                    Setter: '=',
                    Compatibility: UnrealCompatibility.UE5,
                    AllowMultiple: false
                ));
            }
            return (UbtConfig) this;
        }

        
/// <summary>
/// The output type to use for the static analyzer.
/// </summary>
        public virtual UbtConfig StaticAnalyzerOutputType(WindowsStaticAnalyzerOutputType? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-StaticAnalyzerOutputType",
                    Value: val?.ToString(),
                    Setter: '=',
                    Compatibility: UnrealCompatibility.UE5,
                    AllowMultiple: false
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
                    Compatibility: UnrealCompatibility.UE5,
                    AllowMultiple: false
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
                    Compatibility: UnrealCompatibility.UE5,
                    AllowMultiple: false
                ));
            }
            return (UbtConfig) this;
        }

        
/// <summary>
/// Enables new preprocessor conformance (/Zc:preprocessor).
/// </summary>
        public virtual UbtConfig StrictPreprocessor(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-StrictPreprocessor",
                    Value: val?.ToString(),
                    Setter: '=',
                    Compatibility: UnrealCompatibility.UE5,
                    AllowMultiple: false
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
                    Compatibility: UnrealCompatibility.UE5,
                    AllowMultiple: false
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
                    Compatibility: UnrealCompatibility.UE5,
                    AllowMultiple: false
                ));
            }
            return (UbtConfig) this;
        }

        
/// <summary>&lt;summary&gt;&lt;/summary&gt;</summary>
    public  class UnrealBuildToolConfig : ToolConfig
    {
        public override string Name => "UnrealBuildTool";
        public override string CliName => "";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE4 | UnrealCompatibility.UE5;
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    }

    protected readonly UnrealBuildToolConfig UnrealBuildToolStorage = new();
        
/// <summary>&lt;summary&gt;
/// Global options for UBT (any modes)
/// &lt;/summary&gt;</summary>
    public  class GlobalOptionsConfig : ToolConfig
    {
        public override string Name => "GlobalOptions";
        public override string CliName => "";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE4 | UnrealCompatibility.UE5;
    
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
                    Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                    AllowMultiple: false
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
                    Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                    AllowMultiple: false
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
                    Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                    AllowMultiple: false
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
                    Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                    AllowMultiple: false
                ));
            }
            return (GlobalOptionsConfig) this;
        }

        
/// <summary>Whether to format messages in MsBuild format
/// Format messages for msbuild</summary>
        public virtual GlobalOptionsConfig FromMsBuild(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-FromMsBuild",
                    Value: val?.ToString(),
                    Setter: '=',
                    Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                    AllowMultiple: false
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
                    Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                    AllowMultiple: false
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
                    Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                    AllowMultiple: false
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
                    Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                    AllowMultiple: false
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
                    Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                    AllowMultiple: false
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
                    Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                    AllowMultiple: false
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
                    Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                    AllowMultiple: false
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
                    Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                    AllowMultiple: false
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
                    Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                    AllowMultiple: false
                ));
            }
            return (GlobalOptionsConfig) this;
        }

        
/// <summary>The mode to execute
/// Generate Linux Makefile</summary>
        public virtual GlobalOptionsConfig Makefile(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Makefile",
                    Value: null,
                    Setter: '=',
                    Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                    AllowMultiple: false
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
                    Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                    AllowMultiple: false
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
                    Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                    AllowMultiple: false
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
                    Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                    AllowMultiple: false
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
                    Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                    AllowMultiple: false
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
                    Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                    AllowMultiple: false
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
                    Compatibility: UnrealCompatibility.UE4,
                    AllowMultiple: false
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
                    Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                    AllowMultiple: false
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
                    Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                    AllowMultiple: false
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
                    Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                    AllowMultiple: false
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
                    Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                    AllowMultiple: false
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
                    Compatibility: UnrealCompatibility.UE5,
                    AllowMultiple: false
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
                    Compatibility: UnrealCompatibility.UE5,
                    AllowMultiple: false
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
                    Compatibility: UnrealCompatibility.UE5,
                    AllowMultiple: false
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
        
/// <summary>&lt;summary&gt;
/// Global settings for building. Should not contain any target-specific settings.
/// &lt;/summary&gt;</summary>
    public  class BuildConfigurationConfig : ToolConfig
    {
        public override string Name => "BuildConfiguration";
        public override string CliName => "";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE4 | UnrealCompatibility.UE5;
    
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
                    Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                    AllowMultiple: false
                ));
            }
            return (BuildConfigurationConfig) this;
        }

        
/// <summary>
/// Whether XGE may be used.
/// </summary>
        public virtual BuildConfigurationConfig NoXGE(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-NoXGE",
                    Value: null,
                    Setter: '=',
                    Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                    AllowMultiple: false
                ));
            }
            return (BuildConfigurationConfig) this;
        }

        
/// <summary>
/// Whether FASTBuild may be used.
/// </summary>
        public virtual BuildConfigurationConfig NoFASTBuild(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-NoFASTBuild",
                    Value: null,
                    Setter: '=',
                    Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                    AllowMultiple: false
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
                    Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                    AllowMultiple: false
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
                    Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                    AllowMultiple: false
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
                    Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                    AllowMultiple: false
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
                    Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                    AllowMultiple: false
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
                    Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                    AllowMultiple: false
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
                    Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                    AllowMultiple: false
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
                    Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                    AllowMultiple: false
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
                    Compatibility: UnrealCompatibility.UE5,
                    AllowMultiple: false
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
                    Compatibility: UnrealCompatibility.UE5,
                    AllowMultiple: false
                ));
            }
            return (BuildConfigurationConfig) this;
        }

        
/// <summary>
/// Whether SN-DBS may be used.
/// </summary>
        public virtual BuildConfigurationConfig NoSNDBS(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-NoSNDBS",
                    Value: null,
                    Setter: '=',
                    Compatibility: UnrealCompatibility.UE5,
                    AllowMultiple: false
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
                    Compatibility: UnrealCompatibility.UE5,
                    AllowMultiple: false
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
                    Compatibility: UnrealCompatibility.UE5,
                    AllowMultiple: false
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
                    Compatibility: UnrealCompatibility.UE5,
                    AllowMultiple: false
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
                    Compatibility: UnrealCompatibility.UE5,
                    AllowMultiple: false
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
        
/// <summary>&lt;summary&gt;
/// Describes all of the information needed to initialize a UEBuildTarget object
/// &lt;/summary&gt;</summary>
    public  class TargetDescriptorConfig : ToolConfig
    {
        public override string Name => "TargetDescriptor";
        public override string CliName => "";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE4 | UnrealCompatibility.UE5;
    
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
                    Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                    AllowMultiple: false
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
                            Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                            AllowMultiple: true
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
                            Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                            AllowMultiple: true
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
                    Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                    AllowMultiple: false
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
                    Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                    AllowMultiple: false
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
                    Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                    AllowMultiple: false
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
                            Compatibility: UnrealCompatibility.UE4,
                            AllowMultiple: true
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
                    Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                    AllowMultiple: false
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
                    Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                    AllowMultiple: false
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
                    Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                    AllowMultiple: false
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
                            Compatibility: UnrealCompatibility.UE5,
                            AllowMultiple: true
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
                            Compatibility: UnrealCompatibility.UE5,
                            AllowMultiple: true
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
                    Compatibility: UnrealCompatibility.UE5,
                    AllowMultiple: false
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
                    Compatibility: UnrealCompatibility.UE5,
                    AllowMultiple: false
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
        
/// <summary>&lt;summary&gt;
/// Aggregates parsed Visual C++ timing information files together into one monolithic breakdown file.
/// &lt;/summary&gt;
/// &lt;summary&gt;
/// Aggregates parsed Visual C++ timing information files together into one monolithic breakdown file.
/// &lt;/summary&gt;</summary>
    public  class AggregateParsedTimingInfoConfig : ToolConfig
    {
        public override string Name => "AggregateParsedTimingInfo";
        public override string CliName => "-AggregateParsedTimingInfo";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE4 | UnrealCompatibility.UE5;
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    }

    protected readonly AggregateParsedTimingInfoConfig AggregateParsedTimingInfoStorage = new();
        
/// <summary>&lt;summary&gt;
/// Builds a target
/// &lt;/summary&gt;</summary>
    public  class BuildConfig : ToolConfig
    {
        public override string Name => "Build";
        public override string CliName => "-Build";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE4 | UnrealCompatibility.UE5;
    
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
                    Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                    AllowMultiple: false
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
                    Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                    AllowMultiple: false
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
                    Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                    AllowMultiple: false
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
                    Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                    AllowMultiple: false
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
                    Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                    AllowMultiple: false
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
                    Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                    AllowMultiple: false
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
                    Compatibility: UnrealCompatibility.UE5,
                    AllowMultiple: false
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
        
/// <summary>&lt;summary&gt;
/// Cleans build products and intermediates for the target. This deletes files which are named consistently with the target being built
/// (e.g. UE4Editor-Foo-Win64-Debug.dll) rather than an actual record of previous build products.
/// &lt;/summary&gt;
/// &lt;summary&gt;
/// Cleans build products and intermediates for the target. This deletes files which are named consistently with the target being built
/// (e.g. UnrealEditor-Foo-Win64-Debug.dll) rather than an actual record of previous build products.
/// &lt;/summary&gt;</summary>
    public  class CleanConfig : ToolConfig
    {
        public override string Name => "Clean";
        public override string CliName => "-Clean";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE4 | UnrealCompatibility.UE5;
    
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
                    Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                    AllowMultiple: false
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
                    Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                    AllowMultiple: false
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
        
/// <summary>&lt;summary&gt;
/// Invokes the deployment handler for a target.
/// &lt;/summary&gt;</summary>
    public  class DeployConfig : ToolConfig
    {
        public override string Name => "Deploy";
        public override string CliName => "-Deploy";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE4 | UnrealCompatibility.UE5;
    
/// <summary>
/// If we are just running the deployment step, specifies the path to the given deployment settings
/// </summary>
        public virtual DeployConfig Receipt(object val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Receipt",
                    Value: val?.ToString(),
                    Setter: '=',
                    Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                    AllowMultiple: false
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
        
/// <summary>&lt;summary&gt;
/// Builds a target
/// &lt;/summary&gt;</summary>
    public  class ExecuteConfig : ToolConfig
    {
        public override string Name => "Execute";
        public override string CliName => "-Execute";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE4 | UnrealCompatibility.UE5;
    
/// <summary>
/// Whether we should just export the outdated actions list
/// </summary>
        public virtual ExecuteConfig Actions(object val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Actions",
                    Value: val?.ToString(),
                    Setter: '=',
                    Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                    AllowMultiple: false
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
        
/// <summary>&lt;summary&gt;
/// Generate a clang compile_commands file for a target
/// &lt;/summary&gt;</summary>
    public  class GenerateClangDatabaseConfig : ToolConfig
    {
        public override string Name => "GenerateClangDatabase";
        public override string CliName => "-GenerateClangDatabase";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE4 | UnrealCompatibility.UE5;
    
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
                            Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                            AllowMultiple: true
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
                    Compatibility: UnrealCompatibility.UE5,
                    AllowMultiple: false
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
        
/// <summary>&lt;summary&gt;
/// Generates project files for one or more projects
/// &lt;/summary&gt;</summary>
    public  class GenerateProjectFilesConfig : ToolConfig
    {
        public override string Name => "GenerateProjectFiles";
        public override string CliName => "-GenerateProjectFiles";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE4 | UnrealCompatibility.UE5;
    
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
                            Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                            AllowMultiple: true
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
                            Compatibility: UnrealCompatibility.UE4,
                            AllowMultiple: true
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
                            Compatibility: UnrealCompatibility.UE4,
                            AllowMultiple: true
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
                            Compatibility: UnrealCompatibility.UE4,
                            AllowMultiple: true
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
                            Compatibility: UnrealCompatibility.UE4,
                            AllowMultiple: true
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
                            Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                            AllowMultiple: true
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
                            Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                            AllowMultiple: true
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
                            Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                            AllowMultiple: true
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
                            Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                            AllowMultiple: true
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
                            Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                            AllowMultiple: true
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
                            Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                            AllowMultiple: true
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
                            Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                            AllowMultiple: true
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
                            Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                            AllowMultiple: true
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
                            Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                            AllowMultiple: true
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
                            Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                            AllowMultiple: true
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
                            Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                            AllowMultiple: true
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
                            Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                            AllowMultiple: true
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
                            Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                            AllowMultiple: true
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
                    Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                    AllowMultiple: false
                ));
            }
            return (GenerateProjectFilesConfig) this;
        }
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    }

    protected readonly GenerateProjectFilesConfig GenerateProjectFilesStorage = new();
        
/// <summary>&lt;summary&gt;
/// Exports a target as a JSON file
/// &lt;/summary&gt;</summary>
    public  class JsonExportConfig : ToolConfig
    {
        public override string Name => "JsonExport";
        public override string CliName => "-JsonExport";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE4 | UnrealCompatibility.UE5;
    
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
                    Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                    AllowMultiple: false
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
        
/// <summary>&lt;summary&gt;
/// Parses an MSVC timing info file generated from cl-filter to turn it into a form that can be used by other tooling.
/// This is implemented as a separate mode to allow it to be done as part of the action graph.
/// &lt;/summary&gt;
/// &lt;summary&gt;
/// Parses an MSVC timing info file generated from cl-filter to turn it into a form that can be used by other tooling.
/// This is implemented as a separate mode to allow it to be done as part of the action graph.
/// &lt;/summary&gt;</summary>
    public  class ParseMsvcTimingInfoConfig : ToolConfig
    {
        public override string Name => "ParseMsvcTimingInfo";
        public override string CliName => "-ParseMsvcTimingInfo";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE4 | UnrealCompatibility.UE5;
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    }

    protected readonly ParseMsvcTimingInfoConfig ParseMsvcTimingInfoStorage = new();
        
/// <summary>&lt;summary&gt;
/// Queries information about the targets supported by a project
/// &lt;/summary&gt;</summary>
    public  class QueryTargetsConfig : ToolConfig
    {
        public override string Name => "QueryTargets";
        public override string CliName => "-QueryTargets";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE4 | UnrealCompatibility.UE5;
    
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
                    Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                    AllowMultiple: false
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
                    Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                    AllowMultiple: false
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
        
/// <summary>&lt;summary&gt;
/// Register all platforms (and in the process, configure all autosdks)
/// &lt;/summary&gt;</summary>
    public  class SetupPlatformsConfig : ToolConfig
    {
        public override string Name => "SetupPlatforms";
        public override string CliName => "-SetupPlatforms";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE4 | UnrealCompatibility.UE5;
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    }

    protected readonly SetupPlatformsConfig SetupPlatformsStorage = new();
        
/// <summary>&lt;summary&gt;
/// Validates the various platforms to determine if they are ready for building
/// &lt;/summary&gt;</summary>
    public  class ValidatePlatformsConfig : ToolConfig
    {
        public override string Name => "ValidatePlatforms";
        public override string CliName => "-ValidatePlatforms";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE4 | UnrealCompatibility.UE5;
    
/// <summary>
/// Platforms to validate
/// </summary>
        public virtual ValidatePlatformsConfig Platforms(params object[] values)
        {
            if (true)
            {
                if (values != null)
                    foreach (var val in values)
                    {
                        AppendArgument(new UnrealToolArgument(
                            "-Platforms",
                            Value: val.ToString(),
                            Setter: '=',
                            Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                            AllowMultiple: true
                        ));
                    }
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
                    Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                    AllowMultiple: false
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
                    Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                    AllowMultiple: false
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
        
/// <summary>&lt;summary&gt;
/// Generates documentation from reflection data
/// &lt;/summary&gt;</summary>
    public  class WriteDocumentationConfig : ToolConfig
    {
        public override string Name => "WriteDocumentation";
        public override string CliName => "-WriteDocumentation";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE4 | UnrealCompatibility.UE5;
    
/// <summary>
/// Type of documentation to generate
/// </summary>
        public virtual WriteDocumentationConfig _Type(DocumentationType? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Type",
                    Value: val?.ToString(),
                    Setter: '=',
                    Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                    AllowMultiple: false
                ));
            }
            return (WriteDocumentationConfig) this;
        }

        
/// <summary>
/// The HTML file to write to
/// </summary>
        public virtual WriteDocumentationConfig OutputFile(object val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-OutputFile",
                    Value: val?.ToString(),
                    Setter: '=',
                    Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                    AllowMultiple: false
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
        
/// <summary>&lt;summary&gt;
/// Writes all metadata files at the end of a build (receipts, version files, etc...). This is implemented as a separate mode to allow it to be done as part of the action graph.
/// &lt;/summary&gt;</summary>
    public  class WriteMetadataConfig : ToolConfig
    {
        public override string Name => "WriteMetadata";
        public override string CliName => "-WriteMetadata";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE4 | UnrealCompatibility.UE5;
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    }

    protected readonly WriteMetadataConfig WriteMetadataStorage = new();
        
/// <summary>&lt;summary&gt;&lt;/summary&gt;</summary>
    public  class AndroidToolChainConfig : ToolConfig
    {
        public override string Name => "AndroidToolChain";
        public override string CliName => "";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE4 | UnrealCompatibility.UE5;
    
/// <summary>
/// Lists Architectures that you want to build
/// </summary>
        public virtual AndroidToolChainConfig Architectures(params object[] values)
        {
            if (true)
            {
                if (values != null)
                    foreach (var val in values)
                    {
                        AppendArgument(new UnrealToolArgument(
                            "-Architectures",
                            Value: val.ToString(),
                            Setter: '=',
                            Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                            AllowMultiple: true
                        ));
                    }
            }
            return (AndroidToolChainConfig) this;
        }
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    }

    protected readonly AndroidToolChainConfig AndroidToolChainStorage = new();
        
/// <summary>&lt;summary&gt;
/// Android-specific target settings
/// &lt;/summary&gt;</summary>
    public  class AndroidTargetRulesConfig : ToolConfig
    {
        public override string Name => "AndroidTargetRules";
        public override string CliName => "";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE4 | UnrealCompatibility.UE5;
    
/// <summary>
/// Lists Architectures that you want to build
/// </summary>
        public virtual AndroidTargetRulesConfig Architectures(params object[] values)
        {
            if (true)
            {
                if (values != null)
                    foreach (var val in values)
                    {
                        AppendArgument(new UnrealToolArgument(
                            "-Architectures",
                            Value: val.ToString(),
                            Setter: '=',
                            Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                            AllowMultiple: true
                        ));
                    }
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
                if (values != null)
                    foreach (var val in values)
                    {
                        AppendArgument(new UnrealToolArgument(
                            "-GPUArchitectures",
                            Value: val.ToString(),
                            Setter: '=',
                            Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                            AllowMultiple: true
                        ));
                    }
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
                    Compatibility: UnrealCompatibility.UE5,
                    AllowMultiple: false
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
                    Compatibility: UnrealCompatibility.UE5,
                    AllowMultiple: false
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
                    Compatibility: UnrealCompatibility.UE5,
                    AllowMultiple: false
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
                    Compatibility: UnrealCompatibility.UE5,
                    AllowMultiple: false
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
        
/// <summary>&lt;summary&gt;&lt;/summary&gt;</summary>
    public  class UEDeployAndroidConfig : ToolConfig
    {
        public override string Name => "UEDeployAndroid";
        public override string CliName => "";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE4 | UnrealCompatibility.UE5;
    
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
                    Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                    AllowMultiple: false
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
                    Compatibility: UnrealCompatibility.UE5,
                    AllowMultiple: false
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
        
/// <summary>&lt;summary&gt;
/// HoloLens-specific target settings
/// &lt;/summary&gt;</summary>
    public  class HoloLensTargetRulesConfig : ToolConfig
    {
        public override string Name => "HoloLensTargetRules";
        public override string CliName => "";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE4;
    
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
                    Compatibility: UnrealCompatibility.UE4,
                    AllowMultiple: false
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
                    Compatibility: UnrealCompatibility.UE4,
                    AllowMultiple: false
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
                    Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                    AllowMultiple: false
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
                    Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                    AllowMultiple: false
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
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE4 | UnrealCompatibility.UE5;
    
    
        public virtual IOSPostBuildSyncConfig Input(object val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Input",
                    Value: val?.ToString(),
                    Setter: '=',
                    Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                    AllowMultiple: false
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
                    Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                    AllowMultiple: false
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
        
/// <summary>&lt;summary&gt;
/// IOS-specific target settings
/// &lt;/summary&gt;</summary>
    public  class IOSTargetRulesConfig : ToolConfig
    {
        public override string Name => "IOSTargetRules";
        public override string CliName => "";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE4 | UnrealCompatibility.UE5;
    
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
                    Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                    AllowMultiple: false
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
                    Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                    AllowMultiple: false
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
                    Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                    AllowMultiple: false
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
                    Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                    AllowMultiple: false
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
                    Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                    AllowMultiple: false
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
                    Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                    AllowMultiple: false
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
                    Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                    AllowMultiple: false
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
                    Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                    AllowMultiple: false
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
                    Compatibility: UnrealCompatibility.UE5,
                    AllowMultiple: false
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
                    Compatibility: UnrealCompatibility.UE5,
                    AllowMultiple: false
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
                    Compatibility: UnrealCompatibility.UE5,
                    AllowMultiple: false
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
                    Compatibility: UnrealCompatibility.UE5,
                    AllowMultiple: false
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
        
/// <summary>&lt;summary&gt;
/// Stores project-specific IOS settings. Instances of this object are cached by IOSPlatform.
/// &lt;/summary&gt;</summary>
    public  class IOSProjectSettingsConfig : ToolConfig
    {
        public override string Name => "IOSProjectSettings";
        public override string CliName => "";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE4 | UnrealCompatibility.UE5;
    
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
                    Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                    AllowMultiple: false
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
                    Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                    AllowMultiple: false
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
                    Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                    AllowMultiple: false
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
        
/// <summary>&lt;summary&gt;
/// Linux-specific target settings
/// &lt;/summary&gt;</summary>
    public  class LinuxTargetRulesConfig : ToolConfig
    {
        public override string Name => "LinuxTargetRules";
        public override string CliName => "";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE4 | UnrealCompatibility.UE5;
    
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
                    Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                    AllowMultiple: false
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
                    Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                    AllowMultiple: false
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
                    Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                    AllowMultiple: false
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
                    Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                    AllowMultiple: false
                ));
            }
            return (LinuxTargetRulesConfig) this;
        }

        
/// <summary>
/// Enables "thin" LTO
/// </summary>
        public virtual LinuxTargetRulesConfig ThinLTO(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-ThinLTO",
                    Value: val?.ToString(),
                    Setter: '=',
                    Compatibility: UnrealCompatibility.UE4,
                    AllowMultiple: false
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
                    Compatibility: UnrealCompatibility.UE5,
                    AllowMultiple: false
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
        
/// <summary>&lt;summary&gt;&lt;/summary&gt;</summary>
    public  class LuminToolChainConfig : ToolConfig
    {
        public override string Name => "LuminToolChain";
        public override string CliName => "";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE4;
    
    
        public virtual LuminToolChainConfig GpuArchitectures(params object[] values)
        {
            if (true)
            {
                if (values != null)
                    foreach (var val in values)
                    {
                        AppendArgument(new UnrealToolArgument(
                            "-GpuArchitectures",
                            Value: val.ToString(),
                            Setter: '=',
                            Compatibility: UnrealCompatibility.UE4,
                            AllowMultiple: true
                        ));
                    }
            }
            return (LuminToolChainConfig) this;
        }
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    }

    protected readonly LuminToolChainConfig LuminToolChainStorage = new();
        
/// <summary>&lt;summary&gt;
/// Lumin-specific target settings
/// &lt;/summary&gt;</summary>
    public  class LuminTargetRulesConfig : ToolConfig
    {
        public override string Name => "LuminTargetRules";
        public override string CliName => "";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE4;
    
/// <summary>
/// Lists GPU Architectures that you want to build (mostly used for mobile etc.)
/// </summary>
        public virtual LuminTargetRulesConfig GPUArchitectures(params object[] values)
        {
            if (true)
            {
                if (values != null)
                    foreach (var val in values)
                    {
                        AppendArgument(new UnrealToolArgument(
                            "-GPUArchitectures",
                            Value: val.ToString(),
                            Setter: '=',
                            Compatibility: UnrealCompatibility.UE4,
                            AllowMultiple: true
                        ));
                    }
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
                    Compatibility: UnrealCompatibility.UE4,
                    AllowMultiple: false
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
        
/// <summary>&lt;summary&gt;
/// Mac-specific target settings
/// &lt;/summary&gt;</summary>
    public  class MacTargetRulesConfig : ToolConfig
    {
        public override string Name => "MacTargetRules";
        public override string CliName => "";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE4 | UnrealCompatibility.UE5;
    
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
                    Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                    AllowMultiple: false
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
                    Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                    AllowMultiple: false
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
                    Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                    AllowMultiple: false
                ));
            }
            return (MacTargetRulesConfig) this;
        }

        
/// <summary>
/// Enables the generation of .dsym files. This can be disabled to enable faster iteration times during development.
/// </summary>
        public virtual MacTargetRulesConfig EnableDSYM(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-EnableDSYM",
                    Value: null,
                    Setter: '=',
                    Compatibility: UnrealCompatibility.UE5,
                    AllowMultiple: false
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
                    Compatibility: UnrealCompatibility.UE5,
                    AllowMultiple: false
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
        
/// <summary>&lt;summary&gt;
/// Special mode for gathering all the messages into a single output file
/// &lt;/summary&gt;</summary>
    public  class PVSGatherConfig : ToolConfig
    {
        public override string Name => "PVSGather";
        public override string CliName => "-PVSGather";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE4 | UnrealCompatibility.UE5;
    
/// <summary>
/// Path to the input file list
/// </summary>
        public virtual PVSGatherConfig Input(object val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Input",
                    Value: val?.ToString(),
                    Setter: '=',
                    Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                    AllowMultiple: false
                ));
            }
            return (PVSGatherConfig) this;
        }

        
/// <summary>
/// Output file to generate
/// </summary>
        public virtual PVSGatherConfig Output(object val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Output",
                    Value: val?.ToString(),
                    Setter: '=',
                    Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                    AllowMultiple: false
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
        
/// <summary>&lt;summary&gt;
/// Windows-specific target settings
/// &lt;/summary&gt;</summary>
    public  class WindowsTargetRulesConfig : ToolConfig
    {
        public override string Name => "WindowsTargetRules";
        public override string CliName => "";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE4 | UnrealCompatibility.UE5;
    
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
                    Compatibility: UnrealCompatibility.UE4,
                    AllowMultiple: false
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
                    Compatibility: UnrealCompatibility.UE4,
                    AllowMultiple: false
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
                    Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                    AllowMultiple: false
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
                    Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                    AllowMultiple: false
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
                    Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                    AllowMultiple: false
                ));
            }
            return (WindowsTargetRulesConfig) this;
        }

        
/// <summary>
/// The specific toolchain version to use. This may be a specific version number (for example, "14.13.26128"), the string "Latest" to select the newest available version, or
/// the string "Preview" to select the newest available preview version. By default, and if it is available, we use the toolchain version indicated by
/// WindowsPlatform.DefaultToolChainVersion (otherwise, we use the latest version).
/// </summary>
        public virtual WindowsTargetRulesConfig CompilerVersion(object val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-CompilerVersion",
                    Value: val?.ToString(),
                    Setter: '=',
                    Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                    AllowMultiple: false
                ));
            }
            return (WindowsTargetRulesConfig) this;
        }

        
/// <summary>
/// The static analyzer to use.
/// </summary>
        public virtual WindowsTargetRulesConfig StaticAnalyzer(WindowsStaticAnalyzer? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-StaticAnalyzer",
                    Value: val?.ToString(),
                    Setter: '=',
                    Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                    AllowMultiple: false
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
                    Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                    AllowMultiple: false
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
                    Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                    AllowMultiple: false
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
                    Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                    AllowMultiple: false
                ));
            }
            return (WindowsTargetRulesConfig) this;
        }

        
/// <summary>
/// The output type to use for the static analyzer.
/// </summary>
        public virtual WindowsTargetRulesConfig StaticAnalyzerOutputType(WindowsStaticAnalyzerOutputType? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-StaticAnalyzerOutputType",
                    Value: val?.ToString(),
                    Setter: '=',
                    Compatibility: UnrealCompatibility.UE5,
                    AllowMultiple: false
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
                    Compatibility: UnrealCompatibility.UE5,
                    AllowMultiple: false
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
                    Compatibility: UnrealCompatibility.UE5,
                    AllowMultiple: false
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
                    Compatibility: UnrealCompatibility.UE5,
                    AllowMultiple: false
                ));
            }
            return (WindowsTargetRulesConfig) this;
        }

        
/// <summary>
/// Enables new preprocessor conformance (/Zc:preprocessor).
/// </summary>
        public virtual WindowsTargetRulesConfig StrictPreprocessor(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-StrictPreprocessor",
                    Value: val?.ToString(),
                    Setter: '=',
                    Compatibility: UnrealCompatibility.UE5,
                    AllowMultiple: false
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
                    Compatibility: UnrealCompatibility.UE5,
                    AllowMultiple: false
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
        
/// <summary>&lt;summary&gt;&lt;/summary&gt;</summary>
    public  class RiderProjectFileGeneratorConfig : ToolConfig
    {
        public override string Name => "RiderProjectFileGenerator";
        public override string CliName => "";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE4 | UnrealCompatibility.UE5;
    
/// <summary>
/// Platforms to generate project files for
/// </summary>
        public virtual RiderProjectFileGeneratorConfig Platforms(params object[] values)
        {
            if (true)
            {
                if (values != null)
                    foreach (var val in values)
                    {
                        AppendArgument(new UnrealToolArgument(
                            "-Platforms",
                            Value: val.ToString(),
                            Setter: '=',
                            Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                            AllowMultiple: true
                        ));
                    }
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
                if (values != null)
                    foreach (var val in values)
                    {
                        AppendArgument(new UnrealToolArgument(
                            "-TargetTypes",
                            Value: val.ToString(),
                            Setter: '=',
                            Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                            AllowMultiple: true
                        ));
                    }
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
                if (values != null)
                    foreach (var val in values)
                    {
                        AppendArgument(new UnrealToolArgument(
                            "-TargetConfigurations",
                            Value: val.ToString(),
                            Setter: '=',
                            Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                            AllowMultiple: true
                        ));
                    }
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
                if (values != null)
                    foreach (var val in values)
                    {
                        AppendArgument(new UnrealToolArgument(
                            "-ProjectNames",
                            Value: val.ToString(),
                            Setter: '=',
                            Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                            AllowMultiple: true
                        ));
                    }
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
                    Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                    AllowMultiple: false
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
                    Compatibility: UnrealCompatibility.UE5,
                    AllowMultiple: false
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
        
/// <summary>&lt;summary&gt;
/// Aggregates clang timing information files together into one monolithic breakdown file.
/// &lt;/summary&gt;</summary>
    public  class AggregateClangTimingInfoConfig : ToolConfig
    {
        public override string Name => "AggregateClangTimingInfo";
        public override string CliName => "-AggregateClangTimingInfo";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE5;
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    }

    protected readonly AggregateClangTimingInfoConfig AggregateClangTimingInfoStorage = new();
        
/// <summary>&lt;summary&gt;
/// Outputs information about the given target, including a module dependecy graph (in .gefx format and list of module references)
/// &lt;/summary&gt;</summary>
    public  class AnalyzeConfig : ToolConfig
    {
        public override string Name => "Analyze";
        public override string CliName => "-Analyze";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE5;
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    }

    protected readonly AnalyzeConfig AnalyzeStorage = new();
        
/// <summary>&lt;summary&gt;
/// Fixes the include paths found in a header and source file
/// &lt;/summary&gt;</summary>
    public  class FixIncludePathsConfig : ToolConfig
    {
        public override string Name => "FixIncludePaths";
        public override string CliName => "-FixIncludePaths";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE5;
    
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
                            Compatibility: UnrealCompatibility.UE5,
                            AllowMultiple: true
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
                    Compatibility: UnrealCompatibility.UE5,
                    AllowMultiple: false
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
                    Compatibility: UnrealCompatibility.UE5,
                    AllowMultiple: false
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
                    Compatibility: UnrealCompatibility.UE5,
                    AllowMultiple: false
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
        
/// <summary>&lt;summary&gt;
/// Generate a clang compile_commands file for a target
/// &lt;/summary&gt;</summary>
    public  class InlineGeneratedCppsConfig : ToolConfig
    {
        public override string Name => "InlineGeneratedCpps";
        public override string CliName => "-InlineGeneratedCpps";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE5;
    
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
                            Compatibility: UnrealCompatibility.UE5,
                            AllowMultiple: true
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
                    Compatibility: UnrealCompatibility.UE5,
                    AllowMultiple: false
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
                    Compatibility: UnrealCompatibility.UE5,
                    AllowMultiple: false
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
        
/// <summary>&lt;summary&gt;
/// Generate a clang compile_commands file for a target
/// &lt;/summary&gt;</summary>
    public  class PrintBuildGraphInfoConfig : ToolConfig
    {
        public override string Name => "PrintBuildGraphInfo";
        public override string CliName => "-PrintBuildGraphInfo";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE5;
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    }

    protected readonly PrintBuildGraphInfoConfig PrintBuildGraphInfoStorage = new();
        
/// <summary>&lt;summary&gt;
/// Builds low level tests on one or more targets.
/// &lt;/summary&gt;</summary>
    public  class TestConfig : ToolConfig
    {
        public override string Name => "Test";
        public override string CliName => "-Test";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE5;
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    }

    protected readonly TestConfig TestStorage = new();
        
/// <summary>&lt;summary&gt;
/// Global options for UBT (any modes)
/// &lt;/summary&gt;</summary>
    public  class UhtGlobalOptionsConfig : ToolConfig
    {
        public override string Name => "UhtGlobalOptions";
        public override string CliName => "";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE5;
    
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
                    Compatibility: UnrealCompatibility.UE5,
                    AllowMultiple: false
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
                    Compatibility: UnrealCompatibility.UE5,
                    AllowMultiple: false
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
                    Compatibility: UnrealCompatibility.UE5,
                    AllowMultiple: false
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
                    Compatibility: UnrealCompatibility.UE5,
                    AllowMultiple: false
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
                    Compatibility: UnrealCompatibility.UE5,
                    AllowMultiple: false
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
                    Compatibility: UnrealCompatibility.UE5,
                    AllowMultiple: false
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
                    Compatibility: UnrealCompatibility.UE5,
                    AllowMultiple: false
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
                    Compatibility: UnrealCompatibility.UE5,
                    AllowMultiple: false
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
                    Compatibility: UnrealCompatibility.UE5,
                    AllowMultiple: false
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
                    Compatibility: UnrealCompatibility.UE5,
                    AllowMultiple: false
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
                    Compatibility: UnrealCompatibility.UE5,
                    AllowMultiple: false
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
                    Compatibility: UnrealCompatibility.UE5,
                    AllowMultiple: false
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
                    Compatibility: UnrealCompatibility.UE5,
                    AllowMultiple: false
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
                    Compatibility: UnrealCompatibility.UE5,
                    AllowMultiple: false
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
                    Compatibility: UnrealCompatibility.UE5,
                    AllowMultiple: false
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
        
/// <summary>&lt;summary&gt;
/// Invoke UHT
/// &lt;/summary&gt;</summary>
    public  class UnrealHeaderToolConfig : ToolConfig
    {
        public override string Name => "UnrealHeaderTool";
        public override string CliName => "-UnrealHeaderTool";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE5;
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    }

    protected readonly UnrealHeaderToolConfig UnrealHeaderToolStorage = new();

    private ToolConfig[] _configs = null;
    protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
    {
        UnrealBuildToolStorage,
                GlobalOptionsStorage,
                BuildConfigurationStorage,
                TargetDescriptorStorage,
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
                AggregateClangTimingInfoStorage,
                AnalyzeStorage,
                FixIncludePathsStorage,
                InlineGeneratedCppsStorage,
                PrintBuildGraphInfoStorage,
                TestStorage,
                UhtGlobalOptionsStorage,
                UnrealHeaderToolStorage,
            };
/// <summary>&lt;summary&gt;&lt;/summary&gt;</summary>
    public UbtConfig UnrealBuildTool(Action<UnrealBuildToolConfig> configurator)
    {
        configurator?.Invoke(UnrealBuildToolStorage);
        AppendSubtool(UnrealBuildToolStorage);
        return (UbtConfig) this;
    }
/// <summary>&lt;summary&gt;
/// Global options for UBT (any modes)
/// &lt;/summary&gt;</summary>
    public UbtConfig GlobalOptions(Action<GlobalOptionsConfig> configurator)
    {
        configurator?.Invoke(GlobalOptionsStorage);
        AppendSubtool(GlobalOptionsStorage);
        return (UbtConfig) this;
    }
/// <summary>&lt;summary&gt;
/// Global settings for building. Should not contain any target-specific settings.
/// &lt;/summary&gt;</summary>
    public UbtConfig BuildConfiguration(Action<BuildConfigurationConfig> configurator)
    {
        configurator?.Invoke(BuildConfigurationStorage);
        AppendSubtool(BuildConfigurationStorage);
        return (UbtConfig) this;
    }
/// <summary>&lt;summary&gt;
/// Describes all of the information needed to initialize a UEBuildTarget object
/// &lt;/summary&gt;</summary>
    public UbtConfig TargetDescriptor(Action<TargetDescriptorConfig> configurator)
    {
        configurator?.Invoke(TargetDescriptorStorage);
        AppendSubtool(TargetDescriptorStorage);
        return (UbtConfig) this;
    }
/// <summary>&lt;summary&gt;
/// Aggregates parsed Visual C++ timing information files together into one monolithic breakdown file.
/// &lt;/summary&gt;
/// &lt;summary&gt;
/// Aggregates parsed Visual C++ timing information files together into one monolithic breakdown file.
/// &lt;/summary&gt;</summary>
    public UbtConfig AggregateParsedTimingInfo(Action<AggregateParsedTimingInfoConfig> configurator)
    {
        configurator?.Invoke(AggregateParsedTimingInfoStorage);
        AppendSubtool(AggregateParsedTimingInfoStorage);
        return (UbtConfig) this;
    }
/// <summary>&lt;summary&gt;
/// Builds a target
/// &lt;/summary&gt;</summary>
    public UbtConfig Build(Action<BuildConfig> configurator)
    {
        configurator?.Invoke(BuildStorage);
        AppendSubtool(BuildStorage);
        return (UbtConfig) this;
    }
/// <summary>&lt;summary&gt;
/// Cleans build products and intermediates for the target. This deletes files which are named consistently with the target being built
/// (e.g. UE4Editor-Foo-Win64-Debug.dll) rather than an actual record of previous build products.
/// &lt;/summary&gt;
/// &lt;summary&gt;
/// Cleans build products and intermediates for the target. This deletes files which are named consistently with the target being built
/// (e.g. UnrealEditor-Foo-Win64-Debug.dll) rather than an actual record of previous build products.
/// &lt;/summary&gt;</summary>
    public UbtConfig Clean(Action<CleanConfig> configurator)
    {
        configurator?.Invoke(CleanStorage);
        AppendSubtool(CleanStorage);
        return (UbtConfig) this;
    }
/// <summary>&lt;summary&gt;
/// Invokes the deployment handler for a target.
/// &lt;/summary&gt;</summary>
    public UbtConfig Deploy(Action<DeployConfig> configurator)
    {
        configurator?.Invoke(DeployStorage);
        AppendSubtool(DeployStorage);
        return (UbtConfig) this;
    }
/// <summary>&lt;summary&gt;
/// Builds a target
/// &lt;/summary&gt;</summary>
    public UbtConfig Execute(Action<ExecuteConfig> configurator)
    {
        configurator?.Invoke(ExecuteStorage);
        AppendSubtool(ExecuteStorage);
        return (UbtConfig) this;
    }
/// <summary>&lt;summary&gt;
/// Generate a clang compile_commands file for a target
/// &lt;/summary&gt;</summary>
    public UbtConfig GenerateClangDatabase(Action<GenerateClangDatabaseConfig> configurator)
    {
        configurator?.Invoke(GenerateClangDatabaseStorage);
        AppendSubtool(GenerateClangDatabaseStorage);
        return (UbtConfig) this;
    }
/// <summary>&lt;summary&gt;
/// Generates project files for one or more projects
/// &lt;/summary&gt;</summary>
    public UbtConfig GenerateProjectFiles(Action<GenerateProjectFilesConfig> configurator)
    {
        configurator?.Invoke(GenerateProjectFilesStorage);
        AppendSubtool(GenerateProjectFilesStorage);
        return (UbtConfig) this;
    }
/// <summary>&lt;summary&gt;
/// Exports a target as a JSON file
/// &lt;/summary&gt;</summary>
    public UbtConfig JsonExport(Action<JsonExportConfig> configurator)
    {
        configurator?.Invoke(JsonExportStorage);
        AppendSubtool(JsonExportStorage);
        return (UbtConfig) this;
    }
/// <summary>&lt;summary&gt;
/// Parses an MSVC timing info file generated from cl-filter to turn it into a form that can be used by other tooling.
/// This is implemented as a separate mode to allow it to be done as part of the action graph.
/// &lt;/summary&gt;
/// &lt;summary&gt;
/// Parses an MSVC timing info file generated from cl-filter to turn it into a form that can be used by other tooling.
/// This is implemented as a separate mode to allow it to be done as part of the action graph.
/// &lt;/summary&gt;</summary>
    public UbtConfig ParseMsvcTimingInfo(Action<ParseMsvcTimingInfoConfig> configurator)
    {
        configurator?.Invoke(ParseMsvcTimingInfoStorage);
        AppendSubtool(ParseMsvcTimingInfoStorage);
        return (UbtConfig) this;
    }
/// <summary>&lt;summary&gt;
/// Queries information about the targets supported by a project
/// &lt;/summary&gt;</summary>
    public UbtConfig QueryTargets(Action<QueryTargetsConfig> configurator)
    {
        configurator?.Invoke(QueryTargetsStorage);
        AppendSubtool(QueryTargetsStorage);
        return (UbtConfig) this;
    }
/// <summary>&lt;summary&gt;
/// Register all platforms (and in the process, configure all autosdks)
/// &lt;/summary&gt;</summary>
    public UbtConfig SetupPlatforms(Action<SetupPlatformsConfig> configurator)
    {
        configurator?.Invoke(SetupPlatformsStorage);
        AppendSubtool(SetupPlatformsStorage);
        return (UbtConfig) this;
    }
/// <summary>&lt;summary&gt;
/// Validates the various platforms to determine if they are ready for building
/// &lt;/summary&gt;</summary>
    public UbtConfig ValidatePlatforms(Action<ValidatePlatformsConfig> configurator)
    {
        configurator?.Invoke(ValidatePlatformsStorage);
        AppendSubtool(ValidatePlatformsStorage);
        return (UbtConfig) this;
    }
/// <summary>&lt;summary&gt;
/// Generates documentation from reflection data
/// &lt;/summary&gt;</summary>
    public UbtConfig WriteDocumentation(Action<WriteDocumentationConfig> configurator)
    {
        configurator?.Invoke(WriteDocumentationStorage);
        AppendSubtool(WriteDocumentationStorage);
        return (UbtConfig) this;
    }
/// <summary>&lt;summary&gt;
/// Writes all metadata files at the end of a build (receipts, version files, etc...). This is implemented as a separate mode to allow it to be done as part of the action graph.
/// &lt;/summary&gt;</summary>
    public UbtConfig WriteMetadata(Action<WriteMetadataConfig> configurator)
    {
        configurator?.Invoke(WriteMetadataStorage);
        AppendSubtool(WriteMetadataStorage);
        return (UbtConfig) this;
    }
/// <summary>&lt;summary&gt;&lt;/summary&gt;</summary>
    public UbtConfig AndroidToolChain(Action<AndroidToolChainConfig> configurator)
    {
        configurator?.Invoke(AndroidToolChainStorage);
        AppendSubtool(AndroidToolChainStorage);
        return (UbtConfig) this;
    }
/// <summary>&lt;summary&gt;
/// Android-specific target settings
/// &lt;/summary&gt;</summary>
    public UbtConfig AndroidTargetRules(Action<AndroidTargetRulesConfig> configurator)
    {
        configurator?.Invoke(AndroidTargetRulesStorage);
        AppendSubtool(AndroidTargetRulesStorage);
        return (UbtConfig) this;
    }
/// <summary>&lt;summary&gt;&lt;/summary&gt;</summary>
    public UbtConfig UEDeployAndroid(Action<UEDeployAndroidConfig> configurator)
    {
        configurator?.Invoke(UEDeployAndroidStorage);
        AppendSubtool(UEDeployAndroidStorage);
        return (UbtConfig) this;
    }
/// <summary>&lt;summary&gt;
/// HoloLens-specific target settings
/// &lt;/summary&gt;</summary>
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
/// <summary>&lt;summary&gt;
/// IOS-specific target settings
/// &lt;/summary&gt;</summary>
    public UbtConfig IOSTargetRules(Action<IOSTargetRulesConfig> configurator)
    {
        configurator?.Invoke(IOSTargetRulesStorage);
        AppendSubtool(IOSTargetRulesStorage);
        return (UbtConfig) this;
    }
/// <summary>&lt;summary&gt;
/// Stores project-specific IOS settings. Instances of this object are cached by IOSPlatform.
/// &lt;/summary&gt;</summary>
    public UbtConfig IOSProjectSettings(Action<IOSProjectSettingsConfig> configurator)
    {
        configurator?.Invoke(IOSProjectSettingsStorage);
        AppendSubtool(IOSProjectSettingsStorage);
        return (UbtConfig) this;
    }
/// <summary>&lt;summary&gt;
/// Linux-specific target settings
/// &lt;/summary&gt;</summary>
    public UbtConfig LinuxTargetRules(Action<LinuxTargetRulesConfig> configurator)
    {
        configurator?.Invoke(LinuxTargetRulesStorage);
        AppendSubtool(LinuxTargetRulesStorage);
        return (UbtConfig) this;
    }
/// <summary>&lt;summary&gt;&lt;/summary&gt;</summary>
    public UbtConfig LuminToolChain(Action<LuminToolChainConfig> configurator)
    {
        configurator?.Invoke(LuminToolChainStorage);
        AppendSubtool(LuminToolChainStorage);
        return (UbtConfig) this;
    }
/// <summary>&lt;summary&gt;
/// Lumin-specific target settings
/// &lt;/summary&gt;</summary>
    public UbtConfig LuminTargetRules(Action<LuminTargetRulesConfig> configurator)
    {
        configurator?.Invoke(LuminTargetRulesStorage);
        AppendSubtool(LuminTargetRulesStorage);
        return (UbtConfig) this;
    }
/// <summary>&lt;summary&gt;
/// Mac-specific target settings
/// &lt;/summary&gt;</summary>
    public UbtConfig MacTargetRules(Action<MacTargetRulesConfig> configurator)
    {
        configurator?.Invoke(MacTargetRulesStorage);
        AppendSubtool(MacTargetRulesStorage);
        return (UbtConfig) this;
    }
/// <summary>&lt;summary&gt;
/// Special mode for gathering all the messages into a single output file
/// &lt;/summary&gt;</summary>
    public UbtConfig PVSGather(Action<PVSGatherConfig> configurator)
    {
        configurator?.Invoke(PVSGatherStorage);
        AppendSubtool(PVSGatherStorage);
        return (UbtConfig) this;
    }
/// <summary>&lt;summary&gt;
/// Windows-specific target settings
/// &lt;/summary&gt;</summary>
    public UbtConfig WindowsTargetRules(Action<WindowsTargetRulesConfig> configurator)
    {
        configurator?.Invoke(WindowsTargetRulesStorage);
        AppendSubtool(WindowsTargetRulesStorage);
        return (UbtConfig) this;
    }
/// <summary>&lt;summary&gt;&lt;/summary&gt;</summary>
    public UbtConfig RiderProjectFileGenerator(Action<RiderProjectFileGeneratorConfig> configurator)
    {
        configurator?.Invoke(RiderProjectFileGeneratorStorage);
        AppendSubtool(RiderProjectFileGeneratorStorage);
        return (UbtConfig) this;
    }
/// <summary>&lt;summary&gt;
/// Aggregates clang timing information files together into one monolithic breakdown file.
/// &lt;/summary&gt;</summary>
    public UbtConfig AggregateClangTimingInfo(Action<AggregateClangTimingInfoConfig> configurator)
    {
        configurator?.Invoke(AggregateClangTimingInfoStorage);
        AppendSubtool(AggregateClangTimingInfoStorage);
        return (UbtConfig) this;
    }
/// <summary>&lt;summary&gt;
/// Outputs information about the given target, including a module dependecy graph (in .gefx format and list of module references)
/// &lt;/summary&gt;</summary>
    public UbtConfig Analyze(Action<AnalyzeConfig> configurator)
    {
        configurator?.Invoke(AnalyzeStorage);
        AppendSubtool(AnalyzeStorage);
        return (UbtConfig) this;
    }
/// <summary>&lt;summary&gt;
/// Fixes the include paths found in a header and source file
/// &lt;/summary&gt;</summary>
    public UbtConfig FixIncludePaths(Action<FixIncludePathsConfig> configurator)
    {
        configurator?.Invoke(FixIncludePathsStorage);
        AppendSubtool(FixIncludePathsStorage);
        return (UbtConfig) this;
    }
/// <summary>&lt;summary&gt;
/// Generate a clang compile_commands file for a target
/// &lt;/summary&gt;</summary>
    public UbtConfig InlineGeneratedCpps(Action<InlineGeneratedCppsConfig> configurator)
    {
        configurator?.Invoke(InlineGeneratedCppsStorage);
        AppendSubtool(InlineGeneratedCppsStorage);
        return (UbtConfig) this;
    }
/// <summary>&lt;summary&gt;
/// Generate a clang compile_commands file for a target
/// &lt;/summary&gt;</summary>
    public UbtConfig PrintBuildGraphInfo(Action<PrintBuildGraphInfoConfig> configurator)
    {
        configurator?.Invoke(PrintBuildGraphInfoStorage);
        AppendSubtool(PrintBuildGraphInfoStorage);
        return (UbtConfig) this;
    }
/// <summary>&lt;summary&gt;
/// Builds low level tests on one or more targets.
/// &lt;/summary&gt;</summary>
    public UbtConfig Test(Action<TestConfig> configurator)
    {
        configurator?.Invoke(TestStorage);
        AppendSubtool(TestStorage);
        return (UbtConfig) this;
    }
/// <summary>&lt;summary&gt;
/// Global options for UBT (any modes)
/// &lt;/summary&gt;</summary>
    public UbtConfig UhtGlobalOptions(Action<UhtGlobalOptionsConfig> configurator)
    {
        configurator?.Invoke(UhtGlobalOptionsStorage);
        AppendSubtool(UhtGlobalOptionsStorage);
        return (UbtConfig) this;
    }
/// <summary>&lt;summary&gt;
/// Invoke UHT
/// &lt;/summary&gt;</summary>
    public UbtConfig UnrealHeaderTool(Action<UnrealHeaderToolConfig> configurator)
    {
        configurator?.Invoke(UnrealHeaderToolStorage);
        AppendSubtool(UnrealHeaderToolStorage);
        return (UbtConfig) this;
    }
}
