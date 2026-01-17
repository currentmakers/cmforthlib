\
\ @file dbgmcu.fs
\ @brief Microcontroller Debug Unit
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] DBGMCU_DEF

  [ifdef] DBGMCU_IDCODER_DEF
    \
    \ @brief DBGMCU Identity Code Register
    \ Address offset: 0x00
    \ Reset value: 0x10006497
    \
    $00 constant DBGMCU_DEV_ID                  \ [0x00 : 12] Device ID
    $10 constant DBGMCU_REV_ID                  \ [0x10 : 16] Revision
  [then]


  [ifdef] DBGMCU_CR_DEF
    \
    \ @brief DBGMCU Configuration Register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant DBGMCU_DBG_SLEEP               \ [0x00] Allow debug in SLEEP mode
    $01 constant DBGMCU_DBG_STOP                \ [0x01] Allow debug in STOP mode
    $02 constant DBGMCU_DBG_STANDBY             \ [0x02] Allow debug in STANDBY mode
  [then]


  [ifdef] DBGMCU_APB1FZR1_DEF
    \
    \ @brief DBGMCU CPU1 APB1 Peripheral Freeze Register 1
    \ Address offset: 0x3C
    \ Reset value: 0x00000000
    \
    $00 constant DBGMCU_DBG_TIM2_STOP           \ [0x00] TIM2 stop in CPU1 debug
    $0a constant DBGMCU_DBG_RTC_STOP            \ [0x0a] RTC stop in CPU1 debug
    $0b constant DBGMCU_DBG_WWDG_STOP           \ [0x0b] WWDG stop in CPU1 debug
    $0c constant DBGMCU_DBG_IWDG_STOP           \ [0x0c] IWDG stop in CPU1 debug
    $15 constant DBGMCU_DBG_I2C1_STOP           \ [0x15] I2C1 SMBUS timeout stop in CPU1 debug
    $16 constant DBGMCU_DBG_I2C2_STOP           \ [0x16] I2C2 SMBUS timeout stop in CPU1 debug
    $17 constant DBGMCU_DBG_I2C3_STOP           \ [0x17] I2C3 SMBUS timeout stop in CPU1 debug
    $1f constant DBGMCU_DBG_LPTIM1_STOP         \ [0x1f] LPTIM1 stop in CPU1 debug
  [then]


  [ifdef] DBGMCU_C2APB1FZR1_DEF
    \
    \ @brief DBGMCU CPU2 APB1 Peripheral Freeze Register 1 [dual core device
    \ Address offset: 0x40
    \ Reset value: 0x00000000
    \
    $00 constant DBGMCU_DBG_TIM2_STOP           \ [0x00] DBG_TIM2_STOP
    $0a constant DBGMCU_DBG_RTC_STOP            \ [0x0a] DBG_RTC_STOP
    $0c constant DBGMCU_DBG_IWDG_STOP           \ [0x0c] DBG_IWDG_STOP
    $15 constant DBGMCU_DBG_I2C1_STOP           \ [0x15] DBG_I2C1_STOP
    $16 constant DBGMCU_DBG_I2C2_STOP           \ [0x16] DBG_I2C2_STOP
    $17 constant DBGMCU_DBG_I2C3_STOP           \ [0x17] DBG_I2C3_STOP
    $1f constant DBGMCU_DBG_LPTIM1_STOP         \ [0x1f] DBG_LPTIM1_STOP
  [then]


  [ifdef] DBGMCU_APB1FZR2_DEF
    \
    \ @brief DBGMCU CPU1 APB1 Peripheral Freeze Register 2
    \ Address offset: 0x44
    \ Reset value: 0x00000000
    \
    $05 constant DBGMCU_DBG_LPTIM2_STOP         \ [0x05] DBG_LPTIM2_STOP
    $06 constant DBGMCU_DBG_LPTIM3_STOP         \ [0x06] DBG_LPTIM3_STOP
  [then]


  [ifdef] DBGMCU_C2APB1FZR2_DEF
    \
    \ @brief DBGMCU CPU2 APB1 Peripheral Freeze Register 2 [dual core device
    \ Address offset: 0x48
    \ Reset value: 0x00000000
    \
    $05 constant DBGMCU_DBG_LPTIM2_STOP         \ [0x05] DBG_LPTIM2_STOP
    $06 constant DBGMCU_DBG_LPTIM3_STOP         \ [0x06] DBG_LPTIM3_STOP
  [then]


  [ifdef] DBGMCU_APB2FZR_DEF
    \
    \ @brief DBGMCU CPU1 APB2 Peripheral Freeze Register
    \ Address offset: 0x4C
    \ Reset value: 0x00000000
    \
    $0b constant DBGMCU_DBG_TIM1_STOP           \ [0x0b] DBG_TIM1_STOP
    $11 constant DBGMCU_DBG_TIM16_STOP          \ [0x11] DBG_TIM16_STOP
    $12 constant DBGMCU_DBG_TIM17_STOP          \ [0x12] DBG_TIM17_STOP
  [then]


  [ifdef] DBGMCU_C2APB2FZR_DEF
    \
    \ @brief DBGMCU CPU2 APB2 Peripheral Freeze Register [dual core device
    \ Address offset: 0x50
    \ Reset value: 0x00000000
    \
    $0b constant DBGMCU_DBG_TIM1_STOP           \ [0x0b] DBG_TIM1_STOP
    $11 constant DBGMCU_DBG_TIM16_STOP          \ [0x11] DBG_TIM16_STOP
    $12 constant DBGMCU_DBG_TIM17_STOP          \ [0x12] DBG_TIM17_STOP
  [then]

  \
  \ @brief Microcontroller Debug Unit
  \
  $00 constant DBGMCU_IDCODER           \ DBGMCU Identity Code Register
  $04 constant DBGMCU_CR                \ DBGMCU Configuration Register
  $3C constant DBGMCU_APB1FZR1          \ DBGMCU CPU1 APB1 Peripheral Freeze Register 1
  $40 constant DBGMCU_C2APB1FZR1        \ DBGMCU CPU2 APB1 Peripheral Freeze Register 1 [dual core device
  $44 constant DBGMCU_APB1FZR2          \ DBGMCU CPU1 APB1 Peripheral Freeze Register 2
  $48 constant DBGMCU_C2APB1FZR2        \ DBGMCU CPU2 APB1 Peripheral Freeze Register 2 [dual core device
  $4C constant DBGMCU_APB2FZR           \ DBGMCU CPU1 APB2 Peripheral Freeze Register
  $50 constant DBGMCU_C2APB2FZR         \ DBGMCU CPU2 APB2 Peripheral Freeze Register [dual core device

: DBGMCU_DEF ; [then]
