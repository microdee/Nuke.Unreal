
// This file is generated via `nuke generate-tools` target.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace Nuke.Unreal.Tools;


public enum CppStandardVersion
{

    
    Default,
    
    
    Cpp14,
    
    
    Cpp17,
    
    
    Latest,
    }




public enum WindowsCompiler
{

    
    Default,
    
    
    Clang,
    
    
    Intel,
    
    
    VisualStudio2015_DEPRECATED,
    
    
    VisualStudio2015,
    
    
    VisualStudio2017,
    
    
    VisualStudio2019,
    
    
    VisualStudio2022,
    }




public enum WindowsStaticAnalyzer
{

    
    None,
    
    
    VisualCpp,
    
    
    PVSStudio,
    }















/// <summary>Unreal Build Tool compiles the binaries of Unreal projects</summary>
public abstract class UnrealBuildToolConfigGenerated : ToolConfig
{
    public override string Name => "UnrealBuildTool";
    public override string CliName => "";
    public override UnrealCompatibility Compatibility => UnrealCompatibility.UE4;
    
        
/// <summary>
/// Enables address sanitizer (ASan).
/// 
/// 
/// Enables address sanitizer (ASan)
/// </summary>
        public virtual UnrealBuildToolConfig EnableASan(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-EnableASan",
                    Value: val?.ToString(),
                    Setter: '=',
                    Compatibility: UnrealCompatibility.UE4
                ));
            }
            return (UnrealBuildToolConfig) this;
        }

        
        
/// <summary>
/// Enables thread sanitizer (TSan).
/// 
/// 
/// Enables thread sanitizer (TSan)
/// </summary>
        public virtual UnrealBuildToolConfig EnableTSan(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-EnableTSan",
                    Value: val?.ToString(),
                    Setter: '=',
                    Compatibility: UnrealCompatibility.UE4
                ));
            }
            return (UnrealBuildToolConfig) this;
        }

        
        
/// <summary>
/// Enables undefined behavior sanitizer (UBSan).
/// 
/// 
/// Enables undefined behavior sanitizer (UBSan)
/// </summary>
        public virtual UnrealBuildToolConfig EnableUBSan(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-EnableUBSan",
                    Value: val?.ToString(),
                    Setter: '=',
                    Compatibility: UnrealCompatibility.UE4
                ));
            }
            return (UnrealBuildToolConfig) this;
        }

        
        
/// <summary>
/// Whether to skip checking for files identified by the junk manifest.
/// </summary>
        public virtual UnrealBuildToolConfig IgnoreJunk(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-IgnoreJunk",
                    Value: val?.ToString(),
                    Setter: '=',
                    Compatibility: UnrealCompatibility.UE4
                ));
            }
            return (UnrealBuildToolConfig) this;
        }

        
        
/// <summary>
/// Skip building; just do setup and terminate.
/// </summary>
        public virtual UnrealBuildToolConfig SkipBuild(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-SkipBuild",
                    Value: val?.ToString(),
                    Setter: '=',
                    Compatibility: UnrealCompatibility.UE4
                ));
            }
            return (UnrealBuildToolConfig) this;
        }

        
        
/// <summary>
/// Skip pre build targets; just do the main target.
/// </summary>
        public virtual UnrealBuildToolConfig SkipPreBuildTargets(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-SkipPreBuildTargets",
                    Value: val?.ToString(),
                    Setter: '=',
                    Compatibility: UnrealCompatibility.UE4
                ));
            }
            return (UnrealBuildToolConfig) this;
        }

        
        
/// <summary>
/// Whether we should just export the XGE XML and pretend it succeeded
/// </summary>
        public virtual UnrealBuildToolConfig XGEExport(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-XGEExport",
                    Value: val?.ToString(),
                    Setter: '=',
                    Compatibility: UnrealCompatibility.UE4
                ));
            }
            return (UnrealBuildToolConfig) this;
        }

        
        
/// <summary>
/// Do not allow any engine files to be output (used by compile on startup functionality)
/// </summary>
        public virtual UnrealBuildToolConfig NoEngineChanges(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-NoEngineChanges",
                    Value: val?.ToString(),
                    Setter: '=',
                    Compatibility: UnrealCompatibility.UE4
                ));
            }
            return (UnrealBuildToolConfig) this;
        }

        
        
/// <summary>
/// Whether we should just export the outdated actions list
/// </summary>
        public virtual UnrealBuildToolConfig WriteOutdatedActions(object val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-WriteOutdatedActions",
                    Value: val?.ToString(),
                    Setter: '=',
                    Compatibility: UnrealCompatibility.UE4
                ));
            }
            return (UnrealBuildToolConfig) this;
        }

        
        
/// <summary>
/// If we are just running the deployment step, specifies the path to the given deployment settings
/// </summary>
        public virtual UnrealBuildToolConfig Receipt(object val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Receipt",
                    Value: val?.ToString(),
                    Setter: '=',
                    Compatibility: UnrealCompatibility.UE4
                ));
            }
            return (UnrealBuildToolConfig) this;
        }

        
        
/// <summary>
/// Whether we should just export the outdated actions list
/// </summary>
        public virtual UnrealBuildToolConfig Actions(object val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Actions",
                    Value: val?.ToString(),
                    Setter: '=',
                    Compatibility: UnrealCompatibility.UE4
                ));
            }
            return (UnrealBuildToolConfig) this;
        }

        
        
/// <summary>
/// Execute any actions which result in code generation (eg. ISPC compilation)
/// </summary>
        public virtual UnrealBuildToolConfig ExecCodeGenActions(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-ExecCodeGenActions",
                    Value: val?.ToString(),
                    Setter: '=',
                    Compatibility: UnrealCompatibility.UE4
                ));
            }
            return (UnrealBuildToolConfig) this;
        }

        
        
/// <summary>
/// Foreign plugin to compile against this target
/// </summary>
        public virtual UnrealBuildToolConfig Plugin(object val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Plugin",
                    Value: val?.ToString(),
                    Setter: '=',
                    Compatibility: UnrealCompatibility.UE4
                ));
            }
            return (UnrealBuildToolConfig) this;
        }

        
        
/// <summary>
/// Set of module names to compile.
/// </summary>
        public virtual UnrealBuildToolConfig Module(object val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Module",
                    Value: val?.ToString(),
                    Setter: '=',
                    Compatibility: UnrealCompatibility.UE4
                ));
            }
            return (UnrealBuildToolConfig) this;
        }

        
        
/// <summary>
/// Individual file(s) to compile
/// </summary>
        public virtual UnrealBuildToolConfig SingleFile(object val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-SingleFile",
                    Value: val?.ToString(),
                    Setter: '=',
                    Compatibility: UnrealCompatibility.UE4
                ));
            }
            return (UnrealBuildToolConfig) this;
        }

        
        
