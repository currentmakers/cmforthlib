\
\ @file dfsdm.fs
\ @brief Digital filter for sigma delta       modulators
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief DFSDM channel configuration 0 register 1
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000003 constant DFSDM_DFSDM_CHCFG0R1_SITP                        \ Serial interface type for channel 0
$0000000c constant DFSDM_DFSDM_CHCFG0R1_SPICKSEL                    \ SPI clock select for channel 0
$00000020 constant DFSDM_DFSDM_CHCFG0R1_SCDEN                       \ Short-circuit detector enable on channel 0
$00000040 constant DFSDM_DFSDM_CHCFG0R1_CKABEN                      \ Clock absence detector enable on channel 0
$00000080 constant DFSDM_DFSDM_CHCFG0R1_CHEN                        \ Channel 0 enable
$00000100 constant DFSDM_DFSDM_CHCFG0R1_CHINSEL                     \ Channel inputs selection
$00003000 constant DFSDM_DFSDM_CHCFG0R1_DATMPX                      \ Input data multiplexer for channel 0
$0000c000 constant DFSDM_DFSDM_CHCFG0R1_DATPACK                     \ Data packing mode in DFSDM_CHDATINyR register
$00ff0000 constant DFSDM_DFSDM_CHCFG0R1_CKOUTDIV                    \ Output serial clock divider
$40000000 constant DFSDM_DFSDM_CHCFG0R1_CKOUTSRC                    \ Output serial clock source selection
$80000000 constant DFSDM_DFSDM_CHCFG0R1_DFSDMEN                     \ Global enable for DFSDM interface


\
\ @brief DFSDM channel configuration 1 register 1
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000003 constant DFSDM_DFSDM_CHCFG1R1_SITP                        \ Serial interface type for channel 1
$0000000c constant DFSDM_DFSDM_CHCFG1R1_SPICKSEL                    \ SPI clock select for channel 1
$00000020 constant DFSDM_DFSDM_CHCFG1R1_SCDEN                       \ Short-circuit detector enable on channel 1
$00000040 constant DFSDM_DFSDM_CHCFG1R1_CKABEN                      \ Clock absence detector enable on channel 1
$00000080 constant DFSDM_DFSDM_CHCFG1R1_CHEN                        \ Channel 1 enable
$00000100 constant DFSDM_DFSDM_CHCFG1R1_CHINSEL                     \ Channel inputs selection
$00003000 constant DFSDM_DFSDM_CHCFG1R1_DATMPX                      \ Input data multiplexer for channel 1
$0000c000 constant DFSDM_DFSDM_CHCFG1R1_DATPACK                     \ Data packing mode in DFSDM_CHDATINyR register
$00ff0000 constant DFSDM_DFSDM_CHCFG1R1_CKOUTDIV                    \ Output serial clock divider
$40000000 constant DFSDM_DFSDM_CHCFG1R1_CKOUTSRC                    \ Output serial clock source selection
$80000000 constant DFSDM_DFSDM_CHCFG1R1_DFSDMEN                     \ Global enable for DFSDM interface


\
\ @brief DFSDM channel configuration 2 register 1
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000003 constant DFSDM_DFSDM_CHCFG2R1_SITP                        \ Serial interface type for channel 2
$0000000c constant DFSDM_DFSDM_CHCFG2R1_SPICKSEL                    \ SPI clock select for channel 2
$00000020 constant DFSDM_DFSDM_CHCFG2R1_SCDEN                       \ Short-circuit detector enable on channel 2
$00000040 constant DFSDM_DFSDM_CHCFG2R1_CKABEN                      \ Clock absence detector enable on channel 2
$00000080 constant DFSDM_DFSDM_CHCFG2R1_CHEN                        \ Channel 2 enable
$00000100 constant DFSDM_DFSDM_CHCFG2R1_CHINSEL                     \ Channel inputs selection
$00003000 constant DFSDM_DFSDM_CHCFG2R1_DATMPX                      \ Input data multiplexer for channel 2
$0000c000 constant DFSDM_DFSDM_CHCFG2R1_DATPACK                     \ Data packing mode in DFSDM_CHDATINyR register
$00ff0000 constant DFSDM_DFSDM_CHCFG2R1_CKOUTDIV                    \ Output serial clock divider
$40000000 constant DFSDM_DFSDM_CHCFG2R1_CKOUTSRC                    \ Output serial clock source selection
$80000000 constant DFSDM_DFSDM_CHCFG2R1_DFSDMEN                     \ Global enable for DFSDM interface


\
\ @brief DFSDM channel configuration 3 register 1
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000003 constant DFSDM_DFSDM_CHCFG3R1_SITP                        \ Serial interface type for channel 3
$0000000c constant DFSDM_DFSDM_CHCFG3R1_SPICKSEL                    \ SPI clock select for channel 3
$00000020 constant DFSDM_DFSDM_CHCFG3R1_SCDEN                       \ Short-circuit detector enable on channel 3
$00000040 constant DFSDM_DFSDM_CHCFG3R1_CKABEN                      \ Clock absence detector enable on channel 3
$00000080 constant DFSDM_DFSDM_CHCFG3R1_CHEN                        \ Channel 3 enable
$00000100 constant DFSDM_DFSDM_CHCFG3R1_CHINSEL                     \ Channel inputs selection
$00003000 constant DFSDM_DFSDM_CHCFG3R1_DATMPX                      \ Input data multiplexer for channel 3
$0000c000 constant DFSDM_DFSDM_CHCFG3R1_DATPACK                     \ Data packing mode in DFSDM_CHDATINyR register
$00ff0000 constant DFSDM_DFSDM_CHCFG3R1_CKOUTDIV                    \ Output serial clock divider
$40000000 constant DFSDM_DFSDM_CHCFG3R1_CKOUTSRC                    \ Output serial clock source selection
$80000000 constant DFSDM_DFSDM_CHCFG3R1_DFSDMEN                     \ Global enable for DFSDM interface


\
\ @brief DFSDM channel configuration 4 register 1
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000003 constant DFSDM_DFSDM_CHCFG4R1_SITP                        \ Serial interface type for channel 4
$0000000c constant DFSDM_DFSDM_CHCFG4R1_SPICKSEL                    \ SPI clock select for channel 4
$00000020 constant DFSDM_DFSDM_CHCFG4R1_SCDEN                       \ Short-circuit detector enable on channel 4
$00000040 constant DFSDM_DFSDM_CHCFG4R1_CKABEN                      \ Clock absence detector enable on channel 4
$00000080 constant DFSDM_DFSDM_CHCFG4R1_CHEN                        \ Channel 4 enable
$00000100 constant DFSDM_DFSDM_CHCFG4R1_CHINSEL                     \ Channel inputs selection
$00003000 constant DFSDM_DFSDM_CHCFG4R1_DATMPX                      \ Input data multiplexer for channel 4
$0000c000 constant DFSDM_DFSDM_CHCFG4R1_DATPACK                     \ Data packing mode in DFSDM_CHDATINyR register
$00ff0000 constant DFSDM_DFSDM_CHCFG4R1_CKOUTDIV                    \ Output serial clock divider
$40000000 constant DFSDM_DFSDM_CHCFG4R1_CKOUTSRC                    \ Output serial clock source selection
$80000000 constant DFSDM_DFSDM_CHCFG4R1_DFSDMEN                     \ Global enable for DFSDM interface


\
\ @brief DFSDM channel configuration 5 register 1
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000003 constant DFSDM_DFSDM_CHCFG5R1_SITP                        \ Serial interface type for channel 5
$0000000c constant DFSDM_DFSDM_CHCFG5R1_SPICKSEL                    \ SPI clock select for channel 5
$00000020 constant DFSDM_DFSDM_CHCFG5R1_SCDEN                       \ Short-circuit detector enable on channel 5
$00000040 constant DFSDM_DFSDM_CHCFG5R1_CKABEN                      \ Clock absence detector enable on channel 5
$00000080 constant DFSDM_DFSDM_CHCFG5R1_CHEN                        \ Channel 5 enable
$00000100 constant DFSDM_DFSDM_CHCFG5R1_CHINSEL                     \ Channel inputs selection
$00003000 constant DFSDM_DFSDM_CHCFG5R1_DATMPX                      \ Input data multiplexer for channel 5
$0000c000 constant DFSDM_DFSDM_CHCFG5R1_DATPACK                     \ Data packing mode in DFSDM_CHDATINyR register
$00ff0000 constant DFSDM_DFSDM_CHCFG5R1_CKOUTDIV                    \ Output serial clock divider
$40000000 constant DFSDM_DFSDM_CHCFG5R1_CKOUTSRC                    \ Output serial clock source selection
$80000000 constant DFSDM_DFSDM_CHCFG5R1_DFSDMEN                     \ Global enable for DFSDM interface


