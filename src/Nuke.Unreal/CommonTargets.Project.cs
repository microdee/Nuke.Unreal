using System;
using System.ComponentModel;
using System.IO;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Nuke.Common;
using Nuke.Common.CI;
using Nuke.Common.Execution;
using Nuke.Common.Git;
using Nuke.Common.IO;
using Nuke.Common.ProjectModel;
using Nuke.Common.Tooling;
using Nuke.Common.Tools.DotNet;
using Nuke.Common.Utilities.Collections;
using Nuke.Unreal.BoilerplateGenerators;

using static Nuke.Common.EnvironmentInfo;
using static Nuke.Common.IO.FileSystemTasks;
using static Nuke.Common.IO.PathConstruction;
using static Nuke.Common.Tools.DotNet.DotNetTasks;
using static Nuke.Common.Logger;
using static Nuke.Common.ControlFlow;
using static Nuke.Unreal.BuildCommon;

namespace Nuke.Unreal
{
    public abstract partial class CommonTargets : NukeBuild
    {
        protected bool LookAroundFor(Func<string, bool> predicate, out AbsolutePath result)
        {
            result = null;
            var parents = RootDirectory
                .DescendantsAndSelf(d => d.Parent, d => Path.GetPathRoot(d) != d );

            foreach(var p in parents)
                foreach(var f in Directory.EnumerateFiles(p))
                {
                    if(predicate(f))
                    {
                        result = (AbsolutePath) f;
                        return true;
                    }
                }
            
            var descendants = RootDirectory.DescendantsAndSelf(d =>
                from sd in d.GlobDirectories("*")
                where !Path.GetFileName(sd).StartsWith(".")
                where !Path.GetFileName(sd).StartsWith("Nuke.")
                where Path.GetFileName(sd) != "Intermediate"
                where Path.GetFileName(sd) != "Binaries"
                where Path.GetFileName(sd) != "ThirdParty"
                where Path.GetFileName(sd) != "Saved"
                select sd
            );

            foreach(var p in descendants)
                foreach(var f in Directory.EnumerateFiles(p))
                {
                    if(predicate(f))
                    {
                        result = (AbsolutePath) f;
                        return true;
                    }
                }
            return false;
        }

        private AbsolutePath _toProjectCache = null;

        /// <summary>
        /// Optionally specify a project path.
        /// If not overridden Nuke.Unreal will traverse upwards on the directory tree,
        /// then sift through all subdirectories recursively (ignoring some known folders)
        /// </summary>
        public virtual AbsolutePath ToProject
        {
            get
            {
                if(_toProjectCache != null) return _toProjectCache;

                Logger.Info(".uproject path was unspecified, looking for one...");
                if(LookAroundFor(f => f.EndsWith(".uproject"), out var candidate))
                {
                    Logger.Success($"Found project at {candidate}");
                    _toProjectCache = candidate;
                    return _toProjectCache;
                }
                throw new FileNotFoundException("No .uproject was found");
            }
        }

        public AbsolutePath UnrealProjectFolder => ToProject.Parent;
        public AbsolutePath UnrealPluginsFolder => UnrealProjectFolder / "Plugins";

        public string UnrealProjectName => Path.GetFileNameWithoutExtension(ToProject);

        private JObject _projectObject;
        protected JObject ProjectObject =>
            _projectObject ?? (_projectObject = JObject.Parse(File.ReadAllText(ToProject)));
    }
}