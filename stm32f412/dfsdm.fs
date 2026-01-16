\
\ @file dfsdm.fs
\ @brief Digital filter for sigma delta       modulators
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief channel configuration y register
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000003 constant DFSDM_CHCFG0R1_SITP                              \ SITP
$0000000c constant DFSDM_CHCFG0R1_SPICKSEL                          \ SPICKSEL
$00000020 constant DFSDM_CHCFG0R1_SCDEN                             \ SCDEN
$00000040 constant DFSDM_CHCFG0R1_CKABEN                            \ CKABEN
$00000080 constant DFSDM_CHCFG0R1_CHEN                              \ CHEN
$00000100 constant DFSDM_CHCFG0R1_CHINSEL                           \ CHINSEL
$00003000 constant DFSDM_CHCFG0R1_DATMPX                            \ DATMPX
$0000c000 constant DFSDM_CHCFG0R1_DATPACK                           \ DATPACK
$00ff0000 constant DFSDM_CHCFG0R1_CKOUTDIV                          \ CKOUTDIV
$40000000 constant DFSDM_CHCFG0R1_CKOUTSRC                          \ CKOUTSRC
$80000000 constant DFSDM_CHCFG0R1_DFSDMEN                           \ DFSDMEN


\
\ @brief channel configuration y register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$000000f8 constant DFSDM_CHCFG0R2_DTRBS                             \ DTRBS
$ffffff00 constant DFSDM_CHCFG0R2_OFFSET                            \ OFFSET


\
\ @brief analog watchdog and short-circuit detector register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$000000ff constant DFSDM_AWSCD0R_SCDT                               \ SCDT
$0000f000 constant DFSDM_AWSCD0R_BKSCD                              \ BKSCD
$001f0000 constant DFSDM_AWSCD0R_AWFOSR                             \ AWFOSR
$00c00000 constant DFSDM_AWSCD0R_AWFORD                             \ AWFORD


\
\ @brief channel watchdog filter data register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$0000ffff constant DFSDM_CHWDAT0R_WDATA                             \ WDATA


\
\ @brief channel data input register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$0000ffff constant DFSDM_CHDATIN0R_INDAT0                           \ INDAT0
$ffff0000 constant DFSDM_CHDATIN0R_INDAT1                           \ INDAT1


\
\ @brief CHCFG1R1
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000003 constant DFSDM_CHCFG1R1_SITP                              \ SITP
$0000000c constant DFSDM_CHCFG1R1_SPICKSEL                          \ SPICKSEL
$00000020 constant DFSDM_CHCFG1R1_SCDEN                             \ SCDEN
$00000040 constant DFSDM_CHCFG1R1_CKABEN                            \ CKABEN
$00000080 constant DFSDM_CHCFG1R1_CHEN                              \ CHEN
$00000100 constant DFSDM_CHCFG1R1_CHINSEL                           \ CHINSEL
$00003000 constant DFSDM_CHCFG1R1_DATMPX                            \ DATMPX
$0000c000 constant DFSDM_CHCFG1R1_DATPACK                           \ DATPACK


\
\ @brief CHCFG1R2
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$000000f8 constant DFSDM_CHCFG1R2_DTRBS                             \ DTRBS
$ffffff00 constant DFSDM_CHCFG1R2_OFFSET                            \ OFFSET


\
\ @brief AWSCD1R
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$000000ff constant DFSDM_AWSCD1R_SCDT                               \ SCDT
$0000f000 constant DFSDM_AWSCD1R_BKSCD                              \ BKSCD
$001f0000 constant DFSDM_AWSCD1R_AWFOSR                             \ AWFOSR
$00c00000 constant DFSDM_AWSCD1R_AWFORD                             \ AWFORD


\
\ @brief CHWDAT1R
\ Address offset: 0x2C
\ Reset value: 0x00000000
\

$0000ffff constant DFSDM_CHWDAT1R_WDATA                             \ WDATA


\
\ @brief CHDATIN1R
\ Address offset: 0x30
\ Reset value: 0x00000000
\

$0000ffff constant DFSDM_CHDATIN1R_INDAT0                           \ INDAT0
$ffff0000 constant DFSDM_CHDATIN1R_INDAT1                           \ INDAT1


\
\ @brief CHCFG2R1
\ Address offset: 0x40
\ Reset value: 0x00000000
\

$00000003 constant DFSDM_CHCFG2R1_SITP                              \ SITP
$0000000c constant DFSDM_CHCFG2R1_SPICKSEL                          \ SPICKSEL
$00000020 constant DFSDM_CHCFG2R1_SCDEN                             \ SCDEN
$00000040 constant DFSDM_CHCFG2R1_CKABEN                            \ CKABEN
$00000080 constant DFSDM_CHCFG2R1_CHEN                              \ CHEN
$00000100 constant DFSDM_CHCFG2R1_CHINSEL                           \ CHINSEL
$00003000 constant DFSDM_CHCFG2R1_DATMPX                            \ DATMPX
$0000c000 constant DFSDM_CHCFG2R1_DATPACK                           \ DATPACK


\
\ @brief CHCFG2R2
\ Address offset: 0x44
\ Reset value: 0x00000000
\

$000000f8 constant DFSDM_CHCFG2R2_DTRBS                             \ DTRBS
$ffffff00 constant DFSDM_CHCFG2R2_OFFSET                            \ OFFSET


\
\ @brief AWSCD2R
\ Address offset: 0x48
\ Reset value: 0x00000000
\

$000000ff constant DFSDM_AWSCD2R_SCDT                               \ SCDT
$0000f000 constant DFSDM_AWSCD2R_BKSCD                              \ BKSCD
$001f0000 constant DFSDM_AWSCD2R_AWFOSR                             \ AWFOSR
$00c00000 constant DFSDM_AWSCD2R_AWFORD                             \ AWFORD


\
\ @brief CHWDAT2R
\ Address offset: 0x4C
\ Reset value: 0x00000000
\

$0000ffff constant DFSDM_CHWDAT2R_WDATA                             \ WDATA


\
\ @brief CHDATIN2R
\ Address offset: 0x50
\ Reset value: 0x00000000
\

$0000ffff constant DFSDM_CHDATIN2R_INDAT0                           \ INDAT0
$ffff0000 constant DFSDM_CHDATIN2R_INDAT1                           \ INDAT1


\
\ @brief CHCFG3R1
\ Address offset: 0x60
\ Reset value: 0x00000000
\

$00000003 constant DFSDM_CHCFG3R1_SITP                              \ SITP
$0000000c constant DFSDM_CHCFG3R1_SPICKSEL                          \ SPICKSEL
$00000020 constant DFSDM_CHCFG3R1_SCDEN                             \ SCDEN
$00000040 constant DFSDM_CHCFG3R1_CKABEN                            \ CKABEN
$00000080 constant DFSDM_CHCFG3R1_CHEN                              \ CHEN
$00000100 constant DFSDM_CHCFG3R1_CHINSEL                           \ CHINSEL
$00003000 constant DFSDM_CHCFG3R1_DATMPX                            \ DATMPX
$0000c000 constant DFSDM_CHCFG3R1_DATPACK                           \ DATPACK


\
\ @brief CHCFG3R2
\ Address offset: 0x64
\ Reset value: 0x00000000
\

$000000f8 constant DFSDM_CHCFG3R2_DTRBS                             \ DTRBS
$ffffff00 constant DFSDM_CHCFG3R2_OFFSET                            \ OFFSET


\
\ @brief AWSCD3R
\ Address offset: 0x68
\ Reset value: 0x00000000
\

$000000ff constant DFSDM_AWSCD3R_SCDT                               \ SCDT
$0000f000 constant DFSDM_AWSCD3R_BKSCD                              \ BKSCD
$001f0000 constant DFSDM_AWSCD3R_AWFOSR                             \ AWFOSR
$00c00000 constant DFSDM_AWSCD3R_AWFORD                             \ AWFORD


