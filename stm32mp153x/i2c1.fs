\
\ @file i2c1.fs
\ @brief I2C1
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief Access: No wait states, except if a write access occurs while a write access to this register is ongoing. In this case, wait states are inserted in the second write access until the previous one is completed. The latency of the second write access can be up to 2xi2c_pclk+6xi2c_ker_ck.
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000001 constant I2C1_I2C_CR1_PE                                  \ PE
$00000002 constant I2C1_I2C_CR1_TXIE                                \ TXIE
$00000004 constant I2C1_I2C_CR1_RXIE                                \ RXIE
$00000008 constant I2C1_I2C_CR1_ADDRIE                              \ ADDRIE
$00000010 constant I2C1_I2C_CR1_NACKIE                              \ NACKIE
$00000020 constant I2C1_I2C_CR1_STOPIE                              \ STOPIE
$00000040 constant I2C1_I2C_CR1_TCIE                                \ TCIE
$00000080 constant I2C1_I2C_CR1_ERRIE                               \ ERRIE
$00000f00 constant I2C1_I2C_CR1_DNF                                 \ DNF
$00001000 constant I2C1_I2C_CR1_ANFOFF                              \ ANFOFF
$00004000 constant I2C1_I2C_CR1_TXDMAEN                             \ TXDMAEN
$00008000 constant I2C1_I2C_CR1_RXDMAEN                             \ RXDMAEN
$00010000 constant I2C1_I2C_CR1_SBC                                 \ SBC
$00020000 constant I2C1_I2C_CR1_NOSTRETCH                           \ NOSTRETCH
$00040000 constant I2C1_I2C_CR1_WUPEN                               \ WUPEN
$00080000 constant I2C1_I2C_CR1_GCEN                                \ GCEN
$00100000 constant I2C1_I2C_CR1_SMBHEN                              \ SMBHEN
$00200000 constant I2C1_I2C_CR1_SMBDEN                              \ SMBDEN
$00400000 constant I2C1_I2C_CR1_ALERTEN                             \ ALERTEN
$00800000 constant I2C1_I2C_CR1_PECEN                               \ PECEN


\
\ @brief Access: No wait states, except if a write access occurs while a write access to this register is ongoing. In this case, wait states are inserted in the second write access until the previous one is completed. The latency of the second write access can be up to 2 x i2c_pclk + 6 x i2c_ker_ck.
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$000003ff constant I2C1_I2C_CR2_SADD                                \ SADD
$00000400 constant I2C1_I2C_CR2_RD_WRN                              \ RD_WRN
$00000800 constant I2C1_I2C_CR2_ADD10                               \ ADD10
$00001000 constant I2C1_I2C_CR2_HEAD10R                             \ HEAD10R
$00002000 constant I2C1_I2C_CR2_START                               \ START
$00004000 constant I2C1_I2C_CR2_STOP                                \ STOP
$00008000 constant I2C1_I2C_CR2_NACK                                \ NACK
$00ff0000 constant I2C1_I2C_CR2_NBYTES                              \ NBYTES
$01000000 constant I2C1_I2C_CR2_RELOAD                              \ RELOAD
$02000000 constant I2C1_I2C_CR2_AUTOEND                             \ AUTOEND
$04000000 constant I2C1_I2C_CR2_PECBYTE                             \ PECBYTE


\
\ @brief Access: No wait states, except if a write access occurs while a write access to this register is ongoing. In this case, wait states are inserted in the second write access until the previous one is completed. The latency of the second write access can be up to 2 x i2c_pclk + 6 x i2c_ker_ck.
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$000003ff constant I2C1_I2C_OAR1_OA1                                \ OA1
$00000400 constant I2C1_I2C_OAR1_OA1MODE                            \ OA1MODE
$00008000 constant I2C1_I2C_OAR1_OA1EN                              \ OA1EN


