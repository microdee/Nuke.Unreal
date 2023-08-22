
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


public enum QueryType
{
    
    Capabilities,
    
    AvailableTargets,
    
    TargetDetails,
}


/// <summary>Unreal Build Tool defines the Unreal project structure and provides unified source building utilities over multiple platforms</summary>
public abstract class UbtConfigGenerated : ToolConfig
{
    public override string Name => "Ubt";
    public override string CliName => "";
    public override UnrealCompatibility Compatibility => UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest;
    
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
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
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
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
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
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
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
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
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
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
                                Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
                                Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
                if (values != null)
                    foreach (var val in values)
                    {
                        AppendArgument(new UnrealToolArgument(
                            "-Architectures",
                            Value: val.ToString(),
                            Setter: '=',
                            Meta: new(
                                Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1,
                                AllowMultiple: true
                            )
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
                            Meta: new(
                                Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1,
                                AllowMultiple: true
                            )
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
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
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
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4,
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
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
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
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2,
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
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
                if (values != null)
                    foreach (var val in values)
                    {
                        AppendArgument(new UnrealToolArgument(
                            "-Platforms",
                            Value: val.ToString(),
                            Setter: '=',
                            Meta: new(
                                Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
                                AllowMultiple: true
                            )
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
                            Meta: new(
                                Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
                                AllowMultiple: true
                            )
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
                            Meta: new(
                                Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
                                AllowMultiple: true
                            )
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
                            Meta: new(
                                Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
                                AllowMultiple: true
                            )
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
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
                        Compatibility: UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
                        Compatibility: UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
                        Compatibility: UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
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
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
                        Compatibility: UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
                                Compatibility: UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
                                Compatibility: UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
                        Compatibility: UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
                        Compatibility: UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
                        Compatibility: UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
                        Compatibility: UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
                        Compatibility: UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

        
/// <summary>
/// Set flags require for determinstic compiles (experimental)
/// </summary>
        public virtual UbtConfig Deterministic(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Deterministic",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_0,
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
                        Compatibility: UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
                        Compatibility: UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
                        Compatibility: UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
                        Compatibility: UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
                        Compatibility: UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
                        Compatibility: UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
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
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
                        Compatibility: UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
                        Compatibility: UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
                        Compatibility: UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
                        Compatibility: UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
                        Compatibility: UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
                        Compatibility: UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
                        Compatibility: UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
                        Compatibility: UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
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
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
                        Compatibility: UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
                        Compatibility: UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
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
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
                        Compatibility: UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
                        Compatibility: UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

        
/// <summary>
/// True if we should use the Clang linker (LLD) when we are compiling with Clang, or Intel linker (xilink\xilib) when we are compiling with Intel oneAPI, otherwise we use the MSVC linker.
/// </summary>
        public virtual UbtConfig ClangLinker(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-ClangLinker",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
                        Compatibility: UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
                        Compatibility: UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
                        Compatibility: UnrealCompatibility.UE_5_Latest,
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
                        Compatibility: UnrealCompatibility.UE_5_Latest,
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
                        Compatibility: UnrealCompatibility.UE_5_Latest,
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
                        Compatibility: UnrealCompatibility.UE_5_Latest,
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
                        Compatibility: UnrealCompatibility.UE_5_Latest,
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
                        Compatibility: UnrealCompatibility.UE_5_Latest,
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
                        Compatibility: UnrealCompatibility.UE_5_Latest,
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
                        Compatibility: UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (UbtConfig) this;
        }

        
/// <summary>
/// Enables "include what you use" mode.
/// </summary>
        public virtual UbtConfig IWYU(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-IWYU",
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
                        Compatibility: UnrealCompatibility.UE_5_Latest,
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
                if (values != null)
                    foreach (var val in values)
                    {
                        AppendArgument(new UnrealToolArgument(
                            "-Files",
                            Value: val.ToString(),
                            Setter: '=',
                            Meta: new(
                                Compatibility: UnrealCompatibility.UE_5_Latest,
                                AllowMultiple: true
                            )
                        ));
                    }
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
                        Compatibility: UnrealCompatibility.UE_5_Latest,
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
                        Compatibility: UnrealCompatibility.UE_5_Latest,
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
                        Compatibility: UnrealCompatibility.UE_5_Latest,
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
                        Compatibility: UnrealCompatibility.UE_5_Latest,
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
                        Compatibility: UnrealCompatibility.UE_5_Latest,
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
                        Compatibility: UnrealCompatibility.UE_5_Latest,
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
                        Compatibility: UnrealCompatibility.UE_5_Latest,
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
                        Compatibility: UnrealCompatibility.UE_5_Latest,
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
                        Compatibility: UnrealCompatibility.UE_5_Latest,
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
                        Compatibility: UnrealCompatibility.UE_5_Latest,
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
                        Compatibility: UnrealCompatibility.UE_5_Latest,
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
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest;
    
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
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest;
    
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
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
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
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
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
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
                        Compatibility: UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
                        Compatibility: UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
                        Compatibility: UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest;
    
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
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
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
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
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
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
                        Compatibility: UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
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
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
                        Compatibility: UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
                        Compatibility: UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
                        Compatibility: UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
                        Compatibility: UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
                        Compatibility: UnrealCompatibility.UE_5_Latest,
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
                        Compatibility: UnrealCompatibility.UE_5_Latest,
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
                        Compatibility: UnrealCompatibility.UE_5_Latest,
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
                        Compatibility: UnrealCompatibility.UE_5_Latest,
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
                        Compatibility: UnrealCompatibility.UE_5_Latest,
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
                        Compatibility: UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (BuildConfigurationConfig) this;
        }

        
/// <summary>
/// Whether to unify C++ code into larger files for faster compilation.
/// </summary>
        public virtual BuildConfigurationConfig DisableUnity(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-DisableUnity",
                    Value: null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (BuildConfigurationConfig) this;
        }

        
/// <summary>
/// Whether to force C++ source files to be combined into larger files for faster compilation.
/// </summary>
        public virtual BuildConfigurationConfig ForceUnity(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-ForceUnity",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (BuildConfigurationConfig) this;
        }

        
/// <summary>
/// Enables "include what you use" mode.
/// </summary>
        public virtual BuildConfigurationConfig IWYU(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-IWYU",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_Latest,
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
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest;
    
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
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
                                Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
                                Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
                                Compatibility: UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
                                Compatibility: UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
                        Compatibility: UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
                        Compatibility: UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
                        Compatibility: UnrealCompatibility.UE_5_Latest,
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
                if (values != null)
                    foreach (var val in values)
                    {
                        AppendArgument(new UnrealToolArgument(
                            "-Files",
                            Value: val.ToString(),
                            Setter: '=',
                            Meta: new(
                                Compatibility: UnrealCompatibility.UE_5_Latest,
                                AllowMultiple: true
                            )
                        ));
                    }
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
                        Compatibility: UnrealCompatibility.UE_5_Latest,
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
                        Compatibility: UnrealCompatibility.UE_5_Latest,
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
/// Aggregates parsed Visual C++ timing information files together into one monolithic breakdown file.
/// </summary>
/// <summary>
/// Aggregates parsed Visual C++ timing information files together into one monolithic breakdown file.
/// </summary>
    public  class AggregateParsedTimingInfoConfig : ToolConfig
    {
        public override string Name => "AggregateParsedTimingInfo";
        public override string CliName => "-AggregateParsedTimingInfo";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest;
    
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
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest;
    
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
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
                        Compatibility: UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest;
    
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
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest;
    
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
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest;
    
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
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest;
    
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
                                Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
                        Compatibility: UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest;
    
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
                                Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
                                Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
                                Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
                                Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
                                Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
                                Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
                                Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
                                Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
                                Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
                                Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
                                Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
                                Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
                                Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
                                Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
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
        
/// <summary>
/// Exports a target as a JSON file
/// </summary>
    public  class JsonExportConfig : ToolConfig
    {
        public override string Name => "JsonExport";
        public override string CliName => "-JsonExport";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest;
    
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
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest;
    
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
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest;
    
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
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
                        Compatibility: UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest;
    
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
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest;
    
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
                            Meta: new(
                                Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
                                AllowMultiple: true
                            )
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
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest;
    
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
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
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
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest;
    
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
                if (values != null)
                    foreach (var val in values)
                    {
                        AppendArgument(new UnrealToolArgument(
                            "-Architectures",
                            Value: val.ToString(),
                            Setter: '=',
                            Meta: new(
                                Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1,
                                AllowMultiple: true
                            )
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
        
/// <summary>
/// Android-specific target settings
/// </summary>
    public  class AndroidTargetRulesConfig : ToolConfig
    {
        public override string Name => "AndroidTargetRules";
        public override string CliName => "";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest;
    
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
                            Meta: new(
                                Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1,
                                AllowMultiple: true
                            )
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
                            Meta: new(
                                Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1,
                                AllowMultiple: true
                            )
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
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
                        Compatibility: UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
                        Compatibility: UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
                        Compatibility: UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest;
    
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
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
                        Compatibility: UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest;
    
    
        public virtual IOSPostBuildSyncConfig Input(object val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Input",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest;
    
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
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
                        Compatibility: UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
                        Compatibility: UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
                        Compatibility: UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
                        Compatibility: UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest;
    
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
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest;
    
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
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
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
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4,
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
                        Compatibility: UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
                        Compatibility: UnrealCompatibility.UE_5_Latest,
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
                        Compatibility: UnrealCompatibility.UE_5_Latest,
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
                if (values != null)
                    foreach (var val in values)
                    {
                        AppendArgument(new UnrealToolArgument(
                            "-GpuArchitectures",
                            Value: val.ToString(),
                            Setter: '=',
                            Meta: new(
                                Compatibility: UnrealCompatibility.UE_4,
                                AllowMultiple: true
                            )
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
                if (values != null)
                    foreach (var val in values)
                    {
                        AppendArgument(new UnrealToolArgument(
                            "-GPUArchitectures",
                            Value: val.ToString(),
                            Setter: '=',
                            Meta: new(
                                Compatibility: UnrealCompatibility.UE_4,
                                AllowMultiple: true
                            )
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
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest;
    
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
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
                        Compatibility: UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
                        Compatibility: UnrealCompatibility.UE_5_Latest,
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
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest;
    
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
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
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
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest;
    
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
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
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
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2,
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
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
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
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2,
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
                        Compatibility: UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (WindowsTargetRulesConfig) this;
        }

        
/// <summary>
/// Set flags require for determinstic compiles (experimental)
/// </summary>
        public virtual WindowsTargetRulesConfig Deterministic(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Deterministic",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_0,
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
                        Compatibility: UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
                        Compatibility: UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
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
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
                        Compatibility: UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (WindowsTargetRulesConfig) this;
        }

        
/// <summary>
/// True if we should use the Clang linker (LLD) when we are compiling with Clang, or Intel linker (xilink\xilib) when we are compiling with Intel oneAPI, otherwise we use the MSVC linker.
/// </summary>
        public virtual WindowsTargetRulesConfig ClangLinker(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-ClangLinker",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
                        Compatibility: UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
                        Compatibility: UnrealCompatibility.UE_5_Latest,
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
                        Compatibility: UnrealCompatibility.UE_5_Latest,
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
                        Compatibility: UnrealCompatibility.UE_5_Latest,
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
                        Compatibility: UnrealCompatibility.UE_5_Latest,
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
                        Compatibility: UnrealCompatibility.UE_5_Latest,
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
                        Compatibility: UnrealCompatibility.UE_5_Latest,
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
                        Compatibility: UnrealCompatibility.UE_5_Latest,
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
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest;
    
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
                            Meta: new(
                                Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
                                AllowMultiple: true
                            )
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
                            Meta: new(
                                Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
                                AllowMultiple: true
                            )
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
                            Meta: new(
                                Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
                                AllowMultiple: true
                            )
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
                            Meta: new(
                                Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
                                AllowMultiple: true
                            )
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
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_4 | UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
                        Compatibility: UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE_5_0 | UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest;
    
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
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest;
    
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
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest;
    
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
                                Compatibility: UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
                        Compatibility: UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
                        Compatibility: UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
                        Compatibility: UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
                                Compatibility: UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
                                AllowMultiple: true
                            )
                        ));
                    }
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
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest;
    
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
                                Compatibility: UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
                        Compatibility: UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
                        Compatibility: UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest;
    
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
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest;
    
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
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest;
    
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
                        Compatibility: UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
                        Compatibility: UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
                        Compatibility: UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
                        Compatibility: UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
                        Compatibility: UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
                        Compatibility: UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
                        Compatibility: UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
                        Compatibility: UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
                        Compatibility: UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
                        Compatibility: UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
                        Compatibility: UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
                        Compatibility: UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
                        Compatibility: UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
                        Compatibility: UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
                        Compatibility: UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE_5_1 | UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest;
    
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
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest;
    
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
                        Compatibility: UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
                        Compatibility: UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
                        Compatibility: UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
                        Compatibility: UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
                        Compatibility: UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
                        Compatibility: UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
                        Compatibility: UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
                        Compatibility: UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
                        Compatibility: UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
                        Compatibility: UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
                        Compatibility: UnrealCompatibility.UE_5_Latest,
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
                        Compatibility: UnrealCompatibility.UE_5_Latest,
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
                        Compatibility: UnrealCompatibility.UE_5_Latest,
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
                        Compatibility: UnrealCompatibility.UE_5_Latest,
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
                        Compatibility: UnrealCompatibility.UE_5_Latest,
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
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest;
    
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
                                Compatibility: UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest;
    
    
        public virtual ServerConfig LogDirectory(object val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-LogDirectory",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest;
    
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
                        Compatibility: UnrealCompatibility.UE_5_2 | UnrealCompatibility.UE_5_Latest,
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
                        Compatibility: UnrealCompatibility.UE_5_Latest,
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
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE_5_Latest;
    
    
        public virtual ClReproConfig InputCpp(object val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-InputCpp",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_Latest,
                        AllowMultiple: false
                    )
                ));
            }
            return (ClReproConfig) this;
        }

        
    
        public virtual ClReproConfig OutputDir(object val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-OutputDir",
                    Value: val?.ToString(),
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE_5_Latest,
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
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE_5_Latest;
    
    
        public virtual QueryConfig LogDirectory(object val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-LogDirectory",
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

        
    
        public virtual QueryConfig Query(QueryType? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Query",
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

        
    
        public virtual QueryConfig IncludeEngineSource(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-IncludeEngineSource",
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

        
    
        public virtual QueryConfig Target(object val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Target",
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

        
    
        public virtual QueryConfig Configuration(object val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Configuration",
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

        
    
        public virtual QueryConfig Platform(object val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Platform",
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

        
    
        public virtual QueryConfig Indented(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Indented",
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
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE_5_Latest;
    
    
        public virtual ApplePostBuildSyncConfig Input(object val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Input",
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

        
    
        public virtual ApplePostBuildSyncConfig XmlConfigCache(object val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-XmlConfigCache",
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

        
    
        public virtual ApplePostBuildSyncConfig ModernXcode(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-ModernXcode",
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
}
