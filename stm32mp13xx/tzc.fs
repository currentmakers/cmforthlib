\
\ @file tzc.fs
\ @brief TZC
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief TZC configuration register
\ Address offset: 0x00
\ Reset value: 0x00001F08
\

$0000001f constant TZC_TZC_BUILD_CONFIG_NO_OF_REGIONS               \ Number fo regions Others: Reserved
$00003f00 constant TZC_TZC_BUILD_CONFIG_ADDRESS_WIDTH               \ Address width Others: Reserved
$01000000 constant TZC_TZC_BUILD_CONFIG_NO_OF_FILTERS               \ Number of filters


\
\ @brief TZC action register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000003 constant TZC_TZC_ACTION_REACTION_VALUE                    \ Permission failure reaction Controls how TZC signals region permission failure. 2: set tzcint high and issue OKAY on the bus 3: set tzcint high and issue DECERR on the bus


\
\ @brief TZC gate keeper register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000001 constant TZC_TZC_GATE_KEEPER_OPENREQ                      \ Gate keeper open request for filter
$00010000 constant TZC_TZC_GATE_KEEPER_OPENSTAT                     \ Gate keeper status for filter


\
\ @brief TZC speculation control register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000001 constant TZC_TZC_SPECULATION_CTRL_READSPEC_DISABLE        \ Read access speculation disable
$00000002 constant TZC_TZC_SPECULATION_CTRL_WRITESPEC_DISABLE       \ Write access speculation disable


\
\ @brief TZC interrupt status register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000001 constant TZC_TZC_INT_STATUS_STATUS                        \ Interrupt status for the filter.
$00000100 constant TZC_TZC_INT_STATUS_OVERRUN                       \ Permission failure overrun Two or more regions permission failures for the filter.
$00030000 constant TZC_TZC_INT_STATUS_OVERLAP                       \ Overlap violation for each filter Bit 17 is for filter 1, bit 16 is for filter 0.


\
\ @brief TZC interrupt clear register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000001 constant TZC_TZC_INT_CLEAR_CLEAR                          \ Filter interrupt clear Write “1” to clear interrupt for each filter.


\
\ @brief TZC fail address low register x
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000000 constant TZC_TZC_FAIL_ADDRESS_LOW_ADDR_STATUS_LOW         \ Fail address low bits Low 32 address bits of the first failed access permission check in the filter.


\
\ @brief TZC fail control register x
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$00100000 constant TZC_TZC_FAIL_CONTROL_PRIVILEGE                   \ Privilege access failure
$00200000 constant TZC_TZC_FAIL_CONTROL_NON_SECURE                  \ Non-secure access failure
$01000000 constant TZC_TZC_FAIL_CONTROL_DIRECTION                   \ Access failure direction


\
\ @brief TZC fail ID register x
\ Address offset: 0x2C
\ Reset value: 0x00000000
\

$000007ff constant TZC_TZC_FAIL_ID_ID                               \ AXI fail ID Return the AXI ID of the first fail.


\
\ @brief TZC region 0 base address low register
\ Address offset: 0x100
\ Reset value: 0x00000000
\

$fffff000 constant TZC_TZC_REGION_BASE_LOW0_BASE_ADDRESS_LOW        \ base address bits[31:12] for region 0 Others: Reserved


\
\ @brief TZC region 0 top address low register
\ Address offset: 0x108
\ Reset value: 0xFFFFFFFF
\

$fffff000 constant TZC_TZC_REGION_TOP_LOW0_TOP_ADDRESS_LOW          \ Top address bits [31:12] of region 0 Others: Reserved


\
\ @brief TZC region 0 attribute register
\ Address offset: 0x110
\ Reset value: 0x00000003
\

$00000001 constant TZC_TZC_REGION_ATTRIBUTE0_FILTER_EN              \ Region enable for the filter
$40000000 constant TZC_TZC_REGION_ATTRIBUTE0_S_RD_EN                \ Secure global read enable
$80000000 constant TZC_TZC_REGION_ATTRIBUTE0_S_WR_EN                \ Secure global write enable


