\
\ @file sec_dfsdm1.fs
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

$00000003 constant SEC_DFSDM1_CH0CFGR1_SITP                         \ SITP
$0000000c constant SEC_DFSDM1_CH0CFGR1_SPICKSEL                     \ SPICKSEL
$00000020 constant SEC_DFSDM1_CH0CFGR1_SCDEN                        \ SCDEN
$00000040 constant SEC_DFSDM1_CH0CFGR1_CKABEN                       \ CKABEN
$00000080 constant SEC_DFSDM1_CH0CFGR1_CHEN                         \ CHEN
$00000100 constant SEC_DFSDM1_CH0CFGR1_CHINSEL                      \ CHINSEL
$00003000 constant SEC_DFSDM1_CH0CFGR1_DATMPX                       \ DATMPX
$0000c000 constant SEC_DFSDM1_CH0CFGR1_DATPACK                      \ DATPACK
$00ff0000 constant SEC_DFSDM1_CH0CFGR1_CKOUTDIV                     \ CKOUTDIV
$40000000 constant SEC_DFSDM1_CH0CFGR1_CKOUTSRC                     \ CKOUTSRC
$80000000 constant SEC_DFSDM1_CH0CFGR1_DFSDMEN                      \ DFSDMEN


\
\ @brief channel configuration y register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$000000f8 constant SEC_DFSDM1_CH0CFGR2_DTRBS                        \ DTRBS
$ffffff00 constant SEC_DFSDM1_CH0CFGR2_OFFSET                       \ OFFSET


\
\ @brief analog watchdog and short-circuit detector register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$000000ff constant SEC_DFSDM1_CH0AWSCDR_SCDT                        \ SCDT
$0000f000 constant SEC_DFSDM1_CH0AWSCDR_BKSCD                       \ BKSCD
$001f0000 constant SEC_DFSDM1_CH0AWSCDR_AWFOSR                      \ AWFOSR
$00c00000 constant SEC_DFSDM1_CH0AWSCDR_AWFORD                      \ AWFORD


\
\ @brief channel watchdog filter data register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$0000ffff constant SEC_DFSDM1_CH0WDATR_WDATA                        \ WDATA


\
\ @brief channel data input register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$0000ffff constant SEC_DFSDM1_CH0DATINR_INDAT0                      \ INDAT0
$ffff0000 constant SEC_DFSDM1_CH0DATINR_INDAT1                      \ INDAT1


\
\ @brief DFSDM channel y delay register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$0000003f constant SEC_DFSDM1_CH0DLYR_PLSSKP                        \ Pulses to skip for input data skipping function


\
\ @brief CHCFG1R1
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000003 constant SEC_DFSDM1_CH1CFGR1_SITP                         \ SITP
$0000000c constant SEC_DFSDM1_CH1CFGR1_SPICKSEL                     \ SPICKSEL
$00000020 constant SEC_DFSDM1_CH1CFGR1_SCDEN                        \ SCDEN
$00000040 constant SEC_DFSDM1_CH1CFGR1_CKABEN                       \ CKABEN
$00000080 constant SEC_DFSDM1_CH1CFGR1_CHEN                         \ CHEN
$00000100 constant SEC_DFSDM1_CH1CFGR1_CHINSEL                      \ CHINSEL
$00003000 constant SEC_DFSDM1_CH1CFGR1_DATMPX                       \ DATMPX
$0000c000 constant SEC_DFSDM1_CH1CFGR1_DATPACK                      \ DATPACK
$00ff0000 constant SEC_DFSDM1_CH1CFGR1_CKOUTDIV                     \ Output serial clock divider
$40000000 constant SEC_DFSDM1_CH1CFGR1_CKOUTSRC                     \ Output serial clock source selection
$80000000 constant SEC_DFSDM1_CH1CFGR1_DFSDMEN                      \ Global enable for DFSDM interface


\
\ @brief CHCFG1R2
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$000000f8 constant SEC_DFSDM1_CH1CFGR2_DTRBS                        \ DTRBS
$ffffff00 constant SEC_DFSDM1_CH1CFGR2_OFFSET                       \ OFFSET


\
\ @brief AWSCD1R
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$000000ff constant SEC_DFSDM1_CH1AWSCDR_SCDT                        \ SCDT
$0000f000 constant SEC_DFSDM1_CH1AWSCDR_BKSCD                       \ BKSCD
$001f0000 constant SEC_DFSDM1_CH1AWSCDR_AWFOSR                      \ AWFOSR
$00c00000 constant SEC_DFSDM1_CH1AWSCDR_AWFORD                      \ AWFORD


\
\ @brief CHWDAT1R
\ Address offset: 0x2C
\ Reset value: 0x00000000
\

$0000ffff constant SEC_DFSDM1_CH1WDATR_WDATA                        \ WDATA


\
\ @brief CHDATIN1R
\ Address offset: 0x30
\ Reset value: 0x00000000
\

$0000ffff constant SEC_DFSDM1_CH1DATINR_INDAT0                      \ INDAT0
$ffff0000 constant SEC_DFSDM1_CH1DATINR_INDAT1                      \ INDAT1


\
\ @brief DFSDM channel y delay register
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$0000003f constant SEC_DFSDM1_CH1DLYR_PLSSKP                        \ PLSSKP


\
\ @brief CHCFG2R1
\ Address offset: 0x40
\ Reset value: 0x00000000
\

$00000003 constant SEC_DFSDM1_CH2CFGR1_SITP                         \ SITP
$0000000c constant SEC_DFSDM1_CH2CFGR1_SPICKSEL                     \ SPICKSEL
$00000020 constant SEC_DFSDM1_CH2CFGR1_SCDEN                        \ SCDEN
$00000040 constant SEC_DFSDM1_CH2CFGR1_CKABEN                       \ CKABEN
$00000080 constant SEC_DFSDM1_CH2CFGR1_CHEN                         \ CHEN
$00000100 constant SEC_DFSDM1_CH2CFGR1_CHINSEL                      \ CHINSEL
$00003000 constant SEC_DFSDM1_CH2CFGR1_DATMPX                       \ DATMPX
$0000c000 constant SEC_DFSDM1_CH2CFGR1_DATPACK                      \ DATPACK
$00ff0000 constant SEC_DFSDM1_CH2CFGR1_CKOUTDIV                     \ Output serial clock divider
$40000000 constant SEC_DFSDM1_CH2CFGR1_CKOUTSRC                     \ Output serial clock source selection
$80000000 constant SEC_DFSDM1_CH2CFGR1_DFSDMEN                      \ Global enable for DFSDM interface


\
\ @brief CHCFG2R2
\ Address offset: 0x44
\ Reset value: 0x00000000
\

$000000f8 constant SEC_DFSDM1_CH2CFGR2_DTRBS                        \ DTRBS
$ffffff00 constant SEC_DFSDM1_CH2CFGR2_OFFSET                       \ OFFSET


\
\ @brief AWSCD2R
\ Address offset: 0x48
\ Reset value: 0x00000000
\

$000000ff constant SEC_DFSDM1_CH2AWSCDR_SCDT                        \ SCDT
$0000f000 constant SEC_DFSDM1_CH2AWSCDR_BKSCD                       \ BKSCD
$001f0000 constant SEC_DFSDM1_CH2AWSCDR_AWFOSR                      \ AWFOSR
$00c00000 constant SEC_DFSDM1_CH2AWSCDR_AWFORD                      \ AWFORD


\
\ @brief CHWDAT2R
\ Address offset: 0x4C
\ Reset value: 0x00000000
\

$0000ffff constant SEC_DFSDM1_CH2WDATR_WDATA                        \ WDATA


\
\ @brief CHDATIN2R
\ Address offset: 0x50
\ Reset value: 0x00000000
\

$0000ffff constant SEC_DFSDM1_CH2DATINR_INDAT0                      \ INDAT0
$ffff0000 constant SEC_DFSDM1_CH2DATINR_INDAT1                      \ INDAT1


\
\ @brief DFSDM channel y delay register
\ Address offset: 0x54
\ Reset value: 0x00000000
\

$0000003f constant SEC_DFSDM1_CH2DLYR_PLSSKP                        \ PLSSKP


\
\ @brief CHCFG3R1
\ Address offset: 0x60
\ Reset value: 0x00000000
\

$00000003 constant SEC_DFSDM1_CH3CFGR1_SITP                         \ SITP
$0000000c constant SEC_DFSDM1_CH3CFGR1_SPICKSEL                     \ SPICKSEL
$00000020 constant SEC_DFSDM1_CH3CFGR1_SCDEN                        \ SCDEN
$00000040 constant SEC_DFSDM1_CH3CFGR1_CKABEN                       \ CKABEN
$00000080 constant SEC_DFSDM1_CH3CFGR1_CHEN                         \ CHEN
$00000100 constant SEC_DFSDM1_CH3CFGR1_CHINSEL                      \ CHINSEL
$00003000 constant SEC_DFSDM1_CH3CFGR1_DATMPX                       \ DATMPX
$0000c000 constant SEC_DFSDM1_CH3CFGR1_DATPACK                      \ DATPACK
$00ff0000 constant SEC_DFSDM1_CH3CFGR1_CKOUTDIV                     \ Output serial clock divider
$40000000 constant SEC_DFSDM1_CH3CFGR1_CKOUTSRC                     \ Output serial clock source selection
$80000000 constant SEC_DFSDM1_CH3CFGR1_DFSDMEN                      \ Global enable for DFSDM interface


