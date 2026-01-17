\
\ @file adc3.fs
\ @brief Analog to digital converter
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] ADC3_DEF

  [ifdef] ADC3_SR_DEF
    \
    \ @brief status register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant ADC3_AWD                       \ [0x00] Analog watchdog flag
    $01 constant ADC3_EOC                       \ [0x01] Regular channel end of conversion
    $02 constant ADC3_JEOC                      \ [0x02] Injected channel end of conversion
    $03 constant ADC3_JSTRT                     \ [0x03] Injected channel start flag
    $04 constant ADC3_STRT                      \ [0x04] Regular channel start flag
  [then]


  [ifdef] ADC3_CR1_DEF
    \
    \ @brief control register 1
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant ADC3_AWDCH                     \ [0x00 : 5] Analog watchdog channel select bits
    $05 constant ADC3_EOCIE                     \ [0x05] Interrupt enable for EOC
    $06 constant ADC3_AWDIE                     \ [0x06] Analog watchdog interrupt enable
    $07 constant ADC3_JEOCIE                    \ [0x07] Interrupt enable for injected channels
    $08 constant ADC3_SCAN                      \ [0x08] Scan mode
    $09 constant ADC3_AWDSGL                    \ [0x09] Enable the watchdog on a single channel in scan mode
    $0a constant ADC3_JAUTO                     \ [0x0a] Automatic injected group conversion
    $0b constant ADC3_DISCEN                    \ [0x0b] Discontinuous mode on regular channels
    $0c constant ADC3_JDISCEN                   \ [0x0c] Discontinuous mode on injected channels
    $0d constant ADC3_DISCNUM                   \ [0x0d : 3] Discontinuous mode channel count
    $10 constant ADC3_DUALMOD                   \ [0x10 : 4] Dual mode selection
    $16 constant ADC3_JAWDEN                    \ [0x16] Analog watchdog enable on injected channels
    $17 constant ADC3_AWDEN                     \ [0x17] Analog watchdog enable on regular channels
  [then]


  [ifdef] ADC3_CR2_DEF
    \
    \ @brief control register 2
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant ADC3_ADON                      \ [0x00] A/D converter ON / OFF
    $01 constant ADC3_CONT                      \ [0x01] Continuous conversion
    $02 constant ADC3_CAL                       \ [0x02] A/D calibration
    $03 constant ADC3_RSTCAL                    \ [0x03] Reset calibration
    $08 constant ADC3_DMA                       \ [0x08] Direct memory access mode
    $0b constant ADC3_ALIGN                     \ [0x0b] Data alignment
    $0c constant ADC3_JEXTSEL                   \ [0x0c : 3] External event select for injected group
    $0f constant ADC3_JEXTTRIG                  \ [0x0f] External trigger conversion mode for injected channels
    $11 constant ADC3_EXTSEL                    \ [0x11 : 3] External event select for regular group
    $14 constant ADC3_EXTTRIG                   \ [0x14] External trigger conversion mode for regular channels
    $15 constant ADC3_JSWSTART                  \ [0x15] Start conversion of injected channels
    $16 constant ADC3_SWSTART                   \ [0x16] Start conversion of regular channels
    $17 constant ADC3_TSVREFE                   \ [0x17] Temperature sensor and VREFINT enable
  [then]


  [ifdef] ADC3_SMPR1_DEF
    \
    \ @brief sample time register 1
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant ADC3_SMPx_x                    \ [0x00 : 32] Sample time bits
  [then]


  [ifdef] ADC3_SMPR2_DEF
    \
    \ @brief sample time register 2
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant ADC3_SMPx_x                    \ [0x00 : 32] Sample time bits
  [then]


  [ifdef] ADC3_JOFR1_DEF
    \
    \ @brief injected channel data offset register x
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant ADC3_JOFFSET1                  \ [0x00 : 12] Data offset for injected channel x
  [then]


  [ifdef] ADC3_JOFR2_DEF
    \
    \ @brief injected channel data offset register x
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant ADC3_JOFFSET2                  \ [0x00 : 12] Data offset for injected channel x
  [then]


  [ifdef] ADC3_JOFR3_DEF
    \
    \ @brief injected channel data offset register x
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant ADC3_JOFFSET3                  \ [0x00 : 12] Data offset for injected channel x
  [then]


  [ifdef] ADC3_JOFR4_DEF
    \
    \ @brief injected channel data offset register x
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant ADC3_JOFFSET4                  \ [0x00 : 12] Data offset for injected channel x
  [then]


  [ifdef] ADC3_HTR_DEF
    \
    \ @brief watchdog higher threshold register
    \ Address offset: 0x24
    \ Reset value: 0x00000FFF
    \
    $00 constant ADC3_HT                        \ [0x00 : 12] Analog watchdog higher threshold
  [then]


  [ifdef] ADC3_LTR_DEF
    \
    \ @brief watchdog lower threshold register
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant ADC3_LT                        \ [0x00 : 12] Analog watchdog lower threshold
  [then]


  [ifdef] ADC3_SQR1_DEF
    \
    \ @brief regular sequence register 1
    \ Address offset: 0x2C
    \ Reset value: 0x00000000
    \
    $00 constant ADC3_SQ13                      \ [0x00 : 5] 13th conversion in regular sequence
    $05 constant ADC3_SQ14                      \ [0x05 : 5] 14th conversion in regular sequence
    $0a constant ADC3_SQ15                      \ [0x0a : 5] 15th conversion in regular sequence
    $0f constant ADC3_SQ16                      \ [0x0f : 5] 16th conversion in regular sequence
    $14 constant ADC3_L                         \ [0x14 : 4] Regular channel sequence length
  [then]


  [ifdef] ADC3_SQR2_DEF
    \
    \ @brief regular sequence register 2
    \ Address offset: 0x30
    \ Reset value: 0x00000000
    \
    $00 constant ADC3_SQ7                       \ [0x00 : 5] 7th conversion in regular sequence
    $05 constant ADC3_SQ8                       \ [0x05 : 5] 8th conversion in regular sequence
    $0a constant ADC3_SQ9                       \ [0x0a : 5] 9th conversion in regular sequence
    $0f constant ADC3_SQ10                      \ [0x0f : 5] 10th conversion in regular sequence
    $14 constant ADC3_SQ11                      \ [0x14 : 5] 11th conversion in regular sequence
    $19 constant ADC3_SQ12                      \ [0x19 : 5] 12th conversion in regular sequence
  [then]


  [ifdef] ADC3_SQR3_DEF
    \
    \ @brief regular sequence register 3
    \ Address offset: 0x34
    \ Reset value: 0x00000000
    \
    $00 constant ADC3_SQ1                       \ [0x00 : 5] 1st conversion in regular sequence
    $05 constant ADC3_SQ2                       \ [0x05 : 5] 2nd conversion in regular sequence
    $0a constant ADC3_SQ3                       \ [0x0a : 5] 3rd conversion in regular sequence
    $0f constant ADC3_SQ4                       \ [0x0f : 5] 4th conversion in regular sequence
    $14 constant ADC3_SQ5                       \ [0x14 : 5] 5th conversion in regular sequence
    $19 constant ADC3_SQ6                       \ [0x19 : 5] 6th conversion in regular sequence
  [then]


  [ifdef] ADC3_JSQR_DEF
    \
    \ @brief injected sequence register
    \ Address offset: 0x38
    \ Reset value: 0x00000000
    \
    $00 constant ADC3_JSQ1                      \ [0x00 : 5] 1st conversion in injected sequence
    $05 constant ADC3_JSQ2                      \ [0x05 : 5] 2nd conversion in injected sequence
    $0a constant ADC3_JSQ3                      \ [0x0a : 5] 3rd conversion in injected sequence
    $0f constant ADC3_JSQ4                      \ [0x0f : 5] 4th conversion in injected sequence
    $14 constant ADC3_JL                        \ [0x14 : 2] Injected sequence length
  [then]


  [ifdef] ADC3_JDR1_DEF
    \
    \ @brief injected data register x
    \ Address offset: 0x3C
    \ Reset value: 0x00000000
    \
    $00 constant ADC3_JDATA                     \ [0x00 : 16] Injected data
  [then]


  [ifdef] ADC3_JDR2_DEF
    \
    \ @brief injected data register x
    \ Address offset: 0x40
    \ Reset value: 0x00000000
    \
    $00 constant ADC3_JDATA                     \ [0x00 : 16] Injected data
  [then]


  [ifdef] ADC3_JDR3_DEF
    \
    \ @brief injected data register x
    \ Address offset: 0x44
    \ Reset value: 0x00000000
    \
    $00 constant ADC3_JDATA                     \ [0x00 : 16] Injected data
  [then]


  [ifdef] ADC3_JDR4_DEF
    \
    \ @brief injected data register x
    \ Address offset: 0x48
    \ Reset value: 0x00000000
    \
    $00 constant ADC3_JDATA                     \ [0x00 : 16] Injected data
  [then]


  [ifdef] ADC3_DR_DEF
    \
    \ @brief regular data register
    \ Address offset: 0x4C
    \ Reset value: 0x00000000
    \
    $00 constant ADC3_DATA                      \ [0x00 : 16] Regular data
  [then]

  \
  \ @brief Analog to digital converter
  \
  $00 constant ADC3_SR                  \ status register
  $04 constant ADC3_CR1                 \ control register 1
  $08 constant ADC3_CR2                 \ control register 2
  $0C constant ADC3_SMPR1               \ sample time register 1
  $10 constant ADC3_SMPR2               \ sample time register 2
  $14 constant ADC3_JOFR1               \ injected channel data offset register x
  $18 constant ADC3_JOFR2               \ injected channel data offset register x
  $1C constant ADC3_JOFR3               \ injected channel data offset register x
  $20 constant ADC3_JOFR4               \ injected channel data offset register x
  $24 constant ADC3_HTR                 \ watchdog higher threshold register
  $28 constant ADC3_LTR                 \ watchdog lower threshold register
  $2C constant ADC3_SQR1                \ regular sequence register 1
  $30 constant ADC3_SQR2                \ regular sequence register 2
  $34 constant ADC3_SQR3                \ regular sequence register 3
  $38 constant ADC3_JSQR                \ injected sequence register
  $3C constant ADC3_JDR1                \ injected data register x
  $40 constant ADC3_JDR2                \ injected data register x
  $44 constant ADC3_JDR3                \ injected data register x
  $48 constant ADC3_JDR4                \ injected data register x
  $4C constant ADC3_DR                  \ regular data register

: ADC3_DEF ; [then]
