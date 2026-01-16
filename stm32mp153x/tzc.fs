\
\ @file tzc.fs
\ @brief TZC
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief Provides information about TZC configuration.
\ Address offset: 0x00
\ Reset value: 0x01001F08
\

$0000001f constant TZC_TZC_BUILD_CONFIG_NO_OF_REGIONS               \ NO_OF_REGIONS
$00003f00 constant TZC_TZC_BUILD_CONFIG_ADDRESS_WIDTH               \ ADDRESS_WIDTH
$03000000 constant TZC_TZC_BUILD_CONFIG_NO_OF_FILTERS               \ NO_OF_FILTERS


\
\ @brief Controls interrupt and bus error response behavior when regions permission failures occur.
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000003 constant TZC_TZC_ACTION_REACTION_VALUE                    \ REACTION_VALUE


\
\ @brief Provides control and status for the gate keeper in each filter unit implemented.
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000003 constant TZC_TZC_GATE_KEEPER_OPENREQ                      \ OPENREQ
$00030000 constant TZC_TZC_GATE_KEEPER_OPENSTAT                     \ OPENSTAT


\
\ @brief Controls read and write access speculation.
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000001 constant TZC_TZC_SPECULATION_CTRL_READSPEC_DISABLE        \ READSPEC_DISABLE
$00000002 constant TZC_TZC_SPECULATION_CTRL_WRITESPEC_DISABLE       \ WRITESPEC_DISABLE


\
\ @brief Contains the status of the interrupt signal, TZCINT, that reports access security violations or region overlap errors.
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000003 constant TZC_TZC_INT_STATUS_STATUS                        \ STATUS
$00000300 constant TZC_TZC_INT_STATUS_OVERRUN                       \ OVERRUN
$00030000 constant TZC_TZC_INT_STATUS_OVERLAP                       \ OVERLAP


\
\ @brief Interrupt clear for each filter.
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000003 constant TZC_TZC_INT_CLEAR_CLEAR                          \ CLEAR


\
\ @brief Address low bits of the first failed access in the associated filter (0 to 1).
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000000 constant TZC_TZC_FAIL_ADDRESS_LOW0_ADDR_STATUS_LOW        \ ADDR_STATUS_LOW


\
\ @brief Address high bit of the first failed access in the associated filter (0 to 1). Not used with 32bit address.
\ Address offset: 0x24
\ Reset value: 0x00000000
\


\
\ @brief Status information about the first access that failed a region permission check in the associated filter (0 to 1).
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$00100000 constant TZC_TZC_FAIL_CONTROL0_PRIVILEGE                  \ PRIVILEGE
$00200000 constant TZC_TZC_FAIL_CONTROL0_NON_SECURE                 \ NON_SECURE
$01000000 constant TZC_TZC_FAIL_CONTROL0_DIRECTION                  \ DIRECTION


\
\ @brief Contains the master AXI ARID or AWID of the first access that failed a region permission check in the associated filter unit. This occurs even if the ACTION register is set to not drive the interrupt signal. AXI ID mapping is described in Table4: NSAID definition table (TBD).
\ Address offset: 0x2C
\ Reset value: 0x00000000
\

$000007ff constant TZC_TZC_FAIL_ID0_ID                              \ ID


\
\ @brief Address low bits of the first failed access in the associated filter (0 to 1).
\ Address offset: 0x30
\ Reset value: 0x00000000
\

$00000000 constant TZC_TZC_FAIL_ADDRESS_LOW1_ADDR_STATUS_LOW        \ ADDR_STATUS_LOW


\
\ @brief Address high bit of the first failed access in the associated filter (0 to 1). Not used with 32bit address.
\ Address offset: 0x34
\ Reset value: 0x00000000
\


\
\ @brief Status information about the first access that failed a region permission check in the associated filter (0 to 1).
\ Address offset: 0x38
\ Reset value: 0x00000000
\

$00100000 constant TZC_TZC_FAIL_CONTROL1_PRIVILEGE                  \ PRIVILEGE
$00200000 constant TZC_TZC_FAIL_CONTROL1_NON_SECURE                 \ NON_SECURE
$01000000 constant TZC_TZC_FAIL_CONTROL1_DIRECTION                  \ DIRECTION


