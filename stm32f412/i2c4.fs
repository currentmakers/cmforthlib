\
\ @file i2c4.fs
\ @brief Inter-integrated circuit
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief Control register 1
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000001 constant I2C4_CR1_PE                                      \ Peripheral enable
$00000002 constant I2C4_CR1_TXIE                                    \ TXIE
$00000004 constant I2C4_CR1_RXIE                                    \ RXIE
$00000008 constant I2C4_CR1_ADDRE                                   \ ADDRE
$00000010 constant I2C4_CR1_NACKIE                                  \ NACKIE
$00000020 constant I2C4_CR1_STOPIE                                  \ STOPIE
$00000040 constant I2C4_CR1_TCIE                                    \ TCIE
$00000080 constant I2C4_CR1_ERRIE                                   \ ERRIE
$00000f00 constant I2C4_CR1_DNF                                     \ DNF
$00001000 constant I2C4_CR1_ANFOFF                                  \ ANFOFF
$00004000 constant I2C4_CR1_TCDMAEN                                 \ TCDMAEN
$00008000 constant I2C4_CR1_RXDMAEN                                 \ RXDMAEN
$00010000 constant I2C4_CR1_SBC                                     \ SBC
$00020000 constant I2C4_CR1_NOSTRETCH                               \ NOSTRETCH
$00040000 constant I2C4_CR1_WUPEN                                   \ WUPEN
$00080000 constant I2C4_CR1_GCEN                                    \ GCEN
$00100000 constant I2C4_CR1_SMBHEN                                  \ SMBHEN
$00200000 constant I2C4_CR1_SMBDEN                                  \ SMBDEN
$00400000 constant I2C4_CR1_ALERTEN                                 \ ALERTEN
$00800000 constant I2C4_CR1_PECEN                                   \ PECEN


\
\ @brief Control register 2
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant I2C4_CR2_SADD0                                   \ Slave address bit 0
$000000fe constant I2C4_CR2_SADD1_7                                 \ Slave address bit 7_1
$00000300 constant I2C4_CR2_SADD8_9                                 \ Slave address bit 8_9
$00000400 constant I2C4_CR2_RD_WRN                                  \ Transfer direction
$00000800 constant I2C4_CR2_ADD10                                   \ 10-bit addressing mode
$00001000 constant I2C4_CR2_HEAD10R                                 \ 10-bit address header only read direction
$00002000 constant I2C4_CR2_START                                   \ Start generation
$00004000 constant I2C4_CR2_STOP                                    \ Stop generation
$00008000 constant I2C4_CR2_NACK                                    \ NACK generation
$00ff0000 constant I2C4_CR2_NBYTES                                  \ Number of bytes
$01000000 constant I2C4_CR2_RELOAD                                  \ NBYTES reload mode
$02000000 constant I2C4_CR2_AUTOEND                                 \ Automatic end mode
$04000000 constant I2C4_CR2_PECBYTE                                 \ Packet error checking byte


\
\ @brief Own address register 1
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000001 constant I2C4_OAR1_OA1                                    \ OA1
$000000fe constant I2C4_OAR1_OA11_7                                 \ OA11_7
$00000300 constant I2C4_OAR1_OA18_9                                 \ OA18_9
$00000400 constant I2C4_OAR1_OA1MODE                                \ OA1MODE
$00008000 constant I2C4_OAR1_OA1EN                                  \ OA1EN


\
\ @brief Own address register 2
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$000000fe constant I2C4_OAR2_OA21_7                                 \ OA21_7
$00000700 constant I2C4_OAR2_OA2MSK                                 \ OA2MSK
$00008000 constant I2C4_OAR2_OA2EN                                  \ OA2EN


\
\ @brief Timing register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$000000ff constant I2C4_TIMINGR_SCLL                                \ SCLL
$0000ff00 constant I2C4_TIMINGR_SCLH                                \ SCLH
$000f0000 constant I2C4_TIMINGR_SDADEL                              \ SDADEL
$00f00000 constant I2C4_TIMINGR_SCLDEL                              \ SCLDEL
$f0000000 constant I2C4_TIMINGR_PRESC                               \ PRESC


