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
    $00 constant DBGMCU_DEV_ID                  \ [0x00 : 16] Device Identifier
    $10 constant DBGMCU_REV_ID                  \ [0x10 : 16] Revision Identifier
  [then]


  [ifdef] DBGMCU_CR_DEF
    \
    \ @brief Debug MCU Configuration Register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant DBGMCU_DBG_SLEEP               \ [0x00] Debug Sleep Mode
    $01 constant DBGMCU_DBG_STOP                \ [0x01] Debug Stop Mode
    $02 constant DBGMCU_DBG_STANDBY             \ [0x02] Debug Standby Mode
    $05 constant DBGMCU_TRACE_IOEN              \ [0x05] Trace pin assignment control
    $06 constant DBGMCU_TRACE_MODE              \ [0x06 : 2] Trace pin assignment control
  [then]


  [ifdef] DBGMCU_APB1_FZR1_DEF
    \
    \ @brief APB Low Freeze Register 1
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant DBGMCU_DBG_TIMER2_STOP         \ [0x00] Debug Timer 2 stopped when Core is halted
    $01 constant DBGMCU_DBG_TIM3_STOP           \ [0x01] TIM3 counter stopped when core is halted
    $02 constant DBGMCU_DBG_TIM4_STOP           \ [0x02] TIM4 counter stopped when core is halted
    $03 constant DBGMCU_DBG_TIM5_STOP           \ [0x03] TIM5 counter stopped when core is halted
    $04 constant DBGMCU_DBG_TIMER6_STOP         \ [0x04] Debug Timer 6 stopped when Core is halted
    $05 constant DBGMCU_DBG_TIM7_STOP           \ [0x05] TIM7 counter stopped when core is halted
    $0a constant DBGMCU_DBG_RTC_STOP            \ [0x0a] Debug RTC stopped when Core is halted
    $0b constant DBGMCU_DBG_WWDG_STOP           \ [0x0b] Debug Window Wachdog stopped when Core is halted
    $0c constant DBGMCU_DBG_IWDG_STOP           \ [0x0c] Debug Independent Wachdog stopped when Core is halted
    $15 constant DBGMCU_DBG_I2C1_STOP           \ [0x15] I2C1 SMBUS timeout mode stopped when core is halted
    $16 constant DBGMCU_DBG_I2C2_STOP           \ [0x16] I2C2 SMBUS timeout mode stopped when core is halted
    $17 constant DBGMCU_DBG_I2C3_STOP           \ [0x17] I2C3 SMBUS timeout counter stopped when core is halted
    $19 constant DBGMCU_DBG_CAN_STOP            \ [0x19] bxCAN stopped when core is halted
    $1f constant DBGMCU_DBG_LPTIMER_STOP        \ [0x1f] LPTIM1 counter stopped when core is halted
  [then]


  [ifdef] DBGMCU_APB1_FZR2_DEF
    \
    \ @brief APB Low Freeze Register 2
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $05 constant DBGMCU_DBG_LPTIM2_STOP         \ [0x05] LPTIM2 counter stopped when core is halted
  [then]


  [ifdef] DBGMCU_APB2_FZR_DEF
    \
    \ @brief APB High Freeze Register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $0b constant DBGMCU_DBG_TIM1_STOP           \ [0x0b] TIM1 counter stopped when core is halted
    $0d constant DBGMCU_DBG_TIM8_STOP           \ [0x0d] TIM8 counter stopped when core is halted
    $10 constant DBGMCU_DBG_TIM15_STOP          \ [0x10] TIM15 counter stopped when core is halted
    $11 constant DBGMCU_DBG_TIM16_STOP          \ [0x11] TIM16 counter stopped when core is halted
    $12 constant DBGMCU_DBG_TIM17_STOP          \ [0x12] TIM17 counter stopped when core is halted
  [then]

  \
  \ @brief Debug support
  \
  $00 constant DBGMCU_IDCODE            \ MCU Device ID Code Register
  $04 constant DBGMCU_CR                \ Debug MCU Configuration Register
  $08 constant DBGMCU_APB1_FZR1         \ APB Low Freeze Register 1
  $0C constant DBGMCU_APB1_FZR2         \ APB Low Freeze Register 2
  $10 constant DBGMCU_APB2_FZR          \ APB High Freeze Register

: DBGMCU_DEF ; [then]
