\
\ @file eth_dma.fs
\ @brief ETH_DMA
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief DMA mode register
\ Address offset: 0x00
\ Reset value: 0x00008000
\

$00000001 constant ETH_DMA_ETH_DMAMR_SWR                            \ Software Reset
$0000001c constant ETH_DMA_ETH_DMAMR_TAA                            \ TAA
$00000800 constant ETH_DMA_ETH_DMAMR_TXPR                           \ Transmit priority
$00007000 constant ETH_DMA_ETH_DMAMR_PR                             \ Priority ratio
$00030000 constant ETH_DMA_ETH_DMAMR_INTM                           \ Interrupt Mode


\
\ @brief System bus mode register
\ Address offset: 0x04
\ Reset value: 0x00008000
\

$00000001 constant ETH_DMA_ETH_DMASBMR_FB                           \ Fixed Burst Length
$00000002 constant ETH_DMA_ETH_DMASBMR_BLEN4                        \ BLEN4
$00000004 constant ETH_DMA_ETH_DMASBMR_BLEN8                        \ BLEN8
$00000008 constant ETH_DMA_ETH_DMASBMR_BLEN16                       \ BLEN16
$00000010 constant ETH_DMA_ETH_DMASBMR_BLEN32                       \ BLEN32
$00000020 constant ETH_DMA_ETH_DMASBMR_BLEN64                       \ BLEN64
$00000040 constant ETH_DMA_ETH_DMASBMR_BLEN128                      \ BLEN128
$00000080 constant ETH_DMA_ETH_DMASBMR_BLEN256                      \ BLEN256
$00001000 constant ETH_DMA_ETH_DMASBMR_AAL                          \ Address-Aligned Beats
$00002000 constant ETH_DMA_ETH_DMASBMR_ONEKBBE                      \ ONEKBBE
$00030000 constant ETH_DMA_ETH_DMASBMR_RD_OSR_LMT                   \ RD_OSR_LMT
$03000000 constant ETH_DMA_ETH_DMASBMR_WR_OSR_LMT                   \ WR_OSR_LMT
$40000000 constant ETH_DMA_ETH_DMASBMR_LPI_XIT_PKT                  \ LPI_XIT_PKT
$80000000 constant ETH_DMA_ETH_DMASBMR_EN_LPI                       \ EN_LPI


\
\ @brief Interrupt status register
\ Address offset: 0x08
\ Reset value: 0x00008000
\

$00000001 constant ETH_DMA_ETH_DMAISR_DC0IS                         \ DMA Channel Interrupt Status
$00000002 constant ETH_DMA_ETH_DMAISR_DC1IS                         \ DC1IS
$00010000 constant ETH_DMA_ETH_DMAISR_MTLIS                         \ MTL Interrupt Status
$00020000 constant ETH_DMA_ETH_DMAISR_MACIS                         \ MAC Interrupt Status


\
\ @brief Debug status register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000001 constant ETH_DMA_ETH_DMADSR_AXWHSTS                       \ AHB Master Write Channel
$00000002 constant ETH_DMA_ETH_DMADSR_AXRHSTS                       \ AXRHSTS
$00000f00 constant ETH_DMA_ETH_DMADSR_RPS0                          \ RPS0
$0000f000 constant ETH_DMA_ETH_DMADSR_TPS0                          \ TPS0
$000f0000 constant ETH_DMA_ETH_DMADSR_RPS1                          \ RPS1
$00f00000 constant ETH_DMA_ETH_DMADSR_TPS1                          \ TPS1


\
\ @brief AXI4 transmit channel ACE control register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$0000000f constant ETH_DMA_ETH_DMAA4TXACR_TDRC                      \ TDRC
$00000f00 constant ETH_DMA_ETH_DMAA4TXACR_TEC                       \ TEC
$000f0000 constant ETH_DMA_ETH_DMAA4TXACR_THC                       \ THC


\
\ @brief AXI4 receive channel ACE control register
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$0000000f constant ETH_DMA_ETH_DMAA4RXACR_RDWC                      \ RDWC
$00000f00 constant ETH_DMA_ETH_DMAA4RXACR_RPC                       \ RPC
$000f0000 constant ETH_DMA_ETH_DMAA4RXACR_RHC                       \ RHC
$03000000 constant ETH_DMA_ETH_DMAA4RXACR_RDC                       \ RDC