/// <summary>
/// Whether to perform hot reload for this target
/// </summary>
        public virtual UnrealBuildToolConfig NoHotReload(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-NoHotReload",
                    Value: null,
                    Setter: '=',
                    Compatibility: UnrealCompatibility.UE4
                ));
            }
            return (UnrealBuildToolConfig) this;
        }

        
        
/// <summary>
/// Whether to perform hot reload for this target
/// </summary>
        public virtual UnrealBuildToolConfig ForceHotReload(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-ForceHotReload",
                    Value: null,
                    Setter: '=',
                    Compatibility: UnrealCompatibility.UE4
                ));
            }
            return (UnrealBuildToolConfig) this;
        }

        
        
/// <summary>
/// Whether to perform hot reload for this target
/// </summary>
        public virtual UnrealBuildToolConfig LiveCoding(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-LiveCoding",
                    Value: null,
                    Setter: '=',
                    Compatibility: UnrealCompatibility.UE4
                ));
            }
            return (UnrealBuildToolConfig) this;
        }

        
        
/// <summary>
/// Export the actions for the target to a file
/// </summary>
        public virtual UnrealBuildToolConfig WriteActions(object val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-WriteActions",
                    Value: val?.ToString(),
                    Setter: '=',
                    Compatibility: UnrealCompatibility.UE4
                ));
            }
            return (UnrealBuildToolConfig) this;
        }

        
        
/// <summary>
/// Path to a file containing a list of modules that may be modified for live coding.
/// </summary>
        public virtual UnrealBuildToolConfig LiveCodingModules(object val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-LiveCodingModules",
                    Value: val?.ToString(),
                    Setter: '=',
                    Compatibility: UnrealCompatibility.UE4
                ));
            }
            return (UnrealBuildToolConfig) this;
        }

        
        
/// <summary>
/// Path to the manifest for passing info about the output to live coding
/// </summary>
        public virtual UnrealBuildToolConfig LiveCodingManifest(object val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-LiveCodingManifest",
                    Value: val?.ToString(),
                    Setter: '=',
                    Compatibility: UnrealCompatibility.UE4
                ));
            }
            return (UnrealBuildToolConfig) this;
        }

        
        
/// <summary>
/// Suppress messages about building this target
/// </summary>
        public virtual UnrealBuildToolConfig Quiet(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Quiet",
                    Value: val?.ToString(),
                    Setter: '=',
                    Compatibility: UnrealCompatibility.UE4
                ));
            }
            return (UnrealBuildToolConfig) this;
        }

        
        
    
        public virtual UnrealBuildToolConfig Input(object val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Input",
                    Value: val?.ToString(),
                    Setter: '=',
                    Compatibility: UnrealCompatibility.UE4
                ));
            }
            return (UnrealBuildToolConfig) this;
        }

        
        
    
        public virtual UnrealBuildToolConfig XmlConfigCache(object val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-XmlConfigCache",
                    Value: val?.ToString(),
                    Setter: '=',
                    Compatibility: UnrealCompatibility.UE4
                ));
            }
            return (UnrealBuildToolConfig) this;
        }

        
        
/// <summary>
/// Build all the modules that are valid for this target type. Used for CIS and making installed engine builds.
/// </summary>
        public virtual UnrealBuildToolConfig AllModules(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-AllModules",
                    Value: val?.ToString(),
                    Setter: '=',
                    Compatibility: UnrealCompatibility.UE4
                ));
            }
            return (UnrealBuildToolConfig) this;
        }

        
        
/// <summary>
/// Additional plugins that are built for this target type but not enabled.
/// </summary>
        public virtual UnrealBuildToolConfig BuildPlugin(object val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-BuildPlugin",
                    Value: val?.ToString(),
                    Setter: '=',
                    Compatibility: UnrealCompatibility.UE4
                ));
            }
            return (UnrealBuildToolConfig) this;
        }

        
        
/// <summary>
/// Additional plugins that should be included for this target.
/// </summary>
        public virtual UnrealBuildToolConfig EnablePlugin(object val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-EnablePlugin",
                    Value: val?.ToString(),
                    Setter: '=',
                    Compatibility: UnrealCompatibility.UE4
                ));
            }
            return (UnrealBuildToolConfig) this;
        }

        
        
/// <summary>
/// List of plugins to be disabled for this target. Note that the project file may still reference them, so they should be marked
/// as optional to avoid failing to find them at runtime.
/// </summary>
        public virtual UnrealBuildToolConfig DisablePlugin(object val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-DisablePlugin",
                    Value: val?.ToString(),
                    Setter: '=',
                    Compatibility: UnrealCompatibility.UE4
                ));
            }
            return (UnrealBuildToolConfig) this;
        }

        
        
/// <summary>
/// Whether this target should be compiled as a DLL.  Requires LinkType to be set to TargetLinkType.Monolithic.
/// </summary>
        public virtual UnrealBuildToolConfig CompileAsDll(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-CompileAsDll",
                    Value: val?.ToString(),
                    Setter: '=',
                    Compatibility: UnrealCompatibility.UE4
                ));
            }
            return (UnrealBuildToolConfig) this;
        }

        
        
/// <summary>
/// Whether to compile the Chaos physics plugin.
/// </summary>
        public virtual UnrealBuildToolConfig NoCompileChaos(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-NoCompileChaos",
                    Value: null,
                    Setter: '=',
                    Compatibility: UnrealCompatibility.UE4
                ));
            }
            return (UnrealBuildToolConfig) this;
        }

        
        
/// <summary>
/// Whether to compile the Chaos physics plugin.
/// </summary>
        public virtual UnrealBuildToolConfig CompileChaos(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-CompileChaos",
                    Value: null,
                    Setter: '=',
                    Compatibility: UnrealCompatibility.UE4
                ));
            }
            return (UnrealBuildToolConfig) this;
        }

        
        
/// <summary>
/// Whether to use the Chaos physics interface. This overrides the physx flags to disable APEX and NvCloth
/// </summary>
        public virtual UnrealBuildToolConfig NoUseChaos(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-NoUseChaos",
                    Value: null,
                    Setter: '=',
                    Compatibility: UnrealCompatibility.UE4
                ));
            }
            return (UnrealBuildToolConfig) this;
        }

        
        
/// <summary>
/// Whether to use the Chaos physics interface. This overrides the physx flags to disable APEX and NvCloth
/// </summary>
        public virtual UnrealBuildToolConfig UseChaos(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-UseChaos",
                    Value: null,
                    Setter: '=',
                    Compatibility: UnrealCompatibility.UE4
                ));
            }
            return (UnrealBuildToolConfig) this;
        }

        
        
/// <summary>
/// Enable RTTI for all modules.
/// </summary>
        public virtual UnrealBuildToolConfig Rtti(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-rtti",
                    Value: val?.ToString(),
                    Setter: '=',
                    Compatibility: UnrealCompatibility.UE4
                ));
            }
            return (UnrealBuildToolConfig) this;
        }

        
        
