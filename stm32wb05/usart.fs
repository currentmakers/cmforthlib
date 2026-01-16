\
\ @file usart.fs
\ @brief USART interrupt
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief CR1 register
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000001 constant USART_CR1_UE                                     \ UE: USART enable When this bit is cleared, the USART prescalers and outputs are stopped immediately, and current operations are discarded. The configuration of the USART is kept, but all the status flags, in the USART_ISR are reset. This bit is set and cleared by software. -0: USART prescaler and outputs disabled, low power mode -1: USART enabled
$00000004 constant USART_CR1_RE                                     \ RE: Receiver enable This bit enables the receiver. It is set and cleared by software. -0: Receiver is disabled -1: Receiver is enabled and begins searching for a start bit
$00000008 constant USART_CR1_TE                                     \ TE: Transmitter enable This bit enables the transmitter. It is set and cleared by software. -0: Transmitter is disabled -1: Transmitter is enabled
$00000010 constant USART_CR1_IDLEIE                                 \ IDLEIE: IDLE interrupt enable This bit is set and cleared by software. -0: Interrupt is inhibited -1: A USART interrupt is generated whenever IDLE=1 in the USART_ISR register
$00000020 constant USART_CR1_RXNEIE_RXFNEIE                         \ RXNEIE/RXFNEIE: Receive data register not empty/RXFIFO not empty interrupt enable This bit is set and cleared by software. -0: Interrupt is inhibited -1: An USART interrupt is generated whenever ORE=1 or RXNE/RXFNE=1 in the USART_ISR register
$00000040 constant USART_CR1_TCIE                                   \ TCIE: Transmission complete interrupt enable This bit is set and cleared by software. -0: Interrupt is inhibited -1: A USART interrupt is generated whenever TC=1 in the USART_ISR register
$00000080 constant USART_CR1_TXEIE_TXFNFIE                          \ TXEIE/TXFNFIE: Transmit data regsiter empty/TXFIFO not full interrupt enable This bit is set and cleared by software. -0: Interrupt is inhibited -1: A USART interrupt is generated whenever TXE/TXFNF =1 in the USART_ISR register
$00000100 constant USART_CR1_PEIE                                   \ PEIE: PE interrupt enable This bit is set and cleared by software. -0: Interrupt is inhibited -1: A USART interrupt is generated whenever PE=1 in the USART_ISR register
$00000200 constant USART_CR1_PS                                     \ PS: Parity selection This bit selects the odd or even parity when the parity generation/detection is enabled (PCE bit set). It is set and cleared by software. The parity will be selected after the current byte. -0: Even parity -1: Odd parity This bit field can only be written when the USART is disabled (UE=0).
$00000400 constant USART_CR1_PCE                                    \ PCE: Parity control enable This bit selects the hardware parity control (generation and detection). When the parity control is enabled, the computed parity is inserted at the MSB position (9th bit if M=1; 8th bit if M=0) and parity is checked on the received data. This bit is set and cleared by software. Once it is set, PCE is active after the current byte (in reception and in transmission). -0: Parity control disabled -1: Parity control enabled This bit field can only be written when the USART is disabled (UE=0).
$00000800 constant USART_CR1_WAKE                                   \ WAKE: Receiver wakeup method This bit determines the USART wakeup method from Mute mode. It is set or cleared by software. -0: Idle line -1: Address mark This bit field can only be written when the USART is disabled (UE=0).
$00001000 constant USART_CR1_M_0                                    \ M0: Word length This bit, with bit 28 (M1) determine the word length. It is set or cleared by software. See Bit -28 (M1)description. This bit can only be written when the USART is disabled (UE=0).
$00002000 constant USART_CR1_MME                                    \ MME: Mute mode enable This bit activates the mute mode function of the USART. When set, the USART can switch between the active and mute modes, as defined by the WAKE bit. It is set and cleared by software. -0: Receiver in active mode permanently -1: Receiver can switch between mute mode and active mode
$00004000 constant USART_CR1_CMIE                                   \ CMIE: Character match interrupt enable This bit is set and cleared by software. -0: Interrupt is inhibited -1: A USART interrupt is generated when the CMF bit is set in the USART_ISR register.
$00008000 constant USART_CR1_OVER8                                  \ OVER8: Oversampling mode -0: Oversampling by 16 This bit can only be written when the USART is disabled (UE=0).
$001f0000 constant USART_CR1_DEDT                                   \ DEDT[4:0]: Driver Enable deassertion time This 5-bit value defines the time between the end of the last stop bit, in a transmitted message, and the de-activation of the DE (Driver Enable) signal. It is expressed in sample time units (1/8 or 1/16 bit time, depending on the oversampling rate). If the USART_TDR register is written during the DEDT time, the new data is transmitted only when the DEDT and DEAT times have both elapsed. This bit field can only be written when the USART is disabled (UE=0).
$03e00000 constant USART_CR1_DEAT                                   \ DEAT[4:0]: Driver Enable assertion time This 5-bit value defines the time between the activation of the DE (Driver Enable) signal and the beginning of the start bit. It is expressed in sample time units (1/8 or 1/16 bit time, depending on the oversampling rate). This bit field can only be written when the USART is disabled (UE=0).
$04000000 constant USART_CR1_RTOIE                                  \ RTOIE: Receiver timeout interrupt enable This bit is set and cleared by software. -0: Interrupt is inhibited -1: An USART interrupt is generated when the RTOF bit is set in the USART_ISR register
$08000000 constant USART_CR1_EOBIE                                  \ EOBIE: End of Block interrupt enable This bit is set and cleared by software.
$10000000 constant USART_CR1_M_1                                    \ Word length This bit, with bit 12 (M0) determine the word length. It is set or cleared by software. M[1:0] = 00: 1 Start bit, 8 Data bits, n Stop bit M[1:0] = 01: 1 Start bit, 9 Data bits, n Stop bit M[1:0] = 10: 1 Start bit, 7 Data bits, n Stop bit This bit can only be written when the USART is disabled (UE=0).s
$20000000 constant USART_CR1_FIFOEN                                 \ FIFOEN :FIFO mode enable This bit is set and cleared by software. -0: FIFO mode is disabled. -1: FIFO mode is enabled.
$40000000 constant USART_CR1_TXFEIE                                 \ TXFEIE :TXFIFO empty interrupt enable This bit is set and cleared by software. -0: Interrupt is inhibited -1: An USART interrupt is generated when TXFE=1 in the USART_ISR register
$80000000 constant USART_CR1_RXFFIE                                 \ RXFFIE :RXFIFO Full interrupt enable This bit is set and cleared by software. -0: Interrupt is inhibited -1: An USART interrupt is generated when RXFF=1 in the USART_ISR register


