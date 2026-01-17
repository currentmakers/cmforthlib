\
\ @file rng.fs
\ @brief RNG_CR register
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] RNG_DEF

  [ifdef] RNG_RNG_CR_DEF
    \
    \ @brief RNG_CR register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $02 constant RNG_RNG_DIS                    \ [0x02] RNG Disable bit.
    $03 constant RNG_TST_CLK                    \ [0x03] RNG Test Clock bit.
  [then]


  [ifdef] RNG_RNG_SR_DEF
    \
    \ @brief RNG_SR register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant RNG_RNGRDY                     \ [0x00] New Random Value Ready.
    $01 constant RNG_REVCLK                     \ [0x01] RNGCLK Clock Reveal bit.
    $02 constant RNG_FAULT                      \ [0x02] Fault Reveal bit.
  [then]


  [ifdef] RNG_RNG_VAL_DEF
    \
    \ @brief RNG_VAL register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant RNG_RANDOM_VALUE               \ [0x00 : 16] Random Value
  [then]


  [ifdef] RNG_RNG_TCR_DEF
    \
    \ @brief RNG_TCR register
    \ Address offset: 0x80
    \ Reset value: 0x00000000
    \
    $00 constant RNG_TCR                        \ [0x00] Test-control register
  [then]


  [ifdef] RNG_RNG_ITIP_DEF
    \
    \ @brief RNG_ITIP register
    \ Address offset: 0x84
    \ Reset value: 0x00000000
    \
    $00 constant RNG_ITIP                       \ [0x00] Integration-test input register
  [then]


  [ifdef] RNG_RNGPeriphID0_DEF
    \
    \ @brief RNGPeriphID0 register
    \ Address offset: 0xFE0
    \ Reset value: 0x000000E1
    \
    $00 constant RNG_PartNumber0                \ [0x00 : 8] These bits are read back as 0xE1
  [then]


  [ifdef] RNG_RNGPeriphID1_DEF
    \
    \ @brief RNGPeriphID1 register
    \ Address offset: 0xFE4
    \ Reset value: 0x00000005
    \
    $00 constant RNG_PartNumber1                \ [0x00 : 4] These bits are read back as 0x05
    $04 constant RNG_Designer0                  \ [0x04 : 4] These bits are read back as 0x00
  [then]


  [ifdef] RNG_RNGPeriphID2_DEF
    \
    \ @brief RNGPeriphID2 register
    \ Address offset: 0xFE8
    \ Reset value: 0x00000028
    \
    $00 constant RNG_Designer1                  \ [0x00 : 4] These bits are read back as 0x08
    $04 constant RNG_Revision                   \ [0x04 : 4] These bits are read back as 0x02
  [then]


  [ifdef] RNG_RNGPeriphID3_DEF
    \
    \ @brief RNGPeriphID3 register
    \ Address offset: 0xFEC
    \ Reset value: 0x00000000
    \
    $00 constant RNG_Configuration              \ [0x00 : 8] These bits are read back as 0x00
  [then]


  [ifdef] RNG_RNGPCellID0_DEF
    \
    \ @brief RNGPCellID0 register
    \ Address offset: 0xFF0
    \ Reset value: 0x0000000D
    \
    $00 constant RNG_RNGPCellID0                \ [0x00 : 8] These bits are read back as 0x0D
  [then]


  [ifdef] RNG_RNGPCellID1_DEF
    \
    \ @brief RNGPCellID1 register
    \ Address offset: 0xFF4
    \ Reset value: 0x000000F0
    \
    $00 constant RNG_RNGPCellID1                \ [0x00 : 8] These bits are read back as 0xF0
  [then]


  [ifdef] RNG_RNGPCellID2_DEF
    \
    \ @brief RNGPCellID2 register
    \ Address offset: 0xFF8
    \ Reset value: 0x00000005
    \
    $00 constant RNG_RNGPCellID2                \ [0x00 : 8] These bits are read back as 0x05
  [then]


  [ifdef] RNG_RNGPCellID3_DEF
    \
    \ @brief RNGPCellID3 register
    \ Address offset: 0xFFC
    \ Reset value: 0x000000B1
    \
    $00 constant RNG_RNGPCellID3                \ [0x00 : 8] These bits are read back as 0xB1
  [then]

  \
  \ @brief RNG_CR register
  \
  $00 constant RNG_RNG_CR               \ RNG_CR register
  $04 constant RNG_RNG_SR               \ RNG_SR register
  $08 constant RNG_RNG_VAL              \ RNG_VAL register
  $80 constant RNG_RNG_TCR              \ RNG_TCR register
  $84 constant RNG_RNG_ITIP             \ RNG_ITIP register
  $FE0 constant RNG_RNGPERIPHID0        \ RNGPeriphID0 register
  $FE4 constant RNG_RNGPERIPHID1        \ RNGPeriphID1 register
  $FE8 constant RNG_RNGPERIPHID2        \ RNGPeriphID2 register
  $FEC constant RNG_RNGPERIPHID3        \ RNGPeriphID3 register
  $FF0 constant RNG_RNGPCELLID0         \ RNGPCellID0 register
  $FF4 constant RNG_RNGPCELLID1         \ RNGPCellID1 register
  $FF8 constant RNG_RNGPCELLID2         \ RNGPCellID2 register
  $FFC constant RNG_RNGPCELLID3         \ RNGPCellID3 register

: RNG_DEF ; [then]
