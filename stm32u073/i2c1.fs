\
\ @file i2c1.fs
\ @brief I2C address block description
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

$00000001 constant I2C1_I2C_CR1_PE                                  \ Peripheral enable Note: When PE = 0, the I2C SCL and SDA lines are released. Internal state machines and status bits are put back to their reset value. When cleared, PE must be kept low for at least three APB clock cycles.
$00000002 constant I2C1_I2C_CR1_TXIE                                \ TX interrupt enable
$00000004 constant I2C1_I2C_CR1_RXIE                                \ RX interrupt enable
$00000008 constant I2C1_I2C_CR1_ADDRIE                              \ Address match interrupt enable (slave only)
$00000010 constant I2C1_I2C_CR1_NACKIE                              \ Not acknowledge received interrupt enable
$00000020 constant I2C1_I2C_CR1_STOPIE                              \ Stop detection interrupt enable
$00000040 constant I2C1_I2C_CR1_TCIE                                \ Transfer complete interrupt enable Note: Any of these events generate an interrupt: Note: Transfer complete (TC) Note: Transfer complete reload (TCR)
$00000080 constant I2C1_I2C_CR1_ERRIE                               \ Error interrupts enable Note: Any of these errors generate an interrupt: Note: Arbitration loss (ARLO) Note: Bus error detection (BERR) Note: Overrun/Underrun (OVR)
$00000f00 constant I2C1_I2C_CR1_DNF                                 \ Digital noise filter These bits are used to configure the digital noise filter on SDA and SCL input. The digital filter, filters spikes with a length of up to DNF[3:0] * t<sub>I2CCLK</sub> <sub>...</sub> Note: If the analog filter is enabled, the digital filter is added to it. This filter can be programmed only when the I2C is disabled (PE = 0).
$00001000 constant I2C1_I2C_CR1_ANFOFF                              \ Analog noise filter OFF Note: This bit can be programmed only when the I2C is disabled (PE = 0).
$00004000 constant I2C1_I2C_CR1_TXDMAEN                             \ DMA transmission requests enable
$00008000 constant I2C1_I2C_CR1_RXDMAEN                             \ DMA reception requests enable
$00010000 constant I2C1_I2C_CR1_SBC                                 \ Slave byte control This bit is used to enable hardware byte control in slave mode.
$00020000 constant I2C1_I2C_CR1_NOSTRETCH                           \ Clock stretching disable This bit is used to disable clock stretching in slave mode. It must be kept cleared in master mode. Note: This bit can be programmed only when the I2C is disabled (PE = 0).
$00040000 constant I2C1_I2C_CR1_WUPEN                               \ Wake-up from Stop mode enable
$00080000 constant I2C1_I2C_CR1_GCEN                                \ General call enable
$01000000 constant I2C1_I2C_CR1_FMP                                 \ Fast-mode Plus 20 mA drive enable
$40000000 constant I2C1_I2C_CR1_ADDRACLR                            \ Address match flag (ADDR) automatic clear
$80000000 constant I2C1_I2C_CR1_STOPFACLR                           \ STOP detection flag (STOPF) automatic clear


\
\ @brief I2C control register 2
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$000003ff constant I2C1_I2C_CR2_SADD                                \ Slave address (master mode) In 7-bit addressing mode (ADD10 = 0): SADD[7:1] must be written with the 7-bit slave address to be sent. Bits SADD[9], SADD[8] and SADD[0] are don't care. In 10-bit addressing mode (ADD10 = 1): SADD[9:0] must be written with the 10-bit slave address to be sent. Note: Changing these bits when the START bit is set is not allowed.
$00000400 constant I2C1_I2C_CR2_RD_WRN                              \ Transfer direction (master mode) Note: Changing this bit when the START bit is set is not allowed.
$00000800 constant I2C1_I2C_CR2_ADD10                               \ 10-bit addressing mode (master mode) Note: Changing this bit when the START bit is set is not allowed.
$00001000 constant I2C1_I2C_CR2_HEAD10R                             \ 10-bit address header only read direction (master receiver mode) Note: Changing this bit when the START bit is set is not allowed.
$00002000 constant I2C1_I2C_CR2_START                               \ Start generation This bit is set by software, and cleared by hardware after the Start followed by the address sequence is sent, by an arbitration loss, by an address matched in slave mode, by a timeout error detection, or when PE = 0. If the I2C is already in master mode with AUTOEND = 0, setting this bit generates a Repeated start condition when RELOAD = 0, after the end of the NBYTES transfer. Otherwise, setting this bit generates a START condition once the bus is free. Note: Writing 0 to this bit has no effect. Note: The START bit can be set even if the bus is BUSY or I2C is in slave mode. Note: This bit has no effect when RELOAD is set.
$00004000 constant I2C1_I2C_CR2_STOP                                \ Stop generation (master mode) The bit is set by software, cleared by hardware when a STOP condition is detected, or when PE = 0. In master mode: Note: Writing 0 to this bit has no effect.
$00008000 constant I2C1_I2C_CR2_NACK                                \ NACK generation (slave mode) The bit is set by software, cleared by hardware when the NACK is sent, or when a STOP condition or an Address matched is received, or when PE = 0. Note: Writing 0 to this bit has no effect. Note: This bit is used in slave mode only: in master receiver mode, NACK is automatically generated after last byte preceding STOP or RESTART condition, whatever the NACK bit value. Note: When an overrun occurs in slave receiver NOSTRETCH mode, a NACK is automatically generated, whatever the NACK bit value. Note: When hardware PEC checking is enabled (PECBYTE = 1), the PEC acknowledge value does not depend on the NACK value.
$00ff0000 constant I2C1_I2C_CR2_NBYTES                              \ Number of bytes
$01000000 constant I2C1_I2C_CR2_RELOAD                              \ NBYTES reload mode This bit is set and cleared by software.
$02000000 constant I2C1_I2C_CR2_AUTOEND                             \ Automatic end mode (master mode) This bit is set and cleared by software. Note: This bit has no effect in slave mode or when the RELOAD bit is set.