\
\ @brief CR2 register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant USART_CR2_SLVEN                                  \ SLVEN: Synchronous Slave mode enable When the SLVEN bit is set, the synchronous slave mode is enabled. -0: Slave mode disabled. -1: Slave mode enabled. Note: When SPI slave mode is not supported, this bit is reserved and must be kept at reset value
$00000008 constant USART_CR2_DIS_NSS                                \ DIS_NSS When the DSI_NSS bit is set, the NSS pin input will be ignored. -0: SPI slave selection depends on NSS input pin. -1: SPI slave will be always selected and NSS input pin will be ignored. Note: When SPI slave mode is not supported, this bit is reserved and must be kept at reset value
$00000010 constant USART_CR2_ADDM7                                  \ ADDM7:7-bit Address Detection/4-bit Address Detection This bit is for selection between 4-bit address detection or 7-bit address detection. -0: 4-bit address detection -1: 7-bit address detection (in 8-bit data mode) This bit can only be written when the USART is disabled (UE=0)
$00000020 constant USART_CR2_LBDL                                   \ LBDL: LIN break detection length This bit is for selection between 11 bit or 10 bit break detection. -0: 10-bit break detection -1: 11-bit break detection This bit can only be written when the USART is disabled (UE=0).
$00000040 constant USART_CR2_LBDIE                                  \ LBDIE: LIN break detection interrupt enable Break interrupt mask (break detection using break delimiter). -0: Interrupt is inhibited -1: An interrupt is generated whenever LBDF=1 in the USART_ISR register
$00000100 constant USART_CR2_LBCL                                   \ LBCL: Last bit clock pulse This bit is used to select whether the clock pulse associated with the last data bit transmitted (MSB) has to be output on the SCLK pin in synchronous mode. -0: The clock pulse of the last data bit is not output to the SCLK pin -1: The clock pulse of the last data bit is output to the SCLK pin Caution: The last bit is the 7th or 8th or 9th data bit transmitted depending on the 7 or 8 or 9 bit format selected by the M bit in the USART_CR1 register. This bit can only be written when the USART is disabled (UE=0).
$00000200 constant USART_CR2_CPHA                                   \ CPHA: Clock phase This bit is used to select the phase of the clock output on the SCLK pin in synchronous mode. It works in conjunction with the CPOL bit to produce the desired clock/data relationship (see Figure 137 and Figure 138) -0: The first clock transition is the first data capture edge -1: The second clock transition is the first data capture edge This bit can only be written when the USART is disabled (UE=0).
$00000400 constant USART_CR2_CPOL                                   \ CPOL: Clock polarity This bit allows the user to select the polarity of the clock output on the SCLK pin in synchronous mode. It works in conjunction with the CPHA bit to produce the desired clock/data relationship -0: Steady low value on SCLK pin outside transmission window -1: Steady high value on SCLK pin outside transmission window This bit can only be written when the USART is disabled (UE=0).
$00000800 constant USART_CR2_CLKEN                                  \ CLKEN: Clock enable This bit allows the user to enable the SCLK pin. -0: SCLK pin disabled -1: SCLK pin enabled This bit can only be written when the USART is disabled (UE=0). Note: If neither synchronous mode nor Smartcard mode is supported, this bit is reserved and forced by hardware to 0'. Please refer to Section 23.4: USART implementation on page 483. Note: In Smartcard mode, in order to provide correctly the SCLK clock to the smartcard, the steps below must be respected: - UE = 0 - SCEN = 1 - GTPR configuration - CLKEN= 1 - UE = 1
$00003000 constant USART_CR2_STOP                                   \ STOP[1:0]: STOP bits These bits are used for programming the stop bits. -00: 1 stop bit -01: 0.5 stop bit. -10: 2 stop bits -11: 1.5 stop bits This bit field can only be written when the USART is disabled (UE=0).
$00004000 constant USART_CR2_LINEN                                  \ LINEN: LIN mode enable This bit is set and cleared by software. -0: LIN mode disabled -1: LIN mode enabled The LIN mode enables the capability to send LIN Synch Breaks (13 low bits) using the SBKRQ bit in the USART_CR1 register, and to detect LIN Sync breaks. This bit field can only be written when the USART is disabled (UE=0).
$00008000 constant USART_CR2_SWAP                                   \ SWAP: Swap TX/RX pins This bit is set and cleared by software. -0: TX/RX pins are used as defined in standard pinout -1: The TX and RX pins functions are swapped. This allows to work in the case of a cross-wired connection to another UART. This bit field can only be written when the USART is disabled (UE=0).
$00010000 constant USART_CR2_RXINV                                  \ RXINV: RX pin active level inversion This bit is set and cleared by software. -0: RX pin signal works using the standard logic levels (VDD =1/idle, Gnd=0/mark) -1: RX pin signal values are inverted. ((VDD =0/mark, Gnd=1/idle). This allows the use of an external inverter on the RX line. This bit field can only be written when the USART is disabled (UE=0).
$00020000 constant USART_CR2_TXINV                                  \ TXINV: TX pin active level inversion This bit is set and cleared by software. -0: TX pin signal works using the standard logic levels (VDD =1/idle, Gnd=0/mark) -1: TX pin signal values are inverted. ((VDD =0/mark, Gnd=1/idle). This allows the use of an external inverter on the TX line. This bit field can only be written when the USART is disabled (UE=0).
$00040000 constant USART_CR2_DATAINV                                \ DATAINV: Binary data inversion This bit is set and cleared by software. -0: Logical data from the data register are send/received in positive/direct logic. (1=H, 0=L) -1: Logical data from the data register are send/received in negative/inverse logic. (1=L, 0=H). The parity bit is also inverted. This bit field can only be written when the USART is disabled (UE=0).
$00080000 constant USART_CR2_MSBFIRST                               \ MSBFIRST: Most significant bit first This bit is set and cleared by software. -0: data is transmitted/received with data bit 0 first, following the start bit. -1: data is transmitted/received with the MSB (bit 7/8) first, following the start bit. This bit field can only be written when the USART is disabled (UE=0).
$00100000 constant USART_CR2_ABREN                                  \ ABREN: Auto baud rate enable This bit is set and cleared by software. -0: Auto baud rate detection is disabled. -1: Auto baud rate detection is enabled.
$00600000 constant USART_CR2_ABRMOD                                 \ ABRMOD[1:0]: Auto baud rate mode These bits are set and cleared by software. -00: Measurement of the start bit is used to detect the baud rate. -01: Falling edge to falling edge measurement. (the received frame must start with a single bit = 1 -> Frame = Start10xxxxxx) -10: 0x7F frame detection. -11: 0x55 frame detection This bit field can only be written when ABREN = 0 or the USART is disabled (UE=0).
$00800000 constant USART_CR2_RTOEN                                  \ RTOEN: Receiver timeout enable This bit is set and cleared by software. -0: Receiver timeout feature disabled. -1: Receiver timeout feature enabled. When this feature is enabled, the RTOF flag in the USART_ISR register is set if the RX line is idle (no reception) for the duration programmed in the RTOR (receiver timeout register).
$ff000000 constant USART_CR2_ADD                                    \ ADD[7:0]: Address of the USART node This bit-field gives the address of the USART node or a character code to be recognized. This is used in multiprocessor communication during Mute mode or Stop mode, for wakeup with 7- bit address mark detection. The MSB of the character sent by the transmitter should be equal to 1. It may also be used for character detection during normal reception, Mute mode inactive (for example, end of block detection in ModBus protocol). In this case, the whole received character (8- bit) is compared to the ADD[7:0] value and CMF flag is set on match. This bit field can only be written when reception is disabled (RE = 0) or the USART is disabled (UE=0)


\
\ @brief CR3 register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000001 constant USART_CR3_EIE                                    \ EIE: Error interrupt enable Error Interrupt Enable Bit is required to enable interrupt generation in case of a framing error, overrun error noise flag or SPI slave underrun error (FE=1 or ORE=1 or NF=1or UDR = 1 in the USART_ISR register). -0: Interrupt is inhibited -1: An interrupt is generated when FE=1 or ORE=1 or NF=1 or UDR = 1 (in SPI slave mode) in the USART_ISR register.
$00000002 constant USART_CR3_IREN                                   \ IREN: IrDA mode enable This bit is set and cleared by software. -0: IrDA disabled -1: IrDA enabled This bit can only be written when the USART is disabled (UE=0).
$00000004 constant USART_CR3_IRLP                                   \ IRLP: IrDA low-power This bit is used for selecting between normal and low-power IrDA modes -0: Normal mode -1: Low-power mode This bit can only be written when the USART is disabled (UE=0).
$00000008 constant USART_CR3_HDSEL                                  \ HDSEL: Half-duplex selection Selection of Single-wire Half-duplex mode -0: Half duplex mode is not selected -1: Half duplex mode is selected This bit can only be written when the USART is disabled (UE=0).
$00000010 constant USART_CR3_NACK                                   \ NACK: Smartcard NACK enable -0: NACK transmission in case of parity error is disabled -1: NACK transmission during parity error is enabled This bit field can only be written when the USART is disabled (UE=0).
$00000020 constant USART_CR3_SCEN                                   \ SCEN: Smartcard mode enable This bit is used for enabling Smartcard mode. -0: Smartcard Mode disabled -1: Smartcard Mode enabled This bit field can only be written when the USART is disabled (UE=0).
$00000040 constant USART_CR3_DMAR                                   \ DMAR: DMA enable receiver This bit is set/reset by software -1: DMA mode is enabled for reception -0: DMA mode is disabled for reception
$00000080 constant USART_CR3_DMAT                                   \ DMAT: DMA enable transmitter This bit is set/reset by software -1: DMA mode is enabled for transmission -0: DMA mode is disabled for transmission
$00000100 constant USART_CR3_RTSE                                   \ RTSE: RTS enable -0: RTS hardware flow control disabled -1: RTS output enabled, data is only requested when there is space in the receive buffer. The transmission of data is expected to cease after the current character has been transmitted. The nRTS output is asserted (pulled to 0) when data can be received. This bit can only be written when the USART is disabled (UE=0).
$00000200 constant USART_CR3_CTSE                                   \ CTSE: CTS enable -0: CTS hardware flow control disabled -1: CTS mode enabled, data is only transmitted when the nCTS input is asserted (tied to 0). If the nCTS input is deasserted while data is being transmitted, then the transmission is completed before stopping. If data is written into the data register while nCTS is asserted, the transmission is postponed until nCTS is asserted. This bit can only be written when the USART is disabled (UE=0)
$00000400 constant USART_CR3_CTSIE                                  \ CTSIE: CTS interrupt enable -0: Interrupt is inhibited -1: An interrupt is generated whenever CTSIF=1 in the USART_ISR register
$00000800 constant USART_CR3_ONEBIT                                 \ ONEBIT: One sample bit method enable This bit allows the user to select the sample method. When the one sample bit method is selected the noise detection flag (NF) is disabled. -0: Three sample bit method -1: One sample bit method This bit can only be written when the USART is disabled (UE=0).
$00001000 constant USART_CR3_OVRDIS                                 \ OVRDIS: Overrun Disable This bit is used to disable the receive overrun detection. -0: Overrun Error Flag, ORE, is set when received data is not read before receiving new data. -1: Overrun functionality is disabled. If new data is received while the RXNE flag is still set the ORE flag is not set and the new received data overwrites the previous content of the USART_RDR register. When FIFO mode is enabled, the RXFIFO will be bypassed and data will be written directly in USARTx_RDR register. Even when FIFO management is enabled, the RXNE flag is to be used. This bit can only be written when the USART is disabled (UE=0).
$00002000 constant USART_CR3_DDRE                                   \ DDRE: DMA Disable on Reception Error -0: DMA is not disabled in case of reception error. The corresponding error flag is set but RXNE is kept 0 preventing from overrun. As a consequence, the DMA request is not asserted, so the erroneous data is not transferred (no DMA request), but next correct received data will be transferred. (used for Smartcard mode) -1: DMA is disabled following a reception error. The corresponding error flag is set, as well as RXNE. The DMA request is masked until the error flag is cleared. This means that the software must first disable the DMA request (DMAR = 0) or clear RXNE(RXFNE is case FIFO mode is enabled) before clearing the error flag. This bit can only be written when the USART is disabled (UE=0).
$00004000 constant USART_CR3_DEM                                    \ DEM: Driver enable mode This bit allows the user to activate the external transceiver control, through the DE signal. -0: DE function is disabled. -1: DE function is enabled. The DE signal is output on the RTS pin. This bit can only be written when the USART is disabled (UE=0).
$00008000 constant USART_CR3_DEP                                    \ DEP: Driver enable polarity selection -0: DE signal is active high. -1: DE signal is active low. This bit can only be written when the USART is disabled (UE=0).
$000e0000 constant USART_CR3_SCARCNT                                \ SCARCNT[2:0]: Smartcard auto-retry count This bit-field specifies the number of retries in transmit and receive, in Smartcard mode. In transmission mode, it specifies the number of automatic retransmission retries, before generating a transmission error (FE bit set). In reception mode, it specifies the number or erroneous reception trials, before generating a reception error (RXNE/RXFNE and PE bits set). This bit field must be programmed only when the USART is disabled (UE=0). When the USART is enabled (UE=1), this bit field may only be written to 0x0, in order to stop retransmission. -0x0: retransmission disabled - No automatic retransmission in transmit mode. -0x1 to 0x7: number of automatic retransmission attempts (before signaling error)
$00800000 constant USART_CR3_TXFTIE                                 \ TXFTIE: TXFIFO threshold interrupt enable This bit is set and cleared by software. -0: Interrupt is inhibited -1: An USART interrupt is generated when TXFIFO reaches the threshold programmed in TXFTCFG.
$01000000 constant USART_CR3_TCBGTIE                                \ TCBGTIE: Transmission Complete before guard time, interrupt enable This bit is set and cleared by software. -0: Interrupt is inhibited -1: An USART interrupt is generated whenever TCBGT=1 in the USARTx_ISR register
$0e000000 constant USART_CR3_RXFTCFG                                \ RXFTCFG: Receive FIFO threshold configuration -000:Receive FIFO reaches 1/8 of its depth. -001:Receive FIFO reaches 1/4 of its depth. -010:Receive FIFO reaches 1/2 of its depth. -011:Receive FIFO reaches 3/4 of its depth. -100:Receive FIFO reaches 7/8 of its depth. -101:Receive FIFO becomes full. Remaining combinations: Reserved.
$10000000 constant USART_CR3_RXFTIE                                 \ RXFTIE: RXFIFO threshold interrupt enable This bit is set and cleared by software. -0: Interrupt is inhibited -1: An USART interrupt is generated when Receive FIFO reaches the threshold programmed in RXFTCFG.
$e0000000 constant USART_CR3_TXFTCFG                                \ TXFTCFG: TXFIFO threshold configuration -000:TXFIFO reaches 1/8 of its depth. -001:TXFIFO reaches 1/4 of its depth. -010:TXFIFO reaches 1/2 of its depth. -011:TXFIFO reaches 3/4 of its depth. -100:TXFIFO reaches 7/8 of its depth. -101:TXFIFO becomes empty. Remaining combinations: Reserved.


\
\ @brief BRR register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$0000ffff constant USART_BRR_BRR                                    \ BRR[15:4] BRR[15:4] = USARTDIV[15:4]BRR[3:0] When OVER8 = 0, BRR[3:0] = USARTDIV[3:0]. When OVER8 = 1: BRR[2:0] = USARTDIV[3:0] shifted 1 bit to the right. BRR[3] must be kept cleared


\
\ @brief GTPR register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$000000ff constant USART_GTPR_PSC                                   \ PSC[7:0]: Prescaler value In IrDA Low-power and normal IrDA mode: PSC[7:0] = IrDA Normal and Low-Power Baud Rate Used for programming the prescaler for dividing the USART source clock to achieve the lowpower frequency: The source clock is divided by the value given in the register (8 significant bits): -00000000: Reserved - do not program this value -00000001: divides the source clock by 1 -00000010: divides the source clock by 2 ... In Smartcard mode: PSC[4:0]: Prescaler value Used for programming the prescaler for dividing the USART source clock to provide the Smartcard clock. The value given in the register (5 significant bits) is multiplied by 2 to give the division factor of the source clock frequency: -00000: Reserved - do not program this value -00001: divides the source clock by 2 -00010: divides the source clock by 4 -00011: divides the source clock by 6 ... This bit field can only be written when the USART is disabled (UE=0).
$0000ff00 constant USART_GTPR_GT                                    \ GT[7:0]: Guard time value This bit-field is used to program the Guard time value in terms of number of baud clock periods. This is used in Smartcard mode. The Transmission Complete flag is set after this guard time value. This bit field can only be written when the USART is disabled (UE=0).


\
\ @brief RTOR register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00ffffff constant USART_RTOR_RTO                                   \ RTO[23:0]: Receiver timeout value This bit-field gives the Receiver timeout value in terms of number of baud clocks. In standard mode, the RTOF flag is set if, after the last received character, no new start bit is detected for more than the RTO value. In Smartcard mode, this value is used to implement the CWT and BWT. See Smartcard chapter for more details. In the standard, the CWT/BWT measurement is done starting from the Start Bit of the last received character.
$ff000000 constant USART_RTOR_BLEN                                  \ BLEN[7:0]: Block Length This bit-field gives the Block length in Smartcard T=1 Reception. Its value equals the number of information characters + the length of the Epilogue Field (1-LEC/2-CRC) - 1. Examples: BLEN = 0 -> 0 information characters + LEC BLEN = 1 -> 0 information characters + CRC BLEN = 255 -> 254 information characters + CRC (total 256 characters)) In Smartcard mode, the Block length counter is reset when TXE=0 (TXFE = 0 in case FIFO mode is enabled). This bit-field can be used also in other modes. In this case, the Block length counter is reset when RE=0 (receiver disabled) and/or when the EOBCF bit is written to 1.


\
\ @brief RQR register
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000001 constant USART_RQR_ABRRQ                                  \ ABRRQ: Auto baud rate request Writing 1 to this bit resets the ABRF flag in the USART_ISR and request an automatic baud rate measurement on the next received data frame.
$00000002 constant USART_RQR_SBKRQ                                  \ SBKRQ: Send break request Writing 1 to this bit sets the SBKF flag and request to send a BREAK on the line, as soon as the transmit machine is available.
$00000004 constant USART_RQR_MMRQ                                   \ MMRQ: Mute mode request Writing 1 to this bit puts the USART in mute mode and resets the RWU flag.
$00000008 constant USART_RQR_RXFRQ                                  \ RXFRQ: Receive data flush request Writing 1 to this bit empties the entire receive FIFO i.e. clears the bit RXFNE. This allows to discard the received data without reading them, and avoid an overrun condition.
$00000010 constant USART_RQR_TXFRQ                                  \ TXFRQ: Transmit data flush request When FIFO mode is disabled, Writing 1 to this bit sets the TXE flag. This allows to discard the transmit data. This bit must be used only in Smartcard mode, when data has not been sent due to errors (NACK) and the FE flag is active in the USART_ISR register. If the USART does not support Smartcard mode, this bit is reserved and forced by hardware to 0' When FIFO is enabled, TXFRQ bit is set to flush the whole FIFO . This will set the flag TXFE (Transmit FIFO empty, bit 23 in the USART_ISR register). Flushing the Transmit FIFO is supported in both UART and Smartcard modes.


\
\ @brief ISR register
\ Address offset: 0x1C
\ Reset value: 0x000000C0
\

$00000001 constant USART_ISR_PE                                     \ PE: Parity error This bit is set by hardware when a parity error occurs in receiver mode. It is cleared by software, writing 1 to the PECF in the USART_ICR register. An interrupt is generated if PEIE = 1 in the USART_CR1 register. -0: No parity error -1: Parity error
$00000002 constant USART_ISR_FE                                     \ FE: Framing error This bit is set by hardware when a de-synchronization, excessive noise or a break character is detected. It is cleared by software, writing 1 to the FECF bit in the USART_ICR register. In Smartcard mode, in transmission, this bit is set when the maximum number of transmit attempts is reached without success (the card NACKs the data frame). An interrupt is generated if EIE = 1 in the USART_CR1 register. -0: No Framing error is detected -1: Framing error or break character is detected
$00000004 constant USART_ISR_NF                                     \ NF: START bit Noise detection flag This bit is set by hardware when noise is detected on a received frame. It is cleared by software, writing 1 to the NFCF bit in the USART_ICR register. -0: No noise is detected -1: Noise is detected
$00000008 constant USART_ISR_ORE                                    \ ORE: Overrun error This bit is set by hardware when the data currently being received in the shift register is ready to be transferred into the USARTx_RDR register while RXNE=1 (RXFF = 1 in case FIFO mode is enabled) . It is cleared by a software, writing 1 to the ORECF, in the USARTx_ICR register. An interrupt is generated if RXNEIE/ RXFNEIE=1 or EIE = 1 in the USARTx_CR1 register. -0: No overrun error -1: Overrun error is detected
$00000010 constant USART_ISR_IDLE                                   \ IDLE: Idle line detected This bit is set by hardware when an Idle Line is detected. An interrupt is generated if IDLEIE=1 in the USART_CR1 register. It is cleared by software, writing 1 to the IDLECF in the USART_ICR register. -0: No Idle line is detected -1: Idle line is detected
$00000020 constant USART_ISR_RXNE_RXFNE                             \ RXNE/RXFNE:Read data register not empty/RXFIFO not empty RXNE bit is set by hardware when the content of the USARTx_RDR shift register has been transferred to the USARTx_RDR register. It is cleared by a read to the USARTx_RDR register. The RXNE flag can also be cleared by writing 1 to the RXFRQ in the USARTx_RQR register. RXFNE bit is set by hardware when the RXFIFO is not empty, and so data can be read from the USART_RDR register. Every read of the USART_RDR frees a location in the RXFIFO. It is cleared when the RXFIFO is empty. The RXNE/RXFNE flag can also be cleared by writing 1 to the RXFRQ in the USART_RQR register. An interrupt is generated if RXNEIE/RXFNEIE=1 in the USART_CR1 register. -0: Data is not received -1: Received data is ready to be read.
$00000040 constant USART_ISR_TC                                     \ TC: Transmission complete This bit indicates when the last data written in the USART_TDR has been transmitted out of the shift register. It is set by hardware if the transmission of a frame containing data is complete and if TXE/TXFE is set. An interrupt is generated if TCIE=1 in the USART_CR1 register. It is cleared by software, writing 1 to the TCCF in the USART_ICR register or by a write to the USART_TDR register. An interrupt is generated if TCIE=1 in the USART_CR1 register. -0: Transmission is not complete -1: Transmission is complete
$00000080 constant USART_ISR_TXE_TXFNF                              \ TXE/TXFNF: Transmit data register empty/TXFIFO not full When FIFO mode is disabled, TXE is set by hardware when the content of the USARTx_TDR register has been transferred into the shift register. It is cleared by a write to the USARTx_TDR register. The TXE flag can also be set by writing 1 to the TXFRQ in the USART_RQR register, in order to discard the data (only in Smartcard T=0 mode, in case of transmission failure). When FIFO mode is enabled, TXFNF is set by hardware when TXFIFO is not full, and so data can be written in the USART_TDR. Every write in the USART_TDR places the data in the TXFIFO. This flag remains set until the TXFIFO is full. When the TXFIFO is full, this flag is cleared indicating that data can not be written into the USART_TDR. Note: The TXFNF is kept reset during the flush request until TXFIFO is empty . After sending the flush request (by setting TXFRQ bit), the flag TXFNF should be checked prior to writing in TXFIFO. (TXFNF and TXFE will be set at the same time). An interrupt is generated if the TXEIE/TXFNFIE bit =1 in the USART_CR1 register. -0: Data register is full/Transmit FIFO is full. -1: Data register/Transmit FIFO is not full
$00000100 constant USART_ISR_LBDF                                   \ LBDF: LIN break detection flag This bit is set by hardware when the LIN break is detected. It is cleared by software, by writing 1 to the LBDCF in the USART_ICR. An interrupt is generated if LBDIE = 1 in the USART_CR2 register. -0: LIN Break not detected -1: LIN break detected
$00000200 constant USART_ISR_CTSIF                                  \ CTSIF: CTS interrupt flag This bit is set by hardware when the nCTS input toggles, if the CTSE bit is set. It is cleared by software, by writing 1 to the CTSCF bit in the USART_ICR register. An interrupt is generated if CTSIE=1 in the USART_CR3 register. -0: No change occurred on the nCTS status line -1: A change occurred on the nCTS status line
$00000400 constant USART_ISR_CTS                                    \ CTS: CTS flag This bit is set/reset by hardware. It is an inverted copy of the status of the nCTS input pin. -0: nCTS line set -1: nCTS line reset
$00000800 constant USART_ISR_RTOF                                   \ RTOF: Receiver timeout This bit is set by hardware when the timeout value, programmed in the RTOR register has lapsed, without any communication. It is cleared by software, writing 1 to the RTOCF bit in the USART_ICR register. An interrupt is generated if RTOIE=1 in the USART_CR2 register. In Smartcard mode, the timeout corresponds to the CWT or BWT timings. -0: Timeout value not reached -1: Timeout value reached without any data reception
$00001000 constant USART_ISR_EOBF                                   \ EOBF: End of block flag This bit is set by hardware when a complete block has been received (for example T=1 Smartcard mode). The detection is done when the number of received bytes (from the start of the block, including the prologue) is equal or greater than BLEN + 4. An interrupt is generated if the EOBIE=1 in the USART_CR2 register. It is cleared by software, writing 1 to the EOBCF in the USART_ICR register. -0: End of Block not reached -1: End of Block (number of characters) reached
$00002000 constant USART_ISR_UDR                                    \ UDR: SPI slave underrun error flag In slave transmission mode, this flag is set when the first clock for data transmission appears while the software has not yet loaded any value into USARTx_DR. -0: No underrun error -1: underrun error
$00004000 constant USART_ISR_ABRE                                   \ ABRE: Auto baud rate error This bit is set by hardware if the baud rate measurement failed (baud rate out of range or character comparison failed) It is cleared by software, by writing 1 to the ABRRQ bit in the USART_CR3 register
$00008000 constant USART_ISR_ABRF                                   \ ABRF: Auto baud rate flag This bit is set by hardware when the automatic baud rate has been set (RXNE will also be set, generating an interrupt if RXNEIE = 1) or when the auto baud rate operation was completed without success (ABRE=1) (ABRE, RXNE and FE are also set in this case) It is cleared by software, in order to request a new auto baud rate detection, by writing 1 to the ABRRQ in the USART_RQR register.
$00010000 constant USART_ISR_BUSY                                   \ BUSY: Busy flag This bit is set and reset by hardware. It is active when a communication is ongoing on the RX line (successful start bit detected). It is reset at the end of the reception (successful or not). -0: USART is idle (no reception) -1: Reception on going
$00020000 constant USART_ISR_CMF                                    \ CMF: Character match flag This bit is set by hardware, when a the character defined by ADD[7:0] is received. It is cleared by software, writing 1 to the CMCF in the USART_ICR register. An interrupt is generated if CMIE=1in the USART_CR1 register. -0: No Character match detected -1: Character Match detected
$00040000 constant USART_ISR_SBKF                                   \ SBKF: Send break flag This bit indicates that a send break character was requested. It is set by software, by writing 1 to the SBKRQ bit in the USART_CR3 register. It is automatically reset by hardware during the stop bit of break transmission. -0: No break character is transmitted -1: Break character will be transmitted
$00080000 constant USART_ISR_RWU                                    \ RWU: Receiver wakeup from Mute mode This bit indicates if the USART is in mute mode. It is cleared/set by hardware when a wakeup/mute sequence is recognized. The mute mode control sequence (address or IDLE) is selected by the WAKE bit in the USART_CR1 register. When wakeup on IDLE mode is selected, this bit can only be set by software, writing 1 to the MMRQ bit in the USART_RQR register. -0: Receiver in active mode -1: Receiver in mute mode
$00200000 constant USART_ISR_TEACK                                  \ TEACK: Transmit enable acknowledge flag This bit is set/reset by hardware, when the Transmit Enable value is taken into account by the USART. It can be used when an idle frame request is generated by writing TE=0, followed by TE=1 in the USART_CR1 register, in order to respect the TE=0 minimum period.
$00400000 constant USART_ISR_REACK                                  \ REACK: Receive enable acknowledge flag This bit is set/reset by hardware, when the Receive Enable value is taken into account by the USART. It can be used to verify that the USART is ready for reception before entering Stop mode.
$00800000 constant USART_ISR_TXFE                                   \ TXFE: TXFIFO Empty This bit is set by hardware when TXFIFO is Empty. When the TXFIFO contains at least one data, this flag is cleared. The TXFE flag can also be set by writing 1 to the bit TXFRQ (bit 4) in the USART_RQR register. An interrupt is generated if the TXFEIE bit =1 (bit 30) in the USART_CR1 register. -0: TXFIFO is not empty. -1: TXFIFO is empty.
$01000000 constant USART_ISR_RXFF                                   \ RXFF: RXFIFO Full This bit is set by hardware when RXFIFO is Full. An interrupt is generated if the RXFFIE bit =1 in the USART_CR1 register. -0: RXFIFO is not Full. -1: RXFIFO is Full.
$02000000 constant USART_ISR_TCBGT                                  \ TCBGT: Transmission complete before guard time flagl This bit indicates when the last data written in the USART_TDR has been transmitted correctly out of the shift register . It is set by hardware in Smartcard mode, if the transmission of a frame containing data is complete and if there is no NACK from the smartcard. An interrupt is generated if TCBGTIE=1 in the USART_CR3 register. It is cleared by software, writing 1 to the TCBGTCF in the USART_ICR register or by a write to the USART_TDR register. -0: Transmission is not complete or transmission is complete unsuccessfuly (i.e. a NACK is received from the card) -1: Transmission is complete successfully (before Guard time completion and there is no NACK from the smart card).
$04000000 constant USART_ISR_RXFT                                   \ RXFT: RXFIFO threshold flag This bit is set by hardware when the programmed threshold in RXFTCFG in USARTx_CR3 register is reached. This means that there are (RXFTCFG - 1) data in the Receive FIFO and one data in the USART_RDR register. An interrupt is generated if the RXFTIE bit =1 (bit 27) in the USART_CR3 register. -0: Receive FIFO doesn't reach the programmed threshold. -1: Receive FIFO reached the programmed threshold
$08000000 constant USART_ISR_TXFT                                   \ TXFT: TXFIFO threshold flag This bit is set by hardware when the TXFIFO reaches the programmed threshold in TXFTCFG in USARTx_CR3 register i.e. the TXFIFO contains TXFTCFG empty locations. An interrupt is generated if the TXFTIE bit =1 (bit 31) in the USART_CR3 register. -0: TXFIFO doesn't reach the programmed threshold. -1: TXFIFO reached the programmed threshold


\
\ @brief ICR register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000001 constant USART_ICR_PECF                                   \ PECF: Parity error clear flag Writing 1 to this bit clears the PE flag in the USART_ISR register.
$00000002 constant USART_ICR_FECF                                   \ FECF: Framing error clear flag Writing 1 to this bit clears the FE flag in the USART_ISR register
$00000004 constant USART_ICR_NECF                                   \ NECF: Noise detected clear flag Writing 1 to this bit clears the NF flag in the USART_ISR register.
$00000008 constant USART_ICR_ORECF                                  \ ORECF: Overrun error clear flag Writing 1 to this bit clears the ORE flag in the USART_ISR register.
$00000010 constant USART_ICR_IDLECF                                 \ IDLECF: Idle line detected clear flag Writing 1 to this bit clears the IDLE flag in the USART_ISR register.
$00000020 constant USART_ICR_TXFECF                                 \ TXFECF: TXFIFO empty clear flag Writing 1 to this bit clears the TXFE flag in the USART_ISR register
$00000040 constant USART_ICR_TCCF                                   \ TCCF: Transmission complete clear flag Writing 1 to this bit clears the TC flag in the USART_ISR register
$00000080 constant USART_ICR_TCBGTCF                                \ TCBGTCF: Transmission complete before Guard time clear flag Writing 1 to this bit clears the TCBGT flag in the USART_ISR register.
$00000100 constant USART_ICR_LBDCF                                  \ LBDCF: LIN break detection clear flag Writing 1 to this bit clears the LBDF flag in the USART_ISR register.
$00000200 constant USART_ICR_CTSCF                                  \ CTSCF: CTS clear flag Writing 1 to this bit clears the CTSIF flag in the USART_ISR register
$00000800 constant USART_ICR_RTOCF                                  \ RTOCF: Receiver timeout clear flag Writing 1 to this bit clears the RTOF flag in the USART_ISR register.
$00001000 constant USART_ICR_EOBCF                                  \ EOBCF: End of block clear flag Writing 1 to this bit clears the EOBF flag in the USART_ISR register
$00002000 constant USART_ICR_UDRCF                                  \ UDRCF:SPI slave underrun clear flag Writing 1 to this bit clears the UDRF flag in the USART_ISR register
$00020000 constant USART_ICR_CMCF                                   \ CMCF: Character match clear flag Writing 1 to this bit clears the CMF flag in the USART_ISR register


\
\ @brief RDR register
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$000001ff constant USART_RDR_RDR                                    \ RDR[8:0]: Receive data value Contains the received data character. The RDR register provides the parallel interface between the input shift register and the internal bus (see Figure 124). When receiving with the parity enabled, the value read in the MSB bit is the received parity bit.


\
\ @brief TDR register
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$000001ff constant USART_TDR_TDR                                    \ TDR[8:0]: Transmit data value Contains the data character to be transmitted. The USARTx_TDR register provides the parallel interface between the internal bus and the output shift register (see Figure 124). When transmitting with the parity enabled (PCE bit set to 1 in the USART_CR1 register), the value written in the MSB (bit 7 or bit 8 depending on the data length) has no effect because it is replaced by the parity. Note: This register must be written only when TXE/TXFNF=1.


\
\ @brief PRESC register
\ Address offset: 0x2C
\ Reset value: 0x00000000
\

$0000000f constant USART_PRESC_PRESCALER                            \ PRESCALER[3:0]: Clock prescaler The USART input clock can be divided by a prescaler: -0000: input clock not divided -0001: input clock divided by 2 -0010: input clock divided by 4 -0011: input clock divided by 6 -0100: input clock divided by 8 -0101: input clock divided by 10 -0110: input clock divided by 12 -0111: input clock divided by 16 -1000: input clock divided by 32 -1001: input clock divided by 64 -1010: input clock divided by 128 -1011: input clock divided by 256 Remaing combinations: Reserved. Note: When PRESCALER is programmed with a value different of the allowed ones, programmed prescaler value will be '1011' i.e. input clock divided by 256


\
\ @brief USART interrupt
\
$41004000 constant USART_CR1      \ offset: 0x00 : CR1 register
$41004004 constant USART_CR2      \ offset: 0x04 : CR2 register
$41004008 constant USART_CR3      \ offset: 0x08 : CR3 register
$4100400c constant USART_BRR      \ offset: 0x0C : BRR register
$41004010 constant USART_GTPR     \ offset: 0x10 : GTPR register
$41004014 constant USART_RTOR     \ offset: 0x14 : RTOR register
$41004018 constant USART_RQR      \ offset: 0x18 : RQR register
$4100401c constant USART_ISR      \ offset: 0x1C : ISR register
$41004020 constant USART_ICR      \ offset: 0x20 : ICR register
$41004024 constant USART_RDR      \ offset: 0x24 : RDR register
$41004028 constant USART_TDR      \ offset: 0x28 : TDR register
$4100402c constant USART_PRESC    \ offset: 0x2C : PRESC register

