

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace Nuke.Unreal.Tools;






public abstract class UnrealBuildToolConfigGenerated : ToolConfig
{
    public override string Name => "UnrealBuildTool";


    
        /// <summary>
        /// No description
        /// </summary>
        public UnrealBuildToolConfig EnableASan(bool? val = null)
        {
            AppendArgument(val == null ? "-EnableASan" : "-EnableASan=" + val.ToString());
            return (UnrealBuildToolConfig) this;
        }

    
    
        /// <summary>
        /// No description
        /// </summary>
        public UnrealBuildToolConfig EnableTSan(bool? val = null)
        {
            AppendArgument(val == null ? "-EnableTSan" : "-EnableTSan=" + val.ToString());
            return (UnrealBuildToolConfig) this;
        }

    
    
        /// <summary>
        /// No description
        /// </summary>
        public UnrealBuildToolConfig EnableUBSan(bool? val = null)
        {
            AppendArgument(val == null ? "-EnableUBSan" : "-EnableUBSan=" + val.ToString());
            return (UnrealBuildToolConfig) this;
        }

    
    
        /// <summary>
        /// No description
        /// </summary>
        public UnrealBuildToolConfig IgnoreJunk(bool? val = null)
        {
            AppendArgument(val == null ? "-IgnoreJunk" : "-IgnoreJunk=" + val.ToString());
            return (UnrealBuildToolConfig) this;
        }

    
    
        /// <summary>
        /// No description
        /// </summary>
        public UnrealBuildToolConfig SkipBuild(bool? val = null)
        {
            AppendArgument(val == null ? "-SkipBuild" : "-SkipBuild=" + val.ToString());
            return (UnrealBuildToolConfig) this;
        }

    
    
        /// <summary>
        /// No description
        /// </summary>
        public UnrealBuildToolConfig SkipPreBuildTargets(bool? val = null)
        {
            AppendArgument(val == null ? "-SkipPreBuildTargets" : "-SkipPreBuildTargets=" + val.ToString());
            return (UnrealBuildToolConfig) this;
        }

    
    
        /// <summary>
        /// No description
        /// </summary>
        public UnrealBuildToolConfig XGEExport(bool? val = null)
        {
            AppendArgument(val == null ? "-XGEExport" : "-XGEExport=" + val.ToString());
            return (UnrealBuildToolConfig) this;
        }

    
    
        /// <summary>
        /// No description
        /// </summary>
        public UnrealBuildToolConfig NoEngineChanges(bool? val = null)
        {
            AppendArgument(val == null ? "-NoEngineChanges" : "-NoEngineChanges=" + val.ToString());
            return (UnrealBuildToolConfig) this;
        }

    
    
        /// <summary>
        /// No description
        /// </summary>
        public UnrealBuildToolConfig WriteOutdatedActions(object val = null)
        {
            AppendArgument(string.IsNullOrWhiteSpace(val?.ToString()) ? "-WriteOutdatedActions" : "-WriteOutdatedActions=" + val.ToString().DoubleQuoteIfNeeded());
            return (UnrealBuildToolConfig) this;
        }

    
    
        /// <summary>
        /// No description
        /// </summary>
        public UnrealBuildToolConfig Receipt(object val = null)
        {
            AppendArgument(string.IsNullOrWhiteSpace(val?.ToString()) ? "-Receipt" : "-Receipt=" + val.ToString().DoubleQuoteIfNeeded());
            return (UnrealBuildToolConfig) this;
        }

    
    
        /// <summary>
        /// No description
        /// </summary>
        public UnrealBuildToolConfig Actions(object val = null)
        {
            AppendArgument(string.IsNullOrWhiteSpace(val?.ToString()) ? "-Actions" : "-Actions=" + val.ToString().DoubleQuoteIfNeeded());
            return (UnrealBuildToolConfig) this;
        }

    
    
        /// <summary>
        /// No description
        /// </summary>
        public UnrealBuildToolConfig ExecCodeGenActions(bool? val = null)
        {
            AppendArgument(val == null ? "-ExecCodeGenActions" : "-ExecCodeGenActions=" + val.ToString());
            return (UnrealBuildToolConfig) this;
        }

    
    
        /// <summary>
        /// No description
        /// </summary>
        public UnrealBuildToolConfig Plugin(object val = null)
        {
            AppendArgument(string.IsNullOrWhiteSpace(val?.ToString()) ? "-Plugin" : "-Plugin=" + val.ToString().DoubleQuoteIfNeeded());
            return (UnrealBuildToolConfig) this;
        }

    
    
        /// <summary>
        /// No description
        /// </summary>
        public UnrealBuildToolConfig Module(object val = null)
        {
            AppendArgument(string.IsNullOrWhiteSpace(val?.ToString()) ? "-Module" : "-Module=" + val.ToString().DoubleQuoteIfNeeded());
            return (UnrealBuildToolConfig) this;
        }

    
    
        /// <summary>
        /// No description
        /// </summary>
        public UnrealBuildToolConfig SingleFile(object val = null)
        {
            AppendArgument(string.IsNullOrWhiteSpace(val?.ToString()) ? "-SingleFile" : "-SingleFile=" + val.ToString().DoubleQuoteIfNeeded());
            return (UnrealBuildToolConfig) this;
        }

    
    
        /// <summary>
        /// No description
        /// </summary>
        public UnrealBuildToolConfig NoHotReload(bool present = true)
        {
            AppendArgument(present ? "-NoHotReload" : "");
            return (UnrealBuildToolConfig) this;
        }

    
    
