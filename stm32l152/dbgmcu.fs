\
\ @file dbgmcu.fs
\ @brief debug support
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] DBGMCU_DEF

  [ifdef] DBGMCU_IDCODE_DEF
    \
    \ @brief DBGMCU_IDCODE
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant DBGMCU_DEV_ID                  \ [0x00 : 12] Device identifier
    $10 constant DBGMCU_REV_ID                  \ [0x10 : 16] Revision identifie
  [then]


  [ifdef] DBGMCU_CR_DEF
    \
    \ @brief Debug MCU configuration register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant DBGMCU_DBG_SLEEP               \ [0x00] Debug Sleep mode
    $01 constant DBGMCU_DBG_STOP                \ [0x01] Debug Stop mode
    $02 constant DBGMCU_DBG_STANDBY             \ [0x02] Debug Standby mode
    $05 constant DBGMCU_TRACE_IOEN              \ [0x05] Trace pin assignment control
    $06 constant DBGMCU_TRACE_MODE              \ [0x06 : 2] Trace pin assignment control
  [then]


  [ifdef] DBGMCU_APB1_FZ_DEF
    \
    \ @brief Debug MCU APB1 freeze register1
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant DBGMCU_DBG_TIM2_STOP           \ [0x00] TIM2 counter stopped when core is halted
    $01 constant DBGMCU_DBG_TIM3_STOP           \ [0x01] TIM3 counter stopped when core is halted
    $02 constant DBGMCU_DBG_TIM4_STOP           \ [0x02] TIM4 counter stopped when core is halted
    $03 constant DBGMCU_DBG_TIM5_STOP           \ [0x03] TIM5 counter stopped when core is halted
    $04 constant DBGMCU_DBG_TIM6_STOP           \ [0x04] TIM6 counter stopped when core is halted
    $05 constant DBGMCU_DBG_TIM7_STOP           \ [0x05] TIM7 counter stopped when core is halted
    $0a constant DBGMCU_DBG_RTC_STOP            \ [0x0a] Debug RTC stopped when core is halted
    $0b constant DBGMCU_DBG_WWDG_STOP           \ [0x0b] Debug window watchdog stopped when core is halted
    $0c constant DBGMCU_DBG_IWDG_STOP           \ [0x0c] Debug independent watchdog stopped when core is halted
    $15 constant DBGMCU_DBG_I2C1_SMBUS_TIMEOUT  \ [0x15] SMBUS timeout mode stopped when core is halted
    $16 constant DBGMCU_DBG_I2C2_SMBUS_TIMEOUT  \ [0x16] SMBUS timeout mode stopped when core is halted
  [then]


  [ifdef] DBGMCU_APB2_FZ_DEF
    \
    \ @brief Debug MCU APB1 freeze register 2
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $02 constant DBGMCU_DBG_TIM9_STOP           \ [0x02] TIM counter stopped when core is halted
    $03 constant DBGMCU_DBG_TIM10_STOP          \ [0x03] TIM counter stopped when core is halted
    $04 constant DBGMCU_DBG_TIM11_STOP          \ [0x04] TIM counter stopped when core is halted
  [then]

  \
  \ @brief debug support
  \
  $00 constant DBGMCU_IDCODE            \ DBGMCU_IDCODE
  $04 constant DBGMCU_CR                \ Debug MCU configuration register
  $08 constant DBGMCU_APB1_FZ           \ Debug MCU APB1 freeze register1
  $0C constant DBGMCU_APB2_FZ           \ Debug MCU APB1 freeze register 2

: DBGMCU_DEF ; [then]
