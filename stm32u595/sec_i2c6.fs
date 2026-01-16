\
\ @file sec_i2c6.fs
\ @brief I2C6 error interrupt
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

$00000001 constant SEC_I2C6_CR1_PE                                  \ Peripheral enable
$00000002 constant SEC_I2C6_CR1_TXIE                                \ TX Interrupt enable
$00000004 constant SEC_I2C6_CR1_RXIE                                \ RX Interrupt enable
$00000008 constant SEC_I2C6_CR1_ADDRIE                              \ Address match interrupt enable (slave only)
$00000010 constant SEC_I2C6_CR1_NACKIE                              \ Not acknowledge received interrupt enable
$00000020 constant SEC_I2C6_CR1_STOPIE                              \ STOP detection Interrupt enable
$00000040 constant SEC_I2C6_CR1_TCIE                                \ Transfer Complete interrupt enable
$00000080 constant SEC_I2C6_CR1_ERRIE                               \ Error interrupts enable
$00000f00 constant SEC_I2C6_CR1_DNF                                 \ Digital noise filter
$00001000 constant SEC_I2C6_CR1_ANFOFF                              \ Analog noise filter OFF
$00004000 constant SEC_I2C6_CR1_TXDMAEN                             \ DMA transmission requests enable
$00008000 constant SEC_I2C6_CR1_RXDMAEN                             \ DMA reception requests enable
$00010000 constant SEC_I2C6_CR1_SBC                                 \ Slave byte control
$00020000 constant SEC_I2C6_CR1_NOSTRETCH                           \ Clock stretching disable
$00040000 constant SEC_I2C6_CR1_WUPEN                               \ Wakeup from STOP enable
$00080000 constant SEC_I2C6_CR1_GCEN                                \ General call enable
$00100000 constant SEC_I2C6_CR1_SMBHEN                              \ SMBus Host address enable
$00200000 constant SEC_I2C6_CR1_SMBDEN                              \ SMBus Device Default address enable
$00400000 constant SEC_I2C6_CR1_ALERTEN                             \ SMBUS alert enable
$00800000 constant SEC_I2C6_CR1_PECEN                               \ PEC enable
$01000000 constant SEC_I2C6_CR1_FMP                                 \ Fast-mode Plus 20 mA drive enable
$40000000 constant SEC_I2C6_CR1_ADDRACLR                            \ Address match flag (ADDR) automatic clear
$80000000 constant SEC_I2C6_CR1_STOPFACLR                           \ STOP detection flag (STOPF) automatic clear


\
\ @brief Control register 2
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$000003ff constant SEC_I2C6_CR2_SADD                                \ Slave address bit (master mode)
$00000400 constant SEC_I2C6_CR2_RD_WRN                              \ Transfer direction (master mode)
$00000800 constant SEC_I2C6_CR2_ADD10                               \ 10-bit addressing mode (master mode)
$00001000 constant SEC_I2C6_CR2_HEAD10R                             \ 10-bit address header only read direction (master receiver mode)
$00002000 constant SEC_I2C6_CR2_START                               \ Start generation
$00004000 constant SEC_I2C6_CR2_STOP                                \ Stop generation (master mode)
$00008000 constant SEC_I2C6_CR2_NACK                                \ NACK generation (slave mode)
$00ff0000 constant SEC_I2C6_CR2_NBYTES                              \ Number of bytes
$01000000 constant SEC_I2C6_CR2_RELOAD                              \ NBYTES reload mode
$02000000 constant SEC_I2C6_CR2_AUTOEND                             \ Automatic end mode (master mode)
$04000000 constant SEC_I2C6_CR2_PECBYTE                             \ Packet error checking byte


\
\ @brief Own address register 1
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$000003ff constant SEC_I2C6_OAR1_OA1                                \ Interface address
$00000400 constant SEC_I2C6_OAR1_OA1MODE                            \ Own Address 1 10-bit mode
$00008000 constant SEC_I2C6_OAR1_OA1EN                              \ Own Address 1 enable


\
\ @brief Own address register 2
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$000000fe constant SEC_I2C6_OAR2_OA2                                \ Interface address
$00000700 constant SEC_I2C6_OAR2_OA2MSK                             \ Own Address 2 masks
$00008000 constant SEC_I2C6_OAR2_OA2EN                              \ Own Address 2 enable


\
\ @brief Timing register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$000000ff constant SEC_I2C6_TIMINGR_SCLL                            \ SCL low period (master mode)
$0000ff00 constant SEC_I2C6_TIMINGR_SCLH                            \ SCL high period (master mode)
$000f0000 constant SEC_I2C6_TIMINGR_SDADEL                          \ Data hold time
$00f00000 constant SEC_I2C6_TIMINGR_SCLDEL                          \ Data setup time
$f0000000 constant SEC_I2C6_TIMINGR_PRESC                           \ Timing prescaler


\
\ @brief Status register 1
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000fff constant SEC_I2C6_TIMEOUTR_TIMEOUTA                       \ Bus timeout A
$00001000 constant SEC_I2C6_TIMEOUTR_TIDLE                          \ Idle clock timeout detection
$00008000 constant SEC_I2C6_TIMEOUTR_TIMOUTEN                       \ Clock timeout enable
$0fff0000 constant SEC_I2C6_TIMEOUTR_TIMEOUTB                       \ Bus timeout B
$80000000 constant SEC_I2C6_TIMEOUTR_TEXTEN                         \ Extended clock timeout enable


