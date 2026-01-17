\
\ @file syscfg.fs
\ @brief System configuration controller
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] SYSCFG_DEF

  [ifdef] SYSCFG_SECCFGR_DEF
    \
    \ @brief SYSCFG secure configuration register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_SYSCFGSEC               \ [0x00] SYSCFG clock control security
    $01 constant SYSCFG_CLASSBSEC               \ [0x01] CLASSBSEC
    $03 constant SYSCFG_FPUSEC                  \ [0x03] FPUSEC
  [then]


  [ifdef] SYSCFG_CFGR1_DEF
    \
    \ @brief configuration register 1
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $08 constant SYSCFG_BOOSTEN                 \ [0x08] I/O analog switch voltage booster enable
    $09 constant SYSCFG_ANASWVDD                \ [0x09] GPIO analog switch control voltage selection
    $10 constant SYSCFG_PB6_FMP                 \ [0x10] PB6_FMP
    $11 constant SYSCFG_PB7_FMP                 \ [0x11] PB7_FMP
    $12 constant SYSCFG_PB8_FMP                 \ [0x12] PB8_FMP
    $13 constant SYSCFG_PB9_FMP                 \ [0x13] PB9_FMP
  [then]


  [ifdef] SYSCFG_FPUIMR_DEF
    \
    \ @brief FPU interrupt mask register
    \ Address offset: 0x08
    \ Reset value: 0x0000001F
    \
    $00 constant SYSCFG_FPU_IE                  \ [0x00 : 6] Floating point unit interrupts enable bits
  [then]


  [ifdef] SYSCFG_CNSLCKR_DEF
    \
    \ @brief SYSCFG CPU non-secure lock register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_LOCKNSVTOR              \ [0x00] VTOR_NS register lock
    $01 constant SYSCFG_LOCKNSMPU               \ [0x01] Non-secure MPU registers lock
  [then]


  [ifdef] SYSCFG_CSLOCKR_DEF
    \
    \ @brief SYSCFG CPU secure lock register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_LOCKSVTAIRCR            \ [0x00] LOCKSVTAIRCR
    $01 constant SYSCFG_LOCKSMPU                \ [0x01] LOCKSMPU
    $02 constant SYSCFG_LOCKSAU                 \ [0x02] LOCKSAU
  [then]


  [ifdef] SYSCFG_CFGR2_DEF
    \
    \ @brief configuration register 2
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_CLL                     \ [0x00] LOCKUP (hardfault) output enable bit
    $01 constant SYSCFG_SPL                     \ [0x01] SRAM ECC lock bit
    $02 constant SYSCFG_PVDL                    \ [0x02] PVD lock enable bit
    $03 constant SYSCFG_ECCL                    \ [0x03] ECC Lock
  [then]


  [ifdef] SYSCFG_MESR_DEF
    \
    \ @brief memory erase status register
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_MCLR                    \ [0x00] MCLR
    $10 constant SYSCFG_IPMEE                   \ [0x10] IPMEE
  [then]


  [ifdef] SYSCFG_CCCSR_DEF
    \
    \ @brief compensation cell control/status register
    \ Address offset: 0x1C
    \ Reset value: 0x0000000A
    \
    $00 constant SYSCFG_EN1                     \ [0x00] EN1
    $01 constant SYSCFG_CS1                     \ [0x01] CS1
    $02 constant SYSCFG_EN2                     \ [0x02] EN2
    $03 constant SYSCFG_CS2                     \ [0x03] CS2
    $08 constant SYSCFG_RDY1                    \ [0x08] RDY1
    $09 constant SYSCFG_RDY2                    \ [0x09] RDY2
  [then]


  [ifdef] SYSCFG_CCVR_DEF
    \
    \ @brief compensation cell value register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_NCV1                    \ [0x00 : 4] NCV1
    $04 constant SYSCFG_PCV1                    \ [0x04 : 4] PCV1
    $08 constant SYSCFG_NCV2                    \ [0x08 : 4] NCV2
    $0c constant SYSCFG_PCV2                    \ [0x0c : 4] PCV2
  [then]


  [ifdef] SYSCFG_CCCR_DEF
    \
    \ @brief compensation cell code register
    \ Address offset: 0x24
    \ Reset value: 0x00007878
    \
    $00 constant SYSCFG_NCC1                    \ [0x00 : 4] NCC1
    $04 constant SYSCFG_PCC1                    \ [0x04 : 4] PCC1
    $08 constant SYSCFG_NCC2                    \ [0x08 : 4] NCC2
    $0c constant SYSCFG_PCC2                    \ [0x0c : 4] PCC2
  [then]


  [ifdef] SYSCFG_RSSCMDR_DEF
    \
    \ @brief RSS command register
    \ Address offset: 0x2C
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_RSSCMD                  \ [0x00 : 16] RSS commands
  [then]


  [ifdef] SYSCFG_UCPDR_DEF
    \
    \ @brief USB Type C and Power Delivery register
    \ Address offset: 0x70
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_CC1ENRXFILTER           \ [0x00] CC1ENRXFILTER
    $01 constant SYSCFG_CC2ENRXFILTER           \ [0x01] CC2ENRXFILTER
  [then]

  \
  \ @brief System configuration controller
  \
  $00 constant SYSCFG_SECCFGR           \ SYSCFG secure configuration register
  $04 constant SYSCFG_CFGR1             \ configuration register 1
  $08 constant SYSCFG_FPUIMR            \ FPU interrupt mask register
  $0C constant SYSCFG_CNSLCKR           \ SYSCFG CPU non-secure lock register
  $10 constant SYSCFG_CSLOCKR           \ SYSCFG CPU secure lock register
  $14 constant SYSCFG_CFGR2             \ configuration register 2
  $18 constant SYSCFG_MESR              \ memory erase status register
  $1C constant SYSCFG_CCCSR             \ compensation cell control/status register
  $20 constant SYSCFG_CCVR              \ compensation cell value register
  $24 constant SYSCFG_CCCR              \ compensation cell code register
  $2C constant SYSCFG_RSSCMDR           \ RSS command register
  $70 constant SYSCFG_UCPDR             \ USB Type C and Power Delivery register

: SYSCFG_DEF ; [then]
