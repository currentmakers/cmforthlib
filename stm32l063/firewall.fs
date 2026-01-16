\
\ @file firewall.fs
\ @brief Firewall
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief Code segment start address
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00ffff00 constant FIREWALL_FIREWALL_CSSA_ADD                       \ code segment start address


\
\ @brief Code segment length
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$003fff00 constant FIREWALL_FIREWALL_CSL_LENG                       \ code segment length


\
\ @brief Non-volatile data segment start address
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00ffff00 constant FIREWALL_FIREWALL_NVDSSA_ADD                     \ Non-volatile data segment start address


\
\ @brief Non-volatile data segment length
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$003fff00 constant FIREWALL_FIREWALL_NVDSL_LENG                     \ Non-volatile data segment length


\
\ @brief Volatile data segment start address
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$0000ffc0 constant FIREWALL_FIREWALL_VDSSA_ADD                      \ Volatile data segment start address


\
\ @brief Volatile data segment length
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$0000ffc0 constant FIREWALL_FIREWALL_VDSL_LENG                      \ Non-volatile data segment length


\
\ @brief Configuration register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000001 constant FIREWALL_FIREWALL_CR_FPA                         \ Firewall pre alarm
$00000002 constant FIREWALL_FIREWALL_CR_VDS                         \ Volatile data shared
$00000004 constant FIREWALL_FIREWALL_CR_VDE                         \ Volatile data execution


\
\ @brief Firewall
\
$40011c00 constant FIREWALL_FIREWALL_CSSA  \ offset: 0x00 : Code segment start address
$40011c04 constant FIREWALL_FIREWALL_CSL  \ offset: 0x04 : Code segment length
$40011c08 constant FIREWALL_FIREWALL_NVDSSA  \ offset: 0x08 : Non-volatile data segment start address
$40011c0c constant FIREWALL_FIREWALL_NVDSL  \ offset: 0x0C : Non-volatile data segment length
$40011c10 constant FIREWALL_FIREWALL_VDSSA  \ offset: 0x10 : Volatile data segment start address
$40011c14 constant FIREWALL_FIREWALL_VDSL  \ offset: 0x14 : Volatile data segment length
$40011c20 constant FIREWALL_FIREWALL_CR  \ offset: 0x20 : Configuration register

