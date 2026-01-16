\
\ @file i2c2.fs
\ @brief I2C2 interrupt
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief I2C2_CR1 register
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000001 constant I2C2_I2C2_CR1_PE                                 \ Peripheral enable - 0: Peripheral disable - 1: Peripheral enable
$00000002 constant I2C2_I2C2_CR1_TXIE                               \ TX Interrupt enable - 0: Transmit (TXIS) interrupt disabled - 1: Transmit (TXIS) interrupt enabled
$00000004 constant I2C2_I2C2_CR1_RXIE                               \ RX Interrupt enable - 0: Receive (RXNE) interrupt disabled - 1: Receive (RXNE) interrupt enabled
$00000008 constant I2C2_I2C2_CR1_ADDRIE                             \ Address match Interrupt enable (slave only) - 0: Address match (ADDR) interrupts disabled - 1: Address match (ADDR) interrupts enabled
$00000010 constant I2C2_I2C2_CR1_NACKIE                             \ Not acknowledge received Interrupt enable - 0: Not acknowledge (NACKF) received interrupts disabled - 1: Not acknowledge (NACKF) received interrupts enabled
$00000020 constant I2C2_I2C2_CR1_STOPIE                             \ STOP detection Interrupt enable - 0: Stop detection (STOPF) interrupt disabled - 1: Stop detection (STOPF) interrupt enabled
$00000040 constant I2C2_I2C2_CR1_TCIE                               \ Transfer Complete interrupt enable - 0: Transfer Complete interrupt disabled - 1: Transfer Complete interrupt enabled
$00000080 constant I2C2_I2C2_CR1_ERRIE                              \ Error interrupts enable - 0: Error detection interrupts disabled - 1: Error detection interrupts enabled Note: Any of these errors generate an interrupt: Arbitration Loss (ARLO) Bus Error detection (BERR) Overrun/Underrun (OVR) Timeout detection (TIMEOUT) PEC error detection (PECERR) Alert pin event detection (ALERT)
$00000f00 constant I2C2_I2C2_CR1_DNF                                \ Digital noise filter These bits are used to configure the digital noise filter on SDA and SCL input. The digital filter will filter spikes with a length of up to DNF[3:0] * tI2CCLK - 0000: Digital filter disabled - 0001: Digital filter enabled and filtering capability up to 1 tI2CCLK - 1111: digital filter enabled and filtering capability up to15 tI2CCLK
$00001000 constant I2C2_I2C2_CR1_ANFOFF                             \ Analog noise filter OFF - 0: Analog noise filter enabled - 1: Analog noise filter disabled
$00004000 constant I2C2_I2C2_CR1_TXDMAEN                            \ DMA transmission requests enable - 0: DMA mode disabled for transmission - 1: DMA mode enabled for transmission
$00008000 constant I2C2_I2C2_CR1_RXDMAEN                            \ DMA reception requests enable - 0: DMA mode disabled for reception - 1: DMA mode enabled for reception
$00010000 constant I2C2_I2C2_CR1_SBC                                \ Slave byte control This bit is used to enable hardware byte control in slave mode. - 0: Slave byte control disabled - 1: Slave byte control enabled
$00020000 constant I2C2_I2C2_CR1_NOSTRETCH                          \ Clock stretching disable This bit is used to disable clock stretching in slave mode. It must be kept cleared in master mode. - 0: Clock stretching enabled - 1: Clock stretching disabled Note: This bit can only be programmed when the I2C is disabled (PE = 0).
$00080000 constant I2C2_I2C2_CR1_GCEN                               \ General call enable - 0: General call disabled. Address 0b00000000 is NACKed. - 1: General call enabled. Address 0b00000000 is ACKed.
$00100000 constant I2C2_I2C2_CR1_SMBHEN                             \ SMBus Host address enable - 0: Host address disabled. Address 0b0001000x is NACKed. - 1: Host address enabled. Address 0b0001000x is ACKed.
$00200000 constant I2C2_I2C2_CR1_SMBDEN                             \ SMBus Device Default address enable - 0: Device default address disabled. Address 0b1100001x is NACKed. - 1: Device default address enabled. Address 0b1100001x is ACKed.
$00400000 constant I2C2_I2C2_CR1_ALERTEN                            \ SMBus alert enable Device mode (SMBHEN=0): - 0: Releases SMBA pin high and Alert Response Address Header disabled: 0001100x followed by NACK. - 1: Drives SMBA pin low and Alert Response Address Header enables: 0001100x followed by ACK. Host mode (SMBHEN=1): - 0: SMBus Alert pin (SMBA) not supported. - 1: SMBus Alert pin (SMBA) supported.
$00800000 constant I2C2_I2C2_CR1_PECEN                              \ PEC enable - 0: PEC calculation disabled - 1: PEC calculation enabled