\
\ @brief DFSDM channel configuration 6 register 1
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000003 constant DFSDM_DFSDM_CHCFG6R1_SITP                        \ Serial interface type for channel 6
$0000000c constant DFSDM_DFSDM_CHCFG6R1_SPICKSEL                    \ SPI clock select for channel 6
$00000020 constant DFSDM_DFSDM_CHCFG6R1_SCDEN                       \ Short-circuit detector enable on channel 6
$00000040 constant DFSDM_DFSDM_CHCFG6R1_CKABEN                      \ Clock absence detector enable on channel 6
$00000080 constant DFSDM_DFSDM_CHCFG6R1_CHEN                        \ Channel 6 enable
$00000100 constant DFSDM_DFSDM_CHCFG6R1_CHINSEL                     \ Channel inputs selection
$00003000 constant DFSDM_DFSDM_CHCFG6R1_DATMPX                      \ Input data multiplexer for channel 6
$0000c000 constant DFSDM_DFSDM_CHCFG6R1_DATPACK                     \ Data packing mode in DFSDM_CHDATINyR register
$00ff0000 constant DFSDM_DFSDM_CHCFG6R1_CKOUTDIV                    \ Output serial clock divider
$40000000 constant DFSDM_DFSDM_CHCFG6R1_CKOUTSRC                    \ Output serial clock source selection
$80000000 constant DFSDM_DFSDM_CHCFG6R1_DFSDMEN                     \ Global enable for DFSDM interface


\
\ @brief DFSDM channel configuration 7 register 1
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$00000003 constant DFSDM_DFSDM_CHCFG7R1_SITP                        \ Serial interface type for channel 7
$0000000c constant DFSDM_DFSDM_CHCFG7R1_SPICKSEL                    \ SPI clock select for channel 7
$00000020 constant DFSDM_DFSDM_CHCFG7R1_SCDEN                       \ Short-circuit detector enable on channel 7
$00000040 constant DFSDM_DFSDM_CHCFG7R1_CKABEN                      \ Clock absence detector enable on channel 7
$00000080 constant DFSDM_DFSDM_CHCFG7R1_CHEN                        \ Channel 7 enable
$00000100 constant DFSDM_DFSDM_CHCFG7R1_CHINSEL                     \ Channel inputs selection
$00003000 constant DFSDM_DFSDM_CHCFG7R1_DATMPX                      \ Input data multiplexer for channel 7
$0000c000 constant DFSDM_DFSDM_CHCFG7R1_DATPACK                     \ Data packing mode in DFSDM_CHDATINyR register
$00ff0000 constant DFSDM_DFSDM_CHCFG7R1_CKOUTDIV                    \ Output serial clock divider
$40000000 constant DFSDM_DFSDM_CHCFG7R1_CKOUTSRC                    \ Output serial clock source selection
$80000000 constant DFSDM_DFSDM_CHCFG7R1_DFSDMEN                     \ Global enable for DFSDM interface


\
\ @brief DFSDM channel configuration 0 register 2
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$000000f8 constant DFSDM_DFSDM_CHCFG0R2_DTRBS                       \ Data right bit-shift for channel 0
$ffffff00 constant DFSDM_DFSDM_CHCFG0R2_OFFSET                      \ 24-bit calibration offset for channel 0


\
\ @brief DFSDM channel configuration 1 register 2
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$000000f8 constant DFSDM_DFSDM_CHCFG1R2_DTRBS                       \ Data right bit-shift for channel 1
$ffffff00 constant DFSDM_DFSDM_CHCFG1R2_OFFSET                      \ 24-bit calibration offset for channel 1


\
\ @brief DFSDM channel configuration 2 register 2
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$000000f8 constant DFSDM_DFSDM_CHCFG2R2_DTRBS                       \ Data right bit-shift for channel 2
$ffffff00 constant DFSDM_DFSDM_CHCFG2R2_OFFSET                      \ 24-bit calibration offset for channel 2


\
\ @brief DFSDM channel configuration 3 register 2
\ Address offset: 0x2C
\ Reset value: 0x00000000
\

$000000f8 constant DFSDM_DFSDM_CHCFG3R2_DTRBS                       \ Data right bit-shift for channel 3
$ffffff00 constant DFSDM_DFSDM_CHCFG3R2_OFFSET                      \ 24-bit calibration offset for channel 3


\
\ @brief DFSDM channel configuration 4 register 2
\ Address offset: 0x30
\ Reset value: 0x00000000
\

$000000f8 constant DFSDM_DFSDM_CHCFG4R2_DTRBS                       \ Data right bit-shift for channel 4
$ffffff00 constant DFSDM_DFSDM_CHCFG4R2_OFFSET                      \ 24-bit calibration offset for channel 4


\
\ @brief DFSDM channel configuration 5 register 2
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$000000f8 constant DFSDM_DFSDM_CHCFG5R2_DTRBS                       \ Data right bit-shift for channel 5
$ffffff00 constant DFSDM_DFSDM_CHCFG5R2_OFFSET                      \ 24-bit calibration offset for channel 5


\
\ @brief DFSDM channel configuration 6 register 2
\ Address offset: 0x38
\ Reset value: 0x00000000
\

$000000f8 constant DFSDM_DFSDM_CHCFG6R2_DTRBS                       \ Data right bit-shift for channel 6
$ffffff00 constant DFSDM_DFSDM_CHCFG6R2_OFFSET                      \ 24-bit calibration offset for channel 6


\
\ @brief DFSDM channel configuration 7 register 2
\ Address offset: 0x3C
\ Reset value: 0x00000000
\

$000000f8 constant DFSDM_DFSDM_CHCFG7R2_DTRBS                       \ Data right bit-shift for channel 7
$ffffff00 constant DFSDM_DFSDM_CHCFG7R2_OFFSET                      \ 24-bit calibration offset for channel 7


\
\ @brief DFSDM analog watchdog and short-circuit detector register
\ Address offset: 0x40
\ Reset value: 0x00000000
\

$000000ff constant DFSDM_DFSDM_AWSCD0R_SCDT                         \ short-circuit detector threshold for channel 0
$0000f000 constant DFSDM_DFSDM_AWSCD0R_BKSCD                        \ Break signal assignment for short-circuit detector on channel 0
$001f0000 constant DFSDM_DFSDM_AWSCD0R_AWFOSR                       \ Analog watchdog filter oversampling ratio (decimation rate) on channel 0
$00c00000 constant DFSDM_DFSDM_AWSCD0R_AWFORD                       \ Analog watchdog Sinc filter order on channel 0


\
\ @brief DFSDM analog watchdog and short-circuit detector register
\ Address offset: 0x44
\ Reset value: 0x00000000
\

$000000ff constant DFSDM_DFSDM_AWSCD1R_SCDT                         \ short-circuit detector threshold for channel 1
$0000f000 constant DFSDM_DFSDM_AWSCD1R_BKSCD                        \ Break signal assignment for short-circuit detector on channel 1
$001f0000 constant DFSDM_DFSDM_AWSCD1R_AWFOSR                       \ Analog watchdog filter oversampling ratio (decimation rate) on channel 1
$00c00000 constant DFSDM_DFSDM_AWSCD1R_AWFORD                       \ Analog watchdog Sinc filter order on channel 1


\
\ @brief DFSDM analog watchdog and short-circuit detector register
\ Address offset: 0x48
\ Reset value: 0x00000000
\

