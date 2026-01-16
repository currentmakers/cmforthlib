\
\ @file dfsdm1.fs
\ @brief DFSDM1
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief This register specifies the parameters used by channel y.
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000003 constant DFSDM1_DFSDM_CH0CFGR1_SITP                       \ SITP
$0000000c constant DFSDM1_DFSDM_CH0CFGR1_SPICKSEL                   \ SPICKSEL
$00000020 constant DFSDM1_DFSDM_CH0CFGR1_SCDEN                      \ SCDEN
$00000040 constant DFSDM1_DFSDM_CH0CFGR1_CKABEN                     \ CKABEN
$00000080 constant DFSDM1_DFSDM_CH0CFGR1_CHEN                       \ CHEN
$00000100 constant DFSDM1_DFSDM_CH0CFGR1_CHINSEL                    \ CHINSEL
$00003000 constant DFSDM1_DFSDM_CH0CFGR1_DATMPX                     \ DATMPX
$0000c000 constant DFSDM1_DFSDM_CH0CFGR1_DATPACK                    \ DATPACK
$00ff0000 constant DFSDM1_DFSDM_CH0CFGR1_CKOUTDIV                   \ CKOUTDIV
$40000000 constant DFSDM1_DFSDM_CH0CFGR1_CKOUTSRC                   \ CKOUTSRC
$80000000 constant DFSDM1_DFSDM_CH0CFGR1_DFSDMEN                    \ DFSDMEN


\
\ @brief This register specifies the parameters used by channel y.
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$000000f8 constant DFSDM1_DFSDM_CH0CFGR2_DTRBS                      \ DTRBS
$ffffff00 constant DFSDM1_DFSDM_CH0CFGR2_OFFSET                     \ OFFSET


\
\ @brief Short-circuit detector and analog watchdog settings for channel y.
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$000000ff constant DFSDM1_DFSDM_CH0AWSCDR_SCDT                      \ SCDT
$0000f000 constant DFSDM1_DFSDM_CH0AWSCDR_BKSCD                     \ BKSCD
$001f0000 constant DFSDM1_DFSDM_CH0AWSCDR_AWFOSR                    \ AWFOSR
$00c00000 constant DFSDM1_DFSDM_CH0AWSCDR_AWFORD                    \ AWFORD


\
\ @brief This register contains the data resulting from the analog watchdog filter associated to the input channel y.
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$0000ffff constant DFSDM1_DFSDM_CH0WDATR_WDATA                      \ WDATA


\
\ @brief This register contains 16-bit input data to be processed by DFSDM filter module.
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$0000ffff constant DFSDM1_DFSDM_CH0DATINR_INDAT0                    \ INDAT0
$ffff0000 constant DFSDM1_DFSDM_CH0DATINR_INDAT1                    \ INDAT1


\
\ @brief DFSDM channel 0 delay register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$0000003f constant DFSDM1_DFSDM_CH0DLYR_PLSSKP                      \ PLSSKP


\
\ @brief This register specifies the parameters used by channel y.
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000003 constant DFSDM1_DFSDM_CH1CFGR1_SITP                       \ SITP
$0000000c constant DFSDM1_DFSDM_CH1CFGR1_SPICKSEL                   \ SPICKSEL
$00000020 constant DFSDM1_DFSDM_CH1CFGR1_SCDEN                      \ SCDEN
$00000040 constant DFSDM1_DFSDM_CH1CFGR1_CKABEN                     \ CKABEN
$00000080 constant DFSDM1_DFSDM_CH1CFGR1_CHEN                       \ CHEN
$00000100 constant DFSDM1_DFSDM_CH1CFGR1_CHINSEL                    \ CHINSEL
$00003000 constant DFSDM1_DFSDM_CH1CFGR1_DATMPX                     \ DATMPX
$0000c000 constant DFSDM1_DFSDM_CH1CFGR1_DATPACK                    \ DATPACK
$00ff0000 constant DFSDM1_DFSDM_CH1CFGR1_CKOUTDIV                   \ CKOUTDIV
$40000000 constant DFSDM1_DFSDM_CH1CFGR1_CKOUTSRC                   \ CKOUTSRC
$80000000 constant DFSDM1_DFSDM_CH1CFGR1_DFSDMEN                    \ DFSDMEN


\
\ @brief This register specifies the parameters used by channel y.
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$000000f8 constant DFSDM1_DFSDM_CH1CFGR2_DTRBS                      \ DTRBS
$ffffff00 constant DFSDM1_DFSDM_CH1CFGR2_OFFSET                     \ OFFSET


\
\ @brief Short-circuit detector and analog watchdog settings for channel y.
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$000000ff constant DFSDM1_DFSDM_CH1AWSCDR_SCDT                      \ SCDT
$0000f000 constant DFSDM1_DFSDM_CH1AWSCDR_BKSCD                     \ BKSCD
$001f0000 constant DFSDM1_DFSDM_CH1AWSCDR_AWFOSR                    \ AWFOSR
$00c00000 constant DFSDM1_DFSDM_CH1AWSCDR_AWFORD                    \ AWFORD


\
\ @brief This register contains the data resulting from the analog watchdog filter associated to the input channel y.
\ Address offset: 0x2C
\ Reset value: 0x00000000
\

$0000ffff constant DFSDM1_DFSDM_CH1WDATR_WDATA                      \ WDATA


\
\ @brief This register contains 16-bit input data to be processed by DFSDM filter module.
\ Address offset: 0x30
\ Reset value: 0x00000000
\

$0000ffff constant DFSDM1_DFSDM_CH1DATINR_INDAT0                    \ INDAT0
$ffff0000 constant DFSDM1_DFSDM_CH1DATINR_INDAT1                    \ INDAT1


\
\ @brief DFSDM channel 1 delay register
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$0000003f constant DFSDM1_DFSDM_CH1DLYR_PLSSKP                      \ PLSSKP


\
\ @brief This register specifies the parameters used by channel y.
\ Address offset: 0x40
\ Reset value: 0x00000000
\

$00000003 constant DFSDM1_DFSDM_CH2CFGR1_SITP                       \ SITP
$0000000c constant DFSDM1_DFSDM_CH2CFGR1_SPICKSEL                   \ SPICKSEL
$00000020 constant DFSDM1_DFSDM_CH2CFGR1_SCDEN                      \ SCDEN
$00000040 constant DFSDM1_DFSDM_CH2CFGR1_CKABEN                     \ CKABEN
$00000080 constant DFSDM1_DFSDM_CH2CFGR1_CHEN                       \ CHEN
$00000100 constant DFSDM1_DFSDM_CH2CFGR1_CHINSEL                    \ CHINSEL
$00003000 constant DFSDM1_DFSDM_CH2CFGR1_DATMPX                     \ DATMPX
$0000c000 constant DFSDM1_DFSDM_CH2CFGR1_DATPACK                    \ DATPACK
$00ff0000 constant DFSDM1_DFSDM_CH2CFGR1_CKOUTDIV                   \ CKOUTDIV
$40000000 constant DFSDM1_DFSDM_CH2CFGR1_CKOUTSRC                   \ CKOUTSRC
$80000000 constant DFSDM1_DFSDM_CH2CFGR1_DFSDMEN                    \ DFSDMEN


\
\ @brief This register specifies the parameters used by channel y.
\ Address offset: 0x44
\ Reset value: 0x00000000
\

$000000f8 constant DFSDM1_DFSDM_CH2CFGR2_DTRBS                      \ DTRBS
$ffffff00 constant DFSDM1_DFSDM_CH2CFGR2_OFFSET                     \ OFFSET


\
\ @brief Short-circuit detector and analog watchdog settings for channel y.
\ Address offset: 0x48
\ Reset value: 0x00000000
\

$000000ff constant DFSDM1_DFSDM_CH2AWSCDR_SCDT                      \ SCDT
$0000f000 constant DFSDM1_DFSDM_CH2AWSCDR_BKSCD                     \ BKSCD
$001f0000 constant DFSDM1_DFSDM_CH2AWSCDR_AWFOSR                    \ AWFOSR
$00c00000 constant DFSDM1_DFSDM_CH2AWSCDR_AWFORD                    \ AWFORD


\
\ @brief This register contains the data resulting from the analog watchdog filter associated to the input channel y.
\ Address offset: 0x4C
\ Reset value: 0x00000000
\

$0000ffff constant DFSDM1_DFSDM_CH2WDATR_WDATA                      \ WDATA


\
\ @brief This register contains 16-bit input data to be processed by DFSDM filter module.
\ Address offset: 0x50
\ Reset value: 0x00000000
\

$0000ffff constant DFSDM1_DFSDM_CH2DATINR_INDAT0                    \ INDAT0
$ffff0000 constant DFSDM1_DFSDM_CH2DATINR_INDAT1                    \ INDAT1


\
\ @brief DFSDM channel 2 delay register
\ Address offset: 0x54
\ Reset value: 0x00000000
\

$0000003f constant DFSDM1_DFSDM_CH2DLYR_PLSSKP                      \ PLSSKP


\
\ @brief This register specifies the parameters used by channel y.
\ Address offset: 0x60
\ Reset value: 0x00000000
\

$00000003 constant DFSDM1_DFSDM_CH3CFGR1_SITP                       \ SITP
$0000000c constant DFSDM1_DFSDM_CH3CFGR1_SPICKSEL                   \ SPICKSEL
$00000020 constant DFSDM1_DFSDM_CH3CFGR1_SCDEN                      \ SCDEN
$00000040 constant DFSDM1_DFSDM_CH3CFGR1_CKABEN                     \ CKABEN
$00000080 constant DFSDM1_DFSDM_CH3CFGR1_CHEN                       \ CHEN
$00000100 constant DFSDM1_DFSDM_CH3CFGR1_CHINSEL                    \ CHINSEL
$00003000 constant DFSDM1_DFSDM_CH3CFGR1_DATMPX                     \ DATMPX
$0000c000 constant DFSDM1_DFSDM_CH3CFGR1_DATPACK                    \ DATPACK
$00ff0000 constant DFSDM1_DFSDM_CH3CFGR1_CKOUTDIV                   \ CKOUTDIV
$40000000 constant DFSDM1_DFSDM_CH3CFGR1_CKOUTSRC                   \ CKOUTSRC
$80000000 constant DFSDM1_DFSDM_CH3CFGR1_DFSDMEN                    \ DFSDMEN


\
\ @brief This register specifies the parameters used by channel y.
\ Address offset: 0x64
\ Reset value: 0x00000000
\

$000000f8 constant DFSDM1_DFSDM_CH3CFGR2_DTRBS                      \ DTRBS
$ffffff00 constant DFSDM1_DFSDM_CH3CFGR2_OFFSET                     \ OFFSET


\
\ @brief Short-circuit detector and analog watchdog settings for channel y.
\ Address offset: 0x68
\ Reset value: 0x00000000
\

$000000ff constant DFSDM1_DFSDM_CH3AWSCDR_SCDT                      \ SCDT
$0000f000 constant DFSDM1_DFSDM_CH3AWSCDR_BKSCD                     \ BKSCD
$001f0000 constant DFSDM1_DFSDM_CH3AWSCDR_AWFOSR                    \ AWFOSR
$00c00000 constant DFSDM1_DFSDM_CH3AWSCDR_AWFORD                    \ AWFORD


\
\ @brief This register contains the data resulting from the analog watchdog filter associated to the input channel y.
\ Address offset: 0x6C
\ Reset value: 0x00000000
\

$0000ffff constant DFSDM1_DFSDM_CH3WDATR_WDATA                      \ WDATA


\
\ @brief This register contains 16-bit input data to be processed by DFSDM filter module.
\ Address offset: 0x70
\ Reset value: 0x00000000
\

$0000ffff constant DFSDM1_DFSDM_CH3DATINR_INDAT0                    \ INDAT0
$ffff0000 constant DFSDM1_DFSDM_CH3DATINR_INDAT1                    \ INDAT1


\
\ @brief DFSDM channel 3 delay register
\ Address offset: 0x74
\ Reset value: 0x00000000
\

$0000003f constant DFSDM1_DFSDM_CH3DLYR_PLSSKP                      \ PLSSKP


\
\ @brief This register specifies the parameters used by channel y.
\ Address offset: 0x80
\ Reset value: 0x00000000
\

