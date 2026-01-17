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
    $01 constant SYSCFG_CLASSBSEC               \ [0x01] ClassB security
    $02 constant SYSCFG_SRAM2SEC                \ [0x02] SRAM2 security
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
    $10 constant SYSCFG_I2C_PB6_FMP             \ [0x10] Fast-mode Plus (Fm+) driving capability activation on PB6
    $11 constant SYSCFG_I2C_PB7_FMP             \ [0x11] Fast-mode Plus (Fm+) driving capability activation on PB7
    $12 constant SYSCFG_I2C_PB8_FMP             \ [0x12] Fast-mode Plus (Fm+) driving capability activation on PB8
    $13 constant SYSCFG_I2C_PB9_FMP             \ [0x13] Fast-mode Plus (Fm+) driving capability activation on PB9
    $14 constant SYSCFG_I2C1_FMP                \ [0x14] I2C1 Fast-mode Plus driving capability activation
    $15 constant SYSCFG_I2C2_FMP                \ [0x15] I2C2 Fast-mode Plus driving capability activation
    $16 constant SYSCFG_I2C3_FMP                \ [0x16] I2C3 Fast-mode Plus driving capability activation
    $17 constant SYSCFG_I2C4_FMP                \ [0x17] I2C4_FMP
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
    \ @brief CFGR2
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_CLL                     \ [0x00] LOCKUP (hardfault) output enable bit
    $01 constant SYSCFG_SPL                     \ [0x01] SRAM2 parity lock bit
    $02 constant SYSCFG_PVDL                    \ [0x02] PVD lock enable bit
    $03 constant SYSCFG_ECCL                    \ [0x03] ECC Lock
    $08 constant SYSCFG_SPF                     \ [0x08] SRAM2 parity error flag
  [then]


  [ifdef] SYSCFG_SCSR_DEF
    \
    \ @brief SCSR
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_SRAM2ER                 \ [0x00] SRAM2 Erase
    $01 constant SYSCFG_SRAM2BSY                \ [0x01] SRAM2 busy by erase operation
  [then]


  [ifdef] SYSCFG_SKR_DEF
    \
    \ @brief SKR
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_KEY                     \ [0x00 : 8] SRAM2 write protection key for software erase
  [then]


  [ifdef] SYSCFG_SWPR_DEF
    \
    \ @brief SWPR
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_P0WP                    \ [0x00] P0WP
    $01 constant SYSCFG_P1WP                    \ [0x01] P1WP
    $02 constant SYSCFG_P2WP                    \ [0x02] P2WP
    $03 constant SYSCFG_P3WP                    \ [0x03] P3WP
    $04 constant SYSCFG_P4WP                    \ [0x04] P4WP
    $05 constant SYSCFG_P5WP                    \ [0x05] P5WP
    $06 constant SYSCFG_P6WP                    \ [0x06] P6WP
    $07 constant SYSCFG_P7WP                    \ [0x07] P7WP
    $08 constant SYSCFG_P8WP                    \ [0x08] P8WP
    $09 constant SYSCFG_P9WP                    \ [0x09] P9WP
    $0a constant SYSCFG_P10WP                   \ [0x0a] P10WP
    $0b constant SYSCFG_P11WP                   \ [0x0b] P11WP
    $0c constant SYSCFG_P12WP                   \ [0x0c] P12WP
    $0d constant SYSCFG_P13WP                   \ [0x0d] P13WP
    $0e constant SYSCFG_P14WP                   \ [0x0e] P14WP
    $0f constant SYSCFG_P15WP                   \ [0x0f] P15WP
    $10 constant SYSCFG_P16WP                   \ [0x10] P16WP
    $11 constant SYSCFG_P17WP                   \ [0x11] P17WP
    $12 constant SYSCFG_P18WP                   \ [0x12] P18WP
    $13 constant SYSCFG_P19WP                   \ [0x13] P19WP
    $14 constant SYSCFG_P20WP                   \ [0x14] P20WP
    $15 constant SYSCFG_P21WP                   \ [0x15] P21WP
    $16 constant SYSCFG_P22WP                   \ [0x16] P22WP
    $17 constant SYSCFG_P23WP                   \ [0x17] P23WP
    $18 constant SYSCFG_P24WP                   \ [0x18] P24WP
    $19 constant SYSCFG_P25WP                   \ [0x19] P25WP
    $1a constant SYSCFG_P26WP                   \ [0x1a] P26WP
    $1b constant SYSCFG_P27WP                   \ [0x1b] P27WP
    $1c constant SYSCFG_P28WP                   \ [0x1c] P28WP
    $1d constant SYSCFG_P29WP                   \ [0x1d] P29WP
    $1e constant SYSCFG_P30WP                   \ [0x1e] P30WP
    $1f constant SYSCFG_P31WP                   \ [0x1f] SRAM2 page 31 write protection
  [then]


  [ifdef] SYSCFG_SWPR2_DEF
    \
    \ @brief SWPR2
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_P32WP                   \ [0x00] P32WP
    $01 constant SYSCFG_P33WP                   \ [0x01] P33WP
    $02 constant SYSCFG_P34WP                   \ [0x02] P34WP
    $03 constant SYSCFG_P35WP                   \ [0x03] P35WP
    $04 constant SYSCFG_P36WP                   \ [0x04] P36WP
    $05 constant SYSCFG_P37WP                   \ [0x05] P37WP
    $06 constant SYSCFG_P38WP                   \ [0x06] P38WP
    $07 constant SYSCFG_P39WP                   \ [0x07] P39WP
    $08 constant SYSCFG_P40WP                   \ [0x08] P40WP
    $09 constant SYSCFG_P41WP                   \ [0x09] P41WP
    $0a constant SYSCFG_P42WP                   \ [0x0a] P42WP
    $0b constant SYSCFG_P43WP                   \ [0x0b] P43WP
    $0c constant SYSCFG_P44WP                   \ [0x0c] P44WP
    $0d constant SYSCFG_P45WP                   \ [0x0d] P45WP
    $0e constant SYSCFG_P46WP                   \ [0x0e] P46WP
    $0f constant SYSCFG_P47WP                   \ [0x0f] P47WP
    $10 constant SYSCFG_P48WP                   \ [0x10] P48WP
    $11 constant SYSCFG_P49WP                   \ [0x11] P49WP
    $12 constant SYSCFG_P50WP                   \ [0x12] P50WP
    $13 constant SYSCFG_P51WP                   \ [0x13] P51WP
    $14 constant SYSCFG_P52WP                   \ [0x14] P52WP
    $15 constant SYSCFG_P53WP                   \ [0x15] P53WP
    $16 constant SYSCFG_P54WP                   \ [0x16] P54WP
    $17 constant SYSCFG_P55WP                   \ [0x17] P55WP
    $18 constant SYSCFG_P56WP                   \ [0x18] P56WP
    $19 constant SYSCFG_P57WP                   \ [0x19] P57WP
    $1a constant SYSCFG_P58WP                   \ [0x1a] P58WP
    $1b constant SYSCFG_P59WP                   \ [0x1b] P59WP
    $1c constant SYSCFG_P60WP                   \ [0x1c] P60WP
    $1d constant SYSCFG_P61WP                   \ [0x1d] P61WP
    $1e constant SYSCFG_P62WP                   \ [0x1e] P62WP
    $1f constant SYSCFG_P63WP                   \ [0x1f] P63WP
  [then]


  [ifdef] SYSCFG_RSSCMDR_DEF
    \
    \ @brief RSSCMDR
    \ Address offset: 0x2C
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_RSSCMD                  \ [0x00 : 8] RSS commands
  [then]

  \
  \ @brief System configuration controller
  \
  $00 constant SYSCFG_SECCFGR           \ SYSCFG secure configuration register
  $04 constant SYSCFG_CFGR1             \ configuration register 1
  $08 constant SYSCFG_FPUIMR            \ FPU interrupt mask register
  $0C constant SYSCFG_CNSLCKR           \ SYSCFG CPU non-secure lock register
  $10 constant SYSCFG_CSLOCKR           \ SYSCFG CPU secure lock register
  $14 constant SYSCFG_CFGR2             \ CFGR2
  $18 constant SYSCFG_SCSR              \ SCSR
  $1C constant SYSCFG_SKR               \ SKR
  $20 constant SYSCFG_SWPR              \ SWPR
  $24 constant SYSCFG_SWPR2             \ SWPR2
  $2C constant SYSCFG_RSSCMDR           \ RSSCMDR

: SYSCFG_DEF ; [then]
