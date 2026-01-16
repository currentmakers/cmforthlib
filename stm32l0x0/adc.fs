\
\ @file adc.fs
\ @brief Analog-to-digital converter
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

$00000001 constant ADC_ISR_ADRDY                                    \ ADC ready
$00000002 constant ADC_ISR_EOSMP                                    \ End of sampling flag
$00000004 constant ADC_ISR_EOC                                      \ End of conversion flag
$00000008 constant ADC_ISR_EOS                                      \ End of sequence flag
$00000010 constant ADC_ISR_OVR                                      \ ADC overrun
$00000080 constant ADC_ISR_AWD                                      \ Analog watchdog flag
$00000800 constant ADC_ISR_EOCAL                                    \ End Of Calibration flag


\
\ @brief interrupt enable register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant ADC_IER_ADRDYIE                                  \ ADC ready interrupt enable
$00000002 constant ADC_IER_EOSMPIE                                  \ End of sampling flag interrupt enable
$00000004 constant ADC_IER_EOCIE                                    \ End of conversion interrupt enable
$00000008 constant ADC_IER_EOSIE                                    \ End of conversion sequence interrupt enable
$00000010 constant ADC_IER_OVRIE                                    \ Overrun interrupt enable
$00000080 constant ADC_IER_AWDIE                                    \ Analog watchdog interrupt enable
$00000800 constant ADC_IER_EOCALIE                                  \ End of calibration interrupt enable


\
\ @brief control register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000001 constant ADC_CR_ADEN                                      \ ADC enable command
$00000002 constant ADC_CR_ADDIS                                     \ ADC disable command
$00000004 constant ADC_CR_ADSTART                                   \ ADC start conversion command
$00000010 constant ADC_CR_ADSTP                                     \ ADC stop conversion command
$10000000 constant ADC_CR_ADVREGEN                                  \ ADC Voltage Regulator Enable
$80000000 constant ADC_CR_ADCAL                                     \ ADC calibration


\
\ @brief configuration register 1
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000001 constant ADC_CFGR1_DMAEN                                  \ Direct memory access enable
$00000002 constant ADC_CFGR1_DMACFG                                 \ Direct memery access configuration
$00000004 constant ADC_CFGR1_SCANDIR                                \ Scan sequence direction
$00000018 constant ADC_CFGR1_RES                                    \ Data resolution
$00000020 constant ADC_CFGR1_ALIGN                                  \ Data alignment
$000001c0 constant ADC_CFGR1_EXTSEL                                 \ External trigger selection
$00000c00 constant ADC_CFGR1_EXTEN                                  \ External trigger enable and polarity selection
$00001000 constant ADC_CFGR1_OVRMOD                                 \ Overrun management mode
$00002000 constant ADC_CFGR1_CONT                                   \ Single / continuous conversion mode
$00004000 constant ADC_CFGR1_AUTDLY                                 \ Auto-delayed conversion mode
$00008000 constant ADC_CFGR1_AUTOFF                                 \ Auto-off mode
$00010000 constant ADC_CFGR1_DISCEN                                 \ Discontinuous mode
$00400000 constant ADC_CFGR1_AWDSGL                                 \ Enable the watchdog on a single channel or on all channels
$00800000 constant ADC_CFGR1_AWDEN                                  \ Analog watchdog enable
$7c000000 constant ADC_CFGR1_AWDCH                                  \ Analog watchdog channel selection


\
\ @brief configuration register 2
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000001 constant ADC_CFGR2_OVSE                                   \ Oversampler Enable
$0000001c constant ADC_CFGR2_OVSR                                   \ Oversampling ratio
$000001e0 constant ADC_CFGR2_OVSS                                   \ Oversampling shift
$00000200 constant ADC_CFGR2_TOVS                                   \ Triggered Oversampling
$c0000000 constant ADC_CFGR2_CKMODE                                 \ ADC clock mode


\
\ @brief sampling time register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000007 constant ADC_SMPR_SMPR                                    \ Sampling time selection


