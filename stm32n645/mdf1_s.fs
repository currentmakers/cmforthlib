\
\ @file mdf1_s.fs
\ @brief MDF register block
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief MDF global control register
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000001 constant MDF1_S_MDF_GCR_TRGO                              \ Trigger output control
$000000f0 constant MDF1_S_MDF_GCR_ILVNB                             \ Interleaved number


\
\ @brief MDF clock generator control register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant MDF1_S_MDF_CKGCR_CKGDEN                          \ CKGEN dividers enable
$00000002 constant MDF1_S_MDF_CKGCR_CCK0EN                          \ MDF_CCK0 clock enable
$00000004 constant MDF1_S_MDF_CKGCR_CCK1EN                          \ MDF_CCK1 clock enable
$00000010 constant MDF1_S_MDF_CKGCR_CKGMOD                          \ Clock generator mode
$00000020 constant MDF1_S_MDF_CKGCR_CCK0DIR                         \ MDF_CCK0 direction
$00000040 constant MDF1_S_MDF_CKGCR_CCK1DIR                         \ MDF_CCK1 direction
$00000100 constant MDF1_S_MDF_CKGCR_TRGSENS                         \ CKGEN trigger sensitivity selection
$0000f000 constant MDF1_S_MDF_CKGCR_TRGSRC                          \ Digital filter trigger signal selection
$000f0000 constant MDF1_S_MDF_CKGCR_CCKDIV                          \ Divider to control the MDF_CCK clock
$7f000000 constant MDF1_S_MDF_CKGCR_PROCDIV                         \ Divider to control the serial interface clock
$80000000 constant MDF1_S_MDF_CKGCR_CKGACTIVE                       \ Clock generator active flag


\
\ @brief MDF serial interface control register 0
\ Address offset: 0x80
\ Reset value: 0x00001F00
\

$00000001 constant MDF1_S_MDF_SITF0CR_SITFEN                        \ Serial interface enable
$00000006 constant MDF1_S_MDF_SITF0CR_SCKSRC                        \ Serial clock source
$00000030 constant MDF1_S_MDF_SITF0CR_SITFMOD                       \ Serial interface type
$00001f00 constant MDF1_S_MDF_SITF0CR_STH                           \ Manchester symbol threshold/SPI threshold
$80000000 constant MDF1_S_MDF_SITF0CR_SITFACTIVE                    \ Serial interface active flag


\
\ @brief MDF bitstream matrix control register 0
\ Address offset: 0x84
\ Reset value: 0x00000000
\

$0000001f constant MDF1_S_MDF_BSMX0CR_BSSEL                         \ Bitstream Selection
$80000000 constant MDF1_S_MDF_BSMX0CR_BSMXACTIVE                    \ BSMX active flag


\
\ @brief MDF digital filter control register 0
\ Address offset: 0x88
\ Reset value: 0x00000000
\

$00000001 constant MDF1_S_MDF_DFLT0CR_DFLTEN                        \ Digital filter enable
$00000002 constant MDF1_S_MDF_DFLT0CR_DMAEN                         \ DMA requests enable
$00000004 constant MDF1_S_MDF_DFLT0CR_FTH                           \ RXFIFO Threshold selection
$00000070 constant MDF1_S_MDF_DFLT0CR_ACQMOD                        \ Digital filter trigger mode
$00000100 constant MDF1_S_MDF_DFLT0CR_TRGSENS                       \ Digital filter trigger sensitivity selection
$0000f000 constant MDF1_S_MDF_DFLT0CR_TRGSRC                        \ Digital filter trigger signal selection
$00010000 constant MDF1_S_MDF_DFLT0CR_SNPSFMT                       \ Snapshot data format
$0ff00000 constant MDF1_S_MDF_DFLT0CR_NBDIS                         \ Number of samples to be discarded
$40000000 constant MDF1_S_MDF_DFLT0CR_DFLTRUN                       \ Digital filter run status flag
$80000000 constant MDF1_S_MDF_DFLT0CR_DFLTACTIVE                    \ Digital filter active flag


\
\ @brief MDF digital filter configuration register 0
\ Address offset: 0x8C
\ Reset value: 0x00000000
\

$00000003 constant MDF1_S_MDF_DFLT0CICR_DATSRC                      \ Source data for the digital filter
$00000070 constant MDF1_S_MDF_DFLT0CICR_CICMOD                      \ Select the CIC mode
$0000ff00 constant MDF1_S_MDF_DFLT0CICR_MCICD                       \ CIC decimation ratio selection
$00010000 constant MDF1_S_MDF_DFLT0CICR_MCICD8                      \ CIC decimation ratio selection
$03f00000 constant MDF1_S_MDF_DFLT0CICR_SCALE                       \ Scaling factor selection


\
\ @brief MDF reshape filter configuration register 0
\ Address offset: 0x90
\ Reset value: 0x00000000
\

$00000001 constant MDF1_S_MDF_DFLT0RSFR_RSFLTBYP                    \ Reshaper filter bypass
$00000010 constant MDF1_S_MDF_DFLT0RSFR_RSFLTD                      \ Reshaper filter decimation ratio
$00000080 constant MDF1_S_MDF_DFLT0RSFR_HPFBYP                      \ High-pass filter bypass
$00000300 constant MDF1_S_MDF_DFLT0RSFR_HPFC                        \ High-pass filter cut-off frequency


\
\ @brief MDF integrator configuration register 0
\ Address offset: 0x94
\ Reset value: 0x00000000
\

$00000003 constant MDF1_S_MDF_DFLT0INTR_INTDIV                      \ Integrator output division
$000007f0 constant MDF1_S_MDF_DFLT0INTR_INTVAL                      \ Integration value selection


\
\ @brief MDF out-of limit detector control register 0
\ Address offset: 0x98
\ Reset value: 0x00000000
\

$00000001 constant MDF1_S_MDF_OLD0CR_OLDEN                          \ OLDx enable
$00000002 constant MDF1_S_MDF_OLD0CR_THINB                          \ Threshold In band
$000000f0 constant MDF1_S_MDF_OLD0CR_BKOLD                          \ Break signal assignment for out-of limit detector
$00003000 constant MDF1_S_MDF_OLD0CR_ACICN                          \ OLDx CIC order selection
$003e0000 constant MDF1_S_MDF_OLD0CR_ACICD                          \ OLDx CIC decimation ratio selection
$80000000 constant MDF1_S_MDF_OLD0CR_OLDACTIVE                      \ OLDx active flag


\
\ @brief MDF OLD0 low threshold register 0
\ Address offset: 0x9C
\ Reset value: 0x00000000
\

$03ffffff constant MDF1_S_MDF_OLD0THLR_OLDTHL                       \ OLD low threshold value


\
\ @brief MDF OLD0 high threshold register 0
\ Address offset: 0xA0
\ Reset value: 0x00000000
\

$03ffffff constant MDF1_S_MDF_OLD0THHR_OLDTHH                       \ OLDx high threshold value


\
\ @brief MDF delay control register 0
\ Address offset: 0xA4
\ Reset value: 0x00000000
\

$0000007f constant MDF1_S_MDF_DLY0CR_SKPDLY                         \ Delay to apply to a bitstream
$80000000 constant MDF1_S_MDF_DLY0CR_SKPBF                          \ Skip busy flag


\
\ @brief MDF short circuit detector control register 0
\ Address offset: 0xA8
\ Reset value: 0x00000000
\

$00000001 constant MDF1_S_MDF_SCD0CR_SCDEN                          \ SCDx enable
$000000f0 constant MDF1_S_MDF_SCD0CR_BKSCD                          \ Break signal assignment for short circuit detector
$000ff000 constant MDF1_S_MDF_SCD0CR_SCDT                           \ SCDx threshold
$80000000 constant MDF1_S_MDF_SCD0CR_SCDACTIVE                      \ SCDx active flag


\
\ @brief MDF DFLT0 interrupt enable register 0
\ Address offset: 0xAC
\ Reset value: 0x00000000
\

$00000001 constant MDF1_S_MDF_DFLT0IER_FTHIE                        \ RXFIFO threshold interrupt enable
$00000002 constant MDF1_S_MDF_DFLT0IER_DOVRIE                       \ Data overflow interrupt enable
$00000004 constant MDF1_S_MDF_DFLT0IER_SSDRIE                       \ Snapshot data ready interrupt enable
$00000010 constant MDF1_S_MDF_DFLT0IER_OLDIE                        \ OLD0 interrupt enable
$00000080 constant MDF1_S_MDF_DFLT0IER_SSOVRIE                      \ Snapshot overrun interrupt enable
$00000100 constant MDF1_S_MDF_DFLT0IER_SCDIE                        \ SCD0 interrupt enable
$00000200 constant MDF1_S_MDF_DFLT0IER_SATIE                        \ Saturation detection interrupt enable
$00000400 constant MDF1_S_MDF_DFLT0IER_CKABIE                       \ Clock absence detection interrupt enable
$00000800 constant MDF1_S_MDF_DFLT0IER_RFOVRIE                      \ Reshape filter overrun interrupt enable


\
\ @brief MDF DFLT0 interrupt status register 0
\ Address offset: 0xB0
\ Reset value: 0x00000000
\