\
\ @brief I2C2_CR2 register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$000003ff constant I2C2_I2C2_CR2_SADD                               \ Slave address
$00000400 constant I2C2_I2C2_CR2_RD_WRN                             \ Transfer direction (master mode) - 0: Master requests a write transfer. - 1: Master requests a read transfer.
$00000800 constant I2C2_I2C2_CR2_ADD10                              \ Ten-bit addressing mode (master mode) - 0: The master operates in 7-bit addressing mode, - 1: The master operates in 10-bit addressing mode
$00001000 constant I2C2_I2C2_CR2_HEAD10R                            \ Ten bit (10-bit) address header only read direction (master receiver mode) - 0: The master sends the complete 10 bit slave address read sequence: Start + 2 bytes 10bit address in write direction + Restart + 1st 7 bits of the 10 bit address in read direction. - 1: The master only sends the 1st 7 bits of the 10 bit address, followed by Read direction.
$00002000 constant I2C2_I2C2_CR2_START                              \ Start generation This bit is set by software, and cleared by hardware after the Start followed by the address sequence is sent, by an arbitration loss, by a timeout error detection, or when PE = 0. It can also be cleared by software by writing 1 to the ADDRCF bit in the I2C_ICR register. - 0: No Start generation. - 1: Restart/Start generation: If the I2C is already in master mode with AUTOEND = 0, setting this bit generates a Repeated Start condition when RELOAD=0, after the end of the NBYTES transfer. Otherwise setting this bit will generate a START condition once the bus is free.
$00004000 constant I2C2_I2C2_CR2_STOP                               \ Stop generation (master mode) The bit is set by software, cleared by hardware when a Stop condition is detected, or when PE = 0. In Master Mode: - 0: No Stop generation. - 1: Stop generation after current byte transfer.
$00008000 constant I2C2_I2C2_CR2_NACK                               \ NACK generation (slave mode) The bit is set by software, cleared by hardware when the NACK is sent, or when a STOP condition or an Address matched is received, or when PE=0. - 0: an ACK is sent after current received byte. - 1: a NACK is sent after current received byte.
$00ff0000 constant I2C2_I2C2_CR2_NBYTES                             \ Number of bytes The number of bytes to be transmitted/received is programmed there. This field is dont care in slave mode with SBC=0.
$01000000 constant I2C2_I2C2_CR2_RELOAD                             \ NBYTES reload mode This bit is set and cleared by software. - 0: The transfer is completed after the NBYTES data transfer (STOP or RESTART will follow). - 1: The transfer is not completed after the NBYTES data transfer (NBYTES will be reloaded). TCR flag is set when NBYTES data are transferred, stretching SCL low.
$02000000 constant I2C2_I2C2_CR2_AUTOEND                            \ Automatic end mode (master mode) This bit is set and cleared by software. - 0: software end mode: TC flag is set when NBYTES data are transferred, stretching SCL low. - 1: Automatic end mode: a STOP condition is automatically sent when NBYTES data are transferred.
$04000000 constant I2C2_I2C2_CR2_PECBYTE                            \ Packet error checking byte This bit is set by software, and cleared by hardware when the PEC is transferred, or when a STOP condition or an Address matched is received, also when PE=0. - 0: No PEC transfer. - 1: PEC transmission/reception is requested


