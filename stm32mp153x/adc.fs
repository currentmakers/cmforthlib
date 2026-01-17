\
\ @file adc.fs
\ @brief ADC
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] ADC_DEF

  [ifdef] ADC_ADC_ISR_DEF
    \
    \ @brief ADC interrupt and status register
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


  [ifdef] ADC_ADC_IER_DEF
    \
    \ @brief ADC interrupt enable register
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


  [ifdef] ADC_ADC_CR_DEF
    \
    \ @brief ADC control register
    \ Address offset: 0x08
    \ Reset value: 0x20000000
    \
    $00 constant ADC_ADEN                       \ [0x00] ADEN
    $01 constant ADC_ADDIS                      \ [0x01] ADDIS
    $02 constant ADC_ADSTART                    \ [0x02] ADSTART
    $03 constant ADC_JADSTART                   \ [0x03] JADSTART
    $04 constant ADC_ADSTP                      \ [0x04] ADSTP
    $05 constant ADC_JADSTP                     \ [0x05] JADSTP
    $08 constant ADC_BOOST                      \ [0x08] BOOST
    $10 constant ADC_ADCALLIN                   \ [0x10] ADCALLIN
    $16 constant ADC_LINCALRDYW1                \ [0x16] LINCALRDYW1
    $17 constant ADC_LINCALRDYW2                \ [0x17] LINCALRDYW2
    $18 constant ADC_LINCALRDYW3                \ [0x18] LINCALRDYW3
    $19 constant ADC_LINCALRDYW4                \ [0x19] LINCALRDYW4
    $1a constant ADC_LINCALRDYW5                \ [0x1a] LINCALRDYW5
    $1b constant ADC_LINCALRDYW6                \ [0x1b] LINCALRDYW6
    $1c constant ADC_ADVREGEN                   \ [0x1c] ADVREGEN
    $1d constant ADC_DEEPPWD                    \ [0x1d] DEEPPWD
    $1e constant ADC_ADCALDIF                   \ [0x1e] ADCALDIF
    $1f constant ADC_ADCAL                      \ [0x1f] ADCAL
  [then]


  [ifdef] ADC_ADC_CFGR_DEF
    \
    \ @brief ADC configuration register
    \ Address offset: 0x0C
    \ Reset value: 0x80000000
    \
    $00 constant ADC_DMNGT                      \ [0x00 : 2] DMNGT
    $02 constant ADC_RES                        \ [0x02 : 3] RES
    $05 constant ADC_EXTSEL                     \ [0x05 : 5] EXTSEL
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
    $1a constant ADC_AWD1CH                     \ [0x1a : 5] AWD1CH
    $1f constant ADC_JQDIS                      \ [0x1f] JQDIS
  [then]


  [ifdef] ADC_ADC_CFGR2_DEF
    \
    \ @brief ADC configuration register 2
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant ADC_ROVSE                      \ [0x00] ROVSE
    $01 constant ADC_JOVSE                      \ [0x01] JOVSE
    $05 constant ADC_OVSS                       \ [0x05 : 4] OVSS
    $09 constant ADC_TROVS                      \ [0x09] TROVS
    $0a constant ADC_ROVSM                      \ [0x0a] ROVSM
    $0b constant ADC_RSHIFT1                    \ [0x0b] RSHIFT1
    $0c constant ADC_RSHIFT2                    \ [0x0c] RSHIFT2
    $0d constant ADC_RSHIFT3                    \ [0x0d] RSHIFT3
    $0e constant ADC_RSHIFT4                    \ [0x0e] RSHIFT4
    $10 constant ADC_OSVR                       \ [0x10 : 10] OSVR
    $1c constant ADC_LSHIFT                     \ [0x1c : 4] LSHIFT
  [then]


  [ifdef] ADC_ADC_SMPR1_DEF
    \
    \ @brief ADC sample time register 1
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
  [then]


  [ifdef] ADC_ADC_SMPR2_DEF
    \
    \ @brief ADC sample time register 2
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
    $1b constant ADC_SMP19                      \ [0x1b : 3] SMP19
  [then]


  [ifdef] ADC_ADC_PCSEL_DEF
    \
    \ @brief ADC channel preselection register
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant ADC_PCSEL0                     \ [0x00] PCSEL0
    $01 constant ADC_PCSEL1                     \ [0x01] PCSEL1
    $02 constant ADC_PCSEL2                     \ [0x02] PCSEL2
    $03 constant ADC_PCSEL3                     \ [0x03] PCSEL3
    $04 constant ADC_PCSEL4                     \ [0x04] PCSEL4
    $05 constant ADC_PCSEL5                     \ [0x05] PCSEL5
    $06 constant ADC_PCSEL6                     \ [0x06] PCSEL6
    $07 constant ADC_PCSEL7                     \ [0x07] PCSEL7
    $08 constant ADC_PCSEL8                     \ [0x08] PCSEL8
    $09 constant ADC_PCSEL9                     \ [0x09] PCSEL9
    $0a constant ADC_PCSEL10                    \ [0x0a] PCSEL10
    $0b constant ADC_PCSEL11                    \ [0x0b] PCSEL11
    $0c constant ADC_PCSEL12                    \ [0x0c] PCSEL12
    $0d constant ADC_PCSEL13                    \ [0x0d] PCSEL13
    $0e constant ADC_PCSEL14                    \ [0x0e] PCSEL14
    $0f constant ADC_PCSEL15                    \ [0x0f] PCSEL15
    $10 constant ADC_PCSEL16                    \ [0x10] PCSEL16
    $11 constant ADC_PCSEL17                    \ [0x11] PCSEL17
    $12 constant ADC_PCSEL18                    \ [0x12] PCSEL18
    $13 constant ADC_PCSEL19                    \ [0x13] PCSEL19
  [then]


  [ifdef] ADC_ADC_LTR1_DEF
    \
    \ @brief ADC watchdog threshold register 1
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant ADC_LTR1                       \ [0x00 : 26] LTR1
  [then]


  [ifdef] ADC_ADC_HTR1_DEF
    \
    \ @brief ADC watchdog threshold register 1
    \ Address offset: 0x24
    \ Reset value: 0x03FFFFFF
    \
    $00 constant ADC_HTR1                       \ [0x00 : 26] HTR1
  [then]


  [ifdef] ADC_ADC_SQR1_DEF
    \
    \ @brief ADC regular sequence register 1
    \ Address offset: 0x30
    \ Reset value: 0x00000000
    \
    $00 constant ADC_L                          \ [0x00 : 4] L
    $06 constant ADC_SQ1                        \ [0x06 : 5] SQ1
    $0c constant ADC_SQ2                        \ [0x0c : 5] SQ2
    $12 constant ADC_SQ3                        \ [0x12 : 5] SQ3
    $18 constant ADC_SQ4                        \ [0x18 : 5] SQ4
  [then]


  [ifdef] ADC_ADC_SQR2_DEF
    \
    \ @brief ADC regular sequence register 2
    \ Address offset: 0x34
    \ Reset value: 0x00000000
    \
    $00 constant ADC_SQ5                        \ [0x00 : 5] SQ5
    $06 constant ADC_SQ6                        \ [0x06 : 5] SQ6
    $0c constant ADC_SQ7                        \ [0x0c : 5] SQ7
    $12 constant ADC_SQ8                        \ [0x12 : 5] SQ8
    $18 constant ADC_SQ9                        \ [0x18 : 5] SQ9
  [then]


  [ifdef] ADC_ADC_SQR3_DEF
    \
    \ @brief ADC regular sequence register 3
    \ Address offset: 0x38
    \ Reset value: 0x00000000
    \
    $00 constant ADC_SQ10                       \ [0x00 : 5] SQ10
    $06 constant ADC_SQ11                       \ [0x06 : 5] SQ11
    $0c constant ADC_SQ12                       \ [0x0c : 5] SQ12
    $12 constant ADC_SQ13                       \ [0x12 : 5] SQ13
    $18 constant ADC_SQ14                       \ [0x18 : 5] SQ14
  [then]


  [ifdef] ADC_ADC_SQR4_DEF
    \
    \ @brief ADC regular sequence register 4
    \ Address offset: 0x3C
    \ Reset value: 0x00000000
    \
    $00 constant ADC_SQ15                       \ [0x00 : 5] SQ15
    $06 constant ADC_SQ16                       \ [0x06 : 5] SQ16
  [then]


  [ifdef] ADC_ADC_DR_DEF
    \
    \ @brief ADC regular Data Register
    \ Address offset: 0x40
    \ Reset value: 0x00000000
    \
    $00 constant ADC_RDATA                      \ [0x00 : 32] RDATA
  [then]


  [ifdef] ADC_ADC_JSQR_DEF
    \
    \ @brief ADC injected sequence register
    \ Address offset: 0x4C
    \ Reset value: 0x00000000
    \
    $00 constant ADC_JL                         \ [0x00 : 2] JL
    $02 constant ADC_JEXTSEL                    \ [0x02 : 5] JEXTSEL
    $07 constant ADC_JEXTEN                     \ [0x07 : 2] JEXTEN
    $09 constant ADC_JSQ1                       \ [0x09 : 5] JSQ1
    $0f constant ADC_JSQ2                       \ [0x0f : 5] JSQ2
    $15 constant ADC_JSQ3                       \ [0x15 : 5] JSQ3
    $1b constant ADC_JSQ4                       \ [0x1b : 5] JSQ4
  [then]


  [ifdef] ADC_ADC_OFR1_DEF
    \
    \ @brief ADC offset register
    \ Address offset: 0x60
    \ Reset value: 0x00000000
    \
    $00 constant ADC_OFFSET1                    \ [0x00 : 26] OFFSET1
    $1a constant ADC_OFFSET1_CH                 \ [0x1a : 5] OFFSET1_CH
    $1f constant ADC_SSATE                      \ [0x1f] SSATE
  [then]


  [ifdef] ADC_ADC_OFR2_DEF
    \
    \ @brief ADC offset register
    \ Address offset: 0x64
    \ Reset value: 0x00000000
    \
    $00 constant ADC_OFFSET2                    \ [0x00 : 26] OFFSET2
    $1a constant ADC_OFFSET2_CH                 \ [0x1a : 5] OFFSET2_CH
    $1f constant ADC_SSATE                      \ [0x1f] SSATE
  [then]


  [ifdef] ADC_ADC_OFR3_DEF
    \
    \ @brief ADC offset register
    \ Address offset: 0x68
    \ Reset value: 0x00000000
    \
    $00 constant ADC_OFFSET3                    \ [0x00 : 26] OFFSET3
    $1a constant ADC_OFFSET3_CH                 \ [0x1a : 5] OFFSET3_CH
    $1f constant ADC_SSATE                      \ [0x1f] SSATE
  [then]


  [ifdef] ADC_ADC_OFR4_DEF
    \
    \ @brief ADC offset register
    \ Address offset: 0x6C
    \ Reset value: 0x00000000
    \
    $00 constant ADC_OFFSET4                    \ [0x00 : 26] OFFSET4
    $1a constant ADC_OFFSET4_CH                 \ [0x1a : 5] OFFSET4_CH
    $1f constant ADC_SSATE                      \ [0x1f] SSATE
  [then]


  [ifdef] ADC_ADC_JDR1_DEF
    \
    \ @brief ADC injected data register
    \ Address offset: 0x80
    \ Reset value: 0x00000000
    \
    $00 constant ADC_JDATA                      \ [0x00 : 32] JDATA
  [then]


  [ifdef] ADC_ADC_JDR2_DEF
    \
    \ @brief ADC injected data register
    \ Address offset: 0x84
    \ Reset value: 0x00000000
    \
    $00 constant ADC_JDATA                      \ [0x00 : 32] JDATA
  [then]


  [ifdef] ADC_ADC_JDR3_DEF
    \
    \ @brief ADC injected data register
    \ Address offset: 0x88
    \ Reset value: 0x00000000
    \
    $00 constant ADC_JDATA                      \ [0x00 : 32] JDATA
  [then]


  [ifdef] ADC_ADC_JDR4_DEF
    \
    \ @brief ADC injected data register
    \ Address offset: 0x8C
    \ Reset value: 0x00000000
    \
    $00 constant ADC_JDATA                      \ [0x00 : 32] JDATA
  [then]


  [ifdef] ADC_ADC_AWD2CR_DEF
    \
    \ @brief ADC analog watchdog 2 configuration register
    \ Address offset: 0xA0
    \ Reset value: 0x00000000
    \
    $00 constant ADC_AWD2CH                     \ [0x00 : 20] AWD2CH
  [then]


  [ifdef] ADC_ADC_AWD3CR_DEF
    \
    \ @brief ADC analog watchdog 3 configuration register
    \ Address offset: 0xA4
    \ Reset value: 0x00000000
    \
    $00 constant ADC_AWD3CH                     \ [0x00 : 20] AWD3CH
  [then]


  [ifdef] ADC_ADC_LTR2_DEF
    \
    \ @brief ADC watchdog lower threshold register 2
    \ Address offset: 0xB0
    \ Reset value: 0x00000000
    \
    $00 constant ADC_LTR2                       \ [0x00 : 26] LTR2
  [then]


  [ifdef] ADC_ADC_HTR2_DEF
    \
    \ @brief ADC watchdog higher threshold register 2
    \ Address offset: 0xB4
    \ Reset value: 0x03FFFFFF
    \
    $00 constant ADC_HTR2                       \ [0x00 : 26] HTR2
  [then]


  [ifdef] ADC_ADC_LTR3_DEF
    \
    \ @brief ADC watchdog lower threshold register 3
    \ Address offset: 0xB8
    \ Reset value: 0x00000000
    \
    $00 constant ADC_LTR3                       \ [0x00 : 26] LTR3
  [then]


  [ifdef] ADC_ADC_HTR3_DEF
    \
    \ @brief ADC watchdog higher threshold register 3
    \ Address offset: 0xBC
    \ Reset value: 0x03FFFFFF
    \
    $00 constant ADC_HTR3                       \ [0x00 : 26] HTR3
  [then]


  [ifdef] ADC_ADC_DIFSEL_DEF
    \
    \ @brief ADC differential mode selection register
    \ Address offset: 0xC0
    \ Reset value: 0x00000000
    \
    $00 constant ADC_DIFSEL                     \ [0x00 : 20] DIFSEL
  [then]


  [ifdef] ADC_ADC_CALFACT_DEF
    \
    \ @brief ADC calibration factors register
    \ Address offset: 0xC4
    \ Reset value: 0x00000000
    \
    $00 constant ADC_CALFACT_S                  \ [0x00 : 11] CALFACT_S
    $10 constant ADC_CALFACT_D                  \ [0x10 : 11] CALFACT_D
  [then]


  [ifdef] ADC_ADC_CALFACT2_DEF
    \
    \ @brief ADC calibration factor register 2
    \ Address offset: 0xC8
    \ Reset value: 0x00000000
    \
    $00 constant ADC_LINCALFACT                 \ [0x00 : 30] LINCALFACT
  [then]

  \
  \ @brief ADC
  \
  $00 constant ADC_ADC_ISR              \ ADC interrupt and status register
  $04 constant ADC_ADC_IER              \ ADC interrupt enable register
  $08 constant ADC_ADC_CR               \ ADC control register
  $0C constant ADC_ADC_CFGR             \ ADC configuration register
  $10 constant ADC_ADC_CFGR2            \ ADC configuration register 2
  $14 constant ADC_ADC_SMPR1            \ ADC sample time register 1
  $18 constant ADC_ADC_SMPR2            \ ADC sample time register 2
  $1C constant ADC_ADC_PCSEL            \ ADC channel preselection register
  $20 constant ADC_ADC_LTR1             \ ADC watchdog threshold register 1
  $24 constant ADC_ADC_HTR1             \ ADC watchdog threshold register 1
  $30 constant ADC_ADC_SQR1             \ ADC regular sequence register 1
  $34 constant ADC_ADC_SQR2             \ ADC regular sequence register 2
  $38 constant ADC_ADC_SQR3             \ ADC regular sequence register 3
  $3C constant ADC_ADC_SQR4             \ ADC regular sequence register 4
  $40 constant ADC_ADC_DR               \ ADC regular Data Register
  $4C constant ADC_ADC_JSQR             \ ADC injected sequence register
  $60 constant ADC_ADC_OFR1             \ ADC offset register
  $64 constant ADC_ADC_OFR2             \ ADC offset register
  $68 constant ADC_ADC_OFR3             \ ADC offset register
  $6C constant ADC_ADC_OFR4             \ ADC offset register
  $80 constant ADC_ADC_JDR1             \ ADC injected data register
  $84 constant ADC_ADC_JDR2             \ ADC injected data register
  $88 constant ADC_ADC_JDR3             \ ADC injected data register
  $8C constant ADC_ADC_JDR4             \ ADC injected data register
  $A0 constant ADC_ADC_AWD2CR           \ ADC analog watchdog 2 configuration register
  $A4 constant ADC_ADC_AWD3CR           \ ADC analog watchdog 3 configuration register
  $B0 constant ADC_ADC_LTR2             \ ADC watchdog lower threshold register 2
  $B4 constant ADC_ADC_HTR2             \ ADC watchdog higher threshold register 2
  $B8 constant ADC_ADC_LTR3             \ ADC watchdog lower threshold register 3
  $BC constant ADC_ADC_HTR3             \ ADC watchdog higher threshold register 3
  $C0 constant ADC_ADC_DIFSEL           \ ADC differential mode selection register
  $C4 constant ADC_ADC_CALFACT          \ ADC calibration factors register
  $C8 constant ADC_ADC_CALFACT2         \ ADC calibration factor register 2

: ADC_DEF ; [then]