\
\ @brief TZC region 0 ID access register
\ Address offset: 0x114
\ Reset value: 0x00000000
\

$0000ffff constant TZC_TZC_REGION_ID_ACCESS0_NSAID_RD_EN            \ Region read enable for each NSAID Bit 0 is associated to NSAID = 0 ... bit 15 is associated to NSAID = 15.
$ffff0000 constant TZC_TZC_REGION_ID_ACCESS0_NSAID_WR_EN            \ Region write enable for each NSAID Bit 16 is associated to NSAID = 0 .. bit 31 is associated to NSAID = 15


\
\ @brief TZC region 1 base address low register
\ Address offset: 0x120
\ Reset value: 0x00000000
\

$fffff000 constant TZC_TZC_REGION_BASE_LOW1_BASE_ADDRESS_LOW        \ Base address bits[31:12] for region x


\
\ @brief TZC regions 1 top address low register
\ Address offset: 0x128
\ Reset value: 0x00000FFF
\

$fffff000 constant TZC_TZC_REGION_TOP_LOW1_TOP_ADDRESS_LOW          \ Top address bits [31:12] of region x


\
\ @brief TZC region 1 attribute register
\ Address offset: 0x130
\ Reset value: 0x00000000
\

$00000001 constant TZC_TZC_REGION_ATTRIBUTE1_FILTER_EN              \ Region enable for the filter
$40000000 constant TZC_TZC_REGION_ATTRIBUTE1_S_RD_EN                \ Secure global read enable
$80000000 constant TZC_TZC_REGION_ATTRIBUTE1_S_WR_EN                \ Secure global write enable


\
\ @brief TZC region 1 ID access register
\ Address offset: 0x134
\ Reset value: 0x00000000
\

$0000ffff constant TZC_TZC_REGION_ID_ACCESS1_NSAID_RD_EN            \ Region read enable for each NSAID Bit 0 is associated to NSAID = 0 ... bit 15 is associated to NSAID = 15.
$ffff0000 constant TZC_TZC_REGION_ID_ACCESS1_NSAID_WR_EN            \ Region write enable for each NSAID Bit 16 is associated to NSAID = 0 .. bit 31 is associated to NSAID = 15


\
\ @brief TZC region 2 base address low register
\ Address offset: 0x140
\ Reset value: 0x00000000
\

$fffff000 constant TZC_TZC_REGION_BASE_LOW2_BASE_ADDRESS_LOW        \ Base address bits[31:12] for region x


\
\ @brief TZC regions 2 top address low register
\ Address offset: 0x148
\ Reset value: 0x00000FFF
\

$fffff000 constant TZC_TZC_REGION_TOP_LOW2_TOP_ADDRESS_LOW          \ Top address bits [31:12] of region x


\
\ @brief TZC region 2 attribute register
\ Address offset: 0x150
\ Reset value: 0x00000000
\

$00000001 constant TZC_TZC_REGION_ATTRIBUTE2_FILTER_EN              \ Region enable for the filter
$40000000 constant TZC_TZC_REGION_ATTRIBUTE2_S_RD_EN                \ Secure global read enable
$80000000 constant TZC_TZC_REGION_ATTRIBUTE2_S_WR_EN                \ Secure global write enable


\
\ @brief TZC region 2 ID access register
\ Address offset: 0x154
\ Reset value: 0x00000000
\

$0000ffff constant TZC_TZC_REGION_ID_ACCESS2_NSAID_RD_EN            \ Region read enable for each NSAID Bit 0 is associated to NSAID = 0 ... bit 15 is associated to NSAID = 15.
$ffff0000 constant TZC_TZC_REGION_ID_ACCESS2_NSAID_WR_EN            \ Region write enable for each NSAID Bit 16 is associated to NSAID = 0 .. bit 31 is associated to NSAID = 15


\
\ @brief TZC region 3 base address low register
\ Address offset: 0x160
\ Reset value: 0x00000000
\

