\
\ @file i2c5.fs
\ @brief I2C5 event interrupt
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief I2C control register 1
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000001 constant I2C5_I2C_CR1_PE                                  \ Peripheral enable Note: When PE=0, the I2C SCL and SDA lines are released. Internal state machines and status bits are put back to their reset value. When cleared, PE must be kept low for at least 3 APB clock cycles.
$00000002 constant I2C5_I2C_CR1_TXIE                                \ TX Interrupt enable
$00000004 constant I2C5_I2C_CR1_RXIE                                \ RX Interrupt enable
$00000008 constant I2C5_I2C_CR1_ADDRIE                              \ Address match Interrupt enable (slave only)
$00000010 constant I2C5_I2C_CR1_NACKIE                              \ Not acknowledge received Interrupt enable
$00000020 constant I2C5_I2C_CR1_STOPIE                              \ Stop detection Interrupt enable
$00000040 constant I2C5_I2C_CR1_TCIE                                \ Transfer Complete interrupt enable Note: Any of these events generate an interrupt: Transfer Complete (TC) Transfer Complete Reload (TCR)
$00000080 constant I2C5_I2C_CR1_ERRIE                               \ Error interrupts enable Note: Any of these errors generate an interrupt: Arbitration Loss (ARLO) Bus Error detection (BERR) Overrun/Underrun (OVR) Timeout detection (TIMEOUT) PEC error detection (PECERR) Alert pin event detection (ALERT)
$00000f00 constant I2C5_I2C_CR1_DNF                                 \ Digital noise filter These bits are used to configure the digital noise filter on SDA and SCL input. The digital filter, filters spikes with a length of up to DNF[3:0] * tI2CCLK ... Note: If the analog filter is also enabled, the digital filter is added to the analog filter. This filter can only be programmed when the I2C is disabled (PE = 0).
$00001000 constant I2C5_I2C_CR1_ANFOFF                              \ Analog noise filter OFF Note: This bit can only be programmed when the I2C is disabled (PE = 0).
$00004000 constant I2C5_I2C_CR1_TXDMAEN                             \ DMA transmission requests enable
$00008000 constant I2C5_I2C_CR1_RXDMAEN                             \ DMA reception requests enable
$00010000 constant I2C5_I2C_CR1_SBC                                 \ Slave byte control This bit is used to enable hardware byte control in slave mode.
$00020000 constant I2C5_I2C_CR1_NOSTRETCH                           \ Clock stretching disable This bit is used to disable clock stretching in slave mode. It must be kept cleared in master mode. Note: This bit can only be programmed when the I2C is disabled (PE = 0).
$00040000 constant I2C5_I2C_CR1_WUPEN                               \ Wakeup from Stop mode enable Note: If the Wakeup from Stop mode feature is not supported, this bit is reserved and forced by hardware to ‘0’. Refer to . Note: WUPEN can be set only when DNF = ‘0000’
$00080000 constant I2C5_I2C_CR1_GCEN                                \ General call enable
$00100000 constant I2C5_I2C_CR1_SMBHEN                              \ SMBus host address enable Note: If the SMBus feature is not supported, this bit is reserved and forced by hardware to ‘0’. Refer to .
$00200000 constant I2C5_I2C_CR1_SMBDEN                              \ SMBus device default address enable Note: If the SMBus feature is not supported, this bit is reserved and forced by hardware to ‘0’. Refer to .
$00400000 constant I2C5_I2C_CR1_ALERTEN                             \ SMBus alert enable Note: When ALERTEN=0, the SMBA pin can be used as a standard GPIO. If the SMBus feature is not supported, this bit is reserved and forced by hardware to ‘0’. Refer to .
$00800000 constant I2C5_I2C_CR1_PECEN                               \ PEC enable Note: If the SMBus feature is not supported, this bit is reserved and forced by hardware to ‘0’. Refer to .