\
\ @brief AXI4 descriptor ACE control register
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$0000000f constant ETH_DMA_ETH_DMAA4DACR_TDWC                       \ TDWC
$00000030 constant ETH_DMA_ETH_DMAA4DACR_TDWD                       \ TDWD
$00000f00 constant ETH_DMA_ETH_DMAA4DACR_RDRC                       \ RDRC
$00070000 constant ETH_DMA_ETH_DMAA4DACR_RDP                        \ RDP
$00700000 constant ETH_DMA_ETH_DMAA4DACR_WRP                        \ WRP


\
\ @brief Channel 0 control register
\ Address offset: 0x100
\ Reset value: 0x00000000
\

$00003fff constant ETH_DMA_ETH_DMAC0CR_MSS                          \ MSS
$00010000 constant ETH_DMA_ETH_DMAC0CR_PBLX8                        \ PBLX8
$001c0000 constant ETH_DMA_ETH_DMAC0CR_DSL                          \ DSL


\
\ @brief Channel 0 transmit control register
\ Address offset: 0x104
\ Reset value: 0x00000000
\

$00000001 constant ETH_DMA_ETH_DMAC0TXCR_ST                         \ ST
$0000000e constant ETH_DMA_ETH_DMAC0TXCR_TCW                        \ TCW
$00000010 constant ETH_DMA_ETH_DMAC0TXCR_OSF                        \ OSF
$00001000 constant ETH_DMA_ETH_DMAC0TXCR_TSE                        \ TSE
$003f0000 constant ETH_DMA_ETH_DMAC0TXCR_TXPBL                      \ TXPBL
$0f000000 constant ETH_DMA_ETH_DMAC0TXCR_TQOS                       \ TQOS


\
\ @brief Channel receive control register
\ Address offset: 0x108
\ Reset value: 0x00008000
\

$00000001 constant ETH_DMA_ETH_DMAC0RXCR_SR                         \ Start or Stop Receive Command
$00007ffe constant ETH_DMA_ETH_DMAC0RXCR_RBSZ                       \ Receive Buffer size
$003f0000 constant ETH_DMA_ETH_DMAC0RXCR_RXPBL                      \ RXPBL
$0f000000 constant ETH_DMA_ETH_DMAC0RXCR_RQOS                       \ RQOS
$80000000 constant ETH_DMA_ETH_DMAC0RXCR_RPF                        \ DMA Rx Channel Packet Flush


\
\ @brief Channel i Tx descriptor list address register
\ Address offset: 0x114
\ Reset value: 0x00000000
\

$fffffff8 constant ETH_DMA_ETH_DMAC0TXDLAR_TDESLA                   \ Start of Transmit List


\
\ @brief Channel Rx descriptor list address register
\ Address offset: 0x11C
\ Reset value: 0x00008000
\

$fffffff8 constant ETH_DMA_ETH_DMAC0RXDLAR_RDESLA                   \ Start of Receive List


\
\ @brief Channel Tx descriptor tail pointer register
\ Address offset: 0x120
\ Reset value: 0x00000000
\

$fffffff8 constant ETH_DMA_ETH_DMAC0TXDTPR_TDT                      \ Transmit Descriptor Tail Pointer


\
\ @brief Channel Rx descriptor tail pointer register
\ Address offset: 0x128
\ Reset value: 0x00000000
\

$fffffff8 constant ETH_DMA_ETH_DMAC0RXDTPR_RDT                      \ Receive Descriptor Tail Pointer


\
\ @brief Channel Tx descriptor ring length register
\ Address offset: 0x12C
\ Reset value: 0x00000000
\

$000003ff constant ETH_DMA_ETH_DMAC0TXRLR_TDRL                      \ Transmit Descriptor Ring Length


\
\ @brief Channel Rx descriptor ring length register
\ Address offset: 0x130
\ Reset value: 0x00008000
\

$000003ff constant ETH_DMA_ETH_DMAC0RXRLR_RDRL                      \ Receive Descriptor Ring Length


\
\ @brief Channel interrupt enable register
\ Address offset: 0x134
\ Reset value: 0x00008000
\