\
\ @brief Timeout register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000fff constant I2C4_TIMEOUTR_TIMEOUTA                           \ TIMEOUTA
$00001000 constant I2C4_TIMEOUTR_TIDLE                              \ TIDLE
$00008000 constant I2C4_TIMEOUTR_TIMOUTEN                           \ TIMOUTEN
$0fff0000 constant I2C4_TIMEOUTR_TIMEOUTB                           \ TIMEOUTB
$80000000 constant I2C4_TIMEOUTR_TEXTEN                             \ TEXTEN


\
\ @brief Interrupt and Status register
\ Address offset: 0x18
\ Reset value: 0x00000001
\

$00000001 constant I2C4_ISR_TXE                                     \ TXE
$00000002 constant I2C4_ISR_TXIS                                    \ TXIS
$00000004 constant I2C4_ISR_RXNE                                    \ RXNE
$00000008 constant I2C4_ISR_ADDR                                    \ ADDR
$00000010 constant I2C4_ISR_NACKF                                   \ NACKF
$00000020 constant I2C4_ISR_STOPF                                   \ STOPF
$00000040 constant I2C4_ISR_TC                                      \ TC
$00000080 constant I2C4_ISR_TCR                                     \ TCR
$00000100 constant I2C4_ISR_BERR                                    \ BERR
$00000200 constant I2C4_ISR_ARLO                                    \ ARLO
$00000400 constant I2C4_ISR_OVR                                     \ OVR
$00000800 constant I2C4_ISR_PECERR                                  \ PECERR
$00001000 constant I2C4_ISR_TIMEOUT                                 \ TIMEOUT
$00002000 constant I2C4_ISR_ALERT                                   \ ALERT
$00008000 constant I2C4_ISR_BUSY                                    \ BUSY
$00010000 constant I2C4_ISR_DIR                                     \ DIR
$00fe0000 constant I2C4_ISR_ADDCODE                                 \ ADDCODE


\
\ @brief Interrupt clear register
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$00000008 constant I2C4_ICR_ADDRCF                                  \ ADDRCF
$00000010 constant I2C4_ICR_NACKCF                                  \ NACKCF
$00000020 constant I2C4_ICR_STOPCF                                  \ STOPCF
$00000100 constant I2C4_ICR_BERRCF                                  \ BERRCF
$00000200 constant I2C4_ICR_ARLOCF                                  \ ARLOCF
$00000400 constant I2C4_ICR_OVRCF                                   \ OVRCF
$00000800 constant I2C4_ICR_PECCF                                   \ PECCF
$00001000 constant I2C4_ICR_TIMOUTCF                                \ TIMOUTCF
$00002000 constant I2C4_ICR_ALERTC                                  \ ALERTC


\
\ @brief PEC register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$000000ff constant I2C4_PECR_PEC                                    \ PEC


\
\ @brief Receive data register
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$000000ff constant I2C4_RXDR_RXDATA                                 \ RXDATA


\
\ @brief Transmit data register
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$000000ff constant I2C4_TXDR_TXDATA                                 \ TXDATA


\
\ @brief Inter-integrated circuit
\
$40006000 constant I2C4_CR1       \ offset: 0x00 : Control register 1
$40006004 constant I2C4_CR2       \ offset: 0x04 : Control register 2
$40006008 constant I2C4_OAR1      \ offset: 0x08 : Own address register 1
$4000600c constant I2C4_OAR2      \ offset: 0x0C : Own address register 2
$40006010 constant I2C4_TIMINGR   \ offset: 0x10 : Timing register
$40006014 constant I2C4_TIMEOUTR  \ offset: 0x14 : Timeout register
$40006018 constant I2C4_ISR       \ offset: 0x18 : Interrupt and Status register
$4000601c constant I2C4_ICR       \ offset: 0x1C : Interrupt clear register
$40006020 constant I2C4_PECR      \ offset: 0x20 : PEC register
$40006024 constant I2C4_RXDR      \ offset: 0x24 : Receive data register
$40006028 constant I2C4_TXDR      \ offset: 0x28 : Transmit data register