$000000ff constant DFSDM_DFSDM_AWSCD2R_SCDT                         \ short-circuit detector threshold for channel 2
$0000f000 constant DFSDM_DFSDM_AWSCD2R_BKSCD                        \ Break signal assignment for short-circuit detector on channel 2
$001f0000 constant DFSDM_DFSDM_AWSCD2R_AWFOSR                       \ Analog watchdog filter oversampling ratio (decimation rate) on channel 2
$00c00000 constant DFSDM_DFSDM_AWSCD2R_AWFORD                       \ Analog watchdog Sinc filter order on channel 2


\
\ @brief DFSDM analog watchdog and short-circuit detector register
\ Address offset: 0x4C
\ Reset value: 0x00000000
\

$000000ff constant DFSDM_DFSDM_AWSCD3R_SCDT                         \ short-circuit detector threshold for channel 3
$0000f000 constant DFSDM_DFSDM_AWSCD3R_BKSCD                        \ Break signal assignment for short-circuit detector on channel 3
$001f0000 constant DFSDM_DFSDM_AWSCD3R_AWFOSR                       \ Analog watchdog filter oversampling ratio (decimation rate) on channel 3
$00c00000 constant DFSDM_DFSDM_AWSCD3R_AWFORD                       \ Analog watchdog Sinc filter order on channel 3


\
\ @brief DFSDM analog watchdog and short-circuit detector register
\ Address offset: 0x50
\ Reset value: 0x00000000
\

$000000ff constant DFSDM_DFSDM_AWSCD4R_SCDT                         \ short-circuit detector threshold for channel 4
$0000f000 constant DFSDM_DFSDM_AWSCD4R_BKSCD                        \ Break signal assignment for short-circuit detector on channel 4
$001f0000 constant DFSDM_DFSDM_AWSCD4R_AWFOSR                       \ Analog watchdog filter oversampling ratio (decimation rate) on channel 4
$00c00000 constant DFSDM_DFSDM_AWSCD4R_AWFORD                       \ Analog watchdog Sinc filter order on channel 4


\
\ @brief DFSDM analog watchdog and short-circuit detector register
\ Address offset: 0x54
\ Reset value: 0x00000000
\

$000000ff constant DFSDM_DFSDM_AWSCD5R_SCDT                         \ short-circuit detector threshold for channel 5
$0000f000 constant DFSDM_DFSDM_AWSCD5R_BKSCD                        \ Break signal assignment for short-circuit detector on channel 5
$001f0000 constant DFSDM_DFSDM_AWSCD5R_AWFOSR                       \ Analog watchdog filter oversampling ratio (decimation rate) on channel 5
$00c00000 constant DFSDM_DFSDM_AWSCD5R_AWFORD                       \ Analog watchdog Sinc filter order on channel 5


\
\ @brief DFSDM analog watchdog and short-circuit detector register
\ Address offset: 0x58
\ Reset value: 0x00000000
\

$000000ff constant DFSDM_DFSDM_AWSCD6R_SCDT                         \ short-circuit detector threshold for channel 6
$0000f000 constant DFSDM_DFSDM_AWSCD6R_BKSCD                        \ Break signal assignment for short-circuit detector on channel 6
$001f0000 constant DFSDM_DFSDM_AWSCD6R_AWFOSR                       \ Analog watchdog filter oversampling ratio (decimation rate) on channel 6
$00c00000 constant DFSDM_DFSDM_AWSCD6R_AWFORD                       \ Analog watchdog Sinc filter order on channel 6


\
\ @brief DFSDM analog watchdog and short-circuit detector register
\ Address offset: 0x5C
\ Reset value: 0x00000000
\

$000000ff constant DFSDM_DFSDM_AWSCD7R_SCDT                         \ short-circuit detector threshold for channel 7
$0000f000 constant DFSDM_DFSDM_AWSCD7R_BKSCD                        \ Break signal assignment for short-circuit detector on channel 7
$001f0000 constant DFSDM_DFSDM_AWSCD7R_AWFOSR                       \ Analog watchdog filter oversampling ratio (decimation rate) on channel 7
$00c00000 constant DFSDM_DFSDM_AWSCD7R_AWFORD                       \ Analog watchdog Sinc filter order on channel 7


\
\ @brief DFSDM channel watchdog filter data register
\ Address offset: 0x60
\ Reset value: 0x00000000
\

$0000ffff constant DFSDM_DFSDM_CHWDAT0R_WDATA                       \ Input channel y watchdog data


\
\ @brief DFSDM channel watchdog filter data register
\ Address offset: 0x64
\ Reset value: 0x00000000
\

$0000ffff constant DFSDM_DFSDM_CHWDAT1R_WDATA                       \ Input channel y watchdog data


\
\ @brief DFSDM channel watchdog filter data register
\ Address offset: 0x68
\ Reset value: 0x00000000
\

$0000ffff constant DFSDM_DFSDM_CHWDAT2R_WDATA                       \ Input channel y watchdog data


\
\ @brief DFSDM channel watchdog filter data register
\ Address offset: 0x6C
\ Reset value: 0x00000000
\

$0000ffff constant DFSDM_DFSDM_CHWDAT3R_WDATA                       \ Input channel y watchdog data


\
\ @brief DFSDM channel watchdog filter data register
\ Address offset: 0x70
\ Reset value: 0x00000000
\

$0000ffff constant DFSDM_DFSDM_CHWDAT4R_WDATA                       \ Input channel y watchdog data


\
\ @brief DFSDM channel watchdog filter data register
\ Address offset: 0x74
\ Reset value: 0x00000000
\

$0000ffff constant DFSDM_DFSDM_CHWDAT5R_WDATA                       \ Input channel y watchdog data


\
\ @brief DFSDM channel watchdog filter data register
\ Address offset: 0x78
\ Reset value: 0x00000000
\

$0000ffff constant DFSDM_DFSDM_CHWDAT6R_WDATA                       \ Input channel y watchdog data


\
\ @brief DFSDM channel watchdog filter data register
\ Address offset: 0x7C
\ Reset value: 0x00000000
\

$0000ffff constant DFSDM_DFSDM_CHWDAT7R_WDATA                       \ Input channel y watchdog data


\
\ @brief DFSDM channel data input register
\ Address offset: 0x80
\ Reset value: 0x00000000
\

$0000ffff constant DFSDM_DFSDM_CHDATIN0R_INDAT0                     \ Input data for channel 0
$ffff0000 constant DFSDM_DFSDM_CHDATIN0R_INDAT1                     \ Input data for channel 1


\
\ @brief DFSDM channel data input register
\ Address offset: 0x84
\ Reset value: 0x00000000
\

$0000ffff constant DFSDM_DFSDM_CHDATIN1R_INDAT0                     \ Input data for channel 1
$ffff0000 constant DFSDM_DFSDM_CHDATIN1R_INDAT1                     \ Input data for channel 2


\
\ @brief DFSDM channel data input register
\ Address offset: 0x88
\ Reset value: 0x00000000
\

$0000ffff constant DFSDM_DFSDM_CHDATIN2R_INDAT0                     \ Input data for channel 2
$ffff0000 constant DFSDM_DFSDM_CHDATIN2R_INDAT1                     \ Input data for channel 3


\
\ @brief DFSDM channel data input register
\ Address offset: 0x8C
\ Reset value: 0x00000000
\

$0000ffff constant DFSDM_DFSDM_CHDATIN3R_INDAT0                     \ Input data for channel 3
$ffff0000 constant DFSDM_DFSDM_CHDATIN3R_INDAT1                     \ Input data for channel 4


\
\ @brief DFSDM channel data input register
\ Address offset: 0x90
\ Reset value: 0x00000000
\

$0000ffff constant DFSDM_DFSDM_CHDATIN4R_INDAT0                     \ Input data for channel 4
$ffff0000 constant DFSDM_DFSDM_CHDATIN4R_INDAT1                     \ Input data for channel 5


\
\ @brief DFSDM channel data input register
\ Address offset: 0x94
\ Reset value: 0x00000000
\

$0000ffff constant DFSDM_DFSDM_CHDATIN5R_INDAT0                     \ Input data for channel 5
$ffff0000 constant DFSDM_DFSDM_CHDATIN5R_INDAT1                     \ Input data for channel 6


