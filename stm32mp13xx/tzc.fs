\
\ @file tzc.fs
\ @brief TZC
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] TZC_DEF

  [ifdef] TZC_TZC_BUILD_CONFIG_DEF
    \
    \ @brief TZC configuration register
    \ Address offset: 0x00
    \ Reset value: 0x00001F08
    \
    $00 constant TZC_NO_OF_REGIONS              \ [0x00 : 5] Number fo regions Others: Reserved
    $08 constant TZC_ADDRESS_WIDTH              \ [0x08 : 6] Address width Others: Reserved
    $18 constant TZC_NO_OF_FILTERS              \ [0x18] Number of filters
  [then]


  [ifdef] TZC_TZC_ACTION_DEF
    \
    \ @brief TZC action register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant TZC_REACTION_VALUE             \ [0x00 : 2] Permission failure reaction Controls how TZC signals region permission failure. 2: set tzcint high and issue OKAY on the bus 3: set tzcint high and issue DECERR on the bus
  [then]


  [ifdef] TZC_TZC_GATE_KEEPER_DEF
    \
    \ @brief TZC gate keeper register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant TZC_OPENREQ                    \ [0x00] Gate keeper open request for filter
    $10 constant TZC_OPENSTAT                   \ [0x10] Gate keeper status for filter
  [then]


  [ifdef] TZC_TZC_SPECULATION_CTRL_DEF
    \
    \ @brief TZC speculation control register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant TZC_READSPEC_DISABLE           \ [0x00] Read access speculation disable
    $01 constant TZC_WRITESPEC_DISABLE          \ [0x01] Write access speculation disable
  [then]


  [ifdef] TZC_TZC_INT_STATUS_DEF
    \
    \ @brief TZC interrupt status register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant TZC_STATUS                     \ [0x00] Interrupt status for the filter.
    $08 constant TZC_OVERRUN                    \ [0x08] Permission failure overrun Two or more regions permission failures for the filter.
    $10 constant TZC_OVERLAP                    \ [0x10 : 2] Overlap violation for each filter Bit 17 is for filter 1, bit 16 is for filter 0.
  [then]


  [ifdef] TZC_TZC_INT_CLEAR_DEF
    \
    \ @brief TZC interrupt clear register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant TZC_CLEAR                      \ [0x00] Filter interrupt clear Write “1” to clear interrupt for each filter.
  [then]


  [ifdef] TZC_TZC_FAIL_ADDRESS_LOW_DEF
    \
    \ @brief TZC fail address low register x
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant TZC_ADDR_STATUS_LOW            \ [0x00 : 32] Fail address low bits Low 32 address bits of the first failed access permission check in the filter.
  [then]


  [ifdef] TZC_TZC_FAIL_CONTROL_DEF
    \
    \ @brief TZC fail control register x
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $14 constant TZC_PRIVILEGE                  \ [0x14] Privilege access failure
    $15 constant TZC_NON_SECURE                 \ [0x15] Non-secure access failure
    $18 constant TZC_DIRECTION                  \ [0x18] Access failure direction
  [then]


  [ifdef] TZC_TZC_FAIL_ID_DEF
    \
    \ @brief TZC fail ID register x
    \ Address offset: 0x2C
    \ Reset value: 0x00000000
    \
    $00 constant TZC_ID                         \ [0x00 : 11] AXI fail ID Return the AXI ID of the first fail.
  [then]


  [ifdef] TZC_TZC_REGION_BASE_LOW0_DEF
    \
    \ @brief TZC region 0 base address low register
    \ Address offset: 0x100
    \ Reset value: 0x00000000
    \
    $0c constant TZC_BASE_ADDRESS_LOW           \ [0x0c : 20] base address bits[31:12] for region 0 Others: Reserved
  [then]


  [ifdef] TZC_TZC_REGION_TOP_LOW0_DEF
    \
    \ @brief TZC region 0 top address low register
    \ Address offset: 0x108
    \ Reset value: 0xFFFFFFFF
    \
    $0c constant TZC_TOP_ADDRESS_LOW            \ [0x0c : 20] Top address bits [31:12] of region 0 Others: Reserved
  [then]


  [ifdef] TZC_TZC_REGION_ATTRIBUTE0_DEF
    \
    \ @brief TZC region 0 attribute register
    \ Address offset: 0x110
    \ Reset value: 0x00000003
    \
    $00 constant TZC_FILTER_EN                  \ [0x00] Region enable for the filter
    $1e constant TZC_S_RD_EN                    \ [0x1e] Secure global read enable
    $1f constant TZC_S_WR_EN                    \ [0x1f] Secure global write enable
  [then]


  [ifdef] TZC_TZC_REGION_ID_ACCESS0_DEF
    \
    \ @brief TZC region 0 ID access register
    \ Address offset: 0x114
    \ Reset value: 0x00000000
    \
    $00 constant TZC_NSAID_RD_EN                \ [0x00 : 16] Region read enable for each NSAID Bit 0 is associated to NSAID = 0 ... bit 15 is associated to NSAID = 15.
    $10 constant TZC_NSAID_WR_EN                \ [0x10 : 16] Region write enable for each NSAID Bit 16 is associated to NSAID = 0 .. bit 31 is associated to NSAID = 15
  [then]


  [ifdef] TZC_TZC_REGION_BASE_LOW1_DEF
    \
    \ @brief TZC region 1 base address low register
    \ Address offset: 0x120
    \ Reset value: 0x00000000
    \
    $0c constant TZC_BASE_ADDRESS_LOW           \ [0x0c : 20] Base address bits[31:12] for region x
  [then]


  [ifdef] TZC_TZC_REGION_TOP_LOW1_DEF
    \
    \ @brief TZC regions 1 top address low register
    \ Address offset: 0x128
    \ Reset value: 0x00000FFF
    \
    $0c constant TZC_TOP_ADDRESS_LOW            \ [0x0c : 20] Top address bits [31:12] of region x
  [then]


  [ifdef] TZC_TZC_REGION_ATTRIBUTE1_DEF
    \
    \ @brief TZC region 1 attribute register
    \ Address offset: 0x130
    \ Reset value: 0x00000000
    \
    $00 constant TZC_FILTER_EN                  \ [0x00] Region enable for the filter
    $1e constant TZC_S_RD_EN                    \ [0x1e] Secure global read enable
    $1f constant TZC_S_WR_EN                    \ [0x1f] Secure global write enable
  [then]


  [ifdef] TZC_TZC_REGION_ID_ACCESS1_DEF
    \
    \ @brief TZC region 1 ID access register
    \ Address offset: 0x134
    \ Reset value: 0x00000000
    \
    $00 constant TZC_NSAID_RD_EN                \ [0x00 : 16] Region read enable for each NSAID Bit 0 is associated to NSAID = 0 ... bit 15 is associated to NSAID = 15.
    $10 constant TZC_NSAID_WR_EN                \ [0x10 : 16] Region write enable for each NSAID Bit 16 is associated to NSAID = 0 .. bit 31 is associated to NSAID = 15
  [then]


  [ifdef] TZC_TZC_REGION_BASE_LOW2_DEF
    \
    \ @brief TZC region 2 base address low register
    \ Address offset: 0x140
    \ Reset value: 0x00000000
    \
    $0c constant TZC_BASE_ADDRESS_LOW           \ [0x0c : 20] Base address bits[31:12] for region x
  [then]


  [ifdef] TZC_TZC_REGION_TOP_LOW2_DEF
    \
    \ @brief TZC regions 2 top address low register
    \ Address offset: 0x148
    \ Reset value: 0x00000FFF
    \
    $0c constant TZC_TOP_ADDRESS_LOW            \ [0x0c : 20] Top address bits [31:12] of region x
  [then]


  [ifdef] TZC_TZC_REGION_ATTRIBUTE2_DEF
    \
    \ @brief TZC region 2 attribute register
    \ Address offset: 0x150
    \ Reset value: 0x00000000
    \
    $00 constant TZC_FILTER_EN                  \ [0x00] Region enable for the filter
    $1e constant TZC_S_RD_EN                    \ [0x1e] Secure global read enable
    $1f constant TZC_S_WR_EN                    \ [0x1f] Secure global write enable
  [then]


  [ifdef] TZC_TZC_REGION_ID_ACCESS2_DEF
    \
    \ @brief TZC region 2 ID access register
    \ Address offset: 0x154
    \ Reset value: 0x00000000
    \
    $00 constant TZC_NSAID_RD_EN                \ [0x00 : 16] Region read enable for each NSAID Bit 0 is associated to NSAID = 0 ... bit 15 is associated to NSAID = 15.
    $10 constant TZC_NSAID_WR_EN                \ [0x10 : 16] Region write enable for each NSAID Bit 16 is associated to NSAID = 0 .. bit 31 is associated to NSAID = 15
  [then]


  [ifdef] TZC_TZC_REGION_BASE_LOW3_DEF
    \
    \ @brief TZC region 3 base address low register
    \ Address offset: 0x160
    \ Reset value: 0x00000000
    \
    $0c constant TZC_BASE_ADDRESS_LOW           \ [0x0c : 20] Base address bits[31:12] for region x
  [then]


  [ifdef] TZC_TZC_REGION_TOP_LOW3_DEF
    \
    \ @brief TZC regions 3 top address low register
    \ Address offset: 0x168
    \ Reset value: 0x00000FFF
    \
    $0c constant TZC_TOP_ADDRESS_LOW            \ [0x0c : 20] Top address bits [31:12] of region x
  [then]


  [ifdef] TZC_TZC_REGION_ATTRIBUTE3_DEF
    \
    \ @brief TZC region 3 attribute register
    \ Address offset: 0x170
    \ Reset value: 0x00000000
    \
    $00 constant TZC_FILTER_EN                  \ [0x00] Region enable for the filter
    $1e constant TZC_S_RD_EN                    \ [0x1e] Secure global read enable
    $1f constant TZC_S_WR_EN                    \ [0x1f] Secure global write enable
  [then]


  [ifdef] TZC_TZC_REGION_ID_ACCESS3_DEF
    \
    \ @brief TZC region 3 ID access register
    \ Address offset: 0x174
    \ Reset value: 0x00000000
    \
    $00 constant TZC_NSAID_RD_EN                \ [0x00 : 16] Region read enable for each NSAID Bit 0 is associated to NSAID = 0 ... bit 15 is associated to NSAID = 15.
    $10 constant TZC_NSAID_WR_EN                \ [0x10 : 16] Region write enable for each NSAID Bit 16 is associated to NSAID = 0 .. bit 31 is associated to NSAID = 15
  [then]


  [ifdef] TZC_TZC_REGION_BASE_LOW4_DEF
    \
    \ @brief TZC region 4 base address low register
    \ Address offset: 0x180
    \ Reset value: 0x00000000
    \
    $0c constant TZC_BASE_ADDRESS_LOW           \ [0x0c : 20] Base address bits[31:12] for region x
  [then]


  [ifdef] TZC_TZC_REGION_TOP_LOW4_DEF
    \
    \ @brief TZC regions 4 top address low register
    \ Address offset: 0x188
    \ Reset value: 0x00000FFF
    \
    $0c constant TZC_TOP_ADDRESS_LOW            \ [0x0c : 20] Top address bits [31:12] of region x
  [then]


  [ifdef] TZC_TZC_REGION_ATTRIBUTE4_DEF
    \
    \ @brief TZC region 4 attribute register
    \ Address offset: 0x190
    \ Reset value: 0x00000000
    \
    $00 constant TZC_FILTER_EN                  \ [0x00] Region enable for the filter
    $1e constant TZC_S_RD_EN                    \ [0x1e] Secure global read enable
    $1f constant TZC_S_WR_EN                    \ [0x1f] Secure global write enable
  [then]


  [ifdef] TZC_TZC_REGION_ID_ACCESS4_DEF
    \
    \ @brief TZC region 4 ID access register
    \ Address offset: 0x194
    \ Reset value: 0x00000000
    \
    $00 constant TZC_NSAID_RD_EN                \ [0x00 : 16] Region read enable for each NSAID Bit 0 is associated to NSAID = 0 ... bit 15 is associated to NSAID = 15.
    $10 constant TZC_NSAID_WR_EN                \ [0x10 : 16] Region write enable for each NSAID Bit 16 is associated to NSAID = 0 .. bit 31 is associated to NSAID = 15
  [then]


  [ifdef] TZC_TZC_REGION_BASE_LOW5_DEF
    \
    \ @brief TZC region 5 base address low register
    \ Address offset: 0x1A0
    \ Reset value: 0x00000000
    \
    $0c constant TZC_BASE_ADDRESS_LOW           \ [0x0c : 20] Base address bits[31:12] for region x
  [then]


  [ifdef] TZC_TZC_REGION_TOP_LOW5_DEF
    \
    \ @brief TZC regions 5 top address low register
    \ Address offset: 0x1A8
    \ Reset value: 0x00000FFF
    \
    $0c constant TZC_TOP_ADDRESS_LOW            \ [0x0c : 20] Top address bits [31:12] of region x
  [then]


  [ifdef] TZC_TZC_REGION_ATTRIBUTE5_DEF
    \
    \ @brief TZC region 5 attribute register
    \ Address offset: 0x1B0
    \ Reset value: 0x00000000
    \
    $00 constant TZC_FILTER_EN                  \ [0x00] Region enable for the filter
    $1e constant TZC_S_RD_EN                    \ [0x1e] Secure global read enable
    $1f constant TZC_S_WR_EN                    \ [0x1f] Secure global write enable
  [then]


  [ifdef] TZC_TZC_REGION_ID_ACCESS5_DEF
    \
    \ @brief TZC region 5 ID access register
    \ Address offset: 0x1B4
    \ Reset value: 0x00000000
    \
    $00 constant TZC_NSAID_RD_EN                \ [0x00 : 16] Region read enable for each NSAID Bit 0 is associated to NSAID = 0 ... bit 15 is associated to NSAID = 15.
    $10 constant TZC_NSAID_WR_EN                \ [0x10 : 16] Region write enable for each NSAID Bit 16 is associated to NSAID = 0 .. bit 31 is associated to NSAID = 15
  [then]


  [ifdef] TZC_TZC_REGION_BASE_LOW6_DEF
    \
    \ @brief TZC region 6 base address low register
    \ Address offset: 0x1C0
    \ Reset value: 0x00000000
    \
    $0c constant TZC_BASE_ADDRESS_LOW           \ [0x0c : 20] Base address bits[31:12] for region x
  [then]


  [ifdef] TZC_TZC_REGION_TOP_LOW6_DEF
    \
    \ @brief TZC regions 6 top address low register
    \ Address offset: 0x1C8
    \ Reset value: 0x00000FFF
    \
    $0c constant TZC_TOP_ADDRESS_LOW            \ [0x0c : 20] Top address bits [31:12] of region x
  [then]


  [ifdef] TZC_TZC_REGION_ATTRIBUTE6_DEF
    \
    \ @brief TZC region 6 attribute register
    \ Address offset: 0x1D0
    \ Reset value: 0x00000000
    \
    $00 constant TZC_FILTER_EN                  \ [0x00] Region enable for the filter
    $1e constant TZC_S_RD_EN                    \ [0x1e] Secure global read enable
    $1f constant TZC_S_WR_EN                    \ [0x1f] Secure global write enable
  [then]


  [ifdef] TZC_TZC_REGION_ID_ACCESS6_DEF
    \
    \ @brief TZC region 6 ID access register
    \ Address offset: 0x1D4
    \ Reset value: 0x00000000
    \
    $00 constant TZC_NSAID_RD_EN                \ [0x00 : 16] Region read enable for each NSAID Bit 0 is associated to NSAID = 0 ... bit 15 is associated to NSAID = 15.
    $10 constant TZC_NSAID_WR_EN                \ [0x10 : 16] Region write enable for each NSAID Bit 16 is associated to NSAID = 0 .. bit 31 is associated to NSAID = 15
  [then]


  [ifdef] TZC_TZC_REGION_BASE_LOW7_DEF
    \
    \ @brief TZC region 7 base address low register
    \ Address offset: 0x1E0
    \ Reset value: 0x00000000
    \
    $0c constant TZC_BASE_ADDRESS_LOW           \ [0x0c : 20] Base address bits[31:12] for region x
  [then]


  [ifdef] TZC_TZC_REGION_TOP_LOW7_DEF
    \
    \ @brief TZC regions 7 top address low register
    \ Address offset: 0x1E8
    \ Reset value: 0x00000FFF
    \
    $0c constant TZC_TOP_ADDRESS_LOW            \ [0x0c : 20] Top address bits [31:12] of region x
  [then]


  [ifdef] TZC_TZC_REGION_ATTRIBUTE7_DEF
    \
    \ @brief TZC region 7 attribute register
    \ Address offset: 0x1F0
    \ Reset value: 0x00000000
    \
    $00 constant TZC_FILTER_EN                  \ [0x00] Region enable for the filter
    $1e constant TZC_S_RD_EN                    \ [0x1e] Secure global read enable
    $1f constant TZC_S_WR_EN                    \ [0x1f] Secure global write enable
  [then]


  [ifdef] TZC_TZC_REGION_ID_ACCESS7_DEF
    \
    \ @brief TZC region 7 ID access register
    \ Address offset: 0x1F4
    \ Reset value: 0x00000000
    \
    $00 constant TZC_NSAID_RD_EN                \ [0x00 : 16] Region read enable for each NSAID Bit 0 is associated to NSAID = 0 ... bit 15 is associated to NSAID = 15.
    $10 constant TZC_NSAID_WR_EN                \ [0x10 : 16] Region write enable for each NSAID Bit 16 is associated to NSAID = 0 .. bit 31 is associated to NSAID = 15
  [then]


  [ifdef] TZC_TZC_REGION_BASE_LOW8_DEF
    \
    \ @brief TZC region 8 base address low register
    \ Address offset: 0x200
    \ Reset value: 0x00000000
    \
    $0c constant TZC_BASE_ADDRESS_LOW           \ [0x0c : 20] Base address bits[31:12] for region x
  [then]


  [ifdef] TZC_TZC_REGION_TOP_LOW8_DEF
    \
    \ @brief TZC regions 8 top address low register
    \ Address offset: 0x208
    \ Reset value: 0x00000FFF
    \
    $0c constant TZC_TOP_ADDRESS_LOW            \ [0x0c : 20] Top address bits [31:12] of region x
  [then]


  [ifdef] TZC_TZC_REGION_ATTRIBUTE8_DEF
    \
    \ @brief TZC region 8 attribute register
    \ Address offset: 0x210
    \ Reset value: 0x00000000
    \
    $00 constant TZC_FILTER_EN                  \ [0x00] Region enable for the filter
    $1e constant TZC_S_RD_EN                    \ [0x1e] Secure global read enable
    $1f constant TZC_S_WR_EN                    \ [0x1f] Secure global write enable
  [then]


  [ifdef] TZC_TZC_REGION_ID_ACCESS8_DEF
    \
    \ @brief TZC region 8 ID access register
    \ Address offset: 0x214
    \ Reset value: 0x00000000
    \
    $00 constant TZC_NSAID_RD_EN                \ [0x00 : 16] Region read enable for each NSAID Bit 0 is associated to NSAID = 0 ... bit 15 is associated to NSAID = 15.
    $10 constant TZC_NSAID_WR_EN                \ [0x10 : 16] Region write enable for each NSAID Bit 16 is associated to NSAID = 0 .. bit 31 is associated to NSAID = 15
  [then]


  [ifdef] TZC_TZC_PID4_DEF
    \
    \ @brief TZC peripheral ID 4 register
    \ Address offset: 0xFD0
    \ Reset value: 0x00000004
    \
    $00 constant TZC_PER_ID_4                   \ [0x00 : 8] Peripheral ID 4
  [then]


  [ifdef] TZC_TZC_PID5_DEF
    \
    \ @brief TZC peripheral ID 5 register
    \ Address offset: 0xFD4
    \ Reset value: 0x00000000
    \
    $00 constant TZC_PER_ID_5                   \ [0x00 : 8] Peripheral ID 5
  [then]


  [ifdef] TZC_TZC_PID6_DEF
    \
    \ @brief TZC peripheral ID 6 register
    \ Address offset: 0xFD8
    \ Reset value: 0x00000000
    \
    $00 constant TZC_PER_ID_6                   \ [0x00 : 8] Peripheral ID 6
  [then]


  [ifdef] TZC_TZC_PID7_DEF
    \
    \ @brief TZC peripheral ID 7 register
    \ Address offset: 0xFDC
    \ Reset value: 0x00000000
    \
    $00 constant TZC_PER_ID_7                   \ [0x00 : 8] Peripheral ID 7
  [then]


  [ifdef] TZC_TZC_PID0_DEF
    \
    \ @brief TZC peripheral ID 0 register
    \ Address offset: 0xFE0
    \ Reset value: 0x00000060
    \
    $00 constant TZC_PER_ID_0                   \ [0x00 : 8] Peripheral ID 0
  [then]


  [ifdef] TZC_TZC_PID1_DEF
    \
    \ @brief TZC peripheral ID 1 register
    \ Address offset: 0xFE4
    \ Reset value: 0x000000B4
    \
    $00 constant TZC_PER_ID_1                   \ [0x00 : 8] Peripheral ID 1
  [then]


  [ifdef] TZC_TZC_PID2_DEF
    \
    \ @brief TZC peripheral ID 2 register
    \ Address offset: 0xFE8
    \ Reset value: 0x0000002B
    \
    $00 constant TZC_PER_ID_2                   \ [0x00 : 8] Peripheral ID 2
  [then]


  [ifdef] TZC_TZC_PID3_DEF
    \
    \ @brief TZC peripheral ID 3 register
    \ Address offset: 0xFEC
    \ Reset value: 0x00000000
    \
    $00 constant TZC_PER_ID_3                   \ [0x00 : 8] Peripheral ID 3
  [then]


  [ifdef] TZC_TZC_CID0_DEF
    \
    \ @brief TZC component ID 0 register
    \ Address offset: 0xFF0
    \ Reset value: 0x0000000D
    \
    $00 constant TZC_COMP_ID_0                  \ [0x00 : 8] Component ID 0
  [then]


  [ifdef] TZC_TZC_CID1_DEF
    \
    \ @brief TZC component ID 1 register
    \ Address offset: 0xFF4
    \ Reset value: 0x000000F0
    \
    $00 constant TZC_COMP_ID_1                  \ [0x00 : 8] Component ID 0
  [then]


  [ifdef] TZC_TZC_CID2_DEF
    \
    \ @brief TZC component ID 2 register
    \ Address offset: 0xFF8
    \ Reset value: 0x00000005
    \
    $00 constant TZC_COMP_ID_2                  \ [0x00 : 8] Component ID 2
  [then]


  [ifdef] TZC_TZC_CID3_DEF
    \
    \ @brief TZC component ID 3 register
    \ Address offset: 0xFFC
    \ Reset value: 0x000000B1
    \
    $00 constant TZC_COMP_ID_3                  \ [0x00 : 8] Component ID 3
  [then]

  \
  \ @brief TZC
  \
  $00 constant TZC_TZC_BUILD_CONFIG     \ TZC configuration register
  $04 constant TZC_TZC_ACTION           \ TZC action register
  $08 constant TZC_TZC_GATE_KEEPER      \ TZC gate keeper register
  $0C constant TZC_TZC_SPECULATION_CTRL \ TZC speculation control register
  $10 constant TZC_TZC_INT_STATUS       \ TZC interrupt status register
  $14 constant TZC_TZC_INT_CLEAR        \ TZC interrupt clear register
  $20 constant TZC_TZC_FAIL_ADDRESS_LOW \ TZC fail address low register x
  $28 constant TZC_TZC_FAIL_CONTROL     \ TZC fail control register x
  $2C constant TZC_TZC_FAIL_ID          \ TZC fail ID register x
  $100 constant TZC_TZC_REGION_BASE_LOW0    \ TZC region 0 base address low register
  $108 constant TZC_TZC_REGION_TOP_LOW0 \ TZC region 0 top address low register
  $110 constant TZC_TZC_REGION_ATTRIBUTE0    \ TZC region 0 attribute register
  $114 constant TZC_TZC_REGION_ID_ACCESS0    \ TZC region 0 ID access register
  $120 constant TZC_TZC_REGION_BASE_LOW1    \ TZC region 1 base address low register
  $128 constant TZC_TZC_REGION_TOP_LOW1 \ TZC regions 1 top address low register
  $130 constant TZC_TZC_REGION_ATTRIBUTE1    \ TZC region 1 attribute register
  $134 constant TZC_TZC_REGION_ID_ACCESS1    \ TZC region 1 ID access register
  $140 constant TZC_TZC_REGION_BASE_LOW2    \ TZC region 2 base address low register
  $148 constant TZC_TZC_REGION_TOP_LOW2 \ TZC regions 2 top address low register
  $150 constant TZC_TZC_REGION_ATTRIBUTE2    \ TZC region 2 attribute register
  $154 constant TZC_TZC_REGION_ID_ACCESS2    \ TZC region 2 ID access register
  $160 constant TZC_TZC_REGION_BASE_LOW3    \ TZC region 3 base address low register
  $168 constant TZC_TZC_REGION_TOP_LOW3 \ TZC regions 3 top address low register
  $170 constant TZC_TZC_REGION_ATTRIBUTE3    \ TZC region 3 attribute register
  $174 constant TZC_TZC_REGION_ID_ACCESS3    \ TZC region 3 ID access register
  $180 constant TZC_TZC_REGION_BASE_LOW4    \ TZC region 4 base address low register
  $188 constant TZC_TZC_REGION_TOP_LOW4 \ TZC regions 4 top address low register
  $190 constant TZC_TZC_REGION_ATTRIBUTE4    \ TZC region 4 attribute register
  $194 constant TZC_TZC_REGION_ID_ACCESS4    \ TZC region 4 ID access register
  $1A0 constant TZC_TZC_REGION_BASE_LOW5    \ TZC region 5 base address low register
  $1A8 constant TZC_TZC_REGION_TOP_LOW5 \ TZC regions 5 top address low register
  $1B0 constant TZC_TZC_REGION_ATTRIBUTE5    \ TZC region 5 attribute register
  $1B4 constant TZC_TZC_REGION_ID_ACCESS5    \ TZC region 5 ID access register
  $1C0 constant TZC_TZC_REGION_BASE_LOW6    \ TZC region 6 base address low register
  $1C8 constant TZC_TZC_REGION_TOP_LOW6 \ TZC regions 6 top address low register
  $1D0 constant TZC_TZC_REGION_ATTRIBUTE6    \ TZC region 6 attribute register
  $1D4 constant TZC_TZC_REGION_ID_ACCESS6    \ TZC region 6 ID access register
  $1E0 constant TZC_TZC_REGION_BASE_LOW7    \ TZC region 7 base address low register
  $1E8 constant TZC_TZC_REGION_TOP_LOW7 \ TZC regions 7 top address low register
  $1F0 constant TZC_TZC_REGION_ATTRIBUTE7    \ TZC region 7 attribute register
  $1F4 constant TZC_TZC_REGION_ID_ACCESS7    \ TZC region 7 ID access register
  $200 constant TZC_TZC_REGION_BASE_LOW8    \ TZC region 8 base address low register
  $208 constant TZC_TZC_REGION_TOP_LOW8 \ TZC regions 8 top address low register
  $210 constant TZC_TZC_REGION_ATTRIBUTE8    \ TZC region 8 attribute register
  $214 constant TZC_TZC_REGION_ID_ACCESS8    \ TZC region 8 ID access register
  $FD0 constant TZC_TZC_PID4            \ TZC peripheral ID 4 register
  $FD4 constant TZC_TZC_PID5            \ TZC peripheral ID 5 register
  $FD8 constant TZC_TZC_PID6            \ TZC peripheral ID 6 register
  $FDC constant TZC_TZC_PID7            \ TZC peripheral ID 7 register
  $FE0 constant TZC_TZC_PID0            \ TZC peripheral ID 0 register
  $FE4 constant TZC_TZC_PID1            \ TZC peripheral ID 1 register
  $FE8 constant TZC_TZC_PID2            \ TZC peripheral ID 2 register
  $FEC constant TZC_TZC_PID3            \ TZC peripheral ID 3 register
  $FF0 constant TZC_TZC_CID0            \ TZC component ID 0 register
  $FF4 constant TZC_TZC_CID1            \ TZC component ID 1 register
  $FF8 constant TZC_TZC_CID2            \ TZC component ID 2 register
  $FFC constant TZC_TZC_CID3            \ TZC component ID 3 register

: TZC_DEF ; [then]
