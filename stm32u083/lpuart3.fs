\
\ @file lpuart3.fs
\ @brief LPUART address block description
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief LPUART control register 1
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000001 constant LPUART3_LPUART_CR1_UE                            \ LPUART enable When this bit is cleared, the LPUART prescalers and outputs are stopped immediately, and current operations are discarded. The configuration of the LPUART is kept, but all the status flags, in the LPUART_ISR are reset. This bit is set and cleared by software. Note: To enter low-power mode without generating errors on the line, the TE bit must be reset before and the software must wait for the TC bit in the LPUART_ISR to be set before resetting the UE bit. Note: The DMA requests are also reset when UE = 0 so the DMA channel must be disabled before resetting the UE bit.
$00000002 constant LPUART3_LPUART_CR1_UESM                          \ LPUART enable in low-power mode When this bit is cleared, the LPUART cannot wake up the MCU from low-power mode. When this bit is set, the LPUART can wake up the MCU from low-power mode. This bit is set and cleared by software. Note: It is recommended to set the UESM bit just before entering low-power mode, and clear it when exiting low-power mode.
$00000004 constant LPUART3_LPUART_CR1_RE                            \ Receiver enable This bit enables the receiver. It is set and cleared by software.
$00000008 constant LPUART3_LPUART_CR1_TE                            \ Transmitter enable This bit enables the transmitter. It is set and cleared by software. Note: During transmission, a low pulse on the TE bit (0 followed by 1) sends a preamble (idle line) after the current word, except in Smartcard mode. In order to generate an idle character, the TE must not be immediately written to 1. To ensure the required duration, the software can poll the TEACK bit in the LPUART_ISR register. Note: In Smartcard mode, when TE is set, there is a 1 bit-time delay before the transmission starts.
$00000010 constant LPUART3_LPUART_CR1_IDLEIE                        \ IDLE interrupt enable This bit is set and cleared by software.
$00000020 constant LPUART3_LPUART_CR1_RXFNEIE                       \ RXFIFO not empty interrupt enable This bit is set and cleared by software.
$00000040 constant LPUART3_LPUART_CR1_TCIE                          \ Transmission complete interrupt enable This bit is set and cleared by software.
$00000080 constant LPUART3_LPUART_CR1_TXFNFIE                       \ TXFIFO not full interrupt enable This bit is set and cleared by software.
$00000100 constant LPUART3_LPUART_CR1_PEIE                          \ PE interrupt enable This bit is set and cleared by software.
$00000200 constant LPUART3_LPUART_CR1_PS                            \ Parity selection This bit selects the odd or even parity when the parity generation/detection is enabled (PCE bit set). It is set and cleared by software. The parity is selected after the current byte. This bitfield can only be written when the LPUART is disabled (UE=0).
$00000400 constant LPUART3_LPUART_CR1_PCE                           \ Parity control enable This bit selects the hardware parity control (generation and detection). When the parity control is enabled, the computed parity is inserted at the MSB position (9th bit if M=1; 8th bit if M=0) and parity is checked on the received data. This bit is set and cleared by software. Once it is set, PCE is active after the current byte (in reception and in transmission). This bitfield can only be written when the LPUART is disabled (UE=0).
$00000800 constant LPUART3_LPUART_CR1_WAKE                          \ Receiver wake-up method This bit determines the LPUART wake-up method from Mute mode. It is set or cleared by software. This bitfield can only be written when the LPUART is disabled (UE=0).
$00001000 constant LPUART3_LPUART_CR1_M0                            \ Word length This bit is used in conjunction with bit 28 (M1) to determine the word length. It is set or cleared by software (refer to bit 28 (M1) description). This bit can only be written when the LPUART is disabled (UE=0).
$00002000 constant LPUART3_LPUART_CR1_MME                           \ Mute mode enable This bit activates the Mute mode function of the LPUART. When set, the LPUART can switch between the active and Mute modes, as defined by the WAKE bit. It is set and cleared by software.
$00004000 constant LPUART3_LPUART_CR1_CMIE                          \ Character match interrupt enable This bit is set and cleared by software.
$001f0000 constant LPUART3_LPUART_CR1_DEDT                          \ Driver Enable deassertion time This 5-bit value defines the time between the end of the last stop bit, in a transmitted message, and the de-activation of the DE (Driver Enable) signal.It is expressed in lpuart_ker_ck clock cycles. For more details, refer Section132.4.14: RS232 Hardware flow control and RS485 Driver Enable. If the LPUART_TDR register is written during the DEDT time, the new data is transmitted only when the DEDT and DEAT times have both elapsed. This bitfield can only be written when the LPUART is disabled (UE=0).
$03e00000 constant LPUART3_LPUART_CR1_DEAT                          \ Driver Enable assertion time This 5-bit value defines the time between the activation of the DE (Driver Enable) signal and the beginning of the start bit. It is expressed in lpuart_ker_ck clock cycles. For more details, refer Section131.5.21: RS232 Hardware flow control and RS485 Driver Enable. This bitfield can only be written when the LPUART is disabled (UE=0).
$10000000 constant LPUART3_LPUART_CR1_M1                            \ Word length This bit must be used in conjunction with bit 12 (M0) to determine the word length. It is set or cleared by software. M[1:0] = 00: 1 Start bit, 8 Data bits, n Stop bit M[1:0] = 01: 1 Start bit, 9 Data bits, n Stop bit M[1:0] = 10: 1 Start bit, 7 Data bits, n Stop bit This bit can only be written when the LPUART is disabled (UE=0). Note: In 7-bit data length mode, the Smartcard mode, LIN master mode and auto baud rate (0x7F and 0x55 frames detection) are not supported.
$20000000 constant LPUART3_LPUART_CR1_FIFOEN                        \ FIFO mode enable This bit is set and cleared by software.
$40000000 constant LPUART3_LPUART_CR1_TXFEIE                        \ TXFIFO empty interrupt enable This bit is set and cleared by software.
$80000000 constant LPUART3_LPUART_CR1_RXFFIE                        \ RXFIFO Full interrupt enable This bit is set and cleared by software.