\
\ @brief DFSDM channel data input register
\ Address offset: 0x98
\ Reset value: 0x00000000
\

$0000ffff constant DFSDM_DFSDM_CHDATIN6R_INDAT0                     \ Input data for channel 6
$ffff0000 constant DFSDM_DFSDM_CHDATIN6R_INDAT1                     \ Input data for channel 7


\
\ @brief DFSDM channel data input register
\ Address offset: 0x9C
\ Reset value: 0x00000000
\

$0000ffff constant DFSDM_DFSDM_CHDATIN7R_INDAT0                     \ Input data for channel 7
$ffff0000 constant DFSDM_DFSDM_CHDATIN7R_INDAT1                     \ Input data for channel 8


\
\ @brief DFSDM control register 1
\ Address offset: 0xA0
\ Reset value: 0x00000000
\

$00000001 constant DFSDM_DFSDM0_CR1_DFEN                            \ DFSDM enable
$00000002 constant DFSDM_DFSDM0_CR1_JSWSTART                        \ Start a conversion of the injected group of channels
$00000008 constant DFSDM_DFSDM0_CR1_JSYNC                           \ Launch an injected conversion synchronously with the DFSDM0 JSWSTART trigger
$00000010 constant DFSDM_DFSDM0_CR1_JSCAN                           \ Scanning conversion mode for injected conversions
$00000020 constant DFSDM_DFSDM0_CR1_JDMAEN                          \ DMA channel enabled to read data for the injected channel group
$00001f00 constant DFSDM_DFSDM0_CR1_JEXTSEL                         \ Trigger signal selection for launching injected conversions
$00006000 constant DFSDM_DFSDM0_CR1_JEXTEN                          \ Trigger enable and trigger edge selection for injected conversions
$00020000 constant DFSDM_DFSDM0_CR1_RSWSTART                        \ Software start of a conversion on the regular channel
$00040000 constant DFSDM_DFSDM0_CR1_RCONT                           \ Continuous mode selection for regular conversions
$00080000 constant DFSDM_DFSDM0_CR1_RSYNC                           \ Launch regular conversion synchronously with DFSDM0
$00200000 constant DFSDM_DFSDM0_CR1_RDMAEN                          \ DMA channel enabled to read data for the regular conversion
$07000000 constant DFSDM_DFSDM0_CR1_RCH                             \ Regular channel selection
$20000000 constant DFSDM_DFSDM0_CR1_FAST                            \ Fast conversion mode selection for regular conversions
$40000000 constant DFSDM_DFSDM0_CR1_AWFSEL                          \ Analog watchdog fast mode select


\
\ @brief DFSDM control register 1
\ Address offset: 0xA4
\ Reset value: 0x00000000
\

$00000001 constant DFSDM_DFSDM1_CR1_DFEN                            \ DFSDM enable
$00000002 constant DFSDM_DFSDM1_CR1_JSWSTART                        \ Start a conversion of the injected group of channels
$00000008 constant DFSDM_DFSDM1_CR1_JSYNC                           \ Launch an injected conversion synchronously with the DFSDM0 JSWSTART trigger
$00000010 constant DFSDM_DFSDM1_CR1_JSCAN                           \ Scanning conversion mode for injected conversions
$00000020 constant DFSDM_DFSDM1_CR1_JDMAEN                          \ DMA channel enabled to read data for the injected channel group
$00001f00 constant DFSDM_DFSDM1_CR1_JEXTSEL                         \ Trigger signal selection for launching injected conversions
$00006000 constant DFSDM_DFSDM1_CR1_JEXTEN                          \ Trigger enable and trigger edge selection for injected conversions
$00020000 constant DFSDM_DFSDM1_CR1_RSWSTART                        \ Software start of a conversion on the regular channel
$00040000 constant DFSDM_DFSDM1_CR1_RCONT                           \ Continuous mode selection for regular conversions
$00080000 constant DFSDM_DFSDM1_CR1_RSYNC                           \ Launch regular conversion synchronously with DFSDM0
$00200000 constant DFSDM_DFSDM1_CR1_RDMAEN                          \ DMA channel enabled to read data for the regular conversion
$07000000 constant DFSDM_DFSDM1_CR1_RCH                             \ Regular channel selection
$20000000 constant DFSDM_DFSDM1_CR1_FAST                            \ Fast conversion mode selection for regular conversions
$40000000 constant DFSDM_DFSDM1_CR1_AWFSEL                          \ Analog watchdog fast mode select


\
\ @brief DFSDM control register 1
\ Address offset: 0xA8
\ Reset value: 0x00000000
\

$00000001 constant DFSDM_DFSDM2_CR1_DFEN                            \ DFSDM enable
$00000002 constant DFSDM_DFSDM2_CR1_JSWSTART                        \ Start a conversion of the injected group of channels
$00000008 constant DFSDM_DFSDM2_CR1_JSYNC                           \ Launch an injected conversion synchronously with the DFSDM0 JSWSTART trigger
$00000010 constant DFSDM_DFSDM2_CR1_JSCAN                           \ Scanning conversion mode for injected conversions
$00000020 constant DFSDM_DFSDM2_CR1_JDMAEN                          \ DMA channel enabled to read data for the injected channel group
$00001f00 constant DFSDM_DFSDM2_CR1_JEXTSEL                         \ Trigger signal selection for launching injected conversions
$00006000 constant DFSDM_DFSDM2_CR1_JEXTEN                          \ Trigger enable and trigger edge selection for injected conversions
$00020000 constant DFSDM_DFSDM2_CR1_RSWSTART                        \ Software start of a conversion on the regular channel
$00040000 constant DFSDM_DFSDM2_CR1_RCONT                           \ Continuous mode selection for regular conversions
$00080000 constant DFSDM_DFSDM2_CR1_RSYNC                           \ Launch regular conversion synchronously with DFSDM0
$00200000 constant DFSDM_DFSDM2_CR1_RDMAEN                          \ DMA channel enabled to read data for the regular conversion
$07000000 constant DFSDM_DFSDM2_CR1_RCH                             \ Regular channel selection
$20000000 constant DFSDM_DFSDM2_CR1_FAST                            \ Fast conversion mode selection for regular conversions
$40000000 constant DFSDM_DFSDM2_CR1_AWFSEL                          \ Analog watchdog fast mode select


\
\ @brief DFSDM control register 1
\ Address offset: 0xAC
\ Reset value: 0x00000000
\

$00000001 constant DFSDM_DFSDM3_CR1_DFEN                            \ DFSDM enable
$00000002 constant DFSDM_DFSDM3_CR1_JSWSTART                        \ Start a conversion of the injected group of channels
$00000008 constant DFSDM_DFSDM3_CR1_JSYNC                           \ Launch an injected conversion synchronously with the DFSDM0 JSWSTART trigger
$00000010 constant DFSDM_DFSDM3_CR1_JSCAN                           \ Scanning conversion mode for injected conversions
$00000020 constant DFSDM_DFSDM3_CR1_JDMAEN                          \ DMA channel enabled to read data for the injected channel group
$00001f00 constant DFSDM_DFSDM3_CR1_JEXTSEL                         \ Trigger signal selection for launching injected conversions
$00006000 constant DFSDM_DFSDM3_CR1_JEXTEN                          \ Trigger enable and trigger edge selection for injected conversions
$00020000 constant DFSDM_DFSDM3_CR1_RSWSTART                        \ Software start of a conversion on the regular channel
$00040000 constant DFSDM_DFSDM3_CR1_RCONT                           \ Continuous mode selection for regular conversions
$00080000 constant DFSDM_DFSDM3_CR1_RSYNC                           \ Launch regular conversion synchronously with DFSDM0
$00200000 constant DFSDM_DFSDM3_CR1_RDMAEN                          \ DMA channel enabled to read data for the regular conversion
$07000000 constant DFSDM_DFSDM3_CR1_RCH                             \ Regular channel selection
$20000000 constant DFSDM_DFSDM3_CR1_FAST                            \ Fast conversion mode selection for regular conversions
$40000000 constant DFSDM_DFSDM3_CR1_AWFSEL                          \ Analog watchdog fast mode select


