\
\ @file iwdg.fs
\ @brief IWDG address block description
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] IWDG_DEF

  [ifdef] IWDG_IWDG_KR_DEF
    \
    \ @brief IWDG key register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant IWDG_KEY                       \ [0x00 : 16] Key value (write only, read 0x0000)
  [then]


  [ifdef] IWDG_IWDG_PR_DEF
    \
    \ @brief IWDG prescaler register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant IWDG_PR                        \ [0x00 : 4] Prescaler divider
  [then]


  [ifdef] IWDG_IWDG_RLR_DEF
    \
    \ @brief IWDG reload register
    \ Address offset: 0x08
    \ Reset value: 0x00000FFF
    \
    $00 constant IWDG_RL                        \ [0x00 : 12] Watchdog counter reload value
  [then]


  [ifdef] IWDG_IWDG_SR_DEF
    \
    \ @brief IWDG status register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant IWDG_PVU                       \ [0x00] Watchdog prescaler value update
    $01 constant IWDG_RVU                       \ [0x01] Watchdog counter reload value update
    $02 constant IWDG_WVU                       \ [0x02] Watchdog counter window value update
    $03 constant IWDG_EWU                       \ [0x03] Watchdog interrupt comparator value update
    $08 constant IWDG_ONF                       \ [0x08] Watchdog enable status bit
    $0e constant IWDG_EWIF                      \ [0x0e] Watchdog early interrupt flag
  [then]


  [ifdef] IWDG_IWDG_WINR_DEF
    \
    \ @brief IWDG window register
    \ Address offset: 0x10
    \ Reset value: 0x00000FFF
    \
    $00 constant IWDG_WIN                       \ [0x00 : 12] Watchdog counter window value
  [then]


  [ifdef] IWDG_IWDG_EWCR_DEF
    \
    \ @brief IWDG early wake-up interrupt register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant IWDG_EWIT                      \ [0x00 : 12] Watchdog counter window value
    $0e constant IWDG_EWIC                      \ [0x0e] Watchdog early interrupt acknowledge
    $0f constant IWDG_EWIE                      \ [0x0f] Watchdog early interrupt enable
  [then]

  \
  \ @brief IWDG address block description
  \
  $00 constant IWDG_IWDG_KR             \ IWDG key register
  $04 constant IWDG_IWDG_PR             \ IWDG prescaler register
  $08 constant IWDG_IWDG_RLR            \ IWDG reload register
  $0C constant IWDG_IWDG_SR             \ IWDG status register
  $10 constant IWDG_IWDG_WINR           \ IWDG window register
  $14 constant IWDG_IWDG_EWCR           \ IWDG early wake-up interrupt register

: IWDG_DEF ; [then]
