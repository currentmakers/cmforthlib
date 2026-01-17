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
    $00 constant LPUART_UE                      \ [0x00] LPUART enable
    $01 constant LPUART_UESM                    \ [0x01] LPUART enable in low-power mode
    $02 constant LPUART_RE                      \ [0x02] Receiver enable
    $03 constant LPUART_TE                      \ [0x03] Transmitter enable
    $04 constant LPUART_IDLEIE                  \ [0x04] IDLE interrupt enable
    $05 constant LPUART_RXFNEIE                 \ [0x05] RXFIFO not empty interrupt enable
    $06 constant LPUART_TCIE                    \ [0x06] Transmission complete interrupt enable
    $07 constant LPUART_TXFNFIE                 \ [0x07] TXFIFO not full interrupt enable
    $08 constant LPUART_PEIE                    \ [0x08] PE interrupt enable
    $09 constant LPUART_PS                      \ [0x09] Parity selection
    $0a constant LPUART_PCE                     \ [0x0a] Parity control enable
    $0b constant LPUART_WAKE                    \ [0x0b] Receiver wake-up method
    $0c constant LPUART_M0                      \ [0x0c] Word length
    $0d constant LPUART_MME                     \ [0x0d] Mute mode enable
    $0e constant LPUART_CMIE                    \ [0x0e] Character match interrupt enable
    $10 constant LPUART_DEDT                    \ [0x10 : 5] Driver Enable deassertion time
    $15 constant LPUART_DEAT                    \ [0x15 : 5] Driver Enable assertion time
    $1c constant LPUART_M1                      \ [0x1c] Word length
    $1d constant LPUART_FIFOEN                  \ [0x1d] FIFO mode enable
    $1e constant LPUART_TXFEIE                  \ [0x1e] TXFIFO empty interrupt enable
    $1f constant LPUART_RXFFIE                  \ [0x1f] RXFIFO Full interrupt enable
  [then]


  [ifdef] LPUART_LPUART_CR1_ALTERNATE1_DEF
    \
    \ @brief LPUART control register 1
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant LPUART_UE                      \ [0x00] LPUART enable
    $01 constant LPUART_UESM                    \ [0x01] LPUART enable in low-power mode
    $02 constant LPUART_RE                      \ [0x02] Receiver enable
    $03 constant LPUART_TE                      \ [0x03] Transmitter enable
    $04 constant LPUART_IDLEIE                  \ [0x04] IDLE interrupt enable
    $05 constant LPUART_RXNEIE                  \ [0x05] Receive data register not empty
    $06 constant LPUART_TCIE                    \ [0x06] Transmission complete interrupt enable
    $07 constant LPUART_TXEIE                   \ [0x07] Transmit data register empty
    $08 constant LPUART_PEIE                    \ [0x08] PE interrupt enable
    $09 constant LPUART_PS                      \ [0x09] Parity selection
    $0a constant LPUART_PCE                     \ [0x0a] Parity control enable
    $0b constant LPUART_WAKE                    \ [0x0b] Receiver wake-up method
    $0c constant LPUART_M0                      \ [0x0c] Word length
    $0d constant LPUART_MME                     \ [0x0d] Mute mode enable
    $0e constant LPUART_CMIE                    \ [0x0e] Character match interrupt enable
    $10 constant LPUART_DEDT                    \ [0x10 : 5] Driver Enable deassertion time
    $15 constant LPUART_DEAT                    \ [0x15 : 5] Driver Enable assertion time
    $1c constant LPUART_M1                      \ [0x1c] Word length
    $1d constant LPUART_FIFOEN                  \ [0x1d] FIFO mode enable
  [then]


  [ifdef] LPUART_LPUART_CR2_DEF
    \
    \ @brief LPUART control register 2
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $04 constant LPUART_ADDM7                   \ [0x04] 7-bit Address Detection/4-bit Address Detection
    $0c constant LPUART_STOP                    \ [0x0c : 2] STOP bits
    $0f constant LPUART_SWAP                    \ [0x0f] Swap TX/RX pins
    $10 constant LPUART_RXINV                   \ [0x10] RX pin active level inversion
    $11 constant LPUART_TXINV                   \ [0x11] TX pin active level inversion
    $12 constant LPUART_DATAINV                 \ [0x12] Binary data inversion
    $13 constant LPUART_MSBFIRST                \ [0x13] Most significant bit first
    $18 constant LPUART_ADD                     \ [0x18 : 8] Address of the LPUART node
  [then]


  [ifdef] LPUART_LPUART_CR3_DEF
    \
    \ @brief LPUART control register 3
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant LPUART_EIE                     \ [0x00] Error interrupt enable
    $03 constant LPUART_HDSEL                   \ [0x03] Half-duplex selection
    $06 constant LPUART_DMAR                    \ [0x06] DMA enable receiver
    $07 constant LPUART_DMAT                    \ [0x07] DMA enable transmitter
    $08 constant LPUART_RTSE                    \ [0x08] RTS enable
    $09 constant LPUART_CTSE                    \ [0x09] CTS enable
    $0a constant LPUART_CTSIE                   \ [0x0a] CTS interrupt enable
    $0c constant LPUART_OVRDIS                  \ [0x0c] Overrun Disable
    $0d constant LPUART_DDRE                    \ [0x0d] DMA Disable on reception Error
    $0e constant LPUART_DEM                     \ [0x0e] Driver enable mode
    $0f constant LPUART_DEP                     \ [0x0f] Driver enable polarity selection
    $14 constant LPUART_WUS0                    \ [0x14] Wake-up from low-power mode interrupt flag selection
    $15 constant LPUART_WUS1                    \ [0x15] Wake-up from low-power mode interrupt flag selection
    $16 constant LPUART_WUFIE                   \ [0x16] Wake-up from low-power mode interrupt enable
    $17 constant LPUART_TXFTIE                  \ [0x17] TXFIFO threshold interrupt enable
    $19 constant LPUART_RXFTCFG                 \ [0x19 : 3] Receive FIFO threshold configuration
    $1c constant LPUART_RXFTIE                  \ [0x1c] RXFIFO threshold interrupt enable
    $1d constant LPUART_TXFTCFG                 \ [0x1d : 3] TXFIFO threshold configuration
  [then]


  [ifdef] LPUART_LPUART_CR3_ALTERNATE1_DEF
    \
    \ @brief LPUART control register 3
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant LPUART_EIE                     \ [0x00] Error interrupt enable
    $03 constant LPUART_HDSEL                   \ [0x03] Half-duplex selection
    $06 constant LPUART_DMAR                    \ [0x06] DMA enable receiver
    $07 constant LPUART_DMAT                    \ [0x07] DMA enable transmitter
    $08 constant LPUART_RTSE                    \ [0x08] RTS enable
    $09 constant LPUART_CTSE                    \ [0x09] CTS enable
    $0a constant LPUART_CTSIE                   \ [0x0a] CTS interrupt enable
    $0c constant LPUART_OVRDIS                  \ [0x0c] Overrun Disable
    $0d constant LPUART_DDRE                    \ [0x0d] DMA Disable on reception Error
    $0e constant LPUART_DEM                     \ [0x0e] Driver enable mode
    $0f constant LPUART_DEP                     \ [0x0f] Driver enable polarity selection
    $14 constant LPUART_WUS0                    \ [0x14] Wake-up from low-power mode interrupt flag selection
    $15 constant LPUART_WUS1                    \ [0x15] Wake-up from low-power mode interrupt flag selection
    $16 constant LPUART_WUFIE                   \ [0x16] Wake-up from low-power mode interrupt enable
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
    $01 constant LPUART_SBKRQ                   \ [0x01] Send break request
    $02 constant LPUART_MMRQ                    \ [0x02] Mute mode request
    $03 constant LPUART_RXFRQ                   \ [0x03] Receive data flush request
    $04 constant LPUART_TXFRQ                   \ [0x04] Transmit data flush request
  [then]


  [ifdef] LPUART_LPUART_ISR_DEF
    \
    \ @brief LPUART interrupt and status register
    \ Address offset: 0x1C
    \ Reset value: 0x008000C0
    \
    $00 constant LPUART_PE                      \ [0x00] Parity error
    $01 constant LPUART_FE                      \ [0x01] Framing error
    $02 constant LPUART_NE                      \ [0x02] Start bit noise detection flag
    $03 constant LPUART_ORE                     \ [0x03] Overrun error
    $04 constant LPUART_IDLE                    \ [0x04] Idle line detected
    $05 constant LPUART_RXFNE                   \ [0x05] RXFIFO not empty
    $06 constant LPUART_TC                      \ [0x06] Transmission complete
    $07 constant LPUART_TXFNF                   \ [0x07] TXFIFO not full
    $09 constant LPUART_CTSIF                   \ [0x09] CTS interrupt flag
    $0a constant LPUART_CTS                     \ [0x0a] CTS flag
    $10 constant LPUART_BUSY                    \ [0x10] Busy flag
    $11 constant LPUART_CMF                     \ [0x11] Character match flag
    $12 constant LPUART_SBKF                    \ [0x12] Send break flag
    $13 constant LPUART_RWU                     \ [0x13] Receiver wake-up from mute mode
    $14 constant LPUART_WUF                     \ [0x14] Wake-up from low-power mode flag
    $15 constant LPUART_TEACK                   \ [0x15] Transmit enable acknowledge flag
    $16 constant LPUART_REACK                   \ [0x16] Receive enable acknowledge flag
    $17 constant LPUART_TXFE                    \ [0x17] TXFIFO Empty
    $18 constant LPUART_RXFF                    \ [0x18] RXFIFO Full
    $1a constant LPUART_RXFT                    \ [0x1a] RXFIFO threshold flag
    $1b constant LPUART_TXFT                    \ [0x1b] TXFIFO threshold flag
  [then]


  [ifdef] LPUART_LPUART_ISR_ALTERNATE1_DEF
    \
    \ @brief LPUART interrupt and status register
    \ Address offset: 0x1C
    \ Reset value: 0x000000C0
    \
    $00 constant LPUART_PE                      \ [0x00] Parity error
    $01 constant LPUART_FE                      \ [0x01] Framing error
    $02 constant LPUART_NE                      \ [0x02] Start bit noise detection flag
    $03 constant LPUART_ORE                     \ [0x03] Overrun error
    $04 constant LPUART_IDLE                    \ [0x04] Idle line detected
    $05 constant LPUART_RXNE                    \ [0x05] Read data register not empty
    $06 constant LPUART_TC                      \ [0x06] Transmission complete
    $07 constant LPUART_TXE                     \ [0x07] Transmit data register empty
    $09 constant LPUART_CTSIF                   \ [0x09] CTS interrupt flag
    $0a constant LPUART_CTS                     \ [0x0a] CTS flag
    $10 constant LPUART_BUSY                    \ [0x10] Busy flag
    $11 constant LPUART_CMF                     \ [0x11] Character match flag
    $12 constant LPUART_SBKF                    \ [0x12] Send break flag
    $13 constant LPUART_RWU                     \ [0x13] Receiver wake-up from mute mode
    $14 constant LPUART_WUF                     \ [0x14] Wake-up from low-power mode flag
    $15 constant LPUART_TEACK                   \ [0x15] Transmit enable acknowledge flag
    $16 constant LPUART_REACK                   \ [0x16] Receive enable acknowledge flag
  [then]


  [ifdef] LPUART_LPUART_ICR_DEF
    \
    \ @brief LPUART interrupt flag clear register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant LPUART_PECF                    \ [0x00] Parity error clear flag
    $01 constant LPUART_FECF                    \ [0x01] Framing error clear flag
    $02 constant LPUART_NECF                    \ [0x02] Noise detected clear flag
    $03 constant LPUART_ORECF                   \ [0x03] Overrun error clear flag
    $04 constant LPUART_IDLECF                  \ [0x04] Idle line detected clear flag
    $06 constant LPUART_TCCF                    \ [0x06] Transmission complete clear flag
    $09 constant LPUART_CTSCF                   \ [0x09] CTS clear flag
    $11 constant LPUART_CMCF                    \ [0x11] Character match clear flag
    $14 constant LPUART_WUCF                    \ [0x14] Wake-up from low-power mode clear flag
  [then]


  [ifdef] LPUART_LPUART_RDR_DEF
    \
    \ @brief LPUART receive data register
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant LPUART_RDR                     \ [0x00 : 9] Receive data value
  [then]


  [ifdef] LPUART_LPUART_TDR_DEF
    \
    \ @brief LPUART transmit data register
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant LPUART_TDR                     \ [0x00 : 9] Transmit data value
  [then]


  [ifdef] LPUART_LPUART_PRESC_DEF
    \
    \ @brief LPUART prescaler register
    \ Address offset: 0x2C
    \ Reset value: 0x00000000
    \
    $00 constant LPUART_PRESCALER               \ [0x00 : 4] Clock prescaler
  [then]

  \
  \ @brief LPUART address block description
  \
  $00 constant LPUART_LPUART_CR1        \ LPUART control register 1
  $00 constant LPUART_LPUART_CR1_ALTERNATE1    \ LPUART control register 1
  $04 constant LPUART_LPUART_CR2        \ LPUART control register 2
  $08 constant LPUART_LPUART_CR3        \ LPUART control register 3
  $08 constant LPUART_LPUART_CR3_ALTERNATE1    \ LPUART control register 3
  $0C constant LPUART_LPUART_BRR        \ LPUART baud rate register
  $18 constant LPUART_LPUART_RQR        \ LPUART request register
  $1C constant LPUART_LPUART_ISR        \ LPUART interrupt and status register
  $1C constant LPUART_LPUART_ISR_ALTERNATE1    \ LPUART interrupt and status register
  $20 constant LPUART_LPUART_ICR        \ LPUART interrupt flag clear register
  $24 constant LPUART_LPUART_RDR        \ LPUART receive data register
  $28 constant LPUART_LPUART_TDR        \ LPUART transmit data register
  $2C constant LPUART_LPUART_PRESC      \ LPUART prescaler register

: LPUART_DEF ; [then]
