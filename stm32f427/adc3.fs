\
\ @file adc3.fs
\ @brief ADC3 global interrupts
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

$00000001 constant ADC3_SR_AWD                                      \ Analog watchdog flag
$00000002 constant ADC3_SR_EOC                                      \ Regular channel end of conversion
$00000004 constant ADC3_SR_JEOC                                     \ Injected channel end of conversion
$00000008 constant ADC3_SR_JSTRT                                    \ Injected channel start flag
$00000010 constant ADC3_SR_STRT                                     \ Regular channel start flag
$00000020 constant ADC3_SR_OVR                                      \ Overrun


\
\ @brief control register 1
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$0000001f constant ADC3_CR1_AWDCH                                   \ Analog watchdog channel select bits
$00000020 constant ADC3_CR1_EOCIE                                   \ Interrupt enable for EOC
$00000040 constant ADC3_CR1_AWDIE                                   \ Analog watchdog interrupt enable
$00000080 constant ADC3_CR1_JEOCIE                                  \ Interrupt enable for injected channels
$00000100 constant ADC3_CR1_SCAN                                    \ Scan mode
$00000200 constant ADC3_CR1_AWDSGL                                  \ Enable the watchdog on a single channel in scan mode
$00000400 constant ADC3_CR1_JAUTO                                   \ Automatic injected group conversion
$00000800 constant ADC3_CR1_DISCEN                                  \ Discontinuous mode on regular channels
$00001000 constant ADC3_CR1_JDISCEN                                 \ Discontinuous mode on injected channels
$0000e000 constant ADC3_CR1_DISCNUM                                 \ Discontinuous mode channel count
$00400000 constant ADC3_CR1_JAWDEN                                  \ Analog watchdog enable on injected channels
$00800000 constant ADC3_CR1_AWDEN                                   \ Analog watchdog enable on regular channels
$03000000 constant ADC3_CR1_RES                                     \ Resolution
$04000000 constant ADC3_CR1_OVRIE                                   \ Overrun interrupt enable


\
\ @brief control register 2
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000001 constant ADC3_CR2_ADON                                    \ A/D Converter ON / OFF
$00000002 constant ADC3_CR2_CONT                                    \ Continuous conversion
$00000100 constant ADC3_CR2_DMA                                     \ Direct memory access mode (for single ADC mode)
$00000200 constant ADC3_CR2_DDS                                     \ DMA disable selection (for single ADC mode)
$00000400 constant ADC3_CR2_EOCS                                    \ End of conversion selection
$00000800 constant ADC3_CR2_ALIGN                                   \ Data alignment
$000f0000 constant ADC3_CR2_JEXTSEL                                 \ External event select for injected group
$00300000 constant ADC3_CR2_JEXTEN                                  \ External trigger enable for injected channels
$00400000 constant ADC3_CR2_JSWSTART                                \ Start conversion of injected channels
$0f000000 constant ADC3_CR2_EXTSEL                                  \ External event select for regular group
$30000000 constant ADC3_CR2_EXTEN                                   \ External trigger enable for regular channels
$40000000 constant ADC3_CR2_SWSTART                                 \ Start conversion of regular channels


\
\ @brief sample time register 1
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000000 constant ADC3_SMPR1_SMPX_X                                \ Sample time bits


\
\ @brief sample time register 2
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000000 constant ADC3_SMPR2_SMPX_X                                \ Sample time bits


\
\ @brief injected channel data offset register x
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000fff constant ADC3_JOFR1_JOFFSET1                              \ Data offset for injected channel x


\
\ @brief injected channel data offset register x
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000fff constant ADC3_JOFR2_JOFFSET2                              \ Data offset for injected channel x


\
\ @brief injected channel data offset register x
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$00000fff constant ADC3_JOFR3_JOFFSET3                              \ Data offset for injected channel x


\
\ @brief injected channel data offset register x
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000fff constant ADC3_JOFR4_JOFFSET4                              \ Data offset for injected channel x


\
\ @brief watchdog higher threshold register
\ Address offset: 0x24
\ Reset value: 0x00000FFF
\

$00000fff constant ADC3_HTR_HT                                      \ Analog watchdog higher threshold


\
\ @brief watchdog lower threshold register
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$00000fff constant ADC3_LTR_LT                                      \ Analog watchdog lower threshold


\
\ @brief regular sequence register 1
\ Address offset: 0x2C
\ Reset value: 0x00000000
\

$0000001f constant ADC3_SQR1_SQ13                                   \ 13th conversion in regular sequence
$000003e0 constant ADC3_SQR1_SQ14                                   \ 14th conversion in regular sequence
$00007c00 constant ADC3_SQR1_SQ15                                   \ 15th conversion in regular sequence
$000f8000 constant ADC3_SQR1_SQ16                                   \ 16th conversion in regular sequence
$00f00000 constant ADC3_SQR1_L                                      \ Regular channel sequence length


