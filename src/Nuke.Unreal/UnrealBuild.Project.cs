using System.IO;
using Newtonsoft.Json.Linq;
using Nuke.Common;
using Nuke.Common.IO;
using Serilog;

namespace Nuke.Unreal
{
    public abstract partial class UnrealBuild : NukeBuild
    {
        private AbsolutePath? _projectCache = null;

        /// <summary>
        ///     <para>
        ///         Optionally specify a path to a `.uproject` file.
        ///     </para>
        ///     <para>
        ///         If not overridden Nuke.Unreal will traverse upwards on the directory tree,
        ///         then sift through all subdirectories recursively (ignoring some known folders)
        ///     </para>
        /// </summary>
        public virtual AbsolutePath ProjectPath
        {
            get
            {
                if (_projectCache != null) return _projectCache;

                var projectCachePath = TemporaryDirectory / "UProjectFile.txt";
                if (projectCachePath.FileExists())
                {
                    _projectCache = AbsolutePath.Create(projectCachePath.ReadAllText());
                }
                else
                {
                    Log.Information("Detecting Unreal project");
                    if (BuildCommon.LookAroundFor(f => f.EndsWith(".uproject"), out var candidate))
                    {
                        projectCachePath.WriteAllText(candidate);
                        _projectCache = candidate;
                    }
                }
                Assert.NotNull(_projectCache, "This build doesn't seem to be an Unreal project.");
                Log.Information($"Unreal project: {_projectCache}");
                return _projectCache!;
            }
        }

        /// <summary>
        /// Path to folder containing the `.project` file
        /// </summary>
        public AbsolutePath ProjectFolder => ProjectPath.Parent;
        public AbsolutePath PluginsFolder => ProjectFolder / "Plugins";

        /// <summary>
        /// Short name of the project
        /// </summary>
        public string ProjectName => Path.GetFileNameWithoutExtension(ProjectPath);

        private JObject? _projectObject;
        
        /// <summary>
        /// JObject representation of the `.uproject` contents
        /// </summary>
        public JObject ProjectObject => _projectObject ??= JObject.Parse(File.ReadAllText(ProjectPath));
    }
}