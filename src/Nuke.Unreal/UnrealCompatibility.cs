using System;

namespace Nuke.Unreal;

[Flags]
public enum UnrealCompatibility
{
    UE4 = 1,
    UE5 = 2,
    All = UE4 | UE5
}