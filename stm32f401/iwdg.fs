\
\ @file iwdg.fs
\ @brief Independent watchdog
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] IWDG_DEF

  [ifdef] IWDG_KR_DEF
    \
    \ @brief Key register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant IWDG_KEY                       \ [0x00 : 16] Key value
  [then]


  [ifdef] IWDG_PR_DEF
    \
    \ @brief Prescaler register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant IWDG_PR                        \ [0x00 : 3] Prescaler divider
  [then]


  [ifdef] IWDG_RLR_DEF
    \
    \ @brief Reload register
    \ Address offset: 0x08
    \ Reset value: 0x00000FFF
    \
    $00 constant IWDG_RL                        \ [0x00 : 12] Watchdog counter reload value
  [then]


  [ifdef] IWDG_SR_DEF
    \
    \ @brief Status register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant IWDG_PVU                       \ [0x00] Watchdog prescaler value update
    $01 constant IWDG_RVU                       \ [0x01] Watchdog counter reload value update
  [then]

  \
  \ @brief Independent watchdog
  \
  $00 constant IWDG_KR                  \ Key register
  $04 constant IWDG_PR                  \ Prescaler register
  $08 constant IWDG_RLR                 \ Reload register
  $0C constant IWDG_SR                  \ Status register

: IWDG_DEF ; [then]