\
\ @brief I2C control register 2
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$000003ff constant I2C5_I2C_CR2_SADD                                \ Slave address (master mode) In 7-bit addressing mode (ADD10 = 0): SADD[7:1] should be written with the 7-bit slave address to be sent. The bits SADD[9], SADD[8] and SADD[0] are don't care. In 10-bit addressing mode (ADD10 = 1): SADD[9:0] should be written with the 10-bit slave address to be sent. Note: Changing these bits when the START bit is set is not allowed.
$00000400 constant I2C5_I2C_CR2_RD_WRN                              \ Transfer direction (master mode) Note: Changing this bit when the START bit is set is not allowed.
$00000800 constant I2C5_I2C_CR2_ADD10                               \ 10-bit addressing mode (master mode) Note: Changing this bit when the START bit is set is not allowed.
$00001000 constant I2C5_I2C_CR2_HEAD10R                             \ 10-bit address header only read direction (master receiver mode) Note: Changing this bit when the START bit is set is not allowed.
$00002000 constant I2C5_I2C_CR2_START                               \ Start generation This bit is set by software, and cleared by hardware after the Start followed by the address sequence is sent, by an arbitration loss, by an address matched in slave mode, by a timeout error detection, or when PE = 0. If the I2C is already in master mode with AUTOEND = 0, setting this bit generates a Repeated Start condition when RELOAD=0, after the end of the NBYTES transfer. Otherwise setting this bit generates a START condition once the bus is free. Note: Writing ‘0’ to this bit has no effect. The START bit can be set even if the bus is BUSY or I2C is in slave mode. This bit has no effect when RELOAD is set.
$00004000 constant I2C5_I2C_CR2_STOP                                \ Stop generation (master mode) The bit is set by software, cleared by hardware when a STOP condition is detected, or when PE = 0. In Master Mode: Note: Writing ‘0’ to this bit has no effect.
$00008000 constant I2C5_I2C_CR2_NACK                                \ NACK generation (slave mode) The bit is set by software, cleared by hardware when the NACK is sent, or when a STOP condition or an Address matched is received, or when PE=0. Note: Writing ‘0’ to this bit has no effect. This bit is used in slave mode only: in master receiver mode, NACK is automatically generated after last byte preceding STOP or RESTART condition, whatever the NACK bit value. When an overrun occurs in slave receiver NOSTRETCH mode, a NACK is automatically generated whatever the NACK bit value. When hardware PEC checking is enabled (PECBYTE=1), the PEC acknowledge value does not depend on the NACK value.
$00ff0000 constant I2C5_I2C_CR2_NBYTES                              \ Number of bytes The number of bytes to be transmitted/received is programmed there. This field is don’t care in slave mode with SBC=0. Note: Changing these bits when the START bit is set is not allowed.
$01000000 constant I2C5_I2C_CR2_RELOAD                              \ NBYTES reload mode This bit is set and cleared by software.
$02000000 constant I2C5_I2C_CR2_AUTOEND                             \ Automatic end mode (master mode) This bit is set and cleared by software. Note: This bit has no effect in slave mode or when the RELOAD bit is set.
$04000000 constant I2C5_I2C_CR2_PECBYTE                             \ Packet error checking byte This bit is set by software, and cleared by hardware when the PEC is transferred, or when a STOP condition or an Address matched is received, also when PE=0. Note: Writing ‘0’ to this bit has no effect. This bit has no effect when RELOAD is set. This bit has no effect is slave mode when SBC=0. If the SMBus feature is not supported, this bit is reserved and forced by hardware to ‘0’. Refer to .


\
\ @brief I2C own address 1 register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$000003ff constant I2C5_I2C_OAR1_OA1                                \ Interface own slave address 7-bit addressing mode: OA1[7:1] contains the 7-bit own slave address. The bits OA1[9], OA1[8] and OA1[0] are don't care. 10-bit addressing mode: OA1[9:0] contains the 10-bit own slave address. Note: These bits can be written only when OA1EN=0.
$00000400 constant I2C5_I2C_OAR1_OA1MODE                            \ Own Address 1 10-bit mode Note: This bit can be written only when OA1EN=0.
$00008000 constant I2C5_I2C_OAR1_OA1EN                              \ Own Address 1 enable


\
\ @brief I2C own address 2 register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$000000fe constant I2C5_I2C_OAR2_OA2                                \ Interface address 7-bit addressing mode: 7-bit address Note: These bits can be written only when OA2EN=0.
$00000700 constant I2C5_I2C_OAR2_OA2MSK                             \ Own Address 2 masks Note: These bits can be written only when OA2EN=0. As soon as OA2MSK is not equal to 0, the reserved I2C addresses (0b0000xxx and 0b1111xxx) are not acknowledged even if the comparison matches.
$00008000 constant I2C5_I2C_OAR2_OA2EN                              \ Own Address 2 enable