\
\ @brief CHWDAT3R
\ Address offset: 0x6C
\ Reset value: 0x00000000
\

$0000ffff constant DFSDM_CHWDAT3R_WDATA                             \ WDATA


\
\ @brief CHDATIN3R
\ Address offset: 0x70
\ Reset value: 0x00000000
\

$0000ffff constant DFSDM_CHDATIN3R_INDAT0                           \ INDAT0
$ffff0000 constant DFSDM_CHDATIN3R_INDAT1                           \ INDAT1


\
\ @brief CHCFG4R1
\ Address offset: 0x80
\ Reset value: 0x00000000
\

$00000003 constant DFSDM_CHCFG4R1_SITP                              \ SITP
$0000000c constant DFSDM_CHCFG4R1_SPICKSEL                          \ SPICKSEL
$00000020 constant DFSDM_CHCFG4R1_SCDEN                             \ SCDEN
$00000040 constant DFSDM_CHCFG4R1_CKABEN                            \ CKABEN
$00000080 constant DFSDM_CHCFG4R1_CHEN                              \ CHEN
$00000100 constant DFSDM_CHCFG4R1_CHINSEL                           \ CHINSEL
$00003000 constant DFSDM_CHCFG4R1_DATMPX                            \ DATMPX
$0000c000 constant DFSDM_CHCFG4R1_DATPACK                           \ DATPACK


\
\ @brief CHCFG4R2
\ Address offset: 0x84
\ Reset value: 0x00000000
\

$000000f8 constant DFSDM_CHCFG4R2_DTRBS                             \ DTRBS
$ffffff00 constant DFSDM_CHCFG4R2_OFFSET                            \ OFFSET


\
\ @brief AWSCD4R
\ Address offset: 0x88
\ Reset value: 0x00000000
\

$000000ff constant DFSDM_AWSCD4R_SCDT                               \ SCDT
$0000f000 constant DFSDM_AWSCD4R_BKSCD                              \ BKSCD
$001f0000 constant DFSDM_AWSCD4R_AWFOSR                             \ AWFOSR
$00c00000 constant DFSDM_AWSCD4R_AWFORD                             \ AWFORD


\
\ @brief CHWDAT4R
\ Address offset: 0x8C
\ Reset value: 0x00000000
\

$0000ffff constant DFSDM_CHWDAT4R_WDATA                             \ WDATA


\
\ @brief CHDATIN4R
\ Address offset: 0x90
\ Reset value: 0x00000000
\

$0000ffff constant DFSDM_CHDATIN4R_INDAT0                           \ INDAT0
$ffff0000 constant DFSDM_CHDATIN4R_INDAT1                           \ INDAT1


\
\ @brief CHCFG5R1
\ Address offset: 0xA0
\ Reset value: 0x00000000
\

$00000003 constant DFSDM_CHCFG5R1_SITP                              \ SITP
$0000000c constant DFSDM_CHCFG5R1_SPICKSEL                          \ SPICKSEL
$00000020 constant DFSDM_CHCFG5R1_SCDEN                             \ SCDEN
$00000040 constant DFSDM_CHCFG5R1_CKABEN                            \ CKABEN
$00000080 constant DFSDM_CHCFG5R1_CHEN                              \ CHEN
$00000100 constant DFSDM_CHCFG5R1_CHINSEL                           \ CHINSEL
$00003000 constant DFSDM_CHCFG5R1_DATMPX                            \ DATMPX
$0000c000 constant DFSDM_CHCFG5R1_DATPACK                           \ DATPACK


\
\ @brief CHCFG5R2
\ Address offset: 0xA4
\ Reset value: 0x00000000
\

$000000f8 constant DFSDM_CHCFG5R2_DTRBS                             \ DTRBS
$ffffff00 constant DFSDM_CHCFG5R2_OFFSET                            \ OFFSET


\
\ @brief AWSCD5R
\ Address offset: 0xA8
\ Reset value: 0x00000000
\

$000000ff constant DFSDM_AWSCD5R_SCDT                               \ SCDT
$0000f000 constant DFSDM_AWSCD5R_BKSCD                              \ BKSCD
$001f0000 constant DFSDM_AWSCD5R_AWFOSR                             \ AWFOSR
$00c00000 constant DFSDM_AWSCD5R_AWFORD                             \ AWFORD


\
\ @brief CHWDAT5R
\ Address offset: 0xAC
\ Reset value: 0x00000000
\

$0000ffff constant DFSDM_CHWDAT5R_WDATA                             \ WDATA


\
\ @brief CHDATIN5R
\ Address offset: 0xB0
\ Reset value: 0x00000000
\

$0000ffff constant DFSDM_CHDATIN5R_INDAT0                           \ INDAT0
$ffff0000 constant DFSDM_CHDATIN5R_INDAT1                           \ INDAT1


\
\ @brief CHCFG6R1
\ Address offset: 0xC0
\ Reset value: 0x00000000
\

$00000003 constant DFSDM_CHCFG6R1_SITP                              \ SITP
$0000000c constant DFSDM_CHCFG6R1_SPICKSEL                          \ SPICKSEL
$00000020 constant DFSDM_CHCFG6R1_SCDEN                             \ SCDEN
$00000040 constant DFSDM_CHCFG6R1_CKABEN                            \ CKABEN
$00000080 constant DFSDM_CHCFG6R1_CHEN                              \ CHEN
$00000100 constant DFSDM_CHCFG6R1_CHINSEL                           \ CHINSEL
$00003000 constant DFSDM_CHCFG6R1_DATMPX                            \ DATMPX
$0000c000 constant DFSDM_CHCFG6R1_DATPACK                           \ DATPACK


\
\ @brief CHCFG6R2
\ Address offset: 0xC4
\ Reset value: 0x00000000
\

$000000f8 constant DFSDM_CHCFG6R2_DTRBS                             \ DTRBS
$ffffff00 constant DFSDM_CHCFG6R2_OFFSET                            \ OFFSET


\
\ @brief AWSCD6R
\ Address offset: 0xC8
\ Reset value: 0x00000000
\

$000000ff constant DFSDM_AWSCD6R_SCDT                               \ SCDT
$0000f000 constant DFSDM_AWSCD6R_BKSCD                              \ BKSCD
$001f0000 constant DFSDM_AWSCD6R_AWFOSR                             \ AWFOSR
$00c00000 constant DFSDM_AWSCD6R_AWFORD                             \ AWFORD


\
\ @brief CHWDAT6R
\ Address offset: 0xCC
\ Reset value: 0x00000000
\

$0000ffff constant DFSDM_CHWDAT6R_WDATA                             \ WDATA


\
\ @brief CHDATIN6R
\ Address offset: 0xD0
\ Reset value: 0x00000000
\

$0000ffff constant DFSDM_CHDATIN6R_INDAT0                           \ INDAT0
$ffff0000 constant DFSDM_CHDATIN6R_INDAT1                           \ INDAT1


\
\ @brief CHCFG7R1
\ Address offset: 0xE0
\ Reset value: 0x00000000
\

$00000003 constant DFSDM_CHCFG7R1_SITP                              \ SITP
$0000000c constant DFSDM_CHCFG7R1_SPICKSEL                          \ SPICKSEL
$00000020 constant DFSDM_CHCFG7R1_SCDEN                             \ SCDEN
$00000040 constant DFSDM_CHCFG7R1_CKABEN                            \ CKABEN
$00000080 constant DFSDM_CHCFG7R1_CHEN                              \ CHEN
$00000100 constant DFSDM_CHCFG7R1_CHINSEL                           \ CHINSEL
$00003000 constant DFSDM_CHCFG7R1_DATMPX                            \ DATMPX
$0000c000 constant DFSDM_CHCFG7R1_DATPACK                           \ DATPACK


