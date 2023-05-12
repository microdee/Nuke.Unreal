
// This file is generated via `nuke generate-tools` target.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace Nuke.Unreal.Tools;
/// <summary>Unreal Automation Tool is a vast collection of scripts solving all aspects of deploying a program made in Unreal Engine</summary>
public abstract class UatConfigGenerated : ToolConfig
{
    public override string Name => "Uat";
    public override string CliName => "";
    public override UnrealCompatibility Compatibility => UnrealCompatibility.UE4 | UnrealCompatibility.UE5;
    
/// <summary>Does not run any commands, only compiles them</summary>
        public virtual UatConfig CompileOnly(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-CompileOnly",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4,
                        AllowMultiple: true
                    )
                ));
            }
            return (UatConfig) this;
        }

        
/// <summary>Enables verbose logging</summary>
        public virtual UatConfig Verbose(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Verbose",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (UatConfig) this;
        }

        
    
        public virtual UatConfig TimeStamps(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-TimeStamps",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (UatConfig) this;
        }

        
/// <summary>Allows UAT command to submit changes</summary>
        public virtual UatConfig Submit(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Submit",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (UatConfig) this;
        }

        
/// <summary>Prevents any submit attempts</summary>
        public virtual UatConfig NoSubmit(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-NoSubmit",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (UatConfig) this;
        }

        
/// <summary>Disables Perforce functionality (default if not run on a build machine)
/// Disables Perforce functionality {default if not run on a build machine}</summary>
        public virtual UatConfig NoP4(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-NoP4",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (UatConfig) this;
        }

        
/// <summary>Enables Perforce functionality (default if run on a build machine)
/// Enables Perforce functionality {default if run on a build machine}</summary>
        public virtual UatConfig P4(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-P4",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (UatConfig) this;
        }

        
/// <summary>Dynamically compiles all commands (otherwise assumes they are already built)
/// Force all script modules to be compiled</summary>
        public virtual UatConfig Compile(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Compile",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (UatConfig) this;
        }

        
    
        public virtual UatConfig IgnoreDependencies(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-IgnoreDependencies",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (UatConfig) this;
        }

        
/// <summary>
/// This command is LEGACY because we used to run UAT.exe to compile scripts by default.
/// Now we only compile by default when run via RunUAT.bat, which still understands -nocompile.
/// However, the batch file simply passes on all arguments, so UAT will choke when encountering -nocompile.
/// Keep this CommandLineArg around so that doesn't happen.
/// </summary>
        public virtual UatConfig NoCompileLegacyDontUse(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-NoCompile",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4,
                        AllowMultiple: true
                    )
                ));
            }
            return (UatConfig) this;
        }

        
    
        public virtual UatConfig NoCompileEditor(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-NoCompileEditor",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4,
                        AllowMultiple: true
                    )
                ));
            }
            return (UatConfig) this;
        }

        
/// <summary>Displays help</summary>
        public virtual UatConfig Help(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Help",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (UatConfig) this;
        }

        
/// <summary>Lists all available commands</summary>
        public virtual UatConfig List(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-List",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (UatConfig) this;
        }

        
/// <summary>Does not kill any spawned processes on exit</summary>
        public virtual UatConfig NoKill(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-NoKill",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (UatConfig) this;
        }

        
    
        public virtual UatConfig UTF8Output(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-UTF8Output",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (UatConfig) this;
        }

        
    
        public virtual UatConfig AllowStdOutLogVerbosity(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-AllowStdOutLogVerbosity",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (UatConfig) this;
        }

        
    
        public virtual UatConfig NoAutoSDK(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-NoAutoSDK",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (UatConfig) this;
        }

        
/// <summary>Allows you to use local storage for your root build storage dir (default of P:\Builds (on PC) is changed to Engine\Saved\LocalBuilds). Used for local testing.
/// Allows you to use local storage for your root build storage dir {default of P:\Builds {on PC} is changed to Engine\Saved\LocalBuilds}. Used for local testing.</summary>
        public virtual UatConfig UseLocalBuildStorage(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-UseLocalBuildStorage",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (UatConfig) this;
        }

        
/// <summary>Prevents UBT from cleaning junk files</summary>
        public virtual UatConfig Ignorejunk(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-ignorejunk",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4,
                        AllowMultiple: true
                    )
                ));
            }
            return (UatConfig) this;
        }

        
    
        public virtual UatConfig Telemetry(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Telemetry",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4,
                        AllowMultiple: true
                    )
                ));
            }
            return (UatConfig) this;
        }

        
/// <summary>Enables very verbose logging</summary>
        public virtual UatConfig VeryVerbose(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-VeryVerbose",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (UatConfig) this;
        }

        
/// <summary>target platform for building, cooking and deployment (also -Platform)</summary>
        public virtual UatConfig Targetplatform(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-targetplatform",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (UatConfig) this;
        }

        
/// <summary>target platform for building, cooking and deployment of the dedicated server (also -ServerPlatform)</summary>
        public virtual UatConfig Servertargetplatform(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-servertargetplatform",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (UatConfig) this;
        }

        
/// <summary>Generate a foreign uproject from blankproject and use that
/// Shared: The current project is a foreign project, commandline: -foreign</summary>
        public virtual UatConfig Foreign(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-foreign",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (UatConfig) this;
        }

        
/// <summary>Generate a foreign code uproject from platformergame and use that
/// Shared: The current project is a foreign project, commandline: -foreign</summary>
        public virtual UatConfig Foreigncode(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-foreigncode",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (UatConfig) this;
        }

        
/// <summary>true if we should build crash reporter
/// Shared: true if we should build crash reporter</summary>
        public virtual UatConfig CrashReporter(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-CrashReporter",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (UatConfig) this;
        }

        
/// <summary>Determines if the build is going to use cooked data
/// Shared: Determines if the build is going to use cooked data, commandline: -cook, -cookonthefly</summary>
        public virtual UatConfig Cook(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-cook",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (UatConfig) this;
        }

        
/// <summary>use a cooked build, but we assume the cooked data is up to date and where it belongs, implies -cook
/// Shared: Determines if the build is going to use cooked data, commandline: -cook, -cookonthefly</summary>
        public virtual UatConfig Skipcook(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-skipcook",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (UatConfig) this;
        }

        
/// <summary>in a cookonthefly build, used solely to pass information to the package step
/// Shared: In a cookonthefly build, used solely to pass information to the package step. This is necessary because you can't set cookonthefly and cook at the same time, and skipcook sets cook.</summary>
        public virtual UatConfig Skipcookonthefly(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-skipcookonthefly",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (UatConfig) this;
        }

        
/// <summary>wipe intermediate folders before building
/// Shared: Determines if the intermediate folders will be wiped before building, commandline: -clean</summary>
        public virtual UatConfig Clean(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-clean",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (UatConfig) this;
        }

        
/// <summary>assumes no operator is present, always terminates without waiting for something.
/// Shared: Assumes no user is sitting at the console, so for example kills clients automatically, commandline: -Unattended</summary>
        public virtual UatConfig Unattended(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-unattended",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (UatConfig) this;
        }

        
/// <summary>generate a pak file
/// disable reuse of pak files from the alternate cook source folder, if specified
/// Shared: True if pak file should be generated.</summary>
        public virtual UatConfig Pak(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-pak",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (UatConfig) this;
        }

        
/// <summary>generate I/O store container file(s)
/// Shared: True if container file(s) should be generated with ZenPak.</summary>
        public virtual UatConfig Iostore(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-iostore",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (UatConfig) this;
        }

        
/// <summary>generate optimized config data during staging to improve loadtimes</summary>
        public virtual UatConfig Makebinaryconfig(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-makebinaryconfig",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (UatConfig) this;
        }

        
/// <summary>sign the generated pak file with the specified key, i.e. -signpak=C:\Encryption.keys. Also implies -signedpak.
/// Shared: Encryption keys used for signing the pak file.</summary>
        public virtual UatConfig Signpak(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-signpak",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (UatConfig) this;
        }

        
/// <summary>attempt to avoid cooking and instead pull pak files from the network, implies pak and skipcook
/// Shared: true if this build is staged, command line: -stage</summary>
        public virtual UatConfig Prepak(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-prepak",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (UatConfig) this;
        }

        
/// <summary>the game should expect to use a signed pak file.</summary>
        public virtual UatConfig Signed(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-signed",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (UatConfig) this;
        }

        
/// <summary>The game will be set up for memory mapping bulk data.
/// Shared: The game will be set up for memory mapping bulk data.</summary>
        public virtual UatConfig PakAlignForMemoryMapping(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-PakAlignForMemoryMapping",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (UatConfig) this;
        }

        
/// <summary>use a pak file, but assume it is already built, implies pak
/// Shared: true if this build is staged, command line: -stage</summary>
        public virtual UatConfig Skippak(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-skippak",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (UatConfig) this;
        }

        
/// <summary>override the -iostore commandline option to not run it
/// Shared: true if we want to skip iostore, even if -iostore is specified</summary>
        public virtual UatConfig Skipiostore(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-skipiostore",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (UatConfig) this;
        }

        
/// <summary>put this build in a stage directory
/// Shared: true if this build is staged, command line: -stage</summary>
        public virtual UatConfig Stage(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-stage",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (UatConfig) this;
        }

        
/// <summary>uses a stage directory, but assumes everything is already there, implies -stage
/// Shared: true if this build is staged, command line: -stage</summary>
        public virtual UatConfig Skipstage(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-skipstage",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (UatConfig) this;
        }

        
/// <summary>generate streaming install manifests when cooking data
/// Shared: true if this build is using streaming install manifests, command line: -manifests</summary>
        public virtual UatConfig Manifests(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-manifests",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (UatConfig) this;
        }

        
/// <summary>generate streaming install data from manifest when cooking data, requires -stage &amp; -manifests
/// Shared: true if this build chunk install streaming install data, command line: -createchunkinstalldata</summary>
        public virtual UatConfig Createchunkinstall(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-createchunkinstall",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (UatConfig) this;
        }

        
/// <summary>skips encrypting pak files even if crypto keys are provided</summary>
        public virtual UatConfig Skipencryption(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-skipencryption",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (UatConfig) this;
        }

        
/// <summary>Directory to copy the builds to, i.e. -stagingdirectory=C:\Stage</summary>
        public virtual UatConfig Stagingdirectory(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-stagingdirectory",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (UatConfig) this;
        }

        
/// <summary>Name of the UE4 Editor executable, i.e. -ue4exe=UE4Editor.exe</summary>
        public virtual UatConfig Ue4exe(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-ue4exe",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4,
                        AllowMultiple: true
                    )
                ));
            }
            return (UatConfig) this;
        }

        
/// <summary>put this build in an archive directory
/// Shared: true if this build is archived, command line: -archive</summary>
        public virtual UatConfig Archive(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-archive",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (UatConfig) this;
        }

        
/// <summary>Directory to archive the builds to, i.e. -archivedirectory=C:\Archive</summary>
        public virtual UatConfig Archivedirectory(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-archivedirectory",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (UatConfig) this;
        }

        
/// <summary>Archive extra metadata files in addition to the build (e.g. build.properties)
/// Whether the project should use non monolithic staging</summary>
        public virtual UatConfig Archivemetadata(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-archivemetadata",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (UatConfig) this;
        }

        
/// <summary>When archiving for Mac, set this to true to package it in a .app bundle instead of normal loose files</summary>
        public virtual UatConfig Createappbundle(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-createappbundle",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (UatConfig) this;
        }

        
/// <summary>True if build step should be executed
/// Build: True if build step should be executed, command: -build</summary>
        public virtual UatConfig Build(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-build",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (UatConfig) this;
        }

        
/// <summary>True if XGE should NOT be used for building
/// Build: True if XGE should NOT be used for building.
/// Toggle to disable the distributed build process</summary>
        public virtual UatConfig Noxge(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-noxge",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (UatConfig) this;
        }

        
/// <summary>while cooking clean up packages as we are done with them rather then cleaning everything up when we run out of space
/// Cook: While cooking clean up packages as we go along rather then cleaning everything (and potentially having to reload some of it) when we run out of space</summary>
        public virtual UatConfig CookPartialgc(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-CookPartialgc",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (UatConfig) this;
        }

        
/// <summary>Did we cook in the editor instead of in UAT
/// Stage: Did we cook in the editor instead of from UAT (cook in editor uses a different staging directory)</summary>
        public virtual UatConfig CookInEditor(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-CookInEditor",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (UatConfig) this;
        }

        
/// <summary>Uses the iterative cooking, command line: -iterativecooking or -iterate
/// Uses the iterative cooking, command line: -iterativedeploy or -iterate
/// Cook: Uses the iterative cooking, command line: -iterativecooking or -iterate</summary>
        public virtual UatConfig Iterativecooking(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-iterativecooking",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (UatConfig) this;
        }

        
/// <summary>Cook only maps this only affects usage of -cookall the flag
/// Cook: Only cook maps (and referenced content) instead of cooking everything only affects -cookall flag</summary>
        public virtual UatConfig CookMapsOnly(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-CookMapsOnly",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (UatConfig) this;
        }

        
/// <summary>Cook all the things in the content directory for this project
/// Cook: Only cook maps (and referenced content) instead of cooking everything only affects cookall flag</summary>
        public virtual UatConfig CookAll(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-CookAll",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (UatConfig) this;
        }

        
/// <summary>Skips content under /Engine/Editor when cooking
/// Cook: Skip cooking editor content</summary>
        public virtual UatConfig SkipCookingEditorContent(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-SkipCookingEditorContent",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (UatConfig) this;
        }

        
/// <summary>Uses fast cook path if supported by target</summary>
        public virtual UatConfig FastCook(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-FastCook",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (UatConfig) this;
        }

        
/// <summary>Ignores cook errors and continues with packaging etc
/// Cook: Ignores cook errors and continues with packaging etc.</summary>
        public virtual UatConfig IgnoreCookErrors(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-IgnoreCookErrors",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (UatConfig) this;
        }

        
/// <summary>do not copy debug files to the stage
/// Stage: Commandline: -nodebuginfo</summary>
        public virtual UatConfig Nodebuginfo(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-nodebuginfo",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (UatConfig) this;
        }

        
/// <summary>output debug info to a separate directory
/// Stage: Commandline: -separatedebuginfo</summary>
        public virtual UatConfig Separatedebuginfo(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-separatedebuginfo",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (UatConfig) this;
        }

        
/// <summary>generates a *.map file
/// Stage: Commandline: -mapfile</summary>
        public virtual UatConfig MapFile(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-MapFile",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (UatConfig) this;
        }

        
/// <summary>skip cleaning the stage directory
/// true if the staging directory is to be cleaned: -cleanstage (also true if -clean is specified)</summary>
        public virtual UatConfig Nocleanstage(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-nocleanstage",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (UatConfig) this;
        }

        
/// <summary>command line to put into the stage in UE4CommandLine.txt
/// command line to put into the stage in UECommandLine.txt</summary>
        public virtual UatConfig Cmdline(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-cmdline",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (UatConfig) this;
        }

        
/// <summary>string to use as the bundle name when deploying to mobile device
/// Stage: If non-empty, the contents will be used for the bundle name</summary>
        public virtual UatConfig Bundlename(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-bundlename",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (UatConfig) this;
        }

        
/// <summary>run the game after it is built (including server, if -server)
/// Run: True if the Run step should be executed, command: -run</summary>
        public virtual UatConfig Run(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-run",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (UatConfig) this;
        }

        
/// <summary>run the client with cooked data provided by cook on the fly server
/// Run: The client runs with cooked data provided by cook on the fly server, command line: -cookonthefly</summary>
        public virtual UatConfig Cookonthefly(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-cookonthefly",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (UatConfig) this;
        }

        
/// <summary>run the client in streaming cook on the fly mode (don't cache files locally instead force reget from server each file load)
/// Run: The client should run in streaming mode when connecting to cook on the fly server</summary>
        public virtual UatConfig Cookontheflystreaming(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Cookontheflystreaming",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (UatConfig) this;
        }

        
/// <summary>run the client with cooked data provided by UnrealFileServer
/// Run: The client runs with cooked data provided by UnrealFileServer, command line: -fileserver</summary>
        public virtual UatConfig Fileserver(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-fileserver",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (UatConfig) this;
        }

        
/// <summary>build, cook and run both a client and a server (also -server)
/// Run: The client connects to dedicated server to get data, command line: -dedicatedserver</summary>
        public virtual UatConfig Dedicatedserver(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-dedicatedserver",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (UatConfig) this;
        }

        
/// <summary>build, cook and run a client and a server, uses client target configuration
/// Run: Uses a client target configuration, also implies -dedicatedserver, command line: -client</summary>
        public virtual UatConfig Client(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-client",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (UatConfig) this;
        }

        
/// <summary>do not run the client, just run the server
/// Run: Whether the client should start or not, command line (to disable): -noclient</summary>
        public virtual UatConfig Noclient(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-noclient",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (UatConfig) this;
        }

        
/// <summary>create a log window for the client
/// Run: Client should create its own log window, command line: -logwindow</summary>
        public virtual UatConfig Logwindow(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-logwindow",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (UatConfig) this;
        }

        
/// <summary>map to run the game with</summary>
        public virtual UatConfig Map(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-map",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (UatConfig) this;
        }

        
/// <summary>Additional server map params, i.e ?param=value
/// Run: Additional server map params.</summary>
        public virtual UatConfig AdditionalServerMapParams(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-AdditionalServerMapParams",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (UatConfig) this;
        }

        
/// <summary>Devices to run the game on
/// Device names without the platform prefix to run the game on</summary>
        public virtual UatConfig Device(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-device",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (UatConfig) this;
        }

        
/// <summary>Device to run the server on
/// Run: the target device to run the server on</summary>
        public virtual UatConfig Serverdevice(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-serverdevice",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (UatConfig) this;
        }

        
/// <summary>Skip starting the server
/// Run: The indicated server has already been started</summary>
        public virtual UatConfig Skipserver(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-skipserver",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (UatConfig) this;
        }

        
/// <summary>Start extra clients, n should be 2 or more
/// Run: The indicated server has already been started</summary>
        public virtual UatConfig Numclients(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-numclients",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (UatConfig) this;
        }

        
/// <summary>Additional command line arguments for the program</summary>
        public virtual UatConfig Addcmdline(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-addcmdline",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (UatConfig) this;
        }

        
/// <summary>Additional command line arguments for the program</summary>
        public virtual UatConfig Servercmdline(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-servercmdline",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (UatConfig) this;
        }

        
/// <summary>Override command line arguments to pass to the client</summary>
        public virtual UatConfig Clientcmdline(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-clientcmdline",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (UatConfig) this;
        }

        
/// <summary>add -nullrhi to the client commandlines
/// Run:adds -nullrhi to the client commandline</summary>
        public virtual UatConfig Nullrhi(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-nullrhi",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (UatConfig) this;
        }

        
/// <summary>adds ?fake to the server URL
/// Run:adds ?fake to the server URL</summary>
        public virtual UatConfig Fakeclient(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-fakeclient",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (UatConfig) this;
        }

        
/// <summary>rather than running a client, run the editor instead
/// Run:adds ?fake to the server URL</summary>
        public virtual UatConfig Editortest(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-editortest",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (UatConfig) this;
        }

        
/// <summary>when running -editortest or a client, run all automation tests, not compatible with -server
/// when running -editortest or a client, run a specific automation tests, not compatible with -server
/// Run:when running -editortest or a client, run all automation tests, not compatible with -server</summary>
        public virtual UatConfig RunAutomationTests(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-RunAutomationTests",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (UatConfig) this;
        }

        
/// <summary>when running -editortest or a client, adds commands like debug crash, debug rendercrash, etc based on index</summary>
        public virtual UatConfig Crash(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Crash",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (UatConfig) this;
        }

        
/// <summary>Linux username for unattended key genereation</summary>
        public virtual UatConfig Deviceuser(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-deviceuser",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (UatConfig) this;
        }

        
/// <summary>Linux password</summary>
        public virtual UatConfig Devicepass(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-devicepass",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (UatConfig) this;
        }

        
/// <summary>package the project for the target platform
/// Determine whether data is packaged. This can be an iteration optimization for platforms that require packages for deployment</summary>
        public virtual UatConfig Package(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-package",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (UatConfig) this;
        }

        
/// <summary>Skips packaging the project for the target platform</summary>
        public virtual UatConfig Skippackage(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-skippackage",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (UatConfig) this;
        }

        
/// <summary>package for distribution the project</summary>
        public virtual UatConfig Distribution(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-distribution",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (UatConfig) this;
        }

        
/// <summary>stage prerequisites along with the project</summary>
        public virtual UatConfig Prereqs(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-prereqs",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (UatConfig) this;
        }

        
/// <summary>location of prerequisites for applocal deployment</summary>
        public virtual UatConfig Applocaldir(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-applocaldir",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (UatConfig) this;
        }

        
/// <summary>this is a prebuilt cooked and packaged build</summary>
        public virtual UatConfig Prebuilt(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Prebuilt",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (UatConfig) this;
        }

        
/// <summary>timeout to wait after we lunch the game</summary>
        public virtual UatConfig RunTimeoutSeconds(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-RunTimeoutSeconds",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (UatConfig) this;
        }

        
/// <summary>Determine a specific Minimum OS</summary>
        public virtual UatConfig SpecifiedArchitecture(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-SpecifiedArchitecture",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (UatConfig) this;
        }

        
/// <summary>extra options to pass to ubt</summary>
        public virtual UatConfig UbtArgs(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-UbtArgs",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (UatConfig) this;
        }

        
/// <summary>extra options to pass to the platform's packager</summary>
        public virtual UatConfig AdditionalPackageOptions(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-AdditionalPackageOptions",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (UatConfig) this;
        }

        
/// <summary>deploy the project for the target platform
/// Location to deploy to on the target platform</summary>
        public virtual UatConfig Deploy(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-deploy",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (UatConfig) this;
        }

        
/// <summary>download file from target after successful run</summary>
        public virtual UatConfig Getfile(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-getfile",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (UatConfig) this;
        }

        
/// <summary>List of maps that need light maps rebuilding</summary>
        public virtual UatConfig MapsToRebuildLightMaps(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-MapsToRebuildLightMaps",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (UatConfig) this;
        }

        
/// <summary>List of maps that need HLOD rebuilding</summary>
        public virtual UatConfig MapsToRebuildHLODMaps(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-MapsToRebuildHLODMaps",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (UatConfig) this;
        }

        
/// <summary>Whether Light Map errors should be treated as critical</summary>
        public virtual UatConfig IgnoreLightMapErrors(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-IgnoreLightMapErrors",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (UatConfig) this;
        }

        
    
        public virtual UatConfig Cookflavor(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-cookflavor",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (UatConfig) this;
        }

        
    
        public virtual UatConfig Ddc(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-ddc",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (UatConfig) this;
        }

        
    
        public virtual UatConfig I18npreset(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-i18npreset",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (UatConfig) this;
        }

        
    
        public virtual UatConfig CookCultures(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-CookCultures",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (UatConfig) this;
        }

        
    
        public virtual UatConfig Skipbuild(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-skipbuild",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (UatConfig) this;
        }

        
/// <summary>
/// SkipBuildClient if true then don't build the client exe
/// </summary>
        public virtual UatConfig SkipBuildClient(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-skipbuildclient",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (UatConfig) this;
        }

        
/// <summary>
/// SkipBuildEditor if true then don't build the editor exe
/// </summary>
        public virtual UatConfig SkipBuildEditor(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-skipbuildeditor",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (UatConfig) this;
        }

        
    
        public virtual UatConfig Createreleaseversionroot(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-createreleaseversionroot",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (UatConfig) this;
        }

        
    
        public virtual UatConfig Basedonreleaseversionroot(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-basedonreleaseversionroot",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (UatConfig) this;
        }

        
/// <summary>
/// The version of the originally released build. This is required by some platforms when generating patches.
/// </summary>
        public virtual UatConfig OriginalReleaseVersion(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-originalreleaseversion",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (UatConfig) this;
        }

        
/// <summary>
/// Cook: Create a cooked release version.  Also, the version. e.g. 1.0
/// </summary>
        public virtual UatConfig CreateReleaseVersion(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-createreleaseversion",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (UatConfig) this;
        }

        
/// <summary>
/// Cook: Base this cook of a already released version of the cooked data
/// </summary>
        public virtual UatConfig BasedOnReleaseVersion(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-basedonreleaseversion",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (UatConfig) this;
        }

        
/// <summary>
/// Are we generating a patch, generate a patch from a previously released version of the game (use CreateReleaseVersion to create a release).
/// this requires BasedOnReleaseVersion
/// see also CreateReleaseVersion, BasedOnReleaseVersion
/// </summary>
        public virtual UatConfig GeneratePatch(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-GeneratePatch",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (UatConfig) this;
        }

        
/// <summary></summary>
        public virtual UatConfig AddPatchLevel(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-AddPatchLevel",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (UatConfig) this;
        }

        
/// <summary>
/// Are we staging the unmodified pak files from the base release</summary>
        public virtual UatConfig StageBaseReleasePaks(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-StageBaseReleasePaks",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (UatConfig) this;
        }

        
/// <summary>
/// Required when building remaster package
/// </summary>
        public virtual UatConfig DiscVersion(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-DiscVersion",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (UatConfig) this;
        }

        
/// <summary>
/// Cook: Additional cooker options to include on the cooker commandline
/// </summary>
        public virtual UatConfig AdditionalCookerOptions(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-AdditionalCookerOptions",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (UatConfig) this;
        }

        
    
        public virtual UatConfig DLCName(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-DLCName",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (UatConfig) this;
        }

        
/// <summary>
/// After cook completes diff the cooked content against another cooked content directory.
/// report all errors to the log
/// </summary>
        public virtual UatConfig DiffCookedContentPath(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-DiffCookedContentPath",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (UatConfig) this;
        }

        
/// <summary>
/// Enable cooking of engine content when cooking dlc
/// not included in original release but is referenced by current cook
/// </summary>
        public virtual UatConfig DLCIncludeEngineContent(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-DLCIncludeEngineContent",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (UatConfig) this;
        }

        
/// <summary>
/// Enable packaging up the uplugin file inside the dlc pak.  This is sometimes desired if you want the plugin to be standalone
/// </summary>
        public virtual UatConfig DLCPakPluginFile(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-DLCPakPluginFile",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (UatConfig) this;
        }

        
/// <summary>
/// DLC will remap it's files to the game directory and act like a patch.  This is useful if you want to override content in the main game along side your main game.
/// For example having different main game content in different DLCs
/// </summary>
        public virtual UatConfig DLCActLikePatch(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-DLCActLikePatch",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (UatConfig) this;
        }

        
/// <summary>
/// Shared: the game will use only signed content.
/// </summary>
        public virtual UatConfig SignedPak(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-signedpak",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (UatConfig) this;
        }

        
/// <summary>
/// Stage: True if we should disable trying to re-use pak files from another staged build when we've specified a different cook source platform
/// </summary>
        public virtual UatConfig IgnorePaksFromDifferentCookSource(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-IgnorePaksFromDifferentCookSource",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (UatConfig) this;
        }

        
/// <summary>
/// Cook: Do not include a version number in the cooked content
/// </summary>
        public virtual UatConfig UnversionedCookedContent(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-UnversionedCookedContent",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (UatConfig) this;
        }

        
/// <summary>
/// Cook: number of additional cookers to spawn while cooking
/// </summary>
        public virtual UatConfig NumCookersToSpawn(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-NumCookersToSpawn",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4,
                        AllowMultiple: true
                    )
                ));
            }
            return (UatConfig) this;
        }

        
/// <summary>
/// Compress packages during cook.
/// </summary>
        public virtual UatConfig Compressed(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-compressed",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (UatConfig) this;
        }

        
/// <summary>
/// Do not compress packages during cook, override game ProjectPackagingSettings to force it off
/// </summary>
        public virtual UatConfig ForceUncompressed(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-ForceUncompressed",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (UatConfig) this;
        }

        
/// <summary>
/// Additional parameters when generating the PAK file
/// </summary>
        public virtual UatConfig AdditionalPakOptions(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-AdditionalPakOptions",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (UatConfig) this;
        }

        
/// <summary>
/// Additional parameters when generating iostore container files
/// </summary>
        public virtual UatConfig AdditionalIoStoreOptions(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-AdditionalIoStoreOptions",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (UatConfig) this;
        }

        
/// <summary>
/// Cook: Iterate from a build on the network
/// </summary>
        public virtual UatConfig Iteratesharedcookedbuild(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-iteratesharedcookedbuild",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (UatConfig) this;
        }

        
/// <summary>
/// Build: Don't build the game instead use the prebuild exe (requires iterate shared cooked build
/// </summary>
        public virtual UatConfig IterateSharedBuildUsePrecompiledExe(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-IterateSharedBuildUsePrecompiledExe",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (UatConfig) this;
        }

        
/// <summary>
/// Cook: Output directory for cooked data
/// </summary>
        public virtual UatConfig CookOutputDir(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-CookOutputDir",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (UatConfig) this;
        }

        
    
        public virtual UatConfig Target(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-target",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (UatConfig) this;
        }

        
/// <summary>Stage: Specifies a list of extra targets that should be staged along with a client
/// </summary>
        public virtual UatConfig ExtraTargetsToStageWithClient(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-ExtraTargetsToStageWithClient",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (UatConfig) this;
        }

        
/// <summary>
/// By default we don't code sign unless it is required or requested
/// </summary>
        public virtual UatConfig CodeSign(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-CodeSign",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (UatConfig) this;
        }

        
/// <summary>
/// If true, non-shipping binaries will be considered DebugUFS files and will appear on the debugfiles manifest
/// </summary>
        public virtual UatConfig TreatNonShippingBinariesAsDebugFiles(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-TreatNonShippingBinariesAsDebugFiles",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (UatConfig) this;
        }

        
/// <summary>
/// If true, use chunk manifest files generated for extra flavor
/// </summary>
        public virtual UatConfig UseExtraFlavor(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-UseExtraFlavor",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (UatConfig) this;
        }

        
/// <summary>
/// Shared: Directory to use for built chunk install data, command line: -chunkinstalldirectory=
/// </summary>
        public virtual UatConfig ChunkInstallDirectory(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-chunkinstalldirectory",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (UatConfig) this;
        }

        
    
        public virtual UatConfig Chunkinstallversion(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-chunkinstallversion",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (UatConfig) this;
        }

        
    
        public virtual UatConfig Chunkinstallrelease(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-chunkinstallrelease",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (UatConfig) this;
        }

        
    
        public virtual UatConfig AppLocalDirectory(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-applocaldirectory",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (UatConfig) this;
        }

        
/// <summary>
/// On Windows, adds an executable to the root of the staging directory which checks for prerequisites being
/// installed and launches the game with a path to the .uproject file.
/// </summary>
        public virtual UatConfig NoBootstrapExe(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-nobootstrapexe",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (UatConfig) this;
        }

        
    
        public virtual UatConfig ForcePackageData(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-forcepackagedata",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (UatConfig) this;
        }

        
/// <summary>
/// Cook: Uses the iterative deploy, command line: -iterativedeploy or -iterate
/// </summary>
        public virtual UatConfig IterativeDeploy(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-iterativedeploy",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (UatConfig) this;
        }

        
/// <summary>
/// Provision to use
/// </summary>
        public virtual UatConfig Provision(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-provision",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (UatConfig) this;
        }

        
/// <summary>
/// Certificate to use
/// </summary>
        public virtual UatConfig Certificate(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-certificate",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (UatConfig) this;
        }

        
/// <summary>
/// Team ID to use
/// </summary>
        public virtual UatConfig Team(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-team",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (UatConfig) this;
        }

        
/// <summary>
/// true if provisioning is automatically managed
/// </summary>
        public virtual UatConfig AutomaticSigning(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-AutomaticSigning",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (UatConfig) this;
        }

        
/// <summary>
/// Run:when running -editortest or a client, run all automation tests, not compatible with -server
/// </summary>
        public virtual UatConfig RunAutomationTest(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-RunAutomationTest",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (UatConfig) this;
        }

        
/// <summary>Name of the Unreal Editor executable, i.e. -unrealexe=UnrealEditor.exe</summary>
        public virtual UatConfig UnrealExe(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-ue4exe",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (UatConfig) this;
        }

        
    
        public virtual UatConfig Clientconfig(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-clientconfig",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (UatConfig) this;
        }

        
    
        public virtual UatConfig Config(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-config",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (UatConfig) this;
        }

        
    
        public virtual UatConfig Configuration(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-configuration",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (UatConfig) this;
        }

        
    
        public virtual UatConfig Port(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-port",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (UatConfig) this;
        }

        
/// <summary>
/// Cook: List of maps to cook.
/// </summary>
        public virtual UatConfig MapsToCook(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-MapsToCook",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (UatConfig) this;
        }

        
/// <summary>
/// Cook: List of map inisections to cook (see allmaps)
/// </summary>
        public virtual UatConfig MapIniSectionsToCook(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-MapIniSectionsToCook",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (UatConfig) this;
        }

        
/// <summary>
/// TitleID to package
/// </summary>
        public virtual UatConfig TitleID(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-TitleID",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (UatConfig) this;
        }

        
    
        public virtual UatConfig Serverconfig(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-serverconfig",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (UatConfig) this;
        }

        
/// <summary>
/// Run: Adds commands like debug crash, debug rendercrash, etc based on index
/// </summary>
        public virtual UatConfig CrashIndex(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-CrashIndex",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (UatConfig) this;
        }

        
/// <summary>Do not attempt to compile any script modules - attempts to run with whatever is up to date</summary>
        public virtual UatConfig NoCompile(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-NoCompile",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (UatConfig) this;
        }

        
/// <summary>Ignore build records (Intermediate/ScriptModule/ProjectName.json) files when determining if script modules are up to date</summary>
        public virtual UatConfig IgnoreBuildRecords(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-IgnoreBuildRecords",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (UatConfig) this;
        }

        
/// <summary>Waits for a debugger to be attached, and breaks once debugger successfully attached.</summary>
        public virtual UatConfig WaitForDebugger(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-WaitForDebugger",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (UatConfig) this;
        }

        
    
        public virtual UatConfig BuildMachine(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-BuildMachine",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (UatConfig) this;
        }

        
    
        public virtual UatConfig WaitForUATMutex(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-WaitForUATMutex",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (UatConfig) this;
        }

        
/// <summary>generate I/O store container file(s)
/// Shared: True if the cooker should write directly to container file(s)</summary>
        public virtual UatConfig Cook4iostore(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-cook4iostore",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (UatConfig) this;
        }

        
/// <summary>save cooked output data to the Zen storage server
/// Shared: True if the cooker should store the cooked output to the Zen storage server</summary>
        public virtual UatConfig Zenstore(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-zenstore",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (UatConfig) this;
        }

        
/// <summary>URL to a running Zen server
/// Shared: URL to a running Zen server</summary>
        public virtual UatConfig Nozenautolaunch(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-nozenautolaunch",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (UatConfig) this;
        }

        
/// <summary>Should virtualized assets be rehydrated?
/// Shared: true if we want to rehydrate virtualized assets when staging.</summary>
        public virtual UatConfig Rehydrateassets(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-rehydrateassets",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (UatConfig) this;
        }

        
/// <summary>Directory to copy the optional files to, i.e. -optionalfilestagingdirectory=C:\StageOptional</summary>
        public virtual UatConfig Optionalfilestagingdirectory(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-optionalfilestagingdirectory",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (UatConfig) this;
        }

        
/// <summary>Directory to read the optional files from, i.e. -optionalfileinputdirectory=C:\StageOptional</summary>
        public virtual UatConfig Optionalfileinputdirectory(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-optionalfileinputdirectory",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (UatConfig) this;
        }

        
/// <summary>Subdirectory under staging to copy CookerSupportFiles (as set in Build.cs files). -CookerSupportFilesSubdirectory=SDK</summary>
        public virtual UatConfig CookerSupportFilesSubdirectory(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-CookerSupportFilesSubdirectory",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (UatConfig) this;
        }

        
/// <summary>Skips preparing data that would be used during packaging, in earlier stages. Different from skippackage which is used to optimize later stages like archive, which still was packaged at some point</summary>
        public virtual UatConfig Neverpackage(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-neverpackage",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (UatConfig) this;
        }

        
/// <summary>Path to file containing encryption key to use in packaging</summary>
        public virtual UatConfig PackageEncryptionKeyFile(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-PackageEncryptionKeyFile",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (UatConfig) this;
        }

        
/// <summary>The list of trace channels to enable</summary>
        public virtual UatConfig Trace(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-trace",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (UatConfig) this;
        }

        
/// <summary>The host address of the trace recorder</summary>
        public virtual UatConfig Tracehost(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-tracehost",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (UatConfig) this;
        }

        
/// <summary>The file where the trace will be recorded</summary>
        public virtual UatConfig Tracefile(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-tracefile",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (UatConfig) this;
        }

        
/// <summary>A label to pass to analytics</summary>
        public virtual UatConfig Sessionlabel(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-sessionlabel",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (UatConfig) this;
        }

        
/// <summary>
/// Stage: Path to the global.utoc file for a directory of iostore containers to use as a source of compressed
/// chunks when writing new containers. See -ReferenceContainerGlobalFileName in IoStoreUtilities.cpp.
/// </summary>
        public virtual UatConfig ReferenceContainerGlobalFileName(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-ReferenceContainerGlobalFileName",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (UatConfig) this;
        }

        
/// <summary>
/// Stage: Path to the crypto.json file to use for decrypting ReferenceContainerFlobalFileName, if needed.
/// </summary>
        public virtual UatConfig ReferenceContainerCryptoKeys(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-ReferenceContainerCryptoKeys",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (UatConfig) this;
        }

        
/// <summary>
/// Sometimes a DLC may get cooked to a subdirectory of where is expected, so this can tell the staging what the subdirectory of the cooked out
/// to find the DLC files (for instance Metadata)
/// </summary>
        public virtual UatConfig DLCOverrideCookedSubDir(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-DLCOverrideCookedSubDir",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (UatConfig) this;
        }

        
/// <summary>
/// Controls where under the staged directory to output to (in case the plugin subdirectory is not desired under the StagingDirectory location)
/// </summary>
        public virtual UatConfig DLCOverrideStagedSubDir(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-DLCOverrideStagedSubDir",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (UatConfig) this;
        }

        
    
        public virtual UatConfig Editoroptional(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-editoroptional",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (UatConfig) this;
        }

        
    
    public  class ProgramConfig : ToolConfig
    {
        public override string Name => "Program";
        public override string CliName => "";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE4 | UnrealCompatibility.UE5;
    
    
        public virtual ProgramConfig Utf8output(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Utf8output",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (ProgramConfig) this;
        }

        
/// <summary>Enables verbose logging</summary>
        public virtual ProgramConfig Verbose(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Verbose",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (ProgramConfig) this;
        }

        
/// <summary>Enables very verbose logging</summary>
        public virtual ProgramConfig VeryVerbose(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-VeryVerbose",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (ProgramConfig) this;
        }

        
    
        public virtual ProgramConfig Timestamps(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Timestamps",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (ProgramConfig) this;
        }

        
/// <summary>Allows UAT command to submit changes</summary>
        public virtual ProgramConfig Submit(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Submit",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (ProgramConfig) this;
        }

        
/// <summary>Prevents any submit attempts</summary>
        public virtual ProgramConfig NoSubmit(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-NoSubmit",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (ProgramConfig) this;
        }

        
/// <summary>Disables Perforce functionality {default if not run on a build machine}</summary>
        public virtual ProgramConfig NoP4(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-NoP4",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (ProgramConfig) this;
        }

        
/// <summary>Enables Perforce functionality {default if run on a build machine}</summary>
        public virtual ProgramConfig P4(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-P4",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (ProgramConfig) this;
        }

        
    
        public virtual ProgramConfig IgnoreDependencies(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-IgnoreDependencies",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (ProgramConfig) this;
        }

        
/// <summary>Displays help</summary>
        public virtual ProgramConfig Help(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Help",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (ProgramConfig) this;
        }

        
/// <summary>Lists all available commands</summary>
        public virtual ProgramConfig List(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-List",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (ProgramConfig) this;
        }

        
/// <summary>Does not kill any spawned processes on exit</summary>
        public virtual ProgramConfig NoKill(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-NoKill",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (ProgramConfig) this;
        }

        
    
        public virtual ProgramConfig AllowStdOutLogVerbosity(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-AllowStdOutLogVerbosity",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (ProgramConfig) this;
        }

        
    
        public virtual ProgramConfig NoAutoSDK(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-NoAutoSDK",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (ProgramConfig) this;
        }

        
/// <summary>Force all script modules to be compiled</summary>
        public virtual ProgramConfig Compile(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Compile",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (ProgramConfig) this;
        }

        
/// <summary>Do not attempt to compile any script modules - attempts to run with whatever is up to date</summary>
        public virtual ProgramConfig NoCompile(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-NoCompile",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (ProgramConfig) this;
        }

        
/// <summary>Ignore build records (Intermediate/ScriptModule/ProjectName.json) files when determining if script modules are up to date</summary>
        public virtual ProgramConfig IgnoreBuildRecords(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-IgnoreBuildRecords",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (ProgramConfig) this;
        }

        
/// <summary>Allows you to use local storage for your root build storage dir {default of P:\Builds {on PC} is changed to Engine\Saved\LocalBuilds}. Used for local testing.</summary>
        public virtual ProgramConfig UseLocalBuildStorage(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-UseLocalBuildStorage",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (ProgramConfig) this;
        }

        
/// <summary>Waits for a debugger to be attached, and breaks once debugger successfully attached.</summary>
        public virtual ProgramConfig WaitForDebugger(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-WaitForDebugger",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (ProgramConfig) this;
        }

        
    
        public virtual ProgramConfig BuildMachine(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-BuildMachine",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (ProgramConfig) this;
        }

        
    
        public virtual ProgramConfig WaitForUATMutex(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-WaitForUATMutex",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (ProgramConfig) this;
        }
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    }

    protected readonly ProgramConfig ProgramStorage = new();
        
/// <summary>Executes scripted commands
/// 
/// AutomationTool.exe [-verbose] [-compileonly] [-p4] Command0 [-Arg0 -Arg1 -Arg2 ...] Command1 [-Arg0 -Arg1 ...] Command2 [-Arg0 ...] Commandn ... [EnvVar0=MyValue0 ... EnvVarn=MyValuen]</summary>
    public  class AutomationConfig : ToolConfig
    {
        public override string Name => "Automation";
        public override string CliName => "";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE4 | UnrealCompatibility.UE5;
    
/// <summary>Enables verbose logging</summary>
        public virtual AutomationConfig Verbose(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-verbose",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4,
                        AllowMultiple: true
                    )
                ));
            }
            return (AutomationConfig) this;
        }

        
/// <summary>Disables Perforce functionality (default if not run on a build machine)</summary>
        public virtual AutomationConfig Nop4(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-nop4",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4,
                        AllowMultiple: true
                    )
                ));
            }
            return (AutomationConfig) this;
        }

        
/// <summary>Enables Perforce functionality (default if run on a build machine)</summary>
        public virtual AutomationConfig P4(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-p4",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4,
                        AllowMultiple: true
                    )
                ));
            }
            return (AutomationConfig) this;
        }

        
/// <summary>Does not run any commands, only compiles them</summary>
        public virtual AutomationConfig Compileonly(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-compileonly",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4,
                        AllowMultiple: true
                    )
                ));
            }
            return (AutomationConfig) this;
        }

        
/// <summary>Dynamically compiles all commands (otherwise assumes they are already built)</summary>
        public virtual AutomationConfig Compile(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-compile",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4,
                        AllowMultiple: true
                    )
                ));
            }
            return (AutomationConfig) this;
        }

        
/// <summary>Displays help</summary>
        public virtual AutomationConfig Help(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-help",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4,
                        AllowMultiple: true
                    )
                ));
            }
            return (AutomationConfig) this;
        }

        
/// <summary>Lists all available commands</summary>
        public virtual AutomationConfig List(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-list",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4,
                        AllowMultiple: true
                    )
                ));
            }
            return (AutomationConfig) this;
        }

        
/// <summary>Allows UAT command to submit changes</summary>
        public virtual AutomationConfig Submit(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-submit",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4,
                        AllowMultiple: true
                    )
                ));
            }
            return (AutomationConfig) this;
        }

        
/// <summary>Prevents any submit attempts</summary>
        public virtual AutomationConfig Nosubmit(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-nosubmit",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4,
                        AllowMultiple: true
                    )
                ));
            }
            return (AutomationConfig) this;
        }

        
/// <summary>Does not kill any spawned processes on exit</summary>
        public virtual AutomationConfig Nokill(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-nokill",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4,
                        AllowMultiple: true
                    )
                ));
            }
            return (AutomationConfig) this;
        }

        
/// <summary>Prevents UBT from cleaning junk files</summary>
        public virtual AutomationConfig Ignorejunk(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-ignorejunk",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4,
                        AllowMultiple: true
                    )
                ));
            }
            return (AutomationConfig) this;
        }

        
/// <summary>Allows you to use local storage for your root build storage dir (default of P:\Builds (on PC) is changed to Engine\Saved\LocalBuilds). Used for local testing.</summary>
        public virtual AutomationConfig UseLocalBuildStorage(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-UseLocalBuildStorage",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4,
                        AllowMultiple: true
                    )
                ));
            }
            return (AutomationConfig) this;
        }

        
    
        public virtual AutomationConfig Telemetry(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Telemetry",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4,
                        AllowMultiple: true
                    )
                ));
            }
            return (AutomationConfig) this;
        }
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    }

    protected readonly AutomationConfig AutomationStorage = new();
        
    
    public  class CodeSignConfig : ToolConfig
    {
        public override string Name => "CodeSign";
        public override string CliName => "";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE4 | UnrealCompatibility.UE5;
    
/// <summary>Skips signing of code/content files.</summary>
        public virtual CodeSignConfig NoSign(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-NoSign",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (CodeSignConfig) this;
        }
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    }

    protected readonly CodeSignConfig CodeSignStorage = new();
        
    
    public  class McpConfigMapperConfig : ToolConfig
    {
        public override string Name => "McpConfigMapper";
        public override string CliName => "";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE4 | UnrealCompatibility.UE5;
    
    
        public virtual McpConfigMapperConfig MCPConfig(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-MCPConfig",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (McpConfigMapperConfig) this;
        }
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    }

    protected readonly McpConfigMapperConfig McpConfigMapperStorage = new();
        
    
    public  class P4EnvironmentConfig : ToolConfig
    {
        public override string Name => "P4Environment";
        public override string CliName => "";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE4 | UnrealCompatibility.UE5;
    
/// <summary>
/// The Perforce host and port number (eg. perforce:1666)
/// </summary>
        public virtual P4EnvironmentConfig P4port(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-p4port",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (P4EnvironmentConfig) this;
        }

        
    
        public virtual P4EnvironmentConfig P4user(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-p4user",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (P4EnvironmentConfig) this;
        }
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    }

    protected readonly P4EnvironmentConfig P4EnvironmentStorage = new();
        
/// <summary>Auto-detects P4 settings based on the current path and creates a p4config file with the relevant settings.</summary>
    public  class P4WriteConfigConfig : ToolConfig
    {
        public override string Name => "P4WriteConfig";
        public override string CliName => "P4WriteConfig";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE4 | UnrealCompatibility.UE5;
    
/// <summary>Adds a P4IGNORE to the default file (Engine/Extras/Perforce/p4ignore)</summary>
        public virtual P4WriteConfigConfig Setignore(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-setignore",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (P4WriteConfigConfig) this;
        }

        
/// <summary>Write to a path other than the current directory</summary>
        public virtual P4WriteConfigConfig Path(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-path",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (P4WriteConfigConfig) this;
        }

        
/// <summary>Optional hint/override of the server to use during lookup</summary>
        public virtual P4WriteConfigConfig P4port(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-p4port",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (P4WriteConfigConfig) this;
        }

        
/// <summary>Optional hint/override of the username to use during lookup</summary>
        public virtual P4WriteConfigConfig P4user(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-p4user",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (P4WriteConfigConfig) this;
        }

        
    
        public virtual P4WriteConfigConfig Listonly(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-listonly",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (P4WriteConfigConfig) this;
        }
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    }

    protected readonly P4WriteConfigConfig P4WriteConfigStorage = new();
        
/// <summary>Iteratively cook from a shared cooked build
/// Iteratively cook from a shared cooked build</summary>
    public  class ProjectParamsConfig : ToolConfig
    {
        public override string Name => "ProjectParams";
        public override string CliName => "";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE4 | UnrealCompatibility.UE5;
    
/// <summary>target platform for building, cooking and deployment (also -Platform)</summary>
        public virtual ProjectParamsConfig Targetplatform(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-targetplatform",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (ProjectParamsConfig) this;
        }

        
/// <summary>target platform for building, cooking and deployment of the dedicated server (also -ServerPlatform)</summary>
        public virtual ProjectParamsConfig Servertargetplatform(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-servertargetplatform",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (ProjectParamsConfig) this;
        }

        
/// <summary>Generate a foreign uproject from blankproject and use that
/// Shared: The current project is a foreign project, commandline: -foreign</summary>
        public virtual ProjectParamsConfig Foreign(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-foreign",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (ProjectParamsConfig) this;
        }

        
/// <summary>Generate a foreign code uproject from platformergame and use that
/// Shared: The current project is a foreign project, commandline: -foreign</summary>
        public virtual ProjectParamsConfig Foreigncode(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-foreigncode",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (ProjectParamsConfig) this;
        }

        
/// <summary>true if we should build crash reporter
/// Shared: true if we should build crash reporter</summary>
        public virtual ProjectParamsConfig CrashReporter(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-CrashReporter",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (ProjectParamsConfig) this;
        }

        
/// <summary>Determines if the build is going to use cooked data
/// Shared: Determines if the build is going to use cooked data, commandline: -cook, -cookonthefly</summary>
        public virtual ProjectParamsConfig Cook(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-cook",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (ProjectParamsConfig) this;
        }

        
/// <summary>use a cooked build, but we assume the cooked data is up to date and where it belongs, implies -cook
/// Shared: Determines if the build is going to use cooked data, commandline: -cook, -cookonthefly</summary>
        public virtual ProjectParamsConfig Skipcook(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-skipcook",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (ProjectParamsConfig) this;
        }

        
/// <summary>in a cookonthefly build, used solely to pass information to the package step
/// Shared: In a cookonthefly build, used solely to pass information to the package step. This is necessary because you can't set cookonthefly and cook at the same time, and skipcook sets cook.</summary>
        public virtual ProjectParamsConfig Skipcookonthefly(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-skipcookonthefly",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (ProjectParamsConfig) this;
        }

        
/// <summary>wipe intermediate folders before building
/// Shared: Determines if the intermediate folders will be wiped before building, commandline: -clean</summary>
        public virtual ProjectParamsConfig Clean(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-clean",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (ProjectParamsConfig) this;
        }

        
/// <summary>assumes no operator is present, always terminates without waiting for something.
/// Shared: Assumes no user is sitting at the console, so for example kills clients automatically, commandline: -Unattended</summary>
        public virtual ProjectParamsConfig Unattended(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-unattended",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (ProjectParamsConfig) this;
        }

        
/// <summary>generate a pak file
/// disable reuse of pak files from the alternate cook source folder, if specified
/// Shared: True if pak file should be generated.</summary>
        public virtual ProjectParamsConfig Pak(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-pak",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (ProjectParamsConfig) this;
        }

        
/// <summary>generate I/O store container file(s)
/// Shared: True if container file(s) should be generated with ZenPak.</summary>
        public virtual ProjectParamsConfig Iostore(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-iostore",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (ProjectParamsConfig) this;
        }

        
/// <summary>generate optimized config data during staging to improve loadtimes</summary>
        public virtual ProjectParamsConfig Makebinaryconfig(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-makebinaryconfig",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (ProjectParamsConfig) this;
        }

        
/// <summary>sign the generated pak file with the specified key, i.e. -signpak=C:\Encryption.keys. Also implies -signedpak.
/// Shared: Encryption keys used for signing the pak file.</summary>
        public virtual ProjectParamsConfig Signpak(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-signpak",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (ProjectParamsConfig) this;
        }

        
/// <summary>attempt to avoid cooking and instead pull pak files from the network, implies pak and skipcook
/// Shared: true if this build is staged, command line: -stage</summary>
        public virtual ProjectParamsConfig Prepak(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-prepak",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (ProjectParamsConfig) this;
        }

        
/// <summary>the game should expect to use a signed pak file.</summary>
        public virtual ProjectParamsConfig Signed(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-signed",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (ProjectParamsConfig) this;
        }

        
/// <summary>The game will be set up for memory mapping bulk data.
/// Shared: The game will be set up for memory mapping bulk data.</summary>
        public virtual ProjectParamsConfig PakAlignForMemoryMapping(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-PakAlignForMemoryMapping",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (ProjectParamsConfig) this;
        }

        
/// <summary>use a pak file, but assume it is already built, implies pak
/// Shared: true if this build is staged, command line: -stage</summary>
        public virtual ProjectParamsConfig Skippak(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-skippak",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (ProjectParamsConfig) this;
        }

        
/// <summary>override the -iostore commandline option to not run it
/// Shared: true if we want to skip iostore, even if -iostore is specified</summary>
        public virtual ProjectParamsConfig Skipiostore(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-skipiostore",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (ProjectParamsConfig) this;
        }

        
/// <summary>put this build in a stage directory
/// Shared: true if this build is staged, command line: -stage</summary>
        public virtual ProjectParamsConfig Stage(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-stage",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (ProjectParamsConfig) this;
        }

        
/// <summary>uses a stage directory, but assumes everything is already there, implies -stage
/// Shared: true if this build is staged, command line: -stage</summary>
        public virtual ProjectParamsConfig Skipstage(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-skipstage",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (ProjectParamsConfig) this;
        }

        
/// <summary>generate streaming install manifests when cooking data
/// Shared: true if this build is using streaming install manifests, command line: -manifests</summary>
        public virtual ProjectParamsConfig Manifests(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-manifests",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (ProjectParamsConfig) this;
        }

        
/// <summary>generate streaming install data from manifest when cooking data, requires -stage &amp; -manifests
/// Shared: true if this build chunk install streaming install data, command line: -createchunkinstalldata</summary>
        public virtual ProjectParamsConfig Createchunkinstall(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-createchunkinstall",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (ProjectParamsConfig) this;
        }

        
/// <summary>skips encrypting pak files even if crypto keys are provided</summary>
        public virtual ProjectParamsConfig Skipencryption(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-skipencryption",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (ProjectParamsConfig) this;
        }

        
/// <summary>Directory to copy the builds to, i.e. -stagingdirectory=C:\Stage</summary>
        public virtual ProjectParamsConfig Stagingdirectory(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-stagingdirectory",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (ProjectParamsConfig) this;
        }

        
/// <summary>Name of the UE4 Editor executable, i.e. -ue4exe=UE4Editor.exe</summary>
        public virtual ProjectParamsConfig Ue4exe(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-ue4exe",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4,
                        AllowMultiple: true
                    )
                ));
            }
            return (ProjectParamsConfig) this;
        }

        
/// <summary>put this build in an archive directory
/// Shared: true if this build is archived, command line: -archive</summary>
        public virtual ProjectParamsConfig Archive(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-archive",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (ProjectParamsConfig) this;
        }

        
/// <summary>Directory to archive the builds to, i.e. -archivedirectory=C:\Archive</summary>
        public virtual ProjectParamsConfig Archivedirectory(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-archivedirectory",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (ProjectParamsConfig) this;
        }

        
/// <summary>Archive extra metadata files in addition to the build (e.g. build.properties)
/// Whether the project should use non monolithic staging</summary>
        public virtual ProjectParamsConfig Archivemetadata(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-archivemetadata",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (ProjectParamsConfig) this;
        }

        
/// <summary>When archiving for Mac, set this to true to package it in a .app bundle instead of normal loose files</summary>
        public virtual ProjectParamsConfig Createappbundle(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-createappbundle",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (ProjectParamsConfig) this;
        }

        
/// <summary>True if build step should be executed
/// Build: True if build step should be executed, command: -build</summary>
        public virtual ProjectParamsConfig Build(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-build",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (ProjectParamsConfig) this;
        }

        
/// <summary>True if XGE should NOT be used for building
/// Build: True if XGE should NOT be used for building.
/// Toggle to disable the distributed build process</summary>
        public virtual ProjectParamsConfig Noxge(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-noxge",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (ProjectParamsConfig) this;
        }

        
/// <summary>while cooking clean up packages as we are done with them rather then cleaning everything up when we run out of space
/// Cook: While cooking clean up packages as we go along rather then cleaning everything (and potentially having to reload some of it) when we run out of space</summary>
        public virtual ProjectParamsConfig CookPartialgc(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-CookPartialgc",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (ProjectParamsConfig) this;
        }

        
/// <summary>Did we cook in the editor instead of in UAT
/// Stage: Did we cook in the editor instead of from UAT (cook in editor uses a different staging directory)</summary>
        public virtual ProjectParamsConfig CookInEditor(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-CookInEditor",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (ProjectParamsConfig) this;
        }

        
/// <summary>Uses the iterative cooking, command line: -iterativecooking or -iterate
/// Uses the iterative cooking, command line: -iterativedeploy or -iterate
/// Cook: Uses the iterative cooking, command line: -iterativecooking or -iterate</summary>
        public virtual ProjectParamsConfig Iterativecooking(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-iterativecooking",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (ProjectParamsConfig) this;
        }

        
/// <summary>Cook only maps this only affects usage of -cookall the flag
/// Cook: Only cook maps (and referenced content) instead of cooking everything only affects -cookall flag</summary>
        public virtual ProjectParamsConfig CookMapsOnly(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-CookMapsOnly",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (ProjectParamsConfig) this;
        }

        
/// <summary>Cook all the things in the content directory for this project
/// Cook: Only cook maps (and referenced content) instead of cooking everything only affects cookall flag</summary>
        public virtual ProjectParamsConfig CookAll(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-CookAll",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (ProjectParamsConfig) this;
        }

        
/// <summary>Skips content under /Engine/Editor when cooking
/// Cook: Skip cooking editor content</summary>
        public virtual ProjectParamsConfig SkipCookingEditorContent(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-SkipCookingEditorContent",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (ProjectParamsConfig) this;
        }

        
/// <summary>Uses fast cook path if supported by target</summary>
        public virtual ProjectParamsConfig FastCook(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-FastCook",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (ProjectParamsConfig) this;
        }

        
/// <summary>Ignores cook errors and continues with packaging etc
/// Cook: Ignores cook errors and continues with packaging etc.</summary>
        public virtual ProjectParamsConfig IgnoreCookErrors(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-IgnoreCookErrors",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (ProjectParamsConfig) this;
        }

        
/// <summary>do not copy debug files to the stage
/// Stage: Commandline: -nodebuginfo</summary>
        public virtual ProjectParamsConfig Nodebuginfo(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-nodebuginfo",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (ProjectParamsConfig) this;
        }

        
/// <summary>output debug info to a separate directory
/// Stage: Commandline: -separatedebuginfo</summary>
        public virtual ProjectParamsConfig Separatedebuginfo(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-separatedebuginfo",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (ProjectParamsConfig) this;
        }

        
/// <summary>generates a *.map file
/// Stage: Commandline: -mapfile</summary>
        public virtual ProjectParamsConfig MapFile(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-MapFile",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (ProjectParamsConfig) this;
        }

        
/// <summary>skip cleaning the stage directory
/// true if the staging directory is to be cleaned: -cleanstage (also true if -clean is specified)</summary>
        public virtual ProjectParamsConfig Nocleanstage(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-nocleanstage",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (ProjectParamsConfig) this;
        }

        
/// <summary>command line to put into the stage in UE4CommandLine.txt
/// command line to put into the stage in UECommandLine.txt</summary>
        public virtual ProjectParamsConfig Cmdline(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-cmdline",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (ProjectParamsConfig) this;
        }

        
/// <summary>string to use as the bundle name when deploying to mobile device
/// Stage: If non-empty, the contents will be used for the bundle name</summary>
        public virtual ProjectParamsConfig Bundlename(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-bundlename",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (ProjectParamsConfig) this;
        }

        
/// <summary>run the game after it is built (including server, if -server)
/// Run: True if the Run step should be executed, command: -run</summary>
        public virtual ProjectParamsConfig Run(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-run",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (ProjectParamsConfig) this;
        }

        
/// <summary>run the client with cooked data provided by cook on the fly server
/// Run: The client runs with cooked data provided by cook on the fly server, command line: -cookonthefly</summary>
        public virtual ProjectParamsConfig Cookonthefly(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-cookonthefly",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (ProjectParamsConfig) this;
        }

        
/// <summary>run the client in streaming cook on the fly mode (don't cache files locally instead force reget from server each file load)
/// Run: The client should run in streaming mode when connecting to cook on the fly server</summary>
        public virtual ProjectParamsConfig Cookontheflystreaming(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Cookontheflystreaming",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (ProjectParamsConfig) this;
        }

        
/// <summary>run the client with cooked data provided by UnrealFileServer
/// Run: The client runs with cooked data provided by UnrealFileServer, command line: -fileserver</summary>
        public virtual ProjectParamsConfig Fileserver(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-fileserver",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (ProjectParamsConfig) this;
        }

        
/// <summary>build, cook and run both a client and a server (also -server)
/// Run: The client connects to dedicated server to get data, command line: -dedicatedserver</summary>
        public virtual ProjectParamsConfig Dedicatedserver(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-dedicatedserver",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (ProjectParamsConfig) this;
        }

        
/// <summary>build, cook and run a client and a server, uses client target configuration
/// Run: Uses a client target configuration, also implies -dedicatedserver, command line: -client</summary>
        public virtual ProjectParamsConfig Client(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-client",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (ProjectParamsConfig) this;
        }

        
/// <summary>do not run the client, just run the server
/// Run: Whether the client should start or not, command line (to disable): -noclient</summary>
        public virtual ProjectParamsConfig Noclient(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-noclient",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (ProjectParamsConfig) this;
        }

        
/// <summary>create a log window for the client
/// Run: Client should create its own log window, command line: -logwindow</summary>
        public virtual ProjectParamsConfig Logwindow(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-logwindow",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (ProjectParamsConfig) this;
        }

        
/// <summary>map to run the game with</summary>
        public virtual ProjectParamsConfig Map(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-map",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (ProjectParamsConfig) this;
        }

        
/// <summary>Additional server map params, i.e ?param=value
/// Run: Additional server map params.</summary>
        public virtual ProjectParamsConfig AdditionalServerMapParams(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-AdditionalServerMapParams",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (ProjectParamsConfig) this;
        }

        
/// <summary>Devices to run the game on
/// Device names without the platform prefix to run the game on</summary>
        public virtual ProjectParamsConfig Device(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-device",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (ProjectParamsConfig) this;
        }

        
/// <summary>Device to run the server on
/// Run: the target device to run the server on</summary>
        public virtual ProjectParamsConfig Serverdevice(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-serverdevice",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (ProjectParamsConfig) this;
        }

        
/// <summary>Skip starting the server
/// Run: The indicated server has already been started</summary>
        public virtual ProjectParamsConfig Skipserver(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-skipserver",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (ProjectParamsConfig) this;
        }

        
/// <summary>Start extra clients, n should be 2 or more
/// Run: The indicated server has already been started</summary>
        public virtual ProjectParamsConfig Numclients(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-numclients",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (ProjectParamsConfig) this;
        }

        
/// <summary>Additional command line arguments for the program</summary>
        public virtual ProjectParamsConfig Addcmdline(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-addcmdline",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (ProjectParamsConfig) this;
        }

        
/// <summary>Additional command line arguments for the program</summary>
        public virtual ProjectParamsConfig Servercmdline(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-servercmdline",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (ProjectParamsConfig) this;
        }

        
/// <summary>Override command line arguments to pass to the client</summary>
        public virtual ProjectParamsConfig Clientcmdline(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-clientcmdline",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (ProjectParamsConfig) this;
        }

        
/// <summary>add -nullrhi to the client commandlines
/// Run:adds -nullrhi to the client commandline</summary>
        public virtual ProjectParamsConfig Nullrhi(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-nullrhi",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (ProjectParamsConfig) this;
        }

        
/// <summary>adds ?fake to the server URL
/// Run:adds ?fake to the server URL</summary>
        public virtual ProjectParamsConfig Fakeclient(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-fakeclient",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (ProjectParamsConfig) this;
        }

        
/// <summary>rather than running a client, run the editor instead
/// Run:adds ?fake to the server URL</summary>
        public virtual ProjectParamsConfig Editortest(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-editortest",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (ProjectParamsConfig) this;
        }

        
/// <summary>when running -editortest or a client, run all automation tests, not compatible with -server
/// when running -editortest or a client, run a specific automation tests, not compatible with -server
/// Run:when running -editortest or a client, run all automation tests, not compatible with -server</summary>
        public virtual ProjectParamsConfig RunAutomationTests(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-RunAutomationTests",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (ProjectParamsConfig) this;
        }

        
/// <summary>when running -editortest or a client, adds commands like debug crash, debug rendercrash, etc based on index</summary>
        public virtual ProjectParamsConfig Crash(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Crash",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (ProjectParamsConfig) this;
        }

        
/// <summary>Linux username for unattended key genereation</summary>
        public virtual ProjectParamsConfig Deviceuser(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-deviceuser",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (ProjectParamsConfig) this;
        }

        
/// <summary>Linux password</summary>
        public virtual ProjectParamsConfig Devicepass(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-devicepass",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (ProjectParamsConfig) this;
        }

        
/// <summary>package the project for the target platform
/// Determine whether data is packaged. This can be an iteration optimization for platforms that require packages for deployment</summary>
        public virtual ProjectParamsConfig Package(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-package",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (ProjectParamsConfig) this;
        }

        
/// <summary>Skips packaging the project for the target platform</summary>
        public virtual ProjectParamsConfig Skippackage(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-skippackage",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (ProjectParamsConfig) this;
        }

        
/// <summary>package for distribution the project</summary>
        public virtual ProjectParamsConfig Distribution(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-distribution",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (ProjectParamsConfig) this;
        }

        
/// <summary>stage prerequisites along with the project</summary>
        public virtual ProjectParamsConfig Prereqs(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-prereqs",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (ProjectParamsConfig) this;
        }

        
/// <summary>location of prerequisites for applocal deployment</summary>
        public virtual ProjectParamsConfig Applocaldir(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-applocaldir",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (ProjectParamsConfig) this;
        }

        
/// <summary>this is a prebuilt cooked and packaged build</summary>
        public virtual ProjectParamsConfig Prebuilt(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Prebuilt",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (ProjectParamsConfig) this;
        }

        
/// <summary>timeout to wait after we lunch the game</summary>
        public virtual ProjectParamsConfig RunTimeoutSeconds(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-RunTimeoutSeconds",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (ProjectParamsConfig) this;
        }

        
/// <summary>Determine a specific Minimum OS</summary>
        public virtual ProjectParamsConfig SpecifiedArchitecture(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-SpecifiedArchitecture",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (ProjectParamsConfig) this;
        }

        
/// <summary>extra options to pass to ubt</summary>
        public virtual ProjectParamsConfig UbtArgs(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-UbtArgs",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (ProjectParamsConfig) this;
        }

        
/// <summary>extra options to pass to the platform's packager</summary>
        public virtual ProjectParamsConfig AdditionalPackageOptions(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-AdditionalPackageOptions",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (ProjectParamsConfig) this;
        }

        
/// <summary>deploy the project for the target platform
/// Location to deploy to on the target platform</summary>
        public virtual ProjectParamsConfig Deploy(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-deploy",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (ProjectParamsConfig) this;
        }

        
/// <summary>download file from target after successful run</summary>
        public virtual ProjectParamsConfig Getfile(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-getfile",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (ProjectParamsConfig) this;
        }

        
/// <summary>List of maps that need light maps rebuilding</summary>
        public virtual ProjectParamsConfig MapsToRebuildLightMaps(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-MapsToRebuildLightMaps",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (ProjectParamsConfig) this;
        }

        
/// <summary>List of maps that need HLOD rebuilding</summary>
        public virtual ProjectParamsConfig MapsToRebuildHLODMaps(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-MapsToRebuildHLODMaps",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (ProjectParamsConfig) this;
        }

        
/// <summary>Whether Light Map errors should be treated as critical</summary>
        public virtual ProjectParamsConfig IgnoreLightMapErrors(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-IgnoreLightMapErrors",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (ProjectParamsConfig) this;
        }

        
    
        public virtual ProjectParamsConfig Cookflavor(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-cookflavor",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (ProjectParamsConfig) this;
        }

        
    
        public virtual ProjectParamsConfig Ddc(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-ddc",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (ProjectParamsConfig) this;
        }

        
    
        public virtual ProjectParamsConfig I18npreset(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-i18npreset",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (ProjectParamsConfig) this;
        }

        
    
        public virtual ProjectParamsConfig CookCultures(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-CookCultures",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (ProjectParamsConfig) this;
        }

        
    
        public virtual ProjectParamsConfig Skipbuild(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-skipbuild",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (ProjectParamsConfig) this;
        }

        
/// <summary>
/// SkipBuildClient if true then don't build the client exe
/// </summary>
        public virtual ProjectParamsConfig SkipBuildClient(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-skipbuildclient",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (ProjectParamsConfig) this;
        }

        
/// <summary>
/// SkipBuildEditor if true then don't build the editor exe
/// </summary>
        public virtual ProjectParamsConfig SkipBuildEditor(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-skipbuildeditor",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (ProjectParamsConfig) this;
        }

        
    
        public virtual ProjectParamsConfig Createreleaseversionroot(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-createreleaseversionroot",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (ProjectParamsConfig) this;
        }

        
    
        public virtual ProjectParamsConfig Basedonreleaseversionroot(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-basedonreleaseversionroot",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (ProjectParamsConfig) this;
        }

        
/// <summary>
/// The version of the originally released build. This is required by some platforms when generating patches.
/// </summary>
        public virtual ProjectParamsConfig OriginalReleaseVersion(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-originalreleaseversion",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (ProjectParamsConfig) this;
        }

        
/// <summary>
/// Cook: Create a cooked release version.  Also, the version. e.g. 1.0
/// </summary>
        public virtual ProjectParamsConfig CreateReleaseVersion(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-createreleaseversion",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (ProjectParamsConfig) this;
        }

        
/// <summary>
/// Cook: Base this cook of a already released version of the cooked data
/// </summary>
        public virtual ProjectParamsConfig BasedOnReleaseVersion(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-basedonreleaseversion",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (ProjectParamsConfig) this;
        }

        
/// <summary>
/// Are we generating a patch, generate a patch from a previously released version of the game (use CreateReleaseVersion to create a release).
/// this requires BasedOnReleaseVersion
/// see also CreateReleaseVersion, BasedOnReleaseVersion
/// </summary>
        public virtual ProjectParamsConfig GeneratePatch(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-GeneratePatch",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (ProjectParamsConfig) this;
        }

        
/// <summary></summary>
        public virtual ProjectParamsConfig AddPatchLevel(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-AddPatchLevel",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (ProjectParamsConfig) this;
        }

        
/// <summary>
/// Are we staging the unmodified pak files from the base release</summary>
        public virtual ProjectParamsConfig StageBaseReleasePaks(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-StageBaseReleasePaks",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (ProjectParamsConfig) this;
        }

        
/// <summary>
/// Required when building remaster package
/// </summary>
        public virtual ProjectParamsConfig DiscVersion(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-DiscVersion",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (ProjectParamsConfig) this;
        }

        
/// <summary>
/// Cook: Additional cooker options to include on the cooker commandline
/// </summary>
        public virtual ProjectParamsConfig AdditionalCookerOptions(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-AdditionalCookerOptions",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (ProjectParamsConfig) this;
        }

        
    
        public virtual ProjectParamsConfig DLCName(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-DLCName",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (ProjectParamsConfig) this;
        }

        
/// <summary>
/// After cook completes diff the cooked content against another cooked content directory.
/// report all errors to the log
/// </summary>
        public virtual ProjectParamsConfig DiffCookedContentPath(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-DiffCookedContentPath",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (ProjectParamsConfig) this;
        }

        
/// <summary>
/// Enable cooking of engine content when cooking dlc
/// not included in original release but is referenced by current cook
/// </summary>
        public virtual ProjectParamsConfig DLCIncludeEngineContent(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-DLCIncludeEngineContent",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (ProjectParamsConfig) this;
        }

        
/// <summary>
/// Enable packaging up the uplugin file inside the dlc pak.  This is sometimes desired if you want the plugin to be standalone
/// </summary>
        public virtual ProjectParamsConfig DLCPakPluginFile(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-DLCPakPluginFile",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (ProjectParamsConfig) this;
        }

        
/// <summary>
/// DLC will remap it's files to the game directory and act like a patch.  This is useful if you want to override content in the main game along side your main game.
/// For example having different main game content in different DLCs
/// </summary>
        public virtual ProjectParamsConfig DLCActLikePatch(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-DLCActLikePatch",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (ProjectParamsConfig) this;
        }

        
/// <summary>
/// Shared: the game will use only signed content.
/// </summary>
        public virtual ProjectParamsConfig SignedPak(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-signedpak",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (ProjectParamsConfig) this;
        }

        
/// <summary>
/// Stage: True if we should disable trying to re-use pak files from another staged build when we've specified a different cook source platform
/// </summary>
        public virtual ProjectParamsConfig IgnorePaksFromDifferentCookSource(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-IgnorePaksFromDifferentCookSource",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (ProjectParamsConfig) this;
        }

        
/// <summary>
/// Cook: Do not include a version number in the cooked content
/// </summary>
        public virtual ProjectParamsConfig UnversionedCookedContent(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-UnversionedCookedContent",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (ProjectParamsConfig) this;
        }

        
/// <summary>
/// Cook: number of additional cookers to spawn while cooking
/// </summary>
        public virtual ProjectParamsConfig NumCookersToSpawn(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-NumCookersToSpawn",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4,
                        AllowMultiple: true
                    )
                ));
            }
            return (ProjectParamsConfig) this;
        }

        
/// <summary>
/// Compress packages during cook.
/// </summary>
        public virtual ProjectParamsConfig Compressed(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-compressed",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (ProjectParamsConfig) this;
        }

        
/// <summary>
/// Do not compress packages during cook, override game ProjectPackagingSettings to force it off
/// </summary>
        public virtual ProjectParamsConfig ForceUncompressed(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-ForceUncompressed",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (ProjectParamsConfig) this;
        }

        
/// <summary>
/// Additional parameters when generating the PAK file
/// </summary>
        public virtual ProjectParamsConfig AdditionalPakOptions(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-AdditionalPakOptions",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (ProjectParamsConfig) this;
        }

        
/// <summary>
/// Additional parameters when generating iostore container files
/// </summary>
        public virtual ProjectParamsConfig AdditionalIoStoreOptions(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-AdditionalIoStoreOptions",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (ProjectParamsConfig) this;
        }

        
/// <summary>
/// Cook: Iterate from a build on the network
/// </summary>
        public virtual ProjectParamsConfig Iteratesharedcookedbuild(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-iteratesharedcookedbuild",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (ProjectParamsConfig) this;
        }

        
/// <summary>
/// Build: Don't build the game instead use the prebuild exe (requires iterate shared cooked build
/// </summary>
        public virtual ProjectParamsConfig IterateSharedBuildUsePrecompiledExe(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-IterateSharedBuildUsePrecompiledExe",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (ProjectParamsConfig) this;
        }

        
/// <summary>
/// Cook: Output directory for cooked data
/// </summary>
        public virtual ProjectParamsConfig CookOutputDir(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-CookOutputDir",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (ProjectParamsConfig) this;
        }

        
    
        public virtual ProjectParamsConfig Target(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-target",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (ProjectParamsConfig) this;
        }

        
/// <summary>Stage: Specifies a list of extra targets that should be staged along with a client
/// </summary>
        public virtual ProjectParamsConfig ExtraTargetsToStageWithClient(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-ExtraTargetsToStageWithClient",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (ProjectParamsConfig) this;
        }

        
/// <summary>
/// By default we don't code sign unless it is required or requested
/// </summary>
        public virtual ProjectParamsConfig CodeSign(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-CodeSign",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (ProjectParamsConfig) this;
        }

        
/// <summary>
/// If true, non-shipping binaries will be considered DebugUFS files and will appear on the debugfiles manifest
/// </summary>
        public virtual ProjectParamsConfig TreatNonShippingBinariesAsDebugFiles(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-TreatNonShippingBinariesAsDebugFiles",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (ProjectParamsConfig) this;
        }

        
/// <summary>
/// If true, use chunk manifest files generated for extra flavor
/// </summary>
        public virtual ProjectParamsConfig UseExtraFlavor(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-UseExtraFlavor",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (ProjectParamsConfig) this;
        }

        
/// <summary>
/// Shared: Directory to use for built chunk install data, command line: -chunkinstalldirectory=
/// </summary>
        public virtual ProjectParamsConfig ChunkInstallDirectory(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-chunkinstalldirectory",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (ProjectParamsConfig) this;
        }

        
    
        public virtual ProjectParamsConfig Chunkinstallversion(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-chunkinstallversion",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (ProjectParamsConfig) this;
        }

        
    
        public virtual ProjectParamsConfig Chunkinstallrelease(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-chunkinstallrelease",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (ProjectParamsConfig) this;
        }

        
    
        public virtual ProjectParamsConfig AppLocalDirectory(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-applocaldirectory",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (ProjectParamsConfig) this;
        }

        
/// <summary>
/// On Windows, adds an executable to the root of the staging directory which checks for prerequisites being
/// installed and launches the game with a path to the .uproject file.
/// </summary>
        public virtual ProjectParamsConfig NoBootstrapExe(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-nobootstrapexe",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (ProjectParamsConfig) this;
        }

        
    
        public virtual ProjectParamsConfig ForcePackageData(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-forcepackagedata",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (ProjectParamsConfig) this;
        }

        
/// <summary>
/// Cook: Uses the iterative deploy, command line: -iterativedeploy or -iterate
/// </summary>
        public virtual ProjectParamsConfig IterativeDeploy(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-iterativedeploy",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (ProjectParamsConfig) this;
        }

        
/// <summary>
/// Provision to use
/// </summary>
        public virtual ProjectParamsConfig Provision(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-provision",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (ProjectParamsConfig) this;
        }

        
/// <summary>
/// Certificate to use
/// </summary>
        public virtual ProjectParamsConfig Certificate(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-certificate",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (ProjectParamsConfig) this;
        }

        
/// <summary>
/// Team ID to use
/// </summary>
        public virtual ProjectParamsConfig Team(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-team",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (ProjectParamsConfig) this;
        }

        
/// <summary>
/// true if provisioning is automatically managed
/// </summary>
        public virtual ProjectParamsConfig AutomaticSigning(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-AutomaticSigning",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (ProjectParamsConfig) this;
        }

        
/// <summary>
/// Run:when running -editortest or a client, run all automation tests, not compatible with -server
/// </summary>
        public virtual ProjectParamsConfig RunAutomationTest(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-RunAutomationTest",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (ProjectParamsConfig) this;
        }

        
/// <summary>Name of the Unreal Editor executable, i.e. -unrealexe=UnrealEditor.exe</summary>
        public virtual ProjectParamsConfig UnrealExe(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-ue4exe",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (ProjectParamsConfig) this;
        }

        
    
        public virtual ProjectParamsConfig Clientconfig(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-clientconfig",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (ProjectParamsConfig) this;
        }

        
    
        public virtual ProjectParamsConfig Config(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-config",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (ProjectParamsConfig) this;
        }

        
    
        public virtual ProjectParamsConfig Configuration(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-configuration",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (ProjectParamsConfig) this;
        }

        
    
        public virtual ProjectParamsConfig Port(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-port",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (ProjectParamsConfig) this;
        }

        
/// <summary>
/// Cook: List of maps to cook.
/// </summary>
        public virtual ProjectParamsConfig MapsToCook(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-MapsToCook",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (ProjectParamsConfig) this;
        }

        
/// <summary>
/// Cook: List of map inisections to cook (see allmaps)
/// </summary>
        public virtual ProjectParamsConfig MapIniSectionsToCook(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-MapIniSectionsToCook",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (ProjectParamsConfig) this;
        }

        
/// <summary>
/// TitleID to package
/// </summary>
        public virtual ProjectParamsConfig TitleID(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-TitleID",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (ProjectParamsConfig) this;
        }

        
    
        public virtual ProjectParamsConfig Serverconfig(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-serverconfig",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (ProjectParamsConfig) this;
        }

        
/// <summary>
/// Run: Adds commands like debug crash, debug rendercrash, etc based on index
/// </summary>
        public virtual ProjectParamsConfig CrashIndex(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-CrashIndex",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (ProjectParamsConfig) this;
        }

        
/// <summary>generate I/O store container file(s)
/// Shared: True if the cooker should write directly to container file(s)</summary>
        public virtual ProjectParamsConfig Cook4iostore(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-cook4iostore",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (ProjectParamsConfig) this;
        }

        
/// <summary>save cooked output data to the Zen storage server
/// Shared: True if the cooker should store the cooked output to the Zen storage server</summary>
        public virtual ProjectParamsConfig Zenstore(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-zenstore",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (ProjectParamsConfig) this;
        }

        
/// <summary>URL to a running Zen server
/// Shared: URL to a running Zen server</summary>
        public virtual ProjectParamsConfig Nozenautolaunch(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-nozenautolaunch",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (ProjectParamsConfig) this;
        }

        
/// <summary>Should virtualized assets be rehydrated?
/// Shared: true if we want to rehydrate virtualized assets when staging.</summary>
        public virtual ProjectParamsConfig Rehydrateassets(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-rehydrateassets",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (ProjectParamsConfig) this;
        }

        
/// <summary>Directory to copy the optional files to, i.e. -optionalfilestagingdirectory=C:\StageOptional</summary>
        public virtual ProjectParamsConfig Optionalfilestagingdirectory(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-optionalfilestagingdirectory",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (ProjectParamsConfig) this;
        }

        
/// <summary>Directory to read the optional files from, i.e. -optionalfileinputdirectory=C:\StageOptional</summary>
        public virtual ProjectParamsConfig Optionalfileinputdirectory(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-optionalfileinputdirectory",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (ProjectParamsConfig) this;
        }

        
/// <summary>Subdirectory under staging to copy CookerSupportFiles (as set in Build.cs files). -CookerSupportFilesSubdirectory=SDK</summary>
        public virtual ProjectParamsConfig CookerSupportFilesSubdirectory(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-CookerSupportFilesSubdirectory",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (ProjectParamsConfig) this;
        }

        
/// <summary>Skips preparing data that would be used during packaging, in earlier stages. Different from skippackage which is used to optimize later stages like archive, which still was packaged at some point</summary>
        public virtual ProjectParamsConfig Neverpackage(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-neverpackage",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (ProjectParamsConfig) this;
        }

        
/// <summary>Path to file containing encryption key to use in packaging</summary>
        public virtual ProjectParamsConfig PackageEncryptionKeyFile(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-PackageEncryptionKeyFile",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (ProjectParamsConfig) this;
        }

        
/// <summary>The list of trace channels to enable</summary>
        public virtual ProjectParamsConfig Trace(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-trace",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (ProjectParamsConfig) this;
        }

        
/// <summary>The host address of the trace recorder</summary>
        public virtual ProjectParamsConfig Tracehost(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-tracehost",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (ProjectParamsConfig) this;
        }

        
/// <summary>The file where the trace will be recorded</summary>
        public virtual ProjectParamsConfig Tracefile(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-tracefile",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (ProjectParamsConfig) this;
        }

        
/// <summary>A label to pass to analytics</summary>
        public virtual ProjectParamsConfig Sessionlabel(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-sessionlabel",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (ProjectParamsConfig) this;
        }

        
/// <summary>
/// Stage: Path to the global.utoc file for a directory of iostore containers to use as a source of compressed
/// chunks when writing new containers. See -ReferenceContainerGlobalFileName in IoStoreUtilities.cpp.
/// </summary>
        public virtual ProjectParamsConfig ReferenceContainerGlobalFileName(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-ReferenceContainerGlobalFileName",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (ProjectParamsConfig) this;
        }

        
/// <summary>
/// Stage: Path to the crypto.json file to use for decrypting ReferenceContainerFlobalFileName, if needed.
/// </summary>
        public virtual ProjectParamsConfig ReferenceContainerCryptoKeys(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-ReferenceContainerCryptoKeys",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (ProjectParamsConfig) this;
        }

        
/// <summary>
/// Sometimes a DLC may get cooked to a subdirectory of where is expected, so this can tell the staging what the subdirectory of the cooked out
/// to find the DLC files (for instance Metadata)
/// </summary>
        public virtual ProjectParamsConfig DLCOverrideCookedSubDir(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-DLCOverrideCookedSubDir",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (ProjectParamsConfig) this;
        }

        
/// <summary>
/// Controls where under the staged directory to output to (in case the plugin subdirectory is not desired under the StagingDirectory location)
/// </summary>
        public virtual ProjectParamsConfig DLCOverrideStagedSubDir(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-DLCOverrideStagedSubDir",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (ProjectParamsConfig) this;
        }

        
    
        public virtual ProjectParamsConfig Editoroptional(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-editoroptional",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (ProjectParamsConfig) this;
        }
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    }

    protected readonly ProjectParamsConfig ProjectParamsStorage = new();
        
    
    public  class UnrealBuildConfig : ToolConfig
    {
        public override string Name => "UnrealBuild";
        public override string CliName => "";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE4 | UnrealCompatibility.UE5;
    
/// <summary>Toggle to combined the result into one executable</summary>
        public virtual UnrealBuildConfig ForceMonolithic(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-ForceMonolithic",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (UnrealBuildConfig) this;
        }

        
/// <summary>Forces debug info even in development builds</summary>
        public virtual UnrealBuildConfig ForceDebugInfo(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-ForceDebugInfo",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (UnrealBuildConfig) this;
        }

        
/// <summary>Toggle to disable the distributed build process</summary>
        public virtual UnrealBuildConfig NoXGE(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-NoXGE",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (UnrealBuildConfig) this;
        }

        
/// <summary>Toggle to disable the unity build system</summary>
        public virtual UnrealBuildConfig ForceNonUnity(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-ForceNonUnity",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (UnrealBuildConfig) this;
        }

        
/// <summary>Toggle to force enable the unity build system</summary>
        public virtual UnrealBuildConfig ForceUnity(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-ForceUnity",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (UnrealBuildConfig) this;
        }

        
/// <summary>If set, this build is being compiled by a licensee</summary>
        public virtual UnrealBuildConfig Licensee(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Licensee",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (UnrealBuildConfig) this;
        }

        
    
        public virtual UnrealBuildConfig Promoted(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Promoted",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (UnrealBuildConfig) this;
        }

        
    
        public virtual UnrealBuildConfig Branch(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Branch",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (UnrealBuildConfig) this;
        }

        
    
        public virtual UnrealBuildConfig StopOnErrors(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-StopOnErrors",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (UnrealBuildConfig) this;
        }

        
    
        public virtual UnrealBuildConfig Clean(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Clean",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (UnrealBuildConfig) this;
        }
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    }

    protected readonly UnrealBuildConfig UnrealBuildStorage = new();
        
/// <summary>Builds the specified targets and configurations for the specified project.
/// Example BuildTarget -project=QAGame -target=Editor+Game -platform=PS4+XboxOne -configuration=Development.
/// Note: Editor will only ever build for the current platform in a Development config and required tools will be included
/// Builds the specified targets and configurations for the specified project.
/// Example BuildTarget -project=QAGame -target=Editor+Game -platform=Win64+Android -configuration=Development.
/// Note: Editor will only ever build for the current platform in a Development config and required tools will be included</summary>
    public  class BuildTargetConfig : ToolConfig
    {
        public override string Name => "BuildTarget";
        public override string CliName => "BuildTarget";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE4 | UnrealCompatibility.UE5;
    
/// <summary>Project to build. Will search current path and paths in ueprojectdirs. If omitted will build vanilla UE4Editor
/// Project to build. Will search current path and paths in ueprojectdirs. If omitted will build vanilla UnrealEditor</summary>
        public virtual BuildTargetConfig Project(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-project",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildTargetConfig) this;
        }

        
/// <summary>Platforms to build, join multiple platforms using +
/// Platform to build</summary>
        public virtual BuildTargetConfig Platform(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-platform",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildTargetConfig) this;
        }

        
/// <summary>Configurations to build, join multiple configurations using +</summary>
        public virtual BuildTargetConfig Configuration(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-configuration",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildTargetConfig) this;
        }

        
/// <summary>Targets to build, join multiple targets using +</summary>
        public virtual BuildTargetConfig Target(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-target",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildTargetConfig) this;
        }

        
/// <summary>Don't build any tools (UnrealPak, Lightmass, ShaderCompiler, CrashReporter</summary>
        public virtual BuildTargetConfig Notools(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-notools",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildTargetConfig) this;
        }

        
/// <summary>Do a clean build
/// Whether to clean this target. If not specified, the target will be cleaned if -Clean is on the command line.</summary>
        public virtual BuildTargetConfig Clean(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-clean",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildTargetConfig) this;
        }

        
/// <summary>Toggle to disable the distributed build process</summary>
        public virtual BuildTargetConfig NoXGE(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-NoXGE",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildTargetConfig) this;
        }

        
/// <summary>Toggle to disable the unity build system</summary>
        public virtual BuildTargetConfig DisableUnity(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-DisableUnity",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildTargetConfig) this;
        }

        
/// <summary>
/// Extra UBT args
/// </summary>
        public virtual BuildTargetConfig UBTArgs(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-ubtargs",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildTargetConfig) this;
        }

        
    
        public virtual BuildTargetConfig Preview(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-preview",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildTargetConfig) this;
        }
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    }

    protected readonly BuildTargetConfig BuildTargetStorage = new();
        
/// <summary>Tool for creating extensible build processes in UE4 which can be run locally or in parallel across a build farm.
/// Tool for creating extensible build processes in UE which can be run locally or in parallel across a build farm.</summary>
    public  class BuildGraphConfig : ToolConfig
    {
        public override string Name => "BuildGraph";
        public override string CliName => "BuildGraph";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE4 | UnrealCompatibility.UE5;
    
/// <summary>Path to the script describing the graph</summary>
        public virtual BuildGraphConfig Script(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Script",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildGraphConfig) this;
        }

        
/// <summary>Name of the node or output tag to be built</summary>
        public virtual BuildGraphConfig Target(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Target",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildGraphConfig) this;
        }

        
/// <summary>Generates a schema to the default location
/// Generate a schema describing valid script documents, including all the known tasks</summary>
        public virtual BuildGraphConfig Schema(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Schema",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildGraphConfig) this;
        }

        
/// <summary>Imports a schema from an existing schema file</summary>
        public virtual BuildGraphConfig ImportSchema(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-ImportSchema",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildGraphConfig) this;
        }

        
/// <summary>Sets a named property to the given value</summary>
        public virtual BuildGraphConfig Set(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Set",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: ':',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildGraphConfig) this;
        }

        
/// <summary>Cleans all cached state of completed build nodes before running</summary>
        public virtual BuildGraphConfig Clean(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Clean",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildGraphConfig) this;
        }

        
/// <summary>Cleans just the given nodes before running</summary>
        public virtual BuildGraphConfig CleanNode(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-CleanNode",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildGraphConfig) this;
        }

        
/// <summary>Resumes a local build from the last node that completed successfully</summary>
        public virtual BuildGraphConfig Resume(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Resume",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildGraphConfig) this;
        }

        
/// <summary>Shows the contents of the preprocessed graph, but does not execute it</summary>
        public virtual BuildGraphConfig ListOnly(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-ListOnly",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildGraphConfig) this;
        }

        
/// <summary>When running with -ListOnly, causes diagnostic messages entered when parsing the graph to be shown</summary>
        public virtual BuildGraphConfig ShowDiagnostics(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-ShowDiagnostics",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildGraphConfig) this;
        }

        
/// <summary>Show node dependencies in the graph output</summary>
        public virtual BuildGraphConfig ShowDeps(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-ShowDeps",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildGraphConfig) this;
        }

        
/// <summary>Show notifications that will be sent for each node in the output</summary>
        public virtual BuildGraphConfig ShowNotifications(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-ShowNotifications",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildGraphConfig) this;
        }

        
/// <summary>Executes only nodes behind the given trigger</summary>
        public virtual BuildGraphConfig Trigger(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Trigger",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildGraphConfig) this;
        }

        
/// <summary>Skips the given triggers, including all the nodes behind them in the graph</summary>
        public virtual BuildGraphConfig SkipTrigger(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-SkipTrigger",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildGraphConfig) this;
        }

        
/// <summary>Skips all triggers</summary>
        public virtual BuildGraphConfig SkipTriggers(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-SkipTriggers",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildGraphConfig) this;
        }

        
/// <summary>Specifies the signature identifying the current job, to be written to tokens for nodes that require them. Tokens are ignored if this parameter is not specified.</summary>
        public virtual BuildGraphConfig TokenSignature(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-TokenSignature",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildGraphConfig) this;
        }

        
/// <summary>Excludes targets which we can't acquire tokens for, rather than failing</summary>
        public virtual BuildGraphConfig SkipTargetsWithoutTokens(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-SkipTargetsWithoutTokens",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildGraphConfig) this;
        }

        
/// <summary>Writes the preprocessed graph to the given file</summary>
        public virtual BuildGraphConfig Preprocess(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Preprocess",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildGraphConfig) this;
        }

        
/// <summary>Exports a JSON file containing the preprocessed build graph, for use as part of a build system</summary>
        public virtual BuildGraphConfig Export(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Export",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildGraphConfig) this;
        }

        
/// <summary>Exports a JSON file containing the full build graph for use by Horde.</summary>
        public virtual BuildGraphConfig HordeExport(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-HordeExport",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildGraphConfig) this;
        }

        
/// <summary>Only include built-in tasks in the schema, excluding any other UAT modules</summary>
        public virtual BuildGraphConfig PublicTasksOnly(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-PublicTasksOnly",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildGraphConfig) this;
        }

        
/// <summary>Sets the directory to use to transfer build products between agents in a build farm</summary>
        public virtual BuildGraphConfig SharedStorageDir(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-SharedStorageDir",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildGraphConfig) this;
        }

        
/// <summary>Run only the given node. Intended for use on a build system after running with -Export.</summary>
        public virtual BuildGraphConfig SingleNode(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-SingleNode",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildGraphConfig) this;
        }

        
/// <summary>Allow writing to shared storage. If not set, but -SharedStorageDir is specified, build products will read but not written</summary>
        public virtual BuildGraphConfig WriteToSharedStorage(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-WriteToSharedStorage",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildGraphConfig) this;
        }

        
    
        public virtual BuildGraphConfig Documentation(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Documentation",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildGraphConfig) this;
        }

        
    
        public virtual BuildGraphConfig ReportName(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-ReportName",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildGraphConfig) this;
        }

        
    
        public virtual BuildGraphConfig Class(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Class",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildGraphConfig) this;
        }

        
    
        public virtual BuildGraphConfig SkipValidation(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-SkipValidation",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildGraphConfig) this;
        }

        
    
        public virtual BuildGraphConfig Branch(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Branch",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildGraphConfig) this;
        }
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    }

    protected readonly BuildGraphConfig BuildGraphStorage = new();
        
    
    public  class BuildConfig : ToolConfig
    {
        public override string Name => "Build";
        public override string CliName => "Build";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE4 | UnrealCompatibility.UE5;
    
/// <summary>Path to the script describing the graph</summary>
        public virtual BuildConfig Script(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Script",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildConfig) this;
        }

        
/// <summary>Name of the node or output tag to be built</summary>
        public virtual BuildConfig Target(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Target",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildConfig) this;
        }

        
/// <summary>Generates a schema to the default location
/// Generate a schema describing valid script documents, including all the known tasks</summary>
        public virtual BuildConfig Schema(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Schema",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildConfig) this;
        }

        
/// <summary>Imports a schema from an existing schema file</summary>
        public virtual BuildConfig ImportSchema(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-ImportSchema",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildConfig) this;
        }

        
/// <summary>Sets a named property to the given value</summary>
        public virtual BuildConfig Set(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Set",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: ':',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildConfig) this;
        }

        
/// <summary>Cleans all cached state of completed build nodes before running</summary>
        public virtual BuildConfig Clean(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Clean",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildConfig) this;
        }

        
/// <summary>Cleans just the given nodes before running</summary>
        public virtual BuildConfig CleanNode(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-CleanNode",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildConfig) this;
        }

        
/// <summary>Resumes a local build from the last node that completed successfully</summary>
        public virtual BuildConfig Resume(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Resume",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildConfig) this;
        }

        
/// <summary>Shows the contents of the preprocessed graph, but does not execute it</summary>
        public virtual BuildConfig ListOnly(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-ListOnly",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildConfig) this;
        }

        
/// <summary>When running with -ListOnly, causes diagnostic messages entered when parsing the graph to be shown</summary>
        public virtual BuildConfig ShowDiagnostics(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-ShowDiagnostics",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildConfig) this;
        }

        
/// <summary>Show node dependencies in the graph output</summary>
        public virtual BuildConfig ShowDeps(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-ShowDeps",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildConfig) this;
        }

        
/// <summary>Show notifications that will be sent for each node in the output</summary>
        public virtual BuildConfig ShowNotifications(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-ShowNotifications",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildConfig) this;
        }

        
/// <summary>Executes only nodes behind the given trigger</summary>
        public virtual BuildConfig Trigger(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Trigger",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildConfig) this;
        }

        
/// <summary>Skips the given triggers, including all the nodes behind them in the graph</summary>
        public virtual BuildConfig SkipTrigger(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-SkipTrigger",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildConfig) this;
        }

        
/// <summary>Skips all triggers</summary>
        public virtual BuildConfig SkipTriggers(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-SkipTriggers",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildConfig) this;
        }

        
/// <summary>Specifies the signature identifying the current job, to be written to tokens for nodes that require them. Tokens are ignored if this parameter is not specified.</summary>
        public virtual BuildConfig TokenSignature(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-TokenSignature",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildConfig) this;
        }

        
/// <summary>Excludes targets which we can't acquire tokens for, rather than failing</summary>
        public virtual BuildConfig SkipTargetsWithoutTokens(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-SkipTargetsWithoutTokens",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildConfig) this;
        }

        
/// <summary>Writes the preprocessed graph to the given file</summary>
        public virtual BuildConfig Preprocess(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Preprocess",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildConfig) this;
        }

        
/// <summary>Exports a JSON file containing the preprocessed build graph, for use as part of a build system</summary>
        public virtual BuildConfig Export(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Export",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildConfig) this;
        }

        
/// <summary>Exports a JSON file containing the full build graph for use by Horde.</summary>
        public virtual BuildConfig HordeExport(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-HordeExport",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildConfig) this;
        }

        
/// <summary>Only include built-in tasks in the schema, excluding any other UAT modules</summary>
        public virtual BuildConfig PublicTasksOnly(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-PublicTasksOnly",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildConfig) this;
        }

        
/// <summary>Sets the directory to use to transfer build products between agents in a build farm</summary>
        public virtual BuildConfig SharedStorageDir(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-SharedStorageDir",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildConfig) this;
        }

        
/// <summary>Run only the given node. Intended for use on a build system after running with -Export.</summary>
        public virtual BuildConfig SingleNode(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-SingleNode",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildConfig) this;
        }

        
/// <summary>Allow writing to shared storage. If not set, but -SharedStorageDir is specified, build products will read but not written</summary>
        public virtual BuildConfig WriteToSharedStorage(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-WriteToSharedStorage",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildConfig) this;
        }

        
    
        public virtual BuildConfig Documentation(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Documentation",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildConfig) this;
        }

        
    
        public virtual BuildConfig ReportName(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-ReportName",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildConfig) this;
        }

        
    
        public virtual BuildConfig Class(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Class",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildConfig) this;
        }

        
    
        public virtual BuildConfig SkipValidation(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-SkipValidation",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildConfig) this;
        }

        
    
        public virtual BuildConfig Branch(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Branch",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE5,
                        AllowMultiple: true
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
        
    
    public  class TempStorageTestsConfig : ToolConfig
    {
        public override string Name => "TempStorageTests";
        public override string CliName => "TempStorageTests";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE4 | UnrealCompatibility.UE5;
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    }

    protected readonly TempStorageTestsConfig TempStorageTestsStorage = new();
        
/// <summary>Removes folders in a given temp storage directory that are older than a certain time.</summary>
    public  class CleanTempStorageConfig : ToolConfig
    {
        public override string Name => "CleanTempStorage";
        public override string CliName => "CleanTempStorage";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE4 | UnrealCompatibility.UE5;
    
/// <summary>Path to the root temp storage directory</summary>
        public virtual CleanTempStorageConfig TempStorageDir(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-TempStorageDir",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (CleanTempStorageConfig) this;
        }

        
/// <summary>Number of days to keep in temp storage</summary>
        public virtual CleanTempStorageConfig Days(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Days",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (CleanTempStorageConfig) this;
        }
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    }

    protected readonly CleanTempStorageConfig CleanTempStorageStorage = new();
        
    
    public  class TestGauntletConfig : ToolConfig
    {
        public override string Name => "TestGauntlet";
        public override string CliName => "TestGauntlet";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE4 | UnrealCompatibility.UE5;
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    }

    protected readonly TestGauntletConfig TestGauntletStorage = new();
        
/// <summary>Run Unreal tests using Gauntlet</summary>
    public  class RunUnrealConfig : ToolConfig
    {
        public override string Name => "RunUnreal";
        public override string CliName => "RunUnreal";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE4 | UnrealCompatibility.UE5;
    
    
        public virtual RunUnrealConfig Log(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-log",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (RunUnrealConfig) this;
        }

        
    
        public virtual RunUnrealConfig Editor(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-editor",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (RunUnrealConfig) this;
        }

        
    
        public virtual RunUnrealConfig Skip(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Skip",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (RunUnrealConfig) this;
        }

        
    
        public virtual RunUnrealConfig Removedevices(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-removedevices",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4,
                        AllowMultiple: true
                    )
                ));
            }
            return (RunUnrealConfig) this;
        }

        
    
        public virtual RunUnrealConfig Clean(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-clean",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (RunUnrealConfig) this;
        }

        
    
        public virtual RunUnrealConfig Listargs(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-listargs",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (RunUnrealConfig) this;
        }

        
    
        public virtual RunUnrealConfig Listallargs(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-listallargs",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (RunUnrealConfig) this;
        }
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    }

    protected readonly RunUnrealConfig RunUnrealStorage = new();
        
/// <summary>Creates an IPA from an xarchive file</summary>
    public  class ExportIPAFromArchiveConfig : ToolConfig
    {
        public override string Name => "ExportIPAFromArchive";
        public override string CliName => "ExportIPAFromArchive";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE4 | UnrealCompatibility.UE5;
    
/// <summary>Purpose of the IPA. (Development, Adhoc, Store)</summary>
        public virtual ExportIPAFromArchiveConfig Method(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-method",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (ExportIPAFromArchiveConfig) this;
        }

        
/// <summary>Path to plist template that will be filled in based on other arguments. See ExportOptions.plist.template for an example</summary>
        public virtual ExportIPAFromArchiveConfig TemplateFile(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-TemplateFile",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (ExportIPAFromArchiveConfig) this;
        }

        
/// <summary>Path to an XML file of options that we'll select from based on method. See ExportOptions.Values.xml for an example</summary>
        public virtual ExportIPAFromArchiveConfig OptionsFile(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-OptionsFile",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (ExportIPAFromArchiveConfig) this;
        }

        
/// <summary>Name of this project (e.g ShooterGame, EngineTest)</summary>
        public virtual ExportIPAFromArchiveConfig Project(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Project",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (ExportIPAFromArchiveConfig) this;
        }

        
    
        public virtual ExportIPAFromArchiveConfig Archive(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-archive",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (ExportIPAFromArchiveConfig) this;
        }

        
    
        public virtual ExportIPAFromArchiveConfig Output(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-output",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (ExportIPAFromArchiveConfig) this;
        }
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    }

    protected readonly ExportIPAFromArchiveConfig ExportIPAFromArchiveStorage = new();
        
/// <summary>Creates an IPA from an xarchive file</summary>
    public  class MakeIPAConfig : ToolConfig
    {
        public override string Name => "MakeIPA";
        public override string CliName => "MakeIPA";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE4 | UnrealCompatibility.UE5;
    
/// <summary>Purpose of the IPA. (Development, Adhoc, Store)</summary>
        public virtual MakeIPAConfig Method(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-method",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (MakeIPAConfig) this;
        }

        
/// <summary>Path to plist template that will be filled in based on other arguments. See ExportOptions.plist.template for an example</summary>
        public virtual MakeIPAConfig TemplateFile(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-TemplateFile",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (MakeIPAConfig) this;
        }

        
/// <summary>Path to an XML file of options that we'll select from based on method. See ExportOptions.Values.xml for an example</summary>
        public virtual MakeIPAConfig OptionsFile(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-OptionsFile",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (MakeIPAConfig) this;
        }

        
/// <summary>Name of this project (e.g ShooterGame, EngineTest)</summary>
        public virtual MakeIPAConfig Project(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Project",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (MakeIPAConfig) this;
        }

        
    
        public virtual MakeIPAConfig Archive(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-archive",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (MakeIPAConfig) this;
        }

        
    
        public virtual MakeIPAConfig Output(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-output",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (MakeIPAConfig) this;
        }
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    }

    protected readonly MakeIPAConfig MakeIPAStorage = new();
        
/// <summary>Pulls a value from an ini file and inserts it into a plist.
/// Note currently only looks at values irrespective of sections!</summary>
    public  class WriteIniValueToPlistConfig : ToolConfig
    {
        public override string Name => "WriteIniValueToPlist";
        public override string CliName => "WriteIniValueToPlist";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE4 | UnrealCompatibility.UE5;
    
/// <summary>Path to ini file to read from
/// Path to the ini file to be read</summary>
        public virtual WriteIniValueToPlistConfig IniFile(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-IniFile",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (WriteIniValueToPlistConfig) this;
        }

        
/// <summary>Name of the ini property to read. E.g. 'Version' for 'Version=12.0'
/// Ini property to read</summary>
        public virtual WriteIniValueToPlistConfig IniProperty(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-IniProperty",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (WriteIniValueToPlistConfig) this;
        }

        
/// <summary>Path to plist file to update
/// Path to the plist file to be updated</summary>
        public virtual WriteIniValueToPlistConfig PlistFile(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-PlistFile",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (WriteIniValueToPlistConfig) this;
        }

        
/// <summary>Plist property to update. E.g. CFBundleShortVersionString</summary>
        public virtual WriteIniValueToPlistConfig PlistProperty(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-PlistProperty",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (WriteIniValueToPlistConfig) this;
        }
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    }

    protected readonly WriteIniValueToPlistConfig WriteIniValueToPlistStorage = new();
        
    
    public  class OneSkyLocalizationProviderConfig : ToolConfig
    {
        public override string Name => "OneSkyLocalizationProvider";
        public override string CliName => "";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE4 | UnrealCompatibility.UE5;
    
/// <summary>Name of the config data to use (see OneSkyConfigHelper).</summary>
        public virtual OneSkyLocalizationProviderConfig OneSkyConfigName(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-OneSkyConfigName",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (OneSkyLocalizationProviderConfig) this;
        }

        
/// <summary>Name of the project group in OneSky.</summary>
        public virtual OneSkyLocalizationProviderConfig OneSkyProjectGroupName(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-OneSkyProjectGroupName",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (OneSkyLocalizationProviderConfig) this;
        }
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    }

    protected readonly OneSkyLocalizationProviderConfig OneSkyLocalizationProviderStorage = new();
        
/// <summary>Analyzes third party libraries</summary>
    public  class AnalyzeThirdPartyLibsConfig : ToolConfig
    {
        public override string Name => "AnalyzeThirdPartyLibs";
        public override string CliName => "AnalyzeThirdPartyLibs";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE4 | UnrealCompatibility.UE5;
    
/// <summary>[Optional] + separated list of libraries to compile; if not specified this job will build all libraries it can find builder scripts for</summary>
        public virtual AnalyzeThirdPartyLibsConfig Libs(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Libs",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (AnalyzeThirdPartyLibsConfig) this;
        }

        
/// <summary>[Optional] a changelist to check out into; if not specified, a changelist will be created</summary>
        public virtual AnalyzeThirdPartyLibsConfig Changelist(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Changelist",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (AnalyzeThirdPartyLibsConfig) this;
        }
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    }

    protected readonly AnalyzeThirdPartyLibsConfig AnalyzeThirdPartyLibsStorage = new();
        
/// <summary>BlameKeyword command. Looks for the specified keywords in all files at the specified path and finds who added them based on P4 history</summary>
/// <remarks>WARNING: This command might require Perforce</remarks>
    public  class BlameKeywordConfig : ToolConfig
    {
        public override string Name => "BlameKeyword";
        public override string CliName => "BlameKeyword";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE4;
    
/// <summary>Local path to search (including subfolders)</summary>
        public virtual BlameKeywordConfig Path(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Path",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4,
                        AllowMultiple: true
                    )
                ));
            }
            return (BlameKeywordConfig) this;
        }

        
/// <summary>Comma separated list of keywords to search for</summary>
        public virtual BlameKeywordConfig Keywords(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Keywords",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4,
                        AllowMultiple: true
                    )
                ));
            }
            return (BlameKeywordConfig) this;
        }

        
/// <summary>(Optional) If specified, uses full revision history (slow)</summary>
        public virtual BlameKeywordConfig Timelapse(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Timelapse",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4,
                        AllowMultiple: true
                    )
                ));
            }
            return (BlameKeywordConfig) this;
        }

        
    
        public virtual BlameKeywordConfig Out(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Out",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4,
                        AllowMultiple: true
                    )
                ));
            }
            return (BlameKeywordConfig) this;
        }
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    }

    protected readonly BlameKeywordConfig BlameKeywordStorage = new();
        
    
    public  class XcodeTargetPlatform_IOSConfig : ToolConfig
    {
        public override string Name => "XcodeTargetPlatform_IOS";
        public override string CliName => "XcodeTargetPlatform_IOS";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE4 | UnrealCompatibility.UE5;
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    }

    protected readonly XcodeTargetPlatform_IOSConfig XcodeTargetPlatform_IOSStorage = new();
        
    
    public  class MakefileTargetPlatform_IOSConfig : ToolConfig
    {
        public override string Name => "MakefileTargetPlatform_IOS";
        public override string CliName => "MakefileTargetPlatform_IOS";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE4 | UnrealCompatibility.UE5;
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    }

    protected readonly MakefileTargetPlatform_IOSConfig MakefileTargetPlatform_IOSStorage = new();
        
/// <summary>Builds common tools used by the engine which are not part of typical editor or game builds. Useful when syncing source-only on GitHub.</summary>
    public  class BuildCommonToolsConfig : ToolConfig
    {
        public override string Name => "BuildCommonTools";
        public override string CliName => "BuildCommonTools";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE4 | UnrealCompatibility.UE5;
    
/// <summary>Specifies on or more platforms to build for (defaults to the current host platform)</summary>
        public virtual BuildCommonToolsConfig Platforms(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-platforms",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildCommonToolsConfig) this;
        }

        
/// <summary>Writes a manifest of all the build products to the given path</summary>
        public virtual BuildCommonToolsConfig Manifest(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-manifest",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildCommonToolsConfig) this;
        }

        
    
        public virtual BuildCommonToolsConfig Allplatforms(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-allplatforms",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildCommonToolsConfig) this;
        }
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    }

    protected readonly BuildCommonToolsConfig BuildCommonToolsStorage = new();
        
    
    public  class ZipProjectUpConfig : ToolConfig
    {
        public override string Name => "ZipProjectUp";
        public override string CliName => "ZipProjectUp";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE4 | UnrealCompatibility.UE5;
    
    
        public virtual ZipProjectUpConfig Project(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-project",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (ZipProjectUpConfig) this;
        }

        
    
        public virtual ZipProjectUpConfig Install(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-install",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (ZipProjectUpConfig) this;
        }
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    }

    protected readonly ZipProjectUpConfig ZipProjectUpStorage = new();
        
/// <summary>Builds/Cooks/Runs a project.
/// 
/// For non-uprojects project targets are discovered by compiling target rule files found in the project folder.
/// If -map is not specified, the command looks for DefaultMap entry in the project's DefaultEngine.ini and if not found, in BaseEngine.ini.
/// If no DefaultMap can be found, the command falls back to /Engine/Maps/Entry.</summary>
    public  class BuildCookRunConfig : ToolConfig
    {
        public override string Name => "BuildCookRun";
        public override string CliName => "BuildCookRun";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE4 | UnrealCompatibility.UE5;
    
/// <summary>Project path (required), i.e: -project=QAGame, -project=Samples\BlackJack\BlackJack.uproject, -project=D:\Projects\MyProject.uproject</summary>
        public virtual BuildCookRunConfig Project(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-project",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildCookRunConfig) this;
        }

        
/// <summary>Destination Sample name</summary>
        public virtual BuildCookRunConfig Destsample(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-destsample",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildCookRunConfig) this;
        }

        
/// <summary>Foreign Destination</summary>
        public virtual BuildCookRunConfig Foreigndest(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-foreigndest",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildCookRunConfig) this;
        }

        
/// <summary>Generate a foreign uproject from blankproject and use that
/// Shared: The current project is a foreign project, commandline: -foreign</summary>
        public virtual BuildCookRunConfig Foreign(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-foreign",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildCookRunConfig) this;
        }

        
/// <summary>Generate a foreign code uproject from platformergame and use that
/// Shared: The current project is a foreign project, commandline: -foreign</summary>
        public virtual BuildCookRunConfig Foreigncode(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-foreigncode",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildCookRunConfig) this;
        }

        
    
        public virtual BuildCookRunConfig Cookdir(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-cookdir",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildCookRunConfig) this;
        }

        
    
        public virtual BuildCookRunConfig Ddc(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-ddc",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildCookRunConfig) this;
        }

        
    
        public virtual BuildCookRunConfig I18npreset(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-i18npreset",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildCookRunConfig) this;
        }

        
    
        public virtual BuildCookRunConfig Cookcultures(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-cookcultures",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildCookRunConfig) this;
        }

        
/// <summary>target platform for building, cooking and deployment (also -Platform)</summary>
        public virtual BuildCookRunConfig Targetplatform(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-targetplatform",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildCookRunConfig) this;
        }

        
/// <summary>target platform for building, cooking and deployment of the dedicated server (also -ServerPlatform)</summary>
        public virtual BuildCookRunConfig Servertargetplatform(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-servertargetplatform",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildCookRunConfig) this;
        }

        
/// <summary>true if we should build crash reporter
/// Shared: true if we should build crash reporter</summary>
        public virtual BuildCookRunConfig CrashReporter(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-CrashReporter",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildCookRunConfig) this;
        }

        
/// <summary>Determines if the build is going to use cooked data
/// Shared: Determines if the build is going to use cooked data, commandline: -cook, -cookonthefly</summary>
        public virtual BuildCookRunConfig Cook(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-cook",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildCookRunConfig) this;
        }

        
/// <summary>use a cooked build, but we assume the cooked data is up to date and where it belongs, implies -cook
/// Shared: Determines if the build is going to use cooked data, commandline: -cook, -cookonthefly</summary>
        public virtual BuildCookRunConfig Skipcook(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-skipcook",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildCookRunConfig) this;
        }

        
/// <summary>in a cookonthefly build, used solely to pass information to the package step
/// Shared: In a cookonthefly build, used solely to pass information to the package step. This is necessary because you can't set cookonthefly and cook at the same time, and skipcook sets cook.</summary>
        public virtual BuildCookRunConfig Skipcookonthefly(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-skipcookonthefly",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildCookRunConfig) this;
        }

        
/// <summary>wipe intermediate folders before building
/// Shared: Determines if the intermediate folders will be wiped before building, commandline: -clean</summary>
        public virtual BuildCookRunConfig Clean(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-clean",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildCookRunConfig) this;
        }

        
/// <summary>assumes no operator is present, always terminates without waiting for something.
/// Shared: Assumes no user is sitting at the console, so for example kills clients automatically, commandline: -Unattended</summary>
        public virtual BuildCookRunConfig Unattended(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-unattended",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildCookRunConfig) this;
        }

        
/// <summary>generate a pak file
/// disable reuse of pak files from the alternate cook source folder, if specified
/// Shared: True if pak file should be generated.</summary>
        public virtual BuildCookRunConfig Pak(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-pak",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildCookRunConfig) this;
        }

        
/// <summary>generate I/O store container file(s)
/// Shared: True if container file(s) should be generated with ZenPak.</summary>
        public virtual BuildCookRunConfig Iostore(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-iostore",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildCookRunConfig) this;
        }

        
/// <summary>generate optimized config data during staging to improve loadtimes</summary>
        public virtual BuildCookRunConfig Makebinaryconfig(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-makebinaryconfig",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildCookRunConfig) this;
        }

        
/// <summary>sign the generated pak file with the specified key, i.e. -signpak=C:\Encryption.keys. Also implies -signedpak.
/// Shared: Encryption keys used for signing the pak file.</summary>
        public virtual BuildCookRunConfig Signpak(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-signpak",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildCookRunConfig) this;
        }

        
/// <summary>attempt to avoid cooking and instead pull pak files from the network, implies pak and skipcook
/// Shared: true if this build is staged, command line: -stage</summary>
        public virtual BuildCookRunConfig Prepak(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-prepak",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildCookRunConfig) this;
        }

        
/// <summary>the game should expect to use a signed pak file.</summary>
        public virtual BuildCookRunConfig Signed(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-signed",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildCookRunConfig) this;
        }

        
/// <summary>The game will be set up for memory mapping bulk data.
/// Shared: The game will be set up for memory mapping bulk data.</summary>
        public virtual BuildCookRunConfig PakAlignForMemoryMapping(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-PakAlignForMemoryMapping",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildCookRunConfig) this;
        }

        
/// <summary>use a pak file, but assume it is already built, implies pak
/// Shared: true if this build is staged, command line: -stage</summary>
        public virtual BuildCookRunConfig Skippak(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-skippak",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildCookRunConfig) this;
        }

        
/// <summary>override the -iostore commandline option to not run it
/// Shared: true if we want to skip iostore, even if -iostore is specified</summary>
        public virtual BuildCookRunConfig Skipiostore(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-skipiostore",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildCookRunConfig) this;
        }

        
/// <summary>put this build in a stage directory
/// Shared: true if this build is staged, command line: -stage</summary>
        public virtual BuildCookRunConfig Stage(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-stage",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildCookRunConfig) this;
        }

        
/// <summary>uses a stage directory, but assumes everything is already there, implies -stage
/// Shared: true if this build is staged, command line: -stage</summary>
        public virtual BuildCookRunConfig Skipstage(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-skipstage",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildCookRunConfig) this;
        }

        
/// <summary>generate streaming install manifests when cooking data
/// Shared: true if this build is using streaming install manifests, command line: -manifests</summary>
        public virtual BuildCookRunConfig Manifests(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-manifests",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildCookRunConfig) this;
        }

        
/// <summary>generate streaming install data from manifest when cooking data, requires -stage &amp; -manifests
/// Shared: true if this build chunk install streaming install data, command line: -createchunkinstalldata</summary>
        public virtual BuildCookRunConfig Createchunkinstall(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-createchunkinstall",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildCookRunConfig) this;
        }

        
/// <summary>skips encrypting pak files even if crypto keys are provided</summary>
        public virtual BuildCookRunConfig Skipencryption(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-skipencryption",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildCookRunConfig) this;
        }

        
/// <summary>Directory to copy the builds to, i.e. -stagingdirectory=C:\Stage</summary>
        public virtual BuildCookRunConfig Stagingdirectory(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-stagingdirectory",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildCookRunConfig) this;
        }

        
/// <summary>Name of the UE4 Editor executable, i.e. -ue4exe=UE4Editor.exe</summary>
        public virtual BuildCookRunConfig Ue4exe(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-ue4exe",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildCookRunConfig) this;
        }

        
/// <summary>put this build in an archive directory
/// Shared: true if this build is archived, command line: -archive</summary>
        public virtual BuildCookRunConfig Archive(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-archive",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildCookRunConfig) this;
        }

        
/// <summary>Directory to archive the builds to, i.e. -archivedirectory=C:\Archive</summary>
        public virtual BuildCookRunConfig Archivedirectory(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-archivedirectory",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildCookRunConfig) this;
        }

        
/// <summary>Archive extra metadata files in addition to the build (e.g. build.properties)
/// Whether the project should use non monolithic staging</summary>
        public virtual BuildCookRunConfig Archivemetadata(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-archivemetadata",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildCookRunConfig) this;
        }

        
/// <summary>When archiving for Mac, set this to true to package it in a .app bundle instead of normal loose files</summary>
        public virtual BuildCookRunConfig Createappbundle(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-createappbundle",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildCookRunConfig) this;
        }

        
/// <summary>True if build step should be executed
/// Build: True if build step should be executed, command: -build</summary>
        public virtual BuildCookRunConfig Build(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-build",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildCookRunConfig) this;
        }

        
/// <summary>True if XGE should NOT be used for building
/// Build: True if XGE should NOT be used for building.
/// Toggle to disable the distributed build process</summary>
        public virtual BuildCookRunConfig Noxge(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-noxge",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildCookRunConfig) this;
        }

        
/// <summary>while cooking clean up packages as we are done with them rather then cleaning everything up when we run out of space
/// Cook: While cooking clean up packages as we go along rather then cleaning everything (and potentially having to reload some of it) when we run out of space</summary>
        public virtual BuildCookRunConfig CookPartialgc(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-CookPartialgc",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildCookRunConfig) this;
        }

        
/// <summary>Did we cook in the editor instead of in UAT
/// Stage: Did we cook in the editor instead of from UAT (cook in editor uses a different staging directory)</summary>
        public virtual BuildCookRunConfig CookInEditor(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-CookInEditor",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildCookRunConfig) this;
        }

        
/// <summary>Uses the iterative cooking, command line: -iterativecooking or -iterate
/// Uses the iterative cooking, command line: -iterativedeploy or -iterate
/// Cook: Uses the iterative cooking, command line: -iterativecooking or -iterate</summary>
        public virtual BuildCookRunConfig Iterativecooking(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-iterativecooking",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildCookRunConfig) this;
        }

        
/// <summary>Cook only maps this only affects usage of -cookall the flag
/// Cook: Only cook maps (and referenced content) instead of cooking everything only affects -cookall flag</summary>
        public virtual BuildCookRunConfig CookMapsOnly(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-CookMapsOnly",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildCookRunConfig) this;
        }

        
/// <summary>Cook all the things in the content directory for this project
/// Cook: Only cook maps (and referenced content) instead of cooking everything only affects cookall flag</summary>
        public virtual BuildCookRunConfig CookAll(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-CookAll",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildCookRunConfig) this;
        }

        
/// <summary>Skips content under /Engine/Editor when cooking
/// Cook: Skip cooking editor content</summary>
        public virtual BuildCookRunConfig SkipCookingEditorContent(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-SkipCookingEditorContent",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildCookRunConfig) this;
        }

        
/// <summary>Uses fast cook path if supported by target</summary>
        public virtual BuildCookRunConfig FastCook(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-FastCook",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildCookRunConfig) this;
        }

        
/// <summary>Ignores cook errors and continues with packaging etc
/// Cook: Ignores cook errors and continues with packaging etc.</summary>
        public virtual BuildCookRunConfig IgnoreCookErrors(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-IgnoreCookErrors",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildCookRunConfig) this;
        }

        
/// <summary>do not copy debug files to the stage
/// Stage: Commandline: -nodebuginfo</summary>
        public virtual BuildCookRunConfig Nodebuginfo(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-nodebuginfo",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildCookRunConfig) this;
        }

        
/// <summary>output debug info to a separate directory
/// Stage: Commandline: -separatedebuginfo</summary>
        public virtual BuildCookRunConfig Separatedebuginfo(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-separatedebuginfo",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildCookRunConfig) this;
        }

        
/// <summary>generates a *.map file
/// Stage: Commandline: -mapfile</summary>
        public virtual BuildCookRunConfig MapFile(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-MapFile",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildCookRunConfig) this;
        }

        
/// <summary>skip cleaning the stage directory
/// true if the staging directory is to be cleaned: -cleanstage (also true if -clean is specified)</summary>
        public virtual BuildCookRunConfig Nocleanstage(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-nocleanstage",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildCookRunConfig) this;
        }

        
/// <summary>command line to put into the stage in UE4CommandLine.txt
/// command line to put into the stage in UECommandLine.txt</summary>
        public virtual BuildCookRunConfig Cmdline(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-cmdline",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildCookRunConfig) this;
        }

        
/// <summary>string to use as the bundle name when deploying to mobile device
/// Stage: If non-empty, the contents will be used for the bundle name</summary>
        public virtual BuildCookRunConfig Bundlename(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-bundlename",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildCookRunConfig) this;
        }

        
/// <summary>run the game after it is built (including server, if -server)
/// Run: True if the Run step should be executed, command: -run</summary>
        public virtual BuildCookRunConfig Run(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-run",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildCookRunConfig) this;
        }

        
/// <summary>run the client with cooked data provided by cook on the fly server
/// Run: The client runs with cooked data provided by cook on the fly server, command line: -cookonthefly</summary>
        public virtual BuildCookRunConfig Cookonthefly(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-cookonthefly",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildCookRunConfig) this;
        }

        
/// <summary>run the client in streaming cook on the fly mode (don't cache files locally instead force reget from server each file load)
/// Run: The client should run in streaming mode when connecting to cook on the fly server</summary>
        public virtual BuildCookRunConfig Cookontheflystreaming(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Cookontheflystreaming",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildCookRunConfig) this;
        }

        
/// <summary>run the client with cooked data provided by UnrealFileServer
/// Run: The client runs with cooked data provided by UnrealFileServer, command line: -fileserver</summary>
        public virtual BuildCookRunConfig Fileserver(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-fileserver",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildCookRunConfig) this;
        }

        
/// <summary>build, cook and run both a client and a server (also -server)
/// Run: The client connects to dedicated server to get data, command line: -dedicatedserver</summary>
        public virtual BuildCookRunConfig Dedicatedserver(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-dedicatedserver",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildCookRunConfig) this;
        }

        
/// <summary>build, cook and run a client and a server, uses client target configuration
/// Run: Uses a client target configuration, also implies -dedicatedserver, command line: -client</summary>
        public virtual BuildCookRunConfig Client(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-client",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildCookRunConfig) this;
        }

        
/// <summary>do not run the client, just run the server
/// Run: Whether the client should start or not, command line (to disable): -noclient</summary>
        public virtual BuildCookRunConfig Noclient(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-noclient",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildCookRunConfig) this;
        }

        
/// <summary>create a log window for the client
/// Run: Client should create its own log window, command line: -logwindow</summary>
        public virtual BuildCookRunConfig Logwindow(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-logwindow",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildCookRunConfig) this;
        }

        
/// <summary>map to run the game with</summary>
        public virtual BuildCookRunConfig Map(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-map",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildCookRunConfig) this;
        }

        
/// <summary>Additional server map params, i.e ?param=value
/// Run: Additional server map params.</summary>
        public virtual BuildCookRunConfig AdditionalServerMapParams(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-AdditionalServerMapParams",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildCookRunConfig) this;
        }

        
/// <summary>Devices to run the game on
/// Device names without the platform prefix to run the game on</summary>
        public virtual BuildCookRunConfig Device(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-device",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildCookRunConfig) this;
        }

        
/// <summary>Device to run the server on
/// Run: the target device to run the server on</summary>
        public virtual BuildCookRunConfig Serverdevice(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-serverdevice",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildCookRunConfig) this;
        }

        
/// <summary>Skip starting the server
/// Run: The indicated server has already been started</summary>
        public virtual BuildCookRunConfig Skipserver(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-skipserver",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildCookRunConfig) this;
        }

        
/// <summary>Start extra clients, n should be 2 or more
/// Run: The indicated server has already been started</summary>
        public virtual BuildCookRunConfig Numclients(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-numclients",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildCookRunConfig) this;
        }

        
/// <summary>Additional command line arguments for the program</summary>
        public virtual BuildCookRunConfig Addcmdline(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-addcmdline",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildCookRunConfig) this;
        }

        
/// <summary>Additional command line arguments for the program</summary>
        public virtual BuildCookRunConfig Servercmdline(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-servercmdline",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildCookRunConfig) this;
        }

        
/// <summary>Override command line arguments to pass to the client</summary>
        public virtual BuildCookRunConfig Clientcmdline(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-clientcmdline",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildCookRunConfig) this;
        }

        
/// <summary>add -nullrhi to the client commandlines
/// Run:adds -nullrhi to the client commandline</summary>
        public virtual BuildCookRunConfig Nullrhi(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-nullrhi",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildCookRunConfig) this;
        }

        
/// <summary>adds ?fake to the server URL
/// Run:adds ?fake to the server URL</summary>
        public virtual BuildCookRunConfig Fakeclient(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-fakeclient",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildCookRunConfig) this;
        }

        
/// <summary>rather than running a client, run the editor instead
/// Run:adds ?fake to the server URL</summary>
        public virtual BuildCookRunConfig Editortest(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-editortest",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildCookRunConfig) this;
        }

        
/// <summary>when running -editortest or a client, run all automation tests, not compatible with -server
/// when running -editortest or a client, run a specific automation tests, not compatible with -server
/// Run:when running -editortest or a client, run all automation tests, not compatible with -server</summary>
        public virtual BuildCookRunConfig RunAutomationTests(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-RunAutomationTests",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildCookRunConfig) this;
        }

        
/// <summary>when running -editortest or a client, adds commands like debug crash, debug rendercrash, etc based on index</summary>
        public virtual BuildCookRunConfig Crash(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Crash",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildCookRunConfig) this;
        }

        
/// <summary>Linux username for unattended key genereation</summary>
        public virtual BuildCookRunConfig Deviceuser(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-deviceuser",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildCookRunConfig) this;
        }

        
/// <summary>Linux password</summary>
        public virtual BuildCookRunConfig Devicepass(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-devicepass",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildCookRunConfig) this;
        }

        
/// <summary>package the project for the target platform
/// Determine whether data is packaged. This can be an iteration optimization for platforms that require packages for deployment</summary>
        public virtual BuildCookRunConfig Package(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-package",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildCookRunConfig) this;
        }

        
/// <summary>Skips packaging the project for the target platform</summary>
        public virtual BuildCookRunConfig Skippackage(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-skippackage",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildCookRunConfig) this;
        }

        
/// <summary>package for distribution the project</summary>
        public virtual BuildCookRunConfig Distribution(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-distribution",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildCookRunConfig) this;
        }

        
/// <summary>stage prerequisites along with the project</summary>
        public virtual BuildCookRunConfig Prereqs(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-prereqs",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildCookRunConfig) this;
        }

        
/// <summary>location of prerequisites for applocal deployment</summary>
        public virtual BuildCookRunConfig Applocaldir(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-applocaldir",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildCookRunConfig) this;
        }

        
/// <summary>this is a prebuilt cooked and packaged build</summary>
        public virtual BuildCookRunConfig Prebuilt(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Prebuilt",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildCookRunConfig) this;
        }

        
/// <summary>timeout to wait after we lunch the game</summary>
        public virtual BuildCookRunConfig RunTimeoutSeconds(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-RunTimeoutSeconds",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildCookRunConfig) this;
        }

        
/// <summary>Determine a specific Minimum OS</summary>
        public virtual BuildCookRunConfig SpecifiedArchitecture(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-SpecifiedArchitecture",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildCookRunConfig) this;
        }

        
/// <summary>extra options to pass to ubt</summary>
        public virtual BuildCookRunConfig UbtArgs(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-UbtArgs",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildCookRunConfig) this;
        }

        
/// <summary>extra options to pass to the platform's packager</summary>
        public virtual BuildCookRunConfig AdditionalPackageOptions(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-AdditionalPackageOptions",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildCookRunConfig) this;
        }

        
/// <summary>deploy the project for the target platform
/// Location to deploy to on the target platform</summary>
        public virtual BuildCookRunConfig Deploy(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-deploy",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildCookRunConfig) this;
        }

        
/// <summary>download file from target after successful run</summary>
        public virtual BuildCookRunConfig Getfile(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-getfile",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildCookRunConfig) this;
        }

        
/// <summary>List of maps that need light maps rebuilding</summary>
        public virtual BuildCookRunConfig MapsToRebuildLightMaps(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-MapsToRebuildLightMaps",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildCookRunConfig) this;
        }

        
/// <summary>List of maps that need HLOD rebuilding</summary>
        public virtual BuildCookRunConfig MapsToRebuildHLODMaps(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-MapsToRebuildHLODMaps",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildCookRunConfig) this;
        }

        
/// <summary>Whether Light Map errors should be treated as critical</summary>
        public virtual BuildCookRunConfig IgnoreLightMapErrors(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-IgnoreLightMapErrors",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildCookRunConfig) this;
        }

        
    
        public virtual BuildCookRunConfig Cookflavor(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-cookflavor",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildCookRunConfig) this;
        }

        
    
        public virtual BuildCookRunConfig Skipbuild(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-skipbuild",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildCookRunConfig) this;
        }

        
/// <summary>
/// SkipBuildClient if true then don't build the client exe
/// </summary>
        public virtual BuildCookRunConfig SkipBuildClient(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-skipbuildclient",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildCookRunConfig) this;
        }

        
/// <summary>
/// SkipBuildEditor if true then don't build the editor exe
/// </summary>
        public virtual BuildCookRunConfig SkipBuildEditor(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-skipbuildeditor",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildCookRunConfig) this;
        }

        
    
        public virtual BuildCookRunConfig Createreleaseversionroot(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-createreleaseversionroot",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildCookRunConfig) this;
        }

        
    
        public virtual BuildCookRunConfig Basedonreleaseversionroot(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-basedonreleaseversionroot",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildCookRunConfig) this;
        }

        
/// <summary>
/// The version of the originally released build. This is required by some platforms when generating patches.
/// </summary>
        public virtual BuildCookRunConfig OriginalReleaseVersion(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-originalreleaseversion",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildCookRunConfig) this;
        }

        
/// <summary>
/// Cook: Create a cooked release version.  Also, the version. e.g. 1.0
/// </summary>
        public virtual BuildCookRunConfig CreateReleaseVersion(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-createreleaseversion",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildCookRunConfig) this;
        }

        
/// <summary>
/// Cook: Base this cook of a already released version of the cooked data
/// </summary>
        public virtual BuildCookRunConfig BasedOnReleaseVersion(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-basedonreleaseversion",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildCookRunConfig) this;
        }

        
/// <summary>
/// Are we generating a patch, generate a patch from a previously released version of the game (use CreateReleaseVersion to create a release).
/// this requires BasedOnReleaseVersion
/// see also CreateReleaseVersion, BasedOnReleaseVersion
/// </summary>
        public virtual BuildCookRunConfig GeneratePatch(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-GeneratePatch",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildCookRunConfig) this;
        }

        
/// <summary></summary>
        public virtual BuildCookRunConfig AddPatchLevel(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-AddPatchLevel",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildCookRunConfig) this;
        }

        
/// <summary>
/// Are we staging the unmodified pak files from the base release</summary>
        public virtual BuildCookRunConfig StageBaseReleasePaks(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-StageBaseReleasePaks",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildCookRunConfig) this;
        }

        
/// <summary>
/// Required when building remaster package
/// </summary>
        public virtual BuildCookRunConfig DiscVersion(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-DiscVersion",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildCookRunConfig) this;
        }

        
/// <summary>
/// Cook: Additional cooker options to include on the cooker commandline
/// </summary>
        public virtual BuildCookRunConfig AdditionalCookerOptions(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-AdditionalCookerOptions",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildCookRunConfig) this;
        }

        
    
        public virtual BuildCookRunConfig DLCName(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-DLCName",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildCookRunConfig) this;
        }

        
/// <summary>
/// After cook completes diff the cooked content against another cooked content directory.
/// report all errors to the log
/// </summary>
        public virtual BuildCookRunConfig DiffCookedContentPath(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-DiffCookedContentPath",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildCookRunConfig) this;
        }

        
/// <summary>
/// Enable cooking of engine content when cooking dlc
/// not included in original release but is referenced by current cook
/// </summary>
        public virtual BuildCookRunConfig DLCIncludeEngineContent(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-DLCIncludeEngineContent",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildCookRunConfig) this;
        }

        
/// <summary>
/// Enable packaging up the uplugin file inside the dlc pak.  This is sometimes desired if you want the plugin to be standalone
/// </summary>
        public virtual BuildCookRunConfig DLCPakPluginFile(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-DLCPakPluginFile",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildCookRunConfig) this;
        }

        
/// <summary>
/// DLC will remap it's files to the game directory and act like a patch.  This is useful if you want to override content in the main game along side your main game.
/// For example having different main game content in different DLCs
/// </summary>
        public virtual BuildCookRunConfig DLCActLikePatch(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-DLCActLikePatch",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildCookRunConfig) this;
        }

        
/// <summary>
/// Shared: the game will use only signed content.
/// </summary>
        public virtual BuildCookRunConfig SignedPak(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-signedpak",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildCookRunConfig) this;
        }

        
/// <summary>
/// Stage: True if we should disable trying to re-use pak files from another staged build when we've specified a different cook source platform
/// </summary>
        public virtual BuildCookRunConfig IgnorePaksFromDifferentCookSource(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-IgnorePaksFromDifferentCookSource",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildCookRunConfig) this;
        }

        
/// <summary>
/// Cook: Do not include a version number in the cooked content
/// </summary>
        public virtual BuildCookRunConfig UnversionedCookedContent(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-UnversionedCookedContent",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildCookRunConfig) this;
        }

        
/// <summary>
/// Cook: number of additional cookers to spawn while cooking
/// </summary>
        public virtual BuildCookRunConfig NumCookersToSpawn(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-NumCookersToSpawn",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildCookRunConfig) this;
        }

        
/// <summary>
/// Compress packages during cook.
/// </summary>
        public virtual BuildCookRunConfig Compressed(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-compressed",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildCookRunConfig) this;
        }

        
/// <summary>
/// Do not compress packages during cook, override game ProjectPackagingSettings to force it off
/// </summary>
        public virtual BuildCookRunConfig ForceUncompressed(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-ForceUncompressed",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildCookRunConfig) this;
        }

        
/// <summary>
/// Additional parameters when generating the PAK file
/// </summary>
        public virtual BuildCookRunConfig AdditionalPakOptions(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-AdditionalPakOptions",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildCookRunConfig) this;
        }

        
/// <summary>
/// Additional parameters when generating iostore container files
/// </summary>
        public virtual BuildCookRunConfig AdditionalIoStoreOptions(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-AdditionalIoStoreOptions",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildCookRunConfig) this;
        }

        
/// <summary>
/// Cook: Iterate from a build on the network
/// </summary>
        public virtual BuildCookRunConfig Iteratesharedcookedbuild(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-iteratesharedcookedbuild",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildCookRunConfig) this;
        }

        
/// <summary>
/// Build: Don't build the game instead use the prebuild exe (requires iterate shared cooked build
/// </summary>
        public virtual BuildCookRunConfig IterateSharedBuildUsePrecompiledExe(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-IterateSharedBuildUsePrecompiledExe",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildCookRunConfig) this;
        }

        
/// <summary>
/// Cook: Output directory for cooked data
/// </summary>
        public virtual BuildCookRunConfig CookOutputDir(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-CookOutputDir",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildCookRunConfig) this;
        }

        
    
        public virtual BuildCookRunConfig Target(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-target",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildCookRunConfig) this;
        }

        
/// <summary>Stage: Specifies a list of extra targets that should be staged along with a client
/// </summary>
        public virtual BuildCookRunConfig ExtraTargetsToStageWithClient(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-ExtraTargetsToStageWithClient",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildCookRunConfig) this;
        }

        
/// <summary>
/// By default we don't code sign unless it is required or requested
/// </summary>
        public virtual BuildCookRunConfig CodeSign(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-CodeSign",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildCookRunConfig) this;
        }

        
/// <summary>
/// If true, non-shipping binaries will be considered DebugUFS files and will appear on the debugfiles manifest
/// </summary>
        public virtual BuildCookRunConfig TreatNonShippingBinariesAsDebugFiles(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-TreatNonShippingBinariesAsDebugFiles",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildCookRunConfig) this;
        }

        
/// <summary>
/// If true, use chunk manifest files generated for extra flavor
/// </summary>
        public virtual BuildCookRunConfig UseExtraFlavor(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-UseExtraFlavor",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildCookRunConfig) this;
        }

        
/// <summary>
/// Shared: Directory to use for built chunk install data, command line: -chunkinstalldirectory=
/// </summary>
        public virtual BuildCookRunConfig ChunkInstallDirectory(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-chunkinstalldirectory",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildCookRunConfig) this;
        }

        
    
        public virtual BuildCookRunConfig Chunkinstallversion(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-chunkinstallversion",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildCookRunConfig) this;
        }

        
    
        public virtual BuildCookRunConfig Chunkinstallrelease(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-chunkinstallrelease",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildCookRunConfig) this;
        }

        
    
        public virtual BuildCookRunConfig AppLocalDirectory(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-applocaldirectory",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildCookRunConfig) this;
        }

        
/// <summary>
/// On Windows, adds an executable to the root of the staging directory which checks for prerequisites being
/// installed and launches the game with a path to the .uproject file.
/// </summary>
        public virtual BuildCookRunConfig NoBootstrapExe(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-nobootstrapexe",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildCookRunConfig) this;
        }

        
    
        public virtual BuildCookRunConfig ForcePackageData(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-forcepackagedata",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildCookRunConfig) this;
        }

        
/// <summary>
/// Cook: Uses the iterative deploy, command line: -iterativedeploy or -iterate
/// </summary>
        public virtual BuildCookRunConfig IterativeDeploy(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-iterativedeploy",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildCookRunConfig) this;
        }

        
/// <summary>
/// Provision to use
/// </summary>
        public virtual BuildCookRunConfig Provision(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-provision",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildCookRunConfig) this;
        }

        
/// <summary>
/// Certificate to use
/// </summary>
        public virtual BuildCookRunConfig Certificate(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-certificate",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildCookRunConfig) this;
        }

        
/// <summary>
/// Team ID to use
/// </summary>
        public virtual BuildCookRunConfig Team(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-team",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildCookRunConfig) this;
        }

        
/// <summary>
/// true if provisioning is automatically managed
/// </summary>
        public virtual BuildCookRunConfig AutomaticSigning(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-AutomaticSigning",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildCookRunConfig) this;
        }

        
/// <summary>
/// Run:when running -editortest or a client, run all automation tests, not compatible with -server
/// </summary>
        public virtual BuildCookRunConfig RunAutomationTest(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-RunAutomationTest",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildCookRunConfig) this;
        }

        
/// <summary>Name of the Unreal Editor executable, i.e. -unrealexe=UnrealEditor.exe</summary>
        public virtual BuildCookRunConfig UnrealExe(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-ue4exe",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildCookRunConfig) this;
        }

        
    
        public virtual BuildCookRunConfig Clientconfig(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-clientconfig",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildCookRunConfig) this;
        }

        
    
        public virtual BuildCookRunConfig Config(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-config",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildCookRunConfig) this;
        }

        
    
        public virtual BuildCookRunConfig Configuration(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-configuration",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildCookRunConfig) this;
        }

        
    
        public virtual BuildCookRunConfig Port(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-port",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildCookRunConfig) this;
        }

        
/// <summary>
/// Cook: List of maps to cook.
/// </summary>
        public virtual BuildCookRunConfig MapsToCook(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-MapsToCook",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildCookRunConfig) this;
        }

        
/// <summary>
/// Cook: List of map inisections to cook (see allmaps)
/// </summary>
        public virtual BuildCookRunConfig MapIniSectionsToCook(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-MapIniSectionsToCook",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildCookRunConfig) this;
        }

        
/// <summary>
/// TitleID to package
/// </summary>
        public virtual BuildCookRunConfig TitleID(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-TitleID",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildCookRunConfig) this;
        }

        
    
        public virtual BuildCookRunConfig Serverconfig(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-serverconfig",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildCookRunConfig) this;
        }

        
/// <summary>
/// Run: Adds commands like debug crash, debug rendercrash, etc based on index
/// </summary>
        public virtual BuildCookRunConfig CrashIndex(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-CrashIndex",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildCookRunConfig) this;
        }

        
/// <summary>Toggle to combined the result into one executable</summary>
        public virtual BuildCookRunConfig ForceMonolithic(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-ForceMonolithic",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildCookRunConfig) this;
        }

        
/// <summary>Forces debug info even in development builds</summary>
        public virtual BuildCookRunConfig ForceDebugInfo(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-ForceDebugInfo",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildCookRunConfig) this;
        }

        
/// <summary>Toggle to disable the unity build system</summary>
        public virtual BuildCookRunConfig ForceNonUnity(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-ForceNonUnity",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildCookRunConfig) this;
        }

        
/// <summary>Toggle to force enable the unity build system</summary>
        public virtual BuildCookRunConfig ForceUnity(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-ForceUnity",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildCookRunConfig) this;
        }

        
/// <summary>If set, this build is being compiled by a licensee</summary>
        public virtual BuildCookRunConfig Licensee(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Licensee",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildCookRunConfig) this;
        }

        
    
        public virtual BuildCookRunConfig Promoted(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Promoted",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildCookRunConfig) this;
        }

        
    
        public virtual BuildCookRunConfig Branch(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Branch",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildCookRunConfig) this;
        }

        
    
        public virtual BuildCookRunConfig StopOnErrors(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-StopOnErrors",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildCookRunConfig) this;
        }

        
/// <summary>Skips signing of code/content files.</summary>
        public virtual BuildCookRunConfig NoSign(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-NoSign",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildCookRunConfig) this;
        }

        
/// <summary>
/// Stage: Path to the global.utoc file for a directory of iostore containers to use as a source of compressed
/// chunks when writing new containers. See -ReferenceContainerGlobalFileName in IoStoreUtilities.cpp.
/// </summary>
        public virtual BuildCookRunConfig ReferenceContainerGlobalFileName(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-ReferenceContainerGlobalFileName",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildCookRunConfig) this;
        }

        
/// <summary>
/// Stage: Path to the crypto.json file to use for decrypting ReferenceContainerFlobalFileName, if needed.
/// </summary>
        public virtual BuildCookRunConfig ReferenceContainerCryptoKeys(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-ReferenceContainerCryptoKeys",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildCookRunConfig) this;
        }

        
/// <summary>generate I/O store container file(s)
/// Shared: True if the cooker should write directly to container file(s)</summary>
        public virtual BuildCookRunConfig Cook4iostore(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-cook4iostore",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildCookRunConfig) this;
        }

        
/// <summary>save cooked output data to the Zen storage server
/// Shared: True if the cooker should store the cooked output to the Zen storage server</summary>
        public virtual BuildCookRunConfig Zenstore(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-zenstore",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildCookRunConfig) this;
        }

        
/// <summary>URL to a running Zen server
/// Shared: URL to a running Zen server</summary>
        public virtual BuildCookRunConfig Nozenautolaunch(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-nozenautolaunch",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildCookRunConfig) this;
        }

        
/// <summary>Should virtualized assets be rehydrated?
/// Shared: true if we want to rehydrate virtualized assets when staging.</summary>
        public virtual BuildCookRunConfig Rehydrateassets(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-rehydrateassets",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildCookRunConfig) this;
        }

        
/// <summary>Directory to copy the optional files to, i.e. -optionalfilestagingdirectory=C:\StageOptional</summary>
        public virtual BuildCookRunConfig Optionalfilestagingdirectory(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-optionalfilestagingdirectory",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildCookRunConfig) this;
        }

        
/// <summary>Directory to read the optional files from, i.e. -optionalfileinputdirectory=C:\StageOptional</summary>
        public virtual BuildCookRunConfig Optionalfileinputdirectory(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-optionalfileinputdirectory",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildCookRunConfig) this;
        }

        
/// <summary>Subdirectory under staging to copy CookerSupportFiles (as set in Build.cs files). -CookerSupportFilesSubdirectory=SDK</summary>
        public virtual BuildCookRunConfig CookerSupportFilesSubdirectory(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-CookerSupportFilesSubdirectory",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildCookRunConfig) this;
        }

        
/// <summary>Skips preparing data that would be used during packaging, in earlier stages. Different from skippackage which is used to optimize later stages like archive, which still was packaged at some point</summary>
        public virtual BuildCookRunConfig Neverpackage(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-neverpackage",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildCookRunConfig) this;
        }

        
/// <summary>Path to file containing encryption key to use in packaging</summary>
        public virtual BuildCookRunConfig PackageEncryptionKeyFile(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-PackageEncryptionKeyFile",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildCookRunConfig) this;
        }

        
/// <summary>The list of trace channels to enable</summary>
        public virtual BuildCookRunConfig Trace(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-trace",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildCookRunConfig) this;
        }

        
/// <summary>The host address of the trace recorder</summary>
        public virtual BuildCookRunConfig Tracehost(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-tracehost",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildCookRunConfig) this;
        }

        
/// <summary>The file where the trace will be recorded</summary>
        public virtual BuildCookRunConfig Tracefile(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-tracefile",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildCookRunConfig) this;
        }

        
/// <summary>A label to pass to analytics</summary>
        public virtual BuildCookRunConfig Sessionlabel(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-sessionlabel",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildCookRunConfig) this;
        }

        
/// <summary>
/// Sometimes a DLC may get cooked to a subdirectory of where is expected, so this can tell the staging what the subdirectory of the cooked out
/// to find the DLC files (for instance Metadata)
/// </summary>
        public virtual BuildCookRunConfig DLCOverrideCookedSubDir(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-DLCOverrideCookedSubDir",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildCookRunConfig) this;
        }

        
/// <summary>
/// Controls where under the staged directory to output to (in case the plugin subdirectory is not desired under the StagingDirectory location)
/// </summary>
        public virtual BuildCookRunConfig DLCOverrideStagedSubDir(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-DLCOverrideStagedSubDir",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildCookRunConfig) this;
        }

        
    
        public virtual BuildCookRunConfig Editoroptional(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-editoroptional",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildCookRunConfig) this;
        }
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    }

    protected readonly BuildCookRunConfig BuildCookRunStorage = new();
        
    
    public  class BuildDerivedDataCacheConfig : ToolConfig
    {
        public override string Name => "BuildDerivedDataCache";
        public override string CliName => "BuildDerivedDataCache";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE4 | UnrealCompatibility.UE5;
    
    
        public virtual BuildDerivedDataCacheConfig FeaturePacks(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-FeaturePacks",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildDerivedDataCacheConfig) this;
        }

        
    
        public virtual BuildDerivedDataCacheConfig TempDir(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-TempDir",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildDerivedDataCacheConfig) this;
        }

        
    
        public virtual BuildDerivedDataCacheConfig TargetPlatforms(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-TargetPlatforms",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildDerivedDataCacheConfig) this;
        }

        
    
        public virtual BuildDerivedDataCacheConfig SavedDir(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-SavedDir",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildDerivedDataCacheConfig) this;
        }

        
    
        public virtual BuildDerivedDataCacheConfig BackendName(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-BackendName",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildDerivedDataCacheConfig) this;
        }

        
    
        public virtual BuildDerivedDataCacheConfig RelativePakPath(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-RelativePakPath",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildDerivedDataCacheConfig) this;
        }

        
    
        public virtual BuildDerivedDataCacheConfig SkipEngine(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-SkipEngine",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildDerivedDataCacheConfig) this;
        }
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    }

    protected readonly BuildDerivedDataCacheConfig BuildDerivedDataCacheStorage = new();
        
/// <remarks>WARNING: This command might require Perforce</remarks>
    public  class BuildForUGSConfig : ToolConfig
    {
        public override string Name => "BuildForUGS";
        public override string CliName => "BuildForUGS";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE4;
    
    
        public virtual BuildForUGSConfig Target(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Target",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildForUGSConfig) this;
        }

        
    
        public virtual BuildForUGSConfig Archive(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Archive",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildForUGSConfig) this;
        }

        
    
        public virtual BuildForUGSConfig Stream(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Stream",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildForUGSConfig) this;
        }

        
    
        public virtual BuildForUGSConfig WithUAT(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-WithUAT",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildForUGSConfig) this;
        }

        
    
        public virtual BuildForUGSConfig WithUBT(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-WithUBT",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildForUGSConfig) this;
        }
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    }

    protected readonly BuildForUGSConfig BuildForUGSStorage = new();
        
/// <summary>Builds Hlslcc using CMake build system.</summary>
/// <remarks>WARNING: This command might require Perforce</remarks>
    public  class BuildHlslccConfig : ToolConfig
    {
        public override string Name => "BuildHlslcc";
        public override string CliName => "BuildHlslcc";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE4 | UnrealCompatibility.UE5;
    
/// <summary>Specify a list of target platforms to build, separated by '+' characters (eg. -TargetPlatforms=Win64+Linux+Mac). Architectures are specified with '-'. Default is Win64+Linux.</summary>
        public virtual BuildHlslccConfig TargetPlatforms(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-TargetPlatforms",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildHlslccConfig) this;
        }

        
/// <summary>Specify a list of configurations to build, separated by '+' characters (eg. -TargetConfigs=Debug+RelWithDebInfo). Default is Debug+RelWithDebInfo.</summary>
        public virtual BuildHlslccConfig TargetConfigs(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-TargetConfigs",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildHlslccConfig) this;
        }

        
/// <summary>Specify a list of target compilers to use when building for Windows, separated by '+' characters (eg. -TargetCompilers=VisualStudio2015+VisualStudio2017). Default is VisualStudio2015.
/// Specify a list of target compilers to use when building for Windows, separated by '+' characters (eg. -TargetCompilers=VisualStudio2019+VisualStudio2022). Default is VisualStudio2019.</summary>
        public virtual BuildHlslccConfig TargetWindowsCompilers(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-TargetWindowsCompilers",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildHlslccConfig) this;
        }

        
/// <summary>Do not perform build step. If this argument is not supplied libraries will be built (in accordance with TargetLibs, TargetPlatforms and TargetWindowsCompilers).</summary>
        public virtual BuildHlslccConfig SkipBuild(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-SkipBuild",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildHlslccConfig) this;
        }

        
/// <summary>Do not perform library deployment to the engine. If this argument is not supplied libraries will be copied into the engine.</summary>
        public virtual BuildHlslccConfig SkipDeployLibs(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-SkipDeployLibs",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildHlslccConfig) this;
        }

        
/// <summary>Do not perform source deployment to the engine. If this argument is not supplied source will be copied into the engine.</summary>
        public virtual BuildHlslccConfig SkipDeploySource(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-SkipDeploySource",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildHlslccConfig) this;
        }

        
/// <summary>Do not create a P4 changelist for source or libs. If this argument is not supplied source and libs will be added to a Perforce changelist.</summary>
        public virtual BuildHlslccConfig SkipCreateChangelist(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-SkipCreateChangelist",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildHlslccConfig) this;
        }

        
/// <summary>Do not perform P4 submit of source or libs. If this argument is not supplied source and libs will be automatically submitted to Perforce. If SkipCreateChangelist is specified, this argument applies by default.</summary>
        public virtual BuildHlslccConfig SkipSubmit(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-SkipSubmit",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildHlslccConfig) this;
        }

        
/// <summary>Which robomerge action to apply to the submission. If we're skipping submit, this is not used.</summary>
        public virtual BuildHlslccConfig Robomerge(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Robomerge",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildHlslccConfig) this;
        }

        
    
        public virtual BuildHlslccConfig SkipBuildSolutions(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-SkipBuildSolutions",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildHlslccConfig) this;
        }
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    }

    protected readonly BuildHlslccConfig BuildHlslccStorage = new();
        
    
    public  class BuildPhysX_AndroidConfig : ToolConfig
    {
        public override string Name => "BuildPhysX_Android";
        public override string CliName => "BuildPhysX_Android";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE4 | UnrealCompatibility.UE5;
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    }

    protected readonly BuildPhysX_AndroidConfig BuildPhysX_AndroidStorage = new();
        
    
    public  class BuildPhysX_IOSConfig : ToolConfig
    {
        public override string Name => "BuildPhysX_IOS";
        public override string CliName => "BuildPhysX_IOS";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE4 | UnrealCompatibility.UE5;
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    }

    protected readonly BuildPhysX_IOSConfig BuildPhysX_IOSStorage = new();
        
    
    public  class BuildPhysX_LinuxConfig : ToolConfig
    {
        public override string Name => "BuildPhysX_Linux";
        public override string CliName => "BuildPhysX_Linux";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE4 | UnrealCompatibility.UE5;
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    }

    protected readonly BuildPhysX_LinuxConfig BuildPhysX_LinuxStorage = new();
        
    
    public  class BuildPhysX_Mac_x86_64Config : ToolConfig
    {
        public override string Name => "BuildPhysX_Mac_x86_64";
        public override string CliName => "BuildPhysX_Mac_x86_64";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE4 | UnrealCompatibility.UE5;
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    }

    protected readonly BuildPhysX_Mac_x86_64Config BuildPhysX_Mac_x86_64Storage = new();
        
    
    public  class BuildPhysX_Mac_arm64Config : ToolConfig
    {
        public override string Name => "BuildPhysX_Mac_arm64";
        public override string CliName => "BuildPhysX_Mac_arm64";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE4 | UnrealCompatibility.UE5;
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    }

    protected readonly BuildPhysX_Mac_arm64Config BuildPhysX_Mac_arm64Storage = new();
        
    
    public  class BuildPhysX_MacConfig : ToolConfig
    {
        public override string Name => "BuildPhysX_Mac";
        public override string CliName => "BuildPhysX_Mac";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE4 | UnrealCompatibility.UE5;
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    }

    protected readonly BuildPhysX_MacConfig BuildPhysX_MacStorage = new();
        
    
    public  class BuildPhysX_TVOSConfig : ToolConfig
    {
        public override string Name => "BuildPhysX_TVOS";
        public override string CliName => "BuildPhysX_TVOS";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE4 | UnrealCompatibility.UE5;
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    }

    protected readonly BuildPhysX_TVOSConfig BuildPhysX_TVOSStorage = new();
        
    
    public  class BuildPhysX_Win32Config : ToolConfig
    {
        public override string Name => "BuildPhysX_Win32";
        public override string CliName => "BuildPhysX_Win32";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE4;
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    }

    protected readonly BuildPhysX_Win32Config BuildPhysX_Win32Storage = new();
        
    
    public  class BuildPhysX_Win64Config : ToolConfig
    {
        public override string Name => "BuildPhysX_Win64";
        public override string CliName => "BuildPhysX_Win64";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE4 | UnrealCompatibility.UE5;
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    }

    protected readonly BuildPhysX_Win64Config BuildPhysX_Win64Storage = new();
        
/// <summary>Builds a plugin, and packages it for distribution</summary>
    public  class BuildPluginConfig : ToolConfig
    {
        public override string Name => "BuildPlugin";
        public override string CliName => "BuildPlugin";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE4;
    
/// <summary>Specify the path to the descriptor file for the plugin that should be packaged</summary>
        public virtual BuildPluginConfig Plugin(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Plugin",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildPluginConfig) this;
        }

        
/// <summary>Prevent compiling for the editor platform on the host</summary>
        public virtual BuildPluginConfig NoHostPlatform(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-NoHostPlatform",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildPluginConfig) this;
        }

        
/// <summary>Specify a list of target platforms to build, separated by '+' characters (eg. -TargetPlatforms=Win32+Win64). Default is all the Rocket target platforms.</summary>
        public virtual BuildPluginConfig TargetPlatforms(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-TargetPlatforms",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildPluginConfig) this;
        }

        
/// <summary>The path which the build artifacts should be packaged to, ready for distribution.</summary>
        public virtual BuildPluginConfig Package(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Package",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildPluginConfig) this;
        }

        
/// <summary>Disables precompiled headers and unity build in order to check all source files have self-contained headers.</summary>
        public virtual BuildPluginConfig StrictIncludes(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-StrictIncludes",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildPluginConfig) this;
        }

        
/// <summary>Do not embed the current engine version into the descriptor</summary>
        public virtual BuildPluginConfig Unversioned(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Unversioned",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildPluginConfig) this;
        }

        
    
        public virtual BuildPluginConfig VS2019(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-VS2019",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildPluginConfig) this;
        }

        
    
        public virtual BuildPluginConfig NoDeleteHostProject(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-NoDeleteHostProject",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildPluginConfig) this;
        }

        
    
        public virtual BuildPluginConfig NoTargetPlatforms(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-NoTargetPlatforms",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildPluginConfig) this;
        }
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    }

    protected readonly BuildPluginConfig BuildPluginStorage = new();
        
/// <summary>Builds the editor for the specified project.
/// Example BuildEditor -project=QAGame
/// Note: Editor will only ever build for the current platform in a Development config and required tools will be included</summary>
    public  class BuildEditorConfig : ToolConfig
    {
        public override string Name => "BuildEditor";
        public override string CliName => "BuildEditor";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE4 | UnrealCompatibility.UE5;
    
/// <summary>Project to build. Will search current path and paths in ueprojectdirs. If omitted will build vanilla UE4Editor
/// Project to build. Will search current path and paths in ueprojectdirs. If omitted will build vanilla UnrealEditor</summary>
        public virtual BuildEditorConfig Project(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-project",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildEditorConfig) this;
        }

        
/// <summary>Don't build any tools (UHT, ShaderCompiler, CrashReporter
/// Don't build any tools (UnrealPak, Lightmass, ShaderCompiler, CrashReporter</summary>
        public virtual BuildEditorConfig Notools(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-notools",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildEditorConfig) this;
        }

        
    
        public virtual BuildEditorConfig Open(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-open",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildEditorConfig) this;
        }

        
/// <summary>Platforms to build, join multiple platforms using +
/// Platform to build</summary>
        public virtual BuildEditorConfig Platform(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-platform",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildEditorConfig) this;
        }

        
/// <summary>Configurations to build, join multiple configurations using +</summary>
        public virtual BuildEditorConfig Configuration(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-configuration",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildEditorConfig) this;
        }

        
/// <summary>Targets to build, join multiple targets using +</summary>
        public virtual BuildEditorConfig Target(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-target",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildEditorConfig) this;
        }

        
/// <summary>Do a clean build
/// Whether to clean this target. If not specified, the target will be cleaned if -Clean is on the command line.</summary>
        public virtual BuildEditorConfig Clean(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-clean",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildEditorConfig) this;
        }

        
/// <summary>Toggle to disable the distributed build process</summary>
        public virtual BuildEditorConfig NoXGE(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-NoXGE",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildEditorConfig) this;
        }

        
/// <summary>Toggle to disable the unity build system</summary>
        public virtual BuildEditorConfig DisableUnity(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-DisableUnity",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildEditorConfig) this;
        }

        
/// <summary>
/// Extra UBT args
/// </summary>
        public virtual BuildEditorConfig UBTArgs(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-ubtargs",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildEditorConfig) this;
        }

        
    
        public virtual BuildEditorConfig Preview(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-preview",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildEditorConfig) this;
        }
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    }

    protected readonly BuildEditorConfig BuildEditorStorage = new();
        
/// <summary>Builds the game for the specified project.
/// Example BuildGame -project=QAGame -platform=PS4+XboxOne -configuration=Development.
/// Builds the game for the specified project.
/// Example BuildGame -project=QAGame -platform=Win64+Android -configuration=Development.</summary>
    public  class BuildGameConfig : ToolConfig
    {
        public override string Name => "BuildGame";
        public override string CliName => "BuildGame";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE4 | UnrealCompatibility.UE5;
    
/// <summary>Project to build. Will search current path and paths in ueprojectdirs.
/// Project to build. Will search current path and paths in ueprojectdirs. If omitted will build vanilla UE4Editor
/// Project to build. Will search current path and paths in ueprojectdirs. If omitted will build vanilla UnrealEditor</summary>
        public virtual BuildGameConfig Project(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-project",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildGameConfig) this;
        }

        
/// <summary>Platforms to build, join multiple platforms using +
/// Platform to build</summary>
        public virtual BuildGameConfig Platform(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-platform",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildGameConfig) this;
        }

        
/// <summary>Configurations to build, join multiple configurations using +</summary>
        public virtual BuildGameConfig Configuration(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-configuration",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildGameConfig) this;
        }

        
/// <summary>Don't build any tools (UHT, ShaderCompiler, CrashReporter
/// Don't build any tools (UnrealPak, Lightmass, ShaderCompiler, CrashReporter</summary>
        public virtual BuildGameConfig Notools(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-notools",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildGameConfig) this;
        }

        
/// <summary>Targets to build, join multiple targets using +</summary>
        public virtual BuildGameConfig Target(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-target",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildGameConfig) this;
        }

        
/// <summary>Do a clean build
/// Whether to clean this target. If not specified, the target will be cleaned if -Clean is on the command line.</summary>
        public virtual BuildGameConfig Clean(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-clean",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildGameConfig) this;
        }

        
/// <summary>Toggle to disable the distributed build process</summary>
        public virtual BuildGameConfig NoXGE(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-NoXGE",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildGameConfig) this;
        }

        
/// <summary>Toggle to disable the unity build system</summary>
        public virtual BuildGameConfig DisableUnity(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-DisableUnity",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildGameConfig) this;
        }

        
/// <summary>
/// Extra UBT args
/// </summary>
        public virtual BuildGameConfig UBTArgs(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-ubtargs",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildGameConfig) this;
        }

        
    
        public virtual BuildGameConfig Preview(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-preview",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildGameConfig) this;
        }
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    }

    protected readonly BuildGameConfig BuildGameStorage = new();
        
/// <summary>Builds the server for the specified project.
/// Example BuildServer -project=QAGame -platform=Win64 -configuration=Development.</summary>
    public  class BuildServerConfig : ToolConfig
    {
        public override string Name => "BuildServer";
        public override string CliName => "BuildServer";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE4 | UnrealCompatibility.UE5;
    
/// <summary>Project to build. Will search current path and paths in ueprojectdirs.
/// Project to build. Will search current path and paths in ueprojectdirs. If omitted will build vanilla UE4Editor
/// Project to build. Will search current path and paths in ueprojectdirs. If omitted will build vanilla UnrealEditor</summary>
        public virtual BuildServerConfig Project(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-project",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildServerConfig) this;
        }

        
/// <summary>Platforms to build, join multiple platforms using +
/// Platform to build</summary>
        public virtual BuildServerConfig Platform(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-platform",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildServerConfig) this;
        }

        
/// <summary>Configurations to build, join multiple configurations using +</summary>
        public virtual BuildServerConfig Configuration(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-configuration",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildServerConfig) this;
        }

        
/// <summary>Don't build any tools (UHT, ShaderCompiler, CrashReporter
/// Don't build any tools (UnrealPak, Lightmass, ShaderCompiler, CrashReporter</summary>
        public virtual BuildServerConfig Notools(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-notools",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildServerConfig) this;
        }

        
/// <summary>Targets to build, join multiple targets using +</summary>
        public virtual BuildServerConfig Target(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-target",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildServerConfig) this;
        }

        
/// <summary>Do a clean build
/// Whether to clean this target. If not specified, the target will be cleaned if -Clean is on the command line.</summary>
        public virtual BuildServerConfig Clean(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-clean",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildServerConfig) this;
        }

        
/// <summary>Toggle to disable the distributed build process</summary>
        public virtual BuildServerConfig NoXGE(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-NoXGE",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildServerConfig) this;
        }

        
/// <summary>Toggle to disable the unity build system</summary>
        public virtual BuildServerConfig DisableUnity(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-DisableUnity",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildServerConfig) this;
        }

        
/// <summary>
/// Extra UBT args
/// </summary>
        public virtual BuildServerConfig UBTArgs(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-ubtargs",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildServerConfig) this;
        }

        
    
        public virtual BuildServerConfig Preview(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-preview",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildServerConfig) this;
        }
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    }

    protected readonly BuildServerConfig BuildServerStorage = new();
        
/// <summary>Builds third party libraries, and puts them all into a changelist</summary>
/// <remarks>WARNING: This command might require Perforce</remarks>
    public  class BuildThirdPartyLibsConfig : ToolConfig
    {
        public override string Name => "BuildThirdPartyLibs";
        public override string CliName => "BuildThirdPartyLibs";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE4 | UnrealCompatibility.UE5;
    
/// <summary>[Optional] + separated list of libraries to compile; if not specified this job will build all libraries it can find builder scripts for</summary>
        public virtual BuildThirdPartyLibsConfig Libs(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Libs",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildThirdPartyLibsConfig) this;
        }

        
/// <summary>[Optional] a changelist to check out into; if not specified, a changelist will be created</summary>
        public virtual BuildThirdPartyLibsConfig Changelist(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Changelist",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildThirdPartyLibsConfig) this;
        }

        
/// <summary>[Optional] Directory to search for the specified Libs</summary>
        public virtual BuildThirdPartyLibsConfig SearchDir(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-SearchDir",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BuildThirdPartyLibsConfig) this;
        }
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    }

    protected readonly BuildThirdPartyLibsConfig BuildThirdPartyLibsStorage = new();
        
/// <summary>Checks that all source files have balanced macros for enabling/disabling optimization, warnings, etc...</summary>
    public  class CheckBalancedMacrosConfig : ToolConfig
    {
        public override string Name => "CheckBalancedMacros";
        public override string CliName => "CheckBalancedMacros";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE4 | UnrealCompatibility.UE5;
    
/// <summary>Path to an additional project file to consider</summary>
        public virtual CheckBalancedMacrosConfig Project(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Project",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (CheckBalancedMacrosConfig) this;
        }

        
/// <summary>Path to a file to parse in isolation, for testing</summary>
        public virtual CheckBalancedMacrosConfig File(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-File",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (CheckBalancedMacrosConfig) this;
        }

        
/// <summary>File name (without path) to exclude from testing</summary>
        public virtual CheckBalancedMacrosConfig Ignore(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Ignore",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (CheckBalancedMacrosConfig) this;
        }
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    }

    protected readonly CheckBalancedMacrosConfig CheckBalancedMacrosStorage = new();
        
    
    public  class CheckCsprojDotNetVersionConfig : ToolConfig
    {
        public override string Name => "CheckCsprojDotNetVersion";
        public override string CliName => "CheckCsprojDotNetVersion";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE4 | UnrealCompatibility.UE5;
    
    
        public virtual CheckCsprojDotNetVersionConfig TargetVersion(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-TargetVersion",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (CheckCsprojDotNetVersionConfig) this;
        }
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    }

    protected readonly CheckCsprojDotNetVersionConfig CheckCsprojDotNetVersionStorage = new();
        
/// <summary>Audits the current branch for comments denoting a hack that was not meant to leave another branch, following a given format ("BEGIN XXXX HACK", where XXXX is one or more tags separated by spaces).
/// Allowed tags may be specified manually on the command line. At least one must match, otherwise it will print a warning.
/// The current branch name and fragments of the branch path will also be added by default, so running from //UE4/Main will add "//UE4/Main", "UE4", and "Main".
/// Audits the current branch for comments denoting a hack that was not meant to leave another branch, following a given format ("BEGIN XXXX HACK", where XXXX is one or more tags separated by spaces).
/// Allowed tags may be specified manually on the command line. At least one must match, otherwise it will print a warning.
/// The current branch name and fragments of the branch path will also be added by default, so running from //UE5/Main will add "//UE5/Main", "UE5", and "Main".</summary>
    public  class CheckForHacksConfig : ToolConfig
    {
        public override string Name => "CheckForHacks";
        public override string CliName => "CheckForHacks";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE4 | UnrealCompatibility.UE5;
    
/// <summary>Specifies additional tags which are allowed in the BEGIN ... HACK tag list</summary>
        public virtual CheckForHacksConfig Allow(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Allow",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (CheckForHacksConfig) this;
        }
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    }

    protected readonly CheckForHacksConfig CheckForHacksStorage = new();
        
/// <summary>Checks that the casing of files within a path on a case-insensitive Perforce server is correct.</summary>
/// <remarks>WARNING: This command might require Perforce</remarks>
    public  class CheckPerforceCaseConfig : ToolConfig
    {
        public override string Name => "CheckPerforceCase";
        public override string CliName => "CheckPerforceCase";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE4 | UnrealCompatibility.UE5;
    
/// <summary>The path to query</summary>
        public virtual CheckPerforceCaseConfig Path(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Path",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (CheckPerforceCaseConfig) this;
        }
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    }

    protected readonly CheckPerforceCaseConfig CheckPerforceCaseStorage = new();
        
/// <summary>Checks a directory for folders which should not be distributed</summary>
    public  class CheckRestrictedFoldersConfig : ToolConfig
    {
        public override string Name => "CheckRestrictedFolders";
        public override string CliName => "CheckRestrictedFolders";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE4 | UnrealCompatibility.UE5;
    
/// <summary>Path to the base directory containing files to check</summary>
        public virtual CheckRestrictedFoldersConfig BaseDir(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-BaseDir",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (CheckRestrictedFoldersConfig) this;
        }

        
/// <summary>Specify names of folders which should be excluded from the list</summary>
        public virtual CheckRestrictedFoldersConfig Allow(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Allow",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (CheckRestrictedFoldersConfig) this;
        }
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    }

    protected readonly CheckRestrictedFoldersConfig CheckRestrictedFoldersStorage = new();
        
/// <summary>Checks that the given target exists, by looking for the relevant receipt.</summary>
    public  class CheckTargetExistsConfig : ToolConfig
    {
        public override string Name => "CheckTargetExists";
        public override string CliName => "CheckTargetExists";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE4 | UnrealCompatibility.UE5;
    
/// <summary>Name of the target to check</summary>
        public virtual CheckTargetExistsConfig Target(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Target",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (CheckTargetExistsConfig) this;
        }

        
/// <summary>Platform the target was built for</summary>
        public virtual CheckTargetExistsConfig Platform(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Platform",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (CheckTargetExistsConfig) this;
        }

        
/// <summary>Configuration for the target</summary>
        public virtual CheckTargetExistsConfig Configuration(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Configuration",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (CheckTargetExistsConfig) this;
        }

        
/// <summary>Architecture that the target was built for</summary>
        public virtual CheckTargetExistsConfig Architecture(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Architecture",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (CheckTargetExistsConfig) this;
        }

        
/// <summary>Path to the project containing the target</summary>
        public virtual CheckTargetExistsConfig Project(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Project",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (CheckTargetExistsConfig) this;
        }
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    }

    protected readonly CheckTargetExistsConfig CheckTargetExistsStorage = new();
        
/// <summary>Checks that the installed Xcode version is the version specified.</summary>
    public  class CheckXcodeVersionConfig : ToolConfig
    {
        public override string Name => "CheckXcodeVersion";
        public override string CliName => "CheckXcodeVersion";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE4 | UnrealCompatibility.UE5;
    
/// <summary>The expected version number</summary>
        public virtual CheckXcodeVersionConfig Version(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Version",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (CheckXcodeVersionConfig) this;
        }
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    }

    protected readonly CheckXcodeVersionConfig CheckXcodeVersionStorage = new();
        
/// <summary>Removes folders in an automation report directory that are older than a certain time.</summary>
    public  class CleanAutomationReportsConfig : ToolConfig
    {
        public override string Name => "CleanAutomationReports";
        public override string CliName => "CleanAutomationReports";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE4 | UnrealCompatibility.UE5;
    
/// <summary>Path to the root report directory</summary>
        public virtual CleanAutomationReportsConfig ReportDir(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-ReportDir",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (CleanAutomationReportsConfig) this;
        }

        
/// <summary>Number of days to keep reports for</summary>
        public virtual CleanAutomationReportsConfig Days(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Days",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (CleanAutomationReportsConfig) this;
        }

        
/// <summary>How many subdirectories deep to clean, defaults to 0 (top level cleaning).</summary>
        public virtual CleanAutomationReportsConfig Depth(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Depth",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (CleanAutomationReportsConfig) this;
        }
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    }

    protected readonly CleanAutomationReportsConfig CleanAutomationReportsStorage = new();
        
/// <summary>Removes folders matching a pattern in a given directory that are older than a certain time.</summary>
    public  class CleanFormalBuildsConfig : ToolConfig
    {
        public override string Name => "CleanFormalBuilds";
        public override string CliName => "CleanFormalBuilds";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE4 | UnrealCompatibility.UE5;
    
/// <summary>Path to the root directory</summary>
        public virtual CleanFormalBuildsConfig ParentDir(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-ParentDir",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (CleanFormalBuildsConfig) this;
        }

        
/// <summary>Pattern to match against</summary>
        public virtual CleanFormalBuildsConfig SearchPattern(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-SearchPattern",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (CleanFormalBuildsConfig) this;
        }

        
/// <summary>Number of days to keep in temp storage (optional - defaults to 4)</summary>
        public virtual CleanFormalBuildsConfig Days(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Days",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (CleanFormalBuildsConfig) this;
        }
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    }

    protected readonly CleanFormalBuildsConfig CleanFormalBuildsStorage = new();
        
/// <summary>custom code to restructure C++ source code for the new stats system.</summary>
    public  class CodeSurgeryConfig : ToolConfig
    {
        public override string Name => "CodeSurgery";
        public override string CliName => "CodeSurgery";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE4;
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    }

    protected readonly CodeSurgeryConfig CodeSurgeryStorage = new();
        
/// <summary>Copies the current shared cooked build from the network to the local PC</summary>
/// <remarks>WARNING: This command might require Perforce</remarks>
    public  class CopySharedCookedBuildConfig : ToolConfig
    {
        public override string Name => "CopySharedCookedBuild";
        public override string CliName => "CopySharedCookedBuild";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE4 | UnrealCompatibility.UE5;
    
    
        public virtual CopySharedCookedBuildConfig Project(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-project",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (CopySharedCookedBuildConfig) this;
        }

        
    
        public virtual CopySharedCookedBuildConfig Platform(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Platform",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (CopySharedCookedBuildConfig) this;
        }

        
    
        public virtual CopySharedCookedBuildConfig Onlycopyassetregistry(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-onlycopyassetregistry",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (CopySharedCookedBuildConfig) this;
        }

        
    
        public virtual CopySharedCookedBuildConfig Buildcl(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-buildcl",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (CopySharedCookedBuildConfig) this;
        }
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    }

    protected readonly CopySharedCookedBuildConfig CopySharedCookedBuildStorage = new();
        
    
    public  class CopyUATConfig : ToolConfig
    {
        public override string Name => "CopyUAT";
        public override string CliName => "CopyUAT";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE4 | UnrealCompatibility.UE5;
    
    
        public virtual CopyUATConfig TargetDir(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-TargetDir",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (CopyUATConfig) this;
        }

        
    
        public virtual CopyUATConfig WithLauncher(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-WithLauncher",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4,
                        AllowMultiple: true
                    )
                ));
            }
            return (CopyUATConfig) this;
        }
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    }

    protected readonly CopyUATConfig CopyUATStorage = new();
        
    
    public  class CryptoKeysConfig : ToolConfig
    {
        public override string Name => "CryptoKeys";
        public override string CliName => "CryptoKeys";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE4 | UnrealCompatibility.UE5;
    
    
        public virtual CryptoKeysConfig Updateallkeys(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-updateallkeys",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (CryptoKeysConfig) this;
        }

        
    
        public virtual CryptoKeysConfig Updateencryptionkey(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-updateencryptionkey",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (CryptoKeysConfig) this;
        }

        
    
        public virtual CryptoKeysConfig Updatesigningkey(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-updatesigningkey",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (CryptoKeysConfig) this;
        }

        
    
        public virtual CryptoKeysConfig Foreign(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-foreign",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4,
                        AllowMultiple: true
                    )
                ));
            }
            return (CryptoKeysConfig) this;
        }

        
    
        public virtual CryptoKeysConfig Foreigncode(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-foreigncode",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4,
                        AllowMultiple: true
                    )
                ));
            }
            return (CryptoKeysConfig) this;
        }

        
    
        public virtual CryptoKeysConfig DestSample(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-DestSample",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4,
                        AllowMultiple: true
                    )
                ));
            }
            return (CryptoKeysConfig) this;
        }

        
    
        public virtual CryptoKeysConfig ForeignDest(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-ForeignDest",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4,
                        AllowMultiple: true
                    )
                ));
            }
            return (CryptoKeysConfig) this;
        }

        
    
        public virtual CryptoKeysConfig Project(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-project",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4,
                        AllowMultiple: true
                    )
                ));
            }
            return (CryptoKeysConfig) this;
        }
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    }

    protected readonly CryptoKeysConfig CryptoKeysStorage = new();
        
    
    public  class ExtractPaksConfig : ToolConfig
    {
        public override string Name => "ExtractPaks";
        public override string CliName => "ExtractPaks";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE4 | UnrealCompatibility.UE5;
    
    
        public virtual ExtractPaksConfig Layered(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-layered",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (ExtractPaksConfig) this;
        }

        
    
        public virtual ExtractPaksConfig Sourcedirectory(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-sourcedirectory",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (ExtractPaksConfig) this;
        }

        
    
        public virtual ExtractPaksConfig Targetdirectory(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-targetdirectory",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (ExtractPaksConfig) this;
        }

        
    
        public virtual ExtractPaksConfig Cryptokeysjson(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-cryptokeysjson",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (ExtractPaksConfig) this;
        }

        
    
        public virtual ExtractPaksConfig Customcompressor(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-customcompressor",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (ExtractPaksConfig) this;
        }

        
    
        public virtual ExtractPaksConfig Project(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-project",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (ExtractPaksConfig) this;
        }
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    }

    protected readonly ExtractPaksConfig ExtractPaksStorage = new();
        
/// <summary>Command to perform additional steps to prepare an installed build.</summary>
    public  class FinalizeInstalledBuildConfig : ToolConfig
    {
        public override string Name => "FinalizeInstalledBuild";
        public override string CliName => "FinalizeInstalledBuild";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE4 | UnrealCompatibility.UE5;
    
/// <summary>Root Directory of the installed build data (required)</summary>
        public virtual FinalizeInstalledBuildConfig OutputDir(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-OutputDir",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (FinalizeInstalledBuildConfig) this;
        }

        
/// <summary>List of platforms that should be marked as only supporting content projects (optional)</summary>
        public virtual FinalizeInstalledBuildConfig ContentOnlyPlatforms(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-ContentOnlyPlatforms",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (FinalizeInstalledBuildConfig) this;
        }

        
/// <summary>List of platforms to add</summary>
        public virtual FinalizeInstalledBuildConfig Platforms(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Platforms",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (FinalizeInstalledBuildConfig) this;
        }

        
/// <summary>List of architectures that are used for a given platform (optional)
/// List of GPU architectures that are used for a given platform (optional)</summary>
        public virtual FinalizeInstalledBuildConfig Platform(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Platform",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (FinalizeInstalledBuildConfig) this;
        }

        
/// <summary>Name to give this build for analytics purposes (optional)</summary>
        public virtual FinalizeInstalledBuildConfig AnalyticsTypeOverride(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-AnalyticsTypeOverride",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (FinalizeInstalledBuildConfig) this;
        }

        
    
        public virtual FinalizeInstalledBuildConfig Project(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Project",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (FinalizeInstalledBuildConfig) this;
        }

        
    
        public virtual FinalizeInstalledBuildConfig Architectures(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Architectures",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (FinalizeInstalledBuildConfig) this;
        }

        
    
        public virtual FinalizeInstalledBuildConfig GPUArchitectures(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-GPUArchitectures",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (FinalizeInstalledBuildConfig) this;
        }
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    }

    protected readonly FinalizeInstalledBuildConfig FinalizeInstalledBuildStorage = new();
        
/// <summary>Fixes the case of files on a case-insensitive Perforce server by removing and re-adding them.</summary>
/// <remarks>WARNING: This command might require Perforce</remarks>
    public  class FixPerforceCaseConfig : ToolConfig
    {
        public override string Name => "FixPerforceCase";
        public override string CliName => "FixPerforceCase";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE4 | UnrealCompatibility.UE5;
    
/// <summary>Pattern for source files to match. Should be a full depot path. May end with a wildcard.</summary>
        public virtual FixPerforceCaseConfig Source(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Source",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4,
                        AllowMultiple: true
                    )
                ));
            }
            return (FixPerforceCaseConfig) this;
        }

        
/// <summary>Pattern for target files. Should be identical to source, except for case.</summary>
        public virtual FixPerforceCaseConfig Target(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Target",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4,
                        AllowMultiple: true
                    )
                ));
            }
            return (FixPerforceCaseConfig) this;
        }

        
/// <summary>Pattern for files to match. Should be a full depot path with the correct case. May end with a wildcard.</summary>
        public virtual FixPerforceCaseConfig Files(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Files",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (FixPerforceCaseConfig) this;
        }
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    }

    protected readonly FixPerforceCaseConfig FixPerforceCaseStorage = new();
        
    
    public  class FixupRedirectsConfig : ToolConfig
    {
        public override string Name => "FixupRedirects";
        public override string CliName => "FixupRedirects";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE4 | UnrealCompatibility.UE5;
    
    
        public virtual FixupRedirectsConfig Project(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-project",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (FixupRedirectsConfig) this;
        }
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    }

    protected readonly FixupRedirectsConfig FixupRedirectsStorage = new();
        
/// <summary>Generates IOS debug symbols for a remote project.</summary>
    public  class GenerateDSYMConfig : ToolConfig
    {
        public override string Name => "GenerateDSYM";
        public override string CliName => "GenerateDSYM";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE4 | UnrealCompatibility.UE5;
    
/// <summary>Project name (required), i.e: -project=QAGame</summary>
        public virtual GenerateDSYMConfig Project(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-project",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (GenerateDSYMConfig) this;
        }

        
/// <summary>Project configuration (required), i.e: -config=Development</summary>
        public virtual GenerateDSYMConfig Config(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-config",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (GenerateDSYMConfig) this;
        }

        
    
        public virtual GenerateDSYMConfig Flat(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-flat",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (GenerateDSYMConfig) this;
        }

        
    
        public virtual GenerateDSYMConfig File_(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-file=",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (GenerateDSYMConfig) this;
        }

        
    
        public virtual GenerateDSYMConfig Platform(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-platform",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (GenerateDSYMConfig) this;
        }
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    }

    protected readonly GenerateDSYMConfig GenerateDSYMStorage = new();
        
/// <summary>UAT command to call into the integrated IPhonePackager code</summary>
    public  class IPhonePackagerConfig : ToolConfig
    {
        public override string Name => "IPhonePackager";
        public override string CliName => "IPhonePackager";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE4 | UnrealCompatibility.UE5;
    
    
        public virtual IPhonePackagerConfig Cmd(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-cmd",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (IPhonePackagerConfig) this;
        }
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    }

    protected readonly IPhonePackagerConfig IPhonePackagerStorage = new();
        
    
    public  class LauncherLocalizationConfig : ToolConfig
    {
        public override string Name => "LauncherLocalization";
        public override string CliName => "LauncherLocalization";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE4;
    
    
        public virtual LauncherLocalizationConfig BuildEditor(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-BuildEditor",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4,
                        AllowMultiple: true
                    )
                ));
            }
            return (LauncherLocalizationConfig) this;
        }
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    }

    protected readonly LauncherLocalizationConfig LauncherLocalizationStorage = new();
        
    
    public  class ListMobileDevicesConfig : ToolConfig
    {
        public override string Name => "ListMobileDevices";
        public override string CliName => "ListMobileDevices";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE4 | UnrealCompatibility.UE5;
    
    
        public virtual ListMobileDevicesConfig Android(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-android",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (ListMobileDevicesConfig) this;
        }

        
    
        public virtual ListMobileDevicesConfig Ios(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-ios",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (ListMobileDevicesConfig) this;
        }
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    }

    protected readonly ListMobileDevicesConfig ListMobileDevicesStorage = new();
        
/// <summary>Lists TPS files associated with any source used to build a specified target(s). Grabs TPS files associated with source modules, content, and engine shaders.</summary>
    public  class ListThirdPartySoftwareConfig : ToolConfig
    {
        public override string Name => "ListThirdPartySoftware";
        public override string CliName => "ListThirdPartySoftware";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE4 | UnrealCompatibility.UE5;
    
/// <summary>One or more UBT command lines to enumerate associated TPS files for (eg. UE4Game Win64 Development).
/// One or more UBT command lines to enumerate associated TPS files for (eg. UnrealGame Win64 Development).</summary>
        public virtual ListThirdPartySoftwareConfig Target(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Target",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (ListThirdPartySoftwareConfig) this;
        }

        
    
        public virtual ListThirdPartySoftwareConfig Project(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Project",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (ListThirdPartySoftwareConfig) this;
        }
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    }

    protected readonly ListThirdPartySoftwareConfig ListThirdPartySoftwareStorage = new();
        
/// <summary>Updates the external localization data using the arguments provided.</summary>
    public  class LocalizeConfig : ToolConfig
    {
        public override string Name => "Localize";
        public override string CliName => "Localize";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE4 | UnrealCompatibility.UE5;
    
/// <summary>Optional root-path to the project we're gathering for (defaults to CmdEnv.LocalRoot if unset).</summary>
        public virtual LocalizeConfig UEProjectRoot(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-UEProjectRoot",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (LocalizeConfig) this;
        }

        
/// <summary>Sub-path to the project we're gathering for (relative to UEProjectRoot).</summary>
        public virtual LocalizeConfig UEProjectDirectory(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-UEProjectDirectory",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (LocalizeConfig) this;
        }

        
/// <summary>Optional name of the project we're gathering for (should match its .uproject file, eg QAGame).</summary>
        public virtual LocalizeConfig UEProjectName(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-UEProjectName",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (LocalizeConfig) this;
        }

        
/// <summary>Comma separated list of the projects to gather text from.</summary>
        public virtual LocalizeConfig LocalizationProjectNames(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-LocalizationProjectNames",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (LocalizeConfig) this;
        }

        
/// <summary>Optional suffix to use when uploading the new data to the localization provider.</summary>
        public virtual LocalizeConfig LocalizationBranch(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-LocalizationBranch",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (LocalizeConfig) this;
        }

        
/// <summary>Optional localization provide override.</summary>
        public virtual LocalizeConfig LocalizationProvider(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-LocalizationProvider",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (LocalizeConfig) this;
        }

        
/// <summary>Optional comma separated list of localization steps to perform [Download, Gather, Import, Export, Compile, GenerateReports, Upload] (default is all). Only valid for projects using a modular config.</summary>
        public virtual LocalizeConfig LocalizationSteps(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-LocalizationSteps",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (LocalizeConfig) this;
        }

        
/// <summary>Optional flag to include plugins from within the given UEProjectDirectory as part of the gather. This may optionally specify a comma separated list of the specific plugins to gather (otherwise all plugins will be gathered).</summary>
        public virtual LocalizeConfig IncludePlugins(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-IncludePlugins",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (LocalizeConfig) this;
        }

        
/// <summary>Optional comma separated list of plugins to exclude from the gather.</summary>
        public virtual LocalizeConfig ExcludePlugins(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-ExcludePlugins",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (LocalizeConfig) this;
        }

        
/// <summary>Optional flag to include platforms from within the given UEProjectDirectory as part of the gather.</summary>
        public virtual LocalizeConfig IncludePlatforms(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-IncludePlatforms",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (LocalizeConfig) this;
        }

        
/// <summary>Optional arguments to pass to the gather process.</summary>
        public virtual LocalizeConfig AdditionalCommandletArguments(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-AdditionalCommandletArguments",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (LocalizeConfig) this;
        }

        
/// <summary>Run the gather processes for a single batch in parallel rather than sequence.</summary>
        public virtual LocalizeConfig ParallelGather(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-ParallelGather",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (LocalizeConfig) this;
        }

        
/// <summary>Run the localization command in preview mode. This passes the -Preview flag along to all commandlets as an additional argument and deletes all temporary files generated by the commandlets in preview mode. Primarily used for build farm automation where localization warnings from localization gathers can be previewed without checking out any files under SCC.</summary>
        public virtual LocalizeConfig Preview(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Preview",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (LocalizeConfig) this;
        }
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    }

    protected readonly LocalizeConfig LocalizeStorage = new();
        
    
    public  class ExportMcpTemplatesConfig : ToolConfig
    {
        public override string Name => "ExportMcpTemplates";
        public override string CliName => "ExportMcpTemplates";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE4 | UnrealCompatibility.UE5;
    
/// <summary>Optional.  Only submit generated loc files, do not submit any other generated file.</summary>
        public virtual ExportMcpTemplatesConfig OnlyLoc(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-OnlyLoc",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (ExportMcpTemplatesConfig) this;
        }

        
/// <summary>Optional.  Do not include the markup in the CL description to allow robomerging to other branches.</summary>
        public virtual ExportMcpTemplatesConfig NoRobomerge(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-NoRobomerge",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (ExportMcpTemplatesConfig) this;
        }

        
    
        public virtual ExportMcpTemplatesConfig ProjectName(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-ProjectName",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (ExportMcpTemplatesConfig) this;
        }

        
    
        public virtual ExportMcpTemplatesConfig Commandlet(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Commandlet",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (ExportMcpTemplatesConfig) this;
        }
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    }

    protected readonly ExportMcpTemplatesConfig ExportMcpTemplatesStorage = new();
        
    
    public  class LocaliseConfig : ToolConfig
    {
        public override string Name => "Localise";
        public override string CliName => "Localise";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE4 | UnrealCompatibility.UE5;
    
/// <summary>Optional root-path to the project we're gathering for (defaults to CmdEnv.LocalRoot if unset).</summary>
        public virtual LocaliseConfig UEProjectRoot(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-UEProjectRoot",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (LocaliseConfig) this;
        }

        
/// <summary>Sub-path to the project we're gathering for (relative to UEProjectRoot).</summary>
        public virtual LocaliseConfig UEProjectDirectory(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-UEProjectDirectory",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (LocaliseConfig) this;
        }

        
/// <summary>Optional name of the project we're gathering for (should match its .uproject file, eg QAGame).</summary>
        public virtual LocaliseConfig UEProjectName(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-UEProjectName",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (LocaliseConfig) this;
        }

        
/// <summary>Comma separated list of the projects to gather text from.</summary>
        public virtual LocaliseConfig LocalizationProjectNames(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-LocalizationProjectNames",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (LocaliseConfig) this;
        }

        
/// <summary>Optional suffix to use when uploading the new data to the localization provider.</summary>
        public virtual LocaliseConfig LocalizationBranch(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-LocalizationBranch",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (LocaliseConfig) this;
        }

        
/// <summary>Optional localization provide override.</summary>
        public virtual LocaliseConfig LocalizationProvider(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-LocalizationProvider",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (LocaliseConfig) this;
        }

        
/// <summary>Optional comma separated list of localization steps to perform [Download, Gather, Import, Export, Compile, GenerateReports, Upload] (default is all). Only valid for projects using a modular config.</summary>
        public virtual LocaliseConfig LocalizationSteps(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-LocalizationSteps",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (LocaliseConfig) this;
        }

        
/// <summary>Optional flag to include plugins from within the given UEProjectDirectory as part of the gather. This may optionally specify a comma separated list of the specific plugins to gather (otherwise all plugins will be gathered).</summary>
        public virtual LocaliseConfig IncludePlugins(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-IncludePlugins",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (LocaliseConfig) this;
        }

        
/// <summary>Optional comma separated list of plugins to exclude from the gather.</summary>
        public virtual LocaliseConfig ExcludePlugins(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-ExcludePlugins",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (LocaliseConfig) this;
        }

        
/// <summary>Optional flag to include platforms from within the given UEProjectDirectory as part of the gather.</summary>
        public virtual LocaliseConfig IncludePlatforms(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-IncludePlatforms",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (LocaliseConfig) this;
        }

        
/// <summary>Optional arguments to pass to the gather process.</summary>
        public virtual LocaliseConfig AdditionalCommandletArguments(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-AdditionalCommandletArguments",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (LocaliseConfig) this;
        }

        
/// <summary>Run the gather processes for a single batch in parallel rather than sequence.</summary>
        public virtual LocaliseConfig ParallelGather(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-ParallelGather",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (LocaliseConfig) this;
        }

        
/// <summary>Run the localization command in preview mode. This passes the -Preview flag along to all commandlets as an additional argument and deletes all temporary files generated by the commandlets in preview mode. Primarily used for build farm automation where localization warnings from localization gathers can be previewed without checking out any files under SCC.</summary>
        public virtual LocaliseConfig Preview(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Preview",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (LocaliseConfig) this;
        }
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    }

    protected readonly LocaliseConfig LocaliseStorage = new();
        
/// <summary>Opens the specified project.</summary>
    public  class OpenEditorConfig : ToolConfig
    {
        public override string Name => "OpenEditor";
        public override string CliName => "OpenEditor";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE4 | UnrealCompatibility.UE5;
    
/// <summary>Project to open. Will search current path and paths in ueprojectdirs. If omitted will open vanilla UE4Editor
/// Project to open. Will search current path and paths in ueprojectdirs. If omitted will open vanilla UnrealEditor</summary>
        public virtual OpenEditorConfig Project(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-project",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (OpenEditorConfig) this;
        }
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    }

    protected readonly OpenEditorConfig OpenEditorStorage = new();
        
/// <summary>Parses Visual C++ timing information (as generated by UBT with the -Timing flag), and converts it into JSON format which can be visualized using the chrome://tracing tab</summary>
    public  class ParseMsvcTimingInfoConfig : ToolConfig
    {
        public override string Name => "ParseMsvcTimingInfo";
        public override string CliName => "ParseMsvcTimingInfo";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE4 | UnrealCompatibility.UE5;
    
/// <summary>Path to the input file</summary>
        public virtual ParseMsvcTimingInfoConfig File(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-File",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (ParseMsvcTimingInfoConfig) this;
        }
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    }

    protected readonly ParseMsvcTimingInfoConfig ParseMsvcTimingInfoStorage = new();
        
/// <summary>Rewrites include directives for headers in public include paths to make them relative to the 'Public' folder.</summary>
    public  class RebasePublicIncludePathsConfig : ToolConfig
    {
        public override string Name => "RebasePublicIncludePaths";
        public override string CliName => "RebasePublicIncludePaths";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE4;
    
/// <summary>Specifies a project to include in the scan for source files. May be specified multiple times.</summary>
        public virtual RebasePublicIncludePathsConfig Project(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Project",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4,
                        AllowMultiple: true
                    )
                ));
            }
            return (RebasePublicIncludePathsConfig) this;
        }

        
/// <summary>Specifies the directory containing files to update. This may be a project/engine directory, or a subfolder.</summary>
        public virtual RebasePublicIncludePathsConfig UpdateDir(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-UpdateDir",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4,
                        AllowMultiple: true
                    )
                ));
            }
            return (RebasePublicIncludePathsConfig) this;
        }

        
/// <summary>If set, causes the modified files to be written. Files will be checked out from Perforce if possible.</summary>
        public virtual RebasePublicIncludePathsConfig Write(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Write",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4,
                        AllowMultiple: true
                    )
                ));
            }
            return (RebasePublicIncludePathsConfig) this;
        }
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    }

    protected readonly RebasePublicIncludePathsConfig RebasePublicIncludePathsStorage = new();
        
/// <remarks>WARNING: This command might require Perforce</remarks>
    public  class RebuildHLODConfig : ToolConfig
    {
        public override string Name => "RebuildHLOD";
        public override string CliName => "RebuildHLOD";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE4 | UnrealCompatibility.UE5;
    
    
        public virtual RebuildHLODConfig DelaySubmission(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-DelaySubmission",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (RebuildHLODConfig) this;
        }

        
    
        public virtual RebuildHLODConfig Nobuild(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-nobuild",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (RebuildHLODConfig) this;
        }

        
    
        public virtual RebuildHLODConfig BuildOptions(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-BuildOptions",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (RebuildHLODConfig) this;
        }

        
    
        public virtual RebuildHLODConfig StakeholdersEmailAddresses(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-StakeholdersEmailAddresses",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (RebuildHLODConfig) this;
        }

        
    
        public virtual RebuildHLODConfig Robomerge(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Robomerge",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (RebuildHLODConfig) this;
        }

        
    
        public virtual RebuildHLODConfig CommandletTargetName(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-CommandletTargetName",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (RebuildHLODConfig) this;
        }

        
    
        public virtual RebuildHLODConfig Project(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-project",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (RebuildHLODConfig) this;
        }
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    }

    protected readonly RebuildHLODConfig RebuildHLODStorage = new();
        
/// <summary>Helper command used for rebuilding a projects light maps</summary>
/// <remarks>WARNING: This command might require Perforce</remarks>
    public  class RebuildLightMapsConfig : ToolConfig
    {
        public override string Name => "RebuildLightMaps";
        public override string CliName => "RebuildLightMaps";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE4 | UnrealCompatibility.UE5;
    
/// <summary>Absolute path to a .uproject file</summary>
        public virtual RebuildLightMapsConfig Project(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Project",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (RebuildLightMapsConfig) this;
        }

        
/// <summary>A list of '+' delimited maps we wish to build lightmaps for.</summary>
        public virtual RebuildLightMapsConfig MapsToRebuildLightMaps(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-MapsToRebuildLightMaps",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (RebuildLightMapsConfig) this;
        }

        
/// <summary>The Target used in running the commandlet</summary>
        public virtual RebuildLightMapsConfig CommandletTargetName(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-CommandletTargetName",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (RebuildLightMapsConfig) this;
        }

        
/// <summary>Users to notify of completion</summary>
        public virtual RebuildLightMapsConfig StakeholdersEmailAddresses(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-StakeholdersEmailAddresses",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (RebuildLightMapsConfig) this;
        }

        
    
        public virtual RebuildLightMapsConfig Nobuild(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-nobuild",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (RebuildLightMapsConfig) this;
        }
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    }

    protected readonly RebuildLightMapsConfig RebuildLightMapsStorage = new();
        
/// <summary>UAT command to run performance test demo using different RHIs and compare results</summary>
    public  class RecordPerformanceConfig : ToolConfig
    {
        public override string Name => "RecordPerformance";
        public override string CliName => "RecordPerformance";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE4 | UnrealCompatibility.UE5;
    
    
        public virtual RecordPerformanceConfig DemoIndex(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-DemoIndex",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (RecordPerformanceConfig) this;
        }

        
    
        public virtual RecordPerformanceConfig NumOfRuns(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-NumOfRuns",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (RecordPerformanceConfig) this;
        }

        
    
        public virtual RecordPerformanceConfig SkipBuild(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-SkipBuild",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (RecordPerformanceConfig) this;
        }
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    }

    protected readonly RecordPerformanceConfig RecordPerformanceStorage = new();
        
    
    public  class ReplaceAssetsUsingManifestConfig : ToolConfig
    {
        public override string Name => "ReplaceAssetsUsingManifest";
        public override string CliName => "ReplaceAssetsUsingManifest";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE4 | UnrealCompatibility.UE5;
    
    
        public virtual ReplaceAssetsUsingManifestConfig ProjectPath(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-ProjectPath",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (ReplaceAssetsUsingManifestConfig) this;
        }

        
    
        public virtual ReplaceAssetsUsingManifestConfig ManifestFile(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-ManifestFile",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (ReplaceAssetsUsingManifestConfig) this;
        }

        
    
        public virtual ReplaceAssetsUsingManifestConfig UnrealExe(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-UE4Exe",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (ReplaceAssetsUsingManifestConfig) this;
        }

        
    
        public virtual ReplaceAssetsUsingManifestConfig ReplacedPaths(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-ReplacedPaths",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (ReplaceAssetsUsingManifestConfig) this;
        }

        
    
        public virtual ReplaceAssetsUsingManifestConfig ReplacedClasses(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-ReplacedClasses",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (ReplaceAssetsUsingManifestConfig) this;
        }

        
    
        public virtual ReplaceAssetsUsingManifestConfig ExcludedPaths(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-ExcludedPaths",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (ReplaceAssetsUsingManifestConfig) this;
        }

        
    
        public virtual ReplaceAssetsUsingManifestConfig ExcludedClasses(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-ExcludedClasses",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (ReplaceAssetsUsingManifestConfig) this;
        }

        
    
        public virtual ReplaceAssetsUsingManifestConfig BaseDir(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-BaseDir",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (ReplaceAssetsUsingManifestConfig) this;
        }

        
    
        public virtual ReplaceAssetsUsingManifestConfig AssetSourcePath(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-AssetSourcePath",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (ReplaceAssetsUsingManifestConfig) this;
        }

        
    
        public virtual ReplaceAssetsUsingManifestConfig UseExistingManifest(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-UseExistingManifest",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (ReplaceAssetsUsingManifestConfig) this;
        }
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    }

    protected readonly ReplaceAssetsUsingManifestConfig ReplaceAssetsUsingManifestStorage = new();
        
/// <remarks>WARNING: This command might require Perforce</remarks>
    public  class ResavePackagesConfig : ToolConfig
    {
        public override string Name => "ResavePackages";
        public override string CliName => "ResavePackages";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE4 | UnrealCompatibility.UE5;
    
    
        public virtual ResavePackagesConfig Nobuild(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-nobuild",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (ResavePackagesConfig) this;
        }

        
    
        public virtual ResavePackagesConfig StakeholdersEmailAddresses(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-StakeholdersEmailAddresses",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (ResavePackagesConfig) this;
        }

        
    
        public virtual ResavePackagesConfig CommandletTargetName(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-CommandletTargetName",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (ResavePackagesConfig) this;
        }

        
    
        public virtual ResavePackagesConfig Project(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-project",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (ResavePackagesConfig) this;
        }
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    }

    protected readonly ResavePackagesConfig ResavePackagesStorage = new();
        
/// <summary>Re-save all the plugin descriptors under a given path, optionally applying standard metadata to them</summary>
    public  class ResavePluginDescriptorsConfig : ToolConfig
    {
        public override string Name => "ResavePluginDescriptors";
        public override string CliName => "ResavePluginDescriptors";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE4;
    
/// <summary>The root directory to enumerate plugins under</summary>
        public virtual ResavePluginDescriptorsConfig RootDir(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-RootDir",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4,
                        AllowMultiple: true
                    )
                ));
            }
            return (ResavePluginDescriptorsConfig) this;
        }

        
/// <summary>Author to specify in the 'Created By' field.</summary>
        public virtual ResavePluginDescriptorsConfig CreatedBy(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-CreatedBy",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4,
                        AllowMultiple: true
                    )
                ));
            }
            return (ResavePluginDescriptorsConfig) this;
        }

        
/// <summary>URL to link to for the 'Created By' field.</summary>
        public virtual ResavePluginDescriptorsConfig CreatedByUrl(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-CreatedByUrl",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4,
                        AllowMultiple: true
                    )
                ));
            }
            return (ResavePluginDescriptorsConfig) this;
        }

        
/// <summary>Remove the read-only flag from output files</summary>
        public virtual ResavePluginDescriptorsConfig Force(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Force",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4,
                        AllowMultiple: true
                    )
                ));
            }
            return (ResavePluginDescriptorsConfig) this;
        }
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    }

    protected readonly ResavePluginDescriptorsConfig ResavePluginDescriptorsStorage = new();
        
/// <summary>Re-save all the project descriptors under a given path</summary>
    public  class ResaveProjectDescriptorsConfig : ToolConfig
    {
        public override string Name => "ResaveProjectDescriptors";
        public override string CliName => "ResaveProjectDescriptors";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE4;
    
/// <summary>Sets the EngineAssociation field for each project</summary>
        public virtual ResaveProjectDescriptorsConfig EngineAssociation(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-EngineAssociation",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4,
                        AllowMultiple: true
                    )
                ));
            }
            return (ResaveProjectDescriptorsConfig) this;
        }

        
/// <summary>Remove the read-only flag from output files</summary>
        public virtual ResaveProjectDescriptorsConfig Force(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Force",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4,
                        AllowMultiple: true
                    )
                ));
            }
            return (ResaveProjectDescriptorsConfig) this;
        }

        
    
        public virtual ResaveProjectDescriptorsConfig RootDir(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-RootDir",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4,
                        AllowMultiple: true
                    )
                ));
            }
            return (ResaveProjectDescriptorsConfig) this;
        }
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    }

    protected readonly ResaveProjectDescriptorsConfig ResaveProjectDescriptorsStorage = new();
        
/// <remarks>WARNING: This command might require Perforce</remarks>
    public  class RunP4ReconcileConfig : ToolConfig
    {
        public override string Name => "RunP4Reconcile";
        public override string CliName => "RunP4Reconcile";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE4;
    
    
        public virtual RunP4ReconcileConfig Paths(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Paths",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4,
                        AllowMultiple: true
                    )
                ));
            }
            return (RunP4ReconcileConfig) this;
        }

        
    
        public virtual RunP4ReconcileConfig Description(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Description",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4,
                        AllowMultiple: true
                    )
                ));
            }
            return (RunP4ReconcileConfig) this;
        }

        
    
        public virtual RunP4ReconcileConfig FileType(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-FileType",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4,
                        AllowMultiple: true
                    )
                ));
            }
            return (RunP4ReconcileConfig) this;
        }
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    }

    protected readonly RunP4ReconcileConfig RunP4ReconcileStorage = new();
        
/// <summary>Copy all the binaries for a target into a different folder. Can be restored using the UnstashTarget command. Useful for A/B testing.</summary>
    public  class StashTargetConfig : ToolConfig
    {
        public override string Name => "StashTarget";
        public override string CliName => "StashTarget";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE4 | UnrealCompatibility.UE5;
    
/// <summary>Name of the target</summary>
        public virtual StashTargetConfig _Name(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Name",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (StashTargetConfig) this;
        }

        
/// <summary>Platform that the target was built for</summary>
        public virtual StashTargetConfig Platform(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Platform",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (StashTargetConfig) this;
        }

        
/// <summary>Architecture that the target was built for</summary>
        public virtual StashTargetConfig Configuration(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Configuration",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (StashTargetConfig) this;
        }

        
/// <summary>Architecture that the target was built for</summary>
        public virtual StashTargetConfig Architecture(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Architecture",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (StashTargetConfig) this;
        }

        
/// <summary>Project file for the target</summary>
        public virtual StashTargetConfig Project(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Project",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (StashTargetConfig) this;
        }

        
/// <summary>Output directory to store the stashed binaries</summary>
        public virtual StashTargetConfig To(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-To",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (StashTargetConfig) this;
        }
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    }

    protected readonly StashTargetConfig StashTargetStorage = new();
        
/// <summary>Copy all the binaries from a target back into the root directory. Use in combination with the StashTarget command.</summary>
    public  class UnstashTargetConfig : ToolConfig
    {
        public override string Name => "UnstashTarget";
        public override string CliName => "UnstashTarget";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE4 | UnrealCompatibility.UE5;
    
/// <summary>Directory to copy from</summary>
        public virtual UnstashTargetConfig From(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-From",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (UnstashTargetConfig) this;
        }
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    }

    protected readonly UnstashTargetConfig UnstashTargetStorage = new();
        
/// <summary>Submits a generated Utilization report to EC</summary>
    public  class SubmitUtilizationReportToECConfig : ToolConfig
    {
        public override string Name => "SubmitUtilizationReportToEC";
        public override string CliName => "SubmitUtilizationReportToEC";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE4;
    
    
        public virtual SubmitUtilizationReportToECConfig Day(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Day",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4,
                        AllowMultiple: true
                    )
                ));
            }
            return (SubmitUtilizationReportToECConfig) this;
        }

        
    
        public virtual SubmitUtilizationReportToECConfig FileName(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-FileName",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4,
                        AllowMultiple: true
                    )
                ));
            }
            return (SubmitUtilizationReportToECConfig) this;
        }
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    }

    protected readonly SubmitUtilizationReportToECConfig SubmitUtilizationReportToECStorage = new();
        
/// <summary>Attempts to sync UGS binaries for the specified project at the currently synced CL of the project/engine folders</summary>
/// <remarks>WARNING: This command might require Perforce</remarks>
    public  class SyncBinariesFromUGSConfig : ToolConfig
    {
        public override string Name => "SyncBinariesFromUGS";
        public override string CliName => "SyncBinariesFromUGS";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE4 | UnrealCompatibility.UE5;
    
/// <summary>Project to sync. Will search current path and paths in ueprojectdirs.</summary>
        public virtual SyncBinariesFromUGSConfig Project(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-project",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (SyncBinariesFromUGSConfig) this;
        }

        
/// <summary>If specified show actions but do not perform them.
/// If true no actions will be performed</summary>
        public virtual SyncBinariesFromUGSConfig Preview(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-preview",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (SyncBinariesFromUGSConfig) this;
        }
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    }

    protected readonly SyncBinariesFromUGSConfig SyncBinariesFromUGSStorage = new();
        
/// <summary>Merge one or more remote DDC shares into a local share, taking files with the newest timestamps and keeping the size below a certain limit</summary>
    public  class SyncDDCConfig : ToolConfig
    {
        public override string Name => "SyncDDC";
        public override string CliName => "SyncDDC";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE4 | UnrealCompatibility.UE5;
    
/// <summary>The local DDC directory to add/remove files from</summary>
        public virtual SyncDDCConfig LocalDir(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-LocalDir",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (SyncDDCConfig) this;
        }

        
/// <summary>The remote DDC directory to pull from. May be specified multiple times.</summary>
        public virtual SyncDDCConfig RemoteDir(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-RemoteDir",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (SyncDDCConfig) this;
        }

        
/// <summary>Maximum size of the local DDC directory. TB/MB/GB/KB units are allowed.</summary>
        public virtual SyncDDCConfig MaxSize(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-MaxSize",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (SyncDDCConfig) this;
        }

        
/// <summary>Only copies files with modified timestamps in the past number of days.</summary>
        public virtual SyncDDCConfig MaxDays(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-MaxDays",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (SyncDDCConfig) this;
        }

        
/// <summary>Maximum time to run for. h/m/s units are allowed.</summary>
        public virtual SyncDDCConfig TimeLimit(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-TimeLimit",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (SyncDDCConfig) this;
        }

        
    
        public virtual SyncDDCConfig Preview(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Preview",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (SyncDDCConfig) this;
        }
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    }

    protected readonly SyncDDCConfig SyncDDCStorage = new();
        
/// <summary>Creates a temporary client and syncs a path from Perforce.</summary>
/// <remarks>WARNING: This command might require Perforce</remarks>
    public  class SyncDepotPathConfig : ToolConfig
    {
        public override string Name => "SyncDepotPath";
        public override string CliName => "SyncDepotPath";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE4 | UnrealCompatibility.UE5;
    
    
        public virtual SyncDepotPathConfig DepotPath(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-DepotPath",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (SyncDepotPathConfig) this;
        }

        
    
        public virtual SyncDepotPathConfig OutputDir(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-OutputDir",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (SyncDepotPathConfig) this;
        }
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    }

    protected readonly SyncDepotPathConfig SyncDepotPathStorage = new();
        
/// <summary>Syncs and builds all the binaries required for a project</summary>
/// <remarks>WARNING: This command might require Perforce</remarks>
    public  class SyncProjectConfig : ToolConfig
    {
        public override string Name => "SyncProject";
        public override string CliName => "SyncProject";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE4 | UnrealCompatibility.UE5;
    
/// <summary>Project to sync. Will search current path and paths in ueprojectdirs. If omitted will sync projectdirs</summary>
        public virtual SyncProjectConfig Project(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-project",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (SyncProjectConfig) this;
        }

        
/// <summary>How many threads to use when syncing. Default=2. When &gt;1 all output happens first</summary>
        public virtual SyncProjectConfig Threads(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-threads",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (SyncProjectConfig) this;
        }

        
/// <summary>Changelist to sync to. If omitted will sync to latest CL of the workspace path. 0 Will Remove files!</summary>
        public virtual SyncProjectConfig Cl(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-cl",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (SyncProjectConfig) this;
        }

        
/// <summary>Clean old files before building</summary>
        public virtual SyncProjectConfig Clean(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-clean",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (SyncProjectConfig) this;
        }

        
/// <summary>Build after syncing</summary>
        public virtual SyncProjectConfig Build(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-build",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (SyncProjectConfig) this;
        }

        
/// <summary>Open project editor after syncing</summary>
        public virtual SyncProjectConfig Open(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-open",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (SyncProjectConfig) this;
        }

        
/// <summary>Generate project files after syncing</summary>
        public virtual SyncProjectConfig Generate(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-generate",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (SyncProjectConfig) this;
        }

        
/// <summary>force sync files (files opened for edit will be untouched)</summary>
        public virtual SyncProjectConfig Force(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-force",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (SyncProjectConfig) this;
        }

        
/// <summary>Shows commands that will be executed but performs no operations</summary>
        public virtual SyncProjectConfig Preview(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-preview",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (SyncProjectConfig) this;
        }

        
/// <summary>Only sync the project</summary>
        public virtual SyncProjectConfig Projectonly(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-projectonly",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (SyncProjectConfig) this;
        }

        
/// <summary>Only sync this path. Can be comma-separated list.</summary>
        public virtual SyncProjectConfig Paths(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-paths",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (SyncProjectConfig) this;
        }

        
/// <summary>Number of retries for a timed out file. Defaults to 3</summary>
        public virtual SyncProjectConfig Retries(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-retries",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (SyncProjectConfig) this;
        }

        
/// <summary>Do not set an engine version after syncing</summary>
        public virtual SyncProjectConfig Unversioned(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-unversioned",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (SyncProjectConfig) this;
        }

        
/// <summary>Only sync files that match this path. Can be comma-separated list.</summary>
        public virtual SyncProjectConfig Path(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-path",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (SyncProjectConfig) this;
        }
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    }

    protected readonly SyncProjectConfig SyncProjectStorage = new();
        
/// <summary>Tests P4 functionality. Runs 'p4 info'.</summary>
/// <remarks>WARNING: This command might require Perforce</remarks>
    public  class TestP4_InfoConfig : ToolConfig
    {
        public override string Name => "TestP4_Info";
        public override string CliName => "TestP4_Info";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE4;
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    }

    protected readonly TestP4_InfoConfig TestP4_InfoStorage = new();
        
/// <summary>GitPullRequest</summary>
/// <remarks>WARNING: This command might require Perforce</remarks>
    public  class GitPullRequestConfig : ToolConfig
    {
        public override string Name => "GitPullRequest";
        public override string CliName => "GitPullRequest";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE4;
    
/// <summary>Directory of the Git repo.</summary>
        public virtual GitPullRequestConfig Dir(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Dir",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4,
                        AllowMultiple: true
                    )
                ));
            }
            return (GitPullRequestConfig) this;
        }

        
/// <summary>PR # to shelve, can use a range PR=5-25</summary>
        public virtual GitPullRequestConfig PR(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-PR",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4,
                        AllowMultiple: true
                    )
                ));
            }
            return (GitPullRequestConfig) this;
        }

        
    
        public virtual GitPullRequestConfig UT(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-UT",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4,
                        AllowMultiple: true
                    )
                ));
            }
            return (GitPullRequestConfig) this;
        }

        
    
        public virtual GitPullRequestConfig Clean(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Clean",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4,
                        AllowMultiple: true
                    )
                ));
            }
            return (GitPullRequestConfig) this;
        }
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    }

    protected readonly GitPullRequestConfig GitPullRequestStorage = new();
        
/// <summary>Throws an automation exception.</summary>
    public  class TestFailConfig : ToolConfig
    {
        public override string Name => "TestFail";
        public override string CliName => "TestFail";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE4;
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    }

    protected readonly TestFailConfig TestFailStorage = new();
        
/// <summary>Prints a message and returns success.</summary>
    public  class TestSuccessConfig : ToolConfig
    {
        public override string Name => "TestSuccess";
        public override string CliName => "TestSuccess";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE4;
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    }

    protected readonly TestSuccessConfig TestSuccessStorage = new();
        
/// <summary>Prints a message and returns success.</summary>
    public  class TestMessageConfig : ToolConfig
    {
        public override string Name => "TestMessage";
        public override string CliName => "TestMessage";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE4;
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    }

    protected readonly TestMessageConfig TestMessageStorage = new();
        
/// <summary>Calls UAT recursively with a given command line.</summary>
    public  class TestRecursionConfig : ToolConfig
    {
        public override string Name => "TestRecursion";
        public override string CliName => "TestRecursion";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE4;
    
    
        public virtual TestRecursionConfig Cmd(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Cmd",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4,
                        AllowMultiple: true
                    )
                ));
            }
            return (TestRecursionConfig) this;
        }
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    }

    protected readonly TestRecursionConfig TestRecursionStorage = new();
        
/// <summary>Calls UAT recursively with a given command line.</summary>
    public  class TestRecursionAutoConfig : ToolConfig
    {
        public override string Name => "TestRecursionAuto";
        public override string CliName => "TestRecursionAuto";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE4;
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    }

    protected readonly TestRecursionAutoConfig TestRecursionAutoStorage = new();
        
/// <summary>Makes a zip file in Rocket/QFE</summary>
    public  class TestMacZipConfig : ToolConfig
    {
        public override string Name => "TestMacZip";
        public override string CliName => "TestMacZip";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE4;
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    }

    protected readonly TestMacZipConfig TestMacZipStorage = new();
        
/// <summary>Tests P4 functionality. Creates a new changelist under the workspace %P4CLIENT%</summary>
/// <remarks>WARNING: This command might require Perforce</remarks>
    public  class TestP4_CreateChangelistConfig : ToolConfig
    {
        public override string Name => "TestP4_CreateChangelist";
        public override string CliName => "TestP4_CreateChangelist";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE4;
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    }

    protected readonly TestP4_CreateChangelistConfig TestP4_CreateChangelistStorage = new();
        
/// <remarks>WARNING: This command might require Perforce</remarks>
    public  class TestP4_StrandCheckoutConfig : ToolConfig
    {
        public override string Name => "TestP4_StrandCheckout";
        public override string CliName => "TestP4_StrandCheckout";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE4;
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    }

    protected readonly TestP4_StrandCheckoutConfig TestP4_StrandCheckoutStorage = new();
        
/// <remarks>WARNING: This command might require Perforce</remarks>
    public  class TestP4_LabelDescriptionConfig : ToolConfig
    {
        public override string Name => "TestP4_LabelDescription";
        public override string CliName => "TestP4_LabelDescription";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE4;
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    }

    protected readonly TestP4_LabelDescriptionConfig TestP4_LabelDescriptionStorage = new();
        
/// <remarks>WARNING: This command might require Perforce</remarks>
    public  class TestP4_ClientOpsConfig : ToolConfig
    {
        public override string Name => "TestP4_ClientOps";
        public override string CliName => "TestP4_ClientOps";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE4;
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    }

    protected readonly TestP4_ClientOpsConfig TestP4_ClientOpsStorage = new();
        
    
    public  class CleanDDCConfig : ToolConfig
    {
        public override string Name => "CleanDDC";
        public override string CliName => "CleanDDC";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE4;
    
    
        public virtual CleanDDCConfig DoIt(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-DoIt",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4,
                        AllowMultiple: true
                    )
                ));
            }
            return (CleanDDCConfig) this;
        }
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    }

    protected readonly CleanDDCConfig CleanDDCStorage = new();
        
    
    public  class TestTestFarmConfig : ToolConfig
    {
        public override string Name => "TestTestFarm";
        public override string CliName => "TestTestFarm";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE4;
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    }

    protected readonly TestTestFarmConfig TestTestFarmStorage = new();
        
/// <summary>Test command line argument parsing functions.</summary>
    public  class TestArgumentsConfig : ToolConfig
    {
        public override string Name => "TestArguments";
        public override string CliName => "TestArguments";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE4;
    
    
        public virtual TestArgumentsConfig Noxge(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-noxge",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4,
                        AllowMultiple: true
                    )
                ));
            }
            return (TestArgumentsConfig) this;
        }

        
    
        public virtual TestArgumentsConfig Dude(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Dude",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4,
                        AllowMultiple: true
                    )
                ));
            }
            return (TestArgumentsConfig) this;
        }

        
    
        public virtual TestArgumentsConfig Stuff(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Stuff",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4,
                        AllowMultiple: true
                    )
                ));
            }
            return (TestArgumentsConfig) this;
        }

        
    
        public virtual TestArgumentsConfig Map(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-map",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4,
                        AllowMultiple: true
                    )
                ));
            }
            return (TestArgumentsConfig) this;
        }

        
    
        public virtual TestArgumentsConfig Run(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-run",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4,
                        AllowMultiple: true
                    )
                ));
            }
            return (TestArgumentsConfig) this;
        }
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    }

    protected readonly TestArgumentsConfig TestArgumentsStorage = new();
        
/// <summary>Checks if combine paths works as excpected</summary>
    public  class TestCombinePathsConfig : ToolConfig
    {
        public override string Name => "TestCombinePaths";
        public override string CliName => "TestCombinePaths";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE4;
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    }

    protected readonly TestCombinePathsConfig TestCombinePathsStorage = new();
        
/// <summary>Tests file utility functions.</summary>
    public  class TestFileUtilityConfig : ToolConfig
    {
        public override string Name => "TestFileUtility";
        public override string CliName => "TestFileUtility";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE4;
    
/// <summary>Filename to perform the tests on.</summary>
        public virtual TestFileUtilityConfig File(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-file",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4,
                        AllowMultiple: true
                    )
                ));
            }
            return (TestFileUtilityConfig) this;
        }
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    }

    protected readonly TestFileUtilityConfig TestFileUtilityStorage = new();
        
    
    public  class TestLogConfig : ToolConfig
    {
        public override string Name => "TestLog";
        public override string CliName => "TestLog";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE4;
    
    
        public virtual TestLogConfig Map(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-map",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4,
                        AllowMultiple: true
                    )
                ));
            }
            return (TestLogConfig) this;
        }
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    }

    protected readonly TestLogConfig TestLogStorage = new();
        
/// <summary>Tests P4 change filetype functionality.</summary>
/// <remarks>WARNING: This command might require Perforce</remarks>
    public  class TestChangeFileTypeConfig : ToolConfig
    {
        public override string Name => "TestChangeFileType";
        public override string CliName => "TestChangeFileType";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE4;
    
/// <summary>Binary file to change the filetype to writeable</summary>
        public virtual TestChangeFileTypeConfig File(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-File",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4,
                        AllowMultiple: true
                    )
                ));
            }
            return (TestChangeFileTypeConfig) this;
        }
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    }

    protected readonly TestChangeFileTypeConfig TestChangeFileTypeStorage = new();
        
/// <summary>Tests if UE4Build properly copies all relevent UAT build products to the Binaries folder.</summary>
    public  class TestUATBuildProductsConfig : ToolConfig
    {
        public override string Name => "TestUATBuildProducts";
        public override string CliName => "TestUATBuildProducts";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE4;
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    }

    protected readonly TestUATBuildProductsConfig TestUATBuildProductsStorage = new();
        
    
    public  class TestOSSCommandsConfig : ToolConfig
    {
        public override string Name => "TestOSSCommands";
        public override string CliName => "TestOSSCommands";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE4;
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    }

    protected readonly TestOSSCommandsConfig TestOSSCommandsStorage = new();
        
/// <summary>Builds a project using UBT. Syntax is similar to UBT with the exception of '-', i.e. UBT -QAGame -Development -Win32</summary>
    public  class UBTConfig : ToolConfig
    {
        public override string Name => "UBT";
        public override string CliName => "UBT";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE4;
    
/// <summary>Disable XGE</summary>
        public virtual UBTConfig NoXGE(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-NoXGE",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4,
                        AllowMultiple: true
                    )
                ));
            }
            return (UBTConfig) this;
        }

        
/// <summary>Clean build products before building</summary>
        public virtual UBTConfig Clean(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Clean",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4,
                        AllowMultiple: true
                    )
                ));
            }
            return (UBTConfig) this;
        }
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    }

    protected readonly UBTConfig UBTStorage = new();
        
/// <summary>Helper command to sync only source code + engine files from P4.</summary>
/// <remarks>WARNING: This command might require Perforce</remarks>
    public  class SyncSourceConfig : ToolConfig
    {
        public override string Name => "SyncSource";
        public override string CliName => "SyncSource";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE4;
    
/// <summary>Optional branch depot path, default is: -Branch=//depot/UE4</summary>
        public virtual SyncSourceConfig Branch(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Branch",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4,
                        AllowMultiple: true
                    )
                ));
            }
            return (SyncSourceConfig) this;
        }

        
/// <summary>Optional changelist to sync (default is latest), -CL=1234567</summary>
        public virtual SyncSourceConfig CL(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-CL",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4,
                        AllowMultiple: true
                    )
                ));
            }
            return (SyncSourceConfig) this;
        }

        
/// <summary>Optional list of branch subforlders to always sync separated with '+', default is: -Sync=Engine/Binaries/ThirdParty+Engine/Content</summary>
        public virtual SyncSourceConfig Sync(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Sync",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4,
                        AllowMultiple: true
                    )
                ));
            }
            return (SyncSourceConfig) this;
        }

        
/// <summary>Optional list of folder names to exclude from syncing, separated with '+', default is: -Exclude=Binaries+Content+Documentation+DataTables</summary>
        public virtual SyncSourceConfig Exclude(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Exclude",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4,
                        AllowMultiple: true
                    )
                ));
            }
            return (SyncSourceConfig) this;
        }
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    }

    protected readonly SyncSourceConfig SyncSourceStorage = new();
        
/// <summary>Generates automation project based on a template.</summary>
    public  class GenerateAutomationProjectConfig : ToolConfig
    {
        public override string Name => "GenerateAutomationProject";
        public override string CliName => "GenerateAutomationProject";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE4;
    
/// <summary>Short name of the project, i.e. QAGame</summary>
        public virtual GenerateAutomationProjectConfig Project(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-project",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4,
                        AllowMultiple: true
                    )
                ));
            }
            return (GenerateAutomationProjectConfig) this;
        }

        
/// <summary>Absolute path to the project root directory, i.e. C:\UE4\QAGame</summary>
        public virtual GenerateAutomationProjectConfig Path(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-path",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4,
                        AllowMultiple: true
                    )
                ));
            }
            return (GenerateAutomationProjectConfig) this;
        }
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    }

    protected readonly GenerateAutomationProjectConfig GenerateAutomationProjectStorage = new();
        
    
    public  class DumpBranchConfig : ToolConfig
    {
        public override string Name => "DumpBranch";
        public override string CliName => "DumpBranch";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE4;
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    }

    protected readonly DumpBranchConfig DumpBranchStorage = new();
        
/// <summary>Sleeps for 20 seconds and then exits</summary>
    public  class DebugSleepConfig : ToolConfig
    {
        public override string Name => "DebugSleep";
        public override string CliName => "DebugSleep";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE4;
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    }

    protected readonly DebugSleepConfig DebugSleepStorage = new();
        
/// <summary>Tests if Mcp configs loaded properly.</summary>
    public  class TestMcpConfigsConfig : ToolConfig
    {
        public override string Name => "TestMcpConfigs";
        public override string CliName => "TestMcpConfigs";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE4;
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    }

    protected readonly TestMcpConfigsConfig TestMcpConfigsStorage = new();
        
/// <summary>Test Blame P4 command.</summary>
/// <remarks>WARNING: This command might require Perforce</remarks>
    public  class TestBlameConfig : ToolConfig
    {
        public override string Name => "TestBlame";
        public override string CliName => "TestBlame";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE4;
    
/// <summary>(Optional) Filename of the file to produce a blame output for</summary>
        public virtual TestBlameConfig File(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-File",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4,
                        AllowMultiple: true
                    )
                ));
            }
            return (TestBlameConfig) this;
        }

        
/// <summary>(Optional) File to save the blame result to.</summary>
        public virtual TestBlameConfig Out(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Out",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4,
                        AllowMultiple: true
                    )
                ));
            }
            return (TestBlameConfig) this;
        }

        
/// <summary>If specified, will use Timelapse command instead of Blame</summary>
        public virtual TestBlameConfig Timelapse(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Timelapse",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4,
                        AllowMultiple: true
                    )
                ));
            }
            return (TestBlameConfig) this;
        }
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    }

    protected readonly TestBlameConfig TestBlameStorage = new();
        
/// <summary>Test P4 changes.</summary>
/// <remarks>WARNING: This command might require Perforce</remarks>
    public  class TestChangesConfig : ToolConfig
    {
        public override string Name => "TestChanges";
        public override string CliName => "TestChanges";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE4;
    
    
        public virtual TestChangesConfig CommandParam(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-CommandParam",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4,
                        AllowMultiple: true
                    )
                ));
            }
            return (TestChangesConfig) this;
        }
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    }

    protected readonly TestChangesConfig TestChangesStorage = new();
        
/// <summary>Spawns a process to test if UAT kills it automatically.</summary>
    public  class TestKillAllConfig : ToolConfig
    {
        public override string Name => "TestKillAll";
        public override string CliName => "TestKillAll";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE4;
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    }

    protected readonly TestKillAllConfig TestKillAllStorage = new();
        
/// <summary>Tests CleanFormalBuilds.</summary>
    public  class TestCleanFormalBuildsConfig : ToolConfig
    {
        public override string Name => "TestCleanFormalBuilds";
        public override string CliName => "TestCleanFormalBuilds";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE4;
    
    
        public virtual TestCleanFormalBuildsConfig Dir(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Dir",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4,
                        AllowMultiple: true
                    )
                ));
            }
            return (TestCleanFormalBuildsConfig) this;
        }
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    }

    protected readonly TestCleanFormalBuildsConfig TestCleanFormalBuildsStorage = new();
        
/// <summary>Spawns a process to test if it can be killed.</summary>
    public  class TestStopProcessConfig : ToolConfig
    {
        public override string Name => "TestStopProcess";
        public override string CliName => "TestStopProcess";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE4;
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    }

    protected readonly TestStopProcessConfig TestStopProcessStorage = new();
        
/// <summary>Looks through an XGE xml for overlapping obj files</summary>
    public  class LookForOverlappingBuildProductsConfig : ToolConfig
    {
        public override string Name => "LookForOverlappingBuildProducts";
        public override string CliName => "LookForOverlappingBuildProducts";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE4;
    
/// <summary>full path of xml to look at</summary>
        public virtual LookForOverlappingBuildProductsConfig Source(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Source",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4,
                        AllowMultiple: true
                    )
                ));
            }
            return (LookForOverlappingBuildProductsConfig) this;
        }

        
    
        public virtual LookForOverlappingBuildProductsConfig Source_(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Source=",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4,
                        AllowMultiple: true
                    )
                ));
            }
            return (LookForOverlappingBuildProductsConfig) this;
        }
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    }

    protected readonly LookForOverlappingBuildProductsConfig LookForOverlappingBuildProductsStorage = new();
        
/// <summary>Copies all files from source directory to destination directory using ThreadedCopyFiles</summary>
    public  class TestThreadedCopyFilesConfig : ToolConfig
    {
        public override string Name => "TestThreadedCopyFiles";
        public override string CliName => "TestThreadedCopyFiles";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE4;
    
/// <summary>Source path</summary>
        public virtual TestThreadedCopyFilesConfig Source(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Source",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4,
                        AllowMultiple: true
                    )
                ));
            }
            return (TestThreadedCopyFilesConfig) this;
        }

        
/// <summary>Destination path</summary>
        public virtual TestThreadedCopyFilesConfig Dest(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Dest",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4,
                        AllowMultiple: true
                    )
                ));
            }
            return (TestThreadedCopyFilesConfig) this;
        }

        
/// <summary>Number of threads used to copy files (64 by default)</summary>
        public virtual TestThreadedCopyFilesConfig Threads(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Threads",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4,
                        AllowMultiple: true
                    )
                ));
            }
            return (TestThreadedCopyFilesConfig) this;
        }

        
    
        public virtual TestThreadedCopyFilesConfig Source_(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Source=",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4,
                        AllowMultiple: true
                    )
                ));
            }
            return (TestThreadedCopyFilesConfig) this;
        }

        
    
        public virtual TestThreadedCopyFilesConfig Dest_(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Dest=",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4,
                        AllowMultiple: true
                    )
                ));
            }
            return (TestThreadedCopyFilesConfig) this;
        }

        
    
        public virtual TestThreadedCopyFilesConfig Threads_(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Threads=",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4,
                        AllowMultiple: true
                    )
                ));
            }
            return (TestThreadedCopyFilesConfig) this;
        }
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    }

    protected readonly TestThreadedCopyFilesConfig TestThreadedCopyFilesStorage = new();
        
    
    public  class UnrealBuildUtilDummyBuildCommandConfig : ToolConfig
    {
        public override string Name => "UnrealBuildUtilDummyBuildCommand";
        public override string CliName => "UE4BuildUtilDummyBuildCommand";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE4 | UnrealCompatibility.UE5;
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    }

    protected readonly UnrealBuildUtilDummyBuildCommandConfig UnrealBuildUtilDummyBuildCommandStorage = new();
        
/// <summary>Updates your local versions based on your P4 sync</summary>
/// <remarks>WARNING: This command might require Perforce</remarks>
    public  class UpdateLocalVersionConfig : ToolConfig
    {
        public override string Name => "UpdateLocalVersion";
        public override string CliName => "UpdateLocalVersion";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE4 | UnrealCompatibility.UE5;
    
/// <summary>Overrides the automatically disovered changelist number with the specified one</summary>
        public virtual UpdateLocalVersionConfig CL(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-CL",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (UpdateLocalVersionConfig) this;
        }

        
/// <summary>Overrides the changelist that the engine is API-compatible with</summary>
        public virtual UpdateLocalVersionConfig CompatibleCL(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-CompatibleCL",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (UpdateLocalVersionConfig) this;
        }

        
/// <summary>Value for whether this is a promoted build (defaults to 1).</summary>
        public virtual UpdateLocalVersionConfig Promoted(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Promoted",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (UpdateLocalVersionConfig) this;
        }

        
/// <summary>Overrides the branch string.</summary>
        public virtual UpdateLocalVersionConfig Branch(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Branch",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (UpdateLocalVersionConfig) this;
        }

        
/// <summary>When updating version files, store the changelist number in licensee format</summary>
        public virtual UpdateLocalVersionConfig Licensee(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Licensee",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (UpdateLocalVersionConfig) this;
        }

        
    
        public virtual UpdateLocalVersionConfig Build(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Build",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (UpdateLocalVersionConfig) this;
        }
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    }

    protected readonly UpdateLocalVersionConfig UpdateLocalVersionStorage = new();
        
    
    public  class UploadDDCToAWSConfig : ToolConfig
    {
        public override string Name => "UploadDDCToAWS";
        public override string CliName => "UploadDDCToAWS";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE4 | UnrealCompatibility.UE5;
    
    
        public virtual UploadDDCToAWSConfig Days(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Days",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (UploadDDCToAWSConfig) this;
        }

        
    
        public virtual UploadDDCToAWSConfig MaxFileSize(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-MaxFileSize",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (UploadDDCToAWSConfig) this;
        }

        
    
        public virtual UploadDDCToAWSConfig KeyPrefix(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-KeyPrefix",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (UploadDDCToAWSConfig) this;
        }

        
    
        public virtual UploadDDCToAWSConfig Reset(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Reset",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (UploadDDCToAWSConfig) this;
        }

        
    
        public virtual UploadDDCToAWSConfig Local(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Local",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (UploadDDCToAWSConfig) this;
        }
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    }

    protected readonly UploadDDCToAWSConfig UploadDDCToAWSStorage = new();
        
/// <summary>ZipUtils is used to zip/unzip (i.e:RunUAT.bat ZipUtils -archive=D:/Content.zip -add=D:/UE/Pojects/SampleGame/Content/) or (i.e:RunUAT.bat ZipUtils -archive=D:/Content.zip -extract=D:/UE/Pojects/SampleGame/Content/)</summary>
    public  class ZipUtilsConfig : ToolConfig
    {
        public override string Name => "ZipUtils";
        public override string CliName => "ZipUtils";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE4 | UnrealCompatibility.UE5;
    
/// <summary>Path to folder that should be add to the archive.</summary>
        public virtual ZipUtilsConfig Archive(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-archive",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (ZipUtilsConfig) this;
        }

        
/// <summary>Path to folder that should be add to the archive.</summary>
        public virtual ZipUtilsConfig Add(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-add",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (ZipUtilsConfig) this;
        }

        
/// <summary>Path to folder where the archive should be extracted</summary>
        public virtual ZipUtilsConfig Extract(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-extract",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (ZipUtilsConfig) this;
        }

        
/// <summary>Compression Level 0 - Copy  9-Best Compression</summary>
        public virtual ZipUtilsConfig Compression(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-compression",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (ZipUtilsConfig) this;
        }
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    }

    protected readonly ZipUtilsConfig ZipUtilsStorage = new();
        
/// <summary>Runs benchmarks and reports overall results
/// Example1: RunUAT BenchmarkBuild -all -project=UE4
/// Example2: RunUAT BenchmarkBuild -allcompile -project=UE4+EngineTest -platform=PS4
/// Example3: RunUAT BenchmarkBuild -editor -client -cook -cooknoshaderddc -cooknoddc -xge -noxge -singlecompile -nopcompile -project=UE4+QAGame+EngineTest -platform=WIn64+PS4+XboxOne+Switch -iterations=3
/// Runs benchmarks and reports overall results
/// Example1: RunUAT BenchmarkBuild -all -project=Unreal
/// Example2: RunUAT BenchmarkBuild -allcompile -project=Unreal+EngineTest -platform=PS4
/// Example3: RunUAT BenchmarkBuild -editor -client -cook -cooknoshaderddc -cooknoddc -xge -noxge -singlecompile -nopcompile -project=Unreal+QAGame+EngineTest -platform=WIn64+PS4+XboxOne+Switch -iterations=3</summary>
    public  class BenchmarkBuildConfig : ToolConfig
    {
        public override string Name => "BenchmarkBuild";
        public override string CliName => "BenchmarkBuild";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE4 | UnrealCompatibility.UE5;
    
/// <summary>List everything that will run but don't do it</summary>
        public virtual BenchmarkBuildConfig Preview(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-preview",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BenchmarkBuildConfig) this;
        }

        
/// <summary>Do tests on the specified projec(s)t. E.g. -project=UE4+FortniteGame+QAGame
/// Do tests on the specified project(s). E.g. -project=Unreal+FortniteGame+QAGame</summary>
        public virtual BenchmarkBuildConfig Project(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-project",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BenchmarkBuildConfig) this;
        }

        
/// <summary>Run all the things (except noddc)
/// Shorthand for -editor -client -AllCompile -AllEditor -AllCook -AllDDC</summary>
        public virtual BenchmarkBuildConfig All(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-all",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BenchmarkBuildConfig) this;
        }

        
/// <summary>Run all the compile things
/// Shorthand for -compile -singlecompile -nopcompile</summary>
        public virtual BenchmarkBuildConfig Allcompile(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-allcompile",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BenchmarkBuildConfig) this;
        }

        
/// <summary>Build an editor for compile tests
/// Time building the editor</summary>
        public virtual BenchmarkBuildConfig Editor(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-editor",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BenchmarkBuildConfig) this;
        }

        
/// <summary>Build a client for comple tests (see -platform)
/// Time building the for the specified platform(s)</summary>
        public virtual BenchmarkBuildConfig Client(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-client",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BenchmarkBuildConfig) this;
        }

        
/// <summary>Specify the platform(s) to use for client compilation/cooking, if empty the local platform be used if -client or -cook is specified</summary>
        public virtual BenchmarkBuildConfig Platform(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-platform",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BenchmarkBuildConfig) this;
        }

        
/// <summary>Do a compile with XGE / FASTBuild
/// Do a pass with XGE / FASTBuild (default)</summary>
        public virtual BenchmarkBuildConfig Xge(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-xge",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BenchmarkBuildConfig) this;
        }

        
/// <summary>Do a compile without XGE / FASTBuild
/// Do a pass without XGE / FASTBuild</summary>
        public virtual BenchmarkBuildConfig Noxge(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-noxge",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BenchmarkBuildConfig) this;
        }

        
/// <summary>Do a single-file compile</summary>
        public virtual BenchmarkBuildConfig Singlecompile(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-singlecompile",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BenchmarkBuildConfig) this;
        }

        
/// <summary>Do a nothing-needs-compiled compile</summary>
        public virtual BenchmarkBuildConfig Nopcompile(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-nopcompile",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BenchmarkBuildConfig) this;
        }

        
/// <summary>Do noxge builds with these processor counts (default is Environment.ProcessorCount)</summary>
        public virtual BenchmarkBuildConfig Cores(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-cores",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BenchmarkBuildConfig) this;
        }

        
/// <summary>Do a cook for the specified platform
/// Time cooking the project for the specified platform(s). Specify maps with -editor-cook=map1+map2</summary>
        public virtual BenchmarkBuildConfig Cook(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-cook",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BenchmarkBuildConfig) this;
        }

        
/// <summary>Launch the editor (only valid when -project is specified</summary>
        public virtual BenchmarkBuildConfig Pie(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-pie",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BenchmarkBuildConfig) this;
        }

        
/// <summary>Map to PIE with (only valid when using a single project</summary>
        public virtual BenchmarkBuildConfig Map(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-map",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4,
                        AllowMultiple: true
                    )
                ));
            }
            return (BenchmarkBuildConfig) this;
        }

        
/// <summary>Cook / PIE with a warm DDC</summary>
        public virtual BenchmarkBuildConfig Warmddc(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-warmddc",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BenchmarkBuildConfig) this;
        }

        
/// <summary>Cook / PIE with a hot local DDC (an untimed pre-run is performed)</summary>
        public virtual BenchmarkBuildConfig Hotddc(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-hotddc",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BenchmarkBuildConfig) this;
        }

        
/// <summary>Cook / PIE with a cold local DDC (a temporary folder is used)</summary>
        public virtual BenchmarkBuildConfig Coldddc(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-coldddc",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BenchmarkBuildConfig) this;
        }

        
/// <summary>Cook / PIE with no shaders in the DDC</summary>
        public virtual BenchmarkBuildConfig Noshaderddc(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-noshaderddc",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BenchmarkBuildConfig) this;
        }

        
/// <summary>How many times to perform each test)</summary>
        public virtual BenchmarkBuildConfig Iterations(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-iterations",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BenchmarkBuildConfig) this;
        }

        
/// <summary>How many seconds to wait between each test)</summary>
        public virtual BenchmarkBuildConfig Wait(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-wait",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BenchmarkBuildConfig) this;
        }

        
/// <summary>Name/path of file to write CSV results to. If empty the local machine name will be used</summary>
        public virtual BenchmarkBuildConfig Filename(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-filename",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4,
                        AllowMultiple: true
                    )
                ));
            }
            return (BenchmarkBuildConfig) this;
        }

        
/// <summary>Don't build from clean. (Mostly just to speed things up when testing)</summary>
        public virtual BenchmarkBuildConfig Noclean(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-noclean",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BenchmarkBuildConfig) this;
        }

        
/// <summary>Extra args to use when cooking. -CookArgs1="-foo" -CookArgs2="-bar" will run two cooks with each argument set
/// Extra args to use when cooking. -CookArgs="-foo" -Cook2Args="-bar" will run two cook passes with -foo and -bar</summary>
        public virtual BenchmarkBuildConfig CookArgs(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-CookArgs",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BenchmarkBuildConfig) this;
        }

        
/// <summary>Extra args to use when running the editor. -PIEArgs1="-foo" -PIEArgs2="-bar" will run two PIE tests with each argument set
/// Extra args to use for PIE. -PIEArgs="-foo" -PIE2Args="-bar" will run two PIE passes with -foo and -bar</summary>
        public virtual BenchmarkBuildConfig PIEArgs(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-PIEArgs",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BenchmarkBuildConfig) this;
        }

        
    
        public virtual BenchmarkBuildConfig Ue4(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-ue4",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4,
                        AllowMultiple: true
                    )
                ));
            }
            return (BenchmarkBuildConfig) this;
        }

        
    
        public virtual BenchmarkBuildConfig Fastbuild(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-fastbuild",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4,
                        AllowMultiple: true
                    )
                ));
            }
            return (BenchmarkBuildConfig) this;
        }

        
    
        public virtual BenchmarkBuildConfig Nofastbuild(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-nofastbuild",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4,
                        AllowMultiple: true
                    )
                ));
            }
            return (BenchmarkBuildConfig) this;
        }

        
    
        public virtual BenchmarkBuildConfig Projects(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-projects",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BenchmarkBuildConfig) this;
        }

        
    
        public virtual BenchmarkBuildConfig Platforms(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-platforms",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BenchmarkBuildConfig) this;
        }

        
/// <summary>Time compiling the target</summary>
        public virtual BenchmarkBuildConfig Compile(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-compile",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BenchmarkBuildConfig) this;
        }

        
/// <summary>Time launching the editor. Specify maps with -editor-startup=map1+map2</summary>
        public virtual BenchmarkBuildConfig Editorstartup(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-editor-startup",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BenchmarkBuildConfig) this;
        }

        
/// <summary>Time pie'ing for a project (only valid when -project is specified). Specify maps with -editor-pie=map1+map2</summary>
        public virtual BenchmarkBuildConfig Editorpie(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-editor-pie",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BenchmarkBuildConfig) this;
        }

        
/// <summary>Time launching the editor as -game (only valid when -project is specified). Specify maps with -editor-game=map1+map2</summary>
        public virtual BenchmarkBuildConfig Editorgame(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-editor-game",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BenchmarkBuildConfig) this;
        }

        
/// <summary>Shorthand for -editor-startup -editor-pie -editor-game</summary>
        public virtual BenchmarkBuildConfig AllEditor(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-AllEditor",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BenchmarkBuildConfig) this;
        }

        
/// <summary>Map to Launch/PIE with (only valid when using a single project. Same as setting editor-pie=m1+m2, editor-startup=m1+m2 individually</summary>
        public virtual BenchmarkBuildConfig Editormaps(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-editor-maps",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BenchmarkBuildConfig) this;
        }

        
/// <summary>Time an iterative cook for the specified platform(s) (will run a cook first if -cook is not specified). Specify maps with -editor-cook-iterative=map1+map2</summary>
        public virtual BenchmarkBuildConfig Cookiterative(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-cook-iterative",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BenchmarkBuildConfig) this;
        }

        
/// <summary>Shorthand for -cook -cook-iterative</summary>
        public virtual BenchmarkBuildConfig AllCook(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-AllCook",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BenchmarkBuildConfig) this;
        }

        
/// <summary>Cook / PIE with a cold local DDC and no shared ddc</summary>
        public virtual BenchmarkBuildConfig Coldddcnoshared(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-coldddc-noshared",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BenchmarkBuildConfig) this;
        }

        
/// <summary>Shorthand for -coldddc -coldddc-noshared -noshaderddc -hotddc</summary>
        public virtual BenchmarkBuildConfig AllDDC(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-AllDDC",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BenchmarkBuildConfig) this;
        }

        
/// <summary>Do a pass with XGE for editor DDC (default)</summary>
        public virtual BenchmarkBuildConfig Editorxge(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-editorxge",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BenchmarkBuildConfig) this;
        }

        
/// <summary>Do a pass without XGE for editor DDC</summary>
        public virtual BenchmarkBuildConfig Noeditorxge(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-noeditorxge",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BenchmarkBuildConfig) this;
        }

        
/// <summary>Extra args to use when compiling. -UBTArgs="-foo" -UBT2Args="-bar" will run two compile passes with -foo and -bar</summary>
        public virtual BenchmarkBuildConfig UBTArgs(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-UBTArgs",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BenchmarkBuildConfig) this;
        }

        
/// <summary>Extra args to use for launching. -LaunchArgs="-foo" -Launch2Args="-bar" will run two launch passes with -foo and -bar</summary>
        public virtual BenchmarkBuildConfig LaunchArgs(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-LaunchArgs",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BenchmarkBuildConfig) this;
        }

        
/// <summary>Name/path of file to write CSV results to. If empty the local machine name will be used</summary>
        public virtual BenchmarkBuildConfig Csv(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-csv",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BenchmarkBuildConfig) this;
        }

        
/// <summary>Don't clean artifacts after a task when building a lot of platforms/projects</summary>
        public virtual BenchmarkBuildConfig Nopostclean(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-nopostclean",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BenchmarkBuildConfig) this;
        }

        
    
        public virtual BenchmarkBuildConfig AllClient(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-AllClient",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BenchmarkBuildConfig) this;
        }

        
    
        public virtual BenchmarkBuildConfig Unreal(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Unreal",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BenchmarkBuildConfig) this;
        }

        
    
        public virtual BenchmarkBuildConfig Launch(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Launch",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BenchmarkBuildConfig) this;
        }

        
    
        public virtual BenchmarkBuildConfig UBT(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-UBT",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BenchmarkBuildConfig) this;
        }
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    }

    protected readonly BenchmarkBuildConfig BenchmarkBuildStorage = new();
        
    
    public  class BenchmarkOptionsConfig : ToolConfig
    {
        public override string Name => "BenchmarkOptions";
        public override string CliName => "BenchmarkOptions";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE4 | UnrealCompatibility.UE5;
    
    
        public virtual BenchmarkOptionsConfig All(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-all",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BenchmarkOptionsConfig) this;
        }

        
    
        public virtual BenchmarkOptionsConfig Allcompile(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-allcompile",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BenchmarkOptionsConfig) this;
        }

        
    
        public virtual BenchmarkOptionsConfig Preview(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-preview",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BenchmarkOptionsConfig) this;
        }

        
    
        public virtual BenchmarkOptionsConfig Ue4(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-ue4",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4,
                        AllowMultiple: true
                    )
                ));
            }
            return (BenchmarkOptionsConfig) this;
        }

        
    
        public virtual BenchmarkOptionsConfig Editor(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-editor",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BenchmarkOptionsConfig) this;
        }

        
    
        public virtual BenchmarkOptionsConfig Client(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-client",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BenchmarkOptionsConfig) this;
        }

        
    
        public virtual BenchmarkOptionsConfig Nopcompile(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-nopcompile",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BenchmarkOptionsConfig) this;
        }

        
    
        public virtual BenchmarkOptionsConfig Singlecompile(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-singlecompile",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BenchmarkOptionsConfig) this;
        }

        
    
        public virtual BenchmarkOptionsConfig Xge(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-xge",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4,
                        AllowMultiple: true
                    )
                ));
            }
            return (BenchmarkOptionsConfig) this;
        }

        
    
        public virtual BenchmarkOptionsConfig Fastbuild(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-fastbuild",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4,
                        AllowMultiple: true
                    )
                ));
            }
            return (BenchmarkOptionsConfig) this;
        }

        
    
        public virtual BenchmarkOptionsConfig Noxge(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-noxge",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4,
                        AllowMultiple: true
                    )
                ));
            }
            return (BenchmarkOptionsConfig) this;
        }

        
    
        public virtual BenchmarkOptionsConfig Nofastbuild(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-nofastbuild",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4,
                        AllowMultiple: true
                    )
                ));
            }
            return (BenchmarkOptionsConfig) this;
        }

        
    
        public virtual BenchmarkOptionsConfig Cook(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-cook",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BenchmarkOptionsConfig) this;
        }

        
    
        public virtual BenchmarkOptionsConfig Pie(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-pie",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BenchmarkOptionsConfig) this;
        }

        
    
        public virtual BenchmarkOptionsConfig Warmddc(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-warmddc",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4,
                        AllowMultiple: true
                    )
                ));
            }
            return (BenchmarkOptionsConfig) this;
        }

        
    
        public virtual BenchmarkOptionsConfig Hotddc(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-hotddc",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4,
                        AllowMultiple: true
                    )
                ));
            }
            return (BenchmarkOptionsConfig) this;
        }

        
    
        public virtual BenchmarkOptionsConfig Coldddc(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-coldddc",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4,
                        AllowMultiple: true
                    )
                ));
            }
            return (BenchmarkOptionsConfig) this;
        }

        
    
        public virtual BenchmarkOptionsConfig Noshaderddc(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-noshaderddc",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4,
                        AllowMultiple: true
                    )
                ));
            }
            return (BenchmarkOptionsConfig) this;
        }

        
    
        public virtual BenchmarkOptionsConfig Iterations(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Iterations",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BenchmarkOptionsConfig) this;
        }

        
    
        public virtual BenchmarkOptionsConfig Wait(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Wait",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BenchmarkOptionsConfig) this;
        }

        
    
        public virtual BenchmarkOptionsConfig CookArgs(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-CookArgs",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4,
                        AllowMultiple: true
                    )
                ));
            }
            return (BenchmarkOptionsConfig) this;
        }

        
    
        public virtual BenchmarkOptionsConfig PIEArgs(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-PIEArgs",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4,
                        AllowMultiple: true
                    )
                ));
            }
            return (BenchmarkOptionsConfig) this;
        }

        
    
        public virtual BenchmarkOptionsConfig FileName(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-filename",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4,
                        AllowMultiple: true
                    )
                ));
            }
            return (BenchmarkOptionsConfig) this;
        }

        
    
        public virtual BenchmarkOptionsConfig Project(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-project",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BenchmarkOptionsConfig) this;
        }

        
    
        public virtual BenchmarkOptionsConfig Projects(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-projects",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BenchmarkOptionsConfig) this;
        }

        
    
        public virtual BenchmarkOptionsConfig Platform(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-platform",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BenchmarkOptionsConfig) this;
        }

        
    
        public virtual BenchmarkOptionsConfig Platforms(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-platforms",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BenchmarkOptionsConfig) this;
        }

        
    
        public virtual BenchmarkOptionsConfig Cores(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-cores",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4 | UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BenchmarkOptionsConfig) this;
        }

        
    
        public virtual BenchmarkOptionsConfig Map(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-map",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE4,
                        AllowMultiple: true
                    )
                ));
            }
            return (BenchmarkOptionsConfig) this;
        }

        
    
        public virtual BenchmarkOptionsConfig AllCook(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-AllCook",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BenchmarkOptionsConfig) this;
        }

        
    
        public virtual BenchmarkOptionsConfig AllEditor(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-AllEditor",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BenchmarkOptionsConfig) this;
        }

        
    
        public virtual BenchmarkOptionsConfig AllClient(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-AllClient",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BenchmarkOptionsConfig) this;
        }

        
    
        public virtual BenchmarkOptionsConfig AllDDC(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-AllDDC",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BenchmarkOptionsConfig) this;
        }

        
    
        public virtual BenchmarkOptionsConfig Unreal(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Unreal",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BenchmarkOptionsConfig) this;
        }

        
    
        public virtual BenchmarkOptionsConfig Compile(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-compile",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BenchmarkOptionsConfig) this;
        }

        
    
        public virtual BenchmarkOptionsConfig CookIterative(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-cook-iterative",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BenchmarkOptionsConfig) this;
        }

        
    
        public virtual BenchmarkOptionsConfig EditorStartup(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-editor-startup",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BenchmarkOptionsConfig) this;
        }

        
    
        public virtual BenchmarkOptionsConfig EditorGame(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-editor-game",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BenchmarkOptionsConfig) this;
        }

        
    
        public virtual BenchmarkOptionsConfig EditorPie(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-editor-pie",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BenchmarkOptionsConfig) this;
        }

        
    
        public virtual BenchmarkOptionsConfig Launch(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Launch",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BenchmarkOptionsConfig) this;
        }

        
    
        public virtual BenchmarkOptionsConfig UBT(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-UBT",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BenchmarkOptionsConfig) this;
        }

        
    
        public virtual BenchmarkOptionsConfig Csv(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-csv",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BenchmarkOptionsConfig) this;
        }

        
    
        public virtual BenchmarkOptionsConfig Noclean(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-noclean",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BenchmarkOptionsConfig) this;
        }

        
    
        public virtual BenchmarkOptionsConfig Nopostclean(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-nopostclean",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (BenchmarkOptionsConfig) this;
        }
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    }

    protected readonly BenchmarkOptionsConfig BenchmarkOptionsStorage = new();
        
    
    public  class MakeCookedEditorConfig : ToolConfig
    {
        public override string Name => "MakeCookedEditor";
        public override string CliName => "MakeCookedEditor";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE5;
    
    
        public virtual MakeCookedEditorConfig Cookedcooker(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-cookedcooker",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (MakeCookedEditorConfig) this;
        }

        
    
        public virtual MakeCookedEditorConfig Makerelease(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-makerelease",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (MakeCookedEditorConfig) this;
        }

        
    
        public virtual MakeCookedEditorConfig CombineBuilds(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-CombineBuilds",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (MakeCookedEditorConfig) this;
        }

        
    
        public virtual MakeCookedEditorConfig BasedOnReleaseVersion(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-BasedOnReleaseVersion",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (MakeCookedEditorConfig) this;
        }

        
    
        public virtual MakeCookedEditorConfig DevelopmentAssetRegistryPlatformOverride(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-DevelopmentAssetRegistryPlatformOverride",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (MakeCookedEditorConfig) this;
        }
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    }

    protected readonly MakeCookedEditorConfig MakeCookedEditorStorage = new();
        
    
    public  class RunUnrealTestsConfig : ToolConfig
    {
        public override string Name => "RunUnrealTests";
        public override string CliName => "RunUnrealTests";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE5;
    
    
        public virtual RunUnrealTestsConfig Log(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-log",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (RunUnrealTestsConfig) this;
        }

        
    
        public virtual RunUnrealTestsConfig Editor(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-editor",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (RunUnrealTestsConfig) this;
        }

        
    
        public virtual RunUnrealTestsConfig Skip(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Skip",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (RunUnrealTestsConfig) this;
        }

        
    
        public virtual RunUnrealTestsConfig Clean(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-clean",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (RunUnrealTestsConfig) this;
        }

        
    
        public virtual RunUnrealTestsConfig Listargs(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-listargs",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (RunUnrealTestsConfig) this;
        }

        
    
        public virtual RunUnrealTestsConfig Listallargs(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-listallargs",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (RunUnrealTestsConfig) this;
        }
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    }

    protected readonly RunUnrealTestsConfig RunUnrealTestsStorage = new();
        
    
    public  class PublishUnrealAutomationTelemetryConfig : ToolConfig
    {
        public override string Name => "PublishUnrealAutomationTelemetry";
        public override string CliName => "PublishUnrealAutomationTelemetry";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE5;
    
/// <summary>Path to the csv file to parse.</summary>
        public virtual PublishUnrealAutomationTelemetryConfig CSVFile(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-CSVFile",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (PublishUnrealAutomationTelemetryConfig) this;
        }

        
/// <summary>Path to a folder containing csv files to parse.</summary>
        public virtual PublishUnrealAutomationTelemetryConfig CSVDirectory(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-CSVDirectory",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (PublishUnrealAutomationTelemetryConfig) this;
        }

        
/// <summary>Optional CSV column mapping. Format is: &lt;target key&gt;:&lt;source key&gt;,...</summary>
        public virtual PublishUnrealAutomationTelemetryConfig CSVMapping(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-CSVMapping",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (PublishUnrealAutomationTelemetryConfig) this;
        }

        
/// <summary>Telemetry configuration to use to publish to Database. Default: UETelemetryStaging.</summary>
        public virtual PublishUnrealAutomationTelemetryConfig TelemetryConfig(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-TelemetryConfig",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (PublishUnrealAutomationTelemetryConfig) this;
        }

        
/// <summary>Path to alternate Database config. Default is TelemetryConfig default.</summary>
        public virtual PublishUnrealAutomationTelemetryConfig DatabaseConfigPath(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-DatabaseConfigPath",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (PublishUnrealAutomationTelemetryConfig) this;
        }

        
/// <summary>Target Project name.</summary>
        public virtual PublishUnrealAutomationTelemetryConfig Project(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Project",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (PublishUnrealAutomationTelemetryConfig) this;
        }

        
/// <summary>Target platform name. Default: current environment platform.</summary>
        public virtual PublishUnrealAutomationTelemetryConfig Platform(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Platform",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (PublishUnrealAutomationTelemetryConfig) this;
        }

        
/// <summary>Target Role name. Default: Editor.</summary>
        public virtual PublishUnrealAutomationTelemetryConfig Role(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Role",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (PublishUnrealAutomationTelemetryConfig) this;
        }

        
/// <summary>Target Branch name. Default: Unknown.</summary>
        public virtual PublishUnrealAutomationTelemetryConfig Branch(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Branch",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (PublishUnrealAutomationTelemetryConfig) this;
        }

        
/// <summary>Target Changelist number. Default: 0.</summary>
        public virtual PublishUnrealAutomationTelemetryConfig Changelist(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Changelist",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (PublishUnrealAutomationTelemetryConfig) this;
        }

        
/// <summary>Target Configuration name. Default: Development.</summary>
        public virtual PublishUnrealAutomationTelemetryConfig Configuration(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Configuration",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (PublishUnrealAutomationTelemetryConfig) this;
        }

        
/// <summary>Http Link to Build Job. Default: %UE_HORDE_JOBID%</summary>
        public virtual PublishUnrealAutomationTelemetryConfig JobLink(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-JobLink",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (PublishUnrealAutomationTelemetryConfig) this;
        }

        
    
        public virtual PublishUnrealAutomationTelemetryConfig CSVFile_(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-CSVFile=",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (PublishUnrealAutomationTelemetryConfig) this;
        }

        
    
        public virtual PublishUnrealAutomationTelemetryConfig CSVDirectory_(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-CSVDirectory=",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (PublishUnrealAutomationTelemetryConfig) this;
        }

        
    
        public virtual PublishUnrealAutomationTelemetryConfig TelemetryConfig_(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-TelemetryConfig=",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (PublishUnrealAutomationTelemetryConfig) this;
        }

        
    
        public virtual PublishUnrealAutomationTelemetryConfig DatabaseConfigPath_(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-DatabaseConfigPath=",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (PublishUnrealAutomationTelemetryConfig) this;
        }

        
    
        public virtual PublishUnrealAutomationTelemetryConfig Project_(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Project=",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (PublishUnrealAutomationTelemetryConfig) this;
        }

        
    
        public virtual PublishUnrealAutomationTelemetryConfig Platform_(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Platform=",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (PublishUnrealAutomationTelemetryConfig) this;
        }

        
    
        public virtual PublishUnrealAutomationTelemetryConfig Branch_(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Branch=",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (PublishUnrealAutomationTelemetryConfig) this;
        }

        
    
        public virtual PublishUnrealAutomationTelemetryConfig Changelist_(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Changelist=",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (PublishUnrealAutomationTelemetryConfig) this;
        }

        
    
        public virtual PublishUnrealAutomationTelemetryConfig Role_(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Role=",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (PublishUnrealAutomationTelemetryConfig) this;
        }

        
    
        public virtual PublishUnrealAutomationTelemetryConfig Configuration_(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Configuration=",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (PublishUnrealAutomationTelemetryConfig) this;
        }

        
    
        public virtual PublishUnrealAutomationTelemetryConfig JobLink_(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-JobLink=",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (PublishUnrealAutomationTelemetryConfig) this;
        }
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    }

    protected readonly PublishUnrealAutomationTelemetryConfig PublishUnrealAutomationTelemetryStorage = new();
        
    
    public  class FetchUnrealAutomationTelemetryConfig : ToolConfig
    {
        public override string Name => "FetchUnrealAutomationTelemetry";
        public override string CliName => "FetchUnrealAutomationTelemetry";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE5;
    
/// <summary>Path of the csv file to save.</summary>
        public virtual FetchUnrealAutomationTelemetryConfig CSVFile(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-CSVFile",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (FetchUnrealAutomationTelemetryConfig) this;
        }

        
/// <summary>Telemetry configuration to use to publish to Database. Default: UETelemetryStaging.</summary>
        public virtual FetchUnrealAutomationTelemetryConfig TelemetryConfig(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-TelemetryConfig",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (FetchUnrealAutomationTelemetryConfig) this;
        }

        
/// <summary>Path to alternate Database config. Default is TelemetryConfig default.</summary>
        public virtual FetchUnrealAutomationTelemetryConfig DatabaseConfigPath(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-DatabaseConfigPath",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (FetchUnrealAutomationTelemetryConfig) this;
        }

        
/// <summary>Target Project name.</summary>
        public virtual FetchUnrealAutomationTelemetryConfig Project(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Project",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (FetchUnrealAutomationTelemetryConfig) this;
        }

        
/// <summary>Target platform name. Default: current environment platform.</summary>
        public virtual FetchUnrealAutomationTelemetryConfig Platform(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Platform",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (FetchUnrealAutomationTelemetryConfig) this;
        }

        
/// <summary>Target Role name. Default: Editor.</summary>
        public virtual FetchUnrealAutomationTelemetryConfig Role(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Role",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (FetchUnrealAutomationTelemetryConfig) this;
        }

        
/// <summary>Target Branch name. Default: Unknown.</summary>
        public virtual FetchUnrealAutomationTelemetryConfig Branch(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Branch",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (FetchUnrealAutomationTelemetryConfig) this;
        }

        
/// <summary>Target Configuration name. Default: Development.</summary>
        public virtual FetchUnrealAutomationTelemetryConfig Configuration(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Configuration",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (FetchUnrealAutomationTelemetryConfig) this;
        }

        
/// <summary>Filter fetch data from the last 'Since' time. Default: 1month.</summary>
        public virtual FetchUnrealAutomationTelemetryConfig Since(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Since",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (FetchUnrealAutomationTelemetryConfig) this;
        }

        
/// <summary>Filter fetch by TestName. Support coma separated list.</summary>
        public virtual FetchUnrealAutomationTelemetryConfig TestName(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-TestName",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (FetchUnrealAutomationTelemetryConfig) this;
        }

        
/// <summary>Filter fetch by DataPoint. Support coma separated list.</summary>
        public virtual FetchUnrealAutomationTelemetryConfig DataPoint(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-DataPoint",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (FetchUnrealAutomationTelemetryConfig) this;
        }

        
/// <summary>Filter fetch by Context. Support coma separated list.</summary>
        public virtual FetchUnrealAutomationTelemetryConfig Context(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Context",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (FetchUnrealAutomationTelemetryConfig) this;
        }

        
    
        public virtual FetchUnrealAutomationTelemetryConfig CSVFile_(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-CSVFile=",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (FetchUnrealAutomationTelemetryConfig) this;
        }

        
    
        public virtual FetchUnrealAutomationTelemetryConfig TelemetryConfig_(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-TelemetryConfig=",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (FetchUnrealAutomationTelemetryConfig) this;
        }

        
    
        public virtual FetchUnrealAutomationTelemetryConfig DatabaseConfigPath_(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-DatabaseConfigPath=",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (FetchUnrealAutomationTelemetryConfig) this;
        }

        
    
        public virtual FetchUnrealAutomationTelemetryConfig Project_(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Project=",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (FetchUnrealAutomationTelemetryConfig) this;
        }

        
    
        public virtual FetchUnrealAutomationTelemetryConfig Platform_(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Platform=",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (FetchUnrealAutomationTelemetryConfig) this;
        }

        
    
        public virtual FetchUnrealAutomationTelemetryConfig Branch_(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Branch=",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (FetchUnrealAutomationTelemetryConfig) this;
        }

        
    
        public virtual FetchUnrealAutomationTelemetryConfig Role_(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Role=",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (FetchUnrealAutomationTelemetryConfig) this;
        }

        
    
        public virtual FetchUnrealAutomationTelemetryConfig Configuration_(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Configuration=",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (FetchUnrealAutomationTelemetryConfig) this;
        }

        
    
        public virtual FetchUnrealAutomationTelemetryConfig Since_(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Since=",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (FetchUnrealAutomationTelemetryConfig) this;
        }

        
    
        public virtual FetchUnrealAutomationTelemetryConfig TestName_(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-TestName=",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (FetchUnrealAutomationTelemetryConfig) this;
        }

        
    
        public virtual FetchUnrealAutomationTelemetryConfig DataPoint_(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-DataPoint=",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (FetchUnrealAutomationTelemetryConfig) this;
        }

        
    
        public virtual FetchUnrealAutomationTelemetryConfig Context_(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Context=",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (FetchUnrealAutomationTelemetryConfig) this;
        }
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    }

    protected readonly FetchUnrealAutomationTelemetryConfig FetchUnrealAutomationTelemetryStorage = new();
        
    
    public  class RunLowLevelTestsConfig : ToolConfig
    {
        public override string Name => "RunLowLevelTests";
        public override string CliName => "RunLowLevelTests";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE5;
    
    
        public virtual RunLowLevelTestsConfig Clean(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-clean",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (RunLowLevelTestsConfig) this;
        }
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    }

    protected readonly RunLowLevelTestsConfig RunLowLevelTestsStorage = new();
        
    
    public  class VS2017TargetPlatform_Win64Config : ToolConfig
    {
        public override string Name => "VS2017TargetPlatform_Win64";
        public override string CliName => "VS2017TargetPlatform_Win64";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE5;
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    }

    protected readonly VS2017TargetPlatform_Win64Config VS2017TargetPlatform_Win64Storage = new();
        
    
    public  class VS2019TargetPlatform_Win64Config : ToolConfig
    {
        public override string Name => "VS2019TargetPlatform_Win64";
        public override string CliName => "VS2019TargetPlatform_Win64";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE5;
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    }

    protected readonly VS2019TargetPlatform_Win64Config VS2019TargetPlatform_Win64Storage = new();
        
    
    public  class VS2022TargetPlatform_Win64Config : ToolConfig
    {
        public override string Name => "VS2022TargetPlatform_Win64";
        public override string CliName => "VS2022TargetPlatform_Win64";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE5;
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    }

    protected readonly VS2022TargetPlatform_Win64Config VS2022TargetPlatform_Win64Storage = new();
        
    
    public  class NMakeTargetPlatform_Win64Config : ToolConfig
    {
        public override string Name => "NMakeTargetPlatform_Win64";
        public override string CliName => "NMakeTargetPlatform_Win64";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE5;
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    }

    protected readonly NMakeTargetPlatform_Win64Config NMakeTargetPlatform_Win64Storage = new();
        
    
    public  class MakefileTargetPlatform_Win64Config : ToolConfig
    {
        public override string Name => "MakefileTargetPlatform_Win64";
        public override string CliName => "MakefileTargetPlatform_Win64";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE5;
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    }

    protected readonly MakefileTargetPlatform_Win64Config MakefileTargetPlatform_Win64Storage = new();
        
    
    public  class NMakeTargetPlatform_UnixConfig : ToolConfig
    {
        public override string Name => "NMakeTargetPlatform_Unix";
        public override string CliName => "NMakeTargetPlatform_Unix";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE5;
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    }

    protected readonly NMakeTargetPlatform_UnixConfig NMakeTargetPlatform_UnixStorage = new();
        
    
    public  class MakefileTargetPlatform_UnixConfig : ToolConfig
    {
        public override string Name => "MakefileTargetPlatform_Unix";
        public override string CliName => "MakefileTargetPlatform_Unix";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE5;
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    }

    protected readonly MakefileTargetPlatform_UnixConfig MakefileTargetPlatform_UnixStorage = new();
        
    
    public  class NMakeTargetPlatform_LinuxConfig : ToolConfig
    {
        public override string Name => "NMakeTargetPlatform_Linux";
        public override string CliName => "NMakeTargetPlatform_Linux";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE5;
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    }

    protected readonly NMakeTargetPlatform_LinuxConfig NMakeTargetPlatform_LinuxStorage = new();
        
    
    public  class MakefileTargetPlatform_LinuxConfig : ToolConfig
    {
        public override string Name => "MakefileTargetPlatform_Linux";
        public override string CliName => "MakefileTargetPlatform_Linux";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE5;
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    }

    protected readonly MakefileTargetPlatform_LinuxConfig MakefileTargetPlatform_LinuxStorage = new();
        
    
    public  class XcodeTargetPlatform_MacConfig : ToolConfig
    {
        public override string Name => "XcodeTargetPlatform_Mac";
        public override string CliName => "XcodeTargetPlatform_Mac";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE5;
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    }

    protected readonly XcodeTargetPlatform_MacConfig XcodeTargetPlatform_MacStorage = new();
        
    
    public  class MakefileTargetPlatform_MacConfig : ToolConfig
    {
        public override string Name => "MakefileTargetPlatform_Mac";
        public override string CliName => "MakefileTargetPlatform_Mac";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE5;
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    }

    protected readonly MakefileTargetPlatform_MacConfig MakefileTargetPlatform_MacStorage = new();
        
    
    public  class XcodeTargetPlatform_TVOSConfig : ToolConfig
    {
        public override string Name => "XcodeTargetPlatform_TVOS";
        public override string CliName => "XcodeTargetPlatform_TVOS";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE5;
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    }

    protected readonly XcodeTargetPlatform_TVOSConfig XcodeTargetPlatform_TVOSStorage = new();
        
    
    public  class MakefileTargetPlatform_TVOSConfig : ToolConfig
    {
        public override string Name => "MakefileTargetPlatform_TVOS";
        public override string CliName => "MakefileTargetPlatform_TVOS";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE5;
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    }

    protected readonly MakefileTargetPlatform_TVOSConfig MakefileTargetPlatform_TVOSStorage = new();
        
    
    public  class NMakeTargetPlatform_AndroidConfig : ToolConfig
    {
        public override string Name => "NMakeTargetPlatform_Android";
        public override string CliName => "NMakeTargetPlatform_Android";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE5;
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    }

    protected readonly NMakeTargetPlatform_AndroidConfig NMakeTargetPlatform_AndroidStorage = new();
        
    
    public  class MakefileTargetPlatform_AndroidConfig : ToolConfig
    {
        public override string Name => "MakefileTargetPlatform_Android";
        public override string CliName => "MakefileTargetPlatform_Android";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE5;
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    }

    protected readonly MakefileTargetPlatform_AndroidConfig MakefileTargetPlatform_AndroidStorage = new();
        
    
    public  class VS2019TargetPlatform_AndroidConfig : ToolConfig
    {
        public override string Name => "VS2019TargetPlatform_Android";
        public override string CliName => "VS2019TargetPlatform_Android";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE5;
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    }

    protected readonly VS2019TargetPlatform_AndroidConfig VS2019TargetPlatform_AndroidStorage = new();
        
    
    public  class CreateComponentZipsConfig : ToolConfig
    {
        public override string Name => "CreateComponentZips";
        public override string CliName => "CreateComponentZips";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE5;
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    }

    protected readonly CreateComponentZipsConfig CreateComponentZipsStorage = new();
        
/// <summary>Create stub code for platform extension</summary>
    public  class CreatePlatformExtensionConfig : ToolConfig
    {
        public override string Name => "CreatePlatformExtension";
        public override string CliName => "CreatePlatformExtension";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE5;
    
/// <summary>Path to source .uplugin, .build.cs or .target.cs, or a source folder to search</summary>
        public virtual CreatePlatformExtensionConfig Source(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Source",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (CreatePlatformExtensionConfig) this;
        }

        
/// <summary>Platform(s) or Platform Groups to generate for</summary>
        public virtual CreatePlatformExtensionConfig Platform(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Platform",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (CreatePlatformExtensionConfig) this;
        }

        
/// <summary>Optional path to project (only required if not creating code for Engine modules/plugins</summary>
        public virtual CreatePlatformExtensionConfig Project(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Project",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (CreatePlatformExtensionConfig) this;
        }

        
/// <summary>Do not generate platform extension module files when generating a platform extension plugin</summary>
        public virtual CreatePlatformExtensionConfig SkipPluginModules(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-SkipPluginModules",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (CreatePlatformExtensionConfig) this;
        }

        
/// <summary>If target files already exist they'll be overwritten rather than skipped</summary>
        public virtual CreatePlatformExtensionConfig AllowOverwrite(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-AllowOverwrite",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (CreatePlatformExtensionConfig) this;
        }

        
/// <summary>Allow platform &amp; platform groups that are not known, for example when generating code for extensions we do not have access to</summary>
        public virtual CreatePlatformExtensionConfig AllowUnknownPlatforms(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-AllowUnknownPlatforms",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (CreatePlatformExtensionConfig) this;
        }

        
/// <summary>When creating a platform extension from another platform extension, use the source platform as the parent</summary>
        public virtual CreatePlatformExtensionConfig AllowPlatformExtensionsAsParents(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-AllowPlatformExtensionsAsParents",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (CreatePlatformExtensionConfig) this;
        }

        
/// <summary>Create a changelist for the new files
/// Enables Perforce functionality {default if run on a build machine}</summary>
        public virtual CreatePlatformExtensionConfig P4(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-P4",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (CreatePlatformExtensionConfig) this;
        }

        
/// <summary>Override the changelist #</summary>
        public virtual CreatePlatformExtensionConfig CL(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-CL",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (CreatePlatformExtensionConfig) this;
        }

        
    
        public virtual CreatePlatformExtensionConfig DebugTest(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-DebugTest",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (CreatePlatformExtensionConfig) this;
        }

        
/// <summary>Enables verbose logging</summary>
        public virtual CreatePlatformExtensionConfig Verbose(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Verbose",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (CreatePlatformExtensionConfig) this;
        }

        
/// <summary>Enables very verbose logging</summary>
        public virtual CreatePlatformExtensionConfig VeryVerbose(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-VeryVerbose",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (CreatePlatformExtensionConfig) this;
        }

        
    
        public virtual CreatePlatformExtensionConfig TimeStamps(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-TimeStamps",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (CreatePlatformExtensionConfig) this;
        }

        
/// <summary>Allows UAT command to submit changes</summary>
        public virtual CreatePlatformExtensionConfig Submit(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Submit",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (CreatePlatformExtensionConfig) this;
        }

        
/// <summary>Prevents any submit attempts</summary>
        public virtual CreatePlatformExtensionConfig NoSubmit(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-NoSubmit",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (CreatePlatformExtensionConfig) this;
        }

        
/// <summary>Disables Perforce functionality {default if not run on a build machine}</summary>
        public virtual CreatePlatformExtensionConfig NoP4(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-NoP4",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (CreatePlatformExtensionConfig) this;
        }

        
    
        public virtual CreatePlatformExtensionConfig IgnoreDependencies(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-IgnoreDependencies",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (CreatePlatformExtensionConfig) this;
        }

        
/// <summary>Displays help</summary>
        public virtual CreatePlatformExtensionConfig Help(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Help",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (CreatePlatformExtensionConfig) this;
        }

        
/// <summary>Lists all available commands</summary>
        public virtual CreatePlatformExtensionConfig List(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-List",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (CreatePlatformExtensionConfig) this;
        }

        
/// <summary>Does not kill any spawned processes on exit</summary>
        public virtual CreatePlatformExtensionConfig NoKill(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-NoKill",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (CreatePlatformExtensionConfig) this;
        }

        
    
        public virtual CreatePlatformExtensionConfig UTF8Output(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-UTF8Output",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (CreatePlatformExtensionConfig) this;
        }

        
    
        public virtual CreatePlatformExtensionConfig AllowStdOutLogVerbosity(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-AllowStdOutLogVerbosity",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (CreatePlatformExtensionConfig) this;
        }

        
    
        public virtual CreatePlatformExtensionConfig NoAutoSDK(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-NoAutoSDK",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (CreatePlatformExtensionConfig) this;
        }

        
/// <summary>Force all script modules to be compiled</summary>
        public virtual CreatePlatformExtensionConfig Compile(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Compile",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (CreatePlatformExtensionConfig) this;
        }

        
/// <summary>Do not attempt to compile any script modules - attempts to run with whatever is up to date</summary>
        public virtual CreatePlatformExtensionConfig NoCompile(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-NoCompile",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (CreatePlatformExtensionConfig) this;
        }

        
/// <summary>Ignore build records (Intermediate/ScriptModule/ProjectName.json) files when determining if script modules are up to date</summary>
        public virtual CreatePlatformExtensionConfig IgnoreBuildRecords(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-IgnoreBuildRecords",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (CreatePlatformExtensionConfig) this;
        }

        
/// <summary>Allows you to use local storage for your root build storage dir {default of P:\Builds {on PC} is changed to Engine\Saved\LocalBuilds}. Used for local testing.</summary>
        public virtual CreatePlatformExtensionConfig UseLocalBuildStorage(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-UseLocalBuildStorage",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (CreatePlatformExtensionConfig) this;
        }

        
/// <summary>Waits for a debugger to be attached, and breaks once debugger successfully attached.</summary>
        public virtual CreatePlatformExtensionConfig WaitForDebugger(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-WaitForDebugger",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (CreatePlatformExtensionConfig) this;
        }

        
    
        public virtual CreatePlatformExtensionConfig BuildMachine(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-BuildMachine",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (CreatePlatformExtensionConfig) this;
        }

        
    
        public virtual CreatePlatformExtensionConfig WaitForUATMutex(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-WaitForUATMutex",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (CreatePlatformExtensionConfig) this;
        }
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    }

    protected readonly CreatePlatformExtensionConfig CreatePlatformExtensionStorage = new();
        
/// <summary>Downloads a build from Jupiter</summary>
    public  class DownloadJupiterBuildConfig : ToolConfig
    {
        public override string Name => "DownloadJupiterBuild";
        public override string CliName => "DownloadJupiterBuild";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE5;
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    }

    protected readonly DownloadJupiterBuildConfig DownloadJupiterBuildStorage = new();
        
/// <summary>Generates a report about all platforms and their configuration settings.</summary>
    public  class GeneratePlatformReportConfig : ToolConfig
    {
        public override string Name => "GeneratePlatformReport";
        public override string CliName => "GeneratePlatformReport";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE5;
    
/// <summary>Limit report to these platforms. e.g. Windows+iOS. Default is all platforms</summary>
        public virtual GeneratePlatformReportConfig Platforms(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Platforms",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (GeneratePlatformReportConfig) this;
        }

        
/// <summary>&lt;filename&gt; - Generate a CSV file instead of an html file</summary>
        public virtual GeneratePlatformReportConfig CsvOut(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-CsvOut",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (GeneratePlatformReportConfig) this;
        }

        
/// <summary>ShaderPlatform,DataDrivenPlatformInfo - which config section to check</summary>
        public virtual GeneratePlatformReportConfig DDPISection(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-DDPISection",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (GeneratePlatformReportConfig) this;
        }

        
/// <summary>Use field names instead of friendly names</summary>
        public virtual GeneratePlatformReportConfig UseFieldNames(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-UseFieldNames",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (GeneratePlatformReportConfig) this;
        }

        
/// <summary>Opens the html report once it has been generated</summary>
        public virtual GeneratePlatformReportConfig OpenReport(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-OpenReport",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (GeneratePlatformReportConfig) this;
        }
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    }

    protected readonly GeneratePlatformReportConfig GeneratePlatformReportStorage = new();
        
/// <summary>MemreportToHelper is used to take a memreport file, extract the CSV sections and generate a GSheet from them (i.e:RunUAT.bat MemReportToGSheet -report=myFile.memreport -name=SheetName (optional)</summary>
    public  class MemreportHelperConfig : ToolConfig
    {
        public override string Name => "MemreportHelper";
        public override string CliName => "MemreportHelper";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE5;
    
    
        public virtual MemreportHelperConfig Report(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-report",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (MemreportHelperConfig) this;
        }

        
    
        public virtual MemreportHelperConfig Outcsvdir(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-outcsvdir",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (MemreportHelperConfig) this;
        }

        
    
        public virtual MemreportHelperConfig Maxoutputcount(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-maxoutputcount",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (MemreportHelperConfig) this;
        }

        
    
        public virtual MemreportHelperConfig Minkblim(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-minkblim",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (MemreportHelperConfig) this;
        }
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    }

    protected readonly MemreportHelperConfig MemreportHelperStorage = new();
        
/// <summary>Execute a World Partition builder</summary>
    public  class WorldPartitionBuilderConfig : ToolConfig
    {
        public override string Name => "WorldPartitionBuilder";
        public override string CliName => "WorldPartitionBuilder";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE5;
    
/// <summary>Name of the builder to run</summary>
        public virtual WorldPartitionBuilderConfig Builder(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Builder",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (WorldPartitionBuilderConfig) this;
        }

        
/// <summary>Arguments to provide to the builder commandlet</summary>
        public virtual WorldPartitionBuilderConfig CommandletArgs(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-CommandletArgs",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (WorldPartitionBuilderConfig) this;
        }

        
/// <summary>If the files modified by the builder should be submitted at the end of the process</summary>
        public virtual WorldPartitionBuilderConfig Submit(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Submit",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (WorldPartitionBuilderConfig) this;
        }

        
/// <summary>If provided (along with -ShelveWorkspace, modified files will be shelved for the P4 User in the specified Workspace.</summary>
        public virtual WorldPartitionBuilderConfig ShelveUser(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-ShelveUser",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (WorldPartitionBuilderConfig) this;
        }

        
/// <summary>If provided (along with -ShelveUser, modified files will be shelved for the P4 User in the specified Workspace.</summary>
        public virtual WorldPartitionBuilderConfig ShelveWorkspace(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-ShelveWorkspace",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (WorldPartitionBuilderConfig) this;
        }
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    }

    protected readonly WorldPartitionBuilderConfig WorldPartitionBuilderStorage = new();
        
    
    public  class TurnkeyConfig : ToolConfig
    {
        public override string Name => "Turnkey";
        public override string CliName => "Turnkey";
        public override UnrealCompatibility Compatibility => UnrealCompatibility.UE5;
    
    
        public virtual TurnkeyConfig EditorIOPort(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-EditorIOPort",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (TurnkeyConfig) this;
        }

        
    
        public virtual TurnkeyConfig EditorIO(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-EditorIO",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (TurnkeyConfig) this;
        }

        
    
        public virtual TurnkeyConfig ReportFilename(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-ReportFilename",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (TurnkeyConfig) this;
        }

        
    
        public virtual TurnkeyConfig Project(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Project",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (TurnkeyConfig) this;
        }

        
    
        public virtual TurnkeyConfig Project_(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Project=",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (TurnkeyConfig) this;
        }

        
    
        public virtual TurnkeyConfig Command(params object[] values)
        {
            if (true)
            {
                AppendArgument(new UnrealToolArgument(
                    "-Command",
                    Value: values != null && values.Length > 0 ? string.Join("+", values) : null,
                    Setter: '=',
                    Meta: new(
                        Compatibility: UnrealCompatibility.UE5,
                        AllowMultiple: true
                    )
                ));
            }
            return (TurnkeyConfig) this;
        }
    
    
        private ToolConfig[] _configs = null;
        protected override ToolConfig[] Configs => _configs ??= new ToolConfig[]
        {
        };
    }

    protected readonly TurnkeyConfig TurnkeyStorage = new();

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
                UnrealBuildStorage,
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
                UnrealBuildUtilDummyBuildCommandStorage,
                UpdateLocalVersionStorage,
                UploadDDCToAWSStorage,
                ZipUtilsStorage,
                BenchmarkBuildStorage,
                BenchmarkOptionsStorage,
                MakeCookedEditorStorage,
                RunUnrealTestsStorage,
                PublishUnrealAutomationTelemetryStorage,
                FetchUnrealAutomationTelemetryStorage,
                RunLowLevelTestsStorage,
                VS2017TargetPlatform_Win64Storage,
                VS2019TargetPlatform_Win64Storage,
                VS2022TargetPlatform_Win64Storage,
                NMakeTargetPlatform_Win64Storage,
                MakefileTargetPlatform_Win64Storage,
                NMakeTargetPlatform_UnixStorage,
                MakefileTargetPlatform_UnixStorage,
                NMakeTargetPlatform_LinuxStorage,
                MakefileTargetPlatform_LinuxStorage,
                XcodeTargetPlatform_MacStorage,
                MakefileTargetPlatform_MacStorage,
                XcodeTargetPlatform_TVOSStorage,
                MakefileTargetPlatform_TVOSStorage,
                NMakeTargetPlatform_AndroidStorage,
                MakefileTargetPlatform_AndroidStorage,
                VS2019TargetPlatform_AndroidStorage,
                CreateComponentZipsStorage,
                CreatePlatformExtensionStorage,
                DownloadJupiterBuildStorage,
                GeneratePlatformReportStorage,
                MemreportHelperStorage,
                WorldPartitionBuilderStorage,
                TurnkeyStorage,
            };

    public UatConfig Program(Action<ProgramConfig> configurator)
    {
        configurator?.Invoke(ProgramStorage);
        AppendSubtool(ProgramStorage);
        return (UatConfig) this;
    }
/// <summary>Executes scripted commands
/// 
/// AutomationTool.exe [-verbose] [-compileonly] [-p4] Command0 [-Arg0 -Arg1 -Arg2 ...] Command1 [-Arg0 -Arg1 ...] Command2 [-Arg0 ...] Commandn ... [EnvVar0=MyValue0 ... EnvVarn=MyValuen]</summary>
    public UatConfig Automation(Action<AutomationConfig> configurator)
    {
        configurator?.Invoke(AutomationStorage);
        AppendSubtool(AutomationStorage);
        return (UatConfig) this;
    }

    public UatConfig CodeSign(Action<CodeSignConfig> configurator)
    {
        configurator?.Invoke(CodeSignStorage);
        AppendSubtool(CodeSignStorage);
        return (UatConfig) this;
    }

    public UatConfig McpConfigMapper(Action<McpConfigMapperConfig> configurator)
    {
        configurator?.Invoke(McpConfigMapperStorage);
        AppendSubtool(McpConfigMapperStorage);
        return (UatConfig) this;
    }

    public UatConfig P4Environment(Action<P4EnvironmentConfig> configurator)
    {
        configurator?.Invoke(P4EnvironmentStorage);
        AppendSubtool(P4EnvironmentStorage);
        return (UatConfig) this;
    }
/// <summary>Auto-detects P4 settings based on the current path and creates a p4config file with the relevant settings.</summary>
    public UatConfig P4WriteConfig(Action<P4WriteConfigConfig> configurator)
    {
        configurator?.Invoke(P4WriteConfigStorage);
        AppendSubtool(P4WriteConfigStorage);
        return (UatConfig) this;
    }
/// <summary>Iteratively cook from a shared cooked build
/// Iteratively cook from a shared cooked build</summary>
    public UatConfig ProjectParams(Action<ProjectParamsConfig> configurator)
    {
        configurator?.Invoke(ProjectParamsStorage);
        AppendSubtool(ProjectParamsStorage);
        return (UatConfig) this;
    }

    public UatConfig UnrealBuild(Action<UnrealBuildConfig> configurator)
    {
        configurator?.Invoke(UnrealBuildStorage);
        AppendSubtool(UnrealBuildStorage);
        return (UatConfig) this;
    }
/// <summary>Builds the specified targets and configurations for the specified project.
/// Example BuildTarget -project=QAGame -target=Editor+Game -platform=PS4+XboxOne -configuration=Development.
/// Note: Editor will only ever build for the current platform in a Development config and required tools will be included
/// Builds the specified targets and configurations for the specified project.
/// Example BuildTarget -project=QAGame -target=Editor+Game -platform=Win64+Android -configuration=Development.
/// Note: Editor will only ever build for the current platform in a Development config and required tools will be included</summary>
    public UatConfig BuildTarget(Action<BuildTargetConfig> configurator)
    {
        configurator?.Invoke(BuildTargetStorage);
        AppendSubtool(BuildTargetStorage);
        return (UatConfig) this;
    }
/// <summary>Tool for creating extensible build processes in UE4 which can be run locally or in parallel across a build farm.
/// Tool for creating extensible build processes in UE which can be run locally or in parallel across a build farm.</summary>
    public UatConfig BuildGraph(Action<BuildGraphConfig> configurator)
    {
        configurator?.Invoke(BuildGraphStorage);
        AppendSubtool(BuildGraphStorage);
        return (UatConfig) this;
    }

    public UatConfig Build(Action<BuildConfig> configurator)
    {
        configurator?.Invoke(BuildStorage);
        AppendSubtool(BuildStorage);
        return (UatConfig) this;
    }

    public UatConfig TempStorageTests(Action<TempStorageTestsConfig> configurator)
    {
        configurator?.Invoke(TempStorageTestsStorage);
        AppendSubtool(TempStorageTestsStorage);
        return (UatConfig) this;
    }
/// <summary>Removes folders in a given temp storage directory that are older than a certain time.</summary>
    public UatConfig CleanTempStorage(Action<CleanTempStorageConfig> configurator)
    {
        configurator?.Invoke(CleanTempStorageStorage);
        AppendSubtool(CleanTempStorageStorage);
        return (UatConfig) this;
    }

    public UatConfig TestGauntlet(Action<TestGauntletConfig> configurator)
    {
        configurator?.Invoke(TestGauntletStorage);
        AppendSubtool(TestGauntletStorage);
        return (UatConfig) this;
    }
/// <summary>Run Unreal tests using Gauntlet</summary>
    public UatConfig RunUnreal(Action<RunUnrealConfig> configurator)
    {
        configurator?.Invoke(RunUnrealStorage);
        AppendSubtool(RunUnrealStorage);
        return (UatConfig) this;
    }
/// <summary>Creates an IPA from an xarchive file</summary>
    public UatConfig ExportIPAFromArchive(Action<ExportIPAFromArchiveConfig> configurator)
    {
        configurator?.Invoke(ExportIPAFromArchiveStorage);
        AppendSubtool(ExportIPAFromArchiveStorage);
        return (UatConfig) this;
    }
/// <summary>Creates an IPA from an xarchive file</summary>
    public UatConfig MakeIPA(Action<MakeIPAConfig> configurator)
    {
        configurator?.Invoke(MakeIPAStorage);
        AppendSubtool(MakeIPAStorage);
        return (UatConfig) this;
    }
/// <summary>Pulls a value from an ini file and inserts it into a plist.
/// Note currently only looks at values irrespective of sections!</summary>
    public UatConfig WriteIniValueToPlist(Action<WriteIniValueToPlistConfig> configurator)
    {
        configurator?.Invoke(WriteIniValueToPlistStorage);
        AppendSubtool(WriteIniValueToPlistStorage);
        return (UatConfig) this;
    }

    public UatConfig OneSkyLocalizationProvider(Action<OneSkyLocalizationProviderConfig> configurator)
    {
        configurator?.Invoke(OneSkyLocalizationProviderStorage);
        AppendSubtool(OneSkyLocalizationProviderStorage);
        return (UatConfig) this;
    }
/// <summary>Analyzes third party libraries</summary>
    public UatConfig AnalyzeThirdPartyLibs(Action<AnalyzeThirdPartyLibsConfig> configurator)
    {
        configurator?.Invoke(AnalyzeThirdPartyLibsStorage);
        AppendSubtool(AnalyzeThirdPartyLibsStorage);
        return (UatConfig) this;
    }
/// <summary>BlameKeyword command. Looks for the specified keywords in all files at the specified path and finds who added them based on P4 history</summary>
/// <remarks>WARNING: This command might require Perforce</remarks>
    public UatConfig BlameKeyword(Action<BlameKeywordConfig> configurator)
    {
        configurator?.Invoke(BlameKeywordStorage);
        AppendSubtool(BlameKeywordStorage);
        return (UatConfig) this;
    }

    public UatConfig XcodeTargetPlatform_IOS(Action<XcodeTargetPlatform_IOSConfig> configurator)
    {
        configurator?.Invoke(XcodeTargetPlatform_IOSStorage);
        AppendSubtool(XcodeTargetPlatform_IOSStorage);
        return (UatConfig) this;
    }

    public UatConfig MakefileTargetPlatform_IOS(Action<MakefileTargetPlatform_IOSConfig> configurator)
    {
        configurator?.Invoke(MakefileTargetPlatform_IOSStorage);
        AppendSubtool(MakefileTargetPlatform_IOSStorage);
        return (UatConfig) this;
    }
/// <summary>Builds common tools used by the engine which are not part of typical editor or game builds. Useful when syncing source-only on GitHub.</summary>
    public UatConfig BuildCommonTools(Action<BuildCommonToolsConfig> configurator)
    {
        configurator?.Invoke(BuildCommonToolsStorage);
        AppendSubtool(BuildCommonToolsStorage);
        return (UatConfig) this;
    }

    public UatConfig ZipProjectUp(Action<ZipProjectUpConfig> configurator)
    {
        configurator?.Invoke(ZipProjectUpStorage);
        AppendSubtool(ZipProjectUpStorage);
        return (UatConfig) this;
    }
/// <summary>Builds/Cooks/Runs a project.
/// 
/// For non-uprojects project targets are discovered by compiling target rule files found in the project folder.
/// If -map is not specified, the command looks for DefaultMap entry in the project's DefaultEngine.ini and if not found, in BaseEngine.ini.
/// If no DefaultMap can be found, the command falls back to /Engine/Maps/Entry.</summary>
    public UatConfig BuildCookRun(Action<BuildCookRunConfig> configurator)
    {
        configurator?.Invoke(BuildCookRunStorage);
        AppendSubtool(BuildCookRunStorage);
        return (UatConfig) this;
    }

    public UatConfig BuildDerivedDataCache(Action<BuildDerivedDataCacheConfig> configurator)
    {
        configurator?.Invoke(BuildDerivedDataCacheStorage);
        AppendSubtool(BuildDerivedDataCacheStorage);
        return (UatConfig) this;
    }
/// <remarks>WARNING: This command might require Perforce</remarks>
    public UatConfig BuildForUGS(Action<BuildForUGSConfig> configurator)
    {
        configurator?.Invoke(BuildForUGSStorage);
        AppendSubtool(BuildForUGSStorage);
        return (UatConfig) this;
    }
/// <summary>Builds Hlslcc using CMake build system.</summary>
/// <remarks>WARNING: This command might require Perforce</remarks>
    public UatConfig BuildHlslcc(Action<BuildHlslccConfig> configurator)
    {
        configurator?.Invoke(BuildHlslccStorage);
        AppendSubtool(BuildHlslccStorage);
        return (UatConfig) this;
    }

    public UatConfig BuildPhysX_Android(Action<BuildPhysX_AndroidConfig> configurator)
    {
        configurator?.Invoke(BuildPhysX_AndroidStorage);
        AppendSubtool(BuildPhysX_AndroidStorage);
        return (UatConfig) this;
    }

    public UatConfig BuildPhysX_IOS(Action<BuildPhysX_IOSConfig> configurator)
    {
        configurator?.Invoke(BuildPhysX_IOSStorage);
        AppendSubtool(BuildPhysX_IOSStorage);
        return (UatConfig) this;
    }

    public UatConfig BuildPhysX_Linux(Action<BuildPhysX_LinuxConfig> configurator)
    {
        configurator?.Invoke(BuildPhysX_LinuxStorage);
        AppendSubtool(BuildPhysX_LinuxStorage);
        return (UatConfig) this;
    }

    public UatConfig BuildPhysX_Mac_x86_64(Action<BuildPhysX_Mac_x86_64Config> configurator)
    {
        configurator?.Invoke(BuildPhysX_Mac_x86_64Storage);
        AppendSubtool(BuildPhysX_Mac_x86_64Storage);
        return (UatConfig) this;
    }

    public UatConfig BuildPhysX_Mac_arm64(Action<BuildPhysX_Mac_arm64Config> configurator)
    {
        configurator?.Invoke(BuildPhysX_Mac_arm64Storage);
        AppendSubtool(BuildPhysX_Mac_arm64Storage);
        return (UatConfig) this;
    }

    public UatConfig BuildPhysX_Mac(Action<BuildPhysX_MacConfig> configurator)
    {
        configurator?.Invoke(BuildPhysX_MacStorage);
        AppendSubtool(BuildPhysX_MacStorage);
        return (UatConfig) this;
    }

    public UatConfig BuildPhysX_TVOS(Action<BuildPhysX_TVOSConfig> configurator)
    {
        configurator?.Invoke(BuildPhysX_TVOSStorage);
        AppendSubtool(BuildPhysX_TVOSStorage);
        return (UatConfig) this;
    }

    public UatConfig BuildPhysX_Win32(Action<BuildPhysX_Win32Config> configurator)
    {
        configurator?.Invoke(BuildPhysX_Win32Storage);
        AppendSubtool(BuildPhysX_Win32Storage);
        return (UatConfig) this;
    }

    public UatConfig BuildPhysX_Win64(Action<BuildPhysX_Win64Config> configurator)
    {
        configurator?.Invoke(BuildPhysX_Win64Storage);
        AppendSubtool(BuildPhysX_Win64Storage);
        return (UatConfig) this;
    }
/// <summary>Builds a plugin, and packages it for distribution</summary>
    public UatConfig BuildPlugin(Action<BuildPluginConfig> configurator)
    {
        configurator?.Invoke(BuildPluginStorage);
        AppendSubtool(BuildPluginStorage);
        return (UatConfig) this;
    }
/// <summary>Builds the editor for the specified project.
/// Example BuildEditor -project=QAGame
/// Note: Editor will only ever build for the current platform in a Development config and required tools will be included</summary>
    public UatConfig BuildEditor(Action<BuildEditorConfig> configurator)
    {
        configurator?.Invoke(BuildEditorStorage);
        AppendSubtool(BuildEditorStorage);
        return (UatConfig) this;
    }
/// <summary>Builds the game for the specified project.
/// Example BuildGame -project=QAGame -platform=PS4+XboxOne -configuration=Development.
/// Builds the game for the specified project.
/// Example BuildGame -project=QAGame -platform=Win64+Android -configuration=Development.</summary>
    public UatConfig BuildGame(Action<BuildGameConfig> configurator)
    {
        configurator?.Invoke(BuildGameStorage);
        AppendSubtool(BuildGameStorage);
        return (UatConfig) this;
    }
/// <summary>Builds the server for the specified project.
/// Example BuildServer -project=QAGame -platform=Win64 -configuration=Development.</summary>
    public UatConfig BuildServer(Action<BuildServerConfig> configurator)
    {
        configurator?.Invoke(BuildServerStorage);
        AppendSubtool(BuildServerStorage);
        return (UatConfig) this;
    }
/// <summary>Builds third party libraries, and puts them all into a changelist</summary>
/// <remarks>WARNING: This command might require Perforce</remarks>
    public UatConfig BuildThirdPartyLibs(Action<BuildThirdPartyLibsConfig> configurator)
    {
        configurator?.Invoke(BuildThirdPartyLibsStorage);
        AppendSubtool(BuildThirdPartyLibsStorage);
        return (UatConfig) this;
    }
/// <summary>Checks that all source files have balanced macros for enabling/disabling optimization, warnings, etc...</summary>
    public UatConfig CheckBalancedMacros(Action<CheckBalancedMacrosConfig> configurator)
    {
        configurator?.Invoke(CheckBalancedMacrosStorage);
        AppendSubtool(CheckBalancedMacrosStorage);
        return (UatConfig) this;
    }

    public UatConfig CheckCsprojDotNetVersion(Action<CheckCsprojDotNetVersionConfig> configurator)
    {
        configurator?.Invoke(CheckCsprojDotNetVersionStorage);
        AppendSubtool(CheckCsprojDotNetVersionStorage);
        return (UatConfig) this;
    }
/// <summary>Audits the current branch for comments denoting a hack that was not meant to leave another branch, following a given format ("BEGIN XXXX HACK", where XXXX is one or more tags separated by spaces).
/// Allowed tags may be specified manually on the command line. At least one must match, otherwise it will print a warning.
/// The current branch name and fragments of the branch path will also be added by default, so running from //UE4/Main will add "//UE4/Main", "UE4", and "Main".
/// Audits the current branch for comments denoting a hack that was not meant to leave another branch, following a given format ("BEGIN XXXX HACK", where XXXX is one or more tags separated by spaces).
/// Allowed tags may be specified manually on the command line. At least one must match, otherwise it will print a warning.
/// The current branch name and fragments of the branch path will also be added by default, so running from //UE5/Main will add "//UE5/Main", "UE5", and "Main".</summary>
    public UatConfig CheckForHacks(Action<CheckForHacksConfig> configurator)
    {
        configurator?.Invoke(CheckForHacksStorage);
        AppendSubtool(CheckForHacksStorage);
        return (UatConfig) this;
    }
/// <summary>Checks that the casing of files within a path on a case-insensitive Perforce server is correct.</summary>
/// <remarks>WARNING: This command might require Perforce</remarks>
    public UatConfig CheckPerforceCase(Action<CheckPerforceCaseConfig> configurator)
    {
        configurator?.Invoke(CheckPerforceCaseStorage);
        AppendSubtool(CheckPerforceCaseStorage);
        return (UatConfig) this;
    }
/// <summary>Checks a directory for folders which should not be distributed</summary>
    public UatConfig CheckRestrictedFolders(Action<CheckRestrictedFoldersConfig> configurator)
    {
        configurator?.Invoke(CheckRestrictedFoldersStorage);
        AppendSubtool(CheckRestrictedFoldersStorage);
        return (UatConfig) this;
    }
/// <summary>Checks that the given target exists, by looking for the relevant receipt.</summary>
    public UatConfig CheckTargetExists(Action<CheckTargetExistsConfig> configurator)
    {
        configurator?.Invoke(CheckTargetExistsStorage);
        AppendSubtool(CheckTargetExistsStorage);
        return (UatConfig) this;
    }
/// <summary>Checks that the installed Xcode version is the version specified.</summary>
    public UatConfig CheckXcodeVersion(Action<CheckXcodeVersionConfig> configurator)
    {
        configurator?.Invoke(CheckXcodeVersionStorage);
        AppendSubtool(CheckXcodeVersionStorage);
        return (UatConfig) this;
    }
/// <summary>Removes folders in an automation report directory that are older than a certain time.</summary>
    public UatConfig CleanAutomationReports(Action<CleanAutomationReportsConfig> configurator)
    {
        configurator?.Invoke(CleanAutomationReportsStorage);
        AppendSubtool(CleanAutomationReportsStorage);
        return (UatConfig) this;
    }
/// <summary>Removes folders matching a pattern in a given directory that are older than a certain time.</summary>
    public UatConfig CleanFormalBuilds(Action<CleanFormalBuildsConfig> configurator)
    {
        configurator?.Invoke(CleanFormalBuildsStorage);
        AppendSubtool(CleanFormalBuildsStorage);
        return (UatConfig) this;
    }
/// <summary>custom code to restructure C++ source code for the new stats system.</summary>
    public UatConfig CodeSurgery(Action<CodeSurgeryConfig> configurator)
    {
        configurator?.Invoke(CodeSurgeryStorage);
        AppendSubtool(CodeSurgeryStorage);
        return (UatConfig) this;
    }
/// <summary>Copies the current shared cooked build from the network to the local PC</summary>
/// <remarks>WARNING: This command might require Perforce</remarks>
    public UatConfig CopySharedCookedBuild(Action<CopySharedCookedBuildConfig> configurator)
    {
        configurator?.Invoke(CopySharedCookedBuildStorage);
        AppendSubtool(CopySharedCookedBuildStorage);
        return (UatConfig) this;
    }

    public UatConfig CopyUAT(Action<CopyUATConfig> configurator)
    {
        configurator?.Invoke(CopyUATStorage);
        AppendSubtool(CopyUATStorage);
        return (UatConfig) this;
    }

    public UatConfig CryptoKeys(Action<CryptoKeysConfig> configurator)
    {
        configurator?.Invoke(CryptoKeysStorage);
        AppendSubtool(CryptoKeysStorage);
        return (UatConfig) this;
    }

    public UatConfig ExtractPaks(Action<ExtractPaksConfig> configurator)
    {
        configurator?.Invoke(ExtractPaksStorage);
        AppendSubtool(ExtractPaksStorage);
        return (UatConfig) this;
    }
/// <summary>Command to perform additional steps to prepare an installed build.</summary>
    public UatConfig FinalizeInstalledBuild(Action<FinalizeInstalledBuildConfig> configurator)
    {
        configurator?.Invoke(FinalizeInstalledBuildStorage);
        AppendSubtool(FinalizeInstalledBuildStorage);
        return (UatConfig) this;
    }
/// <summary>Fixes the case of files on a case-insensitive Perforce server by removing and re-adding them.</summary>
/// <remarks>WARNING: This command might require Perforce</remarks>
    public UatConfig FixPerforceCase(Action<FixPerforceCaseConfig> configurator)
    {
        configurator?.Invoke(FixPerforceCaseStorage);
        AppendSubtool(FixPerforceCaseStorage);
        return (UatConfig) this;
    }

    public UatConfig FixupRedirects(Action<FixupRedirectsConfig> configurator)
    {
        configurator?.Invoke(FixupRedirectsStorage);
        AppendSubtool(FixupRedirectsStorage);
        return (UatConfig) this;
    }
/// <summary>Generates IOS debug symbols for a remote project.</summary>
    public UatConfig GenerateDSYM(Action<GenerateDSYMConfig> configurator)
    {
        configurator?.Invoke(GenerateDSYMStorage);
        AppendSubtool(GenerateDSYMStorage);
        return (UatConfig) this;
    }
/// <summary>UAT command to call into the integrated IPhonePackager code</summary>
    public UatConfig IPhonePackager(Action<IPhonePackagerConfig> configurator)
    {
        configurator?.Invoke(IPhonePackagerStorage);
        AppendSubtool(IPhonePackagerStorage);
        return (UatConfig) this;
    }

    public UatConfig LauncherLocalization(Action<LauncherLocalizationConfig> configurator)
    {
        configurator?.Invoke(LauncherLocalizationStorage);
        AppendSubtool(LauncherLocalizationStorage);
        return (UatConfig) this;
    }

    public UatConfig ListMobileDevices(Action<ListMobileDevicesConfig> configurator)
    {
        configurator?.Invoke(ListMobileDevicesStorage);
        AppendSubtool(ListMobileDevicesStorage);
        return (UatConfig) this;
    }
/// <summary>Lists TPS files associated with any source used to build a specified target(s). Grabs TPS files associated with source modules, content, and engine shaders.</summary>
    public UatConfig ListThirdPartySoftware(Action<ListThirdPartySoftwareConfig> configurator)
    {
        configurator?.Invoke(ListThirdPartySoftwareStorage);
        AppendSubtool(ListThirdPartySoftwareStorage);
        return (UatConfig) this;
    }
/// <summary>Updates the external localization data using the arguments provided.</summary>
    public UatConfig Localize(Action<LocalizeConfig> configurator)
    {
        configurator?.Invoke(LocalizeStorage);
        AppendSubtool(LocalizeStorage);
        return (UatConfig) this;
    }

    public UatConfig ExportMcpTemplates(Action<ExportMcpTemplatesConfig> configurator)
    {
        configurator?.Invoke(ExportMcpTemplatesStorage);
        AppendSubtool(ExportMcpTemplatesStorage);
        return (UatConfig) this;
    }

    public UatConfig Localise(Action<LocaliseConfig> configurator)
    {
        configurator?.Invoke(LocaliseStorage);
        AppendSubtool(LocaliseStorage);
        return (UatConfig) this;
    }
/// <summary>Opens the specified project.</summary>
    public UatConfig OpenEditor(Action<OpenEditorConfig> configurator)
    {
        configurator?.Invoke(OpenEditorStorage);
        AppendSubtool(OpenEditorStorage);
        return (UatConfig) this;
    }
/// <summary>Parses Visual C++ timing information (as generated by UBT with the -Timing flag), and converts it into JSON format which can be visualized using the chrome://tracing tab</summary>
    public UatConfig ParseMsvcTimingInfo(Action<ParseMsvcTimingInfoConfig> configurator)
    {
        configurator?.Invoke(ParseMsvcTimingInfoStorage);
        AppendSubtool(ParseMsvcTimingInfoStorage);
        return (UatConfig) this;
    }
/// <summary>Rewrites include directives for headers in public include paths to make them relative to the 'Public' folder.</summary>
    public UatConfig RebasePublicIncludePaths(Action<RebasePublicIncludePathsConfig> configurator)
    {
        configurator?.Invoke(RebasePublicIncludePathsStorage);
        AppendSubtool(RebasePublicIncludePathsStorage);
        return (UatConfig) this;
    }
/// <remarks>WARNING: This command might require Perforce</remarks>
    public UatConfig RebuildHLOD(Action<RebuildHLODConfig> configurator)
    {
        configurator?.Invoke(RebuildHLODStorage);
        AppendSubtool(RebuildHLODStorage);
        return (UatConfig) this;
    }
/// <summary>Helper command used for rebuilding a projects light maps</summary>
/// <remarks>WARNING: This command might require Perforce</remarks>
    public UatConfig RebuildLightMaps(Action<RebuildLightMapsConfig> configurator)
    {
        configurator?.Invoke(RebuildLightMapsStorage);
        AppendSubtool(RebuildLightMapsStorage);
        return (UatConfig) this;
    }
/// <summary>UAT command to run performance test demo using different RHIs and compare results</summary>
    public UatConfig RecordPerformance(Action<RecordPerformanceConfig> configurator)
    {
        configurator?.Invoke(RecordPerformanceStorage);
        AppendSubtool(RecordPerformanceStorage);
        return (UatConfig) this;
    }

    public UatConfig ReplaceAssetsUsingManifest(Action<ReplaceAssetsUsingManifestConfig> configurator)
    {
        configurator?.Invoke(ReplaceAssetsUsingManifestStorage);
        AppendSubtool(ReplaceAssetsUsingManifestStorage);
        return (UatConfig) this;
    }
/// <remarks>WARNING: This command might require Perforce</remarks>
    public UatConfig ResavePackages(Action<ResavePackagesConfig> configurator)
    {
        configurator?.Invoke(ResavePackagesStorage);
        AppendSubtool(ResavePackagesStorage);
        return (UatConfig) this;
    }
/// <summary>Re-save all the plugin descriptors under a given path, optionally applying standard metadata to them</summary>
    public UatConfig ResavePluginDescriptors(Action<ResavePluginDescriptorsConfig> configurator)
    {
        configurator?.Invoke(ResavePluginDescriptorsStorage);
        AppendSubtool(ResavePluginDescriptorsStorage);
        return (UatConfig) this;
    }
/// <summary>Re-save all the project descriptors under a given path</summary>
    public UatConfig ResaveProjectDescriptors(Action<ResaveProjectDescriptorsConfig> configurator)
    {
        configurator?.Invoke(ResaveProjectDescriptorsStorage);
        AppendSubtool(ResaveProjectDescriptorsStorage);
        return (UatConfig) this;
    }
/// <remarks>WARNING: This command might require Perforce</remarks>
    public UatConfig RunP4Reconcile(Action<RunP4ReconcileConfig> configurator)
    {
        configurator?.Invoke(RunP4ReconcileStorage);
        AppendSubtool(RunP4ReconcileStorage);
        return (UatConfig) this;
    }
/// <summary>Copy all the binaries for a target into a different folder. Can be restored using the UnstashTarget command. Useful for A/B testing.</summary>
    public UatConfig StashTarget(Action<StashTargetConfig> configurator)
    {
        configurator?.Invoke(StashTargetStorage);
        AppendSubtool(StashTargetStorage);
        return (UatConfig) this;
    }
/// <summary>Copy all the binaries from a target back into the root directory. Use in combination with the StashTarget command.</summary>
    public UatConfig UnstashTarget(Action<UnstashTargetConfig> configurator)
    {
        configurator?.Invoke(UnstashTargetStorage);
        AppendSubtool(UnstashTargetStorage);
        return (UatConfig) this;
    }
/// <summary>Submits a generated Utilization report to EC</summary>
    public UatConfig SubmitUtilizationReportToEC(Action<SubmitUtilizationReportToECConfig> configurator)
    {
        configurator?.Invoke(SubmitUtilizationReportToECStorage);
        AppendSubtool(SubmitUtilizationReportToECStorage);
        return (UatConfig) this;
    }
/// <summary>Attempts to sync UGS binaries for the specified project at the currently synced CL of the project/engine folders</summary>
/// <remarks>WARNING: This command might require Perforce</remarks>
    public UatConfig SyncBinariesFromUGS(Action<SyncBinariesFromUGSConfig> configurator)
    {
        configurator?.Invoke(SyncBinariesFromUGSStorage);
        AppendSubtool(SyncBinariesFromUGSStorage);
        return (UatConfig) this;
    }
/// <summary>Merge one or more remote DDC shares into a local share, taking files with the newest timestamps and keeping the size below a certain limit</summary>
    public UatConfig SyncDDC(Action<SyncDDCConfig> configurator)
    {
        configurator?.Invoke(SyncDDCStorage);
        AppendSubtool(SyncDDCStorage);
        return (UatConfig) this;
    }
/// <summary>Creates a temporary client and syncs a path from Perforce.</summary>
/// <remarks>WARNING: This command might require Perforce</remarks>
    public UatConfig SyncDepotPath(Action<SyncDepotPathConfig> configurator)
    {
        configurator?.Invoke(SyncDepotPathStorage);
        AppendSubtool(SyncDepotPathStorage);
        return (UatConfig) this;
    }
/// <summary>Syncs and builds all the binaries required for a project</summary>
/// <remarks>WARNING: This command might require Perforce</remarks>
    public UatConfig SyncProject(Action<SyncProjectConfig> configurator)
    {
        configurator?.Invoke(SyncProjectStorage);
        AppendSubtool(SyncProjectStorage);
        return (UatConfig) this;
    }
/// <summary>Tests P4 functionality. Runs 'p4 info'.</summary>
/// <remarks>WARNING: This command might require Perforce</remarks>
    public UatConfig TestP4_Info(Action<TestP4_InfoConfig> configurator)
    {
        configurator?.Invoke(TestP4_InfoStorage);
        AppendSubtool(TestP4_InfoStorage);
        return (UatConfig) this;
    }
/// <summary>GitPullRequest</summary>
/// <remarks>WARNING: This command might require Perforce</remarks>
    public UatConfig GitPullRequest(Action<GitPullRequestConfig> configurator)
    {
        configurator?.Invoke(GitPullRequestStorage);
        AppendSubtool(GitPullRequestStorage);
        return (UatConfig) this;
    }
/// <summary>Throws an automation exception.</summary>
    public UatConfig TestFail(Action<TestFailConfig> configurator)
    {
        configurator?.Invoke(TestFailStorage);
        AppendSubtool(TestFailStorage);
        return (UatConfig) this;
    }
/// <summary>Prints a message and returns success.</summary>
    public UatConfig TestSuccess(Action<TestSuccessConfig> configurator)
    {
        configurator?.Invoke(TestSuccessStorage);
        AppendSubtool(TestSuccessStorage);
        return (UatConfig) this;
    }
/// <summary>Prints a message and returns success.</summary>
    public UatConfig TestMessage(Action<TestMessageConfig> configurator)
    {
        configurator?.Invoke(TestMessageStorage);
        AppendSubtool(TestMessageStorage);
        return (UatConfig) this;
    }
/// <summary>Calls UAT recursively with a given command line.</summary>
    public UatConfig TestRecursion(Action<TestRecursionConfig> configurator)
    {
        configurator?.Invoke(TestRecursionStorage);
        AppendSubtool(TestRecursionStorage);
        return (UatConfig) this;
    }
/// <summary>Calls UAT recursively with a given command line.</summary>
    public UatConfig TestRecursionAuto(Action<TestRecursionAutoConfig> configurator)
    {
        configurator?.Invoke(TestRecursionAutoStorage);
        AppendSubtool(TestRecursionAutoStorage);
        return (UatConfig) this;
    }
/// <summary>Makes a zip file in Rocket/QFE</summary>
    public UatConfig TestMacZip(Action<TestMacZipConfig> configurator)
    {
        configurator?.Invoke(TestMacZipStorage);
        AppendSubtool(TestMacZipStorage);
        return (UatConfig) this;
    }
/// <summary>Tests P4 functionality. Creates a new changelist under the workspace %P4CLIENT%</summary>
/// <remarks>WARNING: This command might require Perforce</remarks>
    public UatConfig TestP4_CreateChangelist(Action<TestP4_CreateChangelistConfig> configurator)
    {
        configurator?.Invoke(TestP4_CreateChangelistStorage);
        AppendSubtool(TestP4_CreateChangelistStorage);
        return (UatConfig) this;
    }
/// <remarks>WARNING: This command might require Perforce</remarks>
    public UatConfig TestP4_StrandCheckout(Action<TestP4_StrandCheckoutConfig> configurator)
    {
        configurator?.Invoke(TestP4_StrandCheckoutStorage);
        AppendSubtool(TestP4_StrandCheckoutStorage);
        return (UatConfig) this;
    }
/// <remarks>WARNING: This command might require Perforce</remarks>
    public UatConfig TestP4_LabelDescription(Action<TestP4_LabelDescriptionConfig> configurator)
    {
        configurator?.Invoke(TestP4_LabelDescriptionStorage);
        AppendSubtool(TestP4_LabelDescriptionStorage);
        return (UatConfig) this;
    }
/// <remarks>WARNING: This command might require Perforce</remarks>
    public UatConfig TestP4_ClientOps(Action<TestP4_ClientOpsConfig> configurator)
    {
        configurator?.Invoke(TestP4_ClientOpsStorage);
        AppendSubtool(TestP4_ClientOpsStorage);
        return (UatConfig) this;
    }

    public UatConfig CleanDDC(Action<CleanDDCConfig> configurator)
    {
        configurator?.Invoke(CleanDDCStorage);
        AppendSubtool(CleanDDCStorage);
        return (UatConfig) this;
    }

    public UatConfig TestTestFarm(Action<TestTestFarmConfig> configurator)
    {
        configurator?.Invoke(TestTestFarmStorage);
        AppendSubtool(TestTestFarmStorage);
        return (UatConfig) this;
    }
/// <summary>Test command line argument parsing functions.</summary>
    public UatConfig TestArguments(Action<TestArgumentsConfig> configurator)
    {
        configurator?.Invoke(TestArgumentsStorage);
        AppendSubtool(TestArgumentsStorage);
        return (UatConfig) this;
    }
/// <summary>Checks if combine paths works as excpected</summary>
    public UatConfig TestCombinePaths(Action<TestCombinePathsConfig> configurator)
    {
        configurator?.Invoke(TestCombinePathsStorage);
        AppendSubtool(TestCombinePathsStorage);
        return (UatConfig) this;
    }
/// <summary>Tests file utility functions.</summary>
    public UatConfig TestFileUtility(Action<TestFileUtilityConfig> configurator)
    {
        configurator?.Invoke(TestFileUtilityStorage);
        AppendSubtool(TestFileUtilityStorage);
        return (UatConfig) this;
    }

    public UatConfig TestLog(Action<TestLogConfig> configurator)
    {
        configurator?.Invoke(TestLogStorage);
        AppendSubtool(TestLogStorage);
        return (UatConfig) this;
    }
/// <summary>Tests P4 change filetype functionality.</summary>
/// <remarks>WARNING: This command might require Perforce</remarks>
    public UatConfig TestChangeFileType(Action<TestChangeFileTypeConfig> configurator)
    {
        configurator?.Invoke(TestChangeFileTypeStorage);
        AppendSubtool(TestChangeFileTypeStorage);
        return (UatConfig) this;
    }
/// <summary>Tests if UE4Build properly copies all relevent UAT build products to the Binaries folder.</summary>
    public UatConfig TestUATBuildProducts(Action<TestUATBuildProductsConfig> configurator)
    {
        configurator?.Invoke(TestUATBuildProductsStorage);
        AppendSubtool(TestUATBuildProductsStorage);
        return (UatConfig) this;
    }

    public UatConfig TestOSSCommands(Action<TestOSSCommandsConfig> configurator)
    {
        configurator?.Invoke(TestOSSCommandsStorage);
        AppendSubtool(TestOSSCommandsStorage);
        return (UatConfig) this;
    }
/// <summary>Builds a project using UBT. Syntax is similar to UBT with the exception of '-', i.e. UBT -QAGame -Development -Win32</summary>
    public UatConfig UBT(Action<UBTConfig> configurator)
    {
        configurator?.Invoke(UBTStorage);
        AppendSubtool(UBTStorage);
        return (UatConfig) this;
    }
/// <summary>Helper command to sync only source code + engine files from P4.</summary>
/// <remarks>WARNING: This command might require Perforce</remarks>
    public UatConfig SyncSource(Action<SyncSourceConfig> configurator)
    {
        configurator?.Invoke(SyncSourceStorage);
        AppendSubtool(SyncSourceStorage);
        return (UatConfig) this;
    }
/// <summary>Generates automation project based on a template.</summary>
    public UatConfig GenerateAutomationProject(Action<GenerateAutomationProjectConfig> configurator)
    {
        configurator?.Invoke(GenerateAutomationProjectStorage);
        AppendSubtool(GenerateAutomationProjectStorage);
        return (UatConfig) this;
    }

    public UatConfig DumpBranch(Action<DumpBranchConfig> configurator)
    {
        configurator?.Invoke(DumpBranchStorage);
        AppendSubtool(DumpBranchStorage);
        return (UatConfig) this;
    }
/// <summary>Sleeps for 20 seconds and then exits</summary>
    public UatConfig DebugSleep(Action<DebugSleepConfig> configurator)
    {
        configurator?.Invoke(DebugSleepStorage);
        AppendSubtool(DebugSleepStorage);
        return (UatConfig) this;
    }
/// <summary>Tests if Mcp configs loaded properly.</summary>
    public UatConfig TestMcpConfigs(Action<TestMcpConfigsConfig> configurator)
    {
        configurator?.Invoke(TestMcpConfigsStorage);
        AppendSubtool(TestMcpConfigsStorage);
        return (UatConfig) this;
    }
/// <summary>Test Blame P4 command.</summary>
/// <remarks>WARNING: This command might require Perforce</remarks>
    public UatConfig TestBlame(Action<TestBlameConfig> configurator)
    {
        configurator?.Invoke(TestBlameStorage);
        AppendSubtool(TestBlameStorage);
        return (UatConfig) this;
    }
/// <summary>Test P4 changes.</summary>
/// <remarks>WARNING: This command might require Perforce</remarks>
    public UatConfig TestChanges(Action<TestChangesConfig> configurator)
    {
        configurator?.Invoke(TestChangesStorage);
        AppendSubtool(TestChangesStorage);
        return (UatConfig) this;
    }
/// <summary>Spawns a process to test if UAT kills it automatically.</summary>
    public UatConfig TestKillAll(Action<TestKillAllConfig> configurator)
    {
        configurator?.Invoke(TestKillAllStorage);
        AppendSubtool(TestKillAllStorage);
        return (UatConfig) this;
    }
/// <summary>Tests CleanFormalBuilds.</summary>
    public UatConfig TestCleanFormalBuilds(Action<TestCleanFormalBuildsConfig> configurator)
    {
        configurator?.Invoke(TestCleanFormalBuildsStorage);
        AppendSubtool(TestCleanFormalBuildsStorage);
        return (UatConfig) this;
    }
/// <summary>Spawns a process to test if it can be killed.</summary>
    public UatConfig TestStopProcess(Action<TestStopProcessConfig> configurator)
    {
        configurator?.Invoke(TestStopProcessStorage);
        AppendSubtool(TestStopProcessStorage);
        return (UatConfig) this;
    }
/// <summary>Looks through an XGE xml for overlapping obj files</summary>
    public UatConfig LookForOverlappingBuildProducts(Action<LookForOverlappingBuildProductsConfig> configurator)
    {
        configurator?.Invoke(LookForOverlappingBuildProductsStorage);
        AppendSubtool(LookForOverlappingBuildProductsStorage);
        return (UatConfig) this;
    }
/// <summary>Copies all files from source directory to destination directory using ThreadedCopyFiles</summary>
    public UatConfig TestThreadedCopyFiles(Action<TestThreadedCopyFilesConfig> configurator)
    {
        configurator?.Invoke(TestThreadedCopyFilesStorage);
        AppendSubtool(TestThreadedCopyFilesStorage);
        return (UatConfig) this;
    }

    public UatConfig UnrealBuildUtilDummyBuildCommand(Action<UnrealBuildUtilDummyBuildCommandConfig> configurator)
    {
        configurator?.Invoke(UnrealBuildUtilDummyBuildCommandStorage);
        AppendSubtool(UnrealBuildUtilDummyBuildCommandStorage);
        return (UatConfig) this;
    }
/// <summary>Updates your local versions based on your P4 sync</summary>
/// <remarks>WARNING: This command might require Perforce</remarks>
    public UatConfig UpdateLocalVersion(Action<UpdateLocalVersionConfig> configurator)
    {
        configurator?.Invoke(UpdateLocalVersionStorage);
        AppendSubtool(UpdateLocalVersionStorage);
        return (UatConfig) this;
    }

    public UatConfig UploadDDCToAWS(Action<UploadDDCToAWSConfig> configurator)
    {
        configurator?.Invoke(UploadDDCToAWSStorage);
        AppendSubtool(UploadDDCToAWSStorage);
        return (UatConfig) this;
    }
/// <summary>ZipUtils is used to zip/unzip (i.e:RunUAT.bat ZipUtils -archive=D:/Content.zip -add=D:/UE/Pojects/SampleGame/Content/) or (i.e:RunUAT.bat ZipUtils -archive=D:/Content.zip -extract=D:/UE/Pojects/SampleGame/Content/)</summary>
    public UatConfig ZipUtils(Action<ZipUtilsConfig> configurator)
    {
        configurator?.Invoke(ZipUtilsStorage);
        AppendSubtool(ZipUtilsStorage);
        return (UatConfig) this;
    }
/// <summary>Runs benchmarks and reports overall results
/// Example1: RunUAT BenchmarkBuild -all -project=UE4
/// Example2: RunUAT BenchmarkBuild -allcompile -project=UE4+EngineTest -platform=PS4
/// Example3: RunUAT BenchmarkBuild -editor -client -cook -cooknoshaderddc -cooknoddc -xge -noxge -singlecompile -nopcompile -project=UE4+QAGame+EngineTest -platform=WIn64+PS4+XboxOne+Switch -iterations=3
/// Runs benchmarks and reports overall results
/// Example1: RunUAT BenchmarkBuild -all -project=Unreal
/// Example2: RunUAT BenchmarkBuild -allcompile -project=Unreal+EngineTest -platform=PS4
/// Example3: RunUAT BenchmarkBuild -editor -client -cook -cooknoshaderddc -cooknoddc -xge -noxge -singlecompile -nopcompile -project=Unreal+QAGame+EngineTest -platform=WIn64+PS4+XboxOne+Switch -iterations=3</summary>
    public UatConfig BenchmarkBuild(Action<BenchmarkBuildConfig> configurator)
    {
        configurator?.Invoke(BenchmarkBuildStorage);
        AppendSubtool(BenchmarkBuildStorage);
        return (UatConfig) this;
    }

    public UatConfig BenchmarkOptions(Action<BenchmarkOptionsConfig> configurator)
    {
        configurator?.Invoke(BenchmarkOptionsStorage);
        AppendSubtool(BenchmarkOptionsStorage);
        return (UatConfig) this;
    }

    public UatConfig MakeCookedEditor(Action<MakeCookedEditorConfig> configurator)
    {
        configurator?.Invoke(MakeCookedEditorStorage);
        AppendSubtool(MakeCookedEditorStorage);
        return (UatConfig) this;
    }

    public UatConfig RunUnrealTests(Action<RunUnrealTestsConfig> configurator)
    {
        configurator?.Invoke(RunUnrealTestsStorage);
        AppendSubtool(RunUnrealTestsStorage);
        return (UatConfig) this;
    }

    public UatConfig PublishUnrealAutomationTelemetry(Action<PublishUnrealAutomationTelemetryConfig> configurator)
    {
        configurator?.Invoke(PublishUnrealAutomationTelemetryStorage);
        AppendSubtool(PublishUnrealAutomationTelemetryStorage);
        return (UatConfig) this;
    }

    public UatConfig FetchUnrealAutomationTelemetry(Action<FetchUnrealAutomationTelemetryConfig> configurator)
    {
        configurator?.Invoke(FetchUnrealAutomationTelemetryStorage);
        AppendSubtool(FetchUnrealAutomationTelemetryStorage);
        return (UatConfig) this;
    }

    public UatConfig RunLowLevelTests(Action<RunLowLevelTestsConfig> configurator)
    {
        configurator?.Invoke(RunLowLevelTestsStorage);
        AppendSubtool(RunLowLevelTestsStorage);
        return (UatConfig) this;
    }

    public UatConfig VS2017TargetPlatform_Win64(Action<VS2017TargetPlatform_Win64Config> configurator)
    {
        configurator?.Invoke(VS2017TargetPlatform_Win64Storage);
        AppendSubtool(VS2017TargetPlatform_Win64Storage);
        return (UatConfig) this;
    }

    public UatConfig VS2019TargetPlatform_Win64(Action<VS2019TargetPlatform_Win64Config> configurator)
    {
        configurator?.Invoke(VS2019TargetPlatform_Win64Storage);
        AppendSubtool(VS2019TargetPlatform_Win64Storage);
        return (UatConfig) this;
    }

    public UatConfig VS2022TargetPlatform_Win64(Action<VS2022TargetPlatform_Win64Config> configurator)
    {
        configurator?.Invoke(VS2022TargetPlatform_Win64Storage);
        AppendSubtool(VS2022TargetPlatform_Win64Storage);
        return (UatConfig) this;
    }

    public UatConfig NMakeTargetPlatform_Win64(Action<NMakeTargetPlatform_Win64Config> configurator)
    {
        configurator?.Invoke(NMakeTargetPlatform_Win64Storage);
        AppendSubtool(NMakeTargetPlatform_Win64Storage);
        return (UatConfig) this;
    }

    public UatConfig MakefileTargetPlatform_Win64(Action<MakefileTargetPlatform_Win64Config> configurator)
    {
        configurator?.Invoke(MakefileTargetPlatform_Win64Storage);
        AppendSubtool(MakefileTargetPlatform_Win64Storage);
        return (UatConfig) this;
    }

    public UatConfig NMakeTargetPlatform_Unix(Action<NMakeTargetPlatform_UnixConfig> configurator)
    {
        configurator?.Invoke(NMakeTargetPlatform_UnixStorage);
        AppendSubtool(NMakeTargetPlatform_UnixStorage);
        return (UatConfig) this;
    }

    public UatConfig MakefileTargetPlatform_Unix(Action<MakefileTargetPlatform_UnixConfig> configurator)
    {
        configurator?.Invoke(MakefileTargetPlatform_UnixStorage);
        AppendSubtool(MakefileTargetPlatform_UnixStorage);
        return (UatConfig) this;
    }

    public UatConfig NMakeTargetPlatform_Linux(Action<NMakeTargetPlatform_LinuxConfig> configurator)
    {
        configurator?.Invoke(NMakeTargetPlatform_LinuxStorage);
        AppendSubtool(NMakeTargetPlatform_LinuxStorage);
        return (UatConfig) this;
    }

    public UatConfig MakefileTargetPlatform_Linux(Action<MakefileTargetPlatform_LinuxConfig> configurator)
    {
        configurator?.Invoke(MakefileTargetPlatform_LinuxStorage);
        AppendSubtool(MakefileTargetPlatform_LinuxStorage);
        return (UatConfig) this;
    }

    public UatConfig XcodeTargetPlatform_Mac(Action<XcodeTargetPlatform_MacConfig> configurator)
    {
        configurator?.Invoke(XcodeTargetPlatform_MacStorage);
        AppendSubtool(XcodeTargetPlatform_MacStorage);
        return (UatConfig) this;
    }

    public UatConfig MakefileTargetPlatform_Mac(Action<MakefileTargetPlatform_MacConfig> configurator)
    {
        configurator?.Invoke(MakefileTargetPlatform_MacStorage);
        AppendSubtool(MakefileTargetPlatform_MacStorage);
        return (UatConfig) this;
    }

    public UatConfig XcodeTargetPlatform_TVOS(Action<XcodeTargetPlatform_TVOSConfig> configurator)
    {
        configurator?.Invoke(XcodeTargetPlatform_TVOSStorage);
        AppendSubtool(XcodeTargetPlatform_TVOSStorage);
        return (UatConfig) this;
    }

    public UatConfig MakefileTargetPlatform_TVOS(Action<MakefileTargetPlatform_TVOSConfig> configurator)
    {
        configurator?.Invoke(MakefileTargetPlatform_TVOSStorage);
        AppendSubtool(MakefileTargetPlatform_TVOSStorage);
        return (UatConfig) this;
    }

    public UatConfig NMakeTargetPlatform_Android(Action<NMakeTargetPlatform_AndroidConfig> configurator)
    {
        configurator?.Invoke(NMakeTargetPlatform_AndroidStorage);
        AppendSubtool(NMakeTargetPlatform_AndroidStorage);
        return (UatConfig) this;
    }

    public UatConfig MakefileTargetPlatform_Android(Action<MakefileTargetPlatform_AndroidConfig> configurator)
    {
        configurator?.Invoke(MakefileTargetPlatform_AndroidStorage);
        AppendSubtool(MakefileTargetPlatform_AndroidStorage);
        return (UatConfig) this;
    }

    public UatConfig VS2019TargetPlatform_Android(Action<VS2019TargetPlatform_AndroidConfig> configurator)
    {
        configurator?.Invoke(VS2019TargetPlatform_AndroidStorage);
        AppendSubtool(VS2019TargetPlatform_AndroidStorage);
        return (UatConfig) this;
    }

    public UatConfig CreateComponentZips(Action<CreateComponentZipsConfig> configurator)
    {
        configurator?.Invoke(CreateComponentZipsStorage);
        AppendSubtool(CreateComponentZipsStorage);
        return (UatConfig) this;
    }
/// <summary>Create stub code for platform extension</summary>
    public UatConfig CreatePlatformExtension(Action<CreatePlatformExtensionConfig> configurator)
    {
        configurator?.Invoke(CreatePlatformExtensionStorage);
        AppendSubtool(CreatePlatformExtensionStorage);
        return (UatConfig) this;
    }
/// <summary>Downloads a build from Jupiter</summary>
    public UatConfig DownloadJupiterBuild(Action<DownloadJupiterBuildConfig> configurator)
    {
        configurator?.Invoke(DownloadJupiterBuildStorage);
        AppendSubtool(DownloadJupiterBuildStorage);
        return (UatConfig) this;
    }
/// <summary>Generates a report about all platforms and their configuration settings.</summary>
    public UatConfig GeneratePlatformReport(Action<GeneratePlatformReportConfig> configurator)
    {
        configurator?.Invoke(GeneratePlatformReportStorage);
        AppendSubtool(GeneratePlatformReportStorage);
        return (UatConfig) this;
    }
/// <summary>MemreportToHelper is used to take a memreport file, extract the CSV sections and generate a GSheet from them (i.e:RunUAT.bat MemReportToGSheet -report=myFile.memreport -name=SheetName (optional)</summary>
    public UatConfig MemreportHelper(Action<MemreportHelperConfig> configurator)
    {
        configurator?.Invoke(MemreportHelperStorage);
        AppendSubtool(MemreportHelperStorage);
        return (UatConfig) this;
    }
/// <summary>Execute a World Partition builder</summary>
    public UatConfig WorldPartitionBuilder(Action<WorldPartitionBuilderConfig> configurator)
    {
        configurator?.Invoke(WorldPartitionBuilderStorage);
        AppendSubtool(WorldPartitionBuilderStorage);
        return (UatConfig) this;
    }

    public UatConfig Turnkey(Action<TurnkeyConfig> configurator)
    {
        configurator?.Invoke(TurnkeyStorage);
        AppendSubtool(TurnkeyStorage);
        return (UatConfig) this;
    }
}
