\
\ @file i2c1.fs
\ @brief I2C1
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief Access: No wait states, except if a write access occurs while a write access to this register is ongoing. In this case, wait states are inserted in the second write access until the previous one is completed. The latency of the second write access can be up to 2 x PCLK1 + 6 x I2CCLK.
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000001 constant I2C1_CR1_PE                                      \ Peripheral enable Note: When PE=0, the I2C SCL and SDA lines are released. Internal state machines and status bits are put back to their reset value. When cleared, PE must be kept low for at least 3 APB clock cycles.
$00000002 constant I2C1_CR1_TXIE                                    \ TX Interrupt enable
$00000004 constant I2C1_CR1_RXIE                                    \ RX Interrupt enable
$00000008 constant I2C1_CR1_ADDRIE                                  \ Address match Interrupt enable (slave only)
$00000010 constant I2C1_CR1_NACKIE                                  \ Not acknowledge received Interrupt enable
$00000020 constant I2C1_CR1_STOPIE                                  \ STOP detection Interrupt enable
$00000040 constant I2C1_CR1_TCIE                                    \ Transfer Complete interrupt enable Note: Any of these events will generate an interrupt: Transfer Complete (TC) Transfer Complete Reload (TCR)
$00000080 constant I2C1_CR1_ERRIE                                   \ Error interrupts enable Note: Any of these errors generate an interrupt: Arbitration Loss (ARLO) Bus Error detection (BERR) Overrun/Underrun (OVR) Timeout detection (TIMEOUT) PEC error detection (PECERR) Alert pin event detection (ALERT)
$00000f00 constant I2C1_CR1_DNF                                     \ Digital noise filter These bits are used to configure the digital noise filter on SDA and SCL input. The digital filter will filter spikes with a length of up to DNF[3:0] * tI2CCLK ... Note: If the analog filter is also enabled, the digital filter is added to the analog filter. This filter can only be programmed when the I2C is disabled (PE = 0).
$00001000 constant I2C1_CR1_ANFOFF                                  \ Analog noise filter OFF Note: This bit can only be programmed when the I2C is disabled (PE = 0).
$00004000 constant I2C1_CR1_TXDMAEN                                 \ DMA transmission requests enable
$00008000 constant I2C1_CR1_RXDMAEN                                 \ DMA reception requests enable
$00010000 constant I2C1_CR1_SBC                                     \ Slave byte control This bit is used to enable hardware byte control in slave mode.
$00020000 constant I2C1_CR1_NOSTRETCH                               \ Clock stretching disable This bit is used to disable clock stretching in slave mode. It must be kept cleared in master mode. Note: This bit can only be programmed when the I2C is disabled (PE = 0).
$00040000 constant I2C1_CR1_WUPEN                                   \ Wakeup from Stop mode enable Note: If the Wakeup from Stop mode feature is not supported, this bit is reserved and forced by hardware to 0. Please refer to Section25.3: I2C implementation. Note: WUPEN can be set only when DNF = 0000
$00080000 constant I2C1_CR1_GCEN                                    \ General call enable
$00100000 constant I2C1_CR1_SMBHEN                                  \ SMBus Host address enable Note: If the SMBus feature is not supported, this bit is reserved and forced by hardware to 0. Please refer to Section25.3: I2C implementation.
$00200000 constant I2C1_CR1_SMBDEN                                  \ SMBus Device Default address enable Note: If the SMBus feature is not supported, this bit is reserved and forced by hardware to 0. Please refer to Section25.3: I2C implementation.
$00400000 constant I2C1_CR1_ALERTEN                                 \ SMBus alert enable Device mode (SMBHEN=0): Host mode (SMBHEN=1): Note: When ALERTEN=0, the SMBA pin can be used as a standard GPIO. If the SMBus feature is not supported, this bit is reserved and forced by hardware to 0. Please refer to Section25.3: I2C implementation.
$00800000 constant I2C1_CR1_PECEN                                   \ PEC enable Note: If the SMBus feature is not supported, this bit is reserved and forced by hardware to 0. Please refer to Section25.3: I2C implementation.


