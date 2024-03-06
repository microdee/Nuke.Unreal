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
        protected T SelfAs<T>() where T : class, INukeBuild => (object)this as T;

        /// <summary>
        /// Most targets read the desired UE4 version from the project file.
        /// </summary>
        [Parameter("Specify the target Unreal Engine version. By default only used by the Checkout target. Everything else should infer engine version from the project file.")]
        public virtual string UnrealVersion { get; set; }

        [Parameter("Specify a path to a custom engine version (eg.: built from source)")]
        public virtual AbsolutePath CustomEnginePath { get; set; } = null;
        
        protected override void OnBuildInitialized()
        {
            base.OnBuildInitialized();
            if(CustomEnginePath != null)
            {
                Unreal.EnginePathOverride = CustomEnginePath;
            }
        }
        
        [Parameter("Specify the output working directory for artifacts")]
        public AbsolutePath Output { get; set; } = null;

        public virtual AbsolutePath GetOutput() => Output ??= ProjectFolder / "Intermediate" / "Output";

        [Parameter("Set platform for running targets")]
        public virtual UnrealPlatform Platform { get; set; } = UnrealPlatform.FromFlag(Unreal.GetDefaultPlatform());

        [Parameter("The target configuration for building or packaging the project")]
        public virtual UnrealConfig[] Config { get; set; } = new [] {UnrealConfig.Development};

        [Parameter("The editor configuration to be used while building or packaging the project")]
        public virtual UnrealConfig[] EditorConfig { get; set; } = new [] {UnrealConfig.Development};

        [Parameter("The Unreal target type for building the project")]
        public virtual UnrealTargetType[] TargetType { get; set; } = new [] {UnrealTargetType.Game};

        public EngineVersion EngineVersion => new(UnrealVersion, CustomEnginePath);
        [Parameter("Extra arguments passed to UBT. It's recommended to use it only from command line, do not override.")]
        public virtual string[] UbtArgs { get; set; }
        
        public virtual UbtConfig UbtGlobal(UbtConfig _) => _
            .WaitMutex();
        public virtual UatConfig UatGlobal(UatConfig _) => _
            .UTF8Output()
            .NoP4();

        [Parameter("Extra arguments passed to UAT. It's recommended to use it only from command line, do not override.")]
        public virtual string[] UatArgs { get; set; }

        public EngineVersion GetEngineVersionFromProject() {
            var result = (ProjectObject["EngineVersionPatch"] ?? ProjectObject["EngineAssociation"]).ToString();
            if(!EngineVersion.ValidVersionString(result))
                return EngineVersion;
            
            return new(result, CustomEnginePath);
        }

        public AbsolutePath UnrealEnginePath => Unreal.GetEnginePath(GetEngineVersionFromProject());
        
        public ConfigIni ReadIniHierarchy(
            string shortName,
            IniHierarchyLevel lowestLevel = IniHierarchyLevel.Base,
            IniHierarchyLevel highestLevel = IniHierarchyLevel.Saved,
            bool considerPlugins = true,
            IEnumerable<string> extraConfigSubfolder = null
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