using System;
using System.ComponentModel;
using System.Linq;
using Nuke.Common.Tooling;

[TypeConverter(typeof(TypeConverter<NuGetPublishTarget>))]
public class NuGetPublishTarget : Enumeration
{
    public static readonly NuGetPublishTarget NugetOrg = new()
    {
        Value = nameof(NugetOrg),
        Source = "https://api.nuget.org/v3/index.json"
    };

    public static readonly NuGetPublishTarget Github = new()
    {
        Value = nameof(Github),
        Source = "https://nuget.pkg.github.com/microdee/index.json"
    };

    public string Source { init; get; }

    public static implicit operator string(NuGetPublishTarget NuGetPublishTarget)
    {
        return NuGetPublishTarget.Value;
    }
}
