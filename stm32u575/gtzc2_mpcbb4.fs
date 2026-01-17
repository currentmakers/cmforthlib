\
\ @file gtzc2_mpcbb4.fs
\ @brief GTZC2_MPCBB4
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] GTZC2_MPCBB4_DEF

  [ifdef] GTZC2_MPCBB4_MPCBB4_CR_DEF
    \
    \ @brief MPCBB control register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant GTZC2_MPCBB4_GLOCK             \ [0x00] lock the control register of the MPCBB until next reset
    $1e constant GTZC2_MPCBB4_INVSECSTATE       \ [0x1e] SRAMx clocks security state
    $1f constant GTZC2_MPCBB4_SRWILADIS         \ [0x1f] secure read/write illegal access disable
  [then]


  [ifdef] GTZC2_MPCBB4_MPCBB4_CFGLOCK_DEF
    \
    \ @brief GTZC2 SRAM4 MPCBB configuration lock register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant GTZC2_MPCBB4_SPLCK0            \ [0x00] Security/privilege configuration lock for super-block 0
  [then]


  [ifdef] GTZC2_MPCBB4_MPCBB4_SECCFGR0_DEF
    \
    \ @brief MPCBB security configuration for super-block 0 register
    \ Address offset: 0x100
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GTZC2_MPCBB4_SEC0              \ [0x00] SEC0
    $01 constant GTZC2_MPCBB4_SEC1              \ [0x01] SEC1
    $02 constant GTZC2_MPCBB4_SEC2              \ [0x02] SEC2
    $03 constant GTZC2_MPCBB4_SEC3              \ [0x03] SEC3
    $04 constant GTZC2_MPCBB4_SEC4              \ [0x04] SEC4
    $05 constant GTZC2_MPCBB4_SEC5              \ [0x05] SEC5
    $06 constant GTZC2_MPCBB4_SEC6              \ [0x06] SEC6
    $07 constant GTZC2_MPCBB4_SEC7              \ [0x07] SEC7
    $08 constant GTZC2_MPCBB4_SEC8              \ [0x08] SEC8
    $09 constant GTZC2_MPCBB4_SEC9              \ [0x09] SEC9
    $0a constant GTZC2_MPCBB4_SEC10             \ [0x0a] SEC10
    $0b constant GTZC2_MPCBB4_SEC11             \ [0x0b] SEC11
    $0c constant GTZC2_MPCBB4_SEC12             \ [0x0c] SEC12
    $0d constant GTZC2_MPCBB4_SEC13             \ [0x0d] SEC13
    $0e constant GTZC2_MPCBB4_SEC14             \ [0x0e] SEC14
    $0f constant GTZC2_MPCBB4_SEC15             \ [0x0f] SEC15
    $10 constant GTZC2_MPCBB4_SEC16             \ [0x10] SEC16
    $11 constant GTZC2_MPCBB4_SEC17             \ [0x11] SEC17
    $12 constant GTZC2_MPCBB4_SEC18             \ [0x12] SEC18
    $13 constant GTZC2_MPCBB4_SEC19             \ [0x13] SEC19
    $14 constant GTZC2_MPCBB4_SEC20             \ [0x14] SEC20
    $15 constant GTZC2_MPCBB4_SEC21             \ [0x15] SEC21
    $16 constant GTZC2_MPCBB4_SEC22             \ [0x16] SEC22
    $17 constant GTZC2_MPCBB4_SEC23             \ [0x17] SEC23
    $18 constant GTZC2_MPCBB4_SEC24             \ [0x18] SEC24
    $19 constant GTZC2_MPCBB4_SEC25             \ [0x19] SEC25
    $1a constant GTZC2_MPCBB4_SEC26             \ [0x1a] SEC26
    $1b constant GTZC2_MPCBB4_SEC27             \ [0x1b] SEC27
    $1c constant GTZC2_MPCBB4_SEC28             \ [0x1c] SEC28
    $1d constant GTZC2_MPCBB4_SEC29             \ [0x1d] SEC29
    $1e constant GTZC2_MPCBB4_SEC30             \ [0x1e] SEC30
    $1f constant GTZC2_MPCBB4_SEC31             \ [0x1f] SEC31
  [then]


  [ifdef] GTZC2_MPCBB4_MPCBB4_PRIVCFGR0_DEF
    \
    \ @brief MPCBB privileged configuration for super-block 0 register
    \ Address offset: 0x200
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GTZC2_MPCBB4_PRIV0             \ [0x00] PRIV0
    $01 constant GTZC2_MPCBB4_PRIV1             \ [0x01] PRIV1
    $02 constant GTZC2_MPCBB4_PRIV2             \ [0x02] PRIV2
    $03 constant GTZC2_MPCBB4_PRIV3             \ [0x03] PRIV3
    $04 constant GTZC2_MPCBB4_PRIV4             \ [0x04] PRIV4
    $05 constant GTZC2_MPCBB4_PRIV5             \ [0x05] PRIV5
    $06 constant GTZC2_MPCBB4_PRIV6             \ [0x06] PRIV6
    $07 constant GTZC2_MPCBB4_PRIV7             \ [0x07] PRIV7
    $08 constant GTZC2_MPCBB4_PRIV8             \ [0x08] PRIV8
    $09 constant GTZC2_MPCBB4_PRIV9             \ [0x09] PRIV9
    $0a constant GTZC2_MPCBB4_PRIV10            \ [0x0a] PRIV10
    $0b constant GTZC2_MPCBB4_PRIV11            \ [0x0b] PRIV11
    $0c constant GTZC2_MPCBB4_PRIV12            \ [0x0c] PRIV12
    $0d constant GTZC2_MPCBB4_PRIV13            \ [0x0d] PRIV13
    $0e constant GTZC2_MPCBB4_PRIV14            \ [0x0e] PRIV14
    $0f constant GTZC2_MPCBB4_PRIV15            \ [0x0f] PRIV15
    $10 constant GTZC2_MPCBB4_PRIV16            \ [0x10] PRIV16
    $11 constant GTZC2_MPCBB4_PRIV17            \ [0x11] PRIV17
    $12 constant GTZC2_MPCBB4_PRIV18            \ [0x12] PRIV18
    $13 constant GTZC2_MPCBB4_PRIV19            \ [0x13] PRIV19
    $14 constant GTZC2_MPCBB4_PRIV20            \ [0x14] PRIV20
    $15 constant GTZC2_MPCBB4_PRIV21            \ [0x15] PRIV21
    $16 constant GTZC2_MPCBB4_PRIV22            \ [0x16] PRIV22
    $17 constant GTZC2_MPCBB4_PRIV23            \ [0x17] PRIV23
    $18 constant GTZC2_MPCBB4_PRIV24            \ [0x18] PRIV24
    $19 constant GTZC2_MPCBB4_PRIV25            \ [0x19] PRIV25
    $1a constant GTZC2_MPCBB4_PRIV26            \ [0x1a] PRIV26
    $1b constant GTZC2_MPCBB4_PRIV27            \ [0x1b] PRIV27
    $1c constant GTZC2_MPCBB4_PRIV28            \ [0x1c] PRIV28
    $1d constant GTZC2_MPCBB4_PRIV29            \ [0x1d] PRIV29
    $1e constant GTZC2_MPCBB4_PRIV30            \ [0x1e] PRIV30
    $1f constant GTZC2_MPCBB4_PRIV31            \ [0x1f] PRIV31
  [then]

  \
  \ @brief GTZC2_MPCBB4
  \
  $00 constant GTZC2_MPCBB4_MPCBB4_CR   \ MPCBB control register
  $10 constant GTZC2_MPCBB4_MPCBB4_CFGLOCK    \ GTZC2 SRAM4 MPCBB configuration lock register
  $100 constant GTZC2_MPCBB4_MPCBB4_SECCFGR0    \ MPCBB security configuration for super-block 0 register
  $200 constant GTZC2_MPCBB4_MPCBB4_PRIVCFGR0    \ MPCBB privileged configuration for super-block 0 register

: GTZC2_MPCBB4_DEF ; [then]
