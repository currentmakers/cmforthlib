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
    \ @brief DBGMCU_IDCODE
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant DBG_DEV_ID                     \ [0x00 : 12] DEV_ID
    $10 constant DBG_REV_ID                     \ [0x10 : 16] REV_ID
  [then]


  [ifdef] DBG_CR_DEF
    \
    \ @brief DBGMCU_CR
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant DBG_DBG_SLEEP                  \ [0x00] DBG_SLEEP
    $01 constant DBG_DBG_STOP                   \ [0x01] DBG_STOP
    $02 constant DBG_DBG_STANDBY                \ [0x02] DBG_STANDBY
    $05 constant DBG_TRACE_IOEN                 \ [0x05] TRACE_IOEN
    $06 constant DBG_TRACE_MODE                 \ [0x06 : 2] TRACE_MODE
    $08 constant DBG_DBG_IWDG_STOP              \ [0x08] DBG_IWDG_STOP
    $09 constant DBG_DBG_WWDG_STOP              \ [0x09] DBG_WWDG_STOP
    $0a constant DBG_DBG_TIM1_STOP              \ [0x0a] DBG_TIM1_STOP
    $0b constant DBG_DBG_TIM2_STOP              \ [0x0b] DBG_TIM2_STOP
    $0c constant DBG_DBG_TIM3_STOP              \ [0x0c] DBG_TIM3_STOP
    $0d constant DBG_DBG_TIM4_STOP              \ [0x0d] DBG_TIM4_STOP
    $0f constant DBG_DBG_I2C1_SMBUS_TIMEOUT     \ [0x0f] DBG_I2C1_SMBUS_TIMEOUT
    $10 constant DBG_DBG_I2C2_SMBUS_TIMEOUT     \ [0x10] DBG_I2C2_SMBUS_TIMEOUT
    $12 constant DBG_DBG_TIM5_STOP              \ [0x12] DBG_TIM5_STOP
    $13 constant DBG_DBG_TIM6_STOP              \ [0x13] DBG_TIM6_STOP
    $14 constant DBG_DBG_TIM7_STOP              \ [0x14] DBG_TIM7_STOP
    $16 constant DBG_DBG_TIM15_STOP             \ [0x16] DBG_TIM15_STOP
    $17 constant DBG_DBG_TIM16_STOP             \ [0x17] DBG_TIM16_STOP
    $18 constant DBG_DBG_TIM17_STOP             \ [0x18] DBG_TIM17_STOP
    $19 constant DBG_DBG_TIM12_STOP             \ [0x19] DBG_TIM12_STOP
    $1a constant DBG_DBG_TIM13_STOP             \ [0x1a] DBG_TIM13_STOP
    $1b constant DBG_DBG_TIM14_STOP             \ [0x1b] DBG_TIM14_STOP
  [then]

  \
  \ @brief Debug support
  \
  $00 constant DBG_IDCODE               \ DBGMCU_IDCODE
  $04 constant DBG_CR                   \ DBGMCU_CR

: DBG_DEF ; [then]
