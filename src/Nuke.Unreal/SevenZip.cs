using Nuke.Common.Tooling;

namespace Nuke.Unreal;

public static class SevenZip
{
    public static Tool Exe => ToolResolver.GetTool(BuildCommon.GetContentsFolder() / "7z/7z.exe");
}
