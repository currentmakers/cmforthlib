\
\ @file adf.fs
\ @brief Audio digital filter
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief ADF global control register
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000001 constant ADF_ADF_GCR_TRGO                                 \ Trigger output control


\
\ @brief ADF clock generator control register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant ADF_ADF_CKGCR_CKGDEN                             \ CKGEN dividers enable
$00000002 constant ADF_ADF_CKGCR_CCK0EN                             \ ADF_CCK0 clock enable
$00000004 constant ADF_ADF_CKGCR_CCK1EN                             \ ADF_CCK1 clock enable
$00000010 constant ADF_ADF_CKGCR_CKGMOD                             \ Clock generator mode
$00000020 constant ADF_ADF_CKGCR_CCK0DIR                            \ ADF_CCK0 direction
$00000040 constant ADF_ADF_CKGCR_CCK1DIR                            \ ADF_CCK1 direction
$00000100 constant ADF_ADF_CKGCR_TRGSENS                            \ CKGEN trigger sensitivity selection
$0000f000 constant ADF_ADF_CKGCR_TRGSRC                             \ Digital filter trigger signal selection
$000f0000 constant ADF_ADF_CKGCR_CCKDIV                             \ Divider to control the ADF_CCK clock
$7f000000 constant ADF_ADF_CKGCR_PROCDIV                            \ Divider to control the serial interface clock
$80000000 constant ADF_ADF_CKGCR_CKGACTIVE                          \ Clock generator active flag


\
\ @brief ADF serial interface control register 0
\ Address offset: 0x80
\ Reset value: 0x00001F00
\

$00000001 constant ADF_ADF_SITF0CR_SITFEN                           \ Serial interface enable
$00000006 constant ADF_ADF_SITF0CR_SCKSRC                           \ Serial clock source
$00000030 constant ADF_ADF_SITF0CR_SITFMOD                          \ Serial interface type
$00001f00 constant ADF_ADF_SITF0CR_STH                              \ Manchester symbol threshold/SPI threshold
$80000000 constant ADF_ADF_SITF0CR_SITFACTIVE                       \ Serial interface active flag


\
\ @brief ADF bitstream matrix control register 0
\ Address offset: 0x84
\ Reset value: 0x00000000
\

$0000001f constant ADF_ADF_BSMX0CR_BSSEL                            \ Bitstream selection
$80000000 constant ADF_ADF_BSMX0CR_BSMXACTIVE                       \ BSMX active flag


\
\ @brief ADF digital filter control register 0
\ Address offset: 0x88
\ Reset value: 0x00000000
\

$00000001 constant ADF_ADF_DFLT0CR_DFLTEN                           \ DFLT0 enable
$00000002 constant ADF_ADF_DFLT0CR_DMAEN                            \ DMA requests enable
$00000004 constant ADF_ADF_DFLT0CR_FTH                              \ RXFIFO threshold selection
$00000070 constant ADF_ADF_DFLT0CR_ACQMOD                           \ DFLT0 trigger mode
$00000100 constant ADF_ADF_DFLT0CR_TRGSENS                          \ DFLT0 trigger sensitivity selection
$0000f000 constant ADF_ADF_DFLT0CR_TRGSRC                           \ DFLT0 trigger signal selection
$0ff00000 constant ADF_ADF_DFLT0CR_NBDIS                            \ Number of samples to be discarded
$40000000 constant ADF_ADF_DFLT0CR_DFLTRUN                          \ DFLT0 run status flag
$80000000 constant ADF_ADF_DFLT0CR_DFLTACTIVE                       \ DFLT0 active flag


\
\ @brief ADF digital filer configuration register 0
\ Address offset: 0x8C
\ Reset value: 0x00000000
\

$00000003 constant ADF_ADF_DFLT0CICR_DATSRC                         \ Source data for the digital filter
$00000070 constant ADF_ADF_DFLT0CICR_CICMOD                         \ Select the CIC order
$0000ff00 constant ADF_ADF_DFLT0CICR_MCICD                          \ CIC decimation ratio selection
$00010000 constant ADF_ADF_DFLT0CICR_MCICD8                         \ CIC decimation ratio selection
$03f00000 constant ADF_ADF_DFLT0CICR_SCALE                          \ Scaling factor selection


\
\ @brief ADF reshape filter configuration register 0
\ Address offset: 0x90
\ Reset value: 0x00000000
\

$00000001 constant ADF_ADF_DFLT0RSFR_RSFLTBYP                       \ Reshaper filter bypass
$00000010 constant ADF_ADF_DFLT0RSFR_RSFLTD                         \ Reshaper filter decimation ratio
$00000080 constant ADF_ADF_DFLT0RSFR_HPFBYP                         \ High-pass filter bypass
$00000300 constant ADF_ADF_DFLT0RSFR_HPFC                           \ High-pass filter cut-off frequency


\
\ @brief ADF delay control register 0
\ Address offset: 0xA4
\ Reset value: 0x00000000
\

$0000007f constant ADF_ADF_DLY0CR_SKPDLY                            \ Delay to apply to a bitstream
$80000000 constant ADF_ADF_DLY0CR_SKPBF                             \ Skip busy flag


\
\ @brief ADF DFLT0 interrupt enable register
\ Address offset: 0xAC
\ Reset value: 0x00000000
\