\
\ @brief LPUART control register 1
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000001 constant LPUART3_LPUART_CR1_ALTERNATE_UE                  \ LPUART enable When this bit is cleared, the LPUART prescalers and outputs are stopped immediately, and current operations are discarded. The configuration of the LPUART is kept, but all the status flags, in the LPUART_ISR are reset. This bit is set and cleared by software. Note: To enter low-power mode without generating errors on the line, the TE bit must be reset before and the software must wait for the TC bit in the LPUART_ISR to be set before resetting the UE bit. Note: The DMA requests are also reset when UE = 0 so the DMA channel must be disabled before resetting the UE bit.
$00000002 constant LPUART3_LPUART_CR1_ALTERNATE_UESM                \ LPUART enable in low-power mode When this bit is cleared, the LPUART cannot wake up the MCU from low-power mode. When this bit is set, the LPUART can wake up the MCU from low-power mode. This bit is set and cleared by software. Note: It is recommended to set the UESM bit just before entering low-power mode, and clear it when exiting low-power mode.
$00000004 constant LPUART3_LPUART_CR1_ALTERNATE_RE                  \ Receiver enable This bit enables the receiver. It is set and cleared by software.
$00000008 constant LPUART3_LPUART_CR1_ALTERNATE_TE                  \ Transmitter enable This bit enables the transmitter. It is set and cleared by software. Note: During transmission, a low pulse on the TE bit (0 followed by 1) sends a preamble (idle line) after the current word, except in Smartcard mode. In order to generate an idle character, the TE must not be immediately written to 1. To ensure the required duration, the software can poll the TEACK bit in the LPUART_ISR register. Note: In Smartcard mode, when TE is set, there is a 1 bit-time delay before the transmission starts.
$00000010 constant LPUART3_LPUART_CR1_ALTERNATE_IDLEIE              \ IDLE interrupt enable This bit is set and cleared by software.
$00000020 constant LPUART3_LPUART_CR1_ALTERNATE_RXNEIE              \ Receive data register not empty This bit is set and cleared by software.
$00000040 constant LPUART3_LPUART_CR1_ALTERNATE_TCIE                \ Transmission complete interrupt enable This bit is set and cleared by software.
$00000080 constant LPUART3_LPUART_CR1_ALTERNATE_TXEIE               \ Transmit data register empty This bit is set and cleared by software.
$00000100 constant LPUART3_LPUART_CR1_ALTERNATE_PEIE                \ PE interrupt enable This bit is set and cleared by software.
$00000200 constant LPUART3_LPUART_CR1_ALTERNATE_PS                  \ Parity selection This bit selects the odd or even parity when the parity generation/detection is enabled (PCE bit set). It is set and cleared by software. The parity is selected after the current byte. This bitfield can only be written when the LPUART is disabled (UE=0).
$00000400 constant LPUART3_LPUART_CR1_ALTERNATE_PCE                 \ Parity control enable This bit selects the hardware parity control (generation and detection). When the parity control is enabled, the computed parity is inserted at the MSB position (9th bit if M=1; 8th bit if M=0) and parity is checked on the received data. This bit is set and cleared by software. Once it is set, PCE is active after the current byte (in reception and in transmission). This bitfield can only be written when the LPUART is disabled (UE=0).
$00000800 constant LPUART3_LPUART_CR1_ALTERNATE_WAKE                \ Receiver wake-up method This bit determines the LPUART wake-up method from Mute mode. It is set or cleared by software. This bitfield can only be written when the LPUART is disabled (UE=0).
$00001000 constant LPUART3_LPUART_CR1_ALTERNATE_M0                  \ Word length This bit is used in conjunction with bit 28 (M1) to determine the word length. It is set or cleared by software (refer to bit 28 (M1) description). This bit can only be written when the LPUART is disabled (UE=0).
$00002000 constant LPUART3_LPUART_CR1_ALTERNATE_MME                 \ Mute mode enable This bit activates the Mute mode function of the LPUART. When set, the LPUART can switch between the active and Mute modes, as defined by the WAKE bit. It is set and cleared by software.
$00004000 constant LPUART3_LPUART_CR1_ALTERNATE_CMIE                \ Character match interrupt enable This bit is set and cleared by software.
$001f0000 constant LPUART3_LPUART_CR1_ALTERNATE_DEDT                \ Driver Enable deassertion time This 5-bit value defines the time between the end of the last stop bit, in a transmitted message, and the de-activation of the DE (Driver Enable) signal.It is expressed in lpuart_ker_ck clock cycles. For more details, refer Section132.4.14: RS232 Hardware flow control and RS485 Driver Enable. If the LPUART_TDR register is written during the DEDT time, the new data is transmitted only when the DEDT and DEAT times have both elapsed. This bitfield can only be written when the LPUART is disabled (UE=0).
$03e00000 constant LPUART3_LPUART_CR1_ALTERNATE_DEAT                \ Driver Enable assertion time This 5-bit value defines the time between the activation of the DE (Driver Enable) signal and the beginning of the start bit. It is expressed in lpuart_ker_ck clock cycles. For more details, refer Section131.5.21: RS232 Hardware flow control and RS485 Driver Enable. This bitfield can only be written when the LPUART is disabled (UE=0).
$10000000 constant LPUART3_LPUART_CR1_ALTERNATE_M1                  \ Word length This bit must be used in conjunction with bit 12 (M0) to determine the word length. It is set or cleared by software. M[1:0] = 00: 1 Start bit, 8 Data bits, n Stop bit M[1:0] = 01: 1 Start bit, 9 Data bits, n Stop bit M[1:0] = 10: 1 Start bit, 7 Data bits, n Stop bit This bit can only be written when the LPUART is disabled (UE=0). Note: In 7-bit data length mode, the Smartcard mode, LIN master mode and auto baud rate (0x7F and 0x55 frames detection) are not supported.
$20000000 constant LPUART3_LPUART_CR1_ALTERNATE_FIFOEN              \ FIFO mode enable This bit is set and cleared by software.