/// <summary>
/// Enables "include what you use" by default for modules in this target. Changes the default PCH mode for any module in this project to PCHUsageMode.UseExplicitOrSharedPCHs.
/// </summary>
        public virtual UnrealBuildToolConfig IWYU(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-IWYU",
                    Value: val?.ToString(),
                    Setter: '=',
                    Compatibility: UnrealCompatibility.UE4
                ));
            }
            return (UnrealBuildToolConfig) this;
        }

        
        
/// <summary>
/// Make static libraries for all engine modules as intermediates for this target.
/// </summary>
        public virtual UnrealBuildToolConfig Precompile(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Precompile",
                    Value: val?.ToString(),
                    Setter: '=',
                    Compatibility: UnrealCompatibility.UE4
                ));
            }
            return (UnrealBuildToolConfig) this;
        }

        
        
/// <summary>
/// Whether to unify C++ code into larger files for faster compilation.
/// </summary>
        public virtual UnrealBuildToolConfig DisableUnity(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-DisableUnity",
                    Value: null,
                    Setter: '=',
                    Compatibility: UnrealCompatibility.UE4
                ));
            }
            return (UnrealBuildToolConfig) this;
        }

        
        
/// <summary>
/// Whether to force C++ source files to be combined into larger files for faster compilation.
/// </summary>
        public virtual UnrealBuildToolConfig ForceUnity(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-ForceUnity",
                    Value: val?.ToString(),
                    Setter: '=',
                    Compatibility: UnrealCompatibility.UE4
                ));
            }
            return (UnrealBuildToolConfig) this;
        }

        
        
/// <summary>
/// Forces shadow variable warnings to be treated as errors on platforms that support it.
/// </summary>
        public virtual UnrealBuildToolConfig ShadowVariableErrors(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-ShadowVariableErrors",
                    Value: null,
                    Setter: '=',
                    Compatibility: UnrealCompatibility.UE4
                ));
            }
            return (UnrealBuildToolConfig) this;
        }

        
        
/// <summary>
/// New Monolithic Graphics drivers have optional "fast calls" replacing various D3d functions
/// </summary>
        public virtual UnrealBuildToolConfig FastMonoCalls(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-FastMonoCalls",
                    Value: null,
                    Setter: '=',
                    Compatibility: UnrealCompatibility.UE4
                ));
            }
            return (UnrealBuildToolConfig) this;
        }

        
        
/// <summary>
/// New Monolithic Graphics drivers have optional "fast calls" replacing various D3d functions
/// </summary>
        public virtual UnrealBuildToolConfig NoFastMonoCalls(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-NoFastMonoCalls",
                    Value: null,
                    Setter: '=',
                    Compatibility: UnrealCompatibility.UE4
                ));
            }
            return (UnrealBuildToolConfig) this;
        }

        
        
/// <summary>
/// Whether to stress test the C++ unity build robustness by including all C++ files files in a project from a single unified file.
/// </summary>
        public virtual UnrealBuildToolConfig StressTestUnity(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-StressTestUnity",
                    Value: val?.ToString(),
                    Setter: '=',
                    Compatibility: UnrealCompatibility.UE4
                ));
            }
            return (UnrealBuildToolConfig) this;
        }

        
        
/// <summary>
/// Whether to force debug info to be generated.
/// </summary>
        public virtual UnrealBuildToolConfig ForceDebugInfo(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-ForceDebugInfo",
                    Value: val?.ToString(),
                    Setter: '=',
                    Compatibility: UnrealCompatibility.UE4
                ));
            }
            return (UnrealBuildToolConfig) this;
        }

        
        
/// <summary>
/// Whether to globally disable debug info generation; see DebugInfoHeuristics.cs for per-config and per-platform options.
/// </summary>
        public virtual UnrealBuildToolConfig NoDebugInfo(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-NoDebugInfo",
                    Value: val?.ToString(),
                    Setter: '=',
                    Compatibility: UnrealCompatibility.UE4
                ));
            }
            return (UnrealBuildToolConfig) this;
        }

        
        
/// <summary>
/// Whether PDB files should be used for Visual C++ builds.
/// </summary>
        public virtual UnrealBuildToolConfig NoPDB(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-NoPDB",
                    Value: null,
                    Setter: '=',
                    Compatibility: UnrealCompatibility.UE4
                ));
            }
            return (UnrealBuildToolConfig) this;
        }

        
        
/// <summary>
/// Whether PCH files should be used.
/// </summary>
        public virtual UnrealBuildToolConfig NoPCH(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-NoPCH",
                    Value: null,
                    Setter: '=',
                    Compatibility: UnrealCompatibility.UE4
                ));
            }
            return (UnrealBuildToolConfig) this;
        }

        
        
/// <summary>
/// Whether to just preprocess source files for this target, and skip compilation
/// </summary>
        public virtual UnrealBuildToolConfig Preprocess(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Preprocess",
                    Value: val?.ToString(),
                    Setter: '=',
                    Compatibility: UnrealCompatibility.UE4
                ));
            }
            return (UnrealBuildToolConfig) this;
        }

        
        
/// <summary>
/// Whether to use incremental linking or not. Incremental linking can yield faster iteration times when making small changes.
/// Currently disabled by default because it tends to behave a bit buggy on some computers (PDB-related compile errors).
/// </summary>
        public virtual UnrealBuildToolConfig IncrementalLinking(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-IncrementalLinking",
                    Value: val?.ToString(),
                    Setter: '=',
                    Compatibility: UnrealCompatibility.UE4
                ));
            }
            return (UnrealBuildToolConfig) this;
        }

        
        
/// <summary>
/// Whether to use incremental linking or not. Incremental linking can yield faster iteration times when making small changes.
/// Currently disabled by default because it tends to behave a bit buggy on some computers (PDB-related compile errors).
/// </summary>
        public virtual UnrealBuildToolConfig NoIncrementalLinking(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-NoIncrementalLinking",
                    Value: null,
                    Setter: '=',
                    Compatibility: UnrealCompatibility.UE4
                ));
            }
            return (UnrealBuildToolConfig) this;
        }

        
        
/// <summary>
/// Whether to allow the use of link time code generation (LTCG).
/// </summary>
        public virtual UnrealBuildToolConfig LTCG(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-LTCG",
                    Value: val?.ToString(),
                    Setter: '=',
                    Compatibility: UnrealCompatibility.UE4
                ));
            }
            return (UnrealBuildToolConfig) this;
        }

        
        
/// <summary>
/// Whether to enable Profile Guided Optimization (PGO) instrumentation in this build.
/// </summary>
        public virtual UnrealBuildToolConfig PGOProfile(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-PGOProfile",
                    Value: null,
                    Setter: '=',
                    Compatibility: UnrealCompatibility.UE4
                ));
            }
            return (UnrealBuildToolConfig) this;
        }

        
        
