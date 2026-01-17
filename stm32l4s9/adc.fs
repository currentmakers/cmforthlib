\
\ @file adc.fs
\ @brief Analog-to-Digital Converter
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] ADC_DEF

  [ifdef] ADC_ISR_DEF
    \
    \ @brief interrupt and status register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant ADC_ADRDY                      \ [0x00] ADRDY
    $01 constant ADC_EOSMP                      \ [0x01] EOSMP
    $02 constant ADC_EOC                        \ [0x02] EOC
    $03 constant ADC_EOS                        \ [0x03] EOS
    $04 constant ADC_OVR                        \ [0x04] OVR
    $05 constant ADC_JEOC                       \ [0x05] JEOC
    $06 constant ADC_JEOS                       \ [0x06] JEOS
    $07 constant ADC_AWD1                       \ [0x07] AWD1
    $08 constant ADC_AWD2                       \ [0x08] AWD2
    $09 constant ADC_AWD3                       \ [0x09] AWD3
    $0a constant ADC_JQOVF                      \ [0x0a] JQOVF
  [then]


  [ifdef] ADC_IER_DEF
    \
    \ @brief interrupt enable register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant ADC_ADRDYIE                    \ [0x00] ADRDYIE
    $01 constant ADC_EOSMPIE                    \ [0x01] EOSMPIE
    $02 constant ADC_EOCIE                      \ [0x02] EOCIE
    $03 constant ADC_EOSIE                      \ [0x03] EOSIE
    $04 constant ADC_OVRIE                      \ [0x04] OVRIE
    $05 constant ADC_JEOCIE                     \ [0x05] JEOCIE
    $06 constant ADC_JEOSIE                     \ [0x06] JEOSIE
    $07 constant ADC_AWD1IE                     \ [0x07] AWD1IE
    $08 constant ADC_AWD2IE                     \ [0x08] AWD2IE
    $09 constant ADC_AWD3IE                     \ [0x09] AWD3IE
    $0a constant ADC_JQOVFIE                    \ [0x0a] JQOVFIE
  [then]


  [ifdef] ADC_CR_DEF
    \
    \ @brief control register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant ADC_ADEN                       \ [0x00] ADEN
    $01 constant ADC_ADDIS                      \ [0x01] ADDIS
    $02 constant ADC_ADSTART                    \ [0x02] ADSTART
    $03 constant ADC_JADSTART                   \ [0x03] JADSTART
    $04 constant ADC_ADSTP                      \ [0x04] ADSTP
    $05 constant ADC_JADSTP                     \ [0x05] JADSTP
    $1c constant ADC_ADVREGEN                   \ [0x1c] ADVREGEN
    $1d constant ADC_DEEPPWD                    \ [0x1d] DEEPPWD
    $1e constant ADC_ADCALDIF                   \ [0x1e] ADCALDIF
    $1f constant ADC_ADCAL                      \ [0x1f] ADCAL
  [then]


  [ifdef] ADC_CFGR_DEF
    \
    \ @brief configuration register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant ADC_DMAEN                      \ [0x00] DMAEN
    $01 constant ADC_DMACFG                     \ [0x01] DMACFG
    $03 constant ADC_RES                        \ [0x03 : 2] RES
    $05 constant ADC_ALIGN                      \ [0x05] ALIGN
    $06 constant ADC_EXTSEL                     \ [0x06 : 4] EXTSEL
    $0a constant ADC_EXTEN                      \ [0x0a : 2] EXTEN
    $0c constant ADC_OVRMOD                     \ [0x0c] OVRMOD
    $0d constant ADC_CONT                       \ [0x0d] CONT
    $0e constant ADC_AUTDLY                     \ [0x0e] AUTDLY
    $10 constant ADC_DISCEN                     \ [0x10] DISCEN
    $11 constant ADC_DISCNUM                    \ [0x11 : 3] DISCNUM
    $14 constant ADC_JDISCEN                    \ [0x14] JDISCEN
    $15 constant ADC_JQM                        \ [0x15] JQM
    $16 constant ADC_AWD1SGL                    \ [0x16] AWD1SGL
    $17 constant ADC_AWD1EN                     \ [0x17] AWD1EN
    $18 constant ADC_JAWD1EN                    \ [0x18] JAWD1EN
    $19 constant ADC_JAUTO                      \ [0x19] JAUTO
    $1a constant ADC_AWDCH1CH                   \ [0x1a : 5] AWDCH1CH
    $1f constant ADC_JQDIS                      \ [0x1f] Injected Queue disable
  [then]


  [ifdef] ADC_CFGR2_DEF
    \
    \ @brief configuration register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant ADC_ROVSE                      \ [0x00] DMAEN
    $01 constant ADC_JOVSE                      \ [0x01] DMACFG
    $02 constant ADC_OVSR                       \ [0x02 : 3] RES
    $05 constant ADC_OVSS                       \ [0x05 : 4] ALIGN
    $09 constant ADC_TROVS                      \ [0x09] Triggered Regular Oversampling
    $0a constant ADC_ROVSM                      \ [0x0a] EXTEN
  [then]


  [ifdef] ADC_SMPR1_DEF
    \
    \ @brief sample time register 1
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant ADC_SMP0                       \ [0x00 : 3] SMP0
    $03 constant ADC_SMP1                       \ [0x03 : 3] SMP1
    $06 constant ADC_SMP2                       \ [0x06 : 3] SMP2
    $09 constant ADC_SMP3                       \ [0x09 : 3] SMP3
    $0c constant ADC_SMP4                       \ [0x0c : 3] SMP4
    $0f constant ADC_SMP5                       \ [0x0f : 3] SMP5
    $12 constant ADC_SMP6                       \ [0x12 : 3] SMP6
    $15 constant ADC_SMP7                       \ [0x15 : 3] SMP7
    $18 constant ADC_SMP8                       \ [0x18 : 3] SMP8
    $1b constant ADC_SMP9                       \ [0x1b : 3] SMP9
    $1f constant ADC_SMPPLUS                    \ [0x1f] Addition of one clock cycle to the sampling time
  [then]


  [ifdef] ADC_SMPR2_DEF
    \
    \ @brief sample time register 2
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant ADC_SMP10                      \ [0x00 : 3] SMP10
    $03 constant ADC_SMP11                      \ [0x03 : 3] SMP11
    $06 constant ADC_SMP12                      \ [0x06 : 3] SMP12
    $09 constant ADC_SMP13                      \ [0x09 : 3] SMP13
    $0c constant ADC_SMP14                      \ [0x0c : 3] SMP14
    $0f constant ADC_SMP15                      \ [0x0f : 3] SMP15
    $12 constant ADC_SMP16                      \ [0x12 : 3] SMP16
    $15 constant ADC_SMP17                      \ [0x15 : 3] SMP17
    $18 constant ADC_SMP18                      \ [0x18 : 3] SMP18
  [then]


  [ifdef] ADC_TR1_DEF
    \
    \ @brief watchdog threshold register 1
    \ Address offset: 0x20
    \ Reset value: 0x0FFF0000
    \
    $00 constant ADC_LT1                        \ [0x00 : 12] LT1
    $10 constant ADC_HT1                        \ [0x10 : 12] HT1
  [then]


  [ifdef] ADC_TR2_DEF
    \
    \ @brief watchdog threshold register
    \ Address offset: 0x24
    \ Reset value: 0x0FFF0000
    \
    $00 constant ADC_LT2                        \ [0x00 : 8] LT2
    $10 constant ADC_HT2                        \ [0x10 : 8] HT2
  [then]


  [ifdef] ADC_TR3_DEF
    \
    \ @brief watchdog threshold register 3
    \ Address offset: 0x28
    \ Reset value: 0x0FFF0000
    \
    $00 constant ADC_LT3                        \ [0x00 : 8] LT3
    $10 constant ADC_HT3                        \ [0x10 : 8] HT3
  [then]


  [ifdef] ADC_SQR1_DEF
    \
    \ @brief regular sequence register 1
    \ Address offset: 0x30
    \ Reset value: 0x00000000
    \
    $00 constant ADC_L                          \ [0x00 : 4] Regular channel sequence length
    $06 constant ADC_SQ1                        \ [0x06 : 5] SQ1
    $0c constant ADC_SQ2                        \ [0x0c : 5] SQ2
    $12 constant ADC_SQ3                        \ [0x12 : 5] SQ3
    $18 constant ADC_SQ4                        \ [0x18 : 5] SQ4
  [then]


  [ifdef] ADC_SQR2_DEF
    \
    \ @brief regular sequence register 2
    \ Address offset: 0x34
    \ Reset value: 0x00000000
    \
    $00 constant ADC_SQ5                        \ [0x00 : 5] SQ5
    $06 constant ADC_SQ6                        \ [0x06 : 5] SQ6
    $0c constant ADC_SQ7                        \ [0x0c : 5] SQ7
    $12 constant ADC_SQ8                        \ [0x12 : 5] SQ8
    $18 constant ADC_SQ9                        \ [0x18 : 5] SQ9
  [then]


  [ifdef] ADC_SQR3_DEF
    \
    \ @brief regular sequence register 3
    \ Address offset: 0x38
    \ Reset value: 0x00000000
    \
    $00 constant ADC_SQ10                       \ [0x00 : 5] SQ10
    $06 constant ADC_SQ11                       \ [0x06 : 5] SQ11
    $0c constant ADC_SQ12                       \ [0x0c : 5] SQ12
    $12 constant ADC_SQ13                       \ [0x12 : 5] SQ13
    $18 constant ADC_SQ14                       \ [0x18 : 5] SQ14
  [then]


  [ifdef] ADC_SQR4_DEF
    \
    \ @brief regular sequence register 4
    \ Address offset: 0x3C
    \ Reset value: 0x00000000
    \
    $00 constant ADC_SQ15                       \ [0x00 : 5] SQ15
    $06 constant ADC_SQ16                       \ [0x06 : 5] SQ16
  [then]


  [ifdef] ADC_DR_DEF
    \
    \ @brief regular Data Register
    \ Address offset: 0x40
    \ Reset value: 0x00000000
    \
    $00 constant ADC_RDATA                      \ [0x00 : 16] Regular Data converted
  [then]


  [ifdef] ADC_JSQR_DEF
    \
    \ @brief injected sequence register
    \ Address offset: 0x4C
    \ Reset value: 0x00000000
    \
    $00 constant ADC_JL                         \ [0x00 : 2] JL
    $02 constant ADC_JEXTSEL                    \ [0x02 : 4] JEXTSEL
    $06 constant ADC_JEXTEN                     \ [0x06 : 2] JEXTEN
    $08 constant ADC_JSQ1                       \ [0x08 : 5] JSQ1
    $0e constant ADC_JSQ2                       \ [0x0e : 5] JSQ2
    $14 constant ADC_JSQ3                       \ [0x14 : 5] JSQ3
    $1a constant ADC_JSQ4                       \ [0x1a : 5] JSQ4
  [then]


  [ifdef] ADC_OFR1_DEF
    \
    \ @brief offset register 1
    \ Address offset: 0x60
    \ Reset value: 0x00000000
    \
    $00 constant ADC_OFFSET1                    \ [0x00 : 12] OFFSET1
    $1a constant ADC_OFFSET1_CH                 \ [0x1a : 5] OFFSET1_CH
    $1f constant ADC_OFFSET1_EN                 \ [0x1f] OFFSET1_EN
  [then]


  [ifdef] ADC_OFR2_DEF
    \
    \ @brief offset register 2
    \ Address offset: 0x64
    \ Reset value: 0x00000000
    \
    $00 constant ADC_OFFSET2                    \ [0x00 : 12] OFFSET2
    $1a constant ADC_OFFSET2_CH                 \ [0x1a : 5] OFFSET2_CH
    $1f constant ADC_OFFSET2_EN                 \ [0x1f] OFFSET2_EN
  [then]


  [ifdef] ADC_OFR3_DEF
    \
    \ @brief offset register 3
    \ Address offset: 0x68
    \ Reset value: 0x00000000
    \
    $00 constant ADC_OFFSET3                    \ [0x00 : 12] OFFSET3
    $1a constant ADC_OFFSET3_CH                 \ [0x1a : 5] OFFSET3_CH
    $1f constant ADC_OFFSET3_EN                 \ [0x1f] OFFSET3_EN
  [then]


  [ifdef] ADC_OFR4_DEF
    \
    \ @brief offset register 4
    \ Address offset: 0x6C
    \ Reset value: 0x00000000
    \
    $00 constant ADC_OFFSET4                    \ [0x00 : 12] OFFSET4
    $1a constant ADC_OFFSET4_CH                 \ [0x1a : 5] OFFSET4_CH
    $1f constant ADC_OFFSET4_EN                 \ [0x1f] OFFSET4_EN
  [then]


  [ifdef] ADC_JDR1_DEF
    \
    \ @brief injected data register 1
    \ Address offset: 0x80
    \ Reset value: 0x00000000
    \
    $00 constant ADC_JDATA1                     \ [0x00 : 16] JDATA1
  [then]


  [ifdef] ADC_JDR2_DEF
    \
    \ @brief injected data register 2
    \ Address offset: 0x84
    \ Reset value: 0x00000000
    \
    $00 constant ADC_JDATA2                     \ [0x00 : 16] JDATA2
  [then]


  [ifdef] ADC_JDR3_DEF
    \
    \ @brief injected data register 3
    \ Address offset: 0x88
    \ Reset value: 0x00000000
    \
    $00 constant ADC_JDATA3                     \ [0x00 : 16] JDATA3
  [then]


  [ifdef] ADC_JDR4_DEF
    \
    \ @brief injected data register 4
    \ Address offset: 0x8C
    \ Reset value: 0x00000000
    \
    $00 constant ADC_JDATA4                     \ [0x00 : 16] JDATA4
  [then]


  [ifdef] ADC_AWD2CR_DEF
    \
    \ @brief Analog Watchdog 2 Configuration Register
    \ Address offset: 0xA0
    \ Reset value: 0x00000000
    \
    $00 constant ADC_AWD2CH                     \ [0x00 : 18] AWD2CH
  [then]


  [ifdef] ADC_AWD3CR_DEF
    \
    \ @brief Analog Watchdog 3 Configuration Register
    \ Address offset: 0xA4
    \ Reset value: 0x00000000
    \
    $00 constant ADC_AWD3CH                     \ [0x00 : 18] AWD3CH
  [then]


  [ifdef] ADC_DIFSEL_DEF
    \
    \ @brief Differential Mode Selection Register 2
    \ Address offset: 0xB0
    \ Reset value: 0x00000000
    \
    $01 constant ADC_DIFSEL_1_15                \ [0x01 : 15] Differential mode for channels 15 to 1
    $10 constant ADC_DIFSEL_16_18               \ [0x10 : 3] Differential mode for channels 18 to 16
  [then]


  [ifdef] ADC_CALFACT_DEF
    \
    \ @brief Calibration Factors
    \ Address offset: 0xB4
    \ Reset value: 0x00000000
    \
    $00 constant ADC_CALFACT_S                  \ [0x00 : 7] CALFACT_S
    $10 constant ADC_CALFACT_D                  \ [0x10 : 7] CALFACT_D
  [then]

  \
  \ @brief Analog-to-Digital Converter
  \
  $00 constant ADC_ISR                  \ interrupt and status register
  $04 constant ADC_IER                  \ interrupt enable register
  $08 constant ADC_CR                   \ control register
  $0C constant ADC_CFGR                 \ configuration register
  $10 constant ADC_CFGR2                \ configuration register
  $14 constant ADC_SMPR1                \ sample time register 1
  $18 constant ADC_SMPR2                \ sample time register 2
  $20 constant ADC_TR1                  \ watchdog threshold register 1
  $24 constant ADC_TR2                  \ watchdog threshold register
  $28 constant ADC_TR3                  \ watchdog threshold register 3
  $30 constant ADC_SQR1                 \ regular sequence register 1
  $34 constant ADC_SQR2                 \ regular sequence register 2
  $38 constant ADC_SQR3                 \ regular sequence register 3
  $3C constant ADC_SQR4                 \ regular sequence register 4
  $40 constant ADC_DR                   \ regular Data Register
  $4C constant ADC_JSQR                 \ injected sequence register
  $60 constant ADC_OFR1                 \ offset register 1
  $64 constant ADC_OFR2                 \ offset register 2
  $68 constant ADC_OFR3                 \ offset register 3
  $6C constant ADC_OFR4                 \ offset register 4
  $80 constant ADC_JDR1                 \ injected data register 1
  $84 constant ADC_JDR2                 \ injected data register 2
  $88 constant ADC_JDR3                 \ injected data register 3
  $8C constant ADC_JDR4                 \ injected data register 4
  $A0 constant ADC_AWD2CR               \ Analog Watchdog 2 Configuration Register
  $A4 constant ADC_AWD3CR               \ Analog Watchdog 3 Configuration Register
  $B0 constant ADC_DIFSEL               \ Differential Mode Selection Register 2
  $B4 constant ADC_CALFACT              \ Calibration Factors

: ADC_DEF ; [then]
