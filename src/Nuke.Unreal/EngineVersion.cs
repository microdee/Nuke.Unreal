using System;
using System.Text.RegularExpressions;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using Nuke.Common;
using Nuke.Common.IO;
using System.Runtime.InteropServices;
using Nuke.Common.Tooling;
using System.Reflection;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Serilog;

using static Nuke.Common.IO.FileSystemTasks;
using Nuke.Common.Utilities;
using System.Text;

namespace Nuke.Unreal
{
    public struct EngineVersion
    {
        public static bool ValidVersionString(string versionName)
        {
            if(Guid.TryParse(versionName, out _))
            {
                return true;
            }

            var regexedComponents = Regex.Match(versionName, @"(?<version>[\W\d]+)(?<extension>\w*)");
            if(regexedComponents == null)
                return false;

            var pureVersionNamePatch = regexedComponents.Groups["version"].Value;
            return Version.TryParse(pureVersionNamePatch, out _);
        }

        public EngineVersion(string versionName, string customEnginePath = null)
        {
            FullVersionName = versionName;
            VersionName = versionName;

            PureVersionName = "";
            PureVersionNamePatch = "";
            Extension = "";
            IsEngineSource = false;
            IsEarlyAccess = false;
            SemanticalVersion = null;

            if(Guid.TryParse(versionName, out EngineSourceId))
            {
                IsEngineSource = true;
                EngineAssociation = versionName;
                var enginePath = (AbsolutePath) customEnginePath ?? Unreal.GetEnginePath(versionName);
                if(enginePath != null)
                {
                    var buildVersionPath = enginePath / "Engine" / "Build" / "Build.version";
                    if(buildVersionPath.Exists())
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
                }
                return;
            }

            var regexedComponents = Regex.Match(versionName, @"(?<version>[\W\d]+)(?<extension>\w*)");
            Assert.True(regexedComponents != null, "Invalid version format");

            PureVersionNamePatch = regexedComponents.Groups["version"].Value;
            Extension = regexedComponents.Groups["extension"].Value ?? "";
            IsEarlyAccess = Extension == "EA";

            Assert.True(Version.TryParse(PureVersionNamePatch, out var semVersion), "Couldn't parse semantic version of input UE version");

            SemanticalVersion = new Version(
                semVersion.Major,
                semVersion.Minor,
                Math.Max(semVersion.Build, 0),
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
    }
}
