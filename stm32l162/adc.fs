\
\ @file adc.fs
\ @brief Analog-to-digital converter
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief status register
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000001 constant ADC_SR_AWD                                       \ Analog watchdog flag
$00000002 constant ADC_SR_EOC                                       \ Regular channel end of conversion
$00000004 constant ADC_SR_JEOC                                      \ Injected channel end of conversion
$00000008 constant ADC_SR_JSTRT                                     \ Injected channel start flag
$00000010 constant ADC_SR_STRT                                      \ Regular channel start flag
$00000020 constant ADC_SR_OVR                                       \ Overrun
$00000040 constant ADC_SR_ADONS                                     \ ADC ON status
$00000100 constant ADC_SR_RCNR                                      \ Regular channel not ready
$00000200 constant ADC_SR_JCNR                                      \ Injected channel not ready


\
\ @brief control register 1
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$0000001f constant ADC_CR1_AWDCH                                    \ Analog watchdog channel select bits
$00000020 constant ADC_CR1_EOCIE                                    \ Interrupt enable for EOC
$00000040 constant ADC_CR1_AWDIE                                    \ Analog watchdog interrupt enable
$00000080 constant ADC_CR1_JEOCIE                                   \ Interrupt enable for injected channels
$00000100 constant ADC_CR1_SCAN                                     \ Scan mode
$00000200 constant ADC_CR1_AWDSGL                                   \ Enable the watchdog on a single channel in scan mode
$00000400 constant ADC_CR1_JAUTO                                    \ Automatic injected group conversion
$00000800 constant ADC_CR1_DISCEN                                   \ Discontinuous mode on regular channels
$00001000 constant ADC_CR1_JDISCEN                                  \ Discontinuous mode on injected channels
$0000e000 constant ADC_CR1_DISCNUM                                  \ Discontinuous mode channel count
$00010000 constant ADC_CR1_PDD                                      \ Power down during the delay phase
$00020000 constant ADC_CR1_PDI                                      \ Power down during the idle phase
$00400000 constant ADC_CR1_JAWDEN                                   \ Analog watchdog enable on injected channels
$00800000 constant ADC_CR1_AWDEN                                    \ Analog watchdog enable on regular channels
$03000000 constant ADC_CR1_RES                                      \ Resolution
$04000000 constant ADC_CR1_OVRIE                                    \ Overrun interrupt enable


\
\ @brief control register 2
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000001 constant ADC_CR2_ADON                                     \ A/D Converter ON / OFF
$00000002 constant ADC_CR2_CONT                                     \ Continuous conversion
$00000004 constant ADC_CR2_ADC_CFG                                  \ ADC configuration
$00000070 constant ADC_CR2_DELS                                     \ Delay selection
$00000100 constant ADC_CR2_DMA                                      \ Direct memory access mode
$00000200 constant ADC_CR2_DDS                                      \ DMA disable selection
$00000400 constant ADC_CR2_EOCS                                     \ End of conversion selection
$00000800 constant ADC_CR2_ALIGN                                    \ Data alignment
$000f0000 constant ADC_CR2_JEXTSEL                                  \ External event select for injected group
$00300000 constant ADC_CR2_JEXTEN                                   \ External trigger enable for injected channels
$00400000 constant ADC_CR2_JSWSTART                                 \ Start conversion of injected channels
$0f000000 constant ADC_CR2_EXTSEL                                   \ External event select for regular group
$30000000 constant ADC_CR2_EXTEN                                    \ External trigger enable for regular channels
$40000000 constant ADC_CR2_SWSTART                                  \ Start conversion of regular channels


\
\ @brief sample time register 1
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$3fffffff constant ADC_SMPR1_SMP                                    \ Channel sampling time selection


\
\ @brief sample time register 2
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$3fffffff constant ADC_SMPR2_SMP                                    \ Channel sampling time selection


\
\ @brief sample time register 3
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$3fffffff constant ADC_SMPR3_SMP                                    \ Channel Sample time selection


\
\ @brief injected channel data offset register x
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000fff constant ADC_JOFR1_JOFFSET1                               \ Data offset for injected channel x


\
\ @brief injected channel data offset register x
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$00000fff constant ADC_JOFR2_JOFFSET2                               \ Data offset for injected channel x


\
\ @brief injected channel data offset register x
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000fff constant ADC_JOFR3_JOFFSET3                               \ Data offset for injected channel x


