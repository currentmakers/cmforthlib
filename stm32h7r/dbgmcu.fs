\
\ @file dbgmcu.fs
\ @brief Microcontroller debug unit
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] DBGMCU_DEF

  [ifdef] DBGMCU_DBGMCU_IDC_DEF
    \
    \ @brief DBGMCU identity code register
    \ Address offset: 0x00
    \ Reset value: 0x00006485
    \
    $00 constant DBGMCU_DEV_ID                  \ [0x00 : 12] Device ID
    $10 constant DBGMCU_REV_ID                  \ [0x10 : 16] Revision
  [then]


  [ifdef] DBGMCU_DBGMCU_CR_DEF
    \
    \ @brief DBGMCU configuration register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant DBGMCU_DBGSLEEP                \ [0x00] Debug in Sleep mode enable
    $01 constant DBGMCU_DBGSTOP                 \ [0x01] Debug in Stop mode enable
    $02 constant DBGMCU_DBGSTBY                 \ [0x02] Debug in Standby mode enable
    $10 constant DBGMCU_DCRT                    \ [0x10] Debug credentials reset type This bit selects which type of reset is used to revoke the debug authentication credentials
    $14 constant DBGMCU_TRACECLKEN              \ [0x14] Trace port clock enable. This bit enables the trace port clock, TRACECLK.
    $15 constant DBGMCU_D1DBGCKEN               \ [0x15] D1 debug clock enable This bit allows the debug components in the D1 clock domain (excluding those in the processor core) to be switched off if they are not needed.
    $1c constant DBGMCU_TRGOEN                  \ [0x1c] External trigger output enable This bit controls the direction of the bi-directional trigger pin, TRGIO.
  [then]


  [ifdef] DBGMCU_DBGMCU_AHB5FZR_DEF
    \
    \ @brief DBGMCU AHB5 peripheral freeze register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant DBGMCU_DBG_HPDMA_0_STOP        \ [0x00] HPDMA channel 0 stop in debug
    $01 constant DBGMCU_DBG_HPDMA_1_STOP        \ [0x01] HPDMA channel 1 stop in debug
    $02 constant DBGMCU_DBG_HPDMA_2_STOP        \ [0x02] HPDMA channel 2 stop in debug
    $03 constant DBGMCU_DBG_HPDMA_3_STOP        \ [0x03] HPDMA channel 3 stop in debug
    $04 constant DBGMCU_DBG_HPDMA_4_STOP        \ [0x04] HPDMA channel 4 stop in debug
    $05 constant DBGMCU_DBG_HPDMA_5_STOP        \ [0x05] HPDMA channel 5 stop in debug
    $06 constant DBGMCU_DBG_HPDMA_6_STOP        \ [0x06] HPDMA channel 6 stop in debug
    $07 constant DBGMCU_DBG_HPDMA_7_STOP        \ [0x07] HPDMA channel 7 stop in debug
    $08 constant DBGMCU_DBG_HPDMA_8_STOP        \ [0x08] HPDMA channel 8 stop in debug
    $09 constant DBGMCU_DBG_HPDMA_9_STOP        \ [0x09] HPDMA channel 9 stop in debug
    $0a constant DBGMCU_DBG_HPDMA_10_STOP       \ [0x0a] HPDMA channel 10 stop in debug
    $0b constant DBGMCU_DBG_HPDMA_11_STOP       \ [0x0b] HPDMA channel 11 stop in debug
    $0c constant DBGMCU_DBG_HPDMA_12_STOP       \ [0x0c] HPDMA channel 12 stop in debug
    $0d constant DBGMCU_DBG_HPDMA_13_STOP       \ [0x0d] HPDMA channel 13 stop in debug
    $0e constant DBGMCU_DBG_HPDMA_14_STOP       \ [0x0e] HPDMA channel 14 stop in debug
    $0f constant DBGMCU_DBG_HPDMA_15_STOP       \ [0x0f] HPDMA channel 15 stop in debug
  [then]


  [ifdef] DBGMCU_DBGMCU_AHB1FZR_DEF
    \
    \ @brief DBGMCU AHB1 peripheral freeze register
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant DBGMCU_DBG_GPDMA_0_STOP        \ [0x00] GPDMA channel 0 stop in debug
    $01 constant DBGMCU_DBG_GPDMA_1_STOP        \ [0x01] GPDMA channel 1 stop in debug
    $02 constant DBGMCU_DBG_GPDMA_2_STOP        \ [0x02] GPDMA channel 2 stop in debug
    $03 constant DBGMCU_DBG_GPDMA_3_STOP        \ [0x03] GPDMA channel 3 stop in debug
    $04 constant DBGMCU_DBG_GPDMA_4_STOP        \ [0x04] GPDMA channel 4 stop in debug
    $05 constant DBGMCU_DBG_GPDMA_5_STOP        \ [0x05] GPDMA channel 5 stop in debug
    $06 constant DBGMCU_DBG_GPDMA_6_STOP        \ [0x06] GPDMA channel 6 stop in debug
    $07 constant DBGMCU_DBG_GPDMA_7_STOP        \ [0x07] GPDMA channel 7 stop in debug
    $08 constant DBGMCU_DBG_GPDMA_8_STOP        \ [0x08] GPDMA channel 8 stop in debug
    $09 constant DBGMCU_DBG_GPDMA_9_STOP        \ [0x09] GPDMA channel 9 stop in debug
    $0a constant DBGMCU_DBG_GPDMA_10_STOP       \ [0x0a] GPDMA channel 10 stop in debug
    $0b constant DBGMCU_DBG_GPDMA_11_STOP       \ [0x0b] GPDMA channel 11 stop in debug
    $0c constant DBGMCU_DBG_GPDMA_12_STOP       \ [0x0c] GPDMA channel 12 stop in debug
    $0d constant DBGMCU_DBG_GPDMA_13_STOP       \ [0x0d] GPDMA channel 13 stop in debug
    $0e constant DBGMCU_DBG_GPDMA_14_STOP       \ [0x0e] GPDMA channel 14 stop in debug
    $0f constant DBGMCU_DBG_GPDMA_15_STOP       \ [0x0f] GPDMA channel 15 stop in debug
  [then]


  [ifdef] DBGMCU_DBGMCU_APB1FZR_DEF
    \
    \ @brief DBGMCU APB1 peripheral freeze register
    \ Address offset: 0x3C
    \ Reset value: 0x00000000
    \
    $00 constant DBGMCU_TIM2                    \ [0x00] TIM2 stop in debug
    $01 constant DBGMCU_TIM3                    \ [0x01] TIM3 stop in debug
    $02 constant DBGMCU_TIM4                    \ [0x02] TIM4 stop in debug
    $03 constant DBGMCU_TIM5                    \ [0x03] TIM5 stop in debug
    $04 constant DBGMCU_TIM6                    \ [0x04] TIM6 stop in debug
    $05 constant DBGMCU_TIM7                    \ [0x05] TIM7 stop in debug
    $06 constant DBGMCU_TIM12                   \ [0x06] TIM12 stop in debug
    $07 constant DBGMCU_TIM13                   \ [0x07] TIM13 stop in debug
    $08 constant DBGMCU_TIM14                   \ [0x08] TIM14 stop in debug
    $09 constant DBGMCU_LPTIM1                  \ [0x09] LPTIM1 stop in debug
    $0b constant DBGMCU_WWDG                    \ [0x0b] WWDG stop in debug
    $15 constant DBGMCU_I2C1                    \ [0x15] I2C1 SMBUS timeout stop in debug
    $16 constant DBGMCU_I2C2                    \ [0x16] I2C2 SMBUS timeout stop in debug
    $17 constant DBGMCU_I2C3                    \ [0x17] I2C3 SMBUS timeout stop in debug
  [then]


  [ifdef] DBGMCU_DBGMCU_APB2FZ_DEF
    \
    \ @brief DBGMCU APB2 peripheral freeze register
    \ Address offset: 0x4C
    \ Reset value: 0x00000000
    \
    $00 constant DBGMCU_TIM1                    \ [0x00] TIM1 stop in debug
    $10 constant DBGMCU_TIM15                   \ [0x10] TIM15 stop in debug
    $11 constant DBGMCU_TIM16                   \ [0x11] TIM16 stop in debug
    $12 constant DBGMCU_TIM17                   \ [0x12] TIM17 stop in debug
    $13 constant DBGMCU_TIM9                    \ [0x13] TIM9 stop in debug
  [then]


  [ifdef] DBGMCU_DBGMCU_APB4FZR_DEF
    \
    \ @brief DBGMCU APB4 peripheral freeze register
    \ Address offset: 0x54
    \ Reset value: 0x00000000
    \
    $09 constant DBGMCU_LPTIM2                  \ [0x09] LPTIM2 stop in debug
    $0a constant DBGMCU_LPTIM3                  \ [0x0a] LPTIM2 stop in debug
    $0b constant DBGMCU_LPTIM4                  \ [0x0b] LPTIM4 stop in debug
    $0c constant DBGMCU_LPTIM5                  \ [0x0c] LPTIM5 stop in debug
    $10 constant DBGMCU_RTC                     \ [0x10] RTC stop in debug
    $12 constant DBGMCU_IWDG                    \ [0x12] Independent watchdog for stop in debug
  [then]


  [ifdef] DBGMCU_DBGMCU_SR_DEF
    \
    \ @brief DBGMCU status register
    \ Address offset: 0xFC
    \ Reset value: 0x00010003
    \
    $00 constant DBGMCU_AP_PRESENT              \ [0x00 : 16] Bit n identifies whether access port AP n is open (can be accessed via the debug port) or locked (debug access to the AP is blocked) Bit n = 0: APn absent Bit n = 1: APn present
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
    \ @brief DBGMCU peripheral identity register 4
    \ Address offset: 0xFD0
    \ Reset value: 0x00000000
    \
    $00 constant DBGMCU_JEP106CON               \ [0x00 : 4] JEP106 continuation code
    $04 constant DBGMCU_SIZE                    \ [0x04 : 4] Register file size
  [then]


  [ifdef] DBGMCU_DBGMCU_PIDR0_DEF
    \
    \ @brief DBGMCU peripheral identity register 0
    \ Address offset: 0xFE0
    \ Reset value: 0x00000000
    \
    $00 constant DBGMCU_PARTNUM                 \ [0x00 : 8] Part number field, bits [7:0]
  [then]


  [ifdef] DBGMCU_DBGMCU_PIDR1_DEF
    \
    \ @brief DBGMCU peripheral identity register 1
    \ Address offset: 0xFE4
    \ Reset value: 0x00000000
    \
    $00 constant DBGMCU_PARTNUM                 \ [0x00 : 4] Part number field, bits [11:8]
    $04 constant DBGMCU_JEP106ID                \ [0x04 : 4] JEP106 identity code field, bits [3:0]
  [then]


  [ifdef] DBGMCU_DBGMCU_PIDR2_DEF
    \
    \ @brief DBGMCU peripheral identity register 2
    \ Address offset: 0xFE8
    \ Reset value: 0x0000000A
    \
    $00 constant DBGMCU_JEP106ID                \ [0x00 : 3] JEP106 identity code field, bits [6:4]
    $03 constant DBGMCU_JEDEC                   \ [0x03] JEDEC assigned value
    $04 constant DBGMCU_REVISION                \ [0x04 : 4] Component revision number
  [then]


  [ifdef] DBGMCU_DBGMCU_PIDR3_DEF
    \
    \ @brief DBGMCU peripheral identity register 3
    \ Address offset: 0xFEC
    \ Reset value: 0x00000000
    \
    $00 constant DBGMCU_CMOD                    \ [0x00 : 4] Customer modified
    $04 constant DBGMCU_REVAND                  \ [0x04 : 4] Metal fix version
  [then]


  [ifdef] DBGMCU_DBGMCU_CIDR0_DEF
    \
    \ @brief DBGMCU component identity register
    \ Address offset: 0xFF0
    \ Reset value: 0x0000000D
    \
    $00 constant DBGMCU_PREAMBLE                \ [0x00 : 8] Component ID field, bits [7:0]
  [then]


  [ifdef] DBGMCU_DBGMCU_CIDR1_DEF
    \
    \ @brief DBGMCU component identity register
    \ Address offset: 0xFF4
    \ Reset value: 0x000000F0
    \
    $00 constant DBGMCU_PREAMBLE                \ [0x00 : 4] Component ID field, bits [11:8]
    $04 constant DBGMCU_CLASS                   \ [0x04 : 4] Component ID field, bits [15:12] - component class
  [then]


  [ifdef] DBGMCU_DBGMCU_CIDR2_DEF
    \
    \ @brief DBGMCU component identity register
    \ Address offset: 0xFF8
    \ Reset value: 0x00000005
    \
    $00 constant DBGMCU_PREAMBLE                \ [0x00 : 8] Component ID field, bits [23:16]
  [then]


  [ifdef] DBGMCU_DBGMCU_CIDR3_DEF
    \
    \ @brief DBGMCU component identity register
    \ Address offset: 0xFFC
    \ Reset value: 0x000000B1
    \
    $00 constant DBGMCU_PREAMBLE                \ [0x00 : 8] Component ID field, bits [31:24]
  [then]

  \
  \ @brief Microcontroller debug unit
  \
  $00 constant DBGMCU_DBGMCU_IDC        \ DBGMCU identity code register
  $04 constant DBGMCU_DBGMCU_CR         \ DBGMCU configuration register
  $20 constant DBGMCU_DBGMCU_AHB5FZR    \ DBGMCU AHB5 peripheral freeze register
  $24 constant DBGMCU_DBGMCU_AHB1FZR    \ DBGMCU AHB1 peripheral freeze register
  $3C constant DBGMCU_DBGMCU_APB1FZR    \ DBGMCU APB1 peripheral freeze register
  $4C constant DBGMCU_DBGMCU_APB2FZ     \ DBGMCU APB2 peripheral freeze register
  $54 constant DBGMCU_DBGMCU_APB4FZR    \ DBGMCU APB4 peripheral freeze register
  $FC constant DBGMCU_DBGMCU_SR         \ DBGMCU status register
  $100 constant DBGMCU_DBGMCU_DBG_AUTH_HOST    \ DBGMCU debug authentication mailbox host register
  $104 constant DBGMCU_DBGMCU_DBG_AUTH_DEVICE    \ DBGMCU debug authentication mailbox device register
  $108 constant DBGMCU_DBGMCU_DBG_AUTH_ACK    \ DBGMCU debug authentication mailbox acknowledge register
  $FD0 constant DBGMCU_DBGMCU_PIDR4     \ DBGMCU peripheral identity register 4
  $FE0 constant DBGMCU_DBGMCU_PIDR0     \ DBGMCU peripheral identity register 0
  $FE4 constant DBGMCU_DBGMCU_PIDR1     \ DBGMCU peripheral identity register 1
  $FE8 constant DBGMCU_DBGMCU_PIDR2     \ DBGMCU peripheral identity register 2
  $FEC constant DBGMCU_DBGMCU_PIDR3     \ DBGMCU peripheral identity register 3
  $FF0 constant DBGMCU_DBGMCU_CIDR0     \ DBGMCU component identity register
  $FF4 constant DBGMCU_DBGMCU_CIDR1     \ DBGMCU component identity register
  $FF8 constant DBGMCU_DBGMCU_CIDR2     \ DBGMCU component identity register
  $FFC constant DBGMCU_DBGMCU_CIDR3     \ DBGMCU component identity register

: DBGMCU_DEF ; [then]