        /// <summary>
        /// No description
        /// </summary>
        public UnrealBuildToolConfig ForceHotReload(bool present = true)
        {
            AppendArgument(present ? "-ForceHotReload" : "");
            return (UnrealBuildToolConfig) this;
        }

    
    
        /// <summary>
        /// No description
        /// </summary>
        public UnrealBuildToolConfig LiveCoding(bool present = true)
        {
            AppendArgument(present ? "-LiveCoding" : "");
            return (UnrealBuildToolConfig) this;
        }

    
    
        /// <summary>
        /// No description
        /// </summary>
        public UnrealBuildToolConfig WriteActions(object val = null)
        {
            AppendArgument(string.IsNullOrWhiteSpace(val?.ToString()) ? "-WriteActions" : "-WriteActions=" + val.ToString().DoubleQuoteIfNeeded());
            return (UnrealBuildToolConfig) this;
        }

    
    
        /// <summary>
        /// No description
        /// </summary>
        public UnrealBuildToolConfig LiveCodingModules(object val = null)
        {
            AppendArgument(string.IsNullOrWhiteSpace(val?.ToString()) ? "-LiveCodingModules" : "-LiveCodingModules=" + val.ToString().DoubleQuoteIfNeeded());
            return (UnrealBuildToolConfig) this;
        }

    
    
        /// <summary>
        /// No description
        /// </summary>
        public UnrealBuildToolConfig LiveCodingManifest(object val = null)
        {
            AppendArgument(string.IsNullOrWhiteSpace(val?.ToString()) ? "-LiveCodingManifest" : "-LiveCodingManifest=" + val.ToString().DoubleQuoteIfNeeded());
            return (UnrealBuildToolConfig) this;
        }

    
    
        /// <summary>
        /// No description
        /// </summary>
        public UnrealBuildToolConfig Quiet(bool? val = null)
        {
            AppendArgument(val == null ? "-Quiet" : "-Quiet=" + val.ToString());
            return (UnrealBuildToolConfig) this;
        }

    
    
        /// <summary>
        /// No description
        /// </summary>
        public UnrealBuildToolConfig Input(object val = null)
        {
            AppendArgument(string.IsNullOrWhiteSpace(val?.ToString()) ? "-Input" : "-Input=" + val.ToString().DoubleQuoteIfNeeded());
            return (UnrealBuildToolConfig) this;
        }

    
    
        /// <summary>
        /// No description
        /// </summary>
        public UnrealBuildToolConfig XmlConfigCache(object val = null)
        {
            AppendArgument(string.IsNullOrWhiteSpace(val?.ToString()) ? "-XmlConfigCache" : "-XmlConfigCache=" + val.ToString().DoubleQuoteIfNeeded());
            return (UnrealBuildToolConfig) this;
        }

    
    
        /// <summary>
        /// No description
        /// </summary>
        public UnrealBuildToolConfig AllModules(bool? val = null)
        {
            AppendArgument(val == null ? "-AllModules" : "-AllModules=" + val.ToString());
            return (UnrealBuildToolConfig) this;
        }

    
    
        /// <summary>
        /// No description
        /// </summary>
        public UnrealBuildToolConfig BuildPlugin(object val = null)
        {
            AppendArgument(string.IsNullOrWhiteSpace(val?.ToString()) ? "-BuildPlugin" : "-BuildPlugin=" + val.ToString().DoubleQuoteIfNeeded());
            return (UnrealBuildToolConfig) this;
        }

    
    
        /// <summary>
        /// No description
        /// </summary>
        public UnrealBuildToolConfig EnablePlugin(object val = null)
        {
            AppendArgument(string.IsNullOrWhiteSpace(val?.ToString()) ? "-EnablePlugin" : "-EnablePlugin=" + val.ToString().DoubleQuoteIfNeeded());
            return (UnrealBuildToolConfig) this;
        }

    
    
        /// <summary>
        /// No description
        /// </summary>
        public UnrealBuildToolConfig DisablePlugin(object val = null)
        {
            AppendArgument(string.IsNullOrWhiteSpace(val?.ToString()) ? "-DisablePlugin" : "-DisablePlugin=" + val.ToString().DoubleQuoteIfNeeded());
            return (UnrealBuildToolConfig) this;
        }

    
    
        /// <summary>
        /// No description
        /// </summary>
        public UnrealBuildToolConfig CompileAsDll(bool? val = null)
        {
            AppendArgument(val == null ? "-CompileAsDll" : "-CompileAsDll=" + val.ToString());
            return (UnrealBuildToolConfig) this;
        }

    
    
        /// <summary>
        /// No description
        /// </summary>
        public UnrealBuildToolConfig NoCompileChaos(bool present = true)
        {
            AppendArgument(present ? "-NoCompileChaos" : "");
            return (UnrealBuildToolConfig) this;
        }

    
    
        /// <summary>
        /// No description
        /// </summary>
        public UnrealBuildToolConfig CompileChaos(bool present = true)
        {
            AppendArgument(present ? "-CompileChaos" : "");
            return (UnrealBuildToolConfig) this;
        }

    
    
        /// <summary>
        /// No description
        /// </summary>
        public UnrealBuildToolConfig NoUseChaos(bool present = true)
        {
            AppendArgument(present ? "-NoUseChaos" : "");
            return (UnrealBuildToolConfig) this;
        }

    
    