\
\ @brief CHCFG7R2
\ Address offset: 0xE4
\ Reset value: 0x00000000
\

$000000f8 constant DFSDM_CHCFG7R2_DTRBS                             \ DTRBS
$ffffff00 constant DFSDM_CHCFG7R2_OFFSET                            \ OFFSET


\
\ @brief AWSCD7R
\ Address offset: 0xE8
\ Reset value: 0x00000000
\

$000000ff constant DFSDM_AWSCD7R_SCDT                               \ SCDT
$0000f000 constant DFSDM_AWSCD7R_BKSCD                              \ BKSCD
$001f0000 constant DFSDM_AWSCD7R_AWFOSR                             \ AWFOSR
$00c00000 constant DFSDM_AWSCD7R_AWFORD                             \ AWFORD


\
\ @brief CHWDAT7R
\ Address offset: 0xEC
\ Reset value: 0x00000000
\

$0000ffff constant DFSDM_CHWDAT7R_WDATA                             \ WDATA


\
\ @brief CHDATIN7R
\ Address offset: 0xF0
\ Reset value: 0x00000000
\

$0000ffff constant DFSDM_CHDATIN7R_INDAT0                           \ INDAT0
$ffff0000 constant DFSDM_CHDATIN7R_INDAT1                           \ INDAT1


\
\ @brief control register 1
\ Address offset: 0x100
\ Reset value: 0x00000000
\

$00000001 constant DFSDM_DFSDM0_CR1_DFEN                            \ DFSDM enable
$00000002 constant DFSDM_DFSDM0_CR1_JSWSTART                        \ Start a conversion of the injected group of channels
$00000008 constant DFSDM_DFSDM0_CR1_JSYNC                           \ Launch an injected conversion synchronously with the DFSDM0 JSWSTART trigger
$00000010 constant DFSDM_DFSDM0_CR1_JSCAN                           \ Scanning conversion mode for injected conversions
$00000020 constant DFSDM_DFSDM0_CR1_JDMAEN                          \ DMA channel enabled to read data for the injected channel group
$00000700 constant DFSDM_DFSDM0_CR1_JEXTSEL                         \ Trigger signal selection for launching injected conversions
$00006000 constant DFSDM_DFSDM0_CR1_JEXTEN                          \ Trigger enable and trigger edge selection for injected conversions
$00020000 constant DFSDM_DFSDM0_CR1_RSWSTART                        \ Software start of a conversion on the regular channel
$00040000 constant DFSDM_DFSDM0_CR1_RCONT                           \ Continuous mode selection for regular conversions
$00080000 constant DFSDM_DFSDM0_CR1_RSYNC                           \ Launch regular conversion synchronously with DFSDM0
$00200000 constant DFSDM_DFSDM0_CR1_RDMAEN                          \ DMA channel enabled to read data for the regular conversion
$07000000 constant DFSDM_DFSDM0_CR1_RCH                             \ Regular channel selection
$20000000 constant DFSDM_DFSDM0_CR1_FAST                            \ Fast conversion mode selection for regular conversions
$40000000 constant DFSDM_DFSDM0_CR1_AWFSEL                          \ Analog watchdog fast mode select


\
\ @brief control register 2
\ Address offset: 0x104
\ Reset value: 0x00000000
\

$00000001 constant DFSDM_DFSDM0_CR2_JEOCIE                          \ Injected end of conversion interrupt enable
$00000002 constant DFSDM_DFSDM0_CR2_REOCIE                          \ Regular end of conversion interrupt enable
$00000004 constant DFSDM_DFSDM0_CR2_JOVRIE                          \ Injected data overrun interrupt enable
$00000008 constant DFSDM_DFSDM0_CR2_ROVRIE                          \ Regular data overrun interrupt enable
$00000010 constant DFSDM_DFSDM0_CR2_AWDIE                           \ Analog watchdog interrupt enable
$00000020 constant DFSDM_DFSDM0_CR2_SCDIE                           \ Short-circuit detector interrupt enable
$00000040 constant DFSDM_DFSDM0_CR2_CKABIE                          \ Clock absence interrupt enable
$0000ff00 constant DFSDM_DFSDM0_CR2_EXCH                            \ Extremes detector channel selection
$00ff0000 constant DFSDM_DFSDM0_CR2_AWDCH                           \ Analog watchdog channel selection


\
\ @brief interrupt and status register
\ Address offset: 0x108
\ Reset value: 0x00FF0000
\

$00000001 constant DFSDM_DFSDM0_ISR_JEOCF                           \ End of injected conversion flag
$00000002 constant DFSDM_DFSDM0_ISR_REOCF                           \ End of regular conversion flag
$00000004 constant DFSDM_DFSDM0_ISR_JOVRF                           \ Injected conversion overrun flag
$00000008 constant DFSDM_DFSDM0_ISR_ROVRF                           \ Regular conversion overrun flag
$00000010 constant DFSDM_DFSDM0_ISR_AWDF                            \ Analog watchdog
$00002000 constant DFSDM_DFSDM0_ISR_JCIP                            \ Injected conversion in progress status
$00004000 constant DFSDM_DFSDM0_ISR_RCIP                            \ Regular conversion in progress status
$00ff0000 constant DFSDM_DFSDM0_ISR_CKABF                           \ Clock absence flag
$ff000000 constant DFSDM_DFSDM0_ISR_SCDF                            \ short-circuit detector flag


\
\ @brief interrupt flag clear register
\ Address offset: 0x10C
\ Reset value: 0x00000000
\

$00000004 constant DFSDM_DFSDM0_ICR_CLRJOVRF                        \ Clear the injected conversion overrun flag
$00000008 constant DFSDM_DFSDM0_ICR_CLRROVRF                        \ Clear the regular conversion overrun flag
$00ff0000 constant DFSDM_DFSDM0_ICR_CLRCKABF                        \ Clear the clock absence flag
$ff000000 constant DFSDM_DFSDM0_ICR_CLRSCDF                         \ Clear the short-circuit detector flag


\
\ @brief injected channel group selection register
\ Address offset: 0x110
\ Reset value: 0x00000001
\

$000000ff constant DFSDM_DFSDM0_JCHGR_JCHG                          \ Injected channel group selection


\
\ @brief filter control register
\ Address offset: 0x114
\ Reset value: 0x00000000
\

$000000ff constant DFSDM_DFSDM0_FCR_IOSR                            \ Integrator oversampling ratio (averaging length)
$03ff0000 constant DFSDM_DFSDM0_FCR_FOSR                            \ Sinc filter oversampling ratio (decimation rate)
$e0000000 constant DFSDM_DFSDM0_FCR_FORD                            \ Sinc filter order


\
\ @brief data register for injected group
\ Address offset: 0x118
\ Reset value: 0x00000000
\

$00000007 constant DFSDM_DFSDM0_JDATAR_JDATACH                      \ Injected channel most recently converted
$ffffff00 constant DFSDM_DFSDM0_JDATAR_JDATA                        \ Injected group conversion data


\
\ @brief data register for the regular channel
\ Address offset: 0x11C
\ Reset value: 0x00000000
\

$00000007 constant DFSDM_DFSDM0_RDATAR_RDATACH                      \ Regular channel most recently converted
$00000010 constant DFSDM_DFSDM0_RDATAR_RPEND                        \ Regular channel pending data
$ffffff00 constant DFSDM_DFSDM0_RDATAR_RDATA                        \ Regular channel conversion data


\
\ @brief analog watchdog high threshold register
\ Address offset: 0x120
\ Reset value: 0x00000000
\

$0000000f constant DFSDM_DFSDM0_AWHTR_BKAWH                         \ Break signal assignment to analog watchdog high threshold event
$ffffff00 constant DFSDM_DFSDM0_AWHTR_AWHT                          \ Analog watchdog high threshold


