\
\ @file adc3.fs
\ @brief ADC1 and ADC2 global interrupt
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief interrupt and status register
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000001 constant ADC3_ISR_ADRDY                                   \ ADRDY
$00000002 constant ADC3_ISR_EOSMP                                   \ EOSMP
$00000004 constant ADC3_ISR_EOC                                     \ EOC
$00000008 constant ADC3_ISR_EOS                                     \ EOS
$00000010 constant ADC3_ISR_OVR                                     \ OVR
$00000020 constant ADC3_ISR_JEOC                                    \ JEOC
$00000040 constant ADC3_ISR_JEOS                                    \ JEOS
$00000080 constant ADC3_ISR_AWD1                                    \ AWD1
$00000100 constant ADC3_ISR_AWD2                                    \ AWD2
$00000200 constant ADC3_ISR_AWD3                                    \ AWD3
$00000400 constant ADC3_ISR_JQOVF                                   \ JQOVF


\
\ @brief interrupt enable register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant ADC3_IER_ADRDYIE                                 \ ADRDYIE
$00000002 constant ADC3_IER_EOSMPIE                                 \ EOSMPIE
$00000004 constant ADC3_IER_EOCIE                                   \ EOCIE
$00000008 constant ADC3_IER_EOSIE                                   \ EOSIE
$00000010 constant ADC3_IER_OVRIE                                   \ OVRIE
$00000020 constant ADC3_IER_JEOCIE                                  \ JEOCIE
$00000040 constant ADC3_IER_JEOSIE                                  \ JEOSIE
$00000080 constant ADC3_IER_AWD1IE                                  \ AWD1IE
$00000100 constant ADC3_IER_AWD2IE                                  \ AWD2IE
$00000200 constant ADC3_IER_AWD3IE                                  \ AWD3IE
$00000400 constant ADC3_IER_JQOVFIE                                 \ JQOVFIE


\
\ @brief control register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000001 constant ADC3_CR_ADEN                                     \ ADEN
$00000002 constant ADC3_CR_ADDIS                                    \ ADDIS
$00000004 constant ADC3_CR_ADSTART                                  \ ADSTART
$00000008 constant ADC3_CR_JADSTART                                 \ JADSTART
$00000010 constant ADC3_CR_ADSTP                                    \ ADSTP
$00000020 constant ADC3_CR_JADSTP                                   \ JADSTP
$10000000 constant ADC3_CR_ADVREGEN                                 \ ADVREGEN
$20000000 constant ADC3_CR_DEEPPWD                                  \ DEEPPWD
$40000000 constant ADC3_CR_ADCALDIF                                 \ ADCALDIF
$80000000 constant ADC3_CR_ADCAL                                    \ ADCAL


\
\ @brief configuration register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000001 constant ADC3_CFGR_DMAEN                                  \ DMAEN
$00000002 constant ADC3_CFGR_DMACFG                                 \ DMACFG
$00000004 constant ADC3_CFGR_DFSDMCFG                               \ DFSDMCFG
$00000018 constant ADC3_CFGR_RES                                    \ RES
$00000020 constant ADC3_CFGR_ALIGN                                  \ ALIGN
$000003c0 constant ADC3_CFGR_EXTSEL                                 \ EXTSEL
$00000c00 constant ADC3_CFGR_EXTEN                                  \ EXTEN
$00001000 constant ADC3_CFGR_OVRMOD                                 \ OVRMOD
$00002000 constant ADC3_CFGR_CONT                                   \ CONT
$00004000 constant ADC3_CFGR_AUTDLY                                 \ AUTDLY
$00010000 constant ADC3_CFGR_DISCEN                                 \ DISCEN
$000e0000 constant ADC3_CFGR_DISCNUM                                \ DISCNUM
$00100000 constant ADC3_CFGR_JDISCEN                                \ JDISCEN
$00200000 constant ADC3_CFGR_JQM                                    \ JQM
$00400000 constant ADC3_CFGR_AWD1SGL                                \ AWD1SGL
$00800000 constant ADC3_CFGR_AWD1EN                                 \ AWD1EN
$01000000 constant ADC3_CFGR_JAWD1EN                                \ JAWD1EN
$02000000 constant ADC3_CFGR_JAUTO                                  \ JAUTO
$7c000000 constant ADC3_CFGR_AWDCH1CH                               \ AWDCH1CH
$80000000 constant ADC3_CFGR_JQDIS                                  \ Injected Queue disable


