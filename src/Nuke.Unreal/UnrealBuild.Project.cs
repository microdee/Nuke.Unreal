using System;
using System.IO;
using System.Linq;
using Newtonsoft.Json.Linq;
using Nuke.Cola;
using Nuke.Common;
using Nuke.Common.IO;
using Nuke.Common.Utilities.Collections;
using Serilog;

using static Nuke.Common.IO.PathConstruction;

namespace Nuke.Unreal
{
    public abstract partial class UnrealBuild : NukeBuild
    {
        private AbsolutePath _projectCache = null;

        /// <summary>
        /// Optionally specify a project path.
        /// If not overridden Nuke.Unreal will traverse upwards on the directory tree,
        /// then sift through all subdirectories recursively (ignoring some known folders)
        /// </summary>
        public virtual AbsolutePath ProjectPath
        {
            get
            {
                if (_projectCache != null) return _projectCache;

                Log.Information(".uproject path was unspecified, looking for one...");
                if (BuildCommon.LookAroundFor(f => f.EndsWith(".uproject"), out var candidate))
                {
                    Log.Information($"Found project at {candidate}");
                    _projectCache = candidate;
                    return _projectCache;
                }
                throw new FileNotFoundException("No .uproject was found");
            }
        }

        public AbsolutePath ProjectFolder => ProjectPath.Parent;
        public AbsolutePath PluginsFolder => ProjectFolder / "Plugins";

        public string ProjectName => Path.GetFileNameWithoutExtension(ProjectPath);

        private JObject _projectObject;
        public JObject ProjectObject => _projectObject ??= JObject.Parse(File.ReadAllText(ProjectPath));
    }
}