\
\ @brief I2C own address 1 register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$000003ff constant I2C1_I2C_OAR1_OA1                                \ Interface own slave address 7-bit addressing mode: OA1[7:1] contains the 7-bit own slave address. Bits OA1[9], OA1[8] and OA1[0] are don't care. 10-bit addressing mode: OA1[9:0] contains the 10-bit own slave address. Note: These bits can be written only when OA1EN = 0.
$00000400 constant I2C1_I2C_OAR1_OA1MODE                            \ Own address 1 10-bit mode Note: This bit can be written only when OA1EN = 0.
$00008000 constant I2C1_I2C_OAR1_OA1EN                              \ Own address 1 enable


\
\ @brief I2C own address 2 register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$000000fe constant I2C1_I2C_OAR2_OA2                                \ Interface address 7-bit addressing mode: 7-bit address Note: These bits can be written only when OA2EN = 0.
$00000700 constant I2C1_I2C_OAR2_OA2MSK                             \ Own address 2 masks Note: These bits can be written only when OA2EN = 0. Note: As soon as OA2MSK is not equal to 0, the reserved I2C addresses (0b0000xxx and 0b1111xxx) are not acknowledged even if the comparison matches.
$00008000 constant I2C1_I2C_OAR2_OA2EN                              \ Own address 2 enable


\
\ @brief I2C timing register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$000000ff constant I2C1_I2C_TIMINGR_SCLL                            \ SCL low period (master mode) This field is used to generate the SCL low period in master mode. t<sub>SCLL </sub>= (SCLL + 1) x t<sub>PRESC</sub> Note: SCLL is also used to generate t<sub>BUF </sub>and t<sub>SU:STA </sub>timings.
$0000ff00 constant I2C1_I2C_TIMINGR_SCLH                            \ SCL high period (master mode) This field is used to generate the SCL high period in master mode. t<sub>SCLH </sub>= (SCLH + 1) x t<sub>PRESC</sub> Note: SCLH is also used to generate t<sub>SU:STO </sub>and t<sub>HD:STA </sub>timing.
$000f0000 constant I2C1_I2C_TIMINGR_SDADEL                          \ Data hold time This field is used to generate the delay t<sub>SDADEL </sub>between SCL falling edge and SDA edge. In master and in slave modes with NOSTRETCH = 0, the SCL line is stretched low during t<sub>SDADEL</sub>. t<sub>SDADEL</sub>= SDADEL x t<sub>PRESC</sub> Note: SDADEL is used to generate t<sub>HD:DAT </sub>timing.
$00f00000 constant I2C1_I2C_TIMINGR_SCLDEL                          \ Data setup time This field is used to generate a delay t<sub>SCLDEL </sub>between SDA edge and SCL rising edge. In master and in slave modes with NOSTRETCH = 0, the SCL line is stretched low during t<sub>SCLDEL</sub>. t<sub>SCLDEL </sub>= (SCLDEL + 1) x t<sub>PRESC</sub> Note: t<sub>SCLDEL</sub> is used to generate t<sub>SU:DAT </sub>timing.
$f0000000 constant I2C1_I2C_TIMINGR_PRESC                           \ Timing prescaler This field is used to prescale I2CCLK to generate the clock period t<sub>PRESC </sub>used for data setup and hold counters (refer to I2C timings) and for SCL high and low level counters (refer to I2C master initialization). t<sub>PRESC </sub>= (PRESC + 1) x t<sub>I2CCLK</sub>


