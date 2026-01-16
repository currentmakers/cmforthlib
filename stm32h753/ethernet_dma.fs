\
\ @file ethernet_dma.fs
\ @brief Ethernet: DMA mode register (DMA)
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief DMA mode register
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000001 constant ETHERNET_DMA_DMAMR_SWR                           \ Software Reset
$00000002 constant ETHERNET_DMA_DMAMR_DA                            \ DMA Tx or Rx Arbitration Scheme
$00000800 constant ETHERNET_DMA_DMAMR_TXPR                          \ Transmit priority
$00007000 constant ETHERNET_DMA_DMAMR_PR                            \ Priority ratio
$00010000 constant ETHERNET_DMA_DMAMR_INTM                          \ Interrupt Mode


\
\ @brief System bus mode register
\ Address offset: 0x04
\ Reset value: 0x01010000
\

$00000001 constant ETHERNET_DMA_DMASBMR_FB                          \ Fixed Burst Length
$00001000 constant ETHERNET_DMA_DMASBMR_AAL                         \ Address-Aligned Beats
$00004000 constant ETHERNET_DMA_DMASBMR_MB                          \ Mixed Burst
$00008000 constant ETHERNET_DMA_DMASBMR_RB                          \ Rebuild INCRx Burst


\
\ @brief Interrupt status register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000001 constant ETHERNET_DMA_DMAISR_DC0IS                        \ DMA Channel Interrupt Status
$00010000 constant ETHERNET_DMA_DMAISR_MTLIS                        \ MTL Interrupt Status
$00020000 constant ETHERNET_DMA_DMAISR_MACIS                        \ MAC Interrupt Status


\
\ @brief Debug status register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000001 constant ETHERNET_DMA_DMADSR_AXWHSTS                      \ AHB Master Write Channel
$00000f00 constant ETHERNET_DMA_DMADSR_RPS0                         \ DMA Channel Receive Process State
$0000f000 constant ETHERNET_DMA_DMADSR_TPS0                         \ DMA Channel Transmit Process State


\
\ @brief Channel control register
\ Address offset: 0x100
\ Reset value: 0x00000000
\

$00003fff constant ETHERNET_DMA_DMACCR_MSS                          \ Maximum Segment Size
$00010000 constant ETHERNET_DMA_DMACCR_PBLX8                        \ 8xPBL mode
$001c0000 constant ETHERNET_DMA_DMACCR_DSL                          \ Descriptor Skip Length


\
\ @brief Channel transmit control register
\ Address offset: 0x104
\ Reset value: 0x00000000
\

$00000001 constant ETHERNET_DMA_DMACTXCR_ST                         \ Start or Stop Transmission Command
$00000010 constant ETHERNET_DMA_DMACTXCR_OSF                        \ Operate on Second Packet
$00001000 constant ETHERNET_DMA_DMACTXCR_TSE                        \ TCP Segmentation Enabled
$003f0000 constant ETHERNET_DMA_DMACTXCR_TXPBL                      \ Transmit Programmable Burst Length


\
\ @brief Channel receive control register
\ Address offset: 0x108
\ Reset value: 0x00000000
\

$00000001 constant ETHERNET_DMA_DMACRXCR_SR                         \ Start or Stop Receive Command
$00007ffe constant ETHERNET_DMA_DMACRXCR_RBSZ                       \ Receive Buffer size
$003f0000 constant ETHERNET_DMA_DMACRXCR_RXPBL                      \ RXPBL
$80000000 constant ETHERNET_DMA_DMACRXCR_RPF                        \ DMA Rx Channel Packet Flush


\
\ @brief Channel Tx descriptor list address register
\ Address offset: 0x114
\ Reset value: 0x00000000
\

$fffffffc constant ETHERNET_DMA_DMACTXDLAR_TDESLA                   \ Start of Transmit List


\
\ @brief Channel Rx descriptor list address register
\ Address offset: 0x11C
\ Reset value: 0x00000000
\

$fffffffc constant ETHERNET_DMA_DMACRXDLAR_RDESLA                   \ Start of Receive List


\
\ @brief Channel Tx descriptor tail pointer register
\ Address offset: 0x120
\ Reset value: 0x00000000
\