$00000001 constant MDF1_S_MDF_DFLT0ISR_FTHF                         \ RXFIFO threshold flag
$00000002 constant MDF1_S_MDF_DFLT0ISR_DOVRF                        \ Data overflow flag
$00000004 constant MDF1_S_MDF_DFLT0ISR_SSDRF                        \ Snapshot data ready flag
$00000008 constant MDF1_S_MDF_DFLT0ISR_RXNEF                        \ RXFIFO not-empty flag
$00000010 constant MDF1_S_MDF_DFLT0ISR_OLDF                         \ OLD0 flag
$00000020 constant MDF1_S_MDF_DFLT0ISR_THLF                         \ Low-threshold status flag
$00000040 constant MDF1_S_MDF_DFLT0ISR_THHF                         \ High-threshold status flag
$00000080 constant MDF1_S_MDF_DFLT0ISR_SSOVRF                       \ Snapshot overrun flag
$00000100 constant MDF1_S_MDF_DFLT0ISR_SCDF                         \ Short-circuit detector flag
$00000200 constant MDF1_S_MDF_DFLT0ISR_SATF                         \ Saturation detection flag
$00000400 constant MDF1_S_MDF_DFLT0ISR_CKABF                        \ Clock absence detection flag
$00000800 constant MDF1_S_MDF_DFLT0ISR_RFOVRF                       \ Reshape filter overrun detection flag


\
\ @brief MDF offset error compensation control register 0
\ Address offset: 0xB4
\ Reset value: 0x00000000
\

$03ffffff constant MDF1_S_MDF_OEC0CR_OFFSET                         \ Offset error compensation


\
\ @brief MDF snapshot data register 0
\ Address offset: 0xEC
\ Reset value: 0x00000000
\

$000001ff constant MDF1_S_MDF_SNPS0DR_MCICDC                        \ Contains the MCIC decimation counter value when the last trigger event occurs (MCIC_CNT)
$0000fe00 constant MDF1_S_MDF_SNPS0DR_EXTSDR                        \ Extended data size
$ffff0000 constant MDF1_S_MDF_SNPS0DR_SDR                           \ Contains the 16 MSB of the last valid data processed by the digital filter.


\
\ @brief MDF digital filter data register 0
\ Address offset: 0xF0
\ Reset value: 0x00000000
\

$ffffff00 constant MDF1_S_MDF_DFLT0DR_DR                            \ Data processed by digital filter


\
\ @brief MDF serial interface control register 1
\ Address offset: 0x100
\ Reset value: 0x00001F00
\

$00000001 constant MDF1_S_MDF_SITF1CR_SITFEN                        \ Serial interface enable
$00000006 constant MDF1_S_MDF_SITF1CR_SCKSRC                        \ Serial clock source
$00000030 constant MDF1_S_MDF_SITF1CR_SITFMOD                       \ Serial interface type
$00001f00 constant MDF1_S_MDF_SITF1CR_STH                           \ Manchester symbol threshold/SPI threshold
$80000000 constant MDF1_S_MDF_SITF1CR_SITFACTIVE                    \ Serial interface active flag


\
\ @brief MDF bitstream matrix control register 1
\ Address offset: 0x104
\ Reset value: 0x00000000
\

$0000001f constant MDF1_S_MDF_BSMX1CR_BSSEL                         \ Bitstream Selection
$80000000 constant MDF1_S_MDF_BSMX1CR_BSMXACTIVE                    \ BSMX active flag


\
\ @brief MDF digital filter control register 1
\ Address offset: 0x108
\ Reset value: 0x00000000
\

$00000001 constant MDF1_S_MDF_DFLT1CR_DFLTEN                        \ Digital filter enable
$00000002 constant MDF1_S_MDF_DFLT1CR_DMAEN                         \ DMA requests enable
$00000004 constant MDF1_S_MDF_DFLT1CR_FTH                           \ RXFIFO Threshold selection
$00000070 constant MDF1_S_MDF_DFLT1CR_ACQMOD                        \ Digital filter trigger mode
$00000100 constant MDF1_S_MDF_DFLT1CR_TRGSENS                       \ Digital filter trigger sensitivity selection
$0000f000 constant MDF1_S_MDF_DFLT1CR_TRGSRC                        \ Digital filter trigger signal selection
$00010000 constant MDF1_S_MDF_DFLT1CR_SNPSFMT                       \ Snapshot data format
$0ff00000 constant MDF1_S_MDF_DFLT1CR_NBDIS                         \ Number of samples to be discarded
$40000000 constant MDF1_S_MDF_DFLT1CR_DFLTRUN                       \ Digital filter run status flag
$80000000 constant MDF1_S_MDF_DFLT1CR_DFLTACTIVE                    \ Digital filter active flag


\
\ @brief MDF digital filter configuration register 1
\ Address offset: 0x10C
\ Reset value: 0x00000000
\

$00000003 constant MDF1_S_MDF_DFLT1CICR_DATSRC                      \ Source data for the digital filter
$00000070 constant MDF1_S_MDF_DFLT1CICR_CICMOD                      \ Select the CIC mode
$0000ff00 constant MDF1_S_MDF_DFLT1CICR_MCICD                       \ CIC decimation ratio selection
$00010000 constant MDF1_S_MDF_DFLT1CICR_MCICD8                      \ CIC decimation ratio selection
$03f00000 constant MDF1_S_MDF_DFLT1CICR_SCALE                       \ Scaling factor selection


\
\ @brief MDF reshape filter configuration register 1
\ Address offset: 0x110
\ Reset value: 0x00000000
\

$00000001 constant MDF1_S_MDF_DFLT1RSFR_RSFLTBYP                    \ Reshaper filter bypass
$00000010 constant MDF1_S_MDF_DFLT1RSFR_RSFLTD                      \ Reshaper filter decimation ratio
$00000080 constant MDF1_S_MDF_DFLT1RSFR_HPFBYP                      \ High-pass filter bypass
$00000300 constant MDF1_S_MDF_DFLT1RSFR_HPFC                        \ High-pass filter cut-off frequency


\
\ @brief MDF integrator configuration register 1
\ Address offset: 0x114
\ Reset value: 0x00000000
\

$00000003 constant MDF1_S_MDF_DFLT1INTR_INTDIV                      \ Integrator output division
$000007f0 constant MDF1_S_MDF_DFLT1INTR_INTVAL                      \ Integration value selection


\
\ @brief MDF out-of limit detector control register 1
\ Address offset: 0x118
\ Reset value: 0x00000000
\

$00000001 constant MDF1_S_MDF_OLD1CR_OLDEN                          \ OLDx enable
$00000002 constant MDF1_S_MDF_OLD1CR_THINB                          \ Threshold In band
$000000f0 constant MDF1_S_MDF_OLD1CR_BKOLD                          \ Break signal assignment for out-of limit detector
$00003000 constant MDF1_S_MDF_OLD1CR_ACICN                          \ OLDx CIC order selection
$003e0000 constant MDF1_S_MDF_OLD1CR_ACICD                          \ OLDx CIC decimation ratio selection
$80000000 constant MDF1_S_MDF_OLD1CR_OLDACTIVE                      \ OLDx active flag


\
\ @brief MDF OLD1 low threshold register 1
\ Address offset: 0x11C
\ Reset value: 0x00000000
\

$03ffffff constant MDF1_S_MDF_OLD1THLR_OLDTHL                       \ OLD low threshold value


\
\ @brief MDF OLD1 high threshold register 1
\ Address offset: 0x120
\ Reset value: 0x00000000
\

$03ffffff constant MDF1_S_MDF_OLD1THHR_OLDTHH                       \ OLDx high threshold value


\
\ @brief MDF delay control register 1
\ Address offset: 0x124
\ Reset value: 0x00000000
\

$0000007f constant MDF1_S_MDF_DLY1CR_SKPDLY                         \ Delay to apply to a bitstream
$80000000 constant MDF1_S_MDF_DLY1CR_SKPBF                          \ Skip busy flag


\
\ @brief MDF short circuit detector control register 1
\ Address offset: 0x128
\ Reset value: 0x00000000
\

$00000001 constant MDF1_S_MDF_SCD1CR_SCDEN                          \ SCDx enable
$000000f0 constant MDF1_S_MDF_SCD1CR_BKSCD                          \ Break signal assignment for short circuit detector
$000ff000 constant MDF1_S_MDF_SCD1CR_SCDT                           \ SCDx threshold
$80000000 constant MDF1_S_MDF_SCD1CR_SCDACTIVE                      \ SCDx active flag


\
\ @brief MDF DFLT1 interrupt enable register 1
\ Address offset: 0x12C
\ Reset value: 0x00000000
\