\
\ @brief Access: No wait states, except if a write access occurs while a write access to this register is ongoing. In this case, wait states are inserted in the second write access until the previous one is completed. The latency of the second write access can be up to 2 x i2c_pclk + 6 x i2c_ker_ck.
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$000000fe constant I2C1_I2C_OAR2_OA2                                \ OA2
$00000700 constant I2C1_I2C_OAR2_OA2MSK                             \ OA2MSK
$00008000 constant I2C1_I2C_OAR2_OA2EN                              \ OA2EN


\
\ @brief Access: No wait states
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$000000ff constant I2C1_I2C_TIMINGR_SCLL                            \ SCLL
$0000ff00 constant I2C1_I2C_TIMINGR_SCLH                            \ SCLH
$000f0000 constant I2C1_I2C_TIMINGR_SDADEL                          \ SDADEL
$00f00000 constant I2C1_I2C_TIMINGR_SCLDEL                          \ SCLDEL
$f0000000 constant I2C1_I2C_TIMINGR_PRESC                           \ PRESC


\
\ @brief Access: No wait states, except if a write access occurs while a write access to this register is ongoing. In this case, wait states are inserted in the second write access until the previous one is completed. The latency of the second write access can be up to 2 x i2c_pclk + 6 x i2c_ker_ck.
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000fff constant I2C1_I2C_TIMEOUTR_TIMEOUTA                       \ TIMEOUTA
$00001000 constant I2C1_I2C_TIMEOUTR_TIDLE                          \ TIDLE
$00008000 constant I2C1_I2C_TIMEOUTR_TIMOUTEN                       \ TIMOUTEN
$0fff0000 constant I2C1_I2C_TIMEOUTR_TIMEOUTB                       \ TIMEOUTB
$80000000 constant I2C1_I2C_TIMEOUTR_TEXTEN                         \ TEXTEN


\
\ @brief Access: No wait states
\ Address offset: 0x18
\ Reset value: 0x00000001
\

$00000001 constant I2C1_I2C_ISR_TXE                                 \ TXE
$00000002 constant I2C1_I2C_ISR_TXIS                                \ TXIS
$00000004 constant I2C1_I2C_ISR_RXNE                                \ RXNE
$00000008 constant I2C1_I2C_ISR_ADDR                                \ ADDR
$00000010 constant I2C1_I2C_ISR_NACKF                               \ NACKF
$00000020 constant I2C1_I2C_ISR_STOPF                               \ STOPF
$00000040 constant I2C1_I2C_ISR_TC                                  \ TC
$00000080 constant I2C1_I2C_ISR_TCR                                 \ TCR
$00000100 constant I2C1_I2C_ISR_BERR                                \ BERR
$00000200 constant I2C1_I2C_ISR_ARLO                                \ ARLO
$00000400 constant I2C1_I2C_ISR_OVR                                 \ OVR
$00000800 constant I2C1_I2C_ISR_PECERR                              \ PECERR
$00001000 constant I2C1_I2C_ISR_TIMEOUT                             \ TIMEOUT
$00002000 constant I2C1_I2C_ISR_ALERT                               \ ALERT
$00008000 constant I2C1_I2C_ISR_BUSY                                \ BUSY
$00010000 constant I2C1_I2C_ISR_DIR                                 \ DIR
$00fe0000 constant I2C1_I2C_ISR_ADDCODE                             \ ADDCODE


\
\ @brief Access: No wait states
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$00000008 constant I2C1_I2C_ICR_ADDRCF                              \ ADDRCF
$00000010 constant I2C1_I2C_ICR_NACKCF                              \ NACKCF
$00000020 constant I2C1_I2C_ICR_STOPCF                              \ STOPCF
$00000100 constant I2C1_I2C_ICR_BERRCF                              \ BERRCF
$00000200 constant I2C1_I2C_ICR_ARLOCF                              \ ARLOCF
$00000400 constant I2C1_I2C_ICR_OVRCF                               \ OVRCF
$00000800 constant I2C1_I2C_ICR_PECCF                               \ PECCF
$00001000 constant I2C1_I2C_ICR_TIMOUTCF                            \ TIMOUTCF
$00002000 constant I2C1_I2C_ICR_ALERTCF                             \ ALERTCF


