\
\ @file hdp_s.fs
\ @brief Hardware debug port
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

$00000001 constant HDP_S_HDP_CTRL_EN                                \ Enable HDP, valid if enabled in BSEC


\
\ @brief HDP multiplexer control register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$0000000f constant HDP_S_HDP_MUX_MUX0                               \ Select the HDPy output among the 16 available signals
$000000f0 constant HDP_S_HDP_MUX_MUX1                               \ Select the HDPy output among the 16 available signals
$00000f00 constant HDP_S_HDP_MUX_MUX2                               \ Select the HDPy output among the 16 available signals
$0000f000 constant HDP_S_HDP_MUX_MUX3                               \ Select the HDPy output among the 16 available signals
$000f0000 constant HDP_S_HDP_MUX_MUX4                               \ Select the HDPy output among the 16 available signals
$00f00000 constant HDP_S_HDP_MUX_MUX5                               \ Select the HDPy output among the 16 available signals
$0f000000 constant HDP_S_HDP_MUX_MUX6                               \ Select the HDPy output among the 16 available signals
$f0000000 constant HDP_S_HDP_MUX_MUX7                               \ Select the HDPy output among the 16 available signals


\
\ @brief HDP read back value register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$000000ff constant HDP_S_HDP_VAL_HDPVAL                             \ Value of the HDP signals


\
\ @brief HDP general-purpose output set register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$000000ff constant HDP_S_HDP_GPOSET_HDPGPOSET                       \ When a bit is written to 1, the corresponding HDP GPO is set


\
\ @brief HDP general purpose output clear register
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$000000ff constant HDP_S_HDP_GPOCLR_HDPGPOCLR                       \ When a bit is written to 1, the corresponding HDP GPO is cleared.


\
\ @brief HDP general purpose output value register
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$000000ff constant HDP_S_HDP_GPOVAL_HDPGPOVAL                       \ When written, define the value of the HDP GPO.


\
\ @brief Hardware debug port
\
$56000800 constant HDP_S_HDP_CTRL  \ offset: 0x00 : HDP control register
$56000804 constant HDP_S_HDP_MUX  \ offset: 0x04 : HDP multiplexer control register
$56000810 constant HDP_S_HDP_VAL  \ offset: 0x10 : HDP read back value register
$56000814 constant HDP_S_HDP_GPOSET  \ offset: 0x14 : HDP general-purpose output set register
$56000818 constant HDP_S_HDP_GPOCLR  \ offset: 0x18 : HDP general purpose output clear register
$5600081c constant HDP_S_HDP_GPOVAL  \ offset: 0x1C : HDP general purpose output value register