$00000001 constant MDF1_S_MDF_DFLT1IER_FTHIE                        \ RXFIFO threshold interrupt enable
$00000002 constant MDF1_S_MDF_DFLT1IER_DOVRIE                       \ Data overflow interrupt enable
$00000004 constant MDF1_S_MDF_DFLT1IER_SSDRIE                       \ Snapshot data ready interrupt enable
$00000010 constant MDF1_S_MDF_DFLT1IER_OLDIE                        \ OLDx interrupt enable
$00000080 constant MDF1_S_MDF_DFLT1IER_SSOVRIE                      \ Snapshot overrun interrupt enable
$00000100 constant MDF1_S_MDF_DFLT1IER_SCDIE                        \ SCDx interrupt enable
$00000200 constant MDF1_S_MDF_DFLT1IER_SATIE                        \ Saturation detection interrupt enable
$00000400 constant MDF1_S_MDF_DFLT1IER_CKABIE                       \ Clock absence detection interrupt enable
$00000800 constant MDF1_S_MDF_DFLT1IER_RFOVRIE                      \ Reshape filter overrun interrupt enable


\
\ @brief MDF DFLT1 interrupt status register 1
\ Address offset: 0x130
\ Reset value: 0x00000000
\

$00000001 constant MDF1_S_MDF_DFLT1ISR_FTHF                         \ RXFIFO threshold flag
$00000002 constant MDF1_S_MDF_DFLT1ISR_DOVRF                        \ Data overflow flag
$00000004 constant MDF1_S_MDF_DFLT1ISR_SSDRF                        \ Snapshot data ready flag
$00000008 constant MDF1_S_MDF_DFLT1ISR_RXNEF                        \ RXFIFO not-empty flag
$00000010 constant MDF1_S_MDF_DFLT1ISR_OLDF                         \ OLDx flag
$00000020 constant MDF1_S_MDF_DFLT1ISR_THLF                         \ Low-threshold status flag
$00000040 constant MDF1_S_MDF_DFLT1ISR_THHF                         \ High-threshold status flag
$00000080 constant MDF1_S_MDF_DFLT1ISR_SSOVRF                       \ Snapshot overrun flag
$00000100 constant MDF1_S_MDF_DFLT1ISR_SCDF                         \ Short-circuit detector flag
$00000200 constant MDF1_S_MDF_DFLT1ISR_SATF                         \ Saturation detection flag
$00000400 constant MDF1_S_MDF_DFLT1ISR_CKABF                        \ Clock absence detection flag
$00000800 constant MDF1_S_MDF_DFLT1ISR_RFOVRF                       \ Reshape filter overrun detection flag


\
\ @brief MDF offset error compensation control register 1
\ Address offset: 0x134
\ Reset value: 0x00000000
\

$03ffffff constant MDF1_S_MDF_OEC1CR_OFFSET                         \ Offset error compensation


\
\ @brief MDF snapshot data register 1
\ Address offset: 0x16C
\ Reset value: 0x00000000
\

$000001ff constant MDF1_S_MDF_SNPS1DR_MCICDC                        \ Contains the MCIC decimation counter value when the last trigger event occurs (MCIC_CNT)
$0000fe00 constant MDF1_S_MDF_SNPS1DR_EXTSDR                        \ Extended data size
$ffff0000 constant MDF1_S_MDF_SNPS1DR_SDR                           \ Contains the 16 MSB of the last valid data processed by the digital filter.


\
\ @brief MDF digital filter data register 1
\ Address offset: 0x170
\ Reset value: 0x00000000
\

$ffffff00 constant MDF1_S_MDF_DFLT1DR_DR                            \ Data processed by digital filter


\
\ @brief MDF serial interface control register 2
\ Address offset: 0x180
\ Reset value: 0x00001F00
\

$00000001 constant MDF1_S_MDF_SITF2CR_SITFEN                        \ Serial interface enable
$00000006 constant MDF1_S_MDF_SITF2CR_SCKSRC                        \ Serial clock source
$00000030 constant MDF1_S_MDF_SITF2CR_SITFMOD                       \ Serial interface type
$00001f00 constant MDF1_S_MDF_SITF2CR_STH                           \ Manchester symbol threshold/SPI threshold
$80000000 constant MDF1_S_MDF_SITF2CR_SITFACTIVE                    \ Serial interface active flag


\
\ @brief MDF bitstream matrix control register 2
\ Address offset: 0x184
\ Reset value: 0x00000000
\

$0000001f constant MDF1_S_MDF_BSMX2CR_BSSEL                         \ Bitstream Selection
$80000000 constant MDF1_S_MDF_BSMX2CR_BSMXACTIVE                    \ BSMX active flag


\
\ @brief MDF digital filter control register 2
\ Address offset: 0x188
\ Reset value: 0x00000000
\

$00000001 constant MDF1_S_MDF_DFLT2CR_DFLTEN                        \ Digital filter enable
$00000002 constant MDF1_S_MDF_DFLT2CR_DMAEN                         \ DMA requests enable
$00000004 constant MDF1_S_MDF_DFLT2CR_FTH                           \ RXFIFO Threshold selection
$00000070 constant MDF1_S_MDF_DFLT2CR_ACQMOD                        \ Digital filter trigger mode
$00000100 constant MDF1_S_MDF_DFLT2CR_TRGSENS                       \ Digital filter trigger sensitivity selection
$0000f000 constant MDF1_S_MDF_DFLT2CR_TRGSRC                        \ Digital filter trigger signal selection
$00010000 constant MDF1_S_MDF_DFLT2CR_SNPSFMT                       \ Snapshot data format
$0ff00000 constant MDF1_S_MDF_DFLT2CR_NBDIS                         \ Number of samples to be discarded
$40000000 constant MDF1_S_MDF_DFLT2CR_DFLTRUN                       \ Digital filter run status flag
$80000000 constant MDF1_S_MDF_DFLT2CR_DFLTACTIVE                    \ Digital filter active flag


\
\ @brief MDF digital filter configuration register 2
\ Address offset: 0x18C
\ Reset value: 0x00000000
\

$00000003 constant MDF1_S_MDF_DFLT2CICR_DATSRC                      \ Source data for the digital filter
$00000070 constant MDF1_S_MDF_DFLT2CICR_CICMOD                      \ Select the CIC mode
$0000ff00 constant MDF1_S_MDF_DFLT2CICR_MCICD                       \ CIC decimation ratio selection
$00010000 constant MDF1_S_MDF_DFLT2CICR_MCICD8                      \ CIC decimation ratio selection
$03f00000 constant MDF1_S_MDF_DFLT2CICR_SCALE                       \ Scaling factor selection


\
\ @brief MDF reshape filter configuration register 2
\ Address offset: 0x190
\ Reset value: 0x00000000
\

$00000001 constant MDF1_S_MDF_DFLT2RSFR_RSFLTBYP                    \ Reshaper filter bypass
$00000010 constant MDF1_S_MDF_DFLT2RSFR_RSFLTD                      \ Reshaper filter decimation ratio
$00000080 constant MDF1_S_MDF_DFLT2RSFR_HPFBYP                      \ High-pass filter bypass
$00000300 constant MDF1_S_MDF_DFLT2RSFR_HPFC                        \ High-pass filter cut-off frequency


\
\ @brief MDF integrator configuration register 2
\ Address offset: 0x194
\ Reset value: 0x00000000
\

$00000003 constant MDF1_S_MDF_DFLT2INTR_INTDIV                      \ Integrator output division
$000007f0 constant MDF1_S_MDF_DFLT2INTR_INTVAL                      \ Integration value selection


\
\ @brief MDF out-of limit detector control register 2
\ Address offset: 0x198
\ Reset value: 0x00000000
\

$00000001 constant MDF1_S_MDF_OLD2CR_OLDEN                          \ OLDx enable
$00000002 constant MDF1_S_MDF_OLD2CR_THINB                          \ Threshold In band
$000000f0 constant MDF1_S_MDF_OLD2CR_BKOLD                          \ Break signal assignment for out-of limit detector
$00003000 constant MDF1_S_MDF_OLD2CR_ACICN                          \ OLDx CIC order selection
$003e0000 constant MDF1_S_MDF_OLD2CR_ACICD                          \ OLDx CIC decimation ratio selection
$80000000 constant MDF1_S_MDF_OLD2CR_OLDACTIVE                      \ OLDx active flag


\
\ @brief MDF OLD2 low threshold register 2
\ Address offset: 0x19C
\ Reset value: 0x00000000
\

$03ffffff constant MDF1_S_MDF_OLD2THLR_OLDTHL                       \ OLD low threshold value


\
\ @brief MDF OLD2 high threshold register 2
\ Address offset: 0x1A0
\ Reset value: 0x00000000
\

$03ffffff constant MDF1_S_MDF_OLD2THHR_OLDTHH                       \ OLDx high threshold value


\
\ @brief MDF delay control register 2
\ Address offset: 0x1A4
\ Reset value: 0x00000000
\

$0000007f constant MDF1_S_MDF_DLY2CR_SKPDLY                         \ Delay to apply to a bitstream
$80000000 constant MDF1_S_MDF_DLY2CR_SKPBF                          \ Skip busy flag


\
\ @brief MDF short circuit detector control register 2
\ Address offset: 0x1A8
\ Reset value: 0x00000000
\

$00000001 constant MDF1_S_MDF_SCD2CR_SCDEN                          \ SCDx enable
$000000f0 constant MDF1_S_MDF_SCD2CR_BKSCD                          \ Break signal assignment for short circuit detector
$000ff000 constant MDF1_S_MDF_SCD2CR_SCDT                           \ SCDx threshold
$80000000 constant MDF1_S_MDF_SCD2CR_SCDACTIVE                      \ SCDx active flag