        /// <summary>
        /// No description
        /// </summary>
        public UnrealBuildToolConfig UseChaos(bool present = true)
        {
            AppendArgument(present ? "-UseChaos" : "");
            return (UnrealBuildToolConfig) this;
        }

    
    
        /// <summary>
        /// No description
        /// </summary>
        public UnrealBuildToolConfig Rtti(bool? val = null)
        {
            AppendArgument(val == null ? "-rtti" : "-rtti=" + val.ToString());
            return (UnrealBuildToolConfig) this;
        }

    
    
        /// <summary>
        /// No description
        /// </summary>
        public UnrealBuildToolConfig IWYU(bool? val = null)
        {
            AppendArgument(val == null ? "-IWYU" : "-IWYU=" + val.ToString());
            return (UnrealBuildToolConfig) this;
        }

    
    
        /// <summary>
        /// No description
        /// </summary>
        public UnrealBuildToolConfig Precompile(bool? val = null)
        {
            AppendArgument(val == null ? "-Precompile" : "-Precompile=" + val.ToString());
            return (UnrealBuildToolConfig) this;
        }

    
    
        /// <summary>
        /// No description
        /// </summary>
        public UnrealBuildToolConfig DisableUnity(bool present = true)
        {
            AppendArgument(present ? "-DisableUnity" : "");
            return (UnrealBuildToolConfig) this;
        }

    
    
        /// <summary>
        /// No description
        /// </summary>
        public UnrealBuildToolConfig ForceUnity(bool? val = null)
        {
            AppendArgument(val == null ? "-ForceUnity" : "-ForceUnity=" + val.ToString());
            return (UnrealBuildToolConfig) this;
        }

    
    
        /// <summary>
        /// No description
        /// </summary>
        public UnrealBuildToolConfig ShadowVariableErrors(bool present = true)
        {
            AppendArgument(present ? "-ShadowVariableErrors" : "");
            return (UnrealBuildToolConfig) this;
        }

    
    
        /// <summary>
        /// No description
        /// </summary>
        public UnrealBuildToolConfig FastMonoCalls(bool present = true)
        {
            AppendArgument(present ? "-FastMonoCalls" : "");
            return (UnrealBuildToolConfig) this;
        }

    
    
        /// <summary>
        /// No description
        /// </summary>
        public UnrealBuildToolConfig NoFastMonoCalls(bool present = true)
        {
            AppendArgument(present ? "-NoFastMonoCalls" : "");
            return (UnrealBuildToolConfig) this;
        }

    
    
        /// <summary>
        /// No description
        /// </summary>
        public UnrealBuildToolConfig StressTestUnity(bool? val = null)
        {
            AppendArgument(val == null ? "-StressTestUnity" : "-StressTestUnity=" + val.ToString());
            return (UnrealBuildToolConfig) this;
        }

    
    
        /// <summary>
        /// No description
        /// </summary>
        public UnrealBuildToolConfig ForceDebugInfo(bool? val = null)
        {
            AppendArgument(val == null ? "-ForceDebugInfo" : "-ForceDebugInfo=" + val.ToString());
            return (UnrealBuildToolConfig) this;
        }

    
    
        /// <summary>
        /// No description
        /// </summary>
        public UnrealBuildToolConfig NoDebugInfo(bool? val = null)
        {
            AppendArgument(val == null ? "-NoDebugInfo" : "-NoDebugInfo=" + val.ToString());
            return (UnrealBuildToolConfig) this;
        }

    
    
        /// <summary>
        /// No description
        /// </summary>
        public UnrealBuildToolConfig NoPDB(bool present = true)
        {
            AppendArgument(present ? "-NoPDB" : "");
            return (UnrealBuildToolConfig) this;
        }

    
    
        /// <summary>
        /// No description
        /// </summary>
        public UnrealBuildToolConfig NoPCH(bool present = true)
        {
            AppendArgument(present ? "-NoPCH" : "");
            return (UnrealBuildToolConfig) this;
        }

    
    
        /// <summary>
        /// No description
        /// </summary>
        public UnrealBuildToolConfig Preprocess(bool? val = null)
        {
            AppendArgument(val == null ? "-Preprocess" : "-Preprocess=" + val.ToString());
            return (UnrealBuildToolConfig) this;
        }

    
    
        /// <summary>
        /// No description
        /// </summary>
        public UnrealBuildToolConfig IncrementalLinking(bool? val = null)
        {
            AppendArgument(val == null ? "-IncrementalLinking" : "-IncrementalLinking=" + val.ToString());
            return (UnrealBuildToolConfig) this;
        }

    
    
        /// <summary>
        /// No description
        /// </summary>
        public UnrealBuildToolConfig NoIncrementalLinking(bool present = true)
        {
            AppendArgument(present ? "-NoIncrementalLinking" : "");
            return (UnrealBuildToolConfig) this;
        }

    
    
        /// <summary>
        /// No description
        /// </summary>
        public UnrealBuildToolConfig LTCG(bool? val = null)
        {
            AppendArgument(val == null ? "-LTCG" : "-LTCG=" + val.ToString());
            return (UnrealBuildToolConfig) this;
        }

    
    
        /// <summary>
        /// No description
        /// </summary>
        public UnrealBuildToolConfig PGOProfile(bool present = true)
        {
            AppendArgument(present ? "-PGOProfile" : "");
            return (UnrealBuildToolConfig) this;
        }

    
    
