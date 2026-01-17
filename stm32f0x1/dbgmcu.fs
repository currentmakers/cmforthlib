\
\ @file dbgmcu.fs
\ @brief Debug support
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] DBGMCU_DEF

  [ifdef] DBGMCU_IDCODE_DEF
    \
    \ @brief MCU Device ID Code Register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant DBGMCU_DEV_ID                  \ [0x00 : 12] Device Identifier
    $0c constant DBGMCU_DIV_ID                  \ [0x0c : 4] Division Identifier
    $10 constant DBGMCU_REV_ID                  \ [0x10 : 16] Revision Identifier
  [then]


  [ifdef] DBGMCU_CR_DEF
    \
    \ @brief Debug MCU Configuration Register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $01 constant DBGMCU_DBG_STOP                \ [0x01] Debug Stop Mode
    $02 constant DBGMCU_DBG_STANDBY             \ [0x02] Debug Standby Mode
  [then]


  [ifdef] DBGMCU_APB1_FZ_DEF
    \
    \ @brief Debug MCU APB1 freeze register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant DBGMCU_DBG_TIM2_STOP           \ [0x00] TIM2 counter stopped when core is halted
    $01 constant DBGMCU_DBG_TIM3_STOP           \ [0x01] TIM3 counter stopped when core is halted
    $04 constant DBGMCU_TIM3_counter_stopped_when_core_is_halted     \ [0x04] TIM6 counter stopped when core is halted
    $05 constant DBGMCU_DBG_TIM7_STOP           \ [0x05] TIM7 counter stopped when core is halted
    $08 constant DBGMCU_DBG_TIM14_STOP          \ [0x08] TIM14 counter stopped when core is halted
    $0a constant DBGMCU_DBG_RTC_STOP            \ [0x0a] Debug RTC stopped when core is halted
    $0b constant DBGMCU_DBG_WWDG_STOP           \ [0x0b] Debug window watchdog stopped when core is halted
    $0c constant DBGMCU_DBG_IWDG_STOP           \ [0x0c] Debug independent watchdog stopped when core is halted
    $15 constant DBGMCU_DBG_I2C1_SMBUS_TIMEOUT  \ [0x15] SMBUS timeout mode stopped when core is halted
    $19 constant DBGMCU_DBG_CAN_STOP            \ [0x19] CAN stopped when core is halted
  [then]


  [ifdef] DBGMCU_APB2_FZ_DEF
    \
    \ @brief Debug MCU APB2 freeze register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $0b constant DBGMCU_DBG_TIM1_STOP           \ [0x0b] TIM1 counter stopped when core is halted
    $10 constant DBGMCU_DBG_TIM15_STOP          \ [0x10] TIM15 counter stopped when core is halted
    $11 constant DBGMCU_DBG_TIM16_STOP          \ [0x11] TIM16 counter stopped when core is halted
    $12 constant DBGMCU_DBG_TIM17_STOP          \ [0x12] TIM17 counter stopped when core is halted
  [then]

  \
  \ @brief Debug support
  \
  $00 constant DBGMCU_IDCODE            \ MCU Device ID Code Register
  $04 constant DBGMCU_CR                \ Debug MCU Configuration Register
  $08 constant DBGMCU_APB1_FZ           \ Debug MCU APB1 freeze register
  $0C constant DBGMCU_APB2_FZ           \ Debug MCU APB2 freeze register

: DBGMCU_DEF ; [then]
