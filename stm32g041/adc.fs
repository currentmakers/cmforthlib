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
$00000080 constant ADC_ISR_AWD1                                     \ ADC analog watchdog 1 flag
$00000100 constant ADC_ISR_AWD2                                     \ ADC analog watchdog 2 flag
$00000200 constant ADC_ISR_AWD3                                     \ ADC analog watchdog 3 flag
$00000800 constant ADC_ISR_EOCAL                                    \ End Of Calibration flag
$00002000 constant ADC_ISR_CCRDY                                    \ Channel Configuration Ready flag


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
$00000080 constant ADC_IER_AWD1IE                                   \ ADC analog watchdog 1 interrupt
$00000100 constant ADC_IER_AWD2IE                                   \ ADC analog watchdog 2 interrupt
$00000200 constant ADC_IER_AWD3IE                                   \ ADC analog watchdog 3 interrupt
$00000800 constant ADC_IER_EOCALIE                                  \ End of calibration interrupt enable
$00002000 constant ADC_IER_CCRDYIE                                  \ Channel Configuration Ready Interrupt enable


\
\ @brief ADC control register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000001 constant ADC_CR_ADEN                                      \ ADC enable
$00000002 constant ADC_CR_ADDIS                                     \ ADC disable
$00000004 constant ADC_CR_ADSTART                                   \ ADC group regular conversion start
$00000010 constant ADC_CR_ADSTP                                     \ ADC group regular conversion stop
$10000000 constant ADC_CR_ADVREGEN                                  \ ADC voltage regulator enable
$80000000 constant ADC_CR_ADCAL                                     \ ADC calibration


\
\ @brief ADC configuration register 1
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000001 constant ADC_ADC_CFGR1_DMAEN                              \ ADC DMA transfer enable
$00000002 constant ADC_ADC_CFGR1_DMACFG                             \ ADC DMA transfer configuration
$00000004 constant ADC_ADC_CFGR1_SCANDIR                            \ Scan sequence direction
$00000018 constant ADC_ADC_CFGR1_RES                                \ ADC data resolution
$00000020 constant ADC_ADC_CFGR1_ALIGN                              \ ADC data alignement
$000001c0 constant ADC_ADC_CFGR1_EXTSEL                             \ ADC group regular external trigger source
$00000c00 constant ADC_ADC_CFGR1_EXTEN                              \ ADC group regular external trigger polarity
$00001000 constant ADC_ADC_CFGR1_OVRMOD                             \ ADC group regular overrun configuration
$00002000 constant ADC_ADC_CFGR1_CONT                               \ ADC group regular continuous conversion mode
$00004000 constant ADC_ADC_CFGR1_WAIT                               \ Wait conversion mode
$00008000 constant ADC_ADC_CFGR1_AUTOFF                             \ Auto-off mode
$00010000 constant ADC_ADC_CFGR1_DISCEN                             \ ADC group regular sequencer discontinuous mode
$00200000 constant ADC_ADC_CFGR1_CHSELRMOD                          \ Mode selection of the ADC_CHSELR register
$00400000 constant ADC_ADC_CFGR1_AWD1SGL                            \ ADC analog watchdog 1 monitoring a single channel or all channels
$00800000 constant ADC_ADC_CFGR1_AWD1EN                             \ ADC analog watchdog 1 enable on scope ADC group regular
$7c000000 constant ADC_ADC_CFGR1_AWDCH1CH                           \ ADC analog watchdog 1 monitored channel selection


\
\ @brief ADC configuration register 2
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000001 constant ADC_ADC_CFGR2_OVSE                               \ ADC oversampler enable on scope ADC group regular
$0000001c constant ADC_ADC_CFGR2_OVSR                               \ ADC oversampling ratio
$000001e0 constant ADC_ADC_CFGR2_OVSS                               \ ADC oversampling shift
$00000200 constant ADC_ADC_CFGR2_TOVS                               \ ADC oversampling discontinuous mode (triggered mode) for ADC group regular
$20000000 constant ADC_ADC_CFGR2_LFTRIG                             \ Low frequency trigger mode enable
$c0000000 constant ADC_ADC_CFGR2_CKMODE                             \ ADC clock mode


\
\ @brief ADC sampling time register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000007 constant ADC_SMPR_SMP1                                    \ Sampling time selection
$00000070 constant ADC_SMPR_SMP2                                    \ Sampling time selection
$07ffff00 constant ADC_SMPR_SMPSEL                                  \ Channel sampling time selection


\
\ @brief watchdog threshold register
\ Address offset: 0x20
\ Reset value: 0x0FFF0000
\