/// <summary>
/// Whether to optimize this build with Profile Guided Optimization (PGO).
/// </summary>
        public virtual UnrealBuildToolConfig PGOOptimize(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-PGOOptimize",
                    Value: null,
                    Setter: '=',
                    Compatibility: UnrealCompatibility.UE4
                ));
            }
            return (UnrealBuildToolConfig) this;
        }

        
        
/// <summary>
/// Enables "Shared PCHs", a feature which significantly speeds up compile times by attempting to
/// share certain PCH files between modules that UBT detects is including those PCH's header files.
/// </summary>
        public virtual UnrealBuildToolConfig NoSharedPCH(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-NoSharedPCH",
                    Value: null,
                    Setter: '=',
                    Compatibility: UnrealCompatibility.UE4
                ));
            }
            return (UnrealBuildToolConfig) this;
        }

        
        
/// <summary>
/// Whether to use the :FASTLINK option when building with /DEBUG to create local PDBs on Windows. Fast, but currently seems to have problems finding symbols in the debugger.
/// </summary>
        public virtual UnrealBuildToolConfig FastPDB(object val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-FastPDB",
                    Value: val?.ToString(),
                    Setter: '=',
                    Compatibility: UnrealCompatibility.UE4
                ));
            }
            return (UnrealBuildToolConfig) this;
        }

        
        
/// <summary>
/// Outputs a map file as part of the build.
/// </summary>
        public virtual UnrealBuildToolConfig MapFile(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-MapFile",
                    Value: val?.ToString(),
                    Setter: '=',
                    Compatibility: UnrealCompatibility.UE4
                ));
            }
            return (UnrealBuildToolConfig) this;
        }

        
        
/// <summary>
/// Bundle version for Mac apps.
/// </summary>
        public virtual UnrealBuildToolConfig BundleVersion(object val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-BundleVersion",
                    Value: val?.ToString(),
                    Setter: '=',
                    Compatibility: UnrealCompatibility.UE4
                ));
            }
            return (UnrealBuildToolConfig) this;
        }

        
        
/// <summary>
/// Whether to deploy the executable after compilation on platforms that require deployment.
/// </summary>
        public virtual UnrealBuildToolConfig Deploy(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Deploy",
                    Value: val?.ToString(),
                    Setter: '=',
                    Compatibility: UnrealCompatibility.UE4
                ));
            }
            return (UnrealBuildToolConfig) this;
        }

        
        
/// <summary>
/// Whether to disable linking for this target.
/// </summary>
        public virtual UnrealBuildToolConfig NoLink(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-NoLink",
                    Value: val?.ToString(),
                    Setter: '=',
                    Compatibility: UnrealCompatibility.UE4
                ));
            }
            return (UnrealBuildToolConfig) this;
        }

        
        
/// <summary>
/// Indicates that this is a formal build, intended for distribution. This flag is automatically set to true when Build.version has a changelist set.
/// The only behavior currently bound to this flag is to compile the default resource file separately for each binary so that the OriginalFilename field is set correctly.
/// By default, we only compile the resource once to reduce build times.
/// </summary>
        public virtual UnrealBuildToolConfig Formal(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Formal",
                    Value: val?.ToString(),
                    Setter: '=',
                    Compatibility: UnrealCompatibility.UE4
                ));
            }
            return (UnrealBuildToolConfig) this;
        }

        
        
/// <summary>
/// Whether to clean Builds directory on a remote Mac before building.
/// </summary>
        public virtual UnrealBuildToolConfig FlushMac(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-FlushMac",
                    Value: val?.ToString(),
                    Setter: '=',
                    Compatibility: UnrealCompatibility.UE4
                ));
            }
            return (UnrealBuildToolConfig) this;
        }

        
        
/// <summary>
/// Whether to write detailed timing info from the compiler and linker.
/// </summary>
        public virtual UnrealBuildToolConfig Timing(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Timing",
                    Value: val?.ToString(),
                    Setter: '=',
                    Compatibility: UnrealCompatibility.UE4
                ));
            }
            return (UnrealBuildToolConfig) this;
        }

        
        
/// <summary>
/// Whether to parse timing data into a tracing file compatible with chrome://tracing.
/// </summary>
        public virtual UnrealBuildToolConfig Tracing(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Tracing",
                    Value: val?.ToString(),
                    Setter: '=',
                    Compatibility: UnrealCompatibility.UE4
                ));
            }
            return (UnrealBuildToolConfig) this;
        }

        
        
/// <summary>
/// Whether to expose all symbols as public by default on POSIX platforms
/// </summary>
        public virtual UnrealBuildToolConfig PublicSymbolsByDefault(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-PublicSymbolsByDefault",
                    Value: val?.ToString(),
                    Setter: '=',
                    Compatibility: UnrealCompatibility.UE4
                ));
            }
            return (UnrealBuildToolConfig) this;
        }

        
        
/// <summary>
/// Allows overriding the toolchain to be created for this target. This must match the name of a class declared in the UnrealBuildTool assembly.
/// </summary>
        public virtual UnrealBuildToolConfig ToolChain(object val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-ToolChain",
                    Value: val?.ToString(),
                    Setter: '=',
                    Compatibility: UnrealCompatibility.UE4
                ));
            }
            return (UnrealBuildToolConfig) this;
        }

        
        
/// <summary>
/// Which C++ stanard to use for compiling this target
/// </summary>
        public virtual UnrealBuildToolConfig CppStd(CppStandardVersion? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-CppStd",
                    Value: val?.ToString(),
                    Setter: '=',
                    Compatibility: UnrealCompatibility.UE4
                ));
            }
            return (UnrealBuildToolConfig) this;
        }

        
        
/// <summary>
/// The build version string
/// </summary>
        public virtual UnrealBuildToolConfig BuildVersion(object val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-BuildVersion",
                    Value: val?.ToString(),
                    Setter: '=',
                    Compatibility: UnrealCompatibility.UE4
                ));
            }
            return (UnrealBuildToolConfig) this;
        }

        
        
/// <summary>
/// Macros to define globally across the whole target.
/// </summary>
        public virtual UnrealBuildToolConfig Define(object val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Define",
                    Value: val?.ToString(),
                    Setter: ':',
                    Compatibility: UnrealCompatibility.UE4
                ));
            }
            return (UnrealBuildToolConfig) this;
        }

        
        
/// <summary>
/// Macros to define across all macros in the project.
/// </summary>
        public virtual UnrealBuildToolConfig ProjectDefine(object val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-ProjectDefine",
                    Value: val?.ToString(),
                    Setter: ':',
                    Compatibility: UnrealCompatibility.UE4
                ));
            }
            return (UnrealBuildToolConfig) this;
        }

        
        
/// <summary>
/// Path to a manifest to output for this target
/// </summary>
        public virtual UnrealBuildToolConfig Manifest(object val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Manifest",
                    Value: val?.ToString(),
                    Setter: '=',
                    Compatibility: UnrealCompatibility.UE4
                ));
            }
            return (UnrealBuildToolConfig) this;
        }

        
        
