\
\ @file dbgmcu.fs
\ @brief DBGMCU register block
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] DBGMCU_DEF

  [ifdef] DBGMCU_DBGMCU_IDCODE_DEF
    \
    \ @brief DBGMCU device ID code register
    \ Address offset: 0x00
    \ Reset value: 0x00006000
    \
    $00 constant DBGMCU_DEV_ID                  \ [0x00 : 12] Device identifier This field indicates the device ID.
    $10 constant DBGMCU_REV_ID                  \ [0x10 : 16] Revision identifier This field indicates the revision of the device.
  [then]


  [ifdef] DBGMCU_DBGMCU_CR_DEF
    \
    \ @brief DBGMCU configuration register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $01 constant DBGMCU_DBG_STOP                \ [0x01] Debug Stop mode Debug options in Stop mode.
    $02 constant DBGMCU_DBG_STANDBY             \ [0x02] Debug Standby and Shutdown modes Debug options in Standby or Shutdown mode.
  [then]


  [ifdef] DBGMCU_DBGMCU_APB1FZR_DEF
    \
    \ @brief DBGMCU APB1 freeze register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant DBGMCU_DBG_TIM2_STOP           \ [0x00] TIM2 stop in debug
    $01 constant DBGMCU_DBG_TIM3_STOP           \ [0x01] TIM3 stop in debug
    $02 constant DBGMCU_DBG_TIM4_STOP           \ [0x02] TIM4 stop in debug
    $04 constant DBGMCU_DBG_TIM6_STOP           \ [0x04] TIM6 stop in debug
    $05 constant DBGMCU_DBG_TIM7_STOP           \ [0x05] TIM7 stop in debug
    $0a constant DBGMCU_DBG_RTC_STOP            \ [0x0a] RTC stop in debug
    $0b constant DBGMCU_DBG_WWDG_STOP           \ [0x0b] WWDG stop in debug
    $0c constant DBGMCU_DBG_IWDG_STOP           \ [0x0c] IWDG stop in debug
    $15 constant DBGMCU_DBG_I2C3_STOP           \ [0x15] I2C3 SMBUS timeout stop in debug
    $16 constant DBGMCU_DBG_I2C1_STOP           \ [0x16] I2C1 SMBUS timeout stop in debug
    $1e constant DBGMCU_DBG_LPTIM2_STOP         \ [0x1e] LPTIM2 stop in debug
    $1f constant DBGMCU_DBG_LPTIM1_STOP         \ [0x1f] LPTIM1 stop in debug
  [then]


  [ifdef] DBGMCU_DBGMCU_APB2FZR_DEF
    \
    \ @brief DBG APB2 freeze register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $0b constant DBGMCU_DBG_TIM1_STOP           \ [0x0b] TIM1 stop in debug
    $0f constant DBGMCU_DBG_TIM14_STOP          \ [0x0f] TIM14 stop in debug
    $10 constant DBGMCU_DBG_TIM15_STOP          \ [0x10] TIM15 stop in debug
    $11 constant DBGMCU_DBG_TIM16_STOP          \ [0x11] TIM16 stop in debug
  [then]


  [ifdef] DBGMCU_DBGMCU_SR_DEF
    \
    \ @brief DBGMCU status register
    \ Address offset: 0xFC
    \ Reset value: 0x00010003
    \
    $00 constant DBGMCU_AP1_PRESENT             \ [0x00] Identifies whether access port AP1 is present in device
    $01 constant DBGMCU_AP0_PRESENT             \ [0x01] Identifies whether access port AP0 is present in device
    $10 constant DBGMCU_AP1_ENABLED             \ [0x10] Identifies whether access port AP0 is open (can be accessed via the debug port) or locked (debug access to the AP is blocked)
    $11 constant DBGMCU_AP0_ENABLED             \ [0x11] Identifies whether access port AP0 is open (can be accessed via the debug port) or locked (debug access to the AP is blocked)
  [then]


  [ifdef] DBGMCU_DBGMCU_DBG_AUTH_HOST_DEF
    \
    \ @brief DBGMCU debug authentication mailbox host register
    \ Address offset: 0x100
    \ Reset value: 0x00000000
    \
    $00 constant DBGMCU_MESSAGE                 \ [0x00 : 32] Debug host to device mailbox message. During debug authentication the debug host communicates with the device via this register.
  [then]


  [ifdef] DBGMCU_DBGMCU_DBG_AUTH_DEVICE_DEF
    \
    \ @brief DBGMCU debug authentication mailbox device register
    \ Address offset: 0x104
    \ Reset value: 0x00000000
    \
    $00 constant DBGMCU_MESSAGE                 \ [0x00 : 32] Device to debug host mailbox message. During debug authentication the device communicates with the debug host via this register.
  [then]


  [ifdef] DBGMCU_DBGMCU_PIDR4_DEF
    \
    \ @brief DBGMCU CoreSight peripheral identity register 4
    \ Address offset: 0xFD0
    \ Reset value: 0x00000000
    \
    $00 constant DBGMCU_JEP106CON               \ [0x00 : 4] JEP106 continuation code
    $04 constant DBGMCU_SIZE                    \ [0x04 : 4] register file size
  [then]


  [ifdef] DBGMCU_DBGMCU_PIDR0_DEF
    \
    \ @brief DBGMCU CoreSight peripheral identity register 0
    \ Address offset: 0xFE0
    \ Reset value: 0x00000000
    \
    $00 constant DBGMCU_PARTNUM                 \ [0x00 : 8] part number bits [7:0]
  [then]


  [ifdef] DBGMCU_DBGMCU_PIDR1_DEF
    \
    \ @brief DBGMCU CoreSight peripheral identity register 1
    \ Address offset: 0xFE4
    \ Reset value: 0x00000000
    \
    $00 constant DBGMCU_PARTNUM                 \ [0x00 : 4] part number bits [11:8]
    $04 constant DBGMCU_JEP106ID                \ [0x04 : 4] JEP106 identity code bits [3:0]
  [then]


  [ifdef] DBGMCU_DBGMCU_PIDR2_DEF
    \
    \ @brief DBGMCU CoreSight peripheral identity register 2
    \ Address offset: 0xFE8
    \ Reset value: 0x0000000A
    \
    $00 constant DBGMCU_JEP106ID                \ [0x00 : 3] JEP106 identity code bits [6:4]
    $03 constant DBGMCU_JEDEC                   \ [0x03] JEDEC assigned value
    $04 constant DBGMCU_REVISION                \ [0x04 : 4] component revision number
  [then]


  [ifdef] DBGMCU_DBGMCU_PIDR3_DEF
    \
    \ @brief DBGMCU CoreSight peripheral identity register 3
    \ Address offset: 0xFEC
    \ Reset value: 0x00000000
    \
    $00 constant DBGMCU_CMOD                    \ [0x00 : 4] customer modified
    $04 constant DBGMCU_REVAND                  \ [0x04 : 4] metal fix version
  [then]


  [ifdef] DBGMCU_DBGMCU_CIDR0_DEF
    \
    \ @brief DBGMCU CoreSight component identity register 0
    \ Address offset: 0xFF0
    \ Reset value: 0x0000000D
    \
    $00 constant DBGMCU_PREAMBLE                \ [0x00 : 8] component identification bits [7:0]
  [then]


  [ifdef] DBGMCU_DBGMCU_CIDR1_DEF
    \
    \ @brief DBGMCU CoreSight component identity register 1
    \ Address offset: 0xFF4
    \ Reset value: 0x000000F0
    \
    $00 constant DBGMCU_PREAMBLE                \ [0x00 : 4] component identification bits [11:8]
    $04 constant DBGMCU_CLASS                   \ [0x04 : 4] component identification bits [15:12] - component class
  [then]


  [ifdef] DBGMCU_DBGMCU_CIDR2_DEF
    \
    \ @brief DBGMCU CoreSight component identity register 2
    \ Address offset: 0xFF8
    \ Reset value: 0x00000005
    \
    $00 constant DBGMCU_PREAMBLE                \ [0x00 : 8] component identification bits [23:16]
  [then]


  [ifdef] DBGMCU_DBGMCU_CIDR3_DEF
    \
    \ @brief DBGMCU CoreSight component identity register 3
    \ Address offset: 0xFFC
    \ Reset value: 0x000000B1
    \
    $00 constant DBGMCU_PREAMBLE                \ [0x00 : 8] component identification bits [31:24]
  [then]

  \
  \ @brief DBGMCU register block
  \
  $00 constant DBGMCU_DBGMCU_IDCODE     \ DBGMCU device ID code register
  $04 constant DBGMCU_DBGMCU_CR         \ DBGMCU configuration register
  $08 constant DBGMCU_DBGMCU_APB1FZR    \ DBGMCU APB1 freeze register
  $0C constant DBGMCU_DBGMCU_APB2FZR    \ DBG APB2 freeze register
  $FC constant DBGMCU_DBGMCU_SR         \ DBGMCU status register
  $100 constant DBGMCU_DBGMCU_DBG_AUTH_HOST    \ DBGMCU debug authentication mailbox host register
  $104 constant DBGMCU_DBGMCU_DBG_AUTH_DEVICE    \ DBGMCU debug authentication mailbox device register
  $FD0 constant DBGMCU_DBGMCU_PIDR4     \ DBGMCU CoreSight peripheral identity register 4
  $FE0 constant DBGMCU_DBGMCU_PIDR0     \ DBGMCU CoreSight peripheral identity register 0
  $FE4 constant DBGMCU_DBGMCU_PIDR1     \ DBGMCU CoreSight peripheral identity register 1
  $FE8 constant DBGMCU_DBGMCU_PIDR2     \ DBGMCU CoreSight peripheral identity register 2
  $FEC constant DBGMCU_DBGMCU_PIDR3     \ DBGMCU CoreSight peripheral identity register 3
  $FF0 constant DBGMCU_DBGMCU_CIDR0     \ DBGMCU CoreSight component identity register 0
  $FF4 constant DBGMCU_DBGMCU_CIDR1     \ DBGMCU CoreSight component identity register 1
  $FF8 constant DBGMCU_DBGMCU_CIDR2     \ DBGMCU CoreSight component identity register 2
  $FFC constant DBGMCU_DBGMCU_CIDR3     \ DBGMCU CoreSight component identity register 3

: DBGMCU_DEF ; [then]
