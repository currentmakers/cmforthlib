\
\ @file i2c.fs
\ @brief Inter-integrated circuit
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] I2C_DEF

  [ifdef] I2C_I2C_CR1_DEF
    \
    \ @brief Control register 1
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant I2C_PE                         \ [0x00] Peripheral enable Note: When PE=0, the I2C SCL and SDA lines are released. Internal state machines and status bits are put back to their reset value. When cleared, PE must be kept low for at least 3 APB clock cycles.
    $01 constant I2C_TXIE                       \ [0x01] TX Interrupt enable
    $02 constant I2C_RXIE                       \ [0x02] RX Interrupt enable
    $03 constant I2C_ADDRIE                     \ [0x03] Address match Interrupt enable (slave only)
    $04 constant I2C_NACKIE                     \ [0x04] Not acknowledge received Interrupt enable
    $05 constant I2C_STOPIE                     \ [0x05] Stop detection Interrupt enable
    $06 constant I2C_TCIE                       \ [0x06] Transfer Complete interrupt enable Note: Any of these events generate an interrupt: Transfer Complete (TC) Transfer Complete Reload (TCR)
    $07 constant I2C_ERRIE                      \ [0x07] Error interrupts enable Note: Any of these errors generate an interrupt: Arbitration Loss (ARLO) Bus Error detection (BERR) Overrun/Underrun (OVR) Timeout detection (TIMEOUT) PEC error detection (PECERR) Alert pin event detection (ALERT)
    $08 constant I2C_DNF                        \ [0x08 : 4] Digital noise filter These bits are used to configure the digital noise filter on SDA and SCL input. The digital filter, filters spikes with a length of up to DNF[3:0] * tI2CCLK ... Note: If the analog filter is also enabled, the digital filter is added to the analog filter. This filter can only be programmed when the I2C is disabled (PE = 0).
    $0c constant I2C_ANFOFF                     \ [0x0c] Analog noise filter OFF Note: This bit can only be programmed when the I2C is disabled (PE = 0).
    $0e constant I2C_TXDMAEN                    \ [0x0e] DMA transmission requests enable
    $0f constant I2C_RXDMAEN                    \ [0x0f] DMA reception requests enable
    $10 constant I2C_SBC                        \ [0x10] Slave byte control This bit is used to enable hardware byte control in slave mode.
    $11 constant I2C_NOSTRETCH                  \ [0x11] Clock stretching disable This bit is used to disable clock stretching in slave mode. It must be kept cleared in master mode. Note: This bit can only be programmed when the I2C is disabled (PE = 0).
    $12 constant I2C_WUPEN                      \ [0x12] Wakeup from Stop mode enable Note: If the Wakeup from Stop mode feature is not supported, this bit is reserved and forced by hardware to '0'. Refer to . Note: WUPEN can be set only when DNF = '0000'
    $13 constant I2C_GCEN                       \ [0x13] General call enable
    $14 constant I2C_SMBHEN                     \ [0x14] SMBus Host Address enable Note: If the SMBus feature is not supported, this bit is reserved and forced by hardware to '0'. Refer to .
    $15 constant I2C_SMBDEN                     \ [0x15] SMBus Device Default Address enable Note: If the SMBus feature is not supported, this bit is reserved and forced by hardware to '0'. Refer to .
    $16 constant I2C_ALERTEN                    \ [0x16] SMBus alert enable Note: When ALERTEN=0, the SMBA pin can be used as a standard GPIO. If the SMBus feature is not supported, this bit is reserved and forced by hardware to '0'. Refer to .
    $17 constant I2C_PECEN                      \ [0x17] PEC enable Note: If the SMBus feature is not supported, this bit is reserved and forced by hardware to '0'. Refer to .
  [then]


  [ifdef] I2C_I2C_CR2_DEF
    \
    \ @brief Control register 2
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant I2C_SADD                       \ [0x00 : 10] Slave address (master mode) In 7-bit addressing mode (ADD10 = 0): SADD[7:1] should be written with the 7-bit slave address to be sent. The bits SADD[9], SADD[8] and SADD[0] are don't care. In 10-bit addressing mode (ADD10 = 1): SADD[9:0] should be written with the 10-bit slave address to be sent. Note: Changing these bits when the START bit is set is not allowed.
    $0a constant I2C_RD_WRN                     \ [0x0a] Transfer direction (master mode) Note: Changing this bit when the START bit is set is not allowed.
    $0b constant I2C_ADD10                      \ [0x0b] 10-bit addressing mode (master mode) Note: Changing this bit when the START bit is set is not allowed.
    $0c constant I2C_HEAD10R                    \ [0x0c] 10-bit address header only read direction (master receiver mode) Note: Changing this bit when the START bit is set is not allowed.
    $0d constant I2C_START                      \ [0x0d] Start generation This bit is set by software, and cleared by hardware after the Start followed by the address sequence is sent, by an arbitration loss, by a timeout error detection, or when PE = 0. It can also be cleared by software by writing '1' to the ADDRCF bit in the I2C_ICR register. If the I2C is already in master mode with AUTOEND = 0, setting this bit generates a Repeated Start condition when RELOAD=0, after the end of the NBYTES transfer. Otherwise setting this bit generates a START condition once the bus is free. Note: Writing '0' to this bit has no effect. The START bit can be set even if the bus is BUSY or I2C is in slave mode. This bit has no effect when RELOAD is set.
    $0e constant I2C_STOP                       \ [0x0e] Stop generation (master mode) The bit is set by software, cleared by hardware when a STOP condition is detected, or when PE = 0. In Master Mode: Note: Writing '0' to this bit has no effect.
    $0f constant I2C_NACK                       \ [0x0f] NACK generation (slave mode) The bit is set by software, cleared by hardware when the NACK is sent, or when a STOP condition or an Address matched is received, or when PE=0. Note: Writing '0' to this bit has no effect. This bit is used in slave mode only: in master receiver mode, NACK is automatically generated after last byte preceding STOP or RESTART condition, whatever the NACK bit value. When an overrun occurs in slave receiver NOSTRETCH mode, a NACK is automatically generated whatever the NACK bit value. When hardware PEC checking is enabled (PECBYTE=1), the PEC acknowledge value does not depend on the NACK value.
    $10 constant I2C_NBYTES                     \ [0x10 : 8] Number of bytes The number of bytes to be transmitted/received is programmed there. This field is don't care in slave mode with SBC=0. Note: Changing these bits when the START bit is set is not allowed.
    $18 constant I2C_RELOAD                     \ [0x18] NBYTES reload mode This bit is set and cleared by software.
    $19 constant I2C_AUTOEND                    \ [0x19] Automatic end mode (master mode) This bit is set and cleared by software. Note: This bit has no effect in slave mode or when the RELOAD bit is set.
    $1a constant I2C_PECBYTE                    \ [0x1a] Packet error checking byte This bit is set by software, and cleared by hardware when the PEC is transferred, or when a STOP condition or an Address matched is received, also when PE=0. Note: Writing '0' to this bit has no effect. This bit has no effect when RELOAD is set. This bit has no effect is slave mode when SBC=0. If the SMBus feature is not supported, this bit is reserved and forced by hardware to '0'. Refer to .
  [then]


  [ifdef] I2C_I2C_OAR1_DEF
    \
    \ @brief Own address register 1
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant I2C_OA1                        \ [0x00 : 10] Interface own slave address 7-bit addressing mode: OA1[7:1] contains the 7-bit own slave address. The bits OA1[9], OA1[8] and OA1[0] are don't care. 10-bit addressing mode: OA1[9:0] contains the 10-bit own slave address. Note: These bits can be written only when OA1EN=0.
    $0a constant I2C_OA1MODE                    \ [0x0a] Own Address 1 10-bit mode Note: This bit can be written only when OA1EN=0.
    $0f constant I2C_OA1EN                      \ [0x0f] Own Address 1 enable
  [then]


  [ifdef] I2C_I2C_OAR2_DEF
    \
    \ @brief Own address register 2
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $01 constant I2C_OA2                        \ [0x01 : 7] Interface address 7-bit addressing mode: 7-bit address Note: These bits can be written only when OA2EN=0.
    $08 constant I2C_OA2MSK                     \ [0x08 : 3] Own Address 2 masks Note: These bits can be written only when OA2EN=0. As soon as OA2MSK is not equal to 0, the reserved I2C addresses (0b0000xxx and 0b1111xxx) are not acknowledged even if the comparison matches.
    $0f constant I2C_OA2EN                      \ [0x0f] Own Address 2 enable
  [then]


  [ifdef] I2C_I2C_TIMINGR_DEF
    \
    \ @brief Timing register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant I2C_SCLL                       \ [0x00 : 8] SCL low period (master mode)
    $08 constant I2C_SCLH                       \ [0x08 : 8] SCL high period (master mode)
    $10 constant I2C_SDADEL                     \ [0x10 : 4] Data hold time
    $14 constant I2C_SCLDEL                     \ [0x14 : 4] Data setup time
    $1c constant I2C_PRESC                      \ [0x1c : 4] Timing prescaler
  [then]


  [ifdef] I2C_I2C_TIMEOUTR_DEF
    \
    \ @brief Status register 1
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant I2C_TIMEOUTA                   \ [0x00 : 12] Bus Timeout A This field is used to configure: The SCL low timeout condition tTIMEOUT when TIDLE=0 tTIMEOUT= (TIMEOUTA+1) x 2048 x tI2CCLK The bus idle condition (both SCL and SDA high) when TIDLE=1 tIDLE= (TIMEOUTA+1) x 4 x tI2CCLK Note: These bits can be written only when TIMOUTEN=0.
    $0c constant I2C_TIDLE                      \ [0x0c] Idle clock timeout detection Note: This bit can be written only when TIMOUTEN=0.
    $0f constant I2C_TIMOUTEN                   \ [0x0f] Clock timeout enable
    $10 constant I2C_TIMEOUTB                   \ [0x10 : 12] Bus timeout B This field is used to configure the cumulative clock extension timeout: In master mode, the master cumulative clock low extend time (tLOW:MEXT) is detected In slave mode, the slave cumulative clock low extend time (tLOW:SEXT) is detected tLOW:EXT= (TIMEOUTB+1) x 2048 x tI2CCLK Note: These bits can be written only when TEXTEN=0.
    $1f constant I2C_TEXTEN                     \ [0x1f] Extended clock timeout enable
  [then]


  [ifdef] I2C_I2C_ISR_DEF
    \
    \ @brief Interrupt and Status register
    \ Address offset: 0x18
    \ Reset value: 0x00000001
    \
    $00 constant I2C_TXE                        \ [0x00] Transmit data register empty (transmitters)
    $01 constant I2C_TXIS                       \ [0x01] Transmit interrupt status (transmitters)
    $02 constant I2C_RXNE                       \ [0x02] Receive data register not empty (receivers)
    $03 constant I2C_ADDR                       \ [0x03] Address matched (slave mode)
    $04 constant I2C_NACKF                      \ [0x04] Not acknowledge received flag
    $05 constant I2C_STOPF                      \ [0x05] Stop detection flag
    $06 constant I2C_TC                         \ [0x06] Transfer Complete (master mode)
    $07 constant I2C_TCR                        \ [0x07] Transfer Complete Reload
    $08 constant I2C_BERR                       \ [0x08] Bus error
    $09 constant I2C_ARLO                       \ [0x09] Arbitration lost
    $0a constant I2C_OVR                        \ [0x0a] Overrun/Underrun (slave mode)
    $0b constant I2C_PECERR                     \ [0x0b] PEC Error in reception
    $0c constant I2C_TIMEOUT                    \ [0x0c] Timeout or t_low detection flag
    $0d constant I2C_ALERT                      \ [0x0d] SMBus alert
    $0f constant I2C_BUSY                       \ [0x0f] Bus busy
    $10 constant I2C_DIR                        \ [0x10] Transfer direction (Slave mode) This flag is updated when an address match event occurs (ADDR=1).
    $11 constant I2C_ADDCODE                    \ [0x11 : 7] Address match code (Slave mode)
  [then]


  [ifdef] I2C_I2C_ICR_DEF
    \
    \ @brief Interrupt clear register
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $03 constant I2C_ADDRCF                     \ [0x03] Address Matched flag clear
    $04 constant I2C_NACKCF                     \ [0x04] Not Acknowledge flag clear
    $05 constant I2C_STOPCF                     \ [0x05] Stop detection flag clear
    $08 constant I2C_BERRCF                     \ [0x08] Bus error flag clear
    $09 constant I2C_ARLOCF                     \ [0x09] Arbitration lost flag clear
    $0a constant I2C_OVRCF                      \ [0x0a] Overrun/Underrun flag clear
    $0b constant I2C_PECCF                      \ [0x0b] PEC Error flag clear
    $0c constant I2C_TIMOUTCF                   \ [0x0c] Timeout detection flag clear
    $0d constant I2C_ALERTCF                    \ [0x0d] Alert flag clear
  [then]


  [ifdef] I2C_I2C_PECR_DEF
    \
    \ @brief PEC register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant I2C_PEC                        \ [0x00 : 8] Packet error checking register
  [then]


  [ifdef] I2C_I2C_RXDR_DEF
    \
    \ @brief Receive data register
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant I2C_RXDATA                     \ [0x00 : 8] 8-bit receive data
  [then]


  [ifdef] I2C_I2C_TXDR_DEF
    \
    \ @brief Transmit data register
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant I2C_TXDATA                     \ [0x00 : 8] 8-bit transmit data
  [then]

  \
  \ @brief Inter-integrated circuit
  \
  $00 constant I2C_I2C_CR1              \ Control register 1
  $04 constant I2C_I2C_CR2              \ Control register 2
  $08 constant I2C_I2C_OAR1             \ Own address register 1
  $0C constant I2C_I2C_OAR2             \ Own address register 2
  $10 constant I2C_I2C_TIMINGR          \ Timing register
  $14 constant I2C_I2C_TIMEOUTR         \ Status register 1
  $18 constant I2C_I2C_ISR              \ Interrupt and Status register
  $1C constant I2C_I2C_ICR              \ Interrupt clear register
  $20 constant I2C_I2C_PECR             \ PEC register
  $24 constant I2C_I2C_RXDR             \ Receive data register
  $28 constant I2C_I2C_TXDR             \ Transmit data register

: I2C_DEF ; [then]