/// <summary>
/// Path to a list of dependencies for this target, when precompiling
/// </summary>
        public virtual UnrealBuildToolConfig DependencyList(object val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-DependencyList",
                    Value: val?.ToString(),
                    Setter: '=',
                    Compatibility: UnrealCompatibility.UE4
                ));
            }
            return (UnrealBuildToolConfig) this;
        }

        
        
/// <summary>
/// Whether to ignore violations to the shared build environment (eg. editor targets modifying definitions)
/// </summary>
        public virtual UnrealBuildToolConfig OverrideBuildEnvironment(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-OverrideBuildEnvironment",
                    Value: val?.ToString(),
                    Setter: '=',
                    Compatibility: UnrealCompatibility.UE4
                ));
            }
            return (UnrealBuildToolConfig) this;
        }

        
        
/// <summary>
/// Additional arguments to pass to the compiler
/// </summary>
        public virtual UnrealBuildToolConfig CompilerArguments(object val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-CompilerArguments",
                    Value: val?.ToString(),
                    Setter: '=',
                    Compatibility: UnrealCompatibility.UE4
                ));
            }
            return (UnrealBuildToolConfig) this;
        }

        
        
/// <summary>
/// Additional arguments to pass to the linker
/// </summary>
        public virtual UnrealBuildToolConfig LinkerArguments(object val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-LinkerArguments",
                    Value: val?.ToString(),
                    Setter: '=',
                    Compatibility: UnrealCompatibility.UE4
                ));
            }
            return (UnrealBuildToolConfig) this;
        }

        
        
/// <summary>
/// Whether to build the iOS project as a framework.
/// </summary>
        public virtual UnrealBuildToolConfig BuildAsFramework(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-build-as-framework",
                    Value: val?.ToString(),
                    Setter: '=',
                    Compatibility: UnrealCompatibility.UE4
                ));
            }
            return (UnrealBuildToolConfig) this;
        }

        
        
/// <summary>
/// Whether to generate a dSYM file or not.
/// </summary>
        public virtual UnrealBuildToolConfig Generatedsymfile(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-generatedsymfile",
                    Value: val?.ToString(),
                    Setter: '=',
                    Compatibility: UnrealCompatibility.UE4
                ));
            }
            return (UnrealBuildToolConfig) this;
        }

        
        
/// <summary>
/// Whether to generate a dSYM bundle (as opposed to single file dSYM)
/// </summary>
        public virtual UnrealBuildToolConfig Generatedsymbundle(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-generatedsymbundle",
                    Value: val?.ToString(),
                    Setter: '=',
                    Compatibility: UnrealCompatibility.UE4
                ));
            }
            return (UnrealBuildToolConfig) this;
        }

        
        
/// <summary>
/// Lists Architectures that you want to build
/// </summary>
        public virtual UnrealBuildToolConfig Architectures(object val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Architectures",
                    Value: val?.ToString(),
                    Setter: '=',
                    Compatibility: UnrealCompatibility.UE4
                ));
            }
            return (UnrealBuildToolConfig) this;
        }

        
        
/// <summary>
/// Lists GPU Architectures that you want to build (mostly used for mobile etc.)
/// </summary>
        public virtual UnrealBuildToolConfig GPUArchitectures(object val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-GPUArchitectures",
                    Value: val?.ToString(),
                    Setter: '=',
                    Compatibility: UnrealCompatibility.UE4
                ));
            }
            return (UnrealBuildToolConfig) this;
        }

        
        
/// <summary>
/// Ignore AppBundle (AAB) generation setting if "-ForceAPKGeneration" specified
/// </summary>
        public virtual UnrealBuildToolConfig ForceAPKGeneration(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-ForceAPKGeneration",
                    Value: null,
                    Setter: '=',
                    Compatibility: UnrealCompatibility.UE4
                ));
            }
            return (UnrealBuildToolConfig) this;
        }

        
        
/// <summary>
/// Version of the compiler toolchain to use on HoloLens. A value of "default" will be changed to a specific version at UBT startup.
/// 
/// 
/// Version of the compiler toolchain to use on Windows platform. A value of "default" will be changed to a specific version at UBT start up.
/// </summary>
        public virtual UnrealBuildToolConfig _2015(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-2015",
                    Value: null,
                    Setter: '=',
                    Compatibility: UnrealCompatibility.UE4
                ));
            }
            return (UnrealBuildToolConfig) this;
        }

        
        
/// <summary>
/// Version of the compiler toolchain to use on HoloLens. A value of "default" will be changed to a specific version at UBT startup.
/// 
/// 
/// Version of the compiler toolchain to use on Windows platform. A value of "default" will be changed to a specific version at UBT start up.
/// </summary>
        public virtual UnrealBuildToolConfig _2017(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-2017",
                    Value: null,
                    Setter: '=',
                    Compatibility: UnrealCompatibility.UE4
                ));
            }
            return (UnrealBuildToolConfig) this;
        }

        
        
/// <summary>
/// Version of the compiler toolchain to use on HoloLens. A value of "default" will be changed to a specific version at UBT startup.
/// 
/// 
/// Version of the compiler toolchain to use on Windows platform. A value of "default" will be changed to a specific version at UBT start up.
/// </summary>
        public virtual UnrealBuildToolConfig _2019(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-2019",
                    Value: null,
                    Setter: '=',
                    Compatibility: UnrealCompatibility.UE4
                ));
            }
            return (UnrealBuildToolConfig) this;
        }

        
        
/// <summary>
/// Version of the compiler toolchain to use on HoloLens. A value of "default" will be changed to a specific version at UBT startup.
/// 
/// 
/// Version of the compiler toolchain to use on Windows platform. A value of "default" will be changed to a specific version at UBT start up.
/// </summary>
        public virtual UnrealBuildToolConfig _2022(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-2022",
                    Value: null,
                    Setter: '=',
                    Compatibility: UnrealCompatibility.UE4
                ));
            }
            return (UnrealBuildToolConfig) this;
        }

        
        
/// <summary>
/// Whether to strip iOS symbols or not (implied by Shipping config).
/// </summary>
        public virtual UnrealBuildToolConfig Stripsymbols(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-stripsymbols",
                    Value: null,
                    Setter: '=',
                    Compatibility: UnrealCompatibility.UE4
                ));
            }
            return (UnrealBuildToolConfig) this;
        }

        
        
/// <summary>
/// If true, then a stub IPA will be generated when compiling is done (minimal files needed for a valid IPA).
/// </summary>
        public virtual UnrealBuildToolConfig CreateStub(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-CreateStub",
                    Value: null,
                    Setter: '=',
                    Compatibility: UnrealCompatibility.UE4
                ));
            }
            return (UnrealBuildToolConfig) this;
        }

        
        