\
\ @brief analog watchdog low threshold register
\ Address offset: 0x124
\ Reset value: 0x00000000
\

$0000000f constant DFSDM_DFSDM0_AWLTR_BKAWL                         \ Break signal assignment to analog watchdog low threshold event
$ffffff00 constant DFSDM_DFSDM0_AWLTR_AWLT                          \ Analog watchdog low threshold


\
\ @brief analog watchdog status register
\ Address offset: 0x128
\ Reset value: 0x00000000
\

$000000ff constant DFSDM_DFSDM0_AWSR_AWLTF                          \ Analog watchdog low threshold flag
$0000ff00 constant DFSDM_DFSDM0_AWSR_AWHTF                          \ Analog watchdog high threshold flag


\
\ @brief analog watchdog clear flag register
\ Address offset: 0x12C
\ Reset value: 0x00000000
\

$000000ff constant DFSDM_DFSDM0_AWCFR_CLRAWLTF                      \ Clear the analog watchdog low threshold flag
$0000ff00 constant DFSDM_DFSDM0_AWCFR_CLRAWHTF                      \ Clear the analog watchdog high threshold flag


\
\ @brief Extremes detector maximum register
\ Address offset: 0x130
\ Reset value: 0x80000000
\

$00000007 constant DFSDM_DFSDM0_EXMAX_EXMAXCH                       \ Extremes detector maximum data channel
$ffffff00 constant DFSDM_DFSDM0_EXMAX_EXMAX                         \ Extremes detector maximum value


\
\ @brief Extremes detector minimum register
\ Address offset: 0x134
\ Reset value: 0x7FFFFF00
\

$00000007 constant DFSDM_DFSDM0_EXMIN_EXMINCH                       \ Extremes detector minimum data channel
$ffffff00 constant DFSDM_DFSDM0_EXMIN_EXMIN                         \ EXMIN


\
\ @brief conversion timer register
\ Address offset: 0x138
\ Reset value: 0x00000000
\

$fffffff0 constant DFSDM_DFSDM0_CNVTIMR_CNVCNT                      \ 28-bit timer counting conversion time t = CNVCNT[27:0] / fDFSDM_CKIN


\
\ @brief control register 1
\ Address offset: 0x200
\ Reset value: 0x00000000
\

$00000001 constant DFSDM_DFSDM1_CR1_DFEN                            \ DFSDM enable
$00000002 constant DFSDM_DFSDM1_CR1_JSWSTART                        \ Start a conversion of the injected group of channels
$00000008 constant DFSDM_DFSDM1_CR1_JSYNC                           \ Launch an injected conversion synchronously with the DFSDM0 JSWSTART trigger
$00000010 constant DFSDM_DFSDM1_CR1_JSCAN                           \ Scanning conversion mode for injected conversions
$00000020 constant DFSDM_DFSDM1_CR1_JDMAEN                          \ DMA channel enabled to read data for the injected channel group
$00000700 constant DFSDM_DFSDM1_CR1_JEXTSEL                         \ Trigger signal selection for launching injected conversions
$00006000 constant DFSDM_DFSDM1_CR1_JEXTEN                          \ Trigger enable and trigger edge selection for injected conversions
$00020000 constant DFSDM_DFSDM1_CR1_RSWSTART                        \ Software start of a conversion on the regular channel
$00040000 constant DFSDM_DFSDM1_CR1_RCONT                           \ Continuous mode selection for regular conversions
$00080000 constant DFSDM_DFSDM1_CR1_RSYNC                           \ Launch regular conversion synchronously with DFSDM0
$00200000 constant DFSDM_DFSDM1_CR1_RDMAEN                          \ DMA channel enabled to read data for the regular conversion
$07000000 constant DFSDM_DFSDM1_CR1_RCH                             \ Regular channel selection
$20000000 constant DFSDM_DFSDM1_CR1_FAST                            \ Fast conversion mode selection for regular conversions
$40000000 constant DFSDM_DFSDM1_CR1_AWFSEL                          \ Analog watchdog fast mode select


\
\ @brief control register 2
\ Address offset: 0x204
\ Reset value: 0x00000000
\

$00000001 constant DFSDM_DFSDM1_CR2_JEOCIE                          \ Injected end of conversion interrupt enable
$00000002 constant DFSDM_DFSDM1_CR2_REOCIE                          \ Regular end of conversion interrupt enable
$00000004 constant DFSDM_DFSDM1_CR2_JOVRIE                          \ Injected data overrun interrupt enable
$00000008 constant DFSDM_DFSDM1_CR2_ROVRIE                          \ Regular data overrun interrupt enable
$00000010 constant DFSDM_DFSDM1_CR2_AWDIE                           \ Analog watchdog interrupt enable
$00000020 constant DFSDM_DFSDM1_CR2_SCDIE                           \ Short-circuit detector interrupt enable
$00000040 constant DFSDM_DFSDM1_CR2_CKABIE                          \ Clock absence interrupt enable
$0000ff00 constant DFSDM_DFSDM1_CR2_EXCH                            \ Extremes detector channel selection
$00ff0000 constant DFSDM_DFSDM1_CR2_AWDCH                           \ Analog watchdog channel selection


\
\ @brief interrupt and status register
\ Address offset: 0x208
\ Reset value: 0x00FF0000
\

$00000001 constant DFSDM_DFSDM1_ISR_JEOCF                           \ End of injected conversion flag
$00000002 constant DFSDM_DFSDM1_ISR_REOCF                           \ End of regular conversion flag
$00000004 constant DFSDM_DFSDM1_ISR_JOVRF                           \ Injected conversion overrun flag
$00000008 constant DFSDM_DFSDM1_ISR_ROVRF                           \ Regular conversion overrun flag
$00000010 constant DFSDM_DFSDM1_ISR_AWDF                            \ Analog watchdog
$00002000 constant DFSDM_DFSDM1_ISR_JCIP                            \ Injected conversion in progress status
$00004000 constant DFSDM_DFSDM1_ISR_RCIP                            \ Regular conversion in progress status
$00ff0000 constant DFSDM_DFSDM1_ISR_CKABF                           \ Clock absence flag
$ff000000 constant DFSDM_DFSDM1_ISR_SCDF                            \ short-circuit detector flag


\
\ @brief interrupt flag clear register
\ Address offset: 0x20C
\ Reset value: 0x00000000
\

$00000004 constant DFSDM_DFSDM1_ICR_CLRJOVRF                        \ Clear the injected conversion overrun flag
$00000008 constant DFSDM_DFSDM1_ICR_CLRROVRF                        \ Clear the regular conversion overrun flag
$00ff0000 constant DFSDM_DFSDM1_ICR_CLRCKABF                        \ Clear the clock absence flag
$ff000000 constant DFSDM_DFSDM1_ICR_CLRSCDF                         \ Clear the short-circuit detector flag


\
\ @brief injected channel group selection register
\ Address offset: 0x210
\ Reset value: 0x00000001
\

$000000ff constant DFSDM_DFSDM1_JCHGR_JCHG                          \ Injected channel group selection


\
\ @brief filter control register
\ Address offset: 0x214
\ Reset value: 0x00000000
\

$000000ff constant DFSDM_DFSDM1_FCR_IOSR                            \ Integrator oversampling ratio (averaging length)
$03ff0000 constant DFSDM_DFSDM1_FCR_FOSR                            \ Sinc filter oversampling ratio (decimation rate)
$e0000000 constant DFSDM_DFSDM1_FCR_FORD                            \ Sinc filter order


\
\ @brief data register for injected group
\ Address offset: 0x218
\ Reset value: 0x00000000
\

$00000007 constant DFSDM_DFSDM1_JDATAR_JDATACH                      \ Injected channel most recently converted
$ffffff00 constant DFSDM_DFSDM1_JDATAR_JDATA                        \ Injected group conversion data


