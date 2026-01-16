\
\ @file dlybsd.fs
\ @brief DLYBSD address block description
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief Delay block SDMMC DLL configuration
\ Address offset: 0x00
\ Reset value: 0x00400000
\

$00000001 constant DLYBSD_DLYBSD_CFG_SDMMC_DLL_EN                   \ DLL enable
$0000007e constant DLYBSD_DLYBSD_CFG_SDMMC_RX_TAP_SEL               \ selection of RX delay
$00010000 constant DLYBSD_DLYBSD_CFG_SDMMC_DLL_BYP_EN               \ DLL configuration
$003e0000 constant DLYBSD_DLYBSD_CFG_SDMMC_DLL_BYP_CMD              \ Bypass command
$00400000 constant DLYBSD_DLYBSD_CFG_SDMMC_DLL_ANTIGLITCH_EN        \ Antiglitch logic enabled when 1


\
\ @brief Delay block SDMMC DLL status
\ Address offset: 0x04
\ Reset value: 0x00000002
\

$00000001 constant DLYBSD_DLYBSD_STATUS_SDMMC_DLL_LOCK              \ SDMMC DLL lock
$00000002 constant DLYBSD_DLYBSD_STATUS_SDMMC_RX_TAP_SEL_ACK        \ SDMMC RX delay selection acknowledge


\
\ @brief DLYBSD address block description
\
$48028000 constant DLYBSD_DLYBSD_CFG  \ offset: 0x00 : Delay block SDMMC DLL configuration
$48028004 constant DLYBSD_DLYBSD_STATUS  \ offset: 0x04 : Delay block SDMMC DLL status

