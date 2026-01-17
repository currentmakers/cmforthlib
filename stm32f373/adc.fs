\
\ @file adc.fs
\ @brief Analog to digital converter
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] ADC_DEF

  [ifdef] ADC_SR_DEF
    \
    \ @brief status register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant ADC_AWD                        \ [0x00] Analog watchdog flag
    $01 constant ADC_EOC                        \ [0x01] Regular channel end of conversion
    $02 constant ADC_JEOC                       \ [0x02] Injected channel end of conversion
    $03 constant ADC_JSTRT                      \ [0x03] Injected channel start flag
    $04 constant ADC_STRT                       \ [0x04] Regular channel start flag
  [then]


  [ifdef] ADC_CR1_DEF
    \
    \ @brief control register 1
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant ADC_AWDCH                      \ [0x00 : 5] Analog watchdog channel select bits
    $05 constant ADC_EOCIE                      \ [0x05] Interrupt enable for EOC
    $06 constant ADC_AWDIE                      \ [0x06] Analog watchdog interrupt enable
    $07 constant ADC_JEOCIE                     \ [0x07] Interrupt enable for injected channels
    $08 constant ADC_SCAN                       \ [0x08] Scan mode
    $09 constant ADC_AWDSGL                     \ [0x09] Enable the watchdog on a single channel in scan mode
    $0a constant ADC_JAUTO                      \ [0x0a] Automatic injected group conversion
    $0b constant ADC_DISCEN                     \ [0x0b] Discontinuous mode on regular channels
    $0c constant ADC_JDISCEN                    \ [0x0c] Discontinuous mode on injected channels
    $0d constant ADC_DISCNUM                    \ [0x0d : 3] Discontinuous mode channel count
    $16 constant ADC_JAWDEN                     \ [0x16] Analog watchdog enable on injected channels
    $17 constant ADC_AWDEN                      \ [0x17] Analog watchdog enable on regular channels
  [then]


  [ifdef] ADC_CR2_DEF
    \
    \ @brief control register 2
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant ADC_ADON                       \ [0x00] A/D converter ON / OFF
    $01 constant ADC_CONT                       \ [0x01] Continuous conversion
    $02 constant ADC_CAL                        \ [0x02] A/D calibration
    $03 constant ADC_RSTCAL                     \ [0x03] Reset calibration
    $08 constant ADC_DMA                        \ [0x08] Direct memory access mode
    $0b constant ADC_ALIGN                      \ [0x0b] Data alignment
    $0c constant ADC_JEXTSEL                    \ [0x0c : 3] External event select for injected group
    $0f constant ADC_JEXTTRIG                   \ [0x0f] External trigger conversion mode for injected channels
    $11 constant ADC_EXTSEL                     \ [0x11 : 3] External event select for regular group
    $14 constant ADC_EXTTRIG                    \ [0x14] External trigger conversion mode for regular channels
    $15 constant ADC_JSWSTART                   \ [0x15] Start conversion of injected channels
    $16 constant ADC_SWSTART                    \ [0x16] Start conversion of regular channels
    $17 constant ADC_TSVREFE                    \ [0x17] Temperature sensor and VREFINT enable
  [then]


  [ifdef] ADC_SMPR1_DEF
    \
    \ @brief sample time register 1
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant ADC_SMP10                      \ [0x00 : 3] Channel 10 sampling time selection
    $03 constant ADC_SMP11                      \ [0x03 : 3] Channel 11 sampling time selection
    $06 constant ADC_SMP12                      \ [0x06 : 3] Channel 12 sampling time selection
    $09 constant ADC_SMP13                      \ [0x09 : 3] Channel 13 sampling time selection
    $0c constant ADC_SMP14                      \ [0x0c : 3] Channel 14 sampling time selection
    $0f constant ADC_SMP15                      \ [0x0f : 3] Channel 15 sampling time selection
    $12 constant ADC_SMP16                      \ [0x12 : 3] Channel 16 sampling time selection
    $15 constant ADC_SMP17                      \ [0x15 : 3] Channel 17 sampling time selection
  [then]


  [ifdef] ADC_SMPR2_DEF
    \
    \ @brief sample time register 2
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant ADC_SMP0                       \ [0x00 : 3] Channel 0 sampling time selection
    $03 constant ADC_SMP1                       \ [0x03 : 3] Channel 1 sampling time selection
    $06 constant ADC_SMP2                       \ [0x06 : 3] Channel 2 sampling time selection
    $09 constant ADC_SMP3                       \ [0x09 : 3] Channel 3 sampling time selection
    $0c constant ADC_SMP4                       \ [0x0c : 3] Channel 4 sampling time selection
    $0f constant ADC_SMP5                       \ [0x0f : 3] Channel 5 sampling time selection
    $12 constant ADC_SMP6                       \ [0x12 : 3] Channel 6 sampling time selection
    $15 constant ADC_SMP7                       \ [0x15 : 3] Channel 7 sampling time selection
    $18 constant ADC_SMP8                       \ [0x18 : 3] Channel 8 sampling time selection
    $1b constant ADC_SMP9                       \ [0x1b : 3] Channel 9 sampling time selection
  [then]


  [ifdef] ADC_JOFR1_DEF
    \
    \ @brief injected channel data offset register x
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant ADC_JOFFSET1                   \ [0x00 : 12] Data offset for injected channel x
  [then]


  [ifdef] ADC_JOFR2_DEF
    \
    \ @brief injected channel data offset register x
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant ADC_JOFFSET2                   \ [0x00 : 12] Data offset for injected channel x
  [then]


  [ifdef] ADC_JOFR3_DEF
    \
    \ @brief injected channel data offset register x
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant ADC_JOFFSET3                   \ [0x00 : 12] Data offset for injected channel x
  [then]


  [ifdef] ADC_JOFR4_DEF
    \
    \ @brief injected channel data offset register x
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant ADC_JOFFSET4                   \ [0x00 : 12] Data offset for injected channel x
  [then]


  [ifdef] ADC_HTR_DEF
    \
    \ @brief watchdog higher threshold register
    \ Address offset: 0x24
    \ Reset value: 0x00000FFF
    \
    $00 constant ADC_HT                         \ [0x00 : 12] Analog watchdog higher threshold
  [then]


  [ifdef] ADC_LTR_DEF
    \
    \ @brief watchdog lower threshold register
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant ADC_LT                         \ [0x00 : 12] Analog watchdog lower threshold
  [then]


  [ifdef] ADC_SQR1_DEF
    \
    \ @brief regular sequence register 1
    \ Address offset: 0x2C
    \ Reset value: 0x00000000
    \
    $00 constant ADC_SQ13                       \ [0x00 : 5] 13th conversion in regular sequence
    $05 constant ADC_SQ14                       \ [0x05 : 5] 14th conversion in regular sequence
    $0a constant ADC_SQ15                       \ [0x0a : 5] 15th conversion in regular sequence
    $0f constant ADC_SQ16                       \ [0x0f : 5] 16th conversion in regular sequence
    $14 constant ADC_L                          \ [0x14 : 4] Regular channel sequence length
  [then]


  [ifdef] ADC_SQR2_DEF
    \
    \ @brief regular sequence register 2
    \ Address offset: 0x30
    \ Reset value: 0x00000000
    \
    $00 constant ADC_SQ7                        \ [0x00 : 5] 7th conversion in regular sequence
    $05 constant ADC_SQ8                        \ [0x05 : 5] 8th conversion in regular sequence
    $0a constant ADC_SQ9                        \ [0x0a : 5] 9th conversion in regular sequence
    $0f constant ADC_SQ10                       \ [0x0f : 5] 10th conversion in regular sequence
    $14 constant ADC_SQ11                       \ [0x14 : 5] 11th conversion in regular sequence
    $19 constant ADC_SQ12                       \ [0x19 : 5] 12th conversion in regular sequence
  [then]


  [ifdef] ADC_SQR3_DEF
    \
    \ @brief regular sequence register 3
    \ Address offset: 0x34
    \ Reset value: 0x00000000
    \
    $00 constant ADC_SQ1                        \ [0x00 : 5] 1st conversion in regular sequence
    $05 constant ADC_SQ2                        \ [0x05 : 5] 2nd conversion in regular sequence
    $0a constant ADC_SQ3                        \ [0x0a : 5] 3rd conversion in regular sequence
    $0f constant ADC_SQ4                        \ [0x0f : 5] 4th conversion in regular sequence
    $14 constant ADC_SQ5                        \ [0x14 : 5] 5th conversion in regular sequence
    $19 constant ADC_SQ6                        \ [0x19 : 5] 6th conversion in regular sequence
  [then]


  [ifdef] ADC_JSQR_DEF
    \
    \ @brief injected sequence register
    \ Address offset: 0x38
    \ Reset value: 0x00000000
    \
    $00 constant ADC_JSQ1                       \ [0x00 : 5] 1st conversion in injected sequence
    $05 constant ADC_JSQ2                       \ [0x05 : 5] 2nd conversion in injected sequence
    $0a constant ADC_JSQ3                       \ [0x0a : 5] 3rd conversion in injected sequence
    $0f constant ADC_JSQ4                       \ [0x0f : 5] 4th conversion in injected sequence
    $14 constant ADC_JL                         \ [0x14 : 2] Injected sequence length
  [then]


  [ifdef] ADC_JDR1_DEF
    \
    \ @brief injected data register x
    \ Address offset: 0x3C
    \ Reset value: 0x00000000
    \
    $00 constant ADC_JDATA                      \ [0x00 : 16] Injected data
  [then]


  [ifdef] ADC_JDR2_DEF
    \
    \ @brief injected data register x
    \ Address offset: 0x40
    \ Reset value: 0x00000000
    \
    $00 constant ADC_JDATA                      \ [0x00 : 16] Injected data
  [then]


  [ifdef] ADC_JDR3_DEF
    \
    \ @brief injected data register x
    \ Address offset: 0x44
    \ Reset value: 0x00000000
    \
    $00 constant ADC_JDATA                      \ [0x00 : 16] Injected data
  [then]


  [ifdef] ADC_JDR4_DEF
    \
    \ @brief injected data register x
    \ Address offset: 0x48
    \ Reset value: 0x00000000
    \
    $00 constant ADC_JDATA                      \ [0x00 : 16] Injected data
  [then]


  [ifdef] ADC_DR_DEF
    \
    \ @brief regular data register
    \ Address offset: 0x4C
    \ Reset value: 0x00000000
    \
    $00 constant ADC_DATA                       \ [0x00 : 16] Regular data
  [then]

  \
  \ @brief Analog to digital converter
  \
  $00 constant ADC_SR                   \ status register
  $04 constant ADC_CR1                  \ control register 1
  $08 constant ADC_CR2                  \ control register 2
  $0C constant ADC_SMPR1                \ sample time register 1
  $10 constant ADC_SMPR2                \ sample time register 2
  $14 constant ADC_JOFR1                \ injected channel data offset register x
  $18 constant ADC_JOFR2                \ injected channel data offset register x
  $1C constant ADC_JOFR3                \ injected channel data offset register x
  $20 constant ADC_JOFR4                \ injected channel data offset register x
  $24 constant ADC_HTR                  \ watchdog higher threshold register
  $28 constant ADC_LTR                  \ watchdog lower threshold register
  $2C constant ADC_SQR1                 \ regular sequence register 1
  $30 constant ADC_SQR2                 \ regular sequence register 2
  $34 constant ADC_SQR3                 \ regular sequence register 3
  $38 constant ADC_JSQR                 \ injected sequence register
  $3C constant ADC_JDR1                 \ injected data register x
  $40 constant ADC_JDR2                 \ injected data register x
  $44 constant ADC_JDR3                 \ injected data register x
  $48 constant ADC_JDR4                 \ injected data register x
  $4C constant ADC_DR                   \ regular data register

: ADC_DEF ; [then]
