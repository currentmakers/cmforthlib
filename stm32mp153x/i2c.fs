\
\ @file i2c.fs
\ @brief I2C1
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] I2C_DEF

  [ifdef] I2C_I2C_CR1_DEF
    \
    \ @brief Access: No wait states, except if a write access occurs while a write access to this register is ongoing. In this case, wait states are inserted in the second write access until the previous one is completed. The latency of the second write access can be up to 2xi2c_pclk+6xi2c_ker_ck.
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant I2C_PE                         \ [0x00] PE
    $01 constant I2C_TXIE                       \ [0x01] TXIE
    $02 constant I2C_RXIE                       \ [0x02] RXIE
    $03 constant I2C_ADDRIE                     \ [0x03] ADDRIE
    $04 constant I2C_NACKIE                     \ [0x04] NACKIE
    $05 constant I2C_STOPIE                     \ [0x05] STOPIE
    $06 constant I2C_TCIE                       \ [0x06] TCIE
    $07 constant I2C_ERRIE                      \ [0x07] ERRIE
    $08 constant I2C_DNF                        \ [0x08 : 4] DNF
    $0c constant I2C_ANFOFF                     \ [0x0c] ANFOFF
    $0e constant I2C_TXDMAEN                    \ [0x0e] TXDMAEN
    $0f constant I2C_RXDMAEN                    \ [0x0f] RXDMAEN
    $10 constant I2C_SBC                        \ [0x10] SBC
    $11 constant I2C_NOSTRETCH                  \ [0x11] NOSTRETCH
    $12 constant I2C_WUPEN                      \ [0x12] WUPEN
    $13 constant I2C_GCEN                       \ [0x13] GCEN
    $14 constant I2C_SMBHEN                     \ [0x14] SMBHEN
    $15 constant I2C_SMBDEN                     \ [0x15] SMBDEN
    $16 constant I2C_ALERTEN                    \ [0x16] ALERTEN
    $17 constant I2C_PECEN                      \ [0x17] PECEN
  [then]


  [ifdef] I2C_I2C_CR2_DEF
    \
    \ @brief Access: No wait states, except if a write access occurs while a write access to this register is ongoing. In this case, wait states are inserted in the second write access until the previous one is completed. The latency of the second write access can be up to 2 x i2c_pclk + 6 x i2c_ker_ck.
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant I2C_SADD                       \ [0x00 : 10] SADD
    $0a constant I2C_RD_WRN                     \ [0x0a] RD_WRN
    $0b constant I2C_ADD10                      \ [0x0b] ADD10
    $0c constant I2C_HEAD10R                    \ [0x0c] HEAD10R
    $0d constant I2C_START                      \ [0x0d] START
    $0e constant I2C_STOP                       \ [0x0e] STOP
    $0f constant I2C_NACK                       \ [0x0f] NACK
    $10 constant I2C_NBYTES                     \ [0x10 : 8] NBYTES
    $18 constant I2C_RELOAD                     \ [0x18] RELOAD
    $19 constant I2C_AUTOEND                    \ [0x19] AUTOEND
    $1a constant I2C_PECBYTE                    \ [0x1a] PECBYTE
  [then]


  [ifdef] I2C_I2C_OAR1_DEF
    \
    \ @brief Access: No wait states, except if a write access occurs while a write access to this register is ongoing. In this case, wait states are inserted in the second write access until the previous one is completed. The latency of the second write access can be up to 2 x i2c_pclk + 6 x i2c_ker_ck.
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant I2C_OA1                        \ [0x00 : 10] OA1
    $0a constant I2C_OA1MODE                    \ [0x0a] OA1MODE
    $0f constant I2C_OA1EN                      \ [0x0f] OA1EN
  [then]


  [ifdef] I2C_I2C_OAR2_DEF
    \
    \ @brief Access: No wait states, except if a write access occurs while a write access to this register is ongoing. In this case, wait states are inserted in the second write access until the previous one is completed. The latency of the second write access can be up to 2 x i2c_pclk + 6 x i2c_ker_ck.
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $01 constant I2C_OA2                        \ [0x01 : 7] OA2
    $08 constant I2C_OA2MSK                     \ [0x08 : 3] OA2MSK
    $0f constant I2C_OA2EN                      \ [0x0f] OA2EN
  [then]


  [ifdef] I2C_I2C_TIMINGR_DEF
    \
    \ @brief Access: No wait states
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant I2C_SCLL                       \ [0x00 : 8] SCLL
    $08 constant I2C_SCLH                       \ [0x08 : 8] SCLH
    $10 constant I2C_SDADEL                     \ [0x10 : 4] SDADEL
    $14 constant I2C_SCLDEL                     \ [0x14 : 4] SCLDEL
    $1c constant I2C_PRESC                      \ [0x1c : 4] PRESC
  [then]


  [ifdef] I2C_I2C_TIMEOUTR_DEF
    \
    \ @brief Access: No wait states, except if a write access occurs while a write access to this register is ongoing. In this case, wait states are inserted in the second write access until the previous one is completed. The latency of the second write access can be up to 2 x i2c_pclk + 6 x i2c_ker_ck.
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant I2C_TIMEOUTA                   \ [0x00 : 12] TIMEOUTA
    $0c constant I2C_TIDLE                      \ [0x0c] TIDLE
    $0f constant I2C_TIMOUTEN                   \ [0x0f] TIMOUTEN
    $10 constant I2C_TIMEOUTB                   \ [0x10 : 12] TIMEOUTB
    $1f constant I2C_TEXTEN                     \ [0x1f] TEXTEN
  [then]


  [ifdef] I2C_I2C_ISR_DEF
    \
    \ @brief Access: No wait states
    \ Address offset: 0x18
    \ Reset value: 0x00000001
    \
    $00 constant I2C_TXE                        \ [0x00] TXE
    $01 constant I2C_TXIS                       \ [0x01] TXIS
    $02 constant I2C_RXNE                       \ [0x02] RXNE
    $03 constant I2C_ADDR                       \ [0x03] ADDR
    $04 constant I2C_NACKF                      \ [0x04] NACKF
    $05 constant I2C_STOPF                      \ [0x05] STOPF
    $06 constant I2C_TC                         \ [0x06] TC
    $07 constant I2C_TCR                        \ [0x07] TCR
    $08 constant I2C_BERR                       \ [0x08] BERR
    $09 constant I2C_ARLO                       \ [0x09] ARLO
    $0a constant I2C_OVR                        \ [0x0a] OVR
    $0b constant I2C_PECERR                     \ [0x0b] PECERR
    $0c constant I2C_TIMEOUT                    \ [0x0c] TIMEOUT
    $0d constant I2C_ALERT                      \ [0x0d] ALERT
    $0f constant I2C_BUSY                       \ [0x0f] BUSY
    $10 constant I2C_DIR                        \ [0x10] DIR
    $11 constant I2C_ADDCODE                    \ [0x11 : 7] ADDCODE
  [then]


  [ifdef] I2C_I2C_ICR_DEF
    \
    \ @brief Access: No wait states
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $03 constant I2C_ADDRCF                     \ [0x03] ADDRCF
    $04 constant I2C_NACKCF                     \ [0x04] NACKCF
    $05 constant I2C_STOPCF                     \ [0x05] STOPCF
    $08 constant I2C_BERRCF                     \ [0x08] BERRCF
    $09 constant I2C_ARLOCF                     \ [0x09] ARLOCF
    $0a constant I2C_OVRCF                      \ [0x0a] OVRCF
    $0b constant I2C_PECCF                      \ [0x0b] PECCF
    $0c constant I2C_TIMOUTCF                   \ [0x0c] TIMOUTCF
    $0d constant I2C_ALERTCF                    \ [0x0d] ALERTCF
  [then]


  [ifdef] I2C_I2C_PECR_DEF
    \
    \ @brief Access: No wait states
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant I2C_PEC                        \ [0x00 : 8] PEC
  [then]


  [ifdef] I2C_I2C_RXDR_DEF
    \
    \ @brief Access: No wait states
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant I2C_RXDATA                     \ [0x00 : 8] RXDATA
  [then]


  [ifdef] I2C_I2C_TXDR_DEF
    \
    \ @brief Access: No wait states
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant I2C_TXDATA                     \ [0x00 : 8] TXDATA
  [then]


  [ifdef] I2C_I2C_HWCFGR_DEF
    \
    \ @brief I2C hardware configuration register
    \ Address offset: 0x3F0
    \ Reset value: 0x00000111
    \
    $00 constant I2C_SMBUS                      \ [0x00 : 4] SMBUS
    $04 constant I2C_ASYN                       \ [0x04 : 4] ASYN
    $08 constant I2C_WKP                        \ [0x08 : 4] WKP
  [then]


  [ifdef] I2C_I2C_VERR_DEF
    \
    \ @brief I2C version register
    \ Address offset: 0x3F4
    \ Reset value: 0x00000012
    \
    $00 constant I2C_MINREV                     \ [0x00 : 4] MINREV
    $04 constant I2C_MAJREV                     \ [0x04 : 4] MAJREV
  [then]


  [ifdef] I2C_I2C_IPIDR_DEF
    \
    \ @brief I2C identification register
    \ Address offset: 0x3F8
    \ Reset value: 0x00130012
    \
    $00 constant I2C_ID                         \ [0x00 : 32] ID
  [then]


  [ifdef] I2C_I2C_SIDR_DEF
    \
    \ @brief I2C size identification register
    \ Address offset: 0x3FC
    \ Reset value: 0xA3C5DD01
    \
    $00 constant I2C_SID                        \ [0x00 : 32] SID
  [then]

  \
  \ @brief I2C1
  \
  $00 constant I2C_I2C_CR1              \ Access: No wait states, except if a write access occurs while a write access to this register is ongoing. In this case, wait states are inserted in the second write access until the previous one is completed. The latency of the second write access can be up to 2xi2c_pclk+6xi2c_ker_ck.
  $04 constant I2C_I2C_CR2              \ Access: No wait states, except if a write access occurs while a write access to this register is ongoing. In this case, wait states are inserted in the second write access until the previous one is completed. The latency of the second write access can be up to 2 x i2c_pclk + 6 x i2c_ker_ck.
  $08 constant I2C_I2C_OAR1             \ Access: No wait states, except if a write access occurs while a write access to this register is ongoing. In this case, wait states are inserted in the second write access until the previous one is completed. The latency of the second write access can be up to 2 x i2c_pclk + 6 x i2c_ker_ck.
  $0C constant I2C_I2C_OAR2             \ Access: No wait states, except if a write access occurs while a write access to this register is ongoing. In this case, wait states are inserted in the second write access until the previous one is completed. The latency of the second write access can be up to 2 x i2c_pclk + 6 x i2c_ker_ck.
  $10 constant I2C_I2C_TIMINGR          \ Access: No wait states
  $14 constant I2C_I2C_TIMEOUTR         \ Access: No wait states, except if a write access occurs while a write access to this register is ongoing. In this case, wait states are inserted in the second write access until the previous one is completed. The latency of the second write access can be up to 2 x i2c_pclk + 6 x i2c_ker_ck.
  $18 constant I2C_I2C_ISR              \ Access: No wait states
  $1C constant I2C_I2C_ICR              \ Access: No wait states
  $20 constant I2C_I2C_PECR             \ Access: No wait states
  $24 constant I2C_I2C_RXDR             \ Access: No wait states
  $28 constant I2C_I2C_TXDR             \ Access: No wait states
  $3F0 constant I2C_I2C_HWCFGR          \ I2C hardware configuration register
  $3F4 constant I2C_I2C_VERR            \ I2C version register
  $3F8 constant I2C_I2C_IPIDR           \ I2C identification register
  $3FC constant I2C_I2C_SIDR            \ I2C size identification register

: I2C_DEF ; [then]