\
\ @brief DFSDM control register 2
\ Address offset: 0xB0
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
\ @brief DFSDM control register 2
\ Address offset: 0xB4
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
\ @brief DFSDM control register 2
\ Address offset: 0xB8
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
\ @brief DFSDM control register 2
\ Address offset: 0xBC
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
\ @brief DFSDM interrupt and status register
\ Address offset: 0xC0
\ Reset value: 0x00000000
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
\ @brief DFSDM interrupt and status register
\ Address offset: 0xC4
\ Reset value: 0x00000000
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
\ @brief DFSDM interrupt and status register
\ Address offset: 0xC8
\ Reset value: 0x00000000
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
\ @brief DFSDM interrupt and status register
\ Address offset: 0xCC
\ Reset value: 0x00000000
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
\ @brief DFSDM interrupt flag clear register
\ Address offset: 0xD0
\ Reset value: 0x00000000
\

$00000004 constant DFSDM_DFSDM0_ICR_CLRJOVRF                        \ Clear the injected conversion overrun flag
$00000008 constant DFSDM_DFSDM0_ICR_CLRROVRF                        \ Clear the regular conversion overrun flag
$00ff0000 constant DFSDM_DFSDM0_ICR_CLRCKABF                        \ Clear the clock absence flag
$ff000000 constant DFSDM_DFSDM0_ICR_CLRSCDF                         \ Clear the short-circuit detector flag


\
\ @brief DFSDM interrupt flag clear register
\ Address offset: 0xD4
\ Reset value: 0x00000000
\

$00000004 constant DFSDM_DFSDM1_ICR_CLRJOVRF                        \ Clear the injected conversion overrun flag
$00000008 constant DFSDM_DFSDM1_ICR_CLRROVRF                        \ Clear the regular conversion overrun flag
$00ff0000 constant DFSDM_DFSDM1_ICR_CLRCKABF                        \ Clear the clock absence flag
$ff000000 constant DFSDM_DFSDM1_ICR_CLRSCDF                         \ Clear the short-circuit detector flag


\
\ @brief DFSDM interrupt flag clear register
\ Address offset: 0xD8
\ Reset value: 0x00000000
\

$00000004 constant DFSDM_DFSDM2_ICR_CLRJOVRF                        \ Clear the injected conversion overrun flag
$00000008 constant DFSDM_DFSDM2_ICR_CLRROVRF                        \ Clear the regular conversion overrun flag
$00ff0000 constant DFSDM_DFSDM2_ICR_CLRCKABF                        \ Clear the clock absence flag
$ff000000 constant DFSDM_DFSDM2_ICR_CLRSCDF                         \ Clear the short-circuit detector flag


\
\ @brief DFSDM interrupt flag clear register
\ Address offset: 0xDC
\ Reset value: 0x00000000
\

$00000004 constant DFSDM_DFSDM3_ICR_CLRJOVRF                        \ Clear the injected conversion overrun flag
$00000008 constant DFSDM_DFSDM3_ICR_CLRROVRF                        \ Clear the regular conversion overrun flag
$00ff0000 constant DFSDM_DFSDM3_ICR_CLRCKABF                        \ Clear the clock absence flag
$ff000000 constant DFSDM_DFSDM3_ICR_CLRSCDF                         \ Clear the short-circuit detector flag


\
\ @brief DFSDM injected channel group selection register
\ Address offset: 0xE0
\ Reset value: 0x00000000
\

$000000ff constant DFSDM_DFSDM0_JCHGR_JCHG                          \ Injected channel group selection


\
\ @brief DFSDM injected channel group selection register
\ Address offset: 0xE4
\ Reset value: 0x00000000
\

$000000ff constant DFSDM_DFSDM1_JCHGR_JCHG                          \ Injected channel group selection


\
\ @brief DFSDM injected channel group selection register
\ Address offset: 0xE8
\ Reset value: 0x00000000
\

$000000ff constant DFSDM_DFSDM2_JCHGR_JCHG                          \ Injected channel group selection


\
\ @brief DFSDM injected channel group selection register
\ Address offset: 0xEC
\ Reset value: 0x00000000
\

$000000ff constant DFSDM_DFSDM3_JCHGR_JCHG                          \ Injected channel group selection


\
\ @brief DFSDM filter control register
\ Address offset: 0xF0
\ Reset value: 0x00000000
\

$000000ff constant DFSDM_DFSDM0_FCR_IOSR                            \ Integrator oversampling ratio (averaging length)
$03ff0000 constant DFSDM_DFSDM0_FCR_FOSR                            \ Sinc filter oversampling ratio (decimation rate)
$e0000000 constant DFSDM_DFSDM0_FCR_FORD                            \ Sinc filter order


\
\ @brief DFSDM filter control register
\ Address offset: 0xF4
\ Reset value: 0x00000000
\

$000000ff constant DFSDM_DFSDM1_FCR_IOSR                            \ Integrator oversampling ratio (averaging length)
$03ff0000 constant DFSDM_DFSDM1_FCR_FOSR                            \ Sinc filter oversampling ratio (decimation rate)
$e0000000 constant DFSDM_DFSDM1_FCR_FORD                            \ Sinc filter order


\
\ @brief DFSDM filter control register
\ Address offset: 0xF8
\ Reset value: 0x00000000
\

$000000ff constant DFSDM_DFSDM2_FCR_IOSR                            \ Integrator oversampling ratio (averaging length)
$03ff0000 constant DFSDM_DFSDM2_FCR_FOSR                            \ Sinc filter oversampling ratio (decimation rate)
$e0000000 constant DFSDM_DFSDM2_FCR_FORD                            \ Sinc filter order


\
\ @brief DFSDM filter control register
\ Address offset: 0xFC
\ Reset value: 0x00000000
\

$000000ff constant DFSDM_DFSDM3_FCR_IOSR                            \ Integrator oversampling ratio (averaging length)
$03ff0000 constant DFSDM_DFSDM3_FCR_FOSR                            \ Sinc filter oversampling ratio (decimation rate)
$e0000000 constant DFSDM_DFSDM3_FCR_FORD                            \ Sinc filter order


\
\ @brief DFSDM data register for injected group
\ Address offset: 0x100
\ Reset value: 0x00000000
\

$00000007 constant DFSDM_DFSDM0_JDATAR_JDATACH                      \ Injected channel most recently converted
$ffffff00 constant DFSDM_DFSDM0_JDATAR_JDATA                        \ Injected group conversion data


\
\ @brief DFSDM data register for injected group
\ Address offset: 0x104
\ Reset value: 0x00000000
\

$00000007 constant DFSDM_DFSDM1_JDATAR_JDATACH                      \ Injected channel most recently converted
$ffffff00 constant DFSDM_DFSDM1_JDATAR_JDATA                        \ Injected group conversion data


\
\ @brief DFSDM data register for injected group
\ Address offset: 0x108
\ Reset value: 0x00000000
\

$00000007 constant DFSDM_DFSDM2_JDATAR_JDATACH                      \ Injected channel most recently converted
$ffffff00 constant DFSDM_DFSDM2_JDATAR_JDATA                        \ Injected group conversion data


\
\ @brief DFSDM data register for injected group
\ Address offset: 0x10C
\ Reset value: 0x00000000
\

$00000007 constant DFSDM_DFSDM3_JDATAR_JDATACH                      \ Injected channel most recently converted
$ffffff00 constant DFSDM_DFSDM3_JDATAR_JDATA                        \ Injected group conversion data


\
\ @brief DFSDM data register for the regular channel
\ Address offset: 0x110
\ Reset value: 0x00000000
\

$00000007 constant DFSDM_DFSDM0_RDATAR_RDATACH                      \ Regular channel most recently converted
$00000010 constant DFSDM_DFSDM0_RDATAR_RPEND                        \ Regular channel pending data
$ffffff00 constant DFSDM_DFSDM0_RDATAR_RDATA                        \ Regular channel conversion data


\
\ @brief DFSDM data register for the regular channel
\ Address offset: 0x114
\ Reset value: 0x00000000
\

