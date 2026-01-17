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
    $10 constant DBGMCU_REV_ID                  \ [0x10 : 16] Revision Identifier
  [then]


  [ifdef] DBGMCU_CR_DEF
    \
    \ @brief Debug MCU Configuration Register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant DBGMCU_DBG_SLEEP               \ [0x00] Debug Sleep mode
    $01 constant DBGMCU_DBG_STOP                \ [0x01] Debug Stop Mode
    $02 constant DBGMCU_DBG_STANDBY             \ [0x02] Debug Standby Mode
    $05 constant DBGMCU_TRACE_IOEN              \ [0x05] Trace pin assignment control
    $06 constant DBGMCU_TRACE_MODE              \ [0x06 : 2] Trace pin assignment control
  [then]


  [ifdef] DBGMCU_APB1FZ_DEF
    \
    \ @brief APB Low Freeze Register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant DBGMCU_DBG_TIM2_STOP           \ [0x00] Debug Timer 2 stopped when Core is halted
    $01 constant DBGMCU_DBG_TIM3_STOP           \ [0x01] Debug Timer 3 stopped when Core is halted
    $02 constant DBGMCU_DBG_TIM4_STOP           \ [0x02] Debug Timer 4 stopped when Core is halted
    $03 constant DBGMCU_DBG_TIM5_STOP           \ [0x03] Debug Timer 5 stopped when Core is halted
    $04 constant DBGMCU_DBG_TIM6_STOP           \ [0x04] Debug Timer 6 stopped when Core is halted
    $05 constant DBGMCU_DBG_TIM7_STOP           \ [0x05] Debug Timer 7 stopped when Core is halted
    $06 constant DBGMCU_DBG_TIM12_STOP          \ [0x06] Debug Timer 12 stopped when Core is halted
    $07 constant DBGMCU_DBG_TIM13_STOP          \ [0x07] Debug Timer 13 stopped when Core is halted
    $08 constant DBGMCU_DBG_TIMER14_STOP        \ [0x08] Debug Timer 14 stopped when Core is halted
    $09 constant DBGMCU_DBG_TIM18_STOP          \ [0x09] Debug Timer 18 stopped when Core is halted
    $0a constant DBGMCU_DBG_RTC_STOP            \ [0x0a] Debug RTC stopped when Core is halted
    $0b constant DBGMCU_DBG_WWDG_STOP           \ [0x0b] Debug Window Wachdog stopped when Core is halted
    $0c constant DBGMCU_DBG_IWDG_STOP           \ [0x0c] Debug Independent Wachdog stopped when Core is halted
    $15 constant DBGMCU_I2C1_SMBUS_TIMEOUT      \ [0x15] SMBUS timeout mode stopped when Core is halted
    $16 constant DBGMCU_I2C2_SMBUS_TIMEOUT      \ [0x16] SMBUS timeout mode stopped when Core is halted
    $19 constant DBGMCU_DBG_CAN_STOP            \ [0x19] Debug CAN stopped when core is halted
  [then]


  [ifdef] DBGMCU_APB2FZ_DEF
    \
    \ @brief APB High Freeze Register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $02 constant DBGMCU_DBG_TIM15_STOP          \ [0x02] Debug Timer 15 stopped when Core is halted
    $03 constant DBGMCU_DBG_TIM16_STOP          \ [0x03] Debug Timer 16 stopped when Core is halted
    $04 constant DBGMCU_DBG_TIM17_STO           \ [0x04] Debug Timer 17 stopped when Core is halted
    $05 constant DBGMCU_DBG_TIM19_STOP          \ [0x05] Debug Timer 19 stopped when Core is halted
  [then]

  \
  \ @brief Debug support
  \
  $00 constant DBGMCU_IDCODE            \ MCU Device ID Code Register
  $04 constant DBGMCU_CR                \ Debug MCU Configuration Register
  $08 constant DBGMCU_APB1FZ            \ APB Low Freeze Register
  $0C constant DBGMCU_APB2FZ            \ APB High Freeze Register

: DBGMCU_DEF ; [then]
