\
\ @file dlybsd3.fs
\ @brief DLYBSD1
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief DLYB control register
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000001 constant DLYBSD3_DLYB_CR_DEN                              \ DEN
$00000002 constant DLYBSD3_DLYB_CR_SEN                              \ SEN


\
\ @brief DLYB configuration register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$0000000f constant DLYBSD3_DLYB_CFGR_SEL                            \ SEL
$00007f00 constant DLYBSD3_DLYB_CFGR_UNIT                           \ UNIT
$0fff0000 constant DLYBSD3_DLYB_CFGR_LNG                            \ LNG
$80000000 constant DLYBSD3_DLYB_CFGR_LNGF                           \ LNGF


\
\ @brief DLYB IP version register
\ Address offset: 0x3F4
\ Reset value: 0x00000011
\

$0000000f constant DLYBSD3_DLYB_VERR_MINREV                         \ MINREV
$000000f0 constant DLYBSD3_DLYB_VERR_MAJREV                         \ MAJREV


\
\ @brief DLYB IP identification register
\ Address offset: 0x3F8
\ Reset value: 0x00140051
\

$00000000 constant DLYBSD3_DLYB_IPIDR_ID                            \ ID


\
\ @brief DLYB size ID register
\ Address offset: 0x3FC
\ Reset value: 0xA3C5DD01
\

$00000000 constant DLYBSD3_DLYB_SIDR_SID                            \ SID


\
\ @brief DLYBSD1
\
$48005000 constant DLYBSD3_DLYB_CR  \ offset: 0x00 : DLYB control register
$48005004 constant DLYBSD3_DLYB_CFGR  \ offset: 0x04 : DLYB configuration register
$480053f4 constant DLYBSD3_DLYB_VERR  \ offset: 0x3F4 : DLYB IP version register
$480053f8 constant DLYBSD3_DLYB_IPIDR  \ offset: 0x3F8 : DLYB IP identification register
$480053fc constant DLYBSD3_DLYB_SIDR  \ offset: 0x3FC : DLYB size ID register

