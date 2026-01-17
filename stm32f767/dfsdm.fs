\
\ @file dfsdm.fs
\ @brief Digital filter for sigma delta modulators
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] DFSDM_DEF

  [ifdef] DFSDM_DFSDM_CHCFG0R1_DEF
    \
    \ @brief DFSDM channel configuration 0 register 1
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM_SITP                     \ [0x00 : 2] Serial interface type for channel 0
    $02 constant DFSDM_SPICKSEL                 \ [0x02 : 2] SPI clock select for channel 0
    $05 constant DFSDM_SCDEN                    \ [0x05] Short-circuit detector enable on channel 0
    $06 constant DFSDM_CKABEN                   \ [0x06] Clock absence detector enable on channel 0
    $07 constant DFSDM_CHEN                     \ [0x07] Channel 0 enable
    $08 constant DFSDM_CHINSEL                  \ [0x08] Channel inputs selection
    $0c constant DFSDM_DATMPX                   \ [0x0c : 2] Input data multiplexer for channel 0
    $0e constant DFSDM_DATPACK                  \ [0x0e : 2] Data packing mode in DFSDM_CHDATINyR register
    $10 constant DFSDM_CKOUTDIV                 \ [0x10 : 8] Output serial clock divider
    $1e constant DFSDM_CKOUTSRC                 \ [0x1e] Output serial clock source selection
    $1f constant DFSDM_DFSDMEN                  \ [0x1f] Global enable for DFSDM interface
  [then]


  [ifdef] DFSDM_DFSDM_CHCFG0R2_DEF
    \
    \ @brief DFSDM channel configuration 0 register 2
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $03 constant DFSDM_DTRBS                    \ [0x03 : 5] Data right bit-shift for channel 0
    $08 constant DFSDM_OFFSET                   \ [0x08 : 24] 24-bit calibration offset for channel 0
  [then]


  [ifdef] DFSDM_DFSDM_AWSCD0R_DEF
    \
    \ @brief DFSDM analog watchdog and short-circuit detector register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM_SCDT                     \ [0x00 : 8] short-circuit detector threshold for channel 0
    $0c constant DFSDM_BKSCD                    \ [0x0c : 4] Break signal assignment for short-circuit detector on channel 0
    $10 constant DFSDM_AWFOSR                   \ [0x10 : 5] Analog watchdog filter oversampling ratio (decimation rate) on channel 0
    $16 constant DFSDM_AWFORD                   \ [0x16 : 2] Analog watchdog Sinc filter order on channel 0
  [then]


  [ifdef] DFSDM_DFSDM_CHWDAT0R_DEF
    \
    \ @brief DFSDM channel watchdog filter data register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM_WDATA                    \ [0x00 : 16] Input channel y watchdog data
  [then]


  [ifdef] DFSDM_DFSDM_CHDATIN0R_DEF
    \
    \ @brief DFSDM channel data input register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM_INDAT0                   \ [0x00 : 16] Input data for channel 0
    $10 constant DFSDM_INDAT1                   \ [0x10 : 16] Input data for channel 1
  [then]


  [ifdef] DFSDM_DFSDM_CHCFG1R1_DEF
    \
    \ @brief DFSDM channel configuration 1 register 1
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM_SITP                     \ [0x00 : 2] Serial interface type for channel 1
    $02 constant DFSDM_SPICKSEL                 \ [0x02 : 2] SPI clock select for channel 1
    $05 constant DFSDM_SCDEN                    \ [0x05] Short-circuit detector enable on channel 1
    $06 constant DFSDM_CKABEN                   \ [0x06] Clock absence detector enable on channel 1
    $07 constant DFSDM_CHEN                     \ [0x07] Channel 1 enable
    $08 constant DFSDM_CHINSEL                  \ [0x08] Channel inputs selection
    $0c constant DFSDM_DATMPX                   \ [0x0c : 2] Input data multiplexer for channel 1
    $0e constant DFSDM_DATPACK                  \ [0x0e : 2] Data packing mode in DFSDM_CHDATINyR register
    $10 constant DFSDM_CKOUTDIV                 \ [0x10 : 8] Output serial clock divider
    $1e constant DFSDM_CKOUTSRC                 \ [0x1e] Output serial clock source selection
    $1f constant DFSDM_DFSDMEN                  \ [0x1f] Global enable for DFSDM interface
  [then]


  [ifdef] DFSDM_DFSDM_CHCFG1R2_DEF
    \
    \ @brief DFSDM channel configuration 1 register 2
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $03 constant DFSDM_DTRBS                    \ [0x03 : 5] Data right bit-shift for channel 1
    $08 constant DFSDM_OFFSET                   \ [0x08 : 24] 24-bit calibration offset for channel 1
  [then]


  [ifdef] DFSDM_DFSDM_AWSCD1R_DEF
    \
    \ @brief DFSDM analog watchdog and short-circuit detector register
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM_SCDT                     \ [0x00 : 8] short-circuit detector threshold for channel 1
    $0c constant DFSDM_BKSCD                    \ [0x0c : 4] Break signal assignment for short-circuit detector on channel 1
    $10 constant DFSDM_AWFOSR                   \ [0x10 : 5] Analog watchdog filter oversampling ratio (decimation rate) on channel 1
    $16 constant DFSDM_AWFORD                   \ [0x16 : 2] Analog watchdog Sinc filter order on channel 1
  [then]


  [ifdef] DFSDM_DFSDM_CHWDAT1R_DEF
    \
    \ @brief DFSDM channel watchdog filter data register
    \ Address offset: 0x2C
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM_WDATA                    \ [0x00 : 16] Input channel y watchdog data
  [then]


  [ifdef] DFSDM_DFSDM_CHDATIN1R_DEF
    \
    \ @brief DFSDM channel data input register
    \ Address offset: 0x30
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM_INDAT0                   \ [0x00 : 16] Input data for channel 1
    $10 constant DFSDM_INDAT1                   \ [0x10 : 16] Input data for channel 2
  [then]


  [ifdef] DFSDM_DFSDM_CHCFG2R1_DEF
    \
    \ @brief DFSDM channel configuration 2 register 1
    \ Address offset: 0x40
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM_SITP                     \ [0x00 : 2] Serial interface type for channel 2
    $02 constant DFSDM_SPICKSEL                 \ [0x02 : 2] SPI clock select for channel 2
    $05 constant DFSDM_SCDEN                    \ [0x05] Short-circuit detector enable on channel 2
    $06 constant DFSDM_CKABEN                   \ [0x06] Clock absence detector enable on channel 2
    $07 constant DFSDM_CHEN                     \ [0x07] Channel 2 enable
    $08 constant DFSDM_CHINSEL                  \ [0x08] Channel inputs selection
    $0c constant DFSDM_DATMPX                   \ [0x0c : 2] Input data multiplexer for channel 2
    $0e constant DFSDM_DATPACK                  \ [0x0e : 2] Data packing mode in DFSDM_CHDATINyR register
    $10 constant DFSDM_CKOUTDIV                 \ [0x10 : 8] Output serial clock divider
    $1e constant DFSDM_CKOUTSRC                 \ [0x1e] Output serial clock source selection
    $1f constant DFSDM_DFSDMEN                  \ [0x1f] Global enable for DFSDM interface
  [then]


  [ifdef] DFSDM_DFSDM_CHCFG2R2_DEF
    \
    \ @brief DFSDM channel configuration 2 register 2
    \ Address offset: 0x44
    \ Reset value: 0x00000000
    \
    $03 constant DFSDM_DTRBS                    \ [0x03 : 5] Data right bit-shift for channel 2
    $08 constant DFSDM_OFFSET                   \ [0x08 : 24] 24-bit calibration offset for channel 2
  [then]


  [ifdef] DFSDM_DFSDM_AWSCD2R_DEF
    \
    \ @brief DFSDM analog watchdog and short-circuit detector register
    \ Address offset: 0x48
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM_SCDT                     \ [0x00 : 8] short-circuit detector threshold for channel 2
    $0c constant DFSDM_BKSCD                    \ [0x0c : 4] Break signal assignment for short-circuit detector on channel 2
    $10 constant DFSDM_AWFOSR                   \ [0x10 : 5] Analog watchdog filter oversampling ratio (decimation rate) on channel 2
    $16 constant DFSDM_AWFORD                   \ [0x16 : 2] Analog watchdog Sinc filter order on channel 2
  [then]


  [ifdef] DFSDM_DFSDM_CHWDAT2R_DEF
    \
    \ @brief DFSDM channel watchdog filter data register
    \ Address offset: 0x4C
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM_WDATA                    \ [0x00 : 16] Input channel y watchdog data
  [then]


  [ifdef] DFSDM_DFSDM_CHDATIN2R_DEF
    \
    \ @brief DFSDM channel data input register
    \ Address offset: 0x50
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM_INDAT0                   \ [0x00 : 16] Input data for channel 2
    $10 constant DFSDM_INDAT1                   \ [0x10 : 16] Input data for channel 3
  [then]


  [ifdef] DFSDM_DFSDM_CHCFG3R1_DEF
    \
    \ @brief DFSDM channel configuration 3 register 1
    \ Address offset: 0x60
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM_SITP                     \ [0x00 : 2] Serial interface type for channel 3
    $02 constant DFSDM_SPICKSEL                 \ [0x02 : 2] SPI clock select for channel 3
    $05 constant DFSDM_SCDEN                    \ [0x05] Short-circuit detector enable on channel 3
    $06 constant DFSDM_CKABEN                   \ [0x06] Clock absence detector enable on channel 3
    $07 constant DFSDM_CHEN                     \ [0x07] Channel 3 enable
    $08 constant DFSDM_CHINSEL                  \ [0x08] Channel inputs selection
    $0c constant DFSDM_DATMPX                   \ [0x0c : 2] Input data multiplexer for channel 3
    $0e constant DFSDM_DATPACK                  \ [0x0e : 2] Data packing mode in DFSDM_CHDATINyR register
    $10 constant DFSDM_CKOUTDIV                 \ [0x10 : 8] Output serial clock divider
    $1e constant DFSDM_CKOUTSRC                 \ [0x1e] Output serial clock source selection
    $1f constant DFSDM_DFSDMEN                  \ [0x1f] Global enable for DFSDM interface
  [then]


  [ifdef] DFSDM_DFSDM_CHCFG3R2_DEF
    \
    \ @brief DFSDM channel configuration 3 register 2
    \ Address offset: 0x64
    \ Reset value: 0x00000000
    \
    $03 constant DFSDM_DTRBS                    \ [0x03 : 5] Data right bit-shift for channel 3
    $08 constant DFSDM_OFFSET                   \ [0x08 : 24] 24-bit calibration offset for channel 3
  [then]


  [ifdef] DFSDM_DFSDM_AWSCD3R_DEF
    \
    \ @brief DFSDM analog watchdog and short-circuit detector register
    \ Address offset: 0x68
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM_SCDT                     \ [0x00 : 8] short-circuit detector threshold for channel 3
    $0c constant DFSDM_BKSCD                    \ [0x0c : 4] Break signal assignment for short-circuit detector on channel 3
    $10 constant DFSDM_AWFOSR                   \ [0x10 : 5] Analog watchdog filter oversampling ratio (decimation rate) on channel 3
    $16 constant DFSDM_AWFORD                   \ [0x16 : 2] Analog watchdog Sinc filter order on channel 3
  [then]


  [ifdef] DFSDM_DFSDM_CHWDAT3R_DEF
    \
    \ @brief DFSDM channel watchdog filter data register
    \ Address offset: 0x6C
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM_WDATA                    \ [0x00 : 16] Input channel y watchdog data
  [then]


  [ifdef] DFSDM_DFSDM_CHDATIN3R_DEF
    \
    \ @brief DFSDM channel data input register
    \ Address offset: 0x70
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM_INDAT0                   \ [0x00 : 16] Input data for channel 3
    $10 constant DFSDM_INDAT1                   \ [0x10 : 16] Input data for channel 4
  [then]


  [ifdef] DFSDM_DFSDM_CHCFG4R1_DEF
    \
    \ @brief DFSDM channel configuration 4 register 1
    \ Address offset: 0x80
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM_SITP                     \ [0x00 : 2] Serial interface type for channel 4
    $02 constant DFSDM_SPICKSEL                 \ [0x02 : 2] SPI clock select for channel 4
    $05 constant DFSDM_SCDEN                    \ [0x05] Short-circuit detector enable on channel 4
    $06 constant DFSDM_CKABEN                   \ [0x06] Clock absence detector enable on channel 4
    $07 constant DFSDM_CHEN                     \ [0x07] Channel 4 enable
    $08 constant DFSDM_CHINSEL                  \ [0x08] Channel inputs selection
    $0c constant DFSDM_DATMPX                   \ [0x0c : 2] Input data multiplexer for channel 4
    $0e constant DFSDM_DATPACK                  \ [0x0e : 2] Data packing mode in DFSDM_CHDATINyR register
    $10 constant DFSDM_CKOUTDIV                 \ [0x10 : 8] Output serial clock divider
    $1e constant DFSDM_CKOUTSRC                 \ [0x1e] Output serial clock source selection
    $1f constant DFSDM_DFSDMEN                  \ [0x1f] Global enable for DFSDM interface
  [then]


  [ifdef] DFSDM_DFSDM_CHCFG4R2_DEF
    \
    \ @brief DFSDM channel configuration 4 register 2
    \ Address offset: 0x84
    \ Reset value: 0x00000000
    \
    $03 constant DFSDM_DTRBS                    \ [0x03 : 5] Data right bit-shift for channel 4
    $08 constant DFSDM_OFFSET                   \ [0x08 : 24] 24-bit calibration offset for channel 4
  [then]


  [ifdef] DFSDM_DFSDM_AWSCD4R_DEF
    \
    \ @brief DFSDM analog watchdog and short-circuit detector register
    \ Address offset: 0x88
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM_SCDT                     \ [0x00 : 8] short-circuit detector threshold for channel 4
    $0c constant DFSDM_BKSCD                    \ [0x0c : 4] Break signal assignment for short-circuit detector on channel 4
    $10 constant DFSDM_AWFOSR                   \ [0x10 : 5] Analog watchdog filter oversampling ratio (decimation rate) on channel 4
    $16 constant DFSDM_AWFORD                   \ [0x16 : 2] Analog watchdog Sinc filter order on channel 4
  [then]


  [ifdef] DFSDM_DFSDM_CHWDAT4R_DEF
    \
    \ @brief DFSDM channel watchdog filter data register
    \ Address offset: 0x8C
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM_WDATA                    \ [0x00 : 16] Input channel y watchdog data
  [then]


  [ifdef] DFSDM_DFSDM_CHDATIN4R_DEF
    \
    \ @brief DFSDM channel data input register
    \ Address offset: 0x90
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM_INDAT0                   \ [0x00 : 16] Input data for channel 4
    $10 constant DFSDM_INDAT1                   \ [0x10 : 16] Input data for channel 5
  [then]


  [ifdef] DFSDM_DFSDM_CHCFG5R1_DEF
    \
    \ @brief DFSDM channel configuration 5 register 1
    \ Address offset: 0xA0
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM_SITP                     \ [0x00 : 2] Serial interface type for channel 5
    $02 constant DFSDM_SPICKSEL                 \ [0x02 : 2] SPI clock select for channel 5
    $05 constant DFSDM_SCDEN                    \ [0x05] Short-circuit detector enable on channel 5
    $06 constant DFSDM_CKABEN                   \ [0x06] Clock absence detector enable on channel 5
    $07 constant DFSDM_CHEN                     \ [0x07] Channel 5 enable
    $08 constant DFSDM_CHINSEL                  \ [0x08] Channel inputs selection
    $0c constant DFSDM_DATMPX                   \ [0x0c : 2] Input data multiplexer for channel 5
    $0e constant DFSDM_DATPACK                  \ [0x0e : 2] Data packing mode in DFSDM_CHDATINyR register
    $10 constant DFSDM_CKOUTDIV                 \ [0x10 : 8] Output serial clock divider
    $1e constant DFSDM_CKOUTSRC                 \ [0x1e] Output serial clock source selection
    $1f constant DFSDM_DFSDMEN                  \ [0x1f] Global enable for DFSDM interface
  [then]


  [ifdef] DFSDM_DFSDM_CHCFG5R2_DEF
    \
    \ @brief DFSDM channel configuration 5 register 2
    \ Address offset: 0xA4
    \ Reset value: 0x00000000
    \
    $03 constant DFSDM_DTRBS                    \ [0x03 : 5] Data right bit-shift for channel 5
    $08 constant DFSDM_OFFSET                   \ [0x08 : 24] 24-bit calibration offset for channel 5
  [then]


  [ifdef] DFSDM_DFSDM_AWSCD5R_DEF
    \
    \ @brief DFSDM analog watchdog and short-circuit detector register
    \ Address offset: 0xA8
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM_SCDT                     \ [0x00 : 8] short-circuit detector threshold for channel 5
    $0c constant DFSDM_BKSCD                    \ [0x0c : 4] Break signal assignment for short-circuit detector on channel 5
    $10 constant DFSDM_AWFOSR                   \ [0x10 : 5] Analog watchdog filter oversampling ratio (decimation rate) on channel 5
    $16 constant DFSDM_AWFORD                   \ [0x16 : 2] Analog watchdog Sinc filter order on channel 5
  [then]


  [ifdef] DFSDM_DFSDM_CHWDAT5R_DEF
    \
    \ @brief DFSDM channel watchdog filter data register
    \ Address offset: 0xAC
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM_WDATA                    \ [0x00 : 16] Input channel y watchdog data
  [then]


  [ifdef] DFSDM_DFSDM_CHDATIN5R_DEF
    \
    \ @brief DFSDM channel data input register
    \ Address offset: 0xB0
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM_INDAT0                   \ [0x00 : 16] Input data for channel 5
    $10 constant DFSDM_INDAT1                   \ [0x10 : 16] Input data for channel 6
  [then]


  [ifdef] DFSDM_DFSDM_CHCFG6R1_DEF
    \
    \ @brief DFSDM channel configuration 6 register 1
    \ Address offset: 0xC0
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM_SITP                     \ [0x00 : 2] Serial interface type for channel 6
    $02 constant DFSDM_SPICKSEL                 \ [0x02 : 2] SPI clock select for channel 6
    $05 constant DFSDM_SCDEN                    \ [0x05] Short-circuit detector enable on channel 6
    $06 constant DFSDM_CKABEN                   \ [0x06] Clock absence detector enable on channel 6
    $07 constant DFSDM_CHEN                     \ [0x07] Channel 6 enable
    $08 constant DFSDM_CHINSEL                  \ [0x08] Channel inputs selection
    $0c constant DFSDM_DATMPX                   \ [0x0c : 2] Input data multiplexer for channel 6
    $0e constant DFSDM_DATPACK                  \ [0x0e : 2] Data packing mode in DFSDM_CHDATINyR register
    $10 constant DFSDM_CKOUTDIV                 \ [0x10 : 8] Output serial clock divider
    $1e constant DFSDM_CKOUTSRC                 \ [0x1e] Output serial clock source selection
    $1f constant DFSDM_DFSDMEN                  \ [0x1f] Global enable for DFSDM interface
  [then]


  [ifdef] DFSDM_DFSDM_CHCFG6R2_DEF
    \
    \ @brief DFSDM channel configuration 6 register 2
    \ Address offset: 0xC4
    \ Reset value: 0x00000000
    \
    $03 constant DFSDM_DTRBS                    \ [0x03 : 5] Data right bit-shift for channel 6
    $08 constant DFSDM_OFFSET                   \ [0x08 : 24] 24-bit calibration offset for channel 6
  [then]


  [ifdef] DFSDM_DFSDM_AWSCD6R_DEF
    \
    \ @brief DFSDM analog watchdog and short-circuit detector register
    \ Address offset: 0xC8
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM_SCDT                     \ [0x00 : 8] short-circuit detector threshold for channel 6
    $0c constant DFSDM_BKSCD                    \ [0x0c : 4] Break signal assignment for short-circuit detector on channel 6
    $10 constant DFSDM_AWFOSR                   \ [0x10 : 5] Analog watchdog filter oversampling ratio (decimation rate) on channel 6
    $16 constant DFSDM_AWFORD                   \ [0x16 : 2] Analog watchdog Sinc filter order on channel 6
  [then]


  [ifdef] DFSDM_DFSDM_CHWDAT6R_DEF
    \
    \ @brief DFSDM channel watchdog filter data register
    \ Address offset: 0xCC
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM_WDATA                    \ [0x00 : 16] Input channel y watchdog data
  [then]


  [ifdef] DFSDM_DFSDM_CHDATIN6R_DEF
    \
    \ @brief DFSDM channel data input register
    \ Address offset: 0xD0
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM_INDAT0                   \ [0x00 : 16] Input data for channel 6
    $10 constant DFSDM_INDAT1                   \ [0x10 : 16] Input data for channel 7
  [then]


  [ifdef] DFSDM_DFSDM_CHCFG7R1_DEF
    \
    \ @brief DFSDM channel configuration 7 register 1
    \ Address offset: 0xE0
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM_SITP                     \ [0x00 : 2] Serial interface type for channel 7
    $02 constant DFSDM_SPICKSEL                 \ [0x02 : 2] SPI clock select for channel 7
    $05 constant DFSDM_SCDEN                    \ [0x05] Short-circuit detector enable on channel 7
    $06 constant DFSDM_CKABEN                   \ [0x06] Clock absence detector enable on channel 7
    $07 constant DFSDM_CHEN                     \ [0x07] Channel 7 enable
    $08 constant DFSDM_CHINSEL                  \ [0x08] Channel inputs selection
    $0c constant DFSDM_DATMPX                   \ [0x0c : 2] Input data multiplexer for channel 7
    $0e constant DFSDM_DATPACK                  \ [0x0e : 2] Data packing mode in DFSDM_CHDATINyR register
    $10 constant DFSDM_CKOUTDIV                 \ [0x10 : 8] Output serial clock divider
    $1e constant DFSDM_CKOUTSRC                 \ [0x1e] Output serial clock source selection
    $1f constant DFSDM_DFSDMEN                  \ [0x1f] Global enable for DFSDM interface
  [then]


  [ifdef] DFSDM_DFSDM_CHCFG7R2_DEF
    \
    \ @brief DFSDM channel configuration 7 register 2
    \ Address offset: 0xE4
    \ Reset value: 0x00000000
    \
    $03 constant DFSDM_DTRBS                    \ [0x03 : 5] Data right bit-shift for channel 7
    $08 constant DFSDM_OFFSET                   \ [0x08 : 24] 24-bit calibration offset for channel 7
  [then]


  [ifdef] DFSDM_DFSDM_AWSCD7R_DEF
    \
    \ @brief DFSDM analog watchdog and short-circuit detector register
    \ Address offset: 0xE8
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM_SCDT                     \ [0x00 : 8] short-circuit detector threshold for channel 7
    $0c constant DFSDM_BKSCD                    \ [0x0c : 4] Break signal assignment for short-circuit detector on channel 7
    $10 constant DFSDM_AWFOSR                   \ [0x10 : 5] Analog watchdog filter oversampling ratio (decimation rate) on channel 7
    $16 constant DFSDM_AWFORD                   \ [0x16 : 2] Analog watchdog Sinc filter order on channel 7
  [then]


  [ifdef] DFSDM_DFSDM_CHWDAT7R_DEF
    \
    \ @brief DFSDM channel watchdog filter data register
    \ Address offset: 0xEC
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM_WDATA                    \ [0x00 : 16] Input channel y watchdog data
  [then]


  [ifdef] DFSDM_DFSDM_CHDATIN7R_DEF
    \
    \ @brief DFSDM channel data input register
    \ Address offset: 0xF0
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM_INDAT0                   \ [0x00 : 16] Input data for channel 7
    $10 constant DFSDM_INDAT1                   \ [0x10 : 16] Input data for channel 8
  [then]


  [ifdef] DFSDM_DFSDM0_CR1_DEF
    \
    \ @brief DFSDM control register 1
    \ Address offset: 0x100
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM_DFEN                     \ [0x00] DFSDM enable
    $01 constant DFSDM_JSWSTART                 \ [0x01] Start a conversion of the injected group of channels
    $03 constant DFSDM_JSYNC                    \ [0x03] Launch an injected conversion synchronously with the DFSDM0 JSWSTART trigger
    $04 constant DFSDM_JSCAN                    \ [0x04] Scanning conversion mode for injected conversions
    $05 constant DFSDM_JDMAEN                   \ [0x05] DMA channel enabled to read data for the injected channel group
    $08 constant DFSDM_JEXTSEL                  \ [0x08 : 5] Trigger signal selection for launching injected conversions
    $0d constant DFSDM_JEXTEN                   \ [0x0d : 2] Trigger enable and trigger edge selection for injected conversions
    $11 constant DFSDM_RSWSTART                 \ [0x11] Software start of a conversion on the regular channel
    $12 constant DFSDM_RCONT                    \ [0x12] Continuous mode selection for regular conversions
    $13 constant DFSDM_RSYNC                    \ [0x13] Launch regular conversion synchronously with DFSDM0
    $15 constant DFSDM_RDMAEN                   \ [0x15] DMA channel enabled to read data for the regular conversion
    $18 constant DFSDM_RCH                      \ [0x18 : 3] Regular channel selection
    $1d constant DFSDM_FAST                     \ [0x1d] Fast conversion mode selection for regular conversions
    $1e constant DFSDM_AWFSEL                   \ [0x1e] Analog watchdog fast mode select
  [then]


  [ifdef] DFSDM_DFSDM0_CR2_DEF
    \
    \ @brief DFSDM control register 2
    \ Address offset: 0x104
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM_JEOCIE                   \ [0x00] Injected end of conversion interrupt enable
    $01 constant DFSDM_REOCIE                   \ [0x01] Regular end of conversion interrupt enable
    $02 constant DFSDM_JOVRIE                   \ [0x02] Injected data overrun interrupt enable
    $03 constant DFSDM_ROVRIE                   \ [0x03] Regular data overrun interrupt enable
    $04 constant DFSDM_AWDIE                    \ [0x04] Analog watchdog interrupt enable
    $05 constant DFSDM_SCDIE                    \ [0x05] Short-circuit detector interrupt enable
    $06 constant DFSDM_CKABIE                   \ [0x06] Clock absence interrupt enable
    $08 constant DFSDM_EXCH                     \ [0x08 : 8] Extremes detector channel selection
    $10 constant DFSDM_AWDCH                    \ [0x10 : 8] Analog watchdog channel selection
  [then]


  [ifdef] DFSDM_DFSDM0_ISR_DEF
    \
    \ @brief DFSDM interrupt and status register
    \ Address offset: 0x108
    \ Reset value: 0x00FF0000
    \
    $00 constant DFSDM_JEOCF                    \ [0x00] End of injected conversion flag
    $01 constant DFSDM_REOCF                    \ [0x01] End of regular conversion flag
    $02 constant DFSDM_JOVRF                    \ [0x02] Injected conversion overrun flag
    $03 constant DFSDM_ROVRF                    \ [0x03] Regular conversion overrun flag
    $04 constant DFSDM_AWDF                     \ [0x04] Analog watchdog
    $0d constant DFSDM_JCIP                     \ [0x0d] Injected conversion in progress status
    $0e constant DFSDM_RCIP                     \ [0x0e] Regular conversion in progress status
    $10 constant DFSDM_CKABF                    \ [0x10 : 8] Clock absence flag
    $18 constant DFSDM_SCDF                     \ [0x18 : 8] short-circuit detector flag
  [then]


  [ifdef] DFSDM_DFSDM0_ICR_DEF
    \
    \ @brief DFSDM interrupt flag clear register
    \ Address offset: 0x10C
    \ Reset value: 0x00000000
    \
    $02 constant DFSDM_CLRJOVRF                 \ [0x02] Clear the injected conversion overrun flag
    $03 constant DFSDM_CLRROVRF                 \ [0x03] Clear the regular conversion overrun flag
    $10 constant DFSDM_CLRCKABF                 \ [0x10 : 8] Clear the clock absence flag
    $18 constant DFSDM_CLRSCDF                  \ [0x18 : 8] Clear the short-circuit detector flag
  [then]


  [ifdef] DFSDM_DFSDM0_JCHGR_DEF
    \
    \ @brief DFSDM injected channel group selection register
    \ Address offset: 0x110
    \ Reset value: 0x00000001
    \
    $00 constant DFSDM_JCHG                     \ [0x00 : 8] Injected channel group selection
  [then]


  [ifdef] DFSDM_DFSDM0_FCR_DEF
    \
    \ @brief DFSDM filter control register
    \ Address offset: 0x114
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM_IOSR                     \ [0x00 : 8] Integrator oversampling ratio (averaging length)
    $10 constant DFSDM_FOSR                     \ [0x10 : 10] Sinc filter oversampling ratio (decimation rate)
    $1d constant DFSDM_FORD                     \ [0x1d : 3] Sinc filter order
  [then]


  [ifdef] DFSDM_DFSDM0_JDATAR_DEF
    \
    \ @brief DFSDM data register for injected group
    \ Address offset: 0x118
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM_JDATACH                  \ [0x00 : 3] Injected channel most recently converted
    $08 constant DFSDM_JDATA                    \ [0x08 : 24] Injected group conversion data
  [then]


  [ifdef] DFSDM_DFSDM0_RDATAR_DEF
    \
    \ @brief DFSDM data register for the regular channel
    \ Address offset: 0x11C
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM_RDATACH                  \ [0x00 : 3] Regular channel most recently converted
    $04 constant DFSDM_RPEND                    \ [0x04] Regular channel pending data
    $08 constant DFSDM_RDATA                    \ [0x08 : 24] Regular channel conversion data
  [then]


  [ifdef] DFSDM_DFSDM0_AWHTR_DEF
    \
    \ @brief DFSDM analog watchdog high threshold register
    \ Address offset: 0x120
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM_BKAWH                    \ [0x00 : 4] Break signal assignment to analog watchdog high threshold event
    $08 constant DFSDM_AWHT                     \ [0x08 : 24] Analog watchdog high threshold
  [then]


  [ifdef] DFSDM_DFSDM0_AWLTR_DEF
    \
    \ @brief DFSDM analog watchdog low threshold register
    \ Address offset: 0x124
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM_BKAWL                    \ [0x00 : 4] Break signal assignment to analog watchdog low threshold event
    $08 constant DFSDM_AWLT                     \ [0x08 : 24] Analog watchdog low threshold
  [then]


  [ifdef] DFSDM_DFSDM0_AWSR_DEF
    \
    \ @brief DFSDM analog watchdog status register
    \ Address offset: 0x128
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM_AWLTF                    \ [0x00 : 8] Analog watchdog low threshold flag
    $08 constant DFSDM_AWHTF                    \ [0x08 : 8] Analog watchdog high threshold flag
  [then]


  [ifdef] DFSDM_DFSDM0_AWCFR_DEF
    \
    \ @brief DFSDM analog watchdog clear flag register
    \ Address offset: 0x12C
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM_CLRAWLTF                 \ [0x00 : 8] Clear the analog watchdog low threshold flag
    $08 constant DFSDM_CLRAWHTF                 \ [0x08 : 8] Clear the analog watchdog high threshold flag
  [then]


  [ifdef] DFSDM_DFSDM0_EXMAX_DEF
    \
    \ @brief DFSDM Extremes detector maximum register
    \ Address offset: 0x130
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM_EXMAXCH                  \ [0x00 : 3] Extremes detector maximum data channel
    $08 constant DFSDM_EXMAX                    \ [0x08 : 24] Extremes detector maximum value
  [then]


  [ifdef] DFSDM_DFSDM0_EXMIN_DEF
    \
    \ @brief DFSDM Extremes detector minimum register
    \ Address offset: 0x134
    \ Reset value: 0x7FFFFF00
    \
    $00 constant DFSDM_EXMINCH                  \ [0x00 : 3] Extremes detector minimum data channel
    $08 constant DFSDM_EXMIN                    \ [0x08 : 24] Extremes detector minimum value
  [then]


  [ifdef] DFSDM_DFSDM0_CNVTIMR_DEF
    \
    \ @brief DFSDM conversion timer register
    \ Address offset: 0x138
    \ Reset value: 0x00000000
    \
    $04 constant DFSDM_CNVCNT                   \ [0x04 : 28] 28-bit timer counting conversion time
  [then]


  [ifdef] DFSDM_DFSDM1_CR1_DEF
    \
    \ @brief DFSDM control register 1
    \ Address offset: 0x180
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM_DFEN                     \ [0x00] DFSDM enable
    $01 constant DFSDM_JSWSTART                 \ [0x01] Start a conversion of the injected group of channels
    $03 constant DFSDM_JSYNC                    \ [0x03] Launch an injected conversion synchronously with the DFSDM0 JSWSTART trigger
    $04 constant DFSDM_JSCAN                    \ [0x04] Scanning conversion mode for injected conversions
    $05 constant DFSDM_JDMAEN                   \ [0x05] DMA channel enabled to read data for the injected channel group
    $08 constant DFSDM_JEXTSEL                  \ [0x08 : 5] Trigger signal selection for launching injected conversions
    $0d constant DFSDM_JEXTEN                   \ [0x0d : 2] Trigger enable and trigger edge selection for injected conversions
    $11 constant DFSDM_RSWSTART                 \ [0x11] Software start of a conversion on the regular channel
    $12 constant DFSDM_RCONT                    \ [0x12] Continuous mode selection for regular conversions
    $13 constant DFSDM_RSYNC                    \ [0x13] Launch regular conversion synchronously with DFSDM0
    $15 constant DFSDM_RDMAEN                   \ [0x15] DMA channel enabled to read data for the regular conversion
    $18 constant DFSDM_RCH                      \ [0x18 : 3] Regular channel selection
    $1d constant DFSDM_FAST                     \ [0x1d] Fast conversion mode selection for regular conversions
    $1e constant DFSDM_AWFSEL                   \ [0x1e] Analog watchdog fast mode select
  [then]


  [ifdef] DFSDM_DFSDM1_CR2_DEF
    \
    \ @brief DFSDM control register 2
    \ Address offset: 0x184
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM_JEOCIE                   \ [0x00] Injected end of conversion interrupt enable
    $01 constant DFSDM_REOCIE                   \ [0x01] Regular end of conversion interrupt enable
    $02 constant DFSDM_JOVRIE                   \ [0x02] Injected data overrun interrupt enable
    $03 constant DFSDM_ROVRIE                   \ [0x03] Regular data overrun interrupt enable
    $04 constant DFSDM_AWDIE                    \ [0x04] Analog watchdog interrupt enable
    $05 constant DFSDM_SCDIE                    \ [0x05] Short-circuit detector interrupt enable
    $06 constant DFSDM_CKABIE                   \ [0x06] Clock absence interrupt enable
    $08 constant DFSDM_EXCH                     \ [0x08 : 8] Extremes detector channel selection
    $10 constant DFSDM_AWDCH                    \ [0x10 : 8] Analog watchdog channel selection
  [then]


  [ifdef] DFSDM_DFSDM1_ISR_DEF
    \
    \ @brief DFSDM interrupt and status register
    \ Address offset: 0x188
    \ Reset value: 0x00FF0000
    \
    $00 constant DFSDM_JEOCF                    \ [0x00] End of injected conversion flag
    $01 constant DFSDM_REOCF                    \ [0x01] End of regular conversion flag
    $02 constant DFSDM_JOVRF                    \ [0x02] Injected conversion overrun flag
    $03 constant DFSDM_ROVRF                    \ [0x03] Regular conversion overrun flag
    $04 constant DFSDM_AWDF                     \ [0x04] Analog watchdog
    $0d constant DFSDM_JCIP                     \ [0x0d] Injected conversion in progress status
    $0e constant DFSDM_RCIP                     \ [0x0e] Regular conversion in progress status
    $10 constant DFSDM_CKABF                    \ [0x10 : 8] Clock absence flag
    $18 constant DFSDM_SCDF                     \ [0x18 : 8] short-circuit detector flag
  [then]


  [ifdef] DFSDM_DFSDM1_ICR_DEF
    \
    \ @brief DFSDM interrupt flag clear register
    \ Address offset: 0x18C
    \ Reset value: 0x00000000
    \
    $02 constant DFSDM_CLRJOVRF                 \ [0x02] Clear the injected conversion overrun flag
    $03 constant DFSDM_CLRROVRF                 \ [0x03] Clear the regular conversion overrun flag
    $10 constant DFSDM_CLRCKABF                 \ [0x10 : 8] Clear the clock absence flag
    $18 constant DFSDM_CLRSCDF                  \ [0x18 : 8] Clear the short-circuit detector flag
  [then]


  [ifdef] DFSDM_DFSDM1_JCHGR_DEF
    \
    \ @brief DFSDM injected channel group selection register
    \ Address offset: 0x190
    \ Reset value: 0x00000001
    \
    $00 constant DFSDM_JCHG                     \ [0x00 : 8] Injected channel group selection
  [then]


  [ifdef] DFSDM_DFSDM1_FCR_DEF
    \
    \ @brief DFSDM filter control register
    \ Address offset: 0x194
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM_IOSR                     \ [0x00 : 8] Integrator oversampling ratio (averaging length)
    $10 constant DFSDM_FOSR                     \ [0x10 : 10] Sinc filter oversampling ratio (decimation rate)
    $1d constant DFSDM_FORD                     \ [0x1d : 3] Sinc filter order
  [then]


  [ifdef] DFSDM_DFSDM1_JDATAR_DEF
    \
    \ @brief DFSDM data register for injected group
    \ Address offset: 0x198
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM_JDATACH                  \ [0x00 : 3] Injected channel most recently converted
    $08 constant DFSDM_JDATA                    \ [0x08 : 24] Injected group conversion data
  [then]


  [ifdef] DFSDM_DFSDM1_RDATAR_DEF
    \
    \ @brief DFSDM data register for the regular channel
    \ Address offset: 0x198
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM_RDATACH                  \ [0x00 : 3] Regular channel most recently converted
    $04 constant DFSDM_RPEND                    \ [0x04] Regular channel pending data
    $08 constant DFSDM_RDATA                    \ [0x08 : 24] Regular channel conversion data
  [then]


  [ifdef] DFSDM_DFSDM1_AWHTR_DEF
    \
    \ @brief DFSDM analog watchdog high threshold register
    \ Address offset: 0x1A0
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM_BKAWH                    \ [0x00 : 4] Break signal assignment to analog watchdog high threshold event
    $08 constant DFSDM_AWHT                     \ [0x08 : 24] Analog watchdog high threshold
  [then]


  [ifdef] DFSDM_DFSDM1_AWLTR_DEF
    \
    \ @brief DFSDM analog watchdog low threshold register
    \ Address offset: 0x1A4
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM_BKAWL                    \ [0x00 : 4] Break signal assignment to analog watchdog low threshold event
    $08 constant DFSDM_AWLT                     \ [0x08 : 24] Analog watchdog low threshold
  [then]


  [ifdef] DFSDM_DFSDM1_AWSR_DEF
    \
    \ @brief DFSDM analog watchdog status register
    \ Address offset: 0x1A8
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM_AWLTF                    \ [0x00 : 8] Analog watchdog low threshold flag
    $08 constant DFSDM_AWHTF                    \ [0x08 : 8] Analog watchdog high threshold flag
  [then]


  [ifdef] DFSDM_DFSDM1_AWCFR_DEF
    \
    \ @brief DFSDM analog watchdog clear flag register
    \ Address offset: 0x1AC
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM_CLRAWLTF                 \ [0x00 : 8] Clear the analog watchdog low threshold flag
    $08 constant DFSDM_CLRAWHTF                 \ [0x08 : 8] Clear the analog watchdog high threshold flag
  [then]


  [ifdef] DFSDM_DFSDM1_EXMAX_DEF
    \
    \ @brief DFSDM Extremes detector maximum register
    \ Address offset: 0x1B0
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM_EXMAXCH                  \ [0x00 : 3] Extremes detector maximum data channel
    $08 constant DFSDM_EXMAX                    \ [0x08 : 24] Extremes detector maximum value
  [then]


  [ifdef] DFSDM_DFSDM1_EXMIN_DEF
    \
    \ @brief DFSDM Extremes detector minimum register
    \ Address offset: 0x1B4
    \ Reset value: 0x7FFFFF00
    \
    $00 constant DFSDM_EXMINCH                  \ [0x00 : 3] Extremes detector minimum data channel
    $08 constant DFSDM_EXMIN                    \ [0x08 : 24] Extremes detector minimum value
  [then]


  [ifdef] DFSDM_DFSDM1_CNVTIMR_DEF
    \
    \ @brief DFSDM conversion timer register
    \ Address offset: 0x1B8
    \ Reset value: 0x00000000
    \
    $04 constant DFSDM_CNVCNT                   \ [0x04 : 28] 28-bit timer counting conversion time
  [then]


  [ifdef] DFSDM_DFSDM2_CR1_DEF
    \
    \ @brief DFSDM control register 1
    \ Address offset: 0x200
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM_DFEN                     \ [0x00] DFSDM enable
    $01 constant DFSDM_JSWSTART                 \ [0x01] Start a conversion of the injected group of channels
    $03 constant DFSDM_JSYNC                    \ [0x03] Launch an injected conversion synchronously with the DFSDM0 JSWSTART trigger
    $04 constant DFSDM_JSCAN                    \ [0x04] Scanning conversion mode for injected conversions
    $05 constant DFSDM_JDMAEN                   \ [0x05] DMA channel enabled to read data for the injected channel group
    $08 constant DFSDM_JEXTSEL                  \ [0x08 : 5] Trigger signal selection for launching injected conversions
    $0d constant DFSDM_JEXTEN                   \ [0x0d : 2] Trigger enable and trigger edge selection for injected conversions
    $11 constant DFSDM_RSWSTART                 \ [0x11] Software start of a conversion on the regular channel
    $12 constant DFSDM_RCONT                    \ [0x12] Continuous mode selection for regular conversions
    $13 constant DFSDM_RSYNC                    \ [0x13] Launch regular conversion synchronously with DFSDM0
    $15 constant DFSDM_RDMAEN                   \ [0x15] DMA channel enabled to read data for the regular conversion
    $18 constant DFSDM_RCH                      \ [0x18 : 3] Regular channel selection
    $1d constant DFSDM_FAST                     \ [0x1d] Fast conversion mode selection for regular conversions
    $1e constant DFSDM_AWFSEL                   \ [0x1e] Analog watchdog fast mode select
  [then]


  [ifdef] DFSDM_DFSDM2_CR2_DEF
    \
    \ @brief DFSDM control register 2
    \ Address offset: 0x204
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM_JEOCIE                   \ [0x00] Injected end of conversion interrupt enable
    $01 constant DFSDM_REOCIE                   \ [0x01] Regular end of conversion interrupt enable
    $02 constant DFSDM_JOVRIE                   \ [0x02] Injected data overrun interrupt enable
    $03 constant DFSDM_ROVRIE                   \ [0x03] Regular data overrun interrupt enable
    $04 constant DFSDM_AWDIE                    \ [0x04] Analog watchdog interrupt enable
    $05 constant DFSDM_SCDIE                    \ [0x05] Short-circuit detector interrupt enable
    $06 constant DFSDM_CKABIE                   \ [0x06] Clock absence interrupt enable
    $08 constant DFSDM_EXCH                     \ [0x08 : 8] Extremes detector channel selection
    $10 constant DFSDM_AWDCH                    \ [0x10 : 8] Analog watchdog channel selection
  [then]


  [ifdef] DFSDM_DFSDM2_ISR_DEF
    \
    \ @brief DFSDM interrupt and status register
    \ Address offset: 0x208
    \ Reset value: 0x00FF0000
    \
    $00 constant DFSDM_JEOCF                    \ [0x00] End of injected conversion flag
    $01 constant DFSDM_REOCF                    \ [0x01] End of regular conversion flag
    $02 constant DFSDM_JOVRF                    \ [0x02] Injected conversion overrun flag
    $03 constant DFSDM_ROVRF                    \ [0x03] Regular conversion overrun flag
    $04 constant DFSDM_AWDF                     \ [0x04] Analog watchdog
    $0d constant DFSDM_JCIP                     \ [0x0d] Injected conversion in progress status
    $0e constant DFSDM_RCIP                     \ [0x0e] Regular conversion in progress status
    $10 constant DFSDM_CKABF                    \ [0x10 : 8] Clock absence flag
    $18 constant DFSDM_SCDF                     \ [0x18 : 8] short-circuit detector flag
  [then]


  [ifdef] DFSDM_DFSDM2_ICR_DEF
    \
    \ @brief DFSDM interrupt flag clear register
    \ Address offset: 0x20C
    \ Reset value: 0x00000000
    \
    $02 constant DFSDM_CLRJOVRF                 \ [0x02] Clear the injected conversion overrun flag
    $03 constant DFSDM_CLRROVRF                 \ [0x03] Clear the regular conversion overrun flag
    $10 constant DFSDM_CLRCKABF                 \ [0x10 : 8] Clear the clock absence flag
    $18 constant DFSDM_CLRSCDF                  \ [0x18 : 8] Clear the short-circuit detector flag
  [then]


  [ifdef] DFSDM_DFSDM2_JCHGR_DEF
    \
    \ @brief DFSDM injected channel group selection register
    \ Address offset: 0x210
    \ Reset value: 0x00000001
    \
    $00 constant DFSDM_JCHG                     \ [0x00 : 8] Injected channel group selection
  [then]


  [ifdef] DFSDM_DFSDM2_FCR_DEF
    \
    \ @brief DFSDM filter control register
    \ Address offset: 0x214
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM_IOSR                     \ [0x00 : 8] Integrator oversampling ratio (averaging length)
    $10 constant DFSDM_FOSR                     \ [0x10 : 10] Sinc filter oversampling ratio (decimation rate)
    $1d constant DFSDM_FORD                     \ [0x1d : 3] Sinc filter order
  [then]


  [ifdef] DFSDM_DFSDM2_JDATAR_DEF
    \
    \ @brief DFSDM data register for injected group
    \ Address offset: 0x218
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM_JDATACH                  \ [0x00 : 3] Injected channel most recently converted
    $08 constant DFSDM_JDATA                    \ [0x08 : 24] Injected group conversion data
  [then]


  [ifdef] DFSDM_DFSDM2_RDATAR_DEF
    \
    \ @brief DFSDM data register for the regular channel
    \ Address offset: 0x218
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM_RDATACH                  \ [0x00 : 3] Regular channel most recently converted
    $04 constant DFSDM_RPEND                    \ [0x04] Regular channel pending data
    $08 constant DFSDM_RDATA                    \ [0x08 : 24] Regular channel conversion data
  [then]


  [ifdef] DFSDM_DFSDM2_AWHTR_DEF
    \
    \ @brief DFSDM analog watchdog high threshold register
    \ Address offset: 0x220
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM_BKAWH                    \ [0x00 : 4] Break signal assignment to analog watchdog high threshold event
    $08 constant DFSDM_AWHT                     \ [0x08 : 24] Analog watchdog high threshold
  [then]


  [ifdef] DFSDM_DFSDM2_AWLTR_DEF
    \
    \ @brief DFSDM analog watchdog low threshold register
    \ Address offset: 0x224
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM_BKAWL                    \ [0x00 : 4] Break signal assignment to analog watchdog low threshold event
    $08 constant DFSDM_AWLT                     \ [0x08 : 24] Analog watchdog low threshold
  [then]


  [ifdef] DFSDM_DFSDM2_AWSR_DEF
    \
    \ @brief DFSDM analog watchdog status register
    \ Address offset: 0x228
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM_AWLTF                    \ [0x00 : 8] Analog watchdog low threshold flag
    $08 constant DFSDM_AWHTF                    \ [0x08 : 8] Analog watchdog high threshold flag
  [then]


  [ifdef] DFSDM_DFSDM2_AWCFR_DEF
    \
    \ @brief DFSDM analog watchdog clear flag register
    \ Address offset: 0x22C
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM_CLRAWLTF                 \ [0x00 : 8] Clear the analog watchdog low threshold flag
    $08 constant DFSDM_CLRAWHTF                 \ [0x08 : 8] Clear the analog watchdog high threshold flag
  [then]


  [ifdef] DFSDM_DFSDM2_EXMAX_DEF
    \
    \ @brief DFSDM Extremes detector maximum register
    \ Address offset: 0x230
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM_EXMAXCH                  \ [0x00 : 3] Extremes detector maximum data channel
    $08 constant DFSDM_EXMAX                    \ [0x08 : 24] Extremes detector maximum value
  [then]


  [ifdef] DFSDM_DFSDM2_EXMIN_DEF
    \
    \ @brief DFSDM Extremes detector minimum register
    \ Address offset: 0x234
    \ Reset value: 0x7FFFFF00
    \
    $00 constant DFSDM_EXMINCH                  \ [0x00 : 3] Extremes detector minimum data channel
    $08 constant DFSDM_EXMIN                    \ [0x08 : 24] Extremes detector minimum value
  [then]


  [ifdef] DFSDM_DFSDM2_CNVTIMR_DEF
    \
    \ @brief DFSDM conversion timer register
    \ Address offset: 0x238
    \ Reset value: 0x00000000
    \
    $04 constant DFSDM_CNVCNT                   \ [0x04 : 28] 28-bit timer counting conversion time
  [then]


  [ifdef] DFSDM_DFSDM3_AWHTR_DEF
    \
    \ @brief DFSDM analog watchdog high threshold register
    \ Address offset: 0x2A0
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM_BKAWH                    \ [0x00 : 4] Break signal assignment to analog watchdog high threshold event
    $08 constant DFSDM_AWHT                     \ [0x08 : 24] Analog watchdog high threshold
  [then]


  [ifdef] DFSDM_DFSDM3_AWLTR_DEF
    \
    \ @brief DFSDM analog watchdog low threshold register
    \ Address offset: 0x2A4
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM_BKAWL                    \ [0x00 : 4] Break signal assignment to analog watchdog low threshold event
    $08 constant DFSDM_AWLT                     \ [0x08 : 24] Analog watchdog low threshold
  [then]


  [ifdef] DFSDM_DFSDM3_AWSR_DEF
    \
    \ @brief DFSDM analog watchdog status register
    \ Address offset: 0x2A8
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM_AWLTF                    \ [0x00 : 8] Analog watchdog low threshold flag
    $08 constant DFSDM_AWHTF                    \ [0x08 : 8] Analog watchdog high threshold flag
  [then]


  [ifdef] DFSDM_DFSDM3_AWCFR_DEF
    \
    \ @brief DFSDM analog watchdog clear flag register
    \ Address offset: 0x2AC
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM_CLRAWLTF                 \ [0x00 : 8] Clear the analog watchdog low threshold flag
    $08 constant DFSDM_CLRAWHTF                 \ [0x08 : 8] Clear the analog watchdog high threshold flag
  [then]


  [ifdef] DFSDM_DFSDM3_EXMAX_DEF
    \
    \ @brief DFSDM Extremes detector maximum register
    \ Address offset: 0x2B0
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM_EXMAXCH                  \ [0x00 : 3] Extremes detector maximum data channel
    $08 constant DFSDM_EXMAX                    \ [0x08 : 24] Extremes detector maximum value
  [then]


  [ifdef] DFSDM_DFSDM3_EXMIN_DEF
    \
    \ @brief DFSDM Extremes detector minimum register
    \ Address offset: 0x2B4
    \ Reset value: 0x7FFFFF00
    \
    $00 constant DFSDM_EXMINCH                  \ [0x00 : 3] Extremes detector minimum data channel
    $08 constant DFSDM_EXMIN                    \ [0x08 : 24] Extremes detector minimum value
  [then]


  [ifdef] DFSDM_DFSDM3_CNVTIMR_DEF
    \
    \ @brief DFSDM conversion timer register
    \ Address offset: 0x2B8
    \ Reset value: 0x00000000
    \
    $04 constant DFSDM_CNVCNT                   \ [0x04 : 28] 28-bit timer counting conversion time
  [then]


  [ifdef] DFSDM_DFSDM3_JCHGR_DEF
    \
    \ @brief DFSDM injected channel group selection register
    \ Address offset: 0x310
    \ Reset value: 0x00000001
    \
    $00 constant DFSDM_JCHG                     \ [0x00 : 8] Injected channel group selection
  [then]


  [ifdef] DFSDM_DFSDM3_FCR_DEF
    \
    \ @brief DFSDM filter control register
    \ Address offset: 0x314
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM_IOSR                     \ [0x00 : 8] Integrator oversampling ratio (averaging length)
    $10 constant DFSDM_FOSR                     \ [0x10 : 10] Sinc filter oversampling ratio (decimation rate)
    $1d constant DFSDM_FORD                     \ [0x1d : 3] Sinc filter order
  [then]


  [ifdef] DFSDM_DFSDM3_JDATAR_DEF
    \
    \ @brief DFSDM data register for injected group
    \ Address offset: 0x318
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM_JDATACH                  \ [0x00 : 3] Injected channel most recently converted
    $08 constant DFSDM_JDATA                    \ [0x08 : 24] Injected group conversion data
  [then]


  [ifdef] DFSDM_DFSDM3_RDATAR_DEF
    \
    \ @brief DFSDM data register for the regular channel
    \ Address offset: 0x318
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM_RDATACH                  \ [0x00 : 3] Regular channel most recently converted
    $04 constant DFSDM_RPEND                    \ [0x04] Regular channel pending data
    $08 constant DFSDM_RDATA                    \ [0x08 : 24] Regular channel conversion data
  [then]


  [ifdef] DFSDM_DFSDM3_CR1_DEF
    \
    \ @brief DFSDM control register 1
    \ Address offset: 0x380
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM_DFEN                     \ [0x00] DFSDM enable
    $01 constant DFSDM_JSWSTART                 \ [0x01] Start a conversion of the injected group of channels
    $03 constant DFSDM_JSYNC                    \ [0x03] Launch an injected conversion synchronously with the DFSDM0 JSWSTART trigger
    $04 constant DFSDM_JSCAN                    \ [0x04] Scanning conversion mode for injected conversions
    $05 constant DFSDM_JDMAEN                   \ [0x05] DMA channel enabled to read data for the injected channel group
    $08 constant DFSDM_JEXTSEL                  \ [0x08 : 5] Trigger signal selection for launching injected conversions
    $0d constant DFSDM_JEXTEN                   \ [0x0d : 2] Trigger enable and trigger edge selection for injected conversions
    $11 constant DFSDM_RSWSTART                 \ [0x11] Software start of a conversion on the regular channel
    $12 constant DFSDM_RCONT                    \ [0x12] Continuous mode selection for regular conversions
    $13 constant DFSDM_RSYNC                    \ [0x13] Launch regular conversion synchronously with DFSDM0
    $15 constant DFSDM_RDMAEN                   \ [0x15] DMA channel enabled to read data for the regular conversion
    $18 constant DFSDM_RCH                      \ [0x18 : 3] Regular channel selection
    $1d constant DFSDM_FAST                     \ [0x1d] Fast conversion mode selection for regular conversions
    $1e constant DFSDM_AWFSEL                   \ [0x1e] Analog watchdog fast mode select
  [then]


  [ifdef] DFSDM_DFSDM3_CR2_DEF
    \
    \ @brief DFSDM control register 2
    \ Address offset: 0x384
    \ Reset value: 0x00000000
    \
    $00 constant DFSDM_JEOCIE                   \ [0x00] Injected end of conversion interrupt enable
    $01 constant DFSDM_REOCIE                   \ [0x01] Regular end of conversion interrupt enable
    $02 constant DFSDM_JOVRIE                   \ [0x02] Injected data overrun interrupt enable
    $03 constant DFSDM_ROVRIE                   \ [0x03] Regular data overrun interrupt enable
    $04 constant DFSDM_AWDIE                    \ [0x04] Analog watchdog interrupt enable
    $05 constant DFSDM_SCDIE                    \ [0x05] Short-circuit detector interrupt enable
    $06 constant DFSDM_CKABIE                   \ [0x06] Clock absence interrupt enable
    $08 constant DFSDM_EXCH                     \ [0x08 : 8] Extremes detector channel selection
    $10 constant DFSDM_AWDCH                    \ [0x10 : 8] Analog watchdog channel selection
  [then]


  [ifdef] DFSDM_DFSDM3_ISR_DEF
    \
    \ @brief DFSDM interrupt and status register
    \ Address offset: 0x388
    \ Reset value: 0x00FF0000
    \
    $00 constant DFSDM_JEOCF                    \ [0x00] End of injected conversion flag
    $01 constant DFSDM_REOCF                    \ [0x01] End of regular conversion flag
    $02 constant DFSDM_JOVRF                    \ [0x02] Injected conversion overrun flag
    $03 constant DFSDM_ROVRF                    \ [0x03] Regular conversion overrun flag
    $04 constant DFSDM_AWDF                     \ [0x04] Analog watchdog
    $0d constant DFSDM_JCIP                     \ [0x0d] Injected conversion in progress status
    $0e constant DFSDM_RCIP                     \ [0x0e] Regular conversion in progress status
    $10 constant DFSDM_CKABF                    \ [0x10 : 8] Clock absence flag
    $18 constant DFSDM_SCDF                     \ [0x18 : 8] short-circuit detector flag
  [then]


  [ifdef] DFSDM_DFSDM3_ICR_DEF
    \
    \ @brief DFSDM interrupt flag clear register
    \ Address offset: 0x38C
    \ Reset value: 0x00000000
    \
    $02 constant DFSDM_CLRJOVRF                 \ [0x02] Clear the injected conversion overrun flag
    $03 constant DFSDM_CLRROVRF                 \ [0x03] Clear the regular conversion overrun flag
    $10 constant DFSDM_CLRCKABF                 \ [0x10 : 8] Clear the clock absence flag
    $18 constant DFSDM_CLRSCDF                  \ [0x18 : 8] Clear the short-circuit detector flag
  [then]

  \
  \ @brief Digital filter for sigma delta modulators
  \
  $00 constant DFSDM_DFSDM_CHCFG0R1     \ DFSDM channel configuration 0 register 1
  $04 constant DFSDM_DFSDM_CHCFG0R2     \ DFSDM channel configuration 0 register 2
  $08 constant DFSDM_DFSDM_AWSCD0R      \ DFSDM analog watchdog and short-circuit detector register
  $0C constant DFSDM_DFSDM_CHWDAT0R     \ DFSDM channel watchdog filter data register
  $10 constant DFSDM_DFSDM_CHDATIN0R    \ DFSDM channel data input register
  $20 constant DFSDM_DFSDM_CHCFG1R1     \ DFSDM channel configuration 1 register 1
  $24 constant DFSDM_DFSDM_CHCFG1R2     \ DFSDM channel configuration 1 register 2
  $28 constant DFSDM_DFSDM_AWSCD1R      \ DFSDM analog watchdog and short-circuit detector register
  $2C constant DFSDM_DFSDM_CHWDAT1R     \ DFSDM channel watchdog filter data register
  $30 constant DFSDM_DFSDM_CHDATIN1R    \ DFSDM channel data input register
  $40 constant DFSDM_DFSDM_CHCFG2R1     \ DFSDM channel configuration 2 register 1
  $44 constant DFSDM_DFSDM_CHCFG2R2     \ DFSDM channel configuration 2 register 2
  $48 constant DFSDM_DFSDM_AWSCD2R      \ DFSDM analog watchdog and short-circuit detector register
  $4C constant DFSDM_DFSDM_CHWDAT2R     \ DFSDM channel watchdog filter data register
  $50 constant DFSDM_DFSDM_CHDATIN2R    \ DFSDM channel data input register
  $60 constant DFSDM_DFSDM_CHCFG3R1     \ DFSDM channel configuration 3 register 1
  $64 constant DFSDM_DFSDM_CHCFG3R2     \ DFSDM channel configuration 3 register 2
  $68 constant DFSDM_DFSDM_AWSCD3R      \ DFSDM analog watchdog and short-circuit detector register
  $6C constant DFSDM_DFSDM_CHWDAT3R     \ DFSDM channel watchdog filter data register
  $70 constant DFSDM_DFSDM_CHDATIN3R    \ DFSDM channel data input register
  $80 constant DFSDM_DFSDM_CHCFG4R1     \ DFSDM channel configuration 4 register 1
  $84 constant DFSDM_DFSDM_CHCFG4R2     \ DFSDM channel configuration 4 register 2
  $88 constant DFSDM_DFSDM_AWSCD4R      \ DFSDM analog watchdog and short-circuit detector register
  $8C constant DFSDM_DFSDM_CHWDAT4R     \ DFSDM channel watchdog filter data register
  $90 constant DFSDM_DFSDM_CHDATIN4R    \ DFSDM channel data input register
  $A0 constant DFSDM_DFSDM_CHCFG5R1     \ DFSDM channel configuration 5 register 1
  $A4 constant DFSDM_DFSDM_CHCFG5R2     \ DFSDM channel configuration 5 register 2
  $A8 constant DFSDM_DFSDM_AWSCD5R      \ DFSDM analog watchdog and short-circuit detector register
  $AC constant DFSDM_DFSDM_CHWDAT5R     \ DFSDM channel watchdog filter data register
  $B0 constant DFSDM_DFSDM_CHDATIN5R    \ DFSDM channel data input register
  $C0 constant DFSDM_DFSDM_CHCFG6R1     \ DFSDM channel configuration 6 register 1
  $C4 constant DFSDM_DFSDM_CHCFG6R2     \ DFSDM channel configuration 6 register 2
  $C8 constant DFSDM_DFSDM_AWSCD6R      \ DFSDM analog watchdog and short-circuit detector register
  $CC constant DFSDM_DFSDM_CHWDAT6R     \ DFSDM channel watchdog filter data register
  $D0 constant DFSDM_DFSDM_CHDATIN6R    \ DFSDM channel data input register
  $E0 constant DFSDM_DFSDM_CHCFG7R1     \ DFSDM channel configuration 7 register 1
  $E4 constant DFSDM_DFSDM_CHCFG7R2     \ DFSDM channel configuration 7 register 2
  $E8 constant DFSDM_DFSDM_AWSCD7R      \ DFSDM analog watchdog and short-circuit detector register
  $EC constant DFSDM_DFSDM_CHWDAT7R     \ DFSDM channel watchdog filter data register
  $F0 constant DFSDM_DFSDM_CHDATIN7R    \ DFSDM channel data input register
  $100 constant DFSDM_DFSDM0_CR1        \ DFSDM control register 1
  $104 constant DFSDM_DFSDM0_CR2        \ DFSDM control register 2
  $108 constant DFSDM_DFSDM0_ISR        \ DFSDM interrupt and status register
  $10C constant DFSDM_DFSDM0_ICR        \ DFSDM interrupt flag clear register
  $110 constant DFSDM_DFSDM0_JCHGR      \ DFSDM injected channel group selection register
  $114 constant DFSDM_DFSDM0_FCR        \ DFSDM filter control register
  $118 constant DFSDM_DFSDM0_JDATAR     \ DFSDM data register for injected group
  $11C constant DFSDM_DFSDM0_RDATAR     \ DFSDM data register for the regular channel
  $120 constant DFSDM_DFSDM0_AWHTR      \ DFSDM analog watchdog high threshold register
  $124 constant DFSDM_DFSDM0_AWLTR      \ DFSDM analog watchdog low threshold register
  $128 constant DFSDM_DFSDM0_AWSR       \ DFSDM analog watchdog status register
  $12C constant DFSDM_DFSDM0_AWCFR      \ DFSDM analog watchdog clear flag register
  $130 constant DFSDM_DFSDM0_EXMAX      \ DFSDM Extremes detector maximum register
  $134 constant DFSDM_DFSDM0_EXMIN      \ DFSDM Extremes detector minimum register
  $138 constant DFSDM_DFSDM0_CNVTIMR    \ DFSDM conversion timer register
  $180 constant DFSDM_DFSDM1_CR1        \ DFSDM control register 1
  $184 constant DFSDM_DFSDM1_CR2        \ DFSDM control register 2
  $188 constant DFSDM_DFSDM1_ISR        \ DFSDM interrupt and status register
  $18C constant DFSDM_DFSDM1_ICR        \ DFSDM interrupt flag clear register
  $190 constant DFSDM_DFSDM1_JCHGR      \ DFSDM injected channel group selection register
  $194 constant DFSDM_DFSDM1_FCR        \ DFSDM filter control register
  $198 constant DFSDM_DFSDM1_JDATAR     \ DFSDM data register for injected group
  $198 constant DFSDM_DFSDM1_RDATAR     \ DFSDM data register for the regular channel
  $1A0 constant DFSDM_DFSDM1_AWHTR      \ DFSDM analog watchdog high threshold register
  $1A4 constant DFSDM_DFSDM1_AWLTR      \ DFSDM analog watchdog low threshold register
  $1A8 constant DFSDM_DFSDM1_AWSR       \ DFSDM analog watchdog status register
  $1AC constant DFSDM_DFSDM1_AWCFR      \ DFSDM analog watchdog clear flag register
  $1B0 constant DFSDM_DFSDM1_EXMAX      \ DFSDM Extremes detector maximum register
  $1B4 constant DFSDM_DFSDM1_EXMIN      \ DFSDM Extremes detector minimum register
  $1B8 constant DFSDM_DFSDM1_CNVTIMR    \ DFSDM conversion timer register
  $200 constant DFSDM_DFSDM2_CR1        \ DFSDM control register 1
  $204 constant DFSDM_DFSDM2_CR2        \ DFSDM control register 2
  $208 constant DFSDM_DFSDM2_ISR        \ DFSDM interrupt and status register
  $20C constant DFSDM_DFSDM2_ICR        \ DFSDM interrupt flag clear register
  $210 constant DFSDM_DFSDM2_JCHGR      \ DFSDM injected channel group selection register
  $214 constant DFSDM_DFSDM2_FCR        \ DFSDM filter control register
  $218 constant DFSDM_DFSDM2_JDATAR     \ DFSDM data register for injected group
  $218 constant DFSDM_DFSDM2_RDATAR     \ DFSDM data register for the regular channel
  $220 constant DFSDM_DFSDM2_AWHTR      \ DFSDM analog watchdog high threshold register
  $224 constant DFSDM_DFSDM2_AWLTR      \ DFSDM analog watchdog low threshold register
  $228 constant DFSDM_DFSDM2_AWSR       \ DFSDM analog watchdog status register
  $22C constant DFSDM_DFSDM2_AWCFR      \ DFSDM analog watchdog clear flag register
  $230 constant DFSDM_DFSDM2_EXMAX      \ DFSDM Extremes detector maximum register
  $234 constant DFSDM_DFSDM2_EXMIN      \ DFSDM Extremes detector minimum register
  $238 constant DFSDM_DFSDM2_CNVTIMR    \ DFSDM conversion timer register
  $2A0 constant DFSDM_DFSDM3_AWHTR      \ DFSDM analog watchdog high threshold register
  $2A4 constant DFSDM_DFSDM3_AWLTR      \ DFSDM analog watchdog low threshold register
  $2A8 constant DFSDM_DFSDM3_AWSR       \ DFSDM analog watchdog status register
  $2AC constant DFSDM_DFSDM3_AWCFR      \ DFSDM analog watchdog clear flag register
  $2B0 constant DFSDM_DFSDM3_EXMAX      \ DFSDM Extremes detector maximum register
  $2B4 constant DFSDM_DFSDM3_EXMIN      \ DFSDM Extremes detector minimum register
  $2B8 constant DFSDM_DFSDM3_CNVTIMR    \ DFSDM conversion timer register
  $310 constant DFSDM_DFSDM3_JCHGR      \ DFSDM injected channel group selection register
  $314 constant DFSDM_DFSDM3_FCR        \ DFSDM filter control register
  $318 constant DFSDM_DFSDM3_JDATAR     \ DFSDM data register for injected group
  $318 constant DFSDM_DFSDM3_RDATAR     \ DFSDM data register for the regular channel
  $380 constant DFSDM_DFSDM3_CR1        \ DFSDM control register 1
  $384 constant DFSDM_DFSDM3_CR2        \ DFSDM control register 2
  $388 constant DFSDM_DFSDM3_ISR        \ DFSDM interrupt and status register
  $38C constant DFSDM_DFSDM3_ICR        \ DFSDM interrupt flag clear register

: DFSDM_DEF ; [then]
