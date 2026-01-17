\
\ @file iwdg.fs
\ @brief IWDG_KR register
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] IWDG_DEF

  [ifdef] IWDG_IWDG_KR_DEF
    \
    \ @brief IWDG_KR register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant IWDG_KEY                       \ [0x00 : 16] Key value. Software can only write these bits. Reading returns the reset value. These bits must be written by software at regular intervals with the key value 0xAAAA, otherwise the watchdog generates a reset when the counter reaches 0. Writing the key value 0x5555 to enables access to the IWDG_PR, IWDG_RLR and IWDG_WINR registers. Writing the key value CCCCh starts the watchdog
  [then]


  [ifdef] IWDG_IWDG_PR_DEF
    \
    \ @brief IWDG_PR register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant IWDG_PR                        \ [0x00 : 3] Prescaler divider. Set and reset by software. These bits are write access protected. They are written by software to select the prescaler divider feeding the counter clock. PVU bit of IWDG_SR must be reset in order to be able to change the prescaler divider. 000: divider/4 001: divider/8 010: divider/16 011: divider/32 100: divider/64 101: divider/128 110: divider/256 111: divider/256
  [then]


  [ifdef] IWDG_IWDG_RLR_DEF
    \
    \ @brief IWDG_RLR register
    \ Address offset: 0x08
    \ Reset value: 0x00000FFF
    \
    $00 constant IWDG_RL                        \ [0x00 : 12] Watchdog counter reload value. Set and reset by software. These bits are write access protected. They are written by software to define the value to be loaded in the watchdog counter each time the value 0xAAAA is written in the IWDG_KR register. The watchdog counter counts down from this value. The timeout period is a function of this value and the clock prescaler. The RVU bit in the IWDG_SR register must be reset in order to be able to change the reload value.
  [then]


  [ifdef] IWDG_IWDG_SR_DEF
    \
    \ @brief IWDG_SR register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant IWDG_PVU                       \ [0x00] Watchdog prescaler value update. Read only bit. This bit is set by hardware to indicate that an update of the prescaler value is ongoing. It is reset by hardware when the prescaler update operation is completed in the VDD voltage domain (takes up to 5 RC 40 kHz cycles). Prescaler value can be updated only when PVU bit is reset
    $01 constant IWDG_RVU                       \ [0x01] Watchdog counter reload value update. Read only bit. This bit is set by hardware to indicate that an update of the reload value is ongoing. It is reset by hardware when the reload value update operation is completed in the VDD voltage domain (takes up to 5 RC 40 kHz cycles). Reload value can be updated only when RVU bit is reset
    $02 constant IWDG_WVU                       \ [0x02] Watchdog counter window value update. Read only bit. This bit is set by hardware to indicate that an update of the window value is ongoing. It is reset by hardware when the reload value update operation is completed in the VDD voltage domain (takes up to 5 RC 40 kHz cycles). Window value can be updated only when WVU bit is reset. This bit is generated only if generic window = 1
  [then]


  [ifdef] IWDG_IWDG_WINR_DEF
    \
    \ @brief IWDG_WINR register
    \ Address offset: 0x10
    \ Reset value: 0x    NULL
    \
    $00 constant IWDG_WIN                       \ [0x00 : 12] Watchdog counter window value. Set and reset by software. These bits are write access protected. These bits contain the high limit of the window value to be compared to the downcounter. To prevent a reset, the downcounter must be reloaded when its value is lower than the window register value and greater than 0x0 The WVU bit in the IWDG_SR register must be reset in order to be able to change the reload value.
  [then]

  \
  \ @brief IWDG_KR register
  \
  $00 constant IWDG_IWDG_KR             \ IWDG_KR register
  $04 constant IWDG_IWDG_PR             \ IWDG_PR register
  $08 constant IWDG_IWDG_RLR            \ IWDG_RLR register
  $0C constant IWDG_IWDG_SR             \ IWDG_SR register
  $10 constant IWDG_IWDG_WINR           \ IWDG_WINR register

: IWDG_DEF ; [then]
