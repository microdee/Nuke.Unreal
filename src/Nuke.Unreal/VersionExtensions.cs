using System;

namespace Nuke.Unreal;

public static class VersionExtensions
{
    /// <summary>
    /// Automatically prune version component if they're &lt;= 0 (or -1)
    /// </summary>
    /// <param name="version"></param>
    /// <param name="allowZero"></param>
    /// <returns></returns>
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
