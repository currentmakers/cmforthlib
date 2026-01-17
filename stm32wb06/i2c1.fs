\
\ @file i2c1.fs
\ @brief I2C address block description
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] I2C1_DEF

  [ifdef] I2C1_I2C_CR1_DEF
    \
    \ @brief I2C control register 1
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant I2C1_PE                        \ [0x00] Peripheral enable Note: When PE = 0, the I2C SCL and SDA lines are released. Internal state machines and status bits are put back to their reset value. When cleared, PE must be kept low for at least 3 APB clock cycles.
    $01 constant I2C1_TXIE                      \ [0x01] TX Interrupt enable
    $02 constant I2C1_RXIE                      \ [0x02] RX Interrupt enable
    $03 constant I2C1_ADDRIE                    \ [0x03] Address match Interrupt enable (slave only)
    $04 constant I2C1_NACKIE                    \ [0x04] Not acknowledge received Interrupt enable
    $05 constant I2C1_STOPIE                    \ [0x05] Stop detection Interrupt enable
    $06 constant I2C1_TCIE                      \ [0x06] Transfer Complete interrupt enable Note: Any of these events generate an interrupt: Note: Transfer Complete (TC) Note: Transfer Complete Reload (TCR)
    $07 constant I2C1_ERRIE                     \ [0x07] Error interrupts enable Note: Any of these errors generate an interrupt: Note: Arbitration Loss (ARLO) Note: Bus Error detection (BERR) Note: Overrun/Underrun (OVR) Note: Timeout detection (TIMEOUT) Note: PEC error detection (PECERR) Note: Alert pin event detection (ALERT)
    $08 constant I2C1_DNF                       \ [0x08 : 4] Digital noise filter These bits are used to configure the digital noise filter on SDA and SCL input. The digital filter, filters spikes with a length of up to DNF[3:0] * t<sub>I2CCLK</sub> <sub>...</sub> Note: If the analog filter is also enabled, the digital filter is added to the analog filter. Note: This filter can only be programmed when the I2C is disabled (PE = 0).
    $0c constant I2C1_ANFOFF                    \ [0x0c] Analog noise filter OFF Note: This bit can only be programmed when the I2C is disabled (PE = 0).
    $0e constant I2C1_TXDMAEN                   \ [0x0e] DMA transmission requests enable
    $0f constant I2C1_RXDMAEN                   \ [0x0f] DMA reception requests enable
    $10 constant I2C1_SBC                       \ [0x10] Slave byte control This bit is used to enable hardware byte control in slave mode.
    $11 constant I2C1_NOSTRETCH                 \ [0x11] Clock stretching disable This bit is used to disable clock stretching in slave mode. It must be kept cleared in master mode. Note: This bit can only be programmed when the I2C is disabled (PE = 0).
    $12 constant I2C1_WUPEN                     \ [0x12] Wakeup from Stop mode enable Note: If the Wakeup from Stop mode feature is not supported, this bit is reserved and forced by hardware to '0'. Refer to Section 52.3: I2C implementation. Note: WUPEN can be set only when DNF = '0000'
    $13 constant I2C1_GCEN                      \ [0x13] General call enable
    $14 constant I2C1_SMBHEN                    \ [0x14] SMBus host address enable Note: If the SMBus feature is not supported, this bit is reserved and forced by hardware to '0'. Refer to Section 52.3: I2C implementation.
    $15 constant I2C1_SMBDEN                    \ [0x15] SMBus device default address enable Note: If the SMBus feature is not supported, this bit is reserved and forced by hardware to '0'. Refer to Section 52.3: I2C implementation.
    $16 constant I2C1_ALERTEN                   \ [0x16] SMBus alert enable Note: When ALERTEN=0, the SMBA pin can be used as a standard GPIO. Note: If the SMBus feature is not supported, this bit is reserved and forced by hardware to '0'. Refer to Section 52.3: I2C implementation.
    $17 constant I2C1_PECEN                     \ [0x17] PEC enable Note: If the SMBus feature is not supported, this bit is reserved and forced by hardware to '0'. Refer to Section 52.3: I2C implementation.
  [then]


  [ifdef] I2C1_I2C_CR2_DEF
    \
    \ @brief I2C control register 2
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant I2C1_SADD                      \ [0x00 : 10] Slave address (master mode) In 7-bit addressing mode (ADD10 = 0): SADD[7:1] should be written with the 7-bit slave address to be sent. The bits SADD[9], SADD[8] and SADD[0] are don't care. In 10-bit addressing mode (ADD10 = 1): SADD[9:0] should be written with the 10-bit slave address to be sent. Note: Changing these bits when the START bit is set is not allowed.
    $0a constant I2C1_RD_WRN                    \ [0x0a] Transfer direction (master mode) Note: Changing this bit when the START bit is set is not allowed.
    $0b constant I2C1_ADD10                     \ [0x0b] 10-bit addressing mode (master mode) Note: Changing this bit when the START bit is set is not allowed.
    $0c constant I2C1_HEAD10R                   \ [0x0c] 10-bit address header only read direction (master receiver mode) Note: Changing this bit when the START bit is set is not allowed.
    $0d constant I2C1_START                     \ [0x0d] Start generation This bit is set by software, and cleared by hardware after the Start followed by the address sequence is sent, by an arbitration loss, by a timeout error detection, or when PE = 0. It can also be cleared by software by writing '1' to the ADDRCF bit in the I2C_ICR register. If the I2C is already in master mode with AUTOEND = 0, setting this bit generates a Repeated start condition when RELOAD=0, after the end of the NBYTES transfer. Otherwise setting this bit generates a START condition once the bus is free. Note: Writing '0' to this bit has no effect. Note: The START bit can be set even if the bus is BUSY or I2C is in slave mode. Note: This bit has no effect when RELOAD is set.
    $0e constant I2C1_STOP                      \ [0x0e] Stop generation (master mode) The bit is set by software, cleared by hardware when a STOP condition is detected, or when PE = 0. In Master mode: Note: Writing '0' to this bit has no effect.
    $0f constant I2C1_NACK                      \ [0x0f] NACK generation (slave mode) The bit is set by software, cleared by hardware when the NACK is sent, or when a STOP condition or an Address matched is received, or when PE = 0. Note: Writing '0' to this bit has no effect. Note: This bit is used in slave mode only: in master receiver mode, NACK is automatically generated after last byte preceding STOP or RESTART condition, whatever the NACK bit value. Note: When an overrun occurs in slave receiver NOSTRETCH mode, a NACK is automatically generated whatever the NACK bit value. Note: When hardware PEC checking is enabled (PECBYTE=1), the PEC acknowledge value does not depend on the NACK value.
    $10 constant I2C1_NBYTES                    \ [0x10 : 8] Number of bytes The number of bytes to be transmitted/received is programmed there. This field is don't care in slave mode with SBC=0. Note: Changing these bits when the START bit is set is not allowed.
    $18 constant I2C1_RELOAD                    \ [0x18] NBYTES reload mode This bit is set and cleared by software.
    $19 constant I2C1_AUTOEND                   \ [0x19] Automatic end mode (master mode) This bit is set and cleared by software. Note: This bit has no effect in slave mode or when the RELOAD bit is set.
    $1a constant I2C1_PECBYTE                   \ [0x1a] Packet error checking byte This bit is set by software, and cleared by hardware when the PEC is transferred, or when a STOP condition or an Address matched is received, also when PE = 0. Note: Writing '0' to this bit has no effect. Note: This bit has no effect when RELOAD is set. Note: This bit has no effect is slave mode when SBC=0. Note: If the SMBus feature is not supported, this bit is reserved and forced by hardware to '0'. Refer to Section 52.3: I2C implementation.
  [then]


  [ifdef] I2C1_I2C_OAR1_DEF
    \
    \ @brief I2C own address 1 register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant I2C1_OA1                       \ [0x00 : 10] Interface own slave address 7-bit addressing mode: OA1[7:1] contains the 7-bit own slave address. The bits OA1[9], OA1[8] and OA1[0] are don't care. 10-bit addressing mode: OA1[9:0] contains the 10-bit own slave address. Note: These bits can be written only when OA1EN=0.
    $0a constant I2C1_OA1MODE                   \ [0x0a] Own address 1 10-bit mode Note: This bit can be written only when OA1EN=0.
    $0f constant I2C1_OA1EN                     \ [0x0f] Own address 1 enable
  [then]


  [ifdef] I2C1_I2C_OAR2_DEF
    \
    \ @brief I2C own address 2 register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $01 constant I2C1_OA2                       \ [0x01 : 7] Interface address 7-bit addressing mode: 7-bit address Note: These bits can be written only when OA2EN=0.
    $08 constant I2C1_OA2MSK                    \ [0x08 : 3] Own address 2 masks Note: These bits can be written only when OA2EN=0. Note: As soon as OA2MSK is not equal to 0, the reserved I2C addresses (0b0000xxx and 0b1111xxx) are not acknowledged even if the comparison matches.
    $0f constant I2C1_OA2EN                     \ [0x0f] Own address 2 enable
  [then]


  [ifdef] I2C1_I2C_TIMINGR_DEF
    \
    \ @brief I2C timing register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant I2C1_SCLL                      \ [0x00 : 8] SCL low period (master mode) This field is used to generate the SCL low period in master mode. t<sub>SCLL </sub>= (SCLL+1) x t<sub>PRESC</sub> Note: SCLL is also used to generate t<sub>BUF </sub>and t<sub>SU:STA </sub>timings.
    $08 constant I2C1_SCLH                      \ [0x08 : 8] SCL high period (master mode) This field is used to generate the SCL high period in master mode. t<sub>SCLH </sub>= (SCLH+1) x t<sub>PRESC</sub> Note: SCLH is also used to generate t<sub>SU:STO </sub>and t<sub>HD:STA </sub>timing.
    $10 constant I2C1_SDADEL                    \ [0x10 : 4] Data hold time This field is used to generate the delay t<sub>SDADEL </sub>between SCL falling edge and SDA edge. In master mode and in slave mode with NOSTRETCH = 0, the SCL line is stretched low during t<sub>SDADEL</sub>. t<sub>SDADEL</sub>= SDADEL x t<sub>PRESC</sub> Note: SDADEL is used to generate t<sub>HD:DAT </sub>timing.
    $14 constant I2C1_SCLDEL                    \ [0x14 : 4] Data setup time This field is used to generate a delay t<sub>SCLDEL </sub>between SDA edge and SCL rising edge. In master mode and in slave mode with NOSTRETCH = 0, the SCL line is stretched low during t<sub>SCLDEL</sub>. t<sub>SCLDEL </sub>= (SCLDEL+1) x t<sub>PRESC</sub> Note: t<sub>SCLDEL</sub> is used to generate t<sub>SU:DAT </sub>timing.
    $1c constant I2C1_PRESC                     \ [0x1c : 4] Timing prescaler This field is used to prescale i2c_ker_ck in order to generate the clock period t<sub>PRESC </sub>used for data setup and hold counters (refer to I2C timings on page2521) and for SCL high and low level counters (refer to I2C master initialization on page2536). t<sub>PRESC </sub>= (PRESC+1) x t<sub>I2CCLK</sub>
  [then]


  [ifdef] I2C1_I2C_TIMEOUTR_DEF
    \
    \ @brief I2C timeout register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant I2C1_TIMEOUTA                  \ [0x00 : 12] Bus Timeout A This field is used to configure: The SCL low timeout condition t<sub>TIMEOUT</sub> when TIDLE=0 t<sub>TIMEOUT</sub>= (TIMEOUTA+1) x 2048 x t<sub>I2CCLK</sub> The bus idle condition (both SCL and SDA high) when TIDLE=1 t<sub>IDLE</sub>= (TIMEOUTA+1) x 4 x t<sub>I2CCLK</sub> Note: These bits can be written only when TIMOUTEN=0.
    $0c constant I2C1_TIDLE                     \ [0x0c] Idle clock timeout detection Note: This bit can be written only when TIMOUTEN=0.
    $0f constant I2C1_TIMOUTEN                  \ [0x0f] Clock timeout enable
    $10 constant I2C1_TIMEOUTB                  \ [0x10 : 12] Bus timeout B This field is used to configure the cumulative clock extension timeout: In master mode, the master cumulative clock low extend time (t<sub>LOW:MEXT</sub>) is detected In slave mode, the slave cumulative clock low extend time (t<sub>LOW:SEXT</sub>) is detected t<sub>LOW:EXT</sub>= (TIMEOUTB+1) x 2048 x t<sub>I2CCLK</sub> Note: These bits can be written only when TEXTEN=0.
    $1f constant I2C1_TEXTEN                    \ [0x1f] Extended clock timeout enable
  [then]


  [ifdef] I2C1_I2C_ISR_DEF
    \
    \ @brief I2C interrupt and status register
    \ Address offset: 0x18
    \ Reset value: 0x00000001
    \
    $00 constant I2C1_TXE                       \ [0x00] Transmit data register empty (transmitters) This bit is set by hardware when the I2C_TXDR register is empty. It is cleared when the next data to be sent is written in the I2C_TXDR register. This bit can be written to '1' by software in order to flush the transmit data register I2C_TXDR. Note: This bit is set by hardware when PE = 0.
    $01 constant I2C1_TXIS                      \ [0x01] Transmit interrupt status (transmitters) This bit is set by hardware when the I2C_TXDR register is empty and the data to be transmitted must be written in the I2C_TXDR register. It is cleared when the next data to be sent is written in the I2C_TXDR register. This bit can be written to '1' by software when NOSTRETCH = 1 only, in order to generate a TXIS event (interrupt if TXIE=1 or DMA request if TXDMAEN = 1). Note: This bit is cleared by hardware when PE = 0.
    $02 constant I2C1_RXNE                      \ [0x02] Receive data register not empty (receivers) This bit is set by hardware when the received data is copied into the I2C_RXDR register, and is ready to be read. It is cleared when I2C_RXDR is read. Note: This bit is cleared by hardware when PE = 0.
    $03 constant I2C1_ADDR                      \ [0x03] Address matched (slave mode) This bit is set by hardware as soon as the received slave address matched with one of the enabled slave addresses. It is cleared by software by setting ADDRCF bit. Note: This bit is cleared by hardware when PE = 0.
    $04 constant I2C1_NACKF                     \ [0x04] Not Acknowledge received flag This flag is set by hardware when a NACK is received after a byte transmission. It is cleared by software by setting the NACKCF bit. Note: This bit is cleared by hardware when PE = 0.
    $05 constant I2C1_STOPF                     \ [0x05] Stop detection flag This flag is set by hardware when a STOP condition is detected on the bus and the peripheral is involved in this transfer: either as a master, provided that the STOP condition is generated by the peripheral. or as a slave, provided that the peripheral has been addressed previously during this transfer. It is cleared by software by setting the STOPCF bit. Note: This bit is cleared by hardware when PE = 0.
    $06 constant I2C1_TC                        \ [0x06] Transfer Complete (master mode) This flag is set by hardware when RELOAD=0, AUTOEND=0 and NBYTES data have been transferred. It is cleared by software when START bit or STOP bit is set. Note: This bit is cleared by hardware when PE = 0.
    $07 constant I2C1_TCR                       \ [0x07] Transfer Complete Reload This flag is set by hardware when RELOAD=1 and NBYTES data have been transferred. It is cleared by software when NBYTES is written to a non-zero value. Note: This bit is cleared by hardware when PE = 0. Note: This flag is only for master mode, or for slave mode when the SBC bit is set.
    $08 constant I2C1_BERR                      \ [0x08] Bus error This flag is set by hardware when a misplaced Start or STOP condition is detected whereas the peripheral is involved in the transfer. The flag is not set during the address phase in slave mode. It is cleared by software by setting BERRCF bit. Note: This bit is cleared by hardware when PE = 0.
    $09 constant I2C1_ARLO                      \ [0x09] Arbitration lost This flag is set by hardware in case of arbitration loss. It is cleared by software by setting the ARLOCF bit. Note: This bit is cleared by hardware when PE = 0.
    $0a constant I2C1_OVR                       \ [0x0a] Overrun/Underrun (slave mode) This flag is set by hardware in slave mode with NOSTRETCH = 1, when an overrun/underrun error occurs. It is cleared by software by setting the OVRCF bit. Note: This bit is cleared by hardware when PE = 0.
    $0b constant I2C1_PECERR                    \ [0x0b] PEC Error in reception This flag is set by hardware when the received PEC does not match with the PEC register content. A NACK is automatically sent after the wrong PEC reception. It is cleared by software by setting the PECCF bit. Note: This bit is cleared by hardware when PE = 0. Note: If the SMBus feature is not supported, this bit is reserved and forced by hardware to '0'. Refer to Section 52.3: I2C implementation.
    $0c constant I2C1_TIMEOUT                   \ [0x0c] Timeout or t<sub>LOW</sub> detection flag This flag is set by hardware when a timeout or extended clock timeout occurred. It is cleared by software by setting the TIMEOUTCF bit. Note: This bit is cleared by hardware when PE = 0. Note: If the SMBus feature is not supported, this bit is reserved and forced by hardware to '0'. Refer to Section 52.3: I2C implementation.
    $0d constant I2C1_ALERT                     \ [0x0d] SMBus alert This flag is set by hardware when SMBHEN=1 (SMBus host configuration), ALERTEN=1 and a SMBALERT event (falling edge) is detected on SMBA pin. It is cleared by software by setting the ALERTCF bit. Note: This bit is cleared by hardware when PE = 0. Note: If the SMBus feature is not supported, this bit is reserved and forced by hardware to '0'. Refer to Section 52.3: I2C implementation.
    $0f constant I2C1_BUSY                      \ [0x0f] Bus busy This flag indicates that a communication is in progress on the bus. It is set by hardware when a START condition is detected. It is cleared by hardware when a STOP condition is detected, or when PE = 0.
    $10 constant I2C1_DIR                       \ [0x10] Transfer direction (Slave mode) This flag is updated when an address match event occurs (ADDR = 1).
    $11 constant I2C1_ADDCODE                   \ [0x11 : 7] Address match code (Slave mode) These bits are updated with the received address when an address match event occurs (ADDR = 1). In the case of a 10-bit address, ADDCODE provides the 10-bit header followed by the 2 MSBs of the address.
  [then]


  [ifdef] I2C1_I2C_ICR_DEF
    \
    \ @brief I2C interrupt clear register
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $03 constant I2C1_ADDRCF                    \ [0x03] Address matched flag clear Writing 1 to this bit clears the ADDR flag in the I2C_ISR register. Writing 1 to this bit also clears the START bit in the I2C_CR2 register.
    $04 constant I2C1_NACKCF                    \ [0x04] Not Acknowledge flag clear Writing 1 to this bit clears the NACKF flag in I2C_ISR register.
    $05 constant I2C1_STOPCF                    \ [0x05] STOP detection flag clear Writing 1 to this bit clears the STOPF flag in the I2C_ISR register.
    $08 constant I2C1_BERRCF                    \ [0x08] Bus error flag clear Writing 1 to this bit clears the BERRF flag in the I2C_ISR register.
    $09 constant I2C1_ARLOCF                    \ [0x09] Arbitration lost flag clear Writing 1 to this bit clears the ARLO flag in the I2C_ISR register.
    $0a constant I2C1_OVRCF                     \ [0x0a] Overrun/Underrun flag clear Writing 1 to this bit clears the OVR flag in the I2C_ISR register.
    $0b constant I2C1_PECCF                     \ [0x0b] PEC Error flag clear Writing 1 to this bit clears the PECERR flag in the I2C_ISR register. Note: If the SMBus feature is not supported, this bit is reserved and forced by hardware to '0'. Refer to Section 52.3: I2C implementation.
    $0c constant I2C1_TIMOUTCF                  \ [0x0c] Timeout detection flag clear Writing 1 to this bit clears the TIMEOUT flag in the I2C_ISR register. Note: If the SMBus feature is not supported, this bit is reserved and forced by hardware to '0'. Refer to Section 52.3: I2C implementation.
    $0d constant I2C1_ALERTCF                   \ [0x0d] Alert flag clear Writing 1 to this bit clears the ALERT flag in the I2C_ISR register. Note: If the SMBus feature is not supported, this bit is reserved and forced by hardware to '0'. Refer to Section 52.3: I2C implementation.
  [then]


  [ifdef] I2C1_I2C_PECR_DEF
    \
    \ @brief I2C PEC register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant I2C1_PEC                       \ [0x00 : 8] Packet error checking register This field contains the internal PEC when PECEN=1. The PEC is cleared by hardware when PE = 0.
  [then]


  [ifdef] I2C1_I2C_RXDR_DEF
    \
    \ @brief I2C receive data register
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant I2C1_RXDATA                    \ [0x00 : 8] 8-bit receive data Data byte received from the I<sup>2</sup>C bus
  [then]


  [ifdef] I2C1_I2C_TXDR_DEF
    \
    \ @brief I2C transmit data register
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant I2C1_TXDATA                    \ [0x00 : 8] 8-bit transmit data Data byte to be transmitted to the I<sup>2</sup>C bus Note: These bits can be written only when TXE = 1.
  [then]

  \
  \ @brief I2C address block description
  \
  $00 constant I2C1_I2C_CR1             \ I2C control register 1
  $04 constant I2C1_I2C_CR2             \ I2C control register 2
  $08 constant I2C1_I2C_OAR1            \ I2C own address 1 register
  $0C constant I2C1_I2C_OAR2            \ I2C own address 2 register
  $10 constant I2C1_I2C_TIMINGR         \ I2C timing register
  $14 constant I2C1_I2C_TIMEOUTR        \ I2C timeout register
  $18 constant I2C1_I2C_ISR             \ I2C interrupt and status register
  $1C constant I2C1_I2C_ICR             \ I2C interrupt clear register
  $20 constant I2C1_I2C_PECR            \ I2C PEC register
  $24 constant I2C1_I2C_RXDR            \ I2C receive data register
  $28 constant I2C1_I2C_TXDR            \ I2C transmit data register

: I2C1_DEF ; [then]
