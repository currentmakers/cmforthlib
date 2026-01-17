\
\ @file wwdg1.fs
\ @brief WWDG1
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] WWDG1_DEF

  [ifdef] WWDG1_WWDG_CR_DEF
    \
    \ @brief Control register
    \ Address offset: 0x00
    \ Reset value: 0x0000007F
    \
    $00 constant WWDG1_T                        \ [0x00 : 7] T
    $07 constant WWDG1_WDGA                     \ [0x07] WDGA
  [then]


  [ifdef] WWDG1_WWDG_CFR_DEF
    \
    \ @brief Configuration register
    \ Address offset: 0x04
    \ Reset value: 0x0000007F
    \
    $00 constant WWDG1_W                        \ [0x00 : 7] W
    $09 constant WWDG1_EWI                      \ [0x09] EWI
    $0b constant WWDG1_WDGTB                    \ [0x0b : 3] WDGTB
  [then]


  [ifdef] WWDG1_WWDG_SR_DEF
    \
    \ @brief Status register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant WWDG1_EWIF                     \ [0x00] EWIF
  [then]


  [ifdef] WWDG1_WWDG_HWCFGR_DEF
    \
    \ @brief WWDG hardware configuration register
    \ Address offset: 0x3F0
    \ Reset value: 0x00000FFF
    \
    $00 constant WWDG1_PREDIV                   \ [0x00 : 16] PREDIV
  [then]


  [ifdef] WWDG1_WWDG_VERR_DEF
    \
    \ @brief WWDG version register
    \ Address offset: 0x3F4
    \ Reset value: 0x00000021
    \
    $00 constant WWDG1_MINREV                   \ [0x00 : 4] MINREV
    $04 constant WWDG1_MAJREV                   \ [0x04 : 4] MAJREV
  [then]


  [ifdef] WWDG1_WWDG_IPIDR_DEF
    \
    \ @brief WWDG ID register
    \ Address offset: 0x3F8
    \ Reset value: 0x00120051
    \
    $00 constant WWDG1_ID                       \ [0x00 : 32] ID
  [then]


  [ifdef] WWDG1_WWDG_SIDR_DEF
    \
    \ @brief WWDG size ID register
    \ Address offset: 0x3FC
    \ Reset value: 0xA3C5DD01
    \
    $00 constant WWDG1_SID                      \ [0x00 : 32] SID
  [then]

  \
  \ @brief WWDG1
  \
  $00 constant WWDG1_WWDG_CR            \ Control register
  $04 constant WWDG1_WWDG_CFR           \ Configuration register
  $08 constant WWDG1_WWDG_SR            \ Status register
  $3F0 constant WWDG1_WWDG_HWCFGR       \ WWDG hardware configuration register
  $3F4 constant WWDG1_WWDG_VERR         \ WWDG version register
  $3F8 constant WWDG1_WWDG_IPIDR        \ WWDG ID register
  $3FC constant WWDG1_WWDG_SIDR         \ WWDG size ID register

: WWDG1_DEF ; [then]
