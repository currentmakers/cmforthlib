\
\ @file adc2.fs
\ @brief Analog to digital converter
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] ADC2_DEF

  [ifdef] ADC2_SR_DEF
    \
    \ @brief status register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant ADC2_AWD                       \ [0x00] Analog watchdog flag
    $01 constant ADC2_EOC                       \ [0x01] Regular channel end of conversion
    $02 constant ADC2_JEOC                      \ [0x02] Injected channel end of conversion
    $03 constant ADC2_JSTRT                     \ [0x03] Injected channel start flag
    $04 constant ADC2_STRT                      \ [0x04] Regular channel start flag
  [then]


  [ifdef] ADC2_CR1_DEF
    \
    \ @brief control register 1
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant ADC2_AWDCH                     \ [0x00 : 5] Analog watchdog channel select bits
    $05 constant ADC2_EOCIE                     \ [0x05] Interrupt enable for EOC
    $06 constant ADC2_AWDIE                     \ [0x06] Analog watchdog interrupt enable
    $07 constant ADC2_JEOCIE                    \ [0x07] Interrupt enable for injected channels
    $08 constant ADC2_SCAN                      \ [0x08] Scan mode
    $09 constant ADC2_AWDSGL                    \ [0x09] Enable the watchdog on a single channel in scan mode
    $0a constant ADC2_JAUTO                     \ [0x0a] Automatic injected group conversion
    $0b constant ADC2_DISCEN                    \ [0x0b] Discontinuous mode on regular channels
    $0c constant ADC2_JDISCEN                   \ [0x0c] Discontinuous mode on injected channels
    $0d constant ADC2_DISCNUM                   \ [0x0d : 3] Discontinuous mode channel count
    $16 constant ADC2_JAWDEN                    \ [0x16] Analog watchdog enable on injected channels
    $17 constant ADC2_AWDEN                     \ [0x17] Analog watchdog enable on regular channels
  [then]


  [ifdef] ADC2_CR2_DEF
    \
    \ @brief control register 2
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant ADC2_ADON                      \ [0x00] A/D converter ON / OFF
    $01 constant ADC2_CONT                      \ [0x01] Continuous conversion
    $02 constant ADC2_CAL                       \ [0x02] A/D calibration
    $03 constant ADC2_RSTCAL                    \ [0x03] Reset calibration
    $08 constant ADC2_DMA                       \ [0x08] Direct memory access mode
    $0b constant ADC2_ALIGN                     \ [0x0b] Data alignment
    $0c constant ADC2_JEXTSEL                   \ [0x0c : 3] External event select for injected group
    $0f constant ADC2_JEXTTRIG                  \ [0x0f] External trigger conversion mode for injected channels
    $11 constant ADC2_EXTSEL                    \ [0x11 : 3] External event select for regular group
    $14 constant ADC2_EXTTRIG                   \ [0x14] External trigger conversion mode for regular channels
    $15 constant ADC2_JSWSTART                  \ [0x15] Start conversion of injected channels
    $16 constant ADC2_SWSTART                   \ [0x16] Start conversion of regular channels
    $17 constant ADC2_TSVREFE                   \ [0x17] Temperature sensor and VREFINT enable
  [then]


  [ifdef] ADC2_SMPR1_DEF
    \
    \ @brief sample time register 1
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant ADC2_SMP10                     \ [0x00 : 3] Channel 10 sample time selection
    $03 constant ADC2_SMP11                     \ [0x03 : 3] Channel 11 sample time selection
    $06 constant ADC2_SMP12                     \ [0x06 : 3] Channel 12 sample time selection
    $09 constant ADC2_SMP13                     \ [0x09 : 3] Channel 13 sample time selection
    $0c constant ADC2_SMP14                     \ [0x0c : 3] Channel 14 sample time selection
    $0f constant ADC2_SMP15                     \ [0x0f : 3] Channel 15 sample time selection
    $12 constant ADC2_SMP16                     \ [0x12 : 3] Channel 16 sample time selection
    $15 constant ADC2_SMP17                     \ [0x15 : 3] Channel 17 sample time selection
  [then]


  [ifdef] ADC2_SMPR2_DEF
    \
    \ @brief sample time register 2
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant ADC2_SMP0                      \ [0x00 : 3] Channel 0 sample time selection
    $03 constant ADC2_SMP1                      \ [0x03 : 3] Channel 1 sample time selection
    $06 constant ADC2_SMP2                      \ [0x06 : 3] Channel 2 sample time selection
    $09 constant ADC2_SMP3                      \ [0x09 : 3] Channel 3 sample time selection
    $0c constant ADC2_SMP4                      \ [0x0c : 3] Channel 4 sample time selection
    $0f constant ADC2_SMP5                      \ [0x0f : 3] Channel 5 sample time selection
    $12 constant ADC2_SMP6                      \ [0x12 : 3] Channel 6 sample time selection
    $15 constant ADC2_SMP7                      \ [0x15 : 3] Channel 7 sample time selection
    $18 constant ADC2_SMP8                      \ [0x18 : 3] Channel 8 sample time selection
    $1b constant ADC2_SMP9                      \ [0x1b : 3] Channel 9 sample time selection
  [then]


  [ifdef] ADC2_JOFR1_DEF
    \
    \ @brief injected channel data offset register x
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant ADC2_JOFFSET1                  \ [0x00 : 12] Data offset for injected channel 1
  [then]


  [ifdef] ADC2_JOFR2_DEF
    \
    \ @brief injected channel data offset register x
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant ADC2_JOFFSET2                  \ [0x00 : 12] Data offset for injected channel 2
  [then]


  [ifdef] ADC2_JOFR3_DEF
    \
    \ @brief injected channel data offset register x
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant ADC2_JOFFSET3                  \ [0x00 : 12] Data offset for injected channel 3
  [then]


  [ifdef] ADC2_JOFR4_DEF
    \
    \ @brief injected channel data offset register x
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant ADC2_JOFFSET4                  \ [0x00 : 12] Data offset for injected channel 4
  [then]


  [ifdef] ADC2_HTR_DEF
    \
    \ @brief watchdog higher threshold register
    \ Address offset: 0x24
    \ Reset value: 0x00000FFF
    \
    $00 constant ADC2_HT                        \ [0x00 : 12] Analog watchdog higher threshold
  [then]


  [ifdef] ADC2_LTR_DEF
    \
    \ @brief watchdog lower threshold register
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant ADC2_LT                        \ [0x00 : 12] Analog watchdog lower threshold
  [then]


  [ifdef] ADC2_SQR1_DEF
    \
    \ @brief regular sequence register 1
    \ Address offset: 0x2C
    \ Reset value: 0x00000000
    \
    $00 constant ADC2_SQ13                      \ [0x00 : 5] 13th conversion in regular sequence
    $05 constant ADC2_SQ14                      \ [0x05 : 5] 14th conversion in regular sequence
    $0a constant ADC2_SQ15                      \ [0x0a : 5] 15th conversion in regular sequence
    $0f constant ADC2_SQ16                      \ [0x0f : 5] 16th conversion in regular sequence
    $14 constant ADC2_L                         \ [0x14 : 4] Regular channel sequence length
  [then]


  [ifdef] ADC2_SQR2_DEF
    \
    \ @brief regular sequence register 2
    \ Address offset: 0x30
    \ Reset value: 0x00000000
    \
    $00 constant ADC2_SQ7                       \ [0x00 : 5] 7th conversion in regular sequence
    $05 constant ADC2_SQ8                       \ [0x05 : 5] 8th conversion in regular sequence
    $0a constant ADC2_SQ9                       \ [0x0a : 5] 9th conversion in regular sequence
    $0f constant ADC2_SQ10                      \ [0x0f : 5] 10th conversion in regular sequence
    $14 constant ADC2_SQ11                      \ [0x14 : 5] 11th conversion in regular sequence
    $19 constant ADC2_SQ12                      \ [0x19 : 5] 12th conversion in regular sequence
  [then]


  [ifdef] ADC2_SQR3_DEF
    \
    \ @brief regular sequence register 3
    \ Address offset: 0x34
    \ Reset value: 0x00000000
    \
    $00 constant ADC2_SQ1                       \ [0x00 : 5] 1st conversion in regular sequence
    $05 constant ADC2_SQ2                       \ [0x05 : 5] 2nd conversion in regular sequence
    $0a constant ADC2_SQ3                       \ [0x0a : 5] 3rd conversion in regular sequence
    $0f constant ADC2_SQ4                       \ [0x0f : 5] 4th conversion in regular sequence
    $14 constant ADC2_SQ5                       \ [0x14 : 5] 5th conversion in regular sequence
    $19 constant ADC2_SQ6                       \ [0x19 : 5] 6th conversion in regular sequence
  [then]


  [ifdef] ADC2_JSQR_DEF
    \
    \ @brief injected sequence register
    \ Address offset: 0x38
    \ Reset value: 0x00000000
    \
    $00 constant ADC2_JSQ1                      \ [0x00 : 5] 1st conversion in injected sequence
    $05 constant ADC2_JSQ2                      \ [0x05 : 5] 2nd conversion in injected sequence
    $0a constant ADC2_JSQ3                      \ [0x0a : 5] 3rd conversion in injected sequence
    $0f constant ADC2_JSQ4                      \ [0x0f : 5] 4th conversion in injected sequence
    $14 constant ADC2_JL                        \ [0x14 : 2] Injected sequence length
  [then]


  [ifdef] ADC2_JDR1_DEF
    \
    \ @brief injected data register x
    \ Address offset: 0x3C
    \ Reset value: 0x00000000
    \
    $00 constant ADC2_JDATA                     \ [0x00 : 16] Injected data
  [then]


  [ifdef] ADC2_JDR2_DEF
    \
    \ @brief injected data register x
    \ Address offset: 0x40
    \ Reset value: 0x00000000
    \
    $00 constant ADC2_JDATA                     \ [0x00 : 16] Injected data
  [then]


  [ifdef] ADC2_JDR3_DEF
    \
    \ @brief injected data register x
    \ Address offset: 0x44
    \ Reset value: 0x00000000
    \
    $00 constant ADC2_JDATA                     \ [0x00 : 16] Injected data
  [then]


  [ifdef] ADC2_JDR4_DEF
    \
    \ @brief injected data register x
    \ Address offset: 0x48
    \ Reset value: 0x00000000
    \
    $00 constant ADC2_JDATA                     \ [0x00 : 16] Injected data
  [then]


  [ifdef] ADC2_DR_DEF
    \
    \ @brief regular data register
    \ Address offset: 0x4C
    \ Reset value: 0x00000000
    \
    $00 constant ADC2_DATA                      \ [0x00 : 16] Regular data
  [then]

  \
  \ @brief Analog to digital converter
  \
  $00 constant ADC2_SR                  \ status register
  $04 constant ADC2_CR1                 \ control register 1
  $08 constant ADC2_CR2                 \ control register 2
  $0C constant ADC2_SMPR1               \ sample time register 1
  $10 constant ADC2_SMPR2               \ sample time register 2
  $14 constant ADC2_JOFR1               \ injected channel data offset register x
  $18 constant ADC2_JOFR2               \ injected channel data offset register x
  $1C constant ADC2_JOFR3               \ injected channel data offset register x
  $20 constant ADC2_JOFR4               \ injected channel data offset register x
  $24 constant ADC2_HTR                 \ watchdog higher threshold register
  $28 constant ADC2_LTR                 \ watchdog lower threshold register
  $2C constant ADC2_SQR1                \ regular sequence register 1
  $30 constant ADC2_SQR2                \ regular sequence register 2
  $34 constant ADC2_SQR3                \ regular sequence register 3
  $38 constant ADC2_JSQR                \ injected sequence register
  $3C constant ADC2_JDR1                \ injected data register x
  $40 constant ADC2_JDR2                \ injected data register x
  $44 constant ADC2_JDR3                \ injected data register x
  $48 constant ADC2_JDR4                \ injected data register x
  $4C constant ADC2_DR                  \ regular data register

: ADC2_DEF ; [then]