\
\ @brief Contains the master AXI ARID or AWID of the first access that failed a region permission check in the associated filter unit. This occurs even if the ACTION register is set to not drive the interrupt signal. AXI ID mapping is described in Table4: NSAID definition table (TBD).
\ Address offset: 0x3C
\ Reset value: 0x00000000
\

$000007ff constant TZC_TZC_FAIL_ID1_ID                              \ ID


\
\ @brief Base address high are not used with 32-bit address.
\ Address offset: 0x104
\ Reset value: 0x00000000
\


\
\ @brief Top address bits [31:12] for region 0.
\ Address offset: 0x108
\ Reset value: 0xFFFFFFFF
\

$fffff000 constant TZC_TZC_REGION_TOP_LOW0_TOP_ADDRESS_LOW          \ TOP_ADDRESS_LOW


\
\ @brief Top address high of region are not used with 32-bit address.
\ Address offset: 0x10C
\ Reset value: 0x00000000
\


\
\ @brief Region 0 attributes.
\ Address offset: 0x110
\ Reset value: 0x00000003
\

$00000003 constant TZC_TZC_REGION_ATTRIBUTE0_FILTER_EN              \ FILTER_EN
$40000000 constant TZC_TZC_REGION_ATTRIBUTE0_S_RD_EN                \ S_RD_EN
$80000000 constant TZC_TZC_REGION_ATTRIBUTE0_S_WR_EN                \ S_WR_EN


\
\ @brief Region non-secure access based on NSAID.
\ Address offset: 0x114
\ Reset value: 0x00000000
\

$0000ffff constant TZC_TZC_REGION_ID_ACCESS0_NSAID_RD_EN            \ NSAID_RD_EN
$ffff0000 constant TZC_TZC_REGION_ID_ACCESS0_NSAID_WR_EN            \ NSAID_WR_EN


\
\ @brief Base address low for regions 1 to 8.
\ Address offset: 0x120
\ Reset value: 0x00000000
\

$fffff000 constant TZC_TZC_REGION_BASE_LOW1_BASE_ADDRESS_LOW        \ BASE_ADDRESS_LOW


\
\ @brief Base address high are not used with 32-bit address.
\ Address offset: 0x124
\ Reset value: 0x00000000
\


\
\ @brief Top address bits [31:12] for region x.
\ Address offset: 0x128
\ Reset value: 0x00000FFF
\

$fffff000 constant TZC_TZC_REGION_TOP_LOW1_TOP_ADDRESS_LOW          \ TOP_ADDRESS_LOW


\
\ @brief Top address high of region are not used with 32-bit address.
\ Address offset: 0x12C
\ Reset value: 0x00000000
\


\
\ @brief Region x attributes.
\ Address offset: 0x130
\ Reset value: 0x00000000
\

$00000003 constant TZC_TZC_REGION_ATTRIBUTE1_FILTER_EN              \ FILTER_EN
$40000000 constant TZC_TZC_REGION_ATTRIBUTE1_S_RD_EN                \ S_RD_EN
$80000000 constant TZC_TZC_REGION_ATTRIBUTE1_S_WR_EN                \ S_WR_EN


\
\ @brief Region non-secure access based on NSAID.
\ Address offset: 0x134
\ Reset value: 0x00000000
\

$0000ffff constant TZC_TZC_REGION_ID_ACCESS1_NSAID_RD_EN            \ NSAID_RD_EN
$ffff0000 constant TZC_TZC_REGION_ID_ACCESS1_NSAID_WR_EN            \ NSAID_WR_EN


\
\ @brief Base address low for regions 1 to 8.
\ Address offset: 0x140
\ Reset value: 0x00000000
\

$fffff000 constant TZC_TZC_REGION_BASE_LOW2_BASE_ADDRESS_LOW        \ BASE_ADDRESS_LOW


\
\ @brief Base address high are not used with 32-bit address.
\ Address offset: 0x144
\ Reset value: 0x00000000
\


\
\ @brief Top address bits [31:12] for region x.
\ Address offset: 0x148
\ Reset value: 0x00000FFF
\

$fffff000 constant TZC_TZC_REGION_TOP_LOW2_TOP_ADDRESS_LOW          \ TOP_ADDRESS_LOW


