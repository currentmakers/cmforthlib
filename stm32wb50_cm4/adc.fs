\
\ @file adc.fs
\ @brief Analog to Digital Converter instance       1
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

$00000001 constant ADC_ISR_ADRDY                                    \ ADC ready flag
$00000002 constant ADC_ISR_EOSMP                                    \ ADC group regular end of sampling flag
$00000004 constant ADC_ISR_EOC                                      \ ADC group regular end of unitary conversion flag
$00000008 constant ADC_ISR_EOS                                      \ ADC group regular end of sequence conversions flag
$00000010 constant ADC_ISR_OVR                                      \ ADC group regular overrun flag
$00000020 constant ADC_ISR_JEOC                                     \ ADC group injected end of unitary conversion flag
$00000040 constant ADC_ISR_JEOS                                     \ ADC group injected end of sequence conversions flag
$00000080 constant ADC_ISR_AWD1                                     \ ADC analog watchdog 1 flag
$00000100 constant ADC_ISR_AWD2                                     \ ADC analog watchdog 2 flag
$00000200 constant ADC_ISR_AWD3                                     \ ADC analog watchdog 3 flag
$00000400 constant ADC_ISR_JQOVF                                    \ ADC group injected contexts queue overflow flag


\
\ @brief ADC interrupt enable register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant ADC_IER_ADRDYIE                                  \ ADC ready interrupt
$00000002 constant ADC_IER_EOSMPIE                                  \ ADC group regular end of sampling interrupt
$00000004 constant ADC_IER_EOCIE                                    \ ADC group regular end of unitary conversion interrupt
$00000008 constant ADC_IER_EOSIE                                    \ ADC group regular end of sequence conversions interrupt
$00000010 constant ADC_IER_OVRIE                                    \ ADC group regular overrun interrupt
$00000020 constant ADC_IER_JEOCIE                                   \ ADC group injected end of unitary conversion interrupt
$00000040 constant ADC_IER_JEOSIE                                   \ ADC group injected end of sequence conversions interrupt
$00000080 constant ADC_IER_AWD1IE                                   \ ADC analog watchdog 1 interrupt
$00000100 constant ADC_IER_AWD2IE                                   \ ADC analog watchdog 2 interrupt
$00000200 constant ADC_IER_AWD3IE                                   \ ADC analog watchdog 3 interrupt
$00000400 constant ADC_IER_JQOVFIE                                  \ ADC group injected contexts queue overflow interrupt


\
\ @brief ADC control register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000001 constant ADC_CR_ADEN                                      \ ADC enable
$00000002 constant ADC_CR_ADDIS                                     \ ADC disable
$00000004 constant ADC_CR_ADSTART                                   \ ADC group regular conversion start
$00000008 constant ADC_CR_JADSTART                                  \ ADC group injected conversion start
$00000010 constant ADC_CR_ADSTP                                     \ ADC group regular conversion stop
$00000020 constant ADC_CR_JADSTP                                    \ ADC group injected conversion stop
$10000000 constant ADC_CR_ADVREGEN                                  \ ADC voltage regulator enable
$20000000 constant ADC_CR_DEEPPWD                                   \ ADC deep power down enable
$40000000 constant ADC_CR_ADCALDIF                                  \ ADC differential mode for calibration
$80000000 constant ADC_CR_ADCAL                                     \ ADC calibration


\
\ @brief ADC configuration register 1
\ Address offset: 0x0C
\ Reset value: 0x80000000
\

