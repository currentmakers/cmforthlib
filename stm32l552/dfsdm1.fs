\
\ @file dfsdm1.fs
\ @brief Digital filter for sigma delta modulators
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] DFSDM1_DEF

  [ifdef] DFSDM1_CH0CFGR1_DEF
    \
    \ @brief channel configuration y register
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


  [ifdef] DFSDM1_CH0CFGR2_DEF
    \
    \ @brief channel configuration y register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $03 constant DFSDM1_DTRBS                   \ [0x03 : 5] DTRBS
    $08 constant DFSDM1_OFFSET                  \ [0x08 : 24] OFFSET
  [then]


  [ifdef] DFSDM1_CH0AWSCDR_DEF
    \
    \ @brief analog watchdog and short-circuit detector register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM1_SCDT                    \ [0x00 : 8] SCDT
    $0c constant DFSDM1_BKSCD                   \ [0x0c : 4] BKSCD
    $10 constant DFSDM1_AWFOSR                  \ [0x10 : 5] AWFOSR
    $16 constant DFSDM1_AWFORD                  \ [0x16 : 2] AWFORD
  [then]


  [ifdef] DFSDM1_CH0WDATR_DEF
    \
    \ @brief channel watchdog filter data register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM1_WDATA                   \ [0x00 : 16] WDATA
  [then]


  [ifdef] DFSDM1_CH0DATINR_DEF
    \
    \ @brief channel data input register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM1_INDAT0                  \ [0x00 : 16] INDAT0
    $10 constant DFSDM1_INDAT1                  \ [0x10 : 16] INDAT1
  [then]


  [ifdef] DFSDM1_CH0DLYR_DEF
    \
    \ @brief DFSDM channel y delay register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM1_PLSSKP                  \ [0x00 : 6] Pulses to skip for input data skipping function
  [then]


  [ifdef] DFSDM1_CH1CFGR1_DEF
    \
    \ @brief CHCFG1R1
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
    $10 constant DFSDM1_CKOUTDIV                \ [0x10 : 8] Output serial clock divider
    $1e constant DFSDM1_CKOUTSRC                \ [0x1e] Output serial clock source selection
    $1f constant DFSDM1_DFSDMEN                 \ [0x1f] Global enable for DFSDM interface
  [then]


  [ifdef] DFSDM1_CH1CFGR2_DEF
    \
    \ @brief CHCFG1R2
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $03 constant DFSDM1_DTRBS                   \ [0x03 : 5] DTRBS
    $08 constant DFSDM1_OFFSET                  \ [0x08 : 24] OFFSET
  [then]


  [ifdef] DFSDM1_CH1AWSCDR_DEF
    \
    \ @brief AWSCD1R
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM1_SCDT                    \ [0x00 : 8] SCDT
    $0c constant DFSDM1_BKSCD                   \ [0x0c : 4] BKSCD
    $10 constant DFSDM1_AWFOSR                  \ [0x10 : 5] AWFOSR
    $16 constant DFSDM1_AWFORD                  \ [0x16 : 2] AWFORD
  [then]


  [ifdef] DFSDM1_CH1WDATR_DEF
    \
    \ @brief CHWDAT1R
    \ Address offset: 0x2C
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM1_WDATA                   \ [0x00 : 16] WDATA
  [then]


  [ifdef] DFSDM1_CH1DATINR_DEF
    \
    \ @brief CHDATIN1R
    \ Address offset: 0x30
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM1_INDAT0                  \ [0x00 : 16] INDAT0
    $10 constant DFSDM1_INDAT1                  \ [0x10 : 16] INDAT1
  [then]


  [ifdef] DFSDM1_CH1DLYR_DEF
    \
    \ @brief DFSDM channel y delay register
    \ Address offset: 0x34
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM1_PLSSKP                  \ [0x00 : 6] PLSSKP
  [then]


  [ifdef] DFSDM1_CH2CFGR1_DEF
    \
    \ @brief CHCFG2R1
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
    $10 constant DFSDM1_CKOUTDIV                \ [0x10 : 8] Output serial clock divider
    $1e constant DFSDM1_CKOUTSRC                \ [0x1e] Output serial clock source selection
    $1f constant DFSDM1_DFSDMEN                 \ [0x1f] Global enable for DFSDM interface
  [then]


  [ifdef] DFSDM1_CH2CFGR2_DEF
    \
    \ @brief CHCFG2R2
    \ Address offset: 0x44
    \ Reset value: 0x00000000
    \
    $03 constant DFSDM1_DTRBS                   \ [0x03 : 5] DTRBS
    $08 constant DFSDM1_OFFSET                  \ [0x08 : 24] OFFSET
  [then]


  [ifdef] DFSDM1_CH2AWSCDR_DEF
    \
    \ @brief AWSCD2R
    \ Address offset: 0x48
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM1_SCDT                    \ [0x00 : 8] SCDT
    $0c constant DFSDM1_BKSCD                   \ [0x0c : 4] BKSCD
    $10 constant DFSDM1_AWFOSR                  \ [0x10 : 5] AWFOSR
    $16 constant DFSDM1_AWFORD                  \ [0x16 : 2] AWFORD
  [then]


  [ifdef] DFSDM1_CH2WDATR_DEF
    \
    \ @brief CHWDAT2R
    \ Address offset: 0x4C
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM1_WDATA                   \ [0x00 : 16] WDATA
  [then]


  [ifdef] DFSDM1_CH2DATINR_DEF
    \
    \ @brief CHDATIN2R
    \ Address offset: 0x50
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM1_INDAT0                  \ [0x00 : 16] INDAT0
    $10 constant DFSDM1_INDAT1                  \ [0x10 : 16] INDAT1
  [then]


  [ifdef] DFSDM1_CH2DLYR_DEF
    \
    \ @brief DFSDM channel y delay register
    \ Address offset: 0x54
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM1_PLSSKP                  \ [0x00 : 6] PLSSKP
  [then]


  [ifdef] DFSDM1_CH3CFGR1_DEF
    \
    \ @brief CHCFG3R1
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
    $10 constant DFSDM1_CKOUTDIV                \ [0x10 : 8] Output serial clock divider
    $1e constant DFSDM1_CKOUTSRC                \ [0x1e] Output serial clock source selection
    $1f constant DFSDM1_DFSDMEN                 \ [0x1f] Global enable for DFSDM interface
  [then]


  [ifdef] DFSDM1_CH3CFGR2_DEF
    \
    \ @brief CHCFG3R2
    \ Address offset: 0x64
    \ Reset value: 0x00000000
    \
    $03 constant DFSDM1_DTRBS                   \ [0x03 : 5] DTRBS
    $08 constant DFSDM1_OFFSET                  \ [0x08 : 24] OFFSET
  [then]


  [ifdef] DFSDM1_CH3AWSCDR_DEF
    \
    \ @brief AWSCD3R
    \ Address offset: 0x68
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM1_SCDT                    \ [0x00 : 8] SCDT
    $0c constant DFSDM1_BKSCD                   \ [0x0c : 4] BKSCD
    $10 constant DFSDM1_AWFOSR                  \ [0x10 : 5] AWFOSR
    $16 constant DFSDM1_AWFORD                  \ [0x16 : 2] AWFORD
  [then]


  [ifdef] DFSDM1_CH3WDATR_DEF
    \
    \ @brief CHWDAT3R
    \ Address offset: 0x6C
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM1_WDATA                   \ [0x00 : 16] WDATA
  [then]


  [ifdef] DFSDM1_CH3DATINR_DEF
    \
    \ @brief CHDATIN3R
    \ Address offset: 0x70
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM1_INDAT0                  \ [0x00 : 16] INDAT0
    $10 constant DFSDM1_INDAT1                  \ [0x10 : 16] INDAT1
  [then]


  [ifdef] DFSDM1_CH3DLYR_DEF
    \
    \ @brief DFSDM channel y delay register
    \ Address offset: 0x74
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM1_PLSSKP                  \ [0x00 : 6] PLSSKP
  [then]


  [ifdef] DFSDM1_CH4CFGR1_DEF
    \
    \ @brief CHCFG4R1
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
    $10 constant DFSDM1_CKOUTDIV                \ [0x10 : 8] Output serial clock divider
    $1e constant DFSDM1_CKOUTSRC                \ [0x1e] Output serial clock source selection
    $1f constant DFSDM1_DFSDMEN                 \ [0x1f] Global enable for DFSDM interface
  [then]


  [ifdef] DFSDM1_CH4CFGR2_DEF
    \
    \ @brief CHCFG4R2
    \ Address offset: 0x84
    \ Reset value: 0x00000000
    \
    $03 constant DFSDM1_DTRBS                   \ [0x03 : 5] DTRBS
    $08 constant DFSDM1_OFFSET                  \ [0x08 : 24] OFFSET
  [then]


  [ifdef] DFSDM1_CH4AWSCDR_DEF
    \
    \ @brief AWSCD4R
    \ Address offset: 0x88
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM1_SCDT                    \ [0x00 : 8] SCDT
    $0c constant DFSDM1_BKSCD                   \ [0x0c : 4] BKSCD
    $10 constant DFSDM1_AWFOSR                  \ [0x10 : 5] AWFOSR
    $16 constant DFSDM1_AWFORD                  \ [0x16 : 2] AWFORD
  [then]


  [ifdef] DFSDM1_CH4WDATR_DEF
    \
    \ @brief CHWDAT4R
    \ Address offset: 0x8C
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM1_WDATA                   \ [0x00 : 16] WDATA
  [then]


  [ifdef] DFSDM1_CH4DATINR_DEF
    \
    \ @brief CHDATIN4R
    \ Address offset: 0x90
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM1_INDAT0                  \ [0x00 : 16] INDAT0
    $10 constant DFSDM1_INDAT1                  \ [0x10 : 16] INDAT1
  [then]


  [ifdef] DFSDM1_CH4DLYR_DEF
    \
    \ @brief DFSDM channel y delay register
    \ Address offset: 0x94
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM1_PLSSKP                  \ [0x00 : 6] PLSSKP
  [then]


  [ifdef] DFSDM1_CH5CFGR1_DEF
    \
    \ @brief CHCFG5R1
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
    $10 constant DFSDM1_CKOUTDIV                \ [0x10 : 8] Output serial clock divider
    $1e constant DFSDM1_CKOUTSRC                \ [0x1e] Output serial clock source selection
    $1f constant DFSDM1_DFSDMEN                 \ [0x1f] Global enable for DFSDM interface
  [then]


  [ifdef] DFSDM1_CH5CFGR2_DEF
    \
    \ @brief CHCFG5R2
    \ Address offset: 0xA4
    \ Reset value: 0x00000000
    \
    $03 constant DFSDM1_DTRBS                   \ [0x03 : 5] DTRBS
    $08 constant DFSDM1_OFFSET                  \ [0x08 : 24] OFFSET
  [then]


  [ifdef] DFSDM1_CH5AWSCDR_DEF
    \
    \ @brief AWSCD5R
    \ Address offset: 0xA8
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM1_SCDT                    \ [0x00 : 8] SCDT
    $0c constant DFSDM1_BKSCD                   \ [0x0c : 4] BKSCD
    $10 constant DFSDM1_AWFOSR                  \ [0x10 : 5] AWFOSR
    $16 constant DFSDM1_AWFORD                  \ [0x16 : 2] AWFORD
  [then]


  [ifdef] DFSDM1_CH5WDATR_DEF
    \
    \ @brief CHWDAT5R
    \ Address offset: 0xAC
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM1_WDATA                   \ [0x00 : 16] WDATA
  [then]


  [ifdef] DFSDM1_CH5DATINR_DEF
    \
    \ @brief CHDATIN5R
    \ Address offset: 0xB0
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM1_INDAT0                  \ [0x00 : 16] INDAT0
    $10 constant DFSDM1_INDAT1                  \ [0x10 : 16] INDAT1
  [then]


  [ifdef] DFSDM1_CH5DLYR_DEF
    \
    \ @brief DFSDM channel y delay register
    \ Address offset: 0xB4
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM1_PLSSKP                  \ [0x00 : 6] read-only
  [then]


  [ifdef] DFSDM1_CH6CFGR1_DEF
    \
    \ @brief CHCFG6R1
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
    $10 constant DFSDM1_CKOUTDIV                \ [0x10 : 8] Output serial clock divider
    $1e constant DFSDM1_CKOUTSRC                \ [0x1e] Output serial clock source selection
    $1f constant DFSDM1_DFSDMEN                 \ [0x1f] Global enable for DFSDM interface
  [then]


  [ifdef] DFSDM1_CH6CFGR2_DEF
    \
    \ @brief CH6CFGR2
    \ Address offset: 0xC4
    \ Reset value: 0x00000000
    \
    $03 constant DFSDM1_DTRBS                   \ [0x03 : 5] DTRBS
    $08 constant DFSDM1_OFFSET                  \ [0x08 : 24] OFFSET
  [then]


  [ifdef] DFSDM1_CH6AWSCDR_DEF
    \
    \ @brief AWSCD6R
    \ Address offset: 0xC8
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM1_SCDT                    \ [0x00 : 8] SCDT
    $0c constant DFSDM1_BKSCD                   \ [0x0c : 4] BKSCD
    $10 constant DFSDM1_AWFOSR                  \ [0x10 : 5] AWFOSR
    $16 constant DFSDM1_AWFORD                  \ [0x16 : 2] AWFORD
  [then]


  [ifdef] DFSDM1_CH6WDATR_DEF
    \
    \ @brief CHWDAT6R
    \ Address offset: 0xCC
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM1_WDATA                   \ [0x00 : 16] WDATA
  [then]


  [ifdef] DFSDM1_CH6DATINR_DEF
    \
    \ @brief CHDATIN6R
    \ Address offset: 0xD0
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM1_INDAT0                  \ [0x00 : 16] INDAT0
    $10 constant DFSDM1_INDAT1                  \ [0x10 : 16] INDAT1
  [then]


  [ifdef] DFSDM1_CH6DLYR_DEF
    \
    \ @brief DFSDM channel y delay register
    \ Address offset: 0xD4
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM1_PLSSKP                  \ [0x00 : 6] PLSSKP
  [then]


  [ifdef] DFSDM1_CH7CFGR1_DEF
    \
    \ @brief CHCFG7R1
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
    $10 constant DFSDM1_CKOUTDIV                \ [0x10 : 8] Output serial clock divider
    $1e constant DFSDM1_CKOUTSRC                \ [0x1e] Output serial clock source selection
    $1f constant DFSDM1_DFSDMEN                 \ [0x1f] Global enable for DFSDM interface
  [then]


  [ifdef] DFSDM1_CH7CFGR2_DEF
    \
    \ @brief CHCFG7R2
    \ Address offset: 0xE4
    \ Reset value: 0x00000000
    \
    $03 constant DFSDM1_DTRBS                   \ [0x03 : 5] DTRBS
    $08 constant DFSDM1_OFFSET                  \ [0x08 : 24] OFFSET
  [then]


  [ifdef] DFSDM1_CH7AWSCDR_DEF
    \
    \ @brief AWSCD7R
    \ Address offset: 0xE8
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM1_SCDT                    \ [0x00 : 8] SCDT
    $0c constant DFSDM1_BKSCD                   \ [0x0c : 4] BKSCD
    $10 constant DFSDM1_AWFOSR                  \ [0x10 : 5] AWFOSR
    $16 constant DFSDM1_AWFORD                  \ [0x16 : 2] AWFORD
  [then]


  [ifdef] DFSDM1_CH7WDATR_DEF
    \
    \ @brief CHWDAT7R
    \ Address offset: 0xEC
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM1_WDATA                   \ [0x00 : 16] WDATA
  [then]


  [ifdef] DFSDM1_CH7DATINR_DEF
    \
    \ @brief CHDATIN7R
    \ Address offset: 0xF0
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM1_INDAT0                  \ [0x00 : 16] INDAT0
    $10 constant DFSDM1_INDAT1                  \ [0x10 : 16] INDAT1
  [then]


  [ifdef] DFSDM1_CH7DLYR_DEF
    \
    \ @brief DFSDM channel y delay register
    \ Address offset: 0xF4
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM1_PLSSKP                  \ [0x00 : 6] PLSSKP
  [then]


  [ifdef] DFSDM1_FLT0CR1_DEF
    \
    \ @brief control register 1
    \ Address offset: 0x100
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM1_DFEN                    \ [0x00] DFSDM enable
    $01 constant DFSDM1_JSWSTART                \ [0x01] Start a conversion of the injected group of channels
    $03 constant DFSDM1_JSYNC                   \ [0x03] Launch an injected conversion synchronously with the DFSDM0 JSWSTART trigger
    $04 constant DFSDM1_JSCAN                   \ [0x04] Scanning conversion mode for injected conversions
    $05 constant DFSDM1_JDMAEN                  \ [0x05] DMA channel enabled to read data for the injected channel group
    $08 constant DFSDM1_JEXTSEL                 \ [0x08 : 3] Trigger signal selection for launching injected conversions
    $0d constant DFSDM1_JEXTEN                  \ [0x0d : 2] Trigger enable and trigger edge selection for injected conversions
    $11 constant DFSDM1_RSWSTART                \ [0x11] Software start of a conversion on the regular channel
    $12 constant DFSDM1_RCONT                   \ [0x12] Continuous mode selection for regular conversions
    $13 constant DFSDM1_RSYNC                   \ [0x13] Launch regular conversion synchronously with DFSDM0
    $15 constant DFSDM1_RDMAEN                  \ [0x15] DMA channel enabled to read data for the regular conversion
    $18 constant DFSDM1_RCH                     \ [0x18 : 3] Regular channel selection
    $1d constant DFSDM1_FAST                    \ [0x1d] Fast conversion mode selection for regular conversions
    $1e constant DFSDM1_AWFSEL                  \ [0x1e] Analog watchdog fast mode select
  [then]


  [ifdef] DFSDM1_FLT0CR2_DEF
    \
    \ @brief control register 2
    \ Address offset: 0x104
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM1_JEOCIE                  \ [0x00] Injected end of conversion interrupt enable
    $01 constant DFSDM1_REOCIE                  \ [0x01] Regular end of conversion interrupt enable
    $02 constant DFSDM1_JOVRIE                  \ [0x02] Injected data overrun interrupt enable
    $03 constant DFSDM1_ROVRIE                  \ [0x03] Regular data overrun interrupt enable
    $04 constant DFSDM1_AWDIE                   \ [0x04] Analog watchdog interrupt enable
    $05 constant DFSDM1_SCDIE                   \ [0x05] Short-circuit detector interrupt enable
    $06 constant DFSDM1_CKABIE                  \ [0x06] Clock absence interrupt enable
    $08 constant DFSDM1_EXCH                    \ [0x08 : 8] Extremes detector channel selection
    $10 constant DFSDM1_AWDCH                   \ [0x10 : 8] Analog watchdog channel selection
  [then]


  [ifdef] DFSDM1_FLT0ISR_DEF
    \
    \ @brief interrupt and status register
    \ Address offset: 0x108
    \ Reset value: 0x00FF0000
    \
    $00 constant DFSDM1_JEOCF                   \ [0x00] End of injected conversion flag
    $01 constant DFSDM1_REOCF                   \ [0x01] End of regular conversion flag
    $02 constant DFSDM1_JOVRF                   \ [0x02] Injected conversion overrun flag
    $03 constant DFSDM1_ROVRF                   \ [0x03] Regular conversion overrun flag
    $04 constant DFSDM1_AWDF                    \ [0x04] Analog watchdog
    $0d constant DFSDM1_JCIP                    \ [0x0d] Injected conversion in progress status
    $0e constant DFSDM1_RCIP                    \ [0x0e] Regular conversion in progress status
    $10 constant DFSDM1_CKABF                   \ [0x10 : 8] Clock absence flag
    $18 constant DFSDM1_SCDF                    \ [0x18 : 8] short-circuit detector flag
  [then]


  [ifdef] DFSDM1_FLT0ICR_DEF
    \
    \ @brief interrupt flag clear register
    \ Address offset: 0x10C
    \ Reset value: 0x00000000
    \
    $02 constant DFSDM1_CLRJOVRF                \ [0x02] Clear the injected conversion overrun flag
    $03 constant DFSDM1_CLRROVRF                \ [0x03] Clear the regular conversion overrun flag
    $10 constant DFSDM1_CLRCKABF                \ [0x10 : 8] Clear the clock absence flag
    $18 constant DFSDM1_CLRSCDF                 \ [0x18 : 8] Clear the short-circuit detector flag
  [then]


  [ifdef] DFSDM1_FLT0JCHGR_DEF
    \
    \ @brief injected channel group selection register
    \ Address offset: 0x110
    \ Reset value: 0x00000001
    \
    $00 constant DFSDM1_JCHG                    \ [0x00 : 8] Injected channel group selection
  [then]


  [ifdef] DFSDM1_FLT0FCR_DEF
    \
    \ @brief filter control register
    \ Address offset: 0x114
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM1_IOSR                    \ [0x00 : 8] Integrator oversampling ratio (averaging length)
    $10 constant DFSDM1_FOSR                    \ [0x10 : 10] Sinc filter oversampling ratio (decimation rate)
    $1d constant DFSDM1_FORD                    \ [0x1d : 3] Sinc filter order
  [then]


  [ifdef] DFSDM1_FLT0JDATAR_DEF
    \
    \ @brief data register for injected group
    \ Address offset: 0x118
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM1_JDATACH                 \ [0x00 : 3] Injected channel most recently converted
    $08 constant DFSDM1_JDATA                   \ [0x08 : 24] Injected group conversion data
  [then]


  [ifdef] DFSDM1_FLT0RDATAR_DEF
    \
    \ @brief data register for the regular channel
    \ Address offset: 0x11C
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM1_RDATACH                 \ [0x00 : 3] Regular channel most recently converted
    $04 constant DFSDM1_RPEND                   \ [0x04] Regular channel pending data
    $08 constant DFSDM1_RDATA                   \ [0x08 : 24] Regular channel conversion data
  [then]


  [ifdef] DFSDM1_FLT0AWHTR_DEF
    \
    \ @brief analog watchdog high threshold register
    \ Address offset: 0x120
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM1_BKAWH                   \ [0x00 : 4] Break signal assignment to analog watchdog high threshold event
    $08 constant DFSDM1_AWHT                    \ [0x08 : 24] Analog watchdog high threshold
  [then]


  [ifdef] DFSDM1_FLT0AWLTR_DEF
    \
    \ @brief analog watchdog low threshold register
    \ Address offset: 0x124
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM1_BKAWL                   \ [0x00 : 4] Break signal assignment to analog watchdog low threshold event
    $08 constant DFSDM1_AWLT                    \ [0x08 : 24] Analog watchdog low threshold
  [then]


  [ifdef] DFSDM1_FLT0AWSR_DEF
    \
    \ @brief analog watchdog status register
    \ Address offset: 0x128
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM1_AWLTF                   \ [0x00 : 8] Analog watchdog low threshold flag
    $08 constant DFSDM1_AWHTF                   \ [0x08 : 8] Analog watchdog high threshold flag
  [then]


  [ifdef] DFSDM1_FLT0AWCFR_DEF
    \
    \ @brief analog watchdog clear flag register
    \ Address offset: 0x12C
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM1_CLRAWLTF                \ [0x00 : 8] Clear the analog watchdog low threshold flag
    $08 constant DFSDM1_CLRAWHTF                \ [0x08 : 8] Clear the analog watchdog high threshold flag
  [then]


  [ifdef] DFSDM1_FLT0EXMAX_DEF
    \
    \ @brief Extremes detector maximum register
    \ Address offset: 0x130
    \ Reset value: 0x80000000
    \
    $00 constant DFSDM1_EXMAXCH                 \ [0x00 : 3] Extremes detector maximum data channel
    $08 constant DFSDM1_EXMAX                   \ [0x08 : 24] Extremes detector maximum value
  [then]


  [ifdef] DFSDM1_FLT0EXMIN_DEF
    \
    \ @brief Extremes detector minimum register
    \ Address offset: 0x134
    \ Reset value: 0x7FFFFF00
    \
    $00 constant DFSDM1_EXMINCH                 \ [0x00 : 3] Extremes detector minimum data channel
    $08 constant DFSDM1_EXMIN                   \ [0x08 : 24] EXMIN
  [then]


  [ifdef] DFSDM1_FLT0CNVTIMR_DEF
    \
    \ @brief conversion timer register
    \ Address offset: 0x138
    \ Reset value: 0x00000000
    \
    $04 constant DFSDM1_CNVCNT                  \ [0x04 : 28] 28-bit timer counting conversion time t = CNVCNT[27:0] / fDFSDM_CKIN
  [then]


  [ifdef] DFSDM1_FLT1CR1_DEF
    \
    \ @brief control register 1
    \ Address offset: 0x180
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM1_DFEN                    \ [0x00] DFSDM enable
    $01 constant DFSDM1_JSWSTART                \ [0x01] Start a conversion of the injected group of channels
    $03 constant DFSDM1_JSYNC                   \ [0x03] Launch an injected conversion synchronously with the DFSDM0 JSWSTART trigger
    $04 constant DFSDM1_JSCAN                   \ [0x04] Scanning conversion mode for injected conversions
    $05 constant DFSDM1_JDMAEN                  \ [0x05] DMA channel enabled to read data for the injected channel group
    $08 constant DFSDM1_JEXTSEL                 \ [0x08 : 3] Trigger signal selection for launching injected conversions
    $0d constant DFSDM1_JEXTEN                  \ [0x0d : 2] Trigger enable and trigger edge selection for injected conversions
    $11 constant DFSDM1_RSWSTART                \ [0x11] Software start of a conversion on the regular channel
    $12 constant DFSDM1_RCONT                   \ [0x12] Continuous mode selection for regular conversions
    $13 constant DFSDM1_RSYNC                   \ [0x13] Launch regular conversion synchronously with DFSDM0
    $15 constant DFSDM1_RDMAEN                  \ [0x15] DMA channel enabled to read data for the regular conversion
    $18 constant DFSDM1_RCH                     \ [0x18 : 3] Regular channel selection
    $1d constant DFSDM1_FAST                    \ [0x1d] Fast conversion mode selection for regular conversions
    $1e constant DFSDM1_AWFSEL                  \ [0x1e] Analog watchdog fast mode select
  [then]


  [ifdef] DFSDM1_FLT1CR2_DEF
    \
    \ @brief control register 2
    \ Address offset: 0x184
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM1_JEOCIE                  \ [0x00] Injected end of conversion interrupt enable
    $01 constant DFSDM1_REOCIE                  \ [0x01] Regular end of conversion interrupt enable
    $02 constant DFSDM1_JOVRIE                  \ [0x02] Injected data overrun interrupt enable
    $03 constant DFSDM1_ROVRIE                  \ [0x03] Regular data overrun interrupt enable
    $04 constant DFSDM1_AWDIE                   \ [0x04] Analog watchdog interrupt enable
    $05 constant DFSDM1_SCDIE                   \ [0x05] Short-circuit detector interrupt enable
    $06 constant DFSDM1_CKABIE                  \ [0x06] Clock absence interrupt enable
    $08 constant DFSDM1_EXCH                    \ [0x08 : 8] Extremes detector channel selection
    $10 constant DFSDM1_AWDCH                   \ [0x10 : 8] Analog watchdog channel selection
  [then]


  [ifdef] DFSDM1_FLT1ISR_DEF
    \
    \ @brief interrupt and status register
    \ Address offset: 0x188
    \ Reset value: 0x00FF0000
    \
    $00 constant DFSDM1_JEOCF                   \ [0x00] End of injected conversion flag
    $01 constant DFSDM1_REOCF                   \ [0x01] End of regular conversion flag
    $02 constant DFSDM1_JOVRF                   \ [0x02] Injected conversion overrun flag
    $03 constant DFSDM1_ROVRF                   \ [0x03] Regular conversion overrun flag
    $04 constant DFSDM1_AWDF                    \ [0x04] Analog watchdog
    $0d constant DFSDM1_JCIP                    \ [0x0d] Injected conversion in progress status
    $0e constant DFSDM1_RCIP                    \ [0x0e] Regular conversion in progress status
    $10 constant DFSDM1_CKABF                   \ [0x10 : 8] Clock absence flag
    $18 constant DFSDM1_SCDF                    \ [0x18 : 8] short-circuit detector flag
  [then]


  [ifdef] DFSDM1_FLT1ICR_DEF
    \
    \ @brief interrupt flag clear register
    \ Address offset: 0x18C
    \ Reset value: 0x00000000
    \
    $02 constant DFSDM1_CLRJOVRF                \ [0x02] Clear the injected conversion overrun flag
    $03 constant DFSDM1_CLRROVRF                \ [0x03] Clear the regular conversion overrun flag
    $10 constant DFSDM1_CLRCKABF                \ [0x10 : 8] Clear the clock absence flag
    $18 constant DFSDM1_CLRSCDF                 \ [0x18 : 8] Clear the short-circuit detector flag
  [then]


  [ifdef] DFSDM1_FLT1JCHGR_DEF
    \
    \ @brief injected channel group selection register
    \ Address offset: 0x190
    \ Reset value: 0x00000001
    \
    $00 constant DFSDM1_JCHG                    \ [0x00 : 8] Injected channel group selection
  [then]


  [ifdef] DFSDM1_FLT1FCR_DEF
    \
    \ @brief filter control register
    \ Address offset: 0x194
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM1_IOSR                    \ [0x00 : 8] Integrator oversampling ratio (averaging length)
    $10 constant DFSDM1_FOSR                    \ [0x10 : 10] Sinc filter oversampling ratio (decimation rate)
    $1d constant DFSDM1_FORD                    \ [0x1d : 3] Sinc filter order
  [then]


  [ifdef] DFSDM1_FLT1JDATAR_DEF
    \
    \ @brief data register for injected group
    \ Address offset: 0x198
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM1_JDATACH                 \ [0x00 : 3] Injected channel most recently converted
    $08 constant DFSDM1_JDATA                   \ [0x08 : 24] Injected group conversion data
  [then]


  [ifdef] DFSDM1_FLT1RDATAR_DEF
    \
    \ @brief data register for the regular channel
    \ Address offset: 0x19C
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM1_RDATACH                 \ [0x00 : 3] Regular channel most recently converted
    $04 constant DFSDM1_RPEND                   \ [0x04] Regular channel pending data
    $08 constant DFSDM1_RDATA                   \ [0x08 : 24] Regular channel conversion data
  [then]


  [ifdef] DFSDM1_FLT1AWLTR_DEF
    \
    \ @brief analog watchdog low threshold register
    \ Address offset: 0x1A4
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM1_BKAWL                   \ [0x00 : 4] Break signal assignment to analog watchdog low threshold event
    $08 constant DFSDM1_AWLT                    \ [0x08 : 24] Analog watchdog low threshold
  [then]


  [ifdef] DFSDM1_FLT1AWSR_DEF
    \
    \ @brief analog watchdog status register
    \ Address offset: 0x1A8
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM1_AWLTF                   \ [0x00 : 8] Analog watchdog low threshold flag
    $08 constant DFSDM1_AWHTF                   \ [0x08 : 8] Analog watchdog high threshold flag
  [then]


  [ifdef] DFSDM1_FLT1AWHTR_DEF
    \
    \ @brief analog watchdog high threshold register
    \ Address offset: 0x1AC
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM1_BKAWH                   \ [0x00 : 4] Break signal assignment to analog watchdog high threshold event
    $08 constant DFSDM1_AWHT                    \ [0x08 : 24] Analog watchdog high threshold
  [then]


  [ifdef] DFSDM1_FLT1AWCFR_DEF
    \
    \ @brief analog watchdog clear flag register
    \ Address offset: 0x1AC
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM1_CLRAWLTF                \ [0x00 : 8] Clear the analog watchdog low threshold flag
    $08 constant DFSDM1_CLRAWHTF                \ [0x08 : 8] Clear the analog watchdog high threshold flag
  [then]


  [ifdef] DFSDM1_FLT1EXMAX_DEF
    \
    \ @brief Extremes detector maximum register
    \ Address offset: 0x1B0
    \ Reset value: 0x80000000
    \
    $00 constant DFSDM1_EXMAXCH                 \ [0x00 : 3] Extremes detector maximum data channel
    $08 constant DFSDM1_EXMAX                   \ [0x08 : 24] Extremes detector maximum value
  [then]


  [ifdef] DFSDM1_FLT1EXMIN_DEF
    \
    \ @brief Extremes detector minimum register
    \ Address offset: 0x1B4
    \ Reset value: 0x7FFFFF00
    \
    $00 constant DFSDM1_EXMINCH                 \ [0x00 : 3] Extremes detector minimum data channel
    $08 constant DFSDM1_EXMIN                   \ [0x08 : 24] EXMIN
  [then]


  [ifdef] DFSDM1_FLT1CNVTIMR_DEF
    \
    \ @brief conversion timer register
    \ Address offset: 0x1B8
    \ Reset value: 0x00000000
    \
    $04 constant DFSDM1_CNVCNT                  \ [0x04 : 28] 28-bit timer counting conversion time t = CNVCNT[27:0] / fDFSDM_CKIN
  [then]


  [ifdef] DFSDM1_FLT2CR1_DEF
    \
    \ @brief control register 1
    \ Address offset: 0x200
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM1_DFEN                    \ [0x00] DFSDM enable
    $01 constant DFSDM1_JSWSTART                \ [0x01] Start a conversion of the injected group of channels
    $03 constant DFSDM1_JSYNC                   \ [0x03] Launch an injected conversion synchronously with the DFSDM0 JSWSTART trigger
    $04 constant DFSDM1_JSCAN                   \ [0x04] Scanning conversion mode for injected conversions
    $05 constant DFSDM1_JDMAEN                  \ [0x05] DMA channel enabled to read data for the injected channel group
    $08 constant DFSDM1_JEXTSEL                 \ [0x08 : 3] Trigger signal selection for launching injected conversions
    $0d constant DFSDM1_JEXTEN                  \ [0x0d : 2] Trigger enable and trigger edge selection for injected conversions
    $11 constant DFSDM1_RSWSTART                \ [0x11] Software start of a conversion on the regular channel
    $12 constant DFSDM1_RCONT                   \ [0x12] Continuous mode selection for regular conversions
    $13 constant DFSDM1_RSYNC                   \ [0x13] Launch regular conversion synchronously with DFSDM0
    $15 constant DFSDM1_RDMAEN                  \ [0x15] DMA channel enabled to read data for the regular conversion
    $18 constant DFSDM1_RCH                     \ [0x18 : 3] Regular channel selection
    $1d constant DFSDM1_FAST                    \ [0x1d] Fast conversion mode selection for regular conversions
    $1e constant DFSDM1_AWFSEL                  \ [0x1e] Analog watchdog fast mode select
  [then]


  [ifdef] DFSDM1_FLT2CR2_DEF
    \
    \ @brief control register 2
    \ Address offset: 0x204
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM1_JEOCIE                  \ [0x00] Injected end of conversion interrupt enable
    $01 constant DFSDM1_REOCIE                  \ [0x01] Regular end of conversion interrupt enable
    $02 constant DFSDM1_JOVRIE                  \ [0x02] Injected data overrun interrupt enable
    $03 constant DFSDM1_ROVRIE                  \ [0x03] Regular data overrun interrupt enable
    $04 constant DFSDM1_AWDIE                   \ [0x04] Analog watchdog interrupt enable
    $05 constant DFSDM1_SCDIE                   \ [0x05] Short-circuit detector interrupt enable
    $06 constant DFSDM1_CKABIE                  \ [0x06] Clock absence interrupt enable
    $08 constant DFSDM1_EXCH                    \ [0x08 : 8] Extremes detector channel selection
    $10 constant DFSDM1_AWDCH                   \ [0x10 : 8] Analog watchdog channel selection
  [then]


  [ifdef] DFSDM1_FLT2ISR_DEF
    \
    \ @brief interrupt and status register
    \ Address offset: 0x208
    \ Reset value: 0x00FF0000
    \
    $00 constant DFSDM1_JEOCF                   \ [0x00] End of injected conversion flag
    $01 constant DFSDM1_REOCF                   \ [0x01] End of regular conversion flag
    $02 constant DFSDM1_JOVRF                   \ [0x02] Injected conversion overrun flag
    $03 constant DFSDM1_ROVRF                   \ [0x03] Regular conversion overrun flag
    $04 constant DFSDM1_AWDF                    \ [0x04] Analog watchdog
    $0d constant DFSDM1_JCIP                    \ [0x0d] Injected conversion in progress status
    $0e constant DFSDM1_RCIP                    \ [0x0e] Regular conversion in progress status
    $10 constant DFSDM1_CKABF                   \ [0x10 : 8] Clock absence flag
    $18 constant DFSDM1_SCDF                    \ [0x18 : 8] short-circuit detector flag
  [then]


  [ifdef] DFSDM1_FLT2ICR_DEF
    \
    \ @brief interrupt flag clear register
    \ Address offset: 0x20C
    \ Reset value: 0x00000000
    \
    $02 constant DFSDM1_CLRJOVRF                \ [0x02] Clear the injected conversion overrun flag
    $03 constant DFSDM1_CLRROVRF                \ [0x03] Clear the regular conversion overrun flag
    $10 constant DFSDM1_CLRCKABF                \ [0x10 : 8] Clear the clock absence flag
    $18 constant DFSDM1_CLRSCDF                 \ [0x18 : 8] Clear the short-circuit detector flag
  [then]


  [ifdef] DFSDM1_FLT2JCHGR_DEF
    \
    \ @brief injected channel group selection register
    \ Address offset: 0x210
    \ Reset value: 0x00000001
    \
    $00 constant DFSDM1_JCHG                    \ [0x00 : 8] Injected channel group selection
  [then]


  [ifdef] DFSDM1_FLT2FCR_DEF
    \
    \ @brief filter control register
    \ Address offset: 0x214
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM1_IOSR                    \ [0x00 : 8] Integrator oversampling ratio (averaging length)
    $10 constant DFSDM1_FOSR                    \ [0x10 : 10] Sinc filter oversampling ratio (decimation rate)
    $1d constant DFSDM1_FORD                    \ [0x1d : 3] Sinc filter order
  [then]


  [ifdef] DFSDM1_FLT2JDATAR_DEF
    \
    \ @brief data register for injected group
    \ Address offset: 0x218
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM1_JDATACH                 \ [0x00 : 3] Injected channel most recently converted
    $08 constant DFSDM1_JDATA                   \ [0x08 : 24] Injected group conversion data
  [then]


  [ifdef] DFSDM1_FLT2RDATAR_DEF
    \
    \ @brief data register for the regular channel
    \ Address offset: 0x21C
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM1_RDATACH                 \ [0x00 : 3] Regular channel most recently converted
    $04 constant DFSDM1_RPEND                   \ [0x04] Regular channel pending data
    $08 constant DFSDM1_RDATA                   \ [0x08 : 24] Regular channel conversion data
  [then]


  [ifdef] DFSDM1_FLT2AWHTR_DEF
    \
    \ @brief analog watchdog high threshold register
    \ Address offset: 0x220
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM1_BKAWH                   \ [0x00 : 4] Break signal assignment to analog watchdog high threshold event
    $08 constant DFSDM1_AWHT                    \ [0x08 : 24] Analog watchdog high threshold
  [then]


  [ifdef] DFSDM1_FLT2AWLTR_DEF
    \
    \ @brief analog watchdog low threshold register
    \ Address offset: 0x224
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM1_BKAWL                   \ [0x00 : 4] Break signal assignment to analog watchdog low threshold event
    $08 constant DFSDM1_AWLT                    \ [0x08 : 24] Analog watchdog low threshold
  [then]


  [ifdef] DFSDM1_FLT2AWSR_DEF
    \
    \ @brief analog watchdog status register
    \ Address offset: 0x228
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM1_AWLTF                   \ [0x00 : 8] Analog watchdog low threshold flag
    $08 constant DFSDM1_AWHTF                   \ [0x08 : 8] Analog watchdog high threshold flag
  [then]


  [ifdef] DFSDM1_FLT2AWCFR_DEF
    \
    \ @brief analog watchdog clear flag register
    \ Address offset: 0x22C
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM1_CLRAWLTF                \ [0x00 : 8] Clear the analog watchdog low threshold flag
    $08 constant DFSDM1_CLRAWHTF                \ [0x08 : 8] Clear the analog watchdog high threshold flag
  [then]


  [ifdef] DFSDM1_FLT2EXMAX_DEF
    \
    \ @brief Extremes detector maximum register
    \ Address offset: 0x230
    \ Reset value: 0x80000000
    \
    $00 constant DFSDM1_EXMAXCH                 \ [0x00 : 3] Extremes detector maximum data channel
    $08 constant DFSDM1_EXMAX                   \ [0x08 : 24] Extremes detector maximum value
  [then]


  [ifdef] DFSDM1_FLT2EXMIN_DEF
    \
    \ @brief Extremes detector minimum register
    \ Address offset: 0x234
    \ Reset value: 0x7FFFFF00
    \
    $00 constant DFSDM1_EXMINCH                 \ [0x00 : 3] Extremes detector minimum data channel
    $08 constant DFSDM1_EXMIN                   \ [0x08 : 24] EXMIN
  [then]


  [ifdef] DFSDM1_FLT2CNVTIMR_DEF
    \
    \ @brief conversion timer register
    \ Address offset: 0x238
    \ Reset value: 0x00000000
    \
    $04 constant DFSDM1_CNVCNT                  \ [0x04 : 28] 28-bit timer counting conversion time t = CNVCNT[27:0] / fDFSDM_CKIN
  [then]


  [ifdef] DFSDM1_FLT3CR1_DEF
    \
    \ @brief control register 1
    \ Address offset: 0x280
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM1_DFEN                    \ [0x00] DFSDM enable
    $01 constant DFSDM1_JSWSTART                \ [0x01] Start a conversion of the injected group of channels
    $03 constant DFSDM1_JSYNC                   \ [0x03] Launch an injected conversion synchronously with the DFSDM0 JSWSTART trigger
    $04 constant DFSDM1_JSCAN                   \ [0x04] Scanning conversion mode for injected conversions
    $05 constant DFSDM1_JDMAEN                  \ [0x05] DMA channel enabled to read data for the injected channel group
    $08 constant DFSDM1_JEXTSEL                 \ [0x08 : 3] Trigger signal selection for launching injected conversions
    $0d constant DFSDM1_JEXTEN                  \ [0x0d : 2] Trigger enable and trigger edge selection for injected conversions
    $11 constant DFSDM1_RSWSTART                \ [0x11] Software start of a conversion on the regular channel
    $12 constant DFSDM1_RCONT                   \ [0x12] Continuous mode selection for regular conversions
    $13 constant DFSDM1_RSYNC                   \ [0x13] Launch regular conversion synchronously with DFSDM0
    $15 constant DFSDM1_RDMAEN                  \ [0x15] DMA channel enabled to read data for the regular conversion
    $18 constant DFSDM1_RCH                     \ [0x18 : 3] Regular channel selection
    $1d constant DFSDM1_FAST                    \ [0x1d] Fast conversion mode selection for regular conversions
    $1e constant DFSDM1_AWFSEL                  \ [0x1e] Analog watchdog fast mode select
  [then]


  [ifdef] DFSDM1_FLT3CR2_DEF
    \
    \ @brief control register 2
    \ Address offset: 0x284
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM1_JEOCIE                  \ [0x00] Injected end of conversion interrupt enable
    $01 constant DFSDM1_REOCIE                  \ [0x01] Regular end of conversion interrupt enable
    $02 constant DFSDM1_JOVRIE                  \ [0x02] Injected data overrun interrupt enable
    $03 constant DFSDM1_ROVRIE                  \ [0x03] Regular data overrun interrupt enable
    $04 constant DFSDM1_AWDIE                   \ [0x04] Analog watchdog interrupt enable
    $05 constant DFSDM1_SCDIE                   \ [0x05] Short-circuit detector interrupt enable
    $06 constant DFSDM1_CKABIE                  \ [0x06] Clock absence interrupt enable
    $08 constant DFSDM1_EXCH                    \ [0x08 : 8] Extremes detector channel selection
    $10 constant DFSDM1_AWDCH                   \ [0x10 : 8] Analog watchdog channel selection
  [then]


  [ifdef] DFSDM1_FLT3ISR_DEF
    \
    \ @brief interrupt and status register
    \ Address offset: 0x288
    \ Reset value: 0x00FF0000
    \
    $00 constant DFSDM1_JEOCF                   \ [0x00] End of injected conversion flag
    $01 constant DFSDM1_REOCF                   \ [0x01] End of regular conversion flag
    $02 constant DFSDM1_JOVRF                   \ [0x02] Injected conversion overrun flag
    $03 constant DFSDM1_ROVRF                   \ [0x03] Regular conversion overrun flag
    $04 constant DFSDM1_AWDF                    \ [0x04] Analog watchdog
    $0d constant DFSDM1_JCIP                    \ [0x0d] Injected conversion in progress status
    $0e constant DFSDM1_RCIP                    \ [0x0e] Regular conversion in progress status
    $10 constant DFSDM1_CKABF                   \ [0x10 : 8] Clock absence flag
    $18 constant DFSDM1_SCDF                    \ [0x18 : 8] short-circuit detector flag
  [then]


  [ifdef] DFSDM1_FLT3ICR_DEF
    \
    \ @brief interrupt flag clear register
    \ Address offset: 0x28C
    \ Reset value: 0x00000000
    \
    $02 constant DFSDM1_CLRJOVRF                \ [0x02] Clear the injected conversion overrun flag
    $03 constant DFSDM1_CLRROVRF                \ [0x03] Clear the regular conversion overrun flag
    $10 constant DFSDM1_CLRCKABF                \ [0x10 : 8] Clear the clock absence flag
    $18 constant DFSDM1_CLRSCDF                 \ [0x18 : 8] Clear the short-circuit detector flag
  [then]


  [ifdef] DFSDM1_FLT3JCHGR_DEF
    \
    \ @brief injected channel group selection register
    \ Address offset: 0x290
    \ Reset value: 0x00000001
    \
    $00 constant DFSDM1_JCHG                    \ [0x00 : 8] Injected channel group selection
  [then]


  [ifdef] DFSDM1_FLT3FCR_DEF
    \
    \ @brief filter control register
    \ Address offset: 0x294
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM1_IOSR                    \ [0x00 : 8] Integrator oversampling ratio (averaging length)
    $10 constant DFSDM1_FOSR                    \ [0x10 : 10] Sinc filter oversampling ratio (decimation rate)
    $1d constant DFSDM1_FORD                    \ [0x1d : 3] Sinc filter order
  [then]


  [ifdef] DFSDM1_FLT3JDATAR_DEF
    \
    \ @brief data register for injected group
    \ Address offset: 0x298
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM1_JDATACH                 \ [0x00 : 3] Injected channel most recently converted
    $08 constant DFSDM1_JDATA                   \ [0x08 : 24] Injected group conversion data
  [then]


  [ifdef] DFSDM1_FLT3RDATAR_DEF
    \
    \ @brief data register for the regular channel
    \ Address offset: 0x29C
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM1_RDATACH                 \ [0x00 : 3] Regular channel most recently converted
    $04 constant DFSDM1_RPEND                   \ [0x04] Regular channel pending data
    $08 constant DFSDM1_RDATA                   \ [0x08 : 24] Regular channel conversion data
  [then]


  [ifdef] DFSDM1_FLT3AWHTR_DEF
    \
    \ @brief analog watchdog high threshold register
    \ Address offset: 0x2A0
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM1_BKAWH                   \ [0x00 : 4] Break signal assignment to analog watchdog high threshold event
    $08 constant DFSDM1_AWHT                    \ [0x08 : 24] Analog watchdog high threshold
  [then]


  [ifdef] DFSDM1_FLT3AWLTR_DEF
    \
    \ @brief analog watchdog low threshold register
    \ Address offset: 0x2A4
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM1_BKAWL                   \ [0x00 : 4] Break signal assignment to analog watchdog low threshold event
    $08 constant DFSDM1_AWLT                    \ [0x08 : 24] Analog watchdog low threshold
  [then]


  [ifdef] DFSDM1_FLT3AWSR_DEF
    \
    \ @brief analog watchdog status register
    \ Address offset: 0x2A8
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM1_AWLTF                   \ [0x00 : 8] Analog watchdog low threshold flag
    $08 constant DFSDM1_AWHTF                   \ [0x08 : 8] Analog watchdog high threshold flag
  [then]


  [ifdef] DFSDM1_FLT3AWCFR_DEF
    \
    \ @brief analog watchdog clear flag register
    \ Address offset: 0x2AC
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM1_CLRAWLTF                \ [0x00 : 8] Clear the analog watchdog low threshold flag
    $08 constant DFSDM1_CLRAWHTF                \ [0x08 : 8] Clear the analog watchdog high threshold flag
  [then]


  [ifdef] DFSDM1_FLT3EXMAX_DEF
    \
    \ @brief Extremes detector maximum register
    \ Address offset: 0x2B0
    \ Reset value: 0x80000000
    \
    $00 constant DFSDM1_EXMAXCH                 \ [0x00 : 3] Extremes detector maximum data channel
    $08 constant DFSDM1_EXMAX                   \ [0x08 : 24] Extremes detector maximum value
  [then]


  [ifdef] DFSDM1_FLT3EXMIN_DEF
    \
    \ @brief Extremes detector minimum register
    \ Address offset: 0x2B4
    \ Reset value: 0x7FFFFF00
    \
    $00 constant DFSDM1_EXMINCH                 \ [0x00 : 3] Extremes detector minimum data channel
    $08 constant DFSDM1_EXMIN                   \ [0x08 : 24] EXMIN
  [then]


  [ifdef] DFSDM1_FLT3CNVTIMR_DEF
    \
    \ @brief conversion timer register
    \ Address offset: 0x2B8
    \ Reset value: 0x00000000
    \
    $04 constant DFSDM1_CNVCNT                  \ [0x04 : 28] 28-bit timer counting conversion time t = CNVCNT[27:0] / fDFSDM_CKIN
  [then]

  \
  \ @brief Digital filter for sigma delta modulators
  \
  $00 constant DFSDM1_CH0CFGR1          \ channel configuration y register
  $04 constant DFSDM1_CH0CFGR2          \ channel configuration y register
  $08 constant DFSDM1_CH0AWSCDR         \ analog watchdog and short-circuit detector register
  $0C constant DFSDM1_CH0WDATR          \ channel watchdog filter data register
  $10 constant DFSDM1_CH0DATINR         \ channel data input register
  $14 constant DFSDM1_CH0DLYR           \ DFSDM channel y delay register
  $20 constant DFSDM1_CH1CFGR1          \ CHCFG1R1
  $24 constant DFSDM1_CH1CFGR2          \ CHCFG1R2
  $28 constant DFSDM1_CH1AWSCDR         \ AWSCD1R
  $2C constant DFSDM1_CH1WDATR          \ CHWDAT1R
  $30 constant DFSDM1_CH1DATINR         \ CHDATIN1R
  $34 constant DFSDM1_CH1DLYR           \ DFSDM channel y delay register
  $40 constant DFSDM1_CH2CFGR1          \ CHCFG2R1
  $44 constant DFSDM1_CH2CFGR2          \ CHCFG2R2
  $48 constant DFSDM1_CH2AWSCDR         \ AWSCD2R
  $4C constant DFSDM1_CH2WDATR          \ CHWDAT2R
  $50 constant DFSDM1_CH2DATINR         \ CHDATIN2R
  $54 constant DFSDM1_CH2DLYR           \ DFSDM channel y delay register
  $60 constant DFSDM1_CH3CFGR1          \ CHCFG3R1
  $64 constant DFSDM1_CH3CFGR2          \ CHCFG3R2
  $68 constant DFSDM1_CH3AWSCDR         \ AWSCD3R
  $6C constant DFSDM1_CH3WDATR          \ CHWDAT3R
  $70 constant DFSDM1_CH3DATINR         \ CHDATIN3R
  $74 constant DFSDM1_CH3DLYR           \ DFSDM channel y delay register
  $80 constant DFSDM1_CH4CFGR1          \ CHCFG4R1
  $84 constant DFSDM1_CH4CFGR2          \ CHCFG4R2
  $88 constant DFSDM1_CH4AWSCDR         \ AWSCD4R
  $8C constant DFSDM1_CH4WDATR          \ CHWDAT4R
  $90 constant DFSDM1_CH4DATINR         \ CHDATIN4R
  $94 constant DFSDM1_CH4DLYR           \ DFSDM channel y delay register
  $A0 constant DFSDM1_CH5CFGR1          \ CHCFG5R1
  $A4 constant DFSDM1_CH5CFGR2          \ CHCFG5R2
  $A8 constant DFSDM1_CH5AWSCDR         \ AWSCD5R
  $AC constant DFSDM1_CH5WDATR          \ CHWDAT5R
  $B0 constant DFSDM1_CH5DATINR         \ CHDATIN5R
  $B4 constant DFSDM1_CH5DLYR           \ DFSDM channel y delay register
  $C0 constant DFSDM1_CH6CFGR1          \ CHCFG6R1
  $C4 constant DFSDM1_CH6CFGR2          \ CH6CFGR2
  $C8 constant DFSDM1_CH6AWSCDR         \ AWSCD6R
  $CC constant DFSDM1_CH6WDATR          \ CHWDAT6R
  $D0 constant DFSDM1_CH6DATINR         \ CHDATIN6R
  $D4 constant DFSDM1_CH6DLYR           \ DFSDM channel y delay register
  $E0 constant DFSDM1_CH7CFGR1          \ CHCFG7R1
  $E4 constant DFSDM1_CH7CFGR2          \ CHCFG7R2
  $E8 constant DFSDM1_CH7AWSCDR         \ AWSCD7R
  $EC constant DFSDM1_CH7WDATR          \ CHWDAT7R
  $F0 constant DFSDM1_CH7DATINR         \ CHDATIN7R
  $F4 constant DFSDM1_CH7DLYR           \ DFSDM channel y delay register
  $100 constant DFSDM1_FLT0CR1          \ control register 1
  $104 constant DFSDM1_FLT0CR2          \ control register 2
  $108 constant DFSDM1_FLT0ISR          \ interrupt and status register
  $10C constant DFSDM1_FLT0ICR          \ interrupt flag clear register
  $110 constant DFSDM1_FLT0JCHGR        \ injected channel group selection register
  $114 constant DFSDM1_FLT0FCR          \ filter control register
  $118 constant DFSDM1_FLT0JDATAR       \ data register for injected group
  $11C constant DFSDM1_FLT0RDATAR       \ data register for the regular channel
  $120 constant DFSDM1_FLT0AWHTR        \ analog watchdog high threshold register
  $124 constant DFSDM1_FLT0AWLTR        \ analog watchdog low threshold register
  $128 constant DFSDM1_FLT0AWSR         \ analog watchdog status register
  $12C constant DFSDM1_FLT0AWCFR        \ analog watchdog clear flag register
  $130 constant DFSDM1_FLT0EXMAX        \ Extremes detector maximum register
  $134 constant DFSDM1_FLT0EXMIN        \ Extremes detector minimum register
  $138 constant DFSDM1_FLT0CNVTIMR      \ conversion timer register
  $180 constant DFSDM1_FLT1CR1          \ control register 1
  $184 constant DFSDM1_FLT1CR2          \ control register 2
  $188 constant DFSDM1_FLT1ISR          \ interrupt and status register
  $18C constant DFSDM1_FLT1ICR          \ interrupt flag clear register
  $190 constant DFSDM1_FLT1JCHGR        \ injected channel group selection register
  $194 constant DFSDM1_FLT1FCR          \ filter control register
  $198 constant DFSDM1_FLT1JDATAR       \ data register for injected group
  $19C constant DFSDM1_FLT1RDATAR       \ data register for the regular channel
  $1A4 constant DFSDM1_FLT1AWLTR        \ analog watchdog low threshold register
  $1A8 constant DFSDM1_FLT1AWSR         \ analog watchdog status register
  $1AC constant DFSDM1_FLT1AWHTR        \ analog watchdog high threshold register
  $1AC constant DFSDM1_FLT1AWCFR        \ analog watchdog clear flag register
  $1B0 constant DFSDM1_FLT1EXMAX        \ Extremes detector maximum register
  $1B4 constant DFSDM1_FLT1EXMIN        \ Extremes detector minimum register
  $1B8 constant DFSDM1_FLT1CNVTIMR      \ conversion timer register
  $200 constant DFSDM1_FLT2CR1          \ control register 1
  $204 constant DFSDM1_FLT2CR2          \ control register 2
  $208 constant DFSDM1_FLT2ISR          \ interrupt and status register
  $20C constant DFSDM1_FLT2ICR          \ interrupt flag clear register
  $210 constant DFSDM1_FLT2JCHGR        \ injected channel group selection register
  $214 constant DFSDM1_FLT2FCR          \ filter control register
  $218 constant DFSDM1_FLT2JDATAR       \ data register for injected group
  $21C constant DFSDM1_FLT2RDATAR       \ data register for the regular channel
  $220 constant DFSDM1_FLT2AWHTR        \ analog watchdog high threshold register
  $224 constant DFSDM1_FLT2AWLTR        \ analog watchdog low threshold register
  $228 constant DFSDM1_FLT2AWSR         \ analog watchdog status register
  $22C constant DFSDM1_FLT2AWCFR        \ analog watchdog clear flag register
  $230 constant DFSDM1_FLT2EXMAX        \ Extremes detector maximum register
  $234 constant DFSDM1_FLT2EXMIN        \ Extremes detector minimum register
  $238 constant DFSDM1_FLT2CNVTIMR      \ conversion timer register
  $280 constant DFSDM1_FLT3CR1          \ control register 1
  $284 constant DFSDM1_FLT3CR2          \ control register 2
  $288 constant DFSDM1_FLT3ISR          \ interrupt and status register
  $28C constant DFSDM1_FLT3ICR          \ interrupt flag clear register
  $290 constant DFSDM1_FLT3JCHGR        \ injected channel group selection register
  $294 constant DFSDM1_FLT3FCR          \ filter control register
  $298 constant DFSDM1_FLT3JDATAR       \ data register for injected group
  $29C constant DFSDM1_FLT3RDATAR       \ data register for the regular channel
  $2A0 constant DFSDM1_FLT3AWHTR        \ analog watchdog high threshold register
  $2A4 constant DFSDM1_FLT3AWLTR        \ analog watchdog low threshold register
  $2A8 constant DFSDM1_FLT3AWSR         \ analog watchdog status register
  $2AC constant DFSDM1_FLT3AWCFR        \ analog watchdog clear flag register
  $2B0 constant DFSDM1_FLT3EXMAX        \ Extremes detector maximum register
  $2B4 constant DFSDM1_FLT3EXMIN        \ Extremes detector minimum register
  $2B8 constant DFSDM1_FLT3CNVTIMR      \ conversion timer register

: DFSDM1_DEF ; [then]
