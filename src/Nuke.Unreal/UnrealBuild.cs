using Nuke.Common;
using Nuke.Common.IO;

namespace Nuke.Unreal
{
    public abstract partial class UnrealBuild : NukeBuild
    {
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
        public virtual AbsolutePath OutPath { get; set; } = RootDirectory / ".deploy";

        [Parameter("Set platform for running targets")]
        public UnrealPlatform TargetPlatform { get; set; } = UnrealPlatform.FromFlag(Unreal.GetDefaultPlatform());

        [Parameter("The target configuration for building or packaging the project")]
        public virtual UnrealConfig[] Config { get; set; } = new [] {UnrealConfig.Development};

        [Parameter("The target execution mode for building the project (Standalone or Editor")]
        public virtual ExecMode[] RunIn { get; set; } = new [] {ExecMode.Standalone};

        public EngineVersion TargetEngineVersion => new(UnrealVersion, CustomEnginePath);
        [Parameter("Extra arguments passed to UBT. It's recommended to use it only from command line, do not override.")]
        public virtual string[] UbtArgs { get; set; }

        [Parameter("Extra arguments passed to UAT. It's recommended to use it only from command line, do not override.")]
        public virtual string[] UatArgs { get; set; }

        [Parameter("Select texture compression mode for Android")]
        public virtual AndroidCookFlavor[] AndroidTextureMode { get; set; }

        public EngineVersion GetEngineVersionFromProject() {
            var result = (ProjectObject["EngineVersionPatch"] ?? ProjectObject["EngineAssociation"]).ToString();
            if(!EngineVersion.ValidVersionString(result))
                return TargetEngineVersion;
            
            return new(result, CustomEnginePath);
        }

        public AbsolutePath UnrealEnginePath => Unreal.GetEnginePath(GetEngineVersionFromProject());
    }
}