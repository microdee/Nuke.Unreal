

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace Nuke.Unreal.Tools;






/// <summary>
/// Unreal Build Tool compiles the binaries of Unreal projects
/// </summary>
public abstract class UnrealBuildToolConfigGenerated : ToolConfig
{
    public override string Name => "UnrealBuildTool";


    
        
/// <summary>
/// Enables address sanitizer (ASan).
/// </summary>
        public UnrealBuildToolConfig EnableASan(bool? val = null)
        {
            AppendArgument(val == null ? "-EnableASan" : "-EnableASan=" + val.ToString());
            return (UnrealBuildToolConfig) this;
        }

    
    
        
/// <summary>
/// Enables thread sanitizer (TSan).
/// </summary>
        public UnrealBuildToolConfig EnableTSan(bool? val = null)
        {
            AppendArgument(val == null ? "-EnableTSan" : "-EnableTSan=" + val.ToString());
            return (UnrealBuildToolConfig) this;
        }

    
    
        
/// <summary>
/// Enables undefined behavior sanitizer (UBSan).
/// </summary>
        public UnrealBuildToolConfig EnableUBSan(bool? val = null)
        {
            AppendArgument(val == null ? "-EnableUBSan" : "-EnableUBSan=" + val.ToString());
            return (UnrealBuildToolConfig) this;
        }

    
    
        
/// <summary>
/// Whether to skip checking for files identified by the junk manifest.
/// </summary>
        public UnrealBuildToolConfig IgnoreJunk(bool? val = null)
        {
            AppendArgument(val == null ? "-IgnoreJunk" : "-IgnoreJunk=" + val.ToString());
            return (UnrealBuildToolConfig) this;
        }

    
    
        
/// <summary>
/// Skip building; just do setup and terminate.
/// </summary>
        public UnrealBuildToolConfig SkipBuild(bool? val = null)
        {
            AppendArgument(val == null ? "-SkipBuild" : "-SkipBuild=" + val.ToString());
            return (UnrealBuildToolConfig) this;
        }

    
    
        
/// <summary>
/// Skip pre build targets; just do the main target.
/// </summary>
        public UnrealBuildToolConfig SkipPreBuildTargets(bool? val = null)
        {
            AppendArgument(val == null ? "-SkipPreBuildTargets" : "-SkipPreBuildTargets=" + val.ToString());
            return (UnrealBuildToolConfig) this;
        }

    
    
        
/// <summary>
/// Whether we should just export the XGE XML and pretend it succeeded
/// </summary>
        public UnrealBuildToolConfig XGEExport(bool? val = null)
        {
            AppendArgument(val == null ? "-XGEExport" : "-XGEExport=" + val.ToString());
            return (UnrealBuildToolConfig) this;
        }

    
    
        
/// <summary>
/// Do not allow any engine files to be output (used by compile on startup functionality)
/// </summary>
        public UnrealBuildToolConfig NoEngineChanges(bool? val = null)
        {
            AppendArgument(val == null ? "-NoEngineChanges" : "-NoEngineChanges=" + val.ToString());
            return (UnrealBuildToolConfig) this;
        }

    
    
        
/// <summary>
/// Whether we should just export the outdated actions list
/// </summary>
        public UnrealBuildToolConfig WriteOutdatedActions(object val = null)
        {
            AppendArgument(string.IsNullOrWhiteSpace(val?.ToString()) ? "-WriteOutdatedActions" : "-WriteOutdatedActions=" + val.ToString().DoubleQuoteIfNeeded());
            return (UnrealBuildToolConfig) this;
        }

    
    
        
/// <summary>
/// If we are just running the deployment step, specifies the path to the given deployment settings
/// </summary>
        public UnrealBuildToolConfig Receipt(object val = null)
        {
            AppendArgument(string.IsNullOrWhiteSpace(val?.ToString()) ? "-Receipt" : "-Receipt=" + val.ToString().DoubleQuoteIfNeeded());
            return (UnrealBuildToolConfig) this;
        }

    
    
        
/// <summary>
/// Whether we should just export the outdated actions list
/// </summary>
        public UnrealBuildToolConfig Actions(object val = null)
        {
            AppendArgument(string.IsNullOrWhiteSpace(val?.ToString()) ? "-Actions" : "-Actions=" + val.ToString().DoubleQuoteIfNeeded());
            return (UnrealBuildToolConfig) this;
        }

    
    
        
/// <summary>
/// Execute any actions which result in code generation (eg. ISPC compilation)
/// </summary>
        public UnrealBuildToolConfig ExecCodeGenActions(bool? val = null)
        {
            AppendArgument(val == null ? "-ExecCodeGenActions" : "-ExecCodeGenActions=" + val.ToString());
            return (UnrealBuildToolConfig) this;
        }

    
    
        
/// <summary>
/// Foreign plugin to compile against this target
/// </summary>
        public UnrealBuildToolConfig Plugin(object val = null)
        {
            AppendArgument(string.IsNullOrWhiteSpace(val?.ToString()) ? "-Plugin" : "-Plugin=" + val.ToString().DoubleQuoteIfNeeded());
            return (UnrealBuildToolConfig) this;
        }

    
    
        
/// <summary>
/// Set of module names to compile.
/// </summary>
        public UnrealBuildToolConfig Module(object val = null)
        {
            AppendArgument(string.IsNullOrWhiteSpace(val?.ToString()) ? "-Module" : "-Module=" + val.ToString().DoubleQuoteIfNeeded());
            return (UnrealBuildToolConfig) this;
        }

    
    
        
/// <summary>
/// Individual file(s) to compile
/// </summary>
        public UnrealBuildToolConfig SingleFile(object val = null)
        {
            AppendArgument(string.IsNullOrWhiteSpace(val?.ToString()) ? "-SingleFile" : "-SingleFile=" + val.ToString().DoubleQuoteIfNeeded());
            return (UnrealBuildToolConfig) this;
        }

    
    
        
/// <summary>
/// Whether to perform hot reload for this target
/// </summary>
        public UnrealBuildToolConfig NoHotReload(bool present = true)
        {
            AppendArgument(present ? "-NoHotReload" : "");
            return (UnrealBuildToolConfig) this;
        }

    
    
        
/// <summary>
/// Whether to perform hot reload for this target
/// </summary>
        public UnrealBuildToolConfig ForceHotReload(bool present = true)
        {
            AppendArgument(present ? "-ForceHotReload" : "");
            return (UnrealBuildToolConfig) this;
        }

    
    
        
/// <summary>
/// Whether to perform hot reload for this target
/// </summary>
        public UnrealBuildToolConfig LiveCoding(bool present = true)
        {
            AppendArgument(present ? "-LiveCoding" : "");
            return (UnrealBuildToolConfig) this;
        }

    
    
        
/// <summary>
/// Export the actions for the target to a file
/// </summary>
        public UnrealBuildToolConfig WriteActions(object val = null)
        {
            AppendArgument(string.IsNullOrWhiteSpace(val?.ToString()) ? "-WriteActions" : "-WriteActions=" + val.ToString().DoubleQuoteIfNeeded());
            return (UnrealBuildToolConfig) this;
        }

    
    
        
/// <summary>
/// Path to a file containing a list of modules that may be modified for live coding.
/// </summary>
        public UnrealBuildToolConfig LiveCodingModules(object val = null)
        {
            AppendArgument(string.IsNullOrWhiteSpace(val?.ToString()) ? "-LiveCodingModules" : "-LiveCodingModules=" + val.ToString().DoubleQuoteIfNeeded());
            return (UnrealBuildToolConfig) this;
        }

    
    
        
/// <summary>
/// Path to the manifest for passing info about the output to live coding
/// </summary>
        public UnrealBuildToolConfig LiveCodingManifest(object val = null)
        {
            AppendArgument(string.IsNullOrWhiteSpace(val?.ToString()) ? "-LiveCodingManifest" : "-LiveCodingManifest=" + val.ToString().DoubleQuoteIfNeeded());
            return (UnrealBuildToolConfig) this;
        }

    
    
        
/// <summary>
/// Suppress messages about building this target
/// </summary>
        public UnrealBuildToolConfig Quiet(bool? val = null)
        {
            AppendArgument(val == null ? "-Quiet" : "-Quiet=" + val.ToString());
            return (UnrealBuildToolConfig) this;
        }

    
    
        
    