$00000001 constant ADC_CFGR_DMAEN                                   \ ADC DMA transfer enable
$00000002 constant ADC_CFGR_DMACFG                                  \ ADC DMA transfer configuration
$00000018 constant ADC_CFGR_RES                                     \ ADC data resolution
$00000020 constant ADC_CFGR_ALIGN                                   \ ADC data alignement
$000003c0 constant ADC_CFGR_EXTSEL                                  \ ADC group regular external trigger source
$00000c00 constant ADC_CFGR_EXTEN                                   \ ADC group regular external trigger polarity
$00001000 constant ADC_CFGR_OVRMOD                                  \ ADC group regular overrun configuration
$00002000 constant ADC_CFGR_CONT                                    \ ADC group regular continuous conversion mode
$00004000 constant ADC_CFGR_AUTDLY                                  \ ADC low power auto wait
$00010000 constant ADC_CFGR_DISCEN                                  \ ADC group regular sequencer discontinuous mode
$000e0000 constant ADC_CFGR_DISCNUM                                 \ ADC group regular sequencer discontinuous number of ranks
$00100000 constant ADC_CFGR_JDISCEN                                 \ ADC group injected sequencer discontinuous mode
$00200000 constant ADC_CFGR_JQM                                     \ ADC group injected contexts queue mode
$00400000 constant ADC_CFGR_AWD1SGL                                 \ ADC analog watchdog 1 monitoring a single channel or all channels
$00800000 constant ADC_CFGR_AWD1EN                                  \ ADC analog watchdog 1 enable on scope ADC group regular
$01000000 constant ADC_CFGR_JAWD1EN                                 \ ADC analog watchdog 1 enable on scope ADC group injected
$02000000 constant ADC_CFGR_JAUTO                                   \ ADC group injected automatic trigger mode
$7c000000 constant ADC_CFGR_AWDCH1CH                                \ ADC analog watchdog 1 monitored channel selection
$80000000 constant ADC_CFGR_JQDIS                                   \ ADC group injected contexts queue disable


\
\ @brief ADC configuration register 2
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000001 constant ADC_CFGR2_ROVSE                                  \ ADC oversampler enable on scope ADC group regular
$00000002 constant ADC_CFGR2_JOVSE                                  \ ADC oversampler enable on scope ADC group injected
$0000001c constant ADC_CFGR2_OVSR                                   \ ADC oversampling ratio
$000001e0 constant ADC_CFGR2_OVSS                                   \ ADC oversampling shift
$00000200 constant ADC_CFGR2_TOVS                                   \ ADC oversampling discontinuous mode (triggered mode) for ADC group regular
$00000400 constant ADC_CFGR2_ROVSM                                  \ ADC oversampling mode managing interlaced conversions of ADC group regular and group injected


\
\ @brief ADC sampling time register 1
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000038 constant ADC_SMPR1_SMP1                                   \ ADC channel 1 sampling time selection
$000001c0 constant ADC_SMPR1_SMP2                                   \ ADC channel 2 sampling time selection
$00000e00 constant ADC_SMPR1_SMP3                                   \ ADC channel 3 sampling time selection
$00007000 constant ADC_SMPR1_SMP4                                   \ ADC channel 4 sampling time selection
$00038000 constant ADC_SMPR1_SMP5                                   \ ADC channel 5 sampling time selection
$001c0000 constant ADC_SMPR1_SMP6                                   \ ADC channel 6 sampling time selection
$00e00000 constant ADC_SMPR1_SMP7                                   \ ADC channel 7 sampling time selection
$07000000 constant ADC_SMPR1_SMP8                                   \ ADC channel 8 sampling time selection
$38000000 constant ADC_SMPR1_SMP9                                   \ ADC channel 9 sampling time selection


\
\ @brief ADC sampling time register 2
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000007 constant ADC_SMPR2_SMP10                                  \ ADC channel 10 sampling time selection
$00000038 constant ADC_SMPR2_SMP11                                  \ ADC channel 11 sampling time selection
$000001c0 constant ADC_SMPR2_SMP12                                  \ ADC channel 12 sampling time selection
$00000e00 constant ADC_SMPR2_SMP13                                  \ ADC channel 13 sampling time selection
$00007000 constant ADC_SMPR2_SMP14                                  \ ADC channel 14 sampling time selection
$00038000 constant ADC_SMPR2_SMP15                                  \ ADC channel 15 sampling time selection
$001c0000 constant ADC_SMPR2_SMP16                                  \ ADC channel 16 sampling time selection
$00e00000 constant ADC_SMPR2_SMP17                                  \ ADC channel 17 sampling time selection
$07000000 constant ADC_SMPR2_SMP18                                  \ ADC channel 18 sampling time selection


