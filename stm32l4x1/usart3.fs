\
\ @file usart3.fs
\ @brief Universal synchronous asynchronous receiver transmitter
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] USART3_DEF

  [ifdef] USART3_CR1_DEF
    \
    \ @brief Control register 1
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant USART3_UE                      \ [0x00] USART enable
    $01 constant USART3_UESM                    \ [0x01] USART enable in Stop mode
    $02 constant USART3_RE                      \ [0x02] Receiver enable
    $03 constant USART3_TE                      \ [0x03] Transmitter enable
    $04 constant USART3_IDLEIE                  \ [0x04] IDLE interrupt enable
    $05 constant USART3_RXNEIE                  \ [0x05] RXNE interrupt enable
    $06 constant USART3_TCIE                    \ [0x06] Transmission complete interrupt enable
    $07 constant USART3_TXEIE                   \ [0x07] interrupt enable
    $08 constant USART3_PEIE                    \ [0x08] PE interrupt enable
    $09 constant USART3_PS                      \ [0x09] Parity selection
    $0a constant USART3_PCE                     \ [0x0a] Parity control enable
    $0b constant USART3_WAKE                    \ [0x0b] Receiver wakeup method
    $0c constant USART3_M0                      \ [0x0c] Word length
    $0d constant USART3_MME                     \ [0x0d] Mute mode enable
    $0e constant USART3_CMIE                    \ [0x0e] Character match interrupt enable
    $0f constant USART3_OVER8                   \ [0x0f] Oversampling mode
    $10 constant USART3_DEDT0                   \ [0x10] DEDT0
    $11 constant USART3_DEDT1                   \ [0x11] DEDT1
    $12 constant USART3_DEDT2                   \ [0x12] DEDT2
    $13 constant USART3_DEDT3                   \ [0x13] DEDT3
    $14 constant USART3_DEDT4                   \ [0x14] Driver Enable de-assertion time
    $15 constant USART3_DEAT0                   \ [0x15] DEAT0
    $16 constant USART3_DEAT1                   \ [0x16] DEAT1
    $17 constant USART3_DEAT2                   \ [0x17] DEAT2
    $18 constant USART3_DEAT3                   \ [0x18] DEAT3
    $19 constant USART3_DEAT4                   \ [0x19] Driver Enable assertion time
    $1a constant USART3_RTOIE                   \ [0x1a] Receiver timeout interrupt enable
    $1b constant USART3_EOBIE                   \ [0x1b] End of Block interrupt enable
    $1c constant USART3_M1                      \ [0x1c] Word length
  [then]


  [ifdef] USART3_CR2_DEF
    \
    \ @brief Control register 2
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $04 constant USART3_ADDM7                   \ [0x04] 7-bit Address Detection/4-bit Address Detection
    $05 constant USART3_LBDL                    \ [0x05] LIN break detection length
    $06 constant USART3_LBDIE                   \ [0x06] LIN break detection interrupt enable
    $08 constant USART3_LBCL                    \ [0x08] Last bit clock pulse
    $09 constant USART3_CPHA                    \ [0x09] Clock phase
    $0a constant USART3_CPOL                    \ [0x0a] Clock polarity
    $0b constant USART3_CLKEN                   \ [0x0b] Clock enable
    $0c constant USART3_STOP                    \ [0x0c : 2] STOP bits
    $0e constant USART3_LINEN                   \ [0x0e] LIN mode enable
    $0f constant USART3_SWAP                    \ [0x0f] Swap TX/RX pins
    $10 constant USART3_RXINV                   \ [0x10] RX pin active level inversion
    $11 constant USART3_TXINV                   \ [0x11] TX pin active level inversion
    $12 constant USART3_TAINV                   \ [0x12] Binary data inversion
    $13 constant USART3_MSBFIRST                \ [0x13] Most significant bit first
    $14 constant USART3_ABREN                   \ [0x14] Auto baud rate enable
    $15 constant USART3_ABRMOD0                 \ [0x15] ABRMOD0
    $16 constant USART3_ABRMOD1                 \ [0x16] Auto baud rate mode
    $17 constant USART3_RTOEN                   \ [0x17] Receiver timeout enable
    $18 constant USART3_ADD0_3                  \ [0x18 : 4] Address of the USART node
    $1c constant USART3_ADD4_7                  \ [0x1c : 4] Address of the USART node
  [then]


  [ifdef] USART3_CR3_DEF
    \
    \ @brief Control register 3
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant USART3_EIE                     \ [0x00] Error interrupt enable
    $01 constant USART3_IREN                    \ [0x01] Ir mode enable
    $02 constant USART3_IRLP                    \ [0x02] Ir low-power
    $03 constant USART3_HDSEL                   \ [0x03] Half-duplex selection
    $04 constant USART3_NACK                    \ [0x04] Smartcard NACK enable
    $05 constant USART3_SCEN                    \ [0x05] Smartcard mode enable
    $06 constant USART3_DMAR                    \ [0x06] DMA enable receiver
    $07 constant USART3_DMAT                    \ [0x07] DMA enable transmitter
    $08 constant USART3_RTSE                    \ [0x08] RTS enable
    $09 constant USART3_CTSE                    \ [0x09] CTS enable
    $0a constant USART3_CTSIE                   \ [0x0a] CTS interrupt enable
    $0b constant USART3_ONEBIT                  \ [0x0b] One sample bit method enable
    $0c constant USART3_OVRDIS                  \ [0x0c] Overrun Disable
    $0d constant USART3_DDRE                    \ [0x0d] DMA Disable on Reception Error
    $0e constant USART3_DEM                     \ [0x0e] Driver enable mode
    $0f constant USART3_DEP                     \ [0x0f] Driver enable polarity selection
    $11 constant USART3_SCARCNT                 \ [0x11 : 3] Smartcard auto-retry count
    $14 constant USART3_WUS                     \ [0x14 : 2] Wakeup from Stop mode interrupt flag selection
    $16 constant USART3_WUFIE                   \ [0x16] Wakeup from Stop mode interrupt enable
    $17 constant USART3_UCESM                   \ [0x17] USART Clock Enable in Stop mode
    $18 constant USART3_TCBGTIE                 \ [0x18] Transmission complete before guard time interrupt enable
  [then]


  [ifdef] USART3_BRR_DEF
    \
    \ @brief Baud rate register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant USART3_BRR                     \ [0x00 : 12] USARTDIV
  [then]


  [ifdef] USART3_GTPR_DEF
    \
    \ @brief Guard time and prescaler register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant USART3_PSC                     \ [0x00 : 8] Prescaler value
    $08 constant USART3_GT                      \ [0x08 : 8] Guard time value
  [then]


  [ifdef] USART3_RTOR_DEF
    \
    \ @brief Receiver timeout register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant USART3_RTO                     \ [0x00 : 24] Receiver timeout value
    $18 constant USART3_BLEN                    \ [0x18 : 8] Block Length
  [then]


  [ifdef] USART3_RQR_DEF
    \
    \ @brief Request register
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant USART3_ABRRQ                   \ [0x00] Auto baud rate request
    $01 constant USART3_SBKRQ                   \ [0x01] Send break request
    $02 constant USART3_MMRQ                    \ [0x02] Mute mode request
    $03 constant USART3_RXFRQ                   \ [0x03] Receive data flush request
    $04 constant USART3_TXFRQ                   \ [0x04] Transmit data flush request
  [then]


  [ifdef] USART3_ISR_DEF
    \
    \ @brief Interrupt & status register
    \ Address offset: 0x1C
    \ Reset value: 0x000000C0
    \
    $00 constant USART3_PE                      \ [0x00] PE
    $01 constant USART3_FE                      \ [0x01] FE
    $02 constant USART3_NF                      \ [0x02] NF
    $03 constant USART3_ORE                     \ [0x03] ORE
    $04 constant USART3_IDLE                    \ [0x04] IDLE
    $05 constant USART3_RXNE                    \ [0x05] RXNE
    $06 constant USART3_TC                      \ [0x06] TC
    $07 constant USART3_TXE                     \ [0x07] TXE
    $08 constant USART3_LBDF                    \ [0x08] LBDF
    $09 constant USART3_CTSIF                   \ [0x09] CTSIF
    $0a constant USART3_CTS                     \ [0x0a] CTS
    $0b constant USART3_RTOF                    \ [0x0b] RTOF
    $0c constant USART3_EOBF                    \ [0x0c] EOBF
    $0e constant USART3_ABRE                    \ [0x0e] ABRE
    $0f constant USART3_ABRF                    \ [0x0f] ABRF
    $10 constant USART3_BUSY                    \ [0x10] BUSY
    $11 constant USART3_CMF                     \ [0x11] CMF
    $12 constant USART3_SBKF                    \ [0x12] SBKF
    $13 constant USART3_RWU                     \ [0x13] RWU
    $14 constant USART3_WUF                     \ [0x14] WUF
    $15 constant USART3_TEACK                   \ [0x15] TEACK
    $16 constant USART3_REACK                   \ [0x16] REACK
    $19 constant USART3_TCBGT                   \ [0x19] Transmission complete before guard time completion
  [then]


  [ifdef] USART3_ICR_DEF
    \
    \ @brief Interrupt flag clear register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant USART3_PECF                    \ [0x00] Parity error clear flag
    $01 constant USART3_FECF                    \ [0x01] Framing error clear flag
    $02 constant USART3_NCF                     \ [0x02] Noise detected clear flag
    $03 constant USART3_ORECF                   \ [0x03] Overrun error clear flag
    $04 constant USART3_IDLECF                  \ [0x04] Idle line detected clear flag
    $06 constant USART3_TCCF                    \ [0x06] Transmission complete clear flag
    $08 constant USART3_LBDCF                   \ [0x08] LIN break detection clear flag
    $09 constant USART3_CTSCF                   \ [0x09] CTS clear flag
    $0b constant USART3_RTOCF                   \ [0x0b] Receiver timeout clear flag
    $0c constant USART3_EOBCF                   \ [0x0c] End of block clear flag
    $11 constant USART3_CMCF                    \ [0x11] Character match clear flag
    $14 constant USART3_WUCF                    \ [0x14] Wakeup from Stop mode clear flag
  [then]


  [ifdef] USART3_RDR_DEF
    \
    \ @brief Receive data register
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant USART3_RDR                     \ [0x00 : 9] Receive data value
  [then]


  [ifdef] USART3_TDR_DEF
    \
    \ @brief Transmit data register
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant USART3_TDR                     \ [0x00 : 9] Transmit data value
  [then]

  \
  \ @brief Universal synchronous asynchronous receiver transmitter
  \
  $00 constant USART3_CR1               \ Control register 1
  $04 constant USART3_CR2               \ Control register 2
  $08 constant USART3_CR3               \ Control register 3
  $0C constant USART3_BRR               \ Baud rate register
  $10 constant USART3_GTPR              \ Guard time and prescaler register
  $14 constant USART3_RTOR              \ Receiver timeout register
  $18 constant USART3_RQR               \ Request register
  $1C constant USART3_ISR               \ Interrupt & status register
  $20 constant USART3_ICR               \ Interrupt flag clear register
  $24 constant USART3_RDR               \ Receive data register
  $28 constant USART3_TDR               \ Transmit data register

: USART3_DEF ; [then]
