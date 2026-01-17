\
\ @file dfsdm1.fs
\ @brief DFSDM1
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] DFSDM1_DEF

  [ifdef] DFSDM1_DFSDM_CH0CFGR1_DEF
    \
    \ @brief This register specifies the parameters used by channel y.
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM1_SITP                    \ [0x00 : 2] SITP
    $02 constant DFSDM1_SPICKSEL                \ [0x02 : 2] SPICKSEL
    $05 constant DFSDM1_SCDEN                   \ [0x05] SCDEN
    $06 constant DFSDM1_CKABEN                  \ [0x06] CKABEN
    $07 constant DFSDM1_CHEN                    \ [0x07] CHEN
    $08 constant DFSDM1_CHINSEL                 \ [0x08] CHINSEL
    $0c constant DFSDM1_DATMPX                  \ [0x0c : 2] DATMPX
    $0e constant DFSDM1_DATPACK                 \ [0x0e : 2] DATPACK
    $10 constant DFSDM1_CKOUTDIV                \ [0x10 : 8] CKOUTDIV
    $1e constant DFSDM1_CKOUTSRC                \ [0x1e] CKOUTSRC
    $1f constant DFSDM1_DFSDMEN                 \ [0x1f] DFSDMEN
  [then]


  [ifdef] DFSDM1_DFSDM_CH0CFGR2_DEF
    \
    \ @brief This register specifies the parameters used by channel y.
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $03 constant DFSDM1_DTRBS                   \ [0x03 : 5] DTRBS
    $08 constant DFSDM1_OFFSET                  \ [0x08 : 24] OFFSET
  [then]


  [ifdef] DFSDM1_DFSDM_CH0AWSCDR_DEF
    \
    \ @brief Short-circuit detector and analog watchdog settings for channel y.
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM1_SCDT                    \ [0x00 : 8] SCDT
    $0c constant DFSDM1_BKSCD                   \ [0x0c : 4] BKSCD
    $10 constant DFSDM1_AWFOSR                  \ [0x10 : 5] AWFOSR
    $16 constant DFSDM1_AWFORD                  \ [0x16 : 2] AWFORD
  [then]


  [ifdef] DFSDM1_DFSDM_CH0WDATR_DEF
    \
    \ @brief This register contains the data resulting from the analog watchdog filter associated to the input channel y.
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM1_WDATA                   \ [0x00 : 16] WDATA
  [then]


  [ifdef] DFSDM1_DFSDM_CH0DATINR_DEF
    \
    \ @brief This register contains 16-bit input data to be processed by DFSDM filter module.
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM1_INDAT0                  \ [0x00 : 16] INDAT0
    $10 constant DFSDM1_INDAT1                  \ [0x10 : 16] INDAT1
  [then]


  [ifdef] DFSDM1_DFSDM_CH0DLYR_DEF
    \
    \ @brief DFSDM channel 0 delay register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM1_PLSSKP                  \ [0x00 : 6] PLSSKP
  [then]


  [ifdef] DFSDM1_DFSDM_CH1CFGR1_DEF
    \
    \ @brief This register specifies the parameters used by channel y.
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM1_SITP                    \ [0x00 : 2] SITP
    $02 constant DFSDM1_SPICKSEL                \ [0x02 : 2] SPICKSEL
    $05 constant DFSDM1_SCDEN                   \ [0x05] SCDEN
    $06 constant DFSDM1_CKABEN                  \ [0x06] CKABEN
    $07 constant DFSDM1_CHEN                    \ [0x07] CHEN
    $08 constant DFSDM1_CHINSEL                 \ [0x08] CHINSEL
    $0c constant DFSDM1_DATMPX                  \ [0x0c : 2] DATMPX
    $0e constant DFSDM1_DATPACK                 \ [0x0e : 2] DATPACK
    $10 constant DFSDM1_CKOUTDIV                \ [0x10 : 8] CKOUTDIV
    $1e constant DFSDM1_CKOUTSRC                \ [0x1e] CKOUTSRC
    $1f constant DFSDM1_DFSDMEN                 \ [0x1f] DFSDMEN
  [then]


  [ifdef] DFSDM1_DFSDM_CH1CFGR2_DEF
    \
    \ @brief This register specifies the parameters used by channel y.
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $03 constant DFSDM1_DTRBS                   \ [0x03 : 5] DTRBS
    $08 constant DFSDM1_OFFSET                  \ [0x08 : 24] OFFSET
  [then]


  [ifdef] DFSDM1_DFSDM_CH1AWSCDR_DEF
    \
    \ @brief Short-circuit detector and analog watchdog settings for channel y.
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM1_SCDT                    \ [0x00 : 8] SCDT
    $0c constant DFSDM1_BKSCD                   \ [0x0c : 4] BKSCD
    $10 constant DFSDM1_AWFOSR                  \ [0x10 : 5] AWFOSR
    $16 constant DFSDM1_AWFORD                  \ [0x16 : 2] AWFORD
  [then]


  [ifdef] DFSDM1_DFSDM_CH1WDATR_DEF
    \
    \ @brief This register contains the data resulting from the analog watchdog filter associated to the input channel y.
    \ Address offset: 0x2C
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM1_WDATA                   \ [0x00 : 16] WDATA
  [then]


  [ifdef] DFSDM1_DFSDM_CH1DATINR_DEF
    \
    \ @brief This register contains 16-bit input data to be processed by DFSDM filter module.
    \ Address offset: 0x30
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM1_INDAT0                  \ [0x00 : 16] INDAT0
    $10 constant DFSDM1_INDAT1                  \ [0x10 : 16] INDAT1
  [then]


  [ifdef] DFSDM1_DFSDM_CH1DLYR_DEF
    \
    \ @brief DFSDM channel 1 delay register
    \ Address offset: 0x34
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM1_PLSSKP                  \ [0x00 : 6] PLSSKP
  [then]


  [ifdef] DFSDM1_DFSDM_CH2CFGR1_DEF
    \
    \ @brief This register specifies the parameters used by channel y.
    \ Address offset: 0x40
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM1_SITP                    \ [0x00 : 2] SITP
    $02 constant DFSDM1_SPICKSEL                \ [0x02 : 2] SPICKSEL
    $05 constant DFSDM1_SCDEN                   \ [0x05] SCDEN
    $06 constant DFSDM1_CKABEN                  \ [0x06] CKABEN
    $07 constant DFSDM1_CHEN                    \ [0x07] CHEN
    $08 constant DFSDM1_CHINSEL                 \ [0x08] CHINSEL
    $0c constant DFSDM1_DATMPX                  \ [0x0c : 2] DATMPX
    $0e constant DFSDM1_DATPACK                 \ [0x0e : 2] DATPACK
    $10 constant DFSDM1_CKOUTDIV                \ [0x10 : 8] CKOUTDIV
    $1e constant DFSDM1_CKOUTSRC                \ [0x1e] CKOUTSRC
    $1f constant DFSDM1_DFSDMEN                 \ [0x1f] DFSDMEN
  [then]


  [ifdef] DFSDM1_DFSDM_CH2CFGR2_DEF
    \
    \ @brief This register specifies the parameters used by channel y.
    \ Address offset: 0x44
    \ Reset value: 0x00000000
    \
    $03 constant DFSDM1_DTRBS                   \ [0x03 : 5] DTRBS
    $08 constant DFSDM1_OFFSET                  \ [0x08 : 24] OFFSET
  [then]


  [ifdef] DFSDM1_DFSDM_CH2AWSCDR_DEF
    \
    \ @brief Short-circuit detector and analog watchdog settings for channel y.
    \ Address offset: 0x48
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM1_SCDT                    \ [0x00 : 8] SCDT
    $0c constant DFSDM1_BKSCD                   \ [0x0c : 4] BKSCD
    $10 constant DFSDM1_AWFOSR                  \ [0x10 : 5] AWFOSR
    $16 constant DFSDM1_AWFORD                  \ [0x16 : 2] AWFORD
  [then]


  [ifdef] DFSDM1_DFSDM_CH2WDATR_DEF
    \
    \ @brief This register contains the data resulting from the analog watchdog filter associated to the input channel y.
    \ Address offset: 0x4C
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM1_WDATA                   \ [0x00 : 16] WDATA
  [then]


  [ifdef] DFSDM1_DFSDM_CH2DATINR_DEF
    \
    \ @brief This register contains 16-bit input data to be processed by DFSDM filter module.
    \ Address offset: 0x50
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM1_INDAT0                  \ [0x00 : 16] INDAT0
    $10 constant DFSDM1_INDAT1                  \ [0x10 : 16] INDAT1
  [then]


  [ifdef] DFSDM1_DFSDM_CH2DLYR_DEF
    \
    \ @brief DFSDM channel 2 delay register
    \ Address offset: 0x54
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM1_PLSSKP                  \ [0x00 : 6] PLSSKP
  [then]


  [ifdef] DFSDM1_DFSDM_CH3CFGR1_DEF
    \
    \ @brief This register specifies the parameters used by channel y.
    \ Address offset: 0x60
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM1_SITP                    \ [0x00 : 2] SITP
    $02 constant DFSDM1_SPICKSEL                \ [0x02 : 2] SPICKSEL
    $05 constant DFSDM1_SCDEN                   \ [0x05] SCDEN
    $06 constant DFSDM1_CKABEN                  \ [0x06] CKABEN
    $07 constant DFSDM1_CHEN                    \ [0x07] CHEN
    $08 constant DFSDM1_CHINSEL                 \ [0x08] CHINSEL
    $0c constant DFSDM1_DATMPX                  \ [0x0c : 2] DATMPX
    $0e constant DFSDM1_DATPACK                 \ [0x0e : 2] DATPACK
    $10 constant DFSDM1_CKOUTDIV                \ [0x10 : 8] CKOUTDIV
    $1e constant DFSDM1_CKOUTSRC                \ [0x1e] CKOUTSRC
    $1f constant DFSDM1_DFSDMEN                 \ [0x1f] DFSDMEN
  [then]


  [ifdef] DFSDM1_DFSDM_CH3CFGR2_DEF
    \
    \ @brief This register specifies the parameters used by channel y.
    \ Address offset: 0x64
    \ Reset value: 0x00000000
    \
    $03 constant DFSDM1_DTRBS                   \ [0x03 : 5] DTRBS
    $08 constant DFSDM1_OFFSET                  \ [0x08 : 24] OFFSET
  [then]


  [ifdef] DFSDM1_DFSDM_CH3AWSCDR_DEF
    \
    \ @brief Short-circuit detector and analog watchdog settings for channel y.
    \ Address offset: 0x68
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM1_SCDT                    \ [0x00 : 8] SCDT
    $0c constant DFSDM1_BKSCD                   \ [0x0c : 4] BKSCD
    $10 constant DFSDM1_AWFOSR                  \ [0x10 : 5] AWFOSR
    $16 constant DFSDM1_AWFORD                  \ [0x16 : 2] AWFORD
  [then]


  [ifdef] DFSDM1_DFSDM_CH3WDATR_DEF
    \
    \ @brief This register contains the data resulting from the analog watchdog filter associated to the input channel y.
    \ Address offset: 0x6C
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM1_WDATA                   \ [0x00 : 16] WDATA
  [then]


  [ifdef] DFSDM1_DFSDM_CH3DATINR_DEF
    \
    \ @brief This register contains 16-bit input data to be processed by DFSDM filter module.
    \ Address offset: 0x70
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM1_INDAT0                  \ [0x00 : 16] INDAT0
    $10 constant DFSDM1_INDAT1                  \ [0x10 : 16] INDAT1
  [then]


  [ifdef] DFSDM1_DFSDM_CH3DLYR_DEF
    \
    \ @brief DFSDM channel 3 delay register
    \ Address offset: 0x74
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM1_PLSSKP                  \ [0x00 : 6] PLSSKP
  [then]


  [ifdef] DFSDM1_DFSDM_CH4CFGR1_DEF
    \
    \ @brief This register specifies the parameters used by channel y.
    \ Address offset: 0x80
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM1_SITP                    \ [0x00 : 2] SITP
    $02 constant DFSDM1_SPICKSEL                \ [0x02 : 2] SPICKSEL
    $05 constant DFSDM1_SCDEN                   \ [0x05] SCDEN
    $06 constant DFSDM1_CKABEN                  \ [0x06] CKABEN
    $07 constant DFSDM1_CHEN                    \ [0x07] CHEN
    $08 constant DFSDM1_CHINSEL                 \ [0x08] CHINSEL
    $0c constant DFSDM1_DATMPX                  \ [0x0c : 2] DATMPX
    $0e constant DFSDM1_DATPACK                 \ [0x0e : 2] DATPACK
    $10 constant DFSDM1_CKOUTDIV                \ [0x10 : 8] CKOUTDIV
    $1e constant DFSDM1_CKOUTSRC                \ [0x1e] CKOUTSRC
    $1f constant DFSDM1_DFSDMEN                 \ [0x1f] DFSDMEN
  [then]


  [ifdef] DFSDM1_DFSDM_CH4CFGR2_DEF
    \
    \ @brief This register specifies the parameters used by channel y.
    \ Address offset: 0x84
    \ Reset value: 0x00000000
    \
    $03 constant DFSDM1_DTRBS                   \ [0x03 : 5] DTRBS
    $08 constant DFSDM1_OFFSET                  \ [0x08 : 24] OFFSET
  [then]


  [ifdef] DFSDM1_DFSDM_CH4AWSCDR_DEF
    \
    \ @brief Short-circuit detector and analog watchdog settings for channel y.
    \ Address offset: 0x88
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM1_SCDT                    \ [0x00 : 8] SCDT
    $0c constant DFSDM1_BKSCD                   \ [0x0c : 4] BKSCD
    $10 constant DFSDM1_AWFOSR                  \ [0x10 : 5] AWFOSR
    $16 constant DFSDM1_AWFORD                  \ [0x16 : 2] AWFORD
  [then]


  [ifdef] DFSDM1_DFSDM_CH4WDATR_DEF
    \
    \ @brief This register contains the data resulting from the analog watchdog filter associated to the input channel y.
    \ Address offset: 0x8C
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM1_WDATA                   \ [0x00 : 16] WDATA
  [then]


  [ifdef] DFSDM1_DFSDM_CH4DATINR_DEF
    \
    \ @brief This register contains 16-bit input data to be processed by DFSDM filter module.
    \ Address offset: 0x90
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM1_INDAT0                  \ [0x00 : 16] INDAT0
    $10 constant DFSDM1_INDAT1                  \ [0x10 : 16] INDAT1
  [then]


  [ifdef] DFSDM1_DFSDM_CH4DLYR_DEF
    \
    \ @brief DFSDM channel 4 delay register
    \ Address offset: 0x94
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM1_PLSSKP                  \ [0x00 : 6] PLSSKP
  [then]


  [ifdef] DFSDM1_DFSDM_CH5CFGR1_DEF
    \
    \ @brief This register specifies the parameters used by channel y.
    \ Address offset: 0xA0
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM1_SITP                    \ [0x00 : 2] SITP
    $02 constant DFSDM1_SPICKSEL                \ [0x02 : 2] SPICKSEL
    $05 constant DFSDM1_SCDEN                   \ [0x05] SCDEN
    $06 constant DFSDM1_CKABEN                  \ [0x06] CKABEN
    $07 constant DFSDM1_CHEN                    \ [0x07] CHEN
    $08 constant DFSDM1_CHINSEL                 \ [0x08] CHINSEL
    $0c constant DFSDM1_DATMPX                  \ [0x0c : 2] DATMPX
    $0e constant DFSDM1_DATPACK                 \ [0x0e : 2] DATPACK
    $10 constant DFSDM1_CKOUTDIV                \ [0x10 : 8] CKOUTDIV
    $1e constant DFSDM1_CKOUTSRC                \ [0x1e] CKOUTSRC
    $1f constant DFSDM1_DFSDMEN                 \ [0x1f] DFSDMEN
  [then]


  [ifdef] DFSDM1_DFSDM_CH5CFGR2_DEF
    \
    \ @brief This register specifies the parameters used by channel y.
    \ Address offset: 0xA4
    \ Reset value: 0x00000000
    \
    $03 constant DFSDM1_DTRBS                   \ [0x03 : 5] DTRBS
    $08 constant DFSDM1_OFFSET                  \ [0x08 : 24] OFFSET
  [then]


  [ifdef] DFSDM1_DFSDM_CH5AWSCDR_DEF
    \
    \ @brief Short-circuit detector and analog watchdog settings for channel y.
    \ Address offset: 0xA8
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM1_SCDT                    \ [0x00 : 8] SCDT
    $0c constant DFSDM1_BKSCD                   \ [0x0c : 4] BKSCD
    $10 constant DFSDM1_AWFOSR                  \ [0x10 : 5] AWFOSR
    $16 constant DFSDM1_AWFORD                  \ [0x16 : 2] AWFORD
  [then]


  [ifdef] DFSDM1_DFSDM_CH5WDATR_DEF
    \
    \ @brief This register contains the data resulting from the analog watchdog filter associated to the input channel y.
    \ Address offset: 0xAC
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM1_WDATA                   \ [0x00 : 16] WDATA
  [then]


  [ifdef] DFSDM1_DFSDM_CH5DATINR_DEF
    \
    \ @brief This register contains 16-bit input data to be processed by DFSDM filter module.
    \ Address offset: 0xB0
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM1_INDAT0                  \ [0x00 : 16] INDAT0
    $10 constant DFSDM1_INDAT1                  \ [0x10 : 16] INDAT1
  [then]


  [ifdef] DFSDM1_DFSDM_CH5DLYR_DEF
    \
    \ @brief DFSDM channel 5 delay register
    \ Address offset: 0xB4
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM1_PLSSKP                  \ [0x00 : 6] PLSSKP
  [then]


  [ifdef] DFSDM1_DFSDM_CH6CFGR1_DEF
    \
    \ @brief This register specifies the parameters used by channel y.
    \ Address offset: 0xC0
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM1_SITP                    \ [0x00 : 2] SITP
    $02 constant DFSDM1_SPICKSEL                \ [0x02 : 2] SPICKSEL
    $05 constant DFSDM1_SCDEN                   \ [0x05] SCDEN
    $06 constant DFSDM1_CKABEN                  \ [0x06] CKABEN
    $07 constant DFSDM1_CHEN                    \ [0x07] CHEN
    $08 constant DFSDM1_CHINSEL                 \ [0x08] CHINSEL
    $0c constant DFSDM1_DATMPX                  \ [0x0c : 2] DATMPX
    $0e constant DFSDM1_DATPACK                 \ [0x0e : 2] DATPACK
    $10 constant DFSDM1_CKOUTDIV                \ [0x10 : 8] CKOUTDIV
    $1e constant DFSDM1_CKOUTSRC                \ [0x1e] CKOUTSRC
    $1f constant DFSDM1_DFSDMEN                 \ [0x1f] DFSDMEN
  [then]


  [ifdef] DFSDM1_DFSDM_CH6CFGR2_DEF
    \
    \ @brief This register specifies the parameters used by channel y.
    \ Address offset: 0xC4
    \ Reset value: 0x00000000
    \
    $03 constant DFSDM1_DTRBS                   \ [0x03 : 5] DTRBS
    $08 constant DFSDM1_OFFSET                  \ [0x08 : 24] OFFSET
  [then]


  [ifdef] DFSDM1_DFSDM_CH6AWSCDR_DEF
    \
    \ @brief Short-circuit detector and analog watchdog settings for channel y.
    \ Address offset: 0xC8
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM1_SCDT                    \ [0x00 : 8] SCDT
    $0c constant DFSDM1_BKSCD                   \ [0x0c : 4] BKSCD
    $10 constant DFSDM1_AWFOSR                  \ [0x10 : 5] AWFOSR
    $16 constant DFSDM1_AWFORD                  \ [0x16 : 2] AWFORD
  [then]


  [ifdef] DFSDM1_DFSDM_CH6WDATR_DEF
    \
    \ @brief This register contains the data resulting from the analog watchdog filter associated to the input channel y.
    \ Address offset: 0xCC
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM1_WDATA                   \ [0x00 : 16] WDATA
  [then]


  [ifdef] DFSDM1_DFSDM_CH6DATINR_DEF
    \
    \ @brief This register contains 16-bit input data to be processed by DFSDM filter module.
    \ Address offset: 0xD0
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM1_INDAT0                  \ [0x00 : 16] INDAT0
    $10 constant DFSDM1_INDAT1                  \ [0x10 : 16] INDAT1
  [then]


  [ifdef] DFSDM1_DFSDM_CH6DLYR_DEF
    \
    \ @brief DFSDM channel 6 delay register
    \ Address offset: 0xD4
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM1_PLSSKP                  \ [0x00 : 6] PLSSKP
  [then]


  [ifdef] DFSDM1_DFSDM_CH7CFGR1_DEF
    \
    \ @brief This register specifies the parameters used by channel y.
    \ Address offset: 0xE0
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM1_SITP                    \ [0x00 : 2] SITP
    $02 constant DFSDM1_SPICKSEL                \ [0x02 : 2] SPICKSEL
    $05 constant DFSDM1_SCDEN                   \ [0x05] SCDEN
    $06 constant DFSDM1_CKABEN                  \ [0x06] CKABEN
    $07 constant DFSDM1_CHEN                    \ [0x07] CHEN
    $08 constant DFSDM1_CHINSEL                 \ [0x08] CHINSEL
    $0c constant DFSDM1_DATMPX                  \ [0x0c : 2] DATMPX
    $0e constant DFSDM1_DATPACK                 \ [0x0e : 2] DATPACK
    $10 constant DFSDM1_CKOUTDIV                \ [0x10 : 8] CKOUTDIV
    $1e constant DFSDM1_CKOUTSRC                \ [0x1e] CKOUTSRC
    $1f constant DFSDM1_DFSDMEN                 \ [0x1f] DFSDMEN
  [then]


  [ifdef] DFSDM1_DFSDM_CH7CFGR2_DEF
    \
    \ @brief This register specifies the parameters used by channel y.
    \ Address offset: 0xE4
    \ Reset value: 0x00000000
    \
    $03 constant DFSDM1_DTRBS                   \ [0x03 : 5] DTRBS
    $08 constant DFSDM1_OFFSET                  \ [0x08 : 24] OFFSET
  [then]


  [ifdef] DFSDM1_DFSDM_CH7AWSCDR_DEF
    \
    \ @brief Short-circuit detector and analog watchdog settings for channel y.
    \ Address offset: 0xE8
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM1_SCDT                    \ [0x00 : 8] SCDT
    $0c constant DFSDM1_BKSCD                   \ [0x0c : 4] BKSCD
    $10 constant DFSDM1_AWFOSR                  \ [0x10 : 5] AWFOSR
    $16 constant DFSDM1_AWFORD                  \ [0x16 : 2] AWFORD
  [then]


  [ifdef] DFSDM1_DFSDM_CH7WDATR_DEF
    \
    \ @brief This register contains the data resulting from the analog watchdog filter associated to the input channel y.
    \ Address offset: 0xEC
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM1_WDATA                   \ [0x00 : 16] WDATA
  [then]


  [ifdef] DFSDM1_DFSDM_CH7DATINR_DEF
    \
    \ @brief This register contains 16-bit input data to be processed by DFSDM filter module.
    \ Address offset: 0xF0
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM1_INDAT0                  \ [0x00 : 16] INDAT0
    $10 constant DFSDM1_INDAT1                  \ [0x10 : 16] INDAT1
  [then]


  [ifdef] DFSDM1_DFSDM_CH7DLYR_DEF
    \
    \ @brief DFSDM channel 7 delay register
    \ Address offset: 0xF4
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM1_PLSSKP                  \ [0x00 : 6] PLSSKP
  [then]


  [ifdef] DFSDM1_DFSDM_FLT0CR1_DEF
    \
    \ @brief DFSDM filter 0 control register 1
    \ Address offset: 0x100
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM1_DFEN                    \ [0x00] DFEN
    $01 constant DFSDM1_JSWSTART                \ [0x01] JSWSTART
    $03 constant DFSDM1_JSYNC                   \ [0x03] JSYNC
    $04 constant DFSDM1_JSCAN                   \ [0x04] JSCAN
    $05 constant DFSDM1_JDMAEN                  \ [0x05] JDMAEN
    $08 constant DFSDM1_JEXTSEL                 \ [0x08 : 5] JEXTSEL
    $0d constant DFSDM1_JEXTEN                  \ [0x0d : 2] JEXTEN
    $11 constant DFSDM1_RSWSTART                \ [0x11] RSWSTART
    $12 constant DFSDM1_RCONT                   \ [0x12] RCONT
    $13 constant DFSDM1_RSYNC                   \ [0x13] RSYNC
    $15 constant DFSDM1_RDMAEN                  \ [0x15] RDMAEN
    $18 constant DFSDM1_RCH                     \ [0x18 : 3] RCH
    $1d constant DFSDM1_FAST                    \ [0x1d] FAST
    $1e constant DFSDM1_AWFSEL                  \ [0x1e] AWFSEL
  [then]


  [ifdef] DFSDM1_DFSDM_FLT0CR2_DEF
    \
    \ @brief DFSDM filter 0 control register 2
    \ Address offset: 0x104
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM1_JEOCIE                  \ [0x00] JEOCIE
    $01 constant DFSDM1_REOCIE                  \ [0x01] REOCIE
    $02 constant DFSDM1_JOVRIE                  \ [0x02] JOVRIE
    $03 constant DFSDM1_ROVRIE                  \ [0x03] ROVRIE
    $04 constant DFSDM1_AWDIE                   \ [0x04] AWDIE
    $05 constant DFSDM1_SCDIE                   \ [0x05] SCDIE
    $06 constant DFSDM1_CKABIE                  \ [0x06] CKABIE
    $08 constant DFSDM1_EXCH                    \ [0x08 : 8] EXCH
    $10 constant DFSDM1_AWDCH                   \ [0x10 : 8] AWDCH
  [then]


  [ifdef] DFSDM1_DFSDM_FLT0ISR_DEF
    \
    \ @brief DFSDM filter 0 interrupt and status register
    \ Address offset: 0x108
    \ Reset value: 0x00FF0000
    \
    $00 constant DFSDM1_JEOCF                   \ [0x00] JEOCF
    $01 constant DFSDM1_REOCF                   \ [0x01] REOCF
    $02 constant DFSDM1_JOVRF                   \ [0x02] JOVRF
    $03 constant DFSDM1_ROVRF                   \ [0x03] ROVRF
    $04 constant DFSDM1_AWDF                    \ [0x04] AWDF
    $0d constant DFSDM1_JCIP                    \ [0x0d] JCIP
    $0e constant DFSDM1_RCIP                    \ [0x0e] RCIP
    $10 constant DFSDM1_CKABF                   \ [0x10 : 8] CKABF
    $18 constant DFSDM1_SCDF                    \ [0x18 : 8] SCDF
  [then]


  [ifdef] DFSDM1_DFSDM_FLT0ICR_DEF
    \
    \ @brief DFSDM filter 0 interrupt flag clear register
    \ Address offset: 0x10C
    \ Reset value: 0x00000000
    \
    $02 constant DFSDM1_CLRJOVRF                \ [0x02] CLRJOVRF
    $03 constant DFSDM1_CLRROVRF                \ [0x03] CLRROVRF
    $10 constant DFSDM1_CLRCKABF                \ [0x10 : 8] CLRCKABF
    $18 constant DFSDM1_CLRSCDF                 \ [0x18 : 8] CLRSCDF
  [then]


  [ifdef] DFSDM1_DFSDM_FLT0JCHGR_DEF
    \
    \ @brief DFSDM filter 0 injected channel group selection register
    \ Address offset: 0x110
    \ Reset value: 0x00000001
    \
    $00 constant DFSDM1_JCHG                    \ [0x00 : 8] JCHG
  [then]


  [ifdef] DFSDM1_DFSDM_FLT0FCR_DEF
    \
    \ @brief DFSDM filter 0 control register
    \ Address offset: 0x114
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM1_IOSR                    \ [0x00 : 8] IOSR
    $10 constant DFSDM1_FOSR                    \ [0x10 : 10] FOSR
    $1d constant DFSDM1_FORD                    \ [0x1d : 3] FORD
  [then]


  [ifdef] DFSDM1_DFSDM_FLT0JDATAR_DEF
    \
    \ @brief DFSDM filter 0 data register for injected group
    \ Address offset: 0x118
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM1_JDATACH                 \ [0x00 : 3] JDATACH
    $08 constant DFSDM1_JDATA                   \ [0x08 : 24] JDATA
  [then]


  [ifdef] DFSDM1_DFSDM_FLT0RDATAR_DEF
    \
    \ @brief DFSDM filter 0 data register for the regular channel
    \ Address offset: 0x11C
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM1_RDATACH                 \ [0x00 : 3] RDATACH
    $04 constant DFSDM1_RPEND                   \ [0x04] RPEND
    $08 constant DFSDM1_RDATA                   \ [0x08 : 24] RDATA
  [then]


  [ifdef] DFSDM1_DFSDM_FLT0AWHTR_DEF
    \
    \ @brief DFSDM filter 0 analog watchdog high threshold register
    \ Address offset: 0x120
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM1_BKAWH                   \ [0x00 : 4] BKAWH
    $08 constant DFSDM1_AWHT                    \ [0x08 : 24] AWHT
  [then]


  [ifdef] DFSDM1_DFSDM_FLT0AWLTR_DEF
    \
    \ @brief DFSDM filter 0 analog watchdog low threshold register
    \ Address offset: 0x124
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM1_BKAWL                   \ [0x00 : 4] BKAWL
    $08 constant DFSDM1_AWLT                    \ [0x08 : 24] AWLT
  [then]


  [ifdef] DFSDM1_DFSDM_FLT0AWSR_DEF
    \
    \ @brief DFSDM filter 0 analog watchdog status register
    \ Address offset: 0x128
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM1_AWLTF                   \ [0x00 : 8] AWLTF
    $08 constant DFSDM1_AWHTF                   \ [0x08 : 8] AWHTF
  [then]


  [ifdef] DFSDM1_DFSDM_FLT0AWCFR_DEF
    \
    \ @brief DFSDM filter 0 analog watchdog clear flag register
    \ Address offset: 0x12C
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM1_CLRAWLTF                \ [0x00 : 8] CLRAWLTF
    $08 constant DFSDM1_CLRAWHTF                \ [0x08 : 8] CLRAWHTF
  [then]


  [ifdef] DFSDM1_DFSDM_FLT0EXMAX_DEF
    \
    \ @brief DFSDM filter 0 extremes detector maximum register
    \ Address offset: 0x130
    \ Reset value: 0x80000000
    \
    $00 constant DFSDM1_EXMAXCH                 \ [0x00 : 3] EXMAXCH
    $08 constant DFSDM1_EXMAX                   \ [0x08 : 24] EXMAX
  [then]


  [ifdef] DFSDM1_DFSDM_FLT0EXMIN_DEF
    \
    \ @brief DFSDM filter 0 extremes detector minimum register
    \ Address offset: 0x134
    \ Reset value: 0x7FFFFF00
    \
    $00 constant DFSDM1_EXMINCH                 \ [0x00 : 3] EXMINCH
    $08 constant DFSDM1_EXMIN                   \ [0x08 : 24] EXMIN
  [then]


  [ifdef] DFSDM1_DFSDM_FLT0CNVTIMR_DEF
    \
    \ @brief DFSDM filter 0 conversion timer register
    \ Address offset: 0x138
    \ Reset value: 0x00000000
    \
    $04 constant DFSDM1_CNVCNT                  \ [0x04 : 28] CNVCNT
  [then]


  [ifdef] DFSDM1_DFSDM_FLT1CR1_DEF
    \
    \ @brief DFSDM filter 1 control register 1
    \ Address offset: 0x180
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM1_DFEN                    \ [0x00] DFEN
    $01 constant DFSDM1_JSWSTART                \ [0x01] JSWSTART
    $03 constant DFSDM1_JSYNC                   \ [0x03] JSYNC
    $04 constant DFSDM1_JSCAN                   \ [0x04] JSCAN
    $05 constant DFSDM1_JDMAEN                  \ [0x05] JDMAEN
    $08 constant DFSDM1_JEXTSEL                 \ [0x08 : 5] JEXTSEL
    $0d constant DFSDM1_JEXTEN                  \ [0x0d : 2] JEXTEN
    $11 constant DFSDM1_RSWSTART                \ [0x11] RSWSTART
    $12 constant DFSDM1_RCONT                   \ [0x12] RCONT
    $13 constant DFSDM1_RSYNC                   \ [0x13] RSYNC
    $15 constant DFSDM1_RDMAEN                  \ [0x15] RDMAEN
    $18 constant DFSDM1_RCH                     \ [0x18 : 3] RCH
    $1d constant DFSDM1_FAST                    \ [0x1d] FAST
    $1e constant DFSDM1_AWFSEL                  \ [0x1e] AWFSEL
  [then]


  [ifdef] DFSDM1_DFSDM_FLT1CR2_DEF
    \
    \ @brief DFSDM filter 1 control register 2
    \ Address offset: 0x184
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM1_JEOCIE                  \ [0x00] JEOCIE
    $01 constant DFSDM1_REOCIE                  \ [0x01] REOCIE
    $02 constant DFSDM1_JOVRIE                  \ [0x02] JOVRIE
    $03 constant DFSDM1_ROVRIE                  \ [0x03] ROVRIE
    $04 constant DFSDM1_AWDIE                   \ [0x04] AWDIE
    $05 constant DFSDM1_SCDIE                   \ [0x05] SCDIE
    $06 constant DFSDM1_CKABIE                  \ [0x06] CKABIE
    $08 constant DFSDM1_EXCH                    \ [0x08 : 8] EXCH
    $10 constant DFSDM1_AWDCH                   \ [0x10 : 8] AWDCH
  [then]


  [ifdef] DFSDM1_DFSDM_FLT1ISR_DEF
    \
    \ @brief DFSDM filter 1 interrupt and status register
    \ Address offset: 0x188
    \ Reset value: 0x00FF0000
    \
    $00 constant DFSDM1_JEOCF                   \ [0x00] JEOCF
    $01 constant DFSDM1_REOCF                   \ [0x01] REOCF
    $02 constant DFSDM1_JOVRF                   \ [0x02] JOVRF
    $03 constant DFSDM1_ROVRF                   \ [0x03] ROVRF
    $04 constant DFSDM1_AWDF                    \ [0x04] AWDF
    $0d constant DFSDM1_JCIP                    \ [0x0d] JCIP
    $0e constant DFSDM1_RCIP                    \ [0x0e] RCIP
    $10 constant DFSDM1_CKABF                   \ [0x10 : 8] CKABF
    $18 constant DFSDM1_SCDF                    \ [0x18 : 8] SCDF
  [then]


  [ifdef] DFSDM1_DFSDM_FLT1ICR_DEF
    \
    \ @brief DFSDM filter 1 interrupt flag clear register
    \ Address offset: 0x18C
    \ Reset value: 0x00000000
    \
    $02 constant DFSDM1_CLRJOVRF                \ [0x02] CLRJOVRF
    $03 constant DFSDM1_CLRROVRF                \ [0x03] CLRROVRF
    $10 constant DFSDM1_CLRCKABF                \ [0x10 : 8] CLRCKABF
    $18 constant DFSDM1_CLRSCDF                 \ [0x18 : 8] CLRSCDF
  [then]


  [ifdef] DFSDM1_DFSDM_FLT1JCHGR_DEF
    \
    \ @brief DFSDM filter 1 injected channel group selection register
    \ Address offset: 0x190
    \ Reset value: 0x00000001
    \
    $00 constant DFSDM1_JCHG                    \ [0x00 : 8] JCHG
  [then]


  [ifdef] DFSDM1_DFSDM_FLT1FCR_DEF
    \
    \ @brief DFSDM filter 1 control register
    \ Address offset: 0x194
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM1_IOSR                    \ [0x00 : 8] IOSR
    $10 constant DFSDM1_FOSR                    \ [0x10 : 10] FOSR
    $1d constant DFSDM1_FORD                    \ [0x1d : 3] FORD
  [then]


  [ifdef] DFSDM1_DFSDM_FLT1JDATAR_DEF
    \
    \ @brief DFSDM filter 1 data register for injected group
    \ Address offset: 0x198
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM1_JDATACH                 \ [0x00 : 3] JDATACH
    $08 constant DFSDM1_JDATA                   \ [0x08 : 24] JDATA
  [then]


  [ifdef] DFSDM1_DFSDM_FLT1RDATAR_DEF
    \
    \ @brief DFSDM filter 1 data register for the regular channel
    \ Address offset: 0x19C
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM1_RDATACH                 \ [0x00 : 3] RDATACH
    $04 constant DFSDM1_RPEND                   \ [0x04] RPEND
    $08 constant DFSDM1_RDATA                   \ [0x08 : 24] RDATA
  [then]


  [ifdef] DFSDM1_DFSDM_FLT1AWHTR_DEF
    \
    \ @brief DFSDM filter 1 analog watchdog high threshold register
    \ Address offset: 0x1A0
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM1_BKAWH                   \ [0x00 : 4] BKAWH
    $08 constant DFSDM1_AWHT                    \ [0x08 : 24] AWHT
  [then]


  [ifdef] DFSDM1_DFSDM_FLT1AWLTR_DEF
    \
    \ @brief DFSDM filter 1 analog watchdog low threshold register
    \ Address offset: 0x1A4
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM1_BKAWL                   \ [0x00 : 4] BKAWL
    $08 constant DFSDM1_AWLT                    \ [0x08 : 24] AWLT
  [then]


  [ifdef] DFSDM1_DFSDM_FLT1AWSR_DEF
    \
    \ @brief DFSDM filter 1 analog watchdog status register
    \ Address offset: 0x1A8
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM1_AWLTF                   \ [0x00 : 8] AWLTF
    $08 constant DFSDM1_AWHTF                   \ [0x08 : 8] AWHTF
  [then]


  [ifdef] DFSDM1_DFSDM_FLT1AWCFR_DEF
    \
    \ @brief DFSDM filter 1 analog watchdog clear flag register
    \ Address offset: 0x1AC
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM1_CLRAWLTF                \ [0x00 : 8] CLRAWLTF
    $08 constant DFSDM1_CLRAWHTF                \ [0x08 : 8] CLRAWHTF
  [then]


  [ifdef] DFSDM1_DFSDM_FLT1EXMAX_DEF
    \
    \ @brief DFSDM filter 1 extremes detector maximum register
    \ Address offset: 0x1B0
    \ Reset value: 0x80000000
    \
    $00 constant DFSDM1_EXMAXCH                 \ [0x00 : 3] EXMAXCH
    $08 constant DFSDM1_EXMAX                   \ [0x08 : 24] EXMAX
  [then]


  [ifdef] DFSDM1_DFSDM_FLT1EXMIN_DEF
    \
    \ @brief DFSDM filter 1 extremes detector minimum register
    \ Address offset: 0x1B4
    \ Reset value: 0x7FFFFF00
    \
    $00 constant DFSDM1_EXMINCH                 \ [0x00 : 3] EXMINCH
    $08 constant DFSDM1_EXMIN                   \ [0x08 : 24] EXMIN
  [then]


  [ifdef] DFSDM1_DFSDM_FLT1CNVTIMR_DEF
    \
    \ @brief DFSDM filter 1 conversion timer register
    \ Address offset: 0x1B8
    \ Reset value: 0x00000000
    \
    $04 constant DFSDM1_CNVCNT                  \ [0x04 : 28] CNVCNT
  [then]


  [ifdef] DFSDM1_DFSDM_FLT2CR1_DEF
    \
    \ @brief DFSDM filter 2 control register 1
    \ Address offset: 0x200
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM1_DFEN                    \ [0x00] DFEN
    $01 constant DFSDM1_JSWSTART                \ [0x01] JSWSTART
    $03 constant DFSDM1_JSYNC                   \ [0x03] JSYNC
    $04 constant DFSDM1_JSCAN                   \ [0x04] JSCAN
    $05 constant DFSDM1_JDMAEN                  \ [0x05] JDMAEN
    $08 constant DFSDM1_JEXTSEL                 \ [0x08 : 5] JEXTSEL
    $0d constant DFSDM1_JEXTEN                  \ [0x0d : 2] JEXTEN
    $11 constant DFSDM1_RSWSTART                \ [0x11] RSWSTART
    $12 constant DFSDM1_RCONT                   \ [0x12] RCONT
    $13 constant DFSDM1_RSYNC                   \ [0x13] RSYNC
    $15 constant DFSDM1_RDMAEN                  \ [0x15] RDMAEN
    $18 constant DFSDM1_RCH                     \ [0x18 : 3] RCH
    $1d constant DFSDM1_FAST                    \ [0x1d] FAST
    $1e constant DFSDM1_AWFSEL                  \ [0x1e] AWFSEL
  [then]


  [ifdef] DFSDM1_DFSDM_FLT2CR2_DEF
    \
    \ @brief DFSDM filter 2 control register 2
    \ Address offset: 0x204
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM1_JEOCIE                  \ [0x00] JEOCIE
    $01 constant DFSDM1_REOCIE                  \ [0x01] REOCIE
    $02 constant DFSDM1_JOVRIE                  \ [0x02] JOVRIE
    $03 constant DFSDM1_ROVRIE                  \ [0x03] ROVRIE
    $04 constant DFSDM1_AWDIE                   \ [0x04] AWDIE
    $05 constant DFSDM1_SCDIE                   \ [0x05] SCDIE
    $06 constant DFSDM1_CKABIE                  \ [0x06] CKABIE
    $08 constant DFSDM1_EXCH                    \ [0x08 : 8] EXCH
    $10 constant DFSDM1_AWDCH                   \ [0x10 : 8] AWDCH
  [then]


  [ifdef] DFSDM1_DFSDM_FLT2ISR_DEF
    \
    \ @brief DFSDM filter 2 interrupt and status register
    \ Address offset: 0x208
    \ Reset value: 0x00FF0000
    \
    $00 constant DFSDM1_JEOCF                   \ [0x00] JEOCF
    $01 constant DFSDM1_REOCF                   \ [0x01] REOCF
    $02 constant DFSDM1_JOVRF                   \ [0x02] JOVRF
    $03 constant DFSDM1_ROVRF                   \ [0x03] ROVRF
    $04 constant DFSDM1_AWDF                    \ [0x04] AWDF
    $0d constant DFSDM1_JCIP                    \ [0x0d] JCIP
    $0e constant DFSDM1_RCIP                    \ [0x0e] RCIP
    $10 constant DFSDM1_CKABF                   \ [0x10 : 8] CKABF
    $18 constant DFSDM1_SCDF                    \ [0x18 : 8] SCDF
  [then]


  [ifdef] DFSDM1_DFSDM_FLT2ICR_DEF
    \
    \ @brief DFSDM filter 2 interrupt flag clear register
    \ Address offset: 0x20C
    \ Reset value: 0x00000000
    \
    $02 constant DFSDM1_CLRJOVRF                \ [0x02] CLRJOVRF
    $03 constant DFSDM1_CLRROVRF                \ [0x03] CLRROVRF
    $10 constant DFSDM1_CLRCKABF                \ [0x10 : 8] CLRCKABF
    $18 constant DFSDM1_CLRSCDF                 \ [0x18 : 8] CLRSCDF
  [then]


  [ifdef] DFSDM1_DFSDM_FLT2JCHGR_DEF
    \
    \ @brief DFSDM filter 2 injected channel group selection register
    \ Address offset: 0x210
    \ Reset value: 0x00000001
    \
    $00 constant DFSDM1_JCHG                    \ [0x00 : 8] JCHG
  [then]


  [ifdef] DFSDM1_DFSDM_FLT2FCR_DEF
    \
    \ @brief DFSDM filter 2 control register
    \ Address offset: 0x214
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM1_IOSR                    \ [0x00 : 8] IOSR
    $10 constant DFSDM1_FOSR                    \ [0x10 : 10] FOSR
    $1d constant DFSDM1_FORD                    \ [0x1d : 3] FORD
  [then]


  [ifdef] DFSDM1_DFSDM_FLT2JDATAR_DEF
    \
    \ @brief DFSDM filter 2 data register for injected group
    \ Address offset: 0x218
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM1_JDATACH                 \ [0x00 : 3] JDATACH
    $08 constant DFSDM1_JDATA                   \ [0x08 : 24] JDATA
  [then]


  [ifdef] DFSDM1_DFSDM_FLT2RDATAR_DEF
    \
    \ @brief DFSDM filter 2 data register for the regular channel
    \ Address offset: 0x21C
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM1_RDATACH                 \ [0x00 : 3] RDATACH
    $04 constant DFSDM1_RPEND                   \ [0x04] RPEND
    $08 constant DFSDM1_RDATA                   \ [0x08 : 24] RDATA
  [then]


  [ifdef] DFSDM1_DFSDM_FLT2AWHTR_DEF
    \
    \ @brief DFSDM filter 2 analog watchdog high threshold register
    \ Address offset: 0x220
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM1_BKAWH                   \ [0x00 : 4] BKAWH
    $08 constant DFSDM1_AWHT                    \ [0x08 : 24] AWHT
  [then]


  [ifdef] DFSDM1_DFSDM_FLT2AWLTR_DEF
    \
    \ @brief DFSDM filter 2 analog watchdog low threshold register
    \ Address offset: 0x224
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM1_BKAWL                   \ [0x00 : 4] BKAWL
    $08 constant DFSDM1_AWLT                    \ [0x08 : 24] AWLT
  [then]


  [ifdef] DFSDM1_DFSDM_FLT2AWSR_DEF
    \
    \ @brief DFSDM filter 2 analog watchdog status register
    \ Address offset: 0x228
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM1_AWLTF                   \ [0x00 : 8] AWLTF
    $08 constant DFSDM1_AWHTF                   \ [0x08 : 8] AWHTF
  [then]


  [ifdef] DFSDM1_DFSDM_FLT2AWCFR_DEF
    \
    \ @brief DFSDM filter 2 analog watchdog clear flag register
    \ Address offset: 0x22C
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM1_CLRAWLTF                \ [0x00 : 8] CLRAWLTF
    $08 constant DFSDM1_CLRAWHTF                \ [0x08 : 8] CLRAWHTF
  [then]


  [ifdef] DFSDM1_DFSDM_FLT2EXMAX_DEF
    \
    \ @brief DFSDM filter 2 extremes detector maximum register
    \ Address offset: 0x230
    \ Reset value: 0x80000000
    \
    $00 constant DFSDM1_EXMAXCH                 \ [0x00 : 3] EXMAXCH
    $08 constant DFSDM1_EXMAX                   \ [0x08 : 24] EXMAX
  [then]


  [ifdef] DFSDM1_DFSDM_FLT2EXMIN_DEF
    \
    \ @brief DFSDM filter 2 extremes detector minimum register
    \ Address offset: 0x234
    \ Reset value: 0x7FFFFF00
    \
    $00 constant DFSDM1_EXMINCH                 \ [0x00 : 3] EXMINCH
    $08 constant DFSDM1_EXMIN                   \ [0x08 : 24] EXMIN
  [then]


  [ifdef] DFSDM1_DFSDM_FLT2CNVTIMR_DEF
    \
    \ @brief DFSDM filter 2 conversion timer register
    \ Address offset: 0x238
    \ Reset value: 0x00000000
    \
    $04 constant DFSDM1_CNVCNT                  \ [0x04 : 28] CNVCNT
  [then]


  [ifdef] DFSDM1_DFSDM_FLT3CR1_DEF
    \
    \ @brief DFSDM filter 3 control register 1
    \ Address offset: 0x280
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM1_DFEN                    \ [0x00] DFEN
    $01 constant DFSDM1_JSWSTART                \ [0x01] JSWSTART
    $03 constant DFSDM1_JSYNC                   \ [0x03] JSYNC
    $04 constant DFSDM1_JSCAN                   \ [0x04] JSCAN
    $05 constant DFSDM1_JDMAEN                  \ [0x05] JDMAEN
    $08 constant DFSDM1_JEXTSEL                 \ [0x08 : 5] JEXTSEL
    $0d constant DFSDM1_JEXTEN                  \ [0x0d : 2] JEXTEN
    $11 constant DFSDM1_RSWSTART                \ [0x11] RSWSTART
    $12 constant DFSDM1_RCONT                   \ [0x12] RCONT
    $13 constant DFSDM1_RSYNC                   \ [0x13] RSYNC
    $15 constant DFSDM1_RDMAEN                  \ [0x15] RDMAEN
    $18 constant DFSDM1_RCH                     \ [0x18 : 3] RCH
    $1d constant DFSDM1_FAST                    \ [0x1d] FAST
    $1e constant DFSDM1_AWFSEL                  \ [0x1e] AWFSEL
  [then]


  [ifdef] DFSDM1_DFSDM_FLT3CR2_DEF
    \
    \ @brief DFSDM filter 3 control register 2
    \ Address offset: 0x284
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM1_JEOCIE                  \ [0x00] JEOCIE
    $01 constant DFSDM1_REOCIE                  \ [0x01] REOCIE
    $02 constant DFSDM1_JOVRIE                  \ [0x02] JOVRIE
    $03 constant DFSDM1_ROVRIE                  \ [0x03] ROVRIE
    $04 constant DFSDM1_AWDIE                   \ [0x04] AWDIE
    $05 constant DFSDM1_SCDIE                   \ [0x05] SCDIE
    $06 constant DFSDM1_CKABIE                  \ [0x06] CKABIE
    $08 constant DFSDM1_EXCH                    \ [0x08 : 8] EXCH
    $10 constant DFSDM1_AWDCH                   \ [0x10 : 8] AWDCH
  [then]


  [ifdef] DFSDM1_DFSDM_FLT3ISR_DEF
    \
    \ @brief DFSDM filter 3 interrupt and status register
    \ Address offset: 0x288
    \ Reset value: 0x00FF0000
    \
    $00 constant DFSDM1_JEOCF                   \ [0x00] JEOCF
    $01 constant DFSDM1_REOCF                   \ [0x01] REOCF
    $02 constant DFSDM1_JOVRF                   \ [0x02] JOVRF
    $03 constant DFSDM1_ROVRF                   \ [0x03] ROVRF
    $04 constant DFSDM1_AWDF                    \ [0x04] AWDF
    $0d constant DFSDM1_JCIP                    \ [0x0d] JCIP
    $0e constant DFSDM1_RCIP                    \ [0x0e] RCIP
    $10 constant DFSDM1_CKABF                   \ [0x10 : 8] CKABF
    $18 constant DFSDM1_SCDF                    \ [0x18 : 8] SCDF
  [then]


  [ifdef] DFSDM1_DFSDM_FLT3ICR_DEF
    \
    \ @brief DFSDM filter 3 interrupt flag clear register
    \ Address offset: 0x28C
    \ Reset value: 0x00000000
    \
    $02 constant DFSDM1_CLRJOVRF                \ [0x02] CLRJOVRF
    $03 constant DFSDM1_CLRROVRF                \ [0x03] CLRROVRF
    $10 constant DFSDM1_CLRCKABF                \ [0x10 : 8] CLRCKABF
    $18 constant DFSDM1_CLRSCDF                 \ [0x18 : 8] CLRSCDF
  [then]


  [ifdef] DFSDM1_DFSDM_FLT3JCHGR_DEF
    \
    \ @brief DFSDM filter 3 injected channel group selection register
    \ Address offset: 0x290
    \ Reset value: 0x00000001
    \
    $00 constant DFSDM1_JCHG                    \ [0x00 : 8] JCHG
  [then]


  [ifdef] DFSDM1_DFSDM_FLT3FCR_DEF
    \
    \ @brief DFSDM filter 3 control register
    \ Address offset: 0x294
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM1_IOSR                    \ [0x00 : 8] IOSR
    $10 constant DFSDM1_FOSR                    \ [0x10 : 10] FOSR
    $1d constant DFSDM1_FORD                    \ [0x1d : 3] FORD
  [then]


  [ifdef] DFSDM1_DFSDM_FLT3JDATAR_DEF
    \
    \ @brief DFSDM filter 3 data register for injected group
    \ Address offset: 0x298
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM1_JDATACH                 \ [0x00 : 3] JDATACH
    $08 constant DFSDM1_JDATA                   \ [0x08 : 24] JDATA
  [then]


  [ifdef] DFSDM1_DFSDM_FLT3RDATAR_DEF
    \
    \ @brief DFSDM filter 3 data register for the regular channel
    \ Address offset: 0x29C
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM1_RDATACH                 \ [0x00 : 3] RDATACH
    $04 constant DFSDM1_RPEND                   \ [0x04] RPEND
    $08 constant DFSDM1_RDATA                   \ [0x08 : 24] RDATA
  [then]


  [ifdef] DFSDM1_DFSDM_FLT3AWHTR_DEF
    \
    \ @brief DFSDM filter 3 analog watchdog high threshold register
    \ Address offset: 0x2A0
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM1_BKAWH                   \ [0x00 : 4] BKAWH
    $08 constant DFSDM1_AWHT                    \ [0x08 : 24] AWHT
  [then]


  [ifdef] DFSDM1_DFSDM_FLT3AWLTR_DEF
    \
    \ @brief DFSDM filter 3 analog watchdog low threshold register
    \ Address offset: 0x2A4
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM1_BKAWL                   \ [0x00 : 4] BKAWL
    $08 constant DFSDM1_AWLT                    \ [0x08 : 24] AWLT
  [then]


  [ifdef] DFSDM1_DFSDM_FLT3AWSR_DEF
    \
    \ @brief DFSDM filter 3 analog watchdog status register
    \ Address offset: 0x2A8
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM1_AWLTF                   \ [0x00 : 8] AWLTF
    $08 constant DFSDM1_AWHTF                   \ [0x08 : 8] AWHTF
  [then]


  [ifdef] DFSDM1_DFSDM_FLT3AWCFR_DEF
    \
    \ @brief DFSDM filter 3 analog watchdog clear flag register
    \ Address offset: 0x2AC
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM1_CLRAWLTF                \ [0x00 : 8] CLRAWLTF
    $08 constant DFSDM1_CLRAWHTF                \ [0x08 : 8] CLRAWHTF
  [then]


  [ifdef] DFSDM1_DFSDM_FLT3EXMAX_DEF
    \
    \ @brief DFSDM filter 3 extremes detector maximum register
    \ Address offset: 0x2B0
    \ Reset value: 0x80000000
    \
    $00 constant DFSDM1_EXMAXCH                 \ [0x00 : 3] EXMAXCH
    $08 constant DFSDM1_EXMAX                   \ [0x08 : 24] EXMAX
  [then]


  [ifdef] DFSDM1_DFSDM_FLT3EXMIN_DEF
    \
    \ @brief DFSDM filter 3 extremes detector minimum register
    \ Address offset: 0x2B4
    \ Reset value: 0x7FFFFF00
    \
    $00 constant DFSDM1_EXMINCH                 \ [0x00 : 3] EXMINCH
    $08 constant DFSDM1_EXMIN                   \ [0x08 : 24] EXMIN
  [then]


  [ifdef] DFSDM1_DFSDM_FLT3CNVTIMR_DEF
    \
    \ @brief DFSDM filter 3 conversion timer register
    \ Address offset: 0x2B8
    \ Reset value: 0x00000000
    \
    $04 constant DFSDM1_CNVCNT                  \ [0x04 : 28] CNVCNT
  [then]


  [ifdef] DFSDM1_DFSDM_FLT4CR1_DEF
    \
    \ @brief DFSDM filter 4 control register 1
    \ Address offset: 0x300
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM1_DFEN                    \ [0x00] DFEN
    $01 constant DFSDM1_JSWSTART                \ [0x01] JSWSTART
    $03 constant DFSDM1_JSYNC                   \ [0x03] JSYNC
    $04 constant DFSDM1_JSCAN                   \ [0x04] JSCAN
    $05 constant DFSDM1_JDMAEN                  \ [0x05] JDMAEN
    $08 constant DFSDM1_JEXTSEL                 \ [0x08 : 5] JEXTSEL
    $0d constant DFSDM1_JEXTEN                  \ [0x0d : 2] JEXTEN
    $11 constant DFSDM1_RSWSTART                \ [0x11] RSWSTART
    $12 constant DFSDM1_RCONT                   \ [0x12] RCONT
    $13 constant DFSDM1_RSYNC                   \ [0x13] RSYNC
    $15 constant DFSDM1_RDMAEN                  \ [0x15] RDMAEN
    $18 constant DFSDM1_RCH                     \ [0x18 : 3] RCH
    $1d constant DFSDM1_FAST                    \ [0x1d] FAST
    $1e constant DFSDM1_AWFSEL                  \ [0x1e] AWFSEL
  [then]


  [ifdef] DFSDM1_DFSDM_FLT4CR2_DEF
    \
    \ @brief DFSDM filter 4 control register 2
    \ Address offset: 0x304
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM1_JEOCIE                  \ [0x00] JEOCIE
    $01 constant DFSDM1_REOCIE                  \ [0x01] REOCIE
    $02 constant DFSDM1_JOVRIE                  \ [0x02] JOVRIE
    $03 constant DFSDM1_ROVRIE                  \ [0x03] ROVRIE
    $04 constant DFSDM1_AWDIE                   \ [0x04] AWDIE
    $05 constant DFSDM1_SCDIE                   \ [0x05] SCDIE
    $06 constant DFSDM1_CKABIE                  \ [0x06] CKABIE
    $08 constant DFSDM1_EXCH                    \ [0x08 : 8] EXCH
    $10 constant DFSDM1_AWDCH                   \ [0x10 : 8] AWDCH
  [then]


  [ifdef] DFSDM1_DFSDM_FLT4ISR_DEF
    \
    \ @brief DFSDM filter 4 interrupt and status register
    \ Address offset: 0x308
    \ Reset value: 0x00FF0000
    \
    $00 constant DFSDM1_JEOCF                   \ [0x00] JEOCF
    $01 constant DFSDM1_REOCF                   \ [0x01] REOCF
    $02 constant DFSDM1_JOVRF                   \ [0x02] JOVRF
    $03 constant DFSDM1_ROVRF                   \ [0x03] ROVRF
    $04 constant DFSDM1_AWDF                    \ [0x04] AWDF
    $0d constant DFSDM1_JCIP                    \ [0x0d] JCIP
    $0e constant DFSDM1_RCIP                    \ [0x0e] RCIP
    $10 constant DFSDM1_CKABF                   \ [0x10 : 8] CKABF
    $18 constant DFSDM1_SCDF                    \ [0x18 : 8] SCDF
  [then]


  [ifdef] DFSDM1_DFSDM_FLT4ICR_DEF
    \
    \ @brief DFSDM filter 4 interrupt flag clear register
    \ Address offset: 0x30C
    \ Reset value: 0x00000000
    \
    $02 constant DFSDM1_CLRJOVRF                \ [0x02] CLRJOVRF
    $03 constant DFSDM1_CLRROVRF                \ [0x03] CLRROVRF
    $10 constant DFSDM1_CLRCKABF                \ [0x10 : 8] CLRCKABF
    $18 constant DFSDM1_CLRSCDF                 \ [0x18 : 8] CLRSCDF
  [then]


  [ifdef] DFSDM1_DFSDM_FLT4JCHGR_DEF
    \
    \ @brief DFSDM filter 4 injected channel group selection register
    \ Address offset: 0x310
    \ Reset value: 0x00000001
    \
    $00 constant DFSDM1_JCHG                    \ [0x00 : 8] JCHG
  [then]


  [ifdef] DFSDM1_DFSDM_FLT4FCR_DEF
    \
    \ @brief DFSDM filter 4 control register
    \ Address offset: 0x314
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM1_IOSR                    \ [0x00 : 8] IOSR
    $10 constant DFSDM1_FOSR                    \ [0x10 : 10] FOSR
    $1d constant DFSDM1_FORD                    \ [0x1d : 3] FORD
  [then]


  [ifdef] DFSDM1_DFSDM_FLT4JDATAR_DEF
    \
    \ @brief DFSDM filter 4 data register for injected group
    \ Address offset: 0x318
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM1_JDATACH                 \ [0x00 : 3] JDATACH
    $08 constant DFSDM1_JDATA                   \ [0x08 : 24] JDATA
  [then]


  [ifdef] DFSDM1_DFSDM_FLT4RDATAR_DEF
    \
    \ @brief DFSDM filter 4 data register for the regular channel
    \ Address offset: 0x31C
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM1_RDATACH                 \ [0x00 : 3] RDATACH
    $04 constant DFSDM1_RPEND                   \ [0x04] RPEND
    $08 constant DFSDM1_RDATA                   \ [0x08 : 24] RDATA
  [then]


  [ifdef] DFSDM1_DFSDM_FLT4AWHTR_DEF
    \
    \ @brief DFSDM filter 4 analog watchdog high threshold register
    \ Address offset: 0x320
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM1_BKAWH                   \ [0x00 : 4] BKAWH
    $08 constant DFSDM1_AWHT                    \ [0x08 : 24] AWHT
  [then]


  [ifdef] DFSDM1_DFSDM_FLT4AWLTR_DEF
    \
    \ @brief DFSDM filter 4 analog watchdog low threshold register
    \ Address offset: 0x324
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM1_BKAWL                   \ [0x00 : 4] BKAWL
    $08 constant DFSDM1_AWLT                    \ [0x08 : 24] AWLT
  [then]


  [ifdef] DFSDM1_DFSDM_FLT4AWSR_DEF
    \
    \ @brief DFSDM filter 4 analog watchdog status register
    \ Address offset: 0x328
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM1_AWLTF                   \ [0x00 : 8] AWLTF
    $08 constant DFSDM1_AWHTF                   \ [0x08 : 8] AWHTF
  [then]


  [ifdef] DFSDM1_DFSDM_FLT4AWCFR_DEF
    \
    \ @brief DFSDM filter 4 analog watchdog clear flag register
    \ Address offset: 0x32C
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM1_CLRAWLTF                \ [0x00 : 8] CLRAWLTF
    $08 constant DFSDM1_CLRAWHTF                \ [0x08 : 8] CLRAWHTF
  [then]


  [ifdef] DFSDM1_DFSDM_FLT4EXMAX_DEF
    \
    \ @brief DFSDM filter 4 extremes detector maximum register
    \ Address offset: 0x330
    \ Reset value: 0x80000000
    \
    $00 constant DFSDM1_EXMAXCH                 \ [0x00 : 3] EXMAXCH
    $08 constant DFSDM1_EXMAX                   \ [0x08 : 24] EXMAX
  [then]


  [ifdef] DFSDM1_DFSDM_FLT4EXMIN_DEF
    \
    \ @brief DFSDM filter 4 extremes detector minimum register
    \ Address offset: 0x334
    \ Reset value: 0x7FFFFF00
    \
    $00 constant DFSDM1_EXMINCH                 \ [0x00 : 3] EXMINCH
    $08 constant DFSDM1_EXMIN                   \ [0x08 : 24] EXMIN
  [then]


  [ifdef] DFSDM1_DFSDM_FLT4CNVTIMR_DEF
    \
    \ @brief DFSDM filter 4 conversion timer register
    \ Address offset: 0x338
    \ Reset value: 0x00000000
    \
    $04 constant DFSDM1_CNVCNT                  \ [0x04 : 28] CNVCNT
  [then]


  [ifdef] DFSDM1_DFSDM_FLT5CR1_DEF
    \
    \ @brief DFSDM filter 5 control register 1
    \ Address offset: 0x380
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM1_DFEN                    \ [0x00] DFEN
    $01 constant DFSDM1_JSWSTART                \ [0x01] JSWSTART
    $03 constant DFSDM1_JSYNC                   \ [0x03] JSYNC
    $04 constant DFSDM1_JSCAN                   \ [0x04] JSCAN
    $05 constant DFSDM1_JDMAEN                  \ [0x05] JDMAEN
    $08 constant DFSDM1_JEXTSEL                 \ [0x08 : 5] JEXTSEL
    $0d constant DFSDM1_JEXTEN                  \ [0x0d : 2] JEXTEN
    $11 constant DFSDM1_RSWSTART                \ [0x11] RSWSTART
    $12 constant DFSDM1_RCONT                   \ [0x12] RCONT
    $13 constant DFSDM1_RSYNC                   \ [0x13] RSYNC
    $15 constant DFSDM1_RDMAEN                  \ [0x15] RDMAEN
    $18 constant DFSDM1_RCH                     \ [0x18 : 3] RCH
    $1d constant DFSDM1_FAST                    \ [0x1d] FAST
    $1e constant DFSDM1_AWFSEL                  \ [0x1e] AWFSEL
  [then]


  [ifdef] DFSDM1_DFSDM_FLT5CR2_DEF
    \
    \ @brief DFSDM filter 5 control register 2
    \ Address offset: 0x384
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM1_JEOCIE                  \ [0x00] JEOCIE
    $01 constant DFSDM1_REOCIE                  \ [0x01] REOCIE
    $02 constant DFSDM1_JOVRIE                  \ [0x02] JOVRIE
    $03 constant DFSDM1_ROVRIE                  \ [0x03] ROVRIE
    $04 constant DFSDM1_AWDIE                   \ [0x04] AWDIE
    $05 constant DFSDM1_SCDIE                   \ [0x05] SCDIE
    $06 constant DFSDM1_CKABIE                  \ [0x06] CKABIE
    $08 constant DFSDM1_EXCH                    \ [0x08 : 8] EXCH
    $10 constant DFSDM1_AWDCH                   \ [0x10 : 8] AWDCH
  [then]


  [ifdef] DFSDM1_DFSDM_FLT5ISR_DEF
    \
    \ @brief DFSDM filter 5 interrupt and status register
    \ Address offset: 0x388
    \ Reset value: 0x00FF0000
    \
    $00 constant DFSDM1_JEOCF                   \ [0x00] JEOCF
    $01 constant DFSDM1_REOCF                   \ [0x01] REOCF
    $02 constant DFSDM1_JOVRF                   \ [0x02] JOVRF
    $03 constant DFSDM1_ROVRF                   \ [0x03] ROVRF
    $04 constant DFSDM1_AWDF                    \ [0x04] AWDF
    $0d constant DFSDM1_JCIP                    \ [0x0d] JCIP
    $0e constant DFSDM1_RCIP                    \ [0x0e] RCIP
    $10 constant DFSDM1_CKABF                   \ [0x10 : 8] CKABF
    $18 constant DFSDM1_SCDF                    \ [0x18 : 8] SCDF
  [then]


  [ifdef] DFSDM1_DFSDM_FLT5ICR_DEF
    \
    \ @brief DFSDM filter 5 interrupt flag clear register
    \ Address offset: 0x38C
    \ Reset value: 0x00000000
    \
    $02 constant DFSDM1_CLRJOVRF                \ [0x02] CLRJOVRF
    $03 constant DFSDM1_CLRROVRF                \ [0x03] CLRROVRF
    $10 constant DFSDM1_CLRCKABF                \ [0x10 : 8] CLRCKABF
    $18 constant DFSDM1_CLRSCDF                 \ [0x18 : 8] CLRSCDF
  [then]


  [ifdef] DFSDM1_DFSDM_FLT5JCHGR_DEF
    \
    \ @brief DFSDM filter 5 injected channel group selection register
    \ Address offset: 0x390
    \ Reset value: 0x00000001
    \
    $00 constant DFSDM1_JCHG                    \ [0x00 : 8] JCHG
  [then]


  [ifdef] DFSDM1_DFSDM_FLT5FCR_DEF
    \
    \ @brief DFSDM filter 5 control register
    \ Address offset: 0x394
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM1_IOSR                    \ [0x00 : 8] IOSR
    $10 constant DFSDM1_FOSR                    \ [0x10 : 10] FOSR
    $1d constant DFSDM1_FORD                    \ [0x1d : 3] FORD
  [then]


  [ifdef] DFSDM1_DFSDM_FLT5JDATAR_DEF
    \
    \ @brief DFSDM filter 5 data register for injected group
    \ Address offset: 0x398
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM1_JDATACH                 \ [0x00 : 3] JDATACH
    $08 constant DFSDM1_JDATA                   \ [0x08 : 24] JDATA
  [then]


  [ifdef] DFSDM1_DFSDM_FLT5RDATAR_DEF
    \
    \ @brief DFSDM filter 5 data register for the regular channel
    \ Address offset: 0x39C
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM1_RDATACH                 \ [0x00 : 3] RDATACH
    $04 constant DFSDM1_RPEND                   \ [0x04] RPEND
    $08 constant DFSDM1_RDATA                   \ [0x08 : 24] RDATA
  [then]


  [ifdef] DFSDM1_DFSDM_FLT5AWHTR_DEF
    \
    \ @brief DFSDM filter 5 analog watchdog high threshold register
    \ Address offset: 0x3A0
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM1_BKAWH                   \ [0x00 : 4] BKAWH
    $08 constant DFSDM1_AWHT                    \ [0x08 : 24] AWHT
  [then]


  [ifdef] DFSDM1_DFSDM_FLT5AWLTR_DEF
    \
    \ @brief DFSDM filter 5 analog watchdog low threshold register
    \ Address offset: 0x3A4
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM1_BKAWL                   \ [0x00 : 4] BKAWL
    $08 constant DFSDM1_AWLT                    \ [0x08 : 24] AWLT
  [then]


  [ifdef] DFSDM1_DFSDM_FLT5AWSR_DEF
    \
    \ @brief DFSDM filter 5 analog watchdog status register
    \ Address offset: 0x3A8
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM1_AWLTF                   \ [0x00 : 8] AWLTF
    $08 constant DFSDM1_AWHTF                   \ [0x08 : 8] AWHTF
  [then]


  [ifdef] DFSDM1_DFSDM_FLT5AWCFR_DEF
    \
    \ @brief DFSDM filter 5 analog watchdog clear flag register
    \ Address offset: 0x3AC
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM1_CLRAWLTF                \ [0x00 : 8] CLRAWLTF
    $08 constant DFSDM1_CLRAWHTF                \ [0x08 : 8] CLRAWHTF
  [then]


  [ifdef] DFSDM1_DFSDM_FLT5EXMAX_DEF
    \
    \ @brief DFSDM filter 5 extremes detector maximum register
    \ Address offset: 0x3B0
    \ Reset value: 0x80000000
    \
    $00 constant DFSDM1_EXMAXCH                 \ [0x00 : 3] EXMAXCH
    $08 constant DFSDM1_EXMAX                   \ [0x08 : 24] EXMAX
  [then]


  [ifdef] DFSDM1_DFSDM_FLT5EXMIN_DEF
    \
    \ @brief DFSDM filter 5 extremes detector minimum register
    \ Address offset: 0x3B4
    \ Reset value: 0x7FFFFF00
    \
    $00 constant DFSDM1_EXMINCH                 \ [0x00 : 3] EXMINCH
    $08 constant DFSDM1_EXMIN                   \ [0x08 : 24] EXMIN
  [then]


  [ifdef] DFSDM1_DFSDM_FLT5CNVTIMR_DEF
    \
    \ @brief DFSDM filter 5 conversion timer register
    \ Address offset: 0x3B8
    \ Reset value: 0x00000000
    \
    $04 constant DFSDM1_CNVCNT                  \ [0x04 : 28] CNVCNT
  [then]


  [ifdef] DFSDM1_DFSDM_HWCFGR_DEF
    \
    \ @brief This register specifies the hardware configuration of DFSDM peripheral.
    \ Address offset: 0x7F0
    \ Reset value: 0x00000608
    \
    $00 constant DFSDM1_NBT                     \ [0x00 : 8] NBT
    $08 constant DFSDM1_NBF                     \ [0x08 : 8] NBF
  [then]


  [ifdef] DFSDM1_DFSDM_VERR_DEF
    \
    \ @brief This register specifies the version of DFSDM peripheral.
    \ Address offset: 0x7F4
    \ Reset value: 0x00000021
    \
    $00 constant DFSDM1_MINREV                  \ [0x00 : 4] MINREV
    $04 constant DFSDM1_MAJREV                  \ [0x04 : 4] MAJREV
  [then]


  [ifdef] DFSDM1_DFSDM_IPIDR_DEF
    \
    \ @brief This register specifies the identification of DFSDM peripheral.
    \ Address offset: 0x7F8
    \ Reset value: 0x00110031
    \
    $00 constant DFSDM1_ID                      \ [0x00 : 32] ID
  [then]


  [ifdef] DFSDM1_DFSDM_SIDR_DEF
    \
    \ @brief This register specifies the size allocated to DFSDM registers.
    \ Address offset: 0x7FC
    \ Reset value: 0xA3C5DD02
    \
    $00 constant DFSDM1_SID                     \ [0x00 : 32] SID
  [then]

  \
  \ @brief DFSDM1
  \
  $00 constant DFSDM1_DFSDM_CH0CFGR1    \ This register specifies the parameters used by channel y.
  $04 constant DFSDM1_DFSDM_CH0CFGR2    \ This register specifies the parameters used by channel y.
  $08 constant DFSDM1_DFSDM_CH0AWSCDR   \ Short-circuit detector and analog watchdog settings for channel y.
  $0C constant DFSDM1_DFSDM_CH0WDATR    \ This register contains the data resulting from the analog watchdog filter associated to the input channel y.
  $10 constant DFSDM1_DFSDM_CH0DATINR   \ This register contains 16-bit input data to be processed by DFSDM filter module.
  $14 constant DFSDM1_DFSDM_CH0DLYR     \ DFSDM channel 0 delay register
  $20 constant DFSDM1_DFSDM_CH1CFGR1    \ This register specifies the parameters used by channel y.
  $24 constant DFSDM1_DFSDM_CH1CFGR2    \ This register specifies the parameters used by channel y.
  $28 constant DFSDM1_DFSDM_CH1AWSCDR   \ Short-circuit detector and analog watchdog settings for channel y.
  $2C constant DFSDM1_DFSDM_CH1WDATR    \ This register contains the data resulting from the analog watchdog filter associated to the input channel y.
  $30 constant DFSDM1_DFSDM_CH1DATINR   \ This register contains 16-bit input data to be processed by DFSDM filter module.
  $34 constant DFSDM1_DFSDM_CH1DLYR     \ DFSDM channel 1 delay register
  $40 constant DFSDM1_DFSDM_CH2CFGR1    \ This register specifies the parameters used by channel y.
  $44 constant DFSDM1_DFSDM_CH2CFGR2    \ This register specifies the parameters used by channel y.
  $48 constant DFSDM1_DFSDM_CH2AWSCDR   \ Short-circuit detector and analog watchdog settings for channel y.
  $4C constant DFSDM1_DFSDM_CH2WDATR    \ This register contains the data resulting from the analog watchdog filter associated to the input channel y.
  $50 constant DFSDM1_DFSDM_CH2DATINR   \ This register contains 16-bit input data to be processed by DFSDM filter module.
  $54 constant DFSDM1_DFSDM_CH2DLYR     \ DFSDM channel 2 delay register
  $60 constant DFSDM1_DFSDM_CH3CFGR1    \ This register specifies the parameters used by channel y.
  $64 constant DFSDM1_DFSDM_CH3CFGR2    \ This register specifies the parameters used by channel y.
  $68 constant DFSDM1_DFSDM_CH3AWSCDR   \ Short-circuit detector and analog watchdog settings for channel y.
  $6C constant DFSDM1_DFSDM_CH3WDATR    \ This register contains the data resulting from the analog watchdog filter associated to the input channel y.
  $70 constant DFSDM1_DFSDM_CH3DATINR   \ This register contains 16-bit input data to be processed by DFSDM filter module.
  $74 constant DFSDM1_DFSDM_CH3DLYR     \ DFSDM channel 3 delay register
  $80 constant DFSDM1_DFSDM_CH4CFGR1    \ This register specifies the parameters used by channel y.
  $84 constant DFSDM1_DFSDM_CH4CFGR2    \ This register specifies the parameters used by channel y.
  $88 constant DFSDM1_DFSDM_CH4AWSCDR   \ Short-circuit detector and analog watchdog settings for channel y.
  $8C constant DFSDM1_DFSDM_CH4WDATR    \ This register contains the data resulting from the analog watchdog filter associated to the input channel y.
  $90 constant DFSDM1_DFSDM_CH4DATINR   \ This register contains 16-bit input data to be processed by DFSDM filter module.
  $94 constant DFSDM1_DFSDM_CH4DLYR     \ DFSDM channel 4 delay register
  $A0 constant DFSDM1_DFSDM_CH5CFGR1    \ This register specifies the parameters used by channel y.
  $A4 constant DFSDM1_DFSDM_CH5CFGR2    \ This register specifies the parameters used by channel y.
  $A8 constant DFSDM1_DFSDM_CH5AWSCDR   \ Short-circuit detector and analog watchdog settings for channel y.
  $AC constant DFSDM1_DFSDM_CH5WDATR    \ This register contains the data resulting from the analog watchdog filter associated to the input channel y.
  $B0 constant DFSDM1_DFSDM_CH5DATINR   \ This register contains 16-bit input data to be processed by DFSDM filter module.
  $B4 constant DFSDM1_DFSDM_CH5DLYR     \ DFSDM channel 5 delay register
  $C0 constant DFSDM1_DFSDM_CH6CFGR1    \ This register specifies the parameters used by channel y.
  $C4 constant DFSDM1_DFSDM_CH6CFGR2    \ This register specifies the parameters used by channel y.
  $C8 constant DFSDM1_DFSDM_CH6AWSCDR   \ Short-circuit detector and analog watchdog settings for channel y.
  $CC constant DFSDM1_DFSDM_CH6WDATR    \ This register contains the data resulting from the analog watchdog filter associated to the input channel y.
  $D0 constant DFSDM1_DFSDM_CH6DATINR   \ This register contains 16-bit input data to be processed by DFSDM filter module.
  $D4 constant DFSDM1_DFSDM_CH6DLYR     \ DFSDM channel 6 delay register
  $E0 constant DFSDM1_DFSDM_CH7CFGR1    \ This register specifies the parameters used by channel y.
  $E4 constant DFSDM1_DFSDM_CH7CFGR2    \ This register specifies the parameters used by channel y.
  $E8 constant DFSDM1_DFSDM_CH7AWSCDR   \ Short-circuit detector and analog watchdog settings for channel y.
  $EC constant DFSDM1_DFSDM_CH7WDATR    \ This register contains the data resulting from the analog watchdog filter associated to the input channel y.
  $F0 constant DFSDM1_DFSDM_CH7DATINR   \ This register contains 16-bit input data to be processed by DFSDM filter module.
  $F4 constant DFSDM1_DFSDM_CH7DLYR     \ DFSDM channel 7 delay register
  $100 constant DFSDM1_DFSDM_FLT0CR1    \ DFSDM filter 0 control register 1
  $104 constant DFSDM1_DFSDM_FLT0CR2    \ DFSDM filter 0 control register 2
  $108 constant DFSDM1_DFSDM_FLT0ISR    \ DFSDM filter 0 interrupt and status register
  $10C constant DFSDM1_DFSDM_FLT0ICR    \ DFSDM filter 0 interrupt flag clear register
  $110 constant DFSDM1_DFSDM_FLT0JCHGR  \ DFSDM filter 0 injected channel group selection register
  $114 constant DFSDM1_DFSDM_FLT0FCR    \ DFSDM filter 0 control register
  $118 constant DFSDM1_DFSDM_FLT0JDATAR \ DFSDM filter 0 data register for injected group
  $11C constant DFSDM1_DFSDM_FLT0RDATAR \ DFSDM filter 0 data register for the regular channel
  $120 constant DFSDM1_DFSDM_FLT0AWHTR  \ DFSDM filter 0 analog watchdog high threshold register
  $124 constant DFSDM1_DFSDM_FLT0AWLTR  \ DFSDM filter 0 analog watchdog low threshold register
  $128 constant DFSDM1_DFSDM_FLT0AWSR   \ DFSDM filter 0 analog watchdog status register
  $12C constant DFSDM1_DFSDM_FLT0AWCFR  \ DFSDM filter 0 analog watchdog clear flag register
  $130 constant DFSDM1_DFSDM_FLT0EXMAX  \ DFSDM filter 0 extremes detector maximum register
  $134 constant DFSDM1_DFSDM_FLT0EXMIN  \ DFSDM filter 0 extremes detector minimum register
  $138 constant DFSDM1_DFSDM_FLT0CNVTIMR    \ DFSDM filter 0 conversion timer register
  $180 constant DFSDM1_DFSDM_FLT1CR1    \ DFSDM filter 1 control register 1
  $184 constant DFSDM1_DFSDM_FLT1CR2    \ DFSDM filter 1 control register 2
  $188 constant DFSDM1_DFSDM_FLT1ISR    \ DFSDM filter 1 interrupt and status register
  $18C constant DFSDM1_DFSDM_FLT1ICR    \ DFSDM filter 1 interrupt flag clear register
  $190 constant DFSDM1_DFSDM_FLT1JCHGR  \ DFSDM filter 1 injected channel group selection register
  $194 constant DFSDM1_DFSDM_FLT1FCR    \ DFSDM filter 1 control register
  $198 constant DFSDM1_DFSDM_FLT1JDATAR \ DFSDM filter 1 data register for injected group
  $19C constant DFSDM1_DFSDM_FLT1RDATAR \ DFSDM filter 1 data register for the regular channel
  $1A0 constant DFSDM1_DFSDM_FLT1AWHTR  \ DFSDM filter 1 analog watchdog high threshold register
  $1A4 constant DFSDM1_DFSDM_FLT1AWLTR  \ DFSDM filter 1 analog watchdog low threshold register
  $1A8 constant DFSDM1_DFSDM_FLT1AWSR   \ DFSDM filter 1 analog watchdog status register
  $1AC constant DFSDM1_DFSDM_FLT1AWCFR  \ DFSDM filter 1 analog watchdog clear flag register
  $1B0 constant DFSDM1_DFSDM_FLT1EXMAX  \ DFSDM filter 1 extremes detector maximum register
  $1B4 constant DFSDM1_DFSDM_FLT1EXMIN  \ DFSDM filter 1 extremes detector minimum register
  $1B8 constant DFSDM1_DFSDM_FLT1CNVTIMR    \ DFSDM filter 1 conversion timer register
  $200 constant DFSDM1_DFSDM_FLT2CR1    \ DFSDM filter 2 control register 1
  $204 constant DFSDM1_DFSDM_FLT2CR2    \ DFSDM filter 2 control register 2
  $208 constant DFSDM1_DFSDM_FLT2ISR    \ DFSDM filter 2 interrupt and status register
  $20C constant DFSDM1_DFSDM_FLT2ICR    \ DFSDM filter 2 interrupt flag clear register
  $210 constant DFSDM1_DFSDM_FLT2JCHGR  \ DFSDM filter 2 injected channel group selection register
  $214 constant DFSDM1_DFSDM_FLT2FCR    \ DFSDM filter 2 control register
  $218 constant DFSDM1_DFSDM_FLT2JDATAR \ DFSDM filter 2 data register for injected group
  $21C constant DFSDM1_DFSDM_FLT2RDATAR \ DFSDM filter 2 data register for the regular channel
  $220 constant DFSDM1_DFSDM_FLT2AWHTR  \ DFSDM filter 2 analog watchdog high threshold register
  $224 constant DFSDM1_DFSDM_FLT2AWLTR  \ DFSDM filter 2 analog watchdog low threshold register
  $228 constant DFSDM1_DFSDM_FLT2AWSR   \ DFSDM filter 2 analog watchdog status register
  $22C constant DFSDM1_DFSDM_FLT2AWCFR  \ DFSDM filter 2 analog watchdog clear flag register
  $230 constant DFSDM1_DFSDM_FLT2EXMAX  \ DFSDM filter 2 extremes detector maximum register
  $234 constant DFSDM1_DFSDM_FLT2EXMIN  \ DFSDM filter 2 extremes detector minimum register
  $238 constant DFSDM1_DFSDM_FLT2CNVTIMR    \ DFSDM filter 2 conversion timer register
  $280 constant DFSDM1_DFSDM_FLT3CR1    \ DFSDM filter 3 control register 1
  $284 constant DFSDM1_DFSDM_FLT3CR2    \ DFSDM filter 3 control register 2
  $288 constant DFSDM1_DFSDM_FLT3ISR    \ DFSDM filter 3 interrupt and status register
  $28C constant DFSDM1_DFSDM_FLT3ICR    \ DFSDM filter 3 interrupt flag clear register
  $290 constant DFSDM1_DFSDM_FLT3JCHGR  \ DFSDM filter 3 injected channel group selection register
  $294 constant DFSDM1_DFSDM_FLT3FCR    \ DFSDM filter 3 control register
  $298 constant DFSDM1_DFSDM_FLT3JDATAR \ DFSDM filter 3 data register for injected group
  $29C constant DFSDM1_DFSDM_FLT3RDATAR \ DFSDM filter 3 data register for the regular channel
  $2A0 constant DFSDM1_DFSDM_FLT3AWHTR  \ DFSDM filter 3 analog watchdog high threshold register
  $2A4 constant DFSDM1_DFSDM_FLT3AWLTR  \ DFSDM filter 3 analog watchdog low threshold register
  $2A8 constant DFSDM1_DFSDM_FLT3AWSR   \ DFSDM filter 3 analog watchdog status register
  $2AC constant DFSDM1_DFSDM_FLT3AWCFR  \ DFSDM filter 3 analog watchdog clear flag register
  $2B0 constant DFSDM1_DFSDM_FLT3EXMAX  \ DFSDM filter 3 extremes detector maximum register
  $2B4 constant DFSDM1_DFSDM_FLT3EXMIN  \ DFSDM filter 3 extremes detector minimum register
  $2B8 constant DFSDM1_DFSDM_FLT3CNVTIMR    \ DFSDM filter 3 conversion timer register
  $300 constant DFSDM1_DFSDM_FLT4CR1    \ DFSDM filter 4 control register 1
  $304 constant DFSDM1_DFSDM_FLT4CR2    \ DFSDM filter 4 control register 2
  $308 constant DFSDM1_DFSDM_FLT4ISR    \ DFSDM filter 4 interrupt and status register
  $30C constant DFSDM1_DFSDM_FLT4ICR    \ DFSDM filter 4 interrupt flag clear register
  $310 constant DFSDM1_DFSDM_FLT4JCHGR  \ DFSDM filter 4 injected channel group selection register
  $314 constant DFSDM1_DFSDM_FLT4FCR    \ DFSDM filter 4 control register
  $318 constant DFSDM1_DFSDM_FLT4JDATAR \ DFSDM filter 4 data register for injected group
  $31C constant DFSDM1_DFSDM_FLT4RDATAR \ DFSDM filter 4 data register for the regular channel
  $320 constant DFSDM1_DFSDM_FLT4AWHTR  \ DFSDM filter 4 analog watchdog high threshold register
  $324 constant DFSDM1_DFSDM_FLT4AWLTR  \ DFSDM filter 4 analog watchdog low threshold register
  $328 constant DFSDM1_DFSDM_FLT4AWSR   \ DFSDM filter 4 analog watchdog status register
  $32C constant DFSDM1_DFSDM_FLT4AWCFR  \ DFSDM filter 4 analog watchdog clear flag register
  $330 constant DFSDM1_DFSDM_FLT4EXMAX  \ DFSDM filter 4 extremes detector maximum register
  $334 constant DFSDM1_DFSDM_FLT4EXMIN  \ DFSDM filter 4 extremes detector minimum register
  $338 constant DFSDM1_DFSDM_FLT4CNVTIMR    \ DFSDM filter 4 conversion timer register
  $380 constant DFSDM1_DFSDM_FLT5CR1    \ DFSDM filter 5 control register 1
  $384 constant DFSDM1_DFSDM_FLT5CR2    \ DFSDM filter 5 control register 2
  $388 constant DFSDM1_DFSDM_FLT5ISR    \ DFSDM filter 5 interrupt and status register
  $38C constant DFSDM1_DFSDM_FLT5ICR    \ DFSDM filter 5 interrupt flag clear register
  $390 constant DFSDM1_DFSDM_FLT5JCHGR  \ DFSDM filter 5 injected channel group selection register
  $394 constant DFSDM1_DFSDM_FLT5FCR    \ DFSDM filter 5 control register
  $398 constant DFSDM1_DFSDM_FLT5JDATAR \ DFSDM filter 5 data register for injected group
  $39C constant DFSDM1_DFSDM_FLT5RDATAR \ DFSDM filter 5 data register for the regular channel
  $3A0 constant DFSDM1_DFSDM_FLT5AWHTR  \ DFSDM filter 5 analog watchdog high threshold register
  $3A4 constant DFSDM1_DFSDM_FLT5AWLTR  \ DFSDM filter 5 analog watchdog low threshold register
  $3A8 constant DFSDM1_DFSDM_FLT5AWSR   \ DFSDM filter 5 analog watchdog status register
  $3AC constant DFSDM1_DFSDM_FLT5AWCFR  \ DFSDM filter 5 analog watchdog clear flag register
  $3B0 constant DFSDM1_DFSDM_FLT5EXMAX  \ DFSDM filter 5 extremes detector maximum register
  $3B4 constant DFSDM1_DFSDM_FLT5EXMIN  \ DFSDM filter 5 extremes detector minimum register
  $3B8 constant DFSDM1_DFSDM_FLT5CNVTIMR    \ DFSDM filter 5 conversion timer register
  $7F0 constant DFSDM1_DFSDM_HWCFGR     \ This register specifies the hardware configuration of DFSDM peripheral.
  $7F4 constant DFSDM1_DFSDM_VERR       \ This register specifies the version of DFSDM peripheral.
  $7F8 constant DFSDM1_DFSDM_IPIDR      \ This register specifies the identification of DFSDM peripheral.
  $7FC constant DFSDM1_DFSDM_SIDR       \ This register specifies the size allocated to DFSDM registers.

: DFSDM1_DEF ; [then]