\
\ @brief ADC analog watchdog 1 threshold register
\ Address offset: 0x20
\ Reset value: 0x0FFF0000
\

$00000fff constant ADC_TR1_LT1                                      \ ADC analog watchdog 1 threshold low
$0fff0000 constant ADC_TR1_HT1                                      \ ADC analog watchdog 1 threshold high


\
\ @brief ADC analog watchdog 2 threshold register
\ Address offset: 0x24
\ Reset value: 0x0FFF0000
\

$000000ff constant ADC_TR2_LT2                                      \ ADC analog watchdog 2 threshold low
$00ff0000 constant ADC_TR2_HT2                                      \ ADC analog watchdog 2 threshold high


\
\ @brief ADC analog watchdog 3 threshold register
\ Address offset: 0x28
\ Reset value: 0x0FFF0000
\

$000000ff constant ADC_TR3_LT3                                      \ ADC analog watchdog 3 threshold low
$00ff0000 constant ADC_TR3_HT3                                      \ ADC analog watchdog 3 threshold high


\
\ @brief ADC group regular sequencer ranks register 1
\ Address offset: 0x30
\ Reset value: 0x00000000
\

$0000000f constant ADC_SQR1_L3                                      \ L3
$000007c0 constant ADC_SQR1_SQ1                                     \ ADC group regular sequencer rank 1
$0001f000 constant ADC_SQR1_SQ2                                     \ ADC group regular sequencer rank 2
$007c0000 constant ADC_SQR1_SQ3                                     \ ADC group regular sequencer rank 3
$1f000000 constant ADC_SQR1_SQ4                                     \ ADC group regular sequencer rank 4


\
\ @brief ADC group regular sequencer ranks register 2
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$0000001f constant ADC_SQR2_SQ5                                     \ ADC group regular sequencer rank 5
$000007c0 constant ADC_SQR2_SQ6                                     \ ADC group regular sequencer rank 6
$0001f000 constant ADC_SQR2_SQ7                                     \ ADC group regular sequencer rank 7
$007c0000 constant ADC_SQR2_SQ8                                     \ ADC group regular sequencer rank 8
$1f000000 constant ADC_SQR2_SQ9                                     \ ADC group regular sequencer rank 9


\
\ @brief ADC group regular sequencer ranks register 3
\ Address offset: 0x38
\ Reset value: 0x00000000
\

$0000001f constant ADC_SQR3_SQ10                                    \ ADC group regular sequencer rank 10
$000007c0 constant ADC_SQR3_SQ11                                    \ ADC group regular sequencer rank 11
$0001f000 constant ADC_SQR3_SQ12                                    \ ADC group regular sequencer rank 12
$007c0000 constant ADC_SQR3_SQ13                                    \ ADC group regular sequencer rank 13
$1f000000 constant ADC_SQR3_SQ14                                    \ ADC group regular sequencer rank 14


\
\ @brief ADC group regular sequencer ranks register 4
\ Address offset: 0x3C
\ Reset value: 0x00000000
\

$0000001f constant ADC_SQR4_SQ15                                    \ ADC group regular sequencer rank 15
$000007c0 constant ADC_SQR4_SQ16                                    \ ADC group regular sequencer rank 16


\
\ @brief ADC group regular conversion data register
\ Address offset: 0x40
\ Reset value: 0x00000000
\

$0000003f constant ADC_DR_RDATA_0_6                                 \ Regular Data converted 0_6
$0000ff80 constant ADC_DR_RDATA_7_15                                \ 15


\
\ @brief ADC group injected sequencer register
\ Address offset: 0x4C
\ Reset value: 0x00000000
\