\
\ @brief Top address high of region are not used with 32-bit address.
\ Address offset: 0x14C
\ Reset value: 0x00000000
\


\
\ @brief Region x attributes.
\ Address offset: 0x150
\ Reset value: 0x00000000
\

$00000003 constant TZC_TZC_REGION_ATTRIBUTE2_FILTER_EN              \ FILTER_EN
$40000000 constant TZC_TZC_REGION_ATTRIBUTE2_S_RD_EN                \ S_RD_EN
$80000000 constant TZC_TZC_REGION_ATTRIBUTE2_S_WR_EN                \ S_WR_EN


\
\ @brief Region non-secure access based on NSAID.
\ Address offset: 0x154
\ Reset value: 0x00000000
\

$0000ffff constant TZC_TZC_REGION_ID_ACCESS2_NSAID_RD_EN            \ NSAID_RD_EN
$ffff0000 constant TZC_TZC_REGION_ID_ACCESS2_NSAID_WR_EN            \ NSAID_WR_EN


\
\ @brief Base address low for regions 1 to 8.
\ Address offset: 0x160
\ Reset value: 0x00000000
\

$fffff000 constant TZC_TZC_REGION_BASE_LOW3_BASE_ADDRESS_LOW        \ BASE_ADDRESS_LOW


\
\ @brief Base address high are not used with 32-bit address.
\ Address offset: 0x164
\ Reset value: 0x00000000
\


\
\ @brief Top address bits [31:12] for region x.
\ Address offset: 0x168
\ Reset value: 0x00000FFF
\

$fffff000 constant TZC_TZC_REGION_TOP_LOW3_TOP_ADDRESS_LOW          \ TOP_ADDRESS_LOW


\
\ @brief Top address high of region are not used with 32-bit address.
\ Address offset: 0x16C
\ Reset value: 0x00000000
\


\
\ @brief Region x attributes.
\ Address offset: 0x170
\ Reset value: 0x00000000
\

$00000003 constant TZC_TZC_REGION_ATTRIBUTE3_FILTER_EN              \ FILTER_EN
$40000000 constant TZC_TZC_REGION_ATTRIBUTE3_S_RD_EN                \ S_RD_EN
$80000000 constant TZC_TZC_REGION_ATTRIBUTE3_S_WR_EN                \ S_WR_EN


\
\ @brief Region non-secure access based on NSAID.
\ Address offset: 0x174
\ Reset value: 0x00000000
\

$0000ffff constant TZC_TZC_REGION_ID_ACCESS3_NSAID_RD_EN            \ NSAID_RD_EN
$ffff0000 constant TZC_TZC_REGION_ID_ACCESS3_NSAID_WR_EN            \ NSAID_WR_EN


\
\ @brief Base address low for regions 1 to 8.
\ Address offset: 0x180
\ Reset value: 0x00000000
\

$fffff000 constant TZC_TZC_REGION_BASE_LOW4_BASE_ADDRESS_LOW        \ BASE_ADDRESS_LOW


\
\ @brief Base address high are not used with 32-bit address.
\ Address offset: 0x184
\ Reset value: 0x00000000
\


\
\ @brief Top address bits [31:12] for region x.
\ Address offset: 0x188
\ Reset value: 0x00000FFF
\

$fffff000 constant TZC_TZC_REGION_TOP_LOW4_TOP_ADDRESS_LOW          \ TOP_ADDRESS_LOW


\
\ @brief Top address high of region are not used with 32-bit address.
\ Address offset: 0x18C
\ Reset value: 0x00000000
\


\
\ @brief Region x attributes.
\ Address offset: 0x190
\ Reset value: 0x00000000
\

$00000003 constant TZC_TZC_REGION_ATTRIBUTE4_FILTER_EN              \ FILTER_EN
$40000000 constant TZC_TZC_REGION_ATTRIBUTE4_S_RD_EN                \ S_RD_EN
$80000000 constant TZC_TZC_REGION_ATTRIBUTE4_S_WR_EN                \ S_WR_EN


\
\ @brief Region non-secure access based on NSAID.
\ Address offset: 0x194
\ Reset value: 0x00000000
\

