\
\ @file iwdg.fs
\ @brief IWDG1
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] IWDG_DEF

  [ifdef] IWDG_IWDG_KR_DEF
    \
    \ @brief Key register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant IWDG_KEY                       \ [0x00 : 16] KEY
  [then]


  [ifdef] IWDG_IWDG_PR_DEF
    \
    \ @brief Prescaler register
    \ Address offset: 0x04
    \ Reset value: 0x00000007
    \
    $00 constant IWDG_PR                        \ [0x00 : 3] PR
  [then]


  [ifdef] IWDG_IWDG_RLR_DEF
    \
    \ @brief Reload register
    \ Address offset: 0x08
    \ Reset value: 0x00000FFF
    \
    $00 constant IWDG_RL                        \ [0x00 : 12] RL
  [then]


  [ifdef] IWDG_IWDG_SR_DEF
    \
    \ @brief Status register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant IWDG_PVU                       \ [0x00] PVU
    $01 constant IWDG_RVU                       \ [0x01] RVU
    $02 constant IWDG_WVU                       \ [0x02] WVU
  [then]


  [ifdef] IWDG_IWDG_WINR_DEF
    \
    \ @brief Window register
    \ Address offset: 0x10
    \ Reset value: 0x00000FFF
    \
    $00 constant IWDG_WIN                       \ [0x00 : 12] WIN
  [then]


  [ifdef] IWDG_IWDG_EWCR_DEF
    \
    \ @brief IWDG early wake-up interrupt register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant IWDG_EWIT                      \ [0x00 : 12] EWIT
    $0e constant IWDG_EWIC                      \ [0x0e] EWIC
    $0f constant IWDG_EWIE                      \ [0x0f] EWIE
  [then]


  [ifdef] IWDG_IWDG_HWCFGR_DEF
    \
    \ @brief IWDG hardware configuration register
    \ Address offset: 0x3F0
    \ Reset value: 0x00000111
    \
    $00 constant IWDG_WINDOW                    \ [0x00 : 4] WINDOW
    $04 constant IWDG_PR_DEFAULT                \ [0x04 : 4] PR_DEFAULT
  [then]


  [ifdef] IWDG_IWDG_VERR_DEF
    \
    \ @brief IWDG version register
    \ Address offset: 0x3F4
    \ Reset value: 0x00000023
    \
    $00 constant IWDG_MINREV                    \ [0x00 : 4] MINREV
    $04 constant IWDG_MAJREV                    \ [0x04 : 4] MAJREV
  [then]


  [ifdef] IWDG_IWDG_IDR_DEF
    \
    \ @brief IWDG identification register
    \ Address offset: 0x3F8
    \ Reset value: 0x00120041
    \
    $00 constant IWDG_ID                        \ [0x00 : 32] ID
  [then]


  [ifdef] IWDG_IWDG_SIDR_DEF
    \
    \ @brief IWDG size identification register
    \ Address offset: 0x3FC
    \ Reset value: 0xA3C5DD01
    \
    $00 constant IWDG_SID                       \ [0x00 : 32] SID
  [then]

  \
  \ @brief IWDG1
  \
  $00 constant IWDG_IWDG_KR             \ Key register
  $04 constant IWDG_IWDG_PR             \ Prescaler register
  $08 constant IWDG_IWDG_RLR            \ Reload register
  $0C constant IWDG_IWDG_SR             \ Status register
  $10 constant IWDG_IWDG_WINR           \ Window register
  $14 constant IWDG_IWDG_EWCR           \ IWDG early wake-up interrupt register
  $3F0 constant IWDG_IWDG_HWCFGR        \ IWDG hardware configuration register
  $3F4 constant IWDG_IWDG_VERR          \ IWDG version register
  $3F8 constant IWDG_IWDG_IDR           \ IWDG identification register
  $3FC constant IWDG_IWDG_SIDR          \ IWDG size identification register

: IWDG_DEF ; [then]
