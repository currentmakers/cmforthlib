\
\ @file iwdg1.fs
\ @brief IWDG
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] IWDG1_DEF

  [ifdef] IWDG1_KR_DEF
    \
    \ @brief Key register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant IWDG1_KEY                      \ [0x00 : 16] Key value (write only, read 0x0000) These bits must be written by software at regular intervals with the key value 0xAAAA, otherwise the watchdog generates a reset when the counter reaches 0. Writing the key value 0x5555 to enable access to the IWDG_PR, IWDG_RLR and IWDG_WINR registers (see Section23.3.6: Register access protection) Writing the key value CCCCh starts the watchdog (except if the hardware watchdog option is selected)
  [then]


  [ifdef] IWDG1_PR_DEF
    \
    \ @brief Prescaler register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant IWDG1_PR                       \ [0x00 : 3] Prescaler divider These bits are write access protected see Section23.3.6: Register access protection. They are written by software to select the prescaler divider feeding the counter clock. PVU bit of IWDG_SR must be reset in order to be able to change the prescaler divider. Note: Reading this register returns the prescaler value from the VDD voltage domain. This value may not be up to date/valid if a write operation to this register is ongoing. For this reason the value read from this register is valid only when the PVU bit in the IWDG_SR register is reset.
  [then]


  [ifdef] IWDG1_RLR_DEF
    \
    \ @brief Reload register
    \ Address offset: 0x08
    \ Reset value: 0x00000FFF
    \
    $00 constant IWDG1_RL                       \ [0x00 : 12] Watchdog counter reload value These bits are write access protected see Section23.3.6. They are written by software to define the value to be loaded in the watchdog counter each time the value 0xAAAA is written in the IWDG_KR register. The watchdog counter counts down from this value. The timeout period is a function of this value and the clock prescaler. Refer to the datasheet for the timeout information. The RVU bit in the IWDG_SR register must be reset in order to be able to change the reload value. Note: Reading this register returns the reload value from the VDD voltage domain. This value may not be up to date/valid if a write operation to this register is ongoing on this register. For this reason the value read from this register is valid only when the RVU bit in the IWDG_SR register is reset.
  [then]


  [ifdef] IWDG1_SR_DEF
    \
    \ @brief Status register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant IWDG1_PVU                      \ [0x00] Watchdog prescaler value update This bit is set by hardware to indicate that an update of the prescaler value is ongoing. It is reset by hardware when the prescaler update operation is completed in the VDD voltage domain (takes up to 5 RC 40 kHz cycles). Prescaler value can be updated only when PVU bit is reset.
    $01 constant IWDG1_RVU                      \ [0x01] Watchdog counter reload value update This bit is set by hardware to indicate that an update of the reload value is ongoing. It is reset by hardware when the reload value update operation is completed in the VDD voltage domain (takes up to 5 RC 40 kHz cycles). Reload value can be updated only when RVU bit is reset.
    $02 constant IWDG1_WVU                      \ [0x02] Watchdog counter window value update This bit is set by hardware to indicate that an update of the window value is ongoing. It is reset by hardware when the reload value update operation is completed in the VDD voltage domain (takes up to 5 RC 40 kHz cycles). Window value can be updated only when WVU bit is reset. This bit is generated only if generic window = 1
  [then]


  [ifdef] IWDG1_WINR_DEF
    \
    \ @brief Window register
    \ Address offset: 0x10
    \ Reset value: 0x00000FFF
    \
    $00 constant IWDG1_WIN                      \ [0x00 : 12] Watchdog counter window value These bits are write access protected see Section23.3.6. These bits contain the high limit of the window value to be compared to the downcounter. To prevent a reset, the downcounter must be reloaded when its value is lower than the window register value and greater than 0x0 The WVU bit in the IWDG_SR register must be reset in order to be able to change the reload value. Note: Reading this register returns the reload value from the VDD voltage domain. This value may not be valid if a write operation to this register is ongoing. For this reason the value read from this register is valid only when the WVU bit in the IWDG_SR register is reset.
  [then]

  \
  \ @brief IWDG
  \
  $00 constant IWDG1_KR                 \ Key register
  $04 constant IWDG1_PR                 \ Prescaler register
  $08 constant IWDG1_RLR                \ Reload register
  $0C constant IWDG1_SR                 \ Status register
  $10 constant IWDG1_WINR               \ Window register

: IWDG1_DEF ; [then]
