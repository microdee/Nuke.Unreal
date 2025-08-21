using System;
using System.Linq;
using Nuke.Unreal;
using Nuke.Common;
using Nuke.Cola.BuildPlugins;
using Serilog;

public class Build : UnrealBuild
    , IPackageTargets   // Build component for packaged projects (delete if not needed)
    , IAndroidTargets   // Build component for Android chores    (delete if not needed)
{
    /// Nuke:
    /// Support plugins are available for:
    ///   - JetBrains ReSharper        https://nuke.build/resharper
    ///   - JetBrains Rider            https://nuke.build/rider
    ///   - Microsoft VisualStudio     https://nuke.build/visualstudio
    ///   - Microsoft VSCode           https://nuke.build/vscode
    
    // Uncomment to permanently disable the ASCII Nuke logo:
    // protected override void OnBuildCreated() => NoLogo = true;

    public static int Main() => Plugins.Execute<Build>(Execute);
}