$fffffffc constant ETHERNET_DMA_DMACTXDTPR_TDT                      \ Transmit Descriptor Tail Pointer


\
\ @brief Channel Rx descriptor tail pointer register
\ Address offset: 0x128
\ Reset value: 0x00000000
\

$fffffffc constant ETHERNET_DMA_DMACRXDTPR_RDT                      \ Receive Descriptor Tail Pointer


\
\ @brief Channel Tx descriptor ring length register
\ Address offset: 0x12C
\ Reset value: 0x00000000
\

$000003ff constant ETHERNET_DMA_DMACTXRLR_TDRL                      \ Transmit Descriptor Ring Length


\
\ @brief Channel Rx descriptor ring length register
\ Address offset: 0x130
\ Reset value: 0x00000000
\

$000003ff constant ETHERNET_DMA_DMACRXRLR_RDRL                      \ Receive Descriptor Ring Length


\
\ @brief Channel interrupt enable register
\ Address offset: 0x134
\ Reset value: 0x00000000
\

$00000001 constant ETHERNET_DMA_DMACIER_TIE                         \ Transmit Interrupt Enable
$00000002 constant ETHERNET_DMA_DMACIER_TXSE                        \ Transmit Stopped Enable
$00000004 constant ETHERNET_DMA_DMACIER_TBUE                        \ Transmit Buffer Unavailable Enable
$00000040 constant ETHERNET_DMA_DMACIER_RIE                         \ Receive Interrupt Enable
$00000080 constant ETHERNET_DMA_DMACIER_RBUE                        \ Receive Buffer Unavailable Enable
$00000100 constant ETHERNET_DMA_DMACIER_RSE                         \ Receive Stopped Enable
$00000200 constant ETHERNET_DMA_DMACIER_RWTE                        \ Receive Watchdog Timeout Enable
$00000400 constant ETHERNET_DMA_DMACIER_ETIE                        \ Early Transmit Interrupt Enable
$00000800 constant ETHERNET_DMA_DMACIER_ERIE                        \ Early Receive Interrupt Enable
$00001000 constant ETHERNET_DMA_DMACIER_FBEE                        \ Fatal Bus Error Enable
$00002000 constant ETHERNET_DMA_DMACIER_CDEE                        \ Context Descriptor Error Enable
$00004000 constant ETHERNET_DMA_DMACIER_AIE                         \ Abnormal Interrupt Summary Enable
$00008000 constant ETHERNET_DMA_DMACIER_NIE                         \ Normal Interrupt Summary Enable


\
\ @brief Channel Rx interrupt watchdog timer register
\ Address offset: 0x138
\ Reset value: 0x00000000
\

$000000ff constant ETHERNET_DMA_DMACRXIWTR_RWT                      \ Receive Interrupt Watchdog Timer Count


\
\ @brief Channel current application transmit descriptor register
\ Address offset: 0x144
\ Reset value: 0x00000000
\

$00000000 constant ETHERNET_DMA_DMACCATXDR_CURTDESAPTR              \ Application Transmit Descriptor Address Pointer


\
\ @brief Channel current application receive descriptor register
\ Address offset: 0x14C
\ Reset value: 0x00000000
\

$00000000 constant ETHERNET_DMA_DMACCARXDR_CURRDESAPTR              \ Application Receive Descriptor Address Pointer


\
\ @brief Channel current application transmit buffer register
\ Address offset: 0x154
\ Reset value: 0x00000000
\

$00000000 constant ETHERNET_DMA_DMACCATXBR_CURTBUFAPTR              \ Application Transmit Buffer Address Pointer


\
\ @brief Channel current application receive buffer register
\ Address offset: 0x15C
\ Reset value: 0x00000000
\

$00000000 constant ETHERNET_DMA_DMACCARXBR_CURRBUFAPTR              \ Application Receive Buffer Address Pointer


\
\ @brief Channel status register
\ Address offset: 0x160
\ Reset value: 0x00000000
\