\
\ @brief Interrupt and Status register
\ Address offset: 0x18
\ Reset value: 0x00000001
\

$00000001 constant SEC_I2C6_ISR_TXE                                 \ Transmit data register empty (transmitters)
$00000002 constant SEC_I2C6_ISR_TXIS                                \ Transmit interrupt status (transmitters)
$00000004 constant SEC_I2C6_ISR_RXNE                                \ Receive data register not empty (receivers)
$00000008 constant SEC_I2C6_ISR_ADDR                                \ Address matched (slave mode)
$00000010 constant SEC_I2C6_ISR_NACKF                               \ Not acknowledge received flag
$00000020 constant SEC_I2C6_ISR_STOPF                               \ Stop detection flag
$00000040 constant SEC_I2C6_ISR_TC                                  \ Transfer Complete (master mode)
$00000080 constant SEC_I2C6_ISR_TCR                                 \ Transfer Complete Reload
$00000100 constant SEC_I2C6_ISR_BERR                                \ Bus error
$00000200 constant SEC_I2C6_ISR_ARLO                                \ Arbitration lost
$00000400 constant SEC_I2C6_ISR_OVR                                 \ Overrun/Underrun (slave mode)
$00000800 constant SEC_I2C6_ISR_PECERR                              \ PEC Error in reception
$00001000 constant SEC_I2C6_ISR_TIMEOUT                             \ Timeout or t_low detection flag
$00002000 constant SEC_I2C6_ISR_ALERT                               \ SMBus alert
$00008000 constant SEC_I2C6_ISR_BUSY                                \ Bus busy
$00010000 constant SEC_I2C6_ISR_DIR                                 \ Transfer direction (Slave mode)
$00fe0000 constant SEC_I2C6_ISR_ADDCODE                             \ Address match code (Slave mode)


\
\ @brief Interrupt clear register
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$00000008 constant SEC_I2C6_ICR_ADDRCF                              \ Address Matched flag clear
$00000010 constant SEC_I2C6_ICR_NACKCF                              \ Not Acknowledge flag clear
$00000020 constant SEC_I2C6_ICR_STOPCF                              \ Stop detection flag clear
$00000100 constant SEC_I2C6_ICR_BERRCF                              \ Bus error flag clear
$00000200 constant SEC_I2C6_ICR_ARLOCF                              \ Arbitration lost flag clear
$00000400 constant SEC_I2C6_ICR_OVRCF                               \ Overrun/Underrun flag clear
$00000800 constant SEC_I2C6_ICR_PECCF                               \ PEC Error flag clear
$00001000 constant SEC_I2C6_ICR_TIMOUTCF                            \ Timeout detection flag clear
$00002000 constant SEC_I2C6_ICR_ALERTCF                             \ Alert flag clear


\
\ @brief PEC register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$000000ff constant SEC_I2C6_PECR_PEC                                \ Packet error checking register


\
\ @brief Receive data register
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$000000ff constant SEC_I2C6_RXDR_RXDATA                             \ 8-bit receive data


\
\ @brief Transmit data register
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$000000ff constant SEC_I2C6_TXDR_TXDATA                             \ 8-bit transmit data


\
\ @brief I2C Autonomous mode control register
\ Address offset: 0x2C
\ Reset value: 0x00000000
\

$00000040 constant SEC_I2C6_I2C_AUTOCR_TCDMAEN                      \ DMA request enable on Transfer Complete event
$00000080 constant SEC_I2C6_I2C_AUTOCR_TCRDMAEN                     \ DMA request enable on Transfer Complete Reload event
$000f0000 constant SEC_I2C6_I2C_AUTOCR_TRIGSEL                      \ Trigger selection
$00100000 constant SEC_I2C6_I2C_AUTOCR_TRIGPOL                      \ Trigger polarity
$00200000 constant SEC_I2C6_I2C_AUTOCR_TRIGEN                       \ Trigger enable


\
\ @brief I2C6 error interrupt
\
$50009c00 constant SEC_I2C6_CR1   \ offset: 0x00 : Control register 1
$50009c04 constant SEC_I2C6_CR2   \ offset: 0x04 : Control register 2
$50009c08 constant SEC_I2C6_OAR1  \ offset: 0x08 : Own address register 1
$50009c0c constant SEC_I2C6_OAR2  \ offset: 0x0C : Own address register 2
$50009c10 constant SEC_I2C6_TIMINGR  \ offset: 0x10 : Timing register
$50009c14 constant SEC_I2C6_TIMEOUTR  \ offset: 0x14 : Status register 1
$50009c18 constant SEC_I2C6_ISR   \ offset: 0x18 : Interrupt and Status register
$50009c1c constant SEC_I2C6_ICR   \ offset: 0x1C : Interrupt clear register
$50009c20 constant SEC_I2C6_PECR  \ offset: 0x20 : PEC register
$50009c24 constant SEC_I2C6_RXDR  \ offset: 0x24 : Receive data register
$50009c28 constant SEC_I2C6_TXDR  \ offset: 0x28 : Transmit data register
$50009c2c constant SEC_I2C6_I2C_AUTOCR  \ offset: 0x2C : I2C Autonomous mode control register

