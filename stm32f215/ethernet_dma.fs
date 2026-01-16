\
\ @file ethernet_dma.fs
\ @brief Ethernet: DMA controller operation
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief Ethernet DMA bus mode register
\ Address offset: 0x00
\ Reset value: 0x00020101
\

$00000001 constant ETHERNET_DMA_DMABMR_SR                           \ Software reset
$00000002 constant ETHERNET_DMA_DMABMR_DA                           \ DMA Arbitration
$0000007c constant ETHERNET_DMA_DMABMR_DSL                          \ Descriptor skip length
$00000080 constant ETHERNET_DMA_DMABMR_EDFE                         \ Enhanced descriptor format enable
$00003f00 constant ETHERNET_DMA_DMABMR_PBL                          \ Programmable burst length
$0000c000 constant ETHERNET_DMA_DMABMR_RTPR                         \ Rx Tx priority ratio
$00010000 constant ETHERNET_DMA_DMABMR_FB                           \ Fixed burst
$007e0000 constant ETHERNET_DMA_DMABMR_RDP                          \ Rx DMA PBL
$00800000 constant ETHERNET_DMA_DMABMR_USP                          \ Use separate PBL
$01000000 constant ETHERNET_DMA_DMABMR_FPM                          \ 4xPBL mode
$02000000 constant ETHERNET_DMA_DMABMR_AAB                          \ Address-aligned beats
$04000000 constant ETHERNET_DMA_DMABMR_MB                           \ Mixed burst


\
\ @brief Ethernet DMA transmit poll demand register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000000 constant ETHERNET_DMA_DMATPDR_TPD                         \ Transmit poll demand


\
\ @brief EHERNET DMA receive poll demand register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000000 constant ETHERNET_DMA_DMARPDR_RPD                         \ Receive poll demand


\
\ @brief Ethernet DMA receive descriptor list address register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000000 constant ETHERNET_DMA_DMARDLAR_SRL                        \ Start of receive list


\
\ @brief Ethernet DMA transmit descriptor list address register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000000 constant ETHERNET_DMA_DMATDLAR_STL                        \ Start of transmit list


\
\ @brief Ethernet DMA status register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000001 constant ETHERNET_DMA_DMASR_TS                            \ Transmit status
$00000002 constant ETHERNET_DMA_DMASR_TPSS                          \ Transmit process stopped status
$00000004 constant ETHERNET_DMA_DMASR_TBUS                          \ Transmit buffer unavailable status
$00000008 constant ETHERNET_DMA_DMASR_TJTS                          \ Transmit jabber timeout status
$00000010 constant ETHERNET_DMA_DMASR_ROS                           \ Receive overflow status
$00000020 constant ETHERNET_DMA_DMASR_TUS                           \ Transmit underflow status
$00000040 constant ETHERNET_DMA_DMASR_RS                            \ Receive status
$00000080 constant ETHERNET_DMA_DMASR_RBUS                          \ Receive buffer unavailable status
$00000100 constant ETHERNET_DMA_DMASR_RPSS                          \ Receive process stopped status
$00000200 constant ETHERNET_DMA_DMASR_PWTS                          \ Receive watchdog timeout status
$00000400 constant ETHERNET_DMA_DMASR_ETS                           \ Early transmit status
$00002000 constant ETHERNET_DMA_DMASR_FBES                          \ Fatal bus error status
$00004000 constant ETHERNET_DMA_DMASR_ERS                           \ Early receive status
$00008000 constant ETHERNET_DMA_DMASR_AIS                           \ Abnormal interrupt summary
$00010000 constant ETHERNET_DMA_DMASR_NIS                           \ Normal interrupt summary
$000e0000 constant ETHERNET_DMA_DMASR_RPS                           \ Receive process state
$00700000 constant ETHERNET_DMA_DMASR_TPS                           \ Transmit process state
$03800000 constant ETHERNET_DMA_DMASR_EBS                           \ Error bits status
$08000000 constant ETHERNET_DMA_DMASR_MMCS                          \ MMC status
$10000000 constant ETHERNET_DMA_DMASR_PMTS                          \ PMT status
$20000000 constant ETHERNET_DMA_DMASR_TSTS                          \ Time stamp trigger status


\
\ @brief Ethernet DMA operation mode register
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000002 constant ETHERNET_DMA_DMAOMR_SR                           \ SR
$00000004 constant ETHERNET_DMA_DMAOMR_OSF                          \ OSF
$00000018 constant ETHERNET_DMA_DMAOMR_RTC                          \ RTC
$00000040 constant ETHERNET_DMA_DMAOMR_FUGF                         \ FUGF
$00000080 constant ETHERNET_DMA_DMAOMR_FEF                          \ FEF
$00002000 constant ETHERNET_DMA_DMAOMR_ST                           \ ST
$0001c000 constant ETHERNET_DMA_DMAOMR_TTC                          \ TTC
$00100000 constant ETHERNET_DMA_DMAOMR_FTF                          \ FTF
$00200000 constant ETHERNET_DMA_DMAOMR_TSF                          \ TSF
$01000000 constant ETHERNET_DMA_DMAOMR_DFRF                         \ DFRF
$02000000 constant ETHERNET_DMA_DMAOMR_RSF                          \ RSF
$04000000 constant ETHERNET_DMA_DMAOMR_DTCEFD                       \ DTCEFD