        /// <summary>
        /// No description
        /// </summary>
        public UnrealBuildToolConfig PGOOptimize(bool present = true)
        {
            AppendArgument(present ? "-PGOOptimize" : "");
            return (UnrealBuildToolConfig) this;
        }

    
    
        /// <summary>
        /// No description
        /// </summary>
        public UnrealBuildToolConfig NoSharedPCH(bool present = true)
        {
            AppendArgument(present ? "-NoSharedPCH" : "");
            return (UnrealBuildToolConfig) this;
        }

    
    
        /// <summary>
        /// No description
        /// </summary>
        public UnrealBuildToolConfig FastPDB(object val = null)
        {
            AppendArgument(string.IsNullOrWhiteSpace(val?.ToString()) ? "-FastPDB" : "-FastPDB=" + val.ToString().DoubleQuoteIfNeeded());
            return (UnrealBuildToolConfig) this;
        }

    
    
        /// <summary>
        /// No description
        /// </summary>
        public UnrealBuildToolConfig MapFile(bool? val = null)
        {
            AppendArgument(val == null ? "-MapFile" : "-MapFile=" + val.ToString());
            return (UnrealBuildToolConfig) this;
        }

    
    
        /// <summary>
        /// No description
        /// </summary>
        public UnrealBuildToolConfig BundleVersion(object val = null)
        {
            AppendArgument(string.IsNullOrWhiteSpace(val?.ToString()) ? "-BundleVersion" : "-BundleVersion=" + val.ToString().DoubleQuoteIfNeeded());
            return (UnrealBuildToolConfig) this;
        }

    
    
        /// <summary>
        /// No description
        /// </summary>
        public UnrealBuildToolConfig Deploy(bool? val = null)
        {
            AppendArgument(val == null ? "-Deploy" : "-Deploy=" + val.ToString());
            return (UnrealBuildToolConfig) this;
        }

    
    
        /// <summary>
        /// No description
        /// </summary>
        public UnrealBuildToolConfig NoLink(bool? val = null)
        {
            AppendArgument(val == null ? "-NoLink" : "-NoLink=" + val.ToString());
            return (UnrealBuildToolConfig) this;
        }

    
    
        /// <summary>
        /// No description
        /// </summary>
        public UnrealBuildToolConfig Formal(bool? val = null)
        {
            AppendArgument(val == null ? "-Formal" : "-Formal=" + val.ToString());
            return (UnrealBuildToolConfig) this;
        }

    
    
        /// <summary>
        /// No description
        /// </summary>
        public UnrealBuildToolConfig FlushMac(bool? val = null)
        {
            AppendArgument(val == null ? "-FlushMac" : "-FlushMac=" + val.ToString());
            return (UnrealBuildToolConfig) this;
        }

    
    
        /// <summary>
        /// No description
        /// </summary>
        public UnrealBuildToolConfig Timing(bool? val = null)
        {
            AppendArgument(val == null ? "-Timing" : "-Timing=" + val.ToString());
            return (UnrealBuildToolConfig) this;
        }

    
    
        /// <summary>
        /// No description
        /// </summary>
        public UnrealBuildToolConfig Tracing(bool? val = null)
        {
            AppendArgument(val == null ? "-Tracing" : "-Tracing=" + val.ToString());
            return (UnrealBuildToolConfig) this;
        }

    
    
        /// <summary>
        /// No description
        /// </summary>
        public UnrealBuildToolConfig PublicSymbolsByDefault(bool? val = null)
        {
            AppendArgument(val == null ? "-PublicSymbolsByDefault" : "-PublicSymbolsByDefault=" + val.ToString());
            return (UnrealBuildToolConfig) this;
        }

    
    
        /// <summary>
        /// No description
        /// </summary>
        public UnrealBuildToolConfig ToolChain(object val = null)
        {
            AppendArgument(string.IsNullOrWhiteSpace(val?.ToString()) ? "-ToolChain" : "-ToolChain=" + val.ToString().DoubleQuoteIfNeeded());
            return (UnrealBuildToolConfig) this;
        }

    
    
        /// <summary>
        /// No description
        /// </summary>
        public UnrealBuildToolConfig CppStd(object val = null)
        {
            AppendArgument(string.IsNullOrWhiteSpace(val?.ToString()) ? "-CppStd" : "-CppStd=" + val.ToString().DoubleQuoteIfNeeded());
            return (UnrealBuildToolConfig) this;
        }

    
    
        /// <summary>
        /// No description
        /// </summary>
        public UnrealBuildToolConfig BuildVersion(object val = null)
        {
            AppendArgument(string.IsNullOrWhiteSpace(val?.ToString()) ? "-BuildVersion" : "-BuildVersion=" + val.ToString().DoubleQuoteIfNeeded());
            return (UnrealBuildToolConfig) this;
        }

    
    
        /// <summary>
        /// No description
        /// </summary>
        public UnrealBuildToolConfig Define(object val = null)
        {
            AppendArgument(string.IsNullOrWhiteSpace(val?.ToString()) ? "-Define" : "-Define:" + val.ToString().DoubleQuoteIfNeeded());
            return (UnrealBuildToolConfig) this;
        }

    
    
        /// <summary>
        /// No description
        /// </summary>
        public UnrealBuildToolConfig ProjectDefine(object val = null)
        {
            AppendArgument(string.IsNullOrWhiteSpace(val?.ToString()) ? "-ProjectDefine" : "-ProjectDefine:" + val.ToString().DoubleQuoteIfNeeded());
            return (UnrealBuildToolConfig) this;
        }

    
    
