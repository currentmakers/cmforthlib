\
\ @file hdp.fs
\ @brief HDP
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief HDP Control
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000001 constant HDP_HDP_CTRL_EN                                  \ EN


\
\ @brief HDP multiplexing
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$0000000f constant HDP_HDP_MUX_MUX0                                 \ MUX0
$000000f0 constant HDP_HDP_MUX_MUX1                                 \ MUX1
$00000f00 constant HDP_HDP_MUX_MUX2                                 \ MUX2
$0000f000 constant HDP_HDP_MUX_MUX3                                 \ MUX3
$000f0000 constant HDP_HDP_MUX_MUX4                                 \ MUX4
$00f00000 constant HDP_HDP_MUX_MUX5                                 \ MUX5
$0f000000 constant HDP_HDP_MUX_MUX6                                 \ MUX6
$f0000000 constant HDP_HDP_MUX_MUX7                                 \ MUX7


\
\ @brief HDP value
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$000000ff constant HDP_HDP_VAL_HDPVAL                               \ HDPVAL


\
\ @brief HDP GPO set
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$000000ff constant HDP_HDP_GPOSET_HDPGPOSET                         \ HDPGPOSET


\
\ @brief HDP GPO clear
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$000000ff constant HDP_HDP_GPOCLR_HDPGPOCLR                         \ HDPGPOCLR


\
\ @brief HDP GPO value
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$000000ff constant HDP_HDP_GPOVAL_HDPGPOVAL                         \ HDPGPOVAL


\
\ @brief HDP version register
\ Address offset: 0x3F4
\ Reset value: 0x00000010
\

$0000000f constant HDP_HDP_VERR_MINREV                              \ MINREV
$000000f0 constant HDP_HDP_VERR_MAJREV                              \ MAJREV


\
\ @brief HDP IP identification register
\ Address offset: 0x3F8
\ Reset value: 0x00030002
\

$00000000 constant HDP_HDP_IPIDR_ID                                 \ ID


\
\ @brief HDP size identification register
\ Address offset: 0x3FC
\ Reset value: 0xA3C5DD01
\

$00000000 constant HDP_HDP_SIDR_SID                                 \ SID


\
\ @brief HDP
\
$5002a000 constant HDP_HDP_CTRL   \ offset: 0x00 : HDP Control
$5002a004 constant HDP_HDP_MUX    \ offset: 0x04 : HDP multiplexing
$5002a010 constant HDP_HDP_VAL    \ offset: 0x10 : HDP value
$5002a014 constant HDP_HDP_GPOSET  \ offset: 0x14 : HDP GPO set
$5002a018 constant HDP_HDP_GPOCLR  \ offset: 0x18 : HDP GPO clear
$5002a01c constant HDP_HDP_GPOVAL  \ offset: 0x1C : HDP GPO value
$5002a3f4 constant HDP_HDP_VERR   \ offset: 0x3F4 : HDP version register
$5002a3f8 constant HDP_HDP_IPIDR  \ offset: 0x3F8 : HDP IP identification register
$5002a3fc constant HDP_HDP_SIDR   \ offset: 0x3FC : HDP size identification register