\
\ @brief Access: No wait states, except if a write access occurs while a write access to this register is ongoing. In this case, wait states are inserted in the second write access until the previous one is completed. The latency of the second write access can be up to 2 x PCLK1 + 6 x I2CCLK.
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant I2C1_CR2_SADD0                                   \ Slave address bit 0 (master mode) In 7-bit addressing mode (ADD10 = 0): This bit is dont care In 10-bit addressing mode (ADD10 = 1): This bit should be written with bit 0 of the slave address to be sent Note: Changing these bits when the START bit is set is not allowed.
$00000002 constant I2C1_CR2_SADD1                                   \ Slave address bit 7:1 (master mode) In 7-bit addressing mode (ADD10 = 0): These bits should be written with the 7-bit slave address to be sent In 10-bit addressing mode (ADD10 = 1): These bits should be written with bits 7:1 of the slave address to be sent. Note: Changing these bits when the START bit is set is not allowed.
$00000004 constant I2C1_CR2_SADD2                                   \ Slave address bit 7:1 (master mode) In 7-bit addressing mode (ADD10 = 0): These bits should be written with the 7-bit slave address to be sent In 10-bit addressing mode (ADD10 = 1): These bits should be written with bits 7:1 of the slave address to be sent. Note: Changing these bits when the START bit is set is not allowed.
$00000008 constant I2C1_CR2_SADD3                                   \ Slave address bit 7:1 (master mode) In 7-bit addressing mode (ADD10 = 0): These bits should be written with the 7-bit slave address to be sent In 10-bit addressing mode (ADD10 = 1): These bits should be written with bits 7:1 of the slave address to be sent. Note: Changing these bits when the START bit is set is not allowed.
$00000010 constant I2C1_CR2_SADD4                                   \ Slave address bit 7:1 (master mode) In 7-bit addressing mode (ADD10 = 0): These bits should be written with the 7-bit slave address to be sent In 10-bit addressing mode (ADD10 = 1): These bits should be written with bits 7:1 of the slave address to be sent. Note: Changing these bits when the START bit is set is not allowed.
$00000020 constant I2C1_CR2_SADD5                                   \ Slave address bit 7:1 (master mode) In 7-bit addressing mode (ADD10 = 0): These bits should be written with the 7-bit slave address to be sent In 10-bit addressing mode (ADD10 = 1): These bits should be written with bits 7:1 of the slave address to be sent. Note: Changing these bits when the START bit is set is not allowed.
$00000040 constant I2C1_CR2_SADD6                                   \ Slave address bit 7:1 (master mode) In 7-bit addressing mode (ADD10 = 0): These bits should be written with the 7-bit slave address to be sent In 10-bit addressing mode (ADD10 = 1): These bits should be written with bits 7:1 of the slave address to be sent. Note: Changing these bits when the START bit is set is not allowed.
$00000080 constant I2C1_CR2_SADD7                                   \ Slave address bit 7:1 (master mode) In 7-bit addressing mode (ADD10 = 0): These bits should be written with the 7-bit slave address to be sent In 10-bit addressing mode (ADD10 = 1): These bits should be written with bits 7:1 of the slave address to be sent. Note: Changing these bits when the START bit is set is not allowed.
$00000100 constant I2C1_CR2_SADD8                                   \ Slave address bit 9:8 (master mode) In 7-bit addressing mode (ADD10 = 0): These bits are dont care In 10-bit addressing mode (ADD10 = 1): These bits should be written with bits 9:8 of the slave address to be sent Note: Changing these bits when the START bit is set is not allowed.
$00000200 constant I2C1_CR2_SADD9                                   \ Slave address bit 9:8 (master mode) In 7-bit addressing mode (ADD10 = 0): These bits are dont care In 10-bit addressing mode (ADD10 = 1): These bits should be written with bits 9:8 of the slave address to be sent Note: Changing these bits when the START bit is set is not allowed.
$00000400 constant I2C1_CR2_RD_WRN                                  \ Transfer direction (master mode) Note: Changing this bit when the START bit is set is not allowed.
$00000800 constant I2C1_CR2_ADD10                                   \ 10-bit addressing mode (master mode) Note: Changing this bit when the START bit is set is not allowed.
$00001000 constant I2C1_CR2_HEAD10R                                 \ 10-bit address header only read direction (master receiver mode) Note: Changing this bit when the START bit is set is not allowed.
$00002000 constant I2C1_CR2_START                                   \ Start generation This bit is set by software, and cleared by hardware after the Start followed by the address sequence is sent, by an arbitration loss, by a timeout error detection, or when PE = 0. It can also be cleared by software by writing 1 to the ADDRCF bit in the I2C_ICR register. If the I2C is already in master mode with AUTOEND = 0, setting this bit generates a Repeated Start condition when RELOAD=0, after the end of the NBYTES transfer. Otherwise setting this bit will generate a START condition once the bus is free. Note: Writing 0 to this bit has no effect. The START bit can be set even if the bus is BUSY or I2C is in slave mode. This bit has no effect when RELOAD is set.
$00004000 constant I2C1_CR2_STOP                                    \ Stop generation (master mode) The bit is set by software, cleared by hardware when a Stop condition is detected, or when PE = 0. In Master Mode: Note: Writing 0 to this bit has no effect.
$00008000 constant I2C1_CR2_NACK                                    \ NACK generation (slave mode) The bit is set by software, cleared by hardware when the NACK is sent, or when a STOP condition or an Address matched is received, or when PE=0. Note: Writing 0 to this bit has no effect. This bit is used in slave mode only: in master receiver mode, NACK is automatically generated after last byte preceding STOP or RESTART condition, whatever the NACK bit value. When an overrun occurs in slave receiver NOSTRETCH mode, a NACK is automatically generated whatever the NACK bit value. When hardware PEC checking is enabled (PECBYTE=1), the PEC acknowledge value does not depend on the NACK value.
$00ff0000 constant I2C1_CR2_NBYTES                                  \ Number of bytes The number of bytes to be transmitted/received is programmed there. This field is dont care in slave mode with SBC=0. Note: Changing these bits when the START bit is set is not allowed.
$01000000 constant I2C1_CR2_RELOAD                                  \ NBYTES reload mode This bit is set and cleared by software.
$02000000 constant I2C1_CR2_AUTOEND                                 \ Automatic end mode (master mode) This bit is set and cleared by software. Note: This bit has no effect in slave mode or when the RELOAD bit is set.
$04000000 constant I2C1_CR2_PECBYTE                                 \ Packet error checking byte This bit is set by software, and cleared by hardware when the PEC is transferred, or when a STOP condition or an Address matched is received, also when PE=0. Note: Writing 0 to this bit has no effect. This bit has no effect when RELOAD is set. This bit has no effect is slave mode when SBC=0. If the SMBus feature is not supported, this bit is reserved and forced by hardware to 0. Please refer to Section25.3: I2C implementation.


