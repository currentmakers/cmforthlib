\
\ @file spdif_rx.fs
\ @brief Receiver Interface
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] SPDIF_RX_DEF

  [ifdef] SPDIF_RX_CR_DEF
    \
    \ @brief Control register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant SPDIF_RX_SPDIFEN               \ [0x00 : 2] Peripheral Block Enable
    $02 constant SPDIF_RX_RXDMAEN               \ [0x02] Receiver DMA ENable for data flow
    $03 constant SPDIF_RX_RXSTEO                \ [0x03] STerEO Mode
    $04 constant SPDIF_RX_DRFMT                 \ [0x04 : 2] RX Data format
    $06 constant SPDIF_RX_PMSK                  \ [0x06] Mask Parity error bit
    $07 constant SPDIF_RX_VMSK                  \ [0x07] Mask of Validity bit
    $08 constant SPDIF_RX_CUMSK                 \ [0x08] Mask of channel status and user bits
    $09 constant SPDIF_RX_PTMSK                 \ [0x09] Mask of Preamble Type bits
    $0a constant SPDIF_RX_CBDMAEN               \ [0x0a] Control Buffer DMA ENable for control flow
    $0b constant SPDIF_RX_CHSEL                 \ [0x0b] Channel Selection
    $0c constant SPDIF_RX_NBTR                  \ [0x0c : 2] Maximum allowed re-tries during synchronization phase
    $0e constant SPDIF_RX_WFA                   \ [0x0e] Wait For Activity
    $10 constant SPDIF_RX_INSEL                 \ [0x10 : 3] input selection
  [then]


  [ifdef] SPDIF_RX_IMR_DEF
    \
    \ @brief Interrupt mask register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant SPDIF_RX_RXNEIE                \ [0x00] RXNE interrupt enable
    $01 constant SPDIF_RX_CSRNEIE               \ [0x01] Control Buffer Ready Interrupt Enable
    $02 constant SPDIF_RX_PERRIE                \ [0x02] Parity error interrupt enable
    $03 constant SPDIF_RX_OVRIE                 \ [0x03] Overrun error Interrupt Enable
    $04 constant SPDIF_RX_SBLKIE                \ [0x04] Synchronization Block Detected Interrupt Enable
    $05 constant SPDIF_RX_SYNCDIE               \ [0x05] Synchronization Done
    $06 constant SPDIF_RX_IFEIE                 \ [0x06] Serial Interface Error Interrupt Enable
  [then]


  [ifdef] SPDIF_RX_SR_DEF
    \
    \ @brief Status register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant SPDIF_RX_RXNE                  \ [0x00] Read data register not empty
    $01 constant SPDIF_RX_CSRNE                 \ [0x01] Control Buffer register is not empty
    $02 constant SPDIF_RX_PERR                  \ [0x02] Parity error
    $03 constant SPDIF_RX_OVR                   \ [0x03] Overrun error
    $04 constant SPDIF_RX_SBD                   \ [0x04] Synchronization Block Detected
    $05 constant SPDIF_RX_SYNCD                 \ [0x05] Synchronization Done
    $06 constant SPDIF_RX_FERR                  \ [0x06] Framing error
    $07 constant SPDIF_RX_SERR                  \ [0x07] Synchronization error
    $08 constant SPDIF_RX_TERR                  \ [0x08] Time-out error
    $10 constant SPDIF_RX_WIDTH5                \ [0x10 : 15] Duration of 5 symbols counted with SPDIF_CLK
  [then]


  [ifdef] SPDIF_RX_IFCR_DEF
    \
    \ @brief Interrupt Flag Clear register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $02 constant SPDIF_RX_PERRCF                \ [0x02] Clears the Parity error flag
    $03 constant SPDIF_RX_OVRCF                 \ [0x03] Clears the Overrun error flag
    $04 constant SPDIF_RX_SBDCF                 \ [0x04] Clears the Synchronization Block Detected flag
    $05 constant SPDIF_RX_SYNCDCF               \ [0x05] Clears the Synchronization Done flag
  [then]


  [ifdef] SPDIF_RX_DR_DEF
    \
    \ @brief Data input register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant SPDIF_RX_DR                    \ [0x00 : 24] Parity Error bit
    $18 constant SPDIF_RX_PE                    \ [0x18] Parity Error bit
    $19 constant SPDIF_RX_V                     \ [0x19] Validity bit
    $1a constant SPDIF_RX_U                     \ [0x1a] User bit
    $1b constant SPDIF_RX_C                     \ [0x1b] Channel Status bit
    $1c constant SPDIF_RX_PT                    \ [0x1c : 2] Preamble Type
  [then]


  [ifdef] SPDIF_RX_CSR_DEF
    \
    \ @brief Channel Status register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant SPDIF_RX_USR                   \ [0x00 : 16] User data information
    $10 constant SPDIF_RX_CS                    \ [0x10 : 8] Channel A status information
    $18 constant SPDIF_RX_SOB                   \ [0x18] Start Of Block
  [then]


  [ifdef] SPDIF_RX_DIR_DEF
    \
    \ @brief Debug Information register
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant SPDIF_RX_THI                   \ [0x00 : 13] Threshold HIGH
    $10 constant SPDIF_RX_TLO                   \ [0x10 : 13] Threshold LOW
  [then]

  \
  \ @brief Receiver Interface
  \
  $00 constant SPDIF_RX_CR              \ Control register
  $04 constant SPDIF_RX_IMR             \ Interrupt mask register
  $08 constant SPDIF_RX_SR              \ Status register
  $0C constant SPDIF_RX_IFCR            \ Interrupt Flag Clear register
  $10 constant SPDIF_RX_DR              \ Data input register
  $14 constant SPDIF_RX_CSR             \ Channel Status register
  $18 constant SPDIF_RX_DIR             \ Debug Information register

: SPDIF_RX_DEF ; [then]
