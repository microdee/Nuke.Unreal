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
    public record EngineSourceInfo(
        Guid? EngineSourceId,
        AbsolutePath EngineSourcePath
    );

    public partial class EngineVersion
    {
        [GeneratedRegex(@"(?<version>[\W\d]+)(?<extension>\w*)")]
        private static partial Regex ValidVersionRegex();

        public static bool ValidVersionString(string? versionName)
        {
            if (string.IsNullOrWhiteSpace(versionName)) return false;

            if (Guid.TryParse(versionName, out _))
                return true;

            if (Path.IsPathRooted(versionName) && Directory.Exists(versionName))
                return true;

            var regexedComponents = ValidVersionRegex().Match(versionName);
            if (regexedComponents == null)
                return false;

            var pureVersionNamePatch = regexedComponents.Groups["version"].Value;
            return Version.TryParse(pureVersionNamePatch, out _);
        }

        private AbsolutePath GetEnginePath(string versionName)
            => Source?.EngineSourcePath ?? Unreal.GetEnginePath(versionName);

        private Version GetEngineSemVersion(string versionName)
        {
            var buildVersionPath = GetEnginePath(versionName) / "Engine" / "Build" / "Build.version";
            Assert.FileExists(buildVersionPath, $"Specified path was not an Unreal Engine instance ({buildVersionPath})");

            var buildVersion = JObject.Parse(File.ReadAllText(buildVersionPath));
            return new(
                buildVersion.GetPropertyValue<int>("MajorVersion"),
                buildVersion.GetPropertyValue<int>("MinorVersion"),
                buildVersion.GetPropertyValue<int>("PatchVersion")
            );
        }

        [GeneratedRegex(@"(?<version>[\W\d]+)(?<extension>\w*)")]
        private static partial Regex VersionRegex();

        public EngineVersion(string versionName)
        {
            VersionName = versionName;
            Extension = "";
            IsEarlyAccess = false;

            if (Guid.TryParse(versionName, out var engineSourceId))
            {
                var enginePath = Unreal.GetEnginePath(versionName);
                Assert.NotNull(enginePath, $"GUID was not pointing to an Unreal Engine instance {versionName}");
                Source = new(engineSourceId, enginePath);
                return;
            }

            if (Path.IsPathRooted(versionName))
            {
                Assert.DirectoryExists(versionName, $"No instance of Unreal Engine exists at {versionName}");
                Source = new(null, AbsolutePath.Create(versionName));
                return;
            }

            var regexedComponents = VersionRegex().Match(versionName);
            Assert.True(regexedComponents != null, $"Invalid version format ({versionName})");

            VersionName = regexedComponents!.Groups["version"].Value;
            Extension = regexedComponents.Groups["extension"].Value ?? "";
            IsEarlyAccess = Extension == "EA";

            Assert.True(Version.TryParse(VersionName, out _), $"Couldn't parse a simple Unreal version from ({versionName})");
        }

        public string VersionName;
        public string ExtendedVersionName => VersionName + Extension;
        private Version? _semVersion = null;
        public Version SemanticalVersion => _semVersion ??= GetEngineSemVersion(VersionName);
        public string VersionMinor => SemanticalVersion.Major + "." + SemanticalVersion.Minor;
        public string VersionPatch => SemanticalVersion.Major + "." + SemanticalVersion.Minor + "." + SemanticalVersion.Build;
        public string Extension;
        public bool IsEarlyAccess;
        public EngineSourceInfo? Source = null;
        public bool IsEngineSource => Source != null;

        private int CompatibilityBaseExponent => SemanticalVersion.Major > 4 ? 32 : 0;
        private ulong CompatibilityFlag => 1UL << (CompatibilityBaseExponent + SemanticalVersion.Minor);

        public UnrealCompatibility Compatibility => (UnrealCompatibility)CompatibilityFlag;

        public bool IsCompatibleWith(UnrealCompatibility compatibility)
        {
            return (compatibility & Compatibility) > 0;
        }
    }
}
