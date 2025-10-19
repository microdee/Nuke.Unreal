using System;
using System.Text.RegularExpressions;
using System.IO;
using Nuke.Common;
using Nuke.Common.IO;
using Newtonsoft.Json.Linq;
using Serilog;

using Nuke.Common.Utilities;

namespace Nuke.Unreal
{
    /// <summary>
    /// High level representation of an Unreal Engine version
    /// </summary>
    public partial class EngineVersion
    {
        private Version GetEngineSemVersion()
        {
            var buildVersionPath = EnginePath / "Engine" / "Build" / "Build.version";
            Assert.FileExists(buildVersionPath, $"Specified path was not an Unreal Engine instance ({buildVersionPath})");

            var buildVersion = JObject.Parse(File.ReadAllText(buildVersionPath));
            return new(
                buildVersion.GetPropertyValue<int>("MajorVersion"),
                buildVersion.GetPropertyValue<int>("MinorVersion"),
                buildVersion.GetPropertyValue<int>("PatchVersion")
            );
        }

        /// <summary>
        /// Parse a high-level version from an input version identifier (semantic, guid or path)
        /// </summary>
        public EngineVersion(string versionName)
        {
            VersionName = versionName;
            EnginePath = Unreal.GetEnginePath(versionName);
        }

        /// <summary>
        /// The canonical engine version name, only contains Major.Minor and may contain suffixes
        /// like how Unreal Engine 5 Early Access did once (5.0AE)
        /// </summary>
        public string VersionName;
        private Version? _semVersion = null;

        /// <summary>
        /// Semantical version representation of the given Unreal Engine
        /// </summary>
        public Version SemanticalVersion => _semVersion ??= GetEngineSemVersion();

        /// <summary>
        /// Only the Major.Minor version components, with extra information trimmed.
        /// </summary>
        public string VersionMinor => SemanticalVersion.Major + "." + SemanticalVersion.Minor;
        
        /// <summary>
        /// Only the full Major.Minor.Patch version components, with additional information trimmed.
        /// </summary>
        public string VersionPatch => SemanticalVersion.Major + "." + SemanticalVersion.Minor + "." + SemanticalVersion.Build;

        /// <summary>
        /// Cached engine path.
        /// </summary>
        public AbsolutePath EnginePath;

        private int CompatibilityBaseExponent => SemanticalVersion.Major > 4 ? 32 : 0;
        private ulong CompatibilityFlag => 1UL << (CompatibilityBaseExponent + SemanticalVersion.Minor);

        /// <summary>
        /// Compatibility flag equivalent for this version.
        /// </summary>
        public UnrealCompatibility Compatibility => (UnrealCompatibility)CompatibilityFlag;

        /// <summary>
        /// Check if given compatibility mask applies to this version too.
        /// </summary>
        public bool IsCompatibleWith(UnrealCompatibility compatibility)
        {
            return (compatibility & Compatibility) > 0;
        }
    }
}