\
\ @brief I2C timing register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$000000ff constant I2C5_I2C_TIMINGR_SCLL                            \ SCL low period (master mode) This field is used to generate the SCL low period in master mode. tSCLL = (SCLL+1) x tPRESC Note: SCLL is also used to generate tBUF and tSU:STA timings.
$0000ff00 constant I2C5_I2C_TIMINGR_SCLH                            \ SCL high period (master mode) This field is used to generate the SCL high period in master mode. tSCLH = (SCLH+1) x tPRESC Note: SCLH is also used to generate tSU:STO and tHD:STA timing.
$000f0000 constant I2C5_I2C_TIMINGR_SDADEL                          \ Data hold time This field is used to generate the delay tSDADEL between SCL falling edge and SDA edge. In master mode and in slave mode with NOSTRETCH = 0, the SCL line is stretched low during tSDADEL. tSDADEL= SDADEL x tPRESC Note: SDADEL is used to generate tHD:DAT timing.
$00f00000 constant I2C5_I2C_TIMINGR_SCLDEL                          \ Data setup time This field is used to generate a delay tSCLDEL between SDA edge and SCL rising edge. In master mode and in slave mode with NOSTRETCH = 0, the SCL line is stretched low during tSCLDEL. tSCLDEL = (SCLDEL+1) x tPRESC Note: tSCLDEL is used to generate tSU:DAT timing.
$f0000000 constant I2C5_I2C_TIMINGR_PRESC                           \ Timing prescaler This field is used to prescale i2c_ker_ck in order to generate the clock period tPRESC used for data setup and hold counters (refer to ) and for SCL high and low level counters (refer to ). tPRESC = (PRESC+1) x tI2CCLK


\
\ @brief I2C timeout register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000fff constant I2C5_I2C_TIMEOUTR_TIMEOUTA                       \ Bus Timeout A This field is used to configure: The SCL low timeout condition tTIMEOUT when TIDLE=0 tTIMEOUT= (TIMEOUTA+1) x 2048 x tI2CCLK The bus idle condition (both SCL and SDA high) when TIDLE=1 tIDLE= (TIMEOUTA+1) x 4 x tI2CCLK Note: These bits can be written only when TIMOUTEN=0.
$00001000 constant I2C5_I2C_TIMEOUTR_TIDLE                          \ Idle clock timeout detection Note: This bit can be written only when TIMOUTEN=0.
$00008000 constant I2C5_I2C_TIMEOUTR_TIMOUTEN                       \ Clock timeout enable
$0fff0000 constant I2C5_I2C_TIMEOUTR_TIMEOUTB                       \ Bus timeout B This field is used to configure the cumulative clock extension timeout: In master mode, the master cumulative clock low extend time (tLOW:MEXT) is detected In slave mode, the slave cumulative clock low extend time (tLOW:SEXT) is detected tLOW:EXT= (TIMEOUTB+1) x 2048 x tI2CCLK Note: These bits can be written only when TEXTEN=0.
$80000000 constant I2C5_I2C_TIMEOUTR_TEXTEN                         \ Extended clock timeout enable


\
\ @brief I2C interrupt and status register
\ Address offset: 0x18
\ Reset value: 0x00000001
\