$00000003 constant DFSDM1_DFSDM_CH4CFGR1_SITP                       \ SITP
$0000000c constant DFSDM1_DFSDM_CH4CFGR1_SPICKSEL                   \ SPICKSEL
$00000020 constant DFSDM1_DFSDM_CH4CFGR1_SCDEN                      \ SCDEN
$00000040 constant DFSDM1_DFSDM_CH4CFGR1_CKABEN                     \ CKABEN
$00000080 constant DFSDM1_DFSDM_CH4CFGR1_CHEN                       \ CHEN
$00000100 constant DFSDM1_DFSDM_CH4CFGR1_CHINSEL                    \ CHINSEL
$00003000 constant DFSDM1_DFSDM_CH4CFGR1_DATMPX                     \ DATMPX
$0000c000 constant DFSDM1_DFSDM_CH4CFGR1_DATPACK                    \ DATPACK
$00ff0000 constant DFSDM1_DFSDM_CH4CFGR1_CKOUTDIV                   \ CKOUTDIV
$40000000 constant DFSDM1_DFSDM_CH4CFGR1_CKOUTSRC                   \ CKOUTSRC
$80000000 constant DFSDM1_DFSDM_CH4CFGR1_DFSDMEN                    \ DFSDMEN


\
\ @brief This register specifies the parameters used by channel y.
\ Address offset: 0x84
\ Reset value: 0x00000000
\

$000000f8 constant DFSDM1_DFSDM_CH4CFGR2_DTRBS                      \ DTRBS
$ffffff00 constant DFSDM1_DFSDM_CH4CFGR2_OFFSET                     \ OFFSET


\
\ @brief Short-circuit detector and analog watchdog settings for channel y.
\ Address offset: 0x88
\ Reset value: 0x00000000
\

$000000ff constant DFSDM1_DFSDM_CH4AWSCDR_SCDT                      \ SCDT
$0000f000 constant DFSDM1_DFSDM_CH4AWSCDR_BKSCD                     \ BKSCD
$001f0000 constant DFSDM1_DFSDM_CH4AWSCDR_AWFOSR                    \ AWFOSR
$00c00000 constant DFSDM1_DFSDM_CH4AWSCDR_AWFORD                    \ AWFORD


\
\ @brief This register contains the data resulting from the analog watchdog filter associated to the input channel y.
\ Address offset: 0x8C
\ Reset value: 0x00000000
\

$0000ffff constant DFSDM1_DFSDM_CH4WDATR_WDATA                      \ WDATA


\
\ @brief This register contains 16-bit input data to be processed by DFSDM filter module.
\ Address offset: 0x90
\ Reset value: 0x00000000
\

$0000ffff constant DFSDM1_DFSDM_CH4DATINR_INDAT0                    \ INDAT0
$ffff0000 constant DFSDM1_DFSDM_CH4DATINR_INDAT1                    \ INDAT1


\
\ @brief DFSDM channel 4 delay register
\ Address offset: 0x94
\ Reset value: 0x00000000
\

$0000003f constant DFSDM1_DFSDM_CH4DLYR_PLSSKP                      \ PLSSKP


\
\ @brief This register specifies the parameters used by channel y.
\ Address offset: 0xA0
\ Reset value: 0x00000000
\

$00000003 constant DFSDM1_DFSDM_CH5CFGR1_SITP                       \ SITP
$0000000c constant DFSDM1_DFSDM_CH5CFGR1_SPICKSEL                   \ SPICKSEL
$00000020 constant DFSDM1_DFSDM_CH5CFGR1_SCDEN                      \ SCDEN
$00000040 constant DFSDM1_DFSDM_CH5CFGR1_CKABEN                     \ CKABEN
$00000080 constant DFSDM1_DFSDM_CH5CFGR1_CHEN                       \ CHEN
$00000100 constant DFSDM1_DFSDM_CH5CFGR1_CHINSEL                    \ CHINSEL
$00003000 constant DFSDM1_DFSDM_CH5CFGR1_DATMPX                     \ DATMPX
$0000c000 constant DFSDM1_DFSDM_CH5CFGR1_DATPACK                    \ DATPACK
$00ff0000 constant DFSDM1_DFSDM_CH5CFGR1_CKOUTDIV                   \ CKOUTDIV
$40000000 constant DFSDM1_DFSDM_CH5CFGR1_CKOUTSRC                   \ CKOUTSRC
$80000000 constant DFSDM1_DFSDM_CH5CFGR1_DFSDMEN                    \ DFSDMEN


\
\ @brief This register specifies the parameters used by channel y.
\ Address offset: 0xA4
\ Reset value: 0x00000000
\

$000000f8 constant DFSDM1_DFSDM_CH5CFGR2_DTRBS                      \ DTRBS
$ffffff00 constant DFSDM1_DFSDM_CH5CFGR2_OFFSET                     \ OFFSET


\
\ @brief Short-circuit detector and analog watchdog settings for channel y.
\ Address offset: 0xA8
\ Reset value: 0x00000000
\

$000000ff constant DFSDM1_DFSDM_CH5AWSCDR_SCDT                      \ SCDT
$0000f000 constant DFSDM1_DFSDM_CH5AWSCDR_BKSCD                     \ BKSCD
$001f0000 constant DFSDM1_DFSDM_CH5AWSCDR_AWFOSR                    \ AWFOSR
$00c00000 constant DFSDM1_DFSDM_CH5AWSCDR_AWFORD                    \ AWFORD


\
\ @brief This register contains the data resulting from the analog watchdog filter associated to the input channel y.
\ Address offset: 0xAC
\ Reset value: 0x00000000
\

$0000ffff constant DFSDM1_DFSDM_CH5WDATR_WDATA                      \ WDATA


\
\ @brief This register contains 16-bit input data to be processed by DFSDM filter module.
\ Address offset: 0xB0
\ Reset value: 0x00000000
\

$0000ffff constant DFSDM1_DFSDM_CH5DATINR_INDAT0                    \ INDAT0
$ffff0000 constant DFSDM1_DFSDM_CH5DATINR_INDAT1                    \ INDAT1


\
\ @brief DFSDM channel 5 delay register
\ Address offset: 0xB4
\ Reset value: 0x00000000
\

$0000003f constant DFSDM1_DFSDM_CH5DLYR_PLSSKP                      \ PLSSKP


\
\ @brief This register specifies the parameters used by channel y.
\ Address offset: 0xC0
\ Reset value: 0x00000000
\

$00000003 constant DFSDM1_DFSDM_CH6CFGR1_SITP                       \ SITP
$0000000c constant DFSDM1_DFSDM_CH6CFGR1_SPICKSEL                   \ SPICKSEL
$00000020 constant DFSDM1_DFSDM_CH6CFGR1_SCDEN                      \ SCDEN
$00000040 constant DFSDM1_DFSDM_CH6CFGR1_CKABEN                     \ CKABEN
$00000080 constant DFSDM1_DFSDM_CH6CFGR1_CHEN                       \ CHEN
$00000100 constant DFSDM1_DFSDM_CH6CFGR1_CHINSEL                    \ CHINSEL
$00003000 constant DFSDM1_DFSDM_CH6CFGR1_DATMPX                     \ DATMPX
$0000c000 constant DFSDM1_DFSDM_CH6CFGR1_DATPACK                    \ DATPACK
$00ff0000 constant DFSDM1_DFSDM_CH6CFGR1_CKOUTDIV                   \ CKOUTDIV
$40000000 constant DFSDM1_DFSDM_CH6CFGR1_CKOUTSRC                   \ CKOUTSRC
$80000000 constant DFSDM1_DFSDM_CH6CFGR1_DFSDMEN                    \ DFSDMEN


\
\ @brief This register specifies the parameters used by channel y.
\ Address offset: 0xC4
\ Reset value: 0x00000000
\

$000000f8 constant DFSDM1_DFSDM_CH6CFGR2_DTRBS                      \ DTRBS
$ffffff00 constant DFSDM1_DFSDM_CH6CFGR2_OFFSET                     \ OFFSET


\
\ @brief Short-circuit detector and analog watchdog settings for channel y.
\ Address offset: 0xC8
\ Reset value: 0x00000000
\

$000000ff constant DFSDM1_DFSDM_CH6AWSCDR_SCDT                      \ SCDT
$0000f000 constant DFSDM1_DFSDM_CH6AWSCDR_BKSCD                     \ BKSCD
$001f0000 constant DFSDM1_DFSDM_CH6AWSCDR_AWFOSR                    \ AWFOSR
$00c00000 constant DFSDM1_DFSDM_CH6AWSCDR_AWFORD                    \ AWFORD


\
\ @brief This register contains the data resulting from the analog watchdog filter associated to the input channel y.
\ Address offset: 0xCC
\ Reset value: 0x00000000
\

$0000ffff constant DFSDM1_DFSDM_CH6WDATR_WDATA                      \ WDATA


\
\ @brief This register contains 16-bit input data to be processed by DFSDM filter module.
\ Address offset: 0xD0
\ Reset value: 0x00000000
\

$0000ffff constant DFSDM1_DFSDM_CH6DATINR_INDAT0                    \ INDAT0
$ffff0000 constant DFSDM1_DFSDM_CH6DATINR_INDAT1                    \ INDAT1


\
\ @brief DFSDM channel 6 delay register
\ Address offset: 0xD4
\ Reset value: 0x00000000
\

$0000003f constant DFSDM1_DFSDM_CH6DLYR_PLSSKP                      \ PLSSKP


\
\ @brief This register specifies the parameters used by channel y.
\ Address offset: 0xE0
\ Reset value: 0x00000000
\

$00000003 constant DFSDM1_DFSDM_CH7CFGR1_SITP                       \ SITP
$0000000c constant DFSDM1_DFSDM_CH7CFGR1_SPICKSEL                   \ SPICKSEL
$00000020 constant DFSDM1_DFSDM_CH7CFGR1_SCDEN                      \ SCDEN
$00000040 constant DFSDM1_DFSDM_CH7CFGR1_CKABEN                     \ CKABEN
$00000080 constant DFSDM1_DFSDM_CH7CFGR1_CHEN                       \ CHEN
$00000100 constant DFSDM1_DFSDM_CH7CFGR1_CHINSEL                    \ CHINSEL
$00003000 constant DFSDM1_DFSDM_CH7CFGR1_DATMPX                     \ DATMPX
$0000c000 constant DFSDM1_DFSDM_CH7CFGR1_DATPACK                    \ DATPACK
$00ff0000 constant DFSDM1_DFSDM_CH7CFGR1_CKOUTDIV                   \ CKOUTDIV
$40000000 constant DFSDM1_DFSDM_CH7CFGR1_CKOUTSRC                   \ CKOUTSRC
$80000000 constant DFSDM1_DFSDM_CH7CFGR1_DFSDMEN                    \ DFSDMEN


\
\ @brief This register specifies the parameters used by channel y.
\ Address offset: 0xE4
\ Reset value: 0x00000000
\

$000000f8 constant DFSDM1_DFSDM_CH7CFGR2_DTRBS                      \ DTRBS
$ffffff00 constant DFSDM1_DFSDM_CH7CFGR2_OFFSET                     \ OFFSET


\
\ @brief Short-circuit detector and analog watchdog settings for channel y.
\ Address offset: 0xE8
\ Reset value: 0x00000000
\

$000000ff constant DFSDM1_DFSDM_CH7AWSCDR_SCDT                      \ SCDT
$0000f000 constant DFSDM1_DFSDM_CH7AWSCDR_BKSCD                     \ BKSCD
$001f0000 constant DFSDM1_DFSDM_CH7AWSCDR_AWFOSR                    \ AWFOSR
$00c00000 constant DFSDM1_DFSDM_CH7AWSCDR_AWFORD                    \ AWFORD


\
\ @brief This register contains the data resulting from the analog watchdog filter associated to the input channel y.
\ Address offset: 0xEC
\ Reset value: 0x00000000
\

$0000ffff constant DFSDM1_DFSDM_CH7WDATR_WDATA                      \ WDATA


\
\ @brief This register contains 16-bit input data to be processed by DFSDM filter module.
\ Address offset: 0xF0
\ Reset value: 0x00000000
\

