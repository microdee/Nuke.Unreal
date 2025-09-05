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

        public EngineVersion(string versionName)
        {
            VersionName = versionName;
            EnginePath = Unreal.GetEnginePath(versionName);
        }

        public string VersionName;
        private Version? _semVersion = null;
        public Version SemanticalVersion => _semVersion ??= GetEngineSemVersion();
        public string VersionMinor => SemanticalVersion.Major + "." + SemanticalVersion.Minor;
        public string VersionPatch => SemanticalVersion.Major + "." + SemanticalVersion.Minor + "." + SemanticalVersion.Build;
        public AbsolutePath EnginePath;

        private int CompatibilityBaseExponent => SemanticalVersion.Major > 4 ? 32 : 0;
        private ulong CompatibilityFlag => 1UL << (CompatibilityBaseExponent + SemanticalVersion.Minor);

        public UnrealCompatibility Compatibility => (UnrealCompatibility)CompatibilityFlag;

        public bool IsCompatibleWith(UnrealCompatibility compatibility)
        {
            return (compatibility & Compatibility) > 0;
        }
    }
}