\
\ @brief MDF DFLT2 interrupt enable register 2
\ Address offset: 0x1AC
\ Reset value: 0x00000000
\

$00000001 constant MDF1_S_MDF_DFLT2IER_FTHIE                        \ RXFIFO threshold interrupt enable
$00000002 constant MDF1_S_MDF_DFLT2IER_DOVRIE                       \ Data overflow interrupt enable
$00000004 constant MDF1_S_MDF_DFLT2IER_SSDRIE                       \ Snapshot data ready interrupt enable
$00000010 constant MDF1_S_MDF_DFLT2IER_OLDIE                        \ OLDx interrupt enable
$00000080 constant MDF1_S_MDF_DFLT2IER_SSOVRIE                      \ Snapshot overrun interrupt enable
$00000100 constant MDF1_S_MDF_DFLT2IER_SCDIE                        \ SCDx interrupt enable
$00000200 constant MDF1_S_MDF_DFLT2IER_SATIE                        \ Saturation detection interrupt enable
$00000400 constant MDF1_S_MDF_DFLT2IER_CKABIE                       \ Clock absence detection interrupt enable
$00000800 constant MDF1_S_MDF_DFLT2IER_RFOVRIE                      \ Reshape filter overrun interrupt enable


\
\ @brief MDF DFLT2 interrupt status register 2
\ Address offset: 0x1B0
\ Reset value: 0x00000000
\

$00000001 constant MDF1_S_MDF_DFLT2ISR_FTHF                         \ RXFIFO threshold flag
$00000002 constant MDF1_S_MDF_DFLT2ISR_DOVRF                        \ Data overflow flag
$00000004 constant MDF1_S_MDF_DFLT2ISR_SSDRF                        \ Snapshot data ready flag
$00000008 constant MDF1_S_MDF_DFLT2ISR_RXNEF                        \ RXFIFO not-empty flag
$00000010 constant MDF1_S_MDF_DFLT2ISR_OLDF                         \ OLDx flag
$00000020 constant MDF1_S_MDF_DFLT2ISR_THLF                         \ Low-threshold status flag
$00000040 constant MDF1_S_MDF_DFLT2ISR_THHF                         \ High-threshold status flag
$00000080 constant MDF1_S_MDF_DFLT2ISR_SSOVRF                       \ Snapshot overrun flag
$00000100 constant MDF1_S_MDF_DFLT2ISR_SCDF                         \ Short-circuit detector flag
$00000200 constant MDF1_S_MDF_DFLT2ISR_SATF                         \ Saturation detection flag
$00000400 constant MDF1_S_MDF_DFLT2ISR_CKABF                        \ Clock absence detection flag
$00000800 constant MDF1_S_MDF_DFLT2ISR_RFOVRF                       \ Reshape filter overrun detection flag


\
\ @brief MDF offset error compensation control register 2
\ Address offset: 0x1B4
\ Reset value: 0x00000000
\

$03ffffff constant MDF1_S_MDF_OEC2CR_OFFSET                         \ Offset error compensation


\
\ @brief MDF snapshot data register 2
\ Address offset: 0x1EC
\ Reset value: 0x00000000
\

$000001ff constant MDF1_S_MDF_SNPS2DR_MCICDC                        \ Contains the MCIC decimation counter value when the last trigger event occurs (MCIC_CNT)
$0000fe00 constant MDF1_S_MDF_SNPS2DR_EXTSDR                        \ Extended data size
$ffff0000 constant MDF1_S_MDF_SNPS2DR_SDR                           \ Contains the 16 MSB of the last valid data processed by the digital filter.


\
\ @brief MDF digital filter data register 2
\ Address offset: 0x1F0
\ Reset value: 0x00000000
\

$ffffff00 constant MDF1_S_MDF_DFLT2DR_DR                            \ Data processed by digital filter


\
\ @brief MDF serial interface control register 3
\ Address offset: 0x200
\ Reset value: 0x00001F00
\

$00000001 constant MDF1_S_MDF_SITF3CR_SITFEN                        \ Serial interface enable
$00000006 constant MDF1_S_MDF_SITF3CR_SCKSRC                        \ Serial clock source
$00000030 constant MDF1_S_MDF_SITF3CR_SITFMOD                       \ Serial interface type
$00001f00 constant MDF1_S_MDF_SITF3CR_STH                           \ Manchester symbol threshold/SPI threshold
$80000000 constant MDF1_S_MDF_SITF3CR_SITFACTIVE                    \ Serial interface active flag


\
\ @brief MDF bitstream matrix control register 3
\ Address offset: 0x204
\ Reset value: 0x00000000
\

$0000001f constant MDF1_S_MDF_BSMX3CR_BSSEL                         \ Bitstream Selection
$80000000 constant MDF1_S_MDF_BSMX3CR_BSMXACTIVE                    \ BSMX active flag


\
\ @brief MDF digital filter control register 3
\ Address offset: 0x208
\ Reset value: 0x00000000
\

$00000001 constant MDF1_S_MDF_DFLT3CR_DFLTEN                        \ Digital filter enable
$00000002 constant MDF1_S_MDF_DFLT3CR_DMAEN                         \ DMA requests enable
$00000004 constant MDF1_S_MDF_DFLT3CR_FTH                           \ RXFIFO Threshold selection
$00000070 constant MDF1_S_MDF_DFLT3CR_ACQMOD                        \ Digital filter trigger mode
$00000100 constant MDF1_S_MDF_DFLT3CR_TRGSENS                       \ Digital filter trigger sensitivity selection
$0000f000 constant MDF1_S_MDF_DFLT3CR_TRGSRC                        \ Digital filter trigger signal selection
$00010000 constant MDF1_S_MDF_DFLT3CR_SNPSFMT                       \ Snapshot data format
$0ff00000 constant MDF1_S_MDF_DFLT3CR_NBDIS                         \ Number of samples to be discarded
$40000000 constant MDF1_S_MDF_DFLT3CR_DFLTRUN                       \ Digital filter run status flag
$80000000 constant MDF1_S_MDF_DFLT3CR_DFLTACTIVE                    \ Digital filter active flag


\
\ @brief MDF digital filter configuration register 3
\ Address offset: 0x20C
\ Reset value: 0x00000000
\

$00000003 constant MDF1_S_MDF_DFLT3CICR_DATSRC                      \ Source data for the digital filter
$00000070 constant MDF1_S_MDF_DFLT3CICR_CICMOD                      \ Select the CIC mode
$0000ff00 constant MDF1_S_MDF_DFLT3CICR_MCICD                       \ CIC decimation ratio selection
$00010000 constant MDF1_S_MDF_DFLT3CICR_MCICD8                      \ CIC decimation ratio selection
$03f00000 constant MDF1_S_MDF_DFLT3CICR_SCALE                       \ Scaling factor selection


\
\ @brief MDF reshape filter configuration register 3
\ Address offset: 0x210
\ Reset value: 0x00000000
\

$00000001 constant MDF1_S_MDF_DFLT3RSFR_RSFLTBYP                    \ Reshaper filter bypass
$00000010 constant MDF1_S_MDF_DFLT3RSFR_RSFLTD                      \ Reshaper filter decimation ratio
$00000080 constant MDF1_S_MDF_DFLT3RSFR_HPFBYP                      \ High-pass filter bypass
$00000300 constant MDF1_S_MDF_DFLT3RSFR_HPFC                        \ High-pass filter cut-off frequency


\
\ @brief MDF integrator configuration register 3
\ Address offset: 0x214
\ Reset value: 0x00000000
\

$00000003 constant MDF1_S_MDF_DFLT3INTR_INTDIV                      \ Integrator output division
$000007f0 constant MDF1_S_MDF_DFLT3INTR_INTVAL                      \ Integration value selection


\
\ @brief MDF out-of limit detector control register 3
\ Address offset: 0x218
\ Reset value: 0x00000000
\

$00000001 constant MDF1_S_MDF_OLD3CR_OLDEN                          \ OLDx enable
$00000002 constant MDF1_S_MDF_OLD3CR_THINB                          \ Threshold In band
$000000f0 constant MDF1_S_MDF_OLD3CR_BKOLD                          \ Break signal assignment for out-of limit detector
$00003000 constant MDF1_S_MDF_OLD3CR_ACICN                          \ OLDx CIC order selection
$003e0000 constant MDF1_S_MDF_OLD3CR_ACICD                          \ OLDx CIC decimation ratio selection
$80000000 constant MDF1_S_MDF_OLD3CR_OLDACTIVE                      \ OLDx active flag


\
\ @brief MDF OLD3 low threshold register 3
\ Address offset: 0x21C
\ Reset value: 0x00000000
\

$03ffffff constant MDF1_S_MDF_OLD3THLR_OLDTHL                       \ OLD low threshold value


\
\ @brief MDF OLD3 high threshold register 3
\ Address offset: 0x220
\ Reset value: 0x00000000
\

$03ffffff constant MDF1_S_MDF_OLD3THHR_OLDTHH                       \ OLDx high threshold value


\
\ @brief MDF delay control register 3
\ Address offset: 0x224
\ Reset value: 0x00000000
\

