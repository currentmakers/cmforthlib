\
\ @file dlybos1.fs
\ @brief DLYB address block description
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

$00000001 constant DLYBOS1_DLYB_CR_DEN                              \ Delay block enable bit
$00000002 constant DLYBOS1_DLYB_CR_SEN                              \ Sampler length enable bit


\
\ @brief DLYB configuration register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$0000000f constant DLYBOS1_DLYB_CFGR_SEL                            \ Phase for the output clock.
$00007f00 constant DLYBOS1_DLYB_CFGR_UNIT                           \ Delay of a unit delay cell.
$0fff0000 constant DLYBOS1_DLYB_CFGR_LNG                            \ Delay line length value
$80000000 constant DLYBOS1_DLYB_CFGR_LNGF                           \ Length valid flag


\
\ @brief DLYB address block description
\
$4600f000 constant DLYBOS1_DLYB_CR  \ offset: 0x00 : DLYB control register
$4600f004 constant DLYBOS1_DLYB_CFGR  \ offset: 0x04 : DLYB configuration register