$00000001 constant ETHERNET_DMA_DMACSR_TI                           \ Transmit Interrupt
$00000002 constant ETHERNET_DMA_DMACSR_TPS                          \ Transmit Process Stopped
$00000004 constant ETHERNET_DMA_DMACSR_TBU                          \ Transmit Buffer Unavailable
$00000040 constant ETHERNET_DMA_DMACSR_RI                           \ Receive Interrupt
$00000080 constant ETHERNET_DMA_DMACSR_RBU                          \ Receive Buffer Unavailable
$00000100 constant ETHERNET_DMA_DMACSR_RPS                          \ Receive Process Stopped
$00000200 constant ETHERNET_DMA_DMACSR_RWT                          \ Receive Watchdog Timeout
$00000400 constant ETHERNET_DMA_DMACSR_ET                           \ Early Transmit Interrupt
$00000800 constant ETHERNET_DMA_DMACSR_ER                           \ Early Receive Interrupt
$00001000 constant ETHERNET_DMA_DMACSR_FBE                          \ Fatal Bus Error
$00002000 constant ETHERNET_DMA_DMACSR_CDE                          \ Context Descriptor Error
$00004000 constant ETHERNET_DMA_DMACSR_AIS                          \ Abnormal Interrupt Summary
$00008000 constant ETHERNET_DMA_DMACSR_NIS                          \ Normal Interrupt Summary
$00070000 constant ETHERNET_DMA_DMACSR_TEB                          \ Tx DMA Error Bits
$00380000 constant ETHERNET_DMA_DMACSR_REB                          \ Rx DMA Error Bits


\
\ @brief Channel missed frame count register
\ Address offset: 0x16C
\ Reset value: 0x00000000
\

$000007ff constant ETHERNET_DMA_DMACMFCR_MFC                        \ Dropped Packet Counters
$00008000 constant ETHERNET_DMA_DMACMFCR_MFCO                       \ Overflow status of the MFC Counter


\
\ @brief Ethernet: DMA mode register (DMA)
\
$40029000 constant ETHERNET_DMA_DMAMR  \ offset: 0x00 : DMA mode register
$40029004 constant ETHERNET_DMA_DMASBMR  \ offset: 0x04 : System bus mode register
$40029008 constant ETHERNET_DMA_DMAISR  \ offset: 0x08 : Interrupt status register
$4002900c constant ETHERNET_DMA_DMADSR  \ offset: 0x0C : Debug status register
$40029100 constant ETHERNET_DMA_DMACCR  \ offset: 0x100 : Channel control register
$40029104 constant ETHERNET_DMA_DMACTXCR  \ offset: 0x104 : Channel transmit control register
$40029108 constant ETHERNET_DMA_DMACRXCR  \ offset: 0x108 : Channel receive control register
$40029114 constant ETHERNET_DMA_DMACTXDLAR  \ offset: 0x114 : Channel Tx descriptor list address register
$4002911c constant ETHERNET_DMA_DMACRXDLAR  \ offset: 0x11C : Channel Rx descriptor list address register
$40029120 constant ETHERNET_DMA_DMACTXDTPR  \ offset: 0x120 : Channel Tx descriptor tail pointer register
$40029128 constant ETHERNET_DMA_DMACRXDTPR  \ offset: 0x128 : Channel Rx descriptor tail pointer register
$4002912c constant ETHERNET_DMA_DMACTXRLR  \ offset: 0x12C : Channel Tx descriptor ring length register
$40029130 constant ETHERNET_DMA_DMACRXRLR  \ offset: 0x130 : Channel Rx descriptor ring length register
$40029134 constant ETHERNET_DMA_DMACIER  \ offset: 0x134 : Channel interrupt enable register
$40029138 constant ETHERNET_DMA_DMACRXIWTR  \ offset: 0x138 : Channel Rx interrupt watchdog timer register
$40029144 constant ETHERNET_DMA_DMACCATXDR  \ offset: 0x144 : Channel current application transmit descriptor register
$4002914c constant ETHERNET_DMA_DMACCARXDR  \ offset: 0x14C : Channel current application receive descriptor register
$40029154 constant ETHERNET_DMA_DMACCATXBR  \ offset: 0x154 : Channel current application transmit buffer register
$4002915c constant ETHERNET_DMA_DMACCARXBR  \ offset: 0x15C : Channel current application receive buffer register
$40029160 constant ETHERNET_DMA_DMACSR  \ offset: 0x160 : Channel status register
$4002916c constant ETHERNET_DMA_DMACMFCR  \ offset: 0x16C : Channel missed frame count register