\
\ @brief CHCFG3R2
\ Address offset: 0x64
\ Reset value: 0x00000000
\

$000000f8 constant SEC_DFSDM1_CH3CFGR2_DTRBS                        \ DTRBS
$ffffff00 constant SEC_DFSDM1_CH3CFGR2_OFFSET                       \ OFFSET


\
\ @brief AWSCD3R
\ Address offset: 0x68
\ Reset value: 0x00000000
\

$000000ff constant SEC_DFSDM1_CH3AWSCDR_SCDT                        \ SCDT
$0000f000 constant SEC_DFSDM1_CH3AWSCDR_BKSCD                       \ BKSCD
$001f0000 constant SEC_DFSDM1_CH3AWSCDR_AWFOSR                      \ AWFOSR
$00c00000 constant SEC_DFSDM1_CH3AWSCDR_AWFORD                      \ AWFORD


\
\ @brief CHWDAT3R
\ Address offset: 0x6C
\ Reset value: 0x00000000
\

$0000ffff constant SEC_DFSDM1_CH3WDATR_WDATA                        \ WDATA


\
\ @brief CHDATIN3R
\ Address offset: 0x70
\ Reset value: 0x00000000
\

$0000ffff constant SEC_DFSDM1_CH3DATINR_INDAT0                      \ INDAT0
$ffff0000 constant SEC_DFSDM1_CH3DATINR_INDAT1                      \ INDAT1


\
\ @brief DFSDM channel y delay register
\ Address offset: 0x74
\ Reset value: 0x00000000
\

$0000003f constant SEC_DFSDM1_CH3DLYR_PLSSKP                        \ PLSSKP


\
\ @brief CHCFG4R1
\ Address offset: 0x80
\ Reset value: 0x00000000
\

$00000003 constant SEC_DFSDM1_CH4CFGR1_SITP                         \ SITP
$0000000c constant SEC_DFSDM1_CH4CFGR1_SPICKSEL                     \ SPICKSEL
$00000020 constant SEC_DFSDM1_CH4CFGR1_SCDEN                        \ SCDEN
$00000040 constant SEC_DFSDM1_CH4CFGR1_CKABEN                       \ CKABEN
$00000080 constant SEC_DFSDM1_CH4CFGR1_CHEN                         \ CHEN
$00000100 constant SEC_DFSDM1_CH4CFGR1_CHINSEL                      \ CHINSEL
$00003000 constant SEC_DFSDM1_CH4CFGR1_DATMPX                       \ DATMPX
$0000c000 constant SEC_DFSDM1_CH4CFGR1_DATPACK                      \ DATPACK
$00ff0000 constant SEC_DFSDM1_CH4CFGR1_CKOUTDIV                     \ Output serial clock divider
$40000000 constant SEC_DFSDM1_CH4CFGR1_CKOUTSRC                     \ Output serial clock source selection
$80000000 constant SEC_DFSDM1_CH4CFGR1_DFSDMEN                      \ Global enable for DFSDM interface


\
\ @brief CHCFG4R2
\ Address offset: 0x84
\ Reset value: 0x00000000
\

$000000f8 constant SEC_DFSDM1_CH4CFGR2_DTRBS                        \ DTRBS
$ffffff00 constant SEC_DFSDM1_CH4CFGR2_OFFSET                       \ OFFSET


\
\ @brief AWSCD4R
\ Address offset: 0x88
\ Reset value: 0x00000000
\

$000000ff constant SEC_DFSDM1_CH4AWSCDR_SCDT                        \ SCDT
$0000f000 constant SEC_DFSDM1_CH4AWSCDR_BKSCD                       \ BKSCD
$001f0000 constant SEC_DFSDM1_CH4AWSCDR_AWFOSR                      \ AWFOSR
$00c00000 constant SEC_DFSDM1_CH4AWSCDR_AWFORD                      \ AWFORD


\
\ @brief CHWDAT4R
\ Address offset: 0x8C
\ Reset value: 0x00000000
\

$0000ffff constant SEC_DFSDM1_CH4WDATR_WDATA                        \ WDATA


\
\ @brief CHDATIN4R
\ Address offset: 0x90
\ Reset value: 0x00000000
\

$0000ffff constant SEC_DFSDM1_CH4DATINR_INDAT0                      \ INDAT0
$ffff0000 constant SEC_DFSDM1_CH4DATINR_INDAT1                      \ INDAT1


\
\ @brief DFSDM channel y delay register
\ Address offset: 0x94
\ Reset value: 0x00000000
\

$0000003f constant SEC_DFSDM1_CH4DLYR_PLSSKP                        \ PLSSKP


\
\ @brief CHCFG5R1
\ Address offset: 0xA0
\ Reset value: 0x00000000
\

$00000003 constant SEC_DFSDM1_CH5CFGR1_SITP                         \ SITP
$0000000c constant SEC_DFSDM1_CH5CFGR1_SPICKSEL                     \ SPICKSEL
$00000020 constant SEC_DFSDM1_CH5CFGR1_SCDEN                        \ SCDEN
$00000040 constant SEC_DFSDM1_CH5CFGR1_CKABEN                       \ CKABEN
$00000080 constant SEC_DFSDM1_CH5CFGR1_CHEN                         \ CHEN
$00000100 constant SEC_DFSDM1_CH5CFGR1_CHINSEL                      \ CHINSEL
$00003000 constant SEC_DFSDM1_CH5CFGR1_DATMPX                       \ DATMPX
$0000c000 constant SEC_DFSDM1_CH5CFGR1_DATPACK                      \ DATPACK
$00ff0000 constant SEC_DFSDM1_CH5CFGR1_CKOUTDIV                     \ Output serial clock divider
$40000000 constant SEC_DFSDM1_CH5CFGR1_CKOUTSRC                     \ Output serial clock source selection
$80000000 constant SEC_DFSDM1_CH5CFGR1_DFSDMEN                      \ Global enable for DFSDM interface


\
\ @brief CHCFG5R2
\ Address offset: 0xA4
\ Reset value: 0x00000000
\

$000000f8 constant SEC_DFSDM1_CH5CFGR2_DTRBS                        \ DTRBS
$ffffff00 constant SEC_DFSDM1_CH5CFGR2_OFFSET                       \ OFFSET


\
\ @brief AWSCD5R
\ Address offset: 0xA8
\ Reset value: 0x00000000
\

$000000ff constant SEC_DFSDM1_CH5AWSCDR_SCDT                        \ SCDT
$0000f000 constant SEC_DFSDM1_CH5AWSCDR_BKSCD                       \ BKSCD
$001f0000 constant SEC_DFSDM1_CH5AWSCDR_AWFOSR                      \ AWFOSR
$00c00000 constant SEC_DFSDM1_CH5AWSCDR_AWFORD                      \ AWFORD


\
\ @brief CHWDAT5R
\ Address offset: 0xAC
\ Reset value: 0x00000000
\

$0000ffff constant SEC_DFSDM1_CH5WDATR_WDATA                        \ WDATA


\
\ @brief CHDATIN5R
\ Address offset: 0xB0
\ Reset value: 0x00000000
\

$0000ffff constant SEC_DFSDM1_CH5DATINR_INDAT0                      \ INDAT0
$ffff0000 constant SEC_DFSDM1_CH5DATINR_INDAT1                      \ INDAT1


\
\ @brief DFSDM channel y delay register
\ Address offset: 0xB4
\ Reset value: 0x00000000
\

$0000003f constant SEC_DFSDM1_CH5DLYR_PLSSKP                        \ read-only


\
\ @brief CHCFG6R1
\ Address offset: 0xC0
\ Reset value: 0x00000000
\

$00000003 constant SEC_DFSDM1_CH6CFGR1_SITP                         \ SITP
$0000000c constant SEC_DFSDM1_CH6CFGR1_SPICKSEL                     \ SPICKSEL
$00000020 constant SEC_DFSDM1_CH6CFGR1_SCDEN                        \ SCDEN
$00000040 constant SEC_DFSDM1_CH6CFGR1_CKABEN                       \ CKABEN
$00000080 constant SEC_DFSDM1_CH6CFGR1_CHEN                         \ CHEN
$00000100 constant SEC_DFSDM1_CH6CFGR1_CHINSEL                      \ CHINSEL
$00003000 constant SEC_DFSDM1_CH6CFGR1_DATMPX                       \ DATMPX
$0000c000 constant SEC_DFSDM1_CH6CFGR1_DATPACK                      \ DATPACK
$00ff0000 constant SEC_DFSDM1_CH6CFGR1_CKOUTDIV                     \ Output serial clock divider
$40000000 constant SEC_DFSDM1_CH6CFGR1_CKOUTSRC                     \ Output serial clock source selection
$80000000 constant SEC_DFSDM1_CH6CFGR1_DFSDMEN                      \ Global enable for DFSDM interface