\
\ @brief configuration register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000001 constant ADC3_CFGR2_ROVSE                                 \ DMAEN
$00000002 constant ADC3_CFGR2_JOVSE                                 \ DMACFG
$0000001c constant ADC3_CFGR2_OVSR                                  \ RES
$000001e0 constant ADC3_CFGR2_OVSS                                  \ ALIGN
$00000200 constant ADC3_CFGR2_TROVS                                 \ Triggered Regular Oversampling
$00000400 constant ADC3_CFGR2_ROVSM                                 \ EXTEN


\
\ @brief sample time register 1
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000007 constant ADC3_SMPR1_SMP0                                  \ SMP0
$00000038 constant ADC3_SMPR1_SMP1                                  \ SMP1
$000001c0 constant ADC3_SMPR1_SMP2                                  \ SMP2
$00000e00 constant ADC3_SMPR1_SMP3                                  \ SMP3
$00007000 constant ADC3_SMPR1_SMP4                                  \ SMP4
$00038000 constant ADC3_SMPR1_SMP5                                  \ SMP5
$001c0000 constant ADC3_SMPR1_SMP6                                  \ SMP6
$00e00000 constant ADC3_SMPR1_SMP7                                  \ SMP7
$07000000 constant ADC3_SMPR1_SMP8                                  \ SMP8
$38000000 constant ADC3_SMPR1_SMP9                                  \ SMP9
$80000000 constant ADC3_SMPR1_SMPPLUS                               \ Addition of one clock cycle to the sampling time


\
\ @brief sample time register 2
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000007 constant ADC3_SMPR2_SMP10                                 \ SMP10
$00000038 constant ADC3_SMPR2_SMP11                                 \ SMP11
$000001c0 constant ADC3_SMPR2_SMP12                                 \ SMP12
$00000e00 constant ADC3_SMPR2_SMP13                                 \ SMP13
$00007000 constant ADC3_SMPR2_SMP14                                 \ SMP14
$00038000 constant ADC3_SMPR2_SMP15                                 \ SMP15
$001c0000 constant ADC3_SMPR2_SMP16                                 \ SMP16
$00e00000 constant ADC3_SMPR2_SMP17                                 \ SMP17
$07000000 constant ADC3_SMPR2_SMP18                                 \ SMP18


\
\ @brief watchdog threshold register 1
\ Address offset: 0x20
\ Reset value: 0x0FFF0000
\

$00000fff constant ADC3_TR1_LT1                                     \ LT1
$0fff0000 constant ADC3_TR1_HT1                                     \ HT1


\
\ @brief watchdog threshold register
\ Address offset: 0x24
\ Reset value: 0x0FFF0000
\

$000000ff constant ADC3_TR2_LT2                                     \ LT2
$00ff0000 constant ADC3_TR2_HT2                                     \ HT2


\
\ @brief watchdog threshold register 3
\ Address offset: 0x28
\ Reset value: 0x0FFF0000
\

$000000ff constant ADC3_TR3_LT3                                     \ LT3
$00ff0000 constant ADC3_TR3_HT3                                     \ HT3


\
\ @brief regular sequence register 1
\ Address offset: 0x30
\ Reset value: 0x00000000
\

$0000000f constant ADC3_SQR1_L                                      \ Regular channel sequence length
$000007c0 constant ADC3_SQR1_SQ1                                    \ SQ1
$0001f000 constant ADC3_SQR1_SQ2                                    \ SQ2
$007c0000 constant ADC3_SQR1_SQ3                                    \ SQ3
$1f000000 constant ADC3_SQR1_SQ4                                    \ SQ4