\
\ @brief LPUART control register 2
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000010 constant LPUART3_LPUART_CR2_ADDM7                         \ 7-bit Address Detection/4-bit Address Detection This bit is for selection between 4-bit address detection or 7-bit address detection. This bit can only be written when the LPUART is disabled (UE=0) Note: In 7-bit and 9-bit data modes, the address detection is done on 6-bit and 8-bit address (ADD[5:0] and ADD[7:0]) respectively.
$00003000 constant LPUART3_LPUART_CR2_STOP                          \ STOP bits These bits are used for programming the stop bits. This bitfield can only be written when the LPUART is disabled (UE=0).
$00008000 constant LPUART3_LPUART_CR2_SWAP                          \ Swap TX/RX pins This bit is set and cleared by software. This bitfield can only be written when the LPUART is disabled (UE=0).
$00010000 constant LPUART3_LPUART_CR2_RXINV                         \ RX pin active level inversion This bit is set and cleared by software. This enables the use of an external inverter on the RX line. This bitfield can only be written when the LPUART is disabled (UE=0).
$00020000 constant LPUART3_LPUART_CR2_TXINV                         \ TX pin active level inversion This bit is set and cleared by software. This enables the use of an external inverter on the TX line. This bitfield can only be written when the LPUART is disabled (UE=0).
$00040000 constant LPUART3_LPUART_CR2_DATAINV                       \ Binary data inversion This bit is set and cleared by software. This bitfield can only be written when the LPUART is disabled (UE=0).
$00080000 constant LPUART3_LPUART_CR2_MSBFIRST                      \ Most significant bit first This bit is set and cleared by software. This bitfield can only be written when the LPUART is disabled (UE=0).
$ff000000 constant LPUART3_LPUART_CR2_ADD                           \ Address of the LPUART node These bits give the address of the LPUART node in Mute mode or a character code to be recognized in low-power or Run mode: In Mute mode: they are used in multiprocessor communication to wake up from Mute mode with 4-bit/7-bit address mark detection. The MSB of the character sent by the transmitter should be equal to 1. In 4-bit address mark detection, only ADD[3:0] bits are used. In low-power mode: they are used for wake up from low-power mode on character match. When WUS[1:0] is programmed to 0b00 (WUF active on address match), the wake-up from low-power mode is performed when the received character corresponds to the character programmed through ADD[6:0] or ADD[3:0] bitfield (depending on ADDM7 bit), and WUF interrupt is enabled by setting WUFIE bit. The MSB of the character sent by transmitter should be equal to 1. In Run mode with Mute mode inactive (for example, end-of-block detection in ModBus protocol): the whole received character (8 bits) is compared to ADD[7:0] value and CMF flag is set on match. An interrupt is generated if the CMIE bit is set. These bits can only be written when the reception is disabled (RE1=10) or when the USART is disabled (UE1=10).