$0000ffff constant TZC_TZC_REGION_ID_ACCESS4_NSAID_RD_EN            \ NSAID_RD_EN
$ffff0000 constant TZC_TZC_REGION_ID_ACCESS4_NSAID_WR_EN            \ NSAID_WR_EN


\
\ @brief Base address low for regions 1 to 8.
\ Address offset: 0x1A0
\ Reset value: 0x00000000
\

$fffff000 constant TZC_TZC_REGION_BASE_LOW5_BASE_ADDRESS_LOW        \ BASE_ADDRESS_LOW


\
\ @brief Base address high are not used with 32-bit address.
\ Address offset: 0x1A4
\ Reset value: 0x00000000
\


\
\ @brief Top address bits [31:12] for region x.
\ Address offset: 0x1A8
\ Reset value: 0x00000FFF
\

$fffff000 constant TZC_TZC_REGION_TOP_LOW5_TOP_ADDRESS_LOW          \ TOP_ADDRESS_LOW


\
\ @brief Top address high of region are not used with 32-bit address.
\ Address offset: 0x1AC
\ Reset value: 0x00000000
\


\
\ @brief Region x attributes.
\ Address offset: 0x1B0
\ Reset value: 0x00000000
\

$00000003 constant TZC_TZC_REGION_ATTRIBUTE5_FILTER_EN              \ FILTER_EN
$40000000 constant TZC_TZC_REGION_ATTRIBUTE5_S_RD_EN                \ S_RD_EN
$80000000 constant TZC_TZC_REGION_ATTRIBUTE5_S_WR_EN                \ S_WR_EN


\
\ @brief Region non-secure access based on NSAID.
\ Address offset: 0x1B4
\ Reset value: 0x00000000
\

$0000ffff constant TZC_TZC_REGION_ID_ACCESS5_NSAID_RD_EN            \ NSAID_RD_EN
$ffff0000 constant TZC_TZC_REGION_ID_ACCESS5_NSAID_WR_EN            \ NSAID_WR_EN


\
\ @brief Base address low for regions 1 to 8.
\ Address offset: 0x1C0
\ Reset value: 0x00000000
\

$fffff000 constant TZC_TZC_REGION_BASE_LOW6_BASE_ADDRESS_LOW        \ BASE_ADDRESS_LOW


\
\ @brief Base address high are not used with 32-bit address.
\ Address offset: 0x1C4
\ Reset value: 0x00000000
\


\
\ @brief Top address bits [31:12] for region x.
\ Address offset: 0x1C8
\ Reset value: 0x00000FFF
\

$fffff000 constant TZC_TZC_REGION_TOP_LOW6_TOP_ADDRESS_LOW          \ TOP_ADDRESS_LOW


\
\ @brief Top address high of region are not used with 32-bit address.
\ Address offset: 0x1CC
\ Reset value: 0x00000000
\


\
\ @brief Region x attributes.
\ Address offset: 0x1D0
\ Reset value: 0x00000000
\

$00000003 constant TZC_TZC_REGION_ATTRIBUTE6_FILTER_EN              \ FILTER_EN
$40000000 constant TZC_TZC_REGION_ATTRIBUTE6_S_RD_EN                \ S_RD_EN
$80000000 constant TZC_TZC_REGION_ATTRIBUTE6_S_WR_EN                \ S_WR_EN


\
\ @brief Region non-secure access based on NSAID.
\ Address offset: 0x1D4
\ Reset value: 0x00000000
\

$0000ffff constant TZC_TZC_REGION_ID_ACCESS6_NSAID_RD_EN            \ NSAID_RD_EN
$ffff0000 constant TZC_TZC_REGION_ID_ACCESS6_NSAID_WR_EN            \ NSAID_WR_EN


\
\ @brief Top address bits [31:12] for region x.
\ Address offset: 0x1E8
\ Reset value: 0x00000FFF
\

$fffff000 constant TZC_TZC_REGION_TOP_LOW7_TOP_ADDRESS_LOW          \ TOP_ADDRESS_LOW


\
\ @brief Region x attributes.
\ Address offset: 0x1F0
\ Reset value: 0x00000000
\

$00000003 constant TZC_TZC_REGION_ATTRIBUTE7_FILTER_EN              \ FILTER_EN
$40000000 constant TZC_TZC_REGION_ATTRIBUTE7_S_RD_EN                \ S_RD_EN
$80000000 constant TZC_TZC_REGION_ATTRIBUTE7_S_WR_EN                \ S_WR_EN