\
\ @brief data register for the regular channel
\ Address offset: 0x21C
\ Reset value: 0x00000000
\

$00000007 constant DFSDM_DFSDM1_RDATAR_RDATACH                      \ Regular channel most recently converted
$00000010 constant DFSDM_DFSDM1_RDATAR_RPEND                        \ Regular channel pending data
$ffffff00 constant DFSDM_DFSDM1_RDATAR_RDATA                        \ Regular channel conversion data


\
\ @brief analog watchdog high threshold register
\ Address offset: 0x220
\ Reset value: 0x00000000
\

$0000000f constant DFSDM_DFSDM1_AWHTR_BKAWH                         \ Break signal assignment to analog watchdog high threshold event
$ffffff00 constant DFSDM_DFSDM1_AWHTR_AWHT                          \ Analog watchdog high threshold


\
\ @brief analog watchdog low threshold register
\ Address offset: 0x224
\ Reset value: 0x00000000
\

$0000000f constant DFSDM_DFSDM1_AWLTR_BKAWL                         \ Break signal assignment to analog watchdog low threshold event
$ffffff00 constant DFSDM_DFSDM1_AWLTR_AWLT                          \ Analog watchdog low threshold


\
\ @brief analog watchdog status register
\ Address offset: 0x228
\ Reset value: 0x00000000
\

$000000ff constant DFSDM_DFSDM1_AWSR_AWLTF                          \ Analog watchdog low threshold flag
$0000ff00 constant DFSDM_DFSDM1_AWSR_AWHTF                          \ Analog watchdog high threshold flag


\
\ @brief analog watchdog clear flag register
\ Address offset: 0x22C
\ Reset value: 0x00000000
\

$000000ff constant DFSDM_DFSDM1_AWCFR_CLRAWLTF                      \ Clear the analog watchdog low threshold flag
$0000ff00 constant DFSDM_DFSDM1_AWCFR_CLRAWHTF                      \ Clear the analog watchdog high threshold flag


\
\ @brief Extremes detector maximum register
\ Address offset: 0x230
\ Reset value: 0x80000000
\

$00000007 constant DFSDM_DFSDM1_EXMAX_EXMAXCH                       \ Extremes detector maximum data channel
$ffffff00 constant DFSDM_DFSDM1_EXMAX_EXMAX                         \ Extremes detector maximum value


\
\ @brief Extremes detector minimum register
\ Address offset: 0x234
\ Reset value: 0x7FFFFF00
\

$00000007 constant DFSDM_DFSDM1_EXMIN_EXMINCH                       \ Extremes detector minimum data channel
$ffffff00 constant DFSDM_DFSDM1_EXMIN_EXMIN                         \ EXMIN


\
\ @brief conversion timer register
\ Address offset: 0x238
\ Reset value: 0x00000000
\

$fffffff0 constant DFSDM_DFSDM1_CNVTIMR_CNVCNT                      \ 28-bit timer counting conversion time t = CNVCNT[27:0] / fDFSDM_CKIN


\
\ @brief control register 1
\ Address offset: 0x300
\ Reset value: 0x00000000
\

$00000001 constant DFSDM_DFSDM2_CR1_DFEN                            \ DFSDM enable
$00000002 constant DFSDM_DFSDM2_CR1_JSWSTART                        \ Start a conversion of the injected group of channels
$00000008 constant DFSDM_DFSDM2_CR1_JSYNC                           \ Launch an injected conversion synchronously with the DFSDM0 JSWSTART trigger
$00000010 constant DFSDM_DFSDM2_CR1_JSCAN                           \ Scanning conversion mode for injected conversions
$00000020 constant DFSDM_DFSDM2_CR1_JDMAEN                          \ DMA channel enabled to read data for the injected channel group
$00000700 constant DFSDM_DFSDM2_CR1_JEXTSEL                         \ Trigger signal selection for launching injected conversions
$00006000 constant DFSDM_DFSDM2_CR1_JEXTEN                          \ Trigger enable and trigger edge selection for injected conversions
$00020000 constant DFSDM_DFSDM2_CR1_RSWSTART                        \ Software start of a conversion on the regular channel
$00040000 constant DFSDM_DFSDM2_CR1_RCONT                           \ Continuous mode selection for regular conversions
$00080000 constant DFSDM_DFSDM2_CR1_RSYNC                           \ Launch regular conversion synchronously with DFSDM0
$00200000 constant DFSDM_DFSDM2_CR1_RDMAEN                          \ DMA channel enabled to read data for the regular conversion
$07000000 constant DFSDM_DFSDM2_CR1_RCH                             \ Regular channel selection
$20000000 constant DFSDM_DFSDM2_CR1_FAST                            \ Fast conversion mode selection for regular conversions
$40000000 constant DFSDM_DFSDM2_CR1_AWFSEL                          \ Analog watchdog fast mode select


\
\ @brief control register 2
\ Address offset: 0x304
\ Reset value: 0x00000000
\

$00000001 constant DFSDM_DFSDM2_CR2_JEOCIE                          \ Injected end of conversion interrupt enable
$00000002 constant DFSDM_DFSDM2_CR2_REOCIE                          \ Regular end of conversion interrupt enable
$00000004 constant DFSDM_DFSDM2_CR2_JOVRIE                          \ Injected data overrun interrupt enable
$00000008 constant DFSDM_DFSDM2_CR2_ROVRIE                          \ Regular data overrun interrupt enable
$00000010 constant DFSDM_DFSDM2_CR2_AWDIE                           \ Analog watchdog interrupt enable
$00000020 constant DFSDM_DFSDM2_CR2_SCDIE                           \ Short-circuit detector interrupt enable
$00000040 constant DFSDM_DFSDM2_CR2_CKABIE                          \ Clock absence interrupt enable
$0000ff00 constant DFSDM_DFSDM2_CR2_EXCH                            \ Extremes detector channel selection
$00ff0000 constant DFSDM_DFSDM2_CR2_AWDCH                           \ Analog watchdog channel selection


\
\ @brief interrupt and status register
\ Address offset: 0x308
\ Reset value: 0x00FF0000
\

$00000001 constant DFSDM_DFSDM2_ISR_JEOCF                           \ End of injected conversion flag
$00000002 constant DFSDM_DFSDM2_ISR_REOCF                           \ End of regular conversion flag
$00000004 constant DFSDM_DFSDM2_ISR_JOVRF                           \ Injected conversion overrun flag
$00000008 constant DFSDM_DFSDM2_ISR_ROVRF                           \ Regular conversion overrun flag
$00000010 constant DFSDM_DFSDM2_ISR_AWDF                            \ Analog watchdog
$00002000 constant DFSDM_DFSDM2_ISR_JCIP                            \ Injected conversion in progress status
$00004000 constant DFSDM_DFSDM2_ISR_RCIP                            \ Regular conversion in progress status
$00ff0000 constant DFSDM_DFSDM2_ISR_CKABF                           \ Clock absence flag
$ff000000 constant DFSDM_DFSDM2_ISR_SCDF                            \ short-circuit detector flag


\
\ @brief interrupt flag clear register
\ Address offset: 0x30C
\ Reset value: 0x00000000
\

$00000004 constant DFSDM_DFSDM2_ICR_CLRJOVRF                        \ Clear the injected conversion overrun flag
$00000008 constant DFSDM_DFSDM2_ICR_CLRROVRF                        \ Clear the regular conversion overrun flag
$00ff0000 constant DFSDM_DFSDM2_ICR_CLRCKABF                        \ Clear the clock absence flag
$ff000000 constant DFSDM_DFSDM2_ICR_CLRSCDF                         \ Clear the short-circuit detector flag


\
\ @brief injected channel group selection register
\ Address offset: 0x310
\ Reset value: 0x00000001
\

$000000ff constant DFSDM_DFSDM2_JCHGR_JCHG                          \ Injected channel group selection