\
\ @brief I2C timeout register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000fff constant I2C1_I2C_TIMEOUTR_TIMEOUTA                       \ Bus timeout A This field is used to configure: The SCL low timeout condition t<sub>TIMEOUT</sub> when TIDLE = 0 t<sub>TIMEOUT</sub>= (TIMEOUTA + 1) x 2048 x t<sub>I2CCLK</sub> The bus idle condition (both SCL and SDA high) when TIDLE = 1 t<sub>IDLE</sub>= (TIMEOUTA + 1) x 4 x t<sub>I2CCLK</sub> Note: These bits can be written only when TIMOUTEN = 0.
$00001000 constant I2C1_I2C_TIMEOUTR_TIDLE                          \ Idle clock timeout detection Note: This bit can be written only when TIMOUTEN = 0.
$00008000 constant I2C1_I2C_TIMEOUTR_TIMOUTEN                       \ Clock timeout enable
$0fff0000 constant I2C1_I2C_TIMEOUTR_TIMEOUTB                       \ Bus timeout B This field is used to configure the cumulative clock extension timeout: In master mode, the master cumulative clock low extend time (t<sub>LOW:MEXT</sub>) is detected In slave mode, the slave cumulative clock low extend time (t<sub>LOW:SEXT</sub>) is detected t<sub>LOW:EXT </sub>= (TIMEOUTB + TIDLE = 01) x 2048 x t<sub>I2CCLK</sub> Note: These bits can be written only when TEXTEN = 0.
$80000000 constant I2C1_I2C_TIMEOUTR_TEXTEN                         \ Extended clock timeout enable


\
\ @brief I2C interrupt and status register
\ Address offset: 0x18
\ Reset value: 0x00000001
\

$00000001 constant I2C1_I2C_ISR_TXE                                 \ Transmit data register empty (transmitters) This bit is set by hardware when the I2C_TXDR register is empty. It is cleared when the next data to be sent is written in the I2C_TXDR register. This bit can be written to 1 by software in order to flush the transmit data register I2C_TXDR. Note: This bit is set by hardware when PE = 0.
$00000002 constant I2C1_I2C_ISR_TXIS                                \ Transmit interrupt status (transmitters) This bit is set by hardware when the I2C_TXDR register is empty and the data to be transmitted must be written in the I2C_TXDR register. It is cleared when the next data to be sent is written in the I2C_TXDR register. This bit can be written to 1 by software only when NOSTRETCH = 1, to generate a TXIS event (interrupt if TXIE = 1 or DMA request if TXDMAEN = 1). Note: This bit is cleared by hardware when PE = 0.
$00000004 constant I2C1_I2C_ISR_RXNE                                \ Receive data register not empty (receivers) This bit is set by hardware when the received data is copied into the I2C_RXDR register, and is ready to be read. It is cleared when I2C_RXDR is read. Note: This bit is cleared by hardware when PE = 0.
$00000008 constant I2C1_I2C_ISR_ADDR                                \ Address matched (slave mode) This bit is set by hardware as soon as the received slave address matched with one of the enabled slave addresses. It is cleared by software by setting ADDRCF bit. Note: This bit is cleared by hardware when PE = 0.
$00000010 constant I2C1_I2C_ISR_NACKF                               \ Not Acknowledge received flag This flag is set by hardware when a NACK is received after a byte transmission. It is cleared by software by setting the NACKCF bit. Note: This bit is cleared by hardware when PE = 0.
$00000020 constant I2C1_I2C_ISR_STOPF                               \ Stop detection flag This flag is set by hardware when a STOP condition is detected on the bus and the peripheral is involved in this transfer: either as a master, provided that the STOP condition is generated by the peripheral. or as a slave, provided that the peripheral has been addressed previously during this transfer. It is cleared by software by setting the STOPCF bit. Note: This bit is cleared by hardware when PE = 0.
$00000040 constant I2C1_I2C_ISR_TC                                  \ Transfer Complete (master mode) This flag is set by hardware when RELOAD = 0, AUTOEND = 0 and NBYTES data have been transferred. It is cleared by software when START bit or STOP bit is set. Note: This bit is cleared by hardware when PE = 0.
$00000080 constant I2C1_I2C_ISR_TCR                                 \ Transfer Complete Reload This flag is set by hardware when RELOAD = 1 and NBYTES data have been transferred. It is cleared by software when NBYTES is written to a non-zero value. Note: This bit is cleared by hardware when PE = 0. Note: This flag is only for master mode, or for slave mode when the SBC bit is set.
$00000100 constant I2C1_I2C_ISR_BERR                                \ Bus error This flag is set by hardware when a misplaced Start or STOP condition is detected whereas the peripheral is involved in the transfer. The flag is not set during the address phase in slave mode. It is cleared by software by setting BERRCF bit. Note: This bit is cleared by hardware when PE = 0.
$00000200 constant I2C1_I2C_ISR_ARLO                                \ Arbitration lost This flag is set by hardware in case of arbitration loss. It is cleared by software by setting the ARLOCF bit. Note: This bit is cleared by hardware when PE = 0.
$00000400 constant I2C1_I2C_ISR_OVR                                 \ Overrun/Underrun (slave mode) This flag is set by hardware in slave mode with NOSTRETCH = 1, when an overrun/underrun error occurs. It is cleared by software by setting the OVRCF bit. Note: This bit is cleared by hardware when PE = 0.
$00008000 constant I2C1_I2C_ISR_BUSY                                \ Bus busy This flag indicates that a communication is in progress on the bus. It is set by hardware when a START condition is detected, and cleared by hardware when a STOP condition is detected, or when PE = 0.
$00010000 constant I2C1_I2C_ISR_DIR                                 \ Transfer direction (slave mode) This flag is updated when an address match event occurs (ADDR = 1).
$00fe0000 constant I2C1_I2C_ISR_ADDCODE                             \ Address match code (slave mode) These bits are updated with the received address when an address match event occurs (ADDR = 1). In the case of a 10-bit address, ADDCODE provides the 10-bit header followed by the two MSBs of the address.


