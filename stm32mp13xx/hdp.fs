\
\ @file hdp.fs
\ @brief HDP register block
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
    $00 constant HDP_EN                         \ [0x00] Enable HDP Valid if enabled in BSEC.
  [then]


  [ifdef] HDP_HDP_MUX_DEF
    \
    \ @brief HDP multiplexers control register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant HDP_MUX0                       \ [0x00 : 4] Select the HDP0 output among the 16 available signals
    $04 constant HDP_MUX1                       \ [0x04 : 4] Select the HDP1 output among the 16 available signals
    $08 constant HDP_MUX2                       \ [0x08 : 4] Select the HDP2 output among the 16 available signals
    $0c constant HDP_MUX3                       \ [0x0c : 4] Select the HDP3 output among the 16 available signals
    $10 constant HDP_MUX4                       \ [0x10 : 4] Select the HDP4 output among the 16 available signals
    $14 constant HDP_MUX5                       \ [0x14 : 4] Select the HDP5 output among the 16 available signals
    $18 constant HDP_MUX6                       \ [0x18 : 4] Select the HDP6 output among the 16 available signals
    $1c constant HDP_MUX7                       \ [0x1c : 4] Select the HDP7 output among the 16 available signals
  [then]


  [ifdef] HDP_HDP_VAL_DEF
    \
    \ @brief HDP read back value register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant HDP_HDPVAL                     \ [0x00 : 8] HDP read back value Provides the value of the HDP signals.
  [then]


  [ifdef] HDP_HDP_GPOSET_DEF
    \
    \ @brief HDP general purpose output set register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant HDP_HDPGPOSET                  \ [0x00 : 8] HDP general purpose output set When a bit is written to 1, the corresponding HDP GPO is set. Writing a bit to 0 has no effect.
  [then]


  [ifdef] HDP_HDP_GPOCLR_DEF
    \
    \ @brief HDP general purpose output clear register
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant HDP_HDPGPOCLR                  \ [0x00 : 8] HDP general purpose output clear When a bit is written to 1, the corresponding HDP GPO is cleared. Writing a bit to 0 has no effect.
  [then]


  [ifdef] HDP_HDP_GPOVAL_DEF
    \
    \ @brief HDP general purpose output value register
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant HDP_HDPGPOVAL                  \ [0x00 : 8] HDP general purpose output value When written, defines the value of the HDP GPO. When read, provides the current GPO value.
  [then]


  [ifdef] HDP_HDP_VERR_DEF
    \
    \ @brief HDP version register
    \ Address offset: 0x3F4
    \ Reset value: 0x00000010
    \
    $00 constant HDP_MINREV                     \ [0x00 : 4] Minor revision of the IP
    $04 constant HDP_MAJREV                     \ [0x04 : 4] Major revision of the IP
  [then]


  [ifdef] HDP_HDP_IPIDR_DEF
    \
    \ @brief HDP IP identification register
    \ Address offset: 0x3F8
    \ Reset value: 0x00030002
    \
    $00 constant HDP_ID                         \ [0x00 : 32] IP Identifier
  [then]


  [ifdef] HDP_HDP_SIDR_DEF
    \
    \ @brief HDP size identification register
    \ Address offset: 0x3FC
    \ Reset value: 0xA3C5DD01
    \
    $00 constant HDP_SID                        \ [0x00 : 32] Size identifier
  [then]

  \
  \ @brief HDP register block
  \
  $00 constant HDP_HDP_CTRL             \ HDP control register
  $04 constant HDP_HDP_MUX              \ HDP multiplexers control register
  $10 constant HDP_HDP_VAL              \ HDP read back value register
  $14 constant HDP_HDP_GPOSET           \ HDP general purpose output set register
  $18 constant HDP_HDP_GPOCLR           \ HDP general purpose output clear register
  $1C constant HDP_HDP_GPOVAL           \ HDP general purpose output value register
  $3F4 constant HDP_HDP_VERR            \ HDP version register
  $3F8 constant HDP_HDP_IPIDR           \ HDP IP identification register
  $3FC constant HDP_HDP_SIDR            \ HDP size identification register

: HDP_DEF ; [then]
