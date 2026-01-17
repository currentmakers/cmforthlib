\
\ @file dbg.fs
\ @brief Debug support
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] DBG_DEF

  [ifdef] DBG_DBGMCU_IDCODE_DEF
    \
    \ @brief IDCODE
    \ Address offset: 0x00
    \ Reset value: 0x10006411
    \
    $00 constant DBG_DEV_ID                     \ [0x00 : 12] DEV_ID
    $10 constant DBG_REV_ID                     \ [0x10 : 16] REV_ID
  [then]


  [ifdef] DBG_DBGMCU_CR_DEF
    \
    \ @brief Control Register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant DBG_DBG_SLEEP                  \ [0x00] DBG_SLEEP
    $01 constant DBG_DBG_STOP                   \ [0x01] DBG_STOP
    $02 constant DBG_DBG_STANDBY                \ [0x02] DBG_STANDBY
    $05 constant DBG_TRACE_IOEN                 \ [0x05] TRACE_IOEN
    $06 constant DBG_TRACE_MODE                 \ [0x06 : 2] TRACE_MODE
  [then]


  [ifdef] DBG_DBGMCU_APB1_FZ_DEF
    \
    \ @brief Debug MCU APB1 Freeze registe
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant DBG_DBG_TIM2_STOP              \ [0x00] DBG_TIM2_STOP
    $01 constant DBG_DBG_TIM3_STOP              \ [0x01] DBG_TIM3 _STOP
    $02 constant DBG_DBG_TIM4_STOP              \ [0x02] DBG_TIM4_STOP
    $03 constant DBG_DBG_TIM5_STOP              \ [0x03] DBG_TIM5_STOP
    $0a constant DBG_DBG_RTC_Stop               \ [0x0a] RTC stopped when Core is halted
    $0b constant DBG_DBG_WWDG_STOP              \ [0x0b] DBG_WWDG_STOP
    $0c constant DBG_DBG_IWDEG_STOP             \ [0x0c] DBG_IWDEG_STOP
    $15 constant DBG_DBG_I2C1_SMBUS_TIMEOUT     \ [0x15] DBG_J2C1_SMBUS_TIMEOUT
    $16 constant DBG_DBG_I2C2_SMBUS_TIMEOUT     \ [0x16] DBG_J2C2_SMBUS_TIMEOUT
    $17 constant DBG_DBG_I2C3SMBUS_TIMEOUT      \ [0x17] DBG_J2C3SMBUS_TIMEOUT
  [then]


  [ifdef] DBG_DBGMCU_APB2_FZ_DEF
    \
    \ @brief Debug MCU APB2 Freeze registe
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant DBG_DBG_TIM1_STOP              \ [0x00] TIM1 counter stopped when core is halted
    $10 constant DBG_DBG_TIM9_STOP              \ [0x10] TIM9 counter stopped when core is halted
    $11 constant DBG_DBG_TIM10_STOP             \ [0x11] TIM10 counter stopped when core is halted
    $12 constant DBG_DBG_TIM11_STOP             \ [0x12] TIM11 counter stopped when core is halted
  [then]

  \
  \ @brief Debug support
  \
  $00 constant DBG_DBGMCU_IDCODE        \ IDCODE
  $04 constant DBG_DBGMCU_CR            \ Control Register
  $08 constant DBG_DBGMCU_APB1_FZ       \ Debug MCU APB1 Freeze registe
  $0C constant DBG_DBGMCU_APB2_FZ       \ Debug MCU APB2 Freeze registe

: DBG_DEF ; [then]