\
\ @brief I2C interrupt clear register
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$00000008 constant I2C1_I2C_ICR_ADDRCF                              \ Address matched flag clear Writing 1 to this bit clears the ADDR flag in the I2C_ISR register. Writing 1 to this bit also clears the START bit in the I2C_CR2 register.
$00000010 constant I2C1_I2C_ICR_NACKCF                              \ Not Acknowledge flag clear Writing 1 to this bit clears the NACKF flag in I2C_ISR register.
$00000020 constant I2C1_I2C_ICR_STOPCF                              \ STOP detection flag clear Writing 1 to this bit clears the STOPF flag in the I2C_ISR register.
$00000100 constant I2C1_I2C_ICR_BERRCF                              \ Bus error flag clear Writing 1 to this bit clears the BERRF flag in the I2C_ISR register.
$00000200 constant I2C1_I2C_ICR_ARLOCF                              \ Arbitration lost flag clear Writing 1 to this bit clears the ARLO flag in the I2C_ISR register.
$00000400 constant I2C1_I2C_ICR_OVRCF                               \ Overrun/Underrun flag clear Writing 1 to this bit clears the OVR flag in the I2C_ISR register.


\
\ @brief I2C PEC register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$000000ff constant I2C1_I2C_PECR_PEC                                \ Packet error checking register This field contains the internal PEC when PECEN=1. The PEC is cleared by hardware when PE = 0.


\
\ @brief I2C receive data register
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$000000ff constant I2C1_I2C_RXDR_RXDATA                             \ 8-bit receive data Data byte received from the I<sup>2</sup>C bus


\
\ @brief I2C transmit data register
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$000000ff constant I2C1_I2C_TXDR_TXDATA                             \ 8-bit transmit data Data byte to be transmitted to the I<sup>2</sup>C bus Note: These bits can be written only when TXE = 1.


\
\ @brief I2C address block description
\
$40005400 constant I2C1_I2C_CR1   \ offset: 0x00 : I2C control register 1
$40005404 constant I2C1_I2C_CR2   \ offset: 0x04 : I2C control register 2
$40005408 constant I2C1_I2C_OAR1  \ offset: 0x08 : I2C own address 1 register
$4000540c constant I2C1_I2C_OAR2  \ offset: 0x0C : I2C own address 2 register
$40005410 constant I2C1_I2C_TIMINGR  \ offset: 0x10 : I2C timing register
$40005414 constant I2C1_I2C_TIMEOUTR  \ offset: 0x14 : I2C timeout register
$40005418 constant I2C1_I2C_ISR   \ offset: 0x18 : I2C interrupt and status register
$4000541c constant I2C1_I2C_ICR   \ offset: 0x1C : I2C interrupt clear register
$40005420 constant I2C1_I2C_PECR  \ offset: 0x20 : I2C PEC register
$40005424 constant I2C1_I2C_RXDR  \ offset: 0x24 : I2C receive data register
$40005428 constant I2C1_I2C_TXDR  \ offset: 0x28 : I2C transmit data register