\
\ @brief Access: No wait states, except if a write access occurs while a write access to this register is ongoing. In this case, wait states are inserted in the second write access until the previous one is completed. The latency of the second write access can be up to 2 x PCLK1 + 6 x I2CCLK.
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$000003ff constant I2C1_OAR1_OA1                                    \ Interface address 7-bit addressing mode: dont care 10-bit addressing mode: bits 9:8 of address Note: These bits can be written only when OA1EN=0. OA1[7:1]: Interface address Bits 7:1 of address Note: These bits can be written only when OA1EN=0. OA1[0]: Interface address 7-bit addressing mode: dont care 10-bit addressing mode: bit 0 of address Note: This bit can be written only when OA1EN=0.
$00000400 constant I2C1_OAR1_OA1MODE                                \ Own Address 1 10-bit mode Note: This bit can be written only when OA1EN=0.
$00008000 constant I2C1_OAR1_OA1EN                                  \ Own Address 1 enable


\
\ @brief Access: No wait states, except if a write access occurs while a write access to this register is ongoing. In this case, wait states are inserted in the second write access until the previous one is completed. The latency of the second write access can be up to 2 x PCLK1 + 6 x I2CCLK.
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$000000fe constant I2C1_OAR2_OA2                                    \ Interface address bits 7:1 of address Note: These bits can be written only when OA2EN=0.
$00000700 constant I2C1_OAR2_OA2MSK                                 \ Own Address 2 masks Note: These bits can be written only when OA2EN=0. As soon as OA2MSK is not equal to 0, the reserved I2C addresses (0b0000xxx and 0b1111xxx) are not acknowledged even if the comparison matches.
$00008000 constant I2C1_OAR2_OA2EN                                  \ Own Address 2 enable