$00000007 constant DFSDM_DFSDM1_RDATAR_RDATACH                      \ Regular channel most recently converted
$00000010 constant DFSDM_DFSDM1_RDATAR_RPEND                        \ Regular channel pending data
$ffffff00 constant DFSDM_DFSDM1_RDATAR_RDATA                        \ Regular channel conversion data


\
\ @brief DFSDM data register for the regular channel
\ Address offset: 0x118
\ Reset value: 0x00000000
\

$00000007 constant DFSDM_DFSDM2_RDATAR_RDATACH                      \ Regular channel most recently converted
$00000010 constant DFSDM_DFSDM2_RDATAR_RPEND                        \ Regular channel pending data
$ffffff00 constant DFSDM_DFSDM2_RDATAR_RDATA                        \ Regular channel conversion data


\
\ @brief DFSDM data register for the regular channel
\ Address offset: 0x11C
\ Reset value: 0x00000000
\

$00000007 constant DFSDM_DFSDM3_RDATAR_RDATACH                      \ Regular channel most recently converted
$00000010 constant DFSDM_DFSDM3_RDATAR_RPEND                        \ Regular channel pending data
$ffffff00 constant DFSDM_DFSDM3_RDATAR_RDATA                        \ Regular channel conversion data


\
\ @brief DFSDM analog watchdog high threshold register
\ Address offset: 0x120
\ Reset value: 0x00000000
\

$0000000f constant DFSDM_DFSDM0_AWHTR_BKAWH                         \ Break signal assignment to analog watchdog high threshold event
$ffffff00 constant DFSDM_DFSDM0_AWHTR_AWHT                          \ Analog watchdog high threshold


\
\ @brief DFSDM analog watchdog high threshold register
\ Address offset: 0x124
\ Reset value: 0x00000000
\

$0000000f constant DFSDM_DFSDM1_AWHTR_BKAWH                         \ Break signal assignment to analog watchdog high threshold event
$ffffff00 constant DFSDM_DFSDM1_AWHTR_AWHT                          \ Analog watchdog high threshold


\
\ @brief DFSDM analog watchdog high threshold register
\ Address offset: 0x128
\ Reset value: 0x00000000
\

$0000000f constant DFSDM_DFSDM2_AWHTR_BKAWH                         \ Break signal assignment to analog watchdog high threshold event
$ffffff00 constant DFSDM_DFSDM2_AWHTR_AWHT                          \ Analog watchdog high threshold


\
\ @brief DFSDM analog watchdog high threshold register
\ Address offset: 0x12C
\ Reset value: 0x00000000
\

$0000000f constant DFSDM_DFSDM3_AWHTR_BKAWH                         \ Break signal assignment to analog watchdog high threshold event
$ffffff00 constant DFSDM_DFSDM3_AWHTR_AWHT                          \ Analog watchdog high threshold


\
\ @brief DFSDM analog watchdog low threshold register
\ Address offset: 0x130
\ Reset value: 0x00000000
\

$0000000f constant DFSDM_DFSDM0_AWLTR_BKAWL                         \ Break signal assignment to analog watchdog low threshold event
$ffffff00 constant DFSDM_DFSDM0_AWLTR_AWLT                          \ Analog watchdog low threshold


\
\ @brief DFSDM analog watchdog low threshold register
\ Address offset: 0x134
\ Reset value: 0x00000000
\

$0000000f constant DFSDM_DFSDM1_AWLTR_BKAWL                         \ Break signal assignment to analog watchdog low threshold event
$ffffff00 constant DFSDM_DFSDM1_AWLTR_AWLT                          \ Analog watchdog low threshold


\
\ @brief DFSDM analog watchdog low threshold register
\ Address offset: 0x138
\ Reset value: 0x00000000
\

$0000000f constant DFSDM_DFSDM2_AWLTR_BKAWL                         \ Break signal assignment to analog watchdog low threshold event
$ffffff00 constant DFSDM_DFSDM2_AWLTR_AWLT                          \ Analog watchdog low threshold


\
\ @brief DFSDM analog watchdog low threshold register
\ Address offset: 0x13C
\ Reset value: 0x00000000
\

$0000000f constant DFSDM_DFSDM3_AWLTR_BKAWL                         \ Break signal assignment to analog watchdog low threshold event
$ffffff00 constant DFSDM_DFSDM3_AWLTR_AWLT                          \ Analog watchdog low threshold


\
\ @brief DFSDM analog watchdog status register
\ Address offset: 0x140
\ Reset value: 0x00000000
\

$000000ff constant DFSDM_DFSDM0_AWSR_AWLTF                          \ Analog watchdog low threshold flag
$0000ff00 constant DFSDM_DFSDM0_AWSR_AWHTF                          \ Analog watchdog high threshold flag


\
\ @brief DFSDM analog watchdog status register
\ Address offset: 0x144
\ Reset value: 0x00000000
\

$000000ff constant DFSDM_DFSDM1_AWSR_AWLTF                          \ Analog watchdog low threshold flag
$0000ff00 constant DFSDM_DFSDM1_AWSR_AWHTF                          \ Analog watchdog high threshold flag


\
\ @brief DFSDM analog watchdog status register
\ Address offset: 0x148
\ Reset value: 0x00000000
\

$000000ff constant DFSDM_DFSDM2_AWSR_AWLTF                          \ Analog watchdog low threshold flag
$0000ff00 constant DFSDM_DFSDM2_AWSR_AWHTF                          \ Analog watchdog high threshold flag


\
\ @brief DFSDM analog watchdog status register
\ Address offset: 0x14C
\ Reset value: 0x00000000
\

$000000ff constant DFSDM_DFSDM3_AWSR_AWLTF                          \ Analog watchdog low threshold flag
$0000ff00 constant DFSDM_DFSDM3_AWSR_AWHTF                          \ Analog watchdog high threshold flag


\
\ @brief DFSDM analog watchdog clear flag register
\ Address offset: 0x150
\ Reset value: 0x00000000
\

$000000ff constant DFSDM_DFSDM0_AWCFR_CLRAWLTF                      \ Clear the analog watchdog low threshold flag
$0000ff00 constant DFSDM_DFSDM0_AWCFR_CLRAWHTF                      \ Clear the analog watchdog high threshold flag


\
\ @brief DFSDM analog watchdog clear flag register
\ Address offset: 0x154
\ Reset value: 0x00000000
\

$000000ff constant DFSDM_DFSDM1_AWCFR_CLRAWLTF                      \ Clear the analog watchdog low threshold flag
$0000ff00 constant DFSDM_DFSDM1_AWCFR_CLRAWHTF                      \ Clear the analog watchdog high threshold flag


\
\ @brief DFSDM analog watchdog clear flag register
\ Address offset: 0x158
\ Reset value: 0x00000000
\

$000000ff constant DFSDM_DFSDM2_AWCFR_CLRAWLTF                      \ Clear the analog watchdog low threshold flag
$0000ff00 constant DFSDM_DFSDM2_AWCFR_CLRAWHTF                      \ Clear the analog watchdog high threshold flag


\
\ @brief DFSDM analog watchdog clear flag register
\ Address offset: 0x15C
\ Reset value: 0x00000000
\

$000000ff constant DFSDM_DFSDM3_AWCFR_CLRAWLTF                      \ Clear the analog watchdog low threshold flag
$0000ff00 constant DFSDM_DFSDM3_AWCFR_CLRAWHTF                      \ Clear the analog watchdog high threshold flag


\
\ @brief DFSDM Extremes detector maximum register
\ Address offset: 0x160
\ Reset value: 0x00000000
\

$00000007 constant DFSDM_DFSDM0_EXMAX_EXMAXCH                       \ Extremes detector maximum data channel
$ffffff00 constant DFSDM_DFSDM0_EXMAX_EXMAX                         \ Extremes detector maximum value


\
\ @brief DFSDM Extremes detector maximum register
\ Address offset: 0x164
\ Reset value: 0x00000000
\

$00000007 constant DFSDM_DFSDM1_EXMAX_EXMAXCH                       \ Extremes detector maximum data channel
$ffffff00 constant DFSDM_DFSDM1_EXMAX_EXMAX                         \ Extremes detector maximum value


\
\ @brief DFSDM Extremes detector maximum register
\ Address offset: 0x168
\ Reset value: 0x00000000
\

