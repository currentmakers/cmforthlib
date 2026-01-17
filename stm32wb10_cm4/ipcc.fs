\
\ @file ipcc.fs
\ @brief IPCC
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] IPCC_DEF

  [ifdef] IPCC_C1CR_DEF
    \
    \ @brief Control register CPU1
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant IPCC_RXOIE                     \ [0x00] processor 1 Receive channel occupied interrupt enable
    $10 constant IPCC_TXFIE                     \ [0x10] processor 1 Transmit channel free interrupt enable
  [then]


  [ifdef] IPCC_C1MR_DEF
    \
    \ @brief Mask register CPU1
    \ Address offset: 0x04
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant IPCC_CH1OM                     \ [0x00] processor 1 Receive channel 1 occupied interrupt enable
    $01 constant IPCC_CH2OM                     \ [0x01] processor 1 Receive channel 2 occupied interrupt enable
    $02 constant IPCC_CH3OM                     \ [0x02] processor 1 Receive channel 3 occupied interrupt enable
    $03 constant IPCC_CH4OM                     \ [0x03] processor 1 Receive channel 4 occupied interrupt enable
    $04 constant IPCC_CH5OM                     \ [0x04] processor 1 Receive channel 5 occupied interrupt enable
    $05 constant IPCC_CH6OM                     \ [0x05] processor 1 Receive channel 6 occupied interrupt enable
    $10 constant IPCC_CH1FM                     \ [0x10] processor 1 Transmit channel 1 free interrupt mask
    $11 constant IPCC_CH2FM                     \ [0x11] processor 1 Transmit channel 2 free interrupt mask
    $12 constant IPCC_CH3FM                     \ [0x12] processor 1 Transmit channel 3 free interrupt mask
    $13 constant IPCC_CH4FM                     \ [0x13] processor 1 Transmit channel 4 free interrupt mask
    $14 constant IPCC_CH5FM                     \ [0x14] processor 1 Transmit channel 5 free interrupt mask
    $15 constant IPCC_CH6FM                     \ [0x15] processor 1 Transmit channel 6 free interrupt mask
  [then]


  [ifdef] IPCC_C1SCR_DEF
    \
    \ @brief Status Set or Clear register CPU1
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant IPCC_CH1C                      \ [0x00] processor 1 Receive channel 1 status clear
    $01 constant IPCC_CH2C                      \ [0x01] processor 1 Receive channel 2 status clear
    $02 constant IPCC_CH3C                      \ [0x02] processor 1 Receive channel 3 status clear
    $03 constant IPCC_CH4C                      \ [0x03] processor 1 Receive channel 4 status clear
    $04 constant IPCC_CH5C                      \ [0x04] processor 1 Receive channel 5 status clear
    $05 constant IPCC_CH6C                      \ [0x05] processor 1 Receive channel 6 status clear
    $10 constant IPCC_CH1S                      \ [0x10] processor 1 Transmit channel 1 status set
    $11 constant IPCC_CH2S                      \ [0x11] processor 1 Transmit channel 2 status set
    $12 constant IPCC_CH3S                      \ [0x12] processor 1 Transmit channel 3 status set
    $13 constant IPCC_CH4S                      \ [0x13] processor 1 Transmit channel 4 status set
    $14 constant IPCC_CH5S                      \ [0x14] processor 1 Transmit channel 5 status set
    $15 constant IPCC_CH6S                      \ [0x15] processor 1 Transmit channel 6 status set
  [then]


  [ifdef] IPCC_C1TO2SR_DEF
    \
    \ @brief CPU1 to CPU2 status register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant IPCC_CH1F                      \ [0x00] processor 1 transmit to process 2 Receive channel 1 status flag
    $01 constant IPCC_CH2F                      \ [0x01] processor 1 transmit to process 2 Receive channel 2 status flag
    $02 constant IPCC_CH3F                      \ [0x02] processor 1 transmit to process 2 Receive channel 3 status flag
    $03 constant IPCC_CH4F                      \ [0x03] processor 1 transmit to process 2 Receive channel 4 status flag
    $04 constant IPCC_CH5F                      \ [0x04] processor 1 transmit to process 2 Receive channel 5 status flag
    $05 constant IPCC_CH6F                      \ [0x05] processor 1 transmit to process 2 Receive channel 6 status flag
  [then]


  [ifdef] IPCC_C2CR_DEF
    \
    \ @brief Control register CPU2
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant IPCC_RXOIE                     \ [0x00] processor 2 Receive channel occupied interrupt enable
    $10 constant IPCC_TXFIE                     \ [0x10] processor 2 Transmit channel free interrupt enable
  [then]


  [ifdef] IPCC_C2MR_DEF
    \
    \ @brief Mask register CPU2
    \ Address offset: 0x14
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant IPCC_CH1OM                     \ [0x00] processor 2 Receive channel 1 occupied interrupt enable
    $01 constant IPCC_CH2OM                     \ [0x01] processor 2 Receive channel 2 occupied interrupt enable
    $02 constant IPCC_CH3OM                     \ [0x02] processor 2 Receive channel 3 occupied interrupt enable
    $03 constant IPCC_CH4OM                     \ [0x03] processor 2 Receive channel 4 occupied interrupt enable
    $04 constant IPCC_CH5OM                     \ [0x04] processor 2 Receive channel 5 occupied interrupt enable
    $05 constant IPCC_CH6OM                     \ [0x05] processor 2 Receive channel 6 occupied interrupt enable
    $10 constant IPCC_CH1FM                     \ [0x10] processor 2 Transmit channel 1 free interrupt mask
    $11 constant IPCC_CH2FM                     \ [0x11] processor 2 Transmit channel 2 free interrupt mask
    $12 constant IPCC_CH3FM                     \ [0x12] processor 2 Transmit channel 3 free interrupt mask
    $13 constant IPCC_CH4FM                     \ [0x13] processor 2 Transmit channel 4 free interrupt mask
    $14 constant IPCC_CH5FM                     \ [0x14] processor 2 Transmit channel 5 free interrupt mask
    $15 constant IPCC_CH6FM                     \ [0x15] processor 2 Transmit channel 6 free interrupt mask
  [then]


  [ifdef] IPCC_C2SCR_DEF
    \
    \ @brief Status Set or Clear register CPU2
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant IPCC_CH1C                      \ [0x00] processor 2 Receive channel 1 status clear
    $01 constant IPCC_CH2C                      \ [0x01] processor 2 Receive channel 2 status clear
    $02 constant IPCC_CH3C                      \ [0x02] processor 2 Receive channel 3 status clear
    $03 constant IPCC_CH4C                      \ [0x03] processor 2 Receive channel 4 status clear
    $04 constant IPCC_CH5C                      \ [0x04] processor 2 Receive channel 5 status clear
    $05 constant IPCC_CH6C                      \ [0x05] processor 2 Receive channel 6 status clear
    $10 constant IPCC_CH1S                      \ [0x10] processor 2 Transmit channel 1 status set
    $11 constant IPCC_CH2S                      \ [0x11] processor 2 Transmit channel 2 status set
    $12 constant IPCC_CH3S                      \ [0x12] processor 2 Transmit channel 3 status set
    $13 constant IPCC_CH4S                      \ [0x13] processor 2 Transmit channel 4 status set
    $14 constant IPCC_CH5S                      \ [0x14] processor 2 Transmit channel 5 status set
    $15 constant IPCC_CH6S                      \ [0x15] processor 2 Transmit channel 6 status set
  [then]


  [ifdef] IPCC_C2TOC1SR_DEF
    \
    \ @brief CPU2 to CPU1 status register
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant IPCC_CH1F                      \ [0x00] processor 2 transmit to process 1 Receive channel 1 status flag
    $01 constant IPCC_CH2F                      \ [0x01] processor 2 transmit to process 1 Receive channel 2 status flag
    $02 constant IPCC_CH3F                      \ [0x02] processor 2 transmit to process 1 Receive channel 3 status flag
    $03 constant IPCC_CH4F                      \ [0x03] processor 2 transmit to process 1 Receive channel 4 status flag
    $04 constant IPCC_CH5F                      \ [0x04] processor 2 transmit to process 1 Receive channel 5 status flag
    $05 constant IPCC_CH6F                      \ [0x05] processor 2 transmit to process 1 Receive channel 6 status flag
  [then]

  \
  \ @brief IPCC
  \
  $00 constant IPCC_C1CR                \ Control register CPU1
  $04 constant IPCC_C1MR                \ Mask register CPU1
  $08 constant IPCC_C1SCR               \ Status Set or Clear register CPU1
  $0C constant IPCC_C1TO2SR             \ CPU1 to CPU2 status register
  $10 constant IPCC_C2CR                \ Control register CPU2
  $14 constant IPCC_C2MR                \ Mask register CPU2
  $18 constant IPCC_C2SCR               \ Status Set or Clear register CPU2
  $1C constant IPCC_C2TOC1SR            \ CPU2 to CPU1 status register

: IPCC_DEF ; [then]
