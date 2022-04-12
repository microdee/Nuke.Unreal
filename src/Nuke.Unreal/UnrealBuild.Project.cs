using System;
using System.IO;
using System.Linq;
using Newtonsoft.Json.Linq;
using Nuke.Common;
using Nuke.Common.IO;
using Nuke.Common.Utilities.Collections;
using Serilog;

using static Nuke.Common.IO.PathConstruction;

namespace Nuke.Unreal
{
    public abstract partial class UnrealBuild : NukeBuild
    {
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
                if (_toProjectCache != null) return _toProjectCache;

                Log.Information(".uproject path was unspecified, looking for one...");
                if (BuildCommon.LookAroundFor(f => f.EndsWith(".uproject"), out var candidate))
                {
                    Log.Information($"Found project at {candidate}");
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
        public JObject ProjectObject => _projectObject ??= JObject.Parse(File.ReadAllText(ToProject));
    }
}