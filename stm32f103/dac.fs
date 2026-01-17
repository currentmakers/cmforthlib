\
\ @file dac.fs
\ @brief Digital to analog converter
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] DAC_DEF

  [ifdef] DAC_CR_DEF
    \
    \ @brief Control register (DAC_CR)
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
    $10 constant DAC_EN2                        \ [0x10] DAC channel2 enable
    $11 constant DAC_BOFF2                      \ [0x11] DAC channel2 output buffer disable
    $12 constant DAC_TEN2                       \ [0x12] DAC channel2 trigger enable
    $13 constant DAC_TSEL2                      \ [0x13 : 3] DAC channel2 trigger selection
    $16 constant DAC_WAVE2                      \ [0x16 : 2] DAC channel2 noise/triangle wave generation enable
    $18 constant DAC_MAMP2                      \ [0x18 : 4] DAC channel2 mask/amplitude selector
    $1c constant DAC_DMAEN2                     \ [0x1c] DAC channel2 DMA enable
  [then]


  [ifdef] DAC_SWTRIGR_DEF
    \
    \ @brief DAC software trigger register (DAC_SWTRIGR)
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant DAC_SWTRIG1                    \ [0x00] DAC channel1 software trigger
    $01 constant DAC_SWTRIG2                    \ [0x01] DAC channel2 software trigger
  [then]


  [ifdef] DAC_DHR12R1_DEF
    \
    \ @brief DAC channel1 12-bit right-aligned data holding register(DAC_DHR12R1)
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant DAC_DACC1DHR                   \ [0x00 : 12] DAC channel1 12-bit right-aligned data
  [then]


  [ifdef] DAC_DHR12L1_DEF
    \
    \ @brief DAC channel1 12-bit left aligned data holding register (DAC_DHR12L1)
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $04 constant DAC_DACC1DHR                   \ [0x04 : 12] DAC channel1 12-bit left-aligned data
  [then]


  [ifdef] DAC_DHR8R1_DEF
    \
    \ @brief DAC channel1 8-bit right aligned data holding register (DAC_DHR8R1)
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant DAC_DACC1DHR                   \ [0x00 : 8] DAC channel1 8-bit right-aligned data
  [then]


  [ifdef] DAC_DHR12R2_DEF
    \
    \ @brief DAC channel2 12-bit right aligned data holding register (DAC_DHR12R2)
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant DAC_DACC2DHR                   \ [0x00 : 12] DAC channel2 12-bit right-aligned data
  [then]


  [ifdef] DAC_DHR12L2_DEF
    \
    \ @brief DAC channel2 12-bit left aligned data holding register (DAC_DHR12L2)
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $04 constant DAC_DACC2DHR                   \ [0x04 : 12] DAC channel2 12-bit left-aligned data
  [then]


  [ifdef] DAC_DHR8R2_DEF
    \
    \ @brief DAC channel2 8-bit right-aligned data holding register (DAC_DHR8R2)
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant DAC_DACC2DHR                   \ [0x00 : 8] DAC channel2 8-bit right-aligned data
  [then]


  [ifdef] DAC_DHR12RD_DEF
    \
    \ @brief Dual DAC 12-bit right-aligned data holding register (DAC_DHR12RD), Bits 31:28 Reserved, Bits 15:12 Reserved
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant DAC_DACC1DHR                   \ [0x00 : 12] DAC channel1 12-bit right-aligned data
    $10 constant DAC_DACC2DHR                   \ [0x10 : 12] DAC channel2 12-bit right-aligned data
  [then]


  [ifdef] DAC_DHR12LD_DEF
    \
    \ @brief DUAL DAC 12-bit left aligned data holding register (DAC_DHR12LD), Bits 19:16 Reserved, Bits 3:0 Reserved
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $04 constant DAC_DACC1DHR                   \ [0x04 : 12] DAC channel1 12-bit left-aligned data
    $14 constant DAC_DACC2DHR                   \ [0x14 : 12] DAC channel2 12-bit right-aligned data
  [then]


  [ifdef] DAC_DHR8RD_DEF
    \
    \ @brief DUAL DAC 8-bit right aligned data holding register (DAC_DHR8RD), Bits 31:16 Reserved
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant DAC_DACC1DHR                   \ [0x00 : 8] DAC channel1 8-bit right-aligned data
    $08 constant DAC_DACC2DHR                   \ [0x08 : 8] DAC channel2 8-bit right-aligned data
  [then]


  [ifdef] DAC_DOR1_DEF
    \
    \ @brief DAC channel1 data output register (DAC_DOR1)
    \ Address offset: 0x2C
    \ Reset value: 0x00000000
    \
    $00 constant DAC_DACC1DOR                   \ [0x00 : 12] DAC channel1 data output
  [then]


  [ifdef] DAC_DOR2_DEF
    \
    \ @brief DAC channel2 data output register (DAC_DOR2)
    \ Address offset: 0x30
    \ Reset value: 0x00000000
    \
    $00 constant DAC_DACC2DOR                   \ [0x00 : 12] DAC channel2 data output
  [then]

  \
  \ @brief Digital to analog converter
  \
  $00 constant DAC_CR                   \ Control register (DAC_CR)
  $04 constant DAC_SWTRIGR              \ DAC software trigger register (DAC_SWTRIGR)
  $08 constant DAC_DHR12R1              \ DAC channel1 12-bit right-aligned data holding register(DAC_DHR12R1)
  $0C constant DAC_DHR12L1              \ DAC channel1 12-bit left aligned data holding register (DAC_DHR12L1)
  $10 constant DAC_DHR8R1               \ DAC channel1 8-bit right aligned data holding register (DAC_DHR8R1)
  $14 constant DAC_DHR12R2              \ DAC channel2 12-bit right aligned data holding register (DAC_DHR12R2)
  $18 constant DAC_DHR12L2              \ DAC channel2 12-bit left aligned data holding register (DAC_DHR12L2)
  $1C constant DAC_DHR8R2               \ DAC channel2 8-bit right-aligned data holding register (DAC_DHR8R2)
  $20 constant DAC_DHR12RD              \ Dual DAC 12-bit right-aligned data holding register (DAC_DHR12RD), Bits 31:28 Reserved, Bits 15:12 Reserved
  $24 constant DAC_DHR12LD              \ DUAL DAC 12-bit left aligned data holding register (DAC_DHR12LD), Bits 19:16 Reserved, Bits 3:0 Reserved
  $28 constant DAC_DHR8RD               \ DUAL DAC 8-bit right aligned data holding register (DAC_DHR8RD), Bits 31:16 Reserved
  $2C constant DAC_DOR1                 \ DAC channel1 data output register (DAC_DOR1)
  $30 constant DAC_DOR2                 \ DAC channel2 data output register (DAC_DOR2)

: DAC_DEF ; [then]
