\
\ @file i2c3.fs
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

$00000001 constant I2C3_I2C_CR1_PE                                  \ Peripheral enable Note: When PE=0, the I2C SCL and SDA lines are released. Internal state machines and status bits are put back to their reset value. When cleared, PE must be kept low for at least 3 APB clock cycles.
$00000002 constant I2C3_I2C_CR1_TXIE                                \ TX Interrupt enable
$00000004 constant I2C3_I2C_CR1_RXIE                                \ RX Interrupt enable
$00000008 constant I2C3_I2C_CR1_ADDRIE                              \ Address match Interrupt enable (slave only)
$00000010 constant I2C3_I2C_CR1_NACKIE                              \ Not acknowledge received Interrupt enable
$00000020 constant I2C3_I2C_CR1_STOPIE                              \ Stop detection Interrupt enable
$00000040 constant I2C3_I2C_CR1_TCIE                                \ Transfer Complete interrupt enable Note: Any of these events generate an interrupt: Transfer Complete (TC) Transfer Complete Reload (TCR)
$00000080 constant I2C3_I2C_CR1_ERRIE                               \ Error interrupts enable Note: Any of these errors generate an interrupt: Arbitration Loss (ARLO) Bus Error detection (BERR) Overrun/Underrun (OVR) Timeout detection (TIMEOUT) PEC error detection (PECERR) Alert pin event detection (ALERT)
$00000f00 constant I2C3_I2C_CR1_DNF                                 \ Digital noise filter These bits are used to configure the digital noise filter on SDA and SCL input. The digital filter, filters spikes with a length of up to DNF[3:0] * tI2CCLK ... Note: If the analog filter is also enabled, the digital filter is added to the analog filter. This filter can only be programmed when the I2C is disabled (PE = 0).
$00001000 constant I2C3_I2C_CR1_ANFOFF                              \ Analog noise filter OFF Note: This bit can only be programmed when the I2C is disabled (PE = 0).
$00004000 constant I2C3_I2C_CR1_TXDMAEN                             \ DMA transmission requests enable
$00008000 constant I2C3_I2C_CR1_RXDMAEN                             \ DMA reception requests enable
$00010000 constant I2C3_I2C_CR1_SBC                                 \ Slave byte control This bit is used to enable hardware byte control in slave mode.
$00020000 constant I2C3_I2C_CR1_NOSTRETCH                           \ Clock stretching disable This bit is used to disable clock stretching in slave mode. It must be kept cleared in master mode. Note: This bit can only be programmed when the I2C is disabled (PE = 0).
$00040000 constant I2C3_I2C_CR1_WUPEN                               \ Wakeup from Stop mode enable Note: If the Wakeup from Stop mode feature is not supported, this bit is reserved and forced by hardware to '0'. Refer to . Note: WUPEN can be set only when DNF = '0000'
$00080000 constant I2C3_I2C_CR1_GCEN                                \ General call enable
$00100000 constant I2C3_I2C_CR1_SMBHEN                              \ SMBus Host Address enable Note: If the SMBus feature is not supported, this bit is reserved and forced by hardware to '0'. Refer to .
$00200000 constant I2C3_I2C_CR1_SMBDEN                              \ SMBus Device Default Address enable Note: If the SMBus feature is not supported, this bit is reserved and forced by hardware to '0'. Refer to .
$00400000 constant I2C3_I2C_CR1_ALERTEN                             \ SMBus alert enable Note: When ALERTEN=0, the SMBA pin can be used as a standard GPIO. If the SMBus feature is not supported, this bit is reserved and forced by hardware to '0'. Refer to .
$00800000 constant I2C3_I2C_CR1_PECEN                               \ PEC enable Note: If the SMBus feature is not supported, this bit is reserved and forced by hardware to '0'. Refer to .


