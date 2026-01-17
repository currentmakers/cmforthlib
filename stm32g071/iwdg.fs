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
    $00 constant IWDG_KEY                       \ [0x00 : 16] Key value (write only, read 0x0000)
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
    $02 constant IWDG_WVU                       \ [0x02] Watchdog counter window value update
  [then]


  [ifdef] IWDG_WINR_DEF
    \
    \ @brief Window register
    \ Address offset: 0x10
    \ Reset value: 0x00000FFF
    \
    $00 constant IWDG_WIN                       \ [0x00 : 12] Watchdog counter window value
  [then]


  [ifdef] IWDG_HWCFGR_DEF
    \
    \ @brief hardware configuration register
    \ Address offset: 0x3F0
    \ Reset value: 0x00000071
    \
    $00 constant IWDG_WINDOW                    \ [0x00 : 4] Support of Window function
    $04 constant IWDG_PR_DEFAULT                \ [0x04 : 4] Prescaler default value
  [then]


  [ifdef] IWDG_VERR_DEF
    \
    \ @brief EXTI IP Version register
    \ Address offset: 0x3F4
    \ Reset value: 0x00000023
    \
    $00 constant IWDG_MINREV                    \ [0x00 : 4] Minor Revision number
    $04 constant IWDG_MAJREV                    \ [0x04 : 4] Major Revision number
  [then]


  [ifdef] IWDG_IPIDR_DEF
    \
    \ @brief EXTI Identification register
    \ Address offset: 0x3F8
    \ Reset value: 0x00120041
    \
    $00 constant IWDG_IPID                      \ [0x00 : 32] IP Identification
  [then]


  [ifdef] IWDG_SIDR_DEF
    \
    \ @brief EXTI Size ID register
    \ Address offset: 0x3FC
    \ Reset value: 0xA3C5DD01
    \
    $00 constant IWDG_SID                       \ [0x00 : 32] Size Identification
  [then]

  \
  \ @brief Independent watchdog
  \
  $00 constant IWDG_KR                  \ Key register
  $04 constant IWDG_PR                  \ Prescaler register
  $08 constant IWDG_RLR                 \ Reload register
  $0C constant IWDG_SR                  \ Status register
  $10 constant IWDG_WINR                \ Window register
  $3F0 constant IWDG_HWCFGR             \ hardware configuration register
  $3F4 constant IWDG_VERR               \ EXTI IP Version register
  $3F8 constant IWDG_IPIDR              \ EXTI Identification register
  $3FC constant IWDG_SIDR               \ EXTI Size ID register

: IWDG_DEF ; [then]
