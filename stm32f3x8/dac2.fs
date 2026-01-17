\
\ @file dac2.fs
\ @brief Digital-to-analog converter
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] DAC2_DEF

  [ifdef] DAC2_CR_DEF
    \
    \ @brief control register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant DAC2_EN1                       \ [0x00] DAC channel1 enable
    $01 constant DAC2_BOFF1                     \ [0x01] DAC channel1 output buffer disable
    $02 constant DAC2_TEN1                      \ [0x02] DAC channel1 trigger enable
    $03 constant DAC2_TSEL1                     \ [0x03 : 3] DAC channel1 trigger selection
    $06 constant DAC2_WAVE2                     \ [0x06] WAVE2
    $07 constant DAC2_WAVE1                     \ [0x07] DAC channel1 noise/triangle wave generation enable
    $08 constant DAC2_MAMP10                    \ [0x08] MAMP10
    $09 constant DAC2_MAMP11                    \ [0x09] MAMP11
    $0a constant DAC2_MAMP12                    \ [0x0a] MAMP12
    $0b constant DAC2_MAMP13                    \ [0x0b] DAC channel1 mask/amplitude selector
    $0c constant DAC2_DMAEN1                    \ [0x0c] DAC channel1 DMA enable
    $0d constant DAC2_DMAUDRIE1                 \ [0x0d] DAC channel1 DMA Underrun Interrupt enable
  [then]


  [ifdef] DAC2_SWTRIGR_DEF
    \
    \ @brief software trigger register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant DAC2_SWTRIG1                   \ [0x00] DAC channel1 software trigger
  [then]


  [ifdef] DAC2_DHR12R1_DEF
    \
    \ @brief channel1 12-bit right-aligned data holding register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant DAC2_DACC1DHR                  \ [0x00 : 12] DAC channel1 12-bit right-aligned data
  [then]


  [ifdef] DAC2_DHR12L1_DEF
    \
    \ @brief DAC channel1 12-bit left aligned data holding register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $04 constant DAC2_DACC1DHR                  \ [0x04 : 12] DAC channel1 12-bit left-aligned data
  [then]


  [ifdef] DAC2_DHR8R1_DEF
    \
    \ @brief DAC channel1 8-bit right aligned data holding register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant DAC2_DACC1DHR                  \ [0x00 : 8] DAC channel1 8-bit right-aligned data
  [then]


  [ifdef] DAC2_DOR1_DEF
    \
    \ @brief DAC channel1 data output register
    \ Address offset: 0x2C
    \ Reset value: 0x00000000
    \
    $00 constant DAC2_DACC1DOR                  \ [0x00 : 12] DAC channel1 data output
  [then]


  [ifdef] DAC2_SR_DEF
    \
    \ @brief DAC status register
    \ Address offset: 0x34
    \ Reset value: 0x00000000
    \
    $0d constant DAC2_DMAUDR1                   \ [0x0d] DAC channel1 DMA underrun flag
  [then]

  \
  \ @brief Digital-to-analog converter
  \
  $00 constant DAC2_CR                  \ control register
  $04 constant DAC2_SWTRIGR             \ software trigger register
  $08 constant DAC2_DHR12R1             \ channel1 12-bit right-aligned data holding register
  $0C constant DAC2_DHR12L1             \ DAC channel1 12-bit left aligned data holding register
  $10 constant DAC2_DHR8R1              \ DAC channel1 8-bit right aligned data holding register
  $2C constant DAC2_DOR1                \ DAC channel1 data output register
  $34 constant DAC2_SR                  \ DAC status register

: DAC2_DEF ; [then]
