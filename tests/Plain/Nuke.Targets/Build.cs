using System;
using System.Linq;
using Nuke.Unreal;
using Nuke.Common;
using Nuke.Common.CI;
using Nuke.Common.Execution;
using Nuke.Common.IO;
using Nuke.Common.ProjectModel;
using Nuke.Common.Tooling;
using Nuke.Common.Utilities.Collections;
using Nuke.Cola.BuildPlugins;

public class Build : UnrealBuild
    // , IPackageTargets   // Build component for packaged projects
    // , IPluginTargets    // Build component for common plugin development
    // , IAndroidTargets   // Build component for Android chores
{
    /// Nuke:
    /// Support plugins are available for:
    ///   - JetBrains ReSharper        https://nuke.build/resharper
    ///   - JetBrains Rider            https://nuke.build/rider
    ///   - Microsoft VisualStudio     https://nuke.build/visualstudio
    ///   - Microsoft VSCode           https://nuke.build/vscode
    
    // Uncomment to permanently disable the ASCII Nuke logo:
    // protected override void OnBuildCreated() => NoLogo = true;

    public static int Main () => Plugins.Execute<Build>(Execute);
}
