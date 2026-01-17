\
\ @file lpuart1.fs
\ @brief Low-power universal asynchronous receiver transmitter
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] LPUART1_DEF

  [ifdef] LPUART1_LPUART_CR1_enabled_DEF
    \
    \ @brief LPUART control register 1 [alternate]
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant LPUART1_UE                     \ [0x00] USART enable When this bit is cleared, the USART prescalers and outputs are stopped immediately, and all current operations are discarded. The USART configuration is kept, but all the USART_ISR status flags are reset. This bit is set and cleared by software. Note: To enter low-power mode without generating errors on the line, the TE bit must be previously reset and the software must wait for the TC bit in the USART_ISR to be set before resetting the UE bit. The DMA requests are also reset when UE = 0 so the DMA channel must be disabled before resetting the UE bit. In Smartcard mode, (SCEN = 1), the SCLK is always available when CLKEN = 1, regardless of the UE bit value.
    $01 constant LPUART1_UESM                   \ [0x01] USART enable in low-power mode When this bit is cleared, the USART cannot wake up the MCU from low-power mode. When this bit is set, the USART can wake up the MCU from low-power mode. This bit is set and cleared by software. Note: It is recommended to set the UESM bit just before entering low-power mode and clear it when exit from low-power mode. If the USART does not support the wakeup from Stop feature, this bit is reserved and must be kept at reset value. Refer to .
    $02 constant LPUART1_RE                     \ [0x02] Receiver enable This bit enables the receiver. It is set and cleared by software.
    $03 constant LPUART1_TE                     \ [0x03] Transmitter enable This bit enables the transmitter. It is set and cleared by software. Note: During transmission, a low pulse on the TE bit ('0' followed by '1') sends a preamble (idle line) after the current word, except in Smartcard mode. In order to generate an idle character, the TE must not be immediately written to '1'. To ensure the required duration, the software can poll the TEACK bit in the USART_ISR register. In Smartcard mode, when TE is set, there is a 1 bit-time delay before the transmission starts.
    $04 constant LPUART1_IDLEIE                 \ [0x04] IDLE interrupt enable This bit is set and cleared by software.
    $05 constant LPUART1_RXFNEIE                \ [0x05] RXFIFO not empty interrupt enable This bit is set and cleared by software.
    $06 constant LPUART1_TCIE                   \ [0x06] Transmission complete interrupt enable This bit is set and cleared by software.
    $07 constant LPUART1_TXFNFIE                \ [0x07] TXFIFO not full interrupt enable This bit is set and cleared by software.
    $08 constant LPUART1_PEIE                   \ [0x08] PE interrupt enable This bit is set and cleared by software.
    $09 constant LPUART1_PS                     \ [0x09] Parity selection This bit selects the odd or even parity when the parity generation/detection is enabled (PCE bit set). It is set and cleared by software. The parity is selected after the current byte. This bitfield can only be written when the USART is disabled (UE=0).
    $0a constant LPUART1_PCE                    \ [0x0a] Parity control enable This bit selects the hardware parity control (generation and detection). When the parity control is enabled, the computed parity is inserted at the MSB position (9th bit if M=1; 8th bit if M=0) and the parity is checked on the received data. This bit is set and cleared by software. Once it is set, PCE is active after the current byte (in reception and in transmission). This bitfield can only be written when the USART is disabled (UE=0).
    $0b constant LPUART1_WAKE                   \ [0x0b] Receiver wakeup method This bit determines the USART wakeup method from Mute mode. It is set or cleared by software. This bitfield can only be written when the USART is disabled (UE=0).
    $0c constant LPUART1_M0                     \ [0x0c] Word length This bit is used in conjunction with bit 28 (M1) to determine the word length. It is set or cleared by software (refer to bit 28 (M1)description). This bit can only be written when the USART is disabled (UE=0).
    $0d constant LPUART1_MME                    \ [0x0d] Mute mode enable This bit enables the USART Mute mode function. When set, the USART can switch between active and Mute mode, as defined by the WAKE bit. It is set and cleared by software.
    $0e constant LPUART1_CMIE                   \ [0x0e] Character match interrupt enable This bit is set and cleared by software.
    $0f constant LPUART1_OVER8                  \ [0x0f] Oversampling mode This bit can only be written when the USART is disabled (UE=0). Note: In LIN, IrDA and Smartcard modes, this bit must be kept cleared.
    $10 constant LPUART1_DEDT                   \ [0x10 : 5] Driver Enable deassertion time This 5-bit value defines the time between the end of the last stop bit, in a transmitted message, and the de-activation of the DE (Driver Enable) signal. It is expressed in sample time units (1/8 or 1/16 bit time, depending on the oversampling rate). If the USART_TDR register is written during the DEDT time, the new data is transmitted only when the DEDT and DEAT times have both elapsed. This bitfield can only be written when the USART is disabled (UE=0). Note: If the Driver Enable feature is not supported, this bit is reserved and must be kept at reset value. Refer to .
    $15 constant LPUART1_DEAT                   \ [0x15 : 5] Driver Enable assertion time This 5-bit value defines the time between the activation of the DE (Driver Enable) signal and the beginning of the start bit. It is expressed in sample time units (1/8 or 1/16 bit time, depending on the oversampling rate). This bitfield can only be written when the USART is disabled (UE=0). Note: If the Driver Enable feature is not supported, this bit is reserved and must be kept at reset value. Refer to .
    $1a constant LPUART1_RTOIE                  \ [0x1a] Receiver timeout interrupt enable This bit is set and cleared by software. Note: If the USART does not support the Receiver timeout feature, this bit is reserved and must be kept at reset value. .
    $1b constant LPUART1_EOBIE                  \ [0x1b] End of Block interrupt enable This bit is set and cleared by software. Note: If the USART does not support Smartcard mode, this bit is reserved and must be kept at reset value. Refer to .
    $1c constant LPUART1_M1                     \ [0x1c] Word length This bit must be used in conjunction with bit 12 (M0) to determine the word length. It is set or cleared by software. M[1:0] = '00': 1 start bit, 8 Data bits, n Stop bit M[1:0] = '01': 1 start bit, 9 Data bits, n Stop bit M[1:0] = '10': 1 start bit, 7 Data bits, n Stop bit This bit can only be written when the USART is disabled (UE=0). Note: In 7-bits data length mode, the Smartcard mode, LIN master mode and Auto baud rate (0x7F and 0x55 frames detection) are not supported.
    $1d constant LPUART1_FIFOEN                 \ [0x1d] FIFO mode enable This bit is set and cleared by software. This bitfield can only be written when the USART is disabled (UE=0). Note: FIFO mode can be used on standard UART communication, in SPI master/slave mode and in Smartcard modes only. It must not be enabled in IrDA and LIN modes.
    $1e constant LPUART1_TXFEIE                 \ [0x1e] TXFIFO empty interrupt enable This bit is set and cleared by software.
    $1f constant LPUART1_RXFFIE                 \ [0x1f] RXFIFO Full interrupt enable This bit is set and cleared by software.
  [then]


  [ifdef] LPUART1_LPUART_CR1_disabled_DEF
    \
    \ @brief LPUART control register 1 [alternate]
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant LPUART1_UE                     \ [0x00] USART enable When this bit is cleared, the USART prescalers and outputs are stopped immediately, and all current operations are discarded. The USART configuration is kept, but all the USART_ISR status flags are reset. This bit is set and cleared by software. Note: To enter low-power mode without generating errors on the line, the TE bit must be previously reset and the software must wait for the TC bit in the USART_ISR to be set before resetting the UE bit. The DMA requests are also reset when UE = 0 so the DMA channel must be disabled before resetting the UE bit. In Smartcard mode, (SCEN = 1), the SCLK is always available when CLKEN = 1, regardless of the UE bit value.
    $01 constant LPUART1_UESM                   \ [0x01] USART enable in low-power mode When this bit is cleared, the USART cannot wake up the MCU from low-power mode. When this bit is set, the USART can wake up the MCU from low-power mode. This bit is set and cleared by software. Note: It is recommended to set the UESM bit just before entering low-power mode and clear it when exit from low-power mode. If the USART does not support the wakeup from Stop feature, this bit is reserved and must be kept at reset value. Refer to .
    $02 constant LPUART1_RE                     \ [0x02] Receiver enable This bit enables the receiver. It is set and cleared by software.
    $03 constant LPUART1_TE                     \ [0x03] Transmitter enable This bit enables the transmitter. It is set and cleared by software. Note: During transmission, a low pulse on the TE bit ('0' followed by '1') sends a preamble (idle line) after the current word, except in Smartcard mode. In order to generate an idle character, the TE must not be immediately written to '1'. To ensure the required duration, the software can poll the TEACK bit in the USART_ISR register. In Smartcard mode, when TE is set, there is a 1 bit-time delay before the transmission starts.
    $04 constant LPUART1_IDLEIE                 \ [0x04] IDLE interrupt enable This bit is set and cleared by software.
    $05 constant LPUART1_RXNEIE                 \ [0x05] Receive data register not empty This bit is set and cleared by software.
    $06 constant LPUART1_TCIE                   \ [0x06] Transmission complete interrupt enable This bit is set and cleared by software.
    $07 constant LPUART1_TXEIE                  \ [0x07] Transmit data register empty This bit is set and cleared by software.
    $08 constant LPUART1_PEIE                   \ [0x08] PE interrupt enable This bit is set and cleared by software.
    $09 constant LPUART1_PS                     \ [0x09] Parity selection This bit selects the odd or even parity when the parity generation/detection is enabled (PCE bit set). It is set and cleared by software. The parity is selected after the current byte. This bitfield can only be written when the USART is disabled (UE=0).
    $0a constant LPUART1_PCE                    \ [0x0a] Parity control enable This bit selects the hardware parity control (generation and detection). When the parity control is enabled, the computed parity is inserted at the MSB position (9th bit if M=1; 8th bit if M=0) and the parity is checked on the received data. This bit is set and cleared by software. Once it is set, PCE is active after the current byte (in reception and in transmission). This bitfield can only be written when the USART is disabled (UE=0).
    $0b constant LPUART1_WAKE                   \ [0x0b] Receiver wakeup method This bit determines the USART wakeup method from Mute mode. It is set or cleared by software. This bitfield can only be written when the USART is disabled (UE=0).
    $0c constant LPUART1_M0                     \ [0x0c] Word length This bit is used in conjunction with bit 28 (M1) to determine the word length. It is set or cleared by software (refer to bit 28 (M1)description). This bit can only be written when the USART is disabled (UE=0).
    $0d constant LPUART1_MME                    \ [0x0d] Mute mode enable This bit enables the USART Mute mode function. When set, the USART can switch between active and Mute mode, as defined by the WAKE bit. It is set and cleared by software.
    $0e constant LPUART1_CMIE                   \ [0x0e] Character match interrupt enable This bit is set and cleared by software.
    $0f constant LPUART1_OVER8                  \ [0x0f] Oversampling mode This bit can only be written when the USART is disabled (UE=0). Note: In LIN, IrDA and Smartcard modes, this bit must be kept cleared.
    $10 constant LPUART1_DEDT                   \ [0x10 : 5] Driver Enable deassertion time This 5-bit value defines the time between the end of the last stop bit, in a transmitted message, and the de-activation of the DE (Driver Enable) signal. It is expressed in sample time units (1/8 or 1/16 bit time, depending on the oversampling rate). If the USART_TDR register is written during the DEDT time, the new data is transmitted only when the DEDT and DEAT times have both elapsed. This bitfield can only be written when the USART is disabled (UE=0). Note: If the Driver Enable feature is not supported, this bit is reserved and must be kept at reset value. Refer to .
    $15 constant LPUART1_DEAT                   \ [0x15 : 5] Driver Enable assertion time This 5-bit value defines the time between the activation of the DE (Driver Enable) signal and the beginning of the start bit. It is expressed in sample time units (1/8 or 1/16 bit time, depending on the oversampling rate). This bitfield can only be written when the USART is disabled (UE=0). Note: If the Driver Enable feature is not supported, this bit is reserved and must be kept at reset value. Refer to .
    $1a constant LPUART1_RTOIE                  \ [0x1a] Receiver timeout interrupt enable This bit is set and cleared by software. Note: If the USART does not support the Receiver timeout feature, this bit is reserved and must be kept at reset value. .
    $1b constant LPUART1_EOBIE                  \ [0x1b] End of Block interrupt enable This bit is set and cleared by software. Note: If the USART does not support Smartcard mode, this bit is reserved and must be kept at reset value. Refer to .
    $1c constant LPUART1_M1                     \ [0x1c] Word length This bit must be used in conjunction with bit 12 (M0) to determine the word length. It is set or cleared by software. M[1:0] = '00': 1 start bit, 8 Data bits, n Stop bit M[1:0] = '01': 1 start bit, 9 Data bits, n Stop bit M[1:0] = '10': 1 start bit, 7 Data bits, n Stop bit This bit can only be written when the USART is disabled (UE=0). Note: In 7-bits data length mode, the Smartcard mode, LIN master mode and Auto baud rate (0x7F and 0x55 frames detection) are not supported.
    $1d constant LPUART1_FIFOEN                 \ [0x1d] FIFO mode enable This bit is set and cleared by software. This bitfield can only be written when the USART is disabled (UE=0). Note: FIFO mode can be used on standard UART communication, in SPI master/slave mode and in Smartcard modes only. It must not be enabled in IrDA and LIN modes.
  [then]


  [ifdef] LPUART1_LPUART_CR2_DEF
    \
    \ @brief LPUART control register 2
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $04 constant LPUART1_ADDM7                  \ [0x04] 7-bit Address Detection/4-bit Address Detection This bit is for selection between 4-bit address detection or 7-bit address detection. This bit can only be written when the LPUART is disabled (UE=0) Note: In 7-bit and 9-bit data modes, the address detection is done on 6-bit and 8-bit address (ADD[5:0] and ADD[7:0]) respectively.
    $0c constant LPUART1_STOP                   \ [0x0c : 2] STOP bits These bits are used for programming the stop bits. This bitfield can only be written when the LPUART is disabled (UE=0).
    $0f constant LPUART1_SWAP                   \ [0x0f] Swap TX/RX pins This bit is set and cleared by software. This bitfield can only be written when the LPUART is disabled (UE=0).
    $10 constant LPUART1_RXINV                  \ [0x10] RX pin active level inversion This bit is set and cleared by software. This enables the use of an external inverter on the RX line. This bitfield can only be written when the LPUART is disabled (UE=0).
    $11 constant LPUART1_TXINV                  \ [0x11] TX pin active level inversion This bit is set and cleared by software. This enables the use of an external inverter on the TX line. This bitfield can only be written when the LPUART is disabled (UE=0).
    $12 constant LPUART1_DATAINV                \ [0x12] Binary data inversion This bit is set and cleared by software. This bitfield can only be written when the LPUART is disabled (UE=0).
    $13 constant LPUART1_MSBFIRST               \ [0x13] Most significant bit first This bit is set and cleared by software. This bitfield can only be written when the LPUART is disabled (UE=0).
    $18 constant LPUART1_ADD                    \ [0x18 : 8] Address of the LPUART node ADD[7:4]: These bits give the address of the LPUART node or a character code to be recognized. They are used to wake up the MCU with 7-bit address mark detection in multiprocessor communication during Mute mode or Stop mode. The MSB of the character sent by the transmitter should be equal to 1. They can also be used for character detection during normal reception, Mute mode inactive (for example, end of block detection in ModBus protocol). In this case, the whole received character (8-bit) is compared to the ADD[7:0] value and CMF flag is set on match. These bits can only be written when reception is disabled (RE = 0) or the LPUART is disabled (UE=0) ADD[3:0]: These bits give the address of the LPUART node or a character code to be recognized. They are used for wakeup with address mark detection in multiprocessor communication during Mute mode or low-power mode. These bits can only be written when reception is disabled (RE = 0) or the LPUART is disabled (UE=0)
  [then]


  [ifdef] LPUART1_LPUART_CR3_DEF
    \
    \ @brief LPUART control register 3
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant LPUART1_EIE                    \ [0x00] Error interrupt enable Error Interrupt Enable Bit is required to enable interrupt generation in case of a framing error, overrun error or noise flag (FE=1 or ORE=1 or NE=1 in the LPUART_ISR register).
    $03 constant LPUART1_HDSEL                  \ [0x03] Half-duplex selection Selection of Single-wire Half-duplex mode This bit can only be written when the LPUART is disabled (UE=0).
    $06 constant LPUART1_DMAR                   \ [0x06] DMA enable receiver This bit is set/reset by software
    $07 constant LPUART1_DMAT                   \ [0x07] DMA enable transmitter This bit is set/reset by software
    $08 constant LPUART1_RTSE                   \ [0x08] RTS enable This bit can only be written when the LPUART is disabled (UE=0).
    $09 constant LPUART1_CTSE                   \ [0x09] CTS enable This bit can only be written when the LPUART is disabled (UE=0)
    $0a constant LPUART1_CTSIE                  \ [0x0a] CTS interrupt enable
    $0c constant LPUART1_OVRDIS                 \ [0x0c] Overrun Disable This bit is used to disable the receive overrun detection. the ORE flag is not set and the new received data overwrites the previous content of the LPUART_RDR register. This bit can only be written when the LPUART is disabled (UE=0). Note: This control bit enables checking the communication flow w/o reading the data.
    $0d constant LPUART1_DDRE                   \ [0x0d] DMA Disable on Reception Error This bit can only be written when the LPUART is disabled (UE=0). Note: The reception errors are: parity error, framing error or noise error.
    $0e constant LPUART1_DEM                    \ [0x0e] Driver enable mode This bit enables the user to activate the external transceiver control, through the DE signal. This bit can only be written when the LPUART is disabled (UE=0).
    $0f constant LPUART1_DEP                    \ [0x0f] Driver enable polarity selection This bit can only be written when the LPUART is disabled (UE=0).
    $14 constant LPUART1_WUS                    \ [0x14 : 2] Wakeup from low-power mode interrupt flag selection This bitfield specifies the event which activates the WUF (Wakeup from low-power mode flag). This bitfield can only be written when the LPUART is disabled (UE=0). Note: If the LPUART does not support the wakeup from Stop feature, this bit is reserved and must be kept at reset value. Refer to .
    $16 constant LPUART1_WUFIE                  \ [0x16] Wakeup from low-power mode interrupt enable This bit is set and cleared by software. Note: WUFIE must be set before entering in low-power mode. If the LPUART does not support the wakeup from Stop feature, this bit is reserved and must be kept at reset value. Refer to .
    $17 constant LPUART1_TXFTIE                 \ [0x17] TXFIFO threshold interrupt enable This bit is set and cleared by software.
    $19 constant LPUART1_RXFTCFG                \ [0x19 : 3] Receive FIFO threshold configuration Remaining combinations: Reserved.
    $1c constant LPUART1_RXFTIE                 \ [0x1c] RXFIFO threshold interrupt enable This bit is set and cleared by software.
    $1d constant LPUART1_TXFTCFG                \ [0x1d : 3] TXFIFO threshold configuration Remaining combinations: Reserved.
  [then]


  [ifdef] LPUART1_LPUART_BRR_DEF
    \
    \ @brief LPUART baud rate register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant LPUART1_BRR                    \ [0x00 : 20] LPUART baud rate
  [then]


  [ifdef] LPUART1_LPUART_RQR_DEF
    \
    \ @brief LPUART request register
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $01 constant LPUART1_SBKRQ                  \ [0x01] Send break request Writing 1 to this bit sets the SBKF flag and request to send a BREAK on the line, as soon as the transmit machine is available. Note: If the application needs to send the break character following all previously inserted data, including the ones not yet transmitted, the software should wait for the TXE flag assertion before setting the SBKRQ bit.
    $02 constant LPUART1_MMRQ                   \ [0x02] Mute mode request Writing 1 to this bit puts the LPUART in Mute mode and resets the RWU flag.
    $03 constant LPUART1_RXFRQ                  \ [0x03] Receive data flush request Writing 1 to this bit clears the RXNE flag. This enables discarding the received data without reading it, and avoid an overrun condition.
    $04 constant LPUART1_TXFRQ                  \ [0x04] Transmit data flush request This bit is used when FIFO mode is enabled. TXFRQ bit is set to flush the whole FIFO. This sets the flag TXFE (TXFIFO empty, bit 23 in the LPUART_ISR register). Note: In FIFO mode, the TXFNF flag is reset during the flush request until TxFIFO is empty in order to ensure that no data are written in the data register.
  [then]


  [ifdef] LPUART1_LPUART_ISR_enabled_DEF
    \
    \ @brief LPUART interrupt and status register [alternate]
    \ Address offset: 0x1C
    \ Reset value: 0x008000C0
    \
    $00 constant LPUART1_PE                     \ [0x00] Parity error This bit is set by hardware when a parity error occurs in receiver mode. It is cleared by software, writing 1 to the PECF in the USART_ICR register. An interrupt is generated if PEIE = 1 in the USART_CR1 register. Note: This error is associated with the character in the USART_RDR.
    $01 constant LPUART1_FE                     \ [0x01] Framing error This bit is set by hardware when a de-synchronization, excessive noise or a break character is detected. It is cleared by software, writing 1 to the FECF bit in the USART_ICR register. When transmitting data in Smartcard mode, this bit is set when the maximum number of transmit attempts is reached without success (the card NACKs the data frame). An interrupt is generated if EIE=1 in the USART_CR1 register. Note: This error is associated with the character in the USART_RDR.
    $02 constant LPUART1_NE                     \ [0x02] Noise detection flag This bit is set by hardware when noise is detected on a received frame. It is cleared by software, writing 1 to the NECF bit in the USART_ICR register. Note: This bit does not generate an interrupt as it appears at the same time as the RXFNE bit which itself generates an interrupt. An interrupt is generated when the NE flag is set during multi buffer communication if the EIE bit is set. When the line is noise-free, the NE flag can be disabled by programming the ONEBIT bit to 1 to increase the USART tolerance to deviations (Refer to Tolerance of the USART receiver to clock deviation on page903). This error is associated with the character in the USART_RDR.
    $03 constant LPUART1_ORE                    \ [0x03] Overrun error This bit is set by hardware when the data currently being received in the shift register is ready to be transferred into the USART_RDR register while RXFF = 1. It is cleared by a software, writing 1 to the ORECF, in the USART_ICR register. An interrupt is generated if RXFNEIE=1 or EIE = 1 in the USART_CR1 register. Note: When this bit is set, the USART_RDR register content is not lost but the shift register is overwritten. An interrupt is generated if the ORE flag is set during multi buffer communication if the EIE bit is set. This bit is permanently forced to 0 (no overrun detection) when the bit OVRDIS is set in the USART_CR3 register.
    $04 constant LPUART1_IDLE                   \ [0x04] Idle line detected This bit is set by hardware when an Idle Line is detected. An interrupt is generated if IDLEIE=1 in the USART_CR1 register. It is cleared by software, writing 1 to the IDLECF in the USART_ICR register. Note: The IDLE bit is not set again until the RXFNE bit has been set (i.e. a new idle line occurs). If Mute mode is enabled (MME=1), IDLE is set if the USART is not mute (RWU=0), whatever the Mute mode selected by the WAKE bit. If RWU=1, IDLE is not set.
    $05 constant LPUART1_RXFNE                  \ [0x05] RXFIFO not empty RXFNE bit is set by hardware when the RXFIFO is not empty, meaning that data can be read from the USART_RDR register. Every read operation from the USART_RDR frees a location in the RXFIFO. RXFNE is cleared when the RXFIFO is empty. The RXFNE flag can also be cleared by writing 1 to the RXFRQ in the USART_RQR register. An interrupt is generated if RXFNEIE=1 in the USART_CR1 register.
    $06 constant LPUART1_TC                     \ [0x06] Transmission complete This bit indicates that the last data written in the USART_TDR has been transmitted out of the shift register. It is set by hardware when the transmission of a frame containing data is complete and when TXFE is set. An interrupt is generated if TCIE=1 in the USART_CR1 register. TC bit is is cleared by software, by writing 1 to the TCCF in the USART_ICR register or by a write to the USART_TDR register. Note: If TE bit is reset and no transmission is on going, the TC bit is immediately set.
    $07 constant LPUART1_TXFNF                  \ [0x07] TXFIFO not full TXFNF is set by hardware when TXFIFO is not full meaning that data can be written in the USART_TDR. Every write operation to the USART_TDR places the data in the TXFIFO. This flag remains set until the TXFIFO is full. When the TXFIFO is full, this flag is cleared indicating that data can not be written into the USART_TDR. An interrupt is generated if the TXFNFIE bit =1 in the USART_CR1 register. Note: The TXFNF is kept reset during the flush request until TXFIFO is empty. After sending the flush request (by setting TXFRQ bit), the flag TXFNF should be checked prior to writing in TXFIFO (TXFNF and TXFE are set at the same time). This bit is used during single buffer transmission.
    $08 constant LPUART1_LBDF                   \ [0x08] LIN break detection flag This bit is set by hardware when the LIN break is detected. It is cleared by software, by writing 1 to the LBDCF in the USART_ICR. An interrupt is generated if LBDIE = 1 in the USART_CR2 register. Note: If the USART does not support LIN mode, this bit is reserved and kept at reset value. Refer to .
    $09 constant LPUART1_CTSIF                  \ [0x09] CTS interrupt flag This bit is set by hardware when the nCTS input toggles, if the CTSE bit is set. It is cleared by software, by writing 1 to the CTSCF bit in the USART_ICR register. An interrupt is generated if CTSIE=1 in the USART_CR3 register. Note: If the hardware flow control feature is not supported, this bit is reserved and kept at reset value.
    $0a constant LPUART1_CTS                    \ [0x0a] CTS flag This bit is set/reset by hardware. It is an inverted copy of the status of the nCTS input pin. Note: If the hardware flow control feature is not supported, this bit is reserved and kept at reset value.
    $0b constant LPUART1_RTOF                   \ [0x0b] Receiver timeout This bit is set by hardware when the timeout value, programmed in the RTOR register has lapsed, without any communication. It is cleared by software, writing 1 to the RTOCF bit in the USART_ICR register. An interrupt is generated if RTOIE=1 in the USART_CR2 register. In Smartcard mode, the timeout corresponds to the CWT or BWT timings. Note: If a time equal to the value programmed in RTOR register separates 2 characters, RTOF is not set. If this time exceeds this value + 2 sample times (2/16 or 2/8, depending on the oversampling method), RTOF flag is set. The counter counts even if RE = 0 but RTOF is set only when RE = 1. If the timeout has already elapsed when RE is set, then RTOF is set. If the USART does not support the Receiver timeout feature, this bit is reserved and kept at reset value.
    $0c constant LPUART1_EOBF                   \ [0x0c] End of block flag This bit is set by hardware when a complete block has been received (for example T=1 Smartcard mode). The detection is done when the number of received bytes (from the start of the block, including the prologue) is equal or greater than BLEN + 4. An interrupt is generated if the EOBIE=1 in the USART_CR2 register. It is cleared by software, writing 1 to the EOBCF in the USART_ICR register. Note: If Smartcard mode is not supported, this bit is reserved and kept at reset value. Refer to .
    $0d constant LPUART1_UDR                    \ [0x0d] SPI slave underrun error flag In slave transmission mode, this flag is set when the first clock pulse for data transmission appears while the software has not yet loaded any value into USART_TDR. This flag is reset by setting UDRCF bit in the USART_ICR register. Note: If the USART does not support the SPI slave mode, this bit is reserved and kept at reset value. Refer to .
    $0e constant LPUART1_ABRE                   \ [0x0e] Auto baud rate error This bit is set by hardware if the baud rate measurement failed (baud rate out of range or character comparison failed) It is cleared by software, by writing 1 to the ABRRQ bit in the USART_CR3 register. Note: If the USART does not support the auto baud rate feature, this bit is reserved and kept at reset value.
    $0f constant LPUART1_ABRF                   \ [0x0f] Auto baud rate flag This bit is set by hardware when the automatic baud rate has been set (RXFNE is also set, generating an interrupt if RXFNEIE = 1) or when the auto baud rate operation was completed without success (ABRE=1) (ABRE, RXFNE and FE are also set in this case) It is cleared by software, in order to request a new auto baud rate detection, by writing 1 to the ABRRQ in the USART_RQR register. Note: If the USART does not support the auto baud rate feature, this bit is reserved and kept at reset value.
    $10 constant LPUART1_BUSY                   \ [0x10] Busy flag This bit is set and reset by hardware. It is active when a communication is ongoing on the RX line (successful start bit detected). It is reset at the end of the reception (successful or not).
    $11 constant LPUART1_CMF                    \ [0x11] Character match flag This bit is set by hardware, when a the character defined by ADD[7:0] is received. It is cleared by software, writing 1 to the CMCF in the USART_ICR register. An interrupt is generated if CMIE=1in the USART_CR1 register.
    $12 constant LPUART1_SBKF                   \ [0x12] Send break flag This bit indicates that a send break character was requested. It is set by software, by writing 1 to the SBKRQ bit in the USART_CR3 register. It is automatically reset by hardware during the stop bit of break transmission.
    $13 constant LPUART1_RWU                    \ [0x13] Receiver wakeup from Mute mode This bit indicates if the USART is in Mute mode. It is cleared/set by hardware when a wakeup/mute sequence is recognized. The Mute mode control sequence (address or IDLE) is selected by the WAKE bit in the USART_CR1 register. When wakeup on IDLE mode is selected, this bit can only be set by software, writing 1 to the MMRQ bit in the USART_RQR register. Note: If the USART does not support the wakeup from Stop feature, this bit is reserved and kept at reset value. Refer to .
    $14 constant LPUART1_WUF                    \ [0x14] Wakeup from low-power mode flag This bit is set by hardware, when a wakeup event is detected. The event is defined by the WUS bitfield. It is cleared by software, writing a 1 to the WUCF in the USART_ICR register. An interrupt is generated if WUFIE=1 in the USART_CR3 register. Note: When UESM is cleared, WUF flag is also cleared. If the USART does not support the wakeup from Stop feature, this bit is reserved and kept at reset value. Refer to .
    $15 constant LPUART1_TEACK                  \ [0x15] Transmit enable acknowledge flag This bit is set/reset by hardware, when the Transmit Enable value is taken into account by the USART. It can be used when an idle frame request is generated by writing TE=0, followed by TE=1 in the USART_CR1 register, in order to respect the TE=0 minimum period.
    $16 constant LPUART1_REACK                  \ [0x16] Receive enable acknowledge flag This bit is set/reset by hardware, when the Receive Enable value is taken into account by the USART. It can be used to verify that the USART is ready for reception before entering low-power mode. Note: If the USART does not support the wakeup from Stop feature, this bit is reserved and kept at reset value. Refer to .
    $17 constant LPUART1_TXFE                   \ [0x17] TXFIFO empty This bit is set by hardware when TXFIFO is empty. When the TXFIFO contains at least one data, this flag is cleared. The TXFE flag can also be set by writing 1 to the bit TXFRQ (bit 4) in the USART_RQR register. An interrupt is generated if the TXFEIE bit =1 (bit 30) in the USART_CR1 register.
    $18 constant LPUART1_RXFF                   \ [0x18] RXFIFO full This bit is set by hardware when the number of received data corresponds to RXFIFOsize+1 (RXFIFO full + 1 data in the USART_RDR register. An interrupt is generated if the RXFFIE bit =1 in the USART_CR1 register.
    $19 constant LPUART1_TCBGT                  \ [0x19] Transmission complete before guard time flag This bit is set when the last data written in the USART_TDR has been transmitted correctly out of the shift register. It is set by hardware in Smartcard mode, if the transmission of a frame containing data is complete and if the smartcard did not send back any NACK. An interrupt is generated if TCBGTIE=1 in the USART_CR3 register. This bit is cleared by software, by writing 1 to the TCBGTCF in the USART_ICR register or by a write to the USART_TDR register. Note: If the USART does not support the Smartcard mode, this bit is reserved and kept at reset value. If the USART supports the Smartcard mode and the Smartcard mode is enabled, the TCBGT reset value is '1'. Refer to on page877.
    $1a constant LPUART1_RXFT                   \ [0x1a] RXFIFO threshold flag This bit is set by hardware when the threshold programmed in RXFTCFG in USART_CR3 register is reached. This means that there are (RXFTCFG - 1) data in the Receive FIFO and one data in the USART_RDR register. An interrupt is generated if the RXFTIE bit =1 (bit 27) in the USART_CR3 register. Note: When the RXFTCFG threshold is configured to '101', RXFT flag is set if 16 data are available i.e. 15 data in the RXFIFO and 1 data in the USART_RDR. Consequently, the 17th received data does not cause an overrun error. The overrun error occurs after receiving the 18th data.
    $1b constant LPUART1_TXFT                   \ [0x1b] TXFIFO threshold flag This bit is set by hardware when the TXFIFO reaches the threshold programmed in TXFTCFG of USART_CR3 register i.e. the TXFIFO contains TXFTCFG empty locations. An interrupt is generated if the TXFTIE bit =1 (bit 31) in the USART_CR3 register.
  [then]


  [ifdef] LPUART1_LPUART_ISR_disabled_DEF
    \
    \ @brief LPUART interrupt and status register [alternate]
    \ Address offset: 0x1C
    \ Reset value: 0x008000C0
    \
    $00 constant LPUART1_PE                     \ [0x00] Parity error This bit is set by hardware when a parity error occurs in receiver mode. It is cleared by software, writing 1 to the PECF in the USART_ICR register. An interrupt is generated if PEIE = 1 in the USART_CR1 register.
    $01 constant LPUART1_FE                     \ [0x01] Framing error This bit is set by hardware when a de-synchronization, excessive noise or a break character is detected. It is cleared by software, writing 1 to the FECF bit in the USART_ICR register. When transmitting data in Smartcard mode, this bit is set when the maximum number of transmit attempts is reached without success (the card NACKs the data frame). An interrupt is generated if EIE=1 in the USART_CR1 register.
    $02 constant LPUART1_NE                     \ [0x02] Noise detection flag This bit is set by hardware when noise is detected on a received frame. It is cleared by software, writing 1 to the NECF bit in the USART_ICR register. Note: This bit does not generate an interrupt as it appears at the same time as the RXNE bit which itself generates an interrupt. An interrupt is generated when the NE flag is set during multi buffer communication if the EIE bit is set. When the line is noise-free, the NE flag can be disabled by programming the ONEBIT bit to 1 to increase the USART tolerance to deviations (Refer to Tolerance of the USART receiver to clock deviation on page903).
    $03 constant LPUART1_ORE                    \ [0x03] Overrun error This bit is set by hardware when the data currently being received in the shift register is ready to be transferred into the USART_RDR register while RXNE=1. It is cleared by a software, writing 1 to the ORECF, in the USART_ICR register. An interrupt is generated if RXNEIE=1 or EIE = 1 in the USART_CR1 register. Note: When this bit is set, the USART_RDR register content is not lost but the shift register is overwritten. An interrupt is generated if the ORE flag is set during multi buffer communication if the EIE bit is set. This bit is permanently forced to 0 (no overrun detection) when the bit OVRDIS is set in the USART_CR3 register.
    $04 constant LPUART1_IDLE                   \ [0x04] Idle line detected This bit is set by hardware when an Idle Line is detected. An interrupt is generated if IDLEIE=1 in the USART_CR1 register. It is cleared by software, writing 1 to the IDLECF in the USART_ICR register. Note: The IDLE bit is not set again until the RXNE bit has been set (i.e. a new idle line occurs). If Mute mode is enabled (MME=1), IDLE is set if the USART is not mute (RWU=0), whatever the Mute mode selected by the WAKE bit. If RWU=1, IDLE is not set.
    $05 constant LPUART1_RXNE                   \ [0x05] Read data register not empty RXNE bit is set by hardware when the content of the USART_RDR shift register has been transferred to the USART_RDR register. It is cleared by reading from the USART_RDR register. The RXNE flag can also be cleared by writing 1 to the RXFRQ in the USART_RQR register. An interrupt is generated if RXNEIE=1 in the USART_CR1 register.
    $06 constant LPUART1_TC                     \ [0x06] Transmission complete This bit indicates that the last data written in the USART_TDR has been transmitted out of the shift register. It is set by hardware when the transmission of a frame containing data is complete and when TXE is set. An interrupt is generated if TCIE=1 in the USART_CR1 register. TC bit is is cleared by software, by writing 1 to the TCCF in the USART_ICR register or by a write to the USART_TDR register. Note: If TE bit is reset and no transmission is on going, the TC bit is set immediately.
    $07 constant LPUART1_TXE                    \ [0x07] Transmit data register empty TXE is set by hardware when the content of the USART_TDR register has been transferred into the shift register. It is cleared by writing to the USART_TDR register. The TXE flag can also be set by writing 1 to the TXFRQ in the USART_RQR register, in order to discard the data (only in Smartcard T=0 mode, in case of transmission failure). An interrupt is generated if the TXEIE bit =1 in the USART_CR1 register.
    $08 constant LPUART1_LBDF                   \ [0x08] LIN break detection flag This bit is set by hardware when the LIN break is detected. It is cleared by software, by writing 1 to the LBDCF in the USART_ICR. An interrupt is generated if LBDIE = 1 in the USART_CR2 register. Note: If the USART does not support LIN mode, this bit is reserved and kept at reset value. Refer to .
    $09 constant LPUART1_CTSIF                  \ [0x09] CTS interrupt flag This bit is set by hardware when the nCTS input toggles, if the CTSE bit is set. It is cleared by software, by writing 1 to the CTSCF bit in the USART_ICR register. An interrupt is generated if CTSIE=1 in the USART_CR3 register. Note: If the hardware flow control feature is not supported, this bit is reserved and kept at reset value.
    $0a constant LPUART1_CTS                    \ [0x0a] CTS flag This bit is set/reset by hardware. It is an inverted copy of the status of the nCTS input pin. Note: If the hardware flow control feature is not supported, this bit is reserved and kept at reset value.
    $0b constant LPUART1_RTOF                   \ [0x0b] Receiver timeout This bit is set by hardware when the timeout value, programmed in the RTOR register has lapsed, without any communication. It is cleared by software, writing 1 to the RTOCF bit in the USART_ICR register. An interrupt is generated if RTOIE=1 in the USART_CR2 register. In Smartcard mode, the timeout corresponds to the CWT or BWT timings. Note: If a time equal to the value programmed in RTOR register separates 2 characters, RTOF is not set. If this time exceeds this value + 2 sample times (2/16 or 2/8, depending on the oversampling method), RTOF flag is set. The counter counts even if RE = 0 but RTOF is set only when RE = 1. If the timeout has already elapsed when RE is set, then RTOF is set. If the USART does not support the Receiver timeout feature, this bit is reserved and kept at reset value.
    $0c constant LPUART1_EOBF                   \ [0x0c] End of block flag This bit is set by hardware when a complete block has been received (for example T=1 Smartcard mode). The detection is done when the number of received bytes (from the start of the block, including the prologue) is equal or greater than BLEN + 4. An interrupt is generated if the EOBIE=1 in the USART_CR2 register. It is cleared by software, writing 1 to the EOBCF in the USART_ICR register. Note: If Smartcard mode is not supported, this bit is reserved and kept at reset value. Refer to .
    $0d constant LPUART1_UDR                    \ [0x0d] SPI slave underrun error flag In slave transmission mode, this flag is set when the first clock pulse for data transmission appears while the software has not yet loaded any value into USART_TDR. This flag is reset by setting UDRCF bit in the USART_ICR register. Note: If the USART does not support the SPI slave mode, this bit is reserved and kept at reset value. Refer to .
    $0e constant LPUART1_ABRE                   \ [0x0e] Auto baud rate error This bit is set by hardware if the baud rate measurement failed (baud rate out of range or character comparison failed) It is cleared by software, by writing 1 to the ABRRQ bit in the USART_CR3 register. Note: If the USART does not support the auto baud rate feature, this bit is reserved and kept at reset value.
    $0f constant LPUART1_ABRF                   \ [0x0f] Auto baud rate flag This bit is set by hardware when the automatic baud rate has been set (RXNE is also set, generating an interrupt if RXNEIE = 1) or when the auto baud rate operation was completed without success (ABRE=1) (ABRE, RXNE and FE are also set in this case) It is cleared by software, in order to request a new auto baud rate detection, by writing 1 to the ABRRQ in the USART_RQR register. Note: If the USART does not support the auto baud rate feature, this bit is reserved and kept at reset value.
    $10 constant LPUART1_BUSY                   \ [0x10] Busy flag This bit is set and reset by hardware. It is active when a communication is ongoing on the RX line (successful start bit detected). It is reset at the end of the reception (successful or not).
    $11 constant LPUART1_CMF                    \ [0x11] Character match flag This bit is set by hardware, when a the character defined by ADD[7:0] is received. It is cleared by software, writing 1 to the CMCF in the USART_ICR register. An interrupt is generated if CMIE=1in the USART_CR1 register.
    $12 constant LPUART1_SBKF                   \ [0x12] Send break flag This bit indicates that a send break character was requested. It is set by software, by writing 1 to the SBKRQ bit in the USART_CR3 register. It is automatically reset by hardware during the stop bit of break transmission.
    $13 constant LPUART1_RWU                    \ [0x13] Receiver wakeup from Mute mode This bit indicates if the USART is in Mute mode. It is cleared/set by hardware when a wakeup/mute sequence is recognized. The Mute mode control sequence (address or IDLE) is selected by the WAKE bit in the USART_CR1 register. When wakeup on IDLE mode is selected, this bit can only be set by software, writing 1 to the MMRQ bit in the USART_RQR register. Note: If the USART does not support the wakeup from Stop feature, this bit is reserved and kept at reset value. Refer to .
    $14 constant LPUART1_WUF                    \ [0x14] Wakeup from low-power mode flag This bit is set by hardware, when a wakeup event is detected. The event is defined by the WUS bitfield. It is cleared by software, writing a 1 to the WUCF in the USART_ICR register. An interrupt is generated if WUFIE=1 in the USART_CR3 register. Note: When UESM is cleared, WUF flag is also cleared. If the USART does not support the wakeup from Stop feature, this bit is reserved and kept at reset value. Refer to .
    $15 constant LPUART1_TEACK                  \ [0x15] Transmit enable acknowledge flag This bit is set/reset by hardware, when the Transmit Enable value is taken into account by the USART. It can be used when an idle frame request is generated by writing TE=0, followed by TE=1 in the USART_CR1 register, in order to respect the TE=0 minimum period.
    $16 constant LPUART1_REACK                  \ [0x16] Receive enable acknowledge flag This bit is set/reset by hardware, when the Receive Enable value is taken into account by the USART. It can be used to verify that the USART is ready for reception before entering low-power mode. Note: If the USART does not support the wakeup from Stop feature, this bit is reserved and kept at reset value. Refer to .
    $19 constant LPUART1_TCBGT                  \ [0x19] Transmission complete before guard time flag This bit is set when the last data written in the USART_TDR has been transmitted correctly out of the shift register. It is set by hardware in Smartcard mode, if the transmission of a frame containing data is complete and if the smartcard did not send back any NACK. An interrupt is generated if TCBGTIE=1 in the USART_CR3 register. This bit is cleared by software, by writing 1 to the TCBGTCF in the USART_ICR register or by a write to the USART_TDR register. Note: If the USART does not support the Smartcard mode, this bit is reserved and kept at reset value. If the USART supports the Smartcard mode and the Smartcard mode is enabled, the TCBGT reset value is '1'. Refer to on page877.
  [then]


  [ifdef] LPUART1_LPUART_ICR_DEF
    \
    \ @brief LPUART interrupt flag clear register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant LPUART1_PECF                   \ [0x00] Parity error clear flag Writing 1 to this bit clears the PE flag in the LPUART_ISR register.
    $01 constant LPUART1_FECF                   \ [0x01] Framing error clear flag Writing 1 to this bit clears the FE flag in the LPUART_ISR register.
    $02 constant LPUART1_NECF                   \ [0x02] Noise detected clear flag Writing 1 to this bit clears the NE flag in the LPUART_ISR register.
    $03 constant LPUART1_ORECF                  \ [0x03] Overrun error clear flag Writing 1 to this bit clears the ORE flag in the LPUART_ISR register.
    $04 constant LPUART1_IDLECF                 \ [0x04] Idle line detected clear flag Writing 1 to this bit clears the IDLE flag in the LPUART_ISR register.
    $06 constant LPUART1_TCCF                   \ [0x06] Transmission complete clear flag Writing 1 to this bit clears the TC flag in the LPUART_ISR register.
    $09 constant LPUART1_CTSCF                  \ [0x09] CTS clear flag Writing 1 to this bit clears the CTSIF flag in the LPUART_ISR register.
    $11 constant LPUART1_CMCF                   \ [0x11] Character match clear flag Writing 1 to this bit clears the CMF flag in the LPUART_ISR register.
    $14 constant LPUART1_WUCF                   \ [0x14] Wakeup from low-power mode clear flag Writing 1 to this bit clears the WUF flag in the LPUART_ISR register. Note: If the LPUART does not support the wakeup from Stop feature, this bit is reserved and kept at reset value. Refer to .
  [then]


  [ifdef] LPUART1_LPUART_RDR_DEF
    \
    \ @brief LPUART receive data register
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant LPUART1_RDR                    \ [0x00 : 9] Receive data value Contains the received data character. The RDR register provides the parallel interface between the input shift register and the internal bus (see ). When receiving with the parity enabled, the value read in the MSB bit is the received parity bit.
  [then]


  [ifdef] LPUART1_LPUART_TDR_DEF
    \
    \ @brief LPUART transmit data register
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant LPUART1_TDR                    \ [0x00 : 9] Transmit data value Contains the data character to be transmitted. The TDR register provides the parallel interface between the internal bus and the output shift register (see ). When transmitting with the parity enabled (PCE bit set to 1 in the LPUART_CR1 register), the value written in the MSB (bit 7 or bit 8 depending on the data length) has no effect because it is replaced by the parity. Note: This register must be written only when TXE/TXFNF=1.
  [then]


  [ifdef] LPUART1_LPUART_PRESC_DEF
    \
    \ @brief LPUART prescaler register
    \ Address offset: 0x2C
    \ Reset value: 0x00000000
    \
    $00 constant LPUART1_PRESCALER              \ [0x00 : 4] Clock prescaler The LPUART input clock can be divided by a prescaler: Remaining combinations: Reserved. Note: When PRESCALER is programmed with a value different of the allowed ones, programmed prescaler value is 1011 i.e. input clock divided by 256.
  [then]

  \
  \ @brief Low-power universal asynchronous receiver transmitter
  \
  $00 constant LPUART1_LPUART_CR1_ENABLED    \ LPUART control register 1 [alternate]
  $00 constant LPUART1_LPUART_CR1_DISABLED    \ LPUART control register 1 [alternate]
  $04 constant LPUART1_LPUART_CR2       \ LPUART control register 2
  $08 constant LPUART1_LPUART_CR3       \ LPUART control register 3
  $0C constant LPUART1_LPUART_BRR       \ LPUART baud rate register
  $18 constant LPUART1_LPUART_RQR       \ LPUART request register
  $1C constant LPUART1_LPUART_ISR_ENABLED    \ LPUART interrupt and status register [alternate]
  $1C constant LPUART1_LPUART_ISR_DISABLED    \ LPUART interrupt and status register [alternate]
  $20 constant LPUART1_LPUART_ICR       \ LPUART interrupt flag clear register
  $24 constant LPUART1_LPUART_RDR       \ LPUART receive data register
  $28 constant LPUART1_LPUART_TDR       \ LPUART transmit data register
  $2C constant LPUART1_LPUART_PRESC     \ LPUART prescaler register

: LPUART1_DEF ; [then]
