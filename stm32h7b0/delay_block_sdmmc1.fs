\
\ @file delay_block_sdmmc1.fs
\ @brief DELAY_Block_SDMMC1
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] DELAY_BLOCK_SDMMC1_DEF

  [ifdef] DELAY_BLOCK_SDMMC1_CR_DEF
    \
    \ @brief DLYB control register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant DELAY_BLOCK_SDMMC1_DEN         \ [0x00] Delay block enable bit
    $01 constant DELAY_BLOCK_SDMMC1_SEN         \ [0x01] Sampler length enable bit
  [then]


  [ifdef] DELAY_BLOCK_SDMMC1_CFGR_DEF
    \
    \ @brief DLYB configuration register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant DELAY_BLOCK_SDMMC1_SEL         \ [0x00 : 4] Select the phase for the Output clock
    $08 constant DELAY_BLOCK_SDMMC1_UNIT        \ [0x08 : 7] Delay Defines the delay of a Unit delay cell
    $10 constant DELAY_BLOCK_SDMMC1_LNG         \ [0x10 : 12] Delay line length value
    $1f constant DELAY_BLOCK_SDMMC1_LNGF        \ [0x1f] Length valid flag
  [then]

  \
  \ @brief DELAY_Block_SDMMC1
  \
  $00 constant DELAY_BLOCK_SDMMC1_CR    \ DLYB control register
  $04 constant DELAY_BLOCK_SDMMC1_CFGR  \ DLYB configuration register

: DELAY_BLOCK_SDMMC1_DEF ; [then]
