\
\ @file hdp.fs
\ @brief HDP register block
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief HDP control register
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000001 constant HDP_HDP_CTRL_EN                                  \ Enable HDP Valid if enabled in BSEC.


\
\ @brief HDP multiplexers control register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$0000000f constant HDP_HDP_MUX_MUX0                                 \ Select the HDP0 output among the 16 available signals
$000000f0 constant HDP_HDP_MUX_MUX1                                 \ Select the HDP1 output among the 16 available signals
$00000f00 constant HDP_HDP_MUX_MUX2                                 \ Select the HDP2 output among the 16 available signals
$0000f000 constant HDP_HDP_MUX_MUX3                                 \ Select the HDP3 output among the 16 available signals
$000f0000 constant HDP_HDP_MUX_MUX4                                 \ Select the HDP4 output among the 16 available signals
$00f00000 constant HDP_HDP_MUX_MUX5                                 \ Select the HDP5 output among the 16 available signals
$0f000000 constant HDP_HDP_MUX_MUX6                                 \ Select the HDP6 output among the 16 available signals
$f0000000 constant HDP_HDP_MUX_MUX7                                 \ Select the HDP7 output among the 16 available signals


\
\ @brief HDP read back value register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$000000ff constant HDP_HDP_VAL_HDPVAL                               \ HDP read back value Provides the value of the HDP signals.


\
\ @brief HDP general purpose output set register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$000000ff constant HDP_HDP_GPOSET_HDPGPOSET                         \ HDP general purpose output set When a bit is written to 1, the corresponding HDP GPO is set. Writing a bit to 0 has no effect.


\
\ @brief HDP general purpose output clear register
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$000000ff constant HDP_HDP_GPOCLR_HDPGPOCLR                         \ HDP general purpose output clear When a bit is written to 1, the corresponding HDP GPO is cleared. Writing a bit to 0 has no effect.


\
\ @brief HDP general purpose output value register
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$000000ff constant HDP_HDP_GPOVAL_HDPGPOVAL                         \ HDP general purpose output value When written, defines the value of the HDP GPO. When read, provides the current GPO value.


\
\ @brief HDP version register
\ Address offset: 0x3F4
\ Reset value: 0x00000010
\

$0000000f constant HDP_HDP_VERR_MINREV                              \ Minor revision of the IP
$000000f0 constant HDP_HDP_VERR_MAJREV                              \ Major revision of the IP


\
\ @brief HDP IP identification register
\ Address offset: 0x3F8
\ Reset value: 0x00030002
\

$00000000 constant HDP_HDP_IPIDR_ID                                 \ IP Identifier


\
\ @brief HDP size identification register
\ Address offset: 0x3FC
\ Reset value: 0xA3C5DD01
\

$00000000 constant HDP_HDP_SIDR_SID                                 \ Size identifier


\
\ @brief HDP register block
\
$5002a000 constant HDP_HDP_CTRL   \ offset: 0x00 : HDP control register
$5002a004 constant HDP_HDP_MUX    \ offset: 0x04 : HDP multiplexers control register
$5002a010 constant HDP_HDP_VAL    \ offset: 0x10 : HDP read back value register
$5002a014 constant HDP_HDP_GPOSET  \ offset: 0x14 : HDP general purpose output set register
$5002a018 constant HDP_HDP_GPOCLR  \ offset: 0x18 : HDP general purpose output clear register
$5002a01c constant HDP_HDP_GPOVAL  \ offset: 0x1C : HDP general purpose output value register
$5002a3f4 constant HDP_HDP_VERR   \ offset: 0x3F4 : HDP version register
$5002a3f8 constant HDP_HDP_IPIDR  \ offset: 0x3F8 : HDP IP identification register
$5002a3fc constant HDP_HDP_SIDR   \ offset: 0x3FC : HDP size identification register