/// <summary>
/// Don't generate crashlytics data
/// </summary>
        public virtual UnrealBuildToolConfig Alwaysgeneratedsym(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-alwaysgeneratedsym",
                    Value: null,
                    Setter: '=',
                    Compatibility: UnrealCompatibility.UE4
                ));
            }
            return (UnrealBuildToolConfig) this;
        }

        
        
/// <summary>
/// Don't generate crashlytics data
/// </summary>
        public virtual UnrealBuildToolConfig Skipcrashlytics(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-skipcrashlytics",
                    Value: val?.ToString(),
                    Setter: '=',
                    Compatibility: UnrealCompatibility.UE4
                ));
            }
            return (UnrealBuildToolConfig) this;
        }

        
        
/// <summary>
/// Mark the build for distribution
/// 
/// 
/// If -distribution was passed on the commandline, this build is for distribution.
/// </summary>
        public virtual UnrealBuildToolConfig Distribution(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-distribution",
                    Value: val?.ToString(),
                    Setter: '=',
                    Compatibility: UnrealCompatibility.UE4
                ));
            }
            return (UnrealBuildToolConfig) this;
        }

        
        
/// <summary>
/// Manual override for the provision to use. Should be a full path.
/// </summary>
        public virtual UnrealBuildToolConfig ImportProvision(object val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-ImportProvision",
                    Value: val?.ToString(),
                    Setter: '=',
                    Compatibility: UnrealCompatibility.UE4
                ));
            }
            return (UnrealBuildToolConfig) this;
        }

        
        
/// <summary>
/// Imports the given certificate (inc private key) into a temporary keychain before signing.
/// </summary>
        public virtual UnrealBuildToolConfig ImportCertificate(object val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-ImportCertificate",
                    Value: val?.ToString(),
                    Setter: '=',
                    Compatibility: UnrealCompatibility.UE4
                ));
            }
            return (UnrealBuildToolConfig) this;
        }

        
        
/// <summary>
/// Password for the imported certificate
/// </summary>
        public virtual UnrealBuildToolConfig ImportCertificatePassword(object val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-ImportCertificatePassword",
                    Value: val?.ToString(),
                    Setter: '=',
                    Compatibility: UnrealCompatibility.UE4
                ));
            }
            return (UnrealBuildToolConfig) this;
        }

        
        
/// <summary>
/// Enables memory sanitizer (MSan)
/// </summary>
        public virtual UnrealBuildToolConfig EnableMSan(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-EnableMSan",
                    Value: val?.ToString(),
                    Setter: '=',
                    Compatibility: UnrealCompatibility.UE4
                ));
            }
            return (UnrealBuildToolConfig) this;
        }

        
        
/// <summary>
/// Enables "thin" LTO
/// </summary>
        public virtual UnrealBuildToolConfig ThinLTO(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-ThinLTO",
                    Value: val?.ToString(),
                    Setter: '=',
                    Compatibility: UnrealCompatibility.UE4
                ));
            }
            return (UnrealBuildToolConfig) this;
        }

        
        
/// <summary>
/// Use existing static libraries for all engine modules in this target.
/// </summary>
        public virtual UnrealBuildToolConfig UsePrecompiled(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-UsePrecompiled",
                    Value: val?.ToString(),
                    Setter: '=',
                    Compatibility: UnrealCompatibility.UE4
                ));
            }
            return (UnrealBuildToolConfig) this;
        }

        
        
/// <summary>
/// Whether XGE may be used.
/// </summary>
        public virtual UnrealBuildToolConfig NoXGE(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-NoXGE",
                    Value: null,
                    Setter: '=',
                    Compatibility: UnrealCompatibility.UE4
                ));
            }
            return (UnrealBuildToolConfig) this;
        }

        
        
/// <summary>
/// Whether FASTBuild may be used.
/// </summary>
        public virtual UnrealBuildToolConfig NoFASTBuild(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-NoFASTBuild",
                    Value: null,
                    Setter: '=',
                    Compatibility: UnrealCompatibility.UE4
                ));
            }
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
        public virtual UnrealBuildToolConfig NoUBTMakefiles(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-NoUBTMakefiles",
                    Value: null,
                    Setter: '=',
                    Compatibility: UnrealCompatibility.UE4
                ));
            }
            return (UnrealBuildToolConfig) this;
        }

        
        
/// <summary>
/// Number of actions that can be executed in parallel. If 0 then code will pick a default based
/// on the number of cores available. Only applies to the ParallelExecutor
/// </summary>
        public virtual UnrealBuildToolConfig MaxParallelActions(double? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-MaxParallelActions",
                    Value: val?.ToString(),
                    Setter: '=',
                    Compatibility: UnrealCompatibility.UE4
                ));
            }
            return (UnrealBuildToolConfig) this;
        }

        
        
/// <summary>
/// If true, force header regeneration. Intended for the build machine.
/// </summary>
        public virtual UnrealBuildToolConfig ForceHeaderGeneration(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-ForceHeaderGeneration",
                    Value: val?.ToString(),
                    Setter: '=',
                    Compatibility: UnrealCompatibility.UE4
                ));
            }
            return (UnrealBuildToolConfig) this;
        }

        
        
/// <summary>
/// If true, do not build UHT, assume it is already built.
/// </summary>
        public virtual UnrealBuildToolConfig NoBuildUHT(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-NoBuildUHT",
                    Value: val?.ToString(),
                    Setter: '=',
                    Compatibility: UnrealCompatibility.UE4
                ));
            }
            return (UnrealBuildToolConfig) this;
        }

        
        
/// <summary>
/// If true, fail if any of the generated header files is out of date.
/// </summary>
        public virtual UnrealBuildToolConfig FailIfGeneratedCodeChanges(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-FailIfGeneratedCodeChanges",
                    Value: val?.ToString(),
                    Setter: '=',
                    Compatibility: UnrealCompatibility.UE4
                ));
            }
            return (UnrealBuildToolConfig) this;
        }

        
        
/// <summary>
/// True if hot-reload from IDE is allowed.
/// </summary>
        public virtual UnrealBuildToolConfig NoHotReloadFromIDE(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-NoHotReloadFromIDE",
                    Value: null,
                    Setter: '=',
                    Compatibility: UnrealCompatibility.UE4
                ));
            }
            return (UnrealBuildToolConfig) this;
        }

        
        
/// <summary>
/// Whether to skip compiling rules assemblies and just assume they are valid
/// </summary>
        public virtual UnrealBuildToolConfig SkipRulesCompile(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-SkipRulesCompile",
                    Value: val?.ToString(),
                    Setter: '=',
                    Compatibility: UnrealCompatibility.UE4
                ));
            }
            return (UnrealBuildToolConfig) this;
        }

        
        