$0000ffff constant DFSDM1_DFSDM_CH7DATINR_INDAT0                    \ INDAT0
$ffff0000 constant DFSDM1_DFSDM_CH7DATINR_INDAT1                    \ INDAT1


\
\ @brief DFSDM channel 7 delay register
\ Address offset: 0xF4
\ Reset value: 0x00000000
\

$0000003f constant DFSDM1_DFSDM_CH7DLYR_PLSSKP                      \ PLSSKP


\
\ @brief DFSDM filter 0 control register 1
\ Address offset: 0x100
\ Reset value: 0x00000000
\

$00000001 constant DFSDM1_DFSDM_FLT0CR1_DFEN                        \ DFEN
$00000002 constant DFSDM1_DFSDM_FLT0CR1_JSWSTART                    \ JSWSTART
$00000008 constant DFSDM1_DFSDM_FLT0CR1_JSYNC                       \ JSYNC
$00000010 constant DFSDM1_DFSDM_FLT0CR1_JSCAN                       \ JSCAN
$00000020 constant DFSDM1_DFSDM_FLT0CR1_JDMAEN                      \ JDMAEN
$00001f00 constant DFSDM1_DFSDM_FLT0CR1_JEXTSEL                     \ JEXTSEL
$00006000 constant DFSDM1_DFSDM_FLT0CR1_JEXTEN                      \ JEXTEN
$00020000 constant DFSDM1_DFSDM_FLT0CR1_RSWSTART                    \ RSWSTART
$00040000 constant DFSDM1_DFSDM_FLT0CR1_RCONT                       \ RCONT
$00080000 constant DFSDM1_DFSDM_FLT0CR1_RSYNC                       \ RSYNC
$00200000 constant DFSDM1_DFSDM_FLT0CR1_RDMAEN                      \ RDMAEN
$07000000 constant DFSDM1_DFSDM_FLT0CR1_RCH                         \ RCH
$20000000 constant DFSDM1_DFSDM_FLT0CR1_FAST                        \ FAST
$40000000 constant DFSDM1_DFSDM_FLT0CR1_AWFSEL                      \ AWFSEL


\
\ @brief DFSDM filter 0 control register 2
\ Address offset: 0x104
\ Reset value: 0x00000000
\

$00000001 constant DFSDM1_DFSDM_FLT0CR2_JEOCIE                      \ JEOCIE
$00000002 constant DFSDM1_DFSDM_FLT0CR2_REOCIE                      \ REOCIE
$00000004 constant DFSDM1_DFSDM_FLT0CR2_JOVRIE                      \ JOVRIE
$00000008 constant DFSDM1_DFSDM_FLT0CR2_ROVRIE                      \ ROVRIE
$00000010 constant DFSDM1_DFSDM_FLT0CR2_AWDIE                       \ AWDIE
$00000020 constant DFSDM1_DFSDM_FLT0CR2_SCDIE                       \ SCDIE
$00000040 constant DFSDM1_DFSDM_FLT0CR2_CKABIE                      \ CKABIE
$0000ff00 constant DFSDM1_DFSDM_FLT0CR2_EXCH                        \ EXCH
$00ff0000 constant DFSDM1_DFSDM_FLT0CR2_AWDCH                       \ AWDCH


\
\ @brief DFSDM filter 0 interrupt and status register
\ Address offset: 0x108
\ Reset value: 0x00FF0000
\

$00000001 constant DFSDM1_DFSDM_FLT0ISR_JEOCF                       \ JEOCF
$00000002 constant DFSDM1_DFSDM_FLT0ISR_REOCF                       \ REOCF
$00000004 constant DFSDM1_DFSDM_FLT0ISR_JOVRF                       \ JOVRF
$00000008 constant DFSDM1_DFSDM_FLT0ISR_ROVRF                       \ ROVRF
$00000010 constant DFSDM1_DFSDM_FLT0ISR_AWDF                        \ AWDF
$00002000 constant DFSDM1_DFSDM_FLT0ISR_JCIP                        \ JCIP
$00004000 constant DFSDM1_DFSDM_FLT0ISR_RCIP                        \ RCIP
$00ff0000 constant DFSDM1_DFSDM_FLT0ISR_CKABF                       \ CKABF
$ff000000 constant DFSDM1_DFSDM_FLT0ISR_SCDF                        \ SCDF


\
\ @brief DFSDM filter 0 interrupt flag clear register
\ Address offset: 0x10C
\ Reset value: 0x00000000
\

$00000004 constant DFSDM1_DFSDM_FLT0ICR_CLRJOVRF                    \ CLRJOVRF
$00000008 constant DFSDM1_DFSDM_FLT0ICR_CLRROVRF                    \ CLRROVRF
$00ff0000 constant DFSDM1_DFSDM_FLT0ICR_CLRCKABF                    \ CLRCKABF
$ff000000 constant DFSDM1_DFSDM_FLT0ICR_CLRSCDF                     \ CLRSCDF


\
\ @brief DFSDM filter 0 injected channel group selection register
\ Address offset: 0x110
\ Reset value: 0x00000001
\

$000000ff constant DFSDM1_DFSDM_FLT0JCHGR_JCHG                      \ JCHG


\
\ @brief DFSDM filter 0 control register
\ Address offset: 0x114
\ Reset value: 0x00000000
\

$000000ff constant DFSDM1_DFSDM_FLT0FCR_IOSR                        \ IOSR
$03ff0000 constant DFSDM1_DFSDM_FLT0FCR_FOSR                        \ FOSR
$e0000000 constant DFSDM1_DFSDM_FLT0FCR_FORD                        \ FORD


\
\ @brief DFSDM filter 0 data register for injected group
\ Address offset: 0x118
\ Reset value: 0x00000000
\

$00000007 constant DFSDM1_DFSDM_FLT0JDATAR_JDATACH                  \ JDATACH
$ffffff00 constant DFSDM1_DFSDM_FLT0JDATAR_JDATA                    \ JDATA


\
\ @brief DFSDM filter 0 data register for the regular channel
\ Address offset: 0x11C
\ Reset value: 0x00000000
\

$00000007 constant DFSDM1_DFSDM_FLT0RDATAR_RDATACH                  \ RDATACH
$00000010 constant DFSDM1_DFSDM_FLT0RDATAR_RPEND                    \ RPEND
$ffffff00 constant DFSDM1_DFSDM_FLT0RDATAR_RDATA                    \ RDATA


\
\ @brief DFSDM filter 0 analog watchdog high threshold register
\ Address offset: 0x120
\ Reset value: 0x00000000
\

$0000000f constant DFSDM1_DFSDM_FLT0AWHTR_BKAWH                     \ BKAWH
$ffffff00 constant DFSDM1_DFSDM_FLT0AWHTR_AWHT                      \ AWHT


\
\ @brief DFSDM filter 0 analog watchdog low threshold register
\ Address offset: 0x124
\ Reset value: 0x00000000
\

$0000000f constant DFSDM1_DFSDM_FLT0AWLTR_BKAWL                     \ BKAWL
$ffffff00 constant DFSDM1_DFSDM_FLT0AWLTR_AWLT                      \ AWLT


\
\ @brief DFSDM filter 0 analog watchdog status register
\ Address offset: 0x128
\ Reset value: 0x00000000
\

$000000ff constant DFSDM1_DFSDM_FLT0AWSR_AWLTF                      \ AWLTF
$0000ff00 constant DFSDM1_DFSDM_FLT0AWSR_AWHTF                      \ AWHTF


\
\ @brief DFSDM filter 0 analog watchdog clear flag register
\ Address offset: 0x12C
\ Reset value: 0x00000000
\

$000000ff constant DFSDM1_DFSDM_FLT0AWCFR_CLRAWLTF                  \ CLRAWLTF
$0000ff00 constant DFSDM1_DFSDM_FLT0AWCFR_CLRAWHTF                  \ CLRAWHTF


\
\ @brief DFSDM filter 0 extremes detector maximum register
\ Address offset: 0x130
\ Reset value: 0x80000000
\

$00000007 constant DFSDM1_DFSDM_FLT0EXMAX_EXMAXCH                   \ EXMAXCH
$ffffff00 constant DFSDM1_DFSDM_FLT0EXMAX_EXMAX                     \ EXMAX


\
\ @brief DFSDM filter 0 extremes detector minimum register
\ Address offset: 0x134
\ Reset value: 0x7FFFFF00
\

$00000007 constant DFSDM1_DFSDM_FLT0EXMIN_EXMINCH                   \ EXMINCH
$ffffff00 constant DFSDM1_DFSDM_FLT0EXMIN_EXMIN                     \ EXMIN


\
\ @brief DFSDM filter 0 conversion timer register
\ Address offset: 0x138
\ Reset value: 0x00000000
\

$fffffff0 constant DFSDM1_DFSDM_FLT0CNVTIMR_CNVCNT                  \ CNVCNT


\
\ @brief DFSDM filter 1 control register 1
\ Address offset: 0x180
\ Reset value: 0x00000000
\

$00000001 constant DFSDM1_DFSDM_FLT1CR1_DFEN                        \ DFEN
$00000002 constant DFSDM1_DFSDM_FLT1CR1_JSWSTART                    \ JSWSTART
$00000008 constant DFSDM1_DFSDM_FLT1CR1_JSYNC                       \ JSYNC
$00000010 constant DFSDM1_DFSDM_FLT1CR1_JSCAN                       \ JSCAN
$00000020 constant DFSDM1_DFSDM_FLT1CR1_JDMAEN                      \ JDMAEN
$00001f00 constant DFSDM1_DFSDM_FLT1CR1_JEXTSEL                     \ JEXTSEL
$00006000 constant DFSDM1_DFSDM_FLT1CR1_JEXTEN                      \ JEXTEN
$00020000 constant DFSDM1_DFSDM_FLT1CR1_RSWSTART                    \ RSWSTART
$00040000 constant DFSDM1_DFSDM_FLT1CR1_RCONT                       \ RCONT
$00080000 constant DFSDM1_DFSDM_FLT1CR1_RSYNC                       \ RSYNC
$00200000 constant DFSDM1_DFSDM_FLT1CR1_RDMAEN                      \ RDMAEN
$07000000 constant DFSDM1_DFSDM_FLT1CR1_RCH                         \ RCH
$20000000 constant DFSDM1_DFSDM_FLT1CR1_FAST                        \ FAST
$40000000 constant DFSDM1_DFSDM_FLT1CR1_AWFSEL                      \ AWFSEL


\
\ @brief DFSDM filter 1 control register 2
\ Address offset: 0x184
\ Reset value: 0x00000000
\

$00000001 constant DFSDM1_DFSDM_FLT1CR2_JEOCIE                      \ JEOCIE
$00000002 constant DFSDM1_DFSDM_FLT1CR2_REOCIE                      \ REOCIE
$00000004 constant DFSDM1_DFSDM_FLT1CR2_JOVRIE                      \ JOVRIE
$00000008 constant DFSDM1_DFSDM_FLT1CR2_ROVRIE                      \ ROVRIE
$00000010 constant DFSDM1_DFSDM_FLT1CR2_AWDIE                       \ AWDIE
$00000020 constant DFSDM1_DFSDM_FLT1CR2_SCDIE                       \ SCDIE
$00000040 constant DFSDM1_DFSDM_FLT1CR2_CKABIE                      \ CKABIE
$0000ff00 constant DFSDM1_DFSDM_FLT1CR2_EXCH                        \ EXCH
$00ff0000 constant DFSDM1_DFSDM_FLT1CR2_AWDCH                       \ AWDCH


\
\ @brief DFSDM filter 1 interrupt and status register
\ Address offset: 0x188
\ Reset value: 0x00FF0000
\

$00000001 constant DFSDM1_DFSDM_FLT1ISR_JEOCF                       \ JEOCF
$00000002 constant DFSDM1_DFSDM_FLT1ISR_REOCF                       \ REOCF
$00000004 constant DFSDM1_DFSDM_FLT1ISR_JOVRF                       \ JOVRF
$00000008 constant DFSDM1_DFSDM_FLT1ISR_ROVRF                       \ ROVRF
$00000010 constant DFSDM1_DFSDM_FLT1ISR_AWDF                        \ AWDF
$00002000 constant DFSDM1_DFSDM_FLT1ISR_JCIP                        \ JCIP
$00004000 constant DFSDM1_DFSDM_FLT1ISR_RCIP                        \ RCIP
$00ff0000 constant DFSDM1_DFSDM_FLT1ISR_CKABF                       \ CKABF
$ff000000 constant DFSDM1_DFSDM_FLT1ISR_SCDF                        \ SCDF


