\
\ @file i2c.fs
\ @brief Inter-integrated circuit
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] I2C_DEF

  [ifdef] I2C_CR1_DEF
    \
    \ @brief Control register 1
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant I2C_PE                         \ [0x00] Peripheral enable
    $01 constant I2C_TXIE                       \ [0x01] TX Interrupt enable
    $02 constant I2C_RXIE                       \ [0x02] RX Interrupt enable
    $03 constant I2C_ADDRIE                     \ [0x03] Address match interrupt enable (slave only)
    $04 constant I2C_NACKIE                     \ [0x04] Not acknowledge received interrupt enable
    $05 constant I2C_STOPIE                     \ [0x05] STOP detection Interrupt enable
    $06 constant I2C_TCIE                       \ [0x06] Transfer Complete interrupt enable
    $07 constant I2C_ERRIE                      \ [0x07] Error interrupts enable
    $08 constant I2C_DNF                        \ [0x08 : 4] Digital noise filter
    $0c constant I2C_ANFOFF                     \ [0x0c] Analog noise filter OFF
    $0e constant I2C_TXDMAEN                    \ [0x0e] DMA transmission requests enable
    $0f constant I2C_RXDMAEN                    \ [0x0f] DMA reception requests enable
    $10 constant I2C_SBC                        \ [0x10] Slave byte control
    $11 constant I2C_NOSTRETCH                  \ [0x11] Clock stretching disable
    $12 constant I2C_WUPEN                      \ [0x12] Wakeup from STOP enable
    $13 constant I2C_GCEN                       \ [0x13] General call enable
    $14 constant I2C_SMBHEN                     \ [0x14] SMBus Host address enable
    $15 constant I2C_SMBDEN                     \ [0x15] SMBus Device Default address enable
    $16 constant I2C_ALERTEN                    \ [0x16] SMBUS alert enable
    $17 constant I2C_PECEN                      \ [0x17] PEC enable
  [then]


  [ifdef] I2C_CR2_DEF
    \
    \ @brief Control register 2
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant I2C_SADD                       \ [0x00 : 10] Slave address bit (master mode)
    $0a constant I2C_RD_WRN                     \ [0x0a] Transfer direction (master mode)
    $0b constant I2C_ADD10                      \ [0x0b] 10-bit addressing mode (master mode)
    $0c constant I2C_HEAD10R                    \ [0x0c] 10-bit address header only read direction (master receiver mode)
    $0d constant I2C_START                      \ [0x0d] Start generation
    $0e constant I2C_STOP                       \ [0x0e] Stop generation (master mode)
    $0f constant I2C_NACK                       \ [0x0f] NACK generation (slave mode)
    $10 constant I2C_NBYTES                     \ [0x10 : 8] Number of bytes
    $18 constant I2C_RELOAD                     \ [0x18] NBYTES reload mode
    $19 constant I2C_AUTOEND                    \ [0x19] Automatic end mode (master mode)
    $1a constant I2C_PECBYTE                    \ [0x1a] Packet error checking byte
  [then]


  [ifdef] I2C_OAR1_DEF
    \
    \ @brief Own address register 1
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant I2C_OA1                        \ [0x00 : 10] Interface address
    $0a constant I2C_OA1MODE                    \ [0x0a] Own Address 1 10-bit mode
    $0f constant I2C_OA1EN                      \ [0x0f] Own Address 1 enable
  [then]


  [ifdef] I2C_OAR2_DEF
    \
    \ @brief Own address register 2
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $01 constant I2C_OA2                        \ [0x01 : 7] Interface address
    $08 constant I2C_OA2MSK                     \ [0x08 : 3] Own Address 2 masks
    $0f constant I2C_OA2EN                      \ [0x0f] Own Address 2 enable
  [then]


  [ifdef] I2C_TIMINGR_DEF
    \
    \ @brief Timing register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant I2C_SCLL                       \ [0x00 : 8] SCL low period (master mode)
    $08 constant I2C_SCLH                       \ [0x08 : 8] SCL high period (master mode)
    $10 constant I2C_SDADEL                     \ [0x10 : 4] Data hold time
    $14 constant I2C_SCLDEL                     \ [0x14 : 4] Data setup time
    $1c constant I2C_PRESC                      \ [0x1c : 4] Timing prescaler
  [then]


  [ifdef] I2C_TIMEOUTR_DEF
    \
    \ @brief Status register 1
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant I2C_TIMEOUTA                   \ [0x00 : 12] Bus timeout A
    $0c constant I2C_TIDLE                      \ [0x0c] Idle clock timeout detection
    $0f constant I2C_TIMOUTEN                   \ [0x0f] Clock timeout enable
    $10 constant I2C_TIMEOUTB                   \ [0x10 : 12] Bus timeout B
    $1f constant I2C_TEXTEN                     \ [0x1f] Extended clock timeout enable
  [then]


  [ifdef] I2C_ISR_DEF
    \
    \ @brief Interrupt and Status register
    \ Address offset: 0x18
    \ Reset value: 0x00000001
    \
    $00 constant I2C_TXE                        \ [0x00] Transmit data register empty (transmitters)
    $01 constant I2C_TXIS                       \ [0x01] Transmit interrupt status (transmitters)
    $02 constant I2C_RXNE                       \ [0x02] Receive data register not empty (receivers)
    $03 constant I2C_ADDR                       \ [0x03] Address matched (slave mode)
    $04 constant I2C_NACKF                      \ [0x04] Not acknowledge received flag
    $05 constant I2C_STOPF                      \ [0x05] Stop detection flag
    $06 constant I2C_TC                         \ [0x06] Transfer Complete (master mode)
    $07 constant I2C_TCR                        \ [0x07] Transfer Complete Reload
    $08 constant I2C_BERR                       \ [0x08] Bus error
    $09 constant I2C_ARLO                       \ [0x09] Arbitration lost
    $0a constant I2C_OVR                        \ [0x0a] Overrun/Underrun (slave mode)
    $0b constant I2C_PECERR                     \ [0x0b] PEC Error in reception
    $0c constant I2C_TIMEOUT                    \ [0x0c] Timeout or t_low detection flag
    $0d constant I2C_ALERT                      \ [0x0d] SMBus alert
    $0f constant I2C_BUSY                       \ [0x0f] Bus busy
    $10 constant I2C_DIR                        \ [0x10] Transfer direction (Slave mode)
    $11 constant I2C_ADDCODE                    \ [0x11 : 7] Address match code (Slave mode)
  [then]


  [ifdef] I2C_ICR_DEF
    \
    \ @brief Interrupt clear register
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $03 constant I2C_ADDRCF                     \ [0x03] Address Matched flag clear
    $04 constant I2C_NACKCF                     \ [0x04] Not Acknowledge flag clear
    $05 constant I2C_STOPCF                     \ [0x05] Stop detection flag clear
    $08 constant I2C_BERRCF                     \ [0x08] Bus error flag clear
    $09 constant I2C_ARLOCF                     \ [0x09] Arbitration lost flag clear
    $0a constant I2C_OVRCF                      \ [0x0a] Overrun/Underrun flag clear
    $0b constant I2C_PECCF                      \ [0x0b] PEC Error flag clear
    $0c constant I2C_TIMOUTCF                   \ [0x0c] Timeout detection flag clear
    $0d constant I2C_ALERTCF                    \ [0x0d] Alert flag clear
  [then]


  [ifdef] I2C_PECR_DEF
    \
    \ @brief PEC register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant I2C_PEC                        \ [0x00 : 8] Packet error checking register
  [then]


  [ifdef] I2C_RXDR_DEF
    \
    \ @brief Receive data register
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant I2C_RXDATA                     \ [0x00 : 8] 8-bit receive data
  [then]


  [ifdef] I2C_TXDR_DEF
    \
    \ @brief Transmit data register
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant I2C_TXDATA                     \ [0x00 : 8] 8-bit transmit data
  [then]

  \
  \ @brief Inter-integrated circuit
  \
  $00 constant I2C_CR1                  \ Control register 1
  $04 constant I2C_CR2                  \ Control register 2
  $08 constant I2C_OAR1                 \ Own address register 1
  $0C constant I2C_OAR2                 \ Own address register 2
  $10 constant I2C_TIMINGR              \ Timing register
  $14 constant I2C_TIMEOUTR             \ Status register 1
  $18 constant I2C_ISR                  \ Interrupt and Status register
  $1C constant I2C_ICR                  \ Interrupt clear register
  $20 constant I2C_PECR                 \ PEC register
  $24 constant I2C_RXDR                 \ Receive data register
  $28 constant I2C_TXDR                 \ Transmit data register

: I2C_DEF ; [then]
