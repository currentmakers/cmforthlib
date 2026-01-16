\
\ @file fmpi2c.fs
\ @brief Fast-mode Plus Inter-integrated circuit       interface
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

$00000001 constant FMPI2C_CR1_PE                                    \ Peripheral enable
$00000002 constant FMPI2C_CR1_TXIE                                  \ TX Interrupt enable
$00000004 constant FMPI2C_CR1_RXIE                                  \ RX Interrupt enable
$00000008 constant FMPI2C_CR1_ADDRIE                                \ Address match Interrupt enable (slave only)
$00000010 constant FMPI2C_CR1_NACKIE                                \ Not acknowledge received Interrupt enable
$00000020 constant FMPI2C_CR1_STOPIE                                \ STOP detection Interrupt enable
$00000040 constant FMPI2C_CR1_TCIE                                  \ Transfer Complete interrupt enable
$00000080 constant FMPI2C_CR1_ERRIE                                 \ Error interrupts enable
$00000f00 constant FMPI2C_CR1_DNF                                   \ Digital noise filter
$00001000 constant FMPI2C_CR1_ANFOFF                                \ Analog noise filter OFF
$00004000 constant FMPI2C_CR1_TXDMAEN                               \ DMA transmission requests enable
$00008000 constant FMPI2C_CR1_RXDMAEN                               \ DMA reception requests enable
$00010000 constant FMPI2C_CR1_SBC                                   \ Slave byte control
$00020000 constant FMPI2C_CR1_NOSTRETCH                             \ Clock stretching disable
$00080000 constant FMPI2C_CR1_GCEN                                  \ General call enable
$00100000 constant FMPI2C_CR1_SMBHEN                                \ SMBus Host address enable
$00200000 constant FMPI2C_CR1_SMBDEN                                \ SMBus Device Default address enable
$00400000 constant FMPI2C_CR1_ALERTEN                               \ SMBus alert enable
$00800000 constant FMPI2C_CR1_PECEN                                 \ PEC enable


\
\ @brief Control register 1
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant FMPI2C_CR2_SADD0                                 \ Slave address bit 0 (master mode)
$000000fe constant FMPI2C_CR2_SADD7_1                               \ Slave address bit 7:1 (master mode)
$00000300 constant FMPI2C_CR2_SADD9_8                               \ Slave address bit 9:8 (master mode)
$00000400 constant FMPI2C_CR2_RD_WRN                                \ Transfer direction (master mode)
$00000800 constant FMPI2C_CR2_ADD10                                 \ 10-bit addressing mode (master mode)
$00001000 constant FMPI2C_CR2_HEAD10R                               \ 10-bit address header only read direction (master receiver mode)
$00002000 constant FMPI2C_CR2_START                                 \ Start generation
$00004000 constant FMPI2C_CR2_STOP                                  \ Stop generation (master mode)
$00008000 constant FMPI2C_CR2_NACK                                  \ NACK generation (slave mode)
$00ff0000 constant FMPI2C_CR2_NBYTES                                \ Number of bytes
$01000000 constant FMPI2C_CR2_RELOAD                                \ NBYTES reload mode
$02000000 constant FMPI2C_CR2_AUTOEND                               \ Automatic end mode (master mode)
$04000000 constant FMPI2C_CR2_PECBYTE                               \ Packet error checking byte


\
\ @brief Own address 1 register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000001 constant FMPI2C_OAR1_OA1_0                                \ Interface address
$000000fe constant FMPI2C_OAR1_OA1_7_1                              \ Interface address
$00000300 constant FMPI2C_OAR1_OA1_9_8                              \ Interface address
$00000400 constant FMPI2C_OAR1_OA1MODE                              \ Own Address 1 10-bit mode
$00008000 constant FMPI2C_OAR1_OA1EN                                \ Own Address 1 enable


\
\ @brief Own address 2 register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$000000fe constant FMPI2C_OAR2_OA2                                  \ Interface address
$00000700 constant FMPI2C_OAR2_OA2MSK                               \ Own Address 2 masks
$00008000 constant FMPI2C_OAR2_OA2EN                                \ Own Address 2 enable


\
\ @brief Timing register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$000000ff constant FMPI2C_TIMINGR_SCLL                              \ SCL low period (master mode)
$0000ff00 constant FMPI2C_TIMINGR_SCLH                              \ SCL high period (master mode)
$000f0000 constant FMPI2C_TIMINGR_SDADEL                            \ Data hold time
$00f00000 constant FMPI2C_TIMINGR_SCLDEL                            \ Data setup time
$f0000000 constant FMPI2C_TIMINGR_PRESC                             \ Timing prescaler