\
\ @brief LPUART control register 3
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000001 constant LPUART3_LPUART_CR3_EIE                           \ Error interrupt enable Error Interrupt Enable Bit is required to enable interrupt generation in case of a framing error, overrun error or noise flag (FE=1 or ORE=1 or NE=1 in the LPUART_ISR register).
$00000008 constant LPUART3_LPUART_CR3_HDSEL                         \ Half-duplex selection Selection of Single-wire Half-duplex mode This bit can only be written when the LPUART is disabled (UE=0).
$00000040 constant LPUART3_LPUART_CR3_DMAR                          \ DMA enable receiver This bit is set/reset by software
$00000080 constant LPUART3_LPUART_CR3_DMAT                          \ DMA enable transmitter This bit is set/reset by software
$00000100 constant LPUART3_LPUART_CR3_RTSE                          \ RTS enable This bit can only be written when the LPUART is disabled (UE=0).
$00000200 constant LPUART3_LPUART_CR3_CTSE                          \ CTS enable This bit can only be written when the LPUART is disabled (UE=0)
$00000400 constant LPUART3_LPUART_CR3_CTSIE                         \ CTS interrupt enable
$00001000 constant LPUART3_LPUART_CR3_OVRDIS                        \ Overrun Disable This bit is used to disable the receive overrun detection. the ORE flag is not set and the new received data overwrites the previous content of the LPUART_RDR register. This bit can only be written when the LPUART is disabled (UE=0). Note: This control bit enables checking the communication flow w/o reading the data.
$00002000 constant LPUART3_LPUART_CR3_DDRE                          \ DMA Disable on Reception Error This bit can only be written when the LPUART is disabled (UE=0). Note: The reception errors are: parity error, framing error or noise error.
$00004000 constant LPUART3_LPUART_CR3_DEM                           \ Driver enable mode This bit enables the user to activate the external transceiver control, through the DE signal. This bit can only be written when the LPUART is disabled (UE=0).
$00008000 constant LPUART3_LPUART_CR3_DEP                           \ Driver enable polarity selection This bit can only be written when the LPUART is disabled (UE=0).
$00100000 constant LPUART3_LPUART_CR3_WUS0                          \ Wake-up from low-power mode interrupt flag selection This bitfield specifies the event which activates the WUF (Wake-up from low-power mode flag). This bitfield can only be written when the LPUART is disabled (UE=0). Note: If the USART does not support the wake-up from Stop feature, this bit is reserved and must be kept at reset value. Refer to Section132.3: LPUART implementation on page1914.
$00200000 constant LPUART3_LPUART_CR3_WUS1                          \ Wake-up from low-power mode interrupt flag selection This bitfield specifies the event which activates the WUF (Wake-up from low-power mode flag). This bitfield can only be written when the LPUART is disabled (UE=0). Note: If the USART does not support the wake-up from Stop feature, this bit is reserved and must be kept at reset value. Refer to Section132.3: LPUART implementation on page1914.
$00400000 constant LPUART3_LPUART_CR3_WUFIE                         \ Wake-up from low-power mode interrupt enable This bit is set and cleared by software. Note: WUFIE must be set before entering in low-power mode. Note: If the USART does not support the wake-up from Stop feature, this bit is reserved and must be kept at reset value. Refer to Section132.3: LPUART implementation on page1914.
$00800000 constant LPUART3_LPUART_CR3_TXFTIE                        \ TXFIFO threshold interrupt enable This bit is set and cleared by software.
$0e000000 constant LPUART3_LPUART_CR3_RXFTCFG                       \ Receive FIFO threshold configuration Remaining combinations: Reserved.
$10000000 constant LPUART3_LPUART_CR3_RXFTIE                        \ RXFIFO threshold interrupt enable This bit is set and cleared by software.
$e0000000 constant LPUART3_LPUART_CR3_TXFTCFG                       \ TXFIFO threshold configuration Remaining combinations: Reserved.


\
\ @brief LPUART baud rate register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$000fffff constant LPUART3_LPUART_BRR_BRR                           \ LPUART baud rate division (LPUARTDIV)


\
\ @brief LPUART request register
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000002 constant LPUART3_LPUART_RQR_SBKRQ                         \ Send break request Writing 1 to this bit sets the SBKF flag and request to send a BREAK on the line, as soon as the transmit machine is available. Note: If the application needs to send the break character following all previously inserted data, including the ones not yet transmitted, the software must wait for the TXE flag assertion before setting the SBKRQ bit.
$00000004 constant LPUART3_LPUART_RQR_MMRQ                          \ Mute mode request Writing 1 to this bit puts the LPUART in Mute mode and resets the RWU flag.
$00000008 constant LPUART3_LPUART_RQR_RXFRQ                         \ Receive data flush request Writing 1 to this bit clears the RXNE flag. This enables discarding the received data without reading it, and avoid an overrun condition.
$00000010 constant LPUART3_LPUART_RQR_TXFRQ                         \ Transmit data flush request This bit is used when FIFO mode is enabled. TXFRQ bit is set to flush the whole FIFO. This sets the flag TXFE (TXFIFO empty, bit 23 in the LPUART_ISR register). Note: In FIFO mode, the TXFNF flag is reset during the flush request until TxFIFO is empty in order to ensure that no data are written in the data register.


\
\ @brief LPUART interrupt and status register
\ Address offset: 0x1C
\ Reset value: 0x008000C0
\