\
\ @brief Base address low for regions 1 to 8.
\ Address offset: 0x200
\ Reset value: 0x00000000
\

$fffff000 constant TZC_TZC_REGION_BASE_LOW8_BASE_ADDRESS_LOW        \ BASE_ADDRESS_LOW


\
\ @brief Base address high are not used with 32-bit address.
\ Address offset: 0x204
\ Reset value: 0x00000000
\


\
\ @brief Region x attributes.
\ Address offset: 0x210
\ Reset value: 0x00000000
\

$00000003 constant TZC_TZC_REGION_ATTRIBUTE8_FILTER_EN              \ FILTER_EN
$40000000 constant TZC_TZC_REGION_ATTRIBUTE8_S_RD_EN                \ S_RD_EN
$80000000 constant TZC_TZC_REGION_ATTRIBUTE8_S_WR_EN                \ S_WR_EN


\
\ @brief Base address low for regions 1 to 8.
\ Address offset: 0x2E0
\ Reset value: 0x00000000
\

$fffff000 constant TZC_TZC_REGION_BASE_LOW7_BASE_ADDRESS_LOW        \ BASE_ADDRESS_LOW


\
\ @brief Base address high are not used with 32-bit address.
\ Address offset: 0x2E4
\ Reset value: 0x00000000
\


\
\ @brief Top address high of region are not used with 32-bit address.
\ Address offset: 0x2EC
\ Reset value: 0x00000000
\


\
\ @brief Region non-secure access based on NSAID.
\ Address offset: 0x2F4
\ Reset value: 0x00000000
\

$0000ffff constant TZC_TZC_REGION_ID_ACCESS7_NSAID_RD_EN            \ NSAID_RD_EN
$ffff0000 constant TZC_TZC_REGION_ID_ACCESS7_NSAID_WR_EN            \ NSAID_WR_EN


\
\ @brief Top address bits [31:12] for region x.
\ Address offset: 0x308
\ Reset value: 0x00000FFF
\

$fffff000 constant TZC_TZC_REGION_TOP_LOW8_TOP_ADDRESS_LOW          \ TOP_ADDRESS_LOW


\
\ @brief Top address high of region are not used with 32-bit address.
\ Address offset: 0x30C
\ Reset value: 0x00000000
\


\
\ @brief Region non-secure access based on NSAID.
\ Address offset: 0x314
\ Reset value: 0x00000000
\

$0000ffff constant TZC_TZC_REGION_ID_ACCESS8_NSAID_RD_EN            \ NSAID_RD_EN
$ffff0000 constant TZC_TZC_REGION_ID_ACCESS8_NSAID_WR_EN            \ NSAID_WR_EN


\
\ @brief Peripheral ID 4.
\ Address offset: 0xFD0
\ Reset value: 0x00000004
\

$000000ff constant TZC_TZC_PID4_PER_ID_4                            \ PER_ID_4


\
\ @brief Peripheral ID 5.
\ Address offset: 0xFD4
\ Reset value: 0x00000000
\

$000000ff constant TZC_TZC_PID5_PER_ID_5                            \ PER_ID_5


\
\ @brief Peripheral ID 6.
\ Address offset: 0xFD8
\ Reset value: 0x00000000
\

$000000ff constant TZC_TZC_PID6_PER_ID_6                            \ PER_ID_6


\
\ @brief Peripheral ID 7.
\ Address offset: 0xFDC
\ Reset value: 0x00000000
\

$000000ff constant TZC_TZC_PID7_PER_ID_7                            \ PER_ID_7


\
\ @brief Peripheral ID 0.
\ Address offset: 0xFE0
\ Reset value: 0x00000060
\

$000000ff constant TZC_TZC_PID0_PER_ID_0                            \ PER_ID_0


\
\ @brief Peripheral ID 1.
\ Address offset: 0xFE4
\ Reset value: 0x000000B4
\

$000000ff constant TZC_TZC_PID1_PER_ID_1                            \ PER_ID_1


\
\ @brief Peripheral ID 2.
\ Address offset: 0xFE8
\ Reset value: 0x0000002B
\