$0000007f constant MDF1_S_MDF_DLY3CR_SKPDLY                         \ Delay to apply to a bitstream
$80000000 constant MDF1_S_MDF_DLY3CR_SKPBF                          \ Skip busy flag


\
\ @brief MDF short circuit detector control register 3
\ Address offset: 0x228
\ Reset value: 0x00000000
\

$00000001 constant MDF1_S_MDF_SCD3CR_SCDEN                          \ SCDx enable
$000000f0 constant MDF1_S_MDF_SCD3CR_BKSCD                          \ Break signal assignment for short circuit detector
$000ff000 constant MDF1_S_MDF_SCD3CR_SCDT                           \ SCDx threshold
$80000000 constant MDF1_S_MDF_SCD3CR_SCDACTIVE                      \ SCDx active flag


\
\ @brief MDF DFLT3 interrupt enable register 3
\ Address offset: 0x22C
\ Reset value: 0x00000000
\

$00000001 constant MDF1_S_MDF_DFLT3IER_FTHIE                        \ RXFIFO threshold interrupt enable
$00000002 constant MDF1_S_MDF_DFLT3IER_DOVRIE                       \ Data overflow interrupt enable
$00000004 constant MDF1_S_MDF_DFLT3IER_SSDRIE                       \ Snapshot data ready interrupt enable
$00000010 constant MDF1_S_MDF_DFLT3IER_OLDIE                        \ OLDx interrupt enable
$00000080 constant MDF1_S_MDF_DFLT3IER_SSOVRIE                      \ Snapshot overrun interrupt enable
$00000100 constant MDF1_S_MDF_DFLT3IER_SCDIE                        \ SCDx interrupt enable
$00000200 constant MDF1_S_MDF_DFLT3IER_SATIE                        \ Saturation detection interrupt enable
$00000400 constant MDF1_S_MDF_DFLT3IER_CKABIE                       \ Clock absence detection interrupt enable
$00000800 constant MDF1_S_MDF_DFLT3IER_RFOVRIE                      \ Reshape filter overrun interrupt enable


\
\ @brief MDF DFLT3 interrupt status register 3
\ Address offset: 0x230
\ Reset value: 0x00000000
\

$00000001 constant MDF1_S_MDF_DFLT3ISR_FTHF                         \ RXFIFO threshold flag
$00000002 constant MDF1_S_MDF_DFLT3ISR_DOVRF                        \ Data overflow flag
$00000004 constant MDF1_S_MDF_DFLT3ISR_SSDRF                        \ Snapshot data ready flag
$00000008 constant MDF1_S_MDF_DFLT3ISR_RXNEF                        \ RXFIFO not-empty flag
$00000010 constant MDF1_S_MDF_DFLT3ISR_OLDF                         \ OLDx flag
$00000020 constant MDF1_S_MDF_DFLT3ISR_THLF                         \ Low-threshold status flag
$00000040 constant MDF1_S_MDF_DFLT3ISR_THHF                         \ High-threshold status flag
$00000080 constant MDF1_S_MDF_DFLT3ISR_SSOVRF                       \ Snapshot overrun flag
$00000100 constant MDF1_S_MDF_DFLT3ISR_SCDF                         \ Short-circuit detector flag
$00000200 constant MDF1_S_MDF_DFLT3ISR_SATF                         \ Saturation detection flag
$00000400 constant MDF1_S_MDF_DFLT3ISR_CKABF                        \ Clock absence detection flag
$00000800 constant MDF1_S_MDF_DFLT3ISR_RFOVRF                       \ Reshape filter overrun detection flag


\
\ @brief MDF offset error compensation control register 3
\ Address offset: 0x234
\ Reset value: 0x00000000
\

$03ffffff constant MDF1_S_MDF_OEC3CR_OFFSET                         \ Offset error compensation


\
\ @brief MDF snapshot data register 3
\ Address offset: 0x26C
\ Reset value: 0x00000000
\

$000001ff constant MDF1_S_MDF_SNPS3DR_MCICDC                        \ Contains the MCIC decimation counter value when the last trigger event occurs (MCIC_CNT)
$0000fe00 constant MDF1_S_MDF_SNPS3DR_EXTSDR                        \ Extended data size
$ffff0000 constant MDF1_S_MDF_SNPS3DR_SDR                           \ Contains the 16 MSB of the last valid data processed by the digital filter.


\
\ @brief MDF digital filter data register 3
\ Address offset: 0x270
\ Reset value: 0x00000000
\

$ffffff00 constant MDF1_S_MDF_DFLT3DR_DR                            \ Data processed by digital filter


\
\ @brief MDF serial interface control register 4
\ Address offset: 0x280
\ Reset value: 0x00001F00
\

$00000001 constant MDF1_S_MDF_SITF4CR_SITFEN                        \ Serial interface enable
$00000006 constant MDF1_S_MDF_SITF4CR_SCKSRC                        \ Serial clock source
$00000030 constant MDF1_S_MDF_SITF4CR_SITFMOD                       \ Serial interface type
$00001f00 constant MDF1_S_MDF_SITF4CR_STH                           \ Manchester symbol threshold/SPI threshold
$80000000 constant MDF1_S_MDF_SITF4CR_SITFACTIVE                    \ Serial interface active flag


\
\ @brief MDF bitstream matrix control register 4
\ Address offset: 0x284
\ Reset value: 0x00000000
\

$0000001f constant MDF1_S_MDF_BSMX4CR_BSSEL                         \ Bitstream Selection
$80000000 constant MDF1_S_MDF_BSMX4CR_BSMXACTIVE                    \ BSMX active flag


\
\ @brief MDF digital filter control register 4
\ Address offset: 0x288
\ Reset value: 0x00000000
\

$00000001 constant MDF1_S_MDF_DFLT4CR_DFLTEN                        \ Digital filter enable
$00000002 constant MDF1_S_MDF_DFLT4CR_DMAEN                         \ DMA requests enable
$00000004 constant MDF1_S_MDF_DFLT4CR_FTH                           \ RXFIFO Threshold selection
$00000070 constant MDF1_S_MDF_DFLT4CR_ACQMOD                        \ Digital filter trigger mode
$00000100 constant MDF1_S_MDF_DFLT4CR_TRGSENS                       \ Digital filter trigger sensitivity selection
$0000f000 constant MDF1_S_MDF_DFLT4CR_TRGSRC                        \ Digital filter trigger signal selection
$00010000 constant MDF1_S_MDF_DFLT4CR_SNPSFMT                       \ Snapshot data format
$0ff00000 constant MDF1_S_MDF_DFLT4CR_NBDIS                         \ Number of samples to be discarded
$40000000 constant MDF1_S_MDF_DFLT4CR_DFLTRUN                       \ Digital filter run status flag
$80000000 constant MDF1_S_MDF_DFLT4CR_DFLTACTIVE                    \ Digital filter active flag


\
\ @brief MDF digital filter configuration register 4
\ Address offset: 0x28C
\ Reset value: 0x00000000
\

$00000003 constant MDF1_S_MDF_DFLT4CICR_DATSRC                      \ Source data for the digital filter
$00000070 constant MDF1_S_MDF_DFLT4CICR_CICMOD                      \ Select the CIC mode
$0000ff00 constant MDF1_S_MDF_DFLT4CICR_MCICD                       \ CIC decimation ratio selection
$00010000 constant MDF1_S_MDF_DFLT4CICR_MCICD8                      \ CIC decimation ratio selection
$03f00000 constant MDF1_S_MDF_DFLT4CICR_SCALE                       \ Scaling factor selection


\
\ @brief MDF reshape filter configuration register 4
\ Address offset: 0x290
\ Reset value: 0x00000000
\

$00000001 constant MDF1_S_MDF_DFLT4RSFR_RSFLTBYP                    \ Reshaper filter bypass
$00000010 constant MDF1_S_MDF_DFLT4RSFR_RSFLTD                      \ Reshaper filter decimation ratio
$00000080 constant MDF1_S_MDF_DFLT4RSFR_HPFBYP                      \ High-pass filter bypass
$00000300 constant MDF1_S_MDF_DFLT4RSFR_HPFC                        \ High-pass filter cut-off frequency


\
\ @brief MDF integrator configuration register 4
\ Address offset: 0x294
\ Reset value: 0x00000000
\

$00000003 constant MDF1_S_MDF_DFLT4INTR_INTDIV                      \ Integrator output division
$000007f0 constant MDF1_S_MDF_DFLT4INTR_INTVAL                      \ Integration value selection


\
\ @brief MDF out-of limit detector control register 4
\ Address offset: 0x298
\ Reset value: 0x00000000
\

$00000001 constant MDF1_S_MDF_OLD4CR_OLDEN                          \ OLDx enable
$00000002 constant MDF1_S_MDF_OLD4CR_THINB                          \ Threshold In band
$000000f0 constant MDF1_S_MDF_OLD4CR_BKOLD                          \ Break signal assignment for out-of limit detector
$00003000 constant MDF1_S_MDF_OLD4CR_ACICN                          \ OLDx CIC order selection
$003e0000 constant MDF1_S_MDF_OLD4CR_ACICD                          \ OLDx CIC decimation ratio selection
$80000000 constant MDF1_S_MDF_OLD4CR_OLDACTIVE                      \ OLDx active flag


