\
\ @file lpuart.fs
\ @brief LPUART address block description
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] LPUART_DEF

  [ifdef] LPUART_LPUART_CR1_DEF
    \
    \ @brief LPUART control register 1
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant LPUART_UE                      \ [0x00] LPUART enable When this bit is cleared, the LPUART prescalers and outputs are stopped immediately, and current operations are discarded. The configuration of the LPUART is kept, but all the status flags, in the LPUART_ISR are reset. This bit is set and cleared by software. Note: To enter low-power mode without generating errors on the line, the TE bit must be reset before and the software must wait for the TC bit in the LPUART_ISR to be set before resetting the UE bit. Note: The DMA requests are also reset when UE = 0 so the DMA channel must be disabled before resetting the UE bit.
    $01 constant LPUART_UESM                    \ [0x01] LPUART enable in low-power mode When this bit is cleared, the LPUART cannot wake up the MCU from low-power mode. When this bit is set, the LPUART can wake up the MCU from low-power mode. This bit is set and cleared by software. Note: It is recommended to set the UESM bit just before entering low-power mode, and clear it when exiting low-power mode.
    $02 constant LPUART_RE                      \ [0x02] Receiver enable This bit enables the receiver. It is set and cleared by software.
    $03 constant LPUART_TE                      \ [0x03] Transmitter enable This bit enables the transmitter. It is set and cleared by software. Note: During transmission, a low pulse on the TE bit (0 followed by 1) sends a preamble (idle line) after the current word, except in Smartcard mode. In order to generate an idle character, the TE must not be immediately written to 1. To ensure the required duration, the software can poll the TEACK bit in the LPUART_ISR register. Note: In Smartcard mode, when TE is set, there is a 1 bit-time delay before the transmission starts.
    $04 constant LPUART_IDLEIE                  \ [0x04] IDLE interrupt enable This bit is set and cleared by software.
    $05 constant LPUART_RXFNEIE                 \ [0x05] RXFIFO not empty interrupt enable This bit is set and cleared by software.
    $06 constant LPUART_TCIE                    \ [0x06] Transmission complete interrupt enable This bit is set and cleared by software.
    $07 constant LPUART_TXFNFIE                 \ [0x07] TXFIFO not full interrupt enable This bit is set and cleared by software.
    $08 constant LPUART_PEIE                    \ [0x08] PE interrupt enable This bit is set and cleared by software.
    $09 constant LPUART_PS                      \ [0x09] Parity selection This bit selects the odd or even parity when the parity generation/detection is enabled (PCE bit set). It is set and cleared by software. The parity is selected after the current byte. This bitfield can only be written when the LPUART is disabled (UE=0).
    $0a constant LPUART_PCE                     \ [0x0a] Parity control enable This bit selects the hardware parity control (generation and detection). When the parity control is enabled, the computed parity is inserted at the MSB position (9th bit if M=1; 8th bit if M=0) and parity is checked on the received data. This bit is set and cleared by software. Once it is set, PCE is active after the current byte (in reception and in transmission). This bitfield can only be written when the LPUART is disabled (UE=0).
    $0b constant LPUART_WAKE                    \ [0x0b] Receiver wake-up method This bit determines the LPUART wake-up method from Mute mode. It is set or cleared by software. This bitfield can only be written when the LPUART is disabled (UE=0).
    $0c constant LPUART_M0                      \ [0x0c] Word length This bit is used in conjunction with bit 28 (M1) to determine the word length. It is set or cleared by software (refer to bit 28 (M1) description). This bit can only be written when the LPUART is disabled (UE=0).
    $0d constant LPUART_MME                     \ [0x0d] Mute mode enable This bit activates the Mute mode function of the LPUART. When set, the LPUART can switch between the active and Mute modes, as defined by the WAKE bit. It is set and cleared by software.
    $0e constant LPUART_CMIE                    \ [0x0e] Character match interrupt enable This bit is set and cleared by software.
    $10 constant LPUART_DEDT                    \ [0x10 : 5] Driver Enable deassertion time This 5-bit value defines the time between the end of the last stop bit, in a transmitted message, and the de-activation of the DE (Driver Enable) signal.It is expressed in lpuart_ker_ck clock cycles. For more details, refer Section132.4.14: RS232 Hardware flow control and RS485 Driver Enable. If the LPUART_TDR register is written during the DEDT time, the new data is transmitted only when the DEDT and DEAT times have both elapsed. This bitfield can only be written when the LPUART is disabled (UE=0).
    $15 constant LPUART_DEAT                    \ [0x15 : 5] Driver Enable assertion time This 5-bit value defines the time between the activation of the DE (Driver Enable) signal and the beginning of the start bit. It is expressed in lpuart_ker_ck clock cycles. For more details, refer Section131.5.21: RS232 Hardware flow control and RS485 Driver Enable. This bitfield can only be written when the LPUART is disabled (UE=0).
    $1c constant LPUART_M1                      \ [0x1c] Word length This bit must be used in conjunction with bit 12 (M0) to determine the word length. It is set or cleared by software. M[1:0] = 00: 1 Start bit, 8 Data bits, n Stop bit M[1:0] = 01: 1 Start bit, 9 Data bits, n Stop bit M[1:0] = 10: 1 Start bit, 7 Data bits, n Stop bit This bit can only be written when the LPUART is disabled (UE=0). Note: In 7-bit data length mode, the Smartcard mode, LIN master mode and auto baud rate (0x7F and 0x55 frames detection) are not supported.
    $1d constant LPUART_FIFOEN                  \ [0x1d] FIFO mode enable This bit is set and cleared by software.
    $1e constant LPUART_TXFEIE                  \ [0x1e] TXFIFO empty interrupt enable This bit is set and cleared by software.
    $1f constant LPUART_RXFFIE                  \ [0x1f] RXFIFO Full interrupt enable This bit is set and cleared by software.
  [then]


  [ifdef] LPUART_LPUART_CR1_ALTERNATE_DEF
    \
    \ @brief LPUART control register 1
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant LPUART_UE                      \ [0x00] LPUART enable When this bit is cleared, the LPUART prescalers and outputs are stopped immediately, and current operations are discarded. The configuration of the LPUART is kept, but all the status flags, in the LPUART_ISR are reset. This bit is set and cleared by software. Note: To enter low-power mode without generating errors on the line, the TE bit must be reset before and the software must wait for the TC bit in the LPUART_ISR to be set before resetting the UE bit. Note: The DMA requests are also reset when UE = 0 so the DMA channel must be disabled before resetting the UE bit.
    $01 constant LPUART_UESM                    \ [0x01] LPUART enable in low-power mode When this bit is cleared, the LPUART cannot wake up the MCU from low-power mode. When this bit is set, the LPUART can wake up the MCU from low-power mode. This bit is set and cleared by software. Note: It is recommended to set the UESM bit just before entering low-power mode, and clear it when exiting low-power mode.
    $02 constant LPUART_RE                      \ [0x02] Receiver enable This bit enables the receiver. It is set and cleared by software.
    $03 constant LPUART_TE                      \ [0x03] Transmitter enable This bit enables the transmitter. It is set and cleared by software. Note: During transmission, a low pulse on the TE bit (0 followed by 1) sends a preamble (idle line) after the current word, except in Smartcard mode. In order to generate an idle character, the TE must not be immediately written to 1. To ensure the required duration, the software can poll the TEACK bit in the LPUART_ISR register. Note: In Smartcard mode, when TE is set, there is a 1 bit-time delay before the transmission starts.
    $04 constant LPUART_IDLEIE                  \ [0x04] IDLE interrupt enable This bit is set and cleared by software.
    $05 constant LPUART_RXNEIE                  \ [0x05] Receive data register not empty This bit is set and cleared by software.
    $06 constant LPUART_TCIE                    \ [0x06] Transmission complete interrupt enable This bit is set and cleared by software.
    $07 constant LPUART_TXEIE                   \ [0x07] Transmit data register empty This bit is set and cleared by software.
    $08 constant LPUART_PEIE                    \ [0x08] PE interrupt enable This bit is set and cleared by software.
    $09 constant LPUART_PS                      \ [0x09] Parity selection This bit selects the odd or even parity when the parity generation/detection is enabled (PCE bit set). It is set and cleared by software. The parity is selected after the current byte. This bitfield can only be written when the LPUART is disabled (UE=0).
    $0a constant LPUART_PCE                     \ [0x0a] Parity control enable This bit selects the hardware parity control (generation and detection). When the parity control is enabled, the computed parity is inserted at the MSB position (9th bit if M=1; 8th bit if M=0) and parity is checked on the received data. This bit is set and cleared by software. Once it is set, PCE is active after the current byte (in reception and in transmission). This bitfield can only be written when the LPUART is disabled (UE=0).
    $0b constant LPUART_WAKE                    \ [0x0b] Receiver wake-up method This bit determines the LPUART wake-up method from Mute mode. It is set or cleared by software. This bitfield can only be written when the LPUART is disabled (UE=0).
    $0c constant LPUART_M0                      \ [0x0c] Word length This bit is used in conjunction with bit 28 (M1) to determine the word length. It is set or cleared by software (refer to bit 28 (M1) description). This bit can only be written when the LPUART is disabled (UE=0).
    $0d constant LPUART_MME                     \ [0x0d] Mute mode enable This bit activates the Mute mode function of the LPUART. When set, the LPUART can switch between the active and Mute modes, as defined by the WAKE bit. It is set and cleared by software.
    $0e constant LPUART_CMIE                    \ [0x0e] Character match interrupt enable This bit is set and cleared by software.
    $10 constant LPUART_DEDT                    \ [0x10 : 5] Driver Enable deassertion time This 5-bit value defines the time between the end of the last stop bit, in a transmitted message, and the de-activation of the DE (Driver Enable) signal.It is expressed in lpuart_ker_ck clock cycles. For more details, refer Section132.4.14: RS232 Hardware flow control and RS485 Driver Enable. If the LPUART_TDR register is written during the DEDT time, the new data is transmitted only when the DEDT and DEAT times have both elapsed. This bitfield can only be written when the LPUART is disabled (UE=0).
    $15 constant LPUART_DEAT                    \ [0x15 : 5] Driver Enable assertion time This 5-bit value defines the time between the activation of the DE (Driver Enable) signal and the beginning of the start bit. It is expressed in lpuart_ker_ck clock cycles. For more details, refer Section131.5.21: RS232 Hardware flow control and RS485 Driver Enable. This bitfield can only be written when the LPUART is disabled (UE=0).
    $1c constant LPUART_M1                      \ [0x1c] Word length This bit must be used in conjunction with bit 12 (M0) to determine the word length. It is set or cleared by software. M[1:0] = 00: 1 Start bit, 8 Data bits, n Stop bit M[1:0] = 01: 1 Start bit, 9 Data bits, n Stop bit M[1:0] = 10: 1 Start bit, 7 Data bits, n Stop bit This bit can only be written when the LPUART is disabled (UE=0). Note: In 7-bit data length mode, the Smartcard mode, LIN master mode and auto baud rate (0x7F and 0x55 frames detection) are not supported.
    $1d constant LPUART_FIFOEN                  \ [0x1d] FIFO mode enable This bit is set and cleared by software.
  [then]


  [ifdef] LPUART_LPUART_CR2_DEF
    \
    \ @brief LPUART control register 2
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $04 constant LPUART_ADDM7                   \ [0x04] 7-bit Address Detection/4-bit Address Detection This bit is for selection between 4-bit address detection or 7-bit address detection. This bit can only be written when the LPUART is disabled (UE=0) Note: In 7-bit and 9-bit data modes, the address detection is done on 6-bit and 8-bit address (ADD[5:0] and ADD[7:0]) respectively.
    $0c constant LPUART_STOP                    \ [0x0c : 2] STOP bits These bits are used for programming the stop bits. This bitfield can only be written when the LPUART is disabled (UE=0).
    $0f constant LPUART_SWAP                    \ [0x0f] Swap TX/RX pins This bit is set and cleared by software. This bitfield can only be written when the LPUART is disabled (UE=0).
    $10 constant LPUART_RXINV                   \ [0x10] RX pin active level inversion This bit is set and cleared by software. This enables the use of an external inverter on the RX line. This bitfield can only be written when the LPUART is disabled (UE=0).
    $11 constant LPUART_TXINV                   \ [0x11] TX pin active level inversion This bit is set and cleared by software. This enables the use of an external inverter on the TX line. This bitfield can only be written when the LPUART is disabled (UE=0).
    $12 constant LPUART_DATAINV                 \ [0x12] Binary data inversion This bit is set and cleared by software. This bitfield can only be written when the LPUART is disabled (UE=0).
    $13 constant LPUART_MSBFIRST                \ [0x13] Most significant bit first This bit is set and cleared by software. This bitfield can only be written when the LPUART is disabled (UE=0).
    $18 constant LPUART_ADD                     \ [0x18 : 8] Address of the LPUART node These bits give the address of the LPUART node in Mute mode or a character code to be recognized in low-power or Run mode: In Mute mode: they are used in multiprocessor communication to wake up from Mute mode with 4-bit/7-bit address mark detection. The MSB of the character sent by the transmitter should be equal to 1. In 4-bit address mark detection, only ADD[3:0] bits are used. In low-power mode: they are used for wake up from low-power mode on character match. When WUS[1:0] is programmed to 0b00 (WUF active on address match), the wake-up from low-power mode is performed when the received character corresponds to the character programmed through ADD[6:0] or ADD[3:0] bitfield (depending on ADDM7 bit), and WUF interrupt is enabled by setting WUFIE bit. The MSB of the character sent by transmitter should be equal to 1. In Run mode with Mute mode inactive (for example, end-of-block detection in ModBus protocol): the whole received character (8 bits) is compared to ADD[7:0] value and CMF flag is set on match. An interrupt is generated if the CMIE bit is set. These bits can only be written when the reception is disabled (RE1=10) or when the USART is disabled (UE1=10).
  [then]


  [ifdef] LPUART_LPUART_CR3_DEF
    \
    \ @brief LPUART control register 3
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant LPUART_EIE                     \ [0x00] Error interrupt enable Error Interrupt Enable Bit is required to enable interrupt generation in case of a framing error, overrun error or noise flag (FE=1 or ORE=1 or NE=1 in the LPUART_ISR register).
    $03 constant LPUART_HDSEL                   \ [0x03] Half-duplex selection Selection of Single-wire Half-duplex mode This bit can only be written when the LPUART is disabled (UE=0).
    $06 constant LPUART_DMAR                    \ [0x06] DMA enable receiver This bit is set/reset by software
    $07 constant LPUART_DMAT                    \ [0x07] DMA enable transmitter This bit is set/reset by software
    $08 constant LPUART_RTSE                    \ [0x08] RTS enable This bit can only be written when the LPUART is disabled (UE=0).
    $09 constant LPUART_CTSE                    \ [0x09] CTS enable This bit can only be written when the LPUART is disabled (UE=0)
    $0a constant LPUART_CTSIE                   \ [0x0a] CTS interrupt enable
    $0c constant LPUART_OVRDIS                  \ [0x0c] Overrun Disable This bit is used to disable the receive overrun detection. the ORE flag is not set and the new received data overwrites the previous content of the LPUART_RDR register. This bit can only be written when the LPUART is disabled (UE=0). Note: This control bit enables checking the communication flow w/o reading the data.
    $0d constant LPUART_DDRE                    \ [0x0d] DMA Disable on Reception Error This bit can only be written when the LPUART is disabled (UE=0). Note: The reception errors are: parity error, framing error or noise error.
    $0e constant LPUART_DEM                     \ [0x0e] Driver enable mode This bit enables the user to activate the external transceiver control, through the DE signal. This bit can only be written when the LPUART is disabled (UE=0).
    $0f constant LPUART_DEP                     \ [0x0f] Driver enable polarity selection This bit can only be written when the LPUART is disabled (UE=0).
    $14 constant LPUART_WUS0                    \ [0x14] Wake-up from low-power mode interrupt flag selection This bitfield specifies the event which activates the WUF (Wake-up from low-power mode flag). This bitfield can only be written when the LPUART is disabled (UE=0). Note: If the USART does not support the wake-up from Stop feature, this bit is reserved and must be kept at reset value. Refer to Section132.3: LPUART implementation on page1914.
    $15 constant LPUART_WUS1                    \ [0x15] Wake-up from low-power mode interrupt flag selection This bitfield specifies the event which activates the WUF (Wake-up from low-power mode flag). This bitfield can only be written when the LPUART is disabled (UE=0). Note: If the USART does not support the wake-up from Stop feature, this bit is reserved and must be kept at reset value. Refer to Section132.3: LPUART implementation on page1914.
    $16 constant LPUART_WUFIE                   \ [0x16] Wake-up from low-power mode interrupt enable This bit is set and cleared by software. Note: WUFIE must be set before entering in low-power mode. Note: If the USART does not support the wake-up from Stop feature, this bit is reserved and must be kept at reset value. Refer to Section132.3: LPUART implementation on page1914.
    $17 constant LPUART_TXFTIE                  \ [0x17] TXFIFO threshold interrupt enable This bit is set and cleared by software.
    $19 constant LPUART_RXFTCFG                 \ [0x19 : 3] Receive FIFO threshold configuration Remaining combinations: Reserved.
    $1c constant LPUART_RXFTIE                  \ [0x1c] RXFIFO threshold interrupt enable This bit is set and cleared by software.
    $1d constant LPUART_TXFTCFG                 \ [0x1d : 3] TXFIFO threshold configuration Remaining combinations: Reserved.
  [then]


  [ifdef] LPUART_LPUART_BRR_DEF
    \
    \ @brief LPUART baud rate register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant LPUART_BRR                     \ [0x00 : 20] LPUART baud rate division (LPUARTDIV)
  [then]


  [ifdef] LPUART_LPUART_RQR_DEF
    \
    \ @brief LPUART request register
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $01 constant LPUART_SBKRQ                   \ [0x01] Send break request Writing 1 to this bit sets the SBKF flag and request to send a BREAK on the line, as soon as the transmit machine is available. Note: If the application needs to send the break character following all previously inserted data, including the ones not yet transmitted, the software must wait for the TXE flag assertion before setting the SBKRQ bit.
    $02 constant LPUART_MMRQ                    \ [0x02] Mute mode request Writing 1 to this bit puts the LPUART in Mute mode and resets the RWU flag.
    $03 constant LPUART_RXFRQ                   \ [0x03] Receive data flush request Writing 1 to this bit clears the RXNE flag. This enables discarding the received data without reading it, and avoid an overrun condition.
    $04 constant LPUART_TXFRQ                   \ [0x04] Transmit data flush request This bit is used when FIFO mode is enabled. TXFRQ bit is set to flush the whole FIFO. This sets the flag TXFE (TXFIFO empty, bit 23 in the LPUART_ISR register). Note: In FIFO mode, the TXFNF flag is reset during the flush request until TxFIFO is empty in order to ensure that no data are written in the data register.
  [then]


  [ifdef] LPUART_LPUART_ISR_DEF
    \
    \ @brief LPUART interrupt and status register
    \ Address offset: 0x1C
    \ Reset value: 0x008000C0
    \
    $00 constant LPUART_PE                      \ [0x00] Parity error This bit is set by hardware when a parity error occurs in Reception mode. It is cleared by software, writing 1 to the PECF in the LPUART_ICR register. An interrupt is generated if PEIE = 1 in the LPUART_CR1 register. Note: This error is associated with the character in the LPUART_RDR.
    $01 constant LPUART_FE                      \ [0x01] Framing error This bit is set by hardware when a de-synchronization, excessive noise or a break character is detected. It is cleared by software, writing 1 to the FECF bit in the LPUART_ICR register. When transmitting data in Smartcard mode, this bit is set when the maximum number of transmit attempts is reached without success (the card NACKs the data frame). An interrupt is generated if EIE1=11 in the LPUART_CR3 register. Note: This error is associated with the character in the LPUART_RDR.
    $02 constant LPUART_NE                      \ [0x02] Start bit noise detection flag This bit is set by hardware when noise is detected on the start bit of a received frame. It is cleared by software, writing 1 to the NFCF bit in the LPUART_ICR register. Note: This bit does not generate an interrupt as it appears at the same time as the RXFNE bit which itself generates an interrupt. An interrupt is generated when the NE flag is set during multi buffer communication if the EIE bit is set. Note: This error is associated with the character in the LPUART_RDR.
    $03 constant LPUART_ORE                     \ [0x03] Overrun error This bit is set by hardware when the data currently being received in the shift register is ready to be transferred into the LPUART_RDR register while RXFF = 1. It is cleared by a software, writing 1 to the ORECF, in the LPUART_ICR register. An interrupt is generated if RXFNEIE=1 in the LPUART_CR1 register, or EIE = 1 in the LPUART_CR3 register. Note: When this bit is set, the LPUART_RDR register content is not lost but the shift register is overwritten. An interrupt is generated if the ORE flag is set during multi buffer communication if the EIE bit is set. Note: This bit is permanently forced to 0 (no overrun detection) when the bit OVRDIS is set in the LPUART_CR3 register.
    $04 constant LPUART_IDLE                    \ [0x04] Idle line detected This bit is set by hardware when an Idle line is detected. An interrupt is generated if IDLEIE=1 in the LPUART_CR1 register. It is cleared by software, writing 1 to the IDLECF in the LPUART_ICR register. Note: The IDLE bit is not set again until the RXFNE bit has been set (i.e. a new idle line occurs). Note: If Mute mode is enabled (MME=1), IDLE is set if the LPUART is not mute (RWU=0), whatever the Mute mode selected by the WAKE bit. If RWU=1, IDLE is not set.
    $05 constant LPUART_RXFNE                   \ [0x05] RXFIFO not empty RXFNE bit is set by hardware when the RXFIFO is not empty, and so data can be read from the LPUART_RDR register. Every read of the LPUART_RDR frees a location in the RXFIFO. It is cleared when the RXFIFO is empty. The RXFNE flag can also be cleared by writing 1 to the RXFRQ in the LPUART_RQR register. An interrupt is generated if RXFNEIE=1 in the LPUART_CR1 register.
    $06 constant LPUART_TC                      \ [0x06] Transmission complete This bit indicates that the last data written in the LPUART_TDR has been transmitted out of the shift register. The TC flag behaves as follows: When TDN = 0, the TC flag is set when the transmission of a frame containing data is complete and when TXFE is set. When TDN is equal to the number of data in the TXFIFO, the TC flag is set when TXFIFO is empty and TDN is reached. When TDN is greater than the number of data in the TXFIFO, TC remains cleared until the TXFIFO is filled again to reach the programmed number of data to be transferred. When TDN is less than the number of data in the TXFIFO, TC is set when TDN is reached even if the TXFIFO is not empty. An interrupt is generated if TCIE=1 in the LPUART_CR1 register. TC bit is cleared by software by writing 1 to the TCCF in the LPUART_ICR register or by writing to the LPUART_TDR register.
    $07 constant LPUART_TXFNF                   \ [0x07] TXFIFO not full TXFNF is set by hardware when TXFIFO is not full, and so data can be written in the LPUART_TDR. Every write in the LPUART_TDR places the data in the TXFIFO. This flag remains set until the TXFIFO is full. When the TXFIFO is full, this flag is cleared indicating that data can not be written into the LPUART_TDR. The TXFNF is kept reset during the flush request until TXFIFO is empty. After sending the flush request (by setting TXFRQ bit), the flag TXFNF must be checked prior to writing in TXFIFO (TXFNF and TXFE are set at the same time). An interrupt is generated if the TXFNFIE bit =1 in the LPUART_CR1 register. Note: This bit is used during single buffer transmission.
    $09 constant LPUART_CTSIF                   \ [0x09] CTS interrupt flag This bit is set by hardware when the CTS input toggles, if the CTSE bit is set. It is cleared by software, by writing 1 to the CTSCF bit in the LPUART_ICR register. An interrupt is generated if CTSIE=1 in the LPUART_CR3 register. Note: If the hardware flow control feature is not supported, this bit is reserved and kept at reset value.
    $0a constant LPUART_CTS                     \ [0x0a] CTS flag This bit is set/reset by hardware. It is an inverted copy of the status of the CTS input pin. Note: If the hardware flow control feature is not supported, this bit is reserved and kept at reset value.
    $10 constant LPUART_BUSY                    \ [0x10] Busy flag This bit is set and reset by hardware. It is active when a communication is ongoing on the RX line (successful start bit detected). It is reset at the end of the reception (successful or not).
    $11 constant LPUART_CMF                     \ [0x11] Character match flag This bit is set by hardware, when a the character defined by ADD[7:0] is received. It is cleared by software, writing 1 to the CMCF in the LPUART_ICR register. An interrupt is generated if CMIE=1in the LPUART_CR1 register.
    $12 constant LPUART_SBKF                    \ [0x12] Send break flag This bit indicates that a send break character was requested. It is set by software, by writing 1 to the SBKRQ bit in the LPUART_CR3 register. It is automatically reset by hardware during the stop bit of break transmission.
    $13 constant LPUART_RWU                     \ [0x13] Receiver wake-up from Mute mode This bit indicates if the LPUART is in Mute mode. It is cleared/set by hardware when a wake-up/mute sequence is recognized. The Mute mode control sequence (address or IDLE) is selected by the WAKE bit in the LPUART_CR1 register. When wake-up on IDLE mode is selected, this bit can only be set by software, writing 1 to the MMRQ bit in the LPUART_RQR register. Note: If the LPUART does not support the wake-up from Stop feature, this bit is reserved and kept at reset value.
    $14 constant LPUART_WUF                     \ [0x14] Wake-up from low-power mode flag This bit is set by hardware, when a wake-up event is detected. The event is defined by the WUS bitfield. It is cleared by software, writing a 1 to the WUCF in the LPUART_ICR register. An interrupt is generated if WUFIE=1 in the LPUART_CR3 register. Note: When UESM is cleared, WUF flag is also cleared. Note: If the USART does not support the wake-up from Stop feature, this bit is reserved and kept at reset value. Refer to Section132.3: LPUART implementation on page1914.
    $15 constant LPUART_TEACK                   \ [0x15] Transmit enable acknowledge flag This bit is set/reset by hardware, when the Transmit Enable value is taken into account by the LPUART. It can be used when an idle frame request is generated by writing TE=0, followed by TE=1 in the LPUART_CR1 register, in order to respect the TE=0 minimum period.
    $16 constant LPUART_REACK                   \ [0x16] Receive enable acknowledge flag This bit is set/reset by hardware, when the Receive Enable value is taken into account by the LPUART. It can be used to verify that the LPUART is ready for reception before entering low-power mode. Note: If the LPUART does not support the wake-up from Stop feature, this bit is reserved and kept at reset value.
    $17 constant LPUART_TXFE                    \ [0x17] TXFIFO Empty This bit is set by hardware when TXFIFO is Empty. When the TXFIFO contains at least one data, this flag is cleared. The TXFE flag can also be set by writing 1 to the bit TXFRQ (bit 4) in the LPUART_RQR register. An interrupt is generated if the TXFEIE bit =1 (bit 30) in the LPUART_CR1 register.
    $18 constant LPUART_RXFF                    \ [0x18] RXFIFO Full This bit is set by hardware when the number of received data corresponds to RXFIFO1size1+11 (RXFIFO full + 1 data in the LPUART_RDR register. An interrupt is generated if the RXFFIE bit =1 in the LPUART_CR1 register.
    $1a constant LPUART_RXFT                    \ [0x1a] RXFIFO threshold flag This bit is set by hardware when the RXFIFO reaches the threshold programmed in RXFTCFG in LPUART_CR3 register i.e. the Receive FIFO contains RXFTCFG data. An interrupt is generated if the RXFTIE bit =1 (bit 27) in the LPUART_CR3 register.
    $1b constant LPUART_TXFT                    \ [0x1b] TXFIFO threshold flag This bit is set by hardware when the TXFIFO reaches the threshold programmed in TXFTCFG in LPUART_CR3 register i.e. the TXFIFO contains TXFTCFG empty locations. An interrupt is generated if the TXFTIE bit =1 (bit 31) in the LPUART_CR3 register.
  [then]


  [ifdef] LPUART_LPUART_ISR_ALTERNATE_DEF
    \
    \ @brief LPUART interrupt and status register
    \ Address offset: 0x1C
    \ Reset value: 0x008000C0
    \
    $00 constant LPUART_PE                      \ [0x00] Parity error This bit is set by hardware when a parity error occurs in Reception mode. It is cleared by software, writing 1 to the PECF in the LPUART_ICR register. An interrupt is generated if PEIE = 1 in the LPUART_CR1 register. Note: In FIFO mode, this error is associated with the character in the LPUART_RDR.
    $01 constant LPUART_FE                      \ [0x01] Framing error This bit is set by hardware when a de-synchronization, excessive noise or a break character is detected. It is cleared by software, writing 1 to the FECF bit in the LPUART_ICR register. When transmitting data in Smartcard mode, this bit is set when the maximum number of transmit attempts is reached without success (the card NACKs the data frame). An interrupt is generated if EIE1=11 in the LPUART_CR3 register. Note: In FIFO mode, this error is associated with the character in the LPUART_RDR.
    $02 constant LPUART_NE                      \ [0x02] Start bit noise detection flag This bit is set by hardware when noise is detected on the start bit of a received frame. It is cleared by software, writing 1 to the NFCF bit in the LPUART_ICR register. Note: This bit does not generate an interrupt as it appears at the same time as the RXNE/RXFNE bit which itself generates an interrupt. An interrupt is generated when the NE flag is set during multi buffer communication if the EIE bit is set. Note: In FIFO mode, this error is associated with the character in the LPUART_RDR.
    $03 constant LPUART_ORE                     \ [0x03] Overrun error This bit is set by hardware when the data currently being received in the shift register is ready to be transferred into the LPUART_RDR register while RXNE=1 (RXFF = 1 in case FIFO mode is enabled). It is cleared by a software, writing 1 to the ORECF, in the LPUART_ICR register. An interrupt is generated if RXNEIE=1 in the LPUART_CR1 register, or EIE = 1 in the LPUART_CR3 register. Note: When this bit is set, the LPUART_RDR register content is not lost but the shift register is overwritten. An interrupt is generated if the ORE flag is set during multi buffer communication if the EIE bit is set. Note: This bit is permanently forced to 0 (no overrun detection) when the bit OVRDIS is set in the LPUART_CR3 register.
    $04 constant LPUART_IDLE                    \ [0x04] Idle line detected This bit is set by hardware when an Idle Line is detected. An interrupt is generated if IDLEIE=1 in the LPUART_CR1 register. It is cleared by software, writing 1 to the IDLECF in the LPUART_ICR register. Note: The IDLE bit is not set again until the RXNE bit has been set (i.e. a new idle line occurs). Note: If Mute mode is enabled (MME=1), IDLE is set if the LPUART is not mute (RWU=0), whatever the Mute mode selected by the WAKE bit. If RWU=1, IDLE is not set.
    $05 constant LPUART_RXNE                    \ [0x05] Read data register not empty RXNE bit is set by hardware when the content of the LPUART_RDR shift register has been transferred to the LPUART_RDR register. It is cleared by a read to the LPUART_RDR register. The RXNE flag can also be cleared by writing 1 to the RXFRQ in the LPUART_RQR register. The RXFNE flag can also be cleared by writing 1 to the RXFRQ in the LPUART_RQR register. An interrupt is generated if RXNEIE=1 in the LPUART_CR1 register.
    $06 constant LPUART_TC                      \ [0x06] Transmission complete This bit indicates that the last data written in the USART_TDR has been transmitted out of the shift register. The TC flag is set when the transmission of a frame containing data is complete and when TXE is set. An interrupt is generated if TCIE=1 in the LPUART_CR1 register. TC bit is cleared by software by writing 1 to the TCCF in the USART_ICR register or by writing to the USART_TDR register.
    $07 constant LPUART_TXE                     \ [0x07] Transmit data register empty TXE is set by hardware when the content of the LPUART_TDR register has been transferred into the shift register. It is cleared by a write to the LPUART_TDR register. An interrupt is generated if the TXEIE bit =1 in the LPUART_CR1 register. Note: This bit is used during single buffer transmission.
    $09 constant LPUART_CTSIF                   \ [0x09] CTS interrupt flag This bit is set by hardware when the CTS input toggles, if the CTSE bit is set. It is cleared by software, by writing 1 to the CTSCF bit in the LPUART_ICR register. An interrupt is generated if CTSIE=1 in the LPUART_CR3 register. Note: If the hardware flow control feature is not supported, this bit is reserved and kept at reset value.
    $0a constant LPUART_CTS                     \ [0x0a] CTS flag This bit is set/reset by hardware. It is an inverted copy of the status of the CTS input pin. Note: If the hardware flow control feature is not supported, this bit is reserved and kept at reset value.
    $10 constant LPUART_BUSY                    \ [0x10] Busy flag This bit is set and reset by hardware. It is active when a communication is ongoing on the RX line (successful start bit detected). It is reset at the end of the reception (successful or not).
    $11 constant LPUART_CMF                     \ [0x11] Character match flag This bit is set by hardware, when a the character defined by ADD[7:0] is received. It is cleared by software, writing 1 to the CMCF in the LPUART_ICR register. An interrupt is generated if CMIE=1in the LPUART_CR1 register.
    $12 constant LPUART_SBKF                    \ [0x12] Send break flag This bit indicates that a send break character was requested. It is set by software, by writing 1 to the SBKRQ bit in the LPUART_CR3 register. It is automatically reset by hardware during the stop bit of break transmission.
    $13 constant LPUART_RWU                     \ [0x13] Receiver wake-up from Mute mode This bit indicates if the LPUART is in Mute mode. It is cleared/set by hardware when a wake-up/mute sequence is recognized. The Mute mode control sequence (address or IDLE) is selected by the WAKE bit in the LPUART_CR1 register. When wake-up on IDLE mode is selected, this bit can only be set by software, writing 1 to the MMRQ bit in the LPUART_RQR register. Note: If the LPUART does not support the wake-up from Stop feature, this bit is reserved and kept at reset value.
    $14 constant LPUART_WUF                     \ [0x14] Wake-up from low-power mode flag This bit is set by hardware, when a wake-up event is detected. The event is defined by the WUS bitfield. It is cleared by software, writing a 1 to the WUCF in the LPUART_ICR register. An interrupt is generated if WUFIE=1 in the LPUART_CR3 register. Note: When UESM is cleared, WUF flag is also cleared. Note: If the USART does not support the wake-up from Stop feature, this bit is reserved and kept at reset value. Refer to Section132.3: LPUART implementation on page1914.
    $15 constant LPUART_TEACK                   \ [0x15] Transmit enable acknowledge flag This bit is set/reset by hardware, when the Transmit Enable value is taken into account by the LPUART. It can be used when an idle frame request is generated by writing TE=0, followed by TE=1 in the LPUART_CR1 register, in order to respect the TE=0 minimum period.
    $16 constant LPUART_REACK                   \ [0x16] Receive enable acknowledge flag This bit is set/reset by hardware, when the Receive Enable value is taken into account by the LPUART. It can be used to verify that the LPUART is ready for reception before entering low-power mode. Note: If the LPUART does not support the wake-up from Stop feature, this bit is reserved and kept at reset value.
  [then]


  [ifdef] LPUART_LPUART_ICR_DEF
    \
    \ @brief LPUART interrupt flag clear register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant LPUART_PECF                    \ [0x00] Parity error clear flag Writing 1 to this bit clears the PE flag in the LPUART_ISR register.
    $01 constant LPUART_FECF                    \ [0x01] Framing error clear flag Writing 1 to this bit clears the FE flag in the LPUART_ISR register.
    $02 constant LPUART_NECF                    \ [0x02] Noise detected clear flag Writing 1 to this bit clears the NE flag in the LPUART_ISR register.
    $03 constant LPUART_ORECF                   \ [0x03] Overrun error clear flag Writing 1 to this bit clears the ORE flag in the LPUART_ISR register.
    $04 constant LPUART_IDLECF                  \ [0x04] Idle line detected clear flag Writing 1 to this bit clears the IDLE flag in the LPUART_ISR register.
    $06 constant LPUART_TCCF                    \ [0x06] Transmission complete clear flag Writing 1 to this bit clears the TC flag in the LPUART_ISR register.
    $09 constant LPUART_CTSCF                   \ [0x09] CTS clear flag Writing 1 to this bit clears the CTSIF flag in the LPUART_ISR register.
    $11 constant LPUART_CMCF                    \ [0x11] Character match clear flag Writing 1 to this bit clears the CMF flag in the LPUART_ISR register.
    $14 constant LPUART_WUCF                    \ [0x14] Wake-up from low-power mode clear flag Writing 1 to this bit clears the WUF flag in the USART_ISR register. Note: If the USART does not support the wake-up from Stop feature, this bit is reserved and must be kept at reset value. Refer to Section132.3: LPUART implementation on page1914.
  [then]


  [ifdef] LPUART_LPUART_RDR_DEF
    \
    \ @brief LPUART receive data register
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant LPUART_RDR                     \ [0x00 : 9] Receive data value Contains the received data character. The RDR register provides the parallel interface between the input shift register and the internal bus (see Figure1254). When receiving with the parity enabled, the value read in the MSB bit is the received parity bit.
  [then]


  [ifdef] LPUART_LPUART_TDR_DEF
    \
    \ @brief LPUART transmit data register
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant LPUART_TDR                     \ [0x00 : 9] Transmit data value Contains the data character to be transmitted. The TDR register provides the parallel interface between the internal bus and the output shift register (see Figure1254). When transmitting with the parity enabled (PCE bit set to 1 in the LPUART_CR1 register), the value written in the MSB (bit 7 or bit 8 depending on the data length) has no effect because it is replaced by the parity. Note: This register must be written only when TXE/TXFNF=1.
  [then]


  [ifdef] LPUART_LPUART_PRESC_DEF
    \
    \ @brief LPUART prescaler register
    \ Address offset: 0x2C
    \ Reset value: 0x00000000
    \
    $00 constant LPUART_PRESCALER               \ [0x00 : 4] Clock prescaler The LPUART input clock can be divided by a prescaler: Remaining combinations: Reserved. Note: When PRESCALER is programmed with a value different of the allowed ones, programmed prescaler value is equal to 1011 i.e. input clock divided by 256.
  [then]

  \
  \ @brief LPUART address block description
  \
  $00 constant LPUART_LPUART_CR1        \ LPUART control register 1
  $00 constant LPUART_LPUART_CR1_ALTERNATE    \ LPUART control register 1
  $04 constant LPUART_LPUART_CR2        \ LPUART control register 2
  $08 constant LPUART_LPUART_CR3        \ LPUART control register 3
  $0C constant LPUART_LPUART_BRR        \ LPUART baud rate register
  $18 constant LPUART_LPUART_RQR        \ LPUART request register
  $1C constant LPUART_LPUART_ISR        \ LPUART interrupt and status register
  $1C constant LPUART_LPUART_ISR_ALTERNATE    \ LPUART interrupt and status register
  $20 constant LPUART_LPUART_ICR        \ LPUART interrupt flag clear register
  $24 constant LPUART_LPUART_RDR        \ LPUART receive data register
  $28 constant LPUART_LPUART_TDR        \ LPUART transmit data register
  $2C constant LPUART_LPUART_PRESC      \ LPUART prescaler register

: LPUART_DEF ; [then]