\
\ @brief regular sequence register 2
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$0000001f constant ADC3_SQR2_SQ5                                    \ SQ5
$000007c0 constant ADC3_SQR2_SQ6                                    \ SQ6
$0001f000 constant ADC3_SQR2_SQ7                                    \ SQ7
$007c0000 constant ADC3_SQR2_SQ8                                    \ SQ8
$1f000000 constant ADC3_SQR2_SQ9                                    \ SQ9


\
\ @brief regular sequence register 3
\ Address offset: 0x38
\ Reset value: 0x00000000
\

$0000001f constant ADC3_SQR3_SQ10                                   \ SQ10
$000007c0 constant ADC3_SQR3_SQ11                                   \ SQ11
$0001f000 constant ADC3_SQR3_SQ12                                   \ SQ12
$007c0000 constant ADC3_SQR3_SQ13                                   \ SQ13
$1f000000 constant ADC3_SQR3_SQ14                                   \ SQ14


\
\ @brief regular sequence register 4
\ Address offset: 0x3C
\ Reset value: 0x00000000
\

$0000001f constant ADC3_SQR4_SQ15                                   \ SQ15
$000007c0 constant ADC3_SQR4_SQ16                                   \ SQ16


\
\ @brief regular Data Register
\ Address offset: 0x40
\ Reset value: 0x00000000
\

$0000ffff constant ADC3_DR_RDATA                                    \ Regular Data converted


\
\ @brief injected sequence register
\ Address offset: 0x4C
\ Reset value: 0x00000000
\

$00000003 constant ADC3_JSQR_JL                                     \ JL
$0000003c constant ADC3_JSQR_JEXTSEL                                \ JEXTSEL
$000000c0 constant ADC3_JSQR_JEXTEN                                 \ JEXTEN
$00001f00 constant ADC3_JSQR_JSQ1                                   \ JSQ1
$0007c000 constant ADC3_JSQR_JSQ2                                   \ JSQ2
$01f00000 constant ADC3_JSQR_JSQ3                                   \ JSQ3
$7c000000 constant ADC3_JSQR_JSQ4                                   \ JSQ4


\
\ @brief offset register 1
\ Address offset: 0x60
\ Reset value: 0x00000000
\

$00000fff constant ADC3_OFR1_OFFSET1                                \ OFFSET1
$7c000000 constant ADC3_OFR1_OFFSET1_CH                             \ OFFSET1_CH
$80000000 constant ADC3_OFR1_OFFSET1_EN                             \ OFFSET1_EN


\
\ @brief offset register 2
\ Address offset: 0x64
\ Reset value: 0x00000000
\

$00000fff constant ADC3_OFR2_OFFSET2                                \ OFFSET2
$7c000000 constant ADC3_OFR2_OFFSET2_CH                             \ OFFSET2_CH
$80000000 constant ADC3_OFR2_OFFSET2_EN                             \ OFFSET2_EN


\
\ @brief offset register 3
\ Address offset: 0x68
\ Reset value: 0x00000000
\

$00000fff constant ADC3_OFR3_OFFSET3                                \ OFFSET3
$7c000000 constant ADC3_OFR3_OFFSET3_CH                             \ OFFSET3_CH
$80000000 constant ADC3_OFR3_OFFSET3_EN                             \ OFFSET3_EN


\
\ @brief offset register 4
\ Address offset: 0x6C
\ Reset value: 0x00000000
\

$00000fff constant ADC3_OFR4_OFFSET4                                \ OFFSET4
$7c000000 constant ADC3_OFR4_OFFSET4_CH                             \ OFFSET4_CH
$80000000 constant ADC3_OFR4_OFFSET4_EN                             \ OFFSET4_EN


\
\ @brief injected data register 1
\ Address offset: 0x80
\ Reset value: 0x00000000
\

$0000ffff constant ADC3_JDR1_JDATA1                                 \ JDATA1


\
\ @brief injected data register 2
\ Address offset: 0x84
\ Reset value: 0x00000000
\

$0000ffff constant ADC3_JDR2_JDATA2                                 \ JDATA2


\
\ @brief injected data register 3
\ Address offset: 0x88
\ Reset value: 0x00000000
\

$0000ffff constant ADC3_JDR3_JDATA3                                 \ JDATA3