\
\ @brief MDF OLD4 low threshold register 4
\ Address offset: 0x29C
\ Reset value: 0x00000000
\

$03ffffff constant MDF1_S_MDF_OLD4THLR_OLDTHL                       \ OLD low threshold value


\
\ @brief MDF OLD4 high threshold register 4
\ Address offset: 0x2A0
\ Reset value: 0x00000000
\

$03ffffff constant MDF1_S_MDF_OLD4THHR_OLDTHH                       \ OLDx high threshold value


\
\ @brief MDF delay control register 4
\ Address offset: 0x2A4
\ Reset value: 0x00000000
\

$0000007f constant MDF1_S_MDF_DLY4CR_SKPDLY                         \ Delay to apply to a bitstream
$80000000 constant MDF1_S_MDF_DLY4CR_SKPBF                          \ Skip busy flag


\
\ @brief MDF short circuit detector control register 4
\ Address offset: 0x2A8
\ Reset value: 0x00000000
\

$00000001 constant MDF1_S_MDF_SCD4CR_SCDEN                          \ SCDx enable
$000000f0 constant MDF1_S_MDF_SCD4CR_BKSCD                          \ Break signal assignment for short circuit detector
$000ff000 constant MDF1_S_MDF_SCD4CR_SCDT                           \ SCDx threshold
$80000000 constant MDF1_S_MDF_SCD4CR_SCDACTIVE                      \ SCDx active flag


\
\ @brief MDF DFLT4 interrupt enable register 4
\ Address offset: 0x2AC
\ Reset value: 0x00000000
\

$00000001 constant MDF1_S_MDF_DFLT4IER_FTHIE                        \ RXFIFO threshold interrupt enable
$00000002 constant MDF1_S_MDF_DFLT4IER_DOVRIE                       \ Data overflow interrupt enable
$00000004 constant MDF1_S_MDF_DFLT4IER_SSDRIE                       \ Snapshot data ready interrupt enable
$00000010 constant MDF1_S_MDF_DFLT4IER_OLDIE                        \ OLDx interrupt enable
$00000080 constant MDF1_S_MDF_DFLT4IER_SSOVRIE                      \ Snapshot overrun interrupt enable
$00000100 constant MDF1_S_MDF_DFLT4IER_SCDIE                        \ SCDx interrupt enable
$00000200 constant MDF1_S_MDF_DFLT4IER_SATIE                        \ Saturation detection interrupt enable
$00000400 constant MDF1_S_MDF_DFLT4IER_CKABIE                       \ Clock absence detection interrupt enable
$00000800 constant MDF1_S_MDF_DFLT4IER_RFOVRIE                      \ Reshape filter overrun interrupt enable


\
\ @brief MDF DFLT4 interrupt status register 4
\ Address offset: 0x2B0
\ Reset value: 0x00000000
\

$00000001 constant MDF1_S_MDF_DFLT4ISR_FTHF                         \ RXFIFO threshold flag
$00000002 constant MDF1_S_MDF_DFLT4ISR_DOVRF                        \ Data overflow flag
$00000004 constant MDF1_S_MDF_DFLT4ISR_SSDRF                        \ Snapshot data ready flag
$00000008 constant MDF1_S_MDF_DFLT4ISR_RXNEF                        \ RXFIFO not-empty flag
$00000010 constant MDF1_S_MDF_DFLT4ISR_OLDF                         \ OLDx flag
$00000020 constant MDF1_S_MDF_DFLT4ISR_THLF                         \ Low-threshold status flag
$00000040 constant MDF1_S_MDF_DFLT4ISR_THHF                         \ High-threshold status flag
$00000080 constant MDF1_S_MDF_DFLT4ISR_SSOVRF                       \ Snapshot overrun flag
$00000100 constant MDF1_S_MDF_DFLT4ISR_SCDF                         \ Short-circuit detector flag
$00000200 constant MDF1_S_MDF_DFLT4ISR_SATF                         \ Saturation detection flag
$00000400 constant MDF1_S_MDF_DFLT4ISR_CKABF                        \ Clock absence detection flag
$00000800 constant MDF1_S_MDF_DFLT4ISR_RFOVRF                       \ Reshape filter overrun detection flag


\
\ @brief MDF offset error compensation control register 4
\ Address offset: 0x2B4
\ Reset value: 0x00000000
\

$03ffffff constant MDF1_S_MDF_OEC4CR_OFFSET                         \ Offset error compensation


\
\ @brief MDF snapshot data register 4
\ Address offset: 0x2EC
\ Reset value: 0x00000000
\

$000001ff constant MDF1_S_MDF_SNPS4DR_MCICDC                        \ Contains the MCIC decimation counter value when the last trigger event occurs (MCIC_CNT)
$0000fe00 constant MDF1_S_MDF_SNPS4DR_EXTSDR                        \ Extended data size
$ffff0000 constant MDF1_S_MDF_SNPS4DR_SDR                           \ Contains the 16 MSB of the last valid data processed by the digital filter.


\
\ @brief MDF digital filter data register 4
\ Address offset: 0x2F0
\ Reset value: 0x00000000
\

$ffffff00 constant MDF1_S_MDF_DFLT4DR_DR                            \ Data processed by digital filter


\
\ @brief MDF serial interface control register 5
\ Address offset: 0x300
\ Reset value: 0x00001F00
\

$00000001 constant MDF1_S_MDF_SITF5CR_SITFEN                        \ Serial interface enable
$00000006 constant MDF1_S_MDF_SITF5CR_SCKSRC                        \ Serial clock source
$00000030 constant MDF1_S_MDF_SITF5CR_SITFMOD                       \ Serial interface type
$00001f00 constant MDF1_S_MDF_SITF5CR_STH                           \ Manchester symbol threshold/SPI threshold
$80000000 constant MDF1_S_MDF_SITF5CR_SITFACTIVE                    \ Serial interface active flag


\
\ @brief MDF bitstream matrix control register 5
\ Address offset: 0x304
\ Reset value: 0x00000000
\

$0000001f constant MDF1_S_MDF_BSMX5CR_BSSEL                         \ Bitstream Selection
$80000000 constant MDF1_S_MDF_BSMX5CR_BSMXACTIVE                    \ BSMX active flag


\
\ @brief MDF digital filter control register 5
\ Address offset: 0x308
\ Reset value: 0x00000000
\

$00000001 constant MDF1_S_MDF_DFLT5CR_DFLTEN                        \ Digital filter enable
$00000002 constant MDF1_S_MDF_DFLT5CR_DMAEN                         \ DMA requests enable
$00000004 constant MDF1_S_MDF_DFLT5CR_FTH                           \ RXFIFO Threshold selection
$00000070 constant MDF1_S_MDF_DFLT5CR_ACQMOD                        \ Digital filter trigger mode
$00000100 constant MDF1_S_MDF_DFLT5CR_TRGSENS                       \ Digital filter trigger sensitivity selection
$0000f000 constant MDF1_S_MDF_DFLT5CR_TRGSRC                        \ Digital filter trigger signal selection
$00010000 constant MDF1_S_MDF_DFLT5CR_SNPSFMT                       \ Snapshot data format
$0ff00000 constant MDF1_S_MDF_DFLT5CR_NBDIS                         \ Number of samples to be discarded
$40000000 constant MDF1_S_MDF_DFLT5CR_DFLTRUN                       \ Digital filter run status flag
$80000000 constant MDF1_S_MDF_DFLT5CR_DFLTACTIVE                    \ Digital filter active flag


\
\ @brief MDF digital filter configuration register 5
\ Address offset: 0x30C
\ Reset value: 0x00000000
\

$00000003 constant MDF1_S_MDF_DFLT5CICR_DATSRC                      \ Source data for the digital filter
$00000070 constant MDF1_S_MDF_DFLT5CICR_CICMOD                      \ Select the CIC mode
$0000ff00 constant MDF1_S_MDF_DFLT5CICR_MCICD                       \ CIC decimation ratio selection
$00010000 constant MDF1_S_MDF_DFLT5CICR_MCICD8                      \ CIC decimation ratio selection
$03f00000 constant MDF1_S_MDF_DFLT5CICR_SCALE                       \ Scaling factor selection


\
\ @brief MDF reshape filter configuration register 5
\ Address offset: 0x310
\ Reset value: 0x00000000
\

$00000001 constant MDF1_S_MDF_DFLT5RSFR_RSFLTBYP                    \ Reshaper filter bypass
$00000010 constant MDF1_S_MDF_DFLT5RSFR_RSFLTD                      \ Reshaper filter decimation ratio
$00000080 constant MDF1_S_MDF_DFLT5RSFR_HPFBYP                      \ High-pass filter bypass
$00000300 constant MDF1_S_MDF_DFLT5RSFR_HPFC                        \ High-pass filter cut-off frequency


\
\ @brief MDF integrator configuration register 5
\ Address offset: 0x314
\ Reset value: 0x00000000
\

$00000003 constant MDF1_S_MDF_DFLT5INTR_INTDIV                      \ Integrator output division
$000007f0 constant MDF1_S_MDF_DFLT5INTR_INTVAL                      \ Integration value selection


\
\ @brief MDF out-of limit detector control register 5
\ Address offset: 0x318
\ Reset value: 0x00000000
\

