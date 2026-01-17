\
\ @file usart6.fs
\ @brief Universal synchronous asynchronous receiver transmitter
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] USART6_DEF

  [ifdef] USART6_CR1_DEF
    \
    \ @brief Control register 1
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant USART6_UE                      \ [0x00] USART enable
    $01 constant USART6_UESM                    \ [0x01] USART enable in Stop mode
    $02 constant USART6_RE                      \ [0x02] Receiver enable
    $03 constant USART6_TE                      \ [0x03] Transmitter enable
    $04 constant USART6_IDLEIE                  \ [0x04] IDLE interrupt enable
    $05 constant USART6_RXNEIE                  \ [0x05] RXNE interrupt enable
    $06 constant USART6_TCIE                    \ [0x06] Transmission complete interrupt enable
    $07 constant USART6_TXEIE                   \ [0x07] interrupt enable
    $08 constant USART6_PEIE                    \ [0x08] PE interrupt enable
    $09 constant USART6_PS                      \ [0x09] Parity selection
    $0a constant USART6_PCE                     \ [0x0a] Parity control enable
    $0b constant USART6_WAKE                    \ [0x0b] Receiver wakeup method
    $0c constant USART6_M0                      \ [0x0c] Word length
    $0d constant USART6_MME                     \ [0x0d] Mute mode enable
    $0e constant USART6_CMIE                    \ [0x0e] Character match interrupt enable
    $0f constant USART6_OVER8                   \ [0x0f] Oversampling mode
    $10 constant USART6_DEDT0                   \ [0x10] DEDT0
    $11 constant USART6_DEDT1                   \ [0x11] DEDT1
    $12 constant USART6_DEDT2                   \ [0x12] DEDT2
    $13 constant USART6_DEDT3                   \ [0x13] DEDT3
    $14 constant USART6_DEDT4                   \ [0x14] Driver Enable de-assertion time
    $15 constant USART6_DEAT0                   \ [0x15] DEAT0
    $16 constant USART6_DEAT1                   \ [0x16] DEAT1
    $17 constant USART6_DEAT2                   \ [0x17] DEAT2
    $18 constant USART6_DEAT3                   \ [0x18] DEAT3
    $19 constant USART6_DEAT4                   \ [0x19] Driver Enable assertion time
    $1a constant USART6_RTOIE                   \ [0x1a] Receiver timeout interrupt enable
    $1b constant USART6_EOBIE                   \ [0x1b] End of Block interrupt enable
    $1c constant USART6_M1                      \ [0x1c] Word length
  [then]


  [ifdef] USART6_CR2_DEF
    \
    \ @brief Control register 2
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $04 constant USART6_ADDM7                   \ [0x04] 7-bit Address Detection/4-bit Address Detection
    $05 constant USART6_LBDL                    \ [0x05] LIN break detection length
    $06 constant USART6_LBDIE                   \ [0x06] LIN break detection interrupt enable
    $08 constant USART6_LBCL                    \ [0x08] Last bit clock pulse
    $09 constant USART6_CPHA                    \ [0x09] Clock phase
    $0a constant USART6_CPOL                    \ [0x0a] Clock polarity
    $0b constant USART6_CLKEN                   \ [0x0b] Clock enable
    $0c constant USART6_STOP                    \ [0x0c : 2] STOP bits
    $0e constant USART6_LINEN                   \ [0x0e] LIN mode enable
    $0f constant USART6_SWAP                    \ [0x0f] Swap TX/RX pins
    $10 constant USART6_RXINV                   \ [0x10] RX pin active level inversion
    $11 constant USART6_TXINV                   \ [0x11] TX pin active level inversion
    $12 constant USART6_TAINV                   \ [0x12] Binary data inversion
    $13 constant USART6_MSBFIRST                \ [0x13] Most significant bit first
    $14 constant USART6_ABREN                   \ [0x14] Auto baud rate enable
    $15 constant USART6_ABRMOD0                 \ [0x15] ABRMOD0
    $16 constant USART6_ABRMOD1                 \ [0x16] Auto baud rate mode
    $17 constant USART6_RTOEN                   \ [0x17] Receiver timeout enable
    $18 constant USART6_ADD0_3                  \ [0x18 : 4] Address of the USART node
    $1c constant USART6_ADD4_7                  \ [0x1c : 4] Address of the USART node
  [then]


  [ifdef] USART6_CR3_DEF
    \
    \ @brief Control register 3
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant USART6_EIE                     \ [0x00] Error interrupt enable
    $01 constant USART6_IREN                    \ [0x01] Ir mode enable
    $02 constant USART6_IRLP                    \ [0x02] Ir low-power
    $03 constant USART6_HDSEL                   \ [0x03] Half-duplex selection
    $04 constant USART6_NACK                    \ [0x04] Smartcard NACK enable
    $05 constant USART6_SCEN                    \ [0x05] Smartcard mode enable
    $06 constant USART6_DMAR                    \ [0x06] DMA enable receiver
    $07 constant USART6_DMAT                    \ [0x07] DMA enable transmitter
    $08 constant USART6_RTSE                    \ [0x08] RTS enable
    $09 constant USART6_CTSE                    \ [0x09] CTS enable
    $0a constant USART6_CTSIE                   \ [0x0a] CTS interrupt enable
    $0b constant USART6_ONEBIT                  \ [0x0b] One sample bit method enable
    $0c constant USART6_OVRDIS                  \ [0x0c] Overrun Disable
    $0d constant USART6_DDRE                    \ [0x0d] DMA Disable on Reception Error
    $0e constant USART6_DEM                     \ [0x0e] Driver enable mode
    $0f constant USART6_DEP                     \ [0x0f] Driver enable polarity selection
    $11 constant USART6_SCARCNT                 \ [0x11 : 3] Smartcard auto-retry count
    $14 constant USART6_WUS                     \ [0x14 : 2] Wakeup from Stop mode interrupt flag selection
    $16 constant USART6_WUFIE                   \ [0x16] Wakeup from Stop mode interrupt enable
  [then]


  [ifdef] USART6_BRR_DEF
    \
    \ @brief Baud rate register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant USART6_DIV_Fraction            \ [0x00 : 4] DIV_Fraction
    $04 constant USART6_DIV_Mantissa            \ [0x04 : 12] DIV_Mantissa
  [then]


  [ifdef] USART6_GTPR_DEF
    \
    \ @brief Guard time and prescaler register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant USART6_PSC                     \ [0x00 : 8] Prescaler value
    $08 constant USART6_GT                      \ [0x08 : 8] Guard time value
  [then]


  [ifdef] USART6_RTOR_DEF
    \
    \ @brief Receiver timeout register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant USART6_RTO                     \ [0x00 : 24] Receiver timeout value
    $18 constant USART6_BLEN                    \ [0x18 : 8] Block Length
  [then]


  [ifdef] USART6_RQR_DEF
    \
    \ @brief Request register
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant USART6_ABRRQ                   \ [0x00] Auto baud rate request
    $01 constant USART6_SBKRQ                   \ [0x01] Send break request
    $02 constant USART6_MMRQ                    \ [0x02] Mute mode request
    $03 constant USART6_RXFRQ                   \ [0x03] Receive data flush request
    $04 constant USART6_TXFRQ                   \ [0x04] Transmit data flush request
  [then]


  [ifdef] USART6_ISR_DEF
    \
    \ @brief Interrupt & status register
    \ Address offset: 0x1C
    \ Reset value: 0x000000C0
    \
    $00 constant USART6_PE                      \ [0x00] PE
    $01 constant USART6_FE                      \ [0x01] FE
    $02 constant USART6_NF                      \ [0x02] NF
    $03 constant USART6_ORE                     \ [0x03] ORE
    $04 constant USART6_IDLE                    \ [0x04] IDLE
    $05 constant USART6_RXNE                    \ [0x05] RXNE
    $06 constant USART6_TC                      \ [0x06] TC
    $07 constant USART6_TXE                     \ [0x07] TXE
    $08 constant USART6_LBDF                    \ [0x08] LBDF
    $09 constant USART6_CTSIF                   \ [0x09] CTSIF
    $0a constant USART6_CTS                     \ [0x0a] CTS
    $0b constant USART6_RTOF                    \ [0x0b] RTOF
    $0c constant USART6_EOBF                    \ [0x0c] EOBF
    $0e constant USART6_ABRE                    \ [0x0e] ABRE
    $0f constant USART6_ABRF                    \ [0x0f] ABRF
    $10 constant USART6_BUSY                    \ [0x10] BUSY
    $11 constant USART6_CMF                     \ [0x11] CMF
    $12 constant USART6_SBKF                    \ [0x12] SBKF
    $13 constant USART6_RWU                     \ [0x13] RWU
    $14 constant USART6_WUF                     \ [0x14] WUF
    $15 constant USART6_TEACK                   \ [0x15] TEACK
    $16 constant USART6_REACK                   \ [0x16] REACK
  [then]


  [ifdef] USART6_ICR_DEF
    \
    \ @brief Interrupt flag clear register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant USART6_PECF                    \ [0x00] Parity error clear flag
    $01 constant USART6_FECF                    \ [0x01] Framing error clear flag
    $02 constant USART6_NCF                     \ [0x02] Noise detected clear flag
    $03 constant USART6_ORECF                   \ [0x03] Overrun error clear flag
    $04 constant USART6_IDLECF                  \ [0x04] Idle line detected clear flag
    $06 constant USART6_TCCF                    \ [0x06] Transmission complete clear flag
    $08 constant USART6_LBDCF                   \ [0x08] LIN break detection clear flag
    $09 constant USART6_CTSCF                   \ [0x09] CTS clear flag
    $0b constant USART6_RTOCF                   \ [0x0b] Receiver timeout clear flag
    $0c constant USART6_EOBCF                   \ [0x0c] End of block clear flag
    $11 constant USART6_CMCF                    \ [0x11] Character match clear flag
    $14 constant USART6_WUCF                    \ [0x14] Wakeup from Stop mode clear flag
  [then]


  [ifdef] USART6_RDR_DEF
    \
    \ @brief Receive data register
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant USART6_RDR                     \ [0x00 : 9] Receive data value
  [then]


  [ifdef] USART6_TDR_DEF
    \
    \ @brief Transmit data register
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant USART6_TDR                     \ [0x00 : 9] Transmit data value
  [then]

  \
  \ @brief Universal synchronous asynchronous receiver transmitter
  \
  $00 constant USART6_CR1               \ Control register 1
  $04 constant USART6_CR2               \ Control register 2
  $08 constant USART6_CR3               \ Control register 3
  $0C constant USART6_BRR               \ Baud rate register
  $10 constant USART6_GTPR              \ Guard time and prescaler register
  $14 constant USART6_RTOR              \ Receiver timeout register
  $18 constant USART6_RQR               \ Request register
  $1C constant USART6_ISR               \ Interrupt & status register
  $20 constant USART6_ICR               \ Interrupt flag clear register
  $24 constant USART6_RDR               \ Receive data register
  $28 constant USART6_TDR               \ Transmit data register

: USART6_DEF ; [then]