\
\ @brief Timeout register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000fff constant FMPI2C_TIMEOUTR_TIMEOUTA                         \ Bus Timeout A
$00001000 constant FMPI2C_TIMEOUTR_TIDLE                            \ Idle clock timeout detection
$00008000 constant FMPI2C_TIMEOUTR_TIMOUTEN                         \ Clock timeout enable
$0fff0000 constant FMPI2C_TIMEOUTR_TIMEOUTB                         \ Bus timeout B
$80000000 constant FMPI2C_TIMEOUTR_TEXTEN                           \ Extended clock timeout enable


\
\ @brief Interrupt and status register
\ Address offset: 0x18
\ Reset value: 0x00000001
\

$00000001 constant FMPI2C_ISR_TXE                                   \ Transmit data register empty (transmitters)
$00000002 constant FMPI2C_ISR_TXIS                                  \ Transmit interrupt status (transmitters)
$00000004 constant FMPI2C_ISR_RXNE                                  \ Receive data register not empty (receivers)
$00000008 constant FMPI2C_ISR_ADDR                                  \ Address matched (slave mode)
$00000010 constant FMPI2C_ISR_NACKF                                 \ Not Acknowledge received flag
$00000020 constant FMPI2C_ISR_STOPF                                 \ Stop detection flag
$00000040 constant FMPI2C_ISR_TC                                    \ Transfer Complete (master mode)
$00000080 constant FMPI2C_ISR_TCR                                   \ Transfer Complete Reload
$00000100 constant FMPI2C_ISR_BERR                                  \ Bus error
$00000200 constant FMPI2C_ISR_ARLO                                  \ Arbitration lost
$00000400 constant FMPI2C_ISR_OVR                                   \ Overrun/Underrun (slave mode)
$00000800 constant FMPI2C_ISR_PECERR                                \ PEC Error in reception
$00001000 constant FMPI2C_ISR_TIMEOUT                               \ Timeout or tLOW detection flag
$00002000 constant FMPI2C_ISR_ALERT                                 \ SMBus alert
$00008000 constant FMPI2C_ISR_BUSY                                  \ Bus busy
$00010000 constant FMPI2C_ISR_DIR                                   \ Transfer direction (Slave mode)
$00fe0000 constant FMPI2C_ISR_ADDCODE                               \ Address match code (Slave mode)


\
\ @brief Interrupt clear register
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$00000008 constant FMPI2C_ICR_ADDRCF                                \ Address matched flag clear
$00000010 constant FMPI2C_ICR_NACKCF                                \ Not Acknowledge flag clear
$00000020 constant FMPI2C_ICR_STOPCF                                \ Stop detection flag clear
$00000100 constant FMPI2C_ICR_BERRCF                                \ Bus error flag clear
$00000200 constant FMPI2C_ICR_ARLOCF                                \ Arbitration Lost flag clear
$00000400 constant FMPI2C_ICR_OVRCF                                 \ Overrun/Underrun flag clear
$00000800 constant FMPI2C_ICR_PECCF                                 \ PEC Error flag clear
$00001000 constant FMPI2C_ICR_TIMOUTCF                              \ Timeout detection flag clear
$00002000 constant FMPI2C_ICR_ALERTCF                               \ Alert flag clear


\
\ @brief PEC register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$000000ff constant FMPI2C_PECR_PEC                                  \ Packet error checking register


\
\ @brief Receive data register
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$000000ff constant FMPI2C_RXDR_RXDATA                               \ 8-bit receive data


\
\ @brief Transmit data register
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$000000ff constant FMPI2C_TXDR_TXDATA                               \ 8-bit transmit data


\
\ @brief Fast-mode Plus Inter-integrated circuit interface
\
$40006000 constant FMPI2C_CR1     \ offset: 0x00 : Control register 1
$40006004 constant FMPI2C_CR2     \ offset: 0x04 : Control register 1
$40006008 constant FMPI2C_OAR1    \ offset: 0x08 : Own address 1 register
$4000600c constant FMPI2C_OAR2    \ offset: 0x0C : Own address 2 register
$40006010 constant FMPI2C_TIMINGR  \ offset: 0x10 : Timing register
$40006014 constant FMPI2C_TIMEOUTR  \ offset: 0x14 : Timeout register
$40006018 constant FMPI2C_ISR     \ offset: 0x18 : Interrupt and status register
$4000601c constant FMPI2C_ICR     \ offset: 0x1C : Interrupt clear register
$40006020 constant FMPI2C_PECR    \ offset: 0x20 : PEC register
$40006024 constant FMPI2C_RXDR    \ offset: 0x24 : Receive data register
$40006028 constant FMPI2C_TXDR    \ offset: 0x28 : Transmit data register

