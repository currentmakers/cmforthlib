\
\ @file adc.fs
\ @brief Analog to Digital Converter
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief ADC interrupt and status register
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000001 constant ADC_ISR_ADRDY                                    \ ADRDY
$00000002 constant ADC_ISR_EOSMP                                    \ EOSMP
$00000004 constant ADC_ISR_EOC                                      \ EOC
$00000008 constant ADC_ISR_EOS                                      \ EOS
$00000010 constant ADC_ISR_OVR                                      \ OVR
$00000080 constant ADC_ISR_AWD1                                     \ AWD1
$00000100 constant ADC_ISR_AWD2                                     \ AWD2
$00000200 constant ADC_ISR_AWD3                                     \ AWD3
$00000800 constant ADC_ISR_EOCAL                                    \ EOCAL
$00002000 constant ADC_ISR_CCRDY                                    \ CCRDY


\
\ @brief ADC interrupt enable register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant ADC_IER_ADRDYIE                                  \ ADRDYIE
$00000002 constant ADC_IER_EOSMPIE                                  \ EOSMPIE
$00000004 constant ADC_IER_EOCIE                                    \ EOCIE
$00000008 constant ADC_IER_EOSIE                                    \ EOSIE
$00000010 constant ADC_IER_OVRIE                                    \ OVRIE
$00000080 constant ADC_IER_AWD1IE                                   \ AWD1IE
$00000100 constant ADC_IER_AWD2IE                                   \ AWD2IE
$00000200 constant ADC_IER_AWD3IE                                   \ AWD3IE
$00000800 constant ADC_IER_EOCALIE                                  \ EOCALIE
$00002000 constant ADC_IER_CCRDYIE                                  \ CCRDYIE


\
\ @brief ADC control register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000001 constant ADC_CR_ADEN                                      \ ADEN
$00000002 constant ADC_CR_ADDIS                                     \ ADDIS
$00000004 constant ADC_CR_ADSTART                                   \ ADSTART
$00000010 constant ADC_CR_ADSTP                                     \ ADSTP
$10000000 constant ADC_CR_ADVREGEN                                  \ ADVREGEN
$80000000 constant ADC_CR_ADCAL                                     \ ADCAL


\
\ @brief ADC configuration register 1
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000001 constant ADC_CFGR1_DMAEN                                  \ DMAEN
$00000002 constant ADC_CFGR1_DMACFG                                 \ DMACFG
$00000004 constant ADC_CFGR1_SCANDIR                                \ SCANDIR
$00000018 constant ADC_CFGR1_RES                                    \ RES
$00000020 constant ADC_CFGR1_ALIGN                                  \ ALIGN
$000001c0 constant ADC_CFGR1_EXTSEL                                 \ EXTSEL
$00000c00 constant ADC_CFGR1_EXTEN                                  \ EXTEN
$00001000 constant ADC_CFGR1_OVRMOD                                 \ OVRMOD
$00002000 constant ADC_CFGR1_CONT                                   \ CONT
$00004000 constant ADC_CFGR1_WAIT                                   \ WAIT
$00008000 constant ADC_CFGR1_AUTOFF                                 \ AUTOFF
$00010000 constant ADC_CFGR1_DISCEN                                 \ DISCEN
$00200000 constant ADC_CFGR1_CHSELRMOD                              \ CHSELRMOD
$00400000 constant ADC_CFGR1_AWD1SGL                                \ AWD1SGL
$00800000 constant ADC_CFGR1_AWD1EN                                 \ AWD1EN
$7c000000 constant ADC_CFGR1_AWDCH                                  \ AWD1CH


\
\ @brief ADC configuration register 2
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000001 constant ADC_CFGR2_OVSE                                   \ OVSE
$0000001c constant ADC_CFGR2_OVSR                                   \ OVSR
$000001e0 constant ADC_CFGR2_OVSS                                   \ OVSS
$00000200 constant ADC_CFGR2_TOVS                                   \ TOVS
$20000000 constant ADC_CFGR2_LFTRIG                                 \ LFTRIG
$c0000000 constant ADC_CFGR2_CKMODE                                 \ CKMODE


\
\ @brief ADC sampling time register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000007 constant ADC_SMPR_SMP1                                    \ SMP1
$00000070 constant ADC_SMPR_SMP2                                    \ SMP2
$07ffff00 constant ADC_SMPR_SMPSEL                                  \ SMPSEL


