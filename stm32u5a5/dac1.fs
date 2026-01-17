\
\ @file dac1.fs
\ @brief Digital-to-analog converter
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] DAC1_DEF

  [ifdef] DAC1_DAC_CR_DEF
    \
    \ @brief DAC control register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant DAC1_EN1                       \ [0x00] DAC channel1 enable
    $01 constant DAC1_TEN1                      \ [0x01] DAC channel1 trigger enable
    $02 constant DAC1_TSEL1                     \ [0x02 : 4] DAC channel1 trigger selection
    $06 constant DAC1_WAVE1                     \ [0x06 : 2] DAC channel1 noise/triangle wave generation enable
    $08 constant DAC1_MAMP1                     \ [0x08 : 4] DAC channel1 mask/amplitude selector
    $0c constant DAC1_DMAEN1                    \ [0x0c] DAC channel1 DMA enable
    $0d constant DAC1_DMAUDRIE1                 \ [0x0d] DAC channel1 DMA Underrun Interrupt enable
    $0e constant DAC1_CEN1                      \ [0x0e] DAC channel1 calibration enable
    $10 constant DAC1_EN2                       \ [0x10] DAC channel2 enable
    $11 constant DAC1_TEN2                      \ [0x11] DAC channel2 trigger enable
    $12 constant DAC1_TSEL2                     \ [0x12 : 4] DAC channel2 trigger selection
    $16 constant DAC1_WAVE2                     \ [0x16 : 2] DAC channel2 noise/triangle wave generation enable
    $18 constant DAC1_MAMP2                     \ [0x18 : 4] DAC channel2 mask/amplitude selector
    $1c constant DAC1_DMAEN2                    \ [0x1c] DAC channel2 DMA enable
    $1d constant DAC1_DMAUDRIE2                 \ [0x1d] DAC channel2 DMA underrun interrupt enable
    $1e constant DAC1_CEN2                      \ [0x1e] DAC channel2 calibration enable
  [then]


  [ifdef] DAC1_DAC_SWTRGR_DEF
    \
    \ @brief DAC software trigger register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant DAC1_SWTRIG1                   \ [0x00] DAC channel1 software trigger
    $01 constant DAC1_SWTRIG2                   \ [0x01] DAC channel2 software trigger
  [then]


  [ifdef] DAC1_DAC_DHR12R1_DEF
    \
    \ @brief DAC channel1 12-bit right-aligned data holding register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant DAC1_DACC1DHR                  \ [0x00 : 12] DAC channel1 12-bit right-aligned data
    $10 constant DAC1_DACC1DHRB                 \ [0x10 : 12] DAC channel1 12-bit right-aligned data B
  [then]


  [ifdef] DAC1_DAC_DHR12L1_DEF
    \
    \ @brief DAC channel1 12-bit left aligned data holding register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $04 constant DAC1_DACC1DHR                  \ [0x04 : 12] DAC channel1 12-bit left-aligned data
    $14 constant DAC1_DACC1DHRB                 \ [0x14 : 12] DAC channel1 12-bit left-aligned data B
  [then]


  [ifdef] DAC1_DAC_DHR8R1_DEF
    \
    \ @brief DAC channel1 8-bit right aligned data holding register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant DAC1_DACC1DHR                  \ [0x00 : 8] DAC channel1 8-bit right-aligned data
    $08 constant DAC1_DACC1DHRB                 \ [0x08 : 8] DAC channel1 8-bit right-aligned Sdata
  [then]


  [ifdef] DAC1_DAC_DHR12R2_DEF
    \
    \ @brief DAC channel2 12-bit right aligned data holding register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant DAC1_DACC2DHR                  \ [0x00 : 12] DAC channel2 12-bit right-aligned data
    $10 constant DAC1_DACC2DHRB                 \ [0x10 : 12] DAC channel2 12-bit right-aligned data
  [then]


  [ifdef] DAC1_DAC_DHR12L2_DEF
    \
    \ @brief DAC channel2 12-bit left aligned data holding register
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $04 constant DAC1_DACC2DHR                  \ [0x04 : 12] DAC channel2 12-bit left-aligned data
    $14 constant DAC1_DACC2DHRB                 \ [0x14 : 12] DAC channel2 12-bit left-aligned data B
  [then]


  [ifdef] DAC1_DAC_DHR8R2_DEF
    \
    \ @brief DAC channel2 8-bit right-aligned data holding register
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant DAC1_DACC2DHR                  \ [0x00 : 8] DAC channel2 8-bit right-aligned data
    $08 constant DAC1_DACC2DHRB                 \ [0x08 : 8] DAC channel2 8-bit right-aligned data
  [then]


  [ifdef] DAC1_DAC_DHR12RD_DEF
    \
    \ @brief Dual DAC 12-bit right-aligned data holding register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant DAC1_DACC1DHR                  \ [0x00 : 12] DAC channel1 12-bit right-aligned data
    $10 constant DAC1_DACC2DHR                  \ [0x10 : 12] DAC channel2 12-bit right-aligned data
  [then]


  [ifdef] DAC1_DAC_DHR12LD_DEF
    \
    \ @brief DUAL DAC 12-bit left aligned data holding register
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $04 constant DAC1_DACC1DHR                  \ [0x04 : 12] DAC channel1 12-bit left-aligned data
    $14 constant DAC1_DACC2DHR                  \ [0x14 : 12] DAC channel2 12-bit left-aligned data
  [then]


  [ifdef] DAC1_DAC_DHR8RD_DEF
    \
    \ @brief DUAL DAC 8-bit right aligned data holding register
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant DAC1_DACC1DHR                  \ [0x00 : 8] DAC channel1 8-bit right-aligned data
    $08 constant DAC1_DACC2DHR                  \ [0x08 : 8] DAC channel2 8-bit right-aligned data
  [then]


  [ifdef] DAC1_DAC_DOR1_DEF
    \
    \ @brief DAC channel1 data output register
    \ Address offset: 0x2C
    \ Reset value: 0x00000000
    \
    $00 constant DAC1_DACC1DOR                  \ [0x00 : 12] DAC channel1 data output
    $10 constant DAC1_DACC1DORB                 \ [0x10 : 12] DAC channel1 data output
  [then]


  [ifdef] DAC1_DAC_DOR2_DEF
    \
    \ @brief DAC channel2 data output register
    \ Address offset: 0x30
    \ Reset value: 0x00000000
    \
    $00 constant DAC1_DACC2DOR                  \ [0x00 : 12] DAC channel2 data output
    $10 constant DAC1_DACC2DORB                 \ [0x10 : 12] DAC channel2 data output
  [then]


  [ifdef] DAC1_DAC_SR_DEF
    \
    \ @brief DAC status register
    \ Address offset: 0x34
    \ Reset value: 0x00000000
    \
    $0b constant DAC1_DAC1RDY                   \ [0x0b] DAC channel1 ready status bit
    $0c constant DAC1_DORSTAT1                  \ [0x0c] DAC channel1 output register status bit
    $0d constant DAC1_DMAUDR1                   \ [0x0d] DAC channel1 DMA underrun flag
    $0e constant DAC1_CAL_FLAG1                 \ [0x0e] DAC Channel 1 calibration offset status
    $0f constant DAC1_BWST1                     \ [0x0f] DAC Channel 1 busy writing sample time flag
    $1b constant DAC1_DAC2RDY                   \ [0x1b] DAC channel 2 ready status bit
    $1c constant DAC1_DORSTAT2                  \ [0x1c] DAC channel 2 output register status bit
    $1d constant DAC1_DMAUDR2                   \ [0x1d] DAC channel2 DMA underrun flag
    $1e constant DAC1_CAL_FLAG2                 \ [0x1e] DAC Channel 2 calibration offset status
    $1f constant DAC1_BWST2                     \ [0x1f] DAC Channel 2 busy writing sample time flag
  [then]


  [ifdef] DAC1_DAC_CCR_DEF
    \
    \ @brief DAC calibration control register
    \ Address offset: 0x38
    \ Reset value: 0x00000000
    \
    $00 constant DAC1_OTRIM1                    \ [0x00 : 5] DAC Channel 1 offset trimming value
    $10 constant DAC1_OTRIM2                    \ [0x10 : 5] DAC Channel 2 offset trimming value
  [then]


  [ifdef] DAC1_DAC_MCR_DEF
    \
    \ @brief DAC mode control register
    \ Address offset: 0x3C
    \ Reset value: 0x00000000
    \
    $00 constant DAC1_MODE1                     \ [0x00 : 3] DAC Channel 1 mode
    $08 constant DAC1_DMADOUBLE1                \ [0x08] DAC Channel1 DMA double data mode
    $09 constant DAC1_SINFORMAT1                \ [0x09] Enable signed format for DAC channel1
    $0e constant DAC1_HFSEL                     \ [0x0e : 2] High frequency interface mode selection
    $10 constant DAC1_MODE2                     \ [0x10 : 3] DAC Channel 2 mode
    $18 constant DAC1_DMADOUBLE2                \ [0x18] DAC Channel2 DMA double data mode
    $19 constant DAC1_SINFORMAT2                \ [0x19] Enable signed format for DAC channel2
  [then]


  [ifdef] DAC1_DAC_SHSR1_DEF
    \
    \ @brief DAC Sample and Hold sample time register 1
    \ Address offset: 0x40
    \ Reset value: 0x00000000
    \
    $00 constant DAC1_TSAMPLE1                  \ [0x00 : 10] DAC Channel 1 sample Time (only valid in sample &amp; hold mode)
  [then]


  [ifdef] DAC1_DAC_SHSR2_DEF
    \
    \ @brief DAC channel2 sample and hold sample time register
    \ Address offset: 0x44
    \ Reset value: 0x00000000
    \
    $00 constant DAC1_TSAMPLE2                  \ [0x00 : 10] DAC Channel 2 sample Time (only valid in sample and hold mode)
  [then]


  [ifdef] DAC1_DAC_SHHR_DEF
    \
    \ @brief DAC Sample and Hold hold time register
    \ Address offset: 0x48
    \ Reset value: 0x00010001
    \
    $00 constant DAC1_THOLD1                    \ [0x00 : 10] DAC Channel 1 hold Time (only valid in sample and hold mode)
    $10 constant DAC1_THOLD2                    \ [0x10 : 10] DAC Channel 2 hold time (only valid in sample and hold mode)
  [then]


  [ifdef] DAC1_DAC_SHRR_DEF
    \
    \ @brief DAC Sample and Hold refresh time register
    \ Address offset: 0x4C
    \ Reset value: 0x00010001
    \
    $00 constant DAC1_TREFRESH1                 \ [0x00 : 8] DAC Channel 1 refresh Time (only valid in sample and hold mode)
    $10 constant DAC1_TREFRESH2                 \ [0x10 : 8] DAC Channel 2 refresh Time (only valid in sample and hold mode)
  [then]


  [ifdef] DAC1_DAC_AUTOCR_DEF
    \
    \ @brief Autonomous mode control register
    \ Address offset: 0x54
    \ Reset value: 0x00000000
    \
    $16 constant DAC1_AUTOMODE                  \ [0x16] DAC Autonomous mode
  [then]

  \
  \ @brief Digital-to-analog converter
  \
  $00 constant DAC1_DAC_CR              \ DAC control register
  $04 constant DAC1_DAC_SWTRGR          \ DAC software trigger register
  $08 constant DAC1_DAC_DHR12R1         \ DAC channel1 12-bit right-aligned data holding register
  $0C constant DAC1_DAC_DHR12L1         \ DAC channel1 12-bit left aligned data holding register
  $10 constant DAC1_DAC_DHR8R1          \ DAC channel1 8-bit right aligned data holding register
  $14 constant DAC1_DAC_DHR12R2         \ DAC channel2 12-bit right aligned data holding register
  $18 constant DAC1_DAC_DHR12L2         \ DAC channel2 12-bit left aligned data holding register
  $1C constant DAC1_DAC_DHR8R2          \ DAC channel2 8-bit right-aligned data holding register
  $20 constant DAC1_DAC_DHR12RD         \ Dual DAC 12-bit right-aligned data holding register
  $24 constant DAC1_DAC_DHR12LD         \ DUAL DAC 12-bit left aligned data holding register
  $28 constant DAC1_DAC_DHR8RD          \ DUAL DAC 8-bit right aligned data holding register
  $2C constant DAC1_DAC_DOR1            \ DAC channel1 data output register
  $30 constant DAC1_DAC_DOR2            \ DAC channel2 data output register
  $34 constant DAC1_DAC_SR              \ DAC status register
  $38 constant DAC1_DAC_CCR             \ DAC calibration control register
  $3C constant DAC1_DAC_MCR             \ DAC mode control register
  $40 constant DAC1_DAC_SHSR1           \ DAC Sample and Hold sample time register 1
  $44 constant DAC1_DAC_SHSR2           \ DAC channel2 sample and hold sample time register
  $48 constant DAC1_DAC_SHHR            \ DAC Sample and Hold hold time register
  $4C constant DAC1_DAC_SHRR            \ DAC Sample and Hold refresh time register
  $54 constant DAC1_DAC_AUTOCR          \ Autonomous mode control register

: DAC1_DEF ; [then]