\
\ @brief watchdog threshold register
\ Address offset: 0x20
\ Reset value: 0x0FFF0000
\

$00000fff constant ADC_TR_LT                                        \ Analog watchdog lower threshold
$0fff0000 constant ADC_TR_HT                                        \ Analog watchdog higher threshold


\
\ @brief channel selection register
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$00000001 constant ADC_CHSELR_CHSEL0                                \ Channel-x selection
$00000002 constant ADC_CHSELR_CHSEL1                                \ Channel-x selection
$00000004 constant ADC_CHSELR_CHSEL2                                \ Channel-x selection
$00000008 constant ADC_CHSELR_CHSEL3                                \ Channel-x selection
$00000010 constant ADC_CHSELR_CHSEL4                                \ Channel-x selection
$00000020 constant ADC_CHSELR_CHSEL5                                \ Channel-x selection
$00000040 constant ADC_CHSELR_CHSEL6                                \ Channel-x selection
$00000080 constant ADC_CHSELR_CHSEL7                                \ Channel-x selection
$00000100 constant ADC_CHSELR_CHSEL8                                \ Channel-x selection
$00000200 constant ADC_CHSELR_CHSEL9                                \ Channel-x selection
$00000400 constant ADC_CHSELR_CHSEL10                               \ Channel-x selection
$00000800 constant ADC_CHSELR_CHSEL11                               \ Channel-x selection
$00001000 constant ADC_CHSELR_CHSEL12                               \ Channel-x selection
$00002000 constant ADC_CHSELR_CHSEL13                               \ Channel-x selection
$00004000 constant ADC_CHSELR_CHSEL14                               \ Channel-x selection
$00008000 constant ADC_CHSELR_CHSEL15                               \ Channel-x selection
$00010000 constant ADC_CHSELR_CHSEL16                               \ Channel-x selection
$00020000 constant ADC_CHSELR_CHSEL17                               \ Channel-x selection
$00040000 constant ADC_CHSELR_CHSEL18                               \ Channel-x selection


\
\ @brief data register
\ Address offset: 0x40
\ Reset value: 0x00000000
\

$0000ffff constant ADC_DR_DATA                                      \ Converted data


\
\ @brief ADC Calibration factor
\ Address offset: 0xB4
\ Reset value: 0x00000000
\

$0000007f constant ADC_CALFACT_CALFACT                              \ Calibration factor


\
\ @brief ADC common configuration register
\ Address offset: 0x308
\ Reset value: 0x00000000
\

$003c0000 constant ADC_CCR_PRESC                                    \ ADC prescaler
$00400000 constant ADC_CCR_VREFEN                                   \ VREFINT enable
$00800000 constant ADC_CCR_TSEN                                     \ Temperature sensor enable
$01000000 constant ADC_CCR_VLCDEN                                   \ VLCD enable
$02000000 constant ADC_CCR_LFMEN                                    \ Low Frequency Mode enable


\
\ @brief Analog-to-digital converter
\
$40012400 constant ADC_ISR        \ offset: 0x00 : interrupt and status register
$40012404 constant ADC_IER        \ offset: 0x04 : interrupt enable register
$40012408 constant ADC_CR         \ offset: 0x08 : control register
$4001240c constant ADC_CFGR1      \ offset: 0x0C : configuration register 1
$40012410 constant ADC_CFGR2      \ offset: 0x10 : configuration register 2
$40012414 constant ADC_SMPR       \ offset: 0x14 : sampling time register
$40012420 constant ADC_TR         \ offset: 0x20 : watchdog threshold register
$40012428 constant ADC_CHSELR     \ offset: 0x28 : channel selection register
$40012440 constant ADC_DR         \ offset: 0x40 : data register
$400124b4 constant ADC_CALFACT    \ offset: 0xB4 : ADC Calibration factor
$40012708 constant ADC_CCR        \ offset: 0x308 : ADC common configuration register

