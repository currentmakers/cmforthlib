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
    $00 constant DBGMCU_DBG_SLEEP               \ [0x00] Debug Sleep Mode
    $01 constant DBGMCU_DBG_STOP                \ [0x01] Debug Stop Mode
    $02 constant DBGMCU_DBG_STANDBY             \ [0x02] Debug Standby Mode
    $05 constant DBGMCU_TRACE_IOEN              \ [0x05] Trace port and clock enable
    $1c constant DBGMCU_TRGOEN                  \ [0x1c] External trigger output enable
  [then]


  [ifdef] DBGMCU_APB1FZR1_DEF
    \
    \ @brief APB1 Low Freeze Register CPU1
    \ Address offset: 0x3C
    \ Reset value: 0x00000000
    \
    $00 constant DBGMCU_DBG_TIMER2_STOP         \ [0x00] Debug Timer 2 stopped when Core is halted
    $0a constant DBGMCU_DBG_RTC_STOP            \ [0x0a] RTC counter stopped when core is halted
    $0b constant DBGMCU_DBG_WWDG_STOP           \ [0x0b] WWDG counter stopped when core is halted
    $0c constant DBGMCU_DBG_IWDG_STOP           \ [0x0c] IWDG counter stopped when core is halted
    $15 constant DBGMCU_DBG_I2C1_STOP           \ [0x15] Debug I2C1 SMBUS timeout stopped when Core is halted
    $17 constant DBGMCU_DBG_I2C3_STOP           \ [0x17] Debug I2C3 SMBUS timeout stopped when core is halted
    $1f constant DBGMCU_DBG_LPTIM1_STOP         \ [0x1f] Debug LPTIM1 stopped when Core is halted
  [then]


  [ifdef] DBGMCU_C2AP_B1FZR1_DEF
    \
    \ @brief APB1 Low Freeze Register CPU2
    \ Address offset: 0x40
    \ Reset value: 0x00000000
    \
    $00 constant DBGMCU_DBG_LPTIM2_STOP         \ [0x00] LPTIM2 counter stopped when core is halted
    $0a constant DBGMCU_DBG_RTC_STOP            \ [0x0a] RTC counter stopped when core is halted
    $0c constant DBGMCU_DBG_IWDG_STOP           \ [0x0c] IWDG stopped when core is halted
    $15 constant DBGMCU_DBG_I2C1_STOP           \ [0x15] I2C1 SMBUS timeout stopped when core is halted
    $17 constant DBGMCU_DBG_I2C3_STOP           \ [0x17] I2C3 SMBUS timeout stopped when core is halted
    $1f constant DBGMCU_DBG_LPTIM1_STOP         \ [0x1f] LPTIM1 counter stopped when core is halted
  [then]


  [ifdef] DBGMCU_APB1FZR2_DEF
    \
    \ @brief APB1 High Freeze Register CPU1
    \ Address offset: 0x44
    \ Reset value: 0x00000000
    \
    $05 constant DBGMCU_DBG_LPTIM2_STOP         \ [0x05] LPTIM2 counter stopped when core is halted
  [then]


  [ifdef] DBGMCU_C2APB1FZR2_DEF
    \
    \ @brief APB1 High Freeze Register CPU2
    \ Address offset: 0x48
    \ Reset value: 0x00000000
    \
    $05 constant DBGMCU_DBG_LPTIM2_STOP         \ [0x05] LPTIM2 counter stopped when core is halted
  [then]


  [ifdef] DBGMCU_C2APB2FZR_DEF
    \
    \ @brief APB2 Freeze Register CPU2
    \ Address offset: 0x48
    \ Reset value: 0x00000000
    \
    $0b constant DBGMCU_DBG_TIM1_STOP           \ [0x0b] TIM1 counter stopped when core is halted
    $11 constant DBGMCU_DBG_TIM16_STOP          \ [0x11] TIM16 counter stopped when core is halted
    $12 constant DBGMCU_DBG_TIM17_STOP          \ [0x12] TIM17 counter stopped when core is halted
  [then]


  [ifdef] DBGMCU_APB2FZR_DEF
    \
    \ @brief APB2 Freeze Register CPU1
    \ Address offset: 0x4C
    \ Reset value: 0x00000000
    \
    $0b constant DBGMCU_DBG_TIM1_STOP           \ [0x0b] TIM1 counter stopped when core is halted
    $11 constant DBGMCU_DBG_TIM16_STOP          \ [0x11] TIM16 counter stopped when core is halted
    $12 constant DBGMCU_DBG_TIM17_STOP          \ [0x12] TIM17 counter stopped when core is halted
  [then]

  \
  \ @brief Debug support
  \
  $00 constant DBGMCU_IDCODE            \ MCU Device ID Code Register
  $04 constant DBGMCU_CR                \ Debug MCU Configuration Register
  $3C constant DBGMCU_APB1FZR1          \ APB1 Low Freeze Register CPU1
  $40 constant DBGMCU_C2AP_B1FZR1       \ APB1 Low Freeze Register CPU2
  $44 constant DBGMCU_APB1FZR2          \ APB1 High Freeze Register CPU1
  $48 constant DBGMCU_C2APB1FZR2        \ APB1 High Freeze Register CPU2
  $48 constant DBGMCU_C2APB2FZR         \ APB2 Freeze Register CPU2
  $4C constant DBGMCU_APB2FZR           \ APB2 Freeze Register CPU1

: DBGMCU_DEF ; [then]
