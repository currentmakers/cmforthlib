\
\ @file dlybsd2.fs
\ @brief DLYB
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

$00000001 constant DLYBSD2_DLYB_CR_DEN                              \ Delay block enable bit
$00000002 constant DLYBSD2_DLYB_CR_SEN                              \ Sampler length enable bit


\
\ @brief DLYB configuration register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$0000000f constant DLYBSD2_DLYB_CFGR_SEL                            \ Phase for the output clock. These bits can only be written when SEN = 1. Output clock phase = input clock + SEL[3:0] x unit delay
$00007f00 constant DLYBSD2_DLYB_CFGR_UNIT                           \ Delay of a unit delay cell. These bits can only be written when SEN = 1. Unit delay = initial delay + UNIT[6:0] x delay step
$0fff0000 constant DLYBSD2_DLYB_CFGR_LNG                            \ Delay line length value These bits reflect the 12 unit delay values sampled at the rising edge of the input clock. The value is only valid when LNGF = 1.
$80000000 constant DLYBSD2_DLYB_CFGR_LNGF                           \ Length valid flag This flag indicates when the delay line length value contained in LNG[11:0] is valid after UNIT[6:0] bits changed.


\
\ @brief DLYB
\
$58008000 constant DLYBSD2_DLYB_CR  \ offset: 0x00 : DLYB control register
$58008004 constant DLYBSD2_DLYB_CFGR  \ offset: 0x04 : DLYB configuration register