$00000001 constant ETH_DMA_ETH_DMAC0IER_TIE                         \ Transmit Interrupt Enable
$00000002 constant ETH_DMA_ETH_DMAC0IER_TXSE                        \ Transmit Stopped Enable
$00000004 constant ETH_DMA_ETH_DMAC0IER_TBUE                        \ Transmit Buffer Unavailable Enable
$00000040 constant ETH_DMA_ETH_DMAC0IER_RIE                         \ Receive Interrupt Enable
$00000080 constant ETH_DMA_ETH_DMAC0IER_RBUE                        \ Receive Buffer Unavailable Enable
$00000100 constant ETH_DMA_ETH_DMAC0IER_RSE                         \ Receive Stopped Enable
$00000200 constant ETH_DMA_ETH_DMAC0IER_RWTE                        \ Receive Watchdog Timeout Enable
$00000400 constant ETH_DMA_ETH_DMAC0IER_ETIE                        \ Early Transmit Interrupt Enable
$00000800 constant ETH_DMA_ETH_DMAC0IER_ERIE                        \ Early Receive Interrupt Enable
$00001000 constant ETH_DMA_ETH_DMAC0IER_FBEE                        \ Fatal Bus Error Enable
$00002000 constant ETH_DMA_ETH_DMAC0IER_CDEE                        \ Context Descriptor Error Enable
$00004000 constant ETH_DMA_ETH_DMAC0IER_AIE                         \ Abnormal Interrupt Summary Enable
$00008000 constant ETH_DMA_ETH_DMAC0IER_NIE                         \ Normal Interrupt Summary Enable


\
\ @brief Channel Rx interrupt watchdog timer register
\ Address offset: 0x138
\ Reset value: 0x00000000
\

$000000ff constant ETH_DMA_ETH_DMAC0RXIWTR_RWT                      \ Receive Interrupt Watchdog Timer Count


\
\ @brief Channel i slot function control status register
\ Address offset: 0x13C
\ Reset value: 0x00000000
\

$00000001 constant ETH_DMA_ETH_DMAC0SFCSR_ESC                       \ ESC
$00000002 constant ETH_DMA_ETH_DMAC0SFCSR_ASC                       \ ASC
$000f0000 constant ETH_DMA_ETH_DMAC0SFCSR_RSN                       \ RSN


\
\ @brief Channel current application transmit descriptor register
\ Address offset: 0x144
\ Reset value: 0x00000000
\

$00000000 constant ETH_DMA_ETH_DMAC0CATXDR_CURTDESAPTR              \ Application Transmit Descriptor Address Pointer


\
\ @brief Channel 0 current application receive descriptor register
\ Address offset: 0x14C
\ Reset value: 0x00000000
\

$00000000 constant ETH_DMA_ETH_DMAC0CARXDR_CURRDESAPTR              \ Application Transmit Descriptor Address Pointer


\
\ @brief Channel 0 current application transmit buffer register
\ Address offset: 0x154
\ Reset value: 0x00000000
\

$00000000 constant ETH_DMA_ETH_DMAC0CATXBR_CURTBUFAPTR              \ Application Transmit Buffer Address Pointer


\
\ @brief Channel current application receive buffer register
\ Address offset: 0x15C
\ Reset value: 0x00000000
\

$00000000 constant ETH_DMA_ETH_DMAC0CARXBR_CURRBUFAPTR              \ Application Receive Buffer Address Pointer


\
\ @brief Channel status register
\ Address offset: 0x160
\ Reset value: 0x00000000
\

$00000001 constant ETH_DMA_ETH_DMAC0SR_TI                           \ Transmit Interrupt
$00000002 constant ETH_DMA_ETH_DMAC0SR_TPS                          \ Transmit Process Stopped
$00000004 constant ETH_DMA_ETH_DMAC0SR_TBU                          \ Transmit Buffer Unavailable
$00000040 constant ETH_DMA_ETH_DMAC0SR_RI                           \ Receive Interrupt
$00000080 constant ETH_DMA_ETH_DMAC0SR_RBU                          \ Receive Buffer Unavailable
$00000100 constant ETH_DMA_ETH_DMAC0SR_RPS                          \ Receive Process Stopped
$00000200 constant ETH_DMA_ETH_DMAC0SR_RWT                          \ Receive Watchdog Timeout
$00000400 constant ETH_DMA_ETH_DMAC0SR_ETI                          \ Early Transmit Interrupt
$00000800 constant ETH_DMA_ETH_DMAC0SR_ERI                          \ Early Receive Interrupt
$00001000 constant ETH_DMA_ETH_DMAC0SR_FBE                          \ Fatal Bus Error
$00002000 constant ETH_DMA_ETH_DMAC0SR_CDE                          \ Context Descriptor Error
$00004000 constant ETH_DMA_ETH_DMAC0SR_AIS                          \ Abnormal Interrupt Summary
$00008000 constant ETH_DMA_ETH_DMAC0SR_NIS                          \ Normal Interrupt Summary
$00070000 constant ETH_DMA_ETH_DMAC0SR_TEB                          \ Tx DMA Error Bits
$00380000 constant ETH_DMA_ETH_DMAC0SR_REB                          \ Rx DMA Error Bits