$00000007 constant DFSDM_DFSDM2_EXMAX_EXMAXCH                       \ Extremes detector maximum data channel
$ffffff00 constant DFSDM_DFSDM2_EXMAX_EXMAX                         \ Extremes detector maximum value


\
\ @brief DFSDM Extremes detector maximum register
\ Address offset: 0x16C
\ Reset value: 0x00000000
\

$00000007 constant DFSDM_DFSDM3_EXMAX_EXMAXCH                       \ Extremes detector maximum data channel
$ffffff00 constant DFSDM_DFSDM3_EXMAX_EXMAX                         \ Extremes detector maximum value


\
\ @brief DFSDM Extremes detector minimum register
\ Address offset: 0x170
\ Reset value: 0x00000000
\

$00000007 constant DFSDM_DFSDM0_EXMIN_EXMINCH                       \ Extremes detector minimum data channel
$ffffff00 constant DFSDM_DFSDM0_EXMIN_EXMIN                         \ Extremes detector minimum value


\
\ @brief DFSDM Extremes detector minimum register
\ Address offset: 0x174
\ Reset value: 0x00000000
\

$00000007 constant DFSDM_DFSDM1_EXMIN_EXMINCH                       \ Extremes detector minimum data channel
$ffffff00 constant DFSDM_DFSDM1_EXMIN_EXMIN                         \ Extremes detector minimum value


\
\ @brief DFSDM Extremes detector minimum register
\ Address offset: 0x178
\ Reset value: 0x00000000
\

$00000007 constant DFSDM_DFSDM2_EXMIN_EXMINCH                       \ Extremes detector minimum data channel
$ffffff00 constant DFSDM_DFSDM2_EXMIN_EXMIN                         \ Extremes detector minimum value


\
\ @brief DFSDM Extremes detector minimum register
\ Address offset: 0x17C
\ Reset value: 0x00000000
\

$00000007 constant DFSDM_DFSDM3_EXMIN_EXMINCH                       \ Extremes detector minimum data channel
$ffffff00 constant DFSDM_DFSDM3_EXMIN_EXMIN                         \ Extremes detector minimum value


\
\ @brief DFSDM conversion timer register
\ Address offset: 0x180
\ Reset value: 0x00000000
\

$fffffff0 constant DFSDM_DFSDM0_CNVTIMR_CNVCNT                      \ 28-bit timer counting conversion time


\
\ @brief DFSDM conversion timer register
\ Address offset: 0x184
\ Reset value: 0x00000000
\

$fffffff0 constant DFSDM_DFSDM1_CNVTIMR_CNVCNT                      \ 28-bit timer counting conversion time


\
\ @brief DFSDM conversion timer register
\ Address offset: 0x188
\ Reset value: 0x00000000
\

$fffffff0 constant DFSDM_DFSDM2_CNVTIMR_CNVCNT                      \ 28-bit timer counting conversion time


\
\ @brief DFSDM conversion timer register
\ Address offset: 0x18C
\ Reset value: 0x00000000
\

$fffffff0 constant DFSDM_DFSDM3_CNVTIMR_CNVCNT                      \ 28-bit timer counting conversion time


