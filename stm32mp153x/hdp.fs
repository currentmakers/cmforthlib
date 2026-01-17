\
\ @file hdp.fs
\ @brief HDP
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] HDP_DEF

  [ifdef] HDP_HDP_CTRL_DEF
    \
    \ @brief HDP Control
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant HDP_EN                         \ [0x00] EN
  [then]


  [ifdef] HDP_HDP_MUX_DEF
    \
    \ @brief HDP multiplexing
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant HDP_MUX0                       \ [0x00 : 4] MUX0
    $04 constant HDP_MUX1                       \ [0x04 : 4] MUX1
    $08 constant HDP_MUX2                       \ [0x08 : 4] MUX2
    $0c constant HDP_MUX3                       \ [0x0c : 4] MUX3
    $10 constant HDP_MUX4                       \ [0x10 : 4] MUX4
    $14 constant HDP_MUX5                       \ [0x14 : 4] MUX5
    $18 constant HDP_MUX6                       \ [0x18 : 4] MUX6
    $1c constant HDP_MUX7                       \ [0x1c : 4] MUX7
  [then]


  [ifdef] HDP_HDP_VAL_DEF
    \
    \ @brief HDP value
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant HDP_HDPVAL                     \ [0x00 : 8] HDPVAL
  [then]


  [ifdef] HDP_HDP_GPOSET_DEF
    \
    \ @brief HDP GPO set
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant HDP_HDPGPOSET                  \ [0x00 : 8] HDPGPOSET
  [then]


  [ifdef] HDP_HDP_GPOCLR_DEF
    \
    \ @brief HDP GPO clear
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant HDP_HDPGPOCLR                  \ [0x00 : 8] HDPGPOCLR
  [then]


  [ifdef] HDP_HDP_GPOVAL_DEF
    \
    \ @brief HDP GPO value
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant HDP_HDPGPOVAL                  \ [0x00 : 8] HDPGPOVAL
  [then]


  [ifdef] HDP_HDP_VERR_DEF
    \
    \ @brief HDP version register
    \ Address offset: 0x3F4
    \ Reset value: 0x00000010
    \
    $00 constant HDP_MINREV                     \ [0x00 : 4] MINREV
    $04 constant HDP_MAJREV                     \ [0x04 : 4] MAJREV
  [then]


  [ifdef] HDP_HDP_IPIDR_DEF
    \
    \ @brief HDP IP identification register
    \ Address offset: 0x3F8
    \ Reset value: 0x00030002
    \
    $00 constant HDP_ID                         \ [0x00 : 32] ID
  [then]


  [ifdef] HDP_HDP_SIDR_DEF
    \
    \ @brief HDP size identification register
    \ Address offset: 0x3FC
    \ Reset value: 0xA3C5DD01
    \
    $00 constant HDP_SID                        \ [0x00 : 32] SID
  [then]

  \
  \ @brief HDP
  \
  $00 constant HDP_HDP_CTRL             \ HDP Control
  $04 constant HDP_HDP_MUX              \ HDP multiplexing
  $10 constant HDP_HDP_VAL              \ HDP value
  $14 constant HDP_HDP_GPOSET           \ HDP GPO set
  $18 constant HDP_HDP_GPOCLR           \ HDP GPO clear
  $1C constant HDP_HDP_GPOVAL           \ HDP GPO value
  $3F4 constant HDP_HDP_VERR            \ HDP version register
  $3F8 constant HDP_HDP_IPIDR           \ HDP IP identification register
  $3FC constant HDP_HDP_SIDR            \ HDP size identification register

: HDP_DEF ; [then]