\
\ @brief ADC watchdog threshold register
\ Address offset: 0x20
\ Reset value: 0x0FFF0000
\

$00000fff constant ADC_AWD1TR_LT1                                   \ LT1
$0fff0000 constant ADC_AWD1TR_HT1                                   \ HT1


\
\ @brief ADC watchdog threshold register
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$00000fff constant ADC_AWD2TR_LT2                                   \ LT2
$0fff0000 constant ADC_AWD2TR_HT2                                   \ HT2


\
\ @brief channel selection register
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$0007ffff constant ADC_CHSELR0_CHSEL                                \ CHSEL


\
\ @brief channel selection register
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$0000000f constant ADC_CHSELR1_SQ1                                  \ SQ1
$000000f0 constant ADC_CHSELR1_SQ2                                  \ SQ2
$00000f00 constant ADC_CHSELR1_SQ3                                  \ SQ3
$0000f000 constant ADC_CHSELR1_SQ4                                  \ SQ4
$000f0000 constant ADC_CHSELR1_SQ5                                  \ SQ5
$00f00000 constant ADC_CHSELR1_SQ6                                  \ SQ6
$0f000000 constant ADC_CHSELR1_SQ7                                  \ SQ7
$f0000000 constant ADC_CHSELR1_SQ8                                  \ SQ8


\
\ @brief ADC watchdog threshold register
\ Address offset: 0x2C
\ Reset value: 0x0FFF0000
\

$00000fff constant ADC_AWD3TR_LT3                                   \ LT3
$0fff0000 constant ADC_AWD3TR_HT3                                   \ HT3


\
\ @brief ADC data register
\ Address offset: 0x40
\ Reset value: 0x00000000
\

$0000ffff constant ADC_DR_DATA                                      \ DATA


\
\ @brief ADC Analog Watchdog 2 Configuration register
\ Address offset: 0xA0
\ Reset value: 0x00000000
\

$0007ffff constant ADC_AWD2CR_AWD2CH                                \ AWD2CH


\
\ @brief ADC Analog Watchdog 3 Configuration register
\ Address offset: 0xA4
\ Reset value: 0x00000000
\

$0007ffff constant ADC_AWD3CR_AWD3CH                                \ AWD3CH


\
\ @brief ADC Calibration factor
\ Address offset: 0xB4
\ Reset value: 0x00000000
\

$0000007f constant ADC_CALFACT_CALFACT                              \ CALFACT


\
\ @brief ADC common configuration register
\ Address offset: 0x308
\ Reset value: 0x00000000
\

$003c0000 constant ADC_CCR_PRESC                                    \ PRESC
$00400000 constant ADC_CCR_VREFEN                                   \ VREFEN
$00800000 constant ADC_CCR_TSEN                                     \ TSEN
$01000000 constant ADC_CCR_VBATEN                                   \ VBATEN


\
\ @brief Analog to Digital Converter
\
$40012400 constant ADC_ISR        \ offset: 0x00 : ADC interrupt and status register
$40012404 constant ADC_IER        \ offset: 0x04 : ADC interrupt enable register
$40012408 constant ADC_CR         \ offset: 0x08 : ADC control register
$4001240c constant ADC_CFGR1      \ offset: 0x0C : ADC configuration register 1
$40012410 constant ADC_CFGR2      \ offset: 0x10 : ADC configuration register 2
$40012414 constant ADC_SMPR       \ offset: 0x14 : ADC sampling time register
$40012420 constant ADC_AWD1TR     \ offset: 0x20 : ADC watchdog threshold register
$40012424 constant ADC_AWD2TR     \ offset: 0x24 : ADC watchdog threshold register
$40012428 constant ADC_CHSELR0    \ offset: 0x28 : channel selection register
$40012428 constant ADC_CHSELR1    \ offset: 0x28 : channel selection register
$4001242c constant ADC_AWD3TR     \ offset: 0x2C : ADC watchdog threshold register
$40012440 constant ADC_DR         \ offset: 0x40 : ADC data register
$400124a0 constant ADC_AWD2CR     \ offset: 0xA0 : ADC Analog Watchdog 2 Configuration register
$400124a4 constant ADC_AWD3CR     \ offset: 0xA4 : ADC Analog Watchdog 3 Configuration register
$400124b4 constant ADC_CALFACT    \ offset: 0xB4 : ADC Calibration factor
$40012708 constant ADC_CCR        \ offset: 0x308 : ADC common configuration register