\
\ @brief CH6CFGR2
\ Address offset: 0xC4
\ Reset value: 0x00000000
\

$000000f8 constant SEC_DFSDM1_CH6CFGR2_DTRBS                        \ DTRBS
$ffffff00 constant SEC_DFSDM1_CH6CFGR2_OFFSET                       \ OFFSET


\
\ @brief AWSCD6R
\ Address offset: 0xC8
\ Reset value: 0x00000000
\

$000000ff constant SEC_DFSDM1_CH6AWSCDR_SCDT                        \ SCDT
$0000f000 constant SEC_DFSDM1_CH6AWSCDR_BKSCD                       \ BKSCD
$001f0000 constant SEC_DFSDM1_CH6AWSCDR_AWFOSR                      \ AWFOSR
$00c00000 constant SEC_DFSDM1_CH6AWSCDR_AWFORD                      \ AWFORD


\
\ @brief CHWDAT6R
\ Address offset: 0xCC
\ Reset value: 0x00000000
\

$0000ffff constant SEC_DFSDM1_CH6WDATR_WDATA                        \ WDATA


\
\ @brief CHDATIN6R
\ Address offset: 0xD0
\ Reset value: 0x00000000
\

$0000ffff constant SEC_DFSDM1_CH6DATINR_INDAT0                      \ INDAT0
$ffff0000 constant SEC_DFSDM1_CH6DATINR_INDAT1                      \ INDAT1


\
\ @brief DFSDM channel y delay register
\ Address offset: 0xD4
\ Reset value: 0x00000000
\

$0000003f constant SEC_DFSDM1_CH6DLYR_PLSSKP                        \ PLSSKP


\
\ @brief CHCFG7R1
\ Address offset: 0xE0
\ Reset value: 0x00000000
\

$00000003 constant SEC_DFSDM1_CH7CFGR1_SITP                         \ SITP
$0000000c constant SEC_DFSDM1_CH7CFGR1_SPICKSEL                     \ SPICKSEL
$00000020 constant SEC_DFSDM1_CH7CFGR1_SCDEN                        \ SCDEN
$00000040 constant SEC_DFSDM1_CH7CFGR1_CKABEN                       \ CKABEN
$00000080 constant SEC_DFSDM1_CH7CFGR1_CHEN                         \ CHEN
$00000100 constant SEC_DFSDM1_CH7CFGR1_CHINSEL                      \ CHINSEL
$00003000 constant SEC_DFSDM1_CH7CFGR1_DATMPX                       \ DATMPX
$0000c000 constant SEC_DFSDM1_CH7CFGR1_DATPACK                      \ DATPACK
$00ff0000 constant SEC_DFSDM1_CH7CFGR1_CKOUTDIV                     \ Output serial clock divider
$40000000 constant SEC_DFSDM1_CH7CFGR1_CKOUTSRC                     \ Output serial clock source selection
$80000000 constant SEC_DFSDM1_CH7CFGR1_DFSDMEN                      \ Global enable for DFSDM interface


\
\ @brief CHCFG7R2
\ Address offset: 0xE4
\ Reset value: 0x00000000
\

$000000f8 constant SEC_DFSDM1_CH7CFGR2_DTRBS                        \ DTRBS
$ffffff00 constant SEC_DFSDM1_CH7CFGR2_OFFSET                       \ OFFSET


\
\ @brief AWSCD7R
\ Address offset: 0xE8
\ Reset value: 0x00000000
\

$000000ff constant SEC_DFSDM1_CH7AWSCDR_SCDT                        \ SCDT
$0000f000 constant SEC_DFSDM1_CH7AWSCDR_BKSCD                       \ BKSCD
$001f0000 constant SEC_DFSDM1_CH7AWSCDR_AWFOSR                      \ AWFOSR
$00c00000 constant SEC_DFSDM1_CH7AWSCDR_AWFORD                      \ AWFORD


\
\ @brief CHWDAT7R
\ Address offset: 0xEC
\ Reset value: 0x00000000
\

$0000ffff constant SEC_DFSDM1_CH7WDATR_WDATA                        \ WDATA


\
\ @brief CHDATIN7R
\ Address offset: 0xF0
\ Reset value: 0x00000000
\

$0000ffff constant SEC_DFSDM1_CH7DATINR_INDAT0                      \ INDAT0
$ffff0000 constant SEC_DFSDM1_CH7DATINR_INDAT1                      \ INDAT1


\
\ @brief DFSDM channel y delay register
\ Address offset: 0xF4
\ Reset value: 0x00000000
\

$0000003f constant SEC_DFSDM1_CH7DLYR_PLSSKP                        \ PLSSKP


\
\ @brief control register 1
\ Address offset: 0x100
\ Reset value: 0x00000000
\

$00000001 constant SEC_DFSDM1_FLT0CR1_DFEN                          \ DFSDM enable
$00000002 constant SEC_DFSDM1_FLT0CR1_JSWSTART                      \ Start a conversion of the injected group of channels
$00000008 constant SEC_DFSDM1_FLT0CR1_JSYNC                         \ Launch an injected conversion synchronously with the DFSDM0 JSWSTART trigger
$00000010 constant SEC_DFSDM1_FLT0CR1_JSCAN                         \ Scanning conversion mode for injected conversions
$00000020 constant SEC_DFSDM1_FLT0CR1_JDMAEN                        \ DMA channel enabled to read data for the injected channel group
$00000700 constant SEC_DFSDM1_FLT0CR1_JEXTSEL                       \ Trigger signal selection for launching injected conversions
$00006000 constant SEC_DFSDM1_FLT0CR1_JEXTEN                        \ Trigger enable and trigger edge selection for injected conversions
$00020000 constant SEC_DFSDM1_FLT0CR1_RSWSTART                      \ Software start of a conversion on the regular channel
$00040000 constant SEC_DFSDM1_FLT0CR1_RCONT                         \ Continuous mode selection for regular conversions
$00080000 constant SEC_DFSDM1_FLT0CR1_RSYNC                         \ Launch regular conversion synchronously with DFSDM0
$00200000 constant SEC_DFSDM1_FLT0CR1_RDMAEN                        \ DMA channel enabled to read data for the regular conversion
$07000000 constant SEC_DFSDM1_FLT0CR1_RCH                           \ Regular channel selection
$20000000 constant SEC_DFSDM1_FLT0CR1_FAST                          \ Fast conversion mode selection for regular conversions
$40000000 constant SEC_DFSDM1_FLT0CR1_AWFSEL                        \ Analog watchdog fast mode select


\
\ @brief control register 2
\ Address offset: 0x104
\ Reset value: 0x00000000
\

$00000001 constant SEC_DFSDM1_FLT0CR2_JEOCIE                        \ Injected end of conversion interrupt enable
$00000002 constant SEC_DFSDM1_FLT0CR2_REOCIE                        \ Regular end of conversion interrupt enable
$00000004 constant SEC_DFSDM1_FLT0CR2_JOVRIE                        \ Injected data overrun interrupt enable
$00000008 constant SEC_DFSDM1_FLT0CR2_ROVRIE                        \ Regular data overrun interrupt enable
$00000010 constant SEC_DFSDM1_FLT0CR2_AWDIE                         \ Analog watchdog interrupt enable
$00000020 constant SEC_DFSDM1_FLT0CR2_SCDIE                         \ Short-circuit detector interrupt enable
$00000040 constant SEC_DFSDM1_FLT0CR2_CKABIE                        \ Clock absence interrupt enable
$0000ff00 constant SEC_DFSDM1_FLT0CR2_EXCH                          \ Extremes detector channel selection
$00ff0000 constant SEC_DFSDM1_FLT0CR2_AWDCH                         \ Analog watchdog channel selection


\
\ @brief interrupt and status register
\ Address offset: 0x108
\ Reset value: 0x00FF0000
\

$00000001 constant SEC_DFSDM1_FLT0ISR_JEOCF                         \ End of injected conversion flag
$00000002 constant SEC_DFSDM1_FLT0ISR_REOCF                         \ End of regular conversion flag
$00000004 constant SEC_DFSDM1_FLT0ISR_JOVRF                         \ Injected conversion overrun flag
$00000008 constant SEC_DFSDM1_FLT0ISR_ROVRF                         \ Regular conversion overrun flag
$00000010 constant SEC_DFSDM1_FLT0ISR_AWDF                          \ Analog watchdog
$00002000 constant SEC_DFSDM1_FLT0ISR_JCIP                          \ Injected conversion in progress status
$00004000 constant SEC_DFSDM1_FLT0ISR_RCIP                          \ Regular conversion in progress status
$00ff0000 constant SEC_DFSDM1_FLT0ISR_CKABF                         \ Clock absence flag
$ff000000 constant SEC_DFSDM1_FLT0ISR_SCDF                          \ short-circuit detector flag