\
\ @brief filter control register
\ Address offset: 0x314
\ Reset value: 0x00000000
\

$000000ff constant DFSDM_DFSDM2_FCR_IOSR                            \ Integrator oversampling ratio (averaging length)
$03ff0000 constant DFSDM_DFSDM2_FCR_FOSR                            \ Sinc filter oversampling ratio (decimation rate)
$e0000000 constant DFSDM_DFSDM2_FCR_FORD                            \ Sinc filter order


\
\ @brief data register for injected group
\ Address offset: 0x318
\ Reset value: 0x00000000
\

$00000007 constant DFSDM_DFSDM2_JDATAR_JDATACH                      \ Injected channel most recently converted
$ffffff00 constant DFSDM_DFSDM2_JDATAR_JDATA                        \ Injected group conversion data


\
\ @brief data register for the regular channel
\ Address offset: 0x31C
\ Reset value: 0x00000000
\

$00000007 constant DFSDM_DFSDM2_RDATAR_RDATACH                      \ Regular channel most recently converted
$00000010 constant DFSDM_DFSDM2_RDATAR_RPEND                        \ Regular channel pending data
$ffffff00 constant DFSDM_DFSDM2_RDATAR_RDATA                        \ Regular channel conversion data


\
\ @brief analog watchdog high threshold register
\ Address offset: 0x320
\ Reset value: 0x00000000
\

$0000000f constant DFSDM_DFSDM2_AWHTR_BKAWH                         \ Break signal assignment to analog watchdog high threshold event
$ffffff00 constant DFSDM_DFSDM2_AWHTR_AWHT                          \ Analog watchdog high threshold


\
\ @brief analog watchdog low threshold register
\ Address offset: 0x324
\ Reset value: 0x00000000
\

$0000000f constant DFSDM_DFSDM2_AWLTR_BKAWL                         \ Break signal assignment to analog watchdog low threshold event
$ffffff00 constant DFSDM_DFSDM2_AWLTR_AWLT                          \ Analog watchdog low threshold


\
\ @brief analog watchdog status register
\ Address offset: 0x328
\ Reset value: 0x00000000
\

$000000ff constant DFSDM_DFSDM2_AWSR_AWLTF                          \ Analog watchdog low threshold flag
$0000ff00 constant DFSDM_DFSDM2_AWSR_AWHTF                          \ Analog watchdog high threshold flag


\
\ @brief analog watchdog clear flag register
\ Address offset: 0x32C
\ Reset value: 0x00000000
\

$000000ff constant DFSDM_DFSDM2_AWCFR_CLRAWLTF                      \ Clear the analog watchdog low threshold flag
$0000ff00 constant DFSDM_DFSDM2_AWCFR_CLRAWHTF                      \ Clear the analog watchdog high threshold flag


\
\ @brief Extremes detector maximum register
\ Address offset: 0x330
\ Reset value: 0x80000000
\

$00000007 constant DFSDM_DFSDM2_EXMAX_EXMAXCH                       \ Extremes detector maximum data channel
$ffffff00 constant DFSDM_DFSDM2_EXMAX_EXMAX                         \ Extremes detector maximum value


\
\ @brief Extremes detector minimum register
\ Address offset: 0x334
\ Reset value: 0x7FFFFF00
\

$00000007 constant DFSDM_DFSDM2_EXMIN_EXMINCH                       \ Extremes detector minimum data channel
$ffffff00 constant DFSDM_DFSDM2_EXMIN_EXMIN                         \ EXMIN


\
\ @brief conversion timer register
\ Address offset: 0x338
\ Reset value: 0x00000000
\

$fffffff0 constant DFSDM_DFSDM2_CNVTIMR_CNVCNT                      \ 28-bit timer counting conversion time t = CNVCNT[27:0] / fDFSDM_CKIN


\
\ @brief control register 1
\ Address offset: 0x400
\ Reset value: 0x00000000
\

$00000001 constant DFSDM_DFSDM3_CR1_DFEN                            \ DFSDM enable
$00000002 constant DFSDM_DFSDM3_CR1_JSWSTART                        \ Start a conversion of the injected group of channels
$00000008 constant DFSDM_DFSDM3_CR1_JSYNC                           \ Launch an injected conversion synchronously with the DFSDM0 JSWSTART trigger
$00000010 constant DFSDM_DFSDM3_CR1_JSCAN                           \ Scanning conversion mode for injected conversions
$00000020 constant DFSDM_DFSDM3_CR1_JDMAEN                          \ DMA channel enabled to read data for the injected channel group
$00000700 constant DFSDM_DFSDM3_CR1_JEXTSEL                         \ Trigger signal selection for launching injected conversions
$00006000 constant DFSDM_DFSDM3_CR1_JEXTEN                          \ Trigger enable and trigger edge selection for injected conversions
$00020000 constant DFSDM_DFSDM3_CR1_RSWSTART                        \ Software start of a conversion on the regular channel
$00040000 constant DFSDM_DFSDM3_CR1_RCONT                           \ Continuous mode selection for regular conversions
$00080000 constant DFSDM_DFSDM3_CR1_RSYNC                           \ Launch regular conversion synchronously with DFSDM0
$00200000 constant DFSDM_DFSDM3_CR1_RDMAEN                          \ DMA channel enabled to read data for the regular conversion
$07000000 constant DFSDM_DFSDM3_CR1_RCH                             \ Regular channel selection
$20000000 constant DFSDM_DFSDM3_CR1_FAST                            \ Fast conversion mode selection for regular conversions
$40000000 constant DFSDM_DFSDM3_CR1_AWFSEL                          \ Analog watchdog fast mode select


\
\ @brief control register 2
\ Address offset: 0x404
\ Reset value: 0x00000000
\

$00000001 constant DFSDM_DFSDM3_CR2_JEOCIE                          \ Injected end of conversion interrupt enable
$00000002 constant DFSDM_DFSDM3_CR2_REOCIE                          \ Regular end of conversion interrupt enable
$00000004 constant DFSDM_DFSDM3_CR2_JOVRIE                          \ Injected data overrun interrupt enable
$00000008 constant DFSDM_DFSDM3_CR2_ROVRIE                          \ Regular data overrun interrupt enable
$00000010 constant DFSDM_DFSDM3_CR2_AWDIE                           \ Analog watchdog interrupt enable
$00000020 constant DFSDM_DFSDM3_CR2_SCDIE                           \ Short-circuit detector interrupt enable
$00000040 constant DFSDM_DFSDM3_CR2_CKABIE                          \ Clock absence interrupt enable
$0000ff00 constant DFSDM_DFSDM3_CR2_EXCH                            \ Extremes detector channel selection
$00ff0000 constant DFSDM_DFSDM3_CR2_AWDCH                           \ Analog watchdog channel selection


\
\ @brief interrupt and status register
\ Address offset: 0x408
\ Reset value: 0x00FF0000
\

$00000001 constant DFSDM_DFSDM3_ISR_JEOCF                           \ End of injected conversion flag
$00000002 constant DFSDM_DFSDM3_ISR_REOCF                           \ End of regular conversion flag
$00000004 constant DFSDM_DFSDM3_ISR_JOVRF                           \ Injected conversion overrun flag
$00000008 constant DFSDM_DFSDM3_ISR_ROVRF                           \ Regular conversion overrun flag
$00000010 constant DFSDM_DFSDM3_ISR_AWDF                            \ Analog watchdog
$00002000 constant DFSDM_DFSDM3_ISR_JCIP                            \ Injected conversion in progress status
$00004000 constant DFSDM_DFSDM3_ISR_RCIP                            \ Regular conversion in progress status
$00ff0000 constant DFSDM_DFSDM3_ISR_CKABF                           \ Clock absence flag
$ff000000 constant DFSDM_DFSDM3_ISR_SCDF                            \ short-circuit detector flag