$fffff000 constant TZC_TZC_REGION_BASE_LOW3_BASE_ADDRESS_LOW        \ Base address bits[31:12] for region x


\
\ @brief TZC regions 3 top address low register
\ Address offset: 0x168
\ Reset value: 0x00000FFF
\

$fffff000 constant TZC_TZC_REGION_TOP_LOW3_TOP_ADDRESS_LOW          \ Top address bits [31:12] of region x


\
\ @brief TZC region 3 attribute register
\ Address offset: 0x170
\ Reset value: 0x00000000
\

$00000001 constant TZC_TZC_REGION_ATTRIBUTE3_FILTER_EN              \ Region enable for the filter
$40000000 constant TZC_TZC_REGION_ATTRIBUTE3_S_RD_EN                \ Secure global read enable
$80000000 constant TZC_TZC_REGION_ATTRIBUTE3_S_WR_EN                \ Secure global write enable


\
\ @brief TZC region 3 ID access register
\ Address offset: 0x174
\ Reset value: 0x00000000
\

$0000ffff constant TZC_TZC_REGION_ID_ACCESS3_NSAID_RD_EN            \ Region read enable for each NSAID Bit 0 is associated to NSAID = 0 ... bit 15 is associated to NSAID = 15.
$ffff0000 constant TZC_TZC_REGION_ID_ACCESS3_NSAID_WR_EN            \ Region write enable for each NSAID Bit 16 is associated to NSAID = 0 .. bit 31 is associated to NSAID = 15


\
\ @brief TZC region 4 base address low register
\ Address offset: 0x180
\ Reset value: 0x00000000
\

$fffff000 constant TZC_TZC_REGION_BASE_LOW4_BASE_ADDRESS_LOW        \ Base address bits[31:12] for region x


\
\ @brief TZC regions 4 top address low register
\ Address offset: 0x188
\ Reset value: 0x00000FFF
\

$fffff000 constant TZC_TZC_REGION_TOP_LOW4_TOP_ADDRESS_LOW          \ Top address bits [31:12] of region x


\
\ @brief TZC region 4 attribute register
\ Address offset: 0x190
\ Reset value: 0x00000000
\

$00000001 constant TZC_TZC_REGION_ATTRIBUTE4_FILTER_EN              \ Region enable for the filter
$40000000 constant TZC_TZC_REGION_ATTRIBUTE4_S_RD_EN                \ Secure global read enable
$80000000 constant TZC_TZC_REGION_ATTRIBUTE4_S_WR_EN                \ Secure global write enable


\
\ @brief TZC region 4 ID access register
\ Address offset: 0x194
\ Reset value: 0x00000000
\

$0000ffff constant TZC_TZC_REGION_ID_ACCESS4_NSAID_RD_EN            \ Region read enable for each NSAID Bit 0 is associated to NSAID = 0 ... bit 15 is associated to NSAID = 15.
$ffff0000 constant TZC_TZC_REGION_ID_ACCESS4_NSAID_WR_EN            \ Region write enable for each NSAID Bit 16 is associated to NSAID = 0 .. bit 31 is associated to NSAID = 15


\
\ @brief TZC region 5 base address low register
\ Address offset: 0x1A0
\ Reset value: 0x00000000
\

$fffff000 constant TZC_TZC_REGION_BASE_LOW5_BASE_ADDRESS_LOW        \ Base address bits[31:12] for region x


\
\ @brief TZC regions 5 top address low register
\ Address offset: 0x1A8
\ Reset value: 0x00000FFF
\

$fffff000 constant TZC_TZC_REGION_TOP_LOW5_TOP_ADDRESS_LOW          \ Top address bits [31:12] of region x


\
\ @brief TZC region 5 attribute register
\ Address offset: 0x1B0
\ Reset value: 0x00000000
\

