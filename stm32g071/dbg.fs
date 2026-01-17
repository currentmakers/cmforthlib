\
\ @file dbg.fs
\ @brief Debug support
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] DBG_DEF

  [ifdef] DBG_IDCODE_DEF
    \
    \ @brief MCU Device ID Code Register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant DBG_DEV_ID                     \ [0x00 : 16] Device Identifier
    $10 constant DBG_REV_ID                     \ [0x10 : 16] Revision Identifier
  [then]


  [ifdef] DBG_CR_DEF
    \
    \ @brief Debug MCU Configuration Register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $01 constant DBG_DBG_STOP                   \ [0x01] Debug Stop Mode
    $02 constant DBG_DBG_STANDBY                \ [0x02] Debug Standby Mode
  [then]


  [ifdef] DBG_APB_FZ1_DEF
    \
    \ @brief DBG APB freeze register 1
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant DBG_DBG_TIMER2_STOP            \ [0x00] Debug Timer 2 stopped when Core is halted
    $01 constant DBG_DBG_TIM3_STOP              \ [0x01] TIM3 counter stopped when core is halted
    $04 constant DBG_DBG_TIMER6_STOP            \ [0x04] Debug Timer 6 stopped when Core is halted
    $05 constant DBG_DBG_TIM7_STOP              \ [0x05] TIM7 counter stopped when core is halted
    $0a constant DBG_DBG_RTC_STOP               \ [0x0a] Debug RTC stopped when Core is halted
    $0b constant DBG_DBG_WWDG_STOP              \ [0x0b] Debug Window Wachdog stopped when Core is halted
    $0c constant DBG_DBG_IWDG_STOP              \ [0x0c] Debug Independent Wachdog stopped when Core is halted
    $15 constant DBG_DBG_I2C1_STOP              \ [0x15] I2C1 SMBUS timeout mode stopped when core is halted
    $1e constant DBG_DBG_LPTIM2_STOP            \ [0x1e] Clocking of LPTIMER2 counter when the core is halted
    $1f constant DBG_DBG_LPTIM1_STOP            \ [0x1f] Clocking of LPTIMER1 counter when the core is halted
  [then]


  [ifdef] DBG_APB_FZ2_DEF
    \
    \ @brief DBG APB freeze register 2
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $0b constant DBG_DBG_TIM1_STOP              \ [0x0b] DBG_TIM1_STOP
    $0f constant DBG_DBG_TIM14_STOP             \ [0x0f] DBG_TIM14_STOP
    $10 constant DBG_DBG_TIM15_STOP             \ [0x10] DBG_TIM15_STOP
    $11 constant DBG_DBG_TIM16_STOP             \ [0x11] DBG_TIM16_STOP
    $12 constant DBG_DBG_TIM17_STOP             \ [0x12] DBG_TIM17_STOP
  [then]

  \
  \ @brief Debug support
  \
  $00 constant DBG_IDCODE               \ MCU Device ID Code Register
  $04 constant DBG_CR                   \ Debug MCU Configuration Register
  $08 constant DBG_APB_FZ1              \ DBG APB freeze register 1
  $0C constant DBG_APB_FZ2              \ DBG APB freeze register 2

: DBG_DEF ; [then]
