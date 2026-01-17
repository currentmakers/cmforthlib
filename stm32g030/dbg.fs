\
\ @file dbg.fs
\ @brief MCU debug component
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
    $00 constant DBG_DEV_ID                     \ [0x00 : 12] Device identifier
    $10 constant DBG_REV_ID                     \ [0x10 : 16] Revision identifie
  [then]


  [ifdef] DBG_CR_DEF
    \
    \ @brief Debug MCU configuration register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $01 constant DBG_DBG_STOP                   \ [0x01] Debug Stop mode
    $02 constant DBG_DBG_STANDBY                \ [0x02] Debug Standby mode
  [then]


  [ifdef] DBG_APB_FZ1_DEF
    \
    \ @brief Debug MCU APB1 freeze register1
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant DBG_DBG_TIM2_STOP              \ [0x00] TIM2 counter stopped when core is halted
    $01 constant DBG_DBG_TIM3_STOP              \ [0x01] TIM3 counter stopped when core is halted
    $0a constant DBG_DBG_RTC_STOP               \ [0x0a] RTC counter stopped when core is halted
    $0b constant DBG_DBG_WWDG_STOP              \ [0x0b] Window watchdog counter stopped when core is halted
    $0c constant DBG_DBG_IWDG_STOP              \ [0x0c] Independent watchdog counter stopped when core is halted
    $15 constant DBG_DBG_I2C1_STOP              \ [0x15] I2C1 SMBUS timeout counter stopped when core is halted
  [then]


  [ifdef] DBG_APB_FZ2_DEF
    \
    \ @brief Debug MCU APB1 freeze register 2
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $0b constant DBG_DBG_TIM1_STOP              \ [0x0b] TIM1 counter stopped when core is halted
    $0f constant DBG_DBG_TIM14_STOP             \ [0x0f] DBG_TIM14_STOP
    $11 constant DBG_DBG_TIM16_STOP             \ [0x11] DBG_TIM16_STOP
    $12 constant DBG_DBG_TIM17_STOP             \ [0x12] DBG_TIM17_STOP
  [then]

  \
  \ @brief MCU debug component
  \
  $00 constant DBG_IDCODE               \ DBGMCU_IDCODE
  $04 constant DBG_CR                   \ Debug MCU configuration register
  $08 constant DBG_APB_FZ1              \ Debug MCU APB1 freeze register1
  $0C constant DBG_APB_FZ2              \ Debug MCU APB1 freeze register 2

: DBG_DEF ; [then]