$00000001 constant TZC_TZC_REGION_ATTRIBUTE5_FILTER_EN              \ Region enable for the filter
$40000000 constant TZC_TZC_REGION_ATTRIBUTE5_S_RD_EN                \ Secure global read enable
$80000000 constant TZC_TZC_REGION_ATTRIBUTE5_S_WR_EN                \ Secure global write enable


\
\ @brief TZC region 5 ID access register
\ Address offset: 0x1B4
\ Reset value: 0x00000000
\

$0000ffff constant TZC_TZC_REGION_ID_ACCESS5_NSAID_RD_EN            \ Region read enable for each NSAID Bit 0 is associated to NSAID = 0 ... bit 15 is associated to NSAID = 15.
$ffff0000 constant TZC_TZC_REGION_ID_ACCESS5_NSAID_WR_EN            \ Region write enable for each NSAID Bit 16 is associated to NSAID = 0 .. bit 31 is associated to NSAID = 15


\
\ @brief TZC region 6 base address low register
\ Address offset: 0x1C0
\ Reset value: 0x00000000
\

$fffff000 constant TZC_TZC_REGION_BASE_LOW6_BASE_ADDRESS_LOW        \ Base address bits[31:12] for region x


\
\ @brief TZC regions 6 top address low register
\ Address offset: 0x1C8
\ Reset value: 0x00000FFF
\

$fffff000 constant TZC_TZC_REGION_TOP_LOW6_TOP_ADDRESS_LOW          \ Top address bits [31:12] of region x


\
\ @brief TZC region 6 attribute register
\ Address offset: 0x1D0
\ Reset value: 0x00000000
\

$00000001 constant TZC_TZC_REGION_ATTRIBUTE6_FILTER_EN              \ Region enable for the filter
$40000000 constant TZC_TZC_REGION_ATTRIBUTE6_S_RD_EN                \ Secure global read enable
$80000000 constant TZC_TZC_REGION_ATTRIBUTE6_S_WR_EN                \ Secure global write enable


\
\ @brief TZC region 6 ID access register
\ Address offset: 0x1D4
\ Reset value: 0x00000000
\

$0000ffff constant TZC_TZC_REGION_ID_ACCESS6_NSAID_RD_EN            \ Region read enable for each NSAID Bit 0 is associated to NSAID = 0 ... bit 15 is associated to NSAID = 15.
$ffff0000 constant TZC_TZC_REGION_ID_ACCESS6_NSAID_WR_EN            \ Region write enable for each NSAID Bit 16 is associated to NSAID = 0 .. bit 31 is associated to NSAID = 15


\
\ @brief TZC region 7 base address low register
\ Address offset: 0x1E0
\ Reset value: 0x00000000
\

$fffff000 constant TZC_TZC_REGION_BASE_LOW7_BASE_ADDRESS_LOW        \ Base address bits[31:12] for region x


\
\ @brief TZC regions 7 top address low register
\ Address offset: 0x1E8
\ Reset value: 0x00000FFF
\

$fffff000 constant TZC_TZC_REGION_TOP_LOW7_TOP_ADDRESS_LOW          \ Top address bits [31:12] of region x


\
\ @brief TZC region 7 attribute register
\ Address offset: 0x1F0
\ Reset value: 0x00000000
\

$00000001 constant TZC_TZC_REGION_ATTRIBUTE7_FILTER_EN              \ Region enable for the filter
$40000000 constant TZC_TZC_REGION_ATTRIBUTE7_S_RD_EN                \ Secure global read enable
$80000000 constant TZC_TZC_REGION_ATTRIBUTE7_S_WR_EN                \ Secure global write enable


\
\ @brief TZC region 7 ID access register
\ Address offset: 0x1F4
\ Reset value: 0x00000000
\

$0000ffff constant TZC_TZC_REGION_ID_ACCESS7_NSAID_RD_EN            \ Region read enable for each NSAID Bit 0 is associated to NSAID = 0 ... bit 15 is associated to NSAID = 15.
$ffff0000 constant TZC_TZC_REGION_ID_ACCESS7_NSAID_WR_EN            \ Region write enable for each NSAID Bit 16 is associated to NSAID = 0 .. bit 31 is associated to NSAID = 15


