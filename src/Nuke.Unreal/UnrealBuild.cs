using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Nuke.Common;
using Nuke.Common.IO;
using Nuke.Common.Utilities;
using Nuke.Unreal.Ini;
using Nuke.Unreal.Tools;

public enum IniHierarchyLevel
{
    Base,
    Default,
    Saved
}

namespace Nuke.Unreal
{
    public abstract partial class UnrealBuild : NukeBuild
    {
        protected T Self<T>() where T : INukeBuild => (T)(object)this;
        protected T? SelfAs<T>() where T : class, INukeBuild => (object)this as T;

        /// <summary>
        /// Most targets read the desired UE4 version from the project file.
        /// </summary>
        [Parameter(
            """
            Specify the target Unreal Engine version. It's used only for the Switch target.
            Everything else should infer engine version from the project file.
            Can be simple version name like `5.5`, a GUID associated with engine location or an
            absolute path to engine root.
            """,
            Name = "unreal"
        )]
        public virtual string? UnrealVersion { get; set; }
        
        [Parameter("Specify the output working directory for artifacts")]
        public AbsolutePath? Output;

        public virtual AbsolutePath GetOutput() => Output ??= ProjectFolder / "Intermediate" / "Output";

        [Parameter("Set platform for running targets")]
        public virtual UnrealPlatform Platform { get; set; } = UnrealPlatform.FromFlag(Unreal.GetDefaultPlatform());

        [Parameter("The target configuration for building or packaging the project")]
        public virtual UnrealConfig[] Config { get; set; } = [UnrealConfig.Development];

        [Parameter("The editor configuration to be used while building or packaging the project")]
        public virtual UnrealConfig[] EditorConfig { get; set; } = [UnrealConfig.Development];

        [Parameter("The Unreal target type for building the project")]
        public virtual UnrealTargetType[] TargetType { get; set; } = [UnrealTargetType.Game];

        [Parameter(
            """
            Extra arguments passed to UBT. It's recommended to use it only from command line, do not
            override.
            """
        )]
        public virtual string[] UbtArgs { get; set; } = Array.Empty<string>();
        
        public virtual UbtConfig UbtGlobal(UbtConfig _) => _
            .WaitMutex();
        public virtual UatConfig UatGlobal(UatConfig _) => _
            .UTF8Output()
            .NoP4();

        [Parameter(
            """
            Extra arguments passed to UAT. It's recommended to use it only from command line, do not
            override.
            """
        )]
        public virtual string[] UatArgs { get; set; } = Array.Empty<string>();

        private EngineVersion? _engineVersionCache = null;
        
        public EngineVersion GetEngineVersionFromProject()
        {
            if (_engineVersionCache == null)
            {
                var versionString = UnrealVersion ?? ProjectObject["EngineAssociation"]?.ToString();
                Assert.NotNull(versionString, "Unreal Engine version couldn't be determined");
                _engineVersionCache = new(versionString!);
            }
            return _engineVersionCache!;
        }

        public AbsolutePath UnrealEnginePath => Unreal.GetEnginePath(this);
        
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