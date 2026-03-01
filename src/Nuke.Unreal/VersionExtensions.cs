using System;

namespace Nuke.Unreal;

public static class VersionExtensions
{
    public static string ToStringAutoFieldCount(this Version version, bool allowZero = false)
    {
        var tolerance = allowZero ? 0 : -1;
        var fields = 4;
        if (version.Revision <= tolerance) --fields;
        if (version.Build <= tolerance) --fields;
        if (version.Minor <= tolerance) --fields;
        return version.ToString(fields);
    }

}