\
\ @brief Control register 2
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$000003ff constant I2C3_I2C_CR2_SADD                                \ Slave address (master mode) In 7-bit addressing mode (ADD10 = 0): SADD[7:1] should be written with the 7-bit slave address to be sent. The bits SADD[9], SADD[8] and SADD[0] are don't care. In 10-bit addressing mode (ADD10 = 1): SADD[9:0] should be written with the 10-bit slave address to be sent. Note: Changing these bits when the START bit is set is not allowed.
$00000400 constant I2C3_I2C_CR2_RD_WRN                              \ Transfer direction (master mode) Note: Changing this bit when the START bit is set is not allowed.
$00000800 constant I2C3_I2C_CR2_ADD10                               \ 10-bit addressing mode (master mode) Note: Changing this bit when the START bit is set is not allowed.
$00001000 constant I2C3_I2C_CR2_HEAD10R                             \ 10-bit address header only read direction (master receiver mode) Note: Changing this bit when the START bit is set is not allowed.
$00002000 constant I2C3_I2C_CR2_START                               \ Start generation This bit is set by software, and cleared by hardware after the Start followed by the address sequence is sent, by an arbitration loss, by a timeout error detection, or when PE = 0. It can also be cleared by software by writing '1' to the ADDRCF bit in the I2C_ICR register. If the I2C is already in master mode with AUTOEND = 0, setting this bit generates a Repeated Start condition when RELOAD=0, after the end of the NBYTES transfer. Otherwise setting this bit generates a START condition once the bus is free. Note: Writing '0' to this bit has no effect. The START bit can be set even if the bus is BUSY or I2C is in slave mode. This bit has no effect when RELOAD is set.
$00004000 constant I2C3_I2C_CR2_STOP                                \ Stop generation (master mode) The bit is set by software, cleared by hardware when a STOP condition is detected, or when PE = 0. In Master Mode: Note: Writing '0' to this bit has no effect.
$00008000 constant I2C3_I2C_CR2_NACK                                \ NACK generation (slave mode) The bit is set by software, cleared by hardware when the NACK is sent, or when a STOP condition or an Address matched is received, or when PE=0. Note: Writing '0' to this bit has no effect. This bit is used in slave mode only: in master receiver mode, NACK is automatically generated after last byte preceding STOP or RESTART condition, whatever the NACK bit value. When an overrun occurs in slave receiver NOSTRETCH mode, a NACK is automatically generated whatever the NACK bit value. When hardware PEC checking is enabled (PECBYTE=1), the PEC acknowledge value does not depend on the NACK value.
$00ff0000 constant I2C3_I2C_CR2_NBYTES                              \ Number of bytes The number of bytes to be transmitted/received is programmed there. This field is don't care in slave mode with SBC=0. Note: Changing these bits when the START bit is set is not allowed.
$01000000 constant I2C3_I2C_CR2_RELOAD                              \ NBYTES reload mode This bit is set and cleared by software.
$02000000 constant I2C3_I2C_CR2_AUTOEND                             \ Automatic end mode (master mode) This bit is set and cleared by software. Note: This bit has no effect in slave mode or when the RELOAD bit is set.
$04000000 constant I2C3_I2C_CR2_PECBYTE                             \ Packet error checking byte This bit is set by software, and cleared by hardware when the PEC is transferred, or when a STOP condition or an Address matched is received, also when PE=0. Note: Writing '0' to this bit has no effect. This bit has no effect when RELOAD is set. This bit has no effect is slave mode when SBC=0. If the SMBus feature is not supported, this bit is reserved and forced by hardware to '0'. Refer to .


\
\ @brief Own address register 1
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$000003ff constant I2C3_I2C_OAR1_OA1                                \ Interface own slave address 7-bit addressing mode: OA1[7:1] contains the 7-bit own slave address. The bits OA1[9], OA1[8] and OA1[0] are don't care. 10-bit addressing mode: OA1[9:0] contains the 10-bit own slave address. Note: These bits can be written only when OA1EN=0.
$00000400 constant I2C3_I2C_OAR1_OA1MODE                            \ Own Address 1 10-bit mode Note: This bit can be written only when OA1EN=0.
$00008000 constant I2C3_I2C_OAR1_OA1EN                              \ Own Address 1 enable


\
\ @brief Own address register 2
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$000000fe constant I2C3_I2C_OAR2_OA2                                \ Interface address 7-bit addressing mode: 7-bit address Note: These bits can be written only when OA2EN=0.
$00000700 constant I2C3_I2C_OAR2_OA2MSK                             \ Own Address 2 masks Note: These bits can be written only when OA2EN=0. As soon as OA2MSK is not equal to 0, the reserved I2C addresses (0b0000xxx and 0b1111xxx) are not acknowledged even if the comparison matches.
$00008000 constant I2C3_I2C_OAR2_OA2EN                              \ Own Address 2 enable


\
\ @brief Timing register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$000000ff constant I2C3_I2C_TIMINGR_SCLL                            \ SCL low period (master mode)
$0000ff00 constant I2C3_I2C_TIMINGR_SCLH                            \ SCL high period (master mode)
$000f0000 constant I2C3_I2C_TIMINGR_SDADEL                          \ Data hold time
$00f00000 constant I2C3_I2C_TIMINGR_SCLDEL                          \ Data setup time
$f0000000 constant I2C3_I2C_TIMINGR_PRESC                           \ Timing prescaler


\
\ @brief Status register 1
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000fff constant I2C3_I2C_TIMEOUTR_TIMEOUTA                       \ Bus Timeout A This field is used to configure: The SCL low timeout condition tTIMEOUT when TIDLE=0 tTIMEOUT= (TIMEOUTA+1) x 2048 x tI2CCLK The bus idle condition (both SCL and SDA high) when TIDLE=1 tIDLE= (TIMEOUTA+1) x 4 x tI2CCLK Note: These bits can be written only when TIMOUTEN=0.
$00001000 constant I2C3_I2C_TIMEOUTR_TIDLE                          \ Idle clock timeout detection Note: This bit can be written only when TIMOUTEN=0.
$00008000 constant I2C3_I2C_TIMEOUTR_TIMOUTEN                       \ Clock timeout enable
$0fff0000 constant I2C3_I2C_TIMEOUTR_TIMEOUTB                       \ Bus timeout B This field is used to configure the cumulative clock extension timeout: In master mode, the master cumulative clock low extend time (tLOW:MEXT) is detected In slave mode, the slave cumulative clock low extend time (tLOW:SEXT) is detected tLOW:EXT= (TIMEOUTB+1) x 2048 x tI2CCLK Note: These bits can be written only when TEXTEN=0.
$80000000 constant I2C3_I2C_TIMEOUTR_TEXTEN                         \ Extended clock timeout enable