$00000001 constant MDF1_S_MDF_OLD5CR_OLDEN                          \ OLDx enable
$00000002 constant MDF1_S_MDF_OLD5CR_THINB                          \ Threshold In band
$000000f0 constant MDF1_S_MDF_OLD5CR_BKOLD                          \ Break signal assignment for out-of limit detector
$00003000 constant MDF1_S_MDF_OLD5CR_ACICN                          \ OLDx CIC order selection
$003e0000 constant MDF1_S_MDF_OLD5CR_ACICD                          \ OLDx CIC decimation ratio selection
$80000000 constant MDF1_S_MDF_OLD5CR_OLDACTIVE                      \ OLDx active flag


\
\ @brief MDF OLD5 low threshold register 5
\ Address offset: 0x31C
\ Reset value: 0x00000000
\

$03ffffff constant MDF1_S_MDF_OLD5THLR_OLDTHL                       \ OLD low threshold value


\
\ @brief MDF OLD5 high threshold register 5
\ Address offset: 0x320
\ Reset value: 0x00000000
\

$03ffffff constant MDF1_S_MDF_OLD5THHR_OLDTHH                       \ OLDx high threshold value


\
\ @brief MDF delay control register 5
\ Address offset: 0x324
\ Reset value: 0x00000000
\

$0000007f constant MDF1_S_MDF_DLY5CR_SKPDLY                         \ Delay to apply to a bitstream
$80000000 constant MDF1_S_MDF_DLY5CR_SKPBF                          \ Skip busy flag


\
\ @brief MDF short circuit detector control register 5
\ Address offset: 0x328
\ Reset value: 0x00000000
\

$00000001 constant MDF1_S_MDF_SCD5CR_SCDEN                          \ SCDx enable
$000000f0 constant MDF1_S_MDF_SCD5CR_BKSCD                          \ Break signal assignment for short circuit detector
$000ff000 constant MDF1_S_MDF_SCD5CR_SCDT                           \ SCDx threshold
$80000000 constant MDF1_S_MDF_SCD5CR_SCDACTIVE                      \ SCDx active flag


\
\ @brief MDF DFLT5 interrupt enable register 5
\ Address offset: 0x32C
\ Reset value: 0x00000000
\

$00000001 constant MDF1_S_MDF_DFLT5IER_FTHIE                        \ RXFIFO threshold interrupt enable
$00000002 constant MDF1_S_MDF_DFLT5IER_DOVRIE                       \ Data overflow interrupt enable
$00000004 constant MDF1_S_MDF_DFLT5IER_SSDRIE                       \ Snapshot data ready interrupt enable
$00000010 constant MDF1_S_MDF_DFLT5IER_OLDIE                        \ OLDx interrupt enable
$00000080 constant MDF1_S_MDF_DFLT5IER_SSOVRIE                      \ Snapshot overrun interrupt enable
$00000100 constant MDF1_S_MDF_DFLT5IER_SCDIE                        \ SCDx interrupt enable
$00000200 constant MDF1_S_MDF_DFLT5IER_SATIE                        \ Saturation detection interrupt enable
$00000400 constant MDF1_S_MDF_DFLT5IER_CKABIE                       \ Clock absence detection interrupt enable
$00000800 constant MDF1_S_MDF_DFLT5IER_RFOVRIE                      \ Reshape filter overrun interrupt enable


\
\ @brief MDF DFLT5 interrupt status register 5
\ Address offset: 0x330
\ Reset value: 0x00000000
\

$00000001 constant MDF1_S_MDF_DFLT5ISR_FTHF                         \ RXFIFO threshold flag
$00000002 constant MDF1_S_MDF_DFLT5ISR_DOVRF                        \ Data overflow flag
$00000004 constant MDF1_S_MDF_DFLT5ISR_SSDRF                        \ Snapshot data ready flag
$00000008 constant MDF1_S_MDF_DFLT5ISR_RXNEF                        \ RXFIFO not-empty flag
$00000010 constant MDF1_S_MDF_DFLT5ISR_OLDF                         \ OLDx flag
$00000020 constant MDF1_S_MDF_DFLT5ISR_THLF                         \ Low-threshold status flag
$00000040 constant MDF1_S_MDF_DFLT5ISR_THHF                         \ High-threshold status flag
$00000080 constant MDF1_S_MDF_DFLT5ISR_SSOVRF                       \ Snapshot overrun flag
$00000100 constant MDF1_S_MDF_DFLT5ISR_SCDF                         \ Short-circuit detector flag
$00000200 constant MDF1_S_MDF_DFLT5ISR_SATF                         \ Saturation detection flag
$00000400 constant MDF1_S_MDF_DFLT5ISR_CKABF                        \ Clock absence detection flag
$00000800 constant MDF1_S_MDF_DFLT5ISR_RFOVRF                       \ Reshape filter overrun detection flag


\
\ @brief MDF offset error compensation control register 5
\ Address offset: 0x334
\ Reset value: 0x00000000
\

$03ffffff constant MDF1_S_MDF_OEC5CR_OFFSET                         \ Offset error compensation


\
\ @brief MDF snapshot data register 5
\ Address offset: 0x36C
\ Reset value: 0x00000000
\

$000001ff constant MDF1_S_MDF_SNPS5DR_MCICDC                        \ Contains the MCIC decimation counter value when the last trigger event occurs (MCIC_CNT)
$0000fe00 constant MDF1_S_MDF_SNPS5DR_EXTSDR                        \ Extended data size
$ffff0000 constant MDF1_S_MDF_SNPS5DR_SDR                           \ Contains the 16 MSB of the last valid data processed by the digital filter.


\
\ @brief MDF digital filter data register 5
\ Address offset: 0x370
\ Reset value: 0x00000000
\

$ffffff00 constant MDF1_S_MDF_DFLT5DR_DR                            \ Data processed by digital filter