        /// <summary>
        /// No description
        /// </summary>
        public UnrealBuildToolConfig Manifest(object val = null)
        {
            AppendArgument(string.IsNullOrWhiteSpace(val?.ToString()) ? "-Manifest" : "-Manifest=" + val.ToString().DoubleQuoteIfNeeded());
            return (UnrealBuildToolConfig) this;
        }

    
    
        /// <summary>
        /// No description
        /// </summary>
        public UnrealBuildToolConfig DependencyList(object val = null)
        {
            AppendArgument(string.IsNullOrWhiteSpace(val?.ToString()) ? "-DependencyList" : "-DependencyList=" + val.ToString().DoubleQuoteIfNeeded());
            return (UnrealBuildToolConfig) this;
        }

    
    
        /// <summary>
        /// No description
        /// </summary>
        public UnrealBuildToolConfig OverrideBuildEnvironment(bool? val = null)
        {
            AppendArgument(val == null ? "-OverrideBuildEnvironment" : "-OverrideBuildEnvironment=" + val.ToString());
            return (UnrealBuildToolConfig) this;
        }

    
    
        /// <summary>
        /// No description
        /// </summary>
        public UnrealBuildToolConfig CompilerArguments(object val = null)
        {
            AppendArgument(string.IsNullOrWhiteSpace(val?.ToString()) ? "-CompilerArguments" : "-CompilerArguments=" + val.ToString().DoubleQuoteIfNeeded());
            return (UnrealBuildToolConfig) this;
        }

    
    
        /// <summary>
        /// No description
        /// </summary>
        public UnrealBuildToolConfig LinkerArguments(object val = null)
        {
            AppendArgument(string.IsNullOrWhiteSpace(val?.ToString()) ? "-LinkerArguments" : "-LinkerArguments=" + val.ToString().DoubleQuoteIfNeeded());
            return (UnrealBuildToolConfig) this;
        }

    
    
        /// <summary>
        /// No description
        /// </summary>
        public UnrealBuildToolConfig BuildAsFramework(bool? val = null)
        {
            AppendArgument(val == null ? "-build-as-framework" : "-build-as-framework=" + val.ToString());
            return (UnrealBuildToolConfig) this;
        }

    
    
        /// <summary>
        /// No description
        /// </summary>
        public UnrealBuildToolConfig Generatedsymfile(bool? val = null)
        {
            AppendArgument(val == null ? "-generatedsymfile" : "-generatedsymfile=" + val.ToString());
            return (UnrealBuildToolConfig) this;
        }

    
    
        /// <summary>
        /// No description
        /// </summary>
        public UnrealBuildToolConfig Generatedsymbundle(bool? val = null)
        {
            AppendArgument(val == null ? "-generatedsymbundle" : "-generatedsymbundle=" + val.ToString());
            return (UnrealBuildToolConfig) this;
        }

    
    
        /// <summary>
        /// No description
        /// </summary>
        public UnrealBuildToolConfig Architectures(object val = null)
        {
            AppendArgument(string.IsNullOrWhiteSpace(val?.ToString()) ? "-Architectures" : "-Architectures=" + val.ToString().DoubleQuoteIfNeeded());
            return (UnrealBuildToolConfig) this;
        }

    
    
        /// <summary>
        /// No description
        /// </summary>
        public UnrealBuildToolConfig GPUArchitectures(object val = null)
        {
            AppendArgument(string.IsNullOrWhiteSpace(val?.ToString()) ? "-GPUArchitectures" : "-GPUArchitectures=" + val.ToString().DoubleQuoteIfNeeded());
            return (UnrealBuildToolConfig) this;
        }

    
    
        /// <summary>
        /// No description
        /// </summary>
        public UnrealBuildToolConfig ForceAPKGeneration(bool present = true)
        {
            AppendArgument(present ? "-ForceAPKGeneration" : "");
            return (UnrealBuildToolConfig) this;
        }

    
    
        /// <summary>
        /// No description
        /// </summary>
        public UnrealBuildToolConfig _2015(bool present = true)
        {
            AppendArgument(present ? "-2015" : "");
            return (UnrealBuildToolConfig) this;
        }

    
    
        /// <summary>
        /// No description
        /// </summary>
        public UnrealBuildToolConfig _2017(bool present = true)
        {
            AppendArgument(present ? "-2017" : "");
            return (UnrealBuildToolConfig) this;
        }

    
    
        /// <summary>
        /// No description
        /// </summary>
        public UnrealBuildToolConfig _2019(bool present = true)
        {
            AppendArgument(present ? "-2019" : "");
            return (UnrealBuildToolConfig) this;
        }

    
    
        /// <summary>
        /// No description
        /// </summary>
        public UnrealBuildToolConfig _2022(bool present = true)
        {
            AppendArgument(present ? "-2022" : "");
            return (UnrealBuildToolConfig) this;
        }

    
    
        /// <summary>
        /// No description
        /// </summary>
        public UnrealBuildToolConfig Stripsymbols(bool present = true)
        {
            AppendArgument(present ? "-stripsymbols" : "");
            return (UnrealBuildToolConfig) this;
        }

    
    
        /// <summary>
        /// No description
        /// </summary>
        public UnrealBuildToolConfig CreateStub(bool present = true)
        {
            AppendArgument(present ? "-CreateStub" : "");
            return (UnrealBuildToolConfig) this;
        }

    
    