\
\ @brief Channel missed frame count register
\ Address offset: 0x16C
\ Reset value: 0x00000000
\

$000007ff constant ETH_DMA_ETH_DMAC0MFCR_MFC                        \ Dropped Packet Counters
$00008000 constant ETH_DMA_ETH_DMAC0MFCR_MFCO                       \ Overflow status of the MFC Counter


\
\ @brief Channel 1 control register
\ Address offset: 0x180
\ Reset value: 0x00000000
\

$00003fff constant ETH_DMA_ETH_DMAC1CR_MSS                          \ MSS
$00010000 constant ETH_DMA_ETH_DMAC1CR_PBLX8                        \ PBLX8
$001c0000 constant ETH_DMA_ETH_DMAC1CR_DSL                          \ DSL


\
\ @brief Channel 1 transmit control register
\ Address offset: 0x184
\ Reset value: 0x00000000
\

$00000001 constant ETH_DMA_ETH_DMAC1TXCR_ST                         \ ST
$0000000e constant ETH_DMA_ETH_DMAC1TXCR_TCW                        \ TCW
$00000010 constant ETH_DMA_ETH_DMAC1TXCR_OSF                        \ OSF
$00001000 constant ETH_DMA_ETH_DMAC1TXCR_TSE                        \ TSE
$003f0000 constant ETH_DMA_ETH_DMAC1TXCR_TXPBL                      \ TXPBL
$0f000000 constant ETH_DMA_ETH_DMAC1TXCR_TQOS                       \ TQOS


\
\ @brief Channel i Tx descriptor list address register
\ Address offset: 0x194
\ Reset value: 0x00000000
\

$fffffff8 constant ETH_DMA_ETH_DMAC1TXDLAR_TDESLA                   \ Start of Transmit List


\
\ @brief Channel Tx descriptor tail pointer register
\ Address offset: 0x1A0
\ Reset value: 0x00000000
\

$fffffff8 constant ETH_DMA_ETH_DMAC1TXDTPR_TDT                      \ Transmit Descriptor Tail Pointer


\
\ @brief Channel Tx descriptor ring length register
\ Address offset: 0x1AC
\ Reset value: 0x00000000
\

$000003ff constant ETH_DMA_ETH_DMAC1TXRLR_TDRL                      \ Transmit Descriptor Ring Length


\
\ @brief Channel interrupt enable register
\ Address offset: 0x1B4
\ Reset value: 0x00008000
\

$00000001 constant ETH_DMA_ETH_DMAC1IER_TIE                         \ Transmit Interrupt Enable
$00000002 constant ETH_DMA_ETH_DMAC1IER_TXSE                        \ Transmit Stopped Enable
$00000004 constant ETH_DMA_ETH_DMAC1IER_TBUE                        \ Transmit Buffer Unavailable Enable
$00000040 constant ETH_DMA_ETH_DMAC1IER_RIE                         \ Receive Interrupt Enable
$00000080 constant ETH_DMA_ETH_DMAC1IER_RBUE                        \ Receive Buffer Unavailable Enable
$00000100 constant ETH_DMA_ETH_DMAC1IER_RSE                         \ Receive Stopped Enable
$00000200 constant ETH_DMA_ETH_DMAC1IER_RWTE                        \ Receive Watchdog Timeout Enable
$00000400 constant ETH_DMA_ETH_DMAC1IER_ETIE                        \ Early Transmit Interrupt Enable
$00000800 constant ETH_DMA_ETH_DMAC1IER_ERIE                        \ Early Receive Interrupt Enable
$00001000 constant ETH_DMA_ETH_DMAC1IER_FBEE                        \ Fatal Bus Error Enable
$00002000 constant ETH_DMA_ETH_DMAC1IER_CDEE                        \ Context Descriptor Error Enable
$00004000 constant ETH_DMA_ETH_DMAC1IER_AIE                         \ Abnormal Interrupt Summary Enable
$00008000 constant ETH_DMA_ETH_DMAC1IER_NIE                         \ Normal Interrupt Summary Enable