        public UnrealBuildToolConfig Input(object val = null)
        {
            AppendArgument(string.IsNullOrWhiteSpace(val?.ToString()) ? "-Input" : "-Input=" + val.ToString().DoubleQuoteIfNeeded());
            return (UnrealBuildToolConfig) this;
        }

    
    
        
    
        public UnrealBuildToolConfig XmlConfigCache(object val = null)
        {
            AppendArgument(string.IsNullOrWhiteSpace(val?.ToString()) ? "-XmlConfigCache" : "-XmlConfigCache=" + val.ToString().DoubleQuoteIfNeeded());
            return (UnrealBuildToolConfig) this;
        }

    
    
        
/// <summary>
/// Build all the modules that are valid for this target type. Used for CIS and making installed engine builds.
/// </summary>
        public UnrealBuildToolConfig AllModules(bool? val = null)
        {
            AppendArgument(val == null ? "-AllModules" : "-AllModules=" + val.ToString());
            return (UnrealBuildToolConfig) this;
        }

    
    
        
/// <summary>
/// Additional plugins that are built for this target type but not enabled.
/// </summary>
        public UnrealBuildToolConfig BuildPlugin(object val = null)
        {
            AppendArgument(string.IsNullOrWhiteSpace(val?.ToString()) ? "-BuildPlugin" : "-BuildPlugin=" + val.ToString().DoubleQuoteIfNeeded());
            return (UnrealBuildToolConfig) this;
        }

    
    
        
/// <summary>
/// Additional plugins that should be included for this target.
/// </summary>
        public UnrealBuildToolConfig EnablePlugin(object val = null)
        {
            AppendArgument(string.IsNullOrWhiteSpace(val?.ToString()) ? "-EnablePlugin" : "-EnablePlugin=" + val.ToString().DoubleQuoteIfNeeded());
            return (UnrealBuildToolConfig) this;
        }

    
    
        
/// <summary>
/// List of plugins to be disabled for this target. Note that the project file may still reference them, so they should be marked
/// as optional to avoid failing to find them at runtime.
/// </summary>
        public UnrealBuildToolConfig DisablePlugin(object val = null)
        {
            AppendArgument(string.IsNullOrWhiteSpace(val?.ToString()) ? "-DisablePlugin" : "-DisablePlugin=" + val.ToString().DoubleQuoteIfNeeded());
            return (UnrealBuildToolConfig) this;
        }

    
    
        
/// <summary>
/// Whether this target should be compiled as a DLL.  Requires LinkType to be set to TargetLinkType.Monolithic.
/// </summary>
        public UnrealBuildToolConfig CompileAsDll(bool? val = null)
        {
            AppendArgument(val == null ? "-CompileAsDll" : "-CompileAsDll=" + val.ToString());
            return (UnrealBuildToolConfig) this;
        }

    
    
        
/// <summary>
/// Whether to compile the Chaos physics plugin.
/// </summary>
        public UnrealBuildToolConfig NoCompileChaos(bool present = true)
        {
            AppendArgument(present ? "-NoCompileChaos" : "");
            return (UnrealBuildToolConfig) this;
        }

    
    
        
/// <summary>
/// Whether to compile the Chaos physics plugin.
/// </summary>
        public UnrealBuildToolConfig CompileChaos(bool present = true)
        {
            AppendArgument(present ? "-CompileChaos" : "");
            return (UnrealBuildToolConfig) this;
        }

    
    
        
/// <summary>
/// Whether to use the Chaos physics interface. This overrides the physx flags to disable APEX and NvCloth
/// </summary>
        public UnrealBuildToolConfig NoUseChaos(bool present = true)
        {
            AppendArgument(present ? "-NoUseChaos" : "");
            return (UnrealBuildToolConfig) this;
        }

    
    
        
/// <summary>
/// Whether to use the Chaos physics interface. This overrides the physx flags to disable APEX and NvCloth
/// </summary>
        public UnrealBuildToolConfig UseChaos(bool present = true)
        {
            AppendArgument(present ? "-UseChaos" : "");
            return (UnrealBuildToolConfig) this;
        }

    
    
        
/// <summary>
/// Enable RTTI for all modules.
/// </summary>
        public UnrealBuildToolConfig Rtti(bool? val = null)
        {
            AppendArgument(val == null ? "-rtti" : "-rtti=" + val.ToString());
            return (UnrealBuildToolConfig) this;
        }

    
    
        
/// <summary>
/// Enables "include what you use" by default for modules in this target. Changes the default PCH mode for any module in this project to PCHUsageMode.UseExplicitOrSharedPCHs.
/// </summary>
        public UnrealBuildToolConfig IWYU(bool? val = null)
        {
            AppendArgument(val == null ? "-IWYU" : "-IWYU=" + val.ToString());
            return (UnrealBuildToolConfig) this;
        }

    
    
        
/// <summary>
/// Make static libraries for all engine modules as intermediates for this target.
/// </summary>
        public UnrealBuildToolConfig Precompile(bool? val = null)
        {
            AppendArgument(val == null ? "-Precompile" : "-Precompile=" + val.ToString());
            return (UnrealBuildToolConfig) this;
        }

    
    
        
/// <summary>
/// Whether to unify C++ code into larger files for faster compilation.
/// </summary>
        public UnrealBuildToolConfig DisableUnity(bool present = true)
        {
            AppendArgument(present ? "-DisableUnity" : "");
            return (UnrealBuildToolConfig) this;
        }

    
    
        
/// <summary>
/// Whether to force C++ source files to be combined into larger files for faster compilation.
/// </summary>
        public UnrealBuildToolConfig ForceUnity(bool? val = null)
        {
            AppendArgument(val == null ? "-ForceUnity" : "-ForceUnity=" + val.ToString());
            return (UnrealBuildToolConfig) this;
        }

    
    
        
/// <summary>
/// Forces shadow variable warnings to be treated as errors on platforms that support it.
/// </summary>
        public UnrealBuildToolConfig ShadowVariableErrors(bool present = true)
        {
            AppendArgument(present ? "-ShadowVariableErrors" : "");
            return (UnrealBuildToolConfig) this;
        }

    
    
        
/// <summary>
/// New Monolithic Graphics drivers have optional "fast calls" replacing various D3d functions
/// </summary>
        public UnrealBuildToolConfig FastMonoCalls(bool present = true)
        {
            AppendArgument(present ? "-FastMonoCalls" : "");
            return (UnrealBuildToolConfig) this;
        }

    
    
        
/// <summary>
/// New Monolithic Graphics drivers have optional "fast calls" replacing various D3d functions
/// </summary>
        public UnrealBuildToolConfig NoFastMonoCalls(bool present = true)
        {
            AppendArgument(present ? "-NoFastMonoCalls" : "");
            return (UnrealBuildToolConfig) this;
        }

    
    
        
/// <summary>
/// Whether to stress test the C++ unity build robustness by including all C++ files files in a project from a single unified file.
/// </summary>
        public UnrealBuildToolConfig StressTestUnity(bool? val = null)
        {
            AppendArgument(val == null ? "-StressTestUnity" : "-StressTestUnity=" + val.ToString());
            return (UnrealBuildToolConfig) this;
        }

    
    
        
/// <summary>
/// Whether to force debug info to be generated.
/// </summary>
        public UnrealBuildToolConfig ForceDebugInfo(bool? val = null)
        {
            AppendArgument(val == null ? "-ForceDebugInfo" : "-ForceDebugInfo=" + val.ToString());
            return (UnrealBuildToolConfig) this;
        }

    
    
        
/// <summary>
/// Whether to globally disable debug info generation; see DebugInfoHeuristics.cs for per-config and per-platform options.
/// </summary>
        public UnrealBuildToolConfig NoDebugInfo(bool? val = null)
        {
            AppendArgument(val == null ? "-NoDebugInfo" : "-NoDebugInfo=" + val.ToString());
            return (UnrealBuildToolConfig) this;
        }

    
    
        
/// <summary>
/// Whether PDB files should be used for Visual C++ builds.
/// </summary>
        public UnrealBuildToolConfig NoPDB(bool present = true)
        {
            AppendArgument(present ? "-NoPDB" : "");
            return (UnrealBuildToolConfig) this;
        }

    
    
        
/// <summary>
/// Whether PCH files should be used.
/// </summary>
        public UnrealBuildToolConfig NoPCH(bool present = true)
        {
            AppendArgument(present ? "-NoPCH" : "");
            return (UnrealBuildToolConfig) this;
        }

    
    
        
/// <summary>
/// Whether to just preprocess source files for this target, and skip compilation
/// </summary>
        public UnrealBuildToolConfig Preprocess(bool? val = null)
        {
            AppendArgument(val == null ? "-Preprocess" : "-Preprocess=" + val.ToString());
            return (UnrealBuildToolConfig) this;
        }

    
    
        
/// <summary>
/// Whether to use incremental linking or not. Incremental linking can yield faster iteration times when making small changes.
/// Currently disabled by default because it tends to behave a bit buggy on some computers (PDB-related compile errors).
/// </summary>
        public UnrealBuildToolConfig IncrementalLinking(bool? val = null)
        {
            AppendArgument(val == null ? "-IncrementalLinking" : "-IncrementalLinking=" + val.ToString());
            return (UnrealBuildToolConfig) this;
        }

    
    
        
/// <summary>
/// Whether to use incremental linking or not. Incremental linking can yield faster iteration times when making small changes.
/// Currently disabled by default because it tends to behave a bit buggy on some computers (PDB-related compile errors).
/// </summary>
        public UnrealBuildToolConfig NoIncrementalLinking(bool present = true)
        {
            AppendArgument(present ? "-NoIncrementalLinking" : "");
            return (UnrealBuildToolConfig) this;
        }

    
    
        
/// <summary>
/// Whether to allow the use of link time code generation (LTCG).
/// </summary>
        public UnrealBuildToolConfig LTCG(bool? val = null)
        {
            AppendArgument(val == null ? "-LTCG" : "-LTCG=" + val.ToString());
            return (UnrealBuildToolConfig) this;
        }

    
    
        
/// <summary>
/// Whether to enable Profile Guided Optimization (PGO) instrumentation in this build.
/// </summary>
        public UnrealBuildToolConfig PGOProfile(bool present = true)
        {
            AppendArgument(present ? "-PGOProfile" : "");
            return (UnrealBuildToolConfig) this;
        }

    
    
        
/// <summary>
/// Whether to optimize this build with Profile Guided Optimization (PGO).
/// </summary>
        public UnrealBuildToolConfig PGOOptimize(bool present = true)
        {
            AppendArgument(present ? "-PGOOptimize" : "");
            return (UnrealBuildToolConfig) this;
        }

    
    
        
/// <summary>
/// Enables "Shared PCHs", a feature which significantly speeds up compile times by attempting to
/// share certain PCH files between modules that UBT detects is including those PCH's header files.
/// </summary>
        public UnrealBuildToolConfig NoSharedPCH(bool present = true)
        {
            AppendArgument(present ? "-NoSharedPCH" : "");
            return (UnrealBuildToolConfig) this;
        }

    
    
        
/// <summary>
/// Whether to use the :FASTLINK option when building with /DEBUG to create local PDBs on Windows. Fast, but currently seems to have problems finding symbols in the debugger.
/// </summary>
        public UnrealBuildToolConfig FastPDB(object val = null)
        {
            AppendArgument(string.IsNullOrWhiteSpace(val?.ToString()) ? "-FastPDB" : "-FastPDB=" + val.ToString().DoubleQuoteIfNeeded());
            return (UnrealBuildToolConfig) this;
        }

    
    
        
/// <summary>
/// Outputs a map file as part of the build.
/// </summary>
        public UnrealBuildToolConfig MapFile(bool? val = null)
        {
            AppendArgument(val == null ? "-MapFile" : "-MapFile=" + val.ToString());
            return (UnrealBuildToolConfig) this;
        }

    
    
        
/// <summary>
/// Bundle version for Mac apps.
/// </summary>
        public UnrealBuildToolConfig BundleVersion(object val = null)
        {
            AppendArgument(string.IsNullOrWhiteSpace(val?.ToString()) ? "-BundleVersion" : "-BundleVersion=" + val.ToString().DoubleQuoteIfNeeded());
            return (UnrealBuildToolConfig) this;
        }

    
    
        
/// <summary>
/// Whether to deploy the executable after compilation on platforms that require deployment.
/// </summary>
        public UnrealBuildToolConfig Deploy(bool? val = null)
        {
            AppendArgument(val == null ? "-Deploy" : "-Deploy=" + val.ToString());
            return (UnrealBuildToolConfig) this;
        }

    
    
        
/// <summary>
/// Whether to disable linking for this target.
/// </summary>
        public UnrealBuildToolConfig NoLink(bool? val = null)
        {
            AppendArgument(val == null ? "-NoLink" : "-NoLink=" + val.ToString());
            return (UnrealBuildToolConfig) this;
        }

    
    
        
/// <summary>
/// Indicates that this is a formal build, intended for distribution. This flag is automatically set to true when Build.version has a changelist set.
/// The only behavior currently bound to this flag is to compile the default resource file separately for each binary so that the OriginalFilename field is set correctly.
/// By default, we only compile the resource once to reduce build times.
/// </summary>
        public UnrealBuildToolConfig Formal(bool? val = null)
        {
            AppendArgument(val == null ? "-Formal" : "-Formal=" + val.ToString());
            return (UnrealBuildToolConfig) this;
        }

    
    
        
/// <summary>
/// Whether to clean Builds directory on a remote Mac before building.
/// </summary>
        public UnrealBuildToolConfig FlushMac(bool? val = null)
        {
            AppendArgument(val == null ? "-FlushMac" : "-FlushMac=" + val.ToString());
            return (UnrealBuildToolConfig) this;
        }

    
    
        
/// <summary>
/// Whether to write detailed timing info from the compiler and linker.
/// </summary>
        public UnrealBuildToolConfig Timing(bool? val = null)
        {
            AppendArgument(val == null ? "-Timing" : "-Timing=" + val.ToString());
            return (UnrealBuildToolConfig) this;
        }

    
    
        
/// <summary>
/// Whether to parse timing data into a tracing file compatible with chrome://tracing.
/// </summary>
        public UnrealBuildToolConfig Tracing(bool? val = null)
        {
            AppendArgument(val == null ? "-Tracing" : "-Tracing=" + val.ToString());
            return (UnrealBuildToolConfig) this;
        }

    
    
        
/// <summary>
/// Whether to expose all symbols as public by default on POSIX platforms
/// </summary>
        public UnrealBuildToolConfig PublicSymbolsByDefault(bool? val = null)
        {
            AppendArgument(val == null ? "-PublicSymbolsByDefault" : "-PublicSymbolsByDefault=" + val.ToString());
            return (UnrealBuildToolConfig) this;
        }

    
    
        
/// <summary>
/// Allows overriding the toolchain to be created for this target. This must match the name of a class declared in the UnrealBuildTool assembly.
/// </summary>
        public UnrealBuildToolConfig ToolChain(object val = null)
        {
            AppendArgument(string.IsNullOrWhiteSpace(val?.ToString()) ? "-ToolChain" : "-ToolChain=" + val.ToString().DoubleQuoteIfNeeded());
            return (UnrealBuildToolConfig) this;
        }

    
    
        
/// <summary>
/// Which C++ stanard to use for compiling this target
/// </summary>
        public UnrealBuildToolConfig CppStd(object val = null)
        {
            AppendArgument(string.IsNullOrWhiteSpace(val?.ToString()) ? "-CppStd" : "-CppStd=" + val.ToString().DoubleQuoteIfNeeded());
            return (UnrealBuildToolConfig) this;
        }

    
    
        
/// <summary>
/// The build version string
/// </summary>
        public UnrealBuildToolConfig BuildVersion(object val = null)
        {
            AppendArgument(string.IsNullOrWhiteSpace(val?.ToString()) ? "-BuildVersion" : "-BuildVersion=" + val.ToString().DoubleQuoteIfNeeded());
            return (UnrealBuildToolConfig) this;
        }

    
    
        
/// <summary>
/// Macros to define globally across the whole target.
/// </summary>
        public UnrealBuildToolConfig Define(object val = null)
        {
            AppendArgument(string.IsNullOrWhiteSpace(val?.ToString()) ? "-Define" : "-Define:" + val.ToString().DoubleQuoteIfNeeded());
            return (UnrealBuildToolConfig) this;
        }

    
    
        
/// <summary>
/// Macros to define across all macros in the project.
/// </summary>
        public UnrealBuildToolConfig ProjectDefine(object val = null)
        {
            AppendArgument(string.IsNullOrWhiteSpace(val?.ToString()) ? "-ProjectDefine" : "-ProjectDefine:" + val.ToString().DoubleQuoteIfNeeded());
            return (UnrealBuildToolConfig) this;
        }

    
    
        
/// <summary>
/// Path to a manifest to output for this target
/// </summary>
        public UnrealBuildToolConfig Manifest(object val = null)
        {
            AppendArgument(string.IsNullOrWhiteSpace(val?.ToString()) ? "-Manifest" : "-Manifest=" + val.ToString().DoubleQuoteIfNeeded());
            return (UnrealBuildToolConfig) this;
        }

    
    
        
/// <summary>
/// Path to a list of dependencies for this target, when precompiling
/// </summary>
        public UnrealBuildToolConfig DependencyList(object val = null)
        {
            AppendArgument(string.IsNullOrWhiteSpace(val?.ToString()) ? "-DependencyList" : "-DependencyList=" + val.ToString().DoubleQuoteIfNeeded());
            return (UnrealBuildToolConfig) this;
        }

    
    
        
/// <summary>
/// Whether to ignore violations to the shared build environment (eg. editor targets modifying definitions)
/// </summary>
        public UnrealBuildToolConfig OverrideBuildEnvironment(bool? val = null)
        {
            AppendArgument(val == null ? "-OverrideBuildEnvironment" : "-OverrideBuildEnvironment=" + val.ToString());
            return (UnrealBuildToolConfig) this;
        }

    
    
        
/// <summary>
/// Additional arguments to pass to the compiler
/// </summary>
        public UnrealBuildToolConfig CompilerArguments(object val = null)
        {
            AppendArgument(string.IsNullOrWhiteSpace(val?.ToString()) ? "-CompilerArguments" : "-CompilerArguments=" + val.ToString().DoubleQuoteIfNeeded());
            return (UnrealBuildToolConfig) this;
        }

    
    
        
/// <summary>
/// Additional arguments to pass to the linker
/// </summary>
        public UnrealBuildToolConfig LinkerArguments(object val = null)
        {
            AppendArgument(string.IsNullOrWhiteSpace(val?.ToString()) ? "-LinkerArguments" : "-LinkerArguments=" + val.ToString().DoubleQuoteIfNeeded());
            return (UnrealBuildToolConfig) this;
        }

    
    
        
/// <summary>
/// Whether to build the iOS project as a framework.
/// </summary>
        public UnrealBuildToolConfig BuildAsFramework(bool? val = null)
        {
            AppendArgument(val == null ? "-build-as-framework" : "-build-as-framework=" + val.ToString());
            return (UnrealBuildToolConfig) this;
        }

    
    
        
/// <summary>
/// Whether to generate a dSYM file or not.
/// </summary>
        public UnrealBuildToolConfig Generatedsymfile(bool? val = null)
        {
            AppendArgument(val == null ? "-generatedsymfile" : "-generatedsymfile=" + val.ToString());
            return (UnrealBuildToolConfig) this;
        }

    
    
        
/// <summary>
/// Whether to generate a dSYM bundle (as opposed to single file dSYM)
/// </summary>
        public UnrealBuildToolConfig Generatedsymbundle(bool? val = null)
        {
            AppendArgument(val == null ? "-generatedsymbundle" : "-generatedsymbundle=" + val.ToString());
            return (UnrealBuildToolConfig) this;
        }

    
    
        
/// <summary>
/// Lists Architectures that you want to build
/// </summary>
        public UnrealBuildToolConfig Architectures(object val = null)
        {
            AppendArgument(string.IsNullOrWhiteSpace(val?.ToString()) ? "-Architectures" : "-Architectures=" + val.ToString().DoubleQuoteIfNeeded());
            return (UnrealBuildToolConfig) this;
        }

    
    
        
/// <summary>
/// Lists GPU Architectures that you want to build (mostly used for mobile etc.)
/// </summary>
        public UnrealBuildToolConfig GPUArchitectures(object val = null)
        {
            AppendArgument(string.IsNullOrWhiteSpace(val?.ToString()) ? "-GPUArchitectures" : "-GPUArchitectures=" + val.ToString().DoubleQuoteIfNeeded());
            return (UnrealBuildToolConfig) this;
        }

    
    
        
/// <summary>
/// Ignore AppBundle (AAB) generation setting if "-ForceAPKGeneration" specified
/// </summary>
        public UnrealBuildToolConfig ForceAPKGeneration(bool present = true)
        {
            AppendArgument(present ? "-ForceAPKGeneration" : "");
            return (UnrealBuildToolConfig) this;
        }

    
    
        
/// <summary>
/// Version of the compiler toolchain to use on HoloLens. A value of "default" will be changed to a specific version at UBT startup.
/// </summary>
        public UnrealBuildToolConfig _2015(bool present = true)
        {
            AppendArgument(present ? "-2015" : "");
            return (UnrealBuildToolConfig) this;
        }

    
    
        
/// <summary>
/// Version of the compiler toolchain to use on HoloLens. A value of "default" will be changed to a specific version at UBT startup.
/// </summary>
        public UnrealBuildToolConfig _2017(bool present = true)
        {
            AppendArgument(present ? "-2017" : "");
            return (UnrealBuildToolConfig) this;
        }

    
    
        
/// <summary>
/// Version of the compiler toolchain to use on HoloLens. A value of "default" will be changed to a specific version at UBT startup.
/// </summary>
        public UnrealBuildToolConfig _2019(bool present = true)
        {
            AppendArgument(present ? "-2019" : "");
            return (UnrealBuildToolConfig) this;
        }

    
    
        
/// <summary>
/// Version of the compiler toolchain to use on HoloLens. A value of "default" will be changed to a specific version at UBT startup.
/// </summary>
        public UnrealBuildToolConfig _2022(bool present = true)
        {
            AppendArgument(present ? "-2022" : "");
            return (UnrealBuildToolConfig) this;
        }

    
    
        
/// <summary>
/// Whether to strip iOS symbols or not (implied by Shipping config).
/// </summary>
        public UnrealBuildToolConfig Stripsymbols(bool present = true)
        {
            AppendArgument(present ? "-stripsymbols" : "");
            return (UnrealBuildToolConfig) this;
        }

    
    
        
/// <summary>
/// If true, then a stub IPA will be generated when compiling is done (minimal files needed for a valid IPA).
/// </summary>
        public UnrealBuildToolConfig CreateStub(bool present = true)
        {
            AppendArgument(present ? "-CreateStub" : "");
            return (UnrealBuildToolConfig) this;
        }

    
    
        
/// <summary>
/// Don't generate crashlytics data
/// </summary>
        public UnrealBuildToolConfig Alwaysgeneratedsym(bool present = true)
        {
            AppendArgument(present ? "-alwaysgeneratedsym" : "");
            return (UnrealBuildToolConfig) this;
        }

    
    
        
/// <summary>
/// Don't generate crashlytics data
/// </summary>
        public UnrealBuildToolConfig Skipcrashlytics(bool? val = null)
        {
            AppendArgument(val == null ? "-skipcrashlytics" : "-skipcrashlytics=" + val.ToString());
            return (UnrealBuildToolConfig) this;
        }

    
    
        
/// <summary>
/// Mark the build for distribution
/// </summary>
        public UnrealBuildToolConfig Distribution(bool? val = null)
        {
            AppendArgument(val == null ? "-distribution" : "-distribution=" + val.ToString());
            return (UnrealBuildToolConfig) this;
        }

    
    
        
/// <summary>
/// Manual override for the provision to use. Should be a full path.
/// </summary>
        public UnrealBuildToolConfig ImportProvision(object val = null)
        {
            AppendArgument(string.IsNullOrWhiteSpace(val?.ToString()) ? "-ImportProvision" : "-ImportProvision=" + val.ToString().DoubleQuoteIfNeeded());
            return (UnrealBuildToolConfig) this;
        }

    
    
        
/// <summary>
/// Imports the given certificate (inc private key) into a temporary keychain before signing.
/// </summary>
        public UnrealBuildToolConfig ImportCertificate(object val = null)
        {
            AppendArgument(string.IsNullOrWhiteSpace(val?.ToString()) ? "-ImportCertificate" : "-ImportCertificate=" + val.ToString().DoubleQuoteIfNeeded());
            return (UnrealBuildToolConfig) this;
        }

    
    
        
/// <summary>
/// Password for the imported certificate
/// </summary>
        public UnrealBuildToolConfig ImportCertificatePassword(object val = null)
        {
            AppendArgument(string.IsNullOrWhiteSpace(val?.ToString()) ? "-ImportCertificatePassword" : "-ImportCertificatePassword=" + val.ToString().DoubleQuoteIfNeeded());
            return (UnrealBuildToolConfig) this;
        }

    
    
        
/// <summary>
/// Enables memory sanitizer (MSan)
/// </summary>
        public UnrealBuildToolConfig EnableMSan(bool? val = null)
        {
            AppendArgument(val == null ? "-EnableMSan" : "-EnableMSan=" + val.ToString());
            return (UnrealBuildToolConfig) this;
        }

    
    
        
/// <summary>
/// Enables "thin" LTO
/// </summary>
        public UnrealBuildToolConfig ThinLTO(bool? val = null)
        {
            AppendArgument(val == null ? "-ThinLTO" : "-ThinLTO=" + val.ToString());
            return (UnrealBuildToolConfig) this;
        }

    
    
        
/// <summary>
/// Use existing static libraries for all engine modules in this target.
/// </summary>
        public UnrealBuildToolConfig UsePrecompiled(bool? val = null)
        {
            AppendArgument(val == null ? "-UsePrecompiled" : "-UsePrecompiled=" + val.ToString());
            return (UnrealBuildToolConfig) this;
        }

    
    
        
/// <summary>
/// Whether XGE may be used.
/// </summary>
        public UnrealBuildToolConfig NoXGE(bool present = true)
        {
            AppendArgument(present ? "-NoXGE" : "");
            return (UnrealBuildToolConfig) this;
        }

    
    
        
/// <summary>
/// Whether FASTBuild may be used.
/// </summary>
        public UnrealBuildToolConfig NoFASTBuild(bool present = true)
        {
            AppendArgument(present ? "-NoFASTBuild" : "");
            return (UnrealBuildToolConfig) this;
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
        public UnrealBuildToolConfig NoUBTMakefiles(bool present = true)
        {
            AppendArgument(present ? "-NoUBTMakefiles" : "");
            return (UnrealBuildToolConfig) this;
        }

    
    
        
/// <summary>
/// Number of actions that can be executed in parallel. If 0 then code will pick a default based
/// on the number of cores available. Only applies to the ParallelExecutor
/// </summary>
        public UnrealBuildToolConfig MaxParallelActions(double? val = null)
        {
            AppendArgument(val == null ? "-MaxParallelActions" : "-MaxParallelActions=" + val.ToString());
            return (UnrealBuildToolConfig) this;
        }

    
    
        
/// <summary>
/// If true, force header regeneration. Intended for the build machine.
/// </summary>
        public UnrealBuildToolConfig ForceHeaderGeneration(bool? val = null)
        {
            AppendArgument(val == null ? "-ForceHeaderGeneration" : "-ForceHeaderGeneration=" + val.ToString());
            return (UnrealBuildToolConfig) this;
        }

    
    
        
/// <summary>
/// If true, do not build UHT, assume it is already built.
/// </summary>
        public UnrealBuildToolConfig NoBuildUHT(bool? val = null)
        {
            AppendArgument(val == null ? "-NoBuildUHT" : "-NoBuildUHT=" + val.ToString());
            return (UnrealBuildToolConfig) this;
        }

    
    
        
/// <summary>
/// If true, fail if any of the generated header files is out of date.
/// </summary>
        public UnrealBuildToolConfig FailIfGeneratedCodeChanges(bool? val = null)
        {
            AppendArgument(val == null ? "-FailIfGeneratedCodeChanges" : "-FailIfGeneratedCodeChanges=" + val.ToString());
            return (UnrealBuildToolConfig) this;
        }

    
    
        
/// <summary>
/// True if hot-reload from IDE is allowed.
/// </summary>
        public UnrealBuildToolConfig NoHotReloadFromIDE(bool present = true)
        {
            AppendArgument(present ? "-NoHotReloadFromIDE" : "");
            return (UnrealBuildToolConfig) this;
        }

    
    
        
/// <summary>
/// Whether to skip compiling rules assemblies and just assume they are valid
/// </summary>
        public UnrealBuildToolConfig SkipRulesCompile(bool? val = null)
        {
            AppendArgument(val == null ? "-SkipRulesCompile" : "-SkipRulesCompile=" + val.ToString());
            return (UnrealBuildToolConfig) this;
        }

    
    
        
/// <summary>
/// Version of the compiler toolchain to use on Windows platform. A value of "default" will be changed to a specific version at UBT start up.
/// </summary>
        public UnrealBuildToolConfig Compiler(object val = null)
        {
            AppendArgument(string.IsNullOrWhiteSpace(val?.ToString()) ? "-Compiler" : "-Compiler=" + val.ToString().DoubleQuoteIfNeeded());
            return (UnrealBuildToolConfig) this;
        }

    
    
        
/// <summary>
/// The specific toolchain version to use. This may be a specific version number (for example, "14.13.26128"), the string "Latest" to select the newest available version, or
/// the string "Preview" to select the newest available preview version. By default, and if it is available, we use the toolchain version indicated by
/// WindowsPlatform.DefaultToolChainVersion (otherwise, we use the latest version).
/// </summary>
        public UnrealBuildToolConfig CompilerVersion(object val = null)
        {
            AppendArgument(string.IsNullOrWhiteSpace(val?.ToString()) ? "-CompilerVersion" : "-CompilerVersion=" + val.ToString().DoubleQuoteIfNeeded());
            return (UnrealBuildToolConfig) this;
        }

    
    
        
/// <summary>
/// The static analyzer to use.
/// </summary>
        public UnrealBuildToolConfig StaticAnalyzer(object val = null)
        {
            AppendArgument(string.IsNullOrWhiteSpace(val?.ToString()) ? "-StaticAnalyzer" : "-StaticAnalyzer=" + val.ToString().DoubleQuoteIfNeeded());
            return (UnrealBuildToolConfig) this;
        }

    
    
        
/// <summary>
/// Whether we should export a file containing .obj to source file mappings.
/// </summary>
        public UnrealBuildToolConfig ObjSrcMap(object val = null)
        {
            AppendArgument(string.IsNullOrWhiteSpace(val?.ToString()) ? "-ObjSrcMap" : "-ObjSrcMap=" + val.ToString().DoubleQuoteIfNeeded());
            return (UnrealBuildToolConfig) this;
        }

    
    
        
/// <summary>
/// Enables strict standard conformance mode (/permissive-) in VS2017+.
/// </summary>
        public UnrealBuildToolConfig Strict(bool? val = null)
        {
            AppendArgument(val == null ? "-Strict" : "-Strict=" + val.ToString());
            return (UnrealBuildToolConfig) this;
        }

    
    
        
/// <summary>
/// Print out files that are included by each source file
/// </summary>
        public UnrealBuildToolConfig ShowIncludes(bool? val = null)
        {
            AppendArgument(val == null ? "-ShowIncludes" : "-ShowIncludes=" + val.ToString());
            return (UnrealBuildToolConfig) this;
        }

    
    
        
/// <summary>
/// The amount of detail to write to the log
/// </summary>
        public UnrealBuildToolConfig Verbose(bool present = true)
        {
            AppendArgument(present ? "-Verbose" : "");
            return (UnrealBuildToolConfig) this;
        }

    
    
        
/// <summary>
/// The amount of detail to write to the log
/// </summary>
        public UnrealBuildToolConfig VeryVerbose(bool present = true)
        {
            AppendArgument(present ? "-VeryVerbose" : "");
            return (UnrealBuildToolConfig) this;
        }

    
    
        
/// <summary>
/// Specifies the path to a log file to write. Note that the default mode (eg. building, generating project files) will create a log file by default if this not specified.
/// </summary>
        public UnrealBuildToolConfig Log(object val = null)
        {
            AppendArgument(string.IsNullOrWhiteSpace(val?.ToString()) ? "-Log" : "-Log=" + val.ToString().DoubleQuoteIfNeeded());
            return (UnrealBuildToolConfig) this;
        }

    
    
        
/// <summary>
/// Whether to include timestamps in the log
/// </summary>
        public UnrealBuildToolConfig Timestamps(bool? val = null)
        {
            AppendArgument(val == null ? "-Timestamps" : "-Timestamps=" + val.ToString());
            return (UnrealBuildToolConfig) this;
        }

    
    
        
/// <summary>
/// Whether to format messages in MsBuild format
/// </summary>
        public UnrealBuildToolConfig FromMsBuild(bool? val = null)
        {
            AppendArgument(val == null ? "-FromMsBuild" : "-FromMsBuild=" + val.ToString());
            return (UnrealBuildToolConfig) this;
        }

    
    
        
/// <summary>
/// Whether to write progress markup in a format that can be parsed by other programs
/// </summary>
        public UnrealBuildToolConfig Progress(bool? val = null)
        {
            AppendArgument(val == null ? "-Progress" : "-Progress=" + val.ToString());
            return (UnrealBuildToolConfig) this;
        }

    
    
        
/// <summary>
/// Whether to ignore the mutex
/// </summary>
        public UnrealBuildToolConfig NoMutex(bool? val = null)
        {
            AppendArgument(val == null ? "-NoMutex" : "-NoMutex=" + val.ToString());
            return (UnrealBuildToolConfig) this;
        }

    
    
        
/// <summary>
/// Whether to wait for the mutex rather than aborting immediately
/// </summary>
        public UnrealBuildToolConfig WaitMutex(bool? val = null)
        {
            AppendArgument(val == null ? "-WaitMutex" : "-WaitMutex=" + val.ToString());
            return (UnrealBuildToolConfig) this;
        }

    
    
        
/// <summary>
/// Whether to wait for the mutex rather than aborting immediately
/// </summary>
        public UnrealBuildToolConfig RemoteIni(object val = null)
        {
            AppendArgument(string.IsNullOrWhiteSpace(val?.ToString()) ? "-RemoteIni" : "-RemoteIni=" + val.ToString().DoubleQuoteIfNeeded());
            return (UnrealBuildToolConfig) this;
        }

    
    
        
/// <summary>
/// The mode to execute
/// </summary>
        public UnrealBuildToolConfig Mode(object val = null)
        {
            AppendArgument(string.IsNullOrWhiteSpace(val?.ToString()) ? "-Mode" : "-Mode=" + val.ToString().DoubleQuoteIfNeeded());
            return (UnrealBuildToolConfig) this;
        }

    
    
        
/// <summary>
/// The mode to execute
/// </summary>
        public UnrealBuildToolConfig Clean(bool present = true)
        {
            AppendArgument(present ? "-Clean" : "");
            return (UnrealBuildToolConfig) this;
        }

    
    
        
/// <summary>
/// The mode to execute
/// </summary>
        public UnrealBuildToolConfig ProjectFiles(bool present = true)
        {
            AppendArgument(present ? "-ProjectFiles" : "");
            return (UnrealBuildToolConfig) this;
        }

    
    
        
/// <summary>
/// The mode to execute
/// </summary>
        public UnrealBuildToolConfig ProjectFileFormat(bool present = true)
        {
            AppendArgument(present ? "-ProjectFileFormat" : "");
            return (UnrealBuildToolConfig) this;
        }

    
    
        
/// <summary>
/// The mode to execute
/// </summary>
        public UnrealBuildToolConfig Makefile(bool present = true)
        {
            AppendArgument(present ? "-Makefile" : "");
            return (UnrealBuildToolConfig) this;
        }

    
    
        
/// <summary>
/// The mode to execute
/// </summary>
        public UnrealBuildToolConfig CMakefile(bool present = true)
        {
            AppendArgument(present ? "-CMakefile" : "");
            return (UnrealBuildToolConfig) this;
        }

    
    
        
/// <summary>
/// The mode to execute
/// </summary>
        public UnrealBuildToolConfig QMakefile(bool present = true)
        {
            AppendArgument(present ? "-QMakefile" : "");
            return (UnrealBuildToolConfig) this;
        }

    
    
        
/// <summary>
/// The mode to execute
/// </summary>
        public UnrealBuildToolConfig KDevelopfile(bool present = true)
        {
            AppendArgument(present ? "-KDevelopfile" : "");
            return (UnrealBuildToolConfig) this;
        }

    
    
        
/// <summary>
/// The mode to execute
/// </summary>
        public UnrealBuildToolConfig CodeliteFiles(bool present = true)
        {
            AppendArgument(present ? "-CodeliteFiles" : "");
            return (UnrealBuildToolConfig) this;
        }

    
    
        
/// <summary>
/// The mode to execute
/// </summary>
        public UnrealBuildToolConfig XCodeProjectFiles(bool present = true)
        {
            AppendArgument(present ? "-XCodeProjectFiles" : "");
            return (UnrealBuildToolConfig) this;
        }

    
    
        
/// <summary>
/// The mode to execute
/// </summary>
        public UnrealBuildToolConfig EdditProjectFiles(bool present = true)
        {
            AppendArgument(present ? "-EdditProjectFiles" : "");
            return (UnrealBuildToolConfig) this;
        }

    
    
        
/// <summary>
/// The mode to execute
/// </summary>
        public UnrealBuildToolConfig VSCode(bool present = true)
        {
            AppendArgument(present ? "-VSCode" : "");
            return (UnrealBuildToolConfig) this;
        }

    
    
        
/// <summary>
/// The mode to execute
/// </summary>
        public UnrealBuildToolConfig VSMac(bool present = true)
        {
            AppendArgument(present ? "-VSMac" : "");
            return (UnrealBuildToolConfig) this;
        }

    
    
        
/// <summary>
/// The mode to execute
/// </summary>
        public UnrealBuildToolConfig CLion(bool present = true)
        {
            AppendArgument(present ? "-CLion" : "");
            return (UnrealBuildToolConfig) this;
        }

    
    
        
/// <summary>
/// The mode to execute
/// </summary>
        public UnrealBuildToolConfig Rider(bool present = true)
        {
            AppendArgument(present ? "-Rider" : "");
            return (UnrealBuildToolConfig) this;
        }

    

    
/// <summary>
/// Builds a target
/// </summary>
    public  class BuildConfig : ToolConfig
    {
        public override string Name => "Build";
    
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
        
    
        public override string Gather()
        {
            Arguments.Insert(0, "-Build");
            return base.Gather();
        }
    }

    protected readonly BuildConfig BuildStorage = new();
    
    
/// <summary>
/// Cleans build products and intermediates for the target. This deletes files which are named consistently with the target being built
/// (e.g. UE4Editor-Foo-Win64-Debug.dll) rather than an actual record of previous build products.
/// </summary>
    public  class CleanConfig : ToolConfig
    {
        public override string Name => "Clean";
    
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
        
    
        public override string Gather()
        {
            Arguments.Insert(0, "-Clean");
            return base.Gather();
        }
    }

    protected readonly CleanConfig CleanStorage = new();
    
    
/// <summary>
/// Invokes the deployment handler for a target.
/// </summary>
    public  class DeployConfig : ToolConfig
    {
        public override string Name => "Deploy";
    
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
        
    
        public override string Gather()
        {
            Arguments.Insert(0, "-Deploy");
            return base.Gather();
        }
    }

    protected readonly DeployConfig DeployStorage = new();
    
    
/// <summary>
/// Builds a target
/// </summary>
    public  class ExecuteConfig : ToolConfig
    {
        public override string Name => "Execute";
    
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
        
    
        public override string Gather()
        {
            Arguments.Insert(0, "-Execute");
            return base.Gather();
        }
    }

    protected readonly ExecuteConfig ExecuteStorage = new();
    
    
/// <summary>
/// Exports a target as a JSON file
/// </summary>
    public  class JsonExportConfig : ToolConfig
    {
        public override string Name => "JsonExport";
    
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
        
    
        public override string Gather()
        {
            Arguments.Insert(0, "-JsonExport");
            return base.Gather();
        }
    }

    protected readonly JsonExportConfig JsonExportStorage = new();
    
    
    
    public  class IOSPostBuildSyncConfig : ToolConfig
    {
        public override string Name => "IOSPostBuildSync";
    
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
        
    
        public override string Gather()
        {
            Arguments.Insert(0, "-IOSPostBuildSync");
            return base.Gather();
        }
    }

    protected readonly IOSPostBuildSyncConfig IOSPostBuildSyncStorage = new();
    
    private ToolConfig[] _configs = null;
    protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
    {
        BuildStorage,
                CleanStorage,
                DeployStorage,
                ExecuteStorage,
                JsonExportStorage,
                IOSPostBuildSyncStorage,
            };
    

/// <summary>
/// Builds a target
/// </summary>
    public UnrealBuildToolConfig Build(Action<BuildConfig> configurator = null)
    {
        configurator?.Invoke(BuildStorage);
        AppendSubtool(BuildStorage);
        return (UnrealBuildToolConfig) this;
    }
    
/// <summary>
/// Cleans build products and intermediates for the target. This deletes files which are named consistently with the target being built
/// (e.g. UE4Editor-Foo-Win64-Debug.dll) rather than an actual record of previous build products.
/// </summary>
    public UnrealBuildToolConfig Clean(Action<CleanConfig> configurator = null)
    {
        configurator?.Invoke(CleanStorage);
        AppendSubtool(CleanStorage);
        return (UnrealBuildToolConfig) this;
    }
    
/// <summary>
/// Invokes the deployment handler for a target.
/// </summary>
    public UnrealBuildToolConfig Deploy(Action<DeployConfig> configurator = null)
    {
        configurator?.Invoke(DeployStorage);
        AppendSubtool(DeployStorage);
        return (UnrealBuildToolConfig) this;
    }
    
/// <summary>
/// Builds a target
/// </summary>
    public UnrealBuildToolConfig Execute(Action<ExecuteConfig> configurator = null)
    {
        configurator?.Invoke(ExecuteStorage);
        AppendSubtool(ExecuteStorage);
        return (UnrealBuildToolConfig) this;
    }
    
/// <summary>
/// Exports a target as a JSON file
/// </summary>
    public UnrealBuildToolConfig JsonExport(Action<JsonExportConfig> configurator = null)
    {
        configurator?.Invoke(JsonExportStorage);
        AppendSubtool(JsonExportStorage);
        return (UnrealBuildToolConfig) this;
    }
    

    public UnrealBuildToolConfig IOSPostBuildSync(Action<IOSPostBuildSyncConfig> configurator = null)
    {
        configurator?.Invoke(IOSPostBuildSyncStorage);
        AppendSubtool(IOSPostBuildSyncStorage);
        return (UnrealBuildToolConfig) this;
    }
    
    public override string Gather()
    {
        Arguments.Insert(0, "UnrealBuildTool");
        return base.Gather();
    }
}