        /// <summary>
        /// No description
        /// </summary>
        public UnrealBuildToolConfig Alwaysgeneratedsym(bool present = true)
        {
            AppendArgument(present ? "-alwaysgeneratedsym" : "");
            return (UnrealBuildToolConfig) this;
        }

    
    
        /// <summary>
        /// No description
        /// </summary>
        public UnrealBuildToolConfig Skipcrashlytics(bool? val = null)
        {
            AppendArgument(val == null ? "-skipcrashlytics" : "-skipcrashlytics=" + val.ToString());
            return (UnrealBuildToolConfig) this;
        }

    
    
        /// <summary>
        /// No description
        /// </summary>
        public UnrealBuildToolConfig Distribution(bool? val = null)
        {
            AppendArgument(val == null ? "-distribution" : "-distribution=" + val.ToString());
            return (UnrealBuildToolConfig) this;
        }

    
    
        /// <summary>
        /// No description
        /// </summary>
        public UnrealBuildToolConfig ImportProvision(object val = null)
        {
            AppendArgument(string.IsNullOrWhiteSpace(val?.ToString()) ? "-ImportProvision" : "-ImportProvision=" + val.ToString().DoubleQuoteIfNeeded());
            return (UnrealBuildToolConfig) this;
        }

    
    
        /// <summary>
        /// No description
        /// </summary>
        public UnrealBuildToolConfig ImportCertificate(object val = null)
        {
            AppendArgument(string.IsNullOrWhiteSpace(val?.ToString()) ? "-ImportCertificate" : "-ImportCertificate=" + val.ToString().DoubleQuoteIfNeeded());
            return (UnrealBuildToolConfig) this;
        }

    
    
        /// <summary>
        /// No description
        /// </summary>
        public UnrealBuildToolConfig ImportCertificatePassword(object val = null)
        {
            AppendArgument(string.IsNullOrWhiteSpace(val?.ToString()) ? "-ImportCertificatePassword" : "-ImportCertificatePassword=" + val.ToString().DoubleQuoteIfNeeded());
            return (UnrealBuildToolConfig) this;
        }

    
    
        /// <summary>
        /// No description
        /// </summary>
        public UnrealBuildToolConfig EnableMSan(bool? val = null)
        {
            AppendArgument(val == null ? "-EnableMSan" : "-EnableMSan=" + val.ToString());
            return (UnrealBuildToolConfig) this;
        }

    
    
        /// <summary>
        /// No description
        /// </summary>
        public UnrealBuildToolConfig ThinLTO(bool? val = null)
        {
            AppendArgument(val == null ? "-ThinLTO" : "-ThinLTO=" + val.ToString());
            return (UnrealBuildToolConfig) this;
        }

    
    
        /// <summary>
        /// No description
        /// </summary>
        public UnrealBuildToolConfig UsePrecompiled(bool? val = null)
        {
            AppendArgument(val == null ? "-UsePrecompiled" : "-UsePrecompiled=" + val.ToString());
            return (UnrealBuildToolConfig) this;
        }

    
    
        /// <summary>
        /// No description
        /// </summary>
        public UnrealBuildToolConfig NoXGE(bool present = true)
        {
            AppendArgument(present ? "-NoXGE" : "");
            return (UnrealBuildToolConfig) this;
        }

    
    
        /// <summary>
        /// No description
        /// </summary>
        public UnrealBuildToolConfig NoFASTBuild(bool present = true)
        {
            AppendArgument(present ? "-NoFASTBuild" : "");
            return (UnrealBuildToolConfig) this;
        }

    
    
        /// <summary>
        /// No description
        /// </summary>
        public UnrealBuildToolConfig NoUBTMakefiles(bool present = true)
        {
            AppendArgument(present ? "-NoUBTMakefiles" : "");
            return (UnrealBuildToolConfig) this;
        }

    
    
        /// <summary>
        /// No description
        /// </summary>
        public UnrealBuildToolConfig MaxParallelActions(double? val = null)
        {
            AppendArgument(val == null ? "-MaxParallelActions" : "-MaxParallelActions=" + val.ToString());
            return (UnrealBuildToolConfig) this;
        }

    
    
        /// <summary>
        /// No description
        /// </summary>
        public UnrealBuildToolConfig ForceHeaderGeneration(bool? val = null)
        {
            AppendArgument(val == null ? "-ForceHeaderGeneration" : "-ForceHeaderGeneration=" + val.ToString());
            return (UnrealBuildToolConfig) this;
        }

    
    
        /// <summary>
        /// No description
        /// </summary>
        public UnrealBuildToolConfig NoBuildUHT(bool? val = null)
        {
            AppendArgument(val == null ? "-NoBuildUHT" : "-NoBuildUHT=" + val.ToString());
            return (UnrealBuildToolConfig) this;
        }

    
    
        /// <summary>
        /// No description
        /// </summary>
        public UnrealBuildToolConfig FailIfGeneratedCodeChanges(bool? val = null)
        {
            AppendArgument(val == null ? "-FailIfGeneratedCodeChanges" : "-FailIfGeneratedCodeChanges=" + val.ToString());
            return (UnrealBuildToolConfig) this;
        }

    
    
        /// <summary>
        /// No description
        /// </summary>
        public UnrealBuildToolConfig NoHotReloadFromIDE(bool present = true)
        {
            AppendArgument(present ? "-NoHotReloadFromIDE" : "");
            return (UnrealBuildToolConfig) this;
        }

    
    
