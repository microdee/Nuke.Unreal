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
    public partial struct EngineVersion
    {
        [GeneratedRegex(@"(?<version>[\W\d]+)(?<extension>\w*)")]
        private static partial Regex ValidVersionRegex();
        
        public static bool ValidVersionString(string? versionName)
        {
            if (string.IsNullOrWhiteSpace(versionName)) return false;

            if(Guid.TryParse(versionName, out _))
            {
                return true;
            }

            var regexedComponents = ValidVersionRegex().Match(versionName);
            if(regexedComponents == null)
                return false;

            var pureVersionNamePatch = regexedComponents.Groups["version"].Value;
            return Version.TryParse(pureVersionNamePatch, out _);
        }

        [GeneratedRegex(@"(?<version>[\W\d]+)(?<extension>\w*)")]
        private static partial Regex VersionRegex();

        public EngineVersion(string versionName, string? customEnginePath = null)
        {
            FullVersionName = versionName;
            VersionName = versionName;

            PureVersionName = "";
            PureVersionNamePatch = "";
            Extension = "";
            IsEngineSource = false;
            IsEarlyAccess = false;
            SemanticalVersion = new Version();

            if(Guid.TryParse(versionName, out EngineSourceId))
            {
                IsEngineSource = true;
                EngineAssociation = versionName;
                var enginePath = (AbsolutePath) customEnginePath ?? Unreal.GetEnginePath(versionName);
                if(enginePath != null)
                {
                    var buildVersionPath = enginePath / "Engine" / "Build" / "Build.version";
                    if(buildVersionPath.FileExists())
                    {
                        var buildVersion = JObject.Parse(File.ReadAllText(buildVersionPath));
                        SemanticalVersion = new(
                            buildVersion.GetPropertyValue<int>("MajorVersion"),
                            buildVersion.GetPropertyValue<int>("MinorVersion"),
                            buildVersion.GetPropertyValue<int>("PatchVersion")
                        );

                        PureVersionName = $"{SemanticalVersion.Major}.{SemanticalVersion.Minor}";
                        PureVersionNamePatch = $"{SemanticalVersion.Major}.{SemanticalVersion.Minor}.{SemanticalVersion.Build}";
                    }
                    else
                    {
                        Log.Warning("{0} didn't exist", buildVersionPath);
                        Log.Warning("Couldn't determine version of engine from its path");
                    }
                }
                return;
            }

            var regexedComponents = VersionRegex().Match(versionName);
            Assert.True(regexedComponents != null, "Invalid version format");

            PureVersionNamePatch = regexedComponents!.Groups["version"].Value;
            Extension = regexedComponents.Groups["extension"].Value ?? "";
            IsEarlyAccess = Extension == "EA";

            Assert.True(Version.TryParse(PureVersionNamePatch, out var semVersion), "Couldn't parse semantic version of input UE version");

            SemanticalVersion = new Version(
                semVersion!.Major,
                semVersion!.Minor,
                Math.Max(semVersion!.Build, 0),
                0
            );

            PureVersionName = SemanticalVersion.Major + "." + SemanticalVersion.Minor;
            VersionName = PureVersionName + Extension;
            EngineAssociation = customEnginePath?.Replace('\\', '/') ?? VersionName;
        }

        public string VersionName;
        public string PureVersionName;
        public string PureVersionNamePatch;
        public string FullVersionName;
        public Version SemanticalVersion;
        public string Extension;
        public bool IsEarlyAccess;
        public bool IsEngineSource;
        public Guid EngineSourceId;
        public string EngineAssociation;

        private int CompatibilityBaseExponent => SemanticalVersion.Major > 4 ? 32 : 0;
        private ulong CompatibilityFlag => 1UL << (CompatibilityBaseExponent + SemanticalVersion.Minor);

        public UnrealCompatibility Compatibility => (UnrealCompatibility)CompatibilityFlag;

        public bool IsCompatibleWith(UnrealCompatibility compatibility)
        {
            return (compatibility & Compatibility) > 0;
        }
    }
}