\
\ @brief DFSDM filter 1 interrupt flag clear register
\ Address offset: 0x18C
\ Reset value: 0x00000000
\

$00000004 constant DFSDM1_DFSDM_FLT1ICR_CLRJOVRF                    \ CLRJOVRF
$00000008 constant DFSDM1_DFSDM_FLT1ICR_CLRROVRF                    \ CLRROVRF
$00ff0000 constant DFSDM1_DFSDM_FLT1ICR_CLRCKABF                    \ CLRCKABF
$ff000000 constant DFSDM1_DFSDM_FLT1ICR_CLRSCDF                     \ CLRSCDF


\
\ @brief DFSDM filter 1 injected channel group selection register
\ Address offset: 0x190
\ Reset value: 0x00000001
\

$000000ff constant DFSDM1_DFSDM_FLT1JCHGR_JCHG                      \ JCHG


\
\ @brief DFSDM filter 1 control register
\ Address offset: 0x194
\ Reset value: 0x00000000
\

$000000ff constant DFSDM1_DFSDM_FLT1FCR_IOSR                        \ IOSR
$03ff0000 constant DFSDM1_DFSDM_FLT1FCR_FOSR                        \ FOSR
$e0000000 constant DFSDM1_DFSDM_FLT1FCR_FORD                        \ FORD


\
\ @brief DFSDM filter 1 data register for injected group
\ Address offset: 0x198
\ Reset value: 0x00000000
\

$00000007 constant DFSDM1_DFSDM_FLT1JDATAR_JDATACH                  \ JDATACH
$ffffff00 constant DFSDM1_DFSDM_FLT1JDATAR_JDATA                    \ JDATA


\
\ @brief DFSDM filter 1 data register for the regular channel
\ Address offset: 0x19C
\ Reset value: 0x00000000
\

$00000007 constant DFSDM1_DFSDM_FLT1RDATAR_RDATACH                  \ RDATACH
$00000010 constant DFSDM1_DFSDM_FLT1RDATAR_RPEND                    \ RPEND
$ffffff00 constant DFSDM1_DFSDM_FLT1RDATAR_RDATA                    \ RDATA


\
\ @brief DFSDM filter 1 analog watchdog high threshold register
\ Address offset: 0x1A0
\ Reset value: 0x00000000
\

$0000000f constant DFSDM1_DFSDM_FLT1AWHTR_BKAWH                     \ BKAWH
$ffffff00 constant DFSDM1_DFSDM_FLT1AWHTR_AWHT                      \ AWHT


\
\ @brief DFSDM filter 1 analog watchdog low threshold register
\ Address offset: 0x1A4
\ Reset value: 0x00000000
\

$0000000f constant DFSDM1_DFSDM_FLT1AWLTR_BKAWL                     \ BKAWL
$ffffff00 constant DFSDM1_DFSDM_FLT1AWLTR_AWLT                      \ AWLT


\
\ @brief DFSDM filter 1 analog watchdog status register
\ Address offset: 0x1A8
\ Reset value: 0x00000000
\

$000000ff constant DFSDM1_DFSDM_FLT1AWSR_AWLTF                      \ AWLTF
$0000ff00 constant DFSDM1_DFSDM_FLT1AWSR_AWHTF                      \ AWHTF


\
\ @brief DFSDM filter 1 analog watchdog clear flag register
\ Address offset: 0x1AC
\ Reset value: 0x00000000
\

$000000ff constant DFSDM1_DFSDM_FLT1AWCFR_CLRAWLTF                  \ CLRAWLTF
$0000ff00 constant DFSDM1_DFSDM_FLT1AWCFR_CLRAWHTF                  \ CLRAWHTF


\
\ @brief DFSDM filter 1 extremes detector maximum register
\ Address offset: 0x1B0
\ Reset value: 0x80000000
\

$00000007 constant DFSDM1_DFSDM_FLT1EXMAX_EXMAXCH                   \ EXMAXCH
$ffffff00 constant DFSDM1_DFSDM_FLT1EXMAX_EXMAX                     \ EXMAX


\
\ @brief DFSDM filter 1 extremes detector minimum register
\ Address offset: 0x1B4
\ Reset value: 0x7FFFFF00
\

$00000007 constant DFSDM1_DFSDM_FLT1EXMIN_EXMINCH                   \ EXMINCH
$ffffff00 constant DFSDM1_DFSDM_FLT1EXMIN_EXMIN                     \ EXMIN


\
\ @brief DFSDM filter 1 conversion timer register
\ Address offset: 0x1B8
\ Reset value: 0x00000000
\

$fffffff0 constant DFSDM1_DFSDM_FLT1CNVTIMR_CNVCNT                  \ CNVCNT


\
\ @brief DFSDM filter 2 control register 1
\ Address offset: 0x200
\ Reset value: 0x00000000
\

$00000001 constant DFSDM1_DFSDM_FLT2CR1_DFEN                        \ DFEN
$00000002 constant DFSDM1_DFSDM_FLT2CR1_JSWSTART                    \ JSWSTART
$00000008 constant DFSDM1_DFSDM_FLT2CR1_JSYNC                       \ JSYNC
$00000010 constant DFSDM1_DFSDM_FLT2CR1_JSCAN                       \ JSCAN
$00000020 constant DFSDM1_DFSDM_FLT2CR1_JDMAEN                      \ JDMAEN
$00001f00 constant DFSDM1_DFSDM_FLT2CR1_JEXTSEL                     \ JEXTSEL
$00006000 constant DFSDM1_DFSDM_FLT2CR1_JEXTEN                      \ JEXTEN
$00020000 constant DFSDM1_DFSDM_FLT2CR1_RSWSTART                    \ RSWSTART
$00040000 constant DFSDM1_DFSDM_FLT2CR1_RCONT                       \ RCONT
$00080000 constant DFSDM1_DFSDM_FLT2CR1_RSYNC                       \ RSYNC
$00200000 constant DFSDM1_DFSDM_FLT2CR1_RDMAEN                      \ RDMAEN
$07000000 constant DFSDM1_DFSDM_FLT2CR1_RCH                         \ RCH
$20000000 constant DFSDM1_DFSDM_FLT2CR1_FAST                        \ FAST
$40000000 constant DFSDM1_DFSDM_FLT2CR1_AWFSEL                      \ AWFSEL


\
\ @brief DFSDM filter 2 control register 2
\ Address offset: 0x204
\ Reset value: 0x00000000
\

$00000001 constant DFSDM1_DFSDM_FLT2CR2_JEOCIE                      \ JEOCIE
$00000002 constant DFSDM1_DFSDM_FLT2CR2_REOCIE                      \ REOCIE
$00000004 constant DFSDM1_DFSDM_FLT2CR2_JOVRIE                      \ JOVRIE
$00000008 constant DFSDM1_DFSDM_FLT2CR2_ROVRIE                      \ ROVRIE
$00000010 constant DFSDM1_DFSDM_FLT2CR2_AWDIE                       \ AWDIE
$00000020 constant DFSDM1_DFSDM_FLT2CR2_SCDIE                       \ SCDIE
$00000040 constant DFSDM1_DFSDM_FLT2CR2_CKABIE                      \ CKABIE
$0000ff00 constant DFSDM1_DFSDM_FLT2CR2_EXCH                        \ EXCH
$00ff0000 constant DFSDM1_DFSDM_FLT2CR2_AWDCH                       \ AWDCH


\
\ @brief DFSDM filter 2 interrupt and status register
\ Address offset: 0x208
\ Reset value: 0x00FF0000
\

$00000001 constant DFSDM1_DFSDM_FLT2ISR_JEOCF                       \ JEOCF
$00000002 constant DFSDM1_DFSDM_FLT2ISR_REOCF                       \ REOCF
$00000004 constant DFSDM1_DFSDM_FLT2ISR_JOVRF                       \ JOVRF
$00000008 constant DFSDM1_DFSDM_FLT2ISR_ROVRF                       \ ROVRF
$00000010 constant DFSDM1_DFSDM_FLT2ISR_AWDF                        \ AWDF
$00002000 constant DFSDM1_DFSDM_FLT2ISR_JCIP                        \ JCIP
$00004000 constant DFSDM1_DFSDM_FLT2ISR_RCIP                        \ RCIP
$00ff0000 constant DFSDM1_DFSDM_FLT2ISR_CKABF                       \ CKABF
$ff000000 constant DFSDM1_DFSDM_FLT2ISR_SCDF                        \ SCDF


\
\ @brief DFSDM filter 2 interrupt flag clear register
\ Address offset: 0x20C
\ Reset value: 0x00000000
\

$00000004 constant DFSDM1_DFSDM_FLT2ICR_CLRJOVRF                    \ CLRJOVRF
$00000008 constant DFSDM1_DFSDM_FLT2ICR_CLRROVRF                    \ CLRROVRF
$00ff0000 constant DFSDM1_DFSDM_FLT2ICR_CLRCKABF                    \ CLRCKABF
$ff000000 constant DFSDM1_DFSDM_FLT2ICR_CLRSCDF                     \ CLRSCDF


\
\ @brief DFSDM filter 2 injected channel group selection register
\ Address offset: 0x210
\ Reset value: 0x00000001
\

$000000ff constant DFSDM1_DFSDM_FLT2JCHGR_JCHG                      \ JCHG


\
\ @brief DFSDM filter 2 control register
\ Address offset: 0x214
\ Reset value: 0x00000000
\

$000000ff constant DFSDM1_DFSDM_FLT2FCR_IOSR                        \ IOSR
$03ff0000 constant DFSDM1_DFSDM_FLT2FCR_FOSR                        \ FOSR
$e0000000 constant DFSDM1_DFSDM_FLT2FCR_FORD                        \ FORD


\
\ @brief DFSDM filter 2 data register for injected group
\ Address offset: 0x218
\ Reset value: 0x00000000
\

$00000007 constant DFSDM1_DFSDM_FLT2JDATAR_JDATACH                  \ JDATACH
$ffffff00 constant DFSDM1_DFSDM_FLT2JDATAR_JDATA                    \ JDATA


\
\ @brief DFSDM filter 2 data register for the regular channel
\ Address offset: 0x21C
\ Reset value: 0x00000000
\

$00000007 constant DFSDM1_DFSDM_FLT2RDATAR_RDATACH                  \ RDATACH
$00000010 constant DFSDM1_DFSDM_FLT2RDATAR_RPEND                    \ RPEND
$ffffff00 constant DFSDM1_DFSDM_FLT2RDATAR_RDATA                    \ RDATA


\
\ @brief DFSDM filter 2 analog watchdog high threshold register
\ Address offset: 0x220
\ Reset value: 0x00000000
\

$0000000f constant DFSDM1_DFSDM_FLT2AWHTR_BKAWH                     \ BKAWH
$ffffff00 constant DFSDM1_DFSDM_FLT2AWHTR_AWHT                      \ AWHT


\
\ @brief DFSDM filter 2 analog watchdog low threshold register
\ Address offset: 0x224
\ Reset value: 0x00000000
\

$0000000f constant DFSDM1_DFSDM_FLT2AWLTR_BKAWL                     \ BKAWL
$ffffff00 constant DFSDM1_DFSDM_FLT2AWLTR_AWLT                      \ AWLT


\
\ @brief DFSDM filter 2 analog watchdog status register
\ Address offset: 0x228
\ Reset value: 0x00000000
\

$000000ff constant DFSDM1_DFSDM_FLT2AWSR_AWLTF                      \ AWLTF
$0000ff00 constant DFSDM1_DFSDM_FLT2AWSR_AWHTF                      \ AWHTF


\
\ @brief DFSDM filter 2 analog watchdog clear flag register
\ Address offset: 0x22C
\ Reset value: 0x00000000
\

$000000ff constant DFSDM1_DFSDM_FLT2AWCFR_CLRAWLTF                  \ CLRAWLTF
$0000ff00 constant DFSDM1_DFSDM_FLT2AWCFR_CLRAWHTF                  \ CLRAWHTF


