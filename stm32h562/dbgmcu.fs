\
\ @file dbgmcu.fs
\ @brief Microcontroller debug unit
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] DBGMCU_DEF

  [ifdef] DBGMCU_DBGMCU_IDCODE_DEF
    \
    \ @brief DBGMCU identity code register
    \ Address offset: 0x00
    \ Reset value: 0x00006000
    \
    $00 constant DBGMCU_DEV_ID                  \ [0x00 : 12] device identification
    $10 constant DBGMCU_REV_ID                  \ [0x10 : 16] revision
  [then]


  [ifdef] DBGMCU_DBGMCU_CR_DEF
    \
    \ @brief DBGMCU configuration register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $01 constant DBGMCU_DBG_STOP                \ [0x01] Allows debug in Stop mode All clocks are disabled automatically in Stop mode. All active clocks and oscillators continue to run during Stop mode, allowing full debug capability. On exit from Stop mode, the clock settings are set to the Stop mode exit state.
    $02 constant DBGMCU_DBG_STANDBY             \ [0x02] Allows debug in Standby mode All clocks are disabled and the core powered down automatically in Standby mode. All active clocks and oscillators continue to run during Standby mode, and the core supply is maintained, allowing full debug capability. On exit from Standby mode, a system reset is performed.
    $04 constant DBGMCU_TRACE_IOEN              \ [0x04] trace pin enable
    $05 constant DBGMCU_TRACE_EN                \ [0x05] trace port and clock enable. This bit enables the trace port clock, TRACECK.
    $06 constant DBGMCU_TRACE_MODE              \ [0x06 : 2] trace pin assignment
    $10 constant DBGMCU_DCRT                    \ [0x10] Debug credentials reset type This bit selects which type of reset is used to revoke the debug authentication credentials
  [then]


  [ifdef] DBGMCU_DBGMCU_APB1LFZR_DEF
    \
    \ @brief DBGMCU APB1L peripheral freeze register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant DBGMCU_DBG_TIM2_STOP           \ [0x00] TIM2 stop in debug
    $01 constant DBGMCU_DBG_TIM3_STOP           \ [0x01] TIM3 stop in debug
    $02 constant DBGMCU_DBG_TIM4_STOP           \ [0x02] TIM4 stop in debug
    $03 constant DBGMCU_DBG_TIM5_STOP           \ [0x03] TIM5 stop in debug
    $04 constant DBGMCU_DBG_TIM6_STOP           \ [0x04] TIM6 stop in debug
    $05 constant DBGMCU_DBG_TIM7_STOP           \ [0x05] TIM7 stop in debug
    $06 constant DBGMCU_DBG_TIM12_STOP          \ [0x06] TIM12 stop in debug
    $07 constant DBGMCU_DBG_TIM13_STOP          \ [0x07] TIM13 stop in debug
    $08 constant DBGMCU_DBG_TIM14_STOP          \ [0x08] TIM14 stop in debug
    $0b constant DBGMCU_DBG_WWDG_STOP           \ [0x0b] WWDG stop in debug
    $0c constant DBGMCU_DBG_IWDG_STOP           \ [0x0c] IWDG stop in debug
    $15 constant DBGMCU_DBG_I2C1_STOP           \ [0x15] I2C1 SMBUS timeout stop in debug
    $16 constant DBGMCU_DBG_I2C2_STOP           \ [0x16] I2C2 SMBUS timeout stop in debug
    $17 constant DBGMCU_DBG_I3C1_STOP           \ [0x17] I3C1 SCL stall counter stop in debug
  [then]


  [ifdef] DBGMCU_DBGMCU_APB1HFZR_DEF
    \
    \ @brief DBGMCU APB1H peripheral freeze register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $05 constant DBGMCU_DBG_LPTIM2_STOP         \ [0x05] LPTIM2 stop in debug
  [then]


  [ifdef] DBGMCU_DBGMCU_APB2FZR_DEF
    \
    \ @brief DBGMCU APB2 peripheral freeze register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $0b constant DBGMCU_DBG_TIM1_STOP           \ [0x0b] TIM1 stop in debug
    $0d constant DBGMCU_DBG_TIM8_STOP           \ [0x0d] TIM8 stop in debug
    $10 constant DBGMCU_DBG_TIM15_STOP          \ [0x10] TIM15 stop in debug
    $11 constant DBGMCU_DBG_TIM16_STOP          \ [0x11] TIM16 stop in debug
    $12 constant DBGMCU_DBG_TIM17_STOP          \ [0x12] TIM17 stop in debug
  [then]


  [ifdef] DBGMCU_DBGMCU_APB3FZR_DEF
    \
    \ @brief DBGMCU APB3 peripheral freeze register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $0a constant DBGMCU_DBG_I2C3_STOP           \ [0x0a] I2C3 SMBUS timeout stop in debug
    $0b constant DBGMCU_DBG_I2C4_STOP           \ [0x0b] I2C4 SMBUS timeout stop in debug
    $11 constant DBGMCU_DBG_LPTIM1_STOP         \ [0x11] LPTIM1 stop in debug
    $12 constant DBGMCU_DBG_LPTIM3_STOP         \ [0x12] LPTIM3 stop in debug
    $13 constant DBGMCU_DBG_LPTIM4_STOP         \ [0x13] LPTIM4 stop in debug
    $14 constant DBGMCU_DBG_LPTIM5_STOP         \ [0x14] LPTIM5 stop in debug
    $15 constant DBGMCU_DBG_LPTIM6_STOP         \ [0x15] LPTIM6 stop in debug
    $1e constant DBGMCU_DBG_RTC_STOP            \ [0x1e] RTC stop in debug
  [then]


  [ifdef] DBGMCU_DBGMCU_AHB1FZR_DEF
    \
    \ @brief DBGMCU AHB1 peripheral freeze register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant DBGMCU_DBG_GPDMA1_0_STOP       \ [0x00] GPDMA1 channel 0 stop in debug
    $01 constant DBGMCU_DBG_GPDMA1_1_STOP       \ [0x01] GPDMA1 channel 1 stop in debug
    $02 constant DBGMCU_DBG_GPDMA1_2_STOP       \ [0x02] GPDMA1 channel 2 stop in debug
    $03 constant DBGMCU_DBG_GPDMA1_3_STOP       \ [0x03] GPDMA1 channel 3 stop in debug
    $04 constant DBGMCU_DBG_GPDMA1_4_STOP       \ [0x04] GPDMA1 channel 4 stop in debug
    $05 constant DBGMCU_DBG_GPDMA1_5_STOP       \ [0x05] GPDMA1 channel 5 stop in debug
    $06 constant DBGMCU_DBG_GPDMA1_6_STOP       \ [0x06] GPDMA1 channel 6 stop in debug
    $07 constant DBGMCU_DBG_GPDMA1_7_STOP       \ [0x07] GPDMA1 channel 7 stop in debug
    $08 constant DBGMCU_DBG_GPDMA1_8_STOP       \ [0x08] GPDMA1 channel 8 stop in debug
    $09 constant DBGMCU_DBG_GPDMA1_9_STOP       \ [0x09] GPDMA1 channel 9 stop in debug
    $0a constant DBGMCU_DBG_GPDMA1_10_STOP      \ [0x0a] GPDMA1 channel 10 stop in debug
    $0b constant DBGMCU_DBG_GPDMA1_11_STOP      \ [0x0b] GPDMA1 channel 11 stop in debug
    $0c constant DBGMCU_DBG_GPDMA1_12_STOP      \ [0x0c] GPDMA1 channel 12 stop in debug
    $0d constant DBGMCU_DBG_GPDMA1_13_STOP      \ [0x0d] GPDMA1 channel 13 stop in debug
    $0e constant DBGMCU_DBG_GPDMA1_14_STOP      \ [0x0e] GPDMA1 channel 14 stop in debug
    $0f constant DBGMCU_DBG_GPDMA1_15_STOP      \ [0x0f] GPDMA1 channel 15 stop in debug
    $10 constant DBGMCU_DBG_GPDMA2_0_STOP       \ [0x10] GPDMA2 channel 0 stop in debug
    $11 constant DBGMCU_DBG_GPDMA2_1_STOP       \ [0x11] GPDMA2 channel 1 stop in debug
    $12 constant DBGMCU_DBG_GPDMA2_2_STOP       \ [0x12] GPDMA2 channel 2 stop in debug
    $13 constant DBGMCU_DBG_GPDMA2_3_STOP       \ [0x13] GPDMA2 channel 3 stop in debug
    $14 constant DBGMCU_DBG_GPDMA2_4_STOP       \ [0x14] GPDMA2 channel 4 stop in debug
    $15 constant DBGMCU_DBG_GPDMA2_5_STOP       \ [0x15] GPDMA2 channel 5 stop in debug
    $16 constant DBGMCU_DBG_GPDMA2_6_STOP       \ [0x16] GPDMA2 channel 6 stop in debug
    $17 constant DBGMCU_DBG_GPDMA2_7_STOP       \ [0x17] GPDMA2 channel 7 stop in debug
    $18 constant DBGMCU_DBG_GPDMA2_8_STOP       \ [0x18] GPDMA2 channel 8 stop in debug
    $19 constant DBGMCU_DBG_GPDMA2_9_STOP       \ [0x19] GPDMA2 channel 9 stop in debug
    $1a constant DBGMCU_DBG_GPDMA2_10_STOP      \ [0x1a] GPDMA2 channel 10 stop in debug
    $1b constant DBGMCU_DBG_GPDMA2_11_STOP      \ [0x1b] GPDMA2 channel 11 stop in debug
    $1c constant DBGMCU_DBG_GPDMA2_12_STOP      \ [0x1c] GPDMA2 channel 12 stop in debug
    $1d constant DBGMCU_DBG_GPDMA2_13_STOP      \ [0x1d] GPDMA2 channel 13 stop in debug
    $1e constant DBGMCU_DBG_GPDMA2_14_STOP      \ [0x1e] GPDMA2 channel 14 stop in debug
    $1f constant DBGMCU_DBG_GPDMA2_15_STOP      \ [0x1f] GPDMA2 channel 15 stop in debug
  [then]


  [ifdef] DBGMCU_DBGMCU_SR_DEF
    \
    \ @brief DBGMCU status register
    \ Address offset: 0xFC
    \ Reset value: 0x00010003
    \
    $00 constant DBGMCU_AP_PRESENT              \ [0x00 : 16] Bit n identifies whether access port AP n is present in device Bit n = 0: APn absent Bit n = 1: APn present
    $10 constant DBGMCU_AP_ENABLED              \ [0x10 : 16] Bit n identifies whether access port AP n is open (can be accessed via the debug port) or locked (debug access to the AP is blocked) Bit n = 0: APn locked Bit n = 1: APn enabled
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


  [ifdef] DBGMCU_DBGMCU_DBG_AUTH_ACK_DEF
    \
    \ @brief DBGMCU debug authentication mailbox acknowledge register
    \ Address offset: 0x108
    \ Reset value: 0x00000000
    \
    $00 constant DBGMCU_HOST_ACK                \ [0x00] Host to device acknowledge. The device sets this bit to indicate that it has placed a message in the DBGMCU_DBG_AUTH_DEVICE register. It should be reset by the host after reading the message
    $01 constant DBGMCU_DEV_ACK                 \ [0x01] Device to device acknowledge. The host sets this bit to indicate that it has placed a message in the DBGMCU_DBG_AUTH_HOST register. It is reset by the device after reading the message
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
    $04 constant DBGMCU_CLASS                   \ [0x04 : 4] component identification bits [15:12] component class
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
  \ @brief Microcontroller debug unit
  \
  $00 constant DBGMCU_DBGMCU_IDCODE     \ DBGMCU identity code register
  $04 constant DBGMCU_DBGMCU_CR         \ DBGMCU configuration register
  $08 constant DBGMCU_DBGMCU_APB1LFZR   \ DBGMCU APB1L peripheral freeze register
  $0C constant DBGMCU_DBGMCU_APB1HFZR   \ DBGMCU APB1H peripheral freeze register
  $10 constant DBGMCU_DBGMCU_APB2FZR    \ DBGMCU APB2 peripheral freeze register
  $14 constant DBGMCU_DBGMCU_APB3FZR    \ DBGMCU APB3 peripheral freeze register
  $20 constant DBGMCU_DBGMCU_AHB1FZR    \ DBGMCU AHB1 peripheral freeze register
  $FC constant DBGMCU_DBGMCU_SR         \ DBGMCU status register
  $100 constant DBGMCU_DBGMCU_DBG_AUTH_HOST    \ DBGMCU debug authentication mailbox host register
  $104 constant DBGMCU_DBGMCU_DBG_AUTH_DEVICE    \ DBGMCU debug authentication mailbox device register
  $108 constant DBGMCU_DBGMCU_DBG_AUTH_ACK    \ DBGMCU debug authentication mailbox acknowledge register
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
