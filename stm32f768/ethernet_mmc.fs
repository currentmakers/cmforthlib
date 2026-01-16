\
\ @file ethernet_mmc.fs
\ @brief Ethernet: MAC management counters
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief Ethernet MMC control register
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000001 constant ETHERNET_MMC_MMCCR_CR                            \ CR
$00000002 constant ETHERNET_MMC_MMCCR_CSR                           \ CSR
$00000004 constant ETHERNET_MMC_MMCCR_ROR                           \ ROR
$00000008 constant ETHERNET_MMC_MMCCR_MCF                           \ MCF
$00000010 constant ETHERNET_MMC_MMCCR_MCP                           \ MCP
$00000020 constant ETHERNET_MMC_MMCCR_MCFHP                         \ MCFHP


\
\ @brief Ethernet MMC receive interrupt register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000020 constant ETHERNET_MMC_MMCRIR_RFCES                        \ RFCES
$00000040 constant ETHERNET_MMC_MMCRIR_RFAES                        \ RFAES
$00020000 constant ETHERNET_MMC_MMCRIR_RGUFS                        \ RGUFS


\
\ @brief Ethernet MMC transmit interrupt register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00004000 constant ETHERNET_MMC_MMCTIR_TGFSCS                       \ TGFSCS
$00008000 constant ETHERNET_MMC_MMCTIR_TGFMSCS                      \ TGFMSCS
$00200000 constant ETHERNET_MMC_MMCTIR_TGFS                         \ TGFS


\
\ @brief Ethernet MMC receive interrupt mask register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000020 constant ETHERNET_MMC_MMCRIMR_RFCEM                       \ RFCEM
$00000040 constant ETHERNET_MMC_MMCRIMR_RFAEM                       \ RFAEM
$00020000 constant ETHERNET_MMC_MMCRIMR_RGUFM                       \ RGUFM


\
\ @brief Ethernet MMC transmit interrupt mask register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00004000 constant ETHERNET_MMC_MMCTIMR_TGFSCM                      \ TGFSCM
$00008000 constant ETHERNET_MMC_MMCTIMR_TGFMSCM                     \ TGFMSCM
$00010000 constant ETHERNET_MMC_MMCTIMR_TGFM                        \ TGFM


\
\ @brief Ethernet MMC transmitted good frames after a single collision counter
\ Address offset: 0x4C
\ Reset value: 0x00000000
\

$00000000 constant ETHERNET_MMC_MMCTGFSCCR_TGFSCC                   \ TGFSCC


\
\ @brief Ethernet MMC transmitted good frames after more than a single collision
\ Address offset: 0x50
\ Reset value: 0x00000000
\

$00000000 constant ETHERNET_MMC_MMCTGFMSCCR_TGFMSCC                 \ TGFMSCC


\
\ @brief Ethernet MMC transmitted good frames counter register
\ Address offset: 0x68
\ Reset value: 0x00000000
\

$00000000 constant ETHERNET_MMC_MMCTGFCR_TGFC                       \ HTL


\
\ @brief Ethernet MMC received frames with CRC error counter register
\ Address offset: 0x94
\ Reset value: 0x00000000
\

$00000000 constant ETHERNET_MMC_MMCRFCECR_RFCFC                     \ RFCFC


\
\ @brief Ethernet MMC received frames with alignment error counter register
\ Address offset: 0x98
\ Reset value: 0x00000000
\

$00000000 constant ETHERNET_MMC_MMCRFAECR_RFAEC                     \ RFAEC


\
\ @brief MMC received good unicast frames counter register
\ Address offset: 0xC4
\ Reset value: 0x00000000
\

$00000000 constant ETHERNET_MMC_MMCRGUFCR_RGUFC                     \ RGUFC


\
\ @brief Ethernet: MAC management counters
\
$40028100 constant ETHERNET_MMC_MMCCR  \ offset: 0x00 : Ethernet MMC control register
$40028104 constant ETHERNET_MMC_MMCRIR  \ offset: 0x04 : Ethernet MMC receive interrupt register
$40028108 constant ETHERNET_MMC_MMCTIR  \ offset: 0x08 : Ethernet MMC transmit interrupt register
$4002810c constant ETHERNET_MMC_MMCRIMR  \ offset: 0x0C : Ethernet MMC receive interrupt mask register
$40028110 constant ETHERNET_MMC_MMCTIMR  \ offset: 0x10 : Ethernet MMC transmit interrupt mask register
$4002814c constant ETHERNET_MMC_MMCTGFSCCR  \ offset: 0x4C : Ethernet MMC transmitted good frames after a single collision counter
$40028150 constant ETHERNET_MMC_MMCTGFMSCCR  \ offset: 0x50 : Ethernet MMC transmitted good frames after more than a single collision
$40028168 constant ETHERNET_MMC_MMCTGFCR  \ offset: 0x68 : Ethernet MMC transmitted good frames counter register
$40028194 constant ETHERNET_MMC_MMCRFCECR  \ offset: 0x94 : Ethernet MMC received frames with CRC error counter register
$40028198 constant ETHERNET_MMC_MMCRFAECR  \ offset: 0x98 : Ethernet MMC received frames with alignment error counter register
$400281c4 constant ETHERNET_MMC_MMCRGUFCR  \ offset: 0xC4 : MMC received good unicast frames counter register