\
\ @brief DFSDM filter 2 extremes detector maximum register
\ Address offset: 0x230
\ Reset value: 0x80000000
\

$00000007 constant DFSDM1_DFSDM_FLT2EXMAX_EXMAXCH                   \ EXMAXCH
$ffffff00 constant DFSDM1_DFSDM_FLT2EXMAX_EXMAX                     \ EXMAX


\
\ @brief DFSDM filter 2 extremes detector minimum register
\ Address offset: 0x234
\ Reset value: 0x7FFFFF00
\

$00000007 constant DFSDM1_DFSDM_FLT2EXMIN_EXMINCH                   \ EXMINCH
$ffffff00 constant DFSDM1_DFSDM_FLT2EXMIN_EXMIN                     \ EXMIN


\
\ @brief DFSDM filter 2 conversion timer register
\ Address offset: 0x238
\ Reset value: 0x00000000
\

$fffffff0 constant DFSDM1_DFSDM_FLT2CNVTIMR_CNVCNT                  \ CNVCNT


\
\ @brief DFSDM filter 3 control register 1
\ Address offset: 0x280
\ Reset value: 0x00000000
\

$00000001 constant DFSDM1_DFSDM_FLT3CR1_DFEN                        \ DFEN
$00000002 constant DFSDM1_DFSDM_FLT3CR1_JSWSTART                    \ JSWSTART
$00000008 constant DFSDM1_DFSDM_FLT3CR1_JSYNC                       \ JSYNC
$00000010 constant DFSDM1_DFSDM_FLT3CR1_JSCAN                       \ JSCAN
$00000020 constant DFSDM1_DFSDM_FLT3CR1_JDMAEN                      \ JDMAEN
$00001f00 constant DFSDM1_DFSDM_FLT3CR1_JEXTSEL                     \ JEXTSEL
$00006000 constant DFSDM1_DFSDM_FLT3CR1_JEXTEN                      \ JEXTEN
$00020000 constant DFSDM1_DFSDM_FLT3CR1_RSWSTART                    \ RSWSTART
$00040000 constant DFSDM1_DFSDM_FLT3CR1_RCONT                       \ RCONT
$00080000 constant DFSDM1_DFSDM_FLT3CR1_RSYNC                       \ RSYNC
$00200000 constant DFSDM1_DFSDM_FLT3CR1_RDMAEN                      \ RDMAEN
$07000000 constant DFSDM1_DFSDM_FLT3CR1_RCH                         \ RCH
$20000000 constant DFSDM1_DFSDM_FLT3CR1_FAST                        \ FAST
$40000000 constant DFSDM1_DFSDM_FLT3CR1_AWFSEL                      \ AWFSEL


\
\ @brief DFSDM filter 3 control register 2
\ Address offset: 0x284
\ Reset value: 0x00000000
\

$00000001 constant DFSDM1_DFSDM_FLT3CR2_JEOCIE                      \ JEOCIE
$00000002 constant DFSDM1_DFSDM_FLT3CR2_REOCIE                      \ REOCIE
$00000004 constant DFSDM1_DFSDM_FLT3CR2_JOVRIE                      \ JOVRIE
$00000008 constant DFSDM1_DFSDM_FLT3CR2_ROVRIE                      \ ROVRIE
$00000010 constant DFSDM1_DFSDM_FLT3CR2_AWDIE                       \ AWDIE
$00000020 constant DFSDM1_DFSDM_FLT3CR2_SCDIE                       \ SCDIE
$00000040 constant DFSDM1_DFSDM_FLT3CR2_CKABIE                      \ CKABIE
$0000ff00 constant DFSDM1_DFSDM_FLT3CR2_EXCH                        \ EXCH
$00ff0000 constant DFSDM1_DFSDM_FLT3CR2_AWDCH                       \ AWDCH


\
\ @brief DFSDM filter 3 interrupt and status register
\ Address offset: 0x288
\ Reset value: 0x00FF0000
\

$00000001 constant DFSDM1_DFSDM_FLT3ISR_JEOCF                       \ JEOCF
$00000002 constant DFSDM1_DFSDM_FLT3ISR_REOCF                       \ REOCF
$00000004 constant DFSDM1_DFSDM_FLT3ISR_JOVRF                       \ JOVRF
$00000008 constant DFSDM1_DFSDM_FLT3ISR_ROVRF                       \ ROVRF
$00000010 constant DFSDM1_DFSDM_FLT3ISR_AWDF                        \ AWDF
$00002000 constant DFSDM1_DFSDM_FLT3ISR_JCIP                        \ JCIP
$00004000 constant DFSDM1_DFSDM_FLT3ISR_RCIP                        \ RCIP
$00ff0000 constant DFSDM1_DFSDM_FLT3ISR_CKABF                       \ CKABF
$ff000000 constant DFSDM1_DFSDM_FLT3ISR_SCDF                        \ SCDF


\
\ @brief DFSDM filter 3 interrupt flag clear register
\ Address offset: 0x28C
\ Reset value: 0x00000000
\

$00000004 constant DFSDM1_DFSDM_FLT3ICR_CLRJOVRF                    \ CLRJOVRF
$00000008 constant DFSDM1_DFSDM_FLT3ICR_CLRROVRF                    \ CLRROVRF
$00ff0000 constant DFSDM1_DFSDM_FLT3ICR_CLRCKABF                    \ CLRCKABF
$ff000000 constant DFSDM1_DFSDM_FLT3ICR_CLRSCDF                     \ CLRSCDF


\
\ @brief DFSDM filter 3 injected channel group selection register
\ Address offset: 0x290
\ Reset value: 0x00000001
\

$000000ff constant DFSDM1_DFSDM_FLT3JCHGR_JCHG                      \ JCHG


\
\ @brief DFSDM filter 3 control register
\ Address offset: 0x294
\ Reset value: 0x00000000
\

$000000ff constant DFSDM1_DFSDM_FLT3FCR_IOSR                        \ IOSR
$03ff0000 constant DFSDM1_DFSDM_FLT3FCR_FOSR                        \ FOSR
$e0000000 constant DFSDM1_DFSDM_FLT3FCR_FORD                        \ FORD


\
\ @brief DFSDM filter 3 data register for injected group
\ Address offset: 0x298
\ Reset value: 0x00000000
\

$00000007 constant DFSDM1_DFSDM_FLT3JDATAR_JDATACH                  \ JDATACH
$ffffff00 constant DFSDM1_DFSDM_FLT3JDATAR_JDATA                    \ JDATA


\
\ @brief DFSDM filter 3 data register for the regular channel
\ Address offset: 0x29C
\ Reset value: 0x00000000
\

$00000007 constant DFSDM1_DFSDM_FLT3RDATAR_RDATACH                  \ RDATACH
$00000010 constant DFSDM1_DFSDM_FLT3RDATAR_RPEND                    \ RPEND
$ffffff00 constant DFSDM1_DFSDM_FLT3RDATAR_RDATA                    \ RDATA


\
\ @brief DFSDM filter 3 analog watchdog high threshold register
\ Address offset: 0x2A0
\ Reset value: 0x00000000
\

$0000000f constant DFSDM1_DFSDM_FLT3AWHTR_BKAWH                     \ BKAWH
$ffffff00 constant DFSDM1_DFSDM_FLT3AWHTR_AWHT                      \ AWHT


\
\ @brief DFSDM filter 3 analog watchdog low threshold register
\ Address offset: 0x2A4
\ Reset value: 0x00000000
\

$0000000f constant DFSDM1_DFSDM_FLT3AWLTR_BKAWL                     \ BKAWL
$ffffff00 constant DFSDM1_DFSDM_FLT3AWLTR_AWLT                      \ AWLT


\
\ @brief DFSDM filter 3 analog watchdog status register
\ Address offset: 0x2A8
\ Reset value: 0x00000000
\

$000000ff constant DFSDM1_DFSDM_FLT3AWSR_AWLTF                      \ AWLTF
$0000ff00 constant DFSDM1_DFSDM_FLT3AWSR_AWHTF                      \ AWHTF


\
\ @brief DFSDM filter 3 analog watchdog clear flag register
\ Address offset: 0x2AC
\ Reset value: 0x00000000
\

$000000ff constant DFSDM1_DFSDM_FLT3AWCFR_CLRAWLTF                  \ CLRAWLTF
$0000ff00 constant DFSDM1_DFSDM_FLT3AWCFR_CLRAWHTF                  \ CLRAWHTF


\
\ @brief DFSDM filter 3 extremes detector maximum register
\ Address offset: 0x2B0
\ Reset value: 0x80000000
\

$00000007 constant DFSDM1_DFSDM_FLT3EXMAX_EXMAXCH                   \ EXMAXCH
$ffffff00 constant DFSDM1_DFSDM_FLT3EXMAX_EXMAX                     \ EXMAX


\
\ @brief DFSDM filter 3 extremes detector minimum register
\ Address offset: 0x2B4
\ Reset value: 0x7FFFFF00
\

$00000007 constant DFSDM1_DFSDM_FLT3EXMIN_EXMINCH                   \ EXMINCH
$ffffff00 constant DFSDM1_DFSDM_FLT3EXMIN_EXMIN                     \ EXMIN


\
\ @brief DFSDM filter 3 conversion timer register
\ Address offset: 0x2B8
\ Reset value: 0x00000000
\

$fffffff0 constant DFSDM1_DFSDM_FLT3CNVTIMR_CNVCNT                  \ CNVCNT


\
\ @brief DFSDM filter 4 control register 1
\ Address offset: 0x300
\ Reset value: 0x00000000
\

$00000001 constant DFSDM1_DFSDM_FLT4CR1_DFEN                        \ DFEN
$00000002 constant DFSDM1_DFSDM_FLT4CR1_JSWSTART                    \ JSWSTART
$00000008 constant DFSDM1_DFSDM_FLT4CR1_JSYNC                       \ JSYNC
$00000010 constant DFSDM1_DFSDM_FLT4CR1_JSCAN                       \ JSCAN
$00000020 constant DFSDM1_DFSDM_FLT4CR1_JDMAEN                      \ JDMAEN
$00001f00 constant DFSDM1_DFSDM_FLT4CR1_JEXTSEL                     \ JEXTSEL
$00006000 constant DFSDM1_DFSDM_FLT4CR1_JEXTEN                      \ JEXTEN
$00020000 constant DFSDM1_DFSDM_FLT4CR1_RSWSTART                    \ RSWSTART
$00040000 constant DFSDM1_DFSDM_FLT4CR1_RCONT                       \ RCONT
$00080000 constant DFSDM1_DFSDM_FLT4CR1_RSYNC                       \ RSYNC
$00200000 constant DFSDM1_DFSDM_FLT4CR1_RDMAEN                      \ RDMAEN
$07000000 constant DFSDM1_DFSDM_FLT4CR1_RCH                         \ RCH
$20000000 constant DFSDM1_DFSDM_FLT4CR1_FAST                        \ FAST
$40000000 constant DFSDM1_DFSDM_FLT4CR1_AWFSEL                      \ AWFSEL


\
\ @brief DFSDM filter 4 control register 2
\ Address offset: 0x304
\ Reset value: 0x00000000
\

$00000001 constant DFSDM1_DFSDM_FLT4CR2_JEOCIE                      \ JEOCIE
$00000002 constant DFSDM1_DFSDM_FLT4CR2_REOCIE                      \ REOCIE
$00000004 constant DFSDM1_DFSDM_FLT4CR2_JOVRIE                      \ JOVRIE
$00000008 constant DFSDM1_DFSDM_FLT4CR2_ROVRIE                      \ ROVRIE
$00000010 constant DFSDM1_DFSDM_FLT4CR2_AWDIE                       \ AWDIE
$00000020 constant DFSDM1_DFSDM_FLT4CR2_SCDIE                       \ SCDIE
$00000040 constant DFSDM1_DFSDM_FLT4CR2_CKABIE                      \ CKABIE
$0000ff00 constant DFSDM1_DFSDM_FLT4CR2_EXCH                        \ EXCH
$00ff0000 constant DFSDM1_DFSDM_FLT4CR2_AWDCH                       \ AWDCH


