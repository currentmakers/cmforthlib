\
\ @file adc.fs
\ @brief Analog to digital convertor
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
    $07 constant ADC_AWD1                       \ [0x07] AWD1
    $08 constant ADC_AWD2                       \ [0x08] AWD2
    $09 constant ADC_AWD3                       \ [0x09] AWD3
    $0b constant ADC_EOCAL                      \ [0x0b] EOCAL
    $0d constant ADC_CCRDY                      \ [0x0d] CCRDY
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
    $07 constant ADC_AWD1IE                     \ [0x07] AWD1IE
    $08 constant ADC_AWD2IE                     \ [0x08] AWD2IE
    $09 constant ADC_AWD3IE                     \ [0x09] AWD3IE
    $0b constant ADC_EOCALIE                    \ [0x0b] EOCALIE
    $0d constant ADC_CCRDYIE                    \ [0x0d] CCRDYIE
  [then]


  [ifdef] ADC_ADC_CR_DEF
    \
    \ @brief ADC control register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant ADC_ADEN                       \ [0x00] ADEN
    $01 constant ADC_ADDIS                      \ [0x01] ADDIS
    $02 constant ADC_ADSTART                    \ [0x02] ADSTART
    $04 constant ADC_ADSTP                      \ [0x04] ADSTP
    $1c constant ADC_ADVREGEN                   \ [0x1c] ADVREGEN
    $1f constant ADC_ADCAL                      \ [0x1f] ADCAL
  [then]


  [ifdef] ADC_ADC_CFGR1_DEF
    \
    \ @brief ADC configuration register 1
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant ADC_DMAEN                      \ [0x00] DMAEN
    $01 constant ADC_DMACFG                     \ [0x01] DMACFG
    $02 constant ADC_SCANDIR                    \ [0x02] SCANDIR
    $03 constant ADC_RES                        \ [0x03 : 2] RES
    $05 constant ADC_ALIGN                      \ [0x05] ALIGN
    $06 constant ADC_EXTSEL                     \ [0x06 : 3] EXTSEL
    $0a constant ADC_EXTEN                      \ [0x0a : 2] EXTEN
    $0c constant ADC_OVRMOD                     \ [0x0c] OVRMOD
    $0d constant ADC_CONT                       \ [0x0d] CONT
    $0e constant ADC_WAIT                       \ [0x0e] WAIT
    $0f constant ADC_AUTOFF                     \ [0x0f] AUTOFF
    $10 constant ADC_DISCEN                     \ [0x10] DISCEN
    $15 constant ADC_CHSELRMOD                  \ [0x15] CHSELRMOD
    $16 constant ADC_AWD1SGL                    \ [0x16] AWD1SGL
    $17 constant ADC_AWD1EN                     \ [0x17] AWD1EN
    $1a constant ADC_AWD1CH                     \ [0x1a : 5] AWD1CH
  [then]


  [ifdef] ADC_ADC_CFGR2_DEF
    \
    \ @brief ADC configuration register 2
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant ADC_OVSE                       \ [0x00] OVSE
    $02 constant ADC_OVSR0                      \ [0x02] OVSR0
    $03 constant ADC_OVSR1                      \ [0x03] OVSR1
    $04 constant ADC_OVSR2                      \ [0x04] OVSR2
    $05 constant ADC_OVSS0                      \ [0x05] OVSS0
    $06 constant ADC_OVSS1                      \ [0x06] OVSS1
    $07 constant ADC_OVSS2                      \ [0x07] OVSS2
    $08 constant ADC_OVSS3                      \ [0x08] OVSS3
    $09 constant ADC_TOVS                       \ [0x09] TOVS
    $1d constant ADC_LFTRIG                     \ [0x1d] LFTRIG
    $1e constant ADC_CKMODE                     \ [0x1e : 2] CKMODE
  [then]


  [ifdef] ADC_ADC_SMPR_DEF
    \
    \ @brief ADC sampling time register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant ADC_SMP1                       \ [0x00 : 3] SMP1
    $04 constant ADC_SMP2                       \ [0x04 : 3] SMP2
    $08 constant ADC_SMPSEL                     \ [0x08 : 18] SMPSEL
  [then]


  [ifdef] ADC_ADC_AWD1TR_DEF
    \
    \ @brief ADC watchdog threshold register
    \ Address offset: 0x20
    \ Reset value: 0x0FFF0000
    \
    $00 constant ADC_LT1                        \ [0x00 : 12] LT1
    $10 constant ADC_HT1                        \ [0x10 : 12] HT1
  [then]


  [ifdef] ADC_ADC_AWD2TR_DEF
    \
    \ @brief ADC watchdog threshold register
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant ADC_LT2                        \ [0x00 : 12] LT2
    $10 constant ADC_HT2                        \ [0x10 : 12] HT2
  [then]


  [ifdef] ADC_ADC_CHSELR0_DEF
    \
    \ @brief channel selection register
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant ADC_CHSEL                      \ [0x00 : 18] CHSEL
  [then]


  [ifdef] ADC_ADC_CHSELR1_DEF
    \
    \ @brief channel selection register
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant ADC_SQ1                        \ [0x00 : 4] SQ1
    $04 constant ADC_SQ2                        \ [0x04 : 4] SQ2
    $08 constant ADC_SQ3                        \ [0x08 : 4] SQ3
    $0c constant ADC_SQ4                        \ [0x0c : 4] SQ4
    $10 constant ADC_SQ5                        \ [0x10 : 4] SQ5
    $14 constant ADC_SQ6                        \ [0x14 : 4] SQ6
    $18 constant ADC_SQ7                        \ [0x18 : 4] SQ7
    $1c constant ADC_SQ8                        \ [0x1c : 4] SQ8
  [then]


  [ifdef] ADC_ADC_AWD3TR_DEF
    \
    \ @brief ADC watchdog threshold register
    \ Address offset: 0x2C
    \ Reset value: 0x0FFF0000
    \
    $00 constant ADC_LT3                        \ [0x00 : 12] LT3
    $10 constant ADC_HT3                        \ [0x10 : 12] HT3
  [then]


  [ifdef] ADC_ADC_DR_DEF
    \
    \ @brief ADC data register
    \ Address offset: 0x40
    \ Reset value: 0x00000000
    \
    $00 constant ADC_DATA                       \ [0x00 : 16] DATA
  [then]


  [ifdef] ADC_ADC_AWD2CR_DEF
    \
    \ @brief ADC Analog Watchdog 2 Configuration register
    \ Address offset: 0xA0
    \ Reset value: 0x00000000
    \
    $00 constant ADC_AWD2CH                     \ [0x00 : 18] AWD2CH
  [then]


  [ifdef] ADC_ADC_AWD3CR_DEF
    \
    \ @brief ADC Analog Watchdog 3 Configuration register
    \ Address offset: 0xA4
    \ Reset value: 0x00000000
    \
    $00 constant ADC_AWD3CH                     \ [0x00 : 18] AWD3CH
  [then]


  [ifdef] ADC_ADC_CALFACT_DEF
    \
    \ @brief ADC Calibration factor
    \ Address offset: 0xB4
    \ Reset value: 0x00000000
    \
    $00 constant ADC_CALFACT                    \ [0x00 : 7] CALFACT
  [then]


  [ifdef] ADC_ADC_CCR_DEF
    \
    \ @brief ADC common configuration register
    \ Address offset: 0x308
    \ Reset value: 0x00000000
    \
    $12 constant ADC_PRESC0                     \ [0x12] PRESC0
    $13 constant ADC_PRESC1                     \ [0x13] PRESC1
    $14 constant ADC_PRESC2                     \ [0x14] PRESC2
    $15 constant ADC_PRESC3                     \ [0x15] PRESC3
    $16 constant ADC_VREFEN                     \ [0x16] VREFEN
    $17 constant ADC_TSEN                       \ [0x17] TSEN
    $18 constant ADC_VBATEN                     \ [0x18] VBATEN
  [then]

  \
  \ @brief Analog to digital convertor
  \
  $00 constant ADC_ADC_ISR              \ ADC interrupt and status register
  $04 constant ADC_ADC_IER              \ ADC interrupt enable register
  $08 constant ADC_ADC_CR               \ ADC control register
  $0C constant ADC_ADC_CFGR1            \ ADC configuration register 1
  $10 constant ADC_ADC_CFGR2            \ ADC configuration register 2
  $14 constant ADC_ADC_SMPR             \ ADC sampling time register
  $20 constant ADC_ADC_AWD1TR           \ ADC watchdog threshold register
  $24 constant ADC_ADC_AWD2TR           \ ADC watchdog threshold register
  $28 constant ADC_ADC_CHSELR0          \ channel selection register
  $28 constant ADC_ADC_CHSELR1          \ channel selection register
  $2C constant ADC_ADC_AWD3TR           \ ADC watchdog threshold register
  $40 constant ADC_ADC_DR               \ ADC data register
  $A0 constant ADC_ADC_AWD2CR           \ ADC Analog Watchdog 2 Configuration register
  $A4 constant ADC_ADC_AWD3CR           \ ADC Analog Watchdog 3 Configuration register
  $B4 constant ADC_ADC_CALFACT          \ ADC Calibration factor
  $308 constant ADC_ADC_CCR             \ ADC common configuration register

: ADC_DEF ; [then]