\
\ @brief injected channel data offset register x
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$00000fff constant ADC_JOFR4_JOFFSET4                               \ Data offset for injected channel x


\
\ @brief watchdog higher threshold register
\ Address offset: 0x28
\ Reset value: 0x00000FFF
\

$00000fff constant ADC_HTR_HT                                       \ Analog watchdog higher threshold


\
\ @brief watchdog lower threshold register
\ Address offset: 0x2C
\ Reset value: 0x00000000
\

$00000fff constant ADC_LTR_LT                                       \ Analog watchdog lower threshold


\
\ @brief regular sequence register 1
\ Address offset: 0x30
\ Reset value: 0x00000000
\

$0000001f constant ADC_SQR1_SQ25                                    \ 25th conversion in regular sequence
$000003e0 constant ADC_SQR1_SQ26                                    \ 26th conversion in regular sequence
$00007c00 constant ADC_SQR1_SQ27                                    \ 27th conversion in regular sequence
$000f8000 constant ADC_SQR1_SQ28                                    \ 28th conversion in regular sequence
$00f00000 constant ADC_SQR1_L                                       \ Regular channel sequence length


\
\ @brief regular sequence register 2
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$0000001f constant ADC_SQR2_SQ19                                    \ 19th conversion in regular sequence
$000003e0 constant ADC_SQR2_SQ20                                    \ 20th conversion in regular sequence
$00007c00 constant ADC_SQR2_SQ21                                    \ 21st conversion in regular sequence
$000f8000 constant ADC_SQR2_SQ22                                    \ 22nd conversion in regular sequence
$01f00000 constant ADC_SQR2_SQ23                                    \ 23rd conversion in regular sequence
$3e000000 constant ADC_SQR2_SQ24                                    \ 24th conversion in regular sequence


\
\ @brief regular sequence register 3
\ Address offset: 0x38
\ Reset value: 0x00000000
\

$0000001f constant ADC_SQR3_SQ13                                    \ 13th conversion in regular sequence
$000003e0 constant ADC_SQR3_SQ14                                    \ 14th conversion in regular sequence
$00007c00 constant ADC_SQR3_SQ15                                    \ 15th conversion in regular sequence
$000f8000 constant ADC_SQR3_SQ16                                    \ 16th conversion in regular sequence
$01f00000 constant ADC_SQR3_SQ17                                    \ 17th conversion in regular sequence
$3e000000 constant ADC_SQR3_SQ18                                    \ 18th conversion in regular sequence


\
\ @brief regular sequence register 4
\ Address offset: 0x3C
\ Reset value: 0x00000000
\

$0000001f constant ADC_SQR4_SQ7                                     \ 7th conversion in regular sequence
$000003e0 constant ADC_SQR4_SQ8                                     \ 8th conversion in regular sequence
$00007c00 constant ADC_SQR4_SQ9                                     \ 9th conversion in regular sequence
$000f8000 constant ADC_SQR4_SQ10                                    \ 10th conversion in regular sequence
$01f00000 constant ADC_SQR4_SQ11                                    \ 11th conversion in regular sequence
$3e000000 constant ADC_SQR4_SQ12                                    \ 12th conversion in regular sequence


\
\ @brief regular sequence register 5
\ Address offset: 0x40
\ Reset value: 0x00000000
\

$0000001f constant ADC_SQR5_SQ1                                     \ 1st conversion in regular sequence
$000003e0 constant ADC_SQR5_SQ2                                     \ 2nd conversion in regular sequence
$00007c00 constant ADC_SQR5_SQ3                                     \ 3rd conversion in regular sequence
$000f8000 constant ADC_SQR5_SQ4                                     \ 4th conversion in regular sequence
$01f00000 constant ADC_SQR5_SQ5                                     \ 5th conversion in regular sequence
$3e000000 constant ADC_SQR5_SQ6                                     \ 6th conversion in regular sequence


\
\ @brief injected sequence register
\ Address offset: 0x44
\ Reset value: 0x00000000
\

$0000001f constant ADC_JSQR_JSQ1                                    \ 1st conversion in injected sequence
$000003e0 constant ADC_JSQR_JSQ2                                    \ 2nd conversion in injected sequence
$00007c00 constant ADC_JSQR_JSQ3                                    \ 3rd conversion in injected sequence
$000f8000 constant ADC_JSQR_JSQ4                                    \ 4th conversion in injected sequence
$00300000 constant ADC_JSQR_JL                                      \ Injected sequence length