/// <summary>
/// Version of the compiler toolchain to use on Windows platform. A value of "default" will be changed to a specific version at UBT start up.
/// </summary>
        public virtual UnrealBuildToolConfig Compiler(WindowsCompiler? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Compiler",
                    Value: val?.ToString(),
                    Setter: '=',
                    Compatibility: UnrealCompatibility.UE4
                ));
            }
            return (UnrealBuildToolConfig) this;
        }

        
        
/// <summary>
/// The specific toolchain version to use. This may be a specific version number (for example, "14.13.26128"), the string "Latest" to select the newest available version, or
/// the string "Preview" to select the newest available preview version. By default, and if it is available, we use the toolchain version indicated by
/// WindowsPlatform.DefaultToolChainVersion (otherwise, we use the latest version).
/// </summary>
        public virtual UnrealBuildToolConfig CompilerVersion(object val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-CompilerVersion",
                    Value: val?.ToString(),
                    Setter: '=',
                    Compatibility: UnrealCompatibility.UE4
                ));
            }
            return (UnrealBuildToolConfig) this;
        }

        
        
/// <summary>
/// The static analyzer to use.
/// </summary>
        public virtual UnrealBuildToolConfig StaticAnalyzer(WindowsStaticAnalyzer? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-StaticAnalyzer",
                    Value: val?.ToString(),
                    Setter: '=',
                    Compatibility: UnrealCompatibility.UE4
                ));
            }
            return (UnrealBuildToolConfig) this;
        }

        
        
/// <summary>
/// Whether we should export a file containing .obj to source file mappings.
/// </summary>
        public virtual UnrealBuildToolConfig ObjSrcMap(object val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-ObjSrcMap",
                    Value: val?.ToString(),
                    Setter: '=',
                    Compatibility: UnrealCompatibility.UE4
                ));
            }
            return (UnrealBuildToolConfig) this;
        }

        
        
/// <summary>
/// Enables strict standard conformance mode (/permissive-) in VS2017+.
/// </summary>
        public virtual UnrealBuildToolConfig Strict(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Strict",
                    Value: val?.ToString(),
                    Setter: '=',
                    Compatibility: UnrealCompatibility.UE4
                ));
            }
            return (UnrealBuildToolConfig) this;
        }

        
        
/// <summary>
/// Print out files that are included by each source file
/// </summary>
        public virtual UnrealBuildToolConfig ShowIncludes(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-ShowIncludes",
                    Value: val?.ToString(),
                    Setter: '=',
                    Compatibility: UnrealCompatibility.UE4
                ));
            }
            return (UnrealBuildToolConfig) this;
        }

        
        
/// <summary>
/// The amount of detail to write to the log
/// </summary>
        public virtual UnrealBuildToolConfig Verbose(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Verbose",
                    Value: null,
                    Setter: '=',
                    Compatibility: UnrealCompatibility.UE4
                ));
            }
            return (UnrealBuildToolConfig) this;
        }

        
        
/// <summary>
/// The amount of detail to write to the log
/// </summary>
        public virtual UnrealBuildToolConfig VeryVerbose(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-VeryVerbose",
                    Value: null,
                    Setter: '=',
                    Compatibility: UnrealCompatibility.UE4
                ));
            }
            return (UnrealBuildToolConfig) this;
        }

        
        
/// <summary>
/// Specifies the path to a log file to write. Note that the default mode (eg. building, generating project files) will create a log file by default if this not specified.
/// </summary>
        public virtual UnrealBuildToolConfig Log(object val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Log",
                    Value: val?.ToString(),
                    Setter: '=',
                    Compatibility: UnrealCompatibility.UE4
                ));
            }
            return (UnrealBuildToolConfig) this;
        }

        
        
/// <summary>
/// Whether to include timestamps in the log
/// </summary>
        public virtual UnrealBuildToolConfig Timestamps(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Timestamps",
                    Value: val?.ToString(),
                    Setter: '=',
                    Compatibility: UnrealCompatibility.UE4
                ));
            }
            return (UnrealBuildToolConfig) this;
        }

        
        
/// <summary>
/// Whether to format messages in MsBuild format
/// </summary>
        public virtual UnrealBuildToolConfig FromMsBuild(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-FromMsBuild",
                    Value: val?.ToString(),
                    Setter: '=',
                    Compatibility: UnrealCompatibility.UE4
                ));
            }
            return (UnrealBuildToolConfig) this;
        }

        
        
/// <summary>
/// Whether to write progress markup in a format that can be parsed by other programs
/// </summary>
        public virtual UnrealBuildToolConfig Progress(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Progress",
                    Value: val?.ToString(),
                    Setter: '=',
                    Compatibility: UnrealCompatibility.UE4
                ));
            }
            return (UnrealBuildToolConfig) this;
        }

        
        
/// <summary>
/// Whether to ignore the mutex
/// </summary>
        public virtual UnrealBuildToolConfig NoMutex(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-NoMutex",
                    Value: val?.ToString(),
                    Setter: '=',
                    Compatibility: UnrealCompatibility.UE4
                ));
            }
            return (UnrealBuildToolConfig) this;
        }

        
        
/// <summary>
/// Whether to wait for the mutex rather than aborting immediately
/// </summary>
        public virtual UnrealBuildToolConfig WaitMutex(bool? val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-WaitMutex",
                    Value: val?.ToString(),
                    Setter: '=',
                    Compatibility: UnrealCompatibility.UE4
                ));
            }
            return (UnrealBuildToolConfig) this;
        }

        
        
/// <summary>
/// Whether to wait for the mutex rather than aborting immediately
/// </summary>
        public virtual UnrealBuildToolConfig RemoteIni(object val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-RemoteIni",
                    Value: val?.ToString(),
                    Setter: '=',
                    Compatibility: UnrealCompatibility.UE4
                ));
            }
            return (UnrealBuildToolConfig) this;
        }

        
        
/// <summary>
/// The mode to execute
/// </summary>
        public virtual UnrealBuildToolConfig Mode(object val = null)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Mode",
                    Value: val?.ToString(),
                    Setter: '=',
                    Compatibility: UnrealCompatibility.UE4
                ));
            }
            return (UnrealBuildToolConfig) this;
        }

        
        
/// <summary>
/// The mode to execute
/// </summary>
        public virtual UnrealBuildToolConfig Clean(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Clean",
                    Value: null,
                    Setter: '=',
                    Compatibility: UnrealCompatibility.UE4
                ));
            }
            return (UnrealBuildToolConfig) this;
        }

        
        
/// <summary>
/// The mode to execute
/// </summary>
        public virtual UnrealBuildToolConfig ProjectFiles(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-ProjectFiles",
                    Value: null,
                    Setter: '=',
                    Compatibility: UnrealCompatibility.UE4
                ));
            }
            return (UnrealBuildToolConfig) this;
        }

        
        
/// <summary>
/// The mode to execute
/// </summary>
        public virtual UnrealBuildToolConfig ProjectFileFormat(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-ProjectFileFormat",
                    Value: null,
                    Setter: '=',
                    Compatibility: UnrealCompatibility.UE4
                ));
            }
            return (UnrealBuildToolConfig) this;
        }

        
        
