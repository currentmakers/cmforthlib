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
    $00 constant IWDG_KEY                       \ [0x00 : 16] Key value (write only, read 0x0000) These bits must be written by software at regular intervals with the key value 0xAAAA, otherwise the watchdog generates a reset when the counter reaches 0. Writing the key value 0x5555 to enable access to the IWDG_PR, IWDG_RLR and IWDG_WINR registers (see Section 22.3.4: Register access protection) Writing the key value 0xCCCC starts the watchdog (except if the hardware watchdog option is selected)
  [then]


  [ifdef] IWDG_IWDG_PR_DEF
    \
    \ @brief IWDG prescaler register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant IWDG_PR                        \ [0x00 : 3] Prescaler divider These bits are write access protected see Section 22.3.4: Register access protection. They are written by software to select the prescaler divider feeding the counter clock. PVU bit of the IWDG status register (IWDG_SR) must be reset in order to be able to change the prescaler divider. Note: Reading this register returns the prescaler value from the V<sub>DD</sub> voltage domain. This value may not be up to date/valid if a write operation to this register is ongoing. For this reason the value read from this register is valid only when the PVU bit in the IWDG status register (IWDG_SR) is reset.
  [then]


  [ifdef] IWDG_IWDG_RLR_DEF
    \
    \ @brief IWDG reload register
    \ Address offset: 0x08
    \ Reset value: 0x00000FFF
    \
    $00 constant IWDG_RL                        \ [0x00 : 12] Watchdog counter reload value These bits are write access protected see Register access protection. They are written by software to define the value to be loaded in the watchdog counter each time the value 0xAAAA is written in the IWDG key register (IWDG_KR). The watchdog counter counts down from this value. The timeout period is a function of this value and the clock prescaler. Refer to the datasheet for the timeout information. The RVU bit in the IWDG status register (IWDG_SR) must be reset to be able to change the reload value. Note: Reading this register returns the reload value from the V<sub>DD</sub> voltage domain. This value may not be up to date/valid if a write operation to this register is ongoing on it. For this reason the value read from this register is valid only when the RVU bit in the IWDG status register (IWDG_SR) is reset.
  [then]


  [ifdef] IWDG_IWDG_SR_DEF
    \
    \ @brief IWDG status register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant IWDG_PVU                       \ [0x00] Watchdog prescaler value update This bit is set by hardware to indicate that an update of the prescaler value is ongoing. It is reset by hardware when the prescaler update operation is completed in the V<sub>DD</sub> voltage domain (takes up to five LSI cycles). Prescaler value can be updated only when PVU bit is reset.
    $01 constant IWDG_RVU                       \ [0x01] Watchdog counter reload value update This bit is set by hardware to indicate that an update of the reload value is ongoing. It is reset by hardware when the reload value update operation is completed in the V<sub>DD</sub> voltage domain (takes up to five LSI cycles). Reload value can be updated only when RVU bit is reset.
    $02 constant IWDG_WVU                       \ [0x02] Watchdog counter window value update This bit is set by hardware to indicate that an update of the window value is ongoing. It is reset by hardware when the reload value update operation is completed in the V<sub>DD</sub> voltage domain (takes up to five LSI cycles). Window value can be updated only when WVU bit is reset.
  [then]


  [ifdef] IWDG_IWDG_WINR_DEF
    \
    \ @brief IWDG window register
    \ Address offset: 0x10
    \ Reset value: 0x00000FFF
    \
    $00 constant IWDG_WIN                       \ [0x00 : 12] Watchdog counter window value These bits are write access protected, see Section 22.3.4, they contain the high limit of the window value to be compared with the downcounter. To prevent a reset, the downcounter must be reloaded when its value is lower than the window register value and greater than 0x0 The WVU bit in the IWDG status register (IWDG_SR) must be reset in order to be able to change the reload value. Note: Reading this register returns the reload value from the V<sub>DD</sub> voltage domain. This value may not be valid if a write operation to this register is ongoing. For this reason the value read from this register is valid only when the WVU bit in the IWDG status register (IWDG_SR) is reset.
  [then]

  \
  \ @brief IWDG address block description
  \
  $00 constant IWDG_IWDG_KR             \ IWDG key register
  $04 constant IWDG_IWDG_PR             \ IWDG prescaler register
  $08 constant IWDG_IWDG_RLR            \ IWDG reload register
  $0C constant IWDG_IWDG_SR             \ IWDG status register
  $10 constant IWDG_IWDG_WINR           \ IWDG window register

: IWDG_DEF ; [then]