\
\ @brief DFSDM filter 4 interrupt and status register
\ Address offset: 0x308
\ Reset value: 0x00FF0000
\

$00000001 constant DFSDM1_DFSDM_FLT4ISR_JEOCF                       \ JEOCF
$00000002 constant DFSDM1_DFSDM_FLT4ISR_REOCF                       \ REOCF
$00000004 constant DFSDM1_DFSDM_FLT4ISR_JOVRF                       \ JOVRF
$00000008 constant DFSDM1_DFSDM_FLT4ISR_ROVRF                       \ ROVRF
$00000010 constant DFSDM1_DFSDM_FLT4ISR_AWDF                        \ AWDF
$00002000 constant DFSDM1_DFSDM_FLT4ISR_JCIP                        \ JCIP
$00004000 constant DFSDM1_DFSDM_FLT4ISR_RCIP                        \ RCIP
$00ff0000 constant DFSDM1_DFSDM_FLT4ISR_CKABF                       \ CKABF
$ff000000 constant DFSDM1_DFSDM_FLT4ISR_SCDF                        \ SCDF


\
\ @brief DFSDM filter 4 interrupt flag clear register
\ Address offset: 0x30C
\ Reset value: 0x00000000
\

$00000004 constant DFSDM1_DFSDM_FLT4ICR_CLRJOVRF                    \ CLRJOVRF
$00000008 constant DFSDM1_DFSDM_FLT4ICR_CLRROVRF                    \ CLRROVRF
$00ff0000 constant DFSDM1_DFSDM_FLT4ICR_CLRCKABF                    \ CLRCKABF
$ff000000 constant DFSDM1_DFSDM_FLT4ICR_CLRSCDF                     \ CLRSCDF


\
\ @brief DFSDM filter 4 injected channel group selection register
\ Address offset: 0x310
\ Reset value: 0x00000001
\

$000000ff constant DFSDM1_DFSDM_FLT4JCHGR_JCHG                      \ JCHG


\
\ @brief DFSDM filter 4 control register
\ Address offset: 0x314
\ Reset value: 0x00000000
\

$000000ff constant DFSDM1_DFSDM_FLT4FCR_IOSR                        \ IOSR
$03ff0000 constant DFSDM1_DFSDM_FLT4FCR_FOSR                        \ FOSR
$e0000000 constant DFSDM1_DFSDM_FLT4FCR_FORD                        \ FORD


\
\ @brief DFSDM filter 4 data register for injected group
\ Address offset: 0x318
\ Reset value: 0x00000000
\

$00000007 constant DFSDM1_DFSDM_FLT4JDATAR_JDATACH                  \ JDATACH
$ffffff00 constant DFSDM1_DFSDM_FLT4JDATAR_JDATA                    \ JDATA


\
\ @brief DFSDM filter 4 data register for the regular channel
\ Address offset: 0x31C
\ Reset value: 0x00000000
\

$00000007 constant DFSDM1_DFSDM_FLT4RDATAR_RDATACH                  \ RDATACH
$00000010 constant DFSDM1_DFSDM_FLT4RDATAR_RPEND                    \ RPEND
$ffffff00 constant DFSDM1_DFSDM_FLT4RDATAR_RDATA                    \ RDATA


\
\ @brief DFSDM filter 4 analog watchdog high threshold register
\ Address offset: 0x320
\ Reset value: 0x00000000
\

$0000000f constant DFSDM1_DFSDM_FLT4AWHTR_BKAWH                     \ BKAWH
$ffffff00 constant DFSDM1_DFSDM_FLT4AWHTR_AWHT                      \ AWHT


\
\ @brief DFSDM filter 4 analog watchdog low threshold register
\ Address offset: 0x324
\ Reset value: 0x00000000
\

$0000000f constant DFSDM1_DFSDM_FLT4AWLTR_BKAWL                     \ BKAWL
$ffffff00 constant DFSDM1_DFSDM_FLT4AWLTR_AWLT                      \ AWLT


\
\ @brief DFSDM filter 4 analog watchdog status register
\ Address offset: 0x328
\ Reset value: 0x00000000
\

$000000ff constant DFSDM1_DFSDM_FLT4AWSR_AWLTF                      \ AWLTF
$0000ff00 constant DFSDM1_DFSDM_FLT4AWSR_AWHTF                      \ AWHTF


\
\ @brief DFSDM filter 4 analog watchdog clear flag register
\ Address offset: 0x32C
\ Reset value: 0x00000000
\

$000000ff constant DFSDM1_DFSDM_FLT4AWCFR_CLRAWLTF                  \ CLRAWLTF
$0000ff00 constant DFSDM1_DFSDM_FLT4AWCFR_CLRAWHTF                  \ CLRAWHTF


\
\ @brief DFSDM filter 4 extremes detector maximum register
\ Address offset: 0x330
\ Reset value: 0x80000000
\

$00000007 constant DFSDM1_DFSDM_FLT4EXMAX_EXMAXCH                   \ EXMAXCH
$ffffff00 constant DFSDM1_DFSDM_FLT4EXMAX_EXMAX                     \ EXMAX


\
\ @brief DFSDM filter 4 extremes detector minimum register
\ Address offset: 0x334
\ Reset value: 0x7FFFFF00
\

$00000007 constant DFSDM1_DFSDM_FLT4EXMIN_EXMINCH                   \ EXMINCH
$ffffff00 constant DFSDM1_DFSDM_FLT4EXMIN_EXMIN                     \ EXMIN


\
\ @brief DFSDM filter 4 conversion timer register
\ Address offset: 0x338
\ Reset value: 0x00000000
\

$fffffff0 constant DFSDM1_DFSDM_FLT4CNVTIMR_CNVCNT                  \ CNVCNT


\
\ @brief DFSDM filter 5 control register 1
\ Address offset: 0x380
\ Reset value: 0x00000000
\

$00000001 constant DFSDM1_DFSDM_FLT5CR1_DFEN                        \ DFEN
$00000002 constant DFSDM1_DFSDM_FLT5CR1_JSWSTART                    \ JSWSTART
$00000008 constant DFSDM1_DFSDM_FLT5CR1_JSYNC                       \ JSYNC
$00000010 constant DFSDM1_DFSDM_FLT5CR1_JSCAN                       \ JSCAN
$00000020 constant DFSDM1_DFSDM_FLT5CR1_JDMAEN                      \ JDMAEN
$00001f00 constant DFSDM1_DFSDM_FLT5CR1_JEXTSEL                     \ JEXTSEL
$00006000 constant DFSDM1_DFSDM_FLT5CR1_JEXTEN                      \ JEXTEN
$00020000 constant DFSDM1_DFSDM_FLT5CR1_RSWSTART                    \ RSWSTART
$00040000 constant DFSDM1_DFSDM_FLT5CR1_RCONT                       \ RCONT
$00080000 constant DFSDM1_DFSDM_FLT5CR1_RSYNC                       \ RSYNC
$00200000 constant DFSDM1_DFSDM_FLT5CR1_RDMAEN                      \ RDMAEN
$07000000 constant DFSDM1_DFSDM_FLT5CR1_RCH                         \ RCH
$20000000 constant DFSDM1_DFSDM_FLT5CR1_FAST                        \ FAST
$40000000 constant DFSDM1_DFSDM_FLT5CR1_AWFSEL                      \ AWFSEL


\
\ @brief DFSDM filter 5 control register 2
\ Address offset: 0x384
\ Reset value: 0x00000000
\

$00000001 constant DFSDM1_DFSDM_FLT5CR2_JEOCIE                      \ JEOCIE
$00000002 constant DFSDM1_DFSDM_FLT5CR2_REOCIE                      \ REOCIE
$00000004 constant DFSDM1_DFSDM_FLT5CR2_JOVRIE                      \ JOVRIE
$00000008 constant DFSDM1_DFSDM_FLT5CR2_ROVRIE                      \ ROVRIE
$00000010 constant DFSDM1_DFSDM_FLT5CR2_AWDIE                       \ AWDIE
$00000020 constant DFSDM1_DFSDM_FLT5CR2_SCDIE                       \ SCDIE
$00000040 constant DFSDM1_DFSDM_FLT5CR2_CKABIE                      \ CKABIE
$0000ff00 constant DFSDM1_DFSDM_FLT5CR2_EXCH                        \ EXCH
$00ff0000 constant DFSDM1_DFSDM_FLT5CR2_AWDCH                       \ AWDCH


\
\ @brief DFSDM filter 5 interrupt and status register
\ Address offset: 0x388
\ Reset value: 0x00FF0000
\

$00000001 constant DFSDM1_DFSDM_FLT5ISR_JEOCF                       \ JEOCF
$00000002 constant DFSDM1_DFSDM_FLT5ISR_REOCF                       \ REOCF
$00000004 constant DFSDM1_DFSDM_FLT5ISR_JOVRF                       \ JOVRF
$00000008 constant DFSDM1_DFSDM_FLT5ISR_ROVRF                       \ ROVRF
$00000010 constant DFSDM1_DFSDM_FLT5ISR_AWDF                        \ AWDF
$00002000 constant DFSDM1_DFSDM_FLT5ISR_JCIP                        \ JCIP
$00004000 constant DFSDM1_DFSDM_FLT5ISR_RCIP                        \ RCIP
$00ff0000 constant DFSDM1_DFSDM_FLT5ISR_CKABF                       \ CKABF
$ff000000 constant DFSDM1_DFSDM_FLT5ISR_SCDF                        \ SCDF


\
\ @brief DFSDM filter 5 interrupt flag clear register
\ Address offset: 0x38C
\ Reset value: 0x00000000
\

$00000004 constant DFSDM1_DFSDM_FLT5ICR_CLRJOVRF                    \ CLRJOVRF
$00000008 constant DFSDM1_DFSDM_FLT5ICR_CLRROVRF                    \ CLRROVRF
$00ff0000 constant DFSDM1_DFSDM_FLT5ICR_CLRCKABF                    \ CLRCKABF
$ff000000 constant DFSDM1_DFSDM_FLT5ICR_CLRSCDF                     \ CLRSCDF


\
\ @brief DFSDM filter 5 injected channel group selection register
\ Address offset: 0x390
\ Reset value: 0x00000001
\

$000000ff constant DFSDM1_DFSDM_FLT5JCHGR_JCHG                      \ JCHG


\
\ @brief DFSDM filter 5 control register
\ Address offset: 0x394
\ Reset value: 0x00000000
\

$000000ff constant DFSDM1_DFSDM_FLT5FCR_IOSR                        \ IOSR
$03ff0000 constant DFSDM1_DFSDM_FLT5FCR_FOSR                        \ FOSR
$e0000000 constant DFSDM1_DFSDM_FLT5FCR_FORD                        \ FORD


\
\ @brief DFSDM filter 5 data register for injected group
\ Address offset: 0x398
\ Reset value: 0x00000000
\

$00000007 constant DFSDM1_DFSDM_FLT5JDATAR_JDATACH                  \ JDATACH
$ffffff00 constant DFSDM1_DFSDM_FLT5JDATAR_JDATA                    \ JDATA


\
\ @brief DFSDM filter 5 data register for the regular channel
\ Address offset: 0x39C
\ Reset value: 0x00000000
\

$00000007 constant DFSDM1_DFSDM_FLT5RDATAR_RDATACH                  \ RDATACH
$00000010 constant DFSDM1_DFSDM_FLT5RDATAR_RPEND                    \ RPEND
$ffffff00 constant DFSDM1_DFSDM_FLT5RDATAR_RDATA                    \ RDATA


\
\ @brief DFSDM filter 5 analog watchdog high threshold register
\ Address offset: 0x3A0
\ Reset value: 0x00000000
\

$0000000f constant DFSDM1_DFSDM_FLT5AWHTR_BKAWH                     \ BKAWH
$ffffff00 constant DFSDM1_DFSDM_FLT5AWHTR_AWHT                      \ AWHT


\
\ @brief DFSDM filter 5 analog watchdog low threshold register
\ Address offset: 0x3A4
\ Reset value: 0x00000000
\

$0000000f constant DFSDM1_DFSDM_FLT5AWLTR_BKAWL                     \ BKAWL
$ffffff00 constant DFSDM1_DFSDM_FLT5AWLTR_AWLT                      \ AWLT