$00000003 constant ADC_JSQR_JL                                      \ ADC group injected sequencer scan length
$0000003c constant ADC_JSQR_JEXTSEL                                 \ ADC group injected external trigger source
$000000c0 constant ADC_JSQR_JEXTEN                                  \ ADC group injected external trigger polarity
$00001f00 constant ADC_JSQR_JSQ1                                    \ ADC group injected sequencer rank 1
$0007c000 constant ADC_JSQR_JSQ2                                    \ ADC group injected sequencer rank 2
$01f00000 constant ADC_JSQR_JSQ3                                    \ ADC group injected sequencer rank 3
$7c000000 constant ADC_JSQR_JSQ4                                    \ ADC group injected sequencer rank 4


\
\ @brief ADC offset number 1 register
\ Address offset: 0x60
\ Reset value: 0x00000000
\

$00000fff constant ADC_OFR1_OFFSET1                                 \ ADC offset number 1 offset level
$7c000000 constant ADC_OFR1_OFFSET1_CH                              \ ADC offset number 1 channel selection
$80000000 constant ADC_OFR1_OFFSET1_EN                              \ ADC offset number 1 enable


\
\ @brief ADC offset number 2 register
\ Address offset: 0x64
\ Reset value: 0x00000000
\

$00000fff constant ADC_OFR2_OFFSET2                                 \ ADC offset number 2 offset level
$7c000000 constant ADC_OFR2_OFFSET2_CH                              \ ADC offset number 2 channel selection
$80000000 constant ADC_OFR2_OFFSET2_EN                              \ ADC offset number 2 enable


\
\ @brief ADC offset number 3 register
\ Address offset: 0x68
\ Reset value: 0x00000000
\

$00000fff constant ADC_OFR3_OFFSET3                                 \ ADC offset number 3 offset level
$7c000000 constant ADC_OFR3_OFFSET3_CH                              \ ADC offset number 3 channel selection
$80000000 constant ADC_OFR3_OFFSET3_EN                              \ ADC offset number 3 enable


\
\ @brief ADC offset number 4 register
\ Address offset: 0x6C
\ Reset value: 0x00000000
\

$00000fff constant ADC_OFR4_OFFSET4                                 \ ADC offset number 4 offset level
$7c000000 constant ADC_OFR4_OFFSET4_CH                              \ ADC offset number 4 channel selection
$80000000 constant ADC_OFR4_OFFSET4_EN                              \ ADC offset number 4 enable


\
\ @brief ADC group injected sequencer rank 1 register
\ Address offset: 0x80
\ Reset value: 0x00000000
\

$0000ffff constant ADC_JDR1_JDATA1                                  \ ADC group injected sequencer rank 1 conversion data


\
\ @brief ADC group injected sequencer rank 2 register
\ Address offset: 0x84
\ Reset value: 0x00000000
\

$0000ffff constant ADC_JDR2_JDATA2                                  \ ADC group injected sequencer rank 2 conversion data


\
\ @brief ADC group injected sequencer rank 3 register
\ Address offset: 0x88
\ Reset value: 0x00000000
\

$0000ffff constant ADC_JDR3_JDATA3                                  \ ADC group injected sequencer rank 3 conversion data


\
\ @brief ADC group injected sequencer rank 4 register
\ Address offset: 0x8C
\ Reset value: 0x00000000
\

$0000ffff constant ADC_JDR4_JDATA4                                  \ ADC group injected sequencer rank 4 conversion data


\
\ @brief ADC analog watchdog 2 configuration register
\ Address offset: 0xA0
\ Reset value: 0x00000000
\

$0007ffff constant ADC_AWD2CR_AWD2CH                                \ ADC analog watchdog 2 monitored channel selection


\
\ @brief ADC analog watchdog 3 configuration register
\ Address offset: 0xA4
\ Reset value: 0x00000000
\

$0007ffff constant ADC_AWD3CR_AWD3CH                                \ ADC analog watchdog 3 monitored channel selection


\
\ @brief ADC channel differential or single-ended mode selection register
\ Address offset: 0xB0
\ Reset value: 0x00000000
\

$00000001 constant ADC_DIFSEL_DIFSEL_0                              \ ADC channel differential or single-ended mode for channel 0
$0000fffe constant ADC_DIFSEL_DIFSEL_1_15                           \ ADC channel differential or single-ended mode for channels 1 to 15
$00070000 constant ADC_DIFSEL_DIFSEL_16_18                          \ ADC channel differential or single-ended mode for channels 18 to 16