\
\ @brief I2C2_OAR1 register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$000003ff constant I2C2_I2C2_OAR1_OA1                               \ Interface address
$00000400 constant I2C2_I2C2_OAR1_OA1MODE                           \ Own Address 1 10-bit mode - 0: Own address 1 is a 7-bit address. - 1: Own address 1 is a 10-bit address.
$00008000 constant I2C2_I2C2_OAR1_OA1EN                             \ Own Address 1 enable - 0: Own address 1 disabled. The received slave address OA1 is NACKed. - 1: Own address 1 enabled. The received slave address OA1 is ACKed.


\
\ @brief I2C2_OAR2 register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$000000fe constant I2C2_I2C2_OAR2_OA2                               \ Interface address bits 7:1 of address Note: These bits can be written only when OA2EN=0.
$00000700 constant I2C2_I2C2_OAR2_OA2MSK                            \ Own Address 2 masks - 000: No mask - 001: OA2[1] is masked and dont care. Only OA2[7:2] are compared. - 010: OA2[2:1] are masked and dont care. Only OA2[7:3] are compared. - 011: OA2[3:1] are masked and dont care. Only OA2[7:4] are compared. - 100: OA2[4:1] are masked and dont care. Only OA2[7:5] are compared. - 101: OA2[5:1] are masked and dont care. Only OA2[7:6] are compared. - 110: OA2[6:1] are masked and dont care. Only OA2[7] is compared. - 111: OA2[7:1] are masked and dont care. No comparison is done, and all (except reserved) 7-bit received addresses are acknowledged.
$00008000 constant I2C2_I2C2_OAR2_OA2EN                             \ Own Address 2 enable - 0: Own address 2 disabled. The received slave address OA2 is NACKed. - 1: Own address 2 enabled. The received slave address OA2 is ACKed.


\
\ @brief I2C2_TIMING register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$000000ff constant I2C2_I2C2_TIMING_SCLL                            \ SCL low period (master mode) This field is used to generate the SCL low period in master mode. tSCLL = (SCLL+1) x tPRESC Note: SCLL is also used to generate tBUF and tSU:STA timings.
$0000ff00 constant I2C2_I2C2_TIMING_SCLH                            \ SCL high period (master mode) This field is used to generate the SCL high period in master mode. tSCLH = (SCLH+1) x tPRESC Note: SCLH is also used to generate tSU:STO and tHD:STA timing.
$000f0000 constant I2C2_I2C2_TIMING_SDADEL                          \ Data hold time This field is used to generate the delay tSDADEL between SCL falling edge SDA edge in transmission mode. tSDADEL= SDADEL x tPRESC Note: SDADEL is used to generate tHD:DAT timing.
$00f00000 constant I2C2_I2C2_TIMING_SCLDEL                          \ Data setup time This field is used to generate a delay tSCLDEL between SDA edge and SCL rising edge in transmission mode. tSCLDEL = (SCLDEL+1) x tPRESC Note: tSCLDEL is used to generate tSU:DAT timing.
$f0000000 constant I2C2_I2C2_TIMING_PRESC                           \ Timing prescaler This field is used to prescale I2CCLK in order to generate the clock period tPRESC used for data setup and hold counters and for SCL high and low level counters tPRESC = (PRESC+1) x tI2CCLK