\
\ @brief interrupt flag clear register
\ Address offset: 0x10C
\ Reset value: 0x00000000
\

$00000004 constant SEC_DFSDM1_FLT0ICR_CLRJOVRF                      \ Clear the injected conversion overrun flag
$00000008 constant SEC_DFSDM1_FLT0ICR_CLRROVRF                      \ Clear the regular conversion overrun flag
$00ff0000 constant SEC_DFSDM1_FLT0ICR_CLRCKABF                      \ Clear the clock absence flag
$ff000000 constant SEC_DFSDM1_FLT0ICR_CLRSCDF                       \ Clear the short-circuit detector flag


\
\ @brief injected channel group selection register
\ Address offset: 0x110
\ Reset value: 0x00000001
\

$000000ff constant SEC_DFSDM1_FLT0JCHGR_JCHG                        \ Injected channel group selection


\
\ @brief filter control register
\ Address offset: 0x114
\ Reset value: 0x00000000
\

$000000ff constant SEC_DFSDM1_FLT0FCR_IOSR                          \ Integrator oversampling ratio (averaging length)
$03ff0000 constant SEC_DFSDM1_FLT0FCR_FOSR                          \ Sinc filter oversampling ratio (decimation rate)
$e0000000 constant SEC_DFSDM1_FLT0FCR_FORD                          \ Sinc filter order


\
\ @brief data register for injected group
\ Address offset: 0x118
\ Reset value: 0x00000000
\

$00000007 constant SEC_DFSDM1_FLT0JDATAR_JDATACH                    \ Injected channel most recently converted
$ffffff00 constant SEC_DFSDM1_FLT0JDATAR_JDATA                      \ Injected group conversion data


\
\ @brief data register for the regular channel
\ Address offset: 0x11C
\ Reset value: 0x00000000
\

$00000007 constant SEC_DFSDM1_FLT0RDATAR_RDATACH                    \ Regular channel most recently converted
$00000010 constant SEC_DFSDM1_FLT0RDATAR_RPEND                      \ Regular channel pending data
$ffffff00 constant SEC_DFSDM1_FLT0RDATAR_RDATA                      \ Regular channel conversion data


\
\ @brief analog watchdog high threshold register
\ Address offset: 0x120
\ Reset value: 0x00000000
\

$0000000f constant SEC_DFSDM1_FLT0AWHTR_BKAWH                       \ Break signal assignment to analog watchdog high threshold event
$ffffff00 constant SEC_DFSDM1_FLT0AWHTR_AWHT                        \ Analog watchdog high threshold


\
\ @brief analog watchdog low threshold register
\ Address offset: 0x124
\ Reset value: 0x00000000
\

$0000000f constant SEC_DFSDM1_FLT0AWLTR_BKAWL                       \ Break signal assignment to analog watchdog low threshold event
$ffffff00 constant SEC_DFSDM1_FLT0AWLTR_AWLT                        \ Analog watchdog low threshold


\
\ @brief analog watchdog status register
\ Address offset: 0x128
\ Reset value: 0x00000000
\

$000000ff constant SEC_DFSDM1_FLT0AWSR_AWLTF                        \ Analog watchdog low threshold flag
$0000ff00 constant SEC_DFSDM1_FLT0AWSR_AWHTF                        \ Analog watchdog high threshold flag


\
\ @brief analog watchdog clear flag register
\ Address offset: 0x12C
\ Reset value: 0x00000000
\

$000000ff constant SEC_DFSDM1_FLT0AWCFR_CLRAWLTF                    \ Clear the analog watchdog low threshold flag
$0000ff00 constant SEC_DFSDM1_FLT0AWCFR_CLRAWHTF                    \ Clear the analog watchdog high threshold flag


\
\ @brief Extremes detector maximum register
\ Address offset: 0x130
\ Reset value: 0x80000000
\

$00000007 constant SEC_DFSDM1_FLT0EXMAX_EXMAXCH                     \ Extremes detector maximum data channel
$ffffff00 constant SEC_DFSDM1_FLT0EXMAX_EXMAX                       \ Extremes detector maximum value


\
\ @brief Extremes detector minimum register
\ Address offset: 0x134
\ Reset value: 0x7FFFFF00
\

$00000007 constant SEC_DFSDM1_FLT0EXMIN_EXMINCH                     \ Extremes detector minimum data channel
$ffffff00 constant SEC_DFSDM1_FLT0EXMIN_EXMIN                       \ EXMIN


\
\ @brief conversion timer register
\ Address offset: 0x138
\ Reset value: 0x00000000
\

$fffffff0 constant SEC_DFSDM1_FLT0CNVTIMR_CNVCNT                    \ 28-bit timer counting conversion time t = CNVCNT[27:0] / fDFSDM_CKIN


\
\ @brief control register 1
\ Address offset: 0x180
\ Reset value: 0x00000000
\

$00000001 constant SEC_DFSDM1_FLT1CR1_DFEN                          \ DFSDM enable
$00000002 constant SEC_DFSDM1_FLT1CR1_JSWSTART                      \ Start a conversion of the injected group of channels
$00000008 constant SEC_DFSDM1_FLT1CR1_JSYNC                         \ Launch an injected conversion synchronously with the DFSDM0 JSWSTART trigger
$00000010 constant SEC_DFSDM1_FLT1CR1_JSCAN                         \ Scanning conversion mode for injected conversions
$00000020 constant SEC_DFSDM1_FLT1CR1_JDMAEN                        \ DMA channel enabled to read data for the injected channel group
$00000700 constant SEC_DFSDM1_FLT1CR1_JEXTSEL                       \ Trigger signal selection for launching injected conversions
$00006000 constant SEC_DFSDM1_FLT1CR1_JEXTEN                        \ Trigger enable and trigger edge selection for injected conversions
$00020000 constant SEC_DFSDM1_FLT1CR1_RSWSTART                      \ Software start of a conversion on the regular channel
$00040000 constant SEC_DFSDM1_FLT1CR1_RCONT                         \ Continuous mode selection for regular conversions
$00080000 constant SEC_DFSDM1_FLT1CR1_RSYNC                         \ Launch regular conversion synchronously with DFSDM0
$00200000 constant SEC_DFSDM1_FLT1CR1_RDMAEN                        \ DMA channel enabled to read data for the regular conversion
$07000000 constant SEC_DFSDM1_FLT1CR1_RCH                           \ Regular channel selection
$20000000 constant SEC_DFSDM1_FLT1CR1_FAST                          \ Fast conversion mode selection for regular conversions
$40000000 constant SEC_DFSDM1_FLT1CR1_AWFSEL                        \ Analog watchdog fast mode select


\
\ @brief control register 2
\ Address offset: 0x184
\ Reset value: 0x00000000
\

$00000001 constant SEC_DFSDM1_FLT1CR2_JEOCIE                        \ Injected end of conversion interrupt enable
$00000002 constant SEC_DFSDM1_FLT1CR2_REOCIE                        \ Regular end of conversion interrupt enable
$00000004 constant SEC_DFSDM1_FLT1CR2_JOVRIE                        \ Injected data overrun interrupt enable
$00000008 constant SEC_DFSDM1_FLT1CR2_ROVRIE                        \ Regular data overrun interrupt enable
$00000010 constant SEC_DFSDM1_FLT1CR2_AWDIE                         \ Analog watchdog interrupt enable
$00000020 constant SEC_DFSDM1_FLT1CR2_SCDIE                         \ Short-circuit detector interrupt enable
$00000040 constant SEC_DFSDM1_FLT1CR2_CKABIE                        \ Clock absence interrupt enable
$0000ff00 constant SEC_DFSDM1_FLT1CR2_EXCH                          \ Extremes detector channel selection
$00ff0000 constant SEC_DFSDM1_FLT1CR2_AWDCH                         \ Analog watchdog channel selection


\
\ @brief interrupt and status register
\ Address offset: 0x188
\ Reset value: 0x00FF0000
\

$00000001 constant SEC_DFSDM1_FLT1ISR_JEOCF                         \ End of injected conversion flag
$00000002 constant SEC_DFSDM1_FLT1ISR_REOCF                         \ End of regular conversion flag
$00000004 constant SEC_DFSDM1_FLT1ISR_JOVRF                         \ Injected conversion overrun flag
$00000008 constant SEC_DFSDM1_FLT1ISR_ROVRF                         \ Regular conversion overrun flag
$00000010 constant SEC_DFSDM1_FLT1ISR_AWDF                          \ Analog watchdog
$00002000 constant SEC_DFSDM1_FLT1ISR_JCIP                          \ Injected conversion in progress status
$00004000 constant SEC_DFSDM1_FLT1ISR_RCIP                          \ Regular conversion in progress status
$00ff0000 constant SEC_DFSDM1_FLT1ISR_CKABF                         \ Clock absence flag
$ff000000 constant SEC_DFSDM1_FLT1ISR_SCDF                          \ short-circuit detector flag