\
\ @brief Access: No wait states
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$000000ff constant I2C1_TIMINGR_SCLL                                \ SCL low period (master mode) This field is used to generate the SCL low period in master mode. tSCLL = (SCLL+1) x tPRESC Note: SCLL is also used to generate tBUF and tSU:STA timings.
$0000ff00 constant I2C1_TIMINGR_SCLH                                \ SCL high period (master mode) This field is used to generate the SCL high period in master mode. tSCLH = (SCLH+1) x tPRESC Note: SCLH is also used to generate tSU:STO and tHD:STA timing.
$000f0000 constant I2C1_TIMINGR_SDADEL                              \ Data hold time This field is used to generate the delay tSDADEL between SCL falling edge and SDA edge. In master mode and in slave mode with NOSTRETCH = 0, the SCL line is stretched low during tSDADEL. tSDADEL= SDADEL x tPRESC Note: SDADEL is used to generate tHD:DAT timing.
$00f00000 constant I2C1_TIMINGR_SCLDEL                              \ Data setup time This field is used to generate a delay tSCLDEL between SDA edge and SCL rising edge. In master mode and in slave mode with NOSTRETCH = 0, the SCL line is stretched low during tSCLDEL. tSCLDEL = (SCLDEL+1) x tPRESC Note: tSCLDEL is used to generate tSU:DAT timing.
$f0000000 constant I2C1_TIMINGR_PRESC                               \ Timing prescaler This field is used to prescale I2CCLK in order to generate the clock period tPRESC used for data setup and hold counters (refer to I2C timings on page9) and for SCL high and low level counters (refer to I2C master initialization on page24). tPRESC = (PRESC+1) x tI2CCLK


\
\ @brief Access: No wait states, except if a write access occurs while a write access to this register is ongoing. In this case, wait states are inserted in the second write access until the previous one is completed. The latency of the second write access can be up to 2 x PCLK1 + 6 x I2CCLK.
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000fff constant I2C1_TIMEOUTR_TIMEOUTA                           \ Bus Timeout A This field is used to configure: The SCL low timeout condition tTIMEOUT when TIDLE=0 tTIMEOUT= (TIMEOUTA+1) x 2048 x tI2CCLK The bus idle condition (both SCL and SDA high) when TIDLE=1 tIDLE= (TIMEOUTA+1) x 4 x tI2CCLK Note: These bits can be written only when TIMOUTEN=0.
$00001000 constant I2C1_TIMEOUTR_TIDLE                              \ Idle clock timeout detection Note: This bit can be written only when TIMOUTEN=0.
$00008000 constant I2C1_TIMEOUTR_TIMOUTEN                           \ Clock timeout enable
$0fff0000 constant I2C1_TIMEOUTR_TIMEOUTB                           \ Bus timeout B This field is used to configure the cumulative clock extension timeout: In master mode, the master cumulative clock low extend time (tLOW:MEXT) is detected In slave mode, the slave cumulative clock low extend time (tLOW:SEXT) is detected tLOW:EXT= (TIMEOUTB+1) x 2048 x tI2CCLK Note: These bits can be written only when TEXTEN=0.
$80000000 constant I2C1_TIMEOUTR_TEXTEN                             \ Extended clock timeout enable


\
\ @brief Access: No wait states
\ Address offset: 0x18
\ Reset value: 0x00000001
\

