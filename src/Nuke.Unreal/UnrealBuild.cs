using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Nuke.Cola;
using Nuke.Common;
using Nuke.Common.IO;
using Nuke.Common.Utilities;
using Nuke.Common.Utilities.Collections;
using Nuke.Unreal.Ini;
using Nuke.Unreal.Tools;
using Serilog;

// Maximum line length of long parameter description:
// ------------------------------------------------------------

/// <summary>
/// Indicating the INI config hierarchy importance, from least important to most important
/// (in terms of what overrides the other)
/// </summary>
public enum IniHierarchyLevel
{
    Base,
    Default,
    Saved
}

namespace Nuke.Unreal
{
    /// <summary>
    /// The main build class Unreal projects using Nuke.Unreal should inherit from. This class
    /// contains all base targets for use-cases which are relevant for 99% of Unreal project
    /// development tasks.
    /// </summary>
    public abstract partial class UnrealBuild : NukeBuild
    {
        /// <summary>
        /// Shortcut to casting `this` to another class
        /// </summary>
        protected T Self<T>() where T : INukeBuild => (T)(object)this;
        
        /// <summary>
        /// Shortcut to casting `this` to another class
        /// </summary>
        protected T? SelfAs<T>() where T : class, INukeBuild => (object)this as T;

        protected override void OnBuildInitialized()
        {
            base.OnBuildInitialized();
            if (IsPerforce && IsLocalBuild)
            {
                Log.Warning("This project is part of a perforce workspace.");
                Log.Warning("Some files may be locked by P4 which this build may modify. This may result in file-system errors.");
            }
        }

        /// <summary>
        /// Most targets read the desired Unreal version from the project file.
        /// </summary>
        [Parameter(
            """

            Specify the target Unreal Engine version. It's used only
            for the Switch target. Everything else should infer engine
            version from the project file. Can be simple version name
            like `5.5`, a GUID associated with engine location or an
            absolute path to engine root.

            """,
            Name = "unreal"
        )]
        public virtual string? UnrealVersion { get; set; }
        
        [Parameter("Specify the output working directory for artifacts")]
        public AbsolutePath? Output;

        /// <summary>
        /// Get an output folder where the targets should store their artifacts. Override this
        /// function in your main build class to enforce your own.
        /// </summary>
        public virtual AbsolutePath GetOutput() => Output ??= ProjectFolder / "Intermediate" / "Output";

        [Parameter("Set platform for running targets")]
        public virtual UnrealPlatform Platform { get; set; } = UnrealPlatform.FromFlag(Unreal.GetDefaultPlatform());

        [Parameter("The target configuration for building or packaging the project")]
        public virtual UnrealConfig[] Config { get; set; } = [UnrealConfig.Development];

        [Parameter("The editor configuration to be used while building or packaging the project")]
        public virtual UnrealConfig[] EditorConfig { get; set; } = [UnrealConfig.Development];

        [Parameter("The Unreal target type for building the project")]
        public virtual UnrealTargetType[] TargetType { get; set; } = [UnrealTargetType.Game];
        
        /// <summary>
        /// UBT arguments to be applied globally for all UBT invocations. Override this function
        /// in your main build class if your project needs extra intricacies for everything what
        /// UBT may do through Nuke.Unreal.
        /// 
        /// These arguments are also propagated to all UAT invocations through its `-UbtArgs`
        /// </summary>
        public virtual UbtConfig UbtGlobal(UbtConfig _) => _
            .WaitMutex();
            
        /// <summary>
        /// UAT arguments to be applied globally for all UAT invocations. Override this function
        /// in your main build class if your project needs extra intricacies for everything what
        /// UAT may do through Nuke.Unreal.
        /// </summary>
        public virtual UatConfig UatGlobal(UatConfig _)
        {
            var ubtArgs = GetArgumentBlock("ubt").ToList();
            return _
                .UTF8Output()
                .WaitForUATMutex()
                .If(!IsPerforce, _ => _.NoP4())
                .If(!ubtArgs.IsEmpty(), _ => _.UbtArgs(ubtArgs.JoinSpace()));
        }

        private EngineVersion? _engineVersionCache = null;
        
        /// <summary>
        /// Utility function to get the proper Engine version associated with current project.
        /// Rather use `Unreal.Version` static function, that looks nicer.
        /// </summary>
        public EngineVersion GetEngineVersionFromProject()
        {
            if (_engineVersionCache == null)
            {
                var versionString = UnrealVersion ?? ProjectDescriptor.EngineAssociation;
                Assert.NotNull(versionString, "Unreal Engine version couldn't be determined");
                _engineVersionCache = new(versionString!);
            }
            return _engineVersionCache!;
        }
        
        /// <summary>
        /// Path to the root of the associated Unreal Engine installation/source
        /// </summary>
        public AbsolutePath UnrealEnginePath => Unreal.GetEnginePath(this);

