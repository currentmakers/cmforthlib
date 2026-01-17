\
\ @file gtzc1_mpcbb3.fs
\ @brief GTZC1_MPCBB3
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] GTZC1_MPCBB3_DEF

  [ifdef] GTZC1_MPCBB3_MPCBB3_CR_DEF
    \
    \ @brief MPCBB control register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant GTZC1_MPCBB3_GLOCK             \ [0x00] lock the control register of the MPCBB until next reset
    $1e constant GTZC1_MPCBB3_INVSECSTATE       \ [0x1e] SRAMx clocks security state
    $1f constant GTZC1_MPCBB3_SRWILADIS         \ [0x1f] secure read/write illegal access disable
  [then]


  [ifdef] GTZC1_MPCBB3_MPCBB3_CFGLOCK1_DEF
    \
    \ @brief GTZC1 SRAMz MPCBB configuration lock register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant GTZC1_MPCBB3_SPLCK0            \ [0x00] SPLCK0
    $01 constant GTZC1_MPCBB3_SPLCK1            \ [0x01] SPLCK1
    $02 constant GTZC1_MPCBB3_SPLCK2            \ [0x02] SPLCK2
    $03 constant GTZC1_MPCBB3_SPLCK3            \ [0x03] SPLCK3
    $04 constant GTZC1_MPCBB3_SPLCK4            \ [0x04] SPLCK4
    $05 constant GTZC1_MPCBB3_SPLCK5            \ [0x05] SPLCK5
    $06 constant GTZC1_MPCBB3_SPLCK6            \ [0x06] SPLCK6
    $07 constant GTZC1_MPCBB3_SPLCK7            \ [0x07] SPLCK7
    $08 constant GTZC1_MPCBB3_SPLCK8            \ [0x08] SPLCK8
    $09 constant GTZC1_MPCBB3_SPLCK9            \ [0x09] SPLCK9
    $0a constant GTZC1_MPCBB3_SPLCK10           \ [0x0a] SPLCK10
    $0b constant GTZC1_MPCBB3_SPLCK11           \ [0x0b] SPLCK11
    $0c constant GTZC1_MPCBB3_SPLCK12           \ [0x0c] SPLCK12
    $0d constant GTZC1_MPCBB3_SPLCK13           \ [0x0d] SPLCK13
    $0e constant GTZC1_MPCBB3_SPLCK14           \ [0x0e] SPLCK14
    $0f constant GTZC1_MPCBB3_SPLCK15           \ [0x0f] SPLCK15
    $10 constant GTZC1_MPCBB3_SPLCK16           \ [0x10] SPLCK16
    $11 constant GTZC1_MPCBB3_SPLCK17           \ [0x11] SPLCK17
    $12 constant GTZC1_MPCBB3_SPLCK18           \ [0x12] SPLCK18
    $13 constant GTZC1_MPCBB3_SPLCK19           \ [0x13] SPLCK19
    $14 constant GTZC1_MPCBB3_SPLCK20           \ [0x14] SPLCK20
    $15 constant GTZC1_MPCBB3_SPLCK21           \ [0x15] SPLCK21
    $16 constant GTZC1_MPCBB3_SPLCK22           \ [0x16] SPLCK22
    $17 constant GTZC1_MPCBB3_SPLCK23           \ [0x17] SPLCK23
    $18 constant GTZC1_MPCBB3_SPLCK24           \ [0x18] SPLCK24
    $19 constant GTZC1_MPCBB3_SPLCK25           \ [0x19] SPLCK25
    $1a constant GTZC1_MPCBB3_SPLCK26           \ [0x1a] SPLCK26
    $1b constant GTZC1_MPCBB3_SPLCK27           \ [0x1b] SPLCK27
    $1c constant GTZC1_MPCBB3_SPLCK28           \ [0x1c] SPLCK28
    $1d constant GTZC1_MPCBB3_SPLCK29           \ [0x1d] SPLCK29
    $1e constant GTZC1_MPCBB3_SPLCK30           \ [0x1e] SPLCK30
    $1f constant GTZC1_MPCBB3_SPLCK31           \ [0x1f] SPLCK31
  [then]


  [ifdef] GTZC1_MPCBB3_MPCBB3_CFGLOCK2_DEF
    \
    \ @brief GTZC1 SRAMz MPCBB configuration lock register 2
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant GTZC1_MPCBB3_SPLCK32           \ [0x00] SPLCK32
    $01 constant GTZC1_MPCBB3_SPLCK33           \ [0x01] SPLCK33
    $02 constant GTZC1_MPCBB3_SPLCK34           \ [0x02] SPLCK34
    $03 constant GTZC1_MPCBB3_SPLCK35           \ [0x03] SPLCK35
    $04 constant GTZC1_MPCBB3_SPLCK36           \ [0x04] SPLCK36
    $05 constant GTZC1_MPCBB3_SPLCK37           \ [0x05] SPLCK37
    $06 constant GTZC1_MPCBB3_SPLCK38           \ [0x06] SPLCK38
    $07 constant GTZC1_MPCBB3_SPLCK39           \ [0x07] SPLCK39
    $08 constant GTZC1_MPCBB3_SPLCK40           \ [0x08] SPLCK40
    $09 constant GTZC1_MPCBB3_SPLCK41           \ [0x09] SPLCK41
    $0a constant GTZC1_MPCBB3_SPLCK42           \ [0x0a] SPLCK42
    $0b constant GTZC1_MPCBB3_SPLCK43           \ [0x0b] SPLCK43
    $0c constant GTZC1_MPCBB3_SPLCK44           \ [0x0c] SPLCK44
    $0d constant GTZC1_MPCBB3_SPLCK45           \ [0x0d] SPLCK45
    $0e constant GTZC1_MPCBB3_SPLCK46           \ [0x0e] SPLCK46
    $0f constant GTZC1_MPCBB3_SPLCK47           \ [0x0f] SPLCK47
    $10 constant GTZC1_MPCBB3_SPLCK48           \ [0x10] SPLCK48
    $11 constant GTZC1_MPCBB3_SPLCK49           \ [0x11] SPLCK49
    $12 constant GTZC1_MPCBB3_SPLCK50           \ [0x12] SPLCK50
    $13 constant GTZC1_MPCBB3_SPLCK51           \ [0x13] SPLCK51
  [then]


  [ifdef] GTZC1_MPCBB3_MPCBB3_SECCFGR0_DEF
    \
    \ @brief MPCBBx security configuration for super-block x register
    \ Address offset: 0x100
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GTZC1_MPCBB3_SEC0              \ [0x00] SEC0
    $01 constant GTZC1_MPCBB3_SEC1              \ [0x01] SEC1
    $02 constant GTZC1_MPCBB3_SEC2              \ [0x02] SEC2
    $03 constant GTZC1_MPCBB3_SEC3              \ [0x03] SEC3
    $04 constant GTZC1_MPCBB3_SEC4              \ [0x04] SEC4
    $05 constant GTZC1_MPCBB3_SEC5              \ [0x05] SEC5
    $06 constant GTZC1_MPCBB3_SEC6              \ [0x06] SEC6
    $07 constant GTZC1_MPCBB3_SEC7              \ [0x07] SEC7
    $08 constant GTZC1_MPCBB3_SEC8              \ [0x08] SEC8
    $09 constant GTZC1_MPCBB3_SEC9              \ [0x09] SEC9
    $0a constant GTZC1_MPCBB3_SEC10             \ [0x0a] SEC10
    $0b constant GTZC1_MPCBB3_SEC11             \ [0x0b] SEC11
    $0c constant GTZC1_MPCBB3_SEC12             \ [0x0c] SEC12
    $0d constant GTZC1_MPCBB3_SEC13             \ [0x0d] SEC13
    $0e constant GTZC1_MPCBB3_SEC14             \ [0x0e] SEC14
    $0f constant GTZC1_MPCBB3_SEC15             \ [0x0f] SEC15
    $10 constant GTZC1_MPCBB3_SEC16             \ [0x10] SEC16
    $11 constant GTZC1_MPCBB3_SEC17             \ [0x11] SEC17
    $12 constant GTZC1_MPCBB3_SEC18             \ [0x12] SEC18
    $13 constant GTZC1_MPCBB3_SEC19             \ [0x13] SEC19
    $14 constant GTZC1_MPCBB3_SEC20             \ [0x14] SEC20
    $15 constant GTZC1_MPCBB3_SEC21             \ [0x15] SEC21
    $16 constant GTZC1_MPCBB3_SEC22             \ [0x16] SEC22
    $17 constant GTZC1_MPCBB3_SEC23             \ [0x17] SEC23
    $18 constant GTZC1_MPCBB3_SEC24             \ [0x18] SEC24
    $19 constant GTZC1_MPCBB3_SEC25             \ [0x19] SEC25
    $1a constant GTZC1_MPCBB3_SEC26             \ [0x1a] SEC26
    $1b constant GTZC1_MPCBB3_SEC27             \ [0x1b] SEC27
    $1c constant GTZC1_MPCBB3_SEC28             \ [0x1c] SEC28
    $1d constant GTZC1_MPCBB3_SEC29             \ [0x1d] SEC29
    $1e constant GTZC1_MPCBB3_SEC30             \ [0x1e] SEC30
    $1f constant GTZC1_MPCBB3_SEC31             \ [0x1f] SEC31
  [then]


  [ifdef] GTZC1_MPCBB3_MPCBB3_SECCFGR1_DEF
    \
    \ @brief MPCBBx security configuration for super-block x register
    \ Address offset: 0x104
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GTZC1_MPCBB3_SEC0              \ [0x00] SEC0
    $01 constant GTZC1_MPCBB3_SEC1              \ [0x01] SEC1
    $02 constant GTZC1_MPCBB3_SEC2              \ [0x02] SEC2
    $03 constant GTZC1_MPCBB3_SEC3              \ [0x03] SEC3
    $04 constant GTZC1_MPCBB3_SEC4              \ [0x04] SEC4
    $05 constant GTZC1_MPCBB3_SEC5              \ [0x05] SEC5
    $06 constant GTZC1_MPCBB3_SEC6              \ [0x06] SEC6
    $07 constant GTZC1_MPCBB3_SEC7              \ [0x07] SEC7
    $08 constant GTZC1_MPCBB3_SEC8              \ [0x08] SEC8
    $09 constant GTZC1_MPCBB3_SEC9              \ [0x09] SEC9
    $0a constant GTZC1_MPCBB3_SEC10             \ [0x0a] SEC10
    $0b constant GTZC1_MPCBB3_SEC11             \ [0x0b] SEC11
    $0c constant GTZC1_MPCBB3_SEC12             \ [0x0c] SEC12
    $0d constant GTZC1_MPCBB3_SEC13             \ [0x0d] SEC13
    $0e constant GTZC1_MPCBB3_SEC14             \ [0x0e] SEC14
    $0f constant GTZC1_MPCBB3_SEC15             \ [0x0f] SEC15
    $10 constant GTZC1_MPCBB3_SEC16             \ [0x10] SEC16
    $11 constant GTZC1_MPCBB3_SEC17             \ [0x11] SEC17
    $12 constant GTZC1_MPCBB3_SEC18             \ [0x12] SEC18
    $13 constant GTZC1_MPCBB3_SEC19             \ [0x13] SEC19
    $14 constant GTZC1_MPCBB3_SEC20             \ [0x14] SEC20
    $15 constant GTZC1_MPCBB3_SEC21             \ [0x15] SEC21
    $16 constant GTZC1_MPCBB3_SEC22             \ [0x16] SEC22
    $17 constant GTZC1_MPCBB3_SEC23             \ [0x17] SEC23
    $18 constant GTZC1_MPCBB3_SEC24             \ [0x18] SEC24
    $19 constant GTZC1_MPCBB3_SEC25             \ [0x19] SEC25
    $1a constant GTZC1_MPCBB3_SEC26             \ [0x1a] SEC26
    $1b constant GTZC1_MPCBB3_SEC27             \ [0x1b] SEC27
    $1c constant GTZC1_MPCBB3_SEC28             \ [0x1c] SEC28
    $1d constant GTZC1_MPCBB3_SEC29             \ [0x1d] SEC29
    $1e constant GTZC1_MPCBB3_SEC30             \ [0x1e] SEC30
    $1f constant GTZC1_MPCBB3_SEC31             \ [0x1f] SEC31
  [then]


  [ifdef] GTZC1_MPCBB3_MPCBB3_SECCFGR2_DEF
    \
    \ @brief MPCBBx security configuration for super-block x register
    \ Address offset: 0x108
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GTZC1_MPCBB3_SEC0              \ [0x00] SEC0
    $01 constant GTZC1_MPCBB3_SEC1              \ [0x01] SEC1
    $02 constant GTZC1_MPCBB3_SEC2              \ [0x02] SEC2
    $03 constant GTZC1_MPCBB3_SEC3              \ [0x03] SEC3
    $04 constant GTZC1_MPCBB3_SEC4              \ [0x04] SEC4
    $05 constant GTZC1_MPCBB3_SEC5              \ [0x05] SEC5
    $06 constant GTZC1_MPCBB3_SEC6              \ [0x06] SEC6
    $07 constant GTZC1_MPCBB3_SEC7              \ [0x07] SEC7
    $08 constant GTZC1_MPCBB3_SEC8              \ [0x08] SEC8
    $09 constant GTZC1_MPCBB3_SEC9              \ [0x09] SEC9
    $0a constant GTZC1_MPCBB3_SEC10             \ [0x0a] SEC10
    $0b constant GTZC1_MPCBB3_SEC11             \ [0x0b] SEC11
    $0c constant GTZC1_MPCBB3_SEC12             \ [0x0c] SEC12
    $0d constant GTZC1_MPCBB3_SEC13             \ [0x0d] SEC13
    $0e constant GTZC1_MPCBB3_SEC14             \ [0x0e] SEC14
    $0f constant GTZC1_MPCBB3_SEC15             \ [0x0f] SEC15
    $10 constant GTZC1_MPCBB3_SEC16             \ [0x10] SEC16
    $11 constant GTZC1_MPCBB3_SEC17             \ [0x11] SEC17
    $12 constant GTZC1_MPCBB3_SEC18             \ [0x12] SEC18
    $13 constant GTZC1_MPCBB3_SEC19             \ [0x13] SEC19
    $14 constant GTZC1_MPCBB3_SEC20             \ [0x14] SEC20
    $15 constant GTZC1_MPCBB3_SEC21             \ [0x15] SEC21
    $16 constant GTZC1_MPCBB3_SEC22             \ [0x16] SEC22
    $17 constant GTZC1_MPCBB3_SEC23             \ [0x17] SEC23
    $18 constant GTZC1_MPCBB3_SEC24             \ [0x18] SEC24
    $19 constant GTZC1_MPCBB3_SEC25             \ [0x19] SEC25
    $1a constant GTZC1_MPCBB3_SEC26             \ [0x1a] SEC26
    $1b constant GTZC1_MPCBB3_SEC27             \ [0x1b] SEC27
    $1c constant GTZC1_MPCBB3_SEC28             \ [0x1c] SEC28
    $1d constant GTZC1_MPCBB3_SEC29             \ [0x1d] SEC29
    $1e constant GTZC1_MPCBB3_SEC30             \ [0x1e] SEC30
    $1f constant GTZC1_MPCBB3_SEC31             \ [0x1f] SEC31
  [then]


  [ifdef] GTZC1_MPCBB3_MPCBB3_SECCFGR3_DEF
    \
    \ @brief MPCBBx security configuration for super-block x register
    \ Address offset: 0x10C
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GTZC1_MPCBB3_SEC0              \ [0x00] SEC0
    $01 constant GTZC1_MPCBB3_SEC1              \ [0x01] SEC1
    $02 constant GTZC1_MPCBB3_SEC2              \ [0x02] SEC2
    $03 constant GTZC1_MPCBB3_SEC3              \ [0x03] SEC3
    $04 constant GTZC1_MPCBB3_SEC4              \ [0x04] SEC4
    $05 constant GTZC1_MPCBB3_SEC5              \ [0x05] SEC5
    $06 constant GTZC1_MPCBB3_SEC6              \ [0x06] SEC6
    $07 constant GTZC1_MPCBB3_SEC7              \ [0x07] SEC7
    $08 constant GTZC1_MPCBB3_SEC8              \ [0x08] SEC8
    $09 constant GTZC1_MPCBB3_SEC9              \ [0x09] SEC9
    $0a constant GTZC1_MPCBB3_SEC10             \ [0x0a] SEC10
    $0b constant GTZC1_MPCBB3_SEC11             \ [0x0b] SEC11
    $0c constant GTZC1_MPCBB3_SEC12             \ [0x0c] SEC12
    $0d constant GTZC1_MPCBB3_SEC13             \ [0x0d] SEC13
    $0e constant GTZC1_MPCBB3_SEC14             \ [0x0e] SEC14
    $0f constant GTZC1_MPCBB3_SEC15             \ [0x0f] SEC15
    $10 constant GTZC1_MPCBB3_SEC16             \ [0x10] SEC16
    $11 constant GTZC1_MPCBB3_SEC17             \ [0x11] SEC17
    $12 constant GTZC1_MPCBB3_SEC18             \ [0x12] SEC18
    $13 constant GTZC1_MPCBB3_SEC19             \ [0x13] SEC19
    $14 constant GTZC1_MPCBB3_SEC20             \ [0x14] SEC20
    $15 constant GTZC1_MPCBB3_SEC21             \ [0x15] SEC21
    $16 constant GTZC1_MPCBB3_SEC22             \ [0x16] SEC22
    $17 constant GTZC1_MPCBB3_SEC23             \ [0x17] SEC23
    $18 constant GTZC1_MPCBB3_SEC24             \ [0x18] SEC24
    $19 constant GTZC1_MPCBB3_SEC25             \ [0x19] SEC25
    $1a constant GTZC1_MPCBB3_SEC26             \ [0x1a] SEC26
    $1b constant GTZC1_MPCBB3_SEC27             \ [0x1b] SEC27
    $1c constant GTZC1_MPCBB3_SEC28             \ [0x1c] SEC28
    $1d constant GTZC1_MPCBB3_SEC29             \ [0x1d] SEC29
    $1e constant GTZC1_MPCBB3_SEC30             \ [0x1e] SEC30
    $1f constant GTZC1_MPCBB3_SEC31             \ [0x1f] SEC31
  [then]


  [ifdef] GTZC1_MPCBB3_MPCBB3_SECCFGR4_DEF
    \
    \ @brief MPCBBx security configuration for super-block x register
    \ Address offset: 0x110
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GTZC1_MPCBB3_SEC0              \ [0x00] SEC0
    $01 constant GTZC1_MPCBB3_SEC1              \ [0x01] SEC1
    $02 constant GTZC1_MPCBB3_SEC2              \ [0x02] SEC2
    $03 constant GTZC1_MPCBB3_SEC3              \ [0x03] SEC3
    $04 constant GTZC1_MPCBB3_SEC4              \ [0x04] SEC4
    $05 constant GTZC1_MPCBB3_SEC5              \ [0x05] SEC5
    $06 constant GTZC1_MPCBB3_SEC6              \ [0x06] SEC6
    $07 constant GTZC1_MPCBB3_SEC7              \ [0x07] SEC7
    $08 constant GTZC1_MPCBB3_SEC8              \ [0x08] SEC8
    $09 constant GTZC1_MPCBB3_SEC9              \ [0x09] SEC9
    $0a constant GTZC1_MPCBB3_SEC10             \ [0x0a] SEC10
    $0b constant GTZC1_MPCBB3_SEC11             \ [0x0b] SEC11
    $0c constant GTZC1_MPCBB3_SEC12             \ [0x0c] SEC12
    $0d constant GTZC1_MPCBB3_SEC13             \ [0x0d] SEC13
    $0e constant GTZC1_MPCBB3_SEC14             \ [0x0e] SEC14
    $0f constant GTZC1_MPCBB3_SEC15             \ [0x0f] SEC15
    $10 constant GTZC1_MPCBB3_SEC16             \ [0x10] SEC16
    $11 constant GTZC1_MPCBB3_SEC17             \ [0x11] SEC17
    $12 constant GTZC1_MPCBB3_SEC18             \ [0x12] SEC18
    $13 constant GTZC1_MPCBB3_SEC19             \ [0x13] SEC19
    $14 constant GTZC1_MPCBB3_SEC20             \ [0x14] SEC20
    $15 constant GTZC1_MPCBB3_SEC21             \ [0x15] SEC21
    $16 constant GTZC1_MPCBB3_SEC22             \ [0x16] SEC22
    $17 constant GTZC1_MPCBB3_SEC23             \ [0x17] SEC23
    $18 constant GTZC1_MPCBB3_SEC24             \ [0x18] SEC24
    $19 constant GTZC1_MPCBB3_SEC25             \ [0x19] SEC25
    $1a constant GTZC1_MPCBB3_SEC26             \ [0x1a] SEC26
    $1b constant GTZC1_MPCBB3_SEC27             \ [0x1b] SEC27
    $1c constant GTZC1_MPCBB3_SEC28             \ [0x1c] SEC28
    $1d constant GTZC1_MPCBB3_SEC29             \ [0x1d] SEC29
    $1e constant GTZC1_MPCBB3_SEC30             \ [0x1e] SEC30
    $1f constant GTZC1_MPCBB3_SEC31             \ [0x1f] SEC31
  [then]


  [ifdef] GTZC1_MPCBB3_MPCBB3_SECCFGR5_DEF
    \
    \ @brief MPCBBx security configuration for super-block x register
    \ Address offset: 0x114
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GTZC1_MPCBB3_SEC0              \ [0x00] SEC0
    $01 constant GTZC1_MPCBB3_SEC1              \ [0x01] SEC1
    $02 constant GTZC1_MPCBB3_SEC2              \ [0x02] SEC2
    $03 constant GTZC1_MPCBB3_SEC3              \ [0x03] SEC3
    $04 constant GTZC1_MPCBB3_SEC4              \ [0x04] SEC4
    $05 constant GTZC1_MPCBB3_SEC5              \ [0x05] SEC5
    $06 constant GTZC1_MPCBB3_SEC6              \ [0x06] SEC6
    $07 constant GTZC1_MPCBB3_SEC7              \ [0x07] SEC7
    $08 constant GTZC1_MPCBB3_SEC8              \ [0x08] SEC8
    $09 constant GTZC1_MPCBB3_SEC9              \ [0x09] SEC9
    $0a constant GTZC1_MPCBB3_SEC10             \ [0x0a] SEC10
    $0b constant GTZC1_MPCBB3_SEC11             \ [0x0b] SEC11
    $0c constant GTZC1_MPCBB3_SEC12             \ [0x0c] SEC12
    $0d constant GTZC1_MPCBB3_SEC13             \ [0x0d] SEC13
    $0e constant GTZC1_MPCBB3_SEC14             \ [0x0e] SEC14
    $0f constant GTZC1_MPCBB3_SEC15             \ [0x0f] SEC15
    $10 constant GTZC1_MPCBB3_SEC16             \ [0x10] SEC16
    $11 constant GTZC1_MPCBB3_SEC17             \ [0x11] SEC17
    $12 constant GTZC1_MPCBB3_SEC18             \ [0x12] SEC18
    $13 constant GTZC1_MPCBB3_SEC19             \ [0x13] SEC19
    $14 constant GTZC1_MPCBB3_SEC20             \ [0x14] SEC20
    $15 constant GTZC1_MPCBB3_SEC21             \ [0x15] SEC21
    $16 constant GTZC1_MPCBB3_SEC22             \ [0x16] SEC22
    $17 constant GTZC1_MPCBB3_SEC23             \ [0x17] SEC23
    $18 constant GTZC1_MPCBB3_SEC24             \ [0x18] SEC24
    $19 constant GTZC1_MPCBB3_SEC25             \ [0x19] SEC25
    $1a constant GTZC1_MPCBB3_SEC26             \ [0x1a] SEC26
    $1b constant GTZC1_MPCBB3_SEC27             \ [0x1b] SEC27
    $1c constant GTZC1_MPCBB3_SEC28             \ [0x1c] SEC28
    $1d constant GTZC1_MPCBB3_SEC29             \ [0x1d] SEC29
    $1e constant GTZC1_MPCBB3_SEC30             \ [0x1e] SEC30
    $1f constant GTZC1_MPCBB3_SEC31             \ [0x1f] SEC31
  [then]


  [ifdef] GTZC1_MPCBB3_MPCBB3_SECCFGR6_DEF
    \
    \ @brief MPCBBx security configuration for super-block x register
    \ Address offset: 0x118
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GTZC1_MPCBB3_SEC0              \ [0x00] SEC0
    $01 constant GTZC1_MPCBB3_SEC1              \ [0x01] SEC1
    $02 constant GTZC1_MPCBB3_SEC2              \ [0x02] SEC2
    $03 constant GTZC1_MPCBB3_SEC3              \ [0x03] SEC3
    $04 constant GTZC1_MPCBB3_SEC4              \ [0x04] SEC4
    $05 constant GTZC1_MPCBB3_SEC5              \ [0x05] SEC5
    $06 constant GTZC1_MPCBB3_SEC6              \ [0x06] SEC6
    $07 constant GTZC1_MPCBB3_SEC7              \ [0x07] SEC7
    $08 constant GTZC1_MPCBB3_SEC8              \ [0x08] SEC8
    $09 constant GTZC1_MPCBB3_SEC9              \ [0x09] SEC9
    $0a constant GTZC1_MPCBB3_SEC10             \ [0x0a] SEC10
    $0b constant GTZC1_MPCBB3_SEC11             \ [0x0b] SEC11
    $0c constant GTZC1_MPCBB3_SEC12             \ [0x0c] SEC12
    $0d constant GTZC1_MPCBB3_SEC13             \ [0x0d] SEC13
    $0e constant GTZC1_MPCBB3_SEC14             \ [0x0e] SEC14
    $0f constant GTZC1_MPCBB3_SEC15             \ [0x0f] SEC15
    $10 constant GTZC1_MPCBB3_SEC16             \ [0x10] SEC16
    $11 constant GTZC1_MPCBB3_SEC17             \ [0x11] SEC17
    $12 constant GTZC1_MPCBB3_SEC18             \ [0x12] SEC18
    $13 constant GTZC1_MPCBB3_SEC19             \ [0x13] SEC19
    $14 constant GTZC1_MPCBB3_SEC20             \ [0x14] SEC20
    $15 constant GTZC1_MPCBB3_SEC21             \ [0x15] SEC21
    $16 constant GTZC1_MPCBB3_SEC22             \ [0x16] SEC22
    $17 constant GTZC1_MPCBB3_SEC23             \ [0x17] SEC23
    $18 constant GTZC1_MPCBB3_SEC24             \ [0x18] SEC24
    $19 constant GTZC1_MPCBB3_SEC25             \ [0x19] SEC25
    $1a constant GTZC1_MPCBB3_SEC26             \ [0x1a] SEC26
    $1b constant GTZC1_MPCBB3_SEC27             \ [0x1b] SEC27
    $1c constant GTZC1_MPCBB3_SEC28             \ [0x1c] SEC28
    $1d constant GTZC1_MPCBB3_SEC29             \ [0x1d] SEC29
    $1e constant GTZC1_MPCBB3_SEC30             \ [0x1e] SEC30
    $1f constant GTZC1_MPCBB3_SEC31             \ [0x1f] SEC31
  [then]


  [ifdef] GTZC1_MPCBB3_MPCBB3_SECCFGR7_DEF
    \
    \ @brief MPCBBx security configuration for super-block x register
    \ Address offset: 0x11C
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GTZC1_MPCBB3_SEC0              \ [0x00] SEC0
    $01 constant GTZC1_MPCBB3_SEC1              \ [0x01] SEC1
    $02 constant GTZC1_MPCBB3_SEC2              \ [0x02] SEC2
    $03 constant GTZC1_MPCBB3_SEC3              \ [0x03] SEC3
    $04 constant GTZC1_MPCBB3_SEC4              \ [0x04] SEC4
    $05 constant GTZC1_MPCBB3_SEC5              \ [0x05] SEC5
    $06 constant GTZC1_MPCBB3_SEC6              \ [0x06] SEC6
    $07 constant GTZC1_MPCBB3_SEC7              \ [0x07] SEC7
    $08 constant GTZC1_MPCBB3_SEC8              \ [0x08] SEC8
    $09 constant GTZC1_MPCBB3_SEC9              \ [0x09] SEC9
    $0a constant GTZC1_MPCBB3_SEC10             \ [0x0a] SEC10
    $0b constant GTZC1_MPCBB3_SEC11             \ [0x0b] SEC11
    $0c constant GTZC1_MPCBB3_SEC12             \ [0x0c] SEC12
    $0d constant GTZC1_MPCBB3_SEC13             \ [0x0d] SEC13
    $0e constant GTZC1_MPCBB3_SEC14             \ [0x0e] SEC14
    $0f constant GTZC1_MPCBB3_SEC15             \ [0x0f] SEC15
    $10 constant GTZC1_MPCBB3_SEC16             \ [0x10] SEC16
    $11 constant GTZC1_MPCBB3_SEC17             \ [0x11] SEC17
    $12 constant GTZC1_MPCBB3_SEC18             \ [0x12] SEC18
    $13 constant GTZC1_MPCBB3_SEC19             \ [0x13] SEC19
    $14 constant GTZC1_MPCBB3_SEC20             \ [0x14] SEC20
    $15 constant GTZC1_MPCBB3_SEC21             \ [0x15] SEC21
    $16 constant GTZC1_MPCBB3_SEC22             \ [0x16] SEC22
    $17 constant GTZC1_MPCBB3_SEC23             \ [0x17] SEC23
    $18 constant GTZC1_MPCBB3_SEC24             \ [0x18] SEC24
    $19 constant GTZC1_MPCBB3_SEC25             \ [0x19] SEC25
    $1a constant GTZC1_MPCBB3_SEC26             \ [0x1a] SEC26
    $1b constant GTZC1_MPCBB3_SEC27             \ [0x1b] SEC27
    $1c constant GTZC1_MPCBB3_SEC28             \ [0x1c] SEC28
    $1d constant GTZC1_MPCBB3_SEC29             \ [0x1d] SEC29
    $1e constant GTZC1_MPCBB3_SEC30             \ [0x1e] SEC30
    $1f constant GTZC1_MPCBB3_SEC31             \ [0x1f] SEC31
  [then]


  [ifdef] GTZC1_MPCBB3_MPCBB3_SECCFGR8_DEF
    \
    \ @brief MPCBBx security configuration for super-block x register
    \ Address offset: 0x120
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GTZC1_MPCBB3_SEC0              \ [0x00] SEC0
    $01 constant GTZC1_MPCBB3_SEC1              \ [0x01] SEC1
    $02 constant GTZC1_MPCBB3_SEC2              \ [0x02] SEC2
    $03 constant GTZC1_MPCBB3_SEC3              \ [0x03] SEC3
    $04 constant GTZC1_MPCBB3_SEC4              \ [0x04] SEC4
    $05 constant GTZC1_MPCBB3_SEC5              \ [0x05] SEC5
    $06 constant GTZC1_MPCBB3_SEC6              \ [0x06] SEC6
    $07 constant GTZC1_MPCBB3_SEC7              \ [0x07] SEC7
    $08 constant GTZC1_MPCBB3_SEC8              \ [0x08] SEC8
    $09 constant GTZC1_MPCBB3_SEC9              \ [0x09] SEC9
    $0a constant GTZC1_MPCBB3_SEC10             \ [0x0a] SEC10
    $0b constant GTZC1_MPCBB3_SEC11             \ [0x0b] SEC11
    $0c constant GTZC1_MPCBB3_SEC12             \ [0x0c] SEC12
    $0d constant GTZC1_MPCBB3_SEC13             \ [0x0d] SEC13
    $0e constant GTZC1_MPCBB3_SEC14             \ [0x0e] SEC14
    $0f constant GTZC1_MPCBB3_SEC15             \ [0x0f] SEC15
    $10 constant GTZC1_MPCBB3_SEC16             \ [0x10] SEC16
    $11 constant GTZC1_MPCBB3_SEC17             \ [0x11] SEC17
    $12 constant GTZC1_MPCBB3_SEC18             \ [0x12] SEC18
    $13 constant GTZC1_MPCBB3_SEC19             \ [0x13] SEC19
    $14 constant GTZC1_MPCBB3_SEC20             \ [0x14] SEC20
    $15 constant GTZC1_MPCBB3_SEC21             \ [0x15] SEC21
    $16 constant GTZC1_MPCBB3_SEC22             \ [0x16] SEC22
    $17 constant GTZC1_MPCBB3_SEC23             \ [0x17] SEC23
    $18 constant GTZC1_MPCBB3_SEC24             \ [0x18] SEC24
    $19 constant GTZC1_MPCBB3_SEC25             \ [0x19] SEC25
    $1a constant GTZC1_MPCBB3_SEC26             \ [0x1a] SEC26
    $1b constant GTZC1_MPCBB3_SEC27             \ [0x1b] SEC27
    $1c constant GTZC1_MPCBB3_SEC28             \ [0x1c] SEC28
    $1d constant GTZC1_MPCBB3_SEC29             \ [0x1d] SEC29
    $1e constant GTZC1_MPCBB3_SEC30             \ [0x1e] SEC30
    $1f constant GTZC1_MPCBB3_SEC31             \ [0x1f] SEC31
  [then]


  [ifdef] GTZC1_MPCBB3_MPCBB3_SECCFGR9_DEF
    \
    \ @brief MPCBBx security configuration for super-block x register
    \ Address offset: 0x124
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GTZC1_MPCBB3_SEC0              \ [0x00] SEC0
    $01 constant GTZC1_MPCBB3_SEC1              \ [0x01] SEC1
    $02 constant GTZC1_MPCBB3_SEC2              \ [0x02] SEC2
    $03 constant GTZC1_MPCBB3_SEC3              \ [0x03] SEC3
    $04 constant GTZC1_MPCBB3_SEC4              \ [0x04] SEC4
    $05 constant GTZC1_MPCBB3_SEC5              \ [0x05] SEC5
    $06 constant GTZC1_MPCBB3_SEC6              \ [0x06] SEC6
    $07 constant GTZC1_MPCBB3_SEC7              \ [0x07] SEC7
    $08 constant GTZC1_MPCBB3_SEC8              \ [0x08] SEC8
    $09 constant GTZC1_MPCBB3_SEC9              \ [0x09] SEC9
    $0a constant GTZC1_MPCBB3_SEC10             \ [0x0a] SEC10
    $0b constant GTZC1_MPCBB3_SEC11             \ [0x0b] SEC11
    $0c constant GTZC1_MPCBB3_SEC12             \ [0x0c] SEC12
    $0d constant GTZC1_MPCBB3_SEC13             \ [0x0d] SEC13
    $0e constant GTZC1_MPCBB3_SEC14             \ [0x0e] SEC14
    $0f constant GTZC1_MPCBB3_SEC15             \ [0x0f] SEC15
    $10 constant GTZC1_MPCBB3_SEC16             \ [0x10] SEC16
    $11 constant GTZC1_MPCBB3_SEC17             \ [0x11] SEC17
    $12 constant GTZC1_MPCBB3_SEC18             \ [0x12] SEC18
    $13 constant GTZC1_MPCBB3_SEC19             \ [0x13] SEC19
    $14 constant GTZC1_MPCBB3_SEC20             \ [0x14] SEC20
    $15 constant GTZC1_MPCBB3_SEC21             \ [0x15] SEC21
    $16 constant GTZC1_MPCBB3_SEC22             \ [0x16] SEC22
    $17 constant GTZC1_MPCBB3_SEC23             \ [0x17] SEC23
    $18 constant GTZC1_MPCBB3_SEC24             \ [0x18] SEC24
    $19 constant GTZC1_MPCBB3_SEC25             \ [0x19] SEC25
    $1a constant GTZC1_MPCBB3_SEC26             \ [0x1a] SEC26
    $1b constant GTZC1_MPCBB3_SEC27             \ [0x1b] SEC27
    $1c constant GTZC1_MPCBB3_SEC28             \ [0x1c] SEC28
    $1d constant GTZC1_MPCBB3_SEC29             \ [0x1d] SEC29
    $1e constant GTZC1_MPCBB3_SEC30             \ [0x1e] SEC30
    $1f constant GTZC1_MPCBB3_SEC31             \ [0x1f] SEC31
  [then]


  [ifdef] GTZC1_MPCBB3_MPCBB3_SECCFGR10_DEF
    \
    \ @brief MPCBBx security configuration for super-block x register
    \ Address offset: 0x128
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GTZC1_MPCBB3_SEC0              \ [0x00] SEC0
    $01 constant GTZC1_MPCBB3_SEC1              \ [0x01] SEC1
    $02 constant GTZC1_MPCBB3_SEC2              \ [0x02] SEC2
    $03 constant GTZC1_MPCBB3_SEC3              \ [0x03] SEC3
    $04 constant GTZC1_MPCBB3_SEC4              \ [0x04] SEC4
    $05 constant GTZC1_MPCBB3_SEC5              \ [0x05] SEC5
    $06 constant GTZC1_MPCBB3_SEC6              \ [0x06] SEC6
    $07 constant GTZC1_MPCBB3_SEC7              \ [0x07] SEC7
    $08 constant GTZC1_MPCBB3_SEC8              \ [0x08] SEC8
    $09 constant GTZC1_MPCBB3_SEC9              \ [0x09] SEC9
    $0a constant GTZC1_MPCBB3_SEC10             \ [0x0a] SEC10
    $0b constant GTZC1_MPCBB3_SEC11             \ [0x0b] SEC11
    $0c constant GTZC1_MPCBB3_SEC12             \ [0x0c] SEC12
    $0d constant GTZC1_MPCBB3_SEC13             \ [0x0d] SEC13
    $0e constant GTZC1_MPCBB3_SEC14             \ [0x0e] SEC14
    $0f constant GTZC1_MPCBB3_SEC15             \ [0x0f] SEC15
    $10 constant GTZC1_MPCBB3_SEC16             \ [0x10] SEC16
    $11 constant GTZC1_MPCBB3_SEC17             \ [0x11] SEC17
    $12 constant GTZC1_MPCBB3_SEC18             \ [0x12] SEC18
    $13 constant GTZC1_MPCBB3_SEC19             \ [0x13] SEC19
    $14 constant GTZC1_MPCBB3_SEC20             \ [0x14] SEC20
    $15 constant GTZC1_MPCBB3_SEC21             \ [0x15] SEC21
    $16 constant GTZC1_MPCBB3_SEC22             \ [0x16] SEC22
    $17 constant GTZC1_MPCBB3_SEC23             \ [0x17] SEC23
    $18 constant GTZC1_MPCBB3_SEC24             \ [0x18] SEC24
    $19 constant GTZC1_MPCBB3_SEC25             \ [0x19] SEC25
    $1a constant GTZC1_MPCBB3_SEC26             \ [0x1a] SEC26
    $1b constant GTZC1_MPCBB3_SEC27             \ [0x1b] SEC27
    $1c constant GTZC1_MPCBB3_SEC28             \ [0x1c] SEC28
    $1d constant GTZC1_MPCBB3_SEC29             \ [0x1d] SEC29
    $1e constant GTZC1_MPCBB3_SEC30             \ [0x1e] SEC30
    $1f constant GTZC1_MPCBB3_SEC31             \ [0x1f] SEC31
  [then]


  [ifdef] GTZC1_MPCBB3_MPCBB3_SECCFGR11_DEF
    \
    \ @brief MPCBBx security configuration for super-block x register
    \ Address offset: 0x12C
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GTZC1_MPCBB3_SEC0              \ [0x00] SEC0
    $01 constant GTZC1_MPCBB3_SEC1              \ [0x01] SEC1
    $02 constant GTZC1_MPCBB3_SEC2              \ [0x02] SEC2
    $03 constant GTZC1_MPCBB3_SEC3              \ [0x03] SEC3
    $04 constant GTZC1_MPCBB3_SEC4              \ [0x04] SEC4
    $05 constant GTZC1_MPCBB3_SEC5              \ [0x05] SEC5
    $06 constant GTZC1_MPCBB3_SEC6              \ [0x06] SEC6
    $07 constant GTZC1_MPCBB3_SEC7              \ [0x07] SEC7
    $08 constant GTZC1_MPCBB3_SEC8              \ [0x08] SEC8
    $09 constant GTZC1_MPCBB3_SEC9              \ [0x09] SEC9
    $0a constant GTZC1_MPCBB3_SEC10             \ [0x0a] SEC10
    $0b constant GTZC1_MPCBB3_SEC11             \ [0x0b] SEC11
    $0c constant GTZC1_MPCBB3_SEC12             \ [0x0c] SEC12
    $0d constant GTZC1_MPCBB3_SEC13             \ [0x0d] SEC13
    $0e constant GTZC1_MPCBB3_SEC14             \ [0x0e] SEC14
    $0f constant GTZC1_MPCBB3_SEC15             \ [0x0f] SEC15
    $10 constant GTZC1_MPCBB3_SEC16             \ [0x10] SEC16
    $11 constant GTZC1_MPCBB3_SEC17             \ [0x11] SEC17
    $12 constant GTZC1_MPCBB3_SEC18             \ [0x12] SEC18
    $13 constant GTZC1_MPCBB3_SEC19             \ [0x13] SEC19
    $14 constant GTZC1_MPCBB3_SEC20             \ [0x14] SEC20
    $15 constant GTZC1_MPCBB3_SEC21             \ [0x15] SEC21
    $16 constant GTZC1_MPCBB3_SEC22             \ [0x16] SEC22
    $17 constant GTZC1_MPCBB3_SEC23             \ [0x17] SEC23
    $18 constant GTZC1_MPCBB3_SEC24             \ [0x18] SEC24
    $19 constant GTZC1_MPCBB3_SEC25             \ [0x19] SEC25
    $1a constant GTZC1_MPCBB3_SEC26             \ [0x1a] SEC26
    $1b constant GTZC1_MPCBB3_SEC27             \ [0x1b] SEC27
    $1c constant GTZC1_MPCBB3_SEC28             \ [0x1c] SEC28
    $1d constant GTZC1_MPCBB3_SEC29             \ [0x1d] SEC29
    $1e constant GTZC1_MPCBB3_SEC30             \ [0x1e] SEC30
    $1f constant GTZC1_MPCBB3_SEC31             \ [0x1f] SEC31
  [then]


  [ifdef] GTZC1_MPCBB3_MPCBB3_SECCFGR12_DEF
    \
    \ @brief MPCBBx security configuration for super-block x register
    \ Address offset: 0x130
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GTZC1_MPCBB3_SEC0              \ [0x00] SEC0
    $01 constant GTZC1_MPCBB3_SEC1              \ [0x01] SEC1
    $02 constant GTZC1_MPCBB3_SEC2              \ [0x02] SEC2
    $03 constant GTZC1_MPCBB3_SEC3              \ [0x03] SEC3
    $04 constant GTZC1_MPCBB3_SEC4              \ [0x04] SEC4
    $05 constant GTZC1_MPCBB3_SEC5              \ [0x05] SEC5
    $06 constant GTZC1_MPCBB3_SEC6              \ [0x06] SEC6
    $07 constant GTZC1_MPCBB3_SEC7              \ [0x07] SEC7
    $08 constant GTZC1_MPCBB3_SEC8              \ [0x08] SEC8
    $09 constant GTZC1_MPCBB3_SEC9              \ [0x09] SEC9
    $0a constant GTZC1_MPCBB3_SEC10             \ [0x0a] SEC10
    $0b constant GTZC1_MPCBB3_SEC11             \ [0x0b] SEC11
    $0c constant GTZC1_MPCBB3_SEC12             \ [0x0c] SEC12
    $0d constant GTZC1_MPCBB3_SEC13             \ [0x0d] SEC13
    $0e constant GTZC1_MPCBB3_SEC14             \ [0x0e] SEC14
    $0f constant GTZC1_MPCBB3_SEC15             \ [0x0f] SEC15
    $10 constant GTZC1_MPCBB3_SEC16             \ [0x10] SEC16
    $11 constant GTZC1_MPCBB3_SEC17             \ [0x11] SEC17
    $12 constant GTZC1_MPCBB3_SEC18             \ [0x12] SEC18
    $13 constant GTZC1_MPCBB3_SEC19             \ [0x13] SEC19
    $14 constant GTZC1_MPCBB3_SEC20             \ [0x14] SEC20
    $15 constant GTZC1_MPCBB3_SEC21             \ [0x15] SEC21
    $16 constant GTZC1_MPCBB3_SEC22             \ [0x16] SEC22
    $17 constant GTZC1_MPCBB3_SEC23             \ [0x17] SEC23
    $18 constant GTZC1_MPCBB3_SEC24             \ [0x18] SEC24
    $19 constant GTZC1_MPCBB3_SEC25             \ [0x19] SEC25
    $1a constant GTZC1_MPCBB3_SEC26             \ [0x1a] SEC26
    $1b constant GTZC1_MPCBB3_SEC27             \ [0x1b] SEC27
    $1c constant GTZC1_MPCBB3_SEC28             \ [0x1c] SEC28
    $1d constant GTZC1_MPCBB3_SEC29             \ [0x1d] SEC29
    $1e constant GTZC1_MPCBB3_SEC30             \ [0x1e] SEC30
    $1f constant GTZC1_MPCBB3_SEC31             \ [0x1f] SEC31
  [then]


  [ifdef] GTZC1_MPCBB3_MPCBB3_SECCFGR13_DEF
    \
    \ @brief MPCBBx security configuration for super-block x register
    \ Address offset: 0x134
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GTZC1_MPCBB3_SEC0              \ [0x00] SEC0
    $01 constant GTZC1_MPCBB3_SEC1              \ [0x01] SEC1
    $02 constant GTZC1_MPCBB3_SEC2              \ [0x02] SEC2
    $03 constant GTZC1_MPCBB3_SEC3              \ [0x03] SEC3
    $04 constant GTZC1_MPCBB3_SEC4              \ [0x04] SEC4
    $05 constant GTZC1_MPCBB3_SEC5              \ [0x05] SEC5
    $06 constant GTZC1_MPCBB3_SEC6              \ [0x06] SEC6
    $07 constant GTZC1_MPCBB3_SEC7              \ [0x07] SEC7
    $08 constant GTZC1_MPCBB3_SEC8              \ [0x08] SEC8
    $09 constant GTZC1_MPCBB3_SEC9              \ [0x09] SEC9
    $0a constant GTZC1_MPCBB3_SEC10             \ [0x0a] SEC10
    $0b constant GTZC1_MPCBB3_SEC11             \ [0x0b] SEC11
    $0c constant GTZC1_MPCBB3_SEC12             \ [0x0c] SEC12
    $0d constant GTZC1_MPCBB3_SEC13             \ [0x0d] SEC13
    $0e constant GTZC1_MPCBB3_SEC14             \ [0x0e] SEC14
    $0f constant GTZC1_MPCBB3_SEC15             \ [0x0f] SEC15
    $10 constant GTZC1_MPCBB3_SEC16             \ [0x10] SEC16
    $11 constant GTZC1_MPCBB3_SEC17             \ [0x11] SEC17
    $12 constant GTZC1_MPCBB3_SEC18             \ [0x12] SEC18
    $13 constant GTZC1_MPCBB3_SEC19             \ [0x13] SEC19
    $14 constant GTZC1_MPCBB3_SEC20             \ [0x14] SEC20
    $15 constant GTZC1_MPCBB3_SEC21             \ [0x15] SEC21
    $16 constant GTZC1_MPCBB3_SEC22             \ [0x16] SEC22
    $17 constant GTZC1_MPCBB3_SEC23             \ [0x17] SEC23
    $18 constant GTZC1_MPCBB3_SEC24             \ [0x18] SEC24
    $19 constant GTZC1_MPCBB3_SEC25             \ [0x19] SEC25
    $1a constant GTZC1_MPCBB3_SEC26             \ [0x1a] SEC26
    $1b constant GTZC1_MPCBB3_SEC27             \ [0x1b] SEC27
    $1c constant GTZC1_MPCBB3_SEC28             \ [0x1c] SEC28
    $1d constant GTZC1_MPCBB3_SEC29             \ [0x1d] SEC29
    $1e constant GTZC1_MPCBB3_SEC30             \ [0x1e] SEC30
    $1f constant GTZC1_MPCBB3_SEC31             \ [0x1f] SEC31
  [then]


  [ifdef] GTZC1_MPCBB3_MPCBB3_SECCFGR14_DEF
    \
    \ @brief MPCBBx security configuration for super-block x register
    \ Address offset: 0x138
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GTZC1_MPCBB3_SEC0              \ [0x00] SEC0
    $01 constant GTZC1_MPCBB3_SEC1              \ [0x01] SEC1
    $02 constant GTZC1_MPCBB3_SEC2              \ [0x02] SEC2
    $03 constant GTZC1_MPCBB3_SEC3              \ [0x03] SEC3
    $04 constant GTZC1_MPCBB3_SEC4              \ [0x04] SEC4
    $05 constant GTZC1_MPCBB3_SEC5              \ [0x05] SEC5
    $06 constant GTZC1_MPCBB3_SEC6              \ [0x06] SEC6
    $07 constant GTZC1_MPCBB3_SEC7              \ [0x07] SEC7
    $08 constant GTZC1_MPCBB3_SEC8              \ [0x08] SEC8
    $09 constant GTZC1_MPCBB3_SEC9              \ [0x09] SEC9
    $0a constant GTZC1_MPCBB3_SEC10             \ [0x0a] SEC10
    $0b constant GTZC1_MPCBB3_SEC11             \ [0x0b] SEC11
    $0c constant GTZC1_MPCBB3_SEC12             \ [0x0c] SEC12
    $0d constant GTZC1_MPCBB3_SEC13             \ [0x0d] SEC13
    $0e constant GTZC1_MPCBB3_SEC14             \ [0x0e] SEC14
    $0f constant GTZC1_MPCBB3_SEC15             \ [0x0f] SEC15
    $10 constant GTZC1_MPCBB3_SEC16             \ [0x10] SEC16
    $11 constant GTZC1_MPCBB3_SEC17             \ [0x11] SEC17
    $12 constant GTZC1_MPCBB3_SEC18             \ [0x12] SEC18
    $13 constant GTZC1_MPCBB3_SEC19             \ [0x13] SEC19
    $14 constant GTZC1_MPCBB3_SEC20             \ [0x14] SEC20
    $15 constant GTZC1_MPCBB3_SEC21             \ [0x15] SEC21
    $16 constant GTZC1_MPCBB3_SEC22             \ [0x16] SEC22
    $17 constant GTZC1_MPCBB3_SEC23             \ [0x17] SEC23
    $18 constant GTZC1_MPCBB3_SEC24             \ [0x18] SEC24
    $19 constant GTZC1_MPCBB3_SEC25             \ [0x19] SEC25
    $1a constant GTZC1_MPCBB3_SEC26             \ [0x1a] SEC26
    $1b constant GTZC1_MPCBB3_SEC27             \ [0x1b] SEC27
    $1c constant GTZC1_MPCBB3_SEC28             \ [0x1c] SEC28
    $1d constant GTZC1_MPCBB3_SEC29             \ [0x1d] SEC29
    $1e constant GTZC1_MPCBB3_SEC30             \ [0x1e] SEC30
    $1f constant GTZC1_MPCBB3_SEC31             \ [0x1f] SEC31
  [then]


  [ifdef] GTZC1_MPCBB3_MPCBB3_SECCFGR15_DEF
    \
    \ @brief MPCBBx security configuration for super-block x register
    \ Address offset: 0x13C
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GTZC1_MPCBB3_SEC0              \ [0x00] SEC0
    $01 constant GTZC1_MPCBB3_SEC1              \ [0x01] SEC1
    $02 constant GTZC1_MPCBB3_SEC2              \ [0x02] SEC2
    $03 constant GTZC1_MPCBB3_SEC3              \ [0x03] SEC3
    $04 constant GTZC1_MPCBB3_SEC4              \ [0x04] SEC4
    $05 constant GTZC1_MPCBB3_SEC5              \ [0x05] SEC5
    $06 constant GTZC1_MPCBB3_SEC6              \ [0x06] SEC6
    $07 constant GTZC1_MPCBB3_SEC7              \ [0x07] SEC7
    $08 constant GTZC1_MPCBB3_SEC8              \ [0x08] SEC8
    $09 constant GTZC1_MPCBB3_SEC9              \ [0x09] SEC9
    $0a constant GTZC1_MPCBB3_SEC10             \ [0x0a] SEC10
    $0b constant GTZC1_MPCBB3_SEC11             \ [0x0b] SEC11
    $0c constant GTZC1_MPCBB3_SEC12             \ [0x0c] SEC12
    $0d constant GTZC1_MPCBB3_SEC13             \ [0x0d] SEC13
    $0e constant GTZC1_MPCBB3_SEC14             \ [0x0e] SEC14
    $0f constant GTZC1_MPCBB3_SEC15             \ [0x0f] SEC15
    $10 constant GTZC1_MPCBB3_SEC16             \ [0x10] SEC16
    $11 constant GTZC1_MPCBB3_SEC17             \ [0x11] SEC17
    $12 constant GTZC1_MPCBB3_SEC18             \ [0x12] SEC18
    $13 constant GTZC1_MPCBB3_SEC19             \ [0x13] SEC19
    $14 constant GTZC1_MPCBB3_SEC20             \ [0x14] SEC20
    $15 constant GTZC1_MPCBB3_SEC21             \ [0x15] SEC21
    $16 constant GTZC1_MPCBB3_SEC22             \ [0x16] SEC22
    $17 constant GTZC1_MPCBB3_SEC23             \ [0x17] SEC23
    $18 constant GTZC1_MPCBB3_SEC24             \ [0x18] SEC24
    $19 constant GTZC1_MPCBB3_SEC25             \ [0x19] SEC25
    $1a constant GTZC1_MPCBB3_SEC26             \ [0x1a] SEC26
    $1b constant GTZC1_MPCBB3_SEC27             \ [0x1b] SEC27
    $1c constant GTZC1_MPCBB3_SEC28             \ [0x1c] SEC28
    $1d constant GTZC1_MPCBB3_SEC29             \ [0x1d] SEC29
    $1e constant GTZC1_MPCBB3_SEC30             \ [0x1e] SEC30
    $1f constant GTZC1_MPCBB3_SEC31             \ [0x1f] SEC31
  [then]


  [ifdef] GTZC1_MPCBB3_MPCBB3_SECCFGR16_DEF
    \
    \ @brief MPCBBx security configuration for super-block x register
    \ Address offset: 0x140
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GTZC1_MPCBB3_SEC0              \ [0x00] SEC0
    $01 constant GTZC1_MPCBB3_SEC1              \ [0x01] SEC1
    $02 constant GTZC1_MPCBB3_SEC2              \ [0x02] SEC2
    $03 constant GTZC1_MPCBB3_SEC3              \ [0x03] SEC3
    $04 constant GTZC1_MPCBB3_SEC4              \ [0x04] SEC4
    $05 constant GTZC1_MPCBB3_SEC5              \ [0x05] SEC5
    $06 constant GTZC1_MPCBB3_SEC6              \ [0x06] SEC6
    $07 constant GTZC1_MPCBB3_SEC7              \ [0x07] SEC7
    $08 constant GTZC1_MPCBB3_SEC8              \ [0x08] SEC8
    $09 constant GTZC1_MPCBB3_SEC9              \ [0x09] SEC9
    $0a constant GTZC1_MPCBB3_SEC10             \ [0x0a] SEC10
    $0b constant GTZC1_MPCBB3_SEC11             \ [0x0b] SEC11
    $0c constant GTZC1_MPCBB3_SEC12             \ [0x0c] SEC12
    $0d constant GTZC1_MPCBB3_SEC13             \ [0x0d] SEC13
    $0e constant GTZC1_MPCBB3_SEC14             \ [0x0e] SEC14
    $0f constant GTZC1_MPCBB3_SEC15             \ [0x0f] SEC15
    $10 constant GTZC1_MPCBB3_SEC16             \ [0x10] SEC16
    $11 constant GTZC1_MPCBB3_SEC17             \ [0x11] SEC17
    $12 constant GTZC1_MPCBB3_SEC18             \ [0x12] SEC18
    $13 constant GTZC1_MPCBB3_SEC19             \ [0x13] SEC19
    $14 constant GTZC1_MPCBB3_SEC20             \ [0x14] SEC20
    $15 constant GTZC1_MPCBB3_SEC21             \ [0x15] SEC21
    $16 constant GTZC1_MPCBB3_SEC22             \ [0x16] SEC22
    $17 constant GTZC1_MPCBB3_SEC23             \ [0x17] SEC23
    $18 constant GTZC1_MPCBB3_SEC24             \ [0x18] SEC24
    $19 constant GTZC1_MPCBB3_SEC25             \ [0x19] SEC25
    $1a constant GTZC1_MPCBB3_SEC26             \ [0x1a] SEC26
    $1b constant GTZC1_MPCBB3_SEC27             \ [0x1b] SEC27
    $1c constant GTZC1_MPCBB3_SEC28             \ [0x1c] SEC28
    $1d constant GTZC1_MPCBB3_SEC29             \ [0x1d] SEC29
    $1e constant GTZC1_MPCBB3_SEC30             \ [0x1e] SEC30
    $1f constant GTZC1_MPCBB3_SEC31             \ [0x1f] SEC31
  [then]


  [ifdef] GTZC1_MPCBB3_MPCBB3_SECCFGR17_DEF
    \
    \ @brief MPCBBx security configuration for super-block x register
    \ Address offset: 0x144
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GTZC1_MPCBB3_SEC0              \ [0x00] SEC0
    $01 constant GTZC1_MPCBB3_SEC1              \ [0x01] SEC1
    $02 constant GTZC1_MPCBB3_SEC2              \ [0x02] SEC2
    $03 constant GTZC1_MPCBB3_SEC3              \ [0x03] SEC3
    $04 constant GTZC1_MPCBB3_SEC4              \ [0x04] SEC4
    $05 constant GTZC1_MPCBB3_SEC5              \ [0x05] SEC5
    $06 constant GTZC1_MPCBB3_SEC6              \ [0x06] SEC6
    $07 constant GTZC1_MPCBB3_SEC7              \ [0x07] SEC7
    $08 constant GTZC1_MPCBB3_SEC8              \ [0x08] SEC8
    $09 constant GTZC1_MPCBB3_SEC9              \ [0x09] SEC9
    $0a constant GTZC1_MPCBB3_SEC10             \ [0x0a] SEC10
    $0b constant GTZC1_MPCBB3_SEC11             \ [0x0b] SEC11
    $0c constant GTZC1_MPCBB3_SEC12             \ [0x0c] SEC12
    $0d constant GTZC1_MPCBB3_SEC13             \ [0x0d] SEC13
    $0e constant GTZC1_MPCBB3_SEC14             \ [0x0e] SEC14
    $0f constant GTZC1_MPCBB3_SEC15             \ [0x0f] SEC15
    $10 constant GTZC1_MPCBB3_SEC16             \ [0x10] SEC16
    $11 constant GTZC1_MPCBB3_SEC17             \ [0x11] SEC17
    $12 constant GTZC1_MPCBB3_SEC18             \ [0x12] SEC18
    $13 constant GTZC1_MPCBB3_SEC19             \ [0x13] SEC19
    $14 constant GTZC1_MPCBB3_SEC20             \ [0x14] SEC20
    $15 constant GTZC1_MPCBB3_SEC21             \ [0x15] SEC21
    $16 constant GTZC1_MPCBB3_SEC22             \ [0x16] SEC22
    $17 constant GTZC1_MPCBB3_SEC23             \ [0x17] SEC23
    $18 constant GTZC1_MPCBB3_SEC24             \ [0x18] SEC24
    $19 constant GTZC1_MPCBB3_SEC25             \ [0x19] SEC25
    $1a constant GTZC1_MPCBB3_SEC26             \ [0x1a] SEC26
    $1b constant GTZC1_MPCBB3_SEC27             \ [0x1b] SEC27
    $1c constant GTZC1_MPCBB3_SEC28             \ [0x1c] SEC28
    $1d constant GTZC1_MPCBB3_SEC29             \ [0x1d] SEC29
    $1e constant GTZC1_MPCBB3_SEC30             \ [0x1e] SEC30
    $1f constant GTZC1_MPCBB3_SEC31             \ [0x1f] SEC31
  [then]


  [ifdef] GTZC1_MPCBB3_MPCBB3_SECCFGR18_DEF
    \
    \ @brief MPCBBx security configuration for super-block x register
    \ Address offset: 0x148
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GTZC1_MPCBB3_SEC0              \ [0x00] SEC0
    $01 constant GTZC1_MPCBB3_SEC1              \ [0x01] SEC1
    $02 constant GTZC1_MPCBB3_SEC2              \ [0x02] SEC2
    $03 constant GTZC1_MPCBB3_SEC3              \ [0x03] SEC3
    $04 constant GTZC1_MPCBB3_SEC4              \ [0x04] SEC4
    $05 constant GTZC1_MPCBB3_SEC5              \ [0x05] SEC5
    $06 constant GTZC1_MPCBB3_SEC6              \ [0x06] SEC6
    $07 constant GTZC1_MPCBB3_SEC7              \ [0x07] SEC7
    $08 constant GTZC1_MPCBB3_SEC8              \ [0x08] SEC8
    $09 constant GTZC1_MPCBB3_SEC9              \ [0x09] SEC9
    $0a constant GTZC1_MPCBB3_SEC10             \ [0x0a] SEC10
    $0b constant GTZC1_MPCBB3_SEC11             \ [0x0b] SEC11
    $0c constant GTZC1_MPCBB3_SEC12             \ [0x0c] SEC12
    $0d constant GTZC1_MPCBB3_SEC13             \ [0x0d] SEC13
    $0e constant GTZC1_MPCBB3_SEC14             \ [0x0e] SEC14
    $0f constant GTZC1_MPCBB3_SEC15             \ [0x0f] SEC15
    $10 constant GTZC1_MPCBB3_SEC16             \ [0x10] SEC16
    $11 constant GTZC1_MPCBB3_SEC17             \ [0x11] SEC17
    $12 constant GTZC1_MPCBB3_SEC18             \ [0x12] SEC18
    $13 constant GTZC1_MPCBB3_SEC19             \ [0x13] SEC19
    $14 constant GTZC1_MPCBB3_SEC20             \ [0x14] SEC20
    $15 constant GTZC1_MPCBB3_SEC21             \ [0x15] SEC21
    $16 constant GTZC1_MPCBB3_SEC22             \ [0x16] SEC22
    $17 constant GTZC1_MPCBB3_SEC23             \ [0x17] SEC23
    $18 constant GTZC1_MPCBB3_SEC24             \ [0x18] SEC24
    $19 constant GTZC1_MPCBB3_SEC25             \ [0x19] SEC25
    $1a constant GTZC1_MPCBB3_SEC26             \ [0x1a] SEC26
    $1b constant GTZC1_MPCBB3_SEC27             \ [0x1b] SEC27
    $1c constant GTZC1_MPCBB3_SEC28             \ [0x1c] SEC28
    $1d constant GTZC1_MPCBB3_SEC29             \ [0x1d] SEC29
    $1e constant GTZC1_MPCBB3_SEC30             \ [0x1e] SEC30
    $1f constant GTZC1_MPCBB3_SEC31             \ [0x1f] SEC31
  [then]


  [ifdef] GTZC1_MPCBB3_MPCBB3_SECCFGR19_DEF
    \
    \ @brief MPCBBx security configuration for super-block x register
    \ Address offset: 0x14C
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GTZC1_MPCBB3_SEC0              \ [0x00] SEC0
    $01 constant GTZC1_MPCBB3_SEC1              \ [0x01] SEC1
    $02 constant GTZC1_MPCBB3_SEC2              \ [0x02] SEC2
    $03 constant GTZC1_MPCBB3_SEC3              \ [0x03] SEC3
    $04 constant GTZC1_MPCBB3_SEC4              \ [0x04] SEC4
    $05 constant GTZC1_MPCBB3_SEC5              \ [0x05] SEC5
    $06 constant GTZC1_MPCBB3_SEC6              \ [0x06] SEC6
    $07 constant GTZC1_MPCBB3_SEC7              \ [0x07] SEC7
    $08 constant GTZC1_MPCBB3_SEC8              \ [0x08] SEC8
    $09 constant GTZC1_MPCBB3_SEC9              \ [0x09] SEC9
    $0a constant GTZC1_MPCBB3_SEC10             \ [0x0a] SEC10
    $0b constant GTZC1_MPCBB3_SEC11             \ [0x0b] SEC11
    $0c constant GTZC1_MPCBB3_SEC12             \ [0x0c] SEC12
    $0d constant GTZC1_MPCBB3_SEC13             \ [0x0d] SEC13
    $0e constant GTZC1_MPCBB3_SEC14             \ [0x0e] SEC14
    $0f constant GTZC1_MPCBB3_SEC15             \ [0x0f] SEC15
    $10 constant GTZC1_MPCBB3_SEC16             \ [0x10] SEC16
    $11 constant GTZC1_MPCBB3_SEC17             \ [0x11] SEC17
    $12 constant GTZC1_MPCBB3_SEC18             \ [0x12] SEC18
    $13 constant GTZC1_MPCBB3_SEC19             \ [0x13] SEC19
    $14 constant GTZC1_MPCBB3_SEC20             \ [0x14] SEC20
    $15 constant GTZC1_MPCBB3_SEC21             \ [0x15] SEC21
    $16 constant GTZC1_MPCBB3_SEC22             \ [0x16] SEC22
    $17 constant GTZC1_MPCBB3_SEC23             \ [0x17] SEC23
    $18 constant GTZC1_MPCBB3_SEC24             \ [0x18] SEC24
    $19 constant GTZC1_MPCBB3_SEC25             \ [0x19] SEC25
    $1a constant GTZC1_MPCBB3_SEC26             \ [0x1a] SEC26
    $1b constant GTZC1_MPCBB3_SEC27             \ [0x1b] SEC27
    $1c constant GTZC1_MPCBB3_SEC28             \ [0x1c] SEC28
    $1d constant GTZC1_MPCBB3_SEC29             \ [0x1d] SEC29
    $1e constant GTZC1_MPCBB3_SEC30             \ [0x1e] SEC30
    $1f constant GTZC1_MPCBB3_SEC31             \ [0x1f] SEC31
  [then]


  [ifdef] GTZC1_MPCBB3_MPCBB3_SECCFGR20_DEF
    \
    \ @brief MPCBBx security configuration for super-block x register
    \ Address offset: 0x150
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GTZC1_MPCBB3_SEC0              \ [0x00] SEC0
    $01 constant GTZC1_MPCBB3_SEC1              \ [0x01] SEC1
    $02 constant GTZC1_MPCBB3_SEC2              \ [0x02] SEC2
    $03 constant GTZC1_MPCBB3_SEC3              \ [0x03] SEC3
    $04 constant GTZC1_MPCBB3_SEC4              \ [0x04] SEC4
    $05 constant GTZC1_MPCBB3_SEC5              \ [0x05] SEC5
    $06 constant GTZC1_MPCBB3_SEC6              \ [0x06] SEC6
    $07 constant GTZC1_MPCBB3_SEC7              \ [0x07] SEC7
    $08 constant GTZC1_MPCBB3_SEC8              \ [0x08] SEC8
    $09 constant GTZC1_MPCBB3_SEC9              \ [0x09] SEC9
    $0a constant GTZC1_MPCBB3_SEC10             \ [0x0a] SEC10
    $0b constant GTZC1_MPCBB3_SEC11             \ [0x0b] SEC11
    $0c constant GTZC1_MPCBB3_SEC12             \ [0x0c] SEC12
    $0d constant GTZC1_MPCBB3_SEC13             \ [0x0d] SEC13
    $0e constant GTZC1_MPCBB3_SEC14             \ [0x0e] SEC14
    $0f constant GTZC1_MPCBB3_SEC15             \ [0x0f] SEC15
    $10 constant GTZC1_MPCBB3_SEC16             \ [0x10] SEC16
    $11 constant GTZC1_MPCBB3_SEC17             \ [0x11] SEC17
    $12 constant GTZC1_MPCBB3_SEC18             \ [0x12] SEC18
    $13 constant GTZC1_MPCBB3_SEC19             \ [0x13] SEC19
    $14 constant GTZC1_MPCBB3_SEC20             \ [0x14] SEC20
    $15 constant GTZC1_MPCBB3_SEC21             \ [0x15] SEC21
    $16 constant GTZC1_MPCBB3_SEC22             \ [0x16] SEC22
    $17 constant GTZC1_MPCBB3_SEC23             \ [0x17] SEC23
    $18 constant GTZC1_MPCBB3_SEC24             \ [0x18] SEC24
    $19 constant GTZC1_MPCBB3_SEC25             \ [0x19] SEC25
    $1a constant GTZC1_MPCBB3_SEC26             \ [0x1a] SEC26
    $1b constant GTZC1_MPCBB3_SEC27             \ [0x1b] SEC27
    $1c constant GTZC1_MPCBB3_SEC28             \ [0x1c] SEC28
    $1d constant GTZC1_MPCBB3_SEC29             \ [0x1d] SEC29
    $1e constant GTZC1_MPCBB3_SEC30             \ [0x1e] SEC30
    $1f constant GTZC1_MPCBB3_SEC31             \ [0x1f] SEC31
  [then]


  [ifdef] GTZC1_MPCBB3_MPCBB3_SECCFGR21_DEF
    \
    \ @brief MPCBBx security configuration for super-block x register
    \ Address offset: 0x154
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GTZC1_MPCBB3_SEC0              \ [0x00] SEC0
    $01 constant GTZC1_MPCBB3_SEC1              \ [0x01] SEC1
    $02 constant GTZC1_MPCBB3_SEC2              \ [0x02] SEC2
    $03 constant GTZC1_MPCBB3_SEC3              \ [0x03] SEC3
    $04 constant GTZC1_MPCBB3_SEC4              \ [0x04] SEC4
    $05 constant GTZC1_MPCBB3_SEC5              \ [0x05] SEC5
    $06 constant GTZC1_MPCBB3_SEC6              \ [0x06] SEC6
    $07 constant GTZC1_MPCBB3_SEC7              \ [0x07] SEC7
    $08 constant GTZC1_MPCBB3_SEC8              \ [0x08] SEC8
    $09 constant GTZC1_MPCBB3_SEC9              \ [0x09] SEC9
    $0a constant GTZC1_MPCBB3_SEC10             \ [0x0a] SEC10
    $0b constant GTZC1_MPCBB3_SEC11             \ [0x0b] SEC11
    $0c constant GTZC1_MPCBB3_SEC12             \ [0x0c] SEC12
    $0d constant GTZC1_MPCBB3_SEC13             \ [0x0d] SEC13
    $0e constant GTZC1_MPCBB3_SEC14             \ [0x0e] SEC14
    $0f constant GTZC1_MPCBB3_SEC15             \ [0x0f] SEC15
    $10 constant GTZC1_MPCBB3_SEC16             \ [0x10] SEC16
    $11 constant GTZC1_MPCBB3_SEC17             \ [0x11] SEC17
    $12 constant GTZC1_MPCBB3_SEC18             \ [0x12] SEC18
    $13 constant GTZC1_MPCBB3_SEC19             \ [0x13] SEC19
    $14 constant GTZC1_MPCBB3_SEC20             \ [0x14] SEC20
    $15 constant GTZC1_MPCBB3_SEC21             \ [0x15] SEC21
    $16 constant GTZC1_MPCBB3_SEC22             \ [0x16] SEC22
    $17 constant GTZC1_MPCBB3_SEC23             \ [0x17] SEC23
    $18 constant GTZC1_MPCBB3_SEC24             \ [0x18] SEC24
    $19 constant GTZC1_MPCBB3_SEC25             \ [0x19] SEC25
    $1a constant GTZC1_MPCBB3_SEC26             \ [0x1a] SEC26
    $1b constant GTZC1_MPCBB3_SEC27             \ [0x1b] SEC27
    $1c constant GTZC1_MPCBB3_SEC28             \ [0x1c] SEC28
    $1d constant GTZC1_MPCBB3_SEC29             \ [0x1d] SEC29
    $1e constant GTZC1_MPCBB3_SEC30             \ [0x1e] SEC30
    $1f constant GTZC1_MPCBB3_SEC31             \ [0x1f] SEC31
  [then]


  [ifdef] GTZC1_MPCBB3_MPCBB3_SECCFGR22_DEF
    \
    \ @brief MPCBBx security configuration for super-block x register
    \ Address offset: 0x158
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GTZC1_MPCBB3_SEC0              \ [0x00] SEC0
    $01 constant GTZC1_MPCBB3_SEC1              \ [0x01] SEC1
    $02 constant GTZC1_MPCBB3_SEC2              \ [0x02] SEC2
    $03 constant GTZC1_MPCBB3_SEC3              \ [0x03] SEC3
    $04 constant GTZC1_MPCBB3_SEC4              \ [0x04] SEC4
    $05 constant GTZC1_MPCBB3_SEC5              \ [0x05] SEC5
    $06 constant GTZC1_MPCBB3_SEC6              \ [0x06] SEC6
    $07 constant GTZC1_MPCBB3_SEC7              \ [0x07] SEC7
    $08 constant GTZC1_MPCBB3_SEC8              \ [0x08] SEC8
    $09 constant GTZC1_MPCBB3_SEC9              \ [0x09] SEC9
    $0a constant GTZC1_MPCBB3_SEC10             \ [0x0a] SEC10
    $0b constant GTZC1_MPCBB3_SEC11             \ [0x0b] SEC11
    $0c constant GTZC1_MPCBB3_SEC12             \ [0x0c] SEC12
    $0d constant GTZC1_MPCBB3_SEC13             \ [0x0d] SEC13
    $0e constant GTZC1_MPCBB3_SEC14             \ [0x0e] SEC14
    $0f constant GTZC1_MPCBB3_SEC15             \ [0x0f] SEC15
    $10 constant GTZC1_MPCBB3_SEC16             \ [0x10] SEC16
    $11 constant GTZC1_MPCBB3_SEC17             \ [0x11] SEC17
    $12 constant GTZC1_MPCBB3_SEC18             \ [0x12] SEC18
    $13 constant GTZC1_MPCBB3_SEC19             \ [0x13] SEC19
    $14 constant GTZC1_MPCBB3_SEC20             \ [0x14] SEC20
    $15 constant GTZC1_MPCBB3_SEC21             \ [0x15] SEC21
    $16 constant GTZC1_MPCBB3_SEC22             \ [0x16] SEC22
    $17 constant GTZC1_MPCBB3_SEC23             \ [0x17] SEC23
    $18 constant GTZC1_MPCBB3_SEC24             \ [0x18] SEC24
    $19 constant GTZC1_MPCBB3_SEC25             \ [0x19] SEC25
    $1a constant GTZC1_MPCBB3_SEC26             \ [0x1a] SEC26
    $1b constant GTZC1_MPCBB3_SEC27             \ [0x1b] SEC27
    $1c constant GTZC1_MPCBB3_SEC28             \ [0x1c] SEC28
    $1d constant GTZC1_MPCBB3_SEC29             \ [0x1d] SEC29
    $1e constant GTZC1_MPCBB3_SEC30             \ [0x1e] SEC30
    $1f constant GTZC1_MPCBB3_SEC31             \ [0x1f] SEC31
  [then]


  [ifdef] GTZC1_MPCBB3_MPCBB3_SECCFGR23_DEF
    \
    \ @brief MPCBBx security configuration for super-block x register
    \ Address offset: 0x15C
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GTZC1_MPCBB3_SEC0              \ [0x00] SEC0
    $01 constant GTZC1_MPCBB3_SEC1              \ [0x01] SEC1
    $02 constant GTZC1_MPCBB3_SEC2              \ [0x02] SEC2
    $03 constant GTZC1_MPCBB3_SEC3              \ [0x03] SEC3
    $04 constant GTZC1_MPCBB3_SEC4              \ [0x04] SEC4
    $05 constant GTZC1_MPCBB3_SEC5              \ [0x05] SEC5
    $06 constant GTZC1_MPCBB3_SEC6              \ [0x06] SEC6
    $07 constant GTZC1_MPCBB3_SEC7              \ [0x07] SEC7
    $08 constant GTZC1_MPCBB3_SEC8              \ [0x08] SEC8
    $09 constant GTZC1_MPCBB3_SEC9              \ [0x09] SEC9
    $0a constant GTZC1_MPCBB3_SEC10             \ [0x0a] SEC10
    $0b constant GTZC1_MPCBB3_SEC11             \ [0x0b] SEC11
    $0c constant GTZC1_MPCBB3_SEC12             \ [0x0c] SEC12
    $0d constant GTZC1_MPCBB3_SEC13             \ [0x0d] SEC13
    $0e constant GTZC1_MPCBB3_SEC14             \ [0x0e] SEC14
    $0f constant GTZC1_MPCBB3_SEC15             \ [0x0f] SEC15
    $10 constant GTZC1_MPCBB3_SEC16             \ [0x10] SEC16
    $11 constant GTZC1_MPCBB3_SEC17             \ [0x11] SEC17
    $12 constant GTZC1_MPCBB3_SEC18             \ [0x12] SEC18
    $13 constant GTZC1_MPCBB3_SEC19             \ [0x13] SEC19
    $14 constant GTZC1_MPCBB3_SEC20             \ [0x14] SEC20
    $15 constant GTZC1_MPCBB3_SEC21             \ [0x15] SEC21
    $16 constant GTZC1_MPCBB3_SEC22             \ [0x16] SEC22
    $17 constant GTZC1_MPCBB3_SEC23             \ [0x17] SEC23
    $18 constant GTZC1_MPCBB3_SEC24             \ [0x18] SEC24
    $19 constant GTZC1_MPCBB3_SEC25             \ [0x19] SEC25
    $1a constant GTZC1_MPCBB3_SEC26             \ [0x1a] SEC26
    $1b constant GTZC1_MPCBB3_SEC27             \ [0x1b] SEC27
    $1c constant GTZC1_MPCBB3_SEC28             \ [0x1c] SEC28
    $1d constant GTZC1_MPCBB3_SEC29             \ [0x1d] SEC29
    $1e constant GTZC1_MPCBB3_SEC30             \ [0x1e] SEC30
    $1f constant GTZC1_MPCBB3_SEC31             \ [0x1f] SEC31
  [then]


  [ifdef] GTZC1_MPCBB3_MPCBB3_SECCFGR24_DEF
    \
    \ @brief MPCBBx security configuration for super-block x register
    \ Address offset: 0x160
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GTZC1_MPCBB3_SEC0              \ [0x00] SEC0
    $01 constant GTZC1_MPCBB3_SEC1              \ [0x01] SEC1
    $02 constant GTZC1_MPCBB3_SEC2              \ [0x02] SEC2
    $03 constant GTZC1_MPCBB3_SEC3              \ [0x03] SEC3
    $04 constant GTZC1_MPCBB3_SEC4              \ [0x04] SEC4
    $05 constant GTZC1_MPCBB3_SEC5              \ [0x05] SEC5
    $06 constant GTZC1_MPCBB3_SEC6              \ [0x06] SEC6
    $07 constant GTZC1_MPCBB3_SEC7              \ [0x07] SEC7
    $08 constant GTZC1_MPCBB3_SEC8              \ [0x08] SEC8
    $09 constant GTZC1_MPCBB3_SEC9              \ [0x09] SEC9
    $0a constant GTZC1_MPCBB3_SEC10             \ [0x0a] SEC10
    $0b constant GTZC1_MPCBB3_SEC11             \ [0x0b] SEC11
    $0c constant GTZC1_MPCBB3_SEC12             \ [0x0c] SEC12
    $0d constant GTZC1_MPCBB3_SEC13             \ [0x0d] SEC13
    $0e constant GTZC1_MPCBB3_SEC14             \ [0x0e] SEC14
    $0f constant GTZC1_MPCBB3_SEC15             \ [0x0f] SEC15
    $10 constant GTZC1_MPCBB3_SEC16             \ [0x10] SEC16
    $11 constant GTZC1_MPCBB3_SEC17             \ [0x11] SEC17
    $12 constant GTZC1_MPCBB3_SEC18             \ [0x12] SEC18
    $13 constant GTZC1_MPCBB3_SEC19             \ [0x13] SEC19
    $14 constant GTZC1_MPCBB3_SEC20             \ [0x14] SEC20
    $15 constant GTZC1_MPCBB3_SEC21             \ [0x15] SEC21
    $16 constant GTZC1_MPCBB3_SEC22             \ [0x16] SEC22
    $17 constant GTZC1_MPCBB3_SEC23             \ [0x17] SEC23
    $18 constant GTZC1_MPCBB3_SEC24             \ [0x18] SEC24
    $19 constant GTZC1_MPCBB3_SEC25             \ [0x19] SEC25
    $1a constant GTZC1_MPCBB3_SEC26             \ [0x1a] SEC26
    $1b constant GTZC1_MPCBB3_SEC27             \ [0x1b] SEC27
    $1c constant GTZC1_MPCBB3_SEC28             \ [0x1c] SEC28
    $1d constant GTZC1_MPCBB3_SEC29             \ [0x1d] SEC29
    $1e constant GTZC1_MPCBB3_SEC30             \ [0x1e] SEC30
    $1f constant GTZC1_MPCBB3_SEC31             \ [0x1f] SEC31
  [then]


  [ifdef] GTZC1_MPCBB3_MPCBB3_SECCFGR25_DEF
    \
    \ @brief MPCBBx security configuration for super-block x register
    \ Address offset: 0x164
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GTZC1_MPCBB3_SEC0              \ [0x00] SEC0
    $01 constant GTZC1_MPCBB3_SEC1              \ [0x01] SEC1
    $02 constant GTZC1_MPCBB3_SEC2              \ [0x02] SEC2
    $03 constant GTZC1_MPCBB3_SEC3              \ [0x03] SEC3
    $04 constant GTZC1_MPCBB3_SEC4              \ [0x04] SEC4
    $05 constant GTZC1_MPCBB3_SEC5              \ [0x05] SEC5
    $06 constant GTZC1_MPCBB3_SEC6              \ [0x06] SEC6
    $07 constant GTZC1_MPCBB3_SEC7              \ [0x07] SEC7
    $08 constant GTZC1_MPCBB3_SEC8              \ [0x08] SEC8
    $09 constant GTZC1_MPCBB3_SEC9              \ [0x09] SEC9
    $0a constant GTZC1_MPCBB3_SEC10             \ [0x0a] SEC10
    $0b constant GTZC1_MPCBB3_SEC11             \ [0x0b] SEC11
    $0c constant GTZC1_MPCBB3_SEC12             \ [0x0c] SEC12
    $0d constant GTZC1_MPCBB3_SEC13             \ [0x0d] SEC13
    $0e constant GTZC1_MPCBB3_SEC14             \ [0x0e] SEC14
    $0f constant GTZC1_MPCBB3_SEC15             \ [0x0f] SEC15
    $10 constant GTZC1_MPCBB3_SEC16             \ [0x10] SEC16
    $11 constant GTZC1_MPCBB3_SEC17             \ [0x11] SEC17
    $12 constant GTZC1_MPCBB3_SEC18             \ [0x12] SEC18
    $13 constant GTZC1_MPCBB3_SEC19             \ [0x13] SEC19
    $14 constant GTZC1_MPCBB3_SEC20             \ [0x14] SEC20
    $15 constant GTZC1_MPCBB3_SEC21             \ [0x15] SEC21
    $16 constant GTZC1_MPCBB3_SEC22             \ [0x16] SEC22
    $17 constant GTZC1_MPCBB3_SEC23             \ [0x17] SEC23
    $18 constant GTZC1_MPCBB3_SEC24             \ [0x18] SEC24
    $19 constant GTZC1_MPCBB3_SEC25             \ [0x19] SEC25
    $1a constant GTZC1_MPCBB3_SEC26             \ [0x1a] SEC26
    $1b constant GTZC1_MPCBB3_SEC27             \ [0x1b] SEC27
    $1c constant GTZC1_MPCBB3_SEC28             \ [0x1c] SEC28
    $1d constant GTZC1_MPCBB3_SEC29             \ [0x1d] SEC29
    $1e constant GTZC1_MPCBB3_SEC30             \ [0x1e] SEC30
    $1f constant GTZC1_MPCBB3_SEC31             \ [0x1f] SEC31
  [then]


  [ifdef] GTZC1_MPCBB3_MPCBB3_SECCFGR26_DEF
    \
    \ @brief MPCBBx security configuration for super-block x register
    \ Address offset: 0x168
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GTZC1_MPCBB3_SEC0              \ [0x00] SEC0
    $01 constant GTZC1_MPCBB3_SEC1              \ [0x01] SEC1
    $02 constant GTZC1_MPCBB3_SEC2              \ [0x02] SEC2
    $03 constant GTZC1_MPCBB3_SEC3              \ [0x03] SEC3
    $04 constant GTZC1_MPCBB3_SEC4              \ [0x04] SEC4
    $05 constant GTZC1_MPCBB3_SEC5              \ [0x05] SEC5
    $06 constant GTZC1_MPCBB3_SEC6              \ [0x06] SEC6
    $07 constant GTZC1_MPCBB3_SEC7              \ [0x07] SEC7
    $08 constant GTZC1_MPCBB3_SEC8              \ [0x08] SEC8
    $09 constant GTZC1_MPCBB3_SEC9              \ [0x09] SEC9
    $0a constant GTZC1_MPCBB3_SEC10             \ [0x0a] SEC10
    $0b constant GTZC1_MPCBB3_SEC11             \ [0x0b] SEC11
    $0c constant GTZC1_MPCBB3_SEC12             \ [0x0c] SEC12
    $0d constant GTZC1_MPCBB3_SEC13             \ [0x0d] SEC13
    $0e constant GTZC1_MPCBB3_SEC14             \ [0x0e] SEC14
    $0f constant GTZC1_MPCBB3_SEC15             \ [0x0f] SEC15
    $10 constant GTZC1_MPCBB3_SEC16             \ [0x10] SEC16
    $11 constant GTZC1_MPCBB3_SEC17             \ [0x11] SEC17
    $12 constant GTZC1_MPCBB3_SEC18             \ [0x12] SEC18
    $13 constant GTZC1_MPCBB3_SEC19             \ [0x13] SEC19
    $14 constant GTZC1_MPCBB3_SEC20             \ [0x14] SEC20
    $15 constant GTZC1_MPCBB3_SEC21             \ [0x15] SEC21
    $16 constant GTZC1_MPCBB3_SEC22             \ [0x16] SEC22
    $17 constant GTZC1_MPCBB3_SEC23             \ [0x17] SEC23
    $18 constant GTZC1_MPCBB3_SEC24             \ [0x18] SEC24
    $19 constant GTZC1_MPCBB3_SEC25             \ [0x19] SEC25
    $1a constant GTZC1_MPCBB3_SEC26             \ [0x1a] SEC26
    $1b constant GTZC1_MPCBB3_SEC27             \ [0x1b] SEC27
    $1c constant GTZC1_MPCBB3_SEC28             \ [0x1c] SEC28
    $1d constant GTZC1_MPCBB3_SEC29             \ [0x1d] SEC29
    $1e constant GTZC1_MPCBB3_SEC30             \ [0x1e] SEC30
    $1f constant GTZC1_MPCBB3_SEC31             \ [0x1f] SEC31
  [then]


  [ifdef] GTZC1_MPCBB3_MPCBB3_SECCFGR27_DEF
    \
    \ @brief MPCBBx security configuration for super-block x register
    \ Address offset: 0x16C
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GTZC1_MPCBB3_SEC0              \ [0x00] SEC0
    $01 constant GTZC1_MPCBB3_SEC1              \ [0x01] SEC1
    $02 constant GTZC1_MPCBB3_SEC2              \ [0x02] SEC2
    $03 constant GTZC1_MPCBB3_SEC3              \ [0x03] SEC3
    $04 constant GTZC1_MPCBB3_SEC4              \ [0x04] SEC4
    $05 constant GTZC1_MPCBB3_SEC5              \ [0x05] SEC5
    $06 constant GTZC1_MPCBB3_SEC6              \ [0x06] SEC6
    $07 constant GTZC1_MPCBB3_SEC7              \ [0x07] SEC7
    $08 constant GTZC1_MPCBB3_SEC8              \ [0x08] SEC8
    $09 constant GTZC1_MPCBB3_SEC9              \ [0x09] SEC9
    $0a constant GTZC1_MPCBB3_SEC10             \ [0x0a] SEC10
    $0b constant GTZC1_MPCBB3_SEC11             \ [0x0b] SEC11
    $0c constant GTZC1_MPCBB3_SEC12             \ [0x0c] SEC12
    $0d constant GTZC1_MPCBB3_SEC13             \ [0x0d] SEC13
    $0e constant GTZC1_MPCBB3_SEC14             \ [0x0e] SEC14
    $0f constant GTZC1_MPCBB3_SEC15             \ [0x0f] SEC15
    $10 constant GTZC1_MPCBB3_SEC16             \ [0x10] SEC16
    $11 constant GTZC1_MPCBB3_SEC17             \ [0x11] SEC17
    $12 constant GTZC1_MPCBB3_SEC18             \ [0x12] SEC18
    $13 constant GTZC1_MPCBB3_SEC19             \ [0x13] SEC19
    $14 constant GTZC1_MPCBB3_SEC20             \ [0x14] SEC20
    $15 constant GTZC1_MPCBB3_SEC21             \ [0x15] SEC21
    $16 constant GTZC1_MPCBB3_SEC22             \ [0x16] SEC22
    $17 constant GTZC1_MPCBB3_SEC23             \ [0x17] SEC23
    $18 constant GTZC1_MPCBB3_SEC24             \ [0x18] SEC24
    $19 constant GTZC1_MPCBB3_SEC25             \ [0x19] SEC25
    $1a constant GTZC1_MPCBB3_SEC26             \ [0x1a] SEC26
    $1b constant GTZC1_MPCBB3_SEC27             \ [0x1b] SEC27
    $1c constant GTZC1_MPCBB3_SEC28             \ [0x1c] SEC28
    $1d constant GTZC1_MPCBB3_SEC29             \ [0x1d] SEC29
    $1e constant GTZC1_MPCBB3_SEC30             \ [0x1e] SEC30
    $1f constant GTZC1_MPCBB3_SEC31             \ [0x1f] SEC31
  [then]


  [ifdef] GTZC1_MPCBB3_MPCBB3_SECCFGR28_DEF
    \
    \ @brief MPCBBx security configuration for super-block x register
    \ Address offset: 0x170
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GTZC1_MPCBB3_SEC0              \ [0x00] SEC0
    $01 constant GTZC1_MPCBB3_SEC1              \ [0x01] SEC1
    $02 constant GTZC1_MPCBB3_SEC2              \ [0x02] SEC2
    $03 constant GTZC1_MPCBB3_SEC3              \ [0x03] SEC3
    $04 constant GTZC1_MPCBB3_SEC4              \ [0x04] SEC4
    $05 constant GTZC1_MPCBB3_SEC5              \ [0x05] SEC5
    $06 constant GTZC1_MPCBB3_SEC6              \ [0x06] SEC6
    $07 constant GTZC1_MPCBB3_SEC7              \ [0x07] SEC7
    $08 constant GTZC1_MPCBB3_SEC8              \ [0x08] SEC8
    $09 constant GTZC1_MPCBB3_SEC9              \ [0x09] SEC9
    $0a constant GTZC1_MPCBB3_SEC10             \ [0x0a] SEC10
    $0b constant GTZC1_MPCBB3_SEC11             \ [0x0b] SEC11
    $0c constant GTZC1_MPCBB3_SEC12             \ [0x0c] SEC12
    $0d constant GTZC1_MPCBB3_SEC13             \ [0x0d] SEC13
    $0e constant GTZC1_MPCBB3_SEC14             \ [0x0e] SEC14
    $0f constant GTZC1_MPCBB3_SEC15             \ [0x0f] SEC15
    $10 constant GTZC1_MPCBB3_SEC16             \ [0x10] SEC16
    $11 constant GTZC1_MPCBB3_SEC17             \ [0x11] SEC17
    $12 constant GTZC1_MPCBB3_SEC18             \ [0x12] SEC18
    $13 constant GTZC1_MPCBB3_SEC19             \ [0x13] SEC19
    $14 constant GTZC1_MPCBB3_SEC20             \ [0x14] SEC20
    $15 constant GTZC1_MPCBB3_SEC21             \ [0x15] SEC21
    $16 constant GTZC1_MPCBB3_SEC22             \ [0x16] SEC22
    $17 constant GTZC1_MPCBB3_SEC23             \ [0x17] SEC23
    $18 constant GTZC1_MPCBB3_SEC24             \ [0x18] SEC24
    $19 constant GTZC1_MPCBB3_SEC25             \ [0x19] SEC25
    $1a constant GTZC1_MPCBB3_SEC26             \ [0x1a] SEC26
    $1b constant GTZC1_MPCBB3_SEC27             \ [0x1b] SEC27
    $1c constant GTZC1_MPCBB3_SEC28             \ [0x1c] SEC28
    $1d constant GTZC1_MPCBB3_SEC29             \ [0x1d] SEC29
    $1e constant GTZC1_MPCBB3_SEC30             \ [0x1e] SEC30
    $1f constant GTZC1_MPCBB3_SEC31             \ [0x1f] SEC31
  [then]


  [ifdef] GTZC1_MPCBB3_MPCBB3_SECCFGR29_DEF
    \
    \ @brief MPCBBx security configuration for super-block x register
    \ Address offset: 0x174
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GTZC1_MPCBB3_SEC0              \ [0x00] SEC0
    $01 constant GTZC1_MPCBB3_SEC1              \ [0x01] SEC1
    $02 constant GTZC1_MPCBB3_SEC2              \ [0x02] SEC2
    $03 constant GTZC1_MPCBB3_SEC3              \ [0x03] SEC3
    $04 constant GTZC1_MPCBB3_SEC4              \ [0x04] SEC4
    $05 constant GTZC1_MPCBB3_SEC5              \ [0x05] SEC5
    $06 constant GTZC1_MPCBB3_SEC6              \ [0x06] SEC6
    $07 constant GTZC1_MPCBB3_SEC7              \ [0x07] SEC7
    $08 constant GTZC1_MPCBB3_SEC8              \ [0x08] SEC8
    $09 constant GTZC1_MPCBB3_SEC9              \ [0x09] SEC9
    $0a constant GTZC1_MPCBB3_SEC10             \ [0x0a] SEC10
    $0b constant GTZC1_MPCBB3_SEC11             \ [0x0b] SEC11
    $0c constant GTZC1_MPCBB3_SEC12             \ [0x0c] SEC12
    $0d constant GTZC1_MPCBB3_SEC13             \ [0x0d] SEC13
    $0e constant GTZC1_MPCBB3_SEC14             \ [0x0e] SEC14
    $0f constant GTZC1_MPCBB3_SEC15             \ [0x0f] SEC15
    $10 constant GTZC1_MPCBB3_SEC16             \ [0x10] SEC16
    $11 constant GTZC1_MPCBB3_SEC17             \ [0x11] SEC17
    $12 constant GTZC1_MPCBB3_SEC18             \ [0x12] SEC18
    $13 constant GTZC1_MPCBB3_SEC19             \ [0x13] SEC19
    $14 constant GTZC1_MPCBB3_SEC20             \ [0x14] SEC20
    $15 constant GTZC1_MPCBB3_SEC21             \ [0x15] SEC21
    $16 constant GTZC1_MPCBB3_SEC22             \ [0x16] SEC22
    $17 constant GTZC1_MPCBB3_SEC23             \ [0x17] SEC23
    $18 constant GTZC1_MPCBB3_SEC24             \ [0x18] SEC24
    $19 constant GTZC1_MPCBB3_SEC25             \ [0x19] SEC25
    $1a constant GTZC1_MPCBB3_SEC26             \ [0x1a] SEC26
    $1b constant GTZC1_MPCBB3_SEC27             \ [0x1b] SEC27
    $1c constant GTZC1_MPCBB3_SEC28             \ [0x1c] SEC28
    $1d constant GTZC1_MPCBB3_SEC29             \ [0x1d] SEC29
    $1e constant GTZC1_MPCBB3_SEC30             \ [0x1e] SEC30
    $1f constant GTZC1_MPCBB3_SEC31             \ [0x1f] SEC31
  [then]


  [ifdef] GTZC1_MPCBB3_MPCBB3_SECCFGR30_DEF
    \
    \ @brief MPCBBx security configuration for super-block x register
    \ Address offset: 0x178
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GTZC1_MPCBB3_SEC0              \ [0x00] SEC0
    $01 constant GTZC1_MPCBB3_SEC1              \ [0x01] SEC1
    $02 constant GTZC1_MPCBB3_SEC2              \ [0x02] SEC2
    $03 constant GTZC1_MPCBB3_SEC3              \ [0x03] SEC3
    $04 constant GTZC1_MPCBB3_SEC4              \ [0x04] SEC4
    $05 constant GTZC1_MPCBB3_SEC5              \ [0x05] SEC5
    $06 constant GTZC1_MPCBB3_SEC6              \ [0x06] SEC6
    $07 constant GTZC1_MPCBB3_SEC7              \ [0x07] SEC7
    $08 constant GTZC1_MPCBB3_SEC8              \ [0x08] SEC8
    $09 constant GTZC1_MPCBB3_SEC9              \ [0x09] SEC9
    $0a constant GTZC1_MPCBB3_SEC10             \ [0x0a] SEC10
    $0b constant GTZC1_MPCBB3_SEC11             \ [0x0b] SEC11
    $0c constant GTZC1_MPCBB3_SEC12             \ [0x0c] SEC12
    $0d constant GTZC1_MPCBB3_SEC13             \ [0x0d] SEC13
    $0e constant GTZC1_MPCBB3_SEC14             \ [0x0e] SEC14
    $0f constant GTZC1_MPCBB3_SEC15             \ [0x0f] SEC15
    $10 constant GTZC1_MPCBB3_SEC16             \ [0x10] SEC16
    $11 constant GTZC1_MPCBB3_SEC17             \ [0x11] SEC17
    $12 constant GTZC1_MPCBB3_SEC18             \ [0x12] SEC18
    $13 constant GTZC1_MPCBB3_SEC19             \ [0x13] SEC19
    $14 constant GTZC1_MPCBB3_SEC20             \ [0x14] SEC20
    $15 constant GTZC1_MPCBB3_SEC21             \ [0x15] SEC21
    $16 constant GTZC1_MPCBB3_SEC22             \ [0x16] SEC22
    $17 constant GTZC1_MPCBB3_SEC23             \ [0x17] SEC23
    $18 constant GTZC1_MPCBB3_SEC24             \ [0x18] SEC24
    $19 constant GTZC1_MPCBB3_SEC25             \ [0x19] SEC25
    $1a constant GTZC1_MPCBB3_SEC26             \ [0x1a] SEC26
    $1b constant GTZC1_MPCBB3_SEC27             \ [0x1b] SEC27
    $1c constant GTZC1_MPCBB3_SEC28             \ [0x1c] SEC28
    $1d constant GTZC1_MPCBB3_SEC29             \ [0x1d] SEC29
    $1e constant GTZC1_MPCBB3_SEC30             \ [0x1e] SEC30
    $1f constant GTZC1_MPCBB3_SEC31             \ [0x1f] SEC31
  [then]


  [ifdef] GTZC1_MPCBB3_MPCBB3_SECCFGR31_DEF
    \
    \ @brief MPCBBx security configuration for super-block x register
    \ Address offset: 0x17C
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GTZC1_MPCBB3_SEC0              \ [0x00] SEC0
    $01 constant GTZC1_MPCBB3_SEC1              \ [0x01] SEC1
    $02 constant GTZC1_MPCBB3_SEC2              \ [0x02] SEC2
    $03 constant GTZC1_MPCBB3_SEC3              \ [0x03] SEC3
    $04 constant GTZC1_MPCBB3_SEC4              \ [0x04] SEC4
    $05 constant GTZC1_MPCBB3_SEC5              \ [0x05] SEC5
    $06 constant GTZC1_MPCBB3_SEC6              \ [0x06] SEC6
    $07 constant GTZC1_MPCBB3_SEC7              \ [0x07] SEC7
    $08 constant GTZC1_MPCBB3_SEC8              \ [0x08] SEC8
    $09 constant GTZC1_MPCBB3_SEC9              \ [0x09] SEC9
    $0a constant GTZC1_MPCBB3_SEC10             \ [0x0a] SEC10
    $0b constant GTZC1_MPCBB3_SEC11             \ [0x0b] SEC11
    $0c constant GTZC1_MPCBB3_SEC12             \ [0x0c] SEC12
    $0d constant GTZC1_MPCBB3_SEC13             \ [0x0d] SEC13
    $0e constant GTZC1_MPCBB3_SEC14             \ [0x0e] SEC14
    $0f constant GTZC1_MPCBB3_SEC15             \ [0x0f] SEC15
    $10 constant GTZC1_MPCBB3_SEC16             \ [0x10] SEC16
    $11 constant GTZC1_MPCBB3_SEC17             \ [0x11] SEC17
    $12 constant GTZC1_MPCBB3_SEC18             \ [0x12] SEC18
    $13 constant GTZC1_MPCBB3_SEC19             \ [0x13] SEC19
    $14 constant GTZC1_MPCBB3_SEC20             \ [0x14] SEC20
    $15 constant GTZC1_MPCBB3_SEC21             \ [0x15] SEC21
    $16 constant GTZC1_MPCBB3_SEC22             \ [0x16] SEC22
    $17 constant GTZC1_MPCBB3_SEC23             \ [0x17] SEC23
    $18 constant GTZC1_MPCBB3_SEC24             \ [0x18] SEC24
    $19 constant GTZC1_MPCBB3_SEC25             \ [0x19] SEC25
    $1a constant GTZC1_MPCBB3_SEC26             \ [0x1a] SEC26
    $1b constant GTZC1_MPCBB3_SEC27             \ [0x1b] SEC27
    $1c constant GTZC1_MPCBB3_SEC28             \ [0x1c] SEC28
    $1d constant GTZC1_MPCBB3_SEC29             \ [0x1d] SEC29
    $1e constant GTZC1_MPCBB3_SEC30             \ [0x1e] SEC30
    $1f constant GTZC1_MPCBB3_SEC31             \ [0x1f] SEC31
  [then]


  [ifdef] GTZC1_MPCBB3_MPCBB3_SECCFGR32_DEF
    \
    \ @brief MPCBBx security configuration for super-block x register
    \ Address offset: 0x180
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GTZC1_MPCBB3_SEC0              \ [0x00] SEC0
    $01 constant GTZC1_MPCBB3_SEC1              \ [0x01] SEC1
    $02 constant GTZC1_MPCBB3_SEC2              \ [0x02] SEC2
    $03 constant GTZC1_MPCBB3_SEC3              \ [0x03] SEC3
    $04 constant GTZC1_MPCBB3_SEC4              \ [0x04] SEC4
    $05 constant GTZC1_MPCBB3_SEC5              \ [0x05] SEC5
    $06 constant GTZC1_MPCBB3_SEC6              \ [0x06] SEC6
    $07 constant GTZC1_MPCBB3_SEC7              \ [0x07] SEC7
    $08 constant GTZC1_MPCBB3_SEC8              \ [0x08] SEC8
    $09 constant GTZC1_MPCBB3_SEC9              \ [0x09] SEC9
    $0a constant GTZC1_MPCBB3_SEC10             \ [0x0a] SEC10
    $0b constant GTZC1_MPCBB3_SEC11             \ [0x0b] SEC11
    $0c constant GTZC1_MPCBB3_SEC12             \ [0x0c] SEC12
    $0d constant GTZC1_MPCBB3_SEC13             \ [0x0d] SEC13
    $0e constant GTZC1_MPCBB3_SEC14             \ [0x0e] SEC14
    $0f constant GTZC1_MPCBB3_SEC15             \ [0x0f] SEC15
    $10 constant GTZC1_MPCBB3_SEC16             \ [0x10] SEC16
    $11 constant GTZC1_MPCBB3_SEC17             \ [0x11] SEC17
    $12 constant GTZC1_MPCBB3_SEC18             \ [0x12] SEC18
    $13 constant GTZC1_MPCBB3_SEC19             \ [0x13] SEC19
    $14 constant GTZC1_MPCBB3_SEC20             \ [0x14] SEC20
    $15 constant GTZC1_MPCBB3_SEC21             \ [0x15] SEC21
    $16 constant GTZC1_MPCBB3_SEC22             \ [0x16] SEC22
    $17 constant GTZC1_MPCBB3_SEC23             \ [0x17] SEC23
    $18 constant GTZC1_MPCBB3_SEC24             \ [0x18] SEC24
    $19 constant GTZC1_MPCBB3_SEC25             \ [0x19] SEC25
    $1a constant GTZC1_MPCBB3_SEC26             \ [0x1a] SEC26
    $1b constant GTZC1_MPCBB3_SEC27             \ [0x1b] SEC27
    $1c constant GTZC1_MPCBB3_SEC28             \ [0x1c] SEC28
    $1d constant GTZC1_MPCBB3_SEC29             \ [0x1d] SEC29
    $1e constant GTZC1_MPCBB3_SEC30             \ [0x1e] SEC30
    $1f constant GTZC1_MPCBB3_SEC31             \ [0x1f] SEC31
  [then]


  [ifdef] GTZC1_MPCBB3_MPCBB3_SECCFGR33_DEF
    \
    \ @brief MPCBBx security configuration for super-block x register
    \ Address offset: 0x184
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GTZC1_MPCBB3_SEC0              \ [0x00] SEC0
    $01 constant GTZC1_MPCBB3_SEC1              \ [0x01] SEC1
    $02 constant GTZC1_MPCBB3_SEC2              \ [0x02] SEC2
    $03 constant GTZC1_MPCBB3_SEC3              \ [0x03] SEC3
    $04 constant GTZC1_MPCBB3_SEC4              \ [0x04] SEC4
    $05 constant GTZC1_MPCBB3_SEC5              \ [0x05] SEC5
    $06 constant GTZC1_MPCBB3_SEC6              \ [0x06] SEC6
    $07 constant GTZC1_MPCBB3_SEC7              \ [0x07] SEC7
    $08 constant GTZC1_MPCBB3_SEC8              \ [0x08] SEC8
    $09 constant GTZC1_MPCBB3_SEC9              \ [0x09] SEC9
    $0a constant GTZC1_MPCBB3_SEC10             \ [0x0a] SEC10
    $0b constant GTZC1_MPCBB3_SEC11             \ [0x0b] SEC11
    $0c constant GTZC1_MPCBB3_SEC12             \ [0x0c] SEC12
    $0d constant GTZC1_MPCBB3_SEC13             \ [0x0d] SEC13
    $0e constant GTZC1_MPCBB3_SEC14             \ [0x0e] SEC14
    $0f constant GTZC1_MPCBB3_SEC15             \ [0x0f] SEC15
    $10 constant GTZC1_MPCBB3_SEC16             \ [0x10] SEC16
    $11 constant GTZC1_MPCBB3_SEC17             \ [0x11] SEC17
    $12 constant GTZC1_MPCBB3_SEC18             \ [0x12] SEC18
    $13 constant GTZC1_MPCBB3_SEC19             \ [0x13] SEC19
    $14 constant GTZC1_MPCBB3_SEC20             \ [0x14] SEC20
    $15 constant GTZC1_MPCBB3_SEC21             \ [0x15] SEC21
    $16 constant GTZC1_MPCBB3_SEC22             \ [0x16] SEC22
    $17 constant GTZC1_MPCBB3_SEC23             \ [0x17] SEC23
    $18 constant GTZC1_MPCBB3_SEC24             \ [0x18] SEC24
    $19 constant GTZC1_MPCBB3_SEC25             \ [0x19] SEC25
    $1a constant GTZC1_MPCBB3_SEC26             \ [0x1a] SEC26
    $1b constant GTZC1_MPCBB3_SEC27             \ [0x1b] SEC27
    $1c constant GTZC1_MPCBB3_SEC28             \ [0x1c] SEC28
    $1d constant GTZC1_MPCBB3_SEC29             \ [0x1d] SEC29
    $1e constant GTZC1_MPCBB3_SEC30             \ [0x1e] SEC30
    $1f constant GTZC1_MPCBB3_SEC31             \ [0x1f] SEC31
  [then]


  [ifdef] GTZC1_MPCBB3_MPCBB3_SECCFGR34_DEF
    \
    \ @brief MPCBBx security configuration for super-block x register
    \ Address offset: 0x188
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GTZC1_MPCBB3_SEC0              \ [0x00] SEC0
    $01 constant GTZC1_MPCBB3_SEC1              \ [0x01] SEC1
    $02 constant GTZC1_MPCBB3_SEC2              \ [0x02] SEC2
    $03 constant GTZC1_MPCBB3_SEC3              \ [0x03] SEC3
    $04 constant GTZC1_MPCBB3_SEC4              \ [0x04] SEC4
    $05 constant GTZC1_MPCBB3_SEC5              \ [0x05] SEC5
    $06 constant GTZC1_MPCBB3_SEC6              \ [0x06] SEC6
    $07 constant GTZC1_MPCBB3_SEC7              \ [0x07] SEC7
    $08 constant GTZC1_MPCBB3_SEC8              \ [0x08] SEC8
    $09 constant GTZC1_MPCBB3_SEC9              \ [0x09] SEC9
    $0a constant GTZC1_MPCBB3_SEC10             \ [0x0a] SEC10
    $0b constant GTZC1_MPCBB3_SEC11             \ [0x0b] SEC11
    $0c constant GTZC1_MPCBB3_SEC12             \ [0x0c] SEC12
    $0d constant GTZC1_MPCBB3_SEC13             \ [0x0d] SEC13
    $0e constant GTZC1_MPCBB3_SEC14             \ [0x0e] SEC14
    $0f constant GTZC1_MPCBB3_SEC15             \ [0x0f] SEC15
    $10 constant GTZC1_MPCBB3_SEC16             \ [0x10] SEC16
    $11 constant GTZC1_MPCBB3_SEC17             \ [0x11] SEC17
    $12 constant GTZC1_MPCBB3_SEC18             \ [0x12] SEC18
    $13 constant GTZC1_MPCBB3_SEC19             \ [0x13] SEC19
    $14 constant GTZC1_MPCBB3_SEC20             \ [0x14] SEC20
    $15 constant GTZC1_MPCBB3_SEC21             \ [0x15] SEC21
    $16 constant GTZC1_MPCBB3_SEC22             \ [0x16] SEC22
    $17 constant GTZC1_MPCBB3_SEC23             \ [0x17] SEC23
    $18 constant GTZC1_MPCBB3_SEC24             \ [0x18] SEC24
    $19 constant GTZC1_MPCBB3_SEC25             \ [0x19] SEC25
    $1a constant GTZC1_MPCBB3_SEC26             \ [0x1a] SEC26
    $1b constant GTZC1_MPCBB3_SEC27             \ [0x1b] SEC27
    $1c constant GTZC1_MPCBB3_SEC28             \ [0x1c] SEC28
    $1d constant GTZC1_MPCBB3_SEC29             \ [0x1d] SEC29
    $1e constant GTZC1_MPCBB3_SEC30             \ [0x1e] SEC30
    $1f constant GTZC1_MPCBB3_SEC31             \ [0x1f] SEC31
  [then]


  [ifdef] GTZC1_MPCBB3_MPCBB3_SECCFGR35_DEF
    \
    \ @brief MPCBBx security configuration for super-block x register
    \ Address offset: 0x18C
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GTZC1_MPCBB3_SEC0              \ [0x00] SEC0
    $01 constant GTZC1_MPCBB3_SEC1              \ [0x01] SEC1
    $02 constant GTZC1_MPCBB3_SEC2              \ [0x02] SEC2
    $03 constant GTZC1_MPCBB3_SEC3              \ [0x03] SEC3
    $04 constant GTZC1_MPCBB3_SEC4              \ [0x04] SEC4
    $05 constant GTZC1_MPCBB3_SEC5              \ [0x05] SEC5
    $06 constant GTZC1_MPCBB3_SEC6              \ [0x06] SEC6
    $07 constant GTZC1_MPCBB3_SEC7              \ [0x07] SEC7
    $08 constant GTZC1_MPCBB3_SEC8              \ [0x08] SEC8
    $09 constant GTZC1_MPCBB3_SEC9              \ [0x09] SEC9
    $0a constant GTZC1_MPCBB3_SEC10             \ [0x0a] SEC10
    $0b constant GTZC1_MPCBB3_SEC11             \ [0x0b] SEC11
    $0c constant GTZC1_MPCBB3_SEC12             \ [0x0c] SEC12
    $0d constant GTZC1_MPCBB3_SEC13             \ [0x0d] SEC13
    $0e constant GTZC1_MPCBB3_SEC14             \ [0x0e] SEC14
    $0f constant GTZC1_MPCBB3_SEC15             \ [0x0f] SEC15
    $10 constant GTZC1_MPCBB3_SEC16             \ [0x10] SEC16
    $11 constant GTZC1_MPCBB3_SEC17             \ [0x11] SEC17
    $12 constant GTZC1_MPCBB3_SEC18             \ [0x12] SEC18
    $13 constant GTZC1_MPCBB3_SEC19             \ [0x13] SEC19
    $14 constant GTZC1_MPCBB3_SEC20             \ [0x14] SEC20
    $15 constant GTZC1_MPCBB3_SEC21             \ [0x15] SEC21
    $16 constant GTZC1_MPCBB3_SEC22             \ [0x16] SEC22
    $17 constant GTZC1_MPCBB3_SEC23             \ [0x17] SEC23
    $18 constant GTZC1_MPCBB3_SEC24             \ [0x18] SEC24
    $19 constant GTZC1_MPCBB3_SEC25             \ [0x19] SEC25
    $1a constant GTZC1_MPCBB3_SEC26             \ [0x1a] SEC26
    $1b constant GTZC1_MPCBB3_SEC27             \ [0x1b] SEC27
    $1c constant GTZC1_MPCBB3_SEC28             \ [0x1c] SEC28
    $1d constant GTZC1_MPCBB3_SEC29             \ [0x1d] SEC29
    $1e constant GTZC1_MPCBB3_SEC30             \ [0x1e] SEC30
    $1f constant GTZC1_MPCBB3_SEC31             \ [0x1f] SEC31
  [then]


  [ifdef] GTZC1_MPCBB3_MPCBB3_SECCFGR36_DEF
    \
    \ @brief MPCBBx security configuration for super-block x register
    \ Address offset: 0x190
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GTZC1_MPCBB3_SEC0              \ [0x00] SEC0
    $01 constant GTZC1_MPCBB3_SEC1              \ [0x01] SEC1
    $02 constant GTZC1_MPCBB3_SEC2              \ [0x02] SEC2
    $03 constant GTZC1_MPCBB3_SEC3              \ [0x03] SEC3
    $04 constant GTZC1_MPCBB3_SEC4              \ [0x04] SEC4
    $05 constant GTZC1_MPCBB3_SEC5              \ [0x05] SEC5
    $06 constant GTZC1_MPCBB3_SEC6              \ [0x06] SEC6
    $07 constant GTZC1_MPCBB3_SEC7              \ [0x07] SEC7
    $08 constant GTZC1_MPCBB3_SEC8              \ [0x08] SEC8
    $09 constant GTZC1_MPCBB3_SEC9              \ [0x09] SEC9
    $0a constant GTZC1_MPCBB3_SEC10             \ [0x0a] SEC10
    $0b constant GTZC1_MPCBB3_SEC11             \ [0x0b] SEC11
    $0c constant GTZC1_MPCBB3_SEC12             \ [0x0c] SEC12
    $0d constant GTZC1_MPCBB3_SEC13             \ [0x0d] SEC13
    $0e constant GTZC1_MPCBB3_SEC14             \ [0x0e] SEC14
    $0f constant GTZC1_MPCBB3_SEC15             \ [0x0f] SEC15
    $10 constant GTZC1_MPCBB3_SEC16             \ [0x10] SEC16
    $11 constant GTZC1_MPCBB3_SEC17             \ [0x11] SEC17
    $12 constant GTZC1_MPCBB3_SEC18             \ [0x12] SEC18
    $13 constant GTZC1_MPCBB3_SEC19             \ [0x13] SEC19
    $14 constant GTZC1_MPCBB3_SEC20             \ [0x14] SEC20
    $15 constant GTZC1_MPCBB3_SEC21             \ [0x15] SEC21
    $16 constant GTZC1_MPCBB3_SEC22             \ [0x16] SEC22
    $17 constant GTZC1_MPCBB3_SEC23             \ [0x17] SEC23
    $18 constant GTZC1_MPCBB3_SEC24             \ [0x18] SEC24
    $19 constant GTZC1_MPCBB3_SEC25             \ [0x19] SEC25
    $1a constant GTZC1_MPCBB3_SEC26             \ [0x1a] SEC26
    $1b constant GTZC1_MPCBB3_SEC27             \ [0x1b] SEC27
    $1c constant GTZC1_MPCBB3_SEC28             \ [0x1c] SEC28
    $1d constant GTZC1_MPCBB3_SEC29             \ [0x1d] SEC29
    $1e constant GTZC1_MPCBB3_SEC30             \ [0x1e] SEC30
    $1f constant GTZC1_MPCBB3_SEC31             \ [0x1f] SEC31
  [then]


  [ifdef] GTZC1_MPCBB3_MPCBB3_SECCFGR37_DEF
    \
    \ @brief MPCBBx security configuration for super-block x register
    \ Address offset: 0x194
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GTZC1_MPCBB3_SEC0              \ [0x00] SEC0
    $01 constant GTZC1_MPCBB3_SEC1              \ [0x01] SEC1
    $02 constant GTZC1_MPCBB3_SEC2              \ [0x02] SEC2
    $03 constant GTZC1_MPCBB3_SEC3              \ [0x03] SEC3
    $04 constant GTZC1_MPCBB3_SEC4              \ [0x04] SEC4
    $05 constant GTZC1_MPCBB3_SEC5              \ [0x05] SEC5
    $06 constant GTZC1_MPCBB3_SEC6              \ [0x06] SEC6
    $07 constant GTZC1_MPCBB3_SEC7              \ [0x07] SEC7
    $08 constant GTZC1_MPCBB3_SEC8              \ [0x08] SEC8
    $09 constant GTZC1_MPCBB3_SEC9              \ [0x09] SEC9
    $0a constant GTZC1_MPCBB3_SEC10             \ [0x0a] SEC10
    $0b constant GTZC1_MPCBB3_SEC11             \ [0x0b] SEC11
    $0c constant GTZC1_MPCBB3_SEC12             \ [0x0c] SEC12
    $0d constant GTZC1_MPCBB3_SEC13             \ [0x0d] SEC13
    $0e constant GTZC1_MPCBB3_SEC14             \ [0x0e] SEC14
    $0f constant GTZC1_MPCBB3_SEC15             \ [0x0f] SEC15
    $10 constant GTZC1_MPCBB3_SEC16             \ [0x10] SEC16
    $11 constant GTZC1_MPCBB3_SEC17             \ [0x11] SEC17
    $12 constant GTZC1_MPCBB3_SEC18             \ [0x12] SEC18
    $13 constant GTZC1_MPCBB3_SEC19             \ [0x13] SEC19
    $14 constant GTZC1_MPCBB3_SEC20             \ [0x14] SEC20
    $15 constant GTZC1_MPCBB3_SEC21             \ [0x15] SEC21
    $16 constant GTZC1_MPCBB3_SEC22             \ [0x16] SEC22
    $17 constant GTZC1_MPCBB3_SEC23             \ [0x17] SEC23
    $18 constant GTZC1_MPCBB3_SEC24             \ [0x18] SEC24
    $19 constant GTZC1_MPCBB3_SEC25             \ [0x19] SEC25
    $1a constant GTZC1_MPCBB3_SEC26             \ [0x1a] SEC26
    $1b constant GTZC1_MPCBB3_SEC27             \ [0x1b] SEC27
    $1c constant GTZC1_MPCBB3_SEC28             \ [0x1c] SEC28
    $1d constant GTZC1_MPCBB3_SEC29             \ [0x1d] SEC29
    $1e constant GTZC1_MPCBB3_SEC30             \ [0x1e] SEC30
    $1f constant GTZC1_MPCBB3_SEC31             \ [0x1f] SEC31
  [then]


  [ifdef] GTZC1_MPCBB3_MPCBB3_SECCFGR38_DEF
    \
    \ @brief MPCBBx security configuration for super-block x register
    \ Address offset: 0x198
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GTZC1_MPCBB3_SEC0              \ [0x00] SEC0
    $01 constant GTZC1_MPCBB3_SEC1              \ [0x01] SEC1
    $02 constant GTZC1_MPCBB3_SEC2              \ [0x02] SEC2
    $03 constant GTZC1_MPCBB3_SEC3              \ [0x03] SEC3
    $04 constant GTZC1_MPCBB3_SEC4              \ [0x04] SEC4
    $05 constant GTZC1_MPCBB3_SEC5              \ [0x05] SEC5
    $06 constant GTZC1_MPCBB3_SEC6              \ [0x06] SEC6
    $07 constant GTZC1_MPCBB3_SEC7              \ [0x07] SEC7
    $08 constant GTZC1_MPCBB3_SEC8              \ [0x08] SEC8
    $09 constant GTZC1_MPCBB3_SEC9              \ [0x09] SEC9
    $0a constant GTZC1_MPCBB3_SEC10             \ [0x0a] SEC10
    $0b constant GTZC1_MPCBB3_SEC11             \ [0x0b] SEC11
    $0c constant GTZC1_MPCBB3_SEC12             \ [0x0c] SEC12
    $0d constant GTZC1_MPCBB3_SEC13             \ [0x0d] SEC13
    $0e constant GTZC1_MPCBB3_SEC14             \ [0x0e] SEC14
    $0f constant GTZC1_MPCBB3_SEC15             \ [0x0f] SEC15
    $10 constant GTZC1_MPCBB3_SEC16             \ [0x10] SEC16
    $11 constant GTZC1_MPCBB3_SEC17             \ [0x11] SEC17
    $12 constant GTZC1_MPCBB3_SEC18             \ [0x12] SEC18
    $13 constant GTZC1_MPCBB3_SEC19             \ [0x13] SEC19
    $14 constant GTZC1_MPCBB3_SEC20             \ [0x14] SEC20
    $15 constant GTZC1_MPCBB3_SEC21             \ [0x15] SEC21
    $16 constant GTZC1_MPCBB3_SEC22             \ [0x16] SEC22
    $17 constant GTZC1_MPCBB3_SEC23             \ [0x17] SEC23
    $18 constant GTZC1_MPCBB3_SEC24             \ [0x18] SEC24
    $19 constant GTZC1_MPCBB3_SEC25             \ [0x19] SEC25
    $1a constant GTZC1_MPCBB3_SEC26             \ [0x1a] SEC26
    $1b constant GTZC1_MPCBB3_SEC27             \ [0x1b] SEC27
    $1c constant GTZC1_MPCBB3_SEC28             \ [0x1c] SEC28
    $1d constant GTZC1_MPCBB3_SEC29             \ [0x1d] SEC29
    $1e constant GTZC1_MPCBB3_SEC30             \ [0x1e] SEC30
    $1f constant GTZC1_MPCBB3_SEC31             \ [0x1f] SEC31
  [then]


  [ifdef] GTZC1_MPCBB3_MPCBB3_SECCFGR39_DEF
    \
    \ @brief MPCBBx security configuration for super-block x register
    \ Address offset: 0x19C
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GTZC1_MPCBB3_SEC0              \ [0x00] SEC0
    $01 constant GTZC1_MPCBB3_SEC1              \ [0x01] SEC1
    $02 constant GTZC1_MPCBB3_SEC2              \ [0x02] SEC2
    $03 constant GTZC1_MPCBB3_SEC3              \ [0x03] SEC3
    $04 constant GTZC1_MPCBB3_SEC4              \ [0x04] SEC4
    $05 constant GTZC1_MPCBB3_SEC5              \ [0x05] SEC5
    $06 constant GTZC1_MPCBB3_SEC6              \ [0x06] SEC6
    $07 constant GTZC1_MPCBB3_SEC7              \ [0x07] SEC7
    $08 constant GTZC1_MPCBB3_SEC8              \ [0x08] SEC8
    $09 constant GTZC1_MPCBB3_SEC9              \ [0x09] SEC9
    $0a constant GTZC1_MPCBB3_SEC10             \ [0x0a] SEC10
    $0b constant GTZC1_MPCBB3_SEC11             \ [0x0b] SEC11
    $0c constant GTZC1_MPCBB3_SEC12             \ [0x0c] SEC12
    $0d constant GTZC1_MPCBB3_SEC13             \ [0x0d] SEC13
    $0e constant GTZC1_MPCBB3_SEC14             \ [0x0e] SEC14
    $0f constant GTZC1_MPCBB3_SEC15             \ [0x0f] SEC15
    $10 constant GTZC1_MPCBB3_SEC16             \ [0x10] SEC16
    $11 constant GTZC1_MPCBB3_SEC17             \ [0x11] SEC17
    $12 constant GTZC1_MPCBB3_SEC18             \ [0x12] SEC18
    $13 constant GTZC1_MPCBB3_SEC19             \ [0x13] SEC19
    $14 constant GTZC1_MPCBB3_SEC20             \ [0x14] SEC20
    $15 constant GTZC1_MPCBB3_SEC21             \ [0x15] SEC21
    $16 constant GTZC1_MPCBB3_SEC22             \ [0x16] SEC22
    $17 constant GTZC1_MPCBB3_SEC23             \ [0x17] SEC23
    $18 constant GTZC1_MPCBB3_SEC24             \ [0x18] SEC24
    $19 constant GTZC1_MPCBB3_SEC25             \ [0x19] SEC25
    $1a constant GTZC1_MPCBB3_SEC26             \ [0x1a] SEC26
    $1b constant GTZC1_MPCBB3_SEC27             \ [0x1b] SEC27
    $1c constant GTZC1_MPCBB3_SEC28             \ [0x1c] SEC28
    $1d constant GTZC1_MPCBB3_SEC29             \ [0x1d] SEC29
    $1e constant GTZC1_MPCBB3_SEC30             \ [0x1e] SEC30
    $1f constant GTZC1_MPCBB3_SEC31             \ [0x1f] SEC31
  [then]


  [ifdef] GTZC1_MPCBB3_MPCBB3_SECCFGR40_DEF
    \
    \ @brief MPCBBx security configuration for super-block x register
    \ Address offset: 0x1A0
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GTZC1_MPCBB3_SEC0              \ [0x00] SEC0
    $01 constant GTZC1_MPCBB3_SEC1              \ [0x01] SEC1
    $02 constant GTZC1_MPCBB3_SEC2              \ [0x02] SEC2
    $03 constant GTZC1_MPCBB3_SEC3              \ [0x03] SEC3
    $04 constant GTZC1_MPCBB3_SEC4              \ [0x04] SEC4
    $05 constant GTZC1_MPCBB3_SEC5              \ [0x05] SEC5
    $06 constant GTZC1_MPCBB3_SEC6              \ [0x06] SEC6
    $07 constant GTZC1_MPCBB3_SEC7              \ [0x07] SEC7
    $08 constant GTZC1_MPCBB3_SEC8              \ [0x08] SEC8
    $09 constant GTZC1_MPCBB3_SEC9              \ [0x09] SEC9
    $0a constant GTZC1_MPCBB3_SEC10             \ [0x0a] SEC10
    $0b constant GTZC1_MPCBB3_SEC11             \ [0x0b] SEC11
    $0c constant GTZC1_MPCBB3_SEC12             \ [0x0c] SEC12
    $0d constant GTZC1_MPCBB3_SEC13             \ [0x0d] SEC13
    $0e constant GTZC1_MPCBB3_SEC14             \ [0x0e] SEC14
    $0f constant GTZC1_MPCBB3_SEC15             \ [0x0f] SEC15
    $10 constant GTZC1_MPCBB3_SEC16             \ [0x10] SEC16
    $11 constant GTZC1_MPCBB3_SEC17             \ [0x11] SEC17
    $12 constant GTZC1_MPCBB3_SEC18             \ [0x12] SEC18
    $13 constant GTZC1_MPCBB3_SEC19             \ [0x13] SEC19
    $14 constant GTZC1_MPCBB3_SEC20             \ [0x14] SEC20
    $15 constant GTZC1_MPCBB3_SEC21             \ [0x15] SEC21
    $16 constant GTZC1_MPCBB3_SEC22             \ [0x16] SEC22
    $17 constant GTZC1_MPCBB3_SEC23             \ [0x17] SEC23
    $18 constant GTZC1_MPCBB3_SEC24             \ [0x18] SEC24
    $19 constant GTZC1_MPCBB3_SEC25             \ [0x19] SEC25
    $1a constant GTZC1_MPCBB3_SEC26             \ [0x1a] SEC26
    $1b constant GTZC1_MPCBB3_SEC27             \ [0x1b] SEC27
    $1c constant GTZC1_MPCBB3_SEC28             \ [0x1c] SEC28
    $1d constant GTZC1_MPCBB3_SEC29             \ [0x1d] SEC29
    $1e constant GTZC1_MPCBB3_SEC30             \ [0x1e] SEC30
    $1f constant GTZC1_MPCBB3_SEC31             \ [0x1f] SEC31
  [then]


  [ifdef] GTZC1_MPCBB3_MPCBB3_SECCFGR41_DEF
    \
    \ @brief MPCBBx security configuration for super-block x register
    \ Address offset: 0x1A4
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GTZC1_MPCBB3_SEC0              \ [0x00] SEC0
    $01 constant GTZC1_MPCBB3_SEC1              \ [0x01] SEC1
    $02 constant GTZC1_MPCBB3_SEC2              \ [0x02] SEC2
    $03 constant GTZC1_MPCBB3_SEC3              \ [0x03] SEC3
    $04 constant GTZC1_MPCBB3_SEC4              \ [0x04] SEC4
    $05 constant GTZC1_MPCBB3_SEC5              \ [0x05] SEC5
    $06 constant GTZC1_MPCBB3_SEC6              \ [0x06] SEC6
    $07 constant GTZC1_MPCBB3_SEC7              \ [0x07] SEC7
    $08 constant GTZC1_MPCBB3_SEC8              \ [0x08] SEC8
    $09 constant GTZC1_MPCBB3_SEC9              \ [0x09] SEC9
    $0a constant GTZC1_MPCBB3_SEC10             \ [0x0a] SEC10
    $0b constant GTZC1_MPCBB3_SEC11             \ [0x0b] SEC11
    $0c constant GTZC1_MPCBB3_SEC12             \ [0x0c] SEC12
    $0d constant GTZC1_MPCBB3_SEC13             \ [0x0d] SEC13
    $0e constant GTZC1_MPCBB3_SEC14             \ [0x0e] SEC14
    $0f constant GTZC1_MPCBB3_SEC15             \ [0x0f] SEC15
    $10 constant GTZC1_MPCBB3_SEC16             \ [0x10] SEC16
    $11 constant GTZC1_MPCBB3_SEC17             \ [0x11] SEC17
    $12 constant GTZC1_MPCBB3_SEC18             \ [0x12] SEC18
    $13 constant GTZC1_MPCBB3_SEC19             \ [0x13] SEC19
    $14 constant GTZC1_MPCBB3_SEC20             \ [0x14] SEC20
    $15 constant GTZC1_MPCBB3_SEC21             \ [0x15] SEC21
    $16 constant GTZC1_MPCBB3_SEC22             \ [0x16] SEC22
    $17 constant GTZC1_MPCBB3_SEC23             \ [0x17] SEC23
    $18 constant GTZC1_MPCBB3_SEC24             \ [0x18] SEC24
    $19 constant GTZC1_MPCBB3_SEC25             \ [0x19] SEC25
    $1a constant GTZC1_MPCBB3_SEC26             \ [0x1a] SEC26
    $1b constant GTZC1_MPCBB3_SEC27             \ [0x1b] SEC27
    $1c constant GTZC1_MPCBB3_SEC28             \ [0x1c] SEC28
    $1d constant GTZC1_MPCBB3_SEC29             \ [0x1d] SEC29
    $1e constant GTZC1_MPCBB3_SEC30             \ [0x1e] SEC30
    $1f constant GTZC1_MPCBB3_SEC31             \ [0x1f] SEC31
  [then]


  [ifdef] GTZC1_MPCBB3_MPCBB3_SECCFGR42_DEF
    \
    \ @brief MPCBBx security configuration for super-block x register
    \ Address offset: 0x1A8
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GTZC1_MPCBB3_SEC0              \ [0x00] SEC0
    $01 constant GTZC1_MPCBB3_SEC1              \ [0x01] SEC1
    $02 constant GTZC1_MPCBB3_SEC2              \ [0x02] SEC2
    $03 constant GTZC1_MPCBB3_SEC3              \ [0x03] SEC3
    $04 constant GTZC1_MPCBB3_SEC4              \ [0x04] SEC4
    $05 constant GTZC1_MPCBB3_SEC5              \ [0x05] SEC5
    $06 constant GTZC1_MPCBB3_SEC6              \ [0x06] SEC6
    $07 constant GTZC1_MPCBB3_SEC7              \ [0x07] SEC7
    $08 constant GTZC1_MPCBB3_SEC8              \ [0x08] SEC8
    $09 constant GTZC1_MPCBB3_SEC9              \ [0x09] SEC9
    $0a constant GTZC1_MPCBB3_SEC10             \ [0x0a] SEC10
    $0b constant GTZC1_MPCBB3_SEC11             \ [0x0b] SEC11
    $0c constant GTZC1_MPCBB3_SEC12             \ [0x0c] SEC12
    $0d constant GTZC1_MPCBB3_SEC13             \ [0x0d] SEC13
    $0e constant GTZC1_MPCBB3_SEC14             \ [0x0e] SEC14
    $0f constant GTZC1_MPCBB3_SEC15             \ [0x0f] SEC15
    $10 constant GTZC1_MPCBB3_SEC16             \ [0x10] SEC16
    $11 constant GTZC1_MPCBB3_SEC17             \ [0x11] SEC17
    $12 constant GTZC1_MPCBB3_SEC18             \ [0x12] SEC18
    $13 constant GTZC1_MPCBB3_SEC19             \ [0x13] SEC19
    $14 constant GTZC1_MPCBB3_SEC20             \ [0x14] SEC20
    $15 constant GTZC1_MPCBB3_SEC21             \ [0x15] SEC21
    $16 constant GTZC1_MPCBB3_SEC22             \ [0x16] SEC22
    $17 constant GTZC1_MPCBB3_SEC23             \ [0x17] SEC23
    $18 constant GTZC1_MPCBB3_SEC24             \ [0x18] SEC24
    $19 constant GTZC1_MPCBB3_SEC25             \ [0x19] SEC25
    $1a constant GTZC1_MPCBB3_SEC26             \ [0x1a] SEC26
    $1b constant GTZC1_MPCBB3_SEC27             \ [0x1b] SEC27
    $1c constant GTZC1_MPCBB3_SEC28             \ [0x1c] SEC28
    $1d constant GTZC1_MPCBB3_SEC29             \ [0x1d] SEC29
    $1e constant GTZC1_MPCBB3_SEC30             \ [0x1e] SEC30
    $1f constant GTZC1_MPCBB3_SEC31             \ [0x1f] SEC31
  [then]


  [ifdef] GTZC1_MPCBB3_MPCBB3_SECCFGR43_DEF
    \
    \ @brief MPCBBx security configuration for super-block x register
    \ Address offset: 0x1AC
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GTZC1_MPCBB3_SEC0              \ [0x00] SEC0
    $01 constant GTZC1_MPCBB3_SEC1              \ [0x01] SEC1
    $02 constant GTZC1_MPCBB3_SEC2              \ [0x02] SEC2
    $03 constant GTZC1_MPCBB3_SEC3              \ [0x03] SEC3
    $04 constant GTZC1_MPCBB3_SEC4              \ [0x04] SEC4
    $05 constant GTZC1_MPCBB3_SEC5              \ [0x05] SEC5
    $06 constant GTZC1_MPCBB3_SEC6              \ [0x06] SEC6
    $07 constant GTZC1_MPCBB3_SEC7              \ [0x07] SEC7
    $08 constant GTZC1_MPCBB3_SEC8              \ [0x08] SEC8
    $09 constant GTZC1_MPCBB3_SEC9              \ [0x09] SEC9
    $0a constant GTZC1_MPCBB3_SEC10             \ [0x0a] SEC10
    $0b constant GTZC1_MPCBB3_SEC11             \ [0x0b] SEC11
    $0c constant GTZC1_MPCBB3_SEC12             \ [0x0c] SEC12
    $0d constant GTZC1_MPCBB3_SEC13             \ [0x0d] SEC13
    $0e constant GTZC1_MPCBB3_SEC14             \ [0x0e] SEC14
    $0f constant GTZC1_MPCBB3_SEC15             \ [0x0f] SEC15
    $10 constant GTZC1_MPCBB3_SEC16             \ [0x10] SEC16
    $11 constant GTZC1_MPCBB3_SEC17             \ [0x11] SEC17
    $12 constant GTZC1_MPCBB3_SEC18             \ [0x12] SEC18
    $13 constant GTZC1_MPCBB3_SEC19             \ [0x13] SEC19
    $14 constant GTZC1_MPCBB3_SEC20             \ [0x14] SEC20
    $15 constant GTZC1_MPCBB3_SEC21             \ [0x15] SEC21
    $16 constant GTZC1_MPCBB3_SEC22             \ [0x16] SEC22
    $17 constant GTZC1_MPCBB3_SEC23             \ [0x17] SEC23
    $18 constant GTZC1_MPCBB3_SEC24             \ [0x18] SEC24
    $19 constant GTZC1_MPCBB3_SEC25             \ [0x19] SEC25
    $1a constant GTZC1_MPCBB3_SEC26             \ [0x1a] SEC26
    $1b constant GTZC1_MPCBB3_SEC27             \ [0x1b] SEC27
    $1c constant GTZC1_MPCBB3_SEC28             \ [0x1c] SEC28
    $1d constant GTZC1_MPCBB3_SEC29             \ [0x1d] SEC29
    $1e constant GTZC1_MPCBB3_SEC30             \ [0x1e] SEC30
    $1f constant GTZC1_MPCBB3_SEC31             \ [0x1f] SEC31
  [then]


  [ifdef] GTZC1_MPCBB3_MPCBB3_SECCFGR44_DEF
    \
    \ @brief MPCBBx security configuration for super-block x register
    \ Address offset: 0x1B0
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GTZC1_MPCBB3_SEC0              \ [0x00] SEC0
    $01 constant GTZC1_MPCBB3_SEC1              \ [0x01] SEC1
    $02 constant GTZC1_MPCBB3_SEC2              \ [0x02] SEC2
    $03 constant GTZC1_MPCBB3_SEC3              \ [0x03] SEC3
    $04 constant GTZC1_MPCBB3_SEC4              \ [0x04] SEC4
    $05 constant GTZC1_MPCBB3_SEC5              \ [0x05] SEC5
    $06 constant GTZC1_MPCBB3_SEC6              \ [0x06] SEC6
    $07 constant GTZC1_MPCBB3_SEC7              \ [0x07] SEC7
    $08 constant GTZC1_MPCBB3_SEC8              \ [0x08] SEC8
    $09 constant GTZC1_MPCBB3_SEC9              \ [0x09] SEC9
    $0a constant GTZC1_MPCBB3_SEC10             \ [0x0a] SEC10
    $0b constant GTZC1_MPCBB3_SEC11             \ [0x0b] SEC11
    $0c constant GTZC1_MPCBB3_SEC12             \ [0x0c] SEC12
    $0d constant GTZC1_MPCBB3_SEC13             \ [0x0d] SEC13
    $0e constant GTZC1_MPCBB3_SEC14             \ [0x0e] SEC14
    $0f constant GTZC1_MPCBB3_SEC15             \ [0x0f] SEC15
    $10 constant GTZC1_MPCBB3_SEC16             \ [0x10] SEC16
    $11 constant GTZC1_MPCBB3_SEC17             \ [0x11] SEC17
    $12 constant GTZC1_MPCBB3_SEC18             \ [0x12] SEC18
    $13 constant GTZC1_MPCBB3_SEC19             \ [0x13] SEC19
    $14 constant GTZC1_MPCBB3_SEC20             \ [0x14] SEC20
    $15 constant GTZC1_MPCBB3_SEC21             \ [0x15] SEC21
    $16 constant GTZC1_MPCBB3_SEC22             \ [0x16] SEC22
    $17 constant GTZC1_MPCBB3_SEC23             \ [0x17] SEC23
    $18 constant GTZC1_MPCBB3_SEC24             \ [0x18] SEC24
    $19 constant GTZC1_MPCBB3_SEC25             \ [0x19] SEC25
    $1a constant GTZC1_MPCBB3_SEC26             \ [0x1a] SEC26
    $1b constant GTZC1_MPCBB3_SEC27             \ [0x1b] SEC27
    $1c constant GTZC1_MPCBB3_SEC28             \ [0x1c] SEC28
    $1d constant GTZC1_MPCBB3_SEC29             \ [0x1d] SEC29
    $1e constant GTZC1_MPCBB3_SEC30             \ [0x1e] SEC30
    $1f constant GTZC1_MPCBB3_SEC31             \ [0x1f] SEC31
  [then]


  [ifdef] GTZC1_MPCBB3_MPCBB3_SECCFGR45_DEF
    \
    \ @brief MPCBBx security configuration for super-block x register
    \ Address offset: 0x1B4
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GTZC1_MPCBB3_SEC0              \ [0x00] SEC0
    $01 constant GTZC1_MPCBB3_SEC1              \ [0x01] SEC1
    $02 constant GTZC1_MPCBB3_SEC2              \ [0x02] SEC2
    $03 constant GTZC1_MPCBB3_SEC3              \ [0x03] SEC3
    $04 constant GTZC1_MPCBB3_SEC4              \ [0x04] SEC4
    $05 constant GTZC1_MPCBB3_SEC5              \ [0x05] SEC5
    $06 constant GTZC1_MPCBB3_SEC6              \ [0x06] SEC6
    $07 constant GTZC1_MPCBB3_SEC7              \ [0x07] SEC7
    $08 constant GTZC1_MPCBB3_SEC8              \ [0x08] SEC8
    $09 constant GTZC1_MPCBB3_SEC9              \ [0x09] SEC9
    $0a constant GTZC1_MPCBB3_SEC10             \ [0x0a] SEC10
    $0b constant GTZC1_MPCBB3_SEC11             \ [0x0b] SEC11
    $0c constant GTZC1_MPCBB3_SEC12             \ [0x0c] SEC12
    $0d constant GTZC1_MPCBB3_SEC13             \ [0x0d] SEC13
    $0e constant GTZC1_MPCBB3_SEC14             \ [0x0e] SEC14
    $0f constant GTZC1_MPCBB3_SEC15             \ [0x0f] SEC15
    $10 constant GTZC1_MPCBB3_SEC16             \ [0x10] SEC16
    $11 constant GTZC1_MPCBB3_SEC17             \ [0x11] SEC17
    $12 constant GTZC1_MPCBB3_SEC18             \ [0x12] SEC18
    $13 constant GTZC1_MPCBB3_SEC19             \ [0x13] SEC19
    $14 constant GTZC1_MPCBB3_SEC20             \ [0x14] SEC20
    $15 constant GTZC1_MPCBB3_SEC21             \ [0x15] SEC21
    $16 constant GTZC1_MPCBB3_SEC22             \ [0x16] SEC22
    $17 constant GTZC1_MPCBB3_SEC23             \ [0x17] SEC23
    $18 constant GTZC1_MPCBB3_SEC24             \ [0x18] SEC24
    $19 constant GTZC1_MPCBB3_SEC25             \ [0x19] SEC25
    $1a constant GTZC1_MPCBB3_SEC26             \ [0x1a] SEC26
    $1b constant GTZC1_MPCBB3_SEC27             \ [0x1b] SEC27
    $1c constant GTZC1_MPCBB3_SEC28             \ [0x1c] SEC28
    $1d constant GTZC1_MPCBB3_SEC29             \ [0x1d] SEC29
    $1e constant GTZC1_MPCBB3_SEC30             \ [0x1e] SEC30
    $1f constant GTZC1_MPCBB3_SEC31             \ [0x1f] SEC31
  [then]


  [ifdef] GTZC1_MPCBB3_MPCBB3_SECCFGR46_DEF
    \
    \ @brief MPCBBx security configuration for super-block x register
    \ Address offset: 0x1B8
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GTZC1_MPCBB3_SEC0              \ [0x00] SEC0
    $01 constant GTZC1_MPCBB3_SEC1              \ [0x01] SEC1
    $02 constant GTZC1_MPCBB3_SEC2              \ [0x02] SEC2
    $03 constant GTZC1_MPCBB3_SEC3              \ [0x03] SEC3
    $04 constant GTZC1_MPCBB3_SEC4              \ [0x04] SEC4
    $05 constant GTZC1_MPCBB3_SEC5              \ [0x05] SEC5
    $06 constant GTZC1_MPCBB3_SEC6              \ [0x06] SEC6
    $07 constant GTZC1_MPCBB3_SEC7              \ [0x07] SEC7
    $08 constant GTZC1_MPCBB3_SEC8              \ [0x08] SEC8
    $09 constant GTZC1_MPCBB3_SEC9              \ [0x09] SEC9
    $0a constant GTZC1_MPCBB3_SEC10             \ [0x0a] SEC10
    $0b constant GTZC1_MPCBB3_SEC11             \ [0x0b] SEC11
    $0c constant GTZC1_MPCBB3_SEC12             \ [0x0c] SEC12
    $0d constant GTZC1_MPCBB3_SEC13             \ [0x0d] SEC13
    $0e constant GTZC1_MPCBB3_SEC14             \ [0x0e] SEC14
    $0f constant GTZC1_MPCBB3_SEC15             \ [0x0f] SEC15
    $10 constant GTZC1_MPCBB3_SEC16             \ [0x10] SEC16
    $11 constant GTZC1_MPCBB3_SEC17             \ [0x11] SEC17
    $12 constant GTZC1_MPCBB3_SEC18             \ [0x12] SEC18
    $13 constant GTZC1_MPCBB3_SEC19             \ [0x13] SEC19
    $14 constant GTZC1_MPCBB3_SEC20             \ [0x14] SEC20
    $15 constant GTZC1_MPCBB3_SEC21             \ [0x15] SEC21
    $16 constant GTZC1_MPCBB3_SEC22             \ [0x16] SEC22
    $17 constant GTZC1_MPCBB3_SEC23             \ [0x17] SEC23
    $18 constant GTZC1_MPCBB3_SEC24             \ [0x18] SEC24
    $19 constant GTZC1_MPCBB3_SEC25             \ [0x19] SEC25
    $1a constant GTZC1_MPCBB3_SEC26             \ [0x1a] SEC26
    $1b constant GTZC1_MPCBB3_SEC27             \ [0x1b] SEC27
    $1c constant GTZC1_MPCBB3_SEC28             \ [0x1c] SEC28
    $1d constant GTZC1_MPCBB3_SEC29             \ [0x1d] SEC29
    $1e constant GTZC1_MPCBB3_SEC30             \ [0x1e] SEC30
    $1f constant GTZC1_MPCBB3_SEC31             \ [0x1f] SEC31
  [then]


  [ifdef] GTZC1_MPCBB3_MPCBB3_SECCFGR47_DEF
    \
    \ @brief MPCBBx security configuration for super-block x register
    \ Address offset: 0x1BC
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GTZC1_MPCBB3_SEC0              \ [0x00] SEC0
    $01 constant GTZC1_MPCBB3_SEC1              \ [0x01] SEC1
    $02 constant GTZC1_MPCBB3_SEC2              \ [0x02] SEC2
    $03 constant GTZC1_MPCBB3_SEC3              \ [0x03] SEC3
    $04 constant GTZC1_MPCBB3_SEC4              \ [0x04] SEC4
    $05 constant GTZC1_MPCBB3_SEC5              \ [0x05] SEC5
    $06 constant GTZC1_MPCBB3_SEC6              \ [0x06] SEC6
    $07 constant GTZC1_MPCBB3_SEC7              \ [0x07] SEC7
    $08 constant GTZC1_MPCBB3_SEC8              \ [0x08] SEC8
    $09 constant GTZC1_MPCBB3_SEC9              \ [0x09] SEC9
    $0a constant GTZC1_MPCBB3_SEC10             \ [0x0a] SEC10
    $0b constant GTZC1_MPCBB3_SEC11             \ [0x0b] SEC11
    $0c constant GTZC1_MPCBB3_SEC12             \ [0x0c] SEC12
    $0d constant GTZC1_MPCBB3_SEC13             \ [0x0d] SEC13
    $0e constant GTZC1_MPCBB3_SEC14             \ [0x0e] SEC14
    $0f constant GTZC1_MPCBB3_SEC15             \ [0x0f] SEC15
    $10 constant GTZC1_MPCBB3_SEC16             \ [0x10] SEC16
    $11 constant GTZC1_MPCBB3_SEC17             \ [0x11] SEC17
    $12 constant GTZC1_MPCBB3_SEC18             \ [0x12] SEC18
    $13 constant GTZC1_MPCBB3_SEC19             \ [0x13] SEC19
    $14 constant GTZC1_MPCBB3_SEC20             \ [0x14] SEC20
    $15 constant GTZC1_MPCBB3_SEC21             \ [0x15] SEC21
    $16 constant GTZC1_MPCBB3_SEC22             \ [0x16] SEC22
    $17 constant GTZC1_MPCBB3_SEC23             \ [0x17] SEC23
    $18 constant GTZC1_MPCBB3_SEC24             \ [0x18] SEC24
    $19 constant GTZC1_MPCBB3_SEC25             \ [0x19] SEC25
    $1a constant GTZC1_MPCBB3_SEC26             \ [0x1a] SEC26
    $1b constant GTZC1_MPCBB3_SEC27             \ [0x1b] SEC27
    $1c constant GTZC1_MPCBB3_SEC28             \ [0x1c] SEC28
    $1d constant GTZC1_MPCBB3_SEC29             \ [0x1d] SEC29
    $1e constant GTZC1_MPCBB3_SEC30             \ [0x1e] SEC30
    $1f constant GTZC1_MPCBB3_SEC31             \ [0x1f] SEC31
  [then]


  [ifdef] GTZC1_MPCBB3_MPCBB3_SECCFGR48_DEF
    \
    \ @brief MPCBBx security configuration for super-block x register
    \ Address offset: 0x1C0
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GTZC1_MPCBB3_SEC0              \ [0x00] SEC0
    $01 constant GTZC1_MPCBB3_SEC1              \ [0x01] SEC1
    $02 constant GTZC1_MPCBB3_SEC2              \ [0x02] SEC2
    $03 constant GTZC1_MPCBB3_SEC3              \ [0x03] SEC3
    $04 constant GTZC1_MPCBB3_SEC4              \ [0x04] SEC4
    $05 constant GTZC1_MPCBB3_SEC5              \ [0x05] SEC5
    $06 constant GTZC1_MPCBB3_SEC6              \ [0x06] SEC6
    $07 constant GTZC1_MPCBB3_SEC7              \ [0x07] SEC7
    $08 constant GTZC1_MPCBB3_SEC8              \ [0x08] SEC8
    $09 constant GTZC1_MPCBB3_SEC9              \ [0x09] SEC9
    $0a constant GTZC1_MPCBB3_SEC10             \ [0x0a] SEC10
    $0b constant GTZC1_MPCBB3_SEC11             \ [0x0b] SEC11
    $0c constant GTZC1_MPCBB3_SEC12             \ [0x0c] SEC12
    $0d constant GTZC1_MPCBB3_SEC13             \ [0x0d] SEC13
    $0e constant GTZC1_MPCBB3_SEC14             \ [0x0e] SEC14
    $0f constant GTZC1_MPCBB3_SEC15             \ [0x0f] SEC15
    $10 constant GTZC1_MPCBB3_SEC16             \ [0x10] SEC16
    $11 constant GTZC1_MPCBB3_SEC17             \ [0x11] SEC17
    $12 constant GTZC1_MPCBB3_SEC18             \ [0x12] SEC18
    $13 constant GTZC1_MPCBB3_SEC19             \ [0x13] SEC19
    $14 constant GTZC1_MPCBB3_SEC20             \ [0x14] SEC20
    $15 constant GTZC1_MPCBB3_SEC21             \ [0x15] SEC21
    $16 constant GTZC1_MPCBB3_SEC22             \ [0x16] SEC22
    $17 constant GTZC1_MPCBB3_SEC23             \ [0x17] SEC23
    $18 constant GTZC1_MPCBB3_SEC24             \ [0x18] SEC24
    $19 constant GTZC1_MPCBB3_SEC25             \ [0x19] SEC25
    $1a constant GTZC1_MPCBB3_SEC26             \ [0x1a] SEC26
    $1b constant GTZC1_MPCBB3_SEC27             \ [0x1b] SEC27
    $1c constant GTZC1_MPCBB3_SEC28             \ [0x1c] SEC28
    $1d constant GTZC1_MPCBB3_SEC29             \ [0x1d] SEC29
    $1e constant GTZC1_MPCBB3_SEC30             \ [0x1e] SEC30
    $1f constant GTZC1_MPCBB3_SEC31             \ [0x1f] SEC31
  [then]


  [ifdef] GTZC1_MPCBB3_MPCBB3_SECCFGR49_DEF
    \
    \ @brief MPCBBx security configuration for super-block x register
    \ Address offset: 0x1C4
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GTZC1_MPCBB3_SEC0              \ [0x00] SEC0
    $01 constant GTZC1_MPCBB3_SEC1              \ [0x01] SEC1
    $02 constant GTZC1_MPCBB3_SEC2              \ [0x02] SEC2
    $03 constant GTZC1_MPCBB3_SEC3              \ [0x03] SEC3
    $04 constant GTZC1_MPCBB3_SEC4              \ [0x04] SEC4
    $05 constant GTZC1_MPCBB3_SEC5              \ [0x05] SEC5
    $06 constant GTZC1_MPCBB3_SEC6              \ [0x06] SEC6
    $07 constant GTZC1_MPCBB3_SEC7              \ [0x07] SEC7
    $08 constant GTZC1_MPCBB3_SEC8              \ [0x08] SEC8
    $09 constant GTZC1_MPCBB3_SEC9              \ [0x09] SEC9
    $0a constant GTZC1_MPCBB3_SEC10             \ [0x0a] SEC10
    $0b constant GTZC1_MPCBB3_SEC11             \ [0x0b] SEC11
    $0c constant GTZC1_MPCBB3_SEC12             \ [0x0c] SEC12
    $0d constant GTZC1_MPCBB3_SEC13             \ [0x0d] SEC13
    $0e constant GTZC1_MPCBB3_SEC14             \ [0x0e] SEC14
    $0f constant GTZC1_MPCBB3_SEC15             \ [0x0f] SEC15
    $10 constant GTZC1_MPCBB3_SEC16             \ [0x10] SEC16
    $11 constant GTZC1_MPCBB3_SEC17             \ [0x11] SEC17
    $12 constant GTZC1_MPCBB3_SEC18             \ [0x12] SEC18
    $13 constant GTZC1_MPCBB3_SEC19             \ [0x13] SEC19
    $14 constant GTZC1_MPCBB3_SEC20             \ [0x14] SEC20
    $15 constant GTZC1_MPCBB3_SEC21             \ [0x15] SEC21
    $16 constant GTZC1_MPCBB3_SEC22             \ [0x16] SEC22
    $17 constant GTZC1_MPCBB3_SEC23             \ [0x17] SEC23
    $18 constant GTZC1_MPCBB3_SEC24             \ [0x18] SEC24
    $19 constant GTZC1_MPCBB3_SEC25             \ [0x19] SEC25
    $1a constant GTZC1_MPCBB3_SEC26             \ [0x1a] SEC26
    $1b constant GTZC1_MPCBB3_SEC27             \ [0x1b] SEC27
    $1c constant GTZC1_MPCBB3_SEC28             \ [0x1c] SEC28
    $1d constant GTZC1_MPCBB3_SEC29             \ [0x1d] SEC29
    $1e constant GTZC1_MPCBB3_SEC30             \ [0x1e] SEC30
    $1f constant GTZC1_MPCBB3_SEC31             \ [0x1f] SEC31
  [then]


  [ifdef] GTZC1_MPCBB3_MPCBB3_SECCFGR50_DEF
    \
    \ @brief MPCBBx security configuration for super-block x register
    \ Address offset: 0x1C8
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GTZC1_MPCBB3_SEC0              \ [0x00] SEC0
    $01 constant GTZC1_MPCBB3_SEC1              \ [0x01] SEC1
    $02 constant GTZC1_MPCBB3_SEC2              \ [0x02] SEC2
    $03 constant GTZC1_MPCBB3_SEC3              \ [0x03] SEC3
    $04 constant GTZC1_MPCBB3_SEC4              \ [0x04] SEC4
    $05 constant GTZC1_MPCBB3_SEC5              \ [0x05] SEC5
    $06 constant GTZC1_MPCBB3_SEC6              \ [0x06] SEC6
    $07 constant GTZC1_MPCBB3_SEC7              \ [0x07] SEC7
    $08 constant GTZC1_MPCBB3_SEC8              \ [0x08] SEC8
    $09 constant GTZC1_MPCBB3_SEC9              \ [0x09] SEC9
    $0a constant GTZC1_MPCBB3_SEC10             \ [0x0a] SEC10
    $0b constant GTZC1_MPCBB3_SEC11             \ [0x0b] SEC11
    $0c constant GTZC1_MPCBB3_SEC12             \ [0x0c] SEC12
    $0d constant GTZC1_MPCBB3_SEC13             \ [0x0d] SEC13
    $0e constant GTZC1_MPCBB3_SEC14             \ [0x0e] SEC14
    $0f constant GTZC1_MPCBB3_SEC15             \ [0x0f] SEC15
    $10 constant GTZC1_MPCBB3_SEC16             \ [0x10] SEC16
    $11 constant GTZC1_MPCBB3_SEC17             \ [0x11] SEC17
    $12 constant GTZC1_MPCBB3_SEC18             \ [0x12] SEC18
    $13 constant GTZC1_MPCBB3_SEC19             \ [0x13] SEC19
    $14 constant GTZC1_MPCBB3_SEC20             \ [0x14] SEC20
    $15 constant GTZC1_MPCBB3_SEC21             \ [0x15] SEC21
    $16 constant GTZC1_MPCBB3_SEC22             \ [0x16] SEC22
    $17 constant GTZC1_MPCBB3_SEC23             \ [0x17] SEC23
    $18 constant GTZC1_MPCBB3_SEC24             \ [0x18] SEC24
    $19 constant GTZC1_MPCBB3_SEC25             \ [0x19] SEC25
    $1a constant GTZC1_MPCBB3_SEC26             \ [0x1a] SEC26
    $1b constant GTZC1_MPCBB3_SEC27             \ [0x1b] SEC27
    $1c constant GTZC1_MPCBB3_SEC28             \ [0x1c] SEC28
    $1d constant GTZC1_MPCBB3_SEC29             \ [0x1d] SEC29
    $1e constant GTZC1_MPCBB3_SEC30             \ [0x1e] SEC30
    $1f constant GTZC1_MPCBB3_SEC31             \ [0x1f] SEC31
  [then]


  [ifdef] GTZC1_MPCBB3_MPCBB3_SECCFGR51_DEF
    \
    \ @brief MPCBBx security configuration for super-block x register
    \ Address offset: 0x1CC
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GTZC1_MPCBB3_SEC0              \ [0x00] SEC0
    $01 constant GTZC1_MPCBB3_SEC1              \ [0x01] SEC1
    $02 constant GTZC1_MPCBB3_SEC2              \ [0x02] SEC2
    $03 constant GTZC1_MPCBB3_SEC3              \ [0x03] SEC3
    $04 constant GTZC1_MPCBB3_SEC4              \ [0x04] SEC4
    $05 constant GTZC1_MPCBB3_SEC5              \ [0x05] SEC5
    $06 constant GTZC1_MPCBB3_SEC6              \ [0x06] SEC6
    $07 constant GTZC1_MPCBB3_SEC7              \ [0x07] SEC7
    $08 constant GTZC1_MPCBB3_SEC8              \ [0x08] SEC8
    $09 constant GTZC1_MPCBB3_SEC9              \ [0x09] SEC9
    $0a constant GTZC1_MPCBB3_SEC10             \ [0x0a] SEC10
    $0b constant GTZC1_MPCBB3_SEC11             \ [0x0b] SEC11
    $0c constant GTZC1_MPCBB3_SEC12             \ [0x0c] SEC12
    $0d constant GTZC1_MPCBB3_SEC13             \ [0x0d] SEC13
    $0e constant GTZC1_MPCBB3_SEC14             \ [0x0e] SEC14
    $0f constant GTZC1_MPCBB3_SEC15             \ [0x0f] SEC15
    $10 constant GTZC1_MPCBB3_SEC16             \ [0x10] SEC16
    $11 constant GTZC1_MPCBB3_SEC17             \ [0x11] SEC17
    $12 constant GTZC1_MPCBB3_SEC18             \ [0x12] SEC18
    $13 constant GTZC1_MPCBB3_SEC19             \ [0x13] SEC19
    $14 constant GTZC1_MPCBB3_SEC20             \ [0x14] SEC20
    $15 constant GTZC1_MPCBB3_SEC21             \ [0x15] SEC21
    $16 constant GTZC1_MPCBB3_SEC22             \ [0x16] SEC22
    $17 constant GTZC1_MPCBB3_SEC23             \ [0x17] SEC23
    $18 constant GTZC1_MPCBB3_SEC24             \ [0x18] SEC24
    $19 constant GTZC1_MPCBB3_SEC25             \ [0x19] SEC25
    $1a constant GTZC1_MPCBB3_SEC26             \ [0x1a] SEC26
    $1b constant GTZC1_MPCBB3_SEC27             \ [0x1b] SEC27
    $1c constant GTZC1_MPCBB3_SEC28             \ [0x1c] SEC28
    $1d constant GTZC1_MPCBB3_SEC29             \ [0x1d] SEC29
    $1e constant GTZC1_MPCBB3_SEC30             \ [0x1e] SEC30
    $1f constant GTZC1_MPCBB3_SEC31             \ [0x1f] SEC31
  [then]


  [ifdef] GTZC1_MPCBB3_MPCBB3_PRIVCFGR0_DEF
    \
    \ @brief MPCBB privileged configuration for super-block x register
    \ Address offset: 0x200
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GTZC1_MPCBB3_PRIV0             \ [0x00] PRIV0
    $01 constant GTZC1_MPCBB3_PRIV1             \ [0x01] PRIV1
    $02 constant GTZC1_MPCBB3_PRIV2             \ [0x02] PRIV2
    $03 constant GTZC1_MPCBB3_PRIV3             \ [0x03] PRIV3
    $04 constant GTZC1_MPCBB3_PRIV4             \ [0x04] PRIV4
    $05 constant GTZC1_MPCBB3_PRIV5             \ [0x05] PRIV5
    $06 constant GTZC1_MPCBB3_PRIV6             \ [0x06] PRIV6
    $07 constant GTZC1_MPCBB3_PRIV7             \ [0x07] PRIV7
    $08 constant GTZC1_MPCBB3_PRIV8             \ [0x08] PRIV8
    $09 constant GTZC1_MPCBB3_PRIV9             \ [0x09] PRIV9
    $0a constant GTZC1_MPCBB3_PRIV10            \ [0x0a] PRIV10
    $0b constant GTZC1_MPCBB3_PRIV11            \ [0x0b] PRIV11
    $0c constant GTZC1_MPCBB3_PRIV12            \ [0x0c] PRIV12
    $0d constant GTZC1_MPCBB3_PRIV13            \ [0x0d] PRIV13
    $0e constant GTZC1_MPCBB3_PRIV14            \ [0x0e] PRIV14
    $0f constant GTZC1_MPCBB3_PRIV15            \ [0x0f] PRIV15
    $10 constant GTZC1_MPCBB3_PRIV16            \ [0x10] PRIV16
    $11 constant GTZC1_MPCBB3_PRIV17            \ [0x11] PRIV17
    $12 constant GTZC1_MPCBB3_PRIV18            \ [0x12] PRIV18
    $13 constant GTZC1_MPCBB3_PRIV19            \ [0x13] PRIV19
    $14 constant GTZC1_MPCBB3_PRIV20            \ [0x14] PRIV20
    $15 constant GTZC1_MPCBB3_PRIV21            \ [0x15] PRIV21
    $16 constant GTZC1_MPCBB3_PRIV22            \ [0x16] PRIV22
    $17 constant GTZC1_MPCBB3_PRIV23            \ [0x17] PRIV23
    $18 constant GTZC1_MPCBB3_PRIV24            \ [0x18] PRIV24
    $19 constant GTZC1_MPCBB3_PRIV25            \ [0x19] PRIV25
    $1a constant GTZC1_MPCBB3_PRIV26            \ [0x1a] PRIV26
    $1b constant GTZC1_MPCBB3_PRIV27            \ [0x1b] PRIV27
    $1c constant GTZC1_MPCBB3_PRIV28            \ [0x1c] PRIV28
    $1d constant GTZC1_MPCBB3_PRIV29            \ [0x1d] PRIV29
    $1e constant GTZC1_MPCBB3_PRIV30            \ [0x1e] PRIV30
    $1f constant GTZC1_MPCBB3_PRIV31            \ [0x1f] PRIV31
  [then]


  [ifdef] GTZC1_MPCBB3_MPCBB3_PRIVCFGR1_DEF
    \
    \ @brief MPCBB privileged configuration for super-block x register
    \ Address offset: 0x204
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GTZC1_MPCBB3_PRIV0             \ [0x00] PRIV0
    $01 constant GTZC1_MPCBB3_PRIV1             \ [0x01] PRIV1
    $02 constant GTZC1_MPCBB3_PRIV2             \ [0x02] PRIV2
    $03 constant GTZC1_MPCBB3_PRIV3             \ [0x03] PRIV3
    $04 constant GTZC1_MPCBB3_PRIV4             \ [0x04] PRIV4
    $05 constant GTZC1_MPCBB3_PRIV5             \ [0x05] PRIV5
    $06 constant GTZC1_MPCBB3_PRIV6             \ [0x06] PRIV6
    $07 constant GTZC1_MPCBB3_PRIV7             \ [0x07] PRIV7
    $08 constant GTZC1_MPCBB3_PRIV8             \ [0x08] PRIV8
    $09 constant GTZC1_MPCBB3_PRIV9             \ [0x09] PRIV9
    $0a constant GTZC1_MPCBB3_PRIV10            \ [0x0a] PRIV10
    $0b constant GTZC1_MPCBB3_PRIV11            \ [0x0b] PRIV11
    $0c constant GTZC1_MPCBB3_PRIV12            \ [0x0c] PRIV12
    $0d constant GTZC1_MPCBB3_PRIV13            \ [0x0d] PRIV13
    $0e constant GTZC1_MPCBB3_PRIV14            \ [0x0e] PRIV14
    $0f constant GTZC1_MPCBB3_PRIV15            \ [0x0f] PRIV15
    $10 constant GTZC1_MPCBB3_PRIV16            \ [0x10] PRIV16
    $11 constant GTZC1_MPCBB3_PRIV17            \ [0x11] PRIV17
    $12 constant GTZC1_MPCBB3_PRIV18            \ [0x12] PRIV18
    $13 constant GTZC1_MPCBB3_PRIV19            \ [0x13] PRIV19
    $14 constant GTZC1_MPCBB3_PRIV20            \ [0x14] PRIV20
    $15 constant GTZC1_MPCBB3_PRIV21            \ [0x15] PRIV21
    $16 constant GTZC1_MPCBB3_PRIV22            \ [0x16] PRIV22
    $17 constant GTZC1_MPCBB3_PRIV23            \ [0x17] PRIV23
    $18 constant GTZC1_MPCBB3_PRIV24            \ [0x18] PRIV24
    $19 constant GTZC1_MPCBB3_PRIV25            \ [0x19] PRIV25
    $1a constant GTZC1_MPCBB3_PRIV26            \ [0x1a] PRIV26
    $1b constant GTZC1_MPCBB3_PRIV27            \ [0x1b] PRIV27
    $1c constant GTZC1_MPCBB3_PRIV28            \ [0x1c] PRIV28
    $1d constant GTZC1_MPCBB3_PRIV29            \ [0x1d] PRIV29
    $1e constant GTZC1_MPCBB3_PRIV30            \ [0x1e] PRIV30
    $1f constant GTZC1_MPCBB3_PRIV31            \ [0x1f] PRIV31
  [then]


  [ifdef] GTZC1_MPCBB3_MPCBB3_PRIVCFGR2_DEF
    \
    \ @brief MPCBB privileged configuration for super-block x register
    \ Address offset: 0x208
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GTZC1_MPCBB3_PRIV0             \ [0x00] PRIV0
    $01 constant GTZC1_MPCBB3_PRIV1             \ [0x01] PRIV1
    $02 constant GTZC1_MPCBB3_PRIV2             \ [0x02] PRIV2
    $03 constant GTZC1_MPCBB3_PRIV3             \ [0x03] PRIV3
    $04 constant GTZC1_MPCBB3_PRIV4             \ [0x04] PRIV4
    $05 constant GTZC1_MPCBB3_PRIV5             \ [0x05] PRIV5
    $06 constant GTZC1_MPCBB3_PRIV6             \ [0x06] PRIV6
    $07 constant GTZC1_MPCBB3_PRIV7             \ [0x07] PRIV7
    $08 constant GTZC1_MPCBB3_PRIV8             \ [0x08] PRIV8
    $09 constant GTZC1_MPCBB3_PRIV9             \ [0x09] PRIV9
    $0a constant GTZC1_MPCBB3_PRIV10            \ [0x0a] PRIV10
    $0b constant GTZC1_MPCBB3_PRIV11            \ [0x0b] PRIV11
    $0c constant GTZC1_MPCBB3_PRIV12            \ [0x0c] PRIV12
    $0d constant GTZC1_MPCBB3_PRIV13            \ [0x0d] PRIV13
    $0e constant GTZC1_MPCBB3_PRIV14            \ [0x0e] PRIV14
    $0f constant GTZC1_MPCBB3_PRIV15            \ [0x0f] PRIV15
    $10 constant GTZC1_MPCBB3_PRIV16            \ [0x10] PRIV16
    $11 constant GTZC1_MPCBB3_PRIV17            \ [0x11] PRIV17
    $12 constant GTZC1_MPCBB3_PRIV18            \ [0x12] PRIV18
    $13 constant GTZC1_MPCBB3_PRIV19            \ [0x13] PRIV19
    $14 constant GTZC1_MPCBB3_PRIV20            \ [0x14] PRIV20
    $15 constant GTZC1_MPCBB3_PRIV21            \ [0x15] PRIV21
    $16 constant GTZC1_MPCBB3_PRIV22            \ [0x16] PRIV22
    $17 constant GTZC1_MPCBB3_PRIV23            \ [0x17] PRIV23
    $18 constant GTZC1_MPCBB3_PRIV24            \ [0x18] PRIV24
    $19 constant GTZC1_MPCBB3_PRIV25            \ [0x19] PRIV25
    $1a constant GTZC1_MPCBB3_PRIV26            \ [0x1a] PRIV26
    $1b constant GTZC1_MPCBB3_PRIV27            \ [0x1b] PRIV27
    $1c constant GTZC1_MPCBB3_PRIV28            \ [0x1c] PRIV28
    $1d constant GTZC1_MPCBB3_PRIV29            \ [0x1d] PRIV29
    $1e constant GTZC1_MPCBB3_PRIV30            \ [0x1e] PRIV30
    $1f constant GTZC1_MPCBB3_PRIV31            \ [0x1f] PRIV31
  [then]


  [ifdef] GTZC1_MPCBB3_MPCBB3_PRIVCFGR3_DEF
    \
    \ @brief MPCBB privileged configuration for super-block x register
    \ Address offset: 0x20C
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GTZC1_MPCBB3_PRIV0             \ [0x00] PRIV0
    $01 constant GTZC1_MPCBB3_PRIV1             \ [0x01] PRIV1
    $02 constant GTZC1_MPCBB3_PRIV2             \ [0x02] PRIV2
    $03 constant GTZC1_MPCBB3_PRIV3             \ [0x03] PRIV3
    $04 constant GTZC1_MPCBB3_PRIV4             \ [0x04] PRIV4
    $05 constant GTZC1_MPCBB3_PRIV5             \ [0x05] PRIV5
    $06 constant GTZC1_MPCBB3_PRIV6             \ [0x06] PRIV6
    $07 constant GTZC1_MPCBB3_PRIV7             \ [0x07] PRIV7
    $08 constant GTZC1_MPCBB3_PRIV8             \ [0x08] PRIV8
    $09 constant GTZC1_MPCBB3_PRIV9             \ [0x09] PRIV9
    $0a constant GTZC1_MPCBB3_PRIV10            \ [0x0a] PRIV10
    $0b constant GTZC1_MPCBB3_PRIV11            \ [0x0b] PRIV11
    $0c constant GTZC1_MPCBB3_PRIV12            \ [0x0c] PRIV12
    $0d constant GTZC1_MPCBB3_PRIV13            \ [0x0d] PRIV13
    $0e constant GTZC1_MPCBB3_PRIV14            \ [0x0e] PRIV14
    $0f constant GTZC1_MPCBB3_PRIV15            \ [0x0f] PRIV15
    $10 constant GTZC1_MPCBB3_PRIV16            \ [0x10] PRIV16
    $11 constant GTZC1_MPCBB3_PRIV17            \ [0x11] PRIV17
    $12 constant GTZC1_MPCBB3_PRIV18            \ [0x12] PRIV18
    $13 constant GTZC1_MPCBB3_PRIV19            \ [0x13] PRIV19
    $14 constant GTZC1_MPCBB3_PRIV20            \ [0x14] PRIV20
    $15 constant GTZC1_MPCBB3_PRIV21            \ [0x15] PRIV21
    $16 constant GTZC1_MPCBB3_PRIV22            \ [0x16] PRIV22
    $17 constant GTZC1_MPCBB3_PRIV23            \ [0x17] PRIV23
    $18 constant GTZC1_MPCBB3_PRIV24            \ [0x18] PRIV24
    $19 constant GTZC1_MPCBB3_PRIV25            \ [0x19] PRIV25
    $1a constant GTZC1_MPCBB3_PRIV26            \ [0x1a] PRIV26
    $1b constant GTZC1_MPCBB3_PRIV27            \ [0x1b] PRIV27
    $1c constant GTZC1_MPCBB3_PRIV28            \ [0x1c] PRIV28
    $1d constant GTZC1_MPCBB3_PRIV29            \ [0x1d] PRIV29
    $1e constant GTZC1_MPCBB3_PRIV30            \ [0x1e] PRIV30
    $1f constant GTZC1_MPCBB3_PRIV31            \ [0x1f] PRIV31
  [then]


  [ifdef] GTZC1_MPCBB3_MPCBB3_PRIVCFGR4_DEF
    \
    \ @brief MPCBB privileged configuration for super-block x register
    \ Address offset: 0x210
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GTZC1_MPCBB3_PRIV0             \ [0x00] PRIV0
    $01 constant GTZC1_MPCBB3_PRIV1             \ [0x01] PRIV1
    $02 constant GTZC1_MPCBB3_PRIV2             \ [0x02] PRIV2
    $03 constant GTZC1_MPCBB3_PRIV3             \ [0x03] PRIV3
    $04 constant GTZC1_MPCBB3_PRIV4             \ [0x04] PRIV4
    $05 constant GTZC1_MPCBB3_PRIV5             \ [0x05] PRIV5
    $06 constant GTZC1_MPCBB3_PRIV6             \ [0x06] PRIV6
    $07 constant GTZC1_MPCBB3_PRIV7             \ [0x07] PRIV7
    $08 constant GTZC1_MPCBB3_PRIV8             \ [0x08] PRIV8
    $09 constant GTZC1_MPCBB3_PRIV9             \ [0x09] PRIV9
    $0a constant GTZC1_MPCBB3_PRIV10            \ [0x0a] PRIV10
    $0b constant GTZC1_MPCBB3_PRIV11            \ [0x0b] PRIV11
    $0c constant GTZC1_MPCBB3_PRIV12            \ [0x0c] PRIV12
    $0d constant GTZC1_MPCBB3_PRIV13            \ [0x0d] PRIV13
    $0e constant GTZC1_MPCBB3_PRIV14            \ [0x0e] PRIV14
    $0f constant GTZC1_MPCBB3_PRIV15            \ [0x0f] PRIV15
    $10 constant GTZC1_MPCBB3_PRIV16            \ [0x10] PRIV16
    $11 constant GTZC1_MPCBB3_PRIV17            \ [0x11] PRIV17
    $12 constant GTZC1_MPCBB3_PRIV18            \ [0x12] PRIV18
    $13 constant GTZC1_MPCBB3_PRIV19            \ [0x13] PRIV19
    $14 constant GTZC1_MPCBB3_PRIV20            \ [0x14] PRIV20
    $15 constant GTZC1_MPCBB3_PRIV21            \ [0x15] PRIV21
    $16 constant GTZC1_MPCBB3_PRIV22            \ [0x16] PRIV22
    $17 constant GTZC1_MPCBB3_PRIV23            \ [0x17] PRIV23
    $18 constant GTZC1_MPCBB3_PRIV24            \ [0x18] PRIV24
    $19 constant GTZC1_MPCBB3_PRIV25            \ [0x19] PRIV25
    $1a constant GTZC1_MPCBB3_PRIV26            \ [0x1a] PRIV26
    $1b constant GTZC1_MPCBB3_PRIV27            \ [0x1b] PRIV27
    $1c constant GTZC1_MPCBB3_PRIV28            \ [0x1c] PRIV28
    $1d constant GTZC1_MPCBB3_PRIV29            \ [0x1d] PRIV29
    $1e constant GTZC1_MPCBB3_PRIV30            \ [0x1e] PRIV30
    $1f constant GTZC1_MPCBB3_PRIV31            \ [0x1f] PRIV31
  [then]


  [ifdef] GTZC1_MPCBB3_MPCBB3_PRIVCFGR5_DEF
    \
    \ @brief MPCBB privileged configuration for super-block x register
    \ Address offset: 0x214
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GTZC1_MPCBB3_PRIV0             \ [0x00] PRIV0
    $01 constant GTZC1_MPCBB3_PRIV1             \ [0x01] PRIV1
    $02 constant GTZC1_MPCBB3_PRIV2             \ [0x02] PRIV2
    $03 constant GTZC1_MPCBB3_PRIV3             \ [0x03] PRIV3
    $04 constant GTZC1_MPCBB3_PRIV4             \ [0x04] PRIV4
    $05 constant GTZC1_MPCBB3_PRIV5             \ [0x05] PRIV5
    $06 constant GTZC1_MPCBB3_PRIV6             \ [0x06] PRIV6
    $07 constant GTZC1_MPCBB3_PRIV7             \ [0x07] PRIV7
    $08 constant GTZC1_MPCBB3_PRIV8             \ [0x08] PRIV8
    $09 constant GTZC1_MPCBB3_PRIV9             \ [0x09] PRIV9
    $0a constant GTZC1_MPCBB3_PRIV10            \ [0x0a] PRIV10
    $0b constant GTZC1_MPCBB3_PRIV11            \ [0x0b] PRIV11
    $0c constant GTZC1_MPCBB3_PRIV12            \ [0x0c] PRIV12
    $0d constant GTZC1_MPCBB3_PRIV13            \ [0x0d] PRIV13
    $0e constant GTZC1_MPCBB3_PRIV14            \ [0x0e] PRIV14
    $0f constant GTZC1_MPCBB3_PRIV15            \ [0x0f] PRIV15
    $10 constant GTZC1_MPCBB3_PRIV16            \ [0x10] PRIV16
    $11 constant GTZC1_MPCBB3_PRIV17            \ [0x11] PRIV17
    $12 constant GTZC1_MPCBB3_PRIV18            \ [0x12] PRIV18
    $13 constant GTZC1_MPCBB3_PRIV19            \ [0x13] PRIV19
    $14 constant GTZC1_MPCBB3_PRIV20            \ [0x14] PRIV20
    $15 constant GTZC1_MPCBB3_PRIV21            \ [0x15] PRIV21
    $16 constant GTZC1_MPCBB3_PRIV22            \ [0x16] PRIV22
    $17 constant GTZC1_MPCBB3_PRIV23            \ [0x17] PRIV23
    $18 constant GTZC1_MPCBB3_PRIV24            \ [0x18] PRIV24
    $19 constant GTZC1_MPCBB3_PRIV25            \ [0x19] PRIV25
    $1a constant GTZC1_MPCBB3_PRIV26            \ [0x1a] PRIV26
    $1b constant GTZC1_MPCBB3_PRIV27            \ [0x1b] PRIV27
    $1c constant GTZC1_MPCBB3_PRIV28            \ [0x1c] PRIV28
    $1d constant GTZC1_MPCBB3_PRIV29            \ [0x1d] PRIV29
    $1e constant GTZC1_MPCBB3_PRIV30            \ [0x1e] PRIV30
    $1f constant GTZC1_MPCBB3_PRIV31            \ [0x1f] PRIV31
  [then]


  [ifdef] GTZC1_MPCBB3_MPCBB3_PRIVCFGR6_DEF
    \
    \ @brief MPCBB privileged configuration for super-block x register
    \ Address offset: 0x218
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GTZC1_MPCBB3_PRIV0             \ [0x00] PRIV0
    $01 constant GTZC1_MPCBB3_PRIV1             \ [0x01] PRIV1
    $02 constant GTZC1_MPCBB3_PRIV2             \ [0x02] PRIV2
    $03 constant GTZC1_MPCBB3_PRIV3             \ [0x03] PRIV3
    $04 constant GTZC1_MPCBB3_PRIV4             \ [0x04] PRIV4
    $05 constant GTZC1_MPCBB3_PRIV5             \ [0x05] PRIV5
    $06 constant GTZC1_MPCBB3_PRIV6             \ [0x06] PRIV6
    $07 constant GTZC1_MPCBB3_PRIV7             \ [0x07] PRIV7
    $08 constant GTZC1_MPCBB3_PRIV8             \ [0x08] PRIV8
    $09 constant GTZC1_MPCBB3_PRIV9             \ [0x09] PRIV9
    $0a constant GTZC1_MPCBB3_PRIV10            \ [0x0a] PRIV10
    $0b constant GTZC1_MPCBB3_PRIV11            \ [0x0b] PRIV11
    $0c constant GTZC1_MPCBB3_PRIV12            \ [0x0c] PRIV12
    $0d constant GTZC1_MPCBB3_PRIV13            \ [0x0d] PRIV13
    $0e constant GTZC1_MPCBB3_PRIV14            \ [0x0e] PRIV14
    $0f constant GTZC1_MPCBB3_PRIV15            \ [0x0f] PRIV15
    $10 constant GTZC1_MPCBB3_PRIV16            \ [0x10] PRIV16
    $11 constant GTZC1_MPCBB3_PRIV17            \ [0x11] PRIV17
    $12 constant GTZC1_MPCBB3_PRIV18            \ [0x12] PRIV18
    $13 constant GTZC1_MPCBB3_PRIV19            \ [0x13] PRIV19
    $14 constant GTZC1_MPCBB3_PRIV20            \ [0x14] PRIV20
    $15 constant GTZC1_MPCBB3_PRIV21            \ [0x15] PRIV21
    $16 constant GTZC1_MPCBB3_PRIV22            \ [0x16] PRIV22
    $17 constant GTZC1_MPCBB3_PRIV23            \ [0x17] PRIV23
    $18 constant GTZC1_MPCBB3_PRIV24            \ [0x18] PRIV24
    $19 constant GTZC1_MPCBB3_PRIV25            \ [0x19] PRIV25
    $1a constant GTZC1_MPCBB3_PRIV26            \ [0x1a] PRIV26
    $1b constant GTZC1_MPCBB3_PRIV27            \ [0x1b] PRIV27
    $1c constant GTZC1_MPCBB3_PRIV28            \ [0x1c] PRIV28
    $1d constant GTZC1_MPCBB3_PRIV29            \ [0x1d] PRIV29
    $1e constant GTZC1_MPCBB3_PRIV30            \ [0x1e] PRIV30
    $1f constant GTZC1_MPCBB3_PRIV31            \ [0x1f] PRIV31
  [then]


  [ifdef] GTZC1_MPCBB3_MPCBB3_PRIVCFGR7_DEF
    \
    \ @brief MPCBB privileged configuration for super-block x register
    \ Address offset: 0x21C
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GTZC1_MPCBB3_PRIV0             \ [0x00] PRIV0
    $01 constant GTZC1_MPCBB3_PRIV1             \ [0x01] PRIV1
    $02 constant GTZC1_MPCBB3_PRIV2             \ [0x02] PRIV2
    $03 constant GTZC1_MPCBB3_PRIV3             \ [0x03] PRIV3
    $04 constant GTZC1_MPCBB3_PRIV4             \ [0x04] PRIV4
    $05 constant GTZC1_MPCBB3_PRIV5             \ [0x05] PRIV5
    $06 constant GTZC1_MPCBB3_PRIV6             \ [0x06] PRIV6
    $07 constant GTZC1_MPCBB3_PRIV7             \ [0x07] PRIV7
    $08 constant GTZC1_MPCBB3_PRIV8             \ [0x08] PRIV8
    $09 constant GTZC1_MPCBB3_PRIV9             \ [0x09] PRIV9
    $0a constant GTZC1_MPCBB3_PRIV10            \ [0x0a] PRIV10
    $0b constant GTZC1_MPCBB3_PRIV11            \ [0x0b] PRIV11
    $0c constant GTZC1_MPCBB3_PRIV12            \ [0x0c] PRIV12
    $0d constant GTZC1_MPCBB3_PRIV13            \ [0x0d] PRIV13
    $0e constant GTZC1_MPCBB3_PRIV14            \ [0x0e] PRIV14
    $0f constant GTZC1_MPCBB3_PRIV15            \ [0x0f] PRIV15
    $10 constant GTZC1_MPCBB3_PRIV16            \ [0x10] PRIV16
    $11 constant GTZC1_MPCBB3_PRIV17            \ [0x11] PRIV17
    $12 constant GTZC1_MPCBB3_PRIV18            \ [0x12] PRIV18
    $13 constant GTZC1_MPCBB3_PRIV19            \ [0x13] PRIV19
    $14 constant GTZC1_MPCBB3_PRIV20            \ [0x14] PRIV20
    $15 constant GTZC1_MPCBB3_PRIV21            \ [0x15] PRIV21
    $16 constant GTZC1_MPCBB3_PRIV22            \ [0x16] PRIV22
    $17 constant GTZC1_MPCBB3_PRIV23            \ [0x17] PRIV23
    $18 constant GTZC1_MPCBB3_PRIV24            \ [0x18] PRIV24
    $19 constant GTZC1_MPCBB3_PRIV25            \ [0x19] PRIV25
    $1a constant GTZC1_MPCBB3_PRIV26            \ [0x1a] PRIV26
    $1b constant GTZC1_MPCBB3_PRIV27            \ [0x1b] PRIV27
    $1c constant GTZC1_MPCBB3_PRIV28            \ [0x1c] PRIV28
    $1d constant GTZC1_MPCBB3_PRIV29            \ [0x1d] PRIV29
    $1e constant GTZC1_MPCBB3_PRIV30            \ [0x1e] PRIV30
    $1f constant GTZC1_MPCBB3_PRIV31            \ [0x1f] PRIV31
  [then]


  [ifdef] GTZC1_MPCBB3_MPCBB3_PRIVCFGR8_DEF
    \
    \ @brief MPCBB privileged configuration for super-block x register
    \ Address offset: 0x220
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GTZC1_MPCBB3_PRIV0             \ [0x00] PRIV0
    $01 constant GTZC1_MPCBB3_PRIV1             \ [0x01] PRIV1
    $02 constant GTZC1_MPCBB3_PRIV2             \ [0x02] PRIV2
    $03 constant GTZC1_MPCBB3_PRIV3             \ [0x03] PRIV3
    $04 constant GTZC1_MPCBB3_PRIV4             \ [0x04] PRIV4
    $05 constant GTZC1_MPCBB3_PRIV5             \ [0x05] PRIV5
    $06 constant GTZC1_MPCBB3_PRIV6             \ [0x06] PRIV6
    $07 constant GTZC1_MPCBB3_PRIV7             \ [0x07] PRIV7
    $08 constant GTZC1_MPCBB3_PRIV8             \ [0x08] PRIV8
    $09 constant GTZC1_MPCBB3_PRIV9             \ [0x09] PRIV9
    $0a constant GTZC1_MPCBB3_PRIV10            \ [0x0a] PRIV10
    $0b constant GTZC1_MPCBB3_PRIV11            \ [0x0b] PRIV11
    $0c constant GTZC1_MPCBB3_PRIV12            \ [0x0c] PRIV12
    $0d constant GTZC1_MPCBB3_PRIV13            \ [0x0d] PRIV13
    $0e constant GTZC1_MPCBB3_PRIV14            \ [0x0e] PRIV14
    $0f constant GTZC1_MPCBB3_PRIV15            \ [0x0f] PRIV15
    $10 constant GTZC1_MPCBB3_PRIV16            \ [0x10] PRIV16
    $11 constant GTZC1_MPCBB3_PRIV17            \ [0x11] PRIV17
    $12 constant GTZC1_MPCBB3_PRIV18            \ [0x12] PRIV18
    $13 constant GTZC1_MPCBB3_PRIV19            \ [0x13] PRIV19
    $14 constant GTZC1_MPCBB3_PRIV20            \ [0x14] PRIV20
    $15 constant GTZC1_MPCBB3_PRIV21            \ [0x15] PRIV21
    $16 constant GTZC1_MPCBB3_PRIV22            \ [0x16] PRIV22
    $17 constant GTZC1_MPCBB3_PRIV23            \ [0x17] PRIV23
    $18 constant GTZC1_MPCBB3_PRIV24            \ [0x18] PRIV24
    $19 constant GTZC1_MPCBB3_PRIV25            \ [0x19] PRIV25
    $1a constant GTZC1_MPCBB3_PRIV26            \ [0x1a] PRIV26
    $1b constant GTZC1_MPCBB3_PRIV27            \ [0x1b] PRIV27
    $1c constant GTZC1_MPCBB3_PRIV28            \ [0x1c] PRIV28
    $1d constant GTZC1_MPCBB3_PRIV29            \ [0x1d] PRIV29
    $1e constant GTZC1_MPCBB3_PRIV30            \ [0x1e] PRIV30
    $1f constant GTZC1_MPCBB3_PRIV31            \ [0x1f] PRIV31
  [then]


  [ifdef] GTZC1_MPCBB3_MPCBB3_PRIVCFGR9_DEF
    \
    \ @brief MPCBB privileged configuration for super-block x register
    \ Address offset: 0x224
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GTZC1_MPCBB3_PRIV0             \ [0x00] PRIV0
    $01 constant GTZC1_MPCBB3_PRIV1             \ [0x01] PRIV1
    $02 constant GTZC1_MPCBB3_PRIV2             \ [0x02] PRIV2
    $03 constant GTZC1_MPCBB3_PRIV3             \ [0x03] PRIV3
    $04 constant GTZC1_MPCBB3_PRIV4             \ [0x04] PRIV4
    $05 constant GTZC1_MPCBB3_PRIV5             \ [0x05] PRIV5
    $06 constant GTZC1_MPCBB3_PRIV6             \ [0x06] PRIV6
    $07 constant GTZC1_MPCBB3_PRIV7             \ [0x07] PRIV7
    $08 constant GTZC1_MPCBB3_PRIV8             \ [0x08] PRIV8
    $09 constant GTZC1_MPCBB3_PRIV9             \ [0x09] PRIV9
    $0a constant GTZC1_MPCBB3_PRIV10            \ [0x0a] PRIV10
    $0b constant GTZC1_MPCBB3_PRIV11            \ [0x0b] PRIV11
    $0c constant GTZC1_MPCBB3_PRIV12            \ [0x0c] PRIV12
    $0d constant GTZC1_MPCBB3_PRIV13            \ [0x0d] PRIV13
    $0e constant GTZC1_MPCBB3_PRIV14            \ [0x0e] PRIV14
    $0f constant GTZC1_MPCBB3_PRIV15            \ [0x0f] PRIV15
    $10 constant GTZC1_MPCBB3_PRIV16            \ [0x10] PRIV16
    $11 constant GTZC1_MPCBB3_PRIV17            \ [0x11] PRIV17
    $12 constant GTZC1_MPCBB3_PRIV18            \ [0x12] PRIV18
    $13 constant GTZC1_MPCBB3_PRIV19            \ [0x13] PRIV19
    $14 constant GTZC1_MPCBB3_PRIV20            \ [0x14] PRIV20
    $15 constant GTZC1_MPCBB3_PRIV21            \ [0x15] PRIV21
    $16 constant GTZC1_MPCBB3_PRIV22            \ [0x16] PRIV22
    $17 constant GTZC1_MPCBB3_PRIV23            \ [0x17] PRIV23
    $18 constant GTZC1_MPCBB3_PRIV24            \ [0x18] PRIV24
    $19 constant GTZC1_MPCBB3_PRIV25            \ [0x19] PRIV25
    $1a constant GTZC1_MPCBB3_PRIV26            \ [0x1a] PRIV26
    $1b constant GTZC1_MPCBB3_PRIV27            \ [0x1b] PRIV27
    $1c constant GTZC1_MPCBB3_PRIV28            \ [0x1c] PRIV28
    $1d constant GTZC1_MPCBB3_PRIV29            \ [0x1d] PRIV29
    $1e constant GTZC1_MPCBB3_PRIV30            \ [0x1e] PRIV30
    $1f constant GTZC1_MPCBB3_PRIV31            \ [0x1f] PRIV31
  [then]


  [ifdef] GTZC1_MPCBB3_MPCBB3_PRIVCFGR10_DEF
    \
    \ @brief MPCBB privileged configuration for super-block x register
    \ Address offset: 0x228
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GTZC1_MPCBB3_PRIV0             \ [0x00] PRIV0
    $01 constant GTZC1_MPCBB3_PRIV1             \ [0x01] PRIV1
    $02 constant GTZC1_MPCBB3_PRIV2             \ [0x02] PRIV2
    $03 constant GTZC1_MPCBB3_PRIV3             \ [0x03] PRIV3
    $04 constant GTZC1_MPCBB3_PRIV4             \ [0x04] PRIV4
    $05 constant GTZC1_MPCBB3_PRIV5             \ [0x05] PRIV5
    $06 constant GTZC1_MPCBB3_PRIV6             \ [0x06] PRIV6
    $07 constant GTZC1_MPCBB3_PRIV7             \ [0x07] PRIV7
    $08 constant GTZC1_MPCBB3_PRIV8             \ [0x08] PRIV8
    $09 constant GTZC1_MPCBB3_PRIV9             \ [0x09] PRIV9
    $0a constant GTZC1_MPCBB3_PRIV10            \ [0x0a] PRIV10
    $0b constant GTZC1_MPCBB3_PRIV11            \ [0x0b] PRIV11
    $0c constant GTZC1_MPCBB3_PRIV12            \ [0x0c] PRIV12
    $0d constant GTZC1_MPCBB3_PRIV13            \ [0x0d] PRIV13
    $0e constant GTZC1_MPCBB3_PRIV14            \ [0x0e] PRIV14
    $0f constant GTZC1_MPCBB3_PRIV15            \ [0x0f] PRIV15
    $10 constant GTZC1_MPCBB3_PRIV16            \ [0x10] PRIV16
    $11 constant GTZC1_MPCBB3_PRIV17            \ [0x11] PRIV17
    $12 constant GTZC1_MPCBB3_PRIV18            \ [0x12] PRIV18
    $13 constant GTZC1_MPCBB3_PRIV19            \ [0x13] PRIV19
    $14 constant GTZC1_MPCBB3_PRIV20            \ [0x14] PRIV20
    $15 constant GTZC1_MPCBB3_PRIV21            \ [0x15] PRIV21
    $16 constant GTZC1_MPCBB3_PRIV22            \ [0x16] PRIV22
    $17 constant GTZC1_MPCBB3_PRIV23            \ [0x17] PRIV23
    $18 constant GTZC1_MPCBB3_PRIV24            \ [0x18] PRIV24
    $19 constant GTZC1_MPCBB3_PRIV25            \ [0x19] PRIV25
    $1a constant GTZC1_MPCBB3_PRIV26            \ [0x1a] PRIV26
    $1b constant GTZC1_MPCBB3_PRIV27            \ [0x1b] PRIV27
    $1c constant GTZC1_MPCBB3_PRIV28            \ [0x1c] PRIV28
    $1d constant GTZC1_MPCBB3_PRIV29            \ [0x1d] PRIV29
    $1e constant GTZC1_MPCBB3_PRIV30            \ [0x1e] PRIV30
    $1f constant GTZC1_MPCBB3_PRIV31            \ [0x1f] PRIV31
  [then]


  [ifdef] GTZC1_MPCBB3_MPCBB3_PRIVCFGR11_DEF
    \
    \ @brief MPCBB privileged configuration for super-block x register
    \ Address offset: 0x22C
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GTZC1_MPCBB3_PRIV0             \ [0x00] PRIV0
    $01 constant GTZC1_MPCBB3_PRIV1             \ [0x01] PRIV1
    $02 constant GTZC1_MPCBB3_PRIV2             \ [0x02] PRIV2
    $03 constant GTZC1_MPCBB3_PRIV3             \ [0x03] PRIV3
    $04 constant GTZC1_MPCBB3_PRIV4             \ [0x04] PRIV4
    $05 constant GTZC1_MPCBB3_PRIV5             \ [0x05] PRIV5
    $06 constant GTZC1_MPCBB3_PRIV6             \ [0x06] PRIV6
    $07 constant GTZC1_MPCBB3_PRIV7             \ [0x07] PRIV7
    $08 constant GTZC1_MPCBB3_PRIV8             \ [0x08] PRIV8
    $09 constant GTZC1_MPCBB3_PRIV9             \ [0x09] PRIV9
    $0a constant GTZC1_MPCBB3_PRIV10            \ [0x0a] PRIV10
    $0b constant GTZC1_MPCBB3_PRIV11            \ [0x0b] PRIV11
    $0c constant GTZC1_MPCBB3_PRIV12            \ [0x0c] PRIV12
    $0d constant GTZC1_MPCBB3_PRIV13            \ [0x0d] PRIV13
    $0e constant GTZC1_MPCBB3_PRIV14            \ [0x0e] PRIV14
    $0f constant GTZC1_MPCBB3_PRIV15            \ [0x0f] PRIV15
    $10 constant GTZC1_MPCBB3_PRIV16            \ [0x10] PRIV16
    $11 constant GTZC1_MPCBB3_PRIV17            \ [0x11] PRIV17
    $12 constant GTZC1_MPCBB3_PRIV18            \ [0x12] PRIV18
    $13 constant GTZC1_MPCBB3_PRIV19            \ [0x13] PRIV19
    $14 constant GTZC1_MPCBB3_PRIV20            \ [0x14] PRIV20
    $15 constant GTZC1_MPCBB3_PRIV21            \ [0x15] PRIV21
    $16 constant GTZC1_MPCBB3_PRIV22            \ [0x16] PRIV22
    $17 constant GTZC1_MPCBB3_PRIV23            \ [0x17] PRIV23
    $18 constant GTZC1_MPCBB3_PRIV24            \ [0x18] PRIV24
    $19 constant GTZC1_MPCBB3_PRIV25            \ [0x19] PRIV25
    $1a constant GTZC1_MPCBB3_PRIV26            \ [0x1a] PRIV26
    $1b constant GTZC1_MPCBB3_PRIV27            \ [0x1b] PRIV27
    $1c constant GTZC1_MPCBB3_PRIV28            \ [0x1c] PRIV28
    $1d constant GTZC1_MPCBB3_PRIV29            \ [0x1d] PRIV29
    $1e constant GTZC1_MPCBB3_PRIV30            \ [0x1e] PRIV30
    $1f constant GTZC1_MPCBB3_PRIV31            \ [0x1f] PRIV31
  [then]


  [ifdef] GTZC1_MPCBB3_MPCBB3_PRIVCFGR12_DEF
    \
    \ @brief MPCBB privileged configuration for super-block x register
    \ Address offset: 0x230
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GTZC1_MPCBB3_PRIV0             \ [0x00] PRIV0
    $01 constant GTZC1_MPCBB3_PRIV1             \ [0x01] PRIV1
    $02 constant GTZC1_MPCBB3_PRIV2             \ [0x02] PRIV2
    $03 constant GTZC1_MPCBB3_PRIV3             \ [0x03] PRIV3
    $04 constant GTZC1_MPCBB3_PRIV4             \ [0x04] PRIV4
    $05 constant GTZC1_MPCBB3_PRIV5             \ [0x05] PRIV5
    $06 constant GTZC1_MPCBB3_PRIV6             \ [0x06] PRIV6
    $07 constant GTZC1_MPCBB3_PRIV7             \ [0x07] PRIV7
    $08 constant GTZC1_MPCBB3_PRIV8             \ [0x08] PRIV8
    $09 constant GTZC1_MPCBB3_PRIV9             \ [0x09] PRIV9
    $0a constant GTZC1_MPCBB3_PRIV10            \ [0x0a] PRIV10
    $0b constant GTZC1_MPCBB3_PRIV11            \ [0x0b] PRIV11
    $0c constant GTZC1_MPCBB3_PRIV12            \ [0x0c] PRIV12
    $0d constant GTZC1_MPCBB3_PRIV13            \ [0x0d] PRIV13
    $0e constant GTZC1_MPCBB3_PRIV14            \ [0x0e] PRIV14
    $0f constant GTZC1_MPCBB3_PRIV15            \ [0x0f] PRIV15
    $10 constant GTZC1_MPCBB3_PRIV16            \ [0x10] PRIV16
    $11 constant GTZC1_MPCBB3_PRIV17            \ [0x11] PRIV17
    $12 constant GTZC1_MPCBB3_PRIV18            \ [0x12] PRIV18
    $13 constant GTZC1_MPCBB3_PRIV19            \ [0x13] PRIV19
    $14 constant GTZC1_MPCBB3_PRIV20            \ [0x14] PRIV20
    $15 constant GTZC1_MPCBB3_PRIV21            \ [0x15] PRIV21
    $16 constant GTZC1_MPCBB3_PRIV22            \ [0x16] PRIV22
    $17 constant GTZC1_MPCBB3_PRIV23            \ [0x17] PRIV23
    $18 constant GTZC1_MPCBB3_PRIV24            \ [0x18] PRIV24
    $19 constant GTZC1_MPCBB3_PRIV25            \ [0x19] PRIV25
    $1a constant GTZC1_MPCBB3_PRIV26            \ [0x1a] PRIV26
    $1b constant GTZC1_MPCBB3_PRIV27            \ [0x1b] PRIV27
    $1c constant GTZC1_MPCBB3_PRIV28            \ [0x1c] PRIV28
    $1d constant GTZC1_MPCBB3_PRIV29            \ [0x1d] PRIV29
    $1e constant GTZC1_MPCBB3_PRIV30            \ [0x1e] PRIV30
    $1f constant GTZC1_MPCBB3_PRIV31            \ [0x1f] PRIV31
  [then]


  [ifdef] GTZC1_MPCBB3_MPCBB3_PRIVCFGR13_DEF
    \
    \ @brief MPCBB privileged configuration for super-block x register
    \ Address offset: 0x234
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GTZC1_MPCBB3_PRIV0             \ [0x00] PRIV0
    $01 constant GTZC1_MPCBB3_PRIV1             \ [0x01] PRIV1
    $02 constant GTZC1_MPCBB3_PRIV2             \ [0x02] PRIV2
    $03 constant GTZC1_MPCBB3_PRIV3             \ [0x03] PRIV3
    $04 constant GTZC1_MPCBB3_PRIV4             \ [0x04] PRIV4
    $05 constant GTZC1_MPCBB3_PRIV5             \ [0x05] PRIV5
    $06 constant GTZC1_MPCBB3_PRIV6             \ [0x06] PRIV6
    $07 constant GTZC1_MPCBB3_PRIV7             \ [0x07] PRIV7
    $08 constant GTZC1_MPCBB3_PRIV8             \ [0x08] PRIV8
    $09 constant GTZC1_MPCBB3_PRIV9             \ [0x09] PRIV9
    $0a constant GTZC1_MPCBB3_PRIV10            \ [0x0a] PRIV10
    $0b constant GTZC1_MPCBB3_PRIV11            \ [0x0b] PRIV11
    $0c constant GTZC1_MPCBB3_PRIV12            \ [0x0c] PRIV12
    $0d constant GTZC1_MPCBB3_PRIV13            \ [0x0d] PRIV13
    $0e constant GTZC1_MPCBB3_PRIV14            \ [0x0e] PRIV14
    $0f constant GTZC1_MPCBB3_PRIV15            \ [0x0f] PRIV15
    $10 constant GTZC1_MPCBB3_PRIV16            \ [0x10] PRIV16
    $11 constant GTZC1_MPCBB3_PRIV17            \ [0x11] PRIV17
    $12 constant GTZC1_MPCBB3_PRIV18            \ [0x12] PRIV18
    $13 constant GTZC1_MPCBB3_PRIV19            \ [0x13] PRIV19
    $14 constant GTZC1_MPCBB3_PRIV20            \ [0x14] PRIV20
    $15 constant GTZC1_MPCBB3_PRIV21            \ [0x15] PRIV21
    $16 constant GTZC1_MPCBB3_PRIV22            \ [0x16] PRIV22
    $17 constant GTZC1_MPCBB3_PRIV23            \ [0x17] PRIV23
    $18 constant GTZC1_MPCBB3_PRIV24            \ [0x18] PRIV24
    $19 constant GTZC1_MPCBB3_PRIV25            \ [0x19] PRIV25
    $1a constant GTZC1_MPCBB3_PRIV26            \ [0x1a] PRIV26
    $1b constant GTZC1_MPCBB3_PRIV27            \ [0x1b] PRIV27
    $1c constant GTZC1_MPCBB3_PRIV28            \ [0x1c] PRIV28
    $1d constant GTZC1_MPCBB3_PRIV29            \ [0x1d] PRIV29
    $1e constant GTZC1_MPCBB3_PRIV30            \ [0x1e] PRIV30
    $1f constant GTZC1_MPCBB3_PRIV31            \ [0x1f] PRIV31
  [then]


  [ifdef] GTZC1_MPCBB3_MPCBB3_PRIVCFGR14_DEF
    \
    \ @brief MPCBB privileged configuration for super-block x register
    \ Address offset: 0x238
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GTZC1_MPCBB3_PRIV0             \ [0x00] PRIV0
    $01 constant GTZC1_MPCBB3_PRIV1             \ [0x01] PRIV1
    $02 constant GTZC1_MPCBB3_PRIV2             \ [0x02] PRIV2
    $03 constant GTZC1_MPCBB3_PRIV3             \ [0x03] PRIV3
    $04 constant GTZC1_MPCBB3_PRIV4             \ [0x04] PRIV4
    $05 constant GTZC1_MPCBB3_PRIV5             \ [0x05] PRIV5
    $06 constant GTZC1_MPCBB3_PRIV6             \ [0x06] PRIV6
    $07 constant GTZC1_MPCBB3_PRIV7             \ [0x07] PRIV7
    $08 constant GTZC1_MPCBB3_PRIV8             \ [0x08] PRIV8
    $09 constant GTZC1_MPCBB3_PRIV9             \ [0x09] PRIV9
    $0a constant GTZC1_MPCBB3_PRIV10            \ [0x0a] PRIV10
    $0b constant GTZC1_MPCBB3_PRIV11            \ [0x0b] PRIV11
    $0c constant GTZC1_MPCBB3_PRIV12            \ [0x0c] PRIV12
    $0d constant GTZC1_MPCBB3_PRIV13            \ [0x0d] PRIV13
    $0e constant GTZC1_MPCBB3_PRIV14            \ [0x0e] PRIV14
    $0f constant GTZC1_MPCBB3_PRIV15            \ [0x0f] PRIV15
    $10 constant GTZC1_MPCBB3_PRIV16            \ [0x10] PRIV16
    $11 constant GTZC1_MPCBB3_PRIV17            \ [0x11] PRIV17
    $12 constant GTZC1_MPCBB3_PRIV18            \ [0x12] PRIV18
    $13 constant GTZC1_MPCBB3_PRIV19            \ [0x13] PRIV19
    $14 constant GTZC1_MPCBB3_PRIV20            \ [0x14] PRIV20
    $15 constant GTZC1_MPCBB3_PRIV21            \ [0x15] PRIV21
    $16 constant GTZC1_MPCBB3_PRIV22            \ [0x16] PRIV22
    $17 constant GTZC1_MPCBB3_PRIV23            \ [0x17] PRIV23
    $18 constant GTZC1_MPCBB3_PRIV24            \ [0x18] PRIV24
    $19 constant GTZC1_MPCBB3_PRIV25            \ [0x19] PRIV25
    $1a constant GTZC1_MPCBB3_PRIV26            \ [0x1a] PRIV26
    $1b constant GTZC1_MPCBB3_PRIV27            \ [0x1b] PRIV27
    $1c constant GTZC1_MPCBB3_PRIV28            \ [0x1c] PRIV28
    $1d constant GTZC1_MPCBB3_PRIV29            \ [0x1d] PRIV29
    $1e constant GTZC1_MPCBB3_PRIV30            \ [0x1e] PRIV30
    $1f constant GTZC1_MPCBB3_PRIV31            \ [0x1f] PRIV31
  [then]


  [ifdef] GTZC1_MPCBB3_MPCBB3_PRIVCFGR15_DEF
    \
    \ @brief MPCBB privileged configuration for super-block x register
    \ Address offset: 0x23C
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GTZC1_MPCBB3_PRIV0             \ [0x00] PRIV0
    $01 constant GTZC1_MPCBB3_PRIV1             \ [0x01] PRIV1
    $02 constant GTZC1_MPCBB3_PRIV2             \ [0x02] PRIV2
    $03 constant GTZC1_MPCBB3_PRIV3             \ [0x03] PRIV3
    $04 constant GTZC1_MPCBB3_PRIV4             \ [0x04] PRIV4
    $05 constant GTZC1_MPCBB3_PRIV5             \ [0x05] PRIV5
    $06 constant GTZC1_MPCBB3_PRIV6             \ [0x06] PRIV6
    $07 constant GTZC1_MPCBB3_PRIV7             \ [0x07] PRIV7
    $08 constant GTZC1_MPCBB3_PRIV8             \ [0x08] PRIV8
    $09 constant GTZC1_MPCBB3_PRIV9             \ [0x09] PRIV9
    $0a constant GTZC1_MPCBB3_PRIV10            \ [0x0a] PRIV10
    $0b constant GTZC1_MPCBB3_PRIV11            \ [0x0b] PRIV11
    $0c constant GTZC1_MPCBB3_PRIV12            \ [0x0c] PRIV12
    $0d constant GTZC1_MPCBB3_PRIV13            \ [0x0d] PRIV13
    $0e constant GTZC1_MPCBB3_PRIV14            \ [0x0e] PRIV14
    $0f constant GTZC1_MPCBB3_PRIV15            \ [0x0f] PRIV15
    $10 constant GTZC1_MPCBB3_PRIV16            \ [0x10] PRIV16
    $11 constant GTZC1_MPCBB3_PRIV17            \ [0x11] PRIV17
    $12 constant GTZC1_MPCBB3_PRIV18            \ [0x12] PRIV18
    $13 constant GTZC1_MPCBB3_PRIV19            \ [0x13] PRIV19
    $14 constant GTZC1_MPCBB3_PRIV20            \ [0x14] PRIV20
    $15 constant GTZC1_MPCBB3_PRIV21            \ [0x15] PRIV21
    $16 constant GTZC1_MPCBB3_PRIV22            \ [0x16] PRIV22
    $17 constant GTZC1_MPCBB3_PRIV23            \ [0x17] PRIV23
    $18 constant GTZC1_MPCBB3_PRIV24            \ [0x18] PRIV24
    $19 constant GTZC1_MPCBB3_PRIV25            \ [0x19] PRIV25
    $1a constant GTZC1_MPCBB3_PRIV26            \ [0x1a] PRIV26
    $1b constant GTZC1_MPCBB3_PRIV27            \ [0x1b] PRIV27
    $1c constant GTZC1_MPCBB3_PRIV28            \ [0x1c] PRIV28
    $1d constant GTZC1_MPCBB3_PRIV29            \ [0x1d] PRIV29
    $1e constant GTZC1_MPCBB3_PRIV30            \ [0x1e] PRIV30
    $1f constant GTZC1_MPCBB3_PRIV31            \ [0x1f] PRIV31
  [then]


  [ifdef] GTZC1_MPCBB3_MPCBB3_PRIVCFGR16_DEF
    \
    \ @brief MPCBB privileged configuration for super-block x register
    \ Address offset: 0x240
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GTZC1_MPCBB3_PRIV0             \ [0x00] PRIV0
    $01 constant GTZC1_MPCBB3_PRIV1             \ [0x01] PRIV1
    $02 constant GTZC1_MPCBB3_PRIV2             \ [0x02] PRIV2
    $03 constant GTZC1_MPCBB3_PRIV3             \ [0x03] PRIV3
    $04 constant GTZC1_MPCBB3_PRIV4             \ [0x04] PRIV4
    $05 constant GTZC1_MPCBB3_PRIV5             \ [0x05] PRIV5
    $06 constant GTZC1_MPCBB3_PRIV6             \ [0x06] PRIV6
    $07 constant GTZC1_MPCBB3_PRIV7             \ [0x07] PRIV7
    $08 constant GTZC1_MPCBB3_PRIV8             \ [0x08] PRIV8
    $09 constant GTZC1_MPCBB3_PRIV9             \ [0x09] PRIV9
    $0a constant GTZC1_MPCBB3_PRIV10            \ [0x0a] PRIV10
    $0b constant GTZC1_MPCBB3_PRIV11            \ [0x0b] PRIV11
    $0c constant GTZC1_MPCBB3_PRIV12            \ [0x0c] PRIV12
    $0d constant GTZC1_MPCBB3_PRIV13            \ [0x0d] PRIV13
    $0e constant GTZC1_MPCBB3_PRIV14            \ [0x0e] PRIV14
    $0f constant GTZC1_MPCBB3_PRIV15            \ [0x0f] PRIV15
    $10 constant GTZC1_MPCBB3_PRIV16            \ [0x10] PRIV16
    $11 constant GTZC1_MPCBB3_PRIV17            \ [0x11] PRIV17
    $12 constant GTZC1_MPCBB3_PRIV18            \ [0x12] PRIV18
    $13 constant GTZC1_MPCBB3_PRIV19            \ [0x13] PRIV19
    $14 constant GTZC1_MPCBB3_PRIV20            \ [0x14] PRIV20
    $15 constant GTZC1_MPCBB3_PRIV21            \ [0x15] PRIV21
    $16 constant GTZC1_MPCBB3_PRIV22            \ [0x16] PRIV22
    $17 constant GTZC1_MPCBB3_PRIV23            \ [0x17] PRIV23
    $18 constant GTZC1_MPCBB3_PRIV24            \ [0x18] PRIV24
    $19 constant GTZC1_MPCBB3_PRIV25            \ [0x19] PRIV25
    $1a constant GTZC1_MPCBB3_PRIV26            \ [0x1a] PRIV26
    $1b constant GTZC1_MPCBB3_PRIV27            \ [0x1b] PRIV27
    $1c constant GTZC1_MPCBB3_PRIV28            \ [0x1c] PRIV28
    $1d constant GTZC1_MPCBB3_PRIV29            \ [0x1d] PRIV29
    $1e constant GTZC1_MPCBB3_PRIV30            \ [0x1e] PRIV30
    $1f constant GTZC1_MPCBB3_PRIV31            \ [0x1f] PRIV31
  [then]


  [ifdef] GTZC1_MPCBB3_MPCBB3_PRIVCFGR17_DEF
    \
    \ @brief MPCBB privileged configuration for super-block x register
    \ Address offset: 0x244
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GTZC1_MPCBB3_PRIV0             \ [0x00] PRIV0
    $01 constant GTZC1_MPCBB3_PRIV1             \ [0x01] PRIV1
    $02 constant GTZC1_MPCBB3_PRIV2             \ [0x02] PRIV2
    $03 constant GTZC1_MPCBB3_PRIV3             \ [0x03] PRIV3
    $04 constant GTZC1_MPCBB3_PRIV4             \ [0x04] PRIV4
    $05 constant GTZC1_MPCBB3_PRIV5             \ [0x05] PRIV5
    $06 constant GTZC1_MPCBB3_PRIV6             \ [0x06] PRIV6
    $07 constant GTZC1_MPCBB3_PRIV7             \ [0x07] PRIV7
    $08 constant GTZC1_MPCBB3_PRIV8             \ [0x08] PRIV8
    $09 constant GTZC1_MPCBB3_PRIV9             \ [0x09] PRIV9
    $0a constant GTZC1_MPCBB3_PRIV10            \ [0x0a] PRIV10
    $0b constant GTZC1_MPCBB3_PRIV11            \ [0x0b] PRIV11
    $0c constant GTZC1_MPCBB3_PRIV12            \ [0x0c] PRIV12
    $0d constant GTZC1_MPCBB3_PRIV13            \ [0x0d] PRIV13
    $0e constant GTZC1_MPCBB3_PRIV14            \ [0x0e] PRIV14
    $0f constant GTZC1_MPCBB3_PRIV15            \ [0x0f] PRIV15
    $10 constant GTZC1_MPCBB3_PRIV16            \ [0x10] PRIV16
    $11 constant GTZC1_MPCBB3_PRIV17            \ [0x11] PRIV17
    $12 constant GTZC1_MPCBB3_PRIV18            \ [0x12] PRIV18
    $13 constant GTZC1_MPCBB3_PRIV19            \ [0x13] PRIV19
    $14 constant GTZC1_MPCBB3_PRIV20            \ [0x14] PRIV20
    $15 constant GTZC1_MPCBB3_PRIV21            \ [0x15] PRIV21
    $16 constant GTZC1_MPCBB3_PRIV22            \ [0x16] PRIV22
    $17 constant GTZC1_MPCBB3_PRIV23            \ [0x17] PRIV23
    $18 constant GTZC1_MPCBB3_PRIV24            \ [0x18] PRIV24
    $19 constant GTZC1_MPCBB3_PRIV25            \ [0x19] PRIV25
    $1a constant GTZC1_MPCBB3_PRIV26            \ [0x1a] PRIV26
    $1b constant GTZC1_MPCBB3_PRIV27            \ [0x1b] PRIV27
    $1c constant GTZC1_MPCBB3_PRIV28            \ [0x1c] PRIV28
    $1d constant GTZC1_MPCBB3_PRIV29            \ [0x1d] PRIV29
    $1e constant GTZC1_MPCBB3_PRIV30            \ [0x1e] PRIV30
    $1f constant GTZC1_MPCBB3_PRIV31            \ [0x1f] PRIV31
  [then]


  [ifdef] GTZC1_MPCBB3_MPCBB3_PRIVCFGR18_DEF
    \
    \ @brief MPCBB privileged configuration for super-block x register
    \ Address offset: 0x248
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GTZC1_MPCBB3_PRIV0             \ [0x00] PRIV0
    $01 constant GTZC1_MPCBB3_PRIV1             \ [0x01] PRIV1
    $02 constant GTZC1_MPCBB3_PRIV2             \ [0x02] PRIV2
    $03 constant GTZC1_MPCBB3_PRIV3             \ [0x03] PRIV3
    $04 constant GTZC1_MPCBB3_PRIV4             \ [0x04] PRIV4
    $05 constant GTZC1_MPCBB3_PRIV5             \ [0x05] PRIV5
    $06 constant GTZC1_MPCBB3_PRIV6             \ [0x06] PRIV6
    $07 constant GTZC1_MPCBB3_PRIV7             \ [0x07] PRIV7
    $08 constant GTZC1_MPCBB3_PRIV8             \ [0x08] PRIV8
    $09 constant GTZC1_MPCBB3_PRIV9             \ [0x09] PRIV9
    $0a constant GTZC1_MPCBB3_PRIV10            \ [0x0a] PRIV10
    $0b constant GTZC1_MPCBB3_PRIV11            \ [0x0b] PRIV11
    $0c constant GTZC1_MPCBB3_PRIV12            \ [0x0c] PRIV12
    $0d constant GTZC1_MPCBB3_PRIV13            \ [0x0d] PRIV13
    $0e constant GTZC1_MPCBB3_PRIV14            \ [0x0e] PRIV14
    $0f constant GTZC1_MPCBB3_PRIV15            \ [0x0f] PRIV15
    $10 constant GTZC1_MPCBB3_PRIV16            \ [0x10] PRIV16
    $11 constant GTZC1_MPCBB3_PRIV17            \ [0x11] PRIV17
    $12 constant GTZC1_MPCBB3_PRIV18            \ [0x12] PRIV18
    $13 constant GTZC1_MPCBB3_PRIV19            \ [0x13] PRIV19
    $14 constant GTZC1_MPCBB3_PRIV20            \ [0x14] PRIV20
    $15 constant GTZC1_MPCBB3_PRIV21            \ [0x15] PRIV21
    $16 constant GTZC1_MPCBB3_PRIV22            \ [0x16] PRIV22
    $17 constant GTZC1_MPCBB3_PRIV23            \ [0x17] PRIV23
    $18 constant GTZC1_MPCBB3_PRIV24            \ [0x18] PRIV24
    $19 constant GTZC1_MPCBB3_PRIV25            \ [0x19] PRIV25
    $1a constant GTZC1_MPCBB3_PRIV26            \ [0x1a] PRIV26
    $1b constant GTZC1_MPCBB3_PRIV27            \ [0x1b] PRIV27
    $1c constant GTZC1_MPCBB3_PRIV28            \ [0x1c] PRIV28
    $1d constant GTZC1_MPCBB3_PRIV29            \ [0x1d] PRIV29
    $1e constant GTZC1_MPCBB3_PRIV30            \ [0x1e] PRIV30
    $1f constant GTZC1_MPCBB3_PRIV31            \ [0x1f] PRIV31
  [then]


  [ifdef] GTZC1_MPCBB3_MPCBB3_PRIVCFGR19_DEF
    \
    \ @brief MPCBB privileged configuration for super-block x register
    \ Address offset: 0x24C
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GTZC1_MPCBB3_PRIV0             \ [0x00] PRIV0
    $01 constant GTZC1_MPCBB3_PRIV1             \ [0x01] PRIV1
    $02 constant GTZC1_MPCBB3_PRIV2             \ [0x02] PRIV2
    $03 constant GTZC1_MPCBB3_PRIV3             \ [0x03] PRIV3
    $04 constant GTZC1_MPCBB3_PRIV4             \ [0x04] PRIV4
    $05 constant GTZC1_MPCBB3_PRIV5             \ [0x05] PRIV5
    $06 constant GTZC1_MPCBB3_PRIV6             \ [0x06] PRIV6
    $07 constant GTZC1_MPCBB3_PRIV7             \ [0x07] PRIV7
    $08 constant GTZC1_MPCBB3_PRIV8             \ [0x08] PRIV8
    $09 constant GTZC1_MPCBB3_PRIV9             \ [0x09] PRIV9
    $0a constant GTZC1_MPCBB3_PRIV10            \ [0x0a] PRIV10
    $0b constant GTZC1_MPCBB3_PRIV11            \ [0x0b] PRIV11
    $0c constant GTZC1_MPCBB3_PRIV12            \ [0x0c] PRIV12
    $0d constant GTZC1_MPCBB3_PRIV13            \ [0x0d] PRIV13
    $0e constant GTZC1_MPCBB3_PRIV14            \ [0x0e] PRIV14
    $0f constant GTZC1_MPCBB3_PRIV15            \ [0x0f] PRIV15
    $10 constant GTZC1_MPCBB3_PRIV16            \ [0x10] PRIV16
    $11 constant GTZC1_MPCBB3_PRIV17            \ [0x11] PRIV17
    $12 constant GTZC1_MPCBB3_PRIV18            \ [0x12] PRIV18
    $13 constant GTZC1_MPCBB3_PRIV19            \ [0x13] PRIV19
    $14 constant GTZC1_MPCBB3_PRIV20            \ [0x14] PRIV20
    $15 constant GTZC1_MPCBB3_PRIV21            \ [0x15] PRIV21
    $16 constant GTZC1_MPCBB3_PRIV22            \ [0x16] PRIV22
    $17 constant GTZC1_MPCBB3_PRIV23            \ [0x17] PRIV23
    $18 constant GTZC1_MPCBB3_PRIV24            \ [0x18] PRIV24
    $19 constant GTZC1_MPCBB3_PRIV25            \ [0x19] PRIV25
    $1a constant GTZC1_MPCBB3_PRIV26            \ [0x1a] PRIV26
    $1b constant GTZC1_MPCBB3_PRIV27            \ [0x1b] PRIV27
    $1c constant GTZC1_MPCBB3_PRIV28            \ [0x1c] PRIV28
    $1d constant GTZC1_MPCBB3_PRIV29            \ [0x1d] PRIV29
    $1e constant GTZC1_MPCBB3_PRIV30            \ [0x1e] PRIV30
    $1f constant GTZC1_MPCBB3_PRIV31            \ [0x1f] PRIV31
  [then]


  [ifdef] GTZC1_MPCBB3_MPCBB3_PRIVCFGR20_DEF
    \
    \ @brief MPCBB privileged configuration for super-block x register
    \ Address offset: 0x250
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GTZC1_MPCBB3_PRIV0             \ [0x00] PRIV0
    $01 constant GTZC1_MPCBB3_PRIV1             \ [0x01] PRIV1
    $02 constant GTZC1_MPCBB3_PRIV2             \ [0x02] PRIV2
    $03 constant GTZC1_MPCBB3_PRIV3             \ [0x03] PRIV3
    $04 constant GTZC1_MPCBB3_PRIV4             \ [0x04] PRIV4
    $05 constant GTZC1_MPCBB3_PRIV5             \ [0x05] PRIV5
    $06 constant GTZC1_MPCBB3_PRIV6             \ [0x06] PRIV6
    $07 constant GTZC1_MPCBB3_PRIV7             \ [0x07] PRIV7
    $08 constant GTZC1_MPCBB3_PRIV8             \ [0x08] PRIV8
    $09 constant GTZC1_MPCBB3_PRIV9             \ [0x09] PRIV9
    $0a constant GTZC1_MPCBB3_PRIV10            \ [0x0a] PRIV10
    $0b constant GTZC1_MPCBB3_PRIV11            \ [0x0b] PRIV11
    $0c constant GTZC1_MPCBB3_PRIV12            \ [0x0c] PRIV12
    $0d constant GTZC1_MPCBB3_PRIV13            \ [0x0d] PRIV13
    $0e constant GTZC1_MPCBB3_PRIV14            \ [0x0e] PRIV14
    $0f constant GTZC1_MPCBB3_PRIV15            \ [0x0f] PRIV15
    $10 constant GTZC1_MPCBB3_PRIV16            \ [0x10] PRIV16
    $11 constant GTZC1_MPCBB3_PRIV17            \ [0x11] PRIV17
    $12 constant GTZC1_MPCBB3_PRIV18            \ [0x12] PRIV18
    $13 constant GTZC1_MPCBB3_PRIV19            \ [0x13] PRIV19
    $14 constant GTZC1_MPCBB3_PRIV20            \ [0x14] PRIV20
    $15 constant GTZC1_MPCBB3_PRIV21            \ [0x15] PRIV21
    $16 constant GTZC1_MPCBB3_PRIV22            \ [0x16] PRIV22
    $17 constant GTZC1_MPCBB3_PRIV23            \ [0x17] PRIV23
    $18 constant GTZC1_MPCBB3_PRIV24            \ [0x18] PRIV24
    $19 constant GTZC1_MPCBB3_PRIV25            \ [0x19] PRIV25
    $1a constant GTZC1_MPCBB3_PRIV26            \ [0x1a] PRIV26
    $1b constant GTZC1_MPCBB3_PRIV27            \ [0x1b] PRIV27
    $1c constant GTZC1_MPCBB3_PRIV28            \ [0x1c] PRIV28
    $1d constant GTZC1_MPCBB3_PRIV29            \ [0x1d] PRIV29
    $1e constant GTZC1_MPCBB3_PRIV30            \ [0x1e] PRIV30
    $1f constant GTZC1_MPCBB3_PRIV31            \ [0x1f] PRIV31
  [then]


  [ifdef] GTZC1_MPCBB3_MPCBB3_PRIVCFGR21_DEF
    \
    \ @brief MPCBB privileged configuration for super-block x register
    \ Address offset: 0x254
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GTZC1_MPCBB3_PRIV0             \ [0x00] PRIV0
    $01 constant GTZC1_MPCBB3_PRIV1             \ [0x01] PRIV1
    $02 constant GTZC1_MPCBB3_PRIV2             \ [0x02] PRIV2
    $03 constant GTZC1_MPCBB3_PRIV3             \ [0x03] PRIV3
    $04 constant GTZC1_MPCBB3_PRIV4             \ [0x04] PRIV4
    $05 constant GTZC1_MPCBB3_PRIV5             \ [0x05] PRIV5
    $06 constant GTZC1_MPCBB3_PRIV6             \ [0x06] PRIV6
    $07 constant GTZC1_MPCBB3_PRIV7             \ [0x07] PRIV7
    $08 constant GTZC1_MPCBB3_PRIV8             \ [0x08] PRIV8
    $09 constant GTZC1_MPCBB3_PRIV9             \ [0x09] PRIV9
    $0a constant GTZC1_MPCBB3_PRIV10            \ [0x0a] PRIV10
    $0b constant GTZC1_MPCBB3_PRIV11            \ [0x0b] PRIV11
    $0c constant GTZC1_MPCBB3_PRIV12            \ [0x0c] PRIV12
    $0d constant GTZC1_MPCBB3_PRIV13            \ [0x0d] PRIV13
    $0e constant GTZC1_MPCBB3_PRIV14            \ [0x0e] PRIV14
    $0f constant GTZC1_MPCBB3_PRIV15            \ [0x0f] PRIV15
    $10 constant GTZC1_MPCBB3_PRIV16            \ [0x10] PRIV16
    $11 constant GTZC1_MPCBB3_PRIV17            \ [0x11] PRIV17
    $12 constant GTZC1_MPCBB3_PRIV18            \ [0x12] PRIV18
    $13 constant GTZC1_MPCBB3_PRIV19            \ [0x13] PRIV19
    $14 constant GTZC1_MPCBB3_PRIV20            \ [0x14] PRIV20
    $15 constant GTZC1_MPCBB3_PRIV21            \ [0x15] PRIV21
    $16 constant GTZC1_MPCBB3_PRIV22            \ [0x16] PRIV22
    $17 constant GTZC1_MPCBB3_PRIV23            \ [0x17] PRIV23
    $18 constant GTZC1_MPCBB3_PRIV24            \ [0x18] PRIV24
    $19 constant GTZC1_MPCBB3_PRIV25            \ [0x19] PRIV25
    $1a constant GTZC1_MPCBB3_PRIV26            \ [0x1a] PRIV26
    $1b constant GTZC1_MPCBB3_PRIV27            \ [0x1b] PRIV27
    $1c constant GTZC1_MPCBB3_PRIV28            \ [0x1c] PRIV28
    $1d constant GTZC1_MPCBB3_PRIV29            \ [0x1d] PRIV29
    $1e constant GTZC1_MPCBB3_PRIV30            \ [0x1e] PRIV30
    $1f constant GTZC1_MPCBB3_PRIV31            \ [0x1f] PRIV31
  [then]


  [ifdef] GTZC1_MPCBB3_MPCBB3_PRIVCFGR22_DEF
    \
    \ @brief MPCBB privileged configuration for super-block x register
    \ Address offset: 0x258
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GTZC1_MPCBB3_PRIV0             \ [0x00] PRIV0
    $01 constant GTZC1_MPCBB3_PRIV1             \ [0x01] PRIV1
    $02 constant GTZC1_MPCBB3_PRIV2             \ [0x02] PRIV2
    $03 constant GTZC1_MPCBB3_PRIV3             \ [0x03] PRIV3
    $04 constant GTZC1_MPCBB3_PRIV4             \ [0x04] PRIV4
    $05 constant GTZC1_MPCBB3_PRIV5             \ [0x05] PRIV5
    $06 constant GTZC1_MPCBB3_PRIV6             \ [0x06] PRIV6
    $07 constant GTZC1_MPCBB3_PRIV7             \ [0x07] PRIV7
    $08 constant GTZC1_MPCBB3_PRIV8             \ [0x08] PRIV8
    $09 constant GTZC1_MPCBB3_PRIV9             \ [0x09] PRIV9
    $0a constant GTZC1_MPCBB3_PRIV10            \ [0x0a] PRIV10
    $0b constant GTZC1_MPCBB3_PRIV11            \ [0x0b] PRIV11
    $0c constant GTZC1_MPCBB3_PRIV12            \ [0x0c] PRIV12
    $0d constant GTZC1_MPCBB3_PRIV13            \ [0x0d] PRIV13
    $0e constant GTZC1_MPCBB3_PRIV14            \ [0x0e] PRIV14
    $0f constant GTZC1_MPCBB3_PRIV15            \ [0x0f] PRIV15
    $10 constant GTZC1_MPCBB3_PRIV16            \ [0x10] PRIV16
    $11 constant GTZC1_MPCBB3_PRIV17            \ [0x11] PRIV17
    $12 constant GTZC1_MPCBB3_PRIV18            \ [0x12] PRIV18
    $13 constant GTZC1_MPCBB3_PRIV19            \ [0x13] PRIV19
    $14 constant GTZC1_MPCBB3_PRIV20            \ [0x14] PRIV20
    $15 constant GTZC1_MPCBB3_PRIV21            \ [0x15] PRIV21
    $16 constant GTZC1_MPCBB3_PRIV22            \ [0x16] PRIV22
    $17 constant GTZC1_MPCBB3_PRIV23            \ [0x17] PRIV23
    $18 constant GTZC1_MPCBB3_PRIV24            \ [0x18] PRIV24
    $19 constant GTZC1_MPCBB3_PRIV25            \ [0x19] PRIV25
    $1a constant GTZC1_MPCBB3_PRIV26            \ [0x1a] PRIV26
    $1b constant GTZC1_MPCBB3_PRIV27            \ [0x1b] PRIV27
    $1c constant GTZC1_MPCBB3_PRIV28            \ [0x1c] PRIV28
    $1d constant GTZC1_MPCBB3_PRIV29            \ [0x1d] PRIV29
    $1e constant GTZC1_MPCBB3_PRIV30            \ [0x1e] PRIV30
    $1f constant GTZC1_MPCBB3_PRIV31            \ [0x1f] PRIV31
  [then]


  [ifdef] GTZC1_MPCBB3_MPCBB3_PRIVCFGR23_DEF
    \
    \ @brief MPCBB privileged configuration for super-block x register
    \ Address offset: 0x25C
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GTZC1_MPCBB3_PRIV0             \ [0x00] PRIV0
    $01 constant GTZC1_MPCBB3_PRIV1             \ [0x01] PRIV1
    $02 constant GTZC1_MPCBB3_PRIV2             \ [0x02] PRIV2
    $03 constant GTZC1_MPCBB3_PRIV3             \ [0x03] PRIV3
    $04 constant GTZC1_MPCBB3_PRIV4             \ [0x04] PRIV4
    $05 constant GTZC1_MPCBB3_PRIV5             \ [0x05] PRIV5
    $06 constant GTZC1_MPCBB3_PRIV6             \ [0x06] PRIV6
    $07 constant GTZC1_MPCBB3_PRIV7             \ [0x07] PRIV7
    $08 constant GTZC1_MPCBB3_PRIV8             \ [0x08] PRIV8
    $09 constant GTZC1_MPCBB3_PRIV9             \ [0x09] PRIV9
    $0a constant GTZC1_MPCBB3_PRIV10            \ [0x0a] PRIV10
    $0b constant GTZC1_MPCBB3_PRIV11            \ [0x0b] PRIV11
    $0c constant GTZC1_MPCBB3_PRIV12            \ [0x0c] PRIV12
    $0d constant GTZC1_MPCBB3_PRIV13            \ [0x0d] PRIV13
    $0e constant GTZC1_MPCBB3_PRIV14            \ [0x0e] PRIV14
    $0f constant GTZC1_MPCBB3_PRIV15            \ [0x0f] PRIV15
    $10 constant GTZC1_MPCBB3_PRIV16            \ [0x10] PRIV16
    $11 constant GTZC1_MPCBB3_PRIV17            \ [0x11] PRIV17
    $12 constant GTZC1_MPCBB3_PRIV18            \ [0x12] PRIV18
    $13 constant GTZC1_MPCBB3_PRIV19            \ [0x13] PRIV19
    $14 constant GTZC1_MPCBB3_PRIV20            \ [0x14] PRIV20
    $15 constant GTZC1_MPCBB3_PRIV21            \ [0x15] PRIV21
    $16 constant GTZC1_MPCBB3_PRIV22            \ [0x16] PRIV22
    $17 constant GTZC1_MPCBB3_PRIV23            \ [0x17] PRIV23
    $18 constant GTZC1_MPCBB3_PRIV24            \ [0x18] PRIV24
    $19 constant GTZC1_MPCBB3_PRIV25            \ [0x19] PRIV25
    $1a constant GTZC1_MPCBB3_PRIV26            \ [0x1a] PRIV26
    $1b constant GTZC1_MPCBB3_PRIV27            \ [0x1b] PRIV27
    $1c constant GTZC1_MPCBB3_PRIV28            \ [0x1c] PRIV28
    $1d constant GTZC1_MPCBB3_PRIV29            \ [0x1d] PRIV29
    $1e constant GTZC1_MPCBB3_PRIV30            \ [0x1e] PRIV30
    $1f constant GTZC1_MPCBB3_PRIV31            \ [0x1f] PRIV31
  [then]


  [ifdef] GTZC1_MPCBB3_MPCBB3_PRIVCFGR24_DEF
    \
    \ @brief MPCBB privileged configuration for super-block x register
    \ Address offset: 0x260
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GTZC1_MPCBB3_PRIV0             \ [0x00] PRIV0
    $01 constant GTZC1_MPCBB3_PRIV1             \ [0x01] PRIV1
    $02 constant GTZC1_MPCBB3_PRIV2             \ [0x02] PRIV2
    $03 constant GTZC1_MPCBB3_PRIV3             \ [0x03] PRIV3
    $04 constant GTZC1_MPCBB3_PRIV4             \ [0x04] PRIV4
    $05 constant GTZC1_MPCBB3_PRIV5             \ [0x05] PRIV5
    $06 constant GTZC1_MPCBB3_PRIV6             \ [0x06] PRIV6
    $07 constant GTZC1_MPCBB3_PRIV7             \ [0x07] PRIV7
    $08 constant GTZC1_MPCBB3_PRIV8             \ [0x08] PRIV8
    $09 constant GTZC1_MPCBB3_PRIV9             \ [0x09] PRIV9
    $0a constant GTZC1_MPCBB3_PRIV10            \ [0x0a] PRIV10
    $0b constant GTZC1_MPCBB3_PRIV11            \ [0x0b] PRIV11
    $0c constant GTZC1_MPCBB3_PRIV12            \ [0x0c] PRIV12
    $0d constant GTZC1_MPCBB3_PRIV13            \ [0x0d] PRIV13
    $0e constant GTZC1_MPCBB3_PRIV14            \ [0x0e] PRIV14
    $0f constant GTZC1_MPCBB3_PRIV15            \ [0x0f] PRIV15
    $10 constant GTZC1_MPCBB3_PRIV16            \ [0x10] PRIV16
    $11 constant GTZC1_MPCBB3_PRIV17            \ [0x11] PRIV17
    $12 constant GTZC1_MPCBB3_PRIV18            \ [0x12] PRIV18
    $13 constant GTZC1_MPCBB3_PRIV19            \ [0x13] PRIV19
    $14 constant GTZC1_MPCBB3_PRIV20            \ [0x14] PRIV20
    $15 constant GTZC1_MPCBB3_PRIV21            \ [0x15] PRIV21
    $16 constant GTZC1_MPCBB3_PRIV22            \ [0x16] PRIV22
    $17 constant GTZC1_MPCBB3_PRIV23            \ [0x17] PRIV23
    $18 constant GTZC1_MPCBB3_PRIV24            \ [0x18] PRIV24
    $19 constant GTZC1_MPCBB3_PRIV25            \ [0x19] PRIV25
    $1a constant GTZC1_MPCBB3_PRIV26            \ [0x1a] PRIV26
    $1b constant GTZC1_MPCBB3_PRIV27            \ [0x1b] PRIV27
    $1c constant GTZC1_MPCBB3_PRIV28            \ [0x1c] PRIV28
    $1d constant GTZC1_MPCBB3_PRIV29            \ [0x1d] PRIV29
    $1e constant GTZC1_MPCBB3_PRIV30            \ [0x1e] PRIV30
    $1f constant GTZC1_MPCBB3_PRIV31            \ [0x1f] PRIV31
  [then]


  [ifdef] GTZC1_MPCBB3_MPCBB3_PRIVCFGR25_DEF
    \
    \ @brief MPCBB privileged configuration for super-block x register
    \ Address offset: 0x264
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GTZC1_MPCBB3_PRIV0             \ [0x00] PRIV0
    $01 constant GTZC1_MPCBB3_PRIV1             \ [0x01] PRIV1
    $02 constant GTZC1_MPCBB3_PRIV2             \ [0x02] PRIV2
    $03 constant GTZC1_MPCBB3_PRIV3             \ [0x03] PRIV3
    $04 constant GTZC1_MPCBB3_PRIV4             \ [0x04] PRIV4
    $05 constant GTZC1_MPCBB3_PRIV5             \ [0x05] PRIV5
    $06 constant GTZC1_MPCBB3_PRIV6             \ [0x06] PRIV6
    $07 constant GTZC1_MPCBB3_PRIV7             \ [0x07] PRIV7
    $08 constant GTZC1_MPCBB3_PRIV8             \ [0x08] PRIV8
    $09 constant GTZC1_MPCBB3_PRIV9             \ [0x09] PRIV9
    $0a constant GTZC1_MPCBB3_PRIV10            \ [0x0a] PRIV10
    $0b constant GTZC1_MPCBB3_PRIV11            \ [0x0b] PRIV11
    $0c constant GTZC1_MPCBB3_PRIV12            \ [0x0c] PRIV12
    $0d constant GTZC1_MPCBB3_PRIV13            \ [0x0d] PRIV13
    $0e constant GTZC1_MPCBB3_PRIV14            \ [0x0e] PRIV14
    $0f constant GTZC1_MPCBB3_PRIV15            \ [0x0f] PRIV15
    $10 constant GTZC1_MPCBB3_PRIV16            \ [0x10] PRIV16
    $11 constant GTZC1_MPCBB3_PRIV17            \ [0x11] PRIV17
    $12 constant GTZC1_MPCBB3_PRIV18            \ [0x12] PRIV18
    $13 constant GTZC1_MPCBB3_PRIV19            \ [0x13] PRIV19
    $14 constant GTZC1_MPCBB3_PRIV20            \ [0x14] PRIV20
    $15 constant GTZC1_MPCBB3_PRIV21            \ [0x15] PRIV21
    $16 constant GTZC1_MPCBB3_PRIV22            \ [0x16] PRIV22
    $17 constant GTZC1_MPCBB3_PRIV23            \ [0x17] PRIV23
    $18 constant GTZC1_MPCBB3_PRIV24            \ [0x18] PRIV24
    $19 constant GTZC1_MPCBB3_PRIV25            \ [0x19] PRIV25
    $1a constant GTZC1_MPCBB3_PRIV26            \ [0x1a] PRIV26
    $1b constant GTZC1_MPCBB3_PRIV27            \ [0x1b] PRIV27
    $1c constant GTZC1_MPCBB3_PRIV28            \ [0x1c] PRIV28
    $1d constant GTZC1_MPCBB3_PRIV29            \ [0x1d] PRIV29
    $1e constant GTZC1_MPCBB3_PRIV30            \ [0x1e] PRIV30
    $1f constant GTZC1_MPCBB3_PRIV31            \ [0x1f] PRIV31
  [then]


  [ifdef] GTZC1_MPCBB3_MPCBB3_PRIVCFGR26_DEF
    \
    \ @brief MPCBB privileged configuration for super-block x register
    \ Address offset: 0x268
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GTZC1_MPCBB3_PRIV0             \ [0x00] PRIV0
    $01 constant GTZC1_MPCBB3_PRIV1             \ [0x01] PRIV1
    $02 constant GTZC1_MPCBB3_PRIV2             \ [0x02] PRIV2
    $03 constant GTZC1_MPCBB3_PRIV3             \ [0x03] PRIV3
    $04 constant GTZC1_MPCBB3_PRIV4             \ [0x04] PRIV4
    $05 constant GTZC1_MPCBB3_PRIV5             \ [0x05] PRIV5
    $06 constant GTZC1_MPCBB3_PRIV6             \ [0x06] PRIV6
    $07 constant GTZC1_MPCBB3_PRIV7             \ [0x07] PRIV7
    $08 constant GTZC1_MPCBB3_PRIV8             \ [0x08] PRIV8
    $09 constant GTZC1_MPCBB3_PRIV9             \ [0x09] PRIV9
    $0a constant GTZC1_MPCBB3_PRIV10            \ [0x0a] PRIV10
    $0b constant GTZC1_MPCBB3_PRIV11            \ [0x0b] PRIV11
    $0c constant GTZC1_MPCBB3_PRIV12            \ [0x0c] PRIV12
    $0d constant GTZC1_MPCBB3_PRIV13            \ [0x0d] PRIV13
    $0e constant GTZC1_MPCBB3_PRIV14            \ [0x0e] PRIV14
    $0f constant GTZC1_MPCBB3_PRIV15            \ [0x0f] PRIV15
    $10 constant GTZC1_MPCBB3_PRIV16            \ [0x10] PRIV16
    $11 constant GTZC1_MPCBB3_PRIV17            \ [0x11] PRIV17
    $12 constant GTZC1_MPCBB3_PRIV18            \ [0x12] PRIV18
    $13 constant GTZC1_MPCBB3_PRIV19            \ [0x13] PRIV19
    $14 constant GTZC1_MPCBB3_PRIV20            \ [0x14] PRIV20
    $15 constant GTZC1_MPCBB3_PRIV21            \ [0x15] PRIV21
    $16 constant GTZC1_MPCBB3_PRIV22            \ [0x16] PRIV22
    $17 constant GTZC1_MPCBB3_PRIV23            \ [0x17] PRIV23
    $18 constant GTZC1_MPCBB3_PRIV24            \ [0x18] PRIV24
    $19 constant GTZC1_MPCBB3_PRIV25            \ [0x19] PRIV25
    $1a constant GTZC1_MPCBB3_PRIV26            \ [0x1a] PRIV26
    $1b constant GTZC1_MPCBB3_PRIV27            \ [0x1b] PRIV27
    $1c constant GTZC1_MPCBB3_PRIV28            \ [0x1c] PRIV28
    $1d constant GTZC1_MPCBB3_PRIV29            \ [0x1d] PRIV29
    $1e constant GTZC1_MPCBB3_PRIV30            \ [0x1e] PRIV30
    $1f constant GTZC1_MPCBB3_PRIV31            \ [0x1f] PRIV31
  [then]


  [ifdef] GTZC1_MPCBB3_MPCBB3_PRIVCFGR27_DEF
    \
    \ @brief MPCBB privileged configuration for super-block x register
    \ Address offset: 0x26C
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GTZC1_MPCBB3_PRIV0             \ [0x00] PRIV0
    $01 constant GTZC1_MPCBB3_PRIV1             \ [0x01] PRIV1
    $02 constant GTZC1_MPCBB3_PRIV2             \ [0x02] PRIV2
    $03 constant GTZC1_MPCBB3_PRIV3             \ [0x03] PRIV3
    $04 constant GTZC1_MPCBB3_PRIV4             \ [0x04] PRIV4
    $05 constant GTZC1_MPCBB3_PRIV5             \ [0x05] PRIV5
    $06 constant GTZC1_MPCBB3_PRIV6             \ [0x06] PRIV6
    $07 constant GTZC1_MPCBB3_PRIV7             \ [0x07] PRIV7
    $08 constant GTZC1_MPCBB3_PRIV8             \ [0x08] PRIV8
    $09 constant GTZC1_MPCBB3_PRIV9             \ [0x09] PRIV9
    $0a constant GTZC1_MPCBB3_PRIV10            \ [0x0a] PRIV10
    $0b constant GTZC1_MPCBB3_PRIV11            \ [0x0b] PRIV11
    $0c constant GTZC1_MPCBB3_PRIV12            \ [0x0c] PRIV12
    $0d constant GTZC1_MPCBB3_PRIV13            \ [0x0d] PRIV13
    $0e constant GTZC1_MPCBB3_PRIV14            \ [0x0e] PRIV14
    $0f constant GTZC1_MPCBB3_PRIV15            \ [0x0f] PRIV15
    $10 constant GTZC1_MPCBB3_PRIV16            \ [0x10] PRIV16
    $11 constant GTZC1_MPCBB3_PRIV17            \ [0x11] PRIV17
    $12 constant GTZC1_MPCBB3_PRIV18            \ [0x12] PRIV18
    $13 constant GTZC1_MPCBB3_PRIV19            \ [0x13] PRIV19
    $14 constant GTZC1_MPCBB3_PRIV20            \ [0x14] PRIV20
    $15 constant GTZC1_MPCBB3_PRIV21            \ [0x15] PRIV21
    $16 constant GTZC1_MPCBB3_PRIV22            \ [0x16] PRIV22
    $17 constant GTZC1_MPCBB3_PRIV23            \ [0x17] PRIV23
    $18 constant GTZC1_MPCBB3_PRIV24            \ [0x18] PRIV24
    $19 constant GTZC1_MPCBB3_PRIV25            \ [0x19] PRIV25
    $1a constant GTZC1_MPCBB3_PRIV26            \ [0x1a] PRIV26
    $1b constant GTZC1_MPCBB3_PRIV27            \ [0x1b] PRIV27
    $1c constant GTZC1_MPCBB3_PRIV28            \ [0x1c] PRIV28
    $1d constant GTZC1_MPCBB3_PRIV29            \ [0x1d] PRIV29
    $1e constant GTZC1_MPCBB3_PRIV30            \ [0x1e] PRIV30
    $1f constant GTZC1_MPCBB3_PRIV31            \ [0x1f] PRIV31
  [then]


  [ifdef] GTZC1_MPCBB3_MPCBB3_PRIVCFGR28_DEF
    \
    \ @brief MPCBB privileged configuration for super-block x register
    \ Address offset: 0x270
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GTZC1_MPCBB3_PRIV0             \ [0x00] PRIV0
    $01 constant GTZC1_MPCBB3_PRIV1             \ [0x01] PRIV1
    $02 constant GTZC1_MPCBB3_PRIV2             \ [0x02] PRIV2
    $03 constant GTZC1_MPCBB3_PRIV3             \ [0x03] PRIV3
    $04 constant GTZC1_MPCBB3_PRIV4             \ [0x04] PRIV4
    $05 constant GTZC1_MPCBB3_PRIV5             \ [0x05] PRIV5
    $06 constant GTZC1_MPCBB3_PRIV6             \ [0x06] PRIV6
    $07 constant GTZC1_MPCBB3_PRIV7             \ [0x07] PRIV7
    $08 constant GTZC1_MPCBB3_PRIV8             \ [0x08] PRIV8
    $09 constant GTZC1_MPCBB3_PRIV9             \ [0x09] PRIV9
    $0a constant GTZC1_MPCBB3_PRIV10            \ [0x0a] PRIV10
    $0b constant GTZC1_MPCBB3_PRIV11            \ [0x0b] PRIV11
    $0c constant GTZC1_MPCBB3_PRIV12            \ [0x0c] PRIV12
    $0d constant GTZC1_MPCBB3_PRIV13            \ [0x0d] PRIV13
    $0e constant GTZC1_MPCBB3_PRIV14            \ [0x0e] PRIV14
    $0f constant GTZC1_MPCBB3_PRIV15            \ [0x0f] PRIV15
    $10 constant GTZC1_MPCBB3_PRIV16            \ [0x10] PRIV16
    $11 constant GTZC1_MPCBB3_PRIV17            \ [0x11] PRIV17
    $12 constant GTZC1_MPCBB3_PRIV18            \ [0x12] PRIV18
    $13 constant GTZC1_MPCBB3_PRIV19            \ [0x13] PRIV19
    $14 constant GTZC1_MPCBB3_PRIV20            \ [0x14] PRIV20
    $15 constant GTZC1_MPCBB3_PRIV21            \ [0x15] PRIV21
    $16 constant GTZC1_MPCBB3_PRIV22            \ [0x16] PRIV22
    $17 constant GTZC1_MPCBB3_PRIV23            \ [0x17] PRIV23
    $18 constant GTZC1_MPCBB3_PRIV24            \ [0x18] PRIV24
    $19 constant GTZC1_MPCBB3_PRIV25            \ [0x19] PRIV25
    $1a constant GTZC1_MPCBB3_PRIV26            \ [0x1a] PRIV26
    $1b constant GTZC1_MPCBB3_PRIV27            \ [0x1b] PRIV27
    $1c constant GTZC1_MPCBB3_PRIV28            \ [0x1c] PRIV28
    $1d constant GTZC1_MPCBB3_PRIV29            \ [0x1d] PRIV29
    $1e constant GTZC1_MPCBB3_PRIV30            \ [0x1e] PRIV30
    $1f constant GTZC1_MPCBB3_PRIV31            \ [0x1f] PRIV31
  [then]


  [ifdef] GTZC1_MPCBB3_MPCBB3_PRIVCFGR29_DEF
    \
    \ @brief MPCBB privileged configuration for super-block x register
    \ Address offset: 0x274
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GTZC1_MPCBB3_PRIV0             \ [0x00] PRIV0
    $01 constant GTZC1_MPCBB3_PRIV1             \ [0x01] PRIV1
    $02 constant GTZC1_MPCBB3_PRIV2             \ [0x02] PRIV2
    $03 constant GTZC1_MPCBB3_PRIV3             \ [0x03] PRIV3
    $04 constant GTZC1_MPCBB3_PRIV4             \ [0x04] PRIV4
    $05 constant GTZC1_MPCBB3_PRIV5             \ [0x05] PRIV5
    $06 constant GTZC1_MPCBB3_PRIV6             \ [0x06] PRIV6
    $07 constant GTZC1_MPCBB3_PRIV7             \ [0x07] PRIV7
    $08 constant GTZC1_MPCBB3_PRIV8             \ [0x08] PRIV8
    $09 constant GTZC1_MPCBB3_PRIV9             \ [0x09] PRIV9
    $0a constant GTZC1_MPCBB3_PRIV10            \ [0x0a] PRIV10
    $0b constant GTZC1_MPCBB3_PRIV11            \ [0x0b] PRIV11
    $0c constant GTZC1_MPCBB3_PRIV12            \ [0x0c] PRIV12
    $0d constant GTZC1_MPCBB3_PRIV13            \ [0x0d] PRIV13
    $0e constant GTZC1_MPCBB3_PRIV14            \ [0x0e] PRIV14
    $0f constant GTZC1_MPCBB3_PRIV15            \ [0x0f] PRIV15
    $10 constant GTZC1_MPCBB3_PRIV16            \ [0x10] PRIV16
    $11 constant GTZC1_MPCBB3_PRIV17            \ [0x11] PRIV17
    $12 constant GTZC1_MPCBB3_PRIV18            \ [0x12] PRIV18
    $13 constant GTZC1_MPCBB3_PRIV19            \ [0x13] PRIV19
    $14 constant GTZC1_MPCBB3_PRIV20            \ [0x14] PRIV20
    $15 constant GTZC1_MPCBB3_PRIV21            \ [0x15] PRIV21
    $16 constant GTZC1_MPCBB3_PRIV22            \ [0x16] PRIV22
    $17 constant GTZC1_MPCBB3_PRIV23            \ [0x17] PRIV23
    $18 constant GTZC1_MPCBB3_PRIV24            \ [0x18] PRIV24
    $19 constant GTZC1_MPCBB3_PRIV25            \ [0x19] PRIV25
    $1a constant GTZC1_MPCBB3_PRIV26            \ [0x1a] PRIV26
    $1b constant GTZC1_MPCBB3_PRIV27            \ [0x1b] PRIV27
    $1c constant GTZC1_MPCBB3_PRIV28            \ [0x1c] PRIV28
    $1d constant GTZC1_MPCBB3_PRIV29            \ [0x1d] PRIV29
    $1e constant GTZC1_MPCBB3_PRIV30            \ [0x1e] PRIV30
    $1f constant GTZC1_MPCBB3_PRIV31            \ [0x1f] PRIV31
  [then]


  [ifdef] GTZC1_MPCBB3_MPCBB3_PRIVCFGR30_DEF
    \
    \ @brief MPCBB privileged configuration for super-block x register
    \ Address offset: 0x278
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GTZC1_MPCBB3_PRIV0             \ [0x00] PRIV0
    $01 constant GTZC1_MPCBB3_PRIV1             \ [0x01] PRIV1
    $02 constant GTZC1_MPCBB3_PRIV2             \ [0x02] PRIV2
    $03 constant GTZC1_MPCBB3_PRIV3             \ [0x03] PRIV3
    $04 constant GTZC1_MPCBB3_PRIV4             \ [0x04] PRIV4
    $05 constant GTZC1_MPCBB3_PRIV5             \ [0x05] PRIV5
    $06 constant GTZC1_MPCBB3_PRIV6             \ [0x06] PRIV6
    $07 constant GTZC1_MPCBB3_PRIV7             \ [0x07] PRIV7
    $08 constant GTZC1_MPCBB3_PRIV8             \ [0x08] PRIV8
    $09 constant GTZC1_MPCBB3_PRIV9             \ [0x09] PRIV9
    $0a constant GTZC1_MPCBB3_PRIV10            \ [0x0a] PRIV10
    $0b constant GTZC1_MPCBB3_PRIV11            \ [0x0b] PRIV11
    $0c constant GTZC1_MPCBB3_PRIV12            \ [0x0c] PRIV12
    $0d constant GTZC1_MPCBB3_PRIV13            \ [0x0d] PRIV13
    $0e constant GTZC1_MPCBB3_PRIV14            \ [0x0e] PRIV14
    $0f constant GTZC1_MPCBB3_PRIV15            \ [0x0f] PRIV15
    $10 constant GTZC1_MPCBB3_PRIV16            \ [0x10] PRIV16
    $11 constant GTZC1_MPCBB3_PRIV17            \ [0x11] PRIV17
    $12 constant GTZC1_MPCBB3_PRIV18            \ [0x12] PRIV18
    $13 constant GTZC1_MPCBB3_PRIV19            \ [0x13] PRIV19
    $14 constant GTZC1_MPCBB3_PRIV20            \ [0x14] PRIV20
    $15 constant GTZC1_MPCBB3_PRIV21            \ [0x15] PRIV21
    $16 constant GTZC1_MPCBB3_PRIV22            \ [0x16] PRIV22
    $17 constant GTZC1_MPCBB3_PRIV23            \ [0x17] PRIV23
    $18 constant GTZC1_MPCBB3_PRIV24            \ [0x18] PRIV24
    $19 constant GTZC1_MPCBB3_PRIV25            \ [0x19] PRIV25
    $1a constant GTZC1_MPCBB3_PRIV26            \ [0x1a] PRIV26
    $1b constant GTZC1_MPCBB3_PRIV27            \ [0x1b] PRIV27
    $1c constant GTZC1_MPCBB3_PRIV28            \ [0x1c] PRIV28
    $1d constant GTZC1_MPCBB3_PRIV29            \ [0x1d] PRIV29
    $1e constant GTZC1_MPCBB3_PRIV30            \ [0x1e] PRIV30
    $1f constant GTZC1_MPCBB3_PRIV31            \ [0x1f] PRIV31
  [then]


  [ifdef] GTZC1_MPCBB3_MPCBB3_PRIVCFGR31_DEF
    \
    \ @brief MPCBB privileged configuration for super-block x register
    \ Address offset: 0x27C
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GTZC1_MPCBB3_PRIV0             \ [0x00] PRIV0
    $01 constant GTZC1_MPCBB3_PRIV1             \ [0x01] PRIV1
    $02 constant GTZC1_MPCBB3_PRIV2             \ [0x02] PRIV2
    $03 constant GTZC1_MPCBB3_PRIV3             \ [0x03] PRIV3
    $04 constant GTZC1_MPCBB3_PRIV4             \ [0x04] PRIV4
    $05 constant GTZC1_MPCBB3_PRIV5             \ [0x05] PRIV5
    $06 constant GTZC1_MPCBB3_PRIV6             \ [0x06] PRIV6
    $07 constant GTZC1_MPCBB3_PRIV7             \ [0x07] PRIV7
    $08 constant GTZC1_MPCBB3_PRIV8             \ [0x08] PRIV8
    $09 constant GTZC1_MPCBB3_PRIV9             \ [0x09] PRIV9
    $0a constant GTZC1_MPCBB3_PRIV10            \ [0x0a] PRIV10
    $0b constant GTZC1_MPCBB3_PRIV11            \ [0x0b] PRIV11
    $0c constant GTZC1_MPCBB3_PRIV12            \ [0x0c] PRIV12
    $0d constant GTZC1_MPCBB3_PRIV13            \ [0x0d] PRIV13
    $0e constant GTZC1_MPCBB3_PRIV14            \ [0x0e] PRIV14
    $0f constant GTZC1_MPCBB3_PRIV15            \ [0x0f] PRIV15
    $10 constant GTZC1_MPCBB3_PRIV16            \ [0x10] PRIV16
    $11 constant GTZC1_MPCBB3_PRIV17            \ [0x11] PRIV17
    $12 constant GTZC1_MPCBB3_PRIV18            \ [0x12] PRIV18
    $13 constant GTZC1_MPCBB3_PRIV19            \ [0x13] PRIV19
    $14 constant GTZC1_MPCBB3_PRIV20            \ [0x14] PRIV20
    $15 constant GTZC1_MPCBB3_PRIV21            \ [0x15] PRIV21
    $16 constant GTZC1_MPCBB3_PRIV22            \ [0x16] PRIV22
    $17 constant GTZC1_MPCBB3_PRIV23            \ [0x17] PRIV23
    $18 constant GTZC1_MPCBB3_PRIV24            \ [0x18] PRIV24
    $19 constant GTZC1_MPCBB3_PRIV25            \ [0x19] PRIV25
    $1a constant GTZC1_MPCBB3_PRIV26            \ [0x1a] PRIV26
    $1b constant GTZC1_MPCBB3_PRIV27            \ [0x1b] PRIV27
    $1c constant GTZC1_MPCBB3_PRIV28            \ [0x1c] PRIV28
    $1d constant GTZC1_MPCBB3_PRIV29            \ [0x1d] PRIV29
    $1e constant GTZC1_MPCBB3_PRIV30            \ [0x1e] PRIV30
    $1f constant GTZC1_MPCBB3_PRIV31            \ [0x1f] PRIV31
  [then]


  [ifdef] GTZC1_MPCBB3_MPCBB3_PRIVCFGR32_DEF
    \
    \ @brief MPCBB privileged configuration for super-block x register
    \ Address offset: 0x280
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GTZC1_MPCBB3_PRIV0             \ [0x00] PRIV0
    $01 constant GTZC1_MPCBB3_PRIV1             \ [0x01] PRIV1
    $02 constant GTZC1_MPCBB3_PRIV2             \ [0x02] PRIV2
    $03 constant GTZC1_MPCBB3_PRIV3             \ [0x03] PRIV3
    $04 constant GTZC1_MPCBB3_PRIV4             \ [0x04] PRIV4
    $05 constant GTZC1_MPCBB3_PRIV5             \ [0x05] PRIV5
    $06 constant GTZC1_MPCBB3_PRIV6             \ [0x06] PRIV6
    $07 constant GTZC1_MPCBB3_PRIV7             \ [0x07] PRIV7
    $08 constant GTZC1_MPCBB3_PRIV8             \ [0x08] PRIV8
    $09 constant GTZC1_MPCBB3_PRIV9             \ [0x09] PRIV9
    $0a constant GTZC1_MPCBB3_PRIV10            \ [0x0a] PRIV10
    $0b constant GTZC1_MPCBB3_PRIV11            \ [0x0b] PRIV11
    $0c constant GTZC1_MPCBB3_PRIV12            \ [0x0c] PRIV12
    $0d constant GTZC1_MPCBB3_PRIV13            \ [0x0d] PRIV13
    $0e constant GTZC1_MPCBB3_PRIV14            \ [0x0e] PRIV14
    $0f constant GTZC1_MPCBB3_PRIV15            \ [0x0f] PRIV15
    $10 constant GTZC1_MPCBB3_PRIV16            \ [0x10] PRIV16
    $11 constant GTZC1_MPCBB3_PRIV17            \ [0x11] PRIV17
    $12 constant GTZC1_MPCBB3_PRIV18            \ [0x12] PRIV18
    $13 constant GTZC1_MPCBB3_PRIV19            \ [0x13] PRIV19
    $14 constant GTZC1_MPCBB3_PRIV20            \ [0x14] PRIV20
    $15 constant GTZC1_MPCBB3_PRIV21            \ [0x15] PRIV21
    $16 constant GTZC1_MPCBB3_PRIV22            \ [0x16] PRIV22
    $17 constant GTZC1_MPCBB3_PRIV23            \ [0x17] PRIV23
    $18 constant GTZC1_MPCBB3_PRIV24            \ [0x18] PRIV24
    $19 constant GTZC1_MPCBB3_PRIV25            \ [0x19] PRIV25
    $1a constant GTZC1_MPCBB3_PRIV26            \ [0x1a] PRIV26
    $1b constant GTZC1_MPCBB3_PRIV27            \ [0x1b] PRIV27
    $1c constant GTZC1_MPCBB3_PRIV28            \ [0x1c] PRIV28
    $1d constant GTZC1_MPCBB3_PRIV29            \ [0x1d] PRIV29
    $1e constant GTZC1_MPCBB3_PRIV30            \ [0x1e] PRIV30
    $1f constant GTZC1_MPCBB3_PRIV31            \ [0x1f] PRIV31
  [then]


  [ifdef] GTZC1_MPCBB3_MPCBB3_PRIVCFGR33_DEF
    \
    \ @brief MPCBB privileged configuration for super-block x register
    \ Address offset: 0x284
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GTZC1_MPCBB3_PRIV0             \ [0x00] PRIV0
    $01 constant GTZC1_MPCBB3_PRIV1             \ [0x01] PRIV1
    $02 constant GTZC1_MPCBB3_PRIV2             \ [0x02] PRIV2
    $03 constant GTZC1_MPCBB3_PRIV3             \ [0x03] PRIV3
    $04 constant GTZC1_MPCBB3_PRIV4             \ [0x04] PRIV4
    $05 constant GTZC1_MPCBB3_PRIV5             \ [0x05] PRIV5
    $06 constant GTZC1_MPCBB3_PRIV6             \ [0x06] PRIV6
    $07 constant GTZC1_MPCBB3_PRIV7             \ [0x07] PRIV7
    $08 constant GTZC1_MPCBB3_PRIV8             \ [0x08] PRIV8
    $09 constant GTZC1_MPCBB3_PRIV9             \ [0x09] PRIV9
    $0a constant GTZC1_MPCBB3_PRIV10            \ [0x0a] PRIV10
    $0b constant GTZC1_MPCBB3_PRIV11            \ [0x0b] PRIV11
    $0c constant GTZC1_MPCBB3_PRIV12            \ [0x0c] PRIV12
    $0d constant GTZC1_MPCBB3_PRIV13            \ [0x0d] PRIV13
    $0e constant GTZC1_MPCBB3_PRIV14            \ [0x0e] PRIV14
    $0f constant GTZC1_MPCBB3_PRIV15            \ [0x0f] PRIV15
    $10 constant GTZC1_MPCBB3_PRIV16            \ [0x10] PRIV16
    $11 constant GTZC1_MPCBB3_PRIV17            \ [0x11] PRIV17
    $12 constant GTZC1_MPCBB3_PRIV18            \ [0x12] PRIV18
    $13 constant GTZC1_MPCBB3_PRIV19            \ [0x13] PRIV19
    $14 constant GTZC1_MPCBB3_PRIV20            \ [0x14] PRIV20
    $15 constant GTZC1_MPCBB3_PRIV21            \ [0x15] PRIV21
    $16 constant GTZC1_MPCBB3_PRIV22            \ [0x16] PRIV22
    $17 constant GTZC1_MPCBB3_PRIV23            \ [0x17] PRIV23
    $18 constant GTZC1_MPCBB3_PRIV24            \ [0x18] PRIV24
    $19 constant GTZC1_MPCBB3_PRIV25            \ [0x19] PRIV25
    $1a constant GTZC1_MPCBB3_PRIV26            \ [0x1a] PRIV26
    $1b constant GTZC1_MPCBB3_PRIV27            \ [0x1b] PRIV27
    $1c constant GTZC1_MPCBB3_PRIV28            \ [0x1c] PRIV28
    $1d constant GTZC1_MPCBB3_PRIV29            \ [0x1d] PRIV29
    $1e constant GTZC1_MPCBB3_PRIV30            \ [0x1e] PRIV30
    $1f constant GTZC1_MPCBB3_PRIV31            \ [0x1f] PRIV31
  [then]


  [ifdef] GTZC1_MPCBB3_MPCBB3_PRIVCFGR34_DEF
    \
    \ @brief MPCBB privileged configuration for super-block x register
    \ Address offset: 0x288
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GTZC1_MPCBB3_PRIV0             \ [0x00] PRIV0
    $01 constant GTZC1_MPCBB3_PRIV1             \ [0x01] PRIV1
    $02 constant GTZC1_MPCBB3_PRIV2             \ [0x02] PRIV2
    $03 constant GTZC1_MPCBB3_PRIV3             \ [0x03] PRIV3
    $04 constant GTZC1_MPCBB3_PRIV4             \ [0x04] PRIV4
    $05 constant GTZC1_MPCBB3_PRIV5             \ [0x05] PRIV5
    $06 constant GTZC1_MPCBB3_PRIV6             \ [0x06] PRIV6
    $07 constant GTZC1_MPCBB3_PRIV7             \ [0x07] PRIV7
    $08 constant GTZC1_MPCBB3_PRIV8             \ [0x08] PRIV8
    $09 constant GTZC1_MPCBB3_PRIV9             \ [0x09] PRIV9
    $0a constant GTZC1_MPCBB3_PRIV10            \ [0x0a] PRIV10
    $0b constant GTZC1_MPCBB3_PRIV11            \ [0x0b] PRIV11
    $0c constant GTZC1_MPCBB3_PRIV12            \ [0x0c] PRIV12
    $0d constant GTZC1_MPCBB3_PRIV13            \ [0x0d] PRIV13
    $0e constant GTZC1_MPCBB3_PRIV14            \ [0x0e] PRIV14
    $0f constant GTZC1_MPCBB3_PRIV15            \ [0x0f] PRIV15
    $10 constant GTZC1_MPCBB3_PRIV16            \ [0x10] PRIV16
    $11 constant GTZC1_MPCBB3_PRIV17            \ [0x11] PRIV17
    $12 constant GTZC1_MPCBB3_PRIV18            \ [0x12] PRIV18
    $13 constant GTZC1_MPCBB3_PRIV19            \ [0x13] PRIV19
    $14 constant GTZC1_MPCBB3_PRIV20            \ [0x14] PRIV20
    $15 constant GTZC1_MPCBB3_PRIV21            \ [0x15] PRIV21
    $16 constant GTZC1_MPCBB3_PRIV22            \ [0x16] PRIV22
    $17 constant GTZC1_MPCBB3_PRIV23            \ [0x17] PRIV23
    $18 constant GTZC1_MPCBB3_PRIV24            \ [0x18] PRIV24
    $19 constant GTZC1_MPCBB3_PRIV25            \ [0x19] PRIV25
    $1a constant GTZC1_MPCBB3_PRIV26            \ [0x1a] PRIV26
    $1b constant GTZC1_MPCBB3_PRIV27            \ [0x1b] PRIV27
    $1c constant GTZC1_MPCBB3_PRIV28            \ [0x1c] PRIV28
    $1d constant GTZC1_MPCBB3_PRIV29            \ [0x1d] PRIV29
    $1e constant GTZC1_MPCBB3_PRIV30            \ [0x1e] PRIV30
    $1f constant GTZC1_MPCBB3_PRIV31            \ [0x1f] PRIV31
  [then]


  [ifdef] GTZC1_MPCBB3_MPCBB3_PRIVCFGR35_DEF
    \
    \ @brief MPCBB privileged configuration for super-block x register
    \ Address offset: 0x28C
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GTZC1_MPCBB3_PRIV0             \ [0x00] PRIV0
    $01 constant GTZC1_MPCBB3_PRIV1             \ [0x01] PRIV1
    $02 constant GTZC1_MPCBB3_PRIV2             \ [0x02] PRIV2
    $03 constant GTZC1_MPCBB3_PRIV3             \ [0x03] PRIV3
    $04 constant GTZC1_MPCBB3_PRIV4             \ [0x04] PRIV4
    $05 constant GTZC1_MPCBB3_PRIV5             \ [0x05] PRIV5
    $06 constant GTZC1_MPCBB3_PRIV6             \ [0x06] PRIV6
    $07 constant GTZC1_MPCBB3_PRIV7             \ [0x07] PRIV7
    $08 constant GTZC1_MPCBB3_PRIV8             \ [0x08] PRIV8
    $09 constant GTZC1_MPCBB3_PRIV9             \ [0x09] PRIV9
    $0a constant GTZC1_MPCBB3_PRIV10            \ [0x0a] PRIV10
    $0b constant GTZC1_MPCBB3_PRIV11            \ [0x0b] PRIV11
    $0c constant GTZC1_MPCBB3_PRIV12            \ [0x0c] PRIV12
    $0d constant GTZC1_MPCBB3_PRIV13            \ [0x0d] PRIV13
    $0e constant GTZC1_MPCBB3_PRIV14            \ [0x0e] PRIV14
    $0f constant GTZC1_MPCBB3_PRIV15            \ [0x0f] PRIV15
    $10 constant GTZC1_MPCBB3_PRIV16            \ [0x10] PRIV16
    $11 constant GTZC1_MPCBB3_PRIV17            \ [0x11] PRIV17
    $12 constant GTZC1_MPCBB3_PRIV18            \ [0x12] PRIV18
    $13 constant GTZC1_MPCBB3_PRIV19            \ [0x13] PRIV19
    $14 constant GTZC1_MPCBB3_PRIV20            \ [0x14] PRIV20
    $15 constant GTZC1_MPCBB3_PRIV21            \ [0x15] PRIV21
    $16 constant GTZC1_MPCBB3_PRIV22            \ [0x16] PRIV22
    $17 constant GTZC1_MPCBB3_PRIV23            \ [0x17] PRIV23
    $18 constant GTZC1_MPCBB3_PRIV24            \ [0x18] PRIV24
    $19 constant GTZC1_MPCBB3_PRIV25            \ [0x19] PRIV25
    $1a constant GTZC1_MPCBB3_PRIV26            \ [0x1a] PRIV26
    $1b constant GTZC1_MPCBB3_PRIV27            \ [0x1b] PRIV27
    $1c constant GTZC1_MPCBB3_PRIV28            \ [0x1c] PRIV28
    $1d constant GTZC1_MPCBB3_PRIV29            \ [0x1d] PRIV29
    $1e constant GTZC1_MPCBB3_PRIV30            \ [0x1e] PRIV30
    $1f constant GTZC1_MPCBB3_PRIV31            \ [0x1f] PRIV31
  [then]


  [ifdef] GTZC1_MPCBB3_MPCBB3_PRIVCFGR36_DEF
    \
    \ @brief MPCBB privileged configuration for super-block x register
    \ Address offset: 0x290
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GTZC1_MPCBB3_PRIV0             \ [0x00] PRIV0
    $01 constant GTZC1_MPCBB3_PRIV1             \ [0x01] PRIV1
    $02 constant GTZC1_MPCBB3_PRIV2             \ [0x02] PRIV2
    $03 constant GTZC1_MPCBB3_PRIV3             \ [0x03] PRIV3
    $04 constant GTZC1_MPCBB3_PRIV4             \ [0x04] PRIV4
    $05 constant GTZC1_MPCBB3_PRIV5             \ [0x05] PRIV5
    $06 constant GTZC1_MPCBB3_PRIV6             \ [0x06] PRIV6
    $07 constant GTZC1_MPCBB3_PRIV7             \ [0x07] PRIV7
    $08 constant GTZC1_MPCBB3_PRIV8             \ [0x08] PRIV8
    $09 constant GTZC1_MPCBB3_PRIV9             \ [0x09] PRIV9
    $0a constant GTZC1_MPCBB3_PRIV10            \ [0x0a] PRIV10
    $0b constant GTZC1_MPCBB3_PRIV11            \ [0x0b] PRIV11
    $0c constant GTZC1_MPCBB3_PRIV12            \ [0x0c] PRIV12
    $0d constant GTZC1_MPCBB3_PRIV13            \ [0x0d] PRIV13
    $0e constant GTZC1_MPCBB3_PRIV14            \ [0x0e] PRIV14
    $0f constant GTZC1_MPCBB3_PRIV15            \ [0x0f] PRIV15
    $10 constant GTZC1_MPCBB3_PRIV16            \ [0x10] PRIV16
    $11 constant GTZC1_MPCBB3_PRIV17            \ [0x11] PRIV17
    $12 constant GTZC1_MPCBB3_PRIV18            \ [0x12] PRIV18
    $13 constant GTZC1_MPCBB3_PRIV19            \ [0x13] PRIV19
    $14 constant GTZC1_MPCBB3_PRIV20            \ [0x14] PRIV20
    $15 constant GTZC1_MPCBB3_PRIV21            \ [0x15] PRIV21
    $16 constant GTZC1_MPCBB3_PRIV22            \ [0x16] PRIV22
    $17 constant GTZC1_MPCBB3_PRIV23            \ [0x17] PRIV23
    $18 constant GTZC1_MPCBB3_PRIV24            \ [0x18] PRIV24
    $19 constant GTZC1_MPCBB3_PRIV25            \ [0x19] PRIV25
    $1a constant GTZC1_MPCBB3_PRIV26            \ [0x1a] PRIV26
    $1b constant GTZC1_MPCBB3_PRIV27            \ [0x1b] PRIV27
    $1c constant GTZC1_MPCBB3_PRIV28            \ [0x1c] PRIV28
    $1d constant GTZC1_MPCBB3_PRIV29            \ [0x1d] PRIV29
    $1e constant GTZC1_MPCBB3_PRIV30            \ [0x1e] PRIV30
    $1f constant GTZC1_MPCBB3_PRIV31            \ [0x1f] PRIV31
  [then]


  [ifdef] GTZC1_MPCBB3_MPCBB3_PRIVCFGR37_DEF
    \
    \ @brief MPCBB privileged configuration for super-block x register
    \ Address offset: 0x294
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GTZC1_MPCBB3_PRIV0             \ [0x00] PRIV0
    $01 constant GTZC1_MPCBB3_PRIV1             \ [0x01] PRIV1
    $02 constant GTZC1_MPCBB3_PRIV2             \ [0x02] PRIV2
    $03 constant GTZC1_MPCBB3_PRIV3             \ [0x03] PRIV3
    $04 constant GTZC1_MPCBB3_PRIV4             \ [0x04] PRIV4
    $05 constant GTZC1_MPCBB3_PRIV5             \ [0x05] PRIV5
    $06 constant GTZC1_MPCBB3_PRIV6             \ [0x06] PRIV6
    $07 constant GTZC1_MPCBB3_PRIV7             \ [0x07] PRIV7
    $08 constant GTZC1_MPCBB3_PRIV8             \ [0x08] PRIV8
    $09 constant GTZC1_MPCBB3_PRIV9             \ [0x09] PRIV9
    $0a constant GTZC1_MPCBB3_PRIV10            \ [0x0a] PRIV10
    $0b constant GTZC1_MPCBB3_PRIV11            \ [0x0b] PRIV11
    $0c constant GTZC1_MPCBB3_PRIV12            \ [0x0c] PRIV12
    $0d constant GTZC1_MPCBB3_PRIV13            \ [0x0d] PRIV13
    $0e constant GTZC1_MPCBB3_PRIV14            \ [0x0e] PRIV14
    $0f constant GTZC1_MPCBB3_PRIV15            \ [0x0f] PRIV15
    $10 constant GTZC1_MPCBB3_PRIV16            \ [0x10] PRIV16
    $11 constant GTZC1_MPCBB3_PRIV17            \ [0x11] PRIV17
    $12 constant GTZC1_MPCBB3_PRIV18            \ [0x12] PRIV18
    $13 constant GTZC1_MPCBB3_PRIV19            \ [0x13] PRIV19
    $14 constant GTZC1_MPCBB3_PRIV20            \ [0x14] PRIV20
    $15 constant GTZC1_MPCBB3_PRIV21            \ [0x15] PRIV21
    $16 constant GTZC1_MPCBB3_PRIV22            \ [0x16] PRIV22
    $17 constant GTZC1_MPCBB3_PRIV23            \ [0x17] PRIV23
    $18 constant GTZC1_MPCBB3_PRIV24            \ [0x18] PRIV24
    $19 constant GTZC1_MPCBB3_PRIV25            \ [0x19] PRIV25
    $1a constant GTZC1_MPCBB3_PRIV26            \ [0x1a] PRIV26
    $1b constant GTZC1_MPCBB3_PRIV27            \ [0x1b] PRIV27
    $1c constant GTZC1_MPCBB3_PRIV28            \ [0x1c] PRIV28
    $1d constant GTZC1_MPCBB3_PRIV29            \ [0x1d] PRIV29
    $1e constant GTZC1_MPCBB3_PRIV30            \ [0x1e] PRIV30
    $1f constant GTZC1_MPCBB3_PRIV31            \ [0x1f] PRIV31
  [then]


  [ifdef] GTZC1_MPCBB3_MPCBB3_PRIVCFGR38_DEF
    \
    \ @brief MPCBB privileged configuration for super-block x register
    \ Address offset: 0x298
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GTZC1_MPCBB3_PRIV0             \ [0x00] PRIV0
    $01 constant GTZC1_MPCBB3_PRIV1             \ [0x01] PRIV1
    $02 constant GTZC1_MPCBB3_PRIV2             \ [0x02] PRIV2
    $03 constant GTZC1_MPCBB3_PRIV3             \ [0x03] PRIV3
    $04 constant GTZC1_MPCBB3_PRIV4             \ [0x04] PRIV4
    $05 constant GTZC1_MPCBB3_PRIV5             \ [0x05] PRIV5
    $06 constant GTZC1_MPCBB3_PRIV6             \ [0x06] PRIV6
    $07 constant GTZC1_MPCBB3_PRIV7             \ [0x07] PRIV7
    $08 constant GTZC1_MPCBB3_PRIV8             \ [0x08] PRIV8
    $09 constant GTZC1_MPCBB3_PRIV9             \ [0x09] PRIV9
    $0a constant GTZC1_MPCBB3_PRIV10            \ [0x0a] PRIV10
    $0b constant GTZC1_MPCBB3_PRIV11            \ [0x0b] PRIV11
    $0c constant GTZC1_MPCBB3_PRIV12            \ [0x0c] PRIV12
    $0d constant GTZC1_MPCBB3_PRIV13            \ [0x0d] PRIV13
    $0e constant GTZC1_MPCBB3_PRIV14            \ [0x0e] PRIV14
    $0f constant GTZC1_MPCBB3_PRIV15            \ [0x0f] PRIV15
    $10 constant GTZC1_MPCBB3_PRIV16            \ [0x10] PRIV16
    $11 constant GTZC1_MPCBB3_PRIV17            \ [0x11] PRIV17
    $12 constant GTZC1_MPCBB3_PRIV18            \ [0x12] PRIV18
    $13 constant GTZC1_MPCBB3_PRIV19            \ [0x13] PRIV19
    $14 constant GTZC1_MPCBB3_PRIV20            \ [0x14] PRIV20
    $15 constant GTZC1_MPCBB3_PRIV21            \ [0x15] PRIV21
    $16 constant GTZC1_MPCBB3_PRIV22            \ [0x16] PRIV22
    $17 constant GTZC1_MPCBB3_PRIV23            \ [0x17] PRIV23
    $18 constant GTZC1_MPCBB3_PRIV24            \ [0x18] PRIV24
    $19 constant GTZC1_MPCBB3_PRIV25            \ [0x19] PRIV25
    $1a constant GTZC1_MPCBB3_PRIV26            \ [0x1a] PRIV26
    $1b constant GTZC1_MPCBB3_PRIV27            \ [0x1b] PRIV27
    $1c constant GTZC1_MPCBB3_PRIV28            \ [0x1c] PRIV28
    $1d constant GTZC1_MPCBB3_PRIV29            \ [0x1d] PRIV29
    $1e constant GTZC1_MPCBB3_PRIV30            \ [0x1e] PRIV30
    $1f constant GTZC1_MPCBB3_PRIV31            \ [0x1f] PRIV31
  [then]


  [ifdef] GTZC1_MPCBB3_MPCBB3_PRIVCFGR39_DEF
    \
    \ @brief MPCBB privileged configuration for super-block x register
    \ Address offset: 0x29C
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GTZC1_MPCBB3_PRIV0             \ [0x00] PRIV0
    $01 constant GTZC1_MPCBB3_PRIV1             \ [0x01] PRIV1
    $02 constant GTZC1_MPCBB3_PRIV2             \ [0x02] PRIV2
    $03 constant GTZC1_MPCBB3_PRIV3             \ [0x03] PRIV3
    $04 constant GTZC1_MPCBB3_PRIV4             \ [0x04] PRIV4
    $05 constant GTZC1_MPCBB3_PRIV5             \ [0x05] PRIV5
    $06 constant GTZC1_MPCBB3_PRIV6             \ [0x06] PRIV6
    $07 constant GTZC1_MPCBB3_PRIV7             \ [0x07] PRIV7
    $08 constant GTZC1_MPCBB3_PRIV8             \ [0x08] PRIV8
    $09 constant GTZC1_MPCBB3_PRIV9             \ [0x09] PRIV9
    $0a constant GTZC1_MPCBB3_PRIV10            \ [0x0a] PRIV10
    $0b constant GTZC1_MPCBB3_PRIV11            \ [0x0b] PRIV11
    $0c constant GTZC1_MPCBB3_PRIV12            \ [0x0c] PRIV12
    $0d constant GTZC1_MPCBB3_PRIV13            \ [0x0d] PRIV13
    $0e constant GTZC1_MPCBB3_PRIV14            \ [0x0e] PRIV14
    $0f constant GTZC1_MPCBB3_PRIV15            \ [0x0f] PRIV15
    $10 constant GTZC1_MPCBB3_PRIV16            \ [0x10] PRIV16
    $11 constant GTZC1_MPCBB3_PRIV17            \ [0x11] PRIV17
    $12 constant GTZC1_MPCBB3_PRIV18            \ [0x12] PRIV18
    $13 constant GTZC1_MPCBB3_PRIV19            \ [0x13] PRIV19
    $14 constant GTZC1_MPCBB3_PRIV20            \ [0x14] PRIV20
    $15 constant GTZC1_MPCBB3_PRIV21            \ [0x15] PRIV21
    $16 constant GTZC1_MPCBB3_PRIV22            \ [0x16] PRIV22
    $17 constant GTZC1_MPCBB3_PRIV23            \ [0x17] PRIV23
    $18 constant GTZC1_MPCBB3_PRIV24            \ [0x18] PRIV24
    $19 constant GTZC1_MPCBB3_PRIV25            \ [0x19] PRIV25
    $1a constant GTZC1_MPCBB3_PRIV26            \ [0x1a] PRIV26
    $1b constant GTZC1_MPCBB3_PRIV27            \ [0x1b] PRIV27
    $1c constant GTZC1_MPCBB3_PRIV28            \ [0x1c] PRIV28
    $1d constant GTZC1_MPCBB3_PRIV29            \ [0x1d] PRIV29
    $1e constant GTZC1_MPCBB3_PRIV30            \ [0x1e] PRIV30
    $1f constant GTZC1_MPCBB3_PRIV31            \ [0x1f] PRIV31
  [then]


  [ifdef] GTZC1_MPCBB3_MPCBB3_PRIVCFGR40_DEF
    \
    \ @brief MPCBB privileged configuration for super-block x register
    \ Address offset: 0x2A0
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GTZC1_MPCBB3_PRIV0             \ [0x00] PRIV0
    $01 constant GTZC1_MPCBB3_PRIV1             \ [0x01] PRIV1
    $02 constant GTZC1_MPCBB3_PRIV2             \ [0x02] PRIV2
    $03 constant GTZC1_MPCBB3_PRIV3             \ [0x03] PRIV3
    $04 constant GTZC1_MPCBB3_PRIV4             \ [0x04] PRIV4
    $05 constant GTZC1_MPCBB3_PRIV5             \ [0x05] PRIV5
    $06 constant GTZC1_MPCBB3_PRIV6             \ [0x06] PRIV6
    $07 constant GTZC1_MPCBB3_PRIV7             \ [0x07] PRIV7
    $08 constant GTZC1_MPCBB3_PRIV8             \ [0x08] PRIV8
    $09 constant GTZC1_MPCBB3_PRIV9             \ [0x09] PRIV9
    $0a constant GTZC1_MPCBB3_PRIV10            \ [0x0a] PRIV10
    $0b constant GTZC1_MPCBB3_PRIV11            \ [0x0b] PRIV11
    $0c constant GTZC1_MPCBB3_PRIV12            \ [0x0c] PRIV12
    $0d constant GTZC1_MPCBB3_PRIV13            \ [0x0d] PRIV13
    $0e constant GTZC1_MPCBB3_PRIV14            \ [0x0e] PRIV14
    $0f constant GTZC1_MPCBB3_PRIV15            \ [0x0f] PRIV15
    $10 constant GTZC1_MPCBB3_PRIV16            \ [0x10] PRIV16
    $11 constant GTZC1_MPCBB3_PRIV17            \ [0x11] PRIV17
    $12 constant GTZC1_MPCBB3_PRIV18            \ [0x12] PRIV18
    $13 constant GTZC1_MPCBB3_PRIV19            \ [0x13] PRIV19
    $14 constant GTZC1_MPCBB3_PRIV20            \ [0x14] PRIV20
    $15 constant GTZC1_MPCBB3_PRIV21            \ [0x15] PRIV21
    $16 constant GTZC1_MPCBB3_PRIV22            \ [0x16] PRIV22
    $17 constant GTZC1_MPCBB3_PRIV23            \ [0x17] PRIV23
    $18 constant GTZC1_MPCBB3_PRIV24            \ [0x18] PRIV24
    $19 constant GTZC1_MPCBB3_PRIV25            \ [0x19] PRIV25
    $1a constant GTZC1_MPCBB3_PRIV26            \ [0x1a] PRIV26
    $1b constant GTZC1_MPCBB3_PRIV27            \ [0x1b] PRIV27
    $1c constant GTZC1_MPCBB3_PRIV28            \ [0x1c] PRIV28
    $1d constant GTZC1_MPCBB3_PRIV29            \ [0x1d] PRIV29
    $1e constant GTZC1_MPCBB3_PRIV30            \ [0x1e] PRIV30
    $1f constant GTZC1_MPCBB3_PRIV31            \ [0x1f] PRIV31
  [then]


  [ifdef] GTZC1_MPCBB3_MPCBB3_PRIVCFGR41_DEF
    \
    \ @brief MPCBB privileged configuration for super-block x register
    \ Address offset: 0x2A4
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GTZC1_MPCBB3_PRIV0             \ [0x00] PRIV0
    $01 constant GTZC1_MPCBB3_PRIV1             \ [0x01] PRIV1
    $02 constant GTZC1_MPCBB3_PRIV2             \ [0x02] PRIV2
    $03 constant GTZC1_MPCBB3_PRIV3             \ [0x03] PRIV3
    $04 constant GTZC1_MPCBB3_PRIV4             \ [0x04] PRIV4
    $05 constant GTZC1_MPCBB3_PRIV5             \ [0x05] PRIV5
    $06 constant GTZC1_MPCBB3_PRIV6             \ [0x06] PRIV6
    $07 constant GTZC1_MPCBB3_PRIV7             \ [0x07] PRIV7
    $08 constant GTZC1_MPCBB3_PRIV8             \ [0x08] PRIV8
    $09 constant GTZC1_MPCBB3_PRIV9             \ [0x09] PRIV9
    $0a constant GTZC1_MPCBB3_PRIV10            \ [0x0a] PRIV10
    $0b constant GTZC1_MPCBB3_PRIV11            \ [0x0b] PRIV11
    $0c constant GTZC1_MPCBB3_PRIV12            \ [0x0c] PRIV12
    $0d constant GTZC1_MPCBB3_PRIV13            \ [0x0d] PRIV13
    $0e constant GTZC1_MPCBB3_PRIV14            \ [0x0e] PRIV14
    $0f constant GTZC1_MPCBB3_PRIV15            \ [0x0f] PRIV15
    $10 constant GTZC1_MPCBB3_PRIV16            \ [0x10] PRIV16
    $11 constant GTZC1_MPCBB3_PRIV17            \ [0x11] PRIV17
    $12 constant GTZC1_MPCBB3_PRIV18            \ [0x12] PRIV18
    $13 constant GTZC1_MPCBB3_PRIV19            \ [0x13] PRIV19
    $14 constant GTZC1_MPCBB3_PRIV20            \ [0x14] PRIV20
    $15 constant GTZC1_MPCBB3_PRIV21            \ [0x15] PRIV21
    $16 constant GTZC1_MPCBB3_PRIV22            \ [0x16] PRIV22
    $17 constant GTZC1_MPCBB3_PRIV23            \ [0x17] PRIV23
    $18 constant GTZC1_MPCBB3_PRIV24            \ [0x18] PRIV24
    $19 constant GTZC1_MPCBB3_PRIV25            \ [0x19] PRIV25
    $1a constant GTZC1_MPCBB3_PRIV26            \ [0x1a] PRIV26
    $1b constant GTZC1_MPCBB3_PRIV27            \ [0x1b] PRIV27
    $1c constant GTZC1_MPCBB3_PRIV28            \ [0x1c] PRIV28
    $1d constant GTZC1_MPCBB3_PRIV29            \ [0x1d] PRIV29
    $1e constant GTZC1_MPCBB3_PRIV30            \ [0x1e] PRIV30
    $1f constant GTZC1_MPCBB3_PRIV31            \ [0x1f] PRIV31
  [then]


  [ifdef] GTZC1_MPCBB3_MPCBB3_PRIVCFGR42_DEF
    \
    \ @brief MPCBB privileged configuration for super-block x register
    \ Address offset: 0x2A8
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GTZC1_MPCBB3_PRIV0             \ [0x00] PRIV0
    $01 constant GTZC1_MPCBB3_PRIV1             \ [0x01] PRIV1
    $02 constant GTZC1_MPCBB3_PRIV2             \ [0x02] PRIV2
    $03 constant GTZC1_MPCBB3_PRIV3             \ [0x03] PRIV3
    $04 constant GTZC1_MPCBB3_PRIV4             \ [0x04] PRIV4
    $05 constant GTZC1_MPCBB3_PRIV5             \ [0x05] PRIV5
    $06 constant GTZC1_MPCBB3_PRIV6             \ [0x06] PRIV6
    $07 constant GTZC1_MPCBB3_PRIV7             \ [0x07] PRIV7
    $08 constant GTZC1_MPCBB3_PRIV8             \ [0x08] PRIV8
    $09 constant GTZC1_MPCBB3_PRIV9             \ [0x09] PRIV9
    $0a constant GTZC1_MPCBB3_PRIV10            \ [0x0a] PRIV10
    $0b constant GTZC1_MPCBB3_PRIV11            \ [0x0b] PRIV11
    $0c constant GTZC1_MPCBB3_PRIV12            \ [0x0c] PRIV12
    $0d constant GTZC1_MPCBB3_PRIV13            \ [0x0d] PRIV13
    $0e constant GTZC1_MPCBB3_PRIV14            \ [0x0e] PRIV14
    $0f constant GTZC1_MPCBB3_PRIV15            \ [0x0f] PRIV15
    $10 constant GTZC1_MPCBB3_PRIV16            \ [0x10] PRIV16
    $11 constant GTZC1_MPCBB3_PRIV17            \ [0x11] PRIV17
    $12 constant GTZC1_MPCBB3_PRIV18            \ [0x12] PRIV18
    $13 constant GTZC1_MPCBB3_PRIV19            \ [0x13] PRIV19
    $14 constant GTZC1_MPCBB3_PRIV20            \ [0x14] PRIV20
    $15 constant GTZC1_MPCBB3_PRIV21            \ [0x15] PRIV21
    $16 constant GTZC1_MPCBB3_PRIV22            \ [0x16] PRIV22
    $17 constant GTZC1_MPCBB3_PRIV23            \ [0x17] PRIV23
    $18 constant GTZC1_MPCBB3_PRIV24            \ [0x18] PRIV24
    $19 constant GTZC1_MPCBB3_PRIV25            \ [0x19] PRIV25
    $1a constant GTZC1_MPCBB3_PRIV26            \ [0x1a] PRIV26
    $1b constant GTZC1_MPCBB3_PRIV27            \ [0x1b] PRIV27
    $1c constant GTZC1_MPCBB3_PRIV28            \ [0x1c] PRIV28
    $1d constant GTZC1_MPCBB3_PRIV29            \ [0x1d] PRIV29
    $1e constant GTZC1_MPCBB3_PRIV30            \ [0x1e] PRIV30
    $1f constant GTZC1_MPCBB3_PRIV31            \ [0x1f] PRIV31
  [then]


  [ifdef] GTZC1_MPCBB3_MPCBB3_PRIVCFGR43_DEF
    \
    \ @brief MPCBB privileged configuration for super-block x register
    \ Address offset: 0x2AC
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GTZC1_MPCBB3_PRIV0             \ [0x00] PRIV0
    $01 constant GTZC1_MPCBB3_PRIV1             \ [0x01] PRIV1
    $02 constant GTZC1_MPCBB3_PRIV2             \ [0x02] PRIV2
    $03 constant GTZC1_MPCBB3_PRIV3             \ [0x03] PRIV3
    $04 constant GTZC1_MPCBB3_PRIV4             \ [0x04] PRIV4
    $05 constant GTZC1_MPCBB3_PRIV5             \ [0x05] PRIV5
    $06 constant GTZC1_MPCBB3_PRIV6             \ [0x06] PRIV6
    $07 constant GTZC1_MPCBB3_PRIV7             \ [0x07] PRIV7
    $08 constant GTZC1_MPCBB3_PRIV8             \ [0x08] PRIV8
    $09 constant GTZC1_MPCBB3_PRIV9             \ [0x09] PRIV9
    $0a constant GTZC1_MPCBB3_PRIV10            \ [0x0a] PRIV10
    $0b constant GTZC1_MPCBB3_PRIV11            \ [0x0b] PRIV11
    $0c constant GTZC1_MPCBB3_PRIV12            \ [0x0c] PRIV12
    $0d constant GTZC1_MPCBB3_PRIV13            \ [0x0d] PRIV13
    $0e constant GTZC1_MPCBB3_PRIV14            \ [0x0e] PRIV14
    $0f constant GTZC1_MPCBB3_PRIV15            \ [0x0f] PRIV15
    $10 constant GTZC1_MPCBB3_PRIV16            \ [0x10] PRIV16
    $11 constant GTZC1_MPCBB3_PRIV17            \ [0x11] PRIV17
    $12 constant GTZC1_MPCBB3_PRIV18            \ [0x12] PRIV18
    $13 constant GTZC1_MPCBB3_PRIV19            \ [0x13] PRIV19
    $14 constant GTZC1_MPCBB3_PRIV20            \ [0x14] PRIV20
    $15 constant GTZC1_MPCBB3_PRIV21            \ [0x15] PRIV21
    $16 constant GTZC1_MPCBB3_PRIV22            \ [0x16] PRIV22
    $17 constant GTZC1_MPCBB3_PRIV23            \ [0x17] PRIV23
    $18 constant GTZC1_MPCBB3_PRIV24            \ [0x18] PRIV24
    $19 constant GTZC1_MPCBB3_PRIV25            \ [0x19] PRIV25
    $1a constant GTZC1_MPCBB3_PRIV26            \ [0x1a] PRIV26
    $1b constant GTZC1_MPCBB3_PRIV27            \ [0x1b] PRIV27
    $1c constant GTZC1_MPCBB3_PRIV28            \ [0x1c] PRIV28
    $1d constant GTZC1_MPCBB3_PRIV29            \ [0x1d] PRIV29
    $1e constant GTZC1_MPCBB3_PRIV30            \ [0x1e] PRIV30
    $1f constant GTZC1_MPCBB3_PRIV31            \ [0x1f] PRIV31
  [then]


  [ifdef] GTZC1_MPCBB3_MPCBB3_PRIVCFGR44_DEF
    \
    \ @brief MPCBB privileged configuration for super-block x register
    \ Address offset: 0x2B0
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GTZC1_MPCBB3_PRIV0             \ [0x00] PRIV0
    $01 constant GTZC1_MPCBB3_PRIV1             \ [0x01] PRIV1
    $02 constant GTZC1_MPCBB3_PRIV2             \ [0x02] PRIV2
    $03 constant GTZC1_MPCBB3_PRIV3             \ [0x03] PRIV3
    $04 constant GTZC1_MPCBB3_PRIV4             \ [0x04] PRIV4
    $05 constant GTZC1_MPCBB3_PRIV5             \ [0x05] PRIV5
    $06 constant GTZC1_MPCBB3_PRIV6             \ [0x06] PRIV6
    $07 constant GTZC1_MPCBB3_PRIV7             \ [0x07] PRIV7
    $08 constant GTZC1_MPCBB3_PRIV8             \ [0x08] PRIV8
    $09 constant GTZC1_MPCBB3_PRIV9             \ [0x09] PRIV9
    $0a constant GTZC1_MPCBB3_PRIV10            \ [0x0a] PRIV10
    $0b constant GTZC1_MPCBB3_PRIV11            \ [0x0b] PRIV11
    $0c constant GTZC1_MPCBB3_PRIV12            \ [0x0c] PRIV12
    $0d constant GTZC1_MPCBB3_PRIV13            \ [0x0d] PRIV13
    $0e constant GTZC1_MPCBB3_PRIV14            \ [0x0e] PRIV14
    $0f constant GTZC1_MPCBB3_PRIV15            \ [0x0f] PRIV15
    $10 constant GTZC1_MPCBB3_PRIV16            \ [0x10] PRIV16
    $11 constant GTZC1_MPCBB3_PRIV17            \ [0x11] PRIV17
    $12 constant GTZC1_MPCBB3_PRIV18            \ [0x12] PRIV18
    $13 constant GTZC1_MPCBB3_PRIV19            \ [0x13] PRIV19
    $14 constant GTZC1_MPCBB3_PRIV20            \ [0x14] PRIV20
    $15 constant GTZC1_MPCBB3_PRIV21            \ [0x15] PRIV21
    $16 constant GTZC1_MPCBB3_PRIV22            \ [0x16] PRIV22
    $17 constant GTZC1_MPCBB3_PRIV23            \ [0x17] PRIV23
    $18 constant GTZC1_MPCBB3_PRIV24            \ [0x18] PRIV24
    $19 constant GTZC1_MPCBB3_PRIV25            \ [0x19] PRIV25
    $1a constant GTZC1_MPCBB3_PRIV26            \ [0x1a] PRIV26
    $1b constant GTZC1_MPCBB3_PRIV27            \ [0x1b] PRIV27
    $1c constant GTZC1_MPCBB3_PRIV28            \ [0x1c] PRIV28
    $1d constant GTZC1_MPCBB3_PRIV29            \ [0x1d] PRIV29
    $1e constant GTZC1_MPCBB3_PRIV30            \ [0x1e] PRIV30
    $1f constant GTZC1_MPCBB3_PRIV31            \ [0x1f] PRIV31
  [then]


  [ifdef] GTZC1_MPCBB3_MPCBB3_PRIVCFGR45_DEF
    \
    \ @brief MPCBB privileged configuration for super-block x register
    \ Address offset: 0x2B4
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GTZC1_MPCBB3_PRIV0             \ [0x00] PRIV0
    $01 constant GTZC1_MPCBB3_PRIV1             \ [0x01] PRIV1
    $02 constant GTZC1_MPCBB3_PRIV2             \ [0x02] PRIV2
    $03 constant GTZC1_MPCBB3_PRIV3             \ [0x03] PRIV3
    $04 constant GTZC1_MPCBB3_PRIV4             \ [0x04] PRIV4
    $05 constant GTZC1_MPCBB3_PRIV5             \ [0x05] PRIV5
    $06 constant GTZC1_MPCBB3_PRIV6             \ [0x06] PRIV6
    $07 constant GTZC1_MPCBB3_PRIV7             \ [0x07] PRIV7
    $08 constant GTZC1_MPCBB3_PRIV8             \ [0x08] PRIV8
    $09 constant GTZC1_MPCBB3_PRIV9             \ [0x09] PRIV9
    $0a constant GTZC1_MPCBB3_PRIV10            \ [0x0a] PRIV10
    $0b constant GTZC1_MPCBB3_PRIV11            \ [0x0b] PRIV11
    $0c constant GTZC1_MPCBB3_PRIV12            \ [0x0c] PRIV12
    $0d constant GTZC1_MPCBB3_PRIV13            \ [0x0d] PRIV13
    $0e constant GTZC1_MPCBB3_PRIV14            \ [0x0e] PRIV14
    $0f constant GTZC1_MPCBB3_PRIV15            \ [0x0f] PRIV15
    $10 constant GTZC1_MPCBB3_PRIV16            \ [0x10] PRIV16
    $11 constant GTZC1_MPCBB3_PRIV17            \ [0x11] PRIV17
    $12 constant GTZC1_MPCBB3_PRIV18            \ [0x12] PRIV18
    $13 constant GTZC1_MPCBB3_PRIV19            \ [0x13] PRIV19
    $14 constant GTZC1_MPCBB3_PRIV20            \ [0x14] PRIV20
    $15 constant GTZC1_MPCBB3_PRIV21            \ [0x15] PRIV21
    $16 constant GTZC1_MPCBB3_PRIV22            \ [0x16] PRIV22
    $17 constant GTZC1_MPCBB3_PRIV23            \ [0x17] PRIV23
    $18 constant GTZC1_MPCBB3_PRIV24            \ [0x18] PRIV24
    $19 constant GTZC1_MPCBB3_PRIV25            \ [0x19] PRIV25
    $1a constant GTZC1_MPCBB3_PRIV26            \ [0x1a] PRIV26
    $1b constant GTZC1_MPCBB3_PRIV27            \ [0x1b] PRIV27
    $1c constant GTZC1_MPCBB3_PRIV28            \ [0x1c] PRIV28
    $1d constant GTZC1_MPCBB3_PRIV29            \ [0x1d] PRIV29
    $1e constant GTZC1_MPCBB3_PRIV30            \ [0x1e] PRIV30
    $1f constant GTZC1_MPCBB3_PRIV31            \ [0x1f] PRIV31
  [then]


  [ifdef] GTZC1_MPCBB3_MPCBB3_PRIVCFGR46_DEF
    \
    \ @brief MPCBB privileged configuration for super-block x register
    \ Address offset: 0x2B8
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GTZC1_MPCBB3_PRIV0             \ [0x00] PRIV0
    $01 constant GTZC1_MPCBB3_PRIV1             \ [0x01] PRIV1
    $02 constant GTZC1_MPCBB3_PRIV2             \ [0x02] PRIV2
    $03 constant GTZC1_MPCBB3_PRIV3             \ [0x03] PRIV3
    $04 constant GTZC1_MPCBB3_PRIV4             \ [0x04] PRIV4
    $05 constant GTZC1_MPCBB3_PRIV5             \ [0x05] PRIV5
    $06 constant GTZC1_MPCBB3_PRIV6             \ [0x06] PRIV6
    $07 constant GTZC1_MPCBB3_PRIV7             \ [0x07] PRIV7
    $08 constant GTZC1_MPCBB3_PRIV8             \ [0x08] PRIV8
    $09 constant GTZC1_MPCBB3_PRIV9             \ [0x09] PRIV9
    $0a constant GTZC1_MPCBB3_PRIV10            \ [0x0a] PRIV10
    $0b constant GTZC1_MPCBB3_PRIV11            \ [0x0b] PRIV11
    $0c constant GTZC1_MPCBB3_PRIV12            \ [0x0c] PRIV12
    $0d constant GTZC1_MPCBB3_PRIV13            \ [0x0d] PRIV13
    $0e constant GTZC1_MPCBB3_PRIV14            \ [0x0e] PRIV14
    $0f constant GTZC1_MPCBB3_PRIV15            \ [0x0f] PRIV15
    $10 constant GTZC1_MPCBB3_PRIV16            \ [0x10] PRIV16
    $11 constant GTZC1_MPCBB3_PRIV17            \ [0x11] PRIV17
    $12 constant GTZC1_MPCBB3_PRIV18            \ [0x12] PRIV18
    $13 constant GTZC1_MPCBB3_PRIV19            \ [0x13] PRIV19
    $14 constant GTZC1_MPCBB3_PRIV20            \ [0x14] PRIV20
    $15 constant GTZC1_MPCBB3_PRIV21            \ [0x15] PRIV21
    $16 constant GTZC1_MPCBB3_PRIV22            \ [0x16] PRIV22
    $17 constant GTZC1_MPCBB3_PRIV23            \ [0x17] PRIV23
    $18 constant GTZC1_MPCBB3_PRIV24            \ [0x18] PRIV24
    $19 constant GTZC1_MPCBB3_PRIV25            \ [0x19] PRIV25
    $1a constant GTZC1_MPCBB3_PRIV26            \ [0x1a] PRIV26
    $1b constant GTZC1_MPCBB3_PRIV27            \ [0x1b] PRIV27
    $1c constant GTZC1_MPCBB3_PRIV28            \ [0x1c] PRIV28
    $1d constant GTZC1_MPCBB3_PRIV29            \ [0x1d] PRIV29
    $1e constant GTZC1_MPCBB3_PRIV30            \ [0x1e] PRIV30
    $1f constant GTZC1_MPCBB3_PRIV31            \ [0x1f] PRIV31
  [then]


  [ifdef] GTZC1_MPCBB3_MPCBB3_PRIVCFGR47_DEF
    \
    \ @brief MPCBB privileged configuration for super-block x register
    \ Address offset: 0x2BC
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GTZC1_MPCBB3_PRIV0             \ [0x00] PRIV0
    $01 constant GTZC1_MPCBB3_PRIV1             \ [0x01] PRIV1
    $02 constant GTZC1_MPCBB3_PRIV2             \ [0x02] PRIV2
    $03 constant GTZC1_MPCBB3_PRIV3             \ [0x03] PRIV3
    $04 constant GTZC1_MPCBB3_PRIV4             \ [0x04] PRIV4
    $05 constant GTZC1_MPCBB3_PRIV5             \ [0x05] PRIV5
    $06 constant GTZC1_MPCBB3_PRIV6             \ [0x06] PRIV6
    $07 constant GTZC1_MPCBB3_PRIV7             \ [0x07] PRIV7
    $08 constant GTZC1_MPCBB3_PRIV8             \ [0x08] PRIV8
    $09 constant GTZC1_MPCBB3_PRIV9             \ [0x09] PRIV9
    $0a constant GTZC1_MPCBB3_PRIV10            \ [0x0a] PRIV10
    $0b constant GTZC1_MPCBB3_PRIV11            \ [0x0b] PRIV11
    $0c constant GTZC1_MPCBB3_PRIV12            \ [0x0c] PRIV12
    $0d constant GTZC1_MPCBB3_PRIV13            \ [0x0d] PRIV13
    $0e constant GTZC1_MPCBB3_PRIV14            \ [0x0e] PRIV14
    $0f constant GTZC1_MPCBB3_PRIV15            \ [0x0f] PRIV15
    $10 constant GTZC1_MPCBB3_PRIV16            \ [0x10] PRIV16
    $11 constant GTZC1_MPCBB3_PRIV17            \ [0x11] PRIV17
    $12 constant GTZC1_MPCBB3_PRIV18            \ [0x12] PRIV18
    $13 constant GTZC1_MPCBB3_PRIV19            \ [0x13] PRIV19
    $14 constant GTZC1_MPCBB3_PRIV20            \ [0x14] PRIV20
    $15 constant GTZC1_MPCBB3_PRIV21            \ [0x15] PRIV21
    $16 constant GTZC1_MPCBB3_PRIV22            \ [0x16] PRIV22
    $17 constant GTZC1_MPCBB3_PRIV23            \ [0x17] PRIV23
    $18 constant GTZC1_MPCBB3_PRIV24            \ [0x18] PRIV24
    $19 constant GTZC1_MPCBB3_PRIV25            \ [0x19] PRIV25
    $1a constant GTZC1_MPCBB3_PRIV26            \ [0x1a] PRIV26
    $1b constant GTZC1_MPCBB3_PRIV27            \ [0x1b] PRIV27
    $1c constant GTZC1_MPCBB3_PRIV28            \ [0x1c] PRIV28
    $1d constant GTZC1_MPCBB3_PRIV29            \ [0x1d] PRIV29
    $1e constant GTZC1_MPCBB3_PRIV30            \ [0x1e] PRIV30
    $1f constant GTZC1_MPCBB3_PRIV31            \ [0x1f] PRIV31
  [then]


  [ifdef] GTZC1_MPCBB3_MPCBB3_PRIVCFGR48_DEF
    \
    \ @brief MPCBB privileged configuration for super-block x register
    \ Address offset: 0x2C0
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GTZC1_MPCBB3_PRIV0             \ [0x00] PRIV0
    $01 constant GTZC1_MPCBB3_PRIV1             \ [0x01] PRIV1
    $02 constant GTZC1_MPCBB3_PRIV2             \ [0x02] PRIV2
    $03 constant GTZC1_MPCBB3_PRIV3             \ [0x03] PRIV3
    $04 constant GTZC1_MPCBB3_PRIV4             \ [0x04] PRIV4
    $05 constant GTZC1_MPCBB3_PRIV5             \ [0x05] PRIV5
    $06 constant GTZC1_MPCBB3_PRIV6             \ [0x06] PRIV6
    $07 constant GTZC1_MPCBB3_PRIV7             \ [0x07] PRIV7
    $08 constant GTZC1_MPCBB3_PRIV8             \ [0x08] PRIV8
    $09 constant GTZC1_MPCBB3_PRIV9             \ [0x09] PRIV9
    $0a constant GTZC1_MPCBB3_PRIV10            \ [0x0a] PRIV10
    $0b constant GTZC1_MPCBB3_PRIV11            \ [0x0b] PRIV11
    $0c constant GTZC1_MPCBB3_PRIV12            \ [0x0c] PRIV12
    $0d constant GTZC1_MPCBB3_PRIV13            \ [0x0d] PRIV13
    $0e constant GTZC1_MPCBB3_PRIV14            \ [0x0e] PRIV14
    $0f constant GTZC1_MPCBB3_PRIV15            \ [0x0f] PRIV15
    $10 constant GTZC1_MPCBB3_PRIV16            \ [0x10] PRIV16
    $11 constant GTZC1_MPCBB3_PRIV17            \ [0x11] PRIV17
    $12 constant GTZC1_MPCBB3_PRIV18            \ [0x12] PRIV18
    $13 constant GTZC1_MPCBB3_PRIV19            \ [0x13] PRIV19
    $14 constant GTZC1_MPCBB3_PRIV20            \ [0x14] PRIV20
    $15 constant GTZC1_MPCBB3_PRIV21            \ [0x15] PRIV21
    $16 constant GTZC1_MPCBB3_PRIV22            \ [0x16] PRIV22
    $17 constant GTZC1_MPCBB3_PRIV23            \ [0x17] PRIV23
    $18 constant GTZC1_MPCBB3_PRIV24            \ [0x18] PRIV24
    $19 constant GTZC1_MPCBB3_PRIV25            \ [0x19] PRIV25
    $1a constant GTZC1_MPCBB3_PRIV26            \ [0x1a] PRIV26
    $1b constant GTZC1_MPCBB3_PRIV27            \ [0x1b] PRIV27
    $1c constant GTZC1_MPCBB3_PRIV28            \ [0x1c] PRIV28
    $1d constant GTZC1_MPCBB3_PRIV29            \ [0x1d] PRIV29
    $1e constant GTZC1_MPCBB3_PRIV30            \ [0x1e] PRIV30
    $1f constant GTZC1_MPCBB3_PRIV31            \ [0x1f] PRIV31
  [then]


  [ifdef] GTZC1_MPCBB3_MPCBB3_PRIVCFGR49_DEF
    \
    \ @brief MPCBB privileged configuration for super-block x register
    \ Address offset: 0x2C4
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GTZC1_MPCBB3_PRIV0             \ [0x00] PRIV0
    $01 constant GTZC1_MPCBB3_PRIV1             \ [0x01] PRIV1
    $02 constant GTZC1_MPCBB3_PRIV2             \ [0x02] PRIV2
    $03 constant GTZC1_MPCBB3_PRIV3             \ [0x03] PRIV3
    $04 constant GTZC1_MPCBB3_PRIV4             \ [0x04] PRIV4
    $05 constant GTZC1_MPCBB3_PRIV5             \ [0x05] PRIV5
    $06 constant GTZC1_MPCBB3_PRIV6             \ [0x06] PRIV6
    $07 constant GTZC1_MPCBB3_PRIV7             \ [0x07] PRIV7
    $08 constant GTZC1_MPCBB3_PRIV8             \ [0x08] PRIV8
    $09 constant GTZC1_MPCBB3_PRIV9             \ [0x09] PRIV9
    $0a constant GTZC1_MPCBB3_PRIV10            \ [0x0a] PRIV10
    $0b constant GTZC1_MPCBB3_PRIV11            \ [0x0b] PRIV11
    $0c constant GTZC1_MPCBB3_PRIV12            \ [0x0c] PRIV12
    $0d constant GTZC1_MPCBB3_PRIV13            \ [0x0d] PRIV13
    $0e constant GTZC1_MPCBB3_PRIV14            \ [0x0e] PRIV14
    $0f constant GTZC1_MPCBB3_PRIV15            \ [0x0f] PRIV15
    $10 constant GTZC1_MPCBB3_PRIV16            \ [0x10] PRIV16
    $11 constant GTZC1_MPCBB3_PRIV17            \ [0x11] PRIV17
    $12 constant GTZC1_MPCBB3_PRIV18            \ [0x12] PRIV18
    $13 constant GTZC1_MPCBB3_PRIV19            \ [0x13] PRIV19
    $14 constant GTZC1_MPCBB3_PRIV20            \ [0x14] PRIV20
    $15 constant GTZC1_MPCBB3_PRIV21            \ [0x15] PRIV21
    $16 constant GTZC1_MPCBB3_PRIV22            \ [0x16] PRIV22
    $17 constant GTZC1_MPCBB3_PRIV23            \ [0x17] PRIV23
    $18 constant GTZC1_MPCBB3_PRIV24            \ [0x18] PRIV24
    $19 constant GTZC1_MPCBB3_PRIV25            \ [0x19] PRIV25
    $1a constant GTZC1_MPCBB3_PRIV26            \ [0x1a] PRIV26
    $1b constant GTZC1_MPCBB3_PRIV27            \ [0x1b] PRIV27
    $1c constant GTZC1_MPCBB3_PRIV28            \ [0x1c] PRIV28
    $1d constant GTZC1_MPCBB3_PRIV29            \ [0x1d] PRIV29
    $1e constant GTZC1_MPCBB3_PRIV30            \ [0x1e] PRIV30
    $1f constant GTZC1_MPCBB3_PRIV31            \ [0x1f] PRIV31
  [then]


  [ifdef] GTZC1_MPCBB3_MPCBB3_PRIVCFGR50_DEF
    \
    \ @brief MPCBB privileged configuration for super-block x register
    \ Address offset: 0x2C8
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GTZC1_MPCBB3_PRIV0             \ [0x00] PRIV0
    $01 constant GTZC1_MPCBB3_PRIV1             \ [0x01] PRIV1
    $02 constant GTZC1_MPCBB3_PRIV2             \ [0x02] PRIV2
    $03 constant GTZC1_MPCBB3_PRIV3             \ [0x03] PRIV3
    $04 constant GTZC1_MPCBB3_PRIV4             \ [0x04] PRIV4
    $05 constant GTZC1_MPCBB3_PRIV5             \ [0x05] PRIV5
    $06 constant GTZC1_MPCBB3_PRIV6             \ [0x06] PRIV6
    $07 constant GTZC1_MPCBB3_PRIV7             \ [0x07] PRIV7
    $08 constant GTZC1_MPCBB3_PRIV8             \ [0x08] PRIV8
    $09 constant GTZC1_MPCBB3_PRIV9             \ [0x09] PRIV9
    $0a constant GTZC1_MPCBB3_PRIV10            \ [0x0a] PRIV10
    $0b constant GTZC1_MPCBB3_PRIV11            \ [0x0b] PRIV11
    $0c constant GTZC1_MPCBB3_PRIV12            \ [0x0c] PRIV12
    $0d constant GTZC1_MPCBB3_PRIV13            \ [0x0d] PRIV13
    $0e constant GTZC1_MPCBB3_PRIV14            \ [0x0e] PRIV14
    $0f constant GTZC1_MPCBB3_PRIV15            \ [0x0f] PRIV15
    $10 constant GTZC1_MPCBB3_PRIV16            \ [0x10] PRIV16
    $11 constant GTZC1_MPCBB3_PRIV17            \ [0x11] PRIV17
    $12 constant GTZC1_MPCBB3_PRIV18            \ [0x12] PRIV18
    $13 constant GTZC1_MPCBB3_PRIV19            \ [0x13] PRIV19
    $14 constant GTZC1_MPCBB3_PRIV20            \ [0x14] PRIV20
    $15 constant GTZC1_MPCBB3_PRIV21            \ [0x15] PRIV21
    $16 constant GTZC1_MPCBB3_PRIV22            \ [0x16] PRIV22
    $17 constant GTZC1_MPCBB3_PRIV23            \ [0x17] PRIV23
    $18 constant GTZC1_MPCBB3_PRIV24            \ [0x18] PRIV24
    $19 constant GTZC1_MPCBB3_PRIV25            \ [0x19] PRIV25
    $1a constant GTZC1_MPCBB3_PRIV26            \ [0x1a] PRIV26
    $1b constant GTZC1_MPCBB3_PRIV27            \ [0x1b] PRIV27
    $1c constant GTZC1_MPCBB3_PRIV28            \ [0x1c] PRIV28
    $1d constant GTZC1_MPCBB3_PRIV29            \ [0x1d] PRIV29
    $1e constant GTZC1_MPCBB3_PRIV30            \ [0x1e] PRIV30
    $1f constant GTZC1_MPCBB3_PRIV31            \ [0x1f] PRIV31
  [then]


  [ifdef] GTZC1_MPCBB3_MPCBB3_PRIVCFGR51_DEF
    \
    \ @brief MPCBB privileged configuration for super-block x register
    \ Address offset: 0x2CC
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GTZC1_MPCBB3_PRIV0             \ [0x00] PRIV0
    $01 constant GTZC1_MPCBB3_PRIV1             \ [0x01] PRIV1
    $02 constant GTZC1_MPCBB3_PRIV2             \ [0x02] PRIV2
    $03 constant GTZC1_MPCBB3_PRIV3             \ [0x03] PRIV3
    $04 constant GTZC1_MPCBB3_PRIV4             \ [0x04] PRIV4
    $05 constant GTZC1_MPCBB3_PRIV5             \ [0x05] PRIV5
    $06 constant GTZC1_MPCBB3_PRIV6             \ [0x06] PRIV6
    $07 constant GTZC1_MPCBB3_PRIV7             \ [0x07] PRIV7
    $08 constant GTZC1_MPCBB3_PRIV8             \ [0x08] PRIV8
    $09 constant GTZC1_MPCBB3_PRIV9             \ [0x09] PRIV9
    $0a constant GTZC1_MPCBB3_PRIV10            \ [0x0a] PRIV10
    $0b constant GTZC1_MPCBB3_PRIV11            \ [0x0b] PRIV11
    $0c constant GTZC1_MPCBB3_PRIV12            \ [0x0c] PRIV12
    $0d constant GTZC1_MPCBB3_PRIV13            \ [0x0d] PRIV13
    $0e constant GTZC1_MPCBB3_PRIV14            \ [0x0e] PRIV14
    $0f constant GTZC1_MPCBB3_PRIV15            \ [0x0f] PRIV15
    $10 constant GTZC1_MPCBB3_PRIV16            \ [0x10] PRIV16
    $11 constant GTZC1_MPCBB3_PRIV17            \ [0x11] PRIV17
    $12 constant GTZC1_MPCBB3_PRIV18            \ [0x12] PRIV18
    $13 constant GTZC1_MPCBB3_PRIV19            \ [0x13] PRIV19
    $14 constant GTZC1_MPCBB3_PRIV20            \ [0x14] PRIV20
    $15 constant GTZC1_MPCBB3_PRIV21            \ [0x15] PRIV21
    $16 constant GTZC1_MPCBB3_PRIV22            \ [0x16] PRIV22
    $17 constant GTZC1_MPCBB3_PRIV23            \ [0x17] PRIV23
    $18 constant GTZC1_MPCBB3_PRIV24            \ [0x18] PRIV24
    $19 constant GTZC1_MPCBB3_PRIV25            \ [0x19] PRIV25
    $1a constant GTZC1_MPCBB3_PRIV26            \ [0x1a] PRIV26
    $1b constant GTZC1_MPCBB3_PRIV27            \ [0x1b] PRIV27
    $1c constant GTZC1_MPCBB3_PRIV28            \ [0x1c] PRIV28
    $1d constant GTZC1_MPCBB3_PRIV29            \ [0x1d] PRIV29
    $1e constant GTZC1_MPCBB3_PRIV30            \ [0x1e] PRIV30
    $1f constant GTZC1_MPCBB3_PRIV31            \ [0x1f] PRIV31
  [then]

  \
  \ @brief GTZC1_MPCBB3
  \
  $00 constant GTZC1_MPCBB3_MPCBB3_CR   \ MPCBB control register
  $10 constant GTZC1_MPCBB3_MPCBB3_CFGLOCK1    \ GTZC1 SRAMz MPCBB configuration lock register
  $14 constant GTZC1_MPCBB3_MPCBB3_CFGLOCK2    \ GTZC1 SRAMz MPCBB configuration lock register 2
  $100 constant GTZC1_MPCBB3_MPCBB3_SECCFGR0    \ MPCBBx security configuration for super-block x register
  $104 constant GTZC1_MPCBB3_MPCBB3_SECCFGR1    \ MPCBBx security configuration for super-block x register
  $108 constant GTZC1_MPCBB3_MPCBB3_SECCFGR2    \ MPCBBx security configuration for super-block x register
  $10C constant GTZC1_MPCBB3_MPCBB3_SECCFGR3    \ MPCBBx security configuration for super-block x register
  $110 constant GTZC1_MPCBB3_MPCBB3_SECCFGR4    \ MPCBBx security configuration for super-block x register
  $114 constant GTZC1_MPCBB3_MPCBB3_SECCFGR5    \ MPCBBx security configuration for super-block x register
  $118 constant GTZC1_MPCBB3_MPCBB3_SECCFGR6    \ MPCBBx security configuration for super-block x register
  $11C constant GTZC1_MPCBB3_MPCBB3_SECCFGR7    \ MPCBBx security configuration for super-block x register
  $120 constant GTZC1_MPCBB3_MPCBB3_SECCFGR8    \ MPCBBx security configuration for super-block x register
  $124 constant GTZC1_MPCBB3_MPCBB3_SECCFGR9    \ MPCBBx security configuration for super-block x register
  $128 constant GTZC1_MPCBB3_MPCBB3_SECCFGR10    \ MPCBBx security configuration for super-block x register
  $12C constant GTZC1_MPCBB3_MPCBB3_SECCFGR11    \ MPCBBx security configuration for super-block x register
  $130 constant GTZC1_MPCBB3_MPCBB3_SECCFGR12    \ MPCBBx security configuration for super-block x register
  $134 constant GTZC1_MPCBB3_MPCBB3_SECCFGR13    \ MPCBBx security configuration for super-block x register
  $138 constant GTZC1_MPCBB3_MPCBB3_SECCFGR14    \ MPCBBx security configuration for super-block x register
  $13C constant GTZC1_MPCBB3_MPCBB3_SECCFGR15    \ MPCBBx security configuration for super-block x register
  $140 constant GTZC1_MPCBB3_MPCBB3_SECCFGR16    \ MPCBBx security configuration for super-block x register
  $144 constant GTZC1_MPCBB3_MPCBB3_SECCFGR17    \ MPCBBx security configuration for super-block x register
  $148 constant GTZC1_MPCBB3_MPCBB3_SECCFGR18    \ MPCBBx security configuration for super-block x register
  $14C constant GTZC1_MPCBB3_MPCBB3_SECCFGR19    \ MPCBBx security configuration for super-block x register
  $150 constant GTZC1_MPCBB3_MPCBB3_SECCFGR20    \ MPCBBx security configuration for super-block x register
  $154 constant GTZC1_MPCBB3_MPCBB3_SECCFGR21    \ MPCBBx security configuration for super-block x register
  $158 constant GTZC1_MPCBB3_MPCBB3_SECCFGR22    \ MPCBBx security configuration for super-block x register
  $15C constant GTZC1_MPCBB3_MPCBB3_SECCFGR23    \ MPCBBx security configuration for super-block x register
  $160 constant GTZC1_MPCBB3_MPCBB3_SECCFGR24    \ MPCBBx security configuration for super-block x register
  $164 constant GTZC1_MPCBB3_MPCBB3_SECCFGR25    \ MPCBBx security configuration for super-block x register
  $168 constant GTZC1_MPCBB3_MPCBB3_SECCFGR26    \ MPCBBx security configuration for super-block x register
  $16C constant GTZC1_MPCBB3_MPCBB3_SECCFGR27    \ MPCBBx security configuration for super-block x register
  $170 constant GTZC1_MPCBB3_MPCBB3_SECCFGR28    \ MPCBBx security configuration for super-block x register
  $174 constant GTZC1_MPCBB3_MPCBB3_SECCFGR29    \ MPCBBx security configuration for super-block x register
  $178 constant GTZC1_MPCBB3_MPCBB3_SECCFGR30    \ MPCBBx security configuration for super-block x register
  $17C constant GTZC1_MPCBB3_MPCBB3_SECCFGR31    \ MPCBBx security configuration for super-block x register
  $180 constant GTZC1_MPCBB3_MPCBB3_SECCFGR32    \ MPCBBx security configuration for super-block x register
  $184 constant GTZC1_MPCBB3_MPCBB3_SECCFGR33    \ MPCBBx security configuration for super-block x register
  $188 constant GTZC1_MPCBB3_MPCBB3_SECCFGR34    \ MPCBBx security configuration for super-block x register
  $18C constant GTZC1_MPCBB3_MPCBB3_SECCFGR35    \ MPCBBx security configuration for super-block x register
  $190 constant GTZC1_MPCBB3_MPCBB3_SECCFGR36    \ MPCBBx security configuration for super-block x register
  $194 constant GTZC1_MPCBB3_MPCBB3_SECCFGR37    \ MPCBBx security configuration for super-block x register
  $198 constant GTZC1_MPCBB3_MPCBB3_SECCFGR38    \ MPCBBx security configuration for super-block x register
  $19C constant GTZC1_MPCBB3_MPCBB3_SECCFGR39    \ MPCBBx security configuration for super-block x register
  $1A0 constant GTZC1_MPCBB3_MPCBB3_SECCFGR40    \ MPCBBx security configuration for super-block x register
  $1A4 constant GTZC1_MPCBB3_MPCBB3_SECCFGR41    \ MPCBBx security configuration for super-block x register
  $1A8 constant GTZC1_MPCBB3_MPCBB3_SECCFGR42    \ MPCBBx security configuration for super-block x register
  $1AC constant GTZC1_MPCBB3_MPCBB3_SECCFGR43    \ MPCBBx security configuration for super-block x register
  $1B0 constant GTZC1_MPCBB3_MPCBB3_SECCFGR44    \ MPCBBx security configuration for super-block x register
  $1B4 constant GTZC1_MPCBB3_MPCBB3_SECCFGR45    \ MPCBBx security configuration for super-block x register
  $1B8 constant GTZC1_MPCBB3_MPCBB3_SECCFGR46    \ MPCBBx security configuration for super-block x register
  $1BC constant GTZC1_MPCBB3_MPCBB3_SECCFGR47    \ MPCBBx security configuration for super-block x register
  $1C0 constant GTZC1_MPCBB3_MPCBB3_SECCFGR48    \ MPCBBx security configuration for super-block x register
  $1C4 constant GTZC1_MPCBB3_MPCBB3_SECCFGR49    \ MPCBBx security configuration for super-block x register
  $1C8 constant GTZC1_MPCBB3_MPCBB3_SECCFGR50    \ MPCBBx security configuration for super-block x register
  $1CC constant GTZC1_MPCBB3_MPCBB3_SECCFGR51    \ MPCBBx security configuration for super-block x register
  $200 constant GTZC1_MPCBB3_MPCBB3_PRIVCFGR0    \ MPCBB privileged configuration for super-block x register
  $204 constant GTZC1_MPCBB3_MPCBB3_PRIVCFGR1    \ MPCBB privileged configuration for super-block x register
  $208 constant GTZC1_MPCBB3_MPCBB3_PRIVCFGR2    \ MPCBB privileged configuration for super-block x register
  $20C constant GTZC1_MPCBB3_MPCBB3_PRIVCFGR3    \ MPCBB privileged configuration for super-block x register
  $210 constant GTZC1_MPCBB3_MPCBB3_PRIVCFGR4    \ MPCBB privileged configuration for super-block x register
  $214 constant GTZC1_MPCBB3_MPCBB3_PRIVCFGR5    \ MPCBB privileged configuration for super-block x register
  $218 constant GTZC1_MPCBB3_MPCBB3_PRIVCFGR6    \ MPCBB privileged configuration for super-block x register
  $21C constant GTZC1_MPCBB3_MPCBB3_PRIVCFGR7    \ MPCBB privileged configuration for super-block x register
  $220 constant GTZC1_MPCBB3_MPCBB3_PRIVCFGR8    \ MPCBB privileged configuration for super-block x register
  $224 constant GTZC1_MPCBB3_MPCBB3_PRIVCFGR9    \ MPCBB privileged configuration for super-block x register
  $228 constant GTZC1_MPCBB3_MPCBB3_PRIVCFGR10    \ MPCBB privileged configuration for super-block x register
  $22C constant GTZC1_MPCBB3_MPCBB3_PRIVCFGR11    \ MPCBB privileged configuration for super-block x register
  $230 constant GTZC1_MPCBB3_MPCBB3_PRIVCFGR12    \ MPCBB privileged configuration for super-block x register
  $234 constant GTZC1_MPCBB3_MPCBB3_PRIVCFGR13    \ MPCBB privileged configuration for super-block x register
  $238 constant GTZC1_MPCBB3_MPCBB3_PRIVCFGR14    \ MPCBB privileged configuration for super-block x register
  $23C constant GTZC1_MPCBB3_MPCBB3_PRIVCFGR15    \ MPCBB privileged configuration for super-block x register
  $240 constant GTZC1_MPCBB3_MPCBB3_PRIVCFGR16    \ MPCBB privileged configuration for super-block x register
  $244 constant GTZC1_MPCBB3_MPCBB3_PRIVCFGR17    \ MPCBB privileged configuration for super-block x register
  $248 constant GTZC1_MPCBB3_MPCBB3_PRIVCFGR18    \ MPCBB privileged configuration for super-block x register
  $24C constant GTZC1_MPCBB3_MPCBB3_PRIVCFGR19    \ MPCBB privileged configuration for super-block x register
  $250 constant GTZC1_MPCBB3_MPCBB3_PRIVCFGR20    \ MPCBB privileged configuration for super-block x register
  $254 constant GTZC1_MPCBB3_MPCBB3_PRIVCFGR21    \ MPCBB privileged configuration for super-block x register
  $258 constant GTZC1_MPCBB3_MPCBB3_PRIVCFGR22    \ MPCBB privileged configuration for super-block x register
  $25C constant GTZC1_MPCBB3_MPCBB3_PRIVCFGR23    \ MPCBB privileged configuration for super-block x register
  $260 constant GTZC1_MPCBB3_MPCBB3_PRIVCFGR24    \ MPCBB privileged configuration for super-block x register
  $264 constant GTZC1_MPCBB3_MPCBB3_PRIVCFGR25    \ MPCBB privileged configuration for super-block x register
  $268 constant GTZC1_MPCBB3_MPCBB3_PRIVCFGR26    \ MPCBB privileged configuration for super-block x register
  $26C constant GTZC1_MPCBB3_MPCBB3_PRIVCFGR27    \ MPCBB privileged configuration for super-block x register
  $270 constant GTZC1_MPCBB3_MPCBB3_PRIVCFGR28    \ MPCBB privileged configuration for super-block x register
  $274 constant GTZC1_MPCBB3_MPCBB3_PRIVCFGR29    \ MPCBB privileged configuration for super-block x register
  $278 constant GTZC1_MPCBB3_MPCBB3_PRIVCFGR30    \ MPCBB privileged configuration for super-block x register
  $27C constant GTZC1_MPCBB3_MPCBB3_PRIVCFGR31    \ MPCBB privileged configuration for super-block x register
  $280 constant GTZC1_MPCBB3_MPCBB3_PRIVCFGR32    \ MPCBB privileged configuration for super-block x register
  $284 constant GTZC1_MPCBB3_MPCBB3_PRIVCFGR33    \ MPCBB privileged configuration for super-block x register
  $288 constant GTZC1_MPCBB3_MPCBB3_PRIVCFGR34    \ MPCBB privileged configuration for super-block x register
  $28C constant GTZC1_MPCBB3_MPCBB3_PRIVCFGR35    \ MPCBB privileged configuration for super-block x register
  $290 constant GTZC1_MPCBB3_MPCBB3_PRIVCFGR36    \ MPCBB privileged configuration for super-block x register
  $294 constant GTZC1_MPCBB3_MPCBB3_PRIVCFGR37    \ MPCBB privileged configuration for super-block x register
  $298 constant GTZC1_MPCBB3_MPCBB3_PRIVCFGR38    \ MPCBB privileged configuration for super-block x register
  $29C constant GTZC1_MPCBB3_MPCBB3_PRIVCFGR39    \ MPCBB privileged configuration for super-block x register
  $2A0 constant GTZC1_MPCBB3_MPCBB3_PRIVCFGR40    \ MPCBB privileged configuration for super-block x register
  $2A4 constant GTZC1_MPCBB3_MPCBB3_PRIVCFGR41    \ MPCBB privileged configuration for super-block x register
  $2A8 constant GTZC1_MPCBB3_MPCBB3_PRIVCFGR42    \ MPCBB privileged configuration for super-block x register
  $2AC constant GTZC1_MPCBB3_MPCBB3_PRIVCFGR43    \ MPCBB privileged configuration for super-block x register
  $2B0 constant GTZC1_MPCBB3_MPCBB3_PRIVCFGR44    \ MPCBB privileged configuration for super-block x register
  $2B4 constant GTZC1_MPCBB3_MPCBB3_PRIVCFGR45    \ MPCBB privileged configuration for super-block x register
  $2B8 constant GTZC1_MPCBB3_MPCBB3_PRIVCFGR46    \ MPCBB privileged configuration for super-block x register
  $2BC constant GTZC1_MPCBB3_MPCBB3_PRIVCFGR47    \ MPCBB privileged configuration for super-block x register
  $2C0 constant GTZC1_MPCBB3_MPCBB3_PRIVCFGR48    \ MPCBB privileged configuration for super-block x register
  $2C4 constant GTZC1_MPCBB3_MPCBB3_PRIVCFGR49    \ MPCBB privileged configuration for super-block x register
  $2C8 constant GTZC1_MPCBB3_MPCBB3_PRIVCFGR50    \ MPCBB privileged configuration for super-block x register
  $2CC constant GTZC1_MPCBB3_MPCBB3_PRIVCFGR51    \ MPCBB privileged configuration for super-block x register

: GTZC1_MPCBB3_DEF ; [then]
