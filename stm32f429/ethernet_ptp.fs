\
\ @file ethernet_ptp.fs
\ @brief Ethernet: Precision time protocol
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief Ethernet PTP time stamp control register
\ Address offset: 0x00
\ Reset value: 0x00002000
\

$00000001 constant ETHERNET_PTP_PTPTSCR_TSE                         \ TSE
$00000002 constant ETHERNET_PTP_PTPTSCR_TSFCU                       \ TSFCU
$00000004 constant ETHERNET_PTP_PTPTSCR_TSSTI                       \ TSSTI
$00000008 constant ETHERNET_PTP_PTPTSCR_TSSTU                       \ TSSTU
$00000010 constant ETHERNET_PTP_PTPTSCR_TSITE                       \ TSITE
$00000020 constant ETHERNET_PTP_PTPTSCR_TTSARU                      \ TTSARU
$00000100 constant ETHERNET_PTP_PTPTSCR_TSSARFE                     \ TSSARFE
$00000200 constant ETHERNET_PTP_PTPTSCR_TSSSR                       \ TSSSR
$00000400 constant ETHERNET_PTP_PTPTSCR_TSPTPPSV2E                  \ TSPTPPSV2E
$00000800 constant ETHERNET_PTP_PTPTSCR_TSSPTPOEFE                  \ TSSPTPOEFE
$00001000 constant ETHERNET_PTP_PTPTSCR_TSSIPV6FE                   \ TSSIPV6FE
$00002000 constant ETHERNET_PTP_PTPTSCR_TSSIPV4FE                   \ TSSIPV4FE
$00004000 constant ETHERNET_PTP_PTPTSCR_TSSEME                      \ TSSEME
$00008000 constant ETHERNET_PTP_PTPTSCR_TSSMRME                     \ TSSMRME
$00030000 constant ETHERNET_PTP_PTPTSCR_TSCNT                       \ TSCNT
$00040000 constant ETHERNET_PTP_PTPTSCR_TSPFFMAE                    \ TSPFFMAE


\
\ @brief Ethernet PTP subsecond increment register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$000000ff constant ETHERNET_PTP_PTPSSIR_STSSI                       \ STSSI


\
\ @brief Ethernet PTP time stamp high register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000000 constant ETHERNET_PTP_PTPTSHR_STS                         \ STS


\
\ @brief Ethernet PTP time stamp low register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$7fffffff constant ETHERNET_PTP_PTPTSLR_STSS                        \ STSS
$80000000 constant ETHERNET_PTP_PTPTSLR_STPNS                       \ STPNS


\
\ @brief Ethernet PTP time stamp high update register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000000 constant ETHERNET_PTP_PTPTSHUR_TSUS                       \ TSUS


\
\ @brief Ethernet PTP time stamp low update register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$7fffffff constant ETHERNET_PTP_PTPTSLUR_TSUSS                      \ TSUSS
$80000000 constant ETHERNET_PTP_PTPTSLUR_TSUPNS                     \ TSUSS


\
\ @brief Ethernet PTP time stamp addend register
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000000 constant ETHERNET_PTP_PTPTSAR_TSA                         \ TSA


\
\ @brief Ethernet PTP target time high register
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$00000000 constant ETHERNET_PTP_PTPTTHR_TTSH                        \ 0


\
\ @brief Ethernet PTP target time low register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000000 constant ETHERNET_PTP_PTPTTLR_TTSL                        \ TTSL


\
\ @brief Ethernet PTP time stamp status register
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$00000001 constant ETHERNET_PTP_PTPTSSR_TSSO                        \ TSSO
$00000002 constant ETHERNET_PTP_PTPTSSR_TSTTR                       \ TSTTR


\
\ @brief Ethernet PTP PPS control register
\ Address offset: 0x2C
\ Reset value: 0x00000000
\

$00000001 constant ETHERNET_PTP_PTPPPSCR_TSSO                       \ TSSO
$00000002 constant ETHERNET_PTP_PTPPPSCR_TSTTR                      \ TSTTR


\
\ @brief Ethernet: Precision time protocol
\
$40028700 constant ETHERNET_PTP_PTPTSCR  \ offset: 0x00 : Ethernet PTP time stamp control register
$40028704 constant ETHERNET_PTP_PTPSSIR  \ offset: 0x04 : Ethernet PTP subsecond increment register
$40028708 constant ETHERNET_PTP_PTPTSHR  \ offset: 0x08 : Ethernet PTP time stamp high register
$4002870c constant ETHERNET_PTP_PTPTSLR  \ offset: 0x0C : Ethernet PTP time stamp low register
$40028710 constant ETHERNET_PTP_PTPTSHUR  \ offset: 0x10 : Ethernet PTP time stamp high update register
$40028714 constant ETHERNET_PTP_PTPTSLUR  \ offset: 0x14 : Ethernet PTP time stamp low update register
$40028718 constant ETHERNET_PTP_PTPTSAR  \ offset: 0x18 : Ethernet PTP time stamp addend register
$4002871c constant ETHERNET_PTP_PTPTTHR  \ offset: 0x1C : Ethernet PTP target time high register
$40028720 constant ETHERNET_PTP_PTPTTLR  \ offset: 0x20 : Ethernet PTP target time low register
$40028728 constant ETHERNET_PTP_PTPTSSR  \ offset: 0x28 : Ethernet PTP time stamp status register
$4002872c constant ETHERNET_PTP_PTPPPSCR  \ offset: 0x2C : Ethernet PTP PPS control register