\
\ @brief Channel i slot function control status register
\ Address offset: 0x1BC
\ Reset value: 0x00000000
\

$00000001 constant ETH_DMA_ETH_DMAC1SFCSR_ESC                       \ ESC
$00000002 constant ETH_DMA_ETH_DMAC1SFCSR_ASC                       \ ASC
$000f0000 constant ETH_DMA_ETH_DMAC1SFCSR_RSN                       \ RSN


\
\ @brief Channel current application transmit descriptor register
\ Address offset: 0x1C4
\ Reset value: 0x00000000
\

$00000000 constant ETH_DMA_ETH_DMAC1CATXDR_CURTDESAPTR              \ Application Transmit Descriptor Address Pointer


\
\ @brief Channel 0 current application transmit buffer register
\ Address offset: 0x1D4
\ Reset value: 0x00000000
\

$00000000 constant ETH_DMA_ETH_DMAC1CATXBR_CURTBUFAPTR              \ Application Transmit Buffer Address Pointer


\
\ @brief Channel status register
\ Address offset: 0x1E0
\ Reset value: 0x00000000
\

$00000001 constant ETH_DMA_ETH_DMAC1SR_TI                           \ Transmit Interrupt
$00000002 constant ETH_DMA_ETH_DMAC1SR_TPS                          \ Transmit Process Stopped
$00000004 constant ETH_DMA_ETH_DMAC1SR_TBU                          \ Transmit Buffer Unavailable
$00000040 constant ETH_DMA_ETH_DMAC1SR_RI                           \ Receive Interrupt
$00000080 constant ETH_DMA_ETH_DMAC1SR_RBU                          \ Receive Buffer Unavailable
$00000100 constant ETH_DMA_ETH_DMAC1SR_RPS                          \ Receive Process Stopped
$00000200 constant ETH_DMA_ETH_DMAC1SR_RWT                          \ Receive Watchdog Timeout
$00000400 constant ETH_DMA_ETH_DMAC1SR_ETI                          \ Early Transmit Interrupt
$00000800 constant ETH_DMA_ETH_DMAC1SR_ERI                          \ Early Receive Interrupt
$00001000 constant ETH_DMA_ETH_DMAC1SR_FBE                          \ Fatal Bus Error
$00002000 constant ETH_DMA_ETH_DMAC1SR_CDE                          \ Context Descriptor Error
$00004000 constant ETH_DMA_ETH_DMAC1SR_AIS                          \ Abnormal Interrupt Summary
$00008000 constant ETH_DMA_ETH_DMAC1SR_NIS                          \ Normal Interrupt Summary
$00070000 constant ETH_DMA_ETH_DMAC1SR_TEB                          \ Tx DMA Error Bits
$00380000 constant ETH_DMA_ETH_DMAC1SR_REB                          \ Rx DMA Error Bits


\
\ @brief Channel missed frame count register
\ Address offset: 0x1EC
\ Reset value: 0x00000000
\

$000007ff constant ETH_DMA_ETH_DMAC1MFCR_MFC                        \ Dropped Packet Counters
$00008000 constant ETH_DMA_ETH_DMAC1MFCR_MFCO                       \ Overflow status of the MFC Counter


