using System;

namespace build.Generators;

[Flags]
public enum UnrealCompatibility : ulong
{
    UE_4 = 0x00000000FFFFFFFF,
    UE_4_20 = 1UL << 20,
    UE_4_21 = 1UL << 21,
    UE_4_22 = 1UL << 22,
    UE_4_23 = 1UL << 23,
    UE_4_24 = 1UL << 24,
    UE_4_25 = 1UL << 25,
    UE_4_26 = 1UL << 26,
    UE_4_27 = 1UL << 27,
    UE_5 = 0xFFFFFFFF00000000,
    UE_5_0 = 1UL << 32,
    UE_5_1 = 1UL << 33,
    UE_5_2 = 1UL << 34,
    All = 0xFFFFFFFFFFFFFFFF
}