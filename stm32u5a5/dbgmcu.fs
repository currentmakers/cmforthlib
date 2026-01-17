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
    \ Reset value: 0x30016481
    \
    $00 constant DBGMCU_DEV_ID                  \ [0x00 : 12] Device dentification
    $10 constant DBGMCU_REV_ID                  \ [0x10 : 16] Revision
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
    \ @brief Debug MCU APB1L peripheral freeze register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant DBGMCU_DBG_TIM2_STOP           \ [0x00] TIM2 stop in debug
    $01 constant DBGMCU_DBG_TIM3_STOP           \ [0x01] TIM3 stop in debug
    $02 constant DBGMCU_DBG_TIM4_STOP           \ [0x02] TIM4 stop in debug
    $03 constant DBGMCU_DBG_TIM5_STOP           \ [0x03] TIM5 stop in debug
    $04 constant DBGMCU_DBG_TIM6_STOP           \ [0x04] TIM6 stop in debug
    $05 constant DBGMCU_DBG_TIM7_STOP           \ [0x05] TIM7 stop in debug
    $0b constant DBGMCU_DBG_WWDG_STOP           \ [0x0b] Window watchdog counter stop in debug
    $0c constant DBGMCU_DBG_IWDG_STOP           \ [0x0c] Independent watchdog counter stop in debug
    $15 constant DBGMCU_DBG_I2C1_STOP           \ [0x15] I2C1 SMBUS timeout stop in debug
    $16 constant DBGMCU_DBG_I2C2_STOP           \ [0x16] I2C2 SMBUS timeout stop in debug
  [then]


  [ifdef] DBGMCU_APB1HFZR_DEF
    \
    \ @brief Debug MCU APB1H peripheral freeze register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $01 constant DBGMCU_DBG_I2C4_STOP           \ [0x01] I2C4 stop in debug
    $05 constant DBGMCU_DBG_LPTIM2_STOP         \ [0x05] LPTIM2 stop in debug
  [then]


  [ifdef] DBGMCU_APB2FZR_DEF
    \
    \ @brief Debug MCU APB2 peripheral freeze register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $0b constant DBGMCU_DBG_TIM1_STOP           \ [0x0b] TIM1 counter stopped when core is halted
    $0d constant DBGMCU_DBG_TIM8_STOP           \ [0x0d] TIM8 stop in debug
    $10 constant DBGMCU_DBG_TIM15_STOP          \ [0x10] TIM15 counter stopped when core is halted
    $11 constant DBGMCU_DBG_TIM16_STOP          \ [0x11] TIM16 counter stopped when core is halted
    $12 constant DBGMCU_DBG_TIM17_STOP          \ [0x12] DBG_TIM17_STOP
  [then]


  [ifdef] DBGMCU_APB3FZR_DEF
    \
    \ @brief Debug MCU APB3 peripheral freeze register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $0a constant DBGMCU_DBG_I2C3_STOP           \ [0x0a] I2C3 stop in debug
    $11 constant DBGMCU_DBG_LPTIM1_STOP         \ [0x11] LPTIM1 stop in debug
    $12 constant DBGMCU_DBG_LPTIM3_STOP         \ [0x12] LPTIM3 stop in debug
    $13 constant DBGMCU_DBG_LPTIM4_STOP         \ [0x13] LPTIM4 stop in debug
    $1e constant DBGMCU_DBG_RTC_STOP            \ [0x1e] RTC stop in debug
  [then]


  [ifdef] DBGMCU_AHB1FZR_DEF
    \
    \ @brief Debug MCU AHB1 peripheral freeze register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant DBGMCU_DBG_GPDMA0_STOP         \ [0x00] GPDMA channel 0 stop in debug
    $01 constant DBGMCU_DBG_GPDMA1_STOP         \ [0x01] GPDMA channel 1 stop in debug
    $02 constant DBGMCU_DBG_GPDMA2_STOP         \ [0x02] GPDMA channel 2 stop in debug
    $03 constant DBGMCU_DBG_GPDMA3_STOP         \ [0x03] GPDMA channel 3 stop in debug
    $04 constant DBGMCU_DBG_GPDMA4_STOP         \ [0x04] GPDMA channel 4 stop in debug
    $05 constant DBGMCU_DBG_GPDMA5_STOP         \ [0x05] GPDMA channel 5 stop in debug
    $06 constant DBGMCU_DBG_GPDMA6_STOP         \ [0x06] GPDMA channel 6 stop in debug
    $07 constant DBGMCU_DBG_GPDMA7_STOP         \ [0x07] GPDMA channel 7 stop in debug
    $08 constant DBGMCU_DBG_GPDMA8_STOP         \ [0x08] GPDMA channel 8 stop in debug
    $09 constant DBGMCU_DBG_GPDMA9_STOP         \ [0x09] GPDMA channel 9 stop in debug
    $0a constant DBGMCU_DBG_GPDMA10_STOP        \ [0x0a] GPDMA channel 10 stop in debug
    $0b constant DBGMCU_DBG_GPDMA11_STOP        \ [0x0b] GPDMA channel 11 stop in debug
    $0c constant DBGMCU_DBG_GPDMA12_STOP        \ [0x0c] GPDMA channel 12 stop in debug
    $0d constant DBGMCU_DBG_GPDMA13_STOP        \ [0x0d] GPDMA channel 13 stop in debug
    $0e constant DBGMCU_DBG_GPDMA14_STOP        \ [0x0e] GPDMA channel 14 stop in debug
    $0f constant DBGMCU_DBG_GPDMA15_STOP        \ [0x0f] GPDMA channel 15 stop in debug
  [then]


  [ifdef] DBGMCU_AHB3FZR_DEF
    \
    \ @brief Debug MCU AHB3 peripheral freeze register
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant DBGMCU_DBG_LPDMA0_STOP         \ [0x00] LPDMA channel 0 stop in debug
    $01 constant DBGMCU_DBG_LPDMA1_STOP         \ [0x01] LPDMA channel 1 stop in debug
    $02 constant DBGMCU_DBG_LPDMA2_STOP         \ [0x02] LPDMA channel 2 stop in debug
    $03 constant DBGMCU_DBG_LPDMA3_STOP         \ [0x03] LPDMA channel 3 stop in debug
  [then]


  [ifdef] DBGMCU_SR_DEF
    \
    \ @brief DBGMCU status register
    \ Address offset: 0xFC
    \ Reset value: 0x00000001
    \
    $00 constant DBGMCU_AP_PRESENT              \ [0x00 : 8] AP_PRESENT
    $08 constant DBGMCU_AP_LOCKED               \ [0x08 : 8] AP_LOCKED
  [then]


  [ifdef] DBGMCU_DBGMCU_DBG_AUTH_HOST_DEF
    \
    \ @brief DBGMCU debug host authentication register
    \ Address offset: 0x100
    \ Reset value: 0x00000000
    \
    $00 constant DBGMCU_AUTH_KEY                \ [0x00 : 32] AUTH_KEY
  [then]


  [ifdef] DBGMCU_DBG_AUTH_DEVICE_DEF
    \
    \ @brief DBGMCU debug device authentication register
    \ Address offset: 0x104
    \ Reset value: 0x00000000
    \
    $00 constant DBGMCU_AUTH_ID                 \ [0x00 : 16] AUTH_ID
  [then]


  [ifdef] DBGMCU_PIDR4_DEF
    \
    \ @brief Debug MCU CoreSight peripheral identity register 4
    \ Address offset: 0xFD0
    \ Reset value: 0x00000000
    \
    $00 constant DBGMCU_JEP106CON               \ [0x00 : 4] JEP106 continuation code
    $04 constant DBGMCU_KCOUNT_4                \ [0x04 : 4] register file size
  [then]


  [ifdef] DBGMCU_PIDR0_DEF
    \
    \ @brief Debug MCU CoreSight peripheral identity register 0
    \ Address offset: 0xFE0
    \ Reset value: 0x00000000
    \
    $00 constant DBGMCU_PARTNUM                 \ [0x00 : 8] part number bits [7:0]
  [then]


  [ifdef] DBGMCU_PIDR1_DEF
    \
    \ @brief Debug MCU CoreSight peripheral identity register 1
    \ Address offset: 0xFE4
    \ Reset value: 0x00000000
    \
    $00 constant DBGMCU_PARTNUM                 \ [0x00 : 4] part number bits [11:8]
    $04 constant DBGMCU_JEP106ID                \ [0x04 : 4] JEP106 identity code bits [3:0]
  [then]


  [ifdef] DBGMCU_PIDR2_DEF
    \
    \ @brief Debug MCU CoreSight peripheral identity register 2
    \ Address offset: 0xFE8
    \ Reset value: 0x0000000A
    \
    $00 constant DBGMCU_JEP106ID                \ [0x00 : 3] JEP106 identity code bits [6:4]
    $03 constant DBGMCU_JEDEC                   \ [0x03] JEDEC assigned value
    $04 constant DBGMCU_REVISION                \ [0x04 : 4] component revision number
  [then]


  [ifdef] DBGMCU_PIDR3_DEF
    \
    \ @brief Debug MCU CoreSight peripheral identity register 3
    \ Address offset: 0xFEC
    \ Reset value: 0x00000000
    \
    $00 constant DBGMCU_CMOD                    \ [0x00 : 4] customer modified
    $04 constant DBGMCU_REVAND                  \ [0x04 : 4] metal fix version
  [then]


  [ifdef] DBGMCU_CIDR0_DEF
    \
    \ @brief Debug MCU CoreSight component identity register 0
    \ Address offset: 0xFF0
    \ Reset value: 0x0000000D
    \
    $00 constant DBGMCU_PREAMBLE                \ [0x00 : 8] component identification bits [7:0]
  [then]


  [ifdef] DBGMCU_CIDR1_DEF
    \
    \ @brief Debug MCU CoreSight component identity register 1
    \ Address offset: 0xFF4
    \ Reset value: 0x000000F0
    \
    $00 constant DBGMCU_PREAMBLE                \ [0x00 : 4] component identification bits [11:8]
    $04 constant DBGMCU_CLASS                   \ [0x04 : 4] component identification bits [15:12] - component class
  [then]


  [ifdef] DBGMCU_CIDR2_DEF
    \
    \ @brief Debug MCU CoreSight component identity register 2
    \ Address offset: 0xFF8
    \ Reset value: 0x00000005
    \
    $00 constant DBGMCU_PREAMBLE                \ [0x00 : 8] component identification bits [23:16]
  [then]


  [ifdef] DBGMCU_CIDR3_DEF
    \
    \ @brief Debug MCU CoreSight component identity register 3
    \ Address offset: 0xFFC
    \ Reset value: 0x000000B1
    \
    $00 constant DBGMCU_PREAMBLE                \ [0x00 : 8] component identification bits [31:24]
  [then]

  \
  \ @brief MCU debug component
  \
  $00 constant DBGMCU_IDCODE            \ DBGMCU_IDCODE
  $04 constant DBGMCU_CR                \ Debug MCU configuration register
  $08 constant DBGMCU_APB1LFZR          \ Debug MCU APB1L peripheral freeze register
  $0C constant DBGMCU_APB1HFZR          \ Debug MCU APB1H peripheral freeze register
  $10 constant DBGMCU_APB2FZR           \ Debug MCU APB2 peripheral freeze register
  $14 constant DBGMCU_APB3FZR           \ Debug MCU APB3 peripheral freeze register
  $20 constant DBGMCU_AHB1FZR           \ Debug MCU AHB1 peripheral freeze register
  $28 constant DBGMCU_AHB3FZR           \ Debug MCU AHB3 peripheral freeze register
  $FC constant DBGMCU_SR                \ DBGMCU status register
  $100 constant DBGMCU_DBGMCU_DBG_AUTH_HOST    \ DBGMCU debug host authentication register
  $104 constant DBGMCU_DBG_AUTH_DEVICE  \ DBGMCU debug device authentication register
  $FD0 constant DBGMCU_PIDR4            \ Debug MCU CoreSight peripheral identity register 4
  $FE0 constant DBGMCU_PIDR0            \ Debug MCU CoreSight peripheral identity register 0
  $FE4 constant DBGMCU_PIDR1            \ Debug MCU CoreSight peripheral identity register 1
  $FE8 constant DBGMCU_PIDR2            \ Debug MCU CoreSight peripheral identity register 2
  $FEC constant DBGMCU_PIDR3            \ Debug MCU CoreSight peripheral identity register 3
  $FF0 constant DBGMCU_CIDR0            \ Debug MCU CoreSight component identity register 0
  $FF4 constant DBGMCU_CIDR1            \ Debug MCU CoreSight component identity register 1
  $FF8 constant DBGMCU_CIDR2            \ Debug MCU CoreSight component identity register 2
  $FFC constant DBGMCU_CIDR3            \ Debug MCU CoreSight component identity register 3

: DBGMCU_DEF ; [then]
