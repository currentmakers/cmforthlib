\
\ @file dac.fs
\ @brief Digital-to-analog converter
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] DAC_DEF

  [ifdef] DAC_CR_DEF
    \
    \ @brief control register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant DAC_EN1                        \ [0x00] DAC channel1 enable
    $01 constant DAC_BOFF1                      \ [0x01] DAC channel1 output buffer disable
    $02 constant DAC_TEN1                       \ [0x02] DAC channel1 trigger enable
    $03 constant DAC_TSEL1                      \ [0x03 : 3] DAC channel1 trigger selection
    $06 constant DAC_WAVE1                      \ [0x06 : 2] DAC channel1 noise/triangle wave generation enable
    $08 constant DAC_MAMP1                      \ [0x08 : 4] DAC channel1 mask/amplitude selector
    $0c constant DAC_DMAEN1                     \ [0x0c] DAC channel1 DMA enable
    $0d constant DAC_DMAUDRIE1                  \ [0x0d] DAC channel1 DMA Underrun Interrupt enable
    $10 constant DAC_EN2                        \ [0x10] DAC channel2 enable
    $11 constant DAC_BOFF2                      \ [0x11] DAC channel2 output buffer disable
    $12 constant DAC_TEN2                       \ [0x12] DAC channel2 trigger enable
    $13 constant DAC_TSEL2                      \ [0x13 : 3] DAC channel2 trigger selection
    $16 constant DAC_WAVE2                      \ [0x16 : 2] DAC channel2 noise/triangle wave generation enable
    $18 constant DAC_MAMP2                      \ [0x18 : 4] DAC channel2 mask/amplitude selector
    $1c constant DAC_DMAEN2                     \ [0x1c] DAC channel2 DMA enable
    $1d constant DAC_DMAUDRIE2                  \ [0x1d] DAC channel2 DMA underrun interrupt enable
  [then]


  [ifdef] DAC_SWTRIGR_DEF
    \
    \ @brief software trigger register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant DAC_SWTRIG1                    \ [0x00] DAC channel1 software trigger
    $01 constant DAC_SWTRIG2                    \ [0x01] DAC channel2 software trigger
  [then]


  [ifdef] DAC_DHR12R1_DEF
    \
    \ @brief channel1 12-bit right-aligned data holding register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant DAC_DACC1DHR                   \ [0x00 : 12] DAC channel1 12-bit right-aligned data
  [then]


  [ifdef] DAC_DHR12L1_DEF
    \
    \ @brief channel1 12-bit left aligned data holding register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $04 constant DAC_DACC1DHR                   \ [0x04 : 12] DAC channel1 12-bit left-aligned data
  [then]


  [ifdef] DAC_DHR8R1_DEF
    \
    \ @brief channel1 8-bit right aligned data holding register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant DAC_DACC1DHR                   \ [0x00 : 8] DAC channel1 8-bit right-aligned data
  [then]


  [ifdef] DAC_DHR12R2_DEF
    \
    \ @brief channel2 12-bit right aligned data holding register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant DAC_DACC2DHR                   \ [0x00 : 12] DAC channel2 12-bit right-aligned data
  [then]


  [ifdef] DAC_DHR12L2_DEF
    \
    \ @brief channel2 12-bit left aligned data holding register
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $04 constant DAC_DACC2DHR                   \ [0x04 : 12] DAC channel2 12-bit left-aligned data
  [then]


  [ifdef] DAC_DHR8R2_DEF
    \
    \ @brief channel2 8-bit right-aligned data holding register
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant DAC_DACC2DHR                   \ [0x00 : 8] DAC channel2 8-bit right-aligned data
  [then]


  [ifdef] DAC_DHR12RD_DEF
    \
    \ @brief Dual DAC 12-bit right-aligned data holding register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant DAC_DACC1DHR                   \ [0x00 : 12] DAC channel1 12-bit right-aligned data
    $10 constant DAC_DACC2DHR                   \ [0x10 : 12] DAC channel2 12-bit right-aligned data
  [then]


  [ifdef] DAC_DHR12LD_DEF
    \
    \ @brief DUAL DAC 12-bit left aligned data holding register
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $04 constant DAC_DACC1DHR                   \ [0x04 : 12] DAC channel1 12-bit left-aligned data
    $14 constant DAC_DACC2DHR                   \ [0x14 : 12] DAC channel2 12-bit left-aligned data
  [then]


  [ifdef] DAC_DHR8RD_DEF
    \
    \ @brief DUAL DAC 8-bit right aligned data holding register
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant DAC_DACC1DHR                   \ [0x00 : 8] DAC channel1 8-bit right-aligned data
    $08 constant DAC_DACC2DHR                   \ [0x08 : 8] DAC channel2 8-bit right-aligned data
  [then]


  [ifdef] DAC_DOR1_DEF
    \
    \ @brief channel1 data output register
    \ Address offset: 0x2C
    \ Reset value: 0x00000000
    \
    $00 constant DAC_DACC1DOR                   \ [0x00 : 12] DAC channel1 data output
  [then]


  [ifdef] DAC_DOR2_DEF
    \
    \ @brief channel2 data output register
    \ Address offset: 0x30
    \ Reset value: 0x00000000
    \
    $00 constant DAC_DACC2DOR                   \ [0x00 : 12] DAC channel2 data output
  [then]


  [ifdef] DAC_SR_DEF
    \
    \ @brief status register
    \ Address offset: 0x34
    \ Reset value: 0x00000000
    \
    $0d constant DAC_DMAUDR1                    \ [0x0d] DAC channel1 DMA underrun flag
    $1d constant DAC_DMAUDR2                    \ [0x1d] DAC channel2 DMA underrun flag
  [then]

  \
  \ @brief Digital-to-analog converter
  \
  $00 constant DAC_CR                   \ control register
  $04 constant DAC_SWTRIGR              \ software trigger register
  $08 constant DAC_DHR12R1              \ channel1 12-bit right-aligned data holding register
  $0C constant DAC_DHR12L1              \ channel1 12-bit left aligned data holding register
  $10 constant DAC_DHR8R1               \ channel1 8-bit right aligned data holding register
  $14 constant DAC_DHR12R2              \ channel2 12-bit right aligned data holding register
  $18 constant DAC_DHR12L2              \ channel2 12-bit left aligned data holding register
  $1C constant DAC_DHR8R2               \ channel2 8-bit right-aligned data holding register
  $20 constant DAC_DHR12RD              \ Dual DAC 12-bit right-aligned data holding register
  $24 constant DAC_DHR12LD              \ DUAL DAC 12-bit left aligned data holding register
  $28 constant DAC_DHR8RD               \ DUAL DAC 8-bit right aligned data holding register
  $2C constant DAC_DOR1                 \ channel1 data output register
  $30 constant DAC_DOR2                 \ channel2 data output register
  $34 constant DAC_SR                   \ status register

: DAC_DEF ; [then]
