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
    $00 constant IWDG_KEY                       \ [0x00 : 16] Key value (write only, read 0x0000) These bits can be used for several functions, depending upon the value written by the application: - 0xAAAA: reloads the RL[11:0] value into the IWDCNT down-counter (watchdog refresh), and write-protects registers. This value must be written by software at regular intervals, otherwise the watchdog generates a reset when the counter reaches 0. - 0x5555: enables write-accesses to the registers. - 0xCCCC: enables the watchdog (except if the hardware watchdog option is selected) and write-protects registers. - values different from 0x5555: write-protects registers. Note that only IWDG_PR, IWDG_RLR, IWDG_EWCR and IWDG_WINR registers have a write-protection mechanism.
  [then]


  [ifdef] IWDG_IWDG_PR_DEF
    \
    \ @brief IWDG prescaler register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant IWDG_PR                        \ [0x00 : 4] Prescaler divider These bits are write access protected, see Section126.4.6. They are written by software to select the prescaler divider feeding the counter clock. PVU bit of the IWDG status register (IWDG_SR) must be reset to be able to change the prescaler divider. Others: divider / 1024 Note: Reading this register returns the prescaler value from the V<sub>DD</sub> voltage domain. This value may not be up to date/valid if a write operation to this register is ongoing. For this reason the value read from this register is valid only when the PVU bit in the IWDG status register (IWDG_SR) is reset.
  [then]


  [ifdef] IWDG_IWDG_RLR_DEF
    \
    \ @brief IWDG reload register
    \ Address offset: 0x08
    \ Reset value: 0x00000FFF
    \
    $00 constant IWDG_RL                        \ [0x00 : 12] Watchdog counter reload value These bits are write access protected, see Section126.4.6. They are written by software to define the value to be loaded in the watchdog counter each time the value 0xAAAA is written in the IWDG key register (IWDG_KR). The watchdog counter counts down from this value. The timeout period is a function of this value and the prescaler.clock. It is not recommended to set RL[11:0] to a value lower than 2. The RVU bit in the IWDG status register (IWDG_SR) must be reset to be able to change the reload value. Note: Reading this register returns the reload value from the V<sub>DD</sub> voltage domain. This value may not be up to date/valid if a write operation to this register is ongoing, hence the value read from this register is valid only when the RVU bit in the IWDG status register (IWDG_SR) is reset.
  [then]


  [ifdef] IWDG_IWDG_SR_DEF
    \
    \ @brief IWDG status register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant IWDG_PVU                       \ [0x00] Watchdog prescaler value update This bit is set by hardware to indicate that an update of the prescaler value is ongoing. It is reset by hardware when the prescaler update operation is completed in the V<sub>DD</sub> voltage domain (takes up to six periods of the IWDG kernel clock iwdg_ker_ck). The prescaler value can be updated only when PVU bit is reset.
    $01 constant IWDG_RVU                       \ [0x01] Watchdog counter reload value update This bit is set by hardware to indicate that an update of the reload value is ongoing. It is reset by hardware when the reload value update operation is completed in the V<sub>DD</sub> voltage domain (takes up to six periods of the IWDG kernel clock iwdg_ker_ck). The reload value can be updated only when RVU bit is reset.
    $02 constant IWDG_WVU                       \ [0x02] Watchdog counter window value update This bit is set by hardware to indicate that an update of the window value is ongoing. It is reset by hardware when the reload value update operation is completed in the V<sub>DD</sub> voltage domain (takes up to one period of presc_ck and two periods of the IWDG kernel clock iwdg_ker_ck). The window value can be updated only when WVU bit is reset. This bit is generated only if generic window = 1.
    $03 constant IWDG_EWU                       \ [0x03] Watchdog interrupt comparator value update This bit is set by hardware to indicate that an update of the interrupt comparator value (EWIT[11:0]) or an update of the EWIE is ongoing. It is reset by hardware when the update operation is completed in the V<sub>DD</sub> voltage domain (takes up to one period of presc_ck and two periods of the IWDG kernel clock iwdg_ker_ck). The EWIT[11:0] and EWIE fields can be updated only when EWU bit is reset.
    $08 constant IWDG_ONF                       \ [0x08] Watchdog enable status bit Set to 1 by hardware as soon as the IWDG is started. In software mode, it remains to '1' until the IWDG is reset. In hardware mode, this bit is always set to '1'.
    $0e constant IWDG_EWIF                      \ [0x0e] Watchdog early interrupt flag This bit is set to 1 by hardware in order to indicate that an early interrupt is pending. This bit must be cleared by the software by writing the bit EWIC of IWDG_EWCR register to 1.
  [then]


  [ifdef] IWDG_IWDG_WINR_DEF
    \
    \ @brief IWDG window register
    \ Address offset: 0x10
    \ Reset value: 0x00000FFF
    \
    $00 constant IWDG_WIN                       \ [0x00 : 12] Watchdog counter window value These bits are write access protected, see Section126.4.6.They contain the high limit of the window value to be compared with the downcounter. To prevent a reset, the IWDCNT downcounter must be reloaded when its value is lower than WIN[11:0]1+11 and greater than 1. The WVU bit in the IWDG status register (IWDG_SR) must be reset to be able to change the reload value. Note: Reading this register returns the reload value from the V<sub>DD</sub> voltage domain. This value may not be valid if a write operation to this register is ongoing. For this reason the value read from this register is valid only when the WVU bit in the IWDG status register (IWDG_SR) is reset.
  [then]


  [ifdef] IWDG_IWDG_EWCR_DEF
    \
    \ @brief IWDG early wake-up interrupt register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant IWDG_EWIT                      \ [0x00 : 12] Watchdog counter window value These bits are write access protected (see Section126.4.6). They are written by software to define at which position of the IWDCNT down-counter the early wake-up interrupt must be generated. The early interrupt is generated when the IWDCNT is lower or equal to EWIT[11:0]1-11. EWIT[11:0] must be bigger than 1. An interrupt is generated only if EWIE = 1. The EWU bit in the IWDG status register (IWDG_SR) must be reset to be able to change the reload value. Note: Reading this register returns the Early wake-up comparator value and the Interrupt enable bit from the V<sub>DD</sub> voltage domain. This value may not be up to date/valid if a write operation to this register is ongoing, hence the value read from this register is valid only when the EWU bit in the IWDG status register (IWDG_SR) is reset.
    $0e constant IWDG_EWIC                      \ [0x0e] Watchdog early interrupt acknowledge The software must write a 1 into this bit in order to acknowledge the early wake-up interrupt and to clear the EWIF flag. Writing 0 has not effect, reading this flag returns a 0.
    $0f constant IWDG_EWIE                      \ [0x0f] Watchdog early interrupt enable Set and reset by software. The EWU bit in the IWDG status register (IWDG_SR) must be reset to be able to change the value of this bit.
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
