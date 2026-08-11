namespace Nuke.Unreal;

/// <summary>
/// Represents a Build.version file in an engine instance
/// </summary>
public record class UnrealBuildVersion(
    int MajorVersion,
    int MinorVersion,
    int PatchVersion,
    ulong? Changelist,
    ulong? CompatibleChangelist,
    int? IsLicenseeVersion,
    int? IsPromotedBuild,
    string? BranchName
);