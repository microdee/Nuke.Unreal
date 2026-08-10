using System.Collections.Generic;
using System.Linq;
using Nuke.Common.IO;
using Nuke.Common.Utilities;

namespace Nuke.Unreal;

/// <summary>
/// Represents an item in the LauncherInstalled file.
/// </summary>
public record class LauncherInstalledItem(
    string InstallLocation,
    string NamespaceId,
    string ItemId,
    string ArtifactId,
    string AppVersion,
    string AppName
);

/// <summary>
/// Represents the whole LauncherInstalled file
/// </summary>
public record class LauncherInstalledList(List<LauncherInstalledItem> InstallationList)
{
    /// <summary>
    /// Fetch Unreal installations from this list
    /// </summary>
    public IEnumerable<UnrealInstance> GetInstances() => InstallationList
        .Where(i => i.ArtifactId.StartsWith("UE_"))
        .Select(i => new UnrealInstance(i.ArtifactId.Replace("UE_", ""), (AbsolutePath)i.InstallLocation))
    ;

    /// <summary>
    /// Fetch Unreal installations from a LauncherInstalled.dat file
    /// </summary>
    /// <param name="datFile">Can be not existing, in which case an empty enumerable is returned</param>
    public static IEnumerable<UnrealInstance> FromFile(AbsolutePath datFile) => datFile.ExistingFile()
        ?.ReadJson<LauncherInstalledList>()
        ?.GetInstances()
        ?? []
    ;
}