$00000001 constant ADF_ADF_DFLT0IER_FTHIE                           \ RXFIFO threshold interrupt enable
$00000002 constant ADF_ADF_DFLT0IER_DOVRIE                          \ Data overflow interrupt enable
$00000200 constant ADF_ADF_DFLT0IER_SATIE                           \ Saturation detection interrupt enable
$00000400 constant ADF_ADF_DFLT0IER_CKABIE                          \ Clock absence detection interrupt enable
$00000800 constant ADF_ADF_DFLT0IER_RFOVRIE                         \ Reshape filter overrun interrupt enable
$00001000 constant ADF_ADF_DFLT0IER_SDDETIE                         \ Sound activity detection interrupt enable
$00002000 constant ADF_ADF_DFLT0IER_SDLVLIE                         \ SAD sound-level value ready enable


\
\ @brief ADF DFLT0 interrupt status register 0
\ Address offset: 0xB0
\ Reset value: 0x00000000
\

$00000001 constant ADF_ADF_DFLT0ISR_FTHF                            \ RXFIFO threshold flag
$00000002 constant ADF_ADF_DFLT0ISR_DOVRF                           \ Data overflow flag
$00000008 constant ADF_ADF_DFLT0ISR_RXNEF                           \ RXFIFO not empty flag
$00000200 constant ADF_ADF_DFLT0ISR_SATF                            \ Saturation detection flag
$00000400 constant ADF_ADF_DFLT0ISR_CKABF                           \ Clock absence detection flag
$00000800 constant ADF_ADF_DFLT0ISR_RFOVRF                          \ Reshape filter overrun detection flag
$00001000 constant ADF_ADF_DFLT0ISR_SDDETF                          \ Sound activity detection flag
$00002000 constant ADF_ADF_DFLT0ISR_SDLVLF                          \ Sound level value ready flag


\
\ @brief ADF SAD control register
\ Address offset: 0xB8
\ Reset value: 0x00000000
\

$00000001 constant ADF_ADF_SADCR_SADEN                              \ Sound activity detector enable
$00000006 constant ADF_ADF_SADCR_DATCAP                             \ Data capture mode
$00000008 constant ADF_ADF_SADCR_DETCFG                             \ Sound trigger event configuration
$00000030 constant ADF_ADF_SADCR_SADST                              \ SAD state
$00000080 constant ADF_ADF_SADCR_HYSTEN                             \ Hysteresis enable
$00000700 constant ADF_ADF_SADCR_FRSIZE                             \ Frame size
$00003000 constant ADF_ADF_SADCR_SADMOD                             \ SAD working mode
$80000000 constant ADF_ADF_SADCR_SADACTIVE                          \ SAD Active flag


\
\ @brief ADF SAD configuration register
\ Address offset: 0xBC
\ Reset value: 0x00000000
\

$0000000f constant ADF_ADF_SADCFGR_SNTHR                            \ Signal to noise threshold
$00000070 constant ADF_ADF_SADCFGR_ANSLP                            \ Ambient noise slope control
$00000700 constant ADF_ADF_SADCFGR_LFRNB                            \ Number of learning frames
$00007000 constant ADF_ADF_SADCFGR_HGOVR                            \ Hangover time window
$1fff0000 constant ADF_ADF_SADCFGR_ANMIN                            \ Minimum noise level


\
\ @brief ADF SAD sound level register
\ Address offset: 0xC0
\ Reset value: 0x00000000
\

$00007fff constant ADF_ADF_SADSDLVR_SDLVL                           \ Short term sound level


\
\ @brief ADF SAD ambient noise level register
\ Address offset: 0xC4
\ Reset value: 0x00000000
\

$00007fff constant ADF_ADF_SADANLVR_ANLVL                           \ Ambient noise level estimation


\
\ @brief ADF digital filter data register 0
\ Address offset: 0xF0
\ Reset value: 0x00000000
\

$ffffff00 constant ADF_ADF_DFLT0DR_DR                               \ Data processed by DFT0


\
\ @brief Audio digital filter
\
$42026000 constant ADF_ADF_GCR    \ offset: 0x00 : ADF global control register
$42026004 constant ADF_ADF_CKGCR  \ offset: 0x04 : ADF clock generator control register
$42026080 constant ADF_ADF_SITF0CR  \ offset: 0x80 : ADF serial interface control register 0
$42026084 constant ADF_ADF_BSMX0CR  \ offset: 0x84 : ADF bitstream matrix control register 0
$42026088 constant ADF_ADF_DFLT0CR  \ offset: 0x88 : ADF digital filter control register 0
$4202608c constant ADF_ADF_DFLT0CICR  \ offset: 0x8C : ADF digital filer configuration register 0
$42026090 constant ADF_ADF_DFLT0RSFR  \ offset: 0x90 : ADF reshape filter configuration register 0
$420260a4 constant ADF_ADF_DLY0CR  \ offset: 0xA4 : ADF delay control register 0
$420260ac constant ADF_ADF_DFLT0IER  \ offset: 0xAC : ADF DFLT0 interrupt enable register
$420260b0 constant ADF_ADF_DFLT0ISR  \ offset: 0xB0 : ADF DFLT0 interrupt status register 0
$420260b8 constant ADF_ADF_SADCR  \ offset: 0xB8 : ADF SAD control register
$420260bc constant ADF_ADF_SADCFGR  \ offset: 0xBC : ADF SAD configuration register
$420260c0 constant ADF_ADF_SADSDLVR  \ offset: 0xC0 : ADF SAD sound level register
$420260c4 constant ADF_ADF_SADANLVR  \ offset: 0xC4 : ADF SAD ambient noise level register
$420260f0 constant ADF_ADF_DFLT0DR  \ offset: 0xF0 : ADF digital filter data register 0

