\
\ @file i2c2.fs
\ @brief I2C1 global interrupt
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

$00000001 constant I2C2_CR1_PE                                      \ Peripheral enable
$00000002 constant I2C2_CR1_TXIE                                    \ TX Interrupt enable
$00000004 constant I2C2_CR1_RXIE                                    \ RX Interrupt enable
$00000008 constant I2C2_CR1_ADDRIE                                  \ Address match interrupt enable (slave only)
$00000010 constant I2C2_CR1_NACKIE                                  \ Not acknowledge received interrupt enable
$00000020 constant I2C2_CR1_STOPIE                                  \ STOP detection Interrupt enable
$00000040 constant I2C2_CR1_TCIE                                    \ Transfer Complete interrupt enable
$00000080 constant I2C2_CR1_ERRIE                                   \ Error interrupts enable
$00000f00 constant I2C2_CR1_DNF                                     \ Digital noise filter
$00001000 constant I2C2_CR1_ANFOFF                                  \ Analog noise filter OFF
$00004000 constant I2C2_CR1_TXDMAEN                                 \ DMA transmission requests enable
$00008000 constant I2C2_CR1_RXDMAEN                                 \ DMA reception requests enable
$00010000 constant I2C2_CR1_SBC                                     \ Slave byte control
$00020000 constant I2C2_CR1_NOSTRETCH                               \ Clock stretching disable
$00040000 constant I2C2_CR1_WUPEN                                   \ Wakeup from STOP enable
$00080000 constant I2C2_CR1_GCEN                                    \ General call enable
$00100000 constant I2C2_CR1_SMBHEN                                  \ SMBus Host address enable
$00200000 constant I2C2_CR1_SMBDEN                                  \ SMBus Device Default address enable
$00400000 constant I2C2_CR1_ALERTEN                                 \ SMBUS alert enable
$00800000 constant I2C2_CR1_PECEN                                   \ PEC enable


\
\ @brief Control register 2
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$000003ff constant I2C2_CR2_SADD                                    \ Slave address bit (master mode)
$00000400 constant I2C2_CR2_RD_WRN                                  \ Transfer direction (master mode)
$00000800 constant I2C2_CR2_ADD10                                   \ 10-bit addressing mode (master mode)
$00001000 constant I2C2_CR2_HEAD10R                                 \ 10-bit address header only read direction (master receiver mode)
$00002000 constant I2C2_CR2_START                                   \ Start generation
$00004000 constant I2C2_CR2_STOP                                    \ Stop generation (master mode)
$00008000 constant I2C2_CR2_NACK                                    \ NACK generation (slave mode)
$00ff0000 constant I2C2_CR2_NBYTES                                  \ Number of bytes
$01000000 constant I2C2_CR2_RELOAD                                  \ NBYTES reload mode
$02000000 constant I2C2_CR2_AUTOEND                                 \ Automatic end mode (master mode)
$04000000 constant I2C2_CR2_PECBYTE                                 \ Packet error checking byte


\
\ @brief Own address register 1
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$000003ff constant I2C2_OAR1_OA1                                    \ Interface address
$00000400 constant I2C2_OAR1_OA1MODE                                \ Own Address 1 10-bit mode
$00008000 constant I2C2_OAR1_OA1EN                                  \ Own Address 1 enable


\
\ @brief Own address register 2
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$000000fe constant I2C2_OAR2_OA2                                    \ Interface address
$00000700 constant I2C2_OAR2_OA2MSK                                 \ Own Address 2 masks
$00008000 constant I2C2_OAR2_OA2EN                                  \ Own Address 2 enable


\
\ @brief Timing register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$000000ff constant I2C2_TIMINGR_SCLL                                \ SCL low period (master mode)
$0000ff00 constant I2C2_TIMINGR_SCLH                                \ SCL high period (master mode)
$000f0000 constant I2C2_TIMINGR_SDADEL                              \ Data hold time
$00f00000 constant I2C2_TIMINGR_SCLDEL                              \ Data setup time
$f0000000 constant I2C2_TIMINGR_PRESC                               \ Timing prescaler


