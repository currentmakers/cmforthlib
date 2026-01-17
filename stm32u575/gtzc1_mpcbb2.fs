\
\ @file gtzc1_mpcbb2.fs
\ @brief GTZC1_MPCBB2
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] GTZC1_MPCBB2_DEF

  [ifdef] GTZC1_MPCBB2_MPCBB2_CR_DEF
    \
    \ @brief MPCBB control register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant GTZC1_MPCBB2_GLOCK             \ [0x00] lock the control register of the MPCBB until next reset
    $1e constant GTZC1_MPCBB2_INVSECSTATE       \ [0x1e] SRAMx clocks security state
    $1f constant GTZC1_MPCBB2_SRWILADIS         \ [0x1f] secure read/write illegal access disable
  [then]


  [ifdef] GTZC1_MPCBB2_MPCBB2_CFGLOCKR1_DEF
    \
    \ @brief GTZC1 SRAMz MPCBB configuration lock register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant GTZC1_MPCBB2_SPLCK0            \ [0x00] SPLCK0
    $01 constant GTZC1_MPCBB2_SPLCK1            \ [0x01] SPLCK1
    $02 constant GTZC1_MPCBB2_SPLCK2            \ [0x02] SPLCK2
    $03 constant GTZC1_MPCBB2_SPLCK3            \ [0x03] SPLCK3
    $04 constant GTZC1_MPCBB2_SPLCK4            \ [0x04] SPLCK4
    $05 constant GTZC1_MPCBB2_SPLCK5            \ [0x05] SPLCK5
    $06 constant GTZC1_MPCBB2_SPLCK6            \ [0x06] SPLCK6
    $07 constant GTZC1_MPCBB2_SPLCK7            \ [0x07] SPLCK7
    $08 constant GTZC1_MPCBB2_SPLCK8            \ [0x08] SPLCK8
    $09 constant GTZC1_MPCBB2_SPLCK9            \ [0x09] SPLCK9
    $0a constant GTZC1_MPCBB2_SPLCK10           \ [0x0a] SPLCK10
    $0b constant GTZC1_MPCBB2_SPLCK11           \ [0x0b] SPLCK11
    $0c constant GTZC1_MPCBB2_SPLCK12           \ [0x0c] SPLCK12
    $0d constant GTZC1_MPCBB2_SPLCK13           \ [0x0d] SPLCK13
    $0e constant GTZC1_MPCBB2_SPLCK14           \ [0x0e] SPLCK14
    $0f constant GTZC1_MPCBB2_SPLCK15           \ [0x0f] SPLCK15
    $10 constant GTZC1_MPCBB2_SPLCK16           \ [0x10] SPLCK16
    $11 constant GTZC1_MPCBB2_SPLCK17           \ [0x11] SPLCK17
    $12 constant GTZC1_MPCBB2_SPLCK18           \ [0x12] SPLCK18
    $13 constant GTZC1_MPCBB2_SPLCK19           \ [0x13] SPLCK19
    $14 constant GTZC1_MPCBB2_SPLCK20           \ [0x14] SPLCK20
    $15 constant GTZC1_MPCBB2_SPLCK21           \ [0x15] SPLCK21
    $16 constant GTZC1_MPCBB2_SPLCK22           \ [0x16] SPLCK22
    $17 constant GTZC1_MPCBB2_SPLCK23           \ [0x17] SPLCK23
    $18 constant GTZC1_MPCBB2_SPLCK24           \ [0x18] SPLCK24
    $19 constant GTZC1_MPCBB2_SPLCK25           \ [0x19] SPLCK25
    $1a constant GTZC1_MPCBB2_SPLCK26           \ [0x1a] SPLCK26
    $1b constant GTZC1_MPCBB2_SPLCK27           \ [0x1b] SPLCK27
    $1c constant GTZC1_MPCBB2_SPLCK28           \ [0x1c] SPLCK28
    $1d constant GTZC1_MPCBB2_SPLCK29           \ [0x1d] SPLCK29
    $1e constant GTZC1_MPCBB2_SPLCK30           \ [0x1e] SPLCK30
    $1f constant GTZC1_MPCBB2_SPLCK31           \ [0x1f] SPLCK31
  [then]


  [ifdef] GTZC1_MPCBB2_MPCBB2_SECCFGR0_DEF
    \
    \ @brief MPCBBx security configuration for super-block x register
    \ Address offset: 0x100
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GTZC1_MPCBB2_SEC0              \ [0x00] SEC0
    $01 constant GTZC1_MPCBB2_SEC1              \ [0x01] SEC1
    $02 constant GTZC1_MPCBB2_SEC2              \ [0x02] SEC2
    $03 constant GTZC1_MPCBB2_SEC3              \ [0x03] SEC3
    $04 constant GTZC1_MPCBB2_SEC4              \ [0x04] SEC4
    $05 constant GTZC1_MPCBB2_SEC5              \ [0x05] SEC5
    $06 constant GTZC1_MPCBB2_SEC6              \ [0x06] SEC6
    $07 constant GTZC1_MPCBB2_SEC7              \ [0x07] SEC7
    $08 constant GTZC1_MPCBB2_SEC8              \ [0x08] SEC8
    $09 constant GTZC1_MPCBB2_SEC9              \ [0x09] SEC9
    $0a constant GTZC1_MPCBB2_SEC10             \ [0x0a] SEC10
    $0b constant GTZC1_MPCBB2_SEC11             \ [0x0b] SEC11
    $0c constant GTZC1_MPCBB2_SEC12             \ [0x0c] SEC12
    $0d constant GTZC1_MPCBB2_SEC13             \ [0x0d] SEC13
    $0e constant GTZC1_MPCBB2_SEC14             \ [0x0e] SEC14
    $0f constant GTZC1_MPCBB2_SEC15             \ [0x0f] SEC15
    $10 constant GTZC1_MPCBB2_SEC16             \ [0x10] SEC16
    $11 constant GTZC1_MPCBB2_SEC17             \ [0x11] SEC17
    $12 constant GTZC1_MPCBB2_SEC18             \ [0x12] SEC18
    $13 constant GTZC1_MPCBB2_SEC19             \ [0x13] SEC19
    $14 constant GTZC1_MPCBB2_SEC20             \ [0x14] SEC20
    $15 constant GTZC1_MPCBB2_SEC21             \ [0x15] SEC21
    $16 constant GTZC1_MPCBB2_SEC22             \ [0x16] SEC22
    $17 constant GTZC1_MPCBB2_SEC23             \ [0x17] SEC23
    $18 constant GTZC1_MPCBB2_SEC24             \ [0x18] SEC24
    $19 constant GTZC1_MPCBB2_SEC25             \ [0x19] SEC25
    $1a constant GTZC1_MPCBB2_SEC26             \ [0x1a] SEC26
    $1b constant GTZC1_MPCBB2_SEC27             \ [0x1b] SEC27
    $1c constant GTZC1_MPCBB2_SEC28             \ [0x1c] SEC28
    $1d constant GTZC1_MPCBB2_SEC29             \ [0x1d] SEC29
    $1e constant GTZC1_MPCBB2_SEC30             \ [0x1e] SEC30
    $1f constant GTZC1_MPCBB2_SEC31             \ [0x1f] SEC31
  [then]


  [ifdef] GTZC1_MPCBB2_MPCBB2_SECCFGR1_DEF
    \
    \ @brief MPCBBx security configuration for super-block x register
    \ Address offset: 0x104
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GTZC1_MPCBB2_SEC0              \ [0x00] SEC0
    $01 constant GTZC1_MPCBB2_SEC1              \ [0x01] SEC1
    $02 constant GTZC1_MPCBB2_SEC2              \ [0x02] SEC2
    $03 constant GTZC1_MPCBB2_SEC3              \ [0x03] SEC3
    $04 constant GTZC1_MPCBB2_SEC4              \ [0x04] SEC4
    $05 constant GTZC1_MPCBB2_SEC5              \ [0x05] SEC5
    $06 constant GTZC1_MPCBB2_SEC6              \ [0x06] SEC6
    $07 constant GTZC1_MPCBB2_SEC7              \ [0x07] SEC7
    $08 constant GTZC1_MPCBB2_SEC8              \ [0x08] SEC8
    $09 constant GTZC1_MPCBB2_SEC9              \ [0x09] SEC9
    $0a constant GTZC1_MPCBB2_SEC10             \ [0x0a] SEC10
    $0b constant GTZC1_MPCBB2_SEC11             \ [0x0b] SEC11
    $0c constant GTZC1_MPCBB2_SEC12             \ [0x0c] SEC12
    $0d constant GTZC1_MPCBB2_SEC13             \ [0x0d] SEC13
    $0e constant GTZC1_MPCBB2_SEC14             \ [0x0e] SEC14
    $0f constant GTZC1_MPCBB2_SEC15             \ [0x0f] SEC15
    $10 constant GTZC1_MPCBB2_SEC16             \ [0x10] SEC16
    $11 constant GTZC1_MPCBB2_SEC17             \ [0x11] SEC17
    $12 constant GTZC1_MPCBB2_SEC18             \ [0x12] SEC18
    $13 constant GTZC1_MPCBB2_SEC19             \ [0x13] SEC19
    $14 constant GTZC1_MPCBB2_SEC20             \ [0x14] SEC20
    $15 constant GTZC1_MPCBB2_SEC21             \ [0x15] SEC21
    $16 constant GTZC1_MPCBB2_SEC22             \ [0x16] SEC22
    $17 constant GTZC1_MPCBB2_SEC23             \ [0x17] SEC23
    $18 constant GTZC1_MPCBB2_SEC24             \ [0x18] SEC24
    $19 constant GTZC1_MPCBB2_SEC25             \ [0x19] SEC25
    $1a constant GTZC1_MPCBB2_SEC26             \ [0x1a] SEC26
    $1b constant GTZC1_MPCBB2_SEC27             \ [0x1b] SEC27
    $1c constant GTZC1_MPCBB2_SEC28             \ [0x1c] SEC28
    $1d constant GTZC1_MPCBB2_SEC29             \ [0x1d] SEC29
    $1e constant GTZC1_MPCBB2_SEC30             \ [0x1e] SEC30
    $1f constant GTZC1_MPCBB2_SEC31             \ [0x1f] SEC31
  [then]


  [ifdef] GTZC1_MPCBB2_MPCBB2_SECCFGR2_DEF
    \
    \ @brief MPCBBx security configuration for super-block x register
    \ Address offset: 0x108
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GTZC1_MPCBB2_SEC0              \ [0x00] SEC0
    $01 constant GTZC1_MPCBB2_SEC1              \ [0x01] SEC1
    $02 constant GTZC1_MPCBB2_SEC2              \ [0x02] SEC2
    $03 constant GTZC1_MPCBB2_SEC3              \ [0x03] SEC3
    $04 constant GTZC1_MPCBB2_SEC4              \ [0x04] SEC4
    $05 constant GTZC1_MPCBB2_SEC5              \ [0x05] SEC5
    $06 constant GTZC1_MPCBB2_SEC6              \ [0x06] SEC6
    $07 constant GTZC1_MPCBB2_SEC7              \ [0x07] SEC7
    $08 constant GTZC1_MPCBB2_SEC8              \ [0x08] SEC8
    $09 constant GTZC1_MPCBB2_SEC9              \ [0x09] SEC9
    $0a constant GTZC1_MPCBB2_SEC10             \ [0x0a] SEC10
    $0b constant GTZC1_MPCBB2_SEC11             \ [0x0b] SEC11
    $0c constant GTZC1_MPCBB2_SEC12             \ [0x0c] SEC12
    $0d constant GTZC1_MPCBB2_SEC13             \ [0x0d] SEC13
    $0e constant GTZC1_MPCBB2_SEC14             \ [0x0e] SEC14
    $0f constant GTZC1_MPCBB2_SEC15             \ [0x0f] SEC15
    $10 constant GTZC1_MPCBB2_SEC16             \ [0x10] SEC16
    $11 constant GTZC1_MPCBB2_SEC17             \ [0x11] SEC17
    $12 constant GTZC1_MPCBB2_SEC18             \ [0x12] SEC18
    $13 constant GTZC1_MPCBB2_SEC19             \ [0x13] SEC19
    $14 constant GTZC1_MPCBB2_SEC20             \ [0x14] SEC20
    $15 constant GTZC1_MPCBB2_SEC21             \ [0x15] SEC21
    $16 constant GTZC1_MPCBB2_SEC22             \ [0x16] SEC22
    $17 constant GTZC1_MPCBB2_SEC23             \ [0x17] SEC23
    $18 constant GTZC1_MPCBB2_SEC24             \ [0x18] SEC24
    $19 constant GTZC1_MPCBB2_SEC25             \ [0x19] SEC25
    $1a constant GTZC1_MPCBB2_SEC26             \ [0x1a] SEC26
    $1b constant GTZC1_MPCBB2_SEC27             \ [0x1b] SEC27
    $1c constant GTZC1_MPCBB2_SEC28             \ [0x1c] SEC28
    $1d constant GTZC1_MPCBB2_SEC29             \ [0x1d] SEC29
    $1e constant GTZC1_MPCBB2_SEC30             \ [0x1e] SEC30
    $1f constant GTZC1_MPCBB2_SEC31             \ [0x1f] SEC31
  [then]


  [ifdef] GTZC1_MPCBB2_MPCBB2_SECCFGR3_DEF
    \
    \ @brief MPCBBx security configuration for super-block x register
    \ Address offset: 0x10C
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GTZC1_MPCBB2_SEC0              \ [0x00] SEC0
    $01 constant GTZC1_MPCBB2_SEC1              \ [0x01] SEC1
    $02 constant GTZC1_MPCBB2_SEC2              \ [0x02] SEC2
    $03 constant GTZC1_MPCBB2_SEC3              \ [0x03] SEC3
    $04 constant GTZC1_MPCBB2_SEC4              \ [0x04] SEC4
    $05 constant GTZC1_MPCBB2_SEC5              \ [0x05] SEC5
    $06 constant GTZC1_MPCBB2_SEC6              \ [0x06] SEC6
    $07 constant GTZC1_MPCBB2_SEC7              \ [0x07] SEC7
    $08 constant GTZC1_MPCBB2_SEC8              \ [0x08] SEC8
    $09 constant GTZC1_MPCBB2_SEC9              \ [0x09] SEC9
    $0a constant GTZC1_MPCBB2_SEC10             \ [0x0a] SEC10
    $0b constant GTZC1_MPCBB2_SEC11             \ [0x0b] SEC11
    $0c constant GTZC1_MPCBB2_SEC12             \ [0x0c] SEC12
    $0d constant GTZC1_MPCBB2_SEC13             \ [0x0d] SEC13
    $0e constant GTZC1_MPCBB2_SEC14             \ [0x0e] SEC14
    $0f constant GTZC1_MPCBB2_SEC15             \ [0x0f] SEC15
    $10 constant GTZC1_MPCBB2_SEC16             \ [0x10] SEC16
    $11 constant GTZC1_MPCBB2_SEC17             \ [0x11] SEC17
    $12 constant GTZC1_MPCBB2_SEC18             \ [0x12] SEC18
    $13 constant GTZC1_MPCBB2_SEC19             \ [0x13] SEC19
    $14 constant GTZC1_MPCBB2_SEC20             \ [0x14] SEC20
    $15 constant GTZC1_MPCBB2_SEC21             \ [0x15] SEC21
    $16 constant GTZC1_MPCBB2_SEC22             \ [0x16] SEC22
    $17 constant GTZC1_MPCBB2_SEC23             \ [0x17] SEC23
    $18 constant GTZC1_MPCBB2_SEC24             \ [0x18] SEC24
    $19 constant GTZC1_MPCBB2_SEC25             \ [0x19] SEC25
    $1a constant GTZC1_MPCBB2_SEC26             \ [0x1a] SEC26
    $1b constant GTZC1_MPCBB2_SEC27             \ [0x1b] SEC27
    $1c constant GTZC1_MPCBB2_SEC28             \ [0x1c] SEC28
    $1d constant GTZC1_MPCBB2_SEC29             \ [0x1d] SEC29
    $1e constant GTZC1_MPCBB2_SEC30             \ [0x1e] SEC30
    $1f constant GTZC1_MPCBB2_SEC31             \ [0x1f] SEC31
  [then]


  [ifdef] GTZC1_MPCBB2_MPCBB2_SECCFGR4_DEF
    \
    \ @brief MPCBBx security configuration for super-block x register
    \ Address offset: 0x110
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GTZC1_MPCBB2_SEC0              \ [0x00] SEC0
    $01 constant GTZC1_MPCBB2_SEC1              \ [0x01] SEC1
    $02 constant GTZC1_MPCBB2_SEC2              \ [0x02] SEC2
    $03 constant GTZC1_MPCBB2_SEC3              \ [0x03] SEC3
    $04 constant GTZC1_MPCBB2_SEC4              \ [0x04] SEC4
    $05 constant GTZC1_MPCBB2_SEC5              \ [0x05] SEC5
    $06 constant GTZC1_MPCBB2_SEC6              \ [0x06] SEC6
    $07 constant GTZC1_MPCBB2_SEC7              \ [0x07] SEC7
    $08 constant GTZC1_MPCBB2_SEC8              \ [0x08] SEC8
    $09 constant GTZC1_MPCBB2_SEC9              \ [0x09] SEC9
    $0a constant GTZC1_MPCBB2_SEC10             \ [0x0a] SEC10
    $0b constant GTZC1_MPCBB2_SEC11             \ [0x0b] SEC11
    $0c constant GTZC1_MPCBB2_SEC12             \ [0x0c] SEC12
    $0d constant GTZC1_MPCBB2_SEC13             \ [0x0d] SEC13
    $0e constant GTZC1_MPCBB2_SEC14             \ [0x0e] SEC14
    $0f constant GTZC1_MPCBB2_SEC15             \ [0x0f] SEC15
    $10 constant GTZC1_MPCBB2_SEC16             \ [0x10] SEC16
    $11 constant GTZC1_MPCBB2_SEC17             \ [0x11] SEC17
    $12 constant GTZC1_MPCBB2_SEC18             \ [0x12] SEC18
    $13 constant GTZC1_MPCBB2_SEC19             \ [0x13] SEC19
    $14 constant GTZC1_MPCBB2_SEC20             \ [0x14] SEC20
    $15 constant GTZC1_MPCBB2_SEC21             \ [0x15] SEC21
    $16 constant GTZC1_MPCBB2_SEC22             \ [0x16] SEC22
    $17 constant GTZC1_MPCBB2_SEC23             \ [0x17] SEC23
    $18 constant GTZC1_MPCBB2_SEC24             \ [0x18] SEC24
    $19 constant GTZC1_MPCBB2_SEC25             \ [0x19] SEC25
    $1a constant GTZC1_MPCBB2_SEC26             \ [0x1a] SEC26
    $1b constant GTZC1_MPCBB2_SEC27             \ [0x1b] SEC27
    $1c constant GTZC1_MPCBB2_SEC28             \ [0x1c] SEC28
    $1d constant GTZC1_MPCBB2_SEC29             \ [0x1d] SEC29
    $1e constant GTZC1_MPCBB2_SEC30             \ [0x1e] SEC30
    $1f constant GTZC1_MPCBB2_SEC31             \ [0x1f] SEC31
  [then]


  [ifdef] GTZC1_MPCBB2_MPCBB2_SECCFGR5_DEF
    \
    \ @brief MPCBBx security configuration for super-block x register
    \ Address offset: 0x114
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GTZC1_MPCBB2_SEC0              \ [0x00] SEC0
    $01 constant GTZC1_MPCBB2_SEC1              \ [0x01] SEC1
    $02 constant GTZC1_MPCBB2_SEC2              \ [0x02] SEC2
    $03 constant GTZC1_MPCBB2_SEC3              \ [0x03] SEC3
    $04 constant GTZC1_MPCBB2_SEC4              \ [0x04] SEC4
    $05 constant GTZC1_MPCBB2_SEC5              \ [0x05] SEC5
    $06 constant GTZC1_MPCBB2_SEC6              \ [0x06] SEC6
    $07 constant GTZC1_MPCBB2_SEC7              \ [0x07] SEC7
    $08 constant GTZC1_MPCBB2_SEC8              \ [0x08] SEC8
    $09 constant GTZC1_MPCBB2_SEC9              \ [0x09] SEC9
    $0a constant GTZC1_MPCBB2_SEC10             \ [0x0a] SEC10
    $0b constant GTZC1_MPCBB2_SEC11             \ [0x0b] SEC11
    $0c constant GTZC1_MPCBB2_SEC12             \ [0x0c] SEC12
    $0d constant GTZC1_MPCBB2_SEC13             \ [0x0d] SEC13
    $0e constant GTZC1_MPCBB2_SEC14             \ [0x0e] SEC14
    $0f constant GTZC1_MPCBB2_SEC15             \ [0x0f] SEC15
    $10 constant GTZC1_MPCBB2_SEC16             \ [0x10] SEC16
    $11 constant GTZC1_MPCBB2_SEC17             \ [0x11] SEC17
    $12 constant GTZC1_MPCBB2_SEC18             \ [0x12] SEC18
    $13 constant GTZC1_MPCBB2_SEC19             \ [0x13] SEC19
    $14 constant GTZC1_MPCBB2_SEC20             \ [0x14] SEC20
    $15 constant GTZC1_MPCBB2_SEC21             \ [0x15] SEC21
    $16 constant GTZC1_MPCBB2_SEC22             \ [0x16] SEC22
    $17 constant GTZC1_MPCBB2_SEC23             \ [0x17] SEC23
    $18 constant GTZC1_MPCBB2_SEC24             \ [0x18] SEC24
    $19 constant GTZC1_MPCBB2_SEC25             \ [0x19] SEC25
    $1a constant GTZC1_MPCBB2_SEC26             \ [0x1a] SEC26
    $1b constant GTZC1_MPCBB2_SEC27             \ [0x1b] SEC27
    $1c constant GTZC1_MPCBB2_SEC28             \ [0x1c] SEC28
    $1d constant GTZC1_MPCBB2_SEC29             \ [0x1d] SEC29
    $1e constant GTZC1_MPCBB2_SEC30             \ [0x1e] SEC30
    $1f constant GTZC1_MPCBB2_SEC31             \ [0x1f] SEC31
  [then]


  [ifdef] GTZC1_MPCBB2_MPCBB2_SECCFGR6_DEF
    \
    \ @brief MPCBBx security configuration for super-block x register
    \ Address offset: 0x118
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GTZC1_MPCBB2_SEC0              \ [0x00] SEC0
    $01 constant GTZC1_MPCBB2_SEC1              \ [0x01] SEC1
    $02 constant GTZC1_MPCBB2_SEC2              \ [0x02] SEC2
    $03 constant GTZC1_MPCBB2_SEC3              \ [0x03] SEC3
    $04 constant GTZC1_MPCBB2_SEC4              \ [0x04] SEC4
    $05 constant GTZC1_MPCBB2_SEC5              \ [0x05] SEC5
    $06 constant GTZC1_MPCBB2_SEC6              \ [0x06] SEC6
    $07 constant GTZC1_MPCBB2_SEC7              \ [0x07] SEC7
    $08 constant GTZC1_MPCBB2_SEC8              \ [0x08] SEC8
    $09 constant GTZC1_MPCBB2_SEC9              \ [0x09] SEC9
    $0a constant GTZC1_MPCBB2_SEC10             \ [0x0a] SEC10
    $0b constant GTZC1_MPCBB2_SEC11             \ [0x0b] SEC11
    $0c constant GTZC1_MPCBB2_SEC12             \ [0x0c] SEC12
    $0d constant GTZC1_MPCBB2_SEC13             \ [0x0d] SEC13
    $0e constant GTZC1_MPCBB2_SEC14             \ [0x0e] SEC14
    $0f constant GTZC1_MPCBB2_SEC15             \ [0x0f] SEC15
    $10 constant GTZC1_MPCBB2_SEC16             \ [0x10] SEC16
    $11 constant GTZC1_MPCBB2_SEC17             \ [0x11] SEC17
    $12 constant GTZC1_MPCBB2_SEC18             \ [0x12] SEC18
    $13 constant GTZC1_MPCBB2_SEC19             \ [0x13] SEC19
    $14 constant GTZC1_MPCBB2_SEC20             \ [0x14] SEC20
    $15 constant GTZC1_MPCBB2_SEC21             \ [0x15] SEC21
    $16 constant GTZC1_MPCBB2_SEC22             \ [0x16] SEC22
    $17 constant GTZC1_MPCBB2_SEC23             \ [0x17] SEC23
    $18 constant GTZC1_MPCBB2_SEC24             \ [0x18] SEC24
    $19 constant GTZC1_MPCBB2_SEC25             \ [0x19] SEC25
    $1a constant GTZC1_MPCBB2_SEC26             \ [0x1a] SEC26
    $1b constant GTZC1_MPCBB2_SEC27             \ [0x1b] SEC27
    $1c constant GTZC1_MPCBB2_SEC28             \ [0x1c] SEC28
    $1d constant GTZC1_MPCBB2_SEC29             \ [0x1d] SEC29
    $1e constant GTZC1_MPCBB2_SEC30             \ [0x1e] SEC30
    $1f constant GTZC1_MPCBB2_SEC31             \ [0x1f] SEC31
  [then]


  [ifdef] GTZC1_MPCBB2_MPCBB2_SECCFGR7_DEF
    \
    \ @brief MPCBBx security configuration for super-block x register
    \ Address offset: 0x11C
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GTZC1_MPCBB2_SEC0              \ [0x00] SEC0
    $01 constant GTZC1_MPCBB2_SEC1              \ [0x01] SEC1
    $02 constant GTZC1_MPCBB2_SEC2              \ [0x02] SEC2
    $03 constant GTZC1_MPCBB2_SEC3              \ [0x03] SEC3
    $04 constant GTZC1_MPCBB2_SEC4              \ [0x04] SEC4
    $05 constant GTZC1_MPCBB2_SEC5              \ [0x05] SEC5
    $06 constant GTZC1_MPCBB2_SEC6              \ [0x06] SEC6
    $07 constant GTZC1_MPCBB2_SEC7              \ [0x07] SEC7
    $08 constant GTZC1_MPCBB2_SEC8              \ [0x08] SEC8
    $09 constant GTZC1_MPCBB2_SEC9              \ [0x09] SEC9
    $0a constant GTZC1_MPCBB2_SEC10             \ [0x0a] SEC10
    $0b constant GTZC1_MPCBB2_SEC11             \ [0x0b] SEC11
    $0c constant GTZC1_MPCBB2_SEC12             \ [0x0c] SEC12
    $0d constant GTZC1_MPCBB2_SEC13             \ [0x0d] SEC13
    $0e constant GTZC1_MPCBB2_SEC14             \ [0x0e] SEC14
    $0f constant GTZC1_MPCBB2_SEC15             \ [0x0f] SEC15
    $10 constant GTZC1_MPCBB2_SEC16             \ [0x10] SEC16
    $11 constant GTZC1_MPCBB2_SEC17             \ [0x11] SEC17
    $12 constant GTZC1_MPCBB2_SEC18             \ [0x12] SEC18
    $13 constant GTZC1_MPCBB2_SEC19             \ [0x13] SEC19
    $14 constant GTZC1_MPCBB2_SEC20             \ [0x14] SEC20
    $15 constant GTZC1_MPCBB2_SEC21             \ [0x15] SEC21
    $16 constant GTZC1_MPCBB2_SEC22             \ [0x16] SEC22
    $17 constant GTZC1_MPCBB2_SEC23             \ [0x17] SEC23
    $18 constant GTZC1_MPCBB2_SEC24             \ [0x18] SEC24
    $19 constant GTZC1_MPCBB2_SEC25             \ [0x19] SEC25
    $1a constant GTZC1_MPCBB2_SEC26             \ [0x1a] SEC26
    $1b constant GTZC1_MPCBB2_SEC27             \ [0x1b] SEC27
    $1c constant GTZC1_MPCBB2_SEC28             \ [0x1c] SEC28
    $1d constant GTZC1_MPCBB2_SEC29             \ [0x1d] SEC29
    $1e constant GTZC1_MPCBB2_SEC30             \ [0x1e] SEC30
    $1f constant GTZC1_MPCBB2_SEC31             \ [0x1f] SEC31
  [then]


  [ifdef] GTZC1_MPCBB2_MPCBB2_SECCFGR8_DEF
    \
    \ @brief MPCBBx security configuration for super-block x register
    \ Address offset: 0x120
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GTZC1_MPCBB2_SEC0              \ [0x00] SEC0
    $01 constant GTZC1_MPCBB2_SEC1              \ [0x01] SEC1
    $02 constant GTZC1_MPCBB2_SEC2              \ [0x02] SEC2
    $03 constant GTZC1_MPCBB2_SEC3              \ [0x03] SEC3
    $04 constant GTZC1_MPCBB2_SEC4              \ [0x04] SEC4
    $05 constant GTZC1_MPCBB2_SEC5              \ [0x05] SEC5
    $06 constant GTZC1_MPCBB2_SEC6              \ [0x06] SEC6
    $07 constant GTZC1_MPCBB2_SEC7              \ [0x07] SEC7
    $08 constant GTZC1_MPCBB2_SEC8              \ [0x08] SEC8
    $09 constant GTZC1_MPCBB2_SEC9              \ [0x09] SEC9
    $0a constant GTZC1_MPCBB2_SEC10             \ [0x0a] SEC10
    $0b constant GTZC1_MPCBB2_SEC11             \ [0x0b] SEC11
    $0c constant GTZC1_MPCBB2_SEC12             \ [0x0c] SEC12
    $0d constant GTZC1_MPCBB2_SEC13             \ [0x0d] SEC13
    $0e constant GTZC1_MPCBB2_SEC14             \ [0x0e] SEC14
    $0f constant GTZC1_MPCBB2_SEC15             \ [0x0f] SEC15
    $10 constant GTZC1_MPCBB2_SEC16             \ [0x10] SEC16
    $11 constant GTZC1_MPCBB2_SEC17             \ [0x11] SEC17
    $12 constant GTZC1_MPCBB2_SEC18             \ [0x12] SEC18
    $13 constant GTZC1_MPCBB2_SEC19             \ [0x13] SEC19
    $14 constant GTZC1_MPCBB2_SEC20             \ [0x14] SEC20
    $15 constant GTZC1_MPCBB2_SEC21             \ [0x15] SEC21
    $16 constant GTZC1_MPCBB2_SEC22             \ [0x16] SEC22
    $17 constant GTZC1_MPCBB2_SEC23             \ [0x17] SEC23
    $18 constant GTZC1_MPCBB2_SEC24             \ [0x18] SEC24
    $19 constant GTZC1_MPCBB2_SEC25             \ [0x19] SEC25
    $1a constant GTZC1_MPCBB2_SEC26             \ [0x1a] SEC26
    $1b constant GTZC1_MPCBB2_SEC27             \ [0x1b] SEC27
    $1c constant GTZC1_MPCBB2_SEC28             \ [0x1c] SEC28
    $1d constant GTZC1_MPCBB2_SEC29             \ [0x1d] SEC29
    $1e constant GTZC1_MPCBB2_SEC30             \ [0x1e] SEC30
    $1f constant GTZC1_MPCBB2_SEC31             \ [0x1f] SEC31
  [then]


  [ifdef] GTZC1_MPCBB2_MPCBB2_SECCFGR9_DEF
    \
    \ @brief MPCBBx security configuration for super-block x register
    \ Address offset: 0x124
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GTZC1_MPCBB2_SEC0              \ [0x00] SEC0
    $01 constant GTZC1_MPCBB2_SEC1              \ [0x01] SEC1
    $02 constant GTZC1_MPCBB2_SEC2              \ [0x02] SEC2
    $03 constant GTZC1_MPCBB2_SEC3              \ [0x03] SEC3
    $04 constant GTZC1_MPCBB2_SEC4              \ [0x04] SEC4
    $05 constant GTZC1_MPCBB2_SEC5              \ [0x05] SEC5
    $06 constant GTZC1_MPCBB2_SEC6              \ [0x06] SEC6
    $07 constant GTZC1_MPCBB2_SEC7              \ [0x07] SEC7
    $08 constant GTZC1_MPCBB2_SEC8              \ [0x08] SEC8
    $09 constant GTZC1_MPCBB2_SEC9              \ [0x09] SEC9
    $0a constant GTZC1_MPCBB2_SEC10             \ [0x0a] SEC10
    $0b constant GTZC1_MPCBB2_SEC11             \ [0x0b] SEC11
    $0c constant GTZC1_MPCBB2_SEC12             \ [0x0c] SEC12
    $0d constant GTZC1_MPCBB2_SEC13             \ [0x0d] SEC13
    $0e constant GTZC1_MPCBB2_SEC14             \ [0x0e] SEC14
    $0f constant GTZC1_MPCBB2_SEC15             \ [0x0f] SEC15
    $10 constant GTZC1_MPCBB2_SEC16             \ [0x10] SEC16
    $11 constant GTZC1_MPCBB2_SEC17             \ [0x11] SEC17
    $12 constant GTZC1_MPCBB2_SEC18             \ [0x12] SEC18
    $13 constant GTZC1_MPCBB2_SEC19             \ [0x13] SEC19
    $14 constant GTZC1_MPCBB2_SEC20             \ [0x14] SEC20
    $15 constant GTZC1_MPCBB2_SEC21             \ [0x15] SEC21
    $16 constant GTZC1_MPCBB2_SEC22             \ [0x16] SEC22
    $17 constant GTZC1_MPCBB2_SEC23             \ [0x17] SEC23
    $18 constant GTZC1_MPCBB2_SEC24             \ [0x18] SEC24
    $19 constant GTZC1_MPCBB2_SEC25             \ [0x19] SEC25
    $1a constant GTZC1_MPCBB2_SEC26             \ [0x1a] SEC26
    $1b constant GTZC1_MPCBB2_SEC27             \ [0x1b] SEC27
    $1c constant GTZC1_MPCBB2_SEC28             \ [0x1c] SEC28
    $1d constant GTZC1_MPCBB2_SEC29             \ [0x1d] SEC29
    $1e constant GTZC1_MPCBB2_SEC30             \ [0x1e] SEC30
    $1f constant GTZC1_MPCBB2_SEC31             \ [0x1f] SEC31
  [then]


  [ifdef] GTZC1_MPCBB2_MPCBB2_SECCFGR10_DEF
    \
    \ @brief MPCBBx security configuration for super-block x register
    \ Address offset: 0x128
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GTZC1_MPCBB2_SEC0              \ [0x00] SEC0
    $01 constant GTZC1_MPCBB2_SEC1              \ [0x01] SEC1
    $02 constant GTZC1_MPCBB2_SEC2              \ [0x02] SEC2
    $03 constant GTZC1_MPCBB2_SEC3              \ [0x03] SEC3
    $04 constant GTZC1_MPCBB2_SEC4              \ [0x04] SEC4
    $05 constant GTZC1_MPCBB2_SEC5              \ [0x05] SEC5
    $06 constant GTZC1_MPCBB2_SEC6              \ [0x06] SEC6
    $07 constant GTZC1_MPCBB2_SEC7              \ [0x07] SEC7
    $08 constant GTZC1_MPCBB2_SEC8              \ [0x08] SEC8
    $09 constant GTZC1_MPCBB2_SEC9              \ [0x09] SEC9
    $0a constant GTZC1_MPCBB2_SEC10             \ [0x0a] SEC10
    $0b constant GTZC1_MPCBB2_SEC11             \ [0x0b] SEC11
    $0c constant GTZC1_MPCBB2_SEC12             \ [0x0c] SEC12
    $0d constant GTZC1_MPCBB2_SEC13             \ [0x0d] SEC13
    $0e constant GTZC1_MPCBB2_SEC14             \ [0x0e] SEC14
    $0f constant GTZC1_MPCBB2_SEC15             \ [0x0f] SEC15
    $10 constant GTZC1_MPCBB2_SEC16             \ [0x10] SEC16
    $11 constant GTZC1_MPCBB2_SEC17             \ [0x11] SEC17
    $12 constant GTZC1_MPCBB2_SEC18             \ [0x12] SEC18
    $13 constant GTZC1_MPCBB2_SEC19             \ [0x13] SEC19
    $14 constant GTZC1_MPCBB2_SEC20             \ [0x14] SEC20
    $15 constant GTZC1_MPCBB2_SEC21             \ [0x15] SEC21
    $16 constant GTZC1_MPCBB2_SEC22             \ [0x16] SEC22
    $17 constant GTZC1_MPCBB2_SEC23             \ [0x17] SEC23
    $18 constant GTZC1_MPCBB2_SEC24             \ [0x18] SEC24
    $19 constant GTZC1_MPCBB2_SEC25             \ [0x19] SEC25
    $1a constant GTZC1_MPCBB2_SEC26             \ [0x1a] SEC26
    $1b constant GTZC1_MPCBB2_SEC27             \ [0x1b] SEC27
    $1c constant GTZC1_MPCBB2_SEC28             \ [0x1c] SEC28
    $1d constant GTZC1_MPCBB2_SEC29             \ [0x1d] SEC29
    $1e constant GTZC1_MPCBB2_SEC30             \ [0x1e] SEC30
    $1f constant GTZC1_MPCBB2_SEC31             \ [0x1f] SEC31
  [then]


  [ifdef] GTZC1_MPCBB2_MPCBB2_SECCFGR11_DEF
    \
    \ @brief MPCBBx security configuration for super-block x register
    \ Address offset: 0x12C
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GTZC1_MPCBB2_SEC0              \ [0x00] SEC0
    $01 constant GTZC1_MPCBB2_SEC1              \ [0x01] SEC1
    $02 constant GTZC1_MPCBB2_SEC2              \ [0x02] SEC2
    $03 constant GTZC1_MPCBB2_SEC3              \ [0x03] SEC3
    $04 constant GTZC1_MPCBB2_SEC4              \ [0x04] SEC4
    $05 constant GTZC1_MPCBB2_SEC5              \ [0x05] SEC5
    $06 constant GTZC1_MPCBB2_SEC6              \ [0x06] SEC6
    $07 constant GTZC1_MPCBB2_SEC7              \ [0x07] SEC7
    $08 constant GTZC1_MPCBB2_SEC8              \ [0x08] SEC8
    $09 constant GTZC1_MPCBB2_SEC9              \ [0x09] SEC9
    $0a constant GTZC1_MPCBB2_SEC10             \ [0x0a] SEC10
    $0b constant GTZC1_MPCBB2_SEC11             \ [0x0b] SEC11
    $0c constant GTZC1_MPCBB2_SEC12             \ [0x0c] SEC12
    $0d constant GTZC1_MPCBB2_SEC13             \ [0x0d] SEC13
    $0e constant GTZC1_MPCBB2_SEC14             \ [0x0e] SEC14
    $0f constant GTZC1_MPCBB2_SEC15             \ [0x0f] SEC15
    $10 constant GTZC1_MPCBB2_SEC16             \ [0x10] SEC16
    $11 constant GTZC1_MPCBB2_SEC17             \ [0x11] SEC17
    $12 constant GTZC1_MPCBB2_SEC18             \ [0x12] SEC18
    $13 constant GTZC1_MPCBB2_SEC19             \ [0x13] SEC19
    $14 constant GTZC1_MPCBB2_SEC20             \ [0x14] SEC20
    $15 constant GTZC1_MPCBB2_SEC21             \ [0x15] SEC21
    $16 constant GTZC1_MPCBB2_SEC22             \ [0x16] SEC22
    $17 constant GTZC1_MPCBB2_SEC23             \ [0x17] SEC23
    $18 constant GTZC1_MPCBB2_SEC24             \ [0x18] SEC24
    $19 constant GTZC1_MPCBB2_SEC25             \ [0x19] SEC25
    $1a constant GTZC1_MPCBB2_SEC26             \ [0x1a] SEC26
    $1b constant GTZC1_MPCBB2_SEC27             \ [0x1b] SEC27
    $1c constant GTZC1_MPCBB2_SEC28             \ [0x1c] SEC28
    $1d constant GTZC1_MPCBB2_SEC29             \ [0x1d] SEC29
    $1e constant GTZC1_MPCBB2_SEC30             \ [0x1e] SEC30
    $1f constant GTZC1_MPCBB2_SEC31             \ [0x1f] SEC31
  [then]


  [ifdef] GTZC1_MPCBB2_MPCBB2_SECCFGR12_DEF
    \
    \ @brief MPCBBx security configuration for super-block x register
    \ Address offset: 0x130
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GTZC1_MPCBB2_SEC0              \ [0x00] SEC0
    $01 constant GTZC1_MPCBB2_SEC1              \ [0x01] SEC1
    $02 constant GTZC1_MPCBB2_SEC2              \ [0x02] SEC2
    $03 constant GTZC1_MPCBB2_SEC3              \ [0x03] SEC3
    $04 constant GTZC1_MPCBB2_SEC4              \ [0x04] SEC4
    $05 constant GTZC1_MPCBB2_SEC5              \ [0x05] SEC5
    $06 constant GTZC1_MPCBB2_SEC6              \ [0x06] SEC6
    $07 constant GTZC1_MPCBB2_SEC7              \ [0x07] SEC7
    $08 constant GTZC1_MPCBB2_SEC8              \ [0x08] SEC8
    $09 constant GTZC1_MPCBB2_SEC9              \ [0x09] SEC9
    $0a constant GTZC1_MPCBB2_SEC10             \ [0x0a] SEC10
    $0b constant GTZC1_MPCBB2_SEC11             \ [0x0b] SEC11
    $0c constant GTZC1_MPCBB2_SEC12             \ [0x0c] SEC12
    $0d constant GTZC1_MPCBB2_SEC13             \ [0x0d] SEC13
    $0e constant GTZC1_MPCBB2_SEC14             \ [0x0e] SEC14
    $0f constant GTZC1_MPCBB2_SEC15             \ [0x0f] SEC15
    $10 constant GTZC1_MPCBB2_SEC16             \ [0x10] SEC16
    $11 constant GTZC1_MPCBB2_SEC17             \ [0x11] SEC17
    $12 constant GTZC1_MPCBB2_SEC18             \ [0x12] SEC18
    $13 constant GTZC1_MPCBB2_SEC19             \ [0x13] SEC19
    $14 constant GTZC1_MPCBB2_SEC20             \ [0x14] SEC20
    $15 constant GTZC1_MPCBB2_SEC21             \ [0x15] SEC21
    $16 constant GTZC1_MPCBB2_SEC22             \ [0x16] SEC22
    $17 constant GTZC1_MPCBB2_SEC23             \ [0x17] SEC23
    $18 constant GTZC1_MPCBB2_SEC24             \ [0x18] SEC24
    $19 constant GTZC1_MPCBB2_SEC25             \ [0x19] SEC25
    $1a constant GTZC1_MPCBB2_SEC26             \ [0x1a] SEC26
    $1b constant GTZC1_MPCBB2_SEC27             \ [0x1b] SEC27
    $1c constant GTZC1_MPCBB2_SEC28             \ [0x1c] SEC28
    $1d constant GTZC1_MPCBB2_SEC29             \ [0x1d] SEC29
    $1e constant GTZC1_MPCBB2_SEC30             \ [0x1e] SEC30
    $1f constant GTZC1_MPCBB2_SEC31             \ [0x1f] SEC31
  [then]


  [ifdef] GTZC1_MPCBB2_MPCBB2_SECCFGR13_DEF
    \
    \ @brief MPCBBx security configuration for super-block x register
    \ Address offset: 0x134
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GTZC1_MPCBB2_SEC0              \ [0x00] SEC0
    $01 constant GTZC1_MPCBB2_SEC1              \ [0x01] SEC1
    $02 constant GTZC1_MPCBB2_SEC2              \ [0x02] SEC2
    $03 constant GTZC1_MPCBB2_SEC3              \ [0x03] SEC3
    $04 constant GTZC1_MPCBB2_SEC4              \ [0x04] SEC4
    $05 constant GTZC1_MPCBB2_SEC5              \ [0x05] SEC5
    $06 constant GTZC1_MPCBB2_SEC6              \ [0x06] SEC6
    $07 constant GTZC1_MPCBB2_SEC7              \ [0x07] SEC7
    $08 constant GTZC1_MPCBB2_SEC8              \ [0x08] SEC8
    $09 constant GTZC1_MPCBB2_SEC9              \ [0x09] SEC9
    $0a constant GTZC1_MPCBB2_SEC10             \ [0x0a] SEC10
    $0b constant GTZC1_MPCBB2_SEC11             \ [0x0b] SEC11
    $0c constant GTZC1_MPCBB2_SEC12             \ [0x0c] SEC12
    $0d constant GTZC1_MPCBB2_SEC13             \ [0x0d] SEC13
    $0e constant GTZC1_MPCBB2_SEC14             \ [0x0e] SEC14
    $0f constant GTZC1_MPCBB2_SEC15             \ [0x0f] SEC15
    $10 constant GTZC1_MPCBB2_SEC16             \ [0x10] SEC16
    $11 constant GTZC1_MPCBB2_SEC17             \ [0x11] SEC17
    $12 constant GTZC1_MPCBB2_SEC18             \ [0x12] SEC18
    $13 constant GTZC1_MPCBB2_SEC19             \ [0x13] SEC19
    $14 constant GTZC1_MPCBB2_SEC20             \ [0x14] SEC20
    $15 constant GTZC1_MPCBB2_SEC21             \ [0x15] SEC21
    $16 constant GTZC1_MPCBB2_SEC22             \ [0x16] SEC22
    $17 constant GTZC1_MPCBB2_SEC23             \ [0x17] SEC23
    $18 constant GTZC1_MPCBB2_SEC24             \ [0x18] SEC24
    $19 constant GTZC1_MPCBB2_SEC25             \ [0x19] SEC25
    $1a constant GTZC1_MPCBB2_SEC26             \ [0x1a] SEC26
    $1b constant GTZC1_MPCBB2_SEC27             \ [0x1b] SEC27
    $1c constant GTZC1_MPCBB2_SEC28             \ [0x1c] SEC28
    $1d constant GTZC1_MPCBB2_SEC29             \ [0x1d] SEC29
    $1e constant GTZC1_MPCBB2_SEC30             \ [0x1e] SEC30
    $1f constant GTZC1_MPCBB2_SEC31             \ [0x1f] SEC31
  [then]


  [ifdef] GTZC1_MPCBB2_MPCBB2_SECCFGR14_DEF
    \
    \ @brief MPCBBx security configuration for super-block x register
    \ Address offset: 0x138
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GTZC1_MPCBB2_SEC0              \ [0x00] SEC0
    $01 constant GTZC1_MPCBB2_SEC1              \ [0x01] SEC1
    $02 constant GTZC1_MPCBB2_SEC2              \ [0x02] SEC2
    $03 constant GTZC1_MPCBB2_SEC3              \ [0x03] SEC3
    $04 constant GTZC1_MPCBB2_SEC4              \ [0x04] SEC4
    $05 constant GTZC1_MPCBB2_SEC5              \ [0x05] SEC5
    $06 constant GTZC1_MPCBB2_SEC6              \ [0x06] SEC6
    $07 constant GTZC1_MPCBB2_SEC7              \ [0x07] SEC7
    $08 constant GTZC1_MPCBB2_SEC8              \ [0x08] SEC8
    $09 constant GTZC1_MPCBB2_SEC9              \ [0x09] SEC9
    $0a constant GTZC1_MPCBB2_SEC10             \ [0x0a] SEC10
    $0b constant GTZC1_MPCBB2_SEC11             \ [0x0b] SEC11
    $0c constant GTZC1_MPCBB2_SEC12             \ [0x0c] SEC12
    $0d constant GTZC1_MPCBB2_SEC13             \ [0x0d] SEC13
    $0e constant GTZC1_MPCBB2_SEC14             \ [0x0e] SEC14
    $0f constant GTZC1_MPCBB2_SEC15             \ [0x0f] SEC15
    $10 constant GTZC1_MPCBB2_SEC16             \ [0x10] SEC16
    $11 constant GTZC1_MPCBB2_SEC17             \ [0x11] SEC17
    $12 constant GTZC1_MPCBB2_SEC18             \ [0x12] SEC18
    $13 constant GTZC1_MPCBB2_SEC19             \ [0x13] SEC19
    $14 constant GTZC1_MPCBB2_SEC20             \ [0x14] SEC20
    $15 constant GTZC1_MPCBB2_SEC21             \ [0x15] SEC21
    $16 constant GTZC1_MPCBB2_SEC22             \ [0x16] SEC22
    $17 constant GTZC1_MPCBB2_SEC23             \ [0x17] SEC23
    $18 constant GTZC1_MPCBB2_SEC24             \ [0x18] SEC24
    $19 constant GTZC1_MPCBB2_SEC25             \ [0x19] SEC25
    $1a constant GTZC1_MPCBB2_SEC26             \ [0x1a] SEC26
    $1b constant GTZC1_MPCBB2_SEC27             \ [0x1b] SEC27
    $1c constant GTZC1_MPCBB2_SEC28             \ [0x1c] SEC28
    $1d constant GTZC1_MPCBB2_SEC29             \ [0x1d] SEC29
    $1e constant GTZC1_MPCBB2_SEC30             \ [0x1e] SEC30
    $1f constant GTZC1_MPCBB2_SEC31             \ [0x1f] SEC31
  [then]


  [ifdef] GTZC1_MPCBB2_MPCBB2_SECCFGR15_DEF
    \
    \ @brief MPCBBx security configuration for super-block x register
    \ Address offset: 0x13C
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GTZC1_MPCBB2_SEC0              \ [0x00] SEC0
    $01 constant GTZC1_MPCBB2_SEC1              \ [0x01] SEC1
    $02 constant GTZC1_MPCBB2_SEC2              \ [0x02] SEC2
    $03 constant GTZC1_MPCBB2_SEC3              \ [0x03] SEC3
    $04 constant GTZC1_MPCBB2_SEC4              \ [0x04] SEC4
    $05 constant GTZC1_MPCBB2_SEC5              \ [0x05] SEC5
    $06 constant GTZC1_MPCBB2_SEC6              \ [0x06] SEC6
    $07 constant GTZC1_MPCBB2_SEC7              \ [0x07] SEC7
    $08 constant GTZC1_MPCBB2_SEC8              \ [0x08] SEC8
    $09 constant GTZC1_MPCBB2_SEC9              \ [0x09] SEC9
    $0a constant GTZC1_MPCBB2_SEC10             \ [0x0a] SEC10
    $0b constant GTZC1_MPCBB2_SEC11             \ [0x0b] SEC11
    $0c constant GTZC1_MPCBB2_SEC12             \ [0x0c] SEC12
    $0d constant GTZC1_MPCBB2_SEC13             \ [0x0d] SEC13
    $0e constant GTZC1_MPCBB2_SEC14             \ [0x0e] SEC14
    $0f constant GTZC1_MPCBB2_SEC15             \ [0x0f] SEC15
    $10 constant GTZC1_MPCBB2_SEC16             \ [0x10] SEC16
    $11 constant GTZC1_MPCBB2_SEC17             \ [0x11] SEC17
    $12 constant GTZC1_MPCBB2_SEC18             \ [0x12] SEC18
    $13 constant GTZC1_MPCBB2_SEC19             \ [0x13] SEC19
    $14 constant GTZC1_MPCBB2_SEC20             \ [0x14] SEC20
    $15 constant GTZC1_MPCBB2_SEC21             \ [0x15] SEC21
    $16 constant GTZC1_MPCBB2_SEC22             \ [0x16] SEC22
    $17 constant GTZC1_MPCBB2_SEC23             \ [0x17] SEC23
    $18 constant GTZC1_MPCBB2_SEC24             \ [0x18] SEC24
    $19 constant GTZC1_MPCBB2_SEC25             \ [0x19] SEC25
    $1a constant GTZC1_MPCBB2_SEC26             \ [0x1a] SEC26
    $1b constant GTZC1_MPCBB2_SEC27             \ [0x1b] SEC27
    $1c constant GTZC1_MPCBB2_SEC28             \ [0x1c] SEC28
    $1d constant GTZC1_MPCBB2_SEC29             \ [0x1d] SEC29
    $1e constant GTZC1_MPCBB2_SEC30             \ [0x1e] SEC30
    $1f constant GTZC1_MPCBB2_SEC31             \ [0x1f] SEC31
  [then]


  [ifdef] GTZC1_MPCBB2_MPCBB2_SECCFGR16_DEF
    \
    \ @brief MPCBBx security configuration for super-block x register
    \ Address offset: 0x140
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GTZC1_MPCBB2_SEC0              \ [0x00] SEC0
    $01 constant GTZC1_MPCBB2_SEC1              \ [0x01] SEC1
    $02 constant GTZC1_MPCBB2_SEC2              \ [0x02] SEC2
    $03 constant GTZC1_MPCBB2_SEC3              \ [0x03] SEC3
    $04 constant GTZC1_MPCBB2_SEC4              \ [0x04] SEC4
    $05 constant GTZC1_MPCBB2_SEC5              \ [0x05] SEC5
    $06 constant GTZC1_MPCBB2_SEC6              \ [0x06] SEC6
    $07 constant GTZC1_MPCBB2_SEC7              \ [0x07] SEC7
    $08 constant GTZC1_MPCBB2_SEC8              \ [0x08] SEC8
    $09 constant GTZC1_MPCBB2_SEC9              \ [0x09] SEC9
    $0a constant GTZC1_MPCBB2_SEC10             \ [0x0a] SEC10
    $0b constant GTZC1_MPCBB2_SEC11             \ [0x0b] SEC11
    $0c constant GTZC1_MPCBB2_SEC12             \ [0x0c] SEC12
    $0d constant GTZC1_MPCBB2_SEC13             \ [0x0d] SEC13
    $0e constant GTZC1_MPCBB2_SEC14             \ [0x0e] SEC14
    $0f constant GTZC1_MPCBB2_SEC15             \ [0x0f] SEC15
    $10 constant GTZC1_MPCBB2_SEC16             \ [0x10] SEC16
    $11 constant GTZC1_MPCBB2_SEC17             \ [0x11] SEC17
    $12 constant GTZC1_MPCBB2_SEC18             \ [0x12] SEC18
    $13 constant GTZC1_MPCBB2_SEC19             \ [0x13] SEC19
    $14 constant GTZC1_MPCBB2_SEC20             \ [0x14] SEC20
    $15 constant GTZC1_MPCBB2_SEC21             \ [0x15] SEC21
    $16 constant GTZC1_MPCBB2_SEC22             \ [0x16] SEC22
    $17 constant GTZC1_MPCBB2_SEC23             \ [0x17] SEC23
    $18 constant GTZC1_MPCBB2_SEC24             \ [0x18] SEC24
    $19 constant GTZC1_MPCBB2_SEC25             \ [0x19] SEC25
    $1a constant GTZC1_MPCBB2_SEC26             \ [0x1a] SEC26
    $1b constant GTZC1_MPCBB2_SEC27             \ [0x1b] SEC27
    $1c constant GTZC1_MPCBB2_SEC28             \ [0x1c] SEC28
    $1d constant GTZC1_MPCBB2_SEC29             \ [0x1d] SEC29
    $1e constant GTZC1_MPCBB2_SEC30             \ [0x1e] SEC30
    $1f constant GTZC1_MPCBB2_SEC31             \ [0x1f] SEC31
  [then]


  [ifdef] GTZC1_MPCBB2_MPCBB2_SECCFGR17_DEF
    \
    \ @brief MPCBBx security configuration for super-block x register
    \ Address offset: 0x144
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GTZC1_MPCBB2_SEC0              \ [0x00] SEC0
    $01 constant GTZC1_MPCBB2_SEC1              \ [0x01] SEC1
    $02 constant GTZC1_MPCBB2_SEC2              \ [0x02] SEC2
    $03 constant GTZC1_MPCBB2_SEC3              \ [0x03] SEC3
    $04 constant GTZC1_MPCBB2_SEC4              \ [0x04] SEC4
    $05 constant GTZC1_MPCBB2_SEC5              \ [0x05] SEC5
    $06 constant GTZC1_MPCBB2_SEC6              \ [0x06] SEC6
    $07 constant GTZC1_MPCBB2_SEC7              \ [0x07] SEC7
    $08 constant GTZC1_MPCBB2_SEC8              \ [0x08] SEC8
    $09 constant GTZC1_MPCBB2_SEC9              \ [0x09] SEC9
    $0a constant GTZC1_MPCBB2_SEC10             \ [0x0a] SEC10
    $0b constant GTZC1_MPCBB2_SEC11             \ [0x0b] SEC11
    $0c constant GTZC1_MPCBB2_SEC12             \ [0x0c] SEC12
    $0d constant GTZC1_MPCBB2_SEC13             \ [0x0d] SEC13
    $0e constant GTZC1_MPCBB2_SEC14             \ [0x0e] SEC14
    $0f constant GTZC1_MPCBB2_SEC15             \ [0x0f] SEC15
    $10 constant GTZC1_MPCBB2_SEC16             \ [0x10] SEC16
    $11 constant GTZC1_MPCBB2_SEC17             \ [0x11] SEC17
    $12 constant GTZC1_MPCBB2_SEC18             \ [0x12] SEC18
    $13 constant GTZC1_MPCBB2_SEC19             \ [0x13] SEC19
    $14 constant GTZC1_MPCBB2_SEC20             \ [0x14] SEC20
    $15 constant GTZC1_MPCBB2_SEC21             \ [0x15] SEC21
    $16 constant GTZC1_MPCBB2_SEC22             \ [0x16] SEC22
    $17 constant GTZC1_MPCBB2_SEC23             \ [0x17] SEC23
    $18 constant GTZC1_MPCBB2_SEC24             \ [0x18] SEC24
    $19 constant GTZC1_MPCBB2_SEC25             \ [0x19] SEC25
    $1a constant GTZC1_MPCBB2_SEC26             \ [0x1a] SEC26
    $1b constant GTZC1_MPCBB2_SEC27             \ [0x1b] SEC27
    $1c constant GTZC1_MPCBB2_SEC28             \ [0x1c] SEC28
    $1d constant GTZC1_MPCBB2_SEC29             \ [0x1d] SEC29
    $1e constant GTZC1_MPCBB2_SEC30             \ [0x1e] SEC30
    $1f constant GTZC1_MPCBB2_SEC31             \ [0x1f] SEC31
  [then]


  [ifdef] GTZC1_MPCBB2_MPCBB2_SECCFGR18_DEF
    \
    \ @brief MPCBBx security configuration for super-block x register
    \ Address offset: 0x148
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GTZC1_MPCBB2_SEC0              \ [0x00] SEC0
    $01 constant GTZC1_MPCBB2_SEC1              \ [0x01] SEC1
    $02 constant GTZC1_MPCBB2_SEC2              \ [0x02] SEC2
    $03 constant GTZC1_MPCBB2_SEC3              \ [0x03] SEC3
    $04 constant GTZC1_MPCBB2_SEC4              \ [0x04] SEC4
    $05 constant GTZC1_MPCBB2_SEC5              \ [0x05] SEC5
    $06 constant GTZC1_MPCBB2_SEC6              \ [0x06] SEC6
    $07 constant GTZC1_MPCBB2_SEC7              \ [0x07] SEC7
    $08 constant GTZC1_MPCBB2_SEC8              \ [0x08] SEC8
    $09 constant GTZC1_MPCBB2_SEC9              \ [0x09] SEC9
    $0a constant GTZC1_MPCBB2_SEC10             \ [0x0a] SEC10
    $0b constant GTZC1_MPCBB2_SEC11             \ [0x0b] SEC11
    $0c constant GTZC1_MPCBB2_SEC12             \ [0x0c] SEC12
    $0d constant GTZC1_MPCBB2_SEC13             \ [0x0d] SEC13
    $0e constant GTZC1_MPCBB2_SEC14             \ [0x0e] SEC14
    $0f constant GTZC1_MPCBB2_SEC15             \ [0x0f] SEC15
    $10 constant GTZC1_MPCBB2_SEC16             \ [0x10] SEC16
    $11 constant GTZC1_MPCBB2_SEC17             \ [0x11] SEC17
    $12 constant GTZC1_MPCBB2_SEC18             \ [0x12] SEC18
    $13 constant GTZC1_MPCBB2_SEC19             \ [0x13] SEC19
    $14 constant GTZC1_MPCBB2_SEC20             \ [0x14] SEC20
    $15 constant GTZC1_MPCBB2_SEC21             \ [0x15] SEC21
    $16 constant GTZC1_MPCBB2_SEC22             \ [0x16] SEC22
    $17 constant GTZC1_MPCBB2_SEC23             \ [0x17] SEC23
    $18 constant GTZC1_MPCBB2_SEC24             \ [0x18] SEC24
    $19 constant GTZC1_MPCBB2_SEC25             \ [0x19] SEC25
    $1a constant GTZC1_MPCBB2_SEC26             \ [0x1a] SEC26
    $1b constant GTZC1_MPCBB2_SEC27             \ [0x1b] SEC27
    $1c constant GTZC1_MPCBB2_SEC28             \ [0x1c] SEC28
    $1d constant GTZC1_MPCBB2_SEC29             \ [0x1d] SEC29
    $1e constant GTZC1_MPCBB2_SEC30             \ [0x1e] SEC30
    $1f constant GTZC1_MPCBB2_SEC31             \ [0x1f] SEC31
  [then]


  [ifdef] GTZC1_MPCBB2_MPCBB2_SECCFGR19_DEF
    \
    \ @brief MPCBBx security configuration for super-block x register
    \ Address offset: 0x14C
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GTZC1_MPCBB2_SEC0              \ [0x00] SEC0
    $01 constant GTZC1_MPCBB2_SEC1              \ [0x01] SEC1
    $02 constant GTZC1_MPCBB2_SEC2              \ [0x02] SEC2
    $03 constant GTZC1_MPCBB2_SEC3              \ [0x03] SEC3
    $04 constant GTZC1_MPCBB2_SEC4              \ [0x04] SEC4
    $05 constant GTZC1_MPCBB2_SEC5              \ [0x05] SEC5
    $06 constant GTZC1_MPCBB2_SEC6              \ [0x06] SEC6
    $07 constant GTZC1_MPCBB2_SEC7              \ [0x07] SEC7
    $08 constant GTZC1_MPCBB2_SEC8              \ [0x08] SEC8
    $09 constant GTZC1_MPCBB2_SEC9              \ [0x09] SEC9
    $0a constant GTZC1_MPCBB2_SEC10             \ [0x0a] SEC10
    $0b constant GTZC1_MPCBB2_SEC11             \ [0x0b] SEC11
    $0c constant GTZC1_MPCBB2_SEC12             \ [0x0c] SEC12
    $0d constant GTZC1_MPCBB2_SEC13             \ [0x0d] SEC13
    $0e constant GTZC1_MPCBB2_SEC14             \ [0x0e] SEC14
    $0f constant GTZC1_MPCBB2_SEC15             \ [0x0f] SEC15
    $10 constant GTZC1_MPCBB2_SEC16             \ [0x10] SEC16
    $11 constant GTZC1_MPCBB2_SEC17             \ [0x11] SEC17
    $12 constant GTZC1_MPCBB2_SEC18             \ [0x12] SEC18
    $13 constant GTZC1_MPCBB2_SEC19             \ [0x13] SEC19
    $14 constant GTZC1_MPCBB2_SEC20             \ [0x14] SEC20
    $15 constant GTZC1_MPCBB2_SEC21             \ [0x15] SEC21
    $16 constant GTZC1_MPCBB2_SEC22             \ [0x16] SEC22
    $17 constant GTZC1_MPCBB2_SEC23             \ [0x17] SEC23
    $18 constant GTZC1_MPCBB2_SEC24             \ [0x18] SEC24
    $19 constant GTZC1_MPCBB2_SEC25             \ [0x19] SEC25
    $1a constant GTZC1_MPCBB2_SEC26             \ [0x1a] SEC26
    $1b constant GTZC1_MPCBB2_SEC27             \ [0x1b] SEC27
    $1c constant GTZC1_MPCBB2_SEC28             \ [0x1c] SEC28
    $1d constant GTZC1_MPCBB2_SEC29             \ [0x1d] SEC29
    $1e constant GTZC1_MPCBB2_SEC30             \ [0x1e] SEC30
    $1f constant GTZC1_MPCBB2_SEC31             \ [0x1f] SEC31
  [then]


  [ifdef] GTZC1_MPCBB2_MPCBB2_SECCFGR20_DEF
    \
    \ @brief MPCBBx security configuration for super-block x register
    \ Address offset: 0x150
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GTZC1_MPCBB2_SEC0              \ [0x00] SEC0
    $01 constant GTZC1_MPCBB2_SEC1              \ [0x01] SEC1
    $02 constant GTZC1_MPCBB2_SEC2              \ [0x02] SEC2
    $03 constant GTZC1_MPCBB2_SEC3              \ [0x03] SEC3
    $04 constant GTZC1_MPCBB2_SEC4              \ [0x04] SEC4
    $05 constant GTZC1_MPCBB2_SEC5              \ [0x05] SEC5
    $06 constant GTZC1_MPCBB2_SEC6              \ [0x06] SEC6
    $07 constant GTZC1_MPCBB2_SEC7              \ [0x07] SEC7
    $08 constant GTZC1_MPCBB2_SEC8              \ [0x08] SEC8
    $09 constant GTZC1_MPCBB2_SEC9              \ [0x09] SEC9
    $0a constant GTZC1_MPCBB2_SEC10             \ [0x0a] SEC10
    $0b constant GTZC1_MPCBB2_SEC11             \ [0x0b] SEC11
    $0c constant GTZC1_MPCBB2_SEC12             \ [0x0c] SEC12
    $0d constant GTZC1_MPCBB2_SEC13             \ [0x0d] SEC13
    $0e constant GTZC1_MPCBB2_SEC14             \ [0x0e] SEC14
    $0f constant GTZC1_MPCBB2_SEC15             \ [0x0f] SEC15
    $10 constant GTZC1_MPCBB2_SEC16             \ [0x10] SEC16
    $11 constant GTZC1_MPCBB2_SEC17             \ [0x11] SEC17
    $12 constant GTZC1_MPCBB2_SEC18             \ [0x12] SEC18
    $13 constant GTZC1_MPCBB2_SEC19             \ [0x13] SEC19
    $14 constant GTZC1_MPCBB2_SEC20             \ [0x14] SEC20
    $15 constant GTZC1_MPCBB2_SEC21             \ [0x15] SEC21
    $16 constant GTZC1_MPCBB2_SEC22             \ [0x16] SEC22
    $17 constant GTZC1_MPCBB2_SEC23             \ [0x17] SEC23
    $18 constant GTZC1_MPCBB2_SEC24             \ [0x18] SEC24
    $19 constant GTZC1_MPCBB2_SEC25             \ [0x19] SEC25
    $1a constant GTZC1_MPCBB2_SEC26             \ [0x1a] SEC26
    $1b constant GTZC1_MPCBB2_SEC27             \ [0x1b] SEC27
    $1c constant GTZC1_MPCBB2_SEC28             \ [0x1c] SEC28
    $1d constant GTZC1_MPCBB2_SEC29             \ [0x1d] SEC29
    $1e constant GTZC1_MPCBB2_SEC30             \ [0x1e] SEC30
    $1f constant GTZC1_MPCBB2_SEC31             \ [0x1f] SEC31
  [then]


  [ifdef] GTZC1_MPCBB2_MPCBB2_SECCFGR21_DEF
    \
    \ @brief MPCBBx security configuration for super-block x register
    \ Address offset: 0x154
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GTZC1_MPCBB2_SEC0              \ [0x00] SEC0
    $01 constant GTZC1_MPCBB2_SEC1              \ [0x01] SEC1
    $02 constant GTZC1_MPCBB2_SEC2              \ [0x02] SEC2
    $03 constant GTZC1_MPCBB2_SEC3              \ [0x03] SEC3
    $04 constant GTZC1_MPCBB2_SEC4              \ [0x04] SEC4
    $05 constant GTZC1_MPCBB2_SEC5              \ [0x05] SEC5
    $06 constant GTZC1_MPCBB2_SEC6              \ [0x06] SEC6
    $07 constant GTZC1_MPCBB2_SEC7              \ [0x07] SEC7
    $08 constant GTZC1_MPCBB2_SEC8              \ [0x08] SEC8
    $09 constant GTZC1_MPCBB2_SEC9              \ [0x09] SEC9
    $0a constant GTZC1_MPCBB2_SEC10             \ [0x0a] SEC10
    $0b constant GTZC1_MPCBB2_SEC11             \ [0x0b] SEC11
    $0c constant GTZC1_MPCBB2_SEC12             \ [0x0c] SEC12
    $0d constant GTZC1_MPCBB2_SEC13             \ [0x0d] SEC13
    $0e constant GTZC1_MPCBB2_SEC14             \ [0x0e] SEC14
    $0f constant GTZC1_MPCBB2_SEC15             \ [0x0f] SEC15
    $10 constant GTZC1_MPCBB2_SEC16             \ [0x10] SEC16
    $11 constant GTZC1_MPCBB2_SEC17             \ [0x11] SEC17
    $12 constant GTZC1_MPCBB2_SEC18             \ [0x12] SEC18
    $13 constant GTZC1_MPCBB2_SEC19             \ [0x13] SEC19
    $14 constant GTZC1_MPCBB2_SEC20             \ [0x14] SEC20
    $15 constant GTZC1_MPCBB2_SEC21             \ [0x15] SEC21
    $16 constant GTZC1_MPCBB2_SEC22             \ [0x16] SEC22
    $17 constant GTZC1_MPCBB2_SEC23             \ [0x17] SEC23
    $18 constant GTZC1_MPCBB2_SEC24             \ [0x18] SEC24
    $19 constant GTZC1_MPCBB2_SEC25             \ [0x19] SEC25
    $1a constant GTZC1_MPCBB2_SEC26             \ [0x1a] SEC26
    $1b constant GTZC1_MPCBB2_SEC27             \ [0x1b] SEC27
    $1c constant GTZC1_MPCBB2_SEC28             \ [0x1c] SEC28
    $1d constant GTZC1_MPCBB2_SEC29             \ [0x1d] SEC29
    $1e constant GTZC1_MPCBB2_SEC30             \ [0x1e] SEC30
    $1f constant GTZC1_MPCBB2_SEC31             \ [0x1f] SEC31
  [then]


  [ifdef] GTZC1_MPCBB2_MPCBB2_SECCFGR22_DEF
    \
    \ @brief MPCBBx security configuration for super-block x register
    \ Address offset: 0x158
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GTZC1_MPCBB2_SEC0              \ [0x00] SEC0
    $01 constant GTZC1_MPCBB2_SEC1              \ [0x01] SEC1
    $02 constant GTZC1_MPCBB2_SEC2              \ [0x02] SEC2
    $03 constant GTZC1_MPCBB2_SEC3              \ [0x03] SEC3
    $04 constant GTZC1_MPCBB2_SEC4              \ [0x04] SEC4
    $05 constant GTZC1_MPCBB2_SEC5              \ [0x05] SEC5
    $06 constant GTZC1_MPCBB2_SEC6              \ [0x06] SEC6
    $07 constant GTZC1_MPCBB2_SEC7              \ [0x07] SEC7
    $08 constant GTZC1_MPCBB2_SEC8              \ [0x08] SEC8
    $09 constant GTZC1_MPCBB2_SEC9              \ [0x09] SEC9
    $0a constant GTZC1_MPCBB2_SEC10             \ [0x0a] SEC10
    $0b constant GTZC1_MPCBB2_SEC11             \ [0x0b] SEC11
    $0c constant GTZC1_MPCBB2_SEC12             \ [0x0c] SEC12
    $0d constant GTZC1_MPCBB2_SEC13             \ [0x0d] SEC13
    $0e constant GTZC1_MPCBB2_SEC14             \ [0x0e] SEC14
    $0f constant GTZC1_MPCBB2_SEC15             \ [0x0f] SEC15
    $10 constant GTZC1_MPCBB2_SEC16             \ [0x10] SEC16
    $11 constant GTZC1_MPCBB2_SEC17             \ [0x11] SEC17
    $12 constant GTZC1_MPCBB2_SEC18             \ [0x12] SEC18
    $13 constant GTZC1_MPCBB2_SEC19             \ [0x13] SEC19
    $14 constant GTZC1_MPCBB2_SEC20             \ [0x14] SEC20
    $15 constant GTZC1_MPCBB2_SEC21             \ [0x15] SEC21
    $16 constant GTZC1_MPCBB2_SEC22             \ [0x16] SEC22
    $17 constant GTZC1_MPCBB2_SEC23             \ [0x17] SEC23
    $18 constant GTZC1_MPCBB2_SEC24             \ [0x18] SEC24
    $19 constant GTZC1_MPCBB2_SEC25             \ [0x19] SEC25
    $1a constant GTZC1_MPCBB2_SEC26             \ [0x1a] SEC26
    $1b constant GTZC1_MPCBB2_SEC27             \ [0x1b] SEC27
    $1c constant GTZC1_MPCBB2_SEC28             \ [0x1c] SEC28
    $1d constant GTZC1_MPCBB2_SEC29             \ [0x1d] SEC29
    $1e constant GTZC1_MPCBB2_SEC30             \ [0x1e] SEC30
    $1f constant GTZC1_MPCBB2_SEC31             \ [0x1f] SEC31
  [then]


  [ifdef] GTZC1_MPCBB2_MPCBB2_SECCFGR23_DEF
    \
    \ @brief MPCBBx security configuration for super-block x register
    \ Address offset: 0x15C
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GTZC1_MPCBB2_SEC0              \ [0x00] SEC0
    $01 constant GTZC1_MPCBB2_SEC1              \ [0x01] SEC1
    $02 constant GTZC1_MPCBB2_SEC2              \ [0x02] SEC2
    $03 constant GTZC1_MPCBB2_SEC3              \ [0x03] SEC3
    $04 constant GTZC1_MPCBB2_SEC4              \ [0x04] SEC4
    $05 constant GTZC1_MPCBB2_SEC5              \ [0x05] SEC5
    $06 constant GTZC1_MPCBB2_SEC6              \ [0x06] SEC6
    $07 constant GTZC1_MPCBB2_SEC7              \ [0x07] SEC7
    $08 constant GTZC1_MPCBB2_SEC8              \ [0x08] SEC8
    $09 constant GTZC1_MPCBB2_SEC9              \ [0x09] SEC9
    $0a constant GTZC1_MPCBB2_SEC10             \ [0x0a] SEC10
    $0b constant GTZC1_MPCBB2_SEC11             \ [0x0b] SEC11
    $0c constant GTZC1_MPCBB2_SEC12             \ [0x0c] SEC12
    $0d constant GTZC1_MPCBB2_SEC13             \ [0x0d] SEC13
    $0e constant GTZC1_MPCBB2_SEC14             \ [0x0e] SEC14
    $0f constant GTZC1_MPCBB2_SEC15             \ [0x0f] SEC15
    $10 constant GTZC1_MPCBB2_SEC16             \ [0x10] SEC16
    $11 constant GTZC1_MPCBB2_SEC17             \ [0x11] SEC17
    $12 constant GTZC1_MPCBB2_SEC18             \ [0x12] SEC18
    $13 constant GTZC1_MPCBB2_SEC19             \ [0x13] SEC19
    $14 constant GTZC1_MPCBB2_SEC20             \ [0x14] SEC20
    $15 constant GTZC1_MPCBB2_SEC21             \ [0x15] SEC21
    $16 constant GTZC1_MPCBB2_SEC22             \ [0x16] SEC22
    $17 constant GTZC1_MPCBB2_SEC23             \ [0x17] SEC23
    $18 constant GTZC1_MPCBB2_SEC24             \ [0x18] SEC24
    $19 constant GTZC1_MPCBB2_SEC25             \ [0x19] SEC25
    $1a constant GTZC1_MPCBB2_SEC26             \ [0x1a] SEC26
    $1b constant GTZC1_MPCBB2_SEC27             \ [0x1b] SEC27
    $1c constant GTZC1_MPCBB2_SEC28             \ [0x1c] SEC28
    $1d constant GTZC1_MPCBB2_SEC29             \ [0x1d] SEC29
    $1e constant GTZC1_MPCBB2_SEC30             \ [0x1e] SEC30
    $1f constant GTZC1_MPCBB2_SEC31             \ [0x1f] SEC31
  [then]


  [ifdef] GTZC1_MPCBB2_MPCBB2_SECCFGR24_DEF
    \
    \ @brief MPCBBx security configuration for super-block x register
    \ Address offset: 0x160
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GTZC1_MPCBB2_SEC0              \ [0x00] SEC0
    $01 constant GTZC1_MPCBB2_SEC1              \ [0x01] SEC1
    $02 constant GTZC1_MPCBB2_SEC2              \ [0x02] SEC2
    $03 constant GTZC1_MPCBB2_SEC3              \ [0x03] SEC3
    $04 constant GTZC1_MPCBB2_SEC4              \ [0x04] SEC4
    $05 constant GTZC1_MPCBB2_SEC5              \ [0x05] SEC5
    $06 constant GTZC1_MPCBB2_SEC6              \ [0x06] SEC6
    $07 constant GTZC1_MPCBB2_SEC7              \ [0x07] SEC7
    $08 constant GTZC1_MPCBB2_SEC8              \ [0x08] SEC8
    $09 constant GTZC1_MPCBB2_SEC9              \ [0x09] SEC9
    $0a constant GTZC1_MPCBB2_SEC10             \ [0x0a] SEC10
    $0b constant GTZC1_MPCBB2_SEC11             \ [0x0b] SEC11
    $0c constant GTZC1_MPCBB2_SEC12             \ [0x0c] SEC12
    $0d constant GTZC1_MPCBB2_SEC13             \ [0x0d] SEC13
    $0e constant GTZC1_MPCBB2_SEC14             \ [0x0e] SEC14
    $0f constant GTZC1_MPCBB2_SEC15             \ [0x0f] SEC15
    $10 constant GTZC1_MPCBB2_SEC16             \ [0x10] SEC16
    $11 constant GTZC1_MPCBB2_SEC17             \ [0x11] SEC17
    $12 constant GTZC1_MPCBB2_SEC18             \ [0x12] SEC18
    $13 constant GTZC1_MPCBB2_SEC19             \ [0x13] SEC19
    $14 constant GTZC1_MPCBB2_SEC20             \ [0x14] SEC20
    $15 constant GTZC1_MPCBB2_SEC21             \ [0x15] SEC21
    $16 constant GTZC1_MPCBB2_SEC22             \ [0x16] SEC22
    $17 constant GTZC1_MPCBB2_SEC23             \ [0x17] SEC23
    $18 constant GTZC1_MPCBB2_SEC24             \ [0x18] SEC24
    $19 constant GTZC1_MPCBB2_SEC25             \ [0x19] SEC25
    $1a constant GTZC1_MPCBB2_SEC26             \ [0x1a] SEC26
    $1b constant GTZC1_MPCBB2_SEC27             \ [0x1b] SEC27
    $1c constant GTZC1_MPCBB2_SEC28             \ [0x1c] SEC28
    $1d constant GTZC1_MPCBB2_SEC29             \ [0x1d] SEC29
    $1e constant GTZC1_MPCBB2_SEC30             \ [0x1e] SEC30
    $1f constant GTZC1_MPCBB2_SEC31             \ [0x1f] SEC31
  [then]


  [ifdef] GTZC1_MPCBB2_MPCBB2_SECCFGR25_DEF
    \
    \ @brief MPCBBx security configuration for super-block x register
    \ Address offset: 0x164
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GTZC1_MPCBB2_SEC0              \ [0x00] SEC0
    $01 constant GTZC1_MPCBB2_SEC1              \ [0x01] SEC1
    $02 constant GTZC1_MPCBB2_SEC2              \ [0x02] SEC2
    $03 constant GTZC1_MPCBB2_SEC3              \ [0x03] SEC3
    $04 constant GTZC1_MPCBB2_SEC4              \ [0x04] SEC4
    $05 constant GTZC1_MPCBB2_SEC5              \ [0x05] SEC5
    $06 constant GTZC1_MPCBB2_SEC6              \ [0x06] SEC6
    $07 constant GTZC1_MPCBB2_SEC7              \ [0x07] SEC7
    $08 constant GTZC1_MPCBB2_SEC8              \ [0x08] SEC8
    $09 constant GTZC1_MPCBB2_SEC9              \ [0x09] SEC9
    $0a constant GTZC1_MPCBB2_SEC10             \ [0x0a] SEC10
    $0b constant GTZC1_MPCBB2_SEC11             \ [0x0b] SEC11
    $0c constant GTZC1_MPCBB2_SEC12             \ [0x0c] SEC12
    $0d constant GTZC1_MPCBB2_SEC13             \ [0x0d] SEC13
    $0e constant GTZC1_MPCBB2_SEC14             \ [0x0e] SEC14
    $0f constant GTZC1_MPCBB2_SEC15             \ [0x0f] SEC15
    $10 constant GTZC1_MPCBB2_SEC16             \ [0x10] SEC16
    $11 constant GTZC1_MPCBB2_SEC17             \ [0x11] SEC17
    $12 constant GTZC1_MPCBB2_SEC18             \ [0x12] SEC18
    $13 constant GTZC1_MPCBB2_SEC19             \ [0x13] SEC19
    $14 constant GTZC1_MPCBB2_SEC20             \ [0x14] SEC20
    $15 constant GTZC1_MPCBB2_SEC21             \ [0x15] SEC21
    $16 constant GTZC1_MPCBB2_SEC22             \ [0x16] SEC22
    $17 constant GTZC1_MPCBB2_SEC23             \ [0x17] SEC23
    $18 constant GTZC1_MPCBB2_SEC24             \ [0x18] SEC24
    $19 constant GTZC1_MPCBB2_SEC25             \ [0x19] SEC25
    $1a constant GTZC1_MPCBB2_SEC26             \ [0x1a] SEC26
    $1b constant GTZC1_MPCBB2_SEC27             \ [0x1b] SEC27
    $1c constant GTZC1_MPCBB2_SEC28             \ [0x1c] SEC28
    $1d constant GTZC1_MPCBB2_SEC29             \ [0x1d] SEC29
    $1e constant GTZC1_MPCBB2_SEC30             \ [0x1e] SEC30
    $1f constant GTZC1_MPCBB2_SEC31             \ [0x1f] SEC31
  [then]


  [ifdef] GTZC1_MPCBB2_MPCBB2_SECCFGR26_DEF
    \
    \ @brief MPCBBx security configuration for super-block x register
    \ Address offset: 0x168
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GTZC1_MPCBB2_SEC0              \ [0x00] SEC0
    $01 constant GTZC1_MPCBB2_SEC1              \ [0x01] SEC1
    $02 constant GTZC1_MPCBB2_SEC2              \ [0x02] SEC2
    $03 constant GTZC1_MPCBB2_SEC3              \ [0x03] SEC3
    $04 constant GTZC1_MPCBB2_SEC4              \ [0x04] SEC4
    $05 constant GTZC1_MPCBB2_SEC5              \ [0x05] SEC5
    $06 constant GTZC1_MPCBB2_SEC6              \ [0x06] SEC6
    $07 constant GTZC1_MPCBB2_SEC7              \ [0x07] SEC7
    $08 constant GTZC1_MPCBB2_SEC8              \ [0x08] SEC8
    $09 constant GTZC1_MPCBB2_SEC9              \ [0x09] SEC9
    $0a constant GTZC1_MPCBB2_SEC10             \ [0x0a] SEC10
    $0b constant GTZC1_MPCBB2_SEC11             \ [0x0b] SEC11
    $0c constant GTZC1_MPCBB2_SEC12             \ [0x0c] SEC12
    $0d constant GTZC1_MPCBB2_SEC13             \ [0x0d] SEC13
    $0e constant GTZC1_MPCBB2_SEC14             \ [0x0e] SEC14
    $0f constant GTZC1_MPCBB2_SEC15             \ [0x0f] SEC15
    $10 constant GTZC1_MPCBB2_SEC16             \ [0x10] SEC16
    $11 constant GTZC1_MPCBB2_SEC17             \ [0x11] SEC17
    $12 constant GTZC1_MPCBB2_SEC18             \ [0x12] SEC18
    $13 constant GTZC1_MPCBB2_SEC19             \ [0x13] SEC19
    $14 constant GTZC1_MPCBB2_SEC20             \ [0x14] SEC20
    $15 constant GTZC1_MPCBB2_SEC21             \ [0x15] SEC21
    $16 constant GTZC1_MPCBB2_SEC22             \ [0x16] SEC22
    $17 constant GTZC1_MPCBB2_SEC23             \ [0x17] SEC23
    $18 constant GTZC1_MPCBB2_SEC24             \ [0x18] SEC24
    $19 constant GTZC1_MPCBB2_SEC25             \ [0x19] SEC25
    $1a constant GTZC1_MPCBB2_SEC26             \ [0x1a] SEC26
    $1b constant GTZC1_MPCBB2_SEC27             \ [0x1b] SEC27
    $1c constant GTZC1_MPCBB2_SEC28             \ [0x1c] SEC28
    $1d constant GTZC1_MPCBB2_SEC29             \ [0x1d] SEC29
    $1e constant GTZC1_MPCBB2_SEC30             \ [0x1e] SEC30
    $1f constant GTZC1_MPCBB2_SEC31             \ [0x1f] SEC31
  [then]


  [ifdef] GTZC1_MPCBB2_MPCBB2_SECCFGR27_DEF
    \
    \ @brief MPCBBx security configuration for super-block x register
    \ Address offset: 0x16C
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GTZC1_MPCBB2_SEC0              \ [0x00] SEC0
    $01 constant GTZC1_MPCBB2_SEC1              \ [0x01] SEC1
    $02 constant GTZC1_MPCBB2_SEC2              \ [0x02] SEC2
    $03 constant GTZC1_MPCBB2_SEC3              \ [0x03] SEC3
    $04 constant GTZC1_MPCBB2_SEC4              \ [0x04] SEC4
    $05 constant GTZC1_MPCBB2_SEC5              \ [0x05] SEC5
    $06 constant GTZC1_MPCBB2_SEC6              \ [0x06] SEC6
    $07 constant GTZC1_MPCBB2_SEC7              \ [0x07] SEC7
    $08 constant GTZC1_MPCBB2_SEC8              \ [0x08] SEC8
    $09 constant GTZC1_MPCBB2_SEC9              \ [0x09] SEC9
    $0a constant GTZC1_MPCBB2_SEC10             \ [0x0a] SEC10
    $0b constant GTZC1_MPCBB2_SEC11             \ [0x0b] SEC11
    $0c constant GTZC1_MPCBB2_SEC12             \ [0x0c] SEC12
    $0d constant GTZC1_MPCBB2_SEC13             \ [0x0d] SEC13
    $0e constant GTZC1_MPCBB2_SEC14             \ [0x0e] SEC14
    $0f constant GTZC1_MPCBB2_SEC15             \ [0x0f] SEC15
    $10 constant GTZC1_MPCBB2_SEC16             \ [0x10] SEC16
    $11 constant GTZC1_MPCBB2_SEC17             \ [0x11] SEC17
    $12 constant GTZC1_MPCBB2_SEC18             \ [0x12] SEC18
    $13 constant GTZC1_MPCBB2_SEC19             \ [0x13] SEC19
    $14 constant GTZC1_MPCBB2_SEC20             \ [0x14] SEC20
    $15 constant GTZC1_MPCBB2_SEC21             \ [0x15] SEC21
    $16 constant GTZC1_MPCBB2_SEC22             \ [0x16] SEC22
    $17 constant GTZC1_MPCBB2_SEC23             \ [0x17] SEC23
    $18 constant GTZC1_MPCBB2_SEC24             \ [0x18] SEC24
    $19 constant GTZC1_MPCBB2_SEC25             \ [0x19] SEC25
    $1a constant GTZC1_MPCBB2_SEC26             \ [0x1a] SEC26
    $1b constant GTZC1_MPCBB2_SEC27             \ [0x1b] SEC27
    $1c constant GTZC1_MPCBB2_SEC28             \ [0x1c] SEC28
    $1d constant GTZC1_MPCBB2_SEC29             \ [0x1d] SEC29
    $1e constant GTZC1_MPCBB2_SEC30             \ [0x1e] SEC30
    $1f constant GTZC1_MPCBB2_SEC31             \ [0x1f] SEC31
  [then]


  [ifdef] GTZC1_MPCBB2_MPCBB2_SECCFGR28_DEF
    \
    \ @brief MPCBBx security configuration for super-block x register
    \ Address offset: 0x170
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GTZC1_MPCBB2_SEC0              \ [0x00] SEC0
    $01 constant GTZC1_MPCBB2_SEC1              \ [0x01] SEC1
    $02 constant GTZC1_MPCBB2_SEC2              \ [0x02] SEC2
    $03 constant GTZC1_MPCBB2_SEC3              \ [0x03] SEC3
    $04 constant GTZC1_MPCBB2_SEC4              \ [0x04] SEC4
    $05 constant GTZC1_MPCBB2_SEC5              \ [0x05] SEC5
    $06 constant GTZC1_MPCBB2_SEC6              \ [0x06] SEC6
    $07 constant GTZC1_MPCBB2_SEC7              \ [0x07] SEC7
    $08 constant GTZC1_MPCBB2_SEC8              \ [0x08] SEC8
    $09 constant GTZC1_MPCBB2_SEC9              \ [0x09] SEC9
    $0a constant GTZC1_MPCBB2_SEC10             \ [0x0a] SEC10
    $0b constant GTZC1_MPCBB2_SEC11             \ [0x0b] SEC11
    $0c constant GTZC1_MPCBB2_SEC12             \ [0x0c] SEC12
    $0d constant GTZC1_MPCBB2_SEC13             \ [0x0d] SEC13
    $0e constant GTZC1_MPCBB2_SEC14             \ [0x0e] SEC14
    $0f constant GTZC1_MPCBB2_SEC15             \ [0x0f] SEC15
    $10 constant GTZC1_MPCBB2_SEC16             \ [0x10] SEC16
    $11 constant GTZC1_MPCBB2_SEC17             \ [0x11] SEC17
    $12 constant GTZC1_MPCBB2_SEC18             \ [0x12] SEC18
    $13 constant GTZC1_MPCBB2_SEC19             \ [0x13] SEC19
    $14 constant GTZC1_MPCBB2_SEC20             \ [0x14] SEC20
    $15 constant GTZC1_MPCBB2_SEC21             \ [0x15] SEC21
    $16 constant GTZC1_MPCBB2_SEC22             \ [0x16] SEC22
    $17 constant GTZC1_MPCBB2_SEC23             \ [0x17] SEC23
    $18 constant GTZC1_MPCBB2_SEC24             \ [0x18] SEC24
    $19 constant GTZC1_MPCBB2_SEC25             \ [0x19] SEC25
    $1a constant GTZC1_MPCBB2_SEC26             \ [0x1a] SEC26
    $1b constant GTZC1_MPCBB2_SEC27             \ [0x1b] SEC27
    $1c constant GTZC1_MPCBB2_SEC28             \ [0x1c] SEC28
    $1d constant GTZC1_MPCBB2_SEC29             \ [0x1d] SEC29
    $1e constant GTZC1_MPCBB2_SEC30             \ [0x1e] SEC30
    $1f constant GTZC1_MPCBB2_SEC31             \ [0x1f] SEC31
  [then]


  [ifdef] GTZC1_MPCBB2_MPCBB2_SECCFGR29_DEF
    \
    \ @brief MPCBBx security configuration for super-block x register
    \ Address offset: 0x174
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GTZC1_MPCBB2_SEC0              \ [0x00] SEC0
    $01 constant GTZC1_MPCBB2_SEC1              \ [0x01] SEC1
    $02 constant GTZC1_MPCBB2_SEC2              \ [0x02] SEC2
    $03 constant GTZC1_MPCBB2_SEC3              \ [0x03] SEC3
    $04 constant GTZC1_MPCBB2_SEC4              \ [0x04] SEC4
    $05 constant GTZC1_MPCBB2_SEC5              \ [0x05] SEC5
    $06 constant GTZC1_MPCBB2_SEC6              \ [0x06] SEC6
    $07 constant GTZC1_MPCBB2_SEC7              \ [0x07] SEC7
    $08 constant GTZC1_MPCBB2_SEC8              \ [0x08] SEC8
    $09 constant GTZC1_MPCBB2_SEC9              \ [0x09] SEC9
    $0a constant GTZC1_MPCBB2_SEC10             \ [0x0a] SEC10
    $0b constant GTZC1_MPCBB2_SEC11             \ [0x0b] SEC11
    $0c constant GTZC1_MPCBB2_SEC12             \ [0x0c] SEC12
    $0d constant GTZC1_MPCBB2_SEC13             \ [0x0d] SEC13
    $0e constant GTZC1_MPCBB2_SEC14             \ [0x0e] SEC14
    $0f constant GTZC1_MPCBB2_SEC15             \ [0x0f] SEC15
    $10 constant GTZC1_MPCBB2_SEC16             \ [0x10] SEC16
    $11 constant GTZC1_MPCBB2_SEC17             \ [0x11] SEC17
    $12 constant GTZC1_MPCBB2_SEC18             \ [0x12] SEC18
    $13 constant GTZC1_MPCBB2_SEC19             \ [0x13] SEC19
    $14 constant GTZC1_MPCBB2_SEC20             \ [0x14] SEC20
    $15 constant GTZC1_MPCBB2_SEC21             \ [0x15] SEC21
    $16 constant GTZC1_MPCBB2_SEC22             \ [0x16] SEC22
    $17 constant GTZC1_MPCBB2_SEC23             \ [0x17] SEC23
    $18 constant GTZC1_MPCBB2_SEC24             \ [0x18] SEC24
    $19 constant GTZC1_MPCBB2_SEC25             \ [0x19] SEC25
    $1a constant GTZC1_MPCBB2_SEC26             \ [0x1a] SEC26
    $1b constant GTZC1_MPCBB2_SEC27             \ [0x1b] SEC27
    $1c constant GTZC1_MPCBB2_SEC28             \ [0x1c] SEC28
    $1d constant GTZC1_MPCBB2_SEC29             \ [0x1d] SEC29
    $1e constant GTZC1_MPCBB2_SEC30             \ [0x1e] SEC30
    $1f constant GTZC1_MPCBB2_SEC31             \ [0x1f] SEC31
  [then]


  [ifdef] GTZC1_MPCBB2_MPCBB2_SECCFGR30_DEF
    \
    \ @brief MPCBBx security configuration for super-block x register
    \ Address offset: 0x178
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GTZC1_MPCBB2_SEC0              \ [0x00] SEC0
    $01 constant GTZC1_MPCBB2_SEC1              \ [0x01] SEC1
    $02 constant GTZC1_MPCBB2_SEC2              \ [0x02] SEC2
    $03 constant GTZC1_MPCBB2_SEC3              \ [0x03] SEC3
    $04 constant GTZC1_MPCBB2_SEC4              \ [0x04] SEC4
    $05 constant GTZC1_MPCBB2_SEC5              \ [0x05] SEC5
    $06 constant GTZC1_MPCBB2_SEC6              \ [0x06] SEC6
    $07 constant GTZC1_MPCBB2_SEC7              \ [0x07] SEC7
    $08 constant GTZC1_MPCBB2_SEC8              \ [0x08] SEC8
    $09 constant GTZC1_MPCBB2_SEC9              \ [0x09] SEC9
    $0a constant GTZC1_MPCBB2_SEC10             \ [0x0a] SEC10
    $0b constant GTZC1_MPCBB2_SEC11             \ [0x0b] SEC11
    $0c constant GTZC1_MPCBB2_SEC12             \ [0x0c] SEC12
    $0d constant GTZC1_MPCBB2_SEC13             \ [0x0d] SEC13
    $0e constant GTZC1_MPCBB2_SEC14             \ [0x0e] SEC14
    $0f constant GTZC1_MPCBB2_SEC15             \ [0x0f] SEC15
    $10 constant GTZC1_MPCBB2_SEC16             \ [0x10] SEC16
    $11 constant GTZC1_MPCBB2_SEC17             \ [0x11] SEC17
    $12 constant GTZC1_MPCBB2_SEC18             \ [0x12] SEC18
    $13 constant GTZC1_MPCBB2_SEC19             \ [0x13] SEC19
    $14 constant GTZC1_MPCBB2_SEC20             \ [0x14] SEC20
    $15 constant GTZC1_MPCBB2_SEC21             \ [0x15] SEC21
    $16 constant GTZC1_MPCBB2_SEC22             \ [0x16] SEC22
    $17 constant GTZC1_MPCBB2_SEC23             \ [0x17] SEC23
    $18 constant GTZC1_MPCBB2_SEC24             \ [0x18] SEC24
    $19 constant GTZC1_MPCBB2_SEC25             \ [0x19] SEC25
    $1a constant GTZC1_MPCBB2_SEC26             \ [0x1a] SEC26
    $1b constant GTZC1_MPCBB2_SEC27             \ [0x1b] SEC27
    $1c constant GTZC1_MPCBB2_SEC28             \ [0x1c] SEC28
    $1d constant GTZC1_MPCBB2_SEC29             \ [0x1d] SEC29
    $1e constant GTZC1_MPCBB2_SEC30             \ [0x1e] SEC30
    $1f constant GTZC1_MPCBB2_SEC31             \ [0x1f] SEC31
  [then]


  [ifdef] GTZC1_MPCBB2_MPCBB2_SECCFGR31_DEF
    \
    \ @brief MPCBBx security configuration for super-block x register
    \ Address offset: 0x17C
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GTZC1_MPCBB2_SEC0              \ [0x00] SEC0
    $01 constant GTZC1_MPCBB2_SEC1              \ [0x01] SEC1
    $02 constant GTZC1_MPCBB2_SEC2              \ [0x02] SEC2
    $03 constant GTZC1_MPCBB2_SEC3              \ [0x03] SEC3
    $04 constant GTZC1_MPCBB2_SEC4              \ [0x04] SEC4
    $05 constant GTZC1_MPCBB2_SEC5              \ [0x05] SEC5
    $06 constant GTZC1_MPCBB2_SEC6              \ [0x06] SEC6
    $07 constant GTZC1_MPCBB2_SEC7              \ [0x07] SEC7
    $08 constant GTZC1_MPCBB2_SEC8              \ [0x08] SEC8
    $09 constant GTZC1_MPCBB2_SEC9              \ [0x09] SEC9
    $0a constant GTZC1_MPCBB2_SEC10             \ [0x0a] SEC10
    $0b constant GTZC1_MPCBB2_SEC11             \ [0x0b] SEC11
    $0c constant GTZC1_MPCBB2_SEC12             \ [0x0c] SEC12
    $0d constant GTZC1_MPCBB2_SEC13             \ [0x0d] SEC13
    $0e constant GTZC1_MPCBB2_SEC14             \ [0x0e] SEC14
    $0f constant GTZC1_MPCBB2_SEC15             \ [0x0f] SEC15
    $10 constant GTZC1_MPCBB2_SEC16             \ [0x10] SEC16
    $11 constant GTZC1_MPCBB2_SEC17             \ [0x11] SEC17
    $12 constant GTZC1_MPCBB2_SEC18             \ [0x12] SEC18
    $13 constant GTZC1_MPCBB2_SEC19             \ [0x13] SEC19
    $14 constant GTZC1_MPCBB2_SEC20             \ [0x14] SEC20
    $15 constant GTZC1_MPCBB2_SEC21             \ [0x15] SEC21
    $16 constant GTZC1_MPCBB2_SEC22             \ [0x16] SEC22
    $17 constant GTZC1_MPCBB2_SEC23             \ [0x17] SEC23
    $18 constant GTZC1_MPCBB2_SEC24             \ [0x18] SEC24
    $19 constant GTZC1_MPCBB2_SEC25             \ [0x19] SEC25
    $1a constant GTZC1_MPCBB2_SEC26             \ [0x1a] SEC26
    $1b constant GTZC1_MPCBB2_SEC27             \ [0x1b] SEC27
    $1c constant GTZC1_MPCBB2_SEC28             \ [0x1c] SEC28
    $1d constant GTZC1_MPCBB2_SEC29             \ [0x1d] SEC29
    $1e constant GTZC1_MPCBB2_SEC30             \ [0x1e] SEC30
    $1f constant GTZC1_MPCBB2_SEC31             \ [0x1f] SEC31
  [then]


  [ifdef] GTZC1_MPCBB2_MPCBB2_PRIVCFGR0_DEF
    \
    \ @brief MPCBB privileged configuration for super-block x register
    \ Address offset: 0x200
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GTZC1_MPCBB2_PRIV0             \ [0x00] PRIV0
    $01 constant GTZC1_MPCBB2_PRIV1             \ [0x01] PRIV1
    $02 constant GTZC1_MPCBB2_PRIV2             \ [0x02] PRIV2
    $03 constant GTZC1_MPCBB2_PRIV3             \ [0x03] PRIV3
    $04 constant GTZC1_MPCBB2_PRIV4             \ [0x04] PRIV4
    $05 constant GTZC1_MPCBB2_PRIV5             \ [0x05] PRIV5
    $06 constant GTZC1_MPCBB2_PRIV6             \ [0x06] PRIV6
    $07 constant GTZC1_MPCBB2_PRIV7             \ [0x07] PRIV7
    $08 constant GTZC1_MPCBB2_PRIV8             \ [0x08] PRIV8
    $09 constant GTZC1_MPCBB2_PRIV9             \ [0x09] PRIV9
    $0a constant GTZC1_MPCBB2_PRIV10            \ [0x0a] PRIV10
    $0b constant GTZC1_MPCBB2_PRIV11            \ [0x0b] PRIV11
    $0c constant GTZC1_MPCBB2_PRIV12            \ [0x0c] PRIV12
    $0d constant GTZC1_MPCBB2_PRIV13            \ [0x0d] PRIV13
    $0e constant GTZC1_MPCBB2_PRIV14            \ [0x0e] PRIV14
    $0f constant GTZC1_MPCBB2_PRIV15            \ [0x0f] PRIV15
    $10 constant GTZC1_MPCBB2_PRIV16            \ [0x10] PRIV16
    $11 constant GTZC1_MPCBB2_PRIV17            \ [0x11] PRIV17
    $12 constant GTZC1_MPCBB2_PRIV18            \ [0x12] PRIV18
    $13 constant GTZC1_MPCBB2_PRIV19            \ [0x13] PRIV19
    $14 constant GTZC1_MPCBB2_PRIV20            \ [0x14] PRIV20
    $15 constant GTZC1_MPCBB2_PRIV21            \ [0x15] PRIV21
    $16 constant GTZC1_MPCBB2_PRIV22            \ [0x16] PRIV22
    $17 constant GTZC1_MPCBB2_PRIV23            \ [0x17] PRIV23
    $18 constant GTZC1_MPCBB2_PRIV24            \ [0x18] PRIV24
    $19 constant GTZC1_MPCBB2_PRIV25            \ [0x19] PRIV25
    $1a constant GTZC1_MPCBB2_PRIV26            \ [0x1a] PRIV26
    $1b constant GTZC1_MPCBB2_PRIV27            \ [0x1b] PRIV27
    $1c constant GTZC1_MPCBB2_PRIV28            \ [0x1c] PRIV28
    $1d constant GTZC1_MPCBB2_PRIV29            \ [0x1d] PRIV29
    $1e constant GTZC1_MPCBB2_PRIV30            \ [0x1e] PRIV30
    $1f constant GTZC1_MPCBB2_PRIV31            \ [0x1f] PRIV31
  [then]


  [ifdef] GTZC1_MPCBB2_MPCBB2_PRIVCFGR1_DEF
    \
    \ @brief MPCBB privileged configuration for super-block x register
    \ Address offset: 0x204
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GTZC1_MPCBB2_PRIV0             \ [0x00] PRIV0
    $01 constant GTZC1_MPCBB2_PRIV1             \ [0x01] PRIV1
    $02 constant GTZC1_MPCBB2_PRIV2             \ [0x02] PRIV2
    $03 constant GTZC1_MPCBB2_PRIV3             \ [0x03] PRIV3
    $04 constant GTZC1_MPCBB2_PRIV4             \ [0x04] PRIV4
    $05 constant GTZC1_MPCBB2_PRIV5             \ [0x05] PRIV5
    $06 constant GTZC1_MPCBB2_PRIV6             \ [0x06] PRIV6
    $07 constant GTZC1_MPCBB2_PRIV7             \ [0x07] PRIV7
    $08 constant GTZC1_MPCBB2_PRIV8             \ [0x08] PRIV8
    $09 constant GTZC1_MPCBB2_PRIV9             \ [0x09] PRIV9
    $0a constant GTZC1_MPCBB2_PRIV10            \ [0x0a] PRIV10
    $0b constant GTZC1_MPCBB2_PRIV11            \ [0x0b] PRIV11
    $0c constant GTZC1_MPCBB2_PRIV12            \ [0x0c] PRIV12
    $0d constant GTZC1_MPCBB2_PRIV13            \ [0x0d] PRIV13
    $0e constant GTZC1_MPCBB2_PRIV14            \ [0x0e] PRIV14
    $0f constant GTZC1_MPCBB2_PRIV15            \ [0x0f] PRIV15
    $10 constant GTZC1_MPCBB2_PRIV16            \ [0x10] PRIV16
    $11 constant GTZC1_MPCBB2_PRIV17            \ [0x11] PRIV17
    $12 constant GTZC1_MPCBB2_PRIV18            \ [0x12] PRIV18
    $13 constant GTZC1_MPCBB2_PRIV19            \ [0x13] PRIV19
    $14 constant GTZC1_MPCBB2_PRIV20            \ [0x14] PRIV20
    $15 constant GTZC1_MPCBB2_PRIV21            \ [0x15] PRIV21
    $16 constant GTZC1_MPCBB2_PRIV22            \ [0x16] PRIV22
    $17 constant GTZC1_MPCBB2_PRIV23            \ [0x17] PRIV23
    $18 constant GTZC1_MPCBB2_PRIV24            \ [0x18] PRIV24
    $19 constant GTZC1_MPCBB2_PRIV25            \ [0x19] PRIV25
    $1a constant GTZC1_MPCBB2_PRIV26            \ [0x1a] PRIV26
    $1b constant GTZC1_MPCBB2_PRIV27            \ [0x1b] PRIV27
    $1c constant GTZC1_MPCBB2_PRIV28            \ [0x1c] PRIV28
    $1d constant GTZC1_MPCBB2_PRIV29            \ [0x1d] PRIV29
    $1e constant GTZC1_MPCBB2_PRIV30            \ [0x1e] PRIV30
    $1f constant GTZC1_MPCBB2_PRIV31            \ [0x1f] PRIV31
  [then]


  [ifdef] GTZC1_MPCBB2_MPCBB2_PRIVCFGR2_DEF
    \
    \ @brief MPCBB privileged configuration for super-block x register
    \ Address offset: 0x208
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GTZC1_MPCBB2_PRIV0             \ [0x00] PRIV0
    $01 constant GTZC1_MPCBB2_PRIV1             \ [0x01] PRIV1
    $02 constant GTZC1_MPCBB2_PRIV2             \ [0x02] PRIV2
    $03 constant GTZC1_MPCBB2_PRIV3             \ [0x03] PRIV3
    $04 constant GTZC1_MPCBB2_PRIV4             \ [0x04] PRIV4
    $05 constant GTZC1_MPCBB2_PRIV5             \ [0x05] PRIV5
    $06 constant GTZC1_MPCBB2_PRIV6             \ [0x06] PRIV6
    $07 constant GTZC1_MPCBB2_PRIV7             \ [0x07] PRIV7
    $08 constant GTZC1_MPCBB2_PRIV8             \ [0x08] PRIV8
    $09 constant GTZC1_MPCBB2_PRIV9             \ [0x09] PRIV9
    $0a constant GTZC1_MPCBB2_PRIV10            \ [0x0a] PRIV10
    $0b constant GTZC1_MPCBB2_PRIV11            \ [0x0b] PRIV11
    $0c constant GTZC1_MPCBB2_PRIV12            \ [0x0c] PRIV12
    $0d constant GTZC1_MPCBB2_PRIV13            \ [0x0d] PRIV13
    $0e constant GTZC1_MPCBB2_PRIV14            \ [0x0e] PRIV14
    $0f constant GTZC1_MPCBB2_PRIV15            \ [0x0f] PRIV15
    $10 constant GTZC1_MPCBB2_PRIV16            \ [0x10] PRIV16
    $11 constant GTZC1_MPCBB2_PRIV17            \ [0x11] PRIV17
    $12 constant GTZC1_MPCBB2_PRIV18            \ [0x12] PRIV18
    $13 constant GTZC1_MPCBB2_PRIV19            \ [0x13] PRIV19
    $14 constant GTZC1_MPCBB2_PRIV20            \ [0x14] PRIV20
    $15 constant GTZC1_MPCBB2_PRIV21            \ [0x15] PRIV21
    $16 constant GTZC1_MPCBB2_PRIV22            \ [0x16] PRIV22
    $17 constant GTZC1_MPCBB2_PRIV23            \ [0x17] PRIV23
    $18 constant GTZC1_MPCBB2_PRIV24            \ [0x18] PRIV24
    $19 constant GTZC1_MPCBB2_PRIV25            \ [0x19] PRIV25
    $1a constant GTZC1_MPCBB2_PRIV26            \ [0x1a] PRIV26
    $1b constant GTZC1_MPCBB2_PRIV27            \ [0x1b] PRIV27
    $1c constant GTZC1_MPCBB2_PRIV28            \ [0x1c] PRIV28
    $1d constant GTZC1_MPCBB2_PRIV29            \ [0x1d] PRIV29
    $1e constant GTZC1_MPCBB2_PRIV30            \ [0x1e] PRIV30
    $1f constant GTZC1_MPCBB2_PRIV31            \ [0x1f] PRIV31
  [then]


  [ifdef] GTZC1_MPCBB2_MPCBB2_PRIVCFGR3_DEF
    \
    \ @brief MPCBB privileged configuration for super-block x register
    \ Address offset: 0x20C
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GTZC1_MPCBB2_PRIV0             \ [0x00] PRIV0
    $01 constant GTZC1_MPCBB2_PRIV1             \ [0x01] PRIV1
    $02 constant GTZC1_MPCBB2_PRIV2             \ [0x02] PRIV2
    $03 constant GTZC1_MPCBB2_PRIV3             \ [0x03] PRIV3
    $04 constant GTZC1_MPCBB2_PRIV4             \ [0x04] PRIV4
    $05 constant GTZC1_MPCBB2_PRIV5             \ [0x05] PRIV5
    $06 constant GTZC1_MPCBB2_PRIV6             \ [0x06] PRIV6
    $07 constant GTZC1_MPCBB2_PRIV7             \ [0x07] PRIV7
    $08 constant GTZC1_MPCBB2_PRIV8             \ [0x08] PRIV8
    $09 constant GTZC1_MPCBB2_PRIV9             \ [0x09] PRIV9
    $0a constant GTZC1_MPCBB2_PRIV10            \ [0x0a] PRIV10
    $0b constant GTZC1_MPCBB2_PRIV11            \ [0x0b] PRIV11
    $0c constant GTZC1_MPCBB2_PRIV12            \ [0x0c] PRIV12
    $0d constant GTZC1_MPCBB2_PRIV13            \ [0x0d] PRIV13
    $0e constant GTZC1_MPCBB2_PRIV14            \ [0x0e] PRIV14
    $0f constant GTZC1_MPCBB2_PRIV15            \ [0x0f] PRIV15
    $10 constant GTZC1_MPCBB2_PRIV16            \ [0x10] PRIV16
    $11 constant GTZC1_MPCBB2_PRIV17            \ [0x11] PRIV17
    $12 constant GTZC1_MPCBB2_PRIV18            \ [0x12] PRIV18
    $13 constant GTZC1_MPCBB2_PRIV19            \ [0x13] PRIV19
    $14 constant GTZC1_MPCBB2_PRIV20            \ [0x14] PRIV20
    $15 constant GTZC1_MPCBB2_PRIV21            \ [0x15] PRIV21
    $16 constant GTZC1_MPCBB2_PRIV22            \ [0x16] PRIV22
    $17 constant GTZC1_MPCBB2_PRIV23            \ [0x17] PRIV23
    $18 constant GTZC1_MPCBB2_PRIV24            \ [0x18] PRIV24
    $19 constant GTZC1_MPCBB2_PRIV25            \ [0x19] PRIV25
    $1a constant GTZC1_MPCBB2_PRIV26            \ [0x1a] PRIV26
    $1b constant GTZC1_MPCBB2_PRIV27            \ [0x1b] PRIV27
    $1c constant GTZC1_MPCBB2_PRIV28            \ [0x1c] PRIV28
    $1d constant GTZC1_MPCBB2_PRIV29            \ [0x1d] PRIV29
    $1e constant GTZC1_MPCBB2_PRIV30            \ [0x1e] PRIV30
    $1f constant GTZC1_MPCBB2_PRIV31            \ [0x1f] PRIV31
  [then]


  [ifdef] GTZC1_MPCBB2_MPCBB2_PRIVCFGR4_DEF
    \
    \ @brief MPCBB privileged configuration for super-block x register
    \ Address offset: 0x210
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GTZC1_MPCBB2_PRIV0             \ [0x00] PRIV0
    $01 constant GTZC1_MPCBB2_PRIV1             \ [0x01] PRIV1
    $02 constant GTZC1_MPCBB2_PRIV2             \ [0x02] PRIV2
    $03 constant GTZC1_MPCBB2_PRIV3             \ [0x03] PRIV3
    $04 constant GTZC1_MPCBB2_PRIV4             \ [0x04] PRIV4
    $05 constant GTZC1_MPCBB2_PRIV5             \ [0x05] PRIV5
    $06 constant GTZC1_MPCBB2_PRIV6             \ [0x06] PRIV6
    $07 constant GTZC1_MPCBB2_PRIV7             \ [0x07] PRIV7
    $08 constant GTZC1_MPCBB2_PRIV8             \ [0x08] PRIV8
    $09 constant GTZC1_MPCBB2_PRIV9             \ [0x09] PRIV9
    $0a constant GTZC1_MPCBB2_PRIV10            \ [0x0a] PRIV10
    $0b constant GTZC1_MPCBB2_PRIV11            \ [0x0b] PRIV11
    $0c constant GTZC1_MPCBB2_PRIV12            \ [0x0c] PRIV12
    $0d constant GTZC1_MPCBB2_PRIV13            \ [0x0d] PRIV13
    $0e constant GTZC1_MPCBB2_PRIV14            \ [0x0e] PRIV14
    $0f constant GTZC1_MPCBB2_PRIV15            \ [0x0f] PRIV15
    $10 constant GTZC1_MPCBB2_PRIV16            \ [0x10] PRIV16
    $11 constant GTZC1_MPCBB2_PRIV17            \ [0x11] PRIV17
    $12 constant GTZC1_MPCBB2_PRIV18            \ [0x12] PRIV18
    $13 constant GTZC1_MPCBB2_PRIV19            \ [0x13] PRIV19
    $14 constant GTZC1_MPCBB2_PRIV20            \ [0x14] PRIV20
    $15 constant GTZC1_MPCBB2_PRIV21            \ [0x15] PRIV21
    $16 constant GTZC1_MPCBB2_PRIV22            \ [0x16] PRIV22
    $17 constant GTZC1_MPCBB2_PRIV23            \ [0x17] PRIV23
    $18 constant GTZC1_MPCBB2_PRIV24            \ [0x18] PRIV24
    $19 constant GTZC1_MPCBB2_PRIV25            \ [0x19] PRIV25
    $1a constant GTZC1_MPCBB2_PRIV26            \ [0x1a] PRIV26
    $1b constant GTZC1_MPCBB2_PRIV27            \ [0x1b] PRIV27
    $1c constant GTZC1_MPCBB2_PRIV28            \ [0x1c] PRIV28
    $1d constant GTZC1_MPCBB2_PRIV29            \ [0x1d] PRIV29
    $1e constant GTZC1_MPCBB2_PRIV30            \ [0x1e] PRIV30
    $1f constant GTZC1_MPCBB2_PRIV31            \ [0x1f] PRIV31
  [then]


  [ifdef] GTZC1_MPCBB2_MPCBB2_PRIVCFGR5_DEF
    \
    \ @brief MPCBB privileged configuration for super-block x register
    \ Address offset: 0x214
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GTZC1_MPCBB2_PRIV0             \ [0x00] PRIV0
    $01 constant GTZC1_MPCBB2_PRIV1             \ [0x01] PRIV1
    $02 constant GTZC1_MPCBB2_PRIV2             \ [0x02] PRIV2
    $03 constant GTZC1_MPCBB2_PRIV3             \ [0x03] PRIV3
    $04 constant GTZC1_MPCBB2_PRIV4             \ [0x04] PRIV4
    $05 constant GTZC1_MPCBB2_PRIV5             \ [0x05] PRIV5
    $06 constant GTZC1_MPCBB2_PRIV6             \ [0x06] PRIV6
    $07 constant GTZC1_MPCBB2_PRIV7             \ [0x07] PRIV7
    $08 constant GTZC1_MPCBB2_PRIV8             \ [0x08] PRIV8
    $09 constant GTZC1_MPCBB2_PRIV9             \ [0x09] PRIV9
    $0a constant GTZC1_MPCBB2_PRIV10            \ [0x0a] PRIV10
    $0b constant GTZC1_MPCBB2_PRIV11            \ [0x0b] PRIV11
    $0c constant GTZC1_MPCBB2_PRIV12            \ [0x0c] PRIV12
    $0d constant GTZC1_MPCBB2_PRIV13            \ [0x0d] PRIV13
    $0e constant GTZC1_MPCBB2_PRIV14            \ [0x0e] PRIV14
    $0f constant GTZC1_MPCBB2_PRIV15            \ [0x0f] PRIV15
    $10 constant GTZC1_MPCBB2_PRIV16            \ [0x10] PRIV16
    $11 constant GTZC1_MPCBB2_PRIV17            \ [0x11] PRIV17
    $12 constant GTZC1_MPCBB2_PRIV18            \ [0x12] PRIV18
    $13 constant GTZC1_MPCBB2_PRIV19            \ [0x13] PRIV19
    $14 constant GTZC1_MPCBB2_PRIV20            \ [0x14] PRIV20
    $15 constant GTZC1_MPCBB2_PRIV21            \ [0x15] PRIV21
    $16 constant GTZC1_MPCBB2_PRIV22            \ [0x16] PRIV22
    $17 constant GTZC1_MPCBB2_PRIV23            \ [0x17] PRIV23
    $18 constant GTZC1_MPCBB2_PRIV24            \ [0x18] PRIV24
    $19 constant GTZC1_MPCBB2_PRIV25            \ [0x19] PRIV25
    $1a constant GTZC1_MPCBB2_PRIV26            \ [0x1a] PRIV26
    $1b constant GTZC1_MPCBB2_PRIV27            \ [0x1b] PRIV27
    $1c constant GTZC1_MPCBB2_PRIV28            \ [0x1c] PRIV28
    $1d constant GTZC1_MPCBB2_PRIV29            \ [0x1d] PRIV29
    $1e constant GTZC1_MPCBB2_PRIV30            \ [0x1e] PRIV30
    $1f constant GTZC1_MPCBB2_PRIV31            \ [0x1f] PRIV31
  [then]


  [ifdef] GTZC1_MPCBB2_MPCBB2_PRIVCFGR6_DEF
    \
    \ @brief MPCBB privileged configuration for super-block x register
    \ Address offset: 0x218
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GTZC1_MPCBB2_PRIV0             \ [0x00] PRIV0
    $01 constant GTZC1_MPCBB2_PRIV1             \ [0x01] PRIV1
    $02 constant GTZC1_MPCBB2_PRIV2             \ [0x02] PRIV2
    $03 constant GTZC1_MPCBB2_PRIV3             \ [0x03] PRIV3
    $04 constant GTZC1_MPCBB2_PRIV4             \ [0x04] PRIV4
    $05 constant GTZC1_MPCBB2_PRIV5             \ [0x05] PRIV5
    $06 constant GTZC1_MPCBB2_PRIV6             \ [0x06] PRIV6
    $07 constant GTZC1_MPCBB2_PRIV7             \ [0x07] PRIV7
    $08 constant GTZC1_MPCBB2_PRIV8             \ [0x08] PRIV8
    $09 constant GTZC1_MPCBB2_PRIV9             \ [0x09] PRIV9
    $0a constant GTZC1_MPCBB2_PRIV10            \ [0x0a] PRIV10
    $0b constant GTZC1_MPCBB2_PRIV11            \ [0x0b] PRIV11
    $0c constant GTZC1_MPCBB2_PRIV12            \ [0x0c] PRIV12
    $0d constant GTZC1_MPCBB2_PRIV13            \ [0x0d] PRIV13
    $0e constant GTZC1_MPCBB2_PRIV14            \ [0x0e] PRIV14
    $0f constant GTZC1_MPCBB2_PRIV15            \ [0x0f] PRIV15
    $10 constant GTZC1_MPCBB2_PRIV16            \ [0x10] PRIV16
    $11 constant GTZC1_MPCBB2_PRIV17            \ [0x11] PRIV17
    $12 constant GTZC1_MPCBB2_PRIV18            \ [0x12] PRIV18
    $13 constant GTZC1_MPCBB2_PRIV19            \ [0x13] PRIV19
    $14 constant GTZC1_MPCBB2_PRIV20            \ [0x14] PRIV20
    $15 constant GTZC1_MPCBB2_PRIV21            \ [0x15] PRIV21
    $16 constant GTZC1_MPCBB2_PRIV22            \ [0x16] PRIV22
    $17 constant GTZC1_MPCBB2_PRIV23            \ [0x17] PRIV23
    $18 constant GTZC1_MPCBB2_PRIV24            \ [0x18] PRIV24
    $19 constant GTZC1_MPCBB2_PRIV25            \ [0x19] PRIV25
    $1a constant GTZC1_MPCBB2_PRIV26            \ [0x1a] PRIV26
    $1b constant GTZC1_MPCBB2_PRIV27            \ [0x1b] PRIV27
    $1c constant GTZC1_MPCBB2_PRIV28            \ [0x1c] PRIV28
    $1d constant GTZC1_MPCBB2_PRIV29            \ [0x1d] PRIV29
    $1e constant GTZC1_MPCBB2_PRIV30            \ [0x1e] PRIV30
    $1f constant GTZC1_MPCBB2_PRIV31            \ [0x1f] PRIV31
  [then]


  [ifdef] GTZC1_MPCBB2_MPCBB2_PRIVCFGR7_DEF
    \
    \ @brief MPCBB privileged configuration for super-block x register
    \ Address offset: 0x21C
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GTZC1_MPCBB2_PRIV0             \ [0x00] PRIV0
    $01 constant GTZC1_MPCBB2_PRIV1             \ [0x01] PRIV1
    $02 constant GTZC1_MPCBB2_PRIV2             \ [0x02] PRIV2
    $03 constant GTZC1_MPCBB2_PRIV3             \ [0x03] PRIV3
    $04 constant GTZC1_MPCBB2_PRIV4             \ [0x04] PRIV4
    $05 constant GTZC1_MPCBB2_PRIV5             \ [0x05] PRIV5
    $06 constant GTZC1_MPCBB2_PRIV6             \ [0x06] PRIV6
    $07 constant GTZC1_MPCBB2_PRIV7             \ [0x07] PRIV7
    $08 constant GTZC1_MPCBB2_PRIV8             \ [0x08] PRIV8
    $09 constant GTZC1_MPCBB2_PRIV9             \ [0x09] PRIV9
    $0a constant GTZC1_MPCBB2_PRIV10            \ [0x0a] PRIV10
    $0b constant GTZC1_MPCBB2_PRIV11            \ [0x0b] PRIV11
    $0c constant GTZC1_MPCBB2_PRIV12            \ [0x0c] PRIV12
    $0d constant GTZC1_MPCBB2_PRIV13            \ [0x0d] PRIV13
    $0e constant GTZC1_MPCBB2_PRIV14            \ [0x0e] PRIV14
    $0f constant GTZC1_MPCBB2_PRIV15            \ [0x0f] PRIV15
    $10 constant GTZC1_MPCBB2_PRIV16            \ [0x10] PRIV16
    $11 constant GTZC1_MPCBB2_PRIV17            \ [0x11] PRIV17
    $12 constant GTZC1_MPCBB2_PRIV18            \ [0x12] PRIV18
    $13 constant GTZC1_MPCBB2_PRIV19            \ [0x13] PRIV19
    $14 constant GTZC1_MPCBB2_PRIV20            \ [0x14] PRIV20
    $15 constant GTZC1_MPCBB2_PRIV21            \ [0x15] PRIV21
    $16 constant GTZC1_MPCBB2_PRIV22            \ [0x16] PRIV22
    $17 constant GTZC1_MPCBB2_PRIV23            \ [0x17] PRIV23
    $18 constant GTZC1_MPCBB2_PRIV24            \ [0x18] PRIV24
    $19 constant GTZC1_MPCBB2_PRIV25            \ [0x19] PRIV25
    $1a constant GTZC1_MPCBB2_PRIV26            \ [0x1a] PRIV26
    $1b constant GTZC1_MPCBB2_PRIV27            \ [0x1b] PRIV27
    $1c constant GTZC1_MPCBB2_PRIV28            \ [0x1c] PRIV28
    $1d constant GTZC1_MPCBB2_PRIV29            \ [0x1d] PRIV29
    $1e constant GTZC1_MPCBB2_PRIV30            \ [0x1e] PRIV30
    $1f constant GTZC1_MPCBB2_PRIV31            \ [0x1f] PRIV31
  [then]


  [ifdef] GTZC1_MPCBB2_MPCBB2_PRIVCFGR8_DEF
    \
    \ @brief MPCBB privileged configuration for super-block x register
    \ Address offset: 0x220
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GTZC1_MPCBB2_PRIV0             \ [0x00] PRIV0
    $01 constant GTZC1_MPCBB2_PRIV1             \ [0x01] PRIV1
    $02 constant GTZC1_MPCBB2_PRIV2             \ [0x02] PRIV2
    $03 constant GTZC1_MPCBB2_PRIV3             \ [0x03] PRIV3
    $04 constant GTZC1_MPCBB2_PRIV4             \ [0x04] PRIV4
    $05 constant GTZC1_MPCBB2_PRIV5             \ [0x05] PRIV5
    $06 constant GTZC1_MPCBB2_PRIV6             \ [0x06] PRIV6
    $07 constant GTZC1_MPCBB2_PRIV7             \ [0x07] PRIV7
    $08 constant GTZC1_MPCBB2_PRIV8             \ [0x08] PRIV8
    $09 constant GTZC1_MPCBB2_PRIV9             \ [0x09] PRIV9
    $0a constant GTZC1_MPCBB2_PRIV10            \ [0x0a] PRIV10
    $0b constant GTZC1_MPCBB2_PRIV11            \ [0x0b] PRIV11
    $0c constant GTZC1_MPCBB2_PRIV12            \ [0x0c] PRIV12
    $0d constant GTZC1_MPCBB2_PRIV13            \ [0x0d] PRIV13
    $0e constant GTZC1_MPCBB2_PRIV14            \ [0x0e] PRIV14
    $0f constant GTZC1_MPCBB2_PRIV15            \ [0x0f] PRIV15
    $10 constant GTZC1_MPCBB2_PRIV16            \ [0x10] PRIV16
    $11 constant GTZC1_MPCBB2_PRIV17            \ [0x11] PRIV17
    $12 constant GTZC1_MPCBB2_PRIV18            \ [0x12] PRIV18
    $13 constant GTZC1_MPCBB2_PRIV19            \ [0x13] PRIV19
    $14 constant GTZC1_MPCBB2_PRIV20            \ [0x14] PRIV20
    $15 constant GTZC1_MPCBB2_PRIV21            \ [0x15] PRIV21
    $16 constant GTZC1_MPCBB2_PRIV22            \ [0x16] PRIV22
    $17 constant GTZC1_MPCBB2_PRIV23            \ [0x17] PRIV23
    $18 constant GTZC1_MPCBB2_PRIV24            \ [0x18] PRIV24
    $19 constant GTZC1_MPCBB2_PRIV25            \ [0x19] PRIV25
    $1a constant GTZC1_MPCBB2_PRIV26            \ [0x1a] PRIV26
    $1b constant GTZC1_MPCBB2_PRIV27            \ [0x1b] PRIV27
    $1c constant GTZC1_MPCBB2_PRIV28            \ [0x1c] PRIV28
    $1d constant GTZC1_MPCBB2_PRIV29            \ [0x1d] PRIV29
    $1e constant GTZC1_MPCBB2_PRIV30            \ [0x1e] PRIV30
    $1f constant GTZC1_MPCBB2_PRIV31            \ [0x1f] PRIV31
  [then]


  [ifdef] GTZC1_MPCBB2_MPCBB2_PRIVCFGR9_DEF
    \
    \ @brief MPCBB privileged configuration for super-block x register
    \ Address offset: 0x224
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GTZC1_MPCBB2_PRIV0             \ [0x00] PRIV0
    $01 constant GTZC1_MPCBB2_PRIV1             \ [0x01] PRIV1
    $02 constant GTZC1_MPCBB2_PRIV2             \ [0x02] PRIV2
    $03 constant GTZC1_MPCBB2_PRIV3             \ [0x03] PRIV3
    $04 constant GTZC1_MPCBB2_PRIV4             \ [0x04] PRIV4
    $05 constant GTZC1_MPCBB2_PRIV5             \ [0x05] PRIV5
    $06 constant GTZC1_MPCBB2_PRIV6             \ [0x06] PRIV6
    $07 constant GTZC1_MPCBB2_PRIV7             \ [0x07] PRIV7
    $08 constant GTZC1_MPCBB2_PRIV8             \ [0x08] PRIV8
    $09 constant GTZC1_MPCBB2_PRIV9             \ [0x09] PRIV9
    $0a constant GTZC1_MPCBB2_PRIV10            \ [0x0a] PRIV10
    $0b constant GTZC1_MPCBB2_PRIV11            \ [0x0b] PRIV11
    $0c constant GTZC1_MPCBB2_PRIV12            \ [0x0c] PRIV12
    $0d constant GTZC1_MPCBB2_PRIV13            \ [0x0d] PRIV13
    $0e constant GTZC1_MPCBB2_PRIV14            \ [0x0e] PRIV14
    $0f constant GTZC1_MPCBB2_PRIV15            \ [0x0f] PRIV15
    $10 constant GTZC1_MPCBB2_PRIV16            \ [0x10] PRIV16
    $11 constant GTZC1_MPCBB2_PRIV17            \ [0x11] PRIV17
    $12 constant GTZC1_MPCBB2_PRIV18            \ [0x12] PRIV18
    $13 constant GTZC1_MPCBB2_PRIV19            \ [0x13] PRIV19
    $14 constant GTZC1_MPCBB2_PRIV20            \ [0x14] PRIV20
    $15 constant GTZC1_MPCBB2_PRIV21            \ [0x15] PRIV21
    $16 constant GTZC1_MPCBB2_PRIV22            \ [0x16] PRIV22
    $17 constant GTZC1_MPCBB2_PRIV23            \ [0x17] PRIV23
    $18 constant GTZC1_MPCBB2_PRIV24            \ [0x18] PRIV24
    $19 constant GTZC1_MPCBB2_PRIV25            \ [0x19] PRIV25
    $1a constant GTZC1_MPCBB2_PRIV26            \ [0x1a] PRIV26
    $1b constant GTZC1_MPCBB2_PRIV27            \ [0x1b] PRIV27
    $1c constant GTZC1_MPCBB2_PRIV28            \ [0x1c] PRIV28
    $1d constant GTZC1_MPCBB2_PRIV29            \ [0x1d] PRIV29
    $1e constant GTZC1_MPCBB2_PRIV30            \ [0x1e] PRIV30
    $1f constant GTZC1_MPCBB2_PRIV31            \ [0x1f] PRIV31
  [then]


  [ifdef] GTZC1_MPCBB2_MPCBB2_PRIVCFGR10_DEF
    \
    \ @brief MPCBB privileged configuration for super-block x register
    \ Address offset: 0x228
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GTZC1_MPCBB2_PRIV0             \ [0x00] PRIV0
    $01 constant GTZC1_MPCBB2_PRIV1             \ [0x01] PRIV1
    $02 constant GTZC1_MPCBB2_PRIV2             \ [0x02] PRIV2
    $03 constant GTZC1_MPCBB2_PRIV3             \ [0x03] PRIV3
    $04 constant GTZC1_MPCBB2_PRIV4             \ [0x04] PRIV4
    $05 constant GTZC1_MPCBB2_PRIV5             \ [0x05] PRIV5
    $06 constant GTZC1_MPCBB2_PRIV6             \ [0x06] PRIV6
    $07 constant GTZC1_MPCBB2_PRIV7             \ [0x07] PRIV7
    $08 constant GTZC1_MPCBB2_PRIV8             \ [0x08] PRIV8
    $09 constant GTZC1_MPCBB2_PRIV9             \ [0x09] PRIV9
    $0a constant GTZC1_MPCBB2_PRIV10            \ [0x0a] PRIV10
    $0b constant GTZC1_MPCBB2_PRIV11            \ [0x0b] PRIV11
    $0c constant GTZC1_MPCBB2_PRIV12            \ [0x0c] PRIV12
    $0d constant GTZC1_MPCBB2_PRIV13            \ [0x0d] PRIV13
    $0e constant GTZC1_MPCBB2_PRIV14            \ [0x0e] PRIV14
    $0f constant GTZC1_MPCBB2_PRIV15            \ [0x0f] PRIV15
    $10 constant GTZC1_MPCBB2_PRIV16            \ [0x10] PRIV16
    $11 constant GTZC1_MPCBB2_PRIV17            \ [0x11] PRIV17
    $12 constant GTZC1_MPCBB2_PRIV18            \ [0x12] PRIV18
    $13 constant GTZC1_MPCBB2_PRIV19            \ [0x13] PRIV19
    $14 constant GTZC1_MPCBB2_PRIV20            \ [0x14] PRIV20
    $15 constant GTZC1_MPCBB2_PRIV21            \ [0x15] PRIV21
    $16 constant GTZC1_MPCBB2_PRIV22            \ [0x16] PRIV22
    $17 constant GTZC1_MPCBB2_PRIV23            \ [0x17] PRIV23
    $18 constant GTZC1_MPCBB2_PRIV24            \ [0x18] PRIV24
    $19 constant GTZC1_MPCBB2_PRIV25            \ [0x19] PRIV25
    $1a constant GTZC1_MPCBB2_PRIV26            \ [0x1a] PRIV26
    $1b constant GTZC1_MPCBB2_PRIV27            \ [0x1b] PRIV27
    $1c constant GTZC1_MPCBB2_PRIV28            \ [0x1c] PRIV28
    $1d constant GTZC1_MPCBB2_PRIV29            \ [0x1d] PRIV29
    $1e constant GTZC1_MPCBB2_PRIV30            \ [0x1e] PRIV30
    $1f constant GTZC1_MPCBB2_PRIV31            \ [0x1f] PRIV31
  [then]


  [ifdef] GTZC1_MPCBB2_MPCBB2_PRIVCFGR11_DEF
    \
    \ @brief MPCBB privileged configuration for super-block x register
    \ Address offset: 0x22C
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GTZC1_MPCBB2_PRIV0             \ [0x00] PRIV0
    $01 constant GTZC1_MPCBB2_PRIV1             \ [0x01] PRIV1
    $02 constant GTZC1_MPCBB2_PRIV2             \ [0x02] PRIV2
    $03 constant GTZC1_MPCBB2_PRIV3             \ [0x03] PRIV3
    $04 constant GTZC1_MPCBB2_PRIV4             \ [0x04] PRIV4
    $05 constant GTZC1_MPCBB2_PRIV5             \ [0x05] PRIV5
    $06 constant GTZC1_MPCBB2_PRIV6             \ [0x06] PRIV6
    $07 constant GTZC1_MPCBB2_PRIV7             \ [0x07] PRIV7
    $08 constant GTZC1_MPCBB2_PRIV8             \ [0x08] PRIV8
    $09 constant GTZC1_MPCBB2_PRIV9             \ [0x09] PRIV9
    $0a constant GTZC1_MPCBB2_PRIV10            \ [0x0a] PRIV10
    $0b constant GTZC1_MPCBB2_PRIV11            \ [0x0b] PRIV11
    $0c constant GTZC1_MPCBB2_PRIV12            \ [0x0c] PRIV12
    $0d constant GTZC1_MPCBB2_PRIV13            \ [0x0d] PRIV13
    $0e constant GTZC1_MPCBB2_PRIV14            \ [0x0e] PRIV14
    $0f constant GTZC1_MPCBB2_PRIV15            \ [0x0f] PRIV15
    $10 constant GTZC1_MPCBB2_PRIV16            \ [0x10] PRIV16
    $11 constant GTZC1_MPCBB2_PRIV17            \ [0x11] PRIV17
    $12 constant GTZC1_MPCBB2_PRIV18            \ [0x12] PRIV18
    $13 constant GTZC1_MPCBB2_PRIV19            \ [0x13] PRIV19
    $14 constant GTZC1_MPCBB2_PRIV20            \ [0x14] PRIV20
    $15 constant GTZC1_MPCBB2_PRIV21            \ [0x15] PRIV21
    $16 constant GTZC1_MPCBB2_PRIV22            \ [0x16] PRIV22
    $17 constant GTZC1_MPCBB2_PRIV23            \ [0x17] PRIV23
    $18 constant GTZC1_MPCBB2_PRIV24            \ [0x18] PRIV24
    $19 constant GTZC1_MPCBB2_PRIV25            \ [0x19] PRIV25
    $1a constant GTZC1_MPCBB2_PRIV26            \ [0x1a] PRIV26
    $1b constant GTZC1_MPCBB2_PRIV27            \ [0x1b] PRIV27
    $1c constant GTZC1_MPCBB2_PRIV28            \ [0x1c] PRIV28
    $1d constant GTZC1_MPCBB2_PRIV29            \ [0x1d] PRIV29
    $1e constant GTZC1_MPCBB2_PRIV30            \ [0x1e] PRIV30
    $1f constant GTZC1_MPCBB2_PRIV31            \ [0x1f] PRIV31
  [then]


  [ifdef] GTZC1_MPCBB2_MPCBB2_PRIVCFGR12_DEF
    \
    \ @brief MPCBB privileged configuration for super-block x register
    \ Address offset: 0x230
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GTZC1_MPCBB2_PRIV0             \ [0x00] PRIV0
    $01 constant GTZC1_MPCBB2_PRIV1             \ [0x01] PRIV1
    $02 constant GTZC1_MPCBB2_PRIV2             \ [0x02] PRIV2
    $03 constant GTZC1_MPCBB2_PRIV3             \ [0x03] PRIV3
    $04 constant GTZC1_MPCBB2_PRIV4             \ [0x04] PRIV4
    $05 constant GTZC1_MPCBB2_PRIV5             \ [0x05] PRIV5
    $06 constant GTZC1_MPCBB2_PRIV6             \ [0x06] PRIV6
    $07 constant GTZC1_MPCBB2_PRIV7             \ [0x07] PRIV7
    $08 constant GTZC1_MPCBB2_PRIV8             \ [0x08] PRIV8
    $09 constant GTZC1_MPCBB2_PRIV9             \ [0x09] PRIV9
    $0a constant GTZC1_MPCBB2_PRIV10            \ [0x0a] PRIV10
    $0b constant GTZC1_MPCBB2_PRIV11            \ [0x0b] PRIV11
    $0c constant GTZC1_MPCBB2_PRIV12            \ [0x0c] PRIV12
    $0d constant GTZC1_MPCBB2_PRIV13            \ [0x0d] PRIV13
    $0e constant GTZC1_MPCBB2_PRIV14            \ [0x0e] PRIV14
    $0f constant GTZC1_MPCBB2_PRIV15            \ [0x0f] PRIV15
    $10 constant GTZC1_MPCBB2_PRIV16            \ [0x10] PRIV16
    $11 constant GTZC1_MPCBB2_PRIV17            \ [0x11] PRIV17
    $12 constant GTZC1_MPCBB2_PRIV18            \ [0x12] PRIV18
    $13 constant GTZC1_MPCBB2_PRIV19            \ [0x13] PRIV19
    $14 constant GTZC1_MPCBB2_PRIV20            \ [0x14] PRIV20
    $15 constant GTZC1_MPCBB2_PRIV21            \ [0x15] PRIV21
    $16 constant GTZC1_MPCBB2_PRIV22            \ [0x16] PRIV22
    $17 constant GTZC1_MPCBB2_PRIV23            \ [0x17] PRIV23
    $18 constant GTZC1_MPCBB2_PRIV24            \ [0x18] PRIV24
    $19 constant GTZC1_MPCBB2_PRIV25            \ [0x19] PRIV25
    $1a constant GTZC1_MPCBB2_PRIV26            \ [0x1a] PRIV26
    $1b constant GTZC1_MPCBB2_PRIV27            \ [0x1b] PRIV27
    $1c constant GTZC1_MPCBB2_PRIV28            \ [0x1c] PRIV28
    $1d constant GTZC1_MPCBB2_PRIV29            \ [0x1d] PRIV29
    $1e constant GTZC1_MPCBB2_PRIV30            \ [0x1e] PRIV30
    $1f constant GTZC1_MPCBB2_PRIV31            \ [0x1f] PRIV31
  [then]


  [ifdef] GTZC1_MPCBB2_MPCBB2_PRIVCFGR13_DEF
    \
    \ @brief MPCBB privileged configuration for super-block x register
    \ Address offset: 0x234
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GTZC1_MPCBB2_PRIV0             \ [0x00] PRIV0
    $01 constant GTZC1_MPCBB2_PRIV1             \ [0x01] PRIV1
    $02 constant GTZC1_MPCBB2_PRIV2             \ [0x02] PRIV2
    $03 constant GTZC1_MPCBB2_PRIV3             \ [0x03] PRIV3
    $04 constant GTZC1_MPCBB2_PRIV4             \ [0x04] PRIV4
    $05 constant GTZC1_MPCBB2_PRIV5             \ [0x05] PRIV5
    $06 constant GTZC1_MPCBB2_PRIV6             \ [0x06] PRIV6
    $07 constant GTZC1_MPCBB2_PRIV7             \ [0x07] PRIV7
    $08 constant GTZC1_MPCBB2_PRIV8             \ [0x08] PRIV8
    $09 constant GTZC1_MPCBB2_PRIV9             \ [0x09] PRIV9
    $0a constant GTZC1_MPCBB2_PRIV10            \ [0x0a] PRIV10
    $0b constant GTZC1_MPCBB2_PRIV11            \ [0x0b] PRIV11
    $0c constant GTZC1_MPCBB2_PRIV12            \ [0x0c] PRIV12
    $0d constant GTZC1_MPCBB2_PRIV13            \ [0x0d] PRIV13
    $0e constant GTZC1_MPCBB2_PRIV14            \ [0x0e] PRIV14
    $0f constant GTZC1_MPCBB2_PRIV15            \ [0x0f] PRIV15
    $10 constant GTZC1_MPCBB2_PRIV16            \ [0x10] PRIV16
    $11 constant GTZC1_MPCBB2_PRIV17            \ [0x11] PRIV17
    $12 constant GTZC1_MPCBB2_PRIV18            \ [0x12] PRIV18
    $13 constant GTZC1_MPCBB2_PRIV19            \ [0x13] PRIV19
    $14 constant GTZC1_MPCBB2_PRIV20            \ [0x14] PRIV20
    $15 constant GTZC1_MPCBB2_PRIV21            \ [0x15] PRIV21
    $16 constant GTZC1_MPCBB2_PRIV22            \ [0x16] PRIV22
    $17 constant GTZC1_MPCBB2_PRIV23            \ [0x17] PRIV23
    $18 constant GTZC1_MPCBB2_PRIV24            \ [0x18] PRIV24
    $19 constant GTZC1_MPCBB2_PRIV25            \ [0x19] PRIV25
    $1a constant GTZC1_MPCBB2_PRIV26            \ [0x1a] PRIV26
    $1b constant GTZC1_MPCBB2_PRIV27            \ [0x1b] PRIV27
    $1c constant GTZC1_MPCBB2_PRIV28            \ [0x1c] PRIV28
    $1d constant GTZC1_MPCBB2_PRIV29            \ [0x1d] PRIV29
    $1e constant GTZC1_MPCBB2_PRIV30            \ [0x1e] PRIV30
    $1f constant GTZC1_MPCBB2_PRIV31            \ [0x1f] PRIV31
  [then]


  [ifdef] GTZC1_MPCBB2_MPCBB2_PRIVCFGR14_DEF
    \
    \ @brief MPCBB privileged configuration for super-block x register
    \ Address offset: 0x238
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GTZC1_MPCBB2_PRIV0             \ [0x00] PRIV0
    $01 constant GTZC1_MPCBB2_PRIV1             \ [0x01] PRIV1
    $02 constant GTZC1_MPCBB2_PRIV2             \ [0x02] PRIV2
    $03 constant GTZC1_MPCBB2_PRIV3             \ [0x03] PRIV3
    $04 constant GTZC1_MPCBB2_PRIV4             \ [0x04] PRIV4
    $05 constant GTZC1_MPCBB2_PRIV5             \ [0x05] PRIV5
    $06 constant GTZC1_MPCBB2_PRIV6             \ [0x06] PRIV6
    $07 constant GTZC1_MPCBB2_PRIV7             \ [0x07] PRIV7
    $08 constant GTZC1_MPCBB2_PRIV8             \ [0x08] PRIV8
    $09 constant GTZC1_MPCBB2_PRIV9             \ [0x09] PRIV9
    $0a constant GTZC1_MPCBB2_PRIV10            \ [0x0a] PRIV10
    $0b constant GTZC1_MPCBB2_PRIV11            \ [0x0b] PRIV11
    $0c constant GTZC1_MPCBB2_PRIV12            \ [0x0c] PRIV12
    $0d constant GTZC1_MPCBB2_PRIV13            \ [0x0d] PRIV13
    $0e constant GTZC1_MPCBB2_PRIV14            \ [0x0e] PRIV14
    $0f constant GTZC1_MPCBB2_PRIV15            \ [0x0f] PRIV15
    $10 constant GTZC1_MPCBB2_PRIV16            \ [0x10] PRIV16
    $11 constant GTZC1_MPCBB2_PRIV17            \ [0x11] PRIV17
    $12 constant GTZC1_MPCBB2_PRIV18            \ [0x12] PRIV18
    $13 constant GTZC1_MPCBB2_PRIV19            \ [0x13] PRIV19
    $14 constant GTZC1_MPCBB2_PRIV20            \ [0x14] PRIV20
    $15 constant GTZC1_MPCBB2_PRIV21            \ [0x15] PRIV21
    $16 constant GTZC1_MPCBB2_PRIV22            \ [0x16] PRIV22
    $17 constant GTZC1_MPCBB2_PRIV23            \ [0x17] PRIV23
    $18 constant GTZC1_MPCBB2_PRIV24            \ [0x18] PRIV24
    $19 constant GTZC1_MPCBB2_PRIV25            \ [0x19] PRIV25
    $1a constant GTZC1_MPCBB2_PRIV26            \ [0x1a] PRIV26
    $1b constant GTZC1_MPCBB2_PRIV27            \ [0x1b] PRIV27
    $1c constant GTZC1_MPCBB2_PRIV28            \ [0x1c] PRIV28
    $1d constant GTZC1_MPCBB2_PRIV29            \ [0x1d] PRIV29
    $1e constant GTZC1_MPCBB2_PRIV30            \ [0x1e] PRIV30
    $1f constant GTZC1_MPCBB2_PRIV31            \ [0x1f] PRIV31
  [then]


  [ifdef] GTZC1_MPCBB2_MPCBB2_PRIVCFGR15_DEF
    \
    \ @brief MPCBB privileged configuration for super-block x register
    \ Address offset: 0x23C
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GTZC1_MPCBB2_PRIV0             \ [0x00] PRIV0
    $01 constant GTZC1_MPCBB2_PRIV1             \ [0x01] PRIV1
    $02 constant GTZC1_MPCBB2_PRIV2             \ [0x02] PRIV2
    $03 constant GTZC1_MPCBB2_PRIV3             \ [0x03] PRIV3
    $04 constant GTZC1_MPCBB2_PRIV4             \ [0x04] PRIV4
    $05 constant GTZC1_MPCBB2_PRIV5             \ [0x05] PRIV5
    $06 constant GTZC1_MPCBB2_PRIV6             \ [0x06] PRIV6
    $07 constant GTZC1_MPCBB2_PRIV7             \ [0x07] PRIV7
    $08 constant GTZC1_MPCBB2_PRIV8             \ [0x08] PRIV8
    $09 constant GTZC1_MPCBB2_PRIV9             \ [0x09] PRIV9
    $0a constant GTZC1_MPCBB2_PRIV10            \ [0x0a] PRIV10
    $0b constant GTZC1_MPCBB2_PRIV11            \ [0x0b] PRIV11
    $0c constant GTZC1_MPCBB2_PRIV12            \ [0x0c] PRIV12
    $0d constant GTZC1_MPCBB2_PRIV13            \ [0x0d] PRIV13
    $0e constant GTZC1_MPCBB2_PRIV14            \ [0x0e] PRIV14
    $0f constant GTZC1_MPCBB2_PRIV15            \ [0x0f] PRIV15
    $10 constant GTZC1_MPCBB2_PRIV16            \ [0x10] PRIV16
    $11 constant GTZC1_MPCBB2_PRIV17            \ [0x11] PRIV17
    $12 constant GTZC1_MPCBB2_PRIV18            \ [0x12] PRIV18
    $13 constant GTZC1_MPCBB2_PRIV19            \ [0x13] PRIV19
    $14 constant GTZC1_MPCBB2_PRIV20            \ [0x14] PRIV20
    $15 constant GTZC1_MPCBB2_PRIV21            \ [0x15] PRIV21
    $16 constant GTZC1_MPCBB2_PRIV22            \ [0x16] PRIV22
    $17 constant GTZC1_MPCBB2_PRIV23            \ [0x17] PRIV23
    $18 constant GTZC1_MPCBB2_PRIV24            \ [0x18] PRIV24
    $19 constant GTZC1_MPCBB2_PRIV25            \ [0x19] PRIV25
    $1a constant GTZC1_MPCBB2_PRIV26            \ [0x1a] PRIV26
    $1b constant GTZC1_MPCBB2_PRIV27            \ [0x1b] PRIV27
    $1c constant GTZC1_MPCBB2_PRIV28            \ [0x1c] PRIV28
    $1d constant GTZC1_MPCBB2_PRIV29            \ [0x1d] PRIV29
    $1e constant GTZC1_MPCBB2_PRIV30            \ [0x1e] PRIV30
    $1f constant GTZC1_MPCBB2_PRIV31            \ [0x1f] PRIV31
  [then]


  [ifdef] GTZC1_MPCBB2_MPCBB2_PRIVCFGR16_DEF
    \
    \ @brief MPCBB privileged configuration for super-block x register
    \ Address offset: 0x240
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GTZC1_MPCBB2_PRIV0             \ [0x00] PRIV0
    $01 constant GTZC1_MPCBB2_PRIV1             \ [0x01] PRIV1
    $02 constant GTZC1_MPCBB2_PRIV2             \ [0x02] PRIV2
    $03 constant GTZC1_MPCBB2_PRIV3             \ [0x03] PRIV3
    $04 constant GTZC1_MPCBB2_PRIV4             \ [0x04] PRIV4
    $05 constant GTZC1_MPCBB2_PRIV5             \ [0x05] PRIV5
    $06 constant GTZC1_MPCBB2_PRIV6             \ [0x06] PRIV6
    $07 constant GTZC1_MPCBB2_PRIV7             \ [0x07] PRIV7
    $08 constant GTZC1_MPCBB2_PRIV8             \ [0x08] PRIV8
    $09 constant GTZC1_MPCBB2_PRIV9             \ [0x09] PRIV9
    $0a constant GTZC1_MPCBB2_PRIV10            \ [0x0a] PRIV10
    $0b constant GTZC1_MPCBB2_PRIV11            \ [0x0b] PRIV11
    $0c constant GTZC1_MPCBB2_PRIV12            \ [0x0c] PRIV12
    $0d constant GTZC1_MPCBB2_PRIV13            \ [0x0d] PRIV13
    $0e constant GTZC1_MPCBB2_PRIV14            \ [0x0e] PRIV14
    $0f constant GTZC1_MPCBB2_PRIV15            \ [0x0f] PRIV15
    $10 constant GTZC1_MPCBB2_PRIV16            \ [0x10] PRIV16
    $11 constant GTZC1_MPCBB2_PRIV17            \ [0x11] PRIV17
    $12 constant GTZC1_MPCBB2_PRIV18            \ [0x12] PRIV18
    $13 constant GTZC1_MPCBB2_PRIV19            \ [0x13] PRIV19
    $14 constant GTZC1_MPCBB2_PRIV20            \ [0x14] PRIV20
    $15 constant GTZC1_MPCBB2_PRIV21            \ [0x15] PRIV21
    $16 constant GTZC1_MPCBB2_PRIV22            \ [0x16] PRIV22
    $17 constant GTZC1_MPCBB2_PRIV23            \ [0x17] PRIV23
    $18 constant GTZC1_MPCBB2_PRIV24            \ [0x18] PRIV24
    $19 constant GTZC1_MPCBB2_PRIV25            \ [0x19] PRIV25
    $1a constant GTZC1_MPCBB2_PRIV26            \ [0x1a] PRIV26
    $1b constant GTZC1_MPCBB2_PRIV27            \ [0x1b] PRIV27
    $1c constant GTZC1_MPCBB2_PRIV28            \ [0x1c] PRIV28
    $1d constant GTZC1_MPCBB2_PRIV29            \ [0x1d] PRIV29
    $1e constant GTZC1_MPCBB2_PRIV30            \ [0x1e] PRIV30
    $1f constant GTZC1_MPCBB2_PRIV31            \ [0x1f] PRIV31
  [then]


  [ifdef] GTZC1_MPCBB2_MPCBB2_PRIVCFGR17_DEF
    \
    \ @brief MPCBB privileged configuration for super-block x register
    \ Address offset: 0x244
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GTZC1_MPCBB2_PRIV0             \ [0x00] PRIV0
    $01 constant GTZC1_MPCBB2_PRIV1             \ [0x01] PRIV1
    $02 constant GTZC1_MPCBB2_PRIV2             \ [0x02] PRIV2
    $03 constant GTZC1_MPCBB2_PRIV3             \ [0x03] PRIV3
    $04 constant GTZC1_MPCBB2_PRIV4             \ [0x04] PRIV4
    $05 constant GTZC1_MPCBB2_PRIV5             \ [0x05] PRIV5
    $06 constant GTZC1_MPCBB2_PRIV6             \ [0x06] PRIV6
    $07 constant GTZC1_MPCBB2_PRIV7             \ [0x07] PRIV7
    $08 constant GTZC1_MPCBB2_PRIV8             \ [0x08] PRIV8
    $09 constant GTZC1_MPCBB2_PRIV9             \ [0x09] PRIV9
    $0a constant GTZC1_MPCBB2_PRIV10            \ [0x0a] PRIV10
    $0b constant GTZC1_MPCBB2_PRIV11            \ [0x0b] PRIV11
    $0c constant GTZC1_MPCBB2_PRIV12            \ [0x0c] PRIV12
    $0d constant GTZC1_MPCBB2_PRIV13            \ [0x0d] PRIV13
    $0e constant GTZC1_MPCBB2_PRIV14            \ [0x0e] PRIV14
    $0f constant GTZC1_MPCBB2_PRIV15            \ [0x0f] PRIV15
    $10 constant GTZC1_MPCBB2_PRIV16            \ [0x10] PRIV16
    $11 constant GTZC1_MPCBB2_PRIV17            \ [0x11] PRIV17
    $12 constant GTZC1_MPCBB2_PRIV18            \ [0x12] PRIV18
    $13 constant GTZC1_MPCBB2_PRIV19            \ [0x13] PRIV19
    $14 constant GTZC1_MPCBB2_PRIV20            \ [0x14] PRIV20
    $15 constant GTZC1_MPCBB2_PRIV21            \ [0x15] PRIV21
    $16 constant GTZC1_MPCBB2_PRIV22            \ [0x16] PRIV22
    $17 constant GTZC1_MPCBB2_PRIV23            \ [0x17] PRIV23
    $18 constant GTZC1_MPCBB2_PRIV24            \ [0x18] PRIV24
    $19 constant GTZC1_MPCBB2_PRIV25            \ [0x19] PRIV25
    $1a constant GTZC1_MPCBB2_PRIV26            \ [0x1a] PRIV26
    $1b constant GTZC1_MPCBB2_PRIV27            \ [0x1b] PRIV27
    $1c constant GTZC1_MPCBB2_PRIV28            \ [0x1c] PRIV28
    $1d constant GTZC1_MPCBB2_PRIV29            \ [0x1d] PRIV29
    $1e constant GTZC1_MPCBB2_PRIV30            \ [0x1e] PRIV30
    $1f constant GTZC1_MPCBB2_PRIV31            \ [0x1f] PRIV31
  [then]


  [ifdef] GTZC1_MPCBB2_MPCBB2_PRIVCFGR18_DEF
    \
    \ @brief MPCBB privileged configuration for super-block x register
    \ Address offset: 0x248
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GTZC1_MPCBB2_PRIV0             \ [0x00] PRIV0
    $01 constant GTZC1_MPCBB2_PRIV1             \ [0x01] PRIV1
    $02 constant GTZC1_MPCBB2_PRIV2             \ [0x02] PRIV2
    $03 constant GTZC1_MPCBB2_PRIV3             \ [0x03] PRIV3
    $04 constant GTZC1_MPCBB2_PRIV4             \ [0x04] PRIV4
    $05 constant GTZC1_MPCBB2_PRIV5             \ [0x05] PRIV5
    $06 constant GTZC1_MPCBB2_PRIV6             \ [0x06] PRIV6
    $07 constant GTZC1_MPCBB2_PRIV7             \ [0x07] PRIV7
    $08 constant GTZC1_MPCBB2_PRIV8             \ [0x08] PRIV8
    $09 constant GTZC1_MPCBB2_PRIV9             \ [0x09] PRIV9
    $0a constant GTZC1_MPCBB2_PRIV10            \ [0x0a] PRIV10
    $0b constant GTZC1_MPCBB2_PRIV11            \ [0x0b] PRIV11
    $0c constant GTZC1_MPCBB2_PRIV12            \ [0x0c] PRIV12
    $0d constant GTZC1_MPCBB2_PRIV13            \ [0x0d] PRIV13
    $0e constant GTZC1_MPCBB2_PRIV14            \ [0x0e] PRIV14
    $0f constant GTZC1_MPCBB2_PRIV15            \ [0x0f] PRIV15
    $10 constant GTZC1_MPCBB2_PRIV16            \ [0x10] PRIV16
    $11 constant GTZC1_MPCBB2_PRIV17            \ [0x11] PRIV17
    $12 constant GTZC1_MPCBB2_PRIV18            \ [0x12] PRIV18
    $13 constant GTZC1_MPCBB2_PRIV19            \ [0x13] PRIV19
    $14 constant GTZC1_MPCBB2_PRIV20            \ [0x14] PRIV20
    $15 constant GTZC1_MPCBB2_PRIV21            \ [0x15] PRIV21
    $16 constant GTZC1_MPCBB2_PRIV22            \ [0x16] PRIV22
    $17 constant GTZC1_MPCBB2_PRIV23            \ [0x17] PRIV23
    $18 constant GTZC1_MPCBB2_PRIV24            \ [0x18] PRIV24
    $19 constant GTZC1_MPCBB2_PRIV25            \ [0x19] PRIV25
    $1a constant GTZC1_MPCBB2_PRIV26            \ [0x1a] PRIV26
    $1b constant GTZC1_MPCBB2_PRIV27            \ [0x1b] PRIV27
    $1c constant GTZC1_MPCBB2_PRIV28            \ [0x1c] PRIV28
    $1d constant GTZC1_MPCBB2_PRIV29            \ [0x1d] PRIV29
    $1e constant GTZC1_MPCBB2_PRIV30            \ [0x1e] PRIV30
    $1f constant GTZC1_MPCBB2_PRIV31            \ [0x1f] PRIV31
  [then]


  [ifdef] GTZC1_MPCBB2_MPCBB2_PRIVCFGR19_DEF
    \
    \ @brief MPCBB privileged configuration for super-block x register
    \ Address offset: 0x24C
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GTZC1_MPCBB2_PRIV0             \ [0x00] PRIV0
    $01 constant GTZC1_MPCBB2_PRIV1             \ [0x01] PRIV1
    $02 constant GTZC1_MPCBB2_PRIV2             \ [0x02] PRIV2
    $03 constant GTZC1_MPCBB2_PRIV3             \ [0x03] PRIV3
    $04 constant GTZC1_MPCBB2_PRIV4             \ [0x04] PRIV4
    $05 constant GTZC1_MPCBB2_PRIV5             \ [0x05] PRIV5
    $06 constant GTZC1_MPCBB2_PRIV6             \ [0x06] PRIV6
    $07 constant GTZC1_MPCBB2_PRIV7             \ [0x07] PRIV7
    $08 constant GTZC1_MPCBB2_PRIV8             \ [0x08] PRIV8
    $09 constant GTZC1_MPCBB2_PRIV9             \ [0x09] PRIV9
    $0a constant GTZC1_MPCBB2_PRIV10            \ [0x0a] PRIV10
    $0b constant GTZC1_MPCBB2_PRIV11            \ [0x0b] PRIV11
    $0c constant GTZC1_MPCBB2_PRIV12            \ [0x0c] PRIV12
    $0d constant GTZC1_MPCBB2_PRIV13            \ [0x0d] PRIV13
    $0e constant GTZC1_MPCBB2_PRIV14            \ [0x0e] PRIV14
    $0f constant GTZC1_MPCBB2_PRIV15            \ [0x0f] PRIV15
    $10 constant GTZC1_MPCBB2_PRIV16            \ [0x10] PRIV16
    $11 constant GTZC1_MPCBB2_PRIV17            \ [0x11] PRIV17
    $12 constant GTZC1_MPCBB2_PRIV18            \ [0x12] PRIV18
    $13 constant GTZC1_MPCBB2_PRIV19            \ [0x13] PRIV19
    $14 constant GTZC1_MPCBB2_PRIV20            \ [0x14] PRIV20
    $15 constant GTZC1_MPCBB2_PRIV21            \ [0x15] PRIV21
    $16 constant GTZC1_MPCBB2_PRIV22            \ [0x16] PRIV22
    $17 constant GTZC1_MPCBB2_PRIV23            \ [0x17] PRIV23
    $18 constant GTZC1_MPCBB2_PRIV24            \ [0x18] PRIV24
    $19 constant GTZC1_MPCBB2_PRIV25            \ [0x19] PRIV25
    $1a constant GTZC1_MPCBB2_PRIV26            \ [0x1a] PRIV26
    $1b constant GTZC1_MPCBB2_PRIV27            \ [0x1b] PRIV27
    $1c constant GTZC1_MPCBB2_PRIV28            \ [0x1c] PRIV28
    $1d constant GTZC1_MPCBB2_PRIV29            \ [0x1d] PRIV29
    $1e constant GTZC1_MPCBB2_PRIV30            \ [0x1e] PRIV30
    $1f constant GTZC1_MPCBB2_PRIV31            \ [0x1f] PRIV31
  [then]


  [ifdef] GTZC1_MPCBB2_MPCBB2_PRIVCFGR20_DEF
    \
    \ @brief MPCBB privileged configuration for super-block x register
    \ Address offset: 0x250
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GTZC1_MPCBB2_PRIV0             \ [0x00] PRIV0
    $01 constant GTZC1_MPCBB2_PRIV1             \ [0x01] PRIV1
    $02 constant GTZC1_MPCBB2_PRIV2             \ [0x02] PRIV2
    $03 constant GTZC1_MPCBB2_PRIV3             \ [0x03] PRIV3
    $04 constant GTZC1_MPCBB2_PRIV4             \ [0x04] PRIV4
    $05 constant GTZC1_MPCBB2_PRIV5             \ [0x05] PRIV5
    $06 constant GTZC1_MPCBB2_PRIV6             \ [0x06] PRIV6
    $07 constant GTZC1_MPCBB2_PRIV7             \ [0x07] PRIV7
    $08 constant GTZC1_MPCBB2_PRIV8             \ [0x08] PRIV8
    $09 constant GTZC1_MPCBB2_PRIV9             \ [0x09] PRIV9
    $0a constant GTZC1_MPCBB2_PRIV10            \ [0x0a] PRIV10
    $0b constant GTZC1_MPCBB2_PRIV11            \ [0x0b] PRIV11
    $0c constant GTZC1_MPCBB2_PRIV12            \ [0x0c] PRIV12
    $0d constant GTZC1_MPCBB2_PRIV13            \ [0x0d] PRIV13
    $0e constant GTZC1_MPCBB2_PRIV14            \ [0x0e] PRIV14
    $0f constant GTZC1_MPCBB2_PRIV15            \ [0x0f] PRIV15
    $10 constant GTZC1_MPCBB2_PRIV16            \ [0x10] PRIV16
    $11 constant GTZC1_MPCBB2_PRIV17            \ [0x11] PRIV17
    $12 constant GTZC1_MPCBB2_PRIV18            \ [0x12] PRIV18
    $13 constant GTZC1_MPCBB2_PRIV19            \ [0x13] PRIV19
    $14 constant GTZC1_MPCBB2_PRIV20            \ [0x14] PRIV20
    $15 constant GTZC1_MPCBB2_PRIV21            \ [0x15] PRIV21
    $16 constant GTZC1_MPCBB2_PRIV22            \ [0x16] PRIV22
    $17 constant GTZC1_MPCBB2_PRIV23            \ [0x17] PRIV23
    $18 constant GTZC1_MPCBB2_PRIV24            \ [0x18] PRIV24
    $19 constant GTZC1_MPCBB2_PRIV25            \ [0x19] PRIV25
    $1a constant GTZC1_MPCBB2_PRIV26            \ [0x1a] PRIV26
    $1b constant GTZC1_MPCBB2_PRIV27            \ [0x1b] PRIV27
    $1c constant GTZC1_MPCBB2_PRIV28            \ [0x1c] PRIV28
    $1d constant GTZC1_MPCBB2_PRIV29            \ [0x1d] PRIV29
    $1e constant GTZC1_MPCBB2_PRIV30            \ [0x1e] PRIV30
    $1f constant GTZC1_MPCBB2_PRIV31            \ [0x1f] PRIV31
  [then]


  [ifdef] GTZC1_MPCBB2_MPCBB2_PRIVCFGR21_DEF
    \
    \ @brief MPCBB privileged configuration for super-block x register
    \ Address offset: 0x254
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GTZC1_MPCBB2_PRIV0             \ [0x00] PRIV0
    $01 constant GTZC1_MPCBB2_PRIV1             \ [0x01] PRIV1
    $02 constant GTZC1_MPCBB2_PRIV2             \ [0x02] PRIV2
    $03 constant GTZC1_MPCBB2_PRIV3             \ [0x03] PRIV3
    $04 constant GTZC1_MPCBB2_PRIV4             \ [0x04] PRIV4
    $05 constant GTZC1_MPCBB2_PRIV5             \ [0x05] PRIV5
    $06 constant GTZC1_MPCBB2_PRIV6             \ [0x06] PRIV6
    $07 constant GTZC1_MPCBB2_PRIV7             \ [0x07] PRIV7
    $08 constant GTZC1_MPCBB2_PRIV8             \ [0x08] PRIV8
    $09 constant GTZC1_MPCBB2_PRIV9             \ [0x09] PRIV9
    $0a constant GTZC1_MPCBB2_PRIV10            \ [0x0a] PRIV10
    $0b constant GTZC1_MPCBB2_PRIV11            \ [0x0b] PRIV11
    $0c constant GTZC1_MPCBB2_PRIV12            \ [0x0c] PRIV12
    $0d constant GTZC1_MPCBB2_PRIV13            \ [0x0d] PRIV13
    $0e constant GTZC1_MPCBB2_PRIV14            \ [0x0e] PRIV14
    $0f constant GTZC1_MPCBB2_PRIV15            \ [0x0f] PRIV15
    $10 constant GTZC1_MPCBB2_PRIV16            \ [0x10] PRIV16
    $11 constant GTZC1_MPCBB2_PRIV17            \ [0x11] PRIV17
    $12 constant GTZC1_MPCBB2_PRIV18            \ [0x12] PRIV18
    $13 constant GTZC1_MPCBB2_PRIV19            \ [0x13] PRIV19
    $14 constant GTZC1_MPCBB2_PRIV20            \ [0x14] PRIV20
    $15 constant GTZC1_MPCBB2_PRIV21            \ [0x15] PRIV21
    $16 constant GTZC1_MPCBB2_PRIV22            \ [0x16] PRIV22
    $17 constant GTZC1_MPCBB2_PRIV23            \ [0x17] PRIV23
    $18 constant GTZC1_MPCBB2_PRIV24            \ [0x18] PRIV24
    $19 constant GTZC1_MPCBB2_PRIV25            \ [0x19] PRIV25
    $1a constant GTZC1_MPCBB2_PRIV26            \ [0x1a] PRIV26
    $1b constant GTZC1_MPCBB2_PRIV27            \ [0x1b] PRIV27
    $1c constant GTZC1_MPCBB2_PRIV28            \ [0x1c] PRIV28
    $1d constant GTZC1_MPCBB2_PRIV29            \ [0x1d] PRIV29
    $1e constant GTZC1_MPCBB2_PRIV30            \ [0x1e] PRIV30
    $1f constant GTZC1_MPCBB2_PRIV31            \ [0x1f] PRIV31
  [then]


  [ifdef] GTZC1_MPCBB2_MPCBB2_PRIVCFGR22_DEF
    \
    \ @brief MPCBB privileged configuration for super-block x register
    \ Address offset: 0x258
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GTZC1_MPCBB2_PRIV0             \ [0x00] PRIV0
    $01 constant GTZC1_MPCBB2_PRIV1             \ [0x01] PRIV1
    $02 constant GTZC1_MPCBB2_PRIV2             \ [0x02] PRIV2
    $03 constant GTZC1_MPCBB2_PRIV3             \ [0x03] PRIV3
    $04 constant GTZC1_MPCBB2_PRIV4             \ [0x04] PRIV4
    $05 constant GTZC1_MPCBB2_PRIV5             \ [0x05] PRIV5
    $06 constant GTZC1_MPCBB2_PRIV6             \ [0x06] PRIV6
    $07 constant GTZC1_MPCBB2_PRIV7             \ [0x07] PRIV7
    $08 constant GTZC1_MPCBB2_PRIV8             \ [0x08] PRIV8
    $09 constant GTZC1_MPCBB2_PRIV9             \ [0x09] PRIV9
    $0a constant GTZC1_MPCBB2_PRIV10            \ [0x0a] PRIV10
    $0b constant GTZC1_MPCBB2_PRIV11            \ [0x0b] PRIV11
    $0c constant GTZC1_MPCBB2_PRIV12            \ [0x0c] PRIV12
    $0d constant GTZC1_MPCBB2_PRIV13            \ [0x0d] PRIV13
    $0e constant GTZC1_MPCBB2_PRIV14            \ [0x0e] PRIV14
    $0f constant GTZC1_MPCBB2_PRIV15            \ [0x0f] PRIV15
    $10 constant GTZC1_MPCBB2_PRIV16            \ [0x10] PRIV16
    $11 constant GTZC1_MPCBB2_PRIV17            \ [0x11] PRIV17
    $12 constant GTZC1_MPCBB2_PRIV18            \ [0x12] PRIV18
    $13 constant GTZC1_MPCBB2_PRIV19            \ [0x13] PRIV19
    $14 constant GTZC1_MPCBB2_PRIV20            \ [0x14] PRIV20
    $15 constant GTZC1_MPCBB2_PRIV21            \ [0x15] PRIV21
    $16 constant GTZC1_MPCBB2_PRIV22            \ [0x16] PRIV22
    $17 constant GTZC1_MPCBB2_PRIV23            \ [0x17] PRIV23
    $18 constant GTZC1_MPCBB2_PRIV24            \ [0x18] PRIV24
    $19 constant GTZC1_MPCBB2_PRIV25            \ [0x19] PRIV25
    $1a constant GTZC1_MPCBB2_PRIV26            \ [0x1a] PRIV26
    $1b constant GTZC1_MPCBB2_PRIV27            \ [0x1b] PRIV27
    $1c constant GTZC1_MPCBB2_PRIV28            \ [0x1c] PRIV28
    $1d constant GTZC1_MPCBB2_PRIV29            \ [0x1d] PRIV29
    $1e constant GTZC1_MPCBB2_PRIV30            \ [0x1e] PRIV30
    $1f constant GTZC1_MPCBB2_PRIV31            \ [0x1f] PRIV31
  [then]


  [ifdef] GTZC1_MPCBB2_MPCBB2_PRIVCFGR23_DEF
    \
    \ @brief MPCBB privileged configuration for super-block x register
    \ Address offset: 0x25C
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GTZC1_MPCBB2_PRIV0             \ [0x00] PRIV0
    $01 constant GTZC1_MPCBB2_PRIV1             \ [0x01] PRIV1
    $02 constant GTZC1_MPCBB2_PRIV2             \ [0x02] PRIV2
    $03 constant GTZC1_MPCBB2_PRIV3             \ [0x03] PRIV3
    $04 constant GTZC1_MPCBB2_PRIV4             \ [0x04] PRIV4
    $05 constant GTZC1_MPCBB2_PRIV5             \ [0x05] PRIV5
    $06 constant GTZC1_MPCBB2_PRIV6             \ [0x06] PRIV6
    $07 constant GTZC1_MPCBB2_PRIV7             \ [0x07] PRIV7
    $08 constant GTZC1_MPCBB2_PRIV8             \ [0x08] PRIV8
    $09 constant GTZC1_MPCBB2_PRIV9             \ [0x09] PRIV9
    $0a constant GTZC1_MPCBB2_PRIV10            \ [0x0a] PRIV10
    $0b constant GTZC1_MPCBB2_PRIV11            \ [0x0b] PRIV11
    $0c constant GTZC1_MPCBB2_PRIV12            \ [0x0c] PRIV12
    $0d constant GTZC1_MPCBB2_PRIV13            \ [0x0d] PRIV13
    $0e constant GTZC1_MPCBB2_PRIV14            \ [0x0e] PRIV14
    $0f constant GTZC1_MPCBB2_PRIV15            \ [0x0f] PRIV15
    $10 constant GTZC1_MPCBB2_PRIV16            \ [0x10] PRIV16
    $11 constant GTZC1_MPCBB2_PRIV17            \ [0x11] PRIV17
    $12 constant GTZC1_MPCBB2_PRIV18            \ [0x12] PRIV18
    $13 constant GTZC1_MPCBB2_PRIV19            \ [0x13] PRIV19
    $14 constant GTZC1_MPCBB2_PRIV20            \ [0x14] PRIV20
    $15 constant GTZC1_MPCBB2_PRIV21            \ [0x15] PRIV21
    $16 constant GTZC1_MPCBB2_PRIV22            \ [0x16] PRIV22
    $17 constant GTZC1_MPCBB2_PRIV23            \ [0x17] PRIV23
    $18 constant GTZC1_MPCBB2_PRIV24            \ [0x18] PRIV24
    $19 constant GTZC1_MPCBB2_PRIV25            \ [0x19] PRIV25
    $1a constant GTZC1_MPCBB2_PRIV26            \ [0x1a] PRIV26
    $1b constant GTZC1_MPCBB2_PRIV27            \ [0x1b] PRIV27
    $1c constant GTZC1_MPCBB2_PRIV28            \ [0x1c] PRIV28
    $1d constant GTZC1_MPCBB2_PRIV29            \ [0x1d] PRIV29
    $1e constant GTZC1_MPCBB2_PRIV30            \ [0x1e] PRIV30
    $1f constant GTZC1_MPCBB2_PRIV31            \ [0x1f] PRIV31
  [then]


  [ifdef] GTZC1_MPCBB2_MPCBB2_PRIVCFGR24_DEF
    \
    \ @brief MPCBB privileged configuration for super-block x register
    \ Address offset: 0x260
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GTZC1_MPCBB2_PRIV0             \ [0x00] PRIV0
    $01 constant GTZC1_MPCBB2_PRIV1             \ [0x01] PRIV1
    $02 constant GTZC1_MPCBB2_PRIV2             \ [0x02] PRIV2
    $03 constant GTZC1_MPCBB2_PRIV3             \ [0x03] PRIV3
    $04 constant GTZC1_MPCBB2_PRIV4             \ [0x04] PRIV4
    $05 constant GTZC1_MPCBB2_PRIV5             \ [0x05] PRIV5
    $06 constant GTZC1_MPCBB2_PRIV6             \ [0x06] PRIV6
    $07 constant GTZC1_MPCBB2_PRIV7             \ [0x07] PRIV7
    $08 constant GTZC1_MPCBB2_PRIV8             \ [0x08] PRIV8
    $09 constant GTZC1_MPCBB2_PRIV9             \ [0x09] PRIV9
    $0a constant GTZC1_MPCBB2_PRIV10            \ [0x0a] PRIV10
    $0b constant GTZC1_MPCBB2_PRIV11            \ [0x0b] PRIV11
    $0c constant GTZC1_MPCBB2_PRIV12            \ [0x0c] PRIV12
    $0d constant GTZC1_MPCBB2_PRIV13            \ [0x0d] PRIV13
    $0e constant GTZC1_MPCBB2_PRIV14            \ [0x0e] PRIV14
    $0f constant GTZC1_MPCBB2_PRIV15            \ [0x0f] PRIV15
    $10 constant GTZC1_MPCBB2_PRIV16            \ [0x10] PRIV16
    $11 constant GTZC1_MPCBB2_PRIV17            \ [0x11] PRIV17
    $12 constant GTZC1_MPCBB2_PRIV18            \ [0x12] PRIV18
    $13 constant GTZC1_MPCBB2_PRIV19            \ [0x13] PRIV19
    $14 constant GTZC1_MPCBB2_PRIV20            \ [0x14] PRIV20
    $15 constant GTZC1_MPCBB2_PRIV21            \ [0x15] PRIV21
    $16 constant GTZC1_MPCBB2_PRIV22            \ [0x16] PRIV22
    $17 constant GTZC1_MPCBB2_PRIV23            \ [0x17] PRIV23
    $18 constant GTZC1_MPCBB2_PRIV24            \ [0x18] PRIV24
    $19 constant GTZC1_MPCBB2_PRIV25            \ [0x19] PRIV25
    $1a constant GTZC1_MPCBB2_PRIV26            \ [0x1a] PRIV26
    $1b constant GTZC1_MPCBB2_PRIV27            \ [0x1b] PRIV27
    $1c constant GTZC1_MPCBB2_PRIV28            \ [0x1c] PRIV28
    $1d constant GTZC1_MPCBB2_PRIV29            \ [0x1d] PRIV29
    $1e constant GTZC1_MPCBB2_PRIV30            \ [0x1e] PRIV30
    $1f constant GTZC1_MPCBB2_PRIV31            \ [0x1f] PRIV31
  [then]


  [ifdef] GTZC1_MPCBB2_MPCBB2_PRIVCFGR25_DEF
    \
    \ @brief MPCBB privileged configuration for super-block x register
    \ Address offset: 0x264
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GTZC1_MPCBB2_PRIV0             \ [0x00] PRIV0
    $01 constant GTZC1_MPCBB2_PRIV1             \ [0x01] PRIV1
    $02 constant GTZC1_MPCBB2_PRIV2             \ [0x02] PRIV2
    $03 constant GTZC1_MPCBB2_PRIV3             \ [0x03] PRIV3
    $04 constant GTZC1_MPCBB2_PRIV4             \ [0x04] PRIV4
    $05 constant GTZC1_MPCBB2_PRIV5             \ [0x05] PRIV5
    $06 constant GTZC1_MPCBB2_PRIV6             \ [0x06] PRIV6
    $07 constant GTZC1_MPCBB2_PRIV7             \ [0x07] PRIV7
    $08 constant GTZC1_MPCBB2_PRIV8             \ [0x08] PRIV8
    $09 constant GTZC1_MPCBB2_PRIV9             \ [0x09] PRIV9
    $0a constant GTZC1_MPCBB2_PRIV10            \ [0x0a] PRIV10
    $0b constant GTZC1_MPCBB2_PRIV11            \ [0x0b] PRIV11
    $0c constant GTZC1_MPCBB2_PRIV12            \ [0x0c] PRIV12
    $0d constant GTZC1_MPCBB2_PRIV13            \ [0x0d] PRIV13
    $0e constant GTZC1_MPCBB2_PRIV14            \ [0x0e] PRIV14
    $0f constant GTZC1_MPCBB2_PRIV15            \ [0x0f] PRIV15
    $10 constant GTZC1_MPCBB2_PRIV16            \ [0x10] PRIV16
    $11 constant GTZC1_MPCBB2_PRIV17            \ [0x11] PRIV17
    $12 constant GTZC1_MPCBB2_PRIV18            \ [0x12] PRIV18
    $13 constant GTZC1_MPCBB2_PRIV19            \ [0x13] PRIV19
    $14 constant GTZC1_MPCBB2_PRIV20            \ [0x14] PRIV20
    $15 constant GTZC1_MPCBB2_PRIV21            \ [0x15] PRIV21
    $16 constant GTZC1_MPCBB2_PRIV22            \ [0x16] PRIV22
    $17 constant GTZC1_MPCBB2_PRIV23            \ [0x17] PRIV23
    $18 constant GTZC1_MPCBB2_PRIV24            \ [0x18] PRIV24
    $19 constant GTZC1_MPCBB2_PRIV25            \ [0x19] PRIV25
    $1a constant GTZC1_MPCBB2_PRIV26            \ [0x1a] PRIV26
    $1b constant GTZC1_MPCBB2_PRIV27            \ [0x1b] PRIV27
    $1c constant GTZC1_MPCBB2_PRIV28            \ [0x1c] PRIV28
    $1d constant GTZC1_MPCBB2_PRIV29            \ [0x1d] PRIV29
    $1e constant GTZC1_MPCBB2_PRIV30            \ [0x1e] PRIV30
    $1f constant GTZC1_MPCBB2_PRIV31            \ [0x1f] PRIV31
  [then]


  [ifdef] GTZC1_MPCBB2_MPCBB2_PRIVCFGR26_DEF
    \
    \ @brief MPCBB privileged configuration for super-block x register
    \ Address offset: 0x268
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GTZC1_MPCBB2_PRIV0             \ [0x00] PRIV0
    $01 constant GTZC1_MPCBB2_PRIV1             \ [0x01] PRIV1
    $02 constant GTZC1_MPCBB2_PRIV2             \ [0x02] PRIV2
    $03 constant GTZC1_MPCBB2_PRIV3             \ [0x03] PRIV3
    $04 constant GTZC1_MPCBB2_PRIV4             \ [0x04] PRIV4
    $05 constant GTZC1_MPCBB2_PRIV5             \ [0x05] PRIV5
    $06 constant GTZC1_MPCBB2_PRIV6             \ [0x06] PRIV6
    $07 constant GTZC1_MPCBB2_PRIV7             \ [0x07] PRIV7
    $08 constant GTZC1_MPCBB2_PRIV8             \ [0x08] PRIV8
    $09 constant GTZC1_MPCBB2_PRIV9             \ [0x09] PRIV9
    $0a constant GTZC1_MPCBB2_PRIV10            \ [0x0a] PRIV10
    $0b constant GTZC1_MPCBB2_PRIV11            \ [0x0b] PRIV11
    $0c constant GTZC1_MPCBB2_PRIV12            \ [0x0c] PRIV12
    $0d constant GTZC1_MPCBB2_PRIV13            \ [0x0d] PRIV13
    $0e constant GTZC1_MPCBB2_PRIV14            \ [0x0e] PRIV14
    $0f constant GTZC1_MPCBB2_PRIV15            \ [0x0f] PRIV15
    $10 constant GTZC1_MPCBB2_PRIV16            \ [0x10] PRIV16
    $11 constant GTZC1_MPCBB2_PRIV17            \ [0x11] PRIV17
    $12 constant GTZC1_MPCBB2_PRIV18            \ [0x12] PRIV18
    $13 constant GTZC1_MPCBB2_PRIV19            \ [0x13] PRIV19
    $14 constant GTZC1_MPCBB2_PRIV20            \ [0x14] PRIV20
    $15 constant GTZC1_MPCBB2_PRIV21            \ [0x15] PRIV21
    $16 constant GTZC1_MPCBB2_PRIV22            \ [0x16] PRIV22
    $17 constant GTZC1_MPCBB2_PRIV23            \ [0x17] PRIV23
    $18 constant GTZC1_MPCBB2_PRIV24            \ [0x18] PRIV24
    $19 constant GTZC1_MPCBB2_PRIV25            \ [0x19] PRIV25
    $1a constant GTZC1_MPCBB2_PRIV26            \ [0x1a] PRIV26
    $1b constant GTZC1_MPCBB2_PRIV27            \ [0x1b] PRIV27
    $1c constant GTZC1_MPCBB2_PRIV28            \ [0x1c] PRIV28
    $1d constant GTZC1_MPCBB2_PRIV29            \ [0x1d] PRIV29
    $1e constant GTZC1_MPCBB2_PRIV30            \ [0x1e] PRIV30
    $1f constant GTZC1_MPCBB2_PRIV31            \ [0x1f] PRIV31
  [then]


  [ifdef] GTZC1_MPCBB2_MPCBB2_PRIVCFGR27_DEF
    \
    \ @brief MPCBB privileged configuration for super-block x register
    \ Address offset: 0x26C
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GTZC1_MPCBB2_PRIV0             \ [0x00] PRIV0
    $01 constant GTZC1_MPCBB2_PRIV1             \ [0x01] PRIV1
    $02 constant GTZC1_MPCBB2_PRIV2             \ [0x02] PRIV2
    $03 constant GTZC1_MPCBB2_PRIV3             \ [0x03] PRIV3
    $04 constant GTZC1_MPCBB2_PRIV4             \ [0x04] PRIV4
    $05 constant GTZC1_MPCBB2_PRIV5             \ [0x05] PRIV5
    $06 constant GTZC1_MPCBB2_PRIV6             \ [0x06] PRIV6
    $07 constant GTZC1_MPCBB2_PRIV7             \ [0x07] PRIV7
    $08 constant GTZC1_MPCBB2_PRIV8             \ [0x08] PRIV8
    $09 constant GTZC1_MPCBB2_PRIV9             \ [0x09] PRIV9
    $0a constant GTZC1_MPCBB2_PRIV10            \ [0x0a] PRIV10
    $0b constant GTZC1_MPCBB2_PRIV11            \ [0x0b] PRIV11
    $0c constant GTZC1_MPCBB2_PRIV12            \ [0x0c] PRIV12
    $0d constant GTZC1_MPCBB2_PRIV13            \ [0x0d] PRIV13
    $0e constant GTZC1_MPCBB2_PRIV14            \ [0x0e] PRIV14
    $0f constant GTZC1_MPCBB2_PRIV15            \ [0x0f] PRIV15
    $10 constant GTZC1_MPCBB2_PRIV16            \ [0x10] PRIV16
    $11 constant GTZC1_MPCBB2_PRIV17            \ [0x11] PRIV17
    $12 constant GTZC1_MPCBB2_PRIV18            \ [0x12] PRIV18
    $13 constant GTZC1_MPCBB2_PRIV19            \ [0x13] PRIV19
    $14 constant GTZC1_MPCBB2_PRIV20            \ [0x14] PRIV20
    $15 constant GTZC1_MPCBB2_PRIV21            \ [0x15] PRIV21
    $16 constant GTZC1_MPCBB2_PRIV22            \ [0x16] PRIV22
    $17 constant GTZC1_MPCBB2_PRIV23            \ [0x17] PRIV23
    $18 constant GTZC1_MPCBB2_PRIV24            \ [0x18] PRIV24
    $19 constant GTZC1_MPCBB2_PRIV25            \ [0x19] PRIV25
    $1a constant GTZC1_MPCBB2_PRIV26            \ [0x1a] PRIV26
    $1b constant GTZC1_MPCBB2_PRIV27            \ [0x1b] PRIV27
    $1c constant GTZC1_MPCBB2_PRIV28            \ [0x1c] PRIV28
    $1d constant GTZC1_MPCBB2_PRIV29            \ [0x1d] PRIV29
    $1e constant GTZC1_MPCBB2_PRIV30            \ [0x1e] PRIV30
    $1f constant GTZC1_MPCBB2_PRIV31            \ [0x1f] PRIV31
  [then]


  [ifdef] GTZC1_MPCBB2_MPCBB2_PRIVCFGR28_DEF
    \
    \ @brief MPCBB privileged configuration for super-block x register
    \ Address offset: 0x270
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GTZC1_MPCBB2_PRIV0             \ [0x00] PRIV0
    $01 constant GTZC1_MPCBB2_PRIV1             \ [0x01] PRIV1
    $02 constant GTZC1_MPCBB2_PRIV2             \ [0x02] PRIV2
    $03 constant GTZC1_MPCBB2_PRIV3             \ [0x03] PRIV3
    $04 constant GTZC1_MPCBB2_PRIV4             \ [0x04] PRIV4
    $05 constant GTZC1_MPCBB2_PRIV5             \ [0x05] PRIV5
    $06 constant GTZC1_MPCBB2_PRIV6             \ [0x06] PRIV6
    $07 constant GTZC1_MPCBB2_PRIV7             \ [0x07] PRIV7
    $08 constant GTZC1_MPCBB2_PRIV8             \ [0x08] PRIV8
    $09 constant GTZC1_MPCBB2_PRIV9             \ [0x09] PRIV9
    $0a constant GTZC1_MPCBB2_PRIV10            \ [0x0a] PRIV10
    $0b constant GTZC1_MPCBB2_PRIV11            \ [0x0b] PRIV11
    $0c constant GTZC1_MPCBB2_PRIV12            \ [0x0c] PRIV12
    $0d constant GTZC1_MPCBB2_PRIV13            \ [0x0d] PRIV13
    $0e constant GTZC1_MPCBB2_PRIV14            \ [0x0e] PRIV14
    $0f constant GTZC1_MPCBB2_PRIV15            \ [0x0f] PRIV15
    $10 constant GTZC1_MPCBB2_PRIV16            \ [0x10] PRIV16
    $11 constant GTZC1_MPCBB2_PRIV17            \ [0x11] PRIV17
    $12 constant GTZC1_MPCBB2_PRIV18            \ [0x12] PRIV18
    $13 constant GTZC1_MPCBB2_PRIV19            \ [0x13] PRIV19
    $14 constant GTZC1_MPCBB2_PRIV20            \ [0x14] PRIV20
    $15 constant GTZC1_MPCBB2_PRIV21            \ [0x15] PRIV21
    $16 constant GTZC1_MPCBB2_PRIV22            \ [0x16] PRIV22
    $17 constant GTZC1_MPCBB2_PRIV23            \ [0x17] PRIV23
    $18 constant GTZC1_MPCBB2_PRIV24            \ [0x18] PRIV24
    $19 constant GTZC1_MPCBB2_PRIV25            \ [0x19] PRIV25
    $1a constant GTZC1_MPCBB2_PRIV26            \ [0x1a] PRIV26
    $1b constant GTZC1_MPCBB2_PRIV27            \ [0x1b] PRIV27
    $1c constant GTZC1_MPCBB2_PRIV28            \ [0x1c] PRIV28
    $1d constant GTZC1_MPCBB2_PRIV29            \ [0x1d] PRIV29
    $1e constant GTZC1_MPCBB2_PRIV30            \ [0x1e] PRIV30
    $1f constant GTZC1_MPCBB2_PRIV31            \ [0x1f] PRIV31
  [then]


  [ifdef] GTZC1_MPCBB2_MPCBB2_PRIVCFGR29_DEF
    \
    \ @brief MPCBB privileged configuration for super-block x register
    \ Address offset: 0x274
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GTZC1_MPCBB2_PRIV0             \ [0x00] PRIV0
    $01 constant GTZC1_MPCBB2_PRIV1             \ [0x01] PRIV1
    $02 constant GTZC1_MPCBB2_PRIV2             \ [0x02] PRIV2
    $03 constant GTZC1_MPCBB2_PRIV3             \ [0x03] PRIV3
    $04 constant GTZC1_MPCBB2_PRIV4             \ [0x04] PRIV4
    $05 constant GTZC1_MPCBB2_PRIV5             \ [0x05] PRIV5
    $06 constant GTZC1_MPCBB2_PRIV6             \ [0x06] PRIV6
    $07 constant GTZC1_MPCBB2_PRIV7             \ [0x07] PRIV7
    $08 constant GTZC1_MPCBB2_PRIV8             \ [0x08] PRIV8
    $09 constant GTZC1_MPCBB2_PRIV9             \ [0x09] PRIV9
    $0a constant GTZC1_MPCBB2_PRIV10            \ [0x0a] PRIV10
    $0b constant GTZC1_MPCBB2_PRIV11            \ [0x0b] PRIV11
    $0c constant GTZC1_MPCBB2_PRIV12            \ [0x0c] PRIV12
    $0d constant GTZC1_MPCBB2_PRIV13            \ [0x0d] PRIV13
    $0e constant GTZC1_MPCBB2_PRIV14            \ [0x0e] PRIV14
    $0f constant GTZC1_MPCBB2_PRIV15            \ [0x0f] PRIV15
    $10 constant GTZC1_MPCBB2_PRIV16            \ [0x10] PRIV16
    $11 constant GTZC1_MPCBB2_PRIV17            \ [0x11] PRIV17
    $12 constant GTZC1_MPCBB2_PRIV18            \ [0x12] PRIV18
    $13 constant GTZC1_MPCBB2_PRIV19            \ [0x13] PRIV19
    $14 constant GTZC1_MPCBB2_PRIV20            \ [0x14] PRIV20
    $15 constant GTZC1_MPCBB2_PRIV21            \ [0x15] PRIV21
    $16 constant GTZC1_MPCBB2_PRIV22            \ [0x16] PRIV22
    $17 constant GTZC1_MPCBB2_PRIV23            \ [0x17] PRIV23
    $18 constant GTZC1_MPCBB2_PRIV24            \ [0x18] PRIV24
    $19 constant GTZC1_MPCBB2_PRIV25            \ [0x19] PRIV25
    $1a constant GTZC1_MPCBB2_PRIV26            \ [0x1a] PRIV26
    $1b constant GTZC1_MPCBB2_PRIV27            \ [0x1b] PRIV27
    $1c constant GTZC1_MPCBB2_PRIV28            \ [0x1c] PRIV28
    $1d constant GTZC1_MPCBB2_PRIV29            \ [0x1d] PRIV29
    $1e constant GTZC1_MPCBB2_PRIV30            \ [0x1e] PRIV30
    $1f constant GTZC1_MPCBB2_PRIV31            \ [0x1f] PRIV31
  [then]


  [ifdef] GTZC1_MPCBB2_MPCBB2_PRIVCFGR30_DEF
    \
    \ @brief MPCBB privileged configuration for super-block x register
    \ Address offset: 0x278
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GTZC1_MPCBB2_PRIV0             \ [0x00] PRIV0
    $01 constant GTZC1_MPCBB2_PRIV1             \ [0x01] PRIV1
    $02 constant GTZC1_MPCBB2_PRIV2             \ [0x02] PRIV2
    $03 constant GTZC1_MPCBB2_PRIV3             \ [0x03] PRIV3
    $04 constant GTZC1_MPCBB2_PRIV4             \ [0x04] PRIV4
    $05 constant GTZC1_MPCBB2_PRIV5             \ [0x05] PRIV5
    $06 constant GTZC1_MPCBB2_PRIV6             \ [0x06] PRIV6
    $07 constant GTZC1_MPCBB2_PRIV7             \ [0x07] PRIV7
    $08 constant GTZC1_MPCBB2_PRIV8             \ [0x08] PRIV8
    $09 constant GTZC1_MPCBB2_PRIV9             \ [0x09] PRIV9
    $0a constant GTZC1_MPCBB2_PRIV10            \ [0x0a] PRIV10
    $0b constant GTZC1_MPCBB2_PRIV11            \ [0x0b] PRIV11
    $0c constant GTZC1_MPCBB2_PRIV12            \ [0x0c] PRIV12
    $0d constant GTZC1_MPCBB2_PRIV13            \ [0x0d] PRIV13
    $0e constant GTZC1_MPCBB2_PRIV14            \ [0x0e] PRIV14
    $0f constant GTZC1_MPCBB2_PRIV15            \ [0x0f] PRIV15
    $10 constant GTZC1_MPCBB2_PRIV16            \ [0x10] PRIV16
    $11 constant GTZC1_MPCBB2_PRIV17            \ [0x11] PRIV17
    $12 constant GTZC1_MPCBB2_PRIV18            \ [0x12] PRIV18
    $13 constant GTZC1_MPCBB2_PRIV19            \ [0x13] PRIV19
    $14 constant GTZC1_MPCBB2_PRIV20            \ [0x14] PRIV20
    $15 constant GTZC1_MPCBB2_PRIV21            \ [0x15] PRIV21
    $16 constant GTZC1_MPCBB2_PRIV22            \ [0x16] PRIV22
    $17 constant GTZC1_MPCBB2_PRIV23            \ [0x17] PRIV23
    $18 constant GTZC1_MPCBB2_PRIV24            \ [0x18] PRIV24
    $19 constant GTZC1_MPCBB2_PRIV25            \ [0x19] PRIV25
    $1a constant GTZC1_MPCBB2_PRIV26            \ [0x1a] PRIV26
    $1b constant GTZC1_MPCBB2_PRIV27            \ [0x1b] PRIV27
    $1c constant GTZC1_MPCBB2_PRIV28            \ [0x1c] PRIV28
    $1d constant GTZC1_MPCBB2_PRIV29            \ [0x1d] PRIV29
    $1e constant GTZC1_MPCBB2_PRIV30            \ [0x1e] PRIV30
    $1f constant GTZC1_MPCBB2_PRIV31            \ [0x1f] PRIV31
  [then]


  [ifdef] GTZC1_MPCBB2_MPCBB2_PRIVCFGR31_DEF
    \
    \ @brief MPCBB privileged configuration for super-block x register
    \ Address offset: 0x27C
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GTZC1_MPCBB2_PRIV0             \ [0x00] PRIV0
    $01 constant GTZC1_MPCBB2_PRIV1             \ [0x01] PRIV1
    $02 constant GTZC1_MPCBB2_PRIV2             \ [0x02] PRIV2
    $03 constant GTZC1_MPCBB2_PRIV3             \ [0x03] PRIV3
    $04 constant GTZC1_MPCBB2_PRIV4             \ [0x04] PRIV4
    $05 constant GTZC1_MPCBB2_PRIV5             \ [0x05] PRIV5
    $06 constant GTZC1_MPCBB2_PRIV6             \ [0x06] PRIV6
    $07 constant GTZC1_MPCBB2_PRIV7             \ [0x07] PRIV7
    $08 constant GTZC1_MPCBB2_PRIV8             \ [0x08] PRIV8
    $09 constant GTZC1_MPCBB2_PRIV9             \ [0x09] PRIV9
    $0a constant GTZC1_MPCBB2_PRIV10            \ [0x0a] PRIV10
    $0b constant GTZC1_MPCBB2_PRIV11            \ [0x0b] PRIV11
    $0c constant GTZC1_MPCBB2_PRIV12            \ [0x0c] PRIV12
    $0d constant GTZC1_MPCBB2_PRIV13            \ [0x0d] PRIV13
    $0e constant GTZC1_MPCBB2_PRIV14            \ [0x0e] PRIV14
    $0f constant GTZC1_MPCBB2_PRIV15            \ [0x0f] PRIV15
    $10 constant GTZC1_MPCBB2_PRIV16            \ [0x10] PRIV16
    $11 constant GTZC1_MPCBB2_PRIV17            \ [0x11] PRIV17
    $12 constant GTZC1_MPCBB2_PRIV18            \ [0x12] PRIV18
    $13 constant GTZC1_MPCBB2_PRIV19            \ [0x13] PRIV19
    $14 constant GTZC1_MPCBB2_PRIV20            \ [0x14] PRIV20
    $15 constant GTZC1_MPCBB2_PRIV21            \ [0x15] PRIV21
    $16 constant GTZC1_MPCBB2_PRIV22            \ [0x16] PRIV22
    $17 constant GTZC1_MPCBB2_PRIV23            \ [0x17] PRIV23
    $18 constant GTZC1_MPCBB2_PRIV24            \ [0x18] PRIV24
    $19 constant GTZC1_MPCBB2_PRIV25            \ [0x19] PRIV25
    $1a constant GTZC1_MPCBB2_PRIV26            \ [0x1a] PRIV26
    $1b constant GTZC1_MPCBB2_PRIV27            \ [0x1b] PRIV27
    $1c constant GTZC1_MPCBB2_PRIV28            \ [0x1c] PRIV28
    $1d constant GTZC1_MPCBB2_PRIV29            \ [0x1d] PRIV29
    $1e constant GTZC1_MPCBB2_PRIV30            \ [0x1e] PRIV30
    $1f constant GTZC1_MPCBB2_PRIV31            \ [0x1f] PRIV31
  [then]

  \
  \ @brief GTZC1_MPCBB2
  \
  $00 constant GTZC1_MPCBB2_MPCBB2_CR   \ MPCBB control register
  $10 constant GTZC1_MPCBB2_MPCBB2_CFGLOCKR1    \ GTZC1 SRAMz MPCBB configuration lock register
  $100 constant GTZC1_MPCBB2_MPCBB2_SECCFGR0    \ MPCBBx security configuration for super-block x register
  $104 constant GTZC1_MPCBB2_MPCBB2_SECCFGR1    \ MPCBBx security configuration for super-block x register
  $108 constant GTZC1_MPCBB2_MPCBB2_SECCFGR2    \ MPCBBx security configuration for super-block x register
  $10C constant GTZC1_MPCBB2_MPCBB2_SECCFGR3    \ MPCBBx security configuration for super-block x register
  $110 constant GTZC1_MPCBB2_MPCBB2_SECCFGR4    \ MPCBBx security configuration for super-block x register
  $114 constant GTZC1_MPCBB2_MPCBB2_SECCFGR5    \ MPCBBx security configuration for super-block x register
  $118 constant GTZC1_MPCBB2_MPCBB2_SECCFGR6    \ MPCBBx security configuration for super-block x register
  $11C constant GTZC1_MPCBB2_MPCBB2_SECCFGR7    \ MPCBBx security configuration for super-block x register
  $120 constant GTZC1_MPCBB2_MPCBB2_SECCFGR8    \ MPCBBx security configuration for super-block x register
  $124 constant GTZC1_MPCBB2_MPCBB2_SECCFGR9    \ MPCBBx security configuration for super-block x register
  $128 constant GTZC1_MPCBB2_MPCBB2_SECCFGR10    \ MPCBBx security configuration for super-block x register
  $12C constant GTZC1_MPCBB2_MPCBB2_SECCFGR11    \ MPCBBx security configuration for super-block x register
  $130 constant GTZC1_MPCBB2_MPCBB2_SECCFGR12    \ MPCBBx security configuration for super-block x register
  $134 constant GTZC1_MPCBB2_MPCBB2_SECCFGR13    \ MPCBBx security configuration for super-block x register
  $138 constant GTZC1_MPCBB2_MPCBB2_SECCFGR14    \ MPCBBx security configuration for super-block x register
  $13C constant GTZC1_MPCBB2_MPCBB2_SECCFGR15    \ MPCBBx security configuration for super-block x register
  $140 constant GTZC1_MPCBB2_MPCBB2_SECCFGR16    \ MPCBBx security configuration for super-block x register
  $144 constant GTZC1_MPCBB2_MPCBB2_SECCFGR17    \ MPCBBx security configuration for super-block x register
  $148 constant GTZC1_MPCBB2_MPCBB2_SECCFGR18    \ MPCBBx security configuration for super-block x register
  $14C constant GTZC1_MPCBB2_MPCBB2_SECCFGR19    \ MPCBBx security configuration for super-block x register
  $150 constant GTZC1_MPCBB2_MPCBB2_SECCFGR20    \ MPCBBx security configuration for super-block x register
  $154 constant GTZC1_MPCBB2_MPCBB2_SECCFGR21    \ MPCBBx security configuration for super-block x register
  $158 constant GTZC1_MPCBB2_MPCBB2_SECCFGR22    \ MPCBBx security configuration for super-block x register
  $15C constant GTZC1_MPCBB2_MPCBB2_SECCFGR23    \ MPCBBx security configuration for super-block x register
  $160 constant GTZC1_MPCBB2_MPCBB2_SECCFGR24    \ MPCBBx security configuration for super-block x register
  $164 constant GTZC1_MPCBB2_MPCBB2_SECCFGR25    \ MPCBBx security configuration for super-block x register
  $168 constant GTZC1_MPCBB2_MPCBB2_SECCFGR26    \ MPCBBx security configuration for super-block x register
  $16C constant GTZC1_MPCBB2_MPCBB2_SECCFGR27    \ MPCBBx security configuration for super-block x register
  $170 constant GTZC1_MPCBB2_MPCBB2_SECCFGR28    \ MPCBBx security configuration for super-block x register
  $174 constant GTZC1_MPCBB2_MPCBB2_SECCFGR29    \ MPCBBx security configuration for super-block x register
  $178 constant GTZC1_MPCBB2_MPCBB2_SECCFGR30    \ MPCBBx security configuration for super-block x register
  $17C constant GTZC1_MPCBB2_MPCBB2_SECCFGR31    \ MPCBBx security configuration for super-block x register
  $200 constant GTZC1_MPCBB2_MPCBB2_PRIVCFGR0    \ MPCBB privileged configuration for super-block x register
  $204 constant GTZC1_MPCBB2_MPCBB2_PRIVCFGR1    \ MPCBB privileged configuration for super-block x register
  $208 constant GTZC1_MPCBB2_MPCBB2_PRIVCFGR2    \ MPCBB privileged configuration for super-block x register
  $20C constant GTZC1_MPCBB2_MPCBB2_PRIVCFGR3    \ MPCBB privileged configuration for super-block x register
  $210 constant GTZC1_MPCBB2_MPCBB2_PRIVCFGR4    \ MPCBB privileged configuration for super-block x register
  $214 constant GTZC1_MPCBB2_MPCBB2_PRIVCFGR5    \ MPCBB privileged configuration for super-block x register
  $218 constant GTZC1_MPCBB2_MPCBB2_PRIVCFGR6    \ MPCBB privileged configuration for super-block x register
  $21C constant GTZC1_MPCBB2_MPCBB2_PRIVCFGR7    \ MPCBB privileged configuration for super-block x register
  $220 constant GTZC1_MPCBB2_MPCBB2_PRIVCFGR8    \ MPCBB privileged configuration for super-block x register
  $224 constant GTZC1_MPCBB2_MPCBB2_PRIVCFGR9    \ MPCBB privileged configuration for super-block x register
  $228 constant GTZC1_MPCBB2_MPCBB2_PRIVCFGR10    \ MPCBB privileged configuration for super-block x register
  $22C constant GTZC1_MPCBB2_MPCBB2_PRIVCFGR11    \ MPCBB privileged configuration for super-block x register
  $230 constant GTZC1_MPCBB2_MPCBB2_PRIVCFGR12    \ MPCBB privileged configuration for super-block x register
  $234 constant GTZC1_MPCBB2_MPCBB2_PRIVCFGR13    \ MPCBB privileged configuration for super-block x register
  $238 constant GTZC1_MPCBB2_MPCBB2_PRIVCFGR14    \ MPCBB privileged configuration for super-block x register
  $23C constant GTZC1_MPCBB2_MPCBB2_PRIVCFGR15    \ MPCBB privileged configuration for super-block x register
  $240 constant GTZC1_MPCBB2_MPCBB2_PRIVCFGR16    \ MPCBB privileged configuration for super-block x register
  $244 constant GTZC1_MPCBB2_MPCBB2_PRIVCFGR17    \ MPCBB privileged configuration for super-block x register
  $248 constant GTZC1_MPCBB2_MPCBB2_PRIVCFGR18    \ MPCBB privileged configuration for super-block x register
  $24C constant GTZC1_MPCBB2_MPCBB2_PRIVCFGR19    \ MPCBB privileged configuration for super-block x register
  $250 constant GTZC1_MPCBB2_MPCBB2_PRIVCFGR20    \ MPCBB privileged configuration for super-block x register
  $254 constant GTZC1_MPCBB2_MPCBB2_PRIVCFGR21    \ MPCBB privileged configuration for super-block x register
  $258 constant GTZC1_MPCBB2_MPCBB2_PRIVCFGR22    \ MPCBB privileged configuration for super-block x register
  $25C constant GTZC1_MPCBB2_MPCBB2_PRIVCFGR23    \ MPCBB privileged configuration for super-block x register
  $260 constant GTZC1_MPCBB2_MPCBB2_PRIVCFGR24    \ MPCBB privileged configuration for super-block x register
  $264 constant GTZC1_MPCBB2_MPCBB2_PRIVCFGR25    \ MPCBB privileged configuration for super-block x register
  $268 constant GTZC1_MPCBB2_MPCBB2_PRIVCFGR26    \ MPCBB privileged configuration for super-block x register
  $26C constant GTZC1_MPCBB2_MPCBB2_PRIVCFGR27    \ MPCBB privileged configuration for super-block x register
  $270 constant GTZC1_MPCBB2_MPCBB2_PRIVCFGR28    \ MPCBB privileged configuration for super-block x register
  $274 constant GTZC1_MPCBB2_MPCBB2_PRIVCFGR29    \ MPCBB privileged configuration for super-block x register
  $278 constant GTZC1_MPCBB2_MPCBB2_PRIVCFGR30    \ MPCBB privileged configuration for super-block x register
  $27C constant GTZC1_MPCBB2_MPCBB2_PRIVCFGR31    \ MPCBB privileged configuration for super-block x register

: GTZC1_MPCBB2_DEF ; [then]