\
\ @brief ADC calibration factors register
\ Address offset: 0xB4
\ Reset value: 0x00000000
\

$0000007f constant ADC_CALFACT_CALFACT_S                            \ ADC calibration factor in single-ended mode
$007f0000 constant ADC_CALFACT_CALFACT_D                            \ ADC calibration factor in differential mode


\
\ @brief ADC common control register
\ Address offset: 0x308
\ Reset value: 0x00000000
\

$00030000 constant ADC_CCR_CKMODE                                   \ ADC clock mode
$003c0000 constant ADC_CCR_PRESC                                    \ ADC prescaler
$00400000 constant ADC_CCR_VREFEN                                   \ VREFEN
$00800000 constant ADC_CCR_TSEN                                     \ Temperature sensor enable
$01000000 constant ADC_CCR_VBATEN                                   \ VBAT enable


\
\ @brief Analog to Digital Converter instance 1
\
$50040000 constant ADC_ISR        \ offset: 0x00 : ADC interrupt and status register
$50040004 constant ADC_IER        \ offset: 0x04 : ADC interrupt enable register
$50040008 constant ADC_CR         \ offset: 0x08 : ADC control register
$5004000c constant ADC_CFGR       \ offset: 0x0C : ADC configuration register 1
$50040010 constant ADC_CFGR2      \ offset: 0x10 : ADC configuration register 2
$50040014 constant ADC_SMPR1      \ offset: 0x14 : ADC sampling time register 1
$50040018 constant ADC_SMPR2      \ offset: 0x18 : ADC sampling time register 2
$50040020 constant ADC_TR1        \ offset: 0x20 : ADC analog watchdog 1 threshold register
$50040024 constant ADC_TR2        \ offset: 0x24 : ADC analog watchdog 2 threshold register
$50040028 constant ADC_TR3        \ offset: 0x28 : ADC analog watchdog 3 threshold register
$50040030 constant ADC_SQR1       \ offset: 0x30 : ADC group regular sequencer ranks register 1
$50040034 constant ADC_SQR2       \ offset: 0x34 : ADC group regular sequencer ranks register 2
$50040038 constant ADC_SQR3       \ offset: 0x38 : ADC group regular sequencer ranks register 3
$5004003c constant ADC_SQR4       \ offset: 0x3C : ADC group regular sequencer ranks register 4
$50040040 constant ADC_DR         \ offset: 0x40 : ADC group regular conversion data register
$5004004c constant ADC_JSQR       \ offset: 0x4C : ADC group injected sequencer register
$50040060 constant ADC_OFR1       \ offset: 0x60 : ADC offset number 1 register
$50040064 constant ADC_OFR2       \ offset: 0x64 : ADC offset number 2 register
$50040068 constant ADC_OFR3       \ offset: 0x68 : ADC offset number 3 register
$5004006c constant ADC_OFR4       \ offset: 0x6C : ADC offset number 4 register
$50040080 constant ADC_JDR1       \ offset: 0x80 : ADC group injected sequencer rank 1 register
$50040084 constant ADC_JDR2       \ offset: 0x84 : ADC group injected sequencer rank 2 register
$50040088 constant ADC_JDR3       \ offset: 0x88 : ADC group injected sequencer rank 3 register
$5004008c constant ADC_JDR4       \ offset: 0x8C : ADC group injected sequencer rank 4 register
$500400a0 constant ADC_AWD2CR     \ offset: 0xA0 : ADC analog watchdog 2 configuration register
$500400a4 constant ADC_AWD3CR     \ offset: 0xA4 : ADC analog watchdog 3 configuration register
$500400b0 constant ADC_DIFSEL     \ offset: 0xB0 : ADC channel differential or single-ended mode selection register
$500400b4 constant ADC_CALFACT    \ offset: 0xB4 : ADC calibration factors register
$50040308 constant ADC_CCR        \ offset: 0x308 : ADC common control register

