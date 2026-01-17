\
\ @file lpuart.fs
\ @brief LPUART interrupt
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] LPUART_DEF

  [ifdef] LPUART_CR1_DEF
    \
    \ @brief CR1 register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant LPUART_UE                      \ [0x00] UE: USART enable When this bit is cleared, the USART prescalers and outputs are stopped immediately, and current operations are discarded. The configuration of the USART is kept, but all the status flags, in the USART_ISR are reset. This bit is set and cleared by software. -0: USART prescaler and outputs disabled, low power mode -1: USART enabled
    $01 constant LPUART_UESM                    \ [0x01] UESM: LPUART enable in Stop mode When this bit is cleared, the LPUART is not able to wake up the MCU from Stop mode. When this bit is set, the LPUART is able to wake up the MCU from Stop mode, provided that the LPUART clock selection is LSE in the RCC. This bit is set and cleared by software. -0: LPUART not able to wake up the MCU from Stop mode. -1: LPUART able to wake up the MCU from Stop mode. When this function is active, the clock source for the LPUART must be LSE (see RCC chapter)
    $02 constant LPUART_RE                      \ [0x02] RE: Receiver enable This bit enables the receiver. It is set and cleared by software. -0: Receiver is disabled -1: Receiver is enabled and begins searching for a start bit
    $03 constant LPUART_TE                      \ [0x03] TE: Transmitter enable This bit enables the transmitter. It is set and cleared by software. -0: Transmitter is disabled -1: Transmitter is enabled
    $04 constant LPUART_IDLEIE                  \ [0x04] IDLEIE: IDLE interrupt enable This bit is set and cleared by software. -0: Interrupt is inhibited -1: A USART interrupt is generated whenever IDLE=1 in the USART_ISR register
    $05 constant LPUART_RXNEIE_RXFNEIE          \ [0x05] RXNEIE/RXFNEIE: Receive data register not empty/RXFIFO not empty interrupt enable This bit is set and cleared by software. -0: Interrupt is inhibited -1: An USART interrupt is generated whenever ORE=1 or RXNE/RXFNE=1 in the USART_ISR register
    $06 constant LPUART_TCIE                    \ [0x06] TCIE: Transmission complete interrupt enable This bit is set and cleared by software. -0: Interrupt is inhibited -1: A USART interrupt is generated whenever TC=1 in the USART_ISR register
    $07 constant LPUART_TXEIE_TXFNFIE           \ [0x07] TXEIE/TXFNFIE: Transmit data regsiter empty/TXFIFO not full interrupt enable This bit is set and cleared by software. -0: Interrupt is inhibited -1: A USART interrupt is generated whenever TXE/TXFNF =1 in the USART_ISR register
    $08 constant LPUART_PEIE                    \ [0x08] PEIE: PE interrupt enable This bit is set and cleared by software. -0: Interrupt is inhibited -1: A USART interrupt is generated whenever PE=1 in the USART_ISR register
    $09 constant LPUART_PS                      \ [0x09] PS: Parity selection This bit selects the odd or even parity when the parity generation/detection is enabled (PCE bit set). It is set and cleared by software. The parity will be selected after the current byte. -0: Even parity -1: Odd parity This bit field can only be written when the USART is disabled (UE=0).
    $0a constant LPUART_PCE                     \ [0x0a] PCE: Parity control enable This bit selects the hardware parity control (generation and detection). When the parity control is enabled, the computed parity is inserted at the MSB position (9th bit if M=1; 8th bit if M=0) and parity is checked on the received data. This bit is set and cleared by software. Once it is set, PCE is active after the current byte (in reception and in transmission). -0: Parity control disabled -1: Parity control enabled This bit field can only be written when the USART is disabled (UE=0).
    $0b constant LPUART_WAKE                    \ [0x0b] WAKE: Receiver wakeup method This bit determines the USART wakeup method from Mute mode. It is set or cleared by software. -0: Idle line -1: Address mark This bit field can only be written when the USART is disabled (UE=0).
    $0c constant LPUART_M_0                     \ [0x0c] M0: Word length This bit, with bit 28 (M1) determine the word length. It is set or cleared by software. See Bit -28 (M1)description. This bit can only be written when the USART is disabled (UE=0).
    $0d constant LPUART_MME                     \ [0x0d] MME: Mute mode enable This bit activates the mute mode function of the USART. When set, the USART can switch between the active and mute modes, as defined by the WAKE bit. It is set and cleared by software. -0: Receiver in active mode permanently -1: Receiver can switch between mute mode and active mode
    $0e constant LPUART_CMIE                    \ [0x0e] CMIE: Character match interrupt enable This bit is set and cleared by software. -0: Interrupt is inhibited -1: A USART interrupt is generated when the CMF bit is set in the USART_ISR register.
    $10 constant LPUART_DEDT                    \ [0x10 : 5] DEDT[4:0]: Driver Enable deassertion time This 5-bit value defines the time between the end of the last stop bit, in a transmitted message, and the de-activation of the DE (Driver Enable) signal. It is expressed in sample time units (1/8 or 1/16 bit time, depending on the oversampling rate). If the USART_TDR register is written during the DEDT time, the new data is transmitted only when the DEDT and DEAT times have both elapsed. This bit field can only be written when the USART is disabled (UE=0).
    $15 constant LPUART_DEAT                    \ [0x15 : 5] DEAT[4:0]: Driver Enable assertion time This 5-bit value defines the time between the activation of the DE (Driver Enable) signal and the beginning of the start bit. It is expressed in sample time units (1/8 or 1/16 bit time, depending on the oversampling rate). This bit field can only be written when the USART is disabled (UE=0).
    $1c constant LPUART_M_1                     \ [0x1c] Word length This bit, with bit 12 (M0) determine the word length. It is set or cleared by software. M[1:0] = 00: 1 Start bit, 8 Data bits, n Stop bit M[1:0] = 01: 1 Start bit, 9 Data bits, n Stop bit M[1:0] = 10: 1 Start bit, 7 Data bits, n Stop bit This bit can only be written when the USART is disabled (UE=0).s
    $1d constant LPUART_FIFOEN                  \ [0x1d] FIFOEN :FIFO mode enable This bit is set and cleared by software. -0: FIFO mode is disabled. -1: FIFO mode is enabled.
    $1e constant LPUART_TXFEIE                  \ [0x1e] TXFEIE :TXFIFO empty interrupt enable This bit is set and cleared by software. -0: Interrupt is inhibited -1: An USART interrupt is generated when TXFE=1 in the USART_ISR register
    $1f constant LPUART_RXFFIE                  \ [0x1f] RXFFIE :RXFIFO Full interrupt enable This bit is set and cleared by software. -0: Interrupt is inhibited -1: An USART interrupt is generated when RXFF=1 in the USART_ISR register
  [then]


  [ifdef] LPUART_CR2_DEF
    \
    \ @brief CR2 register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $04 constant LPUART_ADDM7                   \ [0x04] ADDM7:7-bit Address Detection/4-bit Address Detection This bit is for selection between 4-bit address detection or 7-bit address detection. -0: 4-bit address detection -1: 7-bit address detection (in 8-bit data mode) This bit can only be written when the USART is disabled (UE=0)
    $0c constant LPUART_STOP                    \ [0x0c : 2] STOP[1:0]: STOP bits These bits are used for programming the stop bits. -00: 1 stop bit -01: 0.5 stop bit. -10: 2 stop bits -11: 1.5 stop bits This bit field can only be written when the USART is disabled (UE=0).
    $0f constant LPUART_SWAP                    \ [0x0f] SWAP: Swap TX/RX pins This bit is set and cleared by software. -0: TX/RX pins are used as defined in standard pinout -1: The TX and RX pins functions are swapped. This allows to work in the case of a cross-wired connection to another UART. This bit field can only be written when the USART is disabled (UE=0).
    $10 constant LPUART_RXINV                   \ [0x10] RXINV: RX pin active level inversion This bit is set and cleared by software. -0: RX pin signal works using the standard logic levels (VDD =1/idle, Gnd=0/mark) -1: RX pin signal values are inverted. ((VDD =0/mark, Gnd=1/idle). This allows the use of an external inverter on the RX line. This bit field can only be written when the USART is disabled (UE=0).
    $11 constant LPUART_TXINV                   \ [0x11] TXINV: TX pin active level inversion This bit is set and cleared by software. -0: TX pin signal works using the standard logic levels (VDD =1/idle, Gnd=0/mark) -1: TX pin signal values are inverted. ((VDD =0/mark, Gnd=1/idle). This allows the use of an external inverter on the TX line. This bit field can only be written when the USART is disabled (UE=0).
    $12 constant LPUART_DATAINV                 \ [0x12] DATAINV: Binary data inversion This bit is set and cleared by software. -0: Logical data from the data register are send/received in positive/direct logic. (1=H, 0=L) -1: Logical data from the data register are send/received in negative/inverse logic. (1=L, 0=H). The parity bit is also inverted. This bit field can only be written when the USART is disabled (UE=0).
    $13 constant LPUART_MSBFIRST                \ [0x13] MSBFIRST: Most significant bit first This bit is set and cleared by software. -0: data is transmitted/received with data bit 0 first, following the start bit. -1: data is transmitted/received with the MSB (bit 7/8) first, following the start bit. This bit field can only be written when the USART is disabled (UE=0).
    $18 constant LPUART_ADD                     \ [0x18 : 8] ADD[7:0]: Address of the USART node This bit-field gives the address of the USART node or a character code to be recognized. This is used in multiprocessor communication during Mute mode or Stop mode, for wakeup with 7- bit address mark detection. The MSB of the character sent by the transmitter should be equal to 1. It may also be used for character detection during normal reception, Mute mode inactive (for example, end of block detection in ModBus protocol). In this case, the whole received character (8- bit) is compared to the ADD[7:0] value and CMF flag is set on match. This bit field can only be written when reception is disabled (RE = 0) or the USART is disabled (UE=0)
  [then]


  [ifdef] LPUART_CR3_DEF
    \
    \ @brief CR3 register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant LPUART_EIE                     \ [0x00] EIE: Error interrupt enable Error Interrupt Enable Bit is required to enable interrupt generation in case of a framing error, overrun error noise flag or SPI slave underrun error (FE=1 or ORE=1 or NF=1or UDR = 1 in the USART_ISR register). -0: Interrupt is inhibited -1: An interrupt is generated when FE=1 or ORE=1 or NF=1 or UDR = 1 (in SPI slave mode) in the USART_ISR register.
    $03 constant LPUART_HDSEL                   \ [0x03] HDSEL: Half-duplex selection Selection of Single-wire Half-duplex mode -0: Half duplex mode is not selected -1: Half duplex mode is selected This bit can only be written when the USART is disabled (UE=0).
    $06 constant LPUART_DMAR                    \ [0x06] DMAR: DMA enable receiver This bit is set/reset by software -1: DMA mode is enabled for reception -0: DMA mode is disabled for reception
    $07 constant LPUART_DMAT                    \ [0x07] DMAT: DMA enable transmitter This bit is set/reset by software -1: DMA mode is enabled for transmission -0: DMA mode is disabled for transmission
    $08 constant LPUART_RTSE                    \ [0x08] RTSE: RTS enable -0: RTS hardware flow control disabled -1: RTS output enabled, data is only requested when there is space in the receive buffer. The transmission of data is expected to cease after the current character has been transmitted. The nRTS output is asserted (pulled to 0) when data can be received. This bit can only be written when the USART is disabled (UE=0).
    $09 constant LPUART_CTSE                    \ [0x09] CTSE: CTS enable -0: CTS hardware flow control disabled -1: CTS mode enabled, data is only transmitted when the nCTS input is asserted (tied to 0). If the nCTS input is deasserted while data is being transmitted, then the transmission is completed before stopping. If data is written into the data register while nCTS is asserted, the transmission is postponed until nCTS is asserted. This bit can only be written when the USART is disabled (UE=0)
    $0a constant LPUART_CTSIE                   \ [0x0a] CTSIE: CTS interrupt enable -0: Interrupt is inhibited -1: An interrupt is generated whenever CTSIF=1 in the USART_ISR register
    $0c constant LPUART_OVRDIS                  \ [0x0c] OVRDIS: Overrun Disable This bit is used to disable the receive overrun detection. -0: Overrun Error Flag, ORE, is set when received data is not read before receiving new data. -1: Overrun functionality is disabled. If new data is received while the RXNE flag is still set the ORE flag is not set and the new received data overwrites the previous content of the USART_RDR register. When FIFO mode is enabled, the RXFIFO will be bypassed and data will be written directly in USARTx_RDR register. Even when FIFO management is enabled, the RXNE flag is to be used. This bit can only be written when the USART is disabled (UE=0).
    $0d constant LPUART_DDRE                    \ [0x0d] DDRE: DMA Disable on Reception Error -0: DMA is not disabled in case of reception error. The corresponding error flag is set but RXNE is kept 0 preventing from overrun. As a consequence, the DMA request is not asserted, so the erroneous data is not transferred (no DMA request), but next correct received data will be transferred. (used for Smartcard mode) -1: DMA is disabled following a reception error. The corresponding error flag is set, as well as RXNE. The DMA request is masked until the error flag is cleared. This means that the software must first disable the DMA request (DMAR = 0) or clear RXNE(RXFNE is case FIFO mode is enabled) before clearing the error flag. This bit can only be written when the USART is disabled (UE=0).
    $0e constant LPUART_DEM                     \ [0x0e] DEM: Driver enable mode This bit allows the user to activate the external transceiver control, through the DE signal. -0: DE function is disabled. -1: DE function is enabled. The DE signal is output on the RTS pin. This bit can only be written when the USART is disabled (UE=0).
    $0f constant LPUART_DEP                     \ [0x0f] DEP: Driver enable polarity selection -0: DE signal is active high. -1: DE signal is active low. This bit can only be written when the USART is disabled (UE=0).
    $14 constant LPUART_WUS                     \ [0x14 : 2] WUS[1:0]: Wakeup from Stop mode interrupt flag selection This bit-field specify the event which activates the WUF (Wakeup from Stop mode flag). -00: WUF active on address match (as defined by ADD[7:0] and ADDM7) -01:Reserved. -10: WUF active on Start bit detection -11: WUF active on RXNE. This bit field can only be written when the LPUART is disabled (UE=0).
    $16 constant LPUART_WUFIE                   \ [0x16] WUFIE: Wakeup from Stop mode interrupt enable This bit is set and cleared by software. -0: Interrupt is inhibited -1: An LPUART interrupt is generated whenever WUF=1 in the LPUART_ISR register
    $17 constant LPUART_TXFTIE                  \ [0x17] TXFTIE: TXFIFO threshold interrupt enable This bit is set and cleared by software. -0: Interrupt is inhibited -1: An USART interrupt is generated when TXFIFO reaches the threshold programmed in TXFTCFG.
    $19 constant LPUART_RXFTCFG                 \ [0x19 : 3] RXFTCFG: Receive FIFO threshold configuration -000:Receive FIFO reaches 1/8 of its depth. -001:Receive FIFO reaches 1/4 of its depth. -010:Receive FIFO reaches 1/2 of its depth. -011:Receive FIFO reaches 3/4 of its depth. -100:Receive FIFO reaches 7/8 of its depth. -101:Receive FIFO becomes full. Remaining combinations: Reserved.
    $1c constant LPUART_RXFTIE                  \ [0x1c] RXFTIE: RXFIFO threshold interrupt enable This bit is set and cleared by software. -0: Interrupt is inhibited -1: An USART interrupt is generated when Receive FIFO reaches the threshold programmed in RXFTCFG.
    $1d constant LPUART_TXFTCFG                 \ [0x1d : 3] TXFTCFG: TXFIFO threshold configuration -000:TXFIFO reaches 1/8 of its depth. -001:TXFIFO reaches 1/4 of its depth. -010:TXFIFO reaches 1/2 of its depth. -011:TXFIFO reaches 3/4 of its depth. -100:TXFIFO reaches 7/8 of its depth. -101:TXFIFO becomes empty. Remaining combinations: Reserved.
  [then]


  [ifdef] LPUART_BRR_DEF
    \
    \ @brief BRR register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant LPUART_BRR                     \ [0x00 : 20] BRR[19:0]
  [then]


  [ifdef] LPUART_RQR_DEF
    \
    \ @brief RQR register
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $01 constant LPUART_SBKRQ                   \ [0x01] SBKRQ: Send break request Writing 1 to this bit sets the SBKF flag and request to send a BREAK on the line, as soon as the transmit machine is available.
    $02 constant LPUART_MMRQ                    \ [0x02] MMRQ: Mute mode request Writing 1 to this bit puts the USART in mute mode and resets the RWU flag.
    $03 constant LPUART_RXFRQ                   \ [0x03] RXFRQ: Receive data flush request Writing 1 to this bit empties the entire receive FIFO i.e. clears the bit RXFNE. This allows to discard the received data without reading them, and avoid an overrun condition.
    $04 constant LPUART_TXFRQ                   \ [0x04] TXFRQ: Transmit data flush request When FIFO mode is disabled, Writing 1 to this bit sets the TXE flag. This allows to discard the transmit data. This bit must be used only in Smartcard mode, when data has not been sent due to errors (NACK) and the FE flag is active in the USART_ISR register. If the USART does not support Smartcard mode, this bit is reserved and forced by hardware to 0' When FIFO is enabled, TXFRQ bit is set to flush the whole FIFO . This will set the flag TXFE (Transmit FIFO empty, bit 23 in the USART_ISR register). Flushing the Transmit FIFO is supported in both UART and Smartcard modes.
  [then]


  [ifdef] LPUART_ISR_DEF
    \
    \ @brief ISR register
    \ Address offset: 0x1C
    \ Reset value: 0x000000C0
    \
    $00 constant LPUART_PE                      \ [0x00] PE: Parity error This bit is set by hardware when a parity error occurs in receiver mode. It is cleared by software, writing 1 to the PECF in the USART_ICR register. An interrupt is generated if PEIE = 1 in the USART_CR1 register. -0: No parity error -1: Parity error
    $01 constant LPUART_FE                      \ [0x01] FE: Framing error This bit is set by hardware when a de-synchronization, excessive noise or a break character is detected. It is cleared by software, writing 1 to the FECF bit in the USART_ICR register. In Smartcard mode, in transmission, this bit is set when the maximum number of transmit attempts is reached without success (the card NACKs the data frame). An interrupt is generated if EIE = 1 in the USART_CR1 register. -0: No Framing error is detected -1: Framing error or break character is detected
    $02 constant LPUART_NF                      \ [0x02] NF: START bit Noise detection flag This bit is set by hardware when noise is detected on a received frame. It is cleared by software, writing 1 to the NFCF bit in the USART_ICR register. -0: No noise is detected -1: Noise is detected
    $03 constant LPUART_ORE                     \ [0x03] ORE: Overrun error This bit is set by hardware when the data currently being received in the shift register is ready to be transferred into the USARTx_RDR register while RXNE=1 (RXFF = 1 in case FIFO mode is enabled) . It is cleared by a software, writing 1 to the ORECF, in the USARTx_ICR register. An interrupt is generated if RXNEIE/ RXFNEIE=1 or EIE = 1 in the USARTx_CR1 register. -0: No overrun error -1: Overrun error is detected
    $04 constant LPUART_IDLE                    \ [0x04] IDLE: Idle line detected This bit is set by hardware when an Idle Line is detected. An interrupt is generated if IDLEIE=1 in the USART_CR1 register. It is cleared by software, writing 1 to the IDLECF in the USART_ICR register. -0: No Idle line is detected -1: Idle line is detected
    $05 constant LPUART_RXNE_RXFNE              \ [0x05] RXNE/RXFNE:Read data register not empty/RXFIFO not empty RXNE bit is set by hardware when the content of the USARTx_RDR shift register has been transferred to the USARTx_RDR register. It is cleared by a read to the USARTx_RDR register. The RXNE flag can also be cleared by writing 1 to the RXFRQ in the USARTx_RQR register. RXFNE bit is set by hardware when the RXFIFO is not empty, and so data can be read from the USART_RDR register. Every read of the USART_RDR frees a location in the RXFIFO. It is cleared when the RXFIFO is empty. The RXNE/RXFNE flag can also be cleared by writing 1 to the RXFRQ in the USART_RQR register. An interrupt is generated if RXNEIE/RXFNEIE=1 in the USART_CR1 register. -0: Data is not received -1: Received data is ready to be read.
    $06 constant LPUART_TC                      \ [0x06] TC: Transmission complete This bit indicates when the last data written in the USART_TDR has been transmitted out of the shift register. It is set by hardware if the transmission of a frame containing data is complete and if TXE/TXFE is set. An interrupt is generated if TCIE=1 in the USART_CR1 register. It is cleared by software, writing 1 to the TCCF in the USART_ICR register or by a write to the USART_TDR register. An interrupt is generated if TCIE=1 in the USART_CR1 register. -0: Transmission is not complete -1: Transmission is complete
    $07 constant LPUART_TXE_TXFNF               \ [0x07] TXE/TXFNF: Transmit data register empty/TXFIFO not full When FIFO mode is disabled, TXE is set by hardware when the content of the USARTx_TDR register has been transferred into the shift register. It is cleared by a write to the USARTx_TDR register. The TXE flag can also be set by writing 1 to the TXFRQ in the USART_RQR register, in order to discard the data (only in Smartcard T=0 mode, in case of transmission failure). When FIFO mode is enabled, TXFNF is set by hardware when TXFIFO is not full, and so data can be written in the USART_TDR. Every write in the USART_TDR places the data in the TXFIFO. This flag remains set until the TXFIFO is full. When the TXFIFO is full, this flag is cleared indicating that data can not be written into the USART_TDR. Note: The TXFNF is kept reset during the flush request until TXFIFO is empty . After sending the flush request (by setting TXFRQ bit), the flag TXFNF should be checked prior to writing in TXFIFO. (TXFNF and TXFE will be set at the same time). An interrupt is generated if the TXEIE/TXFNFIE bit =1 in the USART_CR1 register. -0: Data register is full/Transmit FIFO is full. -1: Data register/Transmit FIFO is not full
    $09 constant LPUART_CTSIF                   \ [0x09] CTSIF: CTS interrupt flag This bit is set by hardware when the nCTS input toggles, if the CTSE bit is set. It is cleared by software, by writing 1 to the CTSCF bit in the USART_ICR register. An interrupt is generated if CTSIE=1 in the USART_CR3 register. -0: No change occurred on the nCTS status line -1: A change occurred on the nCTS status line
    $0a constant LPUART_CTS                     \ [0x0a] CTS: CTS flag This bit is set/reset by hardware. It is an inverted copy of the status of the nCTS input pin. -0: nCTS line set -1: nCTS line reset
    $10 constant LPUART_BUSY                    \ [0x10] BUSY: Busy flag This bit is set and reset by hardware. It is active when a communication is ongoing on the RX line (successful start bit detected). It is reset at the end of the reception (successful or not). -0: USART is idle (no reception) -1: Reception on going
    $11 constant LPUART_CMF                     \ [0x11] CMF: Character match flag This bit is set by hardware, when a the character defined by ADD[7:0] is received. It is cleared by software, writing 1 to the CMCF in the USART_ICR register. An interrupt is generated if CMIE=1in the USART_CR1 register. -0: No Character match detected -1: Character Match detected
    $12 constant LPUART_SBKF                    \ [0x12] SBKF: Send break flag This bit indicates that a send break character was requested. It is set by software, by writing 1 to the SBKRQ bit in the USART_CR3 register. It is automatically reset by hardware during the stop bit of break transmission. -0: No break character is transmitted -1: Break character will be transmitted
    $13 constant LPUART_RWU                     \ [0x13] RWU: Receiver wakeup from Mute mode This bit indicates if the USART is in mute mode. It is cleared/set by hardware when a wakeup/mute sequence is recognized. The mute mode control sequence (address or IDLE) is selected by the WAKE bit in the USART_CR1 register. When wakeup on IDLE mode is selected, this bit can only be set by software, writing 1 to the MMRQ bit in the USART_RQR register. -0: Receiver in active mode -1: Receiver in mute mode
    $14 constant LPUART_WUF                     \ [0x14] WUF: Wakeup from Stop mode flag This bit is set by hardware, when a wakeup event is detected. The event is defined by the WUS bit field. It is cleared by software, writing a 1 to the WUCF in the LPUART_ICR register. An interrupt is generated if WUFIE=1 in the LPUART_CR3 register
    $15 constant LPUART_TEACK                   \ [0x15] TEACK: Transmit enable acknowledge flag This bit is set/reset by hardware, when the Transmit Enable value is taken into account by the USART. It can be used when an idle frame request is generated by writing TE=0, followed by TE=1 in the USART_CR1 register, in order to respect the TE=0 minimum period.
    $16 constant LPUART_REACK                   \ [0x16] REACK: Receive enable acknowledge flag This bit is set/reset by hardware, when the Receive Enable value is taken into account by the USART. It can be used to verify that the USART is ready for reception before entering Stop mode.
    $17 constant LPUART_TXFE                    \ [0x17] TXFE: TXFIFO Empty This bit is set by hardware when TXFIFO is Empty. When the TXFIFO contains at least one data, this flag is cleared. The TXFE flag can also be set by writing 1 to the bit TXFRQ (bit 4) in the USART_RQR register. An interrupt is generated if the TXFEIE bit =1 (bit 30) in the USART_CR1 register. -0: TXFIFO is not empty. -1: TXFIFO is empty.
    $18 constant LPUART_RXFF                    \ [0x18] RXFF: RXFIFO Full This bit is set by hardware when RXFIFO is Full. An interrupt is generated if the RXFFIE bit =1 in the USART_CR1 register. -0: RXFIFO is not Full. -1: RXFIFO is Full.
    $1a constant LPUART_RXFT                    \ [0x1a] RXFT: RXFIFO threshold flag This bit is set by hardware when the programmed threshold in RXFTCFG in USARTx_CR3 register is reached. This means that there are (RXFTCFG 1) data in the Receive FIFO and one data in the USART_RDR register. An interrupt is generated if the RXFTIE bit =1 (bit 27) in the USART_CR3 register. -0: Receive FIFO doesn't reach the programmed threshold. -1: Receive FIFO reached the programmed threshold
    $1b constant LPUART_TXFT                    \ [0x1b] TXFT: TXFIFO threshold flag This bit is set by hardware when the TXFIFO reaches the programmed threshold in TXFTCFG in USARTx_CR3 register i.e. the TXFIFO contains TXFTCFG empty locations. An interrupt is generated if the TXFTIE bit =1 (bit 31) in the USART_CR3 register. -0: TXFIFO doesn't reach the programmed threshold. -1: TXFIFO reached the programmed threshold
  [then]


  [ifdef] LPUART_ICR_DEF
    \
    \ @brief ICR register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant LPUART_PECF                    \ [0x00] PECF: Parity error clear flag Writing 1 to this bit clears the PE flag in the USART_ISR register.
    $01 constant LPUART_FECF                    \ [0x01] FECF: Framing error clear flag Writing 1 to this bit clears the FE flag in the USART_ISR register
    $02 constant LPUART_NECF                    \ [0x02] NECF: Noise detected clear flag Writing 1 to this bit clears the NF flag in the USART_ISR register.
    $03 constant LPUART_ORECF                   \ [0x03] ORECF: Overrun error clear flag Writing 1 to this bit clears the ORE flag in the USART_ISR register.
    $04 constant LPUART_IDLECF                  \ [0x04] IDLECF: Idle line detected clear flag Writing 1 to this bit clears the IDLE flag in the USART_ISR register.
    $06 constant LPUART_TCCF                    \ [0x06] TCCF: Transmission complete clear flag Writing 1 to this bit clears the TC flag in the USART_ISR register
    $09 constant LPUART_CTSCF                   \ [0x09] CTSCF: CTS clear flag Writing 1 to this bit clears the CTSIF flag in the USART_ISR register
    $11 constant LPUART_CMCF                    \ [0x11] CMCF: Character match clear flag Writing 1 to this bit clears the CMF flag in the USART_ISR register
    $14 constant LPUART_WUCF                    \ [0x14] WUCF: Wakeup from Stop mode clear flag Writing 1 to this bit clears the WUF flag in the LPUART_ISR register
  [then]


  [ifdef] LPUART_RDR_DEF
    \
    \ @brief RDR register
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant LPUART_RDR                     \ [0x00 : 9] RDR[8:0]: Receive data value Contains the received data character. The RDR register provides the parallel interface between the input shift register and the internal bus (see Figure 124). When receiving with the parity enabled, the value read in the MSB bit is the received parity bit.
  [then]


  [ifdef] LPUART_TDR_DEF
    \
    \ @brief TDR register
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant LPUART_TDR                     \ [0x00 : 9] TDR[8:0]: Transmit data value Contains the data character to be transmitted. The USARTx_TDR register provides the parallel interface between the internal bus and the output shift register (see Figure 124). When transmitting with the parity enabled (PCE bit set to 1 in the USART_CR1 register), the value written in the MSB (bit 7 or bit 8 depending on the data length) has no effect because it is replaced by the parity. Note: This register must be written only when TXE/TXFNF=1.
  [then]


  [ifdef] LPUART_PRESC_DEF
    \
    \ @brief PRESC register
    \ Address offset: 0x2C
    \ Reset value: 0x00000000
    \
    $00 constant LPUART_PRESCALER               \ [0x00 : 4] PRESCALER[3:0]: Clock prescaler The USART input clock can be divided by a prescaler: -0000: input clock not divided -0001: input clock divided by 2 -0010: input clock divided by 4 -0011: input clock divided by 6 -0100: input clock divided by 8 -0101: input clock divided by 10 -0110: input clock divided by 12 -0111: input clock divided by 16 -1000: input clock divided by 32 -1001: input clock divided by 64 -1010: input clock divided by 128 -1011: input clock divided by 256 Remaing combinations: Reserved. Note: When PRESCALER is programmed with a value different of the allowed ones, programmed prescaler value will be '1011' i.e. input clock divided by 256
  [then]

  \
  \ @brief LPUART interrupt
  \
  $00 constant LPUART_CR1               \ CR1 register
  $04 constant LPUART_CR2               \ CR2 register
  $08 constant LPUART_CR3               \ CR3 register
  $0C constant LPUART_BRR               \ BRR register
  $18 constant LPUART_RQR               \ RQR register
  $1C constant LPUART_ISR               \ ISR register
  $20 constant LPUART_ICR               \ ICR register
  $24 constant LPUART_RDR               \ RDR register
  $28 constant LPUART_TDR               \ TDR register
  $2C constant LPUART_PRESC             \ PRESC register

: LPUART_DEF ; [then]
