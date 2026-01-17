\
\ @file i2c4.fs
\ @brief Inter-integrated circuit
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] I2C4_DEF

  [ifdef] I2C4_CR1_DEF
    \
    \ @brief Control register 1
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant I2C4_PE                        \ [0x00] Peripheral enable
    $01 constant I2C4_TXIE                      \ [0x01] TXIE
    $02 constant I2C4_RXIE                      \ [0x02] RXIE
    $03 constant I2C4_ADDRE                     \ [0x03] ADDRE
    $04 constant I2C4_NACKIE                    \ [0x04] NACKIE
    $05 constant I2C4_STOPIE                    \ [0x05] STOPIE
    $06 constant I2C4_TCIE                      \ [0x06] TCIE
    $07 constant I2C4_ERRIE                     \ [0x07] ERRIE
    $08 constant I2C4_DNF                       \ [0x08 : 4] DNF
    $0c constant I2C4_ANFOFF                    \ [0x0c] ANFOFF
    $0e constant I2C4_TCDMAEN                   \ [0x0e] TCDMAEN
    $0f constant I2C4_RXDMAEN                   \ [0x0f] RXDMAEN
    $10 constant I2C4_SBC                       \ [0x10] SBC
    $11 constant I2C4_NOSTRETCH                 \ [0x11] NOSTRETCH
    $12 constant I2C4_WUPEN                     \ [0x12] WUPEN
    $13 constant I2C4_GCEN                      \ [0x13] GCEN
    $14 constant I2C4_SMBHEN                    \ [0x14] SMBHEN
    $15 constant I2C4_SMBDEN                    \ [0x15] SMBDEN
    $16 constant I2C4_ALERTEN                   \ [0x16] ALERTEN
    $17 constant I2C4_PECEN                     \ [0x17] PECEN
  [then]


  [ifdef] I2C4_CR2_DEF
    \
    \ @brief Control register 2
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant I2C4_SADD0                     \ [0x00] Slave address bit 0
    $01 constant I2C4_SADD1_7                   \ [0x01 : 7] Slave address bit 7_1
    $08 constant I2C4_SADD8_9                   \ [0x08 : 2] Slave address bit 8_9
    $0a constant I2C4_RD_WRN                    \ [0x0a] Transfer direction
    $0b constant I2C4_ADD10                     \ [0x0b] 10-bit addressing mode
    $0c constant I2C4_HEAD10R                   \ [0x0c] 10-bit address header only read direction
    $0d constant I2C4_START                     \ [0x0d] Start generation
    $0e constant I2C4_STOP                      \ [0x0e] Stop generation
    $0f constant I2C4_NACK                      \ [0x0f] NACK generation
    $10 constant I2C4_NBYTES                    \ [0x10 : 8] Number of bytes
    $18 constant I2C4_RELOAD                    \ [0x18] NBYTES reload mode
    $19 constant I2C4_AUTOEND                   \ [0x19] Automatic end mode
    $1a constant I2C4_PECBYTE                   \ [0x1a] Packet error checking byte
  [then]


  [ifdef] I2C4_OAR1_DEF
    \
    \ @brief Own address register 1
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant I2C4_OA1                       \ [0x00] OA1
    $01 constant I2C4_OA11_7                    \ [0x01 : 7] OA11_7
    $08 constant I2C4_OA18_9                    \ [0x08 : 2] OA18_9
    $0a constant I2C4_OA1MODE                   \ [0x0a] OA1MODE
    $0f constant I2C4_OA1EN                     \ [0x0f] OA1EN
  [then]


  [ifdef] I2C4_OAR2_DEF
    \
    \ @brief Own address register 2
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $01 constant I2C4_OA21_7                    \ [0x01 : 7] OA21_7
    $08 constant I2C4_OA2MSK                    \ [0x08 : 3] OA2MSK
    $0f constant I2C4_OA2EN                     \ [0x0f] OA2EN
  [then]


  [ifdef] I2C4_TIMINGR_DEF
    \
    \ @brief Timing register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant I2C4_SCLL                      \ [0x00 : 8] SCLL
    $08 constant I2C4_SCLH                      \ [0x08 : 8] SCLH
    $10 constant I2C4_SDADEL                    \ [0x10 : 4] SDADEL
    $14 constant I2C4_SCLDEL                    \ [0x14 : 4] SCLDEL
    $1c constant I2C4_PRESC                     \ [0x1c : 4] PRESC
  [then]


  [ifdef] I2C4_TIMEOUTR_DEF
    \
    \ @brief Timeout register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant I2C4_TIMEOUTA                  \ [0x00 : 12] TIMEOUTA
    $0c constant I2C4_TIDLE                     \ [0x0c] TIDLE
    $0f constant I2C4_TIMOUTEN                  \ [0x0f] TIMOUTEN
    $10 constant I2C4_TIMEOUTB                  \ [0x10 : 12] TIMEOUTB
    $1f constant I2C4_TEXTEN                    \ [0x1f] TEXTEN
  [then]


  [ifdef] I2C4_ISR_DEF
    \
    \ @brief Interrupt and Status register
    \ Address offset: 0x18
    \ Reset value: 0x00000001
    \
    $00 constant I2C4_TXE                       \ [0x00] TXE
    $01 constant I2C4_TXIS                      \ [0x01] TXIS
    $02 constant I2C4_RXNE                      \ [0x02] RXNE
    $03 constant I2C4_ADDR                      \ [0x03] ADDR
    $04 constant I2C4_NACKF                     \ [0x04] NACKF
    $05 constant I2C4_STOPF                     \ [0x05] STOPF
    $06 constant I2C4_TC                        \ [0x06] TC
    $07 constant I2C4_TCR                       \ [0x07] TCR
    $08 constant I2C4_BERR                      \ [0x08] BERR
    $09 constant I2C4_ARLO                      \ [0x09] ARLO
    $0a constant I2C4_OVR                       \ [0x0a] OVR
    $0b constant I2C4_PECERR                    \ [0x0b] PECERR
    $0c constant I2C4_TIMEOUT                   \ [0x0c] TIMEOUT
    $0d constant I2C4_ALERT                     \ [0x0d] ALERT
    $0f constant I2C4_BUSY                      \ [0x0f] BUSY
    $10 constant I2C4_DIR                       \ [0x10] DIR
    $11 constant I2C4_ADDCODE                   \ [0x11 : 7] ADDCODE
  [then]


  [ifdef] I2C4_ICR_DEF
    \
    \ @brief Interrupt clear register
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $03 constant I2C4_ADDRCF                    \ [0x03] ADDRCF
    $04 constant I2C4_NACKCF                    \ [0x04] NACKCF
    $05 constant I2C4_STOPCF                    \ [0x05] STOPCF
    $08 constant I2C4_BERRCF                    \ [0x08] BERRCF
    $09 constant I2C4_ARLOCF                    \ [0x09] ARLOCF
    $0a constant I2C4_OVRCF                     \ [0x0a] OVRCF
    $0b constant I2C4_PECCF                     \ [0x0b] PECCF
    $0c constant I2C4_TIMOUTCF                  \ [0x0c] TIMOUTCF
    $0d constant I2C4_ALERTC                    \ [0x0d] ALERTC
  [then]


  [ifdef] I2C4_PECR_DEF
    \
    \ @brief PEC register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant I2C4_PEC                       \ [0x00 : 8] PEC
  [then]


  [ifdef] I2C4_RXDR_DEF
    \
    \ @brief Receive data register
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant I2C4_RXDATA                    \ [0x00 : 8] RXDATA
  [then]


  [ifdef] I2C4_TXDR_DEF
    \
    \ @brief Transmit data register
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant I2C4_TXDATA                    \ [0x00 : 8] TXDATA
  [then]

  \
  \ @brief Inter-integrated circuit
  \
  $00 constant I2C4_CR1                 \ Control register 1
  $04 constant I2C4_CR2                 \ Control register 2
  $08 constant I2C4_OAR1                \ Own address register 1
  $0C constant I2C4_OAR2                \ Own address register 2
  $10 constant I2C4_TIMINGR             \ Timing register
  $14 constant I2C4_TIMEOUTR            \ Timeout register
  $18 constant I2C4_ISR                 \ Interrupt and Status register
  $1C constant I2C4_ICR                 \ Interrupt clear register
  $20 constant I2C4_PECR                \ PEC register
  $24 constant I2C4_RXDR                \ Receive data register
  $28 constant I2C4_TXDR                \ Transmit data register

: I2C4_DEF ; [then]