\
\ @brief Digital filter for sigma delta modulators
\
$40017400 constant DFSDM_DFSDM_CHCFG0R1  \ offset: 0x00 : DFSDM channel configuration 0 register 1
$40017404 constant DFSDM_DFSDM_CHCFG1R1  \ offset: 0x04 : DFSDM channel configuration 1 register 1
$40017408 constant DFSDM_DFSDM_CHCFG2R1  \ offset: 0x08 : DFSDM channel configuration 2 register 1
$4001740c constant DFSDM_DFSDM_CHCFG3R1  \ offset: 0x0C : DFSDM channel configuration 3 register 1
$40017410 constant DFSDM_DFSDM_CHCFG4R1  \ offset: 0x10 : DFSDM channel configuration 4 register 1
$40017414 constant DFSDM_DFSDM_CHCFG5R1  \ offset: 0x14 : DFSDM channel configuration 5 register 1
$40017418 constant DFSDM_DFSDM_CHCFG6R1  \ offset: 0x18 : DFSDM channel configuration 6 register 1
$4001741c constant DFSDM_DFSDM_CHCFG7R1  \ offset: 0x1C : DFSDM channel configuration 7 register 1
$40017420 constant DFSDM_DFSDM_CHCFG0R2  \ offset: 0x20 : DFSDM channel configuration 0 register 2
$40017424 constant DFSDM_DFSDM_CHCFG1R2  \ offset: 0x24 : DFSDM channel configuration 1 register 2
$40017428 constant DFSDM_DFSDM_CHCFG2R2  \ offset: 0x28 : DFSDM channel configuration 2 register 2
$4001742c constant DFSDM_DFSDM_CHCFG3R2  \ offset: 0x2C : DFSDM channel configuration 3 register 2
$40017430 constant DFSDM_DFSDM_CHCFG4R2  \ offset: 0x30 : DFSDM channel configuration 4 register 2
$40017434 constant DFSDM_DFSDM_CHCFG5R2  \ offset: 0x34 : DFSDM channel configuration 5 register 2
$40017438 constant DFSDM_DFSDM_CHCFG6R2  \ offset: 0x38 : DFSDM channel configuration 6 register 2
$4001743c constant DFSDM_DFSDM_CHCFG7R2  \ offset: 0x3C : DFSDM channel configuration 7 register 2
$40017440 constant DFSDM_DFSDM_AWSCD0R  \ offset: 0x40 : DFSDM analog watchdog and short-circuit detector register
$40017444 constant DFSDM_DFSDM_AWSCD1R  \ offset: 0x44 : DFSDM analog watchdog and short-circuit detector register
$40017448 constant DFSDM_DFSDM_AWSCD2R  \ offset: 0x48 : DFSDM analog watchdog and short-circuit detector register
$4001744c constant DFSDM_DFSDM_AWSCD3R  \ offset: 0x4C : DFSDM analog watchdog and short-circuit detector register
$40017450 constant DFSDM_DFSDM_AWSCD4R  \ offset: 0x50 : DFSDM analog watchdog and short-circuit detector register
$40017454 constant DFSDM_DFSDM_AWSCD5R  \ offset: 0x54 : DFSDM analog watchdog and short-circuit detector register
$40017458 constant DFSDM_DFSDM_AWSCD6R  \ offset: 0x58 : DFSDM analog watchdog and short-circuit detector register
$4001745c constant DFSDM_DFSDM_AWSCD7R  \ offset: 0x5C : DFSDM analog watchdog and short-circuit detector register
$40017460 constant DFSDM_DFSDM_CHWDAT0R  \ offset: 0x60 : DFSDM channel watchdog filter data register
$40017464 constant DFSDM_DFSDM_CHWDAT1R  \ offset: 0x64 : DFSDM channel watchdog filter data register
$40017468 constant DFSDM_DFSDM_CHWDAT2R  \ offset: 0x68 : DFSDM channel watchdog filter data register
$4001746c constant DFSDM_DFSDM_CHWDAT3R  \ offset: 0x6C : DFSDM channel watchdog filter data register
$40017470 constant DFSDM_DFSDM_CHWDAT4R  \ offset: 0x70 : DFSDM channel watchdog filter data register
$40017474 constant DFSDM_DFSDM_CHWDAT5R  \ offset: 0x74 : DFSDM channel watchdog filter data register
$40017478 constant DFSDM_DFSDM_CHWDAT6R  \ offset: 0x78 : DFSDM channel watchdog filter data register
$4001747c constant DFSDM_DFSDM_CHWDAT7R  \ offset: 0x7C : DFSDM channel watchdog filter data register
$40017480 constant DFSDM_DFSDM_CHDATIN0R  \ offset: 0x80 : DFSDM channel data input register
$40017484 constant DFSDM_DFSDM_CHDATIN1R  \ offset: 0x84 : DFSDM channel data input register
$40017488 constant DFSDM_DFSDM_CHDATIN2R  \ offset: 0x88 : DFSDM channel data input register
$4001748c constant DFSDM_DFSDM_CHDATIN3R  \ offset: 0x8C : DFSDM channel data input register
$40017490 constant DFSDM_DFSDM_CHDATIN4R  \ offset: 0x90 : DFSDM channel data input register
$40017494 constant DFSDM_DFSDM_CHDATIN5R  \ offset: 0x94 : DFSDM channel data input register
$40017498 constant DFSDM_DFSDM_CHDATIN6R  \ offset: 0x98 : DFSDM channel data input register
$4001749c constant DFSDM_DFSDM_CHDATIN7R  \ offset: 0x9C : DFSDM channel data input register
$400174a0 constant DFSDM_DFSDM0_CR1  \ offset: 0xA0 : DFSDM control register 1
$400174a4 constant DFSDM_DFSDM1_CR1  \ offset: 0xA4 : DFSDM control register 1
$400174a8 constant DFSDM_DFSDM2_CR1  \ offset: 0xA8 : DFSDM control register 1
$400174ac constant DFSDM_DFSDM3_CR1  \ offset: 0xAC : DFSDM control register 1
$400174b0 constant DFSDM_DFSDM0_CR2  \ offset: 0xB0 : DFSDM control register 2
$400174b4 constant DFSDM_DFSDM1_CR2  \ offset: 0xB4 : DFSDM control register 2
$400174b8 constant DFSDM_DFSDM2_CR2  \ offset: 0xB8 : DFSDM control register 2
$400174bc constant DFSDM_DFSDM3_CR2  \ offset: 0xBC : DFSDM control register 2
$400174c0 constant DFSDM_DFSDM0_ISR  \ offset: 0xC0 : DFSDM interrupt and status register
$400174c4 constant DFSDM_DFSDM1_ISR  \ offset: 0xC4 : DFSDM interrupt and status register
$400174c8 constant DFSDM_DFSDM2_ISR  \ offset: 0xC8 : DFSDM interrupt and status register
$400174cc constant DFSDM_DFSDM3_ISR  \ offset: 0xCC : DFSDM interrupt and status register
$400174d0 constant DFSDM_DFSDM0_ICR  \ offset: 0xD0 : DFSDM interrupt flag clear register
$400174d4 constant DFSDM_DFSDM1_ICR  \ offset: 0xD4 : DFSDM interrupt flag clear register
$400174d8 constant DFSDM_DFSDM2_ICR  \ offset: 0xD8 : DFSDM interrupt flag clear register
$400174dc constant DFSDM_DFSDM3_ICR  \ offset: 0xDC : DFSDM interrupt flag clear register
$400174e0 constant DFSDM_DFSDM0_JCHGR  \ offset: 0xE0 : DFSDM injected channel group selection register
$400174e4 constant DFSDM_DFSDM1_JCHGR  \ offset: 0xE4 : DFSDM injected channel group selection register
$400174e8 constant DFSDM_DFSDM2_JCHGR  \ offset: 0xE8 : DFSDM injected channel group selection register
$400174ec constant DFSDM_DFSDM3_JCHGR  \ offset: 0xEC : DFSDM injected channel group selection register
$400174f0 constant DFSDM_DFSDM0_FCR  \ offset: 0xF0 : DFSDM filter control register
$400174f4 constant DFSDM_DFSDM1_FCR  \ offset: 0xF4 : DFSDM filter control register
$400174f8 constant DFSDM_DFSDM2_FCR  \ offset: 0xF8 : DFSDM filter control register
$400174fc constant DFSDM_DFSDM3_FCR  \ offset: 0xFC : DFSDM filter control register
$40017500 constant DFSDM_DFSDM0_JDATAR  \ offset: 0x100 : DFSDM data register for injected group
$40017504 constant DFSDM_DFSDM1_JDATAR  \ offset: 0x104 : DFSDM data register for injected group
$40017508 constant DFSDM_DFSDM2_JDATAR  \ offset: 0x108 : DFSDM data register for injected group
$4001750c constant DFSDM_DFSDM3_JDATAR  \ offset: 0x10C : DFSDM data register for injected group
$40017510 constant DFSDM_DFSDM0_RDATAR  \ offset: 0x110 : DFSDM data register for the regular channel
$40017514 constant DFSDM_DFSDM1_RDATAR  \ offset: 0x114 : DFSDM data register for the regular channel
$40017518 constant DFSDM_DFSDM2_RDATAR  \ offset: 0x118 : DFSDM data register for the regular channel
$4001751c constant DFSDM_DFSDM3_RDATAR  \ offset: 0x11C : DFSDM data register for the regular channel
$40017520 constant DFSDM_DFSDM0_AWHTR  \ offset: 0x120 : DFSDM analog watchdog high threshold register
$40017524 constant DFSDM_DFSDM1_AWHTR  \ offset: 0x124 : DFSDM analog watchdog high threshold register
$40017528 constant DFSDM_DFSDM2_AWHTR  \ offset: 0x128 : DFSDM analog watchdog high threshold register
$4001752c constant DFSDM_DFSDM3_AWHTR  \ offset: 0x12C : DFSDM analog watchdog high threshold register
$40017530 constant DFSDM_DFSDM0_AWLTR  \ offset: 0x130 : DFSDM analog watchdog low threshold register
$40017534 constant DFSDM_DFSDM1_AWLTR  \ offset: 0x134 : DFSDM analog watchdog low threshold register
$40017538 constant DFSDM_DFSDM2_AWLTR  \ offset: 0x138 : DFSDM analog watchdog low threshold register
$4001753c constant DFSDM_DFSDM3_AWLTR  \ offset: 0x13C : DFSDM analog watchdog low threshold register
$40017540 constant DFSDM_DFSDM0_AWSR  \ offset: 0x140 : DFSDM analog watchdog status register
$40017544 constant DFSDM_DFSDM1_AWSR  \ offset: 0x144 : DFSDM analog watchdog status register
$40017548 constant DFSDM_DFSDM2_AWSR  \ offset: 0x148 : DFSDM analog watchdog status register
$4001754c constant DFSDM_DFSDM3_AWSR  \ offset: 0x14C : DFSDM analog watchdog status register
$40017550 constant DFSDM_DFSDM0_AWCFR  \ offset: 0x150 : DFSDM analog watchdog clear flag register
$40017554 constant DFSDM_DFSDM1_AWCFR  \ offset: 0x154 : DFSDM analog watchdog clear flag register
$40017558 constant DFSDM_DFSDM2_AWCFR  \ offset: 0x158 : DFSDM analog watchdog clear flag register
$4001755c constant DFSDM_DFSDM3_AWCFR  \ offset: 0x15C : DFSDM analog watchdog clear flag register
$40017560 constant DFSDM_DFSDM0_EXMAX  \ offset: 0x160 : DFSDM Extremes detector maximum register
$40017564 constant DFSDM_DFSDM1_EXMAX  \ offset: 0x164 : DFSDM Extremes detector maximum register
$40017568 constant DFSDM_DFSDM2_EXMAX  \ offset: 0x168 : DFSDM Extremes detector maximum register
$4001756c constant DFSDM_DFSDM3_EXMAX  \ offset: 0x16C : DFSDM Extremes detector maximum register
$40017570 constant DFSDM_DFSDM0_EXMIN  \ offset: 0x170 : DFSDM Extremes detector minimum register
$40017574 constant DFSDM_DFSDM1_EXMIN  \ offset: 0x174 : DFSDM Extremes detector minimum register
$40017578 constant DFSDM_DFSDM2_EXMIN  \ offset: 0x178 : DFSDM Extremes detector minimum register
$4001757c constant DFSDM_DFSDM3_EXMIN  \ offset: 0x17C : DFSDM Extremes detector minimum register
$40017580 constant DFSDM_DFSDM0_CNVTIMR  \ offset: 0x180 : DFSDM conversion timer register
$40017584 constant DFSDM_DFSDM1_CNVTIMR  \ offset: 0x184 : DFSDM conversion timer register
$40017588 constant DFSDM_DFSDM2_CNVTIMR  \ offset: 0x188 : DFSDM conversion timer register
$4001758c constant DFSDM_DFSDM3_CNVTIMR  \ offset: 0x18C : DFSDM conversion timer register

