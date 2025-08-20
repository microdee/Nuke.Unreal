using System.IO;
using Newtonsoft.Json.Linq;
using Nuke.Common;
using Nuke.Common.IO;
using Nuke.Common.Utilities;
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

        private bool? _isPerforceCache = null;

        /// <summary>
        /// Does this project reside in a Perforce workspace?
        /// </summary>
        public virtual bool IsPerforce {
            get
            {
                if (_isPerforceCache != null) return _isPerforceCache ?? false;

                var isP4CachePath = TemporaryDirectory / "IsP4.txt";
                if (isP4CachePath.FileExists())
                    _isPerforceCache = bool.Parse(isP4CachePath.ReadAllText());
                else
                {
                    Log.Information("Detecting Perforce workspace");
                    var isP4 = BuildCommon.LookAroundFor(
                        f => Path.GetFileName(f).EqualsOrdinalIgnoreCase("p4config.txt"),
                        out _
                    );
                    isP4CachePath.WriteAllText(isP4.ToString());
                    _isPerforceCache = isP4;
                }
                Log.Information(_isPerforceCache ?? false
                    ? "Project is managed by Perforce"
                    : "Project is not in a Perforce Workspace"
                );
                return _isPerforceCache ?? false;
            }
        }
    }
}