\
\ @brief regular sequence register 2
\ Address offset: 0x30
\ Reset value: 0x00000000
\

$0000001f constant ADC3_SQR2_SQ7                                    \ 7th conversion in regular sequence
$000003e0 constant ADC3_SQR2_SQ8                                    \ 8th conversion in regular sequence
$00007c00 constant ADC3_SQR2_SQ9                                    \ 9th conversion in regular sequence
$000f8000 constant ADC3_SQR2_SQ10                                   \ 10th conversion in regular sequence
$01f00000 constant ADC3_SQR2_SQ11                                   \ 11th conversion in regular sequence
$3e000000 constant ADC3_SQR2_SQ12                                   \ 12th conversion in regular sequence


\
\ @brief regular sequence register 3
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$0000001f constant ADC3_SQR3_SQ1                                    \ 1st conversion in regular sequence
$000003e0 constant ADC3_SQR3_SQ2                                    \ 2nd conversion in regular sequence
$00007c00 constant ADC3_SQR3_SQ3                                    \ 3rd conversion in regular sequence
$000f8000 constant ADC3_SQR3_SQ4                                    \ 4th conversion in regular sequence
$01f00000 constant ADC3_SQR3_SQ5                                    \ 5th conversion in regular sequence
$3e000000 constant ADC3_SQR3_SQ6                                    \ 6th conversion in regular sequence


\
\ @brief injected sequence register
\ Address offset: 0x38
\ Reset value: 0x00000000
\

$0000001f constant ADC3_JSQR_JSQ1                                   \ 1st conversion in injected sequence
$000003e0 constant ADC3_JSQR_JSQ2                                   \ 2nd conversion in injected sequence
$00007c00 constant ADC3_JSQR_JSQ3                                   \ 3rd conversion in injected sequence
$000f8000 constant ADC3_JSQR_JSQ4                                   \ 4th conversion in injected sequence
$00300000 constant ADC3_JSQR_JL                                     \ Injected sequence length


\
\ @brief injected data register x
\ Address offset: 0x3C
\ Reset value: 0x00000000
\

$0000ffff constant ADC3_JDR1_JDATA                                  \ Injected data


\
\ @brief injected data register x
\ Address offset: 0x40
\ Reset value: 0x00000000
\

$0000ffff constant ADC3_JDR2_JDATA                                  \ Injected data


\
\ @brief injected data register x
\ Address offset: 0x44
\ Reset value: 0x00000000
\

$0000ffff constant ADC3_JDR3_JDATA                                  \ Injected data


\
\ @brief injected data register x
\ Address offset: 0x48
\ Reset value: 0x00000000
\

$0000ffff constant ADC3_JDR4_JDATA                                  \ Injected data


\
\ @brief regular data register
\ Address offset: 0x4C
\ Reset value: 0x00000000
\

$0000ffff constant ADC3_DR_DATA                                     \ Regular data


\
\ @brief ADC3 global interrupts
\
$40012200 constant ADC3_SR        \ offset: 0x00 : status register
$40012204 constant ADC3_CR1       \ offset: 0x04 : control register 1
$40012208 constant ADC3_CR2       \ offset: 0x08 : control register 2
$4001220c constant ADC3_SMPR1     \ offset: 0x0C : sample time register 1
$40012210 constant ADC3_SMPR2     \ offset: 0x10 : sample time register 2
$40012214 constant ADC3_JOFR1     \ offset: 0x14 : injected channel data offset register x
$40012218 constant ADC3_JOFR2     \ offset: 0x18 : injected channel data offset register x
$4001221c constant ADC3_JOFR3     \ offset: 0x1C : injected channel data offset register x
$40012220 constant ADC3_JOFR4     \ offset: 0x20 : injected channel data offset register x
$40012224 constant ADC3_HTR       \ offset: 0x24 : watchdog higher threshold register
$40012228 constant ADC3_LTR       \ offset: 0x28 : watchdog lower threshold register
$4001222c constant ADC3_SQR1      \ offset: 0x2C : regular sequence register 1
$40012230 constant ADC3_SQR2      \ offset: 0x30 : regular sequence register 2
$40012234 constant ADC3_SQR3      \ offset: 0x34 : regular sequence register 3
$40012238 constant ADC3_JSQR      \ offset: 0x38 : injected sequence register
$4001223c constant ADC3_JDR1      \ offset: 0x3C : injected data register x
$40012240 constant ADC3_JDR2      \ offset: 0x40 : injected data register x
$40012244 constant ADC3_JDR3      \ offset: 0x44 : injected data register x
$40012248 constant ADC3_JDR4      \ offset: 0x48 : injected data register x
$4001224c constant ADC3_DR        \ offset: 0x4C : regular data register