$00000fff constant ADC_AWD1TR_LT1                                   \ ADC analog watchdog 1 threshold low
$0fff0000 constant ADC_AWD1TR_HT1                                   \ ADC analog watchdog 1 threshold high


\
\ @brief watchdog threshold register
\ Address offset: 0x24
\ Reset value: 0x0FFF0000
\

$00000fff constant ADC_AWD2TR_LT2                                   \ ADC analog watchdog 2 threshold low
$0fff0000 constant ADC_AWD2TR_HT2                                   \ ADC analog watchdog 2 threshold high


\
\ @brief channel selection register
\ Address offset: 0x28
\ Reset value: 0x0FFF0000
\

$0007ffff constant ADC_CHSELR_CHSEL                                 \ Channel-x selection


\
\ @brief channel selection register CHSELRMOD = 1 in ADC_CFGR1
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$0000000f constant ADC_CHSELR_1_SQ1                                 \ conversion of the sequence
$000000f0 constant ADC_CHSELR_1_SQ2                                 \ conversion of the sequence
$00000f00 constant ADC_CHSELR_1_SQ3                                 \ conversion of the sequence
$0000f000 constant ADC_CHSELR_1_SQ4                                 \ conversion of the sequence
$000f0000 constant ADC_CHSELR_1_SQ5                                 \ conversion of the sequence
$00f00000 constant ADC_CHSELR_1_SQ6                                 \ conversion of the sequence
$0f000000 constant ADC_CHSELR_1_SQ7                                 \ conversion of the sequence
$f0000000 constant ADC_CHSELR_1_SQ8                                 \ conversion of the sequence


\
\ @brief watchdog threshold register
\ Address offset: 0x2C
\ Reset value: 0x0FFF0000
\

$00000fff constant ADC_AWD3TR_LT3                                   \ ADC analog watchdog 3 threshold high
$0fff0000 constant ADC_AWD3TR_HT3                                   \ ADC analog watchdog 3 threshold high


\
\ @brief ADC group regular conversion data register
\ Address offset: 0x40
\ Reset value: 0x00000000
\

$0000ffff constant ADC_DR_REGULARDATA                               \ ADC group regular conversion data


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
\ @brief ADC calibration factors register
\ Address offset: 0xB4
\ Reset value: 0x00000000
\

$0000007f constant ADC_CALFACT_CALFACT                              \ ADC calibration factor in single-ended mode


\
\ @brief ADC common control register
\ Address offset: 0x308
\ Reset value: 0x00000000
\

$003c0000 constant ADC_CCR_PRESC                                    \ ADC prescaler
$00400000 constant ADC_CCR_VREFEN                                   \ VREFINT enable
$00800000 constant ADC_CCR_TSEN                                     \ Temperature sensor enable
$01000000 constant ADC_CCR_VBATEN                                   \ VBAT enable


\
\ @brief Analog to Digital Converter instance 1
\
$40012400 constant ADC_ISR        \ offset: 0x00 : ADC interrupt and status register
$40012404 constant ADC_IER        \ offset: 0x04 : ADC interrupt enable register
$40012408 constant ADC_CR         \ offset: 0x08 : ADC control register
$4001240c constant ADC_ADC_CFGR1  \ offset: 0x0C : ADC configuration register 1
$40012410 constant ADC_ADC_CFGR2  \ offset: 0x10 : ADC configuration register 2
$40012414 constant ADC_SMPR       \ offset: 0x14 : ADC sampling time register
$40012420 constant ADC_AWD1TR     \ offset: 0x20 : watchdog threshold register
$40012424 constant ADC_AWD2TR     \ offset: 0x24 : watchdog threshold register
$40012428 constant ADC_CHSELR     \ offset: 0x28 : channel selection register
$40012428 constant ADC_CHSELR_1   \ offset: 0x28 : channel selection register CHSELRMOD = 1 in ADC_CFGR1
$4001242c constant ADC_AWD3TR     \ offset: 0x2C : watchdog threshold register
$40012440 constant ADC_DR         \ offset: 0x40 : ADC group regular conversion data register
$400124a0 constant ADC_AWD2CR     \ offset: 0xA0 : ADC analog watchdog 2 configuration register
$400124a4 constant ADC_AWD3CR     \ offset: 0xA4 : ADC analog watchdog 3 configuration register
$400124b4 constant ADC_CALFACT    \ offset: 0xB4 : ADC calibration factors register
$40012708 constant ADC_CCR        \ offset: 0x308 : ADC common control register