\
\ @brief DFSDM filter 5 analog watchdog status register
\ Address offset: 0x3A8
\ Reset value: 0x00000000
\

$000000ff constant DFSDM1_DFSDM_FLT5AWSR_AWLTF                      \ AWLTF
$0000ff00 constant DFSDM1_DFSDM_FLT5AWSR_AWHTF                      \ AWHTF


\
\ @brief DFSDM filter 5 analog watchdog clear flag register
\ Address offset: 0x3AC
\ Reset value: 0x00000000
\

$000000ff constant DFSDM1_DFSDM_FLT5AWCFR_CLRAWLTF                  \ CLRAWLTF
$0000ff00 constant DFSDM1_DFSDM_FLT5AWCFR_CLRAWHTF                  \ CLRAWHTF


\
\ @brief DFSDM filter 5 extremes detector maximum register
\ Address offset: 0x3B0
\ Reset value: 0x80000000
\

$00000007 constant DFSDM1_DFSDM_FLT5EXMAX_EXMAXCH                   \ EXMAXCH
$ffffff00 constant DFSDM1_DFSDM_FLT5EXMAX_EXMAX                     \ EXMAX


\
\ @brief DFSDM filter 5 extremes detector minimum register
\ Address offset: 0x3B4
\ Reset value: 0x7FFFFF00
\

$00000007 constant DFSDM1_DFSDM_FLT5EXMIN_EXMINCH                   \ EXMINCH
$ffffff00 constant DFSDM1_DFSDM_FLT5EXMIN_EXMIN                     \ EXMIN


\
\ @brief DFSDM filter 5 conversion timer register
\ Address offset: 0x3B8
\ Reset value: 0x00000000
\

$fffffff0 constant DFSDM1_DFSDM_FLT5CNVTIMR_CNVCNT                  \ CNVCNT


\
\ @brief This register specifies the hardware configuration of DFSDM peripheral.
\ Address offset: 0x7F0
\ Reset value: 0x00000608
\

$000000ff constant DFSDM1_DFSDM_HWCFGR_NBT                          \ NBT
$0000ff00 constant DFSDM1_DFSDM_HWCFGR_NBF                          \ NBF


\
\ @brief This register specifies the version of DFSDM peripheral.
\ Address offset: 0x7F4
\ Reset value: 0x00000021
\

$0000000f constant DFSDM1_DFSDM_VERR_MINREV                         \ MINREV
$000000f0 constant DFSDM1_DFSDM_VERR_MAJREV                         \ MAJREV


\
\ @brief This register specifies the identification of DFSDM peripheral.
\ Address offset: 0x7F8
\ Reset value: 0x00110031
\

$00000000 constant DFSDM1_DFSDM_IPIDR_ID                            \ ID


\
\ @brief This register specifies the size allocated to DFSDM registers.
\ Address offset: 0x7FC
\ Reset value: 0xA3C5DD02
\

$00000000 constant DFSDM1_DFSDM_SIDR_SID                            \ SID


