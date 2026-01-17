\
\ @file pssi.fs
\ @brief Parallel synchronous slave interface
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] PSSI_DEF

  [ifdef] PSSI_PSSI_CR_DEF
    \
    \ @brief PSSI control register
    \ Address offset: 0x00
    \ Reset value: 0x40000000
    \
    $05 constant PSSI_CKPOL                     \ [0x05] Parallel data clock polarity This bit configures the capture edge of the parallel clock or the edge used for driving outputs, depending on OUTEN.
    $06 constant PSSI_DEPOL                     \ [0x06] Data enable (PSSI_DE) polarity This bit indicates the level on the PSSI_DE pin when the data are not valid on the parallel interface.
    $08 constant PSSI_RDYPOL                    \ [0x08] Ready (PSSI_RDY) polarity This bit indicates the level on the PSSI_RDY pin when the data are not valid on the parallel interface.
    $0a constant PSSI_EDM                       \ [0x0a : 2] Extended data mode
    $0e constant PSSI_ENABLE                    \ [0x0e] PSSI enable The contents of the FIFO are flushed when ENABLE is cleared to 0. Note: When ENABLE=1, the content of PSSI_CR must not be changed, except for the ENABLE bit itself. All configuration bits can change as soon as ENABLE changes from 0 to 1. Note: The DMA controller and all PSSI configuration registers must be programmed correctly before setting the ENABLE bit to 1.
    $12 constant PSSI_DERDYCFG                  \ [0x12 : 3] Data enable and ready configuration When the PSSI_RDY function is mapped to the PSSI_DE pin (settings 101 or 111), it is still the RDYPOL bit which determines its polarity. Similarly, when the PSSI_DE function is mapped to the PSSI_RDY pin (settings 110 or 111), it is still the DEPOL bit which determines its polarity.
    $1d constant PSSI_CKSRC                     \ [0x1d] Clock source This bit configures the clock source of the PSSI_PDCK.
    $1e constant PSSI_DMAEN                     \ [0x1e] DMA enable bit
    $1f constant PSSI_OUTEN                     \ [0x1f] Data direction selection bit
  [then]


  [ifdef] PSSI_PSSI_SR_DEF
    \
    \ @brief PSSI status register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $02 constant PSSI_RTT4B                     \ [0x02] FIFO is ready to transfer four bytes
    $03 constant PSSI_RTT1B                     \ [0x03] FIFO is ready to transfer one byte
  [then]


  [ifdef] PSSI_PSSI_RIS_DEF
    \
    \ @brief PSSI raw interrupt status register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $01 constant PSSI_OVR_RIS                   \ [0x01] Data buffer overrun/underrun raw interrupt status This bit is cleared by writing a 1 to the OVR_ISC bit in PSSI_ICR.
  [then]


  [ifdef] PSSI_PSSI_IER_DEF
    \
    \ @brief PSSI interrupt enable register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $01 constant PSSI_OVR_IE                    \ [0x01] Data buffer overrun/underrun interrupt enable
  [then]


  [ifdef] PSSI_PSSI_MIS_DEF
    \
    \ @brief PSSI masked interrupt status register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $01 constant PSSI_OVR_MIS                   \ [0x01] Data buffer overrun/underrun masked interrupt status This bit is set to 1 only when PSSI_IER/OVR_IE and PSSI_RIS/OVR_RIS are both set to 1.
  [then]


  [ifdef] PSSI_PSSI_ICR_DEF
    \
    \ @brief PSSI interrupt clear register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $01 constant PSSI_OVR_ISC                   \ [0x01] Data buffer overrun/underrun interrupt status clear Writing this bit to 1 clears the OVR_RIS bit in PSSI_RIS.
  [then]


  [ifdef] PSSI_PSSI_DR_DEF
    \
    \ @brief PSSI data register
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant PSSI_BYTE0                     \ [0x00 : 8] Data byte 0
    $08 constant PSSI_BYTE1                     \ [0x08 : 8] Data byte 1
    $10 constant PSSI_BYTE2                     \ [0x10 : 8] Data byte 2
    $18 constant PSSI_BYTE3                     \ [0x18 : 8] Data byte 3
  [then]

  \
  \ @brief Parallel synchronous slave interface
  \
  $00 constant PSSI_PSSI_CR             \ PSSI control register
  $04 constant PSSI_PSSI_SR             \ PSSI status register
  $08 constant PSSI_PSSI_RIS            \ PSSI raw interrupt status register
  $0C constant PSSI_PSSI_IER            \ PSSI interrupt enable register
  $10 constant PSSI_PSSI_MIS            \ PSSI masked interrupt status register
  $14 constant PSSI_PSSI_ICR            \ PSSI interrupt clear register
  $28 constant PSSI_PSSI_DR             \ PSSI data register

: PSSI_DEF ; [then]
