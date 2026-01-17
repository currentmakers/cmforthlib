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
    \ @brief Provides information about TZC configuration.
    \ Address offset: 0x00
    \ Reset value: 0x01001F08
    \
    $00 constant TZC_NO_OF_REGIONS              \ [0x00 : 5] NO_OF_REGIONS
    $08 constant TZC_ADDRESS_WIDTH              \ [0x08 : 6] ADDRESS_WIDTH
    $18 constant TZC_NO_OF_FILTERS              \ [0x18 : 2] NO_OF_FILTERS
  [then]


  [ifdef] TZC_TZC_ACTION_DEF
    \
    \ @brief Controls interrupt and bus error response behavior when regions permission failures occur.
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant TZC_REACTION_VALUE             \ [0x00 : 2] REACTION_VALUE
  [then]


  [ifdef] TZC_TZC_GATE_KEEPER_DEF
    \
    \ @brief Provides control and status for the gate keeper in each filter unit implemented.
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant TZC_OPENREQ                    \ [0x00 : 2] OPENREQ
    $10 constant TZC_OPENSTAT                   \ [0x10 : 2] OPENSTAT
  [then]


  [ifdef] TZC_TZC_SPECULATION_CTRL_DEF
    \
    \ @brief Controls read and write access speculation.
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant TZC_READSPEC_DISABLE           \ [0x00] READSPEC_DISABLE
    $01 constant TZC_WRITESPEC_DISABLE          \ [0x01] WRITESPEC_DISABLE
  [then]


  [ifdef] TZC_TZC_INT_STATUS_DEF
    \
    \ @brief Contains the status of the interrupt signal, TZCINT, that reports access security violations or region overlap errors.
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant TZC_STATUS                     \ [0x00 : 2] STATUS
    $08 constant TZC_OVERRUN                    \ [0x08 : 2] OVERRUN
    $10 constant TZC_OVERLAP                    \ [0x10 : 2] OVERLAP
  [then]


  [ifdef] TZC_TZC_INT_CLEAR_DEF
    \
    \ @brief Interrupt clear for each filter.
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant TZC_CLEAR                      \ [0x00 : 2] CLEAR
  [then]


  [ifdef] TZC_TZC_FAIL_ADDRESS_LOW0_DEF
    \
    \ @brief Address low bits of the first failed access in the associated filter (0 to 1).
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant TZC_ADDR_STATUS_LOW            \ [0x00 : 32] ADDR_STATUS_LOW
  [then]


  [ifdef] TZC_TZC_FAIL_ADDRESS_HIGH0_DEF
    \
    \ @brief Address high bit of the first failed access in the associated filter (0 to 1). Not used with 32bit address.
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
  [then]


  [ifdef] TZC_TZC_FAIL_CONTROL0_DEF
    \
    \ @brief Status information about the first access that failed a region permission check in the associated filter (0 to 1).
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $14 constant TZC_PRIVILEGE                  \ [0x14] PRIVILEGE
    $15 constant TZC_NON_SECURE                 \ [0x15] NON_SECURE
    $18 constant TZC_DIRECTION                  \ [0x18] DIRECTION
  [then]


  [ifdef] TZC_TZC_FAIL_ID0_DEF
    \
    \ @brief Contains the master AXI ARID or AWID of the first access that failed a region permission check in the associated filter unit. This occurs even if the ACTION register is set to not drive the interrupt signal. AXI ID mapping is described in Table4: NSAID definition table (TBD).
    \ Address offset: 0x2C
    \ Reset value: 0x00000000
    \
    $00 constant TZC_ID                         \ [0x00 : 11] ID
  [then]


  [ifdef] TZC_TZC_FAIL_ADDRESS_LOW1_DEF
    \
    \ @brief Address low bits of the first failed access in the associated filter (0 to 1).
    \ Address offset: 0x30
    \ Reset value: 0x00000000
    \
    $00 constant TZC_ADDR_STATUS_LOW            \ [0x00 : 32] ADDR_STATUS_LOW
  [then]


  [ifdef] TZC_TZC_FAIL_ADDRESS_HIGH1_DEF
    \
    \ @brief Address high bit of the first failed access in the associated filter (0 to 1). Not used with 32bit address.
    \ Address offset: 0x34
    \ Reset value: 0x00000000
    \
  [then]


  [ifdef] TZC_TZC_FAIL_CONTROL1_DEF
    \
    \ @brief Status information about the first access that failed a region permission check in the associated filter (0 to 1).
    \ Address offset: 0x38
    \ Reset value: 0x00000000
    \
    $14 constant TZC_PRIVILEGE                  \ [0x14] PRIVILEGE
    $15 constant TZC_NON_SECURE                 \ [0x15] NON_SECURE
    $18 constant TZC_DIRECTION                  \ [0x18] DIRECTION
  [then]


  [ifdef] TZC_TZC_FAIL_ID1_DEF
    \
    \ @brief Contains the master AXI ARID or AWID of the first access that failed a region permission check in the associated filter unit. This occurs even if the ACTION register is set to not drive the interrupt signal. AXI ID mapping is described in Table4: NSAID definition table (TBD).
    \ Address offset: 0x3C
    \ Reset value: 0x00000000
    \
    $00 constant TZC_ID                         \ [0x00 : 11] ID
  [then]


  [ifdef] TZC_TZC_REGION_BASE_HIGH0_DEF
    \
    \ @brief Base address high are not used with 32-bit address.
    \ Address offset: 0x104
    \ Reset value: 0x00000000
    \
  [then]


  [ifdef] TZC_TZC_REGION_TOP_LOW0_DEF
    \
    \ @brief Top address bits [31:12] for region 0.
    \ Address offset: 0x108
    \ Reset value: 0xFFFFFFFF
    \
    $0c constant TZC_TOP_ADDRESS_LOW            \ [0x0c : 20] TOP_ADDRESS_LOW
  [then]


  [ifdef] TZC_TZC_REGION_TOP_HIGH0_DEF
    \
    \ @brief Top address high of region are not used with 32-bit address.
    \ Address offset: 0x10C
    \ Reset value: 0x00000000
    \
  [then]


  [ifdef] TZC_TZC_REGION_ATTRIBUTE0_DEF
    \
    \ @brief Region 0 attributes.
    \ Address offset: 0x110
    \ Reset value: 0x00000003
    \
    $00 constant TZC_FILTER_EN                  \ [0x00 : 2] FILTER_EN
    $1e constant TZC_S_RD_EN                    \ [0x1e] S_RD_EN
    $1f constant TZC_S_WR_EN                    \ [0x1f] S_WR_EN
  [then]


  [ifdef] TZC_TZC_REGION_ID_ACCESS0_DEF
    \
    \ @brief Region non-secure access based on NSAID.
    \ Address offset: 0x114
    \ Reset value: 0x00000000
    \
    $00 constant TZC_NSAID_RD_EN                \ [0x00 : 16] NSAID_RD_EN
    $10 constant TZC_NSAID_WR_EN                \ [0x10 : 16] NSAID_WR_EN
  [then]


  [ifdef] TZC_TZC_REGION_BASE_LOW1_DEF
    \
    \ @brief Base address low for regions 1 to 8.
    \ Address offset: 0x120
    \ Reset value: 0x00000000
    \
    $0c constant TZC_BASE_ADDRESS_LOW           \ [0x0c : 20] BASE_ADDRESS_LOW
  [then]


  [ifdef] TZC_TZC_REGION_BASE_HIGH1_DEF
    \
    \ @brief Base address high are not used with 32-bit address.
    \ Address offset: 0x124
    \ Reset value: 0x00000000
    \
  [then]


  [ifdef] TZC_TZC_REGION_TOP_LOW1_DEF
    \
    \ @brief Top address bits [31:12] for region x.
    \ Address offset: 0x128
    \ Reset value: 0x00000FFF
    \
    $0c constant TZC_TOP_ADDRESS_LOW            \ [0x0c : 20] TOP_ADDRESS_LOW
  [then]


  [ifdef] TZC_TZC_REGION_TOP_HIGH1_DEF
    \
    \ @brief Top address high of region are not used with 32-bit address.
    \ Address offset: 0x12C
    \ Reset value: 0x00000000
    \
  [then]


  [ifdef] TZC_TZC_REGION_ATTRIBUTE1_DEF
    \
    \ @brief Region x attributes.
    \ Address offset: 0x130
    \ Reset value: 0x00000000
    \
    $00 constant TZC_FILTER_EN                  \ [0x00 : 2] FILTER_EN
    $1e constant TZC_S_RD_EN                    \ [0x1e] S_RD_EN
    $1f constant TZC_S_WR_EN                    \ [0x1f] S_WR_EN
  [then]


  [ifdef] TZC_TZC_REGION_ID_ACCESS1_DEF
    \
    \ @brief Region non-secure access based on NSAID.
    \ Address offset: 0x134
    \ Reset value: 0x00000000
    \
    $00 constant TZC_NSAID_RD_EN                \ [0x00 : 16] NSAID_RD_EN
    $10 constant TZC_NSAID_WR_EN                \ [0x10 : 16] NSAID_WR_EN
  [then]


  [ifdef] TZC_TZC_REGION_BASE_LOW2_DEF
    \
    \ @brief Base address low for regions 1 to 8.
    \ Address offset: 0x140
    \ Reset value: 0x00000000
    \
    $0c constant TZC_BASE_ADDRESS_LOW           \ [0x0c : 20] BASE_ADDRESS_LOW
  [then]


  [ifdef] TZC_TZC_REGION_BASE_HIGH2_DEF
    \
    \ @brief Base address high are not used with 32-bit address.
    \ Address offset: 0x144
    \ Reset value: 0x00000000
    \
  [then]


  [ifdef] TZC_TZC_REGION_TOP_LOW2_DEF
    \
    \ @brief Top address bits [31:12] for region x.
    \ Address offset: 0x148
    \ Reset value: 0x00000FFF
    \
    $0c constant TZC_TOP_ADDRESS_LOW            \ [0x0c : 20] TOP_ADDRESS_LOW
  [then]


  [ifdef] TZC_TZC_REGION_TOP_HIGH2_DEF
    \
    \ @brief Top address high of region are not used with 32-bit address.
    \ Address offset: 0x14C
    \ Reset value: 0x00000000
    \
  [then]


  [ifdef] TZC_TZC_REGION_ATTRIBUTE2_DEF
    \
    \ @brief Region x attributes.
    \ Address offset: 0x150
    \ Reset value: 0x00000000
    \
    $00 constant TZC_FILTER_EN                  \ [0x00 : 2] FILTER_EN
    $1e constant TZC_S_RD_EN                    \ [0x1e] S_RD_EN
    $1f constant TZC_S_WR_EN                    \ [0x1f] S_WR_EN
  [then]


  [ifdef] TZC_TZC_REGION_ID_ACCESS2_DEF
    \
    \ @brief Region non-secure access based on NSAID.
    \ Address offset: 0x154
    \ Reset value: 0x00000000
    \
    $00 constant TZC_NSAID_RD_EN                \ [0x00 : 16] NSAID_RD_EN
    $10 constant TZC_NSAID_WR_EN                \ [0x10 : 16] NSAID_WR_EN
  [then]


  [ifdef] TZC_TZC_REGION_BASE_LOW3_DEF
    \
    \ @brief Base address low for regions 1 to 8.
    \ Address offset: 0x160
    \ Reset value: 0x00000000
    \
    $0c constant TZC_BASE_ADDRESS_LOW           \ [0x0c : 20] BASE_ADDRESS_LOW
  [then]


  [ifdef] TZC_TZC_REGION_BASE_HIGH3_DEF
    \
    \ @brief Base address high are not used with 32-bit address.
    \ Address offset: 0x164
    \ Reset value: 0x00000000
    \
  [then]


  [ifdef] TZC_TZC_REGION_TOP_LOW3_DEF
    \
    \ @brief Top address bits [31:12] for region x.
    \ Address offset: 0x168
    \ Reset value: 0x00000FFF
    \
    $0c constant TZC_TOP_ADDRESS_LOW            \ [0x0c : 20] TOP_ADDRESS_LOW
  [then]


  [ifdef] TZC_TZC_REGION_TOP_HIGH3_DEF
    \
    \ @brief Top address high of region are not used with 32-bit address.
    \ Address offset: 0x16C
    \ Reset value: 0x00000000
    \
  [then]


  [ifdef] TZC_TZC_REGION_ATTRIBUTE3_DEF
    \
    \ @brief Region x attributes.
    \ Address offset: 0x170
    \ Reset value: 0x00000000
    \
    $00 constant TZC_FILTER_EN                  \ [0x00 : 2] FILTER_EN
    $1e constant TZC_S_RD_EN                    \ [0x1e] S_RD_EN
    $1f constant TZC_S_WR_EN                    \ [0x1f] S_WR_EN
  [then]


  [ifdef] TZC_TZC_REGION_ID_ACCESS3_DEF
    \
    \ @brief Region non-secure access based on NSAID.
    \ Address offset: 0x174
    \ Reset value: 0x00000000
    \
    $00 constant TZC_NSAID_RD_EN                \ [0x00 : 16] NSAID_RD_EN
    $10 constant TZC_NSAID_WR_EN                \ [0x10 : 16] NSAID_WR_EN
  [then]


  [ifdef] TZC_TZC_REGION_BASE_LOW4_DEF
    \
    \ @brief Base address low for regions 1 to 8.
    \ Address offset: 0x180
    \ Reset value: 0x00000000
    \
    $0c constant TZC_BASE_ADDRESS_LOW           \ [0x0c : 20] BASE_ADDRESS_LOW
  [then]


  [ifdef] TZC_TZC_REGION_BASE_HIGH4_DEF
    \
    \ @brief Base address high are not used with 32-bit address.
    \ Address offset: 0x184
    \ Reset value: 0x00000000
    \
  [then]


  [ifdef] TZC_TZC_REGION_TOP_LOW4_DEF
    \
    \ @brief Top address bits [31:12] for region x.
    \ Address offset: 0x188
    \ Reset value: 0x00000FFF
    \
    $0c constant TZC_TOP_ADDRESS_LOW            \ [0x0c : 20] TOP_ADDRESS_LOW
  [then]


  [ifdef] TZC_TZC_REGION_TOP_HIGH4_DEF
    \
    \ @brief Top address high of region are not used with 32-bit address.
    \ Address offset: 0x18C
    \ Reset value: 0x00000000
    \
  [then]


  [ifdef] TZC_TZC_REGION_ATTRIBUTE4_DEF
    \
    \ @brief Region x attributes.
    \ Address offset: 0x190
    \ Reset value: 0x00000000
    \
    $00 constant TZC_FILTER_EN                  \ [0x00 : 2] FILTER_EN
    $1e constant TZC_S_RD_EN                    \ [0x1e] S_RD_EN
    $1f constant TZC_S_WR_EN                    \ [0x1f] S_WR_EN
  [then]


  [ifdef] TZC_TZC_REGION_ID_ACCESS4_DEF
    \
    \ @brief Region non-secure access based on NSAID.
    \ Address offset: 0x194
    \ Reset value: 0x00000000
    \
    $00 constant TZC_NSAID_RD_EN                \ [0x00 : 16] NSAID_RD_EN
    $10 constant TZC_NSAID_WR_EN                \ [0x10 : 16] NSAID_WR_EN
  [then]


  [ifdef] TZC_TZC_REGION_BASE_LOW5_DEF
    \
    \ @brief Base address low for regions 1 to 8.
    \ Address offset: 0x1A0
    \ Reset value: 0x00000000
    \
    $0c constant TZC_BASE_ADDRESS_LOW           \ [0x0c : 20] BASE_ADDRESS_LOW
  [then]


  [ifdef] TZC_TZC_REGION_BASE_HIGH5_DEF
    \
    \ @brief Base address high are not used with 32-bit address.
    \ Address offset: 0x1A4
    \ Reset value: 0x00000000
    \
  [then]


  [ifdef] TZC_TZC_REGION_TOP_LOW5_DEF
    \
    \ @brief Top address bits [31:12] for region x.
    \ Address offset: 0x1A8
    \ Reset value: 0x00000FFF
    \
    $0c constant TZC_TOP_ADDRESS_LOW            \ [0x0c : 20] TOP_ADDRESS_LOW
  [then]


  [ifdef] TZC_TZC_REGION_TOP_HIGH5_DEF
    \
    \ @brief Top address high of region are not used with 32-bit address.
    \ Address offset: 0x1AC
    \ Reset value: 0x00000000
    \
  [then]


  [ifdef] TZC_TZC_REGION_ATTRIBUTE5_DEF
    \
    \ @brief Region x attributes.
    \ Address offset: 0x1B0
    \ Reset value: 0x00000000
    \
    $00 constant TZC_FILTER_EN                  \ [0x00 : 2] FILTER_EN
    $1e constant TZC_S_RD_EN                    \ [0x1e] S_RD_EN
    $1f constant TZC_S_WR_EN                    \ [0x1f] S_WR_EN
  [then]


  [ifdef] TZC_TZC_REGION_ID_ACCESS5_DEF
    \
    \ @brief Region non-secure access based on NSAID.
    \ Address offset: 0x1B4
    \ Reset value: 0x00000000
    \
    $00 constant TZC_NSAID_RD_EN                \ [0x00 : 16] NSAID_RD_EN
    $10 constant TZC_NSAID_WR_EN                \ [0x10 : 16] NSAID_WR_EN
  [then]


  [ifdef] TZC_TZC_REGION_BASE_LOW6_DEF
    \
    \ @brief Base address low for regions 1 to 8.
    \ Address offset: 0x1C0
    \ Reset value: 0x00000000
    \
    $0c constant TZC_BASE_ADDRESS_LOW           \ [0x0c : 20] BASE_ADDRESS_LOW
  [then]


  [ifdef] TZC_TZC_REGION_BASE_HIGH6_DEF
    \
    \ @brief Base address high are not used with 32-bit address.
    \ Address offset: 0x1C4
    \ Reset value: 0x00000000
    \
  [then]


  [ifdef] TZC_TZC_REGION_TOP_LOW6_DEF
    \
    \ @brief Top address bits [31:12] for region x.
    \ Address offset: 0x1C8
    \ Reset value: 0x00000FFF
    \
    $0c constant TZC_TOP_ADDRESS_LOW            \ [0x0c : 20] TOP_ADDRESS_LOW
  [then]


  [ifdef] TZC_TZC_REGION_TOP_HIGH6_DEF
    \
    \ @brief Top address high of region are not used with 32-bit address.
    \ Address offset: 0x1CC
    \ Reset value: 0x00000000
    \
  [then]


  [ifdef] TZC_TZC_REGION_ATTRIBUTE6_DEF
    \
    \ @brief Region x attributes.
    \ Address offset: 0x1D0
    \ Reset value: 0x00000000
    \
    $00 constant TZC_FILTER_EN                  \ [0x00 : 2] FILTER_EN
    $1e constant TZC_S_RD_EN                    \ [0x1e] S_RD_EN
    $1f constant TZC_S_WR_EN                    \ [0x1f] S_WR_EN
  [then]


  [ifdef] TZC_TZC_REGION_ID_ACCESS6_DEF
    \
    \ @brief Region non-secure access based on NSAID.
    \ Address offset: 0x1D4
    \ Reset value: 0x00000000
    \
    $00 constant TZC_NSAID_RD_EN                \ [0x00 : 16] NSAID_RD_EN
    $10 constant TZC_NSAID_WR_EN                \ [0x10 : 16] NSAID_WR_EN
  [then]


  [ifdef] TZC_TZC_REGION_TOP_LOW7_DEF
    \
    \ @brief Top address bits [31:12] for region x.
    \ Address offset: 0x1E8
    \ Reset value: 0x00000FFF
    \
    $0c constant TZC_TOP_ADDRESS_LOW            \ [0x0c : 20] TOP_ADDRESS_LOW
  [then]


  [ifdef] TZC_TZC_REGION_ATTRIBUTE7_DEF
    \
    \ @brief Region x attributes.
    \ Address offset: 0x1F0
    \ Reset value: 0x00000000
    \
    $00 constant TZC_FILTER_EN                  \ [0x00 : 2] FILTER_EN
    $1e constant TZC_S_RD_EN                    \ [0x1e] S_RD_EN
    $1f constant TZC_S_WR_EN                    \ [0x1f] S_WR_EN
  [then]


  [ifdef] TZC_TZC_REGION_BASE_LOW8_DEF
    \
    \ @brief Base address low for regions 1 to 8.
    \ Address offset: 0x200
    \ Reset value: 0x00000000
    \
    $0c constant TZC_BASE_ADDRESS_LOW           \ [0x0c : 20] BASE_ADDRESS_LOW
  [then]


  [ifdef] TZC_TZC_REGION_BASE_HIGH8_DEF
    \
    \ @brief Base address high are not used with 32-bit address.
    \ Address offset: 0x204
    \ Reset value: 0x00000000
    \
  [then]


  [ifdef] TZC_TZC_REGION_ATTRIBUTE8_DEF
    \
    \ @brief Region x attributes.
    \ Address offset: 0x210
    \ Reset value: 0x00000000
    \
    $00 constant TZC_FILTER_EN                  \ [0x00 : 2] FILTER_EN
    $1e constant TZC_S_RD_EN                    \ [0x1e] S_RD_EN
    $1f constant TZC_S_WR_EN                    \ [0x1f] S_WR_EN
  [then]


  [ifdef] TZC_TZC_REGION_BASE_LOW7_DEF
    \
    \ @brief Base address low for regions 1 to 8.
    \ Address offset: 0x2E0
    \ Reset value: 0x00000000
    \
    $0c constant TZC_BASE_ADDRESS_LOW           \ [0x0c : 20] BASE_ADDRESS_LOW
  [then]


  [ifdef] TZC_TZC_REGION_BASE_HIGH7_DEF
    \
    \ @brief Base address high are not used with 32-bit address.
    \ Address offset: 0x2E4
    \ Reset value: 0x00000000
    \
  [then]


  [ifdef] TZC_TZC_REGION_TOP_HIGH7_DEF
    \
    \ @brief Top address high of region are not used with 32-bit address.
    \ Address offset: 0x2EC
    \ Reset value: 0x00000000
    \
  [then]


  [ifdef] TZC_TZC_REGION_ID_ACCESS7_DEF
    \
    \ @brief Region non-secure access based on NSAID.
    \ Address offset: 0x2F4
    \ Reset value: 0x00000000
    \
    $00 constant TZC_NSAID_RD_EN                \ [0x00 : 16] NSAID_RD_EN
    $10 constant TZC_NSAID_WR_EN                \ [0x10 : 16] NSAID_WR_EN
  [then]


  [ifdef] TZC_TZC_REGION_TOP_LOW8_DEF
    \
    \ @brief Top address bits [31:12] for region x.
    \ Address offset: 0x308
    \ Reset value: 0x00000FFF
    \
    $0c constant TZC_TOP_ADDRESS_LOW            \ [0x0c : 20] TOP_ADDRESS_LOW
  [then]


  [ifdef] TZC_TZC_REGION_TOP_HIGH8_DEF
    \
    \ @brief Top address high of region are not used with 32-bit address.
    \ Address offset: 0x30C
    \ Reset value: 0x00000000
    \
  [then]


  [ifdef] TZC_TZC_REGION_ID_ACCESS8_DEF
    \
    \ @brief Region non-secure access based on NSAID.
    \ Address offset: 0x314
    \ Reset value: 0x00000000
    \
    $00 constant TZC_NSAID_RD_EN                \ [0x00 : 16] NSAID_RD_EN
    $10 constant TZC_NSAID_WR_EN                \ [0x10 : 16] NSAID_WR_EN
  [then]


  [ifdef] TZC_TZC_PID4_DEF
    \
    \ @brief Peripheral ID 4.
    \ Address offset: 0xFD0
    \ Reset value: 0x00000004
    \
    $00 constant TZC_PER_ID_4                   \ [0x00 : 8] PER_ID_4
  [then]


  [ifdef] TZC_TZC_PID5_DEF
    \
    \ @brief Peripheral ID 5.
    \ Address offset: 0xFD4
    \ Reset value: 0x00000000
    \
    $00 constant TZC_PER_ID_5                   \ [0x00 : 8] PER_ID_5
  [then]


  [ifdef] TZC_TZC_PID6_DEF
    \
    \ @brief Peripheral ID 6.
    \ Address offset: 0xFD8
    \ Reset value: 0x00000000
    \
    $00 constant TZC_PER_ID_6                   \ [0x00 : 8] PER_ID_6
  [then]


  [ifdef] TZC_TZC_PID7_DEF
    \
    \ @brief Peripheral ID 7.
    \ Address offset: 0xFDC
    \ Reset value: 0x00000000
    \
    $00 constant TZC_PER_ID_7                   \ [0x00 : 8] PER_ID_7
  [then]


  [ifdef] TZC_TZC_PID0_DEF
    \
    \ @brief Peripheral ID 0.
    \ Address offset: 0xFE0
    \ Reset value: 0x00000060
    \
    $00 constant TZC_PER_ID_0                   \ [0x00 : 8] PER_ID_0
  [then]


  [ifdef] TZC_TZC_PID1_DEF
    \
    \ @brief Peripheral ID 1.
    \ Address offset: 0xFE4
    \ Reset value: 0x000000B4
    \
    $00 constant TZC_PER_ID_1                   \ [0x00 : 8] PER_ID_1
  [then]


  [ifdef] TZC_TZC_PID2_DEF
    \
    \ @brief Peripheral ID 2.
    \ Address offset: 0xFE8
    \ Reset value: 0x0000002B
    \
    $00 constant TZC_PER_ID_2                   \ [0x00 : 8] PER_ID_2
  [then]


  [ifdef] TZC_TZC_PID3_DEF
    \
    \ @brief Peripheral ID 3.
    \ Address offset: 0xFEC
    \ Reset value: 0x00000000
    \
    $00 constant TZC_PER_ID_3                   \ [0x00 : 8] PER_ID_3
  [then]


  [ifdef] TZC_TZC_CID0_DEF
    \
    \ @brief Component ID 0.
    \ Address offset: 0xFF0
    \ Reset value: 0x0000000D
    \
    $00 constant TZC_COMP_ID_0                  \ [0x00 : 8] COMP_ID_0
  [then]


  [ifdef] TZC_TZC_CID1_DEF
    \
    \ @brief Component ID 1.
    \ Address offset: 0xFF4
    \ Reset value: 0x000000F0
    \
    $00 constant TZC_COMP_ID_1                  \ [0x00 : 8] COMP_ID_1
  [then]


  [ifdef] TZC_TZC_CID2_DEF
    \
    \ @brief Component ID 2.
    \ Address offset: 0xFF8
    \ Reset value: 0x00000005
    \
    $00 constant TZC_COMP_ID_2                  \ [0x00 : 8] COMP_ID_2
  [then]


  [ifdef] TZC_TZC_CID3_DEF
    \
    \ @brief Component ID 3.
    \ Address offset: 0xFFC
    \ Reset value: 0x000000B1
    \
    $00 constant TZC_COMP_ID_3                  \ [0x00 : 8] COMP_ID_3
  [then]

  \
  \ @brief TZC
  \
  $00 constant TZC_TZC_BUILD_CONFIG     \ Provides information about TZC configuration.
  $04 constant TZC_TZC_ACTION           \ Controls interrupt and bus error response behavior when regions permission failures occur.
  $08 constant TZC_TZC_GATE_KEEPER      \ Provides control and status for the gate keeper in each filter unit implemented.
  $0C constant TZC_TZC_SPECULATION_CTRL \ Controls read and write access speculation.
  $10 constant TZC_TZC_INT_STATUS       \ Contains the status of the interrupt signal, TZCINT, that reports access security violations or region overlap errors.
  $14 constant TZC_TZC_INT_CLEAR        \ Interrupt clear for each filter.
  $20 constant TZC_TZC_FAIL_ADDRESS_LOW0    \ Address low bits of the first failed access in the associated filter (0 to 1).
  $24 constant TZC_TZC_FAIL_ADDRESS_HIGH0    \ Address high bit of the first failed access in the associated filter (0 to 1). Not used with 32bit address.
  $28 constant TZC_TZC_FAIL_CONTROL0    \ Status information about the first access that failed a region permission check in the associated filter (0 to 1).
  $2C constant TZC_TZC_FAIL_ID0         \ Contains the master AXI ARID or AWID of the first access that failed a region permission check in the associated filter unit. This occurs even if the ACTION register is set to not drive the interrupt signal. AXI ID mapping is described in Table4: NSAID definition table (TBD).
  $30 constant TZC_TZC_FAIL_ADDRESS_LOW1    \ Address low bits of the first failed access in the associated filter (0 to 1).
  $34 constant TZC_TZC_FAIL_ADDRESS_HIGH1    \ Address high bit of the first failed access in the associated filter (0 to 1). Not used with 32bit address.
  $38 constant TZC_TZC_FAIL_CONTROL1    \ Status information about the first access that failed a region permission check in the associated filter (0 to 1).
  $3C constant TZC_TZC_FAIL_ID1         \ Contains the master AXI ARID or AWID of the first access that failed a region permission check in the associated filter unit. This occurs even if the ACTION register is set to not drive the interrupt signal. AXI ID mapping is described in Table4: NSAID definition table (TBD).
  $104 constant TZC_TZC_REGION_BASE_HIGH0    \ Base address high are not used with 32-bit address.
  $108 constant TZC_TZC_REGION_TOP_LOW0 \ Top address bits [31:12] for region 0.
  $10C constant TZC_TZC_REGION_TOP_HIGH0    \ Top address high of region are not used with 32-bit address.
  $110 constant TZC_TZC_REGION_ATTRIBUTE0    \ Region 0 attributes.
  $114 constant TZC_TZC_REGION_ID_ACCESS0    \ Region non-secure access based on NSAID.
  $120 constant TZC_TZC_REGION_BASE_LOW1    \ Base address low for regions 1 to 8.
  $124 constant TZC_TZC_REGION_BASE_HIGH1    \ Base address high are not used with 32-bit address.
  $128 constant TZC_TZC_REGION_TOP_LOW1 \ Top address bits [31:12] for region x.
  $12C constant TZC_TZC_REGION_TOP_HIGH1    \ Top address high of region are not used with 32-bit address.
  $130 constant TZC_TZC_REGION_ATTRIBUTE1    \ Region x attributes.
  $134 constant TZC_TZC_REGION_ID_ACCESS1    \ Region non-secure access based on NSAID.
  $140 constant TZC_TZC_REGION_BASE_LOW2    \ Base address low for regions 1 to 8.
  $144 constant TZC_TZC_REGION_BASE_HIGH2    \ Base address high are not used with 32-bit address.
  $148 constant TZC_TZC_REGION_TOP_LOW2 \ Top address bits [31:12] for region x.
  $14C constant TZC_TZC_REGION_TOP_HIGH2    \ Top address high of region are not used with 32-bit address.
  $150 constant TZC_TZC_REGION_ATTRIBUTE2    \ Region x attributes.
  $154 constant TZC_TZC_REGION_ID_ACCESS2    \ Region non-secure access based on NSAID.
  $160 constant TZC_TZC_REGION_BASE_LOW3    \ Base address low for regions 1 to 8.
  $164 constant TZC_TZC_REGION_BASE_HIGH3    \ Base address high are not used with 32-bit address.
  $168 constant TZC_TZC_REGION_TOP_LOW3 \ Top address bits [31:12] for region x.
  $16C constant TZC_TZC_REGION_TOP_HIGH3    \ Top address high of region are not used with 32-bit address.
  $170 constant TZC_TZC_REGION_ATTRIBUTE3    \ Region x attributes.
  $174 constant TZC_TZC_REGION_ID_ACCESS3    \ Region non-secure access based on NSAID.
  $180 constant TZC_TZC_REGION_BASE_LOW4    \ Base address low for regions 1 to 8.
  $184 constant TZC_TZC_REGION_BASE_HIGH4    \ Base address high are not used with 32-bit address.
  $188 constant TZC_TZC_REGION_TOP_LOW4 \ Top address bits [31:12] for region x.
  $18C constant TZC_TZC_REGION_TOP_HIGH4    \ Top address high of region are not used with 32-bit address.
  $190 constant TZC_TZC_REGION_ATTRIBUTE4    \ Region x attributes.
  $194 constant TZC_TZC_REGION_ID_ACCESS4    \ Region non-secure access based on NSAID.
  $1A0 constant TZC_TZC_REGION_BASE_LOW5    \ Base address low for regions 1 to 8.
  $1A4 constant TZC_TZC_REGION_BASE_HIGH5    \ Base address high are not used with 32-bit address.
  $1A8 constant TZC_TZC_REGION_TOP_LOW5 \ Top address bits [31:12] for region x.
  $1AC constant TZC_TZC_REGION_TOP_HIGH5    \ Top address high of region are not used with 32-bit address.
  $1B0 constant TZC_TZC_REGION_ATTRIBUTE5    \ Region x attributes.
  $1B4 constant TZC_TZC_REGION_ID_ACCESS5    \ Region non-secure access based on NSAID.
  $1C0 constant TZC_TZC_REGION_BASE_LOW6    \ Base address low for regions 1 to 8.
  $1C4 constant TZC_TZC_REGION_BASE_HIGH6    \ Base address high are not used with 32-bit address.
  $1C8 constant TZC_TZC_REGION_TOP_LOW6 \ Top address bits [31:12] for region x.
  $1CC constant TZC_TZC_REGION_TOP_HIGH6    \ Top address high of region are not used with 32-bit address.
  $1D0 constant TZC_TZC_REGION_ATTRIBUTE6    \ Region x attributes.
  $1D4 constant TZC_TZC_REGION_ID_ACCESS6    \ Region non-secure access based on NSAID.
  $1E8 constant TZC_TZC_REGION_TOP_LOW7 \ Top address bits [31:12] for region x.
  $1F0 constant TZC_TZC_REGION_ATTRIBUTE7    \ Region x attributes.
  $200 constant TZC_TZC_REGION_BASE_LOW8    \ Base address low for regions 1 to 8.
  $204 constant TZC_TZC_REGION_BASE_HIGH8    \ Base address high are not used with 32-bit address.
  $210 constant TZC_TZC_REGION_ATTRIBUTE8    \ Region x attributes.
  $2E0 constant TZC_TZC_REGION_BASE_LOW7    \ Base address low for regions 1 to 8.
  $2E4 constant TZC_TZC_REGION_BASE_HIGH7    \ Base address high are not used with 32-bit address.
  $2EC constant TZC_TZC_REGION_TOP_HIGH7    \ Top address high of region are not used with 32-bit address.
  $2F4 constant TZC_TZC_REGION_ID_ACCESS7    \ Region non-secure access based on NSAID.
  $308 constant TZC_TZC_REGION_TOP_LOW8 \ Top address bits [31:12] for region x.
  $30C constant TZC_TZC_REGION_TOP_HIGH8    \ Top address high of region are not used with 32-bit address.
  $314 constant TZC_TZC_REGION_ID_ACCESS8    \ Region non-secure access based on NSAID.
  $FD0 constant TZC_TZC_PID4            \ Peripheral ID 4.
  $FD4 constant TZC_TZC_PID5            \ Peripheral ID 5.
  $FD8 constant TZC_TZC_PID6            \ Peripheral ID 6.
  $FDC constant TZC_TZC_PID7            \ Peripheral ID 7.
  $FE0 constant TZC_TZC_PID0            \ Peripheral ID 0.
  $FE4 constant TZC_TZC_PID1            \ Peripheral ID 1.
  $FE8 constant TZC_TZC_PID2            \ Peripheral ID 2.
  $FEC constant TZC_TZC_PID3            \ Peripheral ID 3.
  $FF0 constant TZC_TZC_CID0            \ Component ID 0.
  $FF4 constant TZC_TZC_CID1            \ Component ID 1.
  $FF8 constant TZC_TZC_CID2            \ Component ID 2.
  $FFC constant TZC_TZC_CID3            \ Component ID 3.

: TZC_DEF ; [then]