$000000ff constant TZC_TZC_PID2_PER_ID_2                            \ PER_ID_2


\
\ @brief Peripheral ID 3.
\ Address offset: 0xFEC
\ Reset value: 0x00000000
\

$000000ff constant TZC_TZC_PID3_PER_ID_3                            \ PER_ID_3


\
\ @brief Component ID 0.
\ Address offset: 0xFF0
\ Reset value: 0x0000000D
\

$000000ff constant TZC_TZC_CID0_COMP_ID_0                           \ COMP_ID_0


\
\ @brief Component ID 1.
\ Address offset: 0xFF4
\ Reset value: 0x000000F0
\

$000000ff constant TZC_TZC_CID1_COMP_ID_1                           \ COMP_ID_1


\
\ @brief Component ID 2.
\ Address offset: 0xFF8
\ Reset value: 0x00000005
\

$000000ff constant TZC_TZC_CID2_COMP_ID_2                           \ COMP_ID_2


\
\ @brief Component ID 3.
\ Address offset: 0xFFC
\ Reset value: 0x000000B1
\

$000000ff constant TZC_TZC_CID3_COMP_ID_3                           \ COMP_ID_3


\
\ @brief TZC
\
$5c006000 constant TZC_TZC_BUILD_CONFIG  \ offset: 0x00 : Provides information about TZC configuration.
$5c006004 constant TZC_TZC_ACTION  \ offset: 0x04 : Controls interrupt and bus error response behavior when regions permission failures occur.
$5c006008 constant TZC_TZC_GATE_KEEPER  \ offset: 0x08 : Provides control and status for the gate keeper in each filter unit implemented.
$5c00600c constant TZC_TZC_SPECULATION_CTRL  \ offset: 0x0C : Controls read and write access speculation.
$5c006010 constant TZC_TZC_INT_STATUS  \ offset: 0x10 : Contains the status of the interrupt signal, TZCINT, that reports access security violations or region overlap errors.
$5c006014 constant TZC_TZC_INT_CLEAR  \ offset: 0x14 : Interrupt clear for each filter.
$5c006020 constant TZC_TZC_FAIL_ADDRESS_LOW0  \ offset: 0x20 : Address low bits of the first failed access in the associated filter (0 to 1).
$5c006024 constant TZC_TZC_FAIL_ADDRESS_HIGH0  \ offset: 0x24 : Address high bit of the first failed access in the associated filter (0 to 1). Not used with 32bit address.
$5c006028 constant TZC_TZC_FAIL_CONTROL0  \ offset: 0x28 : Status information about the first access that failed a region permission check in the associated filter (0 to 1).
$5c00602c constant TZC_TZC_FAIL_ID0  \ offset: 0x2C : Contains the master AXI ARID or AWID of the first access that failed a region permission check in the associated filter unit. This occurs even if the ACTION register is set to not drive the interrupt signal. AXI ID mapping is described in Table4: NSAID definition table (TBD).
$5c006030 constant TZC_TZC_FAIL_ADDRESS_LOW1  \ offset: 0x30 : Address low bits of the first failed access in the associated filter (0 to 1).
$5c006034 constant TZC_TZC_FAIL_ADDRESS_HIGH1  \ offset: 0x34 : Address high bit of the first failed access in the associated filter (0 to 1). Not used with 32bit address.
$5c006038 constant TZC_TZC_FAIL_CONTROL1  \ offset: 0x38 : Status information about the first access that failed a region permission check in the associated filter (0 to 1).
$5c00603c constant TZC_TZC_FAIL_ID1  \ offset: 0x3C : Contains the master AXI ARID or AWID of the first access that failed a region permission check in the associated filter unit. This occurs even if the ACTION register is set to not drive the interrupt signal. AXI ID mapping is described in Table4: NSAID definition table (TBD).
$5c006104 constant TZC_TZC_REGION_BASE_HIGH0  \ offset: 0x104 : Base address high are not used with 32-bit address.
$5c006108 constant TZC_TZC_REGION_TOP_LOW0  \ offset: 0x108 : Top address bits [31:12] for region 0.
$5c00610c constant TZC_TZC_REGION_TOP_HIGH0  \ offset: 0x10C : Top address high of region are not used with 32-bit address.
$5c006110 constant TZC_TZC_REGION_ATTRIBUTE0  \ offset: 0x110 : Region 0 attributes.
$5c006114 constant TZC_TZC_REGION_ID_ACCESS0  \ offset: 0x114 : Region non-secure access based on NSAID.
$5c006120 constant TZC_TZC_REGION_BASE_LOW1  \ offset: 0x120 : Base address low for regions 1 to 8.
$5c006124 constant TZC_TZC_REGION_BASE_HIGH1  \ offset: 0x124 : Base address high are not used with 32-bit address.
$5c006128 constant TZC_TZC_REGION_TOP_LOW1  \ offset: 0x128 : Top address bits [31:12] for region x.
$5c00612c constant TZC_TZC_REGION_TOP_HIGH1  \ offset: 0x12C : Top address high of region are not used with 32-bit address.
$5c006130 constant TZC_TZC_REGION_ATTRIBUTE1  \ offset: 0x130 : Region x attributes.
$5c006134 constant TZC_TZC_REGION_ID_ACCESS1  \ offset: 0x134 : Region non-secure access based on NSAID.
$5c006140 constant TZC_TZC_REGION_BASE_LOW2  \ offset: 0x140 : Base address low for regions 1 to 8.
$5c006144 constant TZC_TZC_REGION_BASE_HIGH2  \ offset: 0x144 : Base address high are not used with 32-bit address.
$5c006148 constant TZC_TZC_REGION_TOP_LOW2  \ offset: 0x148 : Top address bits [31:12] for region x.
$5c00614c constant TZC_TZC_REGION_TOP_HIGH2  \ offset: 0x14C : Top address high of region are not used with 32-bit address.
$5c006150 constant TZC_TZC_REGION_ATTRIBUTE2  \ offset: 0x150 : Region x attributes.
$5c006154 constant TZC_TZC_REGION_ID_ACCESS2  \ offset: 0x154 : Region non-secure access based on NSAID.
$5c006160 constant TZC_TZC_REGION_BASE_LOW3  \ offset: 0x160 : Base address low for regions 1 to 8.
$5c006164 constant TZC_TZC_REGION_BASE_HIGH3  \ offset: 0x164 : Base address high are not used with 32-bit address.
$5c006168 constant TZC_TZC_REGION_TOP_LOW3  \ offset: 0x168 : Top address bits [31:12] for region x.
$5c00616c constant TZC_TZC_REGION_TOP_HIGH3  \ offset: 0x16C : Top address high of region are not used with 32-bit address.
$5c006170 constant TZC_TZC_REGION_ATTRIBUTE3  \ offset: 0x170 : Region x attributes.
$5c006174 constant TZC_TZC_REGION_ID_ACCESS3  \ offset: 0x174 : Region non-secure access based on NSAID.
$5c006180 constant TZC_TZC_REGION_BASE_LOW4  \ offset: 0x180 : Base address low for regions 1 to 8.
$5c006184 constant TZC_TZC_REGION_BASE_HIGH4  \ offset: 0x184 : Base address high are not used with 32-bit address.
$5c006188 constant TZC_TZC_REGION_TOP_LOW4  \ offset: 0x188 : Top address bits [31:12] for region x.
$5c00618c constant TZC_TZC_REGION_TOP_HIGH4  \ offset: 0x18C : Top address high of region are not used with 32-bit address.
$5c006190 constant TZC_TZC_REGION_ATTRIBUTE4  \ offset: 0x190 : Region x attributes.
$5c006194 constant TZC_TZC_REGION_ID_ACCESS4  \ offset: 0x194 : Region non-secure access based on NSAID.
$5c0061a0 constant TZC_TZC_REGION_BASE_LOW5  \ offset: 0x1A0 : Base address low for regions 1 to 8.
$5c0061a4 constant TZC_TZC_REGION_BASE_HIGH5  \ offset: 0x1A4 : Base address high are not used with 32-bit address.
$5c0061a8 constant TZC_TZC_REGION_TOP_LOW5  \ offset: 0x1A8 : Top address bits [31:12] for region x.
$5c0061ac constant TZC_TZC_REGION_TOP_HIGH5  \ offset: 0x1AC : Top address high of region are not used with 32-bit address.
$5c0061b0 constant TZC_TZC_REGION_ATTRIBUTE5  \ offset: 0x1B0 : Region x attributes.
$5c0061b4 constant TZC_TZC_REGION_ID_ACCESS5  \ offset: 0x1B4 : Region non-secure access based on NSAID.
$5c0061c0 constant TZC_TZC_REGION_BASE_LOW6  \ offset: 0x1C0 : Base address low for regions 1 to 8.
$5c0061c4 constant TZC_TZC_REGION_BASE_HIGH6  \ offset: 0x1C4 : Base address high are not used with 32-bit address.
$5c0061c8 constant TZC_TZC_REGION_TOP_LOW6  \ offset: 0x1C8 : Top address bits [31:12] for region x.
$5c0061cc constant TZC_TZC_REGION_TOP_HIGH6  \ offset: 0x1CC : Top address high of region are not used with 32-bit address.
$5c0061d0 constant TZC_TZC_REGION_ATTRIBUTE6  \ offset: 0x1D0 : Region x attributes.
$5c0061d4 constant TZC_TZC_REGION_ID_ACCESS6  \ offset: 0x1D4 : Region non-secure access based on NSAID.
$5c0061e8 constant TZC_TZC_REGION_TOP_LOW7  \ offset: 0x1E8 : Top address bits [31:12] for region x.
$5c0061f0 constant TZC_TZC_REGION_ATTRIBUTE7  \ offset: 0x1F0 : Region x attributes.
$5c006200 constant TZC_TZC_REGION_BASE_LOW8  \ offset: 0x200 : Base address low for regions 1 to 8.
$5c006204 constant TZC_TZC_REGION_BASE_HIGH8  \ offset: 0x204 : Base address high are not used with 32-bit address.
$5c006210 constant TZC_TZC_REGION_ATTRIBUTE8  \ offset: 0x210 : Region x attributes.
$5c0062e0 constant TZC_TZC_REGION_BASE_LOW7  \ offset: 0x2E0 : Base address low for regions 1 to 8.
$5c0062e4 constant TZC_TZC_REGION_BASE_HIGH7  \ offset: 0x2E4 : Base address high are not used with 32-bit address.
$5c0062ec constant TZC_TZC_REGION_TOP_HIGH7  \ offset: 0x2EC : Top address high of region are not used with 32-bit address.
$5c0062f4 constant TZC_TZC_REGION_ID_ACCESS7  \ offset: 0x2F4 : Region non-secure access based on NSAID.
$5c006308 constant TZC_TZC_REGION_TOP_LOW8  \ offset: 0x308 : Top address bits [31:12] for region x.
$5c00630c constant TZC_TZC_REGION_TOP_HIGH8  \ offset: 0x30C : Top address high of region are not used with 32-bit address.
$5c006314 constant TZC_TZC_REGION_ID_ACCESS8  \ offset: 0x314 : Region non-secure access based on NSAID.
$5c006fd0 constant TZC_TZC_PID4   \ offset: 0xFD0 : Peripheral ID 4.
$5c006fd4 constant TZC_TZC_PID5   \ offset: 0xFD4 : Peripheral ID 5.
$5c006fd8 constant TZC_TZC_PID6   \ offset: 0xFD8 : Peripheral ID 6.
$5c006fdc constant TZC_TZC_PID7   \ offset: 0xFDC : Peripheral ID 7.
$5c006fe0 constant TZC_TZC_PID0   \ offset: 0xFE0 : Peripheral ID 0.
$5c006fe4 constant TZC_TZC_PID1   \ offset: 0xFE4 : Peripheral ID 1.
$5c006fe8 constant TZC_TZC_PID2   \ offset: 0xFE8 : Peripheral ID 2.
$5c006fec constant TZC_TZC_PID3   \ offset: 0xFEC : Peripheral ID 3.
$5c006ff0 constant TZC_TZC_CID0   \ offset: 0xFF0 : Component ID 0.
$5c006ff4 constant TZC_TZC_CID1   \ offset: 0xFF4 : Component ID 1.
$5c006ff8 constant TZC_TZC_CID2   \ offset: 0xFF8 : Component ID 2.
$5c006ffc constant TZC_TZC_CID3   \ offset: 0xFFC : Component ID 3.