\
\ @brief interrupt flag clear register
\ Address offset: 0x18C
\ Reset value: 0x00000000
\

$00000004 constant SEC_DFSDM1_FLT1ICR_CLRJOVRF                      \ Clear the injected conversion overrun flag
$00000008 constant SEC_DFSDM1_FLT1ICR_CLRROVRF                      \ Clear the regular conversion overrun flag
$00ff0000 constant SEC_DFSDM1_FLT1ICR_CLRCKABF                      \ Clear the clock absence flag
$ff000000 constant SEC_DFSDM1_FLT1ICR_CLRSCDF                       \ Clear the short-circuit detector flag


\
\ @brief injected channel group selection register
\ Address offset: 0x190
\ Reset value: 0x00000001
\

$000000ff constant SEC_DFSDM1_FLT1JCHGR_JCHG                        \ Injected channel group selection


\
\ @brief filter control register
\ Address offset: 0x194
\ Reset value: 0x00000000
\

$000000ff constant SEC_DFSDM1_FLT1FCR_IOSR                          \ Integrator oversampling ratio (averaging length)
$03ff0000 constant SEC_DFSDM1_FLT1FCR_FOSR                          \ Sinc filter oversampling ratio (decimation rate)
$e0000000 constant SEC_DFSDM1_FLT1FCR_FORD                          \ Sinc filter order


\
\ @brief data register for injected group
\ Address offset: 0x198
\ Reset value: 0x00000000
\

$00000007 constant SEC_DFSDM1_FLT1JDATAR_JDATACH                    \ Injected channel most recently converted
$ffffff00 constant SEC_DFSDM1_FLT1JDATAR_JDATA                      \ Injected group conversion data


\
\ @brief data register for the regular channel
\ Address offset: 0x19C
\ Reset value: 0x00000000
\

$00000007 constant SEC_DFSDM1_FLT1RDATAR_RDATACH                    \ Regular channel most recently converted
$00000010 constant SEC_DFSDM1_FLT1RDATAR_RPEND                      \ Regular channel pending data
$ffffff00 constant SEC_DFSDM1_FLT1RDATAR_RDATA                      \ Regular channel conversion data


\
\ @brief analog watchdog low threshold register
\ Address offset: 0x1A4
\ Reset value: 0x00000000
\

$0000000f constant SEC_DFSDM1_FLT1AWLTR_BKAWL                       \ Break signal assignment to analog watchdog low threshold event
$ffffff00 constant SEC_DFSDM1_FLT1AWLTR_AWLT                        \ Analog watchdog low threshold


\
\ @brief analog watchdog status register
\ Address offset: 0x1A8
\ Reset value: 0x00000000
\

$000000ff constant SEC_DFSDM1_FLT1AWSR_AWLTF                        \ Analog watchdog low threshold flag
$0000ff00 constant SEC_DFSDM1_FLT1AWSR_AWHTF                        \ Analog watchdog high threshold flag


\
\ @brief analog watchdog high threshold register
\ Address offset: 0x1AC
\ Reset value: 0x00000000
\

$0000000f constant SEC_DFSDM1_FLT1AWHTR_BKAWH                       \ Break signal assignment to analog watchdog high threshold event
$ffffff00 constant SEC_DFSDM1_FLT1AWHTR_AWHT                        \ Analog watchdog high threshold


\
\ @brief analog watchdog clear flag register
\ Address offset: 0x1AC
\ Reset value: 0x00000000
\

$000000ff constant SEC_DFSDM1_FLT1AWCFR_CLRAWLTF                    \ Clear the analog watchdog low threshold flag
$0000ff00 constant SEC_DFSDM1_FLT1AWCFR_CLRAWHTF                    \ Clear the analog watchdog high threshold flag


\
\ @brief Extremes detector maximum register
\ Address offset: 0x1B0
\ Reset value: 0x80000000
\

$00000007 constant SEC_DFSDM1_FLT1EXMAX_EXMAXCH                     \ Extremes detector maximum data channel
$ffffff00 constant SEC_DFSDM1_FLT1EXMAX_EXMAX                       \ Extremes detector maximum value


\
\ @brief Extremes detector minimum register
\ Address offset: 0x1B4
\ Reset value: 0x7FFFFF00
\

$00000007 constant SEC_DFSDM1_FLT1EXMIN_EXMINCH                     \ Extremes detector minimum data channel
$ffffff00 constant SEC_DFSDM1_FLT1EXMIN_EXMIN                       \ EXMIN


\
\ @brief conversion timer register
\ Address offset: 0x1B8
\ Reset value: 0x00000000
\

$fffffff0 constant SEC_DFSDM1_FLT1CNVTIMR_CNVCNT                    \ 28-bit timer counting conversion time t = CNVCNT[27:0] / fDFSDM_CKIN


\
\ @brief control register 1
\ Address offset: 0x200
\ Reset value: 0x00000000
\

$00000001 constant SEC_DFSDM1_FLT2CR1_DFEN                          \ DFSDM enable
$00000002 constant SEC_DFSDM1_FLT2CR1_JSWSTART                      \ Start a conversion of the injected group of channels
$00000008 constant SEC_DFSDM1_FLT2CR1_JSYNC                         \ Launch an injected conversion synchronously with the DFSDM0 JSWSTART trigger
$00000010 constant SEC_DFSDM1_FLT2CR1_JSCAN                         \ Scanning conversion mode for injected conversions
$00000020 constant SEC_DFSDM1_FLT2CR1_JDMAEN                        \ DMA channel enabled to read data for the injected channel group
$00000700 constant SEC_DFSDM1_FLT2CR1_JEXTSEL                       \ Trigger signal selection for launching injected conversions
$00006000 constant SEC_DFSDM1_FLT2CR1_JEXTEN                        \ Trigger enable and trigger edge selection for injected conversions
$00020000 constant SEC_DFSDM1_FLT2CR1_RSWSTART                      \ Software start of a conversion on the regular channel
$00040000 constant SEC_DFSDM1_FLT2CR1_RCONT                         \ Continuous mode selection for regular conversions
$00080000 constant SEC_DFSDM1_FLT2CR1_RSYNC                         \ Launch regular conversion synchronously with DFSDM0
$00200000 constant SEC_DFSDM1_FLT2CR1_RDMAEN                        \ DMA channel enabled to read data for the regular conversion
$07000000 constant SEC_DFSDM1_FLT2CR1_RCH                           \ Regular channel selection
$20000000 constant SEC_DFSDM1_FLT2CR1_FAST                          \ Fast conversion mode selection for regular conversions
$40000000 constant SEC_DFSDM1_FLT2CR1_AWFSEL                        \ Analog watchdog fast mode select


\
\ @brief control register 2
\ Address offset: 0x204
\ Reset value: 0x00000000
\

$00000001 constant SEC_DFSDM1_FLT2CR2_JEOCIE                        \ Injected end of conversion interrupt enable
$00000002 constant SEC_DFSDM1_FLT2CR2_REOCIE                        \ Regular end of conversion interrupt enable
$00000004 constant SEC_DFSDM1_FLT2CR2_JOVRIE                        \ Injected data overrun interrupt enable
$00000008 constant SEC_DFSDM1_FLT2CR2_ROVRIE                        \ Regular data overrun interrupt enable
$00000010 constant SEC_DFSDM1_FLT2CR2_AWDIE                         \ Analog watchdog interrupt enable
$00000020 constant SEC_DFSDM1_FLT2CR2_SCDIE                         \ Short-circuit detector interrupt enable
$00000040 constant SEC_DFSDM1_FLT2CR2_CKABIE                        \ Clock absence interrupt enable
$0000ff00 constant SEC_DFSDM1_FLT2CR2_EXCH                          \ Extremes detector channel selection
$00ff0000 constant SEC_DFSDM1_FLT2CR2_AWDCH                         \ Analog watchdog channel selection


\
\ @brief interrupt and status register
\ Address offset: 0x208
\ Reset value: 0x00FF0000
\

$00000001 constant SEC_DFSDM1_FLT2ISR_JEOCF                         \ End of injected conversion flag
$00000002 constant SEC_DFSDM1_FLT2ISR_REOCF                         \ End of regular conversion flag
$00000004 constant SEC_DFSDM1_FLT2ISR_JOVRF                         \ Injected conversion overrun flag
$00000008 constant SEC_DFSDM1_FLT2ISR_ROVRF                         \ Regular conversion overrun flag
$00000010 constant SEC_DFSDM1_FLT2ISR_AWDF                          \ Analog watchdog
$00002000 constant SEC_DFSDM1_FLT2ISR_JCIP                          \ Injected conversion in progress status
$00004000 constant SEC_DFSDM1_FLT2ISR_RCIP                          \ Regular conversion in progress status
$00ff0000 constant SEC_DFSDM1_FLT2ISR_CKABF                         \ Clock absence flag
$ff000000 constant SEC_DFSDM1_FLT2ISR_SCDF                          \ short-circuit detector flag


