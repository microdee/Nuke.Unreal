
// This file is generated via `nuke generate-tools` target.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace Nuke.Unreal.Tools;
/// <summary>Unreal Automation Tool is a vast collection of scripts solving all aspects of deploying a program made in Unreal Engine</summary>
public abstract class UnrealAutomationToolConfigGenerated : ToolConfig
{
    public override string Name => "UnrealAutomationTool";
    
        
/// <summary>"Enables verbose logging"</summary>
        public virtual UnrealAutomationToolConfig Verbose(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-verbose=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-verbose");
            return (UnrealAutomationToolConfig) this;
        }

        
        
/// <summary>"Disables Perforce functionality (default if not run on a build machine)"</summary>
        public virtual UnrealAutomationToolConfig Nop4(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-nop4=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-nop4");
            return (UnrealAutomationToolConfig) this;
        }

        
        
/// <summary>"Enables Perforce functionality (default if run on a build machine)"</summary>
        public virtual UnrealAutomationToolConfig P4(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-p4=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-p4");
            return (UnrealAutomationToolConfig) this;
        }

        
        
/// <summary>"Does not run any commands, only compiles them"</summary>
        public virtual UnrealAutomationToolConfig Compileonly(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-compileonly=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-compileonly");
            return (UnrealAutomationToolConfig) this;
        }

        
        
/// <summary>"Dynamically compiles all commands (otherwise assumes they are already built)"</summary>
        public virtual UnrealAutomationToolConfig Compile(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-compile=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-compile");
            return (UnrealAutomationToolConfig) this;
        }

        
        
/// <summary>"Displays help"</summary>
        public virtual UnrealAutomationToolConfig Help(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-help=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-help");
            return (UnrealAutomationToolConfig) this;
        }

        
        
/// <summary>"Lists all available commands"</summary>
        public virtual UnrealAutomationToolConfig List(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-list=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-list");
            return (UnrealAutomationToolConfig) this;
        }

        
        
/// <summary>"Allows UAT command to submit changes"</summary>
        public virtual UnrealAutomationToolConfig Submit(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-submit=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-submit");
            return (UnrealAutomationToolConfig) this;
        }

        
        
/// <summary>"Prevents any submit attempts"</summary>
        public virtual UnrealAutomationToolConfig Nosubmit(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-nosubmit=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-nosubmit");
            return (UnrealAutomationToolConfig) this;
        }

        
        
/// <summary>"Does not kill any spawned processes on exit"</summary>
        public virtual UnrealAutomationToolConfig Nokill(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-nokill=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-nokill");
            return (UnrealAutomationToolConfig) this;
        }

        
        
/// <summary>"Prevents UBT from cleaning junk files"</summary>
        public virtual UnrealAutomationToolConfig Ignorejunk(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-ignorejunk" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-ignorejunk");
            return (UnrealAutomationToolConfig) this;
        }

        
        
/// <summary>@"Allows you to use local storage for your root build storage dir (default of P:\Builds (on PC) is changed to Engine\Saved\LocalBuilds). Used for local testing."
/// 
/// Allows you to use local storage for your root build storage dir (default of P:\Builds (on PC) is changed to Engine\Saved\LocalBuilds). Used for local testing.
/// </summary>
        public virtual UnrealAutomationToolConfig UseLocalBuildStorage(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-UseLocalBuildStorage=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-UseLocalBuildStorage");
            return (UnrealAutomationToolConfig) this;
        }

        
        
    
        public virtual UnrealAutomationToolConfig Telemetry(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-Telemetry=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-Telemetry");
            return (UnrealAutomationToolConfig) this;
        }

        
        
    
        public virtual UnrealAutomationToolConfig Utf8output(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-Utf8output=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-Utf8output");
            return (UnrealAutomationToolConfig) this;
        }

        
        
    
        public virtual UnrealAutomationToolConfig VeryVerbose(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-VeryVerbose=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-VeryVerbose");
            return (UnrealAutomationToolConfig) this;
        }

        
        
    
        public virtual UnrealAutomationToolConfig Timestamps(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-Timestamps=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-Timestamps");
            return (UnrealAutomationToolConfig) this;
        }

        
        
/// <summary>"target platform for building, cooking and deployment (also -Platform)"</summary>
        public virtual UnrealAutomationToolConfig Targetplatform(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-targetplatform=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-targetplatform");
            return (UnrealAutomationToolConfig) this;
        }

        
        
/// <summary>"target platform for building, cooking and deployment of the dedicated server (also -ServerPlatform)"</summary>
        public virtual UnrealAutomationToolConfig Servertargetplatform(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-servertargetplatform=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-servertargetplatform");
            return (UnrealAutomationToolConfig) this;
        }

        
        
/// <summary>"Generate a foreign uproject from blankproject and use that"
/// 
/// Shared: The current project is a foreign project, commandline: -foreign
/// </summary>
        public virtual UnrealAutomationToolConfig Foreign(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-foreign=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-foreign");
            return (UnrealAutomationToolConfig) this;
        }

        
        
/// <summary>"Generate a foreign code uproject from platformergame and use that"
/// 
/// Shared: The current project is a foreign project, commandline: -foreign
/// </summary>
        public virtual UnrealAutomationToolConfig Foreigncode(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-foreigncode=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-foreigncode");
            return (UnrealAutomationToolConfig) this;
        }

        
        
/// <summary>"true if we should build crash reporter"
/// 
/// Shared: true if we should build crash reporter
/// </summary>
        public virtual UnrealAutomationToolConfig CrashReporter(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-CrashReporter=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-CrashReporter");
            return (UnrealAutomationToolConfig) this;
        }

        
        
/// <summary>"Determines if the build is going to use cooked data"
/// 
/// Shared: Determines if the build is going to use cooked data, commandline: -cook, -cookonthefly
/// </summary>
        public virtual UnrealAutomationToolConfig Cook(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-cook=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-cook");
            return (UnrealAutomationToolConfig) this;
        }

        
        
/// <summary>"use a cooked build, but we assume the cooked data is up to date and where it belongs, implies -cook"
/// 
/// Shared: Determines if the build is going to use cooked data, commandline: -cook, -cookonthefly
/// </summary>
        public virtual UnrealAutomationToolConfig Skipcook(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-skipcook=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-skipcook");
            return (UnrealAutomationToolConfig) this;
        }

        
        
/// <summary>"in a cookonthefly build, used solely to pass information to the package step"
/// 
/// Shared: In a cookonthefly build, used solely to pass information to the package step. This is necessary because you can't set cookonthefly and cook at the same time, and skipcook sets cook.
/// </summary>
        public virtual UnrealAutomationToolConfig Skipcookonthefly(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-skipcookonthefly=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-skipcookonthefly");
            return (UnrealAutomationToolConfig) this;
        }

        
        
/// <summary>"wipe intermediate folders before building"
/// 
/// Shared: Determines if the intermediate folders will be wiped before building, commandline: -clean
/// </summary>
        public virtual UnrealAutomationToolConfig Clean(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-clean=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-clean");
            return (UnrealAutomationToolConfig) this;
        }

        
        
/// <summary>"assumes no operator is present, always terminates without waiting for something."
/// 
/// Shared: Assumes no user is sitting at the console, so for example kills clients automatically, commandline: -Unattended
/// </summary>
        public virtual UnrealAutomationToolConfig Unattended(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-unattended=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-unattended");
            return (UnrealAutomationToolConfig) this;
        }

        
        
/// <summary>"generate a pak file"
/// "disable reuse of pak files from the alternate cook source folder, if specified"
/// 
/// Shared: True if pak file should be generated.
/// </summary>
        public virtual UnrealAutomationToolConfig Pak(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-pak=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-pak");
            return (UnrealAutomationToolConfig) this;
        }

        
        
/// <summary>"generate I/O store container file(s)"
/// 
/// Shared: True if container file(s) should be generated with ZenPak.
/// </summary>
        public virtual UnrealAutomationToolConfig Iostore(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-iostore=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-iostore");
            return (UnrealAutomationToolConfig) this;
        }

        
        
/// <summary>"generate optimized config data during staging to improve loadtimes"</summary>
        public virtual UnrealAutomationToolConfig Makebinaryconfig(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-makebinaryconfig=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-makebinaryconfig");
            return (UnrealAutomationToolConfig) this;
        }

        
        
/// <summary>"sign the generated pak file with the specified key, i.e. -signpak=C:\\Encryption.keys. Also implies -signedpak."
/// 
/// Shared: Encryption keys used for signing the pak file.
/// </summary>
        public virtual UnrealAutomationToolConfig Signpak(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-signpak=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-signpak");
            return (UnrealAutomationToolConfig) this;
        }

        
        
/// <summary>"attempt to avoid cooking and instead pull pak files from the network, implies pak and skipcook"
/// 
/// Shared: true if this build is staged, command line: -stage
/// </summary>
        public virtual UnrealAutomationToolConfig Prepak(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-prepak=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-prepak");
            return (UnrealAutomationToolConfig) this;
        }

        
        
/// <summary>"the game should expect to use a signed pak file."</summary>
        public virtual UnrealAutomationToolConfig Signed(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-signed" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-signed");
            return (UnrealAutomationToolConfig) this;
        }

        
        
/// <summary>"The game will be set up for memory mapping bulk data."
/// 
/// Shared: The game will be set up for memory mapping bulk data.
/// </summary>
        public virtual UnrealAutomationToolConfig PakAlignForMemoryMapping(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-PakAlignForMemoryMapping=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-PakAlignForMemoryMapping");
            return (UnrealAutomationToolConfig) this;
        }

        
        
/// <summary>"use a pak file, but assume it is already built, implies pak"
/// 
/// Shared: true if this build is staged, command line: -stage
/// </summary>
        public virtual UnrealAutomationToolConfig Skippak(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-skippak=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-skippak");
            return (UnrealAutomationToolConfig) this;
        }

        
        
/// <summary>"override the -iostore commandline option to not run it"
/// 
/// Shared: true if we want to skip iostore, even if -iostore is specified
/// </summary>
        public virtual UnrealAutomationToolConfig Skipiostore(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-skipiostore=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-skipiostore");
            return (UnrealAutomationToolConfig) this;
        }

        
        
/// <summary>"put this build in a stage directory"
/// 
/// Shared: true if this build is staged, command line: -stage
/// </summary>
        public virtual UnrealAutomationToolConfig Stage(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-stage=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-stage");
            return (UnrealAutomationToolConfig) this;
        }

        
        
/// <summary>"uses a stage directory, but assumes everything is already there, implies -stage"
/// 
/// Shared: true if this build is staged, command line: -stage
/// </summary>
        public virtual UnrealAutomationToolConfig Skipstage(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-skipstage=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-skipstage");
            return (UnrealAutomationToolConfig) this;
        }

        
        
/// <summary>"generate streaming install manifests when cooking data"
/// 
/// Shared: true if this build is using streaming install manifests, command line: -manifests
/// </summary>
        public virtual UnrealAutomationToolConfig Manifests(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-manifests=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-manifests");
            return (UnrealAutomationToolConfig) this;
        }

        
        
/// <summary>"generate streaming install data from manifest when cooking data, requires -stage &amp; -manifests"
/// 
/// Shared: true if this build chunk install streaming install data, command line: -createchunkinstalldata
/// </summary>
        public virtual UnrealAutomationToolConfig Createchunkinstall(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-createchunkinstall=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-createchunkinstall");
            return (UnrealAutomationToolConfig) this;
        }

        
        
/// <summary>"skips encrypting pak files even if crypto keys are provided"</summary>
        public virtual UnrealAutomationToolConfig Skipencryption(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-skipencryption=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-skipencryption");
            return (UnrealAutomationToolConfig) this;
        }

        
        
/// <summary>"Directory to copy the builds to, i.e. -stagingdirectory=C:\\Stage"</summary>
        public virtual UnrealAutomationToolConfig Stagingdirectory(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-stagingdirectory=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-stagingdirectory");
            return (UnrealAutomationToolConfig) this;
        }

        
        
/// <summary>"Name of the UE4 Editor executable, i.e. -ue4exe=UE4Editor.exe"</summary>
        public virtual UnrealAutomationToolConfig Ue4exe(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-ue4exe=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-ue4exe");
            return (UnrealAutomationToolConfig) this;
        }

        
        
/// <summary>"put this build in an archive directory"
/// 
/// Shared: true if this build is archived, command line: -archive
/// </summary>
        public virtual UnrealAutomationToolConfig Archive(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-archive=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-archive");
            return (UnrealAutomationToolConfig) this;
        }

        
        
/// <summary>"Directory to archive the builds to, i.e. -archivedirectory=C:\\Archive"</summary>
        public virtual UnrealAutomationToolConfig Archivedirectory(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-archivedirectory=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-archivedirectory");
            return (UnrealAutomationToolConfig) this;
        }

        
        
/// <summary>"Archive extra metadata files in addition to the build (e.g. build.properties)"
/// 
/// Whether the project should use non monolithic staging
/// </summary>
        public virtual UnrealAutomationToolConfig Archivemetadata(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-archivemetadata=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-archivemetadata");
            return (UnrealAutomationToolConfig) this;
        }

        
        
/// <summary>"When archiving for Mac, set this to true to package it in a .app bundle instead of normal loose files"
/// 
/// When archiving for Mac, set this to true to package it in a .app bundle instead of normal loose files
/// </summary>
        public virtual UnrealAutomationToolConfig Createappbundle(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-createappbundle=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-createappbundle");
            return (UnrealAutomationToolConfig) this;
        }

        
        
/// <summary>"True if build step should be executed"
/// 
/// Build: True if build step should be executed, command: -build
/// </summary>
        public virtual UnrealAutomationToolConfig Build(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-build=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-build");
            return (UnrealAutomationToolConfig) this;
        }

        
        
/// <summary>"True if XGE should NOT be used for building"
/// 
/// Build: True if XGE should NOT be used for building.
/// 
/// "Toggle to disable the distributed build process"</summary>
        public virtual UnrealAutomationToolConfig Noxge(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-noxge=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-noxge");
            return (UnrealAutomationToolConfig) this;
        }

        
        
/// <summary>"while cooking clean up packages as we are done with them rather then cleaning everything up when we run out of space"
/// 
/// Cook: While cooking clean up packages as we go along rather then cleaning everything (and potentially having to reload some of it) when we run out of space
/// </summary>
        public virtual UnrealAutomationToolConfig CookPartialgc(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-CookPartialgc=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-CookPartialgc");
            return (UnrealAutomationToolConfig) this;
        }

        
        
/// <summary>"Did we cook in the editor instead of in UAT"
/// 
/// Stage: Did we cook in the editor instead of from UAT (cook in editor uses a different staging directory)
/// </summary>
        public virtual UnrealAutomationToolConfig CookInEditor(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-CookInEditor=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-CookInEditor");
            return (UnrealAutomationToolConfig) this;
        }

        
        
/// <summary>"Uses the iterative cooking, command line: -iterativecooking or -iterate"
/// "Uses the iterative cooking, command line: -iterativedeploy or -iterate"
/// 
/// Cook: Uses the iterative cooking, command line: -iterativecooking or -iterate
/// </summary>
        public virtual UnrealAutomationToolConfig Iterativecooking(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-iterativecooking=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-iterativecooking");
            return (UnrealAutomationToolConfig) this;
        }

        
        
/// <summary>"Cook only maps this only affects usage of -cookall the flag"
/// 
/// Cook: Only cook maps (and referenced content) instead of cooking everything only affects -cookall flag
/// </summary>
        public virtual UnrealAutomationToolConfig CookMapsOnly(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-CookMapsOnly=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-CookMapsOnly");
            return (UnrealAutomationToolConfig) this;
        }

        
        
/// <summary>"Cook all the things in the content directory for this project"
/// 
/// Cook: Only cook maps (and referenced content) instead of cooking everything only affects cookall flag
/// </summary>
        public virtual UnrealAutomationToolConfig CookAll(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-CookAll=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-CookAll");
            return (UnrealAutomationToolConfig) this;
        }

        
        
/// <summary>"Skips content under /Engine/Editor when cooking"
/// 
/// Cook: Skip cooking editor content
/// </summary>
        public virtual UnrealAutomationToolConfig SkipCookingEditorContent(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-SkipCookingEditorContent=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-SkipCookingEditorContent");
            return (UnrealAutomationToolConfig) this;
        }

        
        
/// <summary>"Uses fast cook path if supported by target"</summary>
        public virtual UnrealAutomationToolConfig FastCook(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-FastCook=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-FastCook");
            return (UnrealAutomationToolConfig) this;
        }

        
        
/// <summary>"Ignores cook errors and continues with packaging etc"
/// 
/// Cook: Ignores cook errors and continues with packaging etc.
/// </summary>
        public virtual UnrealAutomationToolConfig IgnoreCookErrors(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-IgnoreCookErrors=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-IgnoreCookErrors");
            return (UnrealAutomationToolConfig) this;
        }

        
        
/// <summary>"do not copy debug files to the stage"
/// 
/// Stage: Commandline: -nodebuginfo
/// </summary>
        public virtual UnrealAutomationToolConfig Nodebuginfo(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-nodebuginfo=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-nodebuginfo");
            return (UnrealAutomationToolConfig) this;
        }

        
        
/// <summary>"output debug info to a separate directory"
/// 
/// Stage: Commandline: -separatedebuginfo
/// </summary>
        public virtual UnrealAutomationToolConfig Separatedebuginfo(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-separatedebuginfo=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-separatedebuginfo");
            return (UnrealAutomationToolConfig) this;
        }

        
        
/// <summary>"generates a *.map file"
/// 
/// Stage: Commandline: -mapfile
/// </summary>
        public virtual UnrealAutomationToolConfig MapFile(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-MapFile=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-MapFile");
            return (UnrealAutomationToolConfig) this;
        }

        
        
/// <summary>"skip cleaning the stage directory"
/// 
/// true if the staging directory is to be cleaned: -cleanstage (also true if -clean is specified)
/// </summary>
        public virtual UnrealAutomationToolConfig Nocleanstage(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-nocleanstage=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-nocleanstage");
            return (UnrealAutomationToolConfig) this;
        }

        
        
/// <summary>"command line to put into the stage in UE4CommandLine.txt"</summary>
        public virtual UnrealAutomationToolConfig Cmdline(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-cmdline=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-cmdline");
            return (UnrealAutomationToolConfig) this;
        }

        
        
/// <summary>"string to use as the bundle name when deploying to mobile device"
/// 
/// Stage: If non-empty, the contents will be used for the bundle name
/// </summary>
        public virtual UnrealAutomationToolConfig Bundlename(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-bundlename=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-bundlename");
            return (UnrealAutomationToolConfig) this;
        }

        
        
/// <summary>"run the game after it is built (including server, if -server)"
/// 
/// Run: True if the Run step should be executed, command: -run
/// </summary>
        public virtual UnrealAutomationToolConfig Run(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-run=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-run");
            return (UnrealAutomationToolConfig) this;
        }

        
        
/// <summary>"run the client with cooked data provided by cook on the fly server"
/// 
/// Run: The client runs with cooked data provided by cook on the fly server, command line: -cookonthefly
/// </summary>
        public virtual UnrealAutomationToolConfig Cookonthefly(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-cookonthefly=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-cookonthefly");
            return (UnrealAutomationToolConfig) this;
        }

        
        
/// <summary>"run the client in streaming cook on the fly mode (don't cache files locally instead force reget from server each file load)"
/// 
/// Run: The client should run in streaming mode when connecting to cook on the fly server
/// </summary>
        public virtual UnrealAutomationToolConfig Cookontheflystreaming(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-Cookontheflystreaming=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-Cookontheflystreaming");
            return (UnrealAutomationToolConfig) this;
        }

        
        
/// <summary>"run the client with cooked data provided by UnrealFileServer"
/// 
/// Run: The client runs with cooked data provided by UnrealFileServer, command line: -fileserver
/// </summary>
        public virtual UnrealAutomationToolConfig Fileserver(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-fileserver=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-fileserver");
            return (UnrealAutomationToolConfig) this;
        }

        
        
/// <summary>"build, cook and run both a client and a server (also -server)"
/// 
/// Run: The client connects to dedicated server to get data, command line: -dedicatedserver
/// </summary>
        public virtual UnrealAutomationToolConfig Dedicatedserver(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-dedicatedserver=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-dedicatedserver");
            return (UnrealAutomationToolConfig) this;
        }

        
        
/// <summary>"build, cook and run a client and a server, uses client target configuration"
/// 
/// Run: Uses a client target configuration, also implies -dedicatedserver, command line: -client
/// </summary>
        public virtual UnrealAutomationToolConfig Client(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-client=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-client");
            return (UnrealAutomationToolConfig) this;
        }

        
        
/// <summary>"do not run the client, just run the server"
/// 
/// Run: Whether the client should start or not, command line (to disable): -noclient
/// </summary>
        public virtual UnrealAutomationToolConfig Noclient(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-noclient=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-noclient");
            return (UnrealAutomationToolConfig) this;
        }

        
        
/// <summary>"create a log window for the client"
/// 
/// Run: Client should create its own log window, command line: -logwindow
/// </summary>
        public virtual UnrealAutomationToolConfig Logwindow(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-logwindow=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-logwindow");
            return (UnrealAutomationToolConfig) this;
        }

        
        
/// <summary>"map to run the game with"</summary>
        public virtual UnrealAutomationToolConfig Map(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-map=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-map");
            return (UnrealAutomationToolConfig) this;
        }

        
        
/// <summary>"Additional server map params, i.e ?param=value"
/// 
/// Run: Additional server map params.
/// </summary>
        public virtual UnrealAutomationToolConfig AdditionalServerMapParams(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-AdditionalServerMapParams=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-AdditionalServerMapParams");
            return (UnrealAutomationToolConfig) this;
        }

        
        
/// <summary>"Devices to run the game on"
/// "Device names without the platform prefix to run the game on"</summary>
        public virtual UnrealAutomationToolConfig Device(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-device=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-device");
            return (UnrealAutomationToolConfig) this;
        }

        
        
/// <summary>"Device to run the server on"
/// 
/// Run: the target device to run the server on
/// </summary>
        public virtual UnrealAutomationToolConfig Serverdevice(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-serverdevice=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-serverdevice");
            return (UnrealAutomationToolConfig) this;
        }

        
        
/// <summary>"Skip starting the server"
/// 
/// Run: The indicated server has already been started
/// </summary>
        public virtual UnrealAutomationToolConfig Skipserver(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-skipserver=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-skipserver");
            return (UnrealAutomationToolConfig) this;
        }

        
        
/// <summary>"Start extra clients, n should be 2 or more"
/// 
/// Run: The indicated server has already been started
/// </summary>
        public virtual UnrealAutomationToolConfig Numclients(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-numclients=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-numclients");
            return (UnrealAutomationToolConfig) this;
        }

        
        
/// <summary>"Additional command line arguments for the program"</summary>
        public virtual UnrealAutomationToolConfig Addcmdline(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-addcmdline=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-addcmdline");
            return (UnrealAutomationToolConfig) this;
        }

        
        
/// <summary>"Additional command line arguments for the program"</summary>
        public virtual UnrealAutomationToolConfig Servercmdline(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-servercmdline=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-servercmdline");
            return (UnrealAutomationToolConfig) this;
        }

        
        
/// <summary>"Override command line arguments to pass to the client"</summary>
        public virtual UnrealAutomationToolConfig Clientcmdline(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-clientcmdline=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-clientcmdline");
            return (UnrealAutomationToolConfig) this;
        }

        
        
/// <summary>"add -nullrhi to the client commandlines"
/// 
/// Run:adds -nullrhi to the client commandline
/// </summary>
        public virtual UnrealAutomationToolConfig Nullrhi(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-nullrhi=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-nullrhi");
            return (UnrealAutomationToolConfig) this;
        }

        
        
/// <summary>"adds ?fake to the server URL"
/// 
/// Run:adds ?fake to the server URL
/// </summary>
        public virtual UnrealAutomationToolConfig Fakeclient(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-fakeclient=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-fakeclient");
            return (UnrealAutomationToolConfig) this;
        }

        
        
/// <summary>"rather than running a client, run the editor instead"
/// 
/// Run:adds ?fake to the server URL
/// </summary>
        public virtual UnrealAutomationToolConfig Editortest(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-editortest=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-editortest");
            return (UnrealAutomationToolConfig) this;
        }

        
        
/// <summary>"when running -editortest or a client, run all automation tests, not compatible with -server"
/// "when running -editortest or a client, run a specific automation tests, not compatible with -server"
/// 
/// Run:when running -editortest or a client, run all automation tests, not compatible with -server
/// </summary>
        public virtual UnrealAutomationToolConfig RunAutomationTests(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-RunAutomationTests=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-RunAutomationTests");
            return (UnrealAutomationToolConfig) this;
        }

        
        
/// <summary>"when running -editortest or a client, adds commands like debug crash, debug rendercrash, etc based on index"</summary>
        public virtual UnrealAutomationToolConfig Crash(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-Crash=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-Crash");
            return (UnrealAutomationToolConfig) this;
        }

        
        
/// <summary>"Linux username for unattended key genereation"</summary>
        public virtual UnrealAutomationToolConfig Deviceuser(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-deviceuser=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-deviceuser");
            return (UnrealAutomationToolConfig) this;
        }

        
        
/// <summary>"Linux password"</summary>
        public virtual UnrealAutomationToolConfig Devicepass(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-devicepass=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-devicepass");
            return (UnrealAutomationToolConfig) this;
        }

        
        
/// <summary>"package the project for the target platform"
/// "Determine whether data is packaged. This can be an iteration optimization for platforms that require packages for deployment"</summary>
        public virtual UnrealAutomationToolConfig Package(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-package=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-package");
            return (UnrealAutomationToolConfig) this;
        }

        
        
/// <summary>"Skips packaging the project for the target platform"</summary>
        public virtual UnrealAutomationToolConfig Skippackage(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-skippackage=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-skippackage");
            return (UnrealAutomationToolConfig) this;
        }

        
        
/// <summary>"package for distribution the project"</summary>
        public virtual UnrealAutomationToolConfig Distribution(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-distribution=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-distribution");
            return (UnrealAutomationToolConfig) this;
        }

        
        
/// <summary>"stage prerequisites along with the project"</summary>
        public virtual UnrealAutomationToolConfig Prereqs(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-prereqs=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-prereqs");
            return (UnrealAutomationToolConfig) this;
        }

        
        
/// <summary>"location of prerequisites for applocal deployment"</summary>
        public virtual UnrealAutomationToolConfig Applocaldir(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-applocaldir" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-applocaldir");
            return (UnrealAutomationToolConfig) this;
        }

        
        
/// <summary>"this is a prebuilt cooked and packaged build"</summary>
        public virtual UnrealAutomationToolConfig Prebuilt(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-Prebuilt=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-Prebuilt");
            return (UnrealAutomationToolConfig) this;
        }

        
        
/// <summary>"timeout to wait after we lunch the game"</summary>
        public virtual UnrealAutomationToolConfig RunTimeoutSeconds(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-RunTimeoutSeconds=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-RunTimeoutSeconds");
            return (UnrealAutomationToolConfig) this;
        }

        
        
/// <summary>"Determine a specific Minimum OS"</summary>
        public virtual UnrealAutomationToolConfig SpecifiedArchitecture(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-SpecifiedArchitecture=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-SpecifiedArchitecture");
            return (UnrealAutomationToolConfig) this;
        }

        
        
/// <summary>"extra options to pass to ubt"</summary>
        public virtual UnrealAutomationToolConfig UbtArgs(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-UbtArgs=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-UbtArgs");
            return (UnrealAutomationToolConfig) this;
        }

        
        
/// <summary>"extra options to pass to the platform's packager"</summary>
        public virtual UnrealAutomationToolConfig AdditionalPackageOptions(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-AdditionalPackageOptions=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-AdditionalPackageOptions");
            return (UnrealAutomationToolConfig) this;
        }

        
        
/// <summary>"deploy the project for the target platform"
/// "Location to deploy to on the target platform"</summary>
        public virtual UnrealAutomationToolConfig Deploy(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-deploy=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-deploy");
            return (UnrealAutomationToolConfig) this;
        }

        
        
/// <summary>"download file from target after successful run"</summary>
        public virtual UnrealAutomationToolConfig Getfile(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-getfile=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-getfile");
            return (UnrealAutomationToolConfig) this;
        }

        
        
/// <summary>"List of maps that need light maps rebuilding"</summary>
        public virtual UnrealAutomationToolConfig MapsToRebuildLightMaps(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-MapsToRebuildLightMaps=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-MapsToRebuildLightMaps");
            return (UnrealAutomationToolConfig) this;
        }

        
        
/// <summary>"List of maps that need HLOD rebuilding"</summary>
        public virtual UnrealAutomationToolConfig MapsToRebuildHLODMaps(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-MapsToRebuildHLODMaps=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-MapsToRebuildHLODMaps");
            return (UnrealAutomationToolConfig) this;
        }

        
        
/// <summary>"Whether Light Map errors should be treated as critical"</summary>
        public virtual UnrealAutomationToolConfig IgnoreLightMapErrors(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-IgnoreLightMapErrors" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-IgnoreLightMapErrors");
            return (UnrealAutomationToolConfig) this;
        }

        
        
    
        public virtual UnrealAutomationToolConfig Cookflavor(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-cookflavor=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-cookflavor");
            return (UnrealAutomationToolConfig) this;
        }

        
        
    
        public virtual UnrealAutomationToolConfig Ddc(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-ddc=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-ddc");
            return (UnrealAutomationToolConfig) this;
        }

        
        
    
        public virtual UnrealAutomationToolConfig I18npreset(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-i18npreset=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-i18npreset");
            return (UnrealAutomationToolConfig) this;
        }

        
        
    
        public virtual UnrealAutomationToolConfig CookCultures(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-CookCultures=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-CookCultures");
            return (UnrealAutomationToolConfig) this;
        }

        
        
    
        public virtual UnrealAutomationToolConfig Skipbuild(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-skipbuild=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-skipbuild");
            return (UnrealAutomationToolConfig) this;
        }

        
        
/// <summary>
/// SkipBuildClient if true then don't build the client exe
/// </summary>
        public virtual UnrealAutomationToolConfig SkipBuildClient(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-skipbuildclient=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-skipbuildclient");
            return (UnrealAutomationToolConfig) this;
        }

        
        
/// <summary>
/// SkipBuildEditor if true then don't build the editor exe
/// </summary>
        public virtual UnrealAutomationToolConfig SkipBuildEditor(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-skipbuildeditor=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-skipbuildeditor");
            return (UnrealAutomationToolConfig) this;
        }

        
        
    
        public virtual UnrealAutomationToolConfig Createreleaseversionroot(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-createreleaseversionroot=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-createreleaseversionroot");
            return (UnrealAutomationToolConfig) this;
        }

        
        
    
        public virtual UnrealAutomationToolConfig Basedonreleaseversionroot(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-basedonreleaseversionroot=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-basedonreleaseversionroot");
            return (UnrealAutomationToolConfig) this;
        }

        
        
/// <summary>
/// The version of the originally released build. This is required by some platforms when generating patches.
/// </summary>
        public virtual UnrealAutomationToolConfig OriginalReleaseVersion(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-originalreleaseversion=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-originalreleaseversion");
            return (UnrealAutomationToolConfig) this;
        }

        
        
/// <summary>
/// Cook: Create a cooked release version.  Also, the version. e.g. 1.0
/// </summary>
        public virtual UnrealAutomationToolConfig CreateReleaseVersion(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-createreleaseversion=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-createreleaseversion");
            return (UnrealAutomationToolConfig) this;
        }

        
        
/// <summary>
/// Cook: Base this cook of a already released version of the cooked data
/// </summary>
        public virtual UnrealAutomationToolConfig BasedOnReleaseVersion(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-basedonreleaseversion=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-basedonreleaseversion");
            return (UnrealAutomationToolConfig) this;
        }

        
        
/// <summary>
/// Are we generating a patch, generate a patch from a previously released version of the game (use CreateReleaseVersion to create a release).
/// this requires BasedOnReleaseVersion
/// see also CreateReleaseVersion, BasedOnReleaseVersion
/// </summary>
        public virtual UnrealAutomationToolConfig GeneratePatch(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-GeneratePatch=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-GeneratePatch");
            return (UnrealAutomationToolConfig) this;
        }

        
        
/// <summary></summary>
        public virtual UnrealAutomationToolConfig AddPatchLevel(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-AddPatchLevel=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-AddPatchLevel");
            return (UnrealAutomationToolConfig) this;
        }

        
        
/// <summary>
/// Are we staging the unmodified pak files from the base release</summary>
        public virtual UnrealAutomationToolConfig StageBaseReleasePaks(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-StageBaseReleasePaks=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-StageBaseReleasePaks");
            return (UnrealAutomationToolConfig) this;
        }

        
        
/// <summary>
/// Required when building remaster package
/// </summary>
        public virtual UnrealAutomationToolConfig DiscVersion(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-DiscVersion=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-DiscVersion");
            return (UnrealAutomationToolConfig) this;
        }

        
        
/// <summary>
/// Cook: Additional cooker options to include on the cooker commandline
/// </summary>
        public virtual UnrealAutomationToolConfig AdditionalCookerOptions(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-AdditionalCookerOptions=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-AdditionalCookerOptions");
            return (UnrealAutomationToolConfig) this;
        }

        
        
    
        public virtual UnrealAutomationToolConfig DLCName(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-DLCName=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-DLCName");
            return (UnrealAutomationToolConfig) this;
        }

        
        
/// <summary>
/// After cook completes diff the cooked content against another cooked content directory.
/// report all errors to the log
/// </summary>
        public virtual UnrealAutomationToolConfig DiffCookedContentPath(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-DiffCookedContentPath=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-DiffCookedContentPath");
            return (UnrealAutomationToolConfig) this;
        }

        
        
/// <summary>
/// Enable cooking of engine content when cooking dlc
/// not included in original release but is referenced by current cook
/// </summary>
        public virtual UnrealAutomationToolConfig DLCIncludeEngineContent(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-DLCIncludeEngineContent=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-DLCIncludeEngineContent");
            return (UnrealAutomationToolConfig) this;
        }

        
        
/// <summary>
/// Enable packaging up the uplugin file inside the dlc pak.  This is sometimes desired if you want the plugin to be standalone
/// </summary>
        public virtual UnrealAutomationToolConfig DLCPakPluginFile(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-DLCPakPluginFile=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-DLCPakPluginFile");
            return (UnrealAutomationToolConfig) this;
        }

        
        
/// <summary>
/// DLC will remap it's files to the game directory and act like a patch.  This is useful if you want to override content in the main game along side your main game.
/// For example having different main game content in different DLCs
/// </summary>
        public virtual UnrealAutomationToolConfig DLCActLikePatch(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-DLCActLikePatch=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-DLCActLikePatch");
            return (UnrealAutomationToolConfig) this;
        }

        
        
/// <summary>
/// Shared: the game will use only signed content.
/// </summary>
        public virtual UnrealAutomationToolConfig SignedPak(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-signedpak=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-signedpak");
            return (UnrealAutomationToolConfig) this;
        }

        
        
/// <summary>
/// Stage: True if we should disable trying to re-use pak files from another staged build when we've specified a different cook source platform
/// </summary>
        public virtual UnrealAutomationToolConfig IgnorePaksFromDifferentCookSource(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-IgnorePaksFromDifferentCookSource=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-IgnorePaksFromDifferentCookSource");
            return (UnrealAutomationToolConfig) this;
        }

        
        
/// <summary>
/// Cook: Do not include a version number in the cooked content
/// </summary>
        public virtual UnrealAutomationToolConfig UnversionedCookedContent(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-UnversionedCookedContent=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-UnversionedCookedContent");
            return (UnrealAutomationToolConfig) this;
        }

        
        
/// <summary>
/// Cook: number of additional cookers to spawn while cooking
/// </summary>
        public virtual UnrealAutomationToolConfig NumCookersToSpawn(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-NumCookersToSpawn=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-NumCookersToSpawn");
            return (UnrealAutomationToolConfig) this;
        }

        
        
/// <summary>
/// Compress packages during cook.
/// </summary>
        public virtual UnrealAutomationToolConfig Compressed(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-compressed=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-compressed");
            return (UnrealAutomationToolConfig) this;
        }

        
        
/// <summary>
/// Do not compress packages during cook, override game ProjectPackagingSettings to force it off
/// </summary>
        public virtual UnrealAutomationToolConfig ForceUncompressed(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-ForceUncompressed=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-ForceUncompressed");
            return (UnrealAutomationToolConfig) this;
        }

        
        
/// <summary>
/// Additional parameters when generating the PAK file
/// </summary>
        public virtual UnrealAutomationToolConfig AdditionalPakOptions(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-AdditionalPakOptions=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-AdditionalPakOptions");
            return (UnrealAutomationToolConfig) this;
        }

        
        
/// <summary>
/// Additional parameters when generating iostore container files
/// </summary>
        public virtual UnrealAutomationToolConfig AdditionalIoStoreOptions(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-AdditionalIoStoreOptions=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-AdditionalIoStoreOptions");
            return (UnrealAutomationToolConfig) this;
        }

        
        
/// <summary>
/// Cook: Iterate from a build on the network
/// </summary>
        public virtual UnrealAutomationToolConfig Iteratesharedcookedbuild(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-iteratesharedcookedbuild=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-iteratesharedcookedbuild");
            return (UnrealAutomationToolConfig) this;
        }

        
        
/// <summary>
/// Build: Don't build the game instead use the prebuild exe (requires iterate shared cooked build
/// </summary>
        public virtual UnrealAutomationToolConfig IterateSharedBuildUsePrecompiledExe(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-IterateSharedBuildUsePrecompiledExe=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-IterateSharedBuildUsePrecompiledExe");
            return (UnrealAutomationToolConfig) this;
        }

        
        
/// <summary>
/// Cook: Output directory for cooked data
/// </summary>
        public virtual UnrealAutomationToolConfig CookOutputDir(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-CookOutputDir=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-CookOutputDir");
            return (UnrealAutomationToolConfig) this;
        }

        
        
    
        public virtual UnrealAutomationToolConfig Target(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-target=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-target");
            return (UnrealAutomationToolConfig) this;
        }

        
        
/// <summary>Stage: Specifies a list of extra targets that should be staged along with a client
/// </summary>
        public virtual UnrealAutomationToolConfig ExtraTargetsToStageWithClient(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-ExtraTargetsToStageWithClient=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-ExtraTargetsToStageWithClient");
            return (UnrealAutomationToolConfig) this;
        }

        
        
/// <summary>
/// By default we don't code sign unless it is required or requested
/// </summary>
        public virtual UnrealAutomationToolConfig CodeSign(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-CodeSign=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-CodeSign");
            return (UnrealAutomationToolConfig) this;
        }

        
        
/// <summary>
/// If true, non-shipping binaries will be considered DebugUFS files and will appear on the debugfiles manifest
/// </summary>
        public virtual UnrealAutomationToolConfig TreatNonShippingBinariesAsDebugFiles(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-TreatNonShippingBinariesAsDebugFiles=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-TreatNonShippingBinariesAsDebugFiles");
            return (UnrealAutomationToolConfig) this;
        }

        
        
/// <summary>
/// If true, use chunk manifest files generated for extra flavor
/// </summary>
        public virtual UnrealAutomationToolConfig UseExtraFlavor(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-UseExtraFlavor=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-UseExtraFlavor");
            return (UnrealAutomationToolConfig) this;
        }

        
        
/// <summary>
/// Shared: Directory to use for built chunk install data, command line: -chunkinstalldirectory=
/// </summary>
        public virtual UnrealAutomationToolConfig ChunkInstallDirectory(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-chunkinstalldirectory=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-chunkinstalldirectory");
            return (UnrealAutomationToolConfig) this;
        }

        
        
    
        public virtual UnrealAutomationToolConfig Chunkinstallversion(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-chunkinstallversion=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-chunkinstallversion");
            return (UnrealAutomationToolConfig) this;
        }

        
        
    
        public virtual UnrealAutomationToolConfig Chunkinstallrelease(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-chunkinstallrelease=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-chunkinstallrelease");
            return (UnrealAutomationToolConfig) this;
        }

        
        
    
        public virtual UnrealAutomationToolConfig AppLocalDirectory(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-applocaldirectory=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-applocaldirectory");
            return (UnrealAutomationToolConfig) this;
        }

        
        
/// <summary>
/// On Windows, adds an executable to the root of the staging directory which checks for prerequisites being
/// installed and launches the game with a path to the .uproject file.
/// </summary>
        public virtual UnrealAutomationToolConfig NoBootstrapExe(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-nobootstrapexe=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-nobootstrapexe");
            return (UnrealAutomationToolConfig) this;
        }

        
        
    
        public virtual UnrealAutomationToolConfig ForcePackageData(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-forcepackagedata=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-forcepackagedata");
            return (UnrealAutomationToolConfig) this;
        }

        
        
/// <summary>
/// Cook: Uses the iterative deploy, command line: -iterativedeploy or -iterate
/// </summary>
        public virtual UnrealAutomationToolConfig IterativeDeploy(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-iterativedeploy=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-iterativedeploy");
            return (UnrealAutomationToolConfig) this;
        }

        
        
/// <summary>
/// Provision to use
/// </summary>
        public virtual UnrealAutomationToolConfig Provision(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-provision=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-provision");
            return (UnrealAutomationToolConfig) this;
        }

        
        
/// <summary>
/// Certificate to use
/// </summary>
        public virtual UnrealAutomationToolConfig Certificate(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-certificate=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-certificate");
            return (UnrealAutomationToolConfig) this;
        }

        
        
/// <summary>
/// Team ID to use
/// </summary>
        public virtual UnrealAutomationToolConfig Team(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-team=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-team");
            return (UnrealAutomationToolConfig) this;
        }

        
        
/// <summary>
/// true if provisioning is automatically managed
/// </summary>
        public virtual UnrealAutomationToolConfig AutomaticSigning(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-AutomaticSigning=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-AutomaticSigning");
            return (UnrealAutomationToolConfig) this;
        }

        
        
/// <summary>
/// Run:when running -editortest or a client, run all automation tests, not compatible with -server
/// </summary>
        public virtual UnrealAutomationToolConfig RunAutomationTest(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-RunAutomationTest=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-RunAutomationTest");
            return (UnrealAutomationToolConfig) this;
        }

        
        
    
        public virtual UnrealAutomationToolConfig Clientconfig(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-clientconfig=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-clientconfig");
            return (UnrealAutomationToolConfig) this;
        }

        
        
    
        public virtual UnrealAutomationToolConfig Config(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-config=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-config");
            return (UnrealAutomationToolConfig) this;
        }

        
        
    
        public virtual UnrealAutomationToolConfig Configuration(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-configuration=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-configuration");
            return (UnrealAutomationToolConfig) this;
        }

        
        
    
        public virtual UnrealAutomationToolConfig Port(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-port=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-port");
            return (UnrealAutomationToolConfig) this;
        }

        
        
/// <summary>
/// Cook: List of maps to cook.
/// </summary>
        public virtual UnrealAutomationToolConfig MapsToCook(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-MapsToCook=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-MapsToCook");
            return (UnrealAutomationToolConfig) this;
        }

        
        
/// <summary>
/// Cook: List of map inisections to cook (see allmaps)
/// </summary>
        public virtual UnrealAutomationToolConfig MapIniSectionsToCook(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-MapIniSectionsToCook=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-MapIniSectionsToCook");
            return (UnrealAutomationToolConfig) this;
        }

        
        
/// <summary>
/// TitleID to package
/// </summary>
        public virtual UnrealAutomationToolConfig TitleID(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-TitleID=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-TitleID");
            return (UnrealAutomationToolConfig) this;
        }

        
        
    
        public virtual UnrealAutomationToolConfig Serverconfig(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-serverconfig=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-serverconfig");
            return (UnrealAutomationToolConfig) this;
        }

        
        
/// <summary>
/// Run: Adds commands like debug crash, debug rendercrash, etc based on index
/// </summary>
        public virtual UnrealAutomationToolConfig CrashIndex(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-CrashIndex=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-CrashIndex");
            return (UnrealAutomationToolConfig) this;
        }

        
        
    
        public virtual UnrealAutomationToolConfig IgnoreDependencies(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-IgnoreDependencies=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-IgnoreDependencies");
            return (UnrealAutomationToolConfig) this;
        }

        
        
/// <summary>
/// This command is LEGACY because we used to run UAT.exe to compile scripts by default.
/// Now we only compile by default when run via RunUAT.bat, which still understands -nocompile.
/// However, the batch file simply passes on all arguments, so UAT will choke when encountering -nocompile.
/// Keep this CommandLineArg around so that doesn't happen.
/// </summary>
        public virtual UnrealAutomationToolConfig NoCompileLegacyDontUse(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-NoCompile=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-NoCompile");
            return (UnrealAutomationToolConfig) this;
        }

        
        
    
        public virtual UnrealAutomationToolConfig NoCompileEditor(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-NoCompileEditor=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-NoCompileEditor");
            return (UnrealAutomationToolConfig) this;
        }

        
        
    
        public virtual UnrealAutomationToolConfig AllowStdOutLogVerbosity(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-AllowStdOutLogVerbosity=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-AllowStdOutLogVerbosity");
            return (UnrealAutomationToolConfig) this;
        }

        
        
    
        public virtual UnrealAutomationToolConfig NoAutoSDK(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-NoAutoSDK=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-NoAutoSDK");
            return (UnrealAutomationToolConfig) this;
        }

        
    
    public  class ProgramConfig : ToolConfig
    {
        public override string Name => "Program";
    
        
    
        public virtual ProgramConfig Utf8output(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-Utf8output=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-Utf8output");
            return (ProgramConfig) this;
        }

        
        
    
        public virtual ProgramConfig Verbose(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-Verbose=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-Verbose");
            return (ProgramConfig) this;
        }

        
        
    
        public virtual ProgramConfig VeryVerbose(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-VeryVerbose=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-VeryVerbose");
            return (ProgramConfig) this;
        }

        
        
    
        public virtual ProgramConfig Timestamps(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-Timestamps=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-Timestamps");
            return (ProgramConfig) this;
        }
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    
        public override string Gather()
        {
            return base.Gather();
        }
    }

    protected readonly ProgramConfig ProgramStorage = new();
        
/// <summary>@"Executes scripted commands
/// 
/// AutomationTool.exe [-verbose] [-compileonly] [-p4] Command0 [-Arg0 -Arg1 -Arg2 ...] Command1 [-Arg0 -Arg1 ...] Command2 [-Arg0 ...] Commandn ... [EnvVar0=MyValue0 ... EnvVarn=MyValuen]"</summary>
    public  class AutomationConfig : ToolConfig
    {
        public override string Name => "Automation";
    
        
/// <summary>"Enables verbose logging"</summary>
        public virtual AutomationConfig Verbose(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-verbose=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-verbose");
            return (AutomationConfig) this;
        }

        
        
/// <summary>"Disables Perforce functionality (default if not run on a build machine)"</summary>
        public virtual AutomationConfig Nop4(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-nop4=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-nop4");
            return (AutomationConfig) this;
        }

        
        
/// <summary>"Enables Perforce functionality (default if run on a build machine)"</summary>
        public virtual AutomationConfig P4(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-p4=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-p4");
            return (AutomationConfig) this;
        }

        
        
/// <summary>"Does not run any commands, only compiles them"</summary>
        public virtual AutomationConfig Compileonly(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-compileonly=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-compileonly");
            return (AutomationConfig) this;
        }

        
        
/// <summary>"Dynamically compiles all commands (otherwise assumes they are already built)"</summary>
        public virtual AutomationConfig Compile(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-compile=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-compile");
            return (AutomationConfig) this;
        }

        
        
/// <summary>"Displays help"</summary>
        public virtual AutomationConfig Help(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-help=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-help");
            return (AutomationConfig) this;
        }

        
        
/// <summary>"Lists all available commands"</summary>
        public virtual AutomationConfig List(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-list=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-list");
            return (AutomationConfig) this;
        }

        
        
/// <summary>"Allows UAT command to submit changes"</summary>
        public virtual AutomationConfig Submit(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-submit=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-submit");
            return (AutomationConfig) this;
        }

        
        
/// <summary>"Prevents any submit attempts"</summary>
        public virtual AutomationConfig Nosubmit(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-nosubmit=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-nosubmit");
            return (AutomationConfig) this;
        }

        
        
/// <summary>"Does not kill any spawned processes on exit"</summary>
        public virtual AutomationConfig Nokill(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-nokill=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-nokill");
            return (AutomationConfig) this;
        }

        
        
/// <summary>"Prevents UBT from cleaning junk files"</summary>
        public virtual AutomationConfig Ignorejunk(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-ignorejunk" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-ignorejunk");
            return (AutomationConfig) this;
        }

        
        
/// <summary>@"Allows you to use local storage for your root build storage dir (default of P:\Builds (on PC) is changed to Engine\Saved\LocalBuilds). Used for local testing."
/// 
/// Allows you to use local storage for your root build storage dir (default of P:\Builds (on PC) is changed to Engine\Saved\LocalBuilds). Used for local testing.
/// </summary>
        public virtual AutomationConfig UseLocalBuildStorage(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-UseLocalBuildStorage=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-UseLocalBuildStorage");
            return (AutomationConfig) this;
        }

        
        
    
        public virtual AutomationConfig Telemetry(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-Telemetry=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-Telemetry");
            return (AutomationConfig) this;
        }
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    
        public override string Gather()
        {
            return base.Gather();
        }
    }

    protected readonly AutomationConfig AutomationStorage = new();
        
    
    public  class CodeSignConfig : ToolConfig
    {
        public override string Name => "CodeSign";
    
        
/// <summary>"Skips signing of code/content files."</summary>
        public virtual CodeSignConfig NoSign(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-NoSign=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-NoSign");
            return (CodeSignConfig) this;
        }
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    
        public override string Gather()
        {
            return base.Gather();
        }
    }

    protected readonly CodeSignConfig CodeSignStorage = new();
        
    
    public  class McpConfigMapperConfig : ToolConfig
    {
        public override string Name => "McpConfigMapper";
    
        
    
        public virtual McpConfigMapperConfig MCPConfig(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-MCPConfig=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-MCPConfig");
            return (McpConfigMapperConfig) this;
        }
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    
        public override string Gather()
        {
            return base.Gather();
        }
    }

    protected readonly McpConfigMapperConfig McpConfigMapperStorage = new();
        
    
    public  class P4EnvironmentConfig : ToolConfig
    {
        public override string Name => "P4Environment";
    
        
/// <summary>
/// The Perforce host and port number (eg. perforce:1666)
/// </summary>
        public virtual P4EnvironmentConfig P4port(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-p4port=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-p4port");
            return (P4EnvironmentConfig) this;
        }

        
        
    
        public virtual P4EnvironmentConfig P4user(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-p4user=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-p4user");
            return (P4EnvironmentConfig) this;
        }
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    
        public override string Gather()
        {
            return base.Gather();
        }
    }

    protected readonly P4EnvironmentConfig P4EnvironmentStorage = new();
        
/// <summary>Auto-detects P4 settings based on the current path and creates a p4config file with the relevant settings.</summary>
    public  class P4WriteConfigConfig : ToolConfig
    {
        public override string Name => "P4WriteConfig";
    
        
/// <summary>"Adds a P4IGNORE to the default file (Engine/Extras/Perforce/p4ignore)"</summary>
        public virtual P4WriteConfigConfig Setignore(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-setignore=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-setignore");
            return (P4WriteConfigConfig) this;
        }

        
        
/// <summary>"Write to a path other than the current directory"</summary>
        public virtual P4WriteConfigConfig Path(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-path=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-path");
            return (P4WriteConfigConfig) this;
        }

        
        
/// <summary>"Optional hint/override of the server to use during lookup"</summary>
        public virtual P4WriteConfigConfig P4port(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-p4port=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-p4port");
            return (P4WriteConfigConfig) this;
        }

        
        
/// <summary>"Optional hint/override of the username to use during lookup"</summary>
        public virtual P4WriteConfigConfig P4user(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-p4user=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-p4user");
            return (P4WriteConfigConfig) this;
        }

        
        
    
        public virtual P4WriteConfigConfig Listonly(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-listonly=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-listonly");
            return (P4WriteConfigConfig) this;
        }
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    
        public override string Gather()
        {
            Arguments.Insert(0, "P4WriteConfig");return base.Gather();
        }
    }

    protected readonly P4WriteConfigConfig P4WriteConfigStorage = new();
        
/// <summary>Iteratively cook from a shared cooked build
/// Iteratively cook from a shared cooked build</summary>
    public  class ProjectParamsConfig : ToolConfig
    {
        public override string Name => "ProjectParams";
    
        
/// <summary>"target platform for building, cooking and deployment (also -Platform)"</summary>
        public virtual ProjectParamsConfig Targetplatform(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-targetplatform=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-targetplatform");
            return (ProjectParamsConfig) this;
        }

        
        
/// <summary>"target platform for building, cooking and deployment of the dedicated server (also -ServerPlatform)"</summary>
        public virtual ProjectParamsConfig Servertargetplatform(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-servertargetplatform=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-servertargetplatform");
            return (ProjectParamsConfig) this;
        }

        
        
/// <summary>"Generate a foreign uproject from blankproject and use that"
/// 
/// Shared: The current project is a foreign project, commandline: -foreign
/// </summary>
        public virtual ProjectParamsConfig Foreign(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-foreign=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-foreign");
            return (ProjectParamsConfig) this;
        }

        
        
/// <summary>"Generate a foreign code uproject from platformergame and use that"
/// 
/// Shared: The current project is a foreign project, commandline: -foreign
/// </summary>
        public virtual ProjectParamsConfig Foreigncode(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-foreigncode=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-foreigncode");
            return (ProjectParamsConfig) this;
        }

        
        
/// <summary>"true if we should build crash reporter"
/// 
/// Shared: true if we should build crash reporter
/// </summary>
        public virtual ProjectParamsConfig CrashReporter(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-CrashReporter=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-CrashReporter");
            return (ProjectParamsConfig) this;
        }

        
        
/// <summary>"Determines if the build is going to use cooked data"
/// 
/// Shared: Determines if the build is going to use cooked data, commandline: -cook, -cookonthefly
/// </summary>
        public virtual ProjectParamsConfig Cook(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-cook=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-cook");
            return (ProjectParamsConfig) this;
        }

        
        
/// <summary>"use a cooked build, but we assume the cooked data is up to date and where it belongs, implies -cook"
/// 
/// Shared: Determines if the build is going to use cooked data, commandline: -cook, -cookonthefly
/// </summary>
        public virtual ProjectParamsConfig Skipcook(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-skipcook=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-skipcook");
            return (ProjectParamsConfig) this;
        }

        
        
/// <summary>"in a cookonthefly build, used solely to pass information to the package step"
/// 
/// Shared: In a cookonthefly build, used solely to pass information to the package step. This is necessary because you can't set cookonthefly and cook at the same time, and skipcook sets cook.
/// </summary>
        public virtual ProjectParamsConfig Skipcookonthefly(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-skipcookonthefly=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-skipcookonthefly");
            return (ProjectParamsConfig) this;
        }

        
        
/// <summary>"wipe intermediate folders before building"
/// 
/// Shared: Determines if the intermediate folders will be wiped before building, commandline: -clean
/// </summary>
        public virtual ProjectParamsConfig Clean(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-clean=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-clean");
            return (ProjectParamsConfig) this;
        }

        
        
/// <summary>"assumes no operator is present, always terminates without waiting for something."
/// 
/// Shared: Assumes no user is sitting at the console, so for example kills clients automatically, commandline: -Unattended
/// </summary>
        public virtual ProjectParamsConfig Unattended(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-unattended=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-unattended");
            return (ProjectParamsConfig) this;
        }

        
        
/// <summary>"generate a pak file"
/// "disable reuse of pak files from the alternate cook source folder, if specified"
/// 
/// Shared: True if pak file should be generated.
/// </summary>
        public virtual ProjectParamsConfig Pak(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-pak=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-pak");
            return (ProjectParamsConfig) this;
        }

        
        
/// <summary>"generate I/O store container file(s)"
/// 
/// Shared: True if container file(s) should be generated with ZenPak.
/// </summary>
        public virtual ProjectParamsConfig Iostore(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-iostore=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-iostore");
            return (ProjectParamsConfig) this;
        }

        
        
/// <summary>"generate optimized config data during staging to improve loadtimes"</summary>
        public virtual ProjectParamsConfig Makebinaryconfig(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-makebinaryconfig=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-makebinaryconfig");
            return (ProjectParamsConfig) this;
        }

        
        
/// <summary>"sign the generated pak file with the specified key, i.e. -signpak=C:\\Encryption.keys. Also implies -signedpak."
/// 
/// Shared: Encryption keys used for signing the pak file.
/// </summary>
        public virtual ProjectParamsConfig Signpak(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-signpak=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-signpak");
            return (ProjectParamsConfig) this;
        }

        
        
/// <summary>"attempt to avoid cooking and instead pull pak files from the network, implies pak and skipcook"
/// 
/// Shared: true if this build is staged, command line: -stage
/// </summary>
        public virtual ProjectParamsConfig Prepak(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-prepak=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-prepak");
            return (ProjectParamsConfig) this;
        }

        
        
/// <summary>"the game should expect to use a signed pak file."</summary>
        public virtual ProjectParamsConfig Signed(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-signed" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-signed");
            return (ProjectParamsConfig) this;
        }

        
        
/// <summary>"The game will be set up for memory mapping bulk data."
/// 
/// Shared: The game will be set up for memory mapping bulk data.
/// </summary>
        public virtual ProjectParamsConfig PakAlignForMemoryMapping(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-PakAlignForMemoryMapping=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-PakAlignForMemoryMapping");
            return (ProjectParamsConfig) this;
        }

        
        
/// <summary>"use a pak file, but assume it is already built, implies pak"
/// 
/// Shared: true if this build is staged, command line: -stage
/// </summary>
        public virtual ProjectParamsConfig Skippak(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-skippak=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-skippak");
            return (ProjectParamsConfig) this;
        }

        
        
/// <summary>"override the -iostore commandline option to not run it"
/// 
/// Shared: true if we want to skip iostore, even if -iostore is specified
/// </summary>
        public virtual ProjectParamsConfig Skipiostore(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-skipiostore=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-skipiostore");
            return (ProjectParamsConfig) this;
        }

        
        
/// <summary>"put this build in a stage directory"
/// 
/// Shared: true if this build is staged, command line: -stage
/// </summary>
        public virtual ProjectParamsConfig Stage(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-stage=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-stage");
            return (ProjectParamsConfig) this;
        }

        
        
/// <summary>"uses a stage directory, but assumes everything is already there, implies -stage"
/// 
/// Shared: true if this build is staged, command line: -stage
/// </summary>
        public virtual ProjectParamsConfig Skipstage(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-skipstage=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-skipstage");
            return (ProjectParamsConfig) this;
        }

        
        
/// <summary>"generate streaming install manifests when cooking data"
/// 
/// Shared: true if this build is using streaming install manifests, command line: -manifests
/// </summary>
        public virtual ProjectParamsConfig Manifests(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-manifests=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-manifests");
            return (ProjectParamsConfig) this;
        }

        
        
/// <summary>"generate streaming install data from manifest when cooking data, requires -stage &amp; -manifests"
/// 
/// Shared: true if this build chunk install streaming install data, command line: -createchunkinstalldata
/// </summary>
        public virtual ProjectParamsConfig Createchunkinstall(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-createchunkinstall=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-createchunkinstall");
            return (ProjectParamsConfig) this;
        }

        
        
/// <summary>"skips encrypting pak files even if crypto keys are provided"</summary>
        public virtual ProjectParamsConfig Skipencryption(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-skipencryption=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-skipencryption");
            return (ProjectParamsConfig) this;
        }

        
        
/// <summary>"Directory to copy the builds to, i.e. -stagingdirectory=C:\\Stage"</summary>
        public virtual ProjectParamsConfig Stagingdirectory(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-stagingdirectory=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-stagingdirectory");
            return (ProjectParamsConfig) this;
        }

        
        
/// <summary>"Name of the UE4 Editor executable, i.e. -ue4exe=UE4Editor.exe"</summary>
        public virtual ProjectParamsConfig Ue4exe(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-ue4exe=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-ue4exe");
            return (ProjectParamsConfig) this;
        }

        
        
/// <summary>"put this build in an archive directory"
/// 
/// Shared: true if this build is archived, command line: -archive
/// </summary>
        public virtual ProjectParamsConfig Archive(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-archive=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-archive");
            return (ProjectParamsConfig) this;
        }

        
        
/// <summary>"Directory to archive the builds to, i.e. -archivedirectory=C:\\Archive"</summary>
        public virtual ProjectParamsConfig Archivedirectory(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-archivedirectory=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-archivedirectory");
            return (ProjectParamsConfig) this;
        }

        
        
/// <summary>"Archive extra metadata files in addition to the build (e.g. build.properties)"
/// 
/// Whether the project should use non monolithic staging
/// </summary>
        public virtual ProjectParamsConfig Archivemetadata(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-archivemetadata=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-archivemetadata");
            return (ProjectParamsConfig) this;
        }

        
        
/// <summary>"When archiving for Mac, set this to true to package it in a .app bundle instead of normal loose files"
/// 
/// When archiving for Mac, set this to true to package it in a .app bundle instead of normal loose files
/// </summary>
        public virtual ProjectParamsConfig Createappbundle(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-createappbundle=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-createappbundle");
            return (ProjectParamsConfig) this;
        }

        
        
/// <summary>"True if build step should be executed"
/// 
/// Build: True if build step should be executed, command: -build
/// </summary>
        public virtual ProjectParamsConfig Build(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-build=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-build");
            return (ProjectParamsConfig) this;
        }

        
        
/// <summary>"True if XGE should NOT be used for building"
/// 
/// Build: True if XGE should NOT be used for building.
/// 
/// "Toggle to disable the distributed build process"</summary>
        public virtual ProjectParamsConfig Noxge(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-noxge=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-noxge");
            return (ProjectParamsConfig) this;
        }

        
        
/// <summary>"while cooking clean up packages as we are done with them rather then cleaning everything up when we run out of space"
/// 
/// Cook: While cooking clean up packages as we go along rather then cleaning everything (and potentially having to reload some of it) when we run out of space
/// </summary>
        public virtual ProjectParamsConfig CookPartialgc(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-CookPartialgc=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-CookPartialgc");
            return (ProjectParamsConfig) this;
        }

        
        
/// <summary>"Did we cook in the editor instead of in UAT"
/// 
/// Stage: Did we cook in the editor instead of from UAT (cook in editor uses a different staging directory)
/// </summary>
        public virtual ProjectParamsConfig CookInEditor(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-CookInEditor=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-CookInEditor");
            return (ProjectParamsConfig) this;
        }

        
        
/// <summary>"Uses the iterative cooking, command line: -iterativecooking or -iterate"
/// "Uses the iterative cooking, command line: -iterativedeploy or -iterate"
/// 
/// Cook: Uses the iterative cooking, command line: -iterativecooking or -iterate
/// </summary>
        public virtual ProjectParamsConfig Iterativecooking(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-iterativecooking=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-iterativecooking");
            return (ProjectParamsConfig) this;
        }

        
        
/// <summary>"Cook only maps this only affects usage of -cookall the flag"
/// 
/// Cook: Only cook maps (and referenced content) instead of cooking everything only affects -cookall flag
/// </summary>
        public virtual ProjectParamsConfig CookMapsOnly(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-CookMapsOnly=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-CookMapsOnly");
            return (ProjectParamsConfig) this;
        }

        
        
/// <summary>"Cook all the things in the content directory for this project"
/// 
/// Cook: Only cook maps (and referenced content) instead of cooking everything only affects cookall flag
/// </summary>
        public virtual ProjectParamsConfig CookAll(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-CookAll=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-CookAll");
            return (ProjectParamsConfig) this;
        }

        
        
/// <summary>"Skips content under /Engine/Editor when cooking"
/// 
/// Cook: Skip cooking editor content
/// </summary>
        public virtual ProjectParamsConfig SkipCookingEditorContent(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-SkipCookingEditorContent=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-SkipCookingEditorContent");
            return (ProjectParamsConfig) this;
        }

        
        
/// <summary>"Uses fast cook path if supported by target"</summary>
        public virtual ProjectParamsConfig FastCook(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-FastCook=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-FastCook");
            return (ProjectParamsConfig) this;
        }

        
        
/// <summary>"Ignores cook errors and continues with packaging etc"
/// 
/// Cook: Ignores cook errors and continues with packaging etc.
/// </summary>
        public virtual ProjectParamsConfig IgnoreCookErrors(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-IgnoreCookErrors=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-IgnoreCookErrors");
            return (ProjectParamsConfig) this;
        }

        
        
/// <summary>"do not copy debug files to the stage"
/// 
/// Stage: Commandline: -nodebuginfo
/// </summary>
        public virtual ProjectParamsConfig Nodebuginfo(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-nodebuginfo=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-nodebuginfo");
            return (ProjectParamsConfig) this;
        }

        
        
/// <summary>"output debug info to a separate directory"
/// 
/// Stage: Commandline: -separatedebuginfo
/// </summary>
        public virtual ProjectParamsConfig Separatedebuginfo(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-separatedebuginfo=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-separatedebuginfo");
            return (ProjectParamsConfig) this;
        }

        
        
/// <summary>"generates a *.map file"
/// 
/// Stage: Commandline: -mapfile
/// </summary>
        public virtual ProjectParamsConfig MapFile(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-MapFile=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-MapFile");
            return (ProjectParamsConfig) this;
        }

        
        
/// <summary>"skip cleaning the stage directory"
/// 
/// true if the staging directory is to be cleaned: -cleanstage (also true if -clean is specified)
/// </summary>
        public virtual ProjectParamsConfig Nocleanstage(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-nocleanstage=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-nocleanstage");
            return (ProjectParamsConfig) this;
        }

        
        
/// <summary>"command line to put into the stage in UE4CommandLine.txt"</summary>
        public virtual ProjectParamsConfig Cmdline(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-cmdline=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-cmdline");
            return (ProjectParamsConfig) this;
        }

        
        
/// <summary>"string to use as the bundle name when deploying to mobile device"
/// 
/// Stage: If non-empty, the contents will be used for the bundle name
/// </summary>
        public virtual ProjectParamsConfig Bundlename(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-bundlename=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-bundlename");
            return (ProjectParamsConfig) this;
        }

        
        
/// <summary>"run the game after it is built (including server, if -server)"
/// 
/// Run: True if the Run step should be executed, command: -run
/// </summary>
        public virtual ProjectParamsConfig Run(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-run=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-run");
            return (ProjectParamsConfig) this;
        }

        
        
/// <summary>"run the client with cooked data provided by cook on the fly server"
/// 
/// Run: The client runs with cooked data provided by cook on the fly server, command line: -cookonthefly
/// </summary>
        public virtual ProjectParamsConfig Cookonthefly(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-cookonthefly=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-cookonthefly");
            return (ProjectParamsConfig) this;
        }

        
        
/// <summary>"run the client in streaming cook on the fly mode (don't cache files locally instead force reget from server each file load)"
/// 
/// Run: The client should run in streaming mode when connecting to cook on the fly server
/// </summary>
        public virtual ProjectParamsConfig Cookontheflystreaming(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-Cookontheflystreaming=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-Cookontheflystreaming");
            return (ProjectParamsConfig) this;
        }

        
        
/// <summary>"run the client with cooked data provided by UnrealFileServer"
/// 
/// Run: The client runs with cooked data provided by UnrealFileServer, command line: -fileserver
/// </summary>
        public virtual ProjectParamsConfig Fileserver(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-fileserver=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-fileserver");
            return (ProjectParamsConfig) this;
        }

        
        
/// <summary>"build, cook and run both a client and a server (also -server)"
/// 
/// Run: The client connects to dedicated server to get data, command line: -dedicatedserver
/// </summary>
        public virtual ProjectParamsConfig Dedicatedserver(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-dedicatedserver=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-dedicatedserver");
            return (ProjectParamsConfig) this;
        }

        
        
/// <summary>"build, cook and run a client and a server, uses client target configuration"
/// 
/// Run: Uses a client target configuration, also implies -dedicatedserver, command line: -client
/// </summary>
        public virtual ProjectParamsConfig Client(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-client=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-client");
            return (ProjectParamsConfig) this;
        }

        
        
/// <summary>"do not run the client, just run the server"
/// 
/// Run: Whether the client should start or not, command line (to disable): -noclient
/// </summary>
        public virtual ProjectParamsConfig Noclient(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-noclient=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-noclient");
            return (ProjectParamsConfig) this;
        }

        
        
/// <summary>"create a log window for the client"
/// 
/// Run: Client should create its own log window, command line: -logwindow
/// </summary>
        public virtual ProjectParamsConfig Logwindow(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-logwindow=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-logwindow");
            return (ProjectParamsConfig) this;
        }

        
        
/// <summary>"map to run the game with"</summary>
        public virtual ProjectParamsConfig Map(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-map=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-map");
            return (ProjectParamsConfig) this;
        }

        
        
/// <summary>"Additional server map params, i.e ?param=value"
/// 
/// Run: Additional server map params.
/// </summary>
        public virtual ProjectParamsConfig AdditionalServerMapParams(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-AdditionalServerMapParams=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-AdditionalServerMapParams");
            return (ProjectParamsConfig) this;
        }

        
        
/// <summary>"Devices to run the game on"
/// "Device names without the platform prefix to run the game on"</summary>
        public virtual ProjectParamsConfig Device(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-device=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-device");
            return (ProjectParamsConfig) this;
        }

        
        
/// <summary>"Device to run the server on"
/// 
/// Run: the target device to run the server on
/// </summary>
        public virtual ProjectParamsConfig Serverdevice(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-serverdevice=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-serverdevice");
            return (ProjectParamsConfig) this;
        }

        
        
/// <summary>"Skip starting the server"
/// 
/// Run: The indicated server has already been started
/// </summary>
        public virtual ProjectParamsConfig Skipserver(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-skipserver=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-skipserver");
            return (ProjectParamsConfig) this;
        }

        
        
/// <summary>"Start extra clients, n should be 2 or more"
/// 
/// Run: The indicated server has already been started
/// </summary>
        public virtual ProjectParamsConfig Numclients(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-numclients=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-numclients");
            return (ProjectParamsConfig) this;
        }

        
        
/// <summary>"Additional command line arguments for the program"</summary>
        public virtual ProjectParamsConfig Addcmdline(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-addcmdline=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-addcmdline");
            return (ProjectParamsConfig) this;
        }

        
        
/// <summary>"Additional command line arguments for the program"</summary>
        public virtual ProjectParamsConfig Servercmdline(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-servercmdline=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-servercmdline");
            return (ProjectParamsConfig) this;
        }

        
        
/// <summary>"Override command line arguments to pass to the client"</summary>
        public virtual ProjectParamsConfig Clientcmdline(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-clientcmdline=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-clientcmdline");
            return (ProjectParamsConfig) this;
        }

        
        
/// <summary>"add -nullrhi to the client commandlines"
/// 
/// Run:adds -nullrhi to the client commandline
/// </summary>
        public virtual ProjectParamsConfig Nullrhi(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-nullrhi=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-nullrhi");
            return (ProjectParamsConfig) this;
        }

        
        
/// <summary>"adds ?fake to the server URL"
/// 
/// Run:adds ?fake to the server URL
/// </summary>
        public virtual ProjectParamsConfig Fakeclient(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-fakeclient=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-fakeclient");
            return (ProjectParamsConfig) this;
        }

        
        
/// <summary>"rather than running a client, run the editor instead"
/// 
/// Run:adds ?fake to the server URL
/// </summary>
        public virtual ProjectParamsConfig Editortest(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-editortest=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-editortest");
            return (ProjectParamsConfig) this;
        }

        
        
/// <summary>"when running -editortest or a client, run all automation tests, not compatible with -server"
/// "when running -editortest or a client, run a specific automation tests, not compatible with -server"
/// 
/// Run:when running -editortest or a client, run all automation tests, not compatible with -server
/// </summary>
        public virtual ProjectParamsConfig RunAutomationTests(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-RunAutomationTests=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-RunAutomationTests");
            return (ProjectParamsConfig) this;
        }

        
        
/// <summary>"when running -editortest or a client, adds commands like debug crash, debug rendercrash, etc based on index"</summary>
        public virtual ProjectParamsConfig Crash(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-Crash=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-Crash");
            return (ProjectParamsConfig) this;
        }

        
        
/// <summary>"Linux username for unattended key genereation"</summary>
        public virtual ProjectParamsConfig Deviceuser(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-deviceuser=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-deviceuser");
            return (ProjectParamsConfig) this;
        }

        
        
/// <summary>"Linux password"</summary>
        public virtual ProjectParamsConfig Devicepass(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-devicepass=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-devicepass");
            return (ProjectParamsConfig) this;
        }

        
        
/// <summary>"package the project for the target platform"
/// "Determine whether data is packaged. This can be an iteration optimization for platforms that require packages for deployment"</summary>
        public virtual ProjectParamsConfig Package(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-package=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-package");
            return (ProjectParamsConfig) this;
        }

        
        
/// <summary>"Skips packaging the project for the target platform"</summary>
        public virtual ProjectParamsConfig Skippackage(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-skippackage=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-skippackage");
            return (ProjectParamsConfig) this;
        }

        
        
/// <summary>"package for distribution the project"</summary>
        public virtual ProjectParamsConfig Distribution(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-distribution=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-distribution");
            return (ProjectParamsConfig) this;
        }

        
        
/// <summary>"stage prerequisites along with the project"</summary>
        public virtual ProjectParamsConfig Prereqs(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-prereqs=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-prereqs");
            return (ProjectParamsConfig) this;
        }

        
        
/// <summary>"location of prerequisites for applocal deployment"</summary>
        public virtual ProjectParamsConfig Applocaldir(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-applocaldir" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-applocaldir");
            return (ProjectParamsConfig) this;
        }

        
        
/// <summary>"this is a prebuilt cooked and packaged build"</summary>
        public virtual ProjectParamsConfig Prebuilt(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-Prebuilt=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-Prebuilt");
            return (ProjectParamsConfig) this;
        }

        
        
/// <summary>"timeout to wait after we lunch the game"</summary>
        public virtual ProjectParamsConfig RunTimeoutSeconds(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-RunTimeoutSeconds=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-RunTimeoutSeconds");
            return (ProjectParamsConfig) this;
        }

        
        
/// <summary>"Determine a specific Minimum OS"</summary>
        public virtual ProjectParamsConfig SpecifiedArchitecture(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-SpecifiedArchitecture=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-SpecifiedArchitecture");
            return (ProjectParamsConfig) this;
        }

        
        
/// <summary>"extra options to pass to ubt"</summary>
        public virtual ProjectParamsConfig UbtArgs(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-UbtArgs=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-UbtArgs");
            return (ProjectParamsConfig) this;
        }

        
        
/// <summary>"extra options to pass to the platform's packager"</summary>
        public virtual ProjectParamsConfig AdditionalPackageOptions(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-AdditionalPackageOptions=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-AdditionalPackageOptions");
            return (ProjectParamsConfig) this;
        }

        
        
/// <summary>"deploy the project for the target platform"
/// "Location to deploy to on the target platform"</summary>
        public virtual ProjectParamsConfig Deploy(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-deploy=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-deploy");
            return (ProjectParamsConfig) this;
        }

        
        
/// <summary>"download file from target after successful run"</summary>
        public virtual ProjectParamsConfig Getfile(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-getfile=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-getfile");
            return (ProjectParamsConfig) this;
        }

        
        
/// <summary>"List of maps that need light maps rebuilding"</summary>
        public virtual ProjectParamsConfig MapsToRebuildLightMaps(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-MapsToRebuildLightMaps=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-MapsToRebuildLightMaps");
            return (ProjectParamsConfig) this;
        }

        
        
/// <summary>"List of maps that need HLOD rebuilding"</summary>
        public virtual ProjectParamsConfig MapsToRebuildHLODMaps(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-MapsToRebuildHLODMaps=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-MapsToRebuildHLODMaps");
            return (ProjectParamsConfig) this;
        }

        
        
/// <summary>"Whether Light Map errors should be treated as critical"</summary>
        public virtual ProjectParamsConfig IgnoreLightMapErrors(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-IgnoreLightMapErrors" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-IgnoreLightMapErrors");
            return (ProjectParamsConfig) this;
        }

        
        
    
        public virtual ProjectParamsConfig Cookflavor(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-cookflavor=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-cookflavor");
            return (ProjectParamsConfig) this;
        }

        
        
    
        public virtual ProjectParamsConfig Ddc(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-ddc=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-ddc");
            return (ProjectParamsConfig) this;
        }

        
        
    
        public virtual ProjectParamsConfig I18npreset(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-i18npreset=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-i18npreset");
            return (ProjectParamsConfig) this;
        }

        
        
    
        public virtual ProjectParamsConfig CookCultures(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-CookCultures=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-CookCultures");
            return (ProjectParamsConfig) this;
        }

        
        
    
        public virtual ProjectParamsConfig Skipbuild(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-skipbuild=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-skipbuild");
            return (ProjectParamsConfig) this;
        }

        
        
/// <summary>
/// SkipBuildClient if true then don't build the client exe
/// </summary>
        public virtual ProjectParamsConfig SkipBuildClient(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-skipbuildclient=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-skipbuildclient");
            return (ProjectParamsConfig) this;
        }

        
        
/// <summary>
/// SkipBuildEditor if true then don't build the editor exe
/// </summary>
        public virtual ProjectParamsConfig SkipBuildEditor(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-skipbuildeditor=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-skipbuildeditor");
            return (ProjectParamsConfig) this;
        }

        
        
    
        public virtual ProjectParamsConfig Createreleaseversionroot(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-createreleaseversionroot=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-createreleaseversionroot");
            return (ProjectParamsConfig) this;
        }

        
        
    
        public virtual ProjectParamsConfig Basedonreleaseversionroot(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-basedonreleaseversionroot=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-basedonreleaseversionroot");
            return (ProjectParamsConfig) this;
        }

        
        
/// <summary>
/// The version of the originally released build. This is required by some platforms when generating patches.
/// </summary>
        public virtual ProjectParamsConfig OriginalReleaseVersion(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-originalreleaseversion=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-originalreleaseversion");
            return (ProjectParamsConfig) this;
        }

        
        
/// <summary>
/// Cook: Create a cooked release version.  Also, the version. e.g. 1.0
/// </summary>
        public virtual ProjectParamsConfig CreateReleaseVersion(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-createreleaseversion=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-createreleaseversion");
            return (ProjectParamsConfig) this;
        }

        
        
/// <summary>
/// Cook: Base this cook of a already released version of the cooked data
/// </summary>
        public virtual ProjectParamsConfig BasedOnReleaseVersion(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-basedonreleaseversion=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-basedonreleaseversion");
            return (ProjectParamsConfig) this;
        }

        
        
/// <summary>
/// Are we generating a patch, generate a patch from a previously released version of the game (use CreateReleaseVersion to create a release).
/// this requires BasedOnReleaseVersion
/// see also CreateReleaseVersion, BasedOnReleaseVersion
/// </summary>
        public virtual ProjectParamsConfig GeneratePatch(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-GeneratePatch=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-GeneratePatch");
            return (ProjectParamsConfig) this;
        }

        
        
/// <summary></summary>
        public virtual ProjectParamsConfig AddPatchLevel(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-AddPatchLevel=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-AddPatchLevel");
            return (ProjectParamsConfig) this;
        }

        
        
/// <summary>
/// Are we staging the unmodified pak files from the base release</summary>
        public virtual ProjectParamsConfig StageBaseReleasePaks(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-StageBaseReleasePaks=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-StageBaseReleasePaks");
            return (ProjectParamsConfig) this;
        }

        
        
/// <summary>
/// Required when building remaster package
/// </summary>
        public virtual ProjectParamsConfig DiscVersion(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-DiscVersion=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-DiscVersion");
            return (ProjectParamsConfig) this;
        }

        
        
/// <summary>
/// Cook: Additional cooker options to include on the cooker commandline
/// </summary>
        public virtual ProjectParamsConfig AdditionalCookerOptions(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-AdditionalCookerOptions=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-AdditionalCookerOptions");
            return (ProjectParamsConfig) this;
        }

        
        
    
        public virtual ProjectParamsConfig DLCName(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-DLCName=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-DLCName");
            return (ProjectParamsConfig) this;
        }

        
        
/// <summary>
/// After cook completes diff the cooked content against another cooked content directory.
/// report all errors to the log
/// </summary>
        public virtual ProjectParamsConfig DiffCookedContentPath(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-DiffCookedContentPath=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-DiffCookedContentPath");
            return (ProjectParamsConfig) this;
        }

        
        
/// <summary>
/// Enable cooking of engine content when cooking dlc
/// not included in original release but is referenced by current cook
/// </summary>
        public virtual ProjectParamsConfig DLCIncludeEngineContent(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-DLCIncludeEngineContent=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-DLCIncludeEngineContent");
            return (ProjectParamsConfig) this;
        }

        
        
/// <summary>
/// Enable packaging up the uplugin file inside the dlc pak.  This is sometimes desired if you want the plugin to be standalone
/// </summary>
        public virtual ProjectParamsConfig DLCPakPluginFile(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-DLCPakPluginFile=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-DLCPakPluginFile");
            return (ProjectParamsConfig) this;
        }

        
        
/// <summary>
/// DLC will remap it's files to the game directory and act like a patch.  This is useful if you want to override content in the main game along side your main game.
/// For example having different main game content in different DLCs
/// </summary>
        public virtual ProjectParamsConfig DLCActLikePatch(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-DLCActLikePatch=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-DLCActLikePatch");
            return (ProjectParamsConfig) this;
        }

        
        
/// <summary>
/// Shared: the game will use only signed content.
/// </summary>
        public virtual ProjectParamsConfig SignedPak(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-signedpak=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-signedpak");
            return (ProjectParamsConfig) this;
        }

        
        
/// <summary>
/// Stage: True if we should disable trying to re-use pak files from another staged build when we've specified a different cook source platform
/// </summary>
        public virtual ProjectParamsConfig IgnorePaksFromDifferentCookSource(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-IgnorePaksFromDifferentCookSource=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-IgnorePaksFromDifferentCookSource");
            return (ProjectParamsConfig) this;
        }

        
        
/// <summary>
/// Cook: Do not include a version number in the cooked content
/// </summary>
        public virtual ProjectParamsConfig UnversionedCookedContent(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-UnversionedCookedContent=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-UnversionedCookedContent");
            return (ProjectParamsConfig) this;
        }

        
        
/// <summary>
/// Cook: number of additional cookers to spawn while cooking
/// </summary>
        public virtual ProjectParamsConfig NumCookersToSpawn(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-NumCookersToSpawn=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-NumCookersToSpawn");
            return (ProjectParamsConfig) this;
        }

        
        
/// <summary>
/// Compress packages during cook.
/// </summary>
        public virtual ProjectParamsConfig Compressed(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-compressed=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-compressed");
            return (ProjectParamsConfig) this;
        }

        
        
/// <summary>
/// Do not compress packages during cook, override game ProjectPackagingSettings to force it off
/// </summary>
        public virtual ProjectParamsConfig ForceUncompressed(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-ForceUncompressed=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-ForceUncompressed");
            return (ProjectParamsConfig) this;
        }

        
        
/// <summary>
/// Additional parameters when generating the PAK file
/// </summary>
        public virtual ProjectParamsConfig AdditionalPakOptions(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-AdditionalPakOptions=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-AdditionalPakOptions");
            return (ProjectParamsConfig) this;
        }

        
        
/// <summary>
/// Additional parameters when generating iostore container files
/// </summary>
        public virtual ProjectParamsConfig AdditionalIoStoreOptions(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-AdditionalIoStoreOptions=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-AdditionalIoStoreOptions");
            return (ProjectParamsConfig) this;
        }

        
        
/// <summary>
/// Cook: Iterate from a build on the network
/// </summary>
        public virtual ProjectParamsConfig Iteratesharedcookedbuild(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-iteratesharedcookedbuild=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-iteratesharedcookedbuild");
            return (ProjectParamsConfig) this;
        }

        
        
/// <summary>
/// Build: Don't build the game instead use the prebuild exe (requires iterate shared cooked build
/// </summary>
        public virtual ProjectParamsConfig IterateSharedBuildUsePrecompiledExe(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-IterateSharedBuildUsePrecompiledExe=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-IterateSharedBuildUsePrecompiledExe");
            return (ProjectParamsConfig) this;
        }

        
        
/// <summary>
/// Cook: Output directory for cooked data
/// </summary>
        public virtual ProjectParamsConfig CookOutputDir(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-CookOutputDir=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-CookOutputDir");
            return (ProjectParamsConfig) this;
        }

        
        
    
        public virtual ProjectParamsConfig Target(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-target=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-target");
            return (ProjectParamsConfig) this;
        }

        
        
/// <summary>Stage: Specifies a list of extra targets that should be staged along with a client
/// </summary>
        public virtual ProjectParamsConfig ExtraTargetsToStageWithClient(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-ExtraTargetsToStageWithClient=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-ExtraTargetsToStageWithClient");
            return (ProjectParamsConfig) this;
        }

        
        
/// <summary>
/// By default we don't code sign unless it is required or requested
/// </summary>
        public virtual ProjectParamsConfig CodeSign(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-CodeSign=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-CodeSign");
            return (ProjectParamsConfig) this;
        }

        
        
/// <summary>
/// If true, non-shipping binaries will be considered DebugUFS files and will appear on the debugfiles manifest
/// </summary>
        public virtual ProjectParamsConfig TreatNonShippingBinariesAsDebugFiles(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-TreatNonShippingBinariesAsDebugFiles=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-TreatNonShippingBinariesAsDebugFiles");
            return (ProjectParamsConfig) this;
        }

        
        
/// <summary>
/// If true, use chunk manifest files generated for extra flavor
/// </summary>
        public virtual ProjectParamsConfig UseExtraFlavor(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-UseExtraFlavor=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-UseExtraFlavor");
            return (ProjectParamsConfig) this;
        }

        
        
/// <summary>
/// Shared: Directory to use for built chunk install data, command line: -chunkinstalldirectory=
/// </summary>
        public virtual ProjectParamsConfig ChunkInstallDirectory(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-chunkinstalldirectory=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-chunkinstalldirectory");
            return (ProjectParamsConfig) this;
        }

        
        
    
        public virtual ProjectParamsConfig Chunkinstallversion(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-chunkinstallversion=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-chunkinstallversion");
            return (ProjectParamsConfig) this;
        }

        
        
    
        public virtual ProjectParamsConfig Chunkinstallrelease(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-chunkinstallrelease=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-chunkinstallrelease");
            return (ProjectParamsConfig) this;
        }

        
        
    
        public virtual ProjectParamsConfig AppLocalDirectory(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-applocaldirectory=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-applocaldirectory");
            return (ProjectParamsConfig) this;
        }

        
        
/// <summary>
/// On Windows, adds an executable to the root of the staging directory which checks for prerequisites being
/// installed and launches the game with a path to the .uproject file.
/// </summary>
        public virtual ProjectParamsConfig NoBootstrapExe(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-nobootstrapexe=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-nobootstrapexe");
            return (ProjectParamsConfig) this;
        }

        
        
    
        public virtual ProjectParamsConfig ForcePackageData(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-forcepackagedata=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-forcepackagedata");
            return (ProjectParamsConfig) this;
        }

        
        
/// <summary>
/// Cook: Uses the iterative deploy, command line: -iterativedeploy or -iterate
/// </summary>
        public virtual ProjectParamsConfig IterativeDeploy(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-iterativedeploy=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-iterativedeploy");
            return (ProjectParamsConfig) this;
        }

        
        
/// <summary>
/// Provision to use
/// </summary>
        public virtual ProjectParamsConfig Provision(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-provision=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-provision");
            return (ProjectParamsConfig) this;
        }

        
        
/// <summary>
/// Certificate to use
/// </summary>
        public virtual ProjectParamsConfig Certificate(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-certificate=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-certificate");
            return (ProjectParamsConfig) this;
        }

        
        
/// <summary>
/// Team ID to use
/// </summary>
        public virtual ProjectParamsConfig Team(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-team=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-team");
            return (ProjectParamsConfig) this;
        }

        
        
/// <summary>
/// true if provisioning is automatically managed
/// </summary>
        public virtual ProjectParamsConfig AutomaticSigning(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-AutomaticSigning=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-AutomaticSigning");
            return (ProjectParamsConfig) this;
        }

        
        
/// <summary>
/// Run:when running -editortest or a client, run all automation tests, not compatible with -server
/// </summary>
        public virtual ProjectParamsConfig RunAutomationTest(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-RunAutomationTest=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-RunAutomationTest");
            return (ProjectParamsConfig) this;
        }

        
        
    
        public virtual ProjectParamsConfig Clientconfig(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-clientconfig=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-clientconfig");
            return (ProjectParamsConfig) this;
        }

        
        
    
        public virtual ProjectParamsConfig Config(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-config=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-config");
            return (ProjectParamsConfig) this;
        }

        
        
    
        public virtual ProjectParamsConfig Configuration(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-configuration=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-configuration");
            return (ProjectParamsConfig) this;
        }

        
        
    
        public virtual ProjectParamsConfig Port(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-port=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-port");
            return (ProjectParamsConfig) this;
        }

        
        
/// <summary>
/// Cook: List of maps to cook.
/// </summary>
        public virtual ProjectParamsConfig MapsToCook(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-MapsToCook=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-MapsToCook");
            return (ProjectParamsConfig) this;
        }

        
        
/// <summary>
/// Cook: List of map inisections to cook (see allmaps)
/// </summary>
        public virtual ProjectParamsConfig MapIniSectionsToCook(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-MapIniSectionsToCook=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-MapIniSectionsToCook");
            return (ProjectParamsConfig) this;
        }

        
        
/// <summary>
/// TitleID to package
/// </summary>
        public virtual ProjectParamsConfig TitleID(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-TitleID=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-TitleID");
            return (ProjectParamsConfig) this;
        }

        
        
    
        public virtual ProjectParamsConfig Serverconfig(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-serverconfig=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-serverconfig");
            return (ProjectParamsConfig) this;
        }

        
        
/// <summary>
/// Run: Adds commands like debug crash, debug rendercrash, etc based on index
/// </summary>
        public virtual ProjectParamsConfig CrashIndex(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-CrashIndex=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-CrashIndex");
            return (ProjectParamsConfig) this;
        }
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    
        public override string Gather()
        {
            return base.Gather();
        }
    }

    protected readonly ProjectParamsConfig ProjectParamsStorage = new();
        
    
    public  class UE4BuildConfig : ToolConfig
    {
        public override string Name => "UE4Build";
    
        
/// <summary>"Toggle to combined the result into one executable"</summary>
        public virtual UE4BuildConfig ForceMonolithic(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-ForceMonolithic" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-ForceMonolithic");
            return (UE4BuildConfig) this;
        }

        
        
/// <summary>"Forces debug info even in development builds"</summary>
        public virtual UE4BuildConfig ForceDebugInfo(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-ForceDebugInfo" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-ForceDebugInfo");
            return (UE4BuildConfig) this;
        }

        
        
/// <summary>"Toggle to disable the distributed build process"</summary>
        public virtual UE4BuildConfig NoXGE(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-NoXGE=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-NoXGE");
            return (UE4BuildConfig) this;
        }

        
        
/// <summary>"Toggle to disable the unity build system"</summary>
        public virtual UE4BuildConfig ForceNonUnity(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-ForceNonUnity" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-ForceNonUnity");
            return (UE4BuildConfig) this;
        }

        
        
/// <summary>"Toggle to force enable the unity build system"</summary>
        public virtual UE4BuildConfig ForceUnity(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-ForceUnity" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-ForceUnity");
            return (UE4BuildConfig) this;
        }

        
        
/// <summary>"If set, this build is being compiled by a licensee"</summary>
        public virtual UE4BuildConfig Licensee(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-Licensee=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-Licensee");
            return (UE4BuildConfig) this;
        }

        
        
    
        public virtual UE4BuildConfig Promoted(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-Promoted=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-Promoted");
            return (UE4BuildConfig) this;
        }

        
        
    
        public virtual UE4BuildConfig Branch(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-Branch=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-Branch");
            return (UE4BuildConfig) this;
        }

        
        
    
        public virtual UE4BuildConfig StopOnErrors(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-StopOnErrors=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-StopOnErrors");
            return (UE4BuildConfig) this;
        }

        
        
    
        public virtual UE4BuildConfig Clean(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-Clean=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-Clean");
            return (UE4BuildConfig) this;
        }
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    
        public override string Gather()
        {
            return base.Gather();
        }
    }

    protected readonly UE4BuildConfig UE4BuildStorage = new();
        
/// <summary>Builds the specified targets and configurations for the specified project.
/// Example BuildTarget -project=QAGame -target=Editor+Game -platform=PS4+XboxOne -configuration=Development.
/// Note: Editor will only ever build for the current platform in a Development config and required tools will be included</summary>
    public  class BuildTargetConfig : ToolConfig
    {
        public override string Name => "BuildTarget";
    
        
/// <summary>"Project to build. Will search current path and paths in ueprojectdirs. If omitted will build vanilla UE4Editor"</summary>
        public virtual BuildTargetConfig Project(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-project=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-project");
            return (BuildTargetConfig) this;
        }

        
        
/// <summary>"Platforms to build, join multiple platforms using +"
/// 
/// Platform to build
/// </summary>
        public virtual BuildTargetConfig Platform(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-platform=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-platform");
            return (BuildTargetConfig) this;
        }

        
        
/// <summary>"Configurations to build, join multiple configurations using +"</summary>
        public virtual BuildTargetConfig Configuration(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-configuration=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-configuration");
            return (BuildTargetConfig) this;
        }

        
        
/// <summary>"Targets to build, join multiple targets using +"</summary>
        public virtual BuildTargetConfig Target(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-target=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-target");
            return (BuildTargetConfig) this;
        }

        
        
/// <summary>"Don't build any tools (UnrealPak, Lightmass, ShaderCompiler, CrashReporter"</summary>
        public virtual BuildTargetConfig Notools(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-notools=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-notools");
            return (BuildTargetConfig) this;
        }

        
        
/// <summary>"Do a clean build"
/// 
/// Whether to clean this target. If not specified, the target will be cleaned if -Clean is on the command line.
/// </summary>
        public virtual BuildTargetConfig Clean(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-clean=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-clean");
            return (BuildTargetConfig) this;
        }

        
        
/// <summary>"Toggle to disable the distributed build process"</summary>
        public virtual BuildTargetConfig NoXGE(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-NoXGE" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-NoXGE");
            return (BuildTargetConfig) this;
        }

        
        
/// <summary>"Toggle to disable the unity build system"</summary>
        public virtual BuildTargetConfig DisableUnity(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-DisableUnity" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-DisableUnity");
            return (BuildTargetConfig) this;
        }

        
        
/// <summary>
/// Extra UBT args
/// </summary>
        public virtual BuildTargetConfig UBTArgs(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-ubtargs=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-ubtargs");
            return (BuildTargetConfig) this;
        }

        
        
    
        public virtual BuildTargetConfig Preview(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-preview=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-preview");
            return (BuildTargetConfig) this;
        }
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    
        public override string Gather()
        {
            Arguments.Insert(0, "BuildTarget");return base.Gather();
        }
    }

    protected readonly BuildTargetConfig BuildTargetStorage = new();
        
/// <summary>Tool for creating extensible build processes in UE4 which can be run locally or in parallel across a build farm.</summary>
    public  class BuildGraphConfig : ToolConfig
    {
        public override string Name => "BuildGraph";
    
        
/// <summary>"Path to the script describing the graph"</summary>
        public virtual BuildGraphConfig Script(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-Script=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-Script");
            return (BuildGraphConfig) this;
        }

        
        
/// <summary>"Name of the node or output tag to be built"</summary>
        public virtual BuildGraphConfig Target(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-Target=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-Target");
            return (BuildGraphConfig) this;
        }

        
        
/// <summary>"Generates a schema to the default location"
/// "Generate a schema describing valid script documents, including all the known tasks"</summary>
        public virtual BuildGraphConfig Schema(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-Schema=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-Schema");
            return (BuildGraphConfig) this;
        }

        
        
/// <summary>"Imports a schema from an existing schema file"</summary>
        public virtual BuildGraphConfig ImportSchema(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-ImportSchema=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-ImportSchema");
            return (BuildGraphConfig) this;
        }

        
        
/// <summary>"Sets a named property to the given value"</summary>
        public virtual BuildGraphConfig Set(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-Set:" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-Set");
            return (BuildGraphConfig) this;
        }

        
        
/// <summary>"Cleans all cached state of completed build nodes before running"</summary>
        public virtual BuildGraphConfig Clean(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-Clean" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-Clean");
            return (BuildGraphConfig) this;
        }

        
        
/// <summary>"Cleans just the given nodes before running"</summary>
        public virtual BuildGraphConfig CleanNode(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-CleanNode=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-CleanNode");
            return (BuildGraphConfig) this;
        }

        
        
/// <summary>"Resumes a local build from the last node that completed successfully"</summary>
        public virtual BuildGraphConfig Resume(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-Resume=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-Resume");
            return (BuildGraphConfig) this;
        }

        
        
/// <summary>"Shows the contents of the preprocessed graph, but does not execute it"</summary>
        public virtual BuildGraphConfig ListOnly(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-ListOnly=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-ListOnly");
            return (BuildGraphConfig) this;
        }

        
        
/// <summary>"When running with -ListOnly, causes diagnostic messages entered when parsing the graph to be shown"</summary>
        public virtual BuildGraphConfig ShowDiagnostics(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-ShowDiagnostics=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-ShowDiagnostics");
            return (BuildGraphConfig) this;
        }

        
        
/// <summary>"Show node dependencies in the graph output"</summary>
        public virtual BuildGraphConfig ShowDeps(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-ShowDeps=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-ShowDeps");
            return (BuildGraphConfig) this;
        }

        
        
/// <summary>"Show notifications that will be sent for each node in the output"</summary>
        public virtual BuildGraphConfig ShowNotifications(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-ShowNotifications=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-ShowNotifications");
            return (BuildGraphConfig) this;
        }

        
        
/// <summary>"Executes only nodes behind the given trigger"</summary>
        public virtual BuildGraphConfig Trigger(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-Trigger=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-Trigger");
            return (BuildGraphConfig) this;
        }

        
        
/// <summary>"Skips the given triggers, including all the nodes behind them in the graph"</summary>
        public virtual BuildGraphConfig SkipTrigger(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-SkipTrigger=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-SkipTrigger");
            return (BuildGraphConfig) this;
        }

        
        
/// <summary>"Skips all triggers"</summary>
        public virtual BuildGraphConfig SkipTriggers(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-SkipTriggers=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-SkipTriggers");
            return (BuildGraphConfig) this;
        }

        
        
/// <summary>"Specifies the signature identifying the current job, to be written to tokens for nodes that require them. Tokens are ignored if this parameter is not specified."</summary>
        public virtual BuildGraphConfig TokenSignature(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-TokenSignature=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-TokenSignature");
            return (BuildGraphConfig) this;
        }

        
        
/// <summary>"Excludes targets which we can't acquire tokens for, rather than failing"</summary>
        public virtual BuildGraphConfig SkipTargetsWithoutTokens(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-SkipTargetsWithoutTokens=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-SkipTargetsWithoutTokens");
            return (BuildGraphConfig) this;
        }

        
        
/// <summary>"Writes the preprocessed graph to the given file"</summary>
        public virtual BuildGraphConfig Preprocess(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-Preprocess=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-Preprocess");
            return (BuildGraphConfig) this;
        }

        
        
/// <summary>"Exports a JSON file containing the preprocessed build graph, for use as part of a build system"</summary>
        public virtual BuildGraphConfig Export(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-Export=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-Export");
            return (BuildGraphConfig) this;
        }

        
        
/// <summary>"Exports a JSON file containing the full build graph for use by Horde."</summary>
        public virtual BuildGraphConfig HordeExport(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-HordeExport=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-HordeExport");
            return (BuildGraphConfig) this;
        }

        
        
/// <summary>"Only include built-in tasks in the schema, excluding any other UAT modules"</summary>
        public virtual BuildGraphConfig PublicTasksOnly(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-PublicTasksOnly=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-PublicTasksOnly");
            return (BuildGraphConfig) this;
        }

        
        
/// <summary>"Sets the directory to use to transfer build products between agents in a build farm"</summary>
        public virtual BuildGraphConfig SharedStorageDir(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-SharedStorageDir=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-SharedStorageDir");
            return (BuildGraphConfig) this;
        }

        
        
/// <summary>"Run only the given node. Intended for use on a build system after running with -Export."</summary>
        public virtual BuildGraphConfig SingleNode(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-SingleNode=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-SingleNode");
            return (BuildGraphConfig) this;
        }

        
        
/// <summary>"Allow writing to shared storage. If not set, but -SharedStorageDir is specified, build products will read but not written"</summary>
        public virtual BuildGraphConfig WriteToSharedStorage(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-WriteToSharedStorage=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-WriteToSharedStorage");
            return (BuildGraphConfig) this;
        }

        
        
    
        public virtual BuildGraphConfig Documentation(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-Documentation=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-Documentation");
            return (BuildGraphConfig) this;
        }

        
        
    
        public virtual BuildGraphConfig ReportName(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-ReportName=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-ReportName");
            return (BuildGraphConfig) this;
        }
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    
        public override string Gather()
        {
            Arguments.Insert(0, "BuildGraph");return base.Gather();
        }
    }

    protected readonly BuildGraphConfig BuildGraphStorage = new();
        
    
    public  class BuildConfig : ToolConfig
    {
        public override string Name => "Build";
    
        
/// <summary>"Path to the script describing the graph"</summary>
        public virtual BuildConfig Script(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-Script=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-Script");
            return (BuildConfig) this;
        }

        
        
/// <summary>"Name of the node or output tag to be built"</summary>
        public virtual BuildConfig Target(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-Target=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-Target");
            return (BuildConfig) this;
        }

        
        
/// <summary>"Generates a schema to the default location"
/// "Generate a schema describing valid script documents, including all the known tasks"</summary>
        public virtual BuildConfig Schema(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-Schema=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-Schema");
            return (BuildConfig) this;
        }

        
        
/// <summary>"Imports a schema from an existing schema file"</summary>
        public virtual BuildConfig ImportSchema(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-ImportSchema=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-ImportSchema");
            return (BuildConfig) this;
        }

        
        
/// <summary>"Sets a named property to the given value"</summary>
        public virtual BuildConfig Set(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-Set:" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-Set");
            return (BuildConfig) this;
        }

        
        
/// <summary>"Cleans all cached state of completed build nodes before running"</summary>
        public virtual BuildConfig Clean(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-Clean" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-Clean");
            return (BuildConfig) this;
        }

        
        
/// <summary>"Cleans just the given nodes before running"</summary>
        public virtual BuildConfig CleanNode(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-CleanNode=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-CleanNode");
            return (BuildConfig) this;
        }

        
        
/// <summary>"Resumes a local build from the last node that completed successfully"</summary>
        public virtual BuildConfig Resume(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-Resume=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-Resume");
            return (BuildConfig) this;
        }

        
        
/// <summary>"Shows the contents of the preprocessed graph, but does not execute it"</summary>
        public virtual BuildConfig ListOnly(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-ListOnly=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-ListOnly");
            return (BuildConfig) this;
        }

        
        
/// <summary>"When running with -ListOnly, causes diagnostic messages entered when parsing the graph to be shown"</summary>
        public virtual BuildConfig ShowDiagnostics(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-ShowDiagnostics=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-ShowDiagnostics");
            return (BuildConfig) this;
        }

        
        
/// <summary>"Show node dependencies in the graph output"</summary>
        public virtual BuildConfig ShowDeps(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-ShowDeps=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-ShowDeps");
            return (BuildConfig) this;
        }

        
        
/// <summary>"Show notifications that will be sent for each node in the output"</summary>
        public virtual BuildConfig ShowNotifications(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-ShowNotifications=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-ShowNotifications");
            return (BuildConfig) this;
        }

        
        
/// <summary>"Executes only nodes behind the given trigger"</summary>
        public virtual BuildConfig Trigger(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-Trigger=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-Trigger");
            return (BuildConfig) this;
        }

        
        
/// <summary>"Skips the given triggers, including all the nodes behind them in the graph"</summary>
        public virtual BuildConfig SkipTrigger(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-SkipTrigger=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-SkipTrigger");
            return (BuildConfig) this;
        }

        
        
/// <summary>"Skips all triggers"</summary>
        public virtual BuildConfig SkipTriggers(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-SkipTriggers=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-SkipTriggers");
            return (BuildConfig) this;
        }

        
        
/// <summary>"Specifies the signature identifying the current job, to be written to tokens for nodes that require them. Tokens are ignored if this parameter is not specified."</summary>
        public virtual BuildConfig TokenSignature(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-TokenSignature=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-TokenSignature");
            return (BuildConfig) this;
        }

        
        
/// <summary>"Excludes targets which we can't acquire tokens for, rather than failing"</summary>
        public virtual BuildConfig SkipTargetsWithoutTokens(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-SkipTargetsWithoutTokens=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-SkipTargetsWithoutTokens");
            return (BuildConfig) this;
        }

        
        
/// <summary>"Writes the preprocessed graph to the given file"</summary>
        public virtual BuildConfig Preprocess(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-Preprocess=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-Preprocess");
            return (BuildConfig) this;
        }

        
        
/// <summary>"Exports a JSON file containing the preprocessed build graph, for use as part of a build system"</summary>
        public virtual BuildConfig Export(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-Export=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-Export");
            return (BuildConfig) this;
        }

        
        
/// <summary>"Exports a JSON file containing the full build graph for use by Horde."</summary>
        public virtual BuildConfig HordeExport(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-HordeExport=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-HordeExport");
            return (BuildConfig) this;
        }

        
        
/// <summary>"Only include built-in tasks in the schema, excluding any other UAT modules"</summary>
        public virtual BuildConfig PublicTasksOnly(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-PublicTasksOnly=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-PublicTasksOnly");
            return (BuildConfig) this;
        }

        
        
/// <summary>"Sets the directory to use to transfer build products between agents in a build farm"</summary>
        public virtual BuildConfig SharedStorageDir(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-SharedStorageDir=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-SharedStorageDir");
            return (BuildConfig) this;
        }

        
        
/// <summary>"Run only the given node. Intended for use on a build system after running with -Export."</summary>
        public virtual BuildConfig SingleNode(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-SingleNode=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-SingleNode");
            return (BuildConfig) this;
        }

        
        
/// <summary>"Allow writing to shared storage. If not set, but -SharedStorageDir is specified, build products will read but not written"</summary>
        public virtual BuildConfig WriteToSharedStorage(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-WriteToSharedStorage=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-WriteToSharedStorage");
            return (BuildConfig) this;
        }

        
        
    
        public virtual BuildConfig Documentation(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-Documentation=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-Documentation");
            return (BuildConfig) this;
        }

        
        
    
        public virtual BuildConfig ReportName(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-ReportName=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-ReportName");
            return (BuildConfig) this;
        }
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    
        public override string Gather()
        {
            Arguments.Insert(0, "Build");return base.Gather();
        }
    }

    protected readonly BuildConfig BuildStorage = new();
        
    
    public  class TempStorageTestsConfig : ToolConfig
    {
        public override string Name => "TempStorageTests";
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    
        public override string Gather()
        {
            Arguments.Insert(0, "TempStorageTests");return base.Gather();
        }
    }

    protected readonly TempStorageTestsConfig TempStorageTestsStorage = new();
        
/// <summary>Removes folders in a given temp storage directory that are older than a certain time.</summary>
    public  class CleanTempStorageConfig : ToolConfig
    {
        public override string Name => "CleanTempStorage";
    
        
/// <summary>"Path to the root temp storage directory"</summary>
        public virtual CleanTempStorageConfig TempStorageDir(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-TempStorageDir=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-TempStorageDir");
            return (CleanTempStorageConfig) this;
        }

        
        
/// <summary>"Number of days to keep in temp storage"</summary>
        public virtual CleanTempStorageConfig Days(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-Days=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-Days");
            return (CleanTempStorageConfig) this;
        }
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    
        public override string Gather()
        {
            Arguments.Insert(0, "CleanTempStorage");return base.Gather();
        }
    }

    protected readonly CleanTempStorageConfig CleanTempStorageStorage = new();
        
    
    public  class TestGauntletConfig : ToolConfig
    {
        public override string Name => "TestGauntlet";
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    
        public override string Gather()
        {
            Arguments.Insert(0, "TestGauntlet");return base.Gather();
        }
    }

    protected readonly TestGauntletConfig TestGauntletStorage = new();
        
    
    public  class RunUnrealConfig : ToolConfig
    {
        public override string Name => "RunUnreal";
    
        
    
        public virtual RunUnrealConfig Log(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-log=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-log");
            return (RunUnrealConfig) this;
        }

        
        
    
        public virtual RunUnrealConfig Editor(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-editor=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-editor");
            return (RunUnrealConfig) this;
        }

        
        
    
        public virtual RunUnrealConfig Skip(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-Skip=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-Skip");
            return (RunUnrealConfig) this;
        }

        
        
    
        public virtual RunUnrealConfig Removedevices(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-removedevices=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-removedevices");
            return (RunUnrealConfig) this;
        }

        
        
    
        public virtual RunUnrealConfig Clean(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-clean=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-clean");
            return (RunUnrealConfig) this;
        }

        
        
    
        public virtual RunUnrealConfig Listargs(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-listargs=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-listargs");
            return (RunUnrealConfig) this;
        }

        
        
    
        public virtual RunUnrealConfig Listallargs(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-listallargs=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-listallargs");
            return (RunUnrealConfig) this;
        }
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    
        public override string Gather()
        {
            Arguments.Insert(0, "RunUnreal");return base.Gather();
        }
    }

    protected readonly RunUnrealConfig RunUnrealStorage = new();
        
/// <summary>@"Creates an IPA from an xarchive file"</summary>
    public  class ExportIPAFromArchiveConfig : ToolConfig
    {
        public override string Name => "ExportIPAFromArchive";
    
        
/// <summary>@"Purpose of the IPA. (Development, Adhoc, Store)"</summary>
        public virtual ExportIPAFromArchiveConfig Method(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-method=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-method");
            return (ExportIPAFromArchiveConfig) this;
        }

        
        
/// <summary>@"Path to plist template that will be filled in based on other arguments. See ExportOptions.plist.template for an example"</summary>
        public virtual ExportIPAFromArchiveConfig TemplateFile(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-TemplateFile=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-TemplateFile");
            return (ExportIPAFromArchiveConfig) this;
        }

        
        
/// <summary>@"Path to an XML file of options that we'll select from based on method. See ExportOptions.Values.xml for an example"</summary>
        public virtual ExportIPAFromArchiveConfig OptionsFile(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-OptionsFile=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-OptionsFile");
            return (ExportIPAFromArchiveConfig) this;
        }

        
        
/// <summary>@"Name of this project (e.g ShooterGame, EngineTest)"</summary>
        public virtual ExportIPAFromArchiveConfig Project(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-Project=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-Project");
            return (ExportIPAFromArchiveConfig) this;
        }

        
        
    
        public virtual ExportIPAFromArchiveConfig Archive(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-archive=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-archive");
            return (ExportIPAFromArchiveConfig) this;
        }

        
        
    
        public virtual ExportIPAFromArchiveConfig Output(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-output=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-output");
            return (ExportIPAFromArchiveConfig) this;
        }
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    
        public override string Gather()
        {
            Arguments.Insert(0, "ExportIPAFromArchive");return base.Gather();
        }
    }

    protected readonly ExportIPAFromArchiveConfig ExportIPAFromArchiveStorage = new();
        
/// <summary>@"Creates an IPA from an xarchive file"</summary>
    public  class MakeIPAConfig : ToolConfig
    {
        public override string Name => "MakeIPA";
    
        
/// <summary>@"Purpose of the IPA. (Development, Adhoc, Store)"</summary>
        public virtual MakeIPAConfig Method(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-method=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-method");
            return (MakeIPAConfig) this;
        }

        
        
/// <summary>@"Path to plist template that will be filled in based on other arguments. See ExportOptions.plist.template for an example"</summary>
        public virtual MakeIPAConfig TemplateFile(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-TemplateFile=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-TemplateFile");
            return (MakeIPAConfig) this;
        }

        
        
/// <summary>@"Path to an XML file of options that we'll select from based on method. See ExportOptions.Values.xml for an example"</summary>
        public virtual MakeIPAConfig OptionsFile(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-OptionsFile=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-OptionsFile");
            return (MakeIPAConfig) this;
        }

        
        
/// <summary>@"Name of this project (e.g ShooterGame, EngineTest)"</summary>
        public virtual MakeIPAConfig Project(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-Project=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-Project");
            return (MakeIPAConfig) this;
        }

        
        
    
        public virtual MakeIPAConfig Archive(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-archive=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-archive");
            return (MakeIPAConfig) this;
        }

        
        
    
        public virtual MakeIPAConfig Output(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-output=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-output");
            return (MakeIPAConfig) this;
        }
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    
        public override string Gather()
        {
            Arguments.Insert(0, "MakeIPA");return base.Gather();
        }
    }

    protected readonly MakeIPAConfig MakeIPAStorage = new();
        
/// <summary>@"Pulls a value from an ini file and inserts it into a plist."
/// @"Note currently only looks at values irrespective of sections!"</summary>
    public  class WriteIniValueToPlistConfig : ToolConfig
    {
        public override string Name => "WriteIniValueToPlist";
    
        
/// <summary>@"Path to ini file to read from"
/// 
/// Path to the ini file to be read
/// </summary>
        public virtual WriteIniValueToPlistConfig IniFile(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-IniFile=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-IniFile");
            return (WriteIniValueToPlistConfig) this;
        }

        
        
/// <summary>@"Name of the ini property to read. E.g. 'Version' for 'Version=12.0'"
/// 
/// Ini property to read
/// </summary>
        public virtual WriteIniValueToPlistConfig IniProperty(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-IniProperty=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-IniProperty");
            return (WriteIniValueToPlistConfig) this;
        }

        
        
/// <summary>@"Path to plist file to update"
/// 
/// Path to the plist file to be updated
/// </summary>
        public virtual WriteIniValueToPlistConfig PlistFile(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-PlistFile=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-PlistFile");
            return (WriteIniValueToPlistConfig) this;
        }

        
        
/// <summary>@"Plist property to update. E.g. CFBundleShortVersionString"
/// 
/// Plist property to update
/// </summary>
        public virtual WriteIniValueToPlistConfig PlistProperty(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-PlistProperty=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-PlistProperty");
            return (WriteIniValueToPlistConfig) this;
        }
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    
        public override string Gather()
        {
            Arguments.Insert(0, "WriteIniValueToPlist");return base.Gather();
        }
    }

    protected readonly WriteIniValueToPlistConfig WriteIniValueToPlistStorage = new();
        
    
    public  class OneSkyLocalizationProviderConfig : ToolConfig
    {
        public override string Name => "OneSkyLocalizationProvider";
    
        
/// <summary>"Name of the config data to use (see OneSkyConfigHelper)."</summary>
        public virtual OneSkyLocalizationProviderConfig OneSkyConfigName(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-OneSkyConfigName=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-OneSkyConfigName");
            return (OneSkyLocalizationProviderConfig) this;
        }

        
        
/// <summary>"Name of the project group in OneSky."</summary>
        public virtual OneSkyLocalizationProviderConfig OneSkyProjectGroupName(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-OneSkyProjectGroupName=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-OneSkyProjectGroupName");
            return (OneSkyLocalizationProviderConfig) this;
        }
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    
        public override string Gather()
        {
            return base.Gather();
        }
    }

    protected readonly OneSkyLocalizationProviderConfig OneSkyLocalizationProviderStorage = new();
        
/// <summary>Analyzes third party libraries</summary>
    public  class AnalyzeThirdPartyLibsConfig : ToolConfig
    {
        public override string Name => "AnalyzeThirdPartyLibs";
    
        
/// <summary>"[Optional] + separated list of libraries to compile; if not specified this job will build all libraries it can find builder scripts for"</summary>
        public virtual AnalyzeThirdPartyLibsConfig Libs(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-Libs=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-Libs");
            return (AnalyzeThirdPartyLibsConfig) this;
        }

        
        
/// <summary>"[Optional] a changelist to check out into; if not specified, a changelist will be created"</summary>
        public virtual AnalyzeThirdPartyLibsConfig Changelist(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-Changelist" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-Changelist");
            return (AnalyzeThirdPartyLibsConfig) this;
        }
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    
        public override string Gather()
        {
            Arguments.Insert(0, "AnalyzeThirdPartyLibs");return base.Gather();
        }
    }

    protected readonly AnalyzeThirdPartyLibsConfig AnalyzeThirdPartyLibsStorage = new();
        
/// <summary>BlameKeyword command. Looks for the specified keywords in all files at the specified path and finds who added them based on P4 history</summary>
/// <remarks>WARNING: This command might require Perforce</remarks>
    public  class BlameKeywordConfig : ToolConfig
    {
        public override string Name => "BlameKeyword";
    
        
/// <summary>"Local path to search (including subfolders)"</summary>
        public virtual BlameKeywordConfig Path(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-Path=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-Path");
            return (BlameKeywordConfig) this;
        }

        
        
/// <summary>"Comma separated list of keywords to search for"</summary>
        public virtual BlameKeywordConfig Keywords(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-Keywords=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-Keywords");
            return (BlameKeywordConfig) this;
        }

        
        
/// <summary>"(Optional) If specified, uses full revision history (slow)"</summary>
        public virtual BlameKeywordConfig Timelapse(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-Timelapse=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-Timelapse");
            return (BlameKeywordConfig) this;
        }

        
        
    
        public virtual BlameKeywordConfig Out(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-Out=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-Out");
            return (BlameKeywordConfig) this;
        }
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    
        public override string Gather()
        {
            Arguments.Insert(0, "BlameKeyword");return base.Gather();
        }
    }

    protected readonly BlameKeywordConfig BlameKeywordStorage = new();
        
    
    public  class XcodeTargetPlatform_IOSConfig : ToolConfig
    {
        public override string Name => "XcodeTargetPlatform_IOS";
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    
        public override string Gather()
        {
            Arguments.Insert(0, "XcodeTargetPlatform_IOS");return base.Gather();
        }
    }

    protected readonly XcodeTargetPlatform_IOSConfig XcodeTargetPlatform_IOSStorage = new();
        
    
    public  class MakefileTargetPlatform_IOSConfig : ToolConfig
    {
        public override string Name => "MakefileTargetPlatform_IOS";
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    
        public override string Gather()
        {
            Arguments.Insert(0, "MakefileTargetPlatform_IOS");return base.Gather();
        }
    }

    protected readonly MakefileTargetPlatform_IOSConfig MakefileTargetPlatform_IOSStorage = new();
        
/// <summary>Builds common tools used by the engine which are not part of typical editor or game builds. Useful when syncing source-only on GitHub.</summary>
    public  class BuildCommonToolsConfig : ToolConfig
    {
        public override string Name => "BuildCommonTools";
    
        
/// <summary>"Specifies on or more platforms to build for (defaults to the current host platform)"</summary>
        public virtual BuildCommonToolsConfig Platforms(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-platforms=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-platforms");
            return (BuildCommonToolsConfig) this;
        }

        
        
/// <summary>"Writes a manifest of all the build products to the given path"</summary>
        public virtual BuildCommonToolsConfig Manifest(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-manifest=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-manifest");
            return (BuildCommonToolsConfig) this;
        }

        
        
    
        public virtual BuildCommonToolsConfig Allplatforms(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-allplatforms=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-allplatforms");
            return (BuildCommonToolsConfig) this;
        }
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    
        public override string Gather()
        {
            Arguments.Insert(0, "BuildCommonTools");return base.Gather();
        }
    }

    protected readonly BuildCommonToolsConfig BuildCommonToolsStorage = new();
        
    
    public  class ZipProjectUpConfig : ToolConfig
    {
        public override string Name => "ZipProjectUp";
    
        
    
        public virtual ZipProjectUpConfig Project(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-project=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-project");
            return (ZipProjectUpConfig) this;
        }

        
        
    
        public virtual ZipProjectUpConfig Install(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-install=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-install");
            return (ZipProjectUpConfig) this;
        }
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    
        public override string Gather()
        {
            Arguments.Insert(0, "ZipProjectUp");return base.Gather();
        }
    }

    protected readonly ZipProjectUpConfig ZipProjectUpStorage = new();
        
/// <summary>@"Builds/Cooks/Runs a project.
/// 
/// For non-uprojects project targets are discovered by compiling target rule files found in the project folder.
/// If -map is not specified, the command looks for DefaultMap entry in the project's DefaultEngine.ini and if not found, in BaseEngine.ini.
/// If no DefaultMap can be found, the command falls back to /Engine/Maps/Entry."</summary>
    public  class BuildCookRunConfig : ToolConfig
    {
        public override string Name => "BuildCookRun";
    
        
/// <summary>@"Project path (required), i.e: -project=QAGame, -project=Samples\BlackJack\BlackJack.uproject, -project=D:\Projects\MyProject.uproject"</summary>
        public virtual BuildCookRunConfig Project(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-project=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-project");
            return (BuildCookRunConfig) this;
        }

        
        
/// <summary>"Destination Sample name"</summary>
        public virtual BuildCookRunConfig Destsample(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-destsample=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-destsample");
            return (BuildCookRunConfig) this;
        }

        
        
/// <summary>"Foreign Destination"</summary>
        public virtual BuildCookRunConfig Foreigndest(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-foreigndest=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-foreigndest");
            return (BuildCookRunConfig) this;
        }

        
        
/// <summary>"Generate a foreign uproject from blankproject and use that"
/// 
/// Shared: The current project is a foreign project, commandline: -foreign
/// </summary>
        public virtual BuildCookRunConfig Foreign(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-foreign=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-foreign");
            return (BuildCookRunConfig) this;
        }

        
        
/// <summary>"Generate a foreign code uproject from platformergame and use that"
/// 
/// Shared: The current project is a foreign project, commandline: -foreign
/// </summary>
        public virtual BuildCookRunConfig Foreigncode(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-foreigncode=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-foreigncode");
            return (BuildCookRunConfig) this;
        }

        
        
    
        public virtual BuildCookRunConfig Cookdir(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-cookdir=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-cookdir");
            return (BuildCookRunConfig) this;
        }

        
        
    
        public virtual BuildCookRunConfig Ddc(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-ddc=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-ddc");
            return (BuildCookRunConfig) this;
        }

        
        
    
        public virtual BuildCookRunConfig I18npreset(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-i18npreset=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-i18npreset");
            return (BuildCookRunConfig) this;
        }

        
        
    
        public virtual BuildCookRunConfig Cookcultures(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-cookcultures=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-cookcultures");
            return (BuildCookRunConfig) this;
        }

        
        
/// <summary>"target platform for building, cooking and deployment (also -Platform)"</summary>
        public virtual BuildCookRunConfig Targetplatform(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-targetplatform=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-targetplatform");
            return (BuildCookRunConfig) this;
        }

        
        
/// <summary>"target platform for building, cooking and deployment of the dedicated server (also -ServerPlatform)"</summary>
        public virtual BuildCookRunConfig Servertargetplatform(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-servertargetplatform=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-servertargetplatform");
            return (BuildCookRunConfig) this;
        }

        
        
/// <summary>"true if we should build crash reporter"
/// 
/// Shared: true if we should build crash reporter
/// </summary>
        public virtual BuildCookRunConfig CrashReporter(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-CrashReporter=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-CrashReporter");
            return (BuildCookRunConfig) this;
        }

        
        
/// <summary>"Determines if the build is going to use cooked data"
/// 
/// Shared: Determines if the build is going to use cooked data, commandline: -cook, -cookonthefly
/// </summary>
        public virtual BuildCookRunConfig Cook(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-cook=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-cook");
            return (BuildCookRunConfig) this;
        }

        
        
/// <summary>"use a cooked build, but we assume the cooked data is up to date and where it belongs, implies -cook"
/// 
/// Shared: Determines if the build is going to use cooked data, commandline: -cook, -cookonthefly
/// </summary>
        public virtual BuildCookRunConfig Skipcook(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-skipcook=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-skipcook");
            return (BuildCookRunConfig) this;
        }

        
        
/// <summary>"in a cookonthefly build, used solely to pass information to the package step"
/// 
/// Shared: In a cookonthefly build, used solely to pass information to the package step. This is necessary because you can't set cookonthefly and cook at the same time, and skipcook sets cook.
/// </summary>
        public virtual BuildCookRunConfig Skipcookonthefly(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-skipcookonthefly=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-skipcookonthefly");
            return (BuildCookRunConfig) this;
        }

        
        
/// <summary>"wipe intermediate folders before building"
/// 
/// Shared: Determines if the intermediate folders will be wiped before building, commandline: -clean
/// </summary>
        public virtual BuildCookRunConfig Clean(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-clean=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-clean");
            return (BuildCookRunConfig) this;
        }

        
        
/// <summary>"assumes no operator is present, always terminates without waiting for something."
/// 
/// Shared: Assumes no user is sitting at the console, so for example kills clients automatically, commandline: -Unattended
/// </summary>
        public virtual BuildCookRunConfig Unattended(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-unattended=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-unattended");
            return (BuildCookRunConfig) this;
        }

        
        
/// <summary>"generate a pak file"
/// "disable reuse of pak files from the alternate cook source folder, if specified"
/// 
/// Shared: True if pak file should be generated.
/// </summary>
        public virtual BuildCookRunConfig Pak(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-pak=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-pak");
            return (BuildCookRunConfig) this;
        }

        
        
/// <summary>"generate I/O store container file(s)"
/// 
/// Shared: True if container file(s) should be generated with ZenPak.
/// </summary>
        public virtual BuildCookRunConfig Iostore(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-iostore=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-iostore");
            return (BuildCookRunConfig) this;
        }

        
        
/// <summary>"generate optimized config data during staging to improve loadtimes"</summary>
        public virtual BuildCookRunConfig Makebinaryconfig(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-makebinaryconfig=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-makebinaryconfig");
            return (BuildCookRunConfig) this;
        }

        
        
/// <summary>"sign the generated pak file with the specified key, i.e. -signpak=C:\\Encryption.keys. Also implies -signedpak."
/// 
/// Shared: Encryption keys used for signing the pak file.
/// </summary>
        public virtual BuildCookRunConfig Signpak(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-signpak=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-signpak");
            return (BuildCookRunConfig) this;
        }

        
        
/// <summary>"attempt to avoid cooking and instead pull pak files from the network, implies pak and skipcook"
/// 
/// Shared: true if this build is staged, command line: -stage
/// </summary>
        public virtual BuildCookRunConfig Prepak(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-prepak=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-prepak");
            return (BuildCookRunConfig) this;
        }

        
        
/// <summary>"the game should expect to use a signed pak file."</summary>
        public virtual BuildCookRunConfig Signed(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-signed" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-signed");
            return (BuildCookRunConfig) this;
        }

        
        
/// <summary>"The game will be set up for memory mapping bulk data."
/// 
/// Shared: The game will be set up for memory mapping bulk data.
/// </summary>
        public virtual BuildCookRunConfig PakAlignForMemoryMapping(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-PakAlignForMemoryMapping=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-PakAlignForMemoryMapping");
            return (BuildCookRunConfig) this;
        }

        
        
/// <summary>"use a pak file, but assume it is already built, implies pak"
/// 
/// Shared: true if this build is staged, command line: -stage
/// </summary>
        public virtual BuildCookRunConfig Skippak(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-skippak=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-skippak");
            return (BuildCookRunConfig) this;
        }

        
        
/// <summary>"override the -iostore commandline option to not run it"
/// 
/// Shared: true if we want to skip iostore, even if -iostore is specified
/// </summary>
        public virtual BuildCookRunConfig Skipiostore(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-skipiostore=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-skipiostore");
            return (BuildCookRunConfig) this;
        }

        
        
/// <summary>"put this build in a stage directory"
/// 
/// Shared: true if this build is staged, command line: -stage
/// </summary>
        public virtual BuildCookRunConfig Stage(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-stage=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-stage");
            return (BuildCookRunConfig) this;
        }

        
        
/// <summary>"uses a stage directory, but assumes everything is already there, implies -stage"
/// 
/// Shared: true if this build is staged, command line: -stage
/// </summary>
        public virtual BuildCookRunConfig Skipstage(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-skipstage=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-skipstage");
            return (BuildCookRunConfig) this;
        }

        
        
/// <summary>"generate streaming install manifests when cooking data"
/// 
/// Shared: true if this build is using streaming install manifests, command line: -manifests
/// </summary>
        public virtual BuildCookRunConfig Manifests(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-manifests=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-manifests");
            return (BuildCookRunConfig) this;
        }

        
        
/// <summary>"generate streaming install data from manifest when cooking data, requires -stage &amp; -manifests"
/// 
/// Shared: true if this build chunk install streaming install data, command line: -createchunkinstalldata
/// </summary>
        public virtual BuildCookRunConfig Createchunkinstall(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-createchunkinstall=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-createchunkinstall");
            return (BuildCookRunConfig) this;
        }

        
        
/// <summary>"skips encrypting pak files even if crypto keys are provided"</summary>
        public virtual BuildCookRunConfig Skipencryption(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-skipencryption=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-skipencryption");
            return (BuildCookRunConfig) this;
        }

        
        
/// <summary>"Directory to copy the builds to, i.e. -stagingdirectory=C:\\Stage"</summary>
        public virtual BuildCookRunConfig Stagingdirectory(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-stagingdirectory=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-stagingdirectory");
            return (BuildCookRunConfig) this;
        }

        
        
/// <summary>"Name of the UE4 Editor executable, i.e. -ue4exe=UE4Editor.exe"</summary>
        public virtual BuildCookRunConfig Ue4exe(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-ue4exe=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-ue4exe");
            return (BuildCookRunConfig) this;
        }

        
        
/// <summary>"put this build in an archive directory"
/// 
/// Shared: true if this build is archived, command line: -archive
/// </summary>
        public virtual BuildCookRunConfig Archive(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-archive=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-archive");
            return (BuildCookRunConfig) this;
        }

        
        
/// <summary>"Directory to archive the builds to, i.e. -archivedirectory=C:\\Archive"</summary>
        public virtual BuildCookRunConfig Archivedirectory(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-archivedirectory=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-archivedirectory");
            return (BuildCookRunConfig) this;
        }

        
        
/// <summary>"Archive extra metadata files in addition to the build (e.g. build.properties)"
/// 
/// Whether the project should use non monolithic staging
/// </summary>
        public virtual BuildCookRunConfig Archivemetadata(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-archivemetadata=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-archivemetadata");
            return (BuildCookRunConfig) this;
        }

        
        
/// <summary>"When archiving for Mac, set this to true to package it in a .app bundle instead of normal loose files"
/// 
/// When archiving for Mac, set this to true to package it in a .app bundle instead of normal loose files
/// </summary>
        public virtual BuildCookRunConfig Createappbundle(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-createappbundle=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-createappbundle");
            return (BuildCookRunConfig) this;
        }

        
        
/// <summary>"True if build step should be executed"
/// 
/// Build: True if build step should be executed, command: -build
/// </summary>
        public virtual BuildCookRunConfig Build(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-build=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-build");
            return (BuildCookRunConfig) this;
        }

        
        
/// <summary>"True if XGE should NOT be used for building"
/// 
/// Build: True if XGE should NOT be used for building.
/// 
/// "Toggle to disable the distributed build process"</summary>
        public virtual BuildCookRunConfig Noxge(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-noxge=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-noxge");
            return (BuildCookRunConfig) this;
        }

        
        
/// <summary>"while cooking clean up packages as we are done with them rather then cleaning everything up when we run out of space"
/// 
/// Cook: While cooking clean up packages as we go along rather then cleaning everything (and potentially having to reload some of it) when we run out of space
/// </summary>
        public virtual BuildCookRunConfig CookPartialgc(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-CookPartialgc=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-CookPartialgc");
            return (BuildCookRunConfig) this;
        }

        
        
/// <summary>"Did we cook in the editor instead of in UAT"
/// 
/// Stage: Did we cook in the editor instead of from UAT (cook in editor uses a different staging directory)
/// </summary>
        public virtual BuildCookRunConfig CookInEditor(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-CookInEditor=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-CookInEditor");
            return (BuildCookRunConfig) this;
        }

        
        
/// <summary>"Uses the iterative cooking, command line: -iterativecooking or -iterate"
/// "Uses the iterative cooking, command line: -iterativedeploy or -iterate"
/// 
/// Cook: Uses the iterative cooking, command line: -iterativecooking or -iterate
/// </summary>
        public virtual BuildCookRunConfig Iterativecooking(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-iterativecooking=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-iterativecooking");
            return (BuildCookRunConfig) this;
        }

        
        
/// <summary>"Cook only maps this only affects usage of -cookall the flag"
/// 
/// Cook: Only cook maps (and referenced content) instead of cooking everything only affects -cookall flag
/// </summary>
        public virtual BuildCookRunConfig CookMapsOnly(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-CookMapsOnly=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-CookMapsOnly");
            return (BuildCookRunConfig) this;
        }

        
        
/// <summary>"Cook all the things in the content directory for this project"
/// 
/// Cook: Only cook maps (and referenced content) instead of cooking everything only affects cookall flag
/// </summary>
        public virtual BuildCookRunConfig CookAll(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-CookAll=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-CookAll");
            return (BuildCookRunConfig) this;
        }

        
        
/// <summary>"Skips content under /Engine/Editor when cooking"
/// 
/// Cook: Skip cooking editor content
/// </summary>
        public virtual BuildCookRunConfig SkipCookingEditorContent(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-SkipCookingEditorContent=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-SkipCookingEditorContent");
            return (BuildCookRunConfig) this;
        }

        
        
/// <summary>"Uses fast cook path if supported by target"</summary>
        public virtual BuildCookRunConfig FastCook(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-FastCook=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-FastCook");
            return (BuildCookRunConfig) this;
        }

        
        
/// <summary>"Ignores cook errors and continues with packaging etc"
/// 
/// Cook: Ignores cook errors and continues with packaging etc.
/// </summary>
        public virtual BuildCookRunConfig IgnoreCookErrors(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-IgnoreCookErrors=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-IgnoreCookErrors");
            return (BuildCookRunConfig) this;
        }

        
        
/// <summary>"do not copy debug files to the stage"
/// 
/// Stage: Commandline: -nodebuginfo
/// </summary>
        public virtual BuildCookRunConfig Nodebuginfo(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-nodebuginfo=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-nodebuginfo");
            return (BuildCookRunConfig) this;
        }

        
        
/// <summary>"output debug info to a separate directory"
/// 
/// Stage: Commandline: -separatedebuginfo
/// </summary>
        public virtual BuildCookRunConfig Separatedebuginfo(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-separatedebuginfo=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-separatedebuginfo");
            return (BuildCookRunConfig) this;
        }

        
        
/// <summary>"generates a *.map file"
/// 
/// Stage: Commandline: -mapfile
/// </summary>
        public virtual BuildCookRunConfig MapFile(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-MapFile=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-MapFile");
            return (BuildCookRunConfig) this;
        }

        
        
/// <summary>"skip cleaning the stage directory"
/// 
/// true if the staging directory is to be cleaned: -cleanstage (also true if -clean is specified)
/// </summary>
        public virtual BuildCookRunConfig Nocleanstage(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-nocleanstage=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-nocleanstage");
            return (BuildCookRunConfig) this;
        }

        
        
/// <summary>"command line to put into the stage in UE4CommandLine.txt"</summary>
        public virtual BuildCookRunConfig Cmdline(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-cmdline=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-cmdline");
            return (BuildCookRunConfig) this;
        }

        
        
/// <summary>"string to use as the bundle name when deploying to mobile device"
/// 
/// Stage: If non-empty, the contents will be used for the bundle name
/// </summary>
        public virtual BuildCookRunConfig Bundlename(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-bundlename=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-bundlename");
            return (BuildCookRunConfig) this;
        }

        
        
/// <summary>"run the game after it is built (including server, if -server)"
/// 
/// Run: True if the Run step should be executed, command: -run
/// </summary>
        public virtual BuildCookRunConfig Run(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-run=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-run");
            return (BuildCookRunConfig) this;
        }

        
        
/// <summary>"run the client with cooked data provided by cook on the fly server"
/// 
/// Run: The client runs with cooked data provided by cook on the fly server, command line: -cookonthefly
/// </summary>
        public virtual BuildCookRunConfig Cookonthefly(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-cookonthefly=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-cookonthefly");
            return (BuildCookRunConfig) this;
        }

        
        
/// <summary>"run the client in streaming cook on the fly mode (don't cache files locally instead force reget from server each file load)"
/// 
/// Run: The client should run in streaming mode when connecting to cook on the fly server
/// </summary>
        public virtual BuildCookRunConfig Cookontheflystreaming(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-Cookontheflystreaming=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-Cookontheflystreaming");
            return (BuildCookRunConfig) this;
        }

        
        
/// <summary>"run the client with cooked data provided by UnrealFileServer"
/// 
/// Run: The client runs with cooked data provided by UnrealFileServer, command line: -fileserver
/// </summary>
        public virtual BuildCookRunConfig Fileserver(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-fileserver=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-fileserver");
            return (BuildCookRunConfig) this;
        }

        
        
/// <summary>"build, cook and run both a client and a server (also -server)"
/// 
/// Run: The client connects to dedicated server to get data, command line: -dedicatedserver
/// </summary>
        public virtual BuildCookRunConfig Dedicatedserver(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-dedicatedserver=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-dedicatedserver");
            return (BuildCookRunConfig) this;
        }

        
        
/// <summary>"build, cook and run a client and a server, uses client target configuration"
/// 
/// Run: Uses a client target configuration, also implies -dedicatedserver, command line: -client
/// </summary>
        public virtual BuildCookRunConfig Client(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-client=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-client");
            return (BuildCookRunConfig) this;
        }

        
        
/// <summary>"do not run the client, just run the server"
/// 
/// Run: Whether the client should start or not, command line (to disable): -noclient
/// </summary>
        public virtual BuildCookRunConfig Noclient(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-noclient=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-noclient");
            return (BuildCookRunConfig) this;
        }

        
        
/// <summary>"create a log window for the client"
/// 
/// Run: Client should create its own log window, command line: -logwindow
/// </summary>
        public virtual BuildCookRunConfig Logwindow(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-logwindow=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-logwindow");
            return (BuildCookRunConfig) this;
        }

        
        
/// <summary>"map to run the game with"</summary>
        public virtual BuildCookRunConfig Map(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-map=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-map");
            return (BuildCookRunConfig) this;
        }

        
        
/// <summary>"Additional server map params, i.e ?param=value"
/// 
/// Run: Additional server map params.
/// </summary>
        public virtual BuildCookRunConfig AdditionalServerMapParams(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-AdditionalServerMapParams=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-AdditionalServerMapParams");
            return (BuildCookRunConfig) this;
        }

        
        
/// <summary>"Devices to run the game on"
/// "Device names without the platform prefix to run the game on"</summary>
        public virtual BuildCookRunConfig Device(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-device=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-device");
            return (BuildCookRunConfig) this;
        }

        
        
/// <summary>"Device to run the server on"
/// 
/// Run: the target device to run the server on
/// </summary>
        public virtual BuildCookRunConfig Serverdevice(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-serverdevice=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-serverdevice");
            return (BuildCookRunConfig) this;
        }

        
        
/// <summary>"Skip starting the server"
/// 
/// Run: The indicated server has already been started
/// </summary>
        public virtual BuildCookRunConfig Skipserver(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-skipserver=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-skipserver");
            return (BuildCookRunConfig) this;
        }

        
        
/// <summary>"Start extra clients, n should be 2 or more"
/// 
/// Run: The indicated server has already been started
/// </summary>
        public virtual BuildCookRunConfig Numclients(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-numclients=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-numclients");
            return (BuildCookRunConfig) this;
        }

        
        
/// <summary>"Additional command line arguments for the program"</summary>
        public virtual BuildCookRunConfig Addcmdline(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-addcmdline=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-addcmdline");
            return (BuildCookRunConfig) this;
        }

        
        
/// <summary>"Additional command line arguments for the program"</summary>
        public virtual BuildCookRunConfig Servercmdline(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-servercmdline=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-servercmdline");
            return (BuildCookRunConfig) this;
        }

        
        
/// <summary>"Override command line arguments to pass to the client"</summary>
        public virtual BuildCookRunConfig Clientcmdline(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-clientcmdline=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-clientcmdline");
            return (BuildCookRunConfig) this;
        }

        
        
/// <summary>"add -nullrhi to the client commandlines"
/// 
/// Run:adds -nullrhi to the client commandline
/// </summary>
        public virtual BuildCookRunConfig Nullrhi(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-nullrhi=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-nullrhi");
            return (BuildCookRunConfig) this;
        }

        
        
/// <summary>"adds ?fake to the server URL"
/// 
/// Run:adds ?fake to the server URL
/// </summary>
        public virtual BuildCookRunConfig Fakeclient(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-fakeclient=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-fakeclient");
            return (BuildCookRunConfig) this;
        }

        
        
/// <summary>"rather than running a client, run the editor instead"
/// 
/// Run:adds ?fake to the server URL
/// </summary>
        public virtual BuildCookRunConfig Editortest(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-editortest=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-editortest");
            return (BuildCookRunConfig) this;
        }

        
        
/// <summary>"when running -editortest or a client, run all automation tests, not compatible with -server"
/// "when running -editortest or a client, run a specific automation tests, not compatible with -server"
/// 
/// Run:when running -editortest or a client, run all automation tests, not compatible with -server
/// </summary>
        public virtual BuildCookRunConfig RunAutomationTests(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-RunAutomationTests=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-RunAutomationTests");
            return (BuildCookRunConfig) this;
        }

        
        
/// <summary>"when running -editortest or a client, adds commands like debug crash, debug rendercrash, etc based on index"</summary>
        public virtual BuildCookRunConfig Crash(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-Crash=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-Crash");
            return (BuildCookRunConfig) this;
        }

        
        
/// <summary>"Linux username for unattended key genereation"</summary>
        public virtual BuildCookRunConfig Deviceuser(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-deviceuser=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-deviceuser");
            return (BuildCookRunConfig) this;
        }

        
        
/// <summary>"Linux password"</summary>
        public virtual BuildCookRunConfig Devicepass(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-devicepass=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-devicepass");
            return (BuildCookRunConfig) this;
        }

        
        
/// <summary>"package the project for the target platform"
/// "Determine whether data is packaged. This can be an iteration optimization for platforms that require packages for deployment"</summary>
        public virtual BuildCookRunConfig Package(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-package=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-package");
            return (BuildCookRunConfig) this;
        }

        
        
/// <summary>"Skips packaging the project for the target platform"</summary>
        public virtual BuildCookRunConfig Skippackage(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-skippackage=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-skippackage");
            return (BuildCookRunConfig) this;
        }

        
        
/// <summary>"package for distribution the project"</summary>
        public virtual BuildCookRunConfig Distribution(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-distribution=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-distribution");
            return (BuildCookRunConfig) this;
        }

        
        
/// <summary>"stage prerequisites along with the project"</summary>
        public virtual BuildCookRunConfig Prereqs(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-prereqs=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-prereqs");
            return (BuildCookRunConfig) this;
        }

        
        
/// <summary>"location of prerequisites for applocal deployment"</summary>
        public virtual BuildCookRunConfig Applocaldir(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-applocaldir" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-applocaldir");
            return (BuildCookRunConfig) this;
        }

        
        
/// <summary>"this is a prebuilt cooked and packaged build"</summary>
        public virtual BuildCookRunConfig Prebuilt(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-Prebuilt=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-Prebuilt");
            return (BuildCookRunConfig) this;
        }

        
        
/// <summary>"timeout to wait after we lunch the game"</summary>
        public virtual BuildCookRunConfig RunTimeoutSeconds(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-RunTimeoutSeconds=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-RunTimeoutSeconds");
            return (BuildCookRunConfig) this;
        }

        
        
/// <summary>"Determine a specific Minimum OS"</summary>
        public virtual BuildCookRunConfig SpecifiedArchitecture(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-SpecifiedArchitecture=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-SpecifiedArchitecture");
            return (BuildCookRunConfig) this;
        }

        
        
/// <summary>"extra options to pass to ubt"</summary>
        public virtual BuildCookRunConfig UbtArgs(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-UbtArgs=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-UbtArgs");
            return (BuildCookRunConfig) this;
        }

        
        
/// <summary>"extra options to pass to the platform's packager"</summary>
        public virtual BuildCookRunConfig AdditionalPackageOptions(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-AdditionalPackageOptions=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-AdditionalPackageOptions");
            return (BuildCookRunConfig) this;
        }

        
        
/// <summary>"deploy the project for the target platform"
/// "Location to deploy to on the target platform"</summary>
        public virtual BuildCookRunConfig Deploy(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-deploy=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-deploy");
            return (BuildCookRunConfig) this;
        }

        
        
/// <summary>"download file from target after successful run"</summary>
        public virtual BuildCookRunConfig Getfile(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-getfile=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-getfile");
            return (BuildCookRunConfig) this;
        }

        
        
/// <summary>"List of maps that need light maps rebuilding"</summary>
        public virtual BuildCookRunConfig MapsToRebuildLightMaps(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-MapsToRebuildLightMaps=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-MapsToRebuildLightMaps");
            return (BuildCookRunConfig) this;
        }

        
        
/// <summary>"List of maps that need HLOD rebuilding"</summary>
        public virtual BuildCookRunConfig MapsToRebuildHLODMaps(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-MapsToRebuildHLODMaps=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-MapsToRebuildHLODMaps");
            return (BuildCookRunConfig) this;
        }

        
        
/// <summary>"Whether Light Map errors should be treated as critical"</summary>
        public virtual BuildCookRunConfig IgnoreLightMapErrors(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-IgnoreLightMapErrors" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-IgnoreLightMapErrors");
            return (BuildCookRunConfig) this;
        }

        
        
    
        public virtual BuildCookRunConfig Cookflavor(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-cookflavor=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-cookflavor");
            return (BuildCookRunConfig) this;
        }

        
        
    
        public virtual BuildCookRunConfig Skipbuild(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-skipbuild=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-skipbuild");
            return (BuildCookRunConfig) this;
        }

        
        
/// <summary>
/// SkipBuildClient if true then don't build the client exe
/// </summary>
        public virtual BuildCookRunConfig SkipBuildClient(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-skipbuildclient=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-skipbuildclient");
            return (BuildCookRunConfig) this;
        }

        
        
/// <summary>
/// SkipBuildEditor if true then don't build the editor exe
/// </summary>
        public virtual BuildCookRunConfig SkipBuildEditor(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-skipbuildeditor=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-skipbuildeditor");
            return (BuildCookRunConfig) this;
        }

        
        
    
        public virtual BuildCookRunConfig Createreleaseversionroot(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-createreleaseversionroot=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-createreleaseversionroot");
            return (BuildCookRunConfig) this;
        }

        
        
    
        public virtual BuildCookRunConfig Basedonreleaseversionroot(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-basedonreleaseversionroot=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-basedonreleaseversionroot");
            return (BuildCookRunConfig) this;
        }

        
        
/// <summary>
/// The version of the originally released build. This is required by some platforms when generating patches.
/// </summary>
        public virtual BuildCookRunConfig OriginalReleaseVersion(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-originalreleaseversion=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-originalreleaseversion");
            return (BuildCookRunConfig) this;
        }

        
        
/// <summary>
/// Cook: Create a cooked release version.  Also, the version. e.g. 1.0
/// </summary>
        public virtual BuildCookRunConfig CreateReleaseVersion(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-createreleaseversion=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-createreleaseversion");
            return (BuildCookRunConfig) this;
        }

        
        
/// <summary>
/// Cook: Base this cook of a already released version of the cooked data
/// </summary>
        public virtual BuildCookRunConfig BasedOnReleaseVersion(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-basedonreleaseversion=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-basedonreleaseversion");
            return (BuildCookRunConfig) this;
        }

        
        
/// <summary>
/// Are we generating a patch, generate a patch from a previously released version of the game (use CreateReleaseVersion to create a release).
/// this requires BasedOnReleaseVersion
/// see also CreateReleaseVersion, BasedOnReleaseVersion
/// </summary>
        public virtual BuildCookRunConfig GeneratePatch(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-GeneratePatch=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-GeneratePatch");
            return (BuildCookRunConfig) this;
        }

        
        
/// <summary></summary>
        public virtual BuildCookRunConfig AddPatchLevel(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-AddPatchLevel=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-AddPatchLevel");
            return (BuildCookRunConfig) this;
        }

        
        
/// <summary>
/// Are we staging the unmodified pak files from the base release</summary>
        public virtual BuildCookRunConfig StageBaseReleasePaks(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-StageBaseReleasePaks=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-StageBaseReleasePaks");
            return (BuildCookRunConfig) this;
        }

        
        
/// <summary>
/// Required when building remaster package
/// </summary>
        public virtual BuildCookRunConfig DiscVersion(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-DiscVersion=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-DiscVersion");
            return (BuildCookRunConfig) this;
        }

        
        
/// <summary>
/// Cook: Additional cooker options to include on the cooker commandline
/// </summary>
        public virtual BuildCookRunConfig AdditionalCookerOptions(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-AdditionalCookerOptions=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-AdditionalCookerOptions");
            return (BuildCookRunConfig) this;
        }

        
        
    
        public virtual BuildCookRunConfig DLCName(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-DLCName=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-DLCName");
            return (BuildCookRunConfig) this;
        }

        
        
/// <summary>
/// After cook completes diff the cooked content against another cooked content directory.
/// report all errors to the log
/// </summary>
        public virtual BuildCookRunConfig DiffCookedContentPath(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-DiffCookedContentPath=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-DiffCookedContentPath");
            return (BuildCookRunConfig) this;
        }

        
        
/// <summary>
/// Enable cooking of engine content when cooking dlc
/// not included in original release but is referenced by current cook
/// </summary>
        public virtual BuildCookRunConfig DLCIncludeEngineContent(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-DLCIncludeEngineContent=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-DLCIncludeEngineContent");
            return (BuildCookRunConfig) this;
        }

        
        
/// <summary>
/// Enable packaging up the uplugin file inside the dlc pak.  This is sometimes desired if you want the plugin to be standalone
/// </summary>
        public virtual BuildCookRunConfig DLCPakPluginFile(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-DLCPakPluginFile=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-DLCPakPluginFile");
            return (BuildCookRunConfig) this;
        }

        
        
/// <summary>
/// DLC will remap it's files to the game directory and act like a patch.  This is useful if you want to override content in the main game along side your main game.
/// For example having different main game content in different DLCs
/// </summary>
        public virtual BuildCookRunConfig DLCActLikePatch(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-DLCActLikePatch=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-DLCActLikePatch");
            return (BuildCookRunConfig) this;
        }

        
        
/// <summary>
/// Shared: the game will use only signed content.
/// </summary>
        public virtual BuildCookRunConfig SignedPak(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-signedpak=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-signedpak");
            return (BuildCookRunConfig) this;
        }

        
        
/// <summary>
/// Stage: True if we should disable trying to re-use pak files from another staged build when we've specified a different cook source platform
/// </summary>
        public virtual BuildCookRunConfig IgnorePaksFromDifferentCookSource(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-IgnorePaksFromDifferentCookSource=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-IgnorePaksFromDifferentCookSource");
            return (BuildCookRunConfig) this;
        }

        
        
/// <summary>
/// Cook: Do not include a version number in the cooked content
/// </summary>
        public virtual BuildCookRunConfig UnversionedCookedContent(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-UnversionedCookedContent=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-UnversionedCookedContent");
            return (BuildCookRunConfig) this;
        }

        
        
/// <summary>
/// Cook: number of additional cookers to spawn while cooking
/// </summary>
        public virtual BuildCookRunConfig NumCookersToSpawn(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-NumCookersToSpawn=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-NumCookersToSpawn");
            return (BuildCookRunConfig) this;
        }

        
        
/// <summary>
/// Compress packages during cook.
/// </summary>
        public virtual BuildCookRunConfig Compressed(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-compressed=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-compressed");
            return (BuildCookRunConfig) this;
        }

        
        
/// <summary>
/// Do not compress packages during cook, override game ProjectPackagingSettings to force it off
/// </summary>
        public virtual BuildCookRunConfig ForceUncompressed(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-ForceUncompressed=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-ForceUncompressed");
            return (BuildCookRunConfig) this;
        }

        
        
/// <summary>
/// Additional parameters when generating the PAK file
/// </summary>
        public virtual BuildCookRunConfig AdditionalPakOptions(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-AdditionalPakOptions=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-AdditionalPakOptions");
            return (BuildCookRunConfig) this;
        }

        
        
/// <summary>
/// Additional parameters when generating iostore container files
/// </summary>
        public virtual BuildCookRunConfig AdditionalIoStoreOptions(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-AdditionalIoStoreOptions=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-AdditionalIoStoreOptions");
            return (BuildCookRunConfig) this;
        }

        
        
/// <summary>
/// Cook: Iterate from a build on the network
/// </summary>
        public virtual BuildCookRunConfig Iteratesharedcookedbuild(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-iteratesharedcookedbuild=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-iteratesharedcookedbuild");
            return (BuildCookRunConfig) this;
        }

        
        
/// <summary>
/// Build: Don't build the game instead use the prebuild exe (requires iterate shared cooked build
/// </summary>
        public virtual BuildCookRunConfig IterateSharedBuildUsePrecompiledExe(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-IterateSharedBuildUsePrecompiledExe=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-IterateSharedBuildUsePrecompiledExe");
            return (BuildCookRunConfig) this;
        }

        
        
/// <summary>
/// Cook: Output directory for cooked data
/// </summary>
        public virtual BuildCookRunConfig CookOutputDir(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-CookOutputDir=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-CookOutputDir");
            return (BuildCookRunConfig) this;
        }

        
        
    
        public virtual BuildCookRunConfig Target(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-target=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-target");
            return (BuildCookRunConfig) this;
        }

        
        
/// <summary>Stage: Specifies a list of extra targets that should be staged along with a client
/// </summary>
        public virtual BuildCookRunConfig ExtraTargetsToStageWithClient(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-ExtraTargetsToStageWithClient=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-ExtraTargetsToStageWithClient");
            return (BuildCookRunConfig) this;
        }

        
        
/// <summary>
/// By default we don't code sign unless it is required or requested
/// </summary>
        public virtual BuildCookRunConfig CodeSign(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-CodeSign=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-CodeSign");
            return (BuildCookRunConfig) this;
        }

        
        
/// <summary>
/// If true, non-shipping binaries will be considered DebugUFS files and will appear on the debugfiles manifest
/// </summary>
        public virtual BuildCookRunConfig TreatNonShippingBinariesAsDebugFiles(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-TreatNonShippingBinariesAsDebugFiles=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-TreatNonShippingBinariesAsDebugFiles");
            return (BuildCookRunConfig) this;
        }

        
        
/// <summary>
/// If true, use chunk manifest files generated for extra flavor
/// </summary>
        public virtual BuildCookRunConfig UseExtraFlavor(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-UseExtraFlavor=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-UseExtraFlavor");
            return (BuildCookRunConfig) this;
        }

        
        
/// <summary>
/// Shared: Directory to use for built chunk install data, command line: -chunkinstalldirectory=
/// </summary>
        public virtual BuildCookRunConfig ChunkInstallDirectory(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-chunkinstalldirectory=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-chunkinstalldirectory");
            return (BuildCookRunConfig) this;
        }

        
        
    
        public virtual BuildCookRunConfig Chunkinstallversion(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-chunkinstallversion=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-chunkinstallversion");
            return (BuildCookRunConfig) this;
        }

        
        
    
        public virtual BuildCookRunConfig Chunkinstallrelease(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-chunkinstallrelease=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-chunkinstallrelease");
            return (BuildCookRunConfig) this;
        }

        
        
    
        public virtual BuildCookRunConfig AppLocalDirectory(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-applocaldirectory=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-applocaldirectory");
            return (BuildCookRunConfig) this;
        }

        
        
/// <summary>
/// On Windows, adds an executable to the root of the staging directory which checks for prerequisites being
/// installed and launches the game with a path to the .uproject file.
/// </summary>
        public virtual BuildCookRunConfig NoBootstrapExe(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-nobootstrapexe=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-nobootstrapexe");
            return (BuildCookRunConfig) this;
        }

        
        
    
        public virtual BuildCookRunConfig ForcePackageData(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-forcepackagedata=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-forcepackagedata");
            return (BuildCookRunConfig) this;
        }

        
        
/// <summary>
/// Cook: Uses the iterative deploy, command line: -iterativedeploy or -iterate
/// </summary>
        public virtual BuildCookRunConfig IterativeDeploy(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-iterativedeploy=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-iterativedeploy");
            return (BuildCookRunConfig) this;
        }

        
        
/// <summary>
/// Provision to use
/// </summary>
        public virtual BuildCookRunConfig Provision(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-provision=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-provision");
            return (BuildCookRunConfig) this;
        }

        
        
/// <summary>
/// Certificate to use
/// </summary>
        public virtual BuildCookRunConfig Certificate(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-certificate=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-certificate");
            return (BuildCookRunConfig) this;
        }

        
        
/// <summary>
/// Team ID to use
/// </summary>
        public virtual BuildCookRunConfig Team(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-team=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-team");
            return (BuildCookRunConfig) this;
        }

        
        
/// <summary>
/// true if provisioning is automatically managed
/// </summary>
        public virtual BuildCookRunConfig AutomaticSigning(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-AutomaticSigning=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-AutomaticSigning");
            return (BuildCookRunConfig) this;
        }

        
        
/// <summary>
/// Run:when running -editortest or a client, run all automation tests, not compatible with -server
/// </summary>
        public virtual BuildCookRunConfig RunAutomationTest(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-RunAutomationTest=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-RunAutomationTest");
            return (BuildCookRunConfig) this;
        }

        
        
    
        public virtual BuildCookRunConfig Clientconfig(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-clientconfig=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-clientconfig");
            return (BuildCookRunConfig) this;
        }

        
        
    
        public virtual BuildCookRunConfig Config(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-config=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-config");
            return (BuildCookRunConfig) this;
        }

        
        
    
        public virtual BuildCookRunConfig Configuration(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-configuration=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-configuration");
            return (BuildCookRunConfig) this;
        }

        
        
    
        public virtual BuildCookRunConfig Port(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-port=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-port");
            return (BuildCookRunConfig) this;
        }

        
        
/// <summary>
/// Cook: List of maps to cook.
/// </summary>
        public virtual BuildCookRunConfig MapsToCook(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-MapsToCook=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-MapsToCook");
            return (BuildCookRunConfig) this;
        }

        
        
/// <summary>
/// Cook: List of map inisections to cook (see allmaps)
/// </summary>
        public virtual BuildCookRunConfig MapIniSectionsToCook(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-MapIniSectionsToCook=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-MapIniSectionsToCook");
            return (BuildCookRunConfig) this;
        }

        
        
/// <summary>
/// TitleID to package
/// </summary>
        public virtual BuildCookRunConfig TitleID(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-TitleID=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-TitleID");
            return (BuildCookRunConfig) this;
        }

        
        
    
        public virtual BuildCookRunConfig Serverconfig(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-serverconfig=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-serverconfig");
            return (BuildCookRunConfig) this;
        }

        
        
/// <summary>
/// Run: Adds commands like debug crash, debug rendercrash, etc based on index
/// </summary>
        public virtual BuildCookRunConfig CrashIndex(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-CrashIndex=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-CrashIndex");
            return (BuildCookRunConfig) this;
        }

        
        
/// <summary>"Toggle to combined the result into one executable"</summary>
        public virtual BuildCookRunConfig ForceMonolithic(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-ForceMonolithic" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-ForceMonolithic");
            return (BuildCookRunConfig) this;
        }

        
        
/// <summary>"Forces debug info even in development builds"</summary>
        public virtual BuildCookRunConfig ForceDebugInfo(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-ForceDebugInfo" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-ForceDebugInfo");
            return (BuildCookRunConfig) this;
        }

        
        
/// <summary>"Toggle to disable the unity build system"</summary>
        public virtual BuildCookRunConfig ForceNonUnity(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-ForceNonUnity" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-ForceNonUnity");
            return (BuildCookRunConfig) this;
        }

        
        
/// <summary>"Toggle to force enable the unity build system"</summary>
        public virtual BuildCookRunConfig ForceUnity(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-ForceUnity" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-ForceUnity");
            return (BuildCookRunConfig) this;
        }

        
        
/// <summary>"If set, this build is being compiled by a licensee"</summary>
        public virtual BuildCookRunConfig Licensee(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-Licensee=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-Licensee");
            return (BuildCookRunConfig) this;
        }

        
        
    
        public virtual BuildCookRunConfig Promoted(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-Promoted=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-Promoted");
            return (BuildCookRunConfig) this;
        }

        
        
    
        public virtual BuildCookRunConfig Branch(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-Branch=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-Branch");
            return (BuildCookRunConfig) this;
        }

        
        
    
        public virtual BuildCookRunConfig StopOnErrors(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-StopOnErrors=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-StopOnErrors");
            return (BuildCookRunConfig) this;
        }

        
        
/// <summary>"Skips signing of code/content files."</summary>
        public virtual BuildCookRunConfig NoSign(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-NoSign=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-NoSign");
            return (BuildCookRunConfig) this;
        }
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    
        public override string Gather()
        {
            Arguments.Insert(0, "BuildCookRun");return base.Gather();
        }
    }

    protected readonly BuildCookRunConfig BuildCookRunStorage = new();
        
    
    public  class BuildDerivedDataCacheConfig : ToolConfig
    {
        public override string Name => "BuildDerivedDataCache";
    
        
    
        public virtual BuildDerivedDataCacheConfig FeaturePacks(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-FeaturePacks=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-FeaturePacks");
            return (BuildDerivedDataCacheConfig) this;
        }

        
        
    
        public virtual BuildDerivedDataCacheConfig TempDir(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-TempDir=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-TempDir");
            return (BuildDerivedDataCacheConfig) this;
        }

        
        
    
        public virtual BuildDerivedDataCacheConfig TargetPlatforms(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-TargetPlatforms=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-TargetPlatforms");
            return (BuildDerivedDataCacheConfig) this;
        }

        
        
    
        public virtual BuildDerivedDataCacheConfig SavedDir(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-SavedDir=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-SavedDir");
            return (BuildDerivedDataCacheConfig) this;
        }

        
        
    
        public virtual BuildDerivedDataCacheConfig BackendName(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-BackendName=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-BackendName");
            return (BuildDerivedDataCacheConfig) this;
        }

        
        
    
        public virtual BuildDerivedDataCacheConfig RelativePakPath(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-RelativePakPath=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-RelativePakPath");
            return (BuildDerivedDataCacheConfig) this;
        }

        
        
    
        public virtual BuildDerivedDataCacheConfig SkipEngine(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-SkipEngine=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-SkipEngine");
            return (BuildDerivedDataCacheConfig) this;
        }
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    
        public override string Gather()
        {
            Arguments.Insert(0, "BuildDerivedDataCache");return base.Gather();
        }
    }

    protected readonly BuildDerivedDataCacheConfig BuildDerivedDataCacheStorage = new();
        
/// <remarks>WARNING: This command might require Perforce</remarks>
    public  class BuildForUGSConfig : ToolConfig
    {
        public override string Name => "BuildForUGS";
    
        
    
        public virtual BuildForUGSConfig Target(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-Target=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-Target");
            return (BuildForUGSConfig) this;
        }

        
        
    
        public virtual BuildForUGSConfig Archive(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-Archive=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-Archive");
            return (BuildForUGSConfig) this;
        }

        
        
    
        public virtual BuildForUGSConfig Stream(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-Stream=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-Stream");
            return (BuildForUGSConfig) this;
        }

        
        
    
        public virtual BuildForUGSConfig WithUAT(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-WithUAT=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-WithUAT");
            return (BuildForUGSConfig) this;
        }

        
        
    
        public virtual BuildForUGSConfig WithUBT(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-WithUBT=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-WithUBT");
            return (BuildForUGSConfig) this;
        }
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    
        public override string Gather()
        {
            Arguments.Insert(0, "BuildForUGS");return base.Gather();
        }
    }

    protected readonly BuildForUGSConfig BuildForUGSStorage = new();
        
/// <summary>Builds Hlslcc using CMake build system.</summary>
/// <remarks>WARNING: This command might require Perforce</remarks>
    public  class BuildHlslccConfig : ToolConfig
    {
        public override string Name => "BuildHlslcc";
    
        
/// <summary>"Specify a list of target platforms to build, separated by '+' characters (eg. -TargetPlatforms=Win64+Linux+Mac). Architectures are specified with '-'. Default is Win64+Linux."</summary>
        public virtual BuildHlslccConfig TargetPlatforms(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-TargetPlatforms=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-TargetPlatforms");
            return (BuildHlslccConfig) this;
        }

        
        
/// <summary>"Specify a list of configurations to build, separated by '+' characters (eg. -TargetConfigs=Debug+RelWithDebInfo). Default is Debug+RelWithDebInfo."</summary>
        public virtual BuildHlslccConfig TargetConfigs(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-TargetConfigs=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-TargetConfigs");
            return (BuildHlslccConfig) this;
        }

        
        
/// <summary>"Specify a list of target compilers to use when building for Windows, separated by '+' characters (eg. -TargetCompilers=VisualStudio2015+VisualStudio2017). Default is VisualStudio2015."</summary>
        public virtual BuildHlslccConfig TargetWindowsCompilers(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-TargetWindowsCompilers=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-TargetWindowsCompilers");
            return (BuildHlslccConfig) this;
        }

        
        
/// <summary>"Do not perform build step. If this argument is not supplied libraries will be built (in accordance with TargetLibs, TargetPlatforms and TargetWindowsCompilers)."</summary>
        public virtual BuildHlslccConfig SkipBuild(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-SkipBuild=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-SkipBuild");
            return (BuildHlslccConfig) this;
        }

        
        
/// <summary>"Do not perform library deployment to the engine. If this argument is not supplied libraries will be copied into the engine."</summary>
        public virtual BuildHlslccConfig SkipDeployLibs(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-SkipDeployLibs" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-SkipDeployLibs");
            return (BuildHlslccConfig) this;
        }

        
        
/// <summary>"Do not perform source deployment to the engine. If this argument is not supplied source will be copied into the engine."</summary>
        public virtual BuildHlslccConfig SkipDeploySource(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-SkipDeploySource" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-SkipDeploySource");
            return (BuildHlslccConfig) this;
        }

        
        
/// <summary>"Do not create a P4 changelist for source or libs. If this argument is not supplied source and libs will be added to a Perforce changelist."</summary>
        public virtual BuildHlslccConfig SkipCreateChangelist(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-SkipCreateChangelist=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-SkipCreateChangelist");
            return (BuildHlslccConfig) this;
        }

        
        
/// <summary>"Do not perform P4 submit of source or libs. If this argument is not supplied source and libs will be automatically submitted to Perforce. If SkipCreateChangelist is specified, this argument applies by default."</summary>
        public virtual BuildHlslccConfig SkipSubmit(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-SkipSubmit=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-SkipSubmit");
            return (BuildHlslccConfig) this;
        }

        
        
/// <summary>"Which robomerge action to apply to the submission. If we're skipping submit, this is not used."</summary>
        public virtual BuildHlslccConfig Robomerge(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-Robomerge=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-Robomerge");
            return (BuildHlslccConfig) this;
        }

        
        
    
        public virtual BuildHlslccConfig SkipBuildSolutions(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-SkipBuildSolutions=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-SkipBuildSolutions");
            return (BuildHlslccConfig) this;
        }
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    
        public override string Gather()
        {
            Arguments.Insert(0, "BuildHlslcc");return base.Gather();
        }
    }

    protected readonly BuildHlslccConfig BuildHlslccStorage = new();
        
    
    public  class BuildPhysX_AndroidConfig : ToolConfig
    {
        public override string Name => "BuildPhysX_Android";
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    
        public override string Gather()
        {
            Arguments.Insert(0, "BuildPhysX_Android");return base.Gather();
        }
    }

    protected readonly BuildPhysX_AndroidConfig BuildPhysX_AndroidStorage = new();
        
    
    public  class BuildPhysX_IOSConfig : ToolConfig
    {
        public override string Name => "BuildPhysX_IOS";
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    
        public override string Gather()
        {
            Arguments.Insert(0, "BuildPhysX_IOS");return base.Gather();
        }
    }

    protected readonly BuildPhysX_IOSConfig BuildPhysX_IOSStorage = new();
        
    
    public  class BuildPhysX_LinuxConfig : ToolConfig
    {
        public override string Name => "BuildPhysX_Linux";
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    
        public override string Gather()
        {
            Arguments.Insert(0, "BuildPhysX_Linux");return base.Gather();
        }
    }

    protected readonly BuildPhysX_LinuxConfig BuildPhysX_LinuxStorage = new();
        
    
    public  class BuildPhysX_Mac_x86_64Config : ToolConfig
    {
        public override string Name => "BuildPhysX_Mac_x86_64";
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    
        public override string Gather()
        {
            Arguments.Insert(0, "BuildPhysX_Mac_x86_64");return base.Gather();
        }
    }

    protected readonly BuildPhysX_Mac_x86_64Config BuildPhysX_Mac_x86_64Storage = new();
        
    
    public  class BuildPhysX_Mac_arm64Config : ToolConfig
    {
        public override string Name => "BuildPhysX_Mac_arm64";
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    
        public override string Gather()
        {
            Arguments.Insert(0, "BuildPhysX_Mac_arm64");return base.Gather();
        }
    }

    protected readonly BuildPhysX_Mac_arm64Config BuildPhysX_Mac_arm64Storage = new();
        
    
    public  class BuildPhysX_MacConfig : ToolConfig
    {
        public override string Name => "BuildPhysX_Mac";
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    
        public override string Gather()
        {
            Arguments.Insert(0, "BuildPhysX_Mac");return base.Gather();
        }
    }

    protected readonly BuildPhysX_MacConfig BuildPhysX_MacStorage = new();
        
    
    public  class BuildPhysX_TVOSConfig : ToolConfig
    {
        public override string Name => "BuildPhysX_TVOS";
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    
        public override string Gather()
        {
            Arguments.Insert(0, "BuildPhysX_TVOS");return base.Gather();
        }
    }

    protected readonly BuildPhysX_TVOSConfig BuildPhysX_TVOSStorage = new();
        
    
    public  class BuildPhysX_Win32Config : ToolConfig
    {
        public override string Name => "BuildPhysX_Win32";
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    
        public override string Gather()
        {
            Arguments.Insert(0, "BuildPhysX_Win32");return base.Gather();
        }
    }

    protected readonly BuildPhysX_Win32Config BuildPhysX_Win32Storage = new();
        
    
    public  class BuildPhysX_Win64Config : ToolConfig
    {
        public override string Name => "BuildPhysX_Win64";
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    
        public override string Gather()
        {
            Arguments.Insert(0, "BuildPhysX_Win64");return base.Gather();
        }
    }

    protected readonly BuildPhysX_Win64Config BuildPhysX_Win64Storage = new();
        
/// <summary>Builds a plugin, and packages it for distribution</summary>
    public  class BuildPluginConfig : ToolConfig
    {
        public override string Name => "BuildPlugin";
    
        
/// <summary>"Specify the path to the descriptor file for the plugin that should be packaged"</summary>
        public virtual BuildPluginConfig Plugin(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-Plugin=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-Plugin");
            return (BuildPluginConfig) this;
        }

        
        
/// <summary>"Prevent compiling for the editor platform on the host"</summary>
        public virtual BuildPluginConfig NoHostPlatform(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-NoHostPlatform=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-NoHostPlatform");
            return (BuildPluginConfig) this;
        }

        
        
/// <summary>"Specify a list of target platforms to build, separated by '+' characters (eg. -TargetPlatforms=Win32+Win64). Default is all the Rocket target platforms."</summary>
        public virtual BuildPluginConfig TargetPlatforms(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-TargetPlatforms=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-TargetPlatforms");
            return (BuildPluginConfig) this;
        }

        
        
/// <summary>"The path which the build artifacts should be packaged to, ready for distribution."</summary>
        public virtual BuildPluginConfig Package(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-Package=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-Package");
            return (BuildPluginConfig) this;
        }

        
        
/// <summary>"Disables precompiled headers and unity build in order to check all source files have self-contained headers."</summary>
        public virtual BuildPluginConfig StrictIncludes(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-StrictIncludes=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-StrictIncludes");
            return (BuildPluginConfig) this;
        }

        
        
/// <summary>"Do not embed the current engine version into the descriptor"</summary>
        public virtual BuildPluginConfig Unversioned(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-Unversioned=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-Unversioned");
            return (BuildPluginConfig) this;
        }

        
        
    
        public virtual BuildPluginConfig VS2019(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-VS2019=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-VS2019");
            return (BuildPluginConfig) this;
        }

        
        
    
        public virtual BuildPluginConfig NoDeleteHostProject(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-NoDeleteHostProject=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-NoDeleteHostProject");
            return (BuildPluginConfig) this;
        }

        
        
    
        public virtual BuildPluginConfig NoTargetPlatforms(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-NoTargetPlatforms=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-NoTargetPlatforms");
            return (BuildPluginConfig) this;
        }
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    
        public override string Gather()
        {
            Arguments.Insert(0, "BuildPlugin");return base.Gather();
        }
    }

    protected readonly BuildPluginConfig BuildPluginStorage = new();
        
/// <summary>Builds the editor for the specified project.
/// Example BuildEditor -project=QAGame
/// Note: Editor will only ever build for the current platform in a Development config and required tools will be included</summary>
    public  class BuildEditorConfig : ToolConfig
    {
        public override string Name => "BuildEditor";
    
        
/// <summary>"Project to build. Will search current path and paths in ueprojectdirs. If omitted will build vanilla UE4Editor"</summary>
        public virtual BuildEditorConfig Project(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-project=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-project");
            return (BuildEditorConfig) this;
        }

        
        
/// <summary>"Don't build any tools (UHT, ShaderCompiler, CrashReporter"
/// "Don't build any tools (UnrealPak, Lightmass, ShaderCompiler, CrashReporter"</summary>
        public virtual BuildEditorConfig Notools(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-notools=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-notools");
            return (BuildEditorConfig) this;
        }

        
        
    
        public virtual BuildEditorConfig Open(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-open=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-open");
            return (BuildEditorConfig) this;
        }

        
        
/// <summary>"Platforms to build, join multiple platforms using +"
/// 
/// Platform to build
/// </summary>
        public virtual BuildEditorConfig Platform(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-platform=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-platform");
            return (BuildEditorConfig) this;
        }

        
        
/// <summary>"Configurations to build, join multiple configurations using +"</summary>
        public virtual BuildEditorConfig Configuration(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-configuration=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-configuration");
            return (BuildEditorConfig) this;
        }

        
        
/// <summary>"Targets to build, join multiple targets using +"</summary>
        public virtual BuildEditorConfig Target(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-target=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-target");
            return (BuildEditorConfig) this;
        }

        
        
/// <summary>"Do a clean build"
/// 
/// Whether to clean this target. If not specified, the target will be cleaned if -Clean is on the command line.
/// </summary>
        public virtual BuildEditorConfig Clean(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-clean=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-clean");
            return (BuildEditorConfig) this;
        }

        
        
/// <summary>"Toggle to disable the distributed build process"</summary>
        public virtual BuildEditorConfig NoXGE(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-NoXGE" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-NoXGE");
            return (BuildEditorConfig) this;
        }

        
        
/// <summary>"Toggle to disable the unity build system"</summary>
        public virtual BuildEditorConfig DisableUnity(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-DisableUnity" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-DisableUnity");
            return (BuildEditorConfig) this;
        }

        
        
/// <summary>
/// Extra UBT args
/// </summary>
        public virtual BuildEditorConfig UBTArgs(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-ubtargs=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-ubtargs");
            return (BuildEditorConfig) this;
        }

        
        
    
        public virtual BuildEditorConfig Preview(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-preview=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-preview");
            return (BuildEditorConfig) this;
        }
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    
        public override string Gather()
        {
            Arguments.Insert(0, "BuildEditor");return base.Gather();
        }
    }

    protected readonly BuildEditorConfig BuildEditorStorage = new();
        
/// <summary>Builds the game for the specified project.
/// Example BuildGame -project=QAGame -platform=PS4+XboxOne -configuration=Development.</summary>
    public  class BuildGameConfig : ToolConfig
    {
        public override string Name => "BuildGame";
    
        
/// <summary>"Project to build. Will search current path and paths in ueprojectdirs."
/// "Project to build. Will search current path and paths in ueprojectdirs. If omitted will build vanilla UE4Editor"</summary>
        public virtual BuildGameConfig Project(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-project=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-project");
            return (BuildGameConfig) this;
        }

        
        
/// <summary>"Platforms to build, join multiple platforms using +"
/// "Platforms to build, join multiple platforms using +"
/// 
/// Platform to build
/// </summary>
        public virtual BuildGameConfig Platform(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-platform=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-platform");
            return (BuildGameConfig) this;
        }

        
        
/// <summary>"Configurations to build, join multiple configurations using +"</summary>
        public virtual BuildGameConfig Configuration(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-configuration=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-configuration");
            return (BuildGameConfig) this;
        }

        
        
/// <summary>"Don't build any tools (UHT, ShaderCompiler, CrashReporter"
/// "Don't build any tools (UnrealPak, Lightmass, ShaderCompiler, CrashReporter"</summary>
        public virtual BuildGameConfig Notools(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-notools=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-notools");
            return (BuildGameConfig) this;
        }

        
        
/// <summary>"Targets to build, join multiple targets using +"</summary>
        public virtual BuildGameConfig Target(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-target=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-target");
            return (BuildGameConfig) this;
        }

        
        
/// <summary>"Do a clean build"
/// 
/// Whether to clean this target. If not specified, the target will be cleaned if -Clean is on the command line.
/// </summary>
        public virtual BuildGameConfig Clean(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-clean=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-clean");
            return (BuildGameConfig) this;
        }

        
        
/// <summary>"Toggle to disable the distributed build process"</summary>
        public virtual BuildGameConfig NoXGE(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-NoXGE" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-NoXGE");
            return (BuildGameConfig) this;
        }

        
        
/// <summary>"Toggle to disable the unity build system"</summary>
        public virtual BuildGameConfig DisableUnity(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-DisableUnity" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-DisableUnity");
            return (BuildGameConfig) this;
        }

        
        
/// <summary>
/// Extra UBT args
/// </summary>
        public virtual BuildGameConfig UBTArgs(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-ubtargs=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-ubtargs");
            return (BuildGameConfig) this;
        }

        
        
    
        public virtual BuildGameConfig Preview(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-preview=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-preview");
            return (BuildGameConfig) this;
        }
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    
        public override string Gather()
        {
            Arguments.Insert(0, "BuildGame");return base.Gather();
        }
    }

    protected readonly BuildGameConfig BuildGameStorage = new();
        
/// <summary>Builds the server for the specified project.
/// Example BuildServer -project=QAGame -platform=Win64 -configuration=Development.</summary>
    public  class BuildServerConfig : ToolConfig
    {
        public override string Name => "BuildServer";
    
        
/// <summary>"Project to build. Will search current path and paths in ueprojectdirs."
/// "Project to build. Will search current path and paths in ueprojectdirs. If omitted will build vanilla UE4Editor"</summary>
        public virtual BuildServerConfig Project(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-project=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-project");
            return (BuildServerConfig) this;
        }

        
        
/// <summary>"Platforms to build, join multiple platforms using +"
/// "Platforms to build, join multiple platforms using +"
/// 
/// Platform to build
/// </summary>
        public virtual BuildServerConfig Platform(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-platform=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-platform");
            return (BuildServerConfig) this;
        }

        
        
/// <summary>"Configurations to build, join multiple configurations using +"</summary>
        public virtual BuildServerConfig Configuration(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-configuration=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-configuration");
            return (BuildServerConfig) this;
        }

        
        
/// <summary>"Don't build any tools (UHT, ShaderCompiler, CrashReporter"
/// "Don't build any tools (UnrealPak, Lightmass, ShaderCompiler, CrashReporter"</summary>
        public virtual BuildServerConfig Notools(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-notools=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-notools");
            return (BuildServerConfig) this;
        }

        
        
/// <summary>"Targets to build, join multiple targets using +"</summary>
        public virtual BuildServerConfig Target(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-target=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-target");
            return (BuildServerConfig) this;
        }

        
        
/// <summary>"Do a clean build"
/// 
/// Whether to clean this target. If not specified, the target will be cleaned if -Clean is on the command line.
/// </summary>
        public virtual BuildServerConfig Clean(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-clean=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-clean");
            return (BuildServerConfig) this;
        }

        
        
/// <summary>"Toggle to disable the distributed build process"</summary>
        public virtual BuildServerConfig NoXGE(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-NoXGE" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-NoXGE");
            return (BuildServerConfig) this;
        }

        
        
/// <summary>"Toggle to disable the unity build system"</summary>
        public virtual BuildServerConfig DisableUnity(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-DisableUnity" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-DisableUnity");
            return (BuildServerConfig) this;
        }

        
        
/// <summary>
/// Extra UBT args
/// </summary>
        public virtual BuildServerConfig UBTArgs(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-ubtargs=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-ubtargs");
            return (BuildServerConfig) this;
        }

        
        
    
        public virtual BuildServerConfig Preview(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-preview=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-preview");
            return (BuildServerConfig) this;
        }
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    
        public override string Gather()
        {
            Arguments.Insert(0, "BuildServer");return base.Gather();
        }
    }

    protected readonly BuildServerConfig BuildServerStorage = new();
        
/// <summary>Builds third party libraries, and puts them all into a changelist</summary>
/// <remarks>WARNING: This command might require Perforce</remarks>
    public  class BuildThirdPartyLibsConfig : ToolConfig
    {
        public override string Name => "BuildThirdPartyLibs";
    
        
/// <summary>"[Optional] + separated list of libraries to compile; if not specified this job will build all libraries it can find builder scripts for"</summary>
        public virtual BuildThirdPartyLibsConfig Libs(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-Libs=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-Libs");
            return (BuildThirdPartyLibsConfig) this;
        }

        
        
/// <summary>"[Optional] a changelist to check out into; if not specified, a changelist will be created"</summary>
        public virtual BuildThirdPartyLibsConfig Changelist(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-Changelist=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-Changelist");
            return (BuildThirdPartyLibsConfig) this;
        }

        
        
/// <summary>"[Optional] Directory to search for the specified Libs"</summary>
        public virtual BuildThirdPartyLibsConfig SearchDir(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-SearchDir=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-SearchDir");
            return (BuildThirdPartyLibsConfig) this;
        }
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    
        public override string Gather()
        {
            Arguments.Insert(0, "BuildThirdPartyLibs");return base.Gather();
        }
    }

    protected readonly BuildThirdPartyLibsConfig BuildThirdPartyLibsStorage = new();
        
/// <summary>Checks that all source files have balanced macros for enabling/disabling optimization, warnings, etc...</summary>
    public  class CheckBalancedMacrosConfig : ToolConfig
    {
        public override string Name => "CheckBalancedMacros";
    
        
/// <summary>"Path to an additional project file to consider"</summary>
        public virtual CheckBalancedMacrosConfig Project(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-Project=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-Project");
            return (CheckBalancedMacrosConfig) this;
        }

        
        
/// <summary>"Path to a file to parse in isolation, for testing"</summary>
        public virtual CheckBalancedMacrosConfig File(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-File=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-File");
            return (CheckBalancedMacrosConfig) this;
        }

        
        
/// <summary>"File name (without path) to exclude from testing"</summary>
        public virtual CheckBalancedMacrosConfig Ignore(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-Ignore=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-Ignore");
            return (CheckBalancedMacrosConfig) this;
        }
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    
        public override string Gather()
        {
            Arguments.Insert(0, "CheckBalancedMacros");return base.Gather();
        }
    }

    protected readonly CheckBalancedMacrosConfig CheckBalancedMacrosStorage = new();
        
    
    public  class CheckCsprojDotNetVersionConfig : ToolConfig
    {
        public override string Name => "CheckCsprojDotNetVersion";
    
        
    
        public virtual CheckCsprojDotNetVersionConfig TargetVersion(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-TargetVersion=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-TargetVersion");
            return (CheckCsprojDotNetVersionConfig) this;
        }
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    
        public override string Gather()
        {
            Arguments.Insert(0, "CheckCsprojDotNetVersion");return base.Gather();
        }
    }

    protected readonly CheckCsprojDotNetVersionConfig CheckCsprojDotNetVersionStorage = new();
        
/// <summary>Audits the current branch for comments denoting a hack that was not meant to leave another branch, following a given format (\"BEGIN XXXX HACK\", where XXXX is one or more tags separated by spaces).
/// Allowed tags may be specified manually on the command line. At least one must match, otherwise it will print a warning.
/// The current branch name and fragments of the branch path will also be added by default, so running from //UE4/Main will add \"//UE4/Main\", \"UE4\", and \"Main\".</summary>
    public  class CheckForHacksConfig : ToolConfig
    {
        public override string Name => "CheckForHacks";
    
        
/// <summary>"Specifies additional tags which are allowed in the BEGIN ... HACK tag list"</summary>
        public virtual CheckForHacksConfig Allow(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-Allow=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-Allow");
            return (CheckForHacksConfig) this;
        }
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    
        public override string Gather()
        {
            Arguments.Insert(0, "CheckForHacks");return base.Gather();
        }
    }

    protected readonly CheckForHacksConfig CheckForHacksStorage = new();
        
/// <summary>Checks that the casing of files within a path on a case-insensitive Perforce server is correct.</summary>
/// <remarks>WARNING: This command might require Perforce</remarks>
    public  class CheckPerforceCaseConfig : ToolConfig
    {
        public override string Name => "CheckPerforceCase";
    
        
/// <summary>"The path to query"</summary>
        public virtual CheckPerforceCaseConfig Path(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-Path" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-Path");
            return (CheckPerforceCaseConfig) this;
        }
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    
        public override string Gather()
        {
            Arguments.Insert(0, "CheckPerforceCase");return base.Gather();
        }
    }

    protected readonly CheckPerforceCaseConfig CheckPerforceCaseStorage = new();
        
/// <summary>Checks a directory for folders which should not be distributed</summary>
    public  class CheckRestrictedFoldersConfig : ToolConfig
    {
        public override string Name => "CheckRestrictedFolders";
    
        
/// <summary>"Path to the base directory containing files to check"</summary>
        public virtual CheckRestrictedFoldersConfig BaseDir(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-BaseDir=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-BaseDir");
            return (CheckRestrictedFoldersConfig) this;
        }

        
        
/// <summary>"Specify names of folders which should be excluded from the list"</summary>
        public virtual CheckRestrictedFoldersConfig Allow(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-Allow=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-Allow");
            return (CheckRestrictedFoldersConfig) this;
        }
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    
        public override string Gather()
        {
            Arguments.Insert(0, "CheckRestrictedFolders");return base.Gather();
        }
    }

    protected readonly CheckRestrictedFoldersConfig CheckRestrictedFoldersStorage = new();
        
/// <summary>Checks that the given target exists, by looking for the relevant receipt.</summary>
    public  class CheckTargetExistsConfig : ToolConfig
    {
        public override string Name => "CheckTargetExists";
    
        
/// <summary>"Name of the target to check"</summary>
        public virtual CheckTargetExistsConfig Target(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-Target=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-Target");
            return (CheckTargetExistsConfig) this;
        }

        
        
/// <summary>"Platform the target was built for"</summary>
        public virtual CheckTargetExistsConfig Platform(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-Platform=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-Platform");
            return (CheckTargetExistsConfig) this;
        }

        
        
/// <summary>"Configuration for the target"</summary>
        public virtual CheckTargetExistsConfig Configuration(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-Configuration=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-Configuration");
            return (CheckTargetExistsConfig) this;
        }

        
        
/// <summary>"Architecture that the target was built for"</summary>
        public virtual CheckTargetExistsConfig Architecture(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-Architecture=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-Architecture");
            return (CheckTargetExistsConfig) this;
        }

        
        
/// <summary>"Path to the project containing the target"</summary>
        public virtual CheckTargetExistsConfig Project(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-Project=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-Project");
            return (CheckTargetExistsConfig) this;
        }
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    
        public override string Gather()
        {
            Arguments.Insert(0, "CheckTargetExists");return base.Gather();
        }
    }

    protected readonly CheckTargetExistsConfig CheckTargetExistsStorage = new();
        
/// <summary>Checks that the installed Xcode version is the version specified.</summary>
    public  class CheckXcodeVersionConfig : ToolConfig
    {
        public override string Name => "CheckXcodeVersion";
    
        
/// <summary>"The expected version number"</summary>
        public virtual CheckXcodeVersionConfig Version(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-Version=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-Version");
            return (CheckXcodeVersionConfig) this;
        }
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    
        public override string Gather()
        {
            Arguments.Insert(0, "CheckXcodeVersion");return base.Gather();
        }
    }

    protected readonly CheckXcodeVersionConfig CheckXcodeVersionStorage = new();
        
/// <summary>Removes folders in an automation report directory that are older than a certain time.</summary>
    public  class CleanAutomationReportsConfig : ToolConfig
    {
        public override string Name => "CleanAutomationReports";
    
        
/// <summary>"Path to the root report directory"</summary>
        public virtual CleanAutomationReportsConfig ReportDir(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-ReportDir=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-ReportDir");
            return (CleanAutomationReportsConfig) this;
        }

        
        
/// <summary>"Number of days to keep reports for"</summary>
        public virtual CleanAutomationReportsConfig Days(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-Days=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-Days");
            return (CleanAutomationReportsConfig) this;
        }

        
        
/// <summary>"How many subdirectories deep to clean, defaults to 0 (top level cleaning)."</summary>
        public virtual CleanAutomationReportsConfig Depth(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-Depth=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-Depth");
            return (CleanAutomationReportsConfig) this;
        }
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    
        public override string Gather()
        {
            Arguments.Insert(0, "CleanAutomationReports");return base.Gather();
        }
    }

    protected readonly CleanAutomationReportsConfig CleanAutomationReportsStorage = new();
        
/// <summary>Removes folders matching a pattern in a given directory that are older than a certain time.</summary>
    public  class CleanFormalBuildsConfig : ToolConfig
    {
        public override string Name => "CleanFormalBuilds";
    
        
/// <summary>"Path to the root directory"</summary>
        public virtual CleanFormalBuildsConfig ParentDir(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-ParentDir=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-ParentDir");
            return (CleanFormalBuildsConfig) this;
        }

        
        
/// <summary>"Pattern to match against"</summary>
        public virtual CleanFormalBuildsConfig SearchPattern(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-SearchPattern=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-SearchPattern");
            return (CleanFormalBuildsConfig) this;
        }

        
        
/// <summary>"Number of days to keep in temp storage (optional - defaults to 4)"</summary>
        public virtual CleanFormalBuildsConfig Days(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-Days=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-Days");
            return (CleanFormalBuildsConfig) this;
        }
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    
        public override string Gather()
        {
            Arguments.Insert(0, "CleanFormalBuilds");return base.Gather();
        }
    }

    protected readonly CleanFormalBuildsConfig CleanFormalBuildsStorage = new();
        
/// <summary>custom code to restructure C++ source code for the new stats system.</summary>
    public  class CodeSurgeryConfig : ToolConfig
    {
        public override string Name => "CodeSurgery";
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    
        public override string Gather()
        {
            Arguments.Insert(0, "CodeSurgery");return base.Gather();
        }
    }

    protected readonly CodeSurgeryConfig CodeSurgeryStorage = new();
        
/// <summary>Copies the current shared cooked build from the network to the local PC</summary>
/// <remarks>WARNING: This command might require Perforce</remarks>
    public  class CopySharedCookedBuildConfig : ToolConfig
    {
        public override string Name => "CopySharedCookedBuild";
    
        
    
        public virtual CopySharedCookedBuildConfig Project(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-project=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-project");
            return (CopySharedCookedBuildConfig) this;
        }

        
        
    
        public virtual CopySharedCookedBuildConfig Platform(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-Platform=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-Platform");
            return (CopySharedCookedBuildConfig) this;
        }

        
        
    
        public virtual CopySharedCookedBuildConfig Onlycopyassetregistry(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-onlycopyassetregistry=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-onlycopyassetregistry");
            return (CopySharedCookedBuildConfig) this;
        }

        
        
    
        public virtual CopySharedCookedBuildConfig Buildcl(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-buildcl=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-buildcl");
            return (CopySharedCookedBuildConfig) this;
        }
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    
        public override string Gather()
        {
            Arguments.Insert(0, "CopySharedCookedBuild");return base.Gather();
        }
    }

    protected readonly CopySharedCookedBuildConfig CopySharedCookedBuildStorage = new();
        
    
    public  class CopyUATConfig : ToolConfig
    {
        public override string Name => "CopyUAT";
    
        
    
        public virtual CopyUATConfig TargetDir(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-TargetDir=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-TargetDir");
            return (CopyUATConfig) this;
        }

        
        
    
        public virtual CopyUATConfig WithLauncher(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-WithLauncher=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-WithLauncher");
            return (CopyUATConfig) this;
        }
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    
        public override string Gather()
        {
            Arguments.Insert(0, "CopyUAT");return base.Gather();
        }
    }

    protected readonly CopyUATConfig CopyUATStorage = new();
        
    
    public  class CryptoKeysConfig : ToolConfig
    {
        public override string Name => "CryptoKeys";
    
        
    
        public virtual CryptoKeysConfig Updateallkeys(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-updateallkeys=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-updateallkeys");
            return (CryptoKeysConfig) this;
        }

        
        
    
        public virtual CryptoKeysConfig Updateencryptionkey(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-updateencryptionkey=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-updateencryptionkey");
            return (CryptoKeysConfig) this;
        }

        
        
    
        public virtual CryptoKeysConfig Updatesigningkey(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-updatesigningkey=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-updatesigningkey");
            return (CryptoKeysConfig) this;
        }

        
        
    
        public virtual CryptoKeysConfig Foreign(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-foreign=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-foreign");
            return (CryptoKeysConfig) this;
        }

        
        
    
        public virtual CryptoKeysConfig Foreigncode(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-foreigncode=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-foreigncode");
            return (CryptoKeysConfig) this;
        }

        
        
    
        public virtual CryptoKeysConfig DestSample(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-DestSample=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-DestSample");
            return (CryptoKeysConfig) this;
        }

        
        
    
        public virtual CryptoKeysConfig ForeignDest(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-ForeignDest=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-ForeignDest");
            return (CryptoKeysConfig) this;
        }

        
        
    
        public virtual CryptoKeysConfig Project(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-project=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-project");
            return (CryptoKeysConfig) this;
        }
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    
        public override string Gather()
        {
            Arguments.Insert(0, "CryptoKeys");return base.Gather();
        }
    }

    protected readonly CryptoKeysConfig CryptoKeysStorage = new();
        
    
    public  class ExtractPaksConfig : ToolConfig
    {
        public override string Name => "ExtractPaks";
    
        
    
        public virtual ExtractPaksConfig Layered(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-layered=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-layered");
            return (ExtractPaksConfig) this;
        }

        
        
    
        public virtual ExtractPaksConfig Sourcedirectory(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-sourcedirectory=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-sourcedirectory");
            return (ExtractPaksConfig) this;
        }

        
        
    
        public virtual ExtractPaksConfig Targetdirectory(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-targetdirectory=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-targetdirectory");
            return (ExtractPaksConfig) this;
        }

        
        
    
        public virtual ExtractPaksConfig Cryptokeysjson(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-cryptokeysjson=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-cryptokeysjson");
            return (ExtractPaksConfig) this;
        }

        
        
    
        public virtual ExtractPaksConfig Customcompressor(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-customcompressor=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-customcompressor");
            return (ExtractPaksConfig) this;
        }

        
        
    
        public virtual ExtractPaksConfig Project(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-project=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-project");
            return (ExtractPaksConfig) this;
        }
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    
        public override string Gather()
        {
            Arguments.Insert(0, "ExtractPaks");return base.Gather();
        }
    }

    protected readonly ExtractPaksConfig ExtractPaksStorage = new();
        
/// <summary>Command to perform additional steps to prepare an installed build.</summary>
    public  class FinalizeInstalledBuildConfig : ToolConfig
    {
        public override string Name => "FinalizeInstalledBuild";
    
        
/// <summary>"Root Directory of the installed build data (required)"</summary>
        public virtual FinalizeInstalledBuildConfig OutputDir(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-OutputDir=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-OutputDir");
            return (FinalizeInstalledBuildConfig) this;
        }

        
        
/// <summary>"List of platforms that should be marked as only supporting content projects (optional)"</summary>
        public virtual FinalizeInstalledBuildConfig ContentOnlyPlatforms(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-ContentOnlyPlatforms=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-ContentOnlyPlatforms");
            return (FinalizeInstalledBuildConfig) this;
        }

        
        
/// <summary>"List of platforms to add"</summary>
        public virtual FinalizeInstalledBuildConfig Platforms(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-Platforms=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-Platforms");
            return (FinalizeInstalledBuildConfig) this;
        }

        
        
/// <summary>"List of architectures that are used for a given platform (optional)"
/// "List of GPU architectures that are used for a given platform (optional)"</summary>
        public virtual FinalizeInstalledBuildConfig Platform(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-Platform" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-Platform");
            return (FinalizeInstalledBuildConfig) this;
        }

        
        
/// <summary>"Name to give this build for analytics purposes (optional)"</summary>
        public virtual FinalizeInstalledBuildConfig AnalyticsTypeOverride(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-AnalyticsTypeOverride=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-AnalyticsTypeOverride");
            return (FinalizeInstalledBuildConfig) this;
        }

        
        
    
        public virtual FinalizeInstalledBuildConfig Project(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-Project=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-Project");
            return (FinalizeInstalledBuildConfig) this;
        }

        
        
    
        public virtual FinalizeInstalledBuildConfig Architectures(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-Architectures=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-Architectures");
            return (FinalizeInstalledBuildConfig) this;
        }

        
        
    
        public virtual FinalizeInstalledBuildConfig GPUArchitectures(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-GPUArchitectures=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-GPUArchitectures");
            return (FinalizeInstalledBuildConfig) this;
        }
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    
        public override string Gather()
        {
            Arguments.Insert(0, "FinalizeInstalledBuild");return base.Gather();
        }
    }

    protected readonly FinalizeInstalledBuildConfig FinalizeInstalledBuildStorage = new();
        
/// <summary>Fixes the case of files on a case-insensitive Perforce server by removing and re-adding them.</summary>
/// <remarks>WARNING: This command might require Perforce</remarks>
    public  class FixPerforceCaseConfig : ToolConfig
    {
        public override string Name => "FixPerforceCase";
    
        
/// <summary>"Pattern for source files to match. Should be a full depot path. May end with a wildcard."</summary>
        public virtual FixPerforceCaseConfig Source(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-Source" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-Source");
            return (FixPerforceCaseConfig) this;
        }

        
        
/// <summary>"Pattern for target files. Should be identical to source, except for case."</summary>
        public virtual FixPerforceCaseConfig Target(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-Target" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-Target");
            return (FixPerforceCaseConfig) this;
        }
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    
        public override string Gather()
        {
            Arguments.Insert(0, "FixPerforceCase");return base.Gather();
        }
    }

    protected readonly FixPerforceCaseConfig FixPerforceCaseStorage = new();
        
    
    public  class FixupRedirectsConfig : ToolConfig
    {
        public override string Name => "FixupRedirects";
    
        
    
        public virtual FixupRedirectsConfig Project(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-project=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-project");
            return (FixupRedirectsConfig) this;
        }
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    
        public override string Gather()
        {
            Arguments.Insert(0, "FixupRedirects");return base.Gather();
        }
    }

    protected readonly FixupRedirectsConfig FixupRedirectsStorage = new();
        
/// <summary>@"Generates IOS debug symbols for a remote project."</summary>
    public  class GenerateDSYMConfig : ToolConfig
    {
        public override string Name => "GenerateDSYM";
    
        
/// <summary>@"Project name (required), i.e: -project=QAGame"</summary>
        public virtual GenerateDSYMConfig Project(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-project=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-project");
            return (GenerateDSYMConfig) this;
        }

        
        
/// <summary>@"Project configuration (required), i.e: -config=Development"</summary>
        public virtual GenerateDSYMConfig Config(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-config=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-config");
            return (GenerateDSYMConfig) this;
        }
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    
        public override string Gather()
        {
            Arguments.Insert(0, "GenerateDSYM");return base.Gather();
        }
    }

    protected readonly GenerateDSYMConfig GenerateDSYMStorage = new();
        
/// <summary>UAT command to call into the integrated IPhonePackager code</summary>
    public  class IPhonePackagerConfig : ToolConfig
    {
        public override string Name => "IPhonePackager";
    
        
    
        public virtual IPhonePackagerConfig Cmd(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-cmd=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-cmd");
            return (IPhonePackagerConfig) this;
        }
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    
        public override string Gather()
        {
            Arguments.Insert(0, "IPhonePackager");return base.Gather();
        }
    }

    protected readonly IPhonePackagerConfig IPhonePackagerStorage = new();
        
    
    public  class LauncherLocalizationConfig : ToolConfig
    {
        public override string Name => "LauncherLocalization";
    
        
    
        public virtual LauncherLocalizationConfig BuildEditor(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-BuildEditor=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-BuildEditor");
            return (LauncherLocalizationConfig) this;
        }
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    
        public override string Gather()
        {
            Arguments.Insert(0, "LauncherLocalization");return base.Gather();
        }
    }

    protected readonly LauncherLocalizationConfig LauncherLocalizationStorage = new();
        
    
    public  class ListMobileDevicesConfig : ToolConfig
    {
        public override string Name => "ListMobileDevices";
    
        
    
        public virtual ListMobileDevicesConfig Android(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-android=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-android");
            return (ListMobileDevicesConfig) this;
        }

        
        
    
        public virtual ListMobileDevicesConfig Ios(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-ios=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-ios");
            return (ListMobileDevicesConfig) this;
        }
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    
        public override string Gather()
        {
            Arguments.Insert(0, "ListMobileDevices");return base.Gather();
        }
    }

    protected readonly ListMobileDevicesConfig ListMobileDevicesStorage = new();
        
/// <summary>Lists TPS files associated with any source used to build a specified target(s). Grabs TPS files associated with source modules, content, and engine shaders.</summary>
    public  class ListThirdPartySoftwareConfig : ToolConfig
    {
        public override string Name => "ListThirdPartySoftware";
    
        
/// <summary>"One or more UBT command lines to enumerate associated TPS files for (eg. UE4Game Win64 Development)."</summary>
        public virtual ListThirdPartySoftwareConfig Target(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-Target=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-Target");
            return (ListThirdPartySoftwareConfig) this;
        }

        
        
    
        public virtual ListThirdPartySoftwareConfig Project(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-Project=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-Project");
            return (ListThirdPartySoftwareConfig) this;
        }
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    
        public override string Gather()
        {
            Arguments.Insert(0, "ListThirdPartySoftware");return base.Gather();
        }
    }

    protected readonly ListThirdPartySoftwareConfig ListThirdPartySoftwareStorage = new();
        
/// <summary>Updates the external localization data using the arguments provided.</summary>
    public  class LocalizeConfig : ToolConfig
    {
        public override string Name => "Localize";
    
        
/// <summary>"Optional root-path to the project we're gathering for (defaults to CmdEnv.LocalRoot if unset)."</summary>
        public virtual LocalizeConfig UEProjectRoot(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-UEProjectRoot=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-UEProjectRoot");
            return (LocalizeConfig) this;
        }

        
        
/// <summary>"Sub-path to the project we're gathering for (relative to UEProjectRoot)."</summary>
        public virtual LocalizeConfig UEProjectDirectory(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-UEProjectDirectory=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-UEProjectDirectory");
            return (LocalizeConfig) this;
        }

        
        
/// <summary>"Optional name of the project we're gathering for (should match its .uproject file, eg QAGame)."</summary>
        public virtual LocalizeConfig UEProjectName(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-UEProjectName=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-UEProjectName");
            return (LocalizeConfig) this;
        }

        
        
/// <summary>"Comma separated list of the projects to gather text from."</summary>
        public virtual LocalizeConfig LocalizationProjectNames(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-LocalizationProjectNames=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-LocalizationProjectNames");
            return (LocalizeConfig) this;
        }

        
        
/// <summary>"Optional suffix to use when uploading the new data to the localization provider."</summary>
        public virtual LocalizeConfig LocalizationBranch(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-LocalizationBranch" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-LocalizationBranch");
            return (LocalizeConfig) this;
        }

        
        
/// <summary>"Optional localization provide override."</summary>
        public virtual LocalizeConfig LocalizationProvider(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-LocalizationProvider=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-LocalizationProvider");
            return (LocalizeConfig) this;
        }

        
        
/// <summary>"Optional comma separated list of localization steps to perform [Download, Gather, Import, Export, Compile, GenerateReports, Upload] (default is all). Only valid for projects using a modular config."</summary>
        public virtual LocalizeConfig LocalizationSteps(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-LocalizationSteps=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-LocalizationSteps");
            return (LocalizeConfig) this;
        }

        
        
/// <summary>"Optional flag to include plugins from within the given UEProjectDirectory as part of the gather. This may optionally specify a comma separated list of the specific plugins to gather (otherwise all plugins will be gathered)."</summary>
        public virtual LocalizeConfig IncludePlugins(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-IncludePlugins=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-IncludePlugins");
            return (LocalizeConfig) this;
        }

        
        
/// <summary>"Optional comma separated list of plugins to exclude from the gather."</summary>
        public virtual LocalizeConfig ExcludePlugins(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-ExcludePlugins=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-ExcludePlugins");
            return (LocalizeConfig) this;
        }

        
        
/// <summary>"Optional flag to include platforms from within the given UEProjectDirectory as part of the gather."</summary>
        public virtual LocalizeConfig IncludePlatforms(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-IncludePlatforms=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-IncludePlatforms");
            return (LocalizeConfig) this;
        }

        
        
/// <summary>"Optional arguments to pass to the gather process."</summary>
        public virtual LocalizeConfig AdditionalCommandletArguments(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-AdditionalCommandletArguments=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-AdditionalCommandletArguments");
            return (LocalizeConfig) this;
        }

        
        
/// <summary>"Run the gather processes for a single batch in parallel rather than sequence."</summary>
        public virtual LocalizeConfig ParallelGather(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-ParallelGather=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-ParallelGather");
            return (LocalizeConfig) this;
        }
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    
        public override string Gather()
        {
            Arguments.Insert(0, "Localize");return base.Gather();
        }
    }

    protected readonly LocalizeConfig LocalizeStorage = new();
        
    
    public  class ExportMcpTemplatesConfig : ToolConfig
    {
        public override string Name => "ExportMcpTemplates";
    
        
/// <summary>"Optional.  Only submit generated loc files, do not submit any other generated file."</summary>
        public virtual ExportMcpTemplatesConfig OnlyLoc(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-OnlyLoc=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-OnlyLoc");
            return (ExportMcpTemplatesConfig) this;
        }

        
        
/// <summary>"Optional.  Do not include the markup in the CL description to allow robomerging to other branches."</summary>
        public virtual ExportMcpTemplatesConfig NoRobomerge(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-NoRobomerge=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-NoRobomerge");
            return (ExportMcpTemplatesConfig) this;
        }

        
        
    
        public virtual ExportMcpTemplatesConfig ProjectName(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-ProjectName=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-ProjectName");
            return (ExportMcpTemplatesConfig) this;
        }

        
        
    
        public virtual ExportMcpTemplatesConfig Commandlet(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-Commandlet=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-Commandlet");
            return (ExportMcpTemplatesConfig) this;
        }
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    
        public override string Gather()
        {
            Arguments.Insert(0, "ExportMcpTemplates");return base.Gather();
        }
    }

    protected readonly ExportMcpTemplatesConfig ExportMcpTemplatesStorage = new();
        
    
    public  class LocaliseConfig : ToolConfig
    {
        public override string Name => "Localise";
    
        
/// <summary>"Optional root-path to the project we're gathering for (defaults to CmdEnv.LocalRoot if unset)."</summary>
        public virtual LocaliseConfig UEProjectRoot(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-UEProjectRoot=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-UEProjectRoot");
            return (LocaliseConfig) this;
        }

        
        
/// <summary>"Sub-path to the project we're gathering for (relative to UEProjectRoot)."</summary>
        public virtual LocaliseConfig UEProjectDirectory(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-UEProjectDirectory=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-UEProjectDirectory");
            return (LocaliseConfig) this;
        }

        
        
/// <summary>"Optional name of the project we're gathering for (should match its .uproject file, eg QAGame)."</summary>
        public virtual LocaliseConfig UEProjectName(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-UEProjectName=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-UEProjectName");
            return (LocaliseConfig) this;
        }

        
        
/// <summary>"Comma separated list of the projects to gather text from."</summary>
        public virtual LocaliseConfig LocalizationProjectNames(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-LocalizationProjectNames=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-LocalizationProjectNames");
            return (LocaliseConfig) this;
        }

        
        
/// <summary>"Optional suffix to use when uploading the new data to the localization provider."</summary>
        public virtual LocaliseConfig LocalizationBranch(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-LocalizationBranch" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-LocalizationBranch");
            return (LocaliseConfig) this;
        }

        
        
/// <summary>"Optional localization provide override."</summary>
        public virtual LocaliseConfig LocalizationProvider(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-LocalizationProvider=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-LocalizationProvider");
            return (LocaliseConfig) this;
        }

        
        
/// <summary>"Optional comma separated list of localization steps to perform [Download, Gather, Import, Export, Compile, GenerateReports, Upload] (default is all). Only valid for projects using a modular config."</summary>
        public virtual LocaliseConfig LocalizationSteps(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-LocalizationSteps=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-LocalizationSteps");
            return (LocaliseConfig) this;
        }

        
        
/// <summary>"Optional flag to include plugins from within the given UEProjectDirectory as part of the gather. This may optionally specify a comma separated list of the specific plugins to gather (otherwise all plugins will be gathered)."</summary>
        public virtual LocaliseConfig IncludePlugins(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-IncludePlugins=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-IncludePlugins");
            return (LocaliseConfig) this;
        }

        
        
/// <summary>"Optional comma separated list of plugins to exclude from the gather."</summary>
        public virtual LocaliseConfig ExcludePlugins(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-ExcludePlugins=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-ExcludePlugins");
            return (LocaliseConfig) this;
        }

        
        
/// <summary>"Optional flag to include platforms from within the given UEProjectDirectory as part of the gather."</summary>
        public virtual LocaliseConfig IncludePlatforms(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-IncludePlatforms=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-IncludePlatforms");
            return (LocaliseConfig) this;
        }

        
        
/// <summary>"Optional arguments to pass to the gather process."</summary>
        public virtual LocaliseConfig AdditionalCommandletArguments(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-AdditionalCommandletArguments=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-AdditionalCommandletArguments");
            return (LocaliseConfig) this;
        }

        
        
/// <summary>"Run the gather processes for a single batch in parallel rather than sequence."</summary>
        public virtual LocaliseConfig ParallelGather(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-ParallelGather=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-ParallelGather");
            return (LocaliseConfig) this;
        }
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    
        public override string Gather()
        {
            Arguments.Insert(0, "Localise");return base.Gather();
        }
    }

    protected readonly LocaliseConfig LocaliseStorage = new();
        
/// <summary>Opens the specified project.</summary>
    public  class OpenEditorConfig : ToolConfig
    {
        public override string Name => "OpenEditor";
    
        
/// <summary>"Project to open. Will search current path and paths in ueprojectdirs. If omitted will open vanilla UE4Editor"</summary>
        public virtual OpenEditorConfig Project(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-project=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-project");
            return (OpenEditorConfig) this;
        }
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    
        public override string Gather()
        {
            Arguments.Insert(0, "OpenEditor");return base.Gather();
        }
    }

    protected readonly OpenEditorConfig OpenEditorStorage = new();
        
/// <summary>Parses Visual C++ timing information (as generated by UBT with the -Timing flag), and converts it into JSON format which can be visualized using the chrome://tracing tab</summary>
    public  class ParseMsvcTimingInfoConfig : ToolConfig
    {
        public override string Name => "ParseMsvcTimingInfo";
    
        
/// <summary>"Path to the input file"</summary>
        public virtual ParseMsvcTimingInfoConfig File(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-File=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-File");
            return (ParseMsvcTimingInfoConfig) this;
        }
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    
        public override string Gather()
        {
            Arguments.Insert(0, "ParseMsvcTimingInfo");return base.Gather();
        }
    }

    protected readonly ParseMsvcTimingInfoConfig ParseMsvcTimingInfoStorage = new();
        
/// <summary>Rewrites include directives for headers in public include paths to make them relative to the 'Public' folder.</summary>
    public  class RebasePublicIncludePathsConfig : ToolConfig
    {
        public override string Name => "RebasePublicIncludePaths";
    
        
/// <summary>"Specifies a project to include in the scan for source files. May be specified multiple times."</summary>
        public virtual RebasePublicIncludePathsConfig Project(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-Project=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-Project");
            return (RebasePublicIncludePathsConfig) this;
        }

        
        
/// <summary>"Specifies the directory containing files to update. This may be a project/engine directory, or a subfolder."</summary>
        public virtual RebasePublicIncludePathsConfig UpdateDir(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-UpdateDir=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-UpdateDir");
            return (RebasePublicIncludePathsConfig) this;
        }

        
        
/// <summary>"If set, causes the modified files to be written. Files will be checked out from Perforce if possible."</summary>
        public virtual RebasePublicIncludePathsConfig Write(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-Write=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-Write");
            return (RebasePublicIncludePathsConfig) this;
        }
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    
        public override string Gather()
        {
            Arguments.Insert(0, "RebasePublicIncludePaths");return base.Gather();
        }
    }

    protected readonly RebasePublicIncludePathsConfig RebasePublicIncludePathsStorage = new();
        
/// <remarks>WARNING: This command might require Perforce</remarks>
    public  class RebuildHLODConfig : ToolConfig
    {
        public override string Name => "RebuildHLOD";
    
        
    
        public virtual RebuildHLODConfig DelaySubmission(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-DelaySubmission=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-DelaySubmission");
            return (RebuildHLODConfig) this;
        }

        
        
    
        public virtual RebuildHLODConfig Nobuild(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-nobuild=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-nobuild");
            return (RebuildHLODConfig) this;
        }

        
        
    
        public virtual RebuildHLODConfig BuildOptions(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-BuildOptions=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-BuildOptions");
            return (RebuildHLODConfig) this;
        }

        
        
    
        public virtual RebuildHLODConfig StakeholdersEmailAddresses(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-StakeholdersEmailAddresses=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-StakeholdersEmailAddresses");
            return (RebuildHLODConfig) this;
        }

        
        
    
        public virtual RebuildHLODConfig Robomerge(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-Robomerge=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-Robomerge");
            return (RebuildHLODConfig) this;
        }

        
        
    
        public virtual RebuildHLODConfig CommandletTargetName(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-CommandletTargetName=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-CommandletTargetName");
            return (RebuildHLODConfig) this;
        }

        
        
    
        public virtual RebuildHLODConfig Project(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-project=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-project");
            return (RebuildHLODConfig) this;
        }
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    
        public override string Gather()
        {
            Arguments.Insert(0, "RebuildHLOD");return base.Gather();
        }
    }

    protected readonly RebuildHLODConfig RebuildHLODStorage = new();
        
/// <summary>Helper command used for rebuilding a projects light maps</summary>
/// <remarks>WARNING: This command might require Perforce</remarks>
    public  class RebuildLightMapsConfig : ToolConfig
    {
        public override string Name => "RebuildLightMaps";
    
        
/// <summary>"Absolute path to a .uproject file"</summary>
        public virtual RebuildLightMapsConfig Project(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-Project=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-Project");
            return (RebuildLightMapsConfig) this;
        }

        
        
/// <summary>"A list of '+' delimited maps we wish to build lightmaps for."</summary>
        public virtual RebuildLightMapsConfig MapsToRebuildLightMaps(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-MapsToRebuildLightMaps" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-MapsToRebuildLightMaps");
            return (RebuildLightMapsConfig) this;
        }

        
        
/// <summary>"The Target used in running the commandlet"</summary>
        public virtual RebuildLightMapsConfig CommandletTargetName(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-CommandletTargetName=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-CommandletTargetName");
            return (RebuildLightMapsConfig) this;
        }

        
        
/// <summary>"Users to notify of completion"</summary>
        public virtual RebuildLightMapsConfig StakeholdersEmailAddresses(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-StakeholdersEmailAddresses=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-StakeholdersEmailAddresses");
            return (RebuildLightMapsConfig) this;
        }

        
        
    
        public virtual RebuildLightMapsConfig Nobuild(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-nobuild=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-nobuild");
            return (RebuildLightMapsConfig) this;
        }
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    
        public override string Gather()
        {
            Arguments.Insert(0, "RebuildLightMaps");return base.Gather();
        }
    }

    protected readonly RebuildLightMapsConfig RebuildLightMapsStorage = new();
        
/// <summary>UAT command to run performance test demo using different RHIs and compare results</summary>
    public  class RecordPerformanceConfig : ToolConfig
    {
        public override string Name => "RecordPerformance";
    
        
    
        public virtual RecordPerformanceConfig DemoIndex(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-DemoIndex=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-DemoIndex");
            return (RecordPerformanceConfig) this;
        }

        
        
    
        public virtual RecordPerformanceConfig NumOfRuns(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-NumOfRuns=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-NumOfRuns");
            return (RecordPerformanceConfig) this;
        }

        
        
    
        public virtual RecordPerformanceConfig SkipBuild(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-SkipBuild=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-SkipBuild");
            return (RecordPerformanceConfig) this;
        }
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    
        public override string Gather()
        {
            Arguments.Insert(0, "RecordPerformance");return base.Gather();
        }
    }

    protected readonly RecordPerformanceConfig RecordPerformanceStorage = new();
        
    
    public  class ReplaceAssetsUsingManifestConfig : ToolConfig
    {
        public override string Name => "ReplaceAssetsUsingManifest";
    
        
    
        public virtual ReplaceAssetsUsingManifestConfig ProjectPath(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-ProjectPath=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-ProjectPath");
            return (ReplaceAssetsUsingManifestConfig) this;
        }

        
        
    
        public virtual ReplaceAssetsUsingManifestConfig ManifestFile(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-ManifestFile=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-ManifestFile");
            return (ReplaceAssetsUsingManifestConfig) this;
        }

        
        
    
        public virtual ReplaceAssetsUsingManifestConfig UE4Exe(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-UE4Exe=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-UE4Exe");
            return (ReplaceAssetsUsingManifestConfig) this;
        }

        
        
    
        public virtual ReplaceAssetsUsingManifestConfig ReplacedPaths(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-ReplacedPaths=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-ReplacedPaths");
            return (ReplaceAssetsUsingManifestConfig) this;
        }

        
        
    
        public virtual ReplaceAssetsUsingManifestConfig ReplacedClasses(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-ReplacedClasses=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-ReplacedClasses");
            return (ReplaceAssetsUsingManifestConfig) this;
        }

        
        
    
        public virtual ReplaceAssetsUsingManifestConfig ExcludedPaths(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-ExcludedPaths=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-ExcludedPaths");
            return (ReplaceAssetsUsingManifestConfig) this;
        }

        
        
    
        public virtual ReplaceAssetsUsingManifestConfig ExcludedClasses(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-ExcludedClasses=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-ExcludedClasses");
            return (ReplaceAssetsUsingManifestConfig) this;
        }

        
        
    
        public virtual ReplaceAssetsUsingManifestConfig BaseDir(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-BaseDir=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-BaseDir");
            return (ReplaceAssetsUsingManifestConfig) this;
        }

        
        
    
        public virtual ReplaceAssetsUsingManifestConfig AssetSourcePath(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-AssetSourcePath=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-AssetSourcePath");
            return (ReplaceAssetsUsingManifestConfig) this;
        }

        
        
    
        public virtual ReplaceAssetsUsingManifestConfig UseExistingManifest(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-UseExistingManifest=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-UseExistingManifest");
            return (ReplaceAssetsUsingManifestConfig) this;
        }
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    
        public override string Gather()
        {
            Arguments.Insert(0, "ReplaceAssetsUsingManifest");return base.Gather();
        }
    }

    protected readonly ReplaceAssetsUsingManifestConfig ReplaceAssetsUsingManifestStorage = new();
        
/// <remarks>WARNING: This command might require Perforce</remarks>
    public  class ResavePackagesConfig : ToolConfig
    {
        public override string Name => "ResavePackages";
    
        
    
        public virtual ResavePackagesConfig Nobuild(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-nobuild=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-nobuild");
            return (ResavePackagesConfig) this;
        }

        
        
    
        public virtual ResavePackagesConfig StakeholdersEmailAddresses(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-StakeholdersEmailAddresses=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-StakeholdersEmailAddresses");
            return (ResavePackagesConfig) this;
        }

        
        
    
        public virtual ResavePackagesConfig CommandletTargetName(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-CommandletTargetName=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-CommandletTargetName");
            return (ResavePackagesConfig) this;
        }

        
        
    
        public virtual ResavePackagesConfig Project(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-project=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-project");
            return (ResavePackagesConfig) this;
        }
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    
        public override string Gather()
        {
            Arguments.Insert(0, "ResavePackages");return base.Gather();
        }
    }

    protected readonly ResavePackagesConfig ResavePackagesStorage = new();
        
/// <summary>Re-save all the plugin descriptors under a given path, optionally applying standard metadata to them</summary>
    public  class ResavePluginDescriptorsConfig : ToolConfig
    {
        public override string Name => "ResavePluginDescriptors";
    
        
/// <summary>"The root directory to enumerate plugins under"</summary>
        public virtual ResavePluginDescriptorsConfig RootDir(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-RootDir=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-RootDir");
            return (ResavePluginDescriptorsConfig) this;
        }

        
        
/// <summary>"Author to specify in the 'Created By' field."</summary>
        public virtual ResavePluginDescriptorsConfig CreatedBy(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-CreatedBy=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-CreatedBy");
            return (ResavePluginDescriptorsConfig) this;
        }

        
        
/// <summary>"URL to link to for the 'Created By' field."</summary>
        public virtual ResavePluginDescriptorsConfig CreatedByUrl(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-CreatedByUrl=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-CreatedByUrl");
            return (ResavePluginDescriptorsConfig) this;
        }

        
        
/// <summary>"Remove the read-only flag from output files"</summary>
        public virtual ResavePluginDescriptorsConfig Force(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-Force=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-Force");
            return (ResavePluginDescriptorsConfig) this;
        }
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    
        public override string Gather()
        {
            Arguments.Insert(0, "ResavePluginDescriptors");return base.Gather();
        }
    }

    protected readonly ResavePluginDescriptorsConfig ResavePluginDescriptorsStorage = new();
        
/// <summary>Re-save all the project descriptors under a given path</summary>
    public  class ResaveProjectDescriptorsConfig : ToolConfig
    {
        public override string Name => "ResaveProjectDescriptors";
    
        
/// <summary>"Sets the EngineAssociation field for each project"</summary>
        public virtual ResaveProjectDescriptorsConfig EngineAssociation(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-EngineAssociation=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-EngineAssociation");
            return (ResaveProjectDescriptorsConfig) this;
        }

        
        
/// <summary>"Remove the read-only flag from output files"</summary>
        public virtual ResaveProjectDescriptorsConfig Force(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-Force=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-Force");
            return (ResaveProjectDescriptorsConfig) this;
        }

        
        
    
        public virtual ResaveProjectDescriptorsConfig RootDir(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-RootDir=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-RootDir");
            return (ResaveProjectDescriptorsConfig) this;
        }
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    
        public override string Gather()
        {
            Arguments.Insert(0, "ResaveProjectDescriptors");return base.Gather();
        }
    }

    protected readonly ResaveProjectDescriptorsConfig ResaveProjectDescriptorsStorage = new();
        
/// <remarks>WARNING: This command might require Perforce</remarks>
    public  class RunP4ReconcileConfig : ToolConfig
    {
        public override string Name => "RunP4Reconcile";
    
        
    
        public virtual RunP4ReconcileConfig Paths(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-Paths=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-Paths");
            return (RunP4ReconcileConfig) this;
        }

        
        
    
        public virtual RunP4ReconcileConfig Description(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-Description=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-Description");
            return (RunP4ReconcileConfig) this;
        }

        
        
    
        public virtual RunP4ReconcileConfig FileType(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-FileType=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-FileType");
            return (RunP4ReconcileConfig) this;
        }
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    
        public override string Gather()
        {
            Arguments.Insert(0, "RunP4Reconcile");return base.Gather();
        }
    }

    protected readonly RunP4ReconcileConfig RunP4ReconcileStorage = new();
        
/// <summary>Copy all the binaries for a target into a different folder. Can be restored using the UnstashTarget command. Useful for A/B testing.</summary>
    public  class StashTargetConfig : ToolConfig
    {
        public override string Name => "StashTarget";
    
        
/// <summary>"Name of the target"</summary>
        public virtual StashTargetConfig _Name(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-Name" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-Name");
            return (StashTargetConfig) this;
        }

        
        
/// <summary>"Platform that the target was built for"</summary>
        public virtual StashTargetConfig Platform(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-Platform" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-Platform");
            return (StashTargetConfig) this;
        }

        
        
/// <summary>"Architecture that the target was built for"</summary>
        public virtual StashTargetConfig Configuration(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-Configuration" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-Configuration");
            return (StashTargetConfig) this;
        }

        
        
/// <summary>"Architecture that the target was built for"</summary>
        public virtual StashTargetConfig Architecture(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-Architecture" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-Architecture");
            return (StashTargetConfig) this;
        }

        
        
/// <summary>"Project file for the target"</summary>
        public virtual StashTargetConfig Project(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-Project" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-Project");
            return (StashTargetConfig) this;
        }

        
        
/// <summary>"Output directory to store the stashed binaries"</summary>
        public virtual StashTargetConfig To(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-To" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-To");
            return (StashTargetConfig) this;
        }
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    
        public override string Gather()
        {
            Arguments.Insert(0, "StashTarget");return base.Gather();
        }
    }

    protected readonly StashTargetConfig StashTargetStorage = new();
        
/// <summary>Copy all the binaries from a target back into the root directory. Use in combination with the StashTarget command.</summary>
    public  class UnstashTargetConfig : ToolConfig
    {
        public override string Name => "UnstashTarget";
    
        
/// <summary>"Directory to copy from"</summary>
        public virtual UnstashTargetConfig From(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-From" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-From");
            return (UnstashTargetConfig) this;
        }
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    
        public override string Gather()
        {
            Arguments.Insert(0, "UnstashTarget");return base.Gather();
        }
    }

    protected readonly UnstashTargetConfig UnstashTargetStorage = new();
        
/// <summary>Submits a generated Utilization report to EC</summary>
    public  class SubmitUtilizationReportToECConfig : ToolConfig
    {
        public override string Name => "SubmitUtilizationReportToEC";
    
        
    
        public virtual SubmitUtilizationReportToECConfig Day(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-Day=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-Day");
            return (SubmitUtilizationReportToECConfig) this;
        }

        
        
    
        public virtual SubmitUtilizationReportToECConfig FileName(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-FileName=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-FileName");
            return (SubmitUtilizationReportToECConfig) this;
        }
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    
        public override string Gather()
        {
            Arguments.Insert(0, "SubmitUtilizationReportToEC");return base.Gather();
        }
    }

    protected readonly SubmitUtilizationReportToECConfig SubmitUtilizationReportToECStorage = new();
        
/// <summary>Attempts to sync UGS binaries for the specified project at the currently synced CL of the project/engine folders</summary>
/// <remarks>WARNING: This command might require Perforce</remarks>
    public  class SyncBinariesFromUGSConfig : ToolConfig
    {
        public override string Name => "SyncBinariesFromUGS";
    
        
/// <summary>"Project to sync. Will search current path and paths in ueprojectdirs."</summary>
        public virtual SyncBinariesFromUGSConfig Project(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-project=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-project");
            return (SyncBinariesFromUGSConfig) this;
        }

        
        
/// <summary>"If specified show actions but do not perform them."
/// 
/// If true no actions will be performed
/// </summary>
        public virtual SyncBinariesFromUGSConfig Preview(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-preview=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-preview");
            return (SyncBinariesFromUGSConfig) this;
        }
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    
        public override string Gather()
        {
            Arguments.Insert(0, "SyncBinariesFromUGS");return base.Gather();
        }
    }

    protected readonly SyncBinariesFromUGSConfig SyncBinariesFromUGSStorage = new();
        
/// <summary>Merge one or more remote DDC shares into a local share, taking files with the newest timestamps and keeping the size below a certain limit</summary>
    public  class SyncDDCConfig : ToolConfig
    {
        public override string Name => "SyncDDC";
    
        
/// <summary>"The local DDC directory to add/remove files from"</summary>
        public virtual SyncDDCConfig LocalDir(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-LocalDir=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-LocalDir");
            return (SyncDDCConfig) this;
        }

        
        
/// <summary>"The remote DDC directory to pull from. May be specified multiple times."</summary>
        public virtual SyncDDCConfig RemoteDir(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-RemoteDir=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-RemoteDir");
            return (SyncDDCConfig) this;
        }

        
        
/// <summary>"Maximum size of the local DDC directory. TB/MB/GB/KB units are allowed."</summary>
        public virtual SyncDDCConfig MaxSize(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-MaxSize=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-MaxSize");
            return (SyncDDCConfig) this;
        }

        
        
/// <summary>"Only copies files with modified timestamps in the past number of days."</summary>
        public virtual SyncDDCConfig MaxDays(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-MaxDays=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-MaxDays");
            return (SyncDDCConfig) this;
        }

        
        
/// <summary>"Maximum time to run for. h/m/s units are allowed."</summary>
        public virtual SyncDDCConfig TimeLimit(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-TimeLimit=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-TimeLimit");
            return (SyncDDCConfig) this;
        }

        
        
    
        public virtual SyncDDCConfig Preview(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-Preview=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-Preview");
            return (SyncDDCConfig) this;
        }
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    
        public override string Gather()
        {
            Arguments.Insert(0, "SyncDDC");return base.Gather();
        }
    }

    protected readonly SyncDDCConfig SyncDDCStorage = new();
        
/// <summary>Creates a temporary client and syncs a path from Perforce.</summary>
/// <remarks>WARNING: This command might require Perforce</remarks>
    public  class SyncDepotPathConfig : ToolConfig
    {
        public override string Name => "SyncDepotPath";
    
        
    
        public virtual SyncDepotPathConfig DepotPath(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-DepotPath=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-DepotPath");
            return (SyncDepotPathConfig) this;
        }

        
        
    
        public virtual SyncDepotPathConfig OutputDir(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-OutputDir=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-OutputDir");
            return (SyncDepotPathConfig) this;
        }
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    
        public override string Gather()
        {
            Arguments.Insert(0, "SyncDepotPath");return base.Gather();
        }
    }

    protected readonly SyncDepotPathConfig SyncDepotPathStorage = new();
        
/// <summary>Syncs and builds all the binaries required for a project</summary>
/// <remarks>WARNING: This command might require Perforce</remarks>
    public  class SyncProjectConfig : ToolConfig
    {
        public override string Name => "SyncProject";
    
        
/// <summary>"Project to sync. Will search current path and paths in ueprojectdirs. If omitted will sync projectdirs"</summary>
        public virtual SyncProjectConfig Project(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-project=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-project");
            return (SyncProjectConfig) this;
        }

        
        
/// <summary>"How many threads to use when syncing. Default=2. When &gt;1 all output happens first"</summary>
        public virtual SyncProjectConfig Threads(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-threads=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-threads");
            return (SyncProjectConfig) this;
        }

        
        
/// <summary>"Changelist to sync to. If omitted will sync to latest CL of the workspace path. 0 Will Remove files!"</summary>
        public virtual SyncProjectConfig Cl(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-cl=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-cl");
            return (SyncProjectConfig) this;
        }

        
        
/// <summary>"Clean old files before building"</summary>
        public virtual SyncProjectConfig Clean(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-clean=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-clean");
            return (SyncProjectConfig) this;
        }

        
        
/// <summary>"Build after syncing"</summary>
        public virtual SyncProjectConfig Build(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-build=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-build");
            return (SyncProjectConfig) this;
        }

        
        
/// <summary>"Open project editor after syncing"</summary>
        public virtual SyncProjectConfig Open(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-open=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-open");
            return (SyncProjectConfig) this;
        }

        
        
/// <summary>"Generate project files after syncing"</summary>
        public virtual SyncProjectConfig Generate(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-generate=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-generate");
            return (SyncProjectConfig) this;
        }

        
        
/// <summary>"force sync files (files opened for edit will be untouched)"</summary>
        public virtual SyncProjectConfig Force(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-force=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-force");
            return (SyncProjectConfig) this;
        }

        
        
/// <summary>"Shows commands that will be executed but performs no operations"</summary>
        public virtual SyncProjectConfig Preview(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-preview=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-preview");
            return (SyncProjectConfig) this;
        }

        
        
/// <summary>"Only sync the project"</summary>
        public virtual SyncProjectConfig Projectonly(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-projectonly=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-projectonly");
            return (SyncProjectConfig) this;
        }

        
        
/// <summary>"Only sync this path. Can be comma-separated list."</summary>
        public virtual SyncProjectConfig Paths(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-paths=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-paths");
            return (SyncProjectConfig) this;
        }

        
        
/// <summary>"Number of retries for a timed out file. Defaults to 3"</summary>
        public virtual SyncProjectConfig Retries(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-retries=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-retries");
            return (SyncProjectConfig) this;
        }

        
        
/// <summary>"Do not set an engine version after syncing"</summary>
        public virtual SyncProjectConfig Unversioned(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-unversioned=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-unversioned");
            return (SyncProjectConfig) this;
        }

        
        
/// <summary>"Only sync files that match this path. Can be comma-separated list."</summary>
        public virtual SyncProjectConfig Path(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-path" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-path");
            return (SyncProjectConfig) this;
        }
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    
        public override string Gather()
        {
            Arguments.Insert(0, "SyncProject");return base.Gather();
        }
    }

    protected readonly SyncProjectConfig SyncProjectStorage = new();
        
/// <summary>Tests P4 functionality. Runs 'p4 info'.</summary>
/// <remarks>WARNING: This command might require Perforce</remarks>
    public  class TestP4_InfoConfig : ToolConfig
    {
        public override string Name => "TestP4_Info";
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    
        public override string Gather()
        {
            Arguments.Insert(0, "TestP4_Info");return base.Gather();
        }
    }

    protected readonly TestP4_InfoConfig TestP4_InfoStorage = new();
        
/// <summary>GitPullRequest</summary>
/// <remarks>WARNING: This command might require Perforce</remarks>
    public  class GitPullRequestConfig : ToolConfig
    {
        public override string Name => "GitPullRequest";
    
        
/// <summary>"Directory of the Git repo."</summary>
        public virtual GitPullRequestConfig Dir(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-Dir=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-Dir");
            return (GitPullRequestConfig) this;
        }

        
        
/// <summary>"PR # to shelve, can use a range PR=5-25"</summary>
        public virtual GitPullRequestConfig PR(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-PR=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-PR");
            return (GitPullRequestConfig) this;
        }

        
        
    
        public virtual GitPullRequestConfig UT(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-UT=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-UT");
            return (GitPullRequestConfig) this;
        }

        
        
    
        public virtual GitPullRequestConfig Clean(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-Clean=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-Clean");
            return (GitPullRequestConfig) this;
        }
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    
        public override string Gather()
        {
            Arguments.Insert(0, "GitPullRequest");return base.Gather();
        }
    }

    protected readonly GitPullRequestConfig GitPullRequestStorage = new();
        
/// <summary>Throws an automation exception.</summary>
    public  class TestFailConfig : ToolConfig
    {
        public override string Name => "TestFail";
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    
        public override string Gather()
        {
            Arguments.Insert(0, "TestFail");return base.Gather();
        }
    }

    protected readonly TestFailConfig TestFailStorage = new();
        
/// <summary>Prints a message and returns success.</summary>
    public  class TestSuccessConfig : ToolConfig
    {
        public override string Name => "TestSuccess";
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    
        public override string Gather()
        {
            Arguments.Insert(0, "TestSuccess");return base.Gather();
        }
    }

    protected readonly TestSuccessConfig TestSuccessStorage = new();
        
/// <summary>Prints a message and returns success.</summary>
    public  class TestMessageConfig : ToolConfig
    {
        public override string Name => "TestMessage";
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    
        public override string Gather()
        {
            Arguments.Insert(0, "TestMessage");return base.Gather();
        }
    }

    protected readonly TestMessageConfig TestMessageStorage = new();
        
/// <summary>Calls UAT recursively with a given command line.</summary>
    public  class TestRecursionConfig : ToolConfig
    {
        public override string Name => "TestRecursion";
    
        
    
        public virtual TestRecursionConfig Cmd(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-Cmd=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-Cmd");
            return (TestRecursionConfig) this;
        }
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    
        public override string Gather()
        {
            Arguments.Insert(0, "TestRecursion");return base.Gather();
        }
    }

    protected readonly TestRecursionConfig TestRecursionStorage = new();
        
/// <summary>Calls UAT recursively with a given command line.</summary>
    public  class TestRecursionAutoConfig : ToolConfig
    {
        public override string Name => "TestRecursionAuto";
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    
        public override string Gather()
        {
            Arguments.Insert(0, "TestRecursionAuto");return base.Gather();
        }
    }

    protected readonly TestRecursionAutoConfig TestRecursionAutoStorage = new();
        
/// <summary>Makes a zip file in Rocket/QFE</summary>
    public  class TestMacZipConfig : ToolConfig
    {
        public override string Name => "TestMacZip";
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    
        public override string Gather()
        {
            Arguments.Insert(0, "TestMacZip");return base.Gather();
        }
    }

    protected readonly TestMacZipConfig TestMacZipStorage = new();
        
/// <summary>Tests P4 functionality. Creates a new changelist under the workspace %P4CLIENT%</summary>
/// <remarks>WARNING: This command might require Perforce</remarks>
    public  class TestP4_CreateChangelistConfig : ToolConfig
    {
        public override string Name => "TestP4_CreateChangelist";
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    
        public override string Gather()
        {
            Arguments.Insert(0, "TestP4_CreateChangelist");return base.Gather();
        }
    }

    protected readonly TestP4_CreateChangelistConfig TestP4_CreateChangelistStorage = new();
        
/// <remarks>WARNING: This command might require Perforce</remarks>
    public  class TestP4_StrandCheckoutConfig : ToolConfig
    {
        public override string Name => "TestP4_StrandCheckout";
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    
        public override string Gather()
        {
            Arguments.Insert(0, "TestP4_StrandCheckout");return base.Gather();
        }
    }

    protected readonly TestP4_StrandCheckoutConfig TestP4_StrandCheckoutStorage = new();
        
/// <remarks>WARNING: This command might require Perforce</remarks>
    public  class TestP4_LabelDescriptionConfig : ToolConfig
    {
        public override string Name => "TestP4_LabelDescription";
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    
        public override string Gather()
        {
            Arguments.Insert(0, "TestP4_LabelDescription");return base.Gather();
        }
    }

    protected readonly TestP4_LabelDescriptionConfig TestP4_LabelDescriptionStorage = new();
        
/// <remarks>WARNING: This command might require Perforce</remarks>
    public  class TestP4_ClientOpsConfig : ToolConfig
    {
        public override string Name => "TestP4_ClientOps";
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    
        public override string Gather()
        {
            Arguments.Insert(0, "TestP4_ClientOps");return base.Gather();
        }
    }

    protected readonly TestP4_ClientOpsConfig TestP4_ClientOpsStorage = new();
        
    
    public  class CleanDDCConfig : ToolConfig
    {
        public override string Name => "CleanDDC";
    
        
    
        public virtual CleanDDCConfig DoIt(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-DoIt=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-DoIt");
            return (CleanDDCConfig) this;
        }
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    
        public override string Gather()
        {
            Arguments.Insert(0, "CleanDDC");return base.Gather();
        }
    }

    protected readonly CleanDDCConfig CleanDDCStorage = new();
        
    
    public  class TestTestFarmConfig : ToolConfig
    {
        public override string Name => "TestTestFarm";
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    
        public override string Gather()
        {
            Arguments.Insert(0, "TestTestFarm");return base.Gather();
        }
    }

    protected readonly TestTestFarmConfig TestTestFarmStorage = new();
        
/// <summary>Test command line argument parsing functions.</summary>
    public  class TestArgumentsConfig : ToolConfig
    {
        public override string Name => "TestArguments";
    
        
    
        public virtual TestArgumentsConfig Noxge(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-noxge=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-noxge");
            return (TestArgumentsConfig) this;
        }

        
        
    
        public virtual TestArgumentsConfig Dude(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-Dude=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-Dude");
            return (TestArgumentsConfig) this;
        }

        
        
    
        public virtual TestArgumentsConfig Stuff(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-Stuff=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-Stuff");
            return (TestArgumentsConfig) this;
        }

        
        
    
        public virtual TestArgumentsConfig Map(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-map=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-map");
            return (TestArgumentsConfig) this;
        }

        
        
    
        public virtual TestArgumentsConfig Run(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-run=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-run");
            return (TestArgumentsConfig) this;
        }
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    
        public override string Gather()
        {
            Arguments.Insert(0, "TestArguments");return base.Gather();
        }
    }

    protected readonly TestArgumentsConfig TestArgumentsStorage = new();
        
/// <summary>Checks if combine paths works as excpected</summary>
    public  class TestCombinePathsConfig : ToolConfig
    {
        public override string Name => "TestCombinePaths";
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    
        public override string Gather()
        {
            Arguments.Insert(0, "TestCombinePaths");return base.Gather();
        }
    }

    protected readonly TestCombinePathsConfig TestCombinePathsStorage = new();
        
/// <summary>Tests file utility functions.</summary>
    public  class TestFileUtilityConfig : ToolConfig
    {
        public override string Name => "TestFileUtility";
    
        
/// <summary>"Filename to perform the tests on."</summary>
        public virtual TestFileUtilityConfig File(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-file=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-file");
            return (TestFileUtilityConfig) this;
        }
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    
        public override string Gather()
        {
            Arguments.Insert(0, "TestFileUtility");return base.Gather();
        }
    }

    protected readonly TestFileUtilityConfig TestFileUtilityStorage = new();
        
    
    public  class TestLogConfig : ToolConfig
    {
        public override string Name => "TestLog";
    
        
    
        public virtual TestLogConfig Map(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-map=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-map");
            return (TestLogConfig) this;
        }
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    
        public override string Gather()
        {
            Arguments.Insert(0, "TestLog");return base.Gather();
        }
    }

    protected readonly TestLogConfig TestLogStorage = new();
        
/// <summary>Tests P4 change filetype functionality.</summary>
/// <remarks>WARNING: This command might require Perforce</remarks>
    public  class TestChangeFileTypeConfig : ToolConfig
    {
        public override string Name => "TestChangeFileType";
    
        
/// <summary>"Binary file to change the filetype to writeable"</summary>
        public virtual TestChangeFileTypeConfig File(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-File=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-File");
            return (TestChangeFileTypeConfig) this;
        }
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    
        public override string Gather()
        {
            Arguments.Insert(0, "TestChangeFileType");return base.Gather();
        }
    }

    protected readonly TestChangeFileTypeConfig TestChangeFileTypeStorage = new();
        
/// <summary>Tests if UE4Build properly copies all relevent UAT build products to the Binaries folder.</summary>
    public  class TestUATBuildProductsConfig : ToolConfig
    {
        public override string Name => "TestUATBuildProducts";
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    
        public override string Gather()
        {
            Arguments.Insert(0, "TestUATBuildProducts");return base.Gather();
        }
    }

    protected readonly TestUATBuildProductsConfig TestUATBuildProductsStorage = new();
        
    
    public  class TestOSSCommandsConfig : ToolConfig
    {
        public override string Name => "TestOSSCommands";
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    
        public override string Gather()
        {
            Arguments.Insert(0, "TestOSSCommands");return base.Gather();
        }
    }

    protected readonly TestOSSCommandsConfig TestOSSCommandsStorage = new();
        
/// <summary>Builds a project using UBT. Syntax is similar to UBT with the exception of '-', i.e. UBT -QAGame -Development -Win32</summary>
    public  class UBTConfig : ToolConfig
    {
        public override string Name => "UBT";
    
        
/// <summary>"Disable XGE"</summary>
        public virtual UBTConfig NoXGE(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-NoXGE" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-NoXGE");
            return (UBTConfig) this;
        }

        
        
/// <summary>"Clean build products before building"</summary>
        public virtual UBTConfig Clean(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-Clean=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-Clean");
            return (UBTConfig) this;
        }
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    
        public override string Gather()
        {
            Arguments.Insert(0, "UBT");return base.Gather();
        }
    }

    protected readonly UBTConfig UBTStorage = new();
        
/// <summary>Helper command to sync only source code + engine files from P4.</summary>
/// <remarks>WARNING: This command might require Perforce</remarks>
    public  class SyncSourceConfig : ToolConfig
    {
        public override string Name => "SyncSource";
    
        
/// <summary>"Optional branch depot path, default is: -Branch=//depot/UE4"</summary>
        public virtual SyncSourceConfig Branch(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-Branch=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-Branch");
            return (SyncSourceConfig) this;
        }

        
        
/// <summary>"Optional changelist to sync (default is latest), -CL=1234567"</summary>
        public virtual SyncSourceConfig CL(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-CL=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-CL");
            return (SyncSourceConfig) this;
        }

        
        
/// <summary>"Optional list of branch subforlders to always sync separated with '+', default is: -Sync=Engine/Binaries/ThirdParty+Engine/Content"</summary>
        public virtual SyncSourceConfig Sync(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-Sync=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-Sync");
            return (SyncSourceConfig) this;
        }

        
        
/// <summary>"Optional list of folder names to exclude from syncing, separated with '+', default is: -Exclude=Binaries+Content+Documentation+DataTables"</summary>
        public virtual SyncSourceConfig Exclude(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-Exclude=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-Exclude");
            return (SyncSourceConfig) this;
        }
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    
        public override string Gather()
        {
            Arguments.Insert(0, "SyncSource");return base.Gather();
        }
    }

    protected readonly SyncSourceConfig SyncSourceStorage = new();
        
/// <summary>Generates automation project based on a template.</summary>
    public  class GenerateAutomationProjectConfig : ToolConfig
    {
        public override string Name => "GenerateAutomationProject";
    
        
/// <summary>"Short name of the project, i.e. QAGame"</summary>
        public virtual GenerateAutomationProjectConfig Project(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-project=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-project");
            return (GenerateAutomationProjectConfig) this;
        }

        
        
/// <summary>"Absolute path to the project root directory, i.e. C:\\UE4\\QAGame"</summary>
        public virtual GenerateAutomationProjectConfig Path(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-path=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-path");
            return (GenerateAutomationProjectConfig) this;
        }
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    
        public override string Gather()
        {
            Arguments.Insert(0, "GenerateAutomationProject");return base.Gather();
        }
    }

    protected readonly GenerateAutomationProjectConfig GenerateAutomationProjectStorage = new();
        
    
    public  class DumpBranchConfig : ToolConfig
    {
        public override string Name => "DumpBranch";
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    
        public override string Gather()
        {
            Arguments.Insert(0, "DumpBranch");return base.Gather();
        }
    }

    protected readonly DumpBranchConfig DumpBranchStorage = new();
        
/// <summary>Sleeps for 20 seconds and then exits</summary>
    public  class DebugSleepConfig : ToolConfig
    {
        public override string Name => "DebugSleep";
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    
        public override string Gather()
        {
            Arguments.Insert(0, "DebugSleep");return base.Gather();
        }
    }

    protected readonly DebugSleepConfig DebugSleepStorage = new();
        
/// <summary>Tests if Mcp configs loaded properly.</summary>
    public  class TestMcpConfigsConfig : ToolConfig
    {
        public override string Name => "TestMcpConfigs";
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    
        public override string Gather()
        {
            Arguments.Insert(0, "TestMcpConfigs");return base.Gather();
        }
    }

    protected readonly TestMcpConfigsConfig TestMcpConfigsStorage = new();
        
/// <summary>Test Blame P4 command.</summary>
/// <remarks>WARNING: This command might require Perforce</remarks>
    public  class TestBlameConfig : ToolConfig
    {
        public override string Name => "TestBlame";
    
        
/// <summary>"(Optional) Filename of the file to produce a blame output for"</summary>
        public virtual TestBlameConfig File(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-File=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-File");
            return (TestBlameConfig) this;
        }

        
        
/// <summary>"(Optional) File to save the blame result to."</summary>
        public virtual TestBlameConfig Out(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-Out=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-Out");
            return (TestBlameConfig) this;
        }

        
        
/// <summary>"If specified, will use Timelapse command instead of Blame"</summary>
        public virtual TestBlameConfig Timelapse(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-Timelapse=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-Timelapse");
            return (TestBlameConfig) this;
        }
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    
        public override string Gather()
        {
            Arguments.Insert(0, "TestBlame");return base.Gather();
        }
    }

    protected readonly TestBlameConfig TestBlameStorage = new();
        
/// <summary>Test P4 changes.</summary>
/// <remarks>WARNING: This command might require Perforce</remarks>
    public  class TestChangesConfig : ToolConfig
    {
        public override string Name => "TestChanges";
    
        
    
        public virtual TestChangesConfig CommandParam(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-CommandParam=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-CommandParam");
            return (TestChangesConfig) this;
        }
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    
        public override string Gather()
        {
            Arguments.Insert(0, "TestChanges");return base.Gather();
        }
    }

    protected readonly TestChangesConfig TestChangesStorage = new();
        
/// <summary>Spawns a process to test if UAT kills it automatically.</summary>
    public  class TestKillAllConfig : ToolConfig
    {
        public override string Name => "TestKillAll";
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    
        public override string Gather()
        {
            Arguments.Insert(0, "TestKillAll");return base.Gather();
        }
    }

    protected readonly TestKillAllConfig TestKillAllStorage = new();
        
/// <summary>Tests CleanFormalBuilds.</summary>
    public  class TestCleanFormalBuildsConfig : ToolConfig
    {
        public override string Name => "TestCleanFormalBuilds";
    
        
    
        public virtual TestCleanFormalBuildsConfig Dir(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-Dir=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-Dir");
            return (TestCleanFormalBuildsConfig) this;
        }
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    
        public override string Gather()
        {
            Arguments.Insert(0, "TestCleanFormalBuilds");return base.Gather();
        }
    }

    protected readonly TestCleanFormalBuildsConfig TestCleanFormalBuildsStorage = new();
        
/// <summary>Spawns a process to test if it can be killed.</summary>
    public  class TestStopProcessConfig : ToolConfig
    {
        public override string Name => "TestStopProcess";
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    
        public override string Gather()
        {
            Arguments.Insert(0, "TestStopProcess");return base.Gather();
        }
    }

    protected readonly TestStopProcessConfig TestStopProcessStorage = new();
        
/// <summary>Looks through an XGE xml for overlapping obj files</summary>
    public  class LookForOverlappingBuildProductsConfig : ToolConfig
    {
        public override string Name => "LookForOverlappingBuildProducts";
    
        
/// <summary>"full path of xml to look at"</summary>
        public virtual LookForOverlappingBuildProductsConfig Source(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-Source" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-Source");
            return (LookForOverlappingBuildProductsConfig) this;
        }

        
        
    
        public virtual LookForOverlappingBuildProductsConfig Source_(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-Source==" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-Source=");
            return (LookForOverlappingBuildProductsConfig) this;
        }
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    
        public override string Gather()
        {
            Arguments.Insert(0, "LookForOverlappingBuildProducts");return base.Gather();
        }
    }

    protected readonly LookForOverlappingBuildProductsConfig LookForOverlappingBuildProductsStorage = new();
        
/// <summary>Copies all files from source directory to destination directory using ThreadedCopyFiles</summary>
    public  class TestThreadedCopyFilesConfig : ToolConfig
    {
        public override string Name => "TestThreadedCopyFiles";
    
        
/// <summary>"Source path"</summary>
        public virtual TestThreadedCopyFilesConfig Source(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-Source" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-Source");
            return (TestThreadedCopyFilesConfig) this;
        }

        
        
/// <summary>"Destination path"</summary>
        public virtual TestThreadedCopyFilesConfig Dest(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-Dest" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-Dest");
            return (TestThreadedCopyFilesConfig) this;
        }

        
        
/// <summary>"Number of threads used to copy files (64 by default)"</summary>
        public virtual TestThreadedCopyFilesConfig Threads(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-Threads" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-Threads");
            return (TestThreadedCopyFilesConfig) this;
        }

        
        
    
        public virtual TestThreadedCopyFilesConfig Source_(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-Source==" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-Source=");
            return (TestThreadedCopyFilesConfig) this;
        }

        
        
    
        public virtual TestThreadedCopyFilesConfig Dest_(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-Dest==" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-Dest=");
            return (TestThreadedCopyFilesConfig) this;
        }

        
        
    
        public virtual TestThreadedCopyFilesConfig Threads_(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-Threads==" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-Threads=");
            return (TestThreadedCopyFilesConfig) this;
        }
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    
        public override string Gather()
        {
            Arguments.Insert(0, "TestThreadedCopyFiles");return base.Gather();
        }
    }

    protected readonly TestThreadedCopyFilesConfig TestThreadedCopyFilesStorage = new();
        
    
    public  class UE4BuildUtilDummyBuildCommandConfig : ToolConfig
    {
        public override string Name => "UE4BuildUtilDummyBuildCommand";
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    
        public override string Gather()
        {
            Arguments.Insert(0, "UE4BuildUtilDummyBuildCommand");return base.Gather();
        }
    }

    protected readonly UE4BuildUtilDummyBuildCommandConfig UE4BuildUtilDummyBuildCommandStorage = new();
        
/// <summary>Updates your local versions based on your P4 sync</summary>
/// <remarks>WARNING: This command might require Perforce</remarks>
    public  class UpdateLocalVersionConfig : ToolConfig
    {
        public override string Name => "UpdateLocalVersion";
    
        
/// <summary>"Overrides the automatically disovered changelist number with the specified one"</summary>
        public virtual UpdateLocalVersionConfig CL(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-CL=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-CL");
            return (UpdateLocalVersionConfig) this;
        }

        
        
/// <summary>"Overrides the changelist that the engine is API-compatible with"</summary>
        public virtual UpdateLocalVersionConfig CompatibleCL(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-CompatibleCL=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-CompatibleCL");
            return (UpdateLocalVersionConfig) this;
        }

        
        
/// <summary>"Value for whether this is a promoted build (defaults to 1)."</summary>
        public virtual UpdateLocalVersionConfig Promoted(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-Promoted" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-Promoted");
            return (UpdateLocalVersionConfig) this;
        }

        
        
/// <summary>"Overrides the branch string."</summary>
        public virtual UpdateLocalVersionConfig Branch(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-Branch" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-Branch");
            return (UpdateLocalVersionConfig) this;
        }

        
        
/// <summary>"When updating version files, store the changelist number in licensee format"</summary>
        public virtual UpdateLocalVersionConfig Licensee(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-Licensee" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-Licensee");
            return (UpdateLocalVersionConfig) this;
        }

        
        
    
        public virtual UpdateLocalVersionConfig Build(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-Build=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-Build");
            return (UpdateLocalVersionConfig) this;
        }
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    
        public override string Gather()
        {
            Arguments.Insert(0, "UpdateLocalVersion");return base.Gather();
        }
    }

    protected readonly UpdateLocalVersionConfig UpdateLocalVersionStorage = new();
        
    
    public  class UploadDDCToAWSConfig : ToolConfig
    {
        public override string Name => "UploadDDCToAWS";
    
        
    
        public virtual UploadDDCToAWSConfig Days(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-Days=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-Days");
            return (UploadDDCToAWSConfig) this;
        }

        
        
    
        public virtual UploadDDCToAWSConfig MaxFileSize(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-MaxFileSize=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-MaxFileSize");
            return (UploadDDCToAWSConfig) this;
        }

        
        
    
        public virtual UploadDDCToAWSConfig KeyPrefix(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-KeyPrefix=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-KeyPrefix");
            return (UploadDDCToAWSConfig) this;
        }

        
        
    
        public virtual UploadDDCToAWSConfig Reset(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-Reset=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-Reset");
            return (UploadDDCToAWSConfig) this;
        }
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    
        public override string Gather()
        {
            Arguments.Insert(0, "UploadDDCToAWS");return base.Gather();
        }
    }

    protected readonly UploadDDCToAWSConfig UploadDDCToAWSStorage = new();
        
/// <summary>ZipUtils is used to zip/unzip (i.e:RunUAT.bat ZipUtils -archive=D:/Content.zip -add=D:/UE/Pojects/SampleGame/Content/) or (i.e:RunUAT.bat ZipUtils -archive=D:/Content.zip -extract=D:/UE/Pojects/SampleGame/Content/)</summary>
    public  class ZipUtilsConfig : ToolConfig
    {
        public override string Name => "ZipUtils";
    
        
/// <summary>"Path to folder that should be add to the archive."</summary>
        public virtual ZipUtilsConfig Archive(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-archive=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-archive");
            return (ZipUtilsConfig) this;
        }

        
        
/// <summary>"Path to folder that should be add to the archive."</summary>
        public virtual ZipUtilsConfig Add(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-add=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-add");
            return (ZipUtilsConfig) this;
        }

        
        
/// <summary>"Path to folder where the archive should be extracted"</summary>
        public virtual ZipUtilsConfig Extract(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-extract=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-extract");
            return (ZipUtilsConfig) this;
        }

        
        
/// <summary>"Compression Level 0 - Copy  9-Best Compression"</summary>
        public virtual ZipUtilsConfig Compression(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-compression=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-compression");
            return (ZipUtilsConfig) this;
        }
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    
        public override string Gather()
        {
            Arguments.Insert(0, "ZipUtils");return base.Gather();
        }
    }

    protected readonly ZipUtilsConfig ZipUtilsStorage = new();
        
/// <summary>Runs benchmarks and reports overall results
/// Example1: RunUAT BenchmarkBuild -all -project=UE4
/// Example2: RunUAT BenchmarkBuild -allcompile -project=UE4+EngineTest -platform=PS4
/// Example3: RunUAT BenchmarkBuild -editor -client -cook -cooknoshaderddc -cooknoddc -xge -noxge -singlecompile -nopcompile -project=UE4+QAGame+EngineTest -platform=WIn64+PS4+XboxOne+Switch -iterations=3</summary>
    public  class BenchmarkBuildConfig : ToolConfig
    {
        public override string Name => "BenchmarkBuild";
    
        
/// <summary>"List everything that will run but don't do it"</summary>
        public virtual BenchmarkBuildConfig Preview(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-preview=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-preview");
            return (BenchmarkBuildConfig) this;
        }

        
        
/// <summary>"Do tests on the specified projec(s)t. E.g. -project=UE4+FortniteGame+QAGame"</summary>
        public virtual BenchmarkBuildConfig Project(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-project=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-project");
            return (BenchmarkBuildConfig) this;
        }

        
        
/// <summary>"Run all the things (except noddc)"</summary>
        public virtual BenchmarkBuildConfig All(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-all=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-all");
            return (BenchmarkBuildConfig) this;
        }

        
        
/// <summary>"Run all the compile things"</summary>
        public virtual BenchmarkBuildConfig Allcompile(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-allcompile=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-allcompile");
            return (BenchmarkBuildConfig) this;
        }

        
        
/// <summary>"Build an editor for compile tests"</summary>
        public virtual BenchmarkBuildConfig Editor(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-editor=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-editor");
            return (BenchmarkBuildConfig) this;
        }

        
        
/// <summary>"Build a client for comple tests (see -platform)"</summary>
        public virtual BenchmarkBuildConfig Client(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-client=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-client");
            return (BenchmarkBuildConfig) this;
        }

        
        
/// <summary>"Specify the platform(s) to use for client compilation/cooking, if empty the local platform be used if -client or -cook is specified"</summary>
        public virtual BenchmarkBuildConfig Platform(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-platform=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-platform");
            return (BenchmarkBuildConfig) this;
        }

        
        
/// <summary>"Do a compile with XGE / FASTBuild"</summary>
        public virtual BenchmarkBuildConfig Xge(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-xge=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-xge");
            return (BenchmarkBuildConfig) this;
        }

        
        
/// <summary>"Do a compile without XGE / FASTBuild"</summary>
        public virtual BenchmarkBuildConfig Noxge(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-noxge=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-noxge");
            return (BenchmarkBuildConfig) this;
        }

        
        
/// <summary>"Do a single-file compile"</summary>
        public virtual BenchmarkBuildConfig Singlecompile(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-singlecompile=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-singlecompile");
            return (BenchmarkBuildConfig) this;
        }

        
        
/// <summary>"Do a nothing-needs-compiled compile"</summary>
        public virtual BenchmarkBuildConfig Nopcompile(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-nopcompile=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-nopcompile");
            return (BenchmarkBuildConfig) this;
        }

        
        
/// <summary>"Do noxge builds with these processor counts (default is Environment.ProcessorCount)"</summary>
        public virtual BenchmarkBuildConfig Cores(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-cores=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-cores");
            return (BenchmarkBuildConfig) this;
        }

        
        
/// <summary>"Do a cook for the specified platform"</summary>
        public virtual BenchmarkBuildConfig Cook(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-cook=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-cook");
            return (BenchmarkBuildConfig) this;
        }

        
        
/// <summary>"Launch the editor (only valid when -project is specified"</summary>
        public virtual BenchmarkBuildConfig Pie(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-pie=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-pie");
            return (BenchmarkBuildConfig) this;
        }

        
        
/// <summary>"Map to PIE with (only valid when using a single project"</summary>
        public virtual BenchmarkBuildConfig Map(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-map=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-map");
            return (BenchmarkBuildConfig) this;
        }

        
        
/// <summary>"Cook / PIE with a warm DDC"</summary>
        public virtual BenchmarkBuildConfig Warmddc(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-warmddc=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-warmddc");
            return (BenchmarkBuildConfig) this;
        }

        
        
/// <summary>"Cook / PIE with a hot local DDC (an untimed pre-run is performed)"</summary>
        public virtual BenchmarkBuildConfig Hotddc(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-hotddc=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-hotddc");
            return (BenchmarkBuildConfig) this;
        }

        
        
/// <summary>"Cook / PIE with a cold local DDC (a temporary folder is used)"</summary>
        public virtual BenchmarkBuildConfig Coldddc(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-coldddc=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-coldddc");
            return (BenchmarkBuildConfig) this;
        }

        
        
/// <summary>"Cook / PIE with no shaders in the DDC"</summary>
        public virtual BenchmarkBuildConfig Noshaderddc(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-noshaderddc=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-noshaderddc");
            return (BenchmarkBuildConfig) this;
        }

        
        
/// <summary>"How many times to perform each test)"</summary>
        public virtual BenchmarkBuildConfig Iterations(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-iterations=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-iterations");
            return (BenchmarkBuildConfig) this;
        }

        
        
/// <summary>"How many seconds to wait between each test)"</summary>
        public virtual BenchmarkBuildConfig Wait(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-wait=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-wait");
            return (BenchmarkBuildConfig) this;
        }

        
        
/// <summary>"Name/path of file to write CSV results to. If empty the local machine name will be used"</summary>
        public virtual BenchmarkBuildConfig Filename(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-filename=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-filename");
            return (BenchmarkBuildConfig) this;
        }

        
        
/// <summary>"Don't build from clean. (Mostly just to speed things up when testing)"</summary>
        public virtual BenchmarkBuildConfig Noclean(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-noclean" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-noclean");
            return (BenchmarkBuildConfig) this;
        }

        
        
/// <summary>"Extra args to use when cooking. -CookArgs1=\"-foo\" -CookArgs2=\"-bar\" will run two cooks with each argument set"</summary>
        public virtual BenchmarkBuildConfig CookArgs(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-CookArgs=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-CookArgs");
            return (BenchmarkBuildConfig) this;
        }

        
        
/// <summary>"Extra args to use when running the editor. -PIEArgs1=\"-foo\" -PIEArgs2=\"-bar\" will run two PIE tests with each argument set"</summary>
        public virtual BenchmarkBuildConfig PIEArgs(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-PIEArgs=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-PIEArgs");
            return (BenchmarkBuildConfig) this;
        }

        
        
    
        public virtual BenchmarkBuildConfig Ue4(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-ue4=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-ue4");
            return (BenchmarkBuildConfig) this;
        }

        
        
    
        public virtual BenchmarkBuildConfig Fastbuild(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-fastbuild=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-fastbuild");
            return (BenchmarkBuildConfig) this;
        }

        
        
    
        public virtual BenchmarkBuildConfig Nofastbuild(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-nofastbuild=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-nofastbuild");
            return (BenchmarkBuildConfig) this;
        }

        
        
    
        public virtual BenchmarkBuildConfig Projects(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-projects=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-projects");
            return (BenchmarkBuildConfig) this;
        }

        
        
    
        public virtual BenchmarkBuildConfig Platforms(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-platforms=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-platforms");
            return (BenchmarkBuildConfig) this;
        }
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    
        public override string Gather()
        {
            Arguments.Insert(0, "BenchmarkBuild");return base.Gather();
        }
    }

    protected readonly BenchmarkBuildConfig BenchmarkBuildStorage = new();
        
    
    public  class BenchmarkOptionsConfig : ToolConfig
    {
        public override string Name => "BenchmarkOptions";
    
        
    
        public virtual BenchmarkOptionsConfig All(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-all=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-all");
            return (BenchmarkOptionsConfig) this;
        }

        
        
    
        public virtual BenchmarkOptionsConfig Allcompile(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-allcompile=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-allcompile");
            return (BenchmarkOptionsConfig) this;
        }

        
        
    
        public virtual BenchmarkOptionsConfig Preview(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-preview=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-preview");
            return (BenchmarkOptionsConfig) this;
        }

        
        
    
        public virtual BenchmarkOptionsConfig Ue4(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-ue4=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-ue4");
            return (BenchmarkOptionsConfig) this;
        }

        
        
    
        public virtual BenchmarkOptionsConfig Editor(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-editor=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-editor");
            return (BenchmarkOptionsConfig) this;
        }

        
        
    
        public virtual BenchmarkOptionsConfig Client(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-client=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-client");
            return (BenchmarkOptionsConfig) this;
        }

        
        
    
        public virtual BenchmarkOptionsConfig Nopcompile(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-nopcompile=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-nopcompile");
            return (BenchmarkOptionsConfig) this;
        }

        
        
    
        public virtual BenchmarkOptionsConfig Singlecompile(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-singlecompile=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-singlecompile");
            return (BenchmarkOptionsConfig) this;
        }

        
        
    
        public virtual BenchmarkOptionsConfig Xge(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-xge=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-xge");
            return (BenchmarkOptionsConfig) this;
        }

        
        
    
        public virtual BenchmarkOptionsConfig Fastbuild(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-fastbuild=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-fastbuild");
            return (BenchmarkOptionsConfig) this;
        }

        
        
    
        public virtual BenchmarkOptionsConfig Noxge(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-noxge=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-noxge");
            return (BenchmarkOptionsConfig) this;
        }

        
        
    
        public virtual BenchmarkOptionsConfig Nofastbuild(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-nofastbuild=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-nofastbuild");
            return (BenchmarkOptionsConfig) this;
        }

        
        
    
        public virtual BenchmarkOptionsConfig Cook(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-cook=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-cook");
            return (BenchmarkOptionsConfig) this;
        }

        
        
    
        public virtual BenchmarkOptionsConfig Pie(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-pie=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-pie");
            return (BenchmarkOptionsConfig) this;
        }

        
        
    
        public virtual BenchmarkOptionsConfig Warmddc(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-warmddc=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-warmddc");
            return (BenchmarkOptionsConfig) this;
        }

        
        
    
        public virtual BenchmarkOptionsConfig Hotddc(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-hotddc=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-hotddc");
            return (BenchmarkOptionsConfig) this;
        }

        
        
    
        public virtual BenchmarkOptionsConfig Coldddc(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-coldddc=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-coldddc");
            return (BenchmarkOptionsConfig) this;
        }

        
        
    
        public virtual BenchmarkOptionsConfig Noshaderddc(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-noshaderddc=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-noshaderddc");
            return (BenchmarkOptionsConfig) this;
        }

        
        
    
        public virtual BenchmarkOptionsConfig Iterations(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-Iterations=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-Iterations");
            return (BenchmarkOptionsConfig) this;
        }

        
        
    
        public virtual BenchmarkOptionsConfig Wait(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-Wait=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-Wait");
            return (BenchmarkOptionsConfig) this;
        }

        
        
    
        public virtual BenchmarkOptionsConfig CookArgs(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-CookArgs=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-CookArgs");
            return (BenchmarkOptionsConfig) this;
        }

        
        
    
        public virtual BenchmarkOptionsConfig PIEArgs(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-PIEArgs=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-PIEArgs");
            return (BenchmarkOptionsConfig) this;
        }

        
        
    
        public virtual BenchmarkOptionsConfig FileName(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-filename=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-filename");
            return (BenchmarkOptionsConfig) this;
        }

        
        
    
        public virtual BenchmarkOptionsConfig Project(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-project=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-project");
            return (BenchmarkOptionsConfig) this;
        }

        
        
    
        public virtual BenchmarkOptionsConfig Projects(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-projects=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-projects");
            return (BenchmarkOptionsConfig) this;
        }

        
        
    
        public virtual BenchmarkOptionsConfig Platform(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-platform=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-platform");
            return (BenchmarkOptionsConfig) this;
        }

        
        
    
        public virtual BenchmarkOptionsConfig Platforms(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-platforms=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-platforms");
            return (BenchmarkOptionsConfig) this;
        }

        
        
    
        public virtual BenchmarkOptionsConfig Cores(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-cores=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-cores");
            return (BenchmarkOptionsConfig) this;
        }

        
        
    
        public virtual BenchmarkOptionsConfig Map(params object[] values)
        {
            AppendArgument(values != null && values.Length > 0 ? "-map=" + string.Join("+", values.DoubleQuoteIfNeeded()) : "-map");
            return (BenchmarkOptionsConfig) this;
        }
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    
        public override string Gather()
        {
            Arguments.Insert(0, "BenchmarkOptions");return base.Gather();
        }
    }

    protected readonly BenchmarkOptionsConfig BenchmarkOptionsStorage = new();

    private ToolConfig[] _configs = null;
    protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
    {
        ProgramStorage,
                AutomationStorage,
                CodeSignStorage,
                McpConfigMapperStorage,
                P4EnvironmentStorage,
                P4WriteConfigStorage,
                ProjectParamsStorage,
                UE4BuildStorage,
                BuildTargetStorage,
                BuildGraphStorage,
                BuildStorage,
                TempStorageTestsStorage,
                CleanTempStorageStorage,
                TestGauntletStorage,
                RunUnrealStorage,
                ExportIPAFromArchiveStorage,
                MakeIPAStorage,
                WriteIniValueToPlistStorage,
                OneSkyLocalizationProviderStorage,
                AnalyzeThirdPartyLibsStorage,
                BlameKeywordStorage,
                XcodeTargetPlatform_IOSStorage,
                MakefileTargetPlatform_IOSStorage,
                BuildCommonToolsStorage,
                ZipProjectUpStorage,
                BuildCookRunStorage,
                BuildDerivedDataCacheStorage,
                BuildForUGSStorage,
                BuildHlslccStorage,
                BuildPhysX_AndroidStorage,
                BuildPhysX_IOSStorage,
                BuildPhysX_LinuxStorage,
                BuildPhysX_Mac_x86_64Storage,
                BuildPhysX_Mac_arm64Storage,
                BuildPhysX_MacStorage,
                BuildPhysX_TVOSStorage,
                BuildPhysX_Win32Storage,
                BuildPhysX_Win64Storage,
                BuildPluginStorage,
                BuildEditorStorage,
                BuildGameStorage,
                BuildServerStorage,
                BuildThirdPartyLibsStorage,
                CheckBalancedMacrosStorage,
                CheckCsprojDotNetVersionStorage,
                CheckForHacksStorage,
                CheckPerforceCaseStorage,
                CheckRestrictedFoldersStorage,
                CheckTargetExistsStorage,
                CheckXcodeVersionStorage,
                CleanAutomationReportsStorage,
                CleanFormalBuildsStorage,
                CodeSurgeryStorage,
                CopySharedCookedBuildStorage,
                CopyUATStorage,
                CryptoKeysStorage,
                ExtractPaksStorage,
                FinalizeInstalledBuildStorage,
                FixPerforceCaseStorage,
                FixupRedirectsStorage,
                GenerateDSYMStorage,
                IPhonePackagerStorage,
                LauncherLocalizationStorage,
                ListMobileDevicesStorage,
                ListThirdPartySoftwareStorage,
                LocalizeStorage,
                ExportMcpTemplatesStorage,
                LocaliseStorage,
                OpenEditorStorage,
                ParseMsvcTimingInfoStorage,
                RebasePublicIncludePathsStorage,
                RebuildHLODStorage,
                RebuildLightMapsStorage,
                RecordPerformanceStorage,
                ReplaceAssetsUsingManifestStorage,
                ResavePackagesStorage,
                ResavePluginDescriptorsStorage,
                ResaveProjectDescriptorsStorage,
                RunP4ReconcileStorage,
                StashTargetStorage,
                UnstashTargetStorage,
                SubmitUtilizationReportToECStorage,
                SyncBinariesFromUGSStorage,
                SyncDDCStorage,
                SyncDepotPathStorage,
                SyncProjectStorage,
                TestP4_InfoStorage,
                GitPullRequestStorage,
                TestFailStorage,
                TestSuccessStorage,
                TestMessageStorage,
                TestRecursionStorage,
                TestRecursionAutoStorage,
                TestMacZipStorage,
                TestP4_CreateChangelistStorage,
                TestP4_StrandCheckoutStorage,
                TestP4_LabelDescriptionStorage,
                TestP4_ClientOpsStorage,
                CleanDDCStorage,
                TestTestFarmStorage,
                TestArgumentsStorage,
                TestCombinePathsStorage,
                TestFileUtilityStorage,
                TestLogStorage,
                TestChangeFileTypeStorage,
                TestUATBuildProductsStorage,
                TestOSSCommandsStorage,
                UBTStorage,
                SyncSourceStorage,
                GenerateAutomationProjectStorage,
                DumpBranchStorage,
                DebugSleepStorage,
                TestMcpConfigsStorage,
                TestBlameStorage,
                TestChangesStorage,
                TestKillAllStorage,
                TestCleanFormalBuildsStorage,
                TestStopProcessStorage,
                LookForOverlappingBuildProductsStorage,
                TestThreadedCopyFilesStorage,
                UE4BuildUtilDummyBuildCommandStorage,
                UpdateLocalVersionStorage,
                UploadDDCToAWSStorage,
                ZipUtilsStorage,
                BenchmarkBuildStorage,
                BenchmarkOptionsStorage,
            };

    public UnrealAutomationToolConfig Program(Action<ProgramConfig> configurator = null)
    {
        configurator?.Invoke(ProgramStorage);
        AppendSubtool(ProgramStorage);
        return (UnrealAutomationToolConfig) this;
    }
/// <summary>@"Executes scripted commands
/// 
/// AutomationTool.exe [-verbose] [-compileonly] [-p4] Command0 [-Arg0 -Arg1 -Arg2 ...] Command1 [-Arg0 -Arg1 ...] Command2 [-Arg0 ...] Commandn ... [EnvVar0=MyValue0 ... EnvVarn=MyValuen]"</summary>
    public UnrealAutomationToolConfig Automation(Action<AutomationConfig> configurator = null)
    {
        configurator?.Invoke(AutomationStorage);
        AppendSubtool(AutomationStorage);
        return (UnrealAutomationToolConfig) this;
    }

    public UnrealAutomationToolConfig CodeSign(Action<CodeSignConfig> configurator = null)
    {
        configurator?.Invoke(CodeSignStorage);
        AppendSubtool(CodeSignStorage);
        return (UnrealAutomationToolConfig) this;
    }

    public UnrealAutomationToolConfig McpConfigMapper(Action<McpConfigMapperConfig> configurator = null)
    {
        configurator?.Invoke(McpConfigMapperStorage);
        AppendSubtool(McpConfigMapperStorage);
        return (UnrealAutomationToolConfig) this;
    }

    public UnrealAutomationToolConfig P4Environment(Action<P4EnvironmentConfig> configurator = null)
    {
        configurator?.Invoke(P4EnvironmentStorage);
        AppendSubtool(P4EnvironmentStorage);
        return (UnrealAutomationToolConfig) this;
    }
/// <summary>Auto-detects P4 settings based on the current path and creates a p4config file with the relevant settings.</summary>
    public UnrealAutomationToolConfig P4WriteConfig(Action<P4WriteConfigConfig> configurator = null)
    {
        configurator?.Invoke(P4WriteConfigStorage);
        AppendSubtool(P4WriteConfigStorage);
        return (UnrealAutomationToolConfig) this;
    }
/// <summary>Iteratively cook from a shared cooked build
/// Iteratively cook from a shared cooked build</summary>
    public UnrealAutomationToolConfig ProjectParams(Action<ProjectParamsConfig> configurator = null)
    {
        configurator?.Invoke(ProjectParamsStorage);
        AppendSubtool(ProjectParamsStorage);
        return (UnrealAutomationToolConfig) this;
    }

    public UnrealAutomationToolConfig UE4Build(Action<UE4BuildConfig> configurator = null)
    {
        configurator?.Invoke(UE4BuildStorage);
        AppendSubtool(UE4BuildStorage);
        return (UnrealAutomationToolConfig) this;
    }
/// <summary>Builds the specified targets and configurations for the specified project.
/// Example BuildTarget -project=QAGame -target=Editor+Game -platform=PS4+XboxOne -configuration=Development.
/// Note: Editor will only ever build for the current platform in a Development config and required tools will be included</summary>
    public UnrealAutomationToolConfig BuildTarget(Action<BuildTargetConfig> configurator = null)
    {
        configurator?.Invoke(BuildTargetStorage);
        AppendSubtool(BuildTargetStorage);
        return (UnrealAutomationToolConfig) this;
    }
/// <summary>Tool for creating extensible build processes in UE4 which can be run locally or in parallel across a build farm.</summary>
    public UnrealAutomationToolConfig BuildGraph(Action<BuildGraphConfig> configurator = null)
    {
        configurator?.Invoke(BuildGraphStorage);
        AppendSubtool(BuildGraphStorage);
        return (UnrealAutomationToolConfig) this;
    }

    public UnrealAutomationToolConfig Build(Action<BuildConfig> configurator = null)
    {
        configurator?.Invoke(BuildStorage);
        AppendSubtool(BuildStorage);
        return (UnrealAutomationToolConfig) this;
    }

    public UnrealAutomationToolConfig TempStorageTests(Action<TempStorageTestsConfig> configurator = null)
    {
        configurator?.Invoke(TempStorageTestsStorage);
        AppendSubtool(TempStorageTestsStorage);
        return (UnrealAutomationToolConfig) this;
    }
/// <summary>Removes folders in a given temp storage directory that are older than a certain time.</summary>
    public UnrealAutomationToolConfig CleanTempStorage(Action<CleanTempStorageConfig> configurator = null)
    {
        configurator?.Invoke(CleanTempStorageStorage);
        AppendSubtool(CleanTempStorageStorage);
        return (UnrealAutomationToolConfig) this;
    }

    public UnrealAutomationToolConfig TestGauntlet(Action<TestGauntletConfig> configurator = null)
    {
        configurator?.Invoke(TestGauntletStorage);
        AppendSubtool(TestGauntletStorage);
        return (UnrealAutomationToolConfig) this;
    }

    public UnrealAutomationToolConfig RunUnreal(Action<RunUnrealConfig> configurator = null)
    {
        configurator?.Invoke(RunUnrealStorage);
        AppendSubtool(RunUnrealStorage);
        return (UnrealAutomationToolConfig) this;
    }
/// <summary>@"Creates an IPA from an xarchive file"</summary>
    public UnrealAutomationToolConfig ExportIPAFromArchive(Action<ExportIPAFromArchiveConfig> configurator = null)
    {
        configurator?.Invoke(ExportIPAFromArchiveStorage);
        AppendSubtool(ExportIPAFromArchiveStorage);
        return (UnrealAutomationToolConfig) this;
    }
/// <summary>@"Creates an IPA from an xarchive file"</summary>
    public UnrealAutomationToolConfig MakeIPA(Action<MakeIPAConfig> configurator = null)
    {
        configurator?.Invoke(MakeIPAStorage);
        AppendSubtool(MakeIPAStorage);
        return (UnrealAutomationToolConfig) this;
    }
/// <summary>@"Pulls a value from an ini file and inserts it into a plist."
/// @"Note currently only looks at values irrespective of sections!"</summary>
    public UnrealAutomationToolConfig WriteIniValueToPlist(Action<WriteIniValueToPlistConfig> configurator = null)
    {
        configurator?.Invoke(WriteIniValueToPlistStorage);
        AppendSubtool(WriteIniValueToPlistStorage);
        return (UnrealAutomationToolConfig) this;
    }

    public UnrealAutomationToolConfig OneSkyLocalizationProvider(Action<OneSkyLocalizationProviderConfig> configurator = null)
    {
        configurator?.Invoke(OneSkyLocalizationProviderStorage);
        AppendSubtool(OneSkyLocalizationProviderStorage);
        return (UnrealAutomationToolConfig) this;
    }
/// <summary>Analyzes third party libraries</summary>
    public UnrealAutomationToolConfig AnalyzeThirdPartyLibs(Action<AnalyzeThirdPartyLibsConfig> configurator = null)
    {
        configurator?.Invoke(AnalyzeThirdPartyLibsStorage);
        AppendSubtool(AnalyzeThirdPartyLibsStorage);
        return (UnrealAutomationToolConfig) this;
    }
/// <summary>BlameKeyword command. Looks for the specified keywords in all files at the specified path and finds who added them based on P4 history</summary>
/// <remarks>WARNING: This command might require Perforce</remarks>
    public UnrealAutomationToolConfig BlameKeyword(Action<BlameKeywordConfig> configurator = null)
    {
        configurator?.Invoke(BlameKeywordStorage);
        AppendSubtool(BlameKeywordStorage);
        return (UnrealAutomationToolConfig) this;
    }

    public UnrealAutomationToolConfig XcodeTargetPlatform_IOS(Action<XcodeTargetPlatform_IOSConfig> configurator = null)
    {
        configurator?.Invoke(XcodeTargetPlatform_IOSStorage);
        AppendSubtool(XcodeTargetPlatform_IOSStorage);
        return (UnrealAutomationToolConfig) this;
    }

    public UnrealAutomationToolConfig MakefileTargetPlatform_IOS(Action<MakefileTargetPlatform_IOSConfig> configurator = null)
    {
        configurator?.Invoke(MakefileTargetPlatform_IOSStorage);
        AppendSubtool(MakefileTargetPlatform_IOSStorage);
        return (UnrealAutomationToolConfig) this;
    }
/// <summary>Builds common tools used by the engine which are not part of typical editor or game builds. Useful when syncing source-only on GitHub.</summary>
    public UnrealAutomationToolConfig BuildCommonTools(Action<BuildCommonToolsConfig> configurator = null)
    {
        configurator?.Invoke(BuildCommonToolsStorage);
        AppendSubtool(BuildCommonToolsStorage);
        return (UnrealAutomationToolConfig) this;
    }

    public UnrealAutomationToolConfig ZipProjectUp(Action<ZipProjectUpConfig> configurator = null)
    {
        configurator?.Invoke(ZipProjectUpStorage);
        AppendSubtool(ZipProjectUpStorage);
        return (UnrealAutomationToolConfig) this;
    }
/// <summary>@"Builds/Cooks/Runs a project.
/// 
/// For non-uprojects project targets are discovered by compiling target rule files found in the project folder.
/// If -map is not specified, the command looks for DefaultMap entry in the project's DefaultEngine.ini and if not found, in BaseEngine.ini.
/// If no DefaultMap can be found, the command falls back to /Engine/Maps/Entry."</summary>
    public UnrealAutomationToolConfig BuildCookRun(Action<BuildCookRunConfig> configurator = null)
    {
        configurator?.Invoke(BuildCookRunStorage);
        AppendSubtool(BuildCookRunStorage);
        return (UnrealAutomationToolConfig) this;
    }

    public UnrealAutomationToolConfig BuildDerivedDataCache(Action<BuildDerivedDataCacheConfig> configurator = null)
    {
        configurator?.Invoke(BuildDerivedDataCacheStorage);
        AppendSubtool(BuildDerivedDataCacheStorage);
        return (UnrealAutomationToolConfig) this;
    }
/// <remarks>WARNING: This command might require Perforce</remarks>
    public UnrealAutomationToolConfig BuildForUGS(Action<BuildForUGSConfig> configurator = null)
    {
        configurator?.Invoke(BuildForUGSStorage);
        AppendSubtool(BuildForUGSStorage);
        return (UnrealAutomationToolConfig) this;
    }
/// <summary>Builds Hlslcc using CMake build system.</summary>
/// <remarks>WARNING: This command might require Perforce</remarks>
    public UnrealAutomationToolConfig BuildHlslcc(Action<BuildHlslccConfig> configurator = null)
    {
        configurator?.Invoke(BuildHlslccStorage);
        AppendSubtool(BuildHlslccStorage);
        return (UnrealAutomationToolConfig) this;
    }

    public UnrealAutomationToolConfig BuildPhysX_Android(Action<BuildPhysX_AndroidConfig> configurator = null)
    {
        configurator?.Invoke(BuildPhysX_AndroidStorage);
        AppendSubtool(BuildPhysX_AndroidStorage);
        return (UnrealAutomationToolConfig) this;
    }

    public UnrealAutomationToolConfig BuildPhysX_IOS(Action<BuildPhysX_IOSConfig> configurator = null)
    {
        configurator?.Invoke(BuildPhysX_IOSStorage);
        AppendSubtool(BuildPhysX_IOSStorage);
        return (UnrealAutomationToolConfig) this;
    }

    public UnrealAutomationToolConfig BuildPhysX_Linux(Action<BuildPhysX_LinuxConfig> configurator = null)
    {
        configurator?.Invoke(BuildPhysX_LinuxStorage);
        AppendSubtool(BuildPhysX_LinuxStorage);
        return (UnrealAutomationToolConfig) this;
    }

    public UnrealAutomationToolConfig BuildPhysX_Mac_x86_64(Action<BuildPhysX_Mac_x86_64Config> configurator = null)
    {
        configurator?.Invoke(BuildPhysX_Mac_x86_64Storage);
        AppendSubtool(BuildPhysX_Mac_x86_64Storage);
        return (UnrealAutomationToolConfig) this;
    }

    public UnrealAutomationToolConfig BuildPhysX_Mac_arm64(Action<BuildPhysX_Mac_arm64Config> configurator = null)
    {
        configurator?.Invoke(BuildPhysX_Mac_arm64Storage);
        AppendSubtool(BuildPhysX_Mac_arm64Storage);
        return (UnrealAutomationToolConfig) this;
    }

    public UnrealAutomationToolConfig BuildPhysX_Mac(Action<BuildPhysX_MacConfig> configurator = null)
    {
        configurator?.Invoke(BuildPhysX_MacStorage);
        AppendSubtool(BuildPhysX_MacStorage);
        return (UnrealAutomationToolConfig) this;
    }

    public UnrealAutomationToolConfig BuildPhysX_TVOS(Action<BuildPhysX_TVOSConfig> configurator = null)
    {
        configurator?.Invoke(BuildPhysX_TVOSStorage);
        AppendSubtool(BuildPhysX_TVOSStorage);
        return (UnrealAutomationToolConfig) this;
    }

    public UnrealAutomationToolConfig BuildPhysX_Win32(Action<BuildPhysX_Win32Config> configurator = null)
    {
        configurator?.Invoke(BuildPhysX_Win32Storage);
        AppendSubtool(BuildPhysX_Win32Storage);
        return (UnrealAutomationToolConfig) this;
    }

    public UnrealAutomationToolConfig BuildPhysX_Win64(Action<BuildPhysX_Win64Config> configurator = null)
    {
        configurator?.Invoke(BuildPhysX_Win64Storage);
        AppendSubtool(BuildPhysX_Win64Storage);
        return (UnrealAutomationToolConfig) this;
    }
/// <summary>Builds a plugin, and packages it for distribution</summary>
    public UnrealAutomationToolConfig BuildPlugin(Action<BuildPluginConfig> configurator = null)
    {
        configurator?.Invoke(BuildPluginStorage);
        AppendSubtool(BuildPluginStorage);
        return (UnrealAutomationToolConfig) this;
    }
/// <summary>Builds the editor for the specified project.
/// Example BuildEditor -project=QAGame
/// Note: Editor will only ever build for the current platform in a Development config and required tools will be included</summary>
    public UnrealAutomationToolConfig BuildEditor(Action<BuildEditorConfig> configurator = null)
    {
        configurator?.Invoke(BuildEditorStorage);
        AppendSubtool(BuildEditorStorage);
        return (UnrealAutomationToolConfig) this;
    }
/// <summary>Builds the game for the specified project.
/// Example BuildGame -project=QAGame -platform=PS4+XboxOne -configuration=Development.</summary>
    public UnrealAutomationToolConfig BuildGame(Action<BuildGameConfig> configurator = null)
    {
        configurator?.Invoke(BuildGameStorage);
        AppendSubtool(BuildGameStorage);
        return (UnrealAutomationToolConfig) this;
    }
/// <summary>Builds the server for the specified project.
/// Example BuildServer -project=QAGame -platform=Win64 -configuration=Development.</summary>
    public UnrealAutomationToolConfig BuildServer(Action<BuildServerConfig> configurator = null)
    {
        configurator?.Invoke(BuildServerStorage);
        AppendSubtool(BuildServerStorage);
        return (UnrealAutomationToolConfig) this;
    }
/// <summary>Builds third party libraries, and puts them all into a changelist</summary>
/// <remarks>WARNING: This command might require Perforce</remarks>
    public UnrealAutomationToolConfig BuildThirdPartyLibs(Action<BuildThirdPartyLibsConfig> configurator = null)
    {
        configurator?.Invoke(BuildThirdPartyLibsStorage);
        AppendSubtool(BuildThirdPartyLibsStorage);
        return (UnrealAutomationToolConfig) this;
    }
/// <summary>Checks that all source files have balanced macros for enabling/disabling optimization, warnings, etc...</summary>
    public UnrealAutomationToolConfig CheckBalancedMacros(Action<CheckBalancedMacrosConfig> configurator = null)
    {
        configurator?.Invoke(CheckBalancedMacrosStorage);
        AppendSubtool(CheckBalancedMacrosStorage);
        return (UnrealAutomationToolConfig) this;
    }

    public UnrealAutomationToolConfig CheckCsprojDotNetVersion(Action<CheckCsprojDotNetVersionConfig> configurator = null)
    {
        configurator?.Invoke(CheckCsprojDotNetVersionStorage);
        AppendSubtool(CheckCsprojDotNetVersionStorage);
        return (UnrealAutomationToolConfig) this;
    }
/// <summary>Audits the current branch for comments denoting a hack that was not meant to leave another branch, following a given format (\"BEGIN XXXX HACK\", where XXXX is one or more tags separated by spaces).
/// Allowed tags may be specified manually on the command line. At least one must match, otherwise it will print a warning.
/// The current branch name and fragments of the branch path will also be added by default, so running from //UE4/Main will add \"//UE4/Main\", \"UE4\", and \"Main\".</summary>
    public UnrealAutomationToolConfig CheckForHacks(Action<CheckForHacksConfig> configurator = null)
    {
        configurator?.Invoke(CheckForHacksStorage);
        AppendSubtool(CheckForHacksStorage);
        return (UnrealAutomationToolConfig) this;
    }
/// <summary>Checks that the casing of files within a path on a case-insensitive Perforce server is correct.</summary>
/// <remarks>WARNING: This command might require Perforce</remarks>
    public UnrealAutomationToolConfig CheckPerforceCase(Action<CheckPerforceCaseConfig> configurator = null)
    {
        configurator?.Invoke(CheckPerforceCaseStorage);
        AppendSubtool(CheckPerforceCaseStorage);
        return (UnrealAutomationToolConfig) this;
    }
/// <summary>Checks a directory for folders which should not be distributed</summary>
    public UnrealAutomationToolConfig CheckRestrictedFolders(Action<CheckRestrictedFoldersConfig> configurator = null)
    {
        configurator?.Invoke(CheckRestrictedFoldersStorage);
        AppendSubtool(CheckRestrictedFoldersStorage);
        return (UnrealAutomationToolConfig) this;
    }
/// <summary>Checks that the given target exists, by looking for the relevant receipt.</summary>
    public UnrealAutomationToolConfig CheckTargetExists(Action<CheckTargetExistsConfig> configurator = null)
    {
        configurator?.Invoke(CheckTargetExistsStorage);
        AppendSubtool(CheckTargetExistsStorage);
        return (UnrealAutomationToolConfig) this;
    }
/// <summary>Checks that the installed Xcode version is the version specified.</summary>
    public UnrealAutomationToolConfig CheckXcodeVersion(Action<CheckXcodeVersionConfig> configurator = null)
    {
        configurator?.Invoke(CheckXcodeVersionStorage);
        AppendSubtool(CheckXcodeVersionStorage);
        return (UnrealAutomationToolConfig) this;
    }
/// <summary>Removes folders in an automation report directory that are older than a certain time.</summary>
    public UnrealAutomationToolConfig CleanAutomationReports(Action<CleanAutomationReportsConfig> configurator = null)
    {
        configurator?.Invoke(CleanAutomationReportsStorage);
        AppendSubtool(CleanAutomationReportsStorage);
        return (UnrealAutomationToolConfig) this;
    }
/// <summary>Removes folders matching a pattern in a given directory that are older than a certain time.</summary>
    public UnrealAutomationToolConfig CleanFormalBuilds(Action<CleanFormalBuildsConfig> configurator = null)
    {
        configurator?.Invoke(CleanFormalBuildsStorage);
        AppendSubtool(CleanFormalBuildsStorage);
        return (UnrealAutomationToolConfig) this;
    }
/// <summary>custom code to restructure C++ source code for the new stats system.</summary>
    public UnrealAutomationToolConfig CodeSurgery(Action<CodeSurgeryConfig> configurator = null)
    {
        configurator?.Invoke(CodeSurgeryStorage);
        AppendSubtool(CodeSurgeryStorage);
        return (UnrealAutomationToolConfig) this;
    }
/// <summary>Copies the current shared cooked build from the network to the local PC</summary>
/// <remarks>WARNING: This command might require Perforce</remarks>
    public UnrealAutomationToolConfig CopySharedCookedBuild(Action<CopySharedCookedBuildConfig> configurator = null)
    {
        configurator?.Invoke(CopySharedCookedBuildStorage);
        AppendSubtool(CopySharedCookedBuildStorage);
        return (UnrealAutomationToolConfig) this;
    }

    public UnrealAutomationToolConfig CopyUAT(Action<CopyUATConfig> configurator = null)
    {
        configurator?.Invoke(CopyUATStorage);
        AppendSubtool(CopyUATStorage);
        return (UnrealAutomationToolConfig) this;
    }

    public UnrealAutomationToolConfig CryptoKeys(Action<CryptoKeysConfig> configurator = null)
    {
        configurator?.Invoke(CryptoKeysStorage);
        AppendSubtool(CryptoKeysStorage);
        return (UnrealAutomationToolConfig) this;
    }

    public UnrealAutomationToolConfig ExtractPaks(Action<ExtractPaksConfig> configurator = null)
    {
        configurator?.Invoke(ExtractPaksStorage);
        AppendSubtool(ExtractPaksStorage);
        return (UnrealAutomationToolConfig) this;
    }
/// <summary>Command to perform additional steps to prepare an installed build.</summary>
    public UnrealAutomationToolConfig FinalizeInstalledBuild(Action<FinalizeInstalledBuildConfig> configurator = null)
    {
        configurator?.Invoke(FinalizeInstalledBuildStorage);
        AppendSubtool(FinalizeInstalledBuildStorage);
        return (UnrealAutomationToolConfig) this;
    }
/// <summary>Fixes the case of files on a case-insensitive Perforce server by removing and re-adding them.</summary>
/// <remarks>WARNING: This command might require Perforce</remarks>
    public UnrealAutomationToolConfig FixPerforceCase(Action<FixPerforceCaseConfig> configurator = null)
    {
        configurator?.Invoke(FixPerforceCaseStorage);
        AppendSubtool(FixPerforceCaseStorage);
        return (UnrealAutomationToolConfig) this;
    }

    public UnrealAutomationToolConfig FixupRedirects(Action<FixupRedirectsConfig> configurator = null)
    {
        configurator?.Invoke(FixupRedirectsStorage);
        AppendSubtool(FixupRedirectsStorage);
        return (UnrealAutomationToolConfig) this;
    }
/// <summary>@"Generates IOS debug symbols for a remote project."</summary>
    public UnrealAutomationToolConfig GenerateDSYM(Action<GenerateDSYMConfig> configurator = null)
    {
        configurator?.Invoke(GenerateDSYMStorage);
        AppendSubtool(GenerateDSYMStorage);
        return (UnrealAutomationToolConfig) this;
    }
/// <summary>UAT command to call into the integrated IPhonePackager code</summary>
    public UnrealAutomationToolConfig IPhonePackager(Action<IPhonePackagerConfig> configurator = null)
    {
        configurator?.Invoke(IPhonePackagerStorage);
        AppendSubtool(IPhonePackagerStorage);
        return (UnrealAutomationToolConfig) this;
    }

    public UnrealAutomationToolConfig LauncherLocalization(Action<LauncherLocalizationConfig> configurator = null)
    {
        configurator?.Invoke(LauncherLocalizationStorage);
        AppendSubtool(LauncherLocalizationStorage);
        return (UnrealAutomationToolConfig) this;
    }

    public UnrealAutomationToolConfig ListMobileDevices(Action<ListMobileDevicesConfig> configurator = null)
    {
        configurator?.Invoke(ListMobileDevicesStorage);
        AppendSubtool(ListMobileDevicesStorage);
        return (UnrealAutomationToolConfig) this;
    }
/// <summary>Lists TPS files associated with any source used to build a specified target(s). Grabs TPS files associated with source modules, content, and engine shaders.</summary>
    public UnrealAutomationToolConfig ListThirdPartySoftware(Action<ListThirdPartySoftwareConfig> configurator = null)
    {
        configurator?.Invoke(ListThirdPartySoftwareStorage);
        AppendSubtool(ListThirdPartySoftwareStorage);
        return (UnrealAutomationToolConfig) this;
    }
/// <summary>Updates the external localization data using the arguments provided.</summary>
    public UnrealAutomationToolConfig Localize(Action<LocalizeConfig> configurator = null)
    {
        configurator?.Invoke(LocalizeStorage);
        AppendSubtool(LocalizeStorage);
        return (UnrealAutomationToolConfig) this;
    }

    public UnrealAutomationToolConfig ExportMcpTemplates(Action<ExportMcpTemplatesConfig> configurator = null)
    {
        configurator?.Invoke(ExportMcpTemplatesStorage);
        AppendSubtool(ExportMcpTemplatesStorage);
        return (UnrealAutomationToolConfig) this;
    }

    public UnrealAutomationToolConfig Localise(Action<LocaliseConfig> configurator = null)
    {
        configurator?.Invoke(LocaliseStorage);
        AppendSubtool(LocaliseStorage);
        return (UnrealAutomationToolConfig) this;
    }
/// <summary>Opens the specified project.</summary>
    public UnrealAutomationToolConfig OpenEditor(Action<OpenEditorConfig> configurator = null)
    {
        configurator?.Invoke(OpenEditorStorage);
        AppendSubtool(OpenEditorStorage);
        return (UnrealAutomationToolConfig) this;
    }
/// <summary>Parses Visual C++ timing information (as generated by UBT with the -Timing flag), and converts it into JSON format which can be visualized using the chrome://tracing tab</summary>
    public UnrealAutomationToolConfig ParseMsvcTimingInfo(Action<ParseMsvcTimingInfoConfig> configurator = null)
    {
        configurator?.Invoke(ParseMsvcTimingInfoStorage);
        AppendSubtool(ParseMsvcTimingInfoStorage);
        return (UnrealAutomationToolConfig) this;
    }
/// <summary>Rewrites include directives for headers in public include paths to make them relative to the 'Public' folder.</summary>
    public UnrealAutomationToolConfig RebasePublicIncludePaths(Action<RebasePublicIncludePathsConfig> configurator = null)
    {
        configurator?.Invoke(RebasePublicIncludePathsStorage);
        AppendSubtool(RebasePublicIncludePathsStorage);
        return (UnrealAutomationToolConfig) this;
    }
/// <remarks>WARNING: This command might require Perforce</remarks>
    public UnrealAutomationToolConfig RebuildHLOD(Action<RebuildHLODConfig> configurator = null)
    {
        configurator?.Invoke(RebuildHLODStorage);
        AppendSubtool(RebuildHLODStorage);
        return (UnrealAutomationToolConfig) this;
    }
/// <summary>Helper command used for rebuilding a projects light maps</summary>
/// <remarks>WARNING: This command might require Perforce</remarks>
    public UnrealAutomationToolConfig RebuildLightMaps(Action<RebuildLightMapsConfig> configurator = null)
    {
        configurator?.Invoke(RebuildLightMapsStorage);
        AppendSubtool(RebuildLightMapsStorage);
        return (UnrealAutomationToolConfig) this;
    }
/// <summary>UAT command to run performance test demo using different RHIs and compare results</summary>
    public UnrealAutomationToolConfig RecordPerformance(Action<RecordPerformanceConfig> configurator = null)
    {
        configurator?.Invoke(RecordPerformanceStorage);
        AppendSubtool(RecordPerformanceStorage);
        return (UnrealAutomationToolConfig) this;
    }

    public UnrealAutomationToolConfig ReplaceAssetsUsingManifest(Action<ReplaceAssetsUsingManifestConfig> configurator = null)
    {
        configurator?.Invoke(ReplaceAssetsUsingManifestStorage);
        AppendSubtool(ReplaceAssetsUsingManifestStorage);
        return (UnrealAutomationToolConfig) this;
    }
/// <remarks>WARNING: This command might require Perforce</remarks>
    public UnrealAutomationToolConfig ResavePackages(Action<ResavePackagesConfig> configurator = null)
    {
        configurator?.Invoke(ResavePackagesStorage);
        AppendSubtool(ResavePackagesStorage);
        return (UnrealAutomationToolConfig) this;
    }
/// <summary>Re-save all the plugin descriptors under a given path, optionally applying standard metadata to them</summary>
    public UnrealAutomationToolConfig ResavePluginDescriptors(Action<ResavePluginDescriptorsConfig> configurator = null)
    {
        configurator?.Invoke(ResavePluginDescriptorsStorage);
        AppendSubtool(ResavePluginDescriptorsStorage);
        return (UnrealAutomationToolConfig) this;
    }
/// <summary>Re-save all the project descriptors under a given path</summary>
    public UnrealAutomationToolConfig ResaveProjectDescriptors(Action<ResaveProjectDescriptorsConfig> configurator = null)
    {
        configurator?.Invoke(ResaveProjectDescriptorsStorage);
        AppendSubtool(ResaveProjectDescriptorsStorage);
        return (UnrealAutomationToolConfig) this;
    }
/// <remarks>WARNING: This command might require Perforce</remarks>
    public UnrealAutomationToolConfig RunP4Reconcile(Action<RunP4ReconcileConfig> configurator = null)
    {
        configurator?.Invoke(RunP4ReconcileStorage);
        AppendSubtool(RunP4ReconcileStorage);
        return (UnrealAutomationToolConfig) this;
    }
/// <summary>Copy all the binaries for a target into a different folder. Can be restored using the UnstashTarget command. Useful for A/B testing.</summary>
    public UnrealAutomationToolConfig StashTarget(Action<StashTargetConfig> configurator = null)
    {
        configurator?.Invoke(StashTargetStorage);
        AppendSubtool(StashTargetStorage);
        return (UnrealAutomationToolConfig) this;
    }
/// <summary>Copy all the binaries from a target back into the root directory. Use in combination with the StashTarget command.</summary>
    public UnrealAutomationToolConfig UnstashTarget(Action<UnstashTargetConfig> configurator = null)
    {
        configurator?.Invoke(UnstashTargetStorage);
        AppendSubtool(UnstashTargetStorage);
        return (UnrealAutomationToolConfig) this;
    }
/// <summary>Submits a generated Utilization report to EC</summary>
    public UnrealAutomationToolConfig SubmitUtilizationReportToEC(Action<SubmitUtilizationReportToECConfig> configurator = null)
    {
        configurator?.Invoke(SubmitUtilizationReportToECStorage);
        AppendSubtool(SubmitUtilizationReportToECStorage);
        return (UnrealAutomationToolConfig) this;
    }
/// <summary>Attempts to sync UGS binaries for the specified project at the currently synced CL of the project/engine folders</summary>
/// <remarks>WARNING: This command might require Perforce</remarks>
    public UnrealAutomationToolConfig SyncBinariesFromUGS(Action<SyncBinariesFromUGSConfig> configurator = null)
    {
        configurator?.Invoke(SyncBinariesFromUGSStorage);
        AppendSubtool(SyncBinariesFromUGSStorage);
        return (UnrealAutomationToolConfig) this;
    }
/// <summary>Merge one or more remote DDC shares into a local share, taking files with the newest timestamps and keeping the size below a certain limit</summary>
    public UnrealAutomationToolConfig SyncDDC(Action<SyncDDCConfig> configurator = null)
    {
        configurator?.Invoke(SyncDDCStorage);
        AppendSubtool(SyncDDCStorage);
        return (UnrealAutomationToolConfig) this;
    }
/// <summary>Creates a temporary client and syncs a path from Perforce.</summary>
/// <remarks>WARNING: This command might require Perforce</remarks>
    public UnrealAutomationToolConfig SyncDepotPath(Action<SyncDepotPathConfig> configurator = null)
    {
        configurator?.Invoke(SyncDepotPathStorage);
        AppendSubtool(SyncDepotPathStorage);
        return (UnrealAutomationToolConfig) this;
    }
/// <summary>Syncs and builds all the binaries required for a project</summary>
/// <remarks>WARNING: This command might require Perforce</remarks>
    public UnrealAutomationToolConfig SyncProject(Action<SyncProjectConfig> configurator = null)
    {
        configurator?.Invoke(SyncProjectStorage);
        AppendSubtool(SyncProjectStorage);
        return (UnrealAutomationToolConfig) this;
    }
/// <summary>Tests P4 functionality. Runs 'p4 info'.</summary>
/// <remarks>WARNING: This command might require Perforce</remarks>
    public UnrealAutomationToolConfig TestP4_Info(Action<TestP4_InfoConfig> configurator = null)
    {
        configurator?.Invoke(TestP4_InfoStorage);
        AppendSubtool(TestP4_InfoStorage);
        return (UnrealAutomationToolConfig) this;
    }
/// <summary>GitPullRequest</summary>
/// <remarks>WARNING: This command might require Perforce</remarks>
    public UnrealAutomationToolConfig GitPullRequest(Action<GitPullRequestConfig> configurator = null)
    {
        configurator?.Invoke(GitPullRequestStorage);
        AppendSubtool(GitPullRequestStorage);
        return (UnrealAutomationToolConfig) this;
    }
/// <summary>Throws an automation exception.</summary>
    public UnrealAutomationToolConfig TestFail(Action<TestFailConfig> configurator = null)
    {
        configurator?.Invoke(TestFailStorage);
        AppendSubtool(TestFailStorage);
        return (UnrealAutomationToolConfig) this;
    }
/// <summary>Prints a message and returns success.</summary>
    public UnrealAutomationToolConfig TestSuccess(Action<TestSuccessConfig> configurator = null)
    {
        configurator?.Invoke(TestSuccessStorage);
        AppendSubtool(TestSuccessStorage);
        return (UnrealAutomationToolConfig) this;
    }
/// <summary>Prints a message and returns success.</summary>
    public UnrealAutomationToolConfig TestMessage(Action<TestMessageConfig> configurator = null)
    {
        configurator?.Invoke(TestMessageStorage);
        AppendSubtool(TestMessageStorage);
        return (UnrealAutomationToolConfig) this;
    }
/// <summary>Calls UAT recursively with a given command line.</summary>
    public UnrealAutomationToolConfig TestRecursion(Action<TestRecursionConfig> configurator = null)
    {
        configurator?.Invoke(TestRecursionStorage);
        AppendSubtool(TestRecursionStorage);
        return (UnrealAutomationToolConfig) this;
    }
/// <summary>Calls UAT recursively with a given command line.</summary>
    public UnrealAutomationToolConfig TestRecursionAuto(Action<TestRecursionAutoConfig> configurator = null)
    {
        configurator?.Invoke(TestRecursionAutoStorage);
        AppendSubtool(TestRecursionAutoStorage);
        return (UnrealAutomationToolConfig) this;
    }
/// <summary>Makes a zip file in Rocket/QFE</summary>
    public UnrealAutomationToolConfig TestMacZip(Action<TestMacZipConfig> configurator = null)
    {
        configurator?.Invoke(TestMacZipStorage);
        AppendSubtool(TestMacZipStorage);
        return (UnrealAutomationToolConfig) this;
    }
/// <summary>Tests P4 functionality. Creates a new changelist under the workspace %P4CLIENT%</summary>
/// <remarks>WARNING: This command might require Perforce</remarks>
    public UnrealAutomationToolConfig TestP4_CreateChangelist(Action<TestP4_CreateChangelistConfig> configurator = null)
    {
        configurator?.Invoke(TestP4_CreateChangelistStorage);
        AppendSubtool(TestP4_CreateChangelistStorage);
        return (UnrealAutomationToolConfig) this;
    }
/// <remarks>WARNING: This command might require Perforce</remarks>
    public UnrealAutomationToolConfig TestP4_StrandCheckout(Action<TestP4_StrandCheckoutConfig> configurator = null)
    {
        configurator?.Invoke(TestP4_StrandCheckoutStorage);
        AppendSubtool(TestP4_StrandCheckoutStorage);
        return (UnrealAutomationToolConfig) this;
    }
/// <remarks>WARNING: This command might require Perforce</remarks>
    public UnrealAutomationToolConfig TestP4_LabelDescription(Action<TestP4_LabelDescriptionConfig> configurator = null)
    {
        configurator?.Invoke(TestP4_LabelDescriptionStorage);
        AppendSubtool(TestP4_LabelDescriptionStorage);
        return (UnrealAutomationToolConfig) this;
    }
/// <remarks>WARNING: This command might require Perforce</remarks>
    public UnrealAutomationToolConfig TestP4_ClientOps(Action<TestP4_ClientOpsConfig> configurator = null)
    {
        configurator?.Invoke(TestP4_ClientOpsStorage);
        AppendSubtool(TestP4_ClientOpsStorage);
        return (UnrealAutomationToolConfig) this;
    }

    public UnrealAutomationToolConfig CleanDDC(Action<CleanDDCConfig> configurator = null)
    {
        configurator?.Invoke(CleanDDCStorage);
        AppendSubtool(CleanDDCStorage);
        return (UnrealAutomationToolConfig) this;
    }

    public UnrealAutomationToolConfig TestTestFarm(Action<TestTestFarmConfig> configurator = null)
    {
        configurator?.Invoke(TestTestFarmStorage);
        AppendSubtool(TestTestFarmStorage);
        return (UnrealAutomationToolConfig) this;
    }
/// <summary>Test command line argument parsing functions.</summary>
    public UnrealAutomationToolConfig TestArguments(Action<TestArgumentsConfig> configurator = null)
    {
        configurator?.Invoke(TestArgumentsStorage);
        AppendSubtool(TestArgumentsStorage);
        return (UnrealAutomationToolConfig) this;
    }
/// <summary>Checks if combine paths works as excpected</summary>
    public UnrealAutomationToolConfig TestCombinePaths(Action<TestCombinePathsConfig> configurator = null)
    {
        configurator?.Invoke(TestCombinePathsStorage);
        AppendSubtool(TestCombinePathsStorage);
        return (UnrealAutomationToolConfig) this;
    }
/// <summary>Tests file utility functions.</summary>
    public UnrealAutomationToolConfig TestFileUtility(Action<TestFileUtilityConfig> configurator = null)
    {
        configurator?.Invoke(TestFileUtilityStorage);
        AppendSubtool(TestFileUtilityStorage);
        return (UnrealAutomationToolConfig) this;
    }

    public UnrealAutomationToolConfig TestLog(Action<TestLogConfig> configurator = null)
    {
        configurator?.Invoke(TestLogStorage);
        AppendSubtool(TestLogStorage);
        return (UnrealAutomationToolConfig) this;
    }
/// <summary>Tests P4 change filetype functionality.</summary>
/// <remarks>WARNING: This command might require Perforce</remarks>
    public UnrealAutomationToolConfig TestChangeFileType(Action<TestChangeFileTypeConfig> configurator = null)
    {
        configurator?.Invoke(TestChangeFileTypeStorage);
        AppendSubtool(TestChangeFileTypeStorage);
        return (UnrealAutomationToolConfig) this;
    }
/// <summary>Tests if UE4Build properly copies all relevent UAT build products to the Binaries folder.</summary>
    public UnrealAutomationToolConfig TestUATBuildProducts(Action<TestUATBuildProductsConfig> configurator = null)
    {
        configurator?.Invoke(TestUATBuildProductsStorage);
        AppendSubtool(TestUATBuildProductsStorage);
        return (UnrealAutomationToolConfig) this;
    }

    public UnrealAutomationToolConfig TestOSSCommands(Action<TestOSSCommandsConfig> configurator = null)
    {
        configurator?.Invoke(TestOSSCommandsStorage);
        AppendSubtool(TestOSSCommandsStorage);
        return (UnrealAutomationToolConfig) this;
    }
/// <summary>Builds a project using UBT. Syntax is similar to UBT with the exception of '-', i.e. UBT -QAGame -Development -Win32</summary>
    public UnrealAutomationToolConfig UBT(Action<UBTConfig> configurator = null)
    {
        configurator?.Invoke(UBTStorage);
        AppendSubtool(UBTStorage);
        return (UnrealAutomationToolConfig) this;
    }
/// <summary>Helper command to sync only source code + engine files from P4.</summary>
/// <remarks>WARNING: This command might require Perforce</remarks>
    public UnrealAutomationToolConfig SyncSource(Action<SyncSourceConfig> configurator = null)
    {
        configurator?.Invoke(SyncSourceStorage);
        AppendSubtool(SyncSourceStorage);
        return (UnrealAutomationToolConfig) this;
    }
/// <summary>Generates automation project based on a template.</summary>
    public UnrealAutomationToolConfig GenerateAutomationProject(Action<GenerateAutomationProjectConfig> configurator = null)
    {
        configurator?.Invoke(GenerateAutomationProjectStorage);
        AppendSubtool(GenerateAutomationProjectStorage);
        return (UnrealAutomationToolConfig) this;
    }

    public UnrealAutomationToolConfig DumpBranch(Action<DumpBranchConfig> configurator = null)
    {
        configurator?.Invoke(DumpBranchStorage);
        AppendSubtool(DumpBranchStorage);
        return (UnrealAutomationToolConfig) this;
    }
/// <summary>Sleeps for 20 seconds and then exits</summary>
    public UnrealAutomationToolConfig DebugSleep(Action<DebugSleepConfig> configurator = null)
    {
        configurator?.Invoke(DebugSleepStorage);
        AppendSubtool(DebugSleepStorage);
        return (UnrealAutomationToolConfig) this;
    }
/// <summary>Tests if Mcp configs loaded properly.</summary>
    public UnrealAutomationToolConfig TestMcpConfigs(Action<TestMcpConfigsConfig> configurator = null)
    {
        configurator?.Invoke(TestMcpConfigsStorage);
        AppendSubtool(TestMcpConfigsStorage);
        return (UnrealAutomationToolConfig) this;
    }
/// <summary>Test Blame P4 command.</summary>
/// <remarks>WARNING: This command might require Perforce</remarks>
    public UnrealAutomationToolConfig TestBlame(Action<TestBlameConfig> configurator = null)
    {
        configurator?.Invoke(TestBlameStorage);
        AppendSubtool(TestBlameStorage);
        return (UnrealAutomationToolConfig) this;
    }
/// <summary>Test P4 changes.</summary>
/// <remarks>WARNING: This command might require Perforce</remarks>
    public UnrealAutomationToolConfig TestChanges(Action<TestChangesConfig> configurator = null)
    {
        configurator?.Invoke(TestChangesStorage);
        AppendSubtool(TestChangesStorage);
        return (UnrealAutomationToolConfig) this;
    }
/// <summary>Spawns a process to test if UAT kills it automatically.</summary>
    public UnrealAutomationToolConfig TestKillAll(Action<TestKillAllConfig> configurator = null)
    {
        configurator?.Invoke(TestKillAllStorage);
        AppendSubtool(TestKillAllStorage);
        return (UnrealAutomationToolConfig) this;
    }
/// <summary>Tests CleanFormalBuilds.</summary>
    public UnrealAutomationToolConfig TestCleanFormalBuilds(Action<TestCleanFormalBuildsConfig> configurator = null)
    {
        configurator?.Invoke(TestCleanFormalBuildsStorage);
        AppendSubtool(TestCleanFormalBuildsStorage);
        return (UnrealAutomationToolConfig) this;
    }
/// <summary>Spawns a process to test if it can be killed.</summary>
    public UnrealAutomationToolConfig TestStopProcess(Action<TestStopProcessConfig> configurator = null)
    {
        configurator?.Invoke(TestStopProcessStorage);
        AppendSubtool(TestStopProcessStorage);
        return (UnrealAutomationToolConfig) this;
    }
/// <summary>Looks through an XGE xml for overlapping obj files</summary>
    public UnrealAutomationToolConfig LookForOverlappingBuildProducts(Action<LookForOverlappingBuildProductsConfig> configurator = null)
    {
        configurator?.Invoke(LookForOverlappingBuildProductsStorage);
        AppendSubtool(LookForOverlappingBuildProductsStorage);
        return (UnrealAutomationToolConfig) this;
    }
/// <summary>Copies all files from source directory to destination directory using ThreadedCopyFiles</summary>
    public UnrealAutomationToolConfig TestThreadedCopyFiles(Action<TestThreadedCopyFilesConfig> configurator = null)
    {
        configurator?.Invoke(TestThreadedCopyFilesStorage);
        AppendSubtool(TestThreadedCopyFilesStorage);
        return (UnrealAutomationToolConfig) this;
    }

    public UnrealAutomationToolConfig UE4BuildUtilDummyBuildCommand(Action<UE4BuildUtilDummyBuildCommandConfig> configurator = null)
    {
        configurator?.Invoke(UE4BuildUtilDummyBuildCommandStorage);
        AppendSubtool(UE4BuildUtilDummyBuildCommandStorage);
        return (UnrealAutomationToolConfig) this;
    }
/// <summary>Updates your local versions based on your P4 sync</summary>
/// <remarks>WARNING: This command might require Perforce</remarks>
    public UnrealAutomationToolConfig UpdateLocalVersion(Action<UpdateLocalVersionConfig> configurator = null)
    {
        configurator?.Invoke(UpdateLocalVersionStorage);
        AppendSubtool(UpdateLocalVersionStorage);
        return (UnrealAutomationToolConfig) this;
    }

    public UnrealAutomationToolConfig UploadDDCToAWS(Action<UploadDDCToAWSConfig> configurator = null)
    {
        configurator?.Invoke(UploadDDCToAWSStorage);
        AppendSubtool(UploadDDCToAWSStorage);
        return (UnrealAutomationToolConfig) this;
    }
/// <summary>ZipUtils is used to zip/unzip (i.e:RunUAT.bat ZipUtils -archive=D:/Content.zip -add=D:/UE/Pojects/SampleGame/Content/) or (i.e:RunUAT.bat ZipUtils -archive=D:/Content.zip -extract=D:/UE/Pojects/SampleGame/Content/)</summary>
    public UnrealAutomationToolConfig ZipUtils(Action<ZipUtilsConfig> configurator = null)
    {
        configurator?.Invoke(ZipUtilsStorage);
        AppendSubtool(ZipUtilsStorage);
        return (UnrealAutomationToolConfig) this;
    }
/// <summary>Runs benchmarks and reports overall results
/// Example1: RunUAT BenchmarkBuild -all -project=UE4
/// Example2: RunUAT BenchmarkBuild -allcompile -project=UE4+EngineTest -platform=PS4
/// Example3: RunUAT BenchmarkBuild -editor -client -cook -cooknoshaderddc -cooknoddc -xge -noxge -singlecompile -nopcompile -project=UE4+QAGame+EngineTest -platform=WIn64+PS4+XboxOne+Switch -iterations=3</summary>
    public UnrealAutomationToolConfig BenchmarkBuild(Action<BenchmarkBuildConfig> configurator = null)
    {
        configurator?.Invoke(BenchmarkBuildStorage);
        AppendSubtool(BenchmarkBuildStorage);
        return (UnrealAutomationToolConfig) this;
    }

    public UnrealAutomationToolConfig BenchmarkOptions(Action<BenchmarkOptionsConfig> configurator = null)
    {
        configurator?.Invoke(BenchmarkOptionsStorage);
        AppendSubtool(BenchmarkOptionsStorage);
        return (UnrealAutomationToolConfig) this;
    }

    public override string Gather()
    {
        Arguments.Insert(0, "UnrealAutomationTool");return base.Gather();
    }
}