\
\ @brief MDF register block
\
$52025000 constant MDF1_S_MDF_GCR  \ offset: 0x00 : MDF global control register
$52025004 constant MDF1_S_MDF_CKGCR  \ offset: 0x04 : MDF clock generator control register
$52025080 constant MDF1_S_MDF_SITF0CR  \ offset: 0x80 : MDF serial interface control register 0
$52025084 constant MDF1_S_MDF_BSMX0CR  \ offset: 0x84 : MDF bitstream matrix control register 0
$52025088 constant MDF1_S_MDF_DFLT0CR  \ offset: 0x88 : MDF digital filter control register 0
$5202508c constant MDF1_S_MDF_DFLT0CICR  \ offset: 0x8C : MDF digital filter configuration register 0
$52025090 constant MDF1_S_MDF_DFLT0RSFR  \ offset: 0x90 : MDF reshape filter configuration register 0
$52025094 constant MDF1_S_MDF_DFLT0INTR  \ offset: 0x94 : MDF integrator configuration register 0
$52025098 constant MDF1_S_MDF_OLD0CR  \ offset: 0x98 : MDF out-of limit detector control register 0
$5202509c constant MDF1_S_MDF_OLD0THLR  \ offset: 0x9C : MDF OLD0 low threshold register 0
$520250a0 constant MDF1_S_MDF_OLD0THHR  \ offset: 0xA0 : MDF OLD0 high threshold register 0
$520250a4 constant MDF1_S_MDF_DLY0CR  \ offset: 0xA4 : MDF delay control register 0
$520250a8 constant MDF1_S_MDF_SCD0CR  \ offset: 0xA8 : MDF short circuit detector control register 0
$520250ac constant MDF1_S_MDF_DFLT0IER  \ offset: 0xAC : MDF DFLT0 interrupt enable register 0
$520250b0 constant MDF1_S_MDF_DFLT0ISR  \ offset: 0xB0 : MDF DFLT0 interrupt status register 0
$520250b4 constant MDF1_S_MDF_OEC0CR  \ offset: 0xB4 : MDF offset error compensation control register 0
$520250ec constant MDF1_S_MDF_SNPS0DR  \ offset: 0xEC : MDF snapshot data register 0
$520250f0 constant MDF1_S_MDF_DFLT0DR  \ offset: 0xF0 : MDF digital filter data register 0
$52025100 constant MDF1_S_MDF_SITF1CR  \ offset: 0x100 : MDF serial interface control register 1
$52025104 constant MDF1_S_MDF_BSMX1CR  \ offset: 0x104 : MDF bitstream matrix control register 1
$52025108 constant MDF1_S_MDF_DFLT1CR  \ offset: 0x108 : MDF digital filter control register 1
$5202510c constant MDF1_S_MDF_DFLT1CICR  \ offset: 0x10C : MDF digital filter configuration register 1
$52025110 constant MDF1_S_MDF_DFLT1RSFR  \ offset: 0x110 : MDF reshape filter configuration register 1
$52025114 constant MDF1_S_MDF_DFLT1INTR  \ offset: 0x114 : MDF integrator configuration register 1
$52025118 constant MDF1_S_MDF_OLD1CR  \ offset: 0x118 : MDF out-of limit detector control register 1
$5202511c constant MDF1_S_MDF_OLD1THLR  \ offset: 0x11C : MDF OLD1 low threshold register 1
$52025120 constant MDF1_S_MDF_OLD1THHR  \ offset: 0x120 : MDF OLD1 high threshold register 1
$52025124 constant MDF1_S_MDF_DLY1CR  \ offset: 0x124 : MDF delay control register 1
$52025128 constant MDF1_S_MDF_SCD1CR  \ offset: 0x128 : MDF short circuit detector control register 1
$5202512c constant MDF1_S_MDF_DFLT1IER  \ offset: 0x12C : MDF DFLT1 interrupt enable register 1
$52025130 constant MDF1_S_MDF_DFLT1ISR  \ offset: 0x130 : MDF DFLT1 interrupt status register 1
$52025134 constant MDF1_S_MDF_OEC1CR  \ offset: 0x134 : MDF offset error compensation control register 1
$5202516c constant MDF1_S_MDF_SNPS1DR  \ offset: 0x16C : MDF snapshot data register 1
$52025170 constant MDF1_S_MDF_DFLT1DR  \ offset: 0x170 : MDF digital filter data register 1
$52025180 constant MDF1_S_MDF_SITF2CR  \ offset: 0x180 : MDF serial interface control register 2
$52025184 constant MDF1_S_MDF_BSMX2CR  \ offset: 0x184 : MDF bitstream matrix control register 2
$52025188 constant MDF1_S_MDF_DFLT2CR  \ offset: 0x188 : MDF digital filter control register 2
$5202518c constant MDF1_S_MDF_DFLT2CICR  \ offset: 0x18C : MDF digital filter configuration register 2
$52025190 constant MDF1_S_MDF_DFLT2RSFR  \ offset: 0x190 : MDF reshape filter configuration register 2
$52025194 constant MDF1_S_MDF_DFLT2INTR  \ offset: 0x194 : MDF integrator configuration register 2
$52025198 constant MDF1_S_MDF_OLD2CR  \ offset: 0x198 : MDF out-of limit detector control register 2
$5202519c constant MDF1_S_MDF_OLD2THLR  \ offset: 0x19C : MDF OLD2 low threshold register 2
$520251a0 constant MDF1_S_MDF_OLD2THHR  \ offset: 0x1A0 : MDF OLD2 high threshold register 2
$520251a4 constant MDF1_S_MDF_DLY2CR  \ offset: 0x1A4 : MDF delay control register 2
$520251a8 constant MDF1_S_MDF_SCD2CR  \ offset: 0x1A8 : MDF short circuit detector control register 2
$520251ac constant MDF1_S_MDF_DFLT2IER  \ offset: 0x1AC : MDF DFLT2 interrupt enable register 2
$520251b0 constant MDF1_S_MDF_DFLT2ISR  \ offset: 0x1B0 : MDF DFLT2 interrupt status register 2
$520251b4 constant MDF1_S_MDF_OEC2CR  \ offset: 0x1B4 : MDF offset error compensation control register 2
$520251ec constant MDF1_S_MDF_SNPS2DR  \ offset: 0x1EC : MDF snapshot data register 2
$520251f0 constant MDF1_S_MDF_DFLT2DR  \ offset: 0x1F0 : MDF digital filter data register 2
$52025200 constant MDF1_S_MDF_SITF3CR  \ offset: 0x200 : MDF serial interface control register 3
$52025204 constant MDF1_S_MDF_BSMX3CR  \ offset: 0x204 : MDF bitstream matrix control register 3
$52025208 constant MDF1_S_MDF_DFLT3CR  \ offset: 0x208 : MDF digital filter control register 3
$5202520c constant MDF1_S_MDF_DFLT3CICR  \ offset: 0x20C : MDF digital filter configuration register 3
$52025210 constant MDF1_S_MDF_DFLT3RSFR  \ offset: 0x210 : MDF reshape filter configuration register 3
$52025214 constant MDF1_S_MDF_DFLT3INTR  \ offset: 0x214 : MDF integrator configuration register 3
$52025218 constant MDF1_S_MDF_OLD3CR  \ offset: 0x218 : MDF out-of limit detector control register 3
$5202521c constant MDF1_S_MDF_OLD3THLR  \ offset: 0x21C : MDF OLD3 low threshold register 3
$52025220 constant MDF1_S_MDF_OLD3THHR  \ offset: 0x220 : MDF OLD3 high threshold register 3
$52025224 constant MDF1_S_MDF_DLY3CR  \ offset: 0x224 : MDF delay control register 3
$52025228 constant MDF1_S_MDF_SCD3CR  \ offset: 0x228 : MDF short circuit detector control register 3
$5202522c constant MDF1_S_MDF_DFLT3IER  \ offset: 0x22C : MDF DFLT3 interrupt enable register 3
$52025230 constant MDF1_S_MDF_DFLT3ISR  \ offset: 0x230 : MDF DFLT3 interrupt status register 3
$52025234 constant MDF1_S_MDF_OEC3CR  \ offset: 0x234 : MDF offset error compensation control register 3
$5202526c constant MDF1_S_MDF_SNPS3DR  \ offset: 0x26C : MDF snapshot data register 3
$52025270 constant MDF1_S_MDF_DFLT3DR  \ offset: 0x270 : MDF digital filter data register 3
$52025280 constant MDF1_S_MDF_SITF4CR  \ offset: 0x280 : MDF serial interface control register 4
$52025284 constant MDF1_S_MDF_BSMX4CR  \ offset: 0x284 : MDF bitstream matrix control register 4
$52025288 constant MDF1_S_MDF_DFLT4CR  \ offset: 0x288 : MDF digital filter control register 4
$5202528c constant MDF1_S_MDF_DFLT4CICR  \ offset: 0x28C : MDF digital filter configuration register 4
$52025290 constant MDF1_S_MDF_DFLT4RSFR  \ offset: 0x290 : MDF reshape filter configuration register 4
$52025294 constant MDF1_S_MDF_DFLT4INTR  \ offset: 0x294 : MDF integrator configuration register 4
$52025298 constant MDF1_S_MDF_OLD4CR  \ offset: 0x298 : MDF out-of limit detector control register 4
$5202529c constant MDF1_S_MDF_OLD4THLR  \ offset: 0x29C : MDF OLD4 low threshold register 4
$520252a0 constant MDF1_S_MDF_OLD4THHR  \ offset: 0x2A0 : MDF OLD4 high threshold register 4
$520252a4 constant MDF1_S_MDF_DLY4CR  \ offset: 0x2A4 : MDF delay control register 4
$520252a8 constant MDF1_S_MDF_SCD4CR  \ offset: 0x2A8 : MDF short circuit detector control register 4
$520252ac constant MDF1_S_MDF_DFLT4IER  \ offset: 0x2AC : MDF DFLT4 interrupt enable register 4
$520252b0 constant MDF1_S_MDF_DFLT4ISR  \ offset: 0x2B0 : MDF DFLT4 interrupt status register 4
$520252b4 constant MDF1_S_MDF_OEC4CR  \ offset: 0x2B4 : MDF offset error compensation control register 4
$520252ec constant MDF1_S_MDF_SNPS4DR  \ offset: 0x2EC : MDF snapshot data register 4
$520252f0 constant MDF1_S_MDF_DFLT4DR  \ offset: 0x2F0 : MDF digital filter data register 4
$52025300 constant MDF1_S_MDF_SITF5CR  \ offset: 0x300 : MDF serial interface control register 5
$52025304 constant MDF1_S_MDF_BSMX5CR  \ offset: 0x304 : MDF bitstream matrix control register 5
$52025308 constant MDF1_S_MDF_DFLT5CR  \ offset: 0x308 : MDF digital filter control register 5
$5202530c constant MDF1_S_MDF_DFLT5CICR  \ offset: 0x30C : MDF digital filter configuration register 5
$52025310 constant MDF1_S_MDF_DFLT5RSFR  \ offset: 0x310 : MDF reshape filter configuration register 5
$52025314 constant MDF1_S_MDF_DFLT5INTR  \ offset: 0x314 : MDF integrator configuration register 5
$52025318 constant MDF1_S_MDF_OLD5CR  \ offset: 0x318 : MDF out-of limit detector control register 5
$5202531c constant MDF1_S_MDF_OLD5THLR  \ offset: 0x31C : MDF OLD5 low threshold register 5
$52025320 constant MDF1_S_MDF_OLD5THHR  \ offset: 0x320 : MDF OLD5 high threshold register 5
$52025324 constant MDF1_S_MDF_DLY5CR  \ offset: 0x324 : MDF delay control register 5
$52025328 constant MDF1_S_MDF_SCD5CR  \ offset: 0x328 : MDF short circuit detector control register 5
$5202532c constant MDF1_S_MDF_DFLT5IER  \ offset: 0x32C : MDF DFLT5 interrupt enable register 5
$52025330 constant MDF1_S_MDF_DFLT5ISR  \ offset: 0x330 : MDF DFLT5 interrupt status register 5
$52025334 constant MDF1_S_MDF_OEC5CR  \ offset: 0x334 : MDF offset error compensation control register 5
$5202536c constant MDF1_S_MDF_SNPS5DR  \ offset: 0x36C : MDF snapshot data register 5
$52025370 constant MDF1_S_MDF_DFLT5DR  \ offset: 0x370 : MDF digital filter data register 5

