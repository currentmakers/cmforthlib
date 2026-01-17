\
\ @file fmpi2c.fs
\ @brief Fast-mode Plus Inter-integrated circuit interface
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] FMPI2C_DEF

  [ifdef] FMPI2C_CR1_DEF
    \
    \ @brief Control register 1
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant FMPI2C_PE                      \ [0x00] Peripheral enable
    $01 constant FMPI2C_TXIE                    \ [0x01] TX Interrupt enable
    $02 constant FMPI2C_RXIE                    \ [0x02] RX Interrupt enable
    $03 constant FMPI2C_ADDRIE                  \ [0x03] Address match Interrupt enable (slave only)
    $04 constant FMPI2C_NACKIE                  \ [0x04] Not acknowledge received Interrupt enable
    $05 constant FMPI2C_STOPIE                  \ [0x05] STOP detection Interrupt enable
    $06 constant FMPI2C_TCIE                    \ [0x06] Transfer Complete interrupt enable
    $07 constant FMPI2C_ERRIE                   \ [0x07] Error interrupts enable
    $08 constant FMPI2C_DNF                     \ [0x08 : 4] Digital noise filter
    $0c constant FMPI2C_ANFOFF                  \ [0x0c] Analog noise filter OFF
    $0e constant FMPI2C_TXDMAEN                 \ [0x0e] DMA transmission requests enable
    $0f constant FMPI2C_RXDMAEN                 \ [0x0f] DMA reception requests enable
    $10 constant FMPI2C_SBC                     \ [0x10] Slave byte control
    $11 constant FMPI2C_NOSTRETCH               \ [0x11] Clock stretching disable
    $13 constant FMPI2C_GCEN                    \ [0x13] General call enable
    $14 constant FMPI2C_SMBHEN                  \ [0x14] SMBus Host address enable
    $15 constant FMPI2C_SMBDEN                  \ [0x15] SMBus Device Default address enable
    $16 constant FMPI2C_ALERTEN                 \ [0x16] SMBus alert enable
    $17 constant FMPI2C_PECEN                   \ [0x17] PEC enable
  [then]


  [ifdef] FMPI2C_CR2_DEF
    \
    \ @brief Control register 1
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant FMPI2C_SADD0                   \ [0x00] Slave address bit 0 (master mode)
    $01 constant FMPI2C_SADD7_1                 \ [0x01 : 7] Slave address bit 7:1 (master mode)
    $08 constant FMPI2C_SADD9_8                 \ [0x08 : 2] Slave address bit 9:8 (master mode)
    $0a constant FMPI2C_RD_WRN                  \ [0x0a] Transfer direction (master mode)
    $0b constant FMPI2C_ADD10                   \ [0x0b] 10-bit addressing mode (master mode)
    $0c constant FMPI2C_HEAD10R                 \ [0x0c] 10-bit address header only read direction (master receiver mode)
    $0d constant FMPI2C_START                   \ [0x0d] Start generation
    $0e constant FMPI2C_STOP                    \ [0x0e] Stop generation (master mode)
    $0f constant FMPI2C_NACK                    \ [0x0f] NACK generation (slave mode)
    $10 constant FMPI2C_NBYTES                  \ [0x10 : 8] Number of bytes
    $18 constant FMPI2C_RELOAD                  \ [0x18] NBYTES reload mode
    $19 constant FMPI2C_AUTOEND                 \ [0x19] Automatic end mode (master mode)
    $1a constant FMPI2C_PECBYTE                 \ [0x1a] Packet error checking byte
  [then]


  [ifdef] FMPI2C_OAR1_DEF
    \
    \ @brief Own address 1 register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant FMPI2C_OA1_0                   \ [0x00] Interface address
    $01 constant FMPI2C_OA1_7_1                 \ [0x01 : 7] Interface address
    $08 constant FMPI2C_OA1_9_8                 \ [0x08 : 2] Interface address
    $0a constant FMPI2C_OA1MODE                 \ [0x0a] Own Address 1 10-bit mode
    $0f constant FMPI2C_OA1EN                   \ [0x0f] Own Address 1 enable
  [then]


  [ifdef] FMPI2C_OAR2_DEF
    \
    \ @brief Own address 2 register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $01 constant FMPI2C_OA2                     \ [0x01 : 7] Interface address
    $08 constant FMPI2C_OA2MSK                  \ [0x08 : 3] Own Address 2 masks
    $0f constant FMPI2C_OA2EN                   \ [0x0f] Own Address 2 enable
  [then]


  [ifdef] FMPI2C_TIMINGR_DEF
    \
    \ @brief Timing register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant FMPI2C_SCLL                    \ [0x00 : 8] SCL low period (master mode)
    $08 constant FMPI2C_SCLH                    \ [0x08 : 8] SCL high period (master mode)
    $10 constant FMPI2C_SDADEL                  \ [0x10 : 4] Data hold time
    $14 constant FMPI2C_SCLDEL                  \ [0x14 : 4] Data setup time
    $1c constant FMPI2C_PRESC                   \ [0x1c : 4] Timing prescaler
  [then]


  [ifdef] FMPI2C_TIMEOUTR_DEF
    \
    \ @brief Timeout register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant FMPI2C_TIMEOUTA                \ [0x00 : 12] Bus Timeout A
    $0c constant FMPI2C_TIDLE                   \ [0x0c] Idle clock timeout detection
    $0f constant FMPI2C_TIMOUTEN                \ [0x0f] Clock timeout enable
    $10 constant FMPI2C_TIMEOUTB                \ [0x10 : 12] Bus timeout B
    $1f constant FMPI2C_TEXTEN                  \ [0x1f] Extended clock timeout enable
  [then]


  [ifdef] FMPI2C_ISR_DEF
    \
    \ @brief Interrupt and status register
    \ Address offset: 0x18
    \ Reset value: 0x00000001
    \
    $00 constant FMPI2C_TXE                     \ [0x00] Transmit data register empty (transmitters)
    $01 constant FMPI2C_TXIS                    \ [0x01] Transmit interrupt status (transmitters)
    $02 constant FMPI2C_RXNE                    \ [0x02] Receive data register not empty (receivers)
    $03 constant FMPI2C_ADDR                    \ [0x03] Address matched (slave mode)
    $04 constant FMPI2C_NACKF                   \ [0x04] Not Acknowledge received flag
    $05 constant FMPI2C_STOPF                   \ [0x05] Stop detection flag
    $06 constant FMPI2C_TC                      \ [0x06] Transfer Complete (master mode)
    $07 constant FMPI2C_TCR                     \ [0x07] Transfer Complete Reload
    $08 constant FMPI2C_BERR                    \ [0x08] Bus error
    $09 constant FMPI2C_ARLO                    \ [0x09] Arbitration lost
    $0a constant FMPI2C_OVR                     \ [0x0a] Overrun/Underrun (slave mode)
    $0b constant FMPI2C_PECERR                  \ [0x0b] PEC Error in reception
    $0c constant FMPI2C_TIMEOUT                 \ [0x0c] Timeout or tLOW detection flag
    $0d constant FMPI2C_ALERT                   \ [0x0d] SMBus alert
    $0f constant FMPI2C_BUSY                    \ [0x0f] Bus busy
    $10 constant FMPI2C_DIR                     \ [0x10] Transfer direction (Slave mode)
    $11 constant FMPI2C_ADDCODE                 \ [0x11 : 7] Address match code (Slave mode)
  [then]


  [ifdef] FMPI2C_ICR_DEF
    \
    \ @brief Interrupt clear register
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $03 constant FMPI2C_ADDRCF                  \ [0x03] Address matched flag clear
    $04 constant FMPI2C_NACKCF                  \ [0x04] Not Acknowledge flag clear
    $05 constant FMPI2C_STOPCF                  \ [0x05] Stop detection flag clear
    $08 constant FMPI2C_BERRCF                  \ [0x08] Bus error flag clear
    $09 constant FMPI2C_ARLOCF                  \ [0x09] Arbitration Lost flag clear
    $0a constant FMPI2C_OVRCF                   \ [0x0a] Overrun/Underrun flag clear
    $0b constant FMPI2C_PECCF                   \ [0x0b] PEC Error flag clear
    $0c constant FMPI2C_TIMOUTCF                \ [0x0c] Timeout detection flag clear
    $0d constant FMPI2C_ALERTCF                 \ [0x0d] Alert flag clear
  [then]


  [ifdef] FMPI2C_PECR_DEF
    \
    \ @brief PEC register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant FMPI2C_PEC                     \ [0x00 : 8] Packet error checking register
  [then]


  [ifdef] FMPI2C_RXDR_DEF
    \
    \ @brief Receive data register
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant FMPI2C_RXDATA                  \ [0x00 : 8] 8-bit receive data
  [then]


  [ifdef] FMPI2C_TXDR_DEF
    \
    \ @brief Transmit data register
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant FMPI2C_TXDATA                  \ [0x00 : 8] 8-bit transmit data
  [then]

  \
  \ @brief Fast-mode Plus Inter-integrated circuit interface
  \
  $00 constant FMPI2C_CR1               \ Control register 1
  $04 constant FMPI2C_CR2               \ Control register 1
  $08 constant FMPI2C_OAR1              \ Own address 1 register
  $0C constant FMPI2C_OAR2              \ Own address 2 register
  $10 constant FMPI2C_TIMINGR           \ Timing register
  $14 constant FMPI2C_TIMEOUTR          \ Timeout register
  $18 constant FMPI2C_ISR               \ Interrupt and status register
  $1C constant FMPI2C_ICR               \ Interrupt clear register
  $20 constant FMPI2C_PECR              \ PEC register
  $24 constant FMPI2C_RXDR              \ Receive data register
  $28 constant FMPI2C_TXDR              \ Transmit data register

: FMPI2C_DEF ; [then]