\
\ @brief interrupt flag clear register
\ Address offset: 0x40C
\ Reset value: 0x00000000
\

$00000004 constant DFSDM_DFSDM3_ICR_CLRJOVRF                        \ Clear the injected conversion overrun flag
$00000008 constant DFSDM_DFSDM3_ICR_CLRROVRF                        \ Clear the regular conversion overrun flag
$00ff0000 constant DFSDM_DFSDM3_ICR_CLRCKABF                        \ Clear the clock absence flag
$ff000000 constant DFSDM_DFSDM3_ICR_CLRSCDF                         \ Clear the short-circuit detector flag


\
\ @brief injected channel group selection register
\ Address offset: 0x410
\ Reset value: 0x00000001
\

$000000ff constant DFSDM_DFSDM3_JCHGR_JCHG                          \ Injected channel group selection


\
\ @brief filter control register
\ Address offset: 0x414
\ Reset value: 0x00000000
\

$000000ff constant DFSDM_DFSDM3_FCR_IOSR                            \ Integrator oversampling ratio (averaging length)
$03ff0000 constant DFSDM_DFSDM3_FCR_FOSR                            \ Sinc filter oversampling ratio (decimation rate)
$e0000000 constant DFSDM_DFSDM3_FCR_FORD                            \ Sinc filter order


\
\ @brief data register for injected group
\ Address offset: 0x418
\ Reset value: 0x00000000
\

$00000007 constant DFSDM_DFSDM3_JDATAR_JDATACH                      \ Injected channel most recently converted
$ffffff00 constant DFSDM_DFSDM3_JDATAR_JDATA                        \ Injected group conversion data


\
\ @brief data register for the regular channel
\ Address offset: 0x41C
\ Reset value: 0x00000000
\

$00000007 constant DFSDM_DFSDM3_RDATAR_RDATACH                      \ Regular channel most recently converted
$00000010 constant DFSDM_DFSDM3_RDATAR_RPEND                        \ Regular channel pending data
$ffffff00 constant DFSDM_DFSDM3_RDATAR_RDATA                        \ Regular channel conversion data


\
\ @brief analog watchdog high threshold register
\ Address offset: 0x420
\ Reset value: 0x00000000
\

$0000000f constant DFSDM_DFSDM3_AWHTR_BKAWH                         \ Break signal assignment to analog watchdog high threshold event
$ffffff00 constant DFSDM_DFSDM3_AWHTR_AWHT                          \ Analog watchdog high threshold


\
\ @brief analog watchdog low threshold register
\ Address offset: 0x424
\ Reset value: 0x00000000
\

$0000000f constant DFSDM_DFSDM3_AWLTR_BKAWL                         \ Break signal assignment to analog watchdog low threshold event
$ffffff00 constant DFSDM_DFSDM3_AWLTR_AWLT                          \ Analog watchdog low threshold


\
\ @brief analog watchdog status register
\ Address offset: 0x428
\ Reset value: 0x00000000
\

$000000ff constant DFSDM_DFSDM3_AWSR_AWLTF                          \ Analog watchdog low threshold flag
$0000ff00 constant DFSDM_DFSDM3_AWSR_AWHTF                          \ Analog watchdog high threshold flag


\
\ @brief analog watchdog clear flag register
\ Address offset: 0x42C
\ Reset value: 0x00000000
\

$000000ff constant DFSDM_DFSDM3_AWCFR_CLRAWLTF                      \ Clear the analog watchdog low threshold flag
$0000ff00 constant DFSDM_DFSDM3_AWCFR_CLRAWHTF                      \ Clear the analog watchdog high threshold flag


\
\ @brief Extremes detector maximum register
\ Address offset: 0x430
\ Reset value: 0x80000000
\

$00000007 constant DFSDM_DFSDM3_EXMAX_EXMAXCH                       \ Extremes detector maximum data channel
$ffffff00 constant DFSDM_DFSDM3_EXMAX_EXMAX                         \ Extremes detector maximum value


\
\ @brief Extremes detector minimum register
\ Address offset: 0x434
\ Reset value: 0x7FFFFF00
\

$00000007 constant DFSDM_DFSDM3_EXMIN_EXMINCH                       \ Extremes detector minimum data channel
$ffffff00 constant DFSDM_DFSDM3_EXMIN_EXMIN                         \ EXMIN


\
\ @brief conversion timer register
\ Address offset: 0x438
\ Reset value: 0x00000000
\

$fffffff0 constant DFSDM_DFSDM3_CNVTIMR_CNVCNT                      \ 28-bit timer counting conversion time t = CNVCNT[27:0] / fDFSDM_CKIN


