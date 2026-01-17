\
\ @file delay_block_.fs
\ @brief DELAY_Block_SDMMC1
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] DELAY_BLOCK__DEF

  [ifdef] DELAY_BLOCK__CR_DEF
    \
    \ @brief DLYB control register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant DELAY_BLOCK__DEN               \ [0x00] Delay block enable bit
    $01 constant DELAY_BLOCK__SEN               \ [0x01] Sampler length enable bit
  [then]


  [ifdef] DELAY_BLOCK__CFGR_DEF
    \
    \ @brief DLYB configuration register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant DELAY_BLOCK__SEL               \ [0x00 : 4] Select the phase for the Output clock
    $08 constant DELAY_BLOCK__UNIT              \ [0x08 : 7] Delay Defines the delay of a Unit delay cell
    $10 constant DELAY_BLOCK__LNG               \ [0x10 : 12] Delay line length value
    $1f constant DELAY_BLOCK__LNGF              \ [0x1f] Length valid flag
  [then]

  \
  \ @brief DELAY_Block_SDMMC1
  \
  $00 constant DELAY_BLOCK__CR          \ DLYB control register
  $04 constant DELAY_BLOCK__CFGR        \ DLYB configuration register

: DELAY_BLOCK__DEF ; [then]
