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
    $00 constant DBG_DEV_ID                     \ [0x00 : 12] Device Identifier
    $10 constant DBG_REV_ID                     \ [0x10 : 16] Revision Identifier
  [then]


  [ifdef] DBG_DBG_CR_DEF
    \
    \ @brief DBG configuration register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $01 constant DBG_DBG_STOP                   \ [0x01] Debug Stop mode Debug options in Stop mode. Upon Stop mode exit, the software must re-establish the desired clock configuration.
    $02 constant DBG_DBG_STANDBY                \ [0x02] Debug Standby and Shutdown modes Debug options in Standby or Shutdown mode.
  [then]


  [ifdef] DBG_DBG_APB_FZ1_DEF
    \
    \ @brief DBG APB freeze register 1
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $01 constant DBG_DBG_TIM3_STOP              \ [0x01] Clocking of TIM3 counter when the core is halted This bit enables/disables the clock to the counter of TIM3 when the core is halted:
    $04 constant DBG_DBG_TIM6_STOP              \ [0x04] Clocking of TIM6 counter when the core is halted This bit enables/disables the clock to the counter of TIM6 when the core is halted:
    $05 constant DBG_DBG_TIM7_STOP              \ [0x05] Clocking of TIM7 counter when the core is halted. This bit enables/disables the clock to the counter of ITIM7 when the core is halted:
    $0a constant DBG_DBG_RTC_STOP               \ [0x0a] Clocking of RTC counter when the core is halted This bit enables/disables the clock to the counter of RTC when the core is halted:
    $0b constant DBG_DBG_WWDG_STOP              \ [0x0b] Clocking of WWDG counter when the core is halted This bit enables/disables the clock to the counter of WWDG when the core is halted:
    $0c constant DBG_DBG_IWDG_STOP              \ [0x0c] Clocking of IWDG counter when the core is halted This bit enables/disables the clock to the counter of IWDG when the core is halted:
    $15 constant DBG_DBG_I2C1_SMBUS_TIMEOUT     \ [0x15] SMBUS timeout when core is halted
    $16 constant DBG_DBG_I2C2_SMBUS_TIMEOUT     \ [0x16] SMBUS timeout when core is halted
  [then]


  [ifdef] DBG_DBG_APB_FZ2_DEF
    \
    \ @brief DBG APB freeze register 2
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $0b constant DBG_DBG_TIM1_STOP              \ [0x0b] Clocking of TIM1 counter when the core is halted This bit enables/disables the clock to the counter of TIM1 when the core is halted:
    $0f constant DBG_DBG_TIM14_STOP             \ [0x0f] Clocking of TIM14 counter when the core is halted This bit enables/disables the clock to the counter of TIM14 when the core is halted:
    $10 constant DBG_DBG_TIM15_STOP             \ [0x10] Clocking of TIM15 counter when the core is halted This bit enables/disables the clock to the counter of TIM15 when the core is halted: Only available on STM32G071xx and STM32G081xx, reserved on STM32G031xx and STM32G041xx.
    $11 constant DBG_DBG_TIM16_STOP             \ [0x11] Clocking of TIM16 counter when the core is halted This bit enables/disables the clock to the counter of TIM16 when the core is halted:
    $12 constant DBG_DBG_TIM17_STOP             \ [0x12] Clocking of TIM17 counter when the core is halted This bit enables/disables the clock to the counter of TIM17 when the core is halted:
  [then]

  \
  \ @brief Debug support
  \
  $00 constant DBG_IDCODE               \ MCU Device ID Code Register
  $04 constant DBG_DBG_CR               \ DBG configuration register
  $08 constant DBG_DBG_APB_FZ1          \ DBG APB freeze register 1
  $0C constant DBG_DBG_APB_FZ2          \ DBG APB freeze register 2

: DBG_DEF ; [then]