\
\ @brief Digital filter for sigma delta modulators
\
$40016000 constant DFSDM_CHCFG0R1  \ offset: 0x00 : channel configuration y register
$40016004 constant DFSDM_CHCFG0R2  \ offset: 0x04 : channel configuration y register
$40016008 constant DFSDM_AWSCD0R  \ offset: 0x08 : analog watchdog and short-circuit detector register
$4001600c constant DFSDM_CHWDAT0R  \ offset: 0x0C : channel watchdog filter data register
$40016010 constant DFSDM_CHDATIN0R  \ offset: 0x10 : channel data input register
$40016020 constant DFSDM_CHCFG1R1  \ offset: 0x20 : CHCFG1R1
$40016024 constant DFSDM_CHCFG1R2  \ offset: 0x24 : CHCFG1R2
$40016028 constant DFSDM_AWSCD1R  \ offset: 0x28 : AWSCD1R
$4001602c constant DFSDM_CHWDAT1R  \ offset: 0x2C : CHWDAT1R
$40016030 constant DFSDM_CHDATIN1R  \ offset: 0x30 : CHDATIN1R
$40016040 constant DFSDM_CHCFG2R1  \ offset: 0x40 : CHCFG2R1
$40016044 constant DFSDM_CHCFG2R2  \ offset: 0x44 : CHCFG2R2
$40016048 constant DFSDM_AWSCD2R  \ offset: 0x48 : AWSCD2R
$4001604c constant DFSDM_CHWDAT2R  \ offset: 0x4C : CHWDAT2R
$40016050 constant DFSDM_CHDATIN2R  \ offset: 0x50 : CHDATIN2R
$40016060 constant DFSDM_CHCFG3R1  \ offset: 0x60 : CHCFG3R1
$40016064 constant DFSDM_CHCFG3R2  \ offset: 0x64 : CHCFG3R2
$40016068 constant DFSDM_AWSCD3R  \ offset: 0x68 : AWSCD3R
$4001606c constant DFSDM_CHWDAT3R  \ offset: 0x6C : CHWDAT3R
$40016070 constant DFSDM_CHDATIN3R  \ offset: 0x70 : CHDATIN3R
$40016080 constant DFSDM_CHCFG4R1  \ offset: 0x80 : CHCFG4R1
$40016084 constant DFSDM_CHCFG4R2  \ offset: 0x84 : CHCFG4R2
$40016088 constant DFSDM_AWSCD4R  \ offset: 0x88 : AWSCD4R
$4001608c constant DFSDM_CHWDAT4R  \ offset: 0x8C : CHWDAT4R
$40016090 constant DFSDM_CHDATIN4R  \ offset: 0x90 : CHDATIN4R
$400160a0 constant DFSDM_CHCFG5R1  \ offset: 0xA0 : CHCFG5R1
$400160a4 constant DFSDM_CHCFG5R2  \ offset: 0xA4 : CHCFG5R2
$400160a8 constant DFSDM_AWSCD5R  \ offset: 0xA8 : AWSCD5R
$400160ac constant DFSDM_CHWDAT5R  \ offset: 0xAC : CHWDAT5R
$400160b0 constant DFSDM_CHDATIN5R  \ offset: 0xB0 : CHDATIN5R
$400160c0 constant DFSDM_CHCFG6R1  \ offset: 0xC0 : CHCFG6R1
$400160c4 constant DFSDM_CHCFG6R2  \ offset: 0xC4 : CHCFG6R2
$400160c8 constant DFSDM_AWSCD6R  \ offset: 0xC8 : AWSCD6R
$400160cc constant DFSDM_CHWDAT6R  \ offset: 0xCC : CHWDAT6R
$400160d0 constant DFSDM_CHDATIN6R  \ offset: 0xD0 : CHDATIN6R
$400160e0 constant DFSDM_CHCFG7R1  \ offset: 0xE0 : CHCFG7R1
$400160e4 constant DFSDM_CHCFG7R2  \ offset: 0xE4 : CHCFG7R2
$400160e8 constant DFSDM_AWSCD7R  \ offset: 0xE8 : AWSCD7R
$400160ec constant DFSDM_CHWDAT7R  \ offset: 0xEC : CHWDAT7R
$400160f0 constant DFSDM_CHDATIN7R  \ offset: 0xF0 : CHDATIN7R
$40016100 constant DFSDM_DFSDM0_CR1  \ offset: 0x100 : control register 1
$40016104 constant DFSDM_DFSDM0_CR2  \ offset: 0x104 : control register 2
$40016108 constant DFSDM_DFSDM0_ISR  \ offset: 0x108 : interrupt and status register
$4001610c constant DFSDM_DFSDM0_ICR  \ offset: 0x10C : interrupt flag clear register
$40016110 constant DFSDM_DFSDM0_JCHGR  \ offset: 0x110 : injected channel group selection register
$40016114 constant DFSDM_DFSDM0_FCR  \ offset: 0x114 : filter control register
$40016118 constant DFSDM_DFSDM0_JDATAR  \ offset: 0x118 : data register for injected group
$4001611c constant DFSDM_DFSDM0_RDATAR  \ offset: 0x11C : data register for the regular channel
$40016120 constant DFSDM_DFSDM0_AWHTR  \ offset: 0x120 : analog watchdog high threshold register
$40016124 constant DFSDM_DFSDM0_AWLTR  \ offset: 0x124 : analog watchdog low threshold register
$40016128 constant DFSDM_DFSDM0_AWSR  \ offset: 0x128 : analog watchdog status register
$4001612c constant DFSDM_DFSDM0_AWCFR  \ offset: 0x12C : analog watchdog clear flag register
$40016130 constant DFSDM_DFSDM0_EXMAX  \ offset: 0x130 : Extremes detector maximum register
$40016134 constant DFSDM_DFSDM0_EXMIN  \ offset: 0x134 : Extremes detector minimum register
$40016138 constant DFSDM_DFSDM0_CNVTIMR  \ offset: 0x138 : conversion timer register
$40016200 constant DFSDM_DFSDM1_CR1  \ offset: 0x200 : control register 1
$40016204 constant DFSDM_DFSDM1_CR2  \ offset: 0x204 : control register 2
$40016208 constant DFSDM_DFSDM1_ISR  \ offset: 0x208 : interrupt and status register
$4001620c constant DFSDM_DFSDM1_ICR  \ offset: 0x20C : interrupt flag clear register
$40016210 constant DFSDM_DFSDM1_JCHGR  \ offset: 0x210 : injected channel group selection register
$40016214 constant DFSDM_DFSDM1_FCR  \ offset: 0x214 : filter control register
$40016218 constant DFSDM_DFSDM1_JDATAR  \ offset: 0x218 : data register for injected group
$4001621c constant DFSDM_DFSDM1_RDATAR  \ offset: 0x21C : data register for the regular channel
$40016220 constant DFSDM_DFSDM1_AWHTR  \ offset: 0x220 : analog watchdog high threshold register
$40016224 constant DFSDM_DFSDM1_AWLTR  \ offset: 0x224 : analog watchdog low threshold register
$40016228 constant DFSDM_DFSDM1_AWSR  \ offset: 0x228 : analog watchdog status register
$4001622c constant DFSDM_DFSDM1_AWCFR  \ offset: 0x22C : analog watchdog clear flag register
$40016230 constant DFSDM_DFSDM1_EXMAX  \ offset: 0x230 : Extremes detector maximum register
$40016234 constant DFSDM_DFSDM1_EXMIN  \ offset: 0x234 : Extremes detector minimum register
$40016238 constant DFSDM_DFSDM1_CNVTIMR  \ offset: 0x238 : conversion timer register
$40016300 constant DFSDM_DFSDM2_CR1  \ offset: 0x300 : control register 1
$40016304 constant DFSDM_DFSDM2_CR2  \ offset: 0x304 : control register 2
$40016308 constant DFSDM_DFSDM2_ISR  \ offset: 0x308 : interrupt and status register
$4001630c constant DFSDM_DFSDM2_ICR  \ offset: 0x30C : interrupt flag clear register
$40016310 constant DFSDM_DFSDM2_JCHGR  \ offset: 0x310 : injected channel group selection register
$40016314 constant DFSDM_DFSDM2_FCR  \ offset: 0x314 : filter control register
$40016318 constant DFSDM_DFSDM2_JDATAR  \ offset: 0x318 : data register for injected group
$4001631c constant DFSDM_DFSDM2_RDATAR  \ offset: 0x31C : data register for the regular channel
$40016320 constant DFSDM_DFSDM2_AWHTR  \ offset: 0x320 : analog watchdog high threshold register
$40016324 constant DFSDM_DFSDM2_AWLTR  \ offset: 0x324 : analog watchdog low threshold register
$40016328 constant DFSDM_DFSDM2_AWSR  \ offset: 0x328 : analog watchdog status register
$4001632c constant DFSDM_DFSDM2_AWCFR  \ offset: 0x32C : analog watchdog clear flag register
$40016330 constant DFSDM_DFSDM2_EXMAX  \ offset: 0x330 : Extremes detector maximum register
$40016334 constant DFSDM_DFSDM2_EXMIN  \ offset: 0x334 : Extremes detector minimum register
$40016338 constant DFSDM_DFSDM2_CNVTIMR  \ offset: 0x338 : conversion timer register
$40016400 constant DFSDM_DFSDM3_CR1  \ offset: 0x400 : control register 1
$40016404 constant DFSDM_DFSDM3_CR2  \ offset: 0x404 : control register 2
$40016408 constant DFSDM_DFSDM3_ISR  \ offset: 0x408 : interrupt and status register
$4001640c constant DFSDM_DFSDM3_ICR  \ offset: 0x40C : interrupt flag clear register
$40016410 constant DFSDM_DFSDM3_JCHGR  \ offset: 0x410 : injected channel group selection register
$40016414 constant DFSDM_DFSDM3_FCR  \ offset: 0x414 : filter control register
$40016418 constant DFSDM_DFSDM3_JDATAR  \ offset: 0x418 : data register for injected group
$4001641c constant DFSDM_DFSDM3_RDATAR  \ offset: 0x41C : data register for the regular channel
$40016420 constant DFSDM_DFSDM3_AWHTR  \ offset: 0x420 : analog watchdog high threshold register
$40016424 constant DFSDM_DFSDM3_AWLTR  \ offset: 0x424 : analog watchdog low threshold register
$40016428 constant DFSDM_DFSDM3_AWSR  \ offset: 0x428 : analog watchdog status register
$4001642c constant DFSDM_DFSDM3_AWCFR  \ offset: 0x42C : analog watchdog clear flag register
$40016430 constant DFSDM_DFSDM3_EXMAX  \ offset: 0x430 : Extremes detector maximum register
$40016434 constant DFSDM_DFSDM3_EXMIN  \ offset: 0x434 : Extremes detector minimum register
$40016438 constant DFSDM_DFSDM3_CNVTIMR  \ offset: 0x438 : conversion timer register