\
\ @brief TZC region 8 base address low register
\ Address offset: 0x200
\ Reset value: 0x00000000
\

$fffff000 constant TZC_TZC_REGION_BASE_LOW8_BASE_ADDRESS_LOW        \ Base address bits[31:12] for region x


\
\ @brief TZC regions 8 top address low register
\ Address offset: 0x208
\ Reset value: 0x00000FFF
\

$fffff000 constant TZC_TZC_REGION_TOP_LOW8_TOP_ADDRESS_LOW          \ Top address bits [31:12] of region x


\
\ @brief TZC region 8 attribute register
\ Address offset: 0x210
\ Reset value: 0x00000000
\

$00000001 constant TZC_TZC_REGION_ATTRIBUTE8_FILTER_EN              \ Region enable for the filter
$40000000 constant TZC_TZC_REGION_ATTRIBUTE8_S_RD_EN                \ Secure global read enable
$80000000 constant TZC_TZC_REGION_ATTRIBUTE8_S_WR_EN                \ Secure global write enable


\
\ @brief TZC region 8 ID access register
\ Address offset: 0x214
\ Reset value: 0x00000000
\

$0000ffff constant TZC_TZC_REGION_ID_ACCESS8_NSAID_RD_EN            \ Region read enable for each NSAID Bit 0 is associated to NSAID = 0 ... bit 15 is associated to NSAID = 15.
$ffff0000 constant TZC_TZC_REGION_ID_ACCESS8_NSAID_WR_EN            \ Region write enable for each NSAID Bit 16 is associated to NSAID = 0 .. bit 31 is associated to NSAID = 15


\
\ @brief TZC peripheral ID 4 register
\ Address offset: 0xFD0
\ Reset value: 0x00000004
\

$000000ff constant TZC_TZC_PID4_PER_ID_4                            \ Peripheral ID 4


\
\ @brief TZC peripheral ID 5 register
\ Address offset: 0xFD4
\ Reset value: 0x00000000
\

$000000ff constant TZC_TZC_PID5_PER_ID_5                            \ Peripheral ID 5


\
\ @brief TZC peripheral ID 6 register
\ Address offset: 0xFD8
\ Reset value: 0x00000000
\

$000000ff constant TZC_TZC_PID6_PER_ID_6                            \ Peripheral ID 6


\
\ @brief TZC peripheral ID 7 register
\ Address offset: 0xFDC
\ Reset value: 0x00000000
\

$000000ff constant TZC_TZC_PID7_PER_ID_7                            \ Peripheral ID 7


\
\ @brief TZC peripheral ID 0 register
\ Address offset: 0xFE0
\ Reset value: 0x00000060
\

$000000ff constant TZC_TZC_PID0_PER_ID_0                            \ Peripheral ID 0


\
\ @brief TZC peripheral ID 1 register
\ Address offset: 0xFE4
\ Reset value: 0x000000B4
\

$000000ff constant TZC_TZC_PID1_PER_ID_1                            \ Peripheral ID 1


\
\ @brief TZC peripheral ID 2 register
\ Address offset: 0xFE8
\ Reset value: 0x0000002B
\

$000000ff constant TZC_TZC_PID2_PER_ID_2                            \ Peripheral ID 2


\
\ @brief TZC peripheral ID 3 register
\ Address offset: 0xFEC
\ Reset value: 0x00000000
\

$000000ff constant TZC_TZC_PID3_PER_ID_3                            \ Peripheral ID 3


\
\ @brief TZC component ID 0 register
\ Address offset: 0xFF0
\ Reset value: 0x0000000D
\

$000000ff constant TZC_TZC_CID0_COMP_ID_0                           \ Component ID 0


\
\ @brief TZC component ID 1 register
\ Address offset: 0xFF4
\ Reset value: 0x000000F0
\

