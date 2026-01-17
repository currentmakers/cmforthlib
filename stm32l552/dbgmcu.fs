\
\ @file dbgmcu.fs
\ @brief MCU debug component
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
    $01 constant DBGMCU_DBG_STOP                \ [0x01] Debug Stop mode
    $02 constant DBGMCU_DBG_STANDBY             \ [0x02] Debug Standby mode
    $04 constant DBGMCU_TRACE_IOEN              \ [0x04] Trace pin assignment control
    $05 constant DBGMCU_TRACE_EN                \ [0x05] trace port and clock enable
    $06 constant DBGMCU_TRACE_MODE              \ [0x06 : 2] Trace pin assignment control
  [then]


  [ifdef] DBGMCU_APB1LFZR_DEF
    \
    \ @brief Debug MCU APB1 freeze register1
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant DBGMCU_DBG_TIM2_STOP           \ [0x00] TIM2 counter stopped when core is halted
    $01 constant DBGMCU_DBG_TIM3_STOP           \ [0x01] TIM3 stop in debug
    $02 constant DBGMCU_DBG_TIM4_STOP           \ [0x02] TIM4 stop in debug
    $03 constant DBGMCU_DBG_TIM5_STOP           \ [0x03] TIM5 stop in debug
    $04 constant DBGMCU_DBG_TIM6_STOP           \ [0x04] TIM6 counter stopped when core is halted
    $05 constant DBGMCU_DBG_TIM7_STOP           \ [0x05] TIM7 counter stopped when core is halted
    $0a constant DBGMCU_DBG_RTC_STOP            \ [0x0a] RTC counter stopped when core is halted
    $0b constant DBGMCU_DBG_WWDG_STOP           \ [0x0b] Window watchdog counter stopped when core is halted
    $0c constant DBGMCU_DBG_IWDG_STOP           \ [0x0c] Independent watchdog counter stopped when core is halted
    $15 constant DBGMCU_DBG_I2C1_STOP           \ [0x15] I2C1 SMBUS timeout counter stopped when core is halted
    $16 constant DBGMCU_DBG_I2C2_STOP           \ [0x16] I2C2 SMBUS timeout counter stopped when core is halted
    $17 constant DBGMCU_DBG_I2C3_STOP           \ [0x17] I2C3 SMBUS timeout counter stopped when core is halted
    $1f constant DBGMCU_DBG_LPTIM1_STOP         \ [0x1f] LPTIM1 counter stopped when core is halted
  [then]


  [ifdef] DBGMCU_APB1HFZR_DEF
    \
    \ @brief Debug MCU APB1 freeze register 2
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $01 constant DBGMCU_DBG_I2C4_STOP           \ [0x01] I2C4 stop in debug
    $05 constant DBGMCU_DBG_LPTIM2_STOP         \ [0x05] LPTIM2 counter stopped when core is halted
    $06 constant DBGMCU_DBG_LPTIM3_STOP         \ [0x06] LPTIM3 stop in debug
  [then]


  [ifdef] DBGMCU_APB2FZR_DEF
    \
    \ @brief Debug MCU APB2 freeze register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $0b constant DBGMCU_DBG_TIM1_STOP           \ [0x0b] TIM1 counter stopped when core is halted
    $0d constant DBGMCU_DBG_TIM8_STOP           \ [0x0d] TIM8 stop in debug
    $10 constant DBGMCU_DBG_TIM15_STOP          \ [0x10] TIM15 counter stopped when core is halted
    $11 constant DBGMCU_DBG_TIM16_STOP          \ [0x11] TIM16 counter stopped when core is halted
    $12 constant DBGMCU_DBG_TIM17_STOP          \ [0x12] DBG_TIM17_STOP
  [then]

  \
  \ @brief MCU debug component
  \
  $00 constant DBGMCU_IDCODE            \ DBGMCU_IDCODE
  $04 constant DBGMCU_CR                \ Debug MCU configuration register
  $08 constant DBGMCU_APB1LFZR          \ Debug MCU APB1 freeze register1
  $0C constant DBGMCU_APB1HFZR          \ Debug MCU APB1 freeze register 2
  $10 constant DBGMCU_APB2FZR           \ Debug MCU APB2 freeze register

: DBGMCU_DEF ; [then]
