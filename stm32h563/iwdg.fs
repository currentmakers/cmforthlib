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
    \ @brief IWDG key register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant IWDG_KEY                       \ [0x00 : 16] Key value (write only, read 0x0000) These bits must be written by software at regular intervals with the key value 0xAAAA, otherwise the watchdog generates a reset when the counter reaches 0. Writing the key value 0x5555 to enable access to the IWDG_PR, IWDG_RLR and IWDG_WINR registers (see ) Writing the key value 0xCCCC starts the watchdog (except if the hardware watchdog option is selected)
  [then]


  [ifdef] IWDG_IWDG_PR_DEF
    \
    \ @brief IWDG prescaler register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant IWDG_PR                        \ [0x00 : 4] Prescaler divider These bits are write access protected see . They are written by software to select the prescaler divider feeding the counter clock. PVU bit of the must be reset in order to be able to change the prescaler divider. Others: divider / 1024 Note: Reading this register returns the prescaler value from the VDD voltage domain. This value may not be up to date/valid if a write operation to this register is ongoing. For this reason the value read from this register is valid only when the PVU bit in the status register (IWDG_SR) is reset.
  [then]


  [ifdef] IWDG_IWDG_RLR_DEF
    \
    \ @brief IWDG reload register
    \ Address offset: 0x08
    \ Reset value: 0x00000FFF
    \
    $00 constant IWDG_RL                        \ [0x00 : 12] Watchdog counter reload value These bits are write access protected see . They are written by software to define the value to be loaded in the watchdog counter each time the value 0xAAAA is written in the . The watchdog counter counts down from this value. The timeout period is a function of this value and the prescaler.clock. It is not recommended to set RL[11:0] to a value lower than 2. The RVU bit in the must be reset to be able to change the reload value. Note: Reading this register returns the reload value from the VDD voltage domain. This value may not be up to date/valid if a write operation to this register is ongoing on it. For this reason the value read from this register is valid only when the RVU bit in the status register (IWDG_SR) is reset.
  [then]


  [ifdef] IWDG_IWDG_SR_DEF
    \
    \ @brief IWDG status register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant IWDG_PVU                       \ [0x00] Watchdog prescaler value update This bit is set by hardware to indicate that an update of the prescaler value is ongoing. It is reset by hardware when the prescaler update operation is completed in the VDD voltage domain (takes up to three periods of the IWDG kernel clock iwdg_ker_ck). The prescaler value can be updated only when PVU bit is reset.
    $01 constant IWDG_RVU                       \ [0x01] Watchdog counter reload value update This bit is set by hardware to indicate that an update of the reload value is ongoing. It is reset by hardware when the reload value update operation is completed in the VDD voltage domain (takes up to three periods of the IWDG kernel clock iwdg_ker_ck). The reload value can be updated only when RVU bit is reset.
    $02 constant IWDG_WVU                       \ [0x02] Watchdog counter window value update This bit is set by hardware to indicate that an update of the window value is ongoing. It is reset by hardware when the reload value update operation is completed in the VDD voltage domain (takes up to three periods of the IWDG kernel clock iwdg_ker_ck). The window value can be updated only when WVU bit is reset. This bit is generated only if generic 'window' = 1
    $03 constant IWDG_EWU                       \ [0x03] Watchdog interrupt comparator value update This bit is set by hardware to indicate that an update of the interrupt comparator value (EWIT[11:0]) or an update of the EWIE is ongoing. It is reset by hardware when the update operation is completed in the VDD voltage domain (takes up to three periods of the IWDG kernel clock iwdg_ker_ck). The EWIT[11:0] and EWIE fields can be updated only when EWU bit is reset.
    $0e constant IWDG_EWIF                      \ [0x0e] Watchdog early interrupt flag This bit is set to '1' by hardware in order to indicate that an early interrupt is pending. This bit must be cleared by the software by writing the bit EWIC of IWDG_EWCR register to '1'.
  [then]


  [ifdef] IWDG_IWDG_WINR_DEF
    \
    \ @brief IWDG window register
    \ Address offset: 0x10
    \ Reset value: 0x00000FFF
    \
    $00 constant IWDG_WIN                       \ [0x00 : 12] Watchdog counter window value These bits are write access protected, see , they contain the high limit of the window value to be compared with the downcounter. To prevent a reset, the IWDCNT downcounter must be reloaded when its value is lower than WIN[11:0]+1 and greater than 1. The WVU bit in the must be reset to be able to change the reload value. Note: Reading this register returns the reload value from the VDD voltage domain. This value may not be valid if a write operation to this register is ongoing. For this reason the value read from this register is valid only when the WVU bit in the (IWDG_SR) is reset.
  [then]


  [ifdef] IWDG_IWDG_EWCR_DEF
    \
    \ @brief IWDG early wakeup interrupt register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant IWDG_EWIT                      \ [0x00 : 12] Watchdog counter window value These bits are write access protected (see ). They are written by software to define at which position of the IWDCNT down-counter the early wakeup interrupt must be generated. The early interrupt is generated when the IWDCNT is lower or equal to EWIT[11:0]1. EWIT[11:0] must be bigger than 1. An interrupt is generated only if EWIE = 1. The EWU bit in the must be reset to be able to change the reload value. Note: Reading this register returns the Early wakeup comparator value and the Interrupt enable bit from the VDD voltage domain. This value may not be up to date/valid if a write operation to this register is ongoing, hence the value read from this register is valid only when the EWU bit in the is reset.
    $0e constant IWDG_EWIC                      \ [0x0e] Watchdog early interrupt acknowledge The software must write a 1 into this bit in order to acknowledge the early wakeup interrupt and to clear the EWIF flag. Writing 0 has not effect, reading this flag returns a 0.
    $0f constant IWDG_EWIE                      \ [0x0f] Watchdog early interrupt enable Set and reset by software. The EWU bit in the must be reset to be able to change the value of this bit.
  [then]

  \
  \ @brief Independent watchdog
  \
  $00 constant IWDG_IWDG_KR             \ IWDG key register
  $04 constant IWDG_IWDG_PR             \ IWDG prescaler register
  $08 constant IWDG_IWDG_RLR            \ IWDG reload register
  $0C constant IWDG_IWDG_SR             \ IWDG status register
  $10 constant IWDG_IWDG_WINR           \ IWDG window register
  $14 constant IWDG_IWDG_EWCR           \ IWDG early wakeup interrupt register

: IWDG_DEF ; [then]