$00000001 constant I2C5_I2C_ISR_TXE                                 \ Transmit data register empty (transmitters) This bit is set by hardware when the I2C_TXDR register is empty. It is cleared when the next data to be sent is written in the I2C_TXDR register. This bit can be written to ‘1’ by software in order to flush the transmit data register I2C_TXDR. Note: This bit is set by hardware when PE=0.
$00000002 constant I2C5_I2C_ISR_TXIS                                \ Transmit interrupt status (transmitters) This bit is set by hardware when the I2C_TXDR register is empty and the data to be transmitted must be written in the I2C_TXDR register. It is cleared when the next data to be sent is written in the I2C_TXDR register. This bit can be written to ‘1’ by software when NOSTRETCH=1 only, in order to generate a TXIS event (interrupt if TXIE=1 or DMA request if TXDMAEN=1). Note: This bit is cleared by hardware when PE=0.
$00000004 constant I2C5_I2C_ISR_RXNE                                \ Receive data register not empty (receivers) This bit is set by hardware when the received data is copied into the I2C_RXDR register, and is ready to be read. It is cleared when I2C_RXDR is read. Note: This bit is cleared by hardware when PE=0.
$00000008 constant I2C5_I2C_ISR_ADDR                                \ Address matched (slave mode) This bit is set by hardware as soon as the received slave address matched with one of the enabled slave addresses. It is cleared by software by setting ADDRCF bit. Note: This bit is cleared by hardware when PE=0.
$00000010 constant I2C5_I2C_ISR_NACKF                               \ Not Acknowledge received flag This flag is set by hardware when a NACK is received after a byte transmission. It is cleared by software by setting the NACKCF bit. Note: This bit is cleared by hardware when PE=0.
$00000020 constant I2C5_I2C_ISR_STOPF                               \ Stop detection flag This flag is set by hardware when a STOP condition is detected on the bus and the peripheral is involved in this transfer: either as a master, provided that the STOP condition is generated by the peripheral. or as a slave, provided that the peripheral has been addressed previously during this transfer. It is cleared by software by setting the STOPCF bit. Note: This bit is cleared by hardware when PE=0.
$00000040 constant I2C5_I2C_ISR_TC                                  \ Transfer Complete (master mode) This flag is set by hardware when RELOAD=0, AUTOEND=0 and NBYTES data have been transferred. It is cleared by software when START bit or STOP bit is set. Note: This bit is cleared by hardware when PE=0.
$00000080 constant I2C5_I2C_ISR_TCR                                 \ Transfer Complete Reload This flag is set by hardware when RELOAD=1 and NBYTES data have been transferred. It is cleared by software when NBYTES is written to a non-zero value. Note: This bit is cleared by hardware when PE=0. This flag is only for master mode, or for slave mode when the SBC bit is set.
$00000100 constant I2C5_I2C_ISR_BERR                                \ Bus error This flag is set by hardware when a misplaced Start or STOP condition is detected whereas the peripheral is involved in the transfer. The flag is not set during the address phase in slave mode. It is cleared by software by setting BERRCF bit. Note: This bit is cleared by hardware when PE=0.
$00000200 constant I2C5_I2C_ISR_ARLO                                \ Arbitration lost This flag is set by hardware in case of arbitration loss. It is cleared by software by setting the ARLOCF bit. Note: This bit is cleared by hardware when PE=0.
$00000400 constant I2C5_I2C_ISR_OVR                                 \ Overrun/Underrun (slave mode) This flag is set by hardware in slave mode with NOSTRETCH=1, when an overrun/underrun error occurs. It is cleared by software by setting the OVRCF bit. Note: This bit is cleared by hardware when PE=0.
$00000800 constant I2C5_I2C_ISR_PECERR                              \ PEC Error in reception This flag is set by hardware when the received PEC does not match with the PEC register content. A NACK is automatically sent after the wrong PEC reception. It is cleared by software by setting the PECCF bit. Note: This bit is cleared by hardware when PE=0. If the SMBus feature is not supported, this bit is reserved and forced by hardware to ‘0’. Refer to .
$00001000 constant I2C5_I2C_ISR_TIMEOUT                             \ Timeout or tLOW detection flag This flag is set by hardware when a timeout or extended clock timeout occurred. It is cleared by software by setting the TIMEOUTCF bit. Note: This bit is cleared by hardware when PE=0. If the SMBus feature is not supported, this bit is reserved and forced by hardware to ‘0’. Refer to .
$00002000 constant I2C5_I2C_ISR_ALERT                               \ SMBus alert This flag is set by hardware when SMBHEN=1 (SMBus host configuration), ALERTEN=1 and a SMBALERT event (falling edge) is detected on SMBA pin. It is cleared by software by setting the ALERTCF bit. Note: This bit is cleared by hardware when PE=0. If the SMBus feature is not supported, this bit is reserved and forced by hardware to ‘0’. Refer to .
$00008000 constant I2C5_I2C_ISR_BUSY                                \ Bus busy This flag indicates that a communication is in progress on the bus. It is set by hardware when a START condition is detected. It is cleared by hardware when a STOP condition is detected, or when PE=0.
$00010000 constant I2C5_I2C_ISR_DIR                                 \ Transfer direction (Slave mode) This flag is updated when an address match event occurs (ADDR=1).
$00fe0000 constant I2C5_I2C_ISR_ADDCODE                             \ Address match code (Slave mode) These bits are updated with the received address when an address match event occurs (ADDR = 1). In the case of a 10-bit address, ADDCODE provides the 10-bit header followed by the 2 MSBs of the address.


