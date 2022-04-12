
using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.IO.Compression;
using Nuke.Common.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Nuke.Common;
using Nuke.Common.Utilities.Collections;
using static Nuke.Common.IO.FileSystemTasks;
using static Nuke.Common.IO.PathConstruction;
using static Nuke.Common.Logger;
using static Nuke.Common.ControlFlow;

namespace Nuke.Unreal
{
    public interface IPackageTargets
    {
        bool PackagePak => false;
        
        IEnumerable<string> PackageArguments
        {
            get
            {
                var result = new List<string> {
                    "-skipcook",
                    "-nocompileeditor",
                    "-installed",
                    "-prereqs",
                    "-nop4",
                    "-utf8output",
                    "-manifests",
                };
                if(PackagePak)
                {
                    result.Add("-pak");
                }
                return result;
            }
        }

        Target Package => _ => _
            .Description("Same as running Package Project from Editor")
            .DependsOn((this as UnrealBuild)?.Cook)
            .After((this as UnrealBuild)?.CleanDeployment)
            .Executes(() =>
            {
                if (this is not UnrealBuild self)
                {
                    throw new Exception("An UnrealBuild class needs to inherit IPackageTargets");
                }

                var appLocalDir = self.UnrealEnginePath / "Engine" / "Binaries" / "ThirdParty" / "AppLocalDependencies";
                self.Config.ForEach(c =>
                {
                    Unreal.AutomationToolBatch(
                        self.GetEngineVersionFromProject(),
                        "BuildCookRun"
                        + $" -ScriptsForProject=\"{self.ToProject}\""
                        + $" -project=\"{self.ToProject}\""
                        + $" -target={self.UnrealProjectName}"
                        + $" -targetplatform={self.TargetPlatform}"
                        + $" -platform={self.TargetPlatform}"
                        + $" -clientconfig={c}"
                        + $" -archivedirectory=\"{self.OutPath}\""
                        + $" -applocaldirectory={appLocalDir}"
                        + " -build"
                        + " -package"
                        + " -stage"
                        + " -archive"
                        + PackageArguments.AppendAsArguments()
                        + self.UatArgs.AppendAsArguments()
                    )
                    .WithWorkingDir(self.UnrealEnginePath)
                    .Run();
                });
            });
    }
}