        /// <summary>
        /// Print some rudimentary information onto console about this project and it's environment.
        /// Override this function in your main build class if your project may have its own
        /// important info like this useful for debugging.
        /// </summary>
        public virtual void PrintInfo()
        {
            var unrealVersion = GetEngineVersionFromProject();
            Log.Information("Project name:        {0}", ProjectPath.NameWithoutExtension);
            Log.Information("Unreal version:      {0}", unrealVersion.VersionName);
            Log.Information("Unreal full version: {0}", unrealVersion.VersionPatch);
            Log.Information("Unreal root:         {0}", UnrealEnginePath);
            Log.Information("Output folder:       {0}", GetOutput());
        }

        /// <summary>
        /// Get optionally named argument block (section after `-->`) with contextual data
        /// substituted.
        /// <list type="bullet">
        ///     <item>`~p` Project file path</item>
        ///     <item>`~pdir` Project folder</item>
        ///     <item>`~ue` Unreal Engine folder</item>
        /// </list>
        /// </summary>
        public virtual IEnumerable<string> GetArgumentBlock(string name = "")
            => Arguments.GetBlock(name)
                .Select(a => a
                    .Replace("~p", ProjectPath)
                    .Replace("~pdir", ProjectFolder)
                    .Replace("~ue", UnrealEnginePath)
                    .DoubleQuoteIfNeeded()
                );
        
        /// <summary>
        /// Read INI configuration emulating the same hierarchy of importance as Unreal Engine
        /// also does.
        /// </summary>
        /// <param name="shortName">The name of the configuration like `Game` or `Engine`</param>
        /// <param name="lowestLevel">
        ///     The least important level of hierarchy for reading this config.
        ///     Default is `Base`
        /// </param>
        /// <param name="highestLevel">
        ///     The maximum important level of hierarchy for reading this config
        ///     Default is `Saved`
        /// </param>
        /// <param name="considerPlugins">
        ///     If true also consider config files found in plugins.
        ///     Default if true.
        /// </param>
        /// <param name="extraConfigSubfolder">
        ///     Manually add extra configuration subfolders which may be outside of the normal
        ///     sources of config files.
        /// </param>
        /// <returns>The parsed contents of the indicated config name</returns>
        public ConfigIni ReadIniHierarchy(
            string shortName,
            IniHierarchyLevel lowestLevel = IniHierarchyLevel.Base,
            IniHierarchyLevel highestLevel = IniHierarchyLevel.Saved,
            bool considerPlugins = true,
            IEnumerable<string>? extraConfigSubfolder = null
        ) {
            var resultIni = new ConfigIni();
            extraConfigSubfolder = (extraConfigSubfolder ?? Enumerable.Empty<string>())
                .Append(Platform.ToString());

            IReadOnlyCollection<AbsolutePath> GlobIni(AbsolutePath folder)
            {
                return folder.GlobFiles($"{shortName}.ini", $"*{shortName}.ini");
            }

            void MergeInis(AbsolutePath folder, ConfigIni result)
            {
                if (folder.DirectoryExists())
                    foreach (var iniFile in GlobIni(folder))
                    {
                        var currIni = ConfigIni.Parse(File.ReadAllText(iniFile));
                        if (currIni != null)
                            result.Merge(currIni);
                    }
            }

            void GatherInis(AbsolutePath configFolder, ConfigIni result)
            {
                MergeInis(configFolder, resultIni);
                foreach (var folder in extraConfigSubfolder.Select(s => configFolder / s))
                {
                    if (folder.DirectoryExists())
                        MergeInis(folder, resultIni);
                }
            }

            if (lowestLevel <= IniHierarchyLevel.Base && highestLevel >= IniHierarchyLevel.Base)
            {
                var configFolder = UnrealEnginePath / "Engine" / "Config";
                var baseIni = ConfigIni.Parse(File.ReadAllText(configFolder / "Base.ini"));
                if (baseIni != null)
                    resultIni.Merge(baseIni);

                GatherInis(configFolder, resultIni);
            }

            if (lowestLevel <= IniHierarchyLevel.Default && highestLevel >= IniHierarchyLevel.Default)
            {
                var configFolder = ProjectFolder / "Config";
                GatherInis(configFolder, resultIni);
            }
            if (lowestLevel <= IniHierarchyLevel.Default && highestLevel >= IniHierarchyLevel.Default && considerPlugins)
            {
                foreach (var pluginConfigFolder in (ProjectFolder / "Plugins").GlobDirectories("**/Config"))
                {
                    GatherInis(pluginConfigFolder, resultIni);
                }
            }
            if (lowestLevel <= IniHierarchyLevel.Saved && highestLevel >= IniHierarchyLevel.Saved)
            {
                var configFolder = ProjectFolder / "Saved" / "Config";
                GatherInis(configFolder, resultIni);
            }

            return resultIni;
        }
    }
}