\
\ @brief Ethernet DMA interrupt enable register
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$00000001 constant ETHERNET_DMA_DMAIER_TIE                          \ Transmit interrupt enable
$00000002 constant ETHERNET_DMA_DMAIER_TPSIE                        \ Transmit process stopped interrupt enable
$00000004 constant ETHERNET_DMA_DMAIER_TBUIE                        \ Transmit buffer unavailable interrupt enable
$00000008 constant ETHERNET_DMA_DMAIER_TJTIE                        \ Transmit jabber timeout interrupt enable
$00000010 constant ETHERNET_DMA_DMAIER_ROIE                         \ Overflow interrupt enable
$00000020 constant ETHERNET_DMA_DMAIER_TUIE                         \ Underflow interrupt enable
$00000040 constant ETHERNET_DMA_DMAIER_RIE                          \ Receive interrupt enable
$00000080 constant ETHERNET_DMA_DMAIER_RBUIE                        \ Receive buffer unavailable interrupt enable
$00000100 constant ETHERNET_DMA_DMAIER_RPSIE                        \ Receive process stopped interrupt enable
$00000200 constant ETHERNET_DMA_DMAIER_RWTIE                        \ receive watchdog timeout interrupt enable
$00000400 constant ETHERNET_DMA_DMAIER_ETIE                         \ Early transmit interrupt enable
$00002000 constant ETHERNET_DMA_DMAIER_FBEIE                        \ Fatal bus error interrupt enable
$00004000 constant ETHERNET_DMA_DMAIER_ERIE                         \ Early receive interrupt enable
$00008000 constant ETHERNET_DMA_DMAIER_AISE                         \ Abnormal interrupt summary enable
$00010000 constant ETHERNET_DMA_DMAIER_NISE                         \ Normal interrupt summary enable


\
\ @brief Ethernet DMA missed frame and buffer overflow counter register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$0000ffff constant ETHERNET_DMA_DMAMFBOCR_MFC                       \ Missed frames by the controller
$00010000 constant ETHERNET_DMA_DMAMFBOCR_OMFC                      \ Overflow bit for missed frame counter
$0ffe0000 constant ETHERNET_DMA_DMAMFBOCR_MFA                       \ Missed frames by the application
$10000000 constant ETHERNET_DMA_DMAMFBOCR_OFOC                      \ Overflow bit for FIFO overflow counter


\
\ @brief Ethernet DMA receive status watchdog timer register
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$000000ff constant ETHERNET_DMA_DMARSWTR_RSWTC                      \ Receive status watchdog timer count


\
\ @brief Ethernet DMA current host transmit descriptor register
\ Address offset: 0x48
\ Reset value: 0x00000000
\

$00000000 constant ETHERNET_DMA_DMACHTDR_HTDAP                      \ Host transmit descriptor address pointer


\
\ @brief Ethernet DMA current host receive descriptor register
\ Address offset: 0x4C
\ Reset value: 0x00000000
\

$00000000 constant ETHERNET_DMA_DMACHRDR_HRDAP                      \ Host receive descriptor address pointer


\
\ @brief Ethernet DMA current host transmit buffer address register
\ Address offset: 0x50
\ Reset value: 0x00000000
\

$00000000 constant ETHERNET_DMA_DMACHTBAR_HTBAP                     \ Host transmit buffer address pointer


\
\ @brief Ethernet DMA current host receive buffer address register
\ Address offset: 0x54
\ Reset value: 0x00000000
\

$00000000 constant ETHERNET_DMA_DMACHRBAR_HRBAP                     \ Host receive buffer address pointer


\
\ @brief Ethernet: DMA controller operation
\
$40029000 constant ETHERNET_DMA_DMABMR  \ offset: 0x00 : Ethernet DMA bus mode register
$40029004 constant ETHERNET_DMA_DMATPDR  \ offset: 0x04 : Ethernet DMA transmit poll demand register
$40029008 constant ETHERNET_DMA_DMARPDR  \ offset: 0x08 : EHERNET DMA receive poll demand register
$4002900c constant ETHERNET_DMA_DMARDLAR  \ offset: 0x0C : Ethernet DMA receive descriptor list address register
$40029010 constant ETHERNET_DMA_DMATDLAR  \ offset: 0x10 : Ethernet DMA transmit descriptor list address register
$40029014 constant ETHERNET_DMA_DMASR  \ offset: 0x14 : Ethernet DMA status register
$40029018 constant ETHERNET_DMA_DMAOMR  \ offset: 0x18 : Ethernet DMA operation mode register
$4002901c constant ETHERNET_DMA_DMAIER  \ offset: 0x1C : Ethernet DMA interrupt enable register
$40029020 constant ETHERNET_DMA_DMAMFBOCR  \ offset: 0x20 : Ethernet DMA missed frame and buffer overflow counter register
$40029024 constant ETHERNET_DMA_DMARSWTR  \ offset: 0x24 : Ethernet DMA receive status watchdog timer register
$40029048 constant ETHERNET_DMA_DMACHTDR  \ offset: 0x48 : Ethernet DMA current host transmit descriptor register
$4002904c constant ETHERNET_DMA_DMACHRDR  \ offset: 0x4C : Ethernet DMA current host receive descriptor register
$40029050 constant ETHERNET_DMA_DMACHTBAR  \ offset: 0x50 : Ethernet DMA current host transmit buffer address register
$40029054 constant ETHERNET_DMA_DMACHRBAR  \ offset: 0x54 : Ethernet DMA current host receive buffer address register

