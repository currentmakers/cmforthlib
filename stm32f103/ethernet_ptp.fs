\
\ @file ethernet_ptp.fs
\ @brief Ethernet: Precision time protocol
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief Ethernet PTP time stamp control register (ETH_PTPTSCR)
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000001 constant ETHERNET_PTP_PTPTSCR_TSE                         \ Time stamp enable
$00000002 constant ETHERNET_PTP_PTPTSCR_TSFCU                       \ Time stamp fine or coarse update
$00000004 constant ETHERNET_PTP_PTPTSCR_TSSTI                       \ Time stamp system time initialize
$00000008 constant ETHERNET_PTP_PTPTSCR_TSSTU                       \ Time stamp system time update
$00000010 constant ETHERNET_PTP_PTPTSCR_TSITE                       \ Time stamp interrupt trigger enable
$00000020 constant ETHERNET_PTP_PTPTSCR_TSARU                       \ Time stamp addend register update


\
\ @brief Ethernet PTP subsecond increment register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$000000ff constant ETHERNET_PTP_PTPSSIR_STSSI                       \ System time subsecond increment


\
\ @brief Ethernet PTP time stamp high register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000000 constant ETHERNET_PTP_PTPTSHR_STS                         \ System time second


\
\ @brief Ethernet PTP time stamp low register (ETH_PTPTSLR)
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$7fffffff constant ETHERNET_PTP_PTPTSLR_STSS                        \ System time subseconds
$80000000 constant ETHERNET_PTP_PTPTSLR_STPNS                       \ System time positive or negative sign


\
\ @brief Ethernet PTP time stamp high update register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000000 constant ETHERNET_PTP_PTPTSHUR_TSUS                       \ Time stamp update second


\
\ @brief Ethernet PTP time stamp low update register (ETH_PTPTSLUR)
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$7fffffff constant ETHERNET_PTP_PTPTSLUR_TSUSS                      \ Time stamp update subseconds
$80000000 constant ETHERNET_PTP_PTPTSLUR_TSUPNS                     \ Time stamp update positive or negative sign


\
\ @brief Ethernet PTP time stamp addend register
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000000 constant ETHERNET_PTP_PTPTSAR_TSA                         \ Time stamp addend


\
\ @brief Ethernet PTP target time high register
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$00000000 constant ETHERNET_PTP_PTPTTHR_TTSH                        \ Target time stamp high


\
\ @brief Ethernet PTP target time low register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000000 constant ETHERNET_PTP_PTPTTLR_TTSL                        \ Target time stamp low


\
\ @brief Ethernet: Precision time protocol
\
$40028700 constant ETHERNET_PTP_PTPTSCR  \ offset: 0x00 : Ethernet PTP time stamp control register (ETH_PTPTSCR)
$40028704 constant ETHERNET_PTP_PTPSSIR  \ offset: 0x04 : Ethernet PTP subsecond increment register
$40028708 constant ETHERNET_PTP_PTPTSHR  \ offset: 0x08 : Ethernet PTP time stamp high register
$4002870c constant ETHERNET_PTP_PTPTSLR  \ offset: 0x0C : Ethernet PTP time stamp low register (ETH_PTPTSLR)
$40028710 constant ETHERNET_PTP_PTPTSHUR  \ offset: 0x10 : Ethernet PTP time stamp high update register
$40028714 constant ETHERNET_PTP_PTPTSLUR  \ offset: 0x14 : Ethernet PTP time stamp low update register (ETH_PTPTSLUR)
$40028718 constant ETHERNET_PTP_PTPTSAR  \ offset: 0x18 : Ethernet PTP time stamp addend register
$4002871c constant ETHERNET_PTP_PTPTTHR  \ offset: 0x1C : Ethernet PTP target time high register
$40028720 constant ETHERNET_PTP_PTPTTLR  \ offset: 0x20 : Ethernet PTP target time low register

