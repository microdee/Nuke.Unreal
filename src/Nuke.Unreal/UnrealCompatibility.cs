using System;

namespace Nuke.Unreal;

[Flags]
public enum UnrealCompatibility : ulong
{
    UE_4 =        0b00000000_00000000_00000000_00000000_11111111_11111111_11111111_11111111,
    UE_4_Latest = 0b00000000_00000000_00000000_00000000_11111000_00000000_00000000_00000000,
    UE_4_0 = 1UL << 0,
    UE_4_1 = 1UL << 1,
    UE_4_2 = 1UL << 2,
    UE_4_3 = 1UL << 3,
    UE_4_4 = 1UL << 4,
    UE_4_5 = 1UL << 5,
    UE_4_6 = 1UL << 6,
    UE_4_7 = 1UL << 7,
    UE_4_8 = 1UL << 8,
    UE_4_9 = 1UL << 9,
    UE_4_10 = 1UL << 10,
    UE_4_11 = 1UL << 11,
    UE_4_12 = 1UL << 12,
    UE_4_13 = 1UL << 13,
    UE_4_14 = 1UL << 14,
    UE_4_15 = 1UL << 15,
    UE_4_16 = 1UL << 16,
    UE_4_17 = 1UL << 17,
    UE_4_18 = 1UL << 18,
    UE_4_19 = 1UL << 19,
    UE_4_20 = 1UL << 20,
    UE_4_21 = 1UL << 21,
    UE_4_22 = 1UL << 22,
    UE_4_23 = 1UL << 23,
    UE_4_24 = 1UL << 24,
    UE_4_25 = 1UL << 25,
    UE_4_26 = 1UL << 26,
    UE_4_27 = 1UL << 27,
    UE_5 =        0b11111111_11111111_11111111_11111111_00000000_00000000_00000000_00000000,
    UE_5_Latest = 0b11111111_11111111_11111111_11111100_00000000_00000000_00000000_00000000,
    UE_5_0 = 1UL << 32,
    UE_5_1 = 1UL << 33,
    UE_5_2 = 1UL << 34,
    UE_5_3 = 1UL << 35,
    UE_5_4 = 1UL << 36,
    UE_5_5 = 1UL << 37,
    UE_5_6 = 1UL << 38,
    UE_5_7 = 1UL << 39,
    UE_5_8 = 1UL << 40,
    UE_5_9 = 1UL << 41,
    UE_5_10 = 1UL << 42,
    UE_5_11 = 1UL << 43,
    UE_5_12 = 1UL << 44,
    UE_5_13 = 1UL << 45,
    UE_5_14 = 1UL << 46,
    UE_5_15 = 1UL << 47,
    UE_5_16 = 1UL << 48,
    UE_5_17 = 1UL << 49,
    UE_5_18 = 1UL << 50,
    UE_5_19 = 1UL << 51,
    UE_5_20 = 1UL << 52,
    UE_5_21 = 1UL << 53,
    UE_5_22 = 1UL << 54,
    UE_5_23 = 1UL << 55,
    UE_5_24 = 1UL << 56,
    UE_5_25 = 1UL << 57,
    UE_5_26 = 1UL << 58,
    UE_5_27 = 1UL << 59,
    UE_5_28 = 1UL << 60,
    UE_5_29 = 1UL << 61,
    UE_5_30 = 1UL << 62,
    UE_5_31 = 1UL << 63,
    All = 0xFFFFFFFFFFFFFFFF
}