\
\ @brief injected data register x
\ Address offset: 0x48
\ Reset value: 0x00000000
\

$0000ffff constant ADC_JDR1_JDATA                                   \ Injected data


\
\ @brief injected data register x
\ Address offset: 0x4C
\ Reset value: 0x00000000
\

$0000ffff constant ADC_JDR2_JDATA                                   \ Injected data


\
\ @brief injected data register x
\ Address offset: 0x50
\ Reset value: 0x00000000
\

$0000ffff constant ADC_JDR3_JDATA                                   \ Injected data


\
\ @brief injected data register x
\ Address offset: 0x54
\ Reset value: 0x00000000
\

$0000ffff constant ADC_JDR4_JDATA                                   \ Injected data


\
\ @brief regular data register
\ Address offset: 0x58
\ Reset value: 0x00000000
\

$0000ffff constant ADC_DR_REGULARDATA                               \ Regular data


\
\ @brief sample time register 0
\ Address offset: 0x5C
\ Reset value: 0x00000000
\

$0000003f constant ADC_SMPR0_SMP                                    \ Channel Sample time selection


\
\ @brief ADC common status register
\ Address offset: 0x300
\ Reset value: 0x00000000
\

$00000001 constant ADC_CSR_AWD1                                     \ Analog watchdog flag of the ADC
$00000002 constant ADC_CSR_EOC1                                     \ End of conversion of the ADC
$00000004 constant ADC_CSR_JEOC1                                    \ Injected channel end of conversion of the ADC
$00000008 constant ADC_CSR_JSTRT1                                   \ Injected channel Start flag of the ADC
$00000010 constant ADC_CSR_STRT1                                    \ Regular channel Start flag of the ADC
$00000020 constant ADC_CSR_OVR1                                     \ Overrun flag of the ADC
$00000040 constant ADC_CSR_ADONS1                                   \ ADON Status of ADC1


\
\ @brief ADC common control register
\ Address offset: 0x304
\ Reset value: 0x00000000
\

$00030000 constant ADC_CCR_ADCPRE                                   \ ADC prescaler
$00800000 constant ADC_CCR_TSVREFE                                  \ Temperature sensor and VREFINT enable


\
\ @brief Analog-to-digital converter
\
$40012400 constant ADC_SR         \ offset: 0x00 : status register
$40012404 constant ADC_CR1        \ offset: 0x04 : control register 1
$40012408 constant ADC_CR2        \ offset: 0x08 : control register 2
$4001240c constant ADC_SMPR1      \ offset: 0x0C : sample time register 1
$40012410 constant ADC_SMPR2      \ offset: 0x10 : sample time register 2
$40012414 constant ADC_SMPR3      \ offset: 0x14 : sample time register 3
$40012418 constant ADC_JOFR1      \ offset: 0x18 : injected channel data offset register x
$4001241c constant ADC_JOFR2      \ offset: 0x1C : injected channel data offset register x
$40012420 constant ADC_JOFR3      \ offset: 0x20 : injected channel data offset register x
$40012424 constant ADC_JOFR4      \ offset: 0x24 : injected channel data offset register x
$40012428 constant ADC_HTR        \ offset: 0x28 : watchdog higher threshold register
$4001242c constant ADC_LTR        \ offset: 0x2C : watchdog lower threshold register
$40012430 constant ADC_SQR1       \ offset: 0x30 : regular sequence register 1
$40012434 constant ADC_SQR2       \ offset: 0x34 : regular sequence register 2
$40012438 constant ADC_SQR3       \ offset: 0x38 : regular sequence register 3
$4001243c constant ADC_SQR4       \ offset: 0x3C : regular sequence register 4
$40012440 constant ADC_SQR5       \ offset: 0x40 : regular sequence register 5
$40012444 constant ADC_JSQR       \ offset: 0x44 : injected sequence register
$40012448 constant ADC_JDR1       \ offset: 0x48 : injected data register x
$4001244c constant ADC_JDR2       \ offset: 0x4C : injected data register x
$40012450 constant ADC_JDR3       \ offset: 0x50 : injected data register x
$40012454 constant ADC_JDR4       \ offset: 0x54 : injected data register x
$40012458 constant ADC_DR         \ offset: 0x58 : regular data register
$4001245c constant ADC_SMPR0      \ offset: 0x5C : sample time register 0
$40012700 constant ADC_CSR        \ offset: 0x300 : ADC common status register
$40012704 constant ADC_CCR        \ offset: 0x304 : ADC common control register