$000000ff constant TZC_TZC_CID1_COMP_ID_1                           \ Component ID 0


\
\ @brief TZC component ID 2 register
\ Address offset: 0xFF8
\ Reset value: 0x00000005
\

$000000ff constant TZC_TZC_CID2_COMP_ID_2                           \ Component ID 2


\
\ @brief TZC component ID 3 register
\ Address offset: 0xFFC
\ Reset value: 0x000000B1
\

$000000ff constant TZC_TZC_CID3_COMP_ID_3                           \ Component ID 3


\
\ @brief TZC
\
$5c006000 constant TZC_TZC_BUILD_CONFIG  \ offset: 0x00 : TZC configuration register
$5c006004 constant TZC_TZC_ACTION  \ offset: 0x04 : TZC action register
$5c006008 constant TZC_TZC_GATE_KEEPER  \ offset: 0x08 : TZC gate keeper register
$5c00600c constant TZC_TZC_SPECULATION_CTRL  \ offset: 0x0C : TZC speculation control register
$5c006010 constant TZC_TZC_INT_STATUS  \ offset: 0x10 : TZC interrupt status register
$5c006014 constant TZC_TZC_INT_CLEAR  \ offset: 0x14 : TZC interrupt clear register
$5c006020 constant TZC_TZC_FAIL_ADDRESS_LOW  \ offset: 0x20 : TZC fail address low register x
$5c006028 constant TZC_TZC_FAIL_CONTROL  \ offset: 0x28 : TZC fail control register x
$5c00602c constant TZC_TZC_FAIL_ID  \ offset: 0x2C : TZC fail ID register x
$5c006100 constant TZC_TZC_REGION_BASE_LOW0  \ offset: 0x100 : TZC region 0 base address low register
$5c006108 constant TZC_TZC_REGION_TOP_LOW0  \ offset: 0x108 : TZC region 0 top address low register
$5c006110 constant TZC_TZC_REGION_ATTRIBUTE0  \ offset: 0x110 : TZC region 0 attribute register
$5c006114 constant TZC_TZC_REGION_ID_ACCESS0  \ offset: 0x114 : TZC region 0 ID access register
$5c006120 constant TZC_TZC_REGION_BASE_LOW1  \ offset: 0x120 : TZC region 1 base address low register
$5c006128 constant TZC_TZC_REGION_TOP_LOW1  \ offset: 0x128 : TZC regions 1 top address low register
$5c006130 constant TZC_TZC_REGION_ATTRIBUTE1  \ offset: 0x130 : TZC region 1 attribute register
$5c006134 constant TZC_TZC_REGION_ID_ACCESS1  \ offset: 0x134 : TZC region 1 ID access register
$5c006140 constant TZC_TZC_REGION_BASE_LOW2  \ offset: 0x140 : TZC region 2 base address low register
$5c006148 constant TZC_TZC_REGION_TOP_LOW2  \ offset: 0x148 : TZC regions 2 top address low register
$5c006150 constant TZC_TZC_REGION_ATTRIBUTE2  \ offset: 0x150 : TZC region 2 attribute register
$5c006154 constant TZC_TZC_REGION_ID_ACCESS2  \ offset: 0x154 : TZC region 2 ID access register
$5c006160 constant TZC_TZC_REGION_BASE_LOW3  \ offset: 0x160 : TZC region 3 base address low register
$5c006168 constant TZC_TZC_REGION_TOP_LOW3  \ offset: 0x168 : TZC regions 3 top address low register
$5c006170 constant TZC_TZC_REGION_ATTRIBUTE3  \ offset: 0x170 : TZC region 3 attribute register
$5c006174 constant TZC_TZC_REGION_ID_ACCESS3  \ offset: 0x174 : TZC region 3 ID access register
$5c006180 constant TZC_TZC_REGION_BASE_LOW4  \ offset: 0x180 : TZC region 4 base address low register
$5c006188 constant TZC_TZC_REGION_TOP_LOW4  \ offset: 0x188 : TZC regions 4 top address low register
$5c006190 constant TZC_TZC_REGION_ATTRIBUTE4  \ offset: 0x190 : TZC region 4 attribute register
$5c006194 constant TZC_TZC_REGION_ID_ACCESS4  \ offset: 0x194 : TZC region 4 ID access register
$5c0061a0 constant TZC_TZC_REGION_BASE_LOW5  \ offset: 0x1A0 : TZC region 5 base address low register
$5c0061a8 constant TZC_TZC_REGION_TOP_LOW5  \ offset: 0x1A8 : TZC regions 5 top address low register
$5c0061b0 constant TZC_TZC_REGION_ATTRIBUTE5  \ offset: 0x1B0 : TZC region 5 attribute register
$5c0061b4 constant TZC_TZC_REGION_ID_ACCESS5  \ offset: 0x1B4 : TZC region 5 ID access register
$5c0061c0 constant TZC_TZC_REGION_BASE_LOW6  \ offset: 0x1C0 : TZC region 6 base address low register
$5c0061c8 constant TZC_TZC_REGION_TOP_LOW6  \ offset: 0x1C8 : TZC regions 6 top address low register
$5c0061d0 constant TZC_TZC_REGION_ATTRIBUTE6  \ offset: 0x1D0 : TZC region 6 attribute register
$5c0061d4 constant TZC_TZC_REGION_ID_ACCESS6  \ offset: 0x1D4 : TZC region 6 ID access register
$5c0061e0 constant TZC_TZC_REGION_BASE_LOW7  \ offset: 0x1E0 : TZC region 7 base address low register
$5c0061e8 constant TZC_TZC_REGION_TOP_LOW7  \ offset: 0x1E8 : TZC regions 7 top address low register
$5c0061f0 constant TZC_TZC_REGION_ATTRIBUTE7  \ offset: 0x1F0 : TZC region 7 attribute register
$5c0061f4 constant TZC_TZC_REGION_ID_ACCESS7  \ offset: 0x1F4 : TZC region 7 ID access register
$5c006200 constant TZC_TZC_REGION_BASE_LOW8  \ offset: 0x200 : TZC region 8 base address low register
$5c006208 constant TZC_TZC_REGION_TOP_LOW8  \ offset: 0x208 : TZC regions 8 top address low register
$5c006210 constant TZC_TZC_REGION_ATTRIBUTE8  \ offset: 0x210 : TZC region 8 attribute register
$5c006214 constant TZC_TZC_REGION_ID_ACCESS8  \ offset: 0x214 : TZC region 8 ID access register
$5c006fd0 constant TZC_TZC_PID4   \ offset: 0xFD0 : TZC peripheral ID 4 register
$5c006fd4 constant TZC_TZC_PID5   \ offset: 0xFD4 : TZC peripheral ID 5 register
$5c006fd8 constant TZC_TZC_PID6   \ offset: 0xFD8 : TZC peripheral ID 6 register
$5c006fdc constant TZC_TZC_PID7   \ offset: 0xFDC : TZC peripheral ID 7 register
$5c006fe0 constant TZC_TZC_PID0   \ offset: 0xFE0 : TZC peripheral ID 0 register
$5c006fe4 constant TZC_TZC_PID1   \ offset: 0xFE4 : TZC peripheral ID 1 register
$5c006fe8 constant TZC_TZC_PID2   \ offset: 0xFE8 : TZC peripheral ID 2 register
$5c006fec constant TZC_TZC_PID3   \ offset: 0xFEC : TZC peripheral ID 3 register
$5c006ff0 constant TZC_TZC_CID0   \ offset: 0xFF0 : TZC component ID 0 register
$5c006ff4 constant TZC_TZC_CID1   \ offset: 0xFF4 : TZC component ID 1 register
$5c006ff8 constant TZC_TZC_CID2   \ offset: 0xFF8 : TZC component ID 2 register
$5c006ffc constant TZC_TZC_CID3   \ offset: 0xFFC : TZC component ID 3 register