$00000001 constant I2C1_ISR_TXE                                     \ Transmit data register empty (transmitters) This bit is set by hardware when the I2C_TXDR register is empty. It is cleared when the next data to be sent is written in the I2C_TXDR register. This bit can be written to 1 by software in order to flush the transmit data register I2C_TXDR. Note: This bit is set by hardware when PE=0.
$00000002 constant I2C1_ISR_TXIS                                    \ Transmit interrupt status (transmitters) This bit is set by hardware when the I2C_TXDR register is empty and the data to be transmitted must be written in the I2C_TXDR register. It is cleared when the next data to be sent is written in the I2C_TXDR register. This bit can be written to 1 by software when NOSTRETCH=1 only, in order to generate a TXIS event (interrupt if TXIE=1 or DMA request if TXDMAEN=1). Note: This bit is cleared by hardware when PE=0.
$00000004 constant I2C1_ISR_RXNE                                    \ Receive data register not empty (receivers) This bit is set by hardware when the received data is copied into the I2C_RXDR register, and is ready to be read. It is cleared when I2C_RXDR is read. Note: This bit is cleared by hardware when PE=0.
$00000008 constant I2C1_ISR_ADDR                                    \ Address matched (slave mode) This bit is set by hardware as soon as the received slave address matched with one of the enabled slave addresses. It is cleared by software by setting ADDRCF bit. Note: This bit is cleared by hardware when PE=0.
$00000010 constant I2C1_ISR_NACKF                                   \ Not Acknowledge received flag This flag is set by hardware when a NACK is received after a byte transmission. It is cleared by software by setting the NACKCF bit. Note: This bit is cleared by hardware when PE=0.
$00000020 constant I2C1_ISR_STOPF                                   \ Stop detection flag This flag is set by hardware when a Stop condition is detected on the bus and the peripheral is involved in this transfer: either as a master, provided that the STOP condition is generated by the peripheral. or as a slave, provided that the peripheral has been addressed previously during this transfer. It is cleared by software by setting the STOPCF bit. Note: This bit is cleared by hardware when PE=0.
$00000040 constant I2C1_ISR_TC                                      \ Transfer Complete (master mode) This flag is set by hardware when RELOAD=0, AUTOEND=0 and NBYTES data have been transferred. It is cleared by software when START bit or STOP bit is set. Note: This bit is cleared by hardware when PE=0.
$00000080 constant I2C1_ISR_TCR                                     \ Transfer Complete Reload This flag is set by hardware when RELOAD=1 and NBYTES data have been transferred. It is cleared by software when NBYTES is written to a non-zero value. Note: This bit is cleared by hardware when PE=0. This flag is only for master mode, or for slave mode when the SBC bit is set.
$00000100 constant I2C1_ISR_BERR                                    \ Bus error This flag is set by hardware when a misplaced Start or Stop condition is detected whereas the peripheral is involved in the transfer. The flag is not set during the address phase in slave mode. It is cleared by software by setting BERRCF bit. Note: This bit is cleared by hardware when PE=0.
$00000200 constant I2C1_ISR_ARLO                                    \ Arbitration lost This flag is set by hardware in case of arbitration loss. It is cleared by software by setting the ARLOCF bit. Note: This bit is cleared by hardware when PE=0.
$00000400 constant I2C1_ISR_OVR                                     \ Overrun/Underrun (slave mode) This flag is set by hardware in slave mode with NOSTRETCH=1, when an overrun/underrun error occurs. It is cleared by software by setting the OVRCF bit. Note: This bit is cleared by hardware when PE=0.
$00000800 constant I2C1_ISR_PECERR                                  \ PEC Error in reception This flag is set by hardware when the received PEC does not match with the PEC register content. A NACK is automatically sent after the wrong PEC reception. It is cleared by software by setting the PECCF bit. Note: This bit is cleared by hardware when PE=0. If the SMBus feature is not supported, this bit is reserved and forced by hardware to 0. Please refer to Section25.3: I2C implementation.
$00001000 constant I2C1_ISR_TIMEOUT                                 \ Timeout or tLOW detection flag This flag is set by hardware when a timeout or extended clock timeout occurred. It is cleared by software by setting the TIMEOUTCF bit. Note: This bit is cleared by hardware when PE=0. If the SMBus feature is not supported, this bit is reserved and forced by hardware to 0. Please refer to Section25.3: I2C implementation.
$00002000 constant I2C1_ISR_ALERT                                   \ SMBus alert This flag is set by hardware when SMBHEN=1 (SMBus host configuration), ALERTEN=1 and a SMBALERT event (falling edge) is detected on SMBA pin. It is cleared by software by setting the ALERTCF bit. Note: This bit is cleared by hardware when PE=0. If the SMBus feature is not supported, this bit is reserved and forced by hardware to 0. Please refer to Section25.3: I2C implementation.
$00008000 constant I2C1_ISR_BUSY                                    \ Bus busy This flag indicates that a communication is in progress on the bus. It is set by hardware when a START condition is detected. It is cleared by hardware when a Stop condition is detected, or when PE=0.
$00010000 constant I2C1_ISR_DIR                                     \ Transfer direction (Slave mode) This flag is updated when an address match event occurs (ADDR=1).
$00fe0000 constant I2C1_ISR_ADDCODE                                 \ Address match code (Slave mode) These bits are updated with the received address when an address match event occurs (ADDR = 1). In the case of a 10-bit address, ADDCODE provides the 10-bit header followed by the 2 MSBs of the address.