        /// <summary>
        /// No description
        /// </summary>
        public UnrealBuildToolConfig SkipRulesCompile(bool? val = null)
        {
            AppendArgument(val == null ? "-SkipRulesCompile" : "-SkipRulesCompile=" + val.ToString());
            return (UnrealBuildToolConfig) this;
        }

    
    
        /// <summary>
        /// No description
        /// </summary>
        public UnrealBuildToolConfig Compiler(object val = null)
        {
            AppendArgument(string.IsNullOrWhiteSpace(val?.ToString()) ? "-Compiler" : "-Compiler=" + val.ToString().DoubleQuoteIfNeeded());
            return (UnrealBuildToolConfig) this;
        }

    
    
        /// <summary>
        /// No description
        /// </summary>
        public UnrealBuildToolConfig CompilerVersion(object val = null)
        {
            AppendArgument(string.IsNullOrWhiteSpace(val?.ToString()) ? "-CompilerVersion" : "-CompilerVersion=" + val.ToString().DoubleQuoteIfNeeded());
            return (UnrealBuildToolConfig) this;
        }

    
    
        /// <summary>
        /// No description
        /// </summary>
        public UnrealBuildToolConfig StaticAnalyzer(object val = null)
        {
            AppendArgument(string.IsNullOrWhiteSpace(val?.ToString()) ? "-StaticAnalyzer" : "-StaticAnalyzer=" + val.ToString().DoubleQuoteIfNeeded());
            return (UnrealBuildToolConfig) this;
        }

    
    
        /// <summary>
        /// No description
        /// </summary>
        public UnrealBuildToolConfig ObjSrcMap(object val = null)
        {
            AppendArgument(string.IsNullOrWhiteSpace(val?.ToString()) ? "-ObjSrcMap" : "-ObjSrcMap=" + val.ToString().DoubleQuoteIfNeeded());
            return (UnrealBuildToolConfig) this;
        }

    
    
        /// <summary>
        /// No description
        /// </summary>
        public UnrealBuildToolConfig Strict(bool? val = null)
        {
            AppendArgument(val == null ? "-Strict" : "-Strict=" + val.ToString());
            return (UnrealBuildToolConfig) this;
        }

    
    
        /// <summary>
        /// No description
        /// </summary>
        public UnrealBuildToolConfig ShowIncludes(bool? val = null)
        {
            AppendArgument(val == null ? "-ShowIncludes" : "-ShowIncludes=" + val.ToString());
            return (UnrealBuildToolConfig) this;
        }

    
    
        /// <summary>
        /// No description
        /// </summary>
        public UnrealBuildToolConfig Verbose(bool present = true)
        {
            AppendArgument(present ? "-Verbose" : "");
            return (UnrealBuildToolConfig) this;
        }

    
    
        /// <summary>
        /// No description
        /// </summary>
        public UnrealBuildToolConfig VeryVerbose(bool present = true)
        {
            AppendArgument(present ? "-VeryVerbose" : "");
            return (UnrealBuildToolConfig) this;
        }

    
    
        /// <summary>
        /// No description
        /// </summary>
        public UnrealBuildToolConfig Log(object val = null)
        {
            AppendArgument(string.IsNullOrWhiteSpace(val?.ToString()) ? "-Log" : "-Log=" + val.ToString().DoubleQuoteIfNeeded());
            return (UnrealBuildToolConfig) this;
        }

    
    
        /// <summary>
        /// No description
        /// </summary>
        public UnrealBuildToolConfig Timestamps(bool? val = null)
        {
            AppendArgument(val == null ? "-Timestamps" : "-Timestamps=" + val.ToString());
            return (UnrealBuildToolConfig) this;
        }

    
    
        /// <summary>
        /// No description
        /// </summary>
        public UnrealBuildToolConfig FromMsBuild(bool? val = null)
        {
            AppendArgument(val == null ? "-FromMsBuild" : "-FromMsBuild=" + val.ToString());
            return (UnrealBuildToolConfig) this;
        }

    
    
        /// <summary>
        /// No description
        /// </summary>
        public UnrealBuildToolConfig Progress(bool? val = null)
        {
            AppendArgument(val == null ? "-Progress" : "-Progress=" + val.ToString());
            return (UnrealBuildToolConfig) this;
        }

    
    
        /// <summary>
        /// No description
        /// </summary>
        public UnrealBuildToolConfig NoMutex(bool? val = null)
        {
            AppendArgument(val == null ? "-NoMutex" : "-NoMutex=" + val.ToString());
            return (UnrealBuildToolConfig) this;
        }

    
    
        /// <summary>
        /// No description
        /// </summary>
        public UnrealBuildToolConfig WaitMutex(bool? val = null)
        {
            AppendArgument(val == null ? "-WaitMutex" : "-WaitMutex=" + val.ToString());
            return (UnrealBuildToolConfig) this;
        }

    
    
        /// <summary>
        /// No description
        /// </summary>
        public UnrealBuildToolConfig RemoteIni(object val = null)
        {
            AppendArgument(string.IsNullOrWhiteSpace(val?.ToString()) ? "-RemoteIni" : "-RemoteIni=" + val.ToString().DoubleQuoteIfNeeded());
            return (UnrealBuildToolConfig) this;
        }

    
    
