\
\ @file lpuar.fs
\ @brief Low-power universal asynchronous receiver transmitter
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] LPUAR_DEF

  [ifdef] LPUAR_LPUART_CR1_ENABLED_DEF
    \
    \ @brief LPUART control register 1
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant LPUAR_UE                       \ [0x00] LPUART enable
    $01 constant LPUAR_UESM                     \ [0x01] LPUART enable in low-power mode
    $02 constant LPUAR_RE                       \ [0x02] Receiver enable
    $03 constant LPUAR_TE                       \ [0x03] Transmitter enable
    $04 constant LPUAR_IDLEIE                   \ [0x04] IDLE interrupt enable
    $05 constant LPUAR_RXFNEIE                  \ [0x05] RXFIFO not empty interrupt enable
    $06 constant LPUAR_TCIE                     \ [0x06] Transmission complete interrupt enable
    $07 constant LPUAR_TXFNFIE                  \ [0x07] TXFIFO not full interrupt enable
    $08 constant LPUAR_PEIE                     \ [0x08] PE interrupt enable
    $09 constant LPUAR_PS                       \ [0x09] Parity selection
    $0a constant LPUAR_PCE                      \ [0x0a] Parity control enable
    $0b constant LPUAR_WAKE                     \ [0x0b] Receiver wake-up method
    $0c constant LPUAR_M0                       \ [0x0c] Word length
    $0d constant LPUAR_MME                      \ [0x0d] Mute mode enable
    $0e constant LPUAR_CMIE                     \ [0x0e] Character match interrupt enable
    $10 constant LPUAR_DEDT                     \ [0x10 : 5] Driver Enable deassertion time
    $15 constant LPUAR_DEAT                     \ [0x15 : 5] Driver Enable assertion time
    $1c constant LPUAR_M1                       \ [0x1c] Word length
    $1d constant LPUAR_FIFOEN                   \ [0x1d] FIFO mode enable
    $1e constant LPUAR_TXFEIE                   \ [0x1e] TXFIFO empty interrupt enable
    $1f constant LPUAR_RXFFIE                   \ [0x1f] RXFIFO Full interrupt enable
  [then]


  [ifdef] LPUAR_LPUART_CR1_DISABLED_DEF
    \
    \ @brief LPUART control register 1
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant LPUAR_UE                       \ [0x00] LPUART enable
    $01 constant LPUAR_UESM                     \ [0x01] LPUART enable in low-power mode
    $02 constant LPUAR_RE                       \ [0x02] Receiver enable
    $03 constant LPUAR_TE                       \ [0x03] Transmitter enable
    $04 constant LPUAR_IDLEIE                   \ [0x04] IDLE interrupt enable
    $05 constant LPUAR_RXNEIE                   \ [0x05] Receive data register not empty
    $06 constant LPUAR_TCIE                     \ [0x06] Transmission complete interrupt enable
    $07 constant LPUAR_TXEIE                    \ [0x07] Transmit data register empty
    $08 constant LPUAR_PEIE                     \ [0x08] PE interrupt enable
    $09 constant LPUAR_PS                       \ [0x09] Parity selection
    $0a constant LPUAR_PCE                      \ [0x0a] Parity control enable
    $0b constant LPUAR_WAKE                     \ [0x0b] Receiver wake-up method
    $0c constant LPUAR_M0                       \ [0x0c] Word length
    $0d constant LPUAR_MME                      \ [0x0d] Mute mode enable
    $0e constant LPUAR_CMIE                     \ [0x0e] Character match interrupt enable
    $10 constant LPUAR_DEDT                     \ [0x10 : 5] Driver Enable deassertion time
    $15 constant LPUAR_DEAT                     \ [0x15 : 5] Driver Enable assertion time
    $1c constant LPUAR_M1                       \ [0x1c] Word length
    $1d constant LPUAR_FIFOEN                   \ [0x1d] FIFO mode enable
  [then]


  [ifdef] LPUAR_LPUART_CR2_DEF
    \
    \ @brief LPUART control register 2
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $04 constant LPUAR_ADDM7                    \ [0x04] 7-bit Address Detection/4-bit Address Detection
    $0c constant LPUAR_STOP                     \ [0x0c : 2] STOP bits
    $0f constant LPUAR_SWAP                     \ [0x0f] Swap TX/RX pins
    $10 constant LPUAR_RXINV                    \ [0x10] RX pin active level inversion
    $11 constant LPUAR_TXINV                    \ [0x11] TX pin active level inversion
    $12 constant LPUAR_DATAINV                  \ [0x12] Binary data inversion
    $13 constant LPUAR_MSBFIRST                 \ [0x13] Most significant bit first
    $18 constant LPUAR_ADD                      \ [0x18 : 8] Address of the LPUART node
  [then]


  [ifdef] LPUAR_LPUART_CR3_DEF
    \
    \ @brief LPUART control register 3
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant LPUAR_EIE                      \ [0x00] Error interrupt enable
    $03 constant LPUAR_HDSEL                    \ [0x03] Half-duplex selection
    $06 constant LPUAR_DMAR                     \ [0x06] DMA enable receiver
    $07 constant LPUAR_DMAT                     \ [0x07] DMA enable transmitter
    $08 constant LPUAR_RTSE                     \ [0x08] RTS enable
    $09 constant LPUAR_CTSE                     \ [0x09] CTS enable
    $0a constant LPUAR_CTSIE                    \ [0x0a] CTS interrupt enable
    $0c constant LPUAR_OVRDIS                   \ [0x0c] Overrun Disable
    $0d constant LPUAR_DDRE                     \ [0x0d] DMA Disable on Reception Error
    $0e constant LPUAR_DEM                      \ [0x0e] Driver enable mode
    $0f constant LPUAR_DEP                      \ [0x0f] Driver enable polarity selection
    $14 constant LPUAR_WUS0                     \ [0x14] Wake-up from low-power mode interrupt flag selection
    $15 constant LPUAR_WUS1                     \ [0x15] Wake-up from low-power mode interrupt flag selection
    $16 constant LPUAR_WUFIE                    \ [0x16] Wake-up from low-power mode interrupt enable
    $17 constant LPUAR_TXFTIE                   \ [0x17] TXFIFO threshold interrupt enable
    $19 constant LPUAR_RXFTCFG                  \ [0x19 : 3] Receive FIFO threshold configuration
    $1c constant LPUAR_RXFTIE                   \ [0x1c] RXFIFO threshold interrupt enable
    $1d constant LPUAR_TXFTCFG                  \ [0x1d : 3] TXFIFO threshold configuration
  [then]


  [ifdef] LPUAR_LPUART_BRR_DEF
    \
    \ @brief LPUART baud rate register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant LPUAR_BRR                      \ [0x00 : 20] LPUART baud rate division (LPUARTDIV)
  [then]


  [ifdef] LPUAR_LPUART_RQR_DEF
    \
    \ @brief LPUART request register
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $01 constant LPUAR_SBKRQ                    \ [0x01] Send break request
    $02 constant LPUAR_MMRQ                     \ [0x02] Mute mode request
    $03 constant LPUAR_RXFRQ                    \ [0x03] Receive data flush request
    $04 constant LPUAR_TXFRQ                    \ [0x04] Transmit data flush request
  [then]


  [ifdef] LPUAR_LPUART_ISR_ENABLED_DEF
    \
    \ @brief LPUART interrupt and status register
    \ Address offset: 0x1C
    \ Reset value: 0x008000C0
    \
    $00 constant LPUAR_PE                       \ [0x00] Parity error
    $01 constant LPUAR_FE                       \ [0x01] Framing error
    $02 constant LPUAR_NE                       \ [0x02] Start bit noise detection flag
    $03 constant LPUAR_ORE                      \ [0x03] Overrun error
    $04 constant LPUAR_IDLE                     \ [0x04] Idle line detected
    $05 constant LPUAR_RXFNE                    \ [0x05] RXFIFO not empty
    $06 constant LPUAR_TC                       \ [0x06] Transmission complete
    $07 constant LPUAR_TXFNF                    \ [0x07] TXFIFO not full
    $09 constant LPUAR_CTSIF                    \ [0x09] CTS interrupt flag
    $0a constant LPUAR_CTS                      \ [0x0a] CTS flag
    $10 constant LPUAR_BUSY                     \ [0x10] Busy flag
    $11 constant LPUAR_CMF                      \ [0x11] Character match flag
    $12 constant LPUAR_SBKF                     \ [0x12] Send break flag
    $13 constant LPUAR_RWU                      \ [0x13] Receiver wake-up from Mute mode
    $14 constant LPUAR_WUF                      \ [0x14] Wake-up from low-power mode flag
    $15 constant LPUAR_TEACK                    \ [0x15] Transmit enable acknowledge flag
    $16 constant LPUAR_REACK                    \ [0x16] Receive enable acknowledge flag
    $17 constant LPUAR_TXFE                     \ [0x17] TXFIFO Empty
    $18 constant LPUAR_RXFF                     \ [0x18] RXFIFO Full
    $1a constant LPUAR_RXFT                     \ [0x1a] RXFIFO threshold flag
    $1b constant LPUAR_TXFT                     \ [0x1b] TXFIFO threshold flag
  [then]


  [ifdef] LPUAR_LPUART_ISR_DISABLED_DEF
    \
    \ @brief LPUART interrupt and status register
    \ Address offset: 0x1C
    \ Reset value: 0x008000C0
    \
    $00 constant LPUAR_PE                       \ [0x00] Parity error
    $01 constant LPUAR_FE                       \ [0x01] Framing error
    $02 constant LPUAR_NE                       \ [0x02] Start bit noise detection flag
    $03 constant LPUAR_ORE                      \ [0x03] Overrun error
    $04 constant LPUAR_IDLE                     \ [0x04] Idle line detected
    $05 constant LPUAR_RXNE                     \ [0x05] Read data register not empty
    $06 constant LPUAR_TC                       \ [0x06] Transmission complete
    $07 constant LPUAR_TXE                      \ [0x07] Transmit data register empty
    $09 constant LPUAR_CTSIF                    \ [0x09] CTS interrupt flag
    $0a constant LPUAR_CTS                      \ [0x0a] CTS flag
    $10 constant LPUAR_BUSY                     \ [0x10] Busy flag
    $11 constant LPUAR_CMF                      \ [0x11] Character match flag
    $12 constant LPUAR_SBKF                     \ [0x12] Send break flag
    $13 constant LPUAR_RWU                      \ [0x13] Receiver wake-up from Mute mode
    $14 constant LPUAR_WUF                      \ [0x14] Wake-up from low-power mode flag
    $15 constant LPUAR_TEACK                    \ [0x15] Transmit enable acknowledge flag
    $16 constant LPUAR_REACK                    \ [0x16] Receive enable acknowledge flag
  [then]


  [ifdef] LPUAR_LPUART_ICR_DEF
    \
    \ @brief LPUART interrupt flag clear register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant LPUAR_PECF                     \ [0x00] Parity error clear flag
    $01 constant LPUAR_FECF                     \ [0x01] Framing error clear flag
    $02 constant LPUAR_NECF                     \ [0x02] Noise detected clear flag
    $03 constant LPUAR_ORECF                    \ [0x03] Overrun error clear flag
    $04 constant LPUAR_IDLECF                   \ [0x04] Idle line detected clear flag
    $06 constant LPUAR_TCCF                     \ [0x06] Transmission complete clear flag
    $09 constant LPUAR_CTSCF                    \ [0x09] CTS clear flag
    $11 constant LPUAR_CMCF                     \ [0x11] Character match clear flag
    $14 constant LPUAR_WUCF                     \ [0x14] Wake-up from low-power mode clear flag
  [then]


  [ifdef] LPUAR_LPUART_RDR_DEF
    \
    \ @brief LPUART receive data register
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant LPUAR_RDR                      \ [0x00 : 9] Receive data value
  [then]


  [ifdef] LPUAR_LPUART_TDR_DEF
    \
    \ @brief LPUART transmit data register
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant LPUAR_TDR                      \ [0x00 : 9] Transmit data value
  [then]


  [ifdef] LPUAR_LPUART_PRESC_DEF
    \
    \ @brief LPUART prescaler register
    \ Address offset: 0x2C
    \ Reset value: 0x00000000
    \
    $00 constant LPUAR_PRESCALER                \ [0x00 : 4] Clock prescaler
  [then]

  \
  \ @brief Low-power universal asynchronous receiver transmitter
  \
  $00 constant LPUAR_LPUART_CR1_ENABLED \ LPUART control register 1
  $00 constant LPUAR_LPUART_CR1_DISABLED    \ LPUART control register 1
  $04 constant LPUAR_LPUART_CR2         \ LPUART control register 2
  $08 constant LPUAR_LPUART_CR3         \ LPUART control register 3
  $0C constant LPUAR_LPUART_BRR         \ LPUART baud rate register
  $18 constant LPUAR_LPUART_RQR         \ LPUART request register
  $1C constant LPUAR_LPUART_ISR_ENABLED \ LPUART interrupt and status register
  $1C constant LPUAR_LPUART_ISR_DISABLED    \ LPUART interrupt and status register
  $20 constant LPUAR_LPUART_ICR         \ LPUART interrupt flag clear register
  $24 constant LPUAR_LPUART_RDR         \ LPUART receive data register
  $28 constant LPUAR_LPUART_TDR         \ LPUART transmit data register
  $2C constant LPUAR_LPUART_PRESC       \ LPUART prescaler register

: LPUAR_DEF ; [then]
