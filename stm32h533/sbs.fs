\
\ @file sbs.fs
\ @brief SBS address block description
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] SBS_DEF

  [ifdef] SBS_SBS_HDPLCR_DEF
    \
    \ @brief SBS temporal isolation control register
    \ Address offset: 0x10
    \ Reset value: 0x000000B4
    \
    $00 constant SBS_INCR_HDPL                  \ [0x00 : 8] increment HDPL value
  [then]


  [ifdef] SBS_SBS_HDPLSR_DEF
    \
    \ @brief SBS temporal isolation status register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant SBS_HDPL                       \ [0x00 : 8] temporal isolation level
  [then]


  [ifdef] SBS_SBS_NEXTHDPLCR_DEF
    \
    \ @brief SBS next HDPL control register
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant SBS_NEXTHDPL                   \ [0x00 : 2] index to point to a higher HDPL than the current one
  [then]


  [ifdef] SBS_SBS_DBGCR_DEF
    \
    \ @brief SBS debug control register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant SBS_AP_UNLOCK                  \ [0x00 : 8] access port unlock
    $08 constant SBS_DBG_UNLOCK                 \ [0x08 : 8] debug unlock when DBG_AUTH_HDPL is reached
    $10 constant SBS_DBG_AUTH_HDPL              \ [0x10 : 8] authenticated debug temporal isolation level
    $18 constant SBS_DBG_AUTH_SEC               \ [0x18 : 8] control debug opening secure/non-secure
  [then]


  [ifdef] SBS_SBS_DBGLOCKR_DEF
    \
    \ @brief SBS debug lock register
    \ Address offset: 0x24
    \ Reset value: 0x000000B4
    \
    $00 constant SBS_DBGCFG_LOCK                \ [0x00 : 8] debug configuration lock
  [then]


  [ifdef] SBS_SBS_RSSCMDR_DEF
    \
    \ @brief SBS RSS command register
    \ Address offset: 0x34
    \ Reset value: 0x00000000
    \
    $00 constant SBS_RSSCMD                     \ [0x00 : 16] RSS command
  [then]


  [ifdef] SBS_SBS_EPOCHSELCR_DEF
    \
    \ @brief SBS EPOCH selection control register
    \ Address offset: 0xA0
    \ Reset value: 0x00000000
    \
    $00 constant SBS_EPOCH_SEL                  \ [0x00 : 2] select EPOCH value to be sent to the SAES
  [then]


  [ifdef] SBS_SBS_SECCFGR_DEF
    \
    \ @brief SBS security mode configuration control register
    \ Address offset: 0xC0
    \ Reset value: 0x00000000
    \
    $00 constant SBS_SBSSEC                     \ [0x00] SBS clock control, memory-erase status register and compensation cell register security enable
    $01 constant SBS_CLASSBSEC                  \ [0x01] ClassB security enable
    $03 constant SBS_FPUSEC                     \ [0x03] FPU security enable
  [then]


  [ifdef] SBS_SBS_PMCR_DEF
    \
    \ @brief SBS product mode and configuration register
    \ Address offset: 0x100
    \ Reset value: 0x00000000
    \
    $10 constant SBS_PB6_FMP                    \ [0x10] Fast-mode Plus driving capability activation on PB6
    $11 constant SBS_PB7_FMP                    \ [0x11] Fast-mode Plus driving capability activation on PB7
    $12 constant SBS_PB8_FMP                    \ [0x12] Fast-mode Plus driving capability activation on PB8
    $13 constant SBS_PB9_FMP                    \ [0x13] Fast-mode Plus driving capability activation on PB9
    $15 constant SBS_ETH_SEL_PHY                \ [0x15 : 3] Ethernet PHY interface selection
  [then]


  [ifdef] SBS_SBS_FPUIMR_DEF
    \
    \ @brief SBS FPU interrupt mask register
    \ Address offset: 0x104
    \ Reset value: 0x0000001F
    \
    $00 constant SBS_FPU_IE                     \ [0x00 : 6] FPU interrupt enable
  [then]


  [ifdef] SBS_SBS_MESR_DEF
    \
    \ @brief SBS memory erase status register
    \ Address offset: 0x108
    \ Reset value: 0x00000000
    \
    $00 constant SBS_MCLR                       \ [0x00] device memories erase status
    $10 constant SBS_IPMEE                      \ [0x10] ICACHE erase status
  [then]


  [ifdef] SBS_SBS_CCCSR_DEF
    \
    \ @brief SBS compensation cell for I/Os control and status register
    \ Address offset: 0x110
    \ Reset value: 0x00000000
    \
    $00 constant SBS_EN1                        \ [0x00] enable compensation cell for VDDIO power rail
    $01 constant SBS_CS1                        \ [0x01] code selection for VDDIO power rail (reset value set to 1)
    $02 constant SBS_EN2                        \ [0x02] enable compensation cell for VDDIO2 power rail
    $03 constant SBS_CS2                        \ [0x03] code selection for VDDIO2 power rail (reset value set to 1)
    $08 constant SBS_RDY1                       \ [0x08] VDDIO compensation cell ready flag
    $09 constant SBS_RDY2                       \ [0x09] VDDIO2 compensation cell ready flag
  [then]


  [ifdef] SBS_SBS_CCVALR_DEF
    \
    \ @brief SBS compensation cell for I/Os value register
    \ Address offset: 0x114
    \ Reset value: 0x00000088
    \
    $00 constant SBS_ANSRC1                     \ [0x00 : 4] compensation value for the NMOS transistor
    $04 constant SBS_APSRC1                     \ [0x04 : 4] compensation value for the PMOS transistor
    $08 constant SBS_ANSRC2                     \ [0x08 : 4] Compensation value for the NMOS transistor
    $0c constant SBS_APSRC2                     \ [0x0c : 4] compensation value for the PMOS transistor
  [then]


  [ifdef] SBS_SBS_CCSWCR_DEF
    \
    \ @brief SBS compensation cell for I/Os software code register
    \ Address offset: 0x118
    \ Reset value: 0x00007878
    \
    $00 constant SBS_SW_ANSRC1                  \ [0x00 : 4] NMOS compensation code for VDD power rails
    $04 constant SBS_SW_APSRC1                  \ [0x04 : 4] PMOS compensation code for the VDD power rails
    $08 constant SBS_SW_ANSRC2                  \ [0x08 : 4] NMOS compensation code for VDDIO power rails
    $0c constant SBS_SW_APSRC2                  \ [0x0c : 4] PMOS compensation code for the Vless thansub>DDIOless than/sub> power rails
  [then]


  [ifdef] SBS_SBS_CFGR2_DEF
    \
    \ @brief SBS Class B register
    \ Address offset: 0x120
    \ Reset value: 0x00000000
    \
    $00 constant SBS_CLL                        \ [0x00] core lockup lock
    $01 constant SBS_SEL                        \ [0x01] SRAM ECC error lock
    $02 constant SBS_PVDL                       \ [0x02] PVD lock
    $03 constant SBS_ECCL                       \ [0x03] ECC lock
  [then]


  [ifdef] SBS_SBS_CNSLCKR_DEF
    \
    \ @brief SBS CPU non-secure lock register
    \ Address offset: 0x144
    \ Reset value: 0x00000000
    \
    $00 constant SBS_LOCKNSVTOR                 \ [0x00] VTOR_NS register lock
    $01 constant SBS_LOCKNSMPU                  \ [0x01] non-secure MPU register lock
  [then]


  [ifdef] SBS_SBS_CSLCKR_DEF
    \
    \ @brief SBS CPU secure lock register
    \ Address offset: 0x148
    \ Reset value: 0x00000000
    \
    $00 constant SBS_LOCKSVTAIRCR               \ [0x00] VTOR_S and AIRCR register lock
    $01 constant SBS_LOCKSMPU                   \ [0x01] secure MPU registers lock
    $02 constant SBS_LOCKSAU                    \ [0x02] SAU registers lock
  [then]


  [ifdef] SBS_SBS_ECCNMIR_DEF
    \
    \ @brief SBS flift ECC NMI mask register
    \ Address offset: 0x14C
    \ Reset value: 0x00000000
    \
    $00 constant SBS_ECCNMI_MASK_EN             \ [0x00] NMI behavior setup when a double ECC error occurs on flitf data part
  [then]

  \
  \ @brief SBS address block description
  \
  $10 constant SBS_SBS_HDPLCR           \ SBS temporal isolation control register
  $14 constant SBS_SBS_HDPLSR           \ SBS temporal isolation status register
  $18 constant SBS_SBS_NEXTHDPLCR       \ SBS next HDPL control register
  $20 constant SBS_SBS_DBGCR            \ SBS debug control register
  $24 constant SBS_SBS_DBGLOCKR         \ SBS debug lock register
  $34 constant SBS_SBS_RSSCMDR          \ SBS RSS command register
  $A0 constant SBS_SBS_EPOCHSELCR       \ SBS EPOCH selection control register
  $C0 constant SBS_SBS_SECCFGR          \ SBS security mode configuration control register
  $100 constant SBS_SBS_PMCR            \ SBS product mode and configuration register
  $104 constant SBS_SBS_FPUIMR          \ SBS FPU interrupt mask register
  $108 constant SBS_SBS_MESR            \ SBS memory erase status register
  $110 constant SBS_SBS_CCCSR           \ SBS compensation cell for I/Os control and status register
  $114 constant SBS_SBS_CCVALR          \ SBS compensation cell for I/Os value register
  $118 constant SBS_SBS_CCSWCR          \ SBS compensation cell for I/Os software code register
  $120 constant SBS_SBS_CFGR2           \ SBS Class B register
  $144 constant SBS_SBS_CNSLCKR         \ SBS CPU non-secure lock register
  $148 constant SBS_SBS_CSLCKR          \ SBS CPU secure lock register
  $14C constant SBS_SBS_ECCNMIR         \ SBS flift ECC NMI mask register

: SBS_DEF ; [then]