\
\ @brief interrupt flag clear register
\ Address offset: 0x20C
\ Reset value: 0x00000000
\

$00000004 constant SEC_DFSDM1_FLT2ICR_CLRJOVRF                      \ Clear the injected conversion overrun flag
$00000008 constant SEC_DFSDM1_FLT2ICR_CLRROVRF                      \ Clear the regular conversion overrun flag
$00ff0000 constant SEC_DFSDM1_FLT2ICR_CLRCKABF                      \ Clear the clock absence flag
$ff000000 constant SEC_DFSDM1_FLT2ICR_CLRSCDF                       \ Clear the short-circuit detector flag


\
\ @brief injected channel group selection register
\ Address offset: 0x210
\ Reset value: 0x00000001
\

$000000ff constant SEC_DFSDM1_FLT2JCHGR_JCHG                        \ Injected channel group selection


\
\ @brief filter control register
\ Address offset: 0x214
\ Reset value: 0x00000000
\

$000000ff constant SEC_DFSDM1_FLT2FCR_IOSR                          \ Integrator oversampling ratio (averaging length)
$03ff0000 constant SEC_DFSDM1_FLT2FCR_FOSR                          \ Sinc filter oversampling ratio (decimation rate)
$e0000000 constant SEC_DFSDM1_FLT2FCR_FORD                          \ Sinc filter order


\
\ @brief data register for injected group
\ Address offset: 0x218
\ Reset value: 0x00000000
\

$00000007 constant SEC_DFSDM1_FLT2JDATAR_JDATACH                    \ Injected channel most recently converted
$ffffff00 constant SEC_DFSDM1_FLT2JDATAR_JDATA                      \ Injected group conversion data


\
\ @brief data register for the regular channel
\ Address offset: 0x21C
\ Reset value: 0x00000000
\

$00000007 constant SEC_DFSDM1_FLT2RDATAR_RDATACH                    \ Regular channel most recently converted
$00000010 constant SEC_DFSDM1_FLT2RDATAR_RPEND                      \ Regular channel pending data
$ffffff00 constant SEC_DFSDM1_FLT2RDATAR_RDATA                      \ Regular channel conversion data


\
\ @brief analog watchdog high threshold register
\ Address offset: 0x220
\ Reset value: 0x00000000
\

$0000000f constant SEC_DFSDM1_FLT2AWHTR_BKAWH                       \ Break signal assignment to analog watchdog high threshold event
$ffffff00 constant SEC_DFSDM1_FLT2AWHTR_AWHT                        \ Analog watchdog high threshold


\
\ @brief analog watchdog low threshold register
\ Address offset: 0x224
\ Reset value: 0x00000000
\

$0000000f constant SEC_DFSDM1_FLT2AWLTR_BKAWL                       \ Break signal assignment to analog watchdog low threshold event
$ffffff00 constant SEC_DFSDM1_FLT2AWLTR_AWLT                        \ Analog watchdog low threshold


\
\ @brief analog watchdog status register
\ Address offset: 0x228
\ Reset value: 0x00000000
\

$000000ff constant SEC_DFSDM1_FLT2AWSR_AWLTF                        \ Analog watchdog low threshold flag
$0000ff00 constant SEC_DFSDM1_FLT2AWSR_AWHTF                        \ Analog watchdog high threshold flag


\
\ @brief analog watchdog clear flag register
\ Address offset: 0x22C
\ Reset value: 0x00000000
\

$000000ff constant SEC_DFSDM1_FLT2AWCFR_CLRAWLTF                    \ Clear the analog watchdog low threshold flag
$0000ff00 constant SEC_DFSDM1_FLT2AWCFR_CLRAWHTF                    \ Clear the analog watchdog high threshold flag


\
\ @brief Extremes detector maximum register
\ Address offset: 0x230
\ Reset value: 0x80000000
\

$00000007 constant SEC_DFSDM1_FLT2EXMAX_EXMAXCH                     \ Extremes detector maximum data channel
$ffffff00 constant SEC_DFSDM1_FLT2EXMAX_EXMAX                       \ Extremes detector maximum value


\
\ @brief Extremes detector minimum register
\ Address offset: 0x234
\ Reset value: 0x7FFFFF00
\

$00000007 constant SEC_DFSDM1_FLT2EXMIN_EXMINCH                     \ Extremes detector minimum data channel
$ffffff00 constant SEC_DFSDM1_FLT2EXMIN_EXMIN                       \ EXMIN


\
\ @brief conversion timer register
\ Address offset: 0x238
\ Reset value: 0x00000000
\

$fffffff0 constant SEC_DFSDM1_FLT2CNVTIMR_CNVCNT                    \ 28-bit timer counting conversion time t = CNVCNT[27:0] / fDFSDM_CKIN


\
\ @brief control register 1
\ Address offset: 0x280
\ Reset value: 0x00000000
\

$00000001 constant SEC_DFSDM1_FLT3CR1_DFEN                          \ DFSDM enable
$00000002 constant SEC_DFSDM1_FLT3CR1_JSWSTART                      \ Start a conversion of the injected group of channels
$00000008 constant SEC_DFSDM1_FLT3CR1_JSYNC                         \ Launch an injected conversion synchronously with the DFSDM0 JSWSTART trigger
$00000010 constant SEC_DFSDM1_FLT3CR1_JSCAN                         \ Scanning conversion mode for injected conversions
$00000020 constant SEC_DFSDM1_FLT3CR1_JDMAEN                        \ DMA channel enabled to read data for the injected channel group
$00000700 constant SEC_DFSDM1_FLT3CR1_JEXTSEL                       \ Trigger signal selection for launching injected conversions
$00006000 constant SEC_DFSDM1_FLT3CR1_JEXTEN                        \ Trigger enable and trigger edge selection for injected conversions
$00020000 constant SEC_DFSDM1_FLT3CR1_RSWSTART                      \ Software start of a conversion on the regular channel
$00040000 constant SEC_DFSDM1_FLT3CR1_RCONT                         \ Continuous mode selection for regular conversions
$00080000 constant SEC_DFSDM1_FLT3CR1_RSYNC                         \ Launch regular conversion synchronously with DFSDM0
$00200000 constant SEC_DFSDM1_FLT3CR1_RDMAEN                        \ DMA channel enabled to read data for the regular conversion
$07000000 constant SEC_DFSDM1_FLT3CR1_RCH                           \ Regular channel selection
$20000000 constant SEC_DFSDM1_FLT3CR1_FAST                          \ Fast conversion mode selection for regular conversions
$40000000 constant SEC_DFSDM1_FLT3CR1_AWFSEL                        \ Analog watchdog fast mode select


\
\ @brief control register 2
\ Address offset: 0x284
\ Reset value: 0x00000000
\

$00000001 constant SEC_DFSDM1_FLT3CR2_JEOCIE                        \ Injected end of conversion interrupt enable
$00000002 constant SEC_DFSDM1_FLT3CR2_REOCIE                        \ Regular end of conversion interrupt enable
$00000004 constant SEC_DFSDM1_FLT3CR2_JOVRIE                        \ Injected data overrun interrupt enable
$00000008 constant SEC_DFSDM1_FLT3CR2_ROVRIE                        \ Regular data overrun interrupt enable
$00000010 constant SEC_DFSDM1_FLT3CR2_AWDIE                         \ Analog watchdog interrupt enable
$00000020 constant SEC_DFSDM1_FLT3CR2_SCDIE                         \ Short-circuit detector interrupt enable
$00000040 constant SEC_DFSDM1_FLT3CR2_CKABIE                        \ Clock absence interrupt enable
$0000ff00 constant SEC_DFSDM1_FLT3CR2_EXCH                          \ Extremes detector channel selection
$00ff0000 constant SEC_DFSDM1_FLT3CR2_AWDCH                         \ Analog watchdog channel selection


\
\ @brief interrupt and status register
\ Address offset: 0x288
\ Reset value: 0x00FF0000
\

$00000001 constant SEC_DFSDM1_FLT3ISR_JEOCF                         \ End of injected conversion flag
$00000002 constant SEC_DFSDM1_FLT3ISR_REOCF                         \ End of regular conversion flag
$00000004 constant SEC_DFSDM1_FLT3ISR_JOVRF                         \ Injected conversion overrun flag
$00000008 constant SEC_DFSDM1_FLT3ISR_ROVRF                         \ Regular conversion overrun flag
$00000010 constant SEC_DFSDM1_FLT3ISR_AWDF                          \ Analog watchdog
$00002000 constant SEC_DFSDM1_FLT3ISR_JCIP                          \ Injected conversion in progress status
$00004000 constant SEC_DFSDM1_FLT3ISR_RCIP                          \ Regular conversion in progress status
$00ff0000 constant SEC_DFSDM1_FLT3ISR_CKABF                         \ Clock absence flag
$ff000000 constant SEC_DFSDM1_FLT3ISR_SCDF                          \ short-circuit detector flag


