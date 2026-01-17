\
\ @file iwdg.fs
\ @brief Independent watchdog
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
    $00 constant IWDG_KEY                       \ [0x00 : 16] Key value (write only, read 0x0000)
  [then]


  [ifdef] IWDG_IWDG_PR_DEF
    \
    \ @brief Prescaler register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant IWDG_PR                        \ [0x00 : 3] Prescaler divider These bits are write access protected see . They are written by software to select the prescaler divider feeding the counter clock. PVU bit of the must be reset in order to be able to change the prescaler divider. Note: Reading this register returns the prescaler value from the VDD voltage domain. This value may not be up to date/valid if a write operation to this register is ongoing. For this reason the value read from this register is valid only when the PVU bit in the status register (IWDG_SR) is reset.
  [then]


  [ifdef] IWDG_IWDG_RLR_DEF
    \
    \ @brief Reload register
    \ Address offset: 0x08
    \ Reset value: 0x00000FFF
    \
    $00 constant IWDG_RL                        \ [0x00 : 12] Watchdog counter reload value
  [then]


  [ifdef] IWDG_IWDG_SR_DEF
    \
    \ @brief Status register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant IWDG_PVU                       \ [0x00] Watchdog prescaler value update This bit is set by hardware to indicate that an update of the prescaler value is ongoing. It is reset by hardware when the prescaler update operation is completed in the VDD voltage domain (takes up to five LSI cycles). Prescaler value can be updated only when PVU bit is reset.
    $01 constant IWDG_RVU                       \ [0x01] Watchdog counter reload value update This bit is set by hardware to indicate that an update of the reload value is ongoing. It is reset by hardware when the reload value update operation is completed in the VDD voltage domain (takes up to five LSI cycles). Reload value can be updated only when RVU bit is reset.
    $02 constant IWDG_WVU                       \ [0x02] Watchdog counter window value update This bit is set by hardware to indicate that an update of the window value is ongoing. It is reset by hardware when the reload value update operation is completed in the VDD voltage domain (takes up to five LSI cycles). Window value can be updated only when WVU bit is reset.
  [then]


  [ifdef] IWDG_IWDG_WINR_DEF
    \
    \ @brief Window register
    \ Address offset: 0x10
    \ Reset value: 0x00000FFF
    \
    $00 constant IWDG_WIN                       \ [0x00 : 12] Watchdog counter window value
  [then]

  \
  \ @brief Independent watchdog
  \
  $00 constant IWDG_IWDG_KR             \ Key register
  $04 constant IWDG_IWDG_PR             \ Prescaler register
  $08 constant IWDG_IWDG_RLR            \ Reload register
  $0C constant IWDG_IWDG_SR             \ Status register
  $10 constant IWDG_IWDG_WINR           \ Window register

: IWDG_DEF ; [then]