\
\ @brief I2C2_TIMEOUT register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000fff constant I2C2_I2C2_TIMEOUT_TIMEOUTA                       \ Bus Timeout A This field is used to configure: The SCL low timeout condition tTIMEOUT when TIDLE=0 tTIMEOUT= (TIMEOUTA+1) x 2048 x tI2CCLK The bus idle condition (both SCL and SDA high) when TIDLE=1 tIDLE= (TIMEOUTA+1) x 4 x tI2CCLK Note: These bits can be written only when TIMOUTEN=0.
$00001000 constant I2C2_I2C2_TIMEOUT_TIDLE                          \ Idle clock timeout detection - 0: TIMEOUTA is used to detect SCL low timeout - 1: TIMEOUTA is used to detect both SCL and SDA high timeout (bus idle condition) Note: This bit can be written only when TIMOUTEN=0.
$00008000 constant I2C2_I2C2_TIMEOUT_TIMEOUTEN                      \ Clock timeout enable - 0: SCL timeout detection is disabled - 1: SCL timeout detection is enabled: when SCL is low for more than tTIMEOUT (TIDLE=0) or high for more than tIDLE (TIDLE=1), a timeout error is detected (TIMEOUT=1).
$0fff0000 constant I2C2_I2C2_TIMEOUT_TIMEOUTB                       \ Bus timeout B This field is used to configure the cumulative clock extension timeout: In master mode, the master cumulative clock low extend time (tLOW:MEXT) is detected In slave mode, the slave cumulative clock low extend time (tLOW:SEXT) is detected tLOW:EXT= (TIMEOUTB+1) x 2048 x tI2CCLK Note: These bits can be written only when TEXTEN=0.
$80000000 constant I2C2_I2C2_TIMEOUT_TEXTEN                         \ Extended clock timeout enable - 0: Extended clock timeout detection is disabled - 1: Extended clock timeout detection is enabled. When a cumulative SCL stretch for more than tLOW:EXT is done by the I2C interface, a timeout error is detected (TIMEOUT=1).