\
\ @brief Access: No wait states
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$00000008 constant I2C1_ICR_ADDRCF                                  \ Address matched flag clear Writing 1 to this bit clears the ADDR flag in the I2C_ISR register. Writing 1 to this bit also clears the START bit in the I2C_CR2 register.
$00000010 constant I2C1_ICR_NACKCF                                  \ Not Acknowledge flag clear Writing 1 to this bit clears the ACKF flag in I2C_ISR register.
$00000020 constant I2C1_ICR_STOPCF                                  \ Stop detection flag clear Writing 1 to this bit clears the STOPF flag in the I2C_ISR register.
$00000100 constant I2C1_ICR_BERRCF                                  \ Bus error flag clear Writing 1 to this bit clears the BERRF flag in the I2C_ISR register.
$00000200 constant I2C1_ICR_ARLOCF                                  \ Arbitration Lost flag clear Writing 1 to this bit clears the ARLO flag in the I2C_ISR register.
$00000400 constant I2C1_ICR_OVRCF                                   \ Overrun/Underrun flag clear Writing 1 to this bit clears the OVR flag in the I2C_ISR register.
$00000800 constant I2C1_ICR_PECCF                                   \ PEC Error flag clear Writing 1 to this bit clears the PECERR flag in the I2C_ISR register. Note: If the SMBus feature is not supported, this bit is reserved and forced by hardware to 0. Please refer to Section25.3: I2C implementation.
$00001000 constant I2C1_ICR_TIMOUTCF                                \ Timeout detection flag clear Writing 1 to this bit clears the TIMEOUT flag in the I2C_ISR register. Note: If the SMBus feature is not supported, this bit is reserved and forced by hardware to 0. Please refer to Section25.3: I2C implementation.
$00002000 constant I2C1_ICR_ALERTCF                                 \ Alert flag clear Writing 1 to this bit clears the ALERT flag in the I2C_ISR register. Note: If the SMBus feature is not supported, this bit is reserved and forced by hardware to 0. Please refer to Section25.3: I2C implementation.


\
\ @brief Access: No wait states
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$000000ff constant I2C1_PECR_PEC                                    \ Packet error checking register This field contains the internal PEC when PECEN=1. The PEC is cleared by hardware when PE=0.


\
\ @brief Access: No wait states
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$000000ff constant I2C1_RXDR_RXDATA                                 \ 8-bit receive data Data byte received from the I2C bus.


\
\ @brief Access: No wait states
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$000000ff constant I2C1_TXDR_TXDATA                                 \ 8-bit transmit data Data byte to be transmitted to the I2C bus. Note: These bits can be written only when TXE=1.


\
\ @brief I2C1
\
$40005400 constant I2C1_CR1       \ offset: 0x00 : Access: No wait states, except if a write access occurs while a write access to this register is ongoing. In this case, wait states are inserted in the second write access until the previous one is completed. The latency of the second write access can be up to 2 x PCLK1 + 6 x I2CCLK.
$40005404 constant I2C1_CR2       \ offset: 0x04 : Access: No wait states, except if a write access occurs while a write access to this register is ongoing. In this case, wait states are inserted in the second write access until the previous one is completed. The latency of the second write access can be up to 2 x PCLK1 + 6 x I2CCLK.
$40005408 constant I2C1_OAR1      \ offset: 0x08 : Access: No wait states, except if a write access occurs while a write access to this register is ongoing. In this case, wait states are inserted in the second write access until the previous one is completed. The latency of the second write access can be up to 2 x PCLK1 + 6 x I2CCLK.
$4000540c constant I2C1_OAR2      \ offset: 0x0C : Access: No wait states, except if a write access occurs while a write access to this register is ongoing. In this case, wait states are inserted in the second write access until the previous one is completed. The latency of the second write access can be up to 2 x PCLK1 + 6 x I2CCLK.
$40005410 constant I2C1_TIMINGR   \ offset: 0x10 : Access: No wait states
$40005414 constant I2C1_TIMEOUTR  \ offset: 0x14 : Access: No wait states, except if a write access occurs while a write access to this register is ongoing. In this case, wait states are inserted in the second write access until the previous one is completed. The latency of the second write access can be up to 2 x PCLK1 + 6 x I2CCLK.
$40005418 constant I2C1_ISR       \ offset: 0x18 : Access: No wait states
$4000541c constant I2C1_ICR       \ offset: 0x1C : Access: No wait states
$40005420 constant I2C1_PECR      \ offset: 0x20 : Access: No wait states
$40005424 constant I2C1_RXDR      \ offset: 0x24 : Access: No wait states
$40005428 constant I2C1_TXDR      \ offset: 0x28 : Access: No wait states

