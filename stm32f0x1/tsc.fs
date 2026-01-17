\
\ @file tsc.fs
\ @brief Touch sensing controller
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] TSC_DEF

  [ifdef] TSC_CR_DEF
    \
    \ @brief control register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant TSC_TSCE                       \ [0x00] Touch sensing controller enable
    $01 constant TSC_START                      \ [0x01] Start a new acquisition
    $02 constant TSC_AM                         \ [0x02] Acquisition mode
    $03 constant TSC_SYNCPOL                    \ [0x03] Synchronization pin polarity
    $04 constant TSC_IODEF                      \ [0x04] I/O Default mode
    $05 constant TSC_MCV                        \ [0x05 : 3] Max count value
    $0c constant TSC_PGPSC                      \ [0x0c : 3] pulse generator prescaler
    $0f constant TSC_SSPSC                      \ [0x0f] Spread spectrum prescaler
    $10 constant TSC_SSE                        \ [0x10] Spread spectrum enable
    $11 constant TSC_SSD                        \ [0x11 : 7] Spread spectrum deviation
    $18 constant TSC_CTPL                       \ [0x18 : 4] Charge transfer pulse low
    $1c constant TSC_CTPH                       \ [0x1c : 4] Charge transfer pulse high
  [then]


  [ifdef] TSC_IER_DEF
    \
    \ @brief interrupt enable register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant TSC_EOAIE                      \ [0x00] End of acquisition interrupt enable
    $01 constant TSC_MCEIE                      \ [0x01] Max count error interrupt enable
  [then]


  [ifdef] TSC_ICR_DEF
    \
    \ @brief interrupt clear register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant TSC_EOAIC                      \ [0x00] End of acquisition interrupt clear
    $01 constant TSC_MCEIC                      \ [0x01] Max count error interrupt clear
  [then]


  [ifdef] TSC_ISR_DEF
    \
    \ @brief interrupt status register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant TSC_EOAF                       \ [0x00] End of acquisition flag
    $01 constant TSC_MCEF                       \ [0x01] Max count error flag
  [then]


  [ifdef] TSC_IOHCR_DEF
    \
    \ @brief I/O hysteresis control register
    \ Address offset: 0x10
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant TSC_G1_IO1                     \ [0x00] G1_IO1 Schmitt trigger hysteresis mode
    $01 constant TSC_G1_IO2                     \ [0x01] G1_IO2 Schmitt trigger hysteresis mode
    $02 constant TSC_G1_IO3                     \ [0x02] G1_IO3 Schmitt trigger hysteresis mode
    $03 constant TSC_G1_IO4                     \ [0x03] G1_IO4 Schmitt trigger hysteresis mode
    $04 constant TSC_G2_IO1                     \ [0x04] G2_IO1 Schmitt trigger hysteresis mode
    $05 constant TSC_G2_IO2                     \ [0x05] G2_IO2 Schmitt trigger hysteresis mode
    $06 constant TSC_G2_IO3                     \ [0x06] G2_IO3 Schmitt trigger hysteresis mode
    $07 constant TSC_G2_IO4                     \ [0x07] G2_IO4 Schmitt trigger hysteresis mode
    $08 constant TSC_G3_IO1                     \ [0x08] G3_IO1 Schmitt trigger hysteresis mode
    $09 constant TSC_G3_IO2                     \ [0x09] G3_IO2 Schmitt trigger hysteresis mode
    $0a constant TSC_G3_IO3                     \ [0x0a] G3_IO3 Schmitt trigger hysteresis mode
    $0b constant TSC_G3_IO4                     \ [0x0b] G3_IO4 Schmitt trigger hysteresis mode
    $0c constant TSC_G4_IO1                     \ [0x0c] G4_IO1 Schmitt trigger hysteresis mode
    $0d constant TSC_G4_IO2                     \ [0x0d] G4_IO2 Schmitt trigger hysteresis mode
    $0e constant TSC_G4_IO3                     \ [0x0e] G4_IO3 Schmitt trigger hysteresis mode
    $0f constant TSC_G4_IO4                     \ [0x0f] G4_IO4 Schmitt trigger hysteresis mode
    $10 constant TSC_G5_IO1                     \ [0x10] G5_IO1 Schmitt trigger hysteresis mode
    $11 constant TSC_G5_IO2                     \ [0x11] G5_IO2 Schmitt trigger hysteresis mode
    $12 constant TSC_G5_IO3                     \ [0x12] G5_IO3 Schmitt trigger hysteresis mode
    $13 constant TSC_G5_IO4                     \ [0x13] G5_IO4 Schmitt trigger hysteresis mode
    $14 constant TSC_G6_IO1                     \ [0x14] G6_IO1 Schmitt trigger hysteresis mode
    $15 constant TSC_G6_IO2                     \ [0x15] G6_IO2 Schmitt trigger hysteresis mode
    $16 constant TSC_G6_IO3                     \ [0x16] G6_IO3 Schmitt trigger hysteresis mode
    $17 constant TSC_G6_IO4                     \ [0x17] G6_IO4 Schmitt trigger hysteresis mode
  [then]


  [ifdef] TSC_IOASCR_DEF
    \
    \ @brief I/O analog switch control register
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant TSC_G1_IO1                     \ [0x00] G1_IO1 analog switch enable
    $01 constant TSC_G1_IO2                     \ [0x01] G1_IO2 analog switch enable
    $02 constant TSC_G1_IO3                     \ [0x02] G1_IO3 analog switch enable
    $03 constant TSC_G1_IO4                     \ [0x03] G1_IO4 analog switch enable
    $04 constant TSC_G2_IO1                     \ [0x04] G2_IO1 analog switch enable
    $05 constant TSC_G2_IO2                     \ [0x05] G2_IO2 analog switch enable
    $06 constant TSC_G2_IO3                     \ [0x06] G2_IO3 analog switch enable
    $07 constant TSC_G2_IO4                     \ [0x07] G2_IO4 analog switch enable
    $08 constant TSC_G3_IO1                     \ [0x08] G3_IO1 analog switch enable
    $09 constant TSC_G3_IO2                     \ [0x09] G3_IO2 analog switch enable
    $0a constant TSC_G3_IO3                     \ [0x0a] G3_IO3 analog switch enable
    $0b constant TSC_G3_IO4                     \ [0x0b] G3_IO4 analog switch enable
    $0c constant TSC_G4_IO1                     \ [0x0c] G4_IO1 analog switch enable
    $0d constant TSC_G4_IO2                     \ [0x0d] G4_IO2 analog switch enable
    $0e constant TSC_G4_IO3                     \ [0x0e] G4_IO3 analog switch enable
    $0f constant TSC_G4_IO4                     \ [0x0f] G4_IO4 analog switch enable
    $10 constant TSC_G5_IO1                     \ [0x10] G5_IO1 analog switch enable
    $11 constant TSC_G5_IO2                     \ [0x11] G5_IO2 analog switch enable
    $12 constant TSC_G5_IO3                     \ [0x12] G5_IO3 analog switch enable
    $13 constant TSC_G5_IO4                     \ [0x13] G5_IO4 analog switch enable
    $14 constant TSC_G6_IO1                     \ [0x14] G6_IO1 analog switch enable
    $15 constant TSC_G6_IO2                     \ [0x15] G6_IO2 analog switch enable
    $16 constant TSC_G6_IO3                     \ [0x16] G6_IO3 analog switch enable
    $17 constant TSC_G6_IO4                     \ [0x17] G6_IO4 analog switch enable
  [then]


  [ifdef] TSC_IOSCR_DEF
    \
    \ @brief I/O sampling control register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant TSC_G1_IO1                     \ [0x00] G1_IO1 sampling mode
    $01 constant TSC_G1_IO2                     \ [0x01] G1_IO2 sampling mode
    $02 constant TSC_G1_IO3                     \ [0x02] G1_IO3 sampling mode
    $03 constant TSC_G1_IO4                     \ [0x03] G1_IO4 sampling mode
    $04 constant TSC_G2_IO1                     \ [0x04] G2_IO1 sampling mode
    $05 constant TSC_G2_IO2                     \ [0x05] G2_IO2 sampling mode
    $06 constant TSC_G2_IO3                     \ [0x06] G2_IO3 sampling mode
    $07 constant TSC_G2_IO4                     \ [0x07] G2_IO4 sampling mode
    $08 constant TSC_G3_IO1                     \ [0x08] G3_IO1 sampling mode
    $09 constant TSC_G3_IO2                     \ [0x09] G3_IO2 sampling mode
    $0a constant TSC_G3_IO3                     \ [0x0a] G3_IO3 sampling mode
    $0b constant TSC_G3_IO4                     \ [0x0b] G3_IO4 sampling mode
    $0c constant TSC_G4_IO1                     \ [0x0c] G4_IO1 sampling mode
    $0d constant TSC_G4_IO2                     \ [0x0d] G4_IO2 sampling mode
    $0e constant TSC_G4_IO3                     \ [0x0e] G4_IO3 sampling mode
    $0f constant TSC_G4_IO4                     \ [0x0f] G4_IO4 sampling mode
    $10 constant TSC_G5_IO1                     \ [0x10] G5_IO1 sampling mode
    $11 constant TSC_G5_IO2                     \ [0x11] G5_IO2 sampling mode
    $12 constant TSC_G5_IO3                     \ [0x12] G5_IO3 sampling mode
    $13 constant TSC_G5_IO4                     \ [0x13] G5_IO4 sampling mode
    $14 constant TSC_G6_IO1                     \ [0x14] G6_IO1 sampling mode
    $15 constant TSC_G6_IO2                     \ [0x15] G6_IO2 sampling mode
    $16 constant TSC_G6_IO3                     \ [0x16] G6_IO3 sampling mode
    $17 constant TSC_G6_IO4                     \ [0x17] G6_IO4 sampling mode
  [then]


  [ifdef] TSC_IOCCR_DEF
    \
    \ @brief I/O channel control register
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant TSC_G1_IO1                     \ [0x00] G1_IO1 channel mode
    $01 constant TSC_G1_IO2                     \ [0x01] G1_IO2 channel mode
    $02 constant TSC_G1_IO3                     \ [0x02] G1_IO3 channel mode
    $03 constant TSC_G1_IO4                     \ [0x03] G1_IO4 channel mode
    $04 constant TSC_G2_IO1                     \ [0x04] G2_IO1 channel mode
    $05 constant TSC_G2_IO2                     \ [0x05] G2_IO2 channel mode
    $06 constant TSC_G2_IO3                     \ [0x06] G2_IO3 channel mode
    $07 constant TSC_G2_IO4                     \ [0x07] G2_IO4 channel mode
    $08 constant TSC_G3_IO1                     \ [0x08] G3_IO1 channel mode
    $09 constant TSC_G3_IO2                     \ [0x09] G3_IO2 channel mode
    $0a constant TSC_G3_IO3                     \ [0x0a] G3_IO3 channel mode
    $0b constant TSC_G3_IO4                     \ [0x0b] G3_IO4 channel mode
    $0c constant TSC_G4_IO1                     \ [0x0c] G4_IO1 channel mode
    $0d constant TSC_G4_IO2                     \ [0x0d] G4_IO2 channel mode
    $0e constant TSC_G4_IO3                     \ [0x0e] G4_IO3 channel mode
    $0f constant TSC_G4_IO4                     \ [0x0f] G4_IO4 channel mode
    $10 constant TSC_G5_IO1                     \ [0x10] G5_IO1 channel mode
    $11 constant TSC_G5_IO2                     \ [0x11] G5_IO2 channel mode
    $12 constant TSC_G5_IO3                     \ [0x12] G5_IO3 channel mode
    $13 constant TSC_G5_IO4                     \ [0x13] G5_IO4 channel mode
    $14 constant TSC_G6_IO1                     \ [0x14] G6_IO1 channel mode
    $15 constant TSC_G6_IO2                     \ [0x15] G6_IO2 channel mode
    $16 constant TSC_G6_IO3                     \ [0x16] G6_IO3 channel mode
    $17 constant TSC_G6_IO4                     \ [0x17] G6_IO4 channel mode
  [then]


  [ifdef] TSC_IOGCSR_DEF
    \
    \ @brief I/O group control status register
    \ Address offset: 0x30
    \ Reset value: 0x00000000
    \
    $00 constant TSC_G1E                        \ [0x00] Analog I/O group x enable
    $01 constant TSC_G2E                        \ [0x01] Analog I/O group x enable
    $02 constant TSC_G3E                        \ [0x02] Analog I/O group x enable
    $03 constant TSC_G4E                        \ [0x03] Analog I/O group x enable
    $04 constant TSC_G5E                        \ [0x04] Analog I/O group x enable
    $05 constant TSC_G6E                        \ [0x05] Analog I/O group x enable
    $06 constant TSC_G7E                        \ [0x06] Analog I/O group x enable
    $07 constant TSC_G8E                        \ [0x07] Analog I/O group x enable
    $10 constant TSC_G1S                        \ [0x10] Analog I/O group x status
    $11 constant TSC_G2S                        \ [0x11] Analog I/O group x status
    $12 constant TSC_G3S                        \ [0x12] Analog I/O group x status
    $13 constant TSC_G4S                        \ [0x13] Analog I/O group x status
    $14 constant TSC_G5S                        \ [0x14] Analog I/O group x status
    $15 constant TSC_G6S                        \ [0x15] Analog I/O group x status
    $16 constant TSC_G7S                        \ [0x16] Analog I/O group x status
    $17 constant TSC_G8S                        \ [0x17] Analog I/O group x status
  [then]


  [ifdef] TSC_IOG1CR_DEF
    \
    \ @brief I/O group x counter register
    \ Address offset: 0x34
    \ Reset value: 0x00000000
    \
    $00 constant TSC_CNT                        \ [0x00 : 14] Counter value
  [then]


  [ifdef] TSC_IOG2CR_DEF
    \
    \ @brief I/O group x counter register
    \ Address offset: 0x38
    \ Reset value: 0x00000000
    \
    $00 constant TSC_CNT                        \ [0x00 : 14] Counter value
  [then]


  [ifdef] TSC_IOG3CR_DEF
    \
    \ @brief I/O group x counter register
    \ Address offset: 0x3C
    \ Reset value: 0x00000000
    \
    $00 constant TSC_CNT                        \ [0x00 : 14] Counter value
  [then]


  [ifdef] TSC_IOG4CR_DEF
    \
    \ @brief I/O group x counter register
    \ Address offset: 0x40
    \ Reset value: 0x00000000
    \
    $00 constant TSC_CNT                        \ [0x00 : 14] Counter value
  [then]


  [ifdef] TSC_IOG5CR_DEF
    \
    \ @brief I/O group x counter register
    \ Address offset: 0x44
    \ Reset value: 0x00000000
    \
    $00 constant TSC_CNT                        \ [0x00 : 14] Counter value
  [then]


  [ifdef] TSC_IOG6CR_DEF
    \
    \ @brief I/O group x counter register
    \ Address offset: 0x48
    \ Reset value: 0x00000000
    \
    $00 constant TSC_CNT                        \ [0x00 : 14] Counter value
  [then]

  \
  \ @brief Touch sensing controller
  \
  $00 constant TSC_CR                   \ control register
  $04 constant TSC_IER                  \ interrupt enable register
  $08 constant TSC_ICR                  \ interrupt clear register
  $0C constant TSC_ISR                  \ interrupt status register
  $10 constant TSC_IOHCR                \ I/O hysteresis control register
  $18 constant TSC_IOASCR               \ I/O analog switch control register
  $20 constant TSC_IOSCR                \ I/O sampling control register
  $28 constant TSC_IOCCR                \ I/O channel control register
  $30 constant TSC_IOGCSR               \ I/O group control status register
  $34 constant TSC_IOG1CR               \ I/O group x counter register
  $38 constant TSC_IOG2CR               \ I/O group x counter register
  $3C constant TSC_IOG3CR               \ I/O group x counter register
  $40 constant TSC_IOG4CR               \ I/O group x counter register
  $44 constant TSC_IOG5CR               \ I/O group x counter register
  $48 constant TSC_IOG6CR               \ I/O group x counter register

: TSC_DEF ; [then]