\
\ @brief Access: No wait states
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$000000ff constant I2C1_I2C_PECR_PEC                                \ PEC


\
\ @brief Access: No wait states
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$000000ff constant I2C1_I2C_RXDR_RXDATA                             \ RXDATA


\
\ @brief Access: No wait states
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$000000ff constant I2C1_I2C_TXDR_TXDATA                             \ TXDATA


\
\ @brief I2C hardware configuration register
\ Address offset: 0x3F0
\ Reset value: 0x00000111
\

$0000000f constant I2C1_I2C_HWCFGR_SMBUS                            \ SMBUS
$000000f0 constant I2C1_I2C_HWCFGR_ASYN                             \ ASYN
$00000f00 constant I2C1_I2C_HWCFGR_WKP                              \ WKP


\
\ @brief I2C version register
\ Address offset: 0x3F4
\ Reset value: 0x00000012
\

$0000000f constant I2C1_I2C_VERR_MINREV                             \ MINREV
$000000f0 constant I2C1_I2C_VERR_MAJREV                             \ MAJREV


\
\ @brief I2C identification register
\ Address offset: 0x3F8
\ Reset value: 0x00130012
\

$00000000 constant I2C1_I2C_IPIDR_ID                                \ ID


\
\ @brief I2C size identification register
\ Address offset: 0x3FC
\ Reset value: 0xA3C5DD01
\

$00000000 constant I2C1_I2C_SIDR_SID                                \ SID


\
\ @brief I2C1
\
$40012000 constant I2C1_I2C_CR1   \ offset: 0x00 : Access: No wait states, except if a write access occurs while a write access to this register is ongoing. In this case, wait states are inserted in the second write access until the previous one is completed. The latency of the second write access can be up to 2xi2c_pclk+6xi2c_ker_ck.
$40012004 constant I2C1_I2C_CR2   \ offset: 0x04 : Access: No wait states, except if a write access occurs while a write access to this register is ongoing. In this case, wait states are inserted in the second write access until the previous one is completed. The latency of the second write access can be up to 2 x i2c_pclk + 6 x i2c_ker_ck.
$40012008 constant I2C1_I2C_OAR1  \ offset: 0x08 : Access: No wait states, except if a write access occurs while a write access to this register is ongoing. In this case, wait states are inserted in the second write access until the previous one is completed. The latency of the second write access can be up to 2 x i2c_pclk + 6 x i2c_ker_ck.
$4001200c constant I2C1_I2C_OAR2  \ offset: 0x0C : Access: No wait states, except if a write access occurs while a write access to this register is ongoing. In this case, wait states are inserted in the second write access until the previous one is completed. The latency of the second write access can be up to 2 x i2c_pclk + 6 x i2c_ker_ck.
$40012010 constant I2C1_I2C_TIMINGR  \ offset: 0x10 : Access: No wait states
$40012014 constant I2C1_I2C_TIMEOUTR  \ offset: 0x14 : Access: No wait states, except if a write access occurs while a write access to this register is ongoing. In this case, wait states are inserted in the second write access until the previous one is completed. The latency of the second write access can be up to 2 x i2c_pclk + 6 x i2c_ker_ck.
$40012018 constant I2C1_I2C_ISR   \ offset: 0x18 : Access: No wait states
$4001201c constant I2C1_I2C_ICR   \ offset: 0x1C : Access: No wait states
$40012020 constant I2C1_I2C_PECR  \ offset: 0x20 : Access: No wait states
$40012024 constant I2C1_I2C_RXDR  \ offset: 0x24 : Access: No wait states
$40012028 constant I2C1_I2C_TXDR  \ offset: 0x28 : Access: No wait states
$400123f0 constant I2C1_I2C_HWCFGR  \ offset: 0x3F0 : I2C hardware configuration register
$400123f4 constant I2C1_I2C_VERR  \ offset: 0x3F4 : I2C version register
$400123f8 constant I2C1_I2C_IPIDR  \ offset: 0x3F8 : I2C identification register
$400123fc constant I2C1_I2C_SIDR  \ offset: 0x3FC : I2C size identification register