\
\ @brief I2C interrupt clear register
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$00000008 constant I2C5_I2C_ICR_ADDRCF                              \ Address matched flag clear Writing 1 to this bit clears the ADDR flag in the I2C_ISR register. Writing 1 to this bit also clears the START bit in the I2C_CR2 register.
$00000010 constant I2C5_I2C_ICR_NACKCF                              \ Not Acknowledge flag clear Writing 1 to this bit clears the NACKF flag in I2C_ISR register.
$00000020 constant I2C5_I2C_ICR_STOPCF                              \ STOP detection flag clear Writing 1 to this bit clears the STOPF flag in the I2C_ISR register.
$00000100 constant I2C5_I2C_ICR_BERRCF                              \ Bus error flag clear Writing 1 to this bit clears the BERRF flag in the I2C_ISR register.
$00000200 constant I2C5_I2C_ICR_ARLOCF                              \ Arbitration lost flag clear Writing 1 to this bit clears the ARLO flag in the I2C_ISR register.
$00000400 constant I2C5_I2C_ICR_OVRCF                               \ Overrun/Underrun flag clear Writing 1 to this bit clears the OVR flag in the I2C_ISR register.
$00000800 constant I2C5_I2C_ICR_PECCF                               \ PEC Error flag clear Writing 1 to this bit clears the PECERR flag in the I2C_ISR register. Note: If the SMBus feature is not supported, this bit is reserved and forced by hardware to ‘0’. Refer to .
$00001000 constant I2C5_I2C_ICR_TIMOUTCF                            \ Timeout detection flag clear Writing 1 to this bit clears the TIMEOUT flag in the I2C_ISR register. Note: If the SMBus feature is not supported, this bit is reserved and forced by hardware to ‘0’. Refer to .
$00002000 constant I2C5_I2C_ICR_ALERTCF                             \ Alert flag clear Writing 1 to this bit clears the ALERT flag in the I2C_ISR register. Note: If the SMBus feature is not supported, this bit is reserved and forced by hardware to ‘0’. Refer to .


\
\ @brief I2C PEC register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$000000ff constant I2C5_I2C_PECR_PEC                                \ Packet error checking register This field contains the internal PEC when PECEN=1. The PEC is cleared by hardware when PE=0.


\
\ @brief I2C receive data register
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$000000ff constant I2C5_I2C_RXDR_RXDATA                             \ 8-bit receive data Data byte received from the I2C bus


\
\ @brief I2C transmit data register
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$000000ff constant I2C5_I2C_TXDR_TXDATA                             \ 8-bit transmit data Data byte to be transmitted to the I2C bus Note: These bits can be written only when TXE=1.


\
\ @brief I2C hardware configuration register
\ Address offset: 0x3F0
\ Reset value: 0x00000111
\

$0000000f constant I2C5_I2C_HWCFGR_SMBUS                            \ SMBus mode
$000000f0 constant I2C5_I2C_HWCFGR_ASYN                             \ Independent kernel clock
$00000f00 constant I2C5_I2C_HWCFGR_WKP                              \ Wakeup from Stop mode


\
\ @brief I2C version register
\ Address offset: 0x3F4
\ Reset value: 0x00000014
\

$0000000f constant I2C5_I2C_VERR_MINREV                             \ Minor revision
$000000f0 constant I2C5_I2C_VERR_MAJREV                             \ Major revision


\
\ @brief I2C identification register
\ Address offset: 0x3F8
\ Reset value: 0x00130012
\

$00000000 constant I2C5_I2C_IPIDR_ID                                \ Identifier.


\
\ @brief I2C size identification register
\ Address offset: 0x3FC
\ Reset value: 0xA3C5DD01
\

$00000000 constant I2C5_I2C_SIDR_SID                                \ Size identifier.


\
\ @brief I2C5 event interrupt
\
$4c006000 constant I2C5_I2C_CR1   \ offset: 0x00 : I2C control register 1
$4c006004 constant I2C5_I2C_CR2   \ offset: 0x04 : I2C control register 2
$4c006008 constant I2C5_I2C_OAR1  \ offset: 0x08 : I2C own address 1 register
$4c00600c constant I2C5_I2C_OAR2  \ offset: 0x0C : I2C own address 2 register
$4c006010 constant I2C5_I2C_TIMINGR  \ offset: 0x10 : I2C timing register
$4c006014 constant I2C5_I2C_TIMEOUTR  \ offset: 0x14 : I2C timeout register
$4c006018 constant I2C5_I2C_ISR   \ offset: 0x18 : I2C interrupt and status register
$4c00601c constant I2C5_I2C_ICR   \ offset: 0x1C : I2C interrupt clear register
$4c006020 constant I2C5_I2C_PECR  \ offset: 0x20 : I2C PEC register
$4c006024 constant I2C5_I2C_RXDR  \ offset: 0x24 : I2C receive data register
$4c006028 constant I2C5_I2C_TXDR  \ offset: 0x28 : I2C transmit data register
$4c0063f0 constant I2C5_I2C_HWCFGR  \ offset: 0x3F0 : I2C hardware configuration register
$4c0063f4 constant I2C5_I2C_VERR  \ offset: 0x3F4 : I2C version register
$4c0063f8 constant I2C5_I2C_IPIDR  \ offset: 0x3F8 : I2C identification register
$4c0063fc constant I2C5_I2C_SIDR  \ offset: 0x3FC : I2C size identification register