\
\ @brief ETH_DMA
\
$5800b000 constant ETH_DMA_ETH_DMAMR  \ offset: 0x00 : DMA mode register
$5800b004 constant ETH_DMA_ETH_DMASBMR  \ offset: 0x04 : System bus mode register
$5800b008 constant ETH_DMA_ETH_DMAISR  \ offset: 0x08 : Interrupt status register
$5800b00c constant ETH_DMA_ETH_DMADSR  \ offset: 0x0C : Debug status register
$5800b020 constant ETH_DMA_ETH_DMAA4TXACR  \ offset: 0x20 : AXI4 transmit channel ACE control register
$5800b024 constant ETH_DMA_ETH_DMAA4RXACR  \ offset: 0x24 : AXI4 receive channel ACE control register
$5800b028 constant ETH_DMA_ETH_DMAA4DACR  \ offset: 0x28 : AXI4 descriptor ACE control register
$5800b100 constant ETH_DMA_ETH_DMAC0CR  \ offset: 0x100 : Channel 0 control register
$5800b104 constant ETH_DMA_ETH_DMAC0TXCR  \ offset: 0x104 : Channel 0 transmit control register
$5800b108 constant ETH_DMA_ETH_DMAC0RXCR  \ offset: 0x108 : Channel receive control register
$5800b114 constant ETH_DMA_ETH_DMAC0TXDLAR  \ offset: 0x114 : Channel i Tx descriptor list address register
$5800b11c constant ETH_DMA_ETH_DMAC0RXDLAR  \ offset: 0x11C : Channel Rx descriptor list address register
$5800b120 constant ETH_DMA_ETH_DMAC0TXDTPR  \ offset: 0x120 : Channel Tx descriptor tail pointer register
$5800b128 constant ETH_DMA_ETH_DMAC0RXDTPR  \ offset: 0x128 : Channel Rx descriptor tail pointer register
$5800b12c constant ETH_DMA_ETH_DMAC0TXRLR  \ offset: 0x12C : Channel Tx descriptor ring length register
$5800b130 constant ETH_DMA_ETH_DMAC0RXRLR  \ offset: 0x130 : Channel Rx descriptor ring length register
$5800b134 constant ETH_DMA_ETH_DMAC0IER  \ offset: 0x134 : Channel interrupt enable register
$5800b138 constant ETH_DMA_ETH_DMAC0RXIWTR  \ offset: 0x138 : Channel Rx interrupt watchdog timer register
$5800b13c constant ETH_DMA_ETH_DMAC0SFCSR  \ offset: 0x13C : Channel i slot function control status register
$5800b144 constant ETH_DMA_ETH_DMAC0CATXDR  \ offset: 0x144 : Channel current application transmit descriptor register
$5800b14c constant ETH_DMA_ETH_DMAC0CARXDR  \ offset: 0x14C : Channel 0 current application receive descriptor register
$5800b154 constant ETH_DMA_ETH_DMAC0CATXBR  \ offset: 0x154 : Channel 0 current application transmit buffer register
$5800b15c constant ETH_DMA_ETH_DMAC0CARXBR  \ offset: 0x15C : Channel current application receive buffer register
$5800b160 constant ETH_DMA_ETH_DMAC0SR  \ offset: 0x160 : Channel status register
$5800b16c constant ETH_DMA_ETH_DMAC0MFCR  \ offset: 0x16C : Channel missed frame count register
$5800b180 constant ETH_DMA_ETH_DMAC1CR  \ offset: 0x180 : Channel 1 control register
$5800b184 constant ETH_DMA_ETH_DMAC1TXCR  \ offset: 0x184 : Channel 1 transmit control register
$5800b194 constant ETH_DMA_ETH_DMAC1TXDLAR  \ offset: 0x194 : Channel i Tx descriptor list address register
$5800b1a0 constant ETH_DMA_ETH_DMAC1TXDTPR  \ offset: 0x1A0 : Channel Tx descriptor tail pointer register
$5800b1ac constant ETH_DMA_ETH_DMAC1TXRLR  \ offset: 0x1AC : Channel Tx descriptor ring length register
$5800b1b4 constant ETH_DMA_ETH_DMAC1IER  \ offset: 0x1B4 : Channel interrupt enable register
$5800b1bc constant ETH_DMA_ETH_DMAC1SFCSR  \ offset: 0x1BC : Channel i slot function control status register
$5800b1c4 constant ETH_DMA_ETH_DMAC1CATXDR  \ offset: 0x1C4 : Channel current application transmit descriptor register
$5800b1d4 constant ETH_DMA_ETH_DMAC1CATXBR  \ offset: 0x1D4 : Channel 0 current application transmit buffer register
$5800b1e0 constant ETH_DMA_ETH_DMAC1SR  \ offset: 0x1E0 : Channel status register
$5800b1ec constant ETH_DMA_ETH_DMAC1MFCR  \ offset: 0x1EC : Channel missed frame count register

