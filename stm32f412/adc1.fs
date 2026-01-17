\
\ @file adc1.fs
\ @brief Analog-to-digital converter
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] ADC1_DEF

  [ifdef] ADC1_SR_DEF
    \
    \ @brief status register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant ADC1_AWD                       \ [0x00] Analog watchdog flag
    $01 constant ADC1_EOC                       \ [0x01] Regular channel end of conversion
    $02 constant ADC1_JEOC                      \ [0x02] Injected channel end of conversion
    $03 constant ADC1_JSTRT                     \ [0x03] Injected channel start flag
    $04 constant ADC1_STRT                      \ [0x04] Regular channel start flag
    $05 constant ADC1_OVR                       \ [0x05] Overrun
  [then]


  [ifdef] ADC1_CR1_DEF
    \
    \ @brief control register 1
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant ADC1_AWDCH                     \ [0x00 : 5] Analog watchdog channel select bits
    $05 constant ADC1_EOCIE                     \ [0x05] Interrupt enable for EOC
    $06 constant ADC1_AWDIE                     \ [0x06] Analog watchdog interrupt enable
    $07 constant ADC1_JEOCIE                    \ [0x07] Interrupt enable for injected channels
    $08 constant ADC1_SCAN                      \ [0x08] Scan mode
    $09 constant ADC1_AWDSGL                    \ [0x09] Enable the watchdog on a single channel in scan mode
    $0a constant ADC1_JAUTO                     \ [0x0a] Automatic injected group conversion
    $0b constant ADC1_DISCEN                    \ [0x0b] Discontinuous mode on regular channels
    $0c constant ADC1_JDISCEN                   \ [0x0c] Discontinuous mode on injected channels
    $0d constant ADC1_DISCNUM                   \ [0x0d : 3] Discontinuous mode channel count
    $16 constant ADC1_JAWDEN                    \ [0x16] Analog watchdog enable on injected channels
    $17 constant ADC1_AWDEN                     \ [0x17] Analog watchdog enable on regular channels
    $18 constant ADC1_RES                       \ [0x18 : 2] Resolution
    $1a constant ADC1_OVRIE                     \ [0x1a] Overrun interrupt enable
  [then]


  [ifdef] ADC1_CR2_DEF
    \
    \ @brief control register 2
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant ADC1_ADON                      \ [0x00] A/D Converter ON / OFF
    $01 constant ADC1_CONT                      \ [0x01] Continuous conversion
    $08 constant ADC1_DMA                       \ [0x08] Direct memory access mode (for single ADC mode)
    $09 constant ADC1_DDS                       \ [0x09] DMA disable selection (for single ADC mode)
    $0a constant ADC1_EOCS                      \ [0x0a] End of conversion selection
    $0b constant ADC1_ALIGN                     \ [0x0b] Data alignment
    $10 constant ADC1_JEXTSEL                   \ [0x10 : 4] External event select for injected group
    $14 constant ADC1_JEXTEN                    \ [0x14 : 2] External trigger enable for injected channels
    $16 constant ADC1_JSWSTART                  \ [0x16] Start conversion of injected channels
    $18 constant ADC1_EXTSEL                    \ [0x18 : 4] External event select for regular group
    $1c constant ADC1_EXTEN                     \ [0x1c : 2] External trigger enable for regular channels
    $1e constant ADC1_SWSTART                   \ [0x1e] Start conversion of regular channels
  [then]


  [ifdef] ADC1_SMPR1_DEF
    \
    \ @brief sample time register 1
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant ADC1_SMPx_x                    \ [0x00 : 32] Sample time bits
  [then]


  [ifdef] ADC1_SMPR2_DEF
    \
    \ @brief sample time register 2
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant ADC1_SMPx_x                    \ [0x00 : 32] Sample time bits
  [then]


  [ifdef] ADC1_JOFR1_DEF
    \
    \ @brief injected channel data offset register x
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant ADC1_JOFFSET1                  \ [0x00 : 12] Data offset for injected channel x
  [then]


  [ifdef] ADC1_JOFR2_DEF
    \
    \ @brief injected channel data offset register x
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant ADC1_JOFFSET2                  \ [0x00 : 12] Data offset for injected channel x
  [then]


  [ifdef] ADC1_JOFR3_DEF
    \
    \ @brief injected channel data offset register x
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant ADC1_JOFFSET3                  \ [0x00 : 12] Data offset for injected channel x
  [then]


  [ifdef] ADC1_JOFR4_DEF
    \
    \ @brief injected channel data offset register x
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant ADC1_JOFFSET4                  \ [0x00 : 12] Data offset for injected channel x
  [then]


  [ifdef] ADC1_HTR_DEF
    \
    \ @brief watchdog higher threshold register
    \ Address offset: 0x24
    \ Reset value: 0x00000FFF
    \
    $00 constant ADC1_HT                        \ [0x00 : 12] Analog watchdog higher threshold
  [then]


  [ifdef] ADC1_LTR_DEF
    \
    \ @brief watchdog lower threshold register
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant ADC1_LT                        \ [0x00 : 12] Analog watchdog lower threshold
  [then]


  [ifdef] ADC1_SQR1_DEF
    \
    \ @brief regular sequence register 1
    \ Address offset: 0x2C
    \ Reset value: 0x00000000
    \
    $00 constant ADC1_SQ13                      \ [0x00 : 5] 13th conversion in regular sequence
    $05 constant ADC1_SQ14                      \ [0x05 : 5] 14th conversion in regular sequence
    $0a constant ADC1_SQ15                      \ [0x0a : 5] 15th conversion in regular sequence
    $0f constant ADC1_SQ16                      \ [0x0f : 5] 16th conversion in regular sequence
    $14 constant ADC1_L                         \ [0x14 : 4] Regular channel sequence length
  [then]


  [ifdef] ADC1_SQR2_DEF
    \
    \ @brief regular sequence register 2
    \ Address offset: 0x30
    \ Reset value: 0x00000000
    \
    $00 constant ADC1_SQ7                       \ [0x00 : 5] 7th conversion in regular sequence
    $05 constant ADC1_SQ8                       \ [0x05 : 5] 8th conversion in regular sequence
    $0a constant ADC1_SQ9                       \ [0x0a : 5] 9th conversion in regular sequence
    $0f constant ADC1_SQ10                      \ [0x0f : 5] 10th conversion in regular sequence
    $14 constant ADC1_SQ11                      \ [0x14 : 5] 11th conversion in regular sequence
    $19 constant ADC1_SQ12                      \ [0x19 : 5] 12th conversion in regular sequence
  [then]


  [ifdef] ADC1_SQR3_DEF
    \
    \ @brief regular sequence register 3
    \ Address offset: 0x34
    \ Reset value: 0x00000000
    \
    $00 constant ADC1_SQ1                       \ [0x00 : 5] 1st conversion in regular sequence
    $05 constant ADC1_SQ2                       \ [0x05 : 5] 2nd conversion in regular sequence
    $0a constant ADC1_SQ3                       \ [0x0a : 5] 3rd conversion in regular sequence
    $0f constant ADC1_SQ4                       \ [0x0f : 5] 4th conversion in regular sequence
    $14 constant ADC1_SQ5                       \ [0x14 : 5] 5th conversion in regular sequence
    $19 constant ADC1_SQ6                       \ [0x19 : 5] 6th conversion in regular sequence
  [then]


  [ifdef] ADC1_JSQR_DEF
    \
    \ @brief injected sequence register
    \ Address offset: 0x38
    \ Reset value: 0x00000000
    \
    $00 constant ADC1_JSQ1                      \ [0x00 : 5] 1st conversion in injected sequence
    $05 constant ADC1_JSQ2                      \ [0x05 : 5] 2nd conversion in injected sequence
    $0a constant ADC1_JSQ3                      \ [0x0a : 5] 3rd conversion in injected sequence
    $0f constant ADC1_JSQ4                      \ [0x0f : 5] 4th conversion in injected sequence
    $14 constant ADC1_JL                        \ [0x14 : 2] Injected sequence length
  [then]


  [ifdef] ADC1_JDR1_DEF
    \
    \ @brief injected data register x
    \ Address offset: 0x3C
    \ Reset value: 0x00000000
    \
    $00 constant ADC1_JDATA                     \ [0x00 : 16] Injected data
  [then]


  [ifdef] ADC1_JDR2_DEF
    \
    \ @brief injected data register x
    \ Address offset: 0x40
    \ Reset value: 0x00000000
    \
    $00 constant ADC1_JDATA                     \ [0x00 : 16] Injected data
  [then]


  [ifdef] ADC1_JDR3_DEF
    \
    \ @brief injected data register x
    \ Address offset: 0x44
    \ Reset value: 0x00000000
    \
    $00 constant ADC1_JDATA                     \ [0x00 : 16] Injected data
  [then]


  [ifdef] ADC1_JDR4_DEF
    \
    \ @brief injected data register x
    \ Address offset: 0x48
    \ Reset value: 0x00000000
    \
    $00 constant ADC1_JDATA                     \ [0x00 : 16] Injected data
  [then]


  [ifdef] ADC1_DR_DEF
    \
    \ @brief regular data register
    \ Address offset: 0x4C
    \ Reset value: 0x00000000
    \
    $00 constant ADC1_DATA                      \ [0x00 : 16] Regular data
  [then]

  \
  \ @brief Analog-to-digital converter
  \
  $00 constant ADC1_SR                  \ status register
  $04 constant ADC1_CR1                 \ control register 1
  $08 constant ADC1_CR2                 \ control register 2
  $0C constant ADC1_SMPR1               \ sample time register 1
  $10 constant ADC1_SMPR2               \ sample time register 2
  $14 constant ADC1_JOFR1               \ injected channel data offset register x
  $18 constant ADC1_JOFR2               \ injected channel data offset register x
  $1C constant ADC1_JOFR3               \ injected channel data offset register x
  $20 constant ADC1_JOFR4               \ injected channel data offset register x
  $24 constant ADC1_HTR                 \ watchdog higher threshold register
  $28 constant ADC1_LTR                 \ watchdog lower threshold register
  $2C constant ADC1_SQR1                \ regular sequence register 1
  $30 constant ADC1_SQR2                \ regular sequence register 2
  $34 constant ADC1_SQR3                \ regular sequence register 3
  $38 constant ADC1_JSQR                \ injected sequence register
  $3C constant ADC1_JDR1                \ injected data register x
  $40 constant ADC1_JDR2                \ injected data register x
  $44 constant ADC1_JDR3                \ injected data register x
  $48 constant ADC1_JDR4                \ injected data register x
  $4C constant ADC1_DR                  \ regular data register

: ADC1_DEF ; [then]
