\
\ @file hdp.fs
\ @brief Hardware debug port
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] HDP_DEF

  [ifdef] HDP_HDP_CTRL_DEF
    \
    \ @brief HDP control register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant HDP_EN                         \ [0x00] Enable HDP, valid if enabled in BSEC
  [then]


  [ifdef] HDP_HDP_MUX_DEF
    \
    \ @brief HDP multiplexer control register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant HDP_MUX0                       \ [0x00 : 4] Select the HDPy output among the 16 available signals
    $04 constant HDP_MUX1                       \ [0x04 : 4] Select the HDPy output among the 16 available signals
    $08 constant HDP_MUX2                       \ [0x08 : 4] Select the HDPy output among the 16 available signals
    $0c constant HDP_MUX3                       \ [0x0c : 4] Select the HDPy output among the 16 available signals
    $10 constant HDP_MUX4                       \ [0x10 : 4] Select the HDPy output among the 16 available signals
    $14 constant HDP_MUX5                       \ [0x14 : 4] Select the HDPy output among the 16 available signals
    $18 constant HDP_MUX6                       \ [0x18 : 4] Select the HDPy output among the 16 available signals
    $1c constant HDP_MUX7                       \ [0x1c : 4] Select the HDPy output among the 16 available signals
  [then]


  [ifdef] HDP_HDP_VAL_DEF
    \
    \ @brief HDP read back value register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant HDP_HDPVAL                     \ [0x00 : 8] Value of the HDP signals
  [then]


  [ifdef] HDP_HDP_GPOSET_DEF
    \
    \ @brief HDP general-purpose output set register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant HDP_HDPGPOSET                  \ [0x00 : 8] When a bit is written to 1, the corresponding HDP GPO is set
  [then]


  [ifdef] HDP_HDP_GPOCLR_DEF
    \
    \ @brief HDP general purpose output clear register
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant HDP_HDPGPOCLR                  \ [0x00 : 8] When a bit is written to 1, the corresponding HDP GPO is cleared.
  [then]


  [ifdef] HDP_HDP_GPOVAL_DEF
    \
    \ @brief HDP general purpose output value register
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant HDP_HDPGPOVAL                  \ [0x00 : 8] When written, define the value of the HDP GPO.
  [then]

  \
  \ @brief Hardware debug port
  \
  $00 constant HDP_HDP_CTRL             \ HDP control register
  $04 constant HDP_HDP_MUX              \ HDP multiplexer control register
  $10 constant HDP_HDP_VAL              \ HDP read back value register
  $14 constant HDP_HDP_GPOSET           \ HDP general-purpose output set register
  $18 constant HDP_HDP_GPOCLR           \ HDP general purpose output clear register
  $1C constant HDP_HDP_GPOVAL           \ HDP general purpose output value register

: HDP_DEF ; [then]