$00000001 constant LPUART3_LPUART_ISR_PE                            \ Parity error This bit is set by hardware when a parity error occurs in Reception mode. It is cleared by software, writing 1 to the PECF in the LPUART_ICR register. An interrupt is generated if PEIE = 1 in the LPUART_CR1 register. Note: This error is associated with the character in the LPUART_RDR.
$00000002 constant LPUART3_LPUART_ISR_FE                            \ Framing error This bit is set by hardware when a de-synchronization, excessive noise or a break character is detected. It is cleared by software, writing 1 to the FECF bit in the LPUART_ICR register. When transmitting data in Smartcard mode, this bit is set when the maximum number of transmit attempts is reached without success (the card NACKs the data frame). An interrupt is generated if EIE1=11 in the LPUART_CR3 register. Note: This error is associated with the character in the LPUART_RDR.
$00000004 constant LPUART3_LPUART_ISR_NE                            \ Start bit noise detection flag This bit is set by hardware when noise is detected on the start bit of a received frame. It is cleared by software, writing 1 to the NFCF bit in the LPUART_ICR register. Note: This bit does not generate an interrupt as it appears at the same time as the RXFNE bit which itself generates an interrupt. An interrupt is generated when the NE flag is set during multi buffer communication if the EIE bit is set. Note: This error is associated with the character in the LPUART_RDR.
$00000008 constant LPUART3_LPUART_ISR_ORE                           \ Overrun error This bit is set by hardware when the data currently being received in the shift register is ready to be transferred into the LPUART_RDR register while RXFF = 1. It is cleared by a software, writing 1 to the ORECF, in the LPUART_ICR register. An interrupt is generated if RXFNEIE=1 in the LPUART_CR1 register, or EIE = 1 in the LPUART_CR3 register. Note: When this bit is set, the LPUART_RDR register content is not lost but the shift register is overwritten. An interrupt is generated if the ORE flag is set during multi buffer communication if the EIE bit is set. Note: This bit is permanently forced to 0 (no overrun detection) when the bit OVRDIS is set in the LPUART_CR3 register.
$00000010 constant LPUART3_LPUART_ISR_IDLE                          \ Idle line detected This bit is set by hardware when an Idle line is detected. An interrupt is generated if IDLEIE=1 in the LPUART_CR1 register. It is cleared by software, writing 1 to the IDLECF in the LPUART_ICR register. Note: The IDLE bit is not set again until the RXFNE bit has been set (i.e. a new idle line occurs). Note: If Mute mode is enabled (MME=1), IDLE is set if the LPUART is not mute (RWU=0), whatever the Mute mode selected by the WAKE bit. If RWU=1, IDLE is not set.
$00000020 constant LPUART3_LPUART_ISR_RXFNE                         \ RXFIFO not empty RXFNE bit is set by hardware when the RXFIFO is not empty, and so data can be read from the LPUART_RDR register. Every read of the LPUART_RDR frees a location in the RXFIFO. It is cleared when the RXFIFO is empty. The RXFNE flag can also be cleared by writing 1 to the RXFRQ in the LPUART_RQR register. An interrupt is generated if RXFNEIE=1 in the LPUART_CR1 register.
$00000040 constant LPUART3_LPUART_ISR_TC                            \ Transmission complete This bit indicates that the last data written in the LPUART_TDR has been transmitted out of the shift register. The TC flag behaves as follows: When TDN = 0, the TC flag is set when the transmission of a frame containing data is complete and when TXFE is set. When TDN is equal to the number of data in the TXFIFO, the TC flag is set when TXFIFO is empty and TDN is reached. When TDN is greater than the number of data in the TXFIFO, TC remains cleared until the TXFIFO is filled again to reach the programmed number of data to be transferred. When TDN is less than the number of data in the TXFIFO, TC is set when TDN is reached even if the TXFIFO is not empty. An interrupt is generated if TCIE=1 in the LPUART_CR1 register. TC bit is cleared by software by writing 1 to the TCCF in the LPUART_ICR register or by writing to the LPUART_TDR register.
$00000080 constant LPUART3_LPUART_ISR_TXFNF                         \ TXFIFO not full TXFNF is set by hardware when TXFIFO is not full, and so data can be written in the LPUART_TDR. Every write in the LPUART_TDR places the data in the TXFIFO. This flag remains set until the TXFIFO is full. When the TXFIFO is full, this flag is cleared indicating that data can not be written into the LPUART_TDR. The TXFNF is kept reset during the flush request until TXFIFO is empty. After sending the flush request (by setting TXFRQ bit), the flag TXFNF must be checked prior to writing in TXFIFO (TXFNF and TXFE are set at the same time). An interrupt is generated if the TXFNFIE bit =1 in the LPUART_CR1 register. Note: This bit is used during single buffer transmission.
$00000200 constant LPUART3_LPUART_ISR_CTSIF                         \ CTS interrupt flag This bit is set by hardware when the CTS input toggles, if the CTSE bit is set. It is cleared by software, by writing 1 to the CTSCF bit in the LPUART_ICR register. An interrupt is generated if CTSIE=1 in the LPUART_CR3 register. Note: If the hardware flow control feature is not supported, this bit is reserved and kept at reset value.
$00000400 constant LPUART3_LPUART_ISR_CTS                           \ CTS flag This bit is set/reset by hardware. It is an inverted copy of the status of the CTS input pin. Note: If the hardware flow control feature is not supported, this bit is reserved and kept at reset value.
$00010000 constant LPUART3_LPUART_ISR_BUSY                          \ Busy flag This bit is set and reset by hardware. It is active when a communication is ongoing on the RX line (successful start bit detected). It is reset at the end of the reception (successful or not).
$00020000 constant LPUART3_LPUART_ISR_CMF                           \ Character match flag This bit is set by hardware, when a the character defined by ADD[7:0] is received. It is cleared by software, writing 1 to the CMCF in the LPUART_ICR register. An interrupt is generated if CMIE=1in the LPUART_CR1 register.
$00040000 constant LPUART3_LPUART_ISR_SBKF                          \ Send break flag This bit indicates that a send break character was requested. It is set by software, by writing 1 to the SBKRQ bit in the LPUART_CR3 register. It is automatically reset by hardware during the stop bit of break transmission.
$00080000 constant LPUART3_LPUART_ISR_RWU                           \ Receiver wake-up from Mute mode This bit indicates if the LPUART is in Mute mode. It is cleared/set by hardware when a wake-up/mute sequence is recognized. The Mute mode control sequence (address or IDLE) is selected by the WAKE bit in the LPUART_CR1 register. When wake-up on IDLE mode is selected, this bit can only be set by software, writing 1 to the MMRQ bit in the LPUART_RQR register. Note: If the LPUART does not support the wake-up from Stop feature, this bit is reserved and kept at reset value.
$00100000 constant LPUART3_LPUART_ISR_WUF                           \ Wake-up from low-power mode flag This bit is set by hardware, when a wake-up event is detected. The event is defined by the WUS bitfield. It is cleared by software, writing a 1 to the WUCF in the LPUART_ICR register. An interrupt is generated if WUFIE=1 in the LPUART_CR3 register. Note: When UESM is cleared, WUF flag is also cleared. Note: If the USART does not support the wake-up from Stop feature, this bit is reserved and kept at reset value. Refer to Section132.3: LPUART implementation on page1914.
$00200000 constant LPUART3_LPUART_ISR_TEACK                         \ Transmit enable acknowledge flag This bit is set/reset by hardware, when the Transmit Enable value is taken into account by the LPUART. It can be used when an idle frame request is generated by writing TE=0, followed by TE=1 in the LPUART_CR1 register, in order to respect the TE=0 minimum period.
$00400000 constant LPUART3_LPUART_ISR_REACK                         \ Receive enable acknowledge flag This bit is set/reset by hardware, when the Receive Enable value is taken into account by the LPUART. It can be used to verify that the LPUART is ready for reception before entering low-power mode. Note: If the LPUART does not support the wake-up from Stop feature, this bit is reserved and kept at reset value.
$00800000 constant LPUART3_LPUART_ISR_TXFE                          \ TXFIFO Empty This bit is set by hardware when TXFIFO is Empty. When the TXFIFO contains at least one data, this flag is cleared. The TXFE flag can also be set by writing 1 to the bit TXFRQ (bit 4) in the LPUART_RQR register. An interrupt is generated if the TXFEIE bit =1 (bit 30) in the LPUART_CR1 register.
$01000000 constant LPUART3_LPUART_ISR_RXFF                          \ RXFIFO Full This bit is set by hardware when the number of received data corresponds to RXFIFO1size1+11 (RXFIFO full + 1 data in the LPUART_RDR register. An interrupt is generated if the RXFFIE bit =1 in the LPUART_CR1 register.
$04000000 constant LPUART3_LPUART_ISR_RXFT                          \ RXFIFO threshold flag This bit is set by hardware when the RXFIFO reaches the threshold programmed in RXFTCFG in LPUART_CR3 register i.e. the Receive FIFO contains RXFTCFG data. An interrupt is generated if the RXFTIE bit =1 (bit 27) in the LPUART_CR3 register.
$08000000 constant LPUART3_LPUART_ISR_TXFT                          \ TXFIFO threshold flag This bit is set by hardware when the TXFIFO reaches the threshold programmed in TXFTCFG in LPUART_CR3 register i.e. the TXFIFO contains TXFTCFG empty locations. An interrupt is generated if the TXFTIE bit =1 (bit 31) in the LPUART_CR3 register.


\
\ @brief LPUART interrupt and status register
\ Address offset: 0x1C
\ Reset value: 0x008000C0
\

$00000001 constant LPUART3_LPUART_ISR_ALTERNATE_PE                  \ Parity error This bit is set by hardware when a parity error occurs in Reception mode. It is cleared by software, writing 1 to the PECF in the LPUART_ICR register. An interrupt is generated if PEIE = 1 in the LPUART_CR1 register. Note: In FIFO mode, this error is associated with the character in the LPUART_RDR.
$00000002 constant LPUART3_LPUART_ISR_ALTERNATE_FE                  \ Framing error This bit is set by hardware when a de-synchronization, excessive noise or a break character is detected. It is cleared by software, writing 1 to the FECF bit in the LPUART_ICR register. When transmitting data in Smartcard mode, this bit is set when the maximum number of transmit attempts is reached without success (the card NACKs the data frame). An interrupt is generated if EIE1=11 in the LPUART_CR3 register. Note: In FIFO mode, this error is associated with the character in the LPUART_RDR.
$00000004 constant LPUART3_LPUART_ISR_ALTERNATE_NE                  \ Start bit noise detection flag This bit is set by hardware when noise is detected on the start bit of a received frame. It is cleared by software, writing 1 to the NFCF bit in the LPUART_ICR register. Note: This bit does not generate an interrupt as it appears at the same time as the RXNE/RXFNE bit which itself generates an interrupt. An interrupt is generated when the NE flag is set during multi buffer communication if the EIE bit is set. Note: In FIFO mode, this error is associated with the character in the LPUART_RDR.
$00000008 constant LPUART3_LPUART_ISR_ALTERNATE_ORE                 \ Overrun error This bit is set by hardware when the data currently being received in the shift register is ready to be transferred into the LPUART_RDR register while RXNE=1 (RXFF = 1 in case FIFO mode is enabled). It is cleared by a software, writing 1 to the ORECF, in the LPUART_ICR register. An interrupt is generated if RXNEIE=1 in the LPUART_CR1 register, or EIE = 1 in the LPUART_CR3 register. Note: When this bit is set, the LPUART_RDR register content is not lost but the shift register is overwritten. An interrupt is generated if the ORE flag is set during multi buffer communication if the EIE bit is set. Note: This bit is permanently forced to 0 (no overrun detection) when the bit OVRDIS is set in the LPUART_CR3 register.
$00000010 constant LPUART3_LPUART_ISR_ALTERNATE_IDLE                \ Idle line detected This bit is set by hardware when an Idle Line is detected. An interrupt is generated if IDLEIE=1 in the LPUART_CR1 register. It is cleared by software, writing 1 to the IDLECF in the LPUART_ICR register. Note: The IDLE bit is not set again until the RXNE bit has been set (i.e. a new idle line occurs). Note: If Mute mode is enabled (MME=1), IDLE is set if the LPUART is not mute (RWU=0), whatever the Mute mode selected by the WAKE bit. If RWU=1, IDLE is not set.
$00000020 constant LPUART3_LPUART_ISR_ALTERNATE_RXNE                \ Read data register not empty RXNE bit is set by hardware when the content of the LPUART_RDR shift register has been transferred to the LPUART_RDR register. It is cleared by a read to the LPUART_RDR register. The RXNE flag can also be cleared by writing 1 to the RXFRQ in the LPUART_RQR register. The RXFNE flag can also be cleared by writing 1 to the RXFRQ in the LPUART_RQR register. An interrupt is generated if RXNEIE=1 in the LPUART_CR1 register.
$00000040 constant LPUART3_LPUART_ISR_ALTERNATE_TC                  \ Transmission complete This bit indicates that the last data written in the USART_TDR has been transmitted out of the shift register. The TC flag is set when the transmission of a frame containing data is complete and when TXE is set. An interrupt is generated if TCIE=1 in the LPUART_CR1 register. TC bit is cleared by software by writing 1 to the TCCF in the USART_ICR register or by writing to the USART_TDR register.
$00000080 constant LPUART3_LPUART_ISR_ALTERNATE_TXE                 \ Transmit data register empty TXE is set by hardware when the content of the LPUART_TDR register has been transferred into the shift register. It is cleared by a write to the LPUART_TDR register. An interrupt is generated if the TXEIE bit =1 in the LPUART_CR1 register. Note: This bit is used during single buffer transmission.
$00000200 constant LPUART3_LPUART_ISR_ALTERNATE_CTSIF               \ CTS interrupt flag This bit is set by hardware when the CTS input toggles, if the CTSE bit is set. It is cleared by software, by writing 1 to the CTSCF bit in the LPUART_ICR register. An interrupt is generated if CTSIE=1 in the LPUART_CR3 register. Note: If the hardware flow control feature is not supported, this bit is reserved and kept at reset value.
$00000400 constant LPUART3_LPUART_ISR_ALTERNATE_CTS                 \ CTS flag This bit is set/reset by hardware. It is an inverted copy of the status of the CTS input pin. Note: If the hardware flow control feature is not supported, this bit is reserved and kept at reset value.
$00010000 constant LPUART3_LPUART_ISR_ALTERNATE_BUSY                \ Busy flag This bit is set and reset by hardware. It is active when a communication is ongoing on the RX line (successful start bit detected). It is reset at the end of the reception (successful or not).
$00020000 constant LPUART3_LPUART_ISR_ALTERNATE_CMF                 \ Character match flag This bit is set by hardware, when a the character defined by ADD[7:0] is received. It is cleared by software, writing 1 to the CMCF in the LPUART_ICR register. An interrupt is generated if CMIE=1in the LPUART_CR1 register.
$00040000 constant LPUART3_LPUART_ISR_ALTERNATE_SBKF                \ Send break flag This bit indicates that a send break character was requested. It is set by software, by writing 1 to the SBKRQ bit in the LPUART_CR3 register. It is automatically reset by hardware during the stop bit of break transmission.
$00080000 constant LPUART3_LPUART_ISR_ALTERNATE_RWU                 \ Receiver wake-up from Mute mode This bit indicates if the LPUART is in Mute mode. It is cleared/set by hardware when a wake-up/mute sequence is recognized. The Mute mode control sequence (address or IDLE) is selected by the WAKE bit in the LPUART_CR1 register. When wake-up on IDLE mode is selected, this bit can only be set by software, writing 1 to the MMRQ bit in the LPUART_RQR register. Note: If the LPUART does not support the wake-up from Stop feature, this bit is reserved and kept at reset value.
$00100000 constant LPUART3_LPUART_ISR_ALTERNATE_WUF                 \ Wake-up from low-power mode flag This bit is set by hardware, when a wake-up event is detected. The event is defined by the WUS bitfield. It is cleared by software, writing a 1 to the WUCF in the LPUART_ICR register. An interrupt is generated if WUFIE=1 in the LPUART_CR3 register. Note: When UESM is cleared, WUF flag is also cleared. Note: If the USART does not support the wake-up from Stop feature, this bit is reserved and kept at reset value. Refer to Section132.3: LPUART implementation on page1914.
$00200000 constant LPUART3_LPUART_ISR_ALTERNATE_TEACK               \ Transmit enable acknowledge flag This bit is set/reset by hardware, when the Transmit Enable value is taken into account by the LPUART. It can be used when an idle frame request is generated by writing TE=0, followed by TE=1 in the LPUART_CR1 register, in order to respect the TE=0 minimum period.
$00400000 constant LPUART3_LPUART_ISR_ALTERNATE_REACK               \ Receive enable acknowledge flag This bit is set/reset by hardware, when the Receive Enable value is taken into account by the LPUART. It can be used to verify that the LPUART is ready for reception before entering low-power mode. Note: If the LPUART does not support the wake-up from Stop feature, this bit is reserved and kept at reset value.


\
\ @brief LPUART interrupt flag clear register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000001 constant LPUART3_LPUART_ICR_PECF                          \ Parity error clear flag Writing 1 to this bit clears the PE flag in the LPUART_ISR register.
$00000002 constant LPUART3_LPUART_ICR_FECF                          \ Framing error clear flag Writing 1 to this bit clears the FE flag in the LPUART_ISR register.
$00000004 constant LPUART3_LPUART_ICR_NECF                          \ Noise detected clear flag Writing 1 to this bit clears the NE flag in the LPUART_ISR register.
$00000008 constant LPUART3_LPUART_ICR_ORECF                         \ Overrun error clear flag Writing 1 to this bit clears the ORE flag in the LPUART_ISR register.
$00000010 constant LPUART3_LPUART_ICR_IDLECF                        \ Idle line detected clear flag Writing 1 to this bit clears the IDLE flag in the LPUART_ISR register.
$00000040 constant LPUART3_LPUART_ICR_TCCF                          \ Transmission complete clear flag Writing 1 to this bit clears the TC flag in the LPUART_ISR register.
$00000200 constant LPUART3_LPUART_ICR_CTSCF                         \ CTS clear flag Writing 1 to this bit clears the CTSIF flag in the LPUART_ISR register.
$00020000 constant LPUART3_LPUART_ICR_CMCF                          \ Character match clear flag Writing 1 to this bit clears the CMF flag in the LPUART_ISR register.
$00100000 constant LPUART3_LPUART_ICR_WUCF                          \ Wake-up from low-power mode clear flag Writing 1 to this bit clears the WUF flag in the USART_ISR register. Note: If the USART does not support the wake-up from Stop feature, this bit is reserved and must be kept at reset value. Refer to Section132.3: LPUART implementation on page1914.


\
\ @brief LPUART receive data register
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$000001ff constant LPUART3_LPUART_RDR_RDR                           \ Receive data value Contains the received data character. The RDR register provides the parallel interface between the input shift register and the internal bus (see Figure1254). When receiving with the parity enabled, the value read in the MSB bit is the received parity bit.


\
\ @brief LPUART transmit data register
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$000001ff constant LPUART3_LPUART_TDR_TDR                           \ Transmit data value Contains the data character to be transmitted. The TDR register provides the parallel interface between the internal bus and the output shift register (see Figure1254). When transmitting with the parity enabled (PCE bit set to 1 in the LPUART_CR1 register), the value written in the MSB (bit 7 or bit 8 depending on the data length) has no effect because it is replaced by the parity. Note: This register must be written only when TXE/TXFNF=1.


\
\ @brief LPUART prescaler register
\ Address offset: 0x2C
\ Reset value: 0x00000000
\

$0000000f constant LPUART3_LPUART_PRESC_PRESCALER                   \ Clock prescaler The LPUART input clock can be divided by a prescaler: Remaining combinations: Reserved. Note: When PRESCALER is programmed with a value different of the allowed ones, programmed prescaler value is equal to 1011 i.e. input clock divided by 256.


\
\ @brief LPUART address block description
\
$40008c00 constant LPUART3_LPUART_CR1  \ offset: 0x00 : LPUART control register 1
$40008c00 constant LPUART3_LPUART_CR1_ALTERNATE  \ offset: 0x00 : LPUART control register 1
$40008c04 constant LPUART3_LPUART_CR2  \ offset: 0x04 : LPUART control register 2
$40008c08 constant LPUART3_LPUART_CR3  \ offset: 0x08 : LPUART control register 3
$40008c0c constant LPUART3_LPUART_BRR  \ offset: 0x0C : LPUART baud rate register
$40008c18 constant LPUART3_LPUART_RQR  \ offset: 0x18 : LPUART request register
$40008c1c constant LPUART3_LPUART_ISR  \ offset: 0x1C : LPUART interrupt and status register
$40008c1c constant LPUART3_LPUART_ISR_ALTERNATE  \ offset: 0x1C : LPUART interrupt and status register
$40008c20 constant LPUART3_LPUART_ICR  \ offset: 0x20 : LPUART interrupt flag clear register
$40008c24 constant LPUART3_LPUART_RDR  \ offset: 0x24 : LPUART receive data register
$40008c28 constant LPUART3_LPUART_TDR  \ offset: 0x28 : LPUART transmit data register
$40008c2c constant LPUART3_LPUART_PRESC  \ offset: 0x2C : LPUART prescaler register