\
\ @brief interrupt flag clear register
\ Address offset: 0x28C
\ Reset value: 0x00000000
\

$00000004 constant SEC_DFSDM1_FLT3ICR_CLRJOVRF                      \ Clear the injected conversion overrun flag
$00000008 constant SEC_DFSDM1_FLT3ICR_CLRROVRF                      \ Clear the regular conversion overrun flag
$00ff0000 constant SEC_DFSDM1_FLT3ICR_CLRCKABF                      \ Clear the clock absence flag
$ff000000 constant SEC_DFSDM1_FLT3ICR_CLRSCDF                       \ Clear the short-circuit detector flag


\
\ @brief injected channel group selection register
\ Address offset: 0x290
\ Reset value: 0x00000001
\

$000000ff constant SEC_DFSDM1_FLT3JCHGR_JCHG                        \ Injected channel group selection


\
\ @brief filter control register
\ Address offset: 0x294
\ Reset value: 0x00000000
\

$000000ff constant SEC_DFSDM1_FLT3FCR_IOSR                          \ Integrator oversampling ratio (averaging length)
$03ff0000 constant SEC_DFSDM1_FLT3FCR_FOSR                          \ Sinc filter oversampling ratio (decimation rate)
$e0000000 constant SEC_DFSDM1_FLT3FCR_FORD                          \ Sinc filter order


\
\ @brief data register for injected group
\ Address offset: 0x298
\ Reset value: 0x00000000
\

$00000007 constant SEC_DFSDM1_FLT3JDATAR_JDATACH                    \ Injected channel most recently converted
$ffffff00 constant SEC_DFSDM1_FLT3JDATAR_JDATA                      \ Injected group conversion data


\
\ @brief data register for the regular channel
\ Address offset: 0x29C
\ Reset value: 0x00000000
\

$00000007 constant SEC_DFSDM1_FLT3RDATAR_RDATACH                    \ Regular channel most recently converted
$00000010 constant SEC_DFSDM1_FLT3RDATAR_RPEND                      \ Regular channel pending data
$ffffff00 constant SEC_DFSDM1_FLT3RDATAR_RDATA                      \ Regular channel conversion data


\
\ @brief analog watchdog high threshold register
\ Address offset: 0x2A0
\ Reset value: 0x00000000
\

$0000000f constant SEC_DFSDM1_FLT3AWHTR_BKAWH                       \ Break signal assignment to analog watchdog high threshold event
$ffffff00 constant SEC_DFSDM1_FLT3AWHTR_AWHT                        \ Analog watchdog high threshold


\
\ @brief analog watchdog low threshold register
\ Address offset: 0x2A4
\ Reset value: 0x00000000
\

$0000000f constant SEC_DFSDM1_FLT3AWLTR_BKAWL                       \ Break signal assignment to analog watchdog low threshold event
$ffffff00 constant SEC_DFSDM1_FLT3AWLTR_AWLT                        \ Analog watchdog low threshold


\
\ @brief analog watchdog status register
\ Address offset: 0x2A8
\ Reset value: 0x00000000
\

$000000ff constant SEC_DFSDM1_FLT3AWSR_AWLTF                        \ Analog watchdog low threshold flag
$0000ff00 constant SEC_DFSDM1_FLT3AWSR_AWHTF                        \ Analog watchdog high threshold flag


\
\ @brief analog watchdog clear flag register
\ Address offset: 0x2AC
\ Reset value: 0x00000000
\

$000000ff constant SEC_DFSDM1_FLT3AWCFR_CLRAWLTF                    \ Clear the analog watchdog low threshold flag
$0000ff00 constant SEC_DFSDM1_FLT3AWCFR_CLRAWHTF                    \ Clear the analog watchdog high threshold flag


\
\ @brief Extremes detector maximum register
\ Address offset: 0x2B0
\ Reset value: 0x80000000
\

$00000007 constant SEC_DFSDM1_FLT3EXMAX_EXMAXCH                     \ Extremes detector maximum data channel
$ffffff00 constant SEC_DFSDM1_FLT3EXMAX_EXMAX                       \ Extremes detector maximum value


\
\ @brief Extremes detector minimum register
\ Address offset: 0x2B4
\ Reset value: 0x7FFFFF00
\

$00000007 constant SEC_DFSDM1_FLT3EXMIN_EXMINCH                     \ Extremes detector minimum data channel
$ffffff00 constant SEC_DFSDM1_FLT3EXMIN_EXMIN                       \ EXMIN


\
\ @brief conversion timer register
\ Address offset: 0x2B8
\ Reset value: 0x00000000
\

$fffffff0 constant SEC_DFSDM1_FLT3CNVTIMR_CNVCNT                    \ 28-bit timer counting conversion time t = CNVCNT[27:0] / fDFSDM_CKIN


