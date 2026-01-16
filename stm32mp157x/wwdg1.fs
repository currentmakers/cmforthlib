\
\ @file wwdg1.fs
\ @brief WWDG1
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief Control register
\ Address offset: 0x00
\ Reset value: 0x0000007F
\

$0000007f constant WWDG1_WWDG_CR_T                                  \ T
$00000080 constant WWDG1_WWDG_CR_WDGA                               \ WDGA


\
\ @brief Configuration register
\ Address offset: 0x04
\ Reset value: 0x0000007F
\

$0000007f constant WWDG1_WWDG_CFR_W                                 \ W
$00000200 constant WWDG1_WWDG_CFR_EWI                               \ EWI
$00003800 constant WWDG1_WWDG_CFR_WDGTB                             \ WDGTB


\
\ @brief Status register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000001 constant WWDG1_WWDG_SR_EWIF                               \ EWIF


\
\ @brief WWDG hardware configuration register
\ Address offset: 0x3F0
\ Reset value: 0x00000FFF
\

$0000ffff constant WWDG1_WWDG_HWCFGR_PREDIV                         \ PREDIV


\
\ @brief WWDG version register
\ Address offset: 0x3F4
\ Reset value: 0x00000021
\

$0000000f constant WWDG1_WWDG_VERR_MINREV                           \ MINREV
$000000f0 constant WWDG1_WWDG_VERR_MAJREV                           \ MAJREV


\
\ @brief WWDG ID register
\ Address offset: 0x3F8
\ Reset value: 0x00120051
\

$00000000 constant WWDG1_WWDG_IPIDR_ID                              \ ID


\
\ @brief WWDG size ID register
\ Address offset: 0x3FC
\ Reset value: 0xA3C5DD01
\

$00000000 constant WWDG1_WWDG_SIDR_SID                              \ SID


\
\ @brief WWDG1
\
$4000a000 constant WWDG1_WWDG_CR  \ offset: 0x00 : Control register
$4000a004 constant WWDG1_WWDG_CFR  \ offset: 0x04 : Configuration register
$4000a008 constant WWDG1_WWDG_SR  \ offset: 0x08 : Status register
$4000a3f0 constant WWDG1_WWDG_HWCFGR  \ offset: 0x3F0 : WWDG hardware configuration register
$4000a3f4 constant WWDG1_WWDG_VERR  \ offset: 0x3F4 : WWDG version register
$4000a3f8 constant WWDG1_WWDG_IPIDR  \ offset: 0x3F8 : WWDG ID register
$4000a3fc constant WWDG1_WWDG_SIDR  \ offset: 0x3FC : WWDG size ID register

