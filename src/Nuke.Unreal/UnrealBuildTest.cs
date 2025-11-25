using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Nuke.Common.Tools.Git;
using Serilog;

namespace Nuke.Unreal;

/// <summary>
/// Used only for testing purposes. It has no external use outside of Nuke.Unreal development.
/// </summary>
public class UnrealBuildTest : UnrealBuild
{
    protected override void OnBuildCreated()
    {
        base.OnBuildCreated();
        NoLogo = true;
    }
    
    protected virtual void CleanupGit()
    {
        GitTasks.Git("clean -xdf -e Nuke.Targets/ -e .nuke/", workingDirectory: ProjectFolder);
        GitTasks.Git("restore . -- :(exclude)Nuke.Targets/ :(exclude).nuke/", workingDirectory: ProjectFolder);
    }

    protected virtual void PostBuildCheck() {}

    protected override void OnBuildFinished()
    {
        try
        {
            PostBuildCheck();
        }
        catch (Exception e)
        {
            Log.Error(e, "Post build check failed");
            ExitCode = -1;
        }
        CleanupGit();
    }
}