\
\ @brief Digital filter for sigma delta modulators
\
$50016000 constant SEC_DFSDM1_CH0CFGR1  \ offset: 0x00 : channel configuration y register
$50016004 constant SEC_DFSDM1_CH0CFGR2  \ offset: 0x04 : channel configuration y register
$50016008 constant SEC_DFSDM1_CH0AWSCDR  \ offset: 0x08 : analog watchdog and short-circuit detector register
$5001600c constant SEC_DFSDM1_CH0WDATR  \ offset: 0x0C : channel watchdog filter data register
$50016010 constant SEC_DFSDM1_CH0DATINR  \ offset: 0x10 : channel data input register
$50016014 constant SEC_DFSDM1_CH0DLYR  \ offset: 0x14 : DFSDM channel y delay register
$50016020 constant SEC_DFSDM1_CH1CFGR1  \ offset: 0x20 : CHCFG1R1
$50016024 constant SEC_DFSDM1_CH1CFGR2  \ offset: 0x24 : CHCFG1R2
$50016028 constant SEC_DFSDM1_CH1AWSCDR  \ offset: 0x28 : AWSCD1R
$5001602c constant SEC_DFSDM1_CH1WDATR  \ offset: 0x2C : CHWDAT1R
$50016030 constant SEC_DFSDM1_CH1DATINR  \ offset: 0x30 : CHDATIN1R
$50016034 constant SEC_DFSDM1_CH1DLYR  \ offset: 0x34 : DFSDM channel y delay register
$50016040 constant SEC_DFSDM1_CH2CFGR1  \ offset: 0x40 : CHCFG2R1
$50016044 constant SEC_DFSDM1_CH2CFGR2  \ offset: 0x44 : CHCFG2R2
$50016048 constant SEC_DFSDM1_CH2AWSCDR  \ offset: 0x48 : AWSCD2R
$5001604c constant SEC_DFSDM1_CH2WDATR  \ offset: 0x4C : CHWDAT2R
$50016050 constant SEC_DFSDM1_CH2DATINR  \ offset: 0x50 : CHDATIN2R
$50016054 constant SEC_DFSDM1_CH2DLYR  \ offset: 0x54 : DFSDM channel y delay register
$50016060 constant SEC_DFSDM1_CH3CFGR1  \ offset: 0x60 : CHCFG3R1
$50016064 constant SEC_DFSDM1_CH3CFGR2  \ offset: 0x64 : CHCFG3R2
$50016068 constant SEC_DFSDM1_CH3AWSCDR  \ offset: 0x68 : AWSCD3R
$5001606c constant SEC_DFSDM1_CH3WDATR  \ offset: 0x6C : CHWDAT3R
$50016070 constant SEC_DFSDM1_CH3DATINR  \ offset: 0x70 : CHDATIN3R
$50016074 constant SEC_DFSDM1_CH3DLYR  \ offset: 0x74 : DFSDM channel y delay register
$50016080 constant SEC_DFSDM1_CH4CFGR1  \ offset: 0x80 : CHCFG4R1
$50016084 constant SEC_DFSDM1_CH4CFGR2  \ offset: 0x84 : CHCFG4R2
$50016088 constant SEC_DFSDM1_CH4AWSCDR  \ offset: 0x88 : AWSCD4R
$5001608c constant SEC_DFSDM1_CH4WDATR  \ offset: 0x8C : CHWDAT4R
$50016090 constant SEC_DFSDM1_CH4DATINR  \ offset: 0x90 : CHDATIN4R
$50016094 constant SEC_DFSDM1_CH4DLYR  \ offset: 0x94 : DFSDM channel y delay register
$500160a0 constant SEC_DFSDM1_CH5CFGR1  \ offset: 0xA0 : CHCFG5R1
$500160a4 constant SEC_DFSDM1_CH5CFGR2  \ offset: 0xA4 : CHCFG5R2
$500160a8 constant SEC_DFSDM1_CH5AWSCDR  \ offset: 0xA8 : AWSCD5R
$500160ac constant SEC_DFSDM1_CH5WDATR  \ offset: 0xAC : CHWDAT5R
$500160b0 constant SEC_DFSDM1_CH5DATINR  \ offset: 0xB0 : CHDATIN5R
$500160b4 constant SEC_DFSDM1_CH5DLYR  \ offset: 0xB4 : DFSDM channel y delay register
$500160c0 constant SEC_DFSDM1_CH6CFGR1  \ offset: 0xC0 : CHCFG6R1
$500160c4 constant SEC_DFSDM1_CH6CFGR2  \ offset: 0xC4 : CH6CFGR2
$500160c8 constant SEC_DFSDM1_CH6AWSCDR  \ offset: 0xC8 : AWSCD6R
$500160cc constant SEC_DFSDM1_CH6WDATR  \ offset: 0xCC : CHWDAT6R
$500160d0 constant SEC_DFSDM1_CH6DATINR  \ offset: 0xD0 : CHDATIN6R
$500160d4 constant SEC_DFSDM1_CH6DLYR  \ offset: 0xD4 : DFSDM channel y delay register
$500160e0 constant SEC_DFSDM1_CH7CFGR1  \ offset: 0xE0 : CHCFG7R1
$500160e4 constant SEC_DFSDM1_CH7CFGR2  \ offset: 0xE4 : CHCFG7R2
$500160e8 constant SEC_DFSDM1_CH7AWSCDR  \ offset: 0xE8 : AWSCD7R
$500160ec constant SEC_DFSDM1_CH7WDATR  \ offset: 0xEC : CHWDAT7R
$500160f0 constant SEC_DFSDM1_CH7DATINR  \ offset: 0xF0 : CHDATIN7R
$500160f4 constant SEC_DFSDM1_CH7DLYR  \ offset: 0xF4 : DFSDM channel y delay register
$50016100 constant SEC_DFSDM1_FLT0CR1  \ offset: 0x100 : control register 1
$50016104 constant SEC_DFSDM1_FLT0CR2  \ offset: 0x104 : control register 2
$50016108 constant SEC_DFSDM1_FLT0ISR  \ offset: 0x108 : interrupt and status register
$5001610c constant SEC_DFSDM1_FLT0ICR  \ offset: 0x10C : interrupt flag clear register
$50016110 constant SEC_DFSDM1_FLT0JCHGR  \ offset: 0x110 : injected channel group selection register
$50016114 constant SEC_DFSDM1_FLT0FCR  \ offset: 0x114 : filter control register
$50016118 constant SEC_DFSDM1_FLT0JDATAR  \ offset: 0x118 : data register for injected group
$5001611c constant SEC_DFSDM1_FLT0RDATAR  \ offset: 0x11C : data register for the regular channel
$50016120 constant SEC_DFSDM1_FLT0AWHTR  \ offset: 0x120 : analog watchdog high threshold register
$50016124 constant SEC_DFSDM1_FLT0AWLTR  \ offset: 0x124 : analog watchdog low threshold register
$50016128 constant SEC_DFSDM1_FLT0AWSR  \ offset: 0x128 : analog watchdog status register
$5001612c constant SEC_DFSDM1_FLT0AWCFR  \ offset: 0x12C : analog watchdog clear flag register
$50016130 constant SEC_DFSDM1_FLT0EXMAX  \ offset: 0x130 : Extremes detector maximum register
$50016134 constant SEC_DFSDM1_FLT0EXMIN  \ offset: 0x134 : Extremes detector minimum register
$50016138 constant SEC_DFSDM1_FLT0CNVTIMR  \ offset: 0x138 : conversion timer register
$50016180 constant SEC_DFSDM1_FLT1CR1  \ offset: 0x180 : control register 1
$50016184 constant SEC_DFSDM1_FLT1CR2  \ offset: 0x184 : control register 2
$50016188 constant SEC_DFSDM1_FLT1ISR  \ offset: 0x188 : interrupt and status register
$5001618c constant SEC_DFSDM1_FLT1ICR  \ offset: 0x18C : interrupt flag clear register
$50016190 constant SEC_DFSDM1_FLT1JCHGR  \ offset: 0x190 : injected channel group selection register
$50016194 constant SEC_DFSDM1_FLT1FCR  \ offset: 0x194 : filter control register
$50016198 constant SEC_DFSDM1_FLT1JDATAR  \ offset: 0x198 : data register for injected group
$5001619c constant SEC_DFSDM1_FLT1RDATAR  \ offset: 0x19C : data register for the regular channel
$500161a4 constant SEC_DFSDM1_FLT1AWLTR  \ offset: 0x1A4 : analog watchdog low threshold register
$500161a8 constant SEC_DFSDM1_FLT1AWSR  \ offset: 0x1A8 : analog watchdog status register
$500161ac constant SEC_DFSDM1_FLT1AWHTR  \ offset: 0x1AC : analog watchdog high threshold register
$500161ac constant SEC_DFSDM1_FLT1AWCFR  \ offset: 0x1AC : analog watchdog clear flag register
$500161b0 constant SEC_DFSDM1_FLT1EXMAX  \ offset: 0x1B0 : Extremes detector maximum register
$500161b4 constant SEC_DFSDM1_FLT1EXMIN  \ offset: 0x1B4 : Extremes detector minimum register
$500161b8 constant SEC_DFSDM1_FLT1CNVTIMR  \ offset: 0x1B8 : conversion timer register
$50016200 constant SEC_DFSDM1_FLT2CR1  \ offset: 0x200 : control register 1
$50016204 constant SEC_DFSDM1_FLT2CR2  \ offset: 0x204 : control register 2
$50016208 constant SEC_DFSDM1_FLT2ISR  \ offset: 0x208 : interrupt and status register
$5001620c constant SEC_DFSDM1_FLT2ICR  \ offset: 0x20C : interrupt flag clear register
$50016210 constant SEC_DFSDM1_FLT2JCHGR  \ offset: 0x210 : injected channel group selection register
$50016214 constant SEC_DFSDM1_FLT2FCR  \ offset: 0x214 : filter control register
$50016218 constant SEC_DFSDM1_FLT2JDATAR  \ offset: 0x218 : data register for injected group
$5001621c constant SEC_DFSDM1_FLT2RDATAR  \ offset: 0x21C : data register for the regular channel
$50016220 constant SEC_DFSDM1_FLT2AWHTR  \ offset: 0x220 : analog watchdog high threshold register
$50016224 constant SEC_DFSDM1_FLT2AWLTR  \ offset: 0x224 : analog watchdog low threshold register
$50016228 constant SEC_DFSDM1_FLT2AWSR  \ offset: 0x228 : analog watchdog status register
$5001622c constant SEC_DFSDM1_FLT2AWCFR  \ offset: 0x22C : analog watchdog clear flag register
$50016230 constant SEC_DFSDM1_FLT2EXMAX  \ offset: 0x230 : Extremes detector maximum register
$50016234 constant SEC_DFSDM1_FLT2EXMIN  \ offset: 0x234 : Extremes detector minimum register
$50016238 constant SEC_DFSDM1_FLT2CNVTIMR  \ offset: 0x238 : conversion timer register
$50016280 constant SEC_DFSDM1_FLT3CR1  \ offset: 0x280 : control register 1
$50016284 constant SEC_DFSDM1_FLT3CR2  \ offset: 0x284 : control register 2
$50016288 constant SEC_DFSDM1_FLT3ISR  \ offset: 0x288 : interrupt and status register
$5001628c constant SEC_DFSDM1_FLT3ICR  \ offset: 0x28C : interrupt flag clear register
$50016290 constant SEC_DFSDM1_FLT3JCHGR  \ offset: 0x290 : injected channel group selection register
$50016294 constant SEC_DFSDM1_FLT3FCR  \ offset: 0x294 : filter control register
$50016298 constant SEC_DFSDM1_FLT3JDATAR  \ offset: 0x298 : data register for injected group
$5001629c constant SEC_DFSDM1_FLT3RDATAR  \ offset: 0x29C : data register for the regular channel
$500162a0 constant SEC_DFSDM1_FLT3AWHTR  \ offset: 0x2A0 : analog watchdog high threshold register
$500162a4 constant SEC_DFSDM1_FLT3AWLTR  \ offset: 0x2A4 : analog watchdog low threshold register
$500162a8 constant SEC_DFSDM1_FLT3AWSR  \ offset: 0x2A8 : analog watchdog status register
$500162ac constant SEC_DFSDM1_FLT3AWCFR  \ offset: 0x2AC : analog watchdog clear flag register
$500162b0 constant SEC_DFSDM1_FLT3EXMAX  \ offset: 0x2B0 : Extremes detector maximum register
$500162b4 constant SEC_DFSDM1_FLT3EXMIN  \ offset: 0x2B4 : Extremes detector minimum register
$500162b8 constant SEC_DFSDM1_FLT3CNVTIMR  \ offset: 0x2B8 : conversion timer register