/// <summary>
/// The mode to execute
/// </summary>
        public virtual UnrealBuildToolConfig Makefile(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Makefile",
                    Value: null,
                    Setter: '=',
                    Compatibility: UnrealCompatibility.UE4
                ));
            }
            return (UnrealBuildToolConfig) this;
        }

        
        
/// <summary>
/// The mode to execute
/// </summary>
        public virtual UnrealBuildToolConfig CMakefile(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-CMakefile",
                    Value: null,
                    Setter: '=',
                    Compatibility: UnrealCompatibility.UE4
                ));
            }
            return (UnrealBuildToolConfig) this;
        }

        
        
/// <summary>
/// The mode to execute
/// </summary>
        public virtual UnrealBuildToolConfig QMakefile(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-QMakefile",
                    Value: null,
                    Setter: '=',
                    Compatibility: UnrealCompatibility.UE4
                ));
            }
            return (UnrealBuildToolConfig) this;
        }

        
        
/// <summary>
/// The mode to execute
/// </summary>
        public virtual UnrealBuildToolConfig KDevelopfile(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-KDevelopfile",
                    Value: null,
                    Setter: '=',
                    Compatibility: UnrealCompatibility.UE4
                ));
            }
            return (UnrealBuildToolConfig) this;
        }

        
        
/// <summary>
/// The mode to execute
/// </summary>
        public virtual UnrealBuildToolConfig CodeliteFiles(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-CodeliteFiles",
                    Value: null,
                    Setter: '=',
                    Compatibility: UnrealCompatibility.UE4
                ));
            }
            return (UnrealBuildToolConfig) this;
        }

        
        
/// <summary>
/// The mode to execute
/// </summary>
        public virtual UnrealBuildToolConfig XCodeProjectFiles(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-XCodeProjectFiles",
                    Value: null,
                    Setter: '=',
                    Compatibility: UnrealCompatibility.UE4
                ));
            }
            return (UnrealBuildToolConfig) this;
        }

        
        
/// <summary>
/// The mode to execute
/// </summary>
        public virtual UnrealBuildToolConfig EdditProjectFiles(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-EdditProjectFiles",
                    Value: null,
                    Setter: '=',
                    Compatibility: UnrealCompatibility.UE4
                ));
            }
            return (UnrealBuildToolConfig) this;
        }

        
        
/// <summary>
/// The mode to execute
/// </summary>
        public virtual UnrealBuildToolConfig VSCode(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-VSCode",
                    Value: null,
                    Setter: '=',
                    Compatibility: UnrealCompatibility.UE4
                ));
            }
            return (UnrealBuildToolConfig) this;
        }

        
        
/// <summary>
/// The mode to execute
/// </summary>
        public virtual UnrealBuildToolConfig VSMac(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-VSMac",
                    Value: null,
                    Setter: '=',
                    Compatibility: UnrealCompatibility.UE4
                ));
            }
            return (UnrealBuildToolConfig) this;
        }

        
        
/// <summary>
/// The mode to execute
/// </summary>
        public virtual UnrealBuildToolConfig CLion(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-CLion",
                    Value: null,
                    Setter: '=',
                    Compatibility: UnrealCompatibility.UE4
                ));
            }
            return (UnrealBuildToolConfig) this;
        }

        
        
/// <summary>
/// The mode to execute
/// </summary>
        public virtual UnrealBuildToolConfig Rider(bool present = true)
        {
            if (present)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Rider",
                    Value: null,
                    Setter: '=',
                    Compatibility: UnrealCompatibility.UE4
                ));
            }
            return (UnrealBuildToolConfig) this;
        }

        
/// <summary>
/// Builds a target
/// </summary>
    public  class BuildConfig : ToolConfig
    {
        public override string Name => "Build";
        public override string CliName => "-Build";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE4;
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    }

    protected readonly BuildConfig BuildStorage = new();
        
/// <summary>
/// Cleans build products and intermediates for the target. This deletes files which are named consistently with the target being built
/// (e.g. UE4Editor-Foo-Win64-Debug.dll) rather than an actual record of previous build products.
/// </summary>
    public  class CleanConfig : ToolConfig
    {
        public override string Name => "Clean";
        public override string CliName => "-Clean";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE4;
    
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
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE4;
    
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
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE4;
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    }

    protected readonly ExecuteConfig ExecuteStorage = new();
        
/// <summary>
/// Exports a target as a JSON file
/// </summary>
    public  class JsonExportConfig : ToolConfig
    {
        public override string Name => "JsonExport";
        public override string CliName => "-JsonExport";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE4;
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    }

    protected readonly JsonExportConfig JsonExportStorage = new();
        
    
    public  class IOSPostBuildSyncConfig : ToolConfig
    {
        public override string Name => "IOSPostBuildSync";
        public override string CliName => "-IOSPostBuildSync";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE4;
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
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
    public UnrealBuildToolConfig Build(Action<BuildConfig> configurator)
    {
        configurator?.Invoke(BuildStorage);
        AppendSubtool(BuildStorage);
        return (UnrealBuildToolConfig) this;
    }
/// <summary>
/// Cleans build products and intermediates for the target. This deletes files which are named consistently with the target being built
/// (e.g. UE4Editor-Foo-Win64-Debug.dll) rather than an actual record of previous build products.
/// </summary>
    public UnrealBuildToolConfig Clean(Action<CleanConfig> configurator)
    {
        configurator?.Invoke(CleanStorage);
        AppendSubtool(CleanStorage);
        return (UnrealBuildToolConfig) this;
    }
/// <summary>
/// Invokes the deployment handler for a target.
/// </summary>
    public UnrealBuildToolConfig Deploy(Action<DeployConfig> configurator)
    {
        configurator?.Invoke(DeployStorage);
        AppendSubtool(DeployStorage);
        return (UnrealBuildToolConfig) this;
    }
/// <summary>
/// Builds a target
/// </summary>
    public UnrealBuildToolConfig Execute(Action<ExecuteConfig> configurator)
    {
        configurator?.Invoke(ExecuteStorage);
        AppendSubtool(ExecuteStorage);
        return (UnrealBuildToolConfig) this;
    }
/// <summary>
/// Exports a target as a JSON file
/// </summary>
    public UnrealBuildToolConfig JsonExport(Action<JsonExportConfig> configurator)
    {
        configurator?.Invoke(JsonExportStorage);
        AppendSubtool(JsonExportStorage);
        return (UnrealBuildToolConfig) this;
    }

    public UnrealBuildToolConfig IOSPostBuildSync(Action<IOSPostBuildSyncConfig> configurator)
    {
        configurator?.Invoke(IOSPostBuildSyncStorage);
        AppendSubtool(IOSPostBuildSyncStorage);
        return (UnrealBuildToolConfig) this;
    }
}
