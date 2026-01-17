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
    $0b constant DBG_DBG_TIM2_STOP              \ [0x0b] DBG_TIM2_STOP
    $0c constant DBG_DBG_TIM3_STOP              \ [0x0c] DBG_TIM3_STOP
    $0f constant DBG_DBG_I2C1_SMBUS_TIMEOUT     \ [0x0f] DBG_I2C1_SMBUS_TIMEOUT
  [then]

  \
  \ @brief Debug support
  \
  $00 constant DBG_IDCODE               \ DBGMCU_IDCODE
  $04 constant DBG_CR                   \ DBGMCU_CR

: DBG_DEF ; [then]
