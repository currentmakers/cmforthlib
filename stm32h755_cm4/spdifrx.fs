\
\ @file spdifrx.fs
\ @brief Receiver Interface
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] SPDIFRX_DEF

  [ifdef] SPDIFRX_CR_DEF
    \
    \ @brief Control register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant SPDIFRX_SPDIFRXEN              \ [0x00 : 2] Peripheral Block Enable
    $02 constant SPDIFRX_RXDMAEN                \ [0x02] Receiver DMA ENable for data flow
    $03 constant SPDIFRX_RXSTEO                 \ [0x03] STerEO Mode
    $04 constant SPDIFRX_DRFMT                  \ [0x04 : 2] RX Data format
    $06 constant SPDIFRX_PMSK                   \ [0x06] Mask Parity error bit
    $07 constant SPDIFRX_VMSK                   \ [0x07] Mask of Validity bit
    $08 constant SPDIFRX_CUMSK                  \ [0x08] Mask of channel status and user bits
    $09 constant SPDIFRX_PTMSK                  \ [0x09] Mask of Preamble Type bits
    $0a constant SPDIFRX_CBDMAEN                \ [0x0a] Control Buffer DMA ENable for control flow
    $0b constant SPDIFRX_CHSEL                  \ [0x0b] Channel Selection
    $0c constant SPDIFRX_NBTR                   \ [0x0c : 2] Maximum allowed re-tries during synchronization phase
    $0e constant SPDIFRX_WFA                    \ [0x0e] Wait For Activity
    $10 constant SPDIFRX_INSEL                  \ [0x10 : 3] input selection
    $14 constant SPDIFRX_CKSEN                  \ [0x14] Symbol Clock Enable
    $15 constant SPDIFRX_CKSBKPEN               \ [0x15] Backup Symbol Clock Enable
  [then]


  [ifdef] SPDIFRX_IMR_DEF
    \
    \ @brief Interrupt mask register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant SPDIFRX_RXNEIE                 \ [0x00] RXNE interrupt enable
    $01 constant SPDIFRX_CSRNEIE                \ [0x01] Control Buffer Ready Interrupt Enable
    $02 constant SPDIFRX_PERRIE                 \ [0x02] Parity error interrupt enable
    $03 constant SPDIFRX_OVRIE                  \ [0x03] Overrun error Interrupt Enable
    $04 constant SPDIFRX_SBLKIE                 \ [0x04] Synchronization Block Detected Interrupt Enable
    $05 constant SPDIFRX_SYNCDIE                \ [0x05] Synchronization Done
    $06 constant SPDIFRX_IFEIE                  \ [0x06] Serial Interface Error Interrupt Enable
  [then]


  [ifdef] SPDIFRX_SR_DEF
    \
    \ @brief Status register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant SPDIFRX_RXNE                   \ [0x00] Read data register not empty
    $01 constant SPDIFRX_CSRNE                  \ [0x01] Control Buffer register is not empty
    $02 constant SPDIFRX_PERR                   \ [0x02] Parity error
    $03 constant SPDIFRX_OVR                    \ [0x03] Overrun error
    $04 constant SPDIFRX_SBD                    \ [0x04] Synchronization Block Detected
    $05 constant SPDIFRX_SYNCD                  \ [0x05] Synchronization Done
    $06 constant SPDIFRX_FERR                   \ [0x06] Framing error
    $07 constant SPDIFRX_SERR                   \ [0x07] Synchronization error
    $08 constant SPDIFRX_TERR                   \ [0x08] Time-out error
    $10 constant SPDIFRX_WIDTH5                 \ [0x10 : 15] Duration of 5 symbols counted with SPDIF_CLK
  [then]


  [ifdef] SPDIFRX_IFCR_DEF
    \
    \ @brief Interrupt Flag Clear register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $02 constant SPDIFRX_PERRCF                 \ [0x02] Clears the Parity error flag
    $03 constant SPDIFRX_OVRCF                  \ [0x03] Clears the Overrun error flag
    $04 constant SPDIFRX_SBDCF                  \ [0x04] Clears the Synchronization Block Detected flag
    $05 constant SPDIFRX_SYNCDCF                \ [0x05] Clears the Synchronization Done flag
  [then]


  [ifdef] SPDIFRX_DR_00_DEF
    \
    \ @brief Data input register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant SPDIFRX_DR                     \ [0x00 : 24] Parity Error bit
    $18 constant SPDIFRX_PE                     \ [0x18] Parity Error bit
    $19 constant SPDIFRX_V                      \ [0x19] Validity bit
    $1a constant SPDIFRX_U                      \ [0x1a] User bit
    $1b constant SPDIFRX_C                      \ [0x1b] Channel Status bit
    $1c constant SPDIFRX_PT                     \ [0x1c : 2] Preamble Type
  [then]


  [ifdef] SPDIFRX_DR_01_DEF
    \
    \ @brief Data input register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant SPDIFRX_PE                     \ [0x00] Parity Error bit
    $01 constant SPDIFRX_V                      \ [0x01] Validity bit
    $02 constant SPDIFRX_U                      \ [0x02] User bit
    $03 constant SPDIFRX_C                      \ [0x03] Channel Status bit
    $04 constant SPDIFRX_PT                     \ [0x04 : 2] Preamble Type
    $08 constant SPDIFRX_DR                     \ [0x08 : 24] Data value
  [then]


  [ifdef] SPDIFRX_DR_10_DEF
    \
    \ @brief Data input register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant SPDIFRX_DRNL1                  \ [0x00 : 16] Data value
    $10 constant SPDIFRX_DRNL2                  \ [0x10 : 16] Data value
  [then]


  [ifdef] SPDIFRX_CSR_DEF
    \
    \ @brief Channel Status register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant SPDIFRX_USR                    \ [0x00 : 16] User data information
    $10 constant SPDIFRX_CS                     \ [0x10 : 8] Channel A status information
    $18 constant SPDIFRX_SOB                    \ [0x18] Start Of Block
  [then]


  [ifdef] SPDIFRX_DIR_DEF
    \
    \ @brief Debug Information register
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant SPDIFRX_THI                    \ [0x00 : 13] Threshold HIGH
    $10 constant SPDIFRX_TLO                    \ [0x10 : 13] Threshold LOW
  [then]


  [ifdef] SPDIFRX_VERR_DEF
    \
    \ @brief SPDIFRX version register
    \ Address offset: 0x3F4
    \ Reset value: 0x00000012
    \
    $00 constant SPDIFRX_MINREV                 \ [0x00 : 4] Minor revision
    $04 constant SPDIFRX_MAJREV                 \ [0x04 : 4] Major revision
  [then]


  [ifdef] SPDIFRX_IDR_DEF
    \
    \ @brief SPDIFRX identification register
    \ Address offset: 0x3F8
    \ Reset value: 0x00130041
    \
    $00 constant SPDIFRX_ID                     \ [0x00 : 32] SPDIFRX identifier
  [then]


  [ifdef] SPDIFRX_SIDR_DEF
    \
    \ @brief SPDIFRX size identification register
    \ Address offset: 0x3FC
    \ Reset value: 0xA3C5DD01
    \
    $00 constant SPDIFRX_SID                    \ [0x00 : 32] Size identification
  [then]

  \
  \ @brief Receiver Interface
  \
  $00 constant SPDIFRX_CR               \ Control register
  $04 constant SPDIFRX_IMR              \ Interrupt mask register
  $08 constant SPDIFRX_SR               \ Status register
  $0C constant SPDIFRX_IFCR             \ Interrupt Flag Clear register
  $10 constant SPDIFRX_DR_00            \ Data input register
  $10 constant SPDIFRX_DR_01            \ Data input register
  $10 constant SPDIFRX_DR_10            \ Data input register
  $14 constant SPDIFRX_CSR              \ Channel Status register
  $18 constant SPDIFRX_DIR              \ Debug Information register
  $3F4 constant SPDIFRX_VERR            \ SPDIFRX version register
  $3F8 constant SPDIFRX_IDR             \ SPDIFRX identification register
  $3FC constant SPDIFRX_SIDR            \ SPDIFRX size identification register

: SPDIFRX_DEF ; [then]
