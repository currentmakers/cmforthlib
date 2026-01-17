\
\ @file dbgmcu.fs
\ @brief Microcontroller Debug Unit
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] DBGMCU_DEF

  [ifdef] DBGMCU_IDC_DEF
    \
    \ @brief DBGMCU Identity Code Register
    \ Address offset: 0x00
    \ Reset value: 0x10006450
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
    $00 constant DBGMCU_DBGSLEEP_D1             \ [0x00] Allow D1 domain debug in Sleep mode
    $01 constant DBGMCU_DBGSTOP_D1              \ [0x01] Allow D1 domain debug in Stop mode
    $02 constant DBGMCU_DBGSTBY_D1              \ [0x02] Allow D1 domain debug in Standby mode
    $03 constant DBGMCU_DBGSLEEP_D2             \ [0x03] Allow D2 domain debug in Sleep mode
    $04 constant DBGMCU_DBGSTOP_D2              \ [0x04] Allow D2 domain debug in Stop mode
    $05 constant DBGMCU_DBGSTBY_D2              \ [0x05] Allow D2 domain debug in Standby mode
    $07 constant DBGMCU_DBGSTOP_D3              \ [0x07] Allow debug in D3 Stop mode
    $08 constant DBGMCU_DBGSTBY_D3              \ [0x08] Allow debug in D3 Standby mode
    $14 constant DBGMCU_TRACECLKEN              \ [0x14] Trace port clock enable
    $15 constant DBGMCU_D1DBGCKEN               \ [0x15] D1 debug clock enable
    $16 constant DBGMCU_D3DBGCKEN               \ [0x16] D3 debug clock enable
    $1c constant DBGMCU_TRGOEN                  \ [0x1c] External trigger output enable
  [then]


  [ifdef] DBGMCU_APB3FZ1_DEF
    \
    \ @brief DBGMCU APB3 peripheral freeze register
    \ Address offset: 0x34
    \ Reset value: 0x00000000
    \
    $06 constant DBGMCU_WWDG1                   \ [0x06] WWDG1 stop in debug
  [then]


  [ifdef] DBGMCU_APB1LFZ1_DEF
    \
    \ @brief DBGMCU APB1L peripheral freeze register
    \ Address offset: 0x3C
    \ Reset value: 0x00000000
    \
    $00 constant DBGMCU_DBG_TIM2                \ [0x00] TIM2 stop in debug
    $01 constant DBGMCU_DBG_TIM3                \ [0x01] TIM3 stop in debug
    $02 constant DBGMCU_DBG_TIM4                \ [0x02] TIM4 stop in debug
    $03 constant DBGMCU_DBG_TIM5                \ [0x03] TIM5 stop in debug
    $04 constant DBGMCU_DBG_TIM6                \ [0x04] TIM6 stop in debug
    $05 constant DBGMCU_DBG_TIM7                \ [0x05] TIM7 stop in debug
    $06 constant DBGMCU_DBG_TIM12               \ [0x06] TIM12 stop in debug
    $07 constant DBGMCU_DBG_TIM13               \ [0x07] TIM13 stop in debug
    $08 constant DBGMCU_DBG_TIM14               \ [0x08] TIM14 stop in debug
    $09 constant DBGMCU_DBG_LPTIM1              \ [0x09] LPTIM1 stop in debug
    $15 constant DBGMCU_DBG_I2C1                \ [0x15] I2C1 SMBUS timeout stop in debug
    $16 constant DBGMCU_DBG_I2C2                \ [0x16] I2C2 SMBUS timeout stop in debug
    $17 constant DBGMCU_DBG_I2C3                \ [0x17] I2C3 SMBUS timeout stop in debug
  [then]


  [ifdef] DBGMCU_APB2FZ1_DEF
    \
    \ @brief DBGMCU APB2 peripheral freeze register
    \ Address offset: 0x4C
    \ Reset value: 0x00000000
    \
    $00 constant DBGMCU_DBG_TIM1                \ [0x00] TIM1 stop in debug
    $01 constant DBGMCU_DBG_TIM8                \ [0x01] TIM8 stop in debug
    $10 constant DBGMCU_DBG_TIM15               \ [0x10] TIM15 stop in debug
    $11 constant DBGMCU_DBG_TIM16               \ [0x11] TIM16 stop in debug
    $12 constant DBGMCU_DBG_TIM17               \ [0x12] TIM17 stop in debug
    $1d constant DBGMCU_DBG_HRTIM               \ [0x1d] HRTIM stop in debug
  [then]


  [ifdef] DBGMCU_APB4FZ1_DEF
    \
    \ @brief DBGMCU APB4 peripheral freeze register
    \ Address offset: 0x54
    \ Reset value: 0x00000000
    \
    $07 constant DBGMCU_DBG_I2C4                \ [0x07] I2C4 SMBUS timeout stop in debug
    $09 constant DBGMCU_DBG_LPTIM2              \ [0x09] LPTIM2 stop in debug
    $0a constant DBGMCU_DBG_LPTIM3              \ [0x0a] LPTIM2 stop in debug
    $0b constant DBGMCU_DBG_LPTIM4              \ [0x0b] LPTIM4 stop in debug
    $0c constant DBGMCU_DBG_LPTIM5              \ [0x0c] LPTIM5 stop in debug
    $10 constant DBGMCU_DBG_RTC                 \ [0x10] RTC stop in debug
    $12 constant DBGMCU_DBG_WDGLSD1             \ [0x12] Independent watchdog for D1 stop in debug
  [then]

  \
  \ @brief Microcontroller Debug Unit
  \
  $00 constant DBGMCU_IDC               \ DBGMCU Identity Code Register
  $04 constant DBGMCU_CR                \ DBGMCU Configuration Register
  $34 constant DBGMCU_APB3FZ1           \ DBGMCU APB3 peripheral freeze register
  $3C constant DBGMCU_APB1LFZ1          \ DBGMCU APB1L peripheral freeze register
  $4C constant DBGMCU_APB2FZ1           \ DBGMCU APB2 peripheral freeze register
  $54 constant DBGMCU_APB4FZ1           \ DBGMCU APB4 peripheral freeze register

: DBGMCU_DEF ; [then]