\
\ @brief DFSDM1
\
$4400d000 constant DFSDM1_DFSDM_CH0CFGR1  \ offset: 0x00 : This register specifies the parameters used by channel y.
$4400d004 constant DFSDM1_DFSDM_CH0CFGR2  \ offset: 0x04 : This register specifies the parameters used by channel y.
$4400d008 constant DFSDM1_DFSDM_CH0AWSCDR  \ offset: 0x08 : Short-circuit detector and analog watchdog settings for channel y.
$4400d00c constant DFSDM1_DFSDM_CH0WDATR  \ offset: 0x0C : This register contains the data resulting from the analog watchdog filter associated to the input channel y.
$4400d010 constant DFSDM1_DFSDM_CH0DATINR  \ offset: 0x10 : This register contains 16-bit input data to be processed by DFSDM filter module.
$4400d014 constant DFSDM1_DFSDM_CH0DLYR  \ offset: 0x14 : DFSDM channel 0 delay register
$4400d020 constant DFSDM1_DFSDM_CH1CFGR1  \ offset: 0x20 : This register specifies the parameters used by channel y.
$4400d024 constant DFSDM1_DFSDM_CH1CFGR2  \ offset: 0x24 : This register specifies the parameters used by channel y.
$4400d028 constant DFSDM1_DFSDM_CH1AWSCDR  \ offset: 0x28 : Short-circuit detector and analog watchdog settings for channel y.
$4400d02c constant DFSDM1_DFSDM_CH1WDATR  \ offset: 0x2C : This register contains the data resulting from the analog watchdog filter associated to the input channel y.
$4400d030 constant DFSDM1_DFSDM_CH1DATINR  \ offset: 0x30 : This register contains 16-bit input data to be processed by DFSDM filter module.
$4400d034 constant DFSDM1_DFSDM_CH1DLYR  \ offset: 0x34 : DFSDM channel 1 delay register
$4400d040 constant DFSDM1_DFSDM_CH2CFGR1  \ offset: 0x40 : This register specifies the parameters used by channel y.
$4400d044 constant DFSDM1_DFSDM_CH2CFGR2  \ offset: 0x44 : This register specifies the parameters used by channel y.
$4400d048 constant DFSDM1_DFSDM_CH2AWSCDR  \ offset: 0x48 : Short-circuit detector and analog watchdog settings for channel y.
$4400d04c constant DFSDM1_DFSDM_CH2WDATR  \ offset: 0x4C : This register contains the data resulting from the analog watchdog filter associated to the input channel y.
$4400d050 constant DFSDM1_DFSDM_CH2DATINR  \ offset: 0x50 : This register contains 16-bit input data to be processed by DFSDM filter module.
$4400d054 constant DFSDM1_DFSDM_CH2DLYR  \ offset: 0x54 : DFSDM channel 2 delay register
$4400d060 constant DFSDM1_DFSDM_CH3CFGR1  \ offset: 0x60 : This register specifies the parameters used by channel y.
$4400d064 constant DFSDM1_DFSDM_CH3CFGR2  \ offset: 0x64 : This register specifies the parameters used by channel y.
$4400d068 constant DFSDM1_DFSDM_CH3AWSCDR  \ offset: 0x68 : Short-circuit detector and analog watchdog settings for channel y.
$4400d06c constant DFSDM1_DFSDM_CH3WDATR  \ offset: 0x6C : This register contains the data resulting from the analog watchdog filter associated to the input channel y.
$4400d070 constant DFSDM1_DFSDM_CH3DATINR  \ offset: 0x70 : This register contains 16-bit input data to be processed by DFSDM filter module.
$4400d074 constant DFSDM1_DFSDM_CH3DLYR  \ offset: 0x74 : DFSDM channel 3 delay register
$4400d080 constant DFSDM1_DFSDM_CH4CFGR1  \ offset: 0x80 : This register specifies the parameters used by channel y.
$4400d084 constant DFSDM1_DFSDM_CH4CFGR2  \ offset: 0x84 : This register specifies the parameters used by channel y.
$4400d088 constant DFSDM1_DFSDM_CH4AWSCDR  \ offset: 0x88 : Short-circuit detector and analog watchdog settings for channel y.
$4400d08c constant DFSDM1_DFSDM_CH4WDATR  \ offset: 0x8C : This register contains the data resulting from the analog watchdog filter associated to the input channel y.
$4400d090 constant DFSDM1_DFSDM_CH4DATINR  \ offset: 0x90 : This register contains 16-bit input data to be processed by DFSDM filter module.
$4400d094 constant DFSDM1_DFSDM_CH4DLYR  \ offset: 0x94 : DFSDM channel 4 delay register
$4400d0a0 constant DFSDM1_DFSDM_CH5CFGR1  \ offset: 0xA0 : This register specifies the parameters used by channel y.
$4400d0a4 constant DFSDM1_DFSDM_CH5CFGR2  \ offset: 0xA4 : This register specifies the parameters used by channel y.
$4400d0a8 constant DFSDM1_DFSDM_CH5AWSCDR  \ offset: 0xA8 : Short-circuit detector and analog watchdog settings for channel y.
$4400d0ac constant DFSDM1_DFSDM_CH5WDATR  \ offset: 0xAC : This register contains the data resulting from the analog watchdog filter associated to the input channel y.
$4400d0b0 constant DFSDM1_DFSDM_CH5DATINR  \ offset: 0xB0 : This register contains 16-bit input data to be processed by DFSDM filter module.
$4400d0b4 constant DFSDM1_DFSDM_CH5DLYR  \ offset: 0xB4 : DFSDM channel 5 delay register
$4400d0c0 constant DFSDM1_DFSDM_CH6CFGR1  \ offset: 0xC0 : This register specifies the parameters used by channel y.
$4400d0c4 constant DFSDM1_DFSDM_CH6CFGR2  \ offset: 0xC4 : This register specifies the parameters used by channel y.
$4400d0c8 constant DFSDM1_DFSDM_CH6AWSCDR  \ offset: 0xC8 : Short-circuit detector and analog watchdog settings for channel y.
$4400d0cc constant DFSDM1_DFSDM_CH6WDATR  \ offset: 0xCC : This register contains the data resulting from the analog watchdog filter associated to the input channel y.
$4400d0d0 constant DFSDM1_DFSDM_CH6DATINR  \ offset: 0xD0 : This register contains 16-bit input data to be processed by DFSDM filter module.
$4400d0d4 constant DFSDM1_DFSDM_CH6DLYR  \ offset: 0xD4 : DFSDM channel 6 delay register
$4400d0e0 constant DFSDM1_DFSDM_CH7CFGR1  \ offset: 0xE0 : This register specifies the parameters used by channel y.
$4400d0e4 constant DFSDM1_DFSDM_CH7CFGR2  \ offset: 0xE4 : This register specifies the parameters used by channel y.
$4400d0e8 constant DFSDM1_DFSDM_CH7AWSCDR  \ offset: 0xE8 : Short-circuit detector and analog watchdog settings for channel y.
$4400d0ec constant DFSDM1_DFSDM_CH7WDATR  \ offset: 0xEC : This register contains the data resulting from the analog watchdog filter associated to the input channel y.
$4400d0f0 constant DFSDM1_DFSDM_CH7DATINR  \ offset: 0xF0 : This register contains 16-bit input data to be processed by DFSDM filter module.
$4400d0f4 constant DFSDM1_DFSDM_CH7DLYR  \ offset: 0xF4 : DFSDM channel 7 delay register
$4400d100 constant DFSDM1_DFSDM_FLT0CR1  \ offset: 0x100 : DFSDM filter 0 control register 1
$4400d104 constant DFSDM1_DFSDM_FLT0CR2  \ offset: 0x104 : DFSDM filter 0 control register 2
$4400d108 constant DFSDM1_DFSDM_FLT0ISR  \ offset: 0x108 : DFSDM filter 0 interrupt and status register
$4400d10c constant DFSDM1_DFSDM_FLT0ICR  \ offset: 0x10C : DFSDM filter 0 interrupt flag clear register
$4400d110 constant DFSDM1_DFSDM_FLT0JCHGR  \ offset: 0x110 : DFSDM filter 0 injected channel group selection register
$4400d114 constant DFSDM1_DFSDM_FLT0FCR  \ offset: 0x114 : DFSDM filter 0 control register
$4400d118 constant DFSDM1_DFSDM_FLT0JDATAR  \ offset: 0x118 : DFSDM filter 0 data register for injected group
$4400d11c constant DFSDM1_DFSDM_FLT0RDATAR  \ offset: 0x11C : DFSDM filter 0 data register for the regular channel
$4400d120 constant DFSDM1_DFSDM_FLT0AWHTR  \ offset: 0x120 : DFSDM filter 0 analog watchdog high threshold register
$4400d124 constant DFSDM1_DFSDM_FLT0AWLTR  \ offset: 0x124 : DFSDM filter 0 analog watchdog low threshold register
$4400d128 constant DFSDM1_DFSDM_FLT0AWSR  \ offset: 0x128 : DFSDM filter 0 analog watchdog status register
$4400d12c constant DFSDM1_DFSDM_FLT0AWCFR  \ offset: 0x12C : DFSDM filter 0 analog watchdog clear flag register
$4400d130 constant DFSDM1_DFSDM_FLT0EXMAX  \ offset: 0x130 : DFSDM filter 0 extremes detector maximum register
$4400d134 constant DFSDM1_DFSDM_FLT0EXMIN  \ offset: 0x134 : DFSDM filter 0 extremes detector minimum register
$4400d138 constant DFSDM1_DFSDM_FLT0CNVTIMR  \ offset: 0x138 : DFSDM filter 0 conversion timer register
$4400d180 constant DFSDM1_DFSDM_FLT1CR1  \ offset: 0x180 : DFSDM filter 1 control register 1
$4400d184 constant DFSDM1_DFSDM_FLT1CR2  \ offset: 0x184 : DFSDM filter 1 control register 2
$4400d188 constant DFSDM1_DFSDM_FLT1ISR  \ offset: 0x188 : DFSDM filter 1 interrupt and status register
$4400d18c constant DFSDM1_DFSDM_FLT1ICR  \ offset: 0x18C : DFSDM filter 1 interrupt flag clear register
$4400d190 constant DFSDM1_DFSDM_FLT1JCHGR  \ offset: 0x190 : DFSDM filter 1 injected channel group selection register
$4400d194 constant DFSDM1_DFSDM_FLT1FCR  \ offset: 0x194 : DFSDM filter 1 control register
$4400d198 constant DFSDM1_DFSDM_FLT1JDATAR  \ offset: 0x198 : DFSDM filter 1 data register for injected group
$4400d19c constant DFSDM1_DFSDM_FLT1RDATAR  \ offset: 0x19C : DFSDM filter 1 data register for the regular channel
$4400d1a0 constant DFSDM1_DFSDM_FLT1AWHTR  \ offset: 0x1A0 : DFSDM filter 1 analog watchdog high threshold register
$4400d1a4 constant DFSDM1_DFSDM_FLT1AWLTR  \ offset: 0x1A4 : DFSDM filter 1 analog watchdog low threshold register
$4400d1a8 constant DFSDM1_DFSDM_FLT1AWSR  \ offset: 0x1A8 : DFSDM filter 1 analog watchdog status register
$4400d1ac constant DFSDM1_DFSDM_FLT1AWCFR  \ offset: 0x1AC : DFSDM filter 1 analog watchdog clear flag register
$4400d1b0 constant DFSDM1_DFSDM_FLT1EXMAX  \ offset: 0x1B0 : DFSDM filter 1 extremes detector maximum register
$4400d1b4 constant DFSDM1_DFSDM_FLT1EXMIN  \ offset: 0x1B4 : DFSDM filter 1 extremes detector minimum register
$4400d1b8 constant DFSDM1_DFSDM_FLT1CNVTIMR  \ offset: 0x1B8 : DFSDM filter 1 conversion timer register
$4400d200 constant DFSDM1_DFSDM_FLT2CR1  \ offset: 0x200 : DFSDM filter 2 control register 1
$4400d204 constant DFSDM1_DFSDM_FLT2CR2  \ offset: 0x204 : DFSDM filter 2 control register 2
$4400d208 constant DFSDM1_DFSDM_FLT2ISR  \ offset: 0x208 : DFSDM filter 2 interrupt and status register
$4400d20c constant DFSDM1_DFSDM_FLT2ICR  \ offset: 0x20C : DFSDM filter 2 interrupt flag clear register
$4400d210 constant DFSDM1_DFSDM_FLT2JCHGR  \ offset: 0x210 : DFSDM filter 2 injected channel group selection register
$4400d214 constant DFSDM1_DFSDM_FLT2FCR  \ offset: 0x214 : DFSDM filter 2 control register
$4400d218 constant DFSDM1_DFSDM_FLT2JDATAR  \ offset: 0x218 : DFSDM filter 2 data register for injected group
$4400d21c constant DFSDM1_DFSDM_FLT2RDATAR  \ offset: 0x21C : DFSDM filter 2 data register for the regular channel
$4400d220 constant DFSDM1_DFSDM_FLT2AWHTR  \ offset: 0x220 : DFSDM filter 2 analog watchdog high threshold register
$4400d224 constant DFSDM1_DFSDM_FLT2AWLTR  \ offset: 0x224 : DFSDM filter 2 analog watchdog low threshold register
$4400d228 constant DFSDM1_DFSDM_FLT2AWSR  \ offset: 0x228 : DFSDM filter 2 analog watchdog status register
$4400d22c constant DFSDM1_DFSDM_FLT2AWCFR  \ offset: 0x22C : DFSDM filter 2 analog watchdog clear flag register
$4400d230 constant DFSDM1_DFSDM_FLT2EXMAX  \ offset: 0x230 : DFSDM filter 2 extremes detector maximum register
$4400d234 constant DFSDM1_DFSDM_FLT2EXMIN  \ offset: 0x234 : DFSDM filter 2 extremes detector minimum register
$4400d238 constant DFSDM1_DFSDM_FLT2CNVTIMR  \ offset: 0x238 : DFSDM filter 2 conversion timer register
$4400d280 constant DFSDM1_DFSDM_FLT3CR1  \ offset: 0x280 : DFSDM filter 3 control register 1
$4400d284 constant DFSDM1_DFSDM_FLT3CR2  \ offset: 0x284 : DFSDM filter 3 control register 2
$4400d288 constant DFSDM1_DFSDM_FLT3ISR  \ offset: 0x288 : DFSDM filter 3 interrupt and status register
$4400d28c constant DFSDM1_DFSDM_FLT3ICR  \ offset: 0x28C : DFSDM filter 3 interrupt flag clear register
$4400d290 constant DFSDM1_DFSDM_FLT3JCHGR  \ offset: 0x290 : DFSDM filter 3 injected channel group selection register
$4400d294 constant DFSDM1_DFSDM_FLT3FCR  \ offset: 0x294 : DFSDM filter 3 control register
$4400d298 constant DFSDM1_DFSDM_FLT3JDATAR  \ offset: 0x298 : DFSDM filter 3 data register for injected group
$4400d29c constant DFSDM1_DFSDM_FLT3RDATAR  \ offset: 0x29C : DFSDM filter 3 data register for the regular channel
$4400d2a0 constant DFSDM1_DFSDM_FLT3AWHTR  \ offset: 0x2A0 : DFSDM filter 3 analog watchdog high threshold register
$4400d2a4 constant DFSDM1_DFSDM_FLT3AWLTR  \ offset: 0x2A4 : DFSDM filter 3 analog watchdog low threshold register
$4400d2a8 constant DFSDM1_DFSDM_FLT3AWSR  \ offset: 0x2A8 : DFSDM filter 3 analog watchdog status register
$4400d2ac constant DFSDM1_DFSDM_FLT3AWCFR  \ offset: 0x2AC : DFSDM filter 3 analog watchdog clear flag register
$4400d2b0 constant DFSDM1_DFSDM_FLT3EXMAX  \ offset: 0x2B0 : DFSDM filter 3 extremes detector maximum register
$4400d2b4 constant DFSDM1_DFSDM_FLT3EXMIN  \ offset: 0x2B4 : DFSDM filter 3 extremes detector minimum register
$4400d2b8 constant DFSDM1_DFSDM_FLT3CNVTIMR  \ offset: 0x2B8 : DFSDM filter 3 conversion timer register
$4400d300 constant DFSDM1_DFSDM_FLT4CR1  \ offset: 0x300 : DFSDM filter 4 control register 1
$4400d304 constant DFSDM1_DFSDM_FLT4CR2  \ offset: 0x304 : DFSDM filter 4 control register 2
$4400d308 constant DFSDM1_DFSDM_FLT4ISR  \ offset: 0x308 : DFSDM filter 4 interrupt and status register
$4400d30c constant DFSDM1_DFSDM_FLT4ICR  \ offset: 0x30C : DFSDM filter 4 interrupt flag clear register
$4400d310 constant DFSDM1_DFSDM_FLT4JCHGR  \ offset: 0x310 : DFSDM filter 4 injected channel group selection register
$4400d314 constant DFSDM1_DFSDM_FLT4FCR  \ offset: 0x314 : DFSDM filter 4 control register
$4400d318 constant DFSDM1_DFSDM_FLT4JDATAR  \ offset: 0x318 : DFSDM filter 4 data register for injected group
$4400d31c constant DFSDM1_DFSDM_FLT4RDATAR  \ offset: 0x31C : DFSDM filter 4 data register for the regular channel
$4400d320 constant DFSDM1_DFSDM_FLT4AWHTR  \ offset: 0x320 : DFSDM filter 4 analog watchdog high threshold register
$4400d324 constant DFSDM1_DFSDM_FLT4AWLTR  \ offset: 0x324 : DFSDM filter 4 analog watchdog low threshold register
$4400d328 constant DFSDM1_DFSDM_FLT4AWSR  \ offset: 0x328 : DFSDM filter 4 analog watchdog status register
$4400d32c constant DFSDM1_DFSDM_FLT4AWCFR  \ offset: 0x32C : DFSDM filter 4 analog watchdog clear flag register
$4400d330 constant DFSDM1_DFSDM_FLT4EXMAX  \ offset: 0x330 : DFSDM filter 4 extremes detector maximum register
$4400d334 constant DFSDM1_DFSDM_FLT4EXMIN  \ offset: 0x334 : DFSDM filter 4 extremes detector minimum register
$4400d338 constant DFSDM1_DFSDM_FLT4CNVTIMR  \ offset: 0x338 : DFSDM filter 4 conversion timer register
$4400d380 constant DFSDM1_DFSDM_FLT5CR1  \ offset: 0x380 : DFSDM filter 5 control register 1
$4400d384 constant DFSDM1_DFSDM_FLT5CR2  \ offset: 0x384 : DFSDM filter 5 control register 2
$4400d388 constant DFSDM1_DFSDM_FLT5ISR  \ offset: 0x388 : DFSDM filter 5 interrupt and status register
$4400d38c constant DFSDM1_DFSDM_FLT5ICR  \ offset: 0x38C : DFSDM filter 5 interrupt flag clear register
$4400d390 constant DFSDM1_DFSDM_FLT5JCHGR  \ offset: 0x390 : DFSDM filter 5 injected channel group selection register
$4400d394 constant DFSDM1_DFSDM_FLT5FCR  \ offset: 0x394 : DFSDM filter 5 control register
$4400d398 constant DFSDM1_DFSDM_FLT5JDATAR  \ offset: 0x398 : DFSDM filter 5 data register for injected group
$4400d39c constant DFSDM1_DFSDM_FLT5RDATAR  \ offset: 0x39C : DFSDM filter 5 data register for the regular channel
$4400d3a0 constant DFSDM1_DFSDM_FLT5AWHTR  \ offset: 0x3A0 : DFSDM filter 5 analog watchdog high threshold register
$4400d3a4 constant DFSDM1_DFSDM_FLT5AWLTR  \ offset: 0x3A4 : DFSDM filter 5 analog watchdog low threshold register
$4400d3a8 constant DFSDM1_DFSDM_FLT5AWSR  \ offset: 0x3A8 : DFSDM filter 5 analog watchdog status register
$4400d3ac constant DFSDM1_DFSDM_FLT5AWCFR  \ offset: 0x3AC : DFSDM filter 5 analog watchdog clear flag register
$4400d3b0 constant DFSDM1_DFSDM_FLT5EXMAX  \ offset: 0x3B0 : DFSDM filter 5 extremes detector maximum register
$4400d3b4 constant DFSDM1_DFSDM_FLT5EXMIN  \ offset: 0x3B4 : DFSDM filter 5 extremes detector minimum register
$4400d3b8 constant DFSDM1_DFSDM_FLT5CNVTIMR  \ offset: 0x3B8 : DFSDM filter 5 conversion timer register
$4400d7f0 constant DFSDM1_DFSDM_HWCFGR  \ offset: 0x7F0 : This register specifies the hardware configuration of DFSDM peripheral.
$4400d7f4 constant DFSDM1_DFSDM_VERR  \ offset: 0x7F4 : This register specifies the version of DFSDM peripheral.
$4400d7f8 constant DFSDM1_DFSDM_IPIDR  \ offset: 0x7F8 : This register specifies the identification of DFSDM peripheral.
$4400d7fc constant DFSDM1_DFSDM_SIDR  \ offset: 0x7FC : This register specifies the size allocated to DFSDM registers.

