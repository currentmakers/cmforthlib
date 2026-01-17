\
\ @file dlyb.fs
\ @brief DLYBQS
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] DLYB_DEF

  [ifdef] DLYB_DLYB_CR_DEF
    \
    \ @brief DLYB control register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant DLYB_DEN                       \ [0x00] DEN
    $01 constant DLYB_SEN                       \ [0x01] SEN
  [then]


  [ifdef] DLYB_DLYB_CFGR_DEF
    \
    \ @brief DLYB configuration register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant DLYB_SEL                       \ [0x00 : 4] SEL
    $08 constant DLYB_UNIT                      \ [0x08 : 7] UNIT
    $10 constant DLYB_LNG                       \ [0x10 : 12] LNG
    $1f constant DLYB_LNGF                      \ [0x1f] LNGF
  [then]


  [ifdef] DLYB_DLYB_VERR_DEF
    \
    \ @brief DLYB IP version register
    \ Address offset: 0x3F4
    \ Reset value: 0x00000011
    \
    $00 constant DLYB_MINREV                    \ [0x00 : 4] MINREV
    $04 constant DLYB_MAJREV                    \ [0x04 : 4] MAJREV
  [then]


  [ifdef] DLYB_DLYB_IPIDR_DEF
    \
    \ @brief DLYB IP identification register
    \ Address offset: 0x3F8
    \ Reset value: 0x00140051
    \
    $00 constant DLYB_ID                        \ [0x00 : 32] ID
  [then]


  [ifdef] DLYB_DLYB_SIDR_DEF
    \
    \ @brief DLYB size ID register
    \ Address offset: 0x3FC
    \ Reset value: 0xA3C5DD01
    \
    $00 constant DLYB_SID                       \ [0x00 : 32] SID
  [then]

  \
  \ @brief DLYBQS
  \
  $00 constant DLYB_DLYB_CR             \ DLYB control register
  $04 constant DLYB_DLYB_CFGR           \ DLYB configuration register
  $3F4 constant DLYB_DLYB_VERR          \ DLYB IP version register
  $3F8 constant DLYB_DLYB_IPIDR         \ DLYB IP identification register
  $3FC constant DLYB_DLYB_SIDR          \ DLYB size ID register

: DLYB_DEF ; [then]