\
\ @brief Interrupt and Status register
\ Address offset: 0x18
\ Reset value: 0x00000001
\

$00000001 constant I2C3_I2C_ISR_TXE                                 \ Transmit data register empty (transmitters)
$00000002 constant I2C3_I2C_ISR_TXIS                                \ Transmit interrupt status (transmitters)
$00000004 constant I2C3_I2C_ISR_RXNE                                \ Receive data register not empty (receivers)
$00000008 constant I2C3_I2C_ISR_ADDR                                \ Address matched (slave mode)
$00000010 constant I2C3_I2C_ISR_NACKF                               \ Not acknowledge received flag
$00000020 constant I2C3_I2C_ISR_STOPF                               \ Stop detection flag
$00000040 constant I2C3_I2C_ISR_TC                                  \ Transfer Complete (master mode)
$00000080 constant I2C3_I2C_ISR_TCR                                 \ Transfer Complete Reload
$00000100 constant I2C3_I2C_ISR_BERR                                \ Bus error
$00000200 constant I2C3_I2C_ISR_ARLO                                \ Arbitration lost
$00000400 constant I2C3_I2C_ISR_OVR                                 \ Overrun/Underrun (slave mode)
$00000800 constant I2C3_I2C_ISR_PECERR                              \ PEC Error in reception
$00001000 constant I2C3_I2C_ISR_TIMEOUT                             \ Timeout or t_low detection flag
$00002000 constant I2C3_I2C_ISR_ALERT                               \ SMBus alert
$00008000 constant I2C3_I2C_ISR_BUSY                                \ Bus busy
$00010000 constant I2C3_I2C_ISR_DIR                                 \ Transfer direction (Slave mode) This flag is updated when an address match event occurs (ADDR=1).
$00fe0000 constant I2C3_I2C_ISR_ADDCODE                             \ Address match code (Slave mode)


\
\ @brief Interrupt clear register
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$00000008 constant I2C3_I2C_ICR_ADDRCF                              \ Address Matched flag clear
$00000010 constant I2C3_I2C_ICR_NACKCF                              \ Not Acknowledge flag clear
$00000020 constant I2C3_I2C_ICR_STOPCF                              \ Stop detection flag clear
$00000100 constant I2C3_I2C_ICR_BERRCF                              \ Bus error flag clear
$00000200 constant I2C3_I2C_ICR_ARLOCF                              \ Arbitration lost flag clear
$00000400 constant I2C3_I2C_ICR_OVRCF                               \ Overrun/Underrun flag clear
$00000800 constant I2C3_I2C_ICR_PECCF                               \ PEC Error flag clear
$00001000 constant I2C3_I2C_ICR_TIMOUTCF                            \ Timeout detection flag clear
$00002000 constant I2C3_I2C_ICR_ALERTCF                             \ Alert flag clear


\
\ @brief PEC register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$000000ff constant I2C3_I2C_PECR_PEC                                \ Packet error checking register


\
\ @brief Receive data register
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$000000ff constant I2C3_I2C_RXDR_RXDATA                             \ 8-bit receive data


\
\ @brief Transmit data register
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$000000ff constant I2C3_I2C_TXDR_TXDATA                             \ 8-bit transmit data


\
\ @brief Inter-integrated circuit
\
$40008800 constant I2C3_I2C_CR1   \ offset: 0x00 : Control register 1
$40008804 constant I2C3_I2C_CR2   \ offset: 0x04 : Control register 2
$40008808 constant I2C3_I2C_OAR1  \ offset: 0x08 : Own address register 1
$4000880c constant I2C3_I2C_OAR2  \ offset: 0x0C : Own address register 2
$40008810 constant I2C3_I2C_TIMINGR  \ offset: 0x10 : Timing register
$40008814 constant I2C3_I2C_TIMEOUTR  \ offset: 0x14 : Status register 1
$40008818 constant I2C3_I2C_ISR   \ offset: 0x18 : Interrupt and Status register
$4000881c constant I2C3_I2C_ICR   \ offset: 0x1C : Interrupt clear register
$40008820 constant I2C3_I2C_PECR  \ offset: 0x20 : PEC register
$40008824 constant I2C3_I2C_RXDR  \ offset: 0x24 : Receive data register
$40008828 constant I2C3_I2C_TXDR  \ offset: 0x28 : Transmit data register

