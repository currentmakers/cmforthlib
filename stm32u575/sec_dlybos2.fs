\
\ @file sec_dlybos2.fs
\ @brief The delay block (DLYB) is used to generate an output clock that is dephased from the input clock
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief control register
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000001 constant SEC_DLYBOS2_DLYB_CR_DEN                          \ Operational amplifier Enable
$00000002 constant SEC_DLYBOS2_DLYB_CR_SEN                          \ OPALPM


\
\ @brief configuration register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$0000000f constant SEC_DLYBOS2_DLYB_CFGR_SEL                        \ SEL
$00007f00 constant SEC_DLYBOS2_DLYB_CFGR_UNIT                       \ UNIT
$0fff0000 constant SEC_DLYBOS2_DLYB_CFGR_LNG                        \ LNG
$80000000 constant SEC_DLYBOS2_DLYB_CFGR_LNGF                       \ LNGF


\
\ @brief The delay block (DLYB) is used to generate an output clock that is dephased from the input clock
\
$520cf400 constant SEC_DLYBOS2_DLYB_CR  \ offset: 0x00 : control register
$520cf404 constant SEC_DLYBOS2_DLYB_CFGR  \ offset: 0x04 : configuration register