\
\ @brief Status register 1
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000fff constant I2C2_TIMEOUTR_TIMEOUTA                           \ Bus timeout A
$00001000 constant I2C2_TIMEOUTR_TIDLE                              \ Idle clock timeout detection
$00008000 constant I2C2_TIMEOUTR_TIMOUTEN                           \ Clock timeout enable
$0fff0000 constant I2C2_TIMEOUTR_TIMEOUTB                           \ Bus timeout B
$80000000 constant I2C2_TIMEOUTR_TEXTEN                             \ Extended clock timeout enable


\
\ @brief Interrupt and Status register
\ Address offset: 0x18
\ Reset value: 0x00000001
\

$00000001 constant I2C2_ISR_TXE                                     \ Transmit data register empty (transmitters)
$00000002 constant I2C2_ISR_TXIS                                    \ Transmit interrupt status (transmitters)
$00000004 constant I2C2_ISR_RXNE                                    \ Receive data register not empty (receivers)
$00000008 constant I2C2_ISR_ADDR                                    \ Address matched (slave mode)
$00000010 constant I2C2_ISR_NACKF                                   \ Not acknowledge received flag
$00000020 constant I2C2_ISR_STOPF                                   \ Stop detection flag
$00000040 constant I2C2_ISR_TC                                      \ Transfer Complete (master mode)
$00000080 constant I2C2_ISR_TCR                                     \ Transfer Complete Reload
$00000100 constant I2C2_ISR_BERR                                    \ Bus error
$00000200 constant I2C2_ISR_ARLO                                    \ Arbitration lost
$00000400 constant I2C2_ISR_OVR                                     \ Overrun/Underrun (slave mode)
$00000800 constant I2C2_ISR_PECERR                                  \ PEC Error in reception
$00001000 constant I2C2_ISR_TIMEOUT                                 \ Timeout or t_low detection flag
$00002000 constant I2C2_ISR_ALERT                                   \ SMBus alert
$00008000 constant I2C2_ISR_BUSY                                    \ Bus busy
$00010000 constant I2C2_ISR_DIR                                     \ Transfer direction (Slave mode)
$00fe0000 constant I2C2_ISR_ADDCODE                                 \ Address match code (Slave mode)


\
\ @brief Interrupt clear register
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$00000008 constant I2C2_ICR_ADDRCF                                  \ Address Matched flag clear
$00000010 constant I2C2_ICR_NACKCF                                  \ Not Acknowledge flag clear
$00000020 constant I2C2_ICR_STOPCF                                  \ Stop detection flag clear
$00000100 constant I2C2_ICR_BERRCF                                  \ Bus error flag clear
$00000200 constant I2C2_ICR_ARLOCF                                  \ Arbitration lost flag clear
$00000400 constant I2C2_ICR_OVRCF                                   \ Overrun/Underrun flag clear
$00000800 constant I2C2_ICR_PECCF                                   \ PEC Error flag clear
$00001000 constant I2C2_ICR_TIMOUTCF                                \ Timeout detection flag clear
$00002000 constant I2C2_ICR_ALERTCF                                 \ Alert flag clear


\
\ @brief PEC register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$000000ff constant I2C2_PECR_PEC                                    \ Packet error checking register


\
\ @brief Receive data register
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$000000ff constant I2C2_RXDR_RXDATA                                 \ 8-bit receive data


\
\ @brief Transmit data register
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$000000ff constant I2C2_TXDR_TXDATA                                 \ 8-bit transmit data


\
\ @brief I2C1 global interrupt
\
$40005800 constant I2C2_CR1       \ offset: 0x00 : Control register 1
$40005804 constant I2C2_CR2       \ offset: 0x04 : Control register 2
$40005808 constant I2C2_OAR1      \ offset: 0x08 : Own address register 1
$4000580c constant I2C2_OAR2      \ offset: 0x0C : Own address register 2
$40005810 constant I2C2_TIMINGR   \ offset: 0x10 : Timing register
$40005814 constant I2C2_TIMEOUTR  \ offset: 0x14 : Status register 1
$40005818 constant I2C2_ISR       \ offset: 0x18 : Interrupt and Status register
$4000581c constant I2C2_ICR       \ offset: 0x1C : Interrupt clear register
$40005820 constant I2C2_PECR      \ offset: 0x20 : PEC register
$40005824 constant I2C2_RXDR      \ offset: 0x24 : Receive data register
$40005828 constant I2C2_TXDR      \ offset: 0x28 : Transmit data register