\
\ @brief I2C2_ISR register
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000001 constant I2C2_I2C2_ISR_TXE                                \ Transmit data register empty (transmitters) This bit is set by hardware when the I2C_TXDR register is empty. It is cleared when the next data to be sent is written in the I2C_TXDR register. This bit can be written to 1 by software in order to flush the transmit data register I2C_TXDR. Note: This bit is set by hardware when PE=0.
$00000002 constant I2C2_I2C2_ISR_TXIS                               \ Transmit interrupt status (transmitters) This bit is set by hardware when the I2C_TXDR register is empty and the data to be transmitted must be written in the I2C_TXDR register. It is cleared when the next data to be sent is written in the I2C_TXDR register. This bit can be written to 1 by software when NOSTRETCH=1 only, in order to generate a TXIS event (interrupt if TXIE=1 or DMA request if TXDMAEN=1). Note: This bit is cleared by hardware when PE=0.
$00000004 constant I2C2_I2C2_ISR_RXNE                               \ Receive data register not empty (receivers) This bit is set by hardware when the received data is copied into the I2C_RXDR register, and is ready to be read. It is cleared when I2C_RXDR is read. Note: This bit is cleared by hardware when PE=0.
$00000008 constant I2C2_I2C2_ISR_ADDR                               \ Address matched (slave mode) This bit is set by hardware as soon as the received slave address matched with one of the enabled slave addresses. It is cleared by software by setting ADDRCF bit. Note: This bit is cleared by hardware when PE=0.
$00000010 constant I2C2_I2C2_ISR_NACKF                              \ Not Acknowledge received flag This flag is set by hardware when a NACK is received after a byte transmission. It is cleared by software by setting the NACKCF bit. Note: This bit is cleared by hardware when PE=0.
$00000020 constant I2C2_I2C2_ISR_STOPF                              \ Stop detection flag This flag is set by hardware when a Stop condition is detected on the bus and the peripheral is involved in this transfer: either as a master, provided that the STOP condition is generated by the peripheral. or as a slave, provided that the peripheral has been addressed previously during this transfer. It is cleared by software by setting the STOPCF bit. Note: This bit is cleared by hardware when PE=0.
$00000040 constant I2C2_I2C2_ISR_TC                                 \ Transfer Complete (master mode) This flag is set by hardware when RELOAD=0, AUTOEND=0 and NBYTES data have been transferred. It is cleared by software when START bit or STOP bit is set. Note: This bit is cleared by hardware when PE=0.
$00000080 constant I2C2_I2C2_ISR_TCR                                \ Transfer Complete Reload This flag is set by hardware when RELOAD=1 and NBYTES data have been transferred. It is cleared by software when NBYTES is written to a non-zero value. Note: This bit is cleared by hardware when PE=0. This flag is only for master mode, or for slave mode when the SBC bit is set.
$00000100 constant I2C2_I2C2_ISR_BERR                               \ Bus error This flag is set by hardware when a misplaced Start or Stop condition is detected whereas the peripheral is involved in the transfer. The flag is not set during the address phase in slave mode. It is cleared by software by setting BERRCF bit. Note: This bit is cleared by hardware when PE=0.
$00000200 constant I2C2_I2C2_ISR_ARLO                               \ Arbitration lost This flag is set by hardware in case of arbitration loss. It is cleared by software by setting the ARLOCF bit. Note: This bit is cleared by hardware when PE=0.
$00000400 constant I2C2_I2C2_ISR_OVR                                \ Overrun/Underrun (slave mode) This flag is set by hardware in slave mode with NOSTRETCH=1, when an overrun/underrun error occurs. It is cleared by software by setting the OVRCF bit. Note: This bit is cleared by hardware when PE=0.
$00000800 constant I2C2_I2C2_ISR_PECERR                             \ PEC Error in reception This flag is set by hardware when the received PEC does not match with the PEC register content. A NACK is automatically sent after the wrong PEC reception. It is cleared by software by setting the PECCF bit. Note: This bit is cleared by hardware when PE=0. If the SMBus feature is not supported, this bit is reserved and forced by hardware to 0. Please refer to Section 22.3: I2C implementation.
$00001000 constant I2C2_I2C2_ISR_TIMEOUT                            \ Timeout or tLOW detection flag This flag is set by hardware when a timeout or extended clock timeout occurred. It is cleared by software by setting the TIMEOUTCF bit. Note: This bit is cleared by hardware when PE=0. If the SMBus feature is not supported, this bit is reserved and forced by hardware to 0. Please refer to Section 22.3: I2C implementation.
$00002000 constant I2C2_I2C2_ISR_ALERT                              \ SMBus alert This flag is set by hardware when SMBHEN=1 (SMBus host configuration), ALERTEN=1 and a SMBALERT event (falling edge) is detected on SMBA pin. It is cleared by software by setting the ALERTCF bit. Note: This bit is cleared by hardware when PE=0. If the SMBus feature is not supported, this bit is reserved and forced by hardware to 0. Please refer to Section 22.3: I2C implementation.
$00008000 constant I2C2_I2C2_ISR_BUSY                               \ Bus busy This flag indicates that a communication is in progress on the bus. It is set by hardware when a START condition is detected. It is cleared by hardware when a Stop condition is detected, or when PE=0.
$00010000 constant I2C2_I2C2_ISR_DIR                                \ Transfer direction (Slave mode) This flag is updated when an address match event occurs (ADDR=1). - 0: Write transfer, slave enters receiver mode. - 1: Read transfer, slave enters transmitter mode.
$00fe0000 constant I2C2_I2C2_ISR_ADDCODE                            \ Address match code (Slave mode) These bits are updated with the received address when an address match event occurs (ADDR = 1). In the case of a 10-bit address, ADDCODE provides the 10-bit header followed by the 2 MSBs of the address.


