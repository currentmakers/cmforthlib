\
\ @file fmpi2c.fs
\ @brief fast-mode Inter-integrated circuit
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
    $01 constant FMPI2C_TXIE                    \ [0x01] TXIE
    $02 constant FMPI2C_RXIE                    \ [0x02] RXIE
    $03 constant FMPI2C_ADDRE                   \ [0x03] ADDRE
    $04 constant FMPI2C_NACKIE                  \ [0x04] NACKIE
    $05 constant FMPI2C_STOPIE                  \ [0x05] STOPIE
    $06 constant FMPI2C_TCIE                    \ [0x06] TCIE
    $07 constant FMPI2C_ERRIE                   \ [0x07] ERRIE
    $08 constant FMPI2C_DNF                     \ [0x08 : 4] DNF
    $0c constant FMPI2C_ANFOFF                  \ [0x0c] ANFOFF
    $0e constant FMPI2C_TCDMAEN                 \ [0x0e] TCDMAEN
    $0f constant FMPI2C_RXDMAEN                 \ [0x0f] RXDMAEN
    $10 constant FMPI2C_SBC                     \ [0x10] SBC
    $11 constant FMPI2C_NOSTRETCH               \ [0x11] NOSTRETCH
    $13 constant FMPI2C_GCEN                    \ [0x13] GCEN
    $14 constant FMPI2C_SMBHEN                  \ [0x14] SMBHEN
    $15 constant FMPI2C_SMBDEN                  \ [0x15] SMBDEN
    $16 constant FMPI2C_ALERTEN                 \ [0x16] ALERTEN
    $17 constant FMPI2C_PECEN                   \ [0x17] PECEN
  [then]


  [ifdef] FMPI2C_CR2_DEF
    \
    \ @brief Control register 2
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant FMPI2C_SADD0                   \ [0x00] Slave address bit 0
    $01 constant FMPI2C_SADD1_7                 \ [0x01 : 7] Slave address bit 7_1
    $08 constant FMPI2C_SADD8_9                 \ [0x08 : 2] Slave address bit 8_9
    $0a constant FMPI2C_RD_WRN                  \ [0x0a] Transfer direction
    $0b constant FMPI2C_ADD10                   \ [0x0b] 10-bit addressing mode
    $0c constant FMPI2C_HEAD10R                 \ [0x0c] 10-bit address header only read direction
    $0d constant FMPI2C_START                   \ [0x0d] Start generation
    $0e constant FMPI2C_STOP                    \ [0x0e] Stop generation
    $0f constant FMPI2C_NACK                    \ [0x0f] NACK generation
    $10 constant FMPI2C_NBYTES                  \ [0x10 : 8] Number of bytes
    $18 constant FMPI2C_RELOAD                  \ [0x18] NBYTES reload mode
    $19 constant FMPI2C_AUTOEND                 \ [0x19] Automatic end mode
    $1a constant FMPI2C_PECBYTE                 \ [0x1a] Packet error checking byte
  [then]


  [ifdef] FMPI2C_OAR1_DEF
    \
    \ @brief Own address register 1
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant FMPI2C_OA1                     \ [0x00] OA1
    $01 constant FMPI2C_OA11_7                  \ [0x01 : 7] OA11_7
    $08 constant FMPI2C_OA18_9                  \ [0x08 : 2] OA18_9
    $0a constant FMPI2C_OA1MODE                 \ [0x0a] OA1MODE
    $0f constant FMPI2C_OA1EN                   \ [0x0f] OA1EN
  [then]


  [ifdef] FMPI2C_OAR2_DEF
    \
    \ @brief Own address register 2
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $01 constant FMPI2C_OA21_7                  \ [0x01 : 7] OA21_7
    $08 constant FMPI2C_OA2MSK                  \ [0x08 : 3] OA2MSK
    $0f constant FMPI2C_OA2EN                   \ [0x0f] OA2EN
  [then]


  [ifdef] FMPI2C_TIMINGR_DEF
    \
    \ @brief Timing register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant FMPI2C_SCLL                    \ [0x00 : 8] SCLL
    $08 constant FMPI2C_SCLH                    \ [0x08 : 8] SCLH
    $10 constant FMPI2C_SDADEL                  \ [0x10 : 4] SDADEL
    $14 constant FMPI2C_SCLDEL                  \ [0x14 : 4] SCLDEL
    $1c constant FMPI2C_PRESC                   \ [0x1c : 4] PRESC
  [then]


  [ifdef] FMPI2C_TIMEOUTR_DEF
    \
    \ @brief Timeout register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant FMPI2C_TIMEOUTA                \ [0x00 : 12] TIMEOUTA
    $0c constant FMPI2C_TIDLE                   \ [0x0c] TIDLE
    $0f constant FMPI2C_TIMOUTEN                \ [0x0f] TIMOUTEN
    $10 constant FMPI2C_TIMEOUTB                \ [0x10 : 12] TIMEOUTB
    $1f constant FMPI2C_TEXTEN                  \ [0x1f] TEXTEN
  [then]


  [ifdef] FMPI2C_ISR_DEF
    \
    \ @brief Interrupt and Status register
    \ Address offset: 0x18
    \ Reset value: 0x00000001
    \
    $00 constant FMPI2C_TXE                     \ [0x00] TXE
    $01 constant FMPI2C_TXIS                    \ [0x01] TXIS
    $02 constant FMPI2C_RXNE                    \ [0x02] RXNE
    $03 constant FMPI2C_ADDR                    \ [0x03] ADDR
    $04 constant FMPI2C_NACKF                   \ [0x04] NACKF
    $05 constant FMPI2C_STOPF                   \ [0x05] STOPF
    $06 constant FMPI2C_TC                      \ [0x06] TC
    $07 constant FMPI2C_TCR                     \ [0x07] TCR
    $08 constant FMPI2C_BERR                    \ [0x08] BERR
    $09 constant FMPI2C_ARLO                    \ [0x09] ARLO
    $0a constant FMPI2C_OVR                     \ [0x0a] OVR
    $0b constant FMPI2C_PECERR                  \ [0x0b] PECERR
    $0c constant FMPI2C_TIMEOUT                 \ [0x0c] TIMEOUT
    $0d constant FMPI2C_ALERT                   \ [0x0d] ALERT
    $0f constant FMPI2C_BUSY                    \ [0x0f] BUSY
    $10 constant FMPI2C_DIR                     \ [0x10] DIR
    $11 constant FMPI2C_ADDCODE                 \ [0x11 : 7] ADDCODE
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
    $00 constant FMPI2C_PEC                     \ [0x00 : 8] PEC
  [then]


  [ifdef] FMPI2C_RXDR_DEF
    \
    \ @brief Receive data register
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant FMPI2C_RXDATA                  \ [0x00 : 8] RXDATA
  [then]


  [ifdef] FMPI2C_TXDR_DEF
    \
    \ @brief Transmit data register
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant FMPI2C_TXDATA                  \ [0x00 : 8] TXDATA
  [then]

  \
  \ @brief fast-mode Inter-integrated circuit
  \
  $00 constant FMPI2C_CR1               \ Control register 1
  $04 constant FMPI2C_CR2               \ Control register 2
  $08 constant FMPI2C_OAR1              \ Own address register 1
  $0C constant FMPI2C_OAR2              \ Own address register 2
  $10 constant FMPI2C_TIMINGR           \ Timing register
  $14 constant FMPI2C_TIMEOUTR          \ Timeout register
  $18 constant FMPI2C_ISR               \ Interrupt and Status register
  $1C constant FMPI2C_ICR               \ Interrupt clear register
  $20 constant FMPI2C_PECR              \ PEC register
  $24 constant FMPI2C_RXDR              \ Receive data register
  $28 constant FMPI2C_TXDR              \ Transmit data register

: FMPI2C_DEF ; [then]