\
\ @brief injected data register 4
\ Address offset: 0x8C
\ Reset value: 0x00000000
\

$0000ffff constant ADC3_JDR4_JDATA4                                 \ JDATA4


\
\ @brief Analog Watchdog 2 Configuration Register
\ Address offset: 0xA0
\ Reset value: 0x00000000
\

$0007ffff constant ADC3_AWD2CR_AWD2CH                               \ AWD2CH


\
\ @brief Analog Watchdog 3 Configuration Register
\ Address offset: 0xA4
\ Reset value: 0x00000000
\

$0007ffff constant ADC3_AWD3CR_AWD3CH                               \ AWD3CH


\
\ @brief Differential Mode Selection Register 2
\ Address offset: 0xB0
\ Reset value: 0x00000000
\

$00000001 constant ADC3_DIFSEL_DIFSEL_0                             \ Differential mode for channels 0
$0000fffe constant ADC3_DIFSEL_DIFSEL_1_15                          \ Differential mode for channels 15 to 1
$00070000 constant ADC3_DIFSEL_DIFSEL_16_18                         \ Differential mode for channels 18 to 16


\
\ @brief Calibration Factors
\ Address offset: 0xB4
\ Reset value: 0x00000000
\

$0000007f constant ADC3_CALFACT_CALFACT_S                           \ CALFACT_S
$007f0000 constant ADC3_CALFACT_CALFACT_D                           \ CALFACT_D


\
\ @brief ADC1 and ADC2 global interrupt
\
$50040200 constant ADC3_ISR       \ offset: 0x00 : interrupt and status register
$50040204 constant ADC3_IER       \ offset: 0x04 : interrupt enable register
$50040208 constant ADC3_CR        \ offset: 0x08 : control register
$5004020c constant ADC3_CFGR      \ offset: 0x0C : configuration register
$50040210 constant ADC3_CFGR2     \ offset: 0x10 : configuration register
$50040214 constant ADC3_SMPR1     \ offset: 0x14 : sample time register 1
$50040218 constant ADC3_SMPR2     \ offset: 0x18 : sample time register 2
$50040220 constant ADC3_TR1       \ offset: 0x20 : watchdog threshold register 1
$50040224 constant ADC3_TR2       \ offset: 0x24 : watchdog threshold register
$50040228 constant ADC3_TR3       \ offset: 0x28 : watchdog threshold register 3
$50040230 constant ADC3_SQR1      \ offset: 0x30 : regular sequence register 1
$50040234 constant ADC3_SQR2      \ offset: 0x34 : regular sequence register 2
$50040238 constant ADC3_SQR3      \ offset: 0x38 : regular sequence register 3
$5004023c constant ADC3_SQR4      \ offset: 0x3C : regular sequence register 4
$50040240 constant ADC3_DR        \ offset: 0x40 : regular Data Register
$5004024c constant ADC3_JSQR      \ offset: 0x4C : injected sequence register
$50040260 constant ADC3_OFR1      \ offset: 0x60 : offset register 1
$50040264 constant ADC3_OFR2      \ offset: 0x64 : offset register 2
$50040268 constant ADC3_OFR3      \ offset: 0x68 : offset register 3
$5004026c constant ADC3_OFR4      \ offset: 0x6C : offset register 4
$50040280 constant ADC3_JDR1      \ offset: 0x80 : injected data register 1
$50040284 constant ADC3_JDR2      \ offset: 0x84 : injected data register 2
$50040288 constant ADC3_JDR3      \ offset: 0x88 : injected data register 3
$5004028c constant ADC3_JDR4      \ offset: 0x8C : injected data register 4
$500402a0 constant ADC3_AWD2CR    \ offset: 0xA0 : Analog Watchdog 2 Configuration Register
$500402a4 constant ADC3_AWD3CR    \ offset: 0xA4 : Analog Watchdog 3 Configuration Register
$500402b0 constant ADC3_DIFSEL    \ offset: 0xB0 : Differential Mode Selection Register 2
$500402b4 constant ADC3_CALFACT   \ offset: 0xB4 : Calibration Factors

