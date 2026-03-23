using System;

namespace Nuke.Unreal;

public static class VersionExtensions
{
    /// <summary>
    /// Automatically prune version component if they're &lt;= 0
    /// </summary>
    /// <param name="version"></param>
    /// <param name="allowZero"></param>
    /// <returns></returns>
    public static string ToStringAutoFieldCount(this Version version)
    {
        var fields = 4;
        if (version.Revision <= 0) --fields;
        if (version.Build <= 0) --fields;
        if (version.Minor <= 0) --fields;
        return version.ToString(fields);
    }

}