        /// <summary>
        /// No description
        /// </summary>
        public UnrealBuildToolConfig Mode(object val = null)
        {
            AppendArgument(string.IsNullOrWhiteSpace(val?.ToString()) ? "-Mode" : "-Mode=" + val.ToString().DoubleQuoteIfNeeded());
            return (UnrealBuildToolConfig) this;
        }

    
    
        /// <summary>
        /// No description
        /// </summary>
        public UnrealBuildToolConfig Clean(bool present = true)
        {
            AppendArgument(present ? "-Clean" : "");
            return (UnrealBuildToolConfig) this;
        }

    
    
        /// <summary>
        /// No description
        /// </summary>
        public UnrealBuildToolConfig ProjectFiles(bool present = true)
        {
            AppendArgument(present ? "-ProjectFiles" : "");
            return (UnrealBuildToolConfig) this;
        }

    
    
        /// <summary>
        /// No description
        /// </summary>
        public UnrealBuildToolConfig ProjectFileFormat(bool present = true)
        {
            AppendArgument(present ? "-ProjectFileFormat" : "");
            return (UnrealBuildToolConfig) this;
        }

    
    
        /// <summary>
        /// No description
        /// </summary>
        public UnrealBuildToolConfig Makefile(bool present = true)
        {
            AppendArgument(present ? "-Makefile" : "");
            return (UnrealBuildToolConfig) this;
        }

    
    
        /// <summary>
        /// No description
        /// </summary>
        public UnrealBuildToolConfig CMakefile(bool present = true)
        {
            AppendArgument(present ? "-CMakefile" : "");
            return (UnrealBuildToolConfig) this;
        }

    
    
        /// <summary>
        /// No description
        /// </summary>
        public UnrealBuildToolConfig QMakefile(bool present = true)
        {
            AppendArgument(present ? "-QMakefile" : "");
            return (UnrealBuildToolConfig) this;
        }

    
    
        /// <summary>
        /// No description
        /// </summary>
        public UnrealBuildToolConfig KDevelopfile(bool present = true)
        {
            AppendArgument(present ? "-KDevelopfile" : "");
            return (UnrealBuildToolConfig) this;
        }

    
    
        /// <summary>
        /// No description
        /// </summary>
        public UnrealBuildToolConfig CodeliteFiles(bool present = true)
        {
            AppendArgument(present ? "-CodeliteFiles" : "");
            return (UnrealBuildToolConfig) this;
        }

    
    
        /// <summary>
        /// No description
        /// </summary>
        public UnrealBuildToolConfig XCodeProjectFiles(bool present = true)
        {
            AppendArgument(present ? "-XCodeProjectFiles" : "");
            return (UnrealBuildToolConfig) this;
        }

    
    
        /// <summary>
        /// No description
        /// </summary>
        public UnrealBuildToolConfig EdditProjectFiles(bool present = true)
        {
            AppendArgument(present ? "-EdditProjectFiles" : "");
            return (UnrealBuildToolConfig) this;
        }

    
    
        /// <summary>
        /// No description
        /// </summary>
        public UnrealBuildToolConfig VSCode(bool present = true)
        {
            AppendArgument(present ? "-VSCode" : "");
            return (UnrealBuildToolConfig) this;
        }

    
    
        /// <summary>
        /// No description
        /// </summary>
        public UnrealBuildToolConfig VSMac(bool present = true)
        {
            AppendArgument(present ? "-VSMac" : "");
            return (UnrealBuildToolConfig) this;
        }

    
    
        /// <summary>
        /// No description
        /// </summary>
        public UnrealBuildToolConfig CLion(bool present = true)
        {
            AppendArgument(present ? "-CLion" : "");
            return (UnrealBuildToolConfig) this;
        }

    
    
        /// <summary>
        /// No description
        /// </summary>
        public UnrealBuildToolConfig Rider(bool present = true)
        {
            AppendArgument(present ? "-Rider" : "");
            return (UnrealBuildToolConfig) this;
        }

    

    
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
    /// No description
    /// </summary>
    public UnrealBuildToolConfig Build(Action<BuildConfig> configurator = null)
    {
        configurator?.Invoke(BuildStorage);
        AppendSubtool(BuildStorage);
        return (UnrealBuildToolConfig) this;
    }
    
    /// <summary>
    /// No description
    /// </summary>
    public UnrealBuildToolConfig Clean(Action<CleanConfig> configurator = null)
    {
        configurator?.Invoke(CleanStorage);
        AppendSubtool(CleanStorage);
        return (UnrealBuildToolConfig) this;
    }
    
    /// <summary>
    /// No description
    /// </summary>
    public UnrealBuildToolConfig Deploy(Action<DeployConfig> configurator = null)
    {
        configurator?.Invoke(DeployStorage);
        AppendSubtool(DeployStorage);
        return (UnrealBuildToolConfig) this;
    }
    
    /// <summary>
    /// No description
    /// </summary>
    public UnrealBuildToolConfig Execute(Action<ExecuteConfig> configurator = null)
    {
        configurator?.Invoke(ExecuteStorage);
        AppendSubtool(ExecuteStorage);
        return (UnrealBuildToolConfig) this;
    }
    
    /// <summary>
    /// No description
    /// </summary>
    public UnrealBuildToolConfig JsonExport(Action<JsonExportConfig> configurator = null)
    {
        configurator?.Invoke(JsonExportStorage);
        AppendSubtool(JsonExportStorage);
        return (UnrealBuildToolConfig) this;
    }
    
    /// <summary>
    /// No description
    /// </summary>
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