\
\ @brief I2C2_ICR register
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$00000008 constant I2C2_I2C2_ICR_ADDRCF                             \ Address matched flag clear Writing 1 to this bit clears the ADDR flag in the I2C_ISR register. Writing 1 to this bit also clears the START bit in the I2C_CR2 register.
$00000010 constant I2C2_I2C2_ICR_NACKCF                             \ Not Acknowledge flag clear Writing 1 to this bit clears the ACKF flag in I2C_ISR register.
$00000020 constant I2C2_I2C2_ICR_STOPCF                             \ Stop detection flag clear Writing 1 to this bit clears the STOPF flag in the I2C_ISR register.
$00000100 constant I2C2_I2C2_ICR_BERRCF                             \ Bus error flag clear Writing 1 to this bit clears the BERRF flag in the I2C_ISR register.
$00000200 constant I2C2_I2C2_ICR_ARLOCF                             \ Arbitration Lost flag clear Writing 1 to this bit clears the ARLO flag in the I2C_ISR register.
$00000400 constant I2C2_I2C2_ICR_OVRCF                              \ Overrun/Underrun flag clear Writing 1 to this bit clears the OVR flag in the I2C_ISR register.
$00000800 constant I2C2_I2C2_ICR_PECCF                              \ PEC Error flag clear Writing 1 to this bit clears the PECERR flag in the I2C_ISR register. Note: If the SMBus feature is not supported, this bit is reserved and forced by hardware to 0. Please refer to Section 22.3: I2C implementation.
$00001000 constant I2C2_I2C2_ICR_TIMOUTCF                           \ Timeout detection flag clear Writing 1 to this bit clears the TIMEOUT flag in the I2C_ISR register. Note: If the SMBus feature is not supported, this bit is reserved and forced by hardware to 0. Please refer to Section 22.3: I2C implementation.
$00002000 constant I2C2_I2C2_ICR_ALERTCF                            \ Alert flag clear Writing 1 to this bit clears the ALERT flag in the I2C_ISR register. Note: If the SMBus feature is not supported, this bit is reserved and forced by hardware to 0. Please refer to Section 22.3: I2C implementation.


\
\ @brief I2C2_PECR register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$000000ff constant I2C2_I2C2_PECR_PEC                               \ Packet error checking register This field contains the internal PEC when PECEN=1. The PEC is cleared by hardware when PE=0.


\
\ @brief I2C2_RXDR register
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$000000ff constant I2C2_I2C2_RXDR_RXDATA                            \ Eight bit (8-bit) receive data Data byte received from the I2C bus.


\
\ @brief I2C2_TXDR register
\ Address offset: 0x28
\ Reset value: 0x    NULL
\

$000000ff constant I2C2_I2C2_TXDR_TXDATA                            \ Eight bits (8-bit) transmit data Data byte to be transmitted to the I2C bus. Note: These bits can be written only when TXE=1.


\
\ @brief I2C2 interrupt
\
$41001000 constant I2C2_I2C2_CR1  \ offset: 0x00 : I2C2_CR1 register
$41001004 constant I2C2_I2C2_CR2  \ offset: 0x04 : I2C2_CR2 register
$41001008 constant I2C2_I2C2_OAR1  \ offset: 0x08 : I2C2_OAR1 register
$4100100c constant I2C2_I2C2_OAR2  \ offset: 0x0C : I2C2_OAR2 register
$41001010 constant I2C2_I2C2_TIMING  \ offset: 0x10 : I2C2_TIMING register
$41001014 constant I2C2_I2C2_TIMEOUT  \ offset: 0x14 : I2C2_TIMEOUT register
$41001018 constant I2C2_I2C2_ISR  \ offset: 0x18 : I2C2_ISR register
$4100101c constant I2C2_I2C2_ICR  \ offset: 0x1C : I2C2_ICR register
$41001020 constant I2C2_I2C2_PECR  \ offset: 0x20 : I2C2_PECR register
$41001024 constant I2C2_I2C2_RXDR  \ offset: 0x24 : I2C2_RXDR register
$41001028 constant I2C2_I2C2_TXDR  \ offset: 0x28 : I2C2_TXDR register

