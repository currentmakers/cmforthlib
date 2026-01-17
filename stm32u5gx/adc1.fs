\
\ @file adc1.fs
\ @brief ADC1
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] ADC1_DEF

  [ifdef] ADC1_ADC_ISR_DEF
    \
    \ @brief ADC interrupt and status register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant ADC1_ADRDY                     \ [0x00] ADRDY
    $01 constant ADC1_EOSMP                     \ [0x01] EOSMP
    $02 constant ADC1_EOC                       \ [0x02] EOC
    $03 constant ADC1_EOS                       \ [0x03] EOS
    $04 constant ADC1_OVR                       \ [0x04] OVR
    $05 constant ADC1_JEOC                      \ [0x05] JEOC
    $06 constant ADC1_JEOS                      \ [0x06] JEOS
    $07 constant ADC1_AWD1                      \ [0x07] AWD1
    $08 constant ADC1_AWD2                      \ [0x08] AWD2
    $09 constant ADC1_AWD3                      \ [0x09] AWD3
    $0c constant ADC1_LDORDY                    \ [0x0c] LDORDY
  [then]


  [ifdef] ADC1_ADC_IER_DEF
    \
    \ @brief ADC interrupt enable register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant ADC1_ADRDYIE                   \ [0x00] ADRDYIE
    $01 constant ADC1_EOSMPIE                   \ [0x01] EOSMPIE
    $02 constant ADC1_EOCIE                     \ [0x02] EOCIE
    $03 constant ADC1_EOSIE                     \ [0x03] EOSIE
    $04 constant ADC1_OVRIE                     \ [0x04] OVRIE
    $05 constant ADC1_JEOCIE                    \ [0x05] JEOCIE
    $06 constant ADC1_JEOSIE                    \ [0x06] JEOSIE
    $07 constant ADC1_AWD1IE                    \ [0x07] AWD1IE
    $08 constant ADC1_AWD2IE                    \ [0x08] AWD2IE
    $09 constant ADC1_AWD3IE                    \ [0x09] AWD3IE
  [then]


  [ifdef] ADC1_ADC_CR_DEF
    \
    \ @brief ADC control register
    \ Address offset: 0x08
    \ Reset value: 0x20000000
    \
    $00 constant ADC1_ADEN                      \ [0x00] ADEN
    $01 constant ADC1_ADDIS                     \ [0x01] ADDIS
    $02 constant ADC1_ADSTART                   \ [0x02] ADSTART
    $03 constant ADC1_JADSTART                  \ [0x03] JADSTART
    $04 constant ADC1_ADSTP                     \ [0x04] ADSTP
    $05 constant ADC1_JADSTP                    \ [0x05] JADSTP
    $10 constant ADC1_ADCALLIN                  \ [0x10] ADCALLIN
    $18 constant ADC1_CALINDEX                  \ [0x18 : 4] CALINDEX
    $1c constant ADC1_ADVREGEN                  \ [0x1c] ADVREGEN
    $1d constant ADC1_DEEPPWD                   \ [0x1d] DEEPPWD
    $1f constant ADC1_ADCAL                     \ [0x1f] ADCAL
  [then]


  [ifdef] ADC1_ADC_CFGR1_DEF
    \
    \ @brief ADC configuration register
    \ Address offset: 0x0C
    \ Reset value: 0x80000000
    \
    $00 constant ADC1_DMNGT                     \ [0x00 : 2] DMNGT
    $02 constant ADC1_RES                       \ [0x02 : 2] RES
    $05 constant ADC1_EXTSEL                    \ [0x05 : 5] EXTSEL
    $0a constant ADC1_EXTEN                     \ [0x0a : 2] EXTEN
    $0c constant ADC1_OVRMOD                    \ [0x0c] OVRMOD
    $0d constant ADC1_CONT                      \ [0x0d] CONT
    $0e constant ADC1_AUTDLY                    \ [0x0e] AUTDLY
    $10 constant ADC1_DISCEN                    \ [0x10] DISCEN
    $11 constant ADC1_DISCNUM                   \ [0x11 : 3] DISCNUM
    $14 constant ADC1_JDISCEN                   \ [0x14] JDISCEN
    $16 constant ADC1_AWD1SGL                   \ [0x16] AWD1SGL
    $17 constant ADC1_AWD1EN                    \ [0x17] AWD1EN
    $18 constant ADC1_JAWD1EN                   \ [0x18] JAWD1EN
    $19 constant ADC1_JAUTO                     \ [0x19] JAUTO
    $1a constant ADC1_AWD1CH                    \ [0x1a : 5] AWD1CH
  [then]


  [ifdef] ADC1_ADC_CFGR2_DEF
    \
    \ @brief ADC configuration register 2
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant ADC1_ROVSE                     \ [0x00] ROVSE
    $01 constant ADC1_JOVSE                     \ [0x01] JOVSE
    $05 constant ADC1_OVSS                      \ [0x05 : 4] OVSS
    $09 constant ADC1_TROVS                     \ [0x09] TROVS
    $0a constant ADC1_ROVSM                     \ [0x0a] ROVSM
    $0d constant ADC1_BULB                      \ [0x0d] BULB
    $0e constant ADC1_SWTRIG                    \ [0x0e] SWTRIG
    $0f constant ADC1_SMPTRIG                   \ [0x0f] SMPTRIG
    $10 constant ADC1_OSR                       \ [0x10 : 10] OSR
    $1b constant ADC1_LFTRIG                    \ [0x1b] LFTRIG
    $1c constant ADC1_LSHIFT                    \ [0x1c : 4] LSHIFT
  [then]


  [ifdef] ADC1_ADC_SMPR1_DEF
    \
    \ @brief ADC sample time register 1
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant ADC1_SMP0                      \ [0x00 : 3] SMP0
    $03 constant ADC1_SMP1                      \ [0x03 : 3] SMP1
    $06 constant ADC1_SMP2                      \ [0x06 : 3] SMP2
    $09 constant ADC1_SMP3                      \ [0x09 : 3] SMP3
    $0c constant ADC1_SMP4                      \ [0x0c : 3] SMP4
    $0f constant ADC1_SMP5                      \ [0x0f : 3] SMP5
    $12 constant ADC1_SMP6                      \ [0x12 : 3] SMP6
    $15 constant ADC1_SMP7                      \ [0x15 : 3] SMP7
    $18 constant ADC1_SMP8                      \ [0x18 : 3] SMP8
    $1b constant ADC1_SMP9                      \ [0x1b : 3] SMP9
  [then]


  [ifdef] ADC1_ADC_SMPR2_DEF
    \
    \ @brief ADC sample time register 2
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant ADC1_SMP10                     \ [0x00 : 3] SMP10
    $03 constant ADC1_SMP11                     \ [0x03 : 3] SMP11
    $06 constant ADC1_SMP12                     \ [0x06 : 3] SMP12
    $09 constant ADC1_SMP13                     \ [0x09 : 3] SMP13
    $0c constant ADC1_SMP14                     \ [0x0c : 3] SMP14
    $0f constant ADC1_SMP15                     \ [0x0f : 3] SMP15
    $12 constant ADC1_SMP16                     \ [0x12 : 3] SMP16
    $15 constant ADC1_SMP17                     \ [0x15 : 3] SMP17
    $18 constant ADC1_SMP18                     \ [0x18 : 3] SMP18
    $1b constant ADC1_SMP19                     \ [0x1b : 3] SMP19
  [then]


  [ifdef] ADC1_ADC_PCSEL_DEF
    \
    \ @brief ADC channel preselection register
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant ADC1_PCSEL0                    \ [0x00] PCSEL0
    $01 constant ADC1_PCSEL1                    \ [0x01] PCSEL1
    $02 constant ADC1_PCSEL2                    \ [0x02] PCSEL2
    $03 constant ADC1_PCSEL3                    \ [0x03] PCSEL3
    $04 constant ADC1_PCSEL4                    \ [0x04] PCSEL4
    $05 constant ADC1_PCSEL5                    \ [0x05] PCSEL5
    $06 constant ADC1_PCSEL6                    \ [0x06] PCSEL6
    $07 constant ADC1_PCSEL7                    \ [0x07] PCSEL7
    $08 constant ADC1_PCSEL8                    \ [0x08] PCSEL8
    $09 constant ADC1_PCSEL9                    \ [0x09] PCSEL9
    $0a constant ADC1_PCSEL10                   \ [0x0a] PCSEL10
    $0b constant ADC1_PCSEL11                   \ [0x0b] PCSEL11
    $0c constant ADC1_PCSEL12                   \ [0x0c] PCSEL12
    $0d constant ADC1_PCSEL13                   \ [0x0d] PCSEL13
    $0e constant ADC1_PCSEL14                   \ [0x0e] PCSEL14
    $0f constant ADC1_PCSEL15                   \ [0x0f] PCSEL15
    $10 constant ADC1_PCSEL16                   \ [0x10] PCSEL16
    $11 constant ADC1_PCSEL17                   \ [0x11] PCSEL17
    $12 constant ADC1_PCSEL18                   \ [0x12] PCSEL18
    $13 constant ADC1_PCSEL19                   \ [0x13] PCSEL19
  [then]


  [ifdef] ADC1_ADC_SQR1_DEF
    \
    \ @brief ADC regular sequence register 1
    \ Address offset: 0x30
    \ Reset value: 0x00000000
    \
    $00 constant ADC1_L                         \ [0x00 : 4] L
    $06 constant ADC1_SQ1                       \ [0x06 : 5] SQ1
    $0c constant ADC1_SQ2                       \ [0x0c : 5] SQ2
    $12 constant ADC1_SQ3                       \ [0x12 : 5] SQ3
    $18 constant ADC1_SQ4                       \ [0x18 : 5] SQ4
  [then]


  [ifdef] ADC1_ADC_SQR2_DEF
    \
    \ @brief ADC regular sequence register 2
    \ Address offset: 0x34
    \ Reset value: 0x00000000
    \
    $00 constant ADC1_SQ5                       \ [0x00 : 5] SQ5
    $06 constant ADC1_SQ6                       \ [0x06 : 5] SQ6
    $0c constant ADC1_SQ7                       \ [0x0c : 5] SQ7
    $12 constant ADC1_SQ8                       \ [0x12 : 5] SQ8
    $18 constant ADC1_SQ9                       \ [0x18 : 5] SQ9
  [then]


  [ifdef] ADC1_ADC_SQR3_DEF
    \
    \ @brief ADC regular sequence register 3
    \ Address offset: 0x38
    \ Reset value: 0x00000000
    \
    $00 constant ADC1_SQ10                      \ [0x00 : 5] SQ10
    $06 constant ADC1_SQ11                      \ [0x06 : 5] SQ11
    $0c constant ADC1_SQ12                      \ [0x0c : 5] SQ12
    $12 constant ADC1_SQ13                      \ [0x12 : 5] SQ13
    $18 constant ADC1_SQ14                      \ [0x18 : 5] SQ14
  [then]


  [ifdef] ADC1_ADC_SQR4_DEF
    \
    \ @brief ADC regular sequence register 4
    \ Address offset: 0x3C
    \ Reset value: 0x00000000
    \
    $00 constant ADC1_SQ15                      \ [0x00 : 5] SQ15
    $06 constant ADC1_SQ16                      \ [0x06 : 5] SQ16
  [then]


  [ifdef] ADC1_ADC_DR_DEF
    \
    \ @brief ADC regular Data Register
    \ Address offset: 0x40
    \ Reset value: 0x00000000
    \
    $00 constant ADC1_RDATA                     \ [0x00 : 32] RDATA
  [then]


  [ifdef] ADC1_ADC_JSQR_DEF
    \
    \ @brief ADC injected sequence register
    \ Address offset: 0x4C
    \ Reset value: 0x00000000
    \
    $00 constant ADC1_JL                        \ [0x00 : 2] JL
    $02 constant ADC1_JEXTSEL                   \ [0x02 : 5] JEXTSEL
    $07 constant ADC1_JEXTEN                    \ [0x07 : 2] JEXTEN
    $09 constant ADC1_JSQ1                      \ [0x09 : 5] JSQ1
    $0f constant ADC1_JSQ2                      \ [0x0f : 5] JSQ2
    $15 constant ADC1_JSQ3                      \ [0x15 : 5] JSQ3
    $1b constant ADC1_JSQ4                      \ [0x1b : 5] JSQ4
  [then]


  [ifdef] ADC1_ADC_OFR1_DEF
    \
    \ @brief ADC offset register
    \ Address offset: 0x60
    \ Reset value: 0x00000000
    \
    $00 constant ADC1_OFFSET                    \ [0x00 : 24] OFFSET
    $18 constant ADC1_POSOFF                    \ [0x18] POSOFF
    $19 constant ADC1_USAT                      \ [0x19] USAT
    $1a constant ADC1_SSAT                      \ [0x1a] SSAT
    $1b constant ADC1_OFFSET_CH                 \ [0x1b : 5] OFFSET_CH
  [then]


  [ifdef] ADC1_ADC_OFR2_DEF
    \
    \ @brief ADC offset register
    \ Address offset: 0x64
    \ Reset value: 0x00000000
    \
    $00 constant ADC1_OFFSET                    \ [0x00 : 24] OFFSET
    $18 constant ADC1_POSOFF                    \ [0x18] POSOFF
    $19 constant ADC1_USAT                      \ [0x19] USAT
    $1a constant ADC1_SSAT                      \ [0x1a] SSAT
    $1b constant ADC1_OFFSET_CH                 \ [0x1b : 5] OFFSET_CH
  [then]


  [ifdef] ADC1_ADC_OFR3_DEF
    \
    \ @brief ADC offset register
    \ Address offset: 0x68
    \ Reset value: 0x00000000
    \
    $00 constant ADC1_OFFSET                    \ [0x00 : 24] OFFSET
    $18 constant ADC1_POSOFF                    \ [0x18] POSOFF
    $19 constant ADC1_USAT                      \ [0x19] USAT
    $1a constant ADC1_SSAT                      \ [0x1a] SSAT
    $1b constant ADC1_OFFSET_CH                 \ [0x1b : 5] OFFSET_CH
  [then]


  [ifdef] ADC1_ADC_OFR4_DEF
    \
    \ @brief ADC offset register
    \ Address offset: 0x6C
    \ Reset value: 0x00000000
    \
    $00 constant ADC1_OFFSET                    \ [0x00 : 24] OFFSET
    $18 constant ADC1_POSOFF                    \ [0x18] POSOFF
    $19 constant ADC1_USAT                      \ [0x19] USAT
    $1a constant ADC1_SSAT                      \ [0x1a] SSAT
    $1b constant ADC1_OFFSET_CH                 \ [0x1b : 5] OFFSET_CH
  [then]


  [ifdef] ADC1_ADC_GCOMP_DEF
    \
    \ @brief ADC gain compensation register
    \ Address offset: 0x70
    \ Reset value: 0x00000000
    \
    $00 constant ADC1_GCOMPCOEFF                \ [0x00 : 14] GCOMPCOEFF
    $1f constant ADC1_GCOMP                     \ [0x1f] GCOMP
  [then]


  [ifdef] ADC1_ADC_JDR1_DEF
    \
    \ @brief ADC injected data register
    \ Address offset: 0x80
    \ Reset value: 0x00000000
    \
    $00 constant ADC1_JDATA                     \ [0x00 : 32] JDATA
  [then]


  [ifdef] ADC1_ADC_JDR2_DEF
    \
    \ @brief ADC injected data register
    \ Address offset: 0x84
    \ Reset value: 0x00000000
    \
    $00 constant ADC1_JDATA                     \ [0x00 : 32] JDATA
  [then]


  [ifdef] ADC1_ADC_JDR3_DEF
    \
    \ @brief ADC injected data register
    \ Address offset: 0x88
    \ Reset value: 0x00000000
    \
    $00 constant ADC1_JDATA                     \ [0x00 : 32] JDATA
  [then]


  [ifdef] ADC1_ADC_JDR4_DEF
    \
    \ @brief ADC injected data register
    \ Address offset: 0x8C
    \ Reset value: 0x00000000
    \
    $00 constant ADC1_JDATA                     \ [0x00 : 32] JDATA
  [then]


  [ifdef] ADC1_ADC_AWD2CR_DEF
    \
    \ @brief ADC analog watchdog 2 configuration register
    \ Address offset: 0xA0
    \ Reset value: 0x00000000
    \
    $00 constant ADC1_AWD2CH                    \ [0x00 : 20] AWD2CH
  [then]


  [ifdef] ADC1_ADC_AWD3CR_DEF
    \
    \ @brief ADC analog watchdog 3 configuration register
    \ Address offset: 0xA4
    \ Reset value: 0x00000000
    \
    $00 constant ADC1_AWD3CH                    \ [0x00 : 20] AWD3CH
  [then]


  [ifdef] ADC1_ADC_LTR1_DEF
    \
    \ @brief ADC watchdog threshold register 1
    \ Address offset: 0xA8
    \ Reset value: 0x00000000
    \
    $00 constant ADC1_LTR1                      \ [0x00 : 25] LTR1
  [then]


  [ifdef] ADC1_ADC_HTR1_DEF
    \
    \ @brief ADC watchdog threshold register 1
    \ Address offset: 0xAC
    \ Reset value: 0x01FFFFFF
    \
    $00 constant ADC1_HTR1                      \ [0x00 : 25] HTR1
    $1d constant ADC1_AWDFILT1                  \ [0x1d : 3] AWDFILT1
  [then]


  [ifdef] ADC1_ADC_LTR2_DEF
    \
    \ @brief ADC watchdog lower threshold register 2
    \ Address offset: 0xB0
    \ Reset value: 0x00000000
    \
    $00 constant ADC1_LTR2                      \ [0x00 : 25] LTR2
  [then]


  [ifdef] ADC1_ADC_HTR2_DEF
    \
    \ @brief ADC watchdog higher threshold register 2
    \ Address offset: 0xB4
    \ Reset value: 0x01FFFFFF
    \
    $00 constant ADC1_HTR2                      \ [0x00 : 25] HTR2
  [then]


  [ifdef] ADC1_ADC_LTR3_DEF
    \
    \ @brief ADC watchdog lower threshold register 3
    \ Address offset: 0xB8
    \ Reset value: 0x00000000
    \
    $00 constant ADC1_LTR3                      \ [0x00 : 25] LTR3
  [then]


  [ifdef] ADC1_ADC_HTR3_DEF
    \
    \ @brief ADC watchdog higher threshold register 3
    \ Address offset: 0xBC
    \ Reset value: 0x01FFFFFF
    \
    $00 constant ADC1_HTR3                      \ [0x00 : 25] HTR3
  [then]


  [ifdef] ADC1_ADC_DIFSEL_DEF
    \
    \ @brief ADC differential mode selection register
    \ Address offset: 0xC0
    \ Reset value: 0x00000000
    \
    $00 constant ADC1_DIFSEL                    \ [0x00 : 20] DIFSEL
  [then]


  [ifdef] ADC1_ADC_CALFACT_DEF
    \
    \ @brief ADC user control register
    \ Address offset: 0xC4
    \ Reset value: 0x00000000
    \
    $00 constant ADC1_I_APB_ADDR                \ [0x00 : 8] I_APB_ADDR
    $08 constant ADC1_I_APB_DATA                \ [0x08 : 8] I_APB_DATA
    $10 constant ADC1_VALIDITY                  \ [0x10] VALIDITY
    $18 constant ADC1_LATCH_COEF                \ [0x18] LATCH_COEF
    $19 constant ADC1_CAPTURE_COEF              \ [0x19] CAPTURE_COEF
  [then]


  [ifdef] ADC1_ADC_CALFACT2_DEF
    \
    \ @brief ADC calibration factor register
    \ Address offset: 0xC8
    \ Reset value: 0x00000000
    \
    $00 constant ADC1_CALFACT                   \ [0x00 : 32] CALFACT
  [then]

  \
  \ @brief ADC1
  \
  $00 constant ADC1_ADC_ISR             \ ADC interrupt and status register
  $04 constant ADC1_ADC_IER             \ ADC interrupt enable register
  $08 constant ADC1_ADC_CR              \ ADC control register
  $0C constant ADC1_ADC_CFGR1           \ ADC configuration register
  $10 constant ADC1_ADC_CFGR2           \ ADC configuration register 2
  $14 constant ADC1_ADC_SMPR1           \ ADC sample time register 1
  $18 constant ADC1_ADC_SMPR2           \ ADC sample time register 2
  $1C constant ADC1_ADC_PCSEL           \ ADC channel preselection register
  $30 constant ADC1_ADC_SQR1            \ ADC regular sequence register 1
  $34 constant ADC1_ADC_SQR2            \ ADC regular sequence register 2
  $38 constant ADC1_ADC_SQR3            \ ADC regular sequence register 3
  $3C constant ADC1_ADC_SQR4            \ ADC regular sequence register 4
  $40 constant ADC1_ADC_DR              \ ADC regular Data Register
  $4C constant ADC1_ADC_JSQR            \ ADC injected sequence register
  $60 constant ADC1_ADC_OFR1            \ ADC offset register
  $64 constant ADC1_ADC_OFR2            \ ADC offset register
  $68 constant ADC1_ADC_OFR3            \ ADC offset register
  $6C constant ADC1_ADC_OFR4            \ ADC offset register
  $70 constant ADC1_ADC_GCOMP           \ ADC gain compensation register
  $80 constant ADC1_ADC_JDR1            \ ADC injected data register
  $84 constant ADC1_ADC_JDR2            \ ADC injected data register
  $88 constant ADC1_ADC_JDR3            \ ADC injected data register
  $8C constant ADC1_ADC_JDR4            \ ADC injected data register
  $A0 constant ADC1_ADC_AWD2CR          \ ADC analog watchdog 2 configuration register
  $A4 constant ADC1_ADC_AWD3CR          \ ADC analog watchdog 3 configuration register
  $A8 constant ADC1_ADC_LTR1            \ ADC watchdog threshold register 1
  $AC constant ADC1_ADC_HTR1            \ ADC watchdog threshold register 1
  $B0 constant ADC1_ADC_LTR2            \ ADC watchdog lower threshold register 2
  $B4 constant ADC1_ADC_HTR2            \ ADC watchdog higher threshold register 2
  $B8 constant ADC1_ADC_LTR3            \ ADC watchdog lower threshold register 3
  $BC constant ADC1_ADC_HTR3            \ ADC watchdog higher threshold register 3
  $C0 constant ADC1_ADC_DIFSEL          \ ADC differential mode selection register
  $C4 constant ADC1_ADC_CALFACT         \ ADC user control register
  $C8 constant ADC1_ADC_CALFACT2        \ ADC calibration factor register

: ADC1_DEF ; [then]
