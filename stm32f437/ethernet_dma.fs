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
\ Reset value: 0x00002101
\

$00000001 constant ETHERNET_DMA_DMABMR_SR                           \ SR
$00000002 constant ETHERNET_DMA_DMABMR_DA                           \ DA
$0000007c constant ETHERNET_DMA_DMABMR_DSL                          \ DSL
$00000080 constant ETHERNET_DMA_DMABMR_EDFE                         \ EDFE
$00003f00 constant ETHERNET_DMA_DMABMR_PBL                          \ PBL
$0000c000 constant ETHERNET_DMA_DMABMR_RTPR                         \ RTPR
$00010000 constant ETHERNET_DMA_DMABMR_FB                           \ FB
$007e0000 constant ETHERNET_DMA_DMABMR_RDP                          \ RDP
$00800000 constant ETHERNET_DMA_DMABMR_USP                          \ USP
$01000000 constant ETHERNET_DMA_DMABMR_FPM                          \ FPM
$02000000 constant ETHERNET_DMA_DMABMR_AAB                          \ AAB
$04000000 constant ETHERNET_DMA_DMABMR_MB                           \ MB


\
\ @brief Ethernet DMA transmit poll demand register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000000 constant ETHERNET_DMA_DMATPDR_TPD                         \ TPD


\
\ @brief EHERNET DMA receive poll demand register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000000 constant ETHERNET_DMA_DMARPDR_RPD                         \ RPD


\
\ @brief Ethernet DMA receive descriptor list address register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000000 constant ETHERNET_DMA_DMARDLAR_SRL                        \ SRL


\
\ @brief Ethernet DMA transmit descriptor list address register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000000 constant ETHERNET_DMA_DMATDLAR_STL                        \ STL


\
\ @brief Ethernet DMA status register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000001 constant ETHERNET_DMA_DMASR_TS                            \ TS
$00000002 constant ETHERNET_DMA_DMASR_TPSS                          \ TPSS
$00000004 constant ETHERNET_DMA_DMASR_TBUS                          \ TPSS
$00000008 constant ETHERNET_DMA_DMASR_TJTS                          \ TJTS
$00000010 constant ETHERNET_DMA_DMASR_ROS                           \ ROS
$00000020 constant ETHERNET_DMA_DMASR_TUS                           \ TUS
$00000040 constant ETHERNET_DMA_DMASR_RS                            \ RS
$00000080 constant ETHERNET_DMA_DMASR_RBUS                          \ RBUS
$00000100 constant ETHERNET_DMA_DMASR_RPSS                          \ RPSS
$00000200 constant ETHERNET_DMA_DMASR_PWTS                          \ PWTS
$00000400 constant ETHERNET_DMA_DMASR_ETS                           \ ETS
$00002000 constant ETHERNET_DMA_DMASR_FBES                          \ FBES
$00004000 constant ETHERNET_DMA_DMASR_ERS                           \ ERS
$00008000 constant ETHERNET_DMA_DMASR_AIS                           \ AIS
$00010000 constant ETHERNET_DMA_DMASR_NIS                           \ NIS
$000e0000 constant ETHERNET_DMA_DMASR_RPS                           \ RPS
$00700000 constant ETHERNET_DMA_DMASR_TPS                           \ TPS
$03800000 constant ETHERNET_DMA_DMASR_EBS                           \ EBS
$08000000 constant ETHERNET_DMA_DMASR_MMCS                          \ MMCS
$10000000 constant ETHERNET_DMA_DMASR_PMTS                          \ PMTS
$20000000 constant ETHERNET_DMA_DMASR_TSTS                          \ TSTS


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

$00000001 constant ETHERNET_DMA_DMAIER_TIE                          \ TIE
$00000002 constant ETHERNET_DMA_DMAIER_TPSIE                        \ TPSIE
$00000004 constant ETHERNET_DMA_DMAIER_TBUIE                        \ TBUIE
$00000008 constant ETHERNET_DMA_DMAIER_TJTIE                        \ TJTIE
$00000010 constant ETHERNET_DMA_DMAIER_ROIE                         \ ROIE
$00000020 constant ETHERNET_DMA_DMAIER_TUIE                         \ TUIE
$00000040 constant ETHERNET_DMA_DMAIER_RIE                          \ RIE
$00000080 constant ETHERNET_DMA_DMAIER_RBUIE                        \ RBUIE
$00000100 constant ETHERNET_DMA_DMAIER_RPSIE                        \ RPSIE
$00000200 constant ETHERNET_DMA_DMAIER_RWTIE                        \ RWTIE
$00000400 constant ETHERNET_DMA_DMAIER_ETIE                         \ ETIE
$00002000 constant ETHERNET_DMA_DMAIER_FBEIE                        \ FBEIE
$00004000 constant ETHERNET_DMA_DMAIER_ERIE                         \ ERIE
$00008000 constant ETHERNET_DMA_DMAIER_AISE                         \ AISE
$00010000 constant ETHERNET_DMA_DMAIER_NISE                         \ NISE


\
\ @brief Ethernet DMA missed frame and buffer overflow counter register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$0000ffff constant ETHERNET_DMA_DMAMFBOCR_MFC                       \ MFC
$00010000 constant ETHERNET_DMA_DMAMFBOCR_OMFC                      \ OMFC
$0ffe0000 constant ETHERNET_DMA_DMAMFBOCR_MFA                       \ MFA
$10000000 constant ETHERNET_DMA_DMAMFBOCR_OFOC                      \ OFOC


\
\ @brief Ethernet DMA receive status watchdog timer register
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$000000ff constant ETHERNET_DMA_DMARSWTR_RSWTC                      \ RSWTC


\
\ @brief Ethernet DMA current host transmit descriptor register
\ Address offset: 0x48
\ Reset value: 0x00000000
\

$00000000 constant ETHERNET_DMA_DMACHTDR_HTDAP                      \ HTDAP


\
\ @brief Ethernet DMA current host receive descriptor register
\ Address offset: 0x4C
\ Reset value: 0x00000000
\

$00000000 constant ETHERNET_DMA_DMACHRDR_HRDAP                      \ HRDAP


\
\ @brief Ethernet DMA current host transmit buffer address register
\ Address offset: 0x50
\ Reset value: 0x00000000
\

$00000000 constant ETHERNET_DMA_DMACHTBAR_HTBAP                     \ HTBAP


\
\ @brief Ethernet DMA current host receive buffer address register
\ Address offset: 0x54
\ Reset value: 0x00000000
\

$00000000 constant ETHERNET_DMA_DMACHRBAR_HRBAP                     \ HRBAP


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

