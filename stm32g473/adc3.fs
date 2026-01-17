\
\ @file adc3.fs
\ @brief Analog-to-Digital Converter
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] ADC3_DEF

  [ifdef] ADC3_ISR_DEF
    \
    \ @brief interrupt and status register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant ADC3_ADRDY                     \ [0x00] ADRDY
    $01 constant ADC3_EOSMP                     \ [0x01] EOSMP
    $02 constant ADC3_EOC                       \ [0x02] EOC
    $03 constant ADC3_EOS                       \ [0x03] EOS
    $04 constant ADC3_OVR                       \ [0x04] OVR
    $05 constant ADC3_JEOC                      \ [0x05] JEOC
    $06 constant ADC3_JEOS                      \ [0x06] JEOS
    $07 constant ADC3_AWD1                      \ [0x07] AWD1
    $08 constant ADC3_AWD2                      \ [0x08] AWD2
    $09 constant ADC3_AWD3                      \ [0x09] AWD3
    $0a constant ADC3_JQOVF                     \ [0x0a] JQOVF
  [then]


  [ifdef] ADC3_IER_DEF
    \
    \ @brief interrupt enable register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant ADC3_ADRDYIE                   \ [0x00] ADRDYIE
    $01 constant ADC3_EOSMPIE                   \ [0x01] EOSMPIE
    $02 constant ADC3_EOCIE                     \ [0x02] EOCIE
    $03 constant ADC3_EOSIE                     \ [0x03] EOSIE
    $04 constant ADC3_OVRIE                     \ [0x04] OVRIE
    $05 constant ADC3_JEOCIE                    \ [0x05] JEOCIE
    $06 constant ADC3_JEOSIE                    \ [0x06] JEOSIE
    $07 constant ADC3_AWD1IE                    \ [0x07] AWD1IE
    $08 constant ADC3_AWD2IE                    \ [0x08] AWD2IE
    $09 constant ADC3_AWD3IE                    \ [0x09] AWD3IE
    $0a constant ADC3_JQOVFIE                   \ [0x0a] JQOVFIE
  [then]


  [ifdef] ADC3_CR_DEF
    \
    \ @brief control register
    \ Address offset: 0x08
    \ Reset value: 0x20002000
    \
    $00 constant ADC3_ADEN                      \ [0x00] ADEN
    $01 constant ADC3_ADDIS                     \ [0x01] ADDIS
    $02 constant ADC3_ADSTART                   \ [0x02] ADSTART
    $03 constant ADC3_JADSTART                  \ [0x03] JADSTART
    $04 constant ADC3_ADSTP                     \ [0x04] ADSTP
    $05 constant ADC3_JADSTP                    \ [0x05] JADSTP
    $1c constant ADC3_ADVREGEN                  \ [0x1c] ADVREGEN
    $1d constant ADC3_DEEPPWD                   \ [0x1d] DEEPPWD
    $1e constant ADC3_ADCALDIF                  \ [0x1e] ADCALDIF
    $1f constant ADC3_ADCAL                     \ [0x1f] ADCAL
  [then]


  [ifdef] ADC3_CFGR_DEF
    \
    \ @brief configuration register
    \ Address offset: 0x0C
    \ Reset value: 0x80000000
    \
    $00 constant ADC3_DMAEN                     \ [0x00] DMAEN
    $01 constant ADC3_DMACFG                    \ [0x01] DMACFG
    $03 constant ADC3_RES                       \ [0x03 : 2] RES
    $05 constant ADC3_EXTSEL                    \ [0x05 : 5] External trigger selection for regular group
    $0a constant ADC3_EXTEN                     \ [0x0a : 2] EXTEN
    $0c constant ADC3_OVRMOD                    \ [0x0c] OVRMOD
    $0d constant ADC3_CONT                      \ [0x0d] CONT
    $0e constant ADC3_AUTDLY                    \ [0x0e] AUTDLY
    $0f constant ADC3_ALIGN                     \ [0x0f] ALIGN
    $10 constant ADC3_DISCEN                    \ [0x10] DISCEN
    $11 constant ADC3_DISCNUM                   \ [0x11 : 3] DISCNUM
    $14 constant ADC3_JDISCEN                   \ [0x14] JDISCEN
    $15 constant ADC3_JQM                       \ [0x15] JQM
    $16 constant ADC3_AWD1SGL                   \ [0x16] AWD1SGL
    $17 constant ADC3_AWD1EN                    \ [0x17] AWD1EN
    $18 constant ADC3_JAWD1EN                   \ [0x18] JAWD1EN
    $19 constant ADC3_JAUTO                     \ [0x19] JAUTO
    $1a constant ADC3_AWDCH1CH                  \ [0x1a : 5] AWDCH1CH
    $1f constant ADC3_JQDIS                     \ [0x1f] Injected Queue disable
  [then]


  [ifdef] ADC3_CFGR2_DEF
    \
    \ @brief configuration register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant ADC3_ROVSE                     \ [0x00] DMAEN
    $01 constant ADC3_JOVSE                     \ [0x01] DMACFG
    $02 constant ADC3_OVSR                      \ [0x02 : 3] RES
    $05 constant ADC3_OVSS                      \ [0x05 : 4] ALIGN
    $09 constant ADC3_TROVS                     \ [0x09] Triggered Regular Oversampling
    $0a constant ADC3_ROVSM                     \ [0x0a] EXTEN
    $10 constant ADC3_GCOMP                     \ [0x10] GCOMP
    $19 constant ADC3_SWTRIG                    \ [0x19] SWTRIG
    $1a constant ADC3_BULB                      \ [0x1a] BULB
    $1b constant ADC3_SMPTRIG                   \ [0x1b] SMPTRIG
  [then]


  [ifdef] ADC3_SMPR1_DEF
    \
    \ @brief sample time register 1
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant ADC3_SMP0                      \ [0x00 : 3] SMP0
    $03 constant ADC3_SMP1                      \ [0x03 : 3] SMP1
    $06 constant ADC3_SMP2                      \ [0x06 : 3] SMP2
    $09 constant ADC3_SMP3                      \ [0x09 : 3] SMP3
    $0c constant ADC3_SMP4                      \ [0x0c : 3] SMP4
    $0f constant ADC3_SMP5                      \ [0x0f : 3] SMP5
    $12 constant ADC3_SMP6                      \ [0x12 : 3] SMP6
    $15 constant ADC3_SMP7                      \ [0x15 : 3] SMP7
    $18 constant ADC3_SMP8                      \ [0x18 : 3] SMP8
    $1b constant ADC3_SMP9                      \ [0x1b : 3] SMP9
    $1f constant ADC3_SMPPLUS                   \ [0x1f] Addition of one clock cycle to the sampling time
  [then]


  [ifdef] ADC3_SMPR2_DEF
    \
    \ @brief sample time register 2
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant ADC3_SMP10                     \ [0x00 : 3] SMP10
    $03 constant ADC3_SMP11                     \ [0x03 : 3] SMP11
    $06 constant ADC3_SMP12                     \ [0x06 : 3] SMP12
    $09 constant ADC3_SMP13                     \ [0x09 : 3] SMP13
    $0c constant ADC3_SMP14                     \ [0x0c : 3] SMP14
    $0f constant ADC3_SMP15                     \ [0x0f : 3] SMP15
    $12 constant ADC3_SMP16                     \ [0x12 : 3] SMP16
    $15 constant ADC3_SMP17                     \ [0x15 : 3] SMP17
    $18 constant ADC3_SMP18                     \ [0x18 : 3] SMP18
  [then]


  [ifdef] ADC3_TR1_DEF
    \
    \ @brief watchdog threshold register 1
    \ Address offset: 0x20
    \ Reset value: 0x0FFF0000
    \
    $00 constant ADC3_LT1                       \ [0x00 : 12] LT1
    $0c constant ADC3_AWDFILT                   \ [0x0c : 3] AWDFILT
    $10 constant ADC3_HT1                       \ [0x10 : 12] HT1
  [then]


  [ifdef] ADC3_TR2_DEF
    \
    \ @brief watchdog threshold register
    \ Address offset: 0x24
    \ Reset value: 0x00FF0000
    \
    $00 constant ADC3_LT2                       \ [0x00 : 8] LT2
    $10 constant ADC3_HT2                       \ [0x10 : 8] HT2
  [then]


  [ifdef] ADC3_TR3_DEF
    \
    \ @brief watchdog threshold register 3
    \ Address offset: 0x28
    \ Reset value: 0x00FF0000
    \
    $00 constant ADC3_LT3                       \ [0x00 : 8] LT3
    $10 constant ADC3_HT3                       \ [0x10 : 8] HT3
  [then]


  [ifdef] ADC3_SQR1_DEF
    \
    \ @brief regular sequence register 1
    \ Address offset: 0x30
    \ Reset value: 0x00000000
    \
    $00 constant ADC3_L                         \ [0x00 : 4] Regular channel sequence length
    $06 constant ADC3_SQ1                       \ [0x06 : 5] SQ1
    $0c constant ADC3_SQ2                       \ [0x0c : 5] SQ2
    $12 constant ADC3_SQ3                       \ [0x12 : 5] SQ3
    $18 constant ADC3_SQ4                       \ [0x18 : 5] SQ4
  [then]


  [ifdef] ADC3_SQR2_DEF
    \
    \ @brief regular sequence register 2
    \ Address offset: 0x34
    \ Reset value: 0x00000000
    \
    $00 constant ADC3_SQ5                       \ [0x00 : 5] SQ5
    $06 constant ADC3_SQ6                       \ [0x06 : 5] SQ6
    $0c constant ADC3_SQ7                       \ [0x0c : 5] SQ7
    $12 constant ADC3_SQ8                       \ [0x12 : 5] SQ8
    $18 constant ADC3_SQ9                       \ [0x18 : 5] SQ9
  [then]


  [ifdef] ADC3_SQR3_DEF
    \
    \ @brief regular sequence register 3
    \ Address offset: 0x38
    \ Reset value: 0x00000000
    \
    $00 constant ADC3_SQ10                      \ [0x00 : 5] SQ10
    $06 constant ADC3_SQ11                      \ [0x06 : 5] SQ11
    $0c constant ADC3_SQ12                      \ [0x0c : 5] SQ12
    $12 constant ADC3_SQ13                      \ [0x12 : 5] SQ13
    $18 constant ADC3_SQ14                      \ [0x18 : 5] SQ14
  [then]


  [ifdef] ADC3_SQR4_DEF
    \
    \ @brief regular sequence register 4
    \ Address offset: 0x3C
    \ Reset value: 0x00000000
    \
    $00 constant ADC3_SQ15                      \ [0x00 : 5] SQ15
    $06 constant ADC3_SQ16                      \ [0x06 : 5] SQ16
  [then]


  [ifdef] ADC3_DR_DEF
    \
    \ @brief regular Data Register
    \ Address offset: 0x40
    \ Reset value: 0x00000000
    \
    $00 constant ADC3_RDATA                     \ [0x00 : 16] Regular Data converted
  [then]


  [ifdef] ADC3_JSQR_DEF
    \
    \ @brief injected sequence register
    \ Address offset: 0x4C
    \ Reset value: 0x00000000
    \
    $00 constant ADC3_JL                        \ [0x00 : 2] JL
    $02 constant ADC3_JEXTSEL                   \ [0x02 : 5] JEXTSEL
    $07 constant ADC3_JEXTEN                    \ [0x07 : 2] JEXTEN
    $09 constant ADC3_JSQ1                      \ [0x09 : 5] JSQ1
    $0f constant ADC3_JSQ2                      \ [0x0f : 5] JSQ2
    $15 constant ADC3_JSQ3                      \ [0x15 : 5] JSQ3
    $1b constant ADC3_JSQ4                      \ [0x1b : 5] JSQ4
  [then]


  [ifdef] ADC3_OFR1_DEF
    \
    \ @brief offset register 1
    \ Address offset: 0x60
    \ Reset value: 0x00000000
    \
    $00 constant ADC3_OFFSET1                   \ [0x00 : 12] OFFSET1
    $18 constant ADC3_OFFSETPOS                 \ [0x18] OFFSETPOS
    $19 constant ADC3_SATEN                     \ [0x19] SATEN
    $1a constant ADC3_OFFSET1_CH                \ [0x1a : 5] OFFSET1_CH
    $1f constant ADC3_OFFSET1_EN                \ [0x1f] OFFSET1_EN
  [then]


  [ifdef] ADC3_OFR2_DEF
    \
    \ @brief offset register 2
    \ Address offset: 0x64
    \ Reset value: 0x00000000
    \
    $00 constant ADC3_OFFSET1                   \ [0x00 : 12] OFFSET1
    $18 constant ADC3_OFFSETPOS                 \ [0x18] OFFSETPOS
    $19 constant ADC3_SATEN                     \ [0x19] SATEN
    $1a constant ADC3_OFFSET1_CH                \ [0x1a : 5] OFFSET1_CH
    $1f constant ADC3_OFFSET1_EN                \ [0x1f] OFFSET1_EN
  [then]


  [ifdef] ADC3_OFR3_DEF
    \
    \ @brief offset register 3
    \ Address offset: 0x68
    \ Reset value: 0x00000000
    \
    $00 constant ADC3_OFFSET1                   \ [0x00 : 12] OFFSET1
    $18 constant ADC3_OFFSETPOS                 \ [0x18] OFFSETPOS
    $19 constant ADC3_SATEN                     \ [0x19] SATEN
    $1a constant ADC3_OFFSET1_CH                \ [0x1a : 5] OFFSET1_CH
    $1f constant ADC3_OFFSET1_EN                \ [0x1f] OFFSET1_EN
  [then]


  [ifdef] ADC3_OFR4_DEF
    \
    \ @brief offset register 4
    \ Address offset: 0x6C
    \ Reset value: 0x00000000
    \
    $00 constant ADC3_OFFSET1                   \ [0x00 : 12] OFFSET1
    $18 constant ADC3_OFFSETPOS                 \ [0x18] OFFSETPOS
    $19 constant ADC3_SATEN                     \ [0x19] SATEN
    $1a constant ADC3_OFFSET1_CH                \ [0x1a : 5] OFFSET1_CH
    $1f constant ADC3_OFFSET1_EN                \ [0x1f] OFFSET1_EN
  [then]


  [ifdef] ADC3_JDR1_DEF
    \
    \ @brief injected data register 1
    \ Address offset: 0x80
    \ Reset value: 0x00000000
    \
    $00 constant ADC3_JDATA1                    \ [0x00 : 16] JDATA1
  [then]


  [ifdef] ADC3_JDR2_DEF
    \
    \ @brief injected data register 2
    \ Address offset: 0x84
    \ Reset value: 0x00000000
    \
    $00 constant ADC3_JDATA2                    \ [0x00 : 16] JDATA2
  [then]


  [ifdef] ADC3_JDR3_DEF
    \
    \ @brief injected data register 3
    \ Address offset: 0x88
    \ Reset value: 0x00000000
    \
    $00 constant ADC3_JDATA3                    \ [0x00 : 16] JDATA3
  [then]


  [ifdef] ADC3_JDR4_DEF
    \
    \ @brief injected data register 4
    \ Address offset: 0x8C
    \ Reset value: 0x00000000
    \
    $00 constant ADC3_JDATA4                    \ [0x00 : 16] JDATA4
  [then]


  [ifdef] ADC3_AWD2CR_DEF
    \
    \ @brief Analog Watchdog 2 Configuration Register
    \ Address offset: 0xA0
    \ Reset value: 0x00000000
    \
    $00 constant ADC3_AWD2CH                    \ [0x00 : 19] AWD2CH
  [then]


  [ifdef] ADC3_AWD3CR_DEF
    \
    \ @brief Analog Watchdog 3 Configuration Register
    \ Address offset: 0xA4
    \ Reset value: 0x00000000
    \
    $00 constant ADC3_AWD3CH                    \ [0x00 : 19] AWD3CH
  [then]


  [ifdef] ADC3_DIFSEL_DEF
    \
    \ @brief Differential Mode Selection Register 2
    \ Address offset: 0xB0
    \ Reset value: 0x00000000
    \
    $00 constant ADC3_DIFSEL_0                  \ [0x00] Differential mode for channels 0
    $01 constant ADC3_DIFSEL_1_18               \ [0x01 : 18] Differential mode for channels 15 to 1
  [then]


  [ifdef] ADC3_CALFACT_DEF
    \
    \ @brief Calibration Factors
    \ Address offset: 0xB4
    \ Reset value: 0x00000000
    \
    $00 constant ADC3_CALFACT_S                 \ [0x00 : 7] CALFACT_S
    $10 constant ADC3_CALFACT_D                 \ [0x10 : 7] CALFACT_D
  [then]


  [ifdef] ADC3_GCOMP_DEF
    \
    \ @brief Gain compensation Register
    \ Address offset: 0xC0
    \ Reset value: 0x00000000
    \
    $00 constant ADC3_GCOMPCOEFF                \ [0x00 : 14] GCOMPCOEFF
  [then]

  \
  \ @brief Analog-to-Digital Converter
  \
  $00 constant ADC3_ISR                 \ interrupt and status register
  $04 constant ADC3_IER                 \ interrupt enable register
  $08 constant ADC3_CR                  \ control register
  $0C constant ADC3_CFGR                \ configuration register
  $10 constant ADC3_CFGR2               \ configuration register
  $14 constant ADC3_SMPR1               \ sample time register 1
  $18 constant ADC3_SMPR2               \ sample time register 2
  $20 constant ADC3_TR1                 \ watchdog threshold register 1
  $24 constant ADC3_TR2                 \ watchdog threshold register
  $28 constant ADC3_TR3                 \ watchdog threshold register 3
  $30 constant ADC3_SQR1                \ regular sequence register 1
  $34 constant ADC3_SQR2                \ regular sequence register 2
  $38 constant ADC3_SQR3                \ regular sequence register 3
  $3C constant ADC3_SQR4                \ regular sequence register 4
  $40 constant ADC3_DR                  \ regular Data Register
  $4C constant ADC3_JSQR                \ injected sequence register
  $60 constant ADC3_OFR1                \ offset register 1
  $64 constant ADC3_OFR2                \ offset register 2
  $68 constant ADC3_OFR3                \ offset register 3
  $6C constant ADC3_OFR4                \ offset register 4
  $80 constant ADC3_JDR1                \ injected data register 1
  $84 constant ADC3_JDR2                \ injected data register 2
  $88 constant ADC3_JDR3                \ injected data register 3
  $8C constant ADC3_JDR4                \ injected data register 4
  $A0 constant ADC3_AWD2CR              \ Analog Watchdog 2 Configuration Register
  $A4 constant ADC3_AWD3CR              \ Analog Watchdog 3 Configuration Register
  $B0 constant ADC3_DIFSEL              \ Differential Mode Selection Register 2
  $B4 constant ADC3_CALFACT             \ Calibration Factors
  $C0 constant ADC3_GCOMP               \ Gain compensation Register

: ADC3_DEF ; [then]
