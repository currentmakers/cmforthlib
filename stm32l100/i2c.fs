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
    \ @brief CR1
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant I2C_PE                         \ [0x00] Peripheral enable
    $01 constant I2C_SMBUS                      \ [0x01] SMBus mode
    $03 constant I2C_SMBTYPE                    \ [0x03] SMBus type
    $04 constant I2C_ENARP                      \ [0x04] ARP enable
    $05 constant I2C_ENPEC                      \ [0x05] PEC enable
    $06 constant I2C_ENGC                       \ [0x06] General call enable
    $07 constant I2C_NOSTRETCH                  \ [0x07] Clock stretching disable (Slave mode)
    $08 constant I2C_START                      \ [0x08] Start generation
    $09 constant I2C_STOP                       \ [0x09] Stop generation
    $0a constant I2C_ACK                        \ [0x0a] Acknowledge enable
    $0b constant I2C_POS                        \ [0x0b] Acknowledge/PEC Position (for data reception)
    $0c constant I2C_PEC                        \ [0x0c] Packet error checking
    $0d constant I2C_ALERT                      \ [0x0d] SMBus alert
    $0f constant I2C_SWRST                      \ [0x0f] Software reset
  [then]


  [ifdef] I2C_CR2_DEF
    \
    \ @brief CR2
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant I2C_FREQ                       \ [0x00 : 6] Peripheral clock frequency
    $08 constant I2C_ITERREN                    \ [0x08] Error interrupt enable
    $09 constant I2C_ITEVTEN                    \ [0x09] Event interrupt enable
    $0a constant I2C_ITBUFEN                    \ [0x0a] Buffer interrupt enable
    $0b constant I2C_DMAEN                      \ [0x0b] DMA requests enable
    $0c constant I2C_LAST                       \ [0x0c] DMA last transfer
  [then]


  [ifdef] I2C_OAR1_DEF
    \
    \ @brief OAR1
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant I2C_ADD_0                      \ [0x00] Interface address
    $01 constant I2C_ADD_1_7                    \ [0x01 : 7] Interface address
    $08 constant I2C_ADD_8_9                    \ [0x08 : 2] Interface address
    $0f constant I2C_ADDMODE                    \ [0x0f] ADDMODE
  [then]


  [ifdef] I2C_OAR2_DEF
    \
    \ @brief OAR2
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant I2C_ENDUAL                     \ [0x00] Dual addressing mode enable
    $01 constant I2C_ADD2                       \ [0x01 : 7] Interface address
  [then]


  [ifdef] I2C_DR_DEF
    \
    \ @brief DR
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant I2C_DR                         \ [0x00 : 8] -bit data register
  [then]


  [ifdef] I2C_SR1_DEF
    \
    \ @brief SR1
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant I2C_SB                         \ [0x00] Start bit (Master mode)
    $01 constant I2C_ADDR                       \ [0x01] Address sent (master mode)/matched (slave mode)
    $02 constant I2C_BTF                        \ [0x02] Byte transfer finished
    $03 constant I2C_ADD10                      \ [0x03] 10-bit header sent (Master mode)
    $04 constant I2C_STOPF                      \ [0x04] Stop detection (slave mode)
    $06 constant I2C_RxNE                       \ [0x06] Data register not empty (receivers)
    $07 constant I2C_TxE                        \ [0x07] Data register empty (transmitters)
    $08 constant I2C_BERR                       \ [0x08] Bus error
    $09 constant I2C_ARLO                       \ [0x09] Arbitration lost (master mode)
    $0a constant I2C_AF                         \ [0x0a] Acknowledge failure
    $0b constant I2C_OVR                        \ [0x0b] Overrun/Underrun
    $0c constant I2C_PECERR                     \ [0x0c] PEC Error in reception
    $0e constant I2C_TIMEOUT                    \ [0x0e] Timeout or Tlow error
    $0f constant I2C_SMBALERT                   \ [0x0f] SMBus alert
  [then]


  [ifdef] I2C_SR2_DEF
    \
    \ @brief SR2
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant I2C_MSL                        \ [0x00] Master/slave
    $01 constant I2C_BUSY                       \ [0x01] Bus busy
    $02 constant I2C_TRA                        \ [0x02] Transmitter/receiver
    $04 constant I2C_GENCALL                    \ [0x04] General call address (Slave mode)
    $05 constant I2C_SMBDEFAULT                 \ [0x05] SMBus device default address (Slave mode)
    $06 constant I2C_SMBHOST                    \ [0x06] SMBus host header (Slave mode)
    $07 constant I2C_DUALF                      \ [0x07] Dual flag (Slave mode)
    $08 constant I2C_PEC                        \ [0x08 : 8] acket error checking register
  [then]


  [ifdef] I2C_CCR_DEF
    \
    \ @brief CCR
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant I2C_CCR                        \ [0x00 : 12] Clock control register in Fast/Standard mode (Master mode)
    $0e constant I2C_DUTY                       \ [0x0e] Fast mode duty cycle
    $0f constant I2C_F_S                        \ [0x0f] I2C master mode selection
  [then]


  [ifdef] I2C_TRISE_DEF
    \
    \ @brief TRISE
    \ Address offset: 0x20
    \ Reset value: 0x00000002
    \
    $00 constant I2C_TRISE                      \ [0x00 : 6] Maximum rise time in Fast/Standard mode (Master mode)
  [then]

  \
  \ @brief Inter-integrated circuit
  \
  $00 constant I2C_CR1                  \ CR1
  $04 constant I2C_CR2                  \ CR2
  $08 constant I2C_OAR1                 \ OAR1
  $0C constant I2C_OAR2                 \ OAR2
  $10 constant I2C_DR                   \ DR
  $14 constant I2C_SR1                  \ SR1
  $18 constant I2C_SR2                  \ SR2
  $1C constant I2C_CCR                  \ CCR
  $20 constant I2C_TRISE                \ TRISE

: I2C_DEF